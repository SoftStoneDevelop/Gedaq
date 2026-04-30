

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
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2010, month: 10, day: 16, hour: 5, minute: 58, second: 42, millisecond: 742, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 9, hour: 1, minute: 35, second: 21, millisecond: 958, kind: DateTimeKind.Utc),

new DateTime(year: 1921, month: 10, day: 12, hour: 11, minute: 31, second: 35, millisecond: 444, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2006, month: 10, day: 4, hour: 13, minute: 26, second: 18, millisecond: 898, kind: DateTimeKind.Utc),

new DateTime(year: 1939, month: 10, day: 13, hour: 13, minute: 35, second: 6, millisecond: 605, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 15, hour: 18, minute: 52, second: 30, millisecond: 746, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1979, month: 10, day: 10, hour: 14, minute: 2, second: 38, millisecond: 737, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 5, hour: 1, minute: 3, second: 34, millisecond: 600, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 3, hour: 8, minute: 1, second: 40, millisecond: 168, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 18, hour: 14, minute: 48, second: 51, millisecond: 453, kind: DateTimeKind.Utc),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1983, month: 10, day: 12, hour: 9, minute: 17, second: 9, millisecond: 945, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 11, hour: 14, minute: 13, second: 30, millisecond: 718, kind: DateTimeKind.Utc),

new DateTime(year: 1936, month: 10, day: 18, hour: 12, minute: 53, second: 1, millisecond: 109, kind: DateTimeKind.Utc),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1931, month: 10, day: 16, hour: 14, minute: 39, second: 18, millisecond: 225, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 11, hour: 4, minute: 18, second: 9, millisecond: 849, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 9, hour: 22, minute: 11, second: 49, millisecond: 155, kind: DateTimeKind.Utc),

new DateTime(year: 1966, month: 10, day: 4, hour: 22, minute: 2, second: 44, millisecond: 731, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1986, month: 10, day: 2, hour: 17, minute: 4, second: 31, millisecond: 295, kind: DateTimeKind.Utc),

new DateTime(year: 1966, month: 10, day: 4, hour: 13, minute: 29, second: 7, millisecond: 446, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 9, hour: 19, minute: 1, second: 10, millisecond: 824, kind: DateTimeKind.Utc),

new DateTime(year: 1948, month: 10, day: 2, hour: 10, minute: 19, second: 40, millisecond: 396, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1951, month: 10, day: 16, hour: 13, minute: 35, second: 56, millisecond: 616, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 14, hour: 8, minute: 33, second: 49, millisecond: 197, kind: DateTimeKind.Utc),

new DateTime(year: 1943, month: 10, day: 17, hour: 21, minute: 16, second: 17, millisecond: 138, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 6, hour: 16, minute: 17, second: 16, millisecond: 995, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1936, month: 10, day: 14, hour: 10, minute: 37, second: 22, millisecond: 778, kind: DateTimeKind.Utc),

new DateTime(year: 1937, month: 10, day: 4, hour: 10, minute: 25, second: 5, millisecond: 707, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 5, hour: 22, minute: 28, second: 16, millisecond: 125, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 15, hour: 17, minute: 26, second: 10, millisecond: 356, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1990, month: 10, day: 19, hour: 3, minute: 41, second: 50, millisecond: 391, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 8, hour: 22, minute: 7, second: 24, millisecond: 970, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 9, hour: 20, minute: 28, second: 54, millisecond: 714, kind: DateTimeKind.Utc),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 17, hour: 18, minute: 20, second: 22, millisecond: 62, kind: DateTimeKind.Utc),

new DateTime(year: 1948, month: 10, day: 2, hour: 13, minute: 47, second: 48, millisecond: 443, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 1, hour: 16, minute: 7, second: 27, millisecond: 694, kind: DateTimeKind.Utc),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1998, month: 10, day: 19, hour: 21, minute: 29, second: 58, millisecond: 466, kind: DateTimeKind.Utc),

new DateTime(year: 2005, month: 10, day: 7, hour: 11, minute: 49, second: 52, millisecond: 830, kind: DateTimeKind.Utc),

new DateTime(year: 1929, month: 10, day: 1, hour: 14, minute: 55, second: 1, millisecond: 515, kind: DateTimeKind.Utc),

