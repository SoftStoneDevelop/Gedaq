

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
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2019, month: 10, day: 17, hour: 17, minute: 53, second: 7, millisecond: 848, kind: DateTimeKind.Local),

new DateTime(year: 2000, month: 10, day: 10, hour: 15, minute: 8, second: 53, millisecond: 937, kind: DateTimeKind.Local),

new DateTime(year: 2017, month: 10, day: 13, hour: 18, minute: 1, second: 58, millisecond: 597, kind: DateTimeKind.Local),

new DateTime(year: 1937, month: 10, day: 6, hour: 1, minute: 58, second: 41, millisecond: 930, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1946, month: 10, day: 12, hour: 15, minute: 12, second: 26, millisecond: 853, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 5, hour: 20, minute: 32, second: 28, millisecond: 961, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 19, hour: 22, minute: 4, second: 41, millisecond: 837, kind: DateTimeKind.Local),

new DateTime(year: 1952, month: 10, day: 14, hour: 7, minute: 6, second: 52, millisecond: 524, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1969, month: 10, day: 15, hour: 7, minute: 41, second: 1, millisecond: 698, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 4, hour: 20, minute: 51, second: 15, millisecond: 51, kind: DateTimeKind.Local),

new DateTime(year: 1923, month: 10, day: 8, hour: 14, minute: 11, second: 17, millisecond: 440, kind: DateTimeKind.Local),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1987, month: 10, day: 11, hour: 2, minute: 46, second: 16, millisecond: 732, kind: DateTimeKind.Local),

new DateTime(year: 1935, month: 10, day: 6, hour: 14, minute: 4, second: 2, millisecond: 210, kind: DateTimeKind.Local),

new DateTime(year: 1978, month: 10, day: 3, hour: 3, minute: 3, second: 40, millisecond: 36, kind: DateTimeKind.Local),

new DateTime(year: 2018, month: 10, day: 9, hour: 8, minute: 51, second: 53, millisecond: 472, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1925, month: 10, day: 1, hour: 8, minute: 15, second: 34, millisecond: 562, kind: DateTimeKind.Local),

new DateTime(year: 1922, month: 10, day: 5, hour: 4, minute: 46, second: 3, millisecond: 906, kind: DateTimeKind.Local),

new DateTime(year: 1967, month: 10, day: 19, hour: 20, minute: 29, second: 37, millisecond: 794, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1989, month: 10, day: 9, hour: 1, minute: 41, second: 6, millisecond: 929, kind: DateTimeKind.Local),

new DateTime(year: 1929, month: 10, day: 19, hour: 13, minute: 45, second: 47, millisecond: 901, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 12, hour: 19, minute: 19, second: 42, millisecond: 34, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1949, month: 10, day: 17, hour: 8, minute: 31, second: 41, millisecond: 170, kind: DateTimeKind.Local),

new DateTime(year: 1977, month: 10, day: 12, hour: 8, minute: 57, second: 2, millisecond: 948, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 8, hour: 15, minute: 48, second: 24, millisecond: 916, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1934, month: 10, day: 2, hour: 19, minute: 37, second: 42, millisecond: 486, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 13, hour: 1, minute: 26, second: 8, millisecond: 224, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 13, hour: 7, minute: 32, second: 3, millisecond: 2, kind: DateTimeKind.Local),

new DateTime(year: 1999, month: 10, day: 5, hour: 12, minute: 6, second: 38, millisecond: 764, kind: DateTimeKind.Local),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1948, month: 10, day: 8, hour: 15, minute: 46, second: 46, millisecond: 37, kind: DateTimeKind.Local),

new DateTime(year: 1964, month: 10, day: 14, hour: 17, minute: 47, second: 40, millisecond: 719, kind: DateTimeKind.Local),

new DateTime(year: 2007, month: 10, day: 1, hour: 10, minute: 38, second: 47, millisecond: 484, kind: DateTimeKind.Local),

new DateTime(year: 1920, month: 10, day: 11, hour: 14, minute: 48, second: 50, millisecond: 608, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2009, month: 10, day: 17, hour: 13, minute: 53, second: 24, millisecond: 977, kind: DateTimeKind.Local),

