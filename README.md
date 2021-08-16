# O365-data-to-Azure :point_right:

1.	**Title**: Pulling Office365 Users Usage (signals) data at-scale for downstream analytics insights, leveraging Microsoft Graph Data connect with the Microsoft Data Factory Service.

2.	**Description**: Sample End-user application short description: Here is a sample minimal C# Web application that demonstrates how the Office 365 user data can be quickly obtained at-scale to feed the downstream application to extract the insights and the learning from it. All this while keeping the data with the enterprise subscription and with finer granularity of consent for access compared to using Microsoft Graph API calls-based applications. 

3.	**Video Demo** :film_projector: *[9 minutes 44 seconds]*: This Demo https://youtu.be/8WIcnof-CL8 video steps through entire wroflow of the data extraction in three borad stages.\
 **(i)** Setting up the Office 365 source teanant with the email-enabled secuirty group to consider and approve the request to access the Office 365 users usgae data by the Azure Data Factory for this demonstration of bulk data extraction.\
 **(ii)** Setting up the data pipeline in the Azure Data Factory. It is a simple signle activity of copy from the Office 365 tenant prepared using the Microsoft Graph Connector as source. And copying to a sink which in this demo is a Azure Blob storage in a Azure Storage account container.\
 **(iii)** Sample demonstration app coded using the ASP.NET Core using C# and HTML. This is just a simple example using the email statistics table. The possibilities are unlimited, based on the downstream insights that one might be looking for to better understand the working of the knowledge workers of the organization.
4. **Instruction to try-out this Demo**:\
    (i) Follow the instrcution in the 'Microsoft Docs' website as in the reference# (b) provided in the "References" section below, up till the Step#5 only\
    (ii) Clone this "O365-Data-to-Azure" git repository on to your local host machine. Upon opening the project O365Demo1 inside this folder in Visual Studio, double-click on the project in the solution eplxorer window to reveal the project structure.\
    (iii) Setup the Azure storage contianer hosting the email blob, that you have created in the step#3 of the 'Microsoft Docs' website as in the reference# (b) provided in the "References" section below. also check out the 'add connected service.jpg' file provided in this repository with screenshots of the process.\
    (iv) Hit "F5" to run the app and slelect the "EmailMEtrics" option from the top menu bar to show the email statistics from the O365 tenent used for this demonstration.
5.	**References**: :earth_asia:

    **(a)**   Overview of Microsoft Graph Data Connect - Microsoft Graph | Microsoft Docs [Caption] https://docs.microsoft.com/en-us/graph/data-connect-concept-overview\
  
    **(b)**    Build your first Microsoft Graph Data Connect application | Microsoft Docs [Caption] https://docs.microsoft.com/en-us/graph/data-connect-quickstart?tabs=Microsoft365\
  
    **(c)**    Introduction to ASP.NET Core [Caption] https://docs.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core?view=aspnetcore-5.0 \
  
    **(d)**    Introduction to Razor Pages in ASP.NET Core [Caption] https://docs.microsoft.com/en-us/aspnet/core/razor-pages/?view=aspnetcore-5.0&tabs=visual-studio\
  
  
