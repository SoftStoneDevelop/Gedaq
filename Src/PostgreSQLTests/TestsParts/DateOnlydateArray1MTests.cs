

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
    internal partial interface IDateOnlyArraydateArray
    {
    }
    
    internal partial class DateOnlyArraydateArray : IDateOnlyArraydateArray
    {


#region TestData

        private readonly DateOnlydateArray1M[] _testData = new DateOnlydateArray1M[]
        {
            new DateOnlydateArray1M
{
    Id = 7,
    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 2009, month: 10, day: 6),
new DateOnly(year: 1991, month: 10, day: 13),
new DateOnly(year: 2011, month: 10, day: 18),
},
    ModelInner = null,
    NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1968, month: 10, day: 13),
new DateOnly(year: 2000, month: 10, day: 5),
new DateOnly(year: 1919, month: 10, day: 12),
},
},
            new DateOnlydateArray1M
{
    Id = 13,
    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 2001, month: 10, day: 12),
new DateOnly(year: 1941, month: 10, day: 10),
new DateOnly(year: 1991, month: 10, day: 14),
},
    ModelInner = new DateOnlydateArray1MI
{
    Id = 2,
    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1978, month: 10, day: 4),
new DateOnly(year: 1923, month: 10, day: 7),
new DateOnly(year: 1974, month: 10, day: 6),
},
    NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1922, month: 10, day: 3),
new DateOnly(year: 1947, month: 10, day: 18),
new DateOnly(year: 2013, month: 10, day: 3),
new DateOnly(year: 1980, month: 10, day: 16),
},
},
    NullableValue = null,
},
            new DateOnlydateArray1M
{
    Id = 22,
    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1981, month: 10, day: 16),
new DateOnly(year: 1943, month: 10, day: 14),
new DateOnly(year: 2013, month: 10, day: 6),
},
    ModelInner = null,
    NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1981, month: 10, day: 13),
new DateOnly(year: 2005, month: 10, day: 9),
new DateOnly(year: 1927, month: 10, day: 13),
new DateOnly(year: 1983, month: 10, day: 12),
},
},
            new DateOnlydateArray1M
{
    Id = 24,
    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1961, month: 10, day: 10),
new DateOnly(year: 1986, month: 10, day: 18),
new DateOnly(year: 2016, month: 10, day: 13),
},
    ModelInner = new DateOnlydateArray1MI
{
    Id = 8,
    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 2008, month: 10, day: 9),
new DateOnly(year: 1931, month: 10, day: 13),
new DateOnly(year: 2012, month: 10, day: 11),
new DateOnly(year: 1981, month: 10, day: 5),
},
    NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1994, month: 10, day: 1),
new DateOnly(year: 1930, month: 10, day: 17),
new DateOnly(year: 1980, month: 10, day: 2),
new DateOnly(year: 1959, month: 10, day: 7),
},
},
    NullableValue = null,
},
            new DateOnlydateArray1M
{
    Id = 33,
    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1934, month: 10, day: 1),
new DateOnly(year: 2012, month: 10, day: 5),
new DateOnly(year: 1973, month: 10, day: 14),
new DateOnly(year: 1956, month: 10, day: 13),
},
    ModelInner = null,
    NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1984, month: 10, day: 18),
new DateOnly(year: 1971, month: 10, day: 8),
new DateOnly(year: 1926, month: 10, day: 17),
new DateOnly(year: 1987, month: 10, day: 3),
},
},
            new DateOnlydateArray1M
{
    Id = 34,
    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1966, month: 10, day: 1),
new DateOnly(year: 1980, month: 10, day: 16),
new DateOnly(year: 1983, month: 10, day: 1),
},
    ModelInner = new DateOnlydateArray1MI
{
    Id = 13,
    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 2018, month: 10, day: 4),
new DateOnly(year: 1942, month: 10, day: 14),
new DateOnly(year: 1955, month: 10, day: 18),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateOnlydateArray1M
{
    Id = 39,
    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 2011, month: 10, day: 19),
new DateOnly(year: 1939, month: 10, day: 6),
new DateOnly(year: 1939, month: 10, day: 1),
new DateOnly(year: 1968, month: 10, day: 10),
},
    ModelInner = null,
    NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1948, month: 10, day: 13),
new DateOnly(year: 1949, month: 10, day: 7),
new DateOnly(year: 1987, month: 10, day: 9),
},
},
            new DateOnlydateArray1M
{
    Id = 42,
    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1942, month: 10, day: 14),
new DateOnly(year: 2004, month: 10, day: 15),
new DateOnly(year: 1974, month: 10, day: 8),
},
    ModelInner = new DateOnlydateArray1MI
{
    Id = 21,
    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1935, month: 10, day: 17),
new DateOnly(year: 1978, month: 10, day: 15),
new DateOnly(year: 1947, month: 10, day: 9),
},
    NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2001, month: 10, day: 5),
new DateOnly(year: 1955, month: 10, day: 1),
new DateOnly(year: 2019, month: 10, day: 8),
new DateOnly(year: 1977, month: 10, day: 12),
},
},
    NullableValue = null,
},
            new DateOnlydateArray1M
{
    Id = 48,
    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1981, month: 10, day: 11),
new DateOnly(year: 1969, month: 10, day: 2),
new DateOnly(year: 1966, month: 10, day: 4),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateOnlydateArray1M
{
    Id = 57,
    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1994, month: 10, day: 15),
new DateOnly(year: 1998, month: 10, day: 8),
new DateOnly(year: 1953, month: 10, day: 5),
},
    ModelInner = new DateOnlydateArray1MI
{
    Id = 30,
    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1923, month: 10, day: 10),
new DateOnly(year: 1947, month: 10, day: 7),
new DateOnly(year: 1983, month: 10, day: 9),
new DateOnly(year: 1956, month: 10, day: 14),
},
    NullableValue = null,
},
    NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1919, month: 10, day: 9),
new DateOnly(year: 2002, month: 10, day: 12),
new DateOnly(year: 1930, month: 10, day: 2),
},
},
            new DateOnlydateArray1M
{
    Id = 59,
    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1925, month: 10, day: 3),
new DateOnly(year: 2016, month: 10, day: 1),
new DateOnly(year: 1918, month: 10, day: 1),
new DateOnly(year: 1940, month: 10, day: 3),
},
    ModelInner = null,
    NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1979, month: 10, day: 3),
new DateOnly(year: 1940, month: 10, day: 14),
new DateOnly(year: 1935, month: 10, day: 3),
new DateOnly(year: 1948, month: 10, day: 1),
},
},
            new DateOnlydateArray1M
{
    Id = 63,
    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1982, month: 10, day: 16),
new DateOnly(year: 1939, month: 10, day: 17),
new DateOnly(year: 1992, month: 10, day: 8),
new DateOnly(year: 2000, month: 10, day: 6),
},
    ModelInner = new DateOnlydateArray1MI
{
    Id = 37,
    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 2005, month: 10, day: 6),
new DateOnly(year: 1965, month: 10, day: 17),
new DateOnly(year: 1925, month: 10, day: 13),
},
    NullableValue = null,
},
    NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1985, month: 10, day: 14),
new DateOnly(year: 1935, month: 10, day: 18),
new DateOnly(year: 1955, month: 10, day: 10),
},
},
            new DateOnlydateArray1M
{
    Id = 69,
    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1955, month: 10, day: 19),
