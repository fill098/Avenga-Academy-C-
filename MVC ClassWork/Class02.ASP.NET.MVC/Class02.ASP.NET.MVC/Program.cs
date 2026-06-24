using Microsoft.AspNetCore.Routing.Constraints;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

// CONVETIONAL ROUTING
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.MapControllerRoute(
    name: "courses",
    pattern: "courses/allcourses",
    defaults: new { controller = "Courses", action = "GetAllCurses" }
    );

app.MapControllerRoute(
    name: "course_by_name_with_constraint",
    pattern: "courses/{name}",
    defaults: new { controller = "Courses", action = "GetCourseByName" },
    constraints: new { name = new MinLengthRouteConstraint(5) }
    );

app.MapControllerRoute(
    name: "course_multiple_parms",
    pattern: "courses/{id}/{name}",
    defaults: new { controller = "Courses", action = "GetCoursesByIdAndName" },
    constraints: new { id = new IntRouteConstraint() }
    );

app.MapControllerRoute(
    name: "course_by_id",
    pattern: "courses/GetCourseById/{id:int}",
    defaults: new { controller = "Courses", action = "GetCourseById" }
    );




app.Run();
