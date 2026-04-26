

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
    internal partial interface IDateTimeListtimestamp_with_time_zoneArray
    {
    }
    
    internal partial class DateTimeListtimestamp_with_time_zoneArray : IDateTimeListtimestamp_with_time_zoneArray
    {


#region TestData

        private readonly DateTimetimestamp_with_time_zoneArray2M[] _testData = new DateTimetimestamp_with_time_zoneArray2M[]
        {
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1987, month: 10, day: 4, hour: 9, minute: 26, second: 2, millisecond: 676, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 1, hour: 5, minute: 49, second: 28, millisecond: 962, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 17, hour: 14, minute: 53, second: 29, millisecond: 291, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 5, hour: 17, minute: 1, second: 28, millisecond: 234, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1928, month: 10, day: 14, hour: 5, minute: 49, second: 42, millisecond: 304, kind: DateTimeKind.Utc),

new DateTime(year: 1951, month: 10, day: 4, hour: 18, minute: 57, second: 2, millisecond: 724, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 5, hour: 6, minute: 7, second: 41, millisecond: 721, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 16, hour: 9, minute: 44, second: 50, millisecond: 848, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2010, month: 10, day: 18, hour: 11, minute: 43, second: 21, millisecond: 290, kind: DateTimeKind.Utc),

new DateTime(year: 1948, month: 10, day: 6, hour: 20, minute: 14, second: 43, millisecond: 222, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 18, hour: 19, minute: 12, second: 4, millisecond: 21, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1989, month: 10, day: 13, hour: 2, minute: 33, second: 45, millisecond: 192, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 17, hour: 21, minute: 32, second: 1, millisecond: 900, kind: DateTimeKind.Utc),

new DateTime(year: 1952, month: 10, day: 19, hour: 2, minute: 5, second: 39, millisecond: 319, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 4, hour: 16, minute: 47, second: 29, millisecond: 268, kind: DateTimeKind.Utc),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1992, month: 10, day: 10, hour: 22, minute: 57, second: 12, millisecond: 936, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 7, hour: 3, minute: 42, second: 14, millisecond: 259, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 2, hour: 15, minute: 44, second: 4, millisecond: 604, kind: DateTimeKind.Utc),

},
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1944, month: 10, day: 15, hour: 9, minute: 54, second: 33, millisecond: 178, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 2, hour: 17, minute: 38, second: 50, millisecond: 742, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 19, hour: 2, minute: 29, second: 7, millisecond: 356, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 17, hour: 17, minute: 22, second: 36, millisecond: 457, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1984, month: 10, day: 10, hour: 21, minute: 2, second: 48, millisecond: 961, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 14, hour: 2, minute: 44, second: 37, millisecond: 941, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 13, hour: 11, minute: 8, second: 3, millisecond: 882, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1917, month: 10, day: 14, hour: 3, minute: 47, second: 25, millisecond: 967, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 10, hour: 20, minute: 42, second: 43, millisecond: 570, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 1, hour: 1, minute: 12, second: 9, millisecond: 189, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1925, month: 10, day: 7, hour: 21, minute: 35, second: 45, millisecond: 243, kind: DateTimeKind.Utc),

new DateTime(year: 1944, month: 10, day: 7, hour: 18, minute: 10, second: 20, millisecond: 920, kind: DateTimeKind.Utc),

new DateTime(year: 2010, month: 10, day: 9, hour: 9, minute: 53, second: 28, millisecond: 432, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 19, hour: 18, minute: 34, second: 58, millisecond: 230, kind: DateTimeKind.Utc),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1939, month: 10, day: 11, hour: 11, minute: 14, second: 11, millisecond: 634, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 15, hour: 15, minute: 39, second: 33, millisecond: 581, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 19, hour: 9, minute: 23, second: 45, millisecond: 207, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 17, hour: 18, minute: 56, second: 45, millisecond: 447, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1933, month: 10, day: 8, hour: 21, minute: 18, second: 9, millisecond: 462, kind: DateTimeKind.Utc),

