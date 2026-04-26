

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
    Id = 9,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1930, month: 10, day: 17, hour: 10, minute: 13, second: 30, millisecond: 930, kind: DateTimeKind.Local),
new DateTime(year: 2002, month: 10, day: 4, hour: 2, minute: 34, second: 2, millisecond: 147, kind: DateTimeKind.Local),
new DateTime(year: 1973, month: 10, day: 7, hour: 1, minute: 3, second: 39, millisecond: 900, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 16, hour: 19, minute: 49, second: 42, millisecond: 716, kind: DateTimeKind.Local),
new DateTime(year: 1918, month: 10, day: 1, hour: 19, minute: 9, second: 37, millisecond: 448, kind: DateTimeKind.Local),
new DateTime(year: 1959, month: 10, day: 9, hour: 11, minute: 11, second: 17, millisecond: 848, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 16,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1975, month: 10, day: 12, hour: 10, minute: 48, second: 50, millisecond: 580, kind: DateTimeKind.Local),
new DateTime(year: 2008, month: 10, day: 18, hour: 6, minute: 4, second: 38, millisecond: 772, kind: DateTimeKind.Local),
new DateTime(year: 1965, month: 10, day: 1, hour: 21, minute: 44, second: 49, millisecond: 970, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 4,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1947, month: 10, day: 6, hour: 20, minute: 32, second: 28, millisecond: 684, kind: DateTimeKind.Local),
new DateTime(year: 1954, month: 10, day: 4, hour: 17, minute: 36, second: 13, millisecond: 546, kind: DateTimeKind.Local),
new DateTime(year: 1966, month: 10, day: 4, hour: 18, minute: 41, second: 58, millisecond: 377, kind: DateTimeKind.Local),
new DateTime(year: 1990, month: 10, day: 18, hour: 8, minute: 24, second: 48, millisecond: 806, kind: DateTimeKind.Local),
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1930, month: 10, day: 17, hour: 13, minute: 42, second: 15, millisecond: 193, kind: DateTimeKind.Local),
new DateTime(year: 2002, month: 10, day: 15, hour: 11, minute: 44, second: 40, millisecond: 654, kind: DateTimeKind.Local),
new DateTime(year: 1928, month: 10, day: 10, hour: 7, minute: 24, second: 39, millisecond: 986, kind: DateTimeKind.Local),
},
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 2014, month: 10, day: 13, hour: 17, minute: 26, second: 41, millisecond: 712, kind: DateTimeKind.Local),
new DateTime(year: 1936, month: 10, day: 13, hour: 9, minute: 51, second: 10, millisecond: 332, kind: DateTimeKind.Local),
new DateTime(year: 1966, month: 10, day: 15, hour: 7, minute: 23, second: 46, millisecond: 772, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 18,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 2008, month: 10, day: 3, hour: 19, minute: 33, second: 18, millisecond: 552, kind: DateTimeKind.Local),
new DateTime(year: 1930, month: 10, day: 16, hour: 9, minute: 26, second: 24, millisecond: 6, kind: DateTimeKind.Local),
new DateTime(year: 1917, month: 10, day: 12, hour: 7, minute: 12, second: 1, millisecond: 907, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 25,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1976, month: 10, day: 11, hour: 20, minute: 14, second: 5, millisecond: 888, kind: DateTimeKind.Local),
new DateTime(year: 1921, month: 10, day: 12, hour: 10, minute: 29, second: 28, millisecond: 468, kind: DateTimeKind.Local),
new DateTime(year: 1995, month: 10, day: 13, hour: 8, minute: 19, second: 37, millisecond: 731, kind: DateTimeKind.Local),
new DateTime(year: 1977, month: 10, day: 5, hour: 16, minute: 25, second: 18, millisecond: 353, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 5,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1970, month: 10, day: 15, hour: 3, minute: 27, second: 18, millisecond: 600, kind: DateTimeKind.Local),
new DateTime(year: 1949, month: 10, day: 8, hour: 1, minute: 56, second: 38, millisecond: 493, kind: DateTimeKind.Local),
new DateTime(year: 1951, month: 10, day: 3, hour: 3, minute: 27, second: 4, millisecond: 552, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 34,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1993, month: 10, day: 13, hour: 2, minute: 30, second: 43, millisecond: 433, kind: DateTimeKind.Local),
new DateTime(year: 1964, month: 10, day: 1, hour: 17, minute: 28, second: 33, millisecond: 147, kind: DateTimeKind.Local),
new DateTime(year: 1965, month: 10, day: 3, hour: 6, minute: 8, second: 6, millisecond: 263, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 2012, month: 10, day: 10, hour: 4, minute: 55, second: 11, millisecond: 485, kind: DateTimeKind.Local),
new DateTime(year: 1970, month: 10, day: 9, hour: 8, minute: 35, second: 33, millisecond: 342, kind: DateTimeKind.Local),
new DateTime(year: 1946, month: 10, day: 15, hour: 2, minute: 49, second: 10, millisecond: 95, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 38,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1948, month: 10, day: 12, hour: 19, minute: 9, second: 53, millisecond: 229, kind: DateTimeKind.Local),
new DateTime(year: 1934, month: 10, day: 13, hour: 22, minute: 14, second: 13, millisecond: 924, kind: DateTimeKind.Local),
new DateTime(year: 1973, month: 10, day: 4, hour: 17, minute: 36, second: 32, millisecond: 566, kind: DateTimeKind.Local),
new DateTime(year: 1949, month: 10, day: 14, hour: 2, minute: 3, second: 11, millisecond: 664, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 14,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1956, month: 10, day: 1, hour: 8, minute: 52, second: 52, millisecond: 534, kind: DateTimeKind.Local),
new DateTime(year: 1997, month: 10, day: 17, hour: 10, minute: 18, second: 30, millisecond: 784, kind: DateTimeKind.Local),
new DateTime(year: 1986, month: 10, day: 14, hour: 13, minute: 18, second: 12, millisecond: 48, kind: DateTimeKind.Local),
new DateTime(year: 1967, month: 10, day: 18, hour: 5, minute: 20, second: 13, millisecond: 219, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1934, month: 10, day: 16, hour: 11, minute: 18, second: 57, millisecond: 517, kind: DateTimeKind.Local),
new DateTime(year: 1949, month: 10, day: 14, hour: 9, minute: 23, second: 23, millisecond: 792, kind: DateTimeKind.Local),
new DateTime(year: 1974, month: 10, day: 16, hour: 17, minute: 10, second: 54, millisecond: 268, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 42,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1986, month: 10, day: 2, hour: 17, minute: 52, second: 7, millisecond: 917, kind: DateTimeKind.Local),
new DateTime(year: 1972, month: 10, day: 14, hour: 19, minute: 41, second: 17, millisecond: 279, kind: DateTimeKind.Local),
new DateTime(year: 1992, month: 10, day: 5, hour: 6, minute: 11, second: 34, millisecond: 3, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 49,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1978, month: 10, day: 9, hour: 10, minute: 54, second: 43, millisecond: 479, kind: DateTimeKind.Local),
new DateTime(year: 1954, month: 10, day: 8, hour: 18, minute: 4, second: 3, millisecond: 661, kind: DateTimeKind.Local),
new DateTime(year: 2012, month: 10, day: 7, hour: 8, minute: 46, second: 12, millisecond: 601, kind: DateTimeKind.Local),
new DateTime(year: 2002, month: 10, day: 16, hour: 18, minute: 38, second: 57, millisecond: 384, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 16,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 2010, month: 10, day: 8, hour: 4, minute: 23, second: 35, millisecond: 785, kind: DateTimeKind.Local),
new DateTime(year: 1929, month: 10, day: 15, hour: 14, minute: 40, second: 10, millisecond: 331, kind: DateTimeKind.Local),
new DateTime(year: 2006, month: 10, day: 2, hour: 17, minute: 52, second: 55, millisecond: 503, kind: DateTimeKind.Local),
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1977, month: 10, day: 13, hour: 3, minute: 25, second: 15, millisecond: 142, kind: DateTimeKind.Local),
new DateTime(year: 1998, month: 10, day: 11, hour: 7, minute: 20, second: 54, millisecond: 520, kind: DateTimeKind.Local),
new DateTime(year: 1977, month: 10, day: 1, hour: 20, minute: 48, second: 11, millisecond: 150, kind: DateTimeKind.Local),
},
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 53,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1930, month: 10, day: 6, hour: 2, minute: 4, second: 44, millisecond: 179, kind: DateTimeKind.Local),
new DateTime(year: 1981, month: 10, day: 1, hour: 5, minute: 36, second: 31, millisecond: 398, kind: DateTimeKind.Local),
new DateTime(year: 1922, month: 10, day: 10, hour: 6, minute: 18, second: 20, millisecond: 873, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1931, month: 10, day: 3, hour: 9, minute: 14, second: 9, millisecond: 606, kind: DateTimeKind.Local),
new DateTime(year: 2001, month: 10, day: 13, hour: 19, minute: 25, second: 38, millisecond: 452, kind: DateTimeKind.Local),
new DateTime(year: 1934, month: 10, day: 4, hour: 7, minute: 20, second: 9, millisecond: 589, kind: DateTimeKind.Local),
new DateTime(year: 1995, month: 10, day: 2, hour: 9, minute: 50, second: 15, millisecond: 516, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 58,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 2003, month: 10, day: 17, hour: 22, minute: 52, second: 34, millisecond: 685, kind: DateTimeKind.Local),
new DateTime(year: 1927, month: 10, day: 7, hour: 18, minute: 22, second: 36, millisecond: 319, kind: DateTimeKind.Local),
new DateTime(year: 1934, month: 10, day: 6, hour: 19, minute: 39, second: 52, millisecond: 571, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 22,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 2001, month: 10, day: 8, hour: 19, minute: 58, second: 39, millisecond: 877, kind: DateTimeKind.Local),
new DateTime(year: 1949, month: 10, day: 2, hour: 7, minute: 51, second: 29, millisecond: 767, kind: DateTimeKind.Local),
new DateTime(year: 1947, month: 10, day: 6, hour: 11, minute: 57, second: 14, millisecond: 18, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1921, month: 10, day: 1, hour: 19, minute: 39, second: 8, millisecond: 589, kind: DateTimeKind.Local),
new DateTime(year: 1999, month: 10, day: 11, hour: 10, minute: 54, second: 34, millisecond: 288, kind: DateTimeKind.Local),
new DateTime(year: 2007, month: 10, day: 12, hour: 12, minute: 33, second: 36, millisecond: 505, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 67,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1927, month: 10, day: 2, hour: 2, minute: 11, second: 46, millisecond: 992, kind: DateTimeKind.Local),
new DateTime(year: 1967, month: 10, day: 14, hour: 2, minute: 13, second: 55, millisecond: 69, kind: DateTimeKind.Local),
new DateTime(year: 1919, month: 10, day: 17, hour: 14, minute: 22, second: 35, millisecond: 926, kind: DateTimeKind.Local),
new DateTime(year: 1973, month: 10, day: 19, hour: 4, minute: 6, second: 35, millisecond: 748, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 2005, month: 10, day: 11, hour: 5, minute: 46, second: 12, millisecond: 827, kind: DateTimeKind.Local),
new DateTime(year: 1993, month: 10, day: 8, hour: 20, minute: 43, second: 53, millisecond: 114, kind: DateTimeKind.Local),
new DateTime(year: 2012, month: 10, day: 15, hour: 21, minute: 14, second: 17, millisecond: 910, kind: DateTimeKind.Local),
new DateTime(year: 1996, month: 10, day: 18, hour: 16, minute: 3, second: 34, millisecond: 715, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 75,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 2018, month: 10, day: 2, hour: 1, minute: 10, second: 34, millisecond: 410, kind: DateTimeKind.Local),
new DateTime(year: 1979, month: 10, day: 11, hour: 7, minute: 36, second: 20, millisecond: 190, kind: DateTimeKind.Local),
new DateTime(year: 2007, month: 10, day: 4, hour: 5, minute: 27, second: 39, millisecond: 694, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 25,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1925, month: 10, day: 8, hour: 19, minute: 13, second: 18, millisecond: 78, kind: DateTimeKind.Local),
new DateTime(year: 1986, month: 10, day: 16, hour: 13, minute: 25, second: 49, millisecond: 540, kind: DateTimeKind.Local),
new DateTime(year: 1923, month: 10, day: 18, hour: 4, minute: 24, second: 25, millisecond: 590, kind: DateTimeKind.Local),
new DateTime(year: 1967, month: 10, day: 12, hour: 21, minute: 11, second: 52, millisecond: 159, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1967, month: 10, day: 17, hour: 1, minute: 51, second: 31, millisecond: 249, kind: DateTimeKind.Local),
new DateTime(year: 1946, month: 10, day: 12, hour: 5, minute: 15, second: 14, millisecond: 105, kind: DateTimeKind.Local),
new DateTime(year: 1924, month: 10, day: 17, hour: 19, minute: 17, second: 8, millisecond: 128, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 77,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1974, month: 10, day: 1, hour: 12, minute: 19, second: 41, millisecond: 579, kind: DateTimeKind.Local),
new DateTime(year: 1940, month: 10, day: 13, hour: 20, minute: 30, second: 17, millisecond: 452, kind: DateTimeKind.Local),
new DateTime(year: 1973, month: 10, day: 14, hour: 13, minute: 54, second: 37, millisecond: 267, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 84,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1995, month: 10, day: 1, hour: 21, minute: 2, second: 45, millisecond: 918, kind: DateTimeKind.Local),
new DateTime(year: 1966, month: 10, day: 16, hour: 11, minute: 11, second: 57, millisecond: 204, kind: DateTimeKind.Local),
new DateTime(year: 2000, month: 10, day: 14, hour: 12, minute: 32, second: 30, millisecond: 963, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 31,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 2019, month: 10, day: 19, hour: 14, minute: 31, second: 37, millisecond: 953, kind: DateTimeKind.Local),
new DateTime(year: 1956, month: 10, day: 2, hour: 3, minute: 2, second: 12, millisecond: 523, kind: DateTimeKind.Local),
new DateTime(year: 1983, month: 10, day: 14, hour: 15, minute: 3, second: 9, millisecond: 987, kind: DateTimeKind.Local),
new DateTime(year: 2002, month: 10, day: 4, hour: 22, minute: 14, second: 49, millisecond: 275, kind: DateTimeKind.Local),
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1946, month: 10, day: 19, hour: 15, minute: 54, second: 21, millisecond: 873, kind: DateTimeKind.Local),
new DateTime(year: 1923, month: 10, day: 2, hour: 21, minute: 57, second: 56, millisecond: 174, kind: DateTimeKind.Local),
new DateTime(year: 2010, month: 10, day: 6, hour: 21, minute: 28, second: 12, millisecond: 754, kind: DateTimeKind.Local),
new DateTime(year: 1935, month: 10, day: 8, hour: 4, minute: 54, second: 29, millisecond: 938, kind: DateTimeKind.Local),
},
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1990, month: 10, day: 7, hour: 6, minute: 35, second: 30, millisecond: 456, kind: DateTimeKind.Local),
new DateTime(year: 2019, month: 10, day: 16, hour: 18, minute: 11, second: 8, millisecond: 44, kind: DateTimeKind.Local),
new DateTime(year: 1988, month: 10, day: 14, hour: 21, minute: 20, second: 29, millisecond: 977, kind: DateTimeKind.Local),
new DateTime(year: 1998, month: 10, day: 15, hour: 9, minute: 27, second: 50, millisecond: 932, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 91,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1987, month: 10, day: 2, hour: 11, minute: 25, second: 48, millisecond: 687, kind: DateTimeKind.Local),
new DateTime(year: 1990, month: 10, day: 13, hour: 9, minute: 22, second: 56, millisecond: 727, kind: DateTimeKind.Local),
new DateTime(year: 1996, month: 10, day: 2, hour: 3, minute: 29, second: 19, millisecond: 974, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 2012, month: 10, day: 14, hour: 15, minute: 11, second: 22, millisecond: 945, kind: DateTimeKind.Local),
new DateTime(year: 1939, month: 10, day: 2, hour: 2, minute: 38, second: 22, millisecond: 648, kind: DateTimeKind.Local),
new DateTime(year: 1948, month: 10, day: 12, hour: 11, minute: 11, second: 35, millisecond: 430, kind: DateTimeKind.Local),
new DateTime(year: 1978, month: 10, day: 4, hour: 4, minute: 47, second: 20, millisecond: 119, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 94,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1938, month: 10, day: 5, hour: 17, minute: 25, second: 25, millisecond: 185, kind: DateTimeKind.Local),
new DateTime(year: 1954, month: 10, day: 9, hour: 8, minute: 47, second: 21, millisecond: 289, kind: DateTimeKind.Local),
new DateTime(year: 1958, month: 10, day: 5, hour: 5, minute: 52, second: 53, millisecond: 831, kind: DateTimeKind.Local),
new DateTime(year: 1981, month: 10, day: 16, hour: 12, minute: 3, second: 10, millisecond: 623, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 32,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1985, month: 10, day: 3, hour: 12, minute: 40, second: 39, millisecond: 610, kind: DateTimeKind.Local),
new DateTime(year: 1954, month: 10, day: 6, hour: 18, minute: 34, second: 7, millisecond: 941, kind: DateTimeKind.Local),
new DateTime(year: 1942, month: 10, day: 15, hour: 10, minute: 7, second: 25, millisecond: 182, kind: DateTimeKind.Local),
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1922, month: 10, day: 6, hour: 14, minute: 8, second: 48, millisecond: 543, kind: DateTimeKind.Local),
new DateTime(year: 1947, month: 10, day: 9, hour: 9, minute: 31, second: 3, millisecond: 555, kind: DateTimeKind.Local),
new DateTime(year: 2005, month: 10, day: 13, hour: 20, minute: 42, second: 33, millisecond: 384, kind: DateTimeKind.Local),
new DateTime(year: 1937, month: 10, day: 9, hour: 18, minute: 51, second: 57, millisecond: 443, kind: DateTimeKind.Local),
},
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 101,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1937, month: 10, day: 16, hour: 9, minute: 58, second: 8, millisecond: 323, kind: DateTimeKind.Local),
new DateTime(year: 2017, month: 10, day: 17, hour: 21, minute: 24, second: 13, millisecond: 368, kind: DateTimeKind.Local),
new DateTime(year: 2007, month: 10, day: 10, hour: 5, minute: 57, second: 47, millisecond: 261, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 103,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1994, month: 10, day: 19, hour: 3, minute: 17, second: 44, millisecond: 111, kind: DateTimeKind.Local),
new DateTime(year: 1965, month: 10, day: 17, hour: 9, minute: 46, second: 4, millisecond: 326, kind: DateTimeKind.Local),
new DateTime(year: 1933, month: 10, day: 14, hour: 1, minute: 38, second: 39, millisecond: 847, kind: DateTimeKind.Local),
new DateTime(year: 1985, month: 10, day: 8, hour: 8, minute: 58, second: 42, millisecond: 278, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 39,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1984, month: 10, day: 7, hour: 1, minute: 36, second: 42, millisecond: 839, kind: DateTimeKind.Local),
new DateTime(year: 1958, month: 10, day: 3, hour: 6, minute: 55, second: 37, millisecond: 368, kind: DateTimeKind.Local),
new DateTime(year: 1923, month: 10, day: 16, hour: 17, minute: 1, second: 34, millisecond: 255, kind: DateTimeKind.Local),
new DateTime(year: 1958, month: 10, day: 13, hour: 5, minute: 23, second: 27, millisecond: 433, kind: DateTimeKind.Local),
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1973, month: 10, day: 8, hour: 7, minute: 55, second: 24, millisecond: 776, kind: DateTimeKind.Local),
new DateTime(year: 1922, month: 10, day: 6, hour: 13, minute: 36, second: 5, millisecond: 936, kind: DateTimeKind.Local),
new DateTime(year: 1947, month: 10, day: 14, hour: 9, minute: 34, second: 47, millisecond: 580, kind: DateTimeKind.Local),
new DateTime(year: 1960, month: 10, day: 1, hour: 12, minute: 45, second: 4, millisecond: 103, kind: DateTimeKind.Local),
},
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 106,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1932, month: 10, day: 10, hour: 11, minute: 4, second: 30, millisecond: 871, kind: DateTimeKind.Local),
new DateTime(year: 1982, month: 10, day: 10, hour: 21, minute: 51, second: 19, millisecond: 812, kind: DateTimeKind.Local),
new DateTime(year: 1952, month: 10, day: 3, hour: 11, minute: 1, second: 34, millisecond: 654, kind: DateTimeKind.Local),
new DateTime(year: 2010, month: 10, day: 15, hour: 18, minute: 43, second: 26, millisecond: 549, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1925, month: 10, day: 4, hour: 16, minute: 1, second: 24, millisecond: 718, kind: DateTimeKind.Local),
new DateTime(year: 1936, month: 10, day: 17, hour: 16, minute: 56, second: 32, millisecond: 116, kind: DateTimeKind.Local),
new DateTime(year: 1924, month: 10, day: 18, hour: 15, minute: 31, second: 53, millisecond: 286, kind: DateTimeKind.Local),
new DateTime(year: 1938, month: 10, day: 17, hour: 21, minute: 28, second: 42, millisecond: 586, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 108,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1928, month: 10, day: 9, hour: 20, minute: 58, second: 42, millisecond: 15, kind: DateTimeKind.Local),
new DateTime(year: 1918, month: 10, day: 9, hour: 15, minute: 39, second: 41, millisecond: 481, kind: DateTimeKind.Local),
new DateTime(year: 1944, month: 10, day: 11, hour: 10, minute: 30, second: 4, millisecond: 708, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 47,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1985, month: 10, day: 5, hour: 1, minute: 21, second: 44, millisecond: 534, kind: DateTimeKind.Local),
new DateTime(year: 1978, month: 10, day: 6, hour: 11, minute: 41, second: 42, millisecond: 150, kind: DateTimeKind.Local),
new DateTime(year: 1922, month: 10, day: 15, hour: 13, minute: 51, second: 55, millisecond: 875, kind: DateTimeKind.Local),
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1964, month: 10, day: 7, hour: 3, minute: 37, second: 19, millisecond: 552, kind: DateTimeKind.Local),
new DateTime(year: 1988, month: 10, day: 12, hour: 18, minute: 38, second: 37, millisecond: 276, kind: DateTimeKind.Local),
new DateTime(year: 2004, month: 10, day: 16, hour: 1, minute: 10, second: 8, millisecond: 70, kind: DateTimeKind.Local),
new DateTime(year: 1962, month: 10, day: 7, hour: 2, minute: 43, second: 34, millisecond: 596, kind: DateTimeKind.Local),
},
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 110,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1928, month: 10, day: 10, hour: 21, minute: 9, second: 15, millisecond: 584, kind: DateTimeKind.Local),
new DateTime(year: 1966, month: 10, day: 18, hour: 13, minute: 52, second: 41, millisecond: 995, kind: DateTimeKind.Local),
new DateTime(year: 1964, month: 10, day: 8, hour: 9, minute: 54, second: 55, millisecond: 863, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 10, hour: 17, minute: 36, second: 48, millisecond: 595, kind: DateTimeKind.Local),
new DateTime(year: 1984, month: 10, day: 15, hour: 15, minute: 22, second: 52, millisecond: 104, kind: DateTimeKind.Local),
new DateTime(year: 1979, month: 10, day: 14, hour: 2, minute: 41, second: 12, millisecond: 942, kind: DateTimeKind.Local),
new DateTime(year: 1989, month: 10, day: 3, hour: 14, minute: 28, second: 13, millisecond: 785, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 117,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1983, month: 10, day: 4, hour: 1, minute: 20, second: 47, millisecond: 723, kind: DateTimeKind.Local),
new DateTime(year: 1924, month: 10, day: 1, hour: 5, minute: 24, second: 21, millisecond: 202, kind: DateTimeKind.Local),
new DateTime(year: 1967, month: 10, day: 19, hour: 1, minute: 29, second: 11, millisecond: 71, kind: DateTimeKind.Local),
new DateTime(year: 2016, month: 10, day: 17, hour: 1, minute: 11, second: 44, millisecond: 616, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 52,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1961, month: 10, day: 8, hour: 14, minute: 38, second: 58, millisecond: 401, kind: DateTimeKind.Local),
new DateTime(year: 1998, month: 10, day: 12, hour: 12, minute: 36, second: 11, millisecond: 600, kind: DateTimeKind.Local),
new DateTime(year: 2006, month: 10, day: 4, hour: 4, minute: 10, second: 20, millisecond: 979, kind: DateTimeKind.Local),
new DateTime(year: 1917, month: 10, day: 5, hour: 14, minute: 8, second: 41, millisecond: 878, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1999, month: 10, day: 14, hour: 18, minute: 31, second: 49, millisecond: 173, kind: DateTimeKind.Local),
new DateTime(year: 2014, month: 10, day: 12, hour: 17, minute: 40, second: 56, millisecond: 500, kind: DateTimeKind.Local),
new DateTime(year: 1944, month: 10, day: 11, hour: 14, minute: 29, second: 51, millisecond: 938, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 124,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1950, month: 10, day: 16, hour: 15, minute: 2, second: 1, millisecond: 898, kind: DateTimeKind.Local),
new DateTime(year: 2008, month: 10, day: 17, hour: 8, minute: 31, second: 44, millisecond: 487, kind: DateTimeKind.Local),
new DateTime(year: 1928, month: 10, day: 1, hour: 13, minute: 23, second: 56, millisecond: 570, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1939, month: 10, day: 2, hour: 19, minute: 37, second: 41, millisecond: 397, kind: DateTimeKind.Local),
new DateTime(year: 1990, month: 10, day: 14, hour: 13, minute: 54, second: 18, millisecond: 19, kind: DateTimeKind.Local),
new DateTime(year: 1995, month: 10, day: 1, hour: 21, minute: 37, second: 55, millisecond: 334, kind: DateTimeKind.Local),
new DateTime(year: 2005, month: 10, day: 8, hour: 20, minute: 9, second: 42, millisecond: 737, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 130,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 2001, month: 10, day: 1, hour: 8, minute: 49, second: 8, millisecond: 412, kind: DateTimeKind.Local),
new DateTime(year: 1917, month: 10, day: 12, hour: 10, minute: 15, second: 46, millisecond: 182, kind: DateTimeKind.Local),
new DateTime(year: 2000, month: 10, day: 17, hour: 17, minute: 32, second: 54, millisecond: 558, kind: DateTimeKind.Local),
new DateTime(year: 1928, month: 10, day: 6, hour: 9, minute: 8, second: 20, millisecond: 641, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 61,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 2018, month: 10, day: 16, hour: 20, minute: 40, second: 17, millisecond: 456, kind: DateTimeKind.Local),
new DateTime(year: 1931, month: 10, day: 7, hour: 16, minute: 43, second: 30, millisecond: 514, kind: DateTimeKind.Local),
new DateTime(year: 1976, month: 10, day: 18, hour: 8, minute: 43, second: 13, millisecond: 986, kind: DateTimeKind.Local),
new DateTime(year: 1947, month: 10, day: 3, hour: 16, minute: 30, second: 21, millisecond: 998, kind: DateTimeKind.Local),
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1921, month: 10, day: 5, hour: 2, minute: 4, second: 58, millisecond: 469, kind: DateTimeKind.Local),
new DateTime(year: 1952, month: 10, day: 11, hour: 11, minute: 25, second: 32, millisecond: 103, kind: DateTimeKind.Local),
new DateTime(year: 1959, month: 10, day: 7, hour: 3, minute: 11, second: 35, millisecond: 941, kind: DateTimeKind.Local),
},
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 134,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 2010, month: 10, day: 18, hour: 19, minute: 3, second: 40, millisecond: 940, kind: DateTimeKind.Local),
new DateTime(year: 1985, month: 10, day: 8, hour: 12, minute: 51, second: 4, millisecond: 952, kind: DateTimeKind.Local),
new DateTime(year: 1969, month: 10, day: 17, hour: 22, minute: 53, second: 22, millisecond: 593, kind: DateTimeKind.Local),
new DateTime(year: 2001, month: 10, day: 1, hour: 19, minute: 58, second: 16, millisecond: 936, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 139,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1966, month: 10, day: 17, hour: 6, minute: 46, second: 26, millisecond: 670, kind: DateTimeKind.Local),
new DateTime(year: 2000, month: 10, day: 1, hour: 15, minute: 44, second: 56, millisecond: 186, kind: DateTimeKind.Local),
new DateTime(year: 1970, month: 10, day: 5, hour: 6, minute: 1, second: 53, millisecond: 20, kind: DateTimeKind.Local),
new DateTime(year: 1961, month: 10, day: 19, hour: 13, minute: 46, second: 44, millisecond: 620, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 65,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1971, month: 10, day: 16, hour: 20, minute: 31, second: 43, millisecond: 220, kind: DateTimeKind.Local),
new DateTime(year: 1996, month: 10, day: 17, hour: 1, minute: 36, second: 1, millisecond: 533, kind: DateTimeKind.Local),
new DateTime(year: 1995, month: 10, day: 9, hour: 20, minute: 14, second: 50, millisecond: 93, kind: DateTimeKind.Local),
new DateTime(year: 1939, month: 10, day: 13, hour: 11, minute: 13, second: 33, millisecond: 994, kind: DateTimeKind.Local),
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1980, month: 10, day: 17, hour: 15, minute: 42, second: 1, millisecond: 720, kind: DateTimeKind.Local),
new DateTime(year: 2010, month: 10, day: 8, hour: 8, minute: 15, second: 51, millisecond: 995, kind: DateTimeKind.Local),
new DateTime(year: 2007, month: 10, day: 14, hour: 13, minute: 42, second: 27, millisecond: 375, kind: DateTimeKind.Local),
},
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 143,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1954, month: 10, day: 17, hour: 20, minute: 26, second: 4, millisecond: 696, kind: DateTimeKind.Local),
new DateTime(year: 2010, month: 10, day: 7, hour: 19, minute: 13, second: 56, millisecond: 149, kind: DateTimeKind.Local),
new DateTime(year: 1963, month: 10, day: 7, hour: 17, minute: 16, second: 36, millisecond: 342, kind: DateTimeKind.Local),
new DateTime(year: 1986, month: 10, day: 9, hour: 10, minute: 23, second: 13, millisecond: 561, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 149,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1944, month: 10, day: 18, hour: 4, minute: 20, second: 31, millisecond: 717, kind: DateTimeKind.Local),
new DateTime(year: 1935, month: 10, day: 7, hour: 13, minute: 16, second: 6, millisecond: 802, kind: DateTimeKind.Local),
new DateTime(year: 1939, month: 10, day: 4, hour: 9, minute: 48, second: 51, millisecond: 193, kind: DateTimeKind.Local),
new DateTime(year: 1938, month: 10, day: 13, hour: 1, minute: 19, second: 58, millisecond: 869, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 73,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1923, month: 10, day: 12, hour: 4, minute: 50, second: 27, millisecond: 948, kind: DateTimeKind.Local),
new DateTime(year: 1999, month: 10, day: 7, hour: 16, minute: 4, second: 53, millisecond: 873, kind: DateTimeKind.Local),
new DateTime(year: 1931, month: 10, day: 6, hour: 14, minute: 14, second: 16, millisecond: 646, kind: DateTimeKind.Local),
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1976, month: 10, day: 4, hour: 17, minute: 24, second: 44, millisecond: 381, kind: DateTimeKind.Local),
new DateTime(year: 1953, month: 10, day: 11, hour: 17, minute: 21, second: 30, millisecond: 412, kind: DateTimeKind.Local),
new DateTime(year: 1953, month: 10, day: 17, hour: 14, minute: 39, second: 4, millisecond: 313, kind: DateTimeKind.Local),
new DateTime(year: 1966, month: 10, day: 1, hour: 1, minute: 19, second: 6, millisecond: 800, kind: DateTimeKind.Local),
},
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1944, month: 10, day: 18, hour: 12, minute: 50, second: 40, millisecond: 467, kind: DateTimeKind.Local),
new DateTime(year: 1939, month: 10, day: 1, hour: 17, minute: 46, second: 26, millisecond: 450, kind: DateTimeKind.Local),
new DateTime(year: 1987, month: 10, day: 8, hour: 11, minute: 58, second: 53, millisecond: 498, kind: DateTimeKind.Local),
new DateTime(year: 1928, month: 10, day: 10, hour: 4, minute: 34, second: 48, millisecond: 906, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 158,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 2007, month: 10, day: 18, hour: 2, minute: 45, second: 38, millisecond: 797, kind: DateTimeKind.Local),
new DateTime(year: 1971, month: 10, day: 8, hour: 13, minute: 32, second: 18, millisecond: 765, kind: DateTimeKind.Local),
new DateTime(year: 1983, month: 10, day: 5, hour: 13, minute: 10, second: 9, millisecond: 401, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1957, month: 10, day: 1, hour: 18, minute: 13, second: 23, millisecond: 514, kind: DateTimeKind.Local),
new DateTime(year: 1990, month: 10, day: 10, hour: 13, minute: 10, second: 32, millisecond: 289, kind: DateTimeKind.Local),
new DateTime(year: 1940, month: 10, day: 19, hour: 8, minute: 35, second: 46, millisecond: 38, kind: DateTimeKind.Local),
new DateTime(year: 1927, month: 10, day: 12, hour: 14, minute: 11, second: 16, millisecond: 918, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 162,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1986, month: 10, day: 19, hour: 14, minute: 38, second: 6, millisecond: 715, kind: DateTimeKind.Local),
new DateTime(year: 2001, month: 10, day: 15, hour: 17, minute: 22, second: 58, millisecond: 817, kind: DateTimeKind.Local),
new DateTime(year: 1995, month: 10, day: 6, hour: 22, minute: 15, second: 16, millisecond: 791, kind: DateTimeKind.Local),
new DateTime(year: 1987, month: 10, day: 7, hour: 17, minute: 23, second: 52, millisecond: 833, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 76,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1979, month: 10, day: 1, hour: 8, minute: 28, second: 13, millisecond: 483, kind: DateTimeKind.Local),
new DateTime(year: 1926, month: 10, day: 1, hour: 15, minute: 52, second: 47, millisecond: 144, kind: DateTimeKind.Local),
new DateTime(year: 1983, month: 10, day: 15, hour: 14, minute: 18, second: 15, millisecond: 263, kind: DateTimeKind.Local),
new DateTime(year: 1938, month: 10, day: 1, hour: 4, minute: 35, second: 24, millisecond: 407, kind: DateTimeKind.Local),
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1937, month: 10, day: 2, hour: 13, minute: 58, second: 45, millisecond: 233, kind: DateTimeKind.Local),
new DateTime(year: 1984, month: 10, day: 6, hour: 9, minute: 25, second: 22, millisecond: 894, kind: DateTimeKind.Local),
new DateTime(year: 1946, month: 10, day: 8, hour: 3, minute: 19, second: 2, millisecond: 376, kind: DateTimeKind.Local),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.DateTime[3]
{
new DateTime(year: 2012, month: 10, day: 10, hour: 4, minute: 55, second: 11, millisecond: 485, kind: DateTimeKind.Local),
new DateTime(year: 1970, month: 10, day: 9, hour: 8, minute: 35, second: 33, millisecond: 342, kind: DateTimeKind.Local),
new DateTime(year: 1946, month: 10, day: 15, hour: 2, minute: 49, second: 10, millisecond: 95, kind: DateTimeKind.Local),
}));
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
new System.DateTime[3]
{
new DateTime(year: 1934, month: 10, day: 16, hour: 11, minute: 18, second: 57, millisecond: 517, kind: DateTimeKind.Local),
new DateTime(year: 1949, month: 10, day: 14, hour: 9, minute: 23, second: 23, millisecond: 792, kind: DateTimeKind.Local),
new DateTime(year: 1974, month: 10, day: 16, hour: 17, minute: 10, second: 54, millisecond: 268, kind: DateTimeKind.Local),
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
                Assert.That(nullable, Is.Null);
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
new DateTime(year: 1931, month: 10, day: 3, hour: 9, minute: 14, second: 9, millisecond: 606, kind: DateTimeKind.Local),
new DateTime(year: 2001, month: 10, day: 13, hour: 19, minute: 25, second: 38, millisecond: 452, kind: DateTimeKind.Local),
new DateTime(year: 1934, month: 10, day: 4, hour: 7, minute: 20, second: 9, millisecond: 589, kind: DateTimeKind.Local),
new DateTime(year: 1995, month: 10, day: 2, hour: 9, minute: 50, second: 15, millisecond: 516, kind: DateTimeKind.Local),
}));
                nullable =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.DateTime[3]
{
new DateTime(year: 1921, month: 10, day: 1, hour: 19, minute: 39, second: 8, millisecond: 589, kind: DateTimeKind.Local),
new DateTime(year: 1999, month: 10, day: 11, hour: 10, minute: 54, second: 34, millisecond: 288, kind: DateTimeKind.Local),
new DateTime(year: 2007, month: 10, day: 12, hour: 12, minute: 33, second: 36, millisecond: 505, kind: DateTimeKind.Local),
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
new DateTime(year: 2005, month: 10, day: 11, hour: 5, minute: 46, second: 12, millisecond: 827, kind: DateTimeKind.Local),
new DateTime(year: 1993, month: 10, day: 8, hour: 20, minute: 43, second: 53, millisecond: 114, kind: DateTimeKind.Local),
new DateTime(year: 2012, month: 10, day: 15, hour: 21, minute: 14, second: 17, millisecond: 910, kind: DateTimeKind.Local),
new DateTime(year: 1996, month: 10, day: 18, hour: 16, minute: 3, second: 34, millisecond: 715, kind: DateTimeKind.Local),
}));
                nullable = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.DateTime[3]
{
new DateTime(year: 1967, month: 10, day: 17, hour: 1, minute: 51, second: 31, millisecond: 249, kind: DateTimeKind.Local),
new DateTime(year: 1946, month: 10, day: 12, hour: 5, minute: 15, second: 14, millisecond: 105, kind: DateTimeKind.Local),
new DateTime(year: 1924, month: 10, day: 17, hour: 19, minute: 17, second: 8, millisecond: 128, kind: DateTimeKind.Local),
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
                parametr1.Value = 91;
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
                        Assert.That(models, Has.Count.EqualTo(15));
FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[15], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[16], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[17], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[18], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[19], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[20], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[21], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[22], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[23], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[24], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[25], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[26], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[27], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[28], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[26], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[27], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[28], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[29], false);
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
                parametr1.Value = 49;
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
                foreach(var batchResult in  ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[8], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[9], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[10], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[11], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[12], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[13], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[14], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[15], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[16], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[17], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[18], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[19], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[20], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[21], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[22], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[23], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[16],_testData[24], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[17],_testData[25], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[18],_testData[26], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[19],_testData[27], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[20],_testData[28], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[3], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[4], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[5], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[6], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[7], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[8], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[9], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[10], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[11], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[12], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[13], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[14], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[15], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[16], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[17], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[18], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[16],_testData[19], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[17],_testData[20], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[18],_testData[21], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[19],_testData[22], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[20],_testData[23], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[21],_testData[24], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[22],_testData[25], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[23],_testData[26], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[24],_testData[27], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[25],_testData[28], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[26],_testData[29], false);
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
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[26], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[27], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[28], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[2], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[3], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[4], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[5], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[6], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[7], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[8], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[9], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[10], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[11], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[12], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[13], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[14], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[15], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[16], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[17], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[16],_testData[18], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[17],_testData[19], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[18],_testData[20], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[19],_testData[21], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[20],_testData[22], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[21],_testData[23], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[22],_testData[24], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[23],_testData[25], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[24],_testData[26], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[25],_testData[27], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[26],_testData[28], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[27],_testData[29], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
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
                        Assert.That(models, Has.Count.EqualTo(23));
DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[7], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[8], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[9], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[10], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[11], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[12], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[13], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[14], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[15], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[16], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[17], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[18], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[19], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[20], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[21], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[22], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[16],_testData[23], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[17],_testData[24], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[18],_testData[25], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[19],_testData[26], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[20],_testData[27], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[21],_testData[28], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[22],_testData[29], false);
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
                foreach(var batchResult in await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 53, query1, 16, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[9], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[10], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[11], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[12], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[13], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[14], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[15], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[16], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[17], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[18], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[19], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[20], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[21], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[22], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[23], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[24], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[16],_testData[25], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[17],_testData[26], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[18],_testData[27], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[19],_testData[28], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[2], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[3], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[4], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[5], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[6], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[7], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[8], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[9], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[10], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[11], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[12], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[13], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[14], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[15], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[16], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[17], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[16],_testData[18], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[17],_testData[19], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[18],_testData[20], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[19],_testData[21], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[20],_testData[22], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[21],_testData[23], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[22],_testData[24], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[23],_testData[25], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[24],_testData[26], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[25],_testData[27], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[26],_testData[28], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[27],_testData[29], false);
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
                foreach(var batchResult in  ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatch(connection, 67, query1, 106, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[11], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[12], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[13], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[14], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[15], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[16], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[17], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[18], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[19], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[20], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[21], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[22], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[23], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[24], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[25], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[26], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[16],_testData[27], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[17],_testData[28], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[19], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[20], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[21], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[22], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[23], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[24], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[25], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[26], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[27], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[28], false);FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[29], false);
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
                foreach(var batchResult in await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSelectModelBatchAsync(connection, 103, 67))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[18], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[19], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[20], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[21], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[22], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[23], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[24], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[25], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[26], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[27], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[28], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[11], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[12], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[13], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[14], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[15], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[16], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[17], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[18], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[19], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[20], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[21], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[22], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[23], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[24], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[25], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[26], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[16],_testData[27], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[17],_testData[28], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[18],_testData[29], false);
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
                foreach(var batchResult in  ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSelectModelBatch(connection, 149, 84))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[28], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[14], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[15], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[16], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[17], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[18], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[19], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[20], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[21], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[22], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[23], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[24], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[25], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[26], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[27], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[28], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[29], false);
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
                ((IDateTimeArraytimestamp_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 9);
                var models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[1], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[2], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[3], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[4], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[5], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[6], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[7], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[8], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[9], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[10], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[11], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[12], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[13], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[14], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[15], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[16], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[16],_testData[17], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[17],_testData[18], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[18],_testData[19], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[19],_testData[20], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[20],_testData[21], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[21],_testData[22], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[22],_testData[23], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[23],_testData[24], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[24],_testData[25], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[25],_testData[26], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[26],_testData[27], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[27],_testData[28], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[28],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateTimeArraytimestamp_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 25);
                var models =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(26));
DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[4], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[5], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[6], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[7], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[8], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[9], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[10], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[11], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[12], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[13], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[14], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[15], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[16], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[17], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[18], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[19], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[16],_testData[20], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[17],_testData[21], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[18],_testData[22], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[19],_testData[23], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[20],_testData[24], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[21],_testData[25], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[22],_testData[26], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[23],_testData[27], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[24],_testData[28], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[25],_testData[29], false);
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