new DateTime(year: 1957, month: 10, day: 4, hour: 12, minute: 42, second: 50, millisecond: 569, kind: DateTimeKind.Local),

new DateTime(year: 1983, month: 10, day: 2, hour: 17, minute: 4, second: 18, millisecond: 595, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2000, month: 10, day: 15, hour: 20, minute: 7, second: 12, millisecond: 13, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 4, hour: 20, minute: 19, second: 24, millisecond: 786, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 16, hour: 11, minute: 19, second: 8, millisecond: 97, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1965, month: 10, day: 11, hour: 22, minute: 43, second: 1, millisecond: 826, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 6, hour: 10, minute: 37, second: 4, millisecond: 484, kind: DateTimeKind.Local),

new DateTime(year: 1999, month: 10, day: 9, hour: 14, minute: 41, second: 36, millisecond: 645, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 11, hour: 6, minute: 31, second: 52, millisecond: 704, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1986, month: 10, day: 5, hour: 21, minute: 22, second: 29, millisecond: 752, kind: DateTimeKind.Local),

new DateTime(year: 1935, month: 10, day: 14, hour: 15, minute: 26, second: 49, millisecond: 65, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 17, hour: 6, minute: 33, second: 25, millisecond: 917, kind: DateTimeKind.Local),

},
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1925, month: 10, day: 8, hour: 4, minute: 35, second: 22, millisecond: 714, kind: DateTimeKind.Local),

new DateTime(year: 1974, month: 10, day: 7, hour: 6, minute: 38, second: 56, millisecond: 253, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 14, hour: 3, minute: 7, second: 44, millisecond: 982, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1994, month: 10, day: 11, hour: 6, minute: 49, second: 40, millisecond: 714, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 4, hour: 21, minute: 24, second: 34, millisecond: 397, kind: DateTimeKind.Local),

new DateTime(year: 2009, month: 10, day: 12, hour: 2, minute: 44, second: 43, millisecond: 352, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1988, month: 10, day: 2, hour: 18, minute: 32, second: 44, millisecond: 841, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 11, hour: 16, minute: 1, second: 53, millisecond: 525, kind: DateTimeKind.Local),

new DateTime(year: 1940, month: 10, day: 3, hour: 6, minute: 43, second: 38, millisecond: 553, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 3, hour: 13, minute: 39, second: 25, millisecond: 527, kind: DateTimeKind.Local),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1941, month: 10, day: 6, hour: 6, minute: 14, second: 58, millisecond: 988, kind: DateTimeKind.Local),

new DateTime(year: 1978, month: 10, day: 1, hour: 3, minute: 37, second: 58, millisecond: 773, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 9, hour: 7, minute: 2, second: 41, millisecond: 103, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 6, hour: 12, minute: 19, second: 4, millisecond: 554, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1927, month: 10, day: 17, hour: 5, minute: 29, second: 58, millisecond: 941, kind: DateTimeKind.Local),

new DateTime(year: 1992, month: 10, day: 13, hour: 19, minute: 6, second: 31, millisecond: 322, kind: DateTimeKind.Local),

new DateTime(year: 1960, month: 10, day: 13, hour: 7, minute: 46, second: 19, millisecond: 984, kind: DateTimeKind.Local),

new DateTime(year: 2008, month: 10, day: 12, hour: 18, minute: 38, second: 12, millisecond: 270, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2011, month: 10, day: 14, hour: 3, minute: 20, second: 5, millisecond: 797, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 12, hour: 7, minute: 36, second: 42, millisecond: 441, kind: DateTimeKind.Local),

new DateTime(year: 1966, month: 10, day: 3, hour: 12, minute: 23, second: 58, millisecond: 995, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1920, month: 10, day: 1, hour: 3, minute: 24, second: 57, millisecond: 948, kind: DateTimeKind.Local),

new DateTime(year: 1994, month: 10, day: 16, hour: 22, minute: 25, second: 50, millisecond: 463, kind: DateTimeKind.Local),

