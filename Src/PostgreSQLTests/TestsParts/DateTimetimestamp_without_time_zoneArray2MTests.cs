

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
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1981, month: 10, day: 9, hour: 10, minute: 34, second: 18, millisecond: 352, kind: DateTimeKind.Local),

new DateTime(year: 1988, month: 10, day: 18, hour: 18, minute: 33, second: 6, millisecond: 392, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 3, hour: 21, minute: 29, second: 15, millisecond: 37, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1956, month: 10, day: 7, hour: 1, minute: 22, second: 33, millisecond: 249, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 6, hour: 18, minute: 40, second: 51, millisecond: 23, kind: DateTimeKind.Local),

new DateTime(year: 1952, month: 10, day: 12, hour: 20, minute: 11, second: 13, millisecond: 847, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1974, month: 10, day: 19, hour: 22, minute: 48, second: 55, millisecond: 896, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 7, hour: 2, minute: 15, second: 2, millisecond: 42, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 18, hour: 20, minute: 29, second: 51, millisecond: 97, kind: DateTimeKind.Local),

new DateTime(year: 1994, month: 10, day: 9, hour: 18, minute: 55, second: 25, millisecond: 242, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1974, month: 10, day: 5, hour: 9, minute: 23, second: 1, millisecond: 794, kind: DateTimeKind.Local),

new DateTime(year: 2011, month: 10, day: 3, hour: 4, minute: 4, second: 46, millisecond: 382, kind: DateTimeKind.Local),

new DateTime(year: 1988, month: 10, day: 9, hour: 18, minute: 19, second: 8, millisecond: 168, kind: DateTimeKind.Local),

new DateTime(year: 2019, month: 10, day: 14, hour: 15, minute: 21, second: 50, millisecond: 625, kind: DateTimeKind.Local),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1952, month: 10, day: 14, hour: 22, minute: 53, second: 36, millisecond: 470, kind: DateTimeKind.Local),

new DateTime(year: 1984, month: 10, day: 11, hour: 3, minute: 6, second: 3, millisecond: 134, kind: DateTimeKind.Local),

new DateTime(year: 1924, month: 10, day: 14, hour: 6, minute: 9, second: 47, millisecond: 498, kind: DateTimeKind.Local),

new DateTime(year: 1999, month: 10, day: 3, hour: 5, minute: 54, second: 26, millisecond: 949, kind: DateTimeKind.Local),

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
new DateTime(year: 1971, month: 10, day: 10, hour: 5, minute: 27, second: 44, millisecond: 394, kind: DateTimeKind.Local),

new DateTime(year: 1926, month: 10, day: 2, hour: 4, minute: 15, second: 53, millisecond: 976, kind: DateTimeKind.Local),

new DateTime(year: 2001, month: 10, day: 14, hour: 4, minute: 10, second: 1, millisecond: 243, kind: DateTimeKind.Local),

new DateTime(year: 1935, month: 10, day: 5, hour: 9, minute: 41, second: 8, millisecond: 88, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1942, month: 10, day: 19, hour: 16, minute: 29, second: 37, millisecond: 582, kind: DateTimeKind.Local),

new DateTime(year: 1964, month: 10, day: 13, hour: 12, minute: 1, second: 29, millisecond: 565, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 8, hour: 21, minute: 52, second: 11, millisecond: 715, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1988, month: 10, day: 3, hour: 17, minute: 40, second: 31, millisecond: 813, kind: DateTimeKind.Local),

new DateTime(year: 2005, month: 10, day: 7, hour: 13, minute: 15, second: 34, millisecond: 948, kind: DateTimeKind.Local),

new DateTime(year: 2005, month: 10, day: 13, hour: 8, minute: 10, second: 57, millisecond: 630, kind: DateTimeKind.Local),

},
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1980, month: 10, day: 4, hour: 11, minute: 6, second: 41, millisecond: 411, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 8, hour: 9, minute: 55, second: 2, millisecond: 997, kind: DateTimeKind.Local),