new DateTime(year: 1944, month: 10, day: 1, hour: 6, minute: 11, second: 11, millisecond: 772, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1931, month: 10, day: 13, hour: 20, minute: 51, second: 3, millisecond: 843, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 14, hour: 3, minute: 8, second: 55, millisecond: 750, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 18, hour: 9, minute: 48, second: 48, millisecond: 857, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 6, hour: 1, minute: 6, second: 43, millisecond: 937, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2006, month: 10, day: 6, hour: 12, minute: 37, second: 41, millisecond: 969, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 19, hour: 4, minute: 17, second: 4, millisecond: 351, kind: DateTimeKind.Utc),

new DateTime(year: 1969, month: 10, day: 6, hour: 13, minute: 29, second: 56, millisecond: 451, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1984, month: 10, day: 7, hour: 11, minute: 49, second: 55, millisecond: 666, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 9, hour: 21, minute: 8, second: 38, millisecond: 734, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 5, hour: 3, minute: 25, second: 37, millisecond: 393, kind: DateTimeKind.Utc),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2013, month: 10, day: 5, hour: 16, minute: 42, second: 57, millisecond: 487, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 12, hour: 16, minute: 45, second: 27, millisecond: 366, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 7, hour: 1, minute: 19, second: 17, millisecond: 64, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 15, hour: 17, minute: 32, second: 29, millisecond: 540, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1955, month: 10, day: 7, hour: 21, minute: 45, second: 41, millisecond: 525, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 4, hour: 11, minute: 53, second: 55, millisecond: 564, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 18, hour: 21, minute: 35, second: 45, millisecond: 443, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 2, hour: 21, minute: 8, second: 25, millisecond: 456, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1988, month: 10, day: 5, hour: 11, minute: 32, second: 26, millisecond: 366, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 7, hour: 16, minute: 15, second: 24, millisecond: 168, kind: DateTimeKind.Utc),

new DateTime(year: 2005, month: 10, day: 16, hour: 13, minute: 27, second: 12, millisecond: 212, kind: DateTimeKind.Utc),

new DateTime(year: 2010, month: 10, day: 6, hour: 5, minute: 14, second: 46, millisecond: 386, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1965, month: 10, day: 3, hour: 16, minute: 26, second: 39, millisecond: 407, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 15, hour: 11, minute: 15, second: 23, millisecond: 499, kind: DateTimeKind.Utc),

new DateTime(year: 1965, month: 10, day: 7, hour: 11, minute: 49, second: 49, millisecond: 321, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1973, month: 10, day: 16, hour: 17, minute: 9, second: 18, millisecond: 513, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 5, hour: 9, minute: 22, second: 49, millisecond: 636, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 14, hour: 19, minute: 16, second: 25, millisecond: 330, kind: DateTimeKind.Utc),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2019, month: 10, day: 2, hour: 4, minute: 50, second: 56, millisecond: 399, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 3, hour: 20, minute: 36, second: 51, millisecond: 371, kind: DateTimeKind.Utc),

new DateTime(year: 1939, month: 10, day: 9, hour: 6, minute: 19, second: 16, millisecond: 896, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 12, hour: 9, minute: 42, second: 31, millisecond: 235, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1918, month: 10, day: 11, hour: 9, minute: 43, second: 36, millisecond: 865, kind: DateTimeKind.Utc),

new DateTime(year: 1921, month: 10, day: 15, hour: 2, minute: 4, second: 12, millisecond: 697, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 5, hour: 22, minute: 40, second: 51, millisecond: 776, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2011, month: 10, day: 19, hour: 5, minute: 10, second: 3, millisecond: 587, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 16, hour: 3, minute: 3, second: 45, millisecond: 912, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 3, hour: 7, minute: 22, second: 45, millisecond: 848, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 5, hour: 7, minute: 50, second: 42, millisecond: 574, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1936, month: 10, day: 2, hour: 4, minute: 20, second: 40, millisecond: 206, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 2, hour: 20, minute: 39, second: 51, millisecond: 386, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 5, hour: 18, minute: 7, second: 25, millisecond: 844, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 19, hour: 1, minute: 1, second: 56, millisecond: 616, kind: DateTimeKind.Utc),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2012, month: 10, day: 14, hour: 12, minute: 13, second: 38, millisecond: 459, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 16, hour: 5, minute: 48, second: 5, millisecond: 861, kind: DateTimeKind.Utc),

