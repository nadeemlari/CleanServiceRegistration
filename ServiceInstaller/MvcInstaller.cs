namespace CleanServiceRegistration.ServiceInstaller;

public class MvcInstaller : IInstaller
{
    public void Register(IConfiguration configuration, IServiceCollection serviceCollection)
    {
        serviceCollection.AddControllers();
    }
}