new DateOnly(year: 1983, month: 10, day: 3),
new DateOnly(year: 1953, month: 10, day: 4),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateOnlydateArray1M
{
    Id = 71,
    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1992, month: 10, day: 2),
new DateOnly(year: 1925, month: 10, day: 19),
new DateOnly(year: 1928, month: 10, day: 9),
},
    ModelInner = new DateOnlydateArray1MI
{
    Id = 41,
    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 2005, month: 10, day: 11),
new DateOnly(year: 1961, month: 10, day: 15),
new DateOnly(year: 1937, month: 10, day: 1),
},
    NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2019, month: 10, day: 1),
new DateOnly(year: 2012, month: 10, day: 9),
new DateOnly(year: 1945, month: 10, day: 14),
new DateOnly(year: 1971, month: 10, day: 7),
},
},
    NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2006, month: 10, day: 4),
new DateOnly(year: 1923, month: 10, day: 4),
new DateOnly(year: 2001, month: 10, day: 5),
},
},
            new DateOnlydateArray1M
{
    Id = 80,
    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1931, month: 10, day: 5),
new DateOnly(year: 1972, month: 10, day: 7),
new DateOnly(year: 1960, month: 10, day: 1),
new DateOnly(year: 1987, month: 10, day: 1),
},
    ModelInner = null,
    NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1980, month: 10, day: 11),
new DateOnly(year: 1937, month: 10, day: 3),
new DateOnly(year: 1961, month: 10, day: 11),
new DateOnly(year: 1932, month: 10, day: 8),
},
},
            new DateOnlydateArray1M
{
    Id = 87,
    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 2000, month: 10, day: 18),
new DateOnly(year: 2010, month: 10, day: 17),
new DateOnly(year: 1963, month: 10, day: 10),
new DateOnly(year: 1939, month: 10, day: 19),
},
    ModelInner = new DateOnlydateArray1MI
{
    Id = 48,
    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1997, month: 10, day: 9),
new DateOnly(year: 1992, month: 10, day: 19),
new DateOnly(year: 1917, month: 10, day: 11),
},
    NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1987, month: 10, day: 8),
new DateOnly(year: 1926, month: 10, day: 16),
new DateOnly(year: 1939, month: 10, day: 15),
new DateOnly(year: 1971, month: 10, day: 8),
},
},
    NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1968, month: 10, day: 7),
new DateOnly(year: 1950, month: 10, day: 8),
new DateOnly(year: 1925, month: 10, day: 5),
},
},
            new DateOnlydateArray1M
{
    Id = 93,
    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1979, month: 10, day: 15),
new DateOnly(year: 1951, month: 10, day: 10),
new DateOnly(year: 1923, month: 10, day: 13),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateOnlydateArray1M
{
    Id = 96,
    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1957, month: 10, day: 2),
new DateOnly(year: 1950, month: 10, day: 18),
new DateOnly(year: 1991, month: 10, day: 14),
},
    ModelInner = new DateOnlydateArray1MI
{
    Id = 53,
    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 2019, month: 10, day: 17),
new DateOnly(year: 1982, month: 10, day: 1),
new DateOnly(year: 2015, month: 10, day: 13),
new DateOnly(year: 1939, month: 10, day: 10),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateOnlydateArray1M
{
    Id = 102,
    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1934, month: 10, day: 2),
new DateOnly(year: 1994, month: 10, day: 19),
new DateOnly(year: 1948, month: 10, day: 13),
new DateOnly(year: 1973, month: 10, day: 15),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateOnlydateArray1M
{
    Id = 111,
    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1934, month: 10, day: 14),
new DateOnly(year: 1974, month: 10, day: 3),
new DateOnly(year: 1971, month: 10, day: 15),
new DateOnly(year: 2009, month: 10, day: 8),
},
    ModelInner = new DateOnlydateArray1MI
{
    Id = 59,
    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1949, month: 10, day: 9),
new DateOnly(year: 1985, month: 10, day: 6),
new DateOnly(year: 1930, month: 10, day: 8),
new DateOnly(year: 1943, month: 10, day: 3),
},
    NullableValue = null,
},
    NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1965, month: 10, day: 17),
new DateOnly(year: 1935, month: 10, day: 15),
new DateOnly(year: 2017, month: 10, day: 10),
new DateOnly(year: 1997, month: 10, day: 4),
},
},
            new DateOnlydateArray1M
{
    Id = 117,
    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1950, month: 10, day: 2),
new DateOnly(year: 2002, month: 10, day: 6),
new DateOnly(year: 1970, month: 10, day: 17),
},
    ModelInner = null,
    NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1921, month: 10, day: 10),
new DateOnly(year: 1934, month: 10, day: 12),
new DateOnly(year: 2003, month: 10, day: 12),
},
},
            new DateOnlydateArray1M
{
    Id = 121,
    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1932, month: 10, day: 14),
new DateOnly(year: 1918, month: 10, day: 19),
new DateOnly(year: 1946, month: 10, day: 10),
new DateOnly(year: 1920, month: 10, day: 18),
},
    ModelInner = new DateOnlydateArray1MI
{
    Id = 63,
    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1996, month: 10, day: 14),
new DateOnly(year: 1984, month: 10, day: 2),
new DateOnly(year: 2001, month: 10, day: 3),
},
    NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1962, month: 10, day: 11),
new DateOnly(year: 1996, month: 10, day: 4),
new DateOnly(year: 1953, month: 10, day: 19),
new DateOnly(year: 1933, month: 10, day: 3),
},
},
    NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2007, month: 10, day: 2),
new DateOnly(year: 1973, month: 10, day: 2),
new DateOnly(year: 1978, month: 10, day: 19),
},
},
            new DateOnlydateArray1M
{
    Id = 126,
    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1937, month: 10, day: 9),
new DateOnly(year: 1959, month: 10, day: 17),
new DateOnly(year: 1985, month: 10, day: 16),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateOnlydateArray1M
{
    Id = 130,
    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1983, month: 10, day: 8),
new DateOnly(year: 1962, month: 10, day: 16),
new DateOnly(year: 1987, month: 10, day: 18),
new DateOnly(year: 1988, month: 10, day: 14),
},
    ModelInner = new DateOnlydateArray1MI
{
    Id = 64,
    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1988, month: 10, day: 10),
new DateOnly(year: 1927, month: 10, day: 15),
new DateOnly(year: 1952, month: 10, day: 18),
},
    NullableValue = null,
},
    NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1985, month: 10, day: 17),
new DateOnly(year: 1952, month: 10, day: 16),
new DateOnly(year: 1920, month: 10, day: 10),
},
},
            new DateOnlydateArray1M
{
    Id = 131,
    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1977, month: 10, day: 12),
new DateOnly(year: 1977, month: 10, day: 6),
new DateOnly(year: 1925, month: 10, day: 1),
new DateOnly(year: 1953, month: 10, day: 16),
},
    ModelInner = null,
    NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2016, month: 10, day: 13),
new DateOnly(year: 1979, month: 10, day: 17),
new DateOnly(year: 1995, month: 10, day: 15),
new DateOnly(year: 1987, month: 10, day: 15),
},
},
            new DateOnlydateArray1M
{
    Id = 134,
    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 2013, month: 10, day: 19),
new DateOnly(year: 1971, month: 10, day: 19),
new DateOnly(year: 1931, month: 10, day: 16),
},
    ModelInner = new DateOnlydateArray1MI
{
    Id = 71,
    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 2018, month: 10, day: 2),
new DateOnly(year: 2004, month: 10, day: 9),
new DateOnly(year: 1930, month: 10, day: 9),
},
    NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1968, month: 10, day: 17),
