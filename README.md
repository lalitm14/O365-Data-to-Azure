<font size="50">**O365-data-to-Azure**</font> :point_right:
<br>
<br>
<font size="5">**1. Title**</font>: Pulling Office365 Users Usage (signals) data at-scale for downstream analytics insights, leveraging Microsoft Graph Data connect with the Microsoft Data Factory Service.
<br>\
<font size="5">**2. Description**</font>: Sample End-user application short description: Here is a sample minimal C# Web application that demonstrates how the Office 365 user data can be quickly obtained at-scale to feed the downstream application to extract the insights and the learning from it. All this while keeping the data with the enterprise subscription and with finer granularity of consent for access compared to using Microsoft Graph API calls-based applications.
<br>
<br>
<font size="5">**3. Video Demo**</font> 📽️ [9 minutes 44 seconds]: This [Demo  video](https://youtu.be/8WIcnof-CL8) steps through entire workflow of the data extraction in three broad stages.
<br>
**(i)** Setting up the Office 365 source tenant with the email-enabled security group to consider and approve the request to access the Office 365 users usage data by the Azure Data Factory for this demonstration of bulk data extraction.
<br>
**(ii)** Setting up the data pipeline in the Azure Data Factory. It is a simple single activity of copy from the Office 365 tenant prepared using the Microsoft Graph Connector as source. And copying to a sink which in this demo is a Azure Blob storage in a Azure Storage account container.
<br>
**(iii)** Sample demonstration app coded using the ASP.NET Core using C# and HTML. This is just a simple example using the email statistics table. The possibilities are unlimited, based on the downstream insights that one might be looking for to better understand the working of the knowledge workers of the organization.
<br>
<br>
<font size="5">**4. Instruction to try-out this Demo**</font>:
<br>
**(i)** Follow the instruction in the 'Microsoft Docs' website as in the reference# (b) provided in the "References" section below, up till the Step#5 only
<br>
**(ii)** Clone this "O365-Data-to-Azure" git repository on to your local host machine. Upon opening the project O365Demo1 inside this folder in Visual Studio, double-click on the project in the solution explorer window to reveal the project structure.
<br>
**(iii)** Setup the Azure storage container hosting the email blob, that you have created in the step#3 of the 'Microsoft Docs' website as in the reference# (b) provided in the "References" section below as the connected service for this project. Also check out the 'add connected service.jpg' file provided in this repository with screenshots of the process<br>**(iv)** Hit "F5" to run the app and select the "EmailMetrics" option from the top menu bar to show the email statistics flowing from the O365 tenant used for this demonstration.
<br>
<br>
<font size="5">**5. References**</font>: 🌏
<br>
**(a)** [Overview of Microsoft Graph Data Connect - Microsoft Graph | Microsoft Docs](https://docs.microsoft.com/en-us/graph/data-connect-concept-overview)
<br>
**(b)** [Build your first Microsoft Graph Data Connect application | Microsoft Docs](https://docs.microsoft.com/en-us/graph/data-connect-quickstart?tabs=Microsoft365)
<br>
**(c)** [Introduction to ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core?view=aspnetcore-5.0)
<br/>
**(d)** [Introduction to Razor Pages in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/razor-pages/?view=aspnetcore-5.0&tabs=visual-studio)
