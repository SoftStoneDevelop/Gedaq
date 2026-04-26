

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
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1993, month: 10, day: 7, hour: 14, minute: 50, second: 57, millisecond: 151, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 13, hour: 6, minute: 9, second: 56, millisecond: 354, kind: DateTimeKind.Utc),

new DateTime(year: 1921, month: 10, day: 18, hour: 1, minute: 41, second: 47, millisecond: 188, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 8, hour: 5, minute: 29, second: 1, millisecond: 193, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 13, hour: 15, minute: 52, second: 52, millisecond: 557, kind: DateTimeKind.Utc),

new DateTime(year: 1919, month: 10, day: 15, hour: 1, minute: 20, second: 46, millisecond: 889, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 2, hour: 12, minute: 51, second: 31, millisecond: 318, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2006, month: 10, day: 7, hour: 10, minute: 49, second: 40, millisecond: 767, kind: DateTimeKind.Utc),

new DateTime(year: 1943, month: 10, day: 7, hour: 4, minute: 52, second: 13, millisecond: 691, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 12, hour: 20, minute: 14, second: 21, millisecond: 622, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 16, hour: 12, minute: 50, second: 22, millisecond: 346, kind: DateTimeKind.Utc),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1931, month: 10, day: 3, hour: 11, minute: 50, second: 3, millisecond: 475, kind: DateTimeKind.Utc),

new DateTime(year: 1990, month: 10, day: 12, hour: 18, minute: 16, second: 24, millisecond: 179, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 5, hour: 1, minute: 45, second: 16, millisecond: 976, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 14, hour: 10, minute: 13, second: 57, millisecond: 947, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1932, month: 10, day: 14, hour: 16, minute: 15, second: 27, millisecond: 817, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 6, hour: 2, minute: 11, second: 20, millisecond: 859, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 17, hour: 1, minute: 50, second: 2, millisecond: 560, kind: DateTimeKind.Utc),

new DateTime(year: 1936, month: 10, day: 2, hour: 2, minute: 58, second: 27, millisecond: 201, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1921, month: 10, day: 3, hour: 12, minute: 49, second: 11, millisecond: 931, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 17, hour: 15, minute: 52, second: 30, millisecond: 802, kind: DateTimeKind.Utc),

new DateTime(year: 1966, month: 10, day: 5, hour: 13, minute: 45, second: 42, millisecond: 150, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1999, month: 10, day: 8, hour: 2, minute: 31, second: 35, millisecond: 965, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 2, hour: 10, minute: 53, second: 1, millisecond: 686, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 15, hour: 21, minute: 10, second: 34, millisecond: 81, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 19, hour: 14, minute: 14, second: 25, millisecond: 288, kind: DateTimeKind.Utc),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1919, month: 10, day: 11, hour: 11, minute: 27, second: 11, millisecond: 139, kind: DateTimeKind.Utc),

new DateTime(year: 1921, month: 10, day: 12, hour: 17, minute: 45, second: 55, millisecond: 219, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 3, hour: 3, minute: 27, second: 35, millisecond: 175, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2009, month: 10, day: 8, hour: 9, minute: 35, second: 57, millisecond: 568, kind: DateTimeKind.Utc),

new DateTime(year: 1920, month: 10, day: 11, hour: 12, minute: 32, second: 28, millisecond: 82, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 8, hour: 2, minute: 27, second: 45, millisecond: 353, kind: DateTimeKind.Utc),

new DateTime(year: 1969, month: 10, day: 10, hour: 11, minute: 25, second: 3, millisecond: 867, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1919, month: 10, day: 17, hour: 1, minute: 6, second: 10, millisecond: 88, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 6, hour: 20, minute: 23, second: 18, millisecond: 58, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 18, hour: 14, minute: 9, second: 10, millisecond: 802, kind: DateTimeKind.Utc),

