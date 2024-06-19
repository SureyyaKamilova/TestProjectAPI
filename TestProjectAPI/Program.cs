using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using TestProjectAPI.Concrete;
using TestProjectAPI.Interfaces;
using TestProjectAPI.Services;

namespace TestProjectAPI
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

            builder.Services.AddDbContext<Context>(options => options.UseSqlServer(""));
            builder.Services.AddScoped<IBookService, BookService>();

            var options = new DbContextOptionsBuilder<Context>()
                              .UseSqlServer("")
                              .Options;

            using (var context = new Context(options))
            {
                var bookService = new BookService(context);
                bookService.AvailableBooks();
            }

            using(var context = new Context(options))
            {
                var bookService = new BookService(context);

                bookService.BookInsert("1984","George Orwell","dystoping",1,"10096785432");

                var featuredBooks = bookService.GetBooks("dedektiv");
                Console.WriteLine("Book:" + featuredBooks);
            }

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
