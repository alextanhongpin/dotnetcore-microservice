# Getting Started

## Create a solution

```bash
$ dotnet new sln
```

## To start a new project:

```bash
$ dotnet new mvc -o Company.TeamService

# Add project to solution
$ dotnet sln add ./Company.TeamService/Company.TeamService.csproj
```


To create the test project. Reference [here](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-dotnet-test).

```bash
# Create test project
$ dotnet new xunit

# Add the reference back to the Company.TeamService project
$ dotnet add reference ../Company.TeamService/Company.TeamService.csproj

# Add test to solution 
$ dotnet sln add Company.TeamService.Tests/Company.TeamService.Tests.csproj
```

## Adding packages manually

```bash
$ dotnet add package Microsoft.AspNetCore.Mvc
$ dotnet add package Microsoft.AspNetCore.Server.Kestrel
$ dotnet add package Microsoft.Extensions.Logging
$ dotnet add package Microsoft.Extensions.Logging.Console
$ dotnet add package Microsoft.Extensions.Logging.Debug
$ dotnet add package Microsoft.Extensions.Configuration.CommandLine
$ dotnet add package Microsoft.Extensions.DependencyInjection

# Testing dependencies
$ dotnet add package xunit
$ dotnet add package xunit.runner.visualstudio
$ dotnet add package Microsoft.NET.Test.Sdk
```