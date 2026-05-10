

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
    Id = 3,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 2011, month: 10, day: 15, hour: 1, minute: 8, second: 45, millisecond: 350, kind: DateTimeKind.Local),
new DateTime(year: 2019, month: 10, day: 7, hour: 19, minute: 46, second: 45, millisecond: 205, kind: DateTimeKind.Local),
new DateTime(year: 1984, month: 10, day: 1, hour: 20, minute: 27, second: 3, millisecond: 221, kind: DateTimeKind.Local),
new DateTime(year: 1948, month: 10, day: 17, hour: 18, minute: 2, second: 33, millisecond: 329, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1936, month: 10, day: 18, hour: 4, minute: 24, second: 10, millisecond: 41, kind: DateTimeKind.Local),
new DateTime(year: 2011, month: 10, day: 5, hour: 3, minute: 58, second: 10, millisecond: 259, kind: DateTimeKind.Local),
new DateTime(year: 1993, month: 10, day: 11, hour: 20, minute: 54, second: 14, millisecond: 105, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 12,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1952, month: 10, day: 16, hour: 6, minute: 35, second: 7, millisecond: 180, kind: DateTimeKind.Local),
new DateTime(year: 1919, month: 10, day: 11, hour: 14, minute: 37, second: 32, millisecond: 106, kind: DateTimeKind.Local),
new DateTime(year: 1949, month: 10, day: 6, hour: 18, minute: 12, second: 9, millisecond: 925, kind: DateTimeKind.Local),
new DateTime(year: 2006, month: 10, day: 5, hour: 7, minute: 17, second: 35, millisecond: 724, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 2,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1986, month: 10, day: 3, hour: 20, minute: 32, second: 13, millisecond: 11, kind: DateTimeKind.Local),
new DateTime(year: 1998, month: 10, day: 4, hour: 14, minute: 22, second: 35, millisecond: 892, kind: DateTimeKind.Local),
new DateTime(year: 1964, month: 10, day: 12, hour: 2, minute: 1, second: 21, millisecond: 749, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1939, month: 10, day: 16, hour: 10, minute: 42, second: 32, millisecond: 949, kind: DateTimeKind.Local),
new DateTime(year: 1969, month: 10, day: 14, hour: 1, minute: 45, second: 7, millisecond: 136, kind: DateTimeKind.Local),
new DateTime(year: 1973, month: 10, day: 11, hour: 15, minute: 50, second: 26, millisecond: 614, kind: DateTimeKind.Local),
new DateTime(year: 1969, month: 10, day: 6, hour: 12, minute: 53, second: 24, millisecond: 478, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 13,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1951, month: 10, day: 10, hour: 4, minute: 8, second: 16, millisecond: 662, kind: DateTimeKind.Local),
new DateTime(year: 1922, month: 10, day: 8, hour: 19, minute: 55, second: 36, millisecond: 423, kind: DateTimeKind.Local),
new DateTime(year: 1961, month: 10, day: 9, hour: 15, minute: 38, second: 54, millisecond: 217, kind: DateTimeKind.Local),
new DateTime(year: 1936, month: 10, day: 3, hour: 16, minute: 45, second: 8, millisecond: 50, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 21,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1987, month: 10, day: 1, hour: 14, minute: 50, second: 25, millisecond: 583, kind: DateTimeKind.Local),
new DateTime(year: 2000, month: 10, day: 2, hour: 2, minute: 53, second: 41, millisecond: 251, kind: DateTimeKind.Local),
new DateTime(year: 1978, month: 10, day: 15, hour: 18, minute: 15, second: 48, millisecond: 660, kind: DateTimeKind.Local),
new DateTime(year: 1943, month: 10, day: 19, hour: 5, minute: 32, second: 35, millisecond: 332, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 7,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1984, month: 10, day: 9, hour: 14, minute: 43, second: 16, millisecond: 642, kind: DateTimeKind.Local),
new DateTime(year: 1985, month: 10, day: 8, hour: 21, minute: 54, second: 34, millisecond: 626, kind: DateTimeKind.Local),
new DateTime(year: 1967, month: 10, day: 19, hour: 1, minute: 47, second: 17, millisecond: 948, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1942, month: 10, day: 4, hour: 15, minute: 18, second: 4, millisecond: 680, kind: DateTimeKind.Local),
new DateTime(year: 1940, month: 10, day: 4, hour: 17, minute: 1, second: 36, millisecond: 987, kind: DateTimeKind.Local),
new DateTime(year: 1935, month: 10, day: 8, hour: 3, minute: 14, second: 39, millisecond: 478, kind: DateTimeKind.Local),
new DateTime(year: 1961, month: 10, day: 4, hour: 7, minute: 12, second: 17, millisecond: 929, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 27,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1945, month: 10, day: 7, hour: 7, minute: 52, second: 21, millisecond: 946, kind: DateTimeKind.Local),
new DateTime(year: 1920, month: 10, day: 3, hour: 16, minute: 35, second: 17, millisecond: 779, kind: DateTimeKind.Local),
new DateTime(year: 1965, month: 10, day: 5, hour: 10, minute: 35, second: 3, millisecond: 36, kind: DateTimeKind.Local),
new DateTime(year: 1969, month: 10, day: 6, hour: 2, minute: 48, second: 19, millisecond: 864, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 28,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1922, month: 10, day: 1, hour: 10, minute: 45, second: 2, millisecond: 94, kind: DateTimeKind.Local),
new DateTime(year: 1923, month: 10, day: 8, hour: 8, minute: 25, second: 19, millisecond: 899, kind: DateTimeKind.Local),
new DateTime(year: 1951, month: 10, day: 1, hour: 5, minute: 8, second: 28, millisecond: 620, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 9,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1942, month: 10, day: 4, hour: 19, minute: 40, second: 21, millisecond: 907, kind: DateTimeKind.Local),
new DateTime(year: 1989, month: 10, day: 9, hour: 11, minute: 39, second: 47, millisecond: 988, kind: DateTimeKind.Local),
new DateTime(year: 1967, month: 10, day: 12, hour: 19, minute: 43, second: 10, millisecond: 933, kind: DateTimeKind.Local),
new DateTime(year: 1950, month: 10, day: 8, hour: 3, minute: 23, second: 39, millisecond: 271, kind: DateTimeKind.Local),
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1998, month: 10, day: 10, hour: 11, minute: 32, second: 7, millisecond: 945, kind: DateTimeKind.Local),
new DateTime(year: 1970, month: 10, day: 14, hour: 15, minute: 42, second: 44, millisecond: 359, kind: DateTimeKind.Local),
new DateTime(year: 2004, month: 10, day: 19, hour: 17, minute: 55, second: 10, millisecond: 760, kind: DateTimeKind.Local),
},
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1981, month: 10, day: 10, hour: 12, minute: 30, second: 2, millisecond: 602, kind: DateTimeKind.Local),
new DateTime(year: 2001, month: 10, day: 2, hour: 6, minute: 52, second: 36, millisecond: 747, kind: DateTimeKind.Local),
new DateTime(year: 1974, month: 10, day: 19, hour: 15, minute: 25, second: 45, millisecond: 276, kind: DateTimeKind.Local),
new DateTime(year: 1950, month: 10, day: 2, hour: 5, minute: 35, second: 12, millisecond: 302, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 31,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1923, month: 10, day: 12, hour: 13, minute: 50, second: 53, millisecond: 843, kind: DateTimeKind.Local),
new DateTime(year: 1957, month: 10, day: 6, hour: 10, minute: 8, second: 11, millisecond: 976, kind: DateTimeKind.Local),
new DateTime(year: 1954, month: 10, day: 1, hour: 10, minute: 13, second: 33, millisecond: 327, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1982, month: 10, day: 18, hour: 18, minute: 19, second: 9, millisecond: 125, kind: DateTimeKind.Local),
new DateTime(year: 1972, month: 10, day: 9, hour: 2, minute: 37, second: 43, millisecond: 788, kind: DateTimeKind.Local),
new DateTime(year: 2002, month: 10, day: 14, hour: 19, minute: 50, second: 20, millisecond: 681, kind: DateTimeKind.Local),
new DateTime(year: 2008, month: 10, day: 13, hour: 1, minute: 49, second: 47, millisecond: 384, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 40,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 2011, month: 10, day: 19, hour: 21, minute: 36, second: 19, millisecond: 80, kind: DateTimeKind.Local),
new DateTime(year: 1996, month: 10, day: 6, hour: 15, minute: 46, second: 34, millisecond: 474, kind: DateTimeKind.Local),
new DateTime(year: 1987, month: 10, day: 14, hour: 10, minute: 33, second: 30, millisecond: 31, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 18,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1922, month: 10, day: 1, hour: 18, minute: 30, second: 32, millisecond: 317, kind: DateTimeKind.Local),
new DateTime(year: 1968, month: 10, day: 5, hour: 4, minute: 35, second: 8, millisecond: 296, kind: DateTimeKind.Local),
new DateTime(year: 2010, month: 10, day: 16, hour: 2, minute: 37, second: 20, millisecond: 754, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 43,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1996, month: 10, day: 3, hour: 15, minute: 16, second: 40, millisecond: 509, kind: DateTimeKind.Local),
new DateTime(year: 1980, month: 10, day: 16, hour: 11, minute: 20, second: 7, millisecond: 908, kind: DateTimeKind.Local),
new DateTime(year: 1950, month: 10, day: 15, hour: 12, minute: 42, second: 6, millisecond: 969, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 45,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1932, month: 10, day: 9, hour: 19, minute: 16, second: 20, millisecond: 786, kind: DateTimeKind.Local),
new DateTime(year: 1991, month: 10, day: 11, hour: 1, minute: 5, second: 18, millisecond: 720, kind: DateTimeKind.Local),
new DateTime(year: 1978, month: 10, day: 3, hour: 19, minute: 20, second: 17, millisecond: 95, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 22,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1985, month: 10, day: 3, hour: 11, minute: 30, second: 58, millisecond: 45, kind: DateTimeKind.Local),
new DateTime(year: 1977, month: 10, day: 3, hour: 12, minute: 33, second: 20, millisecond: 909, kind: DateTimeKind.Local),
new DateTime(year: 1951, month: 10, day: 11, hour: 3, minute: 14, second: 31, millisecond: 478, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 2004, month: 10, day: 3, hour: 7, minute: 4, second: 49, millisecond: 452, kind: DateTimeKind.Local),
new DateTime(year: 1927, month: 10, day: 3, hour: 22, minute: 39, second: 21, millisecond: 728, kind: DateTimeKind.Local),
new DateTime(year: 1957, month: 10, day: 19, hour: 1, minute: 32, second: 29, millisecond: 825, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 48,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1938, month: 10, day: 17, hour: 16, minute: 4, second: 40, millisecond: 659, kind: DateTimeKind.Local),
new DateTime(year: 2000, month: 10, day: 5, hour: 8, minute: 37, second: 50, millisecond: 783, kind: DateTimeKind.Local),
new DateTime(year: 1967, month: 10, day: 11, hour: 8, minute: 46, second: 34, millisecond: 836, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1930, month: 10, day: 9, hour: 3, minute: 8, second: 40, millisecond: 206, kind: DateTimeKind.Local),
new DateTime(year: 2016, month: 10, day: 13, hour: 5, minute: 6, second: 49, millisecond: 930, kind: DateTimeKind.Local),
new DateTime(year: 1959, month: 10, day: 11, hour: 21, minute: 50, second: 56, millisecond: 8, kind: DateTimeKind.Local),
new DateTime(year: 1975, month: 10, day: 7, hour: 1, minute: 2, second: 45, millisecond: 484, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 53,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 2014, month: 10, day: 9, hour: 15, minute: 57, second: 55, millisecond: 777, kind: DateTimeKind.Local),
new DateTime(year: 1945, month: 10, day: 14, hour: 7, minute: 44, second: 38, millisecond: 31, kind: DateTimeKind.Local),
new DateTime(year: 1980, month: 10, day: 13, hour: 10, minute: 18, second: 39, millisecond: 514, kind: DateTimeKind.Local),
new DateTime(year: 1974, month: 10, day: 2, hour: 21, minute: 19, second: 13, millisecond: 872, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 24,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1943, month: 10, day: 11, hour: 17, minute: 54, second: 50, millisecond: 555, kind: DateTimeKind.Local),
new DateTime(year: 1917, month: 10, day: 19, hour: 2, minute: 29, second: 37, millisecond: 425, kind: DateTimeKind.Local),
new DateTime(year: 1953, month: 10, day: 17, hour: 20, minute: 39, second: 13, millisecond: 456, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1925, month: 10, day: 13, hour: 5, minute: 11, second: 10, millisecond: 891, kind: DateTimeKind.Local),
new DateTime(year: 1918, month: 10, day: 11, hour: 6, minute: 51, second: 58, millisecond: 495, kind: DateTimeKind.Local),
new DateTime(year: 1926, month: 10, day: 15, hour: 13, minute: 30, second: 44, millisecond: 464, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 56,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1961, month: 10, day: 2, hour: 22, minute: 24, second: 36, millisecond: 822, kind: DateTimeKind.Local),
new DateTime(year: 2014, month: 10, day: 14, hour: 6, minute: 57, second: 50, millisecond: 344, kind: DateTimeKind.Local),
new DateTime(year: 1930, month: 10, day: 9, hour: 15, minute: 42, second: 2, millisecond: 190, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 60,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 2005, month: 10, day: 16, hour: 21, minute: 12, second: 43, millisecond: 23, kind: DateTimeKind.Local),
new DateTime(year: 1960, month: 10, day: 18, hour: 19, minute: 5, second: 38, millisecond: 764, kind: DateTimeKind.Local),
new DateTime(year: 1921, month: 10, day: 18, hour: 13, minute: 32, second: 21, millisecond: 272, kind: DateTimeKind.Local),
new DateTime(year: 1963, month: 10, day: 11, hour: 7, minute: 37, second: 41, millisecond: 963, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 28,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1926, month: 10, day: 17, hour: 12, minute: 9, second: 17, millisecond: 725, kind: DateTimeKind.Local),
new DateTime(year: 1968, month: 10, day: 6, hour: 20, minute: 28, second: 46, millisecond: 357, kind: DateTimeKind.Local),
new DateTime(year: 1931, month: 10, day: 2, hour: 9, minute: 55, second: 58, millisecond: 73, kind: DateTimeKind.Local),
new DateTime(year: 1979, month: 10, day: 15, hour: 20, minute: 30, second: 56, millisecond: 194, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 68,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1973, month: 10, day: 11, hour: 14, minute: 37, second: 51, millisecond: 26, kind: DateTimeKind.Local),
new DateTime(year: 1946, month: 10, day: 2, hour: 9, minute: 34, second: 30, millisecond: 961, kind: DateTimeKind.Local),
new DateTime(year: 2010, month: 10, day: 3, hour: 18, minute: 3, second: 26, millisecond: 487, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 74,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1946, month: 10, day: 6, hour: 14, minute: 45, second: 25, millisecond: 362, kind: DateTimeKind.Local),
new DateTime(year: 1995, month: 10, day: 18, hour: 1, minute: 41, second: 37, millisecond: 507, kind: DateTimeKind.Local),
new DateTime(year: 2004, month: 10, day: 10, hour: 11, minute: 20, second: 16, millisecond: 136, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 32,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1965, month: 10, day: 8, hour: 22, minute: 43, second: 32, millisecond: 76, kind: DateTimeKind.Local),
new DateTime(year: 1975, month: 10, day: 4, hour: 10, minute: 4, second: 21, millisecond: 93, kind: DateTimeKind.Local),
new DateTime(year: 1980, month: 10, day: 5, hour: 9, minute: 56, second: 26, millisecond: 48, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 76,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 2006, month: 10, day: 3, hour: 19, minute: 46, second: 22, millisecond: 362, kind: DateTimeKind.Local),
new DateTime(year: 1965, month: 10, day: 7, hour: 13, minute: 51, second: 23, millisecond: 976, kind: DateTimeKind.Local),
new DateTime(year: 2019, month: 10, day: 2, hour: 11, minute: 3, second: 36, millisecond: 616, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1982, month: 10, day: 11, hour: 2, minute: 32, second: 55, millisecond: 585, kind: DateTimeKind.Local),
new DateTime(year: 1941, month: 10, day: 6, hour: 12, minute: 53, second: 8, millisecond: 895, kind: DateTimeKind.Local),
new DateTime(year: 1931, month: 10, day: 12, hour: 3, minute: 50, second: 4, millisecond: 884, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 85,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 2002, month: 10, day: 3, hour: 22, minute: 2, second: 42, millisecond: 817, kind: DateTimeKind.Local),
new DateTime(year: 2009, month: 10, day: 17, hour: 1, minute: 53, second: 8, millisecond: 696, kind: DateTimeKind.Local),
new DateTime(year: 1928, month: 10, day: 10, hour: 17, minute: 11, second: 48, millisecond: 633, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 39,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1946, month: 10, day: 7, hour: 5, minute: 44, second: 32, millisecond: 783, kind: DateTimeKind.Local),
new DateTime(year: 1937, month: 10, day: 18, hour: 2, minute: 57, second: 24, millisecond: 395, kind: DateTimeKind.Local),
new DateTime(year: 2014, month: 10, day: 19, hour: 1, minute: 18, second: 11, millisecond: 369, kind: DateTimeKind.Local),
new DateTime(year: 2000, month: 10, day: 7, hour: 16, minute: 19, second: 51, millisecond: 861, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 89,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1917, month: 10, day: 4, hour: 22, minute: 15, second: 51, millisecond: 4, kind: DateTimeKind.Local),
new DateTime(year: 1972, month: 10, day: 16, hour: 20, minute: 31, second: 6, millisecond: 612, kind: DateTimeKind.Local),
new DateTime(year: 2012, month: 10, day: 12, hour: 10, minute: 28, second: 51, millisecond: 31, kind: DateTimeKind.Local),
new DateTime(year: 1946, month: 10, day: 5, hour: 15, minute: 19, second: 27, millisecond: 565, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 98,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 2014, month: 10, day: 6, hour: 12, minute: 36, second: 19, millisecond: 973, kind: DateTimeKind.Local),
new DateTime(year: 2016, month: 10, day: 3, hour: 15, minute: 10, second: 26, millisecond: 597, kind: DateTimeKind.Local),
new DateTime(year: 2003, month: 10, day: 5, hour: 14, minute: 58, second: 22, millisecond: 952, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 45,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1981, month: 10, day: 12, hour: 20, minute: 8, second: 32, millisecond: 203, kind: DateTimeKind.Local),
new DateTime(year: 2001, month: 10, day: 6, hour: 20, minute: 25, second: 48, millisecond: 935, kind: DateTimeKind.Local),
new DateTime(year: 1994, month: 10, day: 7, hour: 4, minute: 37, second: 48, millisecond: 667, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 103,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1934, month: 10, day: 16, hour: 4, minute: 10, second: 6, millisecond: 616, kind: DateTimeKind.Local),
new DateTime(year: 1926, month: 10, day: 2, hour: 22, minute: 56, second: 53, millisecond: 232, kind: DateTimeKind.Local),
new DateTime(year: 1996, month: 10, day: 7, hour: 1, minute: 37, second: 7, millisecond: 547, kind: DateTimeKind.Local),
new DateTime(year: 1945, month: 10, day: 9, hour: 1, minute: 42, second: 45, millisecond: 994, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1998, month: 10, day: 14, hour: 16, minute: 8, second: 24, millisecond: 141, kind: DateTimeKind.Local),
new DateTime(year: 1918, month: 10, day: 8, hour: 20, minute: 17, second: 41, millisecond: 887, kind: DateTimeKind.Local),
new DateTime(year: 1942, month: 10, day: 11, hour: 9, minute: 29, second: 22, millisecond: 852, kind: DateTimeKind.Local),
new DateTime(year: 1926, month: 10, day: 16, hour: 1, minute: 33, second: 4, millisecond: 408, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 110,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1937, month: 10, day: 4, hour: 19, minute: 34, second: 44, millisecond: 548, kind: DateTimeKind.Local),
new DateTime(year: 1939, month: 10, day: 14, hour: 5, minute: 6, second: 40, millisecond: 578, kind: DateTimeKind.Local),
new DateTime(year: 1972, month: 10, day: 19, hour: 3, minute: 22, second: 25, millisecond: 374, kind: DateTimeKind.Local),
new DateTime(year: 1947, month: 10, day: 1, hour: 14, minute: 30, second: 14, millisecond: 231, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 46,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1940, month: 10, day: 14, hour: 11, minute: 13, second: 32, millisecond: 267, kind: DateTimeKind.Local),
new DateTime(year: 1981, month: 10, day: 15, hour: 14, minute: 20, second: 54, millisecond: 547, kind: DateTimeKind.Local),
new DateTime(year: 1976, month: 10, day: 9, hour: 8, minute: 52, second: 15, millisecond: 31, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1920, month: 10, day: 17, hour: 8, minute: 21, second: 32, millisecond: 462, kind: DateTimeKind.Local),
new DateTime(year: 1954, month: 10, day: 8, hour: 14, minute: 18, second: 43, millisecond: 401, kind: DateTimeKind.Local),
new DateTime(year: 1982, month: 10, day: 13, hour: 10, minute: 17, second: 14, millisecond: 964, kind: DateTimeKind.Local),
new DateTime(year: 1936, month: 10, day: 7, hour: 2, minute: 21, second: 48, millisecond: 632, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 111,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1938, month: 10, day: 15, hour: 2, minute: 7, second: 53, millisecond: 755, kind: DateTimeKind.Local),
new DateTime(year: 1938, month: 10, day: 3, hour: 22, minute: 14, second: 15, millisecond: 212, kind: DateTimeKind.Local),
new DateTime(year: 1922, month: 10, day: 12, hour: 14, minute: 24, second: 32, millisecond: 54, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 112,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 2004, month: 10, day: 1, hour: 6, minute: 13, second: 58, millisecond: 683, kind: DateTimeKind.Local),
new DateTime(year: 1927, month: 10, day: 16, hour: 2, minute: 37, second: 6, millisecond: 67, kind: DateTimeKind.Local),
new DateTime(year: 1986, month: 10, day: 16, hour: 3, minute: 11, second: 27, millisecond: 723, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 49,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1917, month: 10, day: 4, hour: 6, minute: 31, second: 58, millisecond: 279, kind: DateTimeKind.Local),
new DateTime(year: 2001, month: 10, day: 14, hour: 18, minute: 32, second: 48, millisecond: 608, kind: DateTimeKind.Local),
new DateTime(year: 1981, month: 10, day: 14, hour: 19, minute: 11, second: 54, millisecond: 971, kind: DateTimeKind.Local),
new DateTime(year: 1959, month: 10, day: 12, hour: 9, minute: 16, second: 1, millisecond: 568, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 2017, month: 10, day: 8, hour: 21, minute: 12, second: 44, millisecond: 258, kind: DateTimeKind.Local),
new DateTime(year: 2004, month: 10, day: 11, hour: 14, minute: 10, second: 51, millisecond: 442, kind: DateTimeKind.Local),
new DateTime(year: 1935, month: 10, day: 6, hour: 6, minute: 23, second: 46, millisecond: 966, kind: DateTimeKind.Local),
new DateTime(year: 1982, month: 10, day: 7, hour: 12, minute: 3, second: 1, millisecond: 485, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 121,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1983, month: 10, day: 2, hour: 12, minute: 30, second: 31, millisecond: 617, kind: DateTimeKind.Local),
new DateTime(year: 1920, month: 10, day: 2, hour: 4, minute: 14, second: 41, millisecond: 447, kind: DateTimeKind.Local),
new DateTime(year: 1963, month: 10, day: 11, hour: 17, minute: 57, second: 28, millisecond: 410, kind: DateTimeKind.Local),
new DateTime(year: 1975, month: 10, day: 11, hour: 1, minute: 54, second: 45, millisecond: 914, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 130,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1983, month: 10, day: 11, hour: 11, minute: 57, second: 28, millisecond: 901, kind: DateTimeKind.Local),
new DateTime(year: 1999, month: 10, day: 3, hour: 16, minute: 28, second: 31, millisecond: 252, kind: DateTimeKind.Local),
new DateTime(year: 2008, month: 10, day: 15, hour: 19, minute: 27, second: 15, millisecond: 421, kind: DateTimeKind.Local),
new DateTime(year: 2018, month: 10, day: 11, hour: 1, minute: 37, second: 25, millisecond: 638, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 53,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 2019, month: 10, day: 13, hour: 6, minute: 9, second: 44, millisecond: 799, kind: DateTimeKind.Local),
new DateTime(year: 1962, month: 10, day: 11, hour: 10, minute: 54, second: 36, millisecond: 581, kind: DateTimeKind.Local),
new DateTime(year: 1981, month: 10, day: 17, hour: 6, minute: 24, second: 25, millisecond: 807, kind: DateTimeKind.Local),
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1985, month: 10, day: 13, hour: 3, minute: 3, second: 40, millisecond: 591, kind: DateTimeKind.Local),
new DateTime(year: 1990, month: 10, day: 11, hour: 21, minute: 41, second: 20, millisecond: 893, kind: DateTimeKind.Local),
new DateTime(year: 2011, month: 10, day: 1, hour: 15, minute: 12, second: 36, millisecond: 684, kind: DateTimeKind.Local),
},
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 131,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1934, month: 10, day: 13, hour: 3, minute: 37, second: 23, millisecond: 142, kind: DateTimeKind.Local),
new DateTime(year: 1960, month: 10, day: 16, hour: 18, minute: 56, second: 46, millisecond: 741, kind: DateTimeKind.Local),
new DateTime(year: 1922, month: 10, day: 19, hour: 16, minute: 7, second: 20, millisecond: 281, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1925, month: 10, day: 18, hour: 22, minute: 49, second: 2, millisecond: 306, kind: DateTimeKind.Local),
new DateTime(year: 1992, month: 10, day: 4, hour: 10, minute: 57, second: 10, millisecond: 53, kind: DateTimeKind.Local),
new DateTime(year: 2015, month: 10, day: 8, hour: 11, minute: 25, second: 9, millisecond: 603, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 133,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1976, month: 10, day: 9, hour: 10, minute: 20, second: 57, millisecond: 901, kind: DateTimeKind.Local),
new DateTime(year: 1980, month: 10, day: 9, hour: 6, minute: 29, second: 35, millisecond: 513, kind: DateTimeKind.Local),
new DateTime(year: 2007, month: 10, day: 11, hour: 16, minute: 33, second: 23, millisecond: 826, kind: DateTimeKind.Local),
new DateTime(year: 1960, month: 10, day: 3, hour: 21, minute: 28, second: 22, millisecond: 12, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 54,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1964, month: 10, day: 3, hour: 10, minute: 51, second: 53, millisecond: 499, kind: DateTimeKind.Local),
new DateTime(year: 2015, month: 10, day: 13, hour: 1, minute: 56, second: 46, millisecond: 967, kind: DateTimeKind.Local),
new DateTime(year: 1960, month: 10, day: 16, hour: 10, minute: 46, second: 8, millisecond: 23, kind: DateTimeKind.Local),
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1982, month: 10, day: 9, hour: 5, minute: 9, second: 35, millisecond: 834, kind: DateTimeKind.Local),
new DateTime(year: 1962, month: 10, day: 18, hour: 12, minute: 12, second: 40, millisecond: 811, kind: DateTimeKind.Local),
new DateTime(year: 1932, month: 10, day: 3, hour: 11, minute: 26, second: 22, millisecond: 122, kind: DateTimeKind.Local),
new DateTime(year: 1931, month: 10, day: 6, hour: 1, minute: 34, second: 30, millisecond: 241, kind: DateTimeKind.Local),
},
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 142,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 2016, month: 10, day: 8, hour: 14, minute: 40, second: 29, millisecond: 897, kind: DateTimeKind.Local),
new DateTime(year: 2007, month: 10, day: 1, hour: 9, minute: 17, second: 52, millisecond: 286, kind: DateTimeKind.Local),
new DateTime(year: 1980, month: 10, day: 18, hour: 10, minute: 30, second: 56, millisecond: 701, kind: DateTimeKind.Local),
new DateTime(year: 2011, month: 10, day: 9, hour: 6, minute: 19, second: 52, millisecond: 530, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 146,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1966, month: 10, day: 17, hour: 16, minute: 1, second: 6, millisecond: 274, kind: DateTimeKind.Local),
new DateTime(year: 1995, month: 10, day: 2, hour: 20, minute: 46, second: 18, millisecond: 719, kind: DateTimeKind.Local),
new DateTime(year: 2016, month: 10, day: 11, hour: 21, minute: 13, second: 31, millisecond: 411, kind: DateTimeKind.Local),
new DateTime(year: 2019, month: 10, day: 11, hour: 20, minute: 24, second: 43, millisecond: 254, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 60,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1939, month: 10, day: 10, hour: 19, minute: 21, second: 33, millisecond: 627, kind: DateTimeKind.Local),
new DateTime(year: 1980, month: 10, day: 16, hour: 19, minute: 55, second: 44, millisecond: 439, kind: DateTimeKind.Local),
new DateTime(year: 1975, month: 10, day: 12, hour: 6, minute: 6, second: 22, millisecond: 549, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1940, month: 10, day: 10, hour: 8, minute: 54, second: 37, millisecond: 589, kind: DateTimeKind.Local),
new DateTime(year: 1925, month: 10, day: 5, hour: 18, minute: 53, second: 48, millisecond: 305, kind: DateTimeKind.Local),
new DateTime(year: 1981, month: 10, day: 5, hour: 12, minute: 7, second: 29, millisecond: 240, kind: DateTimeKind.Local),
new DateTime(year: 1923, month: 10, day: 16, hour: 13, minute: 51, second: 10, millisecond: 527, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 149,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1958, month: 10, day: 11, hour: 22, minute: 36, second: 1, millisecond: 155, kind: DateTimeKind.Local),
new DateTime(year: 2008, month: 10, day: 5, hour: 18, minute: 13, second: 3, millisecond: 766, kind: DateTimeKind.Local),
new DateTime(year: 1946, month: 10, day: 4, hour: 10, minute: 19, second: 35, millisecond: 311, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1920, month: 10, day: 9, hour: 17, minute: 43, second: 35, millisecond: 210, kind: DateTimeKind.Local),
new DateTime(year: 2010, month: 10, day: 16, hour: 10, minute: 35, second: 20, millisecond: 913, kind: DateTimeKind.Local),
new DateTime(year: 2006, month: 10, day: 18, hour: 4, minute: 17, second: 58, millisecond: 33, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 157,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1930, month: 10, day: 7, hour: 11, minute: 22, second: 11, millisecond: 629, kind: DateTimeKind.Local),
new DateTime(year: 1989, month: 10, day: 19, hour: 21, minute: 56, second: 14, millisecond: 325, kind: DateTimeKind.Local),
new DateTime(year: 1977, month: 10, day: 17, hour: 5, minute: 39, second: 5, millisecond: 605, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 69,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1935, month: 10, day: 13, hour: 9, minute: 10, second: 26, millisecond: 580, kind: DateTimeKind.Local),
new DateTime(year: 2006, month: 10, day: 16, hour: 13, minute: 19, second: 19, millisecond: 359, kind: DateTimeKind.Local),
new DateTime(year: 1958, month: 10, day: 11, hour: 10, minute: 11, second: 31, millisecond: 493, kind: DateTimeKind.Local),
new DateTime(year: 1944, month: 10, day: 3, hour: 1, minute: 16, second: 31, millisecond: 144, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1996, month: 10, day: 5, hour: 8, minute: 20, second: 24, millisecond: 358, kind: DateTimeKind.Local),
new DateTime(year: 2008, month: 10, day: 13, hour: 4, minute: 54, second: 45, millisecond: 590, kind: DateTimeKind.Local),
new DateTime(year: 1946, month: 10, day: 4, hour: 18, minute: 9, second: 16, millisecond: 250, kind: DateTimeKind.Local),
new DateTime(year: 2003, month: 10, day: 8, hour: 12, minute: 34, second: 3, millisecond: 568, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 161,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1957, month: 10, day: 5, hour: 5, minute: 24, second: 14, millisecond: 249, kind: DateTimeKind.Local),
new DateTime(year: 2019, month: 10, day: 11, hour: 16, minute: 55, second: 45, millisecond: 14, kind: DateTimeKind.Local),
new DateTime(year: 1923, month: 10, day: 5, hour: 16, minute: 4, second: 41, millisecond: 489, kind: DateTimeKind.Local),
new DateTime(year: 1923, month: 10, day: 12, hour: 21, minute: 13, second: 3, millisecond: 600, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1962, month: 10, day: 4, hour: 19, minute: 34, second: 4, millisecond: 88, kind: DateTimeKind.Local),
new DateTime(year: 1947, month: 10, day: 10, hour: 19, minute: 39, second: 35, millisecond: 865, kind: DateTimeKind.Local),
new DateTime(year: 1984, month: 10, day: 3, hour: 8, minute: 9, second: 5, millisecond: 823, kind: DateTimeKind.Local),
new DateTime(year: 1923, month: 10, day: 11, hour: 9, minute: 5, second: 54, millisecond: 685, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 169,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1991, month: 10, day: 9, hour: 3, minute: 47, second: 33, millisecond: 636, kind: DateTimeKind.Local),
new DateTime(year: 1967, month: 10, day: 13, hour: 9, minute: 14, second: 39, millisecond: 91, kind: DateTimeKind.Local),
new DateTime(year: 1949, month: 10, day: 14, hour: 19, minute: 31, second: 19, millisecond: 119, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 78,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 2009, month: 10, day: 2, hour: 14, minute: 42, second: 19, millisecond: 872, kind: DateTimeKind.Local),
new DateTime(year: 2011, month: 10, day: 13, hour: 16, minute: 54, second: 30, millisecond: 265, kind: DateTimeKind.Local),
new DateTime(year: 1977, month: 10, day: 10, hour: 20, minute: 28, second: 38, millisecond: 322, kind: DateTimeKind.Local),
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 17, hour: 21, minute: 16, second: 1, millisecond: 266, kind: DateTimeKind.Local),
new DateTime(year: 1938, month: 10, day: 2, hour: 9, minute: 48, second: 16, millisecond: 49, kind: DateTimeKind.Local),
new DateTime(year: 1943, month: 10, day: 10, hour: 4, minute: 41, second: 19, millisecond: 896, kind: DateTimeKind.Local),
},
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 176,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1953, month: 10, day: 15, hour: 13, minute: 12, second: 31, millisecond: 761, kind: DateTimeKind.Local),
new DateTime(year: 1960, month: 10, day: 5, hour: 1, minute: 54, second: 58, millisecond: 709, kind: DateTimeKind.Local),
new DateTime(year: 1966, month: 10, day: 15, hour: 3, minute: 29, second: 12, millisecond: 610, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1946, month: 10, day: 2, hour: 13, minute: 33, second: 48, millisecond: 178, kind: DateTimeKind.Local),
new DateTime(year: 1952, month: 10, day: 10, hour: 1, minute: 53, second: 5, millisecond: 400, kind: DateTimeKind.Local),
new DateTime(year: 1919, month: 10, day: 4, hour: 1, minute: 27, second: 15, millisecond: 689, kind: DateTimeKind.Local),
new DateTime(year: 2019, month: 10, day: 17, hour: 3, minute: 44, second: 18, millisecond: 904, kind: DateTimeKind.Local),
},
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

                id = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.DateTime[4]
{
new DateTime(year: 1981, month: 10, day: 10, hour: 12, minute: 30, second: 2, millisecond: 602, kind: DateTimeKind.Local),
new DateTime(year: 2001, month: 10, day: 2, hour: 6, minute: 52, second: 36, millisecond: 747, kind: DateTimeKind.Local),
new DateTime(year: 1974, month: 10, day: 19, hour: 15, minute: 25, second: 45, millisecond: 276, kind: DateTimeKind.Local),
new DateTime(year: 1950, month: 10, day: 2, hour: 5, minute: 35, second: 12, millisecond: 302, kind: DateTimeKind.Local),
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
new DateTime(year: 1982, month: 10, day: 18, hour: 18, minute: 19, second: 9, millisecond: 125, kind: DateTimeKind.Local),
new DateTime(year: 1972, month: 10, day: 9, hour: 2, minute: 37, second: 43, millisecond: 788, kind: DateTimeKind.Local),
new DateTime(year: 2002, month: 10, day: 14, hour: 19, minute: 50, second: 20, millisecond: 681, kind: DateTimeKind.Local),
new DateTime(year: 2008, month: 10, day: 13, hour: 1, minute: 49, second: 47, millisecond: 384, kind: DateTimeKind.Local),
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
                Assert.That(nullable, Is.Null);
                nullable =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.DateTime[3]
{
new DateTime(year: 2004, month: 10, day: 3, hour: 7, minute: 4, second: 49, millisecond: 452, kind: DateTimeKind.Local),
new DateTime(year: 1927, month: 10, day: 3, hour: 22, minute: 39, second: 21, millisecond: 728, kind: DateTimeKind.Local),
new DateTime(year: 1957, month: 10, day: 19, hour: 1, minute: 32, second: 29, millisecond: 825, kind: DateTimeKind.Local),
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
                nullable = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.DateTime[4]
{
new DateTime(year: 1930, month: 10, day: 9, hour: 3, minute: 8, second: 40, millisecond: 206, kind: DateTimeKind.Local),
new DateTime(year: 2016, month: 10, day: 13, hour: 5, minute: 6, second: 49, millisecond: 930, kind: DateTimeKind.Local),
new DateTime(year: 1959, month: 10, day: 11, hour: 21, minute: 50, second: 56, millisecond: 8, kind: DateTimeKind.Local),
new DateTime(year: 1975, month: 10, day: 7, hour: 1, minute: 2, second: 45, millisecond: 484, kind: DateTimeKind.Local),
}));
                nullable = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.DateTime[3]
{
new DateTime(year: 1925, month: 10, day: 13, hour: 5, minute: 11, second: 10, millisecond: 891, kind: DateTimeKind.Local),
new DateTime(year: 1918, month: 10, day: 11, hour: 6, minute: 51, second: 58, millisecond: 495, kind: DateTimeKind.Local),
new DateTime(year: 1926, month: 10, day: 15, hour: 13, minute: 30, second: 44, millisecond: 464, kind: DateTimeKind.Local),
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
                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneArray1M), typeof(FlatDateTimetimestamp_without_time_zoneArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray)),
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
FROM public.datetimetimestamp_without_time_zonearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                await ((IDateTimeArraytimestamp_without_time_zoneArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                ((IDateTimeArraytimestamp_without_time_zoneArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneArray1M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDateTimeArraytimestamp_without_time_zoneArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
            overrideAliasPrefixs: null,
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var models = ((IDateTimeArraytimestamp_without_time_zoneArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneArray1M), typeof(FlatDateTimetimestamp_without_time_zoneArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
FROM public.datetimetimestamp_without_time_zonearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                await ((IDateTimeArraytimestamp_without_time_zoneArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                ((IDateTimeArraytimestamp_without_time_zoneArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneArray1M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDateTimeArraytimestamp_without_time_zoneArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
            overrideAliasPrefixs: null,
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var models = ((IDateTimeArraytimestamp_without_time_zoneArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneArray1M), typeof(FlatDateTimetimestamp_without_time_zoneArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray)),
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
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray)),
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
FROM public.datetimetimestamp_without_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                await((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
FROM public.datetimetimestamp_without_time_zonearray1m m
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
FROM public.datetimetimestamp_without_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 149;
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
FROM public.datetimetimestamp_without_time_zonearray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[34], false);
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
FROM public.datetimetimestamp_without_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
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
FROM public.datetimetimestamp_without_time_zonearray1m m
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
FROM public.datetimetimestamp_without_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                 ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 76;
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
FROM public.datetimetimestamp_without_time_zonearray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                 ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneArray1M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
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
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
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
FROM public.datetimetimestamp_without_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_without_time_zonearray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[16],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[17],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[18],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[19],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[20],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[21],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[16],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[17],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[18],_testData[34], false);
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
                parametr2.Value = 60;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_without_time_zonearray1m m
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
FROM public.datetimetimestamp_without_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[20],_testData[34], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 149;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_without_time_zonearray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 161;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 149;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_without_time_zonearray1m m
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
FROM public.datetimetimestamp_without_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                 ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[3],_testData[34], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelDynParBatch",
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
                var models = await((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 161;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[27], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[28], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[29], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[30], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[31], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[32], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[33], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[33], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[34], false);
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
                var models = ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[18], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[19], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[20], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[21], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[22], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[23], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[24], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[25], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[26], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[27], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[28], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[29], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[30], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[31], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[32], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[33], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[30], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[31], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[32], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[33], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneArray1M), typeof(FlatDateTimetimestamp_without_time_zoneArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray)),
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
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray)),
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
FROM public.datetimetimestamp_without_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                await((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonearray1m m
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
FROM public.datetimetimestamp_without_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 56, query1, 111, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.datetimetimestamp_without_time_zonearray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 133, query1, 85, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[16],_testData[34], false);
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
FROM public.datetimetimestamp_without_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonearray1m m
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
FROM public.datetimetimestamp_without_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                 ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 149, query1, 43, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.datetimetimestamp_without_time_zonearray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                 ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 74, query1, 111, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[11],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneArray1M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
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
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
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
FROM public.datetimetimestamp_without_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonearray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 21, query1, 53, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[16],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[17],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[18],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[19],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[20],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[21],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[22],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[23],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[24],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[25],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[26],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[27],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[28],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[29],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[16],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[17],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[18],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[19],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[20],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[21],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[22],_testData[34], false);
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
FROM public.datetimetimestamp_without_time_zonearray1m m
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
FROM public.datetimetimestamp_without_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 43, query1, 149, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[3],_testData[34], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonearray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 149, query1, 111, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[34], false);
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
FROM public.datetimetimestamp_without_time_zonearray1m m
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
FROM public.datetimetimestamp_without_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneArray1M>();
                 ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatch(connection, 12, query1, 111, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[11],_testData[34], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelBatch",
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
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSTSelectModelBatchAsync(connection, 40, 112))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[8], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[9], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[10], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[11], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[12], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[13], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[14], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[15], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[16], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[17], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[18], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[19], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[20], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[21], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[22], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[23], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[16],_testData[24], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[17],_testData[25], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[18],_testData[26], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[19],_testData[27], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[20],_testData[28], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[21],_testData[29], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[22],_testData[30], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[23],_testData[31], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[24],_testData[32], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[25],_testData[33], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[24], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[25], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[26], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[27], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[28], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[29], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[30], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[31], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[32], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[33], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[34], false);
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
                var models = ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSTSelectModelBatch(connection, 142, 3))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[29], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[30], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[31], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[32], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[33], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[1], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[2], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[3], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[4], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[5], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[6], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[7], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[8], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[9], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[10], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[11], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[12], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[13], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[14], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[15], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[16], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[16],_testData[17], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[17],_testData[18], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[18],_testData[19], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[19],_testData[20], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[20],_testData[21], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[21],_testData[22], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[22],_testData[23], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[23],_testData[24], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[24],_testData[25], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[25],_testData[26], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[26],_testData[27], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[27],_testData[28], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[28],_testData[29], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[29],_testData[30], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[30],_testData[31], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[31],_testData[32], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[32],_testData[33], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[33],_testData[34], false);
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
                ((IDateTimeArraytimestamp_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 89);
                var models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(16));

                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[19], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[20], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[21], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[22], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[23], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[24], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[25], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[26], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[27], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[28], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[29], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[30], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[31], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[32], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[33], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateTimeArraytimestamp_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 48);
                var models =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[11], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[12], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[13], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[14], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[15], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[16], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[17], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[18], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[19], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[20], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[21], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[22], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[23], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[24], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[25], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[26], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[16],_testData[27], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[17],_testData[28], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[18],_testData[29], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[19],_testData[30], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[20],_testData[31], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[21],_testData[32], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[22],_testData[33], false);
                DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[23],_testData[34], false);
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
FROM public.binary_datetimetimestamp_without_time_zonearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(DateTimetimestamp_without_time_zoneArray1MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateTimetimestamp_without_time_zoneArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_without_time_zoneArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_datetimetimestamp_without_time_zonearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DateTimetimestamp_without_time_zoneArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_without_time_zoneArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDateTimeArraytimestamp_without_time_zoneArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_datetimetimestamp_without_time_zonearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDateTimeArraytimestamp_without_time_zoneArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_datetimetimestamp_without_time_zonearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(DateTimetimestamp_without_time_zoneArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateTimetimestamp_without_time_zoneArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_without_time_zoneArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_datetimetimestamp_without_time_zonearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DateTimetimestamp_without_time_zoneArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_without_time_zoneArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDateTimeArraytimestamp_without_time_zoneArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_datetimetimestamp_without_time_zonearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDateTimeArraytimestamp_without_time_zoneArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_datetimetimestamp_without_time_zonearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

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
            methodName:"WAImportModelInner",
            queryMapType: typeof(DateTimetimestamp_without_time_zoneArray1MI),
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateTimetimestamp_without_time_zoneArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDateTimeArraytimestamp_without_time_zoneArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<DateTimetimestamp_without_time_zoneArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDateTimeArraytimestamp_without_time_zoneArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IDateTimeArraytimestamp_without_time_zoneArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_datetimetimestamp_without_time_zonearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_datetimetimestamp_without_time_zonearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DateTimetimestamp_without_time_zoneArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateTimetimestamp_without_time_zoneArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_without_time_zoneArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDateTimeArraytimestamp_without_time_zoneArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DateTimetimestamp_without_time_zoneArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_without_time_zoneArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDateTimeArraytimestamp_without_time_zoneArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDateTimeArraytimestamp_without_time_zoneArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(DateTimetimestamp_without_time_zoneArray1M),
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateTimetimestamp_without_time_zoneArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDateTimeArraytimestamp_without_time_zoneArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DateTimetimestamp_without_time_zoneArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<DateTimetimestamp_without_time_zoneArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDateTimeArraytimestamp_without_time_zoneArray)this).ImportModel(connection, importCollection);
                var models = ((IDateTimeArraytimestamp_without_time_zoneArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DateTimetimestamp_without_time_zoneArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483627),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483627)
            })]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray1MIWA), typeof(DateTimetimestamp_without_time_zoneArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483627),
                (NpgsqlTypes.NpgsqlDbType)(-2147483627)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483627),
                (NpgsqlTypes.NpgsqlDbType)(-2147483627)
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
                var models1 = new List<DateTimetimestamp_without_time_zoneArray1MIWA>();
                var models2 = new List<DateTimetimestamp_without_time_zoneArray1MIWA>();
                await ((IDateTimeArraytimestamp_without_time_zoneArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_datetimetimestamp_without_time_zonearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DateTimetimestamp_without_time_zoneArray1MIWA>();
                var models2 = new List<DateTimetimestamp_without_time_zoneArray1MIWA>();
                ((IDateTimeArraytimestamp_without_time_zoneArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_datetimetimestamp_without_time_zonearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483627),
                (NpgsqlTypes.NpgsqlDbType)(-2147483627)
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
                var models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_datetimetimestamp_without_time_zonearray1mi
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
                    DateTimetimestamp_without_time_zoneArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDateTimeArraytimestamp_without_time_zoneArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_datetimetimestamp_without_time_zonearray1mi
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
                    DateTimetimestamp_without_time_zoneArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray1MIWA), typeof(DateTimetimestamp_without_time_zoneArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray))]
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
                var models1 = new List<DateTimetimestamp_without_time_zoneArray1MIWA>();
                var models2 = new List<DateTimetimestamp_without_time_zoneArray1MIWA>();
                await ((IDateTimeArraytimestamp_without_time_zoneArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_datetimetimestamp_without_time_zonearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DateTimetimestamp_without_time_zoneArray1MIWA>();
                var models2 = new List<DateTimetimestamp_without_time_zoneArray1MIWA>();
                ((IDateTimeArraytimestamp_without_time_zoneArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_datetimetimestamp_without_time_zonearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray))]
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
                var models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_datetimetimestamp_without_time_zonearray1mi
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
                    DateTimetimestamp_without_time_zoneArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDateTimeArraytimestamp_without_time_zoneArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_datetimetimestamp_without_time_zonearray1mi
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
                    DateTimetimestamp_without_time_zoneArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_datetimetimestamp_without_time_zonearray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray1MI), typeof(DateTimetimestamp_without_time_zoneArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483627),
                (NpgsqlTypes.NpgsqlDbType)(-2147483627)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483627),
                (NpgsqlTypes.NpgsqlDbType)(-2147483627)
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
                var models1 = new List<DateTimetimestamp_without_time_zoneArray1MI>();
                var models2 = new List<DateTimetimestamp_without_time_zoneArray1MI>();
                await ((IDateTimeArraytimestamp_without_time_zoneArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DateTimetimestamp_without_time_zoneArray1MI>();
                var models2 = new List<DateTimetimestamp_without_time_zoneArray1MI>();
                ((IDateTimeArraytimestamp_without_time_zoneArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_datetimetimestamp_without_time_zonearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483627),
                (NpgsqlTypes.NpgsqlDbType)(-2147483627)
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
                var models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDateTimeArraytimestamp_without_time_zoneArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_datetimetimestamp_without_time_zonearray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray1MIWA), typeof(DateTimetimestamp_without_time_zoneArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray))]
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
                var models1 = new List<DateTimetimestamp_without_time_zoneArray1MIWA>();
                var models2 = new List<DateTimetimestamp_without_time_zoneArray1MIWA>();
                await ((IDateTimeArraytimestamp_without_time_zoneArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DateTimetimestamp_without_time_zoneArray1MIWA>();
                var models2 = new List<DateTimetimestamp_without_time_zoneArray1MIWA>();
                ((IDateTimeArraytimestamp_without_time_zoneArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_datetimetimestamp_without_time_zonearray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray))]
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
                var models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDateTimeArraytimestamp_without_time_zoneArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

