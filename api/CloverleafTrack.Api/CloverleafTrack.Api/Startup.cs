using System.Text.Json.Serialization;

using CloverleafTrack.Api.Managers;
using CloverleafTrack.Api.Options;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CloverleafTrack.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CurrentSeasonOptions>(Configuration.GetSection(CurrentSeasonOptions.Name));
            services.Configure<DatabaseOptions>(Configuration.GetSection(DatabaseOptions.Name));

            services.AddControllers().AddJsonOptions(x =>
            {
                x.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                x.JsonSerializerOptions.IgnoreNullValues = true;
            });

            services.AddScoped<RunningEventManager>();
            services.AddScoped<FieldEventManager>();
            services.AddScoped<LeaderboardManager>();
            //services.AddTransient<IAthleteManager, AthleteManager>();
            //services.AddTransient<IMeetManager, MeetManager>();
            //services.AddTransient<IPerformanceManager, PerformanceManager>();
            //services.AddTransient<ISeasonManager, SeasonManager>();
            //services.AddTransient<ITrackEventManager, TrackEventManager>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
