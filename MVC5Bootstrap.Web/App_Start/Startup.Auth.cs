using System;
using Microsoft.Owin.Security.Cookies;
using Owin;
using MVC5Bootstrap.Infrastructure.Repository;
using System.Web.Mvc;
using System.Globalization;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OpenIdConnect;
using System.Threading.Tasks;
using System.Configuration;

namespace MVC5Bootstrap.Web
{
    public partial class Startup
    {
        ICustomerRepository customerRepository = DependencyResolver.Current.GetService<ICustomerRepository>();
        
        private static string clientId = ConfigurationManager.AppSettings["ida:ClientId"];
        private static string aadInstance = ConfigurationManager.AppSettings["ida:AADInstance"];
        private static string tenant = ConfigurationManager.AppSettings["ida:Tenant"];
        private static string postLogoutRedirectUri = ConfigurationManager.AppSettings["ida:PostLogoutRedirectUri"];

        string authority = String.Format(CultureInfo.InvariantCulture, aadInstance, tenant);

        public void ConfigureAuth(IAppBuilder app)
        {
            app.SetDefaultSignInAsAuthenticationType(CookieAuthenticationDefaults.AuthenticationType);

            app.UseCookieAuthentication(new CookieAuthenticationOptions());

            //app.UseOpenIdConnectAuthentication(
            //    new OpenIdConnectAuthenticationOptions
            //    {
            //        ClientId = clientId,
            //        Authority = authority,
            //        PostLogoutRedirectUri = postLogoutRedirectUri,
            //        Notifications = new OpenIdConnectAuthenticationNotifications
            //        {
            //            AuthenticationFailed = context =>
            //            {
            //                context.HandleResponse();
            //                context.Response.Redirect("/Error?message=" + context.Exception.Message);
            //                return Task.FromResult(0);
            //            },
            //            SecurityTokenValidated = context =>
            //            {
            //                var UserName = context.AuthenticationTicket.Identity.Name;

            //                var customer = customerRepository.GetById(UserName);

            //                if (customer == null) //he is in ad but not setup
            //                {
            //                    //TODO: Figure out what to do here...
            //                    context.HandleResponse();
            //                    context.Response.Redirect("/Error?message=Please contact the site adminstrator");
            //                }
            //                else
            //                {
            //                    System.Web.HttpContext.Current.Session["Customer"] = customer;
            //                }
            //                return Task.FromResult(0);
            //            }
            //        }
            //    });
        }
    }
}