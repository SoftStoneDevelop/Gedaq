

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
    internal partial interface IDateTimeArraytimestamp_without_time_zoneArray
    {
    }
    
    internal partial class DateTimeArraytimestamp_without_time_zoneArray : IDateTimeArraytimestamp_without_time_zoneArray
    {


#region TestData

        private readonly DateTimetimestamp_without_time_zoneArray1M[] _testData = new DateTimetimestamp_without_time_zoneArray1M[]
        {
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 4,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1978, month: 10, day: 7, hour: 21, minute: 18, second: 28, millisecond: 869, kind: DateTimeKind.Local),
new DateTime(year: 1959, month: 10, day: 16, hour: 16, minute: 16, second: 25, millisecond: 576, kind: DateTimeKind.Local),
new DateTime(year: 1948, month: 10, day: 5, hour: 2, minute: 29, second: 24, millisecond: 396, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 8,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1962, month: 10, day: 16, hour: 11, minute: 49, second: 44, millisecond: 132, kind: DateTimeKind.Local),
new DateTime(year: 1960, month: 10, day: 2, hour: 11, minute: 58, second: 2, millisecond: 204, kind: DateTimeKind.Local),
new DateTime(year: 1966, month: 10, day: 16, hour: 17, minute: 34, second: 21, millisecond: 659, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 8,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1980, month: 10, day: 14, hour: 4, minute: 19, second: 47, millisecond: 854, kind: DateTimeKind.Local),
new DateTime(year: 2012, month: 10, day: 13, hour: 4, minute: 48, second: 9, millisecond: 775, kind: DateTimeKind.Local),
new DateTime(year: 1955, month: 10, day: 5, hour: 14, minute: 54, second: 37, millisecond: 228, kind: DateTimeKind.Local),
new DateTime(year: 1954, month: 10, day: 4, hour: 1, minute: 28, second: 24, millisecond: 835, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 9,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 2003, month: 10, day: 7, hour: 13, minute: 38, second: 16, millisecond: 418, kind: DateTimeKind.Local),
new DateTime(year: 1953, month: 10, day: 19, hour: 8, minute: 48, second: 40, millisecond: 158, kind: DateTimeKind.Local),
new DateTime(year: 1951, month: 10, day: 10, hour: 20, minute: 11, second: 20, millisecond: 342, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 10,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1919, month: 10, day: 19, hour: 6, minute: 17, second: 19, millisecond: 805, kind: DateTimeKind.Local),
new DateTime(year: 1949, month: 10, day: 1, hour: 17, minute: 47, second: 43, millisecond: 684, kind: DateTimeKind.Local),
new DateTime(year: 1937, month: 10, day: 5, hour: 14, minute: 42, second: 29, millisecond: 361, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 16,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1940, month: 10, day: 10, hour: 20, minute: 21, second: 36, millisecond: 156, kind: DateTimeKind.Local),
new DateTime(year: 1922, month: 10, day: 14, hour: 8, minute: 56, second: 46, millisecond: 19, kind: DateTimeKind.Local),
new DateTime(year: 1937, month: 10, day: 10, hour: 7, minute: 19, second: 26, millisecond: 147, kind: DateTimeKind.Local),
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 2017, month: 10, day: 9, hour: 10, minute: 10, second: 38, millisecond: 711, kind: DateTimeKind.Local),
new DateTime(year: 2006, month: 10, day: 16, hour: 17, minute: 58, second: 42, millisecond: 555, kind: DateTimeKind.Local),
new DateTime(year: 1984, month: 10, day: 1, hour: 2, minute: 25, second: 25, millisecond: 122, kind: DateTimeKind.Local),
new DateTime(year: 1990, month: 10, day: 3, hour: 2, minute: 26, second: 7, millisecond: 791, kind: DateTimeKind.Local),
},
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 14,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1972, month: 10, day: 5, hour: 11, minute: 24, second: 48, millisecond: 400, kind: DateTimeKind.Local),
new DateTime(year: 1928, month: 10, day: 8, hour: 17, minute: 1, second: 40, millisecond: 565, kind: DateTimeKind.Local),
new DateTime(year: 1936, month: 10, day: 10, hour: 20, minute: 15, second: 30, millisecond: 666, kind: DateTimeKind.Local),
new DateTime(year: 2009, month: 10, day: 1, hour: 16, minute: 7, second: 27, millisecond: 231, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 18,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 2007, month: 10, day: 19, hour: 22, minute: 21, second: 24, millisecond: 357, kind: DateTimeKind.Local),
new DateTime(year: 1919, month: 10, day: 4, hour: 1, minute: 15, second: 42, millisecond: 501, kind: DateTimeKind.Local),
new DateTime(year: 1980, month: 10, day: 10, hour: 9, minute: 51, second: 13, millisecond: 188, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 18,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1978, month: 10, day: 16, hour: 4, minute: 40, second: 3, millisecond: 385, kind: DateTimeKind.Local),
new DateTime(year: 1971, month: 10, day: 18, hour: 12, minute: 11, second: 3, millisecond: 779, kind: DateTimeKind.Local),
new DateTime(year: 1921, month: 10, day: 18, hour: 19, minute: 29, second: 23, millisecond: 804, kind: DateTimeKind.Local),
new DateTime(year: 1921, month: 10, day: 3, hour: 11, minute: 8, second: 11, millisecond: 666, kind: DateTimeKind.Local),
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 2010, month: 10, day: 3, hour: 6, minute: 38, second: 50, millisecond: 479, kind: DateTimeKind.Local),
new DateTime(year: 1966, month: 10, day: 10, hour: 9, minute: 29, second: 53, millisecond: 453, kind: DateTimeKind.Local),
new DateTime(year: 1943, month: 10, day: 14, hour: 9, minute: 4, second: 28, millisecond: 853, kind: DateTimeKind.Local),
new DateTime(year: 1984, month: 10, day: 15, hour: 1, minute: 1, second: 38, millisecond: 950, kind: DateTimeKind.Local),
},
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 23,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1920, month: 10, day: 14, hour: 9, minute: 39, second: 15, millisecond: 720, kind: DateTimeKind.Local),
new DateTime(year: 1976, month: 10, day: 16, hour: 4, minute: 1, second: 28, millisecond: 963, kind: DateTimeKind.Local),
new DateTime(year: 1988, month: 10, day: 17, hour: 11, minute: 35, second: 10, millisecond: 498, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1928, month: 10, day: 10, hour: 8, minute: 5, second: 40, millisecond: 466, kind: DateTimeKind.Local),
new DateTime(year: 1982, month: 10, day: 11, hour: 17, minute: 49, second: 29, millisecond: 329, kind: DateTimeKind.Local),
new DateTime(year: 1999, month: 10, day: 10, hour: 6, minute: 8, second: 55, millisecond: 677, kind: DateTimeKind.Local),
new DateTime(year: 1950, month: 10, day: 13, hour: 20, minute: 23, second: 5, millisecond: 6, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 24,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 2014, month: 10, day: 6, hour: 1, minute: 22, second: 7, millisecond: 102, kind: DateTimeKind.Local),
new DateTime(year: 1918, month: 10, day: 19, hour: 16, minute: 23, second: 42, millisecond: 76, kind: DateTimeKind.Local),
new DateTime(year: 2013, month: 10, day: 10, hour: 2, minute: 6, second: 42, millisecond: 705, kind: DateTimeKind.Local),
new DateTime(year: 1994, month: 10, day: 11, hour: 9, minute: 55, second: 35, millisecond: 798, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 20,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1935, month: 10, day: 17, hour: 15, minute: 42, second: 55, millisecond: 369, kind: DateTimeKind.Local),
new DateTime(year: 1989, month: 10, day: 5, hour: 12, minute: 19, second: 33, millisecond: 468, kind: DateTimeKind.Local),
new DateTime(year: 1993, month: 10, day: 12, hour: 7, minute: 2, second: 44, millisecond: 251, kind: DateTimeKind.Local),
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 2008, month: 10, day: 8, hour: 11, minute: 52, second: 52, millisecond: 900, kind: DateTimeKind.Local),
new DateTime(year: 2001, month: 10, day: 6, hour: 9, minute: 11, second: 4, millisecond: 184, kind: DateTimeKind.Local),
new DateTime(year: 1994, month: 10, day: 13, hour: 2, minute: 7, second: 4, millisecond: 723, kind: DateTimeKind.Local),
new DateTime(year: 1989, month: 10, day: 8, hour: 2, minute: 3, second: 5, millisecond: 70, kind: DateTimeKind.Local),
},
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 27,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1957, month: 10, day: 4, hour: 22, minute: 31, second: 46, millisecond: 638, kind: DateTimeKind.Local),
new DateTime(year: 1961, month: 10, day: 18, hour: 10, minute: 57, second: 47, millisecond: 342, kind: DateTimeKind.Local),
new DateTime(year: 1968, month: 10, day: 15, hour: 12, minute: 51, second: 39, millisecond: 46, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1956, month: 10, day: 1, hour: 19, minute: 57, second: 3, millisecond: 199, kind: DateTimeKind.Local),
new DateTime(year: 1941, month: 10, day: 13, hour: 8, minute: 43, second: 42, millisecond: 859, kind: DateTimeKind.Local),
new DateTime(year: 2016, month: 10, day: 3, hour: 20, minute: 21, second: 19, millisecond: 236, kind: DateTimeKind.Local),
new DateTime(year: 2009, month: 10, day: 18, hour: 21, minute: 11, second: 1, millisecond: 25, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 30,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 2002, month: 10, day: 19, hour: 16, minute: 2, second: 5, millisecond: 748, kind: DateTimeKind.Local),
new DateTime(year: 1925, month: 10, day: 19, hour: 8, minute: 15, second: 40, millisecond: 860, kind: DateTimeKind.Local),
new DateTime(year: 1955, month: 10, day: 12, hour: 17, minute: 10, second: 56, millisecond: 56, kind: DateTimeKind.Local),
new DateTime(year: 1955, month: 10, day: 1, hour: 3, minute: 2, second: 30, millisecond: 900, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 29,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1999, month: 10, day: 2, hour: 6, minute: 28, second: 16, millisecond: 117, kind: DateTimeKind.Local),
new DateTime(year: 1964, month: 10, day: 15, hour: 22, minute: 22, second: 2, millisecond: 446, kind: DateTimeKind.Local),
new DateTime(year: 1980, month: 10, day: 9, hour: 4, minute: 50, second: 44, millisecond: 14, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 33,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1994, month: 10, day: 15, hour: 19, minute: 23, second: 34, millisecond: 376, kind: DateTimeKind.Local),
new DateTime(year: 1926, month: 10, day: 3, hour: 13, minute: 47, second: 9, millisecond: 314, kind: DateTimeKind.Local),
new DateTime(year: 1926, month: 10, day: 10, hour: 12, minute: 13, second: 35, millisecond: 393, kind: DateTimeKind.Local),
new DateTime(year: 1934, month: 10, day: 17, hour: 20, minute: 16, second: 14, millisecond: 837, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 36,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1968, month: 10, day: 16, hour: 20, minute: 18, second: 6, millisecond: 984, kind: DateTimeKind.Local),
new DateTime(year: 1970, month: 10, day: 11, hour: 2, minute: 56, second: 42, millisecond: 983, kind: DateTimeKind.Local),
new DateTime(year: 1978, month: 10, day: 7, hour: 12, minute: 3, second: 44, millisecond: 321, kind: DateTimeKind.Local),
new DateTime(year: 1997, month: 10, day: 19, hour: 22, minute: 38, second: 13, millisecond: 302, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 32,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1942, month: 10, day: 19, hour: 3, minute: 2, second: 36, millisecond: 349, kind: DateTimeKind.Local),
new DateTime(year: 2012, month: 10, day: 17, hour: 11, minute: 57, second: 58, millisecond: 206, kind: DateTimeKind.Local),
new DateTime(year: 1943, month: 10, day: 14, hour: 19, minute: 12, second: 28, millisecond: 146, kind: DateTimeKind.Local),
new DateTime(year: 1950, month: 10, day: 17, hour: 17, minute: 8, second: 22, millisecond: 133, kind: DateTimeKind.Local),
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 2006, month: 10, day: 3, hour: 13, minute: 36, second: 49, millisecond: 766, kind: DateTimeKind.Local),
new DateTime(year: 1930, month: 10, day: 9, hour: 9, minute: 54, second: 30, millisecond: 65, kind: DateTimeKind.Local),
new DateTime(year: 1943, month: 10, day: 12, hour: 10, minute: 43, second: 48, millisecond: 420, kind: DateTimeKind.Local),
},
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1923, month: 10, day: 5, hour: 13, minute: 37, second: 21, millisecond: 651, kind: DateTimeKind.Local),
new DateTime(year: 2013, month: 10, day: 2, hour: 17, minute: 41, second: 18, millisecond: 263, kind: DateTimeKind.Local),
new DateTime(year: 1997, month: 10, day: 17, hour: 4, minute: 35, second: 4, millisecond: 857, kind: DateTimeKind.Local),
new DateTime(year: 1968, month: 10, day: 10, hour: 3, minute: 21, second: 45, millisecond: 673, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 42,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1993, month: 10, day: 1, hour: 10, minute: 54, second: 43, millisecond: 650, kind: DateTimeKind.Local),
new DateTime(year: 2019, month: 10, day: 18, hour: 16, minute: 11, second: 23, millisecond: 38, kind: DateTimeKind.Local),
new DateTime(year: 2012, month: 10, day: 7, hour: 13, minute: 33, second: 41, millisecond: 661, kind: DateTimeKind.Local),
new DateTime(year: 1963, month: 10, day: 16, hour: 15, minute: 28, second: 29, millisecond: 385, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 2007, month: 10, day: 7, hour: 15, minute: 44, second: 6, millisecond: 886, kind: DateTimeKind.Local),
new DateTime(year: 1974, month: 10, day: 2, hour: 2, minute: 19, second: 36, millisecond: 711, kind: DateTimeKind.Local),
new DateTime(year: 2007, month: 10, day: 5, hour: 19, minute: 37, second: 30, millisecond: 115, kind: DateTimeKind.Local),
new DateTime(year: 1997, month: 10, day: 7, hour: 22, minute: 33, second: 7, millisecond: 608, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 44,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1948, month: 10, day: 15, hour: 12, minute: 1, second: 16, millisecond: 951, kind: DateTimeKind.Local),
new DateTime(year: 1918, month: 10, day: 17, hour: 5, minute: 20, second: 16, millisecond: 557, kind: DateTimeKind.Local),
new DateTime(year: 1998, month: 10, day: 13, hour: 16, minute: 46, second: 30, millisecond: 617, kind: DateTimeKind.Local),
new DateTime(year: 2005, month: 10, day: 3, hour: 20, minute: 40, second: 24, millisecond: 302, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 39,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1971, month: 10, day: 6, hour: 3, minute: 45, second: 51, millisecond: 127, kind: DateTimeKind.Local),
new DateTime(year: 1927, month: 10, day: 10, hour: 12, minute: 43, second: 3, millisecond: 116, kind: DateTimeKind.Local),
new DateTime(year: 2008, month: 10, day: 18, hour: 9, minute: 54, second: 17, millisecond: 21, kind: DateTimeKind.Local),
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1990, month: 10, day: 8, hour: 6, minute: 43, second: 55, millisecond: 600, kind: DateTimeKind.Local),
new DateTime(year: 2004, month: 10, day: 1, hour: 10, minute: 28, second: 15, millisecond: 555, kind: DateTimeKind.Local),
new DateTime(year: 1973, month: 10, day: 17, hour: 10, minute: 9, second: 21, millisecond: 71, kind: DateTimeKind.Local),
new DateTime(year: 1988, month: 10, day: 4, hour: 21, minute: 19, second: 16, millisecond: 862, kind: DateTimeKind.Local),
},
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 2008, month: 10, day: 3, hour: 11, minute: 45, second: 5, millisecond: 524, kind: DateTimeKind.Local),
new DateTime(year: 1962, month: 10, day: 17, hour: 18, minute: 24, second: 39, millisecond: 330, kind: DateTimeKind.Local),
new DateTime(year: 1943, month: 10, day: 11, hour: 21, minute: 26, second: 28, millisecond: 419, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 45,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 2012, month: 10, day: 7, hour: 11, minute: 50, second: 15, millisecond: 581, kind: DateTimeKind.Local),
new DateTime(year: 1952, month: 10, day: 8, hour: 10, minute: 17, second: 48, millisecond: 605, kind: DateTimeKind.Local),
new DateTime(year: 1980, month: 10, day: 14, hour: 17, minute: 56, second: 57, millisecond: 402, kind: DateTimeKind.Local),
new DateTime(year: 2007, month: 10, day: 17, hour: 14, minute: 30, second: 47, millisecond: 82, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 51,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1981, month: 10, day: 8, hour: 5, minute: 40, second: 16, millisecond: 573, kind: DateTimeKind.Local),
new DateTime(year: 1943, month: 10, day: 19, hour: 10, minute: 13, second: 56, millisecond: 361, kind: DateTimeKind.Local),
new DateTime(year: 1977, month: 10, day: 5, hour: 5, minute: 52, second: 37, millisecond: 884, kind: DateTimeKind.Local),
new DateTime(year: 2016, month: 10, day: 3, hour: 1, minute: 46, second: 14, millisecond: 812, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 48,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1940, month: 10, day: 2, hour: 1, minute: 22, second: 42, millisecond: 157, kind: DateTimeKind.Local),
new DateTime(year: 1921, month: 10, day: 17, hour: 22, minute: 35, second: 7, millisecond: 353, kind: DateTimeKind.Local),
new DateTime(year: 1973, month: 10, day: 7, hour: 15, minute: 58, second: 40, millisecond: 491, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 52,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1986, month: 10, day: 7, hour: 9, minute: 52, second: 54, millisecond: 462, kind: DateTimeKind.Local),
new DateTime(year: 1997, month: 10, day: 2, hour: 1, minute: 4, second: 12, millisecond: 930, kind: DateTimeKind.Local),
new DateTime(year: 1981, month: 10, day: 8, hour: 14, minute: 53, second: 23, millisecond: 627, kind: DateTimeKind.Local),
new DateTime(year: 1933, month: 10, day: 4, hour: 13, minute: 28, second: 21, millisecond: 853, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 2002, month: 10, day: 15, hour: 4, minute: 31, second: 9, millisecond: 313, kind: DateTimeKind.Local),
new DateTime(year: 1926, month: 10, day: 13, hour: 7, minute: 3, second: 38, millisecond: 518, kind: DateTimeKind.Local),
new DateTime(year: 1953, month: 10, day: 3, hour: 18, minute: 23, second: 31, millisecond: 39, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 58,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1935, month: 10, day: 7, hour: 9, minute: 31, second: 45, millisecond: 639, kind: DateTimeKind.Local),
new DateTime(year: 1919, month: 10, day: 19, hour: 20, minute: 36, second: 27, millisecond: 181, kind: DateTimeKind.Local),
new DateTime(year: 1917, month: 10, day: 14, hour: 20, minute: 16, second: 57, millisecond: 34, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 52,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1953, month: 10, day: 10, hour: 16, minute: 26, second: 14, millisecond: 475, kind: DateTimeKind.Local),
new DateTime(year: 1967, month: 10, day: 12, hour: 15, minute: 15, second: 6, millisecond: 305, kind: DateTimeKind.Local),
new DateTime(year: 1996, month: 10, day: 9, hour: 21, minute: 51, second: 12, millisecond: 558, kind: DateTimeKind.Local),
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1999, month: 10, day: 7, hour: 4, minute: 29, second: 49, millisecond: 591, kind: DateTimeKind.Local),
new DateTime(year: 1961, month: 10, day: 6, hour: 18, minute: 38, second: 18, millisecond: 882, kind: DateTimeKind.Local),
new DateTime(year: 1936, month: 10, day: 14, hour: 18, minute: 1, second: 49, millisecond: 24, kind: DateTimeKind.Local),
},
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 63,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1961, month: 10, day: 19, hour: 10, minute: 42, second: 38, millisecond: 9, kind: DateTimeKind.Local),
new DateTime(year: 1954, month: 10, day: 14, hour: 22, minute: 55, second: 30, millisecond: 296, kind: DateTimeKind.Local),
new DateTime(year: 1989, month: 10, day: 14, hour: 20, minute: 22, second: 27, millisecond: 773, kind: DateTimeKind.Local),
new DateTime(year: 1977, month: 10, day: 9, hour: 1, minute: 57, second: 51, millisecond: 432, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1939, month: 10, day: 9, hour: 7, minute: 27, second: 27, millisecond: 608, kind: DateTimeKind.Local),
new DateTime(year: 1950, month: 10, day: 3, hour: 18, minute: 24, second: 34, millisecond: 108, kind: DateTimeKind.Local),
new DateTime(year: 1956, month: 10, day: 5, hour: 22, minute: 52, second: 57, millisecond: 453, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 65,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1960, month: 10, day: 8, hour: 11, minute: 8, second: 31, millisecond: 523, kind: DateTimeKind.Local),
new DateTime(year: 2001, month: 10, day: 5, hour: 16, minute: 20, second: 23, millisecond: 952, kind: DateTimeKind.Local),
new DateTime(year: 1932, month: 10, day: 15, hour: 5, minute: 6, second: 35, millisecond: 99, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 58,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1990, month: 10, day: 19, hour: 10, minute: 51, second: 4, millisecond: 133, kind: DateTimeKind.Local),
new DateTime(year: 1978, month: 10, day: 7, hour: 14, minute: 48, second: 14, millisecond: 954, kind: DateTimeKind.Local),
new DateTime(year: 1939, month: 10, day: 4, hour: 21, minute: 48, second: 43, millisecond: 139, kind: DateTimeKind.Local),
new DateTime(year: 1972, month: 10, day: 9, hour: 7, minute: 35, second: 22, millisecond: 747, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 70,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1967, month: 10, day: 18, hour: 19, minute: 24, second: 24, millisecond: 427, kind: DateTimeKind.Local),
new DateTime(year: 1981, month: 10, day: 5, hour: 10, minute: 40, second: 47, millisecond: 209, kind: DateTimeKind.Local),
new DateTime(year: 1949, month: 10, day: 7, hour: 7, minute: 15, second: 27, millisecond: 155, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 75,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1970, month: 10, day: 14, hour: 3, minute: 37, second: 21, millisecond: 443, kind: DateTimeKind.Local),
new DateTime(year: 1986, month: 10, day: 13, hour: 2, minute: 47, second: 54, millisecond: 519, kind: DateTimeKind.Local),
new DateTime(year: 1988, month: 10, day: 16, hour: 19, minute: 24, second: 32, millisecond: 436, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 62,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1933, month: 10, day: 17, hour: 11, minute: 58, second: 13, millisecond: 512, kind: DateTimeKind.Local),
new DateTime(year: 1956, month: 10, day: 19, hour: 8, minute: 3, second: 23, millisecond: 340, kind: DateTimeKind.Local),
new DateTime(year: 2014, month: 10, day: 19, hour: 19, minute: 14, second: 23, millisecond: 10, kind: DateTimeKind.Local),
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1933, month: 10, day: 1, hour: 2, minute: 39, second: 14, millisecond: 733, kind: DateTimeKind.Local),
new DateTime(year: 1971, month: 10, day: 19, hour: 9, minute: 14, second: 6, millisecond: 772, kind: DateTimeKind.Local),
new DateTime(year: 2010, month: 10, day: 5, hour: 11, minute: 15, second: 27, millisecond: 690, kind: DateTimeKind.Local),
},
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1982, month: 10, day: 13, hour: 12, minute: 6, second: 23, millisecond: 42, kind: DateTimeKind.Local),
new DateTime(year: 1983, month: 10, day: 18, hour: 16, minute: 56, second: 7, millisecond: 881, kind: DateTimeKind.Local),
new DateTime(year: 2019, month: 10, day: 6, hour: 22, minute: 10, second: 50, millisecond: 120, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 84,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1984, month: 10, day: 5, hour: 9, minute: 24, second: 48, millisecond: 920, kind: DateTimeKind.Local),
new DateTime(year: 1981, month: 10, day: 11, hour: 22, minute: 2, second: 30, millisecond: 480, kind: DateTimeKind.Local),
new DateTime(year: 1979, month: 10, day: 6, hour: 15, minute: 15, second: 46, millisecond: 652, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 89,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1988, month: 10, day: 9, hour: 14, minute: 45, second: 58, millisecond: 356, kind: DateTimeKind.Local),
new DateTime(year: 1949, month: 10, day: 12, hour: 6, minute: 32, second: 40, millisecond: 6, kind: DateTimeKind.Local),
new DateTime(year: 1991, month: 10, day: 9, hour: 14, minute: 37, second: 48, millisecond: 292, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 70,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1945, month: 10, day: 15, hour: 5, minute: 20, second: 44, millisecond: 263, kind: DateTimeKind.Local),
new DateTime(year: 1967, month: 10, day: 11, hour: 3, minute: 36, second: 36, millisecond: 323, kind: DateTimeKind.Local),
new DateTime(year: 1918, month: 10, day: 19, hour: 2, minute: 26, second: 24, millisecond: 852, kind: DateTimeKind.Local),
new DateTime(year: 1928, month: 10, day: 16, hour: 10, minute: 34, second: 41, millisecond: 524, kind: DateTimeKind.Local),
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1960, month: 10, day: 5, hour: 12, minute: 48, second: 29, millisecond: 736, kind: DateTimeKind.Local),
new DateTime(year: 1949, month: 10, day: 2, hour: 1, minute: 28, second: 4, millisecond: 300, kind: DateTimeKind.Local),
new DateTime(year: 1946, month: 10, day: 4, hour: 13, minute: 43, second: 40, millisecond: 621, kind: DateTimeKind.Local),
},
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 2018, month: 10, day: 7, hour: 20, minute: 7, second: 8, millisecond: 522, kind: DateTimeKind.Local),
new DateTime(year: 1974, month: 10, day: 17, hour: 1, minute: 48, second: 3, millisecond: 633, kind: DateTimeKind.Local),
new DateTime(year: 1994, month: 10, day: 8, hour: 16, minute: 21, second: 21, millisecond: 41, kind: DateTimeKind.Local),
new DateTime(year: 1947, month: 10, day: 15, hour: 3, minute: 13, second: 36, millisecond: 466, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 90,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 2016, month: 10, day: 12, hour: 17, minute: 30, second: 9, millisecond: 388, kind: DateTimeKind.Local),
new DateTime(year: 1992, month: 10, day: 6, hour: 17, minute: 33, second: 41, millisecond: 524, kind: DateTimeKind.Local),
new DateTime(year: 1917, month: 10, day: 19, hour: 10, minute: 50, second: 41, millisecond: 212, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 96,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 2010, month: 10, day: 15, hour: 17, minute: 42, second: 33, millisecond: 325, kind: DateTimeKind.Local),
new DateTime(year: 1992, month: 10, day: 1, hour: 14, minute: 40, second: 51, millisecond: 444, kind: DateTimeKind.Local),
new DateTime(year: 1986, month: 10, day: 19, hour: 1, minute: 31, second: 53, millisecond: 368, kind: DateTimeKind.Local),
new DateTime(year: 1945, month: 10, day: 8, hour: 18, minute: 17, second: 43, millisecond: 313, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 73,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1969, month: 10, day: 9, hour: 22, minute: 15, second: 17, millisecond: 161, kind: DateTimeKind.Local),
new DateTime(year: 2017, month: 10, day: 6, hour: 2, minute: 31, second: 49, millisecond: 364, kind: DateTimeKind.Local),
new DateTime(year: 1977, month: 10, day: 16, hour: 12, minute: 10, second: 9, millisecond: 470, kind: DateTimeKind.Local),
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1957, month: 10, day: 9, hour: 3, minute: 30, second: 57, millisecond: 840, kind: DateTimeKind.Local),
new DateTime(year: 1981, month: 10, day: 5, hour: 14, minute: 25, second: 16, millisecond: 691, kind: DateTimeKind.Local),
new DateTime(year: 1923, month: 10, day: 10, hour: 15, minute: 9, second: 34, millisecond: 734, kind: DateTimeKind.Local),
new DateTime(year: 1959, month: 10, day: 11, hour: 13, minute: 51, second: 33, millisecond: 969, kind: DateTimeKind.Local),
},
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1933, month: 10, day: 16, hour: 11, minute: 43, second: 4, millisecond: 623, kind: DateTimeKind.Local),
new DateTime(year: 1953, month: 10, day: 1, hour: 15, minute: 2, second: 44, millisecond: 774, kind: DateTimeKind.Local),
new DateTime(year: 1966, month: 10, day: 15, hour: 12, minute: 20, second: 24, millisecond: 623, kind: DateTimeKind.Local),
new DateTime(year: 2001, month: 10, day: 9, hour: 13, minute: 47, second: 23, millisecond: 559, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 102,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1939, month: 10, day: 3, hour: 21, minute: 24, second: 17, millisecond: 706, kind: DateTimeKind.Local),
new DateTime(year: 1964, month: 10, day: 7, hour: 1, minute: 50, second: 20, millisecond: 890, kind: DateTimeKind.Local),
new DateTime(year: 1973, month: 10, day: 17, hour: 21, minute: 56, second: 22, millisecond: 760, kind: DateTimeKind.Local),
new DateTime(year: 2015, month: 10, day: 3, hour: 4, minute: 29, second: 35, millisecond: 865, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 105,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1943, month: 10, day: 14, hour: 3, minute: 16, second: 33, millisecond: 984, kind: DateTimeKind.Local),
new DateTime(year: 1918, month: 10, day: 2, hour: 8, minute: 51, second: 19, millisecond: 117, kind: DateTimeKind.Local),
new DateTime(year: 2016, month: 10, day: 2, hour: 18, minute: 22, second: 36, millisecond: 658, kind: DateTimeKind.Local),
new DateTime(year: 1968, month: 10, day: 12, hour: 18, minute: 50, second: 40, millisecond: 928, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 74,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1971, month: 10, day: 11, hour: 19, minute: 28, second: 16, millisecond: 147, kind: DateTimeKind.Local),
new DateTime(year: 2018, month: 10, day: 18, hour: 6, minute: 51, second: 52, millisecond: 664, kind: DateTimeKind.Local),
new DateTime(year: 1918, month: 10, day: 14, hour: 5, minute: 30, second: 51, millisecond: 346, kind: DateTimeKind.Local),
new DateTime(year: 1969, month: 10, day: 10, hour: 15, minute: 44, second: 38, millisecond: 390, kind: DateTimeKind.Local),
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 2003, month: 10, day: 2, hour: 17, minute: 2, second: 28, millisecond: 505, kind: DateTimeKind.Local),
new DateTime(year: 2008, month: 10, day: 19, hour: 1, minute: 37, second: 50, millisecond: 120, kind: DateTimeKind.Local),
new DateTime(year: 1921, month: 10, day: 12, hour: 8, minute: 6, second: 25, millisecond: 91, kind: DateTimeKind.Local),
},
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 2002, month: 10, day: 9, hour: 5, minute: 25, second: 15, millisecond: 626, kind: DateTimeKind.Local),
new DateTime(year: 1957, month: 10, day: 2, hour: 2, minute: 14, second: 22, millisecond: 810, kind: DateTimeKind.Local),
new DateTime(year: 1968, month: 10, day: 17, hour: 17, minute: 41, second: 20, millisecond: 903, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 106,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1935, month: 10, day: 16, hour: 22, minute: 51, second: 30, millisecond: 90, kind: DateTimeKind.Local),
new DateTime(year: 1930, month: 10, day: 18, hour: 6, minute: 47, second: 17, millisecond: 259, kind: DateTimeKind.Local),
new DateTime(year: 1935, month: 10, day: 2, hour: 2, minute: 37, second: 35, millisecond: 569, kind: DateTimeKind.Local),
new DateTime(year: 1981, month: 10, day: 4, hour: 17, minute: 46, second: 43, millisecond: 553, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 114,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1974, month: 10, day: 18, hour: 11, minute: 29, second: 49, millisecond: 542, kind: DateTimeKind.Local),
new DateTime(year: 2001, month: 10, day: 3, hour: 2, minute: 38, second: 45, millisecond: 346, kind: DateTimeKind.Local),
new DateTime(year: 1980, month: 10, day: 11, hour: 16, minute: 29, second: 21, millisecond: 752, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 77,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1994, month: 10, day: 5, hour: 20, minute: 14, second: 44, millisecond: 331, kind: DateTimeKind.Local),
new DateTime(year: 2013, month: 10, day: 9, hour: 3, minute: 42, second: 26, millisecond: 932, kind: DateTimeKind.Local),
new DateTime(year: 1947, month: 10, day: 1, hour: 3, minute: 8, second: 23, millisecond: 295, kind: DateTimeKind.Local),
new DateTime(year: 2010, month: 10, day: 18, hour: 16, minute: 27, second: 49, millisecond: 83, kind: DateTimeKind.Local),
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1993, month: 10, day: 11, hour: 17, minute: 38, second: 48, millisecond: 88, kind: DateTimeKind.Local),
new DateTime(year: 1979, month: 10, day: 12, hour: 3, minute: 33, second: 44, millisecond: 250, kind: DateTimeKind.Local),
new DateTime(year: 1973, month: 10, day: 17, hour: 1, minute: 17, second: 25, millisecond: 601, kind: DateTimeKind.Local),
},
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zonearray1mi(
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
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483627)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483627))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zonearray1mi(
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
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483627)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[]), 
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

                changedRows =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zonearray1m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_without_time_zonearray1mi_id
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
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483627)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483627)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "datetimetimestamp_without_time_zonearray1mi_id", 
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
                changedRows =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zonearray1m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_without_time_zonearray1mi_id
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
    datetimetimestamp_without_time_zonearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray)),
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
                    ((NpgsqlParameter<System.DateTime[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483627);
                    ((NpgsqlParameter<System.DateTime[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483627);
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

                    nullable =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.DateTime[]>();
                    ((NpgsqlParameter<System.DateTime[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483627);
                    ((NpgsqlParameter<System.DateTime[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483627);
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

                    nullable =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                    ((NpgsqlParameter<System.DateTime[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483627);
                    ((NpgsqlParameter<System.DateTime[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483627);
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

                    nullable = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.DateTime[4]
{
new DateTime(year: 1928, month: 10, day: 10, hour: 8, minute: 5, second: 40, millisecond: 466, kind: DateTimeKind.Local),
new DateTime(year: 1982, month: 10, day: 11, hour: 17, minute: 49, second: 29, millisecond: 329, kind: DateTimeKind.Local),
new DateTime(year: 1999, month: 10, day: 10, hour: 6, minute: 8, second: 55, millisecond: 677, kind: DateTimeKind.Local),
new DateTime(year: 1950, month: 10, day: 13, hour: 20, minute: 23, second: 5, millisecond: 6, kind: DateTimeKind.Local),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.DateTime[]>();
                    ((NpgsqlParameter<System.DateTime[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483627);
                    ((NpgsqlParameter<System.DateTime[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483627);
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

                    nullable = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zonearray1m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_without_time_zonearray1mi_id
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
    datetimetimestamp_without_time_zonearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483627)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483627)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "datetimetimestamp_without_time_zonearray1mi_id", 
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
                nullable =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.DateTime[4]
{
new DateTime(year: 1956, month: 10, day: 1, hour: 19, minute: 57, second: 3, millisecond: 199, kind: DateTimeKind.Local),
new DateTime(year: 1941, month: 10, day: 13, hour: 8, minute: 43, second: 42, millisecond: 859, kind: DateTimeKind.Local),
new DateTime(year: 2016, month: 10, day: 3, hour: 20, minute: 21, second: 19, millisecond: 236, kind: DateTimeKind.Local),
new DateTime(year: 2009, month: 10, day: 18, hour: 21, minute: 11, second: 1, millisecond: 25, kind: DateTimeKind.Local),
}));
                nullable =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
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
                nullable = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.DateTime[4]
{
new DateTime(year: 1923, month: 10, day: 5, hour: 13, minute: 37, second: 21, millisecond: 651, kind: DateTimeKind.Local),
new DateTime(year: 2013, month: 10, day: 2, hour: 17, minute: 41, second: 18, millisecond: 263, kind: DateTimeKind.Local),
new DateTime(year: 1997, month: 10, day: 17, hour: 4, minute: 35, second: 4, millisecond: 857, kind: DateTimeKind.Local),
new DateTime(year: 1968, month: 10, day: 10, hour: 3, minute: 21, second: 45, millisecond: 673, kind: DateTimeKind.Local),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DateTimetimestamp_without_time_zoneArray1M> models = null;

                models =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DateTimetimestamp_without_time_zoneArray1M> models = null;

                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray)),
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
FROM public.datetimetimestamp_without_time_zonearray1m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonearray1m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonearray1m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray)),
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

                var models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray)),
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
FROM public.datetimetimestamp_without_time_zonearray1m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonearray1m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonearray1m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray)),
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
                var models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray)),
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
FROM public.datetimetimestamp_without_time_zonearray1m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_without_time_zonearray1m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray1mi_id
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
FROM public.datetimetimestamp_without_time_zonearray1m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[24], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[25], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[26], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[27], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[28], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[6], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[7], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[8], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[9], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[10], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[11], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[12], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[13], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[14], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[15], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[16], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[17], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[18], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[19], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[20], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[21], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[16],_testData[22], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[17],_testData[23], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[18],_testData[24], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[19],_testData[25], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[20],_testData[26], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[21],_testData[27], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[22],_testData[28], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[23],_testData[29], false);
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
FROM public.datetimetimestamp_without_time_zonearray1m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_without_time_zonearray1m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray1mi_id
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
FROM public.datetimetimestamp_without_time_zonearray1m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[3], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[4], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[5], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[6], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[7], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[8], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[9], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[10], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[11], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[12], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[13], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[14], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[15], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[16], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[17], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[18], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[16],_testData[19], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[17],_testData[20], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[18],_testData[21], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[19],_testData[22], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[20],_testData[23], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[21],_testData[24], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[22],_testData[25], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[23],_testData[26], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[24],_testData[27], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[25],_testData[28], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[5], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[6], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[7], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[8], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[9], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[10], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[11], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[12], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[13], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[14], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[15], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[16], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[17], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[18], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[19], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[20], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[16],_testData[21], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[17],_testData[22], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[18],_testData[23], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[19],_testData[24], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[20],_testData[25], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[21],_testData[26], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[22],_testData[27], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[23],_testData[28], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[24],_testData[29], false);
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
FROM public.datetimetimestamp_without_time_zonearray1m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray)),
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

                var models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[1], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[2], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[3], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[4], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[5], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[6], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[7], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[8], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[9], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[10], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[11], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[12], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[13], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[14], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[15], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[16], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[16],_testData[17], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[17],_testData[18], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[18],_testData[19], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[19],_testData[20], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[20],_testData[21], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[21],_testData[22], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[22],_testData[23], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[23],_testData[24], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[24],_testData[25], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[25],_testData[26], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[26],_testData[27], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[27],_testData[28], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[26], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[27], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[28], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[29], false);
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

                var models =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[4], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[5], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[6], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[7], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[8], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[9], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[10], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[11], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[12], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[13], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[14], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[15], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[16], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[17], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[18], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[19], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[16],_testData[20], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[17],_testData[21], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[18],_testData[22], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[19],_testData[23], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[20],_testData[24], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[21],_testData[25], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[22],_testData[26], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[23],_testData[27], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[24],_testData[28], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[18], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[19], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[20], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[21], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[22], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[23], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[24], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[25], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[26], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[27], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[28], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray)),
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
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray)),
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
FROM public.datetimetimestamp_without_time_zonearray1m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonearray1m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray1mi_id
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
FROM public.datetimetimestamp_without_time_zonearray1m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 105, query1, 51, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[28], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[16], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[17], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[18], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[19], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[20], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[21], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[22], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[23], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[24], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[25], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[26], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[27], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[28], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[29], false);
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
FROM public.datetimetimestamp_without_time_zonearray1m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonearray1m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray1mi_id
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
FROM public.datetimetimestamp_without_time_zonearray1m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatch(connection, 84, query1, 18, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[23], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[24], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[25], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[26], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[27], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[28], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[6], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[7], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[8], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[9], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[10], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[11], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[12], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[13], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[14], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[15], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[16], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[17], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[18], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[19], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[20], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[21], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[16],_testData[22], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[17],_testData[23], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[18],_testData[24], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[19],_testData[25], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[20],_testData[26], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[21],_testData[27], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[22],_testData[28], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[23],_testData[29], false);
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
FROM public.datetimetimestamp_without_time_zonearray1m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray)),
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
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray)),
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
                var models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSelectModelBatchAsync(connection, 8, 90))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[2], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[3], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[4], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[5], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[6], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[7], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[8], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[9], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[10], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[11], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[12], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[13], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[14], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[15], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[16], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[17], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[16],_testData[18], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[17],_testData[19], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[18],_testData[20], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[19],_testData[21], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[20],_testData[22], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[21],_testData[23], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[22],_testData[24], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[23],_testData[25], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[24],_testData[26], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[25],_testData[27], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[26],_testData[28], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[25], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[26], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[27], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[28], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[29], false);
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
                var models =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSelectModelBatch(connection, 65, 36))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[20], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[21], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[22], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[23], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[24], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[25], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[26], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[27], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[28], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[12], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[13], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[14], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[15], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[16], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[17], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[18], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[19], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[20], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[21], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[22], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[23], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[24], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[25], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[26], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[27], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[16],_testData[28], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[17],_testData[29], false);
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
                await using var cmd = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDateTimeArraytimestamp_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 23);
                var models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[7], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[8], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[9], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[10], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[11], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[12], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[13], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[14], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[15], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[16], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[17], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[18], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[19], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[20], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[21], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[22], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[16],_testData[23], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[17],_testData[24], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[18],_testData[25], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[19],_testData[26], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[20],_testData[27], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[21],_testData[28], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[22],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateTimeArraytimestamp_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 14);
                var models =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[5], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[6], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[7], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[8], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[9], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[10], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[11], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[12], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[13], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[14], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[15], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[16], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[17], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[18], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[19], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[20], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[16],_testData[21], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[17],_testData[22], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[18],_testData[23], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[19],_testData[24], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[20],_testData[25], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[21],_testData[26], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[22],_testData[27], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[23],_testData[28], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[24],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_datetimetimestamp_without_time_zonearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray1MI)],
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
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray))]
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
FROM public.binary_datetimetimestamp_without_time_zonearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<DateTimetimestamp_without_time_zoneArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IDateTimeArraytimestamp_without_time_zoneArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDateTimeArraytimestamp_without_time_zoneArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray1MI.AssertModel(actual, expect, false);
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
                await ((IDateTimeArraytimestamp_without_time_zoneArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_datetimetimestamp_without_time_zonearray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
datetimetimestamp_without_time_zonearray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray1M)],
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
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray))]
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
FROM public.binary_datetimetimestamp_without_time_zonearray1m m
LEFT JOIN public.binary_datetimetimestamp_without_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<DateTimetimestamp_without_time_zoneArray1M>(15);

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
                ((IDateTimeArraytimestamp_without_time_zoneArray)this).ImportModel(connection, importCollection);
                var models = ((IDateTimeArraytimestamp_without_time_zoneArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[0], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[1], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[2], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[3], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[4], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[5], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[6], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[7], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[8], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[9], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[10], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[11], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[12], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[13], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((IDateTimeArraytimestamp_without_time_zoneArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[0], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[1], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[2], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[3], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[4], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[5], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[6], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[7], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[8], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[9], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[10], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[11], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[12], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[13], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[14], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[15], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[16],_testData[16], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[17],_testData[17], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[18],_testData[18], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[19],_testData[19], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[20],_testData[20], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[21],_testData[21], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[22],_testData[22], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[23],_testData[23], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[24],_testData[24], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[25],_testData[25], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[26],_testData[26], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[27],_testData[27], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[28],_testData[28], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_datetimetimestamp_without_time_zonearray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    datetimetimestamp_without_time_zonearray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray1M)],
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
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DateTimetimestamp_without_time_zoneArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DateTimetimestamp_without_time_zoneArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_datetimetimestamp_without_time_zonearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray1MI)],
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
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