new DateTime(year: 1948, month: 10, day: 8, hour: 19, minute: 15, second: 25, millisecond: 722, kind: DateTimeKind.Utc),

},
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1938, month: 10, day: 18, hour: 13, minute: 5, second: 19, millisecond: 42, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 4, hour: 20, minute: 55, second: 35, millisecond: 208, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 5, hour: 22, minute: 41, second: 28, millisecond: 928, kind: DateTimeKind.Utc),

new DateTime(year: 1994, month: 10, day: 19, hour: 16, minute: 51, second: 48, millisecond: 46, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1956, month: 10, day: 13, hour: 6, minute: 47, second: 8, millisecond: 348, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 4, hour: 14, minute: 46, second: 44, millisecond: 870, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 7, hour: 22, minute: 48, second: 54, millisecond: 981, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1952, month: 10, day: 15, hour: 2, minute: 28, second: 37, millisecond: 436, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 1, hour: 7, minute: 41, second: 49, millisecond: 983, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 3, hour: 1, minute: 30, second: 14, millisecond: 290, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1943, month: 10, day: 3, hour: 4, minute: 40, second: 34, millisecond: 775, kind: DateTimeKind.Utc),

new DateTime(year: 1920, month: 10, day: 10, hour: 1, minute: 51, second: 57, millisecond: 472, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 16, hour: 8, minute: 23, second: 27, millisecond: 711, kind: DateTimeKind.Utc),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1938, month: 10, day: 4, hour: 14, minute: 48, second: 15, millisecond: 136, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 13, hour: 18, minute: 49, second: 16, millisecond: 648, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 14, hour: 2, minute: 31, second: 28, millisecond: 100, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 3, hour: 12, minute: 48, second: 17, millisecond: 112, kind: DateTimeKind.Utc),

},
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1968, month: 10, day: 9, hour: 19, minute: 56, second: 9, millisecond: 798, kind: DateTimeKind.Utc),

new DateTime(year: 1990, month: 10, day: 8, hour: 7, minute: 24, second: 52, millisecond: 850, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 10, hour: 22, minute: 29, second: 53, millisecond: 514, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2008, month: 10, day: 7, hour: 19, minute: 58, second: 8, millisecond: 354, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 11, hour: 19, minute: 54, second: 46, millisecond: 84, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 8, hour: 13, minute: 40, second: 48, millisecond: 537, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1944, month: 10, day: 12, hour: 8, minute: 30, second: 11, millisecond: 748, kind: DateTimeKind.Utc),

new DateTime(year: 1920, month: 10, day: 9, hour: 20, minute: 42, second: 49, millisecond: 294, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 5, hour: 8, minute: 29, second: 18, millisecond: 453, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 2, hour: 21, minute: 42, second: 53, millisecond: 680, kind: DateTimeKind.Utc),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 10, hour: 17, minute: 20, second: 37, millisecond: 820, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 8, hour: 8, minute: 13, second: 6, millisecond: 593, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 8, hour: 14, minute: 2, second: 49, millisecond: 46, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1925, month: 10, day: 9, hour: 16, minute: 38, second: 53, millisecond: 95, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 10, hour: 22, minute: 49, second: 27, millisecond: 454, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 1, hour: 3, minute: 22, second: 56, millisecond: 4, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 6, hour: 14, minute: 10, second: 1, millisecond: 189, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1999, month: 10, day: 16, hour: 7, minute: 48, second: 37, millisecond: 490, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 10, hour: 11, minute: 8, second: 17, millisecond: 220, kind: DateTimeKind.Utc),

new DateTime(year: 2017, month: 10, day: 7, hour: 4, minute: 32, second: 34, millisecond: 813, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 10, hour: 6, minute: 30, second: 15, millisecond: 299, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1985, month: 10, day: 16, hour: 1, minute: 4, second: 5, millisecond: 880, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 16, hour: 10, minute: 30, second: 36, millisecond: 174, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 11, hour: 6, minute: 9, second: 52, millisecond: 536, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 8, hour: 9, minute: 41, second: 55, millisecond: 469, kind: DateTimeKind.Utc),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1928, month: 10, day: 16, hour: 13, minute: 48, second: 41, millisecond: 466, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 5, hour: 5, minute: 27, second: 47, millisecond: 529, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 8, hour: 13, minute: 18, second: 17, millisecond: 679, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 1, hour: 8, minute: 2, second: 2, millisecond: 771, kind: DateTimeKind.Utc),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1932, month: 10, day: 11, hour: 8, minute: 26, second: 38, millisecond: 285, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 4, hour: 12, minute: 3, second: 31, millisecond: 900, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 19, hour: 6, minute: 1, second: 41, millisecond: 877, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2005, month: 10, day: 4, hour: 6, minute: 34, second: 39, millisecond: 467, kind: DateTimeKind.Utc),

