# Build stage
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

COPY VideoGameAPI/*.csproj ./VideoGameAPI/
RUN dotnet restore VideoGameAPI/VideoGameAPI.csproj

COPY VideoGameAPI/. ./VideoGameAPI/
RUN dotnet publish VideoGameAPI/VideoGameAPI.csproj -c Release -o /app/publish

# Runtime
FROM mcr.microsoft.com/dotnet/aspnet:9.0 
WORKDIR /app
EXPOSE 8080
COPY --from=build /app/publish ./

ENTRYPOINT ["dotnet", "VideoGameAPI.dll"]