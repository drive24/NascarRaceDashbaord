# Nascar Races Dashboard

## Architecture

The architecture using in this application is the typical SPA (Single Page Application) using Blazor WebAssembly. The application is divided in 3 main projects:

- UI &rarr; The Blazor WebAssembly application.
- API &rarr; The ASP.NET Core Web API.
- Shared &rarr; The shared project between the UI and API projects for the models.

The API will serve data from Nascar to the SPA.

## Development Environment

- JetBrains Rider IDE
- Ubuntu Linux 22.04
- Firefox Browser
- Postman &rarr; Testing API calls

## Logging

Used Third Party `Serilog` Logger to write to external file with a day of rollover.

## How to run the application

Import the solution in Visual Studio 2022 or Rider and run the api project and then ui project.

## TODOs:

- Add menu to pick different years to display in the dashboard.
- UI should use an abstraction/SDK to call the API from Blazor.
