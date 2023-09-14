using System.Reflection;

namespace AwsMigration.Extension
{
    public static class ResolveDependencyBuilder
    {
        public static void ResolveDependencyInjection(this IServiceCollection services)
        {

            // AddHttpContextAccessor - Use this if needed to access the Request collection and Response property
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


            #region Auto Register All Services
            var appServices = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.Namespace == "AwsMigration.Services" && t.Name.EndsWith("Service"))
                .ToList();

            appServices.ForEach(x =>
            {
                services.AddTransient(x.GetInterface($"I{x.Name}")!, x);
            });
            #endregion

            #region Auto Register All Repositories

            var repositories = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.Namespace == "AwsMigration.Repositories" && t.Name.EndsWith("Repository"))
                .ToList();

            repositories.ForEach(x =>
            {
                services.AddTransient(x.GetInterface($"I{x.Name}")!, x);
            });

            #endregion
        }

    }
}
