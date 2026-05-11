

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
    internal partial interface IDateTimeMArraytimestamp_without_time_zoneMMArrayD2
    {
    }
    
    internal partial class DateTimeMArraytimestamp_without_time_zoneMMArrayD2 : IDateTimeMArraytimestamp_without_time_zoneMMArrayD2
    {


#region TestData

        private readonly DateTimetimestamp_without_time_zoneMMArrayD2E1M[] _testData = new DateTimetimestamp_without_time_zoneMMArrayD2E1M[]
        {
            new DateTimetimestamp_without_time_zoneMMArrayD2E1M
{
    Id = 8,
    Value = 
new System.DateTime[,] { { new DateTime(year: 2008, month: 10, day: 4, hour: 11, minute: 46, second: 48, millisecond: 995, kind: DateTimeKind.Local), new DateTime(year: 1988, month: 10, day: 19, hour: 15, minute: 19, second: 44, millisecond: 477, kind: DateTimeKind.Local), }, { new DateTime(year: 1958, month: 10, day: 10, hour: 10, minute: 22, second: 6, millisecond: 852, kind: DateTimeKind.Local), new DateTime(year: 1997, month: 10, day: 7, hour: 8, minute: 7, second: 27, millisecond: 445, kind: DateTimeKind.Local), }, },
    ModelInner = null,
    NullableValue = 
new System.DateTime[,] { { new DateTime(year: 1957, month: 10, day: 18, hour: 14, minute: 37, second: 31, millisecond: 204, kind: DateTimeKind.Local), new DateTime(year: 1932, month: 10, day: 4, hour: 3, minute: 54, second: 48, millisecond: 535, kind: DateTimeKind.Local), }, { new DateTime(year: 1977, month: 10, day: 11, hour: 12, minute: 11, second: 1, millisecond: 164, kind: DateTimeKind.Local), new DateTime(year: 1987, month: 10, day: 14, hour: 14, minute: 39, second: 28, millisecond: 573, kind: DateTimeKind.Local), }, },
},
            new DateTimetimestamp_without_time_zoneMMArrayD2E1M
{
    Id = 9,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1957, month: 10, day: 5, hour: 10, minute: 15, second: 32, millisecond: 348, kind: DateTimeKind.Local), new DateTime(year: 1984, month: 10, day: 9, hour: 3, minute: 12, second: 28, millisecond: 338, kind: DateTimeKind.Local), }, { new DateTime(year: 1920, month: 10, day: 1, hour: 4, minute: 3, second: 44, millisecond: 702, kind: DateTimeKind.Local), new DateTime(year: 1939, month: 10, day: 15, hour: 13, minute: 30, second: 7, millisecond: 951, kind: DateTimeKind.Local), }, },
    ModelInner = new DateTimetimestamp_without_time_zoneMMArrayD2E1MI
{
    Id = 9,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1987, month: 10, day: 10, hour: 14, minute: 15, second: 56, millisecond: 223, kind: DateTimeKind.Local), new DateTime(year: 1976, month: 10, day: 14, hour: 16, minute: 28, second: 22, millisecond: 941, kind: DateTimeKind.Local), }, { new DateTime(year: 1984, month: 10, day: 3, hour: 12, minute: 18, second: 35, millisecond: 693, kind: DateTimeKind.Local), new DateTime(year: 1943, month: 10, day: 2, hour: 10, minute: 32, second: 21, millisecond: 75, kind: DateTimeKind.Local), }, },
    NullableValue = 
new System.DateTime[,] { { new DateTime(year: 2002, month: 10, day: 2, hour: 14, minute: 10, second: 23, millisecond: 314, kind: DateTimeKind.Local), new DateTime(year: 1965, month: 10, day: 18, hour: 12, minute: 58, second: 23, millisecond: 522, kind: DateTimeKind.Local), }, { new DateTime(year: 1950, month: 10, day: 19, hour: 19, minute: 13, second: 3, millisecond: 545, kind: DateTimeKind.Local), new DateTime(year: 1919, month: 10, day: 3, hour: 12, minute: 21, second: 43, millisecond: 13, kind: DateTimeKind.Local), }, },
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneMMArrayD2E1M
{
    Id = 13,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1945, month: 10, day: 11, hour: 8, minute: 58, second: 2, millisecond: 127, kind: DateTimeKind.Local), new DateTime(year: 1923, month: 10, day: 12, hour: 21, minute: 39, second: 9, millisecond: 823, kind: DateTimeKind.Local), }, { new DateTime(year: 1958, month: 10, day: 15, hour: 12, minute: 38, second: 51, millisecond: 409, kind: DateTimeKind.Local), new DateTime(year: 1931, month: 10, day: 10, hour: 13, minute: 31, second: 18, millisecond: 340, kind: DateTimeKind.Local), }, },
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneMMArrayD2E1M
{
    Id = 22,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1922, month: 10, day: 8, hour: 16, minute: 10, second: 45, millisecond: 811, kind: DateTimeKind.Local), new DateTime(year: 1932, month: 10, day: 11, hour: 18, minute: 10, second: 40, millisecond: 274, kind: DateTimeKind.Local), }, { new DateTime(year: 1942, month: 10, day: 14, hour: 20, minute: 44, second: 3, millisecond: 499, kind: DateTimeKind.Local), new DateTime(year: 1960, month: 10, day: 10, hour: 20, minute: 2, second: 49, millisecond: 271, kind: DateTimeKind.Local), }, },
    ModelInner = new DateTimetimestamp_without_time_zoneMMArrayD2E1MI
{
    Id = 18,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1920, month: 10, day: 11, hour: 1, minute: 32, second: 8, millisecond: 798, kind: DateTimeKind.Local), new DateTime(year: 1979, month: 10, day: 16, hour: 15, minute: 32, second: 18, millisecond: 895, kind: DateTimeKind.Local), }, { new DateTime(year: 2002, month: 10, day: 18, hour: 11, minute: 31, second: 34, millisecond: 780, kind: DateTimeKind.Local), new DateTime(year: 1964, month: 10, day: 11, hour: 18, minute: 52, second: 21, millisecond: 730, kind: DateTimeKind.Local), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneMMArrayD2E1M
{
    Id = 30,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1976, month: 10, day: 10, hour: 12, minute: 3, second: 21, millisecond: 26, kind: DateTimeKind.Local), new DateTime(year: 1976, month: 10, day: 16, hour: 5, minute: 27, second: 10, millisecond: 767, kind: DateTimeKind.Local), }, { new DateTime(year: 1978, month: 10, day: 6, hour: 8, minute: 14, second: 39, millisecond: 786, kind: DateTimeKind.Local), new DateTime(year: 1960, month: 10, day: 12, hour: 19, minute: 46, second: 13, millisecond: 87, kind: DateTimeKind.Local), }, },
    ModelInner = null,
    NullableValue = 
