# copy csproj and restore as distinct layers
FROM mcr.microsoft.com/dotnet/core/sdk:3.1-nanoserver-1803 AS build-env
WORKDIR /app
COPY WeatherForecast.Api/*.csproj ./
RUN dotnet restore

# copy everything else and build app
COPY WeatherForecast.Api/. ./
RUN dotnet publish -c Release -o out

# Build static files (angular)
FROM stefanscherer/node-windows:10.15 AS angular-build
WORKDIR /app
COPY weather-forecast-client/. ./
RUN npm install
RUN npm run build-local -- --output-path wwwroot

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-nanoserver-1803
WORKDIR /app
COPY --from=angular-build /app/wwwroot ./wwwroot
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "WeatherForecast.Api.dll"]
