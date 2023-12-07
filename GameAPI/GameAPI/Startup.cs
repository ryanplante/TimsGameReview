using DataLibrary.Data;
using DataLibrary.Db;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace GameAPI
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
            services.AddControllers();
            services.AddSingleton(new ConnectionStringData { SqlConnectionName = "Default" });

            services.AddSingleton<IDataAccess, SqlDb>();
            services.AddSingleton<IGameRatingData, GameRatingData>();
            services.AddSingleton<IVideoGameData, VideoGameData>();
            services.AddSingleton<IUserData, UserData>();
            services.AddSingleton<IGenreData, GenreData>();
            services.AddCors(options =>
            {
                options.AddPolicy("AllowOrigin", builder => builder.AllowAnyOrigin()
                .AllowAnyMethod().AllowAnyHeader());
            });
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "GameAPI", Version = "v1" });
            });
            services.AddOptions();
            //services.Configure<Microsoft.Extensions.Configuration.ConfigurationBinderException>(Configuration);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "GameAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            // Use the CORS policy
            app.UseCors("AllowOrigin");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