new System.DateTime[,] { { new DateTime(year: 1968, month: 10, day: 19, hour: 13, minute: 16, second: 57, millisecond: 138, kind: DateTimeKind.Local), new DateTime(year: 1935, month: 10, day: 15, hour: 14, minute: 40, second: 23, millisecond: 877, kind: DateTimeKind.Local), }, { new DateTime(year: 1932, month: 10, day: 8, hour: 8, minute: 22, second: 32, millisecond: 557, kind: DateTimeKind.Local), new DateTime(year: 1973, month: 10, day: 1, hour: 1, minute: 23, second: 7, millisecond: 540, kind: DateTimeKind.Local), }, },
},
            new DateTimetimestamp_without_time_zoneMMArrayD2E1M
{
    Id = 31,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1923, month: 10, day: 7, hour: 17, minute: 38, second: 10, millisecond: 374, kind: DateTimeKind.Local), new DateTime(year: 1996, month: 10, day: 19, hour: 2, minute: 25, second: 4, millisecond: 877, kind: DateTimeKind.Local), }, { new DateTime(year: 2016, month: 10, day: 3, hour: 2, minute: 14, second: 52, millisecond: 623, kind: DateTimeKind.Local), new DateTime(year: 1947, month: 10, day: 10, hour: 6, minute: 57, second: 19, millisecond: 828, kind: DateTimeKind.Local), }, },
    ModelInner = new DateTimetimestamp_without_time_zoneMMArrayD2E1MI
{
    Id = 19,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1952, month: 10, day: 6, hour: 6, minute: 33, second: 28, millisecond: 89, kind: DateTimeKind.Local), new DateTime(year: 1975, month: 10, day: 16, hour: 13, minute: 11, second: 3, millisecond: 129, kind: DateTimeKind.Local), }, { new DateTime(year: 1925, month: 10, day: 17, hour: 21, minute: 33, second: 15, millisecond: 962, kind: DateTimeKind.Local), new DateTime(year: 1927, month: 10, day: 2, hour: 11, minute: 12, second: 40, millisecond: 381, kind: DateTimeKind.Local), }, },
    NullableValue = 
new System.DateTime[,] { { new DateTime(year: 1977, month: 10, day: 12, hour: 12, minute: 12, second: 53, millisecond: 661, kind: DateTimeKind.Local), new DateTime(year: 2004, month: 10, day: 13, hour: 22, minute: 6, second: 9, millisecond: 984, kind: DateTimeKind.Local), }, { new DateTime(year: 1975, month: 10, day: 11, hour: 2, minute: 14, second: 34, millisecond: 491, kind: DateTimeKind.Local), new DateTime(year: 1979, month: 10, day: 17, hour: 5, minute: 44, second: 15, millisecond: 724, kind: DateTimeKind.Local), }, },
},
    NullableValue = 
new System.DateTime[,] { { new DateTime(year: 2018, month: 10, day: 2, hour: 19, minute: 37, second: 53, millisecond: 642, kind: DateTimeKind.Local), new DateTime(year: 1948, month: 10, day: 10, hour: 10, minute: 11, second: 33, millisecond: 717, kind: DateTimeKind.Local), }, { new DateTime(year: 1988, month: 10, day: 18, hour: 8, minute: 7, second: 31, millisecond: 878, kind: DateTimeKind.Local), new DateTime(year: 2008, month: 10, day: 19, hour: 3, minute: 42, second: 8, millisecond: 363, kind: DateTimeKind.Local), }, },
},
            new DateTimetimestamp_without_time_zoneMMArrayD2E1M
{
    Id = 38,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1932, month: 10, day: 14, hour: 13, minute: 54, second: 51, millisecond: 963, kind: DateTimeKind.Local), new DateTime(year: 1952, month: 10, day: 16, hour: 1, minute: 45, second: 28, millisecond: 111, kind: DateTimeKind.Local), }, { new DateTime(year: 1924, month: 10, day: 8, hour: 19, minute: 39, second: 1, millisecond: 527, kind: DateTimeKind.Local), new DateTime(year: 1986, month: 10, day: 8, hour: 22, minute: 49, second: 28, millisecond: 463, kind: DateTimeKind.Local), }, },
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneMMArrayD2E1M
{
    Id = 40,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1982, month: 10, day: 2, hour: 8, minute: 19, second: 2, millisecond: 403, kind: DateTimeKind.Local), new DateTime(year: 1974, month: 10, day: 14, hour: 11, minute: 51, second: 42, millisecond: 105, kind: DateTimeKind.Local), }, { new DateTime(year: 1941, month: 10, day: 8, hour: 10, minute: 43, second: 47, millisecond: 895, kind: DateTimeKind.Local), new DateTime(year: 2002, month: 10, day: 4, hour: 8, minute: 55, second: 44, millisecond: 124, kind: DateTimeKind.Local), }, },
    ModelInner = new DateTimetimestamp_without_time_zoneMMArrayD2E1MI
{
    Id = 21,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1937, month: 10, day: 7, hour: 12, minute: 46, second: 14, millisecond: 557, kind: DateTimeKind.Local), new DateTime(year: 1953, month: 10, day: 18, hour: 11, minute: 45, second: 18, millisecond: 412, kind: DateTimeKind.Local), }, { new DateTime(year: 1960, month: 10, day: 15, hour: 11, minute: 32, second: 52, millisecond: 615, kind: DateTimeKind.Local), new DateTime(year: 1924, month: 10, day: 11, hour: 2, minute: 29, second: 35, millisecond: 112, kind: DateTimeKind.Local), }, },
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[,] { { new DateTime(year: 1918, month: 10, day: 15, hour: 17, minute: 3, second: 28, millisecond: 465, kind: DateTimeKind.Local), new DateTime(year: 1968, month: 10, day: 10, hour: 15, minute: 25, second: 31, millisecond: 583, kind: DateTimeKind.Local), }, { new DateTime(year: 1984, month: 10, day: 9, hour: 18, minute: 18, second: 24, millisecond: 621, kind: DateTimeKind.Local), new DateTime(year: 1962, month: 10, day: 4, hour: 10, minute: 9, second: 45, millisecond: 888, kind: DateTimeKind.Local), }, },
},
            new DateTimetimestamp_without_time_zoneMMArrayD2E1M
{
    Id = 49,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1945, month: 10, day: 18, hour: 4, minute: 54, second: 50, millisecond: 76, kind: DateTimeKind.Local), new DateTime(year: 1932, month: 10, day: 12, hour: 7, minute: 50, second: 21, millisecond: 167, kind: DateTimeKind.Local), }, { new DateTime(year: 1924, month: 10, day: 17, hour: 11, minute: 58, second: 22, millisecond: 654, kind: DateTimeKind.Local), new DateTime(year: 1935, month: 10, day: 9, hour: 11, minute: 6, second: 58, millisecond: 309, kind: DateTimeKind.Local), }, },
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneMMArrayD2E1M
{
    Id = 52,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1985, month: 10, day: 13, hour: 15, minute: 54, second: 52, millisecond: 696, kind: DateTimeKind.Local), new DateTime(year: 1928, month: 10, day: 8, hour: 10, minute: 53, second: 2, millisecond: 943, kind: DateTimeKind.Local), }, { new DateTime(year: 1925, month: 10, day: 10, hour: 4, minute: 42, second: 24, millisecond: 408, kind: DateTimeKind.Local), new DateTime(year: 1964, month: 10, day: 6, hour: 22, minute: 44, second: 3, millisecond: 386, kind: DateTimeKind.Local), }, },
    ModelInner = new DateTimetimestamp_without_time_zoneMMArrayD2E1MI
{
    Id = 27,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1937, month: 10, day: 10, hour: 22, minute: 13, second: 46, millisecond: 67, kind: DateTimeKind.Local), new DateTime(year: 1921, month: 10, day: 17, hour: 4, minute: 3, second: 37, millisecond: 909, kind: DateTimeKind.Local), }, { new DateTime(year: 1939, month: 10, day: 16, hour: 1, minute: 50, second: 40, millisecond: 291, kind: DateTimeKind.Local), new DateTime(year: 1956, month: 10, day: 16, hour: 19, minute: 35, second: 21, millisecond: 275, kind: DateTimeKind.Local), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneMMArrayD2E1M
{
    Id = 54,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1934, month: 10, day: 7, hour: 18, minute: 5, second: 41, millisecond: 465, kind: DateTimeKind.Local), new DateTime(year: 1959, month: 10, day: 5, hour: 19, minute: 7, second: 4, millisecond: 300, kind: DateTimeKind.Local), }, { new DateTime(year: 1951, month: 10, day: 17, hour: 6, minute: 48, second: 57, millisecond: 500, kind: DateTimeKind.Local), new DateTime(year: 1971, month: 10, day: 1, hour: 22, minute: 21, second: 40, millisecond: 690, kind: DateTimeKind.Local), }, },
    ModelInner = null,
    NullableValue = 