new DateTime(year: 2010, month: 10, day: 7, hour: 15, minute: 21, second: 10, millisecond: 758, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 11, hour: 21, minute: 32, second: 55, millisecond: 252, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1941, month: 10, day: 11, hour: 10, minute: 2, second: 9, millisecond: 57, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 7, hour: 16, minute: 32, second: 42, millisecond: 631, kind: DateTimeKind.Utc),

new DateTime(year: 1983, month: 10, day: 11, hour: 13, minute: 28, second: 46, millisecond: 618, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1985, month: 10, day: 8, hour: 1, minute: 27, second: 29, millisecond: 774, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 9, hour: 13, minute: 24, second: 5, millisecond: 366, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 7, hour: 2, minute: 36, second: 16, millisecond: 175, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1920, month: 10, day: 5, hour: 15, minute: 37, second: 17, millisecond: 724, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 3, hour: 7, minute: 27, second: 54, millisecond: 421, kind: DateTimeKind.Utc),

new DateTime(year: 1920, month: 10, day: 12, hour: 10, minute: 31, second: 9, millisecond: 460, kind: DateTimeKind.Utc),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1993, month: 10, day: 9, hour: 11, minute: 54, second: 9, millisecond: 186, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 1, hour: 16, minute: 41, second: 57, millisecond: 643, kind: DateTimeKind.Utc),

new DateTime(year: 1923, month: 10, day: 14, hour: 8, minute: 56, second: 43, millisecond: 150, kind: DateTimeKind.Utc),

},
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1980, month: 10, day: 9, hour: 15, minute: 34, second: 58, millisecond: 808, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 16, hour: 18, minute: 29, second: 44, millisecond: 699, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 12, hour: 21, minute: 8, second: 21, millisecond: 175, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1987, month: 10, day: 13, hour: 13, minute: 32, second: 11, millisecond: 290, kind: DateTimeKind.Utc),

new DateTime(year: 2012, month: 10, day: 11, hour: 18, minute: 24, second: 34, millisecond: 92, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 14, hour: 16, minute: 11, second: 51, millisecond: 553, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1966, month: 10, day: 2, hour: 21, minute: 43, second: 51, millisecond: 297, kind: DateTimeKind.Utc),

new DateTime(year: 1969, month: 10, day: 11, hour: 6, minute: 47, second: 38, millisecond: 769, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 7, hour: 2, minute: 8, second: 25, millisecond: 275, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 9, hour: 18, minute: 38, second: 42, millisecond: 543, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1964, month: 10, day: 7, hour: 11, minute: 43, second: 52, millisecond: 362, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 6, hour: 16, minute: 21, second: 5, millisecond: 371, kind: DateTimeKind.Utc),

new DateTime(year: 1943, month: 10, day: 11, hour: 19, minute: 11, second: 23, millisecond: 42, kind: DateTimeKind.Utc),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1930, month: 10, day: 1, hour: 20, minute: 53, second: 15, millisecond: 17, kind: DateTimeKind.Utc),

new DateTime(year: 2010, month: 10, day: 15, hour: 1, minute: 57, second: 32, millisecond: 584, kind: DateTimeKind.Utc),

new DateTime(year: 1929, month: 10, day: 1, hour: 22, minute: 57, second: 58, millisecond: 275, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 8, hour: 19, minute: 5, second: 1, millisecond: 245, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 15, hour: 5, minute: 54, second: 27, millisecond: 431, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 19, hour: 13, minute: 5, second: 30, millisecond: 893, kind: DateTimeKind.Utc),

new DateTime(year: 1918, month: 10, day: 12, hour: 9, minute: 6, second: 9, millisecond: 853, kind: DateTimeKind.Utc),

new DateTime(year: 1948, month: 10, day: 16, hour: 10, minute: 10, second: 30, millisecond: 160, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1996, month: 10, day: 5, hour: 1, minute: 18, second: 29, millisecond: 644, kind: DateTimeKind.Utc),

