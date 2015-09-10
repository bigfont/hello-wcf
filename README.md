# hello-wcf
A simple WCF project for learning and experimenting.

# Run

Open helloWCF.sln in Visual Studio. 

**Run the WCF Client.** 
* Right click on `MyClient.ConsoleApp` 
* Choose Debug > Start new Instance.

**Run the WCF Service via IIS.** 
* Right click on `MyIISHost.ServiceApplication` 
* Choose Debug > Start new Instance. 
* Click on Service1.svc in the web browser to view the service help page. 

**Run the WCF Service via Self Hosting**. 
* Right click on `MySelfHost.ConsoleApp` 
* Choose Debug > Start new Instance. (Note: You will need to run Visual Studio as an Administrator.)
* You can now open the WCF Test Client and add the service at the service address that is in the console window.

# Helpful Links

[Basic Programming Lifecycle](https://msdn.microsoft.com/en-us/library/ms732098%28v=vs.110%29.aspx)
