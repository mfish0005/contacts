
# Contacts



## Summary

This is basically an example of how I might build an Angular/Dotnet Core app. Noteworthy pieces include:

- An ORM agnostic service layer
- A generic paged list implementation for returning paged results from the API
- An implementation of PrimeNG's `VirtualScroller` component using a paged endpoint to lazy load items indefinitely.
- Custom exceptions in Dotnet Core and an exception filter
- A local implementation of my fish-common library including examples of a reusable feature module, reusable business logic encapsulated in a utilities module, and a basic implementation of my documented SCSS library
- [NLog](https://nlog-project.org/) implementation for logging warnings, errors, etc.


## Getting Started



If you want to run the app locally this is what you need:



Install Node if you don't have it.



To run the client app you'll need the Angular CLI: `npm install -g @angular/cli`



To run the database you'll need Docker and Docker Compose installed.



To run the server you'll need the dotnet CLI which is installed automatically when you install Dotnet Core.



You need `dotnet ef` to deploy the migrations: `dotnet tool install --global dotnet-ef`.




## Database



1. Make sure you're in the root folder E.G. `cd contacts`.



2. Run `docker-compose build` to build the Postgres image.



3. Run `docker-compose up` or `docker-compose up -d` to start the database container.



4. The database should be running now. Time to deploy the migrations. `cd` into the `Contacts.Api` folder and run `dotnet ef database update`.




## API



1. `cd` into the server directory E.G. `cd contacts-server/Contact.Api`.



2. Run `dotnet restore` to restore dependencies.



3. Get the API running at `http://localhost:5000` using `dotnet run`.



## Client



1. `cd` into `contacts-client` and run `npm install`.



2. To build the helper libraries you need to be in the fish-common project's root: `cd projects/fish-common`



3. Run `ng build projects/fish-common` and `cd` back into the `contacts-client` directory



4. Run `npm start` or `ng serve` to launch the app.



5. Go to `localhost:4200` to view the app.



6. To view the contacts you'll need to register an account with Okta using their self service registration form.  You can get there by clicking the log in/register button in the top right corner.
