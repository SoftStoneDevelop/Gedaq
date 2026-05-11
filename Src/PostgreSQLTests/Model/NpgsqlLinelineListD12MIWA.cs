
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class NpgsqlLinelineListD12MIWA
    {
        [Gedaq.Npgsql.Attributes.DbType((NpgsqlTypes.NpgsqlDbType)(9))]
        [Gedaq.Common.Attributes.Alias(order: 0)]
        public System.Int32 Id { get; set; }

        [Gedaq.Npgsql.Attributes.DbType((NpgsqlTypes.NpgsqlDbType)(-2147483638))]
        [Gedaq.Common.Attributes.Alias(order: 1)]
        public System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine> Value { get; set; }

        [Gedaq.Npgsql.Attributes.DbType((NpgsqlTypes.NpgsqlDbType)(-2147483638))]
        [Gedaq.Common.Attributes.Alias(order: 2)]
        public System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine> NullableValue { get; set; }

        public static void AssertModel(NpgsqlLinelineListD12MIWA actual, NpgsqlLinelineListD12MI expect, bool checkInInnerOnlyId)
        {
                Assert.That(actual, Is.Not.Null);
                Assert.That(actual.Id, Is.EqualTo(expect.Id));

                if (expect.NullableValue == null)
                {
                    Assert.That(actual.NullableValue, Is.Null);
                }
                else
                {
                    Assert.That(actual.NullableValue, Is.Not.Null);
                }
        }
    }
}