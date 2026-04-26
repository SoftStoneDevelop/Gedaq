

using Npgsql;
using NpgsqlTypes;
using Gedaq.Common.Enums;
using Gedaq.Npgsql.Attributes;
using Gedaq.Npgsql.Enums;
using System;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IDateOnlyListdateArray
    {
    }
    
    internal partial class DateOnlyListdateArray : IDateOnlyListdateArray
    {


#region TestData

        private readonly DateOnlydateArray2M[] _testData = new DateOnlydateArray2M[]
        {
            new DateOnlydateArray2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1986, month: 10, day: 18),

new DateOnly(year: 1917, month: 10, day: 2),

new DateOnly(year: 1958, month: 10, day: 9),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateOnlydateArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1998, month: 10, day: 14),

new DateOnly(year: 2019, month: 10, day: 17),

new DateOnly(year: 1937, month: 10, day: 14),

new DateOnly(year: 1936, month: 10, day: 4),

},
    ModelInner = new DateOnlydateArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1983, month: 10, day: 5),

new DateOnly(year: 2017, month: 10, day: 2),

new DateOnly(year: 2014, month: 10, day: 7),

new DateOnly(year: 2011, month: 10, day: 8),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1947, month: 10, day: 2),

new DateOnly(year: 1997, month: 10, day: 2),

new DateOnly(year: 1992, month: 10, day: 12),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1928, month: 10, day: 17),

new DateOnly(year: 1971, month: 10, day: 16),

new DateOnly(year: 1966, month: 10, day: 3),

new DateOnly(year: 1976, month: 10, day: 10),

},
},
            new DateOnlydateArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1983, month: 10, day: 15),

new DateOnly(year: 1972, month: 10, day: 19),

new DateOnly(year: 1973, month: 10, day: 14),

new DateOnly(year: 2009, month: 10, day: 19),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateOnlydateArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1933, month: 10, day: 6),

new DateOnly(year: 1943, month: 10, day: 18),

new DateOnly(year: 1929, month: 10, day: 17),

new DateOnly(year: 1985, month: 10, day: 17),

},
    ModelInner = new DateOnlydateArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1918, month: 10, day: 14),

new DateOnly(year: 1982, month: 10, day: 5),

new DateOnly(year: 1987, month: 10, day: 16),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1993, month: 10, day: 7),

new DateOnly(year: 1922, month: 10, day: 13),

new DateOnly(year: 1939, month: 10, day: 4),

new DateOnly(year: 1920, month: 10, day: 18),

},
},
            new DateOnlydateArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1976, month: 10, day: 5),

new DateOnly(year: 2017, month: 10, day: 14),

new DateOnly(year: 1964, month: 10, day: 9),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1983, month: 10, day: 1),

new DateOnly(year: 1956, month: 10, day: 14),

new DateOnly(year: 1937, month: 10, day: 12),

},
},
            new DateOnlydateArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2007, month: 10, day: 3),

new DateOnly(year: 1947, month: 10, day: 13),

new DateOnly(year: 1998, month: 10, day: 9),

new DateOnly(year: 1942, month: 10, day: 8),

},
    ModelInner = new DateOnlydateArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1924, month: 10, day: 10),

new DateOnly(year: 1923, month: 10, day: 5),

new DateOnly(year: 1954, month: 10, day: 12),

new DateOnly(year: 1987, month: 10, day: 14),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1985, month: 10, day: 16),

new DateOnly(year: 1917, month: 10, day: 5),

new DateOnly(year: 1941, month: 10, day: 9),

},
},
    NullableValue = null,
},
            new DateOnlydateArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1988, month: 10, day: 15),

new DateOnly(year: 1927, month: 10, day: 11),

new DateOnly(year: 1947, month: 10, day: 2),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1934, month: 10, day: 12),

new DateOnly(year: 1962, month: 10, day: 7),

new DateOnly(year: 1984, month: 10, day: 6),

},
},
            new DateOnlydateArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1969, month: 10, day: 8),

new DateOnly(year: 1975, month: 10, day: 11),

new DateOnly(year: 2008, month: 10, day: 5),

new DateOnly(year: 2019, month: 10, day: 19),

},
    ModelInner = new DateOnlydateArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1937, month: 10, day: 2),

new DateOnly(year: 1968, month: 10, day: 12),

new DateOnly(year: 1970, month: 10, day: 7),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1991, month: 10, day: 8),

new DateOnly(year: 1998, month: 10, day: 12),

new DateOnly(year: 1946, month: 10, day: 11),

},
},
            new DateOnlydateArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1933, month: 10, day: 3),

new DateOnly(year: 2016, month: 10, day: 14),

new DateOnly(year: 2017, month: 10, day: 6),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateOnlydateArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1986, month: 10, day: 1),

new DateOnly(year: 2003, month: 10, day: 11),

new DateOnly(year: 1926, month: 10, day: 7),

},
    ModelInner = new DateOnlydateArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2014, month: 10, day: 19),

new DateOnly(year: 1934, month: 10, day: 3),

new DateOnly(year: 2008, month: 10, day: 17),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2015, month: 10, day: 9),

new DateOnly(year: 1995, month: 10, day: 16),

new DateOnly(year: 1997, month: 10, day: 2),

},
},
    NullableValue = null,
},
            new DateOnlydateArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1997, month: 10, day: 15),

new DateOnly(year: 2017, month: 10, day: 1),

new DateOnly(year: 2005, month: 10, day: 11),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateOnlydateArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1965, month: 10, day: 12),

new DateOnly(year: 1953, month: 10, day: 17),

new DateOnly(year: 1986, month: 10, day: 9),

},
    ModelInner = new DateOnlydateArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2008, month: 10, day: 19),

new DateOnly(year: 1930, month: 10, day: 17),

new DateOnly(year: 1939, month: 10, day: 12),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateOnlydateArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2002, month: 10, day: 15),

new DateOnly(year: 1975, month: 10, day: 9),

new DateOnly(year: 1930, month: 10, day: 2),

new DateOnly(year: 1963, month: 10, day: 14),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1980, month: 10, day: 9),

new DateOnly(year: 1974, month: 10, day: 12),

new DateOnly(year: 1972, month: 10, day: 6),

new DateOnly(year: 1977, month: 10, day: 8),

},
},
            new DateOnlydateArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1924, month: 10, day: 9),

new DateOnly(year: 1994, month: 10, day: 19),

