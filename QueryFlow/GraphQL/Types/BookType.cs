using GraphQL.Types;
using QueryFlow.Models;

namespace QueryFlow.GraphQL.Types;

public class BookType : ObjectGraphType<Book>
{
    public BookType()
    {
        Name = "Book";

        Field(x => x.Id).Description("The ID of the book");
        Field(x => x.Title).Description("The title of the book");
        Field(x => x.Author).Description("The author of the book");
        Field(x => x.Price).Description("The price of the book");
    }
}
