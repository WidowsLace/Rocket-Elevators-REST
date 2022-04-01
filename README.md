# Rocket Elevators REST API

In this week, we learned how to:

Create a web API project

Add a model class and a database context

Scaffold a controller with CRUD methods

Configure routing, URL paths, and return values

Call the web API with Postman

## Installation

Use the [heroku](https://dashboard.heroku.com/apps) platform to deploy.

Since we used c# as our language, you will have to add the c# buildpack. 

```bash
heroku buildpacks:set jincod/dotnetcore
```

## Usage

Click on the links to view and change the statuses.

[GET](https://rocket-elevators-rest-2022.herokuapp.com/api/battery/1/status) 
 the current status of a specific Battery

[PUT](https://rocket-elevators-rest-2022.herokuapp.com/api/battery/1)
 the status of a specific Battery

[GET](https://rocket-elevators-rest-2022.herokuapp.com/api/column/1/status)
the current status of a specific Column

[PUT](https://rocket-elevators-rest-2022.herokuapp.com/api/column/1)
 the status of a specific Column

[GET](https://rocket-elevators-rest-2022.herokuapp.com/api/elevator/1/status)
the current status of a specific Elevator

[PUT](https://rocket-elevators-rest-2022.herokuapp.com/api/elevator/1)
the status of a specific Elevator

[GET](https://rocket-elevators-rest-2022.herokuapp.com/api/elevator/broken)
a list of Elevators that are not in operation at the time of the request

[GET](https://rocket-elevators-rest-2022.herokuapp.com/api/building/interventions)
a list of Buildings that contain at least one battery, column or elevator requiring intervention

[GET](https://rocket-elevators-rest-2022.herokuapp.com/api/lead/notcustomer)
 a list of Leads created in the last 30 days who have not yet become customers.

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## Members
Michael D'Amico

Troy Wever

Hayleigh Hevener

## Documentation 
We used the following websites to build this project:

[microsoft web api docs](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-3.1&tabs=visual-studio-code)

[heroku docs](https://devcenter.heroku.com/categories/reference)

[Microsoft LINQ Docs](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq-queries)
