using NUnit.Framework;
using System;

namespace NpgsqlTests
{
    [TestFixture]
    internal partial class SqlParserFixture
    {
        [Test]
        public void Parse()
        {
            var parser = new Gedaq.Npgsql.QueryParser();
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
            var parser = new Gedaq.Npgsql.QueryParser();
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
            var parser = new Gedaq.Npgsql.QueryParser();
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
            var parser = new Gedaq.Npgsql.QueryParser();
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
            Assert.IsTrue(188 == lastItem);

            sql = @"
SELECT 
    p1.id,
    p1.firstname,
    p1.middlename,
    p1.lastname
FROM person p1;
".AsSpan();
            lastItem = parser.GetLastSplitedItem(sql, ';');
            Assert.IsTrue(0 == lastItem);

            sql = @"
SELECT 
    p1.id,
    p1.firstname,
    p1.middlename,
    p1.lastname
FROM person p1
".AsSpan();
            lastItem = parser.GetLastSplitedItem(sql, ';');
            Assert.IsTrue(0 == lastItem);

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
            Assert.IsTrue(0 == lastItem);
        }
    }
}