new System.DateTime[,] { { new DateTime(year: 1995, month: 10, day: 15, hour: 19, minute: 36, second: 34, millisecond: 956, kind: DateTimeKind.Local), new DateTime(year: 1948, month: 10, day: 12, hour: 10, minute: 14, second: 40, millisecond: 920, kind: DateTimeKind.Local), }, { new DateTime(year: 1954, month: 10, day: 11, hour: 6, minute: 22, second: 43, millisecond: 782, kind: DateTimeKind.Local), new DateTime(year: 2009, month: 10, day: 2, hour: 22, minute: 4, second: 28, millisecond: 52, kind: DateTimeKind.Local), }, },
},
            new DateTimetimestamp_without_time_zoneMMArrayD2E1M
{
    Id = 56,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1953, month: 10, day: 16, hour: 16, minute: 44, second: 38, millisecond: 869, kind: DateTimeKind.Local), new DateTime(year: 2017, month: 10, day: 19, hour: 7, minute: 37, second: 48, millisecond: 159, kind: DateTimeKind.Local), }, { new DateTime(year: 1917, month: 10, day: 5, hour: 6, minute: 20, second: 39, millisecond: 352, kind: DateTimeKind.Local), new DateTime(year: 1990, month: 10, day: 17, hour: 12, minute: 54, second: 7, millisecond: 211, kind: DateTimeKind.Local), }, },
    ModelInner = new DateTimetimestamp_without_time_zoneMMArrayD2E1MI
{
    Id = 35,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1960, month: 10, day: 1, hour: 8, minute: 25, second: 13, millisecond: 583, kind: DateTimeKind.Local), new DateTime(year: 2005, month: 10, day: 11, hour: 7, minute: 57, second: 26, millisecond: 274, kind: DateTimeKind.Local), }, { new DateTime(year: 2019, month: 10, day: 17, hour: 19, minute: 58, second: 49, millisecond: 110, kind: DateTimeKind.Local), new DateTime(year: 1940, month: 10, day: 7, hour: 11, minute: 57, second: 21, millisecond: 434, kind: DateTimeKind.Local), }, },
    NullableValue = 
new System.DateTime[,] { { new DateTime(year: 1978, month: 10, day: 17, hour: 6, minute: 17, second: 57, millisecond: 307, kind: DateTimeKind.Local), new DateTime(year: 1965, month: 10, day: 8, hour: 13, minute: 31, second: 33, millisecond: 242, kind: DateTimeKind.Local), }, { new DateTime(year: 1970, month: 10, day: 9, hour: 6, minute: 27, second: 55, millisecond: 409, kind: DateTimeKind.Local), new DateTime(year: 2015, month: 10, day: 6, hour: 4, minute: 33, second: 26, millisecond: 697, kind: DateTimeKind.Local), }, },
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneMMArrayD2E1M
{
    Id = 57,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1967, month: 10, day: 17, hour: 21, minute: 49, second: 2, millisecond: 967, kind: DateTimeKind.Local), new DateTime(year: 1956, month: 10, day: 1, hour: 4, minute: 18, second: 49, millisecond: 875, kind: DateTimeKind.Local), }, { new DateTime(year: 1952, month: 10, day: 3, hour: 5, minute: 38, second: 39, millisecond: 743, kind: DateTimeKind.Local), new DateTime(year: 1990, month: 10, day: 4, hour: 9, minute: 31, second: 57, millisecond: 417, kind: DateTimeKind.Local), }, },
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneMMArrayD2E1M
{
    Id = 62,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1963, month: 10, day: 2, hour: 3, minute: 15, second: 45, millisecond: 435, kind: DateTimeKind.Local), new DateTime(year: 1953, month: 10, day: 12, hour: 21, minute: 16, second: 47, millisecond: 493, kind: DateTimeKind.Local), }, { new DateTime(year: 1927, month: 10, day: 19, hour: 7, minute: 44, second: 51, millisecond: 174, kind: DateTimeKind.Local), new DateTime(year: 1945, month: 10, day: 14, hour: 15, minute: 9, second: 35, millisecond: 214, kind: DateTimeKind.Local), }, },
    ModelInner = new DateTimetimestamp_without_time_zoneMMArrayD2E1MI
{
    Id = 37,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1941, month: 10, day: 17, hour: 9, minute: 36, second: 24, millisecond: 648, kind: DateTimeKind.Local), new DateTime(year: 2008, month: 10, day: 18, hour: 20, minute: 11, second: 9, millisecond: 82, kind: DateTimeKind.Local), }, { new DateTime(year: 2005, month: 10, day: 7, hour: 20, minute: 20, second: 11, millisecond: 919, kind: DateTimeKind.Local), new DateTime(year: 1982, month: 10, day: 14, hour: 8, minute: 19, second: 58, millisecond: 710, kind: DateTimeKind.Local), }, },
    NullableValue = 
new System.DateTime[,] { { new DateTime(year: 1983, month: 10, day: 12, hour: 19, minute: 7, second: 44, millisecond: 441, kind: DateTimeKind.Local), new DateTime(year: 1962, month: 10, day: 15, hour: 13, minute: 6, second: 31, millisecond: 391, kind: DateTimeKind.Local), }, { new DateTime(year: 1930, month: 10, day: 15, hour: 4, minute: 18, second: 31, millisecond: 309, kind: DateTimeKind.Local), new DateTime(year: 1928, month: 10, day: 9, hour: 11, minute: 17, second: 49, millisecond: 821, kind: DateTimeKind.Local), }, },
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneMMArrayD2E1M
{
    Id = 69,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1962, month: 10, day: 1, hour: 4, minute: 3, second: 17, millisecond: 204, kind: DateTimeKind.Local), new DateTime(year: 2000, month: 10, day: 18, hour: 8, minute: 38, second: 49, millisecond: 17, kind: DateTimeKind.Local), }, { new DateTime(year: 1942, month: 10, day: 6, hour: 4, minute: 7, second: 55, millisecond: 769, kind: DateTimeKind.Local), new DateTime(year: 2016, month: 10, day: 19, hour: 11, minute: 7, second: 38, millisecond: 410, kind: DateTimeKind.Local), }, },
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneMMArrayD2E1M
{
    Id = 76,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1940, month: 10, day: 16, hour: 2, minute: 10, second: 30, millisecond: 904, kind: DateTimeKind.Local), new DateTime(year: 2007, month: 10, day: 7, hour: 7, minute: 47, second: 45, millisecond: 135, kind: DateTimeKind.Local), }, { new DateTime(year: 1941, month: 10, day: 1, hour: 14, minute: 9, second: 19, millisecond: 814, kind: DateTimeKind.Local), new DateTime(year: 1950, month: 10, day: 12, hour: 11, minute: 45, second: 45, millisecond: 167, kind: DateTimeKind.Local), }, },
    ModelInner = new DateTimetimestamp_without_time_zoneMMArrayD2E1MI
{
    Id = 45,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1980, month: 10, day: 13, hour: 3, minute: 4, second: 53, millisecond: 964, kind: DateTimeKind.Local), new DateTime(year: 1956, month: 10, day: 18, hour: 9, minute: 17, second: 48, millisecond: 634, kind: DateTimeKind.Local), }, { new DateTime(year: 1922, month: 10, day: 3, hour: 9, minute: 18, second: 52, millisecond: 817, kind: DateTimeKind.Local), new DateTime(year: 1954, month: 10, day: 14, hour: 16, minute: 54, second: 10, millisecond: 741, kind: DateTimeKind.Local), }, },
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[,] { { new DateTime(year: 1940, month: 10, day: 5, hour: 15, minute: 57, second: 32, millisecond: 408, kind: DateTimeKind.Local), new DateTime(year: 1956, month: 10, day: 18, hour: 16, minute: 17, second: 48, millisecond: 593, kind: DateTimeKind.Local), }, { new DateTime(year: 1992, month: 10, day: 5, hour: 21, minute: 17, second: 8, millisecond: 538, kind: DateTimeKind.Local), new DateTime(year: 2001, month: 10, day: 2, hour: 10, minute: 10, second: 11, millisecond: 283, kind: DateTimeKind.Local), }, },
},
            new DateTimetimestamp_without_time_zoneMMArrayD2E1M
{
    Id = 83,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1990, month: 10, day: 11, hour: 19, minute: 29, second: 30, millisecond: 477, kind: DateTimeKind.Local), new DateTime(year: 1932, month: 10, day: 6, hour: 7, minute: 23, second: 46, millisecond: 914, kind: DateTimeKind.Local), }, { new DateTime(year: 1951, month: 10, day: 19, hour: 13, minute: 20, second: 53, millisecond: 34, kind: DateTimeKind.Local), new DateTime(year: 2015, month: 10, day: 3, hour: 7, minute: 29, second: 20, millisecond: 314, kind: DateTimeKind.Local), }, },
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneMMArrayD2E1M
{
    Id = 91,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1940, month: 10, day: 2, hour: 19, minute: 42, second: 21, millisecond: 268, kind: DateTimeKind.Local), new DateTime(year: 1927, month: 10, day: 14, hour: 19, minute: 9, second: 42, millisecond: 687, kind: DateTimeKind.Local), }, { new DateTime(year: 1920, month: 10, day: 9, hour: 14, minute: 50, second: 19, millisecond: 776, kind: DateTimeKind.Local), new DateTime(year: 2000, month: 10, day: 1, hour: 11, minute: 48, second: 40, millisecond: 524, kind: DateTimeKind.Local), }, },
    ModelInner = new DateTimetimestamp_without_time_zoneMMArrayD2E1MI
{
    Id = 49,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1966, month: 10, day: 7, hour: 8, minute: 28, second: 20, millisecond: 804, kind: DateTimeKind.Local), new DateTime(year: 1976, month: 10, day: 8, hour: 1, minute: 19, second: 37, millisecond: 476, kind: DateTimeKind.Local), }, { new DateTime(year: 1980, month: 10, day: 18, hour: 13, minute: 21, second: 7, millisecond: 602, kind: DateTimeKind.Local), new DateTime(year: 2000, month: 10, day: 3, hour: 4, minute: 23, second: 15, millisecond: 934, kind: DateTimeKind.Local), }, },
    NullableValue = 