new DateOnly(year: 2005, month: 10, day: 6),

new DateOnly(year: 2005, month: 10, day: 5),

},
    ModelInner = new DateOnlydateArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1921, month: 10, day: 7),

new DateOnly(year: 1995, month: 10, day: 1),

new DateOnly(year: 1968, month: 10, day: 5),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateOnlydateArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1922, month: 10, day: 5),

new DateOnly(year: 1930, month: 10, day: 8),

new DateOnly(year: 1944, month: 10, day: 5),

new DateOnly(year: 1997, month: 10, day: 9),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2000, month: 10, day: 10),

new DateOnly(year: 1963, month: 10, day: 11),

new DateOnly(year: 1923, month: 10, day: 2),

new DateOnly(year: 1957, month: 10, day: 16),

},
},
            new DateOnlydateArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1976, month: 10, day: 7),

new DateOnly(year: 2014, month: 10, day: 6),

new DateOnly(year: 1921, month: 10, day: 12),

},
    ModelInner = new DateOnlydateArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1987, month: 10, day: 18),

new DateOnly(year: 1978, month: 10, day: 10),

new DateOnly(year: 1952, month: 10, day: 2),

new DateOnly(year: 1951, month: 10, day: 4),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1920, month: 10, day: 11),

new DateOnly(year: 1969, month: 10, day: 13),

new DateOnly(year: 1949, month: 10, day: 13),

new DateOnly(year: 2013, month: 10, day: 14),

},
},
            new DateOnlydateArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1965, month: 10, day: 9),

new DateOnly(year: 1946, month: 10, day: 9),

new DateOnly(year: 1942, month: 10, day: 15),

new DateOnly(year: 2019, month: 10, day: 9),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1990, month: 10, day: 7),

new DateOnly(year: 2000, month: 10, day: 1),

new DateOnly(year: 1935, month: 10, day: 19),

},
},
            new DateOnlydateArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1940, month: 10, day: 4),

new DateOnly(year: 1995, month: 10, day: 19),

new DateOnly(year: 1961, month: 10, day: 15),

},
    ModelInner = new DateOnlydateArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2012, month: 10, day: 7),

new DateOnly(year: 1990, month: 10, day: 12),

new DateOnly(year: 1927, month: 10, day: 2),

new DateOnly(year: 1944, month: 10, day: 1),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1974, month: 10, day: 5),

new DateOnly(year: 2002, month: 10, day: 14),

new DateOnly(year: 1957, month: 10, day: 6),

},
},
            new DateOnlydateArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1984, month: 10, day: 3),

new DateOnly(year: 2013, month: 10, day: 5),

new DateOnly(year: 2000, month: 10, day: 2),

new DateOnly(year: 1974, month: 10, day: 2),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateOnlydateArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1940, month: 10, day: 1),

new DateOnly(year: 1920, month: 10, day: 15),

new DateOnly(year: 1920, month: 10, day: 1),

},
    ModelInner = new DateOnlydateArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2012, month: 10, day: 7),

new DateOnly(year: 1979, month: 10, day: 6),

new DateOnly(year: 2018, month: 10, day: 4),

new DateOnly(year: 2017, month: 10, day: 5),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1939, month: 10, day: 8),

new DateOnly(year: 1932, month: 10, day: 16),

new DateOnly(year: 1950, month: 10, day: 17),

},
},
    NullableValue = null,
},
            new DateOnlydateArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2004, month: 10, day: 12),

new DateOnly(year: 2001, month: 10, day: 14),

new DateOnly(year: 1956, month: 10, day: 13),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateOnlydateArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1990, month: 10, day: 14),

new DateOnly(year: 1948, month: 10, day: 17),

new DateOnly(year: 1960, month: 10, day: 17),

new DateOnly(year: 1980, month: 10, day: 14),

},
    ModelInner = new DateOnlydateArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1958, month: 10, day: 2),

new DateOnly(year: 1942, month: 10, day: 1),

new DateOnly(year: 1989, month: 10, day: 16),

new DateOnly(year: 1991, month: 10, day: 15),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateOnlydateArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1963, month: 10, day: 14),

new DateOnly(year: 2015, month: 10, day: 16),

new DateOnly(year: 1978, month: 10, day: 12),

new DateOnly(year: 1922, month: 10, day: 2),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateOnlydateArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1917, month: 10, day: 17),

new DateOnly(year: 1968, month: 10, day: 19),

new DateOnly(year: 1938, month: 10, day: 8),

new DateOnly(year: 1945, month: 10, day: 17),

},
    ModelInner = new DateOnlydateArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1924, month: 10, day: 13),

new DateOnly(year: 1946, month: 10, day: 7),

new DateOnly(year: 1943, month: 10, day: 3),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2017, month: 10, day: 3),

new DateOnly(year: 1957, month: 10, day: 2),

new DateOnly(year: 1962, month: 10, day: 15),

},
},
            new DateOnlydateArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1952, month: 10, day: 7),

new DateOnly(year: 1977, month: 10, day: 8),

new DateOnly(year: 1963, month: 10, day: 8),

new DateOnly(year: 1937, month: 10, day: 14),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1971, month: 10, day: 3),

new DateOnly(year: 2010, month: 10, day: 6),

new DateOnly(year: 1950, month: 10, day: 16),

},
},
            new DateOnlydateArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1940, month: 10, day: 9),

new DateOnly(year: 1962, month: 10, day: 17),

new DateOnly(year: 1959, month: 10, day: 10),

new DateOnly(year: 2004, month: 10, day: 5),

},
    ModelInner = new DateOnlydateArray2MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1963, month: 10, day: 19),

new DateOnly(year: 2015, month: 10, day: 19),

new DateOnly(year: 2013, month: 10, day: 16),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1924, month: 10, day: 14),

new DateOnly(year: 1931, month: 10, day: 5),

new DateOnly(year: 1963, month: 10, day: 17),

new DateOnly(year: 2011, month: 10, day: 1),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1974, month: 10, day: 14),

new DateOnly(year: 1955, month: 10, day: 16),

new DateOnly(year: 1935, month: 10, day: 19),

new DateOnly(year: 1962, month: 10, day: 14),

},
},
            new DateOnlydateArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1923, month: 10, day: 12),

new DateOnly(year: 2002, month: 10, day: 19),

new DateOnly(year: 1935, month: 10, day: 13),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1951, month: 10, day: 15),

