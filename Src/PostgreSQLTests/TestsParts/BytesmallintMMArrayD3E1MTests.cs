

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
    internal partial interface IByteMArraysmallintMMArrayD3
    {
    }
    
    internal partial class ByteMArraysmallintMMArrayD3 : IByteMArraysmallintMMArrayD3
    {


#region TestData

        private readonly BytesmallintMMArrayD3E1M[] _testData = new BytesmallintMMArrayD3E1M[]
        {
            new BytesmallintMMArrayD3E1M
{
    Id = 6,
    Value = 
new System.Byte[,,] { { { 124, 241, 23, }, { 61, 36, 132, }, { 252, 62, 79, }, }, { { 179, 130, 76, }, { 111, 104, 207, }, { 68, 244, 198, }, }, { { 125, 163, 135, }, { 1, 17, 202, }, { 69, 77, 73, }, }, },
    ModelInner = null,
    NullableValue = 
new System.Byte[,,] { { { 53, 10, 55, }, { 70, 239, 82, }, { 65, 2, 142, }, }, { { 210, 232, 71, }, { 121, 131, 174, }, { 73, 77, 59, }, }, { { 109, 136, 137, }, { 253, 160, 98, }, { 120, 175, 44, }, }, },
},
            new BytesmallintMMArrayD3E1M
{
    Id = 7,
    Value = 
new System.Byte[,,] { { { 71, 101, 98, }, { 101, 199, 212, }, { 168, 66, 50, }, }, { { 235, 231, 33, }, { 110, 157, 91, }, { 232, 234, 183, }, }, { { 52, 128, 162, }, { 90, 247, 114, }, { 28, 22, 67, }, }, },
    ModelInner = new BytesmallintMMArrayD3E1MI
{
    Id = 5,
    Value = 
new System.Byte[,,] { { { 4, 68, 75, }, { 247, 217, 219, }, { 116, 221, 147, }, }, { { 238, 34, 35, }, { 191, 62, 179, }, { 120, 222, 14, }, }, { { 247, 183, 157, }, { 152, 210, 111, }, { 254, 35, 178, }, }, },
    NullableValue = 
new System.Byte[,,] { { { 167, 183, 48, }, { 145, 75, 26, }, { 114, 100, 196, }, }, { { 94, 97, 41, }, { 78, 179, 230, }, { 11, 12, 19, }, }, { { 51, 30, 188, }, { 187, 186, 54, }, { 198, 234, 92, }, }, },
},
    NullableValue = null,
},
            new BytesmallintMMArrayD3E1M
{
    Id = 15,
    Value = 
new System.Byte[,,] { { { 49, 110, 104, }, { 77, 224, 124, }, { 129, 224, 44, }, }, { { 53, 182, 117, }, { 48, 249, 196, }, { 56, 179, 222, }, }, { { 184, 49, 112, }, { 224, 103, 7, }, { 112, 41, 70, }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintMMArrayD3E1M
{
    Id = 17,
    Value = 
new System.Byte[,,] { { { 14, 69, 11, }, { 198, 32, 205, }, { 162, 136, 241, }, }, { { 137, 47, 128, }, { 211, 54, 156, }, { 172, 216, 208, }, }, { { 209, 135, 42, }, { 5, 100, 14, }, { 68, 126, 1, }, }, },
    ModelInner = new BytesmallintMMArrayD3E1MI
{
    Id = 8,
    Value = 
new System.Byte[,,] { { { 63, 145, 231, }, { 20, 235, 145, }, { 102, 190, 76, }, }, { { 231, 142, 122, }, { 203, 127, 29, }, { 168, 111, 137, }, }, { { 243, 123, 238, }, { 50, 158, 125, }, { 60, 0, 90, }, }, },
    NullableValue = 
new System.Byte[,,] { { { 245, 7, 145, }, { 88, 150, 211, }, { 250, 186, 194, }, }, { { 111, 214, 205, }, { 254, 203, 118, }, { 197, 163, 121, }, }, { { 161, 57, 220, }, { 129, 237, 48, }, { 140, 57, 58, }, }, },
},
    NullableValue = null,
},
            new BytesmallintMMArrayD3E1M
{
    Id = 20,
    Value = 
new System.Byte[,,] { { { 135, 205, 184, }, { 241, 159, 34, }, { 163, 118, 98, }, }, { { 47, 78, 174, }, { 82, 124, 3, }, { 76, 10, 144, }, }, { { 194, 163, 176, }, { 36, 158, 233, }, { 197, 146, 17, }, }, },
    ModelInner = null,
    NullableValue = 
new System.Byte[,,] { { { 161, 66, 151, }, { 113, 101, 216, }, { 14, 101, 88, }, }, { { 123, 68, 250, }, { 7, 178, 218, }, { 125, 205, 128, }, }, { { 55, 151, 198, }, { 194, 196, 52, }, { 158, 68, 132, }, }, },
},
            new BytesmallintMMArrayD3E1M
{
    Id = 24,
    Value = 
new System.Byte[,,] { { { 65, 75, 244, }, { 226, 116, 22, }, { 199, 185, 40, }, }, { { 67, 165, 25, }, { 76, 42, 208, }, { 190, 131, 73, }, }, { { 194, 177, 204, }, { 130, 221, 199, }, { 84, 27, 13, }, }, },
    ModelInner = new BytesmallintMMArrayD3E1MI
{
    Id = 15,
    Value = 
new System.Byte[,,] { { { 164, 192, 24, }, { 13, 62, 169, }, { 1, 251, 178, }, }, { { 0, 215, 17, }, { 116, 36, 74, }, { 65, 74, 137, }, }, { { 200, 81, 136, }, { 118, 19, 236, }, { 126, 2, 77, }, }, },
    NullableValue = 
new System.Byte[,,] { { { 34, 38, 93, }, { 142, 157, 71, }, { 161, 247, 218, }, }, { { 73, 195, 56, }, { 12, 233, 179, }, { 204, 140, 2, }, }, { { 162, 182, 30, }, { 124, 252, 82, }, { 75, 164, 184, }, }, },
},
    NullableValue = null,
},
            new BytesmallintMMArrayD3E1M
{
    Id = 26,
    Value = 
new System.Byte[,,] { { { 67, 208, 131, }, { 19, 31, 145, }, { 157, 218, 127, }, }, { { 41, 191, 6, }, { 216, 88, 242, }, { 22, 77, 31, }, }, { { 228, 10, 47, }, { 166, 159, 178, }, { 138, 75, 247, }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintMMArrayD3E1M
{
    Id = 27,
    Value = 
new System.Byte[,,] { { { 196, 152, 233, }, { 240, 24, 60, }, { 217, 223, 234, }, }, { { 54, 63, 182, }, { 219, 41, 71, }, { 151, 39, 73, }, }, { { 123, 208, 242, }, { 3, 20, 114, }, { 84, 138, 110, }, }, },
    ModelInner = new BytesmallintMMArrayD3E1MI
{
    Id = 21,
    Value = 
new System.Byte[,,] { { { 2, 208, 16, }, { 17, 19, 4, }, { 67, 231, 28, }, }, { { 231, 95, 105, }, { 249, 218, 142, }, { 102, 33, 178, }, }, { { 127, 46, 2, }, { 125, 0, 239, }, { 87, 137, 228, }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new BytesmallintMMArrayD3E1M
{
    Id = 28,
    Value = 
new System.Byte[,,] { { { 104, 69, 246, }, { 153, 183, 208, }, { 0, 83, 7, }, }, { { 172, 144, 148, }, { 198, 65, 61, }, { 149, 222, 220, }, }, { { 217, 53, 141, }, { 201, 180, 150, }, { 73, 180, 205, }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintMMArrayD3E1M
{
    Id = 37,
    Value = 
new System.Byte[,,] { { { 150, 41, 95, }, { 85, 22, 126, }, { 218, 131, 94, }, }, { { 10, 107, 235, }, { 195, 17, 65, }, { 229, 47, 108, }, }, { { 19, 205, 154, }, { 177, 122, 185, }, { 37, 101, 143, }, }, },
    ModelInner = new BytesmallintMMArrayD3E1MI
{
    Id = 27,
    Value = 
new System.Byte[,,] { { { 236, 239, 45, }, { 54, 27, 87, }, { 235, 237, 129, }, }, { { 172, 201, 54, }, { 102, 130, 209, }, { 201, 212, 11, }, }, { { 115, 90, 77, }, { 203, 142, 187, }, { 112, 71, 121, }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,,] { { { 196, 116, 170, }, { 19, 115, 52, }, { 221, 11, 188, }, }, { { 143, 194, 58, }, { 181, 208, 55, }, { 36, 29, 20, }, }, { { 96, 88, 29, }, { 68, 222, 75, }, { 58, 151, 67, }, }, },
},
            new BytesmallintMMArrayD3E1M
{
    Id = 41,
    Value = 
new System.Byte[,,] { { { 217, 39, 99, }, { 43, 229, 142, }, { 212, 200, 121, }, }, { { 123, 130, 135, }, { 19, 53, 9, }, { 174, 108, 254, }, }, { { 11, 122, 105, }, { 121, 52, 101, }, { 58, 25, 123, }, }, },
    ModelInner = null,
    NullableValue = 
new System.Byte[,,] { { { 178, 217, 100, }, { 113, 66, 254, }, { 19, 55, 97, }, }, { { 244, 229, 188, }, { 6, 187, 64, }, { 114, 16, 125, }, }, { { 240, 56, 158, }, { 26, 185, 102, }, { 60, 214, 52, }, }, },
},
            new BytesmallintMMArrayD3E1M
{
    Id = 46,
    Value = 
new System.Byte[,,] { { { 62, 178, 164, }, { 159, 209, 86, }, { 122, 151, 150, }, }, { { 175, 165, 118, }, { 81, 250, 151, }, { 211, 88, 137, }, }, { { 11, 243, 233, }, { 233, 70, 129, }, { 233, 123, 159, }, }, },
    ModelInner = new BytesmallintMMArrayD3E1MI
{
    Id = 34,
    Value = 
new System.Byte[,,] { { { 96, 195, 28, }, { 58, 151, 67, }, { 190, 137, 184, }, }, { { 99, 112, 229, }, { 45, 185, 85, }, { 174, 95, 74, }, }, { { 201, 226, 218, }, { 140, 227, 129, }, { 96, 209, 162, }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new BytesmallintMMArrayD3E1M
{
    Id = 48,
    Value = 
new System.Byte[,,] { { { 187, 88, 51, }, { 218, 97, 135, }, { 128, 143, 152, }, }, { { 133, 85, 66, }, { 118, 51, 133, }, { 31, 140, 174, }, }, { { 55, 246, 41, }, { 113, 238, 20, }, { 220, 61, 116, }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintMMArrayD3E1M
{
    Id = 55,
    Value = 
new System.Byte[,,] { { { 34, 140, 36, }, { 87, 29, 247, }, { 94, 223, 81, }, }, { { 94, 96, 138, }, { 36, 95, 140, }, { 195, 33, 236, }, }, { { 141, 172, 114, }, { 32, 178, 141, }, { 76, 81, 114, }, }, },
    ModelInner = new BytesmallintMMArrayD3E1MI
{
    Id = 38,
    Value = 
new System.Byte[,,] { { { 251, 59, 232, }, { 25, 182, 242, }, { 129, 54, 220, }, }, { { 217, 117, 107, }, { 36, 98, 208, }, { 19, 89, 32, }, }, { { 223, 102, 245, }, { 216, 191, 169, }, { 58, 115, 80, }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new BytesmallintMMArrayD3E1M
{
    Id = 59,
    Value = 
new System.Byte[,,] { { { 235, 235, 239, }, { 102, 190, 124, }, { 229, 204, 159, }, }, { { 182, 78, 1, }, { 224, 224, 218, }, { 158, 19, 10, }, }, { { 4, 140, 17, }, { 163, 183, 161, }, { 77, 83, 76, }, }, },
    ModelInner = null,
    NullableValue = 
new System.Byte[,,] { { { 231, 222, 119, }, { 53, 131, 73, }, { 79, 69, 169, }, }, { { 194, 58, 74, }, { 175, 21, 55, }, { 73, 2, 41, }, }, { { 249, 184, 126, }, { 53, 178, 217, }, { 137, 174, 3, }, }, },
},
            new BytesmallintMMArrayD3E1M
{
    Id = 68,
    Value = 
new System.Byte[,,] { { { 88, 178, 174, }, { 153, 74, 123, }, { 252, 170, 28, }, }, { { 8, 37, 123, }, { 86, 198, 45, }, { 185, 227, 238, }, }, { { 87, 31, 215, }, { 153, 189, 93, }, { 178, 223, 38, }, }, },
    ModelInner = new BytesmallintMMArrayD3E1MI
{
    Id = 40,
    Value = 
new System.Byte[,,] { { { 253, 240, 251, }, { 146, 167, 198, }, { 60, 33, 86, }, }, { { 72, 236, 143, }, { 199, 140, 117, }, { 139, 56, 98, }, }, { { 161, 8, 220, }, { 30, 112, 12, }, { 42, 25, 145, }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new BytesmallintMMArrayD3E1M
{
    Id = 69,
    Value = 
new System.Byte[,,] { { { 116, 41, 49, }, { 171, 214, 31, }, { 229, 121, 91, }, }, { { 235, 144, 188, }, { 234, 107, 94, }, { 159, 24, 188, }, }, { { 103, 167, 165, }, { 176, 145, 230, }, { 219, 180, 200, }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintMMArrayD3E1M
{
    Id = 74,
    Value = 
new System.Byte[,,] { { { 126, 144, 26, }, { 247, 249, 74, }, { 184, 37, 155, }, }, { { 132, 26, 4, }, { 143, 157, 210, }, { 240, 114, 172, }, }, { { 16, 169, 83, }, { 177, 119, 240, }, { 137, 142, 41, }, }, },
    ModelInner = new BytesmallintMMArrayD3E1MI
{
    Id = 44,
    Value = 
new System.Byte[,,] { { { 14, 254, 56, }, { 75, 69, 19, }, { 78, 129, 140, }, }, { { 231, 187, 26, }, { 170, 131, 105, }, { 123, 162, 220, }, }, { { 136, 206, 195, }, { 95, 238, 17, }, { 79, 204, 177, }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new BytesmallintMMArrayD3E1M
{
    Id = 78,
    Value = 
new System.Byte[,,] { { { 137, 146, 97, }, { 6, 92, 125, }, { 197, 226, 120, }, }, { { 29, 176, 51, }, { 202, 112, 246, }, { 4, 35, 104, }, }, { { 157, 208, 111, }, { 167, 210, 203, }, { 156, 31, 53, }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintMMArrayD3E1M
{
    Id = 80,
    Value = 
new System.Byte[,,] { { { 58, 89, 222, }, { 59, 136, 24, }, { 208, 88, 39, }, }, { { 22, 179, 207, }, { 238, 23, 152, }, { 162, 67, 151, }, }, { { 192, 243, 36, }, { 225, 163, 226, }, { 141, 209, 55, }, }, },
    ModelInner = new BytesmallintMMArrayD3E1MI
{
    Id = 50,
    Value = 
new System.Byte[,,] { { { 40, 14, 7, }, { 22, 223, 17, }, { 40, 91, 237, }, }, { { 187, 187, 71, }, { 30, 67, 37, }, { 174, 157, 249, }, }, { { 71, 37, 113, }, { 63, 94, 87, }, { 113, 137, 53, }, }, },
    NullableValue = 
new System.Byte[,,] { { { 176, 223, 176, }, { 131, 7, 2, }, { 77, 68, 232, }, }, { { 105, 102, 222, }, { 97, 189, 173, }, { 226, 241, 41, }, }, { { 44, 0, 177, }, { 129, 40, 112, }, { 212, 250, 253, }, }, },
},
    NullableValue = null,
},
            new BytesmallintMMArrayD3E1M
{
    Id = 88,
    Value = 
new System.Byte[,,] { { { 99, 253, 218, }, { 96, 84, 244, }, { 194, 161, 204, }, }, { { 199, 68, 202, }, { 246, 74, 119, }, { 230, 119, 182, }, }, { { 68, 55, 36, }, { 86, 134, 217, }, { 94, 239, 149, }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintMMArrayD3E1M
{
    Id = 91,
    Value = 
new System.Byte[,,] { { { 33, 244, 217, }, { 111, 14, 104, }, { 18, 96, 126, }, }, { { 226, 31, 83, }, { 202, 75, 170, }, { 51, 27, 143, }, }, { { 57, 82, 106, }, { 139, 237, 36, }, { 60, 30, 184, }, }, },
    ModelInner = new BytesmallintMMArrayD3E1MI
{
    Id = 57,
    Value = 
new System.Byte[,,] { { { 190, 61, 192, }, { 213, 214, 26, }, { 130, 201, 242, }, }, { { 244, 37, 104, }, { 214, 168, 114, }, { 249, 110, 65, }, }, { { 44, 237, 222, }, { 22, 6, 62, }, { 59, 244, 232, }, }, },
    NullableValue = 
new System.Byte[,,] { { { 211, 105, 206, }, { 106, 117, 156, }, { 190, 246, 205, }, }, { { 24, 104, 189, }, { 189, 98, 167, }, { 26, 46, 147, }, }, { { 173, 232, 126, }, { 9, 115, 229, }, { 165, 232, 150, }, }, },
},
    NullableValue = 
new System.Byte[,,] { { { 200, 202, 101, }, { 124, 231, 47, }, { 226, 4, 246, }, }, { { 146, 132, 183, }, { 100, 138, 231, }, { 202, 80, 212, }, }, { { 75, 105, 57, }, { 242, 55, 2, }, { 110, 63, 52, }, }, },
},
            new BytesmallintMMArrayD3E1M
{
    Id = 94,
    Value = 
new System.Byte[,,] { { { 205, 51, 25, }, { 248, 246, 27, }, { 93, 194, 19, }, }, { { 178, 11, 150, }, { 84, 155, 172, }, { 163, 204, 115, }, }, { { 228, 92, 45, }, { 110, 97, 224, }, { 160, 8, 190, }, }, },
    ModelInner = null,
    NullableValue = 
new System.Byte[,,] { { { 153, 79, 111, }, { 3, 174, 197, }, { 29, 179, 234, }, }, { { 52, 73, 14, }, { 76, 4, 44, }, { 206, 244, 232, }, }, { { 88, 136, 154, }, { 188, 17, 144, }, { 206, 59, 205, }, }, },
},
            new BytesmallintMMArrayD3E1M
{
    Id = 102,
    Value = 
new System.Byte[,,] { { { 43, 169, 171, }, { 238, 25, 155, }, { 136, 25, 153, }, }, { { 117, 129, 59, }, { 27, 30, 74, }, { 24, 45, 61, }, }, { { 13, 239, 204, }, { 163, 188, 180, }, { 107, 105, 187, }, }, },
    ModelInner = new BytesmallintMMArrayD3E1MI
{
    Id = 58,
    Value = 
new System.Byte[,,] { { { 106, 193, 42, }, { 106, 144, 117, }, { 168, 83, 35, }, }, { { 108, 209, 32, }, { 146, 113, 64, }, { 147, 127, 16, }, }, { { 230, 218, 165, }, { 98, 103, 109, }, { 28, 160, 131, }, }, },
    NullableValue = 
new System.Byte[,,] { { { 165, 216, 72, }, { 61, 40, 93, }, { 228, 113, 167, }, }, { { 96, 56, 167, }, { 199, 193, 99, }, { 75, 177, 127, }, }, { { 84, 78, 49, }, { 28, 189, 66, }, { 77, 92, 103, }, }, },
},
    NullableValue = null,
},
            new BytesmallintMMArrayD3E1M
{
    Id = 110,
    Value = 
new System.Byte[,,] { { { 159, 250, 160, }, { 249, 170, 99, }, { 175, 60, 144, }, }, { { 145, 41, 131, }, { 96, 85, 204, }, { 106, 165, 63, }, }, { { 69, 133, 31, }, { 184, 35, 70, }, { 96, 170, 232, }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintMMArrayD3E1M
{
    Id = 117,
    Value = 
new System.Byte[,,] { { { 108, 5, 241, }, { 221, 231, 105, }, { 247, 57, 48, }, }, { { 79, 94, 96, }, { 30, 245, 141, }, { 182, 173, 106, }, }, { { 14, 156, 137, }, { 224, 187, 227, }, { 99, 204, 198, }, }, },
    ModelInner = new BytesmallintMMArrayD3E1MI
{
    Id = 60,
    Value = 
new System.Byte[,,] { { { 49, 27, 13, }, { 90, 162, 177, }, { 29, 33, 40, }, }, { { 181, 13, 113, }, { 157, 101, 162, }, { 116, 46, 174, }, }, { { 212, 82, 172, }, { 44, 22, 53, }, { 8, 102, 166, }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,,] { { { 106, 123, 167, }, { 161, 196, 135, }, { 37, 117, 39, }, }, { { 128, 58, 231, }, { 95, 15, 55, }, { 133, 215, 157, }, }, { { 170, 120, 249, }, { 124, 133, 170, }, { 193, 7, 40, }, }, },
},
            new BytesmallintMMArrayD3E1M
{
    Id = 123,
    Value = 
new System.Byte[,,] { { { 187, 62, 54, }, { 81, 94, 245, }, { 240, 81, 98, }, }, { { 213, 177, 234, }, { 43, 181, 69, }, { 134, 42, 161, }, }, { { 223, 250, 113, }, { 54, 78, 142, }, { 118, 44, 189, }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintMMArrayD3E1M
{
    Id = 128,
    Value = 
new System.Byte[,,] { { { 171, 37, 233, }, { 132, 89, 205, }, { 54, 224, 35, }, }, { { 237, 247, 165, }, { 52, 166, 79, }, { 0, 231, 54, }, }, { { 110, 180, 133, }, { 49, 185, 201, }, { 212, 221, 189, }, }, },
    ModelInner = new BytesmallintMMArrayD3E1MI
{
    Id = 63,
    Value = 
new System.Byte[,,] { { { 130, 182, 110, }, { 30, 67, 43, }, { 122, 236, 230, }, }, { { 184, 7, 242, }, { 123, 207, 138, }, { 93, 29, 23, }, }, { { 241, 157, 198, }, { 67, 127, 172, }, { 179, 32, 202, }, }, },
    NullableValue = 
new System.Byte[,,] { { { 119, 46, 135, }, { 150, 65, 18, }, { 232, 135, 234, }, }, { { 97, 74, 159, }, { 125, 190, 97, }, { 34, 64, 121, }, }, { { 128, 135, 62, }, { 89, 110, 97, }, { 26, 87, 31, }, }, },
},
    NullableValue = 
new System.Byte[,,] { { { 198, 220, 116, }, { 18, 113, 58, }, { 34, 132, 7, }, }, { { 214, 24, 144, }, { 192, 140, 33, }, { 228, 34, 199, }, }, { { 73, 210, 109, }, { 37, 25, 68, }, { 98, 168, 68, }, }, },
},
            new BytesmallintMMArrayD3E1M
{
    Id = 136,
    Value = 
new System.Byte[,,] { { { 46, 22, 117, }, { 150, 97, 113, }, { 236, 158, 1, }, }, { { 61, 82, 106, }, { 196, 211, 12, }, { 191, 57, 2, }, }, { { 157, 59, 22, }, { 219, 124, 67, }, { 176, 146, 234, }, }, },
    ModelInner = null,
    NullableValue = 
new System.Byte[,,] { { { 161, 180, 185, }, { 27, 71, 89, }, { 75, 102, 5, }, }, { { 146, 78, 219, }, { 118, 96, 226, }, { 190, 23, 141, }, }, { { 214, 146, 121, }, { 40, 146, 180, }, { 92, 188, 206, }, }, },
},
            new BytesmallintMMArrayD3E1M
{
    Id = 142,
    Value = 
new System.Byte[,,] { { { 246, 129, 71, }, { 37, 117, 80, }, { 45, 181, 103, }, }, { { 7, 82, 86, }, { 240, 178, 74, }, { 63, 96, 130, }, }, { { 6, 179, 229, }, { 0, 10, 89, }, { 210, 194, 63, }, }, },
    ModelInner = new BytesmallintMMArrayD3E1MI
{
    Id = 70,
    Value = 
new System.Byte[,,] { { { 29, 15, 136, }, { 99, 250, 125, }, { 190, 10, 12, }, }, { { 56, 109, 250, }, { 37, 209, 196, }, { 38, 2, 219, }, }, { { 46, 85, 199, }, { 156, 234, 131, }, { 169, 125, 216, }, }, },
    NullableValue = 
new System.Byte[,,] { { { 174, 111, 215, }, { 5, 240, 157, }, { 215, 76, 113, }, }, { { 2, 183, 22, }, { 151, 45, 144, }, { 122, 139, 226, }, }, { { 145, 98, 172, }, { 112, 107, 164, }, { 61, 119, 170, }, }, },
},
    NullableValue = 
new System.Byte[,,] { { { 61, 134, 204, }, { 165, 192, 205, }, { 203, 168, 254, }, }, { { 79, 106, 94, }, { 194, 38, 111, }, { 199, 187, 30, }, }, { { 28, 79, 76, }, { 111, 102, 169, }, { 217, 144, 80, }, }, },
},
            new BytesmallintMMArrayD3E1M
{
    Id = 151,
    Value = 
new System.Byte[,,] { { { 164, 198, 52, }, { 59, 42, 38, }, { 187, 57, 218, }, }, { { 182, 29, 192, }, { 210, 57, 240, }, { 74, 96, 230, }, }, { { 32, 132, 114, }, { 18, 47, 243, }, { 113, 176, 114, }, }, },
    ModelInner = null,
    NullableValue = 
new System.Byte[,,] { { { 239, 217, 165, }, { 228, 54, 237, }, { 51, 26, 2, }, }, { { 92, 189, 57, }, { 171, 68, 226, }, { 149, 162, 233, }, }, { { 97, 229, 214, }, { 195, 137, 58, }, { 103, 131, 204, }, }, },
},
            new BytesmallintMMArrayD3E1M
{
    Id = 154,
    Value = 
new System.Byte[,,] { { { 57, 235, 42, }, { 175, 212, 8, }, { 154, 210, 243, }, }, { { 207, 145, 64, }, { 5, 72, 224, }, { 166, 189, 89, }, }, { { 97, 173, 198, }, { 215, 62, 78, }, { 78, 121, 249, }, }, },
    ModelInner = new BytesmallintMMArrayD3E1MI
{
    Id = 78,
    Value = 
new System.Byte[,,] { { { 99, 191, 145, }, { 74, 156, 240, }, { 229, 152, 0, }, }, { { 23, 149, 87, }, { 41, 231, 181, }, { 26, 9, 220, }, }, { { 233, 92, 152, }, { 116, 192, 2, }, { 155, 165, 244, }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new BytesmallintMMArrayD3E1M
{
    Id = 161,
    Value = 
new System.Byte[,,] { { { 224, 13, 119, }, { 111, 220, 112, }, { 217, 148, 46, }, }, { { 131, 15, 126, }, { 33, 17, 81, }, { 146, 190, 122, }, }, { { 46, 66, 110, }, { 211, 232, 93, }, { 47, 93, 18, }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintMMArrayD3E1M
{
    Id = 163,
    Value = 
new System.Byte[,,] { { { 65, 161, 174, }, { 23, 177, 165, }, { 0, 56, 64, }, }, { { 202, 253, 86, }, { 119, 35, 173, }, { 88, 131, 99, }, }, { { 136, 82, 30, }, { 53, 247, 131, }, { 141, 88, 105, }, }, },
    ModelInner = new BytesmallintMMArrayD3E1MI
{
    Id = 86,
    Value = 
new System.Byte[,,] { { { 167, 30, 105, }, { 133, 73, 56, }, { 36, 46, 108, }, }, { { 212, 199, 29, }, { 157, 215, 35, }, { 132, 224, 142, }, }, { { 243, 232, 66, }, { 29, 31, 5, }, { 162, 240, 74, }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new BytesmallintMMArrayD3E1M
{
    Id = 165,
    Value = 
new System.Byte[,,] { { { 32, 182, 64, }, { 243, 213, 131, }, { 90, 200, 0, }, }, { { 170, 177, 183, }, { 31, 205, 158, }, { 191, 91, 138, }, }, { { 1, 20, 209, }, { 167, 90, 139, }, { 232, 3, 195, }, }, },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bytesmallintmmarrayd3e1mi(
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
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Byte[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Byte[,,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bytesmallintmmarrayd3e1mi(
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
            queryMapTypes: [typeof(BytesmallintMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Byte[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Byte[,,]), 
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

                changedRows =  ((IByteMArraysmallintMMArrayD3)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IByteMArraysmallintMMArrayD3)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IByteMArraysmallintMMArrayD3)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteMArraysmallintMMArrayD3)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IByteMArraysmallintMMArrayD3)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IByteMArraysmallintMMArrayD3)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IByteMArraysmallintMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IByteMArraysmallintMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IByteMArraysmallintMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IByteMArraysmallintMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IByteMArraysmallintMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IByteMArraysmallintMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IByteMArraysmallintMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IByteMArraysmallintMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IByteMArraysmallintMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IByteMArraysmallintMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IByteMArraysmallintMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bytesmallintmmarrayd3e1m(
	id,
    value,
    nullablevalue,
    bytesmallintmmarrayd3e1mi_id
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
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Byte[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Byte[,,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bytesmallintmmarrayd3e1mi_id", 
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
                changedRows =  ((IByteMArraysmallintMMArrayD3)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IByteMArraysmallintMMArrayD3)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IByteMArraysmallintMMArrayD3)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IByteMArraysmallintMMArrayD3)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bytesmallintmmarrayd3e1m(
	id,
    value,
    nullablevalue,
    bytesmallintmmarrayd3e1mi_id
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
    bytesmallintmmarrayd3e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BytesmallintMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3)),
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
INSERT INTO public.bytesmallintmmarrayd3e1m(
	id,
    value,
    nullablevalue,
    bytesmallintmmarrayd3e1mi_id
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
    bytesmallintmmarrayd3e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BytesmallintMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Byte[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Byte[,,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bytesmallintmmarrayd3e1mi_id", 
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
                List<BytesmallintMMArrayD3E1M> models = null;

                models =  ((IByteMArraysmallintMMArrayD3)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[4], true);
                models =  ((IByteMArraysmallintMMArrayD3)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[5], true);
                models =  ((IByteMArraysmallintMMArrayD3)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[6], true);
                models =  ((IByteMArraysmallintMMArrayD3)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BytesmallintMMArrayD3E1M> models = null;

                models = await ((IByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[8], true);
                models = await ((IByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[9], true);
                models = await ((IByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[10], true);
                models = await ((IByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[11], true);
                models = await ((IByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[12], true);
                models = await ((IByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[13], true);
                models = await ((IByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[14], true);
                models = await ((IByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[15], true);
                models = await ((IByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IByteMArraysmallintMMArrayD3)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytesmallintMMArrayD3E1M), typeof(FlatBytesmallintMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3)),
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
FROM public.bytesmallintmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBytesmallintMMArrayD3E1M>();
                var models2 = new List<FlatBytesmallintMMArrayD3E1M>();
                await ((IByteMArraysmallintMMArrayD3)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBytesmallintMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bytesmallintmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBytesmallintMMArrayD3E1M>();
                var models2 = new List<FlatBytesmallintMMArrayD3E1M>();
                ((IByteMArraysmallintMMArrayD3)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBytesmallintMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytesmallintMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3)),
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
FROM public.bytesmallintmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IByteMArraysmallintMMArrayD3)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bytesmallintmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IByteMArraysmallintMMArrayD3)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bytesmallintmmarrayd3e1m m
LEFT JOIN public.bytesmallintmmarrayd3e1mi mi ON mi.id = m.bytesmallintmmarrayd3e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BytesmallintMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3)),
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
                var models = await ((IByteMArraysmallintMMArrayD3)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BytesmallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IByteMArraysmallintMMArrayD3)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BytesmallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytesmallintMMArrayD3E1M), typeof(FlatBytesmallintMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3)),
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
FROM public.bytesmallintmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytesmallintMMArrayD3E1M>();
                var models2 = new List<FlatBytesmallintMMArrayD3E1M>();
                await ((IByteMArraysmallintMMArrayD3)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBytesmallintMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bytesmallintmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytesmallintMMArrayD3E1M>();
                var models2 = new List<FlatBytesmallintMMArrayD3E1M>();
                ((IByteMArraysmallintMMArrayD3)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBytesmallintMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytesmallintMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3)),
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
FROM public.bytesmallintmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IByteMArraysmallintMMArrayD3)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bytesmallintmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IByteMArraysmallintMMArrayD3)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bytesmallintmmarrayd3e1m m
LEFT JOIN public.bytesmallintmmarrayd3e1mi mi ON mi.id = m.bytesmallintmmarrayd3e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BytesmallintMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3)),
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
                var models = await ((IByteMArraysmallintMMArrayD3)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BytesmallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IByteMArraysmallintMMArrayD3)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BytesmallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytesmallintMMArrayD3E1M), typeof(FlatBytesmallintMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3)),
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
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3)),
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
FROM public.bytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBytesmallintMMArrayD3E1M>();
                var models2 = new List<FlatBytesmallintMMArrayD3E1M>();
                await((IByteMArraysmallintMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBytesmallintMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
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
FROM public.bytesmallintmmarrayd3e1m m
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
FROM public.bytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintMMArrayD3E1M>();
                var firstItems2 = new List<FlatBytesmallintMMArrayD3E1M>();
                var secondItems1 = new List<FlatBytesmallintMMArrayD3E1M>();
                var secondItems2 = new List<FlatBytesmallintMMArrayD3E1M>();
                await ((IByteMArraysmallintMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
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
FROM public.bytesmallintmmarrayd3e1m m
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
FROM public.bytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintMMArrayD3E1M>();
                var firstItems2 = new List<FlatBytesmallintMMArrayD3E1M>();
                var secondItems1 = new List<FlatBytesmallintMMArrayD3E1M>();
                await ((IByteMArraysmallintMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[16],_testData[34], false);
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
FROM public.bytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBytesmallintMMArrayD3E1M>();
                var models2 = new List<FlatBytesmallintMMArrayD3E1M>();
                ((IByteMArraysmallintMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBytesmallintMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
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
FROM public.bytesmallintmmarrayd3e1m m
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
FROM public.bytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintMMArrayD3E1M>();
                var firstItems2 = new List<FlatBytesmallintMMArrayD3E1M>();
                var secondItems1 = new List<FlatBytesmallintMMArrayD3E1M>();
                var secondItems2 = new List<FlatBytesmallintMMArrayD3E1M>();
                 ((IByteMArraysmallintMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
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
FROM public.bytesmallintmmarrayd3e1m m
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
FROM public.bytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintMMArrayD3E1M>();
                var firstItems2 = new List<FlatBytesmallintMMArrayD3E1M>();
                var secondItems1 = new List<FlatBytesmallintMMArrayD3E1M>();
                 ((IByteMArraysmallintMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[30],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytesmallintMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3)),
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
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3)),
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
FROM public.bytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IByteMArraysmallintMMArrayD3)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bytesmallintmmarrayd3e1m m
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
FROM public.bytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IByteMArraysmallintMMArrayD3)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[1],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[2],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[3],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[4],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[5],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[6],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[7],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[8],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[12], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[1],_testData[13], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[2],_testData[14], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[3],_testData[15], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[4],_testData[16], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[5],_testData[17], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[6],_testData[18], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[7],_testData[19], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[8],_testData[20], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[9],_testData[21], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[10],_testData[22], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[11],_testData[23], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[12],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[13],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[14],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[15],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[16],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[17],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[18],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[19],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[20],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[21],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bytesmallintmmarrayd3e1m m
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
FROM public.bytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintMMArrayD3E1M>();
                var secondItems1 = new List<FlatBytesmallintMMArrayD3E1M>();
                var secondItems2 = new List<FlatBytesmallintMMArrayD3E1M>();
                await ((IByteMArraysmallintMMArrayD3)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.bytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IByteMArraysmallintMMArrayD3)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 154;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bytesmallintmmarrayd3e1m m
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
FROM public.bytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IByteMArraysmallintMMArrayD3)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[1],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[2],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[3],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[4],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[5],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[1],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 123;
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
FROM public.bytesmallintmmarrayd3e1m m
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
FROM public.bytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintMMArrayD3E1M>();
                var secondItems1 = new List<FlatBytesmallintMMArrayD3E1M>();
                var secondItems2 = new List<FlatBytesmallintMMArrayD3E1M>();
                 ((IByteMArraysmallintMMArrayD3)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.bytesmallintmmarrayd3e1m m
LEFT JOIN public.bytesmallintmmarrayd3e1mi mi ON mi.id = m.bytesmallintmmarrayd3e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BytesmallintMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3)),
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
                var models = await((IByteMArraysmallintMMArrayD3)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BytesmallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IByteMArraysmallintMMArrayD3)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[4], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[1],_testData[5], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[2],_testData[6], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[3],_testData[7], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[4],_testData[8], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[5],_testData[9], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[6],_testData[10], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[7],_testData[11], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[8],_testData[12], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[9],_testData[13], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[10],_testData[14], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[11],_testData[15], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[12],_testData[16], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[13],_testData[17], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[14],_testData[18], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[15],_testData[19], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[16],_testData[20], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[17],_testData[21], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[18],_testData[22], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[19],_testData[23], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[20],_testData[24], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[21],_testData[25], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[22],_testData[26], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[23],_testData[27], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[24],_testData[28], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[25],_testData[29], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[26],_testData[30], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[27],_testData[31], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[28],_testData[32], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[29],_testData[33], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[29], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[1],_testData[30], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[2],_testData[31], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[3],_testData[32], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[4],_testData[33], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[5],_testData[34], false);
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
                var models = ((IByteMArraysmallintMMArrayD3)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BytesmallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IByteMArraysmallintMMArrayD3)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[24], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[1],_testData[25], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[2],_testData[26], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[3],_testData[27], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[4],_testData[28], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[5],_testData[29], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[6],_testData[30], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[7],_testData[31], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[8],_testData[32], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[9],_testData[33], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[24], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[1],_testData[25], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[2],_testData[26], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[3],_testData[27], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[4],_testData[28], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[5],_testData[29], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[6],_testData[30], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[7],_testData[31], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[8],_testData[32], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[9],_testData[33], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytesmallintMMArrayD3E1M), typeof(FlatBytesmallintMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3)),
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
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3)),
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
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3)),
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
FROM public.bytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytesmallintMMArrayD3E1M>();
                var models2 = new List<FlatBytesmallintMMArrayD3E1M>();
                await((IByteMArraysmallintMMArrayD3)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBytesmallintMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bytesmallintmmarrayd3e1m m
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
FROM public.bytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintMMArrayD3E1M>();
                var firstItems2 = new List<FlatBytesmallintMMArrayD3E1M>();
                var secondItems1 = new List<FlatBytesmallintMMArrayD3E1M>();
                var secondItems2 = new List<FlatBytesmallintMMArrayD3E1M>();
                await ((IByteMArraysmallintMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 20, query1, 80, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.bytesmallintmmarrayd3e1m m
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
FROM public.bytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintMMArrayD3E1M>();
                var firstItems2 = new List<FlatBytesmallintMMArrayD3E1M>();
                var secondItems1 = new List<FlatBytesmallintMMArrayD3E1M>();
                await ((IByteMArraysmallintMMArrayD3)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 102, query1, 26, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[27],_testData[34], false);
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
FROM public.bytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytesmallintMMArrayD3E1M>();
                var models2 = new List<FlatBytesmallintMMArrayD3E1M>();
                ((IByteMArraysmallintMMArrayD3)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBytesmallintMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bytesmallintmmarrayd3e1m m
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
FROM public.bytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintMMArrayD3E1M>();
                var firstItems2 = new List<FlatBytesmallintMMArrayD3E1M>();
                var secondItems1 = new List<FlatBytesmallintMMArrayD3E1M>();
                var secondItems2 = new List<FlatBytesmallintMMArrayD3E1M>();
                 ((IByteMArraysmallintMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 151, query1, 88, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.bytesmallintmmarrayd3e1m m
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
FROM public.bytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintMMArrayD3E1M>();
                var firstItems2 = new List<FlatBytesmallintMMArrayD3E1M>();
                var secondItems1 = new List<FlatBytesmallintMMArrayD3E1M>();
                 ((IByteMArraysmallintMMArrayD3)this).DbConnectionMMDynQuerySelectModelBatch(connection, 80, query1, 80, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[14],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytesmallintMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3)),
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
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3)),
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
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3)),
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
FROM public.bytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IByteMArraysmallintMMArrayD3)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bytesmallintmmarrayd3e1m m
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
FROM public.bytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IByteMArraysmallintMMArrayD3)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 26, query1, 37, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[7], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[1],_testData[8], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[2],_testData[9], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[3],_testData[10], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[4],_testData[11], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[5],_testData[12], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[6],_testData[13], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[7],_testData[14], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[8],_testData[15], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[9],_testData[16], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[10],_testData[17], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[11],_testData[18], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[12],_testData[19], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[13],_testData[20], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[14],_testData[21], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[15],_testData[22], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[16],_testData[23], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[17],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[18],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[19],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[20],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[21],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[22],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[23],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[24],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[25],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[26],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[10], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[1],_testData[11], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[2],_testData[12], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[3],_testData[13], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[4],_testData[14], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[5],_testData[15], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[6],_testData[16], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[7],_testData[17], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[8],_testData[18], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[9],_testData[19], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[10],_testData[20], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[11],_testData[21], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[12],_testData[22], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[13],_testData[23], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[14],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[15],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[16],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[17],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[18],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[19],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[20],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[21],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[22],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[23],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[24],_testData[34], false);
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
FROM public.bytesmallintmmarrayd3e1m m
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
FROM public.bytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintMMArrayD3E1M>();
                var secondItems1 = new List<FlatBytesmallintMMArrayD3E1M>();
                var secondItems2 = new List<FlatBytesmallintMMArrayD3E1M>();
                await ((IByteMArraysmallintMMArrayD3)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 128, query1, 17, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.bytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IByteMArraysmallintMMArrayD3)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bytesmallintmmarrayd3e1m m
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
FROM public.bytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IByteMArraysmallintMMArrayD3)this).DbConnectionSTDynQuerySelectModelBatch(connection, 88, query1, 28, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[21], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[1],_testData[22], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[2],_testData[23], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[3],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[4],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[5],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[6],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[7],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[8],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[9],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[10],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[11],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[12],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[9], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[1],_testData[10], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[2],_testData[11], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[3],_testData[12], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[4],_testData[13], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[5],_testData[14], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[6],_testData[15], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[7],_testData[16], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[8],_testData[17], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[9],_testData[18], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[10],_testData[19], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[11],_testData[20], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[12],_testData[21], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[13],_testData[22], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[14],_testData[23], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[15],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[16],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[17],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[18],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[19],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[20],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[21],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[22],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[23],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[24],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(models[25],_testData[34], false);
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
FROM public.bytesmallintmmarrayd3e1m m
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
FROM public.bytesmallintmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintMMArrayD3E1M>();
                var secondItems1 = new List<FlatBytesmallintMMArrayD3E1M>();
                var secondItems2 = new List<FlatBytesmallintMMArrayD3E1M>();
                 ((IByteMArraysmallintMMArrayD3)this).DbConnectionDynQuerySelectModelBatch(connection, 128, query1, 78, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatBytesmallintMMArrayD3E1M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.bytesmallintmmarrayd3e1m m
LEFT JOIN public.bytesmallintmmarrayd3e1mi mi ON mi.id = m.bytesmallintmmarrayd3e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BytesmallintMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3)),
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
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3)),
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
                var models = await((IByteMArraysmallintMMArrayD3)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BytesmallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IByteMArraysmallintMMArrayD3)this).DbConnectionSTSelectModelBatchAsync(connection, 154, 46))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[32], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[1],_testData[33], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[12], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[1],_testData[13], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[2],_testData[14], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[3],_testData[15], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[4],_testData[16], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[5],_testData[17], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[6],_testData[18], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[7],_testData[19], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[8],_testData[20], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[9],_testData[21], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[10],_testData[22], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[11],_testData[23], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[12],_testData[24], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[13],_testData[25], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[14],_testData[26], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[15],_testData[27], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[16],_testData[28], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[17],_testData[29], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[18],_testData[30], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[19],_testData[31], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[20],_testData[32], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[21],_testData[33], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[22],_testData[34], false);
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
                var models = ((IByteMArraysmallintMMArrayD3)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BytesmallintMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IByteMArraysmallintMMArrayD3)this).DbConnectionSTSelectModelBatch(connection, 128, 46))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[28], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[1],_testData[29], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[2],_testData[30], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[3],_testData[31], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[4],_testData[32], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[5],_testData[33], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[12], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[1],_testData[13], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[2],_testData[14], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[3],_testData[15], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[4],_testData[16], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[5],_testData[17], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[6],_testData[18], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[7],_testData[19], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[8],_testData[20], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[9],_testData[21], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[10],_testData[22], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[11],_testData[23], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[12],_testData[24], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[13],_testData[25], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[14],_testData[26], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[15],_testData[27], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[16],_testData[28], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[17],_testData[29], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[18],_testData[30], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[19],_testData[31], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[20],_testData[32], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[21],_testData[33], false);
                        BytesmallintMMArrayD3E1M.AssertModel(models[22],_testData[34], false);
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
                await using var cmd = await ((IByteMArraysmallintMMArrayD3)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IByteMArraysmallintMMArrayD3)this).SetDbConnectionSelectModelParametrs(cmd, 17);
                var models = await ((IByteMArraysmallintMMArrayD3)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(31));

                BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[4], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[1],_testData[5], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[2],_testData[6], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[3],_testData[7], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[4],_testData[8], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[5],_testData[9], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[6],_testData[10], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[7],_testData[11], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[8],_testData[12], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[9],_testData[13], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[10],_testData[14], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[11],_testData[15], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[12],_testData[16], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[13],_testData[17], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[14],_testData[18], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[15],_testData[19], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[16],_testData[20], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[17],_testData[21], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[18],_testData[22], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[19],_testData[23], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[20],_testData[24], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[21],_testData[25], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[22],_testData[26], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[23],_testData[27], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[24],_testData[28], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[25],_testData[29], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[26],_testData[30], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[27],_testData[31], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[28],_testData[32], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[29],_testData[33], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IByteMArraysmallintMMArrayD3)this).CreateDbConnectionSelectModelCommand(connection);
                ((IByteMArraysmallintMMArrayD3)this).SetDbConnectionSelectModelParametrs(cmd, 94);
                var models =  ((IByteMArraysmallintMMArrayD3)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(12));

                BytesmallintMMArrayD3E1M.AssertModel(models[0],_testData[23], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[1],_testData[24], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[2],_testData[25], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[3],_testData[26], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[4],_testData[27], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[5],_testData[28], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[6],_testData[29], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[7],_testData[30], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[8],_testData[31], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[9],_testData[32], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[10],_testData[33], false);
                BytesmallintMMArrayD3E1M.AssertModel(models[11],_testData[34], false);
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
FROM public.binary_bytesmallintmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(BytesmallintMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(BytesmallintMMArrayD3E1MIWA),
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
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BytesmallintMMArrayD3E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BytesmallintMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IByteMArraysmallintMMArrayD3)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bytesmallintmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IByteMArraysmallintMMArrayD3)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BytesmallintMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BytesmallintMMArrayD3E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BytesmallintMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IByteMArraysmallintMMArrayD3)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_bytesmallintmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IByteMArraysmallintMMArrayD3)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BytesmallintMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bytesmallintmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(BytesmallintMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(BytesmallintMMArrayD3E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BytesmallintMMArrayD3E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BytesmallintMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IByteMArraysmallintMMArrayD3)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bytesmallintmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IByteMArraysmallintMMArrayD3)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BytesmallintMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BytesmallintMMArrayD3E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BytesmallintMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IByteMArraysmallintMMArrayD3)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_bytesmallintmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IByteMArraysmallintMMArrayD3)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BytesmallintMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bytesmallintmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(BytesmallintMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bytesmallintmmarrayd3e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(BytesmallintMMArrayD3E1MI),
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
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BytesmallintMMArrayD3E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IByteMArraysmallintMMArrayD3)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IByteMArraysmallintMMArrayD3)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BytesmallintMMArrayD3E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<BytesmallintMMArrayD3E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IByteMArraysmallintMMArrayD3)this).WAImportModelInner(connection, importCollection);
                var models = ((IByteMArraysmallintMMArrayD3)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BytesmallintMMArrayD3E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_bytesmallintmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BytesmallintMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bytesmallintmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BytesmallintMMArrayD3E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BytesmallintMMArrayD3E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BytesmallintMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IByteMArraysmallintMMArrayD3)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IByteMArraysmallintMMArrayD3)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BytesmallintMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BytesmallintMMArrayD3E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BytesmallintMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IByteMArraysmallintMMArrayD3)this).ImportModelInner(connection, importCollection);
                var models = ((IByteMArraysmallintMMArrayD3)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BytesmallintMMArrayD3E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bytesmallintmmarrayd3e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bytesmallintmmarrayd3e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(BytesmallintMMArrayD3E1M),
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
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3))]
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
FROM public.binary_bytesmallintmmarrayd3e1m m
LEFT JOIN public.binary_bytesmallintmmarrayd3e1mi mi ON mi.id = m.bytesmallintmmarrayd3e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BytesmallintMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BytesmallintMMArrayD3E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IByteMArraysmallintMMArrayD3)this).ImportModelAsync(connection, importCollection);
                var models = await ((IByteMArraysmallintMMArrayD3)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BytesmallintMMArrayD3E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<BytesmallintMMArrayD3E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IByteMArraysmallintMMArrayD3)this).ImportModel(connection, importCollection);
                var models = ((IByteMArraysmallintMMArrayD3)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BytesmallintMMArrayD3E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bytesmallintmmarrayd3e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bytesmallintmmarrayd3e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BytesmallintMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3)),
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
                var models =  ((IByteMArraysmallintMMArrayD3)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BytesmallintMMArrayD3E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IByteMArraysmallintMMArrayD3)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BytesmallintMMArrayD3E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(BytesmallintMMArrayD3E1MIWA), typeof(BytesmallintMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3)),
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
                var models1 = new List<BytesmallintMMArrayD3E1MIWA>();
                var models2 = new List<BytesmallintMMArrayD3E1MIWA>();
                await ((IByteMArraysmallintMMArrayD3)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bytesmallintmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BytesmallintMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BytesmallintMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BytesmallintMMArrayD3E1MIWA>();
                var models2 = new List<BytesmallintMMArrayD3E1MIWA>();
                ((IByteMArraysmallintMMArrayD3)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bytesmallintmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BytesmallintMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BytesmallintMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(BytesmallintMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3)),
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
                var models = await ((IByteMArraysmallintMMArrayD3)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_bytesmallintmmarrayd3e1mi
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
                    BytesmallintMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IByteMArraysmallintMMArrayD3)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_bytesmallintmmarrayd3e1mi
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
                    BytesmallintMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(BytesmallintMMArrayD3E1MIWA), typeof(BytesmallintMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3))]
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
                var models1 = new List<BytesmallintMMArrayD3E1MIWA>();
                var models2 = new List<BytesmallintMMArrayD3E1MIWA>();
                await ((IByteMArraysmallintMMArrayD3)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bytesmallintmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BytesmallintMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BytesmallintMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BytesmallintMMArrayD3E1MIWA>();
                var models2 = new List<BytesmallintMMArrayD3E1MIWA>();
                ((IByteMArraysmallintMMArrayD3)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bytesmallintmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BytesmallintMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BytesmallintMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(BytesmallintMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3))]
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
                var models = await ((IByteMArraysmallintMMArrayD3)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_bytesmallintmmarrayd3e1mi
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
                    BytesmallintMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IByteMArraysmallintMMArrayD3)this).DynQueryExportModelInner(connection, @"
COPY public.binary_bytesmallintmmarrayd3e1mi
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
                    BytesmallintMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bytesmallintmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(BytesmallintMMArrayD3E1MI), typeof(BytesmallintMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3)),
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
                var models1 = new List<BytesmallintMMArrayD3E1MI>();
                var models2 = new List<BytesmallintMMArrayD3E1MI>();
                await ((IByteMArraysmallintMMArrayD3)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BytesmallintMMArrayD3E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BytesmallintMMArrayD3E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BytesmallintMMArrayD3E1MI>();
                var models2 = new List<BytesmallintMMArrayD3E1MI>();
                ((IByteMArraysmallintMMArrayD3)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BytesmallintMMArrayD3E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BytesmallintMMArrayD3E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bytesmallintmmarrayd3e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(BytesmallintMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3)),
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
                var models = await ((IByteMArraysmallintMMArrayD3)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BytesmallintMMArrayD3E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IByteMArraysmallintMMArrayD3)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BytesmallintMMArrayD3E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bytesmallintmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(BytesmallintMMArrayD3E1MIWA), typeof(BytesmallintMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3))]
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
                var models1 = new List<BytesmallintMMArrayD3E1MIWA>();
                var models2 = new List<BytesmallintMMArrayD3E1MIWA>();
                await ((IByteMArraysmallintMMArrayD3)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BytesmallintMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BytesmallintMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BytesmallintMMArrayD3E1MIWA>();
                var models2 = new List<BytesmallintMMArrayD3E1MIWA>();
                ((IByteMArraysmallintMMArrayD3)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BytesmallintMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BytesmallintMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bytesmallintmmarrayd3e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BytesmallintMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMMArrayD3))]
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
                var models = await ((IByteMArraysmallintMMArrayD3)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BytesmallintMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IByteMArraysmallintMMArrayD3)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BytesmallintMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