new DateTime(year: 1937, month: 10, day: 7, hour: 4, minute: 54, second: 10, millisecond: 792, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2013, month: 10, day: 10, hour: 21, minute: 12, second: 44, millisecond: 635, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 15, hour: 11, minute: 29, second: 14, millisecond: 767, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 9, hour: 13, minute: 56, second: 49, millisecond: 707, kind: DateTimeKind.Utc),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1980, month: 10, day: 15, hour: 4, minute: 25, second: 31, millisecond: 995, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 14, hour: 19, minute: 27, second: 39, millisecond: 833, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 18, hour: 14, minute: 56, second: 22, millisecond: 114, kind: DateTimeKind.Utc),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2001, month: 10, day: 1, hour: 3, minute: 35, second: 42, millisecond: 357, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 13, hour: 10, minute: 49, second: 16, millisecond: 108, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 18, hour: 21, minute: 41, second: 11, millisecond: 577, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1940, month: 10, day: 15, hour: 9, minute: 15, second: 49, millisecond: 753, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 3, hour: 22, minute: 53, second: 13, millisecond: 19, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 19, hour: 9, minute: 34, second: 1, millisecond: 455, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 2, hour: 13, minute: 21, second: 56, millisecond: 534, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2012, month: 10, day: 14, hour: 3, minute: 20, second: 39, millisecond: 76, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 2, hour: 22, minute: 15, second: 33, millisecond: 792, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 7, hour: 5, minute: 57, second: 9, millisecond: 196, kind: DateTimeKind.Utc),

new DateTime(year: 1965, month: 10, day: 6, hour: 5, minute: 22, second: 12, millisecond: 435, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1947, month: 10, day: 1, hour: 4, minute: 41, second: 33, millisecond: 113, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 10, hour: 2, minute: 39, second: 8, millisecond: 881, kind: DateTimeKind.Utc),

new DateTime(year: 1939, month: 10, day: 11, hour: 1, minute: 22, second: 33, millisecond: 759, kind: DateTimeKind.Utc),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2001, month: 10, day: 15, hour: 3, minute: 19, second: 9, millisecond: 569, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 18, hour: 14, minute: 29, second: 58, millisecond: 30, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 11, hour: 15, minute: 47, second: 2, millisecond: 37, kind: DateTimeKind.Utc),

new DateTime(year: 1918, month: 10, day: 16, hour: 21, minute: 49, second: 33, millisecond: 713, kind: DateTimeKind.Utc),

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
new DateTime(year: 1943, month: 10, day: 16, hour: 10, minute: 53, second: 2, millisecond: 570, kind: DateTimeKind.Utc),

new DateTime(year: 1952, month: 10, day: 14, hour: 14, minute: 18, second: 41, millisecond: 698, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 3, hour: 3, minute: 26, second: 35, millisecond: 612, kind: DateTimeKind.Utc),

new DateTime(year: 1921, month: 10, day: 1, hour: 21, minute: 9, second: 30, millisecond: 870, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1934, month: 10, day: 4, hour: 16, minute: 2, second: 49, millisecond: 542, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 16, hour: 2, minute: 50, second: 9, millisecond: 876, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 5, hour: 11, minute: 50, second: 7, millisecond: 26, kind: DateTimeKind.Utc),

new DateTime(year: 1943, month: 10, day: 16, hour: 4, minute: 49, second: 51, millisecond: 31, kind: DateTimeKind.Utc),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1978, month: 10, day: 4, hour: 3, minute: 19, second: 27, millisecond: 432, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 19, hour: 10, minute: 18, second: 14, millisecond: 895, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 11, hour: 21, minute: 52, second: 38, millisecond: 638, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 8, hour: 12, minute: 35, second: 24, millisecond: 534, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1917, month: 10, day: 18, hour: 20, minute: 24, second: 7, millisecond: 351, kind: DateTimeKind.Utc),

new DateTime(year: 1994, month: 10, day: 3, hour: 7, minute: 50, second: 48, millisecond: 35, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 2, hour: 4, minute: 27, second: 24, millisecond: 672, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 9, hour: 10, minute: 48, second: 39, millisecond: 63, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1984, month: 10, day: 11, hour: 12, minute: 39, second: 43, millisecond: 949, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 11, hour: 20, minute: 26, second: 38, millisecond: 38, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 15, hour: 9, minute: 53, second: 24, millisecond: 891, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 6, hour: 6, minute: 56, second: 44, millisecond: 759, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1950, month: 10, day: 16, hour: 1, minute: 11, second: 14, millisecond: 983, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 13, hour: 8, minute: 35, second: 11, millisecond: 52, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 7, hour: 9, minute: 4, second: 36, millisecond: 490, kind: DateTimeKind.Utc),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1954, month: 10, day: 7, hour: 6, minute: 23, second: 43, millisecond: 75, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 4, hour: 2, minute: 21, second: 58, millisecond: 977, kind: DateTimeKind.Utc),

