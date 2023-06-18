using Gedaq.Parser;
using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    internal partial class PostgreSQLParserFixture
    {
        [Test]
        public void Parse()
        {
            var parser = new PostgreSQLQueryParser();
            var sql = @"
SELECT 
 
 
 
 
        p1.id ASid,
          p1.firstname
 
  
 


,     


    p1.middlename  as  
middlenameN
 
 ,
    p1.lastname

 
 
 
FROM person p1
";
            var aliases = parser.Parse(ref sql);
            Assert.Multiple(() =>
            {
                Assert.That(aliases.IsRoot, Is.EqualTo(true));
                Assert.That(aliases.IsRowsAffected, Is.EqualTo(false));
                Assert.That(aliases.Fields, Has.Count.EqualTo(4));
                Assert.That(aliases.InnerEntities, Has.Count.EqualTo(0));

                Assert.That(aliases.Fields[0].Name, Is.EqualTo("ASid"));
                Assert.That(aliases.Fields[0].Position, Is.EqualTo(0));

                Assert.That(aliases.Fields[1].Name, Is.EqualTo("firstname"));
                Assert.That(aliases.Fields[1].Position, Is.EqualTo(1));

                Assert.That(aliases.Fields[2].Name, Is.EqualTo("middlenameN"));
                Assert.That(aliases.Fields[2].Position, Is.EqualTo(2));

                Assert.That(aliases.Fields[3].Name, Is.EqualTo("lastname"));
                Assert.That(aliases.Fields[3].Position, Is.EqualTo(3));
            });
        }

        [Test]
        public void ParseWithoutAlias()
        {
            var parser = new PostgreSQLQueryParser();
            var sql = @"
SELECT id  , firstname  
  
 


,     


    middlename
 
 ,
    lastname

 
 
 
FROM person
";
            var aliases = parser.Parse(ref sql);
            Assert.Multiple(() =>
            {
                Assert.That(aliases.IsRoot, Is.EqualTo(true));
                Assert.That(aliases.IsRowsAffected, Is.EqualTo(false));
                Assert.That(aliases.Fields, Has.Count.EqualTo(4));
                Assert.That(aliases.InnerEntities, Has.Count.EqualTo(0));

                Assert.That(aliases.Fields[0].Name, Is.EqualTo("id"));
                Assert.That(aliases.Fields[0].Position, Is.EqualTo(0));

                Assert.That(aliases.Fields[1].Name, Is.EqualTo("firstname"));
                Assert.That(aliases.Fields[1].Position, Is.EqualTo(1));

                Assert.That(aliases.Fields[2].Name, Is.EqualTo("middlename"));
                Assert.That(aliases.Fields[2].Position, Is.EqualTo(2));

                Assert.That(aliases.Fields[3].Name, Is.EqualTo("lastname"));
                Assert.That(aliases.Fields[3].Position, Is.EqualTo(3));
            });
        }

        [Test]
        public void ParseBrackets()
        {
            var parser = new PostgreSQLQueryParser();
            var sql = @"
SELECT 
 (
 
 
 
        p1.id as ASid,
          p1.firstname
 
  
 


,     


    p1.middlename  
 
 ,
    p1.lastname

 ) aS

person,
 (
 
 
 
        p1.id,
          p1.firstname
 
  
 


,     


    p1.middlename  
 
 ,
    p1.lastname

 )
   
person2

 
 
FROM person p1
";
            var aliases = parser.Parse(ref sql);
            Assert.Multiple(() =>
            {
                Assert.That(aliases.IsRoot, Is.EqualTo(true));
                Assert.That(aliases.IsRowsAffected, Is.EqualTo(false));
                Assert.That(aliases.Fields, Has.Count.EqualTo(2));
                Assert.That(aliases.InnerEntities, Has.Count.EqualTo(0));

                Assert.That(aliases.Fields[0].Name, Is.EqualTo("person"));
                Assert.That(aliases.Fields[0].Position, Is.EqualTo(0));

                Assert.That(aliases.Fields[1].Name, Is.EqualTo("person2"));
                Assert.That(aliases.Fields[1].Position, Is.EqualTo(1));
            });
        }

        [Test]
        public void GetLastSplitedItem()
        {
            var parser = new PostgreSQLQueryParser();
            var sql = @"
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
FROM person p1;
".AsSpan();
            var lastItem = parser.GetLastSplitedItem(sql, ';');
            Assert.That(lastItem, Is.EqualTo(188));

            sql = @"
SELECT 
    p1.id,
    p1.firstname,
    p1.middlename,
    p1.lastname
FROM person p1;
".AsSpan();
            lastItem = parser.GetLastSplitedItem(sql, ';');
            Assert.That(lastItem, Is.EqualTo(0));

            sql = @"
SELECT 
    p1.id,
    p1.firstname,
    p1.middlename,
    p1.lastname
FROM person p1
".AsSpan();
            lastItem = parser.GetLastSplitedItem(sql, ';');
            Assert.That(lastItem, Is.EqualTo(0));

            sql = @"
SELECT 
    p1.id,
    p1.firstname,
    p1.middlename,
    p1.lastname
FROM person p1     
 
;
 
 
".AsSpan();
            lastItem = parser.GetLastSplitedItem(sql, ';');
            Assert.That(lastItem, Is.EqualTo(0));
        }

        [Test]
        public void InnerTest()
        {
            var parser = new PostgreSQLQueryParser();
            var inSql = @"
SELECT 
    p1.id,
    p1.firstname,
    p1.middlename,
~StartInner::Identification:id~
    i.id,
~StartInner::country:id~
    c.id,
    c.name,
~EndInner::country~
    i.typename,
~EndInner::Identification~
    p1.lastname
FROM person p1
LEFT JOIN identification i ON i.id = p1.identification_id
LEFT JOIN country c ON c.id = i.country_id
;
";
            var aliases = parser.Parse(ref inSql);
            var outSql = @"
SELECT 
    p1.id,
    p1.firstname,
    p1.middlename,

    i.id,

    c.id,
    c.name,

    i.typename,

    p1.lastname
FROM person p1
LEFT JOIN identification i ON i.id = p1.identification_id
LEFT JOIN country c ON c.id = i.country_id
;
";
            Assert.Multiple(() =>
            {
                Assert.That(inSql, Is.EqualTo(outSql));
                Assert.That(aliases.IsRoot, Is.EqualTo(true));
                Assert.That(aliases.IsRowsAffected, Is.EqualTo(false));
                Assert.That(aliases.Fields, Has.Count.EqualTo(4));
                Assert.That(aliases.InnerEntities, Has.Count.EqualTo(1));
            });
            Assert.Multiple(() =>
            {
                Assert.That(aliases.Fields[0].Name, Is.EqualTo("id"));
                Assert.That(aliases.Fields[0].Position, Is.EqualTo(0));
                Assert.That(aliases.Fields[1].Name, Is.EqualTo("firstname"));
                Assert.That(aliases.Fields[1].Position, Is.EqualTo(1));
                Assert.That(aliases.Fields[2].Name, Is.EqualTo("middlename"));
                Assert.That(aliases.Fields[2].Position, Is.EqualTo(2));
                Assert.That(aliases.Fields[3].Name, Is.EqualTo("lastname"));
                Assert.That(aliases.Fields[3].Position, Is.EqualTo(7));
            });

            var identification = aliases.InnerEntities[0];
            Assert.Multiple(() =>
            {
                Assert.That(identification.IsRoot, Is.EqualTo(false));
                Assert.That(identification.IsRowsAffected, Is.EqualTo(false));
                Assert.That(identification.Fields, Has.Count.EqualTo(2));
                Assert.That(identification.LinkKey, Is.EqualTo("id"));
                Assert.That(identification.InnerEntities, Has.Count.EqualTo(1));
            });
            Assert.Multiple(() =>
            {
                Assert.That(identification.Fields[0].Name, Is.EqualTo("id"));
                Assert.That(identification.Fields[0].Position, Is.EqualTo(3));
                Assert.That(identification.Fields[1].Name, Is.EqualTo("typename"));
                Assert.That(identification.Fields[1].Position, Is.EqualTo(6));
            });
            
            var country = identification.InnerEntities[0];
            Assert.Multiple(() =>
            {
                Assert.That(country.IsRoot, Is.EqualTo(false));
                Assert.That(country.IsRowsAffected, Is.EqualTo(false));
                Assert.That(country.Fields, Has.Count.EqualTo(2));
                Assert.That(country.LinkKey, Is.EqualTo("id"));
                Assert.That(country.InnerEntities, Has.Count.EqualTo(0));
            });
            Assert.Multiple(() =>
            {
                Assert.That(country.Fields[0].Name, Is.EqualTo("id"));
                Assert.That(country.Fields[0].Position, Is.EqualTo(4));
                Assert.That(country.Fields[1].Name, Is.EqualTo("name"));
                Assert.That(country.Fields[1].Position, Is.EqualTo(5));
            });
        }

        [Test]
        public void ReinterpretTest()
        {
            var parser = new PostgreSQLQueryParser();
            var inSql = @"
SELECT 
    p1.id,
    p1.firstname,
    p1.middlename,
~StartInner::Identification:id~
~Reinterpret::id~
    identification_id,
~EndInner::Identification~
    p1.lastname
FROM person p1
;
";
            var aliases = parser.Parse(ref inSql);
            var outSql = @"
SELECT 
    p1.id,
    p1.firstname,
    p1.middlename,


    identification_id,

    p1.lastname
FROM person p1
;
";
            Assert.Multiple(() =>
            {
                Assert.That(inSql, Is.EqualTo(outSql));
                Assert.That(aliases.IsRoot, Is.EqualTo(true));
                Assert.That(aliases.IsRowsAffected, Is.EqualTo(false));
                Assert.That(aliases.Fields, Has.Count.EqualTo(4));
                Assert.That(aliases.InnerEntities, Has.Count.EqualTo(1));
            });
            Assert.Multiple(() =>
            {
                Assert.That(aliases.Fields[0].Name, Is.EqualTo("id"));
                Assert.That(aliases.Fields[0].Position, Is.EqualTo(0));
                Assert.That(aliases.Fields[1].Name, Is.EqualTo("firstname"));
                Assert.That(aliases.Fields[1].Position, Is.EqualTo(1));
                Assert.That(aliases.Fields[2].Name, Is.EqualTo("middlename"));
                Assert.That(aliases.Fields[2].Position, Is.EqualTo(2));
                Assert.That(aliases.Fields[3].Name, Is.EqualTo("lastname"));
                Assert.That(aliases.Fields[3].Position, Is.EqualTo(4));
            });

            var identification = aliases.InnerEntities[0];
            Assert.Multiple(() =>
            {
                Assert.That(identification.IsRoot, Is.EqualTo(false));
                Assert.That(identification.IsRowsAffected, Is.EqualTo(false));
                Assert.That(identification.Fields, Has.Count.EqualTo(1));
                Assert.That(identification.LinkKey, Is.EqualTo("id"));
                Assert.That(identification.InnerEntities, Has.Count.EqualTo(0));
            });
            Assert.Multiple(() =>
            {
                Assert.That(identification.Fields[0].Name, Is.EqualTo("id"));
                Assert.That(identification.Fields[0].Position, Is.EqualTo(3));
            });
        }

        [Test]
        public void ParseReturning()
        {
            var parser = new PostgreSQLQueryParser();
            var sql = @"
INSERT INTO test_table(
	column1,
    column2,
    column3
)
VALUES (
    $1,
    $2, 
    $3
)
 
RETURNING    
    column1,   
    column3,
column2
;
";
            var aliases = parser.Parse(ref sql);
            Assert.Multiple(() =>
            {
                Assert.That(aliases.IsRoot, Is.EqualTo(true));
                Assert.That(aliases.IsRowsAffected, Is.EqualTo(false));
                Assert.That(aliases.Fields, Has.Count.EqualTo(3));
                Assert.That(aliases.InnerEntities, Has.Count.EqualTo(0));

                Assert.That(aliases.Fields[0].Name, Is.EqualTo("column1"));
                Assert.That(aliases.Fields[0].Position, Is.EqualTo(0));

                Assert.That(aliases.Fields[1].Name, Is.EqualTo("column3"));
                Assert.That(aliases.Fields[1].Position, Is.EqualTo(1));

                Assert.That(aliases.Fields[2].Name, Is.EqualTo("column2"));
                Assert.That(aliases.Fields[2].Position, Is.EqualTo(2));
            });
        }
    }
}