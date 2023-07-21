## Why Dependency Injection?

Traditionally, we created tightly coupled code by directly creating concrete instances of classes within other classes. 

For example:
 
In class A:

ClassB objectB = new ClassB(); // calling ClassB directly.

This approach makes the code harder to maintain and extend. If you modify one section of the code, there's a high possibility 
of breaking the existing codebase.

**The solution?** *Enter the Dependency Injection (DI) design pattern.*

In dependency injection, there are three entities:

1. Client (Client.cs) - The first entity is the client, which requires a service. Here, "IClient" is an interface representing the client entity, 
and "Client" is a class implementing the "IClient" interface.

2. Service (Service.cs) - The second entity is the service that provides functionality to the client. For example, "IService" is an interface 
representing the service, and "Service" is a class implementing the "IService" interface.

3. Container (DI Container) (Program.cs) - The last entity is the container, which is responsible for injecting the dependency (Service) 
through constructor dependency injection pattern. The DI container is a part of a DI framework and provides a centralized 
way to manage dependencies and their lifetimes throughout the application.

This design pattern is popularly implemented by many modern frameworks, including ASP.NET Core, but it's not limited to any specific framework.

The approach is simple: a class should not directly create instances of another class it depends on; instead, the "to-be-used class" 
is injected by the DI container. This creates low coupled code that is easier to extend and maintain.

#### The approach looks like this:

(Here, "Service" is implementing "IService" interface.)
IService serviceToInject = new Service(); 

(The "Client" is implementing "IClient" interface and has a constructor taking an "IService" serviceToInject parameter.)
(This is constructor dependency injection.)
IClient clientThatWantsService = new Client(serviceToInject); 

(Call the client method that is implemented by the "Client" class from "IClient")
clientThatWantsService.ConsumeInjectedService();


## Things to note: 

The Dependency Inversion Principle (DIP) is an enabler of the Dependency Injection principle.

DIP states that high-level modules/classes should not depend on low-level modules/classes directly. Instead, both should depend 
on abstractions (interfaces or abstract classes).

By programming to interfaces, you can easily switch implementations without modifying the client code.


## Key Points:

1. DI is a design pattern that decouples the client code from the service implementation.

2. This makes the code more maintainable and extensible.

3. The DI container is responsible for injecting the dependency into the client code.

4. The DI container can be implemented in various ways, such as using an interface or an abstract class.

5. DI is a popular design pattern that is used in many modern frameworks

The design pattern can be considered as follows:

There is a class that has a job to perform and requires a service for that. An abstraction of that service is required through 
its constructor (constructor dependency injection). Once the class receives the service, it can perform computations with it. 
Instead of instantiating the service by itself, it delegates this responsibility to someone else (the DI container).


## How to?

1. start by making a class (Client) that takes a constructor and relevant informations from its parameter along with a service (Service class) that 
is responsible for managing the operations that the is client going to take.

2. Start programming to Interfaces, meaning all parameters should be of interface type instead of the class ("IService service" instead of "Service service")
where IService is the Interface that Service class is implementing. (Reason: Dependency Inversion (SOLID Principle))

3. Implement the client to an IClient interface, for example, "class Client implements IClient" and use the IClient type instead of Client type for
declaring object. (IClient client = new Client() instead of Client client = new Client())

4. Now develop the Interface, IService and IClient respectively in a new namespace.