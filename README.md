# Eau Claire's Salon

A C# website utlizing EFCore framework where you can add a list of stylists working at a salon, and for each stylist, add clients who see that stylist. The stylists have specific specialties, so each client can only see/belong to a single stylist.
#### Authored by Erika Debelis

## Technologies Used

* _C#_
* _MySQL_
* _MySQL Workbench_
* _.NET 5 SDK_
* _Git BASH_
* _ASP .NET CORE MVC_
* _My SQL Designer_

![Screenshot](screenshot.png)
_(a visual representation of the MySQL database used for this project)_

## Setup/Installation Requirements

1. Download or clone the https://github.com/ErikaDebelis/HairSalon.Solution to your local machine

2. Open git BASH terminal and navigate to the HairSalon.Solution of the directory

3. Run "dotnet restore" in the git BASH terminal to install dependencies
    ``$ dotnet restore``

4. Create your own version of the database by importing the erikadebelis.sql file from the repo with MySQL Workbench.

5. Create appsettings.json file in the HairSalon directory of HairSalon.Solution and add the following code to the file: ``touch appsettings.json``
```
{
  "ConnectionStrings":
  {
    "DefaultConnection": "Server=localhost;Port=3306;database=hair_salon;uid={YOUR_USERNAME_NAME};pwd={YOUR_PASSWORD};"
  }
}
```
Be sure to remove the ``{YOUR_USERNAME_NAME}`` and ``{YOUR_PASSWORD}`` and fill in the the code snippet with your username for MySQL, and MySQL password _Do not include the curly brackets in your code snippet of appsettings.json_

6. Run "dotnet run" in the git BASH terminal to  minify the code, and run the project in the terminal.
    ``$ dotnet watch run``
7. View the website by visiting localhost:5000/ in a new web browser( such as google chrome) tab!

## Bugs

_no known bugs at this time_

## License

_MIT_

_Copyright (c) 2021 Erika Debelis_

if any issues are discovered while navigating the site, please let me know! It will help me learn and grow!

## Contact Information

Erika Debelis _erika.debelis@gmail.com_