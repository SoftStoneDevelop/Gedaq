

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
    internal partial interface IDateTimeListtimestamp_without_time_zoneArray
    {
    }
    
    internal partial class DateTimeListtimestamp_without_time_zoneArray : IDateTimeListtimestamp_without_time_zoneArray
    {


#region TestData

        private readonly DateTimetimestamp_without_time_zoneArray2M[] _testData = new DateTimetimestamp_without_time_zoneArray2M[]
        {
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2004, month: 10, day: 13, hour: 12, minute: 22, second: 42, millisecond: 860, kind: DateTimeKind.Local),

new DateTime(year: 1999, month: 10, day: 2, hour: 5, minute: 7, second: 52, millisecond: 133, kind: DateTimeKind.Local),

new DateTime(year: 1956, month: 10, day: 11, hour: 20, minute: 4, second: 33, millisecond: 557, kind: DateTimeKind.Local),

new DateTime(year: 1967, month: 10, day: 3, hour: 3, minute: 38, second: 17, millisecond: 877, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1986, month: 10, day: 8, hour: 1, minute: 28, second: 19, millisecond: 313, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 14, hour: 14, minute: 26, second: 58, millisecond: 299, kind: DateTimeKind.Local),

new DateTime(year: 1977, month: 10, day: 7, hour: 22, minute: 19, second: 39, millisecond: 970, kind: DateTimeKind.Local),

new DateTime(year: 1972, month: 10, day: 15, hour: 21, minute: 12, second: 17, millisecond: 83, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1958, month: 10, day: 6, hour: 3, minute: 35, second: 54, millisecond: 50, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 4, hour: 13, minute: 1, second: 42, millisecond: 889, kind: DateTimeKind.Local),

new DateTime(year: 1952, month: 10, day: 16, hour: 12, minute: 56, second: 27, millisecond: 264, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 15, hour: 17, minute: 45, second: 13, millisecond: 69, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1949, month: 10, day: 18, hour: 20, minute: 49, second: 5, millisecond: 516, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 14, hour: 17, minute: 29, second: 50, millisecond: 272, kind: DateTimeKind.Local),

new DateTime(year: 1918, month: 10, day: 2, hour: 22, minute: 29, second: 47, millisecond: 156, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1944, month: 10, day: 11, hour: 18, minute: 14, second: 24, millisecond: 20, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 14, hour: 21, minute: 26, second: 21, millisecond: 161, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 14, hour: 15, minute: 31, second: 18, millisecond: 848, kind: DateTimeKind.Local),

},
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2014, month: 10, day: 11, hour: 10, minute: 38, second: 12, millisecond: 906, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 12, hour: 14, minute: 6, second: 19, millisecond: 62, kind: DateTimeKind.Local),

new DateTime(year: 1926, month: 10, day: 3, hour: 8, minute: 54, second: 5, millisecond: 51, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 12, hour: 16, minute: 35, second: 17, millisecond: 355, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1925, month: 10, day: 4, hour: 6, minute: 7, second: 8, millisecond: 890, kind: DateTimeKind.Local),

new DateTime(year: 2001, month: 10, day: 5, hour: 12, minute: 27, second: 37, millisecond: 444, kind: DateTimeKind.Local),

new DateTime(year: 1944, month: 10, day: 14, hour: 1, minute: 2, second: 23, millisecond: 756, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 19, hour: 6, minute: 25, second: 48, millisecond: 154, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1991, month: 10, day: 4, hour: 10, minute: 41, second: 35, millisecond: 824, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 18, hour: 13, minute: 35, second: 52, millisecond: 542, kind: DateTimeKind.Local),

new DateTime(year: 1940, month: 10, day: 12, hour: 18, minute: 31, second: 5, millisecond: 454, kind: DateTimeKind.Local),

new DateTime(year: 1977, month: 10, day: 16, hour: 21, minute: 18, second: 26, millisecond: 172, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2018, month: 10, day: 1, hour: 17, minute: 33, second: 19, millisecond: 654, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 3, hour: 9, minute: 13, second: 26, millisecond: 264, kind: DateTimeKind.Local),

new DateTime(year: 1931, month: 10, day: 18, hour: 3, minute: 56, second: 9, millisecond: 238, kind: DateTimeKind.Local),

new DateTime(year: 1984, month: 10, day: 17, hour: 16, minute: 43, second: 1, millisecond: 84, kind: DateTimeKind.Local),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1941, month: 10, day: 7, hour: 12, minute: 23, second: 14, millisecond: 169, kind: DateTimeKind.Local),

new DateTime(year: 1933, month: 10, day: 17, hour: 19, minute: 34, second: 31, millisecond: 393, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 9, hour: 4, minute: 28, second: 46, millisecond: 923, kind: DateTimeKind.Local),

