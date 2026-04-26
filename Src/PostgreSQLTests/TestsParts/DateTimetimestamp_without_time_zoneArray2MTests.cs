

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
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2018, month: 10, day: 8, hour: 12, minute: 42, second: 12, millisecond: 662, kind: DateTimeKind.Local),

new DateTime(year: 1978, month: 10, day: 12, hour: 12, minute: 3, second: 49, millisecond: 296, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 13, hour: 4, minute: 27, second: 35, millisecond: 625, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 1, hour: 20, minute: 9, second: 34, millisecond: 475, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1956, month: 10, day: 1, hour: 11, minute: 12, second: 14, millisecond: 858, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 1, hour: 17, minute: 32, second: 23, millisecond: 246, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 11, hour: 9, minute: 31, second: 31, millisecond: 335, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 19, hour: 10, minute: 31, second: 25, millisecond: 619, kind: DateTimeKind.Local),

new DateTime(year: 1921, month: 10, day: 12, hour: 20, minute: 12, second: 13, millisecond: 647, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 16, hour: 10, minute: 26, second: 5, millisecond: 533, kind: DateTimeKind.Local),

new DateTime(year: 2007, month: 10, day: 5, hour: 19, minute: 41, second: 1, millisecond: 693, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1956, month: 10, day: 11, hour: 18, minute: 3, second: 12, millisecond: 42, kind: DateTimeKind.Local),

new DateTime(year: 1987, month: 10, day: 6, hour: 5, minute: 18, second: 5, millisecond: 710, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 1, hour: 19, minute: 51, second: 54, millisecond: 77, kind: DateTimeKind.Local),

new DateTime(year: 1933, month: 10, day: 5, hour: 22, minute: 37, second: 50, millisecond: 23, kind: DateTimeKind.Local),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1958, month: 10, day: 6, hour: 22, minute: 14, second: 4, millisecond: 689, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 13, hour: 13, minute: 11, second: 50, millisecond: 392, kind: DateTimeKind.Local),

new DateTime(year: 2004, month: 10, day: 5, hour: 8, minute: 31, second: 41, millisecond: 938, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 12, hour: 12, minute: 13, second: 7, millisecond: 169, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1997, month: 10, day: 11, hour: 11, minute: 53, second: 49, millisecond: 537, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 16, hour: 8, minute: 41, second: 48, millisecond: 544, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 6, hour: 2, minute: 3, second: 25, millisecond: 242, kind: DateTimeKind.Local),

new DateTime(year: 1964, month: 10, day: 13, hour: 21, minute: 34, second: 39, millisecond: 91, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1924, month: 10, day: 10, hour: 16, minute: 30, second: 28, millisecond: 855, kind: DateTimeKind.Local),

new DateTime(year: 1957, month: 10, day: 4, hour: 11, minute: 52, second: 27, millisecond: 125, kind: DateTimeKind.Local),

new DateTime(year: 1937, month: 10, day: 8, hour: 20, minute: 49, second: 19, millisecond: 27, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1954, month: 10, day: 16, hour: 7, minute: 19, second: 48, millisecond: 979, kind: DateTimeKind.Local),

new DateTime(year: 1934, month: 10, day: 9, hour: 17, minute: 56, second: 21, millisecond: 764, kind: DateTimeKind.Local),

new DateTime(year: 1917, month: 10, day: 18, hour: 16, minute: 32, second: 46, millisecond: 470, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1979, month: 10, day: 19, hour: 19, minute: 18, second: 52, millisecond: 153, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 12, hour: 7, minute: 15, second: 20, millisecond: 315, kind: DateTimeKind.Local),

new DateTime(year: 1984, month: 10, day: 2, hour: 4, minute: 58, second: 27, millisecond: 455, kind: DateTimeKind.Local),

new DateTime(year: 1965, month: 10, day: 17, hour: 3, minute: 24, second: 37, millisecond: 503, kind: DateTimeKind.Local),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1951, month: 10, day: 1, hour: 19, minute: 13, second: 42, millisecond: 503, kind: DateTimeKind.Local),