new DateTime(year: 2018, month: 10, day: 12, hour: 16, minute: 16, second: 49, millisecond: 450, kind: DateTimeKind.Local),

new DateTime(year: 1957, month: 10, day: 13, hour: 16, minute: 30, second: 3, millisecond: 919, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2015, month: 10, day: 10, hour: 19, minute: 23, second: 30, millisecond: 104, kind: DateTimeKind.Local),

new DateTime(year: 2017, month: 10, day: 10, hour: 8, minute: 13, second: 49, millisecond: 317, kind: DateTimeKind.Local),

new DateTime(year: 1920, month: 10, day: 9, hour: 11, minute: 36, second: 53, millisecond: 944, kind: DateTimeKind.Local),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1939, month: 10, day: 3, hour: 8, minute: 26, second: 3, millisecond: 815, kind: DateTimeKind.Local),

new DateTime(year: 2009, month: 10, day: 2, hour: 14, minute: 7, second: 18, millisecond: 582, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 18, hour: 19, minute: 42, second: 41, millisecond: 854, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 12, hour: 22, minute: 1, second: 52, millisecond: 541, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1946, month: 10, day: 10, hour: 10, minute: 5, second: 24, millisecond: 565, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 6, hour: 13, minute: 53, second: 38, millisecond: 96, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 3, hour: 4, minute: 39, second: 38, millisecond: 696, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1967, month: 10, day: 1, hour: 3, minute: 9, second: 1, millisecond: 688, kind: DateTimeKind.Local),

new DateTime(year: 1991, month: 10, day: 1, hour: 6, minute: 17, second: 18, millisecond: 174, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 2, hour: 16, minute: 37, second: 20, millisecond: 13, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1952, month: 10, day: 12, hour: 5, minute: 40, second: 53, millisecond: 306, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 4, hour: 18, minute: 53, second: 55, millisecond: 393, kind: DateTimeKind.Local),

new DateTime(year: 1936, month: 10, day: 17, hour: 5, minute: 25, second: 32, millisecond: 37, kind: DateTimeKind.Local),

new DateTime(year: 1975, month: 10, day: 13, hour: 9, minute: 35, second: 57, millisecond: 464, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1964, month: 10, day: 11, hour: 12, minute: 58, second: 51, millisecond: 272, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 10, hour: 14, minute: 6, second: 19, millisecond: 69, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 5, hour: 11, minute: 11, second: 30, millisecond: 103, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1967, month: 10, day: 17, hour: 16, minute: 52, second: 36, millisecond: 323, kind: DateTimeKind.Local),

new DateTime(year: 1965, month: 10, day: 2, hour: 14, minute: 36, second: 48, millisecond: 573, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 4, hour: 20, minute: 57, second: 24, millisecond: 175, kind: DateTimeKind.Local),

new DateTime(year: 1944, month: 10, day: 1, hour: 1, minute: 52, second: 51, millisecond: 89, kind: DateTimeKind.Local),

},
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1937, month: 10, day: 16, hour: 2, minute: 37, second: 52, millisecond: 523, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 9, hour: 15, minute: 4, second: 12, millisecond: 648, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 17, hour: 17, minute: 35, second: 45, millisecond: 40, kind: DateTimeKind.Local),

new DateTime(year: 1927, month: 10, day: 4, hour: 3, minute: 49, second: 2, millisecond: 803, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1999, month: 10, day: 1, hour: 12, minute: 15, second: 19, millisecond: 593, kind: DateTimeKind.Local),

new DateTime(year: 1974, month: 10, day: 19, hour: 5, minute: 12, second: 20, millisecond: 305, kind: DateTimeKind.Local),

new DateTime(year: 1956, month: 10, day: 9, hour: 2, minute: 2, second: 55, millisecond: 943, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1999, month: 10, day: 9, hour: 5, minute: 32, second: 24, millisecond: 414, kind: DateTimeKind.Local),

new DateTime(year: 1917, month: 10, day: 19, hour: 7, minute: 47, second: 12, millisecond: 971, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 5, hour: 2, minute: 54, second: 5, millisecond: 573, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1956, month: 10, day: 10, hour: 3, minute: 5, second: 31, millisecond: 789, kind: DateTimeKind.Local),