new System.DateTime[,] { { new DateTime(year: 1992, month: 10, day: 18, hour: 2, minute: 45, second: 8, millisecond: 328, kind: DateTimeKind.Local), new DateTime(year: 1973, month: 10, day: 8, hour: 18, minute: 28, second: 47, millisecond: 13, kind: DateTimeKind.Local), }, { new DateTime(year: 1966, month: 10, day: 2, hour: 22, minute: 13, second: 48, millisecond: 322, kind: DateTimeKind.Local), new DateTime(year: 1969, month: 10, day: 17, hour: 21, minute: 31, second: 50, millisecond: 844, kind: DateTimeKind.Local), }, },
},
    NullableValue = 
new System.DateTime[,] { { new DateTime(year: 1973, month: 10, day: 14, hour: 16, minute: 16, second: 42, millisecond: 908, kind: DateTimeKind.Local), new DateTime(year: 1949, month: 10, day: 14, hour: 8, minute: 37, second: 19, millisecond: 811, kind: DateTimeKind.Local), }, { new DateTime(year: 1930, month: 10, day: 10, hour: 12, minute: 4, second: 41, millisecond: 142, kind: DateTimeKind.Local), new DateTime(year: 1946, month: 10, day: 19, hour: 3, minute: 9, second: 45, millisecond: 944, kind: DateTimeKind.Local), }, },
},
            new DateTimetimestamp_without_time_zoneMMArrayD2E1M
{
    Id = 98,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1926, month: 10, day: 3, hour: 9, minute: 25, second: 37, millisecond: 68, kind: DateTimeKind.Local), new DateTime(year: 1961, month: 10, day: 10, hour: 19, minute: 36, second: 57, millisecond: 551, kind: DateTimeKind.Local), }, { new DateTime(year: 1989, month: 10, day: 15, hour: 5, minute: 17, second: 28, millisecond: 152, kind: DateTimeKind.Local), new DateTime(year: 2015, month: 10, day: 18, hour: 18, minute: 13, second: 56, millisecond: 466, kind: DateTimeKind.Local), }, },
    ModelInner = null,
    NullableValue = 
new System.DateTime[,] { { new DateTime(year: 2002, month: 10, day: 5, hour: 10, minute: 52, second: 52, millisecond: 485, kind: DateTimeKind.Local), new DateTime(year: 1940, month: 10, day: 6, hour: 13, minute: 43, second: 58, millisecond: 848, kind: DateTimeKind.Local), }, { new DateTime(year: 1984, month: 10, day: 4, hour: 13, minute: 6, second: 38, millisecond: 977, kind: DateTimeKind.Local), new DateTime(year: 1986, month: 10, day: 8, hour: 7, minute: 12, second: 46, millisecond: 195, kind: DateTimeKind.Local), }, },
},
            new DateTimetimestamp_without_time_zoneMMArrayD2E1M
{
    Id = 102,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1991, month: 10, day: 2, hour: 19, minute: 4, second: 44, millisecond: 356, kind: DateTimeKind.Local), new DateTime(year: 1976, month: 10, day: 18, hour: 18, minute: 24, second: 50, millisecond: 161, kind: DateTimeKind.Local), }, { new DateTime(year: 1970, month: 10, day: 10, hour: 9, minute: 5, second: 36, millisecond: 891, kind: DateTimeKind.Local), new DateTime(year: 2000, month: 10, day: 4, hour: 21, minute: 12, second: 29, millisecond: 470, kind: DateTimeKind.Local), }, },
    ModelInner = new DateTimetimestamp_without_time_zoneMMArrayD2E1MI
{
    Id = 56,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1969, month: 10, day: 13, hour: 13, minute: 8, second: 33, millisecond: 997, kind: DateTimeKind.Local), new DateTime(year: 1920, month: 10, day: 11, hour: 12, minute: 46, second: 36, millisecond: 772, kind: DateTimeKind.Local), }, { new DateTime(year: 1935, month: 10, day: 14, hour: 8, minute: 56, second: 23, millisecond: 745, kind: DateTimeKind.Local), new DateTime(year: 2016, month: 10, day: 7, hour: 2, minute: 26, second: 44, millisecond: 904, kind: DateTimeKind.Local), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneMMArrayD2E1M
{
    Id = 107,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1973, month: 10, day: 16, hour: 16, minute: 52, second: 21, millisecond: 104, kind: DateTimeKind.Local), new DateTime(year: 1934, month: 10, day: 19, hour: 22, minute: 20, second: 6, millisecond: 40, kind: DateTimeKind.Local), }, { new DateTime(year: 1969, month: 10, day: 10, hour: 15, minute: 56, second: 7, millisecond: 542, kind: DateTimeKind.Local), new DateTime(year: 1928, month: 10, day: 11, hour: 9, minute: 4, second: 23, millisecond: 476, kind: DateTimeKind.Local), }, },
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneMMArrayD2E1M
{
    Id = 116,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1958, month: 10, day: 3, hour: 4, minute: 43, second: 10, millisecond: 467, kind: DateTimeKind.Local), new DateTime(year: 1930, month: 10, day: 18, hour: 18, minute: 20, second: 9, millisecond: 902, kind: DateTimeKind.Local), }, { new DateTime(year: 1922, month: 10, day: 2, hour: 14, minute: 26, second: 51, millisecond: 294, kind: DateTimeKind.Local), new DateTime(year: 1947, month: 10, day: 19, hour: 6, minute: 38, second: 58, millisecond: 348, kind: DateTimeKind.Local), }, },
    ModelInner = new DateTimetimestamp_without_time_zoneMMArrayD2E1MI
{
    Id = 64,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1965, month: 10, day: 10, hour: 16, minute: 22, second: 17, millisecond: 109, kind: DateTimeKind.Local), new DateTime(year: 1947, month: 10, day: 3, hour: 1, minute: 53, second: 21, millisecond: 894, kind: DateTimeKind.Local), }, { new DateTime(year: 1938, month: 10, day: 7, hour: 9, minute: 12, second: 4, millisecond: 609, kind: DateTimeKind.Local), new DateTime(year: 1997, month: 10, day: 13, hour: 2, minute: 5, second: 10, millisecond: 189, kind: DateTimeKind.Local), }, },
    NullableValue = 