new DateTime(year: 1923, month: 10, day: 14, hour: 9, minute: 6, second: 33, millisecond: 887, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1946, month: 10, day: 2, hour: 18, minute: 8, second: 39, millisecond: 510, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 7, hour: 21, minute: 17, second: 18, millisecond: 533, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 11, hour: 8, minute: 57, second: 17, millisecond: 360, kind: DateTimeKind.Local),

new DateTime(year: 2009, month: 10, day: 11, hour: 14, minute: 12, second: 29, millisecond: 908, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1918, month: 10, day: 19, hour: 8, minute: 26, second: 36, millisecond: 905, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 19, hour: 6, minute: 55, second: 2, millisecond: 222, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 13, hour: 15, minute: 4, second: 42, millisecond: 733, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1951, month: 10, day: 3, hour: 20, minute: 45, second: 5, millisecond: 748, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 12, hour: 19, minute: 9, second: 47, millisecond: 713, kind: DateTimeKind.Local),

new DateTime(year: 1988, month: 10, day: 10, hour: 22, minute: 23, second: 15, millisecond: 849, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1919, month: 10, day: 1, hour: 16, minute: 3, second: 31, millisecond: 667, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 17, hour: 4, minute: 10, second: 29, millisecond: 869, kind: DateTimeKind.Local),

new DateTime(year: 1924, month: 10, day: 9, hour: 18, minute: 10, second: 54, millisecond: 223, kind: DateTimeKind.Local),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1963, month: 10, day: 14, hour: 18, minute: 34, second: 39, millisecond: 718, kind: DateTimeKind.Local),

new DateTime(year: 1972, month: 10, day: 7, hour: 1, minute: 20, second: 32, millisecond: 440, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 18, hour: 21, minute: 30, second: 31, millisecond: 260, kind: DateTimeKind.Local),

new DateTime(year: 1921, month: 10, day: 6, hour: 20, minute: 54, second: 57, millisecond: 255, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1934, month: 10, day: 9, hour: 19, minute: 3, second: 43, millisecond: 983, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 16, hour: 7, minute: 52, second: 56, millisecond: 903, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 17, hour: 17, minute: 23, second: 4, millisecond: 298, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1918, month: 10, day: 11, hour: 8, minute: 41, second: 17, millisecond: 189, kind: DateTimeKind.Local),

new DateTime(year: 1924, month: 10, day: 12, hour: 16, minute: 47, second: 32, millisecond: 695, kind: DateTimeKind.Local),

new DateTime(year: 1977, month: 10, day: 13, hour: 10, minute: 30, second: 21, millisecond: 296, kind: DateTimeKind.Local),

new DateTime(year: 1929, month: 10, day: 10, hour: 1, minute: 9, second: 39, millisecond: 658, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1946, month: 10, day: 11, hour: 15, minute: 24, second: 45, millisecond: 103, kind: DateTimeKind.Local),

new DateTime(year: 2009, month: 10, day: 13, hour: 5, minute: 30, second: 8, millisecond: 146, kind: DateTimeKind.Local),

new DateTime(year: 1994, month: 10, day: 8, hour: 7, minute: 34, second: 13, millisecond: 151, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1962, month: 10, day: 11, hour: 13, minute: 54, second: 7, millisecond: 979, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 2, hour: 17, minute: 43, second: 4, millisecond: 967, kind: DateTimeKind.Local),

new DateTime(year: 1984, month: 10, day: 8, hour: 19, minute: 47, second: 17, millisecond: 768, kind: DateTimeKind.Local),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1976, month: 10, day: 9, hour: 19, minute: 41, second: 33, millisecond: 334, kind: DateTimeKind.Local),

new DateTime(year: 1985, month: 10, day: 10, hour: 16, minute: 19, second: 54, millisecond: 900, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 9, hour: 6, minute: 3, second: 26, millisecond: 125, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1951, month: 10, day: 18, hour: 18, minute: 57, second: 32, millisecond: 107, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 6, hour: 18, minute: 51, second: 26, millisecond: 111, kind: DateTimeKind.Local),

new DateTime(year: 1953, month: 10, day: 3, hour: 13, minute: 55, second: 6, millisecond: 570, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1932, month: 10, day: 9, hour: 11, minute: 36, second: 34, millisecond: 918, kind: DateTimeKind.Local),

new DateTime(year: 2000, month: 10, day: 4, hour: 15, minute: 29, second: 57, millisecond: 333, kind: DateTimeKind.Local),

new DateTime(year: 1983, month: 10, day: 12, hour: 1, minute: 51, second: 12, millisecond: 768, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1964, month: 10, day: 4, hour: 16, minute: 32, second: 47, millisecond: 213, kind: DateTimeKind.Local),

