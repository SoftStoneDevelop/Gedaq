

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
    Id = 7,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1936, month: 10, day: 17, hour: 18, minute: 46, second: 32, millisecond: 690, kind: DateTimeKind.Utc),
new DateTime(year: 1946, month: 10, day: 1, hour: 12, minute: 14, second: 5, millisecond: 226, kind: DateTimeKind.Utc),
new DateTime(year: 2005, month: 10, day: 6, hour: 18, minute: 22, second: 17, millisecond: 694, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 13,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1972, month: 10, day: 14, hour: 21, minute: 1, second: 51, millisecond: 128, kind: DateTimeKind.Utc),
new DateTime(year: 1967, month: 10, day: 1, hour: 8, minute: 44, second: 13, millisecond: 640, kind: DateTimeKind.Utc),
new DateTime(year: 2017, month: 10, day: 12, hour: 14, minute: 7, second: 58, millisecond: 502, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 5,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1987, month: 10, day: 14, hour: 19, minute: 58, second: 15, millisecond: 772, kind: DateTimeKind.Utc),
new DateTime(year: 2019, month: 10, day: 14, hour: 5, minute: 42, second: 24, millisecond: 239, kind: DateTimeKind.Utc),
new DateTime(year: 2001, month: 10, day: 5, hour: 22, minute: 41, second: 49, millisecond: 266, kind: DateTimeKind.Utc),
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1999, month: 10, day: 1, hour: 22, minute: 42, second: 13, millisecond: 119, kind: DateTimeKind.Utc),
new DateTime(year: 1978, month: 10, day: 1, hour: 20, minute: 20, second: 2, millisecond: 300, kind: DateTimeKind.Utc),
new DateTime(year: 1947, month: 10, day: 2, hour: 7, minute: 41, second: 13, millisecond: 415, kind: DateTimeKind.Utc),
},
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 2009, month: 10, day: 1, hour: 17, minute: 46, second: 29, millisecond: 175, kind: DateTimeKind.Utc),
new DateTime(year: 1980, month: 10, day: 7, hour: 1, minute: 55, second: 29, millisecond: 740, kind: DateTimeKind.Utc),
new DateTime(year: 1992, month: 10, day: 6, hour: 9, minute: 34, second: 18, millisecond: 775, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 19,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 2013, month: 10, day: 8, hour: 9, minute: 45, second: 24, millisecond: 987, kind: DateTimeKind.Utc),
new DateTime(year: 1925, month: 10, day: 7, hour: 8, minute: 28, second: 21, millisecond: 928, kind: DateTimeKind.Utc),
new DateTime(year: 1936, month: 10, day: 3, hour: 5, minute: 2, second: 18, millisecond: 19, kind: DateTimeKind.Utc),
new DateTime(year: 2001, month: 10, day: 19, hour: 22, minute: 2, second: 58, millisecond: 483, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1969, month: 10, day: 6, hour: 1, minute: 2, second: 38, millisecond: 506, kind: DateTimeKind.Utc),
new DateTime(year: 1945, month: 10, day: 2, hour: 8, minute: 15, second: 2, millisecond: 336, kind: DateTimeKind.Utc),
new DateTime(year: 1979, month: 10, day: 17, hour: 22, minute: 46, second: 52, millisecond: 296, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 20,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1932, month: 10, day: 6, hour: 4, minute: 56, second: 9, millisecond: 151, kind: DateTimeKind.Utc),
new DateTime(year: 1951, month: 10, day: 11, hour: 14, minute: 9, second: 6, millisecond: 375, kind: DateTimeKind.Utc),
new DateTime(year: 1964, month: 10, day: 11, hour: 17, minute: 28, second: 22, millisecond: 150, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 8,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1926, month: 10, day: 18, hour: 7, minute: 22, second: 43, millisecond: 799, kind: DateTimeKind.Utc),
new DateTime(year: 1982, month: 10, day: 19, hour: 5, minute: 11, second: 21, millisecond: 996, kind: DateTimeKind.Utc),
new DateTime(year: 1930, month: 10, day: 8, hour: 19, minute: 19, second: 41, millisecond: 456, kind: DateTimeKind.Utc),
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1933, month: 10, day: 4, hour: 16, minute: 55, second: 29, millisecond: 401, kind: DateTimeKind.Utc),
new DateTime(year: 2011, month: 10, day: 4, hour: 1, minute: 14, second: 15, millisecond: 425, kind: DateTimeKind.Utc),
new DateTime(year: 1968, month: 10, day: 14, hour: 21, minute: 48, second: 27, millisecond: 322, kind: DateTimeKind.Utc),
},
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 29,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1948, month: 10, day: 7, hour: 17, minute: 54, second: 28, millisecond: 505, kind: DateTimeKind.Utc),
new DateTime(year: 1975, month: 10, day: 16, hour: 18, minute: 44, second: 33, millisecond: 396, kind: DateTimeKind.Utc),
new DateTime(year: 2017, month: 10, day: 7, hour: 3, minute: 7, second: 6, millisecond: 921, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 38,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1942, month: 10, day: 1, hour: 16, minute: 45, second: 28, millisecond: 33, kind: DateTimeKind.Utc),
new DateTime(year: 1971, month: 10, day: 19, hour: 13, minute: 26, second: 47, millisecond: 262, kind: DateTimeKind.Utc),
new DateTime(year: 1980, month: 10, day: 13, hour: 20, minute: 12, second: 32, millisecond: 234, kind: DateTimeKind.Utc),
new DateTime(year: 1925, month: 10, day: 11, hour: 10, minute: 24, second: 57, millisecond: 915, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 16,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 2004, month: 10, day: 16, hour: 2, minute: 19, second: 46, millisecond: 97, kind: DateTimeKind.Utc),
new DateTime(year: 1993, month: 10, day: 17, hour: 21, minute: 40, second: 21, millisecond: 136, kind: DateTimeKind.Utc),
new DateTime(year: 1958, month: 10, day: 17, hour: 11, minute: 37, second: 43, millisecond: 931, kind: DateTimeKind.Utc),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 43,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1966, month: 10, day: 6, hour: 7, minute: 17, second: 52, millisecond: 962, kind: DateTimeKind.Utc),
new DateTime(year: 1972, month: 10, day: 9, hour: 9, minute: 27, second: 15, millisecond: 481, kind: DateTimeKind.Utc),
new DateTime(year: 2002, month: 10, day: 17, hour: 22, minute: 50, second: 5, millisecond: 682, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1977, month: 10, day: 14, hour: 21, minute: 48, second: 11, millisecond: 850, kind: DateTimeKind.Utc),
new DateTime(year: 1968, month: 10, day: 1, hour: 13, minute: 30, second: 20, millisecond: 830, kind: DateTimeKind.Utc),
new DateTime(year: 1932, month: 10, day: 13, hour: 5, minute: 34, second: 51, millisecond: 246, kind: DateTimeKind.Utc),
new DateTime(year: 1999, month: 10, day: 15, hour: 7, minute: 26, second: 8, millisecond: 725, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 52,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1994, month: 10, day: 5, hour: 2, minute: 42, second: 12, millisecond: 927, kind: DateTimeKind.Utc),
new DateTime(year: 2017, month: 10, day: 10, hour: 2, minute: 44, second: 28, millisecond: 79, kind: DateTimeKind.Utc),
new DateTime(year: 1967, month: 10, day: 2, hour: 10, minute: 42, second: 18, millisecond: 456, kind: DateTimeKind.Utc),
new DateTime(year: 1927, month: 10, day: 15, hour: 1, minute: 21, second: 15, millisecond: 539, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 18,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1943, month: 10, day: 18, hour: 6, minute: 47, second: 30, millisecond: 396, kind: DateTimeKind.Utc),
new DateTime(year: 2002, month: 10, day: 11, hour: 3, minute: 41, second: 34, millisecond: 227, kind: DateTimeKind.Utc),
new DateTime(year: 1941, month: 10, day: 16, hour: 22, minute: 42, second: 13, millisecond: 925, kind: DateTimeKind.Utc),
},
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1940, month: 10, day: 12, hour: 19, minute: 31, second: 39, millisecond: 272, kind: DateTimeKind.Utc),
new DateTime(year: 1938, month: 10, day: 19, hour: 12, minute: 38, second: 7, millisecond: 276, kind: DateTimeKind.Utc),
new DateTime(year: 1994, month: 10, day: 14, hour: 13, minute: 42, second: 28, millisecond: 712, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 56,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1966, month: 10, day: 13, hour: 19, minute: 36, second: 49, millisecond: 236, kind: DateTimeKind.Utc),
new DateTime(year: 1944, month: 10, day: 15, hour: 15, minute: 35, second: 53, millisecond: 695, kind: DateTimeKind.Utc),
new DateTime(year: 1966, month: 10, day: 5, hour: 3, minute: 48, second: 40, millisecond: 38, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1990, month: 10, day: 13, hour: 7, minute: 8, second: 58, millisecond: 90, kind: DateTimeKind.Utc),
new DateTime(year: 1985, month: 10, day: 12, hour: 9, minute: 29, second: 27, millisecond: 757, kind: DateTimeKind.Utc),
new DateTime(year: 2001, month: 10, day: 8, hour: 20, minute: 8, second: 25, millisecond: 400, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 61,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 2017, month: 10, day: 16, hour: 8, minute: 6, second: 39, millisecond: 183, kind: DateTimeKind.Utc),
new DateTime(year: 1922, month: 10, day: 7, hour: 6, minute: 39, second: 20, millisecond: 349, kind: DateTimeKind.Utc),
new DateTime(year: 1929, month: 10, day: 6, hour: 7, minute: 57, second: 42, millisecond: 980, kind: DateTimeKind.Utc),
new DateTime(year: 1922, month: 10, day: 9, hour: 21, minute: 5, second: 35, millisecond: 795, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 20,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1939, month: 10, day: 10, hour: 8, minute: 22, second: 57, millisecond: 98, kind: DateTimeKind.Utc),
new DateTime(year: 1932, month: 10, day: 4, hour: 22, minute: 40, second: 44, millisecond: 580, kind: DateTimeKind.Utc),
new DateTime(year: 1934, month: 10, day: 14, hour: 9, minute: 17, second: 40, millisecond: 747, kind: DateTimeKind.Utc),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 64,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1952, month: 10, day: 4, hour: 14, minute: 24, second: 56, millisecond: 343, kind: DateTimeKind.Utc),
new DateTime(year: 1971, month: 10, day: 7, hour: 10, minute: 3, second: 47, millisecond: 522, kind: DateTimeKind.Utc),
new DateTime(year: 2001, month: 10, day: 15, hour: 10, minute: 17, second: 27, millisecond: 785, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 71,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1962, month: 10, day: 9, hour: 17, minute: 15, second: 43, millisecond: 180, kind: DateTimeKind.Utc),
new DateTime(year: 1929, month: 10, day: 8, hour: 4, minute: 22, second: 45, millisecond: 384, kind: DateTimeKind.Utc),
new DateTime(year: 1982, month: 10, day: 8, hour: 8, minute: 7, second: 10, millisecond: 673, kind: DateTimeKind.Utc),
new DateTime(year: 2012, month: 10, day: 4, hour: 11, minute: 34, second: 22, millisecond: 200, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 22,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1937, month: 10, day: 8, hour: 16, minute: 18, second: 19, millisecond: 507, kind: DateTimeKind.Utc),
new DateTime(year: 1976, month: 10, day: 16, hour: 11, minute: 7, second: 18, millisecond: 853, kind: DateTimeKind.Utc),
new DateTime(year: 1980, month: 10, day: 19, hour: 13, minute: 27, second: 22, millisecond: 133, kind: DateTimeKind.Utc),
new DateTime(year: 1926, month: 10, day: 13, hour: 8, minute: 30, second: 31, millisecond: 160, kind: DateTimeKind.Utc),
},
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1961, month: 10, day: 7, hour: 20, minute: 54, second: 52, millisecond: 852, kind: DateTimeKind.Utc),
new DateTime(year: 1929, month: 10, day: 5, hour: 10, minute: 36, second: 42, millisecond: 659, kind: DateTimeKind.Utc),
new DateTime(year: 1949, month: 10, day: 18, hour: 22, minute: 13, second: 55, millisecond: 466, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 80,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1957, month: 10, day: 11, hour: 17, minute: 50, second: 28, millisecond: 932, kind: DateTimeKind.Utc),
new DateTime(year: 1985, month: 10, day: 18, hour: 3, minute: 43, second: 46, millisecond: 989, kind: DateTimeKind.Utc),
new DateTime(year: 1933, month: 10, day: 8, hour: 2, minute: 35, second: 8, millisecond: 331, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1938, month: 10, day: 5, hour: 16, minute: 57, second: 57, millisecond: 31, kind: DateTimeKind.Utc),
new DateTime(year: 1971, month: 10, day: 12, hour: 1, minute: 12, second: 22, millisecond: 634, kind: DateTimeKind.Utc),
new DateTime(year: 1940, month: 10, day: 8, hour: 6, minute: 39, second: 52, millisecond: 997, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 87,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1984, month: 10, day: 5, hour: 10, minute: 3, second: 58, millisecond: 148, kind: DateTimeKind.Utc),
new DateTime(year: 2006, month: 10, day: 4, hour: 8, minute: 58, second: 16, millisecond: 927, kind: DateTimeKind.Utc),
new DateTime(year: 1946, month: 10, day: 10, hour: 4, minute: 20, second: 37, millisecond: 990, kind: DateTimeKind.Utc),
new DateTime(year: 1925, month: 10, day: 8, hour: 8, minute: 12, second: 55, millisecond: 644, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 29,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1950, month: 10, day: 3, hour: 3, minute: 49, second: 3, millisecond: 30, kind: DateTimeKind.Utc),
new DateTime(year: 1998, month: 10, day: 13, hour: 11, minute: 11, second: 24, millisecond: 352, kind: DateTimeKind.Utc),
new DateTime(year: 1985, month: 10, day: 10, hour: 22, minute: 17, second: 7, millisecond: 111, kind: DateTimeKind.Utc),
new DateTime(year: 1991, month: 10, day: 17, hour: 7, minute: 1, second: 55, millisecond: 114, kind: DateTimeKind.Utc),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 95,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1928, month: 10, day: 13, hour: 11, minute: 11, second: 14, millisecond: 516, kind: DateTimeKind.Utc),
new DateTime(year: 1938, month: 10, day: 11, hour: 15, minute: 28, second: 35, millisecond: 135, kind: DateTimeKind.Utc),
new DateTime(year: 1999, month: 10, day: 11, hour: 19, minute: 34, second: 19, millisecond: 449, kind: DateTimeKind.Utc),
new DateTime(year: 1984, month: 10, day: 17, hour: 22, minute: 16, second: 57, millisecond: 229, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 103,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1928, month: 10, day: 12, hour: 11, minute: 27, second: 40, millisecond: 327, kind: DateTimeKind.Utc),
new DateTime(year: 2010, month: 10, day: 8, hour: 20, minute: 1, second: 51, millisecond: 663, kind: DateTimeKind.Utc),
new DateTime(year: 1948, month: 10, day: 10, hour: 22, minute: 20, second: 3, millisecond: 861, kind: DateTimeKind.Utc),
new DateTime(year: 1963, month: 10, day: 13, hour: 4, minute: 49, second: 47, millisecond: 143, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 36,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1980, month: 10, day: 17, hour: 14, minute: 27, second: 38, millisecond: 140, kind: DateTimeKind.Utc),
new DateTime(year: 1977, month: 10, day: 14, hour: 7, minute: 6, second: 43, millisecond: 220, kind: DateTimeKind.Utc),
new DateTime(year: 2017, month: 10, day: 7, hour: 22, minute: 58, second: 16, millisecond: 629, kind: DateTimeKind.Utc),
new DateTime(year: 2015, month: 10, day: 14, hour: 16, minute: 8, second: 38, millisecond: 387, kind: DateTimeKind.Utc),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 105,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1926, month: 10, day: 16, hour: 6, minute: 9, second: 20, millisecond: 435, kind: DateTimeKind.Utc),
new DateTime(year: 1985, month: 10, day: 9, hour: 19, minute: 31, second: 13, millisecond: 846, kind: DateTimeKind.Utc),
new DateTime(year: 1938, month: 10, day: 19, hour: 22, minute: 53, second: 19, millisecond: 41, kind: DateTimeKind.Utc),
new DateTime(year: 2010, month: 10, day: 10, hour: 1, minute: 18, second: 38, millisecond: 893, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 113,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1964, month: 10, day: 8, hour: 2, minute: 19, second: 1, millisecond: 725, kind: DateTimeKind.Utc),
new DateTime(year: 1982, month: 10, day: 1, hour: 21, minute: 42, second: 39, millisecond: 88, kind: DateTimeKind.Utc),
new DateTime(year: 1983, month: 10, day: 3, hour: 9, minute: 32, second: 55, millisecond: 392, kind: DateTimeKind.Utc),
new DateTime(year: 2017, month: 10, day: 12, hour: 21, minute: 51, second: 28, millisecond: 342, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 40,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1936, month: 10, day: 16, hour: 12, minute: 17, second: 35, millisecond: 488, kind: DateTimeKind.Utc),
new DateTime(year: 1929, month: 10, day: 13, hour: 13, minute: 50, second: 32, millisecond: 29, kind: DateTimeKind.Utc),
new DateTime(year: 1968, month: 10, day: 9, hour: 1, minute: 13, second: 54, millisecond: 677, kind: DateTimeKind.Utc),
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1965, month: 10, day: 11, hour: 10, minute: 47, second: 19, millisecond: 504, kind: DateTimeKind.Utc),
new DateTime(year: 1941, month: 10, day: 13, hour: 1, minute: 35, second: 53, millisecond: 934, kind: DateTimeKind.Utc),
new DateTime(year: 1986, month: 10, day: 15, hour: 1, minute: 28, second: 27, millisecond: 222, kind: DateTimeKind.Utc),
},
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1937, month: 10, day: 14, hour: 19, minute: 26, second: 46, millisecond: 569, kind: DateTimeKind.Utc),
new DateTime(year: 1967, month: 10, day: 13, hour: 17, minute: 16, second: 12, millisecond: 210, kind: DateTimeKind.Utc),
new DateTime(year: 1987, month: 10, day: 9, hour: 3, minute: 14, second: 30, millisecond: 598, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 117,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1957, month: 10, day: 17, hour: 9, minute: 47, second: 37, millisecond: 694, kind: DateTimeKind.Utc),
new DateTime(year: 1937, month: 10, day: 8, hour: 3, minute: 57, second: 3, millisecond: 51, kind: DateTimeKind.Utc),
new DateTime(year: 1958, month: 10, day: 8, hour: 14, minute: 40, second: 1, millisecond: 777, kind: DateTimeKind.Utc),
new DateTime(year: 1997, month: 10, day: 8, hour: 12, minute: 32, second: 37, millisecond: 707, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 126,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1966, month: 10, day: 16, hour: 15, minute: 51, second: 48, millisecond: 767, kind: DateTimeKind.Utc),
new DateTime(year: 1981, month: 10, day: 10, hour: 10, minute: 40, second: 24, millisecond: 535, kind: DateTimeKind.Utc),
new DateTime(year: 1930, month: 10, day: 6, hour: 1, minute: 27, second: 35, millisecond: 181, kind: DateTimeKind.Utc),
new DateTime(year: 1919, month: 10, day: 10, hour: 7, minute: 56, second: 29, millisecond: 871, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 46,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1929, month: 10, day: 13, hour: 8, minute: 13, second: 37, millisecond: 965, kind: DateTimeKind.Utc),
new DateTime(year: 1998, month: 10, day: 6, hour: 19, minute: 21, second: 44, millisecond: 619, kind: DateTimeKind.Utc),
new DateTime(year: 1943, month: 10, day: 18, hour: 20, minute: 52, second: 25, millisecond: 177, kind: DateTimeKind.Utc),
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1940, month: 10, day: 10, hour: 9, minute: 7, second: 38, millisecond: 95, kind: DateTimeKind.Utc),
new DateTime(year: 2001, month: 10, day: 11, hour: 12, minute: 12, second: 10, millisecond: 311, kind: DateTimeKind.Utc),
new DateTime(year: 1972, month: 10, day: 3, hour: 20, minute: 55, second: 35, millisecond: 507, kind: DateTimeKind.Utc),
},
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 129,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1953, month: 10, day: 10, hour: 19, minute: 27, second: 46, millisecond: 585, kind: DateTimeKind.Utc),
new DateTime(year: 2008, month: 10, day: 16, hour: 18, minute: 7, second: 5, millisecond: 498, kind: DateTimeKind.Utc),
new DateTime(year: 2005, month: 10, day: 2, hour: 19, minute: 31, second: 50, millisecond: 118, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 133,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1982, month: 10, day: 5, hour: 5, minute: 41, second: 52, millisecond: 492, kind: DateTimeKind.Utc),
new DateTime(year: 2009, month: 10, day: 11, hour: 3, minute: 17, second: 13, millisecond: 139, kind: DateTimeKind.Utc),
new DateTime(year: 1917, month: 10, day: 17, hour: 1, minute: 7, second: 51, millisecond: 781, kind: DateTimeKind.Utc),
new DateTime(year: 1935, month: 10, day: 16, hour: 21, minute: 16, second: 51, millisecond: 236, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 53,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 2001, month: 10, day: 1, hour: 12, minute: 1, second: 18, millisecond: 273, kind: DateTimeKind.Utc),
new DateTime(year: 1945, month: 10, day: 11, hour: 22, minute: 12, second: 18, millisecond: 751, kind: DateTimeKind.Utc),
new DateTime(year: 1931, month: 10, day: 3, hour: 20, minute: 11, second: 1, millisecond: 485, kind: DateTimeKind.Utc),
new DateTime(year: 1926, month: 10, day: 9, hour: 3, minute: 31, second: 23, millisecond: 147, kind: DateTimeKind.Utc),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 138,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1974, month: 10, day: 9, hour: 12, minute: 16, second: 53, millisecond: 30, kind: DateTimeKind.Utc),
new DateTime(year: 1999, month: 10, day: 7, hour: 17, minute: 51, second: 3, millisecond: 28, kind: DateTimeKind.Utc),
new DateTime(year: 1993, month: 10, day: 4, hour: 8, minute: 6, second: 8, millisecond: 723, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1944, month: 10, day: 15, hour: 1, minute: 39, second: 54, millisecond: 918, kind: DateTimeKind.Utc),
new DateTime(year: 1975, month: 10, day: 11, hour: 10, minute: 2, second: 1, millisecond: 308, kind: DateTimeKind.Utc),
new DateTime(year: 1966, month: 10, day: 3, hour: 14, minute: 8, second: 2, millisecond: 129, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 147,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1973, month: 10, day: 9, hour: 13, minute: 56, second: 30, millisecond: 826, kind: DateTimeKind.Utc),
new DateTime(year: 1980, month: 10, day: 3, hour: 5, minute: 6, second: 44, millisecond: 416, kind: DateTimeKind.Utc),
new DateTime(year: 2014, month: 10, day: 1, hour: 11, minute: 3, second: 27, millisecond: 142, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 57,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1982, month: 10, day: 15, hour: 9, minute: 36, second: 3, millisecond: 489, kind: DateTimeKind.Utc),
new DateTime(year: 1995, month: 10, day: 11, hour: 19, minute: 15, second: 49, millisecond: 103, kind: DateTimeKind.Utc),
new DateTime(year: 1962, month: 10, day: 10, hour: 8, minute: 22, second: 32, millisecond: 738, kind: DateTimeKind.Utc),
new DateTime(year: 1935, month: 10, day: 19, hour: 11, minute: 35, second: 16, millisecond: 477, kind: DateTimeKind.Utc),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 149,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1958, month: 10, day: 13, hour: 3, minute: 26, second: 53, millisecond: 482, kind: DateTimeKind.Utc),
new DateTime(year: 1979, month: 10, day: 11, hour: 4, minute: 2, second: 45, millisecond: 304, kind: DateTimeKind.Utc),
new DateTime(year: 1969, month: 10, day: 19, hour: 18, minute: 40, second: 49, millisecond: 436, kind: DateTimeKind.Utc),
new DateTime(year: 1954, month: 10, day: 6, hour: 22, minute: 39, second: 6, millisecond: 323, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1932, month: 10, day: 10, hour: 15, minute: 45, second: 11, millisecond: 692, kind: DateTimeKind.Utc),
new DateTime(year: 2014, month: 10, day: 16, hour: 10, minute: 41, second: 24, millisecond: 521, kind: DateTimeKind.Utc),
new DateTime(year: 1929, month: 10, day: 9, hour: 22, minute: 17, second: 38, millisecond: 952, kind: DateTimeKind.Utc),
new DateTime(year: 1968, month: 10, day: 4, hour: 16, minute: 28, second: 43, millisecond: 4, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 153,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1985, month: 10, day: 17, hour: 13, minute: 28, second: 15, millisecond: 593, kind: DateTimeKind.Utc),
new DateTime(year: 1978, month: 10, day: 7, hour: 6, minute: 48, second: 41, millisecond: 193, kind: DateTimeKind.Utc),
new DateTime(year: 1959, month: 10, day: 12, hour: 3, minute: 45, second: 46, millisecond: 228, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 58,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 2010, month: 10, day: 17, hour: 22, minute: 30, second: 2, millisecond: 663, kind: DateTimeKind.Utc),
new DateTime(year: 1974, month: 10, day: 7, hour: 21, minute: 46, second: 24, millisecond: 976, kind: DateTimeKind.Utc),
new DateTime(year: 1938, month: 10, day: 5, hour: 5, minute: 20, second: 27, millisecond: 874, kind: DateTimeKind.Utc),
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1944, month: 10, day: 9, hour: 8, minute: 9, second: 32, millisecond: 551, kind: DateTimeKind.Utc),
new DateTime(year: 1920, month: 10, day: 19, hour: 22, minute: 17, second: 43, millisecond: 128, kind: DateTimeKind.Utc),
new DateTime(year: 1997, month: 10, day: 14, hour: 18, minute: 21, second: 8, millisecond: 838, kind: DateTimeKind.Utc),
},
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 2003, month: 10, day: 13, hour: 16, minute: 50, second: 49, millisecond: 931, kind: DateTimeKind.Utc),
new DateTime(year: 1941, month: 10, day: 17, hour: 7, minute: 48, second: 27, millisecond: 11, kind: DateTimeKind.Utc),
new DateTime(year: 2007, month: 10, day: 12, hour: 9, minute: 46, second: 24, millisecond: 778, kind: DateTimeKind.Utc),
new DateTime(year: 1917, month: 10, day: 10, hour: 5, minute: 10, second: 19, millisecond: 584, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 155,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1962, month: 10, day: 6, hour: 2, minute: 45, second: 32, millisecond: 393, kind: DateTimeKind.Utc),
new DateTime(year: 2002, month: 10, day: 13, hour: 15, minute: 8, second: 44, millisecond: 699, kind: DateTimeKind.Utc),
new DateTime(year: 1932, month: 10, day: 10, hour: 3, minute: 31, second: 44, millisecond: 113, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1979, month: 10, day: 10, hour: 2, minute: 40, second: 36, millisecond: 412, kind: DateTimeKind.Utc),
new DateTime(year: 1984, month: 10, day: 9, hour: 5, minute: 52, second: 26, millisecond: 857, kind: DateTimeKind.Utc),
new DateTime(year: 1979, month: 10, day: 16, hour: 9, minute: 5, second: 48, millisecond: 576, kind: DateTimeKind.Utc),
new DateTime(year: 1957, month: 10, day: 14, hour: 14, minute: 51, second: 31, millisecond: 214, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 162,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1927, month: 10, day: 14, hour: 15, minute: 16, second: 8, millisecond: 27, kind: DateTimeKind.Utc),
new DateTime(year: 1929, month: 10, day: 3, hour: 21, minute: 8, second: 45, millisecond: 637, kind: DateTimeKind.Utc),
new DateTime(year: 1945, month: 10, day: 4, hour: 22, minute: 36, second: 20, millisecond: 867, kind: DateTimeKind.Utc),
new DateTime(year: 2007, month: 10, day: 5, hour: 15, minute: 46, second: 22, millisecond: 360, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 62,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1996, month: 10, day: 5, hour: 7, minute: 8, second: 45, millisecond: 891, kind: DateTimeKind.Utc),
new DateTime(year: 1932, month: 10, day: 14, hour: 12, minute: 32, second: 46, millisecond: 92, kind: DateTimeKind.Utc),
new DateTime(year: 2006, month: 10, day: 12, hour: 5, minute: 56, second: 39, millisecond: 792, kind: DateTimeKind.Utc),
new DateTime(year: 1960, month: 10, day: 6, hour: 6, minute: 20, second: 45, millisecond: 313, kind: DateTimeKind.Utc),
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 2009, month: 10, day: 17, hour: 20, minute: 14, second: 40, millisecond: 868, kind: DateTimeKind.Utc),
new DateTime(year: 1950, month: 10, day: 1, hour: 15, minute: 2, second: 43, millisecond: 507, kind: DateTimeKind.Utc),
new DateTime(year: 2000, month: 10, day: 1, hour: 12, minute: 41, second: 13, millisecond: 751, kind: DateTimeKind.Utc),
},
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 163,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1951, month: 10, day: 9, hour: 15, minute: 27, second: 47, millisecond: 282, kind: DateTimeKind.Utc),
new DateTime(year: 1981, month: 10, day: 5, hour: 3, minute: 21, second: 3, millisecond: 333, kind: DateTimeKind.Utc),
new DateTime(year: 1925, month: 10, day: 4, hour: 6, minute: 22, second: 32, millisecond: 101, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1988, month: 10, day: 3, hour: 4, minute: 31, second: 12, millisecond: 662, kind: DateTimeKind.Utc),
new DateTime(year: 1962, month: 10, day: 1, hour: 9, minute: 30, second: 33, millisecond: 616, kind: DateTimeKind.Utc),
new DateTime(year: 1979, month: 10, day: 9, hour: 1, minute: 58, second: 2, millisecond: 289, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 164,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1922, month: 10, day: 19, hour: 10, minute: 3, second: 53, millisecond: 290, kind: DateTimeKind.Utc),
new DateTime(year: 1942, month: 10, day: 16, hour: 10, minute: 6, second: 10, millisecond: 846, kind: DateTimeKind.Utc),
new DateTime(year: 1946, month: 10, day: 5, hour: 9, minute: 47, second: 34, millisecond: 157, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 67,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1983, month: 10, day: 16, hour: 16, minute: 28, second: 52, millisecond: 659, kind: DateTimeKind.Utc),
new DateTime(year: 1958, month: 10, day: 1, hour: 11, minute: 58, second: 55, millisecond: 347, kind: DateTimeKind.Utc),
new DateTime(year: 1993, month: 10, day: 17, hour: 1, minute: 17, second: 17, millisecond: 836, kind: DateTimeKind.Utc),
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.DateTime[4]
{
new DateTime(year: 1977, month: 10, day: 14, hour: 21, minute: 48, second: 11, millisecond: 850, kind: DateTimeKind.Utc),
new DateTime(year: 1968, month: 10, day: 1, hour: 13, minute: 30, second: 20, millisecond: 830, kind: DateTimeKind.Utc),
new DateTime(year: 1932, month: 10, day: 13, hour: 5, minute: 34, second: 51, millisecond: 246, kind: DateTimeKind.Utc),
new DateTime(year: 1999, month: 10, day: 15, hour: 7, minute: 26, second: 8, millisecond: 725, kind: DateTimeKind.Utc),
}));
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
new DateTime(year: 1940, month: 10, day: 12, hour: 19, minute: 31, second: 39, millisecond: 272, kind: DateTimeKind.Utc),
new DateTime(year: 1938, month: 10, day: 19, hour: 12, minute: 38, second: 7, millisecond: 276, kind: DateTimeKind.Utc),
new DateTime(year: 1994, month: 10, day: 14, hour: 13, minute: 42, second: 28, millisecond: 712, kind: DateTimeKind.Utc),
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
new System.DateTime[3]
{
new DateTime(year: 1990, month: 10, day: 13, hour: 7, minute: 8, second: 58, millisecond: 90, kind: DateTimeKind.Utc),
new DateTime(year: 1985, month: 10, day: 12, hour: 9, minute: 29, second: 27, millisecond: 757, kind: DateTimeKind.Utc),
new DateTime(year: 2001, month: 10, day: 8, hour: 20, minute: 8, second: 25, millisecond: 400, kind: DateTimeKind.Utc),
}));
                nullable =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
