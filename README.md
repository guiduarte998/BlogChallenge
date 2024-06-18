# BlogChallenge

This is a simple blogging platform API built with ASP.NET Core WebAPI. It allows users to manage blog posts and their associated comments.

## Prerequisites
Before you begin, ensure you have met the following requirements:

.NET 6 SDK or later installed on your machine.
Visual Studio or Visual Studio Code with the C# extension.
Sql Server Management Studio 2019.

## Getting Started

To get a local copy up and running, follow these simple steps:

**'git clone https://github.com/guiduarte998/BlogChallenge.git
cd blogging-platform-api'**

After that you need to change your __`connection string`__ in the __`application.json`__ file, because when running the migrations, the `EntityFramework` will access your database and create the tables necessary(BlogPost and Comments).

## Running Migrations

To run the migrations you jsut need two commands (Using the Package Manager Console):
**add-migration InitialDB** and **update-database**

If you are going to use the `Developer PowerShell`, use those commands:
**dotnet ef migrations add InitialCreate** and **dotnet ef database update**

And you are good to go! Running the application will open the `Swagger` page and from there you can test all endpoints.

## Next Steps

### If I had more time for this challenge I would probably do some "upgrades" on it, like:

#### Add Unit Tests: Implement unit tests for the repository and controller methods using a testing framework like xUnit or NUnit.
#### Implement Pagination: Add pagination to the `GET /api/posts` endpoint to handle a large number of blog posts efficiently.
#### Add Validation: Enhance request validation using FluentValidation or data annotations to ensure data integrity.
#### User Authentication: Implement user authentication and authorization to restrict access to certain endpoints.
#### Improve Error Handling: Add more comprehensive error handling and logging to provide better insights into application behavior.
#### Create some UI, to make everything more User Friendly
#### Deploy to Cloud: Deploy the application to a cloud service like Azure or AWS for production use.

For a 4 hours exercise it's a pretty solid application that would do exactly what's expected to do, create a Blog and Comments relation.