new DateTime(year: 2003, month: 10, day: 7, hour: 15, minute: 19, second: 9, millisecond: 434, kind: DateTimeKind.Local),

new DateTime(year: 2016, month: 10, day: 5, hour: 15, minute: 5, second: 18, millisecond: 967, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1964, month: 10, day: 10, hour: 3, minute: 40, second: 10, millisecond: 101, kind: DateTimeKind.Local),

new DateTime(year: 1952, month: 10, day: 15, hour: 19, minute: 34, second: 11, millisecond: 825, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 11, hour: 2, minute: 36, second: 10, millisecond: 678, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1943, month: 10, day: 16, hour: 14, minute: 6, second: 55, millisecond: 446, kind: DateTimeKind.Local),

new DateTime(year: 2017, month: 10, day: 3, hour: 19, minute: 51, second: 19, millisecond: 729, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 9, hour: 11, minute: 11, second: 47, millisecond: 80, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 3, hour: 20, minute: 28, second: 39, millisecond: 83, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1936, month: 10, day: 5, hour: 17, minute: 18, second: 18, millisecond: 261, kind: DateTimeKind.Local),

new DateTime(year: 1991, month: 10, day: 16, hour: 17, minute: 44, second: 37, millisecond: 138, kind: DateTimeKind.Local),

new DateTime(year: 1931, month: 10, day: 19, hour: 22, minute: 16, second: 47, millisecond: 430, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1952, month: 10, day: 16, hour: 9, minute: 11, second: 36, millisecond: 579, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 14, hour: 16, minute: 7, second: 52, millisecond: 412, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 4, hour: 19, minute: 35, second: 7, millisecond: 332, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2017, month: 10, day: 12, hour: 8, minute: 33, second: 17, millisecond: 57, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 19, hour: 8, minute: 6, second: 8, millisecond: 248, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 11, hour: 1, minute: 57, second: 58, millisecond: 982, kind: DateTimeKind.Local),

new DateTime(year: 1960, month: 10, day: 3, hour: 15, minute: 45, second: 41, millisecond: 626, kind: DateTimeKind.Local),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2006, month: 10, day: 14, hour: 17, minute: 58, second: 2, millisecond: 342, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 3, hour: 6, minute: 23, second: 14, millisecond: 2, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 17, hour: 11, minute: 7, second: 27, millisecond: 238, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1990, month: 10, day: 7, hour: 2, minute: 43, second: 21, millisecond: 9, kind: DateTimeKind.Local),

new DateTime(year: 1918, month: 10, day: 4, hour: 19, minute: 28, second: 41, millisecond: 432, kind: DateTimeKind.Local),

new DateTime(year: 1940, month: 10, day: 6, hour: 9, minute: 52, second: 27, millisecond: 304, kind: DateTimeKind.Local),

new DateTime(year: 1930, month: 10, day: 5, hour: 16, minute: 44, second: 8, millisecond: 15, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1996, month: 10, day: 2, hour: 6, minute: 17, second: 3, millisecond: 777, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 15, hour: 14, minute: 14, second: 26, millisecond: 147, kind: DateTimeKind.Local),

new DateTime(year: 2011, month: 10, day: 11, hour: 14, minute: 52, second: 21, millisecond: 216, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2003, month: 10, day: 17, hour: 4, minute: 10, second: 23, millisecond: 941, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 12, hour: 14, minute: 50, second: 36, millisecond: 95, kind: DateTimeKind.Local),

new DateTime(year: 1918, month: 10, day: 9, hour: 15, minute: 52, second: 49, millisecond: 383, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1978, month: 10, day: 17, hour: 2, minute: 55, second: 5, millisecond: 26, kind: DateTimeKind.Local),

new DateTime(year: 1957, month: 10, day: 1, hour: 15, minute: 39, second: 25, millisecond: 60, kind: DateTimeKind.Local),

new DateTime(year: 1974, month: 10, day: 15, hour: 14, minute: 28, second: 10, millisecond: 674, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 12, hour: 11, minute: 21, second: 7, millisecond: 521, kind: DateTimeKind.Local),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1953, month: 10, day: 19, hour: 18, minute: 37, second: 30, millisecond: 698, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 13, hour: 9, minute: 13, second: 14, millisecond: 920, kind: DateTimeKind.Local),

