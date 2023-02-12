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

|               Method | Size |       Mean | Ratio |        Gen0 |        Gen1 |       Gen2 | Allocated | Alloc Ratio |
|--------------------- |----- |-----------:|------:|------------:|------------:|-----------:|----------:|------------:|
|                **Gedaq** |   **10** |   **603.4 ms** |  **0.59** |  **29000.0000** |  **28000.0000** | **11000.0000** | **194.73 MB** |        **0.89** |
| Dapper.Query&lt;Person&gt; |   10 | 1,026.4 ms |  1.00 |  33000.0000 |  32000.0000 | 10000.0000 | 217.64 MB |        1.00 |
|                      |      |            |       |             |             |            |           |             |
|                **Gedaq** |   **20** | **1,180.1 ms** |  **0.57** |  **59000.0000** |  **58000.0000** | **23000.0000** | **389.46 MB** |        **0.89** |
| Dapper.Query&lt;Person&gt; |   20 | 2,052.6 ms |  1.00 |  68000.0000 |  67000.0000 | 25000.0000 | 435.28 MB |        1.00 |
|                      |      |            |       |             |             |            |           |             |
|                **Gedaq** |   **30** | **1,756.1 ms** |  **0.56** |  **88000.0000** |  **86000.0000** | **34000.0000** | **584.19 MB** |        **0.89** |
| Dapper.Query&lt;Person&gt; |   30 | 3,108.7 ms |  1.00 | 103000.0000 | 102000.0000 | 40000.0000 | 652.93 MB |        1.00 |

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
