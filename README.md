
# Contacts



## Summary

This is basically an example of how I might build an Angular/Dotnet Core app. Noteworthy pieces include:

- An ORM agnostic service layer
- A generic paged list implementation for returning paged results from the API
- An implementation of PrimeNG's `VirtualScroller` component using a paged endpoint to lazy load items indefinitely.
- Custom exceptions in Dotnet Core and an exception filter
- [NLog](https://nlog-project.org/) implementation for logging warnings, errors, etc.



## Getting Started



If you want to run the app locally this is what you need:



Install Node if you don't already have it.



To run the client app you'll need the Angular CLI: `npm install -g @angular/cli`



To run the database you'll need Docker and Docker Compose installed.



You'll need the dotnet CLI which is installed automatically when you install Dotnet Core.



You need `dotnet ef` to deploy the migrations: `dotnet tool install --global dotnet-ef`.




## Database



1. Run `docker-compose build` to build the Postgres image.



2. Run `docker-compose up` or `docker-compose up -d` to start the container.



3. The database should be running now. Time to deploy the migrations. Run `dotnet ef database update`.



## API

1. Now that the db is working let's start the API. For now just run the API the old fashioned way with `dotnet run`.



## Client



1. `cd` into `contacts-client` and run `npm install`.



2. Run `npm start` or `ng serve` to launch the app.



3. Go to `localhost:4200` to view the app.