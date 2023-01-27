using Rhetos;
using NLog.Web;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRhetosHost((serviceProvider, rhetosHostBuilder) => rhetosHostBuilder
                  .ConfigureRhetosAppDefaults()
                  .UseBuilderLogProviderFromHost(serviceProvider)
                  .ConfigureConfiguration(cfg => cfg.MapNetCoreConfiguration(builder.Configuration)))
              .AddAspNetCoreIdentityUser()
              .AddHostLogging()
              .AddRestApi(o =>
              {
                  o.BaseRoute = "rest";
                  o.GroupNameMapper = (conceptInfo, controller, oldName) => "v1";
              })
              .AddHostLogging();

// Add services to the container.

builder.Services.AddControllers()
    .AddNewtonsoftJson(o =>
    {
        // Using NewtonsoftJson for backward-compatibility with older versions of RestGenerator:
        // 1. Properties starting with uppercase in JSON objects.
        o.UseMemberCasing();
        // 2. Legacy Microsoft DateTime serialization.
        o.SerializerSettings.DateFormatHandling = Newtonsoft.Json.DateFormatHandling.MicrosoftDateFormat;
        // 3. byte[] serialization as JSON array of integers instead of Base64 string.
        o.SerializerSettings.Converters.Add(new Rhetos.Host.AspNet.RestApi.Utilities.ByteArrayConverter());
    });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(o => o.CustomSchemaIds(type => type.ToString())); // CustomSchemaIds allows multiple entities with the same name in different modules.
builder.Host.UseNLog();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseRhetosRestApi();

app.MapControllers();

app.Run();
