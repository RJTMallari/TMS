# Train Management System (TMS)

A web-based Train Management System developed using ASP.NET Core and React.

## Description

Transit Management System (TMS) is a full-stack web application designed to provide commuters with an interactive way to explore Metro Manila's railway network. The application allows users to view railway lines on an interactive map, browse stations, and access important station information such as first and last train schedules, transfer stations, and station locations.

The project consists of a React and TypeScript frontend that communicates with an ASP.NET Core Web API backend. Station and railway data are stored in a SQL Server database and managed using Entity Framework Core. The frontend uses Leaflet to display an interactive map, allowing users to visualize railway lines and station locations.

TMS also includes a secure authentication system using JSON Web Tokens (JWT). Authenticated users can access the Station Management page, where station information can be added, edited, or updated through a simple administrative interface. This demonstrates the use of RESTful API endpoints, database operations, and protected routes within a modern web application.

Although inspired by my undergraduate thesis project, Rail-O, TMS was developed independently as a new implementation using the programming concepts and technologies learned throughout CS50x. Rather than relying on low-code development tools, this project was built from the ground up using JavaScript/TypeScript, React, ASP.NET Core, Entity Framework Core, and SQL Server, providing valuable experience in designing and developing a complete full-stack application.

## Features

The Transit Management System (TMS) provides several features that demonstrate both frontend and backend web development concepts.

### Interactive Railway Map

* Displays Metro Manila railway lines using an interactive Leaflet map.
* Allows users to visualize station locations and navigate the railway network.
* Automatically adjusts the map view based on the selected rail line.

### Railway Line Selection

* Users can choose between different railway lines.
* Station markers and route information update dynamically based on the selected line.

### Station Information

* View detailed information for each station, including:

  * Station name
  * Railway line
  * First train schedule
  * Last train schedule
  * Transfer station availability
  * Geographic location

### Station Management

Authenticated users can manage station information through an administrative interface.

Functions include:

* View all stations
* Edit station details
* Update first and last train schedules
* Modify transfer station information
* Save changes directly to the SQL Server database using REST API endpoints

### User Authentication

* Secure login using JSON Web Tokens (JWT).
* Protected routes prevent unauthorized users from accessing the Station Management page.
* Authentication state is maintained while the user is logged in.

### RESTful Web API

The frontend communicates with an ASP.NET Core Web API to:

* Retrieve railway lines
* Retrieve station information
* Update station records
* Authenticate users

### Database Integration

* Uses SQL Server as the relational database.
* Entity Framework Core handles database access and object-relational mapping (ORM).
* Railway lines and station information are stored in normalized database tables.

### Progressive Web Application (PWA)

* TMS can be installed on supported devices as a Progressive Web Application.
* Provides a more app-like experience while running in the browser.

### Responsive Interface

* The user interface is designed to adapt to different screen sizes, making the application usable on both desktop and mobile devices.

## Technical Overview

The Transit Management System (TMS) follows a client-server architecture. The frontend is built with React and TypeScript, while the backend is developed using ASP.NET Core Web API. Communication between the frontend and backend is performed through RESTful API endpoints, allowing the application to retrieve and update railway and station information.

Station and railway data are stored in a SQL Server database and managed using Entity Framework Core, which simplifies database operations through object-relational mapping (ORM). The backend exposes endpoints for retrieving railway lines, viewing station information, updating station records, and authenticating users.

User authentication is implemented using JSON Web Tokens (JWT). After a successful login, the server issues a token that is stored on the client and included in subsequent requests to access protected resources such as the Station Management page. This ensures that only authenticated users can perform administrative actions.

The frontend uses the Leaflet mapping library to visualize railway lines and station locations. When a user selects a railway line, the application dynamically loads the corresponding stations from the backend and updates the interactive map. Users can then select individual stations to view information such as first and last train schedules and transfer availability.

Throughout the project, I focused on separating responsibilities between the frontend, backend, and database. This structure made the application easier to maintain and allowed me to gain practical experience working with a modern full-stack web development workflow.

## Challenges

Developing TMS was significantly more challenging than any project I had previously built because it required me to integrate multiple technologies into a single application. Although I had prior experience creating Rail-O using FlutterFlow, building TMS from scratch meant that I needed to understand how each part of a full-stack application communicates with one another.

One of the biggest challenges was learning React and TypeScript while simultaneously developing the frontend. Understanding component-based architecture, state management, and API communication required a different way of thinking compared to low-code development. Connecting the frontend to an ASP.NET Core Web API also introduced concepts such as asynchronous requests, JSON serialization, and RESTful API design.

On the backend, I learned how to use Entity Framework Core to interact with a SQL Server database. Designing the database schema, creating models, configuring relationships, and debugging validation errors helped me better understand how data flows between the application and the database. I also implemented JWT authentication to secure administrative functionality, which introduced me to user authentication, authorization, and protected routes.

Another challenge was integrating Leaflet into the application to display railway stations on an interactive map. I needed to ensure that station markers updated correctly whenever a different railway line was selected while keeping the interface responsive and easy to use.

Perhaps the most valuable lesson from this project was learning how to debug problems systematically. Throughout development, I encountered issues ranging from API errors and database validation problems to frontend rendering bugs. Solving these problems taught me the importance of reading error messages, testing components individually, and making incremental improvements instead of trying to solve everything at once.

Overall, TMS transformed my understanding of web development. It allowed me to move beyond low-code platforms and gain practical experience building a complete full-stack application from the ground up using modern web technologies.

## Future Improvements

Although the Transit Management System is fully functional, there are several features that I would like to implement in the future.

One improvement would be to integrate real-time train information using live transit data so that commuters can view current train locations, service disruptions, and estimated arrival times. I would also like to expand the application by adding fare computation, route planning, and support for additional railway and public transportation systems.

From an administrative perspective, I plan to implement role-based access control so that different users have different levels of permissions instead of sharing the same administrative privileges. Improving the overall user interface and adding more detailed station information, such as facilities and accessibility features, would also enhance the user experience.

Finally, I would like to deploy the application publicly with a production database so that it can be used by commuters as a practical transit information system. This project has given me a strong foundation in full-stack web development, and I hope to continue improving it as I gain more experience.

## How to Run

### Prerequisites

Before running the project, make sure the following are installed:

* .NET 8 SDK
* Node.js
* SQL Server
* Visual Studio 2022 or Visual Studio Code (optional)

### Clone the Repository

```bash
git clone https://github.com/RJTMallari/TMS.git
cd TMS
```

### Configure the Database

Update the SQL Server connection string in the backend project's `appsettings.json` file to match your local SQL Server instance.

Run the Entity Framework Core migrations to create the database.

### Start the Backend

Navigate to the `TMS.Server` directory and run:

```bash
dotnet run
```

The ASP.NET Core Web API will start and expose the API endpoints.

### Start the Frontend

Open another terminal and navigate to the `TMS.Client` directory.

Install the required packages:

```bash
npm install
```

Start the React development server:

```bash
npm run dev
```

Open the URL displayed in the terminal (typically `http://localhost:5173`) to access the application.

### Login

Use the configured administrator account to access the Station Management page and perform CRUD operations on station data.

To access the administrative features, use the following demo account:

Username: admin
Email: admin@tws.com
Password: Password123!