new DateTime(year: 1924, month: 10, day: 14, hour: 12, minute: 50, second: 50, millisecond: 28, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 5, hour: 7, minute: 3, second: 12, millisecond: 604, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 9, hour: 13, minute: 2, second: 47, millisecond: 951, kind: DateTimeKind.Local),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1999, month: 10, day: 1, hour: 10, minute: 11, second: 47, millisecond: 626, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 13, hour: 15, minute: 44, second: 45, millisecond: 250, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 14, hour: 4, minute: 43, second: 34, millisecond: 802, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1969, month: 10, day: 19, hour: 22, minute: 27, second: 1, millisecond: 602, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 17, hour: 11, minute: 34, second: 30, millisecond: 893, kind: DateTimeKind.Local),

new DateTime(year: 1964, month: 10, day: 7, hour: 2, minute: 17, second: 25, millisecond: 871, kind: DateTimeKind.Local),

new DateTime(year: 1964, month: 10, day: 3, hour: 13, minute: 21, second: 57, millisecond: 50, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1971, month: 10, day: 1, hour: 22, minute: 14, second: 40, millisecond: 321, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 8, hour: 1, minute: 30, second: 47, millisecond: 329, kind: DateTimeKind.Local),

new DateTime(year: 1921, month: 10, day: 15, hour: 3, minute: 34, second: 7, millisecond: 652, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1970, month: 10, day: 13, hour: 3, minute: 51, second: 30, millisecond: 942, kind: DateTimeKind.Local),

new DateTime(year: 2011, month: 10, day: 7, hour: 17, minute: 16, second: 24, millisecond: 410, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 3, hour: 18, minute: 15, second: 38, millisecond: 640, kind: DateTimeKind.Local),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1948, month: 10, day: 9, hour: 16, minute: 50, second: 39, millisecond: 89, kind: DateTimeKind.Local),

new DateTime(year: 1917, month: 10, day: 18, hour: 18, minute: 42, second: 36, millisecond: 544, kind: DateTimeKind.Local),

new DateTime(year: 1985, month: 10, day: 6, hour: 2, minute: 36, second: 41, millisecond: 260, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1968, month: 10, day: 13, hour: 11, minute: 10, second: 35, millisecond: 768, kind: DateTimeKind.Local),

new DateTime(year: 1922, month: 10, day: 14, hour: 4, minute: 20, second: 52, millisecond: 938, kind: DateTimeKind.Local),

new DateTime(year: 1983, month: 10, day: 8, hour: 17, minute: 6, second: 37, millisecond: 454, kind: DateTimeKind.Local),

new DateTime(year: 1929, month: 10, day: 18, hour: 9, minute: 8, second: 42, millisecond: 755, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1921, month: 10, day: 4, hour: 18, minute: 56, second: 22, millisecond: 654, kind: DateTimeKind.Local),

new DateTime(year: 1929, month: 10, day: 11, hour: 13, minute: 43, second: 31, millisecond: 675, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 8, hour: 10, minute: 5, second: 36, millisecond: 175, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1930, month: 10, day: 11, hour: 4, minute: 31, second: 49, millisecond: 628, kind: DateTimeKind.Local),

new DateTime(year: 1992, month: 10, day: 6, hour: 3, minute: 19, second: 22, millisecond: 516, kind: DateTimeKind.Local),

new DateTime(year: 1935, month: 10, day: 5, hour: 21, minute: 4, second: 4, millisecond: 632, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2013, month: 10, day: 5, hour: 9, minute: 2, second: 21, millisecond: 601, kind: DateTimeKind.Local),

new DateTime(year: 2001, month: 10, day: 11, hour: 10, minute: 23, second: 57, millisecond: 176, kind: DateTimeKind.Local),

new DateTime(year: 1940, month: 10, day: 2, hour: 6, minute: 9, second: 42, millisecond: 631, kind: DateTimeKind.Local),

new DateTime(year: 2000, month: 10, day: 5, hour: 22, minute: 25, second: 25, millisecond: 697, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1977, month: 10, day: 2, hour: 2, minute: 14, second: 39, millisecond: 871, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 5, hour: 6, minute: 13, second: 29, millisecond: 899, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 11, hour: 7, minute: 9, second: 9, millisecond: 37, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 11, hour: 4, minute: 51, second: 23, millisecond: 196, kind: DateTimeKind.Local),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1918, month: 10, day: 17, hour: 21, minute: 20, second: 6, millisecond: 149, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 13, hour: 15, minute: 48, second: 55, millisecond: 836, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 17, hour: 14, minute: 21, second: 23, millisecond: 215, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2002, month: 10, day: 10, hour: 5, minute: 2, second: 42, millisecond: 270, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 6, hour: 20, minute: 38, second: 46, millisecond: 219, kind: DateTimeKind.Local),