new DateOnly(year: 1969, month: 10, day: 2),

new DateOnly(year: 1957, month: 10, day: 3),

new DateOnly(year: 1936, month: 10, day: 1),

},
},
            new DateOnlydateArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1927, month: 10, day: 8),

new DateOnly(year: 1924, month: 10, day: 18),

new DateOnly(year: 1999, month: 10, day: 16),

},
    ModelInner = new DateOnlydateArray2MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1950, month: 10, day: 3),

new DateOnly(year: 1925, month: 10, day: 2),

new DateOnly(year: 1989, month: 10, day: 13),

new DateOnly(year: 1992, month: 10, day: 19),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateOnlydateArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1936, month: 10, day: 16),

new DateOnly(year: 1981, month: 10, day: 14),

new DateOnly(year: 1996, month: 10, day: 12),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1982, month: 10, day: 19),

new DateOnly(year: 1954, month: 10, day: 19),

new DateOnly(year: 2016, month: 10, day: 1),

},
},
            new DateOnlydateArray2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1973, month: 10, day: 12),

new DateOnly(year: 1972, month: 10, day: 8),

new DateOnly(year: 1959, month: 10, day: 11),

},
    ModelInner = new DateOnlydateArray2MI
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1940, month: 10, day: 2),

new DateOnly(year: 2016, month: 10, day: 11),

new DateOnly(year: 1991, month: 10, day: 10),

new DateOnly(year: 1965, month: 10, day: 3),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1922, month: 10, day: 6),

new DateOnly(year: 1959, month: 10, day: 13),

new DateOnly(year: 1984, month: 10, day: 15),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1971, month: 10, day: 13),

new DateOnly(year: 1927, month: 10, day: 2),

new DateOnly(year: 1928, month: 10, day: 9),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.dateonlydatearray2mi(
	id,
    value,
    nullablevalue
)
VALUES (
    $1, 
    $2, 
    $3
);
",
            methodName:"InsertModelInner",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyListdateArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateOnly>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483641)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateOnly>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483641))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.dateonlydatearray2mi(
	id,
    value,
    nullablevalue
)
VALUES (
    $1, 
    $2, 
    $3
)
RETURNING
    id,
    value,
    nullablevalue
