#!/bin/sh

sleep 15s

/opt/mssql-tools/bin/sqlcmd -S . -U sa -P Sample123 \
-Q "CREATE DATABASE [WeatherForecast] ON (FILENAME = '/var/opt/sqlserver/WeatherForecast.mdf'),(FILENAME = '/var/opt/sqlserver/WeatherForecast_log.ldf') FOR ATTACH"

## NOTE: When creating a .sh file, if using VS Code/Sublime/Notepad++, make
## sure once done to save as LF (Unix) and NOT CR LF (Windows), this can be
## done via Notepad++ (see https://stackoverflow.com/questions/27810758/how-to-replace-crlf-with-lf-in-a-single-file/54245311#54245311)