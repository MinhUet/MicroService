#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Nhom9.Docker_Kubernet.Demo.Admin/Nhom9.Docker_Kubernet.Demo.UserService.csproj", "Nhom9.Docker_Kubernet.Demo.Admin/"]
COPY ["Nhom9.Docker_Kubernet.Demo.Common/Nhom9.Docker_Kubernet.Demo.Common.csproj", "Nhom9.Docker_Kubernet.Demo.Common/"]
COPY ["Nhom9.Docker_Kubernet.Demo.AuthenticationService/Nhom9.Docker_Kubernet.Demo.AuthenticationService.csproj", "Nhom9.Docker_Kubernet.Demo.AuthenticationService/"]
COPY ["Nhom9.Docker_Kubernet.Demo.DL/Nhom9.Docker_Kubernet.Demo.DL.csproj", "Nhom9.Docker_Kubernet.Demo.DL/"]
COPY ["Nhom9.Docker_Kubernet.Demo.Entity/Nhom9.Docker_Kubernet.Demo.Entity.csproj", "Nhom9.Docker_Kubernet.Demo.Entity/"]
RUN dotnet restore "Nhom9.Docker_Kubernet.Demo.Admin/Nhom9.Docker_Kubernet.Demo.UserService.csproj"
COPY . .
WORKDIR "/src/Nhom9.Docker_Kubernet.Demo.Admin"
RUN dotnet build "Nhom9.Docker_Kubernet.Demo.UserService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Nhom9.Docker_Kubernet.Demo.UserService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Nhom9.Docker_Kubernet.Demo.UserService.dll"]