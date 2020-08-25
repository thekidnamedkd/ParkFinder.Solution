# _Park Finder API_

![Glacier National Park](https://c.na84.content.force.com/servlet/servlet.ImageServer?id=01550000001kmeG&oid=00D50000000JMrK&lastMod=1441214314000)

#### _C# Week 6 Independent Project_

#### By _**Kevin Davis**_


## Description

_A RESTful API application in C# with MVC design pattern to document national and state parks in the United States. The application uses a SQL database to store and manipulate data._


## Software/Installation Requirements
* Install [Git v2.62.2+](https://git-scm.com/downloads/)
* Install [.NET version 3.1 SDK v2.2+](https://dotnet.microsoft.com/download/dotnet-core/2.2)
* Install [Visual Studio Code](https://code.visualstudio.com/)
* Install [MySql Workbench](https://www.mysql.com/products/workbench/)
* Install [Postman](https://www.postman.com/downloads/)


## Application Installation
* _First make sure you have the .NET Core installed for your operating system. If you are unsure go here https://dotnet.microsoft.com/download/dotnet-core/2.2. Find the right OS version for you and install._
* _Visit the following link: https://github.com/thekidnamedkd/ParkFinder.Solution_
* _Clone the repository to your desired directory._
* _Use the terminal to navigate into to ParkFinder.Solution_
* _Once inside the folder, navigate further to the Bakery folder via the terminal._
* _There you can use the command ```$dotnet restore``` to add the necessary system files to the application._
* _Then you can use the command ```$dotnet ef database update``` to create a MySQL database for the application._
* _Once that is complete you can run ```$dotnet run``` to launch the application._
* _If the program successfully launches you should be able to go to http://localhost:5000/ to view the project._


## Database Setup/Migration

* The sample database for this project is seeded from the code in ParksContext.cs
* You need to create an appsettings.json file in ParkFinder.Solution/Parks and it should follow this format:

```{
  "AppSettings": {
    "Secret": "super_secret_big_key_value_secret"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=<DATABASE>;uid=<U
    SER>;pwd=<PASSWORD>;"
  }
}
```

* Once this is setup properly, you can run:

```
dotnet ef migrations add Initial
```
followed by:

```
dotnet ef database update
```
## Running the program
* In your command line terminal, type `cd Desktop` then navigate to project folder using `cd ParkFinder.Solution`
* To run the program, you'll need navigate to the project folder by entering `cd Parks`, then to compile the code enter: `dotnet restore`. This will create a compiled application in the bin/ folder.  Do not touch the files in the bin/ or obj/ folders, you will not need to and the application will not run as intended.
* You can then run the program directly with `dotnet run` while still within the TravelApi directory.

## Using JSON Tokenization
This application contains JWT authentication. In order to acccess your token for further authorization follow these steps:

* Open Postman and create a POST request using the following URL: http://localhost:5000/users/authenticate
* As JSON and raw data, add the following query to the Body tab of Postman:
```
{
  "Username": "test",
  "Password": "test" 
}
```
* You should see a token generated in the response. You can use this for further access to the application as more authorization is added to the API in the future.

## Pagination
This application has the ability to return it's broad results with pagination. Follow these steps to access it:

* Open Postman and create a GET request using the following URL: http://localhost:5000/api/nationals/pages?pageSize=2&pageNumber=1
* You can change the number of results by changing the value of pageSize.
* You can change to the proper page number depending how many results are broken into pages by change the value of pageNumber.


## OpenAPI Documentation with Swagger
For further documentation and exploration of this API, see the SwaggerUI by entering the following URL into your browswer of choice while the application is running:
<http://localhost:5000/swagger/index.html#/>


## Known Bugs

_No known bugs._


## Support and Contact Details

_For questions, comments, or collaboration contact me at thekidnamedkd@gmail.com_


## Technologies Used

C#
ASP/.NET Core 2.2
Entity
SQL
MySQL Workbench
Swagger
VSCode


## License

Copyright (c) 2020 **_Kevin Davis_**   
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
