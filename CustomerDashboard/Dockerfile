# Use ASP.NET 4.8 runtime on Windows Server Core
FROM mcr.microsoft.com/dotnet/framework/aspnet:4.8-windowsservercore-ltsc2019

# Set the working folder inside the container
WORKDIR /inetpub/wwwroot

# Copy EVERYTHING from your project folder INTO the container
COPY . .

# Expose port 80 (default for IIS)
EXPOSE 80