new System.DateTime[3]
{
new DateTime(year: 1961, month: 10, day: 7, hour: 20, minute: 54, second: 52, millisecond: 852, kind: DateTimeKind.Utc),
new DateTime(year: 1929, month: 10, day: 5, hour: 10, minute: 36, second: 42, millisecond: 659, kind: DateTimeKind.Utc),
new DateTime(year: 1949, month: 10, day: 18, hour: 22, minute: 13, second: 55, millisecond: 466, kind: DateTimeKind.Utc),
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
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zoneArray1M)],
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
LEFT JOIN public.datetimetimestamp_with_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
LEFT JOIN public.datetimetimestamp_with_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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

                var models =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zoneArray1M)],
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
LEFT JOIN public.datetimetimestamp_with_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
LEFT JOIN public.datetimetimestamp_with_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                var models =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zoneArray1M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
LEFT JOIN public.datetimetimestamp_with_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 153;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_with_time_zonearray1m m
LEFT JOIN public.datetimetimestamp_with_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray1mi_id
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
LEFT JOIN public.datetimetimestamp_with_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[18], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[19], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[20], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[21], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[22], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[23], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[24], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[25], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[8],_testData[26], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[9],_testData[27], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[10],_testData[28], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[26], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[27], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[28], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[29], false);
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
FROM public.datetimetimestamp_with_time_zonearray1m m
LEFT JOIN public.datetimetimestamp_with_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_with_time_zonearray1m m
LEFT JOIN public.datetimetimestamp_with_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray1mi_id
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
LEFT JOIN public.datetimetimestamp_with_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[7], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[8], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[9], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[10], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[11], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[12], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[13], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[14], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[8],_testData[15], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[9],_testData[16], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[10],_testData[17], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[11],_testData[18], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[12],_testData[19], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[13],_testData[20], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[14],_testData[21], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[15],_testData[22], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[16],_testData[23], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[17],_testData[24], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[18],_testData[25], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[19],_testData[26], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[20],_testData[27], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[21],_testData[28], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[21], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[22], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[23], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[24], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[25], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[26], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[27], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[28], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[8],_testData[29], false);
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
            batchName: "DbConnectionSelectModelDynParBatch",
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

                var models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 162;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[28], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[11], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[12], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[13], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[14], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[15], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[16], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[17], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[18], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[8],_testData[19], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[9],_testData[20], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[10],_testData[21], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[11],_testData[22], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[12],_testData[23], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[13],_testData[24], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[14],_testData[25], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[15],_testData[26], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[16],_testData[27], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[17],_testData[28], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[18],_testData[29], false);
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

                var models =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 149;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 149;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[25], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[26], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[27], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[28], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[25], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[26], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[27], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[28], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zoneArray1M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