new DateOnly(year: 2010, month: 10, day: 11),
new DateOnly(year: 1977, month: 10, day: 8),
new DateOnly(year: 1947, month: 10, day: 1),
},
},
    NullableValue = null,
},
            new DateOnlydateArray1M
{
    Id = 143,
    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1934, month: 10, day: 11),
new DateOnly(year: 1989, month: 10, day: 3),
new DateOnly(year: 1943, month: 10, day: 13),
},
    ModelInner = null,
    NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1973, month: 10, day: 7),
new DateOnly(year: 1958, month: 10, day: 11),
new DateOnly(year: 2016, month: 10, day: 2),
},
},
            new DateOnlydateArray1M
{
    Id = 145,
    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 2004, month: 10, day: 15),
new DateOnly(year: 1982, month: 10, day: 17),
new DateOnly(year: 1919, month: 10, day: 8),
},
    ModelInner = new DateOnlydateArray1MI
{
    Id = 74,
    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1957, month: 10, day: 5),
new DateOnly(year: 1928, month: 10, day: 1),
new DateOnly(year: 1984, month: 10, day: 16),
new DateOnly(year: 2016, month: 10, day: 17),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateOnlydateArray1M
{
    Id = 147,
    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1951, month: 10, day: 5),
new DateOnly(year: 1936, month: 10, day: 5),
new DateOnly(year: 1964, month: 10, day: 5),
new DateOnly(year: 1948, month: 10, day: 7),
},
    ModelInner = null,
    NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1941, month: 10, day: 4),
new DateOnly(year: 1971, month: 10, day: 9),
new DateOnly(year: 2009, month: 10, day: 5),
new DateOnly(year: 2002, month: 10, day: 7),
},
},
            new DateOnlydateArray1M
{
    Id = 149,
    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 2006, month: 10, day: 1),
new DateOnly(year: 1951, month: 10, day: 8),
new DateOnly(year: 2007, month: 10, day: 18),
new DateOnly(year: 1971, month: 10, day: 14),
},
    ModelInner = new DateOnlydateArray1MI
{
    Id = 76,
    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1977, month: 10, day: 15),
new DateOnly(year: 1944, month: 10, day: 7),
new DateOnly(year: 1979, month: 10, day: 19),
},
    NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1954, month: 10, day: 13),
new DateOnly(year: 2019, month: 10, day: 11),
new DateOnly(year: 1979, month: 10, day: 17),
},
},
    NullableValue = null,
},
            new DateOnlydateArray1M
{
    Id = 150,
    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1988, month: 10, day: 18),
new DateOnly(year: 2010, month: 10, day: 12),
new DateOnly(year: 1949, month: 10, day: 4),
new DateOnly(year: 1990, month: 10, day: 8),
},
    ModelInner = null,
    NullableValue = null,
},
            new DateOnlydateArray1M
{
    Id = 155,
    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1990, month: 10, day: 12),
new DateOnly(year: 2018, month: 10, day: 16),
new DateOnly(year: 1975, month: 10, day: 14),
new DateOnly(year: 1963, month: 10, day: 4),
},
    ModelInner = new DateOnlydateArray1MI
{
    Id = 82,
    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1957, month: 10, day: 8),
new DateOnly(year: 1930, month: 10, day: 17),
new DateOnly(year: 2001, month: 10, day: 5),
new DateOnly(year: 1994, month: 10, day: 17),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateOnlydateArray1M
{
    Id = 158,
    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1952, month: 10, day: 2),
new DateOnly(year: 2001, month: 10, day: 9),
new DateOnly(year: 1929, month: 10, day: 16),
new DateOnly(year: 2005, month: 10, day: 8),
},
    ModelInner = null,
    NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1948, month: 10, day: 16),
new DateOnly(year: 1980, month: 10, day: 13),
new DateOnly(year: 2005, month: 10, day: 3),
},
},
            new DateOnlydateArray1M
{
    Id = 165,
    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1955, month: 10, day: 17),
new DateOnly(year: 1939, month: 10, day: 4),
new DateOnly(year: 2000, month: 10, day: 6),
new DateOnly(year: 1939, month: 10, day: 16),
},
    ModelInner = new DateOnlydateArray1MI
{
    Id = 88,
    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1946, month: 10, day: 12),
new DateOnly(year: 2004, month: 10, day: 4),
new DateOnly(year: 1983, month: 10, day: 11),
new DateOnly(year: 1927, month: 10, day: 2),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DateOnlydateArray1M
{
    Id = 168,
    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1932, month: 10, day: 9),
