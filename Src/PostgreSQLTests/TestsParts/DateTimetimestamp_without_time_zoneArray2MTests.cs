

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
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2005, month: 10, day: 7, hour: 6, minute: 10, second: 28, millisecond: 524, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 4, hour: 21, minute: 47, second: 32, millisecond: 487, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 2, hour: 17, minute: 41, second: 22, millisecond: 500, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 15, hour: 8, minute: 13, second: 19, millisecond: 37, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1953, month: 10, day: 9, hour: 11, minute: 39, second: 53, millisecond: 710, kind: DateTimeKind.Local),

new DateTime(year: 1934, month: 10, day: 9, hour: 18, minute: 52, second: 9, millisecond: 531, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 6, hour: 11, minute: 58, second: 10, millisecond: 200, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 8, hour: 7, minute: 41, second: 15, millisecond: 152, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2008, month: 10, day: 14, hour: 9, minute: 53, second: 5, millisecond: 84, kind: DateTimeKind.Local),

new DateTime(year: 1972, month: 10, day: 4, hour: 14, minute: 45, second: 45, millisecond: 753, kind: DateTimeKind.Local),

new DateTime(year: 2019, month: 10, day: 11, hour: 14, minute: 36, second: 29, millisecond: 306, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 2, hour: 17, minute: 10, second: 55, millisecond: 355, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2000, month: 10, day: 15, hour: 12, minute: 51, second: 54, millisecond: 224, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 3, hour: 19, minute: 55, second: 10, millisecond: 901, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 5, hour: 11, minute: 48, second: 55, millisecond: 905, kind: DateTimeKind.Local),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1993, month: 10, day: 7, hour: 7, minute: 14, second: 8, millisecond: 851, kind: DateTimeKind.Local),

new DateTime(year: 1983, month: 10, day: 13, hour: 16, minute: 4, second: 28, millisecond: 351, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 7, hour: 13, minute: 33, second: 24, millisecond: 353, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1937, month: 10, day: 10, hour: 10, minute: 26, second: 46, millisecond: 984, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 16, hour: 5, minute: 35, second: 55, millisecond: 986, kind: DateTimeKind.Local),

new DateTime(year: 1986, month: 10, day: 5, hour: 18, minute: 8, second: 30, millisecond: 431, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1950, month: 10, day: 8, hour: 6, minute: 7, second: 20, millisecond: 35, kind: DateTimeKind.Local),

new DateTime(year: 1926, month: 10, day: 9, hour: 10, minute: 23, second: 57, millisecond: 329, kind: DateTimeKind.Local),

new DateTime(year: 1977, month: 10, day: 18, hour: 21, minute: 53, second: 54, millisecond: 228, kind: DateTimeKind.Local),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1942, month: 10, day: 3, hour: 2, minute: 42, second: 13, millisecond: 79, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 6, hour: 13, minute: 16, second: 49, millisecond: 215, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 16, hour: 14, minute: 44, second: 46, millisecond: 956, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1979, month: 10, day: 4, hour: 22, minute: 58, second: 51, millisecond: 612, kind: DateTimeKind.Local),

new DateTime(year: 1974, month: 10, day: 9, hour: 15, minute: 18, second: 33, millisecond: 414, kind: DateTimeKind.Local),

new DateTime(year: 1934, month: 10, day: 11, hour: 13, minute: 8, second: 48, millisecond: 504, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2003, month: 10, day: 2, hour: 20, minute: 50, second: 28, millisecond: 603, kind: DateTimeKind.Local),

new DateTime(year: 1956, month: 10, day: 5, hour: 12, minute: 21, second: 39, millisecond: 213, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 11, hour: 16, minute: 55, second: 39, millisecond: 359, kind: DateTimeKind.Local),

new DateTime(year: 1960, month: 10, day: 2, hour: 3, minute: 5, second: 25, millisecond: 666, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1968, month: 10, day: 13, hour: 8, minute: 42, second: 25, millisecond: 579, kind: DateTimeKind.Local),