new DateTime(year: 1927, month: 10, day: 2, hour: 18, minute: 17, second: 6, millisecond: 703, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1963, month: 10, day: 5, hour: 19, minute: 25, second: 56, millisecond: 161, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 2, hour: 16, minute: 50, second: 25, millisecond: 821, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 4, hour: 14, minute: 4, second: 58, millisecond: 512, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1989, month: 10, day: 5, hour: 21, minute: 51, second: 56, millisecond: 950, kind: DateTimeKind.Local),

new DateTime(year: 1992, month: 10, day: 17, hour: 1, minute: 17, second: 25, millisecond: 590, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 4, hour: 4, minute: 17, second: 10, millisecond: 636, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1930, month: 10, day: 15, hour: 13, minute: 1, second: 2, millisecond: 76, kind: DateTimeKind.Local),

new DateTime(year: 1984, month: 10, day: 6, hour: 6, minute: 39, second: 3, millisecond: 965, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 17, hour: 9, minute: 27, second: 44, millisecond: 949, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 17, hour: 19, minute: 48, second: 2, millisecond: 192, kind: DateTimeKind.Local),

},
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2008, month: 10, day: 16, hour: 4, minute: 58, second: 37, millisecond: 310, kind: DateTimeKind.Local),

new DateTime(year: 1924, month: 10, day: 12, hour: 18, minute: 56, second: 10, millisecond: 174, kind: DateTimeKind.Local),

new DateTime(year: 1985, month: 10, day: 18, hour: 20, minute: 30, second: 10, millisecond: 453, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1997, month: 10, day: 10, hour: 12, minute: 17, second: 34, millisecond: 669, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 10, hour: 11, minute: 22, second: 48, millisecond: 741, kind: DateTimeKind.Local),

new DateTime(year: 1938, month: 10, day: 6, hour: 15, minute: 7, second: 42, millisecond: 121, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 17, hour: 18, minute: 31, second: 55, millisecond: 856, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1938, month: 10, day: 8, hour: 6, minute: 11, second: 49, millisecond: 23, kind: DateTimeKind.Local),

new DateTime(year: 2012, month: 10, day: 14, hour: 21, minute: 23, second: 9, millisecond: 545, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 16, hour: 15, minute: 9, second: 1, millisecond: 112, kind: DateTimeKind.Local),

new DateTime(year: 1978, month: 10, day: 1, hour: 21, minute: 32, second: 50, millisecond: 209, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1996, month: 10, day: 2, hour: 2, minute: 27, second: 15, millisecond: 959, kind: DateTimeKind.Local),

new DateTime(year: 1999, month: 10, day: 13, hour: 7, minute: 8, second: 9, millisecond: 415, kind: DateTimeKind.Local),

new DateTime(year: 1971, month: 10, day: 11, hour: 7, minute: 51, second: 43, millisecond: 247, kind: DateTimeKind.Local),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1944, month: 10, day: 12, hour: 2, minute: 14, second: 29, millisecond: 578, kind: DateTimeKind.Local),

new DateTime(year: 1920, month: 10, day: 8, hour: 21, minute: 42, second: 33, millisecond: 120, kind: DateTimeKind.Local),

new DateTime(year: 1952, month: 10, day: 5, hour: 19, minute: 34, second: 40, millisecond: 400, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2006, month: 10, day: 17, hour: 6, minute: 32, second: 24, millisecond: 547, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 16, hour: 7, minute: 45, second: 2, millisecond: 781, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 7, hour: 9, minute: 14, second: 55, millisecond: 622, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 9, hour: 1, minute: 56, second: 27, millisecond: 779, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2010, month: 10, day: 3, hour: 20, minute: 44, second: 54, millisecond: 414, kind: DateTimeKind.Local),

new DateTime(year: 1952, month: 10, day: 10, hour: 15, minute: 50, second: 43, millisecond: 121, kind: DateTimeKind.Local),

new DateTime(year: 1922, month: 10, day: 18, hour: 13, minute: 50, second: 39, millisecond: 120, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 4, hour: 18, minute: 36, second: 45, millisecond: 644, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 16, hour: 15, minute: 39, second: 56, millisecond: 491, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 15, hour: 6, minute: 47, second: 9, millisecond: 211, kind: DateTimeKind.Local),

},
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1985, month: 10, day: 19, hour: 18, minute: 6, second: 22, millisecond: 625, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 4, hour: 18, minute: 27, second: 2, millisecond: 966, kind: DateTimeKind.Local),