LEFT JOIN public.datetimetimestamp_with_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zonearray1m m
LEFT JOIN public.datetimetimestamp_with_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray1mi_id
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
LEFT JOIN public.datetimetimestamp_with_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 95, query1, 20, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[15], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[16], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[17], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[18], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[19], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[20], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[21], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[22], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[8],_testData[23], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[9],_testData[24], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[10],_testData[25], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[11],_testData[26], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[12],_testData[27], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[13],_testData[28], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[4], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[5], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[6], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[7], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[8], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[9], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[10], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[11], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[8],_testData[12], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[9],_testData[13], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[10],_testData[14], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[11],_testData[15], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[12],_testData[16], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[13],_testData[17], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[14],_testData[18], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[15],_testData[19], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[16],_testData[20], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[17],_testData[21], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[18],_testData[22], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[19],_testData[23], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[20],_testData[24], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[21],_testData[25], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[22],_testData[26], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[23],_testData[27], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[24],_testData[28], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[25],_testData[29], false);
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
FROM public.datetimetimestamp_with_time_zonearray1m m
LEFT JOIN public.datetimetimestamp_with_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zonearray1m m
LEFT JOIN public.datetimetimestamp_with_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray1mi_id
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
LEFT JOIN public.datetimetimestamp_with_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionDynQuerySelectModelBatch(connection, 153, query1, 133, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[26], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[27], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[28], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[22], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[23], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[24], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[25], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[26], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[27], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[28], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[29], false);
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionSelectModelBatchAsync(connection, 153, 13))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[26], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[27], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[28], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[2], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[3], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[4], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[5], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[6], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[7], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[8], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[9], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[8],_testData[10], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[9],_testData[11], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[10],_testData[12], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[11],_testData[13], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[12],_testData[14], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[13],_testData[15], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[14],_testData[16], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[15],_testData[17], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[16],_testData[18], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[17],_testData[19], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[18],_testData[20], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[19],_testData[21], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[20],_testData[22], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[21],_testData[23], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[22],_testData[24], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[23],_testData[25], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[24],_testData[26], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[25],_testData[27], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[26],_testData[28], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[27],_testData[29], false);
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
                var models =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionSelectModelBatch(connection, 162, 149))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[28], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[25], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[26], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[27], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[28], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[29], false);
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
                ((IDateTimeArraytimestamp_with_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 138);
                var models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(7));
DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[23], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[24], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[25], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[26], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[27], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[28], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateTimeArraytimestamp_with_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 38);
                var models =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));
DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[6], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[7], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[8], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[9], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[10], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[11], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[12], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[13], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[8],_testData[14], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[9],_testData[15], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[10],_testData[16], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[11],_testData[17], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[12],_testData[18], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[13],_testData[19], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[14],_testData[20], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[15],_testData[21], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[16],_testData[22], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[17],_testData[23], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[18],_testData[24], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[19],_testData[25], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[20],_testData[26], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[21],_testData[27], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[22],_testData[28], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[23],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneArray1MI)],
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
FROM public.binary_datetimetimestamp_with_time_zonearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<DateTimetimestamp_with_time_zoneArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IDateTimeArraytimestamp_with_time_zoneArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDateTimeArraytimestamp_with_time_zoneArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray1MI.AssertModel(actual, expect, false);
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
                await ((IDateTimeArraytimestamp_with_time_zoneArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<DateTimetimestamp_with_time_zoneArray1M>(15);

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
                ((IDateTimeArraytimestamp_with_time_zoneArray)this).ImportModel(connection, importCollection);
                var models = ((IDateTimeArraytimestamp_with_time_zoneArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[0], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[1], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[2], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[3], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[4], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[5], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[6], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[7], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[8],_testData[8], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[9],_testData[9], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[10],_testData[10], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[11],_testData[11], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[12],_testData[12], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[13],_testData[13], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((IDateTimeArraytimestamp_with_time_zoneArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[0], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[1], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[2], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[3], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[4], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[5], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[6], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[7], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[8],_testData[8], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[9],_testData[9], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[10],_testData[10], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[11],_testData[11], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[12],_testData[12], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[13],_testData[13], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[14],_testData[14], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[15],_testData[15], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[16],_testData[16], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[17],_testData[17], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[18],_testData[18], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[19],_testData[19], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[20],_testData[20], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[21],_testData[21], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[22],_testData[22], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[23],_testData[23], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[24],_testData[24], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[25],_testData[25], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[26],_testData[26], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[27],_testData[27], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[28],_testData[28], false);
                DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[29],_testData[29], false);
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

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_datetimetimestamp_with_time_zonearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneArray1MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

