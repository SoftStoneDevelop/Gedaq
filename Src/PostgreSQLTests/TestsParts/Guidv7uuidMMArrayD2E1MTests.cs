

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
    internal partial interface IGuidMArrayuuidMMArrayD2
    {
    }
    
    internal partial class GuidMArrayuuidMMArrayD2 : IGuidMArrayuuidMMArrayD2
    {


#region TestData

        private readonly Guidv7uuidMMArrayD2E1M[] _testData = new Guidv7uuidMMArrayD2E1M[]
        {
            new Guidv7uuidMMArrayD2E1M
{
    Id = 8,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7451-874d-76361021aef0"), Guid.Parse("019e1b45-9260-7c65-b494-3047aaef6697"), }, { Guid.Parse("019e1b45-9260-7f2e-aa3a-4a059ba135c1"), Guid.Parse("019e1b45-9260-7ff4-9f1f-2cc55a6c29fe"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-734e-94ea-584e6f3930d7"), Guid.Parse("019e1b45-9260-77f3-8d39-723c4b415160"), }, { Guid.Parse("019e1b45-9260-77fa-b2c2-de5e48409a62"), Guid.Parse("019e1b45-9260-7cf7-ba88-bacc80e66f58"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 14,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-719d-a9ef-f4f5e6171851"), Guid.Parse("019e1b45-9260-7dc8-bffc-55feaa30ef72"), }, { Guid.Parse("019e1b45-9260-7c35-a12a-58b190e17d77"), Guid.Parse("019e1b45-9260-7ea8-af34-bab07c08483c"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 8,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7d09-bb2a-1370823af122"), Guid.Parse("019e1b45-9260-772d-95e2-f5bd8d548e99"), }, { Guid.Parse("019e1b45-9260-730d-91b7-8c016bd8bc13"), Guid.Parse("019e1b45-9260-705c-8c9e-e6e5c96474da"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 17,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7ea8-be36-f82f0578d021"), Guid.Parse("019e1b45-9260-7be8-b661-74935cb32848"), }, { Guid.Parse("019e1b45-9260-70e7-afe4-0d25d55e321b"), Guid.Parse("019e1b45-9260-7246-af3a-148d00db8089"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 21,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7a97-b8aa-e3d327ab3a8e"), Guid.Parse("019e1b45-9260-7a45-8657-d95a0963b9c3"), }, { Guid.Parse("019e1b45-9260-7e39-b0a9-c1923c8386cf"), Guid.Parse("019e1b45-9260-7041-8f69-45b9fae733a0"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 17,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7a32-a425-48e20227a7c1"), Guid.Parse("019e1b45-9260-7e0e-9156-461fc8919f68"), }, { Guid.Parse("019e1b45-9260-7502-b8c4-6c69429f5261"), Guid.Parse("019e1b45-9260-750e-b41e-7e61296c5e68"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-762e-8680-cff070aa9a13"), Guid.Parse("019e1b45-9260-7121-b8e8-fa31f2f74c4e"), }, { Guid.Parse("019e1b45-9260-73b0-9cd2-ef50dd3c8acd"), Guid.Parse("019e1b45-9260-7587-90d4-ec2cfc4e1643"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-764f-b286-1b1ab8bbdcdc"), Guid.Parse("019e1b45-9260-765c-aa3e-119788329908"), }, { Guid.Parse("019e1b45-9260-701c-8dbf-b5356840855d"), Guid.Parse("019e1b45-9260-7d0a-8188-3a52ee0593f1"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 28,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7066-863d-1edd7fab3ce6"), Guid.Parse("019e1b45-9260-79f3-ab54-db8a0ccbc6cd"), }, { Guid.Parse("019e1b45-9260-70f0-856b-85707b310b17"), Guid.Parse("019e1b45-9260-7cd9-a1ff-e6db52641888"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7fc1-80ad-59683991b96b"), Guid.Parse("019e1b45-9260-76cd-8d07-fc20cbf64887"), }, { Guid.Parse("019e1b45-9260-79a4-9319-0bfb123ace94"), Guid.Parse("019e1b45-9260-77b2-8ca5-8a339bb6ff1e"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 35,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7644-9997-d5a57b0b0620"), Guid.Parse("019e1b45-9260-7d0d-8cf9-933478e72761"), }, { Guid.Parse("019e1b45-9260-72f0-a553-547acc1895e1"), Guid.Parse("019e1b45-9260-713c-b007-7be49ddb5705"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 23,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-79df-b0d8-878abf6ea0ab"), Guid.Parse("019e1b45-9260-7bbc-989b-e7de1def419d"), }, { Guid.Parse("019e1b45-9260-741a-a2e4-781851167c52"), Guid.Parse("019e1b45-9260-73ff-930e-d30aa39cceb9"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7dc2-b99d-73413007dd96"), Guid.Parse("019e1b45-9260-79df-a71d-d10ca8aa0b6d"), }, { Guid.Parse("019e1b45-9260-70de-8bb6-42abe75d4752"), Guid.Parse("019e1b45-9260-7599-8972-ce91da819fb2"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 37,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7010-b5b5-1912e49291cb"), Guid.Parse("019e1b45-9260-7aa3-992b-22d70e64c7b0"), }, { Guid.Parse("019e1b45-9260-702e-a5df-b0fc808a9840"), Guid.Parse("019e1b45-9260-724d-bce8-28b2acd327f8"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-728e-8c7f-cc8a43566590"), Guid.Parse("019e1b45-9260-7219-8707-6e33c4669fee"), }, { Guid.Parse("019e1b45-9260-79de-9f3f-e4bd7bdd53f6"), Guid.Parse("019e1b45-9260-7f94-8cb6-30e1ad4e1b59"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 43,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7fa9-a8f8-85c53bee2659"), Guid.Parse("019e1b45-9260-7565-b00d-64d63534ea90"), }, { Guid.Parse("019e1b45-9260-7207-a217-1de86bdb1886"), Guid.Parse("019e1b45-9260-7293-894d-210b4330e6c1"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 26,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7dfc-ae77-b43515d4dbf1"), Guid.Parse("019e1b45-9260-7818-8ab1-035a1aa72b81"), }, { Guid.Parse("019e1b45-9260-7eaa-a039-6439430a9abc"), Guid.Parse("019e1b45-9260-729c-a926-8edc6dbfcfeb"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7e5d-911b-8547dbee904e"), Guid.Parse("019e1b45-9260-7dc4-988b-f2ccde5a02fe"), }, { Guid.Parse("019e1b45-9260-7601-a99b-cbd6e694d83c"), Guid.Parse("019e1b45-9260-7835-896c-5ce0d3c5fdb8"), }, },
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 52,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-760f-8ed7-c63a475c11c5"), Guid.Parse("019e1b45-9260-7956-a82b-47f775c11228"), }, { Guid.Parse("019e1b45-9260-75d1-8124-934cc82b9db0"), Guid.Parse("019e1b45-9260-7953-953d-110d6044f542"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 53,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7d76-9027-dc17cd65cb8c"), Guid.Parse("019e1b45-9260-7a83-b3e2-7f0e1c71300a"), }, { Guid.Parse("019e1b45-9260-7330-a5d4-cf7e71e2c892"), Guid.Parse("019e1b45-9260-7749-b650-774deae82d0f"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 27,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7f87-a912-977bcdf0cb3a"), Guid.Parse("019e1b45-9260-78d0-9ab2-1c8569332f10"), }, { Guid.Parse("019e1b45-9260-7ad1-9326-c37cf44d652c"), Guid.Parse("019e1b45-9260-7d8b-92ac-f6e3afa41bf3"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7fde-a8ad-518567e4aa04"), Guid.Parse("019e1b45-9260-71e1-a670-c52a13c0545c"), }, { Guid.Parse("019e1b45-9260-723f-89c3-890f3af83441"), Guid.Parse("019e1b45-9260-7c36-9757-5df355272f5a"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-798b-8229-e1228576cf1f"), Guid.Parse("019e1b45-9260-7af5-82a3-8ead83d9b366"), }, { Guid.Parse("019e1b45-9260-7614-b5d4-fee7e56ada38"), Guid.Parse("019e1b45-9260-7ec8-b6e3-6d6e97291770"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 61,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7941-887f-481b97bcefb3"), Guid.Parse("019e1b45-9260-7110-8cd0-e6adbff7db27"), }, { Guid.Parse("019e1b45-9260-7874-b7a1-f210d7bb99f3"), Guid.Parse("019e1b45-9260-78fa-b909-8e930f462937"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 68,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7765-bd92-95d9d54e7531"), Guid.Parse("019e1b45-9260-778f-8799-ef3313e9fdc2"), }, { Guid.Parse("019e1b45-9260-772b-9f0c-4197793cee9b"), Guid.Parse("019e1b45-9260-7059-8506-9c76f7b4781b"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 33,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-71b1-850d-0dd3039dcd3f"), Guid.Parse("019e1b45-9260-7631-90c3-c1749983cc03"), }, { Guid.Parse("019e1b45-9260-7d66-9f53-ee7edad3504d"), Guid.Parse("019e1b45-9260-7f1c-ae7b-601bbbe5887e"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7652-9c1c-85d0ee38f59e"), Guid.Parse("019e1b45-9260-7d7c-a231-9b627cafa919"), }, { Guid.Parse("019e1b45-9260-7512-acac-815b2a8ed053"), Guid.Parse("019e1b45-9260-74c3-b9ec-d73787ee6749"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 72,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7a20-9f7b-4e427ee0c4c8"), Guid.Parse("019e1b45-9260-7733-ace7-372129f587e6"), }, { Guid.Parse("019e1b45-9260-76fe-8363-cb1f49d5f5e4"), Guid.Parse("019e1b45-9260-79bc-99d4-193f86c9a3cf"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-74f1-b1ab-093ff9cd87ca"), Guid.Parse("019e1b45-9260-7b9e-bcd9-f6150d867d2f"), }, { Guid.Parse("019e1b45-9260-785b-a3d1-e3709e0670c8"), Guid.Parse("019e1b45-9260-7f46-bedb-d6043e552830"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 78,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7b9f-a043-922b42188b92"), Guid.Parse("019e1b45-9260-721e-9ad9-f8a4f85dbcfc"), }, { Guid.Parse("019e1b45-9260-7d5b-87bf-a1fa818d4913"), Guid.Parse("019e1b45-9260-7be9-8f0c-492e44ea9c62"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 39,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7a06-983f-fc2f146d5472"), Guid.Parse("019e1b45-9260-721f-ab9f-910f856f664c"), }, { Guid.Parse("019e1b45-9260-7ef1-89a8-4a5d5ae2ca63"), Guid.Parse("019e1b45-9260-79d2-97fa-ab9e41be8b3b"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-72ab-bf83-fc0e22cc08ac"), Guid.Parse("019e1b45-9260-7a89-b9cf-5eb0a0427dc9"), }, { Guid.Parse("019e1b45-9260-7c0f-9c2a-83b7c5dbfe30"), Guid.Parse("019e1b45-9260-721d-846b-06393fe0e9b8"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 80,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7cda-aa48-f9943cb3ab04"), Guid.Parse("019e1b45-9260-7aeb-805e-e1ec51ffb143"), }, { Guid.Parse("019e1b45-9260-7a7a-8233-6dbe26a18db6"), Guid.Parse("019e1b45-9260-72ff-8d2f-5223395e650f"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 87,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-79e8-8969-79b8cb5be4b7"), Guid.Parse("019e1b45-9260-77ac-a8c1-a9d342fc1d4c"), }, { Guid.Parse("019e1b45-9260-7bd6-8270-cf8a8b8f4a9d"), Guid.Parse("019e1b45-9260-71d9-963e-98f8030c55b2"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 44,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7c15-ae0d-26376be3565f"), Guid.Parse("019e1b45-9260-7259-8ed5-cee626f1e44b"), }, { Guid.Parse("019e1b45-9260-7f8e-a6de-1daeb4ca35d7"), Guid.Parse("019e1b45-9260-7b84-b2b0-224ce32823b8"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7390-bd14-28982b947cc0"), Guid.Parse("019e1b45-9260-72d1-9808-b5d975bfea59"), }, { Guid.Parse("019e1b45-9260-7095-8e31-763e6be40651"), Guid.Parse("019e1b45-9260-780b-a580-8cd378faf842"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7ce0-9e21-2b9dab2bd884"), Guid.Parse("019e1b45-9260-7a82-8e62-cd490555a1d3"), }, { Guid.Parse("019e1b45-9260-78a8-9dc4-7c953a5cee81"), Guid.Parse("019e1b45-9260-7c62-bb48-31b55d7594ca"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 90,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-72ab-8918-137ce9419d10"), Guid.Parse("019e1b45-9260-769a-829f-1d121b4d4f28"), }, { Guid.Parse("019e1b45-9260-7af2-87ec-d22d3886e647"), Guid.Parse("019e1b45-9260-79a5-951c-b8520a86648f"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7500-b851-959798380020"), Guid.Parse("019e1b45-9260-7664-a6e5-f8e95d06009b"), }, { Guid.Parse("019e1b45-9260-7aaf-8baa-02ebce2f47e4"), Guid.Parse("019e1b45-9260-7b9b-87d3-3066abe4b0da"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 94,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-789f-a69e-d48c14b471a8"), Guid.Parse("019e1b45-9260-749c-9ca6-fed481be3eea"), }, { Guid.Parse("019e1b45-9260-707d-b087-a6f4a756f1c9"), Guid.Parse("019e1b45-9260-7c70-8b4f-c6e8b9a41055"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 49,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7a3a-ac3c-7f4f90bec274"), Guid.Parse("019e1b45-9260-7a89-85b6-d25d1b6ee1a2"), }, { Guid.Parse("019e1b45-9260-7efa-a413-0502632c07fd"), Guid.Parse("019e1b45-9260-7d00-99ff-1990adaa8c08"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7ef7-80da-8c7fe50be0b8"), Guid.Parse("019e1b45-9260-7ffd-bdbe-20610f82679f"), }, { Guid.Parse("019e1b45-9260-76dc-91d2-ace150fe38ed"), Guid.Parse("019e1b45-9260-7c73-9790-8db927f186f9"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 96,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-768c-8374-e04dd7117276"), Guid.Parse("019e1b45-9260-7dcf-a953-d40f8cedd14e"), }, { Guid.Parse("019e1b45-9260-7f90-badd-49b3b12294a7"), Guid.Parse("019e1b45-9260-7d2f-a0e1-6209350ab219"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-720a-b201-be4c18d9c51c"), Guid.Parse("019e1b45-9260-71c8-86d6-84355b8ee4d2"), }, { Guid.Parse("019e1b45-9260-7f97-8e9d-2afc7e05dd2b"), Guid.Parse("019e1b45-9260-7225-bd28-6ab7d78bb158"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 103,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-70f6-92ca-01822b1e2d9f"), Guid.Parse("019e1b45-9260-7426-b3d6-37eec7e001a4"), }, { Guid.Parse("019e1b45-9260-7747-a9de-9c731d9aafd1"), Guid.Parse("019e1b45-9260-755d-b734-330bd95ccb50"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 58,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7a0c-9222-25b7a851f326"), Guid.Parse("019e1b45-9260-7675-8ba0-d1cc5110bbec"), }, { Guid.Parse("019e1b45-9260-74c8-af0c-3dcf09e009fe"), Guid.Parse("019e1b45-9260-7675-b3b6-c5469839da37"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-784a-b7f6-a546a61b4220"), Guid.Parse("019e1b45-9260-767e-93bf-2995c7ba4cdf"), }, { Guid.Parse("019e1b45-9260-7392-8685-28cd4b0f6b89"), Guid.Parse("019e1b45-9260-7992-b478-20d2dbc587ff"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-72c4-87ad-9831d070bfbe"), Guid.Parse("019e1b45-9260-7ab8-8fae-4d744486b036"), }, { Guid.Parse("019e1b45-9260-72b5-b208-008fb85350ad"), Guid.Parse("019e1b45-9260-7470-b1b1-4f6303660ca1"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 110,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7e2c-9dc7-d025001d02c6"), Guid.Parse("019e1b45-9260-71f1-80bc-cc251494d46f"), }, { Guid.Parse("019e1b45-9260-7587-9e57-f3302fe90336"), Guid.Parse("019e1b45-9260-7365-a478-3bcb943c9df4"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7156-bbb0-f25405361ffd"), Guid.Parse("019e1b45-9260-7c4b-984a-8060eb746304"), }, { Guid.Parse("019e1b45-9260-7fc3-8dc3-e2d72a1b2a0d"), Guid.Parse("019e1b45-9260-7631-997f-8ff076d0a110"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 118,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7a55-a171-c2be0b5770e9"), Guid.Parse("019e1b45-9260-7032-b41f-46a1e7d90c45"), }, { Guid.Parse("019e1b45-9260-70fa-b752-d0af55f95817"), Guid.Parse("019e1b45-9260-7b5c-b150-858096c992c0"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 60,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7fe0-b669-f37d614cd169"), Guid.Parse("019e1b45-9260-766f-9080-c876b9f09b0c"), }, { Guid.Parse("019e1b45-9260-7315-85d0-d0635f80d8b8"), Guid.Parse("019e1b45-9260-7010-b108-80a9d9e5c2ed"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7023-8441-a8b9de20691a"), Guid.Parse("019e1b45-9260-700f-a9e9-460981d923a0"), }, { Guid.Parse("019e1b45-9260-7339-8ff0-edd7640cd800"), Guid.Parse("019e1b45-9260-7214-b6fa-bb89cf245f9e"), }, },
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 126,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7bad-ba1a-197e04b27c54"), Guid.Parse("019e1b45-9260-7cba-a306-c7ecbc40b0c1"), }, { Guid.Parse("019e1b45-9260-7cb2-a0cb-16626cc95c76"), Guid.Parse("019e1b45-9260-7bfd-8432-6e8d33bdea6c"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7053-888a-860e5fb84670"), Guid.Parse("019e1b45-9260-720c-837a-7cca53bd49a2"), }, { Guid.Parse("019e1b45-9260-707f-9305-1436d4af2a73"), Guid.Parse("019e1b45-9260-704d-a013-9a3ad8185267"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 129,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7475-97d2-ddbf855b4353"), Guid.Parse("019e1b45-9260-71c4-b0ec-2388fa2681ea"), }, { Guid.Parse("019e1b45-9260-7692-b1ba-ff98ee6fc3aa"), Guid.Parse("019e1b45-9260-7b45-94ad-365ada471606"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 62,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7593-bb52-0acd2b64f619"), Guid.Parse("019e1b45-9260-7bbb-9ad8-4dffaf636c2c"), }, { Guid.Parse("019e1b45-9260-7c39-bb20-c6e8bbb0ab0a"), Guid.Parse("019e1b45-9260-7677-b637-df096217f471"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7235-864b-16ea1d32bf66"), Guid.Parse("019e1b45-9260-73f4-b500-50e48c3c9585"), }, { Guid.Parse("019e1b45-9260-773f-b780-794d4225c046"), Guid.Parse("019e1b45-9260-7952-af6f-b27aa9ba7379"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 134,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7dd2-87b8-2e4d7fde65a1"), Guid.Parse("019e1b45-9260-79d6-9caa-987c819aaf2c"), }, { Guid.Parse("019e1b45-9260-7947-8bfa-7b555e5d9fd7"), Guid.Parse("019e1b45-9260-7182-8c0f-bbad45af97ca"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-76ce-822d-5c2eaef42df1"), Guid.Parse("019e1b45-9260-72d5-86d4-eb0573c3f759"), }, { Guid.Parse("019e1b45-9260-7964-94bb-a0c1a2164c6e"), Guid.Parse("019e1b45-9260-7edd-875e-b2878ba41f38"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 140,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-73b6-824d-10126b838f82"), Guid.Parse("019e1b45-9260-760d-becf-4f1f3a4fe50d"), }, { Guid.Parse("019e1b45-9260-7172-a404-96e7f00d3531"), Guid.Parse("019e1b45-9260-7452-a474-8960d14dcc1b"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 64,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7952-8a59-923886528c94"), Guid.Parse("019e1b45-9260-70eb-938b-bd1bc4a1ad56"), }, { Guid.Parse("019e1b45-9260-7cc8-b662-9acd717ddfee"), Guid.Parse("019e1b45-9260-730e-a495-895d11109c38"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 141,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7dac-aa5e-c53c201fa079"), Guid.Parse("019e1b45-9260-741e-8117-b635aca08b53"), }, { Guid.Parse("019e1b45-9260-7182-bb7b-17351b08a23e"), Guid.Parse("019e1b45-9260-76a6-9fed-4d499ef6139b"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 147,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7151-a1b2-f33118507464"), Guid.Parse("019e1b45-9260-7f47-ae92-761fb3522d0c"), }, { Guid.Parse("019e1b45-9260-7d6e-bc54-d15d4cfd58ad"), Guid.Parse("019e1b45-9260-7b5c-8021-0e3a580c2c45"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 70,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7fc4-81e2-5b7eee348e3d"), Guid.Parse("019e1b45-9260-7151-99c8-2d8c59822582"), }, { Guid.Parse("019e1b45-9260-7718-88c3-cc15c0512bca"), Guid.Parse("019e1b45-9260-766d-9c17-498b80ec637e"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7052-bf78-f1dd5e8f3f1e"), Guid.Parse("019e1b45-9260-768f-9383-ab6384506054"), }, { Guid.Parse("019e1b45-9260-70b0-8166-e98f54c5a7a5"), Guid.Parse("019e1b45-9260-7524-9c1a-92f4dadd0ad9"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7cbd-a814-90ae6c1bfc4e"), Guid.Parse("019e1b45-9260-7510-be92-22ba8a2a3e5b"), }, { Guid.Parse("019e1b45-9260-7a4a-b714-4c04526f5ec2"), Guid.Parse("019e1b45-9260-7d5e-baa2-12ebf3ada3ae"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 152,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7967-9f63-54e80411ec76"), Guid.Parse("019e1b45-9260-7554-974f-cd3f6a9e9f78"), }, { Guid.Parse("019e1b45-9260-7965-9a45-0a88b25f19e4"), Guid.Parse("019e1b45-9260-72a0-89b0-076df2a90d47"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7c2c-9630-890cd3879276"), Guid.Parse("019e1b45-9260-72d5-a821-32bed7deec75"), }, { Guid.Parse("019e1b45-9260-7b09-bbb2-4640d6133dc1"), Guid.Parse("019e1b45-9260-728e-9dec-3ddc68cbba0b"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 155,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-76c1-afe7-5424d0ff2821"), Guid.Parse("019e1b45-9260-7c44-8ece-5c47e9c22662"), }, { Guid.Parse("019e1b45-9260-7048-8b2a-bbe0f878383d"), Guid.Parse("019e1b45-9260-7b23-9eef-a89b2c97b392"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 72,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-715b-95b5-fd26ab1b4872"), Guid.Parse("019e1b45-9260-736f-b6d0-429ea9274d66"), }, { Guid.Parse("019e1b45-9260-7bf1-b4e0-c8f2ba2add87"), Guid.Parse("019e1b45-9260-72b4-a276-525d749000df"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 161,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-779e-9b5c-400329155979"), Guid.Parse("019e1b45-9260-7870-aef6-22e57df1bd37"), }, { Guid.Parse("019e1b45-9260-721a-ba54-399ebe00c6ab"), Guid.Parse("019e1b45-9260-7f0b-bb08-a8f584b42ada"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7500-9f18-74b876a3e876"), Guid.Parse("019e1b45-9260-70ab-8ef5-4c83f1786736"), }, { Guid.Parse("019e1b45-9260-732a-ba80-00c2c357c183"), Guid.Parse("019e1b45-9260-7f7a-b814-669b5d37b42b"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 170,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9261-7435-9191-2c32b6429ac2"), Guid.Parse("019e1b45-9261-756f-bc3b-700fd645e8b0"), }, { Guid.Parse("019e1b45-9261-71a1-9f4b-b9952b7a3866"), Guid.Parse("019e1b45-9261-7c3f-978a-8a39328f9b9c"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 75,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9261-78ff-993e-c93cb1776e1b"), Guid.Parse("019e1b45-9261-7696-96bf-506f5e03239c"), }, { Guid.Parse("019e1b45-9261-7d3c-8495-26288fdc8ddf"), Guid.Parse("019e1b45-9261-7037-9812-908390c9e35c"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9261-7a9a-898d-0187a24015ab"), Guid.Parse("019e1b45-9261-7bb3-9ef7-20fd1fa9de35"), }, { Guid.Parse("019e1b45-9261-7223-a4e8-a8230a8ca393"), Guid.Parse("019e1b45-9261-7864-9f9e-312f70443489"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 172,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9261-7ff2-bad9-3a93a3450031"), Guid.Parse("019e1b45-9261-739c-8184-61e2dcfc275a"), }, { Guid.Parse("019e1b45-9261-7e4a-9bad-f9a633d844ef"), Guid.Parse("019e1b45-9261-780f-8ff6-9696d18ffafb"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 180,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9261-745e-bc56-4385be3689bf"), Guid.Parse("019e1b45-9261-7590-9435-3234f874f9b5"), }, { Guid.Parse("019e1b45-9261-7649-b778-72c602657ead"), Guid.Parse("019e1b45-9261-7c41-b1f8-db9a4d3ab8c0"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 84,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9261-7d3d-8fc9-60cb61667760"), Guid.Parse("019e1b45-9261-70bc-9017-2ed0fb21b6c0"), }, { Guid.Parse("019e1b45-9261-71a3-ac9f-6e375e26f2ea"), Guid.Parse("019e1b45-9261-78fd-9907-32b86fc8dcad"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9261-7fae-b031-c19f8c2966db"), Guid.Parse("019e1b45-9261-76da-9606-188303b4979b"), }, { Guid.Parse("019e1b45-9261-7c0e-a943-451bb30d412f"), Guid.Parse("019e1b45-9261-7248-92fa-ccb31e8af4a6"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b45-9261-7a1a-a0ad-afb72d170cd3"), Guid.Parse("019e1b45-9261-72f9-8db3-a68dbe807cd4"), }, { Guid.Parse("019e1b45-9261-7121-849a-56169d7b65a3"), Guid.Parse("019e1b45-9261-7b6e-bb49-9e3e93d2d637"), }, },
},
            new Guidv7uuidMMArrayD2E1M
{
    Id = 183,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b45-9261-74c4-b9b8-c988f7ae4b96"), Guid.Parse("019e1b45-9261-74c9-966e-6d5e9afce9fe"), }, { Guid.Parse("019e1b45-9261-7c51-81e0-3f6195b897c8"), Guid.Parse("019e1b45-9261-7328-941c-c644613e64f7"), }, },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd2e1mi(
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
INSERT INTO public.guiduuidmmarrayd2e1mi(
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
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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

                changedRows =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
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
    guiduuidmmarrayd2e1mi_id
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)), 
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
                methodParametrName: "guiduuidmmarrayd2e1mi_id", 
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
                changedRows =  ((IGuidMArrayuuidMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IGuidMArrayuuidMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guidv7uuidmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    guiduuidmmarrayd2e1mi_id
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
    guiduuidmmarrayd2e1mi_id,
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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

                    nullable =  ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7fc1-80ad-59683991b96b"), Guid.Parse("019e1b45-9260-76cd-8d07-fc20cbf64887"), }, { Guid.Parse("019e1b45-9260-79a4-9319-0bfb123ace94"), Guid.Parse("019e1b45-9260-77b2-8ca5-8a339bb6ff1e"), }, }));
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

                    nullable =  ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7dc2-b99d-73413007dd96"), Guid.Parse("019e1b45-9260-79df-a71d-d10ca8aa0b6d"), }, { Guid.Parse("019e1b45-9260-70de-8bb6-42abe75d4752"), Guid.Parse("019e1b45-9260-7599-8972-ce91da819fb2"), }, }));
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

                    nullable = await ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { { Guid.Parse("019e1b45-9260-728e-8c7f-cc8a43566590"), Guid.Parse("019e1b45-9260-7219-8707-6e33c4669fee"), }, { Guid.Parse("019e1b45-9260-79de-9f3f-e4bd7bdd53f6"), Guid.Parse("019e1b45-9260-7f94-8cb6-30e1ad4e1b59"), }, }));
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

                    nullable = await ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guidv7uuidmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    guiduuidmmarrayd2e1mi_id
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
    guiduuidmmarrayd2e1mi_id,
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                methodParametrName: "guiduuidmmarrayd2e1mi_id", 
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
                nullable =  ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { { Guid.Parse("019e1b45-9260-798b-8229-e1228576cf1f"), Guid.Parse("019e1b45-9260-7af5-82a3-8ead83d9b366"), }, { Guid.Parse("019e1b45-9260-7614-b5d4-fee7e56ada38"), Guid.Parse("019e1b45-9260-7ec8-b6e3-6d6e97291770"), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Guid[,] nullable = null;
                nullable = await ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { { Guid.Parse("019e1b45-9260-7652-9c1c-85d0ee38f59e"), Guid.Parse("019e1b45-9260-7d7c-a231-9b627cafa919"), }, { Guid.Parse("019e1b45-9260-7512-acac-815b2a8ed053"), Guid.Parse("019e1b45-9260-74c3-b9ec-d73787ee6749"), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Guidv7uuidMMArrayD2E1M> models = null;

                models =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
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

                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                await ((IGuidMArrayuuidMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
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
                ((IGuidMArrayuuidMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models = await ((IGuidMArrayuuidMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
LEFT JOIN public.guiduuidmmarrayd2e1mi mi ON mi.id = m.guiduuidmmarrayd2e1mi_id
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models = await ((IGuidMArrayuuidMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                await ((IGuidMArrayuuidMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
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
                ((IGuidMArrayuuidMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models = await ((IGuidMArrayuuidMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
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
LEFT JOIN public.guiduuidmmarrayd2e1mi mi ON mi.id = m.guiduuidmmarrayd2e1mi_id
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models = await ((IGuidMArrayuuidMMArrayD2)this).SelectModelAsync(connection, 0);
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).SelectModel(connection, 0);
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                await((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
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
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 17;
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
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[34], false);
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
                ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
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
                parametr1.Value = 170;
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
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
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
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[34], false);
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models = await((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
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
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 90;
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
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[34], false);
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
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
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
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
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[29],_testData[34], false);
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
LEFT JOIN public.guiduuidmmarrayd2e1mi mi ON mi.id = m.guiduuidmmarrayd2e1mi_id
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models = await((IGuidMArrayuuidMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                await((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
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
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 43, query1, 21, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[30],_testData[34], false);
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
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 170, query1, 94, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[34], false);
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
                ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
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
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 152, query1, 129, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[34], false);
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
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 152, query1, 90, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[34], false);
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

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuidv7uuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models = await((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
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
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 61, query1, 17, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[31],_testData[34], false);
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
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 140, query1, 53, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[24],_testData[34], false);
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
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
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 170, query1, 129, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
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
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 170, query1, 152, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatGuidv7uuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[34], false);
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
LEFT JOIN public.guiduuidmmarrayd2e1mi mi ON mi.id = m.guiduuidmmarrayd2e1mi_id
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models = await((IGuidMArrayuuidMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
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
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 35, 140))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSelectModel(connection, 0);
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
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 28, 68))
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
                        Assert.That(models, Has.Count.EqualTo(23));

                        Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        Guidv7uuidMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
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
                await using var cmd = await ((IGuidMArrayuuidMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidMArrayuuidMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 134);
                var models = await ((IGuidMArrayuuidMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(10));

                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidMArrayuuidMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidMArrayuuidMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 110);
                var models =  ((IGuidMArrayuuidMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(14));

                Guidv7uuidMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                Guidv7uuidMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
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
FROM public.binary_guiduuidmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD2E1MIWA),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidMArrayuuidMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidMArrayuuidMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidMArrayuuidMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidMArrayuuidMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD2E1MI),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidMArrayuuidMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidMArrayuuidMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((IGuidMArrayuuidMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidMArrayuuidMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
guiduuidmmarrayd2e1mi_id,
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
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
LEFT JOIN public.binary_guiduuidmmarrayd2e1mi mi ON mi.id = m.guiduuidmmarrayd2e1mi_id
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
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

                await ((IGuidMArrayuuidMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMMArrayD2)this).SelectImportModelAsync(connection);
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

                ((IGuidMArrayuuidMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((IGuidMArrayuuidMMArrayD2)this).SelectImportModel(connection);
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
    guiduuidmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models =  ((IGuidMArrayuuidMMArrayD2)this).ExportModel(connection).ToList();
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
                var models = await ((IGuidMArrayuuidMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
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
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA), typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models1 = new List<GuiduuidMMArrayD2E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD2E1MIWA>();
                await ((IGuidMArrayuuidMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD2E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD2E1MIWA>();
                ((IGuidMArrayuuidMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models = await ((IGuidMArrayuuidMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
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
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
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
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA), typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
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
                var models1 = new List<GuiduuidMMArrayD2E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD2E1MIWA>();
                await ((IGuidMArrayuuidMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD2E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD2E1MIWA>();
                ((IGuidMArrayuuidMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
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
                var models = await ((IGuidMArrayuuidMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
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
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
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
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MI), typeof(GuiduuidMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models1 = new List<GuiduuidMMArrayD2E1MI>();
                var models2 = new List<GuiduuidMMArrayD2E1MI>();
                await ((IGuidMArrayuuidMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD2E1MI>();
                var models2 = new List<GuiduuidMMArrayD2E1MI>();
                ((IGuidMArrayuuidMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models = await ((IGuidMArrayuuidMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA), typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
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
                var models1 = new List<GuiduuidMMArrayD2E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD2E1MIWA>();
                await ((IGuidMArrayuuidMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD2E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD2E1MIWA>();
                ((IGuidMArrayuuidMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
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
                var models = await ((IGuidMArrayuuidMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