new DateTime(year: 2004, month: 10, day: 6, hour: 6, minute: 28, second: 31, millisecond: 841, kind: DateTimeKind.Local),

new DateTime(year: 2009, month: 10, day: 17, hour: 7, minute: 19, second: 14, millisecond: 910, kind: DateTimeKind.Local),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2005, month: 10, day: 5, hour: 12, minute: 53, second: 38, millisecond: 89, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 2, hour: 16, minute: 27, second: 29, millisecond: 853, kind: DateTimeKind.Local),

new DateTime(year: 1966, month: 10, day: 8, hour: 13, minute: 57, second: 15, millisecond: 745, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1930, month: 10, day: 8, hour: 8, minute: 36, second: 31, millisecond: 193, kind: DateTimeKind.Local),

new DateTime(year: 1933, month: 10, day: 6, hour: 11, minute: 35, second: 39, millisecond: 303, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 3, hour: 4, minute: 42, second: 6, millisecond: 752, kind: DateTimeKind.Local),

new DateTime(year: 1960, month: 10, day: 18, hour: 19, minute: 29, second: 29, millisecond: 611, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1964, month: 10, day: 14, hour: 18, minute: 55, second: 11, millisecond: 253, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 9, hour: 7, minute: 23, second: 52, millisecond: 864, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 8, hour: 1, minute: 16, second: 9, millisecond: 677, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1979, month: 10, day: 16, hour: 14, minute: 42, second: 42, millisecond: 599, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 13, hour: 7, minute: 26, second: 35, millisecond: 489, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 14, hour: 15, minute: 5, second: 5, millisecond: 33, kind: DateTimeKind.Local),

new DateTime(year: 2017, month: 10, day: 2, hour: 8, minute: 15, second: 3, millisecond: 454, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1974, month: 10, day: 8, hour: 2, minute: 30, second: 4, millisecond: 42, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 10, hour: 17, minute: 40, second: 34, millisecond: 217, kind: DateTimeKind.Local),

new DateTime(year: 1965, month: 10, day: 8, hour: 19, minute: 35, second: 51, millisecond: 580, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1969, month: 10, day: 14, hour: 13, minute: 32, second: 21, millisecond: 552, kind: DateTimeKind.Local),

new DateTime(year: 1956, month: 10, day: 17, hour: 3, minute: 3, second: 4, millisecond: 290, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 14, hour: 11, minute: 16, second: 9, millisecond: 196, kind: DateTimeKind.Local),

new DateTime(year: 1963, month: 10, day: 17, hour: 11, minute: 39, second: 5, millisecond: 707, kind: DateTimeKind.Local),

},
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1945, month: 10, day: 9, hour: 2, minute: 25, second: 24, millisecond: 323, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 10, hour: 15, minute: 48, second: 43, millisecond: 859, kind: DateTimeKind.Local),

new DateTime(year: 1992, month: 10, day: 5, hour: 12, minute: 13, second: 5, millisecond: 822, kind: DateTimeKind.Local),

new DateTime(year: 1983, month: 10, day: 12, hour: 8, minute: 12, second: 29, millisecond: 461, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1922, month: 10, day: 16, hour: 15, minute: 20, second: 52, millisecond: 296, kind: DateTimeKind.Local),

new DateTime(year: 1974, month: 10, day: 19, hour: 7, minute: 42, second: 47, millisecond: 472, kind: DateTimeKind.Local),

new DateTime(year: 1991, month: 10, day: 15, hour: 8, minute: 7, second: 30, millisecond: 53, kind: DateTimeKind.Local),

new DateTime(year: 1931, month: 10, day: 12, hour: 6, minute: 34, second: 53, millisecond: 551, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2014, month: 10, day: 17, hour: 14, minute: 46, second: 7, millisecond: 705, kind: DateTimeKind.Local),

