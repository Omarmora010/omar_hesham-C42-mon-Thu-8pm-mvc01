using Microsoft.AspNetCore.Mvc;

namespace omar_hesham_C42_mon_Thu_8pm_mvc01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            var app = builder.Build();
            app.UseRouting();
            #region oldMethod

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/Home", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello From Home");
            //    });
            //    endpoints.MapGet("/Products/{id:int?}", async context =>
            //    {
            //        var ID = context.Request.RouteValues["id"];
            //        if (ID is not null)
            //        {
            //            int id = Convert.ToInt32(ID);
            //            await context.Response.WriteAsync($"Hello From Products where ID is {ID}");
            //        }
            //        else
            //        {
            //            await context.Response.WriteAsync("Hello From Products");
            //        }

            //    });
            //    endpoints.MapGet("/Books/{Id}/{Author:alpha?:minlength(5):maxlength(10)}", async context =>
            //        {
            //            int id = Convert.ToInt32(context.Request.RouteValues["Id"]);
            //            string Author = Convert.ToString(context.Request.RouteValues["Author"]);
            //            await context.Response.WriteAsync($"Hello From Books where id = {id} and author = {Author}");
            //        });
            //}); 
            #endregion


            app.MapControllerRoute(
                name: "HomeController",
                pattern : "/{controller = HomeController } / { Action = Index } ",
                defaults: new {Controller = "HomeController", Action = "AboutUs" }
                );


            //app.Run(async (HttpContext) => { await HttpContext.Response.WriteAsync("Your Requested Page Is Not Available"); } );

            app.Run();
        }
    }
}
