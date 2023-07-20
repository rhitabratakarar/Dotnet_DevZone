using DependencyInjection;

// This is the DI Container (to know, read the comment below).

/* Why Dependency Injection?
 * 
 * Traditionally, we created tightly coupled code by directly creating concrete instances of classes within other classes. For example:
 * 
 * In class A:
 * ClassB objectB = new ClassB(); // calling ClassB directly.
 * 
 * This approach makes the code harder to maintain and extend. If you modify one section of the code, there's a high possibility of breaking the existing codebase.
 * 
 * The solution? *Enter the Dependency Injection (DI) design pattern.*
 * 
 * In dependency injection, there are three entities:
 * 
 * Client - The first entity is the client, which requires a service. Here, IClient and Client are the respective entities representing the client entity.
 * 
 * Service - The second entity is the service that provides functionality to the client (e.g., IService and Service).
 * 
 * Container (or DI Container) - The last entity is the container, which is responsible for injecting the dependency (Service) through constructor dependency injection pattern.
 * 
 * This design pattern is popularly implemented by many modern frameworks, including ASP.NET Core, but it's not limited to any specific framework.
 * 
 * The approach is simple: a class should not directly create instances of another class it depends on; instead, the "to-be-used class" is injected by the container. This creates low coupled code that is easier to extend and maintain.
 * 
 * The approach looks like this:
 * 
 * (here Service is implementing IService interface.)
 * IService serviceToInject = new Service(); 
 * 
 * (The Client is implementing IClient interface and has a constructor taking an IService serviceToInject parameter.)
 * (This is constructor dependency injection.)
 * IClient clientThatWantsService = new Client(serviceToInject); 
 * 
 * (Call the client method that is implemented by the Client class from IClient)
 * clientThatWantsService.ConsumeInjectedService();
 *
 * Things to note: 
 * 
 * The Dependency Inversion Principle (DIP) is an enabler of the Dependency Injection principle.
 * 
 * DIP states that high-level modules/classes should not depend on low-level modules/classes directly. Instead, both should depend on abstractions (interfaces or abstract classes).
 * 
 * By programming to interfaces, you can easily switch implementations without modifying the client code.
 * 
 * The design pattern can be considered as follows:
 * 
 * There is a class that has a job to perform and requires a service for that. An abstraction of that service is required through its constructor (constructor dependency injection). Once the class receives the service, it can perform computations with it. Instead of instantiating the service by itself, it delegates this responsibility to someone else (the DI container).
 */


IService serviceToInject = new Service();
IClient client = new Client(serviceToInject);  // the dependency injection in action.
client.UseDependency(); // IClient has the UseDependency member, thus able to call it.

// It will print the output (IF NOT MODIFIED):
// 38
// This is inside service method
