# SalesCloud
A sales data cloud application for exposing Rest APIs for posting,getting and updating sales data.
Web API is hosted as Azure Service on Url http://helixsalesapi.azurewebsites.net.

POST Url : POST http://helixsalesapi.azurewebsites.net/api/sales

GET Sale object Within Range URL Example
: http://helixsalesapi.azurewebsites.net/api/sales/range=2016-03-10T16:00:00.153|2016-05-10T16:00:00.153

Get all Sale objects : GET http://helixsalesapi.azurewebsites.net/api/sales

Authentication and Authorization is completely implemented using Owin Katana modules.
We are using JWTTokenBearer implementation.

The API's have been tested on the POSTMAN tool.

API Service is complete. Due to time limitations, not able to complete the Sample client completely and 
few validations are are not added.