new DateTime(year: 2000, month: 10, day: 15, hour: 3, minute: 49, second: 17, millisecond: 417, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 14, hour: 9, minute: 5, second: 29, millisecond: 104, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1947, month: 10, day: 2, hour: 18, minute: 7, second: 38, millisecond: 254, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 14, hour: 8, minute: 49, second: 21, millisecond: 744, kind: DateTimeKind.Local),

new DateTime(year: 1992, month: 10, day: 17, hour: 15, minute: 25, second: 54, millisecond: 744, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1925, month: 10, day: 14, hour: 1, minute: 17, second: 57, millisecond: 223, kind: DateTimeKind.Local),

new DateTime(year: 1936, month: 10, day: 12, hour: 19, minute: 22, second: 36, millisecond: 131, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 6, hour: 9, minute: 49, second: 39, millisecond: 11, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1952, month: 10, day: 2, hour: 11, minute: 55, second: 35, millisecond: 602, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 15, hour: 1, minute: 18, second: 35, millisecond: 177, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 16, hour: 14, minute: 22, second: 48, millisecond: 522, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2012, month: 10, day: 1, hour: 5, minute: 2, second: 24, millisecond: 225, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 4, hour: 18, minute: 16, second: 9, millisecond: 787, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 2, hour: 11, minute: 56, second: 1, millisecond: 599, kind: DateTimeKind.Local),

new DateTime(year: 1937, month: 10, day: 3, hour: 21, minute: 10, second: 4, millisecond: 461, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1983, month: 10, day: 2, hour: 2, minute: 22, second: 26, millisecond: 789, kind: DateTimeKind.Local),

new DateTime(year: 2019, month: 10, day: 16, hour: 6, minute: 30, second: 35, millisecond: 280, kind: DateTimeKind.Local),

new DateTime(year: 1957, month: 10, day: 7, hour: 3, minute: 50, second: 53, millisecond: 748, kind: DateTimeKind.Local),

},
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1969, month: 10, day: 12, hour: 9, minute: 25, second: 15, millisecond: 152, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 13, hour: 22, minute: 34, second: 24, millisecond: 349, kind: DateTimeKind.Local),

new DateTime(year: 1934, month: 10, day: 7, hour: 22, minute: 45, second: 19, millisecond: 963, kind: DateTimeKind.Local),

new DateTime(year: 1991, month: 10, day: 17, hour: 16, minute: 41, second: 58, millisecond: 678, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1998, month: 10, day: 9, hour: 3, minute: 12, second: 50, millisecond: 362, kind: DateTimeKind.Local),

new DateTime(year: 1938, month: 10, day: 19, hour: 9, minute: 12, second: 30, millisecond: 285, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 10, hour: 20, minute: 24, second: 51, millisecond: 931, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 15, hour: 3, minute: 7, second: 12, millisecond: 160, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1921, month: 10, day: 18, hour: 19, minute: 38, second: 38, millisecond: 327, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 3, hour: 15, minute: 13, second: 43, millisecond: 523, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 14, hour: 19, minute: 53, second: 27, millisecond: 847, kind: DateTimeKind.Local),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1975, month: 10, day: 15, hour: 11, minute: 39, second: 54, millisecond: 135, kind: DateTimeKind.Local),

new DateTime(year: 2004, month: 10, day: 9, hour: 2, minute: 32, second: 45, millisecond: 992, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 18, hour: 1, minute: 14, second: 17, millisecond: 322, kind: DateTimeKind.Local),

new DateTime(year: 2008, month: 10, day: 14, hour: 6, minute: 31, second: 2, millisecond: 109, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1933, month: 10, day: 19, hour: 11, minute: 42, second: 35, millisecond: 993, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 10, hour: 15, minute: 26, second: 18, millisecond: 77, kind: DateTimeKind.Local),