new DateTime(year: 1923, month: 10, day: 9, hour: 15, minute: 34, second: 20, millisecond: 661, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 16, hour: 13, minute: 23, second: 44, millisecond: 121, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1955, month: 10, day: 11, hour: 7, minute: 6, second: 9, millisecond: 626, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 7, hour: 16, minute: 58, second: 41, millisecond: 309, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 19, hour: 14, minute: 38, second: 50, millisecond: 590, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 13, hour: 7, minute: 46, second: 43, millisecond: 561, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1929, month: 10, day: 5, hour: 20, minute: 45, second: 55, millisecond: 231, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 11, hour: 19, minute: 39, second: 46, millisecond: 705, kind: DateTimeKind.Utc),

new DateTime(year: 1943, month: 10, day: 15, hour: 18, minute: 51, second: 4, millisecond: 779, kind: DateTimeKind.Utc),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1980, month: 10, day: 10, hour: 9, minute: 2, second: 24, millisecond: 834, kind: DateTimeKind.Utc),

new DateTime(year: 1982, month: 10, day: 12, hour: 2, minute: 2, second: 1, millisecond: 901, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 13, hour: 8, minute: 32, second: 29, millisecond: 13, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 9, hour: 14, minute: 37, second: 55, millisecond: 824, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1978, month: 10, day: 19, hour: 16, minute: 6, second: 30, millisecond: 979, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 18, hour: 7, minute: 47, second: 47, millisecond: 177, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 13, hour: 15, minute: 16, second: 49, millisecond: 657, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1993, month: 10, day: 1, hour: 21, minute: 54, second: 17, millisecond: 160, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 7, hour: 16, minute: 56, second: 16, millisecond: 978, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 16, hour: 3, minute: 29, second: 38, millisecond: 947, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 1, hour: 19, minute: 57, second: 50, millisecond: 852, kind: DateTimeKind.Utc),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1990, month: 10, day: 19, hour: 10, minute: 42, second: 16, millisecond: 298, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 10, hour: 21, minute: 31, second: 8, millisecond: 477, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 11, hour: 3, minute: 54, second: 2, millisecond: 843, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 18, hour: 18, minute: 43, second: 26, millisecond: 853, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1998, month: 10, day: 19, hour: 6, minute: 51, second: 1, millisecond: 291, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 3, hour: 17, minute: 18, second: 17, millisecond: 932, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 2, hour: 9, minute: 40, second: 44, millisecond: 838, kind: DateTimeKind.Utc),

new DateTime(year: 2018, month: 10, day: 15, hour: 22, minute: 51, second: 36, millisecond: 336, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1943, month: 10, day: 9, hour: 19, minute: 54, second: 33, millisecond: 452, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 9, hour: 12, minute: 36, second: 45, millisecond: 191, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 7, hour: 16, minute: 19, second: 53, millisecond: 100, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1925, month: 10, day: 11, hour: 15, minute: 42, second: 17, millisecond: 451, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 4, hour: 9, minute: 17, second: 25, millisecond: 758, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 15, hour: 18, minute: 50, second: 33, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 15, hour: 22, minute: 49, second: 55, millisecond: 962, kind: DateTimeKind.Utc),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1987, month: 10, day: 19, hour: 4, minute: 56, second: 31, millisecond: 542, kind: DateTimeKind.Utc),

new DateTime(year: 1934, month: 10, day: 4, hour: 14, minute: 35, second: 29, millisecond: 509, kind: DateTimeKind.Utc),

new DateTime(year: 1943, month: 10, day: 10, hour: 14, minute: 9, second: 23, millisecond: 805, kind: DateTimeKind.Utc),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1934, month: 10, day: 7, hour: 4, minute: 23, second: 54, millisecond: 320, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 2, hour: 19, minute: 21, second: 37, millisecond: 860, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 12, hour: 17, minute: 3, second: 39, millisecond: 94, kind: DateTimeKind.Utc),

