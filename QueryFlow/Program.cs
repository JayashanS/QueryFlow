using GraphQL;
using GraphQL.Types;
using QueryFlow.GraphQL.Mutations;
using QueryFlow.GraphQL.Queries;
using QueryFlow.GraphQL.Schemas;
using QueryFlow.GraphQL.Types;
using QueryFlow.Repositories;

namespace QueryFlow
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddSingleton<IBookRepository, BookRepository>();
            builder.Services.AddSingleton<BookType>();
            builder.Services.AddSingleton<BookQuery>();
            builder.Services.AddSingleton<BookMutation>();
            builder.Services.AddGraphQL(b => b
                .AddSystemTextJson()
                .AddSchema<BookSchema>()
                .AddGraphTypes(typeof(BookSchema).Assembly));

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            // Configure middleware
            app.UseGraphQL<ISchema>();
            //app.UseGraphQLVoyager("/ui/voyager", new GraphQLVoyagerOptions { GraphQLEndPoint = "/graphql" });
            app.UseGraphQLVoyager();


            app.Run();
        }
    }
}
