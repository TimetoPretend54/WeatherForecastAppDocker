# WeatherForecastAppDocker

WeatherForecast prototype application utilizing .NET Core, Angular, SQL Server, containerized by utilizing Docker Containers (DockerCompose.yml &amp; Dockerfile).

## Running Application

_**NOTE:**_

- [Docker Desktop](https://www.docker.com/products/docker-desktop) must be installed
- Docker Desktop must be utilizing [Linux Containers](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers)

1. Run in Powershell
   ```
   docker-compose up
   ```
2. Once everything is built and created, Navigate to
   ```
   http://localhost:8080
   ```

## Exiting Application

1. Type `Ctrl-C` in Powershell Window running `docker-compose`
2. In the same powershell window:
   ```
   docker-compose down
   ```
   - `--rmi` will remove images, if desired, for more info see [docker-compose down docs](https://docs.docker.com/compose/reference/down/)
