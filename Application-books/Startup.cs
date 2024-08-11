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

            services.AddTransient<IAutorServices, AutorServices>();
            services.AddTransient<ILibrosServices, LibrosServices>();
            services.AddTransient<ICalificacionesServices, CalificacionServices>();
            services.AddTransient<IUsuariosServices, UsuariosServices>();
<<<<<<< HEAD
            services.AddTransient<IMembresiaServicio, MembresiaServices>();
=======
>>>>>>> 05a8ee66c43c0e33b97da97cfe17dc4345c9bd9c

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