new DateTime(year: 1937, month: 10, day: 14, hour: 11, minute: 51, second: 25, millisecond: 623, kind: DateTimeKind.Local),

new DateTime(year: 2013, month: 10, day: 3, hour: 9, minute: 3, second: 29, millisecond: 802, kind: DateTimeKind.Local),

new DateTime(year: 1918, month: 10, day: 8, hour: 18, minute: 25, second: 47, millisecond: 797, kind: DateTimeKind.Local),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1964, month: 10, day: 4, hour: 6, minute: 10, second: 54, millisecond: 997, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 2, hour: 22, minute: 41, second: 7, millisecond: 744, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 3, hour: 6, minute: 7, second: 32, millisecond: 65, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1961, month: 10, day: 17, hour: 9, minute: 49, second: 32, millisecond: 92, kind: DateTimeKind.Local),

new DateTime(year: 1960, month: 10, day: 12, hour: 15, minute: 53, second: 12, millisecond: 376, kind: DateTimeKind.Local),

new DateTime(year: 1957, month: 10, day: 13, hour: 9, minute: 47, second: 27, millisecond: 344, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 3, hour: 20, minute: 22, second: 45, millisecond: 541, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1919, month: 10, day: 7, hour: 8, minute: 29, second: 13, millisecond: 284, kind: DateTimeKind.Local),

new DateTime(year: 1935, month: 10, day: 1, hour: 6, minute: 1, second: 6, millisecond: 927, kind: DateTimeKind.Local),

new DateTime(year: 1921, month: 10, day: 19, hour: 14, minute: 11, second: 41, millisecond: 384, kind: DateTimeKind.Local),

new DateTime(year: 2014, month: 10, day: 9, hour: 14, minute: 4, second: 19, millisecond: 186, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1956, month: 10, day: 17, hour: 1, minute: 8, second: 32, millisecond: 595, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 3, hour: 13, minute: 2, second: 24, millisecond: 921, kind: DateTimeKind.Local),

new DateTime(year: 1942, month: 10, day: 11, hour: 4, minute: 52, second: 57, millisecond: 165, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1965, month: 10, day: 19, hour: 10, minute: 51, second: 52, millisecond: 340, kind: DateTimeKind.Local),

new DateTime(year: 1953, month: 10, day: 6, hour: 18, minute: 30, second: 40, millisecond: 536, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 2, hour: 22, minute: 16, second: 52, millisecond: 396, kind: DateTimeKind.Local),

},
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1973, month: 10, day: 11, hour: 15, minute: 30, second: 20, millisecond: 794, kind: DateTimeKind.Local),

new DateTime(year: 2017, month: 10, day: 6, hour: 15, minute: 41, second: 27, millisecond: 204, kind: DateTimeKind.Local),

new DateTime(year: 1966, month: 10, day: 6, hour: 3, minute: 49, second: 15, millisecond: 604, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1967, month: 10, day: 18, hour: 12, minute: 58, second: 29, millisecond: 867, kind: DateTimeKind.Local),

new DateTime(year: 1965, month: 10, day: 11, hour: 5, minute: 33, second: 14, millisecond: 294, kind: DateTimeKind.Local),

new DateTime(year: 1964, month: 10, day: 10, hour: 8, minute: 24, second: 7, millisecond: 157, kind: DateTimeKind.Local),

new DateTime(year: 1975, month: 10, day: 1, hour: 19, minute: 9, second: 45, millisecond: 783, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1924, month: 10, day: 8, hour: 18, minute: 27, second: 51, millisecond: 652, kind: DateTimeKind.Local),

new DateTime(year: 2005, month: 10, day: 7, hour: 1, minute: 42, second: 3, millisecond: 843, kind: DateTimeKind.Local),

new DateTime(year: 1930, month: 10, day: 9, hour: 10, minute: 40, second: 45, millisecond: 194, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2008, month: 10, day: 2, hour: 9, minute: 45, second: 23, millisecond: 694, kind: DateTimeKind.Local),

