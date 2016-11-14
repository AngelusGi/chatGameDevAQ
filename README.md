# chatGameDevAQ
Real time chat proposed using SignalR and Azure on October 22th @GameDev Tour at Università degli Studi dell'Aquila

You can found more information on my web site: http://angelus-gi.azurewebsites.net/gamedev-tour-laquila-signalr/

We need:
1) Web App hosed on Microsoft Azure
	
	- Open your subscription -> new -> app web ->  fill in the form and "CREATE"
	
	- Wait for deploy... Open the web service just created and test the URL, in the new window you should get this message "This web app has been successfully created"
		
2) Visual Studio with Azure SDK
	
	- Open a new project -> Visual C# -> ASP.NET Web Application using .NET Framework 4.6 -> Empty template
	
	- In solution explorer open "Manage NuGet Packages" -> Install "Microsoft.AspNet.SignalR" and all its dependencies
	
	- Add a new "SignalR (v2) HUB Class" called "ChatHub" -> view the code in the repository
	
	- Add a new "Owin Startup Class" called "Startup" -> view the code in the repository
	
	- Add a new "HTML Page" called "Index" and setup it as start page -> view the code in the repository

3) Test this solution on your browser (ex. Opera, Edge, IE, etc.)

4) 	If all works now we're ready to upload it on Azure:
	
	- Build -> Publish
	
	- Microsoft Azure App Service -> Publish
	
5) Enjoy! :)

You can found more information on my web site: http://angelus-gi.azurewebsites.net/gamedev-tour-laquila-signalr/