new DateTime(year: 2018, month: 10, day: 9, hour: 11, minute: 11, second: 39, millisecond: 867, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2001, month: 10, day: 7, hour: 15, minute: 15, second: 18, millisecond: 805, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 10, hour: 16, minute: 36, second: 9, millisecond: 507, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 1, hour: 6, minute: 45, second: 52, millisecond: 186, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 3, hour: 10, minute: 39, second: 52, millisecond: 525, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1961, month: 10, day: 4, hour: 2, minute: 15, second: 35, millisecond: 763, kind: DateTimeKind.Utc),

new DateTime(year: 1990, month: 10, day: 19, hour: 16, minute: 39, second: 9, millisecond: 5, kind: DateTimeKind.Utc),

new DateTime(year: 1926, month: 10, day: 3, hour: 11, minute: 3, second: 1, millisecond: 1, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1918, month: 10, day: 8, hour: 8, minute: 33, second: 43, millisecond: 178, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 9, hour: 1, minute: 38, second: 25, millisecond: 460, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 2, hour: 21, minute: 31, second: 9, millisecond: 973, kind: DateTimeKind.Utc),

new DateTime(year: 1943, month: 10, day: 5, hour: 19, minute: 54, second: 47, millisecond: 340, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1917, month: 10, day: 3, hour: 17, minute: 44, second: 29, millisecond: 610, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 6, hour: 9, minute: 9, second: 31, millisecond: 597, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 9, hour: 18, minute: 56, second: 41, millisecond: 628, kind: DateTimeKind.Utc),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1934, month: 10, day: 10, hour: 8, minute: 29, second: 36, millisecond: 167, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 10, hour: 18, minute: 50, second: 39, millisecond: 163, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 10, hour: 13, minute: 5, second: 52, millisecond: 81, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 10, hour: 19, minute: 7, second: 2, millisecond: 180, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1979, month: 10, day: 4, hour: 6, minute: 51, second: 58, millisecond: 196, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 14, hour: 15, minute: 6, second: 27, millisecond: 372, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 14, hour: 12, minute: 26, second: 14, millisecond: 473, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1956, month: 10, day: 19, hour: 21, minute: 54, second: 58, millisecond: 523, kind: DateTimeKind.Utc),

new DateTime(year: 1918, month: 10, day: 5, hour: 15, minute: 3, second: 42, millisecond: 859, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 5, hour: 16, minute: 31, second: 1, millisecond: 84, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 8, hour: 17, minute: 50, second: 41, millisecond: 318, kind: DateTimeKind.Utc),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1942, month: 10, day: 10, hour: 18, minute: 47, second: 1, millisecond: 8, kind: DateTimeKind.Utc),

new DateTime(year: 1983, month: 10, day: 19, hour: 10, minute: 3, second: 13, millisecond: 138, kind: DateTimeKind.Utc),

new DateTime(year: 1951, month: 10, day: 13, hour: 18, minute: 36, second: 57, millisecond: 753, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 10, hour: 17, minute: 22, second: 12, millisecond: 473, kind: DateTimeKind.Utc),

},
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1946, month: 10, day: 7, hour: 11, minute: 30, second: 15, millisecond: 110, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 12, hour: 16, minute: 14, second: 9, millisecond: 972, kind: DateTimeKind.Utc),

new DateTime(year: 1990, month: 10, day: 17, hour: 19, minute: 46, second: 38, millisecond: 777, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 172,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1962, month: 10, day: 12, hour: 10, minute: 46, second: 52, millisecond: 655, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 3, hour: 6, minute: 23, second: 37, millisecond: 457, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 11, hour: 21, minute: 16, second: 44, millisecond: 155, kind: DateTimeKind.Utc),

new DateTime(year: 1923, month: 10, day: 1, hour: 19, minute: 4, second: 32, millisecond: 32, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1920, month: 10, day: 8, hour: 8, minute: 39, second: 47, millisecond: 119, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 10, hour: 19, minute: 55, second: 55, millisecond: 673, kind: DateTimeKind.Utc),

new DateTime(year: 1973, month: 10, day: 10, hour: 11, minute: 49, second: 45, millisecond: 806, kind: DateTimeKind.Utc),