new DateTime(year: 1924, month: 10, day: 8, hour: 17, minute: 58, second: 38, millisecond: 71, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1936, month: 10, day: 13, hour: 16, minute: 29, second: 7, millisecond: 728, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 8, hour: 21, minute: 44, second: 15, millisecond: 730, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 5, hour: 18, minute: 19, second: 20, millisecond: 458, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2011, month: 10, day: 15, hour: 21, minute: 41, second: 46, millisecond: 789, kind: DateTimeKind.Local),

new DateTime(year: 2016, month: 10, day: 7, hour: 7, minute: 13, second: 55, millisecond: 610, kind: DateTimeKind.Local),

new DateTime(year: 1930, month: 10, day: 5, hour: 22, minute: 30, second: 19, millisecond: 103, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1982, month: 10, day: 12, hour: 8, minute: 13, second: 50, millisecond: 243, kind: DateTimeKind.Local),

new DateTime(year: 1977, month: 10, day: 1, hour: 7, minute: 8, second: 57, millisecond: 647, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 1, hour: 20, minute: 27, second: 56, millisecond: 475, kind: DateTimeKind.Local),

new DateTime(year: 1991, month: 10, day: 4, hour: 15, minute: 27, second: 16, millisecond: 643, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1942, month: 10, day: 18, hour: 17, minute: 29, second: 37, millisecond: 55, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 13, hour: 11, minute: 35, second: 21, millisecond: 707, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 17, hour: 1, minute: 45, second: 24, millisecond: 78, kind: DateTimeKind.Local),

},
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1923, month: 10, day: 13, hour: 12, minute: 30, second: 46, millisecond: 839, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 18, hour: 11, minute: 55, second: 36, millisecond: 915, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 4, hour: 16, minute: 3, second: 30, millisecond: 525, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1968, month: 10, day: 4, hour: 13, minute: 27, second: 48, millisecond: 717, kind: DateTimeKind.Local),

new DateTime(year: 1993, month: 10, day: 18, hour: 16, minute: 39, second: 50, millisecond: 113, kind: DateTimeKind.Local),

new DateTime(year: 1933, month: 10, day: 5, hour: 6, minute: 51, second: 26, millisecond: 652, kind: DateTimeKind.Local),

new DateTime(year: 2004, month: 10, day: 17, hour: 4, minute: 25, second: 50, millisecond: 42, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1991, month: 10, day: 15, hour: 17, minute: 5, second: 28, millisecond: 667, kind: DateTimeKind.Local),

new DateTime(year: 1942, month: 10, day: 9, hour: 19, minute: 46, second: 43, millisecond: 345, kind: DateTimeKind.Local),

new DateTime(year: 1956, month: 10, day: 6, hour: 14, minute: 58, second: 31, millisecond: 951, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1977, month: 10, day: 11, hour: 7, minute: 34, second: 56, millisecond: 791, kind: DateTimeKind.Local),

new DateTime(year: 2011, month: 10, day: 1, hour: 22, minute: 17, second: 30, millisecond: 691, kind: DateTimeKind.Local),

new DateTime(year: 2007, month: 10, day: 9, hour: 3, minute: 44, second: 22, millisecond: 645, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 2, hour: 10, minute: 13, second: 20, millisecond: 459, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2011, month: 10, day: 16, hour: 14, minute: 41, second: 45, millisecond: 383, kind: DateTimeKind.Local),

new DateTime(year: 2018, month: 10, day: 6, hour: 3, minute: 44, second: 31, millisecond: 137, kind: DateTimeKind.Local),

new DateTime(year: 1938, month: 10, day: 1, hour: 17, minute: 8, second: 15, millisecond: 286, kind: DateTimeKind.Local),

