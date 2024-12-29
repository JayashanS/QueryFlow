using GraphQL.Types;
using QueryFlow.GraphQL.Mutations;
using QueryFlow.GraphQL.Queries;

namespace QueryFlow.GraphQL.Schemas
{
    public class BookSchema : Schema
    {
        public BookSchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<BookQuery>();
            Mutation = serviceProvider.GetRequiredService<BookMutation>();
        }
    }
}
