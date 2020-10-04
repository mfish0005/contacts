# Contacts

## Getting Started

To get everything running you need a few things installed.

Install Node if you don't already have it.

To run the client app you'll need the Angular CLI: `npm install -g @angular/cli`

To run the database you'll need Docker and Docker Compose installed.  If you're on Windows or OSX `docker-compose` is installed automatically when you install Docker now.

You'll need the dotnet CLI which is installed automatically when you install Dotnet Core.

You need `dotnet ef` to deploy the migrations: `dotnet tool install --global dotnet-ef`.


## Database

1. `cd` into the `ContactsApi` directory and run `docker-compose build` to build the postgres image.

2. Run `docker-compose up` to start the postgres container or `docker-compose up -d` if you don't mind it running in the background.

3. The database should be running now. Time to deploy the migrations.  Run `dotnet ef database update` and cross your fingers.

## API
1. Now that the db is working let's start the thing up.  Still need to `docker-compose` the API itself.  For now just run the API the old fashioned way with `dotnet run`.

## Client

1. `cd` into `contacts-client` and run `npm install`.

2. Run `npm start` or `ng serve` to launch the app.

3. Go to `localhost:4200` to view the app.