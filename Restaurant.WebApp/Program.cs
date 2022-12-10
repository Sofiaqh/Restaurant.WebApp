using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Hosting.StaticWebAssets;
using MudBlazor.Services;
using Restaurant.WebApp.Data;

var builder = WebApplication.CreateBuilder(args);

StaticWebAssetsLoader.UseStaticWebAssets(builder.Environment, builder.Configuration);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddMudServices();

//Ignorar certificado HTML
var httClientHandler = new HttpClientHandler();
httClientHandler.ServerCertificateCustomValidationCallback =
    (message, cert, chain, errors) => true;

//Lectura del archivo de configuración
var appSettingSection = builder.Configuration.GetSection("AppSettings");
builder.Services.Configure<AppSettings>(appSettingSection);

///Inyección del dominio
builder.Services.AddSingleton(new HttpClient(httClientHandler)
{
    BaseAddress = new Uri(appSettingSection["BaseUrl"])
});


builder.Services.AddHttpClient<IUserServices, UserServices>();
builder.Services.AddHttpClient<IClientServices, ClientServices>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();