new DateTime(year: 2001, month: 10, day: 14, hour: 17, minute: 30, second: 39, millisecond: 619, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 6, hour: 22, minute: 42, second: 38, millisecond: 811, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 12, hour: 15, minute: 9, second: 7, millisecond: 534, kind: DateTimeKind.Utc),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1937, month: 10, day: 17, hour: 9, minute: 9, second: 20, millisecond: 147, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 12, hour: 20, minute: 14, second: 56, millisecond: 973, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 18, hour: 7, minute: 29, second: 53, millisecond: 957, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1942, month: 10, day: 11, hour: 4, minute: 46, second: 48, millisecond: 569, kind: DateTimeKind.Utc),

new DateTime(year: 2010, month: 10, day: 11, hour: 10, minute: 56, second: 57, millisecond: 407, kind: DateTimeKind.Utc),

new DateTime(year: 1951, month: 10, day: 13, hour: 15, minute: 50, second: 53, millisecond: 129, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1966, month: 10, day: 10, hour: 17, minute: 38, second: 58, millisecond: 592, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 1, hour: 2, minute: 38, second: 21, millisecond: 438, kind: DateTimeKind.Utc),

new DateTime(year: 1994, month: 10, day: 8, hour: 10, minute: 33, second: 1, millisecond: 254, kind: DateTimeKind.Utc),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1940, month: 10, day: 11, hour: 13, minute: 3, second: 53, millisecond: 291, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 16, hour: 4, minute: 2, second: 17, millisecond: 625, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 6, hour: 16, minute: 17, second: 7, millisecond: 432, kind: DateTimeKind.Utc),

new DateTime(year: 1969, month: 10, day: 1, hour: 5, minute: 30, second: 27, millisecond: 378, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2014, month: 10, day: 7, hour: 2, minute: 12, second: 54, millisecond: 21, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 8, hour: 17, minute: 51, second: 37, millisecond: 274, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 19, hour: 17, minute: 21, second: 29, millisecond: 245, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 8, hour: 20, minute: 58, second: 42, millisecond: 741, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1952, month: 10, day: 2, hour: 22, minute: 43, second: 29, millisecond: 56, kind: DateTimeKind.Utc),

new DateTime(year: 1943, month: 10, day: 12, hour: 21, minute: 42, second: 35, millisecond: 413, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 9, hour: 1, minute: 1, second: 32, millisecond: 965, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1926, month: 10, day: 3, hour: 14, minute: 12, second: 48, millisecond: 893, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 18, hour: 6, minute: 54, second: 53, millisecond: 778, kind: DateTimeKind.Utc),

new DateTime(year: 1983, month: 10, day: 8, hour: 10, minute: 3, second: 13, millisecond: 943, kind: DateTimeKind.Utc),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1941, month: 10, day: 11, hour: 10, minute: 51, second: 48, millisecond: 27, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 14, hour: 14, minute: 53, second: 34, millisecond: 611, kind: DateTimeKind.Utc),

new DateTime(year: 2005, month: 10, day: 2, hour: 15, minute: 1, second: 31, millisecond: 276, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 9, hour: 2, minute: 1, second: 10, millisecond: 325, kind: DateTimeKind.Utc),

},
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2006, month: 10, day: 7, hour: 18, minute: 14, second: 36, millisecond: 318, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 14, hour: 16, minute: 58, second: 10, millisecond: 834, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 13, hour: 15, minute: 17, second: 9, millisecond: 456, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1921, month: 10, day: 9, hour: 5, minute: 32, second: 22, millisecond: 948, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 15, hour: 20, minute: 7, second: 9, millisecond: 945, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 10, hour: 22, minute: 55, second: 10, millisecond: 975, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1996, month: 10, day: 5, hour: 17, minute: 23, second: 17, millisecond: 830, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 5, hour: 5, minute: 2, second: 21, millisecond: 44, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 2, hour: 22, minute: 5, second: 44, millisecond: 253, kind: DateTimeKind.Utc),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1932, month: 10, day: 10, hour: 6, minute: 8, second: 37, millisecond: 23, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 8, hour: 18, minute: 46, second: 14, millisecond: 9, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 2, hour: 22, minute: 10, second: 40, millisecond: 97, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 1, hour: 3, minute: 40, second: 21, millisecond: 859, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1926, month: 10, day: 19, hour: 20, minute: 14, second: 18, millisecond: 195, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 11, hour: 19, minute: 58, second: 4, millisecond: 160, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 13, hour: 21, minute: 44, second: 48, millisecond: 303, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1928, month: 10, day: 13, hour: 3, minute: 46, second: 2, millisecond: 517, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 3, hour: 9, minute: 49, second: 33, millisecond: 396, kind: DateTimeKind.Utc),