new DateTime(year: 1967, month: 10, day: 10, hour: 8, minute: 29, second: 32, millisecond: 172, kind: DateTimeKind.Local),

new DateTime(year: 1965, month: 10, day: 10, hour: 18, minute: 30, second: 44, millisecond: 329, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1946, month: 10, day: 11, hour: 2, minute: 24, second: 22, millisecond: 385, kind: DateTimeKind.Local),

new DateTime(year: 1941, month: 10, day: 16, hour: 15, minute: 4, second: 3, millisecond: 118, kind: DateTimeKind.Local),

new DateTime(year: 1938, month: 10, day: 13, hour: 21, minute: 45, second: 4, millisecond: 129, kind: DateTimeKind.Local),

new DateTime(year: 1930, month: 10, day: 14, hour: 9, minute: 34, second: 47, millisecond: 48, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1931, month: 10, day: 9, hour: 8, minute: 57, second: 23, millisecond: 761, kind: DateTimeKind.Local),

new DateTime(year: 1927, month: 10, day: 19, hour: 20, minute: 58, second: 9, millisecond: 725, kind: DateTimeKind.Local),

new DateTime(year: 1983, month: 10, day: 15, hour: 2, minute: 37, second: 2, millisecond: 556, kind: DateTimeKind.Local),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1977, month: 10, day: 17, hour: 9, minute: 41, second: 43, millisecond: 955, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 17, hour: 7, minute: 17, second: 7, millisecond: 698, kind: DateTimeKind.Local),

new DateTime(year: 1927, month: 10, day: 10, hour: 21, minute: 56, second: 12, millisecond: 263, kind: DateTimeKind.Local),

new DateTime(year: 2012, month: 10, day: 5, hour: 3, minute: 18, second: 16, millisecond: 192, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1926, month: 10, day: 6, hour: 9, minute: 56, second: 46, millisecond: 845, kind: DateTimeKind.Local),

new DateTime(year: 1942, month: 10, day: 18, hour: 19, minute: 25, second: 23, millisecond: 185, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 2, hour: 4, minute: 29, second: 39, millisecond: 834, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1938, month: 10, day: 7, hour: 11, minute: 13, second: 17, millisecond: 927, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 5, hour: 2, minute: 57, second: 17, millisecond: 720, kind: DateTimeKind.Local),

new DateTime(year: 1941, month: 10, day: 5, hour: 5, minute: 45, second: 20, millisecond: 11, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1956, month: 10, day: 12, hour: 4, minute: 44, second: 39, millisecond: 326, kind: DateTimeKind.Local),

new DateTime(year: 1963, month: 10, day: 2, hour: 10, minute: 40, second: 4, millisecond: 396, kind: DateTimeKind.Local),

new DateTime(year: 1941, month: 10, day: 13, hour: 21, minute: 42, second: 42, millisecond: 672, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1933, month: 10, day: 6, hour: 22, minute: 22, second: 53, millisecond: 526, kind: DateTimeKind.Local),

new DateTime(year: 2008, month: 10, day: 18, hour: 2, minute: 51, second: 13, millisecond: 681, kind: DateTimeKind.Local),

new DateTime(year: 1924, month: 10, day: 16, hour: 11, minute: 12, second: 15, millisecond: 950, kind: DateTimeKind.Local),

new DateTime(year: 1918, month: 10, day: 10, hour: 8, minute: 18, second: 54, millisecond: 950, kind: DateTimeKind.Local),

},
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1993, month: 10, day: 15, hour: 1, minute: 18, second: 12, millisecond: 393, kind: DateTimeKind.Local),

new DateTime(year: 1926, month: 10, day: 3, hour: 22, minute: 3, second: 3, millisecond: 307, kind: DateTimeKind.Local),

new DateTime(year: 1934, month: 10, day: 12, hour: 6, minute: 39, second: 18, millisecond: 659, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1994, month: 10, day: 5, hour: 7, minute: 55, second: 11, millisecond: 788, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 12, hour: 19, minute: 33, second: 21, millisecond: 821, kind: DateTimeKind.Local),