new DateTime(year: 1937, month: 10, day: 14, hour: 10, minute: 58, second: 7, millisecond: 337, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1995, month: 10, day: 19, hour: 11, minute: 50, second: 4, millisecond: 136, kind: DateTimeKind.Local),

new DateTime(year: 2009, month: 10, day: 7, hour: 11, minute: 54, second: 10, millisecond: 625, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 19, hour: 12, minute: 33, second: 7, millisecond: 35, kind: DateTimeKind.Local),

new DateTime(year: 2009, month: 10, day: 17, hour: 11, minute: 15, second: 31, millisecond: 941, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2011, month: 10, day: 17, hour: 1, minute: 32, second: 16, millisecond: 194, kind: DateTimeKind.Local),

new DateTime(year: 1931, month: 10, day: 3, hour: 20, minute: 57, second: 27, millisecond: 753, kind: DateTimeKind.Local),

new DateTime(year: 1938, month: 10, day: 14, hour: 14, minute: 15, second: 48, millisecond: 206, kind: DateTimeKind.Local),

new DateTime(year: 1974, month: 10, day: 18, hour: 5, minute: 29, second: 18, millisecond: 255, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1929, month: 10, day: 2, hour: 7, minute: 13, second: 51, millisecond: 930, kind: DateTimeKind.Local),

new DateTime(year: 2012, month: 10, day: 4, hour: 19, minute: 9, second: 4, millisecond: 662, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 9, hour: 7, minute: 11, second: 11, millisecond: 904, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2011, month: 10, day: 13, hour: 14, minute: 5, second: 34, millisecond: 656, kind: DateTimeKind.Local),

new DateTime(year: 1923, month: 10, day: 19, hour: 20, minute: 44, second: 55, millisecond: 980, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 10, hour: 1, minute: 55, second: 40, millisecond: 425, kind: DateTimeKind.Local),

},
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1986, month: 10, day: 1, hour: 10, minute: 52, second: 20, millisecond: 853, kind: DateTimeKind.Local),

new DateTime(year: 1967, month: 10, day: 6, hour: 21, minute: 42, second: 21, millisecond: 611, kind: DateTimeKind.Local),

new DateTime(year: 2012, month: 10, day: 11, hour: 17, minute: 52, second: 17, millisecond: 194, kind: DateTimeKind.Local),

new DateTime(year: 1963, month: 10, day: 8, hour: 3, minute: 46, second: 30, millisecond: 50, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2001, month: 10, day: 19, hour: 19, minute: 17, second: 24, millisecond: 362, kind: DateTimeKind.Local),

new DateTime(year: 1926, month: 10, day: 4, hour: 13, minute: 49, second: 2, millisecond: 613, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 9, hour: 8, minute: 11, second: 1, millisecond: 617, kind: DateTimeKind.Local),

new DateTime(year: 1936, month: 10, day: 4, hour: 11, minute: 47, second: 23, millisecond: 22, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2000, month: 10, day: 12, hour: 15, minute: 25, second: 29, millisecond: 894, kind: DateTimeKind.Local),

new DateTime(year: 1938, month: 10, day: 4, hour: 20, minute: 33, second: 19, millisecond: 113, kind: DateTimeKind.Local),

new DateTime(year: 1956, month: 10, day: 13, hour: 10, minute: 49, second: 32, millisecond: 298, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1922, month: 10, day: 13, hour: 1, minute: 45, second: 1, millisecond: 801, kind: DateTimeKind.Local),

new DateTime(year: 1933, month: 10, day: 14, hour: 15, minute: 38, second: 34, millisecond: 900, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 13, hour: 18, minute: 58, second: 23, millisecond: 763, kind: DateTimeKind.Local),

new DateTime(year: 1977, month: 10, day: 8, hour: 17, minute: 42, second: 50, millisecond: 932, kind: DateTimeKind.Local),

},
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1998, month: 10, day: 1, hour: 16, minute: 47, second: 50, millisecond: 959, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 18, hour: 12, minute: 37, second: 56, millisecond: 600, kind: DateTimeKind.Local),

new DateTime(year: 1941, month: 10, day: 5, hour: 4, minute: 38, second: 44, millisecond: 62, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 17, hour: 19, minute: 46, second: 45, millisecond: 157, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1997, month: 10, day: 6, hour: 22, minute: 2, second: 9, millisecond: 699, kind: DateTimeKind.Local),

new DateTime(year: 1917, month: 10, day: 4, hour: 13, minute: 57, second: 15, millisecond: 784, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 9, hour: 3, minute: 53, second: 9, millisecond: 783, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1989, month: 10, day: 5, hour: 1, minute: 39, second: 5, millisecond: 209, kind: DateTimeKind.Local),

new DateTime(year: 1920, month: 10, day: 8, hour: 18, minute: 46, second: 55, millisecond: 980, kind: DateTimeKind.Local),

