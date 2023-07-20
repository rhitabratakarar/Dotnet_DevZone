using DependencyInjection;

// This is the dependency injector.

/* Why dependency injection?
 * 
 * Traditionally, we create two concrete classes and call one from the other directly. For eg:
 * 
 * From class A:
 * ClassB objectB = new ClassB(); // calling ClassB directly.
 * 
 * This approach creates "tightly coupled code", which is harder to maintain and harder to extend.
 * 
 * The fix? *Enters Dependency Injection design pattern*
 * 
 * In dependency injection, there are three entities
 * 
 * Client - The first entity is the client which wants a service. Here IClient and Client are the respective entities
 * representing the client entity.
 * 
 * Service - The second entity that provides a service to the requestor (Here IService and Service).
 * 
 * Injector - The last entity is the injector, which is this file that is going to inject the dependency(Service)
 * through construction dependency injection pattern.
 * 
 * This design pattern is popularly implemented by a lot of modern frameworks, one of them is ASP.NET core
 * 
 * The approach is pretty simple, a class will not directly call another class, instead the "to be called class" 
 * will be injected by any injector. This approach creates your code low coupled which is much better to extend
 * and maintain as well.
 * 
 * The approach looks like this,
 * 
 * (here Service is implementing IService interface.)
 * IService serviceToInject = new Service(); 
 * 
 * (the Client is implementing IClient interface.)
 * (the Client class has a constructor that is taking an IService serviceToInject parameter.)
 * (this is the dependency injection through constructor pattern)
 * IClient clientThatWantsService = new Client(serviceToInject); 
 * 
 * (call the client method that is implemented by Client class from IClient)
 * clientThatWantsService.ConsumeInjectedService();
 *
 * This dependency inversion principle is an enabler to the dependency injection principle.
 * 
 * The reason is pretty simple, suppose there is another service, like 'MyCustomService', which is implementing
 * the IService interface, then the members related to the interface has to be present inside the class right? 
 * And for this reason, it will allow us to inject the 'MyCustomService' class object to the Client class 
 * constructor, thus it is not limiting it to the 'Service' class only.
 * 
 * The design pattern can be considered like this,
 * 
 * There is a class that has a job to perform and for that it needs a service, thus an abstraction of that 
 * service is required through its constructor (constructor dependency injection). Now once the class achieves
 * the service, it can do computation with that service. Instead of directly instantiating the service by itself,
 * it chose to do it by someone else (the caller of the client, the injector).
 */


IService serviceToInject = new Service();
IClient client = new Client(serviceToInject);  // the dependency injection in action.
client.UseDependency(); // IClient has the UseDependency member, thus able to call it.

// It will print the output (IF NOT MODIFIED):
// 38
// This is inside service method