new DateTime(year: 1920, month: 10, day: 6, hour: 22, minute: 37, second: 21, millisecond: 632, kind: DateTimeKind.Local),

new DateTime(year: 1923, month: 10, day: 19, hour: 7, minute: 45, second: 8, millisecond: 286, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2008, month: 10, day: 9, hour: 14, minute: 6, second: 2, millisecond: 611, kind: DateTimeKind.Local),

new DateTime(year: 1929, month: 10, day: 12, hour: 11, minute: 15, second: 24, millisecond: 475, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 7, hour: 22, minute: 32, second: 23, millisecond: 926, kind: DateTimeKind.Local),

new DateTime(year: 1975, month: 10, day: 8, hour: 4, minute: 8, second: 18, millisecond: 493, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1945, month: 10, day: 17, hour: 22, minute: 44, second: 20, millisecond: 347, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 6, hour: 4, minute: 51, second: 46, millisecond: 816, kind: DateTimeKind.Local),

new DateTime(year: 1931, month: 10, day: 8, hour: 15, minute: 29, second: 1, millisecond: 266, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 1, hour: 21, minute: 43, second: 30, millisecond: 141, kind: DateTimeKind.Local),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1919, month: 10, day: 5, hour: 10, minute: 30, second: 48, millisecond: 128, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 11, hour: 16, minute: 7, second: 26, millisecond: 251, kind: DateTimeKind.Local),

new DateTime(year: 1971, month: 10, day: 15, hour: 11, minute: 6, second: 15, millisecond: 575, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 15, hour: 14, minute: 30, second: 46, millisecond: 80, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1973, month: 10, day: 7, hour: 6, minute: 36, second: 2, millisecond: 452, kind: DateTimeKind.Local),

new DateTime(year: 1986, month: 10, day: 7, hour: 5, minute: 50, second: 42, millisecond: 322, kind: DateTimeKind.Local),

new DateTime(year: 1964, month: 10, day: 6, hour: 19, minute: 1, second: 51, millisecond: 748, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1986, month: 10, day: 17, hour: 21, minute: 16, second: 34, millisecond: 124, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 16, hour: 20, minute: 27, second: 22, millisecond: 165, kind: DateTimeKind.Local),

new DateTime(year: 1977, month: 10, day: 11, hour: 16, minute: 1, second: 12, millisecond: 129, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1962, month: 10, day: 7, hour: 9, minute: 27, second: 34, millisecond: 210, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 7, hour: 2, minute: 16, second: 10, millisecond: 174, kind: DateTimeKind.Local),

new DateTime(year: 2012, month: 10, day: 7, hour: 21, minute: 17, second: 51, millisecond: 831, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 16, hour: 16, minute: 31, second: 22, millisecond: 773, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1957, month: 10, day: 9, hour: 14, minute: 27, second: 29, millisecond: 805, kind: DateTimeKind.Local),

new DateTime(year: 2013, month: 10, day: 18, hour: 15, minute: 57, second: 31, millisecond: 560, kind: DateTimeKind.Local),

new DateTime(year: 1956, month: 10, day: 6, hour: 20, minute: 9, second: 14, millisecond: 100, kind: DateTimeKind.Local),

},
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1961, month: 10, day: 6, hour: 13, minute: 58, second: 2, millisecond: 340, kind: DateTimeKind.Local),

new DateTime(year: 1952, month: 10, day: 19, hour: 13, minute: 52, second: 17, millisecond: 420, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 18, hour: 7, minute: 11, second: 44, millisecond: 629, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1955, month: 10, day: 18, hour: 10, minute: 30, second: 15, millisecond: 697, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 14, hour: 20, minute: 4, second: 52, millisecond: 848, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 14, hour: 13, minute: 37, second: 9, millisecond: 634, kind: DateTimeKind.Local),

new DateTime(year: 1929, month: 10, day: 1, hour: 16, minute: 42, second: 32, millisecond: 118, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2003, month: 10, day: 10, hour: 14, minute: 24, second: 32, millisecond: 431, kind: DateTimeKind.Local),

new DateTime(year: 1985, month: 10, day: 8, hour: 3, minute: 5, second: 21, millisecond: 837, kind: DateTimeKind.Local),