new System.DateTime[,] { { new DateTime(year: 1926, month: 10, day: 18, hour: 8, minute: 32, second: 14, millisecond: 186, kind: DateTimeKind.Local), new DateTime(year: 1989, month: 10, day: 3, hour: 14, minute: 15, second: 45, millisecond: 566, kind: DateTimeKind.Local), }, { new DateTime(year: 1936, month: 10, day: 3, hour: 16, minute: 28, second: 8, millisecond: 340, kind: DateTimeKind.Local), new DateTime(year: 1962, month: 10, day: 16, hour: 18, minute: 14, second: 29, millisecond: 997, kind: DateTimeKind.Local), }, },
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneMMArrayD2E1M
{
    Id = 121,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1997, month: 10, day: 9, hour: 6, minute: 53, second: 32, millisecond: 641, kind: DateTimeKind.Local), new DateTime(year: 1973, month: 10, day: 11, hour: 5, minute: 54, second: 21, millisecond: 313, kind: DateTimeKind.Local), }, { new DateTime(year: 1998, month: 10, day: 8, hour: 2, minute: 13, second: 23, millisecond: 828, kind: DateTimeKind.Local), new DateTime(year: 2005, month: 10, day: 8, hour: 1, minute: 57, second: 10, millisecond: 452, kind: DateTimeKind.Local), }, },
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneMMArrayD2E1M
{
    Id = 129,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1974, month: 10, day: 13, hour: 21, minute: 13, second: 42, millisecond: 581, kind: DateTimeKind.Local), new DateTime(year: 2003, month: 10, day: 15, hour: 14, minute: 48, second: 2, millisecond: 511, kind: DateTimeKind.Local), }, { new DateTime(year: 2005, month: 10, day: 16, hour: 3, minute: 35, second: 2, millisecond: 536, kind: DateTimeKind.Local), new DateTime(year: 2007, month: 10, day: 1, hour: 10, minute: 9, second: 4, millisecond: 645, kind: DateTimeKind.Local), }, },
    ModelInner = new DateTimetimestamp_without_time_zoneMMArrayD2E1MI
{
    Id = 68,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1967, month: 10, day: 15, hour: 2, minute: 10, second: 23, millisecond: 15, kind: DateTimeKind.Local), new DateTime(year: 1980, month: 10, day: 1, hour: 12, minute: 20, second: 35, millisecond: 646, kind: DateTimeKind.Local), }, { new DateTime(year: 1967, month: 10, day: 16, hour: 16, minute: 29, second: 32, millisecond: 939, kind: DateTimeKind.Local), new DateTime(year: 2009, month: 10, day: 5, hour: 2, minute: 37, second: 54, millisecond: 798, kind: DateTimeKind.Local), }, },
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[,] { { new DateTime(year: 1946, month: 10, day: 14, hour: 5, minute: 14, second: 30, millisecond: 193, kind: DateTimeKind.Local), new DateTime(year: 1962, month: 10, day: 15, hour: 20, minute: 45, second: 44, millisecond: 465, kind: DateTimeKind.Local), }, { new DateTime(year: 1993, month: 10, day: 7, hour: 5, minute: 15, second: 45, millisecond: 934, kind: DateTimeKind.Local), new DateTime(year: 2013, month: 10, day: 10, hour: 15, minute: 52, second: 40, millisecond: 225, kind: DateTimeKind.Local), }, },
},
            new DateTimetimestamp_without_time_zoneMMArrayD2E1M
{
    Id = 138,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1991, month: 10, day: 9, hour: 17, minute: 19, second: 44, millisecond: 687, kind: DateTimeKind.Local), new DateTime(year: 1988, month: 10, day: 13, hour: 11, minute: 10, second: 4, millisecond: 30, kind: DateTimeKind.Local), }, { new DateTime(year: 1938, month: 10, day: 12, hour: 9, minute: 13, second: 40, millisecond: 250, kind: DateTimeKind.Local), new DateTime(year: 2014, month: 10, day: 2, hour: 8, minute: 2, second: 51, millisecond: 394, kind: DateTimeKind.Local), }, },
    ModelInner = null,
    NullableValue = 
new System.DateTime[,] { { new DateTime(year: 1996, month: 10, day: 2, hour: 15, minute: 17, second: 53, millisecond: 182, kind: DateTimeKind.Local), new DateTime(year: 1988, month: 10, day: 17, hour: 11, minute: 46, second: 19, millisecond: 233, kind: DateTimeKind.Local), }, { new DateTime(year: 1939, month: 10, day: 3, hour: 15, minute: 41, second: 2, millisecond: 466, kind: DateTimeKind.Local), new DateTime(year: 1973, month: 10, day: 18, hour: 8, minute: 34, second: 13, millisecond: 318, kind: DateTimeKind.Local), }, },
},
            new DateTimetimestamp_without_time_zoneMMArrayD2E1M
{
    Id = 144,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1961, month: 10, day: 3, hour: 6, minute: 27, second: 12, millisecond: 637, kind: DateTimeKind.Local), new DateTime(year: 1972, month: 10, day: 6, hour: 5, minute: 34, second: 34, millisecond: 972, kind: DateTimeKind.Local), }, { new DateTime(year: 2004, month: 10, day: 15, hour: 12, minute: 34, second: 1, millisecond: 586, kind: DateTimeKind.Local), new DateTime(year: 2003, month: 10, day: 8, hour: 18, minute: 26, second: 5, millisecond: 301, kind: DateTimeKind.Local), }, },
    ModelInner = new DateTimetimestamp_without_time_zoneMMArrayD2E1MI
{
    Id = 73,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1967, month: 10, day: 11, hour: 22, minute: 9, second: 20, millisecond: 84, kind: DateTimeKind.Local), new DateTime(year: 1994, month: 10, day: 5, hour: 13, minute: 57, second: 44, millisecond: 274, kind: DateTimeKind.Local), }, { new DateTime(year: 1938, month: 10, day: 3, hour: 21, minute: 2, second: 10, millisecond: 228, kind: DateTimeKind.Local), new DateTime(year: 1968, month: 10, day: 19, hour: 12, minute: 29, second: 33, millisecond: 908, kind: DateTimeKind.Local), }, },
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[,] { { new DateTime(year: 1942, month: 10, day: 5, hour: 21, minute: 25, second: 4, millisecond: 133, kind: DateTimeKind.Local), new DateTime(year: 1959, month: 10, day: 15, hour: 15, minute: 53, second: 36, millisecond: 459, kind: DateTimeKind.Local), }, { new DateTime(year: 2012, month: 10, day: 14, hour: 12, minute: 30, second: 11, millisecond: 878, kind: DateTimeKind.Local), new DateTime(year: 2009, month: 10, day: 6, hour: 22, minute: 43, second: 38, millisecond: 924, kind: DateTimeKind.Local), }, },
},
            new DateTimetimestamp_without_time_zoneMMArrayD2E1M
{
    Id = 149,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1949, month: 10, day: 10, hour: 16, minute: 31, second: 50, millisecond: 952, kind: DateTimeKind.Local), new DateTime(year: 1965, month: 10, day: 15, hour: 18, minute: 55, second: 16, millisecond: 565, kind: DateTimeKind.Local), }, { new DateTime(year: 2013, month: 10, day: 17, hour: 13, minute: 2, second: 1, millisecond: 139, kind: DateTimeKind.Local), new DateTime(year: 1938, month: 10, day: 19, hour: 11, minute: 20, second: 16, millisecond: 876, kind: DateTimeKind.Local), }, },
    ModelInner = null,
    NullableValue = 