new DateTime(year: 1967, month: 10, day: 14, hour: 17, minute: 48, second: 4, millisecond: 361, kind: DateTimeKind.Local),

},
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1926, month: 10, day: 8, hour: 12, minute: 1, second: 42, millisecond: 212, kind: DateTimeKind.Local),

new DateTime(year: 2005, month: 10, day: 6, hour: 20, minute: 54, second: 46, millisecond: 966, kind: DateTimeKind.Local),

new DateTime(year: 1918, month: 10, day: 1, hour: 1, minute: 5, second: 26, millisecond: 237, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2008, month: 10, day: 13, hour: 20, minute: 54, second: 9, millisecond: 131, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 18, hour: 12, minute: 3, second: 33, millisecond: 890, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 11, hour: 14, minute: 16, second: 57, millisecond: 437, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 11, hour: 15, minute: 26, second: 30, millisecond: 585, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1976, month: 10, day: 8, hour: 8, minute: 27, second: 6, millisecond: 35, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 14, hour: 2, minute: 47, second: 22, millisecond: 106, kind: DateTimeKind.Local),

new DateTime(year: 1921, month: 10, day: 17, hour: 1, minute: 4, second: 24, millisecond: 720, kind: DateTimeKind.Local),

new DateTime(year: 1920, month: 10, day: 7, hour: 9, minute: 5, second: 48, millisecond: 752, kind: DateTimeKind.Local),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2017, month: 10, day: 1, hour: 5, minute: 55, second: 37, millisecond: 871, kind: DateTimeKind.Local),

new DateTime(year: 1960, month: 10, day: 10, hour: 6, minute: 52, second: 53, millisecond: 723, kind: DateTimeKind.Local),

new DateTime(year: 2009, month: 10, day: 9, hour: 15, minute: 46, second: 40, millisecond: 33, kind: DateTimeKind.Local),

new DateTime(year: 1953, month: 10, day: 12, hour: 11, minute: 8, second: 26, millisecond: 709, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1991, month: 10, day: 1, hour: 20, minute: 40, second: 57, millisecond: 541, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 5, hour: 11, minute: 27, second: 57, millisecond: 46, kind: DateTimeKind.Local),

new DateTime(year: 1952, month: 10, day: 16, hour: 4, minute: 19, second: 43, millisecond: 483, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 13, hour: 14, minute: 2, second: 50, millisecond: 187, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2012, month: 10, day: 8, hour: 18, minute: 42, second: 39, millisecond: 531, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 9, hour: 6, minute: 19, second: 18, millisecond: 702, kind: DateTimeKind.Local),

new DateTime(year: 2018, month: 10, day: 1, hour: 1, minute: 5, second: 39, millisecond: 155, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1942, month: 10, day: 16, hour: 18, minute: 36, second: 34, millisecond: 467, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 16, hour: 9, minute: 18, second: 46, millisecond: 181, kind: DateTimeKind.Local),

new DateTime(year: 1978, month: 10, day: 18, hour: 10, minute: 49, second: 5, millisecond: 142, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 12, hour: 20, minute: 57, second: 45, millisecond: 626, kind: DateTimeKind.Local),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1976, month: 10, day: 17, hour: 7, minute: 13, second: 47, millisecond: 371, kind: DateTimeKind.Local),

new DateTime(year: 1994, month: 10, day: 18, hour: 4, minute: 23, second: 56, millisecond: 627, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 1, hour: 20, minute: 17, second: 31, millisecond: 962, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1982, month: 10, day: 1, hour: 11, minute: 38, second: 30, millisecond: 184, kind: DateTimeKind.Local),

new DateTime(year: 1992, month: 10, day: 13, hour: 12, minute: 32, second: 18, millisecond: 929, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 11, hour: 16, minute: 40, second: 46, millisecond: 597, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1949, month: 10, day: 4, hour: 15, minute: 28, second: 28, millisecond: 863, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 2, hour: 17, minute: 49, second: 43, millisecond: 702, kind: DateTimeKind.Local),

new DateTime(year: 1940, month: 10, day: 15, hour: 8, minute: 42, second: 21, millisecond: 459, kind: DateTimeKind.Local),