new DateTime(year: 1969, month: 10, day: 3, hour: 9, minute: 35, second: 43, millisecond: 661, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1957, month: 10, day: 16, hour: 1, minute: 53, second: 37, millisecond: 504, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 14, hour: 8, minute: 11, second: 44, millisecond: 294, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 14, hour: 14, minute: 34, second: 9, millisecond: 232, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 9, hour: 20, minute: 56, second: 34, millisecond: 780, kind: DateTimeKind.Utc),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1921, month: 10, day: 1, hour: 16, minute: 7, second: 27, millisecond: 511, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 5, hour: 1, minute: 52, second: 53, millisecond: 614, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 5, hour: 18, minute: 53, second: 54, millisecond: 671, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1942, month: 10, day: 9, hour: 15, minute: 8, second: 51, millisecond: 82, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 18, hour: 18, minute: 32, second: 51, millisecond: 498, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 8, hour: 1, minute: 20, second: 22, millisecond: 861, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2019, month: 10, day: 14, hour: 10, minute: 38, second: 20, millisecond: 214, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 6, hour: 21, minute: 33, second: 50, millisecond: 422, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 16, hour: 10, minute: 9, second: 56, millisecond: 798, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 14, hour: 4, minute: 12, second: 56, millisecond: 728, kind: DateTimeKind.Utc),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2013, month: 10, day: 14, hour: 8, minute: 40, second: 26, millisecond: 191, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 6, hour: 1, minute: 26, second: 2, millisecond: 368, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 19, hour: 4, minute: 14, second: 37, millisecond: 303, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 3, hour: 22, minute: 30, second: 9, millisecond: 359, kind: DateTimeKind.Utc),

},
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1959, month: 10, day: 10, hour: 3, minute: 16, second: 19, millisecond: 136, kind: DateTimeKind.Utc),

new DateTime(year: 1948, month: 10, day: 10, hour: 14, minute: 49, second: 12, millisecond: 252, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 10, hour: 20, minute: 30, second: 58, millisecond: 478, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1957, month: 10, day: 19, hour: 13, minute: 23, second: 42, millisecond: 41, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 4, hour: 21, minute: 50, second: 23, millisecond: 861, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 1, hour: 7, minute: 30, second: 37, millisecond: 506, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1934, month: 10, day: 9, hour: 19, minute: 17, second: 46, millisecond: 991, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 13, hour: 22, minute: 29, second: 26, millisecond: 413, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 2, hour: 11, minute: 6, second: 34, millisecond: 930, kind: DateTimeKind.Utc),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1974, month: 10, day: 10, hour: 10, minute: 2, second: 15, millisecond: 264, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 3, hour: 19, minute: 56, second: 50, millisecond: 182, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 16, hour: 5, minute: 2, second: 33, millisecond: 114, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1982, month: 10, day: 2, hour: 22, minute: 39, second: 24, millisecond: 163, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 10, hour: 2, minute: 8, second: 17, millisecond: 242, kind: DateTimeKind.Utc),

new DateTime(year: 1929, month: 10, day: 4, hour: 9, minute: 28, second: 5, millisecond: 144, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2003, month: 10, day: 14, hour: 19, minute: 29, second: 43, millisecond: 412, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 1, hour: 8, minute: 31, second: 41, millisecond: 469, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 1, hour: 7, minute: 23, second: 10, millisecond: 244, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1939, month: 10, day: 19, hour: 6, minute: 2, second: 55, millisecond: 723, kind: DateTimeKind.Utc),

