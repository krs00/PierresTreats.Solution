# Pierre's Sweet and Savory Treats

#### This is an application for marketing sweet and savory treats and Pierre's Bakery!

#### By Kymani Stephens

## Technologies Used

* C#
* .NET
* SQL
* Entity Framework Core
* ASP.NET Core
* Pomelo Entity Framework Core
* EF Core Migrations


## Description

Welcome to Pierre's Sweet and Savory Treats! This MVC application serves as your gateway to discovering Pierre's exquisite range of delectable treats. With user authentication and a user-friendly interface, this application aims to deliver a personalized experience to all of Pierre's customers!

## Setup/Installation

### Install Tools

Install the tools that are introduced in [this series of lessons on LearnHowToProgram.com](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c).

### Set up the Databases

Follow the instructions in the LearnHowToProgram.com lesson ["Creating a Test Database: Exporting and Importing Databases with MySQL Workbench"](https://www.learnhowtoprogram.com/c-and-net/database-basics/creating-a-test-database-exporting-and-importing-databases-with-mysql-workbench) to use the `bakery.sql` file located at the top level of this repo to create a new database in MySQL Workbench with the name `bakery`. 

### Set Up and Run Project

1. Clone this repo.
2. Open the terminal and navigate to this project's production directory called "Factory".
3. Turn on "autosave" in VScode (Or your current IDE).
4. Build the database with `dotnet ef database update` command.
5. Within the production directory "HairSalon", create a new file called `appsettings.json`.
6. Within `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL.

```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=bakery;uid=[YOUR-USERNAME];pwd=[YOUR-PASSWORD];"
  }
}
```

7. Within the production directory "Bakery", run `dotnet watch run` in the command line to start the project in development mode with a watcher.
8. Open the browser to _https://localhost:5001_. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: [Redirecting to HTTPS and Issuing a Security Certificate](https://www.learnhowtoprogram.com/lessons/redirecting-to-https-and-issuing-a-security-certificate).

## Known Bugs

* No currently known bugs

## License
[MIT](https://opensource.org/license/mit) 
<br>
Copyright (c) 2023 Kymani Stephens