new DateTime(year: 1957, month: 10, day: 6, hour: 4, minute: 41, second: 49, millisecond: 668, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1990, month: 10, day: 7, hour: 6, minute: 2, second: 8, millisecond: 707, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 16, hour: 16, minute: 51, second: 28, millisecond: 120, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 8, hour: 20, minute: 43, second: 15, millisecond: 868, kind: DateTimeKind.Local),

new DateTime(year: 1975, month: 10, day: 18, hour: 11, minute: 25, second: 53, millisecond: 606, kind: DateTimeKind.Local),

},
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1985, month: 10, day: 3, hour: 7, minute: 55, second: 33, millisecond: 643, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 2, hour: 13, minute: 43, second: 45, millisecond: 53, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 5, hour: 18, minute: 37, second: 52, millisecond: 680, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1960, month: 10, day: 13, hour: 18, minute: 56, second: 16, millisecond: 845, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 3, hour: 2, minute: 25, second: 57, millisecond: 731, kind: DateTimeKind.Local),

new DateTime(year: 1933, month: 10, day: 3, hour: 1, minute: 35, second: 2, millisecond: 332, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 16, hour: 11, minute: 40, second: 16, millisecond: 818, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1982, month: 10, day: 15, hour: 14, minute: 24, second: 46, millisecond: 263, kind: DateTimeKind.Local),

new DateTime(year: 2003, month: 10, day: 9, hour: 10, minute: 10, second: 38, millisecond: 291, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 2, hour: 7, minute: 55, second: 27, millisecond: 728, kind: DateTimeKind.Local),

new DateTime(year: 1930, month: 10, day: 12, hour: 10, minute: 48, second: 18, millisecond: 778, kind: DateTimeKind.Local),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1973, month: 10, day: 8, hour: 10, minute: 49, second: 7, millisecond: 911, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 15, hour: 9, minute: 43, second: 10, millisecond: 906, kind: DateTimeKind.Local),

new DateTime(year: 1991, month: 10, day: 15, hour: 3, minute: 4, second: 57, millisecond: 694, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1997, month: 10, day: 1, hour: 3, minute: 29, second: 18, millisecond: 126, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 10, hour: 9, minute: 13, second: 11, millisecond: 438, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 2, hour: 7, minute: 2, second: 37, millisecond: 443, kind: DateTimeKind.Local),

new DateTime(year: 1929, month: 10, day: 18, hour: 3, minute: 56, second: 53, millisecond: 145, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1968, month: 10, day: 18, hour: 14, minute: 34, second: 16, millisecond: 358, kind: DateTimeKind.Local),

new DateTime(year: 1944, month: 10, day: 18, hour: 4, minute: 12, second: 46, millisecond: 890, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 9, hour: 2, minute: 50, second: 30, millisecond: 31, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1987, month: 10, day: 16, hour: 18, minute: 1, second: 28, millisecond: 825, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 3, hour: 14, minute: 29, second: 40, millisecond: 830, kind: DateTimeKind.Local),

new DateTime(year: 1952, month: 10, day: 14, hour: 13, minute: 46, second: 13, millisecond: 412, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 6, hour: 22, minute: 22, second: 25, millisecond: 464, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1960, month: 10, day: 5, hour: 4, minute: 47, second: 6, millisecond: 168, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 15, hour: 9, minute: 31, second: 1, millisecond: 316, kind: DateTimeKind.Local),

new DateTime(year: 1971, month: 10, day: 13, hour: 2, minute: 47, second: 15, millisecond: 621, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 1, hour: 16, minute: 50, second: 16, millisecond: 940, kind: DateTimeKind.Local),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1961, month: 10, day: 4, hour: 14, minute: 25, second: 52, millisecond: 399, kind: DateTimeKind.Local),

new DateTime(year: 2009, month: 10, day: 18, hour: 12, minute: 21, second: 11, millisecond: 493, kind: DateTimeKind.Local),

new DateTime(year: 1917, month: 10, day: 10, hour: 1, minute: 18, second: 29, millisecond: 373, kind: DateTimeKind.Local),