new DateTime(year: 1990, month: 10, day: 14, hour: 18, minute: 46, second: 30, millisecond: 489, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 18, hour: 22, minute: 21, second: 1, millisecond: 279, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1953, month: 10, day: 3, hour: 21, minute: 10, second: 26, millisecond: 202, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 1, hour: 19, minute: 24, second: 13, millisecond: 391, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 18, hour: 8, minute: 45, second: 49, millisecond: 816, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 19, hour: 5, minute: 21, second: 46, millisecond: 261, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1999, month: 10, day: 2, hour: 19, minute: 18, second: 12, millisecond: 202, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 16, hour: 18, minute: 38, second: 31, millisecond: 89, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 16, hour: 4, minute: 26, second: 29, millisecond: 942, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 13, hour: 10, minute: 24, second: 36, millisecond: 646, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1926, month: 10, day: 14, hour: 15, minute: 27, second: 21, millisecond: 938, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 9, hour: 3, minute: 24, second: 21, millisecond: 329, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 12, hour: 3, minute: 43, second: 35, millisecond: 503, kind: DateTimeKind.Utc),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1938, month: 10, day: 19, hour: 22, minute: 56, second: 6, millisecond: 226, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 1, hour: 14, minute: 20, second: 13, millisecond: 235, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 9, hour: 20, minute: 15, second: 29, millisecond: 794, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 15, hour: 12, minute: 48, second: 54, millisecond: 907, kind: DateTimeKind.Utc),

},
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1954, month: 10, day: 5, hour: 3, minute: 24, second: 9, millisecond: 756, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 12, hour: 14, minute: 28, second: 20, millisecond: 501, kind: DateTimeKind.Utc),

new DateTime(year: 1969, month: 10, day: 2, hour: 3, minute: 14, second: 26, millisecond: 361, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2005, month: 10, day: 1, hour: 4, minute: 30, second: 23, millisecond: 229, kind: DateTimeKind.Utc),

new DateTime(year: 1937, month: 10, day: 16, hour: 19, minute: 3, second: 5, millisecond: 542, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 7, hour: 18, minute: 12, second: 32, millisecond: 137, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 12, hour: 18, minute: 16, second: 18, millisecond: 248, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1943, month: 10, day: 14, hour: 2, minute: 55, second: 31, millisecond: 482, kind: DateTimeKind.Utc),

new DateTime(year: 2018, month: 10, day: 17, hour: 15, minute: 34, second: 57, millisecond: 861, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 14, hour: 5, minute: 15, second: 52, millisecond: 118, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1976, month: 10, day: 16, hour: 21, minute: 45, second: 9, millisecond: 951, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 15, hour: 15, minute: 40, second: 57, millisecond: 789, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 6, hour: 2, minute: 42, second: 49, millisecond: 895, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 14, hour: 6, minute: 25, second: 48, millisecond: 36, kind: DateTimeKind.Utc),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2017, month: 10, day: 16, hour: 11, minute: 53, second: 56, millisecond: 101, kind: DateTimeKind.Utc),

new DateTime(year: 2005, month: 10, day: 1, hour: 4, minute: 43, second: 50, millisecond: 282, kind: DateTimeKind.Utc),

new DateTime(year: 1936, month: 10, day: 14, hour: 21, minute: 47, second: 36, millisecond: 591, kind: DateTimeKind.Utc),

new DateTime(year: 1936, month: 10, day: 10, hour: 12, minute: 26, second: 31, millisecond: 583, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1922, month: 10, day: 15, hour: 13, minute: 24, second: 33, millisecond: 851, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 9, hour: 12, minute: 37, second: 7, millisecond: 389, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 8, hour: 19, minute: 52, second: 18, millisecond: 773, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2019, month: 10, day: 1, hour: 20, minute: 53, second: 55, millisecond: 392, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 4, hour: 9, minute: 19, second: 47, millisecond: 346, kind: DateTimeKind.Utc),

new DateTime(year: 1982, month: 10, day: 5, hour: 5, minute: 8, second: 31, millisecond: 926, kind: DateTimeKind.Utc),

new DateTime(year: 1918, month: 10, day: 10, hour: 17, minute: 58, second: 37, millisecond: 155, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1994, month: 10, day: 2, hour: 5, minute: 58, second: 26, millisecond: 361, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 4, hour: 17, minute: 44, second: 48, millisecond: 408, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 2, hour: 17, minute: 32, second: 21, millisecond: 871, kind: DateTimeKind.Utc),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1999, month: 10, day: 6, hour: 11, minute: 36, second: 13, millisecond: 529, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 9, hour: 10, minute: 47, second: 4, millisecond: 816, kind: DateTimeKind.Utc),

