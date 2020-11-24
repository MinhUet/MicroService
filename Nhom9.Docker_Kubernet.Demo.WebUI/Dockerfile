#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Nhom9.Docker_Kubernet.Demo.WebUI/Nhom9.Docker_Kubernet.Demo.WebUI.csproj", "Nhom9.Docker_Kubernet.Demo.WebUI/"]
COPY ["Nhom9.Docker_Kubernet.Demo.AuthenticationService/Nhom9.Docker_Kubernet.Demo.AuthenticationService.csproj", "Nhom9.Docker_Kubernet.Demo.AuthenticationService/"]
RUN dotnet restore "Nhom9.Docker_Kubernet.Demo.WebUI/Nhom9.Docker_Kubernet.Demo.WebUI.csproj"
COPY . .
WORKDIR "/src/Nhom9.Docker_Kubernet.Demo.WebUI"
RUN dotnet build "Nhom9.Docker_Kubernet.Demo.WebUI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Nhom9.Docker_Kubernet.Demo.WebUI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Nhom9.Docker_Kubernet.Demo.WebUI.dll"]