new DateTime(year: 1977, month: 10, day: 13, hour: 16, minute: 3, second: 35, millisecond: 586, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 17, hour: 2, minute: 29, second: 41, millisecond: 784, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 5, hour: 19, minute: 4, second: 29, millisecond: 66, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1924, month: 10, day: 17, hour: 9, minute: 9, second: 43, millisecond: 363, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 18, hour: 19, minute: 32, second: 51, millisecond: 291, kind: DateTimeKind.Local),

new DateTime(year: 1977, month: 10, day: 6, hour: 2, minute: 12, second: 51, millisecond: 534, kind: DateTimeKind.Local),

},
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1996, month: 10, day: 17, hour: 7, minute: 56, second: 47, millisecond: 388, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 9, hour: 21, minute: 20, second: 24, millisecond: 498, kind: DateTimeKind.Local),

new DateTime(year: 2012, month: 10, day: 9, hour: 1, minute: 52, second: 34, millisecond: 979, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 11, hour: 8, minute: 3, second: 3, millisecond: 6, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1931, month: 10, day: 3, hour: 3, minute: 37, second: 54, millisecond: 419, kind: DateTimeKind.Local),

new DateTime(year: 1974, month: 10, day: 6, hour: 7, minute: 54, second: 38, millisecond: 607, kind: DateTimeKind.Local),

new DateTime(year: 2005, month: 10, day: 6, hour: 11, minute: 32, second: 28, millisecond: 205, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2000, month: 10, day: 14, hour: 9, minute: 56, second: 48, millisecond: 376, kind: DateTimeKind.Local),

new DateTime(year: 1988, month: 10, day: 7, hour: 6, minute: 32, second: 24, millisecond: 233, kind: DateTimeKind.Local),

new DateTime(year: 1993, month: 10, day: 17, hour: 8, minute: 24, second: 9, millisecond: 75, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 4, hour: 11, minute: 18, second: 51, millisecond: 487, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2009, month: 10, day: 7, hour: 12, minute: 10, second: 51, millisecond: 825, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 7, hour: 4, minute: 19, second: 50, millisecond: 462, kind: DateTimeKind.Local),

new DateTime(year: 1983, month: 10, day: 1, hour: 8, minute: 8, second: 14, millisecond: 936, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1948, month: 10, day: 14, hour: 4, minute: 25, second: 7, millisecond: 644, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 10, hour: 11, minute: 3, second: 20, millisecond: 994, kind: DateTimeKind.Local),

new DateTime(year: 1977, month: 10, day: 18, hour: 11, minute: 21, second: 48, millisecond: 542, kind: DateTimeKind.Local),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1974, month: 10, day: 10, hour: 22, minute: 33, second: 22, millisecond: 148, kind: DateTimeKind.Local),

new DateTime(year: 1927, month: 10, day: 17, hour: 19, minute: 37, second: 24, millisecond: 371, kind: DateTimeKind.Local),

new DateTime(year: 1988, month: 10, day: 2, hour: 12, minute: 21, second: 55, millisecond: 439, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2015, month: 10, day: 8, hour: 3, minute: 3, second: 33, millisecond: 195, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 17, hour: 17, minute: 16, second: 24, millisecond: 936, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 2, hour: 17, minute: 2, second: 30, millisecond: 211, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 10, hour: 2, minute: 51, second: 58, millisecond: 152, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2019, month: 10, day: 12, hour: 11, minute: 29, second: 47, millisecond: 791, kind: DateTimeKind.Local),

new DateTime(year: 2013, month: 10, day: 10, hour: 9, minute: 28, second: 10, millisecond: 405, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 17, hour: 1, minute: 25, second: 54, millisecond: 348, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1956, month: 10, day: 12, hour: 16, minute: 17, second: 5, millisecond: 873, kind: DateTimeKind.Local),

new DateTime(year: 1975, month: 10, day: 15, hour: 18, minute: 57, second: 23, millisecond: 628, kind: DateTimeKind.Local),