new DateTime(year: 1921, month: 10, day: 13, hour: 18, minute: 44, second: 26, millisecond: 738, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 13, hour: 6, minute: 6, second: 5, millisecond: 857, kind: DateTimeKind.Utc),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2019, month: 10, day: 17, hour: 8, minute: 37, second: 57, millisecond: 248, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 7, hour: 3, minute: 48, second: 57, millisecond: 775, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 10, hour: 15, minute: 7, second: 31, millisecond: 842, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 16, hour: 11, minute: 12, second: 4, millisecond: 379, kind: DateTimeKind.Utc),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1934, month: 10, day: 18, hour: 15, minute: 22, second: 44, millisecond: 185, kind: DateTimeKind.Utc),

new DateTime(year: 1952, month: 10, day: 15, hour: 11, minute: 23, second: 31, millisecond: 218, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 18, hour: 5, minute: 43, second: 1, millisecond: 782, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2016, month: 10, day: 3, hour: 22, minute: 35, second: 56, millisecond: 736, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 3, hour: 12, minute: 17, second: 35, millisecond: 278, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 11, hour: 21, minute: 51, second: 48, millisecond: 200, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1930, month: 10, day: 15, hour: 10, minute: 30, second: 52, millisecond: 137, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 15, hour: 10, minute: 26, second: 8, millisecond: 371, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 10, hour: 10, minute: 51, second: 29, millisecond: 548, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 11, hour: 14, minute: 47, second: 15, millisecond: 561, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1988, month: 10, day: 12, hour: 10, minute: 38, second: 44, millisecond: 376, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 6, hour: 5, minute: 53, second: 8, millisecond: 442, kind: DateTimeKind.Utc),

new DateTime(year: 1994, month: 10, day: 4, hour: 14, minute: 9, second: 58, millisecond: 567, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2006, month: 10, day: 18, hour: 19, minute: 15, second: 38, millisecond: 796, kind: DateTimeKind.Utc),

new DateTime(year: 1966, month: 10, day: 1, hour: 12, minute: 11, second: 23, millisecond: 776, kind: DateTimeKind.Utc),

new DateTime(year: 1994, month: 10, day: 14, hour: 17, minute: 2, second: 13, millisecond: 510, kind: DateTimeKind.Utc),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1979, month: 10, day: 3, hour: 21, minute: 9, second: 27, millisecond: 252, kind: DateTimeKind.Utc),

new DateTime(year: 2018, month: 10, day: 7, hour: 2, minute: 19, second: 12, millisecond: 296, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 18, hour: 8, minute: 6, second: 22, millisecond: 358, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1940, month: 10, day: 4, hour: 14, minute: 33, second: 18, millisecond: 36, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 17, hour: 1, minute: 23, second: 13, millisecond: 281, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 13, hour: 3, minute: 21, second: 20, millisecond: 179, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1974, month: 10, day: 10, hour: 18, minute: 2, second: 9, millisecond: 481, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 11, hour: 2, minute: 40, second: 57, millisecond: 526, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 3, hour: 2, minute: 19, second: 54, millisecond: 11, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2001, month: 10, day: 3, hour: 8, minute: 12, second: 30, millisecond: 854, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 14, hour: 16, minute: 5, second: 4, millisecond: 55, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 19, hour: 13, minute: 30, second: 36, millisecond: 256, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1961, month: 10, day: 17, hour: 6, minute: 34, second: 19, millisecond: 951, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 10, hour: 4, minute: 8, second: 33, millisecond: 27, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 11, hour: 8, minute: 45, second: 43, millisecond: 125, kind: DateTimeKind.Utc),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1971, month: 10, day: 17, hour: 18, minute: 12, second: 29, millisecond: 977, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 15, hour: 19, minute: 1, second: 10, millisecond: 22, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 18, hour: 5, minute: 21, second: 42, millisecond: 60, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 18, hour: 16, minute: 14, second: 5, millisecond: 362, kind: DateTimeKind.Utc),

},
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1944, month: 10, day: 4, hour: 12, minute: 18, second: 24, millisecond: 739, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 14, hour: 16, minute: 14, second: 13, millisecond: 702, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 1, hour: 10, minute: 22, second: 26, millisecond: 538, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1966, month: 10, day: 9, hour: 4, minute: 52, second: 27, millisecond: 169, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 8, hour: 22, minute: 5, second: 45, millisecond: 576, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 7, hour: 2, minute: 34, second: 11, millisecond: 776, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1960, month: 10, day: 11, hour: 21, minute: 40, second: 48, millisecond: 513, kind: DateTimeKind.Utc),

