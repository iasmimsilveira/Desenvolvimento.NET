using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SN.Web.Areas.Identity.Data;
using SN.Web.Data;

[assembly: HostingStartup(typeof(SN.Web.Areas.Identity.IdentityHostingStartup))]
namespace SN.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<SNWebContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("SNWebContextConnection")));

                services.AddDefaultIdentity<SNWebUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<SNWebContext>();
            });
        }
    }
}