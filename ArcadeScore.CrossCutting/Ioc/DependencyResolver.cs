using ArcadeScore.Domain.Repositories.Interfaces;
using ArcadeScore.Infrastruture;
using Microsoft.Extensions.DependencyInjection;

namespace ArcadeScore.CrossCutting.Ioc
{
    public static class DependencyResolver
    {
        public static void AddDependencyResolver(this IServiceCollection services)
        {
            RegisterRepositories(services);
        }

        private static void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped<IScoreRepository, ScoreRepository>();
        }
    }
}
