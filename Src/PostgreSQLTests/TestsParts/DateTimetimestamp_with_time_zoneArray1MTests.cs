

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
    Id = 4,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1982, month: 10, day: 13, hour: 11, minute: 10, second: 5, millisecond: 108, kind: DateTimeKind.Utc),
new DateTime(year: 1996, month: 10, day: 2, hour: 20, minute: 44, second: 52, millisecond: 462, kind: DateTimeKind.Utc),
new DateTime(year: 1989, month: 10, day: 7, hour: 7, minute: 56, second: 18, millisecond: 263, kind: DateTimeKind.Utc),
new DateTime(year: 1968, month: 10, day: 2, hour: 5, minute: 22, second: 40, millisecond: 389, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1950, month: 10, day: 4, hour: 20, minute: 16, second: 2, millisecond: 219, kind: DateTimeKind.Utc),
new DateTime(year: 1981, month: 10, day: 3, hour: 4, minute: 35, second: 28, millisecond: 439, kind: DateTimeKind.Utc),
new DateTime(year: 1926, month: 10, day: 13, hour: 10, minute: 33, second: 8, millisecond: 479, kind: DateTimeKind.Utc),
new DateTime(year: 2018, month: 10, day: 17, hour: 7, minute: 13, second: 58, millisecond: 331, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 9,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1954, month: 10, day: 8, hour: 6, minute: 56, second: 50, millisecond: 736, kind: DateTimeKind.Utc),
new DateTime(year: 2013, month: 10, day: 16, hour: 13, minute: 32, second: 30, millisecond: 3, kind: DateTimeKind.Utc),
new DateTime(year: 1981, month: 10, day: 5, hour: 19, minute: 43, second: 36, millisecond: 109, kind: DateTimeKind.Utc),
new DateTime(year: 1968, month: 10, day: 5, hour: 9, minute: 1, second: 43, millisecond: 140, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 5,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1966, month: 10, day: 1, hour: 4, minute: 24, second: 34, millisecond: 429, kind: DateTimeKind.Utc),
new DateTime(year: 1986, month: 10, day: 10, hour: 2, minute: 38, second: 36, millisecond: 414, kind: DateTimeKind.Utc),
new DateTime(year: 1945, month: 10, day: 6, hour: 14, minute: 42, second: 50, millisecond: 835, kind: DateTimeKind.Utc),
new DateTime(year: 1939, month: 10, day: 1, hour: 17, minute: 56, second: 27, millisecond: 981, kind: DateTimeKind.Utc),
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1932, month: 10, day: 15, hour: 14, minute: 11, second: 32, millisecond: 489, kind: DateTimeKind.Utc),
new DateTime(year: 1995, month: 10, day: 19, hour: 4, minute: 32, second: 37, millisecond: 42, kind: DateTimeKind.Utc),
new DateTime(year: 2014, month: 10, day: 7, hour: 22, minute: 56, second: 31, millisecond: 936, kind: DateTimeKind.Utc),
new DateTime(year: 1944, month: 10, day: 15, hour: 4, minute: 22, second: 11, millisecond: 613, kind: DateTimeKind.Utc),
},
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 2006, month: 10, day: 8, hour: 16, minute: 53, second: 44, millisecond: 982, kind: DateTimeKind.Utc),
new DateTime(year: 1952, month: 10, day: 9, hour: 4, minute: 7, second: 51, millisecond: 953, kind: DateTimeKind.Utc),
new DateTime(year: 1929, month: 10, day: 10, hour: 20, minute: 25, second: 34, millisecond: 705, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 17,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1959, month: 10, day: 3, hour: 20, minute: 45, second: 3, millisecond: 972, kind: DateTimeKind.Utc),
new DateTime(year: 1939, month: 10, day: 17, hour: 5, minute: 55, second: 28, millisecond: 167, kind: DateTimeKind.Utc),
new DateTime(year: 2010, month: 10, day: 6, hour: 3, minute: 39, second: 21, millisecond: 676, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 18,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1927, month: 10, day: 16, hour: 4, minute: 13, second: 20, millisecond: 460, kind: DateTimeKind.Utc),
new DateTime(year: 1929, month: 10, day: 15, hour: 4, minute: 35, second: 28, millisecond: 580, kind: DateTimeKind.Utc),
new DateTime(year: 1971, month: 10, day: 13, hour: 13, minute: 7, second: 29, millisecond: 260, kind: DateTimeKind.Utc),
new DateTime(year: 1941, month: 10, day: 4, hour: 11, minute: 57, second: 13, millisecond: 792, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 12,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1918, month: 10, day: 1, hour: 3, minute: 28, second: 16, millisecond: 250, kind: DateTimeKind.Utc),
new DateTime(year: 1995, month: 10, day: 4, hour: 4, minute: 29, second: 50, millisecond: 126, kind: DateTimeKind.Utc),
new DateTime(year: 1995, month: 10, day: 2, hour: 4, minute: 53, second: 54, millisecond: 794, kind: DateTimeKind.Utc),
new DateTime(year: 1946, month: 10, day: 3, hour: 9, minute: 53, second: 33, millisecond: 735, kind: DateTimeKind.Utc),
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1940, month: 10, day: 10, hour: 1, minute: 40, second: 23, millisecond: 957, kind: DateTimeKind.Utc),
new DateTime(year: 1943, month: 10, day: 2, hour: 17, minute: 25, second: 29, millisecond: 312, kind: DateTimeKind.Utc),
new DateTime(year: 1994, month: 10, day: 18, hour: 15, minute: 55, second: 31, millisecond: 225, kind: DateTimeKind.Utc),
new DateTime(year: 1919, month: 10, day: 2, hour: 11, minute: 23, second: 17, millisecond: 674, kind: DateTimeKind.Utc),
},
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 27,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1992, month: 10, day: 4, hour: 18, minute: 7, second: 11, millisecond: 331, kind: DateTimeKind.Utc),
new DateTime(year: 1972, month: 10, day: 7, hour: 19, minute: 27, second: 30, millisecond: 748, kind: DateTimeKind.Utc),
new DateTime(year: 1986, month: 10, day: 18, hour: 22, minute: 36, second: 57, millisecond: 502, kind: DateTimeKind.Utc),
new DateTime(year: 1928, month: 10, day: 2, hour: 1, minute: 29, second: 18, millisecond: 52, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 28,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1943, month: 10, day: 8, hour: 11, minute: 10, second: 4, millisecond: 659, kind: DateTimeKind.Utc),
new DateTime(year: 1942, month: 10, day: 9, hour: 6, minute: 23, second: 13, millisecond: 873, kind: DateTimeKind.Utc),
new DateTime(year: 2018, month: 10, day: 18, hour: 22, minute: 45, second: 43, millisecond: 901, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 21,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1950, month: 10, day: 4, hour: 9, minute: 4, second: 14, millisecond: 488, kind: DateTimeKind.Utc),
new DateTime(year: 2006, month: 10, day: 4, hour: 11, minute: 9, second: 51, millisecond: 194, kind: DateTimeKind.Utc),
new DateTime(year: 1926, month: 10, day: 8, hour: 16, minute: 49, second: 30, millisecond: 473, kind: DateTimeKind.Utc),
new DateTime(year: 1921, month: 10, day: 11, hour: 20, minute: 16, second: 49, millisecond: 885, kind: DateTimeKind.Utc),
},
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1986, month: 10, day: 5, hour: 11, minute: 5, second: 31, millisecond: 709, kind: DateTimeKind.Utc),
new DateTime(year: 1919, month: 10, day: 6, hour: 13, minute: 41, second: 18, millisecond: 893, kind: DateTimeKind.Utc),
new DateTime(year: 1970, month: 10, day: 9, hour: 15, minute: 28, second: 53, millisecond: 941, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 37,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1953, month: 10, day: 1, hour: 12, minute: 35, second: 47, millisecond: 773, kind: DateTimeKind.Utc),
new DateTime(year: 1961, month: 10, day: 19, hour: 15, minute: 1, second: 34, millisecond: 671, kind: DateTimeKind.Utc),
new DateTime(year: 2014, month: 10, day: 8, hour: 8, minute: 13, second: 5, millisecond: 699, kind: DateTimeKind.Utc),
new DateTime(year: 1953, month: 10, day: 18, hour: 6, minute: 19, second: 55, millisecond: 667, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 46,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1984, month: 10, day: 11, hour: 22, minute: 32, second: 31, millisecond: 823, kind: DateTimeKind.Utc),
new DateTime(year: 1956, month: 10, day: 2, hour: 22, minute: 57, second: 51, millisecond: 709, kind: DateTimeKind.Utc),
new DateTime(year: 1936, month: 10, day: 11, hour: 1, minute: 3, second: 47, millisecond: 72, kind: DateTimeKind.Utc),
new DateTime(year: 1943, month: 10, day: 10, hour: 20, minute: 49, second: 12, millisecond: 141, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 25,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1990, month: 10, day: 3, hour: 1, minute: 13, second: 43, millisecond: 983, kind: DateTimeKind.Utc),
new DateTime(year: 1984, month: 10, day: 2, hour: 16, minute: 18, second: 22, millisecond: 96, kind: DateTimeKind.Utc),
new DateTime(year: 1944, month: 10, day: 1, hour: 2, minute: 13, second: 35, millisecond: 93, kind: DateTimeKind.Utc),
new DateTime(year: 1961, month: 10, day: 6, hour: 15, minute: 15, second: 13, millisecond: 101, kind: DateTimeKind.Utc),
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1978, month: 10, day: 6, hour: 21, minute: 15, second: 30, millisecond: 554, kind: DateTimeKind.Utc),
new DateTime(year: 1951, month: 10, day: 18, hour: 20, minute: 21, second: 35, millisecond: 451, kind: DateTimeKind.Utc),
new DateTime(year: 1952, month: 10, day: 4, hour: 21, minute: 19, second: 51, millisecond: 663, kind: DateTimeKind.Utc),
},
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 47,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1944, month: 10, day: 10, hour: 7, minute: 57, second: 52, millisecond: 358, kind: DateTimeKind.Utc),
new DateTime(year: 1961, month: 10, day: 16, hour: 21, minute: 47, second: 49, millisecond: 802, kind: DateTimeKind.Utc),
new DateTime(year: 2018, month: 10, day: 4, hour: 15, minute: 50, second: 44, millisecond: 252, kind: DateTimeKind.Utc),
new DateTime(year: 1992, month: 10, day: 2, hour: 8, minute: 11, second: 42, millisecond: 118, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 52,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1990, month: 10, day: 2, hour: 4, minute: 23, second: 1, millisecond: 8, kind: DateTimeKind.Utc),
new DateTime(year: 1941, month: 10, day: 5, hour: 2, minute: 23, second: 5, millisecond: 386, kind: DateTimeKind.Utc),
new DateTime(year: 1947, month: 10, day: 1, hour: 3, minute: 18, second: 2, millisecond: 592, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 26,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 2013, month: 10, day: 5, hour: 18, minute: 1, second: 39, millisecond: 951, kind: DateTimeKind.Utc),
new DateTime(year: 1991, month: 10, day: 13, hour: 8, minute: 48, second: 42, millisecond: 282, kind: DateTimeKind.Utc),
new DateTime(year: 1964, month: 10, day: 8, hour: 11, minute: 33, second: 7, millisecond: 450, kind: DateTimeKind.Utc),
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 2001, month: 10, day: 12, hour: 9, minute: 56, second: 13, millisecond: 844, kind: DateTimeKind.Utc),
new DateTime(year: 1978, month: 10, day: 18, hour: 5, minute: 6, second: 40, millisecond: 510, kind: DateTimeKind.Utc),
new DateTime(year: 2002, month: 10, day: 5, hour: 15, minute: 3, second: 1, millisecond: 896, kind: DateTimeKind.Utc),
new DateTime(year: 1929, month: 10, day: 19, hour: 18, minute: 18, second: 32, millisecond: 301, kind: DateTimeKind.Utc),
},
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1950, month: 10, day: 10, hour: 19, minute: 41, second: 33, millisecond: 530, kind: DateTimeKind.Utc),
new DateTime(year: 1975, month: 10, day: 14, hour: 6, minute: 39, second: 8, millisecond: 567, kind: DateTimeKind.Utc),
new DateTime(year: 2004, month: 10, day: 10, hour: 12, minute: 51, second: 29, millisecond: 570, kind: DateTimeKind.Utc),
new DateTime(year: 1957, month: 10, day: 8, hour: 17, minute: 7, second: 38, millisecond: 476, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 57,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1975, month: 10, day: 16, hour: 18, minute: 21, second: 10, millisecond: 783, kind: DateTimeKind.Utc),
new DateTime(year: 2013, month: 10, day: 14, hour: 9, minute: 46, second: 54, millisecond: 387, kind: DateTimeKind.Utc),
new DateTime(year: 1918, month: 10, day: 4, hour: 21, minute: 19, second: 5, millisecond: 27, kind: DateTimeKind.Utc),
new DateTime(year: 1925, month: 10, day: 1, hour: 21, minute: 11, second: 4, millisecond: 791, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 58,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1921, month: 10, day: 18, hour: 3, minute: 27, second: 50, millisecond: 645, kind: DateTimeKind.Utc),
new DateTime(year: 1922, month: 10, day: 5, hour: 18, minute: 34, second: 51, millisecond: 68, kind: DateTimeKind.Utc),
new DateTime(year: 1955, month: 10, day: 14, hour: 11, minute: 25, second: 38, millisecond: 331, kind: DateTimeKind.Utc),
new DateTime(year: 1935, month: 10, day: 5, hour: 4, minute: 10, second: 19, millisecond: 635, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 30,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1950, month: 10, day: 6, hour: 3, minute: 21, second: 23, millisecond: 238, kind: DateTimeKind.Utc),
new DateTime(year: 1996, month: 10, day: 19, hour: 1, minute: 7, second: 15, millisecond: 764, kind: DateTimeKind.Utc),
new DateTime(year: 1929, month: 10, day: 4, hour: 21, minute: 54, second: 14, millisecond: 867, kind: DateTimeKind.Utc),
new DateTime(year: 1981, month: 10, day: 15, hour: 5, minute: 30, second: 45, millisecond: 543, kind: DateTimeKind.Utc),
},
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1949, month: 10, day: 2, hour: 12, minute: 44, second: 1, millisecond: 807, kind: DateTimeKind.Utc),
new DateTime(year: 2019, month: 10, day: 2, hour: 5, minute: 11, second: 10, millisecond: 741, kind: DateTimeKind.Utc),
new DateTime(year: 1967, month: 10, day: 19, hour: 6, minute: 21, second: 44, millisecond: 355, kind: DateTimeKind.Utc),
new DateTime(year: 1960, month: 10, day: 18, hour: 5, minute: 42, second: 6, millisecond: 984, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 62,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1976, month: 10, day: 8, hour: 7, minute: 13, second: 19, millisecond: 963, kind: DateTimeKind.Utc),
new DateTime(year: 2011, month: 10, day: 8, hour: 19, minute: 54, second: 46, millisecond: 425, kind: DateTimeKind.Utc),
new DateTime(year: 2007, month: 10, day: 15, hour: 10, minute: 18, second: 32, millisecond: 160, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 66,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 2010, month: 10, day: 8, hour: 5, minute: 57, second: 14, millisecond: 61, kind: DateTimeKind.Utc),
new DateTime(year: 1959, month: 10, day: 11, hour: 17, minute: 58, second: 25, millisecond: 527, kind: DateTimeKind.Utc),
new DateTime(year: 1987, month: 10, day: 10, hour: 19, minute: 1, second: 24, millisecond: 176, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 33,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1927, month: 10, day: 11, hour: 4, minute: 17, second: 34, millisecond: 30, kind: DateTimeKind.Utc),
new DateTime(year: 1931, month: 10, day: 4, hour: 6, minute: 21, second: 4, millisecond: 645, kind: DateTimeKind.Utc),
new DateTime(year: 1993, month: 10, day: 3, hour: 10, minute: 11, second: 23, millisecond: 258, kind: DateTimeKind.Utc),
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1974, month: 10, day: 12, hour: 19, minute: 23, second: 41, millisecond: 715, kind: DateTimeKind.Utc),
new DateTime(year: 1927, month: 10, day: 15, hour: 18, minute: 29, second: 55, millisecond: 6, kind: DateTimeKind.Utc),
new DateTime(year: 1997, month: 10, day: 15, hour: 5, minute: 32, second: 30, millisecond: 72, kind: DateTimeKind.Utc),
},
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 69,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1982, month: 10, day: 6, hour: 9, minute: 55, second: 25, millisecond: 633, kind: DateTimeKind.Utc),
new DateTime(year: 2006, month: 10, day: 18, hour: 3, minute: 19, second: 2, millisecond: 174, kind: DateTimeKind.Utc),
new DateTime(year: 1972, month: 10, day: 13, hour: 19, minute: 37, second: 27, millisecond: 944, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 73,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1932, month: 10, day: 2, hour: 5, minute: 23, second: 3, millisecond: 313, kind: DateTimeKind.Utc),
new DateTime(year: 1964, month: 10, day: 11, hour: 3, minute: 27, second: 54, millisecond: 163, kind: DateTimeKind.Utc),
new DateTime(year: 1928, month: 10, day: 5, hour: 21, minute: 41, second: 38, millisecond: 821, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 40,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1962, month: 10, day: 6, hour: 22, minute: 22, second: 41, millisecond: 285, kind: DateTimeKind.Utc),
new DateTime(year: 1953, month: 10, day: 1, hour: 1, minute: 53, second: 44, millisecond: 788, kind: DateTimeKind.Utc),
new DateTime(year: 1918, month: 10, day: 15, hour: 11, minute: 49, second: 14, millisecond: 375, kind: DateTimeKind.Utc),
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1949, month: 10, day: 11, hour: 13, minute: 31, second: 20, millisecond: 628, kind: DateTimeKind.Utc),
new DateTime(year: 1974, month: 10, day: 5, hour: 17, minute: 52, second: 32, millisecond: 302, kind: DateTimeKind.Utc),
new DateTime(year: 1937, month: 10, day: 4, hour: 14, minute: 1, second: 7, millisecond: 74, kind: DateTimeKind.Utc),
},
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 2015, month: 10, day: 11, hour: 16, minute: 51, second: 49, millisecond: 250, kind: DateTimeKind.Utc),
new DateTime(year: 2015, month: 10, day: 17, hour: 17, minute: 50, second: 28, millisecond: 846, kind: DateTimeKind.Utc),
new DateTime(year: 1931, month: 10, day: 4, hour: 8, minute: 50, second: 22, millisecond: 659, kind: DateTimeKind.Utc),
new DateTime(year: 2019, month: 10, day: 13, hour: 2, minute: 11, second: 11, millisecond: 343, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 81,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1987, month: 10, day: 5, hour: 22, minute: 56, second: 5, millisecond: 91, kind: DateTimeKind.Utc),
new DateTime(year: 1972, month: 10, day: 12, hour: 20, minute: 5, second: 27, millisecond: 165, kind: DateTimeKind.Utc),
new DateTime(year: 1917, month: 10, day: 19, hour: 4, minute: 54, second: 32, millisecond: 874, kind: DateTimeKind.Utc),
new DateTime(year: 1972, month: 10, day: 11, hour: 21, minute: 35, second: 45, millisecond: 59, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1928, month: 10, day: 11, hour: 13, minute: 48, second: 50, millisecond: 602, kind: DateTimeKind.Utc),
new DateTime(year: 1918, month: 10, day: 5, hour: 5, minute: 48, second: 45, millisecond: 79, kind: DateTimeKind.Utc),
new DateTime(year: 1944, month: 10, day: 6, hour: 9, minute: 42, second: 4, millisecond: 55, kind: DateTimeKind.Utc),
new DateTime(year: 1976, month: 10, day: 4, hour: 15, minute: 49, second: 9, millisecond: 908, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 83,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 2002, month: 10, day: 16, hour: 18, minute: 46, second: 51, millisecond: 126, kind: DateTimeKind.Utc),
new DateTime(year: 1953, month: 10, day: 2, hour: 7, minute: 42, second: 31, millisecond: 931, kind: DateTimeKind.Utc),
new DateTime(year: 1923, month: 10, day: 3, hour: 5, minute: 41, second: 39, millisecond: 754, kind: DateTimeKind.Utc),
new DateTime(year: 1989, month: 10, day: 18, hour: 20, minute: 50, second: 5, millisecond: 773, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 48,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 2019, month: 10, day: 8, hour: 3, minute: 53, second: 6, millisecond: 393, kind: DateTimeKind.Utc),
new DateTime(year: 1968, month: 10, day: 16, hour: 4, minute: 21, second: 34, millisecond: 283, kind: DateTimeKind.Utc),
new DateTime(year: 1923, month: 10, day: 5, hour: 7, minute: 23, second: 44, millisecond: 470, kind: DateTimeKind.Utc),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 88,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1979, month: 10, day: 18, hour: 6, minute: 58, second: 53, millisecond: 331, kind: DateTimeKind.Utc),
new DateTime(year: 1955, month: 10, day: 14, hour: 17, minute: 25, second: 46, millisecond: 154, kind: DateTimeKind.Utc),
new DateTime(year: 1979, month: 10, day: 15, hour: 14, minute: 8, second: 35, millisecond: 980, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 97,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 2017, month: 10, day: 19, hour: 11, minute: 33, second: 37, millisecond: 898, kind: DateTimeKind.Utc),
new DateTime(year: 1922, month: 10, day: 5, hour: 14, minute: 13, second: 17, millisecond: 821, kind: DateTimeKind.Utc),
new DateTime(year: 1945, month: 10, day: 16, hour: 11, minute: 4, second: 20, millisecond: 445, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 55,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1917, month: 10, day: 19, hour: 12, minute: 45, second: 49, millisecond: 244, kind: DateTimeKind.Utc),
new DateTime(year: 2005, month: 10, day: 5, hour: 12, minute: 58, second: 6, millisecond: 132, kind: DateTimeKind.Utc),
new DateTime(year: 2011, month: 10, day: 12, hour: 17, minute: 44, second: 52, millisecond: 981, kind: DateTimeKind.Utc),
new DateTime(year: 2003, month: 10, day: 1, hour: 5, minute: 11, second: 28, millisecond: 940, kind: DateTimeKind.Utc),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 102,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1945, month: 10, day: 11, hour: 3, minute: 32, second: 33, millisecond: 458, kind: DateTimeKind.Utc),
new DateTime(year: 2010, month: 10, day: 8, hour: 15, minute: 13, second: 43, millisecond: 805, kind: DateTimeKind.Utc),
new DateTime(year: 2016, month: 10, day: 13, hour: 11, minute: 6, second: 1, millisecond: 147, kind: DateTimeKind.Utc),
new DateTime(year: 1952, month: 10, day: 6, hour: 13, minute: 37, second: 5, millisecond: 46, kind: DateTimeKind.Utc),
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
new DateTime(year: 2017, month: 10, day: 14, hour: 8, minute: 56, second: 57, millisecond: 373, kind: DateTimeKind.Utc),
new DateTime(year: 1972, month: 10, day: 14, hour: 1, minute: 20, second: 13, millisecond: 167, kind: DateTimeKind.Utc),
new DateTime(year: 1941, month: 10, day: 15, hour: 14, minute: 14, second: 9, millisecond: 224, kind: DateTimeKind.Utc),
new DateTime(year: 1926, month: 10, day: 18, hour: 22, minute: 52, second: 27, millisecond: 316, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 56,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1982, month: 10, day: 11, hour: 19, minute: 43, second: 42, millisecond: 493, kind: DateTimeKind.Utc),
new DateTime(year: 1998, month: 10, day: 16, hour: 22, minute: 42, second: 43, millisecond: 962, kind: DateTimeKind.Utc),
new DateTime(year: 2006, month: 10, day: 13, hour: 4, minute: 54, second: 1, millisecond: 190, kind: DateTimeKind.Utc),
new DateTime(year: 1981, month: 10, day: 8, hour: 17, minute: 33, second: 49, millisecond: 575, kind: DateTimeKind.Utc),
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 2004, month: 10, day: 1, hour: 8, minute: 47, second: 7, millisecond: 285, kind: DateTimeKind.Utc),
new DateTime(year: 1954, month: 10, day: 11, hour: 4, minute: 11, second: 14, millisecond: 594, kind: DateTimeKind.Utc),
new DateTime(year: 1948, month: 10, day: 13, hour: 14, minute: 56, second: 57, millisecond: 950, kind: DateTimeKind.Utc),
},
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1939, month: 10, day: 10, hour: 20, minute: 38, second: 41, millisecond: 55, kind: DateTimeKind.Utc),
new DateTime(year: 1930, month: 10, day: 10, hour: 22, minute: 39, second: 52, millisecond: 240, kind: DateTimeKind.Utc),
new DateTime(year: 1957, month: 10, day: 9, hour: 10, minute: 23, second: 16, millisecond: 156, kind: DateTimeKind.Utc),
new DateTime(year: 1938, month: 10, day: 8, hour: 7, minute: 25, second: 39, millisecond: 639, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 106,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1937, month: 10, day: 5, hour: 2, minute: 12, second: 1, millisecond: 812, kind: DateTimeKind.Utc),
new DateTime(year: 1932, month: 10, day: 17, hour: 12, minute: 53, second: 1, millisecond: 118, kind: DateTimeKind.Utc),
new DateTime(year: 1962, month: 10, day: 8, hour: 5, minute: 36, second: 40, millisecond: 970, kind: DateTimeKind.Utc),
new DateTime(year: 1954, month: 10, day: 12, hour: 10, minute: 12, second: 45, millisecond: 21, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 110,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1937, month: 10, day: 1, hour: 22, minute: 53, second: 51, millisecond: 586, kind: DateTimeKind.Utc),
new DateTime(year: 1990, month: 10, day: 15, hour: 4, minute: 41, second: 5, millisecond: 432, kind: DateTimeKind.Utc),
new DateTime(year: 1945, month: 10, day: 19, hour: 7, minute: 17, second: 15, millisecond: 91, kind: DateTimeKind.Utc),
new DateTime(year: 1987, month: 10, day: 18, hour: 10, minute: 55, second: 9, millisecond: 386, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 62,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1929, month: 10, day: 8, hour: 22, minute: 21, second: 43, millisecond: 627, kind: DateTimeKind.Utc),
new DateTime(year: 1936, month: 10, day: 18, hour: 2, minute: 50, second: 38, millisecond: 610, kind: DateTimeKind.Utc),
new DateTime(year: 1926, month: 10, day: 8, hour: 4, minute: 32, second: 22, millisecond: 109, kind: DateTimeKind.Utc),
new DateTime(year: 1999, month: 10, day: 6, hour: 13, minute: 35, second: 31, millisecond: 426, kind: DateTimeKind.Utc),
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 2012, month: 10, day: 1, hour: 10, minute: 19, second: 28, millisecond: 297, kind: DateTimeKind.Utc),
new DateTime(year: 1927, month: 10, day: 16, hour: 16, minute: 11, second: 25, millisecond: 589, kind: DateTimeKind.Utc),
new DateTime(year: 1957, month: 10, day: 3, hour: 18, minute: 26, second: 21, millisecond: 454, kind: DateTimeKind.Utc),
},
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 2013, month: 10, day: 13, hour: 7, minute: 55, second: 37, millisecond: 353, kind: DateTimeKind.Utc),
new DateTime(year: 1959, month: 10, day: 6, hour: 17, minute: 42, second: 47, millisecond: 842, kind: DateTimeKind.Utc),
new DateTime(year: 2016, month: 10, day: 6, hour: 1, minute: 34, second: 5, millisecond: 64, kind: DateTimeKind.Utc),
new DateTime(year: 1982, month: 10, day: 4, hour: 9, minute: 40, second: 16, millisecond: 297, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 116,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1973, month: 10, day: 14, hour: 21, minute: 42, second: 56, millisecond: 156, kind: DateTimeKind.Utc),
new DateTime(year: 1953, month: 10, day: 2, hour: 16, minute: 13, second: 19, millisecond: 972, kind: DateTimeKind.Utc),
new DateTime(year: 1953, month: 10, day: 18, hour: 21, minute: 33, second: 11, millisecond: 993, kind: DateTimeKind.Utc),
new DateTime(year: 2011, month: 10, day: 16, hour: 13, minute: 26, second: 33, millisecond: 694, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 118,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1986, month: 10, day: 19, hour: 10, minute: 35, second: 18, millisecond: 987, kind: DateTimeKind.Utc),
new DateTime(year: 1956, month: 10, day: 2, hour: 3, minute: 57, second: 13, millisecond: 669, kind: DateTimeKind.Utc),
new DateTime(year: 1921, month: 10, day: 19, hour: 6, minute: 49, second: 43, millisecond: 225, kind: DateTimeKind.Utc),
new DateTime(year: 1921, month: 10, day: 13, hour: 15, minute: 32, second: 48, millisecond: 433, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 63,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1938, month: 10, day: 7, hour: 11, minute: 19, second: 20, millisecond: 777, kind: DateTimeKind.Utc),
new DateTime(year: 1950, month: 10, day: 4, hour: 9, minute: 20, second: 50, millisecond: 858, kind: DateTimeKind.Utc),
new DateTime(year: 1992, month: 10, day: 9, hour: 21, minute: 16, second: 15, millisecond: 252, kind: DateTimeKind.Utc),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 119,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1996, month: 10, day: 15, hour: 21, minute: 24, second: 15, millisecond: 747, kind: DateTimeKind.Utc),
new DateTime(year: 2002, month: 10, day: 6, hour: 8, minute: 3, second: 19, millisecond: 596, kind: DateTimeKind.Utc),
new DateTime(year: 1979, month: 10, day: 18, hour: 18, minute: 37, second: 55, millisecond: 733, kind: DateTimeKind.Utc),
new DateTime(year: 1970, month: 10, day: 8, hour: 4, minute: 23, second: 51, millisecond: 149, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1961, month: 10, day: 7, hour: 16, minute: 24, second: 12, millisecond: 882, kind: DateTimeKind.Utc),
new DateTime(year: 2012, month: 10, day: 3, hour: 7, minute: 15, second: 19, millisecond: 779, kind: DateTimeKind.Utc),
new DateTime(year: 1990, month: 10, day: 11, hour: 21, minute: 48, second: 36, millisecond: 281, kind: DateTimeKind.Utc),
new DateTime(year: 1926, month: 10, day: 17, hour: 12, minute: 46, second: 56, millisecond: 164, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 125,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1941, month: 10, day: 2, hour: 21, minute: 22, second: 29, millisecond: 146, kind: DateTimeKind.Utc),
new DateTime(year: 1941, month: 10, day: 16, hour: 22, minute: 48, second: 53, millisecond: 795, kind: DateTimeKind.Utc),
new DateTime(year: 2012, month: 10, day: 12, hour: 12, minute: 26, second: 29, millisecond: 772, kind: DateTimeKind.Utc),
new DateTime(year: 2012, month: 10, day: 8, hour: 1, minute: 29, second: 19, millisecond: 394, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 70,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1947, month: 10, day: 6, hour: 13, minute: 43, second: 45, millisecond: 425, kind: DateTimeKind.Utc),
new DateTime(year: 1934, month: 10, day: 19, hour: 1, minute: 15, second: 10, millisecond: 6, kind: DateTimeKind.Utc),
new DateTime(year: 1940, month: 10, day: 12, hour: 4, minute: 41, second: 58, millisecond: 218, kind: DateTimeKind.Utc),
new DateTime(year: 2000, month: 10, day: 12, hour: 11, minute: 11, second: 42, millisecond: 819, kind: DateTimeKind.Utc),
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 2001, month: 10, day: 11, hour: 22, minute: 57, second: 20, millisecond: 183, kind: DateTimeKind.Utc),
new DateTime(year: 1951, month: 10, day: 1, hour: 8, minute: 21, second: 23, millisecond: 981, kind: DateTimeKind.Utc),
new DateTime(year: 1996, month: 10, day: 5, hour: 4, minute: 38, second: 9, millisecond: 989, kind: DateTimeKind.Utc),
new DateTime(year: 1998, month: 10, day: 8, hour: 5, minute: 44, second: 37, millisecond: 364, kind: DateTimeKind.Utc),
},
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1933, month: 10, day: 7, hour: 22, minute: 2, second: 10, millisecond: 487, kind: DateTimeKind.Utc),
new DateTime(year: 1958, month: 10, day: 5, hour: 7, minute: 34, second: 3, millisecond: 845, kind: DateTimeKind.Utc),
new DateTime(year: 1956, month: 10, day: 13, hour: 2, minute: 5, second: 51, millisecond: 506, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 133,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1966, month: 10, day: 3, hour: 2, minute: 7, second: 3, millisecond: 631, kind: DateTimeKind.Utc),
new DateTime(year: 2011, month: 10, day: 7, hour: 15, minute: 54, second: 47, millisecond: 770, kind: DateTimeKind.Utc),
new DateTime(year: 1928, month: 10, day: 2, hour: 22, minute: 49, second: 17, millisecond: 103, kind: DateTimeKind.Utc),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1972, month: 10, day: 17, hour: 11, minute: 7, second: 7, millisecond: 474, kind: DateTimeKind.Utc),
new DateTime(year: 1941, month: 10, day: 3, hour: 20, minute: 6, second: 28, millisecond: 768, kind: DateTimeKind.Utc),
new DateTime(year: 1977, month: 10, day: 6, hour: 8, minute: 44, second: 42, millisecond: 615, kind: DateTimeKind.Utc),
new DateTime(year: 1994, month: 10, day: 18, hour: 8, minute: 39, second: 18, millisecond: 992, kind: DateTimeKind.Utc),
},
},
            new DateTimetimestamp_with_time_zoneArray1M
{
    Id = 140,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1943, month: 10, day: 19, hour: 13, minute: 16, second: 10, millisecond: 359, kind: DateTimeKind.Utc),
