using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using Nhom9.Docker_Kubernet.Demo.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nhom9.Docker_Kubernet.Demo.DL.Database
{
    public class MongoDatabaseContext : IDatabaseContext
    {
        private readonly IMongoDatabase _mongoDatabase;
        private readonly IMongoClient _mongoClient;
        private readonly ILogger<MongoDatabaseContext> _logger;

        public MongoDatabaseContext(ILogger<MongoDatabaseContext> logger, IDatabaseSettings settings)
        {
            _logger = logger;
            try
            {
                _mongoClient = new MongoClient(/*settings.ConnectionString*/"mongodb://root:11111111@104.248.149.21:31029/?authSource=admin&readPreference=primary&appname=MongoDB%20Compass&ssl=false");
                _mongoDatabase = _mongoClient.GetDatabase(/*settings.DatabaseName*/"Demo_Docker_Kubernet");
            }
            catch (Exception ex)
            {
                _logger.LogError($"\nError while connecting to MongoDB: {ex}\n");
            }
        }

        public IMongoDatabase MongoDatabase { get => _mongoDatabase; }
    }
}
