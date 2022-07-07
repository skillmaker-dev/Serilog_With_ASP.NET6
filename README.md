# Serilog_With_ASP.NET6
Using Serilog with ASP.NET 6

- **Clone the project and install Nugget Packages, then Change Azure Analytics sink settings with the corresponding values (Please visit this link for more infos [Here](https://github.com/saleem-mirza/serilog-sinks-azure-analytics) ) in "appsettings.json"**
- **Start The application using CTRL + F5**
- **View logs on console, Text file in "C:\ASP.LOGS\log.txt", Json file "C:\ASP.LOGS\log.json", and Azure analytics (make sure you configured Azure Log Analytics service in your Azure portal)**
- **Don't forget to inject the logger in your controller if you are planning to add one!**

## Console
![ConsoleLogging](https://user-images.githubusercontent.com/64654197/177879453-66cce0f1-c0c4-4256-8114-a6c20e69b400.png)

## Text file
![TextFileLogging](https://user-images.githubusercontent.com/64654197/177879493-8d627fbb-d11a-47d8-9e8d-a5505efb7d8d.png)

## Json file
![JsonLogging](https://user-images.githubusercontent.com/64654197/177879513-4c3e313f-53a5-48c2-b1c4-6d3074bf69fe.png)

## Azure analytics
![AzureLogging](https://user-images.githubusercontent.com/64654197/177879539-c41b4930-2c50-4d09-a3e9-de2477fc39d7.png)

## How to configure Azure Analytics

Install [Serilog.Sinks.AzureAnalytics](https://www.nuget.org/packages/serilog.sinks.azureanalytics) from NuGet
```
Install-Package Serilog.Sinks.AzureAnalytics
```

**Create a log service in azure, it is free (below 500mb of user per day)!**
![LogService](https://user-images.githubusercontent.com/64654197/177880587-5d1a5745-cef0-4113-a3c7-d67c678a7c3f.png)

**Enter a name for you log service and Hit Create**
![Create LogService](https://user-images.githubusercontent.com/64654197/177880737-a06a19cf-e5d6-4256-850a-20b4d223c2a4.png)

**Go to your created resource and then agents management so that you can copy the keys and set them in appsettings.json**

```workspaceId```: Workspace Id from Azure OMS Portal connected sources.

```authenticationId```: Primary or Secondary key from Azure OMS Portal connected sources.

![AzureKeys](https://user-images.githubusercontent.com/64654197/177880999-5883a75e-0163-4516-b697-803a5d4db396.png)

**Launch the app and view the logs**
![ViewAzureLogs](https://user-images.githubusercontent.com/64654197/177881295-7f720e83-70f9-4653-b8c9-1bdeb9ff6449.png)

![AzureLogging](https://user-images.githubusercontent.com/64654197/177881345-ad5feb53-fab7-4fa6-a272-30f0843fcdd7.png)