new DateTime(year: 1973, month: 10, day: 17, hour: 11, minute: 6, second: 24, millisecond: 832, kind: DateTimeKind.Utc),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1937, month: 10, day: 15, hour: 12, minute: 21, second: 52, millisecond: 496, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 6, hour: 4, minute: 14, second: 11, millisecond: 905, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 5, hour: 12, minute: 6, second: 5, millisecond: 658, kind: DateTimeKind.Utc),

},
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 181,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1986, month: 10, day: 7, hour: 4, minute: 43, second: 46, millisecond: 347, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 1, hour: 20, minute: 32, second: 17, millisecond: 580, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 1, hour: 11, minute: 58, second: 4, millisecond: 809, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 4, hour: 16, minute: 11, second: 58, millisecond: 690, kind: DateTimeKind.Utc),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray2M
{
    Id = 189,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1971, month: 10, day: 14, hour: 3, minute: 45, second: 40, millisecond: 79, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 13, hour: 13, minute: 25, second: 44, millisecond: 812, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 12, hour: 22, minute: 46, second: 6, millisecond: 5, kind: DateTimeKind.Utc),

},
    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1927, month: 10, day: 16, hour: 4, minute: 3, second: 39, millisecond: 916, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 7, hour: 17, minute: 24, second: 36, millisecond: 481, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 6, hour: 18, minute: 27, second: 56, millisecond: 254, kind: DateTimeKind.Utc),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1976, month: 10, day: 2, hour: 8, minute: 24, second: 44, millisecond: 315, kind: DateTimeKind.Utc),

new DateTime(year: 2010, month: 10, day: 14, hour: 16, minute: 51, second: 42, millisecond: 129, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 1, hour: 16, minute: 1, second: 8, millisecond: 57, kind: DateTimeKind.Utc),