new DateTime(year: 2011, month: 10, day: 10, hour: 8, minute: 42, second: 7, millisecond: 626, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1991, month: 10, day: 4, hour: 8, minute: 28, second: 38, millisecond: 886, kind: DateTimeKind.Local),

new DateTime(year: 2009, month: 10, day: 18, hour: 22, minute: 12, second: 18, millisecond: 135, kind: DateTimeKind.Local),

new DateTime(year: 1944, month: 10, day: 15, hour: 10, minute: 54, second: 7, millisecond: 20, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1954, month: 10, day: 13, hour: 11, minute: 27, second: 44, millisecond: 530, kind: DateTimeKind.Local),

new DateTime(year: 1938, month: 10, day: 3, hour: 3, minute: 33, second: 35, millisecond: 591, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 7, hour: 21, minute: 52, second: 40, millisecond: 562, kind: DateTimeKind.Local),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1992, month: 10, day: 1, hour: 4, minute: 22, second: 20, millisecond: 31, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 9, hour: 7, minute: 57, second: 12, millisecond: 389, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 11, hour: 6, minute: 23, second: 25, millisecond: 782, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 16, hour: 9, minute: 33, second: 8, millisecond: 309, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1981, month: 10, day: 4, hour: 17, minute: 21, second: 27, millisecond: 739, kind: DateTimeKind.Local),

new DateTime(year: 1967, month: 10, day: 1, hour: 20, minute: 28, second: 44, millisecond: 732, kind: DateTimeKind.Local),

new DateTime(year: 1929, month: 10, day: 12, hour: 14, minute: 40, second: 52, millisecond: 659, kind: DateTimeKind.Local),

new DateTime(year: 1935, month: 10, day: 16, hour: 14, minute: 12, second: 24, millisecond: 709, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1977, month: 10, day: 18, hour: 18, minute: 7, second: 49, millisecond: 220, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 11, hour: 20, minute: 47, second: 31, millisecond: 558, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 6, hour: 17, minute: 46, second: 29, millisecond: 832, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1985, month: 10, day: 18, hour: 2, minute: 27, second: 34, millisecond: 455, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 4, hour: 1, minute: 52, second: 56, millisecond: 380, kind: DateTimeKind.Local),

new DateTime(year: 2007, month: 10, day: 7, hour: 2, minute: 46, second: 23, millisecond: 598, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1936, month: 10, day: 14, hour: 10, minute: 21, second: 53, millisecond: 165, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 18, hour: 15, minute: 19, second: 42, millisecond: 414, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 15, hour: 17, minute: 20, second: 19, millisecond: 321, kind: DateTimeKind.Local),

},
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1943, month: 10, day: 1, hour: 16, minute: 53, second: 1, millisecond: 319, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 18, hour: 18, minute: 54, second: 8, millisecond: 801, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 3, hour: 11, minute: 17, second: 9, millisecond: 541, kind: DateTimeKind.Local),

new DateTime(year: 1933, month: 10, day: 8, hour: 11, minute: 33, second: 46, millisecond: 708, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1938, month: 10, day: 17, hour: 15, minute: 39, second: 1, millisecond: 71, kind: DateTimeKind.Local),

new DateTime(year: 1935, month: 10, day: 1, hour: 19, minute: 4, second: 27, millisecond: 605, kind: DateTimeKind.Local),

new DateTime(year: 1935, month: 10, day: 14, hour: 3, minute: 11, second: 33, millisecond: 827, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1970, month: 10, day: 5, hour: 10, minute: 3, second: 35, millisecond: 484, kind: DateTimeKind.Local),

new DateTime(year: 2017, month: 10, day: 7, hour: 4, minute: 45, second: 58, millisecond: 726, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 5, hour: 21, minute: 3, second: 36, millisecond: 444, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1988, month: 10, day: 3, hour: 19, minute: 54, second: 40, millisecond: 191, kind: DateTimeKind.Local),

new DateTime(year: 1992, month: 10, day: 18, hour: 20, minute: 33, second: 23, millisecond: 230, kind: DateTimeKind.Local),

new DateTime(year: 1920, month: 10, day: 17, hour: 4, minute: 7, second: 27, millisecond: 651, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 7, hour: 7, minute: 54, second: 44, millisecond: 143, kind: DateTimeKind.Local),

},
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1942, month: 10, day: 18, hour: 5, minute: 15, second: 33, millisecond: 642, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 1, hour: 21, minute: 1, second: 47, millisecond: 136, kind: DateTimeKind.Local),

new DateTime(year: 1929, month: 10, day: 19, hour: 14, minute: 13, second: 6, millisecond: 513, kind: DateTimeKind.Local),

