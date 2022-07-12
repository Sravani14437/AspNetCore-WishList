using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WishList.Data;

namespace WishList
{
@@ -17,6 +18,7 @@ public class Startup
        public void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc();
        services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase("Wishlist"));
    }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.