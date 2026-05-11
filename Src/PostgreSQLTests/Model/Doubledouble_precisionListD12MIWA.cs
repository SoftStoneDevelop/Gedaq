
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class Doubledouble_precisionListD12MIWA
    {
        [Gedaq.Npgsql.Attributes.DbType((NpgsqlTypes.NpgsqlDbType)(9))]
        [Gedaq.Common.Attributes.Alias(order: 0)]
        public System.Int32 Id { get; set; }

        [Gedaq.Npgsql.Attributes.DbType((NpgsqlTypes.NpgsqlDbType)(-2147483640))]
        [Gedaq.Common.Attributes.Alias(order: 1)]
        public System.Collections.Generic.List<System.Double> Value { get; set; }

        [Gedaq.Npgsql.Attributes.DbType((NpgsqlTypes.NpgsqlDbType)(-2147483640))]
        [Gedaq.Common.Attributes.Alias(order: 2)]
        public System.Collections.Generic.List<System.Double> NullableValue { get; set; }

        public static void AssertModel(Doubledouble_precisionListD12MIWA actual, Doubledouble_precisionListD12MI expect, bool checkInInnerOnlyId)
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