new DateTime(year: 1936, month: 10, day: 17, hour: 19, minute: 25, second: 31, millisecond: 317, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 5, hour: 12, minute: 27, second: 13, millisecond: 299, kind: DateTimeKind.Local),

new DateTime(year: 1921, month: 10, day: 10, hour: 4, minute: 52, second: 11, millisecond: 995, kind: DateTimeKind.Local),

},
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1927, month: 10, day: 13, hour: 19, minute: 16, second: 23, millisecond: 868, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 8, hour: 18, minute: 46, second: 40, millisecond: 735, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 19, hour: 13, minute: 49, second: 19, millisecond: 570, kind: DateTimeKind.Local),

new DateTime(year: 1918, month: 10, day: 10, hour: 20, minute: 57, second: 24, millisecond: 174, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2013, month: 10, day: 4, hour: 14, minute: 15, second: 13, millisecond: 17, kind: DateTimeKind.Local),

new DateTime(year: 1957, month: 10, day: 8, hour: 22, minute: 30, second: 46, millisecond: 131, kind: DateTimeKind.Local),

new DateTime(year: 1965, month: 10, day: 16, hour: 18, minute: 9, second: 14, millisecond: 45, kind: DateTimeKind.Local),

new DateTime(year: 1975, month: 10, day: 6, hour: 1, minute: 22, second: 19, millisecond: 333, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2012, month: 10, day: 13, hour: 15, minute: 57, second: 27, millisecond: 334, kind: DateTimeKind.Local),

new DateTime(year: 1987, month: 10, day: 1, hour: 13, minute: 26, second: 25, millisecond: 672, kind: DateTimeKind.Local),

new DateTime(year: 2008, month: 10, day: 5, hour: 7, minute: 2, second: 5, millisecond: 124, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 16, hour: 10, minute: 15, second: 29, millisecond: 863, kind: DateTimeKind.Local),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1983, month: 10, day: 8, hour: 21, minute: 27, second: 22, millisecond: 852, kind: DateTimeKind.Local),

new DateTime(year: 2018, month: 10, day: 4, hour: 17, minute: 8, second: 48, millisecond: 844, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 3, hour: 8, minute: 56, second: 58, millisecond: 886, kind: DateTimeKind.Local),

new DateTime(year: 2008, month: 10, day: 10, hour: 14, minute: 9, second: 24, millisecond: 335, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1920, month: 10, day: 1, hour: 20, minute: 54, second: 40, millisecond: 374, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 5, hour: 6, minute: 1, second: 56, millisecond: 964, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 13, hour: 15, minute: 55, second: 32, millisecond: 59, kind: DateTimeKind.Local),

new DateTime(year: 2012, month: 10, day: 1, hour: 12, minute: 39, second: 13, millisecond: 926, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2006, month: 10, day: 15, hour: 14, minute: 57, second: 35, millisecond: 721, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 16, hour: 2, minute: 26, second: 11, millisecond: 307, kind: DateTimeKind.Local),

new DateTime(year: 1936, month: 10, day: 9, hour: 3, minute: 16, second: 19, millisecond: 222, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2009, month: 10, day: 4, hour: 12, minute: 20, second: 2, millisecond: 664, kind: DateTimeKind.Local),

new DateTime(year: 2019, month: 10, day: 11, hour: 16, minute: 12, second: 13, millisecond: 784, kind: DateTimeKind.Local),

new DateTime(year: 1931, month: 10, day: 13, hour: 3, minute: 35, second: 45, millisecond: 313, kind: DateTimeKind.Local),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1967, month: 10, day: 11, hour: 13, minute: 40, second: 57, millisecond: 458, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 11, hour: 4, minute: 29, second: 21, millisecond: 747, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 8, hour: 9, minute: 26, second: 50, millisecond: 550, kind: DateTimeKind.Local),

new DateTime(year: 1986, month: 10, day: 19, hour: 7, minute: 24, second: 4, millisecond: 927, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1969, month: 10, day: 2, hour: 4, minute: 6, second: 4, millisecond: 890, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 5, hour: 6, minute: 19, second: 7, millisecond: 555, kind: DateTimeKind.Local),

