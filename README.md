# Rocket-Elevators-REST

**In this week, we learned how to:**

Create a web API project.
Add a model class and a database context.
Scaffold a controller with CRUD methods.
Configure routing, URL paths, and return values.
Call the web API with Postman.

**We did this by following this documentation:**

https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-3.1&tabs=visual-studio-code

and 

https://docs.microsoft.com/en-us/azure/devops/pipelines/targets/deploy-to-azure-vscode?view=azure-devops


**In the code, you will be able to use the API to do the following:**

Retrieve the current status of a specific Battery

GET https://rocket-elevators-rest-2022.herokuapp.com/api/battery/1/status

Change the status of a specific Battery

PUT https://rocket-elevators-rest-2022.herokuapp.com/api/battery/1

Retrieve the current status of a specific Column

GET https://rocket-elevators-rest-2022.herokuapp.com/api/column/1/status

Change the status of a specific Column

PUT https://rocket-elevators-rest-2022.herokuapp.com/api/column/1

Retrieve the current status of a specific Elevator

GET https://rocket-elevators-rest-2022.herokuapp.com/api/elevator/1/status

Change the status of a specific Elevator

PUT https://rocket-elevators-rest-2022.herokuapp.com/api/elevator/1

Retrieve a list of Elevators that are not in operation at the time of the request

GET https://rocket-elevators-rest-2022.herokuapp.com/api/elevator/broken

Retrieve a list of Buildings that contain at least one battery, column or elevator requiring intervention

GET https://rocket-elevators-rest-2022.herokuapp.com/api/building/interventions

Retrieve a list of Leads created in the last 30 days who have not yet become customers.

GET https://rocket-elevators-rest-2022.herokuapp.com/api/lead/notcustomer

**put more here after finishing the project