new DateTime(year: 1999, month: 10, day: 16, hour: 9, minute: 55, second: 31, millisecond: 652, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1937, month: 10, day: 16, hour: 3, minute: 30, second: 5, millisecond: 169, kind: DateTimeKind.Local),

new DateTime(year: 1938, month: 10, day: 17, hour: 10, minute: 20, second: 54, millisecond: 272, kind: DateTimeKind.Local),

new DateTime(year: 1918, month: 10, day: 15, hour: 20, minute: 46, second: 57, millisecond: 667, kind: DateTimeKind.Local),

new DateTime(year: 1934, month: 10, day: 19, hour: 1, minute: 6, second: 26, millisecond: 784, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2016, month: 10, day: 3, hour: 22, minute: 26, second: 44, millisecond: 649, kind: DateTimeKind.Local),

new DateTime(year: 1929, month: 10, day: 4, hour: 10, minute: 40, second: 53, millisecond: 613, kind: DateTimeKind.Local),

new DateTime(year: 1923, month: 10, day: 15, hour: 16, minute: 54, second: 20, millisecond: 554, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 171,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1919, month: 10, day: 4, hour: 21, minute: 5, second: 5, millisecond: 771, kind: DateTimeKind.Local),

new DateTime(year: 1920, month: 10, day: 3, hour: 17, minute: 47, second: 49, millisecond: 521, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 12, hour: 15, minute: 12, second: 9, millisecond: 949, kind: DateTimeKind.Local),

new DateTime(year: 1927, month: 10, day: 11, hour: 19, minute: 3, second: 8, millisecond: 810, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2015, month: 10, day: 2, hour: 3, minute: 46, second: 57, millisecond: 260, kind: DateTimeKind.Local),

new DateTime(year: 1960, month: 10, day: 17, hour: 2, minute: 4, second: 47, millisecond: 266, kind: DateTimeKind.Local),

new DateTime(year: 1930, month: 10, day: 17, hour: 10, minute: 2, second: 53, millisecond: 865, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1970, month: 10, day: 10, hour: 15, minute: 4, second: 44, millisecond: 791, kind: DateTimeKind.Local),

new DateTime(year: 1956, month: 10, day: 15, hour: 10, minute: 21, second: 2, millisecond: 146, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 4, hour: 3, minute: 20, second: 42, millisecond: 900, kind: DateTimeKind.Local),

new DateTime(year: 1923, month: 10, day: 19, hour: 11, minute: 17, second: 33, millisecond: 167, kind: DateTimeKind.Local),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1981, month: 10, day: 1, hour: 2, minute: 41, second: 43, millisecond: 709, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 14, hour: 19, minute: 10, second: 58, millisecond: 582, kind: DateTimeKind.Local),

new DateTime(year: 2000, month: 10, day: 7, hour: 19, minute: 58, second: 47, millisecond: 221, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 177,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1951, month: 10, day: 7, hour: 13, minute: 28, second: 56, millisecond: 96, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 16, hour: 7, minute: 7, second: 45, millisecond: 242, kind: DateTimeKind.Local),

new DateTime(year: 1921, month: 10, day: 11, hour: 2, minute: 32, second: 10, millisecond: 176, kind: DateTimeKind.Local),

new DateTime(year: 1935, month: 10, day: 12, hour: 19, minute: 31, second: 52, millisecond: 314, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1946, month: 10, day: 8, hour: 14, minute: 28, second: 33, millisecond: 560, kind: DateTimeKind.Local),

new DateTime(year: 1992, month: 10, day: 18, hour: 4, minute: 18, second: 46, millisecond: 510, kind: DateTimeKind.Local),

new DateTime(year: 1992, month: 10, day: 17, hour: 8, minute: 13, second: 23, millisecond: 917, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 186,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1936, month: 10, day: 9, hour: 6, minute: 10, second: 39, millisecond: 184, kind: DateTimeKind.Local),