new DateTime(year: 1983, month: 10, day: 15, hour: 14, minute: 35, second: 43, millisecond: 535, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1992, month: 10, day: 12, hour: 1, minute: 11, second: 46, millisecond: 908, kind: DateTimeKind.Local),

new DateTime(year: 1983, month: 10, day: 1, hour: 2, minute: 15, second: 46, millisecond: 113, kind: DateTimeKind.Local),

new DateTime(year: 2007, month: 10, day: 6, hour: 5, minute: 49, second: 29, millisecond: 165, kind: DateTimeKind.Local),

new DateTime(year: 1957, month: 10, day: 16, hour: 3, minute: 11, second: 34, millisecond: 273, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1952, month: 10, day: 4, hour: 9, minute: 18, second: 29, millisecond: 86, kind: DateTimeKind.Local),

new DateTime(year: 1922, month: 10, day: 9, hour: 20, minute: 5, second: 18, millisecond: 852, kind: DateTimeKind.Local),

new DateTime(year: 1966, month: 10, day: 4, hour: 4, minute: 53, second: 11, millisecond: 76, kind: DateTimeKind.Local),

new DateTime(year: 1956, month: 10, day: 15, hour: 14, minute: 27, second: 52, millisecond: 642, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1927, month: 10, day: 5, hour: 20, minute: 1, second: 33, millisecond: 956, kind: DateTimeKind.Local),

new DateTime(year: 1957, month: 10, day: 15, hour: 1, minute: 10, second: 5, millisecond: 885, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 15, hour: 15, minute: 30, second: 11, millisecond: 682, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 4, hour: 13, minute: 44, second: 8, millisecond: 415, kind: DateTimeKind.Local),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2009, month: 10, day: 6, hour: 22, minute: 12, second: 11, millisecond: 694, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 12, hour: 19, minute: 38, second: 49, millisecond: 498, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 14, hour: 17, minute: 2, second: 54, millisecond: 591, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1937, month: 10, day: 6, hour: 17, minute: 38, second: 11, millisecond: 165, kind: DateTimeKind.Local),

new DateTime(year: 1974, month: 10, day: 18, hour: 9, minute: 16, second: 53, millisecond: 235, kind: DateTimeKind.Local),

new DateTime(year: 1964, month: 10, day: 14, hour: 13, minute: 27, second: 33, millisecond: 623, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 16, hour: 14, minute: 30, second: 34, millisecond: 836, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1987, month: 10, day: 11, hour: 18, minute: 6, second: 17, millisecond: 462, kind: DateTimeKind.Local),

new DateTime(year: 1926, month: 10, day: 10, hour: 21, minute: 2, second: 21, millisecond: 365, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 15, hour: 15, minute: 20, second: 47, millisecond: 920, kind: DateTimeKind.Local),

new DateTime(year: 1917, month: 10, day: 9, hour: 7, minute: 57, second: 3, millisecond: 464, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1944, month: 10, day: 13, hour: 1, minute: 56, second: 55, millisecond: 124, kind: DateTimeKind.Local),

new DateTime(year: 1984, month: 10, day: 13, hour: 14, minute: 47, second: 17, millisecond: 681, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 14, hour: 1, minute: 34, second: 42, millisecond: 309, kind: DateTimeKind.Local),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2014, month: 10, day: 4, hour: 20, minute: 35, second: 7, millisecond: 355, kind: DateTimeKind.Local),

new DateTime(year: 2003, month: 10, day: 16, hour: 21, minute: 6, second: 27, millisecond: 19, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 12, hour: 21, minute: 27, second: 16, millisecond: 679, kind: DateTimeKind.Local),

new DateTime(year: 1957, month: 10, day: 2, hour: 6, minute: 35, second: 52, millisecond: 708, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1960, month: 10, day: 18, hour: 7, minute: 42, second: 35, millisecond: 345, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 9, hour: 2, minute: 32, second: 34, millisecond: 412, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 12, hour: 3, minute: 45, second: 4, millisecond: 39, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1926, month: 10, day: 19, hour: 19, minute: 55, second: 27, millisecond: 667, kind: DateTimeKind.Local),