new System.DateTime[,] { { new DateTime(year: 1955, month: 10, day: 4, hour: 8, minute: 27, second: 19, millisecond: 628, kind: DateTimeKind.Local), new DateTime(year: 1993, month: 10, day: 19, hour: 12, minute: 47, second: 38, millisecond: 910, kind: DateTimeKind.Local), }, { new DateTime(year: 1962, month: 10, day: 19, hour: 2, minute: 46, second: 9, millisecond: 523, kind: DateTimeKind.Local), new DateTime(year: 1935, month: 10, day: 11, hour: 15, minute: 54, second: 46, millisecond: 922, kind: DateTimeKind.Local), }, },
},
            new DateTimetimestamp_without_time_zoneMMArrayD2E1M
{
    Id = 157,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1985, month: 10, day: 18, hour: 14, minute: 41, second: 40, millisecond: 262, kind: DateTimeKind.Local), new DateTime(year: 1971, month: 10, day: 8, hour: 11, minute: 46, second: 29, millisecond: 549, kind: DateTimeKind.Local), }, { new DateTime(year: 2019, month: 10, day: 8, hour: 10, minute: 45, second: 45, millisecond: 327, kind: DateTimeKind.Local), new DateTime(year: 1922, month: 10, day: 19, hour: 5, minute: 29, second: 30, millisecond: 244, kind: DateTimeKind.Local), }, },
    ModelInner = new DateTimetimestamp_without_time_zoneMMArrayD2E1MI
{
    Id = 81,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1977, month: 10, day: 12, hour: 10, minute: 5, second: 24, millisecond: 749, kind: DateTimeKind.Local), new DateTime(year: 1935, month: 10, day: 18, hour: 19, minute: 19, second: 53, millisecond: 355, kind: DateTimeKind.Local), }, { new DateTime(year: 1973, month: 10, day: 1, hour: 17, minute: 36, second: 8, millisecond: 123, kind: DateTimeKind.Local), new DateTime(year: 1936, month: 10, day: 14, hour: 18, minute: 9, second: 23, millisecond: 820, kind: DateTimeKind.Local), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneMMArrayD2E1M
{
    Id = 166,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1965, month: 10, day: 4, hour: 12, minute: 7, second: 19, millisecond: 529, kind: DateTimeKind.Local), new DateTime(year: 2003, month: 10, day: 9, hour: 11, minute: 42, second: 17, millisecond: 763, kind: DateTimeKind.Local), }, { new DateTime(year: 1919, month: 10, day: 8, hour: 16, minute: 33, second: 4, millisecond: 391, kind: DateTimeKind.Local), new DateTime(year: 1948, month: 10, day: 11, hour: 9, minute: 12, second: 46, millisecond: 185, kind: DateTimeKind.Local), }, },
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneMMArrayD2E1M
{
    Id = 173,
    Value = 
new System.DateTime[,] { { new DateTime(year: 2019, month: 10, day: 7, hour: 21, minute: 21, second: 5, millisecond: 964, kind: DateTimeKind.Local), new DateTime(year: 1965, month: 10, day: 8, hour: 10, minute: 23, second: 56, millisecond: 113, kind: DateTimeKind.Local), }, { new DateTime(year: 1981, month: 10, day: 17, hour: 2, minute: 48, second: 32, millisecond: 277, kind: DateTimeKind.Local), new DateTime(year: 1940, month: 10, day: 6, hour: 16, minute: 51, second: 25, millisecond: 89, kind: DateTimeKind.Local), }, },
    ModelInner = new DateTimetimestamp_without_time_zoneMMArrayD2E1MI
{
    Id = 88,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1992, month: 10, day: 4, hour: 9, minute: 15, second: 35, millisecond: 738, kind: DateTimeKind.Local), new DateTime(year: 1944, month: 10, day: 3, hour: 21, minute: 45, second: 35, millisecond: 913, kind: DateTimeKind.Local), }, { new DateTime(year: 2001, month: 10, day: 12, hour: 7, minute: 14, second: 10, millisecond: 663, kind: DateTimeKind.Local), new DateTime(year: 1934, month: 10, day: 10, hour: 12, minute: 8, second: 6, millisecond: 49, kind: DateTimeKind.Local), }, },
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[,] { { new DateTime(year: 1923, month: 10, day: 1, hour: 14, minute: 28, second: 43, millisecond: 682, kind: DateTimeKind.Local), new DateTime(year: 1942, month: 10, day: 14, hour: 21, minute: 27, second: 55, millisecond: 472, kind: DateTimeKind.Local), }, { new DateTime(year: 1984, month: 10, day: 12, hour: 21, minute: 55, second: 10, millisecond: 959, kind: DateTimeKind.Local), new DateTime(year: 2006, month: 10, day: 3, hour: 4, minute: 51, second: 16, millisecond: 646, kind: DateTimeKind.Local), }, },
},
            new DateTimetimestamp_without_time_zoneMMArrayD2E1M
{
    Id = 177,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1919, month: 10, day: 12, hour: 11, minute: 6, second: 45, millisecond: 272, kind: DateTimeKind.Local), new DateTime(year: 1918, month: 10, day: 18, hour: 8, minute: 45, second: 11, millisecond: 261, kind: DateTimeKind.Local), }, { new DateTime(year: 1926, month: 10, day: 4, hour: 2, minute: 3, second: 42, millisecond: 621, kind: DateTimeKind.Local), new DateTime(year: 1983, month: 10, day: 13, hour: 6, minute: 12, second: 22, millisecond: 57, kind: DateTimeKind.Local), }, },
    ModelInner = null,
    NullableValue = 
new System.DateTime[,] { { new DateTime(year: 1937, month: 10, day: 13, hour: 10, minute: 37, second: 28, millisecond: 596, kind: DateTimeKind.Local), new DateTime(year: 1967, month: 10, day: 18, hour: 14, minute: 12, second: 31, millisecond: 234, kind: DateTimeKind.Local), }, { new DateTime(year: 1998, month: 10, day: 14, hour: 12, minute: 17, second: 38, millisecond: 556, kind: DateTimeKind.Local), new DateTime(year: 1919, month: 10, day: 3, hour: 5, minute: 28, second: 2, millisecond: 241, kind: DateTimeKind.Local), }, },
},
            new DateTimetimestamp_without_time_zoneMMArrayD2E1M
{
    Id = 179,
    Value = 
new System.DateTime[,] { { new DateTime(year: 2003, month: 10, day: 2, hour: 17, minute: 20, second: 53, millisecond: 633, kind: DateTimeKind.Local), new DateTime(year: 1934, month: 10, day: 9, hour: 14, minute: 12, second: 8, millisecond: 794, kind: DateTimeKind.Local), }, { new DateTime(year: 1979, month: 10, day: 10, hour: 19, minute: 22, second: 48, millisecond: 551, kind: DateTimeKind.Local), new DateTime(year: 1944, month: 10, day: 5, hour: 13, minute: 21, second: 48, millisecond: 346, kind: DateTimeKind.Local), }, },
    ModelInner = new DateTimetimestamp_without_time_zoneMMArrayD2E1MI
{
    Id = 93,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1966, month: 10, day: 15, hour: 14, minute: 51, second: 15, millisecond: 854, kind: DateTimeKind.Local), new DateTime(year: 1919, month: 10, day: 3, hour: 3, minute: 27, second: 53, millisecond: 172, kind: DateTimeKind.Local), }, { new DateTime(year: 1930, month: 10, day: 19, hour: 20, minute: 30, second: 12, millisecond: 12, kind: DateTimeKind.Local), new DateTime(year: 1981, month: 10, day: 1, hour: 12, minute: 51, second: 7, millisecond: 570, kind: DateTimeKind.Local), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneMMArrayD2E1M
{
    Id = 180,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1945, month: 10, day: 2, hour: 8, minute: 53, second: 36, millisecond: 89, kind: DateTimeKind.Local), new DateTime(year: 1953, month: 10, day: 15, hour: 7, minute: 57, second: 58, millisecond: 35, kind: DateTimeKind.Local), }, { new DateTime(year: 1926, month: 10, day: 17, hour: 10, minute: 18, second: 40, millisecond: 862, kind: DateTimeKind.Local), new DateTime(year: 1948, month: 10, day: 13, hour: 3, minute: 47, second: 3, millisecond: 321, kind: DateTimeKind.Local), }, },
    ModelInner = null,
    NullableValue = 
