using DependencyInjection;

// This is the dependency injector.


/* In dependency injection, there are three entities
 * 
 * Client - The first entity is the client which wants a service. Here IClient and Client are the respective entities
 * representing the client entity.
 * 
 * Service - The second entity that provides a service to the requestor (Here IService and Service).
 * 
 * Injector - The last entity is the injector, which is this file that is going to inject the dependency(Service)
 * through construction dependency injection pattern.
 * 
 * At first, declared a IService interface and a relevant "Service" class that is implementing the interface
 * After that, IClient and "Client" got declared respectively. But this time, in the Client class, a constructor
 * got declared. The constructor is taking an input of "IService injectedService" parameter and this is the
 * service that is going to get injected inside the client class using constructor dependency injection.
 * At last, in the injector, two objects got created, one for service and the other for the client. Now this time,
 * the service got injected to the client object during its creation maintaining the dependency injection design.
 */

/* Things to note:
 * 
 * Everytime, an interface reference is used for referencing the object and not a concrete class, 
 * IService serviceToInject = new Service();
 * This is the dependency inversion principle (depend on the abstraction(interface) instead of concretion(class))
 * 
 * Simillarly, in the 'Client' constructor, "IService serviceToInject" is used instead of "Service".
 * 
 * This dependency inversion principle is an enabler to the dependency injection principle.
 * 
 * The reason is pretty simple, suppose there is another service, like 'MyCustomService', which is implementing
 * the IService interface, then the members related to the interface has to be present inside the class right? 
 * And for this reason, it will allow us to inject the 'MyCustomService' class object to the Client class 
 * constructor, thus it is not limiting it to the 'Service' class only.
 */


IService serviceToInject = new Service();
IClient client = new Client(serviceToInject);  // the dependency injection in action.
client.UseDependency(); // IClient has the UseDependency member, thus able to call it.

// It will print the output (IF NOT MODIFIED):
// 38
// This is inside service method
