

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
    internal partial interface ISByteMArraysmallintMMArrayD3
    {
    }
    
    internal partial class SByteMArraysmallintMMArrayD3 : ISByteMArraysmallintMMArrayD3
    {


#region TestData

        private readonly SBytesmallintMMArrayD3E1M[] _testData = new SBytesmallintMMArrayD3E1M[]
        {
            new SBytesmallintMMArrayD3E1M
{
    Id = 1,
    Value = 
new System.SByte[,,] { { { 13, 68, 69, }, { 124, 110, -91, }, { -36, 76, 27, }, }, { { -68, 39, 72, }, { 119, -97, 49, }, { 61, 9, 105, }, }, { { 14, -111, 59, }, { 92, -27, 104, }, { 36, -48, -111, }, }, },
    ModelInner = null,
    NullableValue = 
new System.SByte[,,] { { { 121, -109, 92, }, { 40, 21, 25, }, { 63, -28, 74, }, }, { { 24, -121, -107, }, { -114, 88, 20, }, { 60, 10, -95, }, }, { { 36, 4, -85, }, { 119, 75, 73, }, { -98, -25, -77, }, }, },
},
            new SBytesmallintMMArrayD3E1M
{
    Id = 2,
    Value = 
new System.SByte[,,] { { { 104, -92, 122, }, { 91, 13, 82, }, { 114, -106, 82, }, }, { { 111, 123, -75, }, { -53, 87, -12, }, { 21, 30, -5, }, }, { { -116, 92, 110, }, { -94, -7, -28, }, { 29, 82, -79, }, }, },
    ModelInner = new SBytesmallintMMArrayD3E1MI
{
    Id = 3,
    Value = 
new System.SByte[,,] { { { 99, 51, -22, }, { 35, -1, 54, }, { -42, -84, -79, }, }, { { 29, -55, 122, }, { 100, -23, 88, }, { 49, -63, -61, }, }, { { -52, 42, -97, }, { 59, 2, -106, }, { -22, -3, 24, }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintMMArrayD3E1M
{
    Id = 6,
    Value = 
new System.SByte[,,] { { { 123, 46, -74, }, { -19, -112, -49, }, { -122, 82, -120, }, }, { { -45, 7, 87, }, { -103, 4, 42, }, { 67, 125, -96, }, }, { { 92, -19, -33, }, { -66, -31, 105, }, { 64, -9, 89, }, }, },
    ModelInner = null,
    NullableValue = 
new System.SByte[,,] { { { 36, -6, -82, }, { 97, -63, 81, }, { 68, 12, 106, }, }, { { 103, 92, -5, }, { -119, 90, -26, }, { 64, 11, 42, }, }, { { -88, -8, 77, }, { -50, 110, -34, }, { -96, -69, 33, }, }, },
},
            new SBytesmallintMMArrayD3E1M
{
    Id = 12,
    Value = 
new System.SByte[,,] { { { 23, -116, -92, }, { 12, 7, 42, }, { -109, -45, -57, }, }, { { -83, -27, 110, }, { -49, 26, 27, }, { 70, 57, -124, }, }, { { 52, -87, -21, }, { 120, -54, -60, }, { 67, -11, -65, }, }, },
    ModelInner = new SBytesmallintMMArrayD3E1MI
{
    Id = 10,
    Value = 
new System.SByte[,,] { { { 89, 68, -70, }, { -72, 105, 6, }, { -81, -68, 98, }, }, { { -12, 0, 118, }, { 89, 62, -44, }, { -110, 88, -39, }, }, { { -70, -115, 24, }, { 57, 69, 74, }, { -121, 22, -89, }, }, },
    NullableValue = 
new System.SByte[,,] { { { -127, -8, 119, }, { -12, 96, 27, }, { 4, 17, 46, }, }, { { -17, 64, -18, }, { 21, 22, 20, }, { -21, 3, -119, }, }, { { -22, -115, -39, }, { 47, 117, 29, }, { -13, -122, -124, }, }, },
},
    NullableValue = 
new System.SByte[,,] { { { 38, 121, -120, }, { -112, 9, -9, }, { -93, -8, -10, }, }, { { -123, -43, 111, }, { 104, 76, -20, }, { 69, 100, 3, }, }, { { 16, -34, -114, }, { 109, -59, 26, }, { -53, -74, 84, }, }, },
},
            new SBytesmallintMMArrayD3E1M
{
    Id = 15,
    Value = 
new System.SByte[,,] { { { -35, -106, 115, }, { -112, 114, -5, }, { 58, -120, 5, }, }, { { -128, 115, -2, }, { -52, 78, -105, }, { 115, 16, -9, }, }, { { -57, 114, 82, }, { 69, 74, 80, }, { 105, -94, -24, }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintMMArrayD3E1M
{
    Id = 19,
    Value = 
new System.SByte[,,] { { { 119, -32, -85, }, { -29, 59, -4, }, { -87, 63, 22, }, }, { { 14, -84, -106, }, { -53, -77, 6, }, { 56, 93, 89, }, }, { { -47, -62, -83, }, { 52, 91, -117, }, { -42, 15, -122, }, }, },
    ModelInner = new SBytesmallintMMArrayD3E1MI
{
    Id = 11,
    Value = 
new System.SByte[,,] { { { 83, 49, -38, }, { -48, 18, 111, }, { 70, 109, 30, }, }, { { 112, 31, 45, }, { 27, -114, -33, }, { 106, -126, 33, }, }, { { 74, -97, 117, }, { 124, 26, -46, }, { -79, -95, 22, }, }, },
    NullableValue = 
new System.SByte[,,] { { { -110, -28, 118, }, { 23, -45, -47, }, { 15, 120, 120, }, }, { { -68, 90, 110, }, { -37, -38, -23, }, { -74, 87, -83, }, }, { { 91, 108, -9, }, { 62, -90, -84, }, { 7, 14, -90, }, }, },
},
    NullableValue = null,
},
            new SBytesmallintMMArrayD3E1M
{
    Id = 26,
    Value = 
new System.SByte[,,] { { { -98, 58, -8, }, { -128, -126, -98, }, { -49, -21, -53, }, }, { { 56, 12, 5, }, { 121, 78, -20, }, { -55, 88, 62, }, }, { { 115, 49, 76, }, { -60, -58, 50, }, { -21, -69, 84, }, }, },
    ModelInner = null,
    NullableValue = 
new System.SByte[,,] { { { -70, -42, 78, }, { -111, 80, 71, }, { -104, 110, -54, }, }, { { 57, -32, 93, }, { -74, 50, 94, }, { 17, 43, -19, }, }, { { -65, -94, -91, }, { 117, 44, -95, }, { 101, -78, 42, }, }, },
},
            new SBytesmallintMMArrayD3E1M
{
    Id = 28,
    Value = 
new System.SByte[,,] { { { -40, 84, 82, }, { -12, -125, 54, }, { -58, -77, -71, }, }, { { 85, -109, 5, }, { 72, 81, 99, }, { 104, 28, 89, }, }, { { -61, -125, -94, }, { -56, 86, 62, }, { 57, 118, -109, }, }, },
    ModelInner = new SBytesmallintMMArrayD3E1MI
{
    Id = 19,
    Value = 
new System.SByte[,,] { { { -92, 26, 109, }, { -91, -90, -124, }, { -80, 108, -74, }, }, { { -52, 110, 69, }, { 9, 1, -53, }, { -58, 26, -77, }, }, { { -75, -20, -107, }, { 84, -71, 56, }, { -128, 15, -103, }, }, },
    NullableValue = 
new System.SByte[,,] { { { 17, -103, -101, }, { 81, -55, 41, }, { 57, -113, -57, }, }, { { -103, 52, 85, }, { -128, -1, 116, }, { 101, 87, 3, }, }, { { -17, 111, 113, }, { 103, 23, 9, }, { 57, -72, -33, }, }, },
},
    NullableValue = null,
},
            new SBytesmallintMMArrayD3E1M
{
    Id = 37,
    Value = 
new System.SByte[,,] { { { 102, 25, -98, }, { -114, -7, -81, }, { 3, -23, 68, }, }, { { -58, 105, 103, }, { 19, 75, 24, }, { -91, -20, -86, }, }, { { 23, -1, -18, }, { -11, -26, -115, }, { 45, -66, 96, }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintMMArrayD3E1M
{
    Id = 44,
    Value = 
new System.SByte[,,] { { { -88, -68, 31, }, { 1, -102, -17, }, { 77, 87, -79, }, }, { { -111, -113, -113, }, { 61, 54, -106, }, { -72, 36, -6, }, }, { { -78, 21, -109, }, { -19, 45, -117, }, { -15, -112, 77, }, }, },
    ModelInner = new SBytesmallintMMArrayD3E1MI
{
    Id = 25,
    Value = 
new System.SByte[,,] { { { 37, -52, -58, }, { -16, 85, 36, }, { -40, 80, 36, }, }, { { -101, -106, 8, }, { 113, 105, -85, }, { 76, 68, 117, }, }, { { -94, -125, -38, }, { -45, 40, 120, }, { -47, 13, 121, }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintMMArrayD3E1M
{
    Id = 53,
    Value = 
new System.SByte[,,] { { { -7, -91, -47, }, { 36, -28, -23, }, { -21, 60, -62, }, }, { { -108, -122, -124, }, { -43, -37, 103, }, { 97, -31, -83, }, }, { { -89, -66, 66, }, { 48, -15, 101, }, { -53, 48, -9, }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintMMArrayD3E1M
{
    Id = 55,
    Value = 
new System.SByte[,,] { { { 42, -14, 90, }, { 122, -77, -69, }, { -72, 23, -32, }, }, { { 55, -33, 63, }, { 119, 11, 97, }, { 114, -111, 94, }, }, { { 19, 113, -124, }, { -101, -26, -63, }, { 94, 13, 49, }, }, },
    ModelInner = new SBytesmallintMMArrayD3E1MI
{
    Id = 28,
    Value = 
new System.SByte[,,] { { { 71, -55, -101, }, { -89, 24, -18, }, { 98, 59, 115, }, }, { { -93, -117, 10, }, { -91, -93, 35, }, { 18, 75, 76, }, }, { { 33, 51, -69, }, { 113, 24, 22, }, { -60, 122, -23, }, }, },
    NullableValue = 
new System.SByte[,,] { { { -68, -124, 57, }, { -115, -38, -44, }, { 9, -84, -32, }, }, { { -34, -42, 65, }, { 38, -107, -38, }, { -31, -112, -54, }, }, { { 65, 87, -104, }, { -68, -59, 34, }, { -90, 5, 22, }, }, },
},
    NullableValue = null,
},
            new SBytesmallintMMArrayD3E1M
{
    Id = 59,
    Value = 
new System.SByte[,,] { { { -9, -94, -5, }, { -85, -13, -88, }, { -69, 27, 97, }, }, { { -13, -9, -125, }, { 17, 102, -111, }, { 42, -124, -107, }, }, { { -43, 107, 77, }, { 74, -46, -123, }, { -23, -110, -35, }, }, },
    ModelInner = null,
    NullableValue = 
new System.SByte[,,] { { { 72, -27, 87, }, { 123, -30, -114, }, { -35, 3, 56, }, }, { { 105, -63, -48, }, { -1, 85, -110, }, { -47, 50, 96, }, }, { { -73, 78, 44, }, { -30, -124, -77, }, { 104, -36, 118, }, }, },
},
            new SBytesmallintMMArrayD3E1M
{
    Id = 67,
    Value = 
new System.SByte[,,] { { { 92, -23, -43, }, { 119, 103, -55, }, { 21, -86, -48, }, }, { { 20, -96, 65, }, { 99, 92, 103, }, { -87, -6, 83, }, }, { { -42, -7, -76, }, { -29, -34, 104, }, { -67, -114, -119, }, }, },
    ModelInner = new SBytesmallintMMArrayD3E1MI
{
    Id = 36,
    Value = 
new System.SByte[,,] { { { 3, 94, 34, }, { 107, 17, -117, }, { 109, 124, 12, }, }, { { 87, 62, 7, }, { 8, -68, -88, }, { -78, -33, -9, }, }, { { 36, 110, -13, }, { -93, 85, -42, }, { 29, 91, -58, }, }, },
    NullableValue = 
new System.SByte[,,] { { { -106, 76, -23, }, { 92, 40, -8, }, { -62, -57, 67, }, }, { { 55, 68, 74, }, { -51, 46, -105, }, { -62, 60, 63, }, }, { { 114, -118, -10, }, { 97, 19, -60, }, { 36, -68, 61, }, }, },
},
    NullableValue = 
new System.SByte[,,] { { { 49, 94, -96, }, { 91, 70, 1, }, { -83, 43, -15, }, }, { { 98, 86, 70, }, { 91, -21, -19, }, { 39, -27, 77, }, }, { { -27, -91, -60, }, { 91, 15, 65, }, { -85, 80, 58, }, }, },
},
            new SBytesmallintMMArrayD3E1M
{
    Id = 70,
    Value = 
new System.SByte[,,] { { { -12, -21, 29, }, { 89, 62, -87, }, { -66, 12, -48, }, }, { { 48, -9, 6, }, { 90, 9, 67, }, { -13, 29, -112, }, }, { { -85, -73, 66, }, { -16, 14, -38, }, { -52, 82, -101, }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintMMArrayD3E1M
{
    Id = 73,
    Value = 
new System.SByte[,,] { { { 5, -90, -16, }, { -44, -59, 68, }, { 11, -45, -75, }, }, { { -86, 109, 64, }, { 33, 50, 109, }, { 109, -27, 119, }, }, { { 15, -33, 28, }, { -57, 78, -103, }, { 125, 7, 104, }, }, },
    ModelInner = new SBytesmallintMMArrayD3E1MI
{
    Id = 42,
    Value = 
new System.SByte[,,] { { { 30, -29, 50, }, { 61, 43, -128, }, { 79, 12, -85, }, }, { { 96, -88, 64, }, { -99, -57, -90, }, { -23, 101, 76, }, }, { { -62, -26, 102, }, { 54, 59, -11, }, { 2, -125, -57, }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,,] { { { -66, 8, -40, }, { 92, 38, 95, }, { -113, 42, -80, }, }, { { 50, 0, -46, }, { -57, 114, -69, }, { -109, -12, -96, }, }, { { -46, 29, 89, }, { -90, 28, 102, }, { -72, -68, -59, }, }, },
},
            new SBytesmallintMMArrayD3E1M
{
    Id = 76,
    Value = 
new System.SByte[,,] { { { 123, -48, 117, }, { -115, 104, -107, }, { -81, -101, -115, }, }, { { 96, 91, -23, }, { -96, -63, 38, }, { -90, 77, -14, }, }, { { 66, -58, -36, }, { 122, 72, -44, }, { -105, 50, -29, }, }, },
    ModelInner = null,
    NullableValue = 
new System.SByte[,,] { { { -77, -28, -127, }, { -17, 32, -123, }, { -67, 16, 95, }, }, { { -68, 29, 108, }, { -56, 98, 121, }, { 102, 12, 76, }, }, { { 93, 126, 87, }, { 98, 72, 14, }, { -76, -45, 82, }, }, },
},
            new SBytesmallintMMArrayD3E1M
{
    Id = 79,
    Value = 
new System.SByte[,,] { { { 62, -77, -117, }, { -6, -116, -58, }, { -17, -36, 86, }, }, { { -10, 119, -39, }, { -6, 7, -57, }, { -37, 105, 10, }, }, { { -36, 109, 117, }, { 73, -10, 84, }, { 15, 114, 39, }, }, },
    ModelInner = new SBytesmallintMMArrayD3E1MI
{
    Id = 49,
    Value = 
new System.SByte[,,] { { { 101, 83, -27, }, { -118, 118, -8, }, { 111, 43, -113, }, }, { { 1, 26, 9, }, { 38, 107, -48, }, { -93, -17, -64, }, }, { { 13, -59, 99, }, { -75, 23, -11, }, { -65, -71, 115, }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,,] { { { -53, 80, -117, }, { -81, 115, 94, }, { -87, 82, -94, }, }, { { 72, -70, 27, }, { 110, 73, -40, }, { 101, 67, -43, }, }, { { -83, -125, 122, }, { 84, -19, 26, }, { -93, -110, -43, }, }, },
},
            new SBytesmallintMMArrayD3E1M
{
    Id = 85,
    Value = 
new System.SByte[,,] { { { -64, 94, 2, }, { 78, 66, 101, }, { 14, -18, -52, }, }, { { 91, 2, 103, }, { 1, 36, -13, }, { -85, -89, -36, }, }, { { 98, -50, 8, }, { -110, 59, -113, }, { 11, -65, 60, }, }, },
    ModelInner = null,
    NullableValue = 
new System.SByte[,,] { { { 110, -59, 67, }, { -68, 75, -30, }, { -100, -123, 105, }, }, { { -49, -47, 11, }, { -104, -65, 122, }, { 85, -53, -67, }, }, { { -55, -9, -39, }, { -84, -110, 90, }, { -12, -96, 73, }, }, },
},
            new SBytesmallintMMArrayD3E1M
{
    Id = 94,
    Value = 
new System.SByte[,,] { { { -66, 39, -34, }, { -76, -35, 38, }, { -45, 1, -94, }, }, { { 55, -49, -92, }, { -7, 124, 20, }, { -125, 8, -32, }, }, { { 101, 75, 29, }, { -97, 16, -67, }, { -114, -115, -27, }, }, },
    ModelInner = new SBytesmallintMMArrayD3E1MI
{
    Id = 50,
    Value = 
new System.SByte[,,] { { { 33, 100, -79, }, { 30, 32, 39, }, { -75, -94, 29, }, }, { { -104, -33, -23, }, { 48, -28, 48, }, { -96, 69, 18, }, }, { { 37, 39, -83, }, { -121, 96, -52, }, { -80, -32, 101, }, }, },
    NullableValue = 
new System.SByte[,,] { { { -91, 37, -83, }, { 74, -89, -119, }, { -65, -81, -54, }, }, { { 56, 89, 105, }, { 110, -2, 6, }, { 77, 12, 85, }, }, { { 50, 27, -108, }, { 27, -65, 22, }, { -108, 73, 52, }, }, },
},
    NullableValue = 
new System.SByte[,,] { { { -48, -26, -30, }, { 93, -105, 59, }, { -44, 89, -96, }, }, { { 94, 62, -96, }, { -38, -69, -126, }, { -34, 65, -35, }, }, { { 124, 61, -74, }, { -120, 91, 106, }, { 109, -97, 14, }, }, },
},
            new SBytesmallintMMArrayD3E1M
{
    Id = 97,
    Value = 
new System.SByte[,,] { { { -70, -79, 41, }, { 85, -94, 14, }, { -33, -30, 33, }, }, { { -117, -36, -98, }, { 122, 3, 97, }, { -35, 55, 23, }, }, { { 24, 61, 68, }, { 92, 84, 85, }, { -31, -105, 75, }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintMMArrayD3E1M
{
    Id = 102,
    Value = 
new System.SByte[,,] { { { 72, -27, 116, }, { 66, 116, -43, }, { -66, -112, -36, }, }, { { 117, -4, 98, }, { 96, -95, -88, }, { 28, 36, 93, }, }, { { 118, -21, -110, }, { -123, -8, -123, }, { 62, -72, 106, }, }, },
    ModelInner = new SBytesmallintMMArrayD3E1MI
{
    Id = 56,
    Value = 
new System.SByte[,,] { { { 16, 96, -50, }, { 48, 0, 83, }, { -106, 29, -101, }, }, { { -89, 81, -47, }, { -105, -106, 25, }, { 7, -32, -96, }, }, { { -52, -38, 21, }, { 12, 1, -30, }, { -94, -98, 27, }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,,] { { { -102, -2, 114, }, { 84, -50, -97, }, { 111, -93, -35, }, }, { { 101, -35, -54, }, { 56, 95, 15, }, { -44, -13, 115, }, }, { { 92, 30, -13, }, { -23, -35, 22, }, { 13, -12, 36, }, }, },
},
            new SBytesmallintMMArrayD3E1M
{
    Id = 107,
    Value = 
new System.SByte[,,] { { { 61, -13, -127, }, { -110, 67, -72, }, { 50, 103, -15, }, }, { { 0, -45, -55, }, { -82, 101, -38, }, { 12, 43, -93, }, }, { { 79, -4, -121, }, { 91, 117, -49, }, { -4, 73, -75, }, }, },
    ModelInner = null,
    NullableValue = 
new System.SByte[,,] { { { -90, -38, -77, }, { -47, -25, 85, }, { -15, -106, -16, }, }, { { 42, -118, -92, }, { 89, 62, -14, }, { -101, -118, 33, }, }, { { -78, 1, -58, }, { 56, -48, 98, }, { 8, 65, 25, }, }, },
},
            new SBytesmallintMMArrayD3E1M
{
    Id = 110,
    Value = 
new System.SByte[,,] { { { 89, 101, 42, }, { 117, -86, -61, }, { -102, 36, -121, }, }, { { -45, -53, -45, }, { -79, -44, -113, }, { -25, -34, 49, }, }, { { -45, 113, -81, }, { 50, 63, 102, }, { -21, 91, -69, }, }, },
    ModelInner = new SBytesmallintMMArrayD3E1MI
{
    Id = 64,
    Value = 
new System.SByte[,,] { { { -30, 101, 124, }, { -84, 117, -101, }, { -25, -98, -97, }, }, { { 13, -110, 2, }, { -96, -36, -104, }, { -40, -24, 99, }, }, { { 89, -41, -14, }, { -45, 36, 76, }, { -86, 5, -91, }, }, },
    NullableValue = 
new System.SByte[,,] { { { 103, -3, -36, }, { -65, -87, -62, }, { 89, 12, -96, }, }, { { 15, 24, 112, }, { 82, -64, 54, }, { 11, 88, 30, }, }, { { 114, -115, 106, }, { 44, 34, 18, }, { 47, 18, -18, }, }, },
},
    NullableValue = 
new System.SByte[,,] { { { -81, 38, 23, }, { -29, 87, 38, }, { 26, 20, 100, }, }, { { -16, -82, -92, }, { 12, 48, 120, }, { -80, 92, 67, }, }, { { 50, -69, -28, }, { 51, -24, -122, }, { 32, -40, 4, }, }, },
},
            new SBytesmallintMMArrayD3E1M
{
    Id = 112,
    Value = 
new System.SByte[,,] { { { 62, 67, 107, }, { 100, 60, 17, }, { -92, 30, 62, }, }, { { 4, 112, -31, }, { 70, 18, 100, }, { -121, 74, 17, }, }, { { 35, -65, 39, }, { -85, 26, 32, }, { 9, 50, -111, }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintMMArrayD3E1M
{
    Id = 115,
    Value = 
new System.SByte[,,] { { { 65, -107, -36, }, { 31, 67, -96, }, { 61, 3, -122, }, }, { { -115, -58, -117, }, { 62, 88, -2, }, { -35, -113, 117, }, }, { { 8, 115, -85, }, { -94, 35, -14, }, { -20, 120, 42, }, }, },
    ModelInner = new SBytesmallintMMArrayD3E1MI
{
    Id = 72,
    Value = 
new System.SByte[,,] { { { -107, -96, -102, }, { 27, 9, 97, }, { -109, 64, -89, }, }, { { -81, -120, 105, }, { -99, -58, -20, }, { -19, 70, 52, }, }, { { 107, -37, 19, }, { -61, -23, 46, }, { 103, -46, -31, }, }, },
    NullableValue = 
new System.SByte[,,] { { { -110, -108, -117, }, { -87, 100, 69, }, { -74, -109, 45, }, }, { { -47, 10, -30, }, { 110, 120, -20, }, { -64, -42, -80, }, }, { { -104, -59, -41, }, { -101, 70, -61, }, { -67, 124, -58, }, }, },
},
    NullableValue = null,
},
            new SBytesmallintMMArrayD3E1M
{
    Id = 122,
    Value = 
new System.SByte[,,] { { { 83, -55, -54, }, { -90, 110, -28, }, { 63, -52, 35, }, }, { { -30, -95, -92, }, { 84, 117, -48, }, { 40, 33, 43, }, }, { { -62, -18, 79, }, { -110, 32, 118, }, { 19, -57, 55, }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintMMArrayD3E1M
{
    Id = 124,
    Value = 
new System.SByte[,,] { { { -96, 106, 111, }, { -121, 56, 22, }, { 87, 86, 120, }, }, { { 35, -81, 74, }, { -122, -61, -4, }, { -15, -101, 4, }, }, { { 39, -112, -27, }, { 77, -117, -68, }, { 22, 96, 111, }, }, },
    ModelInner = new SBytesmallintMMArrayD3E1MI
{
    Id = 80,
    Value = 
new System.SByte[,,] { { { -87, -62, 28, }, { -104, 101, -103, }, { -4, -81, 74, }, }, { { -78, 95, 28, }, { -45, 10, -42, }, { -52, -44, -53, }, }, { { 38, 51, 8, }, { 104, 123, 25, }, { 66, 99, 62, }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,,] { { { -83, -23, 106, }, { 124, 115, -52, }, { 64, -67, -72, }, }, { { 84, -96, -119, }, { 101, 81, 36, }, { 11, 53, -69, }, }, { { 66, -97, 11, }, { -113, 19, 73, }, { 21, -88, -8, }, }, },
},
            new SBytesmallintMMArrayD3E1M
{
    Id = 133,
    Value = 
new System.SByte[,,] { { { -56, 39, 67, }, { 114, 43, 83, }, { -127, -4, 44, }, }, { { -125, -50, -22, }, { 0, 1, 77, }, { -59, -97, 13, }, }, { { -117, 4, -62, }, { -105, 32, -11, }, { 90, -8, -121, }, }, },
    ModelInner = null,
    NullableValue = 
new System.SByte[,,] { { { 31, -61, 1, }, { 113, 50, 99, }, { 62, 72, -70, }, }, { { 60, -65, -107, }, { 43, -111, 48, }, { -79, 7, -54, }, }, { { -126, 98, 18, }, { 1, 19, -43, }, { -30, -65, -21, }, }, },
},
            new SBytesmallintMMArrayD3E1M
{
    Id = 139,
    Value = 
new System.SByte[,,] { { { 48, -45, -28, }, { -20, -14, -9, }, { -110, 13, -68, }, }, { { 50, 2, -36, }, { 112, -101, -68, }, { -35, -99, 110, }, }, { { 58, 64, -104, }, { -55, 87, -49, }, { 93, 2, 108, }, }, },
    ModelInner = new SBytesmallintMMArrayD3E1MI
{
    Id = 82,
    Value = 
new System.SByte[,,] { { { -21, -24, 100, }, { -23, -58, 107, }, { -52, 58, -127, }, }, { { -71, 9, -25, }, { -11, -62, -70, }, { -24, -78, 106, }, }, { { 99, 43, 103, }, { 118, -25, -87, }, { -110, -37, -116, }, }, },
    NullableValue = 
new System.SByte[,,] { { { 63, -116, 31, }, { -50, -51, -97, }, { -36, 74, 38, }, }, { { 2, -88, -109, }, { -23, 103, 28, }, { 7, -40, -19, }, }, { { -1, -124, 36, }, { -113, -104, -113, }, { -96, 103, -126, }, }, },
},
    NullableValue = 
new System.SByte[,,] { { { 45, 37, -93, }, { 123, -105, 40, }, { 38, 83, -97, }, }, { { 57, 17, 4, }, { 87, 94, 31, }, { -113, -103, -120, }, }, { { -23, 10, 48, }, { -21, 96, 77, }, { -77, -73, 76, }, }, },
},
            new SBytesmallintMMArrayD3E1M
{
    Id = 147,
    Value = 
new System.SByte[,,] { { { -65, 83, -61, }, { 109, 40, -109, }, { 12, 34, -43, }, }, { { 86, -3, -7, }, { 57, 122, 13, }, { -41, -7, 68, }, }, { { 91, -119, -57, }, { 17, -100, 20, }, { 50, 1, 19, }, }, },
    ModelInner = null,
    NullableValue = 
new System.SByte[,,] { { { 107, -116, -27, }, { 110, 4, 70, }, { 98, -100, -99, }, }, { { 11, 53, 57, }, { -94, 40, -23, }, { -55, 96, 112, }, }, { { -7, 61, -103, }, { 60, -109, 62, }, { -62, 4, -127, }, }, },
},
            new SBytesmallintMMArrayD3E1M
{
    Id = 152,
    Value = 
new System.SByte[,,] { { { 118, -71, -93, }, { 77, 46, -48, }, { -38, 124, 11, }, }, { { -37, 57, -28, }, { 122, -97, 11, }, { 79, -85, -107, }, }, { { -100, -22, -92, }, { -33, -101, -43, }, { -16, -112, -54, }, }, },
    ModelInner = new SBytesmallintMMArrayD3E1MI
{
    Id = 85,
    Value = 
new System.SByte[,,] { { { -5, -29, -26, }, { 69, 99, 13, }, { -12, -106, -27, }, }, { { -64, -123, 102, }, { 60, 72, -54, }, { -71, 123, -92, }, }, { { 38, -80, 1, }, { 34, 62, 58, }, { 20, -89, 20, }, }, },
    NullableValue = 
new System.SByte[,,] { { { -14, 62, -34, }, { 20, -118, 107, }, { 37, 61, -39, }, }, { { -119, -38, -106, }, { 19, -45, 113, }, { -61, -15, 105, }, }, { { 81, -16, 0, }, { 59, 35, 52, }, { 83, -73, -31, }, }, },
},
    NullableValue = null,
},
            new SBytesmallintMMArrayD3E1M
{
    Id = 159,
    Value = 
new System.SByte[,,] { { { -119, 32, 96, }, { 31, -37, -31, }, { -99, -65, 59, }, }, { { -63, -9, -22, }, { 97, -79, -9, }, { -128, -104, 36, }, }, { { 96, 30, -50, }, { -116, -20, 122, }, { -126, -40, -45, }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintMMArrayD3E1M
{
    Id = 160,
    Value = 
new System.SByte[,,] { { { -40, -29, -126, }, { -61, -118, 95, }, { 8, -90, -7, }, }, { { 10, -20, -59, }, { -10, 30, -73, }, { -45, 22, 96, }, }, { { 99, -35, 39, }, { -7, -33, -80, }, { -93, 34, 49, }, }, },
    ModelInner = new SBytesmallintMMArrayD3E1MI
{
    Id = 94,
    Value = 
new System.SByte[,,] { { { -17, -21, 103, }, { 4, -110, 11, }, { -12, -15, -94, }, }, { { 55, 13, 17, }, { -23, -43, 44, }, { 118, 126, 118, }, }, { { -127, -113, -64, }, { -1, -10, -81, }, { 32, -115, 8, }, }, },
    NullableValue = 
new System.SByte[,,] { { { 8, 76, 121, }, { 14, -125, 47, }, { -72, 50, 59, }, }, { { 59, -99, -126, }, { -121, 20, 88, }, { -110, 55, -112, }, }, { { 125, -10, 86, }, { 12, 15, -26, }, { -10, 76, -16, }, }, },
},
    NullableValue = 
new System.SByte[,,] { { { 76, -24, 16, }, { 37, -15, -13, }, { 6, 73, -67, }, }, { { 11, 92, -34, }, { -64, -85, -121, }, { 13, 17, 103, }, }, { { -37, 112, -55, }, { 34, -115, -47, }, { -29, 96, -70, }, }, },
},
            new SBytesmallintMMArrayD3E1M
{
    Id = 163,
    Value = 
new System.SByte[,,] { { { 5, 36, -12, }, { 80, -51, 51, }, { -111, -22, 39, }, }, { { -4, 118, 13, }, { 12, -25, -105, }, { 77, -97, -32, }, }, { { -121, 123, 8, }, { -18, 36, 90, }, { 6, 113, 74, }, }, },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.sbytesmallintmmarrayd3e1mi(
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
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.SByte[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.SByte[,,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.sbytesmallintmmarrayd3e1mi(
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
            queryMapTypes: [typeof(SBytesmallintMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.SByte[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.SByte[,,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630))]
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

                changedRows =  ((ISByteMArraysmallintMMArrayD3)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISByteMArraysmallintMMArrayD3)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((ISByteMArraysmallintMMArrayD3)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((ISByteMArraysmallintMMArrayD3)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.sbytesmallintmmarrayd3e1m(
	id,
    value,
    nullablevalue,
    sbytesmallintmmarrayd3e1mi_id
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
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.SByte[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.SByte[,,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "sbytesmallintmmarrayd3e1mi_id", 
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
                changedRows =  ((ISByteMArraysmallintMMArrayD3)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((ISByteMArraysmallintMMArrayD3)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.sbytesmallintmmarrayd3e1m(
	id,
    value,
    nullablevalue,
    sbytesmallintmmarrayd3e1mi_id
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
    sbytesmallintmmarrayd3e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(SBytesmallintMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3)),
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
INSERT INTO public.sbytesmallintmmarrayd3e1m(
	id,
    value,
    nullablevalue,
    sbytesmallintmmarrayd3e1mi_id
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
    sbytesmallintmmarrayd3e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(SBytesmallintMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.SByte[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.SByte[,,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "sbytesmallintmmarrayd3e1mi_id", 
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
                List<SBytesmallintMMArrayD3E1M> models = null;

                models =  ((ISByteMArraysmallintMMArrayD3)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[4], true);
                models =  ((ISByteMArraysmallintMMArrayD3)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[5], true);
                models =  ((ISByteMArraysmallintMMArrayD3)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[6], true);
                models =  ((ISByteMArraysmallintMMArrayD3)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<SBytesmallintMMArrayD3E1M> models = null;

                models = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[8], true);
                models = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[9], true);
                models = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[10], true);
                models = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[11], true);
                models = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[12], true);
                models = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[13], true);
                models = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[14], true);
                models = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[15], true);
                models = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[16], true);
                models = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[17], true);
                models = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[18], true);
                models = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[19], true);
                models = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[20], true);
                models = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[21], true);
                models = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[22], true);
                models = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[23], true);
                models = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[24], true);
                models = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[25], true);
                models = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[26], true);
                models = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[27], true);
                models = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[28], true);
                models = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[29], true);
                models = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[30], true);
                models = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[31], true);
                models = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[32], true);
                models = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[33], true);
                models = await ((ISByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSBytesmallintMMArrayD3E1M), typeof(FlatSBytesmallintMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3)),
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
FROM public.sbytesmallintmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatSBytesmallintMMArrayD3E1M>();
                var models2 = new List<FlatSBytesmallintMMArrayD3E1M>();
                await ((ISByteMArraysmallintMMArrayD3)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSBytesmallintMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.sbytesmallintmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatSBytesmallintMMArrayD3E1M>();
                var models2 = new List<FlatSBytesmallintMMArrayD3E1M>();
                ((ISByteMArraysmallintMMArrayD3)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSBytesmallintMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSBytesmallintMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3)),
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
FROM public.sbytesmallintmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((ISByteMArraysmallintMMArrayD3)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.sbytesmallintmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ISByteMArraysmallintMMArrayD3)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.sbytesmallintmmarrayd3e1m m
LEFT JOIN public.sbytesmallintmmarrayd3e1mi mi ON mi.id = m.sbytesmallintmmarrayd3e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(SBytesmallintMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3)),
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
                var models = await ((ISByteMArraysmallintMMArrayD3)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SBytesmallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((ISByteMArraysmallintMMArrayD3)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SBytesmallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSBytesmallintMMArrayD3E1M), typeof(FlatSBytesmallintMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3)),
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
FROM public.sbytesmallintmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSBytesmallintMMArrayD3E1M>();
                var models2 = new List<FlatSBytesmallintMMArrayD3E1M>();
                await ((ISByteMArraysmallintMMArrayD3)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSBytesmallintMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.sbytesmallintmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSBytesmallintMMArrayD3E1M>();
                var models2 = new List<FlatSBytesmallintMMArrayD3E1M>();
                ((ISByteMArraysmallintMMArrayD3)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSBytesmallintMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatSBytesmallintMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3)),
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
FROM public.sbytesmallintmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ISByteMArraysmallintMMArrayD3)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.sbytesmallintmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((ISByteMArraysmallintMMArrayD3)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.sbytesmallintmmarrayd3e1m m
LEFT JOIN public.sbytesmallintmmarrayd3e1mi mi ON mi.id = m.sbytesmallintmmarrayd3e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(SBytesmallintMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3)),
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
                var models = await ((ISByteMArraysmallintMMArrayD3)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SBytesmallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((ISByteMArraysmallintMMArrayD3)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SBytesmallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSBytesmallintMMArrayD3E1M), typeof(FlatSBytesmallintMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3)),
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
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3)),
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
FROM public.sbytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSBytesmallintMMArrayD3E1M>();
                var models2 = new List<FlatSBytesmallintMMArrayD3E1M>();
                await((ISByteMArraysmallintMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSBytesmallintMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
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
FROM public.sbytesmallintmmarrayd3e1m m
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
FROM public.sbytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintMMArrayD3E1M>();
                var firstItems2 = new List<FlatSBytesmallintMMArrayD3E1M>();
                var secondItems1 = new List<FlatSBytesmallintMMArrayD3E1M>();
                var secondItems2 = new List<FlatSBytesmallintMMArrayD3E1M>();
                await ((ISByteMArraysmallintMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
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
FROM public.sbytesmallintmmarrayd3e1m m
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
FROM public.sbytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintMMArrayD3E1M>();
                var firstItems2 = new List<FlatSBytesmallintMMArrayD3E1M>();
                var secondItems1 = new List<FlatSBytesmallintMMArrayD3E1M>();
                await ((ISByteMArraysmallintMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[8],_testData[34], false);
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
FROM public.sbytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSBytesmallintMMArrayD3E1M>();
                var models2 = new List<FlatSBytesmallintMMArrayD3E1M>();
                ((ISByteMArraysmallintMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSBytesmallintMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 28;
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
FROM public.sbytesmallintmmarrayd3e1m m
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
FROM public.sbytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintMMArrayD3E1M>();
                var firstItems2 = new List<FlatSBytesmallintMMArrayD3E1M>();
                var secondItems1 = new List<FlatSBytesmallintMMArrayD3E1M>();
                var secondItems2 = new List<FlatSBytesmallintMMArrayD3E1M>();
                 ((ISByteMArraysmallintMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
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
FROM public.sbytesmallintmmarrayd3e1m m
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
FROM public.sbytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintMMArrayD3E1M>();
                var firstItems2 = new List<FlatSBytesmallintMMArrayD3E1M>();
                var secondItems1 = new List<FlatSBytesmallintMMArrayD3E1M>();
                 ((ISByteMArraysmallintMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[30],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSBytesmallintMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3)),
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
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3)),
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
FROM public.sbytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ISByteMArraysmallintMMArrayD3)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.sbytesmallintmmarrayd3e1m m
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
FROM public.sbytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISByteMArraysmallintMMArrayD3)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[1],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[2],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[3],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[4],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[5],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[20], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[1],_testData[21], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[2],_testData[22], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[3],_testData[23], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[4],_testData[24], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[5],_testData[25], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[6],_testData[26], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[7],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[8],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[9],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[10],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[11],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[12],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[13],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.sbytesmallintmmarrayd3e1m m
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
FROM public.sbytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintMMArrayD3E1M>();
                var secondItems1 = new List<FlatSBytesmallintMMArrayD3E1M>();
                var secondItems2 = new List<FlatSBytesmallintMMArrayD3E1M>();
                await ((ISByteMArraysmallintMMArrayD3)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.sbytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ISByteMArraysmallintMMArrayD3)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.sbytesmallintmmarrayd3e1m m
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
FROM public.sbytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISByteMArraysmallintMMArrayD3)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[25], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[1],_testData[26], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[2],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[3],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[4],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[5],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[6],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[7],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[8],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[15], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[1],_testData[16], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[2],_testData[17], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[3],_testData[18], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[4],_testData[19], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[5],_testData[20], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[6],_testData[21], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[7],_testData[22], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[8],_testData[23], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[9],_testData[24], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[10],_testData[25], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[11],_testData[26], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[12],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[13],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[14],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[15],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[16],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[17],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[18],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[19],_testData[34], false);
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.sbytesmallintmmarrayd3e1m m
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
FROM public.sbytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintMMArrayD3E1M>();
                var secondItems1 = new List<FlatSBytesmallintMMArrayD3E1M>();
                var secondItems2 = new List<FlatSBytesmallintMMArrayD3E1M>();
                 ((ISByteMArraysmallintMMArrayD3)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.sbytesmallintmmarrayd3e1m m
LEFT JOIN public.sbytesmallintmmarrayd3e1mi mi ON mi.id = m.sbytesmallintmmarrayd3e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(SBytesmallintMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3)),
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
                var models = await((ISByteMArraysmallintMMArrayD3)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SBytesmallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISByteMArraysmallintMMArrayD3)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[17], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[1],_testData[18], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[2],_testData[19], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[3],_testData[20], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[4],_testData[21], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[5],_testData[22], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[6],_testData[23], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[7],_testData[24], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[8],_testData[25], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[9],_testData[26], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[10],_testData[27], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[11],_testData[28], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[12],_testData[29], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[13],_testData[30], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[14],_testData[31], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[15],_testData[32], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[16],_testData[33], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[26], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[1],_testData[27], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[2],_testData[28], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[3],_testData[29], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[4],_testData[30], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[5],_testData[31], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[6],_testData[32], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[7],_testData[33], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[8],_testData[34], false);
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
                var models = ((ISByteMArraysmallintMMArrayD3)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SBytesmallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISByteMArraysmallintMMArrayD3)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[29], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[1],_testData[30], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[2],_testData[31], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[3],_testData[32], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[4],_testData[33], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[20], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[1],_testData[21], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[2],_testData[22], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[3],_testData[23], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[4],_testData[24], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[5],_testData[25], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[6],_testData[26], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[7],_testData[27], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[8],_testData[28], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[9],_testData[29], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[10],_testData[30], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[11],_testData[31], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[12],_testData[32], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[13],_testData[33], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSBytesmallintMMArrayD3E1M), typeof(FlatSBytesmallintMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3)),
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
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3)),
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
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3)),
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
FROM public.sbytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSBytesmallintMMArrayD3E1M>();
                var models2 = new List<FlatSBytesmallintMMArrayD3E1M>();
                await((ISByteMArraysmallintMMArrayD3)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSBytesmallintMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.sbytesmallintmmarrayd3e1m m
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
FROM public.sbytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintMMArrayD3E1M>();
                var firstItems2 = new List<FlatSBytesmallintMMArrayD3E1M>();
                var secondItems1 = new List<FlatSBytesmallintMMArrayD3E1M>();
                var secondItems2 = new List<FlatSBytesmallintMMArrayD3E1M>();
                await ((ISByteMArraysmallintMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 53, query1, 139, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.sbytesmallintmmarrayd3e1m m
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
FROM public.sbytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintMMArrayD3E1M>();
                var firstItems2 = new List<FlatSBytesmallintMMArrayD3E1M>();
                var secondItems1 = new List<FlatSBytesmallintMMArrayD3E1M>();
                await ((ISByteMArraysmallintMMArrayD3)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 26, query1, 107, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[11],_testData[34], false);
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
FROM public.sbytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSBytesmallintMMArrayD3E1M>();
                var models2 = new List<FlatSBytesmallintMMArrayD3E1M>();
                ((ISByteMArraysmallintMMArrayD3)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSBytesmallintMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.sbytesmallintmmarrayd3e1m m
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
FROM public.sbytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintMMArrayD3E1M>();
                var firstItems2 = new List<FlatSBytesmallintMMArrayD3E1M>();
                var secondItems1 = new List<FlatSBytesmallintMMArrayD3E1M>();
                var secondItems2 = new List<FlatSBytesmallintMMArrayD3E1M>();
                 ((ISByteMArraysmallintMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 122, query1, 85, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.sbytesmallintmmarrayd3e1m m
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
FROM public.sbytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintMMArrayD3E1M>();
                var firstItems2 = new List<FlatSBytesmallintMMArrayD3E1M>();
                var secondItems1 = new List<FlatSBytesmallintMMArrayD3E1M>();
                 ((ISByteMArraysmallintMMArrayD3)this).DbConnectionMMDynQuerySelectModelBatch(connection, 85, query1, 124, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[6],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSBytesmallintMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3)),
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
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3)),
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
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3)),
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
FROM public.sbytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ISByteMArraysmallintMMArrayD3)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.sbytesmallintmmarrayd3e1m m
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
FROM public.sbytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISByteMArraysmallintMMArrayD3)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 85, query1, 70, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[19], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[1],_testData[20], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[2],_testData[21], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[3],_testData[22], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[4],_testData[23], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[5],_testData[24], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[6],_testData[25], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[7],_testData[26], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[8],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[9],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[10],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[11],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[12],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[13],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[14],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[15], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[1],_testData[16], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[2],_testData[17], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[3],_testData[18], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[4],_testData[19], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[5],_testData[20], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[6],_testData[21], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[7],_testData[22], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[8],_testData[23], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[9],_testData[24], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[10],_testData[25], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[11],_testData[26], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[12],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[13],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[14],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[15],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[16],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[17],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[18],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[19],_testData[34], false);
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
FROM public.sbytesmallintmmarrayd3e1m m
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
FROM public.sbytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintMMArrayD3E1M>();
                var secondItems1 = new List<FlatSBytesmallintMMArrayD3E1M>();
                var secondItems2 = new List<FlatSBytesmallintMMArrayD3E1M>();
                await ((ISByteMArraysmallintMMArrayD3)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 115, query1, 73, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.sbytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ISByteMArraysmallintMMArrayD3)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.sbytesmallintmmarrayd3e1m m
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
FROM public.sbytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISByteMArraysmallintMMArrayD3)this).DbConnectionSTDynQuerySelectModelBatch(connection, 59, query1, 37, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[13], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[1],_testData[14], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[2],_testData[15], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[3],_testData[16], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[4],_testData[17], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[5],_testData[18], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[6],_testData[19], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[7],_testData[20], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[8],_testData[21], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[9],_testData[22], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[10],_testData[23], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[11],_testData[24], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[12],_testData[25], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[13],_testData[26], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[14],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[15],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[16],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[17],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[18],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[19],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[20],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[9], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[1],_testData[10], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[2],_testData[11], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[3],_testData[12], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[4],_testData[13], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[5],_testData[14], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[6],_testData[15], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[7],_testData[16], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[8],_testData[17], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[9],_testData[18], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[10],_testData[19], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[11],_testData[20], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[12],_testData[21], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[13],_testData[22], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[14],_testData[23], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[15],_testData[24], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[16],_testData[25], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[17],_testData[26], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[18],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[19],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[20],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[21],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[22],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[23],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[24],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(models[25],_testData[34], false);
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
FROM public.sbytesmallintmmarrayd3e1m m
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
FROM public.sbytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintMMArrayD3E1M>();
                var secondItems1 = new List<FlatSBytesmallintMMArrayD3E1M>();
                var secondItems2 = new List<FlatSBytesmallintMMArrayD3E1M>();
                 ((ISByteMArraysmallintMMArrayD3)this).DbConnectionDynQuerySelectModelBatch(connection, 44, query1, 19, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatSBytesmallintMMArrayD3E1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.sbytesmallintmmarrayd3e1m m
LEFT JOIN public.sbytesmallintmmarrayd3e1mi mi ON mi.id = m.sbytesmallintmmarrayd3e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(SBytesmallintMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3)),
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
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3)),
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
                var models = await((ISByteMArraysmallintMMArrayD3)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SBytesmallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ISByteMArraysmallintMMArrayD3)this).DbConnectionSTSelectModelBatchAsync(connection, 112, 6))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[25], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[1],_testData[26], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[2],_testData[27], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[3],_testData[28], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[4],_testData[29], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[5],_testData[30], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[6],_testData[31], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[7],_testData[32], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[8],_testData[33], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[3], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[1],_testData[4], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[2],_testData[5], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[3],_testData[6], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[4],_testData[7], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[5],_testData[8], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[6],_testData[9], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[7],_testData[10], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[8],_testData[11], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[9],_testData[12], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[10],_testData[13], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[11],_testData[14], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[12],_testData[15], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[13],_testData[16], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[14],_testData[17], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[15],_testData[18], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[16],_testData[19], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[17],_testData[20], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[18],_testData[21], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[19],_testData[22], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[20],_testData[23], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[21],_testData[24], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[22],_testData[25], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[23],_testData[26], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[24],_testData[27], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[25],_testData[28], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[26],_testData[29], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[27],_testData[30], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[28],_testData[31], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[29],_testData[32], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[30],_testData[33], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[31],_testData[34], false);
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
                var models = ((ISByteMArraysmallintMMArrayD3)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SBytesmallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ISByteMArraysmallintMMArrayD3)this).DbConnectionSTSelectModelBatch(connection, 12, 85))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[4], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[1],_testData[5], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[2],_testData[6], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[3],_testData[7], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[4],_testData[8], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[5],_testData[9], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[6],_testData[10], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[7],_testData[11], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[8],_testData[12], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[9],_testData[13], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[10],_testData[14], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[11],_testData[15], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[12],_testData[16], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[13],_testData[17], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[14],_testData[18], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[15],_testData[19], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[16],_testData[20], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[17],_testData[21], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[18],_testData[22], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[19],_testData[23], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[20],_testData[24], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[21],_testData[25], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[22],_testData[26], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[23],_testData[27], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[24],_testData[28], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[25],_testData[29], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[26],_testData[30], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[27],_testData[31], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[28],_testData[32], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[29],_testData[33], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[19], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[1],_testData[20], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[2],_testData[21], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[3],_testData[22], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[4],_testData[23], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[5],_testData[24], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[6],_testData[25], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[7],_testData[26], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[8],_testData[27], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[9],_testData[28], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[10],_testData[29], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[11],_testData[30], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[12],_testData[31], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[13],_testData[32], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[14],_testData[33], false);
                        SBytesmallintMMArrayD3E1M.AssertModel(models[15],_testData[34], false);
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
                await using var cmd = await ((ISByteMArraysmallintMMArrayD3)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ISByteMArraysmallintMMArrayD3)this).SetDbConnectionSelectModelParametrs(cmd, 79);
                var models = await ((ISByteMArraysmallintMMArrayD3)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(17));

                SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[18], false);
                SBytesmallintMMArrayD3E1M.AssertModel(models[1],_testData[19], false);
                SBytesmallintMMArrayD3E1M.AssertModel(models[2],_testData[20], false);
                SBytesmallintMMArrayD3E1M.AssertModel(models[3],_testData[21], false);
                SBytesmallintMMArrayD3E1M.AssertModel(models[4],_testData[22], false);
                SBytesmallintMMArrayD3E1M.AssertModel(models[5],_testData[23], false);
                SBytesmallintMMArrayD3E1M.AssertModel(models[6],_testData[24], false);
                SBytesmallintMMArrayD3E1M.AssertModel(models[7],_testData[25], false);
                SBytesmallintMMArrayD3E1M.AssertModel(models[8],_testData[26], false);
                SBytesmallintMMArrayD3E1M.AssertModel(models[9],_testData[27], false);
                SBytesmallintMMArrayD3E1M.AssertModel(models[10],_testData[28], false);
                SBytesmallintMMArrayD3E1M.AssertModel(models[11],_testData[29], false);
                SBytesmallintMMArrayD3E1M.AssertModel(models[12],_testData[30], false);
                SBytesmallintMMArrayD3E1M.AssertModel(models[13],_testData[31], false);
                SBytesmallintMMArrayD3E1M.AssertModel(models[14],_testData[32], false);
                SBytesmallintMMArrayD3E1M.AssertModel(models[15],_testData[33], false);
                SBytesmallintMMArrayD3E1M.AssertModel(models[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISByteMArraysmallintMMArrayD3)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISByteMArraysmallintMMArrayD3)this).SetDbConnectionSelectModelParametrs(cmd, 97);
                var models =  ((ISByteMArraysmallintMMArrayD3)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(14));

                SBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[21], false);
                SBytesmallintMMArrayD3E1M.AssertModel(models[1],_testData[22], false);
                SBytesmallintMMArrayD3E1M.AssertModel(models[2],_testData[23], false);
                SBytesmallintMMArrayD3E1M.AssertModel(models[3],_testData[24], false);
                SBytesmallintMMArrayD3E1M.AssertModel(models[4],_testData[25], false);
                SBytesmallintMMArrayD3E1M.AssertModel(models[5],_testData[26], false);
                SBytesmallintMMArrayD3E1M.AssertModel(models[6],_testData[27], false);
                SBytesmallintMMArrayD3E1M.AssertModel(models[7],_testData[28], false);
                SBytesmallintMMArrayD3E1M.AssertModel(models[8],_testData[29], false);
                SBytesmallintMMArrayD3E1M.AssertModel(models[9],_testData[30], false);
                SBytesmallintMMArrayD3E1M.AssertModel(models[10],_testData[31], false);
                SBytesmallintMMArrayD3E1M.AssertModel(models[11],_testData[32], false);
                SBytesmallintMMArrayD3E1M.AssertModel(models[12],_testData[33], false);
                SBytesmallintMMArrayD3E1M.AssertModel(models[13],_testData[34], false);
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
FROM public.binary_sbytesmallintmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(SBytesmallintMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(SBytesmallintMMArrayD3E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SBytesmallintMMArrayD3E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SBytesmallintMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISByteMArraysmallintMMArrayD3)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_sbytesmallintmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ISByteMArraysmallintMMArrayD3)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SBytesmallintMMArrayD3E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SBytesmallintMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISByteMArraysmallintMMArrayD3)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_sbytesmallintmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ISByteMArraysmallintMMArrayD3)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_sbytesmallintmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(SBytesmallintMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(SBytesmallintMMArrayD3E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SBytesmallintMMArrayD3E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SBytesmallintMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISByteMArraysmallintMMArrayD3)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_sbytesmallintmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ISByteMArraysmallintMMArrayD3)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SBytesmallintMMArrayD3E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SBytesmallintMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISByteMArraysmallintMMArrayD3)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_sbytesmallintmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ISByteMArraysmallintMMArrayD3)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_sbytesmallintmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(SBytesmallintMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_sbytesmallintmmarrayd3e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(SBytesmallintMMArrayD3E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SBytesmallintMMArrayD3E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ISByteMArraysmallintMMArrayD3)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((ISByteMArraysmallintMMArrayD3)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintMMArrayD3E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<SBytesmallintMMArrayD3E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ISByteMArraysmallintMMArrayD3)this).WAImportModelInner(connection, importCollection);
                var models = ((ISByteMArraysmallintMMArrayD3)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintMMArrayD3E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_sbytesmallintmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(SBytesmallintMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_sbytesmallintmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(SBytesmallintMMArrayD3E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SBytesmallintMMArrayD3E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SBytesmallintMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISByteMArraysmallintMMArrayD3)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ISByteMArraysmallintMMArrayD3)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SBytesmallintMMArrayD3E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SBytesmallintMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISByteMArraysmallintMMArrayD3)this).ImportModelInner(connection, importCollection);
                var models = ((ISByteMArraysmallintMMArrayD3)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintMMArrayD3E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_sbytesmallintmmarrayd3e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
sbytesmallintmmarrayd3e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(SBytesmallintMMArrayD3E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3))]
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
FROM public.binary_sbytesmallintmmarrayd3e1m m
LEFT JOIN public.binary_sbytesmallintmmarrayd3e1mi mi ON mi.id = m.sbytesmallintmmarrayd3e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(SBytesmallintMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SBytesmallintMMArrayD3E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((ISByteMArraysmallintMMArrayD3)this).ImportModelAsync(connection, importCollection);
                var models = await ((ISByteMArraysmallintMMArrayD3)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    SBytesmallintMMArrayD3E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<SBytesmallintMMArrayD3E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((ISByteMArraysmallintMMArrayD3)this).ImportModel(connection, importCollection);
                var models = ((ISByteMArraysmallintMMArrayD3)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    SBytesmallintMMArrayD3E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_sbytesmallintmmarrayd3e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    sbytesmallintmmarrayd3e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(SBytesmallintMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
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
                var models =  ((ISByteMArraysmallintMMArrayD3)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    SBytesmallintMMArrayD3E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISByteMArraysmallintMMArrayD3)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    SBytesmallintMMArrayD3E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(SBytesmallintMMArrayD3E1MIWA), typeof(SBytesmallintMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
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
                var models1 = new List<SBytesmallintMMArrayD3E1MIWA>();
                var models2 = new List<SBytesmallintMMArrayD3E1MIWA>();
                await ((ISByteMArraysmallintMMArrayD3)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_sbytesmallintmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SBytesmallintMMArrayD3E1MIWA>();
                var models2 = new List<SBytesmallintMMArrayD3E1MIWA>();
                ((ISByteMArraysmallintMMArrayD3)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_sbytesmallintmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(SBytesmallintMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
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
                var models = await ((ISByteMArraysmallintMMArrayD3)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_sbytesmallintmmarrayd3e1mi
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
                    SBytesmallintMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISByteMArraysmallintMMArrayD3)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_sbytesmallintmmarrayd3e1mi
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
                    SBytesmallintMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(SBytesmallintMMArrayD3E1MIWA), typeof(SBytesmallintMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3))]
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
                var models1 = new List<SBytesmallintMMArrayD3E1MIWA>();
                var models2 = new List<SBytesmallintMMArrayD3E1MIWA>();
                await ((ISByteMArraysmallintMMArrayD3)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_sbytesmallintmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SBytesmallintMMArrayD3E1MIWA>();
                var models2 = new List<SBytesmallintMMArrayD3E1MIWA>();
                ((ISByteMArraysmallintMMArrayD3)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_sbytesmallintmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(SBytesmallintMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3))]
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
                var models = await ((ISByteMArraysmallintMMArrayD3)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_sbytesmallintmmarrayd3e1mi
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
                    SBytesmallintMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISByteMArraysmallintMMArrayD3)this).DynQueryExportModelInner(connection, @"
COPY public.binary_sbytesmallintmmarrayd3e1mi
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
                    SBytesmallintMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_sbytesmallintmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(SBytesmallintMMArrayD3E1MI), typeof(SBytesmallintMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
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
                var models1 = new List<SBytesmallintMMArrayD3E1MI>();
                var models2 = new List<SBytesmallintMMArrayD3E1MI>();
                await ((ISByteMArraysmallintMMArrayD3)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintMMArrayD3E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintMMArrayD3E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SBytesmallintMMArrayD3E1MI>();
                var models2 = new List<SBytesmallintMMArrayD3E1MI>();
                ((ISByteMArraysmallintMMArrayD3)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintMMArrayD3E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintMMArrayD3E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_sbytesmallintmmarrayd3e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(SBytesmallintMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
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
                var models = await ((ISByteMArraysmallintMMArrayD3)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SBytesmallintMMArrayD3E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((ISByteMArraysmallintMMArrayD3)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SBytesmallintMMArrayD3E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_sbytesmallintmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(SBytesmallintMMArrayD3E1MIWA), typeof(SBytesmallintMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3))]
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
                var models1 = new List<SBytesmallintMMArrayD3E1MIWA>();
                var models2 = new List<SBytesmallintMMArrayD3E1MIWA>();
                await ((ISByteMArraysmallintMMArrayD3)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SBytesmallintMMArrayD3E1MIWA>();
                var models2 = new List<SBytesmallintMMArrayD3E1MIWA>();
                ((ISByteMArraysmallintMMArrayD3)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_sbytesmallintmmarrayd3e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(SBytesmallintMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD3))]
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
                var models = await ((ISByteMArraysmallintMMArrayD3)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SBytesmallintMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISByteMArraysmallintMMArrayD3)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SBytesmallintMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

