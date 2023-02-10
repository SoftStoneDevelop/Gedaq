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
    p1.id,
    p1.firstname,
    p1.middlename,
    p1.lastname
FROM person p1
",
            typeof(Person),
            Gedaq.Provider.Enums.MethodType.Sync,//of Async
            Gedaq.Npgsql.Enums.SourceType.Connection,
            "GetAllPerson"
            )]
public class Person
//...

```

Now in the code we can call the ready method:
```C#

var persons = 
        connection
        .GetAllPerson()//IEnumerable<Person> or IAsyncEnumerable<Person>
        .ToList();

```

Comparison of getting 100000 Person in a loop(Size is number of loop iterations) from the database:

|          Method | Size |       Mean | Ratio |        Gen0 |        Gen1 |       Gen2 | Allocated | Alloc Ratio |
|---------------- |----- |-----------:|------:|------------:|------------:|-----------:|----------:|------------:|
|           **Gedaq** |   **10** |   **536.4 ms** |  **0.49** |  **27000.0000** |  **26000.0000** | **10000.0000** | **187.11 MB** |        **0.86** |
| Dapper.Query&lt;Person&gt; |   10 | 1,101.0 ms |  1.00 |  32000.0000 |  31000.0000 |  9000.0000 | 217.61 MB |        1.00 |
|                 |      |            |       |             |             |            |           |             |
|           **Gedaq** |   **20** | **1,095.3 ms** |  **0.48** |  **55000.0000** |  **54000.0000** | **21000.0000** | **374.21 MB** |        **0.86** |
| Dapper.Query&lt;Person&gt; |   20 | 2,271.2 ms |  1.00 |  63000.0000 |  62000.0000 | 16000.0000 | 435.23 MB |        1.00 |
|                 |      |            |       |             |             |            |           |             |
|           **Gedaq** |   **30** | **1,659.2 ms** |  **0.48** |  **83000.0000** |  **82000.0000** | **32000.0000** | **561.32 MB** |        **0.86** |
| Dapper.Query&lt;Person&gt; |   30 | 3,447.7 ms |  1.00 |  97000.0000 |  96000.0000 | 26000.0000 | 652.84 MB |        1.00 |
|                 |      |            |       |             |             |            |           |             |
|           **Gedaq** |   **40** | **2,211.6 ms** |  **0.49** | **111000.0000** | **110000.0000** | **43000.0000** | **748.43 MB** |        **0.86** |
| Dapper.Query&lt;Person&gt; |   40 | 4,553.0 ms |  1.00 | 129000.0000 | 128000.0000 | 34000.0000 | 870.45 MB |        1.00 |
