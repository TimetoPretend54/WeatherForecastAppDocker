# base this image of the SQL 2017 latest image
FROM mcr.microsoft.com/mssql/server:2017-latest

# make a directory within the container
RUN mkdir /var/opt/sqlserver

# copy attach-db.sh into container
COPY attach-db.sh /var/opt/sqlserver/attach-db.sh

# copy database files into container
COPY ./SqlData /var/opt/sqlserver

# Grant permissions for the import-data script to be executable
RUN chmod +x /var/opt/sqlserver/attach-db.sh

# use the ENTRYPOINT command to execute the script and start SQL Server
ENTRYPOINT /var/opt/sqlserver/attach-db.sh & /opt/mssql/bin/sqlservr