new DateTime(year: 1987, month: 10, day: 10, hour: 3, minute: 20, second: 1, millisecond: 577, kind: DateTimeKind.Local),

new DateTime(year: 1923, month: 10, day: 12, hour: 16, minute: 21, second: 25, millisecond: 761, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 9, hour: 2, minute: 10, second: 36, millisecond: 948, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1981, month: 10, day: 6, hour: 7, minute: 43, second: 35, millisecond: 97, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 11, hour: 18, minute: 39, second: 5, millisecond: 383, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 6, hour: 13, minute: 27, second: 37, millisecond: 852, kind: DateTimeKind.Local),

new DateTime(year: 2007, month: 10, day: 3, hour: 1, minute: 3, second: 37, millisecond: 203, kind: DateTimeKind.Local),

},
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 166,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1973, month: 10, day: 2, hour: 2, minute: 30, second: 10, millisecond: 510, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 18, hour: 5, minute: 3, second: 49, millisecond: 47, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 9, hour: 14, minute: 51, second: 21, millisecond: 436, kind: DateTimeKind.Local),

new DateTime(year: 1964, month: 10, day: 7, hour: 7, minute: 20, second: 39, millisecond: 998, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1974, month: 10, day: 12, hour: 15, minute: 50, second: 21, millisecond: 752, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 14, hour: 8, minute: 12, second: 36, millisecond: 255, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 16, hour: 8, minute: 55, second: 27, millisecond: 698, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1974, month: 10, day: 1, hour: 4, minute: 26, second: 1, millisecond: 300, kind: DateTimeKind.Local),

new DateTime(year: 2019, month: 10, day: 6, hour: 1, minute: 42, second: 36, millisecond: 487, kind: DateTimeKind.Local),

new DateTime(year: 1975, month: 10, day: 6, hour: 12, minute: 40, second: 24, millisecond: 566, kind: DateTimeKind.Local),