new System.DateTime[,] { { new DateTime(year: 1962, month: 10, day: 14, hour: 20, minute: 28, second: 23, millisecond: 501, kind: DateTimeKind.Local), new DateTime(year: 1993, month: 10, day: 6, hour: 10, minute: 42, second: 19, millisecond: 474, kind: DateTimeKind.Local), }, { new DateTime(year: 1991, month: 10, day: 18, hour: 4, minute: 10, second: 2, millisecond: 224, kind: DateTimeKind.Local), new DateTime(year: 1960, month: 10, day: 19, hour: 6, minute: 44, second: 23, millisecond: 840, kind: DateTimeKind.Local), }, },
},
            new DateTimetimestamp_without_time_zoneMMArrayD2E1M
{
    Id = 188,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1981, month: 10, day: 3, hour: 10, minute: 8, second: 4, millisecond: 113, kind: DateTimeKind.Local), new DateTime(year: 2000, month: 10, day: 13, hour: 19, minute: 19, second: 43, millisecond: 461, kind: DateTimeKind.Local), }, { new DateTime(year: 1969, month: 10, day: 4, hour: 14, minute: 42, second: 13, millisecond: 577, kind: DateTimeKind.Local), new DateTime(year: 1937, month: 10, day: 9, hour: 2, minute: 39, second: 6, millisecond: 177, kind: DateTimeKind.Local), }, },
    ModelInner = new DateTimetimestamp_without_time_zoneMMArrayD2E1MI
{
    Id = 102,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1985, month: 10, day: 7, hour: 3, minute: 44, second: 12, millisecond: 985, kind: DateTimeKind.Local), new DateTime(year: 1954, month: 10, day: 11, hour: 14, minute: 37, second: 11, millisecond: 646, kind: DateTimeKind.Local), }, { new DateTime(year: 2016, month: 10, day: 4, hour: 10, minute: 36, second: 16, millisecond: 269, kind: DateTimeKind.Local), new DateTime(year: 1977, month: 10, day: 17, hour: 4, minute: 51, second: 5, millisecond: 454, kind: DateTimeKind.Local), }, },
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[,] { { new DateTime(year: 1997, month: 10, day: 5, hour: 8, minute: 36, second: 6, millisecond: 863, kind: DateTimeKind.Local), new DateTime(year: 1918, month: 10, day: 10, hour: 6, minute: 28, second: 53, millisecond: 358, kind: DateTimeKind.Local), }, { new DateTime(year: 1924, month: 10, day: 11, hour: 12, minute: 51, second: 21, millisecond: 922, kind: DateTimeKind.Local), new DateTime(year: 1971, month: 10, day: 7, hour: 11, minute: 55, second: 8, millisecond: 730, kind: DateTimeKind.Local), }, },
},
            new DateTimetimestamp_without_time_zoneMMArrayD2E1M
{
    Id = 191,
    Value = 
new System.DateTime[,] { { new DateTime(year: 1953, month: 10, day: 3, hour: 3, minute: 19, second: 33, millisecond: 964, kind: DateTimeKind.Local), new DateTime(year: 1972, month: 10, day: 12, hour: 19, minute: 35, second: 34, millisecond: 279, kind: DateTimeKind.Local), }, { new DateTime(year: 1975, month: 10, day: 5, hour: 1, minute: 8, second: 14, millisecond: 379, kind: DateTimeKind.Local), new DateTime(year: 1994, month: 10, day: 2, hour: 6, minute: 51, second: 53, millisecond: 127, kind: DateTimeKind.Local), }, },
    ModelInner = null,
    NullableValue = 
new System.DateTime[,] { { new DateTime(year: 1944, month: 10, day: 8, hour: 9, minute: 43, second: 23, millisecond: 175, kind: DateTimeKind.Local), new DateTime(year: 1975, month: 10, day: 8, hour: 19, minute: 56, second: 7, millisecond: 808, kind: DateTimeKind.Local), }, { new DateTime(year: 1991, month: 10, day: 6, hour: 12, minute: 24, second: 22, millisecond: 377, kind: DateTimeKind.Local), new DateTime(year: 1983, month: 10, day: 13, hour: 7, minute: 12, second: 48, millisecond: 174, kind: DateTimeKind.Local), }, },
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zonemmarrayd2e1mi(
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
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483627)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483627))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zonemmarrayd2e1mi(
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
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483627)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[,]), 
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

                changedRows =  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zonemmarrayd2e1m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_without_time_zonemmarrayd2e1mi_id
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
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483627)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483627)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "datetimetimestamp_without_time_zonemmarrayd2e1mi_id", 
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
                changedRows =  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zonemmarrayd2e1m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_without_time_zonemmarrayd2e1mi_id
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
    datetimetimestamp_without_time_zonemmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)),
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
                System.DateTime[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.DateTime[,]>();
                    ((NpgsqlParameter<System.DateTime[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483627);
                    ((NpgsqlParameter<System.DateTime[,]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.DateTime[,] { { new DateTime(year: 1968, month: 10, day: 19, hour: 13, minute: 16, second: 57, millisecond: 138, kind: DateTimeKind.Local), new DateTime(year: 1935, month: 10, day: 15, hour: 14, minute: 40, second: 23, millisecond: 877, kind: DateTimeKind.Local), }, { new DateTime(year: 1932, month: 10, day: 8, hour: 8, minute: 22, second: 32, millisecond: 557, kind: DateTimeKind.Local), new DateTime(year: 1973, month: 10, day: 1, hour: 1, minute: 23, second: 7, millisecond: 540, kind: DateTimeKind.Local), }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.DateTime[,]>();
                    ((NpgsqlParameter<System.DateTime[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483627);
                    ((NpgsqlParameter<System.DateTime[,]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.DateTime[,] { { new DateTime(year: 2018, month: 10, day: 2, hour: 19, minute: 37, second: 53, millisecond: 642, kind: DateTimeKind.Local), new DateTime(year: 1948, month: 10, day: 10, hour: 10, minute: 11, second: 33, millisecond: 717, kind: DateTimeKind.Local), }, { new DateTime(year: 1988, month: 10, day: 18, hour: 8, minute: 7, second: 31, millisecond: 878, kind: DateTimeKind.Local), new DateTime(year: 2008, month: 10, day: 19, hour: 3, minute: 42, second: 8, millisecond: 363, kind: DateTimeKind.Local), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.DateTime[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.DateTime[,]>();
                    ((NpgsqlParameter<System.DateTime[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483627);
                    ((NpgsqlParameter<System.DateTime[,]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.DateTime[,]>();
                    ((NpgsqlParameter<System.DateTime[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483627);
                    ((NpgsqlParameter<System.DateTime[,]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.DateTime[,] { { new DateTime(year: 1918, month: 10, day: 15, hour: 17, minute: 3, second: 28, millisecond: 465, kind: DateTimeKind.Local), new DateTime(year: 1968, month: 10, day: 10, hour: 15, minute: 25, second: 31, millisecond: 583, kind: DateTimeKind.Local), }, { new DateTime(year: 1984, month: 10, day: 9, hour: 18, minute: 18, second: 24, millisecond: 621, kind: DateTimeKind.Local), new DateTime(year: 1962, month: 10, day: 4, hour: 10, minute: 9, second: 45, millisecond: 888, kind: DateTimeKind.Local), }, }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zonemmarrayd2e1m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_without_time_zonemmarrayd2e1mi_id
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
    datetimetimestamp_without_time_zonemmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483627)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483627)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "datetimetimestamp_without_time_zonemmarrayd2e1mi_id", 
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
                System.DateTime[,] nullable = null;
                nullable =  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.DateTime[,] nullable = null;
                nullable = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.DateTime[,] { { new DateTime(year: 1995, month: 10, day: 15, hour: 19, minute: 36, second: 34, millisecond: 956, kind: DateTimeKind.Local), new DateTime(year: 1948, month: 10, day: 12, hour: 10, minute: 14, second: 40, millisecond: 920, kind: DateTimeKind.Local), }, { new DateTime(year: 1954, month: 10, day: 11, hour: 6, minute: 22, second: 43, millisecond: 782, kind: DateTimeKind.Local), new DateTime(year: 2009, month: 10, day: 2, hour: 22, minute: 4, second: 28, millisecond: 52, kind: DateTimeKind.Local), }, }));
                nullable = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DateTimetimestamp_without_time_zoneMMArrayD2E1M> models = null;

                models =  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DateTimetimestamp_without_time_zoneMMArrayD2E1M> models = null;

                models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M), typeof(FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)),
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)),
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
LEFT JOIN public.datetimetimestamp_without_time_zonemmarrayd2e1mi mi ON mi.id = m.datetimetimestamp_without_time_zonemmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)),
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
                var models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M), typeof(FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)),
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)),
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
LEFT JOIN public.datetimetimestamp_without_time_zonemmarrayd2e1mi mi ON mi.id = m.datetimetimestamp_without_time_zonemmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)),
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
                var models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M), typeof(FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)),
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
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)),
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                await((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 149;
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[8],_testData[34], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 52;
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                 ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 107;
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                 ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[31],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)),
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
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)),
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 173;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[1],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[2],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[3],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[4],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[5],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[6],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[7],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[8],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[9],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[10],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[11],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[12],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[13],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[14],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[15],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[16],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[17],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[18],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[19],_testData[34], false);
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
                parametr1.Value = 166;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                 ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
