

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
    internal partial interface IDateTimeArraytimestamp_with_time_zoneArray
    {
    }
    
    internal partial class DateTimeArraytimestamp_with_time_zoneArray : IDateTimeArraytimestamp_with_time_zoneArray
    {


#region TestData

        private readonly DateTimetimestamp_with_time_zoneArray1M[] _testData = new DateTimetimestamp_with_time_zoneArray1M[]
        {
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 5,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1957, month: 10, day: 17, hour: 18, minute: 35, second: 36, millisecond: 535, kind: DateTimeKind.Utc),
new DateTime(year: 1958, month: 10, day: 3, hour: 13, minute: 29, second: 6, millisecond: 886, kind: DateTimeKind.Utc),
new DateTime(year: 2014, month: 10, day: 15, hour: 3, minute: 16, second: 8, millisecond: 443, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 12,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1950, month: 10, day: 1, hour: 10, minute: 19, second: 49, millisecond: 465, kind: DateTimeKind.Utc),
new DateTime(year: 1918, month: 10, day: 6, hour: 7, minute: 35, second: 25, millisecond: 750, kind: DateTimeKind.Utc),
new DateTime(year: 2017, month: 10, day: 13, hour: 5, minute: 47, second: 34, millisecond: 32, kind: DateTimeKind.Utc),
new DateTime(year: 1959, month: 10, day: 3, hour: 3, minute: 50, second: 27, millisecond: 716, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 9,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1924, month: 10, day: 3, hour: 10, minute: 1, second: 8, millisecond: 876, kind: DateTimeKind.Utc),
new DateTime(year: 1969, month: 10, day: 11, hour: 9, minute: 3, second: 8, millisecond: 555, kind: DateTimeKind.Utc),
new DateTime(year: 1986, month: 10, day: 1, hour: 21, minute: 27, second: 47, millisecond: 457, kind: DateTimeKind.Utc),
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 2019, month: 10, day: 2, hour: 21, minute: 40, second: 1, millisecond: 521, kind: DateTimeKind.Utc),
new DateTime(year: 2000, month: 10, day: 18, hour: 2, minute: 51, second: 37, millisecond: 855, kind: DateTimeKind.Utc),
new DateTime(year: 1917, month: 10, day: 9, hour: 9, minute: 46, second: 32, millisecond: 424, kind: DateTimeKind.Utc),
new DateTime(year: 2015, month: 10, day: 6, hour: 10, minute: 1, second: 43, millisecond: 694, kind: DateTimeKind.Utc),
},
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 2001, month: 10, day: 18, hour: 5, minute: 33, second: 3, millisecond: 664, kind: DateTimeKind.Utc),
new DateTime(year: 1987, month: 10, day: 17, hour: 14, minute: 37, second: 4, millisecond: 629, kind: DateTimeKind.Utc),
new DateTime(year: 1981, month: 10, day: 14, hour: 21, minute: 12, second: 7, millisecond: 288, kind: DateTimeKind.Utc),
new DateTime(year: 1997, month: 10, day: 5, hour: 8, minute: 18, second: 34, millisecond: 44, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 15,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1979, month: 10, day: 19, hour: 8, minute: 30, second: 48, millisecond: 483, kind: DateTimeKind.Utc),
new DateTime(year: 2014, month: 10, day: 19, hour: 13, minute: 48, second: 19, millisecond: 997, kind: DateTimeKind.Utc),
new DateTime(year: 1953, month: 10, day: 9, hour: 21, minute: 18, second: 15, millisecond: 667, kind: DateTimeKind.Utc),
new DateTime(year: 1962, month: 10, day: 3, hour: 8, minute: 29, second: 7, millisecond: 624, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 2016, month: 10, day: 6, hour: 14, minute: 55, second: 56, millisecond: 322, kind: DateTimeKind.Utc),
new DateTime(year: 1959, month: 10, day: 7, hour: 4, minute: 42, second: 49, millisecond: 514, kind: DateTimeKind.Utc),
new DateTime(year: 1973, month: 10, day: 18, hour: 11, minute: 35, second: 13, millisecond: 637, kind: DateTimeKind.Utc),
new DateTime(year: 1991, month: 10, day: 2, hour: 4, minute: 47, second: 21, millisecond: 472, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 20,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1989, month: 10, day: 4, hour: 2, minute: 2, second: 36, millisecond: 559, kind: DateTimeKind.Utc),
new DateTime(year: 2006, month: 10, day: 11, hour: 11, minute: 31, second: 56, millisecond: 546, kind: DateTimeKind.Utc),
new DateTime(year: 1920, month: 10, day: 1, hour: 15, minute: 52, second: 6, millisecond: 283, kind: DateTimeKind.Utc),
new DateTime(year: 2014, month: 10, day: 3, hour: 20, minute: 1, second: 39, millisecond: 430, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 12,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1945, month: 10, day: 12, hour: 22, minute: 35, second: 56, millisecond: 466, kind: DateTimeKind.Utc),
new DateTime(year: 1920, month: 10, day: 6, hour: 6, minute: 53, second: 50, millisecond: 81, kind: DateTimeKind.Utc),
new DateTime(year: 2008, month: 10, day: 3, hour: 4, minute: 6, second: 5, millisecond: 333, kind: DateTimeKind.Utc),
},
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1943, month: 10, day: 11, hour: 14, minute: 47, second: 45, millisecond: 501, kind: DateTimeKind.Utc),
new DateTime(year: 1936, month: 10, day: 5, hour: 21, minute: 51, second: 22, millisecond: 861, kind: DateTimeKind.Utc),
new DateTime(year: 1988, month: 10, day: 19, hour: 7, minute: 10, second: 26, millisecond: 85, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 29,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1993, month: 10, day: 15, hour: 2, minute: 57, second: 6, millisecond: 472, kind: DateTimeKind.Utc),
new DateTime(year: 1919, month: 10, day: 18, hour: 18, minute: 27, second: 33, millisecond: 96, kind: DateTimeKind.Utc),
new DateTime(year: 1993, month: 10, day: 3, hour: 15, minute: 56, second: 24, millisecond: 435, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1976, month: 10, day: 12, hour: 8, minute: 46, second: 16, millisecond: 421, kind: DateTimeKind.Utc),
new DateTime(year: 2008, month: 10, day: 9, hour: 17, minute: 18, second: 21, millisecond: 284, kind: DateTimeKind.Utc),
new DateTime(year: 1984, month: 10, day: 3, hour: 17, minute: 12, second: 7, millisecond: 626, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 31,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1917, month: 10, day: 17, hour: 14, minute: 58, second: 7, millisecond: 87, kind: DateTimeKind.Utc),
new DateTime(year: 1932, month: 10, day: 9, hour: 16, minute: 15, second: 43, millisecond: 102, kind: DateTimeKind.Utc),
new DateTime(year: 1918, month: 10, day: 12, hour: 13, minute: 27, second: 58, millisecond: 298, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 21,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1917, month: 10, day: 3, hour: 14, minute: 30, second: 38, millisecond: 75, kind: DateTimeKind.Utc),
new DateTime(year: 1983, month: 10, day: 3, hour: 14, minute: 20, second: 5, millisecond: 195, kind: DateTimeKind.Utc),
new DateTime(year: 1939, month: 10, day: 5, hour: 7, minute: 1, second: 11, millisecond: 780, kind: DateTimeKind.Utc),
},
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 2010, month: 10, day: 14, hour: 16, minute: 1, second: 56, millisecond: 409, kind: DateTimeKind.Utc),
new DateTime(year: 2004, month: 10, day: 13, hour: 17, minute: 31, second: 52, millisecond: 573, kind: DateTimeKind.Utc),
new DateTime(year: 1917, month: 10, day: 2, hour: 14, minute: 9, second: 58, millisecond: 291, kind: DateTimeKind.Utc),
new DateTime(year: 1968, month: 10, day: 1, hour: 11, minute: 2, second: 2, millisecond: 57, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 35,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1988, month: 10, day: 17, hour: 22, minute: 24, second: 7, millisecond: 847, kind: DateTimeKind.Utc),
new DateTime(year: 1999, month: 10, day: 17, hour: 22, minute: 15, second: 6, millisecond: 729, kind: DateTimeKind.Utc),
new DateTime(year: 1924, month: 10, day: 3, hour: 19, minute: 50, second: 2, millisecond: 231, kind: DateTimeKind.Utc),
new DateTime(year: 1986, month: 10, day: 6, hour: 18, minute: 18, second: 14, millisecond: 997, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 36,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1982, month: 10, day: 14, hour: 7, minute: 26, second: 41, millisecond: 134, kind: DateTimeKind.Utc),
new DateTime(year: 2017, month: 10, day: 1, hour: 21, minute: 2, second: 7, millisecond: 636, kind: DateTimeKind.Utc),
new DateTime(year: 1928, month: 10, day: 7, hour: 11, minute: 21, second: 37, millisecond: 725, kind: DateTimeKind.Utc),
new DateTime(year: 1984, month: 10, day: 17, hour: 18, minute: 9, second: 55, millisecond: 610, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 23,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1988, month: 10, day: 7, hour: 17, minute: 38, second: 16, millisecond: 319, kind: DateTimeKind.Utc),
new DateTime(year: 1991, month: 10, day: 2, hour: 3, minute: 46, second: 41, millisecond: 847, kind: DateTimeKind.Utc),
new DateTime(year: 1933, month: 10, day: 3, hour: 18, minute: 4, second: 48, millisecond: 649, kind: DateTimeKind.Utc),
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1967, month: 10, day: 16, hour: 17, minute: 31, second: 24, millisecond: 906, kind: DateTimeKind.Utc),
new DateTime(year: 2018, month: 10, day: 12, hour: 3, minute: 28, second: 23, millisecond: 286, kind: DateTimeKind.Utc),
new DateTime(year: 2005, month: 10, day: 5, hour: 1, minute: 48, second: 12, millisecond: 584, kind: DateTimeKind.Utc),
},
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1948, month: 10, day: 15, hour: 22, minute: 37, second: 18, millisecond: 494, kind: DateTimeKind.Utc),
new DateTime(year: 1936, month: 10, day: 3, hour: 1, minute: 13, second: 50, millisecond: 246, kind: DateTimeKind.Utc),
new DateTime(year: 1927, month: 10, day: 3, hour: 6, minute: 9, second: 30, millisecond: 596, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 42,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1971, month: 10, day: 7, hour: 4, minute: 8, second: 2, millisecond: 476, kind: DateTimeKind.Utc),
new DateTime(year: 1946, month: 10, day: 8, hour: 6, minute: 16, second: 49, millisecond: 744, kind: DateTimeKind.Utc),
new DateTime(year: 2009, month: 10, day: 9, hour: 22, minute: 32, second: 7, millisecond: 729, kind: DateTimeKind.Utc),
new DateTime(year: 1982, month: 10, day: 3, hour: 13, minute: 9, second: 58, millisecond: 214, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1970, month: 10, day: 15, hour: 13, minute: 44, second: 27, millisecond: 16, kind: DateTimeKind.Utc),
new DateTime(year: 1982, month: 10, day: 11, hour: 14, minute: 8, second: 27, millisecond: 221, kind: DateTimeKind.Utc),
new DateTime(year: 1975, month: 10, day: 6, hour: 10, minute: 16, second: 22, millisecond: 486, kind: DateTimeKind.Utc),
new DateTime(year: 1940, month: 10, day: 18, hour: 16, minute: 36, second: 2, millisecond: 156, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 44,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1933, month: 10, day: 12, hour: 3, minute: 50, second: 58, millisecond: 194, kind: DateTimeKind.Utc),
new DateTime(year: 2003, month: 10, day: 15, hour: 12, minute: 13, second: 18, millisecond: 85, kind: DateTimeKind.Utc),
new DateTime(year: 1970, month: 10, day: 14, hour: 13, minute: 29, second: 13, millisecond: 677, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 32,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1939, month: 10, day: 3, hour: 11, minute: 15, second: 3, millisecond: 680, kind: DateTimeKind.Utc),
new DateTime(year: 1930, month: 10, day: 16, hour: 16, minute: 48, second: 3, millisecond: 45, kind: DateTimeKind.Utc),
new DateTime(year: 1980, month: 10, day: 6, hour: 5, minute: 42, second: 33, millisecond: 527, kind: DateTimeKind.Utc),
new DateTime(year: 2012, month: 10, day: 6, hour: 2, minute: 3, second: 58, millisecond: 454, kind: DateTimeKind.Utc),
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1961, month: 10, day: 8, hour: 4, minute: 5, second: 30, millisecond: 334, kind: DateTimeKind.Utc),
new DateTime(year: 1996, month: 10, day: 7, hour: 4, minute: 46, second: 18, millisecond: 605, kind: DateTimeKind.Utc),
new DateTime(year: 2003, month: 10, day: 8, hour: 4, minute: 53, second: 14, millisecond: 312, kind: DateTimeKind.Utc),
},
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1971, month: 10, day: 14, hour: 20, minute: 19, second: 47, millisecond: 757, kind: DateTimeKind.Utc),
new DateTime(year: 1982, month: 10, day: 14, hour: 8, minute: 55, second: 35, millisecond: 216, kind: DateTimeKind.Utc),
new DateTime(year: 1993, month: 10, day: 12, hour: 5, minute: 52, second: 45, millisecond: 734, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 47,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1937, month: 10, day: 11, hour: 21, minute: 23, second: 12, millisecond: 567, kind: DateTimeKind.Utc),
new DateTime(year: 1994, month: 10, day: 15, hour: 8, minute: 7, second: 52, millisecond: 90, kind: DateTimeKind.Utc),
new DateTime(year: 1917, month: 10, day: 5, hour: 17, minute: 7, second: 15, millisecond: 387, kind: DateTimeKind.Utc),
new DateTime(year: 2000, month: 10, day: 14, hour: 10, minute: 15, second: 48, millisecond: 669, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 54,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 2010, month: 10, day: 7, hour: 10, minute: 30, second: 43, millisecond: 708, kind: DateTimeKind.Utc),
new DateTime(year: 1984, month: 10, day: 15, hour: 9, minute: 32, second: 28, millisecond: 2, kind: DateTimeKind.Utc),
new DateTime(year: 2003, month: 10, day: 19, hour: 11, minute: 49, second: 1, millisecond: 128, kind: DateTimeKind.Utc),
new DateTime(year: 1963, month: 10, day: 14, hour: 13, minute: 53, second: 6, millisecond: 886, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 35,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 2014, month: 10, day: 5, hour: 4, minute: 36, second: 37, millisecond: 983, kind: DateTimeKind.Utc),
new DateTime(year: 1973, month: 10, day: 17, hour: 20, minute: 54, second: 56, millisecond: 922, kind: DateTimeKind.Utc),
new DateTime(year: 1978, month: 10, day: 12, hour: 12, minute: 53, second: 43, millisecond: 241, kind: DateTimeKind.Utc),
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1960, month: 10, day: 10, hour: 20, minute: 14, second: 4, millisecond: 78, kind: DateTimeKind.Utc),
new DateTime(year: 1962, month: 10, day: 19, hour: 5, minute: 8, second: 19, millisecond: 785, kind: DateTimeKind.Utc),
new DateTime(year: 1976, month: 10, day: 17, hour: 8, minute: 53, second: 41, millisecond: 170, kind: DateTimeKind.Utc),
new DateTime(year: 1981, month: 10, day: 2, hour: 21, minute: 23, second: 21, millisecond: 253, kind: DateTimeKind.Utc),
},
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1942, month: 10, day: 10, hour: 8, minute: 57, second: 33, millisecond: 629, kind: DateTimeKind.Utc),
new DateTime(year: 1920, month: 10, day: 16, hour: 15, minute: 28, second: 45, millisecond: 567, kind: DateTimeKind.Utc),
new DateTime(year: 1974, month: 10, day: 7, hour: 22, minute: 40, second: 39, millisecond: 973, kind: DateTimeKind.Utc),
new DateTime(year: 1970, month: 10, day: 2, hour: 19, minute: 57, second: 43, millisecond: 565, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 59,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 2001, month: 10, day: 8, hour: 12, minute: 56, second: 53, millisecond: 181, kind: DateTimeKind.Utc),
new DateTime(year: 1945, month: 10, day: 7, hour: 3, minute: 27, second: 6, millisecond: 386, kind: DateTimeKind.Utc),
new DateTime(year: 1988, month: 10, day: 9, hour: 7, minute: 58, second: 11, millisecond: 3, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 60,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 16, hour: 13, minute: 7, second: 31, millisecond: 851, kind: DateTimeKind.Utc),
new DateTime(year: 1996, month: 10, day: 16, hour: 19, minute: 57, second: 4, millisecond: 676, kind: DateTimeKind.Utc),
new DateTime(year: 1998, month: 10, day: 9, hour: 6, minute: 12, second: 51, millisecond: 954, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 44,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1927, month: 10, day: 8, hour: 20, minute: 2, second: 33, millisecond: 989, kind: DateTimeKind.Utc),
new DateTime(year: 1977, month: 10, day: 5, hour: 19, minute: 42, second: 53, millisecond: 184, kind: DateTimeKind.Utc),
new DateTime(year: 1974, month: 10, day: 18, hour: 4, minute: 30, second: 27, millisecond: 357, kind: DateTimeKind.Utc),
},
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 2018, month: 10, day: 16, hour: 5, minute: 20, second: 30, millisecond: 58, kind: DateTimeKind.Utc),
new DateTime(year: 1968, month: 10, day: 18, hour: 5, minute: 37, second: 5, millisecond: 406, kind: DateTimeKind.Utc),
new DateTime(year: 1930, month: 10, day: 9, hour: 16, minute: 7, second: 7, millisecond: 302, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 67,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1998, month: 10, day: 13, hour: 17, minute: 39, second: 48, millisecond: 939, kind: DateTimeKind.Utc),
new DateTime(year: 1942, month: 10, day: 6, hour: 2, minute: 35, second: 22, millisecond: 267, kind: DateTimeKind.Utc),
new DateTime(year: 1974, month: 10, day: 8, hour: 11, minute: 3, second: 13, millisecond: 924, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 71,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 2018, month: 10, day: 14, hour: 10, minute: 5, second: 25, millisecond: 585, kind: DateTimeKind.Utc),
new DateTime(year: 1965, month: 10, day: 8, hour: 17, minute: 5, second: 20, millisecond: 671, kind: DateTimeKind.Utc),
new DateTime(year: 1933, month: 10, day: 1, hour: 1, minute: 28, second: 4, millisecond: 224, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 52,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1943, month: 10, day: 3, hour: 9, minute: 12, second: 2, millisecond: 835, kind: DateTimeKind.Utc),
new DateTime(year: 1965, month: 10, day: 3, hour: 17, minute: 5, second: 58, millisecond: 826, kind: DateTimeKind.Utc),
new DateTime(year: 1987, month: 10, day: 14, hour: 7, minute: 19, second: 46, millisecond: 92, kind: DateTimeKind.Utc),
new DateTime(year: 1948, month: 10, day: 2, hour: 10, minute: 34, second: 36, millisecond: 84, kind: DateTimeKind.Utc),
},
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1924, month: 10, day: 18, hour: 13, minute: 19, second: 21, millisecond: 296, kind: DateTimeKind.Utc),
new DateTime(year: 1918, month: 10, day: 18, hour: 16, minute: 46, second: 53, millisecond: 597, kind: DateTimeKind.Utc),
new DateTime(year: 1935, month: 10, day: 8, hour: 22, minute: 50, second: 14, millisecond: 799, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 79,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1985, month: 10, day: 9, hour: 12, minute: 39, second: 31, millisecond: 484, kind: DateTimeKind.Utc),
new DateTime(year: 2016, month: 10, day: 15, hour: 18, minute: 9, second: 28, millisecond: 58, kind: DateTimeKind.Utc),
new DateTime(year: 1936, month: 10, day: 17, hour: 22, minute: 4, second: 32, millisecond: 67, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 80,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1978, month: 10, day: 2, hour: 20, minute: 56, second: 41, millisecond: 622, kind: DateTimeKind.Utc),
new DateTime(year: 1969, month: 10, day: 13, hour: 16, minute: 5, second: 58, millisecond: 665, kind: DateTimeKind.Utc),
new DateTime(year: 1956, month: 10, day: 5, hour: 15, minute: 3, second: 27, millisecond: 662, kind: DateTimeKind.Utc),
new DateTime(year: 2017, month: 10, day: 16, hour: 9, minute: 46, second: 33, millisecond: 356, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 55,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1933, month: 10, day: 10, hour: 13, minute: 36, second: 46, millisecond: 183, kind: DateTimeKind.Utc),
new DateTime(year: 1998, month: 10, day: 13, hour: 7, minute: 38, second: 2, millisecond: 405, kind: DateTimeKind.Utc),
new DateTime(year: 1937, month: 10, day: 18, hour: 19, minute: 46, second: 56, millisecond: 37, kind: DateTimeKind.Utc),
new DateTime(year: 1942, month: 10, day: 2, hour: 12, minute: 16, second: 48, millisecond: 722, kind: DateTimeKind.Utc),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 85,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1986, month: 10, day: 19, hour: 12, minute: 30, second: 22, millisecond: 508, kind: DateTimeKind.Utc),
new DateTime(year: 1933, month: 10, day: 4, hour: 4, minute: 52, second: 31, millisecond: 372, kind: DateTimeKind.Utc),
new DateTime(year: 1994, month: 10, day: 19, hour: 4, minute: 44, second: 34, millisecond: 256, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 91,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1988, month: 10, day: 7, hour: 19, minute: 18, second: 12, millisecond: 934, kind: DateTimeKind.Utc),
new DateTime(year: 2004, month: 10, day: 15, hour: 3, minute: 15, second: 47, millisecond: 453, kind: DateTimeKind.Utc),
new DateTime(year: 1986, month: 10, day: 5, hour: 6, minute: 12, second: 44, millisecond: 619, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 59,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1979, month: 10, day: 16, hour: 22, minute: 24, second: 8, millisecond: 604, kind: DateTimeKind.Utc),
new DateTime(year: 1972, month: 10, day: 16, hour: 5, minute: 7, second: 49, millisecond: 122, kind: DateTimeKind.Utc),
new DateTime(year: 1922, month: 10, day: 3, hour: 13, minute: 25, second: 16, millisecond: 671, kind: DateTimeKind.Utc),
new DateTime(year: 1968, month: 10, day: 6, hour: 19, minute: 39, second: 15, millisecond: 358, kind: DateTimeKind.Utc),
},
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1976, month: 10, day: 17, hour: 3, minute: 22, second: 16, millisecond: 466, kind: DateTimeKind.Utc),
new DateTime(year: 2006, month: 10, day: 17, hour: 21, minute: 2, second: 5, millisecond: 63, kind: DateTimeKind.Utc),
new DateTime(year: 2017, month: 10, day: 19, hour: 13, minute: 35, second: 29, millisecond: 615, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 94,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1939, month: 10, day: 12, hour: 20, minute: 17, second: 27, millisecond: 858, kind: DateTimeKind.Utc),
new DateTime(year: 2003, month: 10, day: 19, hour: 16, minute: 36, second: 57, millisecond: 675, kind: DateTimeKind.Utc),
new DateTime(year: 1969, month: 10, day: 3, hour: 16, minute: 33, second: 33, millisecond: 909, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1965, month: 10, day: 11, hour: 18, minute: 6, second: 34, millisecond: 993, kind: DateTimeKind.Utc),
new DateTime(year: 1984, month: 10, day: 18, hour: 13, minute: 55, second: 53, millisecond: 225, kind: DateTimeKind.Utc),
new DateTime(year: 2015, month: 10, day: 12, hour: 8, minute: 33, second: 43, millisecond: 789, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 96,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 2018, month: 10, day: 2, hour: 22, minute: 29, second: 24, millisecond: 231, kind: DateTimeKind.Utc),
new DateTime(year: 1949, month: 10, day: 12, hour: 3, minute: 44, second: 40, millisecond: 935, kind: DateTimeKind.Utc),
new DateTime(year: 1999, month: 10, day: 2, hour: 12, minute: 28, second: 31, millisecond: 462, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 68,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1941, month: 10, day: 12, hour: 22, minute: 28, second: 20, millisecond: 618, kind: DateTimeKind.Utc),
new DateTime(year: 1920, month: 10, day: 11, hour: 2, minute: 50, second: 50, millisecond: 116, kind: DateTimeKind.Utc),
new DateTime(year: 1929, month: 10, day: 9, hour: 5, minute: 50, second: 57, millisecond: 187, kind: DateTimeKind.Utc),
new DateTime(year: 1959, month: 10, day: 5, hour: 5, minute: 18, second: 5, millisecond: 668, kind: DateTimeKind.Utc),
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1990, month: 10, day: 7, hour: 16, minute: 33, second: 32, millisecond: 378, kind: DateTimeKind.Utc),
new DateTime(year: 1965, month: 10, day: 19, hour: 8, minute: 18, second: 34, millisecond: 267, kind: DateTimeKind.Utc),
new DateTime(year: 2012, month: 10, day: 15, hour: 18, minute: 26, second: 22, millisecond: 842, kind: DateTimeKind.Utc),
},
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1990, month: 10, day: 3, hour: 15, minute: 14, second: 43, millisecond: 134, kind: DateTimeKind.Utc),
new DateTime(year: 1936, month: 10, day: 2, hour: 4, minute: 48, second: 51, millisecond: 673, kind: DateTimeKind.Utc),
new DateTime(year: 1946, month: 10, day: 16, hour: 13, minute: 47, second: 58, millisecond: 570, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 105,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 2014, month: 10, day: 19, hour: 6, minute: 35, second: 15, millisecond: 230, kind: DateTimeKind.Utc),
new DateTime(year: 1959, month: 10, day: 14, hour: 22, minute: 28, second: 39, millisecond: 37, kind: DateTimeKind.Utc),
new DateTime(year: 2016, month: 10, day: 1, hour: 22, minute: 1, second: 4, millisecond: 538, kind: DateTimeKind.Utc),
new DateTime(year: 2008, month: 10, day: 9, hour: 20, minute: 11, second: 44, millisecond: 399, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 2000, month: 10, day: 2, hour: 17, minute: 40, second: 29, millisecond: 241, kind: DateTimeKind.Utc),
new DateTime(year: 1929, month: 10, day: 18, hour: 5, minute: 55, second: 7, millisecond: 6, kind: DateTimeKind.Utc),
new DateTime(year: 1994, month: 10, day: 18, hour: 8, minute: 24, second: 31, millisecond: 904, kind: DateTimeKind.Utc),
new DateTime(year: 1990, month: 10, day: 8, hour: 19, minute: 7, second: 6, millisecond: 578, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 113,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 2015, month: 10, day: 18, hour: 9, minute: 17, second: 12, millisecond: 785, kind: DateTimeKind.Utc),
new DateTime(year: 1936, month: 10, day: 15, hour: 22, minute: 8, second: 24, millisecond: 744, kind: DateTimeKind.Utc),
new DateTime(year: 1968, month: 10, day: 2, hour: 21, minute: 39, second: 54, millisecond: 597, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 70,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1929, month: 10, day: 2, hour: 19, minute: 17, second: 3, millisecond: 526, kind: DateTimeKind.Utc),
new DateTime(year: 1935, month: 10, day: 2, hour: 9, minute: 57, second: 45, millisecond: 739, kind: DateTimeKind.Utc),
new DateTime(year: 1970, month: 10, day: 1, hour: 15, minute: 38, second: 17, millisecond: 305, kind: DateTimeKind.Utc),
new DateTime(year: 2002, month: 10, day: 13, hour: 12, minute: 6, second: 10, millisecond: 957, kind: DateTimeKind.Utc),
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1927, month: 10, day: 10, hour: 20, minute: 38, second: 44, millisecond: 836, kind: DateTimeKind.Utc),
new DateTime(year: 1980, month: 10, day: 3, hour: 6, minute: 10, second: 2, millisecond: 768, kind: DateTimeKind.Utc),
new DateTime(year: 1937, month: 10, day: 8, hour: 11, minute: 55, second: 28, millisecond: 331, kind: DateTimeKind.Utc),
new DateTime(year: 1954, month: 10, day: 16, hour: 18, minute: 10, second: 45, millisecond: 24, kind: DateTimeKind.Utc),
},
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1964, month: 10, day: 16, hour: 20, minute: 7, second: 15, millisecond: 212, kind: DateTimeKind.Utc),
new DateTime(year: 2004, month: 10, day: 17, hour: 2, minute: 20, second: 22, millisecond: 819, kind: DateTimeKind.Utc),
new DateTime(year: 2003, month: 10, day: 15, hour: 6, minute: 11, second: 44, millisecond: 343, kind: DateTimeKind.Utc),
new DateTime(year: 1917, month: 10, day: 15, hour: 3, minute: 5, second: 16, millisecond: 958, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 117,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 2010, month: 10, day: 9, hour: 18, minute: 44, second: 18, millisecond: 386, kind: DateTimeKind.Utc),
new DateTime(year: 1925, month: 10, day: 1, hour: 17, minute: 32, second: 34, millisecond: 195, kind: DateTimeKind.Utc),
new DateTime(year: 1985, month: 10, day: 5, hour: 18, minute: 13, second: 4, millisecond: 978, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 2005, month: 10, day: 12, hour: 19, minute: 48, second: 38, millisecond: 327, kind: DateTimeKind.Utc),
new DateTime(year: 1940, month: 10, day: 1, hour: 21, minute: 24, second: 22, millisecond: 155, kind: DateTimeKind.Utc),
new DateTime(year: 1942, month: 10, day: 15, hour: 15, minute: 6, second: 56, millisecond: 401, kind: DateTimeKind.Utc),
new DateTime(year: 1988, month: 10, day: 3, hour: 15, minute: 9, second: 25, millisecond: 486, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 122,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1947, month: 10, day: 3, hour: 19, minute: 25, second: 19, millisecond: 946, kind: DateTimeKind.Utc),
new DateTime(year: 1954, month: 10, day: 13, hour: 20, minute: 48, second: 44, millisecond: 393, kind: DateTimeKind.Utc),
new DateTime(year: 1961, month: 10, day: 10, hour: 21, minute: 1, second: 8, millisecond: 484, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 74,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1928, month: 10, day: 17, hour: 11, minute: 55, second: 25, millisecond: 962, kind: DateTimeKind.Utc),
new DateTime(year: 1918, month: 10, day: 2, hour: 11, minute: 51, second: 9, millisecond: 317, kind: DateTimeKind.Utc),
new DateTime(year: 1931, month: 10, day: 14, hour: 16, minute: 51, second: 12, millisecond: 934, kind: DateTimeKind.Utc),
new DateTime(year: 2014, month: 10, day: 8, hour: 9, minute: 56, second: 50, millisecond: 394, kind: DateTimeKind.Utc),
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1935, month: 10, day: 19, hour: 21, minute: 46, second: 37, millisecond: 115, kind: DateTimeKind.Utc),
new DateTime(year: 1948, month: 10, day: 15, hour: 1, minute: 9, second: 16, millisecond: 698, kind: DateTimeKind.Utc),
new DateTime(year: 1927, month: 10, day: 19, hour: 5, minute: 19, second: 30, millisecond: 471, kind: DateTimeKind.Utc),
new DateTime(year: 1969, month: 10, day: 4, hour: 18, minute: 24, second: 57, millisecond: 2, kind: DateTimeKind.Utc),
},
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 126,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1980, month: 10, day: 7, hour: 3, minute: 46, second: 10, millisecond: 737, kind: DateTimeKind.Utc),
new DateTime(year: 1977, month: 10, day: 10, hour: 9, minute: 47, second: 32, millisecond: 12, kind: DateTimeKind.Utc),
new DateTime(year: 1949, month: 10, day: 13, hour: 7, minute: 44, second: 27, millisecond: 776, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 135,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1927, month: 10, day: 17, hour: 14, minute: 20, second: 43, millisecond: 214, kind: DateTimeKind.Utc),
new DateTime(year: 2018, month: 10, day: 17, hour: 7, minute: 4, second: 25, millisecond: 492, kind: DateTimeKind.Utc),
new DateTime(year: 1974, month: 10, day: 2, hour: 19, minute: 23, second: 22, millisecond: 131, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 83,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1943, month: 10, day: 9, hour: 13, minute: 38, second: 1, millisecond: 810, kind: DateTimeKind.Utc),
new DateTime(year: 1922, month: 10, day: 4, hour: 3, minute: 5, second: 41, millisecond: 94, kind: DateTimeKind.Utc),
new DateTime(year: 1962, month: 10, day: 11, hour: 8, minute: 22, second: 57, millisecond: 385, kind: DateTimeKind.Utc),
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1928, month: 10, day: 13, hour: 13, minute: 47, second: 20, millisecond: 502, kind: DateTimeKind.Utc),
new DateTime(year: 1990, month: 10, day: 12, hour: 15, minute: 29, second: 25, millisecond: 559, kind: DateTimeKind.Utc),
new DateTime(year: 2000, month: 10, day: 16, hour: 18, minute: 9, second: 47, millisecond: 297, kind: DateTimeKind.Utc),
new DateTime(year: 1943, month: 10, day: 15, hour: 18, minute: 15, second: 27, millisecond: 868, kind: DateTimeKind.Utc),
},
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 144,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1935, month: 10, day: 2, hour: 6, minute: 58, second: 14, millisecond: 193, kind: DateTimeKind.Utc),
new DateTime(year: 1918, month: 10, day: 15, hour: 7, minute: 47, second: 14, millisecond: 421, kind: DateTimeKind.Utc),
new DateTime(year: 1965, month: 10, day: 6, hour: 15, minute: 14, second: 27, millisecond: 474, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1952, month: 10, day: 11, hour: 19, minute: 52, second: 17, millisecond: 206, kind: DateTimeKind.Utc),
new DateTime(year: 1938, month: 10, day: 13, hour: 20, minute: 52, second: 28, millisecond: 416, kind: DateTimeKind.Utc),
new DateTime(year: 1941, month: 10, day: 7, hour: 8, minute: 57, second: 50, millisecond: 36, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 151,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1975, month: 10, day: 9, hour: 5, minute: 12, second: 30, millisecond: 901, kind: DateTimeKind.Utc),
new DateTime(year: 1985, month: 10, day: 18, hour: 3, minute: 30, second: 52, millisecond: 570, kind: DateTimeKind.Utc),
new DateTime(year: 1947, month: 10, day: 12, hour: 16, minute: 7, second: 29, millisecond: 615, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 89,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 2009, month: 10, day: 12, hour: 19, minute: 6, second: 30, millisecond: 388, kind: DateTimeKind.Utc),
new DateTime(year: 1958, month: 10, day: 12, hour: 5, minute: 11, second: 31, millisecond: 69, kind: DateTimeKind.Utc),
new DateTime(year: 1996, month: 10, day: 12, hour: 3, minute: 9, second: 26, millisecond: 15, kind: DateTimeKind.Utc),
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1966, month: 10, day: 5, hour: 4, minute: 53, second: 11, millisecond: 893, kind: DateTimeKind.Utc),
new DateTime(year: 1969, month: 10, day: 7, hour: 18, minute: 1, second: 5, millisecond: 190, kind: DateTimeKind.Utc),
new DateTime(year: 1960, month: 10, day: 14, hour: 22, minute: 12, second: 50, millisecond: 315, kind: DateTimeKind.Utc),
new DateTime(year: 1945, month: 10, day: 19, hour: 4, minute: 51, second: 40, millisecond: 412, kind: DateTimeKind.Utc),
},
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 155,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1934, month: 10, day: 18, hour: 2, minute: 14, second: 8, millisecond: 253, kind: DateTimeKind.Utc),
new DateTime(year: 1987, month: 10, day: 13, hour: 14, minute: 35, second: 22, millisecond: 601, kind: DateTimeKind.Utc),
new DateTime(year: 1982, month: 10, day: 18, hour: 17, minute: 57, second: 26, millisecond: 84, kind: DateTimeKind.Utc),
new DateTime(year: 1946, month: 10, day: 1, hour: 20, minute: 42, second: 23, millisecond: 160, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 161,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1946, month: 10, day: 2, hour: 3, minute: 13, second: 5, millisecond: 627, kind: DateTimeKind.Utc),
new DateTime(year: 2014, month: 10, day: 15, hour: 15, minute: 18, second: 26, millisecond: 279, kind: DateTimeKind.Utc),
new DateTime(year: 2018, month: 10, day: 12, hour: 14, minute: 12, second: 24, millisecond: 608, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 91,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1974, month: 10, day: 16, hour: 5, minute: 1, second: 51, millisecond: 502, kind: DateTimeKind.Utc),
new DateTime(year: 1945, month: 10, day: 12, hour: 1, minute: 10, second: 4, millisecond: 591, kind: DateTimeKind.Utc),
new DateTime(year: 1990, month: 10, day: 18, hour: 8, minute: 56, second: 29, millisecond: 309, kind: DateTimeKind.Utc),
},
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1999, month: 10, day: 9, hour: 12, minute: 6, second: 39, millisecond: 954, kind: DateTimeKind.Utc),
new DateTime(year: 1932, month: 10, day: 2, hour: 22, minute: 27, second: 55, millisecond: 247, kind: DateTimeKind.Utc),
new DateTime(year: 2000, month: 10, day: 3, hour: 4, minute: 17, second: 1, millisecond: 271, kind: DateTimeKind.Utc),
new DateTime(year: 2006, month: 10, day: 3, hour: 20, minute: 7, second: 4, millisecond: 186, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 163,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1965, month: 10, day: 15, hour: 20, minute: 52, second: 31, millisecond: 727, kind: DateTimeKind.Utc),
new DateTime(year: 1918, month: 10, day: 6, hour: 19, minute: 51, second: 38, millisecond: 303, kind: DateTimeKind.Utc),
new DateTime(year: 1946, month: 10, day: 16, hour: 11, minute: 34, second: 48, millisecond: 481, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1944, month: 10, day: 1, hour: 22, minute: 52, second: 16, millisecond: 609, kind: DateTimeKind.Utc),
new DateTime(year: 1970, month: 10, day: 14, hour: 10, minute: 5, second: 11, millisecond: 697, kind: DateTimeKind.Utc),
new DateTime(year: 1968, month: 10, day: 3, hour: 14, minute: 54, second: 22, millisecond: 171, kind: DateTimeKind.Utc),
new DateTime(year: 1989, month: 10, day: 5, hour: 16, minute: 50, second: 43, millisecond: 411, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 168,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1958, month: 10, day: 4, hour: 11, minute: 29, second: 42, millisecond: 167, kind: DateTimeKind.Utc),
new DateTime(year: 1923, month: 10, day: 17, hour: 11, minute: 17, second: 16, millisecond: 935, kind: DateTimeKind.Utc),
new DateTime(year: 1987, month: 10, day: 11, hour: 7, minute: 29, second: 36, millisecond: 19, kind: DateTimeKind.Utc),
new DateTime(year: 1938, month: 10, day: 2, hour: 12, minute: 40, second: 7, millisecond: 529, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 98,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1942, month: 10, day: 14, hour: 22, minute: 35, second: 47, millisecond: 649, kind: DateTimeKind.Utc),
new DateTime(year: 1985, month: 10, day: 17, hour: 22, minute: 40, second: 21, millisecond: 639, kind: DateTimeKind.Utc),
new DateTime(year: 1990, month: 10, day: 14, hour: 18, minute: 8, second: 39, millisecond: 850, kind: DateTimeKind.Utc),
new DateTime(year: 2000, month: 10, day: 10, hour: 1, minute: 31, second: 29, millisecond: 348, kind: DateTimeKind.Utc),
},
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 2013, month: 10, day: 11, hour: 5, minute: 48, second: 1, millisecond: 336, kind: DateTimeKind.Utc),
new DateTime(year: 1943, month: 10, day: 12, hour: 21, minute: 17, second: 55, millisecond: 172, kind: DateTimeKind.Utc),
new DateTime(year: 1931, month: 10, day: 11, hour: 19, minute: 47, second: 51, millisecond: 696, kind: DateTimeKind.Utc),
new DateTime(year: 1962, month: 10, day: 17, hour: 5, minute: 58, second: 49, millisecond: 275, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 174,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 2015, month: 10, day: 14, hour: 21, minute: 34, second: 45, millisecond: 444, kind: DateTimeKind.Utc),
new DateTime(year: 1973, month: 10, day: 14, hour: 17, minute: 41, second: 51, millisecond: 116, kind: DateTimeKind.Utc),
new DateTime(year: 1934, month: 10, day: 13, hour: 9, minute: 51, second: 35, millisecond: 49, kind: DateTimeKind.Utc),
new DateTime(year: 1921, month: 10, day: 12, hour: 15, minute: 42, second: 8, millisecond: 535, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1994, month: 10, day: 7, hour: 12, minute: 52, second: 3, millisecond: 949, kind: DateTimeKind.Utc),
new DateTime(year: 1949, month: 10, day: 15, hour: 13, minute: 48, second: 40, millisecond: 541, kind: DateTimeKind.Utc),
new DateTime(year: 2011, month: 10, day: 13, hour: 11, minute: 34, second: 55, millisecond: 855, kind: DateTimeKind.Utc),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_with_time_zonearray1mi(
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
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483622)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483622))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_with_time_zonearray1mi(
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
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483622)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[]), 
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

                changedRows =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_with_time_zonearray1m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_with_time_zonearray1mi_id
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
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483622)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483622)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "datetimetimestamp_with_time_zonearray1mi_id", 
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
                changedRows =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_with_time_zonearray1m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_with_time_zonearray1mi_id
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
    datetimetimestamp_with_time_zonearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.DateTime[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.DateTime[]>();
                    ((NpgsqlParameter<System.DateTime[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483622);
                    ((NpgsqlParameter<System.DateTime[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483622);
                    if (_testData[4].NullableValue != null)
                    {
                        parameters[2].Value = _testData[4].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[4].ModelInner != null)
                    {
                        parameters[3].Value = _testData[4].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.DateTime[3]
{
new DateTime(year: 1976, month: 10, day: 12, hour: 8, minute: 46, second: 16, millisecond: 421, kind: DateTimeKind.Utc),
new DateTime(year: 2008, month: 10, day: 9, hour: 17, minute: 18, second: 21, millisecond: 284, kind: DateTimeKind.Utc),
new DateTime(year: 1984, month: 10, day: 3, hour: 17, minute: 12, second: 7, millisecond: 626, kind: DateTimeKind.Utc),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.DateTime[]>();
                    ((NpgsqlParameter<System.DateTime[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483622);
                    ((NpgsqlParameter<System.DateTime[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483622);
                    if (_testData[5].NullableValue != null)
                    {
                        parameters[2].Value = _testData[5].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[5].ModelInner != null)
                    {
                        parameters[3].Value = _testData[5].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.DateTime[4]
{
new DateTime(year: 2010, month: 10, day: 14, hour: 16, minute: 1, second: 56, millisecond: 409, kind: DateTimeKind.Utc),
new DateTime(year: 2004, month: 10, day: 13, hour: 17, minute: 31, second: 52, millisecond: 573, kind: DateTimeKind.Utc),
new DateTime(year: 1917, month: 10, day: 2, hour: 14, minute: 9, second: 58, millisecond: 291, kind: DateTimeKind.Utc),
new DateTime(year: 1968, month: 10, day: 1, hour: 11, minute: 2, second: 2, millisecond: 57, kind: DateTimeKind.Utc),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.DateTime[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.DateTime[]>();
                    ((NpgsqlParameter<System.DateTime[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483622);
                    ((NpgsqlParameter<System.DateTime[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483622);
                    if (_testData[6].NullableValue != null)
                    {
                        parameters[2].Value = _testData[6].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[6].ModelInner != null)
                    {
                        parameters[3].Value = _testData[6].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.DateTime[]>();
                    ((NpgsqlParameter<System.DateTime[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483622);
                    ((NpgsqlParameter<System.DateTime[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483622);
                    if (_testData[7].NullableValue != null)
                    {
                        parameters[2].Value = _testData[7].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[7].ModelInner != null)
                    {
                        parameters[3].Value = _testData[7].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.DateTime[3]
{
new DateTime(year: 1948, month: 10, day: 15, hour: 22, minute: 37, second: 18, millisecond: 494, kind: DateTimeKind.Utc),
new DateTime(year: 1936, month: 10, day: 3, hour: 1, minute: 13, second: 50, millisecond: 246, kind: DateTimeKind.Utc),
new DateTime(year: 1927, month: 10, day: 3, hour: 6, minute: 9, second: 30, millisecond: 596, kind: DateTimeKind.Utc),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_with_time_zonearray1m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_with_time_zonearray1mi_id
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
    datetimetimestamp_with_time_zonearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483622)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483622)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "datetimetimestamp_with_time_zonearray1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.DateTime[] nullable = null;
                nullable =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.DateTime[4]
{
new DateTime(year: 1970, month: 10, day: 15, hour: 13, minute: 44, second: 27, millisecond: 16, kind: DateTimeKind.Utc),
new DateTime(year: 1982, month: 10, day: 11, hour: 14, minute: 8, second: 27, millisecond: 221, kind: DateTimeKind.Utc),
new DateTime(year: 1975, month: 10, day: 6, hour: 10, minute: 16, second: 22, millisecond: 486, kind: DateTimeKind.Utc),
new DateTime(year: 1940, month: 10, day: 18, hour: 16, minute: 36, second: 2, millisecond: 156, kind: DateTimeKind.Utc),
}));
                nullable =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.DateTime[3]
{
new DateTime(year: 1971, month: 10, day: 14, hour: 20, minute: 19, second: 47, millisecond: 757, kind: DateTimeKind.Utc),
new DateTime(year: 1982, month: 10, day: 14, hour: 8, minute: 55, second: 35, millisecond: 216, kind: DateTimeKind.Utc),
new DateTime(year: 1993, month: 10, day: 12, hour: 5, minute: 52, second: 45, millisecond: 734, kind: DateTimeKind.Utc),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.DateTime[] nullable = null;
                nullable = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.DateTime[4]
{
new DateTime(year: 1942, month: 10, day: 10, hour: 8, minute: 57, second: 33, millisecond: 629, kind: DateTimeKind.Utc),
new DateTime(year: 1920, month: 10, day: 16, hour: 15, minute: 28, second: 45, millisecond: 567, kind: DateTimeKind.Utc),
new DateTime(year: 1974, month: 10, day: 7, hour: 22, minute: 40, second: 39, millisecond: 973, kind: DateTimeKind.Utc),
new DateTime(year: 1970, month: 10, day: 2, hour: 19, minute: 57, second: 43, millisecond: 565, kind: DateTimeKind.Utc),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DateTimetimestamp_with_time_zoneArray1M> models = null;

                models =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DateTimetimestamp_with_time_zoneArray1M> models = null;

                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zoneArray1M), typeof(FlatDateTimetimestamp_with_time_zoneArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray)),
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
FROM public.datetimetimestamp_with_time_zonearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                var models2 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                await ((IDateTimeArraytimestamp_with_time_zoneArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zonearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                var models2 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                ((IDateTimeArraytimestamp_with_time_zoneArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zoneArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray)),
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
FROM public.datetimetimestamp_with_time_zonearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zonearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDateTimeArraytimestamp_with_time_zoneArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zonearray1m m
LEFT JOIN public.datetimetimestamp_with_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray)),
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
                var models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDateTimeArraytimestamp_with_time_zoneArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zoneArray1M), typeof(FlatDateTimetimestamp_with_time_zoneArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray)),
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
FROM public.datetimetimestamp_with_time_zonearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                var models2 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                await ((IDateTimeArraytimestamp_with_time_zoneArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zonearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                var models2 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                ((IDateTimeArraytimestamp_with_time_zoneArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zoneArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray)),
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
FROM public.datetimetimestamp_with_time_zonearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zonearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDateTimeArraytimestamp_with_time_zoneArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zonearray1m m
LEFT JOIN public.datetimetimestamp_with_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray)),
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
                var models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDateTimeArraytimestamp_with_time_zoneArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zoneArray1M), typeof(FlatDateTimetimestamp_with_time_zoneArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray)),
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
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray)),
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
FROM public.datetimetimestamp_with_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                var models2 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                await((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 144;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
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
FROM public.datetimetimestamp_with_time_zonearray1m m
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
FROM public.datetimetimestamp_with_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                await ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 29;
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
FROM public.datetimetimestamp_with_time_zonearray1m m
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
FROM public.datetimetimestamp_with_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                await ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[23],_testData[34], false);
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
FROM public.datetimetimestamp_with_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                var models2 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 163;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
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
FROM public.datetimetimestamp_with_time_zonearray1m m
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
FROM public.datetimetimestamp_with_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                 ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 151;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
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
FROM public.datetimetimestamp_with_time_zonearray1m m
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
FROM public.datetimetimestamp_with_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                 ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[25],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zoneArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray)),
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
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray)),
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
FROM public.datetimetimestamp_with_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_with_time_zonearray1m m
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
FROM public.datetimetimestamp_with_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[8],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[9],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[10],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[11],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[12],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[13],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[14],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[15],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[16],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[17],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_with_time_zonearray1m m
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
FROM public.datetimetimestamp_with_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                await ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.datetimetimestamp_with_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_with_time_zonearray1m m
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
FROM public.datetimetimestamp_with_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[8],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[9],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[10],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[11],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[12],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[13],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[14],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[15],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[16],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[17],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[18],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[19],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[20],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[5], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[8],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[9],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[10],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[11],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[12],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[13],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[14],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[15],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[16],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[17],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[18],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[19],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[20],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[21],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[22],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[23],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[24],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[25],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[26],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[27],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[28],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_with_time_zonearray1m m
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
FROM public.datetimetimestamp_with_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                 ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.datetimetimestamp_with_time_zonearray1m m
LEFT JOIN public.datetimetimestamp_with_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray)),
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
                var models = await((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[18], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[19], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[20], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[21], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[22], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[23], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[24], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[25], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[8],_testData[26], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[9],_testData[27], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[10],_testData[28], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[11],_testData[29], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[12],_testData[30], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[13],_testData[31], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[14],_testData[32], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[15],_testData[33], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[20], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[21], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[22], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[23], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[24], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[25], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[26], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[27], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[8],_testData[28], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[9],_testData[29], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[10],_testData[30], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[11],_testData[31], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[12],_testData[32], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[13],_testData[33], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[14],_testData[34], false);
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
                var models = ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[27], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[28], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[29], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[30], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[31], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[32], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[33], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[1], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[2], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[3], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[4], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[5], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[6], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[7], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[8], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[8],_testData[9], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[9],_testData[10], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[10],_testData[11], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[11],_testData[12], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[12],_testData[13], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[13],_testData[14], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[14],_testData[15], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[15],_testData[16], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[16],_testData[17], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[17],_testData[18], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[18],_testData[19], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[19],_testData[20], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[20],_testData[21], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[21],_testData[22], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[22],_testData[23], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[23],_testData[24], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[24],_testData[25], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[25],_testData[26], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[26],_testData[27], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[27],_testData[28], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[28],_testData[29], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[29],_testData[30], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[30],_testData[31], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[31],_testData[32], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[32],_testData[33], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zoneArray1M), typeof(FlatDateTimetimestamp_with_time_zoneArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray)),
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
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray)),
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
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray)),
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
FROM public.datetimetimestamp_with_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                var models2 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                await((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zonearray1m m
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
FROM public.datetimetimestamp_with_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                await ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 60, query1, 105, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.datetimetimestamp_with_time_zonearray1m m
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
FROM public.datetimetimestamp_with_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                await ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 144, query1, 71, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[18],_testData[34], false);
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
FROM public.datetimetimestamp_with_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                var models2 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zonearray1m m
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
FROM public.datetimetimestamp_with_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                 ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 20, query1, 161, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.datetimetimestamp_with_time_zonearray1m m
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
FROM public.datetimetimestamp_with_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                 ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 36, query1, 12, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[32],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zoneArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray)),
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
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray)),
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
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray)),
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
FROM public.datetimetimestamp_with_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zonearray1m m
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
FROM public.datetimetimestamp_with_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 36, query1, 15, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[8],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[9],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[10],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[11],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[12],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[13],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[14],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[15],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[16],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[17],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[18],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[19],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[20],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[21],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[22],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[23],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[24],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[25],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[3], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[4], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[5], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[8],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[9],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[10],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[11],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[12],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[13],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[14],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[15],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[16],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[17],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[18],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[19],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[20],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[21],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[22],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[23],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[24],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[25],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[26],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[27],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[28],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[29],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[30],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[31],_testData[34], false);
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
FROM public.datetimetimestamp_with_time_zonearray1m m
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
FROM public.datetimetimestamp_with_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                await ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 155, query1, 15, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.datetimetimestamp_with_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zonearray1m m
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
FROM public.datetimetimestamp_with_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 122, query1, 126, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[34], false);
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
FROM public.datetimetimestamp_with_time_zonearray1m m
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
FROM public.datetimetimestamp_with_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_with_time_zoneArray1M>();
                 ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionDynQuerySelectModelBatch(connection, 155, query1, 85, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.datetimetimestamp_with_time_zonearray1m m
LEFT JOIN public.datetimetimestamp_with_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray)),
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
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray)),
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
                var models = await((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionSTSelectModelBatchAsync(connection, 35, 96))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[7], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[8], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[9], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[10], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[11], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[12], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[13], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[14], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[8],_testData[15], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[9],_testData[16], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[10],_testData[17], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[11],_testData[18], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[12],_testData[19], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[13],_testData[20], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[14],_testData[21], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[15],_testData[22], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[16],_testData[23], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[17],_testData[24], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[18],_testData[25], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[19],_testData[26], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[20],_testData[27], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[21],_testData[28], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[22],_testData[29], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[23],_testData[30], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[24],_testData[31], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[25],_testData[32], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[26],_testData[33], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[22], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[23], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[24], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[25], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[26], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[27], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[28], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[29], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[8],_testData[30], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[9],_testData[31], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[10],_testData[32], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[11],_testData[33], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[12],_testData[34], false);
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
                var models = ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionSTSelectModelBatch(connection, 96, 91))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[22], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[23], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[24], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[25], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[26], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[27], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[28], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[29], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[8],_testData[30], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[9],_testData[31], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[10],_testData[32], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[11],_testData[33], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[20], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[21], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[22], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[23], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[24], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[25], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[26], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[27], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[8],_testData[28], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[9],_testData[29], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[10],_testData[30], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[11],_testData[31], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[12],_testData[32], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[13],_testData[33], false);
                        DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[14],_testData[34], false);
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
                await using var cmd = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDateTimeArraytimestamp_with_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 79);
                var models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(18));
DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[17], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[18], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[19], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[20], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[21], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[22], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[23], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[24], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[8],_testData[25], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[9],_testData[26], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[10],_testData[27], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[11],_testData[28], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[12],_testData[29], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[13],_testData[30], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[14],_testData[31], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[15],_testData[32], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[16],_testData[33], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateTimeArraytimestamp_with_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 151);
                var models =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[30], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[31], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[32], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[33], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[34], false);
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
FROM public.binary_datetimetimestamp_with_time_zonearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(DateTimetimestamp_with_time_zoneArray1MIWA),
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
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateTimetimestamp_with_time_zoneArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_with_time_zoneArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDateTimeArraytimestamp_with_time_zoneArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_datetimetimestamp_with_time_zonearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryWAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<DateTimetimestamp_with_time_zoneArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_with_time_zoneArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDateTimeArraytimestamp_with_time_zoneArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_datetimetimestamp_with_time_zonearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDateTimeArraytimestamp_with_time_zoneArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_datetimetimestamp_with_time_zonearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(DateTimetimestamp_with_time_zoneArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateTimetimestamp_with_time_zoneArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_with_time_zoneArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDateTimeArraytimestamp_with_time_zoneArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_datetimetimestamp_with_time_zonearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<DateTimetimestamp_with_time_zoneArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_with_time_zoneArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDateTimeArraytimestamp_with_time_zoneArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_datetimetimestamp_with_time_zonearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDateTimeArraytimestamp_with_time_zoneArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_datetimetimestamp_with_time_zonearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_datetimetimestamp_with_time_zonearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(DateTimetimestamp_with_time_zoneArray1MI),
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
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateTimetimestamp_with_time_zoneArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDateTimeArraytimestamp_with_time_zoneArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<DateTimetimestamp_with_time_zoneArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDateTimeArraytimestamp_with_time_zoneArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IDateTimeArraytimestamp_with_time_zoneArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_datetimetimestamp_with_time_zonearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_datetimetimestamp_with_time_zonearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DateTimetimestamp_with_time_zoneArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateTimetimestamp_with_time_zoneArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_with_time_zoneArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDateTimeArraytimestamp_with_time_zoneArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<DateTimetimestamp_with_time_zoneArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_with_time_zoneArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDateTimeArraytimestamp_with_time_zoneArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDateTimeArraytimestamp_with_time_zoneArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_datetimetimestamp_with_time_zonearray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
datetimetimestamp_with_time_zonearray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DateTimetimestamp_with_time_zoneArray1M),
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
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray))]
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
FROM public.binary_datetimetimestamp_with_time_zonearray1m m
LEFT JOIN public.binary_datetimetimestamp_with_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateTimetimestamp_with_time_zoneArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDateTimeArraytimestamp_with_time_zoneArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DateTimetimestamp_with_time_zoneArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(10)]
        public  void ImportModelTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<DateTimetimestamp_with_time_zoneArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDateTimeArraytimestamp_with_time_zoneArray)this).ImportModel(connection, importCollection);
                var models = ((IDateTimeArraytimestamp_with_time_zoneArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DateTimetimestamp_with_time_zoneArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_datetimetimestamp_with_time_zonearray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    datetimetimestamp_with_time_zonearray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneArray1M)],
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
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DateTimetimestamp_with_time_zoneArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DateTimetimestamp_with_time_zoneArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneArray1MIWA), typeof(DateTimetimestamp_with_time_zoneArray1MIWA)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483622),
                (NpgsqlTypes.NpgsqlDbType)(-2147483622)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483622),
                (NpgsqlTypes.NpgsqlDbType)(-2147483622)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483622),
                (NpgsqlTypes.NpgsqlDbType)(-2147483622)
            })]
        private void MMDynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<DateTimetimestamp_with_time_zoneArray1MIWA>();
                var models2 = new List<DateTimetimestamp_with_time_zoneArray1MIWA>();
                await ((IDateTimeArraytimestamp_with_time_zoneArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_datetimetimestamp_with_time_zonearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<DateTimetimestamp_with_time_zoneArray1MIWA>();
                var models2 = new List<DateTimetimestamp_with_time_zoneArray1MIWA>();
                ((IDateTimeArraytimestamp_with_time_zoneArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_datetimetimestamp_with_time_zonearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneArray1MIWA)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483622),
                (NpgsqlTypes.NpgsqlDbType)(-2147483622)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483622),
                (NpgsqlTypes.NpgsqlDbType)(-2147483622)
            })]
        private void DynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_datetimetimestamp_with_time_zonearray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IDateTimeArraytimestamp_with_time_zoneArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_datetimetimestamp_with_time_zonearray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneArray1MIWA), typeof(DateTimetimestamp_with_time_zoneArray1MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray))]
        private void MMDynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<DateTimetimestamp_with_time_zoneArray1MIWA>();
                var models2 = new List<DateTimetimestamp_with_time_zoneArray1MIWA>();
                await ((IDateTimeArraytimestamp_with_time_zoneArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_datetimetimestamp_with_time_zonearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<DateTimetimestamp_with_time_zoneArray1MIWA>();
                var models2 = new List<DateTimetimestamp_with_time_zoneArray1MIWA>();
                ((IDateTimeArraytimestamp_with_time_zoneArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_datetimetimestamp_with_time_zonearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneArray1MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_datetimetimestamp_with_time_zonearray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IDateTimeArraytimestamp_with_time_zoneArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_datetimetimestamp_with_time_zonearray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_datetimetimestamp_with_time_zonearray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneArray1MI), typeof(DateTimetimestamp_with_time_zoneArray1MI)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483622),
                (NpgsqlTypes.NpgsqlDbType)(-2147483622)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483622),
                (NpgsqlTypes.NpgsqlDbType)(-2147483622)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483622),
                (NpgsqlTypes.NpgsqlDbType)(-2147483622)
            })]
        private void MMWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<DateTimetimestamp_with_time_zoneArray1MI>();
                var models2 = new List<DateTimetimestamp_with_time_zoneArray1MI>();
                await ((IDateTimeArraytimestamp_with_time_zoneArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<DateTimetimestamp_with_time_zoneArray1MI>();
                var models2 = new List<DateTimetimestamp_with_time_zoneArray1MI>();
                ((IDateTimeArraytimestamp_with_time_zoneArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_datetimetimestamp_with_time_zonearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneArray1MI)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483622),
                (NpgsqlTypes.NpgsqlDbType)(-2147483622)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483622),
                (NpgsqlTypes.NpgsqlDbType)(-2147483622)
            })]
        private void WAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task WAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void WAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IDateTimeArraytimestamp_with_time_zoneArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_datetimetimestamp_with_time_zonearray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneArray1MIWA), typeof(DateTimetimestamp_with_time_zoneArray1MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray))]
        private void MMExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<DateTimetimestamp_with_time_zoneArray1MIWA>();
                var models2 = new List<DateTimetimestamp_with_time_zoneArray1MIWA>();
                await ((IDateTimeArraytimestamp_with_time_zoneArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<DateTimetimestamp_with_time_zoneArray1MIWA>();
                var models2 = new List<DateTimetimestamp_with_time_zoneArray1MIWA>();
                ((IDateTimeArraytimestamp_with_time_zoneArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_datetimetimestamp_with_time_zonearray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneArray1MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IDateTimeArraytimestamp_with_time_zoneArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

