namespace CpmPedidos.API
{
    public class DependencyInjection
    {
        public static void Register(IServiceCollection serviceProvider)
        {
            RepositoryDependece(serviceProvider);
        }

        private static void RepositoryDependece(IServiceCollection serviceProvider)
        {
        }
    }
}