new DateTime(year: 1960, month: 10, day: 11, hour: 3, minute: 57, second: 43, millisecond: 72, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1935, month: 10, day: 4, hour: 11, minute: 38, second: 36, millisecond: 256, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 9, hour: 16, minute: 25, second: 53, millisecond: 102, kind: DateTimeKind.Local),

new DateTime(year: 1952, month: 10, day: 6, hour: 19, minute: 30, second: 32, millisecond: 297, kind: DateTimeKind.Local),

new DateTime(year: 1991, month: 10, day: 4, hour: 22, minute: 42, second: 38, millisecond: 964, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1939, month: 10, day: 12, hour: 16, minute: 39, second: 15, millisecond: 317, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 2, hour: 12, minute: 18, second: 31, millisecond: 554, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 11, hour: 12, minute: 3, second: 4, millisecond: 381, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1986, month: 10, day: 8, hour: 10, minute: 53, second: 42, millisecond: 426, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 4, hour: 4, minute: 21, second: 9, millisecond: 814, kind: DateTimeKind.Local),

new DateTime(year: 1974, month: 10, day: 6, hour: 2, minute: 33, second: 22, millisecond: 796, kind: DateTimeKind.Local),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1937, month: 10, day: 13, hour: 21, minute: 18, second: 9, millisecond: 660, kind: DateTimeKind.Local),

new DateTime(year: 1953, month: 10, day: 5, hour: 18, minute: 47, second: 31, millisecond: 418, kind: DateTimeKind.Local),

new DateTime(year: 1977, month: 10, day: 17, hour: 9, minute: 14, second: 1, millisecond: 844, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1951, month: 10, day: 12, hour: 1, minute: 3, second: 4, millisecond: 357, kind: DateTimeKind.Local),

new DateTime(year: 1922, month: 10, day: 6, hour: 12, minute: 17, second: 13, millisecond: 964, kind: DateTimeKind.Local),

new DateTime(year: 1963, month: 10, day: 19, hour: 7, minute: 19, second: 57, millisecond: 994, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1923, month: 10, day: 11, hour: 3, minute: 2, second: 58, millisecond: 626, kind: DateTimeKind.Local),

new DateTime(year: 2004, month: 10, day: 9, hour: 18, minute: 39, second: 57, millisecond: 203, kind: DateTimeKind.Local),

new DateTime(year: 2001, month: 10, day: 5, hour: 13, minute: 30, second: 37, millisecond: 663, kind: DateTimeKind.Local),

new DateTime(year: 1971, month: 10, day: 2, hour: 3, minute: 15, second: 46, millisecond: 616, kind: DateTimeKind.Local),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2005, month: 10, day: 2, hour: 11, minute: 5, second: 27, millisecond: 869, kind: DateTimeKind.Local),

new DateTime(year: 1993, month: 10, day: 14, hour: 18, minute: 37, second: 31, millisecond: 865, kind: DateTimeKind.Local),

new DateTime(year: 1978, month: 10, day: 16, hour: 10, minute: 43, second: 5, millisecond: 107, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 4, hour: 10, minute: 20, second: 49, millisecond: 988, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2010, month: 10, day: 4, hour: 20, minute: 47, second: 18, millisecond: 903, kind: DateTimeKind.Local),

new DateTime(year: 1960, month: 10, day: 19, hour: 4, minute: 8, second: 32, millisecond: 529, kind: DateTimeKind.Local),

new DateTime(year: 1977, month: 10, day: 14, hour: 15, minute: 42, second: 41, millisecond: 550, kind: DateTimeKind.Local),

new DateTime(year: 1941, month: 10, day: 15, hour: 10, minute: 23, second: 40, millisecond: 199, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1958, month: 10, day: 9, hour: 15, minute: 41, second: 53, millisecond: 879, kind: DateTimeKind.Local),

new DateTime(year: 1935, month: 10, day: 11, hour: 14, minute: 16, second: 36, millisecond: 786, kind: DateTimeKind.Local),

new DateTime(year: 1940, month: 10, day: 18, hour: 2, minute: 50, second: 40, millisecond: 551, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 13, hour: 11, minute: 51, second: 54, millisecond: 626, kind: DateTimeKind.Local),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1943, month: 10, day: 15, hour: 13, minute: 50, second: 34, millisecond: 872, kind: DateTimeKind.Local),

new DateTime(year: 1966, month: 10, day: 15, hour: 3, minute: 53, second: 9, millisecond: 576, kind: DateTimeKind.Local),

