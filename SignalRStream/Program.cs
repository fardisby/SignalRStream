using Microsoft.AspNetCore.Http.Connections;
using SignalRStream;

namespace SignalRStreamTestApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddSignalR();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

           /* app.MapHub<TestHub>("/testhub", options =>
            {
                options.Transports =
                    HttpTransportType.WebSockets |
                    HttpTransportType.LongPolling;
            });*/

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<TestHub>("/testhub");
            });
        

        app.Run();
        }
    }
}