new DateTime(year: 1985, month: 10, day: 5, hour: 6, minute: 45, second: 32, millisecond: 922, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2013, month: 10, day: 10, hour: 19, minute: 31, second: 21, millisecond: 429, kind: DateTimeKind.Local),

new DateTime(year: 1934, month: 10, day: 6, hour: 20, minute: 3, second: 12, millisecond: 253, kind: DateTimeKind.Local),

new DateTime(year: 1933, month: 10, day: 2, hour: 8, minute: 4, second: 45, millisecond: 705, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 10, hour: 5, minute: 31, second: 41, millisecond: 592, kind: DateTimeKind.Local),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1925, month: 10, day: 8, hour: 20, minute: 58, second: 33, millisecond: 672, kind: DateTimeKind.Local),

new DateTime(year: 1936, month: 10, day: 15, hour: 6, minute: 57, second: 45, millisecond: 835, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 6, hour: 9, minute: 9, second: 9, millisecond: 929, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 19, hour: 6, minute: 31, second: 49, millisecond: 885, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1963, month: 10, day: 5, hour: 5, minute: 57, second: 4, millisecond: 206, kind: DateTimeKind.Local),

new DateTime(year: 1953, month: 10, day: 11, hour: 12, minute: 52, second: 46, millisecond: 724, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 14, hour: 20, minute: 52, second: 39, millisecond: 18, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2011, month: 10, day: 6, hour: 11, minute: 37, second: 50, millisecond: 108, kind: DateTimeKind.Local),

new DateTime(year: 1957, month: 10, day: 14, hour: 15, minute: 25, second: 49, millisecond: 365, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 16, hour: 11, minute: 44, second: 1, millisecond: 61, kind: DateTimeKind.Local),

new DateTime(year: 1921, month: 10, day: 5, hour: 22, minute: 19, second: 44, millisecond: 58, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 18, hour: 1, minute: 15, second: 29, millisecond: 985, kind: DateTimeKind.Local),

new DateTime(year: 1986, month: 10, day: 11, hour: 3, minute: 32, second: 1, millisecond: 445, kind: DateTimeKind.Local),

new DateTime(year: 1952, month: 10, day: 12, hour: 7, minute: 21, second: 37, millisecond: 542, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1993, month: 10, day: 16, hour: 5, minute: 16, second: 34, millisecond: 609, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 14, hour: 10, minute: 49, second: 2, millisecond: 259, kind: DateTimeKind.Local),

new DateTime(year: 1931, month: 10, day: 3, hour: 1, minute: 32, second: 20, millisecond: 332, kind: DateTimeKind.Local),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2006, month: 10, day: 1, hour: 3, minute: 19, second: 20, millisecond: 998, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 7, hour: 11, minute: 43, second: 27, millisecond: 948, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 11, hour: 1, minute: 1, second: 55, millisecond: 629, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2014, month: 10, day: 14, hour: 15, minute: 48, second: 6, millisecond: 219, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 3, hour: 1, minute: 46, second: 34, millisecond: 442, kind: DateTimeKind.Local),

new DateTime(year: 1987, month: 10, day: 16, hour: 22, minute: 14, second: 8, millisecond: 459, kind: DateTimeKind.Local),

new DateTime(year: 1923, month: 10, day: 13, hour: 15, minute: 30, second: 48, millisecond: 674, kind: DateTimeKind.Local),

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
new DateTime(year: 1970, month: 10, day: 8, hour: 6, minute: 24, second: 36, millisecond: 583, kind: DateTimeKind.Local),

new DateTime(year: 1930, month: 10, day: 17, hour: 15, minute: 47, second: 32, millisecond: 741, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 1, hour: 4, minute: 41, second: 28, millisecond: 465, kind: DateTimeKind.Local),

new DateTime(year: 2001, month: 10, day: 16, hour: 10, minute: 57, second: 41, millisecond: 1, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1930, month: 10, day: 10, hour: 1, minute: 51, second: 36, millisecond: 175, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 7, hour: 21, minute: 42, second: 31, millisecond: 603, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 16, hour: 16, minute: 48, second: 47, millisecond: 178, kind: DateTimeKind.Local),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1940, month: 10, day: 12, hour: 13, minute: 34, second: 8, millisecond: 694, kind: DateTimeKind.Local),

