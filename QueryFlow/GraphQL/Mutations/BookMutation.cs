using GraphQL;
using GraphQL.Resolvers;
using GraphQL.Types;
using QueryFlow.GraphQL.Types;
using QueryFlow.Models;
using QueryFlow.Repositories;

namespace QueryFlow.GraphQL.Mutations;

public class BookMutation : ObjectGraphType
{
    public BookMutation(IBookRepository bookRepository)
    {
        AddField(new FieldType
        {
            Name = "addBook",
            Type = typeof(BookType),
            Arguments = new QueryArguments(
                new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "title" },
                new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "author" },
                new QueryArgument<NonNullGraphType<DecimalGraphType>> { Name = "price" }
            ),
            Resolver = new FuncFieldResolver<object>(context =>
            {
                var book = new Book
                {
                    Title = context.GetArgument<string>("title"),
                    Author = context.GetArgument<string>("author"),
                    Price = context.GetArgument<decimal>("price")
                };
                return bookRepository.AddBook(book);
            })
        });
    }
}
