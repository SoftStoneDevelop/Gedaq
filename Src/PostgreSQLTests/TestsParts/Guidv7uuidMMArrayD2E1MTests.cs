

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
    internal partial interface IGuidv7MArrayuuidMMArrayD2
    {
    }
    
    internal partial class Guidv7MArrayuuidMMArrayD2 : IGuidv7MArrayuuidMMArrayD2
    {


#region TestData

        private readonly Guidv7uuidMMArrayD2E1M[] _testData = new Guidv7uuidMMArrayD2E1M[]
        {
            new Guidv7uuidMMArrayD2E1M
{
    Id = 2,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7afd-b5c7-6716f363f298"), Guid.Parse("01a17ef0-3a25-73d7-8ed3-8771a78ff557"), }, { Guid.Parse("01a17ef0-3a25-7a41-8a28-31741921b32b"), Guid.Parse("01a17ef0-3a25-787d-adcf-927146184fc5"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7a5c-a61a-d47f8f36bcd9"), Guid.Parse("01a17ef0-3a25-714d-8fe7-d99e3a0a6600"), }, { Guid.Parse("01a17ef0-3a25-7f42-b269-d52cbc4506a9"), Guid.Parse("01a17ef0-3a25-715f-9afe-0b5a8f77ae67"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 7,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7a94-8f93-6277f07cb20b"), Guid.Parse("01a17ef0-3a25-7a68-8a5a-1f3cee905c8c"), }, { Guid.Parse("01a17ef0-3a25-7596-b447-69b4928e5855"), Guid.Parse("01a17ef0-3a25-703f-97b3-2f60d58fff69"), }, },
    ModelInner = new Guidv7uuidMMArrayD2E1MI
{
    Id = 2,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7b83-9547-7ef45058979f"), Guid.Parse("01a17ef0-3a25-7db7-b49e-52564739fbcb"), }, { Guid.Parse("01a17ef0-3a25-738c-95bd-e92184214142"), Guid.Parse("01a17ef0-3a25-7328-8367-953df2ab7320"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7f07-946b-4faa8ade7ed1"), Guid.Parse("01a17ef0-3a25-7880-adc1-5968a26f161b"), }, { Guid.Parse("01a17ef0-3a25-7ec2-858e-42a9dde4fd2a"), Guid.Parse("01a17ef0-3a25-7ae5-964b-cc4804c77263"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 14,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-74af-825b-6aa1c06e4835"), Guid.Parse("01a17ef0-3a25-7894-923c-15731cedc1f7"), }, { Guid.Parse("01a17ef0-3a25-7f5f-83fc-00ca555bc21e"), Guid.Parse("01a17ef0-3a25-7c08-bdd3-939ae696081e"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-77b7-948e-8f15d6fe94f7"), Guid.Parse("01a17ef0-3a25-7574-85f5-153d43768eeb"), }, { Guid.Parse("01a17ef0-3a25-78a4-a0bc-57691a8c16aa"), Guid.Parse("01a17ef0-3a25-7003-8518-0311e7f0e746"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 19,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-79e0-830a-bff4264c7758"), Guid.Parse("01a17ef0-3a25-7261-9d7e-4eebeeec8f01"), }, { Guid.Parse("01a17ef0-3a25-7475-83b9-c833fec851a5"), Guid.Parse("01a17ef0-3a25-77aa-b26b-223c3fb513e2"), }, },
    ModelInner = new Guidv7uuidMMArrayD2E1MI
{
    Id = 3,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-769c-90ee-5cf0d0eb26b8"), Guid.Parse("01a17ef0-3a25-78f6-b87e-50baa9e3fade"), }, { Guid.Parse("01a17ef0-3a25-78c7-8cb0-b33985072471"), Guid.Parse("01a17ef0-3a25-71c7-b206-ff29e159532b"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 24,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7716-a68b-cdfa5a6ce954"), Guid.Parse("01a17ef0-3a25-7b7d-82a2-2be68c7360fd"), }, { Guid.Parse("01a17ef0-3a25-7b35-bd85-3deb65349fcd"), Guid.Parse("01a17ef0-3a25-7f3c-86f8-e6432433503f"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7f65-8b42-a6b998f08722"), Guid.Parse("01a17ef0-3a25-7e5f-ab7d-739dea7e1a77"), }, { Guid.Parse("01a17ef0-3a25-7047-abc0-100258d56803"), Guid.Parse("01a17ef0-3a25-7258-9d35-1bf0fd7fb18e"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 33,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-751d-ac63-e814d349a936"), Guid.Parse("01a17ef0-3a25-7a63-8d2e-08f68da45ee9"), }, { Guid.Parse("01a17ef0-3a25-7a61-9506-b4dcb1c1c99d"), Guid.Parse("01a17ef0-3a25-7cef-b3e5-3846582b3e14"), }, },
    ModelInner = new Guidv7uuidMMArrayD2E1MI
{
    Id = 10,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7d89-8a19-9f22b50c9a27"), Guid.Parse("01a17ef0-3a25-7e8a-baa1-d70480abe608"), }, { Guid.Parse("01a17ef0-3a25-7e22-8aa0-2a83b1ff2132"), Guid.Parse("01a17ef0-3a25-7452-bbc1-6da3fda2fa7e"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7e77-8ffd-6ef2d985554c"), Guid.Parse("01a17ef0-3a25-7df1-9226-5d00656cb7c4"), }, { Guid.Parse("01a17ef0-3a25-7a1c-8b98-9665a8408081"), Guid.Parse("01a17ef0-3a25-7b23-b07d-29a21755974c"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 35,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7499-93e2-aff7bf402e79"), Guid.Parse("01a17ef0-3a25-7c09-9b0d-0ae6355f1284"), }, { Guid.Parse("01a17ef0-3a25-78ed-a56d-88d21616d32c"), Guid.Parse("01a17ef0-3a25-7d70-a321-2a48e02476fb"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7d39-a3a6-78659caebc9b"), Guid.Parse("01a17ef0-3a25-79ce-bbe1-bc70baec266c"), }, { Guid.Parse("01a17ef0-3a25-7177-aa02-60dcf85a55ac"), Guid.Parse("01a17ef0-3a25-78fa-94a9-c62d6dc8fb3b"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 41,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-72e3-9e22-680476b4c54d"), Guid.Parse("01a17ef0-3a25-7cb5-9af9-237d908be49e"), }, { Guid.Parse("01a17ef0-3a25-7e6a-9794-4455ab8158af"), Guid.Parse("01a17ef0-3a25-762d-9a8e-684a38466b98"), }, },
    ModelInner = new Guidv7uuidMMArrayD2E1MI
{
    Id = 12,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7c2d-baf0-777f06e1a91d"), Guid.Parse("01a17ef0-3a25-73cc-8aca-a734089fa03a"), }, { Guid.Parse("01a17ef0-3a25-709a-91c4-1d1ce7b5a392"), Guid.Parse("01a17ef0-3a25-76e6-a0bf-de4518777949"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7485-b5d1-192f98914b4f"), Guid.Parse("01a17ef0-3a25-765d-8a78-9abb7d8173bb"), }, { Guid.Parse("01a17ef0-3a25-7f7d-8d70-bc87edf77079"), Guid.Parse("01a17ef0-3a25-7933-9e88-c810aefc1ac2"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 46,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-72d3-ad2e-97aaa9baee8a"), Guid.Parse("01a17ef0-3a25-7e83-92b9-c690cd98ac00"), }, { Guid.Parse("01a17ef0-3a25-72b3-a324-fdcf7216a44d"), Guid.Parse("01a17ef0-3a25-7fc4-9bc9-b749a42e66ed"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-76c5-97af-6615d69ce3f6"), Guid.Parse("01a17ef0-3a25-7ba4-87f6-af5c70cdb5d1"), }, { Guid.Parse("01a17ef0-3a25-7e7d-8cc1-b1d47a20aaf8"), Guid.Parse("01a17ef0-3a25-711e-bddb-d4bef3a9bf41"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 54,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7be9-a166-ca18cb910786"), Guid.Parse("01a17ef0-3a25-7620-b11f-320e743d040e"), }, { Guid.Parse("01a17ef0-3a25-78ec-a676-c3d59ec14265"), Guid.Parse("01a17ef0-3a25-782c-a336-f80820aaee8d"), }, },
    ModelInner = new Guidv7uuidMMArrayD2E1MI
{
    Id = 20,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-78b7-a3fa-fbbc3b91f3a5"), Guid.Parse("01a17ef0-3a25-7d25-9c6d-c87d14ca5a13"), }, { Guid.Parse("01a17ef0-3a25-73ec-9c7d-088c8b5f6748"), Guid.Parse("01a17ef0-3a25-7ad5-b210-92f4a21e02c5"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7907-96de-1dd4ad8af0ef"), Guid.Parse("01a17ef0-3a25-7f2a-9ccc-cee1b56f2583"), }, { Guid.Parse("01a17ef0-3a25-779e-abbb-079011806ffd"), Guid.Parse("01a17ef0-3a25-785b-9d82-d87229d77dda"), }, },
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 58,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-722a-b6fd-d8831c9ce4f6"), Guid.Parse("01a17ef0-3a25-7ae7-8c00-5fe36cbd816d"), }, { Guid.Parse("01a17ef0-3a25-7059-8ec4-281e488499c1"), Guid.Parse("01a17ef0-3a25-7462-815b-d84b46b341cd"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-79ab-8c75-6cac022c9990"), Guid.Parse("01a17ef0-3a25-7eab-9ed5-bf93d92346ac"), }, { Guid.Parse("01a17ef0-3a25-769b-8a57-ef08b30c97fd"), Guid.Parse("01a17ef0-3a25-7ac5-aa22-938e252b34ac"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 62,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7a14-a455-407c95fef440"), Guid.Parse("01a17ef0-3a25-71e6-8a8c-6cb2ae3a5d17"), }, { Guid.Parse("01a17ef0-3a25-7ca2-be89-025797159c0c"), Guid.Parse("01a17ef0-3a25-7be5-b3dd-8723c2a423ca"), }, },
    ModelInner = new Guidv7uuidMMArrayD2E1MI
{
    Id = 25,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7cd3-a75d-5228b99106ab"), Guid.Parse("01a17ef0-3a25-7d19-9b4e-196f92fca8ba"), }, { Guid.Parse("01a17ef0-3a25-7265-acb6-89bd8663d8af"), Guid.Parse("01a17ef0-3a25-7a46-ab05-9be66a59a428"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-70d7-918c-7ce53606fcd9"), Guid.Parse("01a17ef0-3a25-7f0d-8e19-3fee5f616f72"), }, { Guid.Parse("01a17ef0-3a25-76df-b700-619658e5aba7"), Guid.Parse("01a17ef0-3a25-711b-bd1f-969ff8f2f44a"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 71,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7832-b0b4-d7e5165b0d18"), Guid.Parse("01a17ef0-3a25-7b25-a235-fe3894385968"), }, { Guid.Parse("01a17ef0-3a25-7293-bd4b-d95f7adf33cb"), Guid.Parse("01a17ef0-3a25-7dd4-8bba-2c416b75497e"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 76,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7c01-9d54-376d00053c51"), Guid.Parse("01a17ef0-3a25-7c1b-a6d8-424e0d230eb3"), }, { Guid.Parse("01a17ef0-3a25-7a1f-b515-daf28875490e"), Guid.Parse("01a17ef0-3a25-7727-a2d0-8dd4467e5d0b"), }, },
    ModelInner = new Guidv7uuidMMArrayD2E1MI
{
    Id = 30,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7c5c-b633-e17670d1f06f"), Guid.Parse("01a17ef0-3a25-712f-a876-03d77d9d69bd"), }, { Guid.Parse("01a17ef0-3a25-7eaa-a966-2a3db52e6558"), Guid.Parse("01a17ef0-3a25-748e-9702-62d7c5b855f9"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 84,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-78da-94ae-c85dd0b4789e"), Guid.Parse("01a17ef0-3a25-71c5-9df5-67d92c348231"), }, { Guid.Parse("01a17ef0-3a25-7d61-a067-12e83b04377e"), Guid.Parse("01a17ef0-3a25-7273-aff2-a6938f32de82"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 91,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-79da-8caf-c442da3a7b1b"), Guid.Parse("01a17ef0-3a25-7d7d-bfda-ade4c3123d43"), }, { Guid.Parse("01a17ef0-3a25-7f82-8c19-7d16957a2dc6"), Guid.Parse("01a17ef0-3a25-7c10-821b-c428e98cd6ef"), }, },
    ModelInner = new Guidv7uuidMMArrayD2E1MI
{
    Id = 39,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7ef2-bde9-0e0b5705206e"), Guid.Parse("01a17ef0-3a25-7515-9687-87b1c0d44f23"), }, { Guid.Parse("01a17ef0-3a25-78a8-8ee9-d92465e34611"), Guid.Parse("01a17ef0-3a25-7d44-b0b6-87afee491fe5"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 97,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7417-8a98-c86a4ddb3087"), Guid.Parse("01a17ef0-3a25-74e2-8327-d90669814772"), }, { Guid.Parse("01a17ef0-3a25-77df-9d4d-6a48e712ac5a"), Guid.Parse("01a17ef0-3a25-76d0-a65b-74a35511b29d"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-77cf-933d-b7a0efc25016"), Guid.Parse("01a17ef0-3a25-70b6-bfe6-eebdabdc8d17"), }, { Guid.Parse("01a17ef0-3a25-7cb2-9018-2bb2a673004b"), Guid.Parse("01a17ef0-3a25-728b-8ac7-28d2b467158d"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 104,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-72d6-b430-86abc1c6df3f"), Guid.Parse("01a17ef0-3a25-77d3-98d7-5cd48bbfe5e3"), }, { Guid.Parse("01a17ef0-3a25-7f7d-956a-0740c7759ef7"), Guid.Parse("01a17ef0-3a25-7ccf-9a72-ae67c7edd05f"), }, },
    ModelInner = new Guidv7uuidMMArrayD2E1MI
{
    Id = 48,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-75c9-900e-1c411a27c09e"), Guid.Parse("01a17ef0-3a25-74b2-841f-dbebcd6bd138"), }, { Guid.Parse("01a17ef0-3a25-72ab-8290-70358877e88a"), Guid.Parse("01a17ef0-3a25-783b-8970-a0aed6e41554"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 110,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-76b4-bc20-6a5e8d32d04e"), Guid.Parse("01a17ef0-3a25-78e0-8387-adfc8298ecd3"), }, { Guid.Parse("01a17ef0-3a25-7ebf-accf-7226b0db8571"), Guid.Parse("01a17ef0-3a25-7a04-b94f-4d53d8b4d08d"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 118,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-77ba-b9a0-b2439ed09c3e"), Guid.Parse("01a17ef0-3a25-7f76-9d5b-a39e8a7ebcd6"), }, { Guid.Parse("01a17ef0-3a25-7dd2-a9e6-2c30142bd526"), Guid.Parse("01a17ef0-3a25-7b58-9204-c36c2f16228d"), }, },
    ModelInner = new Guidv7uuidMMArrayD2E1MI
{
    Id = 50,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7a06-96ff-89ca79446a19"), Guid.Parse("01a17ef0-3a25-7501-86a2-b9a281a4faf8"), }, { Guid.Parse("01a17ef0-3a25-74cf-874a-507f2b6425d9"), Guid.Parse("01a17ef0-3a25-76d3-a06c-503855ad6981"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 126,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7840-8574-079a71117ea9"), Guid.Parse("01a17ef0-3a25-7695-8a47-239a6caa076e"), }, { Guid.Parse("01a17ef0-3a25-71d0-8c5f-511caaaf28ec"), Guid.Parse("01a17ef0-3a25-7394-b97f-b3cec1f9c7f4"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7b3f-9cb2-d7fb72bb3c51"), Guid.Parse("01a17ef0-3a25-7b37-88c9-867b92040bd8"), }, { Guid.Parse("01a17ef0-3a25-7b0e-ab41-0b07dcb7f14c"), Guid.Parse("01a17ef0-3a25-7dd2-90f0-d1a0ef320ec9"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 130,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7432-85ca-f0d754917a07"), Guid.Parse("01a17ef0-3a25-7091-a6dd-22abcdaba20f"), }, { Guid.Parse("01a17ef0-3a25-770d-85ae-51ab7e2ce8af"), Guid.Parse("01a17ef0-3a25-754e-9cc8-1907dadbc630"), }, },
    ModelInner = new Guidv7uuidMMArrayD2E1MI
{
    Id = 57,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-774a-81ed-2c99818cde19"), Guid.Parse("01a17ef0-3a25-764b-841a-c8651870b574"), }, { Guid.Parse("01a17ef0-3a25-7ce7-822f-92938aed4c4c"), Guid.Parse("01a17ef0-3a25-71d5-8b9b-f63208813907"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 137,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7c82-b902-f7e0d6337ed0"), Guid.Parse("01a17ef0-3a25-7f8d-90d9-946780c61349"), }, { Guid.Parse("01a17ef0-3a25-7dfd-bd0f-59ceedc72215"), Guid.Parse("01a17ef0-3a25-70a0-8f86-98931b4267f4"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 140,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7c6b-a413-ee57d891ca4e"), Guid.Parse("01a17ef0-3a25-7eb9-9485-87ad82774b2d"), }, { Guid.Parse("01a17ef0-3a25-70f5-b1f9-8e32833fae36"), Guid.Parse("01a17ef0-3a25-7e6b-9a2d-3dd00f1a9120"), }, },
    ModelInner = new Guidv7uuidMMArrayD2E1MI
{
    Id = 59,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-77fb-b0a2-26b45b5bcc72"), Guid.Parse("01a17ef0-3a25-74c8-9f21-2a3bcfc27b77"), }, { Guid.Parse("01a17ef0-3a25-797d-9eab-d1747985e763"), Guid.Parse("01a17ef0-3a25-7fcc-9e2c-3ad6d6436e01"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7f47-a351-202df4993555"), Guid.Parse("01a17ef0-3a25-7d09-8d18-a04490565fa7"), }, { Guid.Parse("01a17ef0-3a25-715a-b747-bf1bd57eae19"), Guid.Parse("01a17ef0-3a25-70aa-b39f-790fbba2349a"), }, },
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 146,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7a28-b4dd-24429f78446d"), Guid.Parse("01a17ef0-3a25-7f10-92dc-56e0fc3e2ddf"), }, { Guid.Parse("01a17ef0-3a25-7b90-99ee-7582640a344f"), Guid.Parse("01a17ef0-3a25-7fb5-965f-f989cf503d68"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 150,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7f64-9d9b-580f036edc66"), Guid.Parse("01a17ef0-3a25-7630-8e5a-b4cf473d8524"), }, { Guid.Parse("01a17ef0-3a25-7de1-a1e7-d3943b804bbb"), Guid.Parse("01a17ef0-3a25-7149-80b4-88ddc371ddce"), }, },
    ModelInner = new Guidv7uuidMMArrayD2E1MI
{
    Id = 67,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-76a3-a2c6-d0c52fbea1eb"), Guid.Parse("01a17ef0-3a25-7b35-a4c8-2aa6f8692b2e"), }, { Guid.Parse("01a17ef0-3a25-79b0-bf42-0e6e12c9963e"), Guid.Parse("01a17ef0-3a25-7538-9714-61d249de8f65"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-71db-8c18-50fd321973f6"), Guid.Parse("01a17ef0-3a25-75ce-9e4a-5c21b517d973"), }, { Guid.Parse("01a17ef0-3a25-71e7-bb2a-1d1f52c55379"), Guid.Parse("01a17ef0-3a25-719d-9655-edbf4a5363e6"), }, },
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 158,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-793e-803d-bd2037aef9b0"), Guid.Parse("01a17ef0-3a25-717b-be2c-18161aece76a"), }, { Guid.Parse("01a17ef0-3a25-7ffb-8711-72bb0ad22998"), Guid.Parse("01a17ef0-3a25-747b-bf63-6fe5652c3fa0"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 167,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-715f-be68-c74e0c5ca7d3"), Guid.Parse("01a17ef0-3a25-7d25-8243-69769e1efffc"), }, { Guid.Parse("01a17ef0-3a25-749b-8e69-da037d3f2f95"), Guid.Parse("01a17ef0-3a25-7f37-b220-ff47f4229e56"), }, },
    ModelInner = new Guidv7uuidMMArrayD2E1MI
{
    Id = 68,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7867-8234-f165ce8f1876"), Guid.Parse("01a17ef0-3a25-768e-b085-3a5faf0473bd"), }, { Guid.Parse("01a17ef0-3a25-7fe7-a4a6-c023725fea43"), Guid.Parse("01a17ef0-3a25-7cf0-b7ee-8df4c651227a"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7c56-9751-46997db1ba8a"), Guid.Parse("01a17ef0-3a25-746b-b5cf-c6aa90a20e9d"), }, { Guid.Parse("01a17ef0-3a25-7af9-a4d6-e10b6db9dd8d"), Guid.Parse("01a17ef0-3a25-7712-8961-b42bce2827a4"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 168,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7cb4-8f13-fc294e18264a"), Guid.Parse("01a17ef0-3a25-718e-8f97-b957a97203ff"), }, { Guid.Parse("01a17ef0-3a25-70ef-b476-1c7e3d6c1195"), Guid.Parse("01a17ef0-3a25-7b5b-a2c4-b84c8fa168ff"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-795e-b7fe-7b2a9d227480"), Guid.Parse("01a17ef0-3a25-7b0b-9e8b-07424c2266af"), }, { Guid.Parse("01a17ef0-3a25-7cd0-9366-ad6b1a594f68"), Guid.Parse("01a17ef0-3a25-7f34-9bba-475720b59e53"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 172,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-799f-9d32-224c236d408f"), Guid.Parse("01a17ef0-3a25-7276-b6cb-805fb4e058d0"), }, { Guid.Parse("01a17ef0-3a25-7b04-99d5-f570ee3bb519"), Guid.Parse("01a17ef0-3a25-7ab1-a8a9-f2be8848d21f"), }, },
    ModelInner = new Guidv7uuidMMArrayD2E1MI
{
    Id = 71,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-73e1-9e14-ef64cce8bb92"), Guid.Parse("01a17ef0-3a25-78b7-b44a-40bfca2629a4"), }, { Guid.Parse("01a17ef0-3a25-73cc-a43d-42bc88373d9f"), Guid.Parse("01a17ef0-3a25-7cb7-b7a7-33d781945001"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 175,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7b18-8bea-df4963ebbc2e"), Guid.Parse("01a17ef0-3a25-7e21-b614-3d03f324ae0a"), }, { Guid.Parse("01a17ef0-3a25-79d7-877c-d5bb029549b4"), Guid.Parse("01a17ef0-3a25-7756-a801-2a65426848fa"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 184,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7a12-9202-10354447a3da"), Guid.Parse("01a17ef0-3a25-76c1-a000-269cccd30cdb"), }, { Guid.Parse("01a17ef0-3a25-7e8b-8ded-4873db5b501f"), Guid.Parse("01a17ef0-3a25-7d5d-b9f6-ce8ecf288991"), }, },
    ModelInner = new Guidv7uuidMMArrayD2E1MI
{
    Id = 75,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-75ff-9eec-8d998bb27528"), Guid.Parse("01a17ef0-3a25-7810-90d7-8df2d8c617b9"), }, { Guid.Parse("01a17ef0-3a25-7503-bc98-7ea0d5a5c049"), Guid.Parse("01a17ef0-3a25-7173-96cb-d4909ffb55a5"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 187,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7461-a0ad-2e42221bbcb0"), Guid.Parse("01a17ef0-3a25-7964-aeef-f33384fac5c4"), }, { Guid.Parse("01a17ef0-3a25-7bf3-939e-319651f80b3b"), Guid.Parse("01a17ef0-3a25-7f66-b1ac-fc28a59fd5d8"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a26-7cf6-8b1a-5bdbd43a81d8"), Guid.Parse("01a17ef0-3a26-7b02-8d95-afb418e33bec"), }, { Guid.Parse("01a17ef0-3a26-7514-bf66-58150e6f5540"), Guid.Parse("01a17ef0-3a26-75cb-bbcc-01fc2c111a60"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 192,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a26-7f4f-861c-5b9753039062"), Guid.Parse("01a17ef0-3a26-70b5-b3ab-43934ee5904d"), }, { Guid.Parse("01a17ef0-3a26-7fea-8601-27242ca40f03"), Guid.Parse("01a17ef0-3a26-763a-8c7e-e1a163e1e592"), }, },
    ModelInner = new Guidv7uuidMMArrayD2E1MI
{
    Id = 78,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a26-7e79-be87-2efa5b04c89d"), Guid.Parse("01a17ef0-3a26-7c41-9ca2-b2ead1526795"), }, { Guid.Parse("01a17ef0-3a26-76e2-912d-f1d483b7282d"), Guid.Parse("01a17ef0-3a26-73e2-81b6-5812bde74f1e"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a26-7a47-92cd-b5250718ed7a"), Guid.Parse("01a17ef0-3a26-7651-9fc7-fd556d3131c0"), }, { Guid.Parse("01a17ef0-3a26-7eb0-9adf-876a7ef76210"), Guid.Parse("01a17ef0-3a26-7363-bab2-6e01d3e2e13e"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a26-74d7-8d08-3b8574ab3674"), Guid.Parse("01a17ef0-3a26-7b93-a720-c51c6949293a"), }, { Guid.Parse("01a17ef0-3a26-7959-8327-03adc0550c1e"), Guid.Parse("01a17ef0-3a26-71ff-b7b6-7b569d977f04"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 196,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a26-7152-b103-6ce740b490d5"), Guid.Parse("01a17ef0-3a26-7dda-9a27-4a8fe633221c"), }, { Guid.Parse("01a17ef0-3a26-7012-9d61-042c120d0e35"), Guid.Parse("01a17ef0-3a26-7807-a510-3805786a336a"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-3a26-773b-bec6-2b05ac5d2667"), Guid.Parse("01a17ef0-3a26-7a67-b2b5-2e7ed770d4b6"), }, { Guid.Parse("01a17ef0-3a26-7ac1-aec3-368be9d1d0f1"), Guid.Parse("01a17ef0-3a26-746a-8120-303285689a08"), }, },
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guidv7uuidmmarrayd2e1mi(
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guidv7uuidmmarrayd2e1mi(
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
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621))]
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

                changedRows =  ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guidv7uuidmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    guidv7uuidmmarrayd2e1mi_id
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guidv7uuidmmarrayd2e1mi_id", 
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
                changedRows =  ((IGuidv7MArrayuuidMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IGuidv7MArrayuuidMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guidv7uuidmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    guidv7uuidmmarrayd2e1mi_id
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
    guidv7uuidmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
                System.Guid[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[,]>();
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
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

                    nullable =  ((IGuidv7MArrayuuidMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7f65-8b42-a6b998f08722"), Guid.Parse("01a17ef0-3a25-7e5f-ab7d-739dea7e1a77"), }, { Guid.Parse("01a17ef0-3a25-7047-abc0-100258d56803"), Guid.Parse("01a17ef0-3a25-7258-9d35-1bf0fd7fb18e"), }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[,]>();
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
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

                    nullable =  ((IGuidv7MArrayuuidMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7e77-8ffd-6ef2d985554c"), Guid.Parse("01a17ef0-3a25-7df1-9226-5d00656cb7c4"), }, { Guid.Parse("01a17ef0-3a25-7a1c-8b98-9665a8408081"), Guid.Parse("01a17ef0-3a25-7b23-b07d-29a21755974c"), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Guid[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[,]>();
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
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

                    nullable = await ((IGuidv7MArrayuuidMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7d39-a3a6-78659caebc9b"), Guid.Parse("01a17ef0-3a25-79ce-bbe1-bc70baec266c"), }, { Guid.Parse("01a17ef0-3a25-7177-aa02-60dcf85a55ac"), Guid.Parse("01a17ef0-3a25-78fa-94a9-c62d6dc8fb3b"), }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[,]>();
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
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

                    nullable = await ((IGuidv7MArrayuuidMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-7485-b5d1-192f98914b4f"), Guid.Parse("01a17ef0-3a25-765d-8a78-9abb7d8173bb"), }, { Guid.Parse("01a17ef0-3a25-7f7d-8d70-bc87edf77079"), Guid.Parse("01a17ef0-3a25-7933-9e88-c810aefc1ac2"), }, }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guidv7uuidmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    guidv7uuidmmarrayd2e1mi_id
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
    guidv7uuidmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guidv7uuidmmarrayd2e1mi_id", 
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
                System.Guid[,] nullable = null;
                nullable =  ((IGuidv7MArrayuuidMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-76c5-97af-6615d69ce3f6"), Guid.Parse("01a17ef0-3a25-7ba4-87f6-af5c70cdb5d1"), }, { Guid.Parse("01a17ef0-3a25-7e7d-8cc1-b1d47a20aaf8"), Guid.Parse("01a17ef0-3a25-711e-bddb-d4bef3a9bf41"), }, }));
                nullable =  ((IGuidv7MArrayuuidMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Guid[,] nullable = null;
                nullable = await ((IGuidv7MArrayuuidMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-79ab-8c75-6cac022c9990"), Guid.Parse("01a17ef0-3a25-7eab-9ed5-bf93d92346ac"), }, { Guid.Parse("01a17ef0-3a25-769b-8a57-ef08b30c97fd"), Guid.Parse("01a17ef0-3a25-7ac5-aa22-938e252b34ac"), }, }));
                nullable = await ((IGuidv7MArrayuuidMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { { Guid.Parse("01a17ef0-3a25-70d7-918c-7ce53606fcd9"), Guid.Parse("01a17ef0-3a25-7f0d-8e19-3fee5f616f72"), }, { Guid.Parse("01a17ef0-3a25-76df-b700-619658e5aba7"), Guid.Parse("01a17ef0-3a25-711b-bd1f-969ff8f2f44a"), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Guidv7uuidMMArrayD2E1M> models = null;

                models =  ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Guidv7uuidMMArrayD2E1M> models = null;

                models = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IGuidv7MArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuidv7uuidMMArrayD2E1M), typeof(FlatGuidv7uuidMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var models2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                await ((IGuidv7MArrayuuidMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var models2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                ((IGuidv7MArrayuuidMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuidv7uuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IGuidv7MArrayuuidMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidv7MArrayuuidMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
LEFT JOIN public.guidv7uuidmmarrayd2e1mi mi ON mi.id = m.guidv7uuidmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
                var models = await ((IGuidv7MArrayuuidMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IGuidv7MArrayuuidMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuidv7uuidMMArrayD2E1M), typeof(FlatGuidv7uuidMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var models2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                await ((IGuidv7MArrayuuidMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var models2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                ((IGuidv7MArrayuuidMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuidv7uuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidv7MArrayuuidMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidv7MArrayuuidMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
LEFT JOIN public.guidv7uuidmmarrayd2e1mi mi ON mi.id = m.guidv7uuidmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
                var models = await ((IGuidv7MArrayuuidMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IGuidv7MArrayuuidMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuidv7uuidMMArrayD2E1M), typeof(FlatGuidv7uuidMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var models2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                await((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 187;
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
FROM public.guidv7uuidmmarrayd2e1m m
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                await ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
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
FROM public.guidv7uuidmmarrayd2e1m m
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                await ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[34], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var models2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 58;
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
FROM public.guidv7uuidmmarrayd2e1m m
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                 ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 150;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
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
FROM public.guidv7uuidmmarrayd2e1m m
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                 ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuidv7uuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 137;
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
FROM public.guidv7uuidmmarrayd2e1m m
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidmmarrayd2e1m m
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                await ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidmmarrayd2e1m m
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidmmarrayd2e1m m
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                 ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
LEFT JOIN public.guidv7uuidmmarrayd2e1mi mi ON mi.id = m.guidv7uuidmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
                var models = await((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 158;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[30],_testData[34], false);
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
                var models = ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 187;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuidv7uuidMMArrayD2E1M), typeof(FlatGuidv7uuidMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var models2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                await((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                await ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 19, query1, 150, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                await ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 118, query1, 137, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[34], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var models2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                 ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 14, query1, 175, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                 ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 84, query1, 58, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuidv7uuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 76, query1, 150, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[34], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                await ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 104, query1, 175, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 91, query1, 62, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
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
FROM public.guidv7uuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuidv7uuidMMArrayD2E1M>();
                 ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 58, query1, 7, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.guidv7uuidmmarrayd2e1m m
LEFT JOIN public.guidv7uuidmmarrayd2e1mi mi ON mi.id = m.guidv7uuidmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
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
                var models = await((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 24, 130))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
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
                var models = ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidv7MArrayuuidMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 150, 2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[33],_testData[34], false);
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
                await using var cmd = await ((IGuidv7MArrayuuidMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidv7MArrayuuidMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 118);
                var models = await ((IGuidv7MArrayuuidMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(15));

                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[20], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[21], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[22], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[23], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[24], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[25], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[26], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[27], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[28], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[9],_testData[29], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[10],_testData[30], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[11],_testData[31], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[12],_testData[32], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[13],_testData[33], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidv7MArrayuuidMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidv7MArrayuuidMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 24);
                var models =  ((IGuidv7MArrayuuidMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(30));

                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[29],_testData[34], false);
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
FROM public.binary_guidv7uuidmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Guidv7uuidMMArrayD2E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Guidv7uuidMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guidv7uuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidv7MArrayuuidMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guidv7uuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidv7MArrayuuidMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Guidv7uuidMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guidv7uuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidv7MArrayuuidMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_guidv7uuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidv7MArrayuuidMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guidv7uuidmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Guidv7uuidMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Guidv7uuidMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guidv7uuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidv7MArrayuuidMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guidv7uuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidv7MArrayuuidMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Guidv7uuidMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guidv7uuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidv7MArrayuuidMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guidv7uuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidv7MArrayuuidMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guidv7uuidmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guidv7uuidmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Guidv7uuidMMArrayD2E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Guidv7uuidMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidv7MArrayuuidMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidv7MArrayuuidMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Guidv7uuidMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidv7MArrayuuidMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((IGuidv7MArrayuuidMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_guidv7uuidmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guidv7uuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Guidv7uuidMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Guidv7uuidMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guidv7uuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidv7MArrayuuidMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidv7MArrayuuidMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Guidv7uuidMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guidv7uuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidv7MArrayuuidMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidv7MArrayuuidMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guidv7uuidmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
guidv7uuidmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Guidv7uuidMMArrayD2E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2))]
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
FROM public.binary_guidv7uuidmmarrayd2e1m m
LEFT JOIN public.binary_guidv7uuidmmarrayd2e1mi mi ON mi.id = m.guidv7uuidmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Guidv7uuidMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IGuidv7MArrayuuidMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((IGuidv7MArrayuuidMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Guidv7uuidMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Guidv7uuidMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IGuidv7MArrayuuidMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((IGuidv7MArrayuuidMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Guidv7uuidMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guidv7uuidmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    guidv7uuidmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
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
                var models =  ((IGuidv7MArrayuuidMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Guidv7uuidMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidv7MArrayuuidMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Guidv7uuidMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1MIWA), typeof(Guidv7uuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
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
                var models1 = new List<Guidv7uuidMMArrayD2E1MIWA>();
                var models2 = new List<Guidv7uuidMMArrayD2E1MIWA>();
                await ((IGuidv7MArrayuuidMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guidv7uuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Guidv7uuidMMArrayD2E1MIWA>();
                var models2 = new List<Guidv7uuidMMArrayD2E1MIWA>();
                ((IGuidv7MArrayuuidMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guidv7uuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
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
                var models = await ((IGuidv7MArrayuuidMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_guidv7uuidmmarrayd2e1mi
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
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidv7MArrayuuidMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_guidv7uuidmmarrayd2e1mi
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
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1MIWA), typeof(Guidv7uuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2))]
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
                var models1 = new List<Guidv7uuidMMArrayD2E1MIWA>();
                var models2 = new List<Guidv7uuidMMArrayD2E1MIWA>();
                await ((IGuidv7MArrayuuidMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guidv7uuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Guidv7uuidMMArrayD2E1MIWA>();
                var models2 = new List<Guidv7uuidMMArrayD2E1MIWA>();
                ((IGuidv7MArrayuuidMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guidv7uuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2))]
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
                var models = await ((IGuidv7MArrayuuidMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_guidv7uuidmmarrayd2e1mi
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
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidv7MArrayuuidMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_guidv7uuidmmarrayd2e1mi
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
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guidv7uuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1MI), typeof(Guidv7uuidMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
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
                var models1 = new List<Guidv7uuidMMArrayD2E1MI>();
                var models2 = new List<Guidv7uuidMMArrayD2E1MI>();
                await ((IGuidv7MArrayuuidMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Guidv7uuidMMArrayD2E1MI>();
                var models2 = new List<Guidv7uuidMMArrayD2E1MI>();
                ((IGuidv7MArrayuuidMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guidv7uuidmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
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
                var models = await ((IGuidv7MArrayuuidMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidv7MArrayuuidMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guidv7uuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1MIWA), typeof(Guidv7uuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2))]
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
                var models1 = new List<Guidv7uuidMMArrayD2E1MIWA>();
                var models2 = new List<Guidv7uuidMMArrayD2E1MIWA>();
                await ((IGuidv7MArrayuuidMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Guidv7uuidMMArrayD2E1MIWA>();
                var models2 = new List<Guidv7uuidMMArrayD2E1MIWA>();
                ((IGuidv7MArrayuuidMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guidv7uuidmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD2))]
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
                var models = await ((IGuidv7MArrayuuidMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidv7MArrayuuidMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Guidv7uuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

