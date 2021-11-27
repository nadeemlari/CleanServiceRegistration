namespace CleanServiceRegistration.ServiceInstaller
{
    public static class InstallerExtension
    {
        public static void InstallServicesInAssembly(this IServiceCollection serviceCollection,IConfiguration configuration)
        {
            var serviceInstaller = typeof(Program).Assembly.ExportedTypes
                .Where(x => typeof(IInstaller).IsAssignableFrom(x) && !x.IsAbstract && !x.IsInterface)
                .Select(Activator.CreateInstance)
                .Cast<IInstaller>()
                .ToList();

            serviceInstaller.ForEach(i => i.Register(configuration, serviceCollection));
        }
    }
}