new DateTime(year: 1923, month: 10, day: 10, hour: 4, minute: 3, second: 16, millisecond: 588, kind: DateTimeKind.Utc),

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

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray)),
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
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray)),
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
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
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
FROM public.datetimetimestamp_with_time_zonearray2m m
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
FROM public.datetimetimestamp_with_time_zonearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                var firstItems2 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                var secondItems2 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                await ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[8],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
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
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                var firstItems2 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                await ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[9],_testData[29], false);
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

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
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
FROM public.datetimetimestamp_with_time_zonearray2m m
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
FROM public.datetimetimestamp_with_time_zonearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                var firstItems2 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                var secondItems2 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                 ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[10],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
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
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                var firstItems2 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                 ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[28],_testData[29], false);
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
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
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
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
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
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
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
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[12],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[13],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[14],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[15],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[16],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[17],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[18],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[19],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[20],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[21],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[22],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[12],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[13],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[14],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[15],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[16],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[17],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[18],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[19],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[20],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[21],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[22],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
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
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                var secondItems2 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                await ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[16],_testData[29], false);
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
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
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
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[12],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[13],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[14],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[15],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[16],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[17],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[18],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[19],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[20],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
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
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                var secondItems2 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                 ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[21],_testData[29], false);
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
            batchName: "DbConnectionSTSelectModelDynParBatch",
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
                var models = await((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 172;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[24], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[25], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[26], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[27], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[28], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[28], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[29], false);
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
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[18], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[19], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[20], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[21], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[22], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[23], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[24], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[25], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[26], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[27], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[28], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[1], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[2], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[3], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[4], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[5], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[6], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[7], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[8], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[9], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[10], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[11], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[12], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[12],_testData[13], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[13],_testData[14], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[14],_testData[15], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[15],_testData[16], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[16],_testData[17], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[17],_testData[18], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[18],_testData[19], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[19],_testData[20], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[20],_testData[21], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[21],_testData[22], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[22],_testData[23], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[23],_testData[24], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[24],_testData[25], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[25],_testData[26], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[26],_testData[27], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[27],_testData[28], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[28],_testData[29], false);
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

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray)),
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
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray)),
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
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
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
                var query2 = @"
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
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                var firstItems2 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                var secondItems2 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                await ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 45, query1, 87, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[14],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
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
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                var firstItems2 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                await ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 131, query1, 87, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[14],_testData[29], false);
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

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
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
                var query2 = @"
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
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                var firstItems2 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                var secondItems2 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                 ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 7, query1, 140, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[7],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
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
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                var firstItems2 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                 ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 95, query1, 131, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[8],_testData[29], false);
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
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
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
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
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
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
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
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 104, query1, 45, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[12],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[13],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[14],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[15],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[16],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[17],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[18],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[19],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[20],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[21],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[22],_testData[29], false);
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
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                var secondItems2 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                await ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 141, query1, 141, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[6],_testData[29], false);
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
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
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
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 13, query1, 45, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[3], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[4], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[5], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[12],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[13],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[14],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[15],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[16],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[17],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[18],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[19],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[20],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[21],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[22],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[23],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[24],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[25],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[12],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[13],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[14],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[15],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[16],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[17],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[18],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[19],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[20],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[21],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(models[22],_testData[29], false);
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
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                var secondItems2 = new List<FlatDateTimetimestamp_with_time_zoneArray2M>();
                 ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionDynQuerySelectModelBatch(connection, 116, query1, 104, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(firstItems1[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray2M.AssertModel(secondItems2[12],_testData[29], false);
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
            batchName: "DbConnectionSTSelectModelBatch",
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
        private void DbConnectionSTSelectModelBatchConfig()
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
        public async Task DbConnectionSTSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionSTSelectModelBatchAsync(connection, 55, 63))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[9], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[10], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[11], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[12], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[13], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[14], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[15], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[16], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[17], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[18], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[19], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[20], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[12],_testData[21], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[13],_testData[22], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[14],_testData[23], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[15],_testData[24], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[16],_testData[25], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[17],_testData[26], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[18],_testData[27], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[19],_testData[28], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[10], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[11], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[12], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[13], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[14], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[15], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[16], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[17], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[18], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[19], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[20], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[21], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[12],_testData[22], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[13],_testData[23], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[14],_testData[24], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[15],_testData[25], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[16],_testData[26], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[17],_testData[27], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[18],_testData[28], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[19],_testData[29], false);
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
        public async Task DbConnectionSTSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionSTSelectModelBatch(connection, 13, 172))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[3], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[4], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[5], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[6], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[7], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[8], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[9], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[10], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[11], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[12], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[13], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[14], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[12],_testData[15], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[13],_testData[16], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[14],_testData[17], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[15],_testData[18], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[16],_testData[19], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[17],_testData[20], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[18],_testData[21], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[19],_testData[22], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[20],_testData[23], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[21],_testData[24], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[22],_testData[25], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[23],_testData[26], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[24],_testData[27], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[25],_testData[28], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[28], false);
                        DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[29], false);
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
                ((IDateTimeListtimestamp_with_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 172);
                var models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[28], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateTimeListtimestamp_with_time_zoneArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateTimeListtimestamp_with_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 47);
                var models =  ((IDateTimeListtimestamp_with_time_zoneArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(22));
DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[0],_testData[8], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[1],_testData[9], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[2],_testData[10], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[3],_testData[11], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[4],_testData[12], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[5],_testData[13], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[6],_testData[14], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[7],_testData[15], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[8],_testData[16], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[9],_testData[17], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[10],_testData[18], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[11],_testData[19], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[12],_testData[20], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[13],_testData[21], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[14],_testData[22], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[15],_testData[23], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[16],_testData[24], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[17],_testData[25], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[18],_testData[26], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[19],_testData[27], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[20],_testData[28], false);DateTimetimestamp_with_time_zoneArray2M.AssertModel(models[21],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(DateTimetimestamp_with_time_zoneArray2MIWA),
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateTimetimestamp_with_time_zoneArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_with_time_zoneArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDateTimeListtimestamp_with_time_zoneArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_datetimetimestamp_with_time_zonearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<DateTimetimestamp_with_time_zoneArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_with_time_zoneArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDateTimeListtimestamp_with_time_zoneArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_datetimetimestamp_with_time_zonearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDateTimeListtimestamp_with_time_zoneArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
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
            queryMapType: typeof(DateTimetimestamp_with_time_zoneArray2MI),
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

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateTimetimestamp_with_time_zoneArray2MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDateTimeListtimestamp_with_time_zoneArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<DateTimetimestamp_with_time_zoneArray2MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDateTimeListtimestamp_with_time_zoneArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDateTimeListtimestamp_with_time_zoneArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(DateTimetimestamp_with_time_zoneArray2M),
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

        [Test, Order(5)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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