LEFT JOIN public.datetimetimestamp_without_time_zonemmarrayd2e1mi mi ON mi.id = m.datetimetimestamp_without_time_zonemmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)),
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
                var models = await((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 177;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[26],_testData[34], false);
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
                var models = ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 149;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M), typeof(FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)),
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
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)),
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
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)),
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                await((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 62, query1, 144, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 9, query1, 8, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                 ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 30, query1, 31, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                 ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 129, query1, 91, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[16],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)),
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
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)),
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
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)),
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 56, query1, 157, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[6],_testData[34], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 56, query1, 8, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 179, query1, 166, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                 ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 129, query1, 9, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd2e1m m
LEFT JOIN public.datetimetimestamp_without_time_zonemmarrayd2e1mi mi ON mi.id = m.datetimetimestamp_without_time_zonemmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)),
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
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)),
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
                var models = await((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 179, 22))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[30],_testData[34], false);
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
                var models = ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 107, 69))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[15], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[1],_testData[16], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[2],_testData[17], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[3],_testData[18], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[4],_testData[19], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[5],_testData[20], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[6],_testData[21], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[7],_testData[22], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[8],_testData[23], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[9],_testData[24], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[10],_testData[25], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[11],_testData[26], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[12],_testData[27], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[13],_testData[28], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[14],_testData[29], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[15],_testData[30], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[16],_testData[31], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[17],_testData[32], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[18],_testData[33], false);
                        DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[19],_testData[34], false);
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
                await using var cmd = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 102);
                var models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(15));

                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[20], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[1],_testData[21], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[2],_testData[22], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[3],_testData[23], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[4],_testData[24], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[5],_testData[25], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[6],_testData[26], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[7],_testData[27], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[8],_testData[28], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[9],_testData[29], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[10],_testData[30], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[11],_testData[31], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[12],_testData[32], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[13],_testData[33], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 49);
                var models =  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
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
FROM public.binary_datetimetimestamp_without_time_zonemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA),
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
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_datetimetimestamp_without_time_zonemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_datetimetimestamp_without_time_zonemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_datetimetimestamp_without_time_zonemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_datetimetimestamp_without_time_zonemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_datetimetimestamp_without_time_zonemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_datetimetimestamp_without_time_zonemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_datetimetimestamp_without_time_zonemmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(DateTimetimestamp_without_time_zoneMMArrayD2E1MI),
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
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateTimetimestamp_without_time_zoneMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<DateTimetimestamp_without_time_zoneMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_datetimetimestamp_without_time_zonemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_datetimetimestamp_without_time_zonemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_datetimetimestamp_without_time_zonemmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
datetimetimestamp_without_time_zonemmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DateTimetimestamp_without_time_zoneMMArrayD2E1M),
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
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2))]
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
FROM public.binary_datetimetimestamp_without_time_zonemmarrayd2e1m m
LEFT JOIN public.binary_datetimetimestamp_without_time_zonemmarrayd2e1mi mi ON mi.id = m.datetimetimestamp_without_time_zonemmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<DateTimetimestamp_without_time_zoneMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_datetimetimestamp_without_time_zonemmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    datetimetimestamp_without_time_zonemmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)),
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
                var models =  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DateTimetimestamp_without_time_zoneMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA), typeof(DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)),
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
                var models1 = new List<DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA>();
                var models2 = new List<DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA>();
                await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_datetimetimestamp_without_time_zonemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA>();
                var models2 = new List<DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA>();
                ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_datetimetimestamp_without_time_zonemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)),
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
                var models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_datetimetimestamp_without_time_zonemmarrayd2e1mi
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
                    DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_datetimetimestamp_without_time_zonemmarrayd2e1mi
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
                    DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA), typeof(DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2))]
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
                var models1 = new List<DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA>();
                var models2 = new List<DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA>();
                await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_datetimetimestamp_without_time_zonemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA>();
                var models2 = new List<DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA>();
                ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_datetimetimestamp_without_time_zonemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2))]
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
                var models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_datetimetimestamp_without_time_zonemmarrayd2e1mi
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
                    DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_datetimetimestamp_without_time_zonemmarrayd2e1mi
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
                    DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_datetimetimestamp_without_time_zonemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD2E1MI), typeof(DateTimetimestamp_without_time_zoneMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)),
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
                var models1 = new List<DateTimetimestamp_without_time_zoneMMArrayD2E1MI>();
                var models2 = new List<DateTimetimestamp_without_time_zoneMMArrayD2E1MI>();
                await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DateTimetimestamp_without_time_zoneMMArrayD2E1MI>();
                var models2 = new List<DateTimetimestamp_without_time_zoneMMArrayD2E1MI>();
                ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_datetimetimestamp_without_time_zonemmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)),
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
                var models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_datetimetimestamp_without_time_zonemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA), typeof(DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2))]
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
                var models1 = new List<DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA>();
                var models2 = new List<DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA>();
                await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA>();
                var models2 = new List<DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA>();
                ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_datetimetimestamp_without_time_zonemmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD2))]
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
                var models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

