


//create profileservice image : 
docker build -t .

//run sql server in a container
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=hello@123" -e "MSSQL_PID=Express" -p 1433:1433 --name serversql -d mcr.microsoft.com/mssql/server:2019-latest

//run ProfileService Project in a container
docker run --name profileservice --link serversql:serversql -e "ServerName=serversql" -e "Database=GratiMeet" -e "UserName=SA" -e "Password=hello@123" -p 80:80 profileservice

//docker.compose.yml
docker-compose up

//For POST localhost/api/profile : 
    {
        "id": 5,
        "firstNmae": "Ilyes",
        "lastName": "Grati",
        "gender": "H",
        "birthDate": "1998-06-09T00:00:00"
    }
