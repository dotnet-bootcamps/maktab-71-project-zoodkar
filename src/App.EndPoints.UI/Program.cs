using App.Domain.AppSevices.Order;
using App.Domain.AppSevices.ServiceEntiry;
using App.Domain.AppSevices.UploadFile;
using App.Domain.AppSevices.User;
using App.Domain.Core.Data.Order;
using App.Domain.Core.Data.ServiceEntity;
using App.Domain.Core.Data.UploadFile;
using App.Domain.Core.Data.User;
using App.Domain.Core.Entities;
using App.Domain.Core.MppingProfile.Profiles;
using App.Domain.Core.Services.AppService.Order;
using App.Domain.Core.Services.AppService.ServiceEntity;
using App.Domain.Core.Services.AppService.UploadFile;
using App.Domain.Core.Services.AppService.User;
using App.Domain.Core.Services.Service.Order;
using App.Domain.Core.Services.Service.ServiceEntity;
using App.Domain.Core.Services.Service.UploadFile;
using App.Domain.Core.Services.Service.User;
using App.Domain.Services.Order;
using App.Domain.Services.ServiceEntiry;
using App.Domain.Services.UploadFile;
using App.Domain.Services.User;
using App.EndPoints.UI.UploadFile;
using App.Infrastructures.Database.SqlServer;
using App.Infrastructures.Repository.Ef.Order;
using App.Infrastructures.Repository.Ef.ServiceEntity;
using App.Infrastructures.Repository.Ef.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
    

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AppDbConnectionString")));


builder.Services.AddIdentity<AppUser, IdentityRole<int>>(
        options =>
        {
            options.SignIn.RequireConfirmedAccount = false;
            options.SignIn.RequireConfirmedEmail = false;
            options.SignIn.RequireConfirmedPhoneNumber = false;

            //options.User.AllowedUserNameCharacters
            //options.User.RequireUniqueEmail

            options.Password.RequireDigit = false;
            options.Password.RequireLowercase = false;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireUppercase = false;
            options.Password.RequiredLength = 3;
            options.Password.RequiredUniqueChars = 1;

        })
    .AddEntityFrameworkStores<AppDbContext>();

builder.Services.AddScoped<IServiceEntityAppService, ServiceEntityAppService>();
builder.Services.AddScoped<IServiceEntityService,ServiceEntityService>();
builder.Services.AddScoped<ICategoryAppService, CategoryAppService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IServiceRepository, ServiceRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IOrderAppService, OrderAppService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddAutoMapper(typeof(ServiceMappings).Assembly);
builder.Services.AddScoped<IUserAppService, UserAppService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUploadFileAppService, UploadFileAppService>();
builder.Services.AddScoped<IUploadFileService, UploadFileService>();
builder.Services.AddScoped<IUploadFileRepository, UploadFileRepository>();


var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();


//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllerRoute(
//      name: "areas",
//      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
//    );
//});

app.MapAreaControllerRoute(
    name: "areas",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}");


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