new DateTime(year: 1992, month: 10, day: 8, hour: 11, minute: 49, second: 54, millisecond: 897, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 6, hour: 8, minute: 7, second: 37, millisecond: 8, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1962, month: 10, day: 16, hour: 7, minute: 52, second: 30, millisecond: 649, kind: DateTimeKind.Local),

new DateTime(year: 1986, month: 10, day: 17, hour: 19, minute: 8, second: 40, millisecond: 357, kind: DateTimeKind.Local),

new DateTime(year: 1923, month: 10, day: 5, hour: 2, minute: 56, second: 15, millisecond: 495, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2002, month: 10, day: 9, hour: 2, minute: 39, second: 14, millisecond: 860, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 6, hour: 6, minute: 26, second: 24, millisecond: 273, kind: DateTimeKind.Local),

new DateTime(year: 1988, month: 10, day: 14, hour: 11, minute: 21, second: 46, millisecond: 19, kind: DateTimeKind.Local),

new DateTime(year: 2000, month: 10, day: 12, hour: 10, minute: 20, second: 28, millisecond: 123, kind: DateTimeKind.Local),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1980, month: 10, day: 1, hour: 6, minute: 52, second: 16, millisecond: 450, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 14, hour: 7, minute: 45, second: 39, millisecond: 743, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 3, hour: 17, minute: 51, second: 50, millisecond: 387, kind: DateTimeKind.Local),

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
                parametr1.Value = 71;
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
                        Assert.That(models, Has.Count.EqualTo(18));
FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[12], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[13], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[14], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[15], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[16], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[17], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[18], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[19], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[20], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[21], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[22], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[23], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[24], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[25], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[26], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[27], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[28], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[8], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[9], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[10], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[11], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[12], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[13], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[14], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[15], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[16], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[17], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[18], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[19], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[20], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[21], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[22], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[23], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[24], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[17],_testData[25], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[18],_testData[26], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[19],_testData[27], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[20],_testData[28], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[21],_testData[29], false);
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
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 171;
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
                        Assert.That(models, Has.Count.EqualTo(15));
FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[15], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[16], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[17], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[18], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[19], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[20], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[21], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[22], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[23], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[24], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[25], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[26], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[27], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[28], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[28], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[29], false);
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[8], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[9], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[10], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[11], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[12], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[13], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[14], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[15], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[16], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[17], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[18], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[19], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[20], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[21], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[22], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[23], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[24], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[17],_testData[25], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[18],_testData[26], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[19],_testData[27], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[20],_testData[28], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[17], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[18], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[19], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[20], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[21], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[22], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[23], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[24], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[25], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[26], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[27], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[28], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[29], false);
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
                parametr1.Value = 143;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 149;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[24], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[25], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[26], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[27], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[28], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[25], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[26], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[27], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[28], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[29], false);
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
                foreach(var batchResult in await ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 80, query1, 171, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[13], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[14], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[15], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[16], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[17], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[18], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[19], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[20], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[21], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[22], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[23], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[24], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[25], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[26], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[27], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[28], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[28], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[29], false);
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
                foreach(var batchResult in  ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatch(connection, 163, query1, 11, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[27], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[28], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[29], false);
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
                foreach(var batchResult in await ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSelectModelBatchAsync(connection, 89, 51))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[14], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[15], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[16], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[17], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[18], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[19], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[20], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[21], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[22], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[23], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[24], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[25], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[26], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[27], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[28], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[29], false);
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
                foreach(var batchResult in  ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSelectModelBatch(connection, 119, 112))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[19], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[20], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[21], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[22], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[23], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[24], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[25], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[26], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[27], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[28], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[18], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[19], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[20], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[21], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[22], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[23], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[24], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[25], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[26], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[27], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[28], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[29], false);
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
                ((IDateTimeListtimestamp_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 90);
                var models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(15));
DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[15], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[16], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[17], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[18], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[19], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[20], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[21], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[22], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[23], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[24], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[25], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[26], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[27], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[28], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateTimeListtimestamp_without_time_zoneArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateTimeListtimestamp_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 163);
                var models =  ((IDateTimeListtimestamp_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(3));
DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[27], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[28], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[29], false);
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

