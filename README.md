# hello-wcf
A simple WCF project for learning and experimenting.

# Run

Open helloWCF.sln in Visual Studio. 

**Run the WCF Client** 
* Right click on `MyClient.ConsoleApp` 
* Choose Debug > Start new Instance.

**Run the WCF Service via IIS**
* Right click on `MyIISHost.ServiceApplication` 
* Choose Debug > Start new Instance. 
* Click on Service1.svc in the web browser to view the service help page. 

**Run the WCF Service via Self Hosting**. 
* Right click on `MySelfHost.ConsoleApp` 
* Choose Debug > Start new Instance. (Note: You will need to run Visual Studio as an Administrator.)
* You can now open the WCF Test Client and add the service at the service address that is in the console window.

# WCF Overview

* ServiceContracts are collections of OperationContracts. 
* DataContracts are collections of DataMembers. 
* Message exchange patterns (MEPS) include Request/Reply, OneWay, and Duplex. 
* FaultExceptions enable services to inform clients about exceptions. 
* Message protection levels include Signed, Signed and Encrypted, and Neither Signed nor Encrypted. 

Services pass serialized copies of objects not object references. The serialization is generally in SOAP. 

Prefer interfaces for service contracts instead of classes unless you want speed & simplicity. 

Use data contracts to enhance interoperability. 

Even void operations in a request/reply pattern block until they receive a response. 

Explicity set the `Name` and `Namespace` properties of all supporting contract attributes (e.g. `ServiceContract`) to avoid naming collisions. 

The configuration goes into the hosts app.config file (or web.config) not the service libraries app.config file. The client element is only necessary if we are consuming a service.

    system.serviceModel
      services
        service
          endpoint
          host
      bindings
        binding
      behaviors
        serviceBehavior
          behavior
      client
        endpoint
      protocolMapping
        add
      serviceHostingEnvironment

There are four main ways to host a WCF Service: 

1. Self Hosted (e.g. Console App)
2. Managed Windows Service
3. Internet Information Services
4. Windows Process Activation

# Helpful Links

[Basic Programming Lifecycle](https://msdn.microsoft.com/en-us/library/ms732098%28v=vs.110%29.aspx)
