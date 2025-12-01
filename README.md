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
4. Open your browser at `http://localhost:44391/`.

## Running with Docker
```bash
# Build the Docker image
docker build -t customer-dashboard:latest ./CustomerDashboard

# Run the container
docker run -d -p 8080:80 customer-dashboard:latest
	
### To access the application run below url
http://localhost:8080/