new DateTime(year: 1938, month: 10, day: 12, hour: 21, minute: 31, second: 9, millisecond: 291, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1996, month: 10, day: 1, hour: 7, minute: 48, second: 27, millisecond: 443, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 3, hour: 5, minute: 40, second: 22, millisecond: 735, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 5, hour: 3, minute: 13, second: 29, millisecond: 626, kind: DateTimeKind.Local),

new DateTime(year: 1978, month: 10, day: 10, hour: 17, minute: 50, second: 32, millisecond: 226, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1925, month: 10, day: 17, hour: 19, minute: 26, second: 42, millisecond: 252, kind: DateTimeKind.Local),

new DateTime(year: 1971, month: 10, day: 10, hour: 22, minute: 1, second: 15, millisecond: 500, kind: DateTimeKind.Local),

new DateTime(year: 1920, month: 10, day: 14, hour: 10, minute: 48, second: 47, millisecond: 957, kind: DateTimeKind.Local),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2017, month: 10, day: 8, hour: 13, minute: 21, second: 2, millisecond: 623, kind: DateTimeKind.Local),

new DateTime(year: 1936, month: 10, day: 7, hour: 20, minute: 9, second: 15, millisecond: 273, kind: DateTimeKind.Local),

new DateTime(year: 1942, month: 10, day: 18, hour: 16, minute: 13, second: 50, millisecond: 540, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1981, month: 10, day: 6, hour: 19, minute: 49, second: 39, millisecond: 201, kind: DateTimeKind.Local),

new DateTime(year: 1926, month: 10, day: 16, hour: 20, minute: 15, second: 54, millisecond: 160, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 16, hour: 16, minute: 7, second: 1, millisecond: 113, kind: DateTimeKind.Local),

new DateTime(year: 1922, month: 10, day: 16, hour: 16, minute: 48, second: 41, millisecond: 198, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1977, month: 10, day: 12, hour: 14, minute: 6, second: 14, millisecond: 145, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 8, hour: 8, minute: 57, second: 48, millisecond: 991, kind: DateTimeKind.Local),

new DateTime(year: 1944, month: 10, day: 1, hour: 21, minute: 12, second: 15, millisecond: 711, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1950, month: 10, day: 3, hour: 17, minute: 5, second: 4, millisecond: 865, kind: DateTimeKind.Local),

new DateTime(year: 1993, month: 10, day: 16, hour: 7, minute: 58, second: 13, millisecond: 295, kind: DateTimeKind.Local),

new DateTime(year: 1935, month: 10, day: 16, hour: 4, minute: 24, second: 6, millisecond: 194, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1928, month: 10, day: 8, hour: 8, minute: 49, second: 6, millisecond: 627, kind: DateTimeKind.Local),

new DateTime(year: 1963, month: 10, day: 9, hour: 13, minute: 53, second: 35, millisecond: 324, kind: DateTimeKind.Local),

new DateTime(year: 1964, month: 10, day: 1, hour: 6, minute: 2, second: 1, millisecond: 665, kind: DateTimeKind.Local),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1986, month: 10, day: 8, hour: 4, minute: 51, second: 57, millisecond: 399, kind: DateTimeKind.Local),

new DateTime(year: 2005, month: 10, day: 6, hour: 15, minute: 32, second: 36, millisecond: 415, kind: DateTimeKind.Local),

new DateTime(year: 1937, month: 10, day: 4, hour: 17, minute: 30, second: 11, millisecond: 303, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2013, month: 10, day: 12, hour: 12, minute: 47, second: 50, millisecond: 400, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 2, hour: 15, minute: 43, second: 44, millisecond: 583, kind: DateTimeKind.Local),

new DateTime(year: 1965, month: 10, day: 9, hour: 12, minute: 57, second: 31, millisecond: 367, kind: DateTimeKind.Local),

new DateTime(year: 2011, month: 10, day: 10, hour: 14, minute: 23, second: 44, millisecond: 104, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1944, month: 10, day: 11, hour: 14, minute: 40, second: 32, millisecond: 309, kind: DateTimeKind.Local),

