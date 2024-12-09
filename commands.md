# Common .NET Commands
=====================================

## Table of Contents
-----------------

- [Common .NET Commands](#common-net-commands)
  - [Table of Contents](#table-of-contents)
  - [dotnet new](#dotnet-new)
  - [dotnet restore](#dotnet-restore)
  - [dotnet build](#dotnet-build)
  - [dotnet run](#dotnet-run)
  - [dotnet test](#dotnet-test)
  - [dotnet publish](#dotnet-publish)
  - [dotnet pack](#dotnet-pack)
  - [dotnet nuget](#dotnet-nuget)
  - [dotnet sln](#dotnet-sln)
  - [dotnet add](#dotnet-add)
  - [dotnet remove](#dotnet-remove)

## dotnet new
-------------

Creates a new .NET project or file.

```bash
dotnet new [template] [options]
```

*   `template`: The type of project or file to create (e.g., `console`, `web`, `classlib`, etc.).
*   `options`: Additional options for the template (e.g., `--name`, `--output`, etc.).

Example:

```bash
dotnet new console -o MyConsoleApp
```

## dotnet restore
----------------

Restores the dependencies and tools of a .NET project.

```bash
dotnet restore [options]
```

*   `options`: Additional options for the restore process (e.g., `--configfile`, `--ignore-failed-sources`, etc.).

Example:

```bash
dotnet restore MyProject.csproj
```

## dotnet build
----------------

Builds a .NET project and its dependencies.

```bash
dotnet build [options]
```

*   `options`: Additional options for the build process (e.g., `--configuration`, `--output`, etc.).

Example:

```bash
dotnet build MyProject.csproj -c Release
```

## dotnet run
----------------

Runs a .NET project.

```bash
dotnet run [options]
```

*   `options`: Additional options for the run process (e.g., `--configuration`, `--launch-profile`, etc.).

Example:

```bash
dotnet run MyProject.csproj
```

## dotnet test
----------------

Runs the tests of a .NET project.

```bash
dotnet test [options]
```

*   `options`: Additional options for the test process (e.g., `--configuration`, `--filter`, etc.).

Example:

```bash
dotnet test MyProject.csproj
```

## dotnet publish
-----------------

Publishes a .NET project to a folder or package.

```bash
dotnet publish [options]
```

*   `options`: Additional options for the publish process (e.g., `--configuration`, `--output`, etc.).

Example:

```bash
dotnet publish MyProject.csproj -c Release -o ./publish
```

## dotnet pack
----------------

Creates a NuGet package from a .NET project.

```bash
dotnet pack [options]
```

*   `options`: Additional options for the pack process (e.g., `--configuration`, `--output`, etc.).

Example:

```bash
dotnet pack MyProject.csproj -c Release
```

## dotnet nuget
-----------------

Manages NuGet packages for a .NET project.

```bash
dotnet nuget [command] [options]
```

*   `command`: The NuGet command to execute (e.g., `push`, `delete`, etc.).
*   `options`: Additional options for the NuGet command (e.g., `--source`, `--api-key`, etc.).

Example:

```bash
dotnet nuget push MyPackage.nupkg --source https://api.nuget.org/v3/index.json --api-key 1234567890
```

## dotnet sln
----------------

Manages solutions for .NET projects.

```bash
dotnet sln [command] [options]
```

*   `command`: The solution command to execute (e.g., `add`, `remove`, etc.).
*   `options`: Additional options for the solution command (e.g., `--solution-file`, etc.).

Example:

```bash
dotnet sln add MyProject.csproj
```

## dotnet add
----------------

Adds a reference or package to a .NET project.

```bash
dotnet add [reference/package] [options]
```

*   `reference/package`: The reference or package to add (e.g., `Microsoft.AspNetCore`, etc.).
*   `options`: Additional options for the add process (e.g., `--version`, etc.).

Example:

```bash
dotnet add package Microsoft.AspNetCore.Mvc
```

## dotnet remove
-----------------

Removes a reference or package from a .NET project.

```bash
dotnet remove [reference/package] [options]
```

*   `reference/package`: The reference or package to remove (e.g., `Microsoft.AspNetCore`, etc.).
*   `options`: Additional options for the remove process (e.g., `--version`, etc.).

Example:

```bash
dotnet remove package Microsoft.AspNetCore.Mvc
```