# O365-data-to-Azure 👉 

Pulling Office 365 Users Usage (signals) data at-scale for downstream analytics insights, leveraging [Microsoft Graph](https://docs.microsoft.com/en-us/graph/overview) Data connect with the [Azure Data Factory](https://azure.microsoft.com/en-us/services/data-factory/) Service.

[![YouTube Video](readme-video-thumb.png?raw=true "YouTube video")](https://www.youtube.com/watch?v=8WIcnof-CL8)

The entire workflow of the data extraction can be divided into 3 broad stages:

1. Set up the Office 365 source tenant with the email-enabled security group to consider and approve the request to access the Office 365 users usage data by the Azure Data Factory for this demonstration of bulk data extraction.
2. Set up the data pipeline in the Azure Data Factory. It is a simple single activity of copy from the Office 365 tenant prepared using the Microsoft Graph Connector as source. And copying to a sink which in this demo is a Azure Blob storage in a Azure Storage account container.
3. Use the sample demonstration app coded using the ASP.NET Core using C# and HTML (**🚩 this repository**). This is just a simple example using the email statistics table. The possibilities are unlimited, based on the downstream insights that one might be looking for to better understand the working of the knowledge workers of the organization.

## What this repository contains

This repository contains a ASP.NET Core project, used as part of the final step of the aforementioned data process.

The sample web application that demonstrates how the Office 365 user data can be quickly obtained at-scale to feed the downstream application to extract the insights and the learning from it. All this while keeping the data with the enterprise subscription and with finer granularity of consent for access compared to using Microsoft Graph API calls-based applications.

## How to use this repository

1. Follow the instruction outlined in this [Microsoft Documentation Article here]([Build your first Microsoft Graph Data Connect application | Microsoft Docs](https://docs.microsoft.com/en-us/graph/data-connect-quickstart?tabs=Microsoft365)) **up until step #5 only ⚠️**
2. Clone this repository to your local machine, and open the `O365Demo.sln` solution file with Visual Studio ([available for free here](https://visualstudio.microsoft.com/downloads/)).
3. Set up connected services for the Azure storage container hosting the email blob that you have created in the step #3 of the 'Microsoft Docs' website

   ![Azure Storage Connected Service](add%20connected%20service.jpg?raw=true "Azure Storage Connected Service")

   Run your project with `F5` key. Click on "EmailMetrics" menu option in the browser window to show the email statistics flowing from the O365 tenant used for this demonstration.

## References

- [Overview of Microsoft Graph Data Connect - Microsoft Graph | Microsoft Docs](https://docs.microsoft.com/en-us/graph/data-connect-concept-overview)
- [Introduction to ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core?view=aspnetcore-5.0)
- [Introduction to Razor Pages in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/razor-pages/?view=aspnetcore-5.0&tabs=visual-studio)
