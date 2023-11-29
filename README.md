# To-do list

#### By _**Patrick Dolan**_

#### _A small To-do list built with .NET 6._

## Technologies Used

* C#
* .NET 6
* MSTest
* Entity Framework Core
* MySQL Workbench

## Description

This project is a basic To-do list built with .NET 6 to update my knowledge of the "learnhowtoprogram.com" lessons that I teach for Fidgetech. 

The project, in its current state, now allows you to create categories and attach items to them. You can't create Items without an attached category. 

## Set up/Installation Requirements

### How to Download the Project

Choose one of the following methods to download the project:

#### Method 1: Clone the Repository

1. Open a terminal/command prompt and navigate to the directory where you want to store the project.
2. Use the following Git command to clone the project repository:

```bash
git clone https://github.com/Patrick-Dolan/ToDoList-DOTNET6
```

This will create a local copy of the project in your chosen directory.

#### Method 2: Download as ZIP

1. Alternatively, you can download the project directly from the GitHub page.
2. Click on the green "Code" button at the top of the GitHub page.
3. Choose "Download ZIP" from the dropdown menu.
4. Save the ZIP file to your computer.
5. Unzip the downloaded file to extract the project files.

Regardless of the method you choose, proceed to the next set of instructions to set up the database and configure the project.

### How to set up the database

_The following instructions assume you have downloaded the project to your computer and have MySQL Workbench._

1. Ensure that you have Entity Framework Core (EF Core) tools installed globally. If not, you can install it using the following command:

```bash
dotnet tool install --global dotnet-ef --version 6.0.0
```


2. Navigate to the production project directory: ToDoList-DOTNET6/ToDoList/ and create a new file named appsettings.json. This file will contain the connection string for your database.
  - ```[YOUR-USER-HERE]``` with your username
  - ```[YOUR-PASSWORD-HERE]``` with your password

3. Add the following contents to your newly created appsettings.json file, replacing the placeholders with your information:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=to_do_list_with_ef_core;uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```

For example, your ```appsettings.json``` might look like this:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=to_do_list_with_ef_core;uid=adalovelace;pwd=theCountessKing1;"
  }
}
```

4. Open a terminal and run the following command to apply EF Core migrations and create the database:

```bash
dotnet ef database update
```

This will automatically apply any pending migrations and create the database using the connection string specified in appsettings.json.

### How to run the project

_The following instructions assume you have downloaded the project to your computer._

1. Now that you have the project files you will need to navigate to the ```ToDoList-DOTNET6``` folder. Once inside this folder navigate to the ```ToDoList``` folder and run the following command to download the project dependencies:

```bash
dotnet restore
```

2. Now that you have downloaded the dependencies you will need to run the following command to build the project:

```bash
dotnet build
```

3. Once the build is complete the final step is to run the project using the following command:

```bash
dotnet run
```

- **Note: the URL where you can view the application in your web browser should show up in the terminal.**
- Alternatively, if you are working on developing features for the project you can run the command ```dotnet watch run``` which will reload the project as you make changes.

### How to run the project tests

#### _TESTS CURRENTLY DO NOT WORK_

1. Open the project on your editor/terminal of choice.
2. Navigate to ```ToDoList.Tests``` directory in your terminal
3. Run the following command to download the project dependencies and set up testing:

```bash
dotnet restore
```

4. Now you can run the tests in your terminal with the following command:

```bash
dotnet test
```

## Known Bugs

* No known issues

## License

[MIT](./LICENSE.txt)

Copyright (c) _2023_ _Patrick Dolan_ 