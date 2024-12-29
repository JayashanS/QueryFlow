using GraphQL;
using GraphQL.Resolvers;
using GraphQL.Types;
using QueryFlow.GraphQL.Types;
using QueryFlow.Repositories;

namespace QueryFlow.GraphQL.Queries;

public class BookQuery : ObjectGraphType
{
    public BookQuery(IBookRepository bookRepository)
    {
        AddField(new FieldType
        {
            Name = "books",
            Type = typeof(ListGraphType<BookType>),
            Description = "Get all books",
            Resolver = new FuncFieldResolver<object>(context => bookRepository.GetAll())
        });

        AddField(new FieldType
        {
            Name = "book",
            Type = typeof(BookType),
            Description = "Get a book by id",
            Arguments = new QueryArguments(
                new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id", Description = "The id of the book" }
            ),
            Resolver = new FuncFieldResolver<object>(context =>
            {
                var id = context.GetArgument<int>("id");
                return bookRepository.GetById(id);
            })
        });
    }
}