;
",
            methodName:"InsertModelInnerReturning",
            queryMapTypes: [typeof(DateOnlydateArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyListdateArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateOnly>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483641)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateOnly>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483641))]
        public void InsertModelInnerReturningConfig()
        {
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((IDateOnlyListdateArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateOnlyListdateArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((IDateOnlyListdateArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlyListdateArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id =  ((IDateOnlyListdateArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDateOnlyListdateArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[11].ModelInner.Id));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IDateOnlyListdateArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDateOnlyListdateArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDateOnlyListdateArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDateOnlyListdateArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDateOnlyListdateArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDateOnlyListdateArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDateOnlyListdateArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDateOnlyListdateArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDateOnlyListdateArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.dateonlydatearray2m(
	id,
    value,
    nullablevalue,
    dateonlydatearray2mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
);
",
            methodName:"InsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyListdateArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateOnly>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483641)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateOnly>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483641)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "dateonlydatearray2mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;
                changedRows =  ((IDateOnlyListdateArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDateOnlyListdateArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;
                changedRows = await ((IDateOnlyListdateArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDateOnlyListdateArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.dateonlydatearray2m(
	id,
    value,
    nullablevalue,
    dateonlydatearray2mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
)
RETURNING
    nullablevalue,
    value,
~StartInner::ModelInner:Id~
~Reinterpret::Id~
    dateonlydatearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DateOnlydateArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyListdateArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.dateonlydatearray2m(
	id,
    value,
    nullablevalue,
    dateonlydatearray2mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
)
RETURNING
    nullablevalue,
    value,
~StartInner::ModelInner:Id~
~Reinterpret::Id~
    dateonlydatearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DateOnlydateArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyListdateArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateOnly>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483641)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateOnly>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483641)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "dateonlydatearray2mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DateOnlydateArray2M> models = null;

                models =  ((IDateOnlyListdateArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IDateOnlyListdateArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IDateOnlyListdateArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IDateOnlyListdateArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DateOnlydateArray2M> models = null;

                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateOnlydateArray2M), typeof(FlatDateOnlydateArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyListdateArray)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void MMDynQuerySelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.dateonlydatearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDateOnlydateArray2M>();
                var models2 = new List<FlatDateOnlydateArray2M>();
                await ((IDateOnlyListdateArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateOnlydateArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateOnlydateArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.dateonlydatearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDateOnlydateArray2M>();
                var models2 = new List<FlatDateOnlydateArray2M>();
                ((IDateOnlyListdateArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateOnlydateArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateOnlydateArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateOnlydateArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyListdateArray)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void DynQuerySelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.dateonlydatearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDateOnlyListdateArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateOnlydateArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.dateonlydatearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDateOnlyListdateArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateOnlydateArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.dateonlydatearray2m m
LEFT JOIN public.dateonlydatearray2mi mi ON mi.id = m.dateonlydatearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DateOnlydateArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyListdateArray)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void SelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDateOnlyListdateArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateOnlydateArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDateOnlyListdateArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateOnlydateArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateOnlydateArray2M), typeof(FlatDateOnlydateArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyListdateArray)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void MMDynQuerySelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.dateonlydatearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateOnlydateArray2M>();
                var models2 = new List<FlatDateOnlydateArray2M>();
                await ((IDateOnlyListdateArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateOnlydateArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateOnlydateArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.dateonlydatearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateOnlydateArray2M>();
                var models2 = new List<FlatDateOnlydateArray2M>();
                ((IDateOnlyListdateArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateOnlydateArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateOnlydateArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateOnlydateArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyListdateArray)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void DynQuerySelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.dateonlydatearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDateOnlyListdateArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateOnlydateArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.dateonlydatearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDateOnlyListdateArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateOnlydateArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.dateonlydatearray2m m
LEFT JOIN public.dateonlydatearray2mi mi ON mi.id = m.dateonlydatearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DateOnlydateArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyListdateArray)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateOnlyListdateArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateOnlydateArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDateOnlyListdateArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateOnlydateArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateOnlydateArray2M), typeof(FlatDateOnlydateArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyListdateArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.dateonlydatearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateOnlydateArray2M>();
                var models2 = new List<FlatDateOnlydateArray2M>();
                await((IDateOnlyListdateArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateOnlydateArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateOnlydateArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.dateonlydatearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateOnlydateArray2M>();
                var models2 = new List<FlatDateOnlydateArray2M>();
                ((IDateOnlyListdateArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateOnlydateArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateOnlydateArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateOnlydateArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyListdateArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyListdateArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionDynQuerySelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.dateonlydatearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDateOnlyListdateArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateOnlydateArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.dateonlydatearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.dateonlydatearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDateOnlyListdateArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatDateOnlydateArray2M.AssertModel(models[0],_testData[8], false);FlatDateOnlydateArray2M.AssertModel(models[1],_testData[9], false);FlatDateOnlydateArray2M.AssertModel(models[2],_testData[10], false);FlatDateOnlydateArray2M.AssertModel(models[3],_testData[11], false);FlatDateOnlydateArray2M.AssertModel(models[4],_testData[12], false);FlatDateOnlydateArray2M.AssertModel(models[5],_testData[13], false);FlatDateOnlydateArray2M.AssertModel(models[6],_testData[14], false);FlatDateOnlydateArray2M.AssertModel(models[7],_testData[15], false);FlatDateOnlydateArray2M.AssertModel(models[8],_testData[16], false);FlatDateOnlydateArray2M.AssertModel(models[9],_testData[17], false);FlatDateOnlydateArray2M.AssertModel(models[10],_testData[18], false);FlatDateOnlydateArray2M.AssertModel(models[11],_testData[19], false);FlatDateOnlydateArray2M.AssertModel(models[12],_testData[20], false);FlatDateOnlydateArray2M.AssertModel(models[13],_testData[21], false);FlatDateOnlydateArray2M.AssertModel(models[14],_testData[22], false);FlatDateOnlydateArray2M.AssertModel(models[15],_testData[23], false);FlatDateOnlydateArray2M.AssertModel(models[16],_testData[24], false);FlatDateOnlydateArray2M.AssertModel(models[17],_testData[25], false);FlatDateOnlydateArray2M.AssertModel(models[18],_testData[26], false);FlatDateOnlydateArray2M.AssertModel(models[19],_testData[27], false);FlatDateOnlydateArray2M.AssertModel(models[20],_testData[28], false);FlatDateOnlydateArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatDateOnlydateArray2M.AssertModel(models[0],_testData[21], false);FlatDateOnlydateArray2M.AssertModel(models[1],_testData[22], false);FlatDateOnlydateArray2M.AssertModel(models[2],_testData[23], false);FlatDateOnlydateArray2M.AssertModel(models[3],_testData[24], false);FlatDateOnlydateArray2M.AssertModel(models[4],_testData[25], false);FlatDateOnlydateArray2M.AssertModel(models[5],_testData[26], false);FlatDateOnlydateArray2M.AssertModel(models[6],_testData[27], false);FlatDateOnlydateArray2M.AssertModel(models[7],_testData[28], false);FlatDateOnlydateArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.dateonlydatearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDateOnlyListdateArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateOnlydateArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.dateonlydatearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.dateonlydatearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDateOnlyListdateArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatDateOnlydateArray2M.AssertModel(models[0],_testData[6], false);FlatDateOnlydateArray2M.AssertModel(models[1],_testData[7], false);FlatDateOnlydateArray2M.AssertModel(models[2],_testData[8], false);FlatDateOnlydateArray2M.AssertModel(models[3],_testData[9], false);FlatDateOnlydateArray2M.AssertModel(models[4],_testData[10], false);FlatDateOnlydateArray2M.AssertModel(models[5],_testData[11], false);FlatDateOnlydateArray2M.AssertModel(models[6],_testData[12], false);FlatDateOnlydateArray2M.AssertModel(models[7],_testData[13], false);FlatDateOnlydateArray2M.AssertModel(models[8],_testData[14], false);FlatDateOnlydateArray2M.AssertModel(models[9],_testData[15], false);FlatDateOnlydateArray2M.AssertModel(models[10],_testData[16], false);FlatDateOnlydateArray2M.AssertModel(models[11],_testData[17], false);FlatDateOnlydateArray2M.AssertModel(models[12],_testData[18], false);FlatDateOnlydateArray2M.AssertModel(models[13],_testData[19], false);FlatDateOnlydateArray2M.AssertModel(models[14],_testData[20], false);FlatDateOnlydateArray2M.AssertModel(models[15],_testData[21], false);FlatDateOnlydateArray2M.AssertModel(models[16],_testData[22], false);FlatDateOnlydateArray2M.AssertModel(models[17],_testData[23], false);FlatDateOnlydateArray2M.AssertModel(models[18],_testData[24], false);FlatDateOnlydateArray2M.AssertModel(models[19],_testData[25], false);FlatDateOnlydateArray2M.AssertModel(models[20],_testData[26], false);FlatDateOnlydateArray2M.AssertModel(models[21],_testData[27], false);FlatDateOnlydateArray2M.AssertModel(models[22],_testData[28], false);FlatDateOnlydateArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
FlatDateOnlydateArray2M.AssertModel(models[0],_testData[17], false);FlatDateOnlydateArray2M.AssertModel(models[1],_testData[18], false);FlatDateOnlydateArray2M.AssertModel(models[2],_testData[19], false);FlatDateOnlydateArray2M.AssertModel(models[3],_testData[20], false);FlatDateOnlydateArray2M.AssertModel(models[4],_testData[21], false);FlatDateOnlydateArray2M.AssertModel(models[5],_testData[22], false);FlatDateOnlydateArray2M.AssertModel(models[6],_testData[23], false);FlatDateOnlydateArray2M.AssertModel(models[7],_testData[24], false);FlatDateOnlydateArray2M.AssertModel(models[8],_testData[25], false);FlatDateOnlydateArray2M.AssertModel(models[9],_testData[26], false);FlatDateOnlydateArray2M.AssertModel(models[10],_testData[27], false);FlatDateOnlydateArray2M.AssertModel(models[11],_testData[28], false);FlatDateOnlydateArray2M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 

@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.dateonlydatearray2m m
LEFT JOIN public.dateonlydatearray2mi mi ON mi.id = m.dateonlydatearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DateOnlydateArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyListdateArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyListdateArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 2)]
        private void DbConnectionSelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDateOnlyListdateArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateOnlydateArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IDateOnlyListdateArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
DateOnlydateArray2M.AssertModel(models[0],_testData[1], false);DateOnlydateArray2M.AssertModel(models[1],_testData[2], false);DateOnlydateArray2M.AssertModel(models[2],_testData[3], false);DateOnlydateArray2M.AssertModel(models[3],_testData[4], false);DateOnlydateArray2M.AssertModel(models[4],_testData[5], false);DateOnlydateArray2M.AssertModel(models[5],_testData[6], false);DateOnlydateArray2M.AssertModel(models[6],_testData[7], false);DateOnlydateArray2M.AssertModel(models[7],_testData[8], false);DateOnlydateArray2M.AssertModel(models[8],_testData[9], false);DateOnlydateArray2M.AssertModel(models[9],_testData[10], false);DateOnlydateArray2M.AssertModel(models[10],_testData[11], false);DateOnlydateArray2M.AssertModel(models[11],_testData[12], false);DateOnlydateArray2M.AssertModel(models[12],_testData[13], false);DateOnlydateArray2M.AssertModel(models[13],_testData[14], false);DateOnlydateArray2M.AssertModel(models[14],_testData[15], false);DateOnlydateArray2M.AssertModel(models[15],_testData[16], false);DateOnlydateArray2M.AssertModel(models[16],_testData[17], false);DateOnlydateArray2M.AssertModel(models[17],_testData[18], false);DateOnlydateArray2M.AssertModel(models[18],_testData[19], false);DateOnlydateArray2M.AssertModel(models[19],_testData[20], false);DateOnlydateArray2M.AssertModel(models[20],_testData[21], false);DateOnlydateArray2M.AssertModel(models[21],_testData[22], false);DateOnlydateArray2M.AssertModel(models[22],_testData[23], false);DateOnlydateArray2M.AssertModel(models[23],_testData[24], false);DateOnlydateArray2M.AssertModel(models[24],_testData[25], false);DateOnlydateArray2M.AssertModel(models[25],_testData[26], false);DateOnlydateArray2M.AssertModel(models[26],_testData[27], false);DateOnlydateArray2M.AssertModel(models[27],_testData[28], false);DateOnlydateArray2M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
DateOnlydateArray2M.AssertModel(models[0],_testData[13], false);DateOnlydateArray2M.AssertModel(models[1],_testData[14], false);DateOnlydateArray2M.AssertModel(models[2],_testData[15], false);DateOnlydateArray2M.AssertModel(models[3],_testData[16], false);DateOnlydateArray2M.AssertModel(models[4],_testData[17], false);DateOnlydateArray2M.AssertModel(models[5],_testData[18], false);DateOnlydateArray2M.AssertModel(models[6],_testData[19], false);DateOnlydateArray2M.AssertModel(models[7],_testData[20], false);DateOnlydateArray2M.AssertModel(models[8],_testData[21], false);DateOnlydateArray2M.AssertModel(models[9],_testData[22], false);DateOnlydateArray2M.AssertModel(models[10],_testData[23], false);DateOnlydateArray2M.AssertModel(models[11],_testData[24], false);DateOnlydateArray2M.AssertModel(models[12],_testData[25], false);DateOnlydateArray2M.AssertModel(models[13],_testData[26], false);DateOnlydateArray2M.AssertModel(models[14],_testData[27], false);DateOnlydateArray2M.AssertModel(models[15],_testData[28], false);DateOnlydateArray2M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDateOnlyListdateArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateOnlydateArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IDateOnlyListdateArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
DateOnlydateArray2M.AssertModel(models[0],_testData[17], false);DateOnlydateArray2M.AssertModel(models[1],_testData[18], false);DateOnlydateArray2M.AssertModel(models[2],_testData[19], false);DateOnlydateArray2M.AssertModel(models[3],_testData[20], false);DateOnlydateArray2M.AssertModel(models[4],_testData[21], false);DateOnlydateArray2M.AssertModel(models[5],_testData[22], false);DateOnlydateArray2M.AssertModel(models[6],_testData[23], false);DateOnlydateArray2M.AssertModel(models[7],_testData[24], false);DateOnlydateArray2M.AssertModel(models[8],_testData[25], false);DateOnlydateArray2M.AssertModel(models[9],_testData[26], false);DateOnlydateArray2M.AssertModel(models[10],_testData[27], false);DateOnlydateArray2M.AssertModel(models[11],_testData[28], false);DateOnlydateArray2M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
DateOnlydateArray2M.AssertModel(models[0],_testData[21], false);DateOnlydateArray2M.AssertModel(models[1],_testData[22], false);DateOnlydateArray2M.AssertModel(models[2],_testData[23], false);DateOnlydateArray2M.AssertModel(models[3],_testData[24], false);DateOnlydateArray2M.AssertModel(models[4],_testData[25], false);DateOnlydateArray2M.AssertModel(models[5],_testData[26], false);DateOnlydateArray2M.AssertModel(models[6],_testData[27], false);DateOnlydateArray2M.AssertModel(models[7],_testData[28], false);DateOnlydateArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateOnlydateArray2M), typeof(FlatDateOnlydateArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyListdateArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.dateonlydatearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateOnlydateArray2M>();
                var models2 = new List<FlatDateOnlydateArray2M>();
                await((IDateOnlyListdateArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateOnlydateArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateOnlydateArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.dateonlydatearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateOnlydateArray2M>();
                var models2 = new List<FlatDateOnlydateArray2M>();
                ((IDateOnlyListdateArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateOnlydateArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateOnlydateArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateOnlydateArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyListdateArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyListdateArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 2)]
        private void DbConnectionDynQuerySelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.dateonlydatearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDateOnlyListdateArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateOnlydateArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.dateonlydatearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.dateonlydatearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDateOnlyListdateArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 106, query1, 133, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
FlatDateOnlydateArray2M.AssertModel(models[0],_testData[23], false);FlatDateOnlydateArray2M.AssertModel(models[1],_testData[24], false);FlatDateOnlydateArray2M.AssertModel(models[2],_testData[25], false);FlatDateOnlydateArray2M.AssertModel(models[3],_testData[26], false);FlatDateOnlydateArray2M.AssertModel(models[4],_testData[27], false);FlatDateOnlydateArray2M.AssertModel(models[5],_testData[28], false);FlatDateOnlydateArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
FlatDateOnlydateArray2M.AssertModel(models[0],_testData[27], false);FlatDateOnlydateArray2M.AssertModel(models[1],_testData[28], false);FlatDateOnlydateArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.dateonlydatearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDateOnlyListdateArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateOnlydateArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.dateonlydatearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.dateonlydatearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDateOnlyListdateArray)this).DbConnectionDynQuerySelectModelBatch(connection, 5, query1, 41, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatDateOnlydateArray2M.AssertModel(models[0],_testData[1], false);FlatDateOnlydateArray2M.AssertModel(models[1],_testData[2], false);FlatDateOnlydateArray2M.AssertModel(models[2],_testData[3], false);FlatDateOnlydateArray2M.AssertModel(models[3],_testData[4], false);FlatDateOnlydateArray2M.AssertModel(models[4],_testData[5], false);FlatDateOnlydateArray2M.AssertModel(models[5],_testData[6], false);FlatDateOnlydateArray2M.AssertModel(models[6],_testData[7], false);FlatDateOnlydateArray2M.AssertModel(models[7],_testData[8], false);FlatDateOnlydateArray2M.AssertModel(models[8],_testData[9], false);FlatDateOnlydateArray2M.AssertModel(models[9],_testData[10], false);FlatDateOnlydateArray2M.AssertModel(models[10],_testData[11], false);FlatDateOnlydateArray2M.AssertModel(models[11],_testData[12], false);FlatDateOnlydateArray2M.AssertModel(models[12],_testData[13], false);FlatDateOnlydateArray2M.AssertModel(models[13],_testData[14], false);FlatDateOnlydateArray2M.AssertModel(models[14],_testData[15], false);FlatDateOnlydateArray2M.AssertModel(models[15],_testData[16], false);FlatDateOnlydateArray2M.AssertModel(models[16],_testData[17], false);FlatDateOnlydateArray2M.AssertModel(models[17],_testData[18], false);FlatDateOnlydateArray2M.AssertModel(models[18],_testData[19], false);FlatDateOnlydateArray2M.AssertModel(models[19],_testData[20], false);FlatDateOnlydateArray2M.AssertModel(models[20],_testData[21], false);FlatDateOnlydateArray2M.AssertModel(models[21],_testData[22], false);FlatDateOnlydateArray2M.AssertModel(models[22],_testData[23], false);FlatDateOnlydateArray2M.AssertModel(models[23],_testData[24], false);FlatDateOnlydateArray2M.AssertModel(models[24],_testData[25], false);FlatDateOnlydateArray2M.AssertModel(models[25],_testData[26], false);FlatDateOnlydateArray2M.AssertModel(models[26],_testData[27], false);FlatDateOnlydateArray2M.AssertModel(models[27],_testData[28], false);FlatDateOnlydateArray2M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatDateOnlydateArray2M.AssertModel(models[0],_testData[8], false);FlatDateOnlydateArray2M.AssertModel(models[1],_testData[9], false);FlatDateOnlydateArray2M.AssertModel(models[2],_testData[10], false);FlatDateOnlydateArray2M.AssertModel(models[3],_testData[11], false);FlatDateOnlydateArray2M.AssertModel(models[4],_testData[12], false);FlatDateOnlydateArray2M.AssertModel(models[5],_testData[13], false);FlatDateOnlydateArray2M.AssertModel(models[6],_testData[14], false);FlatDateOnlydateArray2M.AssertModel(models[7],_testData[15], false);FlatDateOnlydateArray2M.AssertModel(models[8],_testData[16], false);FlatDateOnlydateArray2M.AssertModel(models[9],_testData[17], false);FlatDateOnlydateArray2M.AssertModel(models[10],_testData[18], false);FlatDateOnlydateArray2M.AssertModel(models[11],_testData[19], false);FlatDateOnlydateArray2M.AssertModel(models[12],_testData[20], false);FlatDateOnlydateArray2M.AssertModel(models[13],_testData[21], false);FlatDateOnlydateArray2M.AssertModel(models[14],_testData[22], false);FlatDateOnlydateArray2M.AssertModel(models[15],_testData[23], false);FlatDateOnlydateArray2M.AssertModel(models[16],_testData[24], false);FlatDateOnlydateArray2M.AssertModel(models[17],_testData[25], false);FlatDateOnlydateArray2M.AssertModel(models[18],_testData[26], false);FlatDateOnlydateArray2M.AssertModel(models[19],_testData[27], false);FlatDateOnlydateArray2M.AssertModel(models[20],_testData[28], false);FlatDateOnlydateArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 

@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.dateonlydatearray2m m
LEFT JOIN public.dateonlydatearray2mi mi ON mi.id = m.dateonlydatearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DateOnlydateArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyListdateArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyListdateArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2)]
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((IDateOnlyListdateArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateOnlydateArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateOnlyListdateArray)this).DbConnectionSelectModelBatchAsync(connection, 52, 81))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
DateOnlydateArray2M.AssertModel(models[0],_testData[11], false);DateOnlydateArray2M.AssertModel(models[1],_testData[12], false);DateOnlydateArray2M.AssertModel(models[2],_testData[13], false);DateOnlydateArray2M.AssertModel(models[3],_testData[14], false);DateOnlydateArray2M.AssertModel(models[4],_testData[15], false);DateOnlydateArray2M.AssertModel(models[5],_testData[16], false);DateOnlydateArray2M.AssertModel(models[6],_testData[17], false);DateOnlydateArray2M.AssertModel(models[7],_testData[18], false);DateOnlydateArray2M.AssertModel(models[8],_testData[19], false);DateOnlydateArray2M.AssertModel(models[9],_testData[20], false);DateOnlydateArray2M.AssertModel(models[10],_testData[21], false);DateOnlydateArray2M.AssertModel(models[11],_testData[22], false);DateOnlydateArray2M.AssertModel(models[12],_testData[23], false);DateOnlydateArray2M.AssertModel(models[13],_testData[24], false);DateOnlydateArray2M.AssertModel(models[14],_testData[25], false);DateOnlydateArray2M.AssertModel(models[15],_testData[26], false);DateOnlydateArray2M.AssertModel(models[16],_testData[27], false);DateOnlydateArray2M.AssertModel(models[17],_testData[28], false);DateOnlydateArray2M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
DateOnlydateArray2M.AssertModel(models[0],_testData[18], false);DateOnlydateArray2M.AssertModel(models[1],_testData[19], false);DateOnlydateArray2M.AssertModel(models[2],_testData[20], false);DateOnlydateArray2M.AssertModel(models[3],_testData[21], false);DateOnlydateArray2M.AssertModel(models[4],_testData[22], false);DateOnlydateArray2M.AssertModel(models[5],_testData[23], false);DateOnlydateArray2M.AssertModel(models[6],_testData[24], false);DateOnlydateArray2M.AssertModel(models[7],_testData[25], false);DateOnlydateArray2M.AssertModel(models[8],_testData[26], false);DateOnlydateArray2M.AssertModel(models[9],_testData[27], false);DateOnlydateArray2M.AssertModel(models[10],_testData[28], false);DateOnlydateArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = ((IDateOnlyListdateArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateOnlydateArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateOnlyListdateArray)this).DbConnectionSelectModelBatch(connection, 41, 28))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
DateOnlydateArray2M.AssertModel(models[0],_testData[8], false);DateOnlydateArray2M.AssertModel(models[1],_testData[9], false);DateOnlydateArray2M.AssertModel(models[2],_testData[10], false);DateOnlydateArray2M.AssertModel(models[3],_testData[11], false);DateOnlydateArray2M.AssertModel(models[4],_testData[12], false);DateOnlydateArray2M.AssertModel(models[5],_testData[13], false);DateOnlydateArray2M.AssertModel(models[6],_testData[14], false);DateOnlydateArray2M.AssertModel(models[7],_testData[15], false);DateOnlydateArray2M.AssertModel(models[8],_testData[16], false);DateOnlydateArray2M.AssertModel(models[9],_testData[17], false);DateOnlydateArray2M.AssertModel(models[10],_testData[18], false);DateOnlydateArray2M.AssertModel(models[11],_testData[19], false);DateOnlydateArray2M.AssertModel(models[12],_testData[20], false);DateOnlydateArray2M.AssertModel(models[13],_testData[21], false);DateOnlydateArray2M.AssertModel(models[14],_testData[22], false);DateOnlydateArray2M.AssertModel(models[15],_testData[23], false);DateOnlydateArray2M.AssertModel(models[16],_testData[24], false);DateOnlydateArray2M.AssertModel(models[17],_testData[25], false);DateOnlydateArray2M.AssertModel(models[18],_testData[26], false);DateOnlydateArray2M.AssertModel(models[19],_testData[27], false);DateOnlydateArray2M.AssertModel(models[20],_testData[28], false);DateOnlydateArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
DateOnlydateArray2M.AssertModel(models[0],_testData[6], false);DateOnlydateArray2M.AssertModel(models[1],_testData[7], false);DateOnlydateArray2M.AssertModel(models[2],_testData[8], false);DateOnlydateArray2M.AssertModel(models[3],_testData[9], false);DateOnlydateArray2M.AssertModel(models[4],_testData[10], false);DateOnlydateArray2M.AssertModel(models[5],_testData[11], false);DateOnlydateArray2M.AssertModel(models[6],_testData[12], false);DateOnlydateArray2M.AssertModel(models[7],_testData[13], false);DateOnlydateArray2M.AssertModel(models[8],_testData[14], false);DateOnlydateArray2M.AssertModel(models[9],_testData[15], false);DateOnlydateArray2M.AssertModel(models[10],_testData[16], false);DateOnlydateArray2M.AssertModel(models[11],_testData[17], false);DateOnlydateArray2M.AssertModel(models[12],_testData[18], false);DateOnlydateArray2M.AssertModel(models[13],_testData[19], false);DateOnlydateArray2M.AssertModel(models[14],_testData[20], false);DateOnlydateArray2M.AssertModel(models[15],_testData[21], false);DateOnlydateArray2M.AssertModel(models[16],_testData[22], false);DateOnlydateArray2M.AssertModel(models[17],_testData[23], false);DateOnlydateArray2M.AssertModel(models[18],_testData[24], false);DateOnlydateArray2M.AssertModel(models[19],_testData[25], false);DateOnlydateArray2M.AssertModel(models[20],_testData[26], false);DateOnlydateArray2M.AssertModel(models[21],_testData[27], false);DateOnlydateArray2M.AssertModel(models[22],_testData[28], false);DateOnlydateArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IDateOnlyListdateArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDateOnlyListdateArray)this).SetDbConnectionSelectModelParametrs(cmd, 129);
                var models = await ((IDateOnlyListdateArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
DateOnlydateArray2M.AssertModel(models[0],_testData[26], false);DateOnlydateArray2M.AssertModel(models[1],_testData[27], false);DateOnlydateArray2M.AssertModel(models[2],_testData[28], false);DateOnlydateArray2M.AssertModel(models[3],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateOnlyListdateArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateOnlyListdateArray)this).SetDbConnectionSelectModelParametrs(cmd, 81);
                var models =  ((IDateOnlyListdateArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
DateOnlydateArray2M.AssertModel(models[0],_testData[18], false);DateOnlydateArray2M.AssertModel(models[1],_testData[19], false);DateOnlydateArray2M.AssertModel(models[2],_testData[20], false);DateOnlydateArray2M.AssertModel(models[3],_testData[21], false);DateOnlydateArray2M.AssertModel(models[4],_testData[22], false);DateOnlydateArray2M.AssertModel(models[5],_testData[23], false);DateOnlydateArray2M.AssertModel(models[6],_testData[24], false);DateOnlydateArray2M.AssertModel(models[7],_testData[25], false);DateOnlydateArray2M.AssertModel(models[8],_testData[26], false);DateOnlydateArray2M.AssertModel(models[9],_testData[27], false);DateOnlydateArray2M.AssertModel(models[10],_testData[28], false);DateOnlydateArray2M.AssertModel(models[11],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_dateonlydatearray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(DateOnlydateArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483641),
                (NpgsqlTypes.NpgsqlDbType)(-2147483641)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyListdateArray))]
        private void ImportModelInnerConfig()
        {
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_dateonlydatearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DateOnlydateArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyListdateArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<DateOnlydateArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IDateOnlyListdateArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDateOnlyListdateArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateOnlydateArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
                importCollection.Clear();

                importCollection.Add(_testData[15].ModelInner);
                importCollection.Add(_testData[17].ModelInner);
                importCollection.Add(_testData[19].ModelInner);
                importCollection.Add(_testData[21].ModelInner);
                importCollection.Add(_testData[23].ModelInner);
                importCollection.Add(_testData[25].ModelInner);
                importCollection.Add(_testData[27].ModelInner);
                importCollection.Add(_testData[29].ModelInner);
                await ((IDateOnlyListdateArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IDateOnlyListdateArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateOnlydateArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_dateonlydatearray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
dateonlydatearray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(DateOnlydateArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483641),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483641)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyListdateArray))]
        private void ImportModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.binary_dateonlydatearray2m m
LEFT JOIN public.binary_dateonlydatearray2mi mi ON mi.id = m.dateonlydatearray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DateOnlydateArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyListdateArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<DateOnlydateArray2M>(15);

                    importCollection.Add(_testData[0]);
                    importCollection.Add(_testData[1]);
                    importCollection.Add(_testData[2]);
                    importCollection.Add(_testData[3]);
                    importCollection.Add(_testData[4]);
                    importCollection.Add(_testData[5]);
                    importCollection.Add(_testData[6]);
                    importCollection.Add(_testData[7]);
                    importCollection.Add(_testData[8]);
                    importCollection.Add(_testData[9]);
                    importCollection.Add(_testData[10]);
                    importCollection.Add(_testData[11]);
                    importCollection.Add(_testData[12]);
                    importCollection.Add(_testData[13]);
                    importCollection.Add(_testData[14]);
                ((IDateOnlyListdateArray)this).ImportModel(connection, importCollection);
                var models = ((IDateOnlyListdateArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                DateOnlydateArray2M.AssertModel(models[0],_testData[0], false);
                DateOnlydateArray2M.AssertModel(models[1],_testData[1], false);
                DateOnlydateArray2M.AssertModel(models[2],_testData[2], false);
                DateOnlydateArray2M.AssertModel(models[3],_testData[3], false);
                DateOnlydateArray2M.AssertModel(models[4],_testData[4], false);
                DateOnlydateArray2M.AssertModel(models[5],_testData[5], false);
                DateOnlydateArray2M.AssertModel(models[6],_testData[6], false);
                DateOnlydateArray2M.AssertModel(models[7],_testData[7], false);
                DateOnlydateArray2M.AssertModel(models[8],_testData[8], false);
                DateOnlydateArray2M.AssertModel(models[9],_testData[9], false);
                DateOnlydateArray2M.AssertModel(models[10],_testData[10], false);
                DateOnlydateArray2M.AssertModel(models[11],_testData[11], false);
                DateOnlydateArray2M.AssertModel(models[12],_testData[12], false);
                DateOnlydateArray2M.AssertModel(models[13],_testData[13], false);
                DateOnlydateArray2M.AssertModel(models[14],_testData[14], false);
                importCollection.Clear();

                    importCollection.Add(_testData[15]);
                    importCollection.Add(_testData[16]);
                    importCollection.Add(_testData[17]);
                    importCollection.Add(_testData[18]);
                    importCollection.Add(_testData[19]);
                    importCollection.Add(_testData[20]);
                    importCollection.Add(_testData[21]);
                    importCollection.Add(_testData[22]);
                    importCollection.Add(_testData[23]);
                    importCollection.Add(_testData[24]);
                    importCollection.Add(_testData[25]);
                    importCollection.Add(_testData[26]);
                    importCollection.Add(_testData[27]);
                    importCollection.Add(_testData[28]);
                    importCollection.Add(_testData[29]);
                await ((IDateOnlyListdateArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IDateOnlyListdateArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                DateOnlydateArray2M.AssertModel(models[0],_testData[0], false);
                DateOnlydateArray2M.AssertModel(models[1],_testData[1], false);
                DateOnlydateArray2M.AssertModel(models[2],_testData[2], false);
                DateOnlydateArray2M.AssertModel(models[3],_testData[3], false);
                DateOnlydateArray2M.AssertModel(models[4],_testData[4], false);
                DateOnlydateArray2M.AssertModel(models[5],_testData[5], false);
                DateOnlydateArray2M.AssertModel(models[6],_testData[6], false);
                DateOnlydateArray2M.AssertModel(models[7],_testData[7], false);
                DateOnlydateArray2M.AssertModel(models[8],_testData[8], false);
                DateOnlydateArray2M.AssertModel(models[9],_testData[9], false);
                DateOnlydateArray2M.AssertModel(models[10],_testData[10], false);
                DateOnlydateArray2M.AssertModel(models[11],_testData[11], false);
                DateOnlydateArray2M.AssertModel(models[12],_testData[12], false);
                DateOnlydateArray2M.AssertModel(models[13],_testData[13], false);
                DateOnlydateArray2M.AssertModel(models[14],_testData[14], false);
                DateOnlydateArray2M.AssertModel(models[15],_testData[15], false);
                DateOnlydateArray2M.AssertModel(models[16],_testData[16], false);
                DateOnlydateArray2M.AssertModel(models[17],_testData[17], false);
                DateOnlydateArray2M.AssertModel(models[18],_testData[18], false);
                DateOnlydateArray2M.AssertModel(models[19],_testData[19], false);
                DateOnlydateArray2M.AssertModel(models[20],_testData[20], false);
                DateOnlydateArray2M.AssertModel(models[21],_testData[21], false);
                DateOnlydateArray2M.AssertModel(models[22],_testData[22], false);
                DateOnlydateArray2M.AssertModel(models[23],_testData[23], false);
                DateOnlydateArray2M.AssertModel(models[24],_testData[24], false);
                DateOnlydateArray2M.AssertModel(models[25],_testData[25], false);
                DateOnlydateArray2M.AssertModel(models[26],_testData[26], false);
                DateOnlydateArray2M.AssertModel(models[27],_testData[27], false);
                DateOnlydateArray2M.AssertModel(models[28],_testData[28], false);
                DateOnlydateArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_dateonlydatearray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    dateonlydatearray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DateOnlydateArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483641),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483641)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyListdateArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDateOnlyListdateArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DateOnlydateArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateOnlyListdateArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DateOnlydateArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_dateonlydatearray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DateOnlydateArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483641),
                (NpgsqlTypes.NpgsqlDbType)(-2147483641)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyListdateArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDateOnlyListdateArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateOnlydateArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateOnlyListdateArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateOnlydateArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

