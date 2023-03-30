
# Getting Started with MundiAPI

## Introduction

Mundipagg API

## Building

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore is enabled, these dependencies will be installed automatically. Therefore, you will need internet access for build.

* Open the solution (MundiAPI.sln) file.

Invoke the build process using Ctrl + Shift + B shortcut key or using the Build menu as shown below.

The build process generates a portable class library, which can be used like a normal class library. More information on how to use can be found at the MSDN Portable Class Libraries documentation.

The supported version is **.NET Standard 2.0**. For checking compatibility of your .NET implementation with the generated library, [click here](https://dotnet.microsoft.com/en-us/platform/dotnet-standard#versions).

## Installation

The following section explains how to use the MundiAPI.Standard library in a new project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the solution explorer and choose `Add -> New Project`.

![Add a new project in Visual Studio](https://apidocs.io/illustration/cs?workspaceFolder=MundiAPI-CSharp&workspaceName=MundiAPI&projectName=MundiAPI.Standard&rootNamespace=MundiAPI.Standard&step=addProject)

Next, choose `Console Application`, provide `TestConsoleProject` as the project name and click OK.

![Create a new Console Application in Visual Studio](https://apidocs.io/illustration/cs?workspaceFolder=MundiAPI-CSharp&workspaceName=MundiAPI&projectName=MundiAPI.Standard&rootNamespace=MundiAPI.Standard&step=createProject)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the `TestConsoleProject` as the start-up project. To do this, right-click on the `TestConsoleProject` and choose `Set as StartUp Project` form the context menu.

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=MundiAPI-CSharp&workspaceName=MundiAPI&projectName=MundiAPI.Standard&rootNamespace=MundiAPI.Standard&step=setStartup)

### 3. Add reference of the library project

In order to use the `MundiAPI.Standard` library in the new project, first we must add a project reference to the `TestConsoleProject`. First, right click on the `References` node in the solution explorer and click `Add Reference...`

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=MundiAPI-CSharp&workspaceName=MundiAPI&projectName=MundiAPI.Standard&rootNamespace=MundiAPI.Standard&step=addReference)

Next, a window will be displayed where we must set the `checkbox` on `MundiAPI.Standard` and click `OK`. By doing this, we have added a reference of the `MundiAPI.Standard` project into the new `TestConsoleProject`.

![Creating a project reference](https://apidocs.io/illustration/cs?workspaceFolder=MundiAPI-CSharp&workspaceName=MundiAPI&projectName=MundiAPI.Standard&rootNamespace=MundiAPI.Standard&step=createReference)

### 4. Write sample code

Once the `TestConsoleProject` is created, a file named `Program.cs` will be visible in the solution explorer with an empty `Main` method. This is the entry point for the execution of the entire solution. Here, you can add code to initialize the client library and acquire the instance of a Controller class. Sample code to initialize the client library and using Controller methods is given in the subsequent sections.

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=MundiAPI-CSharp&workspaceName=MundiAPI&projectName=MundiAPI.Standard&rootNamespace=MundiAPI.Standard&step=addCode)

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `BasicAuthUserName` | `string` | The username to use with basic authentication |
| `BasicAuthPassword` | `string` | The password to use with basic authentication |

The API client can be initialized as follows:

```csharp
MundiAPI.Standard.MundiAPIClient client = new MundiAPI.Standard.MundiAPIClient.Builder()
    .BasicAuthCredentials("BasicAuthUserName", "BasicAuthPassword")
    .Build();
```

## Authorization

This API uses `Basic Authentication`.

## API Errors

Here is the list of errors that the API might throw.

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid request | [`ErrorException`](doc/models/error-exception.md) |
| 401 | Invalid API key | [`ErrorException`](doc/models/error-exception.md) |
| 404 | An informed resource was not found | [`ErrorException`](doc/models/error-exception.md) |
| 412 | Business validation error | [`ErrorException`](doc/models/error-exception.md) |
| 422 | Contract validation error | [`ErrorException`](doc/models/error-exception.md) |
| 500 | Internal server error | [`ErrorException`](doc/models/error-exception.md) |

## List of APIs

* [Subscriptions](doc/controllers/subscriptions.md)
* [Orders](doc/controllers/orders.md)
* [Plans](doc/controllers/plans.md)
* [Invoices](doc/controllers/invoices.md)
* [Customers](doc/controllers/customers.md)
* [Charges](doc/controllers/charges.md)
* [Recipients](doc/controllers/recipients.md)
* [Tokens](doc/controllers/tokens.md)
* [Transactions](doc/controllers/transactions.md)
* [Transfers](doc/controllers/transfers.md)

## Classes Documentation

* [Utility Classes](doc/utility-classes.md)
* [HttpRequest](doc/http-request.md)
* [HttpResponse](doc/http-response.md)
* [HttpStringResponse](doc/http-string-response.md)
* [HttpContext](doc/http-context.md)
* [HttpClientConfiguration](doc/http-client-configuration.md)
* [HttpClientConfiguration Builder](doc/http-client-configuration-builder.md)
* [IAuthManager](doc/i-auth-manager.md)
* [ApiException](doc/api-exception.md)

