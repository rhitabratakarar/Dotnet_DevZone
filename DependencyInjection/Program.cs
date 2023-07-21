using DependencyInjection;

// This is the DI Container (to know, read the README).

IService serviceToInject = new Service();
IClient client = new Client(serviceToInject);  // the dependency injection in action.
client.UseDependency(); // IClient has the UseDependency member, thus able to call it.

// It will print the output (IF NOT MODIFIED):
// 38
// This logic is inside the service method.
