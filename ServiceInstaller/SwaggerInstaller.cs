namespace CleanServiceRegistration.ServiceInstaller;

public class SwaggerInstaller:IInstaller
{
    public void Register(IConfiguration configuration, IServiceCollection serviceCollection)
    {
        serviceCollection.AddEndpointsApiExplorer();
        serviceCollection.AddSwaggerGen();
    }
}