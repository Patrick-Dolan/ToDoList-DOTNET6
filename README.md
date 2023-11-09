# To-do list

#### By _**Patrick Dolan**_

#### _A small To-do list built with .NET 6._

## Technologies Used

* _C#_
* _.NET 6_
* _MSTest_

## Description

This project is a basic To-do list built with .NET 6 to update my knowledge of the "learnhowtoprogram.com" lessons that I teach for Fidgetech. 

The project, in its current state, now allows you to create categories and attach items to them. You can't create Items without an attached category. 

## Set up/Installation Requirements

### How to download and run the project

1. Open a terminal/command prompt and navigate to the directory where you want to store the project. Use the following GIT command to clone the project repository:

```bash
git clone https://github.com/Patrick-Dolan/ToDoList-DOTNET6
```

- Alternatively, you can download the project using the green "Code" button at the top of the GitHub page that the project is located on. Then, click the Download ZIP button on the dropdown to save the project to your computer. Once you have downloaded the zip file you will need to unzip it and move on to step two.

2. Now that you have the project files you will need to navigate to the ```ToDoList-DOTNET6 folder```. Once inside this folder navigate to the `ToDoList`.Solution``` folder and run the following command to download the project dependencies:

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