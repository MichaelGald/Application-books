using Application_books.Database;
using Application_books.Helpers;
using Application_books.Services;
using Application_books.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace Application_books
{
    public class Startup
    {
        private IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            //Add Custom services
            services.AddDbContext<ApplicationbooksContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient<IAutorServices, AutoresServices>();
            services.AddTransient<ILibrosServices, LibrosServices>();
<<<<<<< HEAD
            services.AddTransient<ICalificacionesServices, CalificacionesServices>();
            services.AddTransient<IUsuariosServices, UsuariosServices>();
            services.AddTransient<IMembresiaServicio, MembresiaServices>();

=======
>>>>>>> 7e0c0a2195fc86dd14460daf44473dd4f2af3fde

            // Configurar AutoMapper
            services.AddAutoMapper(typeof(AutoMapperProfile));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

    }
}