new DateTime(year: 2019, month: 10, day: 7, hour: 15, minute: 13, second: 32, millisecond: 859, kind: DateTimeKind.Local),

new DateTime(year: 2012, month: 10, day: 11, hour: 20, minute: 43, second: 15, millisecond: 210, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1960, month: 10, day: 12, hour: 17, minute: 45, second: 53, millisecond: 875, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 12, hour: 2, minute: 29, second: 33, millisecond: 899, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 18, hour: 5, minute: 1, second: 26, millisecond: 294, kind: DateTimeKind.Local),

new DateTime(year: 1940, month: 10, day: 5, hour: 16, minute: 51, second: 20, millisecond: 370, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2009, month: 10, day: 18, hour: 19, minute: 12, second: 1, millisecond: 992, kind: DateTimeKind.Local),

new DateTime(year: 2017, month: 10, day: 18, hour: 8, minute: 31, second: 49, millisecond: 501, kind: DateTimeKind.Local),

new DateTime(year: 2008, month: 10, day: 18, hour: 8, minute: 54, second: 11, millisecond: 55, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 1, hour: 18, minute: 11, second: 7, millisecond: 527, kind: DateTimeKind.Local),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1921, month: 10, day: 2, hour: 10, minute: 38, second: 5, millisecond: 374, kind: DateTimeKind.Local),

new DateTime(year: 1960, month: 10, day: 4, hour: 14, minute: 19, second: 22, millisecond: 921, kind: DateTimeKind.Local),

new DateTime(year: 1987, month: 10, day: 2, hour: 9, minute: 38, second: 35, millisecond: 953, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2006, month: 10, day: 16, hour: 18, minute: 9, second: 52, millisecond: 263, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 10, hour: 13, minute: 53, second: 36, millisecond: 284, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 10, hour: 18, minute: 39, second: 11, millisecond: 52, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2009, month: 10, day: 18, hour: 11, minute: 26, second: 41, millisecond: 501, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 8, hour: 16, minute: 18, second: 54, millisecond: 741, kind: DateTimeKind.Local),

new DateTime(year: 1917, month: 10, day: 12, hour: 6, minute: 11, second: 49, millisecond: 222, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1964, month: 10, day: 4, hour: 22, minute: 24, second: 50, millisecond: 598, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 19, hour: 1, minute: 9, second: 36, millisecond: 994, kind: DateTimeKind.Local),

new DateTime(year: 1918, month: 10, day: 12, hour: 1, minute: 25, second: 31, millisecond: 469, kind: DateTimeKind.Local),

new DateTime(year: 2007, month: 10, day: 9, hour: 22, minute: 11, second: 53, millisecond: 943, kind: DateTimeKind.Local),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1985, month: 10, day: 4, hour: 2, minute: 52, second: 15, millisecond: 530, kind: DateTimeKind.Local),

new DateTime(year: 2005, month: 10, day: 11, hour: 15, minute: 21, second: 36, millisecond: 490, kind: DateTimeKind.Local),

new DateTime(year: 2014, month: 10, day: 9, hour: 5, minute: 57, second: 53, millisecond: 907, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1952, month: 10, day: 16, hour: 15, minute: 46, second: 25, millisecond: 873, kind: DateTimeKind.Local),

new DateTime(year: 1974, month: 10, day: 16, hour: 13, minute: 54, second: 55, millisecond: 76, kind: DateTimeKind.Local),

new DateTime(year: 2012, month: 10, day: 18, hour: 1, minute: 9, second: 24, millisecond: 395, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 2, hour: 11, minute: 31, second: 2, millisecond: 567, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1935, month: 10, day: 3, hour: 1, minute: 24, second: 20, millisecond: 778, kind: DateTimeKind.Local),

new DateTime(year: 1922, month: 10, day: 2, hour: 2, minute: 21, second: 42, millisecond: 228, kind: DateTimeKind.Local),

new DateTime(year: 1991, month: 10, day: 17, hour: 8, minute: 56, second: 13, millisecond: 130, kind: DateTimeKind.Local),