new DateTime(year: 1986, month: 10, day: 10, hour: 5, minute: 5, second: 7, millisecond: 313, kind: DateTimeKind.Local),

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
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneArray2M), typeof(FlatDateTimetimestamp_without_time_zoneArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_without_time_zoneArray)),
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
FROM public.datetimetimestamp_without_time_zonearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                await ((IDateTimeListtimestamp_without_time_zoneArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                ((IDateTimeListtimestamp_without_time_zoneArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneArray2M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDateTimeListtimestamp_without_time_zoneArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
            overrideAliasPrefixs: null,
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
                var models = ((IDateTimeListtimestamp_without_time_zoneArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneArray2M), typeof(FlatDateTimetimestamp_without_time_zoneArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
FROM public.datetimetimestamp_without_time_zonearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                await ((IDateTimeListtimestamp_without_time_zoneArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                ((IDateTimeListtimestamp_without_time_zoneArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneArray2M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDateTimeListtimestamp_without_time_zoneArray)this).DynQuerySelectModel(connection,  query, 0);
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
            overrideAliasPrefixs: null,
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
                var models = ((IDateTimeListtimestamp_without_time_zoneArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneArray2M), typeof(FlatDateTimetimestamp_without_time_zoneArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_without_time_zoneArray)),
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
FROM public.datetimetimestamp_without_time_zonearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                await((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneArray2M)],
            overrideAliasPrefixs: null,
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
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
                parametr1.Value = 158;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_without_time_zonearray2m m
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
                        Assert.That(models, Has.Count.EqualTo(2));
FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[28], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[29], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 158;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_without_time_zonearray2m m
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
            overrideAliasPrefixs: null,
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
                var models = await((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
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
                parametr1.Value = 143;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[23], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[24], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[25], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[26], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[27], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[28], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[3], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[4], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[5], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[6], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[7], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[8], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[9], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[10], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[11], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[12], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[13], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[14], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[15], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[16], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[17], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[18], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[19], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[17],_testData[20], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[18],_testData[21], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[19],_testData[22], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[20],_testData[23], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[21],_testData[24], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[22],_testData[25], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[23],_testData[26], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[24],_testData[27], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[25],_testData[28], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[26],_testData[29], false);
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
                var models = ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(9));
DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[21], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[22], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[23], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[24], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[25], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[26], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[27], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[28], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneArray2M), typeof(FlatDateTimetimestamp_without_time_zoneArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
FROM public.datetimetimestamp_without_time_zonearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                await((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneArray2M)],
            overrideAliasPrefixs: null,
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 134, query1, 7, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[22], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[23], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[24], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[25], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[26], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[27], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[28], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[1], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[2], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[3], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[4], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[5], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[6], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[7], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[8], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[9], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[10], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[11], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[12], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[13], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[14], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[15], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[16], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[17], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[17],_testData[18], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[18],_testData[19], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[19],_testData[20], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[20],_testData[21], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[21],_testData[22], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[22],_testData[23], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[23],_testData[24], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[24],_testData[25], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[25],_testData[26], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[26],_testData[27], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[27],_testData[28], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[28],_testData[29], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatch(connection, 54, query1, 7, query2))
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
                        Assert.That(models, Has.Count.EqualTo(29));
FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[1], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[2], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[3], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[4], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[5], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[6], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[7], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[8], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[9], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[10], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[11], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[12], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[13], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[14], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[15], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[16], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[17], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[17],_testData[18], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[18],_testData[19], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[19],_testData[20], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[20],_testData[21], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[21],_testData[22], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[22],_testData[23], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[23],_testData[24], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[24],_testData[25], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[25],_testData[26], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[26],_testData[27], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[27],_testData[28], false);FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[28],_testData[29], false);
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
            overrideAliasPrefixs: null,
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
                var models = await((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSelectModelAsync(connection, 0);
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
                foreach(var batchResult in await ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSelectModelBatchAsync(connection, 49, 49))
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
                        Assert.That(models, Has.Count.EqualTo(22));
DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[8], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[9], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[10], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[11], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[12], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[13], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[14], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[15], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[16], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[17], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[18], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[19], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[20], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[21], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[22], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[23], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[24], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[17],_testData[25], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[18],_testData[26], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[19],_testData[27], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[20],_testData[28], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[21],_testData[29], false);
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
                var models = ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSelectModel(connection, 0);
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
                foreach(var batchResult in  ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSelectModelBatch(connection, 20, 61))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[3], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[4], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[5], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[6], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[7], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[8], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[9], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[10], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[11], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[12], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[13], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[14], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[15], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[16], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[17], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[18], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[19], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[17],_testData[20], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[18],_testData[21], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[19],_testData[22], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[20],_testData[23], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[21],_testData[24], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[22],_testData[25], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[23],_testData[26], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[24],_testData[27], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[25],_testData[28], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[10], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[11], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[12], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[13], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[14], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[15], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[16], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[17], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[18], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[19], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[20], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[21], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[22], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[23], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[24], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[25], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[26], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[17],_testData[27], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[18],_testData[28], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[19],_testData[29], false);
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
                ((IDateTimeListtimestamp_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 20);
                var models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[3], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[4], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[5], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[6], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[7], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[8], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[9], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[10], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[11], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[12], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[13], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[14], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[15], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[16], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[17], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[18], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[19], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[17],_testData[20], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[18],_testData[21], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[19],_testData[22], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[20],_testData[23], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[21],_testData[24], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[22],_testData[25], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[23],_testData[26], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[24],_testData[27], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[25],_testData[28], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[26],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateTimeListtimestamp_without_time_zoneArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateTimeListtimestamp_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 35);
                var models =  ((IDateTimeListtimestamp_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));
DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[6], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[7], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[8], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[9], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[10], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[11], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[12], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[13], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[14], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[15], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[16], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[17], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[18], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[19], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[20], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[21], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[22], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[17],_testData[23], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[18],_testData[24], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[19],_testData[25], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[20],_testData[26], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[21],_testData[27], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[22],_testData[28], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[23],_testData[29], false);
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

