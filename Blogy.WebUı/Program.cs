using Blogy.BussinessLayer.Abstract;
using Blogy.BussinessLayer.Concrate;
using Blogy.DataAccesLayer.Abstract;
using Blogy.DataAccesLayer.Context;
using Blogy.DataAccesLayer.EntityFramework;
using Blogy.EntityLayer.Concrete;
using Blogy.WebUI.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<BlogyContext>();

builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();


builder.Services.AddScoped<IToDoListService, ToDoListManager>();
builder.Services.AddScoped<IToDoListDal, EfToDoListDal>();

builder.Services.AddScoped<INotificationService, NotificationManager>();
builder.Services.AddScoped<INotificationDal, EfNotificationDal>();

builder.Services.AddScoped<IBrowserService, BrowserManager>();
builder.Services.AddScoped<IBrowserDal, EfBrowserDal>();

builder.Services.AddScoped<IWriterService, WriterManager>();
builder.Services.AddScoped<IWriterDal, EfWriterDal>();

builder.Services.AddScoped<IWriterMessageService, WriterMessageManager>();
builder.Services.AddScoped<IWriterMessageDal, EfWriterMessageDal>();

builder.Services.AddScoped<IArticleService, ArticleManager>();
builder.Services.AddScoped<IArticleDal, EfArticleDal>();

builder.Services.AddScoped<ICommentService, CommentManager>();
builder.Services.AddScoped<ICommentDal, EfCommentDal>();


builder.Services.AddScoped<ILayoutAboutService, LayoutAboutManager>();
builder.Services.AddScoped<ILayoutAboutDal, EfLayoutAboutDal>();

builder.Services.AddScoped<IBlogAboutPictureOrDescriptionService, BlogAboutPictureOrDescriptionManager>();
builder.Services.AddScoped<IBlogAboutPictureOrDescriptionDal, EfBlogAboutPictureOrDescriptionDal>();

builder.Services.AddScoped<IBlogAboutServiceService, BlogAboutServiceManager>();
builder.Services.AddScoped<IBlogAboutServiceDal, EfBlogAboutServiceDal>();

builder.Services.AddScoped<IBlogAboutBloggerPublishingService, BlogAboutBloggerPublishingManager>();
builder.Services.AddScoped<IBlogAboutBloggerPublishingDal, EfBlogAboutBloggerPublishingDal>();

builder.Services.AddScoped<IBlogContactService, BlogContactManager>();
builder.Services.AddScoped<IBlogContactDal, EfBlogContactDal>();

builder.Services.AddScoped<ITagService, TagManager>();
builder.Services.AddScoped<ITagDal, EfTagDal>();





builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<BlogyContext>().AddErrorDescriber<CustomIdentityValidatior>();

builder.Services.AddControllersWithViews();


builder.Services.AddMvc(config =>
{
    var policy = new AuthorizationPolicyBuilder()
                       .RequireAuthenticatedUser()
                       .Build();
    config.Filters.Add(new AuthorizeFilter(policy));
});

builder.Services.AddMvc();


builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(150000);
    options.AccessDeniedPath = "/ErrorPage/Index/";
    options.LoginPath = "/Writer/WriterLogin/Index/";
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStatusCodePagesWithReExecute("/ErrorPage/Index/");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});


app.Run();