new DateTime(year: 1940, month: 10, day: 5, hour: 12, minute: 35, second: 46, millisecond: 165, kind: DateTimeKind.Local),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1998, month: 10, day: 9, hour: 21, minute: 20, second: 37, millisecond: 105, kind: DateTimeKind.Local),

new DateTime(year: 1963, month: 10, day: 9, hour: 15, minute: 29, second: 31, millisecond: 801, kind: DateTimeKind.Local),

new DateTime(year: 2017, month: 10, day: 4, hour: 11, minute: 58, second: 37, millisecond: 183, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1935, month: 10, day: 18, hour: 20, minute: 45, second: 48, millisecond: 824, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 6, hour: 12, minute: 35, second: 38, millisecond: 441, kind: DateTimeKind.Local),

new DateTime(year: 1918, month: 10, day: 14, hour: 10, minute: 55, second: 15, millisecond: 940, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1940, month: 10, day: 15, hour: 14, minute: 29, second: 20, millisecond: 250, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 11, hour: 4, minute: 14, second: 2, millisecond: 108, kind: DateTimeKind.Local),

new DateTime(year: 1920, month: 10, day: 8, hour: 11, minute: 53, second: 46, millisecond: 810, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1919, month: 10, day: 1, hour: 6, minute: 21, second: 45, millisecond: 417, kind: DateTimeKind.Local),

new DateTime(year: 1972, month: 10, day: 14, hour: 2, minute: 9, second: 25, millisecond: 530, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 5, hour: 10, minute: 44, second: 11, millisecond: 207, kind: DateTimeKind.Local),

new DateTime(year: 1993, month: 10, day: 9, hour: 19, minute: 29, second: 13, millisecond: 550, kind: DateTimeKind.Local),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1920, month: 10, day: 2, hour: 21, minute: 36, second: 30, millisecond: 289, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 13, hour: 10, minute: 39, second: 52, millisecond: 164, kind: DateTimeKind.Local),

new DateTime(year: 2007, month: 10, day: 14, hour: 20, minute: 9, second: 38, millisecond: 777, kind: DateTimeKind.Local),

new DateTime(year: 1966, month: 10, day: 5, hour: 22, minute: 25, second: 4, millisecond: 293, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1924, month: 10, day: 6, hour: 2, minute: 39, second: 40, millisecond: 580, kind: DateTimeKind.Local),

new DateTime(year: 2012, month: 10, day: 5, hour: 9, minute: 19, second: 31, millisecond: 42, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 8, hour: 3, minute: 57, second: 7, millisecond: 293, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1929, month: 10, day: 14, hour: 19, minute: 3, second: 53, millisecond: 666, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 7, hour: 12, minute: 23, second: 20, millisecond: 549, kind: DateTimeKind.Local),

new DateTime(year: 2019, month: 10, day: 12, hour: 1, minute: 57, second: 4, millisecond: 660, kind: DateTimeKind.Local),

new DateTime(year: 2014, month: 10, day: 10, hour: 4, minute: 41, second: 3, millisecond: 335, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1975, month: 10, day: 3, hour: 3, minute: 54, second: 44, millisecond: 251, kind: DateTimeKind.Local),

new DateTime(year: 1936, month: 10, day: 15, hour: 13, minute: 13, second: 49, millisecond: 432, kind: DateTimeKind.Local),

new DateTime(year: 1993, month: 10, day: 8, hour: 6, minute: 48, second: 58, millisecond: 239, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1946, month: 10, day: 19, hour: 8, minute: 53, second: 43, millisecond: 242, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 3, hour: 1, minute: 16, second: 55, millisecond: 190, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 19, hour: 5, minute: 39, second: 31, millisecond: 692, kind: DateTimeKind.Local),

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
new DateTime(year: 1954, month: 10, day: 10, hour: 8, minute: 44, second: 2, millisecond: 994, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 19, hour: 17, minute: 8, second: 30, millisecond: 3, kind: DateTimeKind.Local),