new DateTime(year: 1952, month: 10, day: 5, hour: 1, minute: 31, second: 19, millisecond: 391, kind: DateTimeKind.Utc),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1945, month: 10, day: 17, hour: 14, minute: 8, second: 24, millisecond: 795, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 9, hour: 4, minute: 44, second: 13, millisecond: 702, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 4, hour: 10, minute: 56, second: 21, millisecond: 84, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 4, hour: 14, minute: 38, second: 52, millisecond: 350, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1969, month: 10, day: 10, hour: 14, minute: 33, second: 57, millisecond: 578, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 12, hour: 1, minute: 46, second: 26, millisecond: 467, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 10, hour: 19, minute: 4, second: 29, millisecond: 567, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 14, hour: 3, minute: 37, second: 32, millisecond: 758, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2012, month: 10, day: 7, hour: 10, minute: 8, second: 10, millisecond: 662, kind: DateTimeKind.Utc),

new DateTime(year: 1951, month: 10, day: 15, hour: 17, minute: 47, second: 34, millisecond: 76, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 16, hour: 8, minute: 25, second: 20, millisecond: 416, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 19, hour: 20, minute: 27, second: 3, millisecond: 167, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1920, month: 10, day: 14, hour: 10, minute: 12, second: 52, millisecond: 365, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 12, hour: 12, minute: 49, second: 25, millisecond: 25, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 19, hour: 13, minute: 3, second: 49, millisecond: 323, kind: DateTimeKind.Utc),

new DateTime(year: 2018, month: 10, day: 13, hour: 14, minute: 32, second: 29, millisecond: 345, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2004, month: 10, day: 5, hour: 13, minute: 30, second: 8, millisecond: 444, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 17, hour: 11, minute: 51, second: 43, millisecond: 210, kind: DateTimeKind.Utc),

new DateTime(year: 1944, month: 10, day: 7, hour: 15, minute: 5, second: 49, millisecond: 256, kind: DateTimeKind.Utc),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2013, month: 10, day: 10, hour: 19, minute: 51, second: 10, millisecond: 805, kind: DateTimeKind.Utc),

new DateTime(year: 2017, month: 10, day: 11, hour: 17, minute: 38, second: 57, millisecond: 836, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 1, hour: 8, minute: 18, second: 42, millisecond: 851, kind: DateTimeKind.Utc),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1940, month: 10, day: 16, hour: 21, minute: 36, second: 48, millisecond: 627, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 6, hour: 12, minute: 35, second: 27, millisecond: 548, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 9, hour: 9, minute: 7, second: 24, millisecond: 295, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1979, month: 10, day: 6, hour: 13, minute: 8, second: 21, millisecond: 648, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 7, hour: 22, minute: 7, second: 36, millisecond: 431, kind: DateTimeKind.Utc),

new DateTime(year: 1923, month: 10, day: 6, hour: 11, minute: 38, second: 6, millisecond: 859, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 10, hour: 3, minute: 49, second: 18, millisecond: 356, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2004, month: 10, day: 19, hour: 8, minute: 34, second: 19, millisecond: 618, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 14, hour: 16, minute: 26, second: 41, millisecond: 62, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 2, hour: 1, minute: 47, second: 13, millisecond: 821, kind: DateTimeKind.Utc),

new DateTime(year: 1936, month: 10, day: 9, hour: 3, minute: 1, second: 44, millisecond: 501, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1935, month: 10, day: 7, hour: 3, minute: 29, second: 20, millisecond: 876, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 8, hour: 10, minute: 23, second: 15, millisecond: 280, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 17, hour: 9, minute: 37, second: 42, millisecond: 207, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2003, month: 10, day: 8, hour: 14, minute: 21, second: 46, millisecond: 122, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 15, hour: 3, minute: 28, second: 36, millisecond: 672, kind: DateTimeKind.Utc),

new DateTime(year: 1951, month: 10, day: 10, hour: 21, minute: 26, second: 29, millisecond: 167, kind: DateTimeKind.Utc),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1939, month: 10, day: 17, hour: 13, minute: 50, second: 7, millisecond: 454, kind: DateTimeKind.Utc),

