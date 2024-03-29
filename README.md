# WeatherForecastAppDocker

WeatherForecast prototype application utilizing .NET Core, Angular, SQL Server, containerized by utilizing Docker Containers (DockerCompose.yml &amp; Dockerfile).

## Running Application

_**NOTE:**_

- [Docker Desktop](https://www.docker.com/products/docker-desktop) must be installed
- Docker Desktop must be utilizing [Linux Containers](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers)

1. Run in Terminal
   ```
   docker-compose up
   ```
2. Once everything is built and created, Navigate to
   ```
   http://localhost:8080
   ```

## Exiting Application

1. Type `Ctrl-C` in Terminal Window running `docker-compose`
2. In the same Terminal window:
   ```
   docker-compose down
   ```
   - `--rmi` will remove images, if desired, for more info see [docker-compose down docs](https://docs.docker.com/compose/reference/down/)

## Accessing Database

Utilizing whatever Database for accessing SQL infrastructure, connect to the DB w/ the following info:

```
Server Name: localhost,1433

Auth: SQL Server Authentication
User/Login: sa
Password: Sample123
```

Helpful Database Tools:

- [SQL Server Management Studio](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15)
- [Azure Data Studio](https://docs.microsoft.com/en-us/sql/azure-data-studio/download-azure-data-studio?view=sql-server-ver15)