new DateOnly(year: 1960, month: 10, day: 17),
new DateOnly(year: 1940, month: 10, day: 4),
new DateOnly(year: 2018, month: 10, day: 17),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.dateonlydatearray1mi(
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
            asPartInterface: typeof(IDateOnlyArraydateArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateOnly[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483641)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateOnly[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483641))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.dateonlydatearray1mi(
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
            queryMapTypes: [typeof(DateOnlydateArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateOnly[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483641)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateOnly[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483641))]
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

                changedRows =  ((IDateOnlyArraydateArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateOnlyArraydateArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDateOnlyArraydateArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlyArraydateArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDateOnlyArraydateArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDateOnlyArraydateArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDateOnlyArraydateArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDateOnlyArraydateArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDateOnlyArraydateArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDateOnlyArraydateArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDateOnlyArraydateArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDateOnlyArraydateArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDateOnlyArraydateArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDateOnlyArraydateArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDateOnlyArraydateArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDateOnlyArraydateArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDateOnlyArraydateArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.dateonlydatearray1m(
	id,
    value,
    nullablevalue,
    dateonlydatearray1mi_id
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
            asPartInterface: typeof(IDateOnlyArraydateArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateOnly[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483641)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateOnly[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483641)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "dateonlydatearray1mi_id", 
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
                changedRows =  ((IDateOnlyArraydateArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDateOnlyArraydateArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDateOnlyArraydateArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDateOnlyArraydateArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.dateonlydatearray1m(
	id,
    value,
    nullablevalue,
    dateonlydatearray1mi_id
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
    dateonlydatearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DateOnlydateArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.dateonlydatearray1m(
	id,
    value,
    nullablevalue,
    dateonlydatearray1mi_id
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
    dateonlydatearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DateOnlydateArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateOnly[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483641)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateOnly[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483641)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "dateonlydatearray1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DateOnlydateArray1M> models = null;

                models =  ((IDateOnlyArraydateArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray1M.AssertModel(models[0],_testData[4], true);
                models =  ((IDateOnlyArraydateArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray1M.AssertModel(models[0],_testData[5], true);
                models =  ((IDateOnlyArraydateArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray1M.AssertModel(models[0],_testData[6], true);
                models =  ((IDateOnlyArraydateArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray1M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DateOnlydateArray1M> models = null;

                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray1M.AssertModel(models[0],_testData[8], true);
                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray1M.AssertModel(models[0],_testData[9], true);
                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray1M.AssertModel(models[0],_testData[10], true);
                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray1M.AssertModel(models[0],_testData[11], true);
                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray1M.AssertModel(models[0],_testData[12], true);
                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray1M.AssertModel(models[0],_testData[13], true);
                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray1M.AssertModel(models[0],_testData[14], true);
                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray1M.AssertModel(models[0],_testData[15], true);
                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydateArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateOnlydateArray1M), typeof(FlatDateOnlydateArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray)),
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
FROM public.dateonlydatearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDateOnlydateArray1M>();
                var models2 = new List<FlatDateOnlydateArray1M>();
                await ((IDateOnlyArraydateArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydateArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateOnlydateArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.dateonlydatearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDateOnlydateArray1M>();
                var models2 = new List<FlatDateOnlydateArray1M>();
                ((IDateOnlyArraydateArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydateArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateOnlydateArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateOnlydateArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray)),
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
FROM public.dateonlydatearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDateOnlyArraydateArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydateArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.dateonlydatearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDateOnlyArraydateArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydateArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.dateonlydatearray1m m
LEFT JOIN public.dateonlydatearray1mi mi ON mi.id = m.dateonlydatearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DateOnlydateArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray)),
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
                var models = await ((IDateOnlyArraydateArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateOnlydateArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDateOnlyArraydateArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateOnlydateArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateOnlydateArray1M), typeof(FlatDateOnlydateArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray)),
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
FROM public.dateonlydatearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateOnlydateArray1M>();
                var models2 = new List<FlatDateOnlydateArray1M>();
                await ((IDateOnlyArraydateArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydateArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateOnlydateArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.dateonlydatearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateOnlydateArray1M>();
                var models2 = new List<FlatDateOnlydateArray1M>();
                ((IDateOnlyArraydateArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydateArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateOnlydateArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateOnlydateArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray)),
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
FROM public.dateonlydatearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDateOnlyArraydateArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydateArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.dateonlydatearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDateOnlyArraydateArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydateArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.dateonlydatearray1m m
LEFT JOIN public.dateonlydatearray1mi mi ON mi.id = m.dateonlydatearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DateOnlydateArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray)),
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
                var models = await ((IDateOnlyArraydateArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateOnlydateArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDateOnlyArraydateArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateOnlydateArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateOnlydateArray1M), typeof(FlatDateOnlydateArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray)),
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
            asPartInterface: typeof(IDateOnlyArraydateArray)),
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
FROM public.dateonlydatearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateOnlydateArray1M>();
                var models2 = new List<FlatDateOnlydateArray1M>();
                await((IDateOnlyArraydateArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydateArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateOnlydateArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
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
FROM public.dateonlydatearray1m m
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
FROM public.dateonlydatearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateOnlydateArray1M>();
                var firstItems2 = new List<FlatDateOnlydateArray1M>();
                var secondItems1 = new List<FlatDateOnlydateArray1M>();
                var secondItems2 = new List<FlatDateOnlydateArray1M>();
                await ((IDateOnlyArraydateArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
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
FROM public.dateonlydatearray1m m
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
FROM public.dateonlydatearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateOnlydateArray1M>();
                var firstItems2 = new List<FlatDateOnlydateArray1M>();
                var secondItems1 = new List<FlatDateOnlydateArray1M>();
                await ((IDateOnlyArraydateArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[30],_testData[34], false);
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
FROM public.dateonlydatearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateOnlydateArray1M>();
                var models2 = new List<FlatDateOnlydateArray1M>();
                ((IDateOnlyArraydateArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydateArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateOnlydateArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
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
FROM public.dateonlydatearray1m m
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
FROM public.dateonlydatearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateOnlydateArray1M>();
                var firstItems2 = new List<FlatDateOnlydateArray1M>();
                var secondItems1 = new List<FlatDateOnlydateArray1M>();
                var secondItems2 = new List<FlatDateOnlydateArray1M>();
                 ((IDateOnlyArraydateArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
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
FROM public.dateonlydatearray1m m
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
FROM public.dateonlydatearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateOnlydateArray1M>();
                var firstItems2 = new List<FlatDateOnlydateArray1M>();
                var secondItems1 = new List<FlatDateOnlydateArray1M>();
                 ((IDateOnlyArraydateArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[11],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateOnlydateArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray)),
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
            asPartInterface: typeof(IDateOnlyArraydateArray)),
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
FROM public.dateonlydatearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDateOnlyArraydateArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydateArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 150;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.dateonlydatearray1m m
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
FROM public.dateonlydatearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateOnlyArraydateArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDateOnlydateArray1M.AssertModel(models[0],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(models[1],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(models[2],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDateOnlydateArray1M.AssertModel(models[0],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(models[1],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(models[2],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(models[3],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(models[4],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(models[5],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(models[6],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(models[7],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(models[8],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 34;
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
FROM public.dateonlydatearray1m m
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
FROM public.dateonlydatearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateOnlydateArray1M>();
                var secondItems1 = new List<FlatDateOnlydateArray1M>();
                var secondItems2 = new List<FlatDateOnlydateArray1M>();
                await ((IDateOnlyArraydateArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.dateonlydatearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDateOnlyArraydateArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydateArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.dateonlydatearray1m m
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
FROM public.dateonlydatearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateOnlyArraydateArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatDateOnlydateArray1M.AssertModel(models[0],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(models[1],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(models[2],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(models[3],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(models[4],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatDateOnlydateArray1M.AssertModel(models[0],_testData[16], false);
                        FlatDateOnlydateArray1M.AssertModel(models[1],_testData[17], false);
                        FlatDateOnlydateArray1M.AssertModel(models[2],_testData[18], false);
                        FlatDateOnlydateArray1M.AssertModel(models[3],_testData[19], false);
                        FlatDateOnlydateArray1M.AssertModel(models[4],_testData[20], false);
                        FlatDateOnlydateArray1M.AssertModel(models[5],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(models[6],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(models[7],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(models[8],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(models[9],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(models[10],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(models[11],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(models[12],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(models[13],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(models[14],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(models[15],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(models[16],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(models[17],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(models[18],_testData[34], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 158;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.dateonlydatearray1m m
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
FROM public.dateonlydatearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateOnlydateArray1M>();
                var secondItems1 = new List<FlatDateOnlydateArray1M>();
                var secondItems2 = new List<FlatDateOnlydateArray1M>();
                 ((IDateOnlyArraydateArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.dateonlydatearray1m m
LEFT JOIN public.dateonlydatearray1mi mi ON mi.id = m.dateonlydatearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DateOnlydateArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray)),
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
                var models = await((IDateOnlyArraydateArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateOnlydateArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateOnlyArraydateArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        DateOnlydateArray1M.AssertModel(models[0],_testData[26], false);
                        DateOnlydateArray1M.AssertModel(models[1],_testData[27], false);
                        DateOnlydateArray1M.AssertModel(models[2],_testData[28], false);
                        DateOnlydateArray1M.AssertModel(models[3],_testData[29], false);
                        DateOnlydateArray1M.AssertModel(models[4],_testData[30], false);
                        DateOnlydateArray1M.AssertModel(models[5],_testData[31], false);
                        DateOnlydateArray1M.AssertModel(models[6],_testData[32], false);
                        DateOnlydateArray1M.AssertModel(models[7],_testData[33], false);
                        DateOnlydateArray1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        DateOnlydateArray1M.AssertModel(models[0],_testData[2], false);
                        DateOnlydateArray1M.AssertModel(models[1],_testData[3], false);
                        DateOnlydateArray1M.AssertModel(models[2],_testData[4], false);
                        DateOnlydateArray1M.AssertModel(models[3],_testData[5], false);
                        DateOnlydateArray1M.AssertModel(models[4],_testData[6], false);
                        DateOnlydateArray1M.AssertModel(models[5],_testData[7], false);
                        DateOnlydateArray1M.AssertModel(models[6],_testData[8], false);
                        DateOnlydateArray1M.AssertModel(models[7],_testData[9], false);
                        DateOnlydateArray1M.AssertModel(models[8],_testData[10], false);
                        DateOnlydateArray1M.AssertModel(models[9],_testData[11], false);
                        DateOnlydateArray1M.AssertModel(models[10],_testData[12], false);
                        DateOnlydateArray1M.AssertModel(models[11],_testData[13], false);
                        DateOnlydateArray1M.AssertModel(models[12],_testData[14], false);
                        DateOnlydateArray1M.AssertModel(models[13],_testData[15], false);
                        DateOnlydateArray1M.AssertModel(models[14],_testData[16], false);
                        DateOnlydateArray1M.AssertModel(models[15],_testData[17], false);
                        DateOnlydateArray1M.AssertModel(models[16],_testData[18], false);
                        DateOnlydateArray1M.AssertModel(models[17],_testData[19], false);
                        DateOnlydateArray1M.AssertModel(models[18],_testData[20], false);
                        DateOnlydateArray1M.AssertModel(models[19],_testData[21], false);
                        DateOnlydateArray1M.AssertModel(models[20],_testData[22], false);
                        DateOnlydateArray1M.AssertModel(models[21],_testData[23], false);
                        DateOnlydateArray1M.AssertModel(models[22],_testData[24], false);
                        DateOnlydateArray1M.AssertModel(models[23],_testData[25], false);
                        DateOnlydateArray1M.AssertModel(models[24],_testData[26], false);
                        DateOnlydateArray1M.AssertModel(models[25],_testData[27], false);
                        DateOnlydateArray1M.AssertModel(models[26],_testData[28], false);
                        DateOnlydateArray1M.AssertModel(models[27],_testData[29], false);
                        DateOnlydateArray1M.AssertModel(models[28],_testData[30], false);
                        DateOnlydateArray1M.AssertModel(models[29],_testData[31], false);
                        DateOnlydateArray1M.AssertModel(models[30],_testData[32], false);
                        DateOnlydateArray1M.AssertModel(models[31],_testData[33], false);
                        DateOnlydateArray1M.AssertModel(models[32],_testData[34], false);
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
                var models = ((IDateOnlyArraydateArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateOnlydateArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateOnlyArraydateArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        DateOnlydateArray1M.AssertModel(models[0],_testData[4], false);
                        DateOnlydateArray1M.AssertModel(models[1],_testData[5], false);
                        DateOnlydateArray1M.AssertModel(models[2],_testData[6], false);
                        DateOnlydateArray1M.AssertModel(models[3],_testData[7], false);
                        DateOnlydateArray1M.AssertModel(models[4],_testData[8], false);
                        DateOnlydateArray1M.AssertModel(models[5],_testData[9], false);
                        DateOnlydateArray1M.AssertModel(models[6],_testData[10], false);
                        DateOnlydateArray1M.AssertModel(models[7],_testData[11], false);
                        DateOnlydateArray1M.AssertModel(models[8],_testData[12], false);
                        DateOnlydateArray1M.AssertModel(models[9],_testData[13], false);
                        DateOnlydateArray1M.AssertModel(models[10],_testData[14], false);
                        DateOnlydateArray1M.AssertModel(models[11],_testData[15], false);
                        DateOnlydateArray1M.AssertModel(models[12],_testData[16], false);
                        DateOnlydateArray1M.AssertModel(models[13],_testData[17], false);
                        DateOnlydateArray1M.AssertModel(models[14],_testData[18], false);
                        DateOnlydateArray1M.AssertModel(models[15],_testData[19], false);
                        DateOnlydateArray1M.AssertModel(models[16],_testData[20], false);
                        DateOnlydateArray1M.AssertModel(models[17],_testData[21], false);
                        DateOnlydateArray1M.AssertModel(models[18],_testData[22], false);
                        DateOnlydateArray1M.AssertModel(models[19],_testData[23], false);
                        DateOnlydateArray1M.AssertModel(models[20],_testData[24], false);
                        DateOnlydateArray1M.AssertModel(models[21],_testData[25], false);
                        DateOnlydateArray1M.AssertModel(models[22],_testData[26], false);
                        DateOnlydateArray1M.AssertModel(models[23],_testData[27], false);
                        DateOnlydateArray1M.AssertModel(models[24],_testData[28], false);
                        DateOnlydateArray1M.AssertModel(models[25],_testData[29], false);
                        DateOnlydateArray1M.AssertModel(models[26],_testData[30], false);
                        DateOnlydateArray1M.AssertModel(models[27],_testData[31], false);
                        DateOnlydateArray1M.AssertModel(models[28],_testData[32], false);
                        DateOnlydateArray1M.AssertModel(models[29],_testData[33], false);
                        DateOnlydateArray1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        DateOnlydateArray1M.AssertModel(models[0],_testData[4], false);
                        DateOnlydateArray1M.AssertModel(models[1],_testData[5], false);
                        DateOnlydateArray1M.AssertModel(models[2],_testData[6], false);
                        DateOnlydateArray1M.AssertModel(models[3],_testData[7], false);
                        DateOnlydateArray1M.AssertModel(models[4],_testData[8], false);
                        DateOnlydateArray1M.AssertModel(models[5],_testData[9], false);
                        DateOnlydateArray1M.AssertModel(models[6],_testData[10], false);
                        DateOnlydateArray1M.AssertModel(models[7],_testData[11], false);
                        DateOnlydateArray1M.AssertModel(models[8],_testData[12], false);
                        DateOnlydateArray1M.AssertModel(models[9],_testData[13], false);
                        DateOnlydateArray1M.AssertModel(models[10],_testData[14], false);
                        DateOnlydateArray1M.AssertModel(models[11],_testData[15], false);
                        DateOnlydateArray1M.AssertModel(models[12],_testData[16], false);
                        DateOnlydateArray1M.AssertModel(models[13],_testData[17], false);
                        DateOnlydateArray1M.AssertModel(models[14],_testData[18], false);
                        DateOnlydateArray1M.AssertModel(models[15],_testData[19], false);
                        DateOnlydateArray1M.AssertModel(models[16],_testData[20], false);
                        DateOnlydateArray1M.AssertModel(models[17],_testData[21], false);
                        DateOnlydateArray1M.AssertModel(models[18],_testData[22], false);
                        DateOnlydateArray1M.AssertModel(models[19],_testData[23], false);
                        DateOnlydateArray1M.AssertModel(models[20],_testData[24], false);
                        DateOnlydateArray1M.AssertModel(models[21],_testData[25], false);
                        DateOnlydateArray1M.AssertModel(models[22],_testData[26], false);
                        DateOnlydateArray1M.AssertModel(models[23],_testData[27], false);
                        DateOnlydateArray1M.AssertModel(models[24],_testData[28], false);
                        DateOnlydateArray1M.AssertModel(models[25],_testData[29], false);
                        DateOnlydateArray1M.AssertModel(models[26],_testData[30], false);
                        DateOnlydateArray1M.AssertModel(models[27],_testData[31], false);
                        DateOnlydateArray1M.AssertModel(models[28],_testData[32], false);
                        DateOnlydateArray1M.AssertModel(models[29],_testData[33], false);
                        DateOnlydateArray1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateOnlydateArray1M), typeof(FlatDateOnlydateArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray)),
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
            asPartInterface: typeof(IDateOnlyArraydateArray)),
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
            asPartInterface: typeof(IDateOnlyArraydateArray)),
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
FROM public.dateonlydatearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateOnlydateArray1M>();
                var models2 = new List<FlatDateOnlydateArray1M>();
                await((IDateOnlyArraydateArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydateArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateOnlydateArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.dateonlydatearray1m m
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
FROM public.dateonlydatearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateOnlydateArray1M>();
                var firstItems2 = new List<FlatDateOnlydateArray1M>();
                var secondItems1 = new List<FlatDateOnlydateArray1M>();
                var secondItems2 = new List<FlatDateOnlydateArray1M>();
                await ((IDateOnlyArraydateArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 63, query1, 96, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.dateonlydatearray1m m
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
FROM public.dateonlydatearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateOnlydateArray1M>();
                var firstItems2 = new List<FlatDateOnlydateArray1M>();
                var secondItems1 = new List<FlatDateOnlydateArray1M>();
                await ((IDateOnlyArraydateArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 121, query1, 150, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[3],_testData[34], false);
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
FROM public.dateonlydatearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateOnlydateArray1M>();
                var models2 = new List<FlatDateOnlydateArray1M>();
                ((IDateOnlyArraydateArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydateArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDateOnlydateArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.dateonlydatearray1m m
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
FROM public.dateonlydatearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateOnlydateArray1M>();
                var firstItems2 = new List<FlatDateOnlydateArray1M>();
                var secondItems1 = new List<FlatDateOnlydateArray1M>();
                var secondItems2 = new List<FlatDateOnlydateArray1M>();
                 ((IDateOnlyArraydateArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 7, query1, 71, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.dateonlydatearray1m m
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
FROM public.dateonlydatearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateOnlydateArray1M>();
                var firstItems2 = new List<FlatDateOnlydateArray1M>();
                var secondItems1 = new List<FlatDateOnlydateArray1M>();
                 ((IDateOnlyArraydateArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 80, query1, 71, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[20],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateOnlydateArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray)),
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
            asPartInterface: typeof(IDateOnlyArraydateArray)),
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
            asPartInterface: typeof(IDateOnlyArraydateArray)),
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
FROM public.dateonlydatearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDateOnlyArraydateArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydateArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.dateonlydatearray1m m
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
FROM public.dateonlydatearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateOnlyArraydateArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 48, query1, 117, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatDateOnlydateArray1M.AssertModel(models[0],_testData[9], false);
                        FlatDateOnlydateArray1M.AssertModel(models[1],_testData[10], false);
                        FlatDateOnlydateArray1M.AssertModel(models[2],_testData[11], false);
                        FlatDateOnlydateArray1M.AssertModel(models[3],_testData[12], false);
                        FlatDateOnlydateArray1M.AssertModel(models[4],_testData[13], false);
                        FlatDateOnlydateArray1M.AssertModel(models[5],_testData[14], false);
                        FlatDateOnlydateArray1M.AssertModel(models[6],_testData[15], false);
                        FlatDateOnlydateArray1M.AssertModel(models[7],_testData[16], false);
                        FlatDateOnlydateArray1M.AssertModel(models[8],_testData[17], false);
                        FlatDateOnlydateArray1M.AssertModel(models[9],_testData[18], false);
                        FlatDateOnlydateArray1M.AssertModel(models[10],_testData[19], false);
                        FlatDateOnlydateArray1M.AssertModel(models[11],_testData[20], false);
                        FlatDateOnlydateArray1M.AssertModel(models[12],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(models[13],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(models[14],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(models[15],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(models[16],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(models[17],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(models[18],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(models[19],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(models[20],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(models[21],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(models[22],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(models[23],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(models[24],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatDateOnlydateArray1M.AssertModel(models[0],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(models[1],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(models[2],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(models[3],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(models[4],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(models[5],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(models[6],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(models[7],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(models[8],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(models[9],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(models[10],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(models[11],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(models[12],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(models[13],_testData[34], false);
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
FROM public.dateonlydatearray1m m
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
FROM public.dateonlydatearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateOnlydateArray1M>();
                var secondItems1 = new List<FlatDateOnlydateArray1M>();
                var secondItems2 = new List<FlatDateOnlydateArray1M>();
                await ((IDateOnlyArraydateArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 57, query1, 57, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.dateonlydatearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDateOnlyArraydateArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydateArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.dateonlydatearray1m m
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
FROM public.dateonlydatearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateOnlyArraydateArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 96, query1, 87, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatDateOnlydateArray1M.AssertModel(models[0],_testData[18], false);
                        FlatDateOnlydateArray1M.AssertModel(models[1],_testData[19], false);
                        FlatDateOnlydateArray1M.AssertModel(models[2],_testData[20], false);
                        FlatDateOnlydateArray1M.AssertModel(models[3],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(models[4],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(models[5],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(models[6],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(models[7],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(models[8],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(models[9],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(models[10],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(models[11],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(models[12],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(models[13],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(models[14],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(models[15],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatDateOnlydateArray1M.AssertModel(models[0],_testData[16], false);
                        FlatDateOnlydateArray1M.AssertModel(models[1],_testData[17], false);
                        FlatDateOnlydateArray1M.AssertModel(models[2],_testData[18], false);
                        FlatDateOnlydateArray1M.AssertModel(models[3],_testData[19], false);
                        FlatDateOnlydateArray1M.AssertModel(models[4],_testData[20], false);
                        FlatDateOnlydateArray1M.AssertModel(models[5],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(models[6],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(models[7],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(models[8],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(models[9],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(models[10],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(models[11],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(models[12],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(models[13],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(models[14],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(models[15],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(models[16],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(models[17],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(models[18],_testData[34], false);
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
FROM public.dateonlydatearray1m m
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
FROM public.dateonlydatearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateOnlydateArray1M>();
                var secondItems1 = new List<FlatDateOnlydateArray1M>();
                var secondItems2 = new List<FlatDateOnlydateArray1M>();
                 ((IDateOnlyArraydateArray)this).DbConnectionDynQuerySelectModelBatch(connection, 71, query1, 24, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatDateOnlydateArray1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.dateonlydatearray1m m
LEFT JOIN public.dateonlydatearray1mi mi ON mi.id = m.dateonlydatearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DateOnlydateArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray)),
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
            asPartInterface: typeof(IDateOnlyArraydateArray)),
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
                var models = await((IDateOnlyArraydateArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateOnlydateArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDateOnlyArraydateArray)this).DbConnectionSTSelectModelBatchAsync(connection, 149, 158))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        DateOnlydateArray1M.AssertModel(models[0],_testData[30], false);
                        DateOnlydateArray1M.AssertModel(models[1],_testData[31], false);
                        DateOnlydateArray1M.AssertModel(models[2],_testData[32], false);
                        DateOnlydateArray1M.AssertModel(models[3],_testData[33], false);
                        DateOnlydateArray1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        DateOnlydateArray1M.AssertModel(models[0],_testData[33], false);
                        DateOnlydateArray1M.AssertModel(models[1],_testData[34], false);
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
                var models = ((IDateOnlyArraydateArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateOnlydateArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDateOnlyArraydateArray)this).DbConnectionSTSelectModelBatch(connection, 42, 13))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        DateOnlydateArray1M.AssertModel(models[0],_testData[8], false);
                        DateOnlydateArray1M.AssertModel(models[1],_testData[9], false);
                        DateOnlydateArray1M.AssertModel(models[2],_testData[10], false);
                        DateOnlydateArray1M.AssertModel(models[3],_testData[11], false);
                        DateOnlydateArray1M.AssertModel(models[4],_testData[12], false);
                        DateOnlydateArray1M.AssertModel(models[5],_testData[13], false);
                        DateOnlydateArray1M.AssertModel(models[6],_testData[14], false);
                        DateOnlydateArray1M.AssertModel(models[7],_testData[15], false);
                        DateOnlydateArray1M.AssertModel(models[8],_testData[16], false);
                        DateOnlydateArray1M.AssertModel(models[9],_testData[17], false);
                        DateOnlydateArray1M.AssertModel(models[10],_testData[18], false);
                        DateOnlydateArray1M.AssertModel(models[11],_testData[19], false);
                        DateOnlydateArray1M.AssertModel(models[12],_testData[20], false);
                        DateOnlydateArray1M.AssertModel(models[13],_testData[21], false);
                        DateOnlydateArray1M.AssertModel(models[14],_testData[22], false);
                        DateOnlydateArray1M.AssertModel(models[15],_testData[23], false);
                        DateOnlydateArray1M.AssertModel(models[16],_testData[24], false);
                        DateOnlydateArray1M.AssertModel(models[17],_testData[25], false);
                        DateOnlydateArray1M.AssertModel(models[18],_testData[26], false);
                        DateOnlydateArray1M.AssertModel(models[19],_testData[27], false);
                        DateOnlydateArray1M.AssertModel(models[20],_testData[28], false);
                        DateOnlydateArray1M.AssertModel(models[21],_testData[29], false);
                        DateOnlydateArray1M.AssertModel(models[22],_testData[30], false);
                        DateOnlydateArray1M.AssertModel(models[23],_testData[31], false);
                        DateOnlydateArray1M.AssertModel(models[24],_testData[32], false);
                        DateOnlydateArray1M.AssertModel(models[25],_testData[33], false);
                        DateOnlydateArray1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        DateOnlydateArray1M.AssertModel(models[0],_testData[2], false);
                        DateOnlydateArray1M.AssertModel(models[1],_testData[3], false);
                        DateOnlydateArray1M.AssertModel(models[2],_testData[4], false);
                        DateOnlydateArray1M.AssertModel(models[3],_testData[5], false);
                        DateOnlydateArray1M.AssertModel(models[4],_testData[6], false);
                        DateOnlydateArray1M.AssertModel(models[5],_testData[7], false);
                        DateOnlydateArray1M.AssertModel(models[6],_testData[8], false);
                        DateOnlydateArray1M.AssertModel(models[7],_testData[9], false);
                        DateOnlydateArray1M.AssertModel(models[8],_testData[10], false);
                        DateOnlydateArray1M.AssertModel(models[9],_testData[11], false);
                        DateOnlydateArray1M.AssertModel(models[10],_testData[12], false);
                        DateOnlydateArray1M.AssertModel(models[11],_testData[13], false);
                        DateOnlydateArray1M.AssertModel(models[12],_testData[14], false);
                        DateOnlydateArray1M.AssertModel(models[13],_testData[15], false);
                        DateOnlydateArray1M.AssertModel(models[14],_testData[16], false);
                        DateOnlydateArray1M.AssertModel(models[15],_testData[17], false);
                        DateOnlydateArray1M.AssertModel(models[16],_testData[18], false);
                        DateOnlydateArray1M.AssertModel(models[17],_testData[19], false);
                        DateOnlydateArray1M.AssertModel(models[18],_testData[20], false);
                        DateOnlydateArray1M.AssertModel(models[19],_testData[21], false);
                        DateOnlydateArray1M.AssertModel(models[20],_testData[22], false);
                        DateOnlydateArray1M.AssertModel(models[21],_testData[23], false);
                        DateOnlydateArray1M.AssertModel(models[22],_testData[24], false);
                        DateOnlydateArray1M.AssertModel(models[23],_testData[25], false);
                        DateOnlydateArray1M.AssertModel(models[24],_testData[26], false);
                        DateOnlydateArray1M.AssertModel(models[25],_testData[27], false);
                        DateOnlydateArray1M.AssertModel(models[26],_testData[28], false);
                        DateOnlydateArray1M.AssertModel(models[27],_testData[29], false);
                        DateOnlydateArray1M.AssertModel(models[28],_testData[30], false);
                        DateOnlydateArray1M.AssertModel(models[29],_testData[31], false);
                        DateOnlydateArray1M.AssertModel(models[30],_testData[32], false);
                        DateOnlydateArray1M.AssertModel(models[31],_testData[33], false);
                        DateOnlydateArray1M.AssertModel(models[32],_testData[34], false);
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
                await using var cmd = await ((IDateOnlyArraydateArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDateOnlyArraydateArray)this).SetDbConnectionSelectModelParametrs(cmd, 96);
                var models = await ((IDateOnlyArraydateArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(17));

                DateOnlydateArray1M.AssertModel(models[0],_testData[18], false);
                DateOnlydateArray1M.AssertModel(models[1],_testData[19], false);
                DateOnlydateArray1M.AssertModel(models[2],_testData[20], false);
                DateOnlydateArray1M.AssertModel(models[3],_testData[21], false);
                DateOnlydateArray1M.AssertModel(models[4],_testData[22], false);
                DateOnlydateArray1M.AssertModel(models[5],_testData[23], false);
                DateOnlydateArray1M.AssertModel(models[6],_testData[24], false);
                DateOnlydateArray1M.AssertModel(models[7],_testData[25], false);
                DateOnlydateArray1M.AssertModel(models[8],_testData[26], false);
                DateOnlydateArray1M.AssertModel(models[9],_testData[27], false);
                DateOnlydateArray1M.AssertModel(models[10],_testData[28], false);
                DateOnlydateArray1M.AssertModel(models[11],_testData[29], false);
                DateOnlydateArray1M.AssertModel(models[12],_testData[30], false);
                DateOnlydateArray1M.AssertModel(models[13],_testData[31], false);
                DateOnlydateArray1M.AssertModel(models[14],_testData[32], false);
                DateOnlydateArray1M.AssertModel(models[15],_testData[33], false);
                DateOnlydateArray1M.AssertModel(models[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateOnlyArraydateArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateOnlyArraydateArray)this).SetDbConnectionSelectModelParametrs(cmd, 42);
                var models =  ((IDateOnlyArraydateArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                DateOnlydateArray1M.AssertModel(models[0],_testData[8], false);
                DateOnlydateArray1M.AssertModel(models[1],_testData[9], false);
                DateOnlydateArray1M.AssertModel(models[2],_testData[10], false);
                DateOnlydateArray1M.AssertModel(models[3],_testData[11], false);
                DateOnlydateArray1M.AssertModel(models[4],_testData[12], false);
                DateOnlydateArray1M.AssertModel(models[5],_testData[13], false);
                DateOnlydateArray1M.AssertModel(models[6],_testData[14], false);
                DateOnlydateArray1M.AssertModel(models[7],_testData[15], false);
                DateOnlydateArray1M.AssertModel(models[8],_testData[16], false);
                DateOnlydateArray1M.AssertModel(models[9],_testData[17], false);
                DateOnlydateArray1M.AssertModel(models[10],_testData[18], false);
                DateOnlydateArray1M.AssertModel(models[11],_testData[19], false);
                DateOnlydateArray1M.AssertModel(models[12],_testData[20], false);
                DateOnlydateArray1M.AssertModel(models[13],_testData[21], false);
                DateOnlydateArray1M.AssertModel(models[14],_testData[22], false);
                DateOnlydateArray1M.AssertModel(models[15],_testData[23], false);
                DateOnlydateArray1M.AssertModel(models[16],_testData[24], false);
                DateOnlydateArray1M.AssertModel(models[17],_testData[25], false);
                DateOnlydateArray1M.AssertModel(models[18],_testData[26], false);
                DateOnlydateArray1M.AssertModel(models[19],_testData[27], false);
                DateOnlydateArray1M.AssertModel(models[20],_testData[28], false);
                DateOnlydateArray1M.AssertModel(models[21],_testData[29], false);
                DateOnlydateArray1M.AssertModel(models[22],_testData[30], false);
                DateOnlydateArray1M.AssertModel(models[23],_testData[31], false);
                DateOnlydateArray1M.AssertModel(models[24],_testData[32], false);
                DateOnlydateArray1M.AssertModel(models[25],_testData[33], false);
                DateOnlydateArray1M.AssertModel(models[26],_testData[34], false);
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
FROM public.binary_dateonlydatearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(DateOnlydateArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(DateOnlydateArray1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483641),
                (NpgsqlTypes.NpgsqlDbType)(-2147483641)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateOnlydateArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateOnlydateArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDateOnlyArraydateArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_dateonlydatearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDateOnlyArraydateArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateOnlydateArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DateOnlydateArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateOnlydateArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDateOnlyArraydateArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_dateonlydatearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDateOnlyArraydateArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateOnlydateArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_dateonlydatearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(DateOnlydateArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(DateOnlydateArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateOnlydateArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateOnlydateArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDateOnlyArraydateArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_dateonlydatearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDateOnlyArraydateArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateOnlydateArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DateOnlydateArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateOnlydateArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDateOnlyArraydateArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_dateonlydatearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDateOnlyArraydateArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateOnlydateArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_dateonlydatearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(DateOnlydateArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_dateonlydatearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(DateOnlydateArray1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483641),
                (NpgsqlTypes.NpgsqlDbType)(-2147483641)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateOnlydateArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDateOnlyArraydateArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDateOnlyArraydateArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateOnlydateArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<DateOnlydateArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDateOnlyArraydateArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IDateOnlyArraydateArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateOnlydateArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_dateonlydatearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DateOnlydateArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_dateonlydatearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DateOnlydateArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateOnlydateArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateOnlydateArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDateOnlyArraydateArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDateOnlyArraydateArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateOnlydateArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DateOnlydateArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateOnlydateArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDateOnlyArraydateArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDateOnlyArraydateArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateOnlydateArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_dateonlydatearray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
dateonlydatearray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DateOnlydateArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483641),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483641)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray))]
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
FROM public.binary_dateonlydatearray1m m
LEFT JOIN public.binary_dateonlydatearray1mi mi ON mi.id = m.dateonlydatearray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DateOnlydateArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateOnlydateArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDateOnlyArraydateArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDateOnlyArraydateArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DateOnlydateArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<DateOnlydateArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDateOnlyArraydateArray)this).ImportModel(connection, importCollection);
                var models = ((IDateOnlyArraydateArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DateOnlydateArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_dateonlydatearray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    dateonlydatearray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DateOnlydateArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483641),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483641)
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
                var models =  ((IDateOnlyArraydateArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DateOnlydateArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateOnlyArraydateArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DateOnlydateArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(DateOnlydateArray1MIWA), typeof(DateOnlydateArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483641),
                (NpgsqlTypes.NpgsqlDbType)(-2147483641)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483641),
                (NpgsqlTypes.NpgsqlDbType)(-2147483641)
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
                var models1 = new List<DateOnlydateArray1MIWA>();
                var models2 = new List<DateOnlydateArray1MIWA>();
                await ((IDateOnlyArraydateArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_dateonlydatearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateOnlydateArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateOnlydateArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DateOnlydateArray1MIWA>();
                var models2 = new List<DateOnlydateArray1MIWA>();
                ((IDateOnlyArraydateArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_dateonlydatearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateOnlydateArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateOnlydateArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(DateOnlydateArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483641),
                (NpgsqlTypes.NpgsqlDbType)(-2147483641)
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
                var models = await ((IDateOnlyArraydateArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_dateonlydatearray1mi
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
                    DateOnlydateArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDateOnlyArraydateArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_dateonlydatearray1mi
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
                    DateOnlydateArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(DateOnlydateArray1MIWA), typeof(DateOnlydateArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray))]
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
                var models1 = new List<DateOnlydateArray1MIWA>();
                var models2 = new List<DateOnlydateArray1MIWA>();
                await ((IDateOnlyArraydateArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_dateonlydatearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateOnlydateArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateOnlydateArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DateOnlydateArray1MIWA>();
                var models2 = new List<DateOnlydateArray1MIWA>();
                ((IDateOnlyArraydateArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_dateonlydatearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateOnlydateArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateOnlydateArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(DateOnlydateArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray))]
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
                var models = await ((IDateOnlyArraydateArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_dateonlydatearray1mi
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
                    DateOnlydateArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDateOnlyArraydateArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_dateonlydatearray1mi
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
                    DateOnlydateArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_dateonlydatearray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(DateOnlydateArray1MI), typeof(DateOnlydateArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483641),
                (NpgsqlTypes.NpgsqlDbType)(-2147483641)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483641),
                (NpgsqlTypes.NpgsqlDbType)(-2147483641)
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
                var models1 = new List<DateOnlydateArray1MI>();
                var models2 = new List<DateOnlydateArray1MI>();
                await ((IDateOnlyArraydateArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateOnlydateArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateOnlydateArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DateOnlydateArray1MI>();
                var models2 = new List<DateOnlydateArray1MI>();
                ((IDateOnlyArraydateArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateOnlydateArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateOnlydateArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_dateonlydatearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(DateOnlydateArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483641),
                (NpgsqlTypes.NpgsqlDbType)(-2147483641)
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
                var models = await ((IDateOnlyArraydateArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateOnlydateArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDateOnlyArraydateArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateOnlydateArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_dateonlydatearray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(DateOnlydateArray1MIWA), typeof(DateOnlydateArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray))]
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
                var models1 = new List<DateOnlydateArray1MIWA>();
                var models2 = new List<DateOnlydateArray1MIWA>();
                await ((IDateOnlyArraydateArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateOnlydateArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateOnlydateArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DateOnlydateArray1MIWA>();
                var models2 = new List<DateOnlydateArray1MIWA>();
                ((IDateOnlyArraydateArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateOnlydateArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateOnlydateArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_dateonlydatearray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DateOnlydateArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray))]
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
                var models = await ((IDateOnlyArraydateArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateOnlydateArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDateOnlyArraydateArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateOnlydateArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