new DateTime(year: 1951, month: 10, day: 4, hour: 4, minute: 1, second: 52, millisecond: 429, kind: DateTimeKind.Utc),

new DateTime(year: 1918, month: 10, day: 10, hour: 10, minute: 48, second: 37, millisecond: 114, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1980, month: 10, day: 2, hour: 7, minute: 14, second: 41, millisecond: 215, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 8, hour: 2, minute: 13, second: 17, millisecond: 694, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 15, hour: 5, minute: 47, second: 54, millisecond: 109, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1998, month: 10, day: 4, hour: 14, minute: 19, second: 31, millisecond: 396, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 5, hour: 11, minute: 40, second: 49, millisecond: 167, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 19, hour: 11, minute: 53, second: 43, millisecond: 115, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 6, hour: 9, minute: 28, second: 7, millisecond: 669, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1960, month: 10, day: 12, hour: 10, minute: 14, second: 43, millisecond: 109, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 17, hour: 18, minute: 53, second: 34, millisecond: 534, kind: DateTimeKind.Utc),

new DateTime(year: 1939, month: 10, day: 16, hour: 1, minute: 43, second: 49, millisecond: 108, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 18, hour: 21, minute: 52, second: 32, millisecond: 386, kind: DateTimeKind.Utc),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1956, month: 10, day: 4, hour: 13, minute: 28, second: 21, millisecond: 648, kind: DateTimeKind.Utc),

new DateTime(year: 1936, month: 10, day: 8, hour: 20, minute: 21, second: 27, millisecond: 586, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 19, hour: 7, minute: 54, second: 7, millisecond: 288, kind: DateTimeKind.Utc),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1979, month: 10, day: 16, hour: 17, minute: 32, second: 29, millisecond: 644, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 19, hour: 13, minute: 31, second: 35, millisecond: 518, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 3, hour: 12, minute: 26, second: 10, millisecond: 225, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 13, hour: 11, minute: 49, second: 18, millisecond: 249, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2015, month: 10, day: 9, hour: 2, minute: 42, second: 16, millisecond: 349, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 18, hour: 17, minute: 29, second: 27, millisecond: 184, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 3, hour: 9, minute: 52, second: 17, millisecond: 210, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 19, hour: 10, minute: 30, second: 47, millisecond: 361, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1965, month: 10, day: 16, hour: 2, minute: 6, second: 49, millisecond: 38, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 10, hour: 9, minute: 4, second: 32, millisecond: 891, kind: DateTimeKind.Utc),

new DateTime(year: 1939, month: 10, day: 8, hour: 22, minute: 35, second: 33, millisecond: 198, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2002, month: 10, day: 12, hour: 15, minute: 18, second: 45, millisecond: 932, kind: DateTimeKind.Utc),

new DateTime(year: 2001, month: 10, day: 12, hour: 17, minute: 54, second: 8, millisecond: 154, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 6, hour: 9, minute: 3, second: 2, millisecond: 78, kind: DateTimeKind.Utc),

new DateTime(year: 1994, month: 10, day: 1, hour: 17, minute: 51, second: 28, millisecond: 401, kind: DateTimeKind.Utc),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2012, month: 10, day: 4, hour: 20, minute: 55, second: 26, millisecond: 621, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 5, hour: 7, minute: 27, second: 17, millisecond: 84, kind: DateTimeKind.Utc),

new DateTime(year: 1982, month: 10, day: 2, hour: 15, minute: 51, second: 55, millisecond: 565, kind: DateTimeKind.Utc),

},
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1988, month: 10, day: 10, hour: 17, minute: 53, second: 16, millisecond: 539, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 1, hour: 21, minute: 49, second: 8, millisecond: 817, kind: DateTimeKind.Utc),

new DateTime(year: 2010, month: 10, day: 9, hour: 4, minute: 24, second: 12, millisecond: 177, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 12, hour: 17, minute: 7, second: 47, millisecond: 480, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2010, month: 10, day: 5, hour: 9, minute: 29, second: 4, millisecond: 116, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 5, hour: 15, minute: 23, second: 34, millisecond: 653, kind: DateTimeKind.Utc),

new DateTime(year: 1994, month: 10, day: 1, hour: 12, minute: 10, second: 47, millisecond: 374, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 12, hour: 14, minute: 14, second: 29, millisecond: 951, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1966, month: 10, day: 8, hour: 12, minute: 41, second: 10, millisecond: 890, kind: DateTimeKind.Utc),

