# Business Contacts

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
1. Now that the db is working let's start the thing up.  I didn't have time to `docker-compose` the API itself.  I just open up Visual Studio and run it through IIS.  Works on my machine ;)

## Client

1. `cd` into `contacts-client` and run `npm install`.

2. Run `npm start` or `ng serve` to launch the app.

3. Go to `localhost:4200` to view the app.

### Known Issues

1. After creating/editing a contact for the first time the UI sometimes won't show the contact. Reload the page and it should be there
2. PrimeNG's virtual scroller(the library I used for the contact list) has a "feature" where it's lazy loading event is called twice when a component loads.  This caused the first page of contacts to be loaded twice.  To get around this I hardcoded the paged endpoint's `pageSize` to sync it with PrimeNG's `event.first` property.  Makes the urls of my paged endpoint look weird but it mostly fixes it for now.