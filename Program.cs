
using PollingApi.Hubs;
using PollingApi.Services;

namespace PollingApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddSignalR();
            builder.Services
                .AddSingleton<PollService>();

            builder.Services.AddSpaStaticFiles(configuration =>
            {

                configuration.RootPath = "pollingclient/dist";

            });

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigins", policy =>
                {
                    policy.WithOrigins("http://localhost:3000")
                          .AllowAnyMethod()
                          .AllowAnyHeader()
                          .AllowCredentials();
                });

            });

            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors("AllowSpecificOrigins");

            app.MapControllers();

            app.MapHub<VoteHub>("/voteHub");


            app.Run();
        }
    }
}