new DateTime(year: 1918, month: 10, day: 7, hour: 14, minute: 27, second: 11, millisecond: 768, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 6, hour: 11, minute: 53, second: 9, millisecond: 285, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 10, hour: 17, minute: 13, second: 2, millisecond: 844, kind: DateTimeKind.Utc),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2017, month: 10, day: 4, hour: 17, minute: 24, second: 37, millisecond: 578, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 5, hour: 10, minute: 13, second: 54, millisecond: 600, kind: DateTimeKind.Utc),

new DateTime(year: 1982, month: 10, day: 9, hour: 12, minute: 47, second: 32, millisecond: 78, kind: DateTimeKind.Utc),

new DateTime(year: 1929, month: 10, day: 4, hour: 5, minute: 52, second: 34, millisecond: 336, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1952, month: 10, day: 19, hour: 7, minute: 57, second: 46, millisecond: 254, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 1, hour: 9, minute: 22, second: 19, millisecond: 798, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 4, hour: 17, minute: 26, second: 2, millisecond: 216, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 10, hour: 22, minute: 34, second: 3, millisecond: 860, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2004, month: 10, day: 17, hour: 1, minute: 58, second: 9, millisecond: 223, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 5, hour: 2, minute: 46, second: 53, millisecond: 388, kind: DateTimeKind.Utc),

new DateTime(year: 1926, month: 10, day: 17, hour: 14, minute: 49, second: 39, millisecond: 162, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2016, month: 10, day: 18, hour: 16, minute: 38, second: 56, millisecond: 649, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 3, hour: 18, minute: 2, second: 50, millisecond: 40, kind: DateTimeKind.Utc),

new DateTime(year: 2001, month: 10, day: 2, hour: 4, minute: 43, second: 43, millisecond: 162, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 2, hour: 9, minute: 11, second: 48, millisecond: 724, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1931, month: 10, day: 17, hour: 21, minute: 48, second: 31, millisecond: 135, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 13, hour: 2, minute: 39, second: 12, millisecond: 886, kind: DateTimeKind.Utc),