new DateTime(year: 1937, month: 10, day: 16, hour: 12, minute: 20, second: 51, millisecond: 458, kind: DateTimeKind.Local),

new DateTime(year: 1924, month: 10, day: 19, hour: 20, minute: 57, second: 18, millisecond: 835, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 14, hour: 7, minute: 46, second: 39, millisecond: 684, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1954, month: 10, day: 13, hour: 11, minute: 44, second: 21, millisecond: 573, kind: DateTimeKind.Local),

new DateTime(year: 1991, month: 10, day: 3, hour: 15, minute: 51, second: 32, millisecond: 919, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 6, hour: 13, minute: 18, second: 33, millisecond: 951, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2000, month: 10, day: 8, hour: 20, minute: 40, second: 32, millisecond: 54, kind: DateTimeKind.Local),

new DateTime(year: 1920, month: 10, day: 5, hour: 13, minute: 20, second: 40, millisecond: 239, kind: DateTimeKind.Local),

new DateTime(year: 1937, month: 10, day: 4, hour: 8, minute: 57, second: 35, millisecond: 979, kind: DateTimeKind.Local),

new DateTime(year: 1933, month: 10, day: 7, hour: 8, minute: 21, second: 34, millisecond: 455, kind: DateTimeKind.Local),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1998, month: 10, day: 5, hour: 18, minute: 8, second: 35, millisecond: 579, kind: DateTimeKind.Local),

new DateTime(year: 1983, month: 10, day: 8, hour: 14, minute: 28, second: 17, millisecond: 719, kind: DateTimeKind.Local),

new DateTime(year: 1923, month: 10, day: 10, hour: 1, minute: 52, second: 51, millisecond: 384, kind: DateTimeKind.Local),

new DateTime(year: 1920, month: 10, day: 18, hour: 16, minute: 43, second: 15, millisecond: 787, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1997, month: 10, day: 15, hour: 5, minute: 5, second: 14, millisecond: 859, kind: DateTimeKind.Local),

new DateTime(year: 1993, month: 10, day: 13, hour: 10, minute: 15, second: 1, millisecond: 525, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 8, hour: 9, minute: 38, second: 11, millisecond: 323, kind: DateTimeKind.Local),

new DateTime(year: 1936, month: 10, day: 11, hour: 11, minute: 13, second: 57, millisecond: 729, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2011, month: 10, day: 14, hour: 20, minute: 21, second: 36, millisecond: 39, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 2, hour: 3, minute: 4, second: 30, millisecond: 583, kind: DateTimeKind.Local),

new DateTime(year: 2008, month: 10, day: 8, hour: 15, minute: 28, second: 36, millisecond: 898, kind: DateTimeKind.Local),

new DateTime(year: 1944, month: 10, day: 4, hour: 3, minute: 4, second: 47, millisecond: 103, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1996, month: 10, day: 9, hour: 4, minute: 34, second: 48, millisecond: 923, kind: DateTimeKind.Local),

new DateTime(year: 1964, month: 10, day: 2, hour: 4, minute: 14, second: 3, millisecond: 60, kind: DateTimeKind.Local),

new DateTime(year: 1972, month: 10, day: 11, hour: 17, minute: 15, second: 24, millisecond: 121, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1924, month: 10, day: 17, hour: 19, minute: 5, second: 32, millisecond: 920, kind: DateTimeKind.Local),

new DateTime(year: 1921, month: 10, day: 2, hour: 17, minute: 24, second: 6, millisecond: 254, kind: DateTimeKind.Local),

new DateTime(year: 2007, month: 10, day: 3, hour: 11, minute: 57, second: 41, millisecond: 335, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1941, month: 10, day: 13, hour: 4, minute: 2, second: 1, millisecond: 516, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 8, hour: 8, minute: 48, second: 52, millisecond: 391, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 1, hour: 3, minute: 16, second: 58, millisecond: 504, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 2, hour: 16, minute: 32, second: 40, millisecond: 86, kind: DateTimeKind.Local),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1942, month: 10, day: 7, hour: 4, minute: 47, second: 33, millisecond: 909, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 9, hour: 10, minute: 4, second: 42, millisecond: 447, kind: DateTimeKind.Local),