new DateTime(year: 2000, month: 10, day: 12, hour: 16, minute: 40, second: 48, millisecond: 883, kind: DateTimeKind.Local),

new DateTime(year: 2011, month: 10, day: 7, hour: 4, minute: 6, second: 45, millisecond: 561, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2010, month: 10, day: 2, hour: 16, minute: 50, second: 56, millisecond: 861, kind: DateTimeKind.Local),

new DateTime(year: 1992, month: 10, day: 1, hour: 1, minute: 49, second: 46, millisecond: 90, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 4, hour: 16, minute: 17, second: 49, millisecond: 654, kind: DateTimeKind.Local),

new DateTime(year: 1987, month: 10, day: 11, hour: 14, minute: 11, second: 28, millisecond: 629, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1956, month: 10, day: 13, hour: 8, minute: 6, second: 29, millisecond: 570, kind: DateTimeKind.Local),

new DateTime(year: 1984, month: 10, day: 7, hour: 16, minute: 37, second: 48, millisecond: 777, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 14, hour: 13, minute: 33, second: 38, millisecond: 584, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1951, month: 10, day: 14, hour: 22, minute: 50, second: 24, millisecond: 2, kind: DateTimeKind.Local),

new DateTime(year: 1987, month: 10, day: 8, hour: 20, minute: 9, second: 57, millisecond: 783, kind: DateTimeKind.Local),

new DateTime(year: 1952, month: 10, day: 18, hour: 13, minute: 13, second: 6, millisecond: 549, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 3, hour: 22, minute: 9, second: 15, millisecond: 408, kind: DateTimeKind.Local),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1946, month: 10, day: 5, hour: 14, minute: 3, second: 30, millisecond: 458, kind: DateTimeKind.Local),

new DateTime(year: 1942, month: 10, day: 12, hour: 9, minute: 24, second: 49, millisecond: 977, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 14, hour: 10, minute: 16, second: 14, millisecond: 361, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 5, hour: 20, minute: 42, second: 34, millisecond: 429, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2015, month: 10, day: 17, hour: 2, minute: 38, second: 26, millisecond: 482, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 7, hour: 13, minute: 49, second: 30, millisecond: 42, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 11, hour: 1, minute: 26, second: 3, millisecond: 175, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1966, month: 10, day: 14, hour: 17, minute: 55, second: 36, millisecond: 327, kind: DateTimeKind.Local),

new DateTime(year: 1971, month: 10, day: 9, hour: 19, minute: 26, second: 5, millisecond: 593, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 6, hour: 16, minute: 30, second: 30, millisecond: 159, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 8, hour: 1, minute: 34, second: 54, millisecond: 764, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2001, month: 10, day: 16, hour: 11, minute: 57, second: 34, millisecond: 168, kind: DateTimeKind.Local),

new DateTime(year: 1978, month: 10, day: 4, hour: 2, minute: 47, second: 51, millisecond: 568, kind: DateTimeKind.Local),

new DateTime(year: 1972, month: 10, day: 15, hour: 2, minute: 20, second: 12, millisecond: 939, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 13, hour: 11, minute: 5, second: 28, millisecond: 342, kind: DateTimeKind.Local),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1965, month: 10, day: 1, hour: 22, minute: 36, second: 43, millisecond: 308, kind: DateTimeKind.Local),

