# Customer Dashboard

## Overview
ASP.NET MVC 4.8 application for managing customer financial data, including:
- Transactions
- Spending categories
- Filters
- Trends & goals
- User profile and summary

## Prerequisites
- Docker (Windows for .NET Framework 4.8)
- Visual Studio 2019 or later

## Build & Run

### Using Visual Studio
1. Open `CustomerDashboard.sln` in Visual Studio.
2. Restore NuGet packages.
3. Build & run (F5).

### Using Docker
```bash
# Build the Docker image
docker build -t customer-dashboard:latest ./CustomerDashboard

# Run the container
docker run -d -p 8080:80 customer-dashboard:latest
	
### To access the application run below url
http://localhost:8080/