[![Build Status](https://zleaopereira.visualstudio.com/CrossDevelopment/_apis/build/status/zoft.NavigationService?repoName=zleao%2Fzoft.NotificationService&branchName=main)](https://zleaopereira.visualstudio.com/CrossDevelopment/_build/latest?definitionId=3&repoName=zleao%2Fzoft.NotificationService&branchName=main)
[![NuGet](https://img.shields.io/nuget/v/zoft.NotificationService.svg)](https://www.nuget.org/packages/zoft.NotificationService/)

# zoft.NotificationService

Generic C# messaging service to allow communication between different modules. Derived from the [MvxExtensions.Plugin.Notification](https://github.com/zleao/MvvmCross-Extensions/tree/master/Plugins/Notification)

Provides OneWay and TwoWay message sub/pub capabilities as well as Background and UI thread message subscription. Supports delayed notifications for use cases like the resume of views (Android, iOS, etc...).

### A bit of context:

This project is part of the **zoft** library, which is nothing more than an attempt to put together a set of C# utilities that I've created in my current and past projects.

A lot of this code comes from another library I've developed over the years ([MvxExtensions](https://github.com/zleao/MvvmCross-Extensions)). This library was initialy built to provide some extensions and utilities that work on top of awesome [MvvmCross](https://github.com/MvvmCross/MvvmCross) and therefore I never worried to much to have a clean separation of concerns when it comes to MvvmCross libraries dependencies. **zoft** is my attempt to separate what is not MvvmCross dependent. It starts with code ported from MvxExtentions but it will not stop there...

## Get started

### Install Nuget Package ([zoft.NotificationService](https://www.nuget.org/packages/zoft.NotificationService/))

- `Install-Package zoft.NotificationService -Version 1.0.0` 
- `dotnet add package zoft.NotificationService --version 1.0.0`

### Make sure to always use the same service instance

If you're using a DI (Dependency Injection) approach, you can use the provided interface `INotificationService`. **Don't forget to register the service as singleton**. As an example: `IOContainer.RegisterSingleton<INavigationService, NavigationService>()`

If you're not using a DI approach, the important part is to ensure that only one instance is uses throughout the application. You might use a factory or a static property.


## Samples

You can find a some samples in my other libraries repositories [here](https://github.com/zleao/MvvmCross-Extensions) and [here](https://github.com/zleao/zoft.TinyMvvmExtensions). Both samples are built for mobile applications using Xamarin but the usage is be similar for other platforms.


##
   
## How to use

### Subscribe
```
var token = NotificationService.Subscribe<MyMessage>(HandleOneWaySubscriptionAsync);

var token = NotificationService.Subscribe<MyMessage, MyResult>(HandleTwoWaySubscriptionAsync);
```
Click [here](https://gist.github.com/zleao/cce569fe9e0f162f399e7a2e03581973) for a complete set of the possible subscription methods

### Unsubscribe
```
NotificationService.Unsubscribe(token);
```
Click [here](https://gist.github.com/zleao/2aa83875f93c1ebbf866024b16ccd4ef) for a complete set of the possible unsubscription methods

### Publish
```
NotificationService.PublishAsync(myMessage);
NotificationService.DelayedPublishAsync(myMessage);
NotificationService.PublishPendingNotificationsAsync(this);

var myResult = NotificationService.PublishAsync<MyResult>(MyMessage);
```
Click [here](https://gist.github.com/zleao/e8443efebb3841d774da822e73d844f9) for a complete set of the possible publish methods
