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


## Application Installation
* _First make sure you have the .NET Core installed for your operating system. If you are unsure go here https://dotnet.microsoft.com/download/dotnet-core/2.2. Find the right version for you and install._
* _Visit the following link: https://github.com/thekidnamedkd/PierresLogin.Solution_
* _Clone the repository to your desired directory._
* _Use the terminal to navigate into to PierresLogin.Solution_
* _Once inside the folder, navigate further to the Bakery folder via the terminal._
* _There you can use the command ```$dotnet restore``` to add the necessary system files to the application._
* _Then you can use the command ```$dotnet ef database update``` to create a MySQL database for the pplication._
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

### Running the program:
1. In your command line terminal, type `cd Desktop` then navigate to project folder using `cd ParkFinder.Solution`
2. To run the program, you'll need navigate to the project folder by entering `cd Parks`, then to compile the code enter: `dotnet restore`. This will create a compiled application in the bin/ folder.  Do not touch the files in the bin/ or obj/ folders, you will not need to and the application will not run as intended.
3. You can then run the program directly with `dotnet run` while still within the TravelApi directory.


### OpenAPI Documentation:
For further documentation and exploration of our API, see the SwaggerUI here while the app is running:
<http://localhost:5000/swagger/index.html#/>


## Known Bugs

_No known bugs._


## Support and contact details

_Please reach out through my GitHub account._


## Technologies Used

C#
ASP/.NET
Entity
MySQL Workbench
Swagger
VSCode


### License

Copyright (c) 2020 **_Kevin Davis_**   
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

*Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:*

*The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.*

*THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.*