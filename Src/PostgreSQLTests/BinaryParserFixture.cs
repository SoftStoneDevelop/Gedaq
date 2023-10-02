using Gedaq.Npgsql.Parser;
using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    internal partial class BinaryParserFixture
    {
        [Test]
        public void FindBody()
        {
            var parser = new BinaryParser();
            var inSql = @"
COPY readfixtureperson 
(
id,
~Reinterpret::id~
readfixtureidentification_id,
firstname,
middlename,
lastname
) TO STDOUT (FORMAT BINARY)
;
".AsSpan();
            var body = parser.FindBody(inSql, out var start, out var end);
            var expectBody = inSql.Slice(28, 92).ToString();

            Assert.Multiple(() =>
            {
                Assert.That(start, Is.EqualTo(28));
                Assert.That(end, Is.EqualTo(120));
            });

            var bodyStr = body.ToString();
            Assert.Multiple(() =>
            {
                Assert.That(bodyStr, Is.EqualTo(expectBody));
            });
        }

        [Test]
        public void TableParse()
        {
            var parser = new BinaryParser();
            var inSql = @"
COPY readfixtureperson 
(
id,
~StartInner::Identification:id~
    ~Reinterpret::id~
readfixtureidentification_id,
~EndInner::Identification~
firstname,
middlename,
lastname
) TO STDOUT (FORMAT BINARY)
;
";
            var aliases = parser.Parse(ref inSql);
            var outSql = @"
COPY readfixtureperson 
(
id,

    
readfixtureidentification_id,

firstname,
middlename,
lastname
) TO STDOUT (FORMAT BINARY)
;
";
            Assert.Multiple(() =>
            {
                Assert.That(inSql, Is.EqualTo(outSql));
            });
        }

        [Test]
        public void SubqueryParse()
        {
            var parser = new BinaryParser();
            var inSql = @"
COPY 
(
SELECT 
    P.id,
    p.firstname,
~StartInner::Identification:id~
    i.id,
~StartInner::Country:id~
    c.id,
    c.name,
~EndInner::Country~
    i.typename,
~EndInner::Identification~
    p.middlename,
    p.lastname
FROM readfixtureperson p
LEFT JOIN readfixtureidentification i ON i.id = p.readfixtureidentification_id
LEFT JOIN readfixturecountry c ON c.id = i.readfixturecountry_id
ORDER BY p.id ASC
) TO STDOUT (FORMAT BINARY)
;
";
            var aliases = parser.Parse(ref inSql);
            var outSql = @"
COPY 
(
SELECT 
    P.id,
    p.firstname,

    i.id,

    c.id,
    c.name,

    i.typename,

    p.middlename,
    p.lastname
FROM readfixtureperson p
LEFT JOIN readfixtureidentification i ON i.id = p.readfixtureidentification_id
LEFT JOIN readfixturecountry c ON c.id = i.readfixturecountry_id
ORDER BY p.id ASC
) TO STDOUT (FORMAT BINARY)
;
";
            Assert.Multiple(() =>
            {
                Assert.That(inSql, Is.EqualTo(outSql));
            });
        }
    }
}