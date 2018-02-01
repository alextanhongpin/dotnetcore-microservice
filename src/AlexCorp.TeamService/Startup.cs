using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

using AlexCorp.TeamService.Persistence;

namespace AlexCorp.TeamService
{
  public class Startup 
  {
    public Startup(IHostingEnvironment env) 
    {
    }

    public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
    {
      app.Run(async (context) => 
      {
        await context.Response.WriteAsync("Hello, world");
      });
    }

    // public void Configuration(IApplicationBuilder app)
    // {
    //   var services = new ServiceCollection();
    //   ConfigureServices(services);
    // }

    // MVC comes equipped with a scope-aware dependency injection (DI) system
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc();

      // We use the AddScoped because we want the DI subsystem to create a new
      // instance of this repository for every request.
      services.AddScoped<ITeamRepository, MemoryTeamRepository>();
    }
  }
}