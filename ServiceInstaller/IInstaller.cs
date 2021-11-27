namespace CleanServiceRegistration.ServiceInstaller;

public interface IInstaller
{
    void Register(IConfiguration configuration, IServiceCollection serviceCollection);
}