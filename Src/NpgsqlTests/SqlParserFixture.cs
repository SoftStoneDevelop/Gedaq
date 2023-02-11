using NUnit.Framework;

namespace NpgsqlTests
{
    [TestFixture]
    internal partial class SqlParserFixture
    {
        [Test]
        public void TestSqlParser()
        {
            var parser = new Gedaq.Npgsql.QueryParser();
            var aliases = parser.Parse(@"
SELECT 
    p1.id,
    p1.firstname,
    p1.middlename,
    p1.lastname
FROM person p1
"
                );

            Assert.Multiple(() =>
            {
                Assert.That(aliases.IsRoot, Is.EqualTo(true));
                Assert.That(aliases.Fields, Has.Count.EqualTo(4));
                Assert.That(aliases.InnerEntities, Has.Count.EqualTo(0));

                Assert.That(aliases.Fields[0].Name, Is.EqualTo("id"));
                Assert.That(aliases.Fields[1].Name, Is.EqualTo("firstname"));
                Assert.That(aliases.Fields[2].Name, Is.EqualTo("middlename"));
                Assert.That(aliases.Fields[3].Name, Is.EqualTo("lastname"));
            });
        }

        [Test]
        public void FindInstructionRegex()
        {
            var matches1 = Gedaq.Npgsql.QueryParser.FindInstructionRegex.Matches(@"
SELECT 
    p1.id,
    p1.firstname,
    p1.middlename,
    p1.lastname
FROM person p1
");
            Assert.That(matches1, Has.Count.EqualTo(1));

            var matches2 = Gedaq.Npgsql.QueryParser.FindInstructionRegex.Matches(@"
SELECT 
    p1.id,
    p1.firstname,
    p1.middlename,
    p1.lastname
FROM person p1;
SELECT 
    p1.id,
    p1.firstname,
    p1.middlename,
    p1.lastname
FROM person p1;
SELECT 
    p1.id,
    p1.firstname,
    p1.middlename,
    p1.lastname
FROM person p1
");
            Assert.That(matches2, Has.Count.EqualTo(3));
        }
    }
}