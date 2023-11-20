# To-do list

#### By _**Patrick Dolan**_

#### _A small To-do list built with .NET 6._

## Technologies Used

* _C#_
* _.NET 6_
* _MSTest_
* _Entity Framework Core_
* _MySQL Workbench_

## Description

This project is a basic To-do list built with .NET 6 to update my knowledge of the "learnhowtoprogram.com" lessons that I teach for Fidgetech. 

The project, in its current state, now allows you to create categories and attach items to them. You can't create Items without an attached category. 

## Set up/Installation Requirements

### How to set up the database

1. Create a new file in the production project directory: ```ToDoList/``` and call it ```appsettings.json```. This file will hold the connection string for your database.

2. Add the following contents to your newly created ```appsettings.json``` file, replacing the following values with your own:
  - ```[YOUR-USER-HERE]``` with your username
  - ```[YOUR-PASSWORD-HERE]``` with your password

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

3. Now you will need to launch MySQL Workbench and open your local instance. On the left side of the window is the navigator pane and at the bottom of that is a tab labeled ```Administration```. Select that tab to show the options needed to import this project's database. 

4. Select the ```Data Import/Restore``` option to launch the window needed to import the database.

5. In Import Options select ```Import from Self-Contained File``` and navigate to this project's root directory to select the database file: ```to_do_list_with_ef_core.sql```. Then click ok.

6. After you are finished with the above steps, reopen the navigator ```Schemas``` tab. Right-click and select Refresh All. The database should appear in the list of Schemas.

### How to download and run the project

1. Open a terminal/command prompt and navigate to the directory where you want to store the project. Use the following GIT command to clone the project repository:

```bash
git clone https://github.com/Patrick-Dolan/ToDoList-DOTNET6
```

- Alternatively, you can download the project using the green "Code" button at the top of the GitHub page that the project is located on. Then, click the Download ZIP button on the dropdown to save the project to your computer. Once you have downloaded the zip file you will need to unzip it and move on to step two.

2. Now that you have the project files you will need to navigate to the ```ToDoList-DOTNET6``` folder. Once inside this folder navigate to the ```ToDoList``` folder and run the following command to download the project dependencies:

```bash
dotnet restore
```

3. Now that you have downloaded the dependencies you will need to run the following command to build the project:

```bash
dotnet build
```

4. Once the build is complete the final step is to run the project using the following command:

```bash
dotnet run
```

- **Note: the URL where you can view the application in your web browser should show up in the terminal.**
- Alternatively, if you are working on developing features for the project you can run the command ```dotnet watch run``` which will reload the project as you make changes.

### How to run the project tests

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

MIT

Copyright (c) _2023_ _Patrick Dolan_ 