using Gedaq.Provider;
using Gedaq.Provider.Attributes;
using Gedaq.Provider.Enums;

namespace TestApp
{
    [Provider(Dialect.Postgres)]
    public sealed class PostgresRequest : GedaqRequest
    {
    }
}