using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using MongoDB.Driver;
using Nhom9.Docker_Kubernet.Demo.DL.Database;
using Nhom9.Docker_Kubernet.Demo.Entity.DTO;
using Nhom9.Docker_Kubernet.Demo.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom9.Docker_Kubernet.Demo.DL.Repositories
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(IDatabaseContext databaseContext) : base(databaseContext)
        {
        }

        public UserDTO AuthenticateUser(string username, string password)
        {
            var user = _collection.AsQueryable().Where(u => u.Username == username).FirstOrDefault();
            if (user == null) return null;
            var saltDB = user.Salt;
            var hashedPassword = HashPassWord(saltDB, password);
            if (hashedPassword != user.HashedPassword){ return null;  }

            return new UserDTO { 
                UserID = user.UserID,
                Fullname = user.Fullname,
                Password = null,
                Username = user.Username
            };
        }

        private string HashPassWord(string saltDB, string password)
        {
            byte[] salt = System.Convert.FromBase64String(saltDB);
            Console.WriteLine($"Salt: {Convert.ToBase64String(salt)}");

            // derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));
            Console.WriteLine($"Hashed: {hashed}");
            return hashed;
        }

        public async Task<string> UpdateUser(User user)
        {
            await _collection.ReplaceOneAsync(u => u.UserID == user.UserID, user);
            return user.UserID;
        }
    }
}
