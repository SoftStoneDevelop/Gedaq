

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
    Id = 6,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1959, month: 10, day: 11, hour: 18, minute: 11, second: 31, millisecond: 989, kind: DateTimeKind.Local),
new DateTime(year: 1976, month: 10, day: 6, hour: 12, minute: 40, second: 11, millisecond: 804, kind: DateTimeKind.Local),
new DateTime(year: 2008, month: 10, day: 13, hour: 11, minute: 6, second: 6, millisecond: 553, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1937, month: 10, day: 16, hour: 22, minute: 29, second: 19, millisecond: 356, kind: DateTimeKind.Local),
new DateTime(year: 1955, month: 10, day: 6, hour: 11, minute: 27, second: 11, millisecond: 333, kind: DateTimeKind.Local),
new DateTime(year: 2005, month: 10, day: 13, hour: 18, minute: 6, second: 6, millisecond: 518, kind: DateTimeKind.Local),
new DateTime(year: 1970, month: 10, day: 7, hour: 13, minute: 49, second: 29, millisecond: 356, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 8,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1918, month: 10, day: 14, hour: 11, minute: 36, second: 53, millisecond: 282, kind: DateTimeKind.Local),
new DateTime(year: 1969, month: 10, day: 18, hour: 4, minute: 30, second: 1, millisecond: 62, kind: DateTimeKind.Local),
new DateTime(year: 1974, month: 10, day: 6, hour: 15, minute: 30, second: 56, millisecond: 522, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 4,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1952, month: 10, day: 9, hour: 11, minute: 54, second: 16, millisecond: 784, kind: DateTimeKind.Local),
new DateTime(year: 2018, month: 10, day: 8, hour: 2, minute: 37, second: 41, millisecond: 737, kind: DateTimeKind.Local),
new DateTime(year: 1943, month: 10, day: 13, hour: 1, minute: 6, second: 1, millisecond: 469, kind: DateTimeKind.Local),
new DateTime(year: 2002, month: 10, day: 7, hour: 15, minute: 23, second: 35, millisecond: 765, kind: DateTimeKind.Local),
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1966, month: 10, day: 14, hour: 11, minute: 35, second: 39, millisecond: 96, kind: DateTimeKind.Local),
new DateTime(year: 2004, month: 10, day: 14, hour: 14, minute: 16, second: 30, millisecond: 20, kind: DateTimeKind.Local),
new DateTime(year: 1994, month: 10, day: 19, hour: 21, minute: 57, second: 19, millisecond: 92, kind: DateTimeKind.Local),
new DateTime(year: 1941, month: 10, day: 1, hour: 14, minute: 1, second: 11, millisecond: 293, kind: DateTimeKind.Local),
},
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1970, month: 10, day: 11, hour: 5, minute: 18, second: 14, millisecond: 770, kind: DateTimeKind.Local),
new DateTime(year: 1955, month: 10, day: 6, hour: 10, minute: 55, second: 16, millisecond: 873, kind: DateTimeKind.Local),
new DateTime(year: 2018, month: 10, day: 7, hour: 19, minute: 33, second: 49, millisecond: 797, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 14,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1967, month: 10, day: 19, hour: 18, minute: 1, second: 34, millisecond: 769, kind: DateTimeKind.Local),
new DateTime(year: 1980, month: 10, day: 1, hour: 8, minute: 13, second: 53, millisecond: 764, kind: DateTimeKind.Local),
new DateTime(year: 1984, month: 10, day: 7, hour: 11, minute: 11, second: 2, millisecond: 815, kind: DateTimeKind.Local),
new DateTime(year: 1957, month: 10, day: 12, hour: 4, minute: 30, second: 19, millisecond: 37, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 22,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1943, month: 10, day: 18, hour: 22, minute: 29, second: 46, millisecond: 643, kind: DateTimeKind.Local),
new DateTime(year: 1992, month: 10, day: 15, hour: 8, minute: 31, second: 44, millisecond: 512, kind: DateTimeKind.Local),
new DateTime(year: 1993, month: 10, day: 6, hour: 6, minute: 24, second: 34, millisecond: 389, kind: DateTimeKind.Local),
new DateTime(year: 2017, month: 10, day: 10, hour: 17, minute: 25, second: 29, millisecond: 254, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 8,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1945, month: 10, day: 16, hour: 10, minute: 43, second: 26, millisecond: 464, kind: DateTimeKind.Local),
new DateTime(year: 1975, month: 10, day: 9, hour: 14, minute: 40, second: 46, millisecond: 136, kind: DateTimeKind.Local),
new DateTime(year: 1962, month: 10, day: 6, hour: 16, minute: 37, second: 20, millisecond: 260, kind: DateTimeKind.Local),
new DateTime(year: 1976, month: 10, day: 9, hour: 9, minute: 48, second: 53, millisecond: 838, kind: DateTimeKind.Local),
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1944, month: 10, day: 3, hour: 15, minute: 26, second: 4, millisecond: 844, kind: DateTimeKind.Local),
new DateTime(year: 2014, month: 10, day: 14, hour: 19, minute: 47, second: 36, millisecond: 326, kind: DateTimeKind.Local),
new DateTime(year: 1926, month: 10, day: 16, hour: 6, minute: 8, second: 11, millisecond: 768, kind: DateTimeKind.Local),
},
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1975, month: 10, day: 3, hour: 13, minute: 33, second: 11, millisecond: 768, kind: DateTimeKind.Local),
new DateTime(year: 1948, month: 10, day: 9, hour: 15, minute: 56, second: 7, millisecond: 248, kind: DateTimeKind.Local),
new DateTime(year: 1983, month: 10, day: 13, hour: 15, minute: 21, second: 47, millisecond: 352, kind: DateTimeKind.Local),
new DateTime(year: 1980, month: 10, day: 1, hour: 13, minute: 40, second: 29, millisecond: 462, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 29,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1928, month: 10, day: 16, hour: 2, minute: 17, second: 57, millisecond: 793, kind: DateTimeKind.Local),
new DateTime(year: 1999, month: 10, day: 4, hour: 7, minute: 21, second: 53, millisecond: 412, kind: DateTimeKind.Local),
new DateTime(year: 1970, month: 10, day: 7, hour: 15, minute: 50, second: 26, millisecond: 680, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 31,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 2017, month: 10, day: 2, hour: 18, minute: 29, second: 32, millisecond: 310, kind: DateTimeKind.Local),
new DateTime(year: 1949, month: 10, day: 6, hour: 5, minute: 12, second: 31, millisecond: 281, kind: DateTimeKind.Local),
new DateTime(year: 1939, month: 10, day: 12, hour: 13, minute: 39, second: 21, millisecond: 43, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 16,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1958, month: 10, day: 19, hour: 7, minute: 43, second: 40, millisecond: 90, kind: DateTimeKind.Local),
new DateTime(year: 2005, month: 10, day: 6, hour: 15, minute: 8, second: 16, millisecond: 31, kind: DateTimeKind.Local),
new DateTime(year: 1975, month: 10, day: 11, hour: 14, minute: 54, second: 10, millisecond: 120, kind: DateTimeKind.Local),
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 2011, month: 10, day: 9, hour: 19, minute: 57, second: 58, millisecond: 907, kind: DateTimeKind.Local),
new DateTime(year: 1956, month: 10, day: 10, hour: 1, minute: 15, second: 38, millisecond: 305, kind: DateTimeKind.Local),
new DateTime(year: 1934, month: 10, day: 15, hour: 20, minute: 12, second: 25, millisecond: 144, kind: DateTimeKind.Local),
},
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 38,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1982, month: 10, day: 10, hour: 12, minute: 37, second: 48, millisecond: 327, kind: DateTimeKind.Local),
new DateTime(year: 1936, month: 10, day: 9, hour: 22, minute: 31, second: 12, millisecond: 771, kind: DateTimeKind.Local),
new DateTime(year: 1952, month: 10, day: 16, hour: 10, minute: 7, second: 4, millisecond: 390, kind: DateTimeKind.Local),
new DateTime(year: 1967, month: 10, day: 5, hour: 5, minute: 19, second: 41, millisecond: 802, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1981, month: 10, day: 12, hour: 17, minute: 55, second: 55, millisecond: 874, kind: DateTimeKind.Local),
new DateTime(year: 1992, month: 10, day: 11, hour: 9, minute: 17, second: 41, millisecond: 8, kind: DateTimeKind.Local),
new DateTime(year: 1943, month: 10, day: 14, hour: 5, minute: 16, second: 13, millisecond: 985, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 46,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 2008, month: 10, day: 7, hour: 17, minute: 6, second: 3, millisecond: 804, kind: DateTimeKind.Local),
new DateTime(year: 1922, month: 10, day: 19, hour: 1, minute: 57, second: 7, millisecond: 428, kind: DateTimeKind.Local),
new DateTime(year: 1956, month: 10, day: 2, hour: 14, minute: 15, second: 13, millisecond: 174, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 22,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1999, month: 10, day: 15, hour: 16, minute: 39, second: 4, millisecond: 289, kind: DateTimeKind.Local),
new DateTime(year: 1979, month: 10, day: 12, hour: 14, minute: 30, second: 37, millisecond: 106, kind: DateTimeKind.Local),
new DateTime(year: 1998, month: 10, day: 4, hour: 4, minute: 10, second: 24, millisecond: 629, kind: DateTimeKind.Local),
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1953, month: 10, day: 18, hour: 20, minute: 43, second: 28, millisecond: 213, kind: DateTimeKind.Local),
new DateTime(year: 1980, month: 10, day: 17, hour: 18, minute: 40, second: 37, millisecond: 178, kind: DateTimeKind.Local),
new DateTime(year: 1920, month: 10, day: 6, hour: 4, minute: 54, second: 7, millisecond: 236, kind: DateTimeKind.Local),
},
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 55,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1979, month: 10, day: 4, hour: 12, minute: 56, second: 21, millisecond: 171, kind: DateTimeKind.Local),
new DateTime(year: 2006, month: 10, day: 8, hour: 17, minute: 24, second: 22, millisecond: 761, kind: DateTimeKind.Local),
new DateTime(year: 1966, month: 10, day: 15, hour: 1, minute: 44, second: 52, millisecond: 494, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 64,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 2006, month: 10, day: 19, hour: 16, minute: 20, second: 35, millisecond: 931, kind: DateTimeKind.Local),
new DateTime(year: 1952, month: 10, day: 8, hour: 18, minute: 11, second: 58, millisecond: 503, kind: DateTimeKind.Local),
new DateTime(year: 1976, month: 10, day: 4, hour: 19, minute: 33, second: 13, millisecond: 939, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 30,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 2018, month: 10, day: 6, hour: 8, minute: 28, second: 37, millisecond: 760, kind: DateTimeKind.Local),
new DateTime(year: 1944, month: 10, day: 6, hour: 22, minute: 14, second: 25, millisecond: 417, kind: DateTimeKind.Local),
new DateTime(year: 1957, month: 10, day: 12, hour: 2, minute: 36, second: 4, millisecond: 58, kind: DateTimeKind.Local),
new DateTime(year: 1948, month: 10, day: 14, hour: 13, minute: 16, second: 58, millisecond: 208, kind: DateTimeKind.Local),
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1959, month: 10, day: 5, hour: 9, minute: 49, second: 45, millisecond: 994, kind: DateTimeKind.Local),
new DateTime(year: 1997, month: 10, day: 14, hour: 15, minute: 49, second: 38, millisecond: 752, kind: DateTimeKind.Local),
new DateTime(year: 1940, month: 10, day: 10, hour: 5, minute: 10, second: 31, millisecond: 623, kind: DateTimeKind.Local),
},
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1965, month: 10, day: 12, hour: 9, minute: 31, second: 13, millisecond: 296, kind: DateTimeKind.Local),
new DateTime(year: 1925, month: 10, day: 9, hour: 10, minute: 54, second: 29, millisecond: 60, kind: DateTimeKind.Local),
new DateTime(year: 1947, month: 10, day: 17, hour: 12, minute: 8, second: 33, millisecond: 219, kind: DateTimeKind.Local),
new DateTime(year: 1936, month: 10, day: 18, hour: 19, minute: 20, second: 18, millisecond: 280, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 72,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 2017, month: 10, day: 4, hour: 1, minute: 24, second: 38, millisecond: 791, kind: DateTimeKind.Local),
new DateTime(year: 1924, month: 10, day: 16, hour: 18, minute: 49, second: 19, millisecond: 835, kind: DateTimeKind.Local),
new DateTime(year: 1993, month: 10, day: 15, hour: 15, minute: 30, second: 34, millisecond: 566, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 73,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1924, month: 10, day: 4, hour: 14, minute: 24, second: 5, millisecond: 968, kind: DateTimeKind.Local),
new DateTime(year: 1964, month: 10, day: 19, hour: 8, minute: 32, second: 11, millisecond: 24, kind: DateTimeKind.Local),
new DateTime(year: 2010, month: 10, day: 13, hour: 12, minute: 41, second: 35, millisecond: 835, kind: DateTimeKind.Local),
new DateTime(year: 1965, month: 10, day: 1, hour: 10, minute: 15, second: 34, millisecond: 355, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 38,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1923, month: 10, day: 9, hour: 21, minute: 53, second: 17, millisecond: 532, kind: DateTimeKind.Local),
new DateTime(year: 2009, month: 10, day: 7, hour: 14, minute: 16, second: 4, millisecond: 336, kind: DateTimeKind.Local),
new DateTime(year: 1953, month: 10, day: 2, hour: 13, minute: 54, second: 20, millisecond: 134, kind: DateTimeKind.Local),
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1932, month: 10, day: 3, hour: 9, minute: 36, second: 13, millisecond: 102, kind: DateTimeKind.Local),
new DateTime(year: 2006, month: 10, day: 7, hour: 3, minute: 42, second: 4, millisecond: 637, kind: DateTimeKind.Local),
new DateTime(year: 1984, month: 10, day: 5, hour: 20, minute: 30, second: 31, millisecond: 162, kind: DateTimeKind.Local),
},
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 76,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1948, month: 10, day: 7, hour: 16, minute: 8, second: 16, millisecond: 367, kind: DateTimeKind.Local),
new DateTime(year: 2014, month: 10, day: 10, hour: 5, minute: 29, second: 13, millisecond: 165, kind: DateTimeKind.Local),
new DateTime(year: 1942, month: 10, day: 3, hour: 19, minute: 10, second: 42, millisecond: 461, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 82,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1921, month: 10, day: 15, hour: 16, minute: 28, second: 54, millisecond: 405, kind: DateTimeKind.Local),
new DateTime(year: 1955, month: 10, day: 11, hour: 19, minute: 36, second: 56, millisecond: 565, kind: DateTimeKind.Local),
new DateTime(year: 1946, month: 10, day: 9, hour: 9, minute: 15, second: 34, millisecond: 154, kind: DateTimeKind.Local),
new DateTime(year: 2007, month: 10, day: 9, hour: 21, minute: 22, second: 6, millisecond: 715, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 44,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1988, month: 10, day: 8, hour: 17, minute: 47, second: 33, millisecond: 779, kind: DateTimeKind.Local),
new DateTime(year: 1995, month: 10, day: 14, hour: 10, minute: 42, second: 56, millisecond: 200, kind: DateTimeKind.Local),
new DateTime(year: 2012, month: 10, day: 12, hour: 22, minute: 52, second: 3, millisecond: 232, kind: DateTimeKind.Local),
new DateTime(year: 1922, month: 10, day: 8, hour: 11, minute: 51, second: 35, millisecond: 956, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1998, month: 10, day: 3, hour: 10, minute: 13, second: 24, millisecond: 301, kind: DateTimeKind.Local),
new DateTime(year: 1957, month: 10, day: 12, hour: 17, minute: 34, second: 10, millisecond: 734, kind: DateTimeKind.Local),
new DateTime(year: 1991, month: 10, day: 7, hour: 1, minute: 5, second: 38, millisecond: 246, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 91,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1942, month: 10, day: 2, hour: 2, minute: 42, second: 25, millisecond: 770, kind: DateTimeKind.Local),
new DateTime(year: 2009, month: 10, day: 19, hour: 8, minute: 24, second: 47, millisecond: 230, kind: DateTimeKind.Local),
new DateTime(year: 2004, month: 10, day: 3, hour: 10, minute: 25, second: 30, millisecond: 222, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1954, month: 10, day: 4, hour: 14, minute: 15, second: 7, millisecond: 406, kind: DateTimeKind.Local),
new DateTime(year: 1954, month: 10, day: 7, hour: 19, minute: 3, second: 47, millisecond: 470, kind: DateTimeKind.Local),
new DateTime(year: 1960, month: 10, day: 15, hour: 4, minute: 38, second: 14, millisecond: 499, kind: DateTimeKind.Local),
new DateTime(year: 1937, month: 10, day: 5, hour: 9, minute: 57, second: 4, millisecond: 508, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 99,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1982, month: 10, day: 17, hour: 21, minute: 10, second: 18, millisecond: 510, kind: DateTimeKind.Local),
new DateTime(year: 1998, month: 10, day: 12, hour: 20, minute: 45, second: 9, millisecond: 895, kind: DateTimeKind.Local),
new DateTime(year: 1922, month: 10, day: 17, hour: 16, minute: 10, second: 48, millisecond: 386, kind: DateTimeKind.Local),
new DateTime(year: 1932, month: 10, day: 18, hour: 20, minute: 4, second: 32, millisecond: 355, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 51,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1978, month: 10, day: 16, hour: 20, minute: 7, second: 56, millisecond: 286, kind: DateTimeKind.Local),
new DateTime(year: 1945, month: 10, day: 11, hour: 4, minute: 3, second: 11, millisecond: 166, kind: DateTimeKind.Local),
new DateTime(year: 1929, month: 10, day: 9, hour: 19, minute: 28, second: 48, millisecond: 147, kind: DateTimeKind.Local),
new DateTime(year: 2008, month: 10, day: 12, hour: 17, minute: 7, second: 7, millisecond: 133, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 100,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1963, month: 10, day: 16, hour: 16, minute: 52, second: 12, millisecond: 102, kind: DateTimeKind.Local),
new DateTime(year: 2011, month: 10, day: 6, hour: 6, minute: 19, second: 26, millisecond: 883, kind: DateTimeKind.Local),
new DateTime(year: 2015, month: 10, day: 11, hour: 2, minute: 19, second: 27, millisecond: 901, kind: DateTimeKind.Local),
new DateTime(year: 1919, month: 10, day: 16, hour: 14, minute: 52, second: 19, millisecond: 288, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1921, month: 10, day: 14, hour: 6, minute: 26, second: 48, millisecond: 820, kind: DateTimeKind.Local),
new DateTime(year: 1963, month: 10, day: 12, hour: 14, minute: 17, second: 6, millisecond: 54, kind: DateTimeKind.Local),
new DateTime(year: 1990, month: 10, day: 1, hour: 14, minute: 49, second: 54, millisecond: 777, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 101,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1928, month: 10, day: 5, hour: 11, minute: 1, second: 58, millisecond: 697, kind: DateTimeKind.Local),
new DateTime(year: 1984, month: 10, day: 18, hour: 2, minute: 51, second: 32, millisecond: 68, kind: DateTimeKind.Local),
new DateTime(year: 1938, month: 10, day: 19, hour: 13, minute: 26, second: 15, millisecond: 439, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 52,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1963, month: 10, day: 16, hour: 12, minute: 8, second: 44, millisecond: 886, kind: DateTimeKind.Local),
new DateTime(year: 2015, month: 10, day: 5, hour: 13, minute: 51, second: 34, millisecond: 275, kind: DateTimeKind.Local),
new DateTime(year: 1953, month: 10, day: 8, hour: 9, minute: 3, second: 7, millisecond: 591, kind: DateTimeKind.Local),
new DateTime(year: 1978, month: 10, day: 14, hour: 19, minute: 36, second: 30, millisecond: 230, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 2005, month: 10, day: 7, hour: 21, minute: 51, second: 32, millisecond: 96, kind: DateTimeKind.Local),
new DateTime(year: 1971, month: 10, day: 16, hour: 11, minute: 44, second: 22, millisecond: 411, kind: DateTimeKind.Local),
new DateTime(year: 2017, month: 10, day: 19, hour: 19, minute: 55, second: 20, millisecond: 146, kind: DateTimeKind.Local),
new DateTime(year: 1937, month: 10, day: 4, hour: 5, minute: 27, second: 14, millisecond: 31, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 107,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1978, month: 10, day: 1, hour: 22, minute: 26, second: 32, millisecond: 180, kind: DateTimeKind.Local),
new DateTime(year: 1958, month: 10, day: 4, hour: 5, minute: 1, second: 2, millisecond: 44, kind: DateTimeKind.Local),
new DateTime(year: 1947, month: 10, day: 10, hour: 5, minute: 31, second: 19, millisecond: 680, kind: DateTimeKind.Local),
new DateTime(year: 1961, month: 10, day: 15, hour: 3, minute: 8, second: 28, millisecond: 441, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 2009, month: 10, day: 6, hour: 8, minute: 4, second: 45, millisecond: 573, kind: DateTimeKind.Local),
new DateTime(year: 2010, month: 10, day: 7, hour: 6, minute: 55, second: 21, millisecond: 418, kind: DateTimeKind.Local),
new DateTime(year: 1996, month: 10, day: 1, hour: 2, minute: 19, second: 55, millisecond: 195, kind: DateTimeKind.Local),
new DateTime(year: 1987, month: 10, day: 6, hour: 14, minute: 28, second: 21, millisecond: 78, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 112,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1975, month: 10, day: 14, hour: 18, minute: 47, second: 5, millisecond: 817, kind: DateTimeKind.Local),
new DateTime(year: 1990, month: 10, day: 1, hour: 20, minute: 39, second: 20, millisecond: 420, kind: DateTimeKind.Local),
new DateTime(year: 1953, month: 10, day: 11, hour: 8, minute: 22, second: 32, millisecond: 792, kind: DateTimeKind.Local),
new DateTime(year: 1942, month: 10, day: 7, hour: 12, minute: 42, second: 12, millisecond: 197, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 53,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1943, month: 10, day: 17, hour: 1, minute: 50, second: 47, millisecond: 626, kind: DateTimeKind.Local),
new DateTime(year: 1949, month: 10, day: 10, hour: 1, minute: 32, second: 55, millisecond: 351, kind: DateTimeKind.Local),
new DateTime(year: 1989, month: 10, day: 8, hour: 18, minute: 46, second: 21, millisecond: 201, kind: DateTimeKind.Local),
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1950, month: 10, day: 16, hour: 5, minute: 11, second: 13, millisecond: 884, kind: DateTimeKind.Local),
new DateTime(year: 1982, month: 10, day: 16, hour: 2, minute: 33, second: 10, millisecond: 680, kind: DateTimeKind.Local),
new DateTime(year: 1962, month: 10, day: 16, hour: 7, minute: 35, second: 17, millisecond: 921, kind: DateTimeKind.Local),
},
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1961, month: 10, day: 13, hour: 13, minute: 8, second: 37, millisecond: 119, kind: DateTimeKind.Local),
new DateTime(year: 2018, month: 10, day: 13, hour: 11, minute: 9, second: 6, millisecond: 249, kind: DateTimeKind.Local),
new DateTime(year: 1997, month: 10, day: 4, hour: 12, minute: 15, second: 36, millisecond: 263, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 121,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1985, month: 10, day: 19, hour: 6, minute: 53, second: 6, millisecond: 189, kind: DateTimeKind.Local),
new DateTime(year: 1920, month: 10, day: 16, hour: 12, minute: 4, second: 25, millisecond: 976, kind: DateTimeKind.Local),
new DateTime(year: 1995, month: 10, day: 12, hour: 19, minute: 38, second: 38, millisecond: 818, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 126,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1933, month: 10, day: 8, hour: 12, minute: 57, second: 15, millisecond: 496, kind: DateTimeKind.Local),
new DateTime(year: 2000, month: 10, day: 19, hour: 18, minute: 33, second: 46, millisecond: 170, kind: DateTimeKind.Local),
new DateTime(year: 1934, month: 10, day: 16, hour: 2, minute: 54, second: 32, millisecond: 955, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 54,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 2014, month: 10, day: 13, hour: 6, minute: 7, second: 38, millisecond: 299, kind: DateTimeKind.Local),
new DateTime(year: 2005, month: 10, day: 18, hour: 14, minute: 57, second: 50, millisecond: 686, kind: DateTimeKind.Local),
new DateTime(year: 1987, month: 10, day: 4, hour: 10, minute: 1, second: 43, millisecond: 296, kind: DateTimeKind.Local),
new DateTime(year: 1979, month: 10, day: 14, hour: 9, minute: 30, second: 26, millisecond: 441, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 127,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1991, month: 10, day: 11, hour: 15, minute: 11, second: 2, millisecond: 528, kind: DateTimeKind.Local),
new DateTime(year: 2001, month: 10, day: 14, hour: 15, minute: 13, second: 49, millisecond: 669, kind: DateTimeKind.Local),
new DateTime(year: 1937, month: 10, day: 19, hour: 12, minute: 22, second: 20, millisecond: 951, kind: DateTimeKind.Local),
new DateTime(year: 2008, month: 10, day: 2, hour: 21, minute: 12, second: 56, millisecond: 463, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 133,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1970, month: 10, day: 12, hour: 19, minute: 47, second: 19, millisecond: 277, kind: DateTimeKind.Local),
new DateTime(year: 1993, month: 10, day: 8, hour: 12, minute: 26, second: 46, millisecond: 514, kind: DateTimeKind.Local),
new DateTime(year: 1952, month: 10, day: 11, hour: 4, minute: 39, second: 6, millisecond: 209, kind: DateTimeKind.Local),
new DateTime(year: 2007, month: 10, day: 18, hour: 4, minute: 38, second: 57, millisecond: 521, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 62,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1946, month: 10, day: 5, hour: 6, minute: 23, second: 47, millisecond: 2, kind: DateTimeKind.Local),
new DateTime(year: 2014, month: 10, day: 14, hour: 15, minute: 11, second: 7, millisecond: 744, kind: DateTimeKind.Local),
new DateTime(year: 1986, month: 10, day: 16, hour: 6, minute: 27, second: 49, millisecond: 565, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 2013, month: 10, day: 11, hour: 15, minute: 25, second: 55, millisecond: 637, kind: DateTimeKind.Local),
new DateTime(year: 2011, month: 10, day: 13, hour: 5, minute: 32, second: 40, millisecond: 517, kind: DateTimeKind.Local),
new DateTime(year: 1986, month: 10, day: 6, hour: 15, minute: 19, second: 29, millisecond: 314, kind: DateTimeKind.Local),
},
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 141,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1984, month: 10, day: 3, hour: 16, minute: 49, second: 13, millisecond: 89, kind: DateTimeKind.Local),
new DateTime(year: 1936, month: 10, day: 18, hour: 1, minute: 29, second: 4, millisecond: 727, kind: DateTimeKind.Local),
new DateTime(year: 2018, month: 10, day: 19, hour: 8, minute: 56, second: 25, millisecond: 723, kind: DateTimeKind.Local),
new DateTime(year: 1963, month: 10, day: 16, hour: 20, minute: 29, second: 50, millisecond: 668, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 147,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1978, month: 10, day: 5, hour: 18, minute: 41, second: 37, millisecond: 908, kind: DateTimeKind.Local),
new DateTime(year: 1938, month: 10, day: 4, hour: 10, minute: 3, second: 25, millisecond: 476, kind: DateTimeKind.Local),
new DateTime(year: 2009, month: 10, day: 6, hour: 12, minute: 2, second: 27, millisecond: 98, kind: DateTimeKind.Local),
new DateTime(year: 1956, month: 10, day: 4, hour: 1, minute: 23, second: 42, millisecond: 887, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 70,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1979, month: 10, day: 11, hour: 10, minute: 17, second: 47, millisecond: 928, kind: DateTimeKind.Local),
new DateTime(year: 1927, month: 10, day: 5, hour: 11, minute: 33, second: 36, millisecond: 577, kind: DateTimeKind.Local),
new DateTime(year: 1981, month: 10, day: 19, hour: 21, minute: 1, second: 15, millisecond: 419, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 156,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1924, month: 10, day: 16, hour: 5, minute: 39, second: 48, millisecond: 678, kind: DateTimeKind.Local),
new DateTime(year: 1994, month: 10, day: 7, hour: 15, minute: 56, second: 37, millisecond: 301, kind: DateTimeKind.Local),
new DateTime(year: 1993, month: 10, day: 7, hour: 4, minute: 43, second: 41, millisecond: 538, kind: DateTimeKind.Local),
new DateTime(year: 1970, month: 10, day: 1, hour: 10, minute: 26, second: 7, millisecond: 126, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 161,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1966, month: 10, day: 16, hour: 10, minute: 28, second: 47, millisecond: 936, kind: DateTimeKind.Local),
new DateTime(year: 1966, month: 10, day: 3, hour: 4, minute: 51, second: 38, millisecond: 319, kind: DateTimeKind.Local),
new DateTime(year: 1982, month: 10, day: 1, hour: 17, minute: 51, second: 14, millisecond: 926, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 73,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 2012, month: 10, day: 13, hour: 4, minute: 47, second: 32, millisecond: 665, kind: DateTimeKind.Local),
new DateTime(year: 1994, month: 10, day: 9, hour: 11, minute: 38, second: 40, millisecond: 594, kind: DateTimeKind.Local),
new DateTime(year: 1982, month: 10, day: 12, hour: 21, minute: 25, second: 48, millisecond: 266, kind: DateTimeKind.Local),
new DateTime(year: 1977, month: 10, day: 11, hour: 5, minute: 9, second: 57, millisecond: 278, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 167,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 1930, month: 10, day: 6, hour: 5, minute: 34, second: 38, millisecond: 539, kind: DateTimeKind.Local),
new DateTime(year: 1984, month: 10, day: 19, hour: 8, minute: 42, second: 24, millisecond: 611, kind: DateTimeKind.Local),
new DateTime(year: 1949, month: 10, day: 2, hour: 1, minute: 50, second: 17, millisecond: 849, kind: DateTimeKind.Local),
new DateTime(year: 1929, month: 10, day: 9, hour: 12, minute: 28, second: 34, millisecond: 230, kind: DateTimeKind.Local),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneArray1M
{
    Id = 172,
    Value = 
new System.DateTime[3]
{
new DateTime(year: 1926, month: 10, day: 17, hour: 20, minute: 33, second: 32, millisecond: 987, kind: DateTimeKind.Local),
new DateTime(year: 2017, month: 10, day: 3, hour: 4, minute: 26, second: 16, millisecond: 638, kind: DateTimeKind.Local),
new DateTime(year: 2017, month: 10, day: 8, hour: 15, minute: 49, second: 46, millisecond: 77, kind: DateTimeKind.Local),
},
    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
{
    Id = 81,
    Value = 
new System.DateTime[4]
{
new DateTime(year: 2003, month: 10, day: 11, hour: 7, minute: 28, second: 57, millisecond: 907, kind: DateTimeKind.Local),
new DateTime(year: 1989, month: 10, day: 1, hour: 15, minute: 7, second: 8, millisecond: 428, kind: DateTimeKind.Local),
new DateTime(year: 1949, month: 10, day: 9, hour: 20, minute: 53, second: 31, millisecond: 730, kind: DateTimeKind.Local),
new DateTime(year: 1928, month: 10, day: 11, hour: 20, minute: 2, second: 44, millisecond: 463, kind: DateTimeKind.Local),
},
    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1918, month: 10, day: 7, hour: 11, minute: 8, second: 41, millisecond: 70, kind: DateTimeKind.Local),
new DateTime(year: 2015, month: 10, day: 15, hour: 15, minute: 54, second: 27, millisecond: 151, kind: DateTimeKind.Local),
new DateTime(year: 2014, month: 10, day: 1, hour: 13, minute: 15, second: 13, millisecond: 798, kind: DateTimeKind.Local),
new DateTime(year: 1986, month: 10, day: 14, hour: 5, minute: 16, second: 49, millisecond: 194, kind: DateTimeKind.Local),
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
new System.DateTime[3]
{
new DateTime(year: 1981, month: 10, day: 12, hour: 17, minute: 55, second: 55, millisecond: 874, kind: DateTimeKind.Local),
new DateTime(year: 1992, month: 10, day: 11, hour: 9, minute: 17, second: 41, millisecond: 8, kind: DateTimeKind.Local),
new DateTime(year: 1943, month: 10, day: 14, hour: 5, minute: 16, second: 13, millisecond: 985, kind: DateTimeKind.Local),
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
new System.DateTime[4]
{
new DateTime(year: 1965, month: 10, day: 12, hour: 9, minute: 31, second: 13, millisecond: 296, kind: DateTimeKind.Local),
new DateTime(year: 1925, month: 10, day: 9, hour: 10, minute: 54, second: 29, millisecond: 60, kind: DateTimeKind.Local),
new DateTime(year: 1947, month: 10, day: 17, hour: 12, minute: 8, second: 33, millisecond: 219, kind: DateTimeKind.Local),
new DateTime(year: 1936, month: 10, day: 18, hour: 19, minute: 20, second: 18, millisecond: 280, kind: DateTimeKind.Local),
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
                Assert.That(nullable, Is.Null);
                nullable = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDateTimeArraytimestamp_without_time_zoneArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
                var models = ((IDateTimeArraytimestamp_without_time_zoneArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDateTimeArraytimestamp_without_time_zoneArray)this).DynQuerySelectModel(connection,  query, 0);
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
                var models = ((IDateTimeArraytimestamp_without_time_zoneArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[10],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[8],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 161;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
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
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[29], false);
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[18],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 156;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[16],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[17],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[18],_testData[29], false);
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[19],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[4], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[5], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[6], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[7], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[8], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[9], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[10], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[11], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[12], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[13], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[14], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[15], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[16], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[17], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[18], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[19], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[16],_testData[20], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[17],_testData[21], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[18],_testData[22], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[19],_testData[23], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[20],_testData[24], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[21],_testData[25], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[22],_testData[26], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[23],_testData[27], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[24],_testData[28], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[25],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[22], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[23], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[24], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[25], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[26], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[27], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[28], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[6], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[7], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[8], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[9], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[10], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[11], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[12], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[13], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[14], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[15], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[16], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[17], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[18], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[19], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[20], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[21], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[16],_testData[22], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[17],_testData[23], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[18],_testData[24], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[19],_testData[25], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[20],_testData[26], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[21],_testData[27], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[22],_testData[28], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[23],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 8, query1, 107, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[10],_testData[29], false);
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
                await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 6, query1, 112, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                 ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 55, query1, 112, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[9],_testData[29], false);
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
                 ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 100, query1, 14, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
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
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[26],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 64, query1, 6, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[16],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[17],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[18],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[1], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[2], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[3], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[16],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[17],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[18],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[19],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[20],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[21],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[22],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[23],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[24],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[25],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[26],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[27],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[28],_testData[29], false);
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
                await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 82, query1, 46, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[21],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 107, query1, 127, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[29], false);
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
                 ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatch(connection, 76, query1, 121, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(firstItems1[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneArray1M.AssertModel(secondItems2[8],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSTSelectModelBatchAsync(connection, 73, 126))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[12], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[13], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[14], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[15], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[16], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[17], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[18], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[19], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[20], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[21], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[22], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[23], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[24], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[25], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[26], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[27], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[16],_testData[28], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[22], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[23], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[24], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[25], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[26], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[27], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[28], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSTSelectModelBatch(connection, 31, 73))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[6], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[7], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[8], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[9], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[10], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[11], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[12], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[13], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[14], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[15], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[16], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[17], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[18], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[19], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[20], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[21], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[16],_testData[22], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[17],_testData[23], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[18],_testData[24], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[19],_testData[25], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[20],_testData[26], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[21],_testData[27], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[22],_testData[28], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[12], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[13], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[14], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[15], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[16], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[17], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[18], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[19], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[20], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[21], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[22], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[23], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[24], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[25], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[26], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[27], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[16],_testData[28], false);
                        DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[17],_testData[29], false);
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
                ((IDateTimeArraytimestamp_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 29);
                var models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[5], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[6], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[7], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[8], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[4],_testData[9], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[5],_testData[10], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[6],_testData[11], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[7],_testData[12], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[8],_testData[13], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[9],_testData[14], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[10],_testData[15], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[11],_testData[16], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[12],_testData[17], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[13],_testData[18], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[14],_testData[19], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[15],_testData[20], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[16],_testData[21], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[17],_testData[22], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[18],_testData[23], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[19],_testData[24], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[20],_testData[25], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[21],_testData[26], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[22],_testData[27], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[23],_testData[28], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[24],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateTimeArraytimestamp_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 147);
                var models =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[0],_testData[26], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[1],_testData[27], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[2],_testData[28], false);DateTimetimestamp_without_time_zoneArray1M.AssertModel(models[3],_testData[29], false);
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

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerTest()
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
                ((IDateTimeArraytimestamp_without_time_zoneArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_datetimetimestamp_without_time_zonearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
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
                await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_datetimetimestamp_without_time_zonearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
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
        private void ImportModelInnerConfig()
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