new DateTime(year: 1983, month: 10, day: 18, hour: 9, minute: 1, second: 9, millisecond: 804, kind: DateTimeKind.Local),

new DateTime(year: 1994, month: 10, day: 5, hour: 11, minute: 39, second: 19, millisecond: 437, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1990, month: 10, day: 14, hour: 2, minute: 49, second: 5, millisecond: 790, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 9, hour: 14, minute: 22, second: 48, millisecond: 624, kind: DateTimeKind.Local),

new DateTime(year: 1937, month: 10, day: 10, hour: 17, minute: 36, second: 54, millisecond: 881, kind: DateTimeKind.Local),

new DateTime(year: 1940, month: 10, day: 3, hour: 17, minute: 51, second: 10, millisecond: 283, kind: DateTimeKind.Local),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2002, month: 10, day: 10, hour: 12, minute: 40, second: 18, millisecond: 397, kind: DateTimeKind.Local),

new DateTime(year: 1942, month: 10, day: 10, hour: 11, minute: 22, second: 14, millisecond: 180, kind: DateTimeKind.Local),

new DateTime(year: 1922, month: 10, day: 19, hour: 21, minute: 15, second: 47, millisecond: 74, kind: DateTimeKind.Local),

new DateTime(year: 1924, month: 10, day: 14, hour: 11, minute: 40, second: 37, millisecond: 655, kind: DateTimeKind.Local),

},
},
            new DateTimetimestamp_without_time_zoneArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1932, month: 10, day: 15, hour: 9, minute: 31, second: 22, millisecond: 346, kind: DateTimeKind.Local),

new DateTime(year: 1923, month: 10, day: 14, hour: 13, minute: 19, second: 10, millisecond: 766, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 11, hour: 18, minute: 15, second: 46, millisecond: 498, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 10, hour: 7, minute: 19, second: 28, millisecond: 492, kind: DateTimeKind.Local),

},
    ModelInner = new DateTimetimestamp_without_time_zoneArray2MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1978, month: 10, day: 11, hour: 8, minute: 23, second: 37, millisecond: 566, kind: DateTimeKind.Local),

new DateTime(year: 2009, month: 10, day: 4, hour: 14, minute: 6, second: 38, millisecond: 550, kind: DateTimeKind.Local),

new DateTime(year: 1924, month: 10, day: 15, hour: 14, minute: 20, second: 28, millisecond: 557, kind: DateTimeKind.Local),

},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1926, month: 10, day: 4, hour: 19, minute: 15, second: 44, millisecond: 362, kind: DateTimeKind.Local),

new DateTime(year: 1930, month: 10, day: 13, hour: 20, minute: 23, second: 12, millisecond: 229, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 5, hour: 12, minute: 22, second: 5, millisecond: 1, kind: DateTimeKind.Local),

new DateTime(year: 1999, month: 10, day: 18, hour: 13, minute: 37, second: 16, millisecond: 465, kind: DateTimeKind.Local),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1941, month: 10, day: 13, hour: 18, minute: 41, second: 52, millisecond: 61, kind: DateTimeKind.Local),

new DateTime(year: 1942, month: 10, day: 8, hour: 12, minute: 40, second: 12, millisecond: 167, kind: DateTimeKind.Local),

