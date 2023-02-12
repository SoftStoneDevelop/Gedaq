<h1 align="center">
  <a>Gedaq</a>
</h1>

<h3 align="center">

  [![Nuget](https://img.shields.io/nuget/v/Gedaq?logo=Gedaq)](https://www.nuget.org/packages/Gedaq/)
  [![Downloads](https://img.shields.io/nuget/dt/Gedaq.svg)](https://www.nuget.org/packages/Gedaq/)
  [![Stars](https://img.shields.io/github/stars/SoftStoneDevelop/Gedaq?color=brightgreen)](https://github.com/SoftStoneDevelop/Gedaq/stargazers)
  [![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)

</h3>

Generator of methods for obtaining data from databases.

Usage:

For example, we have a Person class:
```C#

public class Person
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string MiddleName { get; set; }

    public string LastName { get; set; }
    
    public Identification Identification { get; set; }
}

public class Identification
{
    public int Id { get; set; }
    public string TypeName { get; set; }
}

```
We just mark anywhere in the code with a special attribute (class, structure, method) that tells the analyzer to generate the data acquisition code.
Let's mark the Person class itself with an attribute:

```C#

[Gedaq.Npgsql.Attributes.QueryRead(
            @"
SELECT 
    p.id,
    p.firstname,
~StartInner::Identification:id~
    i.id,
    i.typename,
~EndInner::Identification~
    p.middlename,
    p.lastname
FROM person p
LEFT JOIN identification i ON i.id = p.identification_id
",
            typeof(Person),
            MethodType.Sync | MethodType.Async,
            Connection,
            "GetAllPerson"
            )]
public class Person
//...

```

Now in the code we can call the ready method:
```C#

var persons = 
        connection
        .GetAllPerson()
        .ToList();
        
var personsAsync = 
        await connection
        .GetAllPersonAsync()
        .ToListAsync();

```

Comparison of getting 100000 Person in a loop(Size is number of loop iterations) from the database:


|                                         Method | Size |       Mean | Ratio |        Gen0 |        Gen1 |       Gen2 | Allocated | Alloc Ratio |
|----------------------------------------------- |----- |-----------:|------:|------------:|------------:|-----------:|----------:|------------:|
|                                          **Gedaq** |   **10** |   **806.3 ms** |  **0.54** |  **36000.0000** |  **35000.0000** | **13000.0000** | **237.46 MB** |        **0.83** |
| &#39;Dapper.Query&lt;Person, Identification, Person&gt;&#39; |   10 | 1,504.6 ms |  1.00 |  46000.0000 |  45000.0000 | 14000.0000 | 287.05 MB |        1.00 |
|                                                |      |            |       |             |             |            |           |             |
|                                          **Gedaq** |   **20** | **1,566.4 ms** |  **0.52** |  **73000.0000** |  **72000.0000** | **27000.0000** | **474.93 MB** |        **0.83** |
| &#39;Dapper.Query&lt;Person, Identification, Person&gt;&#39; |   20 | 2,993.6 ms |  1.00 |  94000.0000 |  93000.0000 | 30000.0000 | 574.12 MB |        1.00 |
|                                                |      |            |       |             |             |            |           |             |
|                                          **Gedaq** |   **30** | **2,325.3 ms** |  **0.51** | **111000.0000** | **110000.0000** | **43000.0000** |  **712.4 MB** |        **0.83** |
| &#39;Dapper.Query&lt;Person, Identification, Person&gt;&#39; |   30 | 4,557.2 ms |  1.00 | 140000.0000 | 139000.0000 | 44000.0000 | 861.15 MB |        1.00 |
