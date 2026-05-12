

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
    internal partial interface IGuidMArrayuuidMMArrayD1
    {
    }
    
    internal partial class GuidMArrayuuidMMArrayD1 : IGuidMArrayuuidMMArrayD1
    {


#region TestData

        private readonly Guidv7uuidMMArrayD1E1M[] _testData = new Guidv7uuidMMArrayD1E1M[]
        {
            new Guidv7uuidMMArrayD1E1M
{
    Id = 5,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-925a-7b3f-a866-6001af1a9027"),
Guid.Parse("019e1b45-925a-7dbb-89a6-ccf9c6a810be"),
Guid.Parse("019e1b45-925a-7a11-919d-26d738a715e4"),
},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 6,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-925a-7c55-bb87-511d7bed746c"),
Guid.Parse("019e1b45-925a-7b05-b927-d3ad040cf9fa"),
Guid.Parse("019e1b45-925a-7607-a8fe-12f811c7e600"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 9,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-925a-7d48-af51-79715d5b5238"),
Guid.Parse("019e1b45-925a-7a9c-9395-e3b08dcf37df"),
Guid.Parse("019e1b45-925a-7c9d-b9f5-247dd12b1563"),
Guid.Parse("019e1b45-925a-79ba-abd1-a511bc16906a"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b45-925a-727a-be5f-03d0f1d43e18"),
Guid.Parse("019e1b45-925a-7153-a090-4b529108193e"),
Guid.Parse("019e1b45-925a-7a53-a303-15f41f1c3364"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 13,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-925a-7bbb-ad00-97605e679d73"),
Guid.Parse("019e1b45-925a-7a47-91d9-7d870eb5c092"),
Guid.Parse("019e1b45-925a-7e47-b8ba-2f9b8eaece9e"),
Guid.Parse("019e1b45-925a-7d58-bf76-e750f51a65f5"),
},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 15,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-925a-74ef-8f90-f779664172ae"),
Guid.Parse("019e1b45-925a-78a5-b58a-c2bcd2b32996"),
Guid.Parse("019e1b45-925a-74c7-b27d-16a6c75cd634"),
Guid.Parse("019e1b45-925a-7927-a41a-91a4895e97d7"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 17,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-925a-794d-85f4-56a741b5e772"),
Guid.Parse("019e1b45-925a-7dda-ad2e-b9a47f58cd5b"),
Guid.Parse("019e1b45-925a-7c85-b10c-c4266f11c0a3"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 17,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-925a-7d54-bd42-953d1bd3f664"),
Guid.Parse("019e1b45-925a-70f8-b022-6733916b5d15"),
Guid.Parse("019e1b45-925a-7248-88b2-21b4cae8c986"),
Guid.Parse("019e1b45-925a-7e2c-9a0e-b118b675ffb0"),
},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 21,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-925a-73d1-a8d7-dac67f9fd24b"),
Guid.Parse("019e1b45-925a-7660-a6d8-9dc92b8815e5"),
Guid.Parse("019e1b45-925a-74e7-a17f-50f64b929ef4"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 19,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-925a-7c59-9a67-9ec86effb58e"),
Guid.Parse("019e1b45-925a-7790-8629-cdaaabcdb936"),
Guid.Parse("019e1b45-925a-7466-8dfc-51fd2a7acb46"),
Guid.Parse("019e1b45-925a-7a0b-966d-02cc38d04ffe"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 27,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-925a-71f0-9a16-b43309ecb78f"),
Guid.Parse("019e1b45-925a-7dee-8278-86ca551b5a09"),
Guid.Parse("019e1b45-925a-745e-bf9f-63ff3a37a079"),
},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 28,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-925a-7e90-9f83-19db5927f14b"),
Guid.Parse("019e1b45-925a-7000-8e82-fe0850cad0ce"),
Guid.Parse("019e1b45-925a-792a-883a-f541ba86ca1c"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 20,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-925a-795c-b402-ef2f625d9d5b"),
Guid.Parse("019e1b45-925a-7fe3-acae-2c1337f8e28b"),
Guid.Parse("019e1b45-925a-7d22-b90f-a51e5fdf5414"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b45-925a-7475-8744-9b0e2cf87a45"),
Guid.Parse("019e1b45-925a-7329-9dde-29766617297b"),
Guid.Parse("019e1b45-925a-7761-987c-f24f1965762f"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b45-925a-7b4c-9283-1bcf27e472ba"),
Guid.Parse("019e1b45-925a-7b2a-b974-b1be8b6d99a6"),
Guid.Parse("019e1b45-925a-7dfe-a717-363a2d056605"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 35,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-925a-7b70-aba8-0d575a508b6d"),
Guid.Parse("019e1b45-925a-78d1-91d0-84f308f14906"),
Guid.Parse("019e1b45-925a-7068-89b5-946a2dfe9200"),
Guid.Parse("019e1b45-925a-7ea4-9179-b29dfafa663f"),
},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 40,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-925a-79e6-81b2-9b6d442c4e8b"),
Guid.Parse("019e1b45-925a-7d0d-ab60-2c9acb96c2e6"),
Guid.Parse("019e1b45-925a-7998-aa74-0a68b404f769"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 28,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-925a-7e24-ae29-3369a3cf6a51"),
Guid.Parse("019e1b45-925a-79dd-ae37-edfea12e6105"),
Guid.Parse("019e1b45-925a-7015-929d-728edad6bc50"),
Guid.Parse("019e1b45-925a-76e2-9575-835198ef1074"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b45-925a-7adb-88f8-4daea90f8c8f"),
Guid.Parse("019e1b45-925a-7ec1-9d7d-9bb17a57c20a"),
Guid.Parse("019e1b45-925a-70c4-babc-5b633c0f0c7c"),
Guid.Parse("019e1b45-925a-7b75-b990-003b251ed747"),
},
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 48,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-925a-7776-949e-c44a9433a04b"),
Guid.Parse("019e1b45-925a-7b74-8b49-e552009ae0d7"),
Guid.Parse("019e1b45-925a-7fbd-8050-31357c6fd95c"),
Guid.Parse("019e1b45-925a-7404-9aed-be1cddcc3e87"),
},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 50,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-925a-795f-84f2-8b59a92d3d61"),
Guid.Parse("019e1b45-925a-763d-8156-54317ab6aec2"),
Guid.Parse("019e1b45-925a-7d2e-9ada-758a17b1d719"),
Guid.Parse("019e1b45-925a-727d-9510-c20934f436d6"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 32,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-925a-7437-a2f7-d63c0c95e144"),
Guid.Parse("019e1b45-925a-7604-9aad-bb4d3c85a7cb"),
Guid.Parse("019e1b45-925a-7d7e-aa19-3908c2bf5028"),
Guid.Parse("019e1b45-925a-7e09-ae26-a9ace7bfe30a"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 58,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-925a-72d1-9813-7fe5e35f1b8d"),
Guid.Parse("019e1b45-925a-73fe-b69b-1dd27e1f8343"),
Guid.Parse("019e1b45-925a-7b89-bb16-79cd48add432"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b45-925a-75a5-b2c8-df194aa47565"),
Guid.Parse("019e1b45-925a-735a-956e-84df3c35cea3"),
Guid.Parse("019e1b45-925a-73e9-b151-1359893ef494"),
Guid.Parse("019e1b45-925a-74ce-b7a8-bde576668959"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 67,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-925a-78d2-a919-cbe6962cd279"),
Guid.Parse("019e1b45-925a-7aee-9644-510c17b6f965"),
Guid.Parse("019e1b45-925a-7c49-9a69-9ab2cdc13645"),
Guid.Parse("019e1b45-925a-7926-822b-c1912feeeb76"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 33,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-925a-79e8-9c34-d20bfbf2c301"),
Guid.Parse("019e1b45-925a-7e69-9f6d-4cc2977b3950"),
Guid.Parse("019e1b45-925a-7f47-8e61-a382d1789525"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b45-925a-7f36-bb8f-1d8d978e009a"),
Guid.Parse("019e1b45-925a-7318-83ab-d4c0fc7dc64f"),
Guid.Parse("019e1b45-925a-739f-b4f7-1e0c04cad78d"),
Guid.Parse("019e1b45-925a-77ab-bcdf-99ca932ef33e"),
},
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 75,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-925a-73d6-ae38-eb2025a93883"),
Guid.Parse("019e1b45-925a-7d24-9bcf-d15c9e47b3c3"),
Guid.Parse("019e1b45-925a-7b73-8d86-b78963110879"),
},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 83,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-925a-78ec-aaa9-4060b72e2fdf"),
Guid.Parse("019e1b45-925a-7026-a704-11758653e5a0"),
Guid.Parse("019e1b45-925a-7232-9e52-c95ccb956835"),
Guid.Parse("019e1b45-925a-7dc6-afdb-1764a9c6303e"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 37,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-925a-7a0e-81e6-b0db27543070"),
Guid.Parse("019e1b45-925a-7523-a9e9-f6b77e4ceac7"),
Guid.Parse("019e1b45-925a-76de-a4cf-641287e36e8c"),
Guid.Parse("019e1b45-925a-7e05-860b-af0db977da95"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 90,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-925a-7931-9207-17d39f480ce3"),
Guid.Parse("019e1b45-925a-7cab-953b-55f861f49d13"),
Guid.Parse("019e1b45-925a-7f22-b79d-48d3e9d749a7"),
Guid.Parse("019e1b45-925a-7442-bf3e-222360a5a881"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b45-925a-722b-88ac-c951d50725e2"),
Guid.Parse("019e1b45-925a-7c85-b186-577a78ce4eab"),
Guid.Parse("019e1b45-925a-749c-9d68-2a5ef1fb32aa"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 93,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-925a-7ef9-8d26-1a057aecaf06"),
Guid.Parse("019e1b45-925a-79ee-b5d3-e553f475099c"),
Guid.Parse("019e1b45-925a-7259-8a4d-45632f060553"),
Guid.Parse("019e1b45-925a-75be-872e-3b1bcd5b3759"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 41,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-925a-73f6-893d-4d42d4128b68"),
Guid.Parse("019e1b45-925a-7048-a750-4716ae638a55"),
Guid.Parse("019e1b45-925a-72f0-8c8e-da33f62f58d1"),
Guid.Parse("019e1b45-925a-70fe-baf9-9f769e1e4723"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b45-925a-70c6-8108-1754f329e670"),
Guid.Parse("019e1b45-925a-7559-a6fd-43361e6dfe29"),
Guid.Parse("019e1b45-925a-71a4-af90-02eb9748ee38"),
Guid.Parse("019e1b45-925a-77a9-8e6b-b47ae8ba3a46"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 94,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-925a-73ba-8c33-acd9b4293fb5"),
Guid.Parse("019e1b45-925a-7308-bfea-c3a0b6ddb91c"),
Guid.Parse("019e1b45-925a-780c-a360-c142131e92fa"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b45-925a-7d95-993e-14481429fef9"),
Guid.Parse("019e1b45-925a-7ad1-b2b4-f462c813baac"),
Guid.Parse("019e1b45-925a-7bf3-9c64-8c4b133ccb14"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 103,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-925a-7d40-ab33-6ba63974d2f0"),
Guid.Parse("019e1b45-925a-7d63-bc3d-bc2d7778d956"),
Guid.Parse("019e1b45-925a-74b0-b8b9-70f6c4f07864"),
Guid.Parse("019e1b45-925a-776f-b4e0-0a1f62fc844e"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 44,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-925a-793a-9dc9-5e6e96b036cd"),
Guid.Parse("019e1b45-925a-7b1f-843f-cc657758f998"),
Guid.Parse("019e1b45-925a-793e-b1a7-f8ea48169f3b"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b45-925a-7d95-ad80-44769e090e9a"),
Guid.Parse("019e1b45-925a-71b6-9132-004fcdf78b88"),
Guid.Parse("019e1b45-925a-74e8-ab75-fb4833ef477b"),
Guid.Parse("019e1b45-925a-7086-af01-677208f05ec6"),
},
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 104,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-925a-7a8d-80a6-61edbf32802b"),
Guid.Parse("019e1b45-925a-7148-991e-f65a5c37e7be"),
Guid.Parse("019e1b45-925a-7134-a7db-0bf8ee2bbdab"),
Guid.Parse("019e1b45-925a-7ca7-aa11-f3e0019a92f3"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b45-925a-7d18-8a1a-c3f997ecf27c"),
Guid.Parse("019e1b45-925a-758a-9901-ef933a57c6d0"),
Guid.Parse("019e1b45-925a-7824-a8e7-533ebf06aa26"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 113,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-925a-725a-b10f-67312f089f41"),
Guid.Parse("019e1b45-925a-76b4-8266-7b6d38c6bb91"),
Guid.Parse("019e1b45-925a-77cc-825e-f6f4f9de6600"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 47,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-925a-713d-819b-ee5d9d0bccf1"),
Guid.Parse("019e1b45-925a-749d-b360-39eb1bfcd5da"),
Guid.Parse("019e1b45-925a-7435-9618-e4feeb69bdbb"),
Guid.Parse("019e1b45-925a-7d27-acdb-35b0901d3270"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b45-925a-79f1-a053-22f9fc1b0f3d"),
Guid.Parse("019e1b45-925a-7cf7-b5fa-9d6eed5e0028"),
Guid.Parse("019e1b45-925a-74c1-9c7f-c5cfa1f02e24"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 121,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-925a-7922-b8fe-0e087c9a2175"),
Guid.Parse("019e1b45-925a-7c83-a6c0-8cda1cc29d8c"),
Guid.Parse("019e1b45-925a-712f-b3c3-66a177edffd1"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b45-925a-7712-b307-070186117f24"),
Guid.Parse("019e1b45-925a-74d9-bacd-6d23537f5473"),
Guid.Parse("019e1b45-925a-7def-bec2-830495561b9d"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 124,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-925a-70fb-b918-4156093227e9"),
Guid.Parse("019e1b45-925a-7a87-a695-11aedbebb7f7"),
Guid.Parse("019e1b45-925a-7193-9099-087da6ac76e6"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 53,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-925a-7a97-9818-c91a7b44cd2c"),
Guid.Parse("019e1b45-925a-74d3-9453-cfec21fb4877"),
Guid.Parse("019e1b45-925a-7155-a32f-6d5e2daf007d"),
Guid.Parse("019e1b45-925a-78be-96bc-2e9dcd0eb319"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 126,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-925a-7cdb-8b87-7b97c1f14140"),
Guid.Parse("019e1b45-925a-77a9-9674-9f3fbc10315f"),
Guid.Parse("019e1b45-925a-71ca-bf83-1070a23c888a"),
},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 133,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-925a-738b-9dec-738a8e5a3577"),
Guid.Parse("019e1b45-925a-785b-af27-650cb40a4716"),
Guid.Parse("019e1b45-925a-7803-b17b-40c86eb592a3"),
Guid.Parse("019e1b45-925a-748d-8d97-f9f4c9607710"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 56,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-925a-7912-8568-85e69772246d"),
Guid.Parse("019e1b45-925a-77c3-8924-a1b8c3d75613"),
Guid.Parse("019e1b45-925a-7982-92cb-13b144d7b48f"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b45-925a-7dfe-86e1-e9bdf83853fc"),
Guid.Parse("019e1b45-925a-7cca-b958-9a781994635c"),
Guid.Parse("019e1b45-925a-7d18-8ae9-39cf28e24210"),
Guid.Parse("019e1b45-925a-7e61-aedd-932c24cdae5b"),
},
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 135,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-925a-7ed4-82f1-9d4cd835b765"),
Guid.Parse("019e1b45-925a-755b-9160-dc7d1aa7bc93"),
Guid.Parse("019e1b45-925a-77d0-9060-74baff70077d"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b45-925a-7839-9eca-587b03ed11de"),
Guid.Parse("019e1b45-925a-7d18-804b-5c0c2b8a5d08"),
Guid.Parse("019e1b45-925a-7255-8dac-6898b1cfdd86"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 138,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-925a-750e-ae25-3843dab9180e"),
Guid.Parse("019e1b45-925a-7ad9-b893-418d7232b897"),
Guid.Parse("019e1b45-925a-7a23-9299-95b87c04b708"),
Guid.Parse("019e1b45-925a-7255-998e-39316e45d50e"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 62,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-925a-7f9f-b79a-66edc263c1ae"),
Guid.Parse("019e1b45-925a-7d12-a286-2293948c8e05"),
Guid.Parse("019e1b45-925a-7f2d-936e-a72c7f895058"),
Guid.Parse("019e1b45-925a-7d7a-a43a-1585e9f88767"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 146,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-925a-775d-afc7-e1c18b94e31f"),
Guid.Parse("019e1b45-925a-7aae-b3d1-00395bccf3d4"),
Guid.Parse("019e1b45-925a-7adb-9c09-18f3e3f6af8d"),
Guid.Parse("019e1b45-925a-7a80-92d3-2b18f3dab98a"),
},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 149,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-925a-7035-9816-fdd214ebaa8d"),
Guid.Parse("019e1b45-925a-779f-9c2f-e5708d7a8820"),
Guid.Parse("019e1b45-925a-7101-9fdc-97d79bbade8c"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 68,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-925a-76e8-b569-63fb53520ffe"),
Guid.Parse("019e1b45-925a-7216-90a2-6e134a49a7e8"),
Guid.Parse("019e1b45-925a-7dc6-801a-6f1ba860c687"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b45-925a-7924-ba9c-5f47b97bdb70"),
Guid.Parse("019e1b45-925a-7df5-97b7-a07d0463f695"),
Guid.Parse("019e1b45-925a-7352-846e-e91442c91f5b"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 154,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-925a-79ee-a92f-cfe9b9c289fa"),
Guid.Parse("019e1b45-925a-750d-b75f-3835ce83e7b9"),
Guid.Parse("019e1b45-925a-77c3-ad93-be809eeb4ac0"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b45-925a-7425-a7af-f5056295eeb4"),
Guid.Parse("019e1b45-925a-7dfd-9a3e-968260eeee1e"),
Guid.Parse("019e1b45-925a-7ead-bb6c-8c61f7afc86e"),
Guid.Parse("019e1b45-925a-72fb-aad6-71a18f5cba0f"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 160,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-925a-7a12-839b-033ab2395bd2"),
Guid.Parse("019e1b45-925a-7162-bafc-882c7f009a70"),
Guid.Parse("019e1b45-925a-7a61-a785-08caf9922c0a"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 73,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-925a-7f96-a24a-c953e6e1af02"),
Guid.Parse("019e1b45-925a-75bb-b4d6-4bc4b3251043"),
Guid.Parse("019e1b45-925a-7820-972b-94b36310bfd5"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b45-925a-7cd0-9646-931ab092dceb"),
Guid.Parse("019e1b45-925a-77c3-b8dd-7323f131e76e"),
Guid.Parse("019e1b45-925a-7347-9e44-037ce16010ab"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 165,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b45-925a-7806-a555-a7cfdc8f479b"),
Guid.Parse("019e1b45-925a-7763-8554-f24d416970dc"),
Guid.Parse("019e1b45-925a-7a73-b2a2-1be7f99dfcdc"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b45-925a-7794-a071-9600b521985e"),
Guid.Parse("019e1b45-925a-75c2-b8be-d3f504e9f248"),
Guid.Parse("019e1b45-925a-71fa-903d-484ca399b637"),
Guid.Parse("019e1b45-925a-7afe-8092-9ff4f58c8f12"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 170,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-925a-702a-9a60-7436de59e0e1"),
Guid.Parse("019e1b45-925a-7d28-a8f0-4320dd522236"),
Guid.Parse("019e1b45-925a-7371-9073-8cc47fea74b7"),
Guid.Parse("019e1b45-925a-735e-a90c-86cceb8ea7e5"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 82,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-925a-7cb4-adf3-49815dbaac46"),
Guid.Parse("019e1b45-925a-7112-9f57-37f67622b39f"),
Guid.Parse("019e1b45-925a-7576-b67b-842c922a6c55"),
Guid.Parse("019e1b45-925a-78d4-ae51-986676caba1d"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b45-925a-7916-b75f-37fcd456c0e0"),
Guid.Parse("019e1b45-925a-7b49-9cf7-19cf49566625"),
Guid.Parse("019e1b45-925a-7faf-b30b-d4a05ccb8c1a"),
},
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 177,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b45-925a-7cc5-96b3-a282f277c357"),
Guid.Parse("019e1b45-925a-7ad0-9e6e-97de89d56161"),
Guid.Parse("019e1b45-925a-77c7-a049-eb566c1363eb"),
Guid.Parse("019e1b45-925a-779c-b5b4-baeb9317b574"),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd1e1mi(
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd1e1mi(
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
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]), 
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

                changedRows =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guidv7uuidmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    guiduuidmmarrayd1e1mi_id
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuidmmarrayd1e1mi_id", 
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
                changedRows =  ((IGuidMArrayuuidMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IGuidMArrayuuidMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guidv7uuidmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    guiduuidmmarrayd1e1mi_id
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
    guiduuidmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                System.Guid[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[]>();
                    ((NpgsqlParameter<System.Guid[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[]>();
                    ((NpgsqlParameter<System.Guid[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                System.Guid[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[]>();
                    ((NpgsqlParameter<System.Guid[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[]>();
                    ((NpgsqlParameter<System.Guid[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("019e1b45-925a-7b4c-9283-1bcf27e472ba"),
Guid.Parse("019e1b45-925a-7b2a-b974-b1be8b6d99a6"),
Guid.Parse("019e1b45-925a-7dfe-a717-363a2d056605"),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guidv7uuidmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    guiduuidmmarrayd1e1mi_id
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
    guiduuidmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuidmmarrayd1e1mi_id", 
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
                System.Guid[] nullable = null;
                nullable =  ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Guid[] nullable = null;
                nullable = await ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Guidv7uuidMMArrayD1E1M> models = null;

                models =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Guidv7uuidMMArrayD1E1M> models = null;

                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuidv7uuidMMArrayD1E1M), typeof(FlatGuidv7uuidMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guidv7uuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var models2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guidv7uuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var models2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                ((IGuidMArrayuuidMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuidv7uuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guidv7uuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IGuidMArrayuuidMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guidv7uuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidMArrayuuidMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guidv7uuidmmarrayd1e1m m
LEFT JOIN public.guiduuidmmarrayd1e1mi mi ON mi.id = m.guiduuidmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models = await ((IGuidMArrayuuidMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IGuidMArrayuuidMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuidv7uuidMMArrayD1E1M), typeof(FlatGuidv7uuidMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guidv7uuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var models2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guidv7uuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var models2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                ((IGuidMArrayuuidMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuidv7uuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guidv7uuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidMArrayuuidMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guidv7uuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidMArrayuuidMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guidv7uuidmmarrayd1e1m m
LEFT JOIN public.guiduuidmmarrayd1e1mi mi ON mi.id = m.guiduuidmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models = await ((IGuidMArrayuuidMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IGuidMArrayuuidMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuidv7uuidMMArrayD1E1M), typeof(FlatGuidv7uuidMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var models2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                await((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 50;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
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
FROM public.guidv7uuidmmarrayd1e1m m
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
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.guidv7uuidmmarrayd1e1m m
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
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[22],_testData[34], false);
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
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var models2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
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
FROM public.guidv7uuidmmarrayd1e1m m
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
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
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
FROM public.guidv7uuidmmarrayd1e1m m
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
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuidv7uuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
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
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 160;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
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
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
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
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
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
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.guidv7uuidmmarrayd1e1m m
LEFT JOIN public.guiduuidmmarrayd1e1mi mi ON mi.id = m.guiduuidmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models = await((IGuidMArrayuuidMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[10], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[11], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[12], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[13], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[14], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[15], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[16], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[17], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[18], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[19], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[20], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[21], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[22], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[13],_testData[23], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[14],_testData[24], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[15],_testData[25], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[16],_testData[26], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[17],_testData[27], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[18],_testData[28], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[19],_testData[29], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[20],_testData[30], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[21],_testData[31], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[22],_testData[32], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[23],_testData[33], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[24],_testData[34], false);
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
                var models = ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuidv7uuidMMArrayD1E1M), typeof(FlatGuidv7uuidMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var models2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                await((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guidv7uuidmmarrayd1e1m m
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
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 126, query1, 146, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.guidv7uuidmmarrayd1e1m m
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
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 75, query1, 126, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
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
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var models2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guidv7uuidmmarrayd1e1m m
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
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 160, query1, 58, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.guidv7uuidmmarrayd1e1m m
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
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 40, query1, 154, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuidv7uuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guidv7uuidmmarrayd1e1m m
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
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 113, query1, 50, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[13],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[14],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[15],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[16],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[17],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[18],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[19],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[20],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[21],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[22],_testData[34], false);
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
FROM public.guidv7uuidmmarrayd1e1m m
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
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 121, query1, 13, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guidv7uuidmmarrayd1e1m m
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
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 13, query1, 58, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[3], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[4], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[5], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[6], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[7], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[8], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[9], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[10], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[11], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[13],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[14],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[15],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[16],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[17],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[18],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[19],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[20],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[21],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[22],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[23],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[24],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[25],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[26],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[27],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[28],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[29],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[30],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
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
FROM public.guidv7uuidmmarrayd1e1m m
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
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 160, query1, 104, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.guidv7uuidmmarrayd1e1m m
LEFT JOIN public.guiduuidmmarrayd1e1mi mi ON mi.id = m.guiduuidmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models = await((IGuidMArrayuuidMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 5, 104))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[21], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[22], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[23], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[24], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[25], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[26], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[27], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[28], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[29], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[30], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[31], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[32], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[33], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[13],_testData[34], false);
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
                var models = ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 58, 121))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[34], false);
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
                await using var cmd = await ((IGuidMArrayuuidMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidMArrayuuidMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 6);
                var models = await ((IGuidMArrayuuidMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(33));

                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidMArrayuuidMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidMArrayuuidMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 133);
                var models =  ((IGuidMArrayuuidMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(9));

                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[34], false);
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
FROM public.binary_guiduuidmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD1E1MIWA),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidMArrayuuidMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidMArrayuuidMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidMArrayuuidMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidMArrayuuidMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD1E1MI),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidMArrayuuidMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidMArrayuuidMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IGuidMArrayuuidMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidMArrayuuidMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guidv7uuidmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
guiduuidmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Guidv7uuidMMArrayD1E1M),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
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
FROM public.binary_guidv7uuidmmarrayd1e1m m
LEFT JOIN public.binary_guiduuidmmarrayd1e1mi mi ON mi.id = m.guiduuidmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Guidv7uuidMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IGuidMArrayuuidMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Guidv7uuidMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Guidv7uuidMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IGuidMArrayuuidMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((IGuidMArrayuuidMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Guidv7uuidMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guidv7uuidmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    guiduuidmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models =  ((IGuidMArrayuuidMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Guidv7uuidMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidMArrayuuidMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Guidv7uuidMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA), typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models1 = new List<GuiduuidMMArrayD1E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD1E1MIWA>();
                await ((IGuidMArrayuuidMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD1E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD1E1MIWA>();
                ((IGuidMArrayuuidMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models = await ((IGuidMArrayuuidMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
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
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
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
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA), typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
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
                var models1 = new List<GuiduuidMMArrayD1E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD1E1MIWA>();
                await ((IGuidMArrayuuidMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD1E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD1E1MIWA>();
                ((IGuidMArrayuuidMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
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
                var models = await ((IGuidMArrayuuidMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
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
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
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
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MI), typeof(GuiduuidMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models1 = new List<GuiduuidMMArrayD1E1MI>();
                var models2 = new List<GuiduuidMMArrayD1E1MI>();
                await ((IGuidMArrayuuidMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD1E1MI>();
                var models2 = new List<GuiduuidMMArrayD1E1MI>();
                ((IGuidMArrayuuidMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models = await ((IGuidMArrayuuidMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA), typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
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
                var models1 = new List<GuiduuidMMArrayD1E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD1E1MIWA>();
                await ((IGuidMArrayuuidMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD1E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD1E1MIWA>();
                ((IGuidMArrayuuidMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
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
                var models = await ((IGuidMArrayuuidMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