new DateTime(year: 1922, month: 10, day: 17, hour: 16, minute: 17, second: 37, millisecond: 924, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 18, hour: 9, minute: 28, second: 13, millisecond: 47, kind: DateTimeKind.Local),

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

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_without_time_zoneArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionSTMMDynQuerySelectModelDynParBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_without_time_zoneArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionMMDynQuerySelectModelDynParBatchConfig()
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
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
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
                var query2 = @"
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
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                await ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[11],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
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
                parametr2.Value = 78;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
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
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                await ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[13],_testData[29], false);
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

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
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
                parametr2.Value = 44;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
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
                var query2 = @"
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
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                 ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[19],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
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
                parametr2.Value = 106;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
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
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                 ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[29], false);
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
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
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
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
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
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
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
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
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
                parametr2.Value = 34;
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
                foreach(var batchResult in await ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[17],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[18],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[19],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[17],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[18],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[19],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[20],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
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
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
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
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                await ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[5],_testData[30], false);
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
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
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
                foreach(var batchResult in  ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
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
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                 ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[1],_testData[30], false);
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
            batchName: "DbConnectionSTSelectModelDynParBatch",
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
        private void DbConnectionSTSelectModelDynParBatchConfig()
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
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[7], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[8], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[9], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[10], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[11], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[12], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[13], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[14], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[15], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[16], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[17], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[18], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[19], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[20], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[21], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[22], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[23], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[17],_testData[24], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[18],_testData[25], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[19],_testData[26], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[20],_testData[27], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[21],_testData[28], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[24], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[25], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[26], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[27], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[28], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[29], false);
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
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[5], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[6], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[7], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[8], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[9], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[10], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[11], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[12], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[13], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[14], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[15], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[16], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[17], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[18], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[19], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[20], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[21], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[17],_testData[22], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[18],_testData[23], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[19],_testData[24], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[20],_testData[25], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[21],_testData[26], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[22],_testData[27], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[23],_testData[28], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[28], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[29], false);
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

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_without_time_zoneArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 2)]
        private void DbConnectionSTMMDynQuerySelectModelBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_without_time_zoneArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 2)]
        private void DbConnectionMMDynQuerySelectModelBatchConfig()
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
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
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
                var query2 = @"
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
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                await ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 114, query1, 116, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[6],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
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
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                await ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 27, query1, 44, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[19],_testData[29], false);
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

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
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
                var query2 = @"
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
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                 ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 87, query1, 119, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[4],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
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
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                 ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 34, query1, 44, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[19],_testData[29], false);
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
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
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
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
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
            methodName: "DbConnectionMMDynQuerySelectModel",
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
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
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
                foreach(var batchResult in await ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 44, query1, 118, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[17],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[18],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
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
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                await ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 136, query1, 19, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[25],_testData[30], false);
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
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
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
                foreach(var batchResult in  ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 87, query1, 69, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
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
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneArray2M>();
                 ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatch(connection, 114, query1, 53, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[18],_testData[30], false);
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
            batchName: "DbConnectionSTSelectModelBatch",
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
        private void DbConnectionSTSelectModelBatchConfig()
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
        public async Task DbConnectionSTSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSTSelectModelBatchAsync(connection, 44, 103))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[10], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[11], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[12], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[13], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[14], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[15], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[16], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[17], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[18], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[19], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[20], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[21], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[22], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[23], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[24], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[25], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[26], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[17],_testData[27], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[18],_testData[28], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[19], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[20], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[21], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[22], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[23], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[24], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[25], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[26], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[27], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[28], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[29], false);
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
        public async Task DbConnectionSTSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSTSelectModelBatch(connection, 66, 127))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[14], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[15], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[16], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[17], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[18], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[19], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[20], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[21], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[22], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[23], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[24], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[25], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[26], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[27], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[28], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[26], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[27], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[28], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[29], false);
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
                ((IDateTimeListtimestamp_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 19);
                var models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));
DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[4], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[5], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[6], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[7], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[8], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[9], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[10], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[11], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[12], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[13], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[14], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[15], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[16], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[17], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[18], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[19], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[20], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[17],_testData[21], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[18],_testData[22], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[19],_testData[23], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[20],_testData[24], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[21],_testData[25], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[22],_testData[26], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[23],_testData[27], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[24],_testData[28], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[25],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateTimeListtimestamp_without_time_zoneArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateTimeListtimestamp_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 78);
                var models =  ((IDateTimeListtimestamp_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(14));
DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[16], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[17], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[18], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[19], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[20], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[21], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[22], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[23], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[24], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[25], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[26], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[27], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[28], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[29], false);
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