new DateTime(year: 1965, month: 10, day: 2, hour: 21, minute: 3, second: 51, millisecond: 333, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 1, hour: 12, minute: 31, second: 53, millisecond: 435, kind: DateTimeKind.Utc),

new DateTime(year: 1937, month: 10, day: 7, hour: 19, minute: 39, second: 25, millisecond: 440, kind: DateTimeKind.Utc),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1961, month: 10, day: 7, hour: 14, minute: 21, second: 16, millisecond: 49, kind: DateTimeKind.Utc),

new DateTime(year: 1965, month: 10, day: 16, hour: 2, minute: 10, second: 39, millisecond: 830, kind: DateTimeKind.Utc),

new DateTime(year: 1929, month: 10, day: 16, hour: 6, minute: 29, second: 17, millisecond: 172, kind: DateTimeKind.Utc),

},
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_with_time_zonearray2mi(
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
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateTime>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483622)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateTime>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483622))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_with_time_zonearray2mi(
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
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateTime>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483622)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateTime>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483622))]
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

                changedRows =  ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_with_time_zonearray2m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_with_time_zonearray2mi_id
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
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateTime>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483622)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateTime>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483622)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "datetimetimestamp_with_time_zonearray2mi_id", 
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
                changedRows =  ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_with_time_zonearray2m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_with_time_zonearray2mi_id
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
    datetimetimestamp_with_time_zonearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_with_time_zonearray2m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_with_time_zonearray2mi_id
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
    datetimetimestamp_with_time_zonearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateTime>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483622)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateTime>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483622)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "datetimetimestamp_with_time_zonearray2mi_id", 
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
                List<DateTimetimestamp_with_time_zoneArray2M> models = null;

                models =  ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DateTimetimestamp_with_time_zoneArray2M> models = null;

                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zoneArray2M), typeof(FlatDateTimetimestamp_with_time_zoneArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray)),
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
FROM public.datetimetimestamp_with_time_zonearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                var models2 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                await ((IDateTimeListtimestamp_with_time_zoneArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zonearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                var models2 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                ((IDateTimeListtimestamp_with_time_zoneArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zoneArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray)),
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
FROM public.datetimetimestamp_with_time_zonearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zonearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDateTimeListtimestamp_with_time_zoneArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zonearray2m m
LEFT JOIN public.datetimetimestamp_with_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray)),
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
                var models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDateTimeListtimestamp_with_time_zoneArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zoneArray2M), typeof(FlatDateTimetimestamp_with_time_zoneArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray)),
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
FROM public.datetimetimestamp_with_time_zonearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                var models2 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                await ((IDateTimeListtimestamp_with_time_zoneArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zonearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                var models2 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                ((IDateTimeListtimestamp_with_time_zoneArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zoneArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray)),
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
FROM public.datetimetimestamp_with_time_zonearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zonearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDateTimeListtimestamp_with_time_zoneArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zonearray2m m
LEFT JOIN public.datetimetimestamp_with_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray)),
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
                var models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDateTimeListtimestamp_with_time_zoneArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zoneArray2M), typeof(FlatDateTimetimestamp_with_time_zoneArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray)),
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
FROM public.datetimetimestamp_with_time_zonearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                var models2 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                await((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zonearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                var models2 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zoneArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray)),
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
FROM public.datetimetimestamp_with_time_zonearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_with_time_zonearray2m m
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
FROM public.datetimetimestamp_with_time_zonearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[20], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[21], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[22], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[23], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[24], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[25], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[26], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[27], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[28], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[18], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[19], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[20], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[21], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[22], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[23], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[24], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[25], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[26], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[27], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[28], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[29], false);
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
FROM public.datetimetimestamp_with_time_zonearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_with_time_zonearray2m m
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
FROM public.datetimetimestamp_with_time_zonearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[12], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[13], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[14], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[15], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[16], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[17], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[18], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[19], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[20], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[21], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[22], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[23], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[12],_testData[24], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[13],_testData[25], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[14],_testData[26], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[15],_testData[27], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[16],_testData[28], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[9], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[10], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[11], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[12], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[13], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[14], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[15], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[16], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[17], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[18], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[19], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[20], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[12],_testData[21], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[13],_testData[22], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[14],_testData[23], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[15],_testData[24], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[16],_testData[25], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[17],_testData[26], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[18],_testData[27], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[19],_testData[28], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[20],_testData[29], false);
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
FROM public.datetimetimestamp_with_time_zonearray2m m
LEFT JOIN public.datetimetimestamp_with_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray)),
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
                var models = await((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[24], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[25], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[26], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[27], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[28], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[11], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[12], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[13], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[14], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[15], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[16], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[17], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[18], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[19], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[20], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[21], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[22], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[12],_testData[23], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[13],_testData[24], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[14],_testData[25], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[15],_testData[26], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[16],_testData[27], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[17],_testData[28], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[18],_testData[29], false);
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
                var models = ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[6], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[7], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[8], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[9], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[10], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[11], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[12], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[13], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[14], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[15], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[16], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[17], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[12],_testData[18], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[13],_testData[19], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[14],_testData[20], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[15],_testData[21], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[16],_testData[22], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[17],_testData[23], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[18],_testData[24], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[19],_testData[25], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[20],_testData[26], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[21],_testData[27], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[22],_testData[28], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[12], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[13], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[14], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[15], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[16], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[17], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[18], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[19], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[20], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[21], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[22], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[23], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[12],_testData[24], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[13],_testData[25], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[14],_testData[26], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[15],_testData[27], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[16],_testData[28], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zoneArray2M), typeof(FlatDateTimetimestamp_with_time_zoneArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray)),
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
FROM public.datetimetimestamp_with_time_zonearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                var models2 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                await((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zonearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                var models2 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zoneArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray)),
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
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray)),
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
FROM public.datetimetimestamp_with_time_zonearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zonearray2m m
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
FROM public.datetimetimestamp_with_time_zonearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 10, query1, 82, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[2], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[3], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[4], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[5], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[6], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[7], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[8], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[9], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[10], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[11], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[12], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[13], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[12],_testData[14], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[13],_testData[15], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[14],_testData[16], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[15],_testData[17], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[16],_testData[18], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[17],_testData[19], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[18],_testData[20], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[19],_testData[21], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[20],_testData[22], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[21],_testData[23], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[22],_testData[24], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[23],_testData[25], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[24],_testData[26], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[25],_testData[27], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[26],_testData[28], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[16], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[17], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[18], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[19], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[20], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[21], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[22], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[23], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[24], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[25], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[26], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[27], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[12],_testData[28], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[13],_testData[29], false);
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
FROM public.datetimetimestamp_with_time_zonearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zonearray2m m
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
FROM public.datetimetimestamp_with_time_zonearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionDynQuerySelectModelBatch(connection, 129, query1, 129, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[25], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[26], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[27], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[28], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[25], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[26], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[27], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[28], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[29], false);
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
FROM public.datetimetimestamp_with_time_zonearray2m m
LEFT JOIN public.datetimetimestamp_with_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray)),
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
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray)),
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
                var models = await((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionSelectModelBatchAsync(connection, 17, 91))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[4], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[5], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[6], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[7], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[8], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[9], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[10], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[11], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[12], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[13], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[14], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[15], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[12],_testData[16], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[13],_testData[17], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[14],_testData[18], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[15],_testData[19], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[16],_testData[20], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[17],_testData[21], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[18],_testData[22], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[19],_testData[23], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[20],_testData[24], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[21],_testData[25], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[22],_testData[26], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[23],_testData[27], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[24],_testData[28], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[18], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[19], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[20], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[21], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[22], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[23], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[24], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[25], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[26], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[27], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[28], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[29], false);
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
                var models = ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionSelectModelBatch(connection, 51, 17))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[10], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[11], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[12], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[13], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[14], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[15], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[16], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[17], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[18], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[19], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[20], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[21], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[12],_testData[22], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[13],_testData[23], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[14],_testData[24], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[15],_testData[25], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[16],_testData[26], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[17],_testData[27], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[18],_testData[28], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[4], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[5], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[6], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[7], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[8], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[9], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[10], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[11], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[12], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[13], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[14], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[15], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[12],_testData[16], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[13],_testData[17], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[14],_testData[18], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[15],_testData[19], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[16],_testData[20], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[17],_testData[21], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[18],_testData[22], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[19],_testData[23], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[20],_testData[24], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[21],_testData[25], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[22],_testData[26], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[23],_testData[27], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[24],_testData[28], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[25],_testData[29], false);
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
                await using var cmd = await ((IDateTimeListtimestamp_with_time_zoneArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDateTimeListtimestamp_with_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 20);
                var models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[5], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[6], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[7], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[8], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[9], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[10], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[11], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[12], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[13], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[14], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[15], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[16], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[12],_testData[17], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[13],_testData[18], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[14],_testData[19], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[15],_testData[20], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[16],_testData[21], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[17],_testData[22], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[18],_testData[23], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[19],_testData[24], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[20],_testData[25], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[21],_testData[26], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[22],_testData[27], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[23],_testData[28], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[24],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateTimeListtimestamp_with_time_zoneArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateTimeListtimestamp_with_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 127);
                var models =  ((IDateTimeListtimestamp_with_time_zoneArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(6));
DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[24], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[25], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[26], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[27], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[28], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_datetimetimestamp_with_time_zonearray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483622),
                (NpgsqlTypes.NpgsqlDbType)(-2147483622)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray))]
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
FROM public.binary_datetimetimestamp_with_time_zonearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<DateTimetimestamp_with_time_zoneArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IDateTimeListtimestamp_with_time_zoneArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDateTimeListtimestamp_with_time_zoneArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray2MI.AssertModel(actual, expect, false);
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
                await ((IDateTimeListtimestamp_with_time_zoneArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_datetimetimestamp_with_time_zonearray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
datetimetimestamp_with_time_zonearray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483622),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483622)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray))]
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
FROM public.binary_datetimetimestamp_with_time_zonearray2m m
LEFT JOIN public.binary_datetimetimestamp_with_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<DateTimetimestamp_with_time_zoneArray2M>(15);

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
                ((IDateTimeListtimestamp_with_time_zoneArray)this).ImportModel(connection, importCollection);
                var models = ((IDateTimeListtimestamp_with_time_zoneArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[0], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[1], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[2], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[3], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[4], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[5], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[6], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[7], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[8], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[9], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[10], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[11], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[12],_testData[12], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[13],_testData[13], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((IDateTimeListtimestamp_with_time_zoneArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[0], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[1], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[2], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[3], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[4], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[5], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[6], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[7], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[8], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[9], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[10], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[11], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[12],_testData[12], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[13],_testData[13], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[14],_testData[14], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[15],_testData[15], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[16],_testData[16], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[17],_testData[17], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[18],_testData[18], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[19],_testData[19], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[20],_testData[20], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[21],_testData[21], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[22],_testData[22], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[23],_testData[23], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[24],_testData[24], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[25],_testData[25], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[26],_testData[26], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[27],_testData[27], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[28],_testData[28], false);
                DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_datetimetimestamp_with_time_zonearray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    datetimetimestamp_with_time_zonearray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483622),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483622)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDateTimeListtimestamp_with_time_zoneArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DateTimetimestamp_with_time_zoneArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DateTimetimestamp_with_time_zoneArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_datetimetimestamp_with_time_zonearray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483622),
                (NpgsqlTypes.NpgsqlDbType)(-2147483622)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDateTimeListtimestamp_with_time_zoneArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

