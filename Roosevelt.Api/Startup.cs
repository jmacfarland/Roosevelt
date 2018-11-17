using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Roosevelt.Api.Models;

namespace Roosevelt.Api
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Change this bit to use the SQL database
            services.AddDbContext<StudentContext>(opt => 
                opt.UseInMemoryDatabase("Student"));
            services.AddMvc()
                    .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
        }
    }
}