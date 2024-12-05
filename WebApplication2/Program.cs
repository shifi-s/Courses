using Courses; 
using Courses.Core.Repositories;
using Courses.Core.Services;
using Courses.Data;
using Courses.Data.Repositories;
using Courses.Service;

namespace Courses.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<ITeacherRepository,TeacherRepository>();
            builder.Services.AddScoped<ICourseRepository, CourseRepository>();
            builder.Services.AddScoped<IStudentRepository, StudentRepository>();
            builder.Services.AddScoped<ITeacherService,TeacherService>();
            builder.Services.AddScoped<IStudentService,StudentService>();
            builder.Services.AddScoped<ICourseService,CourseService>();
          //  builder.Services.AddSingleton<IDataContext, DataContext>();
            builder.Services.AddDbContext<IDataContext, DataContext>();
            var app = builder.Build();


            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}