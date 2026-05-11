

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
    internal partial interface IDateTimeMArraytimestamp_without_time_zoneMMArrayD3
    {
    }
    
    internal partial class DateTimeMArraytimestamp_without_time_zoneMMArrayD3 : IDateTimeMArraytimestamp_without_time_zoneMMArrayD3
    {


#region TestData

        private readonly DateTimetimestamp_without_time_zoneMMArrayD3E1M[] _testData = new DateTimetimestamp_without_time_zoneMMArrayD3E1M[]
        {
            new DateTimetimestamp_without_time_zoneMMArrayD3E1M
{
    Id = 5,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1969, month: 10, day: 9, hour: 12, minute: 32, second: 36, millisecond: 526, kind: DateTimeKind.Local), new DateTime(year: 1965, month: 10, day: 10, hour: 18, minute: 5, second: 11, millisecond: 327, kind: DateTimeKind.Local), new DateTime(year: 1931, month: 10, day: 3, hour: 16, minute: 19, second: 25, millisecond: 584, kind: DateTimeKind.Local), }, { new DateTime(year: 1980, month: 10, day: 10, hour: 19, minute: 50, second: 25, millisecond: 418, kind: DateTimeKind.Local), new DateTime(year: 1947, month: 10, day: 9, hour: 9, minute: 42, second: 21, millisecond: 109, kind: DateTimeKind.Local), new DateTime(year: 1947, month: 10, day: 5, hour: 8, minute: 53, second: 42, millisecond: 594, kind: DateTimeKind.Local), }, { new DateTime(year: 2019, month: 10, day: 14, hour: 8, minute: 42, second: 40, millisecond: 954, kind: DateTimeKind.Local), new DateTime(year: 2006, month: 10, day: 6, hour: 5, minute: 53, second: 38, millisecond: 926, kind: DateTimeKind.Local), new DateTime(year: 2010, month: 10, day: 17, hour: 16, minute: 38, second: 29, millisecond: 614, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1921, month: 10, day: 11, hour: 19, minute: 25, second: 17, millisecond: 823, kind: DateTimeKind.Local), new DateTime(year: 1928, month: 10, day: 10, hour: 4, minute: 50, second: 24, millisecond: 669, kind: DateTimeKind.Local), new DateTime(year: 2004, month: 10, day: 12, hour: 7, minute: 21, second: 25, millisecond: 178, kind: DateTimeKind.Local), }, { new DateTime(year: 1970, month: 10, day: 16, hour: 5, minute: 4, second: 24, millisecond: 67, kind: DateTimeKind.Local), new DateTime(year: 1923, month: 10, day: 11, hour: 14, minute: 37, second: 44, millisecond: 30, kind: DateTimeKind.Local), new DateTime(year: 2008, month: 10, day: 8, hour: 9, minute: 47, second: 19, millisecond: 712, kind: DateTimeKind.Local), }, { new DateTime(year: 1932, month: 10, day: 5, hour: 3, minute: 36, second: 10, millisecond: 209, kind: DateTimeKind.Local), new DateTime(year: 1941, month: 10, day: 4, hour: 13, minute: 40, second: 11, millisecond: 974, kind: DateTimeKind.Local), new DateTime(year: 2018, month: 10, day: 12, hour: 9, minute: 30, second: 31, millisecond: 838, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1948, month: 10, day: 16, hour: 13, minute: 49, second: 57, millisecond: 573, kind: DateTimeKind.Local), new DateTime(year: 1999, month: 10, day: 8, hour: 13, minute: 48, second: 9, millisecond: 359, kind: DateTimeKind.Local), new DateTime(year: 1971, month: 10, day: 13, hour: 10, minute: 6, second: 40, millisecond: 242, kind: DateTimeKind.Local), }, { new DateTime(year: 2007, month: 10, day: 6, hour: 5, minute: 50, second: 37, millisecond: 466, kind: DateTimeKind.Local), new DateTime(year: 1995, month: 10, day: 4, hour: 10, minute: 28, second: 35, millisecond: 734, kind: DateTimeKind.Local), new DateTime(year: 1936, month: 10, day: 15, hour: 13, minute: 21, second: 12, millisecond: 486, kind: DateTimeKind.Local), }, { new DateTime(year: 1950, month: 10, day: 17, hour: 11, minute: 13, second: 11, millisecond: 933, kind: DateTimeKind.Local), new DateTime(year: 1990, month: 10, day: 4, hour: 14, minute: 3, second: 35, millisecond: 108, kind: DateTimeKind.Local), new DateTime(year: 1959, month: 10, day: 5, hour: 7, minute: 7, second: 5, millisecond: 901, kind: DateTimeKind.Local), }, }, },
    ModelInner = null,
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1973, month: 10, day: 14, hour: 16, minute: 1, second: 5, millisecond: 478, kind: DateTimeKind.Local), new DateTime(year: 1988, month: 10, day: 18, hour: 10, minute: 35, second: 26, millisecond: 134, kind: DateTimeKind.Local), new DateTime(year: 1961, month: 10, day: 13, hour: 19, minute: 24, second: 37, millisecond: 676, kind: DateTimeKind.Local), }, { new DateTime(year: 1953, month: 10, day: 12, hour: 6, minute: 18, second: 46, millisecond: 199, kind: DateTimeKind.Local), new DateTime(year: 1999, month: 10, day: 18, hour: 1, minute: 23, second: 19, millisecond: 596, kind: DateTimeKind.Local), new DateTime(year: 2003, month: 10, day: 6, hour: 9, minute: 40, second: 44, millisecond: 86, kind: DateTimeKind.Local), }, { new DateTime(year: 1948, month: 10, day: 19, hour: 6, minute: 55, second: 22, millisecond: 735, kind: DateTimeKind.Local), new DateTime(year: 1971, month: 10, day: 15, hour: 16, minute: 51, second: 37, millisecond: 980, kind: DateTimeKind.Local), new DateTime(year: 1984, month: 10, day: 2, hour: 22, minute: 22, second: 24, millisecond: 636, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1943, month: 10, day: 19, hour: 4, minute: 45, second: 14, millisecond: 681, kind: DateTimeKind.Local), new DateTime(year: 1930, month: 10, day: 17, hour: 5, minute: 7, second: 51, millisecond: 653, kind: DateTimeKind.Local), new DateTime(year: 1991, month: 10, day: 12, hour: 17, minute: 4, second: 44, millisecond: 434, kind: DateTimeKind.Local), }, { new DateTime(year: 1961, month: 10, day: 10, hour: 5, minute: 46, second: 17, millisecond: 937, kind: DateTimeKind.Local), new DateTime(year: 1982, month: 10, day: 1, hour: 2, minute: 16, second: 46, millisecond: 992, kind: DateTimeKind.Local), new DateTime(year: 1987, month: 10, day: 3, hour: 18, minute: 6, second: 45, millisecond: 532, kind: DateTimeKind.Local), }, { new DateTime(year: 1994, month: 10, day: 17, hour: 17, minute: 38, second: 55, millisecond: 817, kind: DateTimeKind.Local), new DateTime(year: 1995, month: 10, day: 14, hour: 3, minute: 35, second: 42, millisecond: 449, kind: DateTimeKind.Local), new DateTime(year: 1919, month: 10, day: 3, hour: 13, minute: 40, second: 19, millisecond: 315, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1944, month: 10, day: 19, hour: 8, minute: 36, second: 35, millisecond: 785, kind: DateTimeKind.Local), new DateTime(year: 2015, month: 10, day: 2, hour: 16, minute: 58, second: 44, millisecond: 918, kind: DateTimeKind.Local), new DateTime(year: 1935, month: 10, day: 13, hour: 3, minute: 25, second: 24, millisecond: 41, kind: DateTimeKind.Local), }, { new DateTime(year: 1961, month: 10, day: 17, hour: 6, minute: 35, second: 21, millisecond: 287, kind: DateTimeKind.Local), new DateTime(year: 1944, month: 10, day: 5, hour: 7, minute: 55, second: 17, millisecond: 249, kind: DateTimeKind.Local), new DateTime(year: 1992, month: 10, day: 5, hour: 19, minute: 33, second: 38, millisecond: 729, kind: DateTimeKind.Local), }, { new DateTime(year: 2003, month: 10, day: 16, hour: 1, minute: 31, second: 9, millisecond: 808, kind: DateTimeKind.Local), new DateTime(year: 1963, month: 10, day: 1, hour: 11, minute: 39, second: 24, millisecond: 391, kind: DateTimeKind.Local), new DateTime(year: 2017, month: 10, day: 3, hour: 6, minute: 5, second: 22, millisecond: 23, kind: DateTimeKind.Local), }, }, },
},
            new DateTimetimestamp_without_time_zoneMMArrayD3E1M
{
    Id = 13,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 2011, month: 10, day: 18, hour: 4, minute: 54, second: 32, millisecond: 426, kind: DateTimeKind.Local), new DateTime(year: 2015, month: 10, day: 10, hour: 6, minute: 6, second: 28, millisecond: 706, kind: DateTimeKind.Local), new DateTime(year: 1935, month: 10, day: 8, hour: 2, minute: 27, second: 28, millisecond: 319, kind: DateTimeKind.Local), }, { new DateTime(year: 1917, month: 10, day: 6, hour: 17, minute: 14, second: 52, millisecond: 367, kind: DateTimeKind.Local), new DateTime(year: 1986, month: 10, day: 1, hour: 9, minute: 19, second: 34, millisecond: 814, kind: DateTimeKind.Local), new DateTime(year: 1956, month: 10, day: 7, hour: 12, minute: 42, second: 9, millisecond: 169, kind: DateTimeKind.Local), }, { new DateTime(year: 2000, month: 10, day: 12, hour: 5, minute: 7, second: 2, millisecond: 374, kind: DateTimeKind.Local), new DateTime(year: 1965, month: 10, day: 14, hour: 10, minute: 32, second: 14, millisecond: 653, kind: DateTimeKind.Local), new DateTime(year: 1944, month: 10, day: 7, hour: 14, minute: 32, second: 4, millisecond: 867, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 2016, month: 10, day: 14, hour: 11, minute: 22, second: 25, millisecond: 428, kind: DateTimeKind.Local), new DateTime(year: 1978, month: 10, day: 13, hour: 15, minute: 14, second: 55, millisecond: 894, kind: DateTimeKind.Local), new DateTime(year: 2017, month: 10, day: 3, hour: 19, minute: 9, second: 9, millisecond: 432, kind: DateTimeKind.Local), }, { new DateTime(year: 1993, month: 10, day: 16, hour: 4, minute: 27, second: 45, millisecond: 514, kind: DateTimeKind.Local), new DateTime(year: 1973, month: 10, day: 14, hour: 15, minute: 33, second: 27, millisecond: 706, kind: DateTimeKind.Local), new DateTime(year: 1928, month: 10, day: 2, hour: 20, minute: 2, second: 11, millisecond: 2, kind: DateTimeKind.Local), }, { new DateTime(year: 1956, month: 10, day: 14, hour: 22, minute: 30, second: 40, millisecond: 58, kind: DateTimeKind.Local), new DateTime(year: 1980, month: 10, day: 19, hour: 13, minute: 29, second: 50, millisecond: 653, kind: DateTimeKind.Local), new DateTime(year: 1948, month: 10, day: 5, hour: 3, minute: 31, second: 15, millisecond: 562, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1984, month: 10, day: 10, hour: 3, minute: 29, second: 54, millisecond: 1, kind: DateTimeKind.Local), new DateTime(year: 1941, month: 10, day: 8, hour: 5, minute: 43, second: 6, millisecond: 609, kind: DateTimeKind.Local), new DateTime(year: 2003, month: 10, day: 1, hour: 14, minute: 36, second: 7, millisecond: 938, kind: DateTimeKind.Local), }, { new DateTime(year: 1919, month: 10, day: 17, hour: 12, minute: 14, second: 35, millisecond: 835, kind: DateTimeKind.Local), new DateTime(year: 2015, month: 10, day: 2, hour: 3, minute: 18, second: 12, millisecond: 329, kind: DateTimeKind.Local), new DateTime(year: 1938, month: 10, day: 16, hour: 11, minute: 18, second: 32, millisecond: 380, kind: DateTimeKind.Local), }, { new DateTime(year: 1920, month: 10, day: 10, hour: 19, minute: 6, second: 31, millisecond: 849, kind: DateTimeKind.Local), new DateTime(year: 1932, month: 10, day: 4, hour: 3, minute: 49, second: 1, millisecond: 351, kind: DateTimeKind.Local), new DateTime(year: 1942, month: 10, day: 1, hour: 13, minute: 30, second: 52, millisecond: 682, kind: DateTimeKind.Local), }, }, },
    ModelInner = new DateTimetimestamp_without_time_zoneMMArrayD3E1MI
{
    Id = 2,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1969, month: 10, day: 3, hour: 21, minute: 6, second: 26, millisecond: 350, kind: DateTimeKind.Local), new DateTime(year: 1957, month: 10, day: 6, hour: 16, minute: 37, second: 6, millisecond: 408, kind: DateTimeKind.Local), new DateTime(year: 2004, month: 10, day: 7, hour: 13, minute: 43, second: 4, millisecond: 324, kind: DateTimeKind.Local), }, { new DateTime(year: 1950, month: 10, day: 13, hour: 12, minute: 13, second: 23, millisecond: 321, kind: DateTimeKind.Local), new DateTime(year: 2016, month: 10, day: 2, hour: 2, minute: 29, second: 16, millisecond: 869, kind: DateTimeKind.Local), new DateTime(year: 1957, month: 10, day: 12, hour: 14, minute: 6, second: 29, millisecond: 284, kind: DateTimeKind.Local), }, { new DateTime(year: 1967, month: 10, day: 14, hour: 14, minute: 1, second: 34, millisecond: 470, kind: DateTimeKind.Local), new DateTime(year: 1975, month: 10, day: 11, hour: 19, minute: 46, second: 55, millisecond: 203, kind: DateTimeKind.Local), new DateTime(year: 1932, month: 10, day: 1, hour: 5, minute: 17, second: 33, millisecond: 803, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1976, month: 10, day: 9, hour: 10, minute: 38, second: 19, millisecond: 334, kind: DateTimeKind.Local), new DateTime(year: 1932, month: 10, day: 2, hour: 17, minute: 31, second: 5, millisecond: 955, kind: DateTimeKind.Local), new DateTime(year: 1991, month: 10, day: 17, hour: 10, minute: 38, second: 2, millisecond: 187, kind: DateTimeKind.Local), }, { new DateTime(year: 1986, month: 10, day: 5, hour: 6, minute: 37, second: 49, millisecond: 291, kind: DateTimeKind.Local), new DateTime(year: 1929, month: 10, day: 7, hour: 22, minute: 42, second: 47, millisecond: 173, kind: DateTimeKind.Local), new DateTime(year: 1967, month: 10, day: 18, hour: 2, minute: 15, second: 51, millisecond: 606, kind: DateTimeKind.Local), }, { new DateTime(year: 2019, month: 10, day: 17, hour: 5, minute: 48, second: 14, millisecond: 622, kind: DateTimeKind.Local), new DateTime(year: 1945, month: 10, day: 1, hour: 3, minute: 9, second: 38, millisecond: 798, kind: DateTimeKind.Local), new DateTime(year: 2000, month: 10, day: 16, hour: 18, minute: 41, second: 22, millisecond: 423, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1984, month: 10, day: 18, hour: 22, minute: 55, second: 20, millisecond: 67, kind: DateTimeKind.Local), new DateTime(year: 2007, month: 10, day: 13, hour: 11, minute: 54, second: 14, millisecond: 346, kind: DateTimeKind.Local), new DateTime(year: 1940, month: 10, day: 4, hour: 2, minute: 5, second: 24, millisecond: 907, kind: DateTimeKind.Local), }, { new DateTime(year: 1980, month: 10, day: 1, hour: 20, minute: 36, second: 51, millisecond: 499, kind: DateTimeKind.Local), new DateTime(year: 1931, month: 10, day: 9, hour: 21, minute: 20, second: 25, millisecond: 287, kind: DateTimeKind.Local), new DateTime(year: 1958, month: 10, day: 5, hour: 8, minute: 17, second: 57, millisecond: 163, kind: DateTimeKind.Local), }, { new DateTime(year: 1966, month: 10, day: 10, hour: 13, minute: 39, second: 35, millisecond: 112, kind: DateTimeKind.Local), new DateTime(year: 1992, month: 10, day: 15, hour: 11, minute: 58, second: 26, millisecond: 271, kind: DateTimeKind.Local), new DateTime(year: 1962, month: 10, day: 10, hour: 15, minute: 54, second: 25, millisecond: 450, kind: DateTimeKind.Local), }, }, },
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1988, month: 10, day: 2, hour: 11, minute: 45, second: 46, millisecond: 422, kind: DateTimeKind.Local), new DateTime(year: 1962, month: 10, day: 3, hour: 15, minute: 13, second: 56, millisecond: 44, kind: DateTimeKind.Local), new DateTime(year: 1956, month: 10, day: 19, hour: 11, minute: 7, second: 25, millisecond: 782, kind: DateTimeKind.Local), }, { new DateTime(year: 2014, month: 10, day: 16, hour: 14, minute: 5, second: 22, millisecond: 561, kind: DateTimeKind.Local), new DateTime(year: 2006, month: 10, day: 4, hour: 6, minute: 31, second: 43, millisecond: 425, kind: DateTimeKind.Local), new DateTime(year: 1928, month: 10, day: 19, hour: 14, minute: 34, second: 26, millisecond: 199, kind: DateTimeKind.Local), }, { new DateTime(year: 1917, month: 10, day: 12, hour: 7, minute: 42, second: 56, millisecond: 12, kind: DateTimeKind.Local), new DateTime(year: 1984, month: 10, day: 10, hour: 17, minute: 17, second: 45, millisecond: 339, kind: DateTimeKind.Local), new DateTime(year: 1996, month: 10, day: 19, hour: 2, minute: 28, second: 38, millisecond: 435, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1972, month: 10, day: 17, hour: 20, minute: 57, second: 48, millisecond: 248, kind: DateTimeKind.Local), new DateTime(year: 1952, month: 10, day: 13, hour: 15, minute: 31, second: 8, millisecond: 416, kind: DateTimeKind.Local), new DateTime(year: 1984, month: 10, day: 6, hour: 20, minute: 47, second: 30, millisecond: 934, kind: DateTimeKind.Local), }, { new DateTime(year: 1972, month: 10, day: 14, hour: 6, minute: 35, second: 41, millisecond: 312, kind: DateTimeKind.Local), new DateTime(year: 1998, month: 10, day: 8, hour: 19, minute: 26, second: 28, millisecond: 361, kind: DateTimeKind.Local), new DateTime(year: 1948, month: 10, day: 19, hour: 14, minute: 18, second: 17, millisecond: 279, kind: DateTimeKind.Local), }, { new DateTime(year: 1952, month: 10, day: 10, hour: 14, minute: 32, second: 46, millisecond: 367, kind: DateTimeKind.Local), new DateTime(year: 1994, month: 10, day: 10, hour: 19, minute: 36, second: 55, millisecond: 815, kind: DateTimeKind.Local), new DateTime(year: 1980, month: 10, day: 17, hour: 19, minute: 25, second: 41, millisecond: 10, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1918, month: 10, day: 8, hour: 1, minute: 56, second: 53, millisecond: 828, kind: DateTimeKind.Local), new DateTime(year: 2004, month: 10, day: 10, hour: 9, minute: 26, second: 41, millisecond: 771, kind: DateTimeKind.Local), new DateTime(year: 1983, month: 10, day: 4, hour: 4, minute: 23, second: 10, millisecond: 299, kind: DateTimeKind.Local), }, { new DateTime(year: 2008, month: 10, day: 6, hour: 11, minute: 45, second: 17, millisecond: 134, kind: DateTimeKind.Local), new DateTime(year: 2003, month: 10, day: 4, hour: 4, minute: 5, second: 31, millisecond: 549, kind: DateTimeKind.Local), new DateTime(year: 1986, month: 10, day: 17, hour: 12, minute: 37, second: 4, millisecond: 638, kind: DateTimeKind.Local), }, { new DateTime(year: 1967, month: 10, day: 12, hour: 17, minute: 13, second: 54, millisecond: 359, kind: DateTimeKind.Local), new DateTime(year: 1931, month: 10, day: 9, hour: 10, minute: 40, second: 26, millisecond: 152, kind: DateTimeKind.Local), new DateTime(year: 1945, month: 10, day: 17, hour: 1, minute: 18, second: 30, millisecond: 507, kind: DateTimeKind.Local), }, }, },
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneMMArrayD3E1M
{
    Id = 18,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1931, month: 10, day: 10, hour: 4, minute: 6, second: 10, millisecond: 210, kind: DateTimeKind.Local), new DateTime(year: 2006, month: 10, day: 11, hour: 16, minute: 41, second: 45, millisecond: 912, kind: DateTimeKind.Local), new DateTime(year: 2017, month: 10, day: 18, hour: 14, minute: 14, second: 13, millisecond: 261, kind: DateTimeKind.Local), }, { new DateTime(year: 1922, month: 10, day: 18, hour: 18, minute: 36, second: 49, millisecond: 996, kind: DateTimeKind.Local), new DateTime(year: 2001, month: 10, day: 11, hour: 20, minute: 44, second: 35, millisecond: 347, kind: DateTimeKind.Local), new DateTime(year: 1979, month: 10, day: 19, hour: 5, minute: 11, second: 41, millisecond: 130, kind: DateTimeKind.Local), }, { new DateTime(year: 1992, month: 10, day: 7, hour: 3, minute: 56, second: 12, millisecond: 284, kind: DateTimeKind.Local), new DateTime(year: 1964, month: 10, day: 10, hour: 15, minute: 1, second: 48, millisecond: 154, kind: DateTimeKind.Local), new DateTime(year: 2000, month: 10, day: 8, hour: 14, minute: 29, second: 41, millisecond: 167, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1991, month: 10, day: 6, hour: 9, minute: 30, second: 18, millisecond: 263, kind: DateTimeKind.Local), new DateTime(year: 1970, month: 10, day: 3, hour: 3, minute: 31, second: 36, millisecond: 948, kind: DateTimeKind.Local), new DateTime(year: 1979, month: 10, day: 10, hour: 16, minute: 47, second: 57, millisecond: 935, kind: DateTimeKind.Local), }, { new DateTime(year: 1992, month: 10, day: 12, hour: 13, minute: 44, second: 58, millisecond: 573, kind: DateTimeKind.Local), new DateTime(year: 2006, month: 10, day: 13, hour: 14, minute: 18, second: 37, millisecond: 70, kind: DateTimeKind.Local), new DateTime(year: 2010, month: 10, day: 12, hour: 1, minute: 13, second: 50, millisecond: 463, kind: DateTimeKind.Local), }, { new DateTime(year: 1944, month: 10, day: 1, hour: 13, minute: 23, second: 46, millisecond: 589, kind: DateTimeKind.Local), new DateTime(year: 1932, month: 10, day: 3, hour: 15, minute: 55, second: 15, millisecond: 767, kind: DateTimeKind.Local), new DateTime(year: 1950, month: 10, day: 7, hour: 7, minute: 31, second: 16, millisecond: 578, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1923, month: 10, day: 10, hour: 14, minute: 49, second: 11, millisecond: 175, kind: DateTimeKind.Local), new DateTime(year: 1957, month: 10, day: 18, hour: 8, minute: 31, second: 45, millisecond: 542, kind: DateTimeKind.Local), new DateTime(year: 1989, month: 10, day: 19, hour: 21, minute: 3, second: 50, millisecond: 84, kind: DateTimeKind.Local), }, { new DateTime(year: 2013, month: 10, day: 13, hour: 13, minute: 47, second: 7, millisecond: 849, kind: DateTimeKind.Local), new DateTime(year: 1931, month: 10, day: 7, hour: 6, minute: 42, second: 42, millisecond: 776, kind: DateTimeKind.Local), new DateTime(year: 2012, month: 10, day: 14, hour: 10, minute: 53, second: 40, millisecond: 85, kind: DateTimeKind.Local), }, { new DateTime(year: 1970, month: 10, day: 8, hour: 9, minute: 49, second: 30, millisecond: 238, kind: DateTimeKind.Local), new DateTime(year: 2017, month: 10, day: 13, hour: 20, minute: 33, second: 43, millisecond: 361, kind: DateTimeKind.Local), new DateTime(year: 1942, month: 10, day: 3, hour: 6, minute: 47, second: 27, millisecond: 545, kind: DateTimeKind.Local), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneMMArrayD3E1M
{
    Id = 24,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1994, month: 10, day: 4, hour: 3, minute: 27, second: 39, millisecond: 331, kind: DateTimeKind.Local), new DateTime(year: 1936, month: 10, day: 10, hour: 6, minute: 57, second: 46, millisecond: 631, kind: DateTimeKind.Local), new DateTime(year: 1920, month: 10, day: 7, hour: 9, minute: 50, second: 20, millisecond: 826, kind: DateTimeKind.Local), }, { new DateTime(year: 1928, month: 10, day: 15, hour: 21, minute: 52, second: 7, millisecond: 638, kind: DateTimeKind.Local), new DateTime(year: 2008, month: 10, day: 5, hour: 1, minute: 57, second: 17, millisecond: 462, kind: DateTimeKind.Local), new DateTime(year: 2016, month: 10, day: 14, hour: 4, minute: 43, second: 29, millisecond: 589, kind: DateTimeKind.Local), }, { new DateTime(year: 2015, month: 10, day: 12, hour: 4, minute: 18, second: 25, millisecond: 330, kind: DateTimeKind.Local), new DateTime(year: 1966, month: 10, day: 16, hour: 19, minute: 54, second: 32, millisecond: 545, kind: DateTimeKind.Local), new DateTime(year: 1960, month: 10, day: 18, hour: 22, minute: 31, second: 55, millisecond: 184, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1946, month: 10, day: 12, hour: 5, minute: 47, second: 12, millisecond: 59, kind: DateTimeKind.Local), new DateTime(year: 1960, month: 10, day: 14, hour: 13, minute: 33, second: 48, millisecond: 434, kind: DateTimeKind.Local), new DateTime(year: 1935, month: 10, day: 19, hour: 4, minute: 4, second: 14, millisecond: 620, kind: DateTimeKind.Local), }, { new DateTime(year: 1985, month: 10, day: 1, hour: 3, minute: 23, second: 32, millisecond: 353, kind: DateTimeKind.Local), new DateTime(year: 2014, month: 10, day: 10, hour: 4, minute: 21, second: 31, millisecond: 110, kind: DateTimeKind.Local), new DateTime(year: 1981, month: 10, day: 17, hour: 20, minute: 22, second: 16, millisecond: 870, kind: DateTimeKind.Local), }, { new DateTime(year: 2014, month: 10, day: 11, hour: 17, minute: 21, second: 31, millisecond: 856, kind: DateTimeKind.Local), new DateTime(year: 1988, month: 10, day: 9, hour: 18, minute: 1, second: 32, millisecond: 964, kind: DateTimeKind.Local), new DateTime(year: 1941, month: 10, day: 4, hour: 18, minute: 24, second: 7, millisecond: 577, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1937, month: 10, day: 10, hour: 5, minute: 43, second: 24, millisecond: 52, kind: DateTimeKind.Local), new DateTime(year: 1990, month: 10, day: 11, hour: 4, minute: 11, second: 16, millisecond: 483, kind: DateTimeKind.Local), new DateTime(year: 2013, month: 10, day: 18, hour: 22, minute: 20, second: 27, millisecond: 328, kind: DateTimeKind.Local), }, { new DateTime(year: 2006, month: 10, day: 10, hour: 9, minute: 45, second: 57, millisecond: 696, kind: DateTimeKind.Local), new DateTime(year: 1944, month: 10, day: 14, hour: 5, minute: 5, second: 40, millisecond: 991, kind: DateTimeKind.Local), new DateTime(year: 1971, month: 10, day: 16, hour: 16, minute: 3, second: 46, millisecond: 275, kind: DateTimeKind.Local), }, { new DateTime(year: 1927, month: 10, day: 13, hour: 5, minute: 3, second: 1, millisecond: 161, kind: DateTimeKind.Local), new DateTime(year: 1941, month: 10, day: 19, hour: 18, minute: 16, second: 10, millisecond: 794, kind: DateTimeKind.Local), new DateTime(year: 2016, month: 10, day: 8, hour: 16, minute: 14, second: 12, millisecond: 92, kind: DateTimeKind.Local), }, }, },
    ModelInner = new DateTimetimestamp_without_time_zoneMMArrayD3E1MI
{
    Id = 7,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1954, month: 10, day: 2, hour: 16, minute: 20, second: 3, millisecond: 416, kind: DateTimeKind.Local), new DateTime(year: 1992, month: 10, day: 12, hour: 10, minute: 48, second: 25, millisecond: 973, kind: DateTimeKind.Local), new DateTime(year: 1930, month: 10, day: 8, hour: 4, minute: 43, second: 27, millisecond: 95, kind: DateTimeKind.Local), }, { new DateTime(year: 1928, month: 10, day: 5, hour: 22, minute: 11, second: 11, millisecond: 297, kind: DateTimeKind.Local), new DateTime(year: 2019, month: 10, day: 13, hour: 19, minute: 48, second: 29, millisecond: 87, kind: DateTimeKind.Local), new DateTime(year: 2019, month: 10, day: 8, hour: 11, minute: 3, second: 52, millisecond: 56, kind: DateTimeKind.Local), }, { new DateTime(year: 1929, month: 10, day: 13, hour: 22, minute: 48, second: 3, millisecond: 971, kind: DateTimeKind.Local), new DateTime(year: 1939, month: 10, day: 19, hour: 19, minute: 44, second: 20, millisecond: 851, kind: DateTimeKind.Local), new DateTime(year: 1925, month: 10, day: 17, hour: 20, minute: 35, second: 43, millisecond: 84, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1988, month: 10, day: 10, hour: 13, minute: 35, second: 6, millisecond: 44, kind: DateTimeKind.Local), new DateTime(year: 1956, month: 10, day: 13, hour: 9, minute: 12, second: 42, millisecond: 105, kind: DateTimeKind.Local), new DateTime(year: 1967, month: 10, day: 14, hour: 2, minute: 28, second: 10, millisecond: 334, kind: DateTimeKind.Local), }, { new DateTime(year: 2012, month: 10, day: 6, hour: 12, minute: 45, second: 42, millisecond: 481, kind: DateTimeKind.Local), new DateTime(year: 1940, month: 10, day: 13, hour: 1, minute: 25, second: 27, millisecond: 315, kind: DateTimeKind.Local), new DateTime(year: 2015, month: 10, day: 13, hour: 14, minute: 27, second: 25, millisecond: 13, kind: DateTimeKind.Local), }, { new DateTime(year: 1934, month: 10, day: 19, hour: 9, minute: 46, second: 56, millisecond: 637, kind: DateTimeKind.Local), new DateTime(year: 1959, month: 10, day: 18, hour: 6, minute: 22, second: 11, millisecond: 100, kind: DateTimeKind.Local), new DateTime(year: 1918, month: 10, day: 17, hour: 20, minute: 34, second: 25, millisecond: 994, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1991, month: 10, day: 7, hour: 3, minute: 9, second: 8, millisecond: 466, kind: DateTimeKind.Local), new DateTime(year: 2009, month: 10, day: 12, hour: 17, minute: 26, second: 25, millisecond: 812, kind: DateTimeKind.Local), new DateTime(year: 1969, month: 10, day: 19, hour: 16, minute: 23, second: 10, millisecond: 581, kind: DateTimeKind.Local), }, { new DateTime(year: 1957, month: 10, day: 6, hour: 14, minute: 25, second: 11, millisecond: 714, kind: DateTimeKind.Local), new DateTime(year: 1993, month: 10, day: 2, hour: 1, minute: 48, second: 24, millisecond: 154, kind: DateTimeKind.Local), new DateTime(year: 2012, month: 10, day: 16, hour: 5, minute: 50, second: 17, millisecond: 114, kind: DateTimeKind.Local), }, { new DateTime(year: 2010, month: 10, day: 16, hour: 15, minute: 44, second: 14, millisecond: 148, kind: DateTimeKind.Local), new DateTime(year: 2008, month: 10, day: 1, hour: 11, minute: 29, second: 9, millisecond: 805, kind: DateTimeKind.Local), new DateTime(year: 1957, month: 10, day: 19, hour: 13, minute: 41, second: 33, millisecond: 700, kind: DateTimeKind.Local), }, }, },
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 2003, month: 10, day: 3, hour: 9, minute: 7, second: 10, millisecond: 90, kind: DateTimeKind.Local), new DateTime(year: 1987, month: 10, day: 16, hour: 2, minute: 53, second: 29, millisecond: 212, kind: DateTimeKind.Local), new DateTime(year: 1926, month: 10, day: 11, hour: 7, minute: 9, second: 56, millisecond: 952, kind: DateTimeKind.Local), }, { new DateTime(year: 2017, month: 10, day: 2, hour: 13, minute: 49, second: 18, millisecond: 166, kind: DateTimeKind.Local), new DateTime(year: 1972, month: 10, day: 1, hour: 20, minute: 52, second: 28, millisecond: 539, kind: DateTimeKind.Local), new DateTime(year: 1949, month: 10, day: 5, hour: 5, minute: 8, second: 39, millisecond: 184, kind: DateTimeKind.Local), }, { new DateTime(year: 2017, month: 10, day: 11, hour: 7, minute: 49, second: 57, millisecond: 150, kind: DateTimeKind.Local), new DateTime(year: 2007, month: 10, day: 19, hour: 15, minute: 52, second: 19, millisecond: 499, kind: DateTimeKind.Local), new DateTime(year: 1965, month: 10, day: 13, hour: 3, minute: 12, second: 55, millisecond: 383, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1957, month: 10, day: 3, hour: 6, minute: 9, second: 31, millisecond: 681, kind: DateTimeKind.Local), new DateTime(year: 1930, month: 10, day: 13, hour: 6, minute: 11, second: 20, millisecond: 696, kind: DateTimeKind.Local), new DateTime(year: 1955, month: 10, day: 3, hour: 22, minute: 52, second: 12, millisecond: 703, kind: DateTimeKind.Local), }, { new DateTime(year: 1926, month: 10, day: 12, hour: 18, minute: 28, second: 21, millisecond: 975, kind: DateTimeKind.Local), new DateTime(year: 1919, month: 10, day: 9, hour: 22, minute: 52, second: 57, millisecond: 877, kind: DateTimeKind.Local), new DateTime(year: 1989, month: 10, day: 3, hour: 17, minute: 57, second: 11, millisecond: 522, kind: DateTimeKind.Local), }, { new DateTime(year: 1957, month: 10, day: 2, hour: 19, minute: 10, second: 7, millisecond: 207, kind: DateTimeKind.Local), new DateTime(year: 1989, month: 10, day: 16, hour: 1, minute: 55, second: 24, millisecond: 849, kind: DateTimeKind.Local), new DateTime(year: 1987, month: 10, day: 2, hour: 22, minute: 55, second: 20, millisecond: 73, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 2002, month: 10, day: 14, hour: 5, minute: 28, second: 50, millisecond: 300, kind: DateTimeKind.Local), new DateTime(year: 1918, month: 10, day: 16, hour: 21, minute: 29, second: 12, millisecond: 542, kind: DateTimeKind.Local), new DateTime(year: 1973, month: 10, day: 18, hour: 17, minute: 54, second: 3, millisecond: 286, kind: DateTimeKind.Local), }, { new DateTime(year: 1977, month: 10, day: 16, hour: 7, minute: 17, second: 19, millisecond: 211, kind: DateTimeKind.Local), new DateTime(year: 1971, month: 10, day: 7, hour: 21, minute: 36, second: 26, millisecond: 73, kind: DateTimeKind.Local), new DateTime(year: 1997, month: 10, day: 8, hour: 12, minute: 57, second: 43, millisecond: 773, kind: DateTimeKind.Local), }, { new DateTime(year: 1968, month: 10, day: 4, hour: 15, minute: 19, second: 16, millisecond: 315, kind: DateTimeKind.Local), new DateTime(year: 1940, month: 10, day: 15, hour: 7, minute: 14, second: 30, millisecond: 701, kind: DateTimeKind.Local), new DateTime(year: 1926, month: 10, day: 8, hour: 18, minute: 27, second: 52, millisecond: 63, kind: DateTimeKind.Local), }, }, },
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneMMArrayD3E1M
{
    Id = 30,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1997, month: 10, day: 5, hour: 2, minute: 37, second: 36, millisecond: 859, kind: DateTimeKind.Local), new DateTime(year: 1960, month: 10, day: 5, hour: 1, minute: 41, second: 12, millisecond: 253, kind: DateTimeKind.Local), new DateTime(year: 2019, month: 10, day: 17, hour: 11, minute: 8, second: 31, millisecond: 139, kind: DateTimeKind.Local), }, { new DateTime(year: 1963, month: 10, day: 3, hour: 7, minute: 29, second: 32, millisecond: 281, kind: DateTimeKind.Local), new DateTime(year: 1930, month: 10, day: 3, hour: 7, minute: 8, second: 27, millisecond: 917, kind: DateTimeKind.Local), new DateTime(year: 1997, month: 10, day: 16, hour: 3, minute: 25, second: 16, millisecond: 504, kind: DateTimeKind.Local), }, { new DateTime(year: 1929, month: 10, day: 13, hour: 19, minute: 51, second: 21, millisecond: 295, kind: DateTimeKind.Local), new DateTime(year: 1946, month: 10, day: 18, hour: 21, minute: 45, second: 29, millisecond: 264, kind: DateTimeKind.Local), new DateTime(year: 1960, month: 10, day: 19, hour: 4, minute: 47, second: 56, millisecond: 949, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1963, month: 10, day: 2, hour: 19, minute: 18, second: 30, millisecond: 252, kind: DateTimeKind.Local), new DateTime(year: 1929, month: 10, day: 19, hour: 12, minute: 58, second: 22, millisecond: 45, kind: DateTimeKind.Local), new DateTime(year: 1926, month: 10, day: 1, hour: 15, minute: 34, second: 28, millisecond: 89, kind: DateTimeKind.Local), }, { new DateTime(year: 1926, month: 10, day: 9, hour: 11, minute: 50, second: 2, millisecond: 9, kind: DateTimeKind.Local), new DateTime(year: 1917, month: 10, day: 16, hour: 9, minute: 9, second: 39, millisecond: 684, kind: DateTimeKind.Local), new DateTime(year: 2000, month: 10, day: 16, hour: 9, minute: 48, second: 18, millisecond: 280, kind: DateTimeKind.Local), }, { new DateTime(year: 1952, month: 10, day: 10, hour: 17, minute: 51, second: 15, millisecond: 52, kind: DateTimeKind.Local), new DateTime(year: 2003, month: 10, day: 18, hour: 14, minute: 28, second: 35, millisecond: 571, kind: DateTimeKind.Local), new DateTime(year: 1965, month: 10, day: 17, hour: 8, minute: 15, second: 3, millisecond: 36, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1938, month: 10, day: 16, hour: 21, minute: 31, second: 58, millisecond: 767, kind: DateTimeKind.Local), new DateTime(year: 1942, month: 10, day: 1, hour: 11, minute: 8, second: 2, millisecond: 367, kind: DateTimeKind.Local), new DateTime(year: 1921, month: 10, day: 3, hour: 16, minute: 20, second: 26, millisecond: 70, kind: DateTimeKind.Local), }, { new DateTime(year: 2017, month: 10, day: 12, hour: 18, minute: 38, second: 53, millisecond: 267, kind: DateTimeKind.Local), new DateTime(year: 1917, month: 10, day: 10, hour: 10, minute: 32, second: 50, millisecond: 576, kind: DateTimeKind.Local), new DateTime(year: 1980, month: 10, day: 1, hour: 21, minute: 16, second: 51, millisecond: 503, kind: DateTimeKind.Local), }, { new DateTime(year: 1951, month: 10, day: 14, hour: 22, minute: 43, second: 3, millisecond: 272, kind: DateTimeKind.Local), new DateTime(year: 1957, month: 10, day: 7, hour: 12, minute: 49, second: 26, millisecond: 59, kind: DateTimeKind.Local), new DateTime(year: 1921, month: 10, day: 7, hour: 18, minute: 7, second: 21, millisecond: 799, kind: DateTimeKind.Local), }, }, },
    ModelInner = null,
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1988, month: 10, day: 5, hour: 10, minute: 46, second: 45, millisecond: 916, kind: DateTimeKind.Local), new DateTime(year: 1927, month: 10, day: 6, hour: 20, minute: 37, second: 8, millisecond: 875, kind: DateTimeKind.Local), new DateTime(year: 1930, month: 10, day: 5, hour: 7, minute: 36, second: 20, millisecond: 989, kind: DateTimeKind.Local), }, { new DateTime(year: 1960, month: 10, day: 12, hour: 22, minute: 48, second: 43, millisecond: 710, kind: DateTimeKind.Local), new DateTime(year: 1967, month: 10, day: 16, hour: 14, minute: 53, second: 33, millisecond: 934, kind: DateTimeKind.Local), new DateTime(year: 1985, month: 10, day: 6, hour: 9, minute: 34, second: 21, millisecond: 429, kind: DateTimeKind.Local), }, { new DateTime(year: 1995, month: 10, day: 5, hour: 1, minute: 22, second: 58, millisecond: 85, kind: DateTimeKind.Local), new DateTime(year: 1948, month: 10, day: 4, hour: 1, minute: 35, second: 52, millisecond: 450, kind: DateTimeKind.Local), new DateTime(year: 2014, month: 10, day: 12, hour: 3, minute: 32, second: 23, millisecond: 216, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1978, month: 10, day: 8, hour: 16, minute: 42, second: 35, millisecond: 700, kind: DateTimeKind.Local), new DateTime(year: 1935, month: 10, day: 8, hour: 22, minute: 53, second: 32, millisecond: 723, kind: DateTimeKind.Local), new DateTime(year: 2011, month: 10, day: 4, hour: 1, minute: 31, second: 16, millisecond: 191, kind: DateTimeKind.Local), }, { new DateTime(year: 1935, month: 10, day: 5, hour: 18, minute: 21, second: 6, millisecond: 736, kind: DateTimeKind.Local), new DateTime(year: 1975, month: 10, day: 14, hour: 22, minute: 19, second: 31, millisecond: 543, kind: DateTimeKind.Local), new DateTime(year: 1930, month: 10, day: 4, hour: 13, minute: 50, second: 53, millisecond: 836, kind: DateTimeKind.Local), }, { new DateTime(year: 1965, month: 10, day: 4, hour: 18, minute: 8, second: 44, millisecond: 223, kind: DateTimeKind.Local), new DateTime(year: 1958, month: 10, day: 13, hour: 13, minute: 53, second: 23, millisecond: 485, kind: DateTimeKind.Local), new DateTime(year: 1917, month: 10, day: 17, hour: 2, minute: 20, second: 52, millisecond: 373, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1963, month: 10, day: 3, hour: 14, minute: 5, second: 5, millisecond: 493, kind: DateTimeKind.Local), new DateTime(year: 2006, month: 10, day: 11, hour: 20, minute: 23, second: 56, millisecond: 288, kind: DateTimeKind.Local), new DateTime(year: 1994, month: 10, day: 16, hour: 13, minute: 42, second: 49, millisecond: 284, kind: DateTimeKind.Local), }, { new DateTime(year: 2005, month: 10, day: 9, hour: 15, minute: 54, second: 23, millisecond: 186, kind: DateTimeKind.Local), new DateTime(year: 1975, month: 10, day: 4, hour: 7, minute: 26, second: 12, millisecond: 353, kind: DateTimeKind.Local), new DateTime(year: 2015, month: 10, day: 8, hour: 18, minute: 51, second: 34, millisecond: 101, kind: DateTimeKind.Local), }, { new DateTime(year: 1958, month: 10, day: 11, hour: 13, minute: 51, second: 54, millisecond: 830, kind: DateTimeKind.Local), new DateTime(year: 2002, month: 10, day: 9, hour: 7, minute: 50, second: 26, millisecond: 982, kind: DateTimeKind.Local), new DateTime(year: 2011, month: 10, day: 11, hour: 8, minute: 41, second: 37, millisecond: 805, kind: DateTimeKind.Local), }, }, },
},
            new DateTimetimestamp_without_time_zoneMMArrayD3E1M
{
    Id = 34,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 2013, month: 10, day: 11, hour: 2, minute: 4, second: 18, millisecond: 146, kind: DateTimeKind.Local), new DateTime(year: 1945, month: 10, day: 4, hour: 16, minute: 10, second: 26, millisecond: 848, kind: DateTimeKind.Local), new DateTime(year: 2008, month: 10, day: 13, hour: 15, minute: 8, second: 18, millisecond: 178, kind: DateTimeKind.Local), }, { new DateTime(year: 1965, month: 10, day: 1, hour: 22, minute: 17, second: 18, millisecond: 195, kind: DateTimeKind.Local), new DateTime(year: 1978, month: 10, day: 2, hour: 10, minute: 37, second: 35, millisecond: 668, kind: DateTimeKind.Local), new DateTime(year: 1998, month: 10, day: 10, hour: 20, minute: 22, second: 16, millisecond: 39, kind: DateTimeKind.Local), }, { new DateTime(year: 2018, month: 10, day: 18, hour: 7, minute: 57, second: 3, millisecond: 678, kind: DateTimeKind.Local), new DateTime(year: 1970, month: 10, day: 6, hour: 10, minute: 42, second: 5, millisecond: 997, kind: DateTimeKind.Local), new DateTime(year: 1966, month: 10, day: 12, hour: 2, minute: 57, second: 39, millisecond: 431, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1922, month: 10, day: 10, hour: 19, minute: 51, second: 28, millisecond: 917, kind: DateTimeKind.Local), new DateTime(year: 1951, month: 10, day: 7, hour: 4, minute: 12, second: 4, millisecond: 703, kind: DateTimeKind.Local), new DateTime(year: 1919, month: 10, day: 12, hour: 15, minute: 33, second: 58, millisecond: 541, kind: DateTimeKind.Local), }, { new DateTime(year: 1981, month: 10, day: 19, hour: 14, minute: 34, second: 13, millisecond: 754, kind: DateTimeKind.Local), new DateTime(year: 1964, month: 10, day: 10, hour: 15, minute: 2, second: 48, millisecond: 768, kind: DateTimeKind.Local), new DateTime(year: 1951, month: 10, day: 13, hour: 6, minute: 9, second: 40, millisecond: 187, kind: DateTimeKind.Local), }, { new DateTime(year: 1942, month: 10, day: 14, hour: 6, minute: 57, second: 52, millisecond: 144, kind: DateTimeKind.Local), new DateTime(year: 1943, month: 10, day: 8, hour: 6, minute: 7, second: 45, millisecond: 570, kind: DateTimeKind.Local), new DateTime(year: 1933, month: 10, day: 13, hour: 13, minute: 49, second: 39, millisecond: 308, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 2019, month: 10, day: 6, hour: 21, minute: 33, second: 27, millisecond: 653, kind: DateTimeKind.Local), new DateTime(year: 1992, month: 10, day: 4, hour: 2, minute: 18, second: 15, millisecond: 123, kind: DateTimeKind.Local), new DateTime(year: 1929, month: 10, day: 14, hour: 16, minute: 36, second: 5, millisecond: 796, kind: DateTimeKind.Local), }, { new DateTime(year: 1939, month: 10, day: 8, hour: 18, minute: 23, second: 24, millisecond: 668, kind: DateTimeKind.Local), new DateTime(year: 1962, month: 10, day: 1, hour: 7, minute: 4, second: 58, millisecond: 217, kind: DateTimeKind.Local), new DateTime(year: 1999, month: 10, day: 14, hour: 11, minute: 48, second: 10, millisecond: 839, kind: DateTimeKind.Local), }, { new DateTime(year: 1989, month: 10, day: 1, hour: 15, minute: 15, second: 50, millisecond: 4, kind: DateTimeKind.Local), new DateTime(year: 2010, month: 10, day: 19, hour: 2, minute: 45, second: 43, millisecond: 749, kind: DateTimeKind.Local), new DateTime(year: 1924, month: 10, day: 11, hour: 16, minute: 47, second: 27, millisecond: 81, kind: DateTimeKind.Local), }, }, },
    ModelInner = new DateTimetimestamp_without_time_zoneMMArrayD3E1MI
{
    Id = 13,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1985, month: 10, day: 1, hour: 18, minute: 55, second: 43, millisecond: 834, kind: DateTimeKind.Local), new DateTime(year: 1938, month: 10, day: 9, hour: 6, minute: 3, second: 21, millisecond: 333, kind: DateTimeKind.Local), new DateTime(year: 1994, month: 10, day: 8, hour: 15, minute: 46, second: 22, millisecond: 714, kind: DateTimeKind.Local), }, { new DateTime(year: 1937, month: 10, day: 17, hour: 9, minute: 43, second: 24, millisecond: 927, kind: DateTimeKind.Local), new DateTime(year: 1938, month: 10, day: 6, hour: 10, minute: 9, second: 34, millisecond: 51, kind: DateTimeKind.Local), new DateTime(year: 1950, month: 10, day: 8, hour: 6, minute: 49, second: 7, millisecond: 172, kind: DateTimeKind.Local), }, { new DateTime(year: 1973, month: 10, day: 9, hour: 8, minute: 9, second: 14, millisecond: 88, kind: DateTimeKind.Local), new DateTime(year: 1968, month: 10, day: 6, hour: 11, minute: 51, second: 32, millisecond: 718, kind: DateTimeKind.Local), new DateTime(year: 1988, month: 10, day: 5, hour: 13, minute: 30, second: 9, millisecond: 943, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1929, month: 10, day: 12, hour: 4, minute: 45, second: 9, millisecond: 740, kind: DateTimeKind.Local), new DateTime(year: 1926, month: 10, day: 10, hour: 9, minute: 3, second: 45, millisecond: 959, kind: DateTimeKind.Local), new DateTime(year: 1962, month: 10, day: 7, hour: 12, minute: 20, second: 41, millisecond: 384, kind: DateTimeKind.Local), }, { new DateTime(year: 1973, month: 10, day: 9, hour: 14, minute: 15, second: 37, millisecond: 969, kind: DateTimeKind.Local), new DateTime(year: 1967, month: 10, day: 5, hour: 10, minute: 21, second: 37, millisecond: 868, kind: DateTimeKind.Local), new DateTime(year: 2010, month: 10, day: 2, hour: 2, minute: 42, second: 2, millisecond: 161, kind: DateTimeKind.Local), }, { new DateTime(year: 1921, month: 10, day: 4, hour: 2, minute: 43, second: 43, millisecond: 308, kind: DateTimeKind.Local), new DateTime(year: 1942, month: 10, day: 8, hour: 2, minute: 53, second: 10, millisecond: 261, kind: DateTimeKind.Local), new DateTime(year: 1971, month: 10, day: 11, hour: 15, minute: 6, second: 42, millisecond: 104, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1943, month: 10, day: 9, hour: 21, minute: 57, second: 53, millisecond: 334, kind: DateTimeKind.Local), new DateTime(year: 1964, month: 10, day: 4, hour: 7, minute: 56, second: 33, millisecond: 338, kind: DateTimeKind.Local), new DateTime(year: 1973, month: 10, day: 14, hour: 17, minute: 50, second: 12, millisecond: 219, kind: DateTimeKind.Local), }, { new DateTime(year: 1978, month: 10, day: 12, hour: 9, minute: 6, second: 39, millisecond: 631, kind: DateTimeKind.Local), new DateTime(year: 1962, month: 10, day: 5, hour: 10, minute: 7, second: 8, millisecond: 120, kind: DateTimeKind.Local), new DateTime(year: 1935, month: 10, day: 15, hour: 5, minute: 30, second: 5, millisecond: 919, kind: DateTimeKind.Local), }, { new DateTime(year: 1949, month: 10, day: 16, hour: 7, minute: 58, second: 4, millisecond: 314, kind: DateTimeKind.Local), new DateTime(year: 1958, month: 10, day: 16, hour: 17, minute: 38, second: 2, millisecond: 852, kind: DateTimeKind.Local), new DateTime(year: 1984, month: 10, day: 9, hour: 7, minute: 5, second: 58, millisecond: 210, kind: DateTimeKind.Local), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneMMArrayD3E1M
{
    Id = 41,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1969, month: 10, day: 3, hour: 6, minute: 24, second: 33, millisecond: 351, kind: DateTimeKind.Local), new DateTime(year: 1945, month: 10, day: 7, hour: 16, minute: 36, second: 20, millisecond: 169, kind: DateTimeKind.Local), new DateTime(year: 1957, month: 10, day: 15, hour: 11, minute: 55, second: 2, millisecond: 948, kind: DateTimeKind.Local), }, { new DateTime(year: 1919, month: 10, day: 17, hour: 11, minute: 45, second: 56, millisecond: 615, kind: DateTimeKind.Local), new DateTime(year: 2012, month: 10, day: 7, hour: 14, minute: 11, second: 15, millisecond: 196, kind: DateTimeKind.Local), new DateTime(year: 1971, month: 10, day: 7, hour: 12, minute: 21, second: 56, millisecond: 394, kind: DateTimeKind.Local), }, { new DateTime(year: 1991, month: 10, day: 6, hour: 10, minute: 17, second: 39, millisecond: 92, kind: DateTimeKind.Local), new DateTime(year: 1965, month: 10, day: 19, hour: 18, minute: 53, second: 49, millisecond: 957, kind: DateTimeKind.Local), new DateTime(year: 1986, month: 10, day: 14, hour: 4, minute: 54, second: 7, millisecond: 563, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1925, month: 10, day: 18, hour: 1, minute: 37, second: 2, millisecond: 599, kind: DateTimeKind.Local), new DateTime(year: 1971, month: 10, day: 11, hour: 13, minute: 45, second: 5, millisecond: 640, kind: DateTimeKind.Local), new DateTime(year: 1979, month: 10, day: 4, hour: 19, minute: 52, second: 22, millisecond: 565, kind: DateTimeKind.Local), }, { new DateTime(year: 2001, month: 10, day: 5, hour: 14, minute: 18, second: 5, millisecond: 43, kind: DateTimeKind.Local), new DateTime(year: 1954, month: 10, day: 6, hour: 1, minute: 45, second: 57, millisecond: 393, kind: DateTimeKind.Local), new DateTime(year: 1955, month: 10, day: 17, hour: 7, minute: 50, second: 45, millisecond: 578, kind: DateTimeKind.Local), }, { new DateTime(year: 1945, month: 10, day: 17, hour: 21, minute: 42, second: 44, millisecond: 982, kind: DateTimeKind.Local), new DateTime(year: 1996, month: 10, day: 3, hour: 21, minute: 12, second: 41, millisecond: 525, kind: DateTimeKind.Local), new DateTime(year: 1945, month: 10, day: 14, hour: 14, minute: 22, second: 52, millisecond: 129, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1918, month: 10, day: 3, hour: 6, minute: 3, second: 53, millisecond: 512, kind: DateTimeKind.Local), new DateTime(year: 2012, month: 10, day: 8, hour: 16, minute: 33, second: 17, millisecond: 246, kind: DateTimeKind.Local), new DateTime(year: 1928, month: 10, day: 17, hour: 16, minute: 1, second: 25, millisecond: 887, kind: DateTimeKind.Local), }, { new DateTime(year: 1986, month: 10, day: 12, hour: 6, minute: 24, second: 53, millisecond: 840, kind: DateTimeKind.Local), new DateTime(year: 1955, month: 10, day: 4, hour: 22, minute: 6, second: 43, millisecond: 61, kind: DateTimeKind.Local), new DateTime(year: 2006, month: 10, day: 4, hour: 8, minute: 49, second: 1, millisecond: 912, kind: DateTimeKind.Local), }, { new DateTime(year: 1940, month: 10, day: 16, hour: 20, minute: 46, second: 9, millisecond: 627, kind: DateTimeKind.Local), new DateTime(year: 1981, month: 10, day: 6, hour: 18, minute: 49, second: 39, millisecond: 65, kind: DateTimeKind.Local), new DateTime(year: 1997, month: 10, day: 7, hour: 22, minute: 48, second: 37, millisecond: 691, kind: DateTimeKind.Local), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneMMArrayD3E1M
{
    Id = 47,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1919, month: 10, day: 1, hour: 15, minute: 42, second: 50, millisecond: 306, kind: DateTimeKind.Local), new DateTime(year: 1920, month: 10, day: 8, hour: 17, minute: 48, second: 31, millisecond: 911, kind: DateTimeKind.Local), new DateTime(year: 1937, month: 10, day: 16, hour: 18, minute: 51, second: 58, millisecond: 90, kind: DateTimeKind.Local), }, { new DateTime(year: 1947, month: 10, day: 15, hour: 8, minute: 57, second: 1, millisecond: 557, kind: DateTimeKind.Local), new DateTime(year: 1950, month: 10, day: 6, hour: 8, minute: 3, second: 23, millisecond: 904, kind: DateTimeKind.Local), new DateTime(year: 1949, month: 10, day: 19, hour: 11, minute: 15, second: 38, millisecond: 153, kind: DateTimeKind.Local), }, { new DateTime(year: 1969, month: 10, day: 2, hour: 14, minute: 17, second: 35, millisecond: 515, kind: DateTimeKind.Local), new DateTime(year: 2002, month: 10, day: 13, hour: 13, minute: 39, second: 58, millisecond: 33, kind: DateTimeKind.Local), new DateTime(year: 1933, month: 10, day: 6, hour: 10, minute: 24, second: 35, millisecond: 943, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 2018, month: 10, day: 8, hour: 12, minute: 14, second: 7, millisecond: 7, kind: DateTimeKind.Local), new DateTime(year: 1983, month: 10, day: 14, hour: 16, minute: 50, second: 53, millisecond: 575, kind: DateTimeKind.Local), new DateTime(year: 1920, month: 10, day: 18, hour: 17, minute: 42, second: 1, millisecond: 933, kind: DateTimeKind.Local), }, { new DateTime(year: 1932, month: 10, day: 3, hour: 16, minute: 45, second: 57, millisecond: 482, kind: DateTimeKind.Local), new DateTime(year: 2017, month: 10, day: 14, hour: 21, minute: 23, second: 44, millisecond: 712, kind: DateTimeKind.Local), new DateTime(year: 1931, month: 10, day: 16, hour: 13, minute: 15, second: 44, millisecond: 391, kind: DateTimeKind.Local), }, { new DateTime(year: 1929, month: 10, day: 1, hour: 12, minute: 34, second: 23, millisecond: 101, kind: DateTimeKind.Local), new DateTime(year: 1982, month: 10, day: 6, hour: 7, minute: 14, second: 8, millisecond: 444, kind: DateTimeKind.Local), new DateTime(year: 1973, month: 10, day: 18, hour: 12, minute: 13, second: 16, millisecond: 183, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1945, month: 10, day: 13, hour: 8, minute: 30, second: 2, millisecond: 208, kind: DateTimeKind.Local), new DateTime(year: 1957, month: 10, day: 4, hour: 18, minute: 41, second: 35, millisecond: 279, kind: DateTimeKind.Local), new DateTime(year: 1998, month: 10, day: 8, hour: 2, minute: 9, second: 54, millisecond: 316, kind: DateTimeKind.Local), }, { new DateTime(year: 1991, month: 10, day: 2, hour: 17, minute: 23, second: 29, millisecond: 79, kind: DateTimeKind.Local), new DateTime(year: 1961, month: 10, day: 4, hour: 18, minute: 8, second: 10, millisecond: 803, kind: DateTimeKind.Local), new DateTime(year: 1946, month: 10, day: 4, hour: 7, minute: 50, second: 19, millisecond: 178, kind: DateTimeKind.Local), }, { new DateTime(year: 1918, month: 10, day: 10, hour: 9, minute: 57, second: 23, millisecond: 752, kind: DateTimeKind.Local), new DateTime(year: 2005, month: 10, day: 6, hour: 6, minute: 43, second: 46, millisecond: 431, kind: DateTimeKind.Local), new DateTime(year: 2010, month: 10, day: 17, hour: 13, minute: 33, second: 24, millisecond: 904, kind: DateTimeKind.Local), }, }, },
    ModelInner = new DateTimetimestamp_without_time_zoneMMArrayD3E1MI
{
    Id = 20,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1924, month: 10, day: 7, hour: 7, minute: 17, second: 49, millisecond: 253, kind: DateTimeKind.Local), new DateTime(year: 1995, month: 10, day: 8, hour: 1, minute: 43, second: 1, millisecond: 835, kind: DateTimeKind.Local), new DateTime(year: 2008, month: 10, day: 10, hour: 14, minute: 38, second: 48, millisecond: 714, kind: DateTimeKind.Local), }, { new DateTime(year: 1919, month: 10, day: 6, hour: 21, minute: 38, second: 40, millisecond: 338, kind: DateTimeKind.Local), new DateTime(year: 1962, month: 10, day: 8, hour: 16, minute: 31, second: 44, millisecond: 137, kind: DateTimeKind.Local), new DateTime(year: 1933, month: 10, day: 5, hour: 10, minute: 7, second: 16, millisecond: 350, kind: DateTimeKind.Local), }, { new DateTime(year: 1978, month: 10, day: 9, hour: 21, minute: 50, second: 37, millisecond: 698, kind: DateTimeKind.Local), new DateTime(year: 1940, month: 10, day: 14, hour: 5, minute: 56, second: 30, millisecond: 64, kind: DateTimeKind.Local), new DateTime(year: 1932, month: 10, day: 11, hour: 10, minute: 25, second: 18, millisecond: 480, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1979, month: 10, day: 9, hour: 10, minute: 20, second: 46, millisecond: 281, kind: DateTimeKind.Local), new DateTime(year: 1951, month: 10, day: 7, hour: 16, minute: 26, second: 46, millisecond: 281, kind: DateTimeKind.Local), new DateTime(year: 2011, month: 10, day: 15, hour: 18, minute: 53, second: 35, millisecond: 387, kind: DateTimeKind.Local), }, { new DateTime(year: 1924, month: 10, day: 3, hour: 3, minute: 39, second: 6, millisecond: 972, kind: DateTimeKind.Local), new DateTime(year: 2015, month: 10, day: 12, hour: 1, minute: 39, second: 21, millisecond: 834, kind: DateTimeKind.Local), new DateTime(year: 2019, month: 10, day: 15, hour: 21, minute: 16, second: 11, millisecond: 670, kind: DateTimeKind.Local), }, { new DateTime(year: 1964, month: 10, day: 3, hour: 15, minute: 57, second: 57, millisecond: 398, kind: DateTimeKind.Local), new DateTime(year: 1976, month: 10, day: 2, hour: 5, minute: 40, second: 13, millisecond: 327, kind: DateTimeKind.Local), new DateTime(year: 1940, month: 10, day: 7, hour: 13, minute: 21, second: 52, millisecond: 103, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 2010, month: 10, day: 13, hour: 17, minute: 55, second: 1, millisecond: 804, kind: DateTimeKind.Local), new DateTime(year: 1956, month: 10, day: 14, hour: 11, minute: 21, second: 5, millisecond: 798, kind: DateTimeKind.Local), new DateTime(year: 2016, month: 10, day: 18, hour: 5, minute: 55, second: 24, millisecond: 413, kind: DateTimeKind.Local), }, { new DateTime(year: 1987, month: 10, day: 2, hour: 3, minute: 53, second: 34, millisecond: 907, kind: DateTimeKind.Local), new DateTime(year: 1969, month: 10, day: 4, hour: 18, minute: 18, second: 53, millisecond: 250, kind: DateTimeKind.Local), new DateTime(year: 2015, month: 10, day: 13, hour: 12, minute: 19, second: 31, millisecond: 846, kind: DateTimeKind.Local), }, { new DateTime(year: 1926, month: 10, day: 6, hour: 1, minute: 46, second: 45, millisecond: 194, kind: DateTimeKind.Local), new DateTime(year: 1952, month: 10, day: 19, hour: 11, minute: 19, second: 16, millisecond: 432, kind: DateTimeKind.Local), new DateTime(year: 1940, month: 10, day: 1, hour: 3, minute: 27, second: 17, millisecond: 111, kind: DateTimeKind.Local), }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 2002, month: 10, day: 13, hour: 16, minute: 33, second: 30, millisecond: 814, kind: DateTimeKind.Local), new DateTime(year: 1997, month: 10, day: 19, hour: 9, minute: 7, second: 9, millisecond: 412, kind: DateTimeKind.Local), new DateTime(year: 2007, month: 10, day: 18, hour: 10, minute: 10, second: 54, millisecond: 587, kind: DateTimeKind.Local), }, { new DateTime(year: 1952, month: 10, day: 2, hour: 8, minute: 39, second: 48, millisecond: 545, kind: DateTimeKind.Local), new DateTime(year: 1940, month: 10, day: 19, hour: 3, minute: 5, second: 39, millisecond: 324, kind: DateTimeKind.Local), new DateTime(year: 1994, month: 10, day: 4, hour: 16, minute: 14, second: 50, millisecond: 255, kind: DateTimeKind.Local), }, { new DateTime(year: 1919, month: 10, day: 18, hour: 10, minute: 36, second: 27, millisecond: 257, kind: DateTimeKind.Local), new DateTime(year: 1953, month: 10, day: 10, hour: 22, minute: 5, second: 27, millisecond: 73, kind: DateTimeKind.Local), new DateTime(year: 1998, month: 10, day: 16, hour: 14, minute: 45, second: 5, millisecond: 365, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1985, month: 10, day: 4, hour: 14, minute: 41, second: 41, millisecond: 714, kind: DateTimeKind.Local), new DateTime(year: 1962, month: 10, day: 8, hour: 12, minute: 54, second: 45, millisecond: 208, kind: DateTimeKind.Local), new DateTime(year: 1958, month: 10, day: 6, hour: 2, minute: 12, second: 4, millisecond: 546, kind: DateTimeKind.Local), }, { new DateTime(year: 1959, month: 10, day: 13, hour: 3, minute: 45, second: 53, millisecond: 139, kind: DateTimeKind.Local), new DateTime(year: 1986, month: 10, day: 3, hour: 15, minute: 55, second: 32, millisecond: 626, kind: DateTimeKind.Local), new DateTime(year: 1983, month: 10, day: 16, hour: 13, minute: 32, second: 45, millisecond: 308, kind: DateTimeKind.Local), }, { new DateTime(year: 1984, month: 10, day: 8, hour: 21, minute: 56, second: 24, millisecond: 376, kind: DateTimeKind.Local), new DateTime(year: 1957, month: 10, day: 7, hour: 2, minute: 17, second: 20, millisecond: 388, kind: DateTimeKind.Local), new DateTime(year: 1982, month: 10, day: 12, hour: 8, minute: 4, second: 19, millisecond: 858, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1973, month: 10, day: 6, hour: 12, minute: 4, second: 26, millisecond: 605, kind: DateTimeKind.Local), new DateTime(year: 2006, month: 10, day: 4, hour: 8, minute: 36, second: 45, millisecond: 763, kind: DateTimeKind.Local), new DateTime(year: 1918, month: 10, day: 13, hour: 15, minute: 5, second: 54, millisecond: 580, kind: DateTimeKind.Local), }, { new DateTime(year: 2016, month: 10, day: 4, hour: 15, minute: 38, second: 46, millisecond: 723, kind: DateTimeKind.Local), new DateTime(year: 1976, month: 10, day: 6, hour: 16, minute: 25, second: 57, millisecond: 19, kind: DateTimeKind.Local), new DateTime(year: 1938, month: 10, day: 6, hour: 18, minute: 57, second: 7, millisecond: 973, kind: DateTimeKind.Local), }, { new DateTime(year: 2013, month: 10, day: 11, hour: 4, minute: 7, second: 34, millisecond: 897, kind: DateTimeKind.Local), new DateTime(year: 1952, month: 10, day: 11, hour: 18, minute: 6, second: 38, millisecond: 713, kind: DateTimeKind.Local), new DateTime(year: 1925, month: 10, day: 9, hour: 3, minute: 30, second: 1, millisecond: 588, kind: DateTimeKind.Local), }, }, },
},
            new DateTimetimestamp_without_time_zoneMMArrayD3E1M
{
    Id = 50,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1966, month: 10, day: 7, hour: 15, minute: 10, second: 36, millisecond: 888, kind: DateTimeKind.Local), new DateTime(year: 1941, month: 10, day: 16, hour: 13, minute: 7, second: 53, millisecond: 699, kind: DateTimeKind.Local), new DateTime(year: 1957, month: 10, day: 11, hour: 17, minute: 6, second: 43, millisecond: 745, kind: DateTimeKind.Local), }, { new DateTime(year: 2011, month: 10, day: 17, hour: 14, minute: 30, second: 27, millisecond: 835, kind: DateTimeKind.Local), new DateTime(year: 1997, month: 10, day: 17, hour: 5, minute: 8, second: 55, millisecond: 71, kind: DateTimeKind.Local), new DateTime(year: 1944, month: 10, day: 19, hour: 18, minute: 40, second: 16, millisecond: 886, kind: DateTimeKind.Local), }, { new DateTime(year: 1926, month: 10, day: 3, hour: 16, minute: 1, second: 32, millisecond: 84, kind: DateTimeKind.Local), new DateTime(year: 1978, month: 10, day: 17, hour: 17, minute: 40, second: 34, millisecond: 815, kind: DateTimeKind.Local), new DateTime(year: 1962, month: 10, day: 13, hour: 18, minute: 50, second: 21, millisecond: 70, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 2002, month: 10, day: 13, hour: 4, minute: 9, second: 51, millisecond: 239, kind: DateTimeKind.Local), new DateTime(year: 1998, month: 10, day: 17, hour: 2, minute: 30, second: 12, millisecond: 416, kind: DateTimeKind.Local), new DateTime(year: 1975, month: 10, day: 12, hour: 22, minute: 44, second: 20, millisecond: 33, kind: DateTimeKind.Local), }, { new DateTime(year: 2019, month: 10, day: 15, hour: 3, minute: 55, second: 20, millisecond: 609, kind: DateTimeKind.Local), new DateTime(year: 1960, month: 10, day: 10, hour: 16, minute: 28, second: 30, millisecond: 210, kind: DateTimeKind.Local), new DateTime(year: 1963, month: 10, day: 10, hour: 12, minute: 40, second: 58, millisecond: 950, kind: DateTimeKind.Local), }, { new DateTime(year: 1963, month: 10, day: 7, hour: 1, minute: 54, second: 30, millisecond: 622, kind: DateTimeKind.Local), new DateTime(year: 1947, month: 10, day: 2, hour: 7, minute: 46, second: 3, millisecond: 684, kind: DateTimeKind.Local), new DateTime(year: 1956, month: 10, day: 1, hour: 17, minute: 57, second: 52, millisecond: 270, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1944, month: 10, day: 8, hour: 20, minute: 3, second: 30, millisecond: 791, kind: DateTimeKind.Local), new DateTime(year: 1943, month: 10, day: 13, hour: 12, minute: 4, second: 6, millisecond: 823, kind: DateTimeKind.Local), new DateTime(year: 2012, month: 10, day: 13, hour: 11, minute: 48, second: 22, millisecond: 402, kind: DateTimeKind.Local), }, { new DateTime(year: 1965, month: 10, day: 5, hour: 15, minute: 42, second: 8, millisecond: 358, kind: DateTimeKind.Local), new DateTime(year: 1966, month: 10, day: 16, hour: 21, minute: 4, second: 52, millisecond: 642, kind: DateTimeKind.Local), new DateTime(year: 1961, month: 10, day: 9, hour: 13, minute: 7, second: 22, millisecond: 396, kind: DateTimeKind.Local), }, { new DateTime(year: 1943, month: 10, day: 14, hour: 3, minute: 37, second: 26, millisecond: 506, kind: DateTimeKind.Local), new DateTime(year: 1929, month: 10, day: 4, hour: 14, minute: 33, second: 48, millisecond: 982, kind: DateTimeKind.Local), new DateTime(year: 1947, month: 10, day: 4, hour: 8, minute: 21, second: 2, millisecond: 390, kind: DateTimeKind.Local), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneMMArrayD3E1M
{
    Id = 58,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1999, month: 10, day: 3, hour: 12, minute: 52, second: 32, millisecond: 960, kind: DateTimeKind.Local), new DateTime(year: 2007, month: 10, day: 12, hour: 8, minute: 9, second: 31, millisecond: 5, kind: DateTimeKind.Local), new DateTime(year: 1981, month: 10, day: 9, hour: 7, minute: 1, second: 27, millisecond: 378, kind: DateTimeKind.Local), }, { new DateTime(year: 1991, month: 10, day: 9, hour: 1, minute: 6, second: 46, millisecond: 988, kind: DateTimeKind.Local), new DateTime(year: 1926, month: 10, day: 7, hour: 15, minute: 45, second: 53, millisecond: 361, kind: DateTimeKind.Local), new DateTime(year: 1924, month: 10, day: 19, hour: 2, minute: 9, second: 58, millisecond: 639, kind: DateTimeKind.Local), }, { new DateTime(year: 2000, month: 10, day: 13, hour: 2, minute: 41, second: 28, millisecond: 336, kind: DateTimeKind.Local), new DateTime(year: 1946, month: 10, day: 15, hour: 16, minute: 23, second: 4, millisecond: 753, kind: DateTimeKind.Local), new DateTime(year: 1994, month: 10, day: 17, hour: 17, minute: 35, second: 2, millisecond: 459, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1999, month: 10, day: 5, hour: 7, minute: 54, second: 24, millisecond: 861, kind: DateTimeKind.Local), new DateTime(year: 1942, month: 10, day: 12, hour: 8, minute: 35, second: 51, millisecond: 195, kind: DateTimeKind.Local), new DateTime(year: 1930, month: 10, day: 5, hour: 17, minute: 30, second: 44, millisecond: 874, kind: DateTimeKind.Local), }, { new DateTime(year: 1919, month: 10, day: 18, hour: 21, minute: 30, second: 17, millisecond: 190, kind: DateTimeKind.Local), new DateTime(year: 1943, month: 10, day: 18, hour: 22, minute: 6, second: 25, millisecond: 267, kind: DateTimeKind.Local), new DateTime(year: 1941, month: 10, day: 19, hour: 11, minute: 20, second: 4, millisecond: 118, kind: DateTimeKind.Local), }, { new DateTime(year: 1944, month: 10, day: 16, hour: 6, minute: 5, second: 29, millisecond: 633, kind: DateTimeKind.Local), new DateTime(year: 1926, month: 10, day: 2, hour: 19, minute: 19, second: 38, millisecond: 535, kind: DateTimeKind.Local), new DateTime(year: 1998, month: 10, day: 17, hour: 9, minute: 58, second: 48, millisecond: 767, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1920, month: 10, day: 7, hour: 9, minute: 35, second: 10, millisecond: 895, kind: DateTimeKind.Local), new DateTime(year: 2001, month: 10, day: 15, hour: 13, minute: 16, second: 5, millisecond: 180, kind: DateTimeKind.Local), new DateTime(year: 1920, month: 10, day: 13, hour: 2, minute: 6, second: 32, millisecond: 624, kind: DateTimeKind.Local), }, { new DateTime(year: 1983, month: 10, day: 18, hour: 5, minute: 9, second: 30, millisecond: 39, kind: DateTimeKind.Local), new DateTime(year: 1932, month: 10, day: 14, hour: 7, minute: 2, second: 8, millisecond: 382, kind: DateTimeKind.Local), new DateTime(year: 2017, month: 10, day: 6, hour: 4, minute: 16, second: 43, millisecond: 720, kind: DateTimeKind.Local), }, { new DateTime(year: 1995, month: 10, day: 18, hour: 12, minute: 10, second: 32, millisecond: 798, kind: DateTimeKind.Local), new DateTime(year: 1951, month: 10, day: 17, hour: 3, minute: 35, second: 58, millisecond: 602, kind: DateTimeKind.Local), new DateTime(year: 1979, month: 10, day: 2, hour: 9, minute: 25, second: 5, millisecond: 753, kind: DateTimeKind.Local), }, }, },
    ModelInner = new DateTimetimestamp_without_time_zoneMMArrayD3E1MI
{
    Id = 22,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1938, month: 10, day: 19, hour: 1, minute: 56, second: 37, millisecond: 160, kind: DateTimeKind.Local), new DateTime(year: 2014, month: 10, day: 16, hour: 9, minute: 20, second: 32, millisecond: 241, kind: DateTimeKind.Local), new DateTime(year: 1935, month: 10, day: 7, hour: 10, minute: 8, second: 52, millisecond: 537, kind: DateTimeKind.Local), }, { new DateTime(year: 1922, month: 10, day: 7, hour: 21, minute: 12, second: 46, millisecond: 319, kind: DateTimeKind.Local), new DateTime(year: 1963, month: 10, day: 13, hour: 2, minute: 11, second: 46, millisecond: 72, kind: DateTimeKind.Local), new DateTime(year: 2011, month: 10, day: 7, hour: 2, minute: 33, second: 45, millisecond: 465, kind: DateTimeKind.Local), }, { new DateTime(year: 1949, month: 10, day: 8, hour: 11, minute: 36, second: 54, millisecond: 907, kind: DateTimeKind.Local), new DateTime(year: 1976, month: 10, day: 5, hour: 3, minute: 21, second: 15, millisecond: 859, kind: DateTimeKind.Local), new DateTime(year: 2009, month: 10, day: 2, hour: 14, minute: 37, second: 23, millisecond: 272, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1951, month: 10, day: 9, hour: 11, minute: 48, second: 52, millisecond: 686, kind: DateTimeKind.Local), new DateTime(year: 1938, month: 10, day: 15, hour: 9, minute: 26, second: 56, millisecond: 928, kind: DateTimeKind.Local), new DateTime(year: 1960, month: 10, day: 16, hour: 7, minute: 37, second: 44, millisecond: 936, kind: DateTimeKind.Local), }, { new DateTime(year: 2012, month: 10, day: 18, hour: 2, minute: 4, second: 5, millisecond: 244, kind: DateTimeKind.Local), new DateTime(year: 1943, month: 10, day: 18, hour: 1, minute: 26, second: 15, millisecond: 108, kind: DateTimeKind.Local), new DateTime(year: 1986, month: 10, day: 13, hour: 10, minute: 49, second: 23, millisecond: 601, kind: DateTimeKind.Local), }, { new DateTime(year: 1974, month: 10, day: 3, hour: 16, minute: 42, second: 18, millisecond: 748, kind: DateTimeKind.Local), new DateTime(year: 1974, month: 10, day: 15, hour: 3, minute: 54, second: 31, millisecond: 137, kind: DateTimeKind.Local), new DateTime(year: 1920, month: 10, day: 2, hour: 2, minute: 26, second: 17, millisecond: 338, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1977, month: 10, day: 6, hour: 11, minute: 16, second: 55, millisecond: 404, kind: DateTimeKind.Local), new DateTime(year: 1961, month: 10, day: 7, hour: 6, minute: 28, second: 30, millisecond: 53, kind: DateTimeKind.Local), new DateTime(year: 2001, month: 10, day: 6, hour: 1, minute: 36, second: 54, millisecond: 271, kind: DateTimeKind.Local), }, { new DateTime(year: 1986, month: 10, day: 12, hour: 19, minute: 57, second: 56, millisecond: 841, kind: DateTimeKind.Local), new DateTime(year: 1974, month: 10, day: 19, hour: 11, minute: 19, second: 13, millisecond: 212, kind: DateTimeKind.Local), new DateTime(year: 1918, month: 10, day: 17, hour: 19, minute: 16, second: 51, millisecond: 723, kind: DateTimeKind.Local), }, { new DateTime(year: 1921, month: 10, day: 11, hour: 3, minute: 50, second: 52, millisecond: 114, kind: DateTimeKind.Local), new DateTime(year: 2007, month: 10, day: 7, hour: 2, minute: 35, second: 2, millisecond: 150, kind: DateTimeKind.Local), new DateTime(year: 1988, month: 10, day: 19, hour: 19, minute: 28, second: 26, millisecond: 467, kind: DateTimeKind.Local), }, }, },
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1934, month: 10, day: 8, hour: 4, minute: 54, second: 50, millisecond: 517, kind: DateTimeKind.Local), new DateTime(year: 1990, month: 10, day: 3, hour: 1, minute: 20, second: 4, millisecond: 319, kind: DateTimeKind.Local), new DateTime(year: 1932, month: 10, day: 5, hour: 11, minute: 31, second: 21, millisecond: 991, kind: DateTimeKind.Local), }, { new DateTime(year: 1931, month: 10, day: 6, hour: 1, minute: 5, second: 1, millisecond: 643, kind: DateTimeKind.Local), new DateTime(year: 1948, month: 10, day: 9, hour: 6, minute: 23, second: 45, millisecond: 877, kind: DateTimeKind.Local), new DateTime(year: 1938, month: 10, day: 12, hour: 9, minute: 31, second: 24, millisecond: 347, kind: DateTimeKind.Local), }, { new DateTime(year: 1952, month: 10, day: 15, hour: 6, minute: 51, second: 8, millisecond: 2, kind: DateTimeKind.Local), new DateTime(year: 1968, month: 10, day: 14, hour: 3, minute: 28, second: 43, millisecond: 800, kind: DateTimeKind.Local), new DateTime(year: 1952, month: 10, day: 4, hour: 8, minute: 57, second: 17, millisecond: 66, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1963, month: 10, day: 11, hour: 10, minute: 29, second: 56, millisecond: 383, kind: DateTimeKind.Local), new DateTime(year: 1954, month: 10, day: 16, hour: 2, minute: 43, second: 57, millisecond: 81, kind: DateTimeKind.Local), new DateTime(year: 1940, month: 10, day: 13, hour: 22, minute: 39, second: 24, millisecond: 767, kind: DateTimeKind.Local), }, { new DateTime(year: 1978, month: 10, day: 4, hour: 20, minute: 45, second: 10, millisecond: 632, kind: DateTimeKind.Local), new DateTime(year: 1952, month: 10, day: 16, hour: 20, minute: 24, second: 50, millisecond: 902, kind: DateTimeKind.Local), new DateTime(year: 1973, month: 10, day: 6, hour: 8, minute: 47, second: 2, millisecond: 582, kind: DateTimeKind.Local), }, { new DateTime(year: 1978, month: 10, day: 19, hour: 22, minute: 32, second: 52, millisecond: 852, kind: DateTimeKind.Local), new DateTime(year: 2002, month: 10, day: 1, hour: 3, minute: 9, second: 58, millisecond: 111, kind: DateTimeKind.Local), new DateTime(year: 1946, month: 10, day: 16, hour: 21, minute: 40, second: 13, millisecond: 874, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1964, month: 10, day: 4, hour: 3, minute: 51, second: 28, millisecond: 426, kind: DateTimeKind.Local), new DateTime(year: 1992, month: 10, day: 14, hour: 8, minute: 19, second: 25, millisecond: 389, kind: DateTimeKind.Local), new DateTime(year: 1957, month: 10, day: 14, hour: 10, minute: 36, second: 11, millisecond: 214, kind: DateTimeKind.Local), }, { new DateTime(year: 1964, month: 10, day: 16, hour: 18, minute: 2, second: 4, millisecond: 187, kind: DateTimeKind.Local), new DateTime(year: 1975, month: 10, day: 19, hour: 1, minute: 18, second: 28, millisecond: 150, kind: DateTimeKind.Local), new DateTime(year: 2003, month: 10, day: 7, hour: 16, minute: 38, second: 26, millisecond: 337, kind: DateTimeKind.Local), }, { new DateTime(year: 1936, month: 10, day: 4, hour: 21, minute: 24, second: 16, millisecond: 996, kind: DateTimeKind.Local), new DateTime(year: 1940, month: 10, day: 2, hour: 8, minute: 22, second: 7, millisecond: 49, kind: DateTimeKind.Local), new DateTime(year: 1972, month: 10, day: 1, hour: 17, minute: 11, second: 57, millisecond: 701, kind: DateTimeKind.Local), }, }, },
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneMMArrayD3E1M
{
    Id = 65,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 2007, month: 10, day: 14, hour: 11, minute: 38, second: 42, millisecond: 817, kind: DateTimeKind.Local), new DateTime(year: 2003, month: 10, day: 9, hour: 4, minute: 24, second: 56, millisecond: 527, kind: DateTimeKind.Local), new DateTime(year: 2011, month: 10, day: 9, hour: 13, minute: 21, second: 36, millisecond: 536, kind: DateTimeKind.Local), }, { new DateTime(year: 1919, month: 10, day: 14, hour: 1, minute: 12, second: 53, millisecond: 512, kind: DateTimeKind.Local), new DateTime(year: 1939, month: 10, day: 10, hour: 9, minute: 22, second: 6, millisecond: 538, kind: DateTimeKind.Local), new DateTime(year: 1938, month: 10, day: 5, hour: 9, minute: 11, second: 48, millisecond: 306, kind: DateTimeKind.Local), }, { new DateTime(year: 2007, month: 10, day: 14, hour: 3, minute: 17, second: 8, millisecond: 844, kind: DateTimeKind.Local), new DateTime(year: 1976, month: 10, day: 4, hour: 13, minute: 3, second: 48, millisecond: 690, kind: DateTimeKind.Local), new DateTime(year: 1978, month: 10, day: 9, hour: 2, minute: 24, second: 57, millisecond: 136, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1938, month: 10, day: 17, hour: 19, minute: 6, second: 14, millisecond: 762, kind: DateTimeKind.Local), new DateTime(year: 1943, month: 10, day: 5, hour: 18, minute: 19, second: 1, millisecond: 227, kind: DateTimeKind.Local), new DateTime(year: 1923, month: 10, day: 19, hour: 17, minute: 49, second: 21, millisecond: 378, kind: DateTimeKind.Local), }, { new DateTime(year: 2000, month: 10, day: 12, hour: 4, minute: 47, second: 18, millisecond: 736, kind: DateTimeKind.Local), new DateTime(year: 1958, month: 10, day: 8, hour: 16, minute: 9, second: 8, millisecond: 248, kind: DateTimeKind.Local), new DateTime(year: 1958, month: 10, day: 10, hour: 19, minute: 30, second: 38, millisecond: 499, kind: DateTimeKind.Local), }, { new DateTime(year: 1938, month: 10, day: 19, hour: 7, minute: 27, second: 22, millisecond: 839, kind: DateTimeKind.Local), new DateTime(year: 1991, month: 10, day: 16, hour: 8, minute: 18, second: 8, millisecond: 694, kind: DateTimeKind.Local), new DateTime(year: 1986, month: 10, day: 4, hour: 6, minute: 1, second: 33, millisecond: 71, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1952, month: 10, day: 14, hour: 18, minute: 44, second: 40, millisecond: 811, kind: DateTimeKind.Local), new DateTime(year: 1919, month: 10, day: 1, hour: 18, minute: 54, second: 55, millisecond: 894, kind: DateTimeKind.Local), new DateTime(year: 1996, month: 10, day: 3, hour: 14, minute: 52, second: 34, millisecond: 644, kind: DateTimeKind.Local), }, { new DateTime(year: 1946, month: 10, day: 11, hour: 17, minute: 45, second: 57, millisecond: 576, kind: DateTimeKind.Local), new DateTime(year: 1984, month: 10, day: 7, hour: 19, minute: 56, second: 55, millisecond: 528, kind: DateTimeKind.Local), new DateTime(year: 1983, month: 10, day: 18, hour: 19, minute: 33, second: 20, millisecond: 403, kind: DateTimeKind.Local), }, { new DateTime(year: 1971, month: 10, day: 6, hour: 19, minute: 46, second: 52, millisecond: 121, kind: DateTimeKind.Local), new DateTime(year: 1920, month: 10, day: 19, hour: 5, minute: 46, second: 49, millisecond: 867, kind: DateTimeKind.Local), new DateTime(year: 1979, month: 10, day: 5, hour: 8, minute: 41, second: 3, millisecond: 451, kind: DateTimeKind.Local), }, }, },
    ModelInner = null,
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1934, month: 10, day: 15, hour: 8, minute: 58, second: 14, millisecond: 140, kind: DateTimeKind.Local), new DateTime(year: 1963, month: 10, day: 11, hour: 1, minute: 55, second: 1, millisecond: 266, kind: DateTimeKind.Local), new DateTime(year: 2007, month: 10, day: 10, hour: 20, minute: 13, second: 24, millisecond: 474, kind: DateTimeKind.Local), }, { new DateTime(year: 1935, month: 10, day: 17, hour: 19, minute: 15, second: 52, millisecond: 325, kind: DateTimeKind.Local), new DateTime(year: 1967, month: 10, day: 9, hour: 21, minute: 51, second: 20, millisecond: 558, kind: DateTimeKind.Local), new DateTime(year: 1984, month: 10, day: 1, hour: 10, minute: 25, second: 11, millisecond: 903, kind: DateTimeKind.Local), }, { new DateTime(year: 1951, month: 10, day: 14, hour: 12, minute: 24, second: 35, millisecond: 600, kind: DateTimeKind.Local), new DateTime(year: 2001, month: 10, day: 16, hour: 11, minute: 19, second: 18, millisecond: 112, kind: DateTimeKind.Local), new DateTime(year: 2011, month: 10, day: 16, hour: 7, minute: 6, second: 2, millisecond: 620, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1964, month: 10, day: 13, hour: 2, minute: 30, second: 14, millisecond: 344, kind: DateTimeKind.Local), new DateTime(year: 1964, month: 10, day: 6, hour: 13, minute: 58, second: 48, millisecond: 896, kind: DateTimeKind.Local), new DateTime(year: 1920, month: 10, day: 2, hour: 18, minute: 56, second: 52, millisecond: 751, kind: DateTimeKind.Local), }, { new DateTime(year: 1985, month: 10, day: 15, hour: 2, minute: 2, second: 56, millisecond: 435, kind: DateTimeKind.Local), new DateTime(year: 1957, month: 10, day: 8, hour: 17, minute: 16, second: 33, millisecond: 283, kind: DateTimeKind.Local), new DateTime(year: 2019, month: 10, day: 16, hour: 9, minute: 36, second: 43, millisecond: 449, kind: DateTimeKind.Local), }, { new DateTime(year: 1951, month: 10, day: 18, hour: 11, minute: 27, second: 6, millisecond: 545, kind: DateTimeKind.Local), new DateTime(year: 1964, month: 10, day: 6, hour: 22, minute: 41, second: 26, millisecond: 373, kind: DateTimeKind.Local), new DateTime(year: 2003, month: 10, day: 9, hour: 10, minute: 5, second: 19, millisecond: 146, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 2000, month: 10, day: 17, hour: 19, minute: 50, second: 7, millisecond: 264, kind: DateTimeKind.Local), new DateTime(year: 2016, month: 10, day: 7, hour: 11, minute: 10, second: 6, millisecond: 291, kind: DateTimeKind.Local), new DateTime(year: 1999, month: 10, day: 19, hour: 18, minute: 4, second: 11, millisecond: 820, kind: DateTimeKind.Local), }, { new DateTime(year: 1951, month: 10, day: 12, hour: 5, minute: 3, second: 33, millisecond: 143, kind: DateTimeKind.Local), new DateTime(year: 2003, month: 10, day: 19, hour: 22, minute: 42, second: 55, millisecond: 723, kind: DateTimeKind.Local), new DateTime(year: 1987, month: 10, day: 7, hour: 21, minute: 19, second: 12, millisecond: 58, kind: DateTimeKind.Local), }, { new DateTime(year: 1980, month: 10, day: 19, hour: 4, minute: 12, second: 29, millisecond: 682, kind: DateTimeKind.Local), new DateTime(year: 1995, month: 10, day: 5, hour: 4, minute: 2, second: 17, millisecond: 641, kind: DateTimeKind.Local), new DateTime(year: 1924, month: 10, day: 18, hour: 6, minute: 40, second: 56, millisecond: 281, kind: DateTimeKind.Local), }, }, },
},
            new DateTimetimestamp_without_time_zoneMMArrayD3E1M
{
    Id = 66,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1992, month: 10, day: 10, hour: 3, minute: 31, second: 11, millisecond: 47, kind: DateTimeKind.Local), new DateTime(year: 1934, month: 10, day: 17, hour: 4, minute: 7, second: 47, millisecond: 619, kind: DateTimeKind.Local), new DateTime(year: 1965, month: 10, day: 11, hour: 11, minute: 47, second: 13, millisecond: 719, kind: DateTimeKind.Local), }, { new DateTime(year: 1930, month: 10, day: 15, hour: 7, minute: 20, second: 48, millisecond: 697, kind: DateTimeKind.Local), new DateTime(year: 1984, month: 10, day: 14, hour: 19, minute: 27, second: 5, millisecond: 842, kind: DateTimeKind.Local), new DateTime(year: 1987, month: 10, day: 1, hour: 22, minute: 15, second: 16, millisecond: 341, kind: DateTimeKind.Local), }, { new DateTime(year: 1966, month: 10, day: 3, hour: 9, minute: 28, second: 26, millisecond: 340, kind: DateTimeKind.Local), new DateTime(year: 1943, month: 10, day: 1, hour: 19, minute: 26, second: 19, millisecond: 299, kind: DateTimeKind.Local), new DateTime(year: 2019, month: 10, day: 16, hour: 20, minute: 50, second: 16, millisecond: 57, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1972, month: 10, day: 14, hour: 7, minute: 53, second: 3, millisecond: 377, kind: DateTimeKind.Local), new DateTime(year: 2004, month: 10, day: 6, hour: 6, minute: 37, second: 13, millisecond: 592, kind: DateTimeKind.Local), new DateTime(year: 1941, month: 10, day: 11, hour: 2, minute: 12, second: 35, millisecond: 586, kind: DateTimeKind.Local), }, { new DateTime(year: 1999, month: 10, day: 3, hour: 12, minute: 5, second: 36, millisecond: 899, kind: DateTimeKind.Local), new DateTime(year: 1967, month: 10, day: 1, hour: 21, minute: 23, second: 9, millisecond: 477, kind: DateTimeKind.Local), new DateTime(year: 1968, month: 10, day: 12, hour: 13, minute: 36, second: 22, millisecond: 257, kind: DateTimeKind.Local), }, { new DateTime(year: 1938, month: 10, day: 14, hour: 11, minute: 32, second: 11, millisecond: 905, kind: DateTimeKind.Local), new DateTime(year: 1948, month: 10, day: 12, hour: 4, minute: 20, second: 10, millisecond: 189, kind: DateTimeKind.Local), new DateTime(year: 1923, month: 10, day: 11, hour: 19, minute: 53, second: 19, millisecond: 26, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1933, month: 10, day: 14, hour: 14, minute: 43, second: 16, millisecond: 483, kind: DateTimeKind.Local), new DateTime(year: 1943, month: 10, day: 11, hour: 15, minute: 13, second: 31, millisecond: 245, kind: DateTimeKind.Local), new DateTime(year: 2018, month: 10, day: 8, hour: 10, minute: 51, second: 4, millisecond: 372, kind: DateTimeKind.Local), }, { new DateTime(year: 2001, month: 10, day: 1, hour: 3, minute: 33, second: 38, millisecond: 301, kind: DateTimeKind.Local), new DateTime(year: 2017, month: 10, day: 5, hour: 19, minute: 26, second: 51, millisecond: 461, kind: DateTimeKind.Local), new DateTime(year: 1926, month: 10, day: 6, hour: 17, minute: 33, second: 55, millisecond: 477, kind: DateTimeKind.Local), }, { new DateTime(year: 1964, month: 10, day: 12, hour: 12, minute: 16, second: 57, millisecond: 369, kind: DateTimeKind.Local), new DateTime(year: 1990, month: 10, day: 17, hour: 8, minute: 4, second: 41, millisecond: 419, kind: DateTimeKind.Local), new DateTime(year: 2006, month: 10, day: 12, hour: 14, minute: 45, second: 21, millisecond: 13, kind: DateTimeKind.Local), }, }, },
    ModelInner = new DateTimetimestamp_without_time_zoneMMArrayD3E1MI
{
    Id = 30,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1986, month: 10, day: 15, hour: 9, minute: 30, second: 15, millisecond: 987, kind: DateTimeKind.Local), new DateTime(year: 1975, month: 10, day: 7, hour: 4, minute: 7, second: 13, millisecond: 946, kind: DateTimeKind.Local), new DateTime(year: 1927, month: 10, day: 9, hour: 14, minute: 39, second: 11, millisecond: 252, kind: DateTimeKind.Local), }, { new DateTime(year: 1932, month: 10, day: 9, hour: 1, minute: 19, second: 57, millisecond: 910, kind: DateTimeKind.Local), new DateTime(year: 2003, month: 10, day: 3, hour: 18, minute: 1, second: 1, millisecond: 333, kind: DateTimeKind.Local), new DateTime(year: 2001, month: 10, day: 6, hour: 4, minute: 47, second: 30, millisecond: 638, kind: DateTimeKind.Local), }, { new DateTime(year: 2010, month: 10, day: 15, hour: 11, minute: 1, second: 9, millisecond: 803, kind: DateTimeKind.Local), new DateTime(year: 2002, month: 10, day: 8, hour: 19, minute: 6, second: 25, millisecond: 487, kind: DateTimeKind.Local), new DateTime(year: 1931, month: 10, day: 19, hour: 14, minute: 3, second: 56, millisecond: 361, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 2015, month: 10, day: 12, hour: 3, minute: 58, second: 30, millisecond: 189, kind: DateTimeKind.Local), new DateTime(year: 1981, month: 10, day: 13, hour: 3, minute: 37, second: 46, millisecond: 654, kind: DateTimeKind.Local), new DateTime(year: 2009, month: 10, day: 19, hour: 22, minute: 31, second: 18, millisecond: 548, kind: DateTimeKind.Local), }, { new DateTime(year: 2005, month: 10, day: 9, hour: 11, minute: 14, second: 9, millisecond: 496, kind: DateTimeKind.Local), new DateTime(year: 1998, month: 10, day: 3, hour: 15, minute: 53, second: 18, millisecond: 158, kind: DateTimeKind.Local), new DateTime(year: 1959, month: 10, day: 12, hour: 20, minute: 35, second: 19, millisecond: 383, kind: DateTimeKind.Local), }, { new DateTime(year: 1953, month: 10, day: 2, hour: 17, minute: 51, second: 45, millisecond: 269, kind: DateTimeKind.Local), new DateTime(year: 1958, month: 10, day: 17, hour: 7, minute: 52, second: 19, millisecond: 611, kind: DateTimeKind.Local), new DateTime(year: 1922, month: 10, day: 13, hour: 22, minute: 3, second: 21, millisecond: 200, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1957, month: 10, day: 19, hour: 11, minute: 47, second: 26, millisecond: 374, kind: DateTimeKind.Local), new DateTime(year: 1977, month: 10, day: 13, hour: 3, minute: 24, second: 4, millisecond: 682, kind: DateTimeKind.Local), new DateTime(year: 1936, month: 10, day: 9, hour: 17, minute: 29, second: 51, millisecond: 259, kind: DateTimeKind.Local), }, { new DateTime(year: 1940, month: 10, day: 6, hour: 3, minute: 25, second: 36, millisecond: 1, kind: DateTimeKind.Local), new DateTime(year: 1998, month: 10, day: 11, hour: 15, minute: 28, second: 39, millisecond: 408, kind: DateTimeKind.Local), new DateTime(year: 1942, month: 10, day: 11, hour: 2, minute: 56, second: 50, millisecond: 705, kind: DateTimeKind.Local), }, { new DateTime(year: 1967, month: 10, day: 13, hour: 5, minute: 17, second: 1, millisecond: 352, kind: DateTimeKind.Local), new DateTime(year: 1966, month: 10, day: 16, hour: 16, minute: 54, second: 38, millisecond: 637, kind: DateTimeKind.Local), new DateTime(year: 2009, month: 10, day: 7, hour: 13, minute: 25, second: 13, millisecond: 214, kind: DateTimeKind.Local), }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1993, month: 10, day: 15, hour: 8, minute: 35, second: 24, millisecond: 976, kind: DateTimeKind.Local), new DateTime(year: 1960, month: 10, day: 19, hour: 22, minute: 25, second: 35, millisecond: 885, kind: DateTimeKind.Local), new DateTime(year: 1943, month: 10, day: 18, hour: 18, minute: 25, second: 6, millisecond: 640, kind: DateTimeKind.Local), }, { new DateTime(year: 2015, month: 10, day: 12, hour: 11, minute: 9, second: 49, millisecond: 558, kind: DateTimeKind.Local), new DateTime(year: 1983, month: 10, day: 5, hour: 6, minute: 17, second: 12, millisecond: 216, kind: DateTimeKind.Local), new DateTime(year: 1956, month: 10, day: 4, hour: 10, minute: 35, second: 2, millisecond: 116, kind: DateTimeKind.Local), }, { new DateTime(year: 1930, month: 10, day: 15, hour: 1, minute: 25, second: 39, millisecond: 973, kind: DateTimeKind.Local), new DateTime(year: 2018, month: 10, day: 8, hour: 8, minute: 51, second: 20, millisecond: 926, kind: DateTimeKind.Local), new DateTime(year: 1987, month: 10, day: 5, hour: 6, minute: 3, second: 16, millisecond: 788, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1939, month: 10, day: 8, hour: 14, minute: 27, second: 26, millisecond: 152, kind: DateTimeKind.Local), new DateTime(year: 1933, month: 10, day: 12, hour: 14, minute: 3, second: 43, millisecond: 427, kind: DateTimeKind.Local), new DateTime(year: 1924, month: 10, day: 7, hour: 10, minute: 24, second: 15, millisecond: 241, kind: DateTimeKind.Local), }, { new DateTime(year: 1951, month: 10, day: 12, hour: 15, minute: 9, second: 58, millisecond: 900, kind: DateTimeKind.Local), new DateTime(year: 1947, month: 10, day: 4, hour: 21, minute: 8, second: 13, millisecond: 946, kind: DateTimeKind.Local), new DateTime(year: 1941, month: 10, day: 9, hour: 4, minute: 54, second: 8, millisecond: 178, kind: DateTimeKind.Local), }, { new DateTime(year: 1943, month: 10, day: 6, hour: 21, minute: 56, second: 20, millisecond: 483, kind: DateTimeKind.Local), new DateTime(year: 2001, month: 10, day: 15, hour: 11, minute: 47, second: 1, millisecond: 239, kind: DateTimeKind.Local), new DateTime(year: 1966, month: 10, day: 15, hour: 5, minute: 38, second: 30, millisecond: 867, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1946, month: 10, day: 10, hour: 14, minute: 22, second: 29, millisecond: 344, kind: DateTimeKind.Local), new DateTime(year: 1950, month: 10, day: 19, hour: 13, minute: 40, second: 26, millisecond: 47, kind: DateTimeKind.Local), new DateTime(year: 1938, month: 10, day: 5, hour: 12, minute: 49, second: 43, millisecond: 303, kind: DateTimeKind.Local), }, { new DateTime(year: 1956, month: 10, day: 13, hour: 13, minute: 40, second: 5, millisecond: 526, kind: DateTimeKind.Local), new DateTime(year: 1977, month: 10, day: 9, hour: 2, minute: 14, second: 19, millisecond: 661, kind: DateTimeKind.Local), new DateTime(year: 1943, month: 10, day: 18, hour: 7, minute: 54, second: 35, millisecond: 888, kind: DateTimeKind.Local), }, { new DateTime(year: 1918, month: 10, day: 5, hour: 1, minute: 26, second: 39, millisecond: 403, kind: DateTimeKind.Local), new DateTime(year: 1923, month: 10, day: 4, hour: 9, minute: 32, second: 17, millisecond: 446, kind: DateTimeKind.Local), new DateTime(year: 1940, month: 10, day: 12, hour: 18, minute: 7, second: 37, millisecond: 760, kind: DateTimeKind.Local), }, }, },
},
            new DateTimetimestamp_without_time_zoneMMArrayD3E1M
{
    Id = 69,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1981, month: 10, day: 13, hour: 1, minute: 5, second: 43, millisecond: 142, kind: DateTimeKind.Local), new DateTime(year: 1945, month: 10, day: 12, hour: 14, minute: 46, second: 37, millisecond: 327, kind: DateTimeKind.Local), new DateTime(year: 1929, month: 10, day: 11, hour: 18, minute: 20, second: 47, millisecond: 717, kind: DateTimeKind.Local), }, { new DateTime(year: 1988, month: 10, day: 18, hour: 5, minute: 57, second: 45, millisecond: 876, kind: DateTimeKind.Local), new DateTime(year: 1998, month: 10, day: 1, hour: 14, minute: 14, second: 4, millisecond: 2, kind: DateTimeKind.Local), new DateTime(year: 1929, month: 10, day: 10, hour: 21, minute: 15, second: 58, millisecond: 43, kind: DateTimeKind.Local), }, { new DateTime(year: 2019, month: 10, day: 1, hour: 5, minute: 35, second: 35, millisecond: 937, kind: DateTimeKind.Local), new DateTime(year: 1985, month: 10, day: 11, hour: 12, minute: 19, second: 19, millisecond: 734, kind: DateTimeKind.Local), new DateTime(year: 2010, month: 10, day: 3, hour: 16, minute: 35, second: 24, millisecond: 267, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1958, month: 10, day: 10, hour: 10, minute: 21, second: 8, millisecond: 737, kind: DateTimeKind.Local), new DateTime(year: 1957, month: 10, day: 3, hour: 6, minute: 38, second: 19, millisecond: 533, kind: DateTimeKind.Local), new DateTime(year: 1989, month: 10, day: 11, hour: 7, minute: 14, second: 47, millisecond: 487, kind: DateTimeKind.Local), }, { new DateTime(year: 1969, month: 10, day: 4, hour: 2, minute: 10, second: 7, millisecond: 626, kind: DateTimeKind.Local), new DateTime(year: 1983, month: 10, day: 8, hour: 3, minute: 58, second: 7, millisecond: 324, kind: DateTimeKind.Local), new DateTime(year: 1923, month: 10, day: 4, hour: 11, minute: 52, second: 21, millisecond: 256, kind: DateTimeKind.Local), }, { new DateTime(year: 1947, month: 10, day: 4, hour: 6, minute: 18, second: 57, millisecond: 54, kind: DateTimeKind.Local), new DateTime(year: 1987, month: 10, day: 15, hour: 8, minute: 16, second: 21, millisecond: 202, kind: DateTimeKind.Local), new DateTime(year: 1932, month: 10, day: 1, hour: 17, minute: 24, second: 1, millisecond: 114, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1917, month: 10, day: 3, hour: 4, minute: 3, second: 57, millisecond: 92, kind: DateTimeKind.Local), new DateTime(year: 1959, month: 10, day: 10, hour: 15, minute: 37, second: 49, millisecond: 260, kind: DateTimeKind.Local), new DateTime(year: 1992, month: 10, day: 9, hour: 7, minute: 39, second: 31, millisecond: 670, kind: DateTimeKind.Local), }, { new DateTime(year: 1980, month: 10, day: 3, hour: 22, minute: 24, second: 45, millisecond: 140, kind: DateTimeKind.Local), new DateTime(year: 1935, month: 10, day: 18, hour: 10, minute: 44, second: 49, millisecond: 812, kind: DateTimeKind.Local), new DateTime(year: 1956, month: 10, day: 13, hour: 17, minute: 22, second: 25, millisecond: 66, kind: DateTimeKind.Local), }, { new DateTime(year: 2019, month: 10, day: 13, hour: 4, minute: 37, second: 19, millisecond: 649, kind: DateTimeKind.Local), new DateTime(year: 1920, month: 10, day: 4, hour: 22, minute: 40, second: 34, millisecond: 412, kind: DateTimeKind.Local), new DateTime(year: 1919, month: 10, day: 9, hour: 7, minute: 13, second: 57, millisecond: 605, kind: DateTimeKind.Local), }, }, },
    ModelInner = null,
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1986, month: 10, day: 3, hour: 7, minute: 19, second: 19, millisecond: 832, kind: DateTimeKind.Local), new DateTime(year: 1925, month: 10, day: 4, hour: 16, minute: 21, second: 53, millisecond: 203, kind: DateTimeKind.Local), new DateTime(year: 1979, month: 10, day: 6, hour: 4, minute: 8, second: 47, millisecond: 375, kind: DateTimeKind.Local), }, { new DateTime(year: 1921, month: 10, day: 18, hour: 16, minute: 56, second: 29, millisecond: 509, kind: DateTimeKind.Local), new DateTime(year: 1932, month: 10, day: 6, hour: 9, minute: 27, second: 43, millisecond: 373, kind: DateTimeKind.Local), new DateTime(year: 2003, month: 10, day: 12, hour: 6, minute: 56, second: 3, millisecond: 341, kind: DateTimeKind.Local), }, { new DateTime(year: 1970, month: 10, day: 17, hour: 13, minute: 33, second: 4, millisecond: 871, kind: DateTimeKind.Local), new DateTime(year: 1949, month: 10, day: 9, hour: 17, minute: 13, second: 13, millisecond: 984, kind: DateTimeKind.Local), new DateTime(year: 2016, month: 10, day: 14, hour: 5, minute: 9, second: 18, millisecond: 630, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1981, month: 10, day: 6, hour: 9, minute: 57, second: 38, millisecond: 446, kind: DateTimeKind.Local), new DateTime(year: 1990, month: 10, day: 19, hour: 6, minute: 52, second: 15, millisecond: 142, kind: DateTimeKind.Local), new DateTime(year: 2002, month: 10, day: 16, hour: 8, minute: 26, second: 4, millisecond: 368, kind: DateTimeKind.Local), }, { new DateTime(year: 1920, month: 10, day: 18, hour: 18, minute: 18, second: 49, millisecond: 23, kind: DateTimeKind.Local), new DateTime(year: 2016, month: 10, day: 11, hour: 11, minute: 52, second: 33, millisecond: 484, kind: DateTimeKind.Local), new DateTime(year: 1981, month: 10, day: 15, hour: 14, minute: 28, second: 37, millisecond: 371, kind: DateTimeKind.Local), }, { new DateTime(year: 1925, month: 10, day: 11, hour: 16, minute: 52, second: 17, millisecond: 984, kind: DateTimeKind.Local), new DateTime(year: 2016, month: 10, day: 7, hour: 20, minute: 19, second: 51, millisecond: 439, kind: DateTimeKind.Local), new DateTime(year: 1965, month: 10, day: 7, hour: 2, minute: 18, second: 40, millisecond: 93, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1974, month: 10, day: 16, hour: 12, minute: 50, second: 16, millisecond: 673, kind: DateTimeKind.Local), new DateTime(year: 2014, month: 10, day: 4, hour: 18, minute: 37, second: 45, millisecond: 285, kind: DateTimeKind.Local), new DateTime(year: 1989, month: 10, day: 9, hour: 3, minute: 8, second: 13, millisecond: 931, kind: DateTimeKind.Local), }, { new DateTime(year: 1979, month: 10, day: 16, hour: 18, minute: 19, second: 22, millisecond: 27, kind: DateTimeKind.Local), new DateTime(year: 1954, month: 10, day: 4, hour: 2, minute: 53, second: 3, millisecond: 187, kind: DateTimeKind.Local), new DateTime(year: 1919, month: 10, day: 10, hour: 15, minute: 57, second: 35, millisecond: 972, kind: DateTimeKind.Local), }, { new DateTime(year: 1993, month: 10, day: 14, hour: 1, minute: 20, second: 54, millisecond: 460, kind: DateTimeKind.Local), new DateTime(year: 1924, month: 10, day: 3, hour: 13, minute: 15, second: 42, millisecond: 503, kind: DateTimeKind.Local), new DateTime(year: 1970, month: 10, day: 13, hour: 12, minute: 19, second: 48, millisecond: 375, kind: DateTimeKind.Local), }, }, },
},
            new DateTimetimestamp_without_time_zoneMMArrayD3E1M
{
    Id = 77,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1963, month: 10, day: 13, hour: 6, minute: 16, second: 31, millisecond: 655, kind: DateTimeKind.Local), new DateTime(year: 1960, month: 10, day: 1, hour: 9, minute: 54, second: 52, millisecond: 688, kind: DateTimeKind.Local), new DateTime(year: 1919, month: 10, day: 9, hour: 5, minute: 28, second: 14, millisecond: 682, kind: DateTimeKind.Local), }, { new DateTime(year: 1979, month: 10, day: 4, hour: 14, minute: 14, second: 32, millisecond: 54, kind: DateTimeKind.Local), new DateTime(year: 1928, month: 10, day: 4, hour: 22, minute: 29, second: 24, millisecond: 131, kind: DateTimeKind.Local), new DateTime(year: 1968, month: 10, day: 11, hour: 14, minute: 10, second: 30, millisecond: 449, kind: DateTimeKind.Local), }, { new DateTime(year: 2014, month: 10, day: 10, hour: 17, minute: 2, second: 14, millisecond: 181, kind: DateTimeKind.Local), new DateTime(year: 1996, month: 10, day: 11, hour: 18, minute: 22, second: 54, millisecond: 95, kind: DateTimeKind.Local), new DateTime(year: 1933, month: 10, day: 4, hour: 13, minute: 15, second: 12, millisecond: 627, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1970, month: 10, day: 9, hour: 10, minute: 10, second: 4, millisecond: 34, kind: DateTimeKind.Local), new DateTime(year: 1965, month: 10, day: 16, hour: 1, minute: 23, second: 26, millisecond: 381, kind: DateTimeKind.Local), new DateTime(year: 1922, month: 10, day: 1, hour: 11, minute: 46, second: 31, millisecond: 196, kind: DateTimeKind.Local), }, { new DateTime(year: 1969, month: 10, day: 10, hour: 5, minute: 26, second: 41, millisecond: 866, kind: DateTimeKind.Local), new DateTime(year: 1925, month: 10, day: 11, hour: 15, minute: 56, second: 39, millisecond: 159, kind: DateTimeKind.Local), new DateTime(year: 1941, month: 10, day: 9, hour: 12, minute: 11, second: 34, millisecond: 297, kind: DateTimeKind.Local), }, { new DateTime(year: 1936, month: 10, day: 7, hour: 5, minute: 53, second: 7, millisecond: 571, kind: DateTimeKind.Local), new DateTime(year: 2018, month: 10, day: 2, hour: 12, minute: 50, second: 34, millisecond: 634, kind: DateTimeKind.Local), new DateTime(year: 1936, month: 10, day: 14, hour: 13, minute: 22, second: 21, millisecond: 699, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1941, month: 10, day: 12, hour: 9, minute: 23, second: 48, millisecond: 212, kind: DateTimeKind.Local), new DateTime(year: 2011, month: 10, day: 4, hour: 16, minute: 43, second: 27, millisecond: 651, kind: DateTimeKind.Local), new DateTime(year: 1945, month: 10, day: 8, hour: 20, minute: 50, second: 50, millisecond: 102, kind: DateTimeKind.Local), }, { new DateTime(year: 1986, month: 10, day: 5, hour: 18, minute: 27, second: 36, millisecond: 758, kind: DateTimeKind.Local), new DateTime(year: 2001, month: 10, day: 18, hour: 19, minute: 58, second: 51, millisecond: 57, kind: DateTimeKind.Local), new DateTime(year: 1946, month: 10, day: 13, hour: 21, minute: 34, second: 48, millisecond: 181, kind: DateTimeKind.Local), }, { new DateTime(year: 1986, month: 10, day: 11, hour: 19, minute: 40, second: 25, millisecond: 146, kind: DateTimeKind.Local), new DateTime(year: 1954, month: 10, day: 12, hour: 15, minute: 54, second: 43, millisecond: 580, kind: DateTimeKind.Local), new DateTime(year: 1982, month: 10, day: 16, hour: 11, minute: 7, second: 28, millisecond: 586, kind: DateTimeKind.Local), }, }, },
    ModelInner = new DateTimetimestamp_without_time_zoneMMArrayD3E1MI
{
    Id = 37,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 2004, month: 10, day: 16, hour: 20, minute: 13, second: 5, millisecond: 312, kind: DateTimeKind.Local), new DateTime(year: 1931, month: 10, day: 12, hour: 20, minute: 33, second: 6, millisecond: 467, kind: DateTimeKind.Local), new DateTime(year: 2001, month: 10, day: 13, hour: 18, minute: 55, second: 26, millisecond: 665, kind: DateTimeKind.Local), }, { new DateTime(year: 2017, month: 10, day: 14, hour: 15, minute: 23, second: 25, millisecond: 732, kind: DateTimeKind.Local), new DateTime(year: 1974, month: 10, day: 6, hour: 13, minute: 7, second: 39, millisecond: 237, kind: DateTimeKind.Local), new DateTime(year: 2015, month: 10, day: 5, hour: 11, minute: 58, second: 24, millisecond: 683, kind: DateTimeKind.Local), }, { new DateTime(year: 1970, month: 10, day: 17, hour: 15, minute: 1, second: 56, millisecond: 457, kind: DateTimeKind.Local), new DateTime(year: 1926, month: 10, day: 18, hour: 1, minute: 2, second: 9, millisecond: 850, kind: DateTimeKind.Local), new DateTime(year: 1954, month: 10, day: 8, hour: 20, minute: 22, second: 33, millisecond: 768, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 2008, month: 10, day: 4, hour: 7, minute: 13, second: 41, millisecond: 774, kind: DateTimeKind.Local), new DateTime(year: 1921, month: 10, day: 2, hour: 20, minute: 38, second: 15, millisecond: 225, kind: DateTimeKind.Local), new DateTime(year: 2005, month: 10, day: 18, hour: 10, minute: 10, second: 54, millisecond: 694, kind: DateTimeKind.Local), }, { new DateTime(year: 2005, month: 10, day: 3, hour: 2, minute: 53, second: 39, millisecond: 222, kind: DateTimeKind.Local), new DateTime(year: 2013, month: 10, day: 6, hour: 6, minute: 47, second: 31, millisecond: 36, kind: DateTimeKind.Local), new DateTime(year: 2013, month: 10, day: 10, hour: 18, minute: 54, second: 38, millisecond: 433, kind: DateTimeKind.Local), }, { new DateTime(year: 1974, month: 10, day: 14, hour: 3, minute: 5, second: 38, millisecond: 447, kind: DateTimeKind.Local), new DateTime(year: 1933, month: 10, day: 11, hour: 9, minute: 2, second: 42, millisecond: 436, kind: DateTimeKind.Local), new DateTime(year: 1933, month: 10, day: 1, hour: 21, minute: 46, second: 27, millisecond: 988, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1950, month: 10, day: 4, hour: 11, minute: 28, second: 4, millisecond: 951, kind: DateTimeKind.Local), new DateTime(year: 1966, month: 10, day: 3, hour: 10, minute: 11, second: 27, millisecond: 152, kind: DateTimeKind.Local), new DateTime(year: 1999, month: 10, day: 13, hour: 12, minute: 17, second: 41, millisecond: 130, kind: DateTimeKind.Local), }, { new DateTime(year: 1948, month: 10, day: 9, hour: 4, minute: 34, second: 32, millisecond: 793, kind: DateTimeKind.Local), new DateTime(year: 1930, month: 10, day: 7, hour: 19, minute: 13, second: 7, millisecond: 836, kind: DateTimeKind.Local), new DateTime(year: 1965, month: 10, day: 11, hour: 15, minute: 4, second: 43, millisecond: 366, kind: DateTimeKind.Local), }, { new DateTime(year: 1947, month: 10, day: 18, hour: 1, minute: 38, second: 27, millisecond: 813, kind: DateTimeKind.Local), new DateTime(year: 1955, month: 10, day: 10, hour: 10, minute: 8, second: 53, millisecond: 380, kind: DateTimeKind.Local), new DateTime(year: 1959, month: 10, day: 9, hour: 11, minute: 29, second: 4, millisecond: 91, kind: DateTimeKind.Local), }, }, },
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1945, month: 10, day: 16, hour: 13, minute: 31, second: 58, millisecond: 950, kind: DateTimeKind.Local), new DateTime(year: 1952, month: 10, day: 17, hour: 21, minute: 27, second: 23, millisecond: 503, kind: DateTimeKind.Local), new DateTime(year: 1986, month: 10, day: 14, hour: 19, minute: 17, second: 42, millisecond: 943, kind: DateTimeKind.Local), }, { new DateTime(year: 1935, month: 10, day: 11, hour: 6, minute: 55, second: 32, millisecond: 697, kind: DateTimeKind.Local), new DateTime(year: 1976, month: 10, day: 11, hour: 12, minute: 54, second: 9, millisecond: 332, kind: DateTimeKind.Local), new DateTime(year: 1920, month: 10, day: 14, hour: 1, minute: 23, second: 57, millisecond: 20, kind: DateTimeKind.Local), }, { new DateTime(year: 1979, month: 10, day: 18, hour: 1, minute: 6, second: 9, millisecond: 420, kind: DateTimeKind.Local), new DateTime(year: 1997, month: 10, day: 10, hour: 18, minute: 54, second: 30, millisecond: 382, kind: DateTimeKind.Local), new DateTime(year: 1957, month: 10, day: 18, hour: 14, minute: 22, second: 55, millisecond: 925, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 2005, month: 10, day: 7, hour: 12, minute: 16, second: 50, millisecond: 876, kind: DateTimeKind.Local), new DateTime(year: 1981, month: 10, day: 16, hour: 2, minute: 52, second: 9, millisecond: 812, kind: DateTimeKind.Local), new DateTime(year: 1943, month: 10, day: 10, hour: 8, minute: 19, second: 26, millisecond: 606, kind: DateTimeKind.Local), }, { new DateTime(year: 1991, month: 10, day: 6, hour: 22, minute: 29, second: 30, millisecond: 310, kind: DateTimeKind.Local), new DateTime(year: 1999, month: 10, day: 17, hour: 18, minute: 14, second: 57, millisecond: 239, kind: DateTimeKind.Local), new DateTime(year: 2009, month: 10, day: 6, hour: 4, minute: 4, second: 23, millisecond: 593, kind: DateTimeKind.Local), }, { new DateTime(year: 1964, month: 10, day: 1, hour: 19, minute: 43, second: 44, millisecond: 186, kind: DateTimeKind.Local), new DateTime(year: 1980, month: 10, day: 12, hour: 6, minute: 33, second: 47, millisecond: 718, kind: DateTimeKind.Local), new DateTime(year: 1986, month: 10, day: 14, hour: 14, minute: 48, second: 34, millisecond: 486, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1970, month: 10, day: 1, hour: 2, minute: 23, second: 43, millisecond: 681, kind: DateTimeKind.Local), new DateTime(year: 1951, month: 10, day: 6, hour: 15, minute: 25, second: 23, millisecond: 210, kind: DateTimeKind.Local), new DateTime(year: 2017, month: 10, day: 18, hour: 4, minute: 18, second: 26, millisecond: 293, kind: DateTimeKind.Local), }, { new DateTime(year: 1928, month: 10, day: 5, hour: 17, minute: 39, second: 30, millisecond: 741, kind: DateTimeKind.Local), new DateTime(year: 2006, month: 10, day: 2, hour: 20, minute: 38, second: 29, millisecond: 673, kind: DateTimeKind.Local), new DateTime(year: 2016, month: 10, day: 10, hour: 19, minute: 5, second: 31, millisecond: 61, kind: DateTimeKind.Local), }, { new DateTime(year: 1983, month: 10, day: 17, hour: 1, minute: 49, second: 10, millisecond: 130, kind: DateTimeKind.Local), new DateTime(year: 1964, month: 10, day: 7, hour: 17, minute: 12, second: 7, millisecond: 440, kind: DateTimeKind.Local), new DateTime(year: 2016, month: 10, day: 1, hour: 14, minute: 54, second: 31, millisecond: 7, kind: DateTimeKind.Local), }, }, },
},
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1977, month: 10, day: 9, hour: 1, minute: 27, second: 43, millisecond: 967, kind: DateTimeKind.Local), new DateTime(year: 2013, month: 10, day: 7, hour: 14, minute: 33, second: 52, millisecond: 299, kind: DateTimeKind.Local), new DateTime(year: 1999, month: 10, day: 1, hour: 10, minute: 25, second: 39, millisecond: 584, kind: DateTimeKind.Local), }, { new DateTime(year: 1971, month: 10, day: 1, hour: 1, minute: 58, second: 41, millisecond: 577, kind: DateTimeKind.Local), new DateTime(year: 1946, month: 10, day: 18, hour: 15, minute: 21, second: 22, millisecond: 563, kind: DateTimeKind.Local), new DateTime(year: 1944, month: 10, day: 14, hour: 2, minute: 31, second: 16, millisecond: 332, kind: DateTimeKind.Local), }, { new DateTime(year: 1992, month: 10, day: 2, hour: 16, minute: 41, second: 18, millisecond: 430, kind: DateTimeKind.Local), new DateTime(year: 1987, month: 10, day: 2, hour: 2, minute: 49, second: 30, millisecond: 306, kind: DateTimeKind.Local), new DateTime(year: 1964, month: 10, day: 4, hour: 13, minute: 10, second: 7, millisecond: 239, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1930, month: 10, day: 14, hour: 4, minute: 8, second: 25, millisecond: 312, kind: DateTimeKind.Local), new DateTime(year: 2014, month: 10, day: 4, hour: 19, minute: 24, second: 7, millisecond: 909, kind: DateTimeKind.Local), new DateTime(year: 1979, month: 10, day: 19, hour: 20, minute: 13, second: 11, millisecond: 459, kind: DateTimeKind.Local), }, { new DateTime(year: 1940, month: 10, day: 15, hour: 14, minute: 43, second: 14, millisecond: 479, kind: DateTimeKind.Local), new DateTime(year: 1983, month: 10, day: 4, hour: 2, minute: 49, second: 48, millisecond: 962, kind: DateTimeKind.Local), new DateTime(year: 1920, month: 10, day: 7, hour: 1, minute: 6, second: 27, millisecond: 49, kind: DateTimeKind.Local), }, { new DateTime(year: 1969, month: 10, day: 1, hour: 9, minute: 31, second: 36, millisecond: 232, kind: DateTimeKind.Local), new DateTime(year: 2005, month: 10, day: 17, hour: 5, minute: 26, second: 21, millisecond: 982, kind: DateTimeKind.Local), new DateTime(year: 1956, month: 10, day: 7, hour: 13, minute: 23, second: 23, millisecond: 571, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1981, month: 10, day: 13, hour: 22, minute: 40, second: 17, millisecond: 45, kind: DateTimeKind.Local), new DateTime(year: 2006, month: 10, day: 7, hour: 11, minute: 16, second: 27, millisecond: 107, kind: DateTimeKind.Local), new DateTime(year: 2018, month: 10, day: 19, hour: 18, minute: 18, second: 16, millisecond: 410, kind: DateTimeKind.Local), }, { new DateTime(year: 2000, month: 10, day: 5, hour: 14, minute: 27, second: 53, millisecond: 102, kind: DateTimeKind.Local), new DateTime(year: 1917, month: 10, day: 4, hour: 7, minute: 32, second: 2, millisecond: 164, kind: DateTimeKind.Local), new DateTime(year: 1965, month: 10, day: 16, hour: 14, minute: 45, second: 51, millisecond: 203, kind: DateTimeKind.Local), }, { new DateTime(year: 1947, month: 10, day: 17, hour: 2, minute: 7, second: 5, millisecond: 758, kind: DateTimeKind.Local), new DateTime(year: 1949, month: 10, day: 5, hour: 15, minute: 23, second: 4, millisecond: 517, kind: DateTimeKind.Local), new DateTime(year: 2006, month: 10, day: 6, hour: 12, minute: 58, second: 37, millisecond: 57, kind: DateTimeKind.Local), }, }, },
},
            new DateTimetimestamp_without_time_zoneMMArrayD3E1M
{
    Id = 86,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1946, month: 10, day: 4, hour: 8, minute: 26, second: 39, millisecond: 790, kind: DateTimeKind.Local), new DateTime(year: 1948, month: 10, day: 4, hour: 16, minute: 53, second: 43, millisecond: 103, kind: DateTimeKind.Local), new DateTime(year: 1998, month: 10, day: 11, hour: 5, minute: 35, second: 3, millisecond: 768, kind: DateTimeKind.Local), }, { new DateTime(year: 1996, month: 10, day: 15, hour: 20, minute: 35, second: 57, millisecond: 575, kind: DateTimeKind.Local), new DateTime(year: 1956, month: 10, day: 16, hour: 21, minute: 52, second: 51, millisecond: 432, kind: DateTimeKind.Local), new DateTime(year: 1948, month: 10, day: 6, hour: 1, minute: 14, second: 30, millisecond: 502, kind: DateTimeKind.Local), }, { new DateTime(year: 2005, month: 10, day: 11, hour: 4, minute: 57, second: 48, millisecond: 950, kind: DateTimeKind.Local), new DateTime(year: 1969, month: 10, day: 10, hour: 22, minute: 24, second: 55, millisecond: 597, kind: DateTimeKind.Local), new DateTime(year: 1942, month: 10, day: 13, hour: 10, minute: 13, second: 3, millisecond: 202, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1985, month: 10, day: 5, hour: 13, minute: 25, second: 39, millisecond: 762, kind: DateTimeKind.Local), new DateTime(year: 1929, month: 10, day: 11, hour: 18, minute: 26, second: 54, millisecond: 44, kind: DateTimeKind.Local), new DateTime(year: 1965, month: 10, day: 13, hour: 13, minute: 46, second: 18, millisecond: 463, kind: DateTimeKind.Local), }, { new DateTime(year: 1945, month: 10, day: 16, hour: 12, minute: 53, second: 55, millisecond: 224, kind: DateTimeKind.Local), new DateTime(year: 2002, month: 10, day: 12, hour: 13, minute: 24, second: 50, millisecond: 556, kind: DateTimeKind.Local), new DateTime(year: 1953, month: 10, day: 18, hour: 18, minute: 16, second: 29, millisecond: 343, kind: DateTimeKind.Local), }, { new DateTime(year: 1920, month: 10, day: 3, hour: 9, minute: 6, second: 40, millisecond: 310, kind: DateTimeKind.Local), new DateTime(year: 1926, month: 10, day: 4, hour: 4, minute: 1, second: 34, millisecond: 681, kind: DateTimeKind.Local), new DateTime(year: 1998, month: 10, day: 18, hour: 5, minute: 24, second: 6, millisecond: 536, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1927, month: 10, day: 9, hour: 12, minute: 27, second: 56, millisecond: 726, kind: DateTimeKind.Local), new DateTime(year: 2005, month: 10, day: 10, hour: 11, minute: 9, second: 18, millisecond: 965, kind: DateTimeKind.Local), new DateTime(year: 1974, month: 10, day: 10, hour: 2, minute: 1, second: 35, millisecond: 865, kind: DateTimeKind.Local), }, { new DateTime(year: 1933, month: 10, day: 13, hour: 19, minute: 56, second: 41, millisecond: 66, kind: DateTimeKind.Local), new DateTime(year: 2007, month: 10, day: 1, hour: 20, minute: 27, second: 44, millisecond: 925, kind: DateTimeKind.Local), new DateTime(year: 1971, month: 10, day: 19, hour: 18, minute: 48, second: 55, millisecond: 116, kind: DateTimeKind.Local), }, { new DateTime(year: 1966, month: 10, day: 1, hour: 5, minute: 47, second: 3, millisecond: 907, kind: DateTimeKind.Local), new DateTime(year: 2017, month: 10, day: 3, hour: 21, minute: 54, second: 32, millisecond: 579, kind: DateTimeKind.Local), new DateTime(year: 1966, month: 10, day: 2, hour: 18, minute: 11, second: 19, millisecond: 326, kind: DateTimeKind.Local), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneMMArrayD3E1M
{
    Id = 87,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1989, month: 10, day: 17, hour: 12, minute: 13, second: 1, millisecond: 847, kind: DateTimeKind.Local), new DateTime(year: 2007, month: 10, day: 11, hour: 14, minute: 14, second: 52, millisecond: 947, kind: DateTimeKind.Local), new DateTime(year: 1923, month: 10, day: 6, hour: 12, minute: 5, second: 24, millisecond: 826, kind: DateTimeKind.Local), }, { new DateTime(year: 2006, month: 10, day: 11, hour: 12, minute: 34, second: 24, millisecond: 473, kind: DateTimeKind.Local), new DateTime(year: 1921, month: 10, day: 4, hour: 15, minute: 24, second: 20, millisecond: 919, kind: DateTimeKind.Local), new DateTime(year: 1938, month: 10, day: 12, hour: 20, minute: 24, second: 52, millisecond: 515, kind: DateTimeKind.Local), }, { new DateTime(year: 1994, month: 10, day: 16, hour: 11, minute: 10, second: 50, millisecond: 668, kind: DateTimeKind.Local), new DateTime(year: 1949, month: 10, day: 6, hour: 4, minute: 29, second: 30, millisecond: 490, kind: DateTimeKind.Local), new DateTime(year: 1949, month: 10, day: 6, hour: 8, minute: 26, second: 49, millisecond: 90, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 2011, month: 10, day: 4, hour: 21, minute: 19, second: 51, millisecond: 350, kind: DateTimeKind.Local), new DateTime(year: 1926, month: 10, day: 2, hour: 22, minute: 35, second: 51, millisecond: 387, kind: DateTimeKind.Local), new DateTime(year: 1946, month: 10, day: 9, hour: 12, minute: 53, second: 8, millisecond: 916, kind: DateTimeKind.Local), }, { new DateTime(year: 1980, month: 10, day: 16, hour: 3, minute: 32, second: 45, millisecond: 531, kind: DateTimeKind.Local), new DateTime(year: 1921, month: 10, day: 14, hour: 9, minute: 58, second: 12, millisecond: 221, kind: DateTimeKind.Local), new DateTime(year: 1988, month: 10, day: 16, hour: 11, minute: 9, second: 52, millisecond: 403, kind: DateTimeKind.Local), }, { new DateTime(year: 2008, month: 10, day: 15, hour: 17, minute: 11, second: 37, millisecond: 829, kind: DateTimeKind.Local), new DateTime(year: 1981, month: 10, day: 15, hour: 8, minute: 26, second: 43, millisecond: 363, kind: DateTimeKind.Local), new DateTime(year: 2004, month: 10, day: 13, hour: 11, minute: 11, second: 54, millisecond: 432, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1961, month: 10, day: 15, hour: 2, minute: 49, second: 54, millisecond: 889, kind: DateTimeKind.Local), new DateTime(year: 1989, month: 10, day: 12, hour: 18, minute: 5, second: 40, millisecond: 205, kind: DateTimeKind.Local), new DateTime(year: 1976, month: 10, day: 7, hour: 9, minute: 22, second: 49, millisecond: 367, kind: DateTimeKind.Local), }, { new DateTime(year: 1949, month: 10, day: 1, hour: 1, minute: 12, second: 54, millisecond: 104, kind: DateTimeKind.Local), new DateTime(year: 1970, month: 10, day: 15, hour: 15, minute: 15, second: 37, millisecond: 91, kind: DateTimeKind.Local), new DateTime(year: 1970, month: 10, day: 9, hour: 9, minute: 13, second: 11, millisecond: 570, kind: DateTimeKind.Local), }, { new DateTime(year: 1936, month: 10, day: 9, hour: 13, minute: 44, second: 19, millisecond: 889, kind: DateTimeKind.Local), new DateTime(year: 2012, month: 10, day: 16, hour: 4, minute: 53, second: 16, millisecond: 676, kind: DateTimeKind.Local), new DateTime(year: 1943, month: 10, day: 8, hour: 15, minute: 50, second: 2, millisecond: 772, kind: DateTimeKind.Local), }, }, },
    ModelInner = new DateTimetimestamp_without_time_zoneMMArrayD3E1MI
{
    Id = 44,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1997, month: 10, day: 5, hour: 12, minute: 35, second: 52, millisecond: 323, kind: DateTimeKind.Local), new DateTime(year: 1936, month: 10, day: 9, hour: 16, minute: 19, second: 37, millisecond: 792, kind: DateTimeKind.Local), new DateTime(year: 2017, month: 10, day: 19, hour: 22, minute: 27, second: 30, millisecond: 653, kind: DateTimeKind.Local), }, { new DateTime(year: 1987, month: 10, day: 10, hour: 18, minute: 32, second: 27, millisecond: 238, kind: DateTimeKind.Local), new DateTime(year: 2016, month: 10, day: 18, hour: 3, minute: 44, second: 57, millisecond: 127, kind: DateTimeKind.Local), new DateTime(year: 2004, month: 10, day: 10, hour: 2, minute: 4, second: 23, millisecond: 890, kind: DateTimeKind.Local), }, { new DateTime(year: 1977, month: 10, day: 18, hour: 11, minute: 10, second: 21, millisecond: 557, kind: DateTimeKind.Local), new DateTime(year: 1996, month: 10, day: 18, hour: 4, minute: 15, second: 53, millisecond: 409, kind: DateTimeKind.Local), new DateTime(year: 1965, month: 10, day: 15, hour: 7, minute: 6, second: 31, millisecond: 57, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1941, month: 10, day: 7, hour: 18, minute: 29, second: 56, millisecond: 877, kind: DateTimeKind.Local), new DateTime(year: 2017, month: 10, day: 1, hour: 11, minute: 30, second: 8, millisecond: 713, kind: DateTimeKind.Local), new DateTime(year: 1931, month: 10, day: 5, hour: 20, minute: 56, second: 6, millisecond: 889, kind: DateTimeKind.Local), }, { new DateTime(year: 1996, month: 10, day: 3, hour: 17, minute: 58, second: 18, millisecond: 673, kind: DateTimeKind.Local), new DateTime(year: 1933, month: 10, day: 4, hour: 16, minute: 10, second: 43, millisecond: 841, kind: DateTimeKind.Local), new DateTime(year: 1948, month: 10, day: 6, hour: 13, minute: 43, second: 44, millisecond: 537, kind: DateTimeKind.Local), }, { new DateTime(year: 1987, month: 10, day: 15, hour: 6, minute: 38, second: 52, millisecond: 9, kind: DateTimeKind.Local), new DateTime(year: 2005, month: 10, day: 18, hour: 2, minute: 45, second: 56, millisecond: 26, kind: DateTimeKind.Local), new DateTime(year: 1919, month: 10, day: 12, hour: 11, minute: 57, second: 19, millisecond: 122, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1930, month: 10, day: 5, hour: 18, minute: 22, second: 32, millisecond: 102, kind: DateTimeKind.Local), new DateTime(year: 1936, month: 10, day: 19, hour: 21, minute: 28, second: 16, millisecond: 501, kind: DateTimeKind.Local), new DateTime(year: 1990, month: 10, day: 7, hour: 12, minute: 1, second: 10, millisecond: 492, kind: DateTimeKind.Local), }, { new DateTime(year: 1986, month: 10, day: 16, hour: 16, minute: 12, second: 13, millisecond: 248, kind: DateTimeKind.Local), new DateTime(year: 2001, month: 10, day: 13, hour: 16, minute: 32, second: 31, millisecond: 126, kind: DateTimeKind.Local), new DateTime(year: 2008, month: 10, day: 8, hour: 16, minute: 31, second: 5, millisecond: 595, kind: DateTimeKind.Local), }, { new DateTime(year: 1998, month: 10, day: 1, hour: 20, minute: 1, second: 19, millisecond: 73, kind: DateTimeKind.Local), new DateTime(year: 1932, month: 10, day: 11, hour: 5, minute: 58, second: 5, millisecond: 607, kind: DateTimeKind.Local), new DateTime(year: 1942, month: 10, day: 11, hour: 3, minute: 25, second: 53, millisecond: 440, kind: DateTimeKind.Local), }, }, },
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1993, month: 10, day: 7, hour: 22, minute: 28, second: 2, millisecond: 862, kind: DateTimeKind.Local), new DateTime(year: 1925, month: 10, day: 16, hour: 6, minute: 55, second: 13, millisecond: 97, kind: DateTimeKind.Local), new DateTime(year: 1932, month: 10, day: 12, hour: 19, minute: 30, second: 28, millisecond: 695, kind: DateTimeKind.Local), }, { new DateTime(year: 1992, month: 10, day: 13, hour: 11, minute: 45, second: 3, millisecond: 55, kind: DateTimeKind.Local), new DateTime(year: 1964, month: 10, day: 8, hour: 3, minute: 51, second: 38, millisecond: 571, kind: DateTimeKind.Local), new DateTime(year: 1917, month: 10, day: 5, hour: 17, minute: 44, second: 20, millisecond: 145, kind: DateTimeKind.Local), }, { new DateTime(year: 1965, month: 10, day: 16, hour: 10, minute: 29, second: 19, millisecond: 265, kind: DateTimeKind.Local), new DateTime(year: 1988, month: 10, day: 2, hour: 18, minute: 54, second: 47, millisecond: 316, kind: DateTimeKind.Local), new DateTime(year: 1965, month: 10, day: 14, hour: 12, minute: 29, second: 48, millisecond: 204, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1926, month: 10, day: 7, hour: 16, minute: 39, second: 47, millisecond: 80, kind: DateTimeKind.Local), new DateTime(year: 1932, month: 10, day: 15, hour: 3, minute: 40, second: 40, millisecond: 669, kind: DateTimeKind.Local), new DateTime(year: 1999, month: 10, day: 6, hour: 9, minute: 37, second: 29, millisecond: 462, kind: DateTimeKind.Local), }, { new DateTime(year: 1981, month: 10, day: 18, hour: 6, minute: 50, second: 17, millisecond: 578, kind: DateTimeKind.Local), new DateTime(year: 1999, month: 10, day: 12, hour: 3, minute: 24, second: 11, millisecond: 142, kind: DateTimeKind.Local), new DateTime(year: 1941, month: 10, day: 7, hour: 1, minute: 38, second: 54, millisecond: 933, kind: DateTimeKind.Local), }, { new DateTime(year: 1989, month: 10, day: 13, hour: 6, minute: 33, second: 43, millisecond: 68, kind: DateTimeKind.Local), new DateTime(year: 1971, month: 10, day: 4, hour: 19, minute: 18, second: 40, millisecond: 646, kind: DateTimeKind.Local), new DateTime(year: 1919, month: 10, day: 10, hour: 1, minute: 40, second: 2, millisecond: 509, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1952, month: 10, day: 10, hour: 21, minute: 11, second: 37, millisecond: 977, kind: DateTimeKind.Local), new DateTime(year: 1953, month: 10, day: 16, hour: 6, minute: 18, second: 17, millisecond: 419, kind: DateTimeKind.Local), new DateTime(year: 1944, month: 10, day: 6, hour: 15, minute: 58, second: 48, millisecond: 519, kind: DateTimeKind.Local), }, { new DateTime(year: 1973, month: 10, day: 5, hour: 20, minute: 9, second: 33, millisecond: 856, kind: DateTimeKind.Local), new DateTime(year: 1946, month: 10, day: 7, hour: 4, minute: 1, second: 30, millisecond: 175, kind: DateTimeKind.Local), new DateTime(year: 1937, month: 10, day: 14, hour: 6, minute: 49, second: 41, millisecond: 8, kind: DateTimeKind.Local), }, { new DateTime(year: 1967, month: 10, day: 17, hour: 15, minute: 17, second: 50, millisecond: 606, kind: DateTimeKind.Local), new DateTime(year: 1944, month: 10, day: 8, hour: 2, minute: 44, second: 21, millisecond: 282, kind: DateTimeKind.Local), new DateTime(year: 2017, month: 10, day: 14, hour: 12, minute: 5, second: 7, millisecond: 903, kind: DateTimeKind.Local), }, }, },
},
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 2000, month: 10, day: 2, hour: 6, minute: 40, second: 38, millisecond: 81, kind: DateTimeKind.Local), new DateTime(year: 1925, month: 10, day: 19, hour: 13, minute: 50, second: 7, millisecond: 413, kind: DateTimeKind.Local), new DateTime(year: 1989, month: 10, day: 7, hour: 20, minute: 19, second: 7, millisecond: 755, kind: DateTimeKind.Local), }, { new DateTime(year: 1928, month: 10, day: 19, hour: 15, minute: 57, second: 26, millisecond: 717, kind: DateTimeKind.Local), new DateTime(year: 1926, month: 10, day: 9, hour: 12, minute: 27, second: 30, millisecond: 770, kind: DateTimeKind.Local), new DateTime(year: 1994, month: 10, day: 10, hour: 3, minute: 16, second: 54, millisecond: 237, kind: DateTimeKind.Local), }, { new DateTime(year: 1934, month: 10, day: 7, hour: 1, minute: 9, second: 17, millisecond: 954, kind: DateTimeKind.Local), new DateTime(year: 1999, month: 10, day: 4, hour: 1, minute: 36, second: 30, millisecond: 570, kind: DateTimeKind.Local), new DateTime(year: 1977, month: 10, day: 15, hour: 5, minute: 42, second: 35, millisecond: 177, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1972, month: 10, day: 8, hour: 4, minute: 54, second: 42, millisecond: 618, kind: DateTimeKind.Local), new DateTime(year: 1992, month: 10, day: 10, hour: 1, minute: 6, second: 34, millisecond: 375, kind: DateTimeKind.Local), new DateTime(year: 2004, month: 10, day: 4, hour: 5, minute: 41, second: 17, millisecond: 789, kind: DateTimeKind.Local), }, { new DateTime(year: 1982, month: 10, day: 3, hour: 8, minute: 52, second: 36, millisecond: 725, kind: DateTimeKind.Local), new DateTime(year: 1929, month: 10, day: 5, hour: 2, minute: 21, second: 13, millisecond: 261, kind: DateTimeKind.Local), new DateTime(year: 1945, month: 10, day: 8, hour: 10, minute: 16, second: 15, millisecond: 930, kind: DateTimeKind.Local), }, { new DateTime(year: 2003, month: 10, day: 19, hour: 11, minute: 38, second: 48, millisecond: 660, kind: DateTimeKind.Local), new DateTime(year: 2007, month: 10, day: 3, hour: 7, minute: 5, second: 40, millisecond: 914, kind: DateTimeKind.Local), new DateTime(year: 1976, month: 10, day: 15, hour: 5, minute: 48, second: 50, millisecond: 689, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 2008, month: 10, day: 6, hour: 12, minute: 50, second: 9, millisecond: 800, kind: DateTimeKind.Local), new DateTime(year: 1969, month: 10, day: 9, hour: 5, minute: 32, second: 14, millisecond: 406, kind: DateTimeKind.Local), new DateTime(year: 1920, month: 10, day: 15, hour: 6, minute: 49, second: 37, millisecond: 455, kind: DateTimeKind.Local), }, { new DateTime(year: 2001, month: 10, day: 4, hour: 20, minute: 49, second: 50, millisecond: 348, kind: DateTimeKind.Local), new DateTime(year: 1974, month: 10, day: 16, hour: 22, minute: 16, second: 21, millisecond: 821, kind: DateTimeKind.Local), new DateTime(year: 1970, month: 10, day: 8, hour: 5, minute: 8, second: 42, millisecond: 289, kind: DateTimeKind.Local), }, { new DateTime(year: 2012, month: 10, day: 5, hour: 13, minute: 24, second: 5, millisecond: 712, kind: DateTimeKind.Local), new DateTime(year: 1949, month: 10, day: 3, hour: 11, minute: 7, second: 40, millisecond: 845, kind: DateTimeKind.Local), new DateTime(year: 1934, month: 10, day: 11, hour: 8, minute: 45, second: 14, millisecond: 626, kind: DateTimeKind.Local), }, }, },
},
            new DateTimetimestamp_without_time_zoneMMArrayD3E1M
{
    Id = 93,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1960, month: 10, day: 13, hour: 3, minute: 31, second: 2, millisecond: 561, kind: DateTimeKind.Local), new DateTime(year: 1989, month: 10, day: 1, hour: 20, minute: 18, second: 50, millisecond: 482, kind: DateTimeKind.Local), new DateTime(year: 1924, month: 10, day: 15, hour: 16, minute: 57, second: 2, millisecond: 567, kind: DateTimeKind.Local), }, { new DateTime(year: 2019, month: 10, day: 19, hour: 2, minute: 16, second: 6, millisecond: 81, kind: DateTimeKind.Local), new DateTime(year: 1968, month: 10, day: 6, hour: 14, minute: 49, second: 1, millisecond: 49, kind: DateTimeKind.Local), new DateTime(year: 1919, month: 10, day: 14, hour: 7, minute: 25, second: 30, millisecond: 108, kind: DateTimeKind.Local), }, { new DateTime(year: 1964, month: 10, day: 6, hour: 1, minute: 35, second: 40, millisecond: 10, kind: DateTimeKind.Local), new DateTime(year: 1925, month: 10, day: 4, hour: 21, minute: 44, second: 11, millisecond: 988, kind: DateTimeKind.Local), new DateTime(year: 1934, month: 10, day: 15, hour: 14, minute: 51, second: 23, millisecond: 350, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1987, month: 10, day: 17, hour: 14, minute: 15, second: 17, millisecond: 12, kind: DateTimeKind.Local), new DateTime(year: 2004, month: 10, day: 16, hour: 5, minute: 12, second: 4, millisecond: 742, kind: DateTimeKind.Local), new DateTime(year: 2014, month: 10, day: 18, hour: 16, minute: 17, second: 5, millisecond: 132, kind: DateTimeKind.Local), }, { new DateTime(year: 1963, month: 10, day: 17, hour: 8, minute: 8, second: 34, millisecond: 680, kind: DateTimeKind.Local), new DateTime(year: 2017, month: 10, day: 6, hour: 12, minute: 53, second: 40, millisecond: 925, kind: DateTimeKind.Local), new DateTime(year: 1997, month: 10, day: 19, hour: 20, minute: 31, second: 46, millisecond: 82, kind: DateTimeKind.Local), }, { new DateTime(year: 2004, month: 10, day: 19, hour: 10, minute: 33, second: 43, millisecond: 679, kind: DateTimeKind.Local), new DateTime(year: 1972, month: 10, day: 5, hour: 17, minute: 49, second: 12, millisecond: 979, kind: DateTimeKind.Local), new DateTime(year: 1979, month: 10, day: 9, hour: 11, minute: 42, second: 49, millisecond: 236, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1974, month: 10, day: 13, hour: 22, minute: 1, second: 45, millisecond: 464, kind: DateTimeKind.Local), new DateTime(year: 2007, month: 10, day: 3, hour: 5, minute: 39, second: 48, millisecond: 313, kind: DateTimeKind.Local), new DateTime(year: 1979, month: 10, day: 3, hour: 15, minute: 58, second: 12, millisecond: 271, kind: DateTimeKind.Local), }, { new DateTime(year: 1969, month: 10, day: 10, hour: 18, minute: 1, second: 28, millisecond: 510, kind: DateTimeKind.Local), new DateTime(year: 1955, month: 10, day: 3, hour: 2, minute: 53, second: 10, millisecond: 419, kind: DateTimeKind.Local), new DateTime(year: 2009, month: 10, day: 7, hour: 22, minute: 41, second: 26, millisecond: 887, kind: DateTimeKind.Local), }, { new DateTime(year: 1929, month: 10, day: 9, hour: 13, minute: 17, second: 22, millisecond: 608, kind: DateTimeKind.Local), new DateTime(year: 1954, month: 10, day: 1, hour: 4, minute: 56, second: 25, millisecond: 555, kind: DateTimeKind.Local), new DateTime(year: 2008, month: 10, day: 4, hour: 17, minute: 9, second: 54, millisecond: 122, kind: DateTimeKind.Local), }, }, },
    ModelInner = null,
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 2007, month: 10, day: 15, hour: 12, minute: 42, second: 30, millisecond: 42, kind: DateTimeKind.Local), new DateTime(year: 2019, month: 10, day: 16, hour: 5, minute: 14, second: 20, millisecond: 926, kind: DateTimeKind.Local), new DateTime(year: 1990, month: 10, day: 14, hour: 21, minute: 34, second: 20, millisecond: 929, kind: DateTimeKind.Local), }, { new DateTime(year: 1968, month: 10, day: 8, hour: 19, minute: 14, second: 34, millisecond: 444, kind: DateTimeKind.Local), new DateTime(year: 2006, month: 10, day: 13, hour: 4, minute: 1, second: 3, millisecond: 77, kind: DateTimeKind.Local), new DateTime(year: 1989, month: 10, day: 7, hour: 20, minute: 49, second: 23, millisecond: 920, kind: DateTimeKind.Local), }, { new DateTime(year: 1952, month: 10, day: 14, hour: 12, minute: 56, second: 58, millisecond: 239, kind: DateTimeKind.Local), new DateTime(year: 1917, month: 10, day: 9, hour: 18, minute: 6, second: 18, millisecond: 698, kind: DateTimeKind.Local), new DateTime(year: 2002, month: 10, day: 8, hour: 4, minute: 57, second: 37, millisecond: 464, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1958, month: 10, day: 17, hour: 14, minute: 2, second: 3, millisecond: 366, kind: DateTimeKind.Local), new DateTime(year: 2013, month: 10, day: 10, hour: 16, minute: 36, second: 3, millisecond: 619, kind: DateTimeKind.Local), new DateTime(year: 1931, month: 10, day: 17, hour: 15, minute: 9, second: 17, millisecond: 267, kind: DateTimeKind.Local), }, { new DateTime(year: 1931, month: 10, day: 17, hour: 3, minute: 12, second: 21, millisecond: 688, kind: DateTimeKind.Local), new DateTime(year: 1959, month: 10, day: 16, hour: 1, minute: 7, second: 31, millisecond: 531, kind: DateTimeKind.Local), new DateTime(year: 1993, month: 10, day: 2, hour: 21, minute: 54, second: 10, millisecond: 575, kind: DateTimeKind.Local), }, { new DateTime(year: 1980, month: 10, day: 10, hour: 4, minute: 9, second: 15, millisecond: 203, kind: DateTimeKind.Local), new DateTime(year: 1952, month: 10, day: 19, hour: 20, minute: 54, second: 50, millisecond: 637, kind: DateTimeKind.Local), new DateTime(year: 1923, month: 10, day: 6, hour: 19, minute: 42, second: 23, millisecond: 458, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1918, month: 10, day: 6, hour: 20, minute: 16, second: 22, millisecond: 97, kind: DateTimeKind.Local), new DateTime(year: 1934, month: 10, day: 2, hour: 3, minute: 51, second: 51, millisecond: 494, kind: DateTimeKind.Local), new DateTime(year: 1930, month: 10, day: 11, hour: 1, minute: 44, second: 54, millisecond: 765, kind: DateTimeKind.Local), }, { new DateTime(year: 2012, month: 10, day: 3, hour: 15, minute: 54, second: 2, millisecond: 614, kind: DateTimeKind.Local), new DateTime(year: 1995, month: 10, day: 19, hour: 11, minute: 55, second: 30, millisecond: 526, kind: DateTimeKind.Local), new DateTime(year: 1999, month: 10, day: 11, hour: 20, minute: 41, second: 39, millisecond: 355, kind: DateTimeKind.Local), }, { new DateTime(year: 2008, month: 10, day: 3, hour: 21, minute: 41, second: 25, millisecond: 763, kind: DateTimeKind.Local), new DateTime(year: 1940, month: 10, day: 17, hour: 11, minute: 35, second: 14, millisecond: 140, kind: DateTimeKind.Local), new DateTime(year: 1982, month: 10, day: 12, hour: 13, minute: 27, second: 44, millisecond: 917, kind: DateTimeKind.Local), }, }, },
},
            new DateTimetimestamp_without_time_zoneMMArrayD3E1M
{
    Id = 96,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1994, month: 10, day: 10, hour: 7, minute: 3, second: 34, millisecond: 302, kind: DateTimeKind.Local), new DateTime(year: 1949, month: 10, day: 15, hour: 5, minute: 1, second: 7, millisecond: 130, kind: DateTimeKind.Local), new DateTime(year: 1967, month: 10, day: 13, hour: 17, minute: 5, second: 2, millisecond: 469, kind: DateTimeKind.Local), }, { new DateTime(year: 1930, month: 10, day: 7, hour: 4, minute: 46, second: 34, millisecond: 273, kind: DateTimeKind.Local), new DateTime(year: 1980, month: 10, day: 9, hour: 16, minute: 37, second: 14, millisecond: 34, kind: DateTimeKind.Local), new DateTime(year: 2014, month: 10, day: 19, hour: 18, minute: 35, second: 3, millisecond: 470, kind: DateTimeKind.Local), }, { new DateTime(year: 1931, month: 10, day: 13, hour: 10, minute: 19, second: 5, millisecond: 328, kind: DateTimeKind.Local), new DateTime(year: 1961, month: 10, day: 6, hour: 13, minute: 52, second: 37, millisecond: 158, kind: DateTimeKind.Local), new DateTime(year: 1937, month: 10, day: 15, hour: 20, minute: 2, second: 1, millisecond: 632, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1922, month: 10, day: 11, hour: 1, minute: 48, second: 33, millisecond: 909, kind: DateTimeKind.Local), new DateTime(year: 2006, month: 10, day: 2, hour: 15, minute: 16, second: 12, millisecond: 61, kind: DateTimeKind.Local), new DateTime(year: 1936, month: 10, day: 14, hour: 6, minute: 47, second: 18, millisecond: 771, kind: DateTimeKind.Local), }, { new DateTime(year: 1943, month: 10, day: 4, hour: 21, minute: 5, second: 16, millisecond: 270, kind: DateTimeKind.Local), new DateTime(year: 2015, month: 10, day: 18, hour: 17, minute: 36, second: 40, millisecond: 650, kind: DateTimeKind.Local), new DateTime(year: 1918, month: 10, day: 15, hour: 10, minute: 49, second: 36, millisecond: 366, kind: DateTimeKind.Local), }, { new DateTime(year: 1971, month: 10, day: 18, hour: 6, minute: 37, second: 5, millisecond: 838, kind: DateTimeKind.Local), new DateTime(year: 1990, month: 10, day: 17, hour: 9, minute: 27, second: 21, millisecond: 413, kind: DateTimeKind.Local), new DateTime(year: 1947, month: 10, day: 19, hour: 17, minute: 16, second: 56, millisecond: 862, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1941, month: 10, day: 9, hour: 5, minute: 46, second: 57, millisecond: 623, kind: DateTimeKind.Local), new DateTime(year: 1958, month: 10, day: 12, hour: 8, minute: 42, second: 13, millisecond: 903, kind: DateTimeKind.Local), new DateTime(year: 1980, month: 10, day: 19, hour: 18, minute: 15, second: 51, millisecond: 626, kind: DateTimeKind.Local), }, { new DateTime(year: 1923, month: 10, day: 11, hour: 2, minute: 42, second: 56, millisecond: 17, kind: DateTimeKind.Local), new DateTime(year: 1991, month: 10, day: 13, hour: 2, minute: 1, second: 13, millisecond: 135, kind: DateTimeKind.Local), new DateTime(year: 2002, month: 10, day: 14, hour: 16, minute: 50, second: 47, millisecond: 534, kind: DateTimeKind.Local), }, { new DateTime(year: 1993, month: 10, day: 2, hour: 18, minute: 36, second: 54, millisecond: 551, kind: DateTimeKind.Local), new DateTime(year: 1997, month: 10, day: 6, hour: 18, minute: 10, second: 20, millisecond: 404, kind: DateTimeKind.Local), new DateTime(year: 1948, month: 10, day: 7, hour: 21, minute: 23, second: 51, millisecond: 488, kind: DateTimeKind.Local), }, }, },
    ModelInner = new DateTimetimestamp_without_time_zoneMMArrayD3E1MI
{
    Id = 47,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1992, month: 10, day: 4, hour: 11, minute: 38, second: 45, millisecond: 236, kind: DateTimeKind.Local), new DateTime(year: 1931, month: 10, day: 15, hour: 18, minute: 4, second: 21, millisecond: 132, kind: DateTimeKind.Local), new DateTime(year: 2002, month: 10, day: 1, hour: 17, minute: 26, second: 54, millisecond: 387, kind: DateTimeKind.Local), }, { new DateTime(year: 1979, month: 10, day: 15, hour: 1, minute: 47, second: 29, millisecond: 306, kind: DateTimeKind.Local), new DateTime(year: 1951, month: 10, day: 10, hour: 22, minute: 30, second: 34, millisecond: 717, kind: DateTimeKind.Local), new DateTime(year: 1974, month: 10, day: 15, hour: 14, minute: 53, second: 55, millisecond: 48, kind: DateTimeKind.Local), }, { new DateTime(year: 1979, month: 10, day: 8, hour: 18, minute: 51, second: 29, millisecond: 267, kind: DateTimeKind.Local), new DateTime(year: 1967, month: 10, day: 14, hour: 8, minute: 40, second: 42, millisecond: 123, kind: DateTimeKind.Local), new DateTime(year: 1941, month: 10, day: 2, hour: 1, minute: 57, second: 34, millisecond: 944, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1980, month: 10, day: 11, hour: 21, minute: 14, second: 2, millisecond: 847, kind: DateTimeKind.Local), new DateTime(year: 1944, month: 10, day: 3, hour: 2, minute: 35, second: 25, millisecond: 265, kind: DateTimeKind.Local), new DateTime(year: 1942, month: 10, day: 3, hour: 19, minute: 15, second: 43, millisecond: 152, kind: DateTimeKind.Local), }, { new DateTime(year: 1973, month: 10, day: 10, hour: 2, minute: 43, second: 24, millisecond: 786, kind: DateTimeKind.Local), new DateTime(year: 1971, month: 10, day: 10, hour: 1, minute: 4, second: 14, millisecond: 950, kind: DateTimeKind.Local), new DateTime(year: 1962, month: 10, day: 17, hour: 15, minute: 49, second: 10, millisecond: 84, kind: DateTimeKind.Local), }, { new DateTime(year: 2007, month: 10, day: 11, hour: 5, minute: 18, second: 6, millisecond: 980, kind: DateTimeKind.Local), new DateTime(year: 2015, month: 10, day: 3, hour: 22, minute: 30, second: 39, millisecond: 399, kind: DateTimeKind.Local), new DateTime(year: 1952, month: 10, day: 6, hour: 4, minute: 14, second: 23, millisecond: 61, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1991, month: 10, day: 14, hour: 15, minute: 51, second: 22, millisecond: 145, kind: DateTimeKind.Local), new DateTime(year: 1934, month: 10, day: 17, hour: 4, minute: 38, second: 43, millisecond: 688, kind: DateTimeKind.Local), new DateTime(year: 2008, month: 10, day: 1, hour: 6, minute: 4, second: 58, millisecond: 158, kind: DateTimeKind.Local), }, { new DateTime(year: 1985, month: 10, day: 11, hour: 10, minute: 26, second: 5, millisecond: 581, kind: DateTimeKind.Local), new DateTime(year: 1942, month: 10, day: 15, hour: 16, minute: 31, second: 40, millisecond: 99, kind: DateTimeKind.Local), new DateTime(year: 1945, month: 10, day: 18, hour: 8, minute: 53, second: 4, millisecond: 329, kind: DateTimeKind.Local), }, { new DateTime(year: 1961, month: 10, day: 3, hour: 17, minute: 41, second: 10, millisecond: 98, kind: DateTimeKind.Local), new DateTime(year: 1982, month: 10, day: 2, hour: 20, minute: 33, second: 20, millisecond: 227, kind: DateTimeKind.Local), new DateTime(year: 1947, month: 10, day: 5, hour: 19, minute: 40, second: 57, millisecond: 961, kind: DateTimeKind.Local), }, }, },
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1936, month: 10, day: 9, hour: 8, minute: 25, second: 41, millisecond: 502, kind: DateTimeKind.Local), new DateTime(year: 1976, month: 10, day: 18, hour: 13, minute: 31, second: 4, millisecond: 29, kind: DateTimeKind.Local), new DateTime(year: 2018, month: 10, day: 3, hour: 17, minute: 5, second: 1, millisecond: 86, kind: DateTimeKind.Local), }, { new DateTime(year: 1939, month: 10, day: 13, hour: 7, minute: 21, second: 35, millisecond: 756, kind: DateTimeKind.Local), new DateTime(year: 1926, month: 10, day: 13, hour: 20, minute: 47, second: 51, millisecond: 467, kind: DateTimeKind.Local), new DateTime(year: 1927, month: 10, day: 7, hour: 10, minute: 56, second: 41, millisecond: 336, kind: DateTimeKind.Local), }, { new DateTime(year: 2007, month: 10, day: 11, hour: 11, minute: 8, second: 11, millisecond: 830, kind: DateTimeKind.Local), new DateTime(year: 1957, month: 10, day: 14, hour: 16, minute: 7, second: 45, millisecond: 930, kind: DateTimeKind.Local), new DateTime(year: 1945, month: 10, day: 10, hour: 8, minute: 4, second: 35, millisecond: 787, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1995, month: 10, day: 15, hour: 20, minute: 43, second: 3, millisecond: 847, kind: DateTimeKind.Local), new DateTime(year: 1917, month: 10, day: 6, hour: 20, minute: 45, second: 20, millisecond: 648, kind: DateTimeKind.Local), new DateTime(year: 1966, month: 10, day: 16, hour: 20, minute: 39, second: 18, millisecond: 29, kind: DateTimeKind.Local), }, { new DateTime(year: 2013, month: 10, day: 7, hour: 20, minute: 2, second: 3, millisecond: 521, kind: DateTimeKind.Local), new DateTime(year: 1971, month: 10, day: 5, hour: 20, minute: 29, second: 39, millisecond: 506, kind: DateTimeKind.Local), new DateTime(year: 1930, month: 10, day: 8, hour: 8, minute: 35, second: 10, millisecond: 749, kind: DateTimeKind.Local), }, { new DateTime(year: 1965, month: 10, day: 2, hour: 3, minute: 53, second: 15, millisecond: 630, kind: DateTimeKind.Local), new DateTime(year: 1964, month: 10, day: 16, hour: 7, minute: 56, second: 1, millisecond: 420, kind: DateTimeKind.Local), new DateTime(year: 1917, month: 10, day: 2, hour: 15, minute: 32, second: 32, millisecond: 819, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 2017, month: 10, day: 1, hour: 5, minute: 53, second: 49, millisecond: 456, kind: DateTimeKind.Local), new DateTime(year: 2019, month: 10, day: 11, hour: 18, minute: 1, second: 32, millisecond: 857, kind: DateTimeKind.Local), new DateTime(year: 1927, month: 10, day: 5, hour: 2, minute: 2, second: 25, millisecond: 507, kind: DateTimeKind.Local), }, { new DateTime(year: 1965, month: 10, day: 12, hour: 12, minute: 13, second: 47, millisecond: 973, kind: DateTimeKind.Local), new DateTime(year: 1962, month: 10, day: 3, hour: 12, minute: 15, second: 1, millisecond: 268, kind: DateTimeKind.Local), new DateTime(year: 1997, month: 10, day: 19, hour: 3, minute: 51, second: 48, millisecond: 97, kind: DateTimeKind.Local), }, { new DateTime(year: 1949, month: 10, day: 6, hour: 19, minute: 13, second: 6, millisecond: 547, kind: DateTimeKind.Local), new DateTime(year: 2012, month: 10, day: 10, hour: 12, minute: 43, second: 41, millisecond: 687, kind: DateTimeKind.Local), new DateTime(year: 2004, month: 10, day: 19, hour: 12, minute: 30, second: 19, millisecond: 634, kind: DateTimeKind.Local), }, }, },
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneMMArrayD3E1M
{
    Id = 99,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1940, month: 10, day: 12, hour: 9, minute: 25, second: 37, millisecond: 644, kind: DateTimeKind.Local), new DateTime(year: 1991, month: 10, day: 4, hour: 9, minute: 9, second: 40, millisecond: 281, kind: DateTimeKind.Local), new DateTime(year: 1926, month: 10, day: 19, hour: 12, minute: 7, second: 33, millisecond: 605, kind: DateTimeKind.Local), }, { new DateTime(year: 1981, month: 10, day: 2, hour: 4, minute: 57, second: 34, millisecond: 600, kind: DateTimeKind.Local), new DateTime(year: 1957, month: 10, day: 3, hour: 5, minute: 55, second: 36, millisecond: 291, kind: DateTimeKind.Local), new DateTime(year: 1989, month: 10, day: 4, hour: 18, minute: 48, second: 16, millisecond: 496, kind: DateTimeKind.Local), }, { new DateTime(year: 1965, month: 10, day: 9, hour: 18, minute: 41, second: 16, millisecond: 223, kind: DateTimeKind.Local), new DateTime(year: 1957, month: 10, day: 3, hour: 1, minute: 29, second: 23, millisecond: 85, kind: DateTimeKind.Local), new DateTime(year: 1970, month: 10, day: 14, hour: 15, minute: 58, second: 48, millisecond: 856, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1959, month: 10, day: 4, hour: 21, minute: 37, second: 10, millisecond: 47, kind: DateTimeKind.Local), new DateTime(year: 2006, month: 10, day: 10, hour: 1, minute: 23, second: 16, millisecond: 606, kind: DateTimeKind.Local), new DateTime(year: 1985, month: 10, day: 17, hour: 22, minute: 38, second: 42, millisecond: 50, kind: DateTimeKind.Local), }, { new DateTime(year: 1969, month: 10, day: 10, hour: 22, minute: 23, second: 6, millisecond: 125, kind: DateTimeKind.Local), new DateTime(year: 1933, month: 10, day: 6, hour: 2, minute: 19, second: 56, millisecond: 715, kind: DateTimeKind.Local), new DateTime(year: 1978, month: 10, day: 8, hour: 9, minute: 50, second: 34, millisecond: 916, kind: DateTimeKind.Local), }, { new DateTime(year: 1979, month: 10, day: 16, hour: 7, minute: 23, second: 5, millisecond: 334, kind: DateTimeKind.Local), new DateTime(year: 1984, month: 10, day: 7, hour: 8, minute: 52, second: 14, millisecond: 568, kind: DateTimeKind.Local), new DateTime(year: 1988, month: 10, day: 17, hour: 8, minute: 21, second: 20, millisecond: 433, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1996, month: 10, day: 5, hour: 11, minute: 43, second: 56, millisecond: 102, kind: DateTimeKind.Local), new DateTime(year: 1942, month: 10, day: 10, hour: 14, minute: 18, second: 15, millisecond: 33, kind: DateTimeKind.Local), new DateTime(year: 1972, month: 10, day: 17, hour: 7, minute: 5, second: 24, millisecond: 97, kind: DateTimeKind.Local), }, { new DateTime(year: 2004, month: 10, day: 9, hour: 20, minute: 33, second: 38, millisecond: 302, kind: DateTimeKind.Local), new DateTime(year: 1987, month: 10, day: 19, hour: 8, minute: 30, second: 4, millisecond: 942, kind: DateTimeKind.Local), new DateTime(year: 1954, month: 10, day: 11, hour: 16, minute: 11, second: 48, millisecond: 386, kind: DateTimeKind.Local), }, { new DateTime(year: 2000, month: 10, day: 3, hour: 10, minute: 49, second: 39, millisecond: 294, kind: DateTimeKind.Local), new DateTime(year: 1953, month: 10, day: 13, hour: 2, minute: 58, second: 1, millisecond: 20, kind: DateTimeKind.Local), new DateTime(year: 1977, month: 10, day: 7, hour: 16, minute: 29, second: 11, millisecond: 697, kind: DateTimeKind.Local), }, }, },
    ModelInner = null,
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1920, month: 10, day: 7, hour: 11, minute: 11, second: 30, millisecond: 277, kind: DateTimeKind.Local), new DateTime(year: 2012, month: 10, day: 14, hour: 22, minute: 23, second: 20, millisecond: 236, kind: DateTimeKind.Local), new DateTime(year: 1933, month: 10, day: 6, hour: 15, minute: 55, second: 22, millisecond: 779, kind: DateTimeKind.Local), }, { new DateTime(year: 1951, month: 10, day: 13, hour: 6, minute: 26, second: 41, millisecond: 446, kind: DateTimeKind.Local), new DateTime(year: 1955, month: 10, day: 11, hour: 10, minute: 28, second: 5, millisecond: 947, kind: DateTimeKind.Local), new DateTime(year: 1995, month: 10, day: 2, hour: 6, minute: 21, second: 1, millisecond: 235, kind: DateTimeKind.Local), }, { new DateTime(year: 1962, month: 10, day: 17, hour: 15, minute: 1, second: 41, millisecond: 656, kind: DateTimeKind.Local), new DateTime(year: 2017, month: 10, day: 15, hour: 15, minute: 44, second: 23, millisecond: 936, kind: DateTimeKind.Local), new DateTime(year: 1970, month: 10, day: 14, hour: 14, minute: 23, second: 19, millisecond: 986, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 2007, month: 10, day: 6, hour: 8, minute: 31, second: 37, millisecond: 757, kind: DateTimeKind.Local), new DateTime(year: 1925, month: 10, day: 5, hour: 17, minute: 24, second: 27, millisecond: 674, kind: DateTimeKind.Local), new DateTime(year: 1998, month: 10, day: 18, hour: 17, minute: 57, second: 10, millisecond: 500, kind: DateTimeKind.Local), }, { new DateTime(year: 1999, month: 10, day: 13, hour: 3, minute: 43, second: 35, millisecond: 249, kind: DateTimeKind.Local), new DateTime(year: 1988, month: 10, day: 1, hour: 20, minute: 8, second: 58, millisecond: 766, kind: DateTimeKind.Local), new DateTime(year: 2007, month: 10, day: 2, hour: 3, minute: 50, second: 57, millisecond: 38, kind: DateTimeKind.Local), }, { new DateTime(year: 1929, month: 10, day: 3, hour: 1, minute: 47, second: 8, millisecond: 499, kind: DateTimeKind.Local), new DateTime(year: 1925, month: 10, day: 14, hour: 18, minute: 9, second: 25, millisecond: 870, kind: DateTimeKind.Local), new DateTime(year: 1975, month: 10, day: 5, hour: 3, minute: 5, second: 38, millisecond: 178, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1987, month: 10, day: 10, hour: 22, minute: 58, second: 40, millisecond: 586, kind: DateTimeKind.Local), new DateTime(year: 2009, month: 10, day: 14, hour: 20, minute: 35, second: 17, millisecond: 280, kind: DateTimeKind.Local), new DateTime(year: 1982, month: 10, day: 10, hour: 13, minute: 7, second: 11, millisecond: 20, kind: DateTimeKind.Local), }, { new DateTime(year: 1988, month: 10, day: 4, hour: 1, minute: 3, second: 45, millisecond: 638, kind: DateTimeKind.Local), new DateTime(year: 1986, month: 10, day: 2, hour: 4, minute: 20, second: 3, millisecond: 828, kind: DateTimeKind.Local), new DateTime(year: 2014, month: 10, day: 7, hour: 21, minute: 51, second: 28, millisecond: 982, kind: DateTimeKind.Local), }, { new DateTime(year: 1998, month: 10, day: 10, hour: 22, minute: 8, second: 36, millisecond: 780, kind: DateTimeKind.Local), new DateTime(year: 1919, month: 10, day: 17, hour: 6, minute: 5, second: 23, millisecond: 647, kind: DateTimeKind.Local), new DateTime(year: 1925, month: 10, day: 11, hour: 19, minute: 23, second: 36, millisecond: 287, kind: DateTimeKind.Local), }, }, },
},
            new DateTimetimestamp_without_time_zoneMMArrayD3E1M
{
    Id = 102,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1976, month: 10, day: 17, hour: 16, minute: 42, second: 18, millisecond: 277, kind: DateTimeKind.Local), new DateTime(year: 1975, month: 10, day: 16, hour: 15, minute: 58, second: 1, millisecond: 920, kind: DateTimeKind.Local), new DateTime(year: 1938, month: 10, day: 7, hour: 5, minute: 22, second: 11, millisecond: 522, kind: DateTimeKind.Local), }, { new DateTime(year: 1934, month: 10, day: 18, hour: 2, minute: 5, second: 47, millisecond: 836, kind: DateTimeKind.Local), new DateTime(year: 1952, month: 10, day: 10, hour: 7, minute: 19, second: 51, millisecond: 460, kind: DateTimeKind.Local), new DateTime(year: 1980, month: 10, day: 12, hour: 10, minute: 7, second: 19, millisecond: 806, kind: DateTimeKind.Local), }, { new DateTime(year: 2006, month: 10, day: 6, hour: 9, minute: 36, second: 9, millisecond: 214, kind: DateTimeKind.Local), new DateTime(year: 1937, month: 10, day: 13, hour: 17, minute: 24, second: 34, millisecond: 110, kind: DateTimeKind.Local), new DateTime(year: 1942, month: 10, day: 14, hour: 6, minute: 12, second: 53, millisecond: 115, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1930, month: 10, day: 15, hour: 13, minute: 45, second: 38, millisecond: 617, kind: DateTimeKind.Local), new DateTime(year: 1951, month: 10, day: 7, hour: 4, minute: 15, second: 23, millisecond: 613, kind: DateTimeKind.Local), new DateTime(year: 2019, month: 10, day: 4, hour: 22, minute: 48, second: 11, millisecond: 273, kind: DateTimeKind.Local), }, { new DateTime(year: 1940, month: 10, day: 8, hour: 3, minute: 14, second: 23, millisecond: 114, kind: DateTimeKind.Local), new DateTime(year: 1961, month: 10, day: 11, hour: 22, minute: 35, second: 15, millisecond: 102, kind: DateTimeKind.Local), new DateTime(year: 1988, month: 10, day: 4, hour: 7, minute: 37, second: 54, millisecond: 294, kind: DateTimeKind.Local), }, { new DateTime(year: 1981, month: 10, day: 18, hour: 19, minute: 40, second: 43, millisecond: 381, kind: DateTimeKind.Local), new DateTime(year: 1961, month: 10, day: 9, hour: 18, minute: 37, second: 47, millisecond: 224, kind: DateTimeKind.Local), new DateTime(year: 1934, month: 10, day: 18, hour: 5, minute: 34, second: 14, millisecond: 651, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1999, month: 10, day: 19, hour: 16, minute: 41, second: 42, millisecond: 24, kind: DateTimeKind.Local), new DateTime(year: 2009, month: 10, day: 3, hour: 5, minute: 16, second: 41, millisecond: 728, kind: DateTimeKind.Local), new DateTime(year: 1984, month: 10, day: 11, hour: 17, minute: 45, second: 54, millisecond: 199, kind: DateTimeKind.Local), }, { new DateTime(year: 1919, month: 10, day: 4, hour: 15, minute: 35, second: 25, millisecond: 380, kind: DateTimeKind.Local), new DateTime(year: 1922, month: 10, day: 7, hour: 4, minute: 14, second: 25, millisecond: 85, kind: DateTimeKind.Local), new DateTime(year: 1956, month: 10, day: 3, hour: 11, minute: 10, second: 26, millisecond: 765, kind: DateTimeKind.Local), }, { new DateTime(year: 1987, month: 10, day: 6, hour: 13, minute: 46, second: 22, millisecond: 737, kind: DateTimeKind.Local), new DateTime(year: 1996, month: 10, day: 9, hour: 5, minute: 17, second: 55, millisecond: 283, kind: DateTimeKind.Local), new DateTime(year: 1918, month: 10, day: 16, hour: 13, minute: 56, second: 33, millisecond: 768, kind: DateTimeKind.Local), }, }, },
    ModelInner = new DateTimetimestamp_without_time_zoneMMArrayD3E1MI
{
    Id = 52,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1990, month: 10, day: 4, hour: 12, minute: 34, second: 36, millisecond: 741, kind: DateTimeKind.Local), new DateTime(year: 1960, month: 10, day: 17, hour: 5, minute: 50, second: 53, millisecond: 883, kind: DateTimeKind.Local), new DateTime(year: 1974, month: 10, day: 14, hour: 18, minute: 14, second: 49, millisecond: 568, kind: DateTimeKind.Local), }, { new DateTime(year: 2018, month: 10, day: 2, hour: 19, minute: 8, second: 41, millisecond: 22, kind: DateTimeKind.Local), new DateTime(year: 2019, month: 10, day: 8, hour: 2, minute: 11, second: 58, millisecond: 43, kind: DateTimeKind.Local), new DateTime(year: 1956, month: 10, day: 4, hour: 10, minute: 20, second: 36, millisecond: 601, kind: DateTimeKind.Local), }, { new DateTime(year: 1926, month: 10, day: 14, hour: 16, minute: 11, second: 21, millisecond: 826, kind: DateTimeKind.Local), new DateTime(year: 1971, month: 10, day: 15, hour: 14, minute: 39, second: 58, millisecond: 693, kind: DateTimeKind.Local), new DateTime(year: 1937, month: 10, day: 15, hour: 1, minute: 3, second: 55, millisecond: 636, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1994, month: 10, day: 6, hour: 22, minute: 28, second: 28, millisecond: 345, kind: DateTimeKind.Local), new DateTime(year: 1972, month: 10, day: 8, hour: 17, minute: 45, second: 21, millisecond: 618, kind: DateTimeKind.Local), new DateTime(year: 1997, month: 10, day: 19, hour: 14, minute: 39, second: 3, millisecond: 204, kind: DateTimeKind.Local), }, { new DateTime(year: 1967, month: 10, day: 6, hour: 9, minute: 4, second: 9, millisecond: 709, kind: DateTimeKind.Local), new DateTime(year: 1922, month: 10, day: 10, hour: 12, minute: 9, second: 25, millisecond: 712, kind: DateTimeKind.Local), new DateTime(year: 1925, month: 10, day: 13, hour: 6, minute: 41, second: 30, millisecond: 302, kind: DateTimeKind.Local), }, { new DateTime(year: 1932, month: 10, day: 8, hour: 16, minute: 39, second: 17, millisecond: 839, kind: DateTimeKind.Local), new DateTime(year: 1923, month: 10, day: 10, hour: 4, minute: 3, second: 10, millisecond: 484, kind: DateTimeKind.Local), new DateTime(year: 1924, month: 10, day: 6, hour: 17, minute: 21, second: 50, millisecond: 307, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1938, month: 10, day: 17, hour: 8, minute: 36, second: 50, millisecond: 200, kind: DateTimeKind.Local), new DateTime(year: 1930, month: 10, day: 7, hour: 12, minute: 33, second: 45, millisecond: 419, kind: DateTimeKind.Local), new DateTime(year: 1989, month: 10, day: 16, hour: 19, minute: 29, second: 35, millisecond: 311, kind: DateTimeKind.Local), }, { new DateTime(year: 1923, month: 10, day: 2, hour: 11, minute: 2, second: 32, millisecond: 547, kind: DateTimeKind.Local), new DateTime(year: 1949, month: 10, day: 16, hour: 3, minute: 31, second: 8, millisecond: 470, kind: DateTimeKind.Local), new DateTime(year: 1926, month: 10, day: 9, hour: 9, minute: 42, second: 11, millisecond: 641, kind: DateTimeKind.Local), }, { new DateTime(year: 1988, month: 10, day: 7, hour: 4, minute: 25, second: 51, millisecond: 154, kind: DateTimeKind.Local), new DateTime(year: 1925, month: 10, day: 19, hour: 20, minute: 33, second: 15, millisecond: 89, kind: DateTimeKind.Local), new DateTime(year: 1992, month: 10, day: 5, hour: 1, minute: 49, second: 46, millisecond: 402, kind: DateTimeKind.Local), }, }, },
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 2005, month: 10, day: 5, hour: 11, minute: 19, second: 14, millisecond: 788, kind: DateTimeKind.Local), new DateTime(year: 1925, month: 10, day: 15, hour: 11, minute: 44, second: 21, millisecond: 530, kind: DateTimeKind.Local), new DateTime(year: 1951, month: 10, day: 17, hour: 11, minute: 50, second: 28, millisecond: 770, kind: DateTimeKind.Local), }, { new DateTime(year: 1950, month: 10, day: 6, hour: 4, minute: 48, second: 43, millisecond: 285, kind: DateTimeKind.Local), new DateTime(year: 1956, month: 10, day: 1, hour: 17, minute: 6, second: 36, millisecond: 805, kind: DateTimeKind.Local), new DateTime(year: 1927, month: 10, day: 8, hour: 22, minute: 11, second: 19, millisecond: 205, kind: DateTimeKind.Local), }, { new DateTime(year: 1925, month: 10, day: 8, hour: 19, minute: 49, second: 18, millisecond: 204, kind: DateTimeKind.Local), new DateTime(year: 1967, month: 10, day: 16, hour: 6, minute: 17, second: 29, millisecond: 632, kind: DateTimeKind.Local), new DateTime(year: 1931, month: 10, day: 5, hour: 4, minute: 14, second: 14, millisecond: 301, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1969, month: 10, day: 10, hour: 6, minute: 24, second: 17, millisecond: 155, kind: DateTimeKind.Local), new DateTime(year: 1928, month: 10, day: 6, hour: 3, minute: 45, second: 34, millisecond: 626, kind: DateTimeKind.Local), new DateTime(year: 1948, month: 10, day: 17, hour: 11, minute: 21, second: 44, millisecond: 77, kind: DateTimeKind.Local), }, { new DateTime(year: 1957, month: 10, day: 19, hour: 7, minute: 6, second: 16, millisecond: 136, kind: DateTimeKind.Local), new DateTime(year: 1979, month: 10, day: 17, hour: 10, minute: 51, second: 10, millisecond: 977, kind: DateTimeKind.Local), new DateTime(year: 2007, month: 10, day: 12, hour: 20, minute: 24, second: 13, millisecond: 853, kind: DateTimeKind.Local), }, { new DateTime(year: 1979, month: 10, day: 15, hour: 13, minute: 47, second: 12, millisecond: 295, kind: DateTimeKind.Local), new DateTime(year: 1974, month: 10, day: 3, hour: 18, minute: 44, second: 30, millisecond: 994, kind: DateTimeKind.Local), new DateTime(year: 1971, month: 10, day: 14, hour: 6, minute: 30, second: 23, millisecond: 414, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 2003, month: 10, day: 7, hour: 11, minute: 56, second: 54, millisecond: 333, kind: DateTimeKind.Local), new DateTime(year: 1969, month: 10, day: 12, hour: 6, minute: 19, second: 53, millisecond: 616, kind: DateTimeKind.Local), new DateTime(year: 1979, month: 10, day: 8, hour: 2, minute: 26, second: 10, millisecond: 561, kind: DateTimeKind.Local), }, { new DateTime(year: 2009, month: 10, day: 2, hour: 20, minute: 22, second: 38, millisecond: 15, kind: DateTimeKind.Local), new DateTime(year: 1935, month: 10, day: 7, hour: 21, minute: 37, second: 51, millisecond: 140, kind: DateTimeKind.Local), new DateTime(year: 1948, month: 10, day: 8, hour: 12, minute: 38, second: 3, millisecond: 482, kind: DateTimeKind.Local), }, { new DateTime(year: 2014, month: 10, day: 11, hour: 3, minute: 6, second: 14, millisecond: 805, kind: DateTimeKind.Local), new DateTime(year: 2000, month: 10, day: 2, hour: 10, minute: 17, second: 13, millisecond: 179, kind: DateTimeKind.Local), new DateTime(year: 1991, month: 10, day: 19, hour: 7, minute: 33, second: 4, millisecond: 110, kind: DateTimeKind.Local), }, }, },
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneMMArrayD3E1M
{
    Id = 108,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1921, month: 10, day: 14, hour: 21, minute: 14, second: 17, millisecond: 457, kind: DateTimeKind.Local), new DateTime(year: 1948, month: 10, day: 11, hour: 15, minute: 30, second: 45, millisecond: 233, kind: DateTimeKind.Local), new DateTime(year: 1987, month: 10, day: 17, hour: 20, minute: 51, second: 15, millisecond: 312, kind: DateTimeKind.Local), }, { new DateTime(year: 1935, month: 10, day: 14, hour: 14, minute: 33, second: 10, millisecond: 767, kind: DateTimeKind.Local), new DateTime(year: 2008, month: 10, day: 16, hour: 8, minute: 11, second: 42, millisecond: 572, kind: DateTimeKind.Local), new DateTime(year: 2005, month: 10, day: 3, hour: 10, minute: 1, second: 32, millisecond: 587, kind: DateTimeKind.Local), }, { new DateTime(year: 2016, month: 10, day: 14, hour: 12, minute: 48, second: 23, millisecond: 614, kind: DateTimeKind.Local), new DateTime(year: 1978, month: 10, day: 12, hour: 5, minute: 48, second: 15, millisecond: 187, kind: DateTimeKind.Local), new DateTime(year: 2009, month: 10, day: 12, hour: 18, minute: 40, second: 33, millisecond: 970, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 2019, month: 10, day: 2, hour: 22, minute: 6, second: 8, millisecond: 491, kind: DateTimeKind.Local), new DateTime(year: 2017, month: 10, day: 15, hour: 3, minute: 24, second: 5, millisecond: 169, kind: DateTimeKind.Local), new DateTime(year: 1970, month: 10, day: 18, hour: 17, minute: 16, second: 37, millisecond: 39, kind: DateTimeKind.Local), }, { new DateTime(year: 1918, month: 10, day: 1, hour: 4, minute: 14, second: 10, millisecond: 211, kind: DateTimeKind.Local), new DateTime(year: 1928, month: 10, day: 8, hour: 18, minute: 5, second: 54, millisecond: 702, kind: DateTimeKind.Local), new DateTime(year: 1919, month: 10, day: 9, hour: 18, minute: 46, second: 49, millisecond: 695, kind: DateTimeKind.Local), }, { new DateTime(year: 2012, month: 10, day: 8, hour: 7, minute: 11, second: 3, millisecond: 664, kind: DateTimeKind.Local), new DateTime(year: 1952, month: 10, day: 17, hour: 10, minute: 14, second: 27, millisecond: 484, kind: DateTimeKind.Local), new DateTime(year: 1982, month: 10, day: 13, hour: 18, minute: 4, second: 40, millisecond: 256, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1993, month: 10, day: 9, hour: 4, minute: 29, second: 12, millisecond: 25, kind: DateTimeKind.Local), new DateTime(year: 1958, month: 10, day: 6, hour: 10, minute: 36, second: 24, millisecond: 527, kind: DateTimeKind.Local), new DateTime(year: 1925, month: 10, day: 3, hour: 12, minute: 44, second: 58, millisecond: 339, kind: DateTimeKind.Local), }, { new DateTime(year: 1993, month: 10, day: 15, hour: 1, minute: 11, second: 40, millisecond: 648, kind: DateTimeKind.Local), new DateTime(year: 1924, month: 10, day: 13, hour: 14, minute: 6, second: 36, millisecond: 81, kind: DateTimeKind.Local), new DateTime(year: 1959, month: 10, day: 4, hour: 17, minute: 2, second: 4, millisecond: 807, kind: DateTimeKind.Local), }, { new DateTime(year: 1931, month: 10, day: 16, hour: 19, minute: 16, second: 42, millisecond: 860, kind: DateTimeKind.Local), new DateTime(year: 2007, month: 10, day: 1, hour: 8, minute: 22, second: 7, millisecond: 557, kind: DateTimeKind.Local), new DateTime(year: 1936, month: 10, day: 13, hour: 13, minute: 29, second: 51, millisecond: 539, kind: DateTimeKind.Local), }, }, },
    ModelInner = null,
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1983, month: 10, day: 13, hour: 6, minute: 22, second: 16, millisecond: 440, kind: DateTimeKind.Local), new DateTime(year: 1955, month: 10, day: 17, hour: 16, minute: 53, second: 56, millisecond: 957, kind: DateTimeKind.Local), new DateTime(year: 1925, month: 10, day: 3, hour: 19, minute: 6, second: 12, millisecond: 551, kind: DateTimeKind.Local), }, { new DateTime(year: 1993, month: 10, day: 3, hour: 22, minute: 41, second: 48, millisecond: 410, kind: DateTimeKind.Local), new DateTime(year: 1922, month: 10, day: 10, hour: 11, minute: 16, second: 36, millisecond: 591, kind: DateTimeKind.Local), new DateTime(year: 1983, month: 10, day: 3, hour: 3, minute: 19, second: 17, millisecond: 139, kind: DateTimeKind.Local), }, { new DateTime(year: 1954, month: 10, day: 10, hour: 21, minute: 24, second: 35, millisecond: 317, kind: DateTimeKind.Local), new DateTime(year: 1954, month: 10, day: 15, hour: 4, minute: 37, second: 8, millisecond: 238, kind: DateTimeKind.Local), new DateTime(year: 1959, month: 10, day: 12, hour: 18, minute: 25, second: 30, millisecond: 579, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 2016, month: 10, day: 5, hour: 14, minute: 22, second: 32, millisecond: 563, kind: DateTimeKind.Local), new DateTime(year: 1935, month: 10, day: 14, hour: 20, minute: 20, second: 47, millisecond: 672, kind: DateTimeKind.Local), new DateTime(year: 1930, month: 10, day: 8, hour: 10, minute: 3, second: 14, millisecond: 407, kind: DateTimeKind.Local), }, { new DateTime(year: 1991, month: 10, day: 12, hour: 8, minute: 43, second: 12, millisecond: 259, kind: DateTimeKind.Local), new DateTime(year: 1999, month: 10, day: 13, hour: 5, minute: 37, second: 57, millisecond: 998, kind: DateTimeKind.Local), new DateTime(year: 1961, month: 10, day: 16, hour: 7, minute: 36, second: 11, millisecond: 580, kind: DateTimeKind.Local), }, { new DateTime(year: 1929, month: 10, day: 7, hour: 8, minute: 30, second: 44, millisecond: 768, kind: DateTimeKind.Local), new DateTime(year: 1934, month: 10, day: 3, hour: 11, minute: 18, second: 24, millisecond: 304, kind: DateTimeKind.Local), new DateTime(year: 1949, month: 10, day: 6, hour: 8, minute: 5, second: 23, millisecond: 440, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1968, month: 10, day: 1, hour: 1, minute: 20, second: 52, millisecond: 86, kind: DateTimeKind.Local), new DateTime(year: 2004, month: 10, day: 17, hour: 18, minute: 25, second: 14, millisecond: 512, kind: DateTimeKind.Local), new DateTime(year: 1922, month: 10, day: 2, hour: 7, minute: 10, second: 20, millisecond: 785, kind: DateTimeKind.Local), }, { new DateTime(year: 1982, month: 10, day: 8, hour: 4, minute: 56, second: 52, millisecond: 802, kind: DateTimeKind.Local), new DateTime(year: 1937, month: 10, day: 8, hour: 12, minute: 47, second: 48, millisecond: 125, kind: DateTimeKind.Local), new DateTime(year: 1968, month: 10, day: 5, hour: 11, minute: 23, second: 21, millisecond: 678, kind: DateTimeKind.Local), }, { new DateTime(year: 1981, month: 10, day: 14, hour: 10, minute: 14, second: 48, millisecond: 8, kind: DateTimeKind.Local), new DateTime(year: 1954, month: 10, day: 6, hour: 19, minute: 41, second: 44, millisecond: 338, kind: DateTimeKind.Local), new DateTime(year: 1997, month: 10, day: 1, hour: 9, minute: 20, second: 32, millisecond: 178, kind: DateTimeKind.Local), }, }, },
},
            new DateTimetimestamp_without_time_zoneMMArrayD3E1M
{
    Id = 112,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 2013, month: 10, day: 4, hour: 4, minute: 20, second: 42, millisecond: 391, kind: DateTimeKind.Local), new DateTime(year: 2016, month: 10, day: 13, hour: 20, minute: 26, second: 54, millisecond: 383, kind: DateTimeKind.Local), new DateTime(year: 1949, month: 10, day: 4, hour: 4, minute: 25, second: 6, millisecond: 364, kind: DateTimeKind.Local), }, { new DateTime(year: 1921, month: 10, day: 18, hour: 1, minute: 29, second: 2, millisecond: 63, kind: DateTimeKind.Local), new DateTime(year: 1956, month: 10, day: 5, hour: 9, minute: 40, second: 49, millisecond: 122, kind: DateTimeKind.Local), new DateTime(year: 1971, month: 10, day: 1, hour: 1, minute: 33, second: 57, millisecond: 972, kind: DateTimeKind.Local), }, { new DateTime(year: 1917, month: 10, day: 12, hour: 19, minute: 8, second: 30, millisecond: 424, kind: DateTimeKind.Local), new DateTime(year: 1969, month: 10, day: 1, hour: 20, minute: 42, second: 14, millisecond: 753, kind: DateTimeKind.Local), new DateTime(year: 1972, month: 10, day: 19, hour: 8, minute: 12, second: 44, millisecond: 620, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1955, month: 10, day: 18, hour: 16, minute: 14, second: 17, millisecond: 310, kind: DateTimeKind.Local), new DateTime(year: 1992, month: 10, day: 13, hour: 20, minute: 17, second: 57, millisecond: 461, kind: DateTimeKind.Local), new DateTime(year: 1925, month: 10, day: 4, hour: 19, minute: 44, second: 31, millisecond: 182, kind: DateTimeKind.Local), }, { new DateTime(year: 1941, month: 10, day: 8, hour: 22, minute: 52, second: 23, millisecond: 122, kind: DateTimeKind.Local), new DateTime(year: 2006, month: 10, day: 4, hour: 10, minute: 10, second: 42, millisecond: 414, kind: DateTimeKind.Local), new DateTime(year: 1956, month: 10, day: 19, hour: 4, minute: 52, second: 56, millisecond: 888, kind: DateTimeKind.Local), }, { new DateTime(year: 1954, month: 10, day: 14, hour: 8, minute: 24, second: 20, millisecond: 652, kind: DateTimeKind.Local), new DateTime(year: 1965, month: 10, day: 16, hour: 6, minute: 18, second: 17, millisecond: 767, kind: DateTimeKind.Local), new DateTime(year: 1930, month: 10, day: 3, hour: 17, minute: 44, second: 16, millisecond: 132, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1950, month: 10, day: 4, hour: 2, minute: 16, second: 52, millisecond: 565, kind: DateTimeKind.Local), new DateTime(year: 1939, month: 10, day: 9, hour: 13, minute: 19, second: 57, millisecond: 24, kind: DateTimeKind.Local), new DateTime(year: 1971, month: 10, day: 2, hour: 14, minute: 37, second: 36, millisecond: 605, kind: DateTimeKind.Local), }, { new DateTime(year: 1953, month: 10, day: 8, hour: 2, minute: 27, second: 26, millisecond: 324, kind: DateTimeKind.Local), new DateTime(year: 1952, month: 10, day: 5, hour: 19, minute: 45, second: 44, millisecond: 839, kind: DateTimeKind.Local), new DateTime(year: 1974, month: 10, day: 9, hour: 18, minute: 17, second: 56, millisecond: 608, kind: DateTimeKind.Local), }, { new DateTime(year: 1993, month: 10, day: 1, hour: 14, minute: 38, second: 58, millisecond: 607, kind: DateTimeKind.Local), new DateTime(year: 1936, month: 10, day: 15, hour: 16, minute: 17, second: 51, millisecond: 86, kind: DateTimeKind.Local), new DateTime(year: 2002, month: 10, day: 7, hour: 22, minute: 31, second: 51, millisecond: 699, kind: DateTimeKind.Local), }, }, },
    ModelInner = new DateTimetimestamp_without_time_zoneMMArrayD3E1MI
{
    Id = 58,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1976, month: 10, day: 19, hour: 20, minute: 23, second: 11, millisecond: 15, kind: DateTimeKind.Local), new DateTime(year: 1994, month: 10, day: 16, hour: 20, minute: 12, second: 22, millisecond: 619, kind: DateTimeKind.Local), new DateTime(year: 1978, month: 10, day: 6, hour: 5, minute: 48, second: 13, millisecond: 928, kind: DateTimeKind.Local), }, { new DateTime(year: 1964, month: 10, day: 1, hour: 9, minute: 35, second: 38, millisecond: 407, kind: DateTimeKind.Local), new DateTime(year: 2017, month: 10, day: 13, hour: 15, minute: 30, second: 35, millisecond: 122, kind: DateTimeKind.Local), new DateTime(year: 1991, month: 10, day: 10, hour: 11, minute: 25, second: 6, millisecond: 598, kind: DateTimeKind.Local), }, { new DateTime(year: 2001, month: 10, day: 2, hour: 17, minute: 40, second: 41, millisecond: 20, kind: DateTimeKind.Local), new DateTime(year: 1933, month: 10, day: 13, hour: 3, minute: 2, second: 54, millisecond: 79, kind: DateTimeKind.Local), new DateTime(year: 1922, month: 10, day: 16, hour: 10, minute: 1, second: 6, millisecond: 861, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1998, month: 10, day: 11, hour: 6, minute: 28, second: 7, millisecond: 838, kind: DateTimeKind.Local), new DateTime(year: 1923, month: 10, day: 15, hour: 15, minute: 4, second: 28, millisecond: 80, kind: DateTimeKind.Local), new DateTime(year: 1978, month: 10, day: 4, hour: 15, minute: 51, second: 31, millisecond: 609, kind: DateTimeKind.Local), }, { new DateTime(year: 1997, month: 10, day: 12, hour: 20, minute: 14, second: 23, millisecond: 335, kind: DateTimeKind.Local), new DateTime(year: 1962, month: 10, day: 7, hour: 11, minute: 29, second: 45, millisecond: 215, kind: DateTimeKind.Local), new DateTime(year: 1927, month: 10, day: 13, hour: 5, minute: 44, second: 57, millisecond: 602, kind: DateTimeKind.Local), }, { new DateTime(year: 2005, month: 10, day: 19, hour: 5, minute: 16, second: 55, millisecond: 58, kind: DateTimeKind.Local), new DateTime(year: 2015, month: 10, day: 9, hour: 16, minute: 20, second: 1, millisecond: 158, kind: DateTimeKind.Local), new DateTime(year: 1979, month: 10, day: 18, hour: 7, minute: 14, second: 45, millisecond: 710, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 2011, month: 10, day: 7, hour: 19, minute: 17, second: 47, millisecond: 642, kind: DateTimeKind.Local), new DateTime(year: 1946, month: 10, day: 12, hour: 2, minute: 43, second: 22, millisecond: 412, kind: DateTimeKind.Local), new DateTime(year: 1942, month: 10, day: 13, hour: 22, minute: 21, second: 35, millisecond: 686, kind: DateTimeKind.Local), }, { new DateTime(year: 2008, month: 10, day: 17, hour: 5, minute: 36, second: 9, millisecond: 791, kind: DateTimeKind.Local), new DateTime(year: 1959, month: 10, day: 16, hour: 10, minute: 46, second: 38, millisecond: 267, kind: DateTimeKind.Local), new DateTime(year: 1965, month: 10, day: 18, hour: 17, minute: 15, second: 39, millisecond: 921, kind: DateTimeKind.Local), }, { new DateTime(year: 1918, month: 10, day: 5, hour: 20, minute: 16, second: 29, millisecond: 734, kind: DateTimeKind.Local), new DateTime(year: 1982, month: 10, day: 8, hour: 9, minute: 55, second: 21, millisecond: 831, kind: DateTimeKind.Local), new DateTime(year: 1980, month: 10, day: 2, hour: 13, minute: 5, second: 23, millisecond: 339, kind: DateTimeKind.Local), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneMMArrayD3E1M
{
    Id = 113,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 2008, month: 10, day: 5, hour: 16, minute: 55, second: 26, millisecond: 914, kind: DateTimeKind.Local), new DateTime(year: 1923, month: 10, day: 4, hour: 10, minute: 30, second: 11, millisecond: 251, kind: DateTimeKind.Local), new DateTime(year: 1929, month: 10, day: 3, hour: 21, minute: 45, second: 50, millisecond: 885, kind: DateTimeKind.Local), }, { new DateTime(year: 1935, month: 10, day: 3, hour: 12, minute: 52, second: 21, millisecond: 203, kind: DateTimeKind.Local), new DateTime(year: 1984, month: 10, day: 15, hour: 8, minute: 3, second: 37, millisecond: 204, kind: DateTimeKind.Local), new DateTime(year: 1942, month: 10, day: 14, hour: 9, minute: 9, second: 41, millisecond: 313, kind: DateTimeKind.Local), }, { new DateTime(year: 1963, month: 10, day: 16, hour: 22, minute: 38, second: 7, millisecond: 419, kind: DateTimeKind.Local), new DateTime(year: 2015, month: 10, day: 10, hour: 8, minute: 31, second: 15, millisecond: 147, kind: DateTimeKind.Local), new DateTime(year: 1989, month: 10, day: 19, hour: 12, minute: 11, second: 2, millisecond: 652, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 2006, month: 10, day: 6, hour: 18, minute: 6, second: 31, millisecond: 847, kind: DateTimeKind.Local), new DateTime(year: 1991, month: 10, day: 4, hour: 11, minute: 31, second: 15, millisecond: 65, kind: DateTimeKind.Local), new DateTime(year: 2017, month: 10, day: 5, hour: 4, minute: 41, second: 54, millisecond: 210, kind: DateTimeKind.Local), }, { new DateTime(year: 2019, month: 10, day: 11, hour: 14, minute: 48, second: 8, millisecond: 146, kind: DateTimeKind.Local), new DateTime(year: 1975, month: 10, day: 9, hour: 17, minute: 43, second: 37, millisecond: 742, kind: DateTimeKind.Local), new DateTime(year: 1919, month: 10, day: 18, hour: 6, minute: 35, second: 55, millisecond: 728, kind: DateTimeKind.Local), }, { new DateTime(year: 1956, month: 10, day: 3, hour: 10, minute: 42, second: 52, millisecond: 28, kind: DateTimeKind.Local), new DateTime(year: 2014, month: 10, day: 12, hour: 12, minute: 18, second: 7, millisecond: 316, kind: DateTimeKind.Local), new DateTime(year: 1962, month: 10, day: 19, hour: 18, minute: 45, second: 5, millisecond: 658, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1948, month: 10, day: 8, hour: 8, minute: 43, second: 21, millisecond: 503, kind: DateTimeKind.Local), new DateTime(year: 2005, month: 10, day: 17, hour: 14, minute: 39, second: 48, millisecond: 400, kind: DateTimeKind.Local), new DateTime(year: 1930, month: 10, day: 19, hour: 5, minute: 53, second: 21, millisecond: 827, kind: DateTimeKind.Local), }, { new DateTime(year: 1948, month: 10, day: 13, hour: 18, minute: 42, second: 50, millisecond: 950, kind: DateTimeKind.Local), new DateTime(year: 2018, month: 10, day: 5, hour: 19, minute: 33, second: 20, millisecond: 513, kind: DateTimeKind.Local), new DateTime(year: 1931, month: 10, day: 11, hour: 9, minute: 43, second: 7, millisecond: 701, kind: DateTimeKind.Local), }, { new DateTime(year: 1963, month: 10, day: 2, hour: 20, minute: 4, second: 39, millisecond: 605, kind: DateTimeKind.Local), new DateTime(year: 1924, month: 10, day: 17, hour: 2, minute: 12, second: 2, millisecond: 419, kind: DateTimeKind.Local), new DateTime(year: 1918, month: 10, day: 7, hour: 18, minute: 37, second: 44, millisecond: 120, kind: DateTimeKind.Local), }, }, },
    ModelInner = null,
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1928, month: 10, day: 8, hour: 11, minute: 26, second: 47, millisecond: 484, kind: DateTimeKind.Local), new DateTime(year: 2006, month: 10, day: 15, hour: 17, minute: 1, second: 5, millisecond: 719, kind: DateTimeKind.Local), new DateTime(year: 1976, month: 10, day: 3, hour: 3, minute: 56, second: 51, millisecond: 198, kind: DateTimeKind.Local), }, { new DateTime(year: 1977, month: 10, day: 16, hour: 18, minute: 11, second: 29, millisecond: 63, kind: DateTimeKind.Local), new DateTime(year: 1926, month: 10, day: 7, hour: 6, minute: 9, second: 51, millisecond: 943, kind: DateTimeKind.Local), new DateTime(year: 1957, month: 10, day: 14, hour: 3, minute: 9, second: 49, millisecond: 7, kind: DateTimeKind.Local), }, { new DateTime(year: 1977, month: 10, day: 2, hour: 7, minute: 9, second: 3, millisecond: 202, kind: DateTimeKind.Local), new DateTime(year: 1969, month: 10, day: 2, hour: 14, minute: 46, second: 9, millisecond: 914, kind: DateTimeKind.Local), new DateTime(year: 1958, month: 10, day: 16, hour: 3, minute: 24, second: 28, millisecond: 122, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 2016, month: 10, day: 18, hour: 14, minute: 45, second: 55, millisecond: 707, kind: DateTimeKind.Local), new DateTime(year: 2016, month: 10, day: 16, hour: 12, minute: 56, second: 57, millisecond: 551, kind: DateTimeKind.Local), new DateTime(year: 1997, month: 10, day: 19, hour: 19, minute: 47, second: 43, millisecond: 59, kind: DateTimeKind.Local), }, { new DateTime(year: 2009, month: 10, day: 10, hour: 5, minute: 55, second: 5, millisecond: 833, kind: DateTimeKind.Local), new DateTime(year: 1986, month: 10, day: 5, hour: 4, minute: 2, second: 23, millisecond: 219, kind: DateTimeKind.Local), new DateTime(year: 1952, month: 10, day: 10, hour: 7, minute: 49, second: 1, millisecond: 862, kind: DateTimeKind.Local), }, { new DateTime(year: 1953, month: 10, day: 7, hour: 11, minute: 49, second: 49, millisecond: 542, kind: DateTimeKind.Local), new DateTime(year: 1971, month: 10, day: 12, hour: 9, minute: 51, second: 52, millisecond: 836, kind: DateTimeKind.Local), new DateTime(year: 2001, month: 10, day: 9, hour: 14, minute: 50, second: 12, millisecond: 269, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1976, month: 10, day: 8, hour: 13, minute: 47, second: 24, millisecond: 962, kind: DateTimeKind.Local), new DateTime(year: 1935, month: 10, day: 1, hour: 18, minute: 6, second: 36, millisecond: 428, kind: DateTimeKind.Local), new DateTime(year: 1957, month: 10, day: 14, hour: 18, minute: 55, second: 1, millisecond: 396, kind: DateTimeKind.Local), }, { new DateTime(year: 2003, month: 10, day: 8, hour: 18, minute: 47, second: 37, millisecond: 4, kind: DateTimeKind.Local), new DateTime(year: 1995, month: 10, day: 4, hour: 7, minute: 1, second: 9, millisecond: 72, kind: DateTimeKind.Local), new DateTime(year: 1973, month: 10, day: 2, hour: 22, minute: 29, second: 33, millisecond: 764, kind: DateTimeKind.Local), }, { new DateTime(year: 1965, month: 10, day: 5, hour: 14, minute: 32, second: 45, millisecond: 813, kind: DateTimeKind.Local), new DateTime(year: 1976, month: 10, day: 8, hour: 8, minute: 47, second: 26, millisecond: 741, kind: DateTimeKind.Local), new DateTime(year: 1933, month: 10, day: 14, hour: 2, minute: 32, second: 13, millisecond: 693, kind: DateTimeKind.Local), }, }, },
},
            new DateTimetimestamp_without_time_zoneMMArrayD3E1M
{
    Id = 122,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1932, month: 10, day: 11, hour: 17, minute: 16, second: 37, millisecond: 289, kind: DateTimeKind.Local), new DateTime(year: 1924, month: 10, day: 16, hour: 6, minute: 19, second: 15, millisecond: 824, kind: DateTimeKind.Local), new DateTime(year: 1973, month: 10, day: 14, hour: 11, minute: 44, second: 36, millisecond: 128, kind: DateTimeKind.Local), }, { new DateTime(year: 1934, month: 10, day: 17, hour: 19, minute: 39, second: 29, millisecond: 423, kind: DateTimeKind.Local), new DateTime(year: 1936, month: 10, day: 19, hour: 19, minute: 5, second: 58, millisecond: 997, kind: DateTimeKind.Local), new DateTime(year: 2012, month: 10, day: 17, hour: 14, minute: 28, second: 55, millisecond: 179, kind: DateTimeKind.Local), }, { new DateTime(year: 1923, month: 10, day: 17, hour: 20, minute: 1, second: 34, millisecond: 757, kind: DateTimeKind.Local), new DateTime(year: 1918, month: 10, day: 1, hour: 5, minute: 24, second: 58, millisecond: 81, kind: DateTimeKind.Local), new DateTime(year: 1964, month: 10, day: 12, hour: 3, minute: 19, second: 40, millisecond: 82, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1952, month: 10, day: 9, hour: 19, minute: 33, second: 16, millisecond: 690, kind: DateTimeKind.Local), new DateTime(year: 1918, month: 10, day: 7, hour: 5, minute: 53, second: 45, millisecond: 728, kind: DateTimeKind.Local), new DateTime(year: 1951, month: 10, day: 3, hour: 22, minute: 56, second: 54, millisecond: 425, kind: DateTimeKind.Local), }, { new DateTime(year: 1983, month: 10, day: 10, hour: 18, minute: 26, second: 9, millisecond: 86, kind: DateTimeKind.Local), new DateTime(year: 1985, month: 10, day: 1, hour: 4, minute: 40, second: 18, millisecond: 274, kind: DateTimeKind.Local), new DateTime(year: 1954, month: 10, day: 9, hour: 9, minute: 14, second: 17, millisecond: 863, kind: DateTimeKind.Local), }, { new DateTime(year: 1964, month: 10, day: 9, hour: 18, minute: 16, second: 9, millisecond: 985, kind: DateTimeKind.Local), new DateTime(year: 1944, month: 10, day: 6, hour: 7, minute: 33, second: 11, millisecond: 956, kind: DateTimeKind.Local), new DateTime(year: 1951, month: 10, day: 2, hour: 18, minute: 51, second: 31, millisecond: 557, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 2012, month: 10, day: 9, hour: 15, minute: 44, second: 50, millisecond: 508, kind: DateTimeKind.Local), new DateTime(year: 1965, month: 10, day: 9, hour: 1, minute: 36, second: 5, millisecond: 308, kind: DateTimeKind.Local), new DateTime(year: 1943, month: 10, day: 13, hour: 18, minute: 53, second: 50, millisecond: 74, kind: DateTimeKind.Local), }, { new DateTime(year: 1932, month: 10, day: 7, hour: 21, minute: 8, second: 5, millisecond: 194, kind: DateTimeKind.Local), new DateTime(year: 1931, month: 10, day: 11, hour: 17, minute: 49, second: 49, millisecond: 273, kind: DateTimeKind.Local), new DateTime(year: 1966, month: 10, day: 9, hour: 19, minute: 26, second: 17, millisecond: 986, kind: DateTimeKind.Local), }, { new DateTime(year: 1944, month: 10, day: 18, hour: 20, minute: 38, second: 17, millisecond: 509, kind: DateTimeKind.Local), new DateTime(year: 1935, month: 10, day: 18, hour: 5, minute: 25, second: 48, millisecond: 339, kind: DateTimeKind.Local), new DateTime(year: 2000, month: 10, day: 1, hour: 15, minute: 25, second: 56, millisecond: 102, kind: DateTimeKind.Local), }, }, },
    ModelInner = new DateTimetimestamp_without_time_zoneMMArrayD3E1MI
{
    Id = 63,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1978, month: 10, day: 2, hour: 8, minute: 13, second: 1, millisecond: 638, kind: DateTimeKind.Local), new DateTime(year: 1999, month: 10, day: 5, hour: 11, minute: 19, second: 6, millisecond: 197, kind: DateTimeKind.Local), new DateTime(year: 1958, month: 10, day: 5, hour: 21, minute: 52, second: 53, millisecond: 308, kind: DateTimeKind.Local), }, { new DateTime(year: 1965, month: 10, day: 9, hour: 3, minute: 11, second: 19, millisecond: 964, kind: DateTimeKind.Local), new DateTime(year: 1997, month: 10, day: 8, hour: 18, minute: 27, second: 14, millisecond: 994, kind: DateTimeKind.Local), new DateTime(year: 1962, month: 10, day: 16, hour: 6, minute: 34, second: 9, millisecond: 345, kind: DateTimeKind.Local), }, { new DateTime(year: 1986, month: 10, day: 11, hour: 1, minute: 34, second: 26, millisecond: 800, kind: DateTimeKind.Local), new DateTime(year: 2006, month: 10, day: 16, hour: 21, minute: 42, second: 17, millisecond: 30, kind: DateTimeKind.Local), new DateTime(year: 1951, month: 10, day: 5, hour: 14, minute: 29, second: 45, millisecond: 63, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1992, month: 10, day: 3, hour: 9, minute: 53, second: 24, millisecond: 691, kind: DateTimeKind.Local), new DateTime(year: 1948, month: 10, day: 18, hour: 17, minute: 57, second: 56, millisecond: 6, kind: DateTimeKind.Local), new DateTime(year: 2013, month: 10, day: 3, hour: 10, minute: 43, second: 56, millisecond: 320, kind: DateTimeKind.Local), }, { new DateTime(year: 1960, month: 10, day: 13, hour: 1, minute: 24, second: 23, millisecond: 189, kind: DateTimeKind.Local), new DateTime(year: 1956, month: 10, day: 10, hour: 1, minute: 5, second: 35, millisecond: 664, kind: DateTimeKind.Local), new DateTime(year: 1973, month: 10, day: 9, hour: 14, minute: 43, second: 13, millisecond: 527, kind: DateTimeKind.Local), }, { new DateTime(year: 1924, month: 10, day: 12, hour: 13, minute: 31, second: 56, millisecond: 77, kind: DateTimeKind.Local), new DateTime(year: 1962, month: 10, day: 7, hour: 12, minute: 3, second: 47, millisecond: 102, kind: DateTimeKind.Local), new DateTime(year: 1977, month: 10, day: 14, hour: 8, minute: 30, second: 26, millisecond: 137, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 2001, month: 10, day: 17, hour: 2, minute: 19, second: 27, millisecond: 192, kind: DateTimeKind.Local), new DateTime(year: 1950, month: 10, day: 16, hour: 7, minute: 46, second: 19, millisecond: 794, kind: DateTimeKind.Local), new DateTime(year: 1928, month: 10, day: 8, hour: 4, minute: 54, second: 9, millisecond: 772, kind: DateTimeKind.Local), }, { new DateTime(year: 2002, month: 10, day: 2, hour: 12, minute: 26, second: 55, millisecond: 909, kind: DateTimeKind.Local), new DateTime(year: 1961, month: 10, day: 3, hour: 8, minute: 40, second: 46, millisecond: 188, kind: DateTimeKind.Local), new DateTime(year: 1927, month: 10, day: 9, hour: 7, minute: 3, second: 14, millisecond: 955, kind: DateTimeKind.Local), }, { new DateTime(year: 2000, month: 10, day: 9, hour: 21, minute: 1, second: 12, millisecond: 153, kind: DateTimeKind.Local), new DateTime(year: 1922, month: 10, day: 2, hour: 12, minute: 36, second: 27, millisecond: 367, kind: DateTimeKind.Local), new DateTime(year: 2012, month: 10, day: 7, hour: 4, minute: 33, second: 29, millisecond: 103, kind: DateTimeKind.Local), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneMMArrayD3E1M
{
    Id = 123,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 2001, month: 10, day: 11, hour: 5, minute: 2, second: 10, millisecond: 49, kind: DateTimeKind.Local), new DateTime(year: 1942, month: 10, day: 8, hour: 17, minute: 20, second: 20, millisecond: 658, kind: DateTimeKind.Local), new DateTime(year: 1990, month: 10, day: 19, hour: 21, minute: 17, second: 33, millisecond: 49, kind: DateTimeKind.Local), }, { new DateTime(year: 2009, month: 10, day: 16, hour: 5, minute: 39, second: 54, millisecond: 20, kind: DateTimeKind.Local), new DateTime(year: 1984, month: 10, day: 10, hour: 13, minute: 23, second: 19, millisecond: 686, kind: DateTimeKind.Local), new DateTime(year: 1943, month: 10, day: 11, hour: 19, minute: 46, second: 19, millisecond: 721, kind: DateTimeKind.Local), }, { new DateTime(year: 1980, month: 10, day: 18, hour: 20, minute: 33, second: 2, millisecond: 681, kind: DateTimeKind.Local), new DateTime(year: 1994, month: 10, day: 14, hour: 22, minute: 5, second: 3, millisecond: 855, kind: DateTimeKind.Local), new DateTime(year: 2013, month: 10, day: 18, hour: 10, minute: 15, second: 42, millisecond: 516, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1928, month: 10, day: 4, hour: 16, minute: 58, second: 20, millisecond: 52, kind: DateTimeKind.Local), new DateTime(year: 1989, month: 10, day: 2, hour: 12, minute: 34, second: 6, millisecond: 262, kind: DateTimeKind.Local), new DateTime(year: 1995, month: 10, day: 8, hour: 21, minute: 32, second: 2, millisecond: 953, kind: DateTimeKind.Local), }, { new DateTime(year: 1956, month: 10, day: 17, hour: 1, minute: 34, second: 17, millisecond: 2, kind: DateTimeKind.Local), new DateTime(year: 2016, month: 10, day: 19, hour: 18, minute: 6, second: 44, millisecond: 712, kind: DateTimeKind.Local), new DateTime(year: 2014, month: 10, day: 13, hour: 2, minute: 12, second: 2, millisecond: 911, kind: DateTimeKind.Local), }, { new DateTime(year: 1969, month: 10, day: 9, hour: 7, minute: 6, second: 18, millisecond: 260, kind: DateTimeKind.Local), new DateTime(year: 1959, month: 10, day: 2, hour: 4, minute: 10, second: 1, millisecond: 118, kind: DateTimeKind.Local), new DateTime(year: 2006, month: 10, day: 18, hour: 14, minute: 22, second: 53, millisecond: 95, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1924, month: 10, day: 2, hour: 16, minute: 11, second: 14, millisecond: 309, kind: DateTimeKind.Local), new DateTime(year: 2019, month: 10, day: 10, hour: 2, minute: 9, second: 6, millisecond: 416, kind: DateTimeKind.Local), new DateTime(year: 1996, month: 10, day: 18, hour: 2, minute: 43, second: 54, millisecond: 550, kind: DateTimeKind.Local), }, { new DateTime(year: 2013, month: 10, day: 12, hour: 15, minute: 11, second: 4, millisecond: 735, kind: DateTimeKind.Local), new DateTime(year: 2004, month: 10, day: 19, hour: 10, minute: 5, second: 35, millisecond: 887, kind: DateTimeKind.Local), new DateTime(year: 1942, month: 10, day: 14, hour: 13, minute: 49, second: 54, millisecond: 649, kind: DateTimeKind.Local), }, { new DateTime(year: 1953, month: 10, day: 16, hour: 5, minute: 47, second: 35, millisecond: 280, kind: DateTimeKind.Local), new DateTime(year: 1940, month: 10, day: 16, hour: 13, minute: 25, second: 13, millisecond: 670, kind: DateTimeKind.Local), new DateTime(year: 1919, month: 10, day: 14, hour: 2, minute: 15, second: 14, millisecond: 938, kind: DateTimeKind.Local), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneMMArrayD3E1M
{
    Id = 126,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 2013, month: 10, day: 19, hour: 9, minute: 12, second: 58, millisecond: 551, kind: DateTimeKind.Local), new DateTime(year: 1949, month: 10, day: 18, hour: 9, minute: 3, second: 32, millisecond: 226, kind: DateTimeKind.Local), new DateTime(year: 1933, month: 10, day: 11, hour: 18, minute: 28, second: 35, millisecond: 289, kind: DateTimeKind.Local), }, { new DateTime(year: 1995, month: 10, day: 7, hour: 12, minute: 48, second: 19, millisecond: 915, kind: DateTimeKind.Local), new DateTime(year: 1932, month: 10, day: 13, hour: 2, minute: 36, second: 13, millisecond: 632, kind: DateTimeKind.Local), new DateTime(year: 1972, month: 10, day: 9, hour: 12, minute: 31, second: 31, millisecond: 270, kind: DateTimeKind.Local), }, { new DateTime(year: 1994, month: 10, day: 3, hour: 5, minute: 57, second: 22, millisecond: 246, kind: DateTimeKind.Local), new DateTime(year: 1927, month: 10, day: 17, hour: 15, minute: 46, second: 21, millisecond: 188, kind: DateTimeKind.Local), new DateTime(year: 1920, month: 10, day: 6, hour: 10, minute: 46, second: 12, millisecond: 807, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1976, month: 10, day: 18, hour: 10, minute: 11, second: 49, millisecond: 512, kind: DateTimeKind.Local), new DateTime(year: 1950, month: 10, day: 10, hour: 17, minute: 18, second: 34, millisecond: 878, kind: DateTimeKind.Local), new DateTime(year: 1919, month: 10, day: 1, hour: 17, minute: 37, second: 35, millisecond: 305, kind: DateTimeKind.Local), }, { new DateTime(year: 1970, month: 10, day: 4, hour: 22, minute: 32, second: 31, millisecond: 631, kind: DateTimeKind.Local), new DateTime(year: 1981, month: 10, day: 11, hour: 12, minute: 39, second: 22, millisecond: 759, kind: DateTimeKind.Local), new DateTime(year: 1966, month: 10, day: 14, hour: 13, minute: 57, second: 12, millisecond: 945, kind: DateTimeKind.Local), }, { new DateTime(year: 1976, month: 10, day: 14, hour: 18, minute: 31, second: 57, millisecond: 271, kind: DateTimeKind.Local), new DateTime(year: 1940, month: 10, day: 16, hour: 22, minute: 49, second: 28, millisecond: 934, kind: DateTimeKind.Local), new DateTime(year: 2019, month: 10, day: 7, hour: 22, minute: 39, second: 18, millisecond: 148, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1959, month: 10, day: 9, hour: 14, minute: 26, second: 7, millisecond: 435, kind: DateTimeKind.Local), new DateTime(year: 2016, month: 10, day: 17, hour: 4, minute: 39, second: 25, millisecond: 317, kind: DateTimeKind.Local), new DateTime(year: 1993, month: 10, day: 13, hour: 4, minute: 55, second: 36, millisecond: 73, kind: DateTimeKind.Local), }, { new DateTime(year: 1917, month: 10, day: 6, hour: 19, minute: 3, second: 37, millisecond: 982, kind: DateTimeKind.Local), new DateTime(year: 1996, month: 10, day: 12, hour: 22, minute: 53, second: 55, millisecond: 603, kind: DateTimeKind.Local), new DateTime(year: 1975, month: 10, day: 4, hour: 14, minute: 30, second: 51, millisecond: 815, kind: DateTimeKind.Local), }, { new DateTime(year: 2008, month: 10, day: 15, hour: 9, minute: 22, second: 34, millisecond: 642, kind: DateTimeKind.Local), new DateTime(year: 1922, month: 10, day: 4, hour: 10, minute: 33, second: 13, millisecond: 620, kind: DateTimeKind.Local), new DateTime(year: 1956, month: 10, day: 1, hour: 3, minute: 44, second: 3, millisecond: 746, kind: DateTimeKind.Local), }, }, },
    ModelInner = new DateTimetimestamp_without_time_zoneMMArrayD3E1MI
{
    Id = 64,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 2014, month: 10, day: 11, hour: 8, minute: 24, second: 11, millisecond: 569, kind: DateTimeKind.Local), new DateTime(year: 1995, month: 10, day: 3, hour: 13, minute: 5, second: 11, millisecond: 397, kind: DateTimeKind.Local), new DateTime(year: 1922, month: 10, day: 18, hour: 13, minute: 56, second: 53, millisecond: 375, kind: DateTimeKind.Local), }, { new DateTime(year: 1999, month: 10, day: 16, hour: 12, minute: 15, second: 51, millisecond: 504, kind: DateTimeKind.Local), new DateTime(year: 1998, month: 10, day: 5, hour: 5, minute: 18, second: 27, millisecond: 93, kind: DateTimeKind.Local), new DateTime(year: 1996, month: 10, day: 9, hour: 6, minute: 4, second: 33, millisecond: 213, kind: DateTimeKind.Local), }, { new DateTime(year: 2015, month: 10, day: 6, hour: 3, minute: 19, second: 34, millisecond: 497, kind: DateTimeKind.Local), new DateTime(year: 1985, month: 10, day: 2, hour: 13, minute: 58, second: 15, millisecond: 863, kind: DateTimeKind.Local), new DateTime(year: 1974, month: 10, day: 12, hour: 21, minute: 35, second: 53, millisecond: 947, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1979, month: 10, day: 6, hour: 8, minute: 16, second: 30, millisecond: 378, kind: DateTimeKind.Local), new DateTime(year: 1922, month: 10, day: 15, hour: 5, minute: 47, second: 56, millisecond: 316, kind: DateTimeKind.Local), new DateTime(year: 1987, month: 10, day: 17, hour: 7, minute: 35, second: 44, millisecond: 818, kind: DateTimeKind.Local), }, { new DateTime(year: 1955, month: 10, day: 6, hour: 12, minute: 53, second: 51, millisecond: 444, kind: DateTimeKind.Local), new DateTime(year: 1969, month: 10, day: 8, hour: 16, minute: 25, second: 3, millisecond: 180, kind: DateTimeKind.Local), new DateTime(year: 2013, month: 10, day: 18, hour: 6, minute: 2, second: 52, millisecond: 726, kind: DateTimeKind.Local), }, { new DateTime(year: 1937, month: 10, day: 8, hour: 19, minute: 32, second: 58, millisecond: 256, kind: DateTimeKind.Local), new DateTime(year: 1974, month: 10, day: 17, hour: 10, minute: 41, second: 20, millisecond: 756, kind: DateTimeKind.Local), new DateTime(year: 1993, month: 10, day: 2, hour: 11, minute: 28, second: 36, millisecond: 156, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1948, month: 10, day: 7, hour: 22, minute: 32, second: 23, millisecond: 494, kind: DateTimeKind.Local), new DateTime(year: 1937, month: 10, day: 4, hour: 16, minute: 36, second: 28, millisecond: 865, kind: DateTimeKind.Local), new DateTime(year: 1976, month: 10, day: 15, hour: 1, minute: 54, second: 35, millisecond: 165, kind: DateTimeKind.Local), }, { new DateTime(year: 1965, month: 10, day: 15, hour: 7, minute: 45, second: 1, millisecond: 711, kind: DateTimeKind.Local), new DateTime(year: 1993, month: 10, day: 5, hour: 8, minute: 5, second: 35, millisecond: 635, kind: DateTimeKind.Local), new DateTime(year: 1985, month: 10, day: 6, hour: 3, minute: 34, second: 26, millisecond: 370, kind: DateTimeKind.Local), }, { new DateTime(year: 1962, month: 10, day: 17, hour: 6, minute: 47, second: 33, millisecond: 947, kind: DateTimeKind.Local), new DateTime(year: 1954, month: 10, day: 14, hour: 5, minute: 39, second: 34, millisecond: 991, kind: DateTimeKind.Local), new DateTime(year: 1998, month: 10, day: 5, hour: 15, minute: 11, second: 25, millisecond: 577, kind: DateTimeKind.Local), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneMMArrayD3E1M
{
    Id = 130,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1917, month: 10, day: 6, hour: 16, minute: 49, second: 55, millisecond: 24, kind: DateTimeKind.Local), new DateTime(year: 2017, month: 10, day: 4, hour: 12, minute: 8, second: 56, millisecond: 933, kind: DateTimeKind.Local), new DateTime(year: 1965, month: 10, day: 19, hour: 10, minute: 47, second: 5, millisecond: 583, kind: DateTimeKind.Local), }, { new DateTime(year: 1942, month: 10, day: 18, hour: 22, minute: 21, second: 7, millisecond: 773, kind: DateTimeKind.Local), new DateTime(year: 1984, month: 10, day: 3, hour: 21, minute: 5, second: 6, millisecond: 25, kind: DateTimeKind.Local), new DateTime(year: 1978, month: 10, day: 2, hour: 22, minute: 33, second: 57, millisecond: 574, kind: DateTimeKind.Local), }, { new DateTime(year: 2012, month: 10, day: 2, hour: 11, minute: 38, second: 54, millisecond: 214, kind: DateTimeKind.Local), new DateTime(year: 1993, month: 10, day: 15, hour: 7, minute: 11, second: 40, millisecond: 103, kind: DateTimeKind.Local), new DateTime(year: 1918, month: 10, day: 14, hour: 19, minute: 7, second: 21, millisecond: 439, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 2006, month: 10, day: 10, hour: 14, minute: 38, second: 14, millisecond: 206, kind: DateTimeKind.Local), new DateTime(year: 1957, month: 10, day: 15, hour: 20, minute: 41, second: 20, millisecond: 924, kind: DateTimeKind.Local), new DateTime(year: 1948, month: 10, day: 10, hour: 9, minute: 10, second: 41, millisecond: 119, kind: DateTimeKind.Local), }, { new DateTime(year: 2008, month: 10, day: 18, hour: 4, minute: 21, second: 33, millisecond: 565, kind: DateTimeKind.Local), new DateTime(year: 1946, month: 10, day: 6, hour: 7, minute: 52, second: 16, millisecond: 72, kind: DateTimeKind.Local), new DateTime(year: 1955, month: 10, day: 8, hour: 14, minute: 34, second: 14, millisecond: 733, kind: DateTimeKind.Local), }, { new DateTime(year: 1969, month: 10, day: 4, hour: 22, minute: 21, second: 53, millisecond: 821, kind: DateTimeKind.Local), new DateTime(year: 2000, month: 10, day: 8, hour: 12, minute: 27, second: 45, millisecond: 900, kind: DateTimeKind.Local), new DateTime(year: 1941, month: 10, day: 18, hour: 18, minute: 35, second: 11, millisecond: 223, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1983, month: 10, day: 14, hour: 14, minute: 4, second: 48, millisecond: 129, kind: DateTimeKind.Local), new DateTime(year: 1964, month: 10, day: 11, hour: 14, minute: 4, second: 5, millisecond: 570, kind: DateTimeKind.Local), new DateTime(year: 2000, month: 10, day: 11, hour: 20, minute: 24, second: 6, millisecond: 402, kind: DateTimeKind.Local), }, { new DateTime(year: 1958, month: 10, day: 10, hour: 3, minute: 54, second: 7, millisecond: 242, kind: DateTimeKind.Local), new DateTime(year: 1960, month: 10, day: 17, hour: 2, minute: 46, second: 2, millisecond: 114, kind: DateTimeKind.Local), new DateTime(year: 2000, month: 10, day: 5, hour: 11, minute: 3, second: 58, millisecond: 847, kind: DateTimeKind.Local), }, { new DateTime(year: 1927, month: 10, day: 13, hour: 12, minute: 33, second: 47, millisecond: 509, kind: DateTimeKind.Local), new DateTime(year: 1976, month: 10, day: 14, hour: 6, minute: 19, second: 21, millisecond: 918, kind: DateTimeKind.Local), new DateTime(year: 1947, month: 10, day: 2, hour: 8, minute: 49, second: 51, millisecond: 854, kind: DateTimeKind.Local), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneMMArrayD3E1M
{
    Id = 133,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1951, month: 10, day: 17, hour: 14, minute: 47, second: 38, millisecond: 194, kind: DateTimeKind.Local), new DateTime(year: 2015, month: 10, day: 3, hour: 6, minute: 14, second: 55, millisecond: 12, kind: DateTimeKind.Local), new DateTime(year: 1932, month: 10, day: 5, hour: 15, minute: 23, second: 1, millisecond: 477, kind: DateTimeKind.Local), }, { new DateTime(year: 1929, month: 10, day: 12, hour: 7, minute: 1, second: 53, millisecond: 180, kind: DateTimeKind.Local), new DateTime(year: 1982, month: 10, day: 17, hour: 16, minute: 58, second: 34, millisecond: 556, kind: DateTimeKind.Local), new DateTime(year: 1937, month: 10, day: 9, hour: 19, minute: 40, second: 23, millisecond: 430, kind: DateTimeKind.Local), }, { new DateTime(year: 1951, month: 10, day: 7, hour: 1, minute: 33, second: 58, millisecond: 348, kind: DateTimeKind.Local), new DateTime(year: 1950, month: 10, day: 7, hour: 4, minute: 1, second: 42, millisecond: 583, kind: DateTimeKind.Local), new DateTime(year: 1917, month: 10, day: 1, hour: 18, minute: 51, second: 12, millisecond: 830, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1949, month: 10, day: 6, hour: 12, minute: 30, second: 37, millisecond: 768, kind: DateTimeKind.Local), new DateTime(year: 1963, month: 10, day: 2, hour: 6, minute: 5, second: 51, millisecond: 896, kind: DateTimeKind.Local), new DateTime(year: 1979, month: 10, day: 3, hour: 5, minute: 43, second: 52, millisecond: 436, kind: DateTimeKind.Local), }, { new DateTime(year: 1932, month: 10, day: 5, hour: 9, minute: 31, second: 13, millisecond: 416, kind: DateTimeKind.Local), new DateTime(year: 1927, month: 10, day: 4, hour: 2, minute: 25, second: 47, millisecond: 264, kind: DateTimeKind.Local), new DateTime(year: 1975, month: 10, day: 12, hour: 10, minute: 46, second: 41, millisecond: 358, kind: DateTimeKind.Local), }, { new DateTime(year: 1993, month: 10, day: 16, hour: 17, minute: 52, second: 12, millisecond: 679, kind: DateTimeKind.Local), new DateTime(year: 1952, month: 10, day: 16, hour: 13, minute: 35, second: 37, millisecond: 536, kind: DateTimeKind.Local), new DateTime(year: 2005, month: 10, day: 17, hour: 6, minute: 38, second: 57, millisecond: 634, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1935, month: 10, day: 6, hour: 16, minute: 35, second: 40, millisecond: 650, kind: DateTimeKind.Local), new DateTime(year: 1966, month: 10, day: 16, hour: 16, minute: 20, second: 50, millisecond: 429, kind: DateTimeKind.Local), new DateTime(year: 1932, month: 10, day: 7, hour: 8, minute: 19, second: 17, millisecond: 81, kind: DateTimeKind.Local), }, { new DateTime(year: 1976, month: 10, day: 12, hour: 20, minute: 57, second: 33, millisecond: 409, kind: DateTimeKind.Local), new DateTime(year: 2006, month: 10, day: 18, hour: 17, minute: 9, second: 45, millisecond: 310, kind: DateTimeKind.Local), new DateTime(year: 1935, month: 10, day: 9, hour: 5, minute: 11, second: 28, millisecond: 673, kind: DateTimeKind.Local), }, { new DateTime(year: 1922, month: 10, day: 12, hour: 17, minute: 29, second: 12, millisecond: 667, kind: DateTimeKind.Local), new DateTime(year: 1920, month: 10, day: 9, hour: 1, minute: 12, second: 24, millisecond: 809, kind: DateTimeKind.Local), new DateTime(year: 1980, month: 10, day: 8, hour: 7, minute: 57, second: 38, millisecond: 413, kind: DateTimeKind.Local), }, }, },
    ModelInner = new DateTimetimestamp_without_time_zoneMMArrayD3E1MI
{
    Id = 71,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1970, month: 10, day: 8, hour: 9, minute: 47, second: 33, millisecond: 59, kind: DateTimeKind.Local), new DateTime(year: 1944, month: 10, day: 11, hour: 7, minute: 38, second: 53, millisecond: 971, kind: DateTimeKind.Local), new DateTime(year: 1944, month: 10, day: 14, hour: 2, minute: 45, second: 42, millisecond: 983, kind: DateTimeKind.Local), }, { new DateTime(year: 2010, month: 10, day: 6, hour: 16, minute: 7, second: 55, millisecond: 92, kind: DateTimeKind.Local), new DateTime(year: 2018, month: 10, day: 9, hour: 17, minute: 8, second: 8, millisecond: 378, kind: DateTimeKind.Local), new DateTime(year: 1949, month: 10, day: 11, hour: 14, minute: 23, second: 27, millisecond: 872, kind: DateTimeKind.Local), }, { new DateTime(year: 1981, month: 10, day: 15, hour: 22, minute: 43, second: 38, millisecond: 179, kind: DateTimeKind.Local), new DateTime(year: 1995, month: 10, day: 6, hour: 11, minute: 10, second: 25, millisecond: 770, kind: DateTimeKind.Local), new DateTime(year: 1932, month: 10, day: 14, hour: 3, minute: 10, second: 21, millisecond: 194, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1996, month: 10, day: 18, hour: 22, minute: 48, second: 51, millisecond: 143, kind: DateTimeKind.Local), new DateTime(year: 2017, month: 10, day: 14, hour: 6, minute: 43, second: 45, millisecond: 976, kind: DateTimeKind.Local), new DateTime(year: 1968, month: 10, day: 11, hour: 12, minute: 34, second: 54, millisecond: 723, kind: DateTimeKind.Local), }, { new DateTime(year: 1936, month: 10, day: 11, hour: 2, minute: 49, second: 28, millisecond: 386, kind: DateTimeKind.Local), new DateTime(year: 1960, month: 10, day: 17, hour: 16, minute: 15, second: 1, millisecond: 70, kind: DateTimeKind.Local), new DateTime(year: 1969, month: 10, day: 5, hour: 13, minute: 9, second: 53, millisecond: 982, kind: DateTimeKind.Local), }, { new DateTime(year: 1968, month: 10, day: 2, hour: 12, minute: 40, second: 32, millisecond: 333, kind: DateTimeKind.Local), new DateTime(year: 1951, month: 10, day: 13, hour: 9, minute: 20, second: 23, millisecond: 283, kind: DateTimeKind.Local), new DateTime(year: 1967, month: 10, day: 4, hour: 9, minute: 26, second: 3, millisecond: 239, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 2014, month: 10, day: 18, hour: 17, minute: 14, second: 54, millisecond: 311, kind: DateTimeKind.Local), new DateTime(year: 2002, month: 10, day: 5, hour: 1, minute: 26, second: 54, millisecond: 412, kind: DateTimeKind.Local), new DateTime(year: 1994, month: 10, day: 1, hour: 21, minute: 8, second: 44, millisecond: 679, kind: DateTimeKind.Local), }, { new DateTime(year: 1926, month: 10, day: 1, hour: 11, minute: 4, second: 11, millisecond: 201, kind: DateTimeKind.Local), new DateTime(year: 1946, month: 10, day: 4, hour: 1, minute: 55, second: 15, millisecond: 948, kind: DateTimeKind.Local), new DateTime(year: 1920, month: 10, day: 16, hour: 19, minute: 5, second: 16, millisecond: 996, kind: DateTimeKind.Local), }, { new DateTime(year: 1962, month: 10, day: 17, hour: 9, minute: 25, second: 17, millisecond: 158, kind: DateTimeKind.Local), new DateTime(year: 1950, month: 10, day: 12, hour: 13, minute: 28, second: 27, millisecond: 875, kind: DateTimeKind.Local), new DateTime(year: 2006, month: 10, day: 19, hour: 14, minute: 40, second: 57, millisecond: 937, kind: DateTimeKind.Local), }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1945, month: 10, day: 18, hour: 21, minute: 9, second: 11, millisecond: 524, kind: DateTimeKind.Local), new DateTime(year: 1958, month: 10, day: 8, hour: 8, minute: 12, second: 58, millisecond: 826, kind: DateTimeKind.Local), new DateTime(year: 2000, month: 10, day: 5, hour: 9, minute: 42, second: 57, millisecond: 732, kind: DateTimeKind.Local), }, { new DateTime(year: 1976, month: 10, day: 10, hour: 13, minute: 39, second: 58, millisecond: 32, kind: DateTimeKind.Local), new DateTime(year: 1953, month: 10, day: 4, hour: 11, minute: 1, second: 18, millisecond: 419, kind: DateTimeKind.Local), new DateTime(year: 1962, month: 10, day: 18, hour: 17, minute: 24, second: 12, millisecond: 414, kind: DateTimeKind.Local), }, { new DateTime(year: 1990, month: 10, day: 10, hour: 14, minute: 52, second: 37, millisecond: 471, kind: DateTimeKind.Local), new DateTime(year: 1952, month: 10, day: 15, hour: 19, minute: 34, second: 19, millisecond: 675, kind: DateTimeKind.Local), new DateTime(year: 1967, month: 10, day: 16, hour: 14, minute: 38, second: 18, millisecond: 22, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1969, month: 10, day: 7, hour: 2, minute: 18, second: 55, millisecond: 624, kind: DateTimeKind.Local), new DateTime(year: 2015, month: 10, day: 16, hour: 8, minute: 58, second: 34, millisecond: 902, kind: DateTimeKind.Local), new DateTime(year: 1934, month: 10, day: 15, hour: 22, minute: 1, second: 43, millisecond: 687, kind: DateTimeKind.Local), }, { new DateTime(year: 1987, month: 10, day: 3, hour: 13, minute: 35, second: 35, millisecond: 968, kind: DateTimeKind.Local), new DateTime(year: 1967, month: 10, day: 9, hour: 7, minute: 25, second: 38, millisecond: 815, kind: DateTimeKind.Local), new DateTime(year: 1920, month: 10, day: 5, hour: 5, minute: 11, second: 51, millisecond: 511, kind: DateTimeKind.Local), }, { new DateTime(year: 1966, month: 10, day: 17, hour: 19, minute: 16, second: 32, millisecond: 511, kind: DateTimeKind.Local), new DateTime(year: 1980, month: 10, day: 10, hour: 8, minute: 41, second: 4, millisecond: 417, kind: DateTimeKind.Local), new DateTime(year: 1997, month: 10, day: 3, hour: 12, minute: 14, second: 7, millisecond: 103, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 2006, month: 10, day: 13, hour: 22, minute: 11, second: 36, millisecond: 347, kind: DateTimeKind.Local), new DateTime(year: 1958, month: 10, day: 3, hour: 17, minute: 15, second: 53, millisecond: 737, kind: DateTimeKind.Local), new DateTime(year: 1936, month: 10, day: 2, hour: 1, minute: 52, second: 36, millisecond: 583, kind: DateTimeKind.Local), }, { new DateTime(year: 1957, month: 10, day: 8, hour: 19, minute: 42, second: 10, millisecond: 519, kind: DateTimeKind.Local), new DateTime(year: 1949, month: 10, day: 19, hour: 11, minute: 49, second: 47, millisecond: 447, kind: DateTimeKind.Local), new DateTime(year: 2016, month: 10, day: 5, hour: 1, minute: 24, second: 2, millisecond: 501, kind: DateTimeKind.Local), }, { new DateTime(year: 1928, month: 10, day: 4, hour: 9, minute: 31, second: 2, millisecond: 762, kind: DateTimeKind.Local), new DateTime(year: 1997, month: 10, day: 14, hour: 9, minute: 53, second: 10, millisecond: 537, kind: DateTimeKind.Local), new DateTime(year: 2017, month: 10, day: 8, hour: 9, minute: 42, second: 24, millisecond: 584, kind: DateTimeKind.Local), }, }, },
},
            new DateTimetimestamp_without_time_zoneMMArrayD3E1M
{
    Id = 138,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1927, month: 10, day: 10, hour: 9, minute: 48, second: 52, millisecond: 313, kind: DateTimeKind.Local), new DateTime(year: 2011, month: 10, day: 6, hour: 13, minute: 37, second: 41, millisecond: 846, kind: DateTimeKind.Local), new DateTime(year: 1959, month: 10, day: 16, hour: 6, minute: 46, second: 2, millisecond: 150, kind: DateTimeKind.Local), }, { new DateTime(year: 1928, month: 10, day: 2, hour: 6, minute: 51, second: 53, millisecond: 666, kind: DateTimeKind.Local), new DateTime(year: 2011, month: 10, day: 19, hour: 3, minute: 33, second: 30, millisecond: 673, kind: DateTimeKind.Local), new DateTime(year: 2010, month: 10, day: 8, hour: 6, minute: 32, second: 40, millisecond: 199, kind: DateTimeKind.Local), }, { new DateTime(year: 1962, month: 10, day: 13, hour: 11, minute: 20, second: 5, millisecond: 985, kind: DateTimeKind.Local), new DateTime(year: 1963, month: 10, day: 19, hour: 7, minute: 34, second: 24, millisecond: 123, kind: DateTimeKind.Local), new DateTime(year: 2010, month: 10, day: 9, hour: 4, minute: 35, second: 2, millisecond: 570, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1929, month: 10, day: 7, hour: 11, minute: 7, second: 12, millisecond: 523, kind: DateTimeKind.Local), new DateTime(year: 1984, month: 10, day: 10, hour: 19, minute: 42, second: 25, millisecond: 747, kind: DateTimeKind.Local), new DateTime(year: 1962, month: 10, day: 9, hour: 15, minute: 55, second: 15, millisecond: 819, kind: DateTimeKind.Local), }, { new DateTime(year: 1945, month: 10, day: 9, hour: 11, minute: 36, second: 57, millisecond: 465, kind: DateTimeKind.Local), new DateTime(year: 1938, month: 10, day: 1, hour: 8, minute: 32, second: 35, millisecond: 931, kind: DateTimeKind.Local), new DateTime(year: 2012, month: 10, day: 13, hour: 14, minute: 53, second: 47, millisecond: 847, kind: DateTimeKind.Local), }, { new DateTime(year: 1918, month: 10, day: 16, hour: 12, minute: 11, second: 30, millisecond: 960, kind: DateTimeKind.Local), new DateTime(year: 2013, month: 10, day: 17, hour: 10, minute: 55, second: 1, millisecond: 725, kind: DateTimeKind.Local), new DateTime(year: 2002, month: 10, day: 17, hour: 6, minute: 2, second: 37, millisecond: 184, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 2007, month: 10, day: 16, hour: 8, minute: 43, second: 20, millisecond: 419, kind: DateTimeKind.Local), new DateTime(year: 1999, month: 10, day: 10, hour: 4, minute: 28, second: 52, millisecond: 323, kind: DateTimeKind.Local), new DateTime(year: 1958, month: 10, day: 6, hour: 17, minute: 46, second: 43, millisecond: 233, kind: DateTimeKind.Local), }, { new DateTime(year: 1921, month: 10, day: 8, hour: 15, minute: 5, second: 1, millisecond: 742, kind: DateTimeKind.Local), new DateTime(year: 1979, month: 10, day: 1, hour: 1, minute: 18, second: 54, millisecond: 551, kind: DateTimeKind.Local), new DateTime(year: 1996, month: 10, day: 1, hour: 2, minute: 1, second: 9, millisecond: 296, kind: DateTimeKind.Local), }, { new DateTime(year: 1939, month: 10, day: 7, hour: 10, minute: 37, second: 30, millisecond: 652, kind: DateTimeKind.Local), new DateTime(year: 1921, month: 10, day: 16, hour: 19, minute: 27, second: 1, millisecond: 171, kind: DateTimeKind.Local), new DateTime(year: 1980, month: 10, day: 13, hour: 7, minute: 9, second: 28, millisecond: 787, kind: DateTimeKind.Local), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneMMArrayD3E1M
{
    Id = 139,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1921, month: 10, day: 9, hour: 5, minute: 22, second: 43, millisecond: 12, kind: DateTimeKind.Local), new DateTime(year: 2003, month: 10, day: 7, hour: 17, minute: 49, second: 45, millisecond: 222, kind: DateTimeKind.Local), new DateTime(year: 2016, month: 10, day: 7, hour: 18, minute: 30, second: 58, millisecond: 772, kind: DateTimeKind.Local), }, { new DateTime(year: 1941, month: 10, day: 5, hour: 13, minute: 36, second: 51, millisecond: 492, kind: DateTimeKind.Local), new DateTime(year: 1950, month: 10, day: 17, hour: 19, minute: 32, second: 13, millisecond: 420, kind: DateTimeKind.Local), new DateTime(year: 1976, month: 10, day: 18, hour: 4, minute: 56, second: 13, millisecond: 573, kind: DateTimeKind.Local), }, { new DateTime(year: 1991, month: 10, day: 7, hour: 8, minute: 58, second: 56, millisecond: 386, kind: DateTimeKind.Local), new DateTime(year: 1948, month: 10, day: 12, hour: 16, minute: 27, second: 34, millisecond: 340, kind: DateTimeKind.Local), new DateTime(year: 1931, month: 10, day: 16, hour: 15, minute: 38, second: 33, millisecond: 972, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1929, month: 10, day: 3, hour: 4, minute: 51, second: 37, millisecond: 898, kind: DateTimeKind.Local), new DateTime(year: 2001, month: 10, day: 17, hour: 7, minute: 52, second: 36, millisecond: 213, kind: DateTimeKind.Local), new DateTime(year: 1989, month: 10, day: 1, hour: 7, minute: 48, second: 7, millisecond: 433, kind: DateTimeKind.Local), }, { new DateTime(year: 1991, month: 10, day: 17, hour: 5, minute: 24, second: 33, millisecond: 946, kind: DateTimeKind.Local), new DateTime(year: 2009, month: 10, day: 9, hour: 10, minute: 44, second: 55, millisecond: 677, kind: DateTimeKind.Local), new DateTime(year: 1929, month: 10, day: 8, hour: 9, minute: 7, second: 38, millisecond: 125, kind: DateTimeKind.Local), }, { new DateTime(year: 1992, month: 10, day: 3, hour: 6, minute: 18, second: 15, millisecond: 59, kind: DateTimeKind.Local), new DateTime(year: 1930, month: 10, day: 18, hour: 6, minute: 24, second: 58, millisecond: 962, kind: DateTimeKind.Local), new DateTime(year: 1928, month: 10, day: 11, hour: 3, minute: 50, second: 57, millisecond: 413, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1998, month: 10, day: 3, hour: 18, minute: 29, second: 5, millisecond: 377, kind: DateTimeKind.Local), new DateTime(year: 1984, month: 10, day: 18, hour: 7, minute: 41, second: 43, millisecond: 586, kind: DateTimeKind.Local), new DateTime(year: 1940, month: 10, day: 12, hour: 14, minute: 44, second: 21, millisecond: 203, kind: DateTimeKind.Local), }, { new DateTime(year: 2014, month: 10, day: 17, hour: 16, minute: 34, second: 25, millisecond: 117, kind: DateTimeKind.Local), new DateTime(year: 1967, month: 10, day: 16, hour: 12, minute: 50, second: 24, millisecond: 532, kind: DateTimeKind.Local), new DateTime(year: 1933, month: 10, day: 15, hour: 5, minute: 45, second: 32, millisecond: 353, kind: DateTimeKind.Local), }, { new DateTime(year: 1929, month: 10, day: 12, hour: 18, minute: 5, second: 13, millisecond: 620, kind: DateTimeKind.Local), new DateTime(year: 1938, month: 10, day: 17, hour: 14, minute: 19, second: 7, millisecond: 18, kind: DateTimeKind.Local), new DateTime(year: 1929, month: 10, day: 15, hour: 19, minute: 46, second: 11, millisecond: 558, kind: DateTimeKind.Local), }, }, },
    ModelInner = new DateTimetimestamp_without_time_zoneMMArrayD3E1MI
{
    Id = 74,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1940, month: 10, day: 1, hour: 11, minute: 50, second: 33, millisecond: 302, kind: DateTimeKind.Local), new DateTime(year: 1965, month: 10, day: 2, hour: 11, minute: 32, second: 50, millisecond: 830, kind: DateTimeKind.Local), new DateTime(year: 1940, month: 10, day: 8, hour: 19, minute: 9, second: 19, millisecond: 427, kind: DateTimeKind.Local), }, { new DateTime(year: 1966, month: 10, day: 18, hour: 13, minute: 6, second: 33, millisecond: 461, kind: DateTimeKind.Local), new DateTime(year: 1929, month: 10, day: 3, hour: 7, minute: 20, second: 56, millisecond: 85, kind: DateTimeKind.Local), new DateTime(year: 1982, month: 10, day: 12, hour: 17, minute: 45, second: 38, millisecond: 264, kind: DateTimeKind.Local), }, { new DateTime(year: 1922, month: 10, day: 9, hour: 6, minute: 17, second: 3, millisecond: 181, kind: DateTimeKind.Local), new DateTime(year: 1917, month: 10, day: 1, hour: 21, minute: 16, second: 36, millisecond: 69, kind: DateTimeKind.Local), new DateTime(year: 1971, month: 10, day: 18, hour: 2, minute: 6, second: 9, millisecond: 62, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 2006, month: 10, day: 17, hour: 6, minute: 26, second: 50, millisecond: 254, kind: DateTimeKind.Local), new DateTime(year: 1963, month: 10, day: 8, hour: 1, minute: 37, second: 1, millisecond: 668, kind: DateTimeKind.Local), new DateTime(year: 1969, month: 10, day: 5, hour: 11, minute: 21, second: 21, millisecond: 872, kind: DateTimeKind.Local), }, { new DateTime(year: 1945, month: 10, day: 2, hour: 22, minute: 42, second: 25, millisecond: 925, kind: DateTimeKind.Local), new DateTime(year: 1984, month: 10, day: 15, hour: 13, minute: 24, second: 23, millisecond: 496, kind: DateTimeKind.Local), new DateTime(year: 1919, month: 10, day: 8, hour: 8, minute: 35, second: 55, millisecond: 706, kind: DateTimeKind.Local), }, { new DateTime(year: 1945, month: 10, day: 6, hour: 1, minute: 34, second: 58, millisecond: 20, kind: DateTimeKind.Local), new DateTime(year: 1932, month: 10, day: 16, hour: 7, minute: 10, second: 39, millisecond: 378, kind: DateTimeKind.Local), new DateTime(year: 1958, month: 10, day: 13, hour: 5, minute: 10, second: 58, millisecond: 832, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1997, month: 10, day: 10, hour: 17, minute: 7, second: 5, millisecond: 464, kind: DateTimeKind.Local), new DateTime(year: 1929, month: 10, day: 13, hour: 19, minute: 34, second: 41, millisecond: 501, kind: DateTimeKind.Local), new DateTime(year: 2012, month: 10, day: 12, hour: 4, minute: 17, second: 28, millisecond: 229, kind: DateTimeKind.Local), }, { new DateTime(year: 1947, month: 10, day: 9, hour: 17, minute: 1, second: 22, millisecond: 960, kind: DateTimeKind.Local), new DateTime(year: 2006, month: 10, day: 14, hour: 10, minute: 41, second: 44, millisecond: 748, kind: DateTimeKind.Local), new DateTime(year: 1932, month: 10, day: 6, hour: 15, minute: 11, second: 56, millisecond: 408, kind: DateTimeKind.Local), }, { new DateTime(year: 1978, month: 10, day: 2, hour: 6, minute: 57, second: 20, millisecond: 987, kind: DateTimeKind.Local), new DateTime(year: 1917, month: 10, day: 11, hour: 12, minute: 20, second: 45, millisecond: 635, kind: DateTimeKind.Local), new DateTime(year: 1967, month: 10, day: 12, hour: 17, minute: 16, second: 40, millisecond: 758, kind: DateTimeKind.Local), }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1987, month: 10, day: 17, hour: 3, minute: 36, second: 51, millisecond: 571, kind: DateTimeKind.Local), new DateTime(year: 2004, month: 10, day: 9, hour: 12, minute: 35, second: 1, millisecond: 128, kind: DateTimeKind.Local), new DateTime(year: 1958, month: 10, day: 14, hour: 21, minute: 34, second: 25, millisecond: 662, kind: DateTimeKind.Local), }, { new DateTime(year: 1978, month: 10, day: 19, hour: 21, minute: 37, second: 58, millisecond: 809, kind: DateTimeKind.Local), new DateTime(year: 1984, month: 10, day: 12, hour: 20, minute: 26, second: 13, millisecond: 112, kind: DateTimeKind.Local), new DateTime(year: 1925, month: 10, day: 9, hour: 9, minute: 50, second: 28, millisecond: 526, kind: DateTimeKind.Local), }, { new DateTime(year: 1975, month: 10, day: 5, hour: 10, minute: 39, second: 5, millisecond: 82, kind: DateTimeKind.Local), new DateTime(year: 1935, month: 10, day: 18, hour: 17, minute: 50, second: 27, millisecond: 89, kind: DateTimeKind.Local), new DateTime(year: 1993, month: 10, day: 19, hour: 11, minute: 33, second: 57, millisecond: 60, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1932, month: 10, day: 5, hour: 18, minute: 41, second: 33, millisecond: 238, kind: DateTimeKind.Local), new DateTime(year: 2004, month: 10, day: 11, hour: 11, minute: 26, second: 31, millisecond: 719, kind: DateTimeKind.Local), new DateTime(year: 1995, month: 10, day: 19, hour: 16, minute: 35, second: 21, millisecond: 356, kind: DateTimeKind.Local), }, { new DateTime(year: 1978, month: 10, day: 1, hour: 9, minute: 8, second: 4, millisecond: 239, kind: DateTimeKind.Local), new DateTime(year: 1951, month: 10, day: 10, hour: 15, minute: 49, second: 40, millisecond: 22, kind: DateTimeKind.Local), new DateTime(year: 1961, month: 10, day: 6, hour: 4, minute: 18, second: 37, millisecond: 148, kind: DateTimeKind.Local), }, { new DateTime(year: 1956, month: 10, day: 8, hour: 20, minute: 11, second: 51, millisecond: 867, kind: DateTimeKind.Local), new DateTime(year: 1961, month: 10, day: 6, hour: 3, minute: 4, second: 53, millisecond: 157, kind: DateTimeKind.Local), new DateTime(year: 2008, month: 10, day: 4, hour: 15, minute: 2, second: 48, millisecond: 222, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1962, month: 10, day: 1, hour: 17, minute: 7, second: 12, millisecond: 369, kind: DateTimeKind.Local), new DateTime(year: 1991, month: 10, day: 8, hour: 8, minute: 8, second: 43, millisecond: 83, kind: DateTimeKind.Local), new DateTime(year: 1935, month: 10, day: 5, hour: 17, minute: 6, second: 38, millisecond: 624, kind: DateTimeKind.Local), }, { new DateTime(year: 2005, month: 10, day: 10, hour: 13, minute: 35, second: 58, millisecond: 933, kind: DateTimeKind.Local), new DateTime(year: 1963, month: 10, day: 5, hour: 9, minute: 1, second: 56, millisecond: 40, kind: DateTimeKind.Local), new DateTime(year: 1976, month: 10, day: 7, hour: 2, minute: 48, second: 46, millisecond: 43, kind: DateTimeKind.Local), }, { new DateTime(year: 1961, month: 10, day: 1, hour: 4, minute: 3, second: 56, millisecond: 862, kind: DateTimeKind.Local), new DateTime(year: 1996, month: 10, day: 14, hour: 7, minute: 7, second: 37, millisecond: 933, kind: DateTimeKind.Local), new DateTime(year: 1947, month: 10, day: 6, hour: 2, minute: 19, second: 13, millisecond: 429, kind: DateTimeKind.Local), }, }, },
},
            new DateTimetimestamp_without_time_zoneMMArrayD3E1M
{
    Id = 146,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1917, month: 10, day: 13, hour: 5, minute: 11, second: 53, millisecond: 453, kind: DateTimeKind.Local), new DateTime(year: 1975, month: 10, day: 17, hour: 5, minute: 14, second: 24, millisecond: 652, kind: DateTimeKind.Local), new DateTime(year: 1969, month: 10, day: 6, hour: 1, minute: 4, second: 53, millisecond: 257, kind: DateTimeKind.Local), }, { new DateTime(year: 1971, month: 10, day: 7, hour: 20, minute: 27, second: 8, millisecond: 734, kind: DateTimeKind.Local), new DateTime(year: 2007, month: 10, day: 14, hour: 16, minute: 3, second: 47, millisecond: 477, kind: DateTimeKind.Local), new DateTime(year: 1973, month: 10, day: 19, hour: 5, minute: 18, second: 1, millisecond: 946, kind: DateTimeKind.Local), }, { new DateTime(year: 1927, month: 10, day: 11, hour: 8, minute: 6, second: 56, millisecond: 20, kind: DateTimeKind.Local), new DateTime(year: 1982, month: 10, day: 1, hour: 15, minute: 41, second: 42, millisecond: 866, kind: DateTimeKind.Local), new DateTime(year: 1992, month: 10, day: 4, hour: 9, minute: 57, second: 34, millisecond: 857, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 2011, month: 10, day: 14, hour: 22, minute: 54, second: 45, millisecond: 608, kind: DateTimeKind.Local), new DateTime(year: 1965, month: 10, day: 13, hour: 3, minute: 24, second: 23, millisecond: 488, kind: DateTimeKind.Local), new DateTime(year: 1993, month: 10, day: 2, hour: 13, minute: 45, second: 34, millisecond: 478, kind: DateTimeKind.Local), }, { new DateTime(year: 1950, month: 10, day: 3, hour: 13, minute: 58, second: 28, millisecond: 939, kind: DateTimeKind.Local), new DateTime(year: 2008, month: 10, day: 4, hour: 12, minute: 24, second: 55, millisecond: 901, kind: DateTimeKind.Local), new DateTime(year: 1921, month: 10, day: 3, hour: 4, minute: 33, second: 40, millisecond: 210, kind: DateTimeKind.Local), }, { new DateTime(year: 1983, month: 10, day: 9, hour: 21, minute: 25, second: 26, millisecond: 361, kind: DateTimeKind.Local), new DateTime(year: 1942, month: 10, day: 7, hour: 8, minute: 20, second: 13, millisecond: 945, kind: DateTimeKind.Local), new DateTime(year: 1947, month: 10, day: 12, hour: 11, minute: 23, second: 58, millisecond: 167, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 2005, month: 10, day: 14, hour: 3, minute: 42, second: 48, millisecond: 804, kind: DateTimeKind.Local), new DateTime(year: 1959, month: 10, day: 18, hour: 7, minute: 38, second: 20, millisecond: 99, kind: DateTimeKind.Local), new DateTime(year: 1973, month: 10, day: 14, hour: 13, minute: 9, second: 28, millisecond: 883, kind: DateTimeKind.Local), }, { new DateTime(year: 1997, month: 10, day: 19, hour: 17, minute: 23, second: 49, millisecond: 681, kind: DateTimeKind.Local), new DateTime(year: 2001, month: 10, day: 13, hour: 18, minute: 56, second: 11, millisecond: 552, kind: DateTimeKind.Local), new DateTime(year: 1977, month: 10, day: 9, hour: 15, minute: 23, second: 6, millisecond: 78, kind: DateTimeKind.Local), }, { new DateTime(year: 1961, month: 10, day: 6, hour: 15, minute: 37, second: 42, millisecond: 718, kind: DateTimeKind.Local), new DateTime(year: 1948, month: 10, day: 11, hour: 14, minute: 43, second: 42, millisecond: 945, kind: DateTimeKind.Local), new DateTime(year: 1937, month: 10, day: 11, hour: 16, minute: 25, second: 46, millisecond: 594, kind: DateTimeKind.Local), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneMMArrayD3E1M
{
    Id = 154,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1952, month: 10, day: 3, hour: 15, minute: 14, second: 12, millisecond: 523, kind: DateTimeKind.Local), new DateTime(year: 1971, month: 10, day: 6, hour: 2, minute: 11, second: 41, millisecond: 349, kind: DateTimeKind.Local), new DateTime(year: 1968, month: 10, day: 12, hour: 6, minute: 31, second: 7, millisecond: 714, kind: DateTimeKind.Local), }, { new DateTime(year: 2012, month: 10, day: 4, hour: 17, minute: 44, second: 10, millisecond: 881, kind: DateTimeKind.Local), new DateTime(year: 2009, month: 10, day: 12, hour: 9, minute: 51, second: 33, millisecond: 855, kind: DateTimeKind.Local), new DateTime(year: 1989, month: 10, day: 1, hour: 18, minute: 40, second: 40, millisecond: 611, kind: DateTimeKind.Local), }, { new DateTime(year: 1986, month: 10, day: 1, hour: 17, minute: 51, second: 27, millisecond: 654, kind: DateTimeKind.Local), new DateTime(year: 1995, month: 10, day: 14, hour: 20, minute: 35, second: 43, millisecond: 717, kind: DateTimeKind.Local), new DateTime(year: 1922, month: 10, day: 8, hour: 15, minute: 6, second: 6, millisecond: 233, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1949, month: 10, day: 18, hour: 14, minute: 9, second: 20, millisecond: 93, kind: DateTimeKind.Local), new DateTime(year: 1935, month: 10, day: 9, hour: 22, minute: 54, second: 40, millisecond: 747, kind: DateTimeKind.Local), new DateTime(year: 1926, month: 10, day: 13, hour: 16, minute: 32, second: 21, millisecond: 147, kind: DateTimeKind.Local), }, { new DateTime(year: 1932, month: 10, day: 17, hour: 8, minute: 24, second: 56, millisecond: 884, kind: DateTimeKind.Local), new DateTime(year: 1955, month: 10, day: 10, hour: 11, minute: 8, second: 5, millisecond: 834, kind: DateTimeKind.Local), new DateTime(year: 2013, month: 10, day: 18, hour: 2, minute: 56, second: 40, millisecond: 955, kind: DateTimeKind.Local), }, { new DateTime(year: 1938, month: 10, day: 14, hour: 2, minute: 18, second: 33, millisecond: 9, kind: DateTimeKind.Local), new DateTime(year: 1979, month: 10, day: 16, hour: 15, minute: 42, second: 49, millisecond: 384, kind: DateTimeKind.Local), new DateTime(year: 1937, month: 10, day: 12, hour: 12, minute: 56, second: 50, millisecond: 236, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 2015, month: 10, day: 3, hour: 13, minute: 31, second: 10, millisecond: 330, kind: DateTimeKind.Local), new DateTime(year: 1934, month: 10, day: 7, hour: 9, minute: 44, second: 50, millisecond: 949, kind: DateTimeKind.Local), new DateTime(year: 1968, month: 10, day: 1, hour: 14, minute: 51, second: 50, millisecond: 587, kind: DateTimeKind.Local), }, { new DateTime(year: 1991, month: 10, day: 8, hour: 2, minute: 36, second: 15, millisecond: 317, kind: DateTimeKind.Local), new DateTime(year: 2016, month: 10, day: 17, hour: 15, minute: 10, second: 32, millisecond: 494, kind: DateTimeKind.Local), new DateTime(year: 2015, month: 10, day: 10, hour: 8, minute: 43, second: 47, millisecond: 165, kind: DateTimeKind.Local), }, { new DateTime(year: 1933, month: 10, day: 11, hour: 18, minute: 32, second: 7, millisecond: 639, kind: DateTimeKind.Local), new DateTime(year: 1988, month: 10, day: 6, hour: 8, minute: 22, second: 12, millisecond: 148, kind: DateTimeKind.Local), new DateTime(year: 2015, month: 10, day: 7, hour: 13, minute: 8, second: 16, millisecond: 497, kind: DateTimeKind.Local), }, }, },
    ModelInner = new DateTimetimestamp_without_time_zoneMMArrayD3E1MI
{
    Id = 77,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1971, month: 10, day: 7, hour: 3, minute: 1, second: 22, millisecond: 411, kind: DateTimeKind.Local), new DateTime(year: 2006, month: 10, day: 9, hour: 18, minute: 36, second: 43, millisecond: 503, kind: DateTimeKind.Local), new DateTime(year: 1983, month: 10, day: 8, hour: 19, minute: 34, second: 23, millisecond: 787, kind: DateTimeKind.Local), }, { new DateTime(year: 1981, month: 10, day: 9, hour: 7, minute: 58, second: 9, millisecond: 955, kind: DateTimeKind.Local), new DateTime(year: 2013, month: 10, day: 14, hour: 10, minute: 2, second: 6, millisecond: 300, kind: DateTimeKind.Local), new DateTime(year: 1986, month: 10, day: 16, hour: 9, minute: 10, second: 58, millisecond: 374, kind: DateTimeKind.Local), }, { new DateTime(year: 1963, month: 10, day: 17, hour: 3, minute: 28, second: 52, millisecond: 91, kind: DateTimeKind.Local), new DateTime(year: 1933, month: 10, day: 8, hour: 22, minute: 23, second: 33, millisecond: 119, kind: DateTimeKind.Local), new DateTime(year: 1964, month: 10, day: 17, hour: 17, minute: 25, second: 54, millisecond: 548, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1940, month: 10, day: 9, hour: 9, minute: 5, second: 54, millisecond: 980, kind: DateTimeKind.Local), new DateTime(year: 1931, month: 10, day: 8, hour: 4, minute: 57, second: 43, millisecond: 625, kind: DateTimeKind.Local), new DateTime(year: 1983, month: 10, day: 17, hour: 16, minute: 49, second: 14, millisecond: 224, kind: DateTimeKind.Local), }, { new DateTime(year: 1956, month: 10, day: 17, hour: 10, minute: 52, second: 20, millisecond: 872, kind: DateTimeKind.Local), new DateTime(year: 1992, month: 10, day: 17, hour: 12, minute: 45, second: 56, millisecond: 742, kind: DateTimeKind.Local), new DateTime(year: 1965, month: 10, day: 16, hour: 8, minute: 36, second: 35, millisecond: 870, kind: DateTimeKind.Local), }, { new DateTime(year: 1966, month: 10, day: 19, hour: 14, minute: 50, second: 8, millisecond: 92, kind: DateTimeKind.Local), new DateTime(year: 2007, month: 10, day: 3, hour: 17, minute: 21, second: 45, millisecond: 629, kind: DateTimeKind.Local), new DateTime(year: 1972, month: 10, day: 3, hour: 5, minute: 48, second: 37, millisecond: 736, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1959, month: 10, day: 8, hour: 13, minute: 13, second: 52, millisecond: 801, kind: DateTimeKind.Local), new DateTime(year: 1968, month: 10, day: 13, hour: 4, minute: 7, second: 55, millisecond: 178, kind: DateTimeKind.Local), new DateTime(year: 1946, month: 10, day: 6, hour: 14, minute: 21, second: 30, millisecond: 934, kind: DateTimeKind.Local), }, { new DateTime(year: 1998, month: 10, day: 1, hour: 10, minute: 41, second: 33, millisecond: 891, kind: DateTimeKind.Local), new DateTime(year: 2000, month: 10, day: 12, hour: 5, minute: 10, second: 1, millisecond: 907, kind: DateTimeKind.Local), new DateTime(year: 1920, month: 10, day: 19, hour: 6, minute: 58, second: 54, millisecond: 166, kind: DateTimeKind.Local), }, { new DateTime(year: 1925, month: 10, day: 19, hour: 11, minute: 19, second: 28, millisecond: 824, kind: DateTimeKind.Local), new DateTime(year: 1937, month: 10, day: 14, hour: 16, minute: 53, second: 8, millisecond: 756, kind: DateTimeKind.Local), new DateTime(year: 1943, month: 10, day: 16, hour: 13, minute: 41, second: 6, millisecond: 483, kind: DateTimeKind.Local), }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1932, month: 10, day: 14, hour: 4, minute: 15, second: 34, millisecond: 48, kind: DateTimeKind.Local), new DateTime(year: 1962, month: 10, day: 4, hour: 9, minute: 26, second: 37, millisecond: 46, kind: DateTimeKind.Local), new DateTime(year: 1964, month: 10, day: 1, hour: 14, minute: 39, second: 35, millisecond: 914, kind: DateTimeKind.Local), }, { new DateTime(year: 1996, month: 10, day: 2, hour: 5, minute: 28, second: 42, millisecond: 327, kind: DateTimeKind.Local), new DateTime(year: 1936, month: 10, day: 7, hour: 18, minute: 18, second: 28, millisecond: 249, kind: DateTimeKind.Local), new DateTime(year: 2008, month: 10, day: 19, hour: 14, minute: 17, second: 56, millisecond: 301, kind: DateTimeKind.Local), }, { new DateTime(year: 1949, month: 10, day: 12, hour: 1, minute: 5, second: 44, millisecond: 714, kind: DateTimeKind.Local), new DateTime(year: 1973, month: 10, day: 1, hour: 19, minute: 15, second: 15, millisecond: 351, kind: DateTimeKind.Local), new DateTime(year: 2002, month: 10, day: 1, hour: 16, minute: 8, second: 24, millisecond: 934, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1923, month: 10, day: 12, hour: 6, minute: 57, second: 52, millisecond: 396, kind: DateTimeKind.Local), new DateTime(year: 1947, month: 10, day: 14, hour: 16, minute: 26, second: 52, millisecond: 449, kind: DateTimeKind.Local), new DateTime(year: 1989, month: 10, day: 16, hour: 7, minute: 3, second: 28, millisecond: 411, kind: DateTimeKind.Local), }, { new DateTime(year: 1977, month: 10, day: 7, hour: 2, minute: 14, second: 11, millisecond: 919, kind: DateTimeKind.Local), new DateTime(year: 1925, month: 10, day: 15, hour: 18, minute: 39, second: 24, millisecond: 51, kind: DateTimeKind.Local), new DateTime(year: 1990, month: 10, day: 13, hour: 10, minute: 31, second: 58, millisecond: 310, kind: DateTimeKind.Local), }, { new DateTime(year: 1970, month: 10, day: 1, hour: 14, minute: 23, second: 7, millisecond: 2, kind: DateTimeKind.Local), new DateTime(year: 1946, month: 10, day: 2, hour: 12, minute: 31, second: 11, millisecond: 892, kind: DateTimeKind.Local), new DateTime(year: 1998, month: 10, day: 15, hour: 16, minute: 34, second: 22, millisecond: 48, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1999, month: 10, day: 14, hour: 14, minute: 2, second: 22, millisecond: 916, kind: DateTimeKind.Local), new DateTime(year: 1980, month: 10, day: 8, hour: 13, minute: 30, second: 44, millisecond: 548, kind: DateTimeKind.Local), new DateTime(year: 1941, month: 10, day: 1, hour: 2, minute: 35, second: 17, millisecond: 778, kind: DateTimeKind.Local), }, { new DateTime(year: 1981, month: 10, day: 5, hour: 6, minute: 9, second: 44, millisecond: 74, kind: DateTimeKind.Local), new DateTime(year: 2010, month: 10, day: 11, hour: 8, minute: 18, second: 33, millisecond: 644, kind: DateTimeKind.Local), new DateTime(year: 1987, month: 10, day: 14, hour: 13, minute: 43, second: 53, millisecond: 227, kind: DateTimeKind.Local), }, { new DateTime(year: 1993, month: 10, day: 15, hour: 11, minute: 22, second: 42, millisecond: 678, kind: DateTimeKind.Local), new DateTime(year: 1935, month: 10, day: 15, hour: 14, minute: 24, second: 22, millisecond: 905, kind: DateTimeKind.Local), new DateTime(year: 1984, month: 10, day: 2, hour: 20, minute: 54, second: 28, millisecond: 298, kind: DateTimeKind.Local), }, }, },
},
            new DateTimetimestamp_without_time_zoneMMArrayD3E1M
{
    Id = 161,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1981, month: 10, day: 8, hour: 17, minute: 43, second: 23, millisecond: 942, kind: DateTimeKind.Local), new DateTime(year: 1977, month: 10, day: 8, hour: 12, minute: 25, second: 50, millisecond: 528, kind: DateTimeKind.Local), new DateTime(year: 2001, month: 10, day: 16, hour: 10, minute: 14, second: 28, millisecond: 439, kind: DateTimeKind.Local), }, { new DateTime(year: 1944, month: 10, day: 1, hour: 7, minute: 20, second: 13, millisecond: 983, kind: DateTimeKind.Local), new DateTime(year: 1954, month: 10, day: 10, hour: 4, minute: 29, second: 14, millisecond: 821, kind: DateTimeKind.Local), new DateTime(year: 1919, month: 10, day: 2, hour: 11, minute: 12, second: 1, millisecond: 847, kind: DateTimeKind.Local), }, { new DateTime(year: 2006, month: 10, day: 1, hour: 10, minute: 56, second: 12, millisecond: 806, kind: DateTimeKind.Local), new DateTime(year: 1942, month: 10, day: 13, hour: 1, minute: 6, second: 3, millisecond: 900, kind: DateTimeKind.Local), new DateTime(year: 1988, month: 10, day: 6, hour: 16, minute: 43, second: 52, millisecond: 524, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 2006, month: 10, day: 14, hour: 20, minute: 29, second: 18, millisecond: 275, kind: DateTimeKind.Local), new DateTime(year: 2007, month: 10, day: 3, hour: 7, minute: 21, second: 45, millisecond: 610, kind: DateTimeKind.Local), new DateTime(year: 1939, month: 10, day: 13, hour: 4, minute: 48, second: 50, millisecond: 558, kind: DateTimeKind.Local), }, { new DateTime(year: 1930, month: 10, day: 4, hour: 20, minute: 2, second: 47, millisecond: 775, kind: DateTimeKind.Local), new DateTime(year: 1958, month: 10, day: 11, hour: 2, minute: 11, second: 17, millisecond: 671, kind: DateTimeKind.Local), new DateTime(year: 1983, month: 10, day: 10, hour: 2, minute: 12, second: 13, millisecond: 376, kind: DateTimeKind.Local), }, { new DateTime(year: 1926, month: 10, day: 1, hour: 8, minute: 51, second: 46, millisecond: 419, kind: DateTimeKind.Local), new DateTime(year: 1994, month: 10, day: 2, hour: 8, minute: 6, second: 47, millisecond: 896, kind: DateTimeKind.Local), new DateTime(year: 1971, month: 10, day: 18, hour: 10, minute: 48, second: 34, millisecond: 49, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1932, month: 10, day: 5, hour: 16, minute: 23, second: 53, millisecond: 593, kind: DateTimeKind.Local), new DateTime(year: 1977, month: 10, day: 19, hour: 18, minute: 2, second: 54, millisecond: 327, kind: DateTimeKind.Local), new DateTime(year: 1940, month: 10, day: 3, hour: 22, minute: 22, second: 7, millisecond: 682, kind: DateTimeKind.Local), }, { new DateTime(year: 1987, month: 10, day: 14, hour: 12, minute: 35, second: 13, millisecond: 494, kind: DateTimeKind.Local), new DateTime(year: 1987, month: 10, day: 11, hour: 11, minute: 23, second: 39, millisecond: 795, kind: DateTimeKind.Local), new DateTime(year: 1985, month: 10, day: 14, hour: 14, minute: 34, second: 2, millisecond: 755, kind: DateTimeKind.Local), }, { new DateTime(year: 2006, month: 10, day: 5, hour: 11, minute: 41, second: 52, millisecond: 224, kind: DateTimeKind.Local), new DateTime(year: 1987, month: 10, day: 19, hour: 11, minute: 31, second: 29, millisecond: 218, kind: DateTimeKind.Local), new DateTime(year: 1936, month: 10, day: 9, hour: 17, minute: 11, second: 25, millisecond: 290, kind: DateTimeKind.Local), }, }, },
    ModelInner = null,
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1965, month: 10, day: 1, hour: 18, minute: 47, second: 13, millisecond: 905, kind: DateTimeKind.Local), new DateTime(year: 2012, month: 10, day: 6, hour: 12, minute: 32, second: 39, millisecond: 490, kind: DateTimeKind.Local), new DateTime(year: 2007, month: 10, day: 18, hour: 12, minute: 39, second: 3, millisecond: 606, kind: DateTimeKind.Local), }, { new DateTime(year: 1928, month: 10, day: 15, hour: 10, minute: 15, second: 40, millisecond: 351, kind: DateTimeKind.Local), new DateTime(year: 1933, month: 10, day: 7, hour: 20, minute: 36, second: 21, millisecond: 318, kind: DateTimeKind.Local), new DateTime(year: 1919, month: 10, day: 15, hour: 16, minute: 10, second: 16, millisecond: 618, kind: DateTimeKind.Local), }, { new DateTime(year: 1989, month: 10, day: 7, hour: 22, minute: 47, second: 54, millisecond: 36, kind: DateTimeKind.Local), new DateTime(year: 2011, month: 10, day: 15, hour: 18, minute: 38, second: 46, millisecond: 729, kind: DateTimeKind.Local), new DateTime(year: 2018, month: 10, day: 18, hour: 1, minute: 38, second: 30, millisecond: 89, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1980, month: 10, day: 8, hour: 16, minute: 46, second: 31, millisecond: 119, kind: DateTimeKind.Local), new DateTime(year: 1932, month: 10, day: 5, hour: 4, minute: 33, second: 19, millisecond: 258, kind: DateTimeKind.Local), new DateTime(year: 2011, month: 10, day: 8, hour: 16, minute: 11, second: 4, millisecond: 486, kind: DateTimeKind.Local), }, { new DateTime(year: 1921, month: 10, day: 16, hour: 18, minute: 55, second: 35, millisecond: 91, kind: DateTimeKind.Local), new DateTime(year: 1990, month: 10, day: 14, hour: 4, minute: 57, second: 9, millisecond: 72, kind: DateTimeKind.Local), new DateTime(year: 1967, month: 10, day: 7, hour: 14, minute: 10, second: 35, millisecond: 95, kind: DateTimeKind.Local), }, { new DateTime(year: 1955, month: 10, day: 19, hour: 9, minute: 17, second: 7, millisecond: 68, kind: DateTimeKind.Local), new DateTime(year: 1926, month: 10, day: 4, hour: 8, minute: 53, second: 46, millisecond: 104, kind: DateTimeKind.Local), new DateTime(year: 2002, month: 10, day: 12, hour: 2, minute: 32, second: 36, millisecond: 682, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1971, month: 10, day: 3, hour: 5, minute: 3, second: 20, millisecond: 596, kind: DateTimeKind.Local), new DateTime(year: 1989, month: 10, day: 9, hour: 5, minute: 10, second: 29, millisecond: 958, kind: DateTimeKind.Local), new DateTime(year: 2013, month: 10, day: 17, hour: 11, minute: 39, second: 53, millisecond: 240, kind: DateTimeKind.Local), }, { new DateTime(year: 1961, month: 10, day: 17, hour: 13, minute: 58, second: 32, millisecond: 499, kind: DateTimeKind.Local), new DateTime(year: 1981, month: 10, day: 14, hour: 6, minute: 45, second: 45, millisecond: 29, kind: DateTimeKind.Local), new DateTime(year: 1975, month: 10, day: 16, hour: 8, minute: 24, second: 53, millisecond: 441, kind: DateTimeKind.Local), }, { new DateTime(year: 1933, month: 10, day: 6, hour: 16, minute: 15, second: 45, millisecond: 664, kind: DateTimeKind.Local), new DateTime(year: 1944, month: 10, day: 14, hour: 2, minute: 41, second: 13, millisecond: 147, kind: DateTimeKind.Local), new DateTime(year: 2016, month: 10, day: 6, hour: 13, minute: 43, second: 14, millisecond: 907, kind: DateTimeKind.Local), }, }, },
},
            new DateTimetimestamp_without_time_zoneMMArrayD3E1M
{
    Id = 169,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1939, month: 10, day: 12, hour: 9, minute: 1, second: 2, millisecond: 41, kind: DateTimeKind.Local), new DateTime(year: 2011, month: 10, day: 4, hour: 12, minute: 42, second: 40, millisecond: 574, kind: DateTimeKind.Local), new DateTime(year: 1939, month: 10, day: 19, hour: 22, minute: 25, second: 3, millisecond: 487, kind: DateTimeKind.Local), }, { new DateTime(year: 1957, month: 10, day: 9, hour: 1, minute: 2, second: 9, millisecond: 60, kind: DateTimeKind.Local), new DateTime(year: 1967, month: 10, day: 17, hour: 16, minute: 7, second: 21, millisecond: 87, kind: DateTimeKind.Local), new DateTime(year: 1918, month: 10, day: 16, hour: 19, minute: 28, second: 57, millisecond: 212, kind: DateTimeKind.Local), }, { new DateTime(year: 1976, month: 10, day: 14, hour: 2, minute: 45, second: 13, millisecond: 14, kind: DateTimeKind.Local), new DateTime(year: 1976, month: 10, day: 18, hour: 17, minute: 27, second: 19, millisecond: 160, kind: DateTimeKind.Local), new DateTime(year: 1957, month: 10, day: 8, hour: 18, minute: 25, second: 16, millisecond: 540, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1984, month: 10, day: 15, hour: 12, minute: 36, second: 36, millisecond: 933, kind: DateTimeKind.Local), new DateTime(year: 2007, month: 10, day: 12, hour: 3, minute: 21, second: 24, millisecond: 459, kind: DateTimeKind.Local), new DateTime(year: 1951, month: 10, day: 15, hour: 19, minute: 44, second: 37, millisecond: 268, kind: DateTimeKind.Local), }, { new DateTime(year: 1965, month: 10, day: 6, hour: 2, minute: 13, second: 29, millisecond: 585, kind: DateTimeKind.Local), new DateTime(year: 1998, month: 10, day: 17, hour: 14, minute: 43, second: 14, millisecond: 296, kind: DateTimeKind.Local), new DateTime(year: 1979, month: 10, day: 17, hour: 9, minute: 31, second: 37, millisecond: 438, kind: DateTimeKind.Local), }, { new DateTime(year: 1989, month: 10, day: 8, hour: 12, minute: 34, second: 53, millisecond: 922, kind: DateTimeKind.Local), new DateTime(year: 1924, month: 10, day: 15, hour: 7, minute: 43, second: 11, millisecond: 266, kind: DateTimeKind.Local), new DateTime(year: 1993, month: 10, day: 4, hour: 17, minute: 14, second: 48, millisecond: 269, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1982, month: 10, day: 19, hour: 16, minute: 34, second: 12, millisecond: 510, kind: DateTimeKind.Local), new DateTime(year: 2001, month: 10, day: 7, hour: 1, minute: 16, second: 14, millisecond: 79, kind: DateTimeKind.Local), new DateTime(year: 1926, month: 10, day: 9, hour: 4, minute: 28, second: 31, millisecond: 618, kind: DateTimeKind.Local), }, { new DateTime(year: 1977, month: 10, day: 2, hour: 13, minute: 44, second: 32, millisecond: 587, kind: DateTimeKind.Local), new DateTime(year: 1995, month: 10, day: 3, hour: 18, minute: 51, second: 20, millisecond: 814, kind: DateTimeKind.Local), new DateTime(year: 1957, month: 10, day: 4, hour: 17, minute: 50, second: 14, millisecond: 657, kind: DateTimeKind.Local), }, { new DateTime(year: 1995, month: 10, day: 17, hour: 15, minute: 37, second: 6, millisecond: 849, kind: DateTimeKind.Local), new DateTime(year: 1970, month: 10, day: 17, hour: 17, minute: 26, second: 45, millisecond: 720, kind: DateTimeKind.Local), new DateTime(year: 1982, month: 10, day: 3, hour: 3, minute: 55, second: 5, millisecond: 646, kind: DateTimeKind.Local), }, }, },
    ModelInner = new DateTimetimestamp_without_time_zoneMMArrayD3E1MI
{
    Id = 80,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1996, month: 10, day: 19, hour: 9, minute: 56, second: 25, millisecond: 920, kind: DateTimeKind.Local), new DateTime(year: 1981, month: 10, day: 1, hour: 8, minute: 3, second: 35, millisecond: 197, kind: DateTimeKind.Local), new DateTime(year: 2018, month: 10, day: 7, hour: 18, minute: 27, second: 28, millisecond: 209, kind: DateTimeKind.Local), }, { new DateTime(year: 1936, month: 10, day: 19, hour: 20, minute: 46, second: 54, millisecond: 902, kind: DateTimeKind.Local), new DateTime(year: 1972, month: 10, day: 10, hour: 20, minute: 1, second: 14, millisecond: 175, kind: DateTimeKind.Local), new DateTime(year: 1996, month: 10, day: 7, hour: 14, minute: 31, second: 17, millisecond: 73, kind: DateTimeKind.Local), }, { new DateTime(year: 1966, month: 10, day: 16, hour: 20, minute: 8, second: 53, millisecond: 36, kind: DateTimeKind.Local), new DateTime(year: 2004, month: 10, day: 2, hour: 18, minute: 1, second: 38, millisecond: 511, kind: DateTimeKind.Local), new DateTime(year: 1964, month: 10, day: 8, hour: 13, minute: 10, second: 58, millisecond: 888, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 2003, month: 10, day: 8, hour: 22, minute: 24, second: 29, millisecond: 327, kind: DateTimeKind.Local), new DateTime(year: 1923, month: 10, day: 18, hour: 7, minute: 49, second: 32, millisecond: 875, kind: DateTimeKind.Local), new DateTime(year: 1986, month: 10, day: 9, hour: 15, minute: 42, second: 4, millisecond: 722, kind: DateTimeKind.Local), }, { new DateTime(year: 1979, month: 10, day: 19, hour: 13, minute: 12, second: 35, millisecond: 855, kind: DateTimeKind.Local), new DateTime(year: 1984, month: 10, day: 1, hour: 7, minute: 2, second: 14, millisecond: 838, kind: DateTimeKind.Local), new DateTime(year: 1987, month: 10, day: 1, hour: 19, minute: 58, second: 56, millisecond: 27, kind: DateTimeKind.Local), }, { new DateTime(year: 1938, month: 10, day: 14, hour: 16, minute: 31, second: 6, millisecond: 604, kind: DateTimeKind.Local), new DateTime(year: 1970, month: 10, day: 18, hour: 4, minute: 57, second: 28, millisecond: 199, kind: DateTimeKind.Local), new DateTime(year: 1953, month: 10, day: 9, hour: 5, minute: 36, second: 48, millisecond: 417, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1975, month: 10, day: 11, hour: 17, minute: 55, second: 18, millisecond: 123, kind: DateTimeKind.Local), new DateTime(year: 2017, month: 10, day: 5, hour: 5, minute: 22, second: 57, millisecond: 394, kind: DateTimeKind.Local), new DateTime(year: 1937, month: 10, day: 11, hour: 13, minute: 3, second: 8, millisecond: 852, kind: DateTimeKind.Local), }, { new DateTime(year: 1971, month: 10, day: 9, hour: 14, minute: 10, second: 14, millisecond: 827, kind: DateTimeKind.Local), new DateTime(year: 1928, month: 10, day: 7, hour: 6, minute: 28, second: 13, millisecond: 263, kind: DateTimeKind.Local), new DateTime(year: 1984, month: 10, day: 7, hour: 6, minute: 42, second: 31, millisecond: 435, kind: DateTimeKind.Local), }, { new DateTime(year: 1929, month: 10, day: 6, hour: 2, minute: 55, second: 42, millisecond: 681, kind: DateTimeKind.Local), new DateTime(year: 1938, month: 10, day: 13, hour: 5, minute: 16, second: 36, millisecond: 86, kind: DateTimeKind.Local), new DateTime(year: 2005, month: 10, day: 1, hour: 9, minute: 51, second: 34, millisecond: 82, kind: DateTimeKind.Local), }, }, },
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 1983, month: 10, day: 18, hour: 21, minute: 15, second: 53, millisecond: 468, kind: DateTimeKind.Local), new DateTime(year: 1942, month: 10, day: 2, hour: 8, minute: 56, second: 1, millisecond: 994, kind: DateTimeKind.Local), new DateTime(year: 1952, month: 10, day: 8, hour: 14, minute: 27, second: 3, millisecond: 238, kind: DateTimeKind.Local), }, { new DateTime(year: 2016, month: 10, day: 9, hour: 7, minute: 11, second: 8, millisecond: 589, kind: DateTimeKind.Local), new DateTime(year: 1947, month: 10, day: 17, hour: 19, minute: 58, second: 19, millisecond: 756, kind: DateTimeKind.Local), new DateTime(year: 1941, month: 10, day: 1, hour: 20, minute: 16, second: 5, millisecond: 969, kind: DateTimeKind.Local), }, { new DateTime(year: 1917, month: 10, day: 18, hour: 1, minute: 7, second: 8, millisecond: 536, kind: DateTimeKind.Local), new DateTime(year: 1930, month: 10, day: 2, hour: 12, minute: 45, second: 39, millisecond: 628, kind: DateTimeKind.Local), new DateTime(year: 1991, month: 10, day: 5, hour: 13, minute: 52, second: 18, millisecond: 381, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1973, month: 10, day: 15, hour: 4, minute: 7, second: 52, millisecond: 200, kind: DateTimeKind.Local), new DateTime(year: 2018, month: 10, day: 2, hour: 8, minute: 47, second: 50, millisecond: 309, kind: DateTimeKind.Local), new DateTime(year: 1996, month: 10, day: 7, hour: 4, minute: 33, second: 6, millisecond: 415, kind: DateTimeKind.Local), }, { new DateTime(year: 1932, month: 10, day: 4, hour: 19, minute: 34, second: 28, millisecond: 705, kind: DateTimeKind.Local), new DateTime(year: 1982, month: 10, day: 6, hour: 9, minute: 4, second: 27, millisecond: 751, kind: DateTimeKind.Local), new DateTime(year: 1972, month: 10, day: 18, hour: 11, minute: 29, second: 37, millisecond: 754, kind: DateTimeKind.Local), }, { new DateTime(year: 2005, month: 10, day: 13, hour: 13, minute: 1, second: 3, millisecond: 332, kind: DateTimeKind.Local), new DateTime(year: 2010, month: 10, day: 11, hour: 4, minute: 47, second: 4, millisecond: 898, kind: DateTimeKind.Local), new DateTime(year: 2007, month: 10, day: 9, hour: 22, minute: 28, second: 38, millisecond: 311, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1979, month: 10, day: 5, hour: 8, minute: 22, second: 30, millisecond: 658, kind: DateTimeKind.Local), new DateTime(year: 1934, month: 10, day: 9, hour: 16, minute: 26, second: 55, millisecond: 135, kind: DateTimeKind.Local), new DateTime(year: 1983, month: 10, day: 16, hour: 3, minute: 56, second: 29, millisecond: 515, kind: DateTimeKind.Local), }, { new DateTime(year: 1949, month: 10, day: 9, hour: 5, minute: 57, second: 45, millisecond: 272, kind: DateTimeKind.Local), new DateTime(year: 1925, month: 10, day: 2, hour: 2, minute: 23, second: 16, millisecond: 920, kind: DateTimeKind.Local), new DateTime(year: 1943, month: 10, day: 17, hour: 22, minute: 51, second: 47, millisecond: 213, kind: DateTimeKind.Local), }, { new DateTime(year: 1998, month: 10, day: 6, hour: 13, minute: 1, second: 22, millisecond: 41, kind: DateTimeKind.Local), new DateTime(year: 1979, month: 10, day: 3, hour: 14, minute: 42, second: 7, millisecond: 596, kind: DateTimeKind.Local), new DateTime(year: 1962, month: 10, day: 2, hour: 19, minute: 35, second: 26, millisecond: 314, kind: DateTimeKind.Local), }, }, },
},
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 2015, month: 10, day: 1, hour: 6, minute: 19, second: 56, millisecond: 775, kind: DateTimeKind.Local), new DateTime(year: 1981, month: 10, day: 16, hour: 7, minute: 16, second: 52, millisecond: 536, kind: DateTimeKind.Local), new DateTime(year: 2008, month: 10, day: 19, hour: 5, minute: 54, second: 39, millisecond: 403, kind: DateTimeKind.Local), }, { new DateTime(year: 1941, month: 10, day: 2, hour: 20, minute: 57, second: 10, millisecond: 126, kind: DateTimeKind.Local), new DateTime(year: 1922, month: 10, day: 5, hour: 5, minute: 30, second: 18, millisecond: 198, kind: DateTimeKind.Local), new DateTime(year: 1938, month: 10, day: 12, hour: 16, minute: 21, second: 21, millisecond: 5, kind: DateTimeKind.Local), }, { new DateTime(year: 2017, month: 10, day: 9, hour: 16, minute: 54, second: 30, millisecond: 564, kind: DateTimeKind.Local), new DateTime(year: 1917, month: 10, day: 13, hour: 15, minute: 57, second: 11, millisecond: 724, kind: DateTimeKind.Local), new DateTime(year: 1963, month: 10, day: 7, hour: 2, minute: 26, second: 46, millisecond: 624, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1948, month: 10, day: 7, hour: 3, minute: 39, second: 20, millisecond: 922, kind: DateTimeKind.Local), new DateTime(year: 1983, month: 10, day: 10, hour: 10, minute: 17, second: 33, millisecond: 99, kind: DateTimeKind.Local), new DateTime(year: 2010, month: 10, day: 3, hour: 9, minute: 2, second: 39, millisecond: 399, kind: DateTimeKind.Local), }, { new DateTime(year: 1950, month: 10, day: 7, hour: 10, minute: 40, second: 30, millisecond: 13, kind: DateTimeKind.Local), new DateTime(year: 1989, month: 10, day: 11, hour: 15, minute: 27, second: 8, millisecond: 500, kind: DateTimeKind.Local), new DateTime(year: 1965, month: 10, day: 18, hour: 16, minute: 29, second: 55, millisecond: 450, kind: DateTimeKind.Local), }, { new DateTime(year: 1924, month: 10, day: 9, hour: 15, minute: 21, second: 13, millisecond: 640, kind: DateTimeKind.Local), new DateTime(year: 1938, month: 10, day: 13, hour: 9, minute: 15, second: 4, millisecond: 465, kind: DateTimeKind.Local), new DateTime(year: 1958, month: 10, day: 2, hour: 10, minute: 3, second: 30, millisecond: 548, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1989, month: 10, day: 3, hour: 15, minute: 54, second: 52, millisecond: 502, kind: DateTimeKind.Local), new DateTime(year: 1987, month: 10, day: 4, hour: 18, minute: 23, second: 21, millisecond: 39, kind: DateTimeKind.Local), new DateTime(year: 2018, month: 10, day: 8, hour: 4, minute: 13, second: 44, millisecond: 332, kind: DateTimeKind.Local), }, { new DateTime(year: 1943, month: 10, day: 16, hour: 15, minute: 13, second: 50, millisecond: 80, kind: DateTimeKind.Local), new DateTime(year: 1937, month: 10, day: 7, hour: 22, minute: 7, second: 51, millisecond: 305, kind: DateTimeKind.Local), new DateTime(year: 2019, month: 10, day: 19, hour: 20, minute: 36, second: 40, millisecond: 528, kind: DateTimeKind.Local), }, { new DateTime(year: 1929, month: 10, day: 15, hour: 2, minute: 5, second: 58, millisecond: 964, kind: DateTimeKind.Local), new DateTime(year: 1925, month: 10, day: 14, hour: 5, minute: 57, second: 47, millisecond: 729, kind: DateTimeKind.Local), new DateTime(year: 1936, month: 10, day: 9, hour: 9, minute: 44, second: 7, millisecond: 994, kind: DateTimeKind.Local), }, }, },
},
            new DateTimetimestamp_without_time_zoneMMArrayD3E1M
{
    Id = 178,
    Value = 
new System.DateTime[,,] { { { new DateTime(year: 1972, month: 10, day: 3, hour: 4, minute: 17, second: 33, millisecond: 227, kind: DateTimeKind.Local), new DateTime(year: 1989, month: 10, day: 19, hour: 20, minute: 6, second: 3, millisecond: 754, kind: DateTimeKind.Local), new DateTime(year: 1939, month: 10, day: 11, hour: 16, minute: 27, second: 22, millisecond: 410, kind: DateTimeKind.Local), }, { new DateTime(year: 1937, month: 10, day: 14, hour: 6, minute: 44, second: 3, millisecond: 839, kind: DateTimeKind.Local), new DateTime(year: 1932, month: 10, day: 17, hour: 18, minute: 30, second: 24, millisecond: 235, kind: DateTimeKind.Local), new DateTime(year: 1994, month: 10, day: 6, hour: 12, minute: 30, second: 30, millisecond: 78, kind: DateTimeKind.Local), }, { new DateTime(year: 2016, month: 10, day: 14, hour: 2, minute: 16, second: 2, millisecond: 506, kind: DateTimeKind.Local), new DateTime(year: 1927, month: 10, day: 9, hour: 2, minute: 36, second: 54, millisecond: 507, kind: DateTimeKind.Local), new DateTime(year: 1925, month: 10, day: 12, hour: 4, minute: 37, second: 51, millisecond: 384, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1982, month: 10, day: 5, hour: 19, minute: 22, second: 9, millisecond: 438, kind: DateTimeKind.Local), new DateTime(year: 1970, month: 10, day: 2, hour: 22, minute: 12, second: 36, millisecond: 952, kind: DateTimeKind.Local), new DateTime(year: 1923, month: 10, day: 18, hour: 7, minute: 47, second: 30, millisecond: 775, kind: DateTimeKind.Local), }, { new DateTime(year: 1985, month: 10, day: 8, hour: 2, minute: 3, second: 35, millisecond: 262, kind: DateTimeKind.Local), new DateTime(year: 1950, month: 10, day: 17, hour: 17, minute: 45, second: 48, millisecond: 560, kind: DateTimeKind.Local), new DateTime(year: 1986, month: 10, day: 19, hour: 19, minute: 47, second: 49, millisecond: 388, kind: DateTimeKind.Local), }, { new DateTime(year: 1942, month: 10, day: 15, hour: 14, minute: 50, second: 13, millisecond: 727, kind: DateTimeKind.Local), new DateTime(year: 1919, month: 10, day: 4, hour: 6, minute: 51, second: 57, millisecond: 352, kind: DateTimeKind.Local), new DateTime(year: 1943, month: 10, day: 13, hour: 1, minute: 36, second: 23, millisecond: 702, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1930, month: 10, day: 4, hour: 2, minute: 52, second: 9, millisecond: 307, kind: DateTimeKind.Local), new DateTime(year: 1974, month: 10, day: 19, hour: 8, minute: 41, second: 28, millisecond: 315, kind: DateTimeKind.Local), new DateTime(year: 1992, month: 10, day: 18, hour: 1, minute: 32, second: 1, millisecond: 761, kind: DateTimeKind.Local), }, { new DateTime(year: 1969, month: 10, day: 8, hour: 4, minute: 46, second: 18, millisecond: 549, kind: DateTimeKind.Local), new DateTime(year: 1954, month: 10, day: 7, hour: 1, minute: 44, second: 48, millisecond: 277, kind: DateTimeKind.Local), new DateTime(year: 1964, month: 10, day: 10, hour: 21, minute: 12, second: 50, millisecond: 133, kind: DateTimeKind.Local), }, { new DateTime(year: 1999, month: 10, day: 11, hour: 12, minute: 24, second: 41, millisecond: 852, kind: DateTimeKind.Local), new DateTime(year: 1925, month: 10, day: 1, hour: 8, minute: 47, second: 27, millisecond: 77, kind: DateTimeKind.Local), new DateTime(year: 1931, month: 10, day: 4, hour: 7, minute: 50, second: 42, millisecond: 478, kind: DateTimeKind.Local), }, }, },
    ModelInner = null,
    NullableValue = 
new System.DateTime[,,] { { { new DateTime(year: 2015, month: 10, day: 8, hour: 21, minute: 7, second: 41, millisecond: 549, kind: DateTimeKind.Local), new DateTime(year: 1996, month: 10, day: 7, hour: 6, minute: 58, second: 3, millisecond: 883, kind: DateTimeKind.Local), new DateTime(year: 1994, month: 10, day: 10, hour: 16, minute: 18, second: 43, millisecond: 435, kind: DateTimeKind.Local), }, { new DateTime(year: 1997, month: 10, day: 4, hour: 6, minute: 5, second: 23, millisecond: 12, kind: DateTimeKind.Local), new DateTime(year: 1985, month: 10, day: 18, hour: 8, minute: 36, second: 9, millisecond: 568, kind: DateTimeKind.Local), new DateTime(year: 1993, month: 10, day: 11, hour: 5, minute: 17, second: 15, millisecond: 802, kind: DateTimeKind.Local), }, { new DateTime(year: 1969, month: 10, day: 17, hour: 20, minute: 18, second: 19, millisecond: 760, kind: DateTimeKind.Local), new DateTime(year: 1918, month: 10, day: 17, hour: 1, minute: 38, second: 52, millisecond: 56, kind: DateTimeKind.Local), new DateTime(year: 1985, month: 10, day: 10, hour: 16, minute: 14, second: 45, millisecond: 944, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1952, month: 10, day: 8, hour: 20, minute: 39, second: 34, millisecond: 416, kind: DateTimeKind.Local), new DateTime(year: 1952, month: 10, day: 19, hour: 16, minute: 37, second: 58, millisecond: 601, kind: DateTimeKind.Local), new DateTime(year: 1956, month: 10, day: 19, hour: 14, minute: 17, second: 33, millisecond: 484, kind: DateTimeKind.Local), }, { new DateTime(year: 1965, month: 10, day: 10, hour: 18, minute: 29, second: 37, millisecond: 799, kind: DateTimeKind.Local), new DateTime(year: 1981, month: 10, day: 3, hour: 21, minute: 30, second: 46, millisecond: 910, kind: DateTimeKind.Local), new DateTime(year: 1919, month: 10, day: 9, hour: 5, minute: 30, second: 13, millisecond: 779, kind: DateTimeKind.Local), }, { new DateTime(year: 1999, month: 10, day: 6, hour: 4, minute: 13, second: 23, millisecond: 766, kind: DateTimeKind.Local), new DateTime(year: 1997, month: 10, day: 2, hour: 10, minute: 45, second: 14, millisecond: 184, kind: DateTimeKind.Local), new DateTime(year: 2004, month: 10, day: 19, hour: 15, minute: 54, second: 54, millisecond: 847, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1972, month: 10, day: 11, hour: 16, minute: 23, second: 54, millisecond: 856, kind: DateTimeKind.Local), new DateTime(year: 1951, month: 10, day: 12, hour: 14, minute: 54, second: 5, millisecond: 976, kind: DateTimeKind.Local), new DateTime(year: 1923, month: 10, day: 7, hour: 14, minute: 24, second: 23, millisecond: 434, kind: DateTimeKind.Local), }, { new DateTime(year: 1983, month: 10, day: 8, hour: 15, minute: 53, second: 30, millisecond: 893, kind: DateTimeKind.Local), new DateTime(year: 1971, month: 10, day: 19, hour: 16, minute: 5, second: 32, millisecond: 169, kind: DateTimeKind.Local), new DateTime(year: 1990, month: 10, day: 1, hour: 7, minute: 18, second: 7, millisecond: 476, kind: DateTimeKind.Local), }, { new DateTime(year: 1950, month: 10, day: 1, hour: 5, minute: 11, second: 25, millisecond: 560, kind: DateTimeKind.Local), new DateTime(year: 1984, month: 10, day: 8, hour: 15, minute: 45, second: 14, millisecond: 772, kind: DateTimeKind.Local), new DateTime(year: 1927, month: 10, day: 8, hour: 14, minute: 55, second: 20, millisecond: 221, kind: DateTimeKind.Local), }, }, },
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zonemmarrayd3e1mi(
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
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483627)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[,,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483627))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zonemmarrayd3e1mi(
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
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483627)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[,,]), 
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

                changedRows =  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zonemmarrayd3e1m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_without_time_zonemmarrayd3e1mi_id
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
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483627)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[,,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483627)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "datetimetimestamp_without_time_zonemmarrayd3e1mi_id", 
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
                changedRows =  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zonemmarrayd3e1m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_without_time_zonemmarrayd3e1mi_id
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
    datetimetimestamp_without_time_zonemmarrayd3e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)),
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
                    ((NpgsqlParameter<System.DateTime[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483627);
                    ((NpgsqlParameter<System.DateTime[,,]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.DateTime[,,] { { { new DateTime(year: 1988, month: 10, day: 5, hour: 10, minute: 46, second: 45, millisecond: 916, kind: DateTimeKind.Local), new DateTime(year: 1927, month: 10, day: 6, hour: 20, minute: 37, second: 8, millisecond: 875, kind: DateTimeKind.Local), new DateTime(year: 1930, month: 10, day: 5, hour: 7, minute: 36, second: 20, millisecond: 989, kind: DateTimeKind.Local), }, { new DateTime(year: 1960, month: 10, day: 12, hour: 22, minute: 48, second: 43, millisecond: 710, kind: DateTimeKind.Local), new DateTime(year: 1967, month: 10, day: 16, hour: 14, minute: 53, second: 33, millisecond: 934, kind: DateTimeKind.Local), new DateTime(year: 1985, month: 10, day: 6, hour: 9, minute: 34, second: 21, millisecond: 429, kind: DateTimeKind.Local), }, { new DateTime(year: 1995, month: 10, day: 5, hour: 1, minute: 22, second: 58, millisecond: 85, kind: DateTimeKind.Local), new DateTime(year: 1948, month: 10, day: 4, hour: 1, minute: 35, second: 52, millisecond: 450, kind: DateTimeKind.Local), new DateTime(year: 2014, month: 10, day: 12, hour: 3, minute: 32, second: 23, millisecond: 216, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1978, month: 10, day: 8, hour: 16, minute: 42, second: 35, millisecond: 700, kind: DateTimeKind.Local), new DateTime(year: 1935, month: 10, day: 8, hour: 22, minute: 53, second: 32, millisecond: 723, kind: DateTimeKind.Local), new DateTime(year: 2011, month: 10, day: 4, hour: 1, minute: 31, second: 16, millisecond: 191, kind: DateTimeKind.Local), }, { new DateTime(year: 1935, month: 10, day: 5, hour: 18, minute: 21, second: 6, millisecond: 736, kind: DateTimeKind.Local), new DateTime(year: 1975, month: 10, day: 14, hour: 22, minute: 19, second: 31, millisecond: 543, kind: DateTimeKind.Local), new DateTime(year: 1930, month: 10, day: 4, hour: 13, minute: 50, second: 53, millisecond: 836, kind: DateTimeKind.Local), }, { new DateTime(year: 1965, month: 10, day: 4, hour: 18, minute: 8, second: 44, millisecond: 223, kind: DateTimeKind.Local), new DateTime(year: 1958, month: 10, day: 13, hour: 13, minute: 53, second: 23, millisecond: 485, kind: DateTimeKind.Local), new DateTime(year: 1917, month: 10, day: 17, hour: 2, minute: 20, second: 52, millisecond: 373, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1963, month: 10, day: 3, hour: 14, minute: 5, second: 5, millisecond: 493, kind: DateTimeKind.Local), new DateTime(year: 2006, month: 10, day: 11, hour: 20, minute: 23, second: 56, millisecond: 288, kind: DateTimeKind.Local), new DateTime(year: 1994, month: 10, day: 16, hour: 13, minute: 42, second: 49, millisecond: 284, kind: DateTimeKind.Local), }, { new DateTime(year: 2005, month: 10, day: 9, hour: 15, minute: 54, second: 23, millisecond: 186, kind: DateTimeKind.Local), new DateTime(year: 1975, month: 10, day: 4, hour: 7, minute: 26, second: 12, millisecond: 353, kind: DateTimeKind.Local), new DateTime(year: 2015, month: 10, day: 8, hour: 18, minute: 51, second: 34, millisecond: 101, kind: DateTimeKind.Local), }, { new DateTime(year: 1958, month: 10, day: 11, hour: 13, minute: 51, second: 54, millisecond: 830, kind: DateTimeKind.Local), new DateTime(year: 2002, month: 10, day: 9, hour: 7, minute: 50, second: 26, millisecond: 982, kind: DateTimeKind.Local), new DateTime(year: 2011, month: 10, day: 11, hour: 8, minute: 41, second: 37, millisecond: 805, kind: DateTimeKind.Local), }, }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.DateTime[,,]>();
                    ((NpgsqlParameter<System.DateTime[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483627);
                    ((NpgsqlParameter<System.DateTime[,,]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                    ((NpgsqlParameter<System.DateTime[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483627);
                    ((NpgsqlParameter<System.DateTime[,,]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.DateTime[,,]>();
                    ((NpgsqlParameter<System.DateTime[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483627);
                    ((NpgsqlParameter<System.DateTime[,,]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.DateTime[,,] { { { new DateTime(year: 2002, month: 10, day: 13, hour: 16, minute: 33, second: 30, millisecond: 814, kind: DateTimeKind.Local), new DateTime(year: 1997, month: 10, day: 19, hour: 9, minute: 7, second: 9, millisecond: 412, kind: DateTimeKind.Local), new DateTime(year: 2007, month: 10, day: 18, hour: 10, minute: 10, second: 54, millisecond: 587, kind: DateTimeKind.Local), }, { new DateTime(year: 1952, month: 10, day: 2, hour: 8, minute: 39, second: 48, millisecond: 545, kind: DateTimeKind.Local), new DateTime(year: 1940, month: 10, day: 19, hour: 3, minute: 5, second: 39, millisecond: 324, kind: DateTimeKind.Local), new DateTime(year: 1994, month: 10, day: 4, hour: 16, minute: 14, second: 50, millisecond: 255, kind: DateTimeKind.Local), }, { new DateTime(year: 1919, month: 10, day: 18, hour: 10, minute: 36, second: 27, millisecond: 257, kind: DateTimeKind.Local), new DateTime(year: 1953, month: 10, day: 10, hour: 22, minute: 5, second: 27, millisecond: 73, kind: DateTimeKind.Local), new DateTime(year: 1998, month: 10, day: 16, hour: 14, minute: 45, second: 5, millisecond: 365, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1985, month: 10, day: 4, hour: 14, minute: 41, second: 41, millisecond: 714, kind: DateTimeKind.Local), new DateTime(year: 1962, month: 10, day: 8, hour: 12, minute: 54, second: 45, millisecond: 208, kind: DateTimeKind.Local), new DateTime(year: 1958, month: 10, day: 6, hour: 2, minute: 12, second: 4, millisecond: 546, kind: DateTimeKind.Local), }, { new DateTime(year: 1959, month: 10, day: 13, hour: 3, minute: 45, second: 53, millisecond: 139, kind: DateTimeKind.Local), new DateTime(year: 1986, month: 10, day: 3, hour: 15, minute: 55, second: 32, millisecond: 626, kind: DateTimeKind.Local), new DateTime(year: 1983, month: 10, day: 16, hour: 13, minute: 32, second: 45, millisecond: 308, kind: DateTimeKind.Local), }, { new DateTime(year: 1984, month: 10, day: 8, hour: 21, minute: 56, second: 24, millisecond: 376, kind: DateTimeKind.Local), new DateTime(year: 1957, month: 10, day: 7, hour: 2, minute: 17, second: 20, millisecond: 388, kind: DateTimeKind.Local), new DateTime(year: 1982, month: 10, day: 12, hour: 8, minute: 4, second: 19, millisecond: 858, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1973, month: 10, day: 6, hour: 12, minute: 4, second: 26, millisecond: 605, kind: DateTimeKind.Local), new DateTime(year: 2006, month: 10, day: 4, hour: 8, minute: 36, second: 45, millisecond: 763, kind: DateTimeKind.Local), new DateTime(year: 1918, month: 10, day: 13, hour: 15, minute: 5, second: 54, millisecond: 580, kind: DateTimeKind.Local), }, { new DateTime(year: 2016, month: 10, day: 4, hour: 15, minute: 38, second: 46, millisecond: 723, kind: DateTimeKind.Local), new DateTime(year: 1976, month: 10, day: 6, hour: 16, minute: 25, second: 57, millisecond: 19, kind: DateTimeKind.Local), new DateTime(year: 1938, month: 10, day: 6, hour: 18, minute: 57, second: 7, millisecond: 973, kind: DateTimeKind.Local), }, { new DateTime(year: 2013, month: 10, day: 11, hour: 4, minute: 7, second: 34, millisecond: 897, kind: DateTimeKind.Local), new DateTime(year: 1952, month: 10, day: 11, hour: 18, minute: 6, second: 38, millisecond: 713, kind: DateTimeKind.Local), new DateTime(year: 1925, month: 10, day: 9, hour: 3, minute: 30, second: 1, millisecond: 588, kind: DateTimeKind.Local), }, }, }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zonemmarrayd3e1m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_without_time_zonemmarrayd3e1mi_id
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
    datetimetimestamp_without_time_zonemmarrayd3e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483627)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[,,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483627)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "datetimetimestamp_without_time_zonemmarrayd3e1mi_id", 
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
                nullable =  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.DateTime[,,] nullable = null;
                nullable = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.DateTime[,,] { { { new DateTime(year: 1934, month: 10, day: 15, hour: 8, minute: 58, second: 14, millisecond: 140, kind: DateTimeKind.Local), new DateTime(year: 1963, month: 10, day: 11, hour: 1, minute: 55, second: 1, millisecond: 266, kind: DateTimeKind.Local), new DateTime(year: 2007, month: 10, day: 10, hour: 20, minute: 13, second: 24, millisecond: 474, kind: DateTimeKind.Local), }, { new DateTime(year: 1935, month: 10, day: 17, hour: 19, minute: 15, second: 52, millisecond: 325, kind: DateTimeKind.Local), new DateTime(year: 1967, month: 10, day: 9, hour: 21, minute: 51, second: 20, millisecond: 558, kind: DateTimeKind.Local), new DateTime(year: 1984, month: 10, day: 1, hour: 10, minute: 25, second: 11, millisecond: 903, kind: DateTimeKind.Local), }, { new DateTime(year: 1951, month: 10, day: 14, hour: 12, minute: 24, second: 35, millisecond: 600, kind: DateTimeKind.Local), new DateTime(year: 2001, month: 10, day: 16, hour: 11, minute: 19, second: 18, millisecond: 112, kind: DateTimeKind.Local), new DateTime(year: 2011, month: 10, day: 16, hour: 7, minute: 6, second: 2, millisecond: 620, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1964, month: 10, day: 13, hour: 2, minute: 30, second: 14, millisecond: 344, kind: DateTimeKind.Local), new DateTime(year: 1964, month: 10, day: 6, hour: 13, minute: 58, second: 48, millisecond: 896, kind: DateTimeKind.Local), new DateTime(year: 1920, month: 10, day: 2, hour: 18, minute: 56, second: 52, millisecond: 751, kind: DateTimeKind.Local), }, { new DateTime(year: 1985, month: 10, day: 15, hour: 2, minute: 2, second: 56, millisecond: 435, kind: DateTimeKind.Local), new DateTime(year: 1957, month: 10, day: 8, hour: 17, minute: 16, second: 33, millisecond: 283, kind: DateTimeKind.Local), new DateTime(year: 2019, month: 10, day: 16, hour: 9, minute: 36, second: 43, millisecond: 449, kind: DateTimeKind.Local), }, { new DateTime(year: 1951, month: 10, day: 18, hour: 11, minute: 27, second: 6, millisecond: 545, kind: DateTimeKind.Local), new DateTime(year: 1964, month: 10, day: 6, hour: 22, minute: 41, second: 26, millisecond: 373, kind: DateTimeKind.Local), new DateTime(year: 2003, month: 10, day: 9, hour: 10, minute: 5, second: 19, millisecond: 146, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 2000, month: 10, day: 17, hour: 19, minute: 50, second: 7, millisecond: 264, kind: DateTimeKind.Local), new DateTime(year: 2016, month: 10, day: 7, hour: 11, minute: 10, second: 6, millisecond: 291, kind: DateTimeKind.Local), new DateTime(year: 1999, month: 10, day: 19, hour: 18, minute: 4, second: 11, millisecond: 820, kind: DateTimeKind.Local), }, { new DateTime(year: 1951, month: 10, day: 12, hour: 5, minute: 3, second: 33, millisecond: 143, kind: DateTimeKind.Local), new DateTime(year: 2003, month: 10, day: 19, hour: 22, minute: 42, second: 55, millisecond: 723, kind: DateTimeKind.Local), new DateTime(year: 1987, month: 10, day: 7, hour: 21, minute: 19, second: 12, millisecond: 58, kind: DateTimeKind.Local), }, { new DateTime(year: 1980, month: 10, day: 19, hour: 4, minute: 12, second: 29, millisecond: 682, kind: DateTimeKind.Local), new DateTime(year: 1995, month: 10, day: 5, hour: 4, minute: 2, second: 17, millisecond: 641, kind: DateTimeKind.Local), new DateTime(year: 1924, month: 10, day: 18, hour: 6, minute: 40, second: 56, millisecond: 281, kind: DateTimeKind.Local), }, }, }));
                nullable = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.DateTime[,,] { { { new DateTime(year: 1993, month: 10, day: 15, hour: 8, minute: 35, second: 24, millisecond: 976, kind: DateTimeKind.Local), new DateTime(year: 1960, month: 10, day: 19, hour: 22, minute: 25, second: 35, millisecond: 885, kind: DateTimeKind.Local), new DateTime(year: 1943, month: 10, day: 18, hour: 18, minute: 25, second: 6, millisecond: 640, kind: DateTimeKind.Local), }, { new DateTime(year: 2015, month: 10, day: 12, hour: 11, minute: 9, second: 49, millisecond: 558, kind: DateTimeKind.Local), new DateTime(year: 1983, month: 10, day: 5, hour: 6, minute: 17, second: 12, millisecond: 216, kind: DateTimeKind.Local), new DateTime(year: 1956, month: 10, day: 4, hour: 10, minute: 35, second: 2, millisecond: 116, kind: DateTimeKind.Local), }, { new DateTime(year: 1930, month: 10, day: 15, hour: 1, minute: 25, second: 39, millisecond: 973, kind: DateTimeKind.Local), new DateTime(year: 2018, month: 10, day: 8, hour: 8, minute: 51, second: 20, millisecond: 926, kind: DateTimeKind.Local), new DateTime(year: 1987, month: 10, day: 5, hour: 6, minute: 3, second: 16, millisecond: 788, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1939, month: 10, day: 8, hour: 14, minute: 27, second: 26, millisecond: 152, kind: DateTimeKind.Local), new DateTime(year: 1933, month: 10, day: 12, hour: 14, minute: 3, second: 43, millisecond: 427, kind: DateTimeKind.Local), new DateTime(year: 1924, month: 10, day: 7, hour: 10, minute: 24, second: 15, millisecond: 241, kind: DateTimeKind.Local), }, { new DateTime(year: 1951, month: 10, day: 12, hour: 15, minute: 9, second: 58, millisecond: 900, kind: DateTimeKind.Local), new DateTime(year: 1947, month: 10, day: 4, hour: 21, minute: 8, second: 13, millisecond: 946, kind: DateTimeKind.Local), new DateTime(year: 1941, month: 10, day: 9, hour: 4, minute: 54, second: 8, millisecond: 178, kind: DateTimeKind.Local), }, { new DateTime(year: 1943, month: 10, day: 6, hour: 21, minute: 56, second: 20, millisecond: 483, kind: DateTimeKind.Local), new DateTime(year: 2001, month: 10, day: 15, hour: 11, minute: 47, second: 1, millisecond: 239, kind: DateTimeKind.Local), new DateTime(year: 1966, month: 10, day: 15, hour: 5, minute: 38, second: 30, millisecond: 867, kind: DateTimeKind.Local), }, }, { { new DateTime(year: 1946, month: 10, day: 10, hour: 14, minute: 22, second: 29, millisecond: 344, kind: DateTimeKind.Local), new DateTime(year: 1950, month: 10, day: 19, hour: 13, minute: 40, second: 26, millisecond: 47, kind: DateTimeKind.Local), new DateTime(year: 1938, month: 10, day: 5, hour: 12, minute: 49, second: 43, millisecond: 303, kind: DateTimeKind.Local), }, { new DateTime(year: 1956, month: 10, day: 13, hour: 13, minute: 40, second: 5, millisecond: 526, kind: DateTimeKind.Local), new DateTime(year: 1977, month: 10, day: 9, hour: 2, minute: 14, second: 19, millisecond: 661, kind: DateTimeKind.Local), new DateTime(year: 1943, month: 10, day: 18, hour: 7, minute: 54, second: 35, millisecond: 888, kind: DateTimeKind.Local), }, { new DateTime(year: 1918, month: 10, day: 5, hour: 1, minute: 26, second: 39, millisecond: 403, kind: DateTimeKind.Local), new DateTime(year: 1923, month: 10, day: 4, hour: 9, minute: 32, second: 17, millisecond: 446, kind: DateTimeKind.Local), new DateTime(year: 1940, month: 10, day: 12, hour: 18, minute: 7, second: 37, millisecond: 760, kind: DateTimeKind.Local), }, }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DateTimetimestamp_without_time_zoneMMArrayD3E1M> models = null;

                models =  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DateTimetimestamp_without_time_zoneMMArrayD3E1M> models = null;

                models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M), typeof(FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)),
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)),
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
LEFT JOIN public.datetimetimestamp_without_time_zonemmarrayd3e1mi mi ON mi.id = m.datetimetimestamp_without_time_zonemmarrayd3e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)),
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
                var models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M), typeof(FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)),
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)),
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
LEFT JOIN public.datetimetimestamp_without_time_zonemmarrayd3e1mi mi ON mi.id = m.datetimetimestamp_without_time_zonemmarrayd3e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)),
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
                var models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M), typeof(FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)),
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
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)),
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                await((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 154;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[25],_testData[34], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                 ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 66;
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                 ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[17],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)),
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
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)),
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[10],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[11],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[12],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[13],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[14],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[15],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[16],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[17],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[18],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[19],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[20],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[21],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[22],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[23],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[24],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[25],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[26],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[27],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[28],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[29],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[10],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[11],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[12],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[13],_testData[34], false);
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 146;
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[3], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[10],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[11],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[12],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[13],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[14],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[15],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[16],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[17],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[18],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[19],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[20],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[21],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[22],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[23],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[24],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[25],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[26],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[27],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[28],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[29],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[30],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[31],_testData[34], false);
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                 ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
LEFT JOIN public.datetimetimestamp_without_time_zonemmarrayd3e1mi mi ON mi.id = m.datetimetimestamp_without_time_zonemmarrayd3e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)),
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
                var models = await((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[28], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[29], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[30], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[31], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[32], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[33], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[30], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[31], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[32], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[33], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[34], false);
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
                var models = ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[12], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[13], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[14], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[15], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[16], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[17], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[18], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[19], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[20], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[21], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[10],_testData[22], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[11],_testData[23], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[12],_testData[24], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[13],_testData[25], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[14],_testData[26], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[15],_testData[27], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[16],_testData[28], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[17],_testData[29], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[18],_testData[30], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[19],_testData[31], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[20],_testData[32], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[21],_testData[33], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[6], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[7], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[8], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[9], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[10], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[11], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[12], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[13], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[14], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[15], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[10],_testData[16], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[11],_testData[17], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[12],_testData[18], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[13],_testData[19], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[14],_testData[20], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[15],_testData[21], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[16],_testData[22], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[17],_testData[23], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[18],_testData[24], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[19],_testData[25], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[20],_testData[26], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[21],_testData[27], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[22],_testData[28], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[23],_testData[29], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[24],_testData[30], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[25],_testData[31], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[26],_testData[32], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[27],_testData[33], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M), typeof(FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)),
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
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)),
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
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)),
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                await((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 41, query1, 5, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 96, query1, 139, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[4],_testData[34], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                 ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 66, query1, 122, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                 ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DbConnectionMMDynQuerySelectModelBatch(connection, 47, query1, 138, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[5],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)),
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
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)),
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
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)),
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 24, query1, 130, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[10],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[11],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[12],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[13],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[14],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[15],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[16],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[17],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[18],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[19],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[20],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[21],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[22],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[23],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[24],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[25],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[26],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[27],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[28],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[29],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[34], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 113, query1, 96, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DbConnectionSTDynQuerySelectModelBatch(connection, 102, query1, 34, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[10],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[11],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[12],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[13],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[10],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[11],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[12],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[13],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[14],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[15],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[16],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[17],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[18],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[19],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[20],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[21],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[22],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[23],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[24],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[25],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[26],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[27],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[28],_testData[34], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                 ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DbConnectionDynQuerySelectModelBatch(connection, 41, query1, 139, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.datetimetimestamp_without_time_zonemmarrayd3e1m m
LEFT JOIN public.datetimetimestamp_without_time_zonemmarrayd3e1mi mi ON mi.id = m.datetimetimestamp_without_time_zonemmarrayd3e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)),
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
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)),
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
                var models = await((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DbConnectionSTSelectModelBatchAsync(connection, 139, 34))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[30], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[31], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[32], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[33], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[6], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[7], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[8], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[9], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[10], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[11], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[12], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[13], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[14], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[15], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[10],_testData[16], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[11],_testData[17], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[12],_testData[18], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[13],_testData[19], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[14],_testData[20], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[15],_testData[21], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[16],_testData[22], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[17],_testData[23], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[18],_testData[24], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[19],_testData[25], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[20],_testData[26], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[21],_testData[27], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[22],_testData[28], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[23],_testData[29], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[24],_testData[30], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[25],_testData[31], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[26],_testData[32], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[27],_testData[33], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[28],_testData[34], false);
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
                var models = ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DbConnectionSTSelectModelBatch(connection, 108, 146))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[21], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[22], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[23], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[24], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[25], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[26], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[27], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[28], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[29], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[30], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[10],_testData[31], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[11],_testData[32], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[12],_testData[33], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[31], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[32], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[33], false);
                        DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[34], false);
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
                await using var cmd = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).SetDbConnectionSelectModelParametrs(cmd, 154);
                var models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(3));

                DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[32], false);
                DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[33], false);
                DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).SetDbConnectionSelectModelParametrs(cmd, 130);
                var models =  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[27], false);
                DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[28], false);
                DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[29], false);
                DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[30], false);
                DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[31], false);
                DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[32], false);
                DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[33], false);
                DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[34], false);
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
FROM public.binary_datetimetimestamp_without_time_zonemmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA),
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
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_datetimetimestamp_without_time_zonemmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_datetimetimestamp_without_time_zonemmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_datetimetimestamp_without_time_zonemmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_datetimetimestamp_without_time_zonemmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_datetimetimestamp_without_time_zonemmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_datetimetimestamp_without_time_zonemmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_datetimetimestamp_without_time_zonemmarrayd3e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(DateTimetimestamp_without_time_zoneMMArrayD3E1MI),
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
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateTimetimestamp_without_time_zoneMMArrayD3E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD3E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<DateTimetimestamp_without_time_zoneMMArrayD3E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).WAImportModelInner(connection, importCollection);
                var models = ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD3E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_datetimetimestamp_without_time_zonemmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_datetimetimestamp_without_time_zonemmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).ImportModelInner(connection, importCollection);
                var models = ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_datetimetimestamp_without_time_zonemmarrayd3e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
datetimetimestamp_without_time_zonemmarrayd3e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DateTimetimestamp_without_time_zoneMMArrayD3E1M),
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
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3))]
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
FROM public.binary_datetimetimestamp_without_time_zonemmarrayd3e1m m
LEFT JOIN public.binary_datetimetimestamp_without_time_zonemmarrayd3e1mi mi ON mi.id = m.datetimetimestamp_without_time_zonemmarrayd3e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<DateTimetimestamp_without_time_zoneMMArrayD3E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).ImportModel(connection, importCollection);
                var models = ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_datetimetimestamp_without_time_zonemmarrayd3e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    datetimetimestamp_without_time_zonemmarrayd3e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)),
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
                var models =  ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DateTimetimestamp_without_time_zoneMMArrayD3E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA), typeof(DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)),
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
                var models1 = new List<DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA>();
                var models2 = new List<DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA>();
                await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_datetimetimestamp_without_time_zonemmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA>();
                var models2 = new List<DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA>();
                ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_datetimetimestamp_without_time_zonemmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)),
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
                var models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_datetimetimestamp_without_time_zonemmarrayd3e1mi
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
                    DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_datetimetimestamp_without_time_zonemmarrayd3e1mi
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
                    DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA), typeof(DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3))]
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
                var models1 = new List<DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA>();
                var models2 = new List<DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA>();
                await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_datetimetimestamp_without_time_zonemmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA>();
                var models2 = new List<DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA>();
                ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_datetimetimestamp_without_time_zonemmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3))]
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
                var models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_datetimetimestamp_without_time_zonemmarrayd3e1mi
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
                    DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).DynQueryExportModelInner(connection, @"
COPY public.binary_datetimetimestamp_without_time_zonemmarrayd3e1mi
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
                    DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_datetimetimestamp_without_time_zonemmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD3E1MI), typeof(DateTimetimestamp_without_time_zoneMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)),
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
                var models1 = new List<DateTimetimestamp_without_time_zoneMMArrayD3E1MI>();
                var models2 = new List<DateTimetimestamp_without_time_zoneMMArrayD3E1MI>();
                await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD3E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD3E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DateTimetimestamp_without_time_zoneMMArrayD3E1MI>();
                var models2 = new List<DateTimetimestamp_without_time_zoneMMArrayD3E1MI>();
                ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD3E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD3E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_datetimetimestamp_without_time_zonemmarrayd3e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)),
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
                var models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD3E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD3E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_datetimetimestamp_without_time_zonemmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA), typeof(DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3))]
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
                var models1 = new List<DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA>();
                var models2 = new List<DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA>();
                await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA>();
                var models2 = new List<DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA>();
                ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_datetimetimestamp_without_time_zonemmarrayd3e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeMArraytimestamp_without_time_zoneMMArrayD3))]
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
                var models = await ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDateTimeMArraytimestamp_without_time_zoneMMArrayD3)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