new DateTime(year: 1960, month: 10, day: 19, hour: 5, minute: 33, second: 30, millisecond: 899, kind: DateTimeKind.Local),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zonearray2mi(
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
            asPartInterface: typeof(IDateTimeListtimestamp_without_time_zoneArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateTime>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483627)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateTime>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483627))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zonearray2mi(
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
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_without_time_zoneArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateTime>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483627)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateTime>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483627))]
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

                changedRows =  ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zonearray2m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_without_time_zonearray2mi_id
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
            asPartInterface: typeof(IDateTimeListtimestamp_without_time_zoneArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateTime>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483627)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateTime>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483627)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "datetimetimestamp_without_time_zonearray2mi_id", 
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
                changedRows =  ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zonearray2m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_without_time_zonearray2mi_id
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
    datetimetimestamp_without_time_zonearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_without_time_zoneArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zonearray2m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_without_time_zonearray2mi_id
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
    datetimetimestamp_without_time_zonearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_without_time_zoneArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateTime>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483627)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateTime>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483627)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "datetimetimestamp_without_time_zonearray2mi_id", 
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
                List<DateTimetimestamp_without_time_zoneArray2M> models = null;

                models =  ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DateTimetimestamp_without_time_zoneArray2M> models = null;

                models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_without_time_zoneArray)),
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
FROM public.datetimetimestamp_without_time_zonearray2m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonearray2m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((IDateTimeListtimestamp_without_time_zoneArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonearray2m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_without_time_zoneArray)),
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

                var models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((IDateTimeListtimestamp_without_time_zoneArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_without_time_zoneArray)),
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
FROM public.datetimetimestamp_without_time_zonearray2m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonearray2m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((IDateTimeListtimestamp_without_time_zoneArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonearray2m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_without_time_zoneArray)),
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
                var models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDateTimeListtimestamp_without_time_zoneArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_without_time_zoneArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_without_time_zoneArray)),
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
FROM public.datetimetimestamp_without_time_zonearray2m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_without_time_zonearray2m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray2mi_id
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
FROM public.datetimetimestamp_without_time_zonearray2m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[9], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[10], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[11], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[12], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[13], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[14], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[15], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[16], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[17], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[18], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[19], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[20], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[21], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[22], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[23], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[24], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[25], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[17],_testData[26], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[18],_testData[27], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[19],_testData[28], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[3], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[4], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[5], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[6], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[7], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[8], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[9], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[10], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[11], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[12], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[13], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[14], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[15], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[16], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[17], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[18], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[19], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[17],_testData[20], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[18],_testData[21], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[19],_testData[22], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[20],_testData[23], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[21],_testData[24], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[22],_testData[25], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[23],_testData[26], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[24],_testData[27], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[25],_testData[28], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[26],_testData[29], false);
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
FROM public.datetimetimestamp_without_time_zonearray2m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_without_time_zonearray2m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray2mi_id
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
FROM public.datetimetimestamp_without_time_zonearray2m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[26], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[27], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[28], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[5], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[6], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[7], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[8], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[9], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[10], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[11], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[12], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[13], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[14], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[15], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[16], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[17], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[18], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[19], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[20], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[21], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[17],_testData[22], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[18],_testData[23], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[19],_testData[24], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[20],_testData[25], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[21],_testData[26], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[22],_testData[27], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[23],_testData[28], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[24],_testData[29], false);
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
FROM public.datetimetimestamp_without_time_zonearray2m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_without_time_zoneArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_without_time_zoneArray)),
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

                var models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[4], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[5], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[6], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[7], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[8], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[9], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[10], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[11], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[12], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[13], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[14], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[15], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[16], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[17], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[18], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[19], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[20], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[17],_testData[21], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[18],_testData[22], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[19],_testData[23], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[20],_testData[24], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[21],_testData[25], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[22],_testData[26], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[23],_testData[27], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[24],_testData[28], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[22], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[23], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[24], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[25], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[26], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[27], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[28], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[29], false);
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

                var models =  ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[20], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[21], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[22], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[23], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[24], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[25], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[26], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[27], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[28], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[9], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[10], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[11], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[12], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[13], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[14], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[15], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[16], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[17], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[18], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[19], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[20], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[21], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[22], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[23], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[24], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[25], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[17],_testData[26], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[18],_testData[27], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[19],_testData[28], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_without_time_zoneArray)),
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
            asPartInterface: typeof(IDateTimeListtimestamp_without_time_zoneArray)),
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
FROM public.datetimetimestamp_without_time_zonearray2m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonearray2m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray2mi_id
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
FROM public.datetimetimestamp_without_time_zonearray2m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 24, query1, 15, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[7], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[8], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[9], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[10], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[11], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[12], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[13], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[14], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[15], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[16], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[17], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[18], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[19], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[20], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[21], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[22], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[23], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[17],_testData[24], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[18],_testData[25], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[19],_testData[26], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[20],_testData[27], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[21],_testData[28], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[4], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[5], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[6], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[7], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[8], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[9], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[10], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[11], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[12], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[13], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[14], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[15], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[16], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[17], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[18], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[19], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[20], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[17],_testData[21], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[18],_testData[22], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[19],_testData[23], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[20],_testData[24], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[21],_testData[25], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[22],_testData[26], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[23],_testData[27], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[24],_testData[28], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[25],_testData[29], false);
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
FROM public.datetimetimestamp_without_time_zonearray2m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonearray2m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray2mi_id
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
FROM public.datetimetimestamp_without_time_zonearray2m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatch(connection, 17, query1, 72, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[5], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[6], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[7], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[8], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[9], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[10], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[11], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[12], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[13], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[14], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[15], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[16], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[17], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[18], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[19], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[20], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[21], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[17],_testData[22], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[18],_testData[23], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[19],_testData[24], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[20],_testData[25], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[21],_testData[26], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[22],_testData[27], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[23],_testData[28], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[16], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[17], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[18], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[19], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[20], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[21], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[22], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[23], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[24], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[25], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[26], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[27], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[28], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[29], false);
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
FROM public.datetimetimestamp_without_time_zonearray2m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_without_time_zoneArray)),
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
            asPartInterface: typeof(IDateTimeListtimestamp_without_time_zoneArray)),
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
                var models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSelectModelBatchAsync(connection, 17, 48))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[5], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[6], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[7], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[8], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[9], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[10], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[11], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[12], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[13], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[14], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[15], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[16], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[17], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[18], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[19], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[20], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[21], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[17],_testData[22], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[18],_testData[23], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[19],_testData[24], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[20],_testData[25], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[21],_testData[26], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[22],_testData[27], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[23],_testData[28], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[11], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[12], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[13], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[14], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[15], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[16], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[17], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[18], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[19], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[20], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[21], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[22], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[23], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[24], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[25], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[26], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[27], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[17],_testData[28], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[18],_testData[29], false);
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
                var models =  ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSelectModelBatch(connection, 100, 72))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[22], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[23], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[24], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[25], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[26], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[27], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[28], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[16], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[17], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[18], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[19], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[20], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[21], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[22], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[23], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[24], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[25], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[26], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[27], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[28], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[29], false);
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
                await using var cmd = await ((IDateTimeListtimestamp_without_time_zoneArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDateTimeListtimestamp_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 80);
                var models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[18], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[19], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[20], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[21], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[22], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[23], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[24], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[25], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[26], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[27], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[28], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateTimeListtimestamp_without_time_zoneArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateTimeListtimestamp_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 132);
                var models =  ((IDateTimeListtimestamp_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[28], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_datetimetimestamp_without_time_zonearray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483627),
                (NpgsqlTypes.NpgsqlDbType)(-2147483627)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_without_time_zoneArray))]
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
FROM public.binary_datetimetimestamp_without_time_zonearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_without_time_zoneArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<DateTimetimestamp_without_time_zoneArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IDateTimeListtimestamp_without_time_zoneArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDateTimeListtimestamp_without_time_zoneArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray2MI.AssertModel(actual, expect, false);
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
                await ((IDateTimeListtimestamp_without_time_zoneArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_datetimetimestamp_without_time_zonearray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
datetimetimestamp_without_time_zonearray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483627),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483627)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_without_time_zoneArray))]
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
FROM public.binary_datetimetimestamp_without_time_zonearray2m m
LEFT JOIN public.binary_datetimetimestamp_without_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_without_time_zoneArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<DateTimetimestamp_without_time_zoneArray2M>(15);

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
                ((IDateTimeListtimestamp_without_time_zoneArray)this).ImportModel(connection, importCollection);
                var models = ((IDateTimeListtimestamp_without_time_zoneArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[0], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[1], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[2], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[3], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[4], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[5], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[6], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[7], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[8], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[9], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[10], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[11], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[12], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[13], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((IDateTimeListtimestamp_without_time_zoneArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[0], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[1], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[2], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[3], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[4], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[5], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[6], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[7], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[8], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[9], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[10], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[11], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[12], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[13], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[14], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[15], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[16], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[17],_testData[17], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[18],_testData[18], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[19],_testData[19], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[20],_testData[20], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[21],_testData[21], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[22],_testData[22], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[23],_testData[23], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[24],_testData[24], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[25],_testData[25], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[26],_testData[26], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[27],_testData[27], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[28],_testData[28], false);
                DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_datetimetimestamp_without_time_zonearray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    datetimetimestamp_without_time_zonearray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483627),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483627)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_without_time_zoneArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDateTimeListtimestamp_without_time_zoneArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DateTimetimestamp_without_time_zoneArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DateTimetimestamp_without_time_zoneArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_datetimetimestamp_without_time_zonearray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483627),
                (NpgsqlTypes.NpgsqlDbType)(-2147483627)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_without_time_zoneArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDateTimeListtimestamp_without_time_zoneArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

