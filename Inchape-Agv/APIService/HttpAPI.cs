using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace APIService
{
    public class HttpAPI
    {
        private IHost _host;
        private static HttpAPI _instance = null;
        private static object _instanceSyncLock = new();

        public static HttpAPI Instance
        {
            get
            {
                object instanceSyncLock = _instanceSyncLock;
                HttpAPI instance;

                lock (instanceSyncLock) {
                    bool flag = _instance == null;
                    if (flag) {
                        _instance = new HttpAPI();
                    }
                    instance = _instance;
                }
                return instance;
            }
        }

        public IHostBuilder HostBuilder(int port)
        {
            return Host.CreateDefaultBuilder().ConfigureWebHostDefaults(builder =>
            {
                builder.UseUrls($"http://0.0.0.0:{port}");
                builder.ConfigureServices(services =>
                {
                    services.AddControllers();
                    services.AddEndpointsApiExplorer();
                    services.AddSwaggerGen(options =>
                    {
                        options.SwaggerDoc("v1", new OpenApiInfo
                        {
                            Title = "Infini RCS AGV",
                            Version = "v1"
                        });
                    });

                    services.AddCors(options =>
                    {
                        options.AddPolicy("AllowAll", policy =>
                        {
                            policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                        });
                    });
                });

                builder.Configure(app =>
                {
                    var env = app.ApplicationServices.GetRequiredService<IWebHostEnvironment>();
                    if (env.IsDevelopment())
                    {
                        app.UseDeveloperExceptionPage();
                    }

                    app.UseStaticFiles();
                    app.UseRouting();
                    app.UseSwagger();
                    app.UseCors("AllowAll");
                    app.UseSwaggerUI(ui =>
                    {
                        ui.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1");
                        ui.RoutePrefix = string.Empty;
                    });

                    app.UseEndpoints(endpoints =>
                    {
                        endpoints.MapControllers();
                    });
                });
            });
        }

        public void StartAPI(int port = 8000)
        {
            try
            {
                _host = HostBuilder(port).Build();
                _host.Start();
            }
            catch { }
        }

        public void StopAPI() {
            try
            {
                _host.StopAsync().GetAwaiter().GetResult();
                _host?.Dispose();
            }
            catch { }
        }
    }
}