new DateTime(year: 1947, month: 10, day: 3, hour: 16, minute: 13, second: 49, millisecond: 657, kind: DateTimeKind.Utc),
new DateTime(year: 1979, month: 10, day: 18, hour: 22, minute: 36, second: 30, millisecond: 941, kind: DateTimeKind.Utc),
},
    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
{
    Id = 79,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1923, month: 10, day: 17, hour: 11, minute: 58, second: 48, millisecond: 303, kind: DateTimeKind.Utc),
new DateTime(year: 2009, month: 10, day: 7, hour: 8, minute: 29, second: 53, millisecond: 623, kind: DateTimeKind.Utc),
new DateTime(year: 2011, month: 10, day: 10, hour: 10, minute: 45, second: 12, millisecond: 813, kind: DateTimeKind.Utc),
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1964, month: 10, day: 3, hour: 22, minute: 56, second: 2, millisecond: 192, kind: DateTimeKind.Utc),
new DateTime(year: 1980, month: 10, day: 9, hour: 7, minute: 35, second: 5, millisecond: 494, kind: DateTimeKind.Utc),
new DateTime(year: 1929, month: 10, day: 16, hour: 8, minute: 14, second: 43, millisecond: 424, kind: DateTimeKind.Utc),
},
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1922, month: 10, day: 10, hour: 6, minute: 6, second: 34, millisecond: 786, kind: DateTimeKind.Utc),
new DateTime(year: 2019, month: 10, day: 11, hour: 10, minute: 8, second: 13, millisecond: 791, kind: DateTimeKind.Utc),
new DateTime(year: 1980, month: 10, day: 15, hour: 9, minute: 24, second: 42, millisecond: 167, kind: DateTimeKind.Utc),
new DateTime(year: 1977, month: 10, day: 2, hour: 11, minute: 23, second: 40, millisecond: 587, kind: DateTimeKind.Utc),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.DateTime[3]
{
new DateTime(year: 1986, month: 10, day: 5, hour: 11, minute: 5, second: 31, millisecond: 709, kind: DateTimeKind.Utc),
new DateTime(year: 1919, month: 10, day: 6, hour: 13, minute: 41, second: 18, millisecond: 893, kind: DateTimeKind.Utc),
new DateTime(year: 1970, month: 10, day: 9, hour: 15, minute: 28, second: 53, millisecond: 941, kind: DateTimeKind.Utc),
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
                nullable =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.DateTime[4]
{
new DateTime(year: 1950, month: 10, day: 10, hour: 19, minute: 41, second: 33, millisecond: 530, kind: DateTimeKind.Utc),
new DateTime(year: 1975, month: 10, day: 14, hour: 6, minute: 39, second: 8, millisecond: 567, kind: DateTimeKind.Utc),
new DateTime(year: 2004, month: 10, day: 10, hour: 12, minute: 51, second: 29, millisecond: 570, kind: DateTimeKind.Utc),
new DateTime(year: 1957, month: 10, day: 8, hour: 17, minute: 7, second: 38, millisecond: 476, kind: DateTimeKind.Utc),
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
new DateTime(year: 1949, month: 10, day: 2, hour: 12, minute: 44, second: 1, millisecond: 807, kind: DateTimeKind.Utc),
new DateTime(year: 2019, month: 10, day: 2, hour: 5, minute: 11, second: 10, millisecond: 741, kind: DateTimeKind.Utc),
new DateTime(year: 1967, month: 10, day: 19, hour: 6, minute: 21, second: 44, millisecond: 355, kind: DateTimeKind.Utc),
new DateTime(year: 1960, month: 10, day: 18, hour: 5, minute: 42, second: 6, millisecond: 984, kind: DateTimeKind.Utc),
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
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
                        Assert.That(models, Has.Count.EqualTo(13));
FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[17], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[18], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[19], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[20], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[21], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[22], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[23], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[24], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[8],_testData[25], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[9],_testData[26], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[10],_testData[27], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[11],_testData[28], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[1], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[2], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[3], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[4], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[5], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[6], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[7], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[8], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[8],_testData[9], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[9],_testData[10], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[10],_testData[11], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[11],_testData[12], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[12],_testData[13], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[13],_testData[14], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[14],_testData[15], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[15],_testData[16], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[16],_testData[17], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[17],_testData[18], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[18],_testData[19], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[19],_testData[20], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[20],_testData[21], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[21],_testData[22], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[22],_testData[23], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[23],_testData[24], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[24],_testData[25], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[25],_testData[26], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[26],_testData[27], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[27],_testData[28], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[28],_testData[29], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
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
                        Assert.That(models, Has.Count.EqualTo(12));
FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[18], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[19], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[20], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[21], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[22], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[23], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[24], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[25], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[8],_testData[26], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[9],_testData[27], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[10],_testData[28], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[28], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[29], false);
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[11], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[12], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[13], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[14], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[15], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[16], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[17], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[18], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[8],_testData[19], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[9],_testData[20], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[10],_testData[21], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[11],_testData[22], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[12],_testData[23], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[13],_testData[24], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[14],_testData[25], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[15],_testData[26], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[16],_testData[27], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[17],_testData[28], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[12], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[13], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[14], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[15], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[16], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[17], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[18], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[19], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[8],_testData[20], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[9],_testData[21], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[10],_testData[22], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[11],_testData[23], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[12],_testData[24], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[13],_testData[25], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[14],_testData[26], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[15],_testData[27], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[16],_testData[28], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[17],_testData[29], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[4], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[5], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[6], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[7], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[8], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[9], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[10], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[11], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[8],_testData[12], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[9],_testData[13], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[10],_testData[14], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[11],_testData[15], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[12],_testData[16], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[13],_testData[17], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[14],_testData[18], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[15],_testData[19], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[16],_testData[20], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[17],_testData[21], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[18],_testData[22], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[19],_testData[23], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[20],_testData[24], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[21],_testData[25], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[22],_testData[26], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[23],_testData[27], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[24],_testData[28], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[7], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[8], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[9], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[10], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[11], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[12], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[13], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[14], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[8],_testData[15], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[9],_testData[16], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[10],_testData[17], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[11],_testData[18], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[12],_testData[19], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[13],_testData[20], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[14],_testData[21], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[15],_testData[22], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[16],_testData[23], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[17],_testData[24], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[18],_testData[25], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[19],_testData[26], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[20],_testData[27], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[21],_testData[28], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[22],_testData[29], false);
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
                foreach(var batchResult in await ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 47, query1, 18, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[9], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[10], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[11], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[12], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[13], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[14], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[15], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[16], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[8],_testData[17], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[9],_testData[18], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[10],_testData[19], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[11],_testData[20], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[12],_testData[21], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[13],_testData[22], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[14],_testData[23], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[15],_testData[24], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[16],_testData[25], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[17],_testData[26], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[18],_testData[27], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[19],_testData[28], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[20],_testData[29], false);
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
                foreach(var batchResult in  ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionDynQuerySelectModelBatch(connection, 83, query1, 62, query2))
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
                        Assert.That(models, Has.Count.EqualTo(17));
FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[13], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[14], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[15], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[16], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[17], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[18], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[19], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[20], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[8],_testData[21], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[9],_testData[22], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[10],_testData[23], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[11],_testData[24], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[12],_testData[25], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[13],_testData[26], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[14],_testData[27], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[15],_testData[28], false);FlatDateTimetimestamp_with_time_zoneArray1M.AssertModel(models[16],_testData[29], false);
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
                foreach(var batchResult in await ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionSelectModelBatchAsync(connection, 103, 46))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[22], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[23], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[24], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[25], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[26], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[27], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[28], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[8], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[9], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[10], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[11], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[12], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[13], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[14], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[15], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[8],_testData[16], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[9],_testData[17], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[10],_testData[18], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[11],_testData[19], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[12],_testData[20], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[13],_testData[21], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[14],_testData[22], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[15],_testData[23], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[16],_testData[24], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[17],_testData[25], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[18],_testData[26], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[19],_testData[27], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[20],_testData[28], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[21],_testData[29], false);
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
                foreach(var batchResult in  ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionSelectModelBatch(connection, 83, 116))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[18], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[19], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[20], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[21], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[4],_testData[22], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[5],_testData[23], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[6],_testData[24], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[7],_testData[25], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[8],_testData[26], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[9],_testData[27], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[10],_testData[28], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[11],_testData[29], false);
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
                ((IDateTimeArraytimestamp_with_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 118);
                var models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[0],_testData[26], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[1],_testData[27], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[2],_testData[28], false);DateTimetimestamp_with_time_zoneArray1M.AssertModel(models[3],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateTimeArraytimestamp_with_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 28);
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