new DateTime(year: 1919, month: 10, day: 10, hour: 16, minute: 44, second: 37, millisecond: 188, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 16, hour: 1, minute: 4, second: 31, millisecond: 8, kind: DateTimeKind.Utc),

},
    NullableValue = null,
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
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zoneArray2M)],
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
LEFT JOIN public.datetimetimestamp_with_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray2mi_id
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
LEFT JOIN public.datetimetimestamp_with_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((IDateTimeListtimestamp_with_time_zoneArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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

                var models =  ((IDateTimeListtimestamp_with_time_zoneArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zoneArray2M)],
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
LEFT JOIN public.datetimetimestamp_with_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray2mi_id
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
LEFT JOIN public.datetimetimestamp_with_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((IDateTimeListtimestamp_with_time_zoneArray)this).DynQuerySelectModel(connection,  query, 0);
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
                var models =  ((IDateTimeListtimestamp_with_time_zoneArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zoneArray2M)],
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
LEFT JOIN public.datetimetimestamp_with_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_with_time_zonearray2m m
LEFT JOIN public.datetimetimestamp_with_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray2mi_id
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
LEFT JOIN public.datetimetimestamp_with_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray2mi_id
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
                        Assert.That(models, Has.Count.EqualTo(15));
FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[15], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[16], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[17], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[18], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[19], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[20], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[21], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[22], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[23], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[24], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[25], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[26], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[12],_testData[27], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[13],_testData[28], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[22], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[23], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[24], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[25], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[26], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[27], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[28], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[29], false);
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
LEFT JOIN public.datetimetimestamp_with_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_with_time_zonearray2m m
LEFT JOIN public.datetimetimestamp_with_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray2mi_id
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
LEFT JOIN public.datetimetimestamp_with_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray2mi_id
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
                        Assert.That(models, Has.Count.EqualTo(17));
FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[13], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[14], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[15], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[16], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[17], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[18], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[19], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[20], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[21], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[22], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[23], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[24], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[12],_testData[25], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[13],_testData[26], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[14],_testData[27], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[15],_testData[28], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[20], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[21], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[22], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[23], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[24], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[25], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[26], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[27], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[28], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[29], false);
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

                var models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[1], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[2], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[3], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[4], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[5], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[6], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[7], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[8], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[9], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[10], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[11], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[12], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[12],_testData[13], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[13],_testData[14], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[14],_testData[15], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[15],_testData[16], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[16],_testData[17], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[17],_testData[18], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[18],_testData[19], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[19],_testData[20], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[20],_testData[21], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[21],_testData[22], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[22],_testData[23], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[23],_testData[24], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[24],_testData[25], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[25],_testData[26], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[26],_testData[27], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[27],_testData[28], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[26], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[27], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[28], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[29], false);
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

                var models =  ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[7], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[8], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[9], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[10], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[11], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[12], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[13], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[14], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[15], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[16], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[17], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[18], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[12],_testData[19], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[13],_testData[20], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[14],_testData[21], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[15],_testData[22], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[16],_testData[23], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[17],_testData[24], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[18],_testData[25], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[19],_testData[26], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[20],_testData[27], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[21],_testData[28], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[7], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[8], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[9], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[10], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[11], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[12], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[13], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[14], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[15], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[16], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[17], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[18], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[12],_testData[19], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[13],_testData[20], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[14],_testData[21], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[15],_testData[22], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[16],_testData[23], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[17],_testData[24], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[18],_testData[25], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[19],_testData[26], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[20],_testData[27], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[21],_testData[28], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zoneArray2M)],
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
LEFT JOIN public.datetimetimestamp_with_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
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
LEFT JOIN public.datetimetimestamp_with_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray2mi_id
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
LEFT JOIN public.datetimetimestamp_with_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 9, query1, 19, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[1], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[2], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[3], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[4], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[5], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[6], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[7], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[8], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[9], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[10], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[11], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[12], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[12],_testData[13], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[13],_testData[14], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[14],_testData[15], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[15],_testData[16], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[16],_testData[17], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[17],_testData[18], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[18],_testData[19], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[19],_testData[20], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[20],_testData[21], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[21],_testData[22], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[22],_testData[23], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[23],_testData[24], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[24],_testData[25], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[25],_testData[26], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[26],_testData[27], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[27],_testData[28], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[3], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[4], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[5], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[6], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[7], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[8], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[9], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[10], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[11], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[12], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[13], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[14], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[12],_testData[15], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[13],_testData[16], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[14],_testData[17], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[15],_testData[18], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[16],_testData[19], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[17],_testData[20], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[18],_testData[21], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[19],_testData[22], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[20],_testData[23], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[21],_testData[24], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[22],_testData[25], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[23],_testData[26], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[24],_testData[27], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[25],_testData[28], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[26],_testData[29], false);
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
LEFT JOIN public.datetimetimestamp_with_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
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
LEFT JOIN public.datetimetimestamp_with_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray2mi_id
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
LEFT JOIN public.datetimetimestamp_with_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionDynQuerySelectModelBatch(connection, 130, query1, 107, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[26], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[27], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[28], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[20], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[21], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[22], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[23], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[24], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[25], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[26], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[27], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[28], false);FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[29], false);
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
                var models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionSelectModelAsync(connection, 0);
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
                foreach(var batchResult in await ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionSelectModelBatchAsync(connection, 54, 132))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[12], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[13], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[14], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[15], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[16], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[17], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[18], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[19], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[20], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[21], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[22], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[23], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[12],_testData[24], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[13],_testData[25], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[14],_testData[26], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[15],_testData[27], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[16],_testData[28], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[27], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[28], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[29], false);
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
                var models =  ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionSelectModel(connection, 0);
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
                foreach(var batchResult in  ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionSelectModelBatch(connection, 117, 90))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[22], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[23], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[24], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[25], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[26], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[27], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[28], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[29], false);
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
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IDateTimeListtimestamp_with_time_zoneArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDateTimeListtimestamp_with_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 89);
                var models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));
DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[17], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[18], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[19], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[20], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[21], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[22], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[23], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[24], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[25], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[26], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[27], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[28], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[12],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateTimeListtimestamp_with_time_zoneArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateTimeListtimestamp_with_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 54);
                var models =  ((IDateTimeListtimestamp_with_time_zoneArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));
DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[12], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[13], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[14], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[15], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[16], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[17], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[18], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[19], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[20], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[21], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[22], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[23], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[12],_testData[24], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[13],_testData[25], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[14],_testData[26], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[15],_testData[27], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[16],_testData[28], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[17],_testData[29], false);
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

