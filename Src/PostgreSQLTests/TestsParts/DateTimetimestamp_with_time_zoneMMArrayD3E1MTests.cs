

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
    internal partial interface IDateTimeMArraytimestamp_with_time_zoneMMArrayD3
    {
    }
    
    internal partial class DateTimeMArraytimestamp_with_time_zoneMMArrayD3 : IDateTimeMArraytimestamp_with_time_zoneMMArrayD3
    {


#region TestData

        private readonly DateTimetimestamp_with_time_zoneMMArrayD3E1M[] _testData = new DateTimetimestamp_with_time_zoneMMArrayD3E1M[]
        {
            new DateTimetimestamp_with_time_zoneMMArrayD3E1M
{
    Id = 5,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1922, month: 10, day: 18, hour: 8, minute: 37, second: 32, millisecond: 154, kind: DateTimeKind.Utc), new DateTime(year: 2003, month: 10, day: 9, hour: 3, minute: 47, second: 2, millisecond: 91, kind: DateTimeKind.Utc), new DateTime(year: 2012, month: 10, day: 10, hour: 12, minute: 22, second: 12, millisecond: 814, kind: DateTimeKind.Utc), }, { new DateTime(year: 1920, month: 10, day: 16, hour: 12, minute: 38, second: 55, millisecond: 234, kind: DateTimeKind.Utc), new DateTime(year: 1994, month: 10, day: 9, hour: 5, minute: 7, second: 19, millisecond: 695, kind: DateTimeKind.Utc), new DateTime(year: 1952, month: 10, day: 2, hour: 5, minute: 34, second: 6, millisecond: 31, kind: DateTimeKind.Utc), }, { new DateTime(year: 1957, month: 10, day: 3, hour: 18, minute: 9, second: 4, millisecond: 48, kind: DateTimeKind.Utc), new DateTime(year: 1937, month: 10, day: 12, hour: 2, minute: 9, second: 52, millisecond: 172, kind: DateTimeKind.Utc), new DateTime(year: 1936, month: 10, day: 12, hour: 11, minute: 45, second: 56, millisecond: 678, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1990, month: 10, day: 13, hour: 2, minute: 2, second: 28, millisecond: 746, kind: DateTimeKind.Utc), new DateTime(year: 1981, month: 10, day: 5, hour: 14, minute: 21, second: 42, millisecond: 270, kind: DateTimeKind.Utc), new DateTime(year: 1965, month: 10, day: 13, hour: 1, minute: 28, second: 41, millisecond: 543, kind: DateTimeKind.Utc), }, { new DateTime(year: 1982, month: 10, day: 18, hour: 13, minute: 34, second: 14, millisecond: 773, kind: DateTimeKind.Utc), new DateTime(year: 2019, month: 10, day: 18, hour: 4, minute: 40, second: 16, millisecond: 447, kind: DateTimeKind.Utc), new DateTime(year: 2017, month: 10, day: 16, hour: 18, minute: 26, second: 43, millisecond: 61, kind: DateTimeKind.Utc), }, { new DateTime(year: 1939, month: 10, day: 2, hour: 8, minute: 54, second: 40, millisecond: 114, kind: DateTimeKind.Utc), new DateTime(year: 1978, month: 10, day: 9, hour: 10, minute: 23, second: 40, millisecond: 267, kind: DateTimeKind.Utc), new DateTime(year: 1995, month: 10, day: 17, hour: 11, minute: 32, second: 27, millisecond: 319, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 2015, month: 10, day: 12, hour: 18, minute: 57, second: 58, millisecond: 335, kind: DateTimeKind.Utc), new DateTime(year: 2000, month: 10, day: 17, hour: 11, minute: 49, second: 3, millisecond: 935, kind: DateTimeKind.Utc), new DateTime(year: 1978, month: 10, day: 15, hour: 17, minute: 40, second: 17, millisecond: 575, kind: DateTimeKind.Utc), }, { new DateTime(year: 1966, month: 10, day: 13, hour: 18, minute: 34, second: 22, millisecond: 203, kind: DateTimeKind.Utc), new DateTime(year: 2005, month: 10, day: 13, hour: 18, minute: 30, second: 12, millisecond: 944, kind: DateTimeKind.Utc), new DateTime(year: 1969, month: 10, day: 7, hour: 8, minute: 25, second: 49, millisecond: 333, kind: DateTimeKind.Utc), }, { new DateTime(year: 1974, month: 10, day: 15, hour: 16, minute: 21, second: 30, millisecond: 761, kind: DateTimeKind.Utc), new DateTime(year: 1973, month: 10, day: 3, hour: 13, minute: 10, second: 38, millisecond: 137, kind: DateTimeKind.Utc), new DateTime(year: 1952, month: 10, day: 10, hour: 16, minute: 25, second: 39, millisecond: 942, kind: DateTimeKind.Utc), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneMMArrayD3E1M
{
    Id = 7,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1967, month: 10, day: 18, hour: 13, minute: 9, second: 25, millisecond: 320, kind: DateTimeKind.Utc), new DateTime(year: 1975, month: 10, day: 2, hour: 6, minute: 38, second: 14, millisecond: 890, kind: DateTimeKind.Utc), new DateTime(year: 1935, month: 10, day: 2, hour: 10, minute: 14, second: 3, millisecond: 220, kind: DateTimeKind.Utc), }, { new DateTime(year: 2019, month: 10, day: 1, hour: 12, minute: 55, second: 29, millisecond: 787, kind: DateTimeKind.Utc), new DateTime(year: 1995, month: 10, day: 6, hour: 15, minute: 41, second: 41, millisecond: 527, kind: DateTimeKind.Utc), new DateTime(year: 2000, month: 10, day: 3, hour: 12, minute: 2, second: 11, millisecond: 55, kind: DateTimeKind.Utc), }, { new DateTime(year: 1966, month: 10, day: 1, hour: 17, minute: 24, second: 9, millisecond: 722, kind: DateTimeKind.Utc), new DateTime(year: 1950, month: 10, day: 7, hour: 12, minute: 23, second: 4, millisecond: 364, kind: DateTimeKind.Utc), new DateTime(year: 1999, month: 10, day: 10, hour: 20, minute: 49, second: 19, millisecond: 347, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1972, month: 10, day: 11, hour: 8, minute: 38, second: 55, millisecond: 51, kind: DateTimeKind.Utc), new DateTime(year: 1949, month: 10, day: 18, hour: 5, minute: 36, second: 41, millisecond: 656, kind: DateTimeKind.Utc), new DateTime(year: 2004, month: 10, day: 13, hour: 7, minute: 44, second: 43, millisecond: 499, kind: DateTimeKind.Utc), }, { new DateTime(year: 1943, month: 10, day: 14, hour: 2, minute: 42, second: 28, millisecond: 846, kind: DateTimeKind.Utc), new DateTime(year: 2002, month: 10, day: 13, hour: 7, minute: 1, second: 31, millisecond: 207, kind: DateTimeKind.Utc), new DateTime(year: 1917, month: 10, day: 7, hour: 15, minute: 38, second: 1, millisecond: 522, kind: DateTimeKind.Utc), }, { new DateTime(year: 1994, month: 10, day: 12, hour: 2, minute: 42, second: 12, millisecond: 864, kind: DateTimeKind.Utc), new DateTime(year: 1976, month: 10, day: 2, hour: 2, minute: 49, second: 56, millisecond: 15, kind: DateTimeKind.Utc), new DateTime(year: 2013, month: 10, day: 7, hour: 20, minute: 39, second: 22, millisecond: 606, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 2002, month: 10, day: 1, hour: 8, minute: 32, second: 8, millisecond: 361, kind: DateTimeKind.Utc), new DateTime(year: 1995, month: 10, day: 2, hour: 13, minute: 20, second: 24, millisecond: 887, kind: DateTimeKind.Utc), new DateTime(year: 2012, month: 10, day: 15, hour: 6, minute: 33, second: 11, millisecond: 713, kind: DateTimeKind.Utc), }, { new DateTime(year: 2016, month: 10, day: 13, hour: 7, minute: 30, second: 33, millisecond: 161, kind: DateTimeKind.Utc), new DateTime(year: 1985, month: 10, day: 10, hour: 5, minute: 49, second: 18, millisecond: 315, kind: DateTimeKind.Utc), new DateTime(year: 1985, month: 10, day: 15, hour: 8, minute: 36, second: 7, millisecond: 279, kind: DateTimeKind.Utc), }, { new DateTime(year: 1959, month: 10, day: 13, hour: 11, minute: 56, second: 21, millisecond: 869, kind: DateTimeKind.Utc), new DateTime(year: 1928, month: 10, day: 13, hour: 9, minute: 7, second: 48, millisecond: 657, kind: DateTimeKind.Utc), new DateTime(year: 2002, month: 10, day: 5, hour: 4, minute: 46, second: 38, millisecond: 566, kind: DateTimeKind.Utc), }, }, },
    ModelInner = new DateTimetimestamp_with_time_zoneMMArrayD3E1MI
{
    Id = 5,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1960, month: 10, day: 5, hour: 13, minute: 28, second: 13, millisecond: 958, kind: DateTimeKind.Utc), new DateTime(year: 1968, month: 10, day: 11, hour: 16, minute: 42, second: 25, millisecond: 358, kind: DateTimeKind.Utc), new DateTime(year: 1939, month: 10, day: 1, hour: 13, minute: 20, second: 41, millisecond: 708, kind: DateTimeKind.Utc), }, { new DateTime(year: 1944, month: 10, day: 7, hour: 4, minute: 20, second: 40, millisecond: 963, kind: DateTimeKind.Utc), new DateTime(year: 1945, month: 10, day: 11, hour: 20, minute: 26, second: 3, millisecond: 267, kind: DateTimeKind.Utc), new DateTime(year: 1930, month: 10, day: 6, hour: 16, minute: 30, second: 15, millisecond: 120, kind: DateTimeKind.Utc), }, { new DateTime(year: 1992, month: 10, day: 18, hour: 10, minute: 13, second: 55, millisecond: 560, kind: DateTimeKind.Utc), new DateTime(year: 2016, month: 10, day: 14, hour: 12, minute: 33, second: 9, millisecond: 679, kind: DateTimeKind.Utc), new DateTime(year: 1952, month: 10, day: 4, hour: 11, minute: 54, second: 4, millisecond: 469, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1941, month: 10, day: 6, hour: 19, minute: 11, second: 35, millisecond: 851, kind: DateTimeKind.Utc), new DateTime(year: 1918, month: 10, day: 17, hour: 22, minute: 7, second: 38, millisecond: 213, kind: DateTimeKind.Utc), new DateTime(year: 1981, month: 10, day: 17, hour: 11, minute: 23, second: 32, millisecond: 920, kind: DateTimeKind.Utc), }, { new DateTime(year: 1957, month: 10, day: 9, hour: 11, minute: 13, second: 31, millisecond: 362, kind: DateTimeKind.Utc), new DateTime(year: 2019, month: 10, day: 16, hour: 9, minute: 53, second: 53, millisecond: 833, kind: DateTimeKind.Utc), new DateTime(year: 1944, month: 10, day: 16, hour: 3, minute: 47, second: 46, millisecond: 145, kind: DateTimeKind.Utc), }, { new DateTime(year: 1962, month: 10, day: 8, hour: 3, minute: 25, second: 16, millisecond: 928, kind: DateTimeKind.Utc), new DateTime(year: 1992, month: 10, day: 15, hour: 4, minute: 45, second: 9, millisecond: 551, kind: DateTimeKind.Utc), new DateTime(year: 2013, month: 10, day: 13, hour: 13, minute: 3, second: 56, millisecond: 876, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1985, month: 10, day: 9, hour: 14, minute: 31, second: 15, millisecond: 216, kind: DateTimeKind.Utc), new DateTime(year: 1918, month: 10, day: 10, hour: 15, minute: 30, second: 57, millisecond: 59, kind: DateTimeKind.Utc), new DateTime(year: 2004, month: 10, day: 5, hour: 7, minute: 14, second: 30, millisecond: 789, kind: DateTimeKind.Utc), }, { new DateTime(year: 1961, month: 10, day: 17, hour: 22, minute: 30, second: 43, millisecond: 472, kind: DateTimeKind.Utc), new DateTime(year: 2013, month: 10, day: 4, hour: 3, minute: 23, second: 25, millisecond: 395, kind: DateTimeKind.Utc), new DateTime(year: 2012, month: 10, day: 7, hour: 5, minute: 40, second: 44, millisecond: 959, kind: DateTimeKind.Utc), }, { new DateTime(year: 2005, month: 10, day: 13, hour: 17, minute: 12, second: 1, millisecond: 511, kind: DateTimeKind.Utc), new DateTime(year: 1971, month: 10, day: 18, hour: 20, minute: 8, second: 22, millisecond: 121, kind: DateTimeKind.Utc), new DateTime(year: 1927, month: 10, day: 3, hour: 11, minute: 1, second: 45, millisecond: 8, kind: DateTimeKind.Utc), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneMMArrayD3E1M
{
    Id = 8,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1947, month: 10, day: 1, hour: 8, minute: 39, second: 49, millisecond: 139, kind: DateTimeKind.Utc), new DateTime(year: 1941, month: 10, day: 1, hour: 9, minute: 21, second: 57, millisecond: 818, kind: DateTimeKind.Utc), new DateTime(year: 1985, month: 10, day: 17, hour: 19, minute: 43, second: 56, millisecond: 809, kind: DateTimeKind.Utc), }, { new DateTime(year: 1998, month: 10, day: 10, hour: 22, minute: 30, second: 56, millisecond: 988, kind: DateTimeKind.Utc), new DateTime(year: 1994, month: 10, day: 11, hour: 18, minute: 42, second: 23, millisecond: 686, kind: DateTimeKind.Utc), new DateTime(year: 2006, month: 10, day: 17, hour: 3, minute: 54, second: 38, millisecond: 676, kind: DateTimeKind.Utc), }, { new DateTime(year: 1988, month: 10, day: 7, hour: 21, minute: 40, second: 32, millisecond: 321, kind: DateTimeKind.Utc), new DateTime(year: 1942, month: 10, day: 11, hour: 8, minute: 13, second: 22, millisecond: 433, kind: DateTimeKind.Utc), new DateTime(year: 1917, month: 10, day: 18, hour: 9, minute: 48, second: 23, millisecond: 542, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1978, month: 10, day: 6, hour: 12, minute: 20, second: 51, millisecond: 633, kind: DateTimeKind.Utc), new DateTime(year: 1955, month: 10, day: 3, hour: 17, minute: 45, second: 48, millisecond: 331, kind: DateTimeKind.Utc), new DateTime(year: 1958, month: 10, day: 8, hour: 7, minute: 13, second: 2, millisecond: 443, kind: DateTimeKind.Utc), }, { new DateTime(year: 1920, month: 10, day: 18, hour: 20, minute: 41, second: 48, millisecond: 309, kind: DateTimeKind.Utc), new DateTime(year: 1923, month: 10, day: 15, hour: 12, minute: 21, second: 57, millisecond: 839, kind: DateTimeKind.Utc), new DateTime(year: 2016, month: 10, day: 19, hour: 1, minute: 31, second: 35, millisecond: 196, kind: DateTimeKind.Utc), }, { new DateTime(year: 1925, month: 10, day: 11, hour: 5, minute: 17, second: 58, millisecond: 942, kind: DateTimeKind.Utc), new DateTime(year: 1920, month: 10, day: 10, hour: 3, minute: 11, second: 19, millisecond: 701, kind: DateTimeKind.Utc), new DateTime(year: 1982, month: 10, day: 18, hour: 11, minute: 24, second: 1, millisecond: 451, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 2010, month: 10, day: 3, hour: 20, minute: 3, second: 42, millisecond: 181, kind: DateTimeKind.Utc), new DateTime(year: 1970, month: 10, day: 3, hour: 13, minute: 1, second: 46, millisecond: 902, kind: DateTimeKind.Utc), new DateTime(year: 1959, month: 10, day: 5, hour: 11, minute: 41, second: 28, millisecond: 503, kind: DateTimeKind.Utc), }, { new DateTime(year: 1929, month: 10, day: 7, hour: 14, minute: 28, second: 29, millisecond: 341, kind: DateTimeKind.Utc), new DateTime(year: 1963, month: 10, day: 14, hour: 19, minute: 49, second: 16, millisecond: 892, kind: DateTimeKind.Utc), new DateTime(year: 1932, month: 10, day: 17, hour: 16, minute: 21, second: 37, millisecond: 42, kind: DateTimeKind.Utc), }, { new DateTime(year: 1948, month: 10, day: 5, hour: 13, minute: 8, second: 57, millisecond: 123, kind: DateTimeKind.Utc), new DateTime(year: 1986, month: 10, day: 11, hour: 21, minute: 4, second: 19, millisecond: 944, kind: DateTimeKind.Utc), new DateTime(year: 2012, month: 10, day: 6, hour: 15, minute: 36, second: 5, millisecond: 730, kind: DateTimeKind.Utc), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneMMArrayD3E1M
{
    Id = 10,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1984, month: 10, day: 19, hour: 13, minute: 43, second: 17, millisecond: 873, kind: DateTimeKind.Utc), new DateTime(year: 2009, month: 10, day: 7, hour: 22, minute: 7, second: 17, millisecond: 359, kind: DateTimeKind.Utc), new DateTime(year: 2004, month: 10, day: 7, hour: 4, minute: 16, second: 25, millisecond: 231, kind: DateTimeKind.Utc), }, { new DateTime(year: 1973, month: 10, day: 2, hour: 15, minute: 16, second: 1, millisecond: 891, kind: DateTimeKind.Utc), new DateTime(year: 1972, month: 10, day: 17, hour: 15, minute: 29, second: 3, millisecond: 46, kind: DateTimeKind.Utc), new DateTime(year: 1990, month: 10, day: 3, hour: 7, minute: 10, second: 17, millisecond: 708, kind: DateTimeKind.Utc), }, { new DateTime(year: 1940, month: 10, day: 3, hour: 1, minute: 11, second: 50, millisecond: 112, kind: DateTimeKind.Utc), new DateTime(year: 1944, month: 10, day: 14, hour: 16, minute: 33, second: 52, millisecond: 28, kind: DateTimeKind.Utc), new DateTime(year: 1966, month: 10, day: 19, hour: 12, minute: 9, second: 4, millisecond: 96, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1923, month: 10, day: 9, hour: 6, minute: 11, second: 43, millisecond: 709, kind: DateTimeKind.Utc), new DateTime(year: 2014, month: 10, day: 15, hour: 3, minute: 14, second: 28, millisecond: 524, kind: DateTimeKind.Utc), new DateTime(year: 1931, month: 10, day: 6, hour: 11, minute: 20, second: 8, millisecond: 994, kind: DateTimeKind.Utc), }, { new DateTime(year: 1918, month: 10, day: 11, hour: 18, minute: 42, second: 15, millisecond: 594, kind: DateTimeKind.Utc), new DateTime(year: 1960, month: 10, day: 15, hour: 14, minute: 43, second: 32, millisecond: 325, kind: DateTimeKind.Utc), new DateTime(year: 1950, month: 10, day: 12, hour: 12, minute: 17, second: 17, millisecond: 901, kind: DateTimeKind.Utc), }, { new DateTime(year: 1973, month: 10, day: 16, hour: 5, minute: 10, second: 48, millisecond: 259, kind: DateTimeKind.Utc), new DateTime(year: 2000, month: 10, day: 4, hour: 4, minute: 33, second: 6, millisecond: 982, kind: DateTimeKind.Utc), new DateTime(year: 2012, month: 10, day: 14, hour: 7, minute: 46, second: 22, millisecond: 278, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1971, month: 10, day: 11, hour: 19, minute: 13, second: 5, millisecond: 910, kind: DateTimeKind.Utc), new DateTime(year: 1961, month: 10, day: 8, hour: 21, minute: 13, second: 57, millisecond: 288, kind: DateTimeKind.Utc), new DateTime(year: 1963, month: 10, day: 18, hour: 8, minute: 16, second: 58, millisecond: 287, kind: DateTimeKind.Utc), }, { new DateTime(year: 1964, month: 10, day: 15, hour: 17, minute: 14, second: 56, millisecond: 926, kind: DateTimeKind.Utc), new DateTime(year: 1924, month: 10, day: 4, hour: 22, minute: 37, second: 20, millisecond: 133, kind: DateTimeKind.Utc), new DateTime(year: 1927, month: 10, day: 6, hour: 17, minute: 45, second: 34, millisecond: 183, kind: DateTimeKind.Utc), }, { new DateTime(year: 1968, month: 10, day: 15, hour: 17, minute: 13, second: 41, millisecond: 749, kind: DateTimeKind.Utc), new DateTime(year: 1927, month: 10, day: 1, hour: 6, minute: 51, second: 12, millisecond: 866, kind: DateTimeKind.Utc), new DateTime(year: 1977, month: 10, day: 11, hour: 19, minute: 10, second: 54, millisecond: 233, kind: DateTimeKind.Utc), }, }, },
    ModelInner = new DateTimetimestamp_with_time_zoneMMArrayD3E1MI
{
    Id = 13,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1975, month: 10, day: 14, hour: 19, minute: 30, second: 45, millisecond: 561, kind: DateTimeKind.Utc), new DateTime(year: 1942, month: 10, day: 19, hour: 17, minute: 5, second: 48, millisecond: 501, kind: DateTimeKind.Utc), new DateTime(year: 1947, month: 10, day: 12, hour: 2, minute: 15, second: 36, millisecond: 170, kind: DateTimeKind.Utc), }, { new DateTime(year: 1968, month: 10, day: 11, hour: 17, minute: 44, second: 26, millisecond: 229, kind: DateTimeKind.Utc), new DateTime(year: 1994, month: 10, day: 18, hour: 9, minute: 4, second: 34, millisecond: 299, kind: DateTimeKind.Utc), new DateTime(year: 1967, month: 10, day: 16, hour: 4, minute: 55, second: 21, millisecond: 385, kind: DateTimeKind.Utc), }, { new DateTime(year: 1950, month: 10, day: 1, hour: 5, minute: 35, second: 29, millisecond: 501, kind: DateTimeKind.Utc), new DateTime(year: 1968, month: 10, day: 19, hour: 3, minute: 29, second: 3, millisecond: 380, kind: DateTimeKind.Utc), new DateTime(year: 1976, month: 10, day: 8, hour: 20, minute: 47, second: 16, millisecond: 651, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1940, month: 10, day: 4, hour: 6, minute: 38, second: 45, millisecond: 917, kind: DateTimeKind.Utc), new DateTime(year: 1991, month: 10, day: 12, hour: 17, minute: 47, second: 13, millisecond: 302, kind: DateTimeKind.Utc), new DateTime(year: 1997, month: 10, day: 12, hour: 6, minute: 5, second: 40, millisecond: 906, kind: DateTimeKind.Utc), }, { new DateTime(year: 1953, month: 10, day: 8, hour: 2, minute: 39, second: 25, millisecond: 435, kind: DateTimeKind.Utc), new DateTime(year: 1937, month: 10, day: 16, hour: 12, minute: 46, second: 48, millisecond: 681, kind: DateTimeKind.Utc), new DateTime(year: 1947, month: 10, day: 16, hour: 21, minute: 14, second: 41, millisecond: 188, kind: DateTimeKind.Utc), }, { new DateTime(year: 1957, month: 10, day: 5, hour: 16, minute: 27, second: 40, millisecond: 105, kind: DateTimeKind.Utc), new DateTime(year: 1972, month: 10, day: 12, hour: 19, minute: 10, second: 43, millisecond: 90, kind: DateTimeKind.Utc), new DateTime(year: 1919, month: 10, day: 14, hour: 15, minute: 26, second: 14, millisecond: 214, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1926, month: 10, day: 16, hour: 21, minute: 53, second: 36, millisecond: 341, kind: DateTimeKind.Utc), new DateTime(year: 1932, month: 10, day: 14, hour: 8, minute: 23, second: 17, millisecond: 687, kind: DateTimeKind.Utc), new DateTime(year: 1948, month: 10, day: 13, hour: 21, minute: 12, second: 48, millisecond: 117, kind: DateTimeKind.Utc), }, { new DateTime(year: 1956, month: 10, day: 10, hour: 18, minute: 19, second: 41, millisecond: 210, kind: DateTimeKind.Utc), new DateTime(year: 1986, month: 10, day: 14, hour: 2, minute: 52, second: 25, millisecond: 630, kind: DateTimeKind.Utc), new DateTime(year: 2001, month: 10, day: 5, hour: 10, minute: 19, second: 34, millisecond: 264, kind: DateTimeKind.Utc), }, { new DateTime(year: 2013, month: 10, day: 10, hour: 19, minute: 29, second: 10, millisecond: 412, kind: DateTimeKind.Utc), new DateTime(year: 1942, month: 10, day: 17, hour: 2, minute: 47, second: 11, millisecond: 686, kind: DateTimeKind.Utc), new DateTime(year: 1991, month: 10, day: 13, hour: 2, minute: 53, second: 45, millisecond: 527, kind: DateTimeKind.Utc), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneMMArrayD3E1M
{
    Id = 16,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 2014, month: 10, day: 5, hour: 4, minute: 10, second: 52, millisecond: 365, kind: DateTimeKind.Utc), new DateTime(year: 1993, month: 10, day: 18, hour: 21, minute: 17, second: 2, millisecond: 460, kind: DateTimeKind.Utc), new DateTime(year: 1958, month: 10, day: 12, hour: 4, minute: 54, second: 12, millisecond: 959, kind: DateTimeKind.Utc), }, { new DateTime(year: 1956, month: 10, day: 12, hour: 14, minute: 46, second: 27, millisecond: 200, kind: DateTimeKind.Utc), new DateTime(year: 1956, month: 10, day: 4, hour: 6, minute: 14, second: 15, millisecond: 904, kind: DateTimeKind.Utc), new DateTime(year: 2018, month: 10, day: 19, hour: 18, minute: 29, second: 27, millisecond: 491, kind: DateTimeKind.Utc), }, { new DateTime(year: 2014, month: 10, day: 16, hour: 12, minute: 33, second: 21, millisecond: 368, kind: DateTimeKind.Utc), new DateTime(year: 1934, month: 10, day: 3, hour: 11, minute: 39, second: 42, millisecond: 586, kind: DateTimeKind.Utc), new DateTime(year: 1998, month: 10, day: 14, hour: 15, minute: 42, second: 9, millisecond: 998, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 2009, month: 10, day: 14, hour: 16, minute: 42, second: 5, millisecond: 313, kind: DateTimeKind.Utc), new DateTime(year: 1971, month: 10, day: 5, hour: 2, minute: 8, second: 36, millisecond: 263, kind: DateTimeKind.Utc), new DateTime(year: 2016, month: 10, day: 14, hour: 18, minute: 51, second: 57, millisecond: 950, kind: DateTimeKind.Utc), }, { new DateTime(year: 2018, month: 10, day: 4, hour: 19, minute: 24, second: 50, millisecond: 773, kind: DateTimeKind.Utc), new DateTime(year: 1967, month: 10, day: 7, hour: 3, minute: 16, second: 15, millisecond: 415, kind: DateTimeKind.Utc), new DateTime(year: 1977, month: 10, day: 7, hour: 11, minute: 41, second: 8, millisecond: 469, kind: DateTimeKind.Utc), }, { new DateTime(year: 1942, month: 10, day: 7, hour: 1, minute: 27, second: 15, millisecond: 326, kind: DateTimeKind.Utc), new DateTime(year: 1917, month: 10, day: 19, hour: 2, minute: 30, second: 1, millisecond: 453, kind: DateTimeKind.Utc), new DateTime(year: 1959, month: 10, day: 17, hour: 22, minute: 41, second: 55, millisecond: 501, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 2007, month: 10, day: 12, hour: 14, minute: 5, second: 21, millisecond: 555, kind: DateTimeKind.Utc), new DateTime(year: 1954, month: 10, day: 14, hour: 9, minute: 38, second: 13, millisecond: 223, kind: DateTimeKind.Utc), new DateTime(year: 1933, month: 10, day: 12, hour: 15, minute: 9, second: 9, millisecond: 565, kind: DateTimeKind.Utc), }, { new DateTime(year: 1945, month: 10, day: 9, hour: 6, minute: 26, second: 37, millisecond: 893, kind: DateTimeKind.Utc), new DateTime(year: 1981, month: 10, day: 4, hour: 3, minute: 45, second: 33, millisecond: 518, kind: DateTimeKind.Utc), new DateTime(year: 1926, month: 10, day: 17, hour: 4, minute: 21, second: 19, millisecond: 532, kind: DateTimeKind.Utc), }, { new DateTime(year: 1918, month: 10, day: 7, hour: 9, minute: 57, second: 36, millisecond: 682, kind: DateTimeKind.Utc), new DateTime(year: 2001, month: 10, day: 10, hour: 13, minute: 31, second: 26, millisecond: 244, kind: DateTimeKind.Utc), new DateTime(year: 2000, month: 10, day: 17, hour: 8, minute: 41, second: 35, millisecond: 486, kind: DateTimeKind.Utc), }, }, },
    ModelInner = null,
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1945, month: 10, day: 17, hour: 12, minute: 43, second: 40, millisecond: 879, kind: DateTimeKind.Utc), new DateTime(year: 1999, month: 10, day: 14, hour: 5, minute: 28, second: 43, millisecond: 160, kind: DateTimeKind.Utc), new DateTime(year: 1988, month: 10, day: 14, hour: 18, minute: 25, second: 28, millisecond: 968, kind: DateTimeKind.Utc), }, { new DateTime(year: 2004, month: 10, day: 16, hour: 16, minute: 47, second: 9, millisecond: 524, kind: DateTimeKind.Utc), new DateTime(year: 1919, month: 10, day: 4, hour: 18, minute: 38, second: 56, millisecond: 917, kind: DateTimeKind.Utc), new DateTime(year: 1955, month: 10, day: 19, hour: 19, minute: 3, second: 23, millisecond: 23, kind: DateTimeKind.Utc), }, { new DateTime(year: 2004, month: 10, day: 7, hour: 3, minute: 46, second: 12, millisecond: 206, kind: DateTimeKind.Utc), new DateTime(year: 1965, month: 10, day: 5, hour: 20, minute: 22, second: 6, millisecond: 16, kind: DateTimeKind.Utc), new DateTime(year: 1972, month: 10, day: 17, hour: 1, minute: 57, second: 39, millisecond: 625, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1991, month: 10, day: 7, hour: 17, minute: 1, second: 40, millisecond: 504, kind: DateTimeKind.Utc), new DateTime(year: 1974, month: 10, day: 7, hour: 13, minute: 52, second: 57, millisecond: 310, kind: DateTimeKind.Utc), new DateTime(year: 1979, month: 10, day: 5, hour: 18, minute: 25, second: 9, millisecond: 974, kind: DateTimeKind.Utc), }, { new DateTime(year: 1990, month: 10, day: 8, hour: 1, minute: 18, second: 47, millisecond: 208, kind: DateTimeKind.Utc), new DateTime(year: 1940, month: 10, day: 4, hour: 22, minute: 6, second: 12, millisecond: 473, kind: DateTimeKind.Utc), new DateTime(year: 2017, month: 10, day: 6, hour: 1, minute: 17, second: 25, millisecond: 373, kind: DateTimeKind.Utc), }, { new DateTime(year: 1971, month: 10, day: 19, hour: 11, minute: 48, second: 24, millisecond: 201, kind: DateTimeKind.Utc), new DateTime(year: 1953, month: 10, day: 16, hour: 12, minute: 7, second: 51, millisecond: 860, kind: DateTimeKind.Utc), new DateTime(year: 1973, month: 10, day: 5, hour: 7, minute: 18, second: 11, millisecond: 922, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1950, month: 10, day: 17, hour: 18, minute: 24, second: 7, millisecond: 793, kind: DateTimeKind.Utc), new DateTime(year: 1960, month: 10, day: 4, hour: 20, minute: 53, second: 22, millisecond: 541, kind: DateTimeKind.Utc), new DateTime(year: 2010, month: 10, day: 7, hour: 9, minute: 55, second: 57, millisecond: 689, kind: DateTimeKind.Utc), }, { new DateTime(year: 1954, month: 10, day: 2, hour: 7, minute: 36, second: 32, millisecond: 976, kind: DateTimeKind.Utc), new DateTime(year: 1930, month: 10, day: 14, hour: 13, minute: 42, second: 34, millisecond: 406, kind: DateTimeKind.Utc), new DateTime(year: 1964, month: 10, day: 7, hour: 6, minute: 53, second: 51, millisecond: 682, kind: DateTimeKind.Utc), }, { new DateTime(year: 1922, month: 10, day: 17, hour: 14, minute: 58, second: 42, millisecond: 88, kind: DateTimeKind.Utc), new DateTime(year: 1974, month: 10, day: 5, hour: 16, minute: 5, second: 28, millisecond: 967, kind: DateTimeKind.Utc), new DateTime(year: 1978, month: 10, day: 17, hour: 16, minute: 41, second: 4, millisecond: 794, kind: DateTimeKind.Utc), }, }, },
},
            new DateTimetimestamp_with_time_zoneMMArrayD3E1M
{
    Id = 24,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1920, month: 10, day: 6, hour: 4, minute: 47, second: 39, millisecond: 371, kind: DateTimeKind.Utc), new DateTime(year: 1929, month: 10, day: 6, hour: 13, minute: 13, second: 25, millisecond: 705, kind: DateTimeKind.Utc), new DateTime(year: 1963, month: 10, day: 17, hour: 5, minute: 5, second: 52, millisecond: 336, kind: DateTimeKind.Utc), }, { new DateTime(year: 1947, month: 10, day: 15, hour: 3, minute: 52, second: 49, millisecond: 833, kind: DateTimeKind.Utc), new DateTime(year: 2008, month: 10, day: 3, hour: 4, minute: 9, second: 2, millisecond: 614, kind: DateTimeKind.Utc), new DateTime(year: 1984, month: 10, day: 2, hour: 21, minute: 4, second: 54, millisecond: 720, kind: DateTimeKind.Utc), }, { new DateTime(year: 2001, month: 10, day: 6, hour: 10, minute: 40, second: 22, millisecond: 263, kind: DateTimeKind.Utc), new DateTime(year: 2010, month: 10, day: 11, hour: 7, minute: 3, second: 58, millisecond: 218, kind: DateTimeKind.Utc), new DateTime(year: 1991, month: 10, day: 13, hour: 14, minute: 23, second: 46, millisecond: 882, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1975, month: 10, day: 3, hour: 17, minute: 56, second: 12, millisecond: 570, kind: DateTimeKind.Utc), new DateTime(year: 1981, month: 10, day: 19, hour: 22, minute: 50, second: 25, millisecond: 744, kind: DateTimeKind.Utc), new DateTime(year: 1991, month: 10, day: 16, hour: 7, minute: 41, second: 31, millisecond: 152, kind: DateTimeKind.Utc), }, { new DateTime(year: 2004, month: 10, day: 17, hour: 7, minute: 5, second: 23, millisecond: 287, kind: DateTimeKind.Utc), new DateTime(year: 1982, month: 10, day: 12, hour: 11, minute: 4, second: 45, millisecond: 443, kind: DateTimeKind.Utc), new DateTime(year: 1948, month: 10, day: 8, hour: 18, minute: 39, second: 17, millisecond: 64, kind: DateTimeKind.Utc), }, { new DateTime(year: 2015, month: 10, day: 17, hour: 13, minute: 35, second: 26, millisecond: 243, kind: DateTimeKind.Utc), new DateTime(year: 1970, month: 10, day: 8, hour: 7, minute: 12, second: 1, millisecond: 627, kind: DateTimeKind.Utc), new DateTime(year: 1953, month: 10, day: 12, hour: 14, minute: 57, second: 32, millisecond: 737, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1917, month: 10, day: 12, hour: 16, minute: 51, second: 2, millisecond: 864, kind: DateTimeKind.Utc), new DateTime(year: 1965, month: 10, day: 19, hour: 12, minute: 57, second: 35, millisecond: 191, kind: DateTimeKind.Utc), new DateTime(year: 1980, month: 10, day: 19, hour: 15, minute: 14, second: 57, millisecond: 792, kind: DateTimeKind.Utc), }, { new DateTime(year: 2014, month: 10, day: 13, hour: 21, minute: 31, second: 49, millisecond: 544, kind: DateTimeKind.Utc), new DateTime(year: 1951, month: 10, day: 4, hour: 17, minute: 21, second: 24, millisecond: 343, kind: DateTimeKind.Utc), new DateTime(year: 1967, month: 10, day: 19, hour: 1, minute: 51, second: 30, millisecond: 640, kind: DateTimeKind.Utc), }, { new DateTime(year: 2009, month: 10, day: 5, hour: 8, minute: 21, second: 39, millisecond: 423, kind: DateTimeKind.Utc), new DateTime(year: 2019, month: 10, day: 15, hour: 4, minute: 15, second: 11, millisecond: 797, kind: DateTimeKind.Utc), new DateTime(year: 1987, month: 10, day: 9, hour: 11, minute: 38, second: 51, millisecond: 697, kind: DateTimeKind.Utc), }, }, },
    ModelInner = new DateTimetimestamp_with_time_zoneMMArrayD3E1MI
{
    Id = 20,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1976, month: 10, day: 5, hour: 7, minute: 5, second: 39, millisecond: 980, kind: DateTimeKind.Utc), new DateTime(year: 1946, month: 10, day: 12, hour: 2, minute: 56, second: 30, millisecond: 488, kind: DateTimeKind.Utc), new DateTime(year: 1941, month: 10, day: 10, hour: 12, minute: 17, second: 39, millisecond: 455, kind: DateTimeKind.Utc), }, { new DateTime(year: 1978, month: 10, day: 13, hour: 21, minute: 34, second: 48, millisecond: 52, kind: DateTimeKind.Utc), new DateTime(year: 1996, month: 10, day: 19, hour: 19, minute: 4, second: 25, millisecond: 227, kind: DateTimeKind.Utc), new DateTime(year: 1987, month: 10, day: 18, hour: 16, minute: 54, second: 23, millisecond: 258, kind: DateTimeKind.Utc), }, { new DateTime(year: 1927, month: 10, day: 17, hour: 18, minute: 33, second: 2, millisecond: 585, kind: DateTimeKind.Utc), new DateTime(year: 1944, month: 10, day: 7, hour: 11, minute: 54, second: 23, millisecond: 590, kind: DateTimeKind.Utc), new DateTime(year: 2016, month: 10, day: 12, hour: 5, minute: 52, second: 13, millisecond: 101, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1928, month: 10, day: 3, hour: 1, minute: 39, second: 38, millisecond: 25, kind: DateTimeKind.Utc), new DateTime(year: 2012, month: 10, day: 7, hour: 17, minute: 27, second: 32, millisecond: 446, kind: DateTimeKind.Utc), new DateTime(year: 1997, month: 10, day: 14, hour: 22, minute: 35, second: 56, millisecond: 805, kind: DateTimeKind.Utc), }, { new DateTime(year: 1960, month: 10, day: 12, hour: 17, minute: 41, second: 51, millisecond: 377, kind: DateTimeKind.Utc), new DateTime(year: 1936, month: 10, day: 17, hour: 20, minute: 37, second: 36, millisecond: 916, kind: DateTimeKind.Utc), new DateTime(year: 1966, month: 10, day: 5, hour: 11, minute: 25, second: 17, millisecond: 470, kind: DateTimeKind.Utc), }, { new DateTime(year: 1968, month: 10, day: 14, hour: 3, minute: 53, second: 29, millisecond: 333, kind: DateTimeKind.Utc), new DateTime(year: 1946, month: 10, day: 10, hour: 3, minute: 58, second: 12, millisecond: 150, kind: DateTimeKind.Utc), new DateTime(year: 1974, month: 10, day: 8, hour: 9, minute: 35, second: 1, millisecond: 571, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1972, month: 10, day: 17, hour: 5, minute: 11, second: 35, millisecond: 743, kind: DateTimeKind.Utc), new DateTime(year: 1938, month: 10, day: 17, hour: 18, minute: 18, second: 31, millisecond: 988, kind: DateTimeKind.Utc), new DateTime(year: 1924, month: 10, day: 10, hour: 7, minute: 44, second: 24, millisecond: 398, kind: DateTimeKind.Utc), }, { new DateTime(year: 1952, month: 10, day: 13, hour: 15, minute: 54, second: 57, millisecond: 214, kind: DateTimeKind.Utc), new DateTime(year: 1986, month: 10, day: 12, hour: 8, minute: 45, second: 13, millisecond: 948, kind: DateTimeKind.Utc), new DateTime(year: 2003, month: 10, day: 11, hour: 22, minute: 57, second: 17, millisecond: 194, kind: DateTimeKind.Utc), }, { new DateTime(year: 1957, month: 10, day: 4, hour: 22, minute: 41, second: 21, millisecond: 592, kind: DateTimeKind.Utc), new DateTime(year: 2004, month: 10, day: 13, hour: 16, minute: 35, second: 50, millisecond: 206, kind: DateTimeKind.Utc), new DateTime(year: 1984, month: 10, day: 1, hour: 10, minute: 2, second: 27, millisecond: 696, kind: DateTimeKind.Utc), }, }, },
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1941, month: 10, day: 7, hour: 17, minute: 7, second: 10, millisecond: 507, kind: DateTimeKind.Utc), new DateTime(year: 1958, month: 10, day: 15, hour: 17, minute: 36, second: 52, millisecond: 702, kind: DateTimeKind.Utc), new DateTime(year: 1931, month: 10, day: 16, hour: 11, minute: 9, second: 10, millisecond: 864, kind: DateTimeKind.Utc), }, { new DateTime(year: 1935, month: 10, day: 19, hour: 3, minute: 41, second: 14, millisecond: 785, kind: DateTimeKind.Utc), new DateTime(year: 1959, month: 10, day: 17, hour: 10, minute: 36, second: 32, millisecond: 704, kind: DateTimeKind.Utc), new DateTime(year: 1924, month: 10, day: 4, hour: 6, minute: 17, second: 48, millisecond: 789, kind: DateTimeKind.Utc), }, { new DateTime(year: 1943, month: 10, day: 11, hour: 11, minute: 4, second: 26, millisecond: 940, kind: DateTimeKind.Utc), new DateTime(year: 2004, month: 10, day: 19, hour: 12, minute: 29, second: 24, millisecond: 699, kind: DateTimeKind.Utc), new DateTime(year: 1982, month: 10, day: 8, hour: 15, minute: 31, second: 31, millisecond: 756, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1982, month: 10, day: 17, hour: 14, minute: 33, second: 44, millisecond: 334, kind: DateTimeKind.Utc), new DateTime(year: 1930, month: 10, day: 19, hour: 20, minute: 33, second: 9, millisecond: 603, kind: DateTimeKind.Utc), new DateTime(year: 1970, month: 10, day: 6, hour: 3, minute: 11, second: 46, millisecond: 929, kind: DateTimeKind.Utc), }, { new DateTime(year: 2009, month: 10, day: 8, hour: 11, minute: 20, second: 44, millisecond: 389, kind: DateTimeKind.Utc), new DateTime(year: 1981, month: 10, day: 14, hour: 5, minute: 24, second: 12, millisecond: 105, kind: DateTimeKind.Utc), new DateTime(year: 1934, month: 10, day: 1, hour: 16, minute: 31, second: 23, millisecond: 557, kind: DateTimeKind.Utc), }, { new DateTime(year: 1923, month: 10, day: 7, hour: 14, minute: 49, second: 18, millisecond: 581, kind: DateTimeKind.Utc), new DateTime(year: 1921, month: 10, day: 7, hour: 9, minute: 46, second: 12, millisecond: 827, kind: DateTimeKind.Utc), new DateTime(year: 1934, month: 10, day: 8, hour: 9, minute: 54, second: 32, millisecond: 703, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1965, month: 10, day: 10, hour: 17, minute: 39, second: 37, millisecond: 807, kind: DateTimeKind.Utc), new DateTime(year: 1952, month: 10, day: 19, hour: 2, minute: 4, second: 14, millisecond: 538, kind: DateTimeKind.Utc), new DateTime(year: 1989, month: 10, day: 10, hour: 10, minute: 20, second: 21, millisecond: 922, kind: DateTimeKind.Utc), }, { new DateTime(year: 1983, month: 10, day: 11, hour: 14, minute: 18, second: 24, millisecond: 761, kind: DateTimeKind.Utc), new DateTime(year: 1948, month: 10, day: 15, hour: 10, minute: 3, second: 39, millisecond: 105, kind: DateTimeKind.Utc), new DateTime(year: 1930, month: 10, day: 12, hour: 14, minute: 58, second: 54, millisecond: 195, kind: DateTimeKind.Utc), }, { new DateTime(year: 1981, month: 10, day: 16, hour: 17, minute: 25, second: 7, millisecond: 426, kind: DateTimeKind.Utc), new DateTime(year: 1938, month: 10, day: 14, hour: 11, minute: 9, second: 47, millisecond: 636, kind: DateTimeKind.Utc), new DateTime(year: 1990, month: 10, day: 12, hour: 5, minute: 48, second: 57, millisecond: 980, kind: DateTimeKind.Utc), }, }, },
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneMMArrayD3E1M
{
    Id = 27,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1957, month: 10, day: 8, hour: 10, minute: 51, second: 21, millisecond: 968, kind: DateTimeKind.Utc), new DateTime(year: 1982, month: 10, day: 1, hour: 20, minute: 16, second: 29, millisecond: 170, kind: DateTimeKind.Utc), new DateTime(year: 1952, month: 10, day: 9, hour: 15, minute: 1, second: 57, millisecond: 506, kind: DateTimeKind.Utc), }, { new DateTime(year: 1954, month: 10, day: 15, hour: 3, minute: 36, second: 14, millisecond: 84, kind: DateTimeKind.Utc), new DateTime(year: 2002, month: 10, day: 7, hour: 21, minute: 35, second: 6, millisecond: 273, kind: DateTimeKind.Utc), new DateTime(year: 1918, month: 10, day: 1, hour: 6, minute: 5, second: 53, millisecond: 600, kind: DateTimeKind.Utc), }, { new DateTime(year: 2015, month: 10, day: 14, hour: 4, minute: 24, second: 55, millisecond: 909, kind: DateTimeKind.Utc), new DateTime(year: 1940, month: 10, day: 13, hour: 6, minute: 7, second: 48, millisecond: 485, kind: DateTimeKind.Utc), new DateTime(year: 2014, month: 10, day: 14, hour: 22, minute: 7, second: 56, millisecond: 499, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1919, month: 10, day: 14, hour: 3, minute: 33, second: 34, millisecond: 209, kind: DateTimeKind.Utc), new DateTime(year: 1940, month: 10, day: 11, hour: 16, minute: 15, second: 37, millisecond: 435, kind: DateTimeKind.Utc), new DateTime(year: 1976, month: 10, day: 17, hour: 2, minute: 55, second: 51, millisecond: 863, kind: DateTimeKind.Utc), }, { new DateTime(year: 1960, month: 10, day: 10, hour: 21, minute: 37, second: 45, millisecond: 207, kind: DateTimeKind.Utc), new DateTime(year: 2013, month: 10, day: 10, hour: 3, minute: 51, second: 2, millisecond: 599, kind: DateTimeKind.Utc), new DateTime(year: 1920, month: 10, day: 2, hour: 21, minute: 52, second: 4, millisecond: 960, kind: DateTimeKind.Utc), }, { new DateTime(year: 2003, month: 10, day: 9, hour: 2, minute: 25, second: 1, millisecond: 56, kind: DateTimeKind.Utc), new DateTime(year: 1974, month: 10, day: 7, hour: 2, minute: 55, second: 9, millisecond: 258, kind: DateTimeKind.Utc), new DateTime(year: 2006, month: 10, day: 12, hour: 5, minute: 5, second: 22, millisecond: 870, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 2017, month: 10, day: 7, hour: 21, minute: 24, second: 10, millisecond: 779, kind: DateTimeKind.Utc), new DateTime(year: 1975, month: 10, day: 7, hour: 15, minute: 8, second: 15, millisecond: 424, kind: DateTimeKind.Utc), new DateTime(year: 2005, month: 10, day: 4, hour: 18, minute: 14, second: 32, millisecond: 75, kind: DateTimeKind.Utc), }, { new DateTime(year: 2015, month: 10, day: 9, hour: 20, minute: 10, second: 1, millisecond: 943, kind: DateTimeKind.Utc), new DateTime(year: 1964, month: 10, day: 8, hour: 5, minute: 9, second: 37, millisecond: 572, kind: DateTimeKind.Utc), new DateTime(year: 2006, month: 10, day: 17, hour: 16, minute: 27, second: 21, millisecond: 72, kind: DateTimeKind.Utc), }, { new DateTime(year: 1970, month: 10, day: 13, hour: 2, minute: 34, second: 49, millisecond: 761, kind: DateTimeKind.Utc), new DateTime(year: 1942, month: 10, day: 4, hour: 19, minute: 42, second: 51, millisecond: 68, kind: DateTimeKind.Utc), new DateTime(year: 1988, month: 10, day: 14, hour: 9, minute: 20, second: 28, millisecond: 123, kind: DateTimeKind.Utc), }, }, },
    ModelInner = null,
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1923, month: 10, day: 6, hour: 3, minute: 49, second: 25, millisecond: 790, kind: DateTimeKind.Utc), new DateTime(year: 1921, month: 10, day: 4, hour: 12, minute: 15, second: 10, millisecond: 752, kind: DateTimeKind.Utc), new DateTime(year: 1985, month: 10, day: 3, hour: 17, minute: 1, second: 14, millisecond: 934, kind: DateTimeKind.Utc), }, { new DateTime(year: 1988, month: 10, day: 19, hour: 11, minute: 10, second: 49, millisecond: 854, kind: DateTimeKind.Utc), new DateTime(year: 1978, month: 10, day: 2, hour: 2, minute: 46, second: 36, millisecond: 510, kind: DateTimeKind.Utc), new DateTime(year: 1955, month: 10, day: 11, hour: 2, minute: 29, second: 28, millisecond: 677, kind: DateTimeKind.Utc), }, { new DateTime(year: 1939, month: 10, day: 8, hour: 11, minute: 30, second: 46, millisecond: 167, kind: DateTimeKind.Utc), new DateTime(year: 2016, month: 10, day: 8, hour: 7, minute: 50, second: 45, millisecond: 51, kind: DateTimeKind.Utc), new DateTime(year: 2017, month: 10, day: 17, hour: 9, minute: 2, second: 29, millisecond: 162, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 2000, month: 10, day: 8, hour: 9, minute: 49, second: 32, millisecond: 704, kind: DateTimeKind.Utc), new DateTime(year: 2013, month: 10, day: 7, hour: 2, minute: 35, second: 29, millisecond: 542, kind: DateTimeKind.Utc), new DateTime(year: 1986, month: 10, day: 7, hour: 5, minute: 31, second: 13, millisecond: 690, kind: DateTimeKind.Utc), }, { new DateTime(year: 1998, month: 10, day: 14, hour: 10, minute: 28, second: 8, millisecond: 467, kind: DateTimeKind.Utc), new DateTime(year: 1922, month: 10, day: 10, hour: 6, minute: 8, second: 45, millisecond: 593, kind: DateTimeKind.Utc), new DateTime(year: 1966, month: 10, day: 3, hour: 10, minute: 43, second: 17, millisecond: 196, kind: DateTimeKind.Utc), }, { new DateTime(year: 1939, month: 10, day: 5, hour: 1, minute: 8, second: 24, millisecond: 54, kind: DateTimeKind.Utc), new DateTime(year: 1955, month: 10, day: 14, hour: 18, minute: 21, second: 6, millisecond: 312, kind: DateTimeKind.Utc), new DateTime(year: 1940, month: 10, day: 1, hour: 13, minute: 49, second: 33, millisecond: 453, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1977, month: 10, day: 2, hour: 10, minute: 47, second: 55, millisecond: 785, kind: DateTimeKind.Utc), new DateTime(year: 1970, month: 10, day: 7, hour: 14, minute: 31, second: 52, millisecond: 223, kind: DateTimeKind.Utc), new DateTime(year: 1951, month: 10, day: 9, hour: 11, minute: 39, second: 28, millisecond: 701, kind: DateTimeKind.Utc), }, { new DateTime(year: 1990, month: 10, day: 11, hour: 16, minute: 7, second: 54, millisecond: 220, kind: DateTimeKind.Utc), new DateTime(year: 1925, month: 10, day: 2, hour: 7, minute: 58, second: 24, millisecond: 246, kind: DateTimeKind.Utc), new DateTime(year: 1942, month: 10, day: 19, hour: 7, minute: 51, second: 21, millisecond: 661, kind: DateTimeKind.Utc), }, { new DateTime(year: 1956, month: 10, day: 2, hour: 22, minute: 2, second: 31, millisecond: 709, kind: DateTimeKind.Utc), new DateTime(year: 1957, month: 10, day: 1, hour: 21, minute: 24, second: 52, millisecond: 82, kind: DateTimeKind.Utc), new DateTime(year: 1981, month: 10, day: 1, hour: 4, minute: 54, second: 5, millisecond: 571, kind: DateTimeKind.Utc), }, }, },
},
            new DateTimetimestamp_with_time_zoneMMArrayD3E1M
{
    Id = 36,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1926, month: 10, day: 8, hour: 5, minute: 26, second: 18, millisecond: 890, kind: DateTimeKind.Utc), new DateTime(year: 1959, month: 10, day: 13, hour: 15, minute: 51, second: 30, millisecond: 243, kind: DateTimeKind.Utc), new DateTime(year: 1995, month: 10, day: 9, hour: 18, minute: 2, second: 19, millisecond: 265, kind: DateTimeKind.Utc), }, { new DateTime(year: 1943, month: 10, day: 1, hour: 1, minute: 8, second: 47, millisecond: 785, kind: DateTimeKind.Utc), new DateTime(year: 1924, month: 10, day: 5, hour: 8, minute: 25, second: 29, millisecond: 29, kind: DateTimeKind.Utc), new DateTime(year: 1973, month: 10, day: 1, hour: 12, minute: 23, second: 44, millisecond: 812, kind: DateTimeKind.Utc), }, { new DateTime(year: 1927, month: 10, day: 6, hour: 22, minute: 40, second: 22, millisecond: 447, kind: DateTimeKind.Utc), new DateTime(year: 2006, month: 10, day: 6, hour: 15, minute: 8, second: 13, millisecond: 794, kind: DateTimeKind.Utc), new DateTime(year: 1994, month: 10, day: 8, hour: 4, minute: 39, second: 11, millisecond: 38, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1918, month: 10, day: 8, hour: 6, minute: 22, second: 43, millisecond: 872, kind: DateTimeKind.Utc), new DateTime(year: 1922, month: 10, day: 6, hour: 13, minute: 36, second: 26, millisecond: 7, kind: DateTimeKind.Utc), new DateTime(year: 1957, month: 10, day: 6, hour: 5, minute: 45, second: 56, millisecond: 886, kind: DateTimeKind.Utc), }, { new DateTime(year: 2007, month: 10, day: 3, hour: 11, minute: 58, second: 38, millisecond: 421, kind: DateTimeKind.Utc), new DateTime(year: 1934, month: 10, day: 8, hour: 13, minute: 49, second: 58, millisecond: 21, kind: DateTimeKind.Utc), new DateTime(year: 1981, month: 10, day: 18, hour: 13, minute: 42, second: 3, millisecond: 677, kind: DateTimeKind.Utc), }, { new DateTime(year: 1917, month: 10, day: 14, hour: 5, minute: 7, second: 32, millisecond: 59, kind: DateTimeKind.Utc), new DateTime(year: 1991, month: 10, day: 5, hour: 6, minute: 14, second: 23, millisecond: 276, kind: DateTimeKind.Utc), new DateTime(year: 1951, month: 10, day: 12, hour: 16, minute: 26, second: 55, millisecond: 621, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1990, month: 10, day: 12, hour: 20, minute: 47, second: 1, millisecond: 195, kind: DateTimeKind.Utc), new DateTime(year: 2004, month: 10, day: 10, hour: 5, minute: 41, second: 44, millisecond: 188, kind: DateTimeKind.Utc), new DateTime(year: 1971, month: 10, day: 15, hour: 20, minute: 44, second: 43, millisecond: 797, kind: DateTimeKind.Utc), }, { new DateTime(year: 1984, month: 10, day: 5, hour: 20, minute: 39, second: 22, millisecond: 247, kind: DateTimeKind.Utc), new DateTime(year: 1994, month: 10, day: 19, hour: 14, minute: 50, second: 45, millisecond: 142, kind: DateTimeKind.Utc), new DateTime(year: 2016, month: 10, day: 15, hour: 15, minute: 22, second: 55, millisecond: 825, kind: DateTimeKind.Utc), }, { new DateTime(year: 1995, month: 10, day: 14, hour: 19, minute: 9, second: 46, millisecond: 859, kind: DateTimeKind.Utc), new DateTime(year: 1969, month: 10, day: 11, hour: 13, minute: 36, second: 22, millisecond: 711, kind: DateTimeKind.Utc), new DateTime(year: 1949, month: 10, day: 4, hour: 9, minute: 1, second: 40, millisecond: 55, kind: DateTimeKind.Utc), }, }, },
    ModelInner = new DateTimetimestamp_with_time_zoneMMArrayD3E1MI
{
    Id = 25,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1985, month: 10, day: 18, hour: 10, minute: 47, second: 12, millisecond: 97, kind: DateTimeKind.Utc), new DateTime(year: 1983, month: 10, day: 6, hour: 8, minute: 14, second: 25, millisecond: 297, kind: DateTimeKind.Utc), new DateTime(year: 1923, month: 10, day: 14, hour: 4, minute: 43, second: 43, millisecond: 130, kind: DateTimeKind.Utc), }, { new DateTime(year: 1935, month: 10, day: 1, hour: 4, minute: 11, second: 53, millisecond: 758, kind: DateTimeKind.Utc), new DateTime(year: 1969, month: 10, day: 6, hour: 20, minute: 47, second: 7, millisecond: 338, kind: DateTimeKind.Utc), new DateTime(year: 1984, month: 10, day: 12, hour: 9, minute: 44, second: 4, millisecond: 475, kind: DateTimeKind.Utc), }, { new DateTime(year: 1995, month: 10, day: 17, hour: 10, minute: 12, second: 53, millisecond: 915, kind: DateTimeKind.Utc), new DateTime(year: 1995, month: 10, day: 17, hour: 22, minute: 4, second: 30, millisecond: 710, kind: DateTimeKind.Utc), new DateTime(year: 2012, month: 10, day: 6, hour: 21, minute: 39, second: 9, millisecond: 841, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1919, month: 10, day: 7, hour: 9, minute: 27, second: 10, millisecond: 476, kind: DateTimeKind.Utc), new DateTime(year: 1973, month: 10, day: 17, hour: 5, minute: 49, second: 54, millisecond: 843, kind: DateTimeKind.Utc), new DateTime(year: 2007, month: 10, day: 18, hour: 21, minute: 21, second: 52, millisecond: 170, kind: DateTimeKind.Utc), }, { new DateTime(year: 1991, month: 10, day: 17, hour: 17, minute: 15, second: 34, millisecond: 553, kind: DateTimeKind.Utc), new DateTime(year: 1989, month: 10, day: 3, hour: 11, minute: 8, second: 8, millisecond: 31, kind: DateTimeKind.Utc), new DateTime(year: 2001, month: 10, day: 4, hour: 12, minute: 6, second: 6, millisecond: 629, kind: DateTimeKind.Utc), }, { new DateTime(year: 2018, month: 10, day: 4, hour: 9, minute: 28, second: 24, millisecond: 774, kind: DateTimeKind.Utc), new DateTime(year: 1946, month: 10, day: 19, hour: 6, minute: 48, second: 51, millisecond: 74, kind: DateTimeKind.Utc), new DateTime(year: 1964, month: 10, day: 11, hour: 8, minute: 29, second: 12, millisecond: 723, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1938, month: 10, day: 7, hour: 21, minute: 37, second: 53, millisecond: 271, kind: DateTimeKind.Utc), new DateTime(year: 1981, month: 10, day: 7, hour: 5, minute: 1, second: 19, millisecond: 706, kind: DateTimeKind.Utc), new DateTime(year: 1947, month: 10, day: 8, hour: 12, minute: 3, second: 2, millisecond: 727, kind: DateTimeKind.Utc), }, { new DateTime(year: 1920, month: 10, day: 16, hour: 4, minute: 19, second: 6, millisecond: 370, kind: DateTimeKind.Utc), new DateTime(year: 1948, month: 10, day: 15, hour: 5, minute: 47, second: 3, millisecond: 170, kind: DateTimeKind.Utc), new DateTime(year: 2012, month: 10, day: 18, hour: 3, minute: 49, second: 22, millisecond: 140, kind: DateTimeKind.Utc), }, { new DateTime(year: 2004, month: 10, day: 16, hour: 22, minute: 39, second: 16, millisecond: 629, kind: DateTimeKind.Utc), new DateTime(year: 1917, month: 10, day: 4, hour: 8, minute: 34, second: 29, millisecond: 392, kind: DateTimeKind.Utc), new DateTime(year: 2005, month: 10, day: 11, hour: 4, minute: 32, second: 34, millisecond: 864, kind: DateTimeKind.Utc), }, }, },
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1938, month: 10, day: 14, hour: 10, minute: 45, second: 28, millisecond: 492, kind: DateTimeKind.Utc), new DateTime(year: 1922, month: 10, day: 17, hour: 16, minute: 30, second: 51, millisecond: 285, kind: DateTimeKind.Utc), new DateTime(year: 1976, month: 10, day: 2, hour: 5, minute: 26, second: 49, millisecond: 258, kind: DateTimeKind.Utc), }, { new DateTime(year: 1955, month: 10, day: 12, hour: 16, minute: 48, second: 41, millisecond: 858, kind: DateTimeKind.Utc), new DateTime(year: 2005, month: 10, day: 8, hour: 22, minute: 4, second: 31, millisecond: 128, kind: DateTimeKind.Utc), new DateTime(year: 1975, month: 10, day: 18, hour: 6, minute: 45, second: 44, millisecond: 941, kind: DateTimeKind.Utc), }, { new DateTime(year: 1974, month: 10, day: 7, hour: 11, minute: 11, second: 53, millisecond: 550, kind: DateTimeKind.Utc), new DateTime(year: 2001, month: 10, day: 13, hour: 22, minute: 34, second: 16, millisecond: 861, kind: DateTimeKind.Utc), new DateTime(year: 1987, month: 10, day: 14, hour: 18, minute: 23, second: 35, millisecond: 424, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1992, month: 10, day: 3, hour: 17, minute: 34, second: 17, millisecond: 59, kind: DateTimeKind.Utc), new DateTime(year: 2007, month: 10, day: 17, hour: 15, minute: 56, second: 12, millisecond: 402, kind: DateTimeKind.Utc), new DateTime(year: 1953, month: 10, day: 4, hour: 11, minute: 14, second: 41, millisecond: 643, kind: DateTimeKind.Utc), }, { new DateTime(year: 1932, month: 10, day: 14, hour: 22, minute: 28, second: 15, millisecond: 326, kind: DateTimeKind.Utc), new DateTime(year: 1958, month: 10, day: 14, hour: 3, minute: 40, second: 15, millisecond: 652, kind: DateTimeKind.Utc), new DateTime(year: 1942, month: 10, day: 14, hour: 3, minute: 48, second: 35, millisecond: 764, kind: DateTimeKind.Utc), }, { new DateTime(year: 1961, month: 10, day: 11, hour: 1, minute: 2, second: 46, millisecond: 652, kind: DateTimeKind.Utc), new DateTime(year: 1995, month: 10, day: 15, hour: 9, minute: 39, second: 48, millisecond: 917, kind: DateTimeKind.Utc), new DateTime(year: 2016, month: 10, day: 12, hour: 3, minute: 31, second: 11, millisecond: 365, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1972, month: 10, day: 4, hour: 21, minute: 32, second: 28, millisecond: 661, kind: DateTimeKind.Utc), new DateTime(year: 1991, month: 10, day: 10, hour: 4, minute: 35, second: 54, millisecond: 53, kind: DateTimeKind.Utc), new DateTime(year: 1972, month: 10, day: 14, hour: 19, minute: 56, second: 55, millisecond: 645, kind: DateTimeKind.Utc), }, { new DateTime(year: 1990, month: 10, day: 10, hour: 14, minute: 21, second: 41, millisecond: 218, kind: DateTimeKind.Utc), new DateTime(year: 1931, month: 10, day: 14, hour: 8, minute: 1, second: 46, millisecond: 339, kind: DateTimeKind.Utc), new DateTime(year: 1917, month: 10, day: 6, hour: 2, minute: 23, second: 6, millisecond: 580, kind: DateTimeKind.Utc), }, { new DateTime(year: 1979, month: 10, day: 11, hour: 12, minute: 6, second: 43, millisecond: 286, kind: DateTimeKind.Utc), new DateTime(year: 1990, month: 10, day: 7, hour: 22, minute: 20, second: 40, millisecond: 918, kind: DateTimeKind.Utc), new DateTime(year: 1982, month: 10, day: 19, hour: 7, minute: 56, second: 22, millisecond: 863, kind: DateTimeKind.Utc), }, }, },
},
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1920, month: 10, day: 10, hour: 3, minute: 34, second: 12, millisecond: 214, kind: DateTimeKind.Utc), new DateTime(year: 1995, month: 10, day: 9, hour: 2, minute: 22, second: 50, millisecond: 591, kind: DateTimeKind.Utc), new DateTime(year: 1942, month: 10, day: 19, hour: 12, minute: 48, second: 7, millisecond: 204, kind: DateTimeKind.Utc), }, { new DateTime(year: 1934, month: 10, day: 3, hour: 12, minute: 24, second: 1, millisecond: 750, kind: DateTimeKind.Utc), new DateTime(year: 1946, month: 10, day: 2, hour: 5, minute: 49, second: 41, millisecond: 82, kind: DateTimeKind.Utc), new DateTime(year: 1993, month: 10, day: 15, hour: 3, minute: 3, second: 54, millisecond: 411, kind: DateTimeKind.Utc), }, { new DateTime(year: 1949, month: 10, day: 7, hour: 6, minute: 25, second: 30, millisecond: 6, kind: DateTimeKind.Utc), new DateTime(year: 1962, month: 10, day: 12, hour: 6, minute: 11, second: 23, millisecond: 25, kind: DateTimeKind.Utc), new DateTime(year: 1966, month: 10, day: 10, hour: 7, minute: 20, second: 19, millisecond: 156, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1982, month: 10, day: 3, hour: 9, minute: 7, second: 4, millisecond: 505, kind: DateTimeKind.Utc), new DateTime(year: 1942, month: 10, day: 14, hour: 16, minute: 19, second: 20, millisecond: 678, kind: DateTimeKind.Utc), new DateTime(year: 1982, month: 10, day: 17, hour: 10, minute: 19, second: 44, millisecond: 572, kind: DateTimeKind.Utc), }, { new DateTime(year: 1998, month: 10, day: 16, hour: 20, minute: 19, second: 19, millisecond: 328, kind: DateTimeKind.Utc), new DateTime(year: 1980, month: 10, day: 19, hour: 1, minute: 10, second: 2, millisecond: 67, kind: DateTimeKind.Utc), new DateTime(year: 1969, month: 10, day: 9, hour: 8, minute: 26, second: 11, millisecond: 482, kind: DateTimeKind.Utc), }, { new DateTime(year: 1951, month: 10, day: 1, hour: 21, minute: 24, second: 36, millisecond: 221, kind: DateTimeKind.Utc), new DateTime(year: 1985, month: 10, day: 5, hour: 6, minute: 48, second: 20, millisecond: 56, kind: DateTimeKind.Utc), new DateTime(year: 1928, month: 10, day: 7, hour: 22, minute: 37, second: 13, millisecond: 359, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1946, month: 10, day: 17, hour: 4, minute: 38, second: 23, millisecond: 492, kind: DateTimeKind.Utc), new DateTime(year: 1928, month: 10, day: 14, hour: 14, minute: 56, second: 23, millisecond: 144, kind: DateTimeKind.Utc), new DateTime(year: 1972, month: 10, day: 6, hour: 16, minute: 48, second: 26, millisecond: 11, kind: DateTimeKind.Utc), }, { new DateTime(year: 1997, month: 10, day: 15, hour: 19, minute: 37, second: 18, millisecond: 286, kind: DateTimeKind.Utc), new DateTime(year: 1996, month: 10, day: 6, hour: 5, minute: 30, second: 52, millisecond: 932, kind: DateTimeKind.Utc), new DateTime(year: 1952, month: 10, day: 1, hour: 19, minute: 17, second: 29, millisecond: 471, kind: DateTimeKind.Utc), }, { new DateTime(year: 1962, month: 10, day: 7, hour: 18, minute: 44, second: 43, millisecond: 89, kind: DateTimeKind.Utc), new DateTime(year: 1924, month: 10, day: 1, hour: 9, minute: 36, second: 11, millisecond: 828, kind: DateTimeKind.Utc), new DateTime(year: 1939, month: 10, day: 11, hour: 5, minute: 34, second: 28, millisecond: 147, kind: DateTimeKind.Utc), }, }, },
},
            new DateTimetimestamp_with_time_zoneMMArrayD3E1M
{
    Id = 41,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1997, month: 10, day: 7, hour: 18, minute: 52, second: 10, millisecond: 274, kind: DateTimeKind.Utc), new DateTime(year: 1954, month: 10, day: 16, hour: 15, minute: 57, second: 57, millisecond: 801, kind: DateTimeKind.Utc), new DateTime(year: 1995, month: 10, day: 17, hour: 13, minute: 32, second: 49, millisecond: 657, kind: DateTimeKind.Utc), }, { new DateTime(year: 1934, month: 10, day: 2, hour: 11, minute: 34, second: 38, millisecond: 859, kind: DateTimeKind.Utc), new DateTime(year: 1966, month: 10, day: 14, hour: 15, minute: 7, second: 38, millisecond: 328, kind: DateTimeKind.Utc), new DateTime(year: 1945, month: 10, day: 15, hour: 15, minute: 12, second: 47, millisecond: 844, kind: DateTimeKind.Utc), }, { new DateTime(year: 2013, month: 10, day: 17, hour: 11, minute: 45, second: 33, millisecond: 696, kind: DateTimeKind.Utc), new DateTime(year: 1984, month: 10, day: 6, hour: 1, minute: 38, second: 31, millisecond: 753, kind: DateTimeKind.Utc), new DateTime(year: 1934, month: 10, day: 3, hour: 7, minute: 12, second: 48, millisecond: 95, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1922, month: 10, day: 8, hour: 1, minute: 46, second: 37, millisecond: 310, kind: DateTimeKind.Utc), new DateTime(year: 2004, month: 10, day: 7, hour: 6, minute: 43, second: 47, millisecond: 228, kind: DateTimeKind.Utc), new DateTime(year: 1918, month: 10, day: 4, hour: 17, minute: 50, second: 52, millisecond: 932, kind: DateTimeKind.Utc), }, { new DateTime(year: 1937, month: 10, day: 13, hour: 13, minute: 3, second: 55, millisecond: 69, kind: DateTimeKind.Utc), new DateTime(year: 1948, month: 10, day: 9, hour: 16, minute: 22, second: 39, millisecond: 280, kind: DateTimeKind.Utc), new DateTime(year: 1957, month: 10, day: 14, hour: 21, minute: 9, second: 51, millisecond: 546, kind: DateTimeKind.Utc), }, { new DateTime(year: 1970, month: 10, day: 11, hour: 17, minute: 53, second: 44, millisecond: 979, kind: DateTimeKind.Utc), new DateTime(year: 1993, month: 10, day: 1, hour: 11, minute: 22, second: 4, millisecond: 856, kind: DateTimeKind.Utc), new DateTime(year: 1960, month: 10, day: 8, hour: 15, minute: 54, second: 15, millisecond: 786, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1951, month: 10, day: 17, hour: 11, minute: 30, second: 31, millisecond: 648, kind: DateTimeKind.Utc), new DateTime(year: 1925, month: 10, day: 7, hour: 19, minute: 4, second: 42, millisecond: 555, kind: DateTimeKind.Utc), new DateTime(year: 1944, month: 10, day: 5, hour: 5, minute: 27, second: 27, millisecond: 167, kind: DateTimeKind.Utc), }, { new DateTime(year: 1929, month: 10, day: 19, hour: 10, minute: 41, second: 24, millisecond: 859, kind: DateTimeKind.Utc), new DateTime(year: 1992, month: 10, day: 15, hour: 9, minute: 52, second: 32, millisecond: 933, kind: DateTimeKind.Utc), new DateTime(year: 1918, month: 10, day: 6, hour: 20, minute: 30, second: 56, millisecond: 384, kind: DateTimeKind.Utc), }, { new DateTime(year: 1985, month: 10, day: 1, hour: 13, minute: 6, second: 22, millisecond: 173, kind: DateTimeKind.Utc), new DateTime(year: 2015, month: 10, day: 16, hour: 7, minute: 12, second: 28, millisecond: 249, kind: DateTimeKind.Utc), new DateTime(year: 2019, month: 10, day: 14, hour: 22, minute: 29, second: 47, millisecond: 671, kind: DateTimeKind.Utc), }, }, },
    ModelInner = null,
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1967, month: 10, day: 17, hour: 10, minute: 7, second: 40, millisecond: 912, kind: DateTimeKind.Utc), new DateTime(year: 1978, month: 10, day: 19, hour: 13, minute: 19, second: 48, millisecond: 128, kind: DateTimeKind.Utc), new DateTime(year: 1960, month: 10, day: 16, hour: 3, minute: 50, second: 54, millisecond: 504, kind: DateTimeKind.Utc), }, { new DateTime(year: 1930, month: 10, day: 11, hour: 1, minute: 40, second: 29, millisecond: 323, kind: DateTimeKind.Utc), new DateTime(year: 1951, month: 10, day: 19, hour: 22, minute: 40, second: 2, millisecond: 308, kind: DateTimeKind.Utc), new DateTime(year: 1936, month: 10, day: 8, hour: 9, minute: 24, second: 36, millisecond: 703, kind: DateTimeKind.Utc), }, { new DateTime(year: 1992, month: 10, day: 12, hour: 10, minute: 33, second: 8, millisecond: 355, kind: DateTimeKind.Utc), new DateTime(year: 1944, month: 10, day: 4, hour: 8, minute: 46, second: 11, millisecond: 190, kind: DateTimeKind.Utc), new DateTime(year: 2004, month: 10, day: 18, hour: 9, minute: 38, second: 26, millisecond: 153, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1951, month: 10, day: 4, hour: 19, minute: 26, second: 30, millisecond: 726, kind: DateTimeKind.Utc), new DateTime(year: 2012, month: 10, day: 6, hour: 16, minute: 15, second: 49, millisecond: 14, kind: DateTimeKind.Utc), new DateTime(year: 1940, month: 10, day: 18, hour: 12, minute: 11, second: 22, millisecond: 812, kind: DateTimeKind.Utc), }, { new DateTime(year: 1994, month: 10, day: 10, hour: 19, minute: 3, second: 6, millisecond: 644, kind: DateTimeKind.Utc), new DateTime(year: 1939, month: 10, day: 15, hour: 14, minute: 11, second: 31, millisecond: 704, kind: DateTimeKind.Utc), new DateTime(year: 2017, month: 10, day: 4, hour: 4, minute: 58, second: 29, millisecond: 211, kind: DateTimeKind.Utc), }, { new DateTime(year: 1955, month: 10, day: 14, hour: 8, minute: 40, second: 1, millisecond: 986, kind: DateTimeKind.Utc), new DateTime(year: 1944, month: 10, day: 9, hour: 9, minute: 53, second: 11, millisecond: 448, kind: DateTimeKind.Utc), new DateTime(year: 1979, month: 10, day: 14, hour: 3, minute: 35, second: 6, millisecond: 884, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1998, month: 10, day: 16, hour: 21, minute: 38, second: 3, millisecond: 446, kind: DateTimeKind.Utc), new DateTime(year: 1942, month: 10, day: 19, hour: 2, minute: 5, second: 5, millisecond: 201, kind: DateTimeKind.Utc), new DateTime(year: 1944, month: 10, day: 18, hour: 13, minute: 50, second: 14, millisecond: 728, kind: DateTimeKind.Utc), }, { new DateTime(year: 1928, month: 10, day: 15, hour: 3, minute: 37, second: 39, millisecond: 815, kind: DateTimeKind.Utc), new DateTime(year: 1980, month: 10, day: 2, hour: 16, minute: 54, second: 53, millisecond: 164, kind: DateTimeKind.Utc), new DateTime(year: 1953, month: 10, day: 14, hour: 4, minute: 31, second: 49, millisecond: 492, kind: DateTimeKind.Utc), }, { new DateTime(year: 1968, month: 10, day: 3, hour: 6, minute: 47, second: 2, millisecond: 481, kind: DateTimeKind.Utc), new DateTime(year: 1981, month: 10, day: 17, hour: 17, minute: 43, second: 32, millisecond: 842, kind: DateTimeKind.Utc), new DateTime(year: 1970, month: 10, day: 8, hour: 11, minute: 37, second: 54, millisecond: 211, kind: DateTimeKind.Utc), }, }, },
},
            new DateTimetimestamp_with_time_zoneMMArrayD3E1M
{
    Id = 42,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1958, month: 10, day: 19, hour: 17, minute: 53, second: 22, millisecond: 209, kind: DateTimeKind.Utc), new DateTime(year: 1959, month: 10, day: 12, hour: 9, minute: 6, second: 13, millisecond: 278, kind: DateTimeKind.Utc), new DateTime(year: 1927, month: 10, day: 10, hour: 17, minute: 18, second: 9, millisecond: 438, kind: DateTimeKind.Utc), }, { new DateTime(year: 1969, month: 10, day: 18, hour: 19, minute: 51, second: 58, millisecond: 653, kind: DateTimeKind.Utc), new DateTime(year: 1997, month: 10, day: 4, hour: 7, minute: 16, second: 46, millisecond: 461, kind: DateTimeKind.Utc), new DateTime(year: 1956, month: 10, day: 11, hour: 2, minute: 39, second: 6, millisecond: 192, kind: DateTimeKind.Utc), }, { new DateTime(year: 1927, month: 10, day: 10, hour: 9, minute: 5, second: 41, millisecond: 552, kind: DateTimeKind.Utc), new DateTime(year: 2003, month: 10, day: 7, hour: 7, minute: 57, second: 10, millisecond: 466, kind: DateTimeKind.Utc), new DateTime(year: 1932, month: 10, day: 1, hour: 18, minute: 52, second: 55, millisecond: 271, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1957, month: 10, day: 4, hour: 4, minute: 50, second: 24, millisecond: 364, kind: DateTimeKind.Utc), new DateTime(year: 1957, month: 10, day: 14, hour: 21, minute: 1, second: 38, millisecond: 633, kind: DateTimeKind.Utc), new DateTime(year: 1959, month: 10, day: 8, hour: 21, minute: 28, second: 34, millisecond: 427, kind: DateTimeKind.Utc), }, { new DateTime(year: 1948, month: 10, day: 19, hour: 3, minute: 18, second: 25, millisecond: 379, kind: DateTimeKind.Utc), new DateTime(year: 2015, month: 10, day: 14, hour: 12, minute: 19, second: 3, millisecond: 834, kind: DateTimeKind.Utc), new DateTime(year: 1949, month: 10, day: 1, hour: 9, minute: 36, second: 35, millisecond: 172, kind: DateTimeKind.Utc), }, { new DateTime(year: 1989, month: 10, day: 4, hour: 22, minute: 9, second: 22, millisecond: 244, kind: DateTimeKind.Utc), new DateTime(year: 1965, month: 10, day: 13, hour: 6, minute: 39, second: 3, millisecond: 561, kind: DateTimeKind.Utc), new DateTime(year: 1927, month: 10, day: 13, hour: 21, minute: 26, second: 52, millisecond: 531, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 2008, month: 10, day: 15, hour: 4, minute: 53, second: 30, millisecond: 888, kind: DateTimeKind.Utc), new DateTime(year: 1923, month: 10, day: 14, hour: 20, minute: 54, second: 13, millisecond: 8, kind: DateTimeKind.Utc), new DateTime(year: 1982, month: 10, day: 6, hour: 7, minute: 6, second: 50, millisecond: 355, kind: DateTimeKind.Utc), }, { new DateTime(year: 1985, month: 10, day: 13, hour: 4, minute: 48, second: 57, millisecond: 500, kind: DateTimeKind.Utc), new DateTime(year: 1930, month: 10, day: 1, hour: 11, minute: 48, second: 45, millisecond: 294, kind: DateTimeKind.Utc), new DateTime(year: 1921, month: 10, day: 11, hour: 1, minute: 27, second: 56, millisecond: 143, kind: DateTimeKind.Utc), }, { new DateTime(year: 2008, month: 10, day: 7, hour: 16, minute: 46, second: 7, millisecond: 137, kind: DateTimeKind.Utc), new DateTime(year: 2005, month: 10, day: 15, hour: 1, minute: 27, second: 12, millisecond: 563, kind: DateTimeKind.Utc), new DateTime(year: 1923, month: 10, day: 15, hour: 3, minute: 52, second: 49, millisecond: 728, kind: DateTimeKind.Utc), }, }, },
    ModelInner = new DateTimetimestamp_with_time_zoneMMArrayD3E1MI
{
    Id = 33,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 2013, month: 10, day: 17, hour: 3, minute: 18, second: 28, millisecond: 988, kind: DateTimeKind.Utc), new DateTime(year: 1927, month: 10, day: 8, hour: 13, minute: 33, second: 29, millisecond: 694, kind: DateTimeKind.Utc), new DateTime(year: 1959, month: 10, day: 4, hour: 20, minute: 42, second: 50, millisecond: 368, kind: DateTimeKind.Utc), }, { new DateTime(year: 1957, month: 10, day: 14, hour: 8, minute: 50, second: 37, millisecond: 400, kind: DateTimeKind.Utc), new DateTime(year: 1976, month: 10, day: 9, hour: 19, minute: 33, second: 27, millisecond: 66, kind: DateTimeKind.Utc), new DateTime(year: 1951, month: 10, day: 12, hour: 1, minute: 58, second: 54, millisecond: 882, kind: DateTimeKind.Utc), }, { new DateTime(year: 1943, month: 10, day: 19, hour: 19, minute: 11, second: 7, millisecond: 194, kind: DateTimeKind.Utc), new DateTime(year: 2007, month: 10, day: 8, hour: 19, minute: 50, second: 27, millisecond: 146, kind: DateTimeKind.Utc), new DateTime(year: 1917, month: 10, day: 15, hour: 11, minute: 19, second: 39, millisecond: 987, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 2003, month: 10, day: 8, hour: 6, minute: 11, second: 35, millisecond: 86, kind: DateTimeKind.Utc), new DateTime(year: 2018, month: 10, day: 11, hour: 10, minute: 36, second: 1, millisecond: 117, kind: DateTimeKind.Utc), new DateTime(year: 2019, month: 10, day: 19, hour: 1, minute: 4, second: 33, millisecond: 121, kind: DateTimeKind.Utc), }, { new DateTime(year: 1996, month: 10, day: 8, hour: 4, minute: 28, second: 10, millisecond: 710, kind: DateTimeKind.Utc), new DateTime(year: 1998, month: 10, day: 5, hour: 10, minute: 57, second: 19, millisecond: 240, kind: DateTimeKind.Utc), new DateTime(year: 1996, month: 10, day: 3, hour: 21, minute: 33, second: 5, millisecond: 990, kind: DateTimeKind.Utc), }, { new DateTime(year: 1970, month: 10, day: 18, hour: 7, minute: 17, second: 49, millisecond: 766, kind: DateTimeKind.Utc), new DateTime(year: 1965, month: 10, day: 9, hour: 15, minute: 58, second: 26, millisecond: 8, kind: DateTimeKind.Utc), new DateTime(year: 1962, month: 10, day: 1, hour: 20, minute: 42, second: 35, millisecond: 922, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1940, month: 10, day: 4, hour: 20, minute: 21, second: 34, millisecond: 337, kind: DateTimeKind.Utc), new DateTime(year: 1982, month: 10, day: 16, hour: 20, minute: 6, second: 34, millisecond: 548, kind: DateTimeKind.Utc), new DateTime(year: 1961, month: 10, day: 5, hour: 9, minute: 9, second: 35, millisecond: 995, kind: DateTimeKind.Utc), }, { new DateTime(year: 1993, month: 10, day: 8, hour: 9, minute: 35, second: 39, millisecond: 953, kind: DateTimeKind.Utc), new DateTime(year: 1998, month: 10, day: 8, hour: 13, minute: 38, second: 3, millisecond: 313, kind: DateTimeKind.Utc), new DateTime(year: 1976, month: 10, day: 16, hour: 12, minute: 48, second: 30, millisecond: 690, kind: DateTimeKind.Utc), }, { new DateTime(year: 1963, month: 10, day: 4, hour: 1, minute: 44, second: 29, millisecond: 208, kind: DateTimeKind.Utc), new DateTime(year: 1953, month: 10, day: 10, hour: 1, minute: 12, second: 24, millisecond: 441, kind: DateTimeKind.Utc), new DateTime(year: 1934, month: 10, day: 17, hour: 17, minute: 34, second: 12, millisecond: 11, kind: DateTimeKind.Utc), }, }, },
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1948, month: 10, day: 7, hour: 12, minute: 47, second: 53, millisecond: 546, kind: DateTimeKind.Utc), new DateTime(year: 2004, month: 10, day: 12, hour: 1, minute: 43, second: 26, millisecond: 680, kind: DateTimeKind.Utc), new DateTime(year: 1928, month: 10, day: 3, hour: 9, minute: 22, second: 23, millisecond: 38, kind: DateTimeKind.Utc), }, { new DateTime(year: 1986, month: 10, day: 14, hour: 15, minute: 43, second: 2, millisecond: 960, kind: DateTimeKind.Utc), new DateTime(year: 1953, month: 10, day: 12, hour: 4, minute: 58, second: 9, millisecond: 188, kind: DateTimeKind.Utc), new DateTime(year: 2006, month: 10, day: 11, hour: 1, minute: 55, second: 24, millisecond: 611, kind: DateTimeKind.Utc), }, { new DateTime(year: 1939, month: 10, day: 9, hour: 18, minute: 18, second: 15, millisecond: 698, kind: DateTimeKind.Utc), new DateTime(year: 1942, month: 10, day: 15, hour: 19, minute: 15, second: 26, millisecond: 71, kind: DateTimeKind.Utc), new DateTime(year: 1955, month: 10, day: 9, hour: 16, minute: 52, second: 35, millisecond: 462, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 2019, month: 10, day: 10, hour: 21, minute: 35, second: 49, millisecond: 268, kind: DateTimeKind.Utc), new DateTime(year: 1959, month: 10, day: 5, hour: 6, minute: 31, second: 9, millisecond: 454, kind: DateTimeKind.Utc), new DateTime(year: 2016, month: 10, day: 7, hour: 8, minute: 31, second: 51, millisecond: 92, kind: DateTimeKind.Utc), }, { new DateTime(year: 1984, month: 10, day: 5, hour: 3, minute: 44, second: 41, millisecond: 245, kind: DateTimeKind.Utc), new DateTime(year: 1952, month: 10, day: 1, hour: 10, minute: 47, second: 46, millisecond: 659, kind: DateTimeKind.Utc), new DateTime(year: 1974, month: 10, day: 13, hour: 11, minute: 37, second: 41, millisecond: 302, kind: DateTimeKind.Utc), }, { new DateTime(year: 1954, month: 10, day: 2, hour: 17, minute: 58, second: 51, millisecond: 416, kind: DateTimeKind.Utc), new DateTime(year: 1943, month: 10, day: 18, hour: 11, minute: 5, second: 36, millisecond: 627, kind: DateTimeKind.Utc), new DateTime(year: 1993, month: 10, day: 6, hour: 15, minute: 7, second: 16, millisecond: 139, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1938, month: 10, day: 4, hour: 16, minute: 48, second: 16, millisecond: 258, kind: DateTimeKind.Utc), new DateTime(year: 1992, month: 10, day: 3, hour: 17, minute: 11, second: 2, millisecond: 442, kind: DateTimeKind.Utc), new DateTime(year: 1979, month: 10, day: 6, hour: 19, minute: 16, second: 56, millisecond: 992, kind: DateTimeKind.Utc), }, { new DateTime(year: 1963, month: 10, day: 9, hour: 10, minute: 32, second: 11, millisecond: 752, kind: DateTimeKind.Utc), new DateTime(year: 1969, month: 10, day: 3, hour: 17, minute: 24, second: 28, millisecond: 75, kind: DateTimeKind.Utc), new DateTime(year: 1998, month: 10, day: 17, hour: 20, minute: 56, second: 15, millisecond: 771, kind: DateTimeKind.Utc), }, { new DateTime(year: 1994, month: 10, day: 12, hour: 10, minute: 40, second: 46, millisecond: 790, kind: DateTimeKind.Utc), new DateTime(year: 1925, month: 10, day: 18, hour: 20, minute: 23, second: 28, millisecond: 560, kind: DateTimeKind.Utc), new DateTime(year: 1942, month: 10, day: 3, hour: 22, minute: 14, second: 8, millisecond: 50, kind: DateTimeKind.Utc), }, }, },
},
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1971, month: 10, day: 4, hour: 1, minute: 58, second: 17, millisecond: 647, kind: DateTimeKind.Utc), new DateTime(year: 1964, month: 10, day: 17, hour: 1, minute: 30, second: 30, millisecond: 786, kind: DateTimeKind.Utc), new DateTime(year: 1958, month: 10, day: 4, hour: 5, minute: 25, second: 10, millisecond: 871, kind: DateTimeKind.Utc), }, { new DateTime(year: 1922, month: 10, day: 13, hour: 12, minute: 8, second: 13, millisecond: 987, kind: DateTimeKind.Utc), new DateTime(year: 1921, month: 10, day: 17, hour: 1, minute: 43, second: 25, millisecond: 564, kind: DateTimeKind.Utc), new DateTime(year: 2017, month: 10, day: 15, hour: 17, minute: 15, second: 41, millisecond: 870, kind: DateTimeKind.Utc), }, { new DateTime(year: 1990, month: 10, day: 6, hour: 2, minute: 23, second: 32, millisecond: 697, kind: DateTimeKind.Utc), new DateTime(year: 1927, month: 10, day: 11, hour: 9, minute: 28, second: 24, millisecond: 13, kind: DateTimeKind.Utc), new DateTime(year: 1919, month: 10, day: 1, hour: 19, minute: 25, second: 28, millisecond: 270, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1980, month: 10, day: 14, hour: 17, minute: 5, second: 43, millisecond: 459, kind: DateTimeKind.Utc), new DateTime(year: 1958, month: 10, day: 15, hour: 18, minute: 27, second: 37, millisecond: 627, kind: DateTimeKind.Utc), new DateTime(year: 2016, month: 10, day: 19, hour: 6, minute: 43, second: 39, millisecond: 880, kind: DateTimeKind.Utc), }, { new DateTime(year: 1927, month: 10, day: 18, hour: 16, minute: 47, second: 16, millisecond: 330, kind: DateTimeKind.Utc), new DateTime(year: 1976, month: 10, day: 13, hour: 19, minute: 30, second: 48, millisecond: 915, kind: DateTimeKind.Utc), new DateTime(year: 1980, month: 10, day: 5, hour: 3, minute: 1, second: 17, millisecond: 651, kind: DateTimeKind.Utc), }, { new DateTime(year: 1986, month: 10, day: 16, hour: 13, minute: 3, second: 52, millisecond: 745, kind: DateTimeKind.Utc), new DateTime(year: 1955, month: 10, day: 13, hour: 15, minute: 21, second: 15, millisecond: 696, kind: DateTimeKind.Utc), new DateTime(year: 1980, month: 10, day: 7, hour: 12, minute: 58, second: 58, millisecond: 692, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1992, month: 10, day: 6, hour: 10, minute: 38, second: 44, millisecond: 560, kind: DateTimeKind.Utc), new DateTime(year: 1942, month: 10, day: 10, hour: 4, minute: 27, second: 56, millisecond: 794, kind: DateTimeKind.Utc), new DateTime(year: 1972, month: 10, day: 19, hour: 6, minute: 13, second: 48, millisecond: 237, kind: DateTimeKind.Utc), }, { new DateTime(year: 1947, month: 10, day: 10, hour: 15, minute: 26, second: 42, millisecond: 199, kind: DateTimeKind.Utc), new DateTime(year: 2006, month: 10, day: 11, hour: 2, minute: 35, second: 38, millisecond: 872, kind: DateTimeKind.Utc), new DateTime(year: 1938, month: 10, day: 8, hour: 4, minute: 20, second: 12, millisecond: 142, kind: DateTimeKind.Utc), }, { new DateTime(year: 1928, month: 10, day: 19, hour: 8, minute: 45, second: 9, millisecond: 968, kind: DateTimeKind.Utc), new DateTime(year: 1982, month: 10, day: 18, hour: 20, minute: 27, second: 48, millisecond: 259, kind: DateTimeKind.Utc), new DateTime(year: 2010, month: 10, day: 16, hour: 3, minute: 54, second: 29, millisecond: 521, kind: DateTimeKind.Utc), }, }, },
},
            new DateTimetimestamp_with_time_zoneMMArrayD3E1M
{
    Id = 50,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1933, month: 10, day: 13, hour: 8, minute: 54, second: 37, millisecond: 456, kind: DateTimeKind.Utc), new DateTime(year: 1941, month: 10, day: 13, hour: 12, minute: 27, second: 4, millisecond: 313, kind: DateTimeKind.Utc), new DateTime(year: 1985, month: 10, day: 4, hour: 16, minute: 44, second: 11, millisecond: 497, kind: DateTimeKind.Utc), }, { new DateTime(year: 1985, month: 10, day: 17, hour: 10, minute: 3, second: 3, millisecond: 908, kind: DateTimeKind.Utc), new DateTime(year: 1956, month: 10, day: 12, hour: 15, minute: 39, second: 16, millisecond: 448, kind: DateTimeKind.Utc), new DateTime(year: 2012, month: 10, day: 12, hour: 17, minute: 20, second: 45, millisecond: 709, kind: DateTimeKind.Utc), }, { new DateTime(year: 1942, month: 10, day: 17, hour: 18, minute: 8, second: 8, millisecond: 854, kind: DateTimeKind.Utc), new DateTime(year: 1928, month: 10, day: 19, hour: 9, minute: 29, second: 23, millisecond: 239, kind: DateTimeKind.Utc), new DateTime(year: 1949, month: 10, day: 11, hour: 16, minute: 41, second: 1, millisecond: 81, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1924, month: 10, day: 17, hour: 19, minute: 21, second: 45, millisecond: 493, kind: DateTimeKind.Utc), new DateTime(year: 1995, month: 10, day: 1, hour: 20, minute: 14, second: 39, millisecond: 564, kind: DateTimeKind.Utc), new DateTime(year: 1974, month: 10, day: 14, hour: 7, minute: 7, second: 35, millisecond: 410, kind: DateTimeKind.Utc), }, { new DateTime(year: 1934, month: 10, day: 8, hour: 9, minute: 54, second: 16, millisecond: 619, kind: DateTimeKind.Utc), new DateTime(year: 1945, month: 10, day: 3, hour: 14, minute: 36, second: 12, millisecond: 87, kind: DateTimeKind.Utc), new DateTime(year: 1928, month: 10, day: 2, hour: 16, minute: 53, second: 51, millisecond: 333, kind: DateTimeKind.Utc), }, { new DateTime(year: 1928, month: 10, day: 9, hour: 5, minute: 50, second: 26, millisecond: 727, kind: DateTimeKind.Utc), new DateTime(year: 1962, month: 10, day: 2, hour: 6, minute: 57, second: 4, millisecond: 850, kind: DateTimeKind.Utc), new DateTime(year: 1972, month: 10, day: 18, hour: 22, minute: 17, second: 6, millisecond: 809, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1996, month: 10, day: 4, hour: 16, minute: 42, second: 58, millisecond: 509, kind: DateTimeKind.Utc), new DateTime(year: 2017, month: 10, day: 14, hour: 20, minute: 29, second: 14, millisecond: 834, kind: DateTimeKind.Utc), new DateTime(year: 1919, month: 10, day: 11, hour: 9, minute: 37, second: 11, millisecond: 73, kind: DateTimeKind.Utc), }, { new DateTime(year: 1948, month: 10, day: 13, hour: 7, minute: 17, second: 12, millisecond: 667, kind: DateTimeKind.Utc), new DateTime(year: 2017, month: 10, day: 4, hour: 2, minute: 36, second: 47, millisecond: 78, kind: DateTimeKind.Utc), new DateTime(year: 2004, month: 10, day: 18, hour: 10, minute: 55, second: 43, millisecond: 71, kind: DateTimeKind.Utc), }, { new DateTime(year: 1970, month: 10, day: 4, hour: 17, minute: 53, second: 6, millisecond: 736, kind: DateTimeKind.Utc), new DateTime(year: 1941, month: 10, day: 12, hour: 2, minute: 56, second: 13, millisecond: 674, kind: DateTimeKind.Utc), new DateTime(year: 1947, month: 10, day: 3, hour: 19, minute: 3, second: 11, millisecond: 206, kind: DateTimeKind.Utc), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneMMArrayD3E1M
{
    Id = 53,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 2019, month: 10, day: 4, hour: 10, minute: 14, second: 53, millisecond: 466, kind: DateTimeKind.Utc), new DateTime(year: 1925, month: 10, day: 10, hour: 9, minute: 19, second: 22, millisecond: 284, kind: DateTimeKind.Utc), new DateTime(year: 1979, month: 10, day: 9, hour: 19, minute: 34, second: 26, millisecond: 821, kind: DateTimeKind.Utc), }, { new DateTime(year: 1980, month: 10, day: 15, hour: 9, minute: 56, second: 54, millisecond: 940, kind: DateTimeKind.Utc), new DateTime(year: 1918, month: 10, day: 3, hour: 20, minute: 36, second: 42, millisecond: 417, kind: DateTimeKind.Utc), new DateTime(year: 1928, month: 10, day: 18, hour: 21, minute: 56, second: 52, millisecond: 560, kind: DateTimeKind.Utc), }, { new DateTime(year: 1972, month: 10, day: 10, hour: 16, minute: 55, second: 57, millisecond: 117, kind: DateTimeKind.Utc), new DateTime(year: 1959, month: 10, day: 14, hour: 3, minute: 14, second: 3, millisecond: 205, kind: DateTimeKind.Utc), new DateTime(year: 1971, month: 10, day: 18, hour: 20, minute: 29, second: 37, millisecond: 645, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 2012, month: 10, day: 9, hour: 12, minute: 53, second: 37, millisecond: 457, kind: DateTimeKind.Utc), new DateTime(year: 1956, month: 10, day: 3, hour: 18, minute: 52, second: 54, millisecond: 730, kind: DateTimeKind.Utc), new DateTime(year: 1925, month: 10, day: 3, hour: 20, minute: 53, second: 53, millisecond: 320, kind: DateTimeKind.Utc), }, { new DateTime(year: 1919, month: 10, day: 18, hour: 11, minute: 53, second: 25, millisecond: 686, kind: DateTimeKind.Utc), new DateTime(year: 1923, month: 10, day: 10, hour: 15, minute: 24, second: 6, millisecond: 145, kind: DateTimeKind.Utc), new DateTime(year: 1973, month: 10, day: 6, hour: 5, minute: 6, second: 29, millisecond: 612, kind: DateTimeKind.Utc), }, { new DateTime(year: 1993, month: 10, day: 16, hour: 13, minute: 46, second: 7, millisecond: 32, kind: DateTimeKind.Utc), new DateTime(year: 1978, month: 10, day: 14, hour: 3, minute: 42, second: 52, millisecond: 897, kind: DateTimeKind.Utc), new DateTime(year: 2015, month: 10, day: 13, hour: 4, minute: 20, second: 5, millisecond: 575, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1962, month: 10, day: 12, hour: 9, minute: 49, second: 18, millisecond: 106, kind: DateTimeKind.Utc), new DateTime(year: 1983, month: 10, day: 3, hour: 2, minute: 23, second: 29, millisecond: 334, kind: DateTimeKind.Utc), new DateTime(year: 1964, month: 10, day: 19, hour: 22, minute: 54, second: 53, millisecond: 952, kind: DateTimeKind.Utc), }, { new DateTime(year: 1975, month: 10, day: 18, hour: 8, minute: 5, second: 39, millisecond: 363, kind: DateTimeKind.Utc), new DateTime(year: 2011, month: 10, day: 6, hour: 15, minute: 37, second: 29, millisecond: 40, kind: DateTimeKind.Utc), new DateTime(year: 1919, month: 10, day: 17, hour: 19, minute: 38, second: 25, millisecond: 188, kind: DateTimeKind.Utc), }, { new DateTime(year: 1952, month: 10, day: 18, hour: 20, minute: 37, second: 53, millisecond: 195, kind: DateTimeKind.Utc), new DateTime(year: 1927, month: 10, day: 4, hour: 16, minute: 3, second: 7, millisecond: 939, kind: DateTimeKind.Utc), new DateTime(year: 2019, month: 10, day: 12, hour: 4, minute: 31, second: 5, millisecond: 619, kind: DateTimeKind.Utc), }, }, },
    ModelInner = new DateTimetimestamp_with_time_zoneMMArrayD3E1MI
{
    Id = 41,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1975, month: 10, day: 19, hour: 8, minute: 54, second: 26, millisecond: 871, kind: DateTimeKind.Utc), new DateTime(year: 1922, month: 10, day: 11, hour: 6, minute: 4, second: 50, millisecond: 393, kind: DateTimeKind.Utc), new DateTime(year: 1946, month: 10, day: 1, hour: 11, minute: 46, second: 41, millisecond: 549, kind: DateTimeKind.Utc), }, { new DateTime(year: 1972, month: 10, day: 19, hour: 20, minute: 12, second: 17, millisecond: 109, kind: DateTimeKind.Utc), new DateTime(year: 1954, month: 10, day: 11, hour: 11, minute: 49, second: 15, millisecond: 742, kind: DateTimeKind.Utc), new DateTime(year: 1921, month: 10, day: 6, hour: 12, minute: 51, second: 48, millisecond: 420, kind: DateTimeKind.Utc), }, { new DateTime(year: 1999, month: 10, day: 3, hour: 12, minute: 52, second: 18, millisecond: 427, kind: DateTimeKind.Utc), new DateTime(year: 2002, month: 10, day: 15, hour: 11, minute: 24, second: 33, millisecond: 458, kind: DateTimeKind.Utc), new DateTime(year: 2012, month: 10, day: 2, hour: 10, minute: 1, second: 18, millisecond: 209, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 2010, month: 10, day: 15, hour: 3, minute: 30, second: 7, millisecond: 164, kind: DateTimeKind.Utc), new DateTime(year: 1976, month: 10, day: 5, hour: 19, minute: 6, second: 42, millisecond: 324, kind: DateTimeKind.Utc), new DateTime(year: 1971, month: 10, day: 2, hour: 7, minute: 56, second: 14, millisecond: 78, kind: DateTimeKind.Utc), }, { new DateTime(year: 1924, month: 10, day: 13, hour: 2, minute: 8, second: 53, millisecond: 791, kind: DateTimeKind.Utc), new DateTime(year: 2019, month: 10, day: 6, hour: 5, minute: 19, second: 39, millisecond: 692, kind: DateTimeKind.Utc), new DateTime(year: 1953, month: 10, day: 9, hour: 20, minute: 54, second: 46, millisecond: 660, kind: DateTimeKind.Utc), }, { new DateTime(year: 1986, month: 10, day: 19, hour: 12, minute: 38, second: 17, millisecond: 504, kind: DateTimeKind.Utc), new DateTime(year: 1929, month: 10, day: 1, hour: 21, minute: 44, second: 25, millisecond: 647, kind: DateTimeKind.Utc), new DateTime(year: 1983, month: 10, day: 17, hour: 22, minute: 22, second: 56, millisecond: 348, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1944, month: 10, day: 12, hour: 19, minute: 26, second: 18, millisecond: 967, kind: DateTimeKind.Utc), new DateTime(year: 2007, month: 10, day: 13, hour: 2, minute: 7, second: 25, millisecond: 767, kind: DateTimeKind.Utc), new DateTime(year: 2010, month: 10, day: 19, hour: 17, minute: 52, second: 14, millisecond: 909, kind: DateTimeKind.Utc), }, { new DateTime(year: 1936, month: 10, day: 2, hour: 10, minute: 12, second: 25, millisecond: 599, kind: DateTimeKind.Utc), new DateTime(year: 1923, month: 10, day: 19, hour: 15, minute: 41, second: 48, millisecond: 418, kind: DateTimeKind.Utc), new DateTime(year: 1976, month: 10, day: 19, hour: 20, minute: 16, second: 24, millisecond: 548, kind: DateTimeKind.Utc), }, { new DateTime(year: 2012, month: 10, day: 13, hour: 13, minute: 27, second: 5, millisecond: 685, kind: DateTimeKind.Utc), new DateTime(year: 1938, month: 10, day: 18, hour: 3, minute: 29, second: 49, millisecond: 323, kind: DateTimeKind.Utc), new DateTime(year: 2005, month: 10, day: 15, hour: 21, minute: 49, second: 24, millisecond: 495, kind: DateTimeKind.Utc), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneMMArrayD3E1M
{
    Id = 61,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 2003, month: 10, day: 5, hour: 20, minute: 42, second: 8, millisecond: 841, kind: DateTimeKind.Utc), new DateTime(year: 2013, month: 10, day: 5, hour: 10, minute: 51, second: 22, millisecond: 769, kind: DateTimeKind.Utc), new DateTime(year: 2006, month: 10, day: 11, hour: 2, minute: 21, second: 32, millisecond: 99, kind: DateTimeKind.Utc), }, { new DateTime(year: 2018, month: 10, day: 14, hour: 19, minute: 53, second: 56, millisecond: 279, kind: DateTimeKind.Utc), new DateTime(year: 1933, month: 10, day: 2, hour: 5, minute: 4, second: 53, millisecond: 981, kind: DateTimeKind.Utc), new DateTime(year: 1978, month: 10, day: 8, hour: 18, minute: 44, second: 31, millisecond: 402, kind: DateTimeKind.Utc), }, { new DateTime(year: 2000, month: 10, day: 6, hour: 10, minute: 29, second: 44, millisecond: 179, kind: DateTimeKind.Utc), new DateTime(year: 1962, month: 10, day: 2, hour: 21, minute: 45, second: 50, millisecond: 930, kind: DateTimeKind.Utc), new DateTime(year: 1977, month: 10, day: 3, hour: 6, minute: 14, second: 27, millisecond: 437, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1962, month: 10, day: 2, hour: 10, minute: 21, second: 35, millisecond: 168, kind: DateTimeKind.Utc), new DateTime(year: 2018, month: 10, day: 19, hour: 22, minute: 18, second: 21, millisecond: 296, kind: DateTimeKind.Utc), new DateTime(year: 1931, month: 10, day: 10, hour: 5, minute: 5, second: 39, millisecond: 521, kind: DateTimeKind.Utc), }, { new DateTime(year: 1986, month: 10, day: 13, hour: 13, minute: 6, second: 40, millisecond: 176, kind: DateTimeKind.Utc), new DateTime(year: 1955, month: 10, day: 14, hour: 12, minute: 42, second: 22, millisecond: 447, kind: DateTimeKind.Utc), new DateTime(year: 2006, month: 10, day: 17, hour: 9, minute: 55, second: 57, millisecond: 337, kind: DateTimeKind.Utc), }, { new DateTime(year: 1934, month: 10, day: 10, hour: 21, minute: 40, second: 25, millisecond: 702, kind: DateTimeKind.Utc), new DateTime(year: 1975, month: 10, day: 15, hour: 19, minute: 26, second: 21, millisecond: 672, kind: DateTimeKind.Utc), new DateTime(year: 2004, month: 10, day: 4, hour: 13, minute: 54, second: 12, millisecond: 726, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1961, month: 10, day: 7, hour: 17, minute: 22, second: 33, millisecond: 873, kind: DateTimeKind.Utc), new DateTime(year: 2007, month: 10, day: 8, hour: 20, minute: 44, second: 19, millisecond: 543, kind: DateTimeKind.Utc), new DateTime(year: 2001, month: 10, day: 6, hour: 10, minute: 13, second: 50, millisecond: 877, kind: DateTimeKind.Utc), }, { new DateTime(year: 1963, month: 10, day: 8, hour: 3, minute: 48, second: 43, millisecond: 107, kind: DateTimeKind.Utc), new DateTime(year: 2000, month: 10, day: 11, hour: 21, minute: 12, second: 24, millisecond: 394, kind: DateTimeKind.Utc), new DateTime(year: 1936, month: 10, day: 4, hour: 2, minute: 51, second: 10, millisecond: 324, kind: DateTimeKind.Utc), }, { new DateTime(year: 2010, month: 10, day: 5, hour: 11, minute: 26, second: 38, millisecond: 904, kind: DateTimeKind.Utc), new DateTime(year: 1984, month: 10, day: 3, hour: 5, minute: 19, second: 9, millisecond: 254, kind: DateTimeKind.Utc), new DateTime(year: 2002, month: 10, day: 16, hour: 15, minute: 33, second: 29, millisecond: 701, kind: DateTimeKind.Utc), }, }, },
    ModelInner = null,
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 2005, month: 10, day: 1, hour: 2, minute: 4, second: 38, millisecond: 504, kind: DateTimeKind.Utc), new DateTime(year: 1963, month: 10, day: 1, hour: 5, minute: 14, second: 5, millisecond: 689, kind: DateTimeKind.Utc), new DateTime(year: 1929, month: 10, day: 5, hour: 19, minute: 35, second: 43, millisecond: 865, kind: DateTimeKind.Utc), }, { new DateTime(year: 1966, month: 10, day: 9, hour: 18, minute: 45, second: 5, millisecond: 498, kind: DateTimeKind.Utc), new DateTime(year: 2000, month: 10, day: 5, hour: 11, minute: 31, second: 37, millisecond: 31, kind: DateTimeKind.Utc), new DateTime(year: 1996, month: 10, day: 3, hour: 13, minute: 24, second: 33, millisecond: 963, kind: DateTimeKind.Utc), }, { new DateTime(year: 1982, month: 10, day: 18, hour: 11, minute: 25, second: 15, millisecond: 102, kind: DateTimeKind.Utc), new DateTime(year: 1936, month: 10, day: 6, hour: 15, minute: 19, second: 32, millisecond: 404, kind: DateTimeKind.Utc), new DateTime(year: 1989, month: 10, day: 10, hour: 5, minute: 12, second: 30, millisecond: 732, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1943, month: 10, day: 6, hour: 20, minute: 56, second: 48, millisecond: 359, kind: DateTimeKind.Utc), new DateTime(year: 1943, month: 10, day: 3, hour: 12, minute: 35, second: 31, millisecond: 77, kind: DateTimeKind.Utc), new DateTime(year: 1926, month: 10, day: 1, hour: 13, minute: 13, second: 10, millisecond: 233, kind: DateTimeKind.Utc), }, { new DateTime(year: 1979, month: 10, day: 13, hour: 20, minute: 28, second: 8, millisecond: 170, kind: DateTimeKind.Utc), new DateTime(year: 1998, month: 10, day: 7, hour: 22, minute: 29, second: 2, millisecond: 629, kind: DateTimeKind.Utc), new DateTime(year: 1971, month: 10, day: 16, hour: 21, minute: 20, second: 15, millisecond: 190, kind: DateTimeKind.Utc), }, { new DateTime(year: 2000, month: 10, day: 12, hour: 3, minute: 3, second: 9, millisecond: 72, kind: DateTimeKind.Utc), new DateTime(year: 1991, month: 10, day: 7, hour: 10, minute: 42, second: 35, millisecond: 530, kind: DateTimeKind.Utc), new DateTime(year: 1918, month: 10, day: 9, hour: 10, minute: 34, second: 26, millisecond: 734, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1971, month: 10, day: 16, hour: 7, minute: 8, second: 26, millisecond: 576, kind: DateTimeKind.Utc), new DateTime(year: 1956, month: 10, day: 18, hour: 1, minute: 28, second: 56, millisecond: 896, kind: DateTimeKind.Utc), new DateTime(year: 1917, month: 10, day: 4, hour: 15, minute: 1, second: 42, millisecond: 794, kind: DateTimeKind.Utc), }, { new DateTime(year: 1935, month: 10, day: 2, hour: 21, minute: 46, second: 15, millisecond: 169, kind: DateTimeKind.Utc), new DateTime(year: 1944, month: 10, day: 15, hour: 9, minute: 15, second: 12, millisecond: 632, kind: DateTimeKind.Utc), new DateTime(year: 1941, month: 10, day: 18, hour: 1, minute: 46, second: 52, millisecond: 257, kind: DateTimeKind.Utc), }, { new DateTime(year: 1999, month: 10, day: 9, hour: 15, minute: 29, second: 38, millisecond: 235, kind: DateTimeKind.Utc), new DateTime(year: 1949, month: 10, day: 6, hour: 10, minute: 10, second: 33, millisecond: 613, kind: DateTimeKind.Utc), new DateTime(year: 1972, month: 10, day: 3, hour: 8, minute: 5, second: 50, millisecond: 660, kind: DateTimeKind.Utc), }, }, },
},
            new DateTimetimestamp_with_time_zoneMMArrayD3E1M
{
    Id = 64,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1946, month: 10, day: 4, hour: 19, minute: 1, second: 11, millisecond: 781, kind: DateTimeKind.Utc), new DateTime(year: 1990, month: 10, day: 1, hour: 9, minute: 25, second: 11, millisecond: 193, kind: DateTimeKind.Utc), new DateTime(year: 1932, month: 10, day: 19, hour: 19, minute: 49, second: 31, millisecond: 388, kind: DateTimeKind.Utc), }, { new DateTime(year: 1994, month: 10, day: 11, hour: 1, minute: 13, second: 39, millisecond: 121, kind: DateTimeKind.Utc), new DateTime(year: 1945, month: 10, day: 17, hour: 20, minute: 22, second: 7, millisecond: 645, kind: DateTimeKind.Utc), new DateTime(year: 1983, month: 10, day: 15, hour: 21, minute: 48, second: 19, millisecond: 810, kind: DateTimeKind.Utc), }, { new DateTime(year: 1938, month: 10, day: 16, hour: 3, minute: 8, second: 38, millisecond: 101, kind: DateTimeKind.Utc), new DateTime(year: 2005, month: 10, day: 17, hour: 5, minute: 24, second: 35, millisecond: 50, kind: DateTimeKind.Utc), new DateTime(year: 1983, month: 10, day: 11, hour: 8, minute: 9, second: 50, millisecond: 681, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1969, month: 10, day: 10, hour: 19, minute: 39, second: 37, millisecond: 769, kind: DateTimeKind.Utc), new DateTime(year: 1924, month: 10, day: 4, hour: 22, minute: 26, second: 43, millisecond: 470, kind: DateTimeKind.Utc), new DateTime(year: 1951, month: 10, day: 11, hour: 12, minute: 53, second: 6, millisecond: 927, kind: DateTimeKind.Utc), }, { new DateTime(year: 1939, month: 10, day: 9, hour: 9, minute: 48, second: 38, millisecond: 20, kind: DateTimeKind.Utc), new DateTime(year: 1984, month: 10, day: 6, hour: 21, minute: 27, second: 41, millisecond: 502, kind: DateTimeKind.Utc), new DateTime(year: 1997, month: 10, day: 12, hour: 9, minute: 25, second: 20, millisecond: 446, kind: DateTimeKind.Utc), }, { new DateTime(year: 2012, month: 10, day: 1, hour: 17, minute: 37, second: 32, millisecond: 717, kind: DateTimeKind.Utc), new DateTime(year: 2019, month: 10, day: 6, hour: 4, minute: 40, second: 49, millisecond: 954, kind: DateTimeKind.Utc), new DateTime(year: 1949, month: 10, day: 9, hour: 10, minute: 1, second: 34, millisecond: 302, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1927, month: 10, day: 15, hour: 18, minute: 46, second: 51, millisecond: 846, kind: DateTimeKind.Utc), new DateTime(year: 2011, month: 10, day: 19, hour: 16, minute: 13, second: 3, millisecond: 566, kind: DateTimeKind.Utc), new DateTime(year: 2015, month: 10, day: 17, hour: 7, minute: 45, second: 58, millisecond: 253, kind: DateTimeKind.Utc), }, { new DateTime(year: 2004, month: 10, day: 11, hour: 4, minute: 38, second: 49, millisecond: 33, kind: DateTimeKind.Utc), new DateTime(year: 1919, month: 10, day: 18, hour: 14, minute: 31, second: 9, millisecond: 930, kind: DateTimeKind.Utc), new DateTime(year: 1984, month: 10, day: 12, hour: 21, minute: 55, second: 19, millisecond: 672, kind: DateTimeKind.Utc), }, { new DateTime(year: 2016, month: 10, day: 12, hour: 16, minute: 49, second: 28, millisecond: 595, kind: DateTimeKind.Utc), new DateTime(year: 1977, month: 10, day: 5, hour: 4, minute: 26, second: 53, millisecond: 612, kind: DateTimeKind.Utc), new DateTime(year: 1919, month: 10, day: 16, hour: 19, minute: 57, second: 29, millisecond: 867, kind: DateTimeKind.Utc), }, }, },
    ModelInner = new DateTimetimestamp_with_time_zoneMMArrayD3E1MI
{
    Id = 46,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1917, month: 10, day: 10, hour: 10, minute: 24, second: 30, millisecond: 227, kind: DateTimeKind.Utc), new DateTime(year: 2006, month: 10, day: 7, hour: 2, minute: 6, second: 33, millisecond: 667, kind: DateTimeKind.Utc), new DateTime(year: 1954, month: 10, day: 5, hour: 2, minute: 19, second: 46, millisecond: 287, kind: DateTimeKind.Utc), }, { new DateTime(year: 1976, month: 10, day: 1, hour: 20, minute: 9, second: 22, millisecond: 832, kind: DateTimeKind.Utc), new DateTime(year: 2018, month: 10, day: 7, hour: 12, minute: 31, second: 56, millisecond: 535, kind: DateTimeKind.Utc), new DateTime(year: 1998, month: 10, day: 1, hour: 7, minute: 32, second: 40, millisecond: 144, kind: DateTimeKind.Utc), }, { new DateTime(year: 1929, month: 10, day: 6, hour: 10, minute: 3, second: 16, millisecond: 589, kind: DateTimeKind.Utc), new DateTime(year: 2016, month: 10, day: 15, hour: 22, minute: 12, second: 41, millisecond: 843, kind: DateTimeKind.Utc), new DateTime(year: 1969, month: 10, day: 16, hour: 16, minute: 37, second: 23, millisecond: 358, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1935, month: 10, day: 10, hour: 21, minute: 5, second: 54, millisecond: 230, kind: DateTimeKind.Utc), new DateTime(year: 1962, month: 10, day: 8, hour: 11, minute: 33, second: 12, millisecond: 887, kind: DateTimeKind.Utc), new DateTime(year: 1946, month: 10, day: 5, hour: 12, minute: 21, second: 5, millisecond: 550, kind: DateTimeKind.Utc), }, { new DateTime(year: 1920, month: 10, day: 4, hour: 8, minute: 27, second: 20, millisecond: 875, kind: DateTimeKind.Utc), new DateTime(year: 1973, month: 10, day: 11, hour: 12, minute: 43, second: 15, millisecond: 989, kind: DateTimeKind.Utc), new DateTime(year: 1949, month: 10, day: 19, hour: 17, minute: 19, second: 3, millisecond: 427, kind: DateTimeKind.Utc), }, { new DateTime(year: 1930, month: 10, day: 3, hour: 6, minute: 3, second: 28, millisecond: 59, kind: DateTimeKind.Utc), new DateTime(year: 2018, month: 10, day: 6, hour: 15, minute: 23, second: 28, millisecond: 233, kind: DateTimeKind.Utc), new DateTime(year: 1947, month: 10, day: 19, hour: 12, minute: 58, second: 41, millisecond: 315, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1961, month: 10, day: 6, hour: 11, minute: 38, second: 13, millisecond: 731, kind: DateTimeKind.Utc), new DateTime(year: 2006, month: 10, day: 13, hour: 22, minute: 48, second: 12, millisecond: 920, kind: DateTimeKind.Utc), new DateTime(year: 1976, month: 10, day: 2, hour: 4, minute: 4, second: 17, millisecond: 934, kind: DateTimeKind.Utc), }, { new DateTime(year: 1956, month: 10, day: 19, hour: 1, minute: 40, second: 19, millisecond: 434, kind: DateTimeKind.Utc), new DateTime(year: 1993, month: 10, day: 11, hour: 6, minute: 7, second: 47, millisecond: 882, kind: DateTimeKind.Utc), new DateTime(year: 1921, month: 10, day: 2, hour: 18, minute: 12, second: 33, millisecond: 222, kind: DateTimeKind.Utc), }, { new DateTime(year: 1924, month: 10, day: 3, hour: 11, minute: 24, second: 3, millisecond: 198, kind: DateTimeKind.Utc), new DateTime(year: 1982, month: 10, day: 12, hour: 9, minute: 10, second: 37, millisecond: 378, kind: DateTimeKind.Utc), new DateTime(year: 1999, month: 10, day: 19, hour: 19, minute: 34, second: 31, millisecond: 334, kind: DateTimeKind.Utc), }, }, },
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1958, month: 10, day: 15, hour: 17, minute: 21, second: 31, millisecond: 210, kind: DateTimeKind.Utc), new DateTime(year: 1999, month: 10, day: 9, hour: 8, minute: 21, second: 36, millisecond: 195, kind: DateTimeKind.Utc), new DateTime(year: 1944, month: 10, day: 7, hour: 2, minute: 56, second: 32, millisecond: 516, kind: DateTimeKind.Utc), }, { new DateTime(year: 1954, month: 10, day: 8, hour: 11, minute: 13, second: 53, millisecond: 252, kind: DateTimeKind.Utc), new DateTime(year: 1919, month: 10, day: 6, hour: 12, minute: 5, second: 19, millisecond: 880, kind: DateTimeKind.Utc), new DateTime(year: 1969, month: 10, day: 14, hour: 12, minute: 19, second: 20, millisecond: 335, kind: DateTimeKind.Utc), }, { new DateTime(year: 1944, month: 10, day: 7, hour: 18, minute: 3, second: 1, millisecond: 620, kind: DateTimeKind.Utc), new DateTime(year: 2016, month: 10, day: 13, hour: 8, minute: 57, second: 21, millisecond: 747, kind: DateTimeKind.Utc), new DateTime(year: 1921, month: 10, day: 19, hour: 14, minute: 39, second: 54, millisecond: 612, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 2013, month: 10, day: 3, hour: 22, minute: 38, second: 24, millisecond: 113, kind: DateTimeKind.Utc), new DateTime(year: 1957, month: 10, day: 2, hour: 11, minute: 9, second: 48, millisecond: 694, kind: DateTimeKind.Utc), new DateTime(year: 1946, month: 10, day: 6, hour: 9, minute: 2, second: 25, millisecond: 896, kind: DateTimeKind.Utc), }, { new DateTime(year: 1995, month: 10, day: 12, hour: 16, minute: 36, second: 48, millisecond: 510, kind: DateTimeKind.Utc), new DateTime(year: 1947, month: 10, day: 19, hour: 20, minute: 27, second: 46, millisecond: 565, kind: DateTimeKind.Utc), new DateTime(year: 2011, month: 10, day: 16, hour: 1, minute: 19, second: 25, millisecond: 805, kind: DateTimeKind.Utc), }, { new DateTime(year: 1990, month: 10, day: 17, hour: 12, minute: 21, second: 17, millisecond: 975, kind: DateTimeKind.Utc), new DateTime(year: 2002, month: 10, day: 1, hour: 21, minute: 43, second: 18, millisecond: 325, kind: DateTimeKind.Utc), new DateTime(year: 1991, month: 10, day: 16, hour: 14, minute: 5, second: 11, millisecond: 133, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 2006, month: 10, day: 11, hour: 10, minute: 44, second: 29, millisecond: 159, kind: DateTimeKind.Utc), new DateTime(year: 1994, month: 10, day: 9, hour: 14, minute: 45, second: 14, millisecond: 668, kind: DateTimeKind.Utc), new DateTime(year: 1930, month: 10, day: 9, hour: 10, minute: 3, second: 48, millisecond: 190, kind: DateTimeKind.Utc), }, { new DateTime(year: 1972, month: 10, day: 3, hour: 9, minute: 31, second: 9, millisecond: 390, kind: DateTimeKind.Utc), new DateTime(year: 1949, month: 10, day: 7, hour: 9, minute: 13, second: 6, millisecond: 49, kind: DateTimeKind.Utc), new DateTime(year: 1987, month: 10, day: 6, hour: 12, minute: 25, second: 12, millisecond: 85, kind: DateTimeKind.Utc), }, { new DateTime(year: 1932, month: 10, day: 17, hour: 9, minute: 46, second: 38, millisecond: 252, kind: DateTimeKind.Utc), new DateTime(year: 2008, month: 10, day: 5, hour: 7, minute: 36, second: 3, millisecond: 60, kind: DateTimeKind.Utc), new DateTime(year: 1988, month: 10, day: 13, hour: 17, minute: 28, second: 4, millisecond: 718, kind: DateTimeKind.Utc), }, }, },
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneMMArrayD3E1M
{
    Id = 65,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1991, month: 10, day: 9, hour: 15, minute: 52, second: 11, millisecond: 422, kind: DateTimeKind.Utc), new DateTime(year: 1965, month: 10, day: 10, hour: 7, minute: 44, second: 8, millisecond: 649, kind: DateTimeKind.Utc), new DateTime(year: 1929, month: 10, day: 3, hour: 16, minute: 34, second: 57, millisecond: 729, kind: DateTimeKind.Utc), }, { new DateTime(year: 2019, month: 10, day: 17, hour: 3, minute: 44, second: 30, millisecond: 174, kind: DateTimeKind.Utc), new DateTime(year: 1977, month: 10, day: 2, hour: 5, minute: 8, second: 7, millisecond: 316, kind: DateTimeKind.Utc), new DateTime(year: 1932, month: 10, day: 10, hour: 8, minute: 3, second: 28, millisecond: 442, kind: DateTimeKind.Utc), }, { new DateTime(year: 1934, month: 10, day: 9, hour: 2, minute: 49, second: 31, millisecond: 273, kind: DateTimeKind.Utc), new DateTime(year: 2015, month: 10, day: 18, hour: 8, minute: 30, second: 3, millisecond: 886, kind: DateTimeKind.Utc), new DateTime(year: 2017, month: 10, day: 15, hour: 5, minute: 17, second: 7, millisecond: 74, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1947, month: 10, day: 10, hour: 2, minute: 14, second: 32, millisecond: 464, kind: DateTimeKind.Utc), new DateTime(year: 1994, month: 10, day: 3, hour: 2, minute: 19, second: 54, millisecond: 396, kind: DateTimeKind.Utc), new DateTime(year: 1962, month: 10, day: 10, hour: 20, minute: 1, second: 3, millisecond: 394, kind: DateTimeKind.Utc), }, { new DateTime(year: 1961, month: 10, day: 8, hour: 6, minute: 16, second: 50, millisecond: 257, kind: DateTimeKind.Utc), new DateTime(year: 1970, month: 10, day: 16, hour: 16, minute: 12, second: 24, millisecond: 22, kind: DateTimeKind.Utc), new DateTime(year: 1942, month: 10, day: 5, hour: 19, minute: 8, second: 15, millisecond: 324, kind: DateTimeKind.Utc), }, { new DateTime(year: 1978, month: 10, day: 2, hour: 15, minute: 36, second: 32, millisecond: 854, kind: DateTimeKind.Utc), new DateTime(year: 1996, month: 10, day: 7, hour: 9, minute: 6, second: 1, millisecond: 989, kind: DateTimeKind.Utc), new DateTime(year: 1921, month: 10, day: 10, hour: 4, minute: 40, second: 12, millisecond: 773, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1993, month: 10, day: 7, hour: 21, minute: 18, second: 8, millisecond: 28, kind: DateTimeKind.Utc), new DateTime(year: 1951, month: 10, day: 13, hour: 20, minute: 35, second: 16, millisecond: 695, kind: DateTimeKind.Utc), new DateTime(year: 1921, month: 10, day: 8, hour: 14, minute: 56, second: 54, millisecond: 332, kind: DateTimeKind.Utc), }, { new DateTime(year: 1973, month: 10, day: 9, hour: 20, minute: 27, second: 49, millisecond: 387, kind: DateTimeKind.Utc), new DateTime(year: 1992, month: 10, day: 12, hour: 10, minute: 7, second: 43, millisecond: 551, kind: DateTimeKind.Utc), new DateTime(year: 1975, month: 10, day: 17, hour: 16, minute: 4, second: 9, millisecond: 880, kind: DateTimeKind.Utc), }, { new DateTime(year: 1994, month: 10, day: 5, hour: 11, minute: 19, second: 54, millisecond: 471, kind: DateTimeKind.Utc), new DateTime(year: 1978, month: 10, day: 18, hour: 10, minute: 16, second: 11, millisecond: 836, kind: DateTimeKind.Utc), new DateTime(year: 1933, month: 10, day: 3, hour: 5, minute: 52, second: 12, millisecond: 50, kind: DateTimeKind.Utc), }, }, },
    ModelInner = null,
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1941, month: 10, day: 7, hour: 9, minute: 44, second: 52, millisecond: 906, kind: DateTimeKind.Utc), new DateTime(year: 1941, month: 10, day: 15, hour: 19, minute: 50, second: 52, millisecond: 475, kind: DateTimeKind.Utc), new DateTime(year: 2012, month: 10, day: 2, hour: 1, minute: 41, second: 35, millisecond: 277, kind: DateTimeKind.Utc), }, { new DateTime(year: 2003, month: 10, day: 5, hour: 13, minute: 12, second: 26, millisecond: 894, kind: DateTimeKind.Utc), new DateTime(year: 1967, month: 10, day: 3, hour: 9, minute: 10, second: 44, millisecond: 586, kind: DateTimeKind.Utc), new DateTime(year: 2001, month: 10, day: 1, hour: 4, minute: 8, second: 15, millisecond: 507, kind: DateTimeKind.Utc), }, { new DateTime(year: 1977, month: 10, day: 6, hour: 22, minute: 6, second: 2, millisecond: 782, kind: DateTimeKind.Utc), new DateTime(year: 1993, month: 10, day: 4, hour: 22, minute: 58, second: 23, millisecond: 52, kind: DateTimeKind.Utc), new DateTime(year: 2017, month: 10, day: 3, hour: 8, minute: 44, second: 45, millisecond: 551, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 2006, month: 10, day: 11, hour: 18, minute: 14, second: 38, millisecond: 778, kind: DateTimeKind.Utc), new DateTime(year: 1960, month: 10, day: 6, hour: 17, minute: 14, second: 42, millisecond: 757, kind: DateTimeKind.Utc), new DateTime(year: 1943, month: 10, day: 4, hour: 4, minute: 40, second: 4, millisecond: 682, kind: DateTimeKind.Utc), }, { new DateTime(year: 1931, month: 10, day: 1, hour: 8, minute: 8, second: 50, millisecond: 627, kind: DateTimeKind.Utc), new DateTime(year: 1926, month: 10, day: 17, hour: 16, minute: 14, second: 58, millisecond: 780, kind: DateTimeKind.Utc), new DateTime(year: 1991, month: 10, day: 16, hour: 1, minute: 51, second: 11, millisecond: 27, kind: DateTimeKind.Utc), }, { new DateTime(year: 1974, month: 10, day: 18, hour: 13, minute: 52, second: 6, millisecond: 886, kind: DateTimeKind.Utc), new DateTime(year: 1974, month: 10, day: 17, hour: 5, minute: 37, second: 35, millisecond: 571, kind: DateTimeKind.Utc), new DateTime(year: 1924, month: 10, day: 5, hour: 9, minute: 46, second: 40, millisecond: 853, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1995, month: 10, day: 1, hour: 20, minute: 1, second: 13, millisecond: 38, kind: DateTimeKind.Utc), new DateTime(year: 1980, month: 10, day: 19, hour: 3, minute: 32, second: 26, millisecond: 565, kind: DateTimeKind.Utc), new DateTime(year: 1999, month: 10, day: 8, hour: 15, minute: 33, second: 38, millisecond: 490, kind: DateTimeKind.Utc), }, { new DateTime(year: 1999, month: 10, day: 2, hour: 17, minute: 53, second: 23, millisecond: 155, kind: DateTimeKind.Utc), new DateTime(year: 2002, month: 10, day: 8, hour: 21, minute: 33, second: 29, millisecond: 754, kind: DateTimeKind.Utc), new DateTime(year: 1933, month: 10, day: 1, hour: 20, minute: 21, second: 25, millisecond: 248, kind: DateTimeKind.Utc), }, { new DateTime(year: 2011, month: 10, day: 2, hour: 18, minute: 6, second: 41, millisecond: 666, kind: DateTimeKind.Utc), new DateTime(year: 1924, month: 10, day: 18, hour: 14, minute: 3, second: 52, millisecond: 778, kind: DateTimeKind.Utc), new DateTime(year: 1934, month: 10, day: 15, hour: 12, minute: 45, second: 19, millisecond: 58, kind: DateTimeKind.Utc), }, }, },
},
            new DateTimetimestamp_with_time_zoneMMArrayD3E1M
{
    Id = 71,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1920, month: 10, day: 10, hour: 8, minute: 4, second: 44, millisecond: 781, kind: DateTimeKind.Utc), new DateTime(year: 1964, month: 10, day: 2, hour: 8, minute: 46, second: 27, millisecond: 340, kind: DateTimeKind.Utc), new DateTime(year: 1939, month: 10, day: 15, hour: 1, minute: 43, second: 3, millisecond: 81, kind: DateTimeKind.Utc), }, { new DateTime(year: 1977, month: 10, day: 19, hour: 19, minute: 9, second: 7, millisecond: 776, kind: DateTimeKind.Utc), new DateTime(year: 1986, month: 10, day: 10, hour: 9, minute: 26, second: 55, millisecond: 125, kind: DateTimeKind.Utc), new DateTime(year: 1966, month: 10, day: 18, hour: 7, minute: 42, second: 6, millisecond: 67, kind: DateTimeKind.Utc), }, { new DateTime(year: 1962, month: 10, day: 3, hour: 9, minute: 40, second: 5, millisecond: 487, kind: DateTimeKind.Utc), new DateTime(year: 1952, month: 10, day: 14, hour: 4, minute: 19, second: 38, millisecond: 686, kind: DateTimeKind.Utc), new DateTime(year: 1926, month: 10, day: 1, hour: 21, minute: 31, second: 32, millisecond: 122, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1935, month: 10, day: 9, hour: 9, minute: 52, second: 31, millisecond: 535, kind: DateTimeKind.Utc), new DateTime(year: 1969, month: 10, day: 7, hour: 16, minute: 29, second: 8, millisecond: 975, kind: DateTimeKind.Utc), new DateTime(year: 1922, month: 10, day: 2, hour: 13, minute: 43, second: 18, millisecond: 577, kind: DateTimeKind.Utc), }, { new DateTime(year: 2006, month: 10, day: 4, hour: 17, minute: 30, second: 26, millisecond: 340, kind: DateTimeKind.Utc), new DateTime(year: 1955, month: 10, day: 2, hour: 20, minute: 32, second: 21, millisecond: 86, kind: DateTimeKind.Utc), new DateTime(year: 1954, month: 10, day: 10, hour: 14, minute: 32, second: 51, millisecond: 210, kind: DateTimeKind.Utc), }, { new DateTime(year: 1940, month: 10, day: 6, hour: 22, minute: 14, second: 2, millisecond: 583, kind: DateTimeKind.Utc), new DateTime(year: 1999, month: 10, day: 9, hour: 2, minute: 48, second: 4, millisecond: 75, kind: DateTimeKind.Utc), new DateTime(year: 1918, month: 10, day: 1, hour: 2, minute: 45, second: 11, millisecond: 995, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1964, month: 10, day: 8, hour: 18, minute: 33, second: 52, millisecond: 712, kind: DateTimeKind.Utc), new DateTime(year: 1960, month: 10, day: 14, hour: 9, minute: 8, second: 12, millisecond: 684, kind: DateTimeKind.Utc), new DateTime(year: 2012, month: 10, day: 16, hour: 3, minute: 56, second: 29, millisecond: 898, kind: DateTimeKind.Utc), }, { new DateTime(year: 1989, month: 10, day: 19, hour: 22, minute: 25, second: 10, millisecond: 837, kind: DateTimeKind.Utc), new DateTime(year: 1917, month: 10, day: 12, hour: 18, minute: 4, second: 15, millisecond: 450, kind: DateTimeKind.Utc), new DateTime(year: 1951, month: 10, day: 12, hour: 7, minute: 31, second: 2, millisecond: 7, kind: DateTimeKind.Utc), }, { new DateTime(year: 1933, month: 10, day: 4, hour: 5, minute: 1, second: 3, millisecond: 320, kind: DateTimeKind.Utc), new DateTime(year: 1937, month: 10, day: 18, hour: 12, minute: 57, second: 2, millisecond: 487, kind: DateTimeKind.Utc), new DateTime(year: 1985, month: 10, day: 15, hour: 13, minute: 36, second: 47, millisecond: 950, kind: DateTimeKind.Utc), }, }, },
    ModelInner = new DateTimetimestamp_with_time_zoneMMArrayD3E1MI
{
    Id = 47,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1995, month: 10, day: 19, hour: 4, minute: 1, second: 6, millisecond: 327, kind: DateTimeKind.Utc), new DateTime(year: 1949, month: 10, day: 8, hour: 17, minute: 12, second: 39, millisecond: 666, kind: DateTimeKind.Utc), new DateTime(year: 1932, month: 10, day: 9, hour: 18, minute: 7, second: 20, millisecond: 481, kind: DateTimeKind.Utc), }, { new DateTime(year: 2019, month: 10, day: 3, hour: 7, minute: 4, second: 29, millisecond: 270, kind: DateTimeKind.Utc), new DateTime(year: 2008, month: 10, day: 11, hour: 11, minute: 24, second: 20, millisecond: 45, kind: DateTimeKind.Utc), new DateTime(year: 1925, month: 10, day: 8, hour: 14, minute: 55, second: 45, millisecond: 155, kind: DateTimeKind.Utc), }, { new DateTime(year: 1951, month: 10, day: 8, hour: 10, minute: 26, second: 36, millisecond: 135, kind: DateTimeKind.Utc), new DateTime(year: 2008, month: 10, day: 3, hour: 1, minute: 50, second: 49, millisecond: 650, kind: DateTimeKind.Utc), new DateTime(year: 2009, month: 10, day: 19, hour: 10, minute: 25, second: 48, millisecond: 598, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1953, month: 10, day: 10, hour: 14, minute: 25, second: 12, millisecond: 837, kind: DateTimeKind.Utc), new DateTime(year: 2015, month: 10, day: 8, hour: 12, minute: 22, second: 36, millisecond: 410, kind: DateTimeKind.Utc), new DateTime(year: 1998, month: 10, day: 7, hour: 22, minute: 26, second: 45, millisecond: 861, kind: DateTimeKind.Utc), }, { new DateTime(year: 1931, month: 10, day: 14, hour: 2, minute: 56, second: 1, millisecond: 39, kind: DateTimeKind.Utc), new DateTime(year: 1954, month: 10, day: 15, hour: 11, minute: 54, second: 11, millisecond: 740, kind: DateTimeKind.Utc), new DateTime(year: 1929, month: 10, day: 2, hour: 11, minute: 7, second: 44, millisecond: 754, kind: DateTimeKind.Utc), }, { new DateTime(year: 1999, month: 10, day: 5, hour: 18, minute: 22, second: 43, millisecond: 113, kind: DateTimeKind.Utc), new DateTime(year: 1991, month: 10, day: 15, hour: 13, minute: 17, second: 21, millisecond: 92, kind: DateTimeKind.Utc), new DateTime(year: 1954, month: 10, day: 17, hour: 3, minute: 21, second: 44, millisecond: 900, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1999, month: 10, day: 15, hour: 2, minute: 33, second: 48, millisecond: 459, kind: DateTimeKind.Utc), new DateTime(year: 1964, month: 10, day: 4, hour: 20, minute: 14, second: 16, millisecond: 661, kind: DateTimeKind.Utc), new DateTime(year: 1938, month: 10, day: 18, hour: 9, minute: 11, second: 17, millisecond: 700, kind: DateTimeKind.Utc), }, { new DateTime(year: 1982, month: 10, day: 13, hour: 17, minute: 24, second: 24, millisecond: 299, kind: DateTimeKind.Utc), new DateTime(year: 1917, month: 10, day: 13, hour: 3, minute: 54, second: 3, millisecond: 43, kind: DateTimeKind.Utc), new DateTime(year: 1994, month: 10, day: 12, hour: 3, minute: 30, second: 15, millisecond: 514, kind: DateTimeKind.Utc), }, { new DateTime(year: 1966, month: 10, day: 7, hour: 12, minute: 56, second: 36, millisecond: 27, kind: DateTimeKind.Utc), new DateTime(year: 1974, month: 10, day: 15, hour: 18, minute: 26, second: 29, millisecond: 936, kind: DateTimeKind.Utc), new DateTime(year: 1929, month: 10, day: 6, hour: 7, minute: 57, second: 38, millisecond: 666, kind: DateTimeKind.Utc), }, }, },
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1959, month: 10, day: 6, hour: 9, minute: 49, second: 50, millisecond: 703, kind: DateTimeKind.Utc), new DateTime(year: 1948, month: 10, day: 16, hour: 18, minute: 41, second: 45, millisecond: 732, kind: DateTimeKind.Utc), new DateTime(year: 2018, month: 10, day: 13, hour: 6, minute: 40, second: 18, millisecond: 448, kind: DateTimeKind.Utc), }, { new DateTime(year: 1962, month: 10, day: 1, hour: 8, minute: 44, second: 38, millisecond: 848, kind: DateTimeKind.Utc), new DateTime(year: 1962, month: 10, day: 5, hour: 11, minute: 52, second: 28, millisecond: 276, kind: DateTimeKind.Utc), new DateTime(year: 1942, month: 10, day: 6, hour: 3, minute: 53, second: 16, millisecond: 475, kind: DateTimeKind.Utc), }, { new DateTime(year: 1983, month: 10, day: 3, hour: 10, minute: 40, second: 55, millisecond: 626, kind: DateTimeKind.Utc), new DateTime(year: 2016, month: 10, day: 18, hour: 18, minute: 3, second: 48, millisecond: 377, kind: DateTimeKind.Utc), new DateTime(year: 1955, month: 10, day: 11, hour: 9, minute: 50, second: 48, millisecond: 316, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1951, month: 10, day: 5, hour: 11, minute: 28, second: 35, millisecond: 924, kind: DateTimeKind.Utc), new DateTime(year: 1993, month: 10, day: 12, hour: 8, minute: 29, second: 56, millisecond: 867, kind: DateTimeKind.Utc), new DateTime(year: 1965, month: 10, day: 15, hour: 19, minute: 25, second: 1, millisecond: 87, kind: DateTimeKind.Utc), }, { new DateTime(year: 2003, month: 10, day: 7, hour: 2, minute: 19, second: 39, millisecond: 148, kind: DateTimeKind.Utc), new DateTime(year: 1955, month: 10, day: 7, hour: 5, minute: 17, second: 37, millisecond: 958, kind: DateTimeKind.Utc), new DateTime(year: 1986, month: 10, day: 3, hour: 4, minute: 36, second: 48, millisecond: 625, kind: DateTimeKind.Utc), }, { new DateTime(year: 1955, month: 10, day: 14, hour: 15, minute: 13, second: 48, millisecond: 871, kind: DateTimeKind.Utc), new DateTime(year: 1968, month: 10, day: 4, hour: 12, minute: 34, second: 14, millisecond: 582, kind: DateTimeKind.Utc), new DateTime(year: 1998, month: 10, day: 6, hour: 15, minute: 56, second: 11, millisecond: 619, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1926, month: 10, day: 3, hour: 19, minute: 2, second: 23, millisecond: 46, kind: DateTimeKind.Utc), new DateTime(year: 1927, month: 10, day: 5, hour: 8, minute: 33, second: 35, millisecond: 17, kind: DateTimeKind.Utc), new DateTime(year: 1962, month: 10, day: 1, hour: 16, minute: 25, second: 11, millisecond: 493, kind: DateTimeKind.Utc), }, { new DateTime(year: 1985, month: 10, day: 2, hour: 4, minute: 37, second: 21, millisecond: 992, kind: DateTimeKind.Utc), new DateTime(year: 1998, month: 10, day: 7, hour: 11, minute: 11, second: 5, millisecond: 805, kind: DateTimeKind.Utc), new DateTime(year: 2002, month: 10, day: 14, hour: 10, minute: 12, second: 40, millisecond: 752, kind: DateTimeKind.Utc), }, { new DateTime(year: 1989, month: 10, day: 10, hour: 20, minute: 51, second: 24, millisecond: 274, kind: DateTimeKind.Utc), new DateTime(year: 1943, month: 10, day: 2, hour: 9, minute: 49, second: 37, millisecond: 526, kind: DateTimeKind.Utc), new DateTime(year: 1941, month: 10, day: 9, hour: 12, minute: 3, second: 27, millisecond: 847, kind: DateTimeKind.Utc), }, }, },
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneMMArrayD3E1M
{
    Id = 79,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1931, month: 10, day: 10, hour: 1, minute: 22, second: 43, millisecond: 642, kind: DateTimeKind.Utc), new DateTime(year: 1981, month: 10, day: 16, hour: 4, minute: 36, second: 22, millisecond: 62, kind: DateTimeKind.Utc), new DateTime(year: 1956, month: 10, day: 9, hour: 15, minute: 39, second: 42, millisecond: 644, kind: DateTimeKind.Utc), }, { new DateTime(year: 1924, month: 10, day: 13, hour: 19, minute: 41, second: 25, millisecond: 804, kind: DateTimeKind.Utc), new DateTime(year: 2017, month: 10, day: 4, hour: 8, minute: 14, second: 45, millisecond: 705, kind: DateTimeKind.Utc), new DateTime(year: 1928, month: 10, day: 5, hour: 3, minute: 51, second: 27, millisecond: 852, kind: DateTimeKind.Utc), }, { new DateTime(year: 1962, month: 10, day: 12, hour: 15, minute: 16, second: 8, millisecond: 158, kind: DateTimeKind.Utc), new DateTime(year: 1918, month: 10, day: 10, hour: 12, minute: 11, second: 33, millisecond: 129, kind: DateTimeKind.Utc), new DateTime(year: 1926, month: 10, day: 3, hour: 19, minute: 7, second: 51, millisecond: 330, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1953, month: 10, day: 5, hour: 11, minute: 14, second: 31, millisecond: 938, kind: DateTimeKind.Utc), new DateTime(year: 1919, month: 10, day: 7, hour: 4, minute: 1, second: 8, millisecond: 74, kind: DateTimeKind.Utc), new DateTime(year: 2002, month: 10, day: 12, hour: 14, minute: 47, second: 7, millisecond: 420, kind: DateTimeKind.Utc), }, { new DateTime(year: 1934, month: 10, day: 12, hour: 4, minute: 42, second: 32, millisecond: 1, kind: DateTimeKind.Utc), new DateTime(year: 1945, month: 10, day: 15, hour: 2, minute: 32, second: 49, millisecond: 432, kind: DateTimeKind.Utc), new DateTime(year: 1940, month: 10, day: 15, hour: 8, minute: 38, second: 23, millisecond: 193, kind: DateTimeKind.Utc), }, { new DateTime(year: 1955, month: 10, day: 7, hour: 8, minute: 23, second: 52, millisecond: 569, kind: DateTimeKind.Utc), new DateTime(year: 1918, month: 10, day: 4, hour: 19, minute: 19, second: 13, millisecond: 756, kind: DateTimeKind.Utc), new DateTime(year: 2015, month: 10, day: 19, hour: 18, minute: 30, second: 19, millisecond: 32, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1934, month: 10, day: 17, hour: 21, minute: 5, second: 33, millisecond: 433, kind: DateTimeKind.Utc), new DateTime(year: 1924, month: 10, day: 4, hour: 6, minute: 55, second: 48, millisecond: 194, kind: DateTimeKind.Utc), new DateTime(year: 1983, month: 10, day: 17, hour: 11, minute: 43, second: 45, millisecond: 169, kind: DateTimeKind.Utc), }, { new DateTime(year: 1997, month: 10, day: 17, hour: 19, minute: 46, second: 29, millisecond: 340, kind: DateTimeKind.Utc), new DateTime(year: 2008, month: 10, day: 1, hour: 20, minute: 28, second: 20, millisecond: 33, kind: DateTimeKind.Utc), new DateTime(year: 1985, month: 10, day: 15, hour: 10, minute: 1, second: 5, millisecond: 929, kind: DateTimeKind.Utc), }, { new DateTime(year: 1991, month: 10, day: 16, hour: 18, minute: 36, second: 39, millisecond: 577, kind: DateTimeKind.Utc), new DateTime(year: 1957, month: 10, day: 3, hour: 20, minute: 13, second: 36, millisecond: 394, kind: DateTimeKind.Utc), new DateTime(year: 1940, month: 10, day: 7, hour: 5, minute: 5, second: 8, millisecond: 389, kind: DateTimeKind.Utc), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneMMArrayD3E1M
{
    Id = 80,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1921, month: 10, day: 13, hour: 9, minute: 57, second: 49, millisecond: 452, kind: DateTimeKind.Utc), new DateTime(year: 1946, month: 10, day: 11, hour: 4, minute: 37, second: 44, millisecond: 511, kind: DateTimeKind.Utc), new DateTime(year: 1928, month: 10, day: 18, hour: 21, minute: 28, second: 46, millisecond: 802, kind: DateTimeKind.Utc), }, { new DateTime(year: 1970, month: 10, day: 3, hour: 6, minute: 2, second: 39, millisecond: 968, kind: DateTimeKind.Utc), new DateTime(year: 1922, month: 10, day: 10, hour: 4, minute: 49, second: 42, millisecond: 321, kind: DateTimeKind.Utc), new DateTime(year: 1964, month: 10, day: 14, hour: 9, minute: 25, second: 52, millisecond: 407, kind: DateTimeKind.Utc), }, { new DateTime(year: 1979, month: 10, day: 9, hour: 19, minute: 42, second: 10, millisecond: 270, kind: DateTimeKind.Utc), new DateTime(year: 1940, month: 10, day: 7, hour: 9, minute: 36, second: 52, millisecond: 625, kind: DateTimeKind.Utc), new DateTime(year: 2004, month: 10, day: 3, hour: 11, minute: 21, second: 19, millisecond: 733, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1936, month: 10, day: 1, hour: 18, minute: 9, second: 12, millisecond: 150, kind: DateTimeKind.Utc), new DateTime(year: 1926, month: 10, day: 15, hour: 5, minute: 54, second: 29, millisecond: 263, kind: DateTimeKind.Utc), new DateTime(year: 1987, month: 10, day: 16, hour: 1, minute: 55, second: 10, millisecond: 327, kind: DateTimeKind.Utc), }, { new DateTime(year: 1938, month: 10, day: 8, hour: 1, minute: 23, second: 7, millisecond: 114, kind: DateTimeKind.Utc), new DateTime(year: 1929, month: 10, day: 13, hour: 3, minute: 1, second: 14, millisecond: 5, kind: DateTimeKind.Utc), new DateTime(year: 2001, month: 10, day: 10, hour: 3, minute: 26, second: 25, millisecond: 170, kind: DateTimeKind.Utc), }, { new DateTime(year: 2018, month: 10, day: 6, hour: 22, minute: 50, second: 29, millisecond: 351, kind: DateTimeKind.Utc), new DateTime(year: 1975, month: 10, day: 17, hour: 12, minute: 43, second: 26, millisecond: 658, kind: DateTimeKind.Utc), new DateTime(year: 2015, month: 10, day: 5, hour: 6, minute: 45, second: 31, millisecond: 599, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1960, month: 10, day: 3, hour: 4, minute: 34, second: 23, millisecond: 148, kind: DateTimeKind.Utc), new DateTime(year: 1986, month: 10, day: 9, hour: 16, minute: 38, second: 18, millisecond: 629, kind: DateTimeKind.Utc), new DateTime(year: 2017, month: 10, day: 11, hour: 21, minute: 47, second: 47, millisecond: 481, kind: DateTimeKind.Utc), }, { new DateTime(year: 1974, month: 10, day: 18, hour: 3, minute: 27, second: 14, millisecond: 225, kind: DateTimeKind.Utc), new DateTime(year: 1984, month: 10, day: 2, hour: 1, minute: 18, second: 9, millisecond: 287, kind: DateTimeKind.Utc), new DateTime(year: 1971, month: 10, day: 8, hour: 1, minute: 15, second: 15, millisecond: 998, kind: DateTimeKind.Utc), }, { new DateTime(year: 2010, month: 10, day: 19, hour: 16, minute: 16, second: 11, millisecond: 399, kind: DateTimeKind.Utc), new DateTime(year: 1942, month: 10, day: 9, hour: 12, minute: 55, second: 54, millisecond: 33, kind: DateTimeKind.Utc), new DateTime(year: 1940, month: 10, day: 18, hour: 10, minute: 1, second: 18, millisecond: 863, kind: DateTimeKind.Utc), }, }, },
    ModelInner = new DateTimetimestamp_with_time_zoneMMArrayD3E1MI
{
    Id = 53,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1956, month: 10, day: 2, hour: 21, minute: 7, second: 58, millisecond: 947, kind: DateTimeKind.Utc), new DateTime(year: 1942, month: 10, day: 14, hour: 2, minute: 13, second: 47, millisecond: 427, kind: DateTimeKind.Utc), new DateTime(year: 1922, month: 10, day: 12, hour: 2, minute: 32, second: 55, millisecond: 452, kind: DateTimeKind.Utc), }, { new DateTime(year: 1964, month: 10, day: 5, hour: 1, minute: 55, second: 8, millisecond: 895, kind: DateTimeKind.Utc), new DateTime(year: 2014, month: 10, day: 2, hour: 10, minute: 1, second: 46, millisecond: 181, kind: DateTimeKind.Utc), new DateTime(year: 1918, month: 10, day: 12, hour: 12, minute: 6, second: 47, millisecond: 439, kind: DateTimeKind.Utc), }, { new DateTime(year: 1928, month: 10, day: 8, hour: 6, minute: 29, second: 40, millisecond: 559, kind: DateTimeKind.Utc), new DateTime(year: 1949, month: 10, day: 19, hour: 17, minute: 18, second: 26, millisecond: 450, kind: DateTimeKind.Utc), new DateTime(year: 1941, month: 10, day: 11, hour: 10, minute: 28, second: 50, millisecond: 290, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1973, month: 10, day: 11, hour: 4, minute: 45, second: 18, millisecond: 102, kind: DateTimeKind.Utc), new DateTime(year: 1995, month: 10, day: 19, hour: 17, minute: 45, second: 1, millisecond: 726, kind: DateTimeKind.Utc), new DateTime(year: 1931, month: 10, day: 16, hour: 11, minute: 44, second: 46, millisecond: 915, kind: DateTimeKind.Utc), }, { new DateTime(year: 1956, month: 10, day: 8, hour: 9, minute: 41, second: 32, millisecond: 335, kind: DateTimeKind.Utc), new DateTime(year: 1981, month: 10, day: 4, hour: 16, minute: 51, second: 48, millisecond: 822, kind: DateTimeKind.Utc), new DateTime(year: 1931, month: 10, day: 11, hour: 9, minute: 16, second: 42, millisecond: 532, kind: DateTimeKind.Utc), }, { new DateTime(year: 1992, month: 10, day: 1, hour: 17, minute: 11, second: 22, millisecond: 269, kind: DateTimeKind.Utc), new DateTime(year: 1924, month: 10, day: 11, hour: 11, minute: 22, second: 22, millisecond: 547, kind: DateTimeKind.Utc), new DateTime(year: 1927, month: 10, day: 11, hour: 1, minute: 31, second: 24, millisecond: 265, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1974, month: 10, day: 2, hour: 1, minute: 43, second: 15, millisecond: 844, kind: DateTimeKind.Utc), new DateTime(year: 1966, month: 10, day: 2, hour: 3, minute: 1, second: 56, millisecond: 380, kind: DateTimeKind.Utc), new DateTime(year: 1985, month: 10, day: 2, hour: 3, minute: 48, second: 18, millisecond: 853, kind: DateTimeKind.Utc), }, { new DateTime(year: 1939, month: 10, day: 9, hour: 2, minute: 45, second: 19, millisecond: 977, kind: DateTimeKind.Utc), new DateTime(year: 1988, month: 10, day: 15, hour: 3, minute: 42, second: 49, millisecond: 359, kind: DateTimeKind.Utc), new DateTime(year: 1963, month: 10, day: 17, hour: 19, minute: 54, second: 3, millisecond: 485, kind: DateTimeKind.Utc), }, { new DateTime(year: 1984, month: 10, day: 19, hour: 6, minute: 58, second: 5, millisecond: 993, kind: DateTimeKind.Utc), new DateTime(year: 1940, month: 10, day: 18, hour: 11, minute: 34, second: 25, millisecond: 502, kind: DateTimeKind.Utc), new DateTime(year: 1939, month: 10, day: 12, hour: 1, minute: 43, second: 10, millisecond: 567, kind: DateTimeKind.Utc), }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1952, month: 10, day: 9, hour: 16, minute: 34, second: 51, millisecond: 585, kind: DateTimeKind.Utc), new DateTime(year: 1917, month: 10, day: 12, hour: 14, minute: 43, second: 33, millisecond: 336, kind: DateTimeKind.Utc), new DateTime(year: 1964, month: 10, day: 16, hour: 7, minute: 1, second: 36, millisecond: 475, kind: DateTimeKind.Utc), }, { new DateTime(year: 1960, month: 10, day: 7, hour: 11, minute: 10, second: 16, millisecond: 261, kind: DateTimeKind.Utc), new DateTime(year: 1963, month: 10, day: 14, hour: 2, minute: 57, second: 53, millisecond: 959, kind: DateTimeKind.Utc), new DateTime(year: 1980, month: 10, day: 14, hour: 21, minute: 32, second: 45, millisecond: 308, kind: DateTimeKind.Utc), }, { new DateTime(year: 1921, month: 10, day: 3, hour: 12, minute: 45, second: 15, millisecond: 46, kind: DateTimeKind.Utc), new DateTime(year: 2010, month: 10, day: 16, hour: 14, minute: 58, second: 40, millisecond: 640, kind: DateTimeKind.Utc), new DateTime(year: 1970, month: 10, day: 15, hour: 2, minute: 24, second: 18, millisecond: 254, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 2012, month: 10, day: 4, hour: 19, minute: 19, second: 22, millisecond: 450, kind: DateTimeKind.Utc), new DateTime(year: 1942, month: 10, day: 3, hour: 10, minute: 15, second: 39, millisecond: 704, kind: DateTimeKind.Utc), new DateTime(year: 2001, month: 10, day: 5, hour: 20, minute: 46, second: 51, millisecond: 747, kind: DateTimeKind.Utc), }, { new DateTime(year: 1931, month: 10, day: 4, hour: 12, minute: 33, second: 11, millisecond: 243, kind: DateTimeKind.Utc), new DateTime(year: 1982, month: 10, day: 8, hour: 9, minute: 24, second: 49, millisecond: 871, kind: DateTimeKind.Utc), new DateTime(year: 1968, month: 10, day: 15, hour: 11, minute: 2, second: 36, millisecond: 350, kind: DateTimeKind.Utc), }, { new DateTime(year: 1992, month: 10, day: 2, hour: 12, minute: 50, second: 4, millisecond: 819, kind: DateTimeKind.Utc), new DateTime(year: 1948, month: 10, day: 3, hour: 12, minute: 40, second: 6, millisecond: 645, kind: DateTimeKind.Utc), new DateTime(year: 1985, month: 10, day: 16, hour: 11, minute: 45, second: 12, millisecond: 31, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1946, month: 10, day: 9, hour: 7, minute: 41, second: 40, millisecond: 417, kind: DateTimeKind.Utc), new DateTime(year: 1924, month: 10, day: 3, hour: 21, minute: 9, second: 25, millisecond: 724, kind: DateTimeKind.Utc), new DateTime(year: 1953, month: 10, day: 9, hour: 11, minute: 34, second: 58, millisecond: 764, kind: DateTimeKind.Utc), }, { new DateTime(year: 1969, month: 10, day: 3, hour: 17, minute: 41, second: 11, millisecond: 122, kind: DateTimeKind.Utc), new DateTime(year: 1940, month: 10, day: 8, hour: 18, minute: 6, second: 58, millisecond: 918, kind: DateTimeKind.Utc), new DateTime(year: 1925, month: 10, day: 2, hour: 3, minute: 19, second: 19, millisecond: 465, kind: DateTimeKind.Utc), }, { new DateTime(year: 1936, month: 10, day: 8, hour: 3, minute: 22, second: 43, millisecond: 613, kind: DateTimeKind.Utc), new DateTime(year: 1965, month: 10, day: 9, hour: 6, minute: 51, second: 21, millisecond: 180, kind: DateTimeKind.Utc), new DateTime(year: 1981, month: 10, day: 12, hour: 1, minute: 2, second: 8, millisecond: 186, kind: DateTimeKind.Utc), }, }, },
},
            new DateTimetimestamp_with_time_zoneMMArrayD3E1M
{
    Id = 87,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1935, month: 10, day: 12, hour: 19, minute: 22, second: 25, millisecond: 848, kind: DateTimeKind.Utc), new DateTime(year: 2014, month: 10, day: 4, hour: 4, minute: 53, second: 9, millisecond: 243, kind: DateTimeKind.Utc), new DateTime(year: 1933, month: 10, day: 2, hour: 15, minute: 48, second: 42, millisecond: 924, kind: DateTimeKind.Utc), }, { new DateTime(year: 1933, month: 10, day: 6, hour: 22, minute: 28, second: 36, millisecond: 849, kind: DateTimeKind.Utc), new DateTime(year: 1944, month: 10, day: 8, hour: 6, minute: 1, second: 34, millisecond: 465, kind: DateTimeKind.Utc), new DateTime(year: 1925, month: 10, day: 8, hour: 13, minute: 39, second: 26, millisecond: 258, kind: DateTimeKind.Utc), }, { new DateTime(year: 1945, month: 10, day: 14, hour: 10, minute: 31, second: 35, millisecond: 512, kind: DateTimeKind.Utc), new DateTime(year: 1958, month: 10, day: 6, hour: 9, minute: 9, second: 55, millisecond: 779, kind: DateTimeKind.Utc), new DateTime(year: 1989, month: 10, day: 11, hour: 21, minute: 5, second: 24, millisecond: 75, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1918, month: 10, day: 14, hour: 18, minute: 18, second: 29, millisecond: 513, kind: DateTimeKind.Utc), new DateTime(year: 1949, month: 10, day: 18, hour: 18, minute: 18, second: 50, millisecond: 878, kind: DateTimeKind.Utc), new DateTime(year: 2002, month: 10, day: 7, hour: 9, minute: 16, second: 27, millisecond: 421, kind: DateTimeKind.Utc), }, { new DateTime(year: 1947, month: 10, day: 1, hour: 9, minute: 26, second: 3, millisecond: 605, kind: DateTimeKind.Utc), new DateTime(year: 1941, month: 10, day: 11, hour: 19, minute: 49, second: 19, millisecond: 65, kind: DateTimeKind.Utc), new DateTime(year: 2004, month: 10, day: 7, hour: 7, minute: 40, second: 11, millisecond: 158, kind: DateTimeKind.Utc), }, { new DateTime(year: 1987, month: 10, day: 8, hour: 19, minute: 50, second: 20, millisecond: 474, kind: DateTimeKind.Utc), new DateTime(year: 1986, month: 10, day: 11, hour: 3, minute: 42, second: 31, millisecond: 846, kind: DateTimeKind.Utc), new DateTime(year: 1970, month: 10, day: 17, hour: 8, minute: 21, second: 57, millisecond: 975, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1937, month: 10, day: 18, hour: 16, minute: 9, second: 23, millisecond: 687, kind: DateTimeKind.Utc), new DateTime(year: 1934, month: 10, day: 11, hour: 6, minute: 12, second: 12, millisecond: 466, kind: DateTimeKind.Utc), new DateTime(year: 1921, month: 10, day: 3, hour: 3, minute: 45, second: 45, millisecond: 670, kind: DateTimeKind.Utc), }, { new DateTime(year: 1981, month: 10, day: 16, hour: 1, minute: 23, second: 3, millisecond: 22, kind: DateTimeKind.Utc), new DateTime(year: 2012, month: 10, day: 3, hour: 2, minute: 25, second: 38, millisecond: 864, kind: DateTimeKind.Utc), new DateTime(year: 1924, month: 10, day: 11, hour: 2, minute: 58, second: 14, millisecond: 95, kind: DateTimeKind.Utc), }, { new DateTime(year: 1959, month: 10, day: 13, hour: 7, minute: 45, second: 19, millisecond: 898, kind: DateTimeKind.Utc), new DateTime(year: 1932, month: 10, day: 13, hour: 20, minute: 15, second: 20, millisecond: 463, kind: DateTimeKind.Utc), new DateTime(year: 2010, month: 10, day: 16, hour: 11, minute: 26, second: 42, millisecond: 43, kind: DateTimeKind.Utc), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneMMArrayD3E1M
{
    Id = 88,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1924, month: 10, day: 18, hour: 17, minute: 46, second: 22, millisecond: 730, kind: DateTimeKind.Utc), new DateTime(year: 1946, month: 10, day: 4, hour: 16, minute: 32, second: 29, millisecond: 988, kind: DateTimeKind.Utc), new DateTime(year: 2016, month: 10, day: 4, hour: 3, minute: 17, second: 49, millisecond: 309, kind: DateTimeKind.Utc), }, { new DateTime(year: 1971, month: 10, day: 19, hour: 21, minute: 37, second: 4, millisecond: 968, kind: DateTimeKind.Utc), new DateTime(year: 1978, month: 10, day: 1, hour: 14, minute: 23, second: 18, millisecond: 5, kind: DateTimeKind.Utc), new DateTime(year: 1938, month: 10, day: 14, hour: 21, minute: 20, second: 43, millisecond: 643, kind: DateTimeKind.Utc), }, { new DateTime(year: 1942, month: 10, day: 18, hour: 14, minute: 9, second: 16, millisecond: 877, kind: DateTimeKind.Utc), new DateTime(year: 1973, month: 10, day: 13, hour: 4, minute: 43, second: 39, millisecond: 110, kind: DateTimeKind.Utc), new DateTime(year: 2005, month: 10, day: 7, hour: 8, minute: 29, second: 32, millisecond: 892, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1956, month: 10, day: 3, hour: 1, minute: 11, second: 48, millisecond: 740, kind: DateTimeKind.Utc), new DateTime(year: 1967, month: 10, day: 19, hour: 12, minute: 45, second: 3, millisecond: 213, kind: DateTimeKind.Utc), new DateTime(year: 1972, month: 10, day: 4, hour: 5, minute: 37, second: 23, millisecond: 572, kind: DateTimeKind.Utc), }, { new DateTime(year: 1986, month: 10, day: 12, hour: 6, minute: 44, second: 2, millisecond: 575, kind: DateTimeKind.Utc), new DateTime(year: 1965, month: 10, day: 16, hour: 5, minute: 47, second: 31, millisecond: 69, kind: DateTimeKind.Utc), new DateTime(year: 1947, month: 10, day: 9, hour: 1, minute: 9, second: 44, millisecond: 27, kind: DateTimeKind.Utc), }, { new DateTime(year: 1966, month: 10, day: 3, hour: 17, minute: 48, second: 48, millisecond: 218, kind: DateTimeKind.Utc), new DateTime(year: 1941, month: 10, day: 3, hour: 13, minute: 42, second: 8, millisecond: 603, kind: DateTimeKind.Utc), new DateTime(year: 1951, month: 10, day: 3, hour: 6, minute: 32, second: 40, millisecond: 243, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 2002, month: 10, day: 12, hour: 6, minute: 44, second: 50, millisecond: 226, kind: DateTimeKind.Utc), new DateTime(year: 2015, month: 10, day: 11, hour: 1, minute: 55, second: 6, millisecond: 729, kind: DateTimeKind.Utc), new DateTime(year: 1984, month: 10, day: 16, hour: 7, minute: 23, second: 24, millisecond: 925, kind: DateTimeKind.Utc), }, { new DateTime(year: 1943, month: 10, day: 1, hour: 18, minute: 37, second: 42, millisecond: 477, kind: DateTimeKind.Utc), new DateTime(year: 1964, month: 10, day: 8, hour: 10, minute: 19, second: 46, millisecond: 613, kind: DateTimeKind.Utc), new DateTime(year: 2005, month: 10, day: 5, hour: 9, minute: 43, second: 46, millisecond: 28, kind: DateTimeKind.Utc), }, { new DateTime(year: 1947, month: 10, day: 17, hour: 15, minute: 10, second: 24, millisecond: 420, kind: DateTimeKind.Utc), new DateTime(year: 1990, month: 10, day: 4, hour: 2, minute: 57, second: 7, millisecond: 729, kind: DateTimeKind.Utc), new DateTime(year: 1943, month: 10, day: 1, hour: 3, minute: 55, second: 40, millisecond: 808, kind: DateTimeKind.Utc), }, }, },
    ModelInner = new DateTimetimestamp_with_time_zoneMMArrayD3E1MI
{
    Id = 57,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1962, month: 10, day: 10, hour: 5, minute: 30, second: 15, millisecond: 244, kind: DateTimeKind.Utc), new DateTime(year: 2011, month: 10, day: 2, hour: 10, minute: 43, second: 11, millisecond: 947, kind: DateTimeKind.Utc), new DateTime(year: 1978, month: 10, day: 19, hour: 7, minute: 55, second: 12, millisecond: 672, kind: DateTimeKind.Utc), }, { new DateTime(year: 2012, month: 10, day: 12, hour: 9, minute: 19, second: 11, millisecond: 639, kind: DateTimeKind.Utc), new DateTime(year: 2005, month: 10, day: 6, hour: 20, minute: 7, second: 43, millisecond: 42, kind: DateTimeKind.Utc), new DateTime(year: 1936, month: 10, day: 12, hour: 20, minute: 55, second: 47, millisecond: 538, kind: DateTimeKind.Utc), }, { new DateTime(year: 1974, month: 10, day: 15, hour: 2, minute: 13, second: 47, millisecond: 891, kind: DateTimeKind.Utc), new DateTime(year: 1935, month: 10, day: 15, hour: 22, minute: 39, second: 16, millisecond: 470, kind: DateTimeKind.Utc), new DateTime(year: 1929, month: 10, day: 7, hour: 10, minute: 15, second: 4, millisecond: 142, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1997, month: 10, day: 12, hour: 8, minute: 40, second: 44, millisecond: 257, kind: DateTimeKind.Utc), new DateTime(year: 2019, month: 10, day: 16, hour: 1, minute: 56, second: 58, millisecond: 821, kind: DateTimeKind.Utc), new DateTime(year: 1958, month: 10, day: 9, hour: 19, minute: 13, second: 38, millisecond: 389, kind: DateTimeKind.Utc), }, { new DateTime(year: 1968, month: 10, day: 18, hour: 3, minute: 24, second: 29, millisecond: 645, kind: DateTimeKind.Utc), new DateTime(year: 1983, month: 10, day: 4, hour: 6, minute: 41, second: 3, millisecond: 591, kind: DateTimeKind.Utc), new DateTime(year: 1927, month: 10, day: 17, hour: 2, minute: 19, second: 36, millisecond: 932, kind: DateTimeKind.Utc), }, { new DateTime(year: 1978, month: 10, day: 10, hour: 10, minute: 28, second: 52, millisecond: 64, kind: DateTimeKind.Utc), new DateTime(year: 1954, month: 10, day: 3, hour: 5, minute: 18, second: 25, millisecond: 955, kind: DateTimeKind.Utc), new DateTime(year: 2008, month: 10, day: 16, hour: 6, minute: 43, second: 1, millisecond: 201, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 2010, month: 10, day: 7, hour: 2, minute: 55, second: 48, millisecond: 304, kind: DateTimeKind.Utc), new DateTime(year: 1994, month: 10, day: 9, hour: 22, minute: 40, second: 44, millisecond: 431, kind: DateTimeKind.Utc), new DateTime(year: 1971, month: 10, day: 4, hour: 13, minute: 52, second: 41, millisecond: 906, kind: DateTimeKind.Utc), }, { new DateTime(year: 1959, month: 10, day: 16, hour: 14, minute: 24, second: 57, millisecond: 923, kind: DateTimeKind.Utc), new DateTime(year: 1980, month: 10, day: 11, hour: 15, minute: 27, second: 29, millisecond: 645, kind: DateTimeKind.Utc), new DateTime(year: 1929, month: 10, day: 19, hour: 8, minute: 28, second: 7, millisecond: 903, kind: DateTimeKind.Utc), }, { new DateTime(year: 2012, month: 10, day: 5, hour: 6, minute: 33, second: 41, millisecond: 647, kind: DateTimeKind.Utc), new DateTime(year: 1971, month: 10, day: 9, hour: 3, minute: 40, second: 18, millisecond: 796, kind: DateTimeKind.Utc), new DateTime(year: 1919, month: 10, day: 16, hour: 1, minute: 4, second: 2, millisecond: 350, kind: DateTimeKind.Utc), }, }, },
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1995, month: 10, day: 18, hour: 20, minute: 34, second: 6, millisecond: 641, kind: DateTimeKind.Utc), new DateTime(year: 1991, month: 10, day: 5, hour: 17, minute: 50, second: 57, millisecond: 796, kind: DateTimeKind.Utc), new DateTime(year: 1964, month: 10, day: 4, hour: 8, minute: 4, second: 20, millisecond: 743, kind: DateTimeKind.Utc), }, { new DateTime(year: 2019, month: 10, day: 13, hour: 4, minute: 1, second: 50, millisecond: 580, kind: DateTimeKind.Utc), new DateTime(year: 1959, month: 10, day: 3, hour: 20, minute: 12, second: 52, millisecond: 622, kind: DateTimeKind.Utc), new DateTime(year: 2014, month: 10, day: 3, hour: 4, minute: 54, second: 13, millisecond: 48, kind: DateTimeKind.Utc), }, { new DateTime(year: 1938, month: 10, day: 14, hour: 10, minute: 42, second: 30, millisecond: 720, kind: DateTimeKind.Utc), new DateTime(year: 2010, month: 10, day: 8, hour: 9, minute: 21, second: 49, millisecond: 351, kind: DateTimeKind.Utc), new DateTime(year: 1934, month: 10, day: 17, hour: 19, minute: 54, second: 26, millisecond: 413, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1918, month: 10, day: 18, hour: 18, minute: 56, second: 33, millisecond: 908, kind: DateTimeKind.Utc), new DateTime(year: 1935, month: 10, day: 16, hour: 20, minute: 3, second: 52, millisecond: 341, kind: DateTimeKind.Utc), new DateTime(year: 1974, month: 10, day: 5, hour: 18, minute: 31, second: 48, millisecond: 409, kind: DateTimeKind.Utc), }, { new DateTime(year: 1993, month: 10, day: 4, hour: 2, minute: 37, second: 2, millisecond: 323, kind: DateTimeKind.Utc), new DateTime(year: 1940, month: 10, day: 4, hour: 1, minute: 30, second: 3, millisecond: 471, kind: DateTimeKind.Utc), new DateTime(year: 1926, month: 10, day: 18, hour: 10, minute: 16, second: 20, millisecond: 678, kind: DateTimeKind.Utc), }, { new DateTime(year: 1952, month: 10, day: 18, hour: 6, minute: 6, second: 1, millisecond: 812, kind: DateTimeKind.Utc), new DateTime(year: 1988, month: 10, day: 13, hour: 14, minute: 48, second: 54, millisecond: 198, kind: DateTimeKind.Utc), new DateTime(year: 1921, month: 10, day: 18, hour: 17, minute: 15, second: 57, millisecond: 350, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 2009, month: 10, day: 4, hour: 4, minute: 10, second: 57, millisecond: 913, kind: DateTimeKind.Utc), new DateTime(year: 1990, month: 10, day: 4, hour: 16, minute: 26, second: 21, millisecond: 628, kind: DateTimeKind.Utc), new DateTime(year: 1938, month: 10, day: 16, hour: 16, minute: 7, second: 47, millisecond: 300, kind: DateTimeKind.Utc), }, { new DateTime(year: 1988, month: 10, day: 13, hour: 21, minute: 51, second: 44, millisecond: 157, kind: DateTimeKind.Utc), new DateTime(year: 1937, month: 10, day: 10, hour: 18, minute: 12, second: 31, millisecond: 899, kind: DateTimeKind.Utc), new DateTime(year: 1938, month: 10, day: 1, hour: 8, minute: 7, second: 15, millisecond: 195, kind: DateTimeKind.Utc), }, { new DateTime(year: 2013, month: 10, day: 5, hour: 14, minute: 49, second: 31, millisecond: 90, kind: DateTimeKind.Utc), new DateTime(year: 1929, month: 10, day: 3, hour: 14, minute: 16, second: 56, millisecond: 75, kind: DateTimeKind.Utc), new DateTime(year: 1952, month: 10, day: 12, hour: 3, minute: 8, second: 49, millisecond: 331, kind: DateTimeKind.Utc), }, }, },
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneMMArrayD3E1M
{
    Id = 93,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 2012, month: 10, day: 11, hour: 20, minute: 8, second: 21, millisecond: 509, kind: DateTimeKind.Utc), new DateTime(year: 1966, month: 10, day: 19, hour: 21, minute: 8, second: 22, millisecond: 283, kind: DateTimeKind.Utc), new DateTime(year: 1981, month: 10, day: 17, hour: 9, minute: 26, second: 38, millisecond: 9, kind: DateTimeKind.Utc), }, { new DateTime(year: 2000, month: 10, day: 5, hour: 16, minute: 25, second: 53, millisecond: 412, kind: DateTimeKind.Utc), new DateTime(year: 1917, month: 10, day: 16, hour: 16, minute: 45, second: 23, millisecond: 297, kind: DateTimeKind.Utc), new DateTime(year: 1965, month: 10, day: 1, hour: 20, minute: 51, second: 2, millisecond: 523, kind: DateTimeKind.Utc), }, { new DateTime(year: 1972, month: 10, day: 7, hour: 15, minute: 38, second: 37, millisecond: 174, kind: DateTimeKind.Utc), new DateTime(year: 2000, month: 10, day: 12, hour: 20, minute: 1, second: 39, millisecond: 776, kind: DateTimeKind.Utc), new DateTime(year: 1997, month: 10, day: 13, hour: 17, minute: 43, second: 40, millisecond: 64, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1985, month: 10, day: 7, hour: 7, minute: 48, second: 10, millisecond: 76, kind: DateTimeKind.Utc), new DateTime(year: 1925, month: 10, day: 1, hour: 10, minute: 17, second: 16, millisecond: 893, kind: DateTimeKind.Utc), new DateTime(year: 1999, month: 10, day: 4, hour: 17, minute: 7, second: 6, millisecond: 4, kind: DateTimeKind.Utc), }, { new DateTime(year: 1989, month: 10, day: 2, hour: 12, minute: 52, second: 52, millisecond: 900, kind: DateTimeKind.Utc), new DateTime(year: 2018, month: 10, day: 9, hour: 6, minute: 3, second: 12, millisecond: 458, kind: DateTimeKind.Utc), new DateTime(year: 1959, month: 10, day: 12, hour: 3, minute: 24, second: 40, millisecond: 581, kind: DateTimeKind.Utc), }, { new DateTime(year: 1965, month: 10, day: 4, hour: 15, minute: 15, second: 47, millisecond: 219, kind: DateTimeKind.Utc), new DateTime(year: 1970, month: 10, day: 6, hour: 13, minute: 30, second: 11, millisecond: 56, kind: DateTimeKind.Utc), new DateTime(year: 2018, month: 10, day: 8, hour: 10, minute: 7, second: 44, millisecond: 261, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1982, month: 10, day: 3, hour: 12, minute: 7, second: 2, millisecond: 748, kind: DateTimeKind.Utc), new DateTime(year: 1950, month: 10, day: 17, hour: 8, minute: 10, second: 43, millisecond: 134, kind: DateTimeKind.Utc), new DateTime(year: 1917, month: 10, day: 10, hour: 12, minute: 42, second: 54, millisecond: 189, kind: DateTimeKind.Utc), }, { new DateTime(year: 1919, month: 10, day: 7, hour: 11, minute: 39, second: 48, millisecond: 844, kind: DateTimeKind.Utc), new DateTime(year: 1958, month: 10, day: 19, hour: 19, minute: 1, second: 16, millisecond: 67, kind: DateTimeKind.Utc), new DateTime(year: 1999, month: 10, day: 12, hour: 8, minute: 4, second: 21, millisecond: 967, kind: DateTimeKind.Utc), }, { new DateTime(year: 1975, month: 10, day: 13, hour: 4, minute: 26, second: 49, millisecond: 487, kind: DateTimeKind.Utc), new DateTime(year: 1987, month: 10, day: 16, hour: 19, minute: 52, second: 18, millisecond: 409, kind: DateTimeKind.Utc), new DateTime(year: 2011, month: 10, day: 13, hour: 11, minute: 47, second: 29, millisecond: 310, kind: DateTimeKind.Utc), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneMMArrayD3E1M
{
    Id = 100,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1922, month: 10, day: 15, hour: 19, minute: 54, second: 49, millisecond: 283, kind: DateTimeKind.Utc), new DateTime(year: 2013, month: 10, day: 11, hour: 7, minute: 33, second: 23, millisecond: 32, kind: DateTimeKind.Utc), new DateTime(year: 1954, month: 10, day: 18, hour: 2, minute: 55, second: 41, millisecond: 916, kind: DateTimeKind.Utc), }, { new DateTime(year: 1950, month: 10, day: 9, hour: 3, minute: 45, second: 38, millisecond: 254, kind: DateTimeKind.Utc), new DateTime(year: 1948, month: 10, day: 2, hour: 3, minute: 41, second: 45, millisecond: 336, kind: DateTimeKind.Utc), new DateTime(year: 1983, month: 10, day: 14, hour: 3, minute: 57, second: 32, millisecond: 111, kind: DateTimeKind.Utc), }, { new DateTime(year: 1918, month: 10, day: 8, hour: 21, minute: 36, second: 2, millisecond: 155, kind: DateTimeKind.Utc), new DateTime(year: 1944, month: 10, day: 14, hour: 17, minute: 25, second: 27, millisecond: 139, kind: DateTimeKind.Utc), new DateTime(year: 1934, month: 10, day: 6, hour: 10, minute: 20, second: 48, millisecond: 34, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1944, month: 10, day: 18, hour: 21, minute: 31, second: 26, millisecond: 203, kind: DateTimeKind.Utc), new DateTime(year: 1995, month: 10, day: 14, hour: 10, minute: 20, second: 11, millisecond: 546, kind: DateTimeKind.Utc), new DateTime(year: 1946, month: 10, day: 5, hour: 10, minute: 31, second: 52, millisecond: 337, kind: DateTimeKind.Utc), }, { new DateTime(year: 1923, month: 10, day: 5, hour: 7, minute: 44, second: 8, millisecond: 671, kind: DateTimeKind.Utc), new DateTime(year: 1976, month: 10, day: 16, hour: 19, minute: 37, second: 54, millisecond: 86, kind: DateTimeKind.Utc), new DateTime(year: 1958, month: 10, day: 1, hour: 22, minute: 21, second: 22, millisecond: 826, kind: DateTimeKind.Utc), }, { new DateTime(year: 1952, month: 10, day: 17, hour: 16, minute: 14, second: 46, millisecond: 518, kind: DateTimeKind.Utc), new DateTime(year: 1934, month: 10, day: 18, hour: 5, minute: 24, second: 19, millisecond: 505, kind: DateTimeKind.Utc), new DateTime(year: 1943, month: 10, day: 8, hour: 1, minute: 9, second: 37, millisecond: 437, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1938, month: 10, day: 1, hour: 1, minute: 8, second: 34, millisecond: 796, kind: DateTimeKind.Utc), new DateTime(year: 1924, month: 10, day: 17, hour: 16, minute: 21, second: 30, millisecond: 134, kind: DateTimeKind.Utc), new DateTime(year: 1989, month: 10, day: 1, hour: 2, minute: 6, second: 30, millisecond: 149, kind: DateTimeKind.Utc), }, { new DateTime(year: 1949, month: 10, day: 11, hour: 16, minute: 16, second: 31, millisecond: 532, kind: DateTimeKind.Utc), new DateTime(year: 1948, month: 10, day: 14, hour: 15, minute: 12, second: 13, millisecond: 436, kind: DateTimeKind.Utc), new DateTime(year: 2006, month: 10, day: 9, hour: 10, minute: 57, second: 38, millisecond: 32, kind: DateTimeKind.Utc), }, { new DateTime(year: 1998, month: 10, day: 10, hour: 17, minute: 8, second: 18, millisecond: 469, kind: DateTimeKind.Utc), new DateTime(year: 1924, month: 10, day: 18, hour: 20, minute: 12, second: 54, millisecond: 567, kind: DateTimeKind.Utc), new DateTime(year: 1942, month: 10, day: 6, hour: 6, minute: 17, second: 55, millisecond: 546, kind: DateTimeKind.Utc), }, }, },
    ModelInner = new DateTimetimestamp_with_time_zoneMMArrayD3E1MI
{
    Id = 63,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1986, month: 10, day: 18, hour: 18, minute: 47, second: 41, millisecond: 482, kind: DateTimeKind.Utc), new DateTime(year: 1941, month: 10, day: 2, hour: 9, minute: 19, second: 40, millisecond: 331, kind: DateTimeKind.Utc), new DateTime(year: 2007, month: 10, day: 19, hour: 12, minute: 35, second: 14, millisecond: 261, kind: DateTimeKind.Utc), }, { new DateTime(year: 2000, month: 10, day: 1, hour: 14, minute: 18, second: 26, millisecond: 955, kind: DateTimeKind.Utc), new DateTime(year: 1938, month: 10, day: 18, hour: 2, minute: 1, second: 17, millisecond: 496, kind: DateTimeKind.Utc), new DateTime(year: 1935, month: 10, day: 3, hour: 13, minute: 1, second: 17, millisecond: 659, kind: DateTimeKind.Utc), }, { new DateTime(year: 1952, month: 10, day: 12, hour: 5, minute: 54, second: 55, millisecond: 49, kind: DateTimeKind.Utc), new DateTime(year: 1944, month: 10, day: 11, hour: 14, minute: 19, second: 40, millisecond: 624, kind: DateTimeKind.Utc), new DateTime(year: 1973, month: 10, day: 6, hour: 6, minute: 16, second: 15, millisecond: 504, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1950, month: 10, day: 17, hour: 22, minute: 26, second: 58, millisecond: 182, kind: DateTimeKind.Utc), new DateTime(year: 1945, month: 10, day: 5, hour: 22, minute: 12, second: 56, millisecond: 821, kind: DateTimeKind.Utc), new DateTime(year: 1925, month: 10, day: 5, hour: 5, minute: 52, second: 12, millisecond: 380, kind: DateTimeKind.Utc), }, { new DateTime(year: 1977, month: 10, day: 8, hour: 15, minute: 25, second: 18, millisecond: 642, kind: DateTimeKind.Utc), new DateTime(year: 2003, month: 10, day: 11, hour: 20, minute: 15, second: 52, millisecond: 676, kind: DateTimeKind.Utc), new DateTime(year: 1939, month: 10, day: 11, hour: 10, minute: 57, second: 10, millisecond: 303, kind: DateTimeKind.Utc), }, { new DateTime(year: 1977, month: 10, day: 15, hour: 19, minute: 10, second: 20, millisecond: 852, kind: DateTimeKind.Utc), new DateTime(year: 1959, month: 10, day: 19, hour: 18, minute: 35, second: 30, millisecond: 262, kind: DateTimeKind.Utc), new DateTime(year: 1942, month: 10, day: 3, hour: 1, minute: 40, second: 43, millisecond: 566, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 2013, month: 10, day: 7, hour: 15, minute: 21, second: 11, millisecond: 150, kind: DateTimeKind.Utc), new DateTime(year: 2015, month: 10, day: 8, hour: 9, minute: 14, second: 3, millisecond: 855, kind: DateTimeKind.Utc), new DateTime(year: 1944, month: 10, day: 5, hour: 13, minute: 43, second: 53, millisecond: 507, kind: DateTimeKind.Utc), }, { new DateTime(year: 1977, month: 10, day: 12, hour: 18, minute: 38, second: 2, millisecond: 16, kind: DateTimeKind.Utc), new DateTime(year: 1998, month: 10, day: 4, hour: 1, minute: 56, second: 41, millisecond: 122, kind: DateTimeKind.Utc), new DateTime(year: 1995, month: 10, day: 7, hour: 9, minute: 43, second: 4, millisecond: 459, kind: DateTimeKind.Utc), }, { new DateTime(year: 1986, month: 10, day: 3, hour: 3, minute: 41, second: 56, millisecond: 875, kind: DateTimeKind.Utc), new DateTime(year: 1982, month: 10, day: 6, hour: 8, minute: 49, second: 13, millisecond: 455, kind: DateTimeKind.Utc), new DateTime(year: 1979, month: 10, day: 10, hour: 1, minute: 31, second: 55, millisecond: 393, kind: DateTimeKind.Utc), }, }, },
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1945, month: 10, day: 1, hour: 12, minute: 40, second: 25, millisecond: 492, kind: DateTimeKind.Utc), new DateTime(year: 1958, month: 10, day: 2, hour: 16, minute: 1, second: 40, millisecond: 465, kind: DateTimeKind.Utc), new DateTime(year: 1940, month: 10, day: 15, hour: 22, minute: 7, second: 52, millisecond: 266, kind: DateTimeKind.Utc), }, { new DateTime(year: 1940, month: 10, day: 18, hour: 12, minute: 2, second: 53, millisecond: 408, kind: DateTimeKind.Utc), new DateTime(year: 1920, month: 10, day: 19, hour: 22, minute: 25, second: 32, millisecond: 292, kind: DateTimeKind.Utc), new DateTime(year: 2011, month: 10, day: 14, hour: 2, minute: 36, second: 47, millisecond: 417, kind: DateTimeKind.Utc), }, { new DateTime(year: 1942, month: 10, day: 19, hour: 20, minute: 4, second: 49, millisecond: 27, kind: DateTimeKind.Utc), new DateTime(year: 1936, month: 10, day: 3, hour: 21, minute: 18, second: 18, millisecond: 579, kind: DateTimeKind.Utc), new DateTime(year: 1939, month: 10, day: 5, hour: 6, minute: 58, second: 12, millisecond: 971, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1924, month: 10, day: 1, hour: 6, minute: 50, second: 48, millisecond: 273, kind: DateTimeKind.Utc), new DateTime(year: 1935, month: 10, day: 9, hour: 3, minute: 35, second: 36, millisecond: 857, kind: DateTimeKind.Utc), new DateTime(year: 1925, month: 10, day: 19, hour: 12, minute: 57, second: 57, millisecond: 518, kind: DateTimeKind.Utc), }, { new DateTime(year: 1927, month: 10, day: 12, hour: 19, minute: 30, second: 6, millisecond: 161, kind: DateTimeKind.Utc), new DateTime(year: 2004, month: 10, day: 9, hour: 13, minute: 25, second: 38, millisecond: 533, kind: DateTimeKind.Utc), new DateTime(year: 1936, month: 10, day: 17, hour: 10, minute: 22, second: 5, millisecond: 675, kind: DateTimeKind.Utc), }, { new DateTime(year: 2002, month: 10, day: 1, hour: 8, minute: 29, second: 50, millisecond: 888, kind: DateTimeKind.Utc), new DateTime(year: 1930, month: 10, day: 6, hour: 14, minute: 6, second: 56, millisecond: 70, kind: DateTimeKind.Utc), new DateTime(year: 1919, month: 10, day: 15, hour: 13, minute: 34, second: 28, millisecond: 775, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1964, month: 10, day: 18, hour: 9, minute: 17, second: 32, millisecond: 672, kind: DateTimeKind.Utc), new DateTime(year: 1962, month: 10, day: 13, hour: 17, minute: 41, second: 25, millisecond: 716, kind: DateTimeKind.Utc), new DateTime(year: 1927, month: 10, day: 15, hour: 1, minute: 28, second: 7, millisecond: 500, kind: DateTimeKind.Utc), }, { new DateTime(year: 1989, month: 10, day: 13, hour: 2, minute: 28, second: 8, millisecond: 605, kind: DateTimeKind.Utc), new DateTime(year: 1953, month: 10, day: 11, hour: 6, minute: 19, second: 38, millisecond: 110, kind: DateTimeKind.Utc), new DateTime(year: 1997, month: 10, day: 4, hour: 19, minute: 15, second: 21, millisecond: 563, kind: DateTimeKind.Utc), }, { new DateTime(year: 1963, month: 10, day: 9, hour: 10, minute: 36, second: 40, millisecond: 448, kind: DateTimeKind.Utc), new DateTime(year: 1960, month: 10, day: 19, hour: 22, minute: 28, second: 18, millisecond: 519, kind: DateTimeKind.Utc), new DateTime(year: 2008, month: 10, day: 18, hour: 2, minute: 14, second: 33, millisecond: 847, kind: DateTimeKind.Utc), }, }, },
},
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1978, month: 10, day: 5, hour: 9, minute: 53, second: 40, millisecond: 504, kind: DateTimeKind.Utc), new DateTime(year: 1985, month: 10, day: 9, hour: 10, minute: 36, second: 41, millisecond: 398, kind: DateTimeKind.Utc), new DateTime(year: 1940, month: 10, day: 4, hour: 14, minute: 14, second: 34, millisecond: 817, kind: DateTimeKind.Utc), }, { new DateTime(year: 1921, month: 10, day: 10, hour: 7, minute: 33, second: 56, millisecond: 65, kind: DateTimeKind.Utc), new DateTime(year: 1968, month: 10, day: 5, hour: 3, minute: 58, second: 11, millisecond: 596, kind: DateTimeKind.Utc), new DateTime(year: 1934, month: 10, day: 19, hour: 15, minute: 49, second: 12, millisecond: 79, kind: DateTimeKind.Utc), }, { new DateTime(year: 2004, month: 10, day: 17, hour: 18, minute: 2, second: 54, millisecond: 809, kind: DateTimeKind.Utc), new DateTime(year: 1957, month: 10, day: 12, hour: 18, minute: 2, second: 34, millisecond: 943, kind: DateTimeKind.Utc), new DateTime(year: 1918, month: 10, day: 10, hour: 6, minute: 40, second: 7, millisecond: 508, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1940, month: 10, day: 13, hour: 1, minute: 10, second: 5, millisecond: 210, kind: DateTimeKind.Utc), new DateTime(year: 1918, month: 10, day: 6, hour: 7, minute: 11, second: 31, millisecond: 763, kind: DateTimeKind.Utc), new DateTime(year: 1976, month: 10, day: 12, hour: 8, minute: 50, second: 47, millisecond: 549, kind: DateTimeKind.Utc), }, { new DateTime(year: 2012, month: 10, day: 11, hour: 20, minute: 23, second: 54, millisecond: 461, kind: DateTimeKind.Utc), new DateTime(year: 1970, month: 10, day: 19, hour: 20, minute: 32, second: 54, millisecond: 915, kind: DateTimeKind.Utc), new DateTime(year: 1930, month: 10, day: 7, hour: 13, minute: 48, second: 49, millisecond: 557, kind: DateTimeKind.Utc), }, { new DateTime(year: 1949, month: 10, day: 3, hour: 3, minute: 43, second: 45, millisecond: 484, kind: DateTimeKind.Utc), new DateTime(year: 1969, month: 10, day: 12, hour: 5, minute: 16, second: 49, millisecond: 679, kind: DateTimeKind.Utc), new DateTime(year: 1964, month: 10, day: 16, hour: 7, minute: 8, second: 50, millisecond: 199, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1990, month: 10, day: 14, hour: 7, minute: 18, second: 45, millisecond: 59, kind: DateTimeKind.Utc), new DateTime(year: 1957, month: 10, day: 3, hour: 4, minute: 27, second: 53, millisecond: 175, kind: DateTimeKind.Utc), new DateTime(year: 2019, month: 10, day: 4, hour: 5, minute: 6, second: 44, millisecond: 981, kind: DateTimeKind.Utc), }, { new DateTime(year: 2010, month: 10, day: 13, hour: 6, minute: 39, second: 7, millisecond: 981, kind: DateTimeKind.Utc), new DateTime(year: 1972, month: 10, day: 6, hour: 9, minute: 57, second: 53, millisecond: 201, kind: DateTimeKind.Utc), new DateTime(year: 1989, month: 10, day: 14, hour: 7, minute: 45, second: 51, millisecond: 213, kind: DateTimeKind.Utc), }, { new DateTime(year: 1918, month: 10, day: 2, hour: 4, minute: 28, second: 2, millisecond: 436, kind: DateTimeKind.Utc), new DateTime(year: 2016, month: 10, day: 19, hour: 4, minute: 54, second: 33, millisecond: 321, kind: DateTimeKind.Utc), new DateTime(year: 1938, month: 10, day: 9, hour: 10, minute: 26, second: 34, millisecond: 385, kind: DateTimeKind.Utc), }, }, },
},
            new DateTimetimestamp_with_time_zoneMMArrayD3E1M
{
    Id = 105,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 2012, month: 10, day: 13, hour: 18, minute: 32, second: 11, millisecond: 120, kind: DateTimeKind.Utc), new DateTime(year: 1970, month: 10, day: 7, hour: 14, minute: 15, second: 15, millisecond: 874, kind: DateTimeKind.Utc), new DateTime(year: 1994, month: 10, day: 5, hour: 3, minute: 39, second: 39, millisecond: 575, kind: DateTimeKind.Utc), }, { new DateTime(year: 1948, month: 10, day: 2, hour: 21, minute: 6, second: 48, millisecond: 953, kind: DateTimeKind.Utc), new DateTime(year: 1987, month: 10, day: 11, hour: 20, minute: 4, second: 53, millisecond: 735, kind: DateTimeKind.Utc), new DateTime(year: 1992, month: 10, day: 13, hour: 9, minute: 3, second: 9, millisecond: 195, kind: DateTimeKind.Utc), }, { new DateTime(year: 1943, month: 10, day: 2, hour: 16, minute: 48, second: 41, millisecond: 9, kind: DateTimeKind.Utc), new DateTime(year: 1932, month: 10, day: 4, hour: 18, minute: 5, second: 9, millisecond: 62, kind: DateTimeKind.Utc), new DateTime(year: 1980, month: 10, day: 10, hour: 2, minute: 40, second: 18, millisecond: 473, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1969, month: 10, day: 10, hour: 12, minute: 36, second: 1, millisecond: 215, kind: DateTimeKind.Utc), new DateTime(year: 1980, month: 10, day: 12, hour: 13, minute: 41, second: 49, millisecond: 459, kind: DateTimeKind.Utc), new DateTime(year: 1950, month: 10, day: 14, hour: 19, minute: 4, second: 21, millisecond: 728, kind: DateTimeKind.Utc), }, { new DateTime(year: 1990, month: 10, day: 11, hour: 20, minute: 30, second: 36, millisecond: 998, kind: DateTimeKind.Utc), new DateTime(year: 1991, month: 10, day: 2, hour: 5, minute: 21, second: 32, millisecond: 658, kind: DateTimeKind.Utc), new DateTime(year: 1944, month: 10, day: 4, hour: 5, minute: 27, second: 25, millisecond: 789, kind: DateTimeKind.Utc), }, { new DateTime(year: 1985, month: 10, day: 6, hour: 4, minute: 29, second: 33, millisecond: 664, kind: DateTimeKind.Utc), new DateTime(year: 1967, month: 10, day: 5, hour: 21, minute: 7, second: 22, millisecond: 268, kind: DateTimeKind.Utc), new DateTime(year: 2006, month: 10, day: 17, hour: 5, minute: 55, second: 27, millisecond: 821, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1965, month: 10, day: 19, hour: 13, minute: 34, second: 32, millisecond: 922, kind: DateTimeKind.Utc), new DateTime(year: 1939, month: 10, day: 5, hour: 21, minute: 10, second: 7, millisecond: 19, kind: DateTimeKind.Utc), new DateTime(year: 1985, month: 10, day: 17, hour: 7, minute: 33, second: 20, millisecond: 234, kind: DateTimeKind.Utc), }, { new DateTime(year: 1994, month: 10, day: 15, hour: 10, minute: 2, second: 54, millisecond: 205, kind: DateTimeKind.Utc), new DateTime(year: 1996, month: 10, day: 6, hour: 7, minute: 11, second: 42, millisecond: 945, kind: DateTimeKind.Utc), new DateTime(year: 1924, month: 10, day: 17, hour: 13, minute: 14, second: 12, millisecond: 691, kind: DateTimeKind.Utc), }, { new DateTime(year: 1925, month: 10, day: 14, hour: 15, minute: 57, second: 34, millisecond: 979, kind: DateTimeKind.Utc), new DateTime(year: 2003, month: 10, day: 19, hour: 21, minute: 12, second: 58, millisecond: 557, kind: DateTimeKind.Utc), new DateTime(year: 1994, month: 10, day: 14, hour: 22, minute: 43, second: 46, millisecond: 480, kind: DateTimeKind.Utc), }, }, },
    ModelInner = null,
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 2019, month: 10, day: 2, hour: 11, minute: 13, second: 5, millisecond: 656, kind: DateTimeKind.Utc), new DateTime(year: 1982, month: 10, day: 13, hour: 21, minute: 3, second: 38, millisecond: 162, kind: DateTimeKind.Utc), new DateTime(year: 1964, month: 10, day: 12, hour: 15, minute: 17, second: 7, millisecond: 976, kind: DateTimeKind.Utc), }, { new DateTime(year: 1922, month: 10, day: 4, hour: 6, minute: 16, second: 26, millisecond: 12, kind: DateTimeKind.Utc), new DateTime(year: 1927, month: 10, day: 8, hour: 12, minute: 1, second: 49, millisecond: 961, kind: DateTimeKind.Utc), new DateTime(year: 1968, month: 10, day: 19, hour: 3, minute: 2, second: 10, millisecond: 778, kind: DateTimeKind.Utc), }, { new DateTime(year: 1921, month: 10, day: 15, hour: 16, minute: 50, second: 8, millisecond: 790, kind: DateTimeKind.Utc), new DateTime(year: 1972, month: 10, day: 3, hour: 8, minute: 30, second: 14, millisecond: 117, kind: DateTimeKind.Utc), new DateTime(year: 1979, month: 10, day: 11, hour: 9, minute: 24, second: 38, millisecond: 434, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1938, month: 10, day: 6, hour: 3, minute: 17, second: 58, millisecond: 12, kind: DateTimeKind.Utc), new DateTime(year: 1974, month: 10, day: 12, hour: 20, minute: 45, second: 23, millisecond: 296, kind: DateTimeKind.Utc), new DateTime(year: 1996, month: 10, day: 14, hour: 1, minute: 41, second: 8, millisecond: 3, kind: DateTimeKind.Utc), }, { new DateTime(year: 2019, month: 10, day: 9, hour: 4, minute: 55, second: 46, millisecond: 181, kind: DateTimeKind.Utc), new DateTime(year: 2003, month: 10, day: 19, hour: 10, minute: 12, second: 33, millisecond: 811, kind: DateTimeKind.Utc), new DateTime(year: 1960, month: 10, day: 3, hour: 21, minute: 31, second: 38, millisecond: 314, kind: DateTimeKind.Utc), }, { new DateTime(year: 1938, month: 10, day: 14, hour: 19, minute: 31, second: 12, millisecond: 483, kind: DateTimeKind.Utc), new DateTime(year: 1984, month: 10, day: 14, hour: 5, minute: 50, second: 33, millisecond: 72, kind: DateTimeKind.Utc), new DateTime(year: 1929, month: 10, day: 18, hour: 15, minute: 50, second: 39, millisecond: 149, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1942, month: 10, day: 15, hour: 17, minute: 30, second: 17, millisecond: 105, kind: DateTimeKind.Utc), new DateTime(year: 1980, month: 10, day: 7, hour: 2, minute: 52, second: 44, millisecond: 969, kind: DateTimeKind.Utc), new DateTime(year: 1959, month: 10, day: 14, hour: 9, minute: 23, second: 43, millisecond: 977, kind: DateTimeKind.Utc), }, { new DateTime(year: 1948, month: 10, day: 15, hour: 8, minute: 36, second: 46, millisecond: 289, kind: DateTimeKind.Utc), new DateTime(year: 2002, month: 10, day: 17, hour: 18, minute: 9, second: 35, millisecond: 645, kind: DateTimeKind.Utc), new DateTime(year: 1973, month: 10, day: 3, hour: 1, minute: 24, second: 35, millisecond: 978, kind: DateTimeKind.Utc), }, { new DateTime(year: 1956, month: 10, day: 6, hour: 8, minute: 40, second: 6, millisecond: 479, kind: DateTimeKind.Utc), new DateTime(year: 2007, month: 10, day: 10, hour: 19, minute: 47, second: 33, millisecond: 843, kind: DateTimeKind.Utc), new DateTime(year: 1972, month: 10, day: 13, hour: 9, minute: 7, second: 38, millisecond: 735, kind: DateTimeKind.Utc), }, }, },
},
            new DateTimetimestamp_with_time_zoneMMArrayD3E1M
{
    Id = 113,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1979, month: 10, day: 18, hour: 6, minute: 42, second: 20, millisecond: 710, kind: DateTimeKind.Utc), new DateTime(year: 1939, month: 10, day: 15, hour: 1, minute: 11, second: 32, millisecond: 843, kind: DateTimeKind.Utc), new DateTime(year: 1931, month: 10, day: 5, hour: 18, minute: 38, second: 25, millisecond: 596, kind: DateTimeKind.Utc), }, { new DateTime(year: 1998, month: 10, day: 16, hour: 11, minute: 16, second: 27, millisecond: 394, kind: DateTimeKind.Utc), new DateTime(year: 2017, month: 10, day: 13, hour: 10, minute: 52, second: 14, millisecond: 735, kind: DateTimeKind.Utc), new DateTime(year: 1995, month: 10, day: 12, hour: 20, minute: 7, second: 2, millisecond: 230, kind: DateTimeKind.Utc), }, { new DateTime(year: 2009, month: 10, day: 6, hour: 18, minute: 18, second: 21, millisecond: 832, kind: DateTimeKind.Utc), new DateTime(year: 1923, month: 10, day: 15, hour: 4, minute: 18, second: 36, millisecond: 395, kind: DateTimeKind.Utc), new DateTime(year: 1983, month: 10, day: 3, hour: 22, minute: 26, second: 25, millisecond: 866, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1933, month: 10, day: 9, hour: 9, minute: 1, second: 1, millisecond: 802, kind: DateTimeKind.Utc), new DateTime(year: 1999, month: 10, day: 12, hour: 17, minute: 22, second: 45, millisecond: 85, kind: DateTimeKind.Utc), new DateTime(year: 1945, month: 10, day: 4, hour: 5, minute: 7, second: 30, millisecond: 981, kind: DateTimeKind.Utc), }, { new DateTime(year: 1922, month: 10, day: 19, hour: 2, minute: 25, second: 40, millisecond: 546, kind: DateTimeKind.Utc), new DateTime(year: 1952, month: 10, day: 15, hour: 8, minute: 19, second: 8, millisecond: 723, kind: DateTimeKind.Utc), new DateTime(year: 1984, month: 10, day: 6, hour: 18, minute: 25, second: 23, millisecond: 152, kind: DateTimeKind.Utc), }, { new DateTime(year: 1936, month: 10, day: 13, hour: 11, minute: 32, second: 15, millisecond: 143, kind: DateTimeKind.Utc), new DateTime(year: 1970, month: 10, day: 9, hour: 18, minute: 24, second: 56, millisecond: 755, kind: DateTimeKind.Utc), new DateTime(year: 1938, month: 10, day: 4, hour: 21, minute: 12, second: 6, millisecond: 290, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1926, month: 10, day: 19, hour: 10, minute: 17, second: 23, millisecond: 780, kind: DateTimeKind.Utc), new DateTime(year: 1955, month: 10, day: 13, hour: 17, minute: 50, second: 5, millisecond: 586, kind: DateTimeKind.Utc), new DateTime(year: 1937, month: 10, day: 17, hour: 5, minute: 56, second: 46, millisecond: 295, kind: DateTimeKind.Utc), }, { new DateTime(year: 2002, month: 10, day: 12, hour: 1, minute: 26, second: 24, millisecond: 835, kind: DateTimeKind.Utc), new DateTime(year: 1995, month: 10, day: 16, hour: 13, minute: 39, second: 43, millisecond: 253, kind: DateTimeKind.Utc), new DateTime(year: 1947, month: 10, day: 17, hour: 21, minute: 5, second: 15, millisecond: 331, kind: DateTimeKind.Utc), }, { new DateTime(year: 1990, month: 10, day: 14, hour: 13, minute: 33, second: 38, millisecond: 32, kind: DateTimeKind.Utc), new DateTime(year: 1922, month: 10, day: 4, hour: 3, minute: 13, second: 45, millisecond: 379, kind: DateTimeKind.Utc), new DateTime(year: 1932, month: 10, day: 19, hour: 20, minute: 13, second: 43, millisecond: 79, kind: DateTimeKind.Utc), }, }, },
    ModelInner = new DateTimetimestamp_with_time_zoneMMArrayD3E1MI
{
    Id = 72,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1980, month: 10, day: 3, hour: 7, minute: 46, second: 43, millisecond: 368, kind: DateTimeKind.Utc), new DateTime(year: 1984, month: 10, day: 14, hour: 21, minute: 22, second: 36, millisecond: 337, kind: DateTimeKind.Utc), new DateTime(year: 1935, month: 10, day: 4, hour: 7, minute: 56, second: 8, millisecond: 804, kind: DateTimeKind.Utc), }, { new DateTime(year: 1959, month: 10, day: 5, hour: 1, minute: 7, second: 34, millisecond: 415, kind: DateTimeKind.Utc), new DateTime(year: 1987, month: 10, day: 3, hour: 14, minute: 1, second: 14, millisecond: 958, kind: DateTimeKind.Utc), new DateTime(year: 1965, month: 10, day: 2, hour: 5, minute: 38, second: 53, millisecond: 312, kind: DateTimeKind.Utc), }, { new DateTime(year: 1976, month: 10, day: 18, hour: 16, minute: 29, second: 3, millisecond: 697, kind: DateTimeKind.Utc), new DateTime(year: 2014, month: 10, day: 19, hour: 4, minute: 39, second: 14, millisecond: 277, kind: DateTimeKind.Utc), new DateTime(year: 2002, month: 10, day: 11, hour: 8, minute: 57, second: 23, millisecond: 463, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 2008, month: 10, day: 16, hour: 12, minute: 38, second: 49, millisecond: 545, kind: DateTimeKind.Utc), new DateTime(year: 1964, month: 10, day: 4, hour: 16, minute: 5, second: 16, millisecond: 998, kind: DateTimeKind.Utc), new DateTime(year: 1967, month: 10, day: 2, hour: 19, minute: 23, second: 13, millisecond: 607, kind: DateTimeKind.Utc), }, { new DateTime(year: 1917, month: 10, day: 14, hour: 4, minute: 24, second: 22, millisecond: 271, kind: DateTimeKind.Utc), new DateTime(year: 1930, month: 10, day: 6, hour: 12, minute: 58, second: 38, millisecond: 758, kind: DateTimeKind.Utc), new DateTime(year: 1944, month: 10, day: 9, hour: 8, minute: 55, second: 26, millisecond: 590, kind: DateTimeKind.Utc), }, { new DateTime(year: 1962, month: 10, day: 8, hour: 7, minute: 27, second: 17, millisecond: 728, kind: DateTimeKind.Utc), new DateTime(year: 1997, month: 10, day: 12, hour: 15, minute: 34, second: 57, millisecond: 396, kind: DateTimeKind.Utc), new DateTime(year: 2006, month: 10, day: 12, hour: 21, minute: 17, second: 5, millisecond: 684, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1990, month: 10, day: 8, hour: 19, minute: 8, second: 48, millisecond: 613, kind: DateTimeKind.Utc), new DateTime(year: 2016, month: 10, day: 3, hour: 9, minute: 6, second: 42, millisecond: 664, kind: DateTimeKind.Utc), new DateTime(year: 1991, month: 10, day: 8, hour: 7, minute: 21, second: 29, millisecond: 637, kind: DateTimeKind.Utc), }, { new DateTime(year: 1975, month: 10, day: 2, hour: 9, minute: 17, second: 36, millisecond: 109, kind: DateTimeKind.Utc), new DateTime(year: 1991, month: 10, day: 16, hour: 11, minute: 58, second: 25, millisecond: 610, kind: DateTimeKind.Utc), new DateTime(year: 1927, month: 10, day: 19, hour: 1, minute: 32, second: 20, millisecond: 946, kind: DateTimeKind.Utc), }, { new DateTime(year: 1982, month: 10, day: 4, hour: 13, minute: 57, second: 44, millisecond: 935, kind: DateTimeKind.Utc), new DateTime(year: 1996, month: 10, day: 1, hour: 2, minute: 38, second: 34, millisecond: 345, kind: DateTimeKind.Utc), new DateTime(year: 1964, month: 10, day: 13, hour: 16, minute: 5, second: 25, millisecond: 171, kind: DateTimeKind.Utc), }, }, },
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1994, month: 10, day: 12, hour: 22, minute: 35, second: 53, millisecond: 569, kind: DateTimeKind.Utc), new DateTime(year: 1947, month: 10, day: 10, hour: 1, minute: 21, second: 47, millisecond: 931, kind: DateTimeKind.Utc), new DateTime(year: 1935, month: 10, day: 10, hour: 6, minute: 20, second: 15, millisecond: 148, kind: DateTimeKind.Utc), }, { new DateTime(year: 2002, month: 10, day: 19, hour: 9, minute: 31, second: 4, millisecond: 941, kind: DateTimeKind.Utc), new DateTime(year: 2013, month: 10, day: 14, hour: 12, minute: 39, second: 52, millisecond: 989, kind: DateTimeKind.Utc), new DateTime(year: 1925, month: 10, day: 9, hour: 9, minute: 20, second: 34, millisecond: 351, kind: DateTimeKind.Utc), }, { new DateTime(year: 1975, month: 10, day: 13, hour: 14, minute: 32, second: 49, millisecond: 966, kind: DateTimeKind.Utc), new DateTime(year: 1950, month: 10, day: 11, hour: 21, minute: 33, second: 47, millisecond: 733, kind: DateTimeKind.Utc), new DateTime(year: 1978, month: 10, day: 1, hour: 3, minute: 35, second: 3, millisecond: 754, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1962, month: 10, day: 2, hour: 1, minute: 57, second: 53, millisecond: 109, kind: DateTimeKind.Utc), new DateTime(year: 2014, month: 10, day: 1, hour: 16, minute: 53, second: 26, millisecond: 85, kind: DateTimeKind.Utc), new DateTime(year: 1929, month: 10, day: 17, hour: 12, minute: 3, second: 6, millisecond: 257, kind: DateTimeKind.Utc), }, { new DateTime(year: 1932, month: 10, day: 1, hour: 16, minute: 11, second: 44, millisecond: 334, kind: DateTimeKind.Utc), new DateTime(year: 1920, month: 10, day: 7, hour: 5, minute: 49, second: 19, millisecond: 753, kind: DateTimeKind.Utc), new DateTime(year: 1985, month: 10, day: 12, hour: 5, minute: 9, second: 37, millisecond: 464, kind: DateTimeKind.Utc), }, { new DateTime(year: 1917, month: 10, day: 15, hour: 10, minute: 13, second: 29, millisecond: 210, kind: DateTimeKind.Utc), new DateTime(year: 1939, month: 10, day: 15, hour: 11, minute: 1, second: 2, millisecond: 803, kind: DateTimeKind.Utc), new DateTime(year: 1974, month: 10, day: 19, hour: 6, minute: 21, second: 45, millisecond: 165, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1965, month: 10, day: 18, hour: 7, minute: 44, second: 36, millisecond: 155, kind: DateTimeKind.Utc), new DateTime(year: 2006, month: 10, day: 11, hour: 17, minute: 16, second: 10, millisecond: 518, kind: DateTimeKind.Utc), new DateTime(year: 1924, month: 10, day: 9, hour: 20, minute: 17, second: 46, millisecond: 585, kind: DateTimeKind.Utc), }, { new DateTime(year: 1974, month: 10, day: 4, hour: 1, minute: 41, second: 29, millisecond: 470, kind: DateTimeKind.Utc), new DateTime(year: 2017, month: 10, day: 11, hour: 9, minute: 39, second: 6, millisecond: 966, kind: DateTimeKind.Utc), new DateTime(year: 1927, month: 10, day: 16, hour: 8, minute: 24, second: 34, millisecond: 262, kind: DateTimeKind.Utc), }, { new DateTime(year: 1921, month: 10, day: 11, hour: 1, minute: 9, second: 12, millisecond: 801, kind: DateTimeKind.Utc), new DateTime(year: 1951, month: 10, day: 5, hour: 11, minute: 4, second: 49, millisecond: 604, kind: DateTimeKind.Utc), new DateTime(year: 1928, month: 10, day: 14, hour: 10, minute: 23, second: 23, millisecond: 96, kind: DateTimeKind.Utc), }, }, },
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneMMArrayD3E1M
{
    Id = 122,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1932, month: 10, day: 9, hour: 7, minute: 15, second: 6, millisecond: 256, kind: DateTimeKind.Utc), new DateTime(year: 2013, month: 10, day: 16, hour: 12, minute: 22, second: 38, millisecond: 694, kind: DateTimeKind.Utc), new DateTime(year: 1919, month: 10, day: 16, hour: 19, minute: 48, second: 43, millisecond: 942, kind: DateTimeKind.Utc), }, { new DateTime(year: 1923, month: 10, day: 10, hour: 18, minute: 27, second: 18, millisecond: 458, kind: DateTimeKind.Utc), new DateTime(year: 2014, month: 10, day: 10, hour: 15, minute: 24, second: 10, millisecond: 171, kind: DateTimeKind.Utc), new DateTime(year: 1985, month: 10, day: 4, hour: 22, minute: 19, second: 21, millisecond: 877, kind: DateTimeKind.Utc), }, { new DateTime(year: 1919, month: 10, day: 3, hour: 1, minute: 39, second: 25, millisecond: 730, kind: DateTimeKind.Utc), new DateTime(year: 1993, month: 10, day: 2, hour: 8, minute: 46, second: 37, millisecond: 337, kind: DateTimeKind.Utc), new DateTime(year: 1985, month: 10, day: 10, hour: 1, minute: 21, second: 53, millisecond: 715, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1998, month: 10, day: 12, hour: 22, minute: 29, second: 55, millisecond: 965, kind: DateTimeKind.Utc), new DateTime(year: 2015, month: 10, day: 4, hour: 12, minute: 11, second: 32, millisecond: 735, kind: DateTimeKind.Utc), new DateTime(year: 1969, month: 10, day: 9, hour: 1, minute: 44, second: 52, millisecond: 235, kind: DateTimeKind.Utc), }, { new DateTime(year: 1980, month: 10, day: 14, hour: 1, minute: 7, second: 47, millisecond: 915, kind: DateTimeKind.Utc), new DateTime(year: 1926, month: 10, day: 6, hour: 6, minute: 5, second: 24, millisecond: 727, kind: DateTimeKind.Utc), new DateTime(year: 1967, month: 10, day: 15, hour: 21, minute: 38, second: 22, millisecond: 623, kind: DateTimeKind.Utc), }, { new DateTime(year: 1935, month: 10, day: 6, hour: 9, minute: 9, second: 4, millisecond: 693, kind: DateTimeKind.Utc), new DateTime(year: 2009, month: 10, day: 2, hour: 16, minute: 13, second: 5, millisecond: 419, kind: DateTimeKind.Utc), new DateTime(year: 1973, month: 10, day: 17, hour: 21, minute: 27, second: 17, millisecond: 610, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1988, month: 10, day: 9, hour: 9, minute: 22, second: 23, millisecond: 736, kind: DateTimeKind.Utc), new DateTime(year: 1965, month: 10, day: 14, hour: 10, minute: 34, second: 39, millisecond: 423, kind: DateTimeKind.Utc), new DateTime(year: 1960, month: 10, day: 14, hour: 20, minute: 1, second: 7, millisecond: 477, kind: DateTimeKind.Utc), }, { new DateTime(year: 1960, month: 10, day: 17, hour: 16, minute: 50, second: 15, millisecond: 207, kind: DateTimeKind.Utc), new DateTime(year: 1983, month: 10, day: 4, hour: 8, minute: 20, second: 36, millisecond: 299, kind: DateTimeKind.Utc), new DateTime(year: 1920, month: 10, day: 15, hour: 7, minute: 51, second: 22, millisecond: 460, kind: DateTimeKind.Utc), }, { new DateTime(year: 1986, month: 10, day: 14, hour: 9, minute: 35, second: 29, millisecond: 781, kind: DateTimeKind.Utc), new DateTime(year: 2016, month: 10, day: 16, hour: 4, minute: 23, second: 47, millisecond: 792, kind: DateTimeKind.Utc), new DateTime(year: 1983, month: 10, day: 3, hour: 18, minute: 14, second: 32, millisecond: 463, kind: DateTimeKind.Utc), }, }, },
    ModelInner = null,
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1937, month: 10, day: 2, hour: 6, minute: 17, second: 32, millisecond: 258, kind: DateTimeKind.Utc), new DateTime(year: 1949, month: 10, day: 5, hour: 7, minute: 21, second: 46, millisecond: 682, kind: DateTimeKind.Utc), new DateTime(year: 1924, month: 10, day: 15, hour: 14, minute: 33, second: 40, millisecond: 176, kind: DateTimeKind.Utc), }, { new DateTime(year: 1943, month: 10, day: 11, hour: 13, minute: 43, second: 11, millisecond: 295, kind: DateTimeKind.Utc), new DateTime(year: 2017, month: 10, day: 15, hour: 2, minute: 34, second: 30, millisecond: 390, kind: DateTimeKind.Utc), new DateTime(year: 1949, month: 10, day: 5, hour: 10, minute: 20, second: 9, millisecond: 351, kind: DateTimeKind.Utc), }, { new DateTime(year: 1992, month: 10, day: 8, hour: 19, minute: 22, second: 48, millisecond: 660, kind: DateTimeKind.Utc), new DateTime(year: 1963, month: 10, day: 5, hour: 21, minute: 29, second: 47, millisecond: 894, kind: DateTimeKind.Utc), new DateTime(year: 1978, month: 10, day: 3, hour: 3, minute: 57, second: 15, millisecond: 879, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1934, month: 10, day: 13, hour: 4, minute: 55, second: 17, millisecond: 557, kind: DateTimeKind.Utc), new DateTime(year: 1980, month: 10, day: 14, hour: 8, minute: 27, second: 34, millisecond: 300, kind: DateTimeKind.Utc), new DateTime(year: 2015, month: 10, day: 12, hour: 3, minute: 3, second: 9, millisecond: 747, kind: DateTimeKind.Utc), }, { new DateTime(year: 1992, month: 10, day: 7, hour: 4, minute: 2, second: 45, millisecond: 661, kind: DateTimeKind.Utc), new DateTime(year: 1941, month: 10, day: 6, hour: 12, minute: 3, second: 42, millisecond: 671, kind: DateTimeKind.Utc), new DateTime(year: 1998, month: 10, day: 11, hour: 14, minute: 18, second: 35, millisecond: 244, kind: DateTimeKind.Utc), }, { new DateTime(year: 1940, month: 10, day: 19, hour: 4, minute: 58, second: 36, millisecond: 352, kind: DateTimeKind.Utc), new DateTime(year: 1962, month: 10, day: 6, hour: 17, minute: 8, second: 45, millisecond: 273, kind: DateTimeKind.Utc), new DateTime(year: 1997, month: 10, day: 2, hour: 1, minute: 3, second: 9, millisecond: 933, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 2003, month: 10, day: 9, hour: 14, minute: 51, second: 12, millisecond: 858, kind: DateTimeKind.Utc), new DateTime(year: 1970, month: 10, day: 9, hour: 2, minute: 22, second: 54, millisecond: 147, kind: DateTimeKind.Utc), new DateTime(year: 1963, month: 10, day: 6, hour: 22, minute: 52, second: 36, millisecond: 942, kind: DateTimeKind.Utc), }, { new DateTime(year: 1964, month: 10, day: 17, hour: 5, minute: 54, second: 33, millisecond: 841, kind: DateTimeKind.Utc), new DateTime(year: 1995, month: 10, day: 14, hour: 18, minute: 34, second: 20, millisecond: 770, kind: DateTimeKind.Utc), new DateTime(year: 2013, month: 10, day: 6, hour: 20, minute: 53, second: 27, millisecond: 904, kind: DateTimeKind.Utc), }, { new DateTime(year: 1958, month: 10, day: 5, hour: 10, minute: 20, second: 4, millisecond: 573, kind: DateTimeKind.Utc), new DateTime(year: 1919, month: 10, day: 1, hour: 5, minute: 57, second: 50, millisecond: 949, kind: DateTimeKind.Utc), new DateTime(year: 1992, month: 10, day: 16, hour: 11, minute: 5, second: 19, millisecond: 243, kind: DateTimeKind.Utc), }, }, },
},
            new DateTimetimestamp_with_time_zoneMMArrayD3E1M
{
    Id = 130,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1956, month: 10, day: 11, hour: 20, minute: 44, second: 34, millisecond: 607, kind: DateTimeKind.Utc), new DateTime(year: 1954, month: 10, day: 11, hour: 20, minute: 12, second: 39, millisecond: 707, kind: DateTimeKind.Utc), new DateTime(year: 1979, month: 10, day: 4, hour: 6, minute: 10, second: 34, millisecond: 542, kind: DateTimeKind.Utc), }, { new DateTime(year: 1921, month: 10, day: 11, hour: 10, minute: 49, second: 53, millisecond: 145, kind: DateTimeKind.Utc), new DateTime(year: 1990, month: 10, day: 19, hour: 2, minute: 26, second: 56, millisecond: 197, kind: DateTimeKind.Utc), new DateTime(year: 1987, month: 10, day: 14, hour: 8, minute: 18, second: 1, millisecond: 963, kind: DateTimeKind.Utc), }, { new DateTime(year: 1924, month: 10, day: 1, hour: 21, minute: 19, second: 31, millisecond: 259, kind: DateTimeKind.Utc), new DateTime(year: 1981, month: 10, day: 8, hour: 2, minute: 44, second: 1, millisecond: 757, kind: DateTimeKind.Utc), new DateTime(year: 2008, month: 10, day: 12, hour: 12, minute: 52, second: 36, millisecond: 189, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1955, month: 10, day: 7, hour: 18, minute: 24, second: 2, millisecond: 60, kind: DateTimeKind.Utc), new DateTime(year: 1930, month: 10, day: 19, hour: 14, minute: 1, second: 24, millisecond: 710, kind: DateTimeKind.Utc), new DateTime(year: 2009, month: 10, day: 2, hour: 11, minute: 48, second: 51, millisecond: 175, kind: DateTimeKind.Utc), }, { new DateTime(year: 1941, month: 10, day: 6, hour: 22, minute: 10, second: 51, millisecond: 309, kind: DateTimeKind.Utc), new DateTime(year: 1984, month: 10, day: 15, hour: 17, minute: 50, second: 44, millisecond: 112, kind: DateTimeKind.Utc), new DateTime(year: 1964, month: 10, day: 13, hour: 13, minute: 36, second: 22, millisecond: 233, kind: DateTimeKind.Utc), }, { new DateTime(year: 1953, month: 10, day: 9, hour: 5, minute: 9, second: 55, millisecond: 223, kind: DateTimeKind.Utc), new DateTime(year: 1981, month: 10, day: 9, hour: 16, minute: 6, second: 48, millisecond: 236, kind: DateTimeKind.Utc), new DateTime(year: 1921, month: 10, day: 14, hour: 2, minute: 42, second: 27, millisecond: 118, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 2001, month: 10, day: 10, hour: 18, minute: 12, second: 21, millisecond: 499, kind: DateTimeKind.Utc), new DateTime(year: 2012, month: 10, day: 17, hour: 20, minute: 4, second: 52, millisecond: 584, kind: DateTimeKind.Utc), new DateTime(year: 1973, month: 10, day: 1, hour: 8, minute: 5, second: 39, millisecond: 802, kind: DateTimeKind.Utc), }, { new DateTime(year: 1959, month: 10, day: 8, hour: 2, minute: 27, second: 35, millisecond: 836, kind: DateTimeKind.Utc), new DateTime(year: 2018, month: 10, day: 19, hour: 11, minute: 33, second: 57, millisecond: 271, kind: DateTimeKind.Utc), new DateTime(year: 1954, month: 10, day: 16, hour: 7, minute: 11, second: 55, millisecond: 913, kind: DateTimeKind.Utc), }, { new DateTime(year: 1977, month: 10, day: 9, hour: 3, minute: 10, second: 32, millisecond: 967, kind: DateTimeKind.Utc), new DateTime(year: 1996, month: 10, day: 11, hour: 17, minute: 13, second: 16, millisecond: 316, kind: DateTimeKind.Utc), new DateTime(year: 1947, month: 10, day: 9, hour: 8, minute: 16, second: 7, millisecond: 309, kind: DateTimeKind.Utc), }, }, },
    ModelInner = new DateTimetimestamp_with_time_zoneMMArrayD3E1MI
{
    Id = 77,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 2002, month: 10, day: 11, hour: 2, minute: 29, second: 20, millisecond: 710, kind: DateTimeKind.Utc), new DateTime(year: 1952, month: 10, day: 11, hour: 4, minute: 22, second: 30, millisecond: 987, kind: DateTimeKind.Utc), new DateTime(year: 1969, month: 10, day: 4, hour: 8, minute: 28, second: 27, millisecond: 792, kind: DateTimeKind.Utc), }, { new DateTime(year: 1975, month: 10, day: 16, hour: 7, minute: 28, second: 48, millisecond: 588, kind: DateTimeKind.Utc), new DateTime(year: 1959, month: 10, day: 4, hour: 22, minute: 38, second: 47, millisecond: 895, kind: DateTimeKind.Utc), new DateTime(year: 1942, month: 10, day: 15, hour: 15, minute: 51, second: 37, millisecond: 876, kind: DateTimeKind.Utc), }, { new DateTime(year: 1926, month: 10, day: 15, hour: 16, minute: 30, second: 20, millisecond: 165, kind: DateTimeKind.Utc), new DateTime(year: 1948, month: 10, day: 7, hour: 7, minute: 27, second: 11, millisecond: 30, kind: DateTimeKind.Utc), new DateTime(year: 1975, month: 10, day: 14, hour: 20, minute: 42, second: 22, millisecond: 250, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 2011, month: 10, day: 14, hour: 21, minute: 22, second: 40, millisecond: 235, kind: DateTimeKind.Utc), new DateTime(year: 1986, month: 10, day: 9, hour: 6, minute: 56, second: 27, millisecond: 189, kind: DateTimeKind.Utc), new DateTime(year: 1957, month: 10, day: 18, hour: 20, minute: 41, second: 53, millisecond: 474, kind: DateTimeKind.Utc), }, { new DateTime(year: 1949, month: 10, day: 18, hour: 8, minute: 11, second: 9, millisecond: 848, kind: DateTimeKind.Utc), new DateTime(year: 2004, month: 10, day: 14, hour: 4, minute: 29, second: 20, millisecond: 23, kind: DateTimeKind.Utc), new DateTime(year: 1961, month: 10, day: 4, hour: 13, minute: 27, second: 33, millisecond: 756, kind: DateTimeKind.Utc), }, { new DateTime(year: 1940, month: 10, day: 11, hour: 16, minute: 17, second: 57, millisecond: 959, kind: DateTimeKind.Utc), new DateTime(year: 1981, month: 10, day: 2, hour: 7, minute: 51, second: 6, millisecond: 853, kind: DateTimeKind.Utc), new DateTime(year: 1926, month: 10, day: 17, hour: 1, minute: 34, second: 8, millisecond: 928, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1968, month: 10, day: 10, hour: 13, minute: 22, second: 47, millisecond: 764, kind: DateTimeKind.Utc), new DateTime(year: 1969, month: 10, day: 13, hour: 11, minute: 41, second: 9, millisecond: 803, kind: DateTimeKind.Utc), new DateTime(year: 1950, month: 10, day: 18, hour: 9, minute: 3, second: 46, millisecond: 990, kind: DateTimeKind.Utc), }, { new DateTime(year: 1928, month: 10, day: 4, hour: 10, minute: 38, second: 5, millisecond: 7, kind: DateTimeKind.Utc), new DateTime(year: 2013, month: 10, day: 12, hour: 6, minute: 1, second: 18, millisecond: 521, kind: DateTimeKind.Utc), new DateTime(year: 1960, month: 10, day: 17, hour: 15, minute: 24, second: 30, millisecond: 951, kind: DateTimeKind.Utc), }, { new DateTime(year: 1942, month: 10, day: 3, hour: 12, minute: 2, second: 39, millisecond: 477, kind: DateTimeKind.Utc), new DateTime(year: 1993, month: 10, day: 15, hour: 1, minute: 26, second: 18, millisecond: 793, kind: DateTimeKind.Utc), new DateTime(year: 1920, month: 10, day: 3, hour: 18, minute: 9, second: 14, millisecond: 608, kind: DateTimeKind.Utc), }, }, },
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1986, month: 10, day: 4, hour: 13, minute: 55, second: 29, millisecond: 669, kind: DateTimeKind.Utc), new DateTime(year: 2012, month: 10, day: 7, hour: 15, minute: 11, second: 49, millisecond: 501, kind: DateTimeKind.Utc), new DateTime(year: 1963, month: 10, day: 12, hour: 10, minute: 8, second: 18, millisecond: 202, kind: DateTimeKind.Utc), }, { new DateTime(year: 2014, month: 10, day: 3, hour: 5, minute: 2, second: 51, millisecond: 144, kind: DateTimeKind.Utc), new DateTime(year: 1999, month: 10, day: 1, hour: 6, minute: 2, second: 1, millisecond: 188, kind: DateTimeKind.Utc), new DateTime(year: 2005, month: 10, day: 15, hour: 14, minute: 50, second: 28, millisecond: 971, kind: DateTimeKind.Utc), }, { new DateTime(year: 1990, month: 10, day: 5, hour: 13, minute: 9, second: 6, millisecond: 921, kind: DateTimeKind.Utc), new DateTime(year: 1920, month: 10, day: 1, hour: 13, minute: 49, second: 21, millisecond: 863, kind: DateTimeKind.Utc), new DateTime(year: 1996, month: 10, day: 2, hour: 6, minute: 35, second: 28, millisecond: 752, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1984, month: 10, day: 2, hour: 20, minute: 7, second: 40, millisecond: 577, kind: DateTimeKind.Utc), new DateTime(year: 2009, month: 10, day: 15, hour: 20, minute: 14, second: 36, millisecond: 827, kind: DateTimeKind.Utc), new DateTime(year: 1964, month: 10, day: 4, hour: 5, minute: 44, second: 23, millisecond: 379, kind: DateTimeKind.Utc), }, { new DateTime(year: 1969, month: 10, day: 19, hour: 15, minute: 44, second: 26, millisecond: 854, kind: DateTimeKind.Utc), new DateTime(year: 1942, month: 10, day: 1, hour: 11, minute: 2, second: 42, millisecond: 438, kind: DateTimeKind.Utc), new DateTime(year: 1917, month: 10, day: 9, hour: 7, minute: 40, second: 48, millisecond: 389, kind: DateTimeKind.Utc), }, { new DateTime(year: 1969, month: 10, day: 8, hour: 9, minute: 35, second: 46, millisecond: 982, kind: DateTimeKind.Utc), new DateTime(year: 1940, month: 10, day: 8, hour: 14, minute: 24, second: 23, millisecond: 757, kind: DateTimeKind.Utc), new DateTime(year: 2016, month: 10, day: 12, hour: 7, minute: 32, second: 8, millisecond: 7, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1998, month: 10, day: 10, hour: 4, minute: 17, second: 30, millisecond: 478, kind: DateTimeKind.Utc), new DateTime(year: 1925, month: 10, day: 7, hour: 12, minute: 57, second: 35, millisecond: 435, kind: DateTimeKind.Utc), new DateTime(year: 1935, month: 10, day: 14, hour: 15, minute: 53, second: 7, millisecond: 269, kind: DateTimeKind.Utc), }, { new DateTime(year: 2007, month: 10, day: 4, hour: 10, minute: 20, second: 47, millisecond: 746, kind: DateTimeKind.Utc), new DateTime(year: 1966, month: 10, day: 16, hour: 16, minute: 15, second: 31, millisecond: 495, kind: DateTimeKind.Utc), new DateTime(year: 1995, month: 10, day: 10, hour: 17, minute: 4, second: 25, millisecond: 765, kind: DateTimeKind.Utc), }, { new DateTime(year: 1958, month: 10, day: 15, hour: 4, minute: 32, second: 43, millisecond: 71, kind: DateTimeKind.Utc), new DateTime(year: 1947, month: 10, day: 9, hour: 15, minute: 54, second: 32, millisecond: 662, kind: DateTimeKind.Utc), new DateTime(year: 1990, month: 10, day: 7, hour: 15, minute: 40, second: 53, millisecond: 663, kind: DateTimeKind.Utc), }, }, },
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneMMArrayD3E1M
{
    Id = 138,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1951, month: 10, day: 11, hour: 7, minute: 58, second: 51, millisecond: 866, kind: DateTimeKind.Utc), new DateTime(year: 1977, month: 10, day: 10, hour: 11, minute: 22, second: 42, millisecond: 155, kind: DateTimeKind.Utc), new DateTime(year: 1948, month: 10, day: 9, hour: 21, minute: 53, second: 30, millisecond: 22, kind: DateTimeKind.Utc), }, { new DateTime(year: 1955, month: 10, day: 13, hour: 5, minute: 14, second: 50, millisecond: 563, kind: DateTimeKind.Utc), new DateTime(year: 1977, month: 10, day: 15, hour: 21, minute: 57, second: 44, millisecond: 88, kind: DateTimeKind.Utc), new DateTime(year: 1976, month: 10, day: 16, hour: 16, minute: 16, second: 30, millisecond: 149, kind: DateTimeKind.Utc), }, { new DateTime(year: 1973, month: 10, day: 17, hour: 5, minute: 7, second: 17, millisecond: 212, kind: DateTimeKind.Utc), new DateTime(year: 1956, month: 10, day: 19, hour: 14, minute: 21, second: 20, millisecond: 391, kind: DateTimeKind.Utc), new DateTime(year: 1956, month: 10, day: 8, hour: 1, minute: 53, second: 50, millisecond: 88, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1992, month: 10, day: 4, hour: 22, minute: 50, second: 5, millisecond: 518, kind: DateTimeKind.Utc), new DateTime(year: 1929, month: 10, day: 8, hour: 16, minute: 29, second: 56, millisecond: 403, kind: DateTimeKind.Utc), new DateTime(year: 1922, month: 10, day: 10, hour: 12, minute: 3, second: 55, millisecond: 619, kind: DateTimeKind.Utc), }, { new DateTime(year: 1960, month: 10, day: 15, hour: 5, minute: 58, second: 55, millisecond: 457, kind: DateTimeKind.Utc), new DateTime(year: 2001, month: 10, day: 6, hour: 7, minute: 45, second: 31, millisecond: 814, kind: DateTimeKind.Utc), new DateTime(year: 1968, month: 10, day: 18, hour: 5, minute: 57, second: 24, millisecond: 941, kind: DateTimeKind.Utc), }, { new DateTime(year: 1924, month: 10, day: 14, hour: 13, minute: 3, second: 11, millisecond: 243, kind: DateTimeKind.Utc), new DateTime(year: 2001, month: 10, day: 4, hour: 13, minute: 28, second: 46, millisecond: 116, kind: DateTimeKind.Utc), new DateTime(year: 1993, month: 10, day: 5, hour: 5, minute: 31, second: 9, millisecond: 830, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1926, month: 10, day: 4, hour: 3, minute: 2, second: 34, millisecond: 496, kind: DateTimeKind.Utc), new DateTime(year: 1917, month: 10, day: 11, hour: 4, minute: 5, second: 7, millisecond: 112, kind: DateTimeKind.Utc), new DateTime(year: 1949, month: 10, day: 2, hour: 7, minute: 26, second: 39, millisecond: 788, kind: DateTimeKind.Utc), }, { new DateTime(year: 1960, month: 10, day: 11, hour: 2, minute: 51, second: 27, millisecond: 367, kind: DateTimeKind.Utc), new DateTime(year: 2017, month: 10, day: 14, hour: 17, minute: 13, second: 58, millisecond: 483, kind: DateTimeKind.Utc), new DateTime(year: 1994, month: 10, day: 6, hour: 3, minute: 31, second: 43, millisecond: 927, kind: DateTimeKind.Utc), }, { new DateTime(year: 1927, month: 10, day: 5, hour: 13, minute: 46, second: 2, millisecond: 807, kind: DateTimeKind.Utc), new DateTime(year: 1960, month: 10, day: 10, hour: 7, minute: 1, second: 54, millisecond: 775, kind: DateTimeKind.Utc), new DateTime(year: 2014, month: 10, day: 6, hour: 14, minute: 3, second: 7, millisecond: 787, kind: DateTimeKind.Utc), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneMMArrayD3E1M
{
    Id = 147,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1948, month: 10, day: 7, hour: 8, minute: 48, second: 46, millisecond: 752, kind: DateTimeKind.Utc), new DateTime(year: 2010, month: 10, day: 12, hour: 2, minute: 13, second: 6, millisecond: 828, kind: DateTimeKind.Utc), new DateTime(year: 1981, month: 10, day: 19, hour: 20, minute: 44, second: 15, millisecond: 40, kind: DateTimeKind.Utc), }, { new DateTime(year: 1945, month: 10, day: 8, hour: 9, minute: 30, second: 35, millisecond: 694, kind: DateTimeKind.Utc), new DateTime(year: 1952, month: 10, day: 8, hour: 10, minute: 32, second: 28, millisecond: 745, kind: DateTimeKind.Utc), new DateTime(year: 1963, month: 10, day: 2, hour: 9, minute: 58, second: 29, millisecond: 977, kind: DateTimeKind.Utc), }, { new DateTime(year: 1945, month: 10, day: 5, hour: 8, minute: 43, second: 36, millisecond: 975, kind: DateTimeKind.Utc), new DateTime(year: 1976, month: 10, day: 4, hour: 10, minute: 35, second: 56, millisecond: 606, kind: DateTimeKind.Utc), new DateTime(year: 1968, month: 10, day: 6, hour: 14, minute: 30, second: 37, millisecond: 518, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1922, month: 10, day: 4, hour: 16, minute: 54, second: 3, millisecond: 509, kind: DateTimeKind.Utc), new DateTime(year: 1946, month: 10, day: 18, hour: 10, minute: 30, second: 56, millisecond: 2, kind: DateTimeKind.Utc), new DateTime(year: 1974, month: 10, day: 17, hour: 3, minute: 26, second: 37, millisecond: 436, kind: DateTimeKind.Utc), }, { new DateTime(year: 1951, month: 10, day: 8, hour: 4, minute: 14, second: 12, millisecond: 843, kind: DateTimeKind.Utc), new DateTime(year: 2002, month: 10, day: 13, hour: 10, minute: 55, second: 54, millisecond: 730, kind: DateTimeKind.Utc), new DateTime(year: 1975, month: 10, day: 18, hour: 20, minute: 54, second: 32, millisecond: 284, kind: DateTimeKind.Utc), }, { new DateTime(year: 1932, month: 10, day: 17, hour: 3, minute: 47, second: 53, millisecond: 696, kind: DateTimeKind.Utc), new DateTime(year: 1952, month: 10, day: 12, hour: 19, minute: 18, second: 24, millisecond: 804, kind: DateTimeKind.Utc), new DateTime(year: 1991, month: 10, day: 13, hour: 4, minute: 30, second: 57, millisecond: 735, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1930, month: 10, day: 7, hour: 17, minute: 57, second: 9, millisecond: 651, kind: DateTimeKind.Utc), new DateTime(year: 1984, month: 10, day: 18, hour: 7, minute: 5, second: 50, millisecond: 67, kind: DateTimeKind.Utc), new DateTime(year: 1925, month: 10, day: 8, hour: 6, minute: 5, second: 35, millisecond: 748, kind: DateTimeKind.Utc), }, { new DateTime(year: 1935, month: 10, day: 18, hour: 22, minute: 17, second: 10, millisecond: 149, kind: DateTimeKind.Utc), new DateTime(year: 2012, month: 10, day: 1, hour: 14, minute: 38, second: 45, millisecond: 491, kind: DateTimeKind.Utc), new DateTime(year: 2014, month: 10, day: 6, hour: 2, minute: 29, second: 57, millisecond: 270, kind: DateTimeKind.Utc), }, { new DateTime(year: 1926, month: 10, day: 15, hour: 14, minute: 33, second: 43, millisecond: 189, kind: DateTimeKind.Utc), new DateTime(year: 1976, month: 10, day: 11, hour: 20, minute: 37, second: 52, millisecond: 556, kind: DateTimeKind.Utc), new DateTime(year: 1941, month: 10, day: 19, hour: 17, minute: 45, second: 10, millisecond: 417, kind: DateTimeKind.Utc), }, }, },
    ModelInner = new DateTimetimestamp_with_time_zoneMMArrayD3E1MI
{
    Id = 83,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 2000, month: 10, day: 19, hour: 15, minute: 25, second: 34, millisecond: 302, kind: DateTimeKind.Utc), new DateTime(year: 1936, month: 10, day: 18, hour: 11, minute: 54, second: 57, millisecond: 551, kind: DateTimeKind.Utc), new DateTime(year: 1980, month: 10, day: 6, hour: 6, minute: 44, second: 25, millisecond: 185, kind: DateTimeKind.Utc), }, { new DateTime(year: 1979, month: 10, day: 10, hour: 16, minute: 50, second: 50, millisecond: 722, kind: DateTimeKind.Utc), new DateTime(year: 2018, month: 10, day: 7, hour: 2, minute: 24, second: 15, millisecond: 332, kind: DateTimeKind.Utc), new DateTime(year: 1961, month: 10, day: 15, hour: 10, minute: 34, second: 58, millisecond: 576, kind: DateTimeKind.Utc), }, { new DateTime(year: 1942, month: 10, day: 16, hour: 15, minute: 17, second: 22, millisecond: 224, kind: DateTimeKind.Utc), new DateTime(year: 2006, month: 10, day: 12, hour: 7, minute: 26, second: 56, millisecond: 321, kind: DateTimeKind.Utc), new DateTime(year: 2004, month: 10, day: 3, hour: 10, minute: 8, second: 40, millisecond: 884, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 2008, month: 10, day: 7, hour: 3, minute: 1, second: 7, millisecond: 516, kind: DateTimeKind.Utc), new DateTime(year: 1981, month: 10, day: 17, hour: 13, minute: 35, second: 45, millisecond: 348, kind: DateTimeKind.Utc), new DateTime(year: 1956, month: 10, day: 12, hour: 15, minute: 30, second: 30, millisecond: 724, kind: DateTimeKind.Utc), }, { new DateTime(year: 2002, month: 10, day: 16, hour: 1, minute: 21, second: 18, millisecond: 50, kind: DateTimeKind.Utc), new DateTime(year: 1931, month: 10, day: 16, hour: 1, minute: 28, second: 17, millisecond: 345, kind: DateTimeKind.Utc), new DateTime(year: 2001, month: 10, day: 2, hour: 7, minute: 29, second: 4, millisecond: 245, kind: DateTimeKind.Utc), }, { new DateTime(year: 1982, month: 10, day: 5, hour: 3, minute: 6, second: 55, millisecond: 920, kind: DateTimeKind.Utc), new DateTime(year: 1970, month: 10, day: 16, hour: 12, minute: 41, second: 39, millisecond: 703, kind: DateTimeKind.Utc), new DateTime(year: 1952, month: 10, day: 10, hour: 8, minute: 17, second: 23, millisecond: 330, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1996, month: 10, day: 1, hour: 6, minute: 20, second: 28, millisecond: 979, kind: DateTimeKind.Utc), new DateTime(year: 1941, month: 10, day: 9, hour: 18, minute: 56, second: 53, millisecond: 168, kind: DateTimeKind.Utc), new DateTime(year: 1969, month: 10, day: 5, hour: 20, minute: 51, second: 12, millisecond: 694, kind: DateTimeKind.Utc), }, { new DateTime(year: 1979, month: 10, day: 6, hour: 9, minute: 34, second: 13, millisecond: 588, kind: DateTimeKind.Utc), new DateTime(year: 2010, month: 10, day: 16, hour: 13, minute: 39, second: 34, millisecond: 302, kind: DateTimeKind.Utc), new DateTime(year: 1972, month: 10, day: 16, hour: 12, minute: 31, second: 21, millisecond: 12, kind: DateTimeKind.Utc), }, { new DateTime(year: 1981, month: 10, day: 19, hour: 22, minute: 12, second: 39, millisecond: 758, kind: DateTimeKind.Utc), new DateTime(year: 1951, month: 10, day: 10, hour: 9, minute: 45, second: 31, millisecond: 638, kind: DateTimeKind.Utc), new DateTime(year: 2007, month: 10, day: 2, hour: 15, minute: 53, second: 28, millisecond: 177, kind: DateTimeKind.Utc), }, }, },
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1962, month: 10, day: 15, hour: 8, minute: 7, second: 42, millisecond: 756, kind: DateTimeKind.Utc), new DateTime(year: 1938, month: 10, day: 18, hour: 4, minute: 56, second: 38, millisecond: 862, kind: DateTimeKind.Utc), new DateTime(year: 1959, month: 10, day: 12, hour: 2, minute: 22, second: 52, millisecond: 418, kind: DateTimeKind.Utc), }, { new DateTime(year: 1965, month: 10, day: 4, hour: 9, minute: 48, second: 48, millisecond: 518, kind: DateTimeKind.Utc), new DateTime(year: 1976, month: 10, day: 10, hour: 20, minute: 40, second: 6, millisecond: 963, kind: DateTimeKind.Utc), new DateTime(year: 1957, month: 10, day: 13, hour: 6, minute: 40, second: 58, millisecond: 621, kind: DateTimeKind.Utc), }, { new DateTime(year: 1969, month: 10, day: 16, hour: 1, minute: 45, second: 44, millisecond: 442, kind: DateTimeKind.Utc), new DateTime(year: 2001, month: 10, day: 12, hour: 11, minute: 2, second: 11, millisecond: 667, kind: DateTimeKind.Utc), new DateTime(year: 1986, month: 10, day: 12, hour: 4, minute: 23, second: 7, millisecond: 696, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 2001, month: 10, day: 17, hour: 17, minute: 55, second: 15, millisecond: 996, kind: DateTimeKind.Utc), new DateTime(year: 1943, month: 10, day: 9, hour: 18, minute: 1, second: 35, millisecond: 664, kind: DateTimeKind.Utc), new DateTime(year: 1929, month: 10, day: 11, hour: 19, minute: 13, second: 55, millisecond: 431, kind: DateTimeKind.Utc), }, { new DateTime(year: 1941, month: 10, day: 14, hour: 10, minute: 44, second: 52, millisecond: 508, kind: DateTimeKind.Utc), new DateTime(year: 2006, month: 10, day: 18, hour: 2, minute: 56, second: 38, millisecond: 971, kind: DateTimeKind.Utc), new DateTime(year: 1928, month: 10, day: 9, hour: 3, minute: 50, second: 50, millisecond: 690, kind: DateTimeKind.Utc), }, { new DateTime(year: 1982, month: 10, day: 17, hour: 10, minute: 9, second: 46, millisecond: 159, kind: DateTimeKind.Utc), new DateTime(year: 2007, month: 10, day: 7, hour: 8, minute: 20, second: 36, millisecond: 604, kind: DateTimeKind.Utc), new DateTime(year: 1979, month: 10, day: 8, hour: 21, minute: 18, second: 31, millisecond: 529, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1974, month: 10, day: 12, hour: 2, minute: 4, second: 3, millisecond: 293, kind: DateTimeKind.Utc), new DateTime(year: 1978, month: 10, day: 16, hour: 21, minute: 35, second: 39, millisecond: 599, kind: DateTimeKind.Utc), new DateTime(year: 1933, month: 10, day: 19, hour: 13, minute: 29, second: 56, millisecond: 709, kind: DateTimeKind.Utc), }, { new DateTime(year: 1969, month: 10, day: 9, hour: 10, minute: 11, second: 8, millisecond: 215, kind: DateTimeKind.Utc), new DateTime(year: 1970, month: 10, day: 14, hour: 16, minute: 8, second: 20, millisecond: 65, kind: DateTimeKind.Utc), new DateTime(year: 1961, month: 10, day: 18, hour: 14, minute: 9, second: 22, millisecond: 256, kind: DateTimeKind.Utc), }, { new DateTime(year: 1924, month: 10, day: 7, hour: 6, minute: 25, second: 51, millisecond: 308, kind: DateTimeKind.Utc), new DateTime(year: 1998, month: 10, day: 1, hour: 20, minute: 45, second: 33, millisecond: 318, kind: DateTimeKind.Utc), new DateTime(year: 2011, month: 10, day: 6, hour: 20, minute: 1, second: 54, millisecond: 669, kind: DateTimeKind.Utc), }, }, },
},
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1951, month: 10, day: 12, hour: 2, minute: 53, second: 56, millisecond: 905, kind: DateTimeKind.Utc), new DateTime(year: 1961, month: 10, day: 17, hour: 18, minute: 17, second: 11, millisecond: 728, kind: DateTimeKind.Utc), new DateTime(year: 1948, month: 10, day: 6, hour: 20, minute: 43, second: 50, millisecond: 936, kind: DateTimeKind.Utc), }, { new DateTime(year: 1962, month: 10, day: 15, hour: 21, minute: 32, second: 57, millisecond: 38, kind: DateTimeKind.Utc), new DateTime(year: 1962, month: 10, day: 10, hour: 12, minute: 22, second: 38, millisecond: 957, kind: DateTimeKind.Utc), new DateTime(year: 2011, month: 10, day: 4, hour: 21, minute: 58, second: 46, millisecond: 952, kind: DateTimeKind.Utc), }, { new DateTime(year: 1947, month: 10, day: 2, hour: 4, minute: 15, second: 12, millisecond: 540, kind: DateTimeKind.Utc), new DateTime(year: 1962, month: 10, day: 13, hour: 19, minute: 7, second: 44, millisecond: 951, kind: DateTimeKind.Utc), new DateTime(year: 1979, month: 10, day: 17, hour: 19, minute: 26, second: 26, millisecond: 902, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1919, month: 10, day: 3, hour: 3, minute: 20, second: 36, millisecond: 61, kind: DateTimeKind.Utc), new DateTime(year: 1978, month: 10, day: 10, hour: 12, minute: 37, second: 3, millisecond: 615, kind: DateTimeKind.Utc), new DateTime(year: 1971, month: 10, day: 7, hour: 13, minute: 7, second: 42, millisecond: 511, kind: DateTimeKind.Utc), }, { new DateTime(year: 1968, month: 10, day: 2, hour: 20, minute: 57, second: 12, millisecond: 385, kind: DateTimeKind.Utc), new DateTime(year: 1954, month: 10, day: 6, hour: 2, minute: 50, second: 13, millisecond: 21, kind: DateTimeKind.Utc), new DateTime(year: 1967, month: 10, day: 15, hour: 3, minute: 38, second: 44, millisecond: 397, kind: DateTimeKind.Utc), }, { new DateTime(year: 2016, month: 10, day: 6, hour: 6, minute: 53, second: 3, millisecond: 534, kind: DateTimeKind.Utc), new DateTime(year: 2003, month: 10, day: 14, hour: 4, minute: 40, second: 38, millisecond: 616, kind: DateTimeKind.Utc), new DateTime(year: 1981, month: 10, day: 5, hour: 7, minute: 13, second: 5, millisecond: 257, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1933, month: 10, day: 16, hour: 7, minute: 38, second: 6, millisecond: 548, kind: DateTimeKind.Utc), new DateTime(year: 1983, month: 10, day: 13, hour: 1, minute: 28, second: 58, millisecond: 34, kind: DateTimeKind.Utc), new DateTime(year: 2016, month: 10, day: 14, hour: 7, minute: 34, second: 44, millisecond: 379, kind: DateTimeKind.Utc), }, { new DateTime(year: 2007, month: 10, day: 2, hour: 20, minute: 40, second: 31, millisecond: 407, kind: DateTimeKind.Utc), new DateTime(year: 1985, month: 10, day: 1, hour: 15, minute: 38, second: 30, millisecond: 867, kind: DateTimeKind.Utc), new DateTime(year: 1972, month: 10, day: 1, hour: 16, minute: 24, second: 47, millisecond: 72, kind: DateTimeKind.Utc), }, { new DateTime(year: 2009, month: 10, day: 9, hour: 21, minute: 15, second: 34, millisecond: 91, kind: DateTimeKind.Utc), new DateTime(year: 1957, month: 10, day: 17, hour: 11, minute: 48, second: 19, millisecond: 820, kind: DateTimeKind.Utc), new DateTime(year: 1987, month: 10, day: 6, hour: 8, minute: 7, second: 2, millisecond: 835, kind: DateTimeKind.Utc), }, }, },
},
            new DateTimetimestamp_with_time_zoneMMArrayD3E1M
{
    Id = 153,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 2002, month: 10, day: 18, hour: 11, minute: 22, second: 46, millisecond: 994, kind: DateTimeKind.Utc), new DateTime(year: 1964, month: 10, day: 10, hour: 17, minute: 34, second: 27, millisecond: 306, kind: DateTimeKind.Utc), new DateTime(year: 1960, month: 10, day: 7, hour: 22, minute: 27, second: 23, millisecond: 401, kind: DateTimeKind.Utc), }, { new DateTime(year: 1971, month: 10, day: 13, hour: 20, minute: 17, second: 20, millisecond: 210, kind: DateTimeKind.Utc), new DateTime(year: 1963, month: 10, day: 12, hour: 11, minute: 49, second: 10, millisecond: 923, kind: DateTimeKind.Utc), new DateTime(year: 1947, month: 10, day: 17, hour: 20, minute: 41, second: 56, millisecond: 407, kind: DateTimeKind.Utc), }, { new DateTime(year: 1951, month: 10, day: 6, hour: 12, minute: 55, second: 16, millisecond: 786, kind: DateTimeKind.Utc), new DateTime(year: 1986, month: 10, day: 17, hour: 7, minute: 47, second: 19, millisecond: 161, kind: DateTimeKind.Utc), new DateTime(year: 1924, month: 10, day: 18, hour: 19, minute: 44, second: 38, millisecond: 791, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1961, month: 10, day: 4, hour: 6, minute: 4, second: 28, millisecond: 114, kind: DateTimeKind.Utc), new DateTime(year: 1963, month: 10, day: 17, hour: 13, minute: 3, second: 5, millisecond: 321, kind: DateTimeKind.Utc), new DateTime(year: 1958, month: 10, day: 7, hour: 1, minute: 20, second: 37, millisecond: 157, kind: DateTimeKind.Utc), }, { new DateTime(year: 1930, month: 10, day: 1, hour: 14, minute: 9, second: 5, millisecond: 986, kind: DateTimeKind.Utc), new DateTime(year: 1932, month: 10, day: 5, hour: 18, minute: 21, second: 28, millisecond: 927, kind: DateTimeKind.Utc), new DateTime(year: 2006, month: 10, day: 1, hour: 19, minute: 9, second: 2, millisecond: 571, kind: DateTimeKind.Utc), }, { new DateTime(year: 1998, month: 10, day: 16, hour: 9, minute: 4, second: 25, millisecond: 785, kind: DateTimeKind.Utc), new DateTime(year: 1960, month: 10, day: 4, hour: 4, minute: 37, second: 45, millisecond: 587, kind: DateTimeKind.Utc), new DateTime(year: 2007, month: 10, day: 7, hour: 3, minute: 57, second: 1, millisecond: 165, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 2007, month: 10, day: 5, hour: 15, minute: 13, second: 16, millisecond: 782, kind: DateTimeKind.Utc), new DateTime(year: 2009, month: 10, day: 14, hour: 18, minute: 14, second: 27, millisecond: 927, kind: DateTimeKind.Utc), new DateTime(year: 1956, month: 10, day: 12, hour: 5, minute: 36, second: 2, millisecond: 301, kind: DateTimeKind.Utc), }, { new DateTime(year: 1954, month: 10, day: 7, hour: 15, minute: 49, second: 34, millisecond: 335, kind: DateTimeKind.Utc), new DateTime(year: 1952, month: 10, day: 3, hour: 20, minute: 49, second: 57, millisecond: 864, kind: DateTimeKind.Utc), new DateTime(year: 1935, month: 10, day: 17, hour: 16, minute: 24, second: 28, millisecond: 457, kind: DateTimeKind.Utc), }, { new DateTime(year: 1928, month: 10, day: 2, hour: 11, minute: 11, second: 17, millisecond: 40, kind: DateTimeKind.Utc), new DateTime(year: 1921, month: 10, day: 14, hour: 11, minute: 12, second: 55, millisecond: 223, kind: DateTimeKind.Utc), new DateTime(year: 1954, month: 10, day: 15, hour: 5, minute: 22, second: 53, millisecond: 101, kind: DateTimeKind.Utc), }, }, },
    ModelInner = null,
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 2008, month: 10, day: 5, hour: 19, minute: 1, second: 30, millisecond: 87, kind: DateTimeKind.Utc), new DateTime(year: 1921, month: 10, day: 8, hour: 8, minute: 5, second: 54, millisecond: 625, kind: DateTimeKind.Utc), new DateTime(year: 1985, month: 10, day: 6, hour: 5, minute: 13, second: 34, millisecond: 288, kind: DateTimeKind.Utc), }, { new DateTime(year: 1921, month: 10, day: 6, hour: 5, minute: 54, second: 22, millisecond: 31, kind: DateTimeKind.Utc), new DateTime(year: 1963, month: 10, day: 4, hour: 16, minute: 1, second: 18, millisecond: 166, kind: DateTimeKind.Utc), new DateTime(year: 1958, month: 10, day: 11, hour: 21, minute: 22, second: 27, millisecond: 304, kind: DateTimeKind.Utc), }, { new DateTime(year: 1970, month: 10, day: 19, hour: 20, minute: 14, second: 54, millisecond: 980, kind: DateTimeKind.Utc), new DateTime(year: 1970, month: 10, day: 5, hour: 5, minute: 42, second: 45, millisecond: 463, kind: DateTimeKind.Utc), new DateTime(year: 2013, month: 10, day: 14, hour: 16, minute: 49, second: 58, millisecond: 689, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1994, month: 10, day: 1, hour: 20, minute: 24, second: 30, millisecond: 222, kind: DateTimeKind.Utc), new DateTime(year: 1930, month: 10, day: 17, hour: 15, minute: 17, second: 54, millisecond: 964, kind: DateTimeKind.Utc), new DateTime(year: 1941, month: 10, day: 4, hour: 14, minute: 10, second: 56, millisecond: 198, kind: DateTimeKind.Utc), }, { new DateTime(year: 1978, month: 10, day: 7, hour: 11, minute: 11, second: 29, millisecond: 832, kind: DateTimeKind.Utc), new DateTime(year: 1929, month: 10, day: 9, hour: 4, minute: 27, second: 11, millisecond: 444, kind: DateTimeKind.Utc), new DateTime(year: 1954, month: 10, day: 14, hour: 10, minute: 44, second: 19, millisecond: 850, kind: DateTimeKind.Utc), }, { new DateTime(year: 1947, month: 10, day: 9, hour: 14, minute: 4, second: 45, millisecond: 245, kind: DateTimeKind.Utc), new DateTime(year: 1964, month: 10, day: 12, hour: 22, minute: 20, second: 5, millisecond: 269, kind: DateTimeKind.Utc), new DateTime(year: 1948, month: 10, day: 10, hour: 13, minute: 16, second: 42, millisecond: 965, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1994, month: 10, day: 14, hour: 14, minute: 6, second: 1, millisecond: 945, kind: DateTimeKind.Utc), new DateTime(year: 1940, month: 10, day: 6, hour: 21, minute: 57, second: 45, millisecond: 432, kind: DateTimeKind.Utc), new DateTime(year: 2007, month: 10, day: 8, hour: 9, minute: 10, second: 5, millisecond: 139, kind: DateTimeKind.Utc), }, { new DateTime(year: 2001, month: 10, day: 6, hour: 18, minute: 14, second: 58, millisecond: 763, kind: DateTimeKind.Utc), new DateTime(year: 2019, month: 10, day: 12, hour: 13, minute: 23, second: 6, millisecond: 866, kind: DateTimeKind.Utc), new DateTime(year: 1961, month: 10, day: 13, hour: 5, minute: 20, second: 13, millisecond: 342, kind: DateTimeKind.Utc), }, { new DateTime(year: 2006, month: 10, day: 1, hour: 21, minute: 55, second: 46, millisecond: 666, kind: DateTimeKind.Utc), new DateTime(year: 1965, month: 10, day: 16, hour: 12, minute: 19, second: 17, millisecond: 968, kind: DateTimeKind.Utc), new DateTime(year: 1927, month: 10, day: 7, hour: 4, minute: 17, second: 24, millisecond: 95, kind: DateTimeKind.Utc), }, }, },
},
            new DateTimetimestamp_with_time_zoneMMArrayD3E1M
{
    Id = 161,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1960, month: 10, day: 17, hour: 2, minute: 25, second: 31, millisecond: 445, kind: DateTimeKind.Utc), new DateTime(year: 1927, month: 10, day: 19, hour: 21, minute: 26, second: 11, millisecond: 876, kind: DateTimeKind.Utc), new DateTime(year: 1971, month: 10, day: 3, hour: 18, minute: 9, second: 13, millisecond: 996, kind: DateTimeKind.Utc), }, { new DateTime(year: 2014, month: 10, day: 4, hour: 9, minute: 17, second: 38, millisecond: 474, kind: DateTimeKind.Utc), new DateTime(year: 1983, month: 10, day: 1, hour: 3, minute: 29, second: 24, millisecond: 179, kind: DateTimeKind.Utc), new DateTime(year: 1947, month: 10, day: 7, hour: 8, minute: 8, second: 57, millisecond: 46, kind: DateTimeKind.Utc), }, { new DateTime(year: 1971, month: 10, day: 12, hour: 6, minute: 55, second: 45, millisecond: 660, kind: DateTimeKind.Utc), new DateTime(year: 1936, month: 10, day: 12, hour: 13, minute: 22, second: 42, millisecond: 96, kind: DateTimeKind.Utc), new DateTime(year: 1961, month: 10, day: 15, hour: 13, minute: 41, second: 49, millisecond: 407, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1928, month: 10, day: 14, hour: 9, minute: 28, second: 40, millisecond: 988, kind: DateTimeKind.Utc), new DateTime(year: 1924, month: 10, day: 4, hour: 11, minute: 42, second: 16, millisecond: 264, kind: DateTimeKind.Utc), new DateTime(year: 1952, month: 10, day: 10, hour: 6, minute: 28, second: 20, millisecond: 760, kind: DateTimeKind.Utc), }, { new DateTime(year: 2000, month: 10, day: 15, hour: 9, minute: 25, second: 56, millisecond: 178, kind: DateTimeKind.Utc), new DateTime(year: 1998, month: 10, day: 13, hour: 19, minute: 11, second: 20, millisecond: 795, kind: DateTimeKind.Utc), new DateTime(year: 1973, month: 10, day: 18, hour: 22, minute: 41, second: 21, millisecond: 882, kind: DateTimeKind.Utc), }, { new DateTime(year: 1929, month: 10, day: 6, hour: 14, minute: 34, second: 48, millisecond: 368, kind: DateTimeKind.Utc), new DateTime(year: 1938, month: 10, day: 7, hour: 14, minute: 54, second: 43, millisecond: 790, kind: DateTimeKind.Utc), new DateTime(year: 1952, month: 10, day: 16, hour: 11, minute: 13, second: 48, millisecond: 514, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1926, month: 10, day: 4, hour: 7, minute: 34, second: 21, millisecond: 620, kind: DateTimeKind.Utc), new DateTime(year: 2013, month: 10, day: 15, hour: 11, minute: 57, second: 9, millisecond: 659, kind: DateTimeKind.Utc), new DateTime(year: 1982, month: 10, day: 10, hour: 5, minute: 27, second: 46, millisecond: 308, kind: DateTimeKind.Utc), }, { new DateTime(year: 2010, month: 10, day: 14, hour: 1, minute: 50, second: 40, millisecond: 562, kind: DateTimeKind.Utc), new DateTime(year: 1925, month: 10, day: 6, hour: 5, minute: 42, second: 5, millisecond: 270, kind: DateTimeKind.Utc), new DateTime(year: 1970, month: 10, day: 6, hour: 5, minute: 20, second: 41, millisecond: 64, kind: DateTimeKind.Utc), }, { new DateTime(year: 2010, month: 10, day: 2, hour: 10, minute: 57, second: 21, millisecond: 944, kind: DateTimeKind.Utc), new DateTime(year: 1991, month: 10, day: 19, hour: 19, minute: 8, second: 16, millisecond: 494, kind: DateTimeKind.Utc), new DateTime(year: 1955, month: 10, day: 7, hour: 7, minute: 26, second: 20, millisecond: 900, kind: DateTimeKind.Utc), }, }, },
    ModelInner = new DateTimetimestamp_with_time_zoneMMArrayD3E1MI
{
    Id = 92,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 2000, month: 10, day: 9, hour: 16, minute: 32, second: 24, millisecond: 880, kind: DateTimeKind.Utc), new DateTime(year: 1999, month: 10, day: 3, hour: 18, minute: 36, second: 10, millisecond: 458, kind: DateTimeKind.Utc), new DateTime(year: 1920, month: 10, day: 8, hour: 3, minute: 27, second: 6, millisecond: 614, kind: DateTimeKind.Utc), }, { new DateTime(year: 1989, month: 10, day: 10, hour: 8, minute: 57, second: 30, millisecond: 335, kind: DateTimeKind.Utc), new DateTime(year: 1931, month: 10, day: 7, hour: 7, minute: 55, second: 35, millisecond: 438, kind: DateTimeKind.Utc), new DateTime(year: 1991, month: 10, day: 2, hour: 8, minute: 34, second: 1, millisecond: 264, kind: DateTimeKind.Utc), }, { new DateTime(year: 1923, month: 10, day: 1, hour: 5, minute: 6, second: 32, millisecond: 587, kind: DateTimeKind.Utc), new DateTime(year: 1985, month: 10, day: 13, hour: 3, minute: 14, second: 54, millisecond: 843, kind: DateTimeKind.Utc), new DateTime(year: 1997, month: 10, day: 13, hour: 12, minute: 47, second: 56, millisecond: 829, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1949, month: 10, day: 5, hour: 7, minute: 16, second: 43, millisecond: 64, kind: DateTimeKind.Utc), new DateTime(year: 2018, month: 10, day: 3, hour: 18, minute: 14, second: 20, millisecond: 731, kind: DateTimeKind.Utc), new DateTime(year: 1950, month: 10, day: 19, hour: 1, minute: 52, second: 8, millisecond: 570, kind: DateTimeKind.Utc), }, { new DateTime(year: 1917, month: 10, day: 15, hour: 15, minute: 41, second: 55, millisecond: 528, kind: DateTimeKind.Utc), new DateTime(year: 1926, month: 10, day: 12, hour: 7, minute: 16, second: 21, millisecond: 701, kind: DateTimeKind.Utc), new DateTime(year: 2000, month: 10, day: 5, hour: 1, minute: 43, second: 39, millisecond: 50, kind: DateTimeKind.Utc), }, { new DateTime(year: 2005, month: 10, day: 9, hour: 2, minute: 40, second: 21, millisecond: 898, kind: DateTimeKind.Utc), new DateTime(year: 1980, month: 10, day: 2, hour: 20, minute: 58, second: 5, millisecond: 482, kind: DateTimeKind.Utc), new DateTime(year: 1932, month: 10, day: 1, hour: 7, minute: 7, second: 18, millisecond: 212, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1969, month: 10, day: 1, hour: 4, minute: 42, second: 31, millisecond: 98, kind: DateTimeKind.Utc), new DateTime(year: 2014, month: 10, day: 19, hour: 21, minute: 47, second: 37, millisecond: 698, kind: DateTimeKind.Utc), new DateTime(year: 1938, month: 10, day: 9, hour: 3, minute: 29, second: 35, millisecond: 552, kind: DateTimeKind.Utc), }, { new DateTime(year: 1970, month: 10, day: 5, hour: 20, minute: 29, second: 47, millisecond: 130, kind: DateTimeKind.Utc), new DateTime(year: 2019, month: 10, day: 10, hour: 18, minute: 31, second: 49, millisecond: 242, kind: DateTimeKind.Utc), new DateTime(year: 1967, month: 10, day: 14, hour: 12, minute: 33, second: 20, millisecond: 998, kind: DateTimeKind.Utc), }, { new DateTime(year: 2003, month: 10, day: 19, hour: 12, minute: 18, second: 5, millisecond: 794, kind: DateTimeKind.Utc), new DateTime(year: 1927, month: 10, day: 1, hour: 7, minute: 57, second: 51, millisecond: 236, kind: DateTimeKind.Utc), new DateTime(year: 1993, month: 10, day: 16, hour: 14, minute: 2, second: 52, millisecond: 40, kind: DateTimeKind.Utc), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneMMArrayD3E1M
{
    Id = 165,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1975, month: 10, day: 14, hour: 17, minute: 46, second: 16, millisecond: 699, kind: DateTimeKind.Utc), new DateTime(year: 1933, month: 10, day: 13, hour: 21, minute: 29, second: 29, millisecond: 188, kind: DateTimeKind.Utc), new DateTime(year: 1948, month: 10, day: 1, hour: 10, minute: 15, second: 21, millisecond: 295, kind: DateTimeKind.Utc), }, { new DateTime(year: 1999, month: 10, day: 18, hour: 8, minute: 3, second: 38, millisecond: 930, kind: DateTimeKind.Utc), new DateTime(year: 2014, month: 10, day: 15, hour: 13, minute: 27, second: 45, millisecond: 904, kind: DateTimeKind.Utc), new DateTime(year: 1928, month: 10, day: 10, hour: 22, minute: 56, second: 10, millisecond: 624, kind: DateTimeKind.Utc), }, { new DateTime(year: 2010, month: 10, day: 14, hour: 19, minute: 45, second: 8, millisecond: 407, kind: DateTimeKind.Utc), new DateTime(year: 1995, month: 10, day: 15, hour: 4, minute: 5, second: 50, millisecond: 905, kind: DateTimeKind.Utc), new DateTime(year: 1936, month: 10, day: 13, hour: 18, minute: 5, second: 14, millisecond: 712, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 2000, month: 10, day: 15, hour: 4, minute: 14, second: 56, millisecond: 845, kind: DateTimeKind.Utc), new DateTime(year: 2014, month: 10, day: 2, hour: 14, minute: 53, second: 49, millisecond: 254, kind: DateTimeKind.Utc), new DateTime(year: 1979, month: 10, day: 18, hour: 7, minute: 55, second: 10, millisecond: 154, kind: DateTimeKind.Utc), }, { new DateTime(year: 1952, month: 10, day: 13, hour: 22, minute: 51, second: 47, millisecond: 138, kind: DateTimeKind.Utc), new DateTime(year: 1965, month: 10, day: 5, hour: 17, minute: 56, second: 46, millisecond: 438, kind: DateTimeKind.Utc), new DateTime(year: 1917, month: 10, day: 11, hour: 3, minute: 57, second: 54, millisecond: 363, kind: DateTimeKind.Utc), }, { new DateTime(year: 1966, month: 10, day: 3, hour: 21, minute: 13, second: 4, millisecond: 134, kind: DateTimeKind.Utc), new DateTime(year: 1987, month: 10, day: 11, hour: 10, minute: 26, second: 46, millisecond: 211, kind: DateTimeKind.Utc), new DateTime(year: 1989, month: 10, day: 15, hour: 10, minute: 32, second: 14, millisecond: 146, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1943, month: 10, day: 17, hour: 2, minute: 50, second: 48, millisecond: 911, kind: DateTimeKind.Utc), new DateTime(year: 1925, month: 10, day: 13, hour: 15, minute: 13, second: 38, millisecond: 952, kind: DateTimeKind.Utc), new DateTime(year: 1951, month: 10, day: 11, hour: 10, minute: 2, second: 27, millisecond: 660, kind: DateTimeKind.Utc), }, { new DateTime(year: 1976, month: 10, day: 13, hour: 14, minute: 40, second: 57, millisecond: 333, kind: DateTimeKind.Utc), new DateTime(year: 1962, month: 10, day: 13, hour: 18, minute: 1, second: 21, millisecond: 338, kind: DateTimeKind.Utc), new DateTime(year: 1997, month: 10, day: 15, hour: 10, minute: 31, second: 3, millisecond: 313, kind: DateTimeKind.Utc), }, { new DateTime(year: 1982, month: 10, day: 3, hour: 4, minute: 4, second: 53, millisecond: 420, kind: DateTimeKind.Utc), new DateTime(year: 1929, month: 10, day: 3, hour: 11, minute: 39, second: 41, millisecond: 99, kind: DateTimeKind.Utc), new DateTime(year: 2014, month: 10, day: 5, hour: 13, minute: 34, second: 31, millisecond: 403, kind: DateTimeKind.Utc), }, }, },
    ModelInner = null,
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1969, month: 10, day: 2, hour: 5, minute: 52, second: 37, millisecond: 610, kind: DateTimeKind.Utc), new DateTime(year: 1968, month: 10, day: 8, hour: 14, minute: 46, second: 14, millisecond: 444, kind: DateTimeKind.Utc), new DateTime(year: 1984, month: 10, day: 11, hour: 13, minute: 42, second: 47, millisecond: 204, kind: DateTimeKind.Utc), }, { new DateTime(year: 2013, month: 10, day: 2, hour: 10, minute: 6, second: 44, millisecond: 815, kind: DateTimeKind.Utc), new DateTime(year: 2005, month: 10, day: 15, hour: 10, minute: 24, second: 29, millisecond: 876, kind: DateTimeKind.Utc), new DateTime(year: 1952, month: 10, day: 9, hour: 17, minute: 29, second: 32, millisecond: 25, kind: DateTimeKind.Utc), }, { new DateTime(year: 2000, month: 10, day: 12, hour: 2, minute: 12, second: 31, millisecond: 295, kind: DateTimeKind.Utc), new DateTime(year: 1955, month: 10, day: 15, hour: 12, minute: 7, second: 48, millisecond: 498, kind: DateTimeKind.Utc), new DateTime(year: 2017, month: 10, day: 10, hour: 12, minute: 42, second: 48, millisecond: 372, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1985, month: 10, day: 11, hour: 4, minute: 40, second: 4, millisecond: 700, kind: DateTimeKind.Utc), new DateTime(year: 2000, month: 10, day: 13, hour: 20, minute: 17, second: 36, millisecond: 846, kind: DateTimeKind.Utc), new DateTime(year: 2000, month: 10, day: 10, hour: 20, minute: 11, second: 54, millisecond: 728, kind: DateTimeKind.Utc), }, { new DateTime(year: 2004, month: 10, day: 4, hour: 10, minute: 3, second: 17, millisecond: 312, kind: DateTimeKind.Utc), new DateTime(year: 1957, month: 10, day: 13, hour: 17, minute: 36, second: 29, millisecond: 262, kind: DateTimeKind.Utc), new DateTime(year: 1991, month: 10, day: 9, hour: 6, minute: 15, second: 35, millisecond: 272, kind: DateTimeKind.Utc), }, { new DateTime(year: 1920, month: 10, day: 4, hour: 20, minute: 58, second: 36, millisecond: 817, kind: DateTimeKind.Utc), new DateTime(year: 1962, month: 10, day: 12, hour: 11, minute: 28, second: 2, millisecond: 901, kind: DateTimeKind.Utc), new DateTime(year: 1955, month: 10, day: 4, hour: 19, minute: 56, second: 2, millisecond: 527, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1936, month: 10, day: 5, hour: 11, minute: 2, second: 4, millisecond: 451, kind: DateTimeKind.Utc), new DateTime(year: 2011, month: 10, day: 15, hour: 6, minute: 51, second: 26, millisecond: 318, kind: DateTimeKind.Utc), new DateTime(year: 2013, month: 10, day: 7, hour: 14, minute: 50, second: 22, millisecond: 87, kind: DateTimeKind.Utc), }, { new DateTime(year: 2018, month: 10, day: 7, hour: 5, minute: 37, second: 45, millisecond: 27, kind: DateTimeKind.Utc), new DateTime(year: 2000, month: 10, day: 9, hour: 9, minute: 45, second: 4, millisecond: 476, kind: DateTimeKind.Utc), new DateTime(year: 2000, month: 10, day: 16, hour: 12, minute: 37, second: 27, millisecond: 172, kind: DateTimeKind.Utc), }, { new DateTime(year: 1997, month: 10, day: 15, hour: 11, minute: 41, second: 15, millisecond: 49, kind: DateTimeKind.Utc), new DateTime(year: 1917, month: 10, day: 1, hour: 8, minute: 40, second: 52, millisecond: 175, kind: DateTimeKind.Utc), new DateTime(year: 1931, month: 10, day: 19, hour: 10, minute: 17, second: 33, millisecond: 49, kind: DateTimeKind.Utc), }, }, },
},
            new DateTimetimestamp_with_time_zoneMMArrayD3E1M
{
    Id = 170,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 2002, month: 10, day: 13, hour: 16, minute: 32, second: 48, millisecond: 754, kind: DateTimeKind.Utc), new DateTime(year: 1955, month: 10, day: 2, hour: 22, minute: 51, second: 41, millisecond: 713, kind: DateTimeKind.Utc), new DateTime(year: 2004, month: 10, day: 6, hour: 12, minute: 41, second: 23, millisecond: 576, kind: DateTimeKind.Utc), }, { new DateTime(year: 1978, month: 10, day: 18, hour: 20, minute: 19, second: 8, millisecond: 509, kind: DateTimeKind.Utc), new DateTime(year: 1990, month: 10, day: 2, hour: 18, minute: 26, second: 29, millisecond: 527, kind: DateTimeKind.Utc), new DateTime(year: 1979, month: 10, day: 6, hour: 10, minute: 24, second: 35, millisecond: 286, kind: DateTimeKind.Utc), }, { new DateTime(year: 1923, month: 10, day: 4, hour: 20, minute: 49, second: 23, millisecond: 844, kind: DateTimeKind.Utc), new DateTime(year: 1974, month: 10, day: 13, hour: 21, minute: 6, second: 2, millisecond: 425, kind: DateTimeKind.Utc), new DateTime(year: 1983, month: 10, day: 8, hour: 12, minute: 53, second: 26, millisecond: 439, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 2001, month: 10, day: 16, hour: 5, minute: 46, second: 9, millisecond: 523, kind: DateTimeKind.Utc), new DateTime(year: 1926, month: 10, day: 11, hour: 8, minute: 56, second: 49, millisecond: 731, kind: DateTimeKind.Utc), new DateTime(year: 1995, month: 10, day: 17, hour: 5, minute: 10, second: 44, millisecond: 493, kind: DateTimeKind.Utc), }, { new DateTime(year: 1935, month: 10, day: 17, hour: 16, minute: 28, second: 27, millisecond: 602, kind: DateTimeKind.Utc), new DateTime(year: 2013, month: 10, day: 5, hour: 3, minute: 58, second: 54, millisecond: 653, kind: DateTimeKind.Utc), new DateTime(year: 1949, month: 10, day: 10, hour: 6, minute: 15, second: 32, millisecond: 182, kind: DateTimeKind.Utc), }, { new DateTime(year: 1936, month: 10, day: 11, hour: 8, minute: 30, second: 6, millisecond: 293, kind: DateTimeKind.Utc), new DateTime(year: 1918, month: 10, day: 10, hour: 13, minute: 13, second: 53, millisecond: 788, kind: DateTimeKind.Utc), new DateTime(year: 1959, month: 10, day: 1, hour: 3, minute: 21, second: 35, millisecond: 5, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1960, month: 10, day: 2, hour: 15, minute: 7, second: 52, millisecond: 575, kind: DateTimeKind.Utc), new DateTime(year: 1936, month: 10, day: 16, hour: 13, minute: 46, second: 26, millisecond: 703, kind: DateTimeKind.Utc), new DateTime(year: 1951, month: 10, day: 16, hour: 7, minute: 38, second: 51, millisecond: 816, kind: DateTimeKind.Utc), }, { new DateTime(year: 1934, month: 10, day: 15, hour: 22, minute: 24, second: 1, millisecond: 134, kind: DateTimeKind.Utc), new DateTime(year: 1982, month: 10, day: 5, hour: 7, minute: 51, second: 20, millisecond: 811, kind: DateTimeKind.Utc), new DateTime(year: 1994, month: 10, day: 14, hour: 17, minute: 16, second: 56, millisecond: 197, kind: DateTimeKind.Utc), }, { new DateTime(year: 1988, month: 10, day: 13, hour: 15, minute: 14, second: 46, millisecond: 681, kind: DateTimeKind.Utc), new DateTime(year: 1967, month: 10, day: 2, hour: 20, minute: 44, second: 56, millisecond: 895, kind: DateTimeKind.Utc), new DateTime(year: 1956, month: 10, day: 19, hour: 10, minute: 15, second: 42, millisecond: 528, kind: DateTimeKind.Utc), }, }, },
    ModelInner = new DateTimetimestamp_with_time_zoneMMArrayD3E1MI
{
    Id = 93,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 2006, month: 10, day: 13, hour: 4, minute: 24, second: 51, millisecond: 240, kind: DateTimeKind.Utc), new DateTime(year: 1980, month: 10, day: 10, hour: 19, minute: 21, second: 40, millisecond: 505, kind: DateTimeKind.Utc), new DateTime(year: 1935, month: 10, day: 18, hour: 6, minute: 49, second: 7, millisecond: 138, kind: DateTimeKind.Utc), }, { new DateTime(year: 1995, month: 10, day: 18, hour: 5, minute: 41, second: 1, millisecond: 836, kind: DateTimeKind.Utc), new DateTime(year: 1960, month: 10, day: 8, hour: 10, minute: 15, second: 26, millisecond: 200, kind: DateTimeKind.Utc), new DateTime(year: 1934, month: 10, day: 13, hour: 16, minute: 25, second: 9, millisecond: 984, kind: DateTimeKind.Utc), }, { new DateTime(year: 1987, month: 10, day: 10, hour: 10, minute: 44, second: 47, millisecond: 828, kind: DateTimeKind.Utc), new DateTime(year: 1978, month: 10, day: 13, hour: 1, minute: 31, second: 48, millisecond: 383, kind: DateTimeKind.Utc), new DateTime(year: 1956, month: 10, day: 4, hour: 7, minute: 10, second: 25, millisecond: 254, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1930, month: 10, day: 15, hour: 16, minute: 57, second: 54, millisecond: 817, kind: DateTimeKind.Utc), new DateTime(year: 2010, month: 10, day: 13, hour: 10, minute: 28, second: 54, millisecond: 599, kind: DateTimeKind.Utc), new DateTime(year: 2012, month: 10, day: 16, hour: 17, minute: 53, second: 8, millisecond: 7, kind: DateTimeKind.Utc), }, { new DateTime(year: 1926, month: 10, day: 11, hour: 13, minute: 44, second: 42, millisecond: 708, kind: DateTimeKind.Utc), new DateTime(year: 1977, month: 10, day: 16, hour: 6, minute: 32, second: 30, millisecond: 665, kind: DateTimeKind.Utc), new DateTime(year: 1992, month: 10, day: 16, hour: 13, minute: 22, second: 32, millisecond: 4, kind: DateTimeKind.Utc), }, { new DateTime(year: 2008, month: 10, day: 11, hour: 18, minute: 50, second: 3, millisecond: 341, kind: DateTimeKind.Utc), new DateTime(year: 1935, month: 10, day: 4, hour: 4, minute: 54, second: 44, millisecond: 296, kind: DateTimeKind.Utc), new DateTime(year: 1960, month: 10, day: 6, hour: 11, minute: 4, second: 16, millisecond: 157, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1925, month: 10, day: 11, hour: 11, minute: 45, second: 8, millisecond: 562, kind: DateTimeKind.Utc), new DateTime(year: 1946, month: 10, day: 10, hour: 7, minute: 56, second: 10, millisecond: 525, kind: DateTimeKind.Utc), new DateTime(year: 1922, month: 10, day: 6, hour: 20, minute: 18, second: 36, millisecond: 248, kind: DateTimeKind.Utc), }, { new DateTime(year: 1968, month: 10, day: 14, hour: 7, minute: 42, second: 13, millisecond: 248, kind: DateTimeKind.Utc), new DateTime(year: 1965, month: 10, day: 17, hour: 6, minute: 41, second: 2, millisecond: 915, kind: DateTimeKind.Utc), new DateTime(year: 1976, month: 10, day: 15, hour: 12, minute: 16, second: 1, millisecond: 938, kind: DateTimeKind.Utc), }, { new DateTime(year: 1923, month: 10, day: 19, hour: 18, minute: 44, second: 57, millisecond: 744, kind: DateTimeKind.Utc), new DateTime(year: 1968, month: 10, day: 9, hour: 3, minute: 48, second: 15, millisecond: 383, kind: DateTimeKind.Utc), new DateTime(year: 1967, month: 10, day: 12, hour: 11, minute: 17, second: 34, millisecond: 882, kind: DateTimeKind.Utc), }, }, },
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1925, month: 10, day: 6, hour: 3, minute: 42, second: 47, millisecond: 407, kind: DateTimeKind.Utc), new DateTime(year: 1976, month: 10, day: 4, hour: 3, minute: 49, second: 34, millisecond: 676, kind: DateTimeKind.Utc), new DateTime(year: 2009, month: 10, day: 15, hour: 4, minute: 15, second: 52, millisecond: 230, kind: DateTimeKind.Utc), }, { new DateTime(year: 1985, month: 10, day: 13, hour: 22, minute: 57, second: 40, millisecond: 981, kind: DateTimeKind.Utc), new DateTime(year: 2019, month: 10, day: 7, hour: 9, minute: 14, second: 5, millisecond: 73, kind: DateTimeKind.Utc), new DateTime(year: 2009, month: 10, day: 16, hour: 4, minute: 13, second: 27, millisecond: 574, kind: DateTimeKind.Utc), }, { new DateTime(year: 2013, month: 10, day: 1, hour: 13, minute: 5, second: 25, millisecond: 542, kind: DateTimeKind.Utc), new DateTime(year: 1957, month: 10, day: 13, hour: 13, minute: 53, second: 41, millisecond: 596, kind: DateTimeKind.Utc), new DateTime(year: 2004, month: 10, day: 16, hour: 22, minute: 13, second: 55, millisecond: 464, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1964, month: 10, day: 1, hour: 20, minute: 23, second: 53, millisecond: 459, kind: DateTimeKind.Utc), new DateTime(year: 1936, month: 10, day: 15, hour: 19, minute: 46, second: 14, millisecond: 607, kind: DateTimeKind.Utc), new DateTime(year: 1998, month: 10, day: 5, hour: 4, minute: 17, second: 33, millisecond: 240, kind: DateTimeKind.Utc), }, { new DateTime(year: 1947, month: 10, day: 8, hour: 12, minute: 48, second: 8, millisecond: 107, kind: DateTimeKind.Utc), new DateTime(year: 1989, month: 10, day: 11, hour: 5, minute: 3, second: 49, millisecond: 411, kind: DateTimeKind.Utc), new DateTime(year: 2002, month: 10, day: 16, hour: 15, minute: 36, second: 56, millisecond: 66, kind: DateTimeKind.Utc), }, { new DateTime(year: 1927, month: 10, day: 5, hour: 18, minute: 40, second: 32, millisecond: 290, kind: DateTimeKind.Utc), new DateTime(year: 1946, month: 10, day: 10, hour: 18, minute: 13, second: 21, millisecond: 955, kind: DateTimeKind.Utc), new DateTime(year: 1987, month: 10, day: 8, hour: 7, minute: 24, second: 7, millisecond: 447, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1924, month: 10, day: 6, hour: 15, minute: 50, second: 16, millisecond: 350, kind: DateTimeKind.Utc), new DateTime(year: 1967, month: 10, day: 18, hour: 13, minute: 17, second: 42, millisecond: 871, kind: DateTimeKind.Utc), new DateTime(year: 1919, month: 10, day: 1, hour: 10, minute: 12, second: 20, millisecond: 958, kind: DateTimeKind.Utc), }, { new DateTime(year: 1996, month: 10, day: 6, hour: 17, minute: 55, second: 23, millisecond: 562, kind: DateTimeKind.Utc), new DateTime(year: 1957, month: 10, day: 14, hour: 16, minute: 9, second: 30, millisecond: 976, kind: DateTimeKind.Utc), new DateTime(year: 1954, month: 10, day: 14, hour: 10, minute: 4, second: 48, millisecond: 219, kind: DateTimeKind.Utc), }, { new DateTime(year: 2000, month: 10, day: 2, hour: 21, minute: 31, second: 49, millisecond: 97, kind: DateTimeKind.Utc), new DateTime(year: 1956, month: 10, day: 11, hour: 17, minute: 13, second: 54, millisecond: 691, kind: DateTimeKind.Utc), new DateTime(year: 1974, month: 10, day: 1, hour: 18, minute: 48, second: 29, millisecond: 991, kind: DateTimeKind.Utc), }, }, },
},
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1967, month: 10, day: 18, hour: 22, minute: 10, second: 28, millisecond: 470, kind: DateTimeKind.Utc), new DateTime(year: 1925, month: 10, day: 15, hour: 2, minute: 22, second: 55, millisecond: 608, kind: DateTimeKind.Utc), new DateTime(year: 1925, month: 10, day: 2, hour: 1, minute: 14, second: 32, millisecond: 823, kind: DateTimeKind.Utc), }, { new DateTime(year: 1991, month: 10, day: 10, hour: 6, minute: 36, second: 52, millisecond: 188, kind: DateTimeKind.Utc), new DateTime(year: 1942, month: 10, day: 9, hour: 22, minute: 34, second: 46, millisecond: 618, kind: DateTimeKind.Utc), new DateTime(year: 1931, month: 10, day: 2, hour: 15, minute: 37, second: 51, millisecond: 793, kind: DateTimeKind.Utc), }, { new DateTime(year: 1939, month: 10, day: 18, hour: 2, minute: 15, second: 12, millisecond: 415, kind: DateTimeKind.Utc), new DateTime(year: 2018, month: 10, day: 15, hour: 13, minute: 46, second: 45, millisecond: 651, kind: DateTimeKind.Utc), new DateTime(year: 1953, month: 10, day: 3, hour: 21, minute: 8, second: 48, millisecond: 898, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1927, month: 10, day: 3, hour: 12, minute: 43, second: 24, millisecond: 162, kind: DateTimeKind.Utc), new DateTime(year: 1924, month: 10, day: 9, hour: 20, minute: 34, second: 43, millisecond: 375, kind: DateTimeKind.Utc), new DateTime(year: 2003, month: 10, day: 10, hour: 15, minute: 52, second: 14, millisecond: 281, kind: DateTimeKind.Utc), }, { new DateTime(year: 1978, month: 10, day: 17, hour: 9, minute: 9, second: 43, millisecond: 670, kind: DateTimeKind.Utc), new DateTime(year: 1923, month: 10, day: 12, hour: 4, minute: 5, second: 52, millisecond: 658, kind: DateTimeKind.Utc), new DateTime(year: 1923, month: 10, day: 11, hour: 15, minute: 5, second: 52, millisecond: 545, kind: DateTimeKind.Utc), }, { new DateTime(year: 1980, month: 10, day: 1, hour: 15, minute: 21, second: 25, millisecond: 343, kind: DateTimeKind.Utc), new DateTime(year: 2006, month: 10, day: 19, hour: 16, minute: 31, second: 34, millisecond: 72, kind: DateTimeKind.Utc), new DateTime(year: 1994, month: 10, day: 7, hour: 4, minute: 29, second: 37, millisecond: 934, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1950, month: 10, day: 16, hour: 9, minute: 50, second: 41, millisecond: 748, kind: DateTimeKind.Utc), new DateTime(year: 1983, month: 10, day: 12, hour: 16, minute: 34, second: 57, millisecond: 524, kind: DateTimeKind.Utc), new DateTime(year: 1959, month: 10, day: 16, hour: 15, minute: 11, second: 26, millisecond: 981, kind: DateTimeKind.Utc), }, { new DateTime(year: 1930, month: 10, day: 2, hour: 17, minute: 16, second: 33, millisecond: 347, kind: DateTimeKind.Utc), new DateTime(year: 1947, month: 10, day: 9, hour: 11, minute: 4, second: 23, millisecond: 91, kind: DateTimeKind.Utc), new DateTime(year: 1959, month: 10, day: 11, hour: 6, minute: 25, second: 46, millisecond: 281, kind: DateTimeKind.Utc), }, { new DateTime(year: 1931, month: 10, day: 2, hour: 4, minute: 23, second: 38, millisecond: 256, kind: DateTimeKind.Utc), new DateTime(year: 1933, month: 10, day: 13, hour: 8, minute: 46, second: 16, millisecond: 752, kind: DateTimeKind.Utc), new DateTime(year: 1931, month: 10, day: 3, hour: 13, minute: 39, second: 47, millisecond: 316, kind: DateTimeKind.Utc), }, }, },
},
            new DateTimetimestamp_with_time_zoneMMArrayD3E1M
{
    Id = 171,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1918, month: 10, day: 17, hour: 6, minute: 15, second: 12, millisecond: 187, kind: DateTimeKind.Utc), new DateTime(year: 2010, month: 10, day: 16, hour: 2, minute: 1, second: 54, millisecond: 383, kind: DateTimeKind.Utc), new DateTime(year: 1942, month: 10, day: 12, hour: 16, minute: 20, second: 1, millisecond: 364, kind: DateTimeKind.Utc), }, { new DateTime(year: 1957, month: 10, day: 16, hour: 2, minute: 46, second: 34, millisecond: 127, kind: DateTimeKind.Utc), new DateTime(year: 2005, month: 10, day: 10, hour: 15, minute: 44, second: 40, millisecond: 530, kind: DateTimeKind.Utc), new DateTime(year: 2004, month: 10, day: 4, hour: 18, minute: 40, second: 32, millisecond: 493, kind: DateTimeKind.Utc), }, { new DateTime(year: 1918, month: 10, day: 5, hour: 2, minute: 5, second: 4, millisecond: 249, kind: DateTimeKind.Utc), new DateTime(year: 1978, month: 10, day: 8, hour: 8, minute: 45, second: 35, millisecond: 400, kind: DateTimeKind.Utc), new DateTime(year: 2004, month: 10, day: 15, hour: 5, minute: 50, second: 42, millisecond: 32, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1971, month: 10, day: 17, hour: 6, minute: 30, second: 57, millisecond: 733, kind: DateTimeKind.Utc), new DateTime(year: 1967, month: 10, day: 7, hour: 7, minute: 33, second: 19, millisecond: 372, kind: DateTimeKind.Utc), new DateTime(year: 1973, month: 10, day: 8, hour: 20, minute: 36, second: 51, millisecond: 210, kind: DateTimeKind.Utc), }, { new DateTime(year: 1957, month: 10, day: 13, hour: 21, minute: 57, second: 11, millisecond: 604, kind: DateTimeKind.Utc), new DateTime(year: 1930, month: 10, day: 16, hour: 17, minute: 46, second: 34, millisecond: 590, kind: DateTimeKind.Utc), new DateTime(year: 1926, month: 10, day: 15, hour: 16, minute: 39, second: 49, millisecond: 113, kind: DateTimeKind.Utc), }, { new DateTime(year: 1977, month: 10, day: 13, hour: 11, minute: 56, second: 42, millisecond: 915, kind: DateTimeKind.Utc), new DateTime(year: 1957, month: 10, day: 14, hour: 17, minute: 34, second: 51, millisecond: 510, kind: DateTimeKind.Utc), new DateTime(year: 1933, month: 10, day: 10, hour: 2, minute: 18, second: 50, millisecond: 172, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1928, month: 10, day: 1, hour: 16, minute: 7, second: 1, millisecond: 221, kind: DateTimeKind.Utc), new DateTime(year: 1944, month: 10, day: 5, hour: 6, minute: 53, second: 50, millisecond: 332, kind: DateTimeKind.Utc), new DateTime(year: 1991, month: 10, day: 11, hour: 16, minute: 6, second: 31, millisecond: 36, kind: DateTimeKind.Utc), }, { new DateTime(year: 2008, month: 10, day: 7, hour: 19, minute: 38, second: 25, millisecond: 505, kind: DateTimeKind.Utc), new DateTime(year: 1939, month: 10, day: 4, hour: 8, minute: 29, second: 30, millisecond: 575, kind: DateTimeKind.Utc), new DateTime(year: 2010, month: 10, day: 7, hour: 19, minute: 2, second: 22, millisecond: 205, kind: DateTimeKind.Utc), }, { new DateTime(year: 2017, month: 10, day: 16, hour: 7, minute: 44, second: 39, millisecond: 10, kind: DateTimeKind.Utc), new DateTime(year: 2012, month: 10, day: 5, hour: 11, minute: 25, second: 43, millisecond: 529, kind: DateTimeKind.Utc), new DateTime(year: 1986, month: 10, day: 17, hour: 21, minute: 39, second: 17, millisecond: 834, kind: DateTimeKind.Utc), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zoneMMArrayD3E1M
{
    Id = 173,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1930, month: 10, day: 9, hour: 1, minute: 6, second: 29, millisecond: 339, kind: DateTimeKind.Utc), new DateTime(year: 1976, month: 10, day: 16, hour: 12, minute: 52, second: 17, millisecond: 804, kind: DateTimeKind.Utc), new DateTime(year: 1951, month: 10, day: 19, hour: 12, minute: 42, second: 46, millisecond: 258, kind: DateTimeKind.Utc), }, { new DateTime(year: 1930, month: 10, day: 19, hour: 16, minute: 55, second: 4, millisecond: 38, kind: DateTimeKind.Utc), new DateTime(year: 1929, month: 10, day: 6, hour: 15, minute: 18, second: 24, millisecond: 803, kind: DateTimeKind.Utc), new DateTime(year: 1987, month: 10, day: 17, hour: 11, minute: 58, second: 28, millisecond: 580, kind: DateTimeKind.Utc), }, { new DateTime(year: 1986, month: 10, day: 15, hour: 12, minute: 43, second: 21, millisecond: 863, kind: DateTimeKind.Utc), new DateTime(year: 1932, month: 10, day: 9, hour: 16, minute: 27, second: 25, millisecond: 898, kind: DateTimeKind.Utc), new DateTime(year: 1968, month: 10, day: 6, hour: 11, minute: 55, second: 51, millisecond: 226, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1929, month: 10, day: 12, hour: 19, minute: 36, second: 35, millisecond: 684, kind: DateTimeKind.Utc), new DateTime(year: 1974, month: 10, day: 17, hour: 17, minute: 40, second: 1, millisecond: 15, kind: DateTimeKind.Utc), new DateTime(year: 2010, month: 10, day: 11, hour: 19, minute: 46, second: 32, millisecond: 22, kind: DateTimeKind.Utc), }, { new DateTime(year: 1950, month: 10, day: 3, hour: 13, minute: 17, second: 41, millisecond: 425, kind: DateTimeKind.Utc), new DateTime(year: 1949, month: 10, day: 8, hour: 21, minute: 45, second: 58, millisecond: 720, kind: DateTimeKind.Utc), new DateTime(year: 1987, month: 10, day: 14, hour: 5, minute: 30, second: 3, millisecond: 583, kind: DateTimeKind.Utc), }, { new DateTime(year: 1977, month: 10, day: 9, hour: 4, minute: 21, second: 49, millisecond: 774, kind: DateTimeKind.Utc), new DateTime(year: 1961, month: 10, day: 10, hour: 16, minute: 10, second: 6, millisecond: 836, kind: DateTimeKind.Utc), new DateTime(year: 2005, month: 10, day: 12, hour: 10, minute: 33, second: 31, millisecond: 335, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1944, month: 10, day: 17, hour: 11, minute: 35, second: 53, millisecond: 463, kind: DateTimeKind.Utc), new DateTime(year: 1999, month: 10, day: 1, hour: 10, minute: 8, second: 5, millisecond: 458, kind: DateTimeKind.Utc), new DateTime(year: 1928, month: 10, day: 12, hour: 1, minute: 18, second: 58, millisecond: 92, kind: DateTimeKind.Utc), }, { new DateTime(year: 1986, month: 10, day: 1, hour: 22, minute: 20, second: 44, millisecond: 132, kind: DateTimeKind.Utc), new DateTime(year: 1997, month: 10, day: 13, hour: 14, minute: 44, second: 51, millisecond: 962, kind: DateTimeKind.Utc), new DateTime(year: 1995, month: 10, day: 3, hour: 2, minute: 50, second: 11, millisecond: 272, kind: DateTimeKind.Utc), }, { new DateTime(year: 1985, month: 10, day: 14, hour: 5, minute: 50, second: 14, millisecond: 586, kind: DateTimeKind.Utc), new DateTime(year: 1998, month: 10, day: 9, hour: 15, minute: 29, second: 26, millisecond: 288, kind: DateTimeKind.Utc), new DateTime(year: 1992, month: 10, day: 9, hour: 14, minute: 10, second: 16, millisecond: 683, kind: DateTimeKind.Utc), }, }, },
    ModelInner = new DateTimetimestamp_with_time_zoneMMArrayD3E1MI
{
    Id = 102,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 2006, month: 10, day: 6, hour: 3, minute: 10, second: 8, millisecond: 829, kind: DateTimeKind.Utc), new DateTime(year: 1963, month: 10, day: 10, hour: 10, minute: 24, second: 4, millisecond: 330, kind: DateTimeKind.Utc), new DateTime(year: 1978, month: 10, day: 14, hour: 12, minute: 21, second: 13, millisecond: 985, kind: DateTimeKind.Utc), }, { new DateTime(year: 1976, month: 10, day: 19, hour: 21, minute: 28, second: 24, millisecond: 457, kind: DateTimeKind.Utc), new DateTime(year: 1989, month: 10, day: 16, hour: 8, minute: 39, second: 39, millisecond: 251, kind: DateTimeKind.Utc), new DateTime(year: 1998, month: 10, day: 13, hour: 5, minute: 12, second: 18, millisecond: 949, kind: DateTimeKind.Utc), }, { new DateTime(year: 2015, month: 10, day: 16, hour: 6, minute: 20, second: 5, millisecond: 572, kind: DateTimeKind.Utc), new DateTime(year: 1953, month: 10, day: 13, hour: 6, minute: 49, second: 18, millisecond: 542, kind: DateTimeKind.Utc), new DateTime(year: 1961, month: 10, day: 11, hour: 18, minute: 19, second: 11, millisecond: 454, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1994, month: 10, day: 7, hour: 21, minute: 35, second: 42, millisecond: 40, kind: DateTimeKind.Utc), new DateTime(year: 1959, month: 10, day: 1, hour: 12, minute: 13, second: 22, millisecond: 694, kind: DateTimeKind.Utc), new DateTime(year: 1933, month: 10, day: 2, hour: 6, minute: 35, second: 46, millisecond: 987, kind: DateTimeKind.Utc), }, { new DateTime(year: 2007, month: 10, day: 14, hour: 12, minute: 26, second: 48, millisecond: 167, kind: DateTimeKind.Utc), new DateTime(year: 2000, month: 10, day: 8, hour: 22, minute: 17, second: 24, millisecond: 391, kind: DateTimeKind.Utc), new DateTime(year: 1995, month: 10, day: 3, hour: 14, minute: 47, second: 18, millisecond: 673, kind: DateTimeKind.Utc), }, { new DateTime(year: 1966, month: 10, day: 17, hour: 2, minute: 53, second: 20, millisecond: 882, kind: DateTimeKind.Utc), new DateTime(year: 1971, month: 10, day: 19, hour: 9, minute: 19, second: 48, millisecond: 775, kind: DateTimeKind.Utc), new DateTime(year: 1920, month: 10, day: 6, hour: 4, minute: 8, second: 14, millisecond: 790, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1917, month: 10, day: 13, hour: 9, minute: 35, second: 54, millisecond: 759, kind: DateTimeKind.Utc), new DateTime(year: 1983, month: 10, day: 5, hour: 5, minute: 35, second: 9, millisecond: 448, kind: DateTimeKind.Utc), new DateTime(year: 2005, month: 10, day: 7, hour: 16, minute: 34, second: 58, millisecond: 861, kind: DateTimeKind.Utc), }, { new DateTime(year: 1927, month: 10, day: 13, hour: 7, minute: 9, second: 29, millisecond: 132, kind: DateTimeKind.Utc), new DateTime(year: 1964, month: 10, day: 11, hour: 4, minute: 48, second: 26, millisecond: 756, kind: DateTimeKind.Utc), new DateTime(year: 1952, month: 10, day: 4, hour: 9, minute: 55, second: 26, millisecond: 107, kind: DateTimeKind.Utc), }, { new DateTime(year: 1945, month: 10, day: 1, hour: 21, minute: 17, second: 36, millisecond: 386, kind: DateTimeKind.Utc), new DateTime(year: 1930, month: 10, day: 18, hour: 12, minute: 18, second: 35, millisecond: 245, kind: DateTimeKind.Utc), new DateTime(year: 1950, month: 10, day: 12, hour: 11, minute: 42, second: 58, millisecond: 323, kind: DateTimeKind.Utc), }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1965, month: 10, day: 7, hour: 5, minute: 23, second: 48, millisecond: 319, kind: DateTimeKind.Utc), new DateTime(year: 1988, month: 10, day: 15, hour: 14, minute: 50, second: 35, millisecond: 502, kind: DateTimeKind.Utc), new DateTime(year: 2004, month: 10, day: 7, hour: 8, minute: 57, second: 43, millisecond: 675, kind: DateTimeKind.Utc), }, { new DateTime(year: 1984, month: 10, day: 11, hour: 14, minute: 45, second: 10, millisecond: 92, kind: DateTimeKind.Utc), new DateTime(year: 1962, month: 10, day: 17, hour: 14, minute: 21, second: 17, millisecond: 631, kind: DateTimeKind.Utc), new DateTime(year: 1980, month: 10, day: 9, hour: 14, minute: 46, second: 36, millisecond: 508, kind: DateTimeKind.Utc), }, { new DateTime(year: 1989, month: 10, day: 8, hour: 15, minute: 19, second: 33, millisecond: 356, kind: DateTimeKind.Utc), new DateTime(year: 1948, month: 10, day: 3, hour: 3, minute: 17, second: 28, millisecond: 105, kind: DateTimeKind.Utc), new DateTime(year: 1977, month: 10, day: 17, hour: 16, minute: 40, second: 47, millisecond: 962, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1953, month: 10, day: 7, hour: 8, minute: 2, second: 12, millisecond: 236, kind: DateTimeKind.Utc), new DateTime(year: 1919, month: 10, day: 3, hour: 13, minute: 9, second: 24, millisecond: 300, kind: DateTimeKind.Utc), new DateTime(year: 2000, month: 10, day: 17, hour: 18, minute: 31, second: 6, millisecond: 64, kind: DateTimeKind.Utc), }, { new DateTime(year: 1958, month: 10, day: 8, hour: 19, minute: 45, second: 5, millisecond: 692, kind: DateTimeKind.Utc), new DateTime(year: 1939, month: 10, day: 3, hour: 6, minute: 25, second: 43, millisecond: 613, kind: DateTimeKind.Utc), new DateTime(year: 1990, month: 10, day: 4, hour: 19, minute: 7, second: 57, millisecond: 134, kind: DateTimeKind.Utc), }, { new DateTime(year: 2003, month: 10, day: 10, hour: 19, minute: 55, second: 45, millisecond: 219, kind: DateTimeKind.Utc), new DateTime(year: 1926, month: 10, day: 14, hour: 15, minute: 57, second: 40, millisecond: 582, kind: DateTimeKind.Utc), new DateTime(year: 1976, month: 10, day: 7, hour: 17, minute: 37, second: 31, millisecond: 420, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1942, month: 10, day: 2, hour: 18, minute: 15, second: 16, millisecond: 385, kind: DateTimeKind.Utc), new DateTime(year: 2013, month: 10, day: 17, hour: 10, minute: 12, second: 18, millisecond: 131, kind: DateTimeKind.Utc), new DateTime(year: 1953, month: 10, day: 5, hour: 20, minute: 40, second: 51, millisecond: 776, kind: DateTimeKind.Utc), }, { new DateTime(year: 2002, month: 10, day: 11, hour: 12, minute: 37, second: 48, millisecond: 357, kind: DateTimeKind.Utc), new DateTime(year: 1961, month: 10, day: 4, hour: 22, minute: 1, second: 47, millisecond: 283, kind: DateTimeKind.Utc), new DateTime(year: 1994, month: 10, day: 18, hour: 2, minute: 9, second: 45, millisecond: 224, kind: DateTimeKind.Utc), }, { new DateTime(year: 2003, month: 10, day: 8, hour: 13, minute: 26, second: 43, millisecond: 75, kind: DateTimeKind.Utc), new DateTime(year: 1983, month: 10, day: 14, hour: 2, minute: 28, second: 57, millisecond: 281, kind: DateTimeKind.Utc), new DateTime(year: 1958, month: 10, day: 6, hour: 18, minute: 27, second: 12, millisecond: 517, kind: DateTimeKind.Utc), }, }, },
},
            new DateTimetimestamp_with_time_zoneMMArrayD3E1M
{
    Id = 182,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1991, month: 10, day: 12, hour: 5, minute: 28, second: 11, millisecond: 733, kind: DateTimeKind.Utc), new DateTime(year: 1972, month: 10, day: 2, hour: 1, minute: 6, second: 23, millisecond: 937, kind: DateTimeKind.Utc), new DateTime(year: 1979, month: 10, day: 3, hour: 20, minute: 36, second: 22, millisecond: 33, kind: DateTimeKind.Utc), }, { new DateTime(year: 1967, month: 10, day: 9, hour: 14, minute: 30, second: 29, millisecond: 159, kind: DateTimeKind.Utc), new DateTime(year: 1975, month: 10, day: 5, hour: 10, minute: 24, second: 3, millisecond: 463, kind: DateTimeKind.Utc), new DateTime(year: 2019, month: 10, day: 10, hour: 12, minute: 20, second: 27, millisecond: 927, kind: DateTimeKind.Utc), }, { new DateTime(year: 1929, month: 10, day: 1, hour: 12, minute: 56, second: 42, millisecond: 108, kind: DateTimeKind.Utc), new DateTime(year: 1980, month: 10, day: 3, hour: 13, minute: 21, second: 34, millisecond: 871, kind: DateTimeKind.Utc), new DateTime(year: 1921, month: 10, day: 8, hour: 7, minute: 50, second: 31, millisecond: 258, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1933, month: 10, day: 15, hour: 3, minute: 38, second: 31, millisecond: 951, kind: DateTimeKind.Utc), new DateTime(year: 1956, month: 10, day: 7, hour: 6, minute: 21, second: 46, millisecond: 541, kind: DateTimeKind.Utc), new DateTime(year: 1929, month: 10, day: 8, hour: 15, minute: 42, second: 12, millisecond: 717, kind: DateTimeKind.Utc), }, { new DateTime(year: 2015, month: 10, day: 10, hour: 4, minute: 49, second: 5, millisecond: 19, kind: DateTimeKind.Utc), new DateTime(year: 1949, month: 10, day: 19, hour: 8, minute: 37, second: 41, millisecond: 977, kind: DateTimeKind.Utc), new DateTime(year: 1964, month: 10, day: 5, hour: 1, minute: 54, second: 53, millisecond: 902, kind: DateTimeKind.Utc), }, { new DateTime(year: 1957, month: 10, day: 7, hour: 17, minute: 32, second: 35, millisecond: 923, kind: DateTimeKind.Utc), new DateTime(year: 1995, month: 10, day: 19, hour: 13, minute: 14, second: 29, millisecond: 793, kind: DateTimeKind.Utc), new DateTime(year: 1971, month: 10, day: 14, hour: 22, minute: 57, second: 33, millisecond: 956, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 2014, month: 10, day: 18, hour: 7, minute: 22, second: 41, millisecond: 609, kind: DateTimeKind.Utc), new DateTime(year: 2010, month: 10, day: 3, hour: 22, minute: 26, second: 54, millisecond: 224, kind: DateTimeKind.Utc), new DateTime(year: 2018, month: 10, day: 12, hour: 20, minute: 26, second: 8, millisecond: 370, kind: DateTimeKind.Utc), }, { new DateTime(year: 1998, month: 10, day: 13, hour: 4, minute: 25, second: 5, millisecond: 401, kind: DateTimeKind.Utc), new DateTime(year: 2007, month: 10, day: 10, hour: 11, minute: 41, second: 24, millisecond: 896, kind: DateTimeKind.Utc), new DateTime(year: 1983, month: 10, day: 5, hour: 16, minute: 11, second: 19, millisecond: 520, kind: DateTimeKind.Utc), }, { new DateTime(year: 1990, month: 10, day: 16, hour: 12, minute: 41, second: 9, millisecond: 885, kind: DateTimeKind.Utc), new DateTime(year: 1992, month: 10, day: 18, hour: 2, minute: 48, second: 8, millisecond: 866, kind: DateTimeKind.Utc), new DateTime(year: 1934, month: 10, day: 12, hour: 22, minute: 58, second: 31, millisecond: 456, kind: DateTimeKind.Utc), }, }, },
    ModelInner = null,
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1993, month: 10, day: 9, hour: 4, minute: 12, second: 52, millisecond: 671, kind: DateTimeKind.Utc), new DateTime(year: 1980, month: 10, day: 19, hour: 22, minute: 24, second: 56, millisecond: 603, kind: DateTimeKind.Utc), new DateTime(year: 1997, month: 10, day: 9, hour: 10, minute: 15, second: 30, millisecond: 327, kind: DateTimeKind.Utc), }, { new DateTime(year: 1935, month: 10, day: 15, hour: 5, minute: 38, second: 10, millisecond: 555, kind: DateTimeKind.Utc), new DateTime(year: 1925, month: 10, day: 16, hour: 4, minute: 44, second: 50, millisecond: 636, kind: DateTimeKind.Utc), new DateTime(year: 1995, month: 10, day: 13, hour: 13, minute: 56, second: 20, millisecond: 976, kind: DateTimeKind.Utc), }, { new DateTime(year: 1972, month: 10, day: 13, hour: 19, minute: 49, second: 7, millisecond: 925, kind: DateTimeKind.Utc), new DateTime(year: 1937, month: 10, day: 10, hour: 10, minute: 39, second: 38, millisecond: 687, kind: DateTimeKind.Utc), new DateTime(year: 1917, month: 10, day: 15, hour: 1, minute: 43, second: 53, millisecond: 206, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 2002, month: 10, day: 15, hour: 10, minute: 12, second: 1, millisecond: 231, kind: DateTimeKind.Utc), new DateTime(year: 1956, month: 10, day: 15, hour: 22, minute: 8, second: 30, millisecond: 369, kind: DateTimeKind.Utc), new DateTime(year: 1964, month: 10, day: 18, hour: 7, minute: 10, second: 16, millisecond: 784, kind: DateTimeKind.Utc), }, { new DateTime(year: 1932, month: 10, day: 3, hour: 2, minute: 42, second: 58, millisecond: 338, kind: DateTimeKind.Utc), new DateTime(year: 1939, month: 10, day: 5, hour: 13, minute: 5, second: 10, millisecond: 531, kind: DateTimeKind.Utc), new DateTime(year: 1958, month: 10, day: 3, hour: 16, minute: 44, second: 30, millisecond: 818, kind: DateTimeKind.Utc), }, { new DateTime(year: 1920, month: 10, day: 19, hour: 13, minute: 8, second: 26, millisecond: 570, kind: DateTimeKind.Utc), new DateTime(year: 1971, month: 10, day: 16, hour: 12, minute: 32, second: 38, millisecond: 847, kind: DateTimeKind.Utc), new DateTime(year: 2004, month: 10, day: 4, hour: 15, minute: 30, second: 14, millisecond: 725, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1923, month: 10, day: 7, hour: 21, minute: 14, second: 50, millisecond: 633, kind: DateTimeKind.Utc), new DateTime(year: 1958, month: 10, day: 18, hour: 17, minute: 51, second: 37, millisecond: 918, kind: DateTimeKind.Utc), new DateTime(year: 1994, month: 10, day: 19, hour: 10, minute: 37, second: 40, millisecond: 721, kind: DateTimeKind.Utc), }, { new DateTime(year: 1927, month: 10, day: 12, hour: 14, minute: 16, second: 51, millisecond: 555, kind: DateTimeKind.Utc), new DateTime(year: 1997, month: 10, day: 11, hour: 20, minute: 24, second: 17, millisecond: 887, kind: DateTimeKind.Utc), new DateTime(year: 1936, month: 10, day: 12, hour: 10, minute: 37, second: 9, millisecond: 376, kind: DateTimeKind.Utc), }, { new DateTime(year: 1941, month: 10, day: 12, hour: 17, minute: 58, second: 32, millisecond: 819, kind: DateTimeKind.Utc), new DateTime(year: 1998, month: 10, day: 4, hour: 16, minute: 17, second: 45, millisecond: 406, kind: DateTimeKind.Utc), new DateTime(year: 2006, month: 10, day: 7, hour: 11, minute: 6, second: 18, millisecond: 294, kind: DateTimeKind.Utc), }, }, },
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_with_time_zonemmarrayd3e1mi(
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
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483622)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[,,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483622))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_with_time_zonemmarrayd3e1mi(
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
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483622)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[,,]), 
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

                changedRows =  ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_with_time_zonemmarrayd3e1m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_with_time_zonemmarrayd3e1mi_id
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
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483622)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[,,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483622)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "datetimetimestamp_with_time_zonemmarrayd3e1mi_id", 
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
                changedRows =  ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_with_time_zonemmarrayd3e1m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_with_time_zonemmarrayd3e1mi_id
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
    datetimetimestamp_with_time_zonemmarrayd3e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)),
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
                System.DateTime[,,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.DateTime[,,]>();
                    ((NpgsqlParameter<System.DateTime[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483622);
                    ((NpgsqlParameter<System.DateTime[,,]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.DateTime[,,] { { { new DateTime(year: 1945, month: 10, day: 17, hour: 12, minute: 43, second: 40, millisecond: 879, kind: DateTimeKind.Utc), new DateTime(year: 1999, month: 10, day: 14, hour: 5, minute: 28, second: 43, millisecond: 160, kind: DateTimeKind.Utc), new DateTime(year: 1988, month: 10, day: 14, hour: 18, minute: 25, second: 28, millisecond: 968, kind: DateTimeKind.Utc), }, { new DateTime(year: 2004, month: 10, day: 16, hour: 16, minute: 47, second: 9, millisecond: 524, kind: DateTimeKind.Utc), new DateTime(year: 1919, month: 10, day: 4, hour: 18, minute: 38, second: 56, millisecond: 917, kind: DateTimeKind.Utc), new DateTime(year: 1955, month: 10, day: 19, hour: 19, minute: 3, second: 23, millisecond: 23, kind: DateTimeKind.Utc), }, { new DateTime(year: 2004, month: 10, day: 7, hour: 3, minute: 46, second: 12, millisecond: 206, kind: DateTimeKind.Utc), new DateTime(year: 1965, month: 10, day: 5, hour: 20, minute: 22, second: 6, millisecond: 16, kind: DateTimeKind.Utc), new DateTime(year: 1972, month: 10, day: 17, hour: 1, minute: 57, second: 39, millisecond: 625, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1991, month: 10, day: 7, hour: 17, minute: 1, second: 40, millisecond: 504, kind: DateTimeKind.Utc), new DateTime(year: 1974, month: 10, day: 7, hour: 13, minute: 52, second: 57, millisecond: 310, kind: DateTimeKind.Utc), new DateTime(year: 1979, month: 10, day: 5, hour: 18, minute: 25, second: 9, millisecond: 974, kind: DateTimeKind.Utc), }, { new DateTime(year: 1990, month: 10, day: 8, hour: 1, minute: 18, second: 47, millisecond: 208, kind: DateTimeKind.Utc), new DateTime(year: 1940, month: 10, day: 4, hour: 22, minute: 6, second: 12, millisecond: 473, kind: DateTimeKind.Utc), new DateTime(year: 2017, month: 10, day: 6, hour: 1, minute: 17, second: 25, millisecond: 373, kind: DateTimeKind.Utc), }, { new DateTime(year: 1971, month: 10, day: 19, hour: 11, minute: 48, second: 24, millisecond: 201, kind: DateTimeKind.Utc), new DateTime(year: 1953, month: 10, day: 16, hour: 12, minute: 7, second: 51, millisecond: 860, kind: DateTimeKind.Utc), new DateTime(year: 1973, month: 10, day: 5, hour: 7, minute: 18, second: 11, millisecond: 922, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1950, month: 10, day: 17, hour: 18, minute: 24, second: 7, millisecond: 793, kind: DateTimeKind.Utc), new DateTime(year: 1960, month: 10, day: 4, hour: 20, minute: 53, second: 22, millisecond: 541, kind: DateTimeKind.Utc), new DateTime(year: 2010, month: 10, day: 7, hour: 9, minute: 55, second: 57, millisecond: 689, kind: DateTimeKind.Utc), }, { new DateTime(year: 1954, month: 10, day: 2, hour: 7, minute: 36, second: 32, millisecond: 976, kind: DateTimeKind.Utc), new DateTime(year: 1930, month: 10, day: 14, hour: 13, minute: 42, second: 34, millisecond: 406, kind: DateTimeKind.Utc), new DateTime(year: 1964, month: 10, day: 7, hour: 6, minute: 53, second: 51, millisecond: 682, kind: DateTimeKind.Utc), }, { new DateTime(year: 1922, month: 10, day: 17, hour: 14, minute: 58, second: 42, millisecond: 88, kind: DateTimeKind.Utc), new DateTime(year: 1974, month: 10, day: 5, hour: 16, minute: 5, second: 28, millisecond: 967, kind: DateTimeKind.Utc), new DateTime(year: 1978, month: 10, day: 17, hour: 16, minute: 41, second: 4, millisecond: 794, kind: DateTimeKind.Utc), }, }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.DateTime[,,]>();
                    ((NpgsqlParameter<System.DateTime[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483622);
                    ((NpgsqlParameter<System.DateTime[,,]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                System.DateTime[,,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.DateTime[,,]>();
                    ((NpgsqlParameter<System.DateTime[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483622);
                    ((NpgsqlParameter<System.DateTime[,,]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.DateTime[,,] { { { new DateTime(year: 1923, month: 10, day: 6, hour: 3, minute: 49, second: 25, millisecond: 790, kind: DateTimeKind.Utc), new DateTime(year: 1921, month: 10, day: 4, hour: 12, minute: 15, second: 10, millisecond: 752, kind: DateTimeKind.Utc), new DateTime(year: 1985, month: 10, day: 3, hour: 17, minute: 1, second: 14, millisecond: 934, kind: DateTimeKind.Utc), }, { new DateTime(year: 1988, month: 10, day: 19, hour: 11, minute: 10, second: 49, millisecond: 854, kind: DateTimeKind.Utc), new DateTime(year: 1978, month: 10, day: 2, hour: 2, minute: 46, second: 36, millisecond: 510, kind: DateTimeKind.Utc), new DateTime(year: 1955, month: 10, day: 11, hour: 2, minute: 29, second: 28, millisecond: 677, kind: DateTimeKind.Utc), }, { new DateTime(year: 1939, month: 10, day: 8, hour: 11, minute: 30, second: 46, millisecond: 167, kind: DateTimeKind.Utc), new DateTime(year: 2016, month: 10, day: 8, hour: 7, minute: 50, second: 45, millisecond: 51, kind: DateTimeKind.Utc), new DateTime(year: 2017, month: 10, day: 17, hour: 9, minute: 2, second: 29, millisecond: 162, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 2000, month: 10, day: 8, hour: 9, minute: 49, second: 32, millisecond: 704, kind: DateTimeKind.Utc), new DateTime(year: 2013, month: 10, day: 7, hour: 2, minute: 35, second: 29, millisecond: 542, kind: DateTimeKind.Utc), new DateTime(year: 1986, month: 10, day: 7, hour: 5, minute: 31, second: 13, millisecond: 690, kind: DateTimeKind.Utc), }, { new DateTime(year: 1998, month: 10, day: 14, hour: 10, minute: 28, second: 8, millisecond: 467, kind: DateTimeKind.Utc), new DateTime(year: 1922, month: 10, day: 10, hour: 6, minute: 8, second: 45, millisecond: 593, kind: DateTimeKind.Utc), new DateTime(year: 1966, month: 10, day: 3, hour: 10, minute: 43, second: 17, millisecond: 196, kind: DateTimeKind.Utc), }, { new DateTime(year: 1939, month: 10, day: 5, hour: 1, minute: 8, second: 24, millisecond: 54, kind: DateTimeKind.Utc), new DateTime(year: 1955, month: 10, day: 14, hour: 18, minute: 21, second: 6, millisecond: 312, kind: DateTimeKind.Utc), new DateTime(year: 1940, month: 10, day: 1, hour: 13, minute: 49, second: 33, millisecond: 453, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1977, month: 10, day: 2, hour: 10, minute: 47, second: 55, millisecond: 785, kind: DateTimeKind.Utc), new DateTime(year: 1970, month: 10, day: 7, hour: 14, minute: 31, second: 52, millisecond: 223, kind: DateTimeKind.Utc), new DateTime(year: 1951, month: 10, day: 9, hour: 11, minute: 39, second: 28, millisecond: 701, kind: DateTimeKind.Utc), }, { new DateTime(year: 1990, month: 10, day: 11, hour: 16, minute: 7, second: 54, millisecond: 220, kind: DateTimeKind.Utc), new DateTime(year: 1925, month: 10, day: 2, hour: 7, minute: 58, second: 24, millisecond: 246, kind: DateTimeKind.Utc), new DateTime(year: 1942, month: 10, day: 19, hour: 7, minute: 51, second: 21, millisecond: 661, kind: DateTimeKind.Utc), }, { new DateTime(year: 1956, month: 10, day: 2, hour: 22, minute: 2, second: 31, millisecond: 709, kind: DateTimeKind.Utc), new DateTime(year: 1957, month: 10, day: 1, hour: 21, minute: 24, second: 52, millisecond: 82, kind: DateTimeKind.Utc), new DateTime(year: 1981, month: 10, day: 1, hour: 4, minute: 54, second: 5, millisecond: 571, kind: DateTimeKind.Utc), }, }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.DateTime[,,]>();
                    ((NpgsqlParameter<System.DateTime[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483622);
                    ((NpgsqlParameter<System.DateTime[,,]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.DateTime[,,] { { { new DateTime(year: 1920, month: 10, day: 10, hour: 3, minute: 34, second: 12, millisecond: 214, kind: DateTimeKind.Utc), new DateTime(year: 1995, month: 10, day: 9, hour: 2, minute: 22, second: 50, millisecond: 591, kind: DateTimeKind.Utc), new DateTime(year: 1942, month: 10, day: 19, hour: 12, minute: 48, second: 7, millisecond: 204, kind: DateTimeKind.Utc), }, { new DateTime(year: 1934, month: 10, day: 3, hour: 12, minute: 24, second: 1, millisecond: 750, kind: DateTimeKind.Utc), new DateTime(year: 1946, month: 10, day: 2, hour: 5, minute: 49, second: 41, millisecond: 82, kind: DateTimeKind.Utc), new DateTime(year: 1993, month: 10, day: 15, hour: 3, minute: 3, second: 54, millisecond: 411, kind: DateTimeKind.Utc), }, { new DateTime(year: 1949, month: 10, day: 7, hour: 6, minute: 25, second: 30, millisecond: 6, kind: DateTimeKind.Utc), new DateTime(year: 1962, month: 10, day: 12, hour: 6, minute: 11, second: 23, millisecond: 25, kind: DateTimeKind.Utc), new DateTime(year: 1966, month: 10, day: 10, hour: 7, minute: 20, second: 19, millisecond: 156, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1982, month: 10, day: 3, hour: 9, minute: 7, second: 4, millisecond: 505, kind: DateTimeKind.Utc), new DateTime(year: 1942, month: 10, day: 14, hour: 16, minute: 19, second: 20, millisecond: 678, kind: DateTimeKind.Utc), new DateTime(year: 1982, month: 10, day: 17, hour: 10, minute: 19, second: 44, millisecond: 572, kind: DateTimeKind.Utc), }, { new DateTime(year: 1998, month: 10, day: 16, hour: 20, minute: 19, second: 19, millisecond: 328, kind: DateTimeKind.Utc), new DateTime(year: 1980, month: 10, day: 19, hour: 1, minute: 10, second: 2, millisecond: 67, kind: DateTimeKind.Utc), new DateTime(year: 1969, month: 10, day: 9, hour: 8, minute: 26, second: 11, millisecond: 482, kind: DateTimeKind.Utc), }, { new DateTime(year: 1951, month: 10, day: 1, hour: 21, minute: 24, second: 36, millisecond: 221, kind: DateTimeKind.Utc), new DateTime(year: 1985, month: 10, day: 5, hour: 6, minute: 48, second: 20, millisecond: 56, kind: DateTimeKind.Utc), new DateTime(year: 1928, month: 10, day: 7, hour: 22, minute: 37, second: 13, millisecond: 359, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1946, month: 10, day: 17, hour: 4, minute: 38, second: 23, millisecond: 492, kind: DateTimeKind.Utc), new DateTime(year: 1928, month: 10, day: 14, hour: 14, minute: 56, second: 23, millisecond: 144, kind: DateTimeKind.Utc), new DateTime(year: 1972, month: 10, day: 6, hour: 16, minute: 48, second: 26, millisecond: 11, kind: DateTimeKind.Utc), }, { new DateTime(year: 1997, month: 10, day: 15, hour: 19, minute: 37, second: 18, millisecond: 286, kind: DateTimeKind.Utc), new DateTime(year: 1996, month: 10, day: 6, hour: 5, minute: 30, second: 52, millisecond: 932, kind: DateTimeKind.Utc), new DateTime(year: 1952, month: 10, day: 1, hour: 19, minute: 17, second: 29, millisecond: 471, kind: DateTimeKind.Utc), }, { new DateTime(year: 1962, month: 10, day: 7, hour: 18, minute: 44, second: 43, millisecond: 89, kind: DateTimeKind.Utc), new DateTime(year: 1924, month: 10, day: 1, hour: 9, minute: 36, second: 11, millisecond: 828, kind: DateTimeKind.Utc), new DateTime(year: 1939, month: 10, day: 11, hour: 5, minute: 34, second: 28, millisecond: 147, kind: DateTimeKind.Utc), }, }, }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_with_time_zonemmarrayd3e1m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_with_time_zonemmarrayd3e1mi_id
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
    datetimetimestamp_with_time_zonemmarrayd3e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483622)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[,,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483622)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "datetimetimestamp_with_time_zonemmarrayd3e1mi_id", 
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
                System.DateTime[,,] nullable = null;
                nullable =  ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.DateTime[,,] { { { new DateTime(year: 1967, month: 10, day: 17, hour: 10, minute: 7, second: 40, millisecond: 912, kind: DateTimeKind.Utc), new DateTime(year: 1978, month: 10, day: 19, hour: 13, minute: 19, second: 48, millisecond: 128, kind: DateTimeKind.Utc), new DateTime(year: 1960, month: 10, day: 16, hour: 3, minute: 50, second: 54, millisecond: 504, kind: DateTimeKind.Utc), }, { new DateTime(year: 1930, month: 10, day: 11, hour: 1, minute: 40, second: 29, millisecond: 323, kind: DateTimeKind.Utc), new DateTime(year: 1951, month: 10, day: 19, hour: 22, minute: 40, second: 2, millisecond: 308, kind: DateTimeKind.Utc), new DateTime(year: 1936, month: 10, day: 8, hour: 9, minute: 24, second: 36, millisecond: 703, kind: DateTimeKind.Utc), }, { new DateTime(year: 1992, month: 10, day: 12, hour: 10, minute: 33, second: 8, millisecond: 355, kind: DateTimeKind.Utc), new DateTime(year: 1944, month: 10, day: 4, hour: 8, minute: 46, second: 11, millisecond: 190, kind: DateTimeKind.Utc), new DateTime(year: 2004, month: 10, day: 18, hour: 9, minute: 38, second: 26, millisecond: 153, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1951, month: 10, day: 4, hour: 19, minute: 26, second: 30, millisecond: 726, kind: DateTimeKind.Utc), new DateTime(year: 2012, month: 10, day: 6, hour: 16, minute: 15, second: 49, millisecond: 14, kind: DateTimeKind.Utc), new DateTime(year: 1940, month: 10, day: 18, hour: 12, minute: 11, second: 22, millisecond: 812, kind: DateTimeKind.Utc), }, { new DateTime(year: 1994, month: 10, day: 10, hour: 19, minute: 3, second: 6, millisecond: 644, kind: DateTimeKind.Utc), new DateTime(year: 1939, month: 10, day: 15, hour: 14, minute: 11, second: 31, millisecond: 704, kind: DateTimeKind.Utc), new DateTime(year: 2017, month: 10, day: 4, hour: 4, minute: 58, second: 29, millisecond: 211, kind: DateTimeKind.Utc), }, { new DateTime(year: 1955, month: 10, day: 14, hour: 8, minute: 40, second: 1, millisecond: 986, kind: DateTimeKind.Utc), new DateTime(year: 1944, month: 10, day: 9, hour: 9, minute: 53, second: 11, millisecond: 448, kind: DateTimeKind.Utc), new DateTime(year: 1979, month: 10, day: 14, hour: 3, minute: 35, second: 6, millisecond: 884, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1998, month: 10, day: 16, hour: 21, minute: 38, second: 3, millisecond: 446, kind: DateTimeKind.Utc), new DateTime(year: 1942, month: 10, day: 19, hour: 2, minute: 5, second: 5, millisecond: 201, kind: DateTimeKind.Utc), new DateTime(year: 1944, month: 10, day: 18, hour: 13, minute: 50, second: 14, millisecond: 728, kind: DateTimeKind.Utc), }, { new DateTime(year: 1928, month: 10, day: 15, hour: 3, minute: 37, second: 39, millisecond: 815, kind: DateTimeKind.Utc), new DateTime(year: 1980, month: 10, day: 2, hour: 16, minute: 54, second: 53, millisecond: 164, kind: DateTimeKind.Utc), new DateTime(year: 1953, month: 10, day: 14, hour: 4, minute: 31, second: 49, millisecond: 492, kind: DateTimeKind.Utc), }, { new DateTime(year: 1968, month: 10, day: 3, hour: 6, minute: 47, second: 2, millisecond: 481, kind: DateTimeKind.Utc), new DateTime(year: 1981, month: 10, day: 17, hour: 17, minute: 43, second: 32, millisecond: 842, kind: DateTimeKind.Utc), new DateTime(year: 1970, month: 10, day: 8, hour: 11, minute: 37, second: 54, millisecond: 211, kind: DateTimeKind.Utc), }, }, }));
                nullable =  ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.DateTime[,,] { { { new DateTime(year: 1971, month: 10, day: 4, hour: 1, minute: 58, second: 17, millisecond: 647, kind: DateTimeKind.Utc), new DateTime(year: 1964, month: 10, day: 17, hour: 1, minute: 30, second: 30, millisecond: 786, kind: DateTimeKind.Utc), new DateTime(year: 1958, month: 10, day: 4, hour: 5, minute: 25, second: 10, millisecond: 871, kind: DateTimeKind.Utc), }, { new DateTime(year: 1922, month: 10, day: 13, hour: 12, minute: 8, second: 13, millisecond: 987, kind: DateTimeKind.Utc), new DateTime(year: 1921, month: 10, day: 17, hour: 1, minute: 43, second: 25, millisecond: 564, kind: DateTimeKind.Utc), new DateTime(year: 2017, month: 10, day: 15, hour: 17, minute: 15, second: 41, millisecond: 870, kind: DateTimeKind.Utc), }, { new DateTime(year: 1990, month: 10, day: 6, hour: 2, minute: 23, second: 32, millisecond: 697, kind: DateTimeKind.Utc), new DateTime(year: 1927, month: 10, day: 11, hour: 9, minute: 28, second: 24, millisecond: 13, kind: DateTimeKind.Utc), new DateTime(year: 1919, month: 10, day: 1, hour: 19, minute: 25, second: 28, millisecond: 270, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1980, month: 10, day: 14, hour: 17, minute: 5, second: 43, millisecond: 459, kind: DateTimeKind.Utc), new DateTime(year: 1958, month: 10, day: 15, hour: 18, minute: 27, second: 37, millisecond: 627, kind: DateTimeKind.Utc), new DateTime(year: 2016, month: 10, day: 19, hour: 6, minute: 43, second: 39, millisecond: 880, kind: DateTimeKind.Utc), }, { new DateTime(year: 1927, month: 10, day: 18, hour: 16, minute: 47, second: 16, millisecond: 330, kind: DateTimeKind.Utc), new DateTime(year: 1976, month: 10, day: 13, hour: 19, minute: 30, second: 48, millisecond: 915, kind: DateTimeKind.Utc), new DateTime(year: 1980, month: 10, day: 5, hour: 3, minute: 1, second: 17, millisecond: 651, kind: DateTimeKind.Utc), }, { new DateTime(year: 1986, month: 10, day: 16, hour: 13, minute: 3, second: 52, millisecond: 745, kind: DateTimeKind.Utc), new DateTime(year: 1955, month: 10, day: 13, hour: 15, minute: 21, second: 15, millisecond: 696, kind: DateTimeKind.Utc), new DateTime(year: 1980, month: 10, day: 7, hour: 12, minute: 58, second: 58, millisecond: 692, kind: DateTimeKind.Utc), }, }, { { new DateTime(year: 1992, month: 10, day: 6, hour: 10, minute: 38, second: 44, millisecond: 560, kind: DateTimeKind.Utc), new DateTime(year: 1942, month: 10, day: 10, hour: 4, minute: 27, second: 56, millisecond: 794, kind: DateTimeKind.Utc), new DateTime(year: 1972, month: 10, day: 19, hour: 6, minute: 13, second: 48, millisecond: 237, kind: DateTimeKind.Utc), }, { new DateTime(year: 1947, month: 10, day: 10, hour: 15, minute: 26, second: 42, millisecond: 199, kind: DateTimeKind.Utc), new DateTime(year: 2006, month: 10, day: 11, hour: 2, minute: 35, second: 38, millisecond: 872, kind: DateTimeKind.Utc), new DateTime(year: 1938, month: 10, day: 8, hour: 4, minute: 20, second: 12, millisecond: 142, kind: DateTimeKind.Utc), }, { new DateTime(year: 1928, month: 10, day: 19, hour: 8, minute: 45, second: 9, millisecond: 968, kind: DateTimeKind.Utc), new DateTime(year: 1982, month: 10, day: 18, hour: 20, minute: 27, second: 48, millisecond: 259, kind: DateTimeKind.Utc), new DateTime(year: 2010, month: 10, day: 16, hour: 3, minute: 54, second: 29, millisecond: 521, kind: DateTimeKind.Utc), }, }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.DateTime[,,] nullable = null;
                nullable = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DateTimetimestamp_with_time_zoneMMArrayD3E1M> models = null;

                models =  ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DateTimetimestamp_with_time_zoneMMArrayD3E1M> models = null;

                models = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M), typeof(FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)),
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                var models2 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                var models2 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)),
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
LEFT JOIN public.datetimetimestamp_with_time_zonemmarrayd3e1mi mi ON mi.id = m.datetimetimestamp_with_time_zonemmarrayd3e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)),
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
                var models = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M), typeof(FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)),
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                var models2 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                var models2 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)),
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
LEFT JOIN public.datetimetimestamp_with_time_zonemmarrayd3e1mi mi ON mi.id = m.datetimetimestamp_with_time_zonemmarrayd3e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)),
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
                var models = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M), typeof(FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)),
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
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)),
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                var models2 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                await((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[15],_testData[34], false);
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                var models2 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                 ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                 ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[13],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)),
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
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)),
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 171;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[10],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[11],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[3], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[4], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[5], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[10],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[11],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[12],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[13],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[14],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[15],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[16],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[17],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[18],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[19],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[20],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[21],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[22],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[23],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[24],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[25],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[26],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[27],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[28],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[29],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[30],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[10],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[11],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[12],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[13],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[14],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[15],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[16],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[17],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[18],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[19],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[20],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[21],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[22],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[23],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                 ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
LEFT JOIN public.datetimetimestamp_with_time_zonemmarrayd3e1mi mi ON mi.id = m.datetimetimestamp_with_time_zonemmarrayd3e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)),
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
                var models = await((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[13], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[14], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[15], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[16], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[17], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[18], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[19], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[20], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[21], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[22], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[10],_testData[23], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[11],_testData[24], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[12],_testData[25], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[13],_testData[26], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[14],_testData[27], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[15],_testData[28], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[16],_testData[29], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[17],_testData[30], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[18],_testData[31], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[19],_testData[32], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[20],_testData[33], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[1], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[2], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[3], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[4], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[5], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[6], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[7], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[8], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[9], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[10], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[10],_testData[11], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[11],_testData[12], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[12],_testData[13], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[13],_testData[14], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[14],_testData[15], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[15],_testData[16], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[16],_testData[17], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[17],_testData[18], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[18],_testData[19], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[19],_testData[20], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[20],_testData[21], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[21],_testData[22], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[22],_testData[23], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[23],_testData[24], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[24],_testData[25], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[25],_testData[26], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[26],_testData[27], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[27],_testData[28], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[28],_testData[29], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[29],_testData[30], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[30],_testData[31], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[31],_testData[32], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[32],_testData[33], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[33],_testData[34], false);
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
                var models = ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[22], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[23], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[24], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[25], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[26], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[27], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[28], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[29], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[30], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[31], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[10],_testData[32], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[11],_testData[33], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[12], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[13], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[14], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[15], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[16], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[17], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[18], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[19], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[20], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[21], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[10],_testData[22], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[11],_testData[23], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[12],_testData[24], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[13],_testData[25], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[14],_testData[26], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[15],_testData[27], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[16],_testData[28], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[17],_testData[29], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[18],_testData[30], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[19],_testData[31], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[20],_testData[32], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[21],_testData[33], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M), typeof(FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)),
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
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)),
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
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)),
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                var models2 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                await((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 153, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 42, query1, 79, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[17],_testData[34], false);
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                var models2 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                 ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 100, query1, 165, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                 ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DbConnectionMMDynQuerySelectModelBatch(connection, 50, query1, 79, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[17],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)),
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
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)),
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
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)),
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 87, query1, 50, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[10],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[11],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[12],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[13],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[14],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[10],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[11],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[12],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[13],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[14],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[15],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[16],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[17],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[18],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[19],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[20],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[21],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[22],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[23],_testData[34], false);
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 65, query1, 130, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DbConnectionSTDynQuerySelectModelBatch(connection, 61, query1, 24, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[10],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[11],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[12],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[13],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[14],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[15],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[16],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[17],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[18],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[19],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[20],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[10],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[11],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[12],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[13],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[14],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[15],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[16],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[17],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[18],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[19],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[20],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[21],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[22],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[23],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[24],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[25],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[26],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[27],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[28],_testData[34], false);
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                 ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DbConnectionDynQuerySelectModelBatch(connection, 165, query1, 61, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatDateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.datetimetimestamp_with_time_zonemmarrayd3e1m m
LEFT JOIN public.datetimetimestamp_with_time_zonemmarrayd3e1mi mi ON mi.id = m.datetimetimestamp_with_time_zonemmarrayd3e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)),
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
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)),
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
                var models = await((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DbConnectionSTSelectModelBatchAsync(connection, 24, 138))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[6], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[7], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[8], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[9], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[10], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[11], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[12], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[13], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[14], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[15], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[10],_testData[16], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[11],_testData[17], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[12],_testData[18], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[13],_testData[19], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[14],_testData[20], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[15],_testData[21], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[16],_testData[22], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[17],_testData[23], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[18],_testData[24], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[19],_testData[25], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[20],_testData[26], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[21],_testData[27], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[22],_testData[28], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[23],_testData[29], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[24],_testData[30], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[25],_testData[31], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[26],_testData[32], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[27],_testData[33], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[27], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[28], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[29], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[30], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[31], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[32], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[33], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[34], false);
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
                var models = ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DbConnectionSTSelectModelBatch(connection, 80, 64))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[18], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[19], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[20], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[21], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[22], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[23], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[24], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[25], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[26], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[27], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[10],_testData[28], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[11],_testData[29], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[12],_testData[30], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[13],_testData[31], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[14],_testData[32], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[15],_testData[33], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[14], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[15], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[16], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[17], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[18], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[19], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[20], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[21], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[22], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[23], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[10],_testData[24], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[11],_testData[25], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[12],_testData[26], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[13],_testData[27], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[14],_testData[28], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[15],_testData[29], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[16],_testData[30], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[17],_testData[31], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[18],_testData[32], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[19],_testData[33], false);
                        DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[20],_testData[34], false);
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
                await using var cmd = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).SetDbConnectionSelectModelParametrs(cmd, 53);
                var models = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[12], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[13], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[14], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[15], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[16], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[17], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[18], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[19], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[20], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[21], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[10],_testData[22], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[11],_testData[23], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[12],_testData[24], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[13],_testData[25], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[14],_testData[26], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[15],_testData[27], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[16],_testData[28], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[17],_testData[29], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[18],_testData[30], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[19],_testData[31], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[20],_testData[32], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[21],_testData[33], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).SetDbConnectionSelectModelParametrs(cmd, 16);
                var models =  ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(30));

                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[5], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[6], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[7], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[8], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[9], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[10], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[11], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[12], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[13], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[14], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[10],_testData[15], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[11],_testData[16], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[12],_testData[17], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[13],_testData[18], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[14],_testData[19], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[15],_testData[20], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[16],_testData[21], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[17],_testData[22], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[18],_testData[23], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[19],_testData[24], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[20],_testData[25], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[21],_testData[26], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[22],_testData[27], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[23],_testData[28], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[24],_testData[29], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[25],_testData[30], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[26],_testData[31], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[27],_testData[32], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[28],_testData[33], false);
                DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(models[29],_testData[34], false);
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
FROM public.binary_datetimetimestamp_with_time_zonemmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA),
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
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_datetimetimestamp_with_time_zonemmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_datetimetimestamp_with_time_zonemmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_datetimetimestamp_with_time_zonemmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_datetimetimestamp_with_time_zonemmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_datetimetimestamp_with_time_zonemmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_datetimetimestamp_with_time_zonemmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_datetimetimestamp_with_time_zonemmarrayd3e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(DateTimetimestamp_with_time_zoneMMArrayD3E1MI),
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
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateTimetimestamp_with_time_zoneMMArrayD3E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneMMArrayD3E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<DateTimetimestamp_with_time_zoneMMArrayD3E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).WAImportModelInner(connection, importCollection);
                var models = ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneMMArrayD3E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_datetimetimestamp_with_time_zonemmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_datetimetimestamp_with_time_zonemmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).ImportModelInner(connection, importCollection);
                var models = ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_datetimetimestamp_with_time_zonemmarrayd3e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
datetimetimestamp_with_time_zonemmarrayd3e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DateTimetimestamp_with_time_zoneMMArrayD3E1M),
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
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3))]
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
FROM public.binary_datetimetimestamp_with_time_zonemmarrayd3e1m m
LEFT JOIN public.binary_datetimetimestamp_with_time_zonemmarrayd3e1mi mi ON mi.id = m.datetimetimestamp_with_time_zonemmarrayd3e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<DateTimetimestamp_with_time_zoneMMArrayD3E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).ImportModel(connection, importCollection);
                var models = ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_datetimetimestamp_with_time_zonemmarrayd3e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    datetimetimestamp_with_time_zonemmarrayd3e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483622),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483622)
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
                var models =  ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DateTimetimestamp_with_time_zoneMMArrayD3E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA), typeof(DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)),
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
                var models1 = new List<DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA>();
                var models2 = new List<DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA>();
                await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_datetimetimestamp_with_time_zonemmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA>();
                var models2 = new List<DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA>();
                ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_datetimetimestamp_with_time_zonemmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)),
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
                var models = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_datetimetimestamp_with_time_zonemmarrayd3e1mi
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
                    DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_datetimetimestamp_with_time_zonemmarrayd3e1mi
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
                    DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA), typeof(DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3))]
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
                var models1 = new List<DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA>();
                var models2 = new List<DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA>();
                await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_datetimetimestamp_with_time_zonemmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA>();
                var models2 = new List<DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA>();
                ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_datetimetimestamp_with_time_zonemmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3))]
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
                var models = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_datetimetimestamp_with_time_zonemmarrayd3e1mi
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
                    DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).DynQueryExportModelInner(connection, @"
COPY public.binary_datetimetimestamp_with_time_zonemmarrayd3e1mi
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
                    DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_datetimetimestamp_with_time_zonemmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneMMArrayD3E1MI), typeof(DateTimetimestamp_with_time_zoneMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)),
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
                var models1 = new List<DateTimetimestamp_with_time_zoneMMArrayD3E1MI>();
                var models2 = new List<DateTimetimestamp_with_time_zoneMMArrayD3E1MI>();
                await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneMMArrayD3E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneMMArrayD3E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DateTimetimestamp_with_time_zoneMMArrayD3E1MI>();
                var models2 = new List<DateTimetimestamp_with_time_zoneMMArrayD3E1MI>();
                ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneMMArrayD3E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneMMArrayD3E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_datetimetimestamp_with_time_zonemmarrayd3e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)),
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
                var models = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneMMArrayD3E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneMMArrayD3E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_datetimetimestamp_with_time_zonemmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA), typeof(DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3))]
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
                var models1 = new List<DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA>();
                var models2 = new List<DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA>();
                await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA>();
                var models2 = new List<DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA>();
                ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_datetimetimestamp_with_time_zonemmarrayd3e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_with_time_zoneMMArrayD3))]
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
                var models = await ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDateTimeMArraytimestamp_with_time_zoneMMArrayD3)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_with_time_zoneMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

