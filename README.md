# Customer Dashboard

A web-based customer dashboard built with ASP.NET MVC 4.8, showcasing financial profiles, transactions, spending trends, and goals.

## Features

- Customer Profile Overview
- Transaction History with Pagination
- Spending Summary by Category
- Financial Goals Dashboard
- Monthly Trends Analysis
- Login/Logout with Session Management

## Prerequisites

- Windows OS (for .NET Framework 4.x)
- Visual Studio 2019 or later
- .NET Framework 4.8
- Docker Desktop (for running Docker container)

## Project Structure

- `Controllers/` → MVC controllers
- `Views/` → Razor views
- `Scripts/` → JS libraries
- `Content/` → CSS, images
- `App_Data/` → JSON mock data
- `Dockerfile` → Docker instructions

## Running Locally

1. Open the solution in Visual Studio.
2. Set `CustomerDashboard` as the startup project.
3. Press **F5** to run in IIS Express.
4. Open your browser at `http://localhost:<port>/`.

## Running with Docker

1. Build the Docker image:

```bash
docker build -t customer-dashboard .


docker run -d -p 8080:80 customer-dashboard


## Notes

- Currently uses mock JSON data in `App_Data`.
- Can be extended to connect to a real database.
- Session management clears user data on logout/back navigation.
