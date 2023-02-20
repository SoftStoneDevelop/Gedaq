using Gedaq.Npgsql.Attributes;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace NpgsqlTests
{
    [TestFixture]
    internal partial class ReadFixture : BaseFixture
    {
        [Test]
        [QueryBatch("BatchReadToClass", Gedaq.Common.Enums.QueryType.Read | Gedaq.Common.Enums.QueryType.Scalar, Gedaq.Common.Enums.MethodType.Sync)]
        [BatchPart("ToClass2", "BatchReadToClass", 1)]
        [BatchPart("ToClass1", "BatchReadToClass", 2)]
        public void BatchReadToClass()
        {
            var batchList = _dataSource.OpenConnection().BatchReadToClass(3, 6, 3).Select(sel => sel.ToList()).ToList();
            CheckBatchEnumerable(batchList);
        }

        [Test]
        public void BatchReadToClassCommand()
        {
            var batchCommand = _dataSource.OpenConnection().CreateBatchReadToClassBatch();
            batchCommand.SetBatchReadToClassParametrs(3, 6, 3);
            var batchList = batchCommand.ExecuteBatchReadToClassBatch().Select(sel => sel.ToList()).ToList();

            CheckBatchEnumerable(batchList);
        }

        private void CheckBatchEnumerable(List<List<ReadFixtureModel>> batchList)
        {
            var list = batchList[0];
            {
                Assert.That(list, Has.Count.EqualTo(8));

                Assert.Multiple(() =>
                {
                    Assert.That(list[0].Id, Is.EqualTo(0));
                    Assert.That(list[0].FirstName, Is.EqualTo("John0"));
                    Assert.That(list[0].MiddleName, Is.EqualTo("Сurly0"));
                    Assert.That(list[0].LastName, Is.EqualTo("Doe0"));

                    Assert.That(list[0].Identification, Is.EqualTo(null));
                });

                Assert.Multiple(() =>
                {
                    Assert.That(list[3].Id, Is.EqualTo(4));
                    Assert.That(list[3].FirstName, Is.EqualTo("John4"));
                    Assert.That(list[3].MiddleName, Is.EqualTo("Сurly4"));
                    Assert.That(list[3].LastName, Is.EqualTo("Doe4"));

                    Assert.That(list[3].Identification, Is.Not.EqualTo(null));
                });

                var identification = list[3].Identification;
                Assert.Multiple(() =>
                {
                    Assert.That(identification.Id, Is.EqualTo(4));
                    Assert.That(identification.TypeName, Is.EqualTo("citizen's passport"));

                    Assert.That(identification.Country, Is.EqualTo(null));
                });

                Assert.Multiple(() =>
                {
                    Assert.That(list[4].Id, Is.EqualTo(5));
                    Assert.That(list[4].FirstName, Is.EqualTo("John5"));
                    Assert.That(list[4].MiddleName, Is.EqualTo("Сurly5"));
                    Assert.That(list[4].LastName, Is.EqualTo("Doe5"));

                    Assert.That(list[4].Identification, Is.Not.EqualTo(null));
                });

                identification = list[4].Identification;
                Assert.Multiple(() =>
                {
                    Assert.That(identification.Id, Is.EqualTo(5));
                    Assert.That(identification.TypeName, Is.EqualTo("party card"));

                    Assert.That(identification.Country, Is.Not.EqualTo(null));
                });

                var country = list[4].Identification.Country;
                Assert.Multiple(() =>
                {
                    Assert.That(country.Id, Is.EqualTo(5));
                    Assert.That(country.Name, Is.EqualTo("Martian colony"));
                });
            }

            list = batchList[1];
            {
                Assert.That(list, Has.Count.EqualTo(9));

                Assert.Multiple(() =>
                {
                    Assert.That(list[0].Id, Is.EqualTo(0));
                    Assert.That(list[0].FirstName, Is.EqualTo("John0"));
                    Assert.That(list[0].MiddleName, Is.EqualTo("Сurly0"));
                    Assert.That(list[0].LastName, Is.EqualTo("Doe0"));

                    Assert.That(list[0].Identification, Is.EqualTo(null));
                });

                Assert.Multiple(() =>
                {
                    Assert.That(list[3].Id, Is.EqualTo(4));
                    Assert.That(list[3].FirstName, Is.EqualTo("John4"));
                    Assert.That(list[3].MiddleName, Is.EqualTo("Сurly4"));
                    Assert.That(list[3].LastName, Is.EqualTo("Doe4"));

                    Assert.That(list[3].Identification, Is.Not.EqualTo(null));
                });

                var identification = list[3].Identification;
                Assert.Multiple(() =>
                {
                    Assert.That(identification.Id, Is.EqualTo(4));
                    Assert.That(identification.TypeName, Is.EqualTo("citizen's passport"));

                    Assert.That(identification.Country, Is.EqualTo(null));
                });

                Assert.Multiple(() =>
                {
                    Assert.That(list[4].Id, Is.EqualTo(5));
                    Assert.That(list[4].FirstName, Is.EqualTo("John5"));
                    Assert.That(list[4].MiddleName, Is.EqualTo("Сurly5"));
                    Assert.That(list[4].LastName, Is.EqualTo("Doe5"));

                    Assert.That(list[4].Identification, Is.Not.EqualTo(null));
                });

                identification = list[4].Identification;
                Assert.Multiple(() =>
                {
                    Assert.That(identification.Id, Is.EqualTo(5));
                    Assert.That(identification.TypeName, Is.EqualTo("party card"));

                    Assert.That(identification.Country, Is.Not.EqualTo(null));
                });

                var country = list[4].Identification.Country;
                Assert.Multiple(() =>
                {
                    Assert.That(country.Id, Is.EqualTo(5));
                    Assert.That(country.Name, Is.EqualTo("Martian colony"));
                });
            }
        }

        [Test]
        public void BatchScalarToClass()
        {
            var id = _dataSource.OpenConnection().ScalarBatchReadToClass(0, 1, 3);
            Assert.That(id, Is.EqualTo(2));
        }
    }
}