new DateTime(year: 2014, month: 10, day: 9, hour: 21, minute: 8, second: 8, millisecond: 958, kind: DateTimeKind.Local),

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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[16],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[13],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
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
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[8],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
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
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[25],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
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
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[17],_testData[29], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[5],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
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
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[17],_testData[29], false);
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[14],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[12], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[13], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[14], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[15], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[16], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[17], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[18], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[19], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[20], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[21], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[22], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[23], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[24], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[25], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[26], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[27], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[28], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[13], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[14], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[15], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[16], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[17], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[18], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[19], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[20], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[21], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[22], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[23], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[24], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[25], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[26], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[27], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[28], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[29], false);
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
                await ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 5, query1, 83, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[13],_testData[29], false);
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
                await ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 75, query1, 54, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[17],_testData[29], false);
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
                 ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 9, query1, 13, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[25],_testData[29], false);
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
                 ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 114, query1, 120, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[29], false);
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
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 112, query1, 9, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[3], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[17],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[18],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[19],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[20],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[21],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[22],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[23],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[24],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[25],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[26],_testData[29], false);
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
                await ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 101, query1, 75, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[14],_testData[29], false);
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
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 91, query1, 109, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[29], false);
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
                 ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatch(connection, 101, query1, 40, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(firstItems1[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray2M.AssertModel(secondItems2[21],_testData[29], false);
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
                foreach(var batchResult in await ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSTSelectModelBatchAsync(connection, 120, 75))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[25], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[26], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[27], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[28], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[15], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[16], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[17], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[18], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[19], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[20], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[21], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[22], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[23], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[24], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[25], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[26], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[27], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[28], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[29], false);
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
                foreach(var batchResult in  ((IDateTimeListtimestamp_without_time_zoneArray)this).DbConnectionSTSelectModelBatch(connection, 54, 138))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[12], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[13], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[14], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[15], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[16], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[17], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[18], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[19], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[20], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[21], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[22], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[23], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[24], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[25], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[26], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[27], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[28], false);
                        DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[17],_testData[29], false);
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

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IDateTimeListtimestamp_without_time_zoneArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDateTimeListtimestamp_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 53);
                var models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(19));
DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[11], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[12], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[13], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[14], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[15], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[16], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[17], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[18], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[19], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[20], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[21], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[22], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[23], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[24], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[25], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[26], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[27], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[17],_testData[28], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[18],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateTimeListtimestamp_without_time_zoneArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateTimeListtimestamp_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 32);
                var models =  ((IDateTimeListtimestamp_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[0],_testData[7], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[1],_testData[8], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[2],_testData[9], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[3],_testData[10], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[4],_testData[11], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[5],_testData[12], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[6],_testData[13], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[7],_testData[14], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[8],_testData[15], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[9],_testData[16], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[10],_testData[17], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[11],_testData[18], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[12],_testData[19], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[13],_testData[20], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[14],_testData[21], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[15],_testData[22], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[16],_testData[23], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[17],_testData[24], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[18],_testData[25], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[19],_testData[26], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[20],_testData[27], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[21],_testData[28], false);DateTimetimestamp_without_time_zoneArray2M.AssertModel(models[22],_testData[29], false);
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
FROM public.binary_datetimetimestamp_without_time_zonearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_without_time_zoneArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(DateTimetimestamp_without_time_zoneArray2MIWA),
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateTimetimestamp_without_time_zoneArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_without_time_zoneArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDateTimeListtimestamp_without_time_zoneArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_datetimetimestamp_without_time_zonearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DateTimetimestamp_without_time_zoneArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_without_time_zoneArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDateTimeListtimestamp_without_time_zoneArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_datetimetimestamp_without_time_zonearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDateTimeListtimestamp_without_time_zoneArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray2MIWA.AssertModel(actual, expect, false);
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
            queryMapType: typeof(DateTimetimestamp_without_time_zoneArray2MI),
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

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateTimetimestamp_without_time_zoneArray2MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDateTimeListtimestamp_without_time_zoneArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<DateTimetimestamp_without_time_zoneArray2MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDateTimeListtimestamp_without_time_zoneArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDateTimeListtimestamp_without_time_zoneArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(DateTimetimestamp_without_time_zoneArray2M),
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

        [Test, Order(5)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray2MIWA)],
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
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateTimeListtimestamp_without_time_zoneArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_datetimetimestamp_without_time_zonearray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((IDateTimeListtimestamp_without_time_zoneArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_datetimetimestamp_without_time_zonearray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

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

        [Test, Order(6)]
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

        [Test, Order(6)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((IDateTimeListtimestamp_without_time_zoneArray)this).ExportModelInner(connection).ToList();
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

