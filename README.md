# Rocket_Elevators_REST_API

Rest_Api developped for Rocket Elevators by team Miguel MArtin

https://rocketrest.azurewebsites.net/

You can make and access all our beautiful and wonderful request with the following routes :

https://rocketrest.azurewebsites.net/api/batteries  -- it will "get" you all you need to know for the batteries in the database.

https://rocketrest.azurewebsites.net/api/batteries/{id}  -- it will "get" you all you need to know for a specific battery in the database. You will also be able to "put" a new satus if you need to.

https://rocketrest.azurewebsites.net/api/columns  -- it will "get" you all you need to know for the columns in the database.

https://rocketrest.azurewebsites.net/api/columns/{id}  -- it will "get" you all you need to know for a specific column in the database. You will also be able to "put" a new satus if you need to.

https://rocketrest.azurewebsites.net/api/elevators  -- it will "get" you all you need to know for the elevators in the database.

https://rocketrest.azurewebsites.net/api/elevators/{id}  -- it will "get" you all you need to know for a specific elevator in the database. You will also be able to "put" a new satus if you need to.

https://rocketrest.azurewebsites.net/api/elevatorsStatus -- it will "get" you all the elevators that are not active at the moment

https://rocketrest.azurewebsites.net/api/elevatorsStatus -- it will "get" you all the elevators that are not active at the moment

https://rocketrest.azurewebsites.net/api/buildings/intervention -- it will "get" you all the buildings in wich there is an intervention at the moment

https://rocketrest.azurewebsites.net/api/leads/under30 -- it will "get" you the leads wich were made less than 30 days ago and wich aren't connected to a current customers. Please note that we made it work without adding a customer_id to our lead table ;););)


You can also use all the other routes that were build in this api, wich you can find inside the controllers
