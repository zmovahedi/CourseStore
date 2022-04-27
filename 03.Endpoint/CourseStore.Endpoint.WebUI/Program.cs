using CourseStore.Common.Domain.Repositories;
using CourseStore.Core.ApplicationService.Courses.CommandHandlers;
using CourseStore.Core.ApplicationService.Courses.QueryHandlers;
using CourseStore.Core.Domain.Courses.Repositories;
using CourseStore.Infra.Data.Commands.EF;
using CourseStore.Infra.Data.Commands.EF.Contexts;
using CourseStore.Infra.Data.Commands.EF.Courses.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<CourseStoreDbContext>(c => c.UseSqlServer("Server=.;Database=CourseStoreDb;User Id=sa; Password=z.movahedi@12"));
builder.Services.AddScoped<ICourseRepository, CourseRepository>();
builder.Services.AddScoped<ICourseQuery, CourseQuery>();
builder.Services.AddScoped<IUnitOfWork, CourseUnitOfWork>();
builder.Services.AddScoped<CreateCourseHandler>();
builder.Services.AddScoped<SetDescriptionHandler>();
builder.Services.AddScoped<GetCourseListHandler>();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
