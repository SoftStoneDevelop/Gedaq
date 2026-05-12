

using ClickHouse.Driver.ADO;
using System;
using Gedaq.Common.Enums;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IGuidv7MArrayMArrayD1
    {
    }
    
    internal partial class Guidv7MArrayMArrayD1 : IGuidv7MArrayMArrayD1
    {


#region TestData

        private readonly Guidv7MArrayD1E1M[] _testData = new Guidv7MArrayD1E1M[]
        {
            new Guidv7MArrayD1E1M
{
    Id = 3,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-70c8-a6bf-a7547f11916b"),
Guid.Parse("019e1b50-15ab-7a49-8b5c-b6835551378e"),
Guid.Parse("019e1b50-15ab-7e40-a189-bb4acbef0a1d"),
Guid.Parse("019e1b50-15ab-7265-b1ee-4fd9a540254a"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 7,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-7dcb-9183-d324b4f1c747"),
Guid.Parse("019e1b50-15ab-73cc-921d-12da50b73707"),
Guid.Parse("019e1b50-15ab-73e0-b05a-e171bf193850"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-7589-97ec-4bf7158ce0d6"),
Guid.Parse("019e1b50-15ab-7ba7-8e9a-a3df4e946a6a"),
Guid.Parse("019e1b50-15ab-70aa-a9c6-540d4f210440"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-73f6-9c1f-567c8b05fd1e"),
Guid.Parse("019e1b50-15ab-726e-93ba-6def5950e86c"),
Guid.Parse("019e1b50-15ab-7f81-86c0-95e75444d501"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 8,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-7e94-ac90-869f08ee2dd0"),
Guid.Parse("019e1b50-15ab-7a9f-a61f-d0b19f719787"),
Guid.Parse("019e1b50-15ab-7a41-9efd-d6745cae6767"),
Guid.Parse("019e1b50-15ab-7078-a9d9-da0dbfaa4bc7"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 11,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-7454-be30-d6a5998422e5"),
Guid.Parse("019e1b50-15ab-74e2-81a3-7b7fa48ec935"),
Guid.Parse("019e1b50-15ab-768a-8355-87310149efe3"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-71a7-8229-b3d109c5849a"),
Guid.Parse("019e1b50-15ab-7c97-9155-9330a9313eb8"),
Guid.Parse("019e1b50-15ab-744b-a9ef-c893825a7639"),
Guid.Parse("019e1b50-15ab-7142-9b4a-ff737b59f777"),
},
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 16,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-7d84-ba99-f0c734cfab56"),
Guid.Parse("019e1b50-15ab-7b47-89a1-1684c44250f4"),
Guid.Parse("019e1b50-15ab-7fca-b873-5d3cfa527114"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 15,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-74d9-a394-f8e30b3109d0"),
Guid.Parse("019e1b50-15ab-71ca-9369-ea25e12ba196"),
Guid.Parse("019e1b50-15ab-7779-bf16-c7b639ae6f99"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-72d4-a580-f63afb782855"),
Guid.Parse("019e1b50-15ab-76d2-9fa1-15e1f71b521b"),
Guid.Parse("019e1b50-15ab-7c7a-8949-9e6adbd77554"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-7207-b9a1-5a3487a03639"),
Guid.Parse("019e1b50-15ab-796d-afe2-12fc69e38a27"),
Guid.Parse("019e1b50-15ab-77db-9157-fba61c85b4e6"),
Guid.Parse("019e1b50-15ab-7a8a-964f-60b68279cf19"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 17,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-7384-a8c6-9c96f622564c"),
Guid.Parse("019e1b50-15ab-7744-8920-579915c32e22"),
Guid.Parse("019e1b50-15ab-752c-aab9-7122eb82c98a"),
Guid.Parse("019e1b50-15ab-7f36-a128-83f3ba62fa8b"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 24,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-7a70-bafd-6fd4dbe70908"),
Guid.Parse("019e1b50-15ab-7f2a-9285-a00c92872697"),
Guid.Parse("019e1b50-15ab-7274-9646-7d545010f357"),
Guid.Parse("019e1b50-15ab-74e9-9c47-4d4a73eabc30"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-716f-a696-3614cf6e3220"),
Guid.Parse("019e1b50-15ab-79ec-8c93-cc1624808fe0"),
Guid.Parse("019e1b50-15ab-7d6a-903b-69f86dd52bd8"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 26,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-7414-8fb2-9cb38ea3f654"),
Guid.Parse("019e1b50-15ab-736c-b27f-f95a5b136b35"),
Guid.Parse("019e1b50-15ab-74da-a1ec-51fd4f8d604a"),
Guid.Parse("019e1b50-15ab-713b-8d24-53ca4f4cb272"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 27,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-760a-95d7-e4ccefe8dd40"),
Guid.Parse("019e1b50-15ab-7882-889e-a5fbd4a5c39b"),
Guid.Parse("019e1b50-15ab-7f47-92f4-b1036d349542"),
Guid.Parse("019e1b50-15ab-7cfa-a2e9-bd2e7a3f4b58"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-7ec5-bfa8-8cbffee9862c"),
Guid.Parse("019e1b50-15ab-716a-9dfc-f93cf341a817"),
Guid.Parse("019e1b50-15ab-7643-8360-d9d568242f22"),
},
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 33,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-75ed-92b5-fe15296bd8f3"),
Guid.Parse("019e1b50-15ab-7869-9d55-6dee6f485ce5"),
Guid.Parse("019e1b50-15ab-7110-90f0-46a5b245444b"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 33,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-7efc-bcae-97ed9bffbe1c"),
Guid.Parse("019e1b50-15ab-7874-8b79-9fed5a5f1b76"),
Guid.Parse("019e1b50-15ab-71dc-a0f5-8ae0deb79460"),
Guid.Parse("019e1b50-15ab-7ba5-ac4f-9fa96c55d11e"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-7722-93de-57303cc113fc"),
Guid.Parse("019e1b50-15ab-7983-ad58-d7d3e1828572"),
Guid.Parse("019e1b50-15ab-7c24-a1e8-68822116d740"),
Guid.Parse("019e1b50-15ab-7d88-99e1-b4bcaacb460e"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 39,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-71f4-add4-1423f97d0731"),
Guid.Parse("019e1b50-15ab-73a4-af03-d0b74df67112"),
Guid.Parse("019e1b50-15ab-7b03-84f2-441f27721ea8"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 40,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-704c-bd5e-7a5e79c738c0"),
Guid.Parse("019e1b50-15ab-7252-8d1a-9281d46310b3"),
Guid.Parse("019e1b50-15ab-7b8d-9d92-344946bc22d9"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-79c2-b17d-d7d25e07b52c"),
Guid.Parse("019e1b50-15ab-7132-8c32-37b8c2086949"),
Guid.Parse("019e1b50-15ab-7d4a-8c28-18bbbc1fcdb0"),
},
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 48,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-7404-b36c-0f079046d278"),
Guid.Parse("019e1b50-15ab-7760-b94c-7827798c051c"),
Guid.Parse("019e1b50-15ab-7e64-bdb2-84e5ceff627c"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 49,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-7d1a-b3a1-b0dfa8ed439c"),
Guid.Parse("019e1b50-15ab-72a1-b980-bfc757e9d85c"),
Guid.Parse("019e1b50-15ab-7119-81d7-73befbf7336c"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-7b9e-a8ff-685bdf902eb5"),
Guid.Parse("019e1b50-15ab-7a23-8a73-84ad1770ef7f"),
Guid.Parse("019e1b50-15ab-7fb8-8338-c1cc5dbba889"),
Guid.Parse("019e1b50-15ab-795e-8865-32feea6466de"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 53,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-74ce-bdf2-243f398cc27c"),
Guid.Parse("019e1b50-15ab-7cd1-af5e-578ce302d7a8"),
Guid.Parse("019e1b50-15ab-7fb9-807f-ebb64af4b490"),
Guid.Parse("019e1b50-15ab-7c14-a021-a15af6e34db1"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 54,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-7bdd-ab07-3106f9ef7585"),
Guid.Parse("019e1b50-15ab-76f1-b36e-4bb3d5b6c7fc"),
Guid.Parse("019e1b50-15ab-7c01-a9fe-7562f1e033db"),
Guid.Parse("019e1b50-15ab-7f7f-a34f-6680cb82e432"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 60,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-7b67-b70d-9f49b83c8a88"),
Guid.Parse("019e1b50-15ab-7bc7-b92c-156f4f4e4842"),
Guid.Parse("019e1b50-15ab-7f87-a03f-1d3b4b4ec2c9"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 61,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-773c-930f-f8b344c7754f"),
Guid.Parse("019e1b50-15ab-7a0a-8fa6-9a958bbfc341"),
Guid.Parse("019e1b50-15ab-7014-8192-4b8a23233ca0"),
Guid.Parse("019e1b50-15ab-7196-8b4c-e634ca6be5b7"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-7749-93e2-56725a4fdd9e"),
Guid.Parse("019e1b50-15ab-7840-8e7f-8850eca50c58"),
Guid.Parse("019e1b50-15ab-77e9-8103-89ee2b8cc107"),
},
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 66,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-74a0-bd7f-d2cabe4ce48e"),
Guid.Parse("019e1b50-15ab-781c-adfb-98228e38e491"),
Guid.Parse("019e1b50-15ab-7c49-9e99-2cdcd03c169d"),
Guid.Parse("019e1b50-15ab-705d-92b7-af4fff4db0a7"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 70,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-7514-8cc0-bb1fc5394dd8"),
Guid.Parse("019e1b50-15ab-738b-a3f0-36a9b47dfe2f"),
Guid.Parse("019e1b50-15ab-7c9c-99c2-b172849ddae6"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-7bd2-b0f5-c6f8c09476dc"),
Guid.Parse("019e1b50-15ab-7258-9513-706323469958"),
Guid.Parse("019e1b50-15ab-7bf0-8026-821dd2701c88"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-76cd-8cc5-ba1100239711"),
Guid.Parse("019e1b50-15ab-7f59-9e94-e1de9de592b5"),
Guid.Parse("019e1b50-15ab-7e97-9d98-1c67ee8cc242"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 73,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-7439-9584-b7ba59a0267d"),
Guid.Parse("019e1b50-15ab-7ee8-ab4b-4c8aa9e96bad"),
Guid.Parse("019e1b50-15ab-7f3f-9a50-8cb828dbe87d"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 75,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-7eca-b884-d55af5d8bb86"),
Guid.Parse("019e1b50-15ab-7d3d-b208-cc78b55f4f23"),
Guid.Parse("019e1b50-15ab-766a-974c-8c2f2df8ba7b"),
Guid.Parse("019e1b50-15ab-7dc6-9fa1-da1464bb1fe3"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-7a01-8176-f5e8c75cb9f5"),
Guid.Parse("019e1b50-15ab-7219-9a26-f6872aff4c2d"),
Guid.Parse("019e1b50-15ab-7f43-9772-c54ce69fb675"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 76,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-7f68-b69a-f7d7557546ad"),
Guid.Parse("019e1b50-15ab-7b87-a505-c0606fe1f321"),
Guid.Parse("019e1b50-15ab-7feb-b560-15f48fe2db4d"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 77,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-7a88-9a28-c539d5a8cf4d"),
Guid.Parse("019e1b50-15ab-7441-80d4-240d91180e66"),
Guid.Parse("019e1b50-15ab-70e7-81d5-08582e38ac11"),
Guid.Parse("019e1b50-15ab-715d-ace8-ec967391ef94"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-7988-b34a-b04d117bd3c9"),
Guid.Parse("019e1b50-15ab-7373-8ec2-483b4d4adbf3"),
Guid.Parse("019e1b50-15ab-7614-adf2-05588672e850"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 83,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-77c6-a1af-c1f678f93338"),
Guid.Parse("019e1b50-15ab-7d85-90eb-e9d83b1d61c5"),
Guid.Parse("019e1b50-15ab-7765-a31f-58c5700f51e3"),
Guid.Parse("019e1b50-15ab-77a1-b515-f33c5872c9f5"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 79,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-7df9-9126-afba7158824c"),
Guid.Parse("019e1b50-15ab-7041-b524-91c500de4d8e"),
Guid.Parse("019e1b50-15ab-7f23-9ef7-4c22c60fc4cc"),
Guid.Parse("019e1b50-15ab-70c7-9e3f-42bde818f790"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-777b-8034-acc2906a6d9b"),
Guid.Parse("019e1b50-15ab-74e8-b3fa-e8883abe104b"),
Guid.Parse("019e1b50-15ab-751e-92b4-c642820dcd23"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-70ed-b8c7-959130abd0f8"),
Guid.Parse("019e1b50-15ab-721c-9f99-c1802468c0a9"),
Guid.Parse("019e1b50-15ab-7b77-9bb5-f7378b9671a4"),
Guid.Parse("019e1b50-15ab-744c-9232-b88546c43bb1"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 89,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-7657-99ef-0dacbd073e63"),
Guid.Parse("019e1b50-15ab-74b9-b4a6-099821335b2e"),
Guid.Parse("019e1b50-15ab-7d83-beea-eaafe23b34d2"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 82,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-792c-bf1b-4a6053c2002e"),
Guid.Parse("019e1b50-15ab-7d76-8f01-933faa33f29d"),
Guid.Parse("019e1b50-15ab-7848-9185-6e5fa77689d8"),
Guid.Parse("019e1b50-15ab-71b3-8e8e-bec323210802"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-7cad-ad05-b266f952e5e1"),
Guid.Parse("019e1b50-15ab-735f-a619-66550edb216b"),
Guid.Parse("019e1b50-15ab-7ae0-84eb-5896bf5645af"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-7a00-ae54-40670f28a1bb"),
Guid.Parse("019e1b50-15ab-77db-bcf5-6ab3765009cc"),
Guid.Parse("019e1b50-15ab-784c-9d95-60af0d86558b"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 97,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-7336-9cd7-ffa484c97993"),
Guid.Parse("019e1b50-15ab-7220-aba5-49cf7cd9db00"),
Guid.Parse("019e1b50-15ab-7e72-8748-97fe843419d1"),
Guid.Parse("019e1b50-15ab-75f9-906c-9eef4ffdf2b6"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 90,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-770e-a5b5-3bc7d04ac433"),
Guid.Parse("019e1b50-15ab-725f-ac20-51bad20995b8"),
Guid.Parse("019e1b50-15ab-76e7-86d2-8c7b4b6b6951"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-7ec1-b0dc-fda22466f0f0"),
Guid.Parse("019e1b50-15ab-75ef-8589-d4ab2cb8c4dd"),
Guid.Parse("019e1b50-15ab-7564-8ef6-2b192332ece8"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-7f83-9e96-81348e03f72c"),
Guid.Parse("019e1b50-15ab-7b3e-a8de-24163b6f6fa0"),
Guid.Parse("019e1b50-15ab-74e3-bc0d-f3600d2ad778"),
Guid.Parse("019e1b50-15ab-7428-b809-654b7cf924ab"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 102,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-7791-97f2-17fa6178f7df"),
Guid.Parse("019e1b50-15ab-7c3b-9229-508600dd90f9"),
Guid.Parse("019e1b50-15ab-731c-88b8-c3fa122c8b48"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 96,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-7564-87e4-9f35e42e61e7"),
Guid.Parse("019e1b50-15ab-7998-bc16-4ad2df438a52"),
Guid.Parse("019e1b50-15ab-75c6-8dcc-58a9cb3ed886"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-73dc-be3b-baeffb31818c"),
Guid.Parse("019e1b50-15ab-7d14-82fc-5bff9afdad41"),
Guid.Parse("019e1b50-15ab-767a-8f5b-e5b6fd848a10"),
Guid.Parse("019e1b50-15ab-712b-afc0-713c26a7caf5"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-7e07-9e72-26eb1b41b5c0"),
Guid.Parse("019e1b50-15ab-7cd2-ac45-e4576c128714"),
Guid.Parse("019e1b50-15ab-7315-9676-5f79be977f19"),
Guid.Parse("019e1b50-15ab-77aa-8a14-0f969de671af"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 110,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-77c9-99d8-fd7521fdfab8"),
Guid.Parse("019e1b50-15ab-70c4-819e-59d74f18b5e7"),
Guid.Parse("019e1b50-15ab-75c3-a42e-167ec1456742"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 105,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-76ef-866d-20a01d949359"),
Guid.Parse("019e1b50-15ab-7400-8190-9a5a0efedc80"),
Guid.Parse("019e1b50-15ab-7c41-af51-8eefc50aa8b5"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-7967-aa6e-0a52847290af"),
Guid.Parse("019e1b50-15ab-7147-b42e-00a248537d1d"),
Guid.Parse("019e1b50-15ab-7126-af35-eb1d06335df4"),
Guid.Parse("019e1b50-15ab-7abc-be92-63db7bfd4375"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-771b-af14-31dc1a366496"),
Guid.Parse("019e1b50-15ab-7ac9-ab00-96653bdc9d37"),
Guid.Parse("019e1b50-15ab-76b2-851a-3fd59332e839"),
Guid.Parse("019e1b50-15ab-7ca2-abca-6699d2e5c7d7"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 114,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-70c2-a446-ddfd93f36f55"),
Guid.Parse("019e1b50-15ab-72b6-9d2d-285e63325bd6"),
Guid.Parse("019e1b50-15ab-7368-b67d-1a7d5268a31a"),
Guid.Parse("019e1b50-15ab-7a6b-997a-89f948155aec"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 110,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-7aad-b0a5-d35cfa2d8baf"),
Guid.Parse("019e1b50-15ab-7efd-b59c-4ee2729d3bcd"),
Guid.Parse("019e1b50-15ab-73d4-8e95-9646c9cb0d75"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-7592-9480-6a0efaf5c03b"),
Guid.Parse("019e1b50-15ab-78e5-aeec-f60a2f0f58c8"),
Guid.Parse("019e1b50-15ab-77d2-970d-8c38c99f7fc5"),
},
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 123,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-732d-aa08-564d274d799c"),
Guid.Parse("019e1b50-15ab-7847-9ff7-fe56be440a0a"),
Guid.Parse("019e1b50-15ab-7dd1-b292-f8affde9c87a"),
Guid.Parse("019e1b50-15ab-7d17-933e-9f1e6cca8ad6"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 111,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-7c75-8618-cdfb753bd135"),
Guid.Parse("019e1b50-15ab-7978-80d1-bfc59e2a8043"),
Guid.Parse("019e1b50-15ab-7749-8319-cfe71dc1a9f2"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 128,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-7f08-9d3a-ca9880032582"),
Guid.Parse("019e1b50-15ab-717f-952d-625836adef27"),
Guid.Parse("019e1b50-15ab-7e8f-bf32-0eae3082ded0"),
Guid.Parse("019e1b50-15ab-7928-b486-6711d04354e8"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 118,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-7eb6-ae79-2833661829e9"),
Guid.Parse("019e1b50-15ab-7304-8af0-26ae497fcd6c"),
Guid.Parse("019e1b50-15ab-7831-a1c2-91d78ad42866"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 137,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-7a9b-b252-74a1a6b12c8c"),
Guid.Parse("019e1b50-15ab-76e4-92f9-aa77bdd53958"),
Guid.Parse("019e1b50-15ab-7c8b-9fec-5b82a4ea3537"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 126,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-76e8-be94-db4ca036dd7d"),
Guid.Parse("019e1b50-15ab-735e-abd3-b8af602c9179"),
Guid.Parse("019e1b50-15ab-7b44-ae44-f16a0d73cb0d"),
Guid.Parse("019e1b50-15ab-79ef-a55c-f9a8d00c5be3"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-7d29-9027-69086efd7d68"),
Guid.Parse("019e1b50-15ab-7c28-aad2-ac790416698a"),
Guid.Parse("019e1b50-15ab-7579-a79b-f8d15b3b290d"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-726d-9cd1-9ddb3a61374a"),
Guid.Parse("019e1b50-15ab-7a29-8944-0bc296d412c1"),
Guid.Parse("019e1b50-15ab-7d59-8daa-a3c17ab53f33"),
Guid.Parse("019e1b50-15ab-7195-a91c-9b7717d0b4b0"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 141,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-78a3-9b00-07464d9a5d3d"),
Guid.Parse("019e1b50-15ab-7d63-8aa2-47cbf4b52c64"),
Guid.Parse("019e1b50-15ab-7e84-81e7-d7e84667d008"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 132,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-7088-aaa6-be4f5ed77a42"),
Guid.Parse("019e1b50-15ab-7909-8994-9e96d8e65d7b"),
Guid.Parse("019e1b50-15ab-7a0b-8216-5b2e1cfc967d"),
Guid.Parse("019e1b50-15ab-77d2-845b-4101f7ee3818"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 144,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-7eb9-84dd-ca42784836f2"),
Guid.Parse("019e1b50-15ab-7b37-94ac-6348196452e4"),
Guid.Parse("019e1b50-15ab-7af3-a28a-3be9d0f077f9"),
Guid.Parse("019e1b50-15ab-7035-a9d2-2e8afcd0de5a"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 133,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-7823-8be3-12ea7f82ae41"),
Guid.Parse("019e1b50-15ab-75d8-afc6-07c37251b009"),
Guid.Parse("019e1b50-15ab-7e9c-97b0-24691899396a"),
Guid.Parse("019e1b50-15ab-793c-b5e3-ddca43c62209"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-737a-a992-5db8cb22e96a"),
Guid.Parse("019e1b50-15ab-7c7e-b82b-96233ec12d6b"),
Guid.Parse("019e1b50-15ab-7243-bbf2-5d67d8a68f54"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 148,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-7ca6-ac7b-bbf891261fd2"),
Guid.Parse("019e1b50-15ab-7f8b-91fe-58061c40525d"),
Guid.Parse("019e1b50-15ab-7e1e-b474-38038f5f3eca"),
Guid.Parse("019e1b50-15ab-77b5-b240-e77db791e8fd"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 140,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-780e-8f8f-009fa9b4083b"),
Guid.Parse("019e1b50-15ab-71df-a292-c858bb3d216b"),
Guid.Parse("019e1b50-15ab-7042-a40c-10b779353e6f"),
Guid.Parse("019e1b50-15ab-73c2-9c8c-f9cc42bb61c0"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-7488-947a-c9da4d11e2e4"),
Guid.Parse("019e1b50-15ab-74f2-8905-8a2823f921d2"),
Guid.Parse("019e1b50-15ab-7d8c-bcd2-a4acafd71429"),
Guid.Parse("019e1b50-15ab-70fa-ad91-75fd68f9dbef"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-7276-b1a0-955e497e0f57"),
Guid.Parse("019e1b50-15ab-7871-90cf-65098f8497e9"),
Guid.Parse("019e1b50-15ab-738d-8b8d-79c9992f9108"),
Guid.Parse("019e1b50-15ab-728d-87ec-f12a3cab8631"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 153,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-730d-8a06-37abed5e33fd"),
Guid.Parse("019e1b50-15ab-759c-97f2-0e93be776d3d"),
Guid.Parse("019e1b50-15ab-7fdb-aa26-11a374559b92"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 143,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-73a6-b47f-7a3ea3dbb31a"),
Guid.Parse("019e1b50-15ab-7a30-ad63-3f9c56fe59ca"),
Guid.Parse("019e1b50-15ab-7192-954f-f2bbb8f0b29a"),
Guid.Parse("019e1b50-15ab-7ff4-a53a-6aa610327e39"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-7cc8-83a7-d37f8e9dd4d5"),
Guid.Parse("019e1b50-15ab-76e0-ba52-b767087ec51c"),
Guid.Parse("019e1b50-15ab-735d-87a8-14defe1560e9"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 154,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-78c5-ad0d-d5cf0335b2f2"),
Guid.Parse("019e1b50-15ab-7a48-99bc-98a501741bda"),
Guid.Parse("019e1b50-15ab-7766-a9cc-127b87de781e"),
Guid.Parse("019e1b50-15ab-77b3-b11a-d2bc1c29d845"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 151,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-7014-a1d6-35de67ccf936"),
Guid.Parse("019e1b50-15ab-76c0-9842-3238aabde15d"),
Guid.Parse("019e1b50-15ab-70fc-acc4-2bb1faae60a9"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 159,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-7f4b-bed5-d6e3ade4fcc8"),
Guid.Parse("019e1b50-15ab-708a-b692-fcc56d9e3c3d"),
Guid.Parse("019e1b50-15ab-7dc3-ac0c-f400920fe484"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 159,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-7f81-97b8-22542361cde2"),
Guid.Parse("019e1b50-15ab-7619-b3cc-48ced9722952"),
Guid.Parse("019e1b50-15ab-7c15-a476-264fa3c86584"),
Guid.Parse("019e1b50-15ab-74a4-9f3e-374c8bed77f6"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-7f9f-b990-d797beaa0775"),
Guid.Parse("019e1b50-15ab-74a0-a537-d46d1ca4f8ef"),
Guid.Parse("019e1b50-15ab-7b05-9be5-37af02945600"),
},
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 166,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-78e3-b467-4aefb97d6f6b"),
Guid.Parse("019e1b50-15ab-7401-a341-1952bb3c86af"),
Guid.Parse("019e1b50-15ab-7033-8f14-b7d653904d6d"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 168,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-79af-85b2-a8a675ed40ac"),
Guid.Parse("019e1b50-15ab-7f79-bd91-873b124c0f61"),
Guid.Parse("019e1b50-15ab-77f5-8874-ab625b9e893a"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-7fbe-a38f-0644964d71cf"),
Guid.Parse("019e1b50-15ab-7af7-8b2d-613517ce6ac3"),
Guid.Parse("019e1b50-15ab-772b-a7cc-541e8c759c0e"),
Guid.Parse("019e1b50-15ab-7043-bc0d-2ae82e1a9ef1"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 174,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-727f-a10d-76b0f0b519b7"),
Guid.Parse("019e1b50-15ab-7dc6-b80f-44291479f1dc"),
Guid.Parse("019e1b50-15ab-7d71-b83e-024c210319c0"),
Guid.Parse("019e1b50-15ab-764a-95ee-11ed92dd2c4b"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 175,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-796c-a46c-aa0eb8d11f4c"),
Guid.Parse("019e1b50-15ab-727a-89ce-0f56f168d4c4"),
Guid.Parse("019e1b50-15ab-7480-80d6-011c39cbab25"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-7f99-9e36-7446964e85e9"),
Guid.Parse("019e1b50-15ab-77d5-8fd7-1c0d5dcb3e57"),
Guid.Parse("019e1b50-15ab-7d2c-9e06-eeaf583fa019"),
Guid.Parse("019e1b50-15ab-7ca3-a634-80d2bfe7633e"),
},
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 179,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-7654-b7bb-0a3da9a3d98c"),
Guid.Parse("019e1b50-15ab-706d-922d-43dfab550862"),
Guid.Parse("019e1b50-15ab-7e52-9ab8-bc474301d581"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 181,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-7be0-997e-ffe77c0138c8"),
Guid.Parse("019e1b50-15ab-71c5-becc-b6216971a0dd"),
Guid.Parse("019e1b50-15ab-79d4-99f9-ef9465333c25"),
Guid.Parse("019e1b50-15ab-71d5-a682-3d4aac7767b0"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-7efe-8144-8cd9c90dd111"),
Guid.Parse("019e1b50-15ab-7aac-8046-1ffe1c4f21bf"),
Guid.Parse("019e1b50-15ab-7d39-9264-fd35079334b9"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-7e3e-9ecb-02e419f90f52"),
Guid.Parse("019e1b50-15ab-7545-955b-a6ae2c4aca86"),
Guid.Parse("019e1b50-15ab-7a84-ad77-bd070f428975"),
Guid.Parse("019e1b50-15ab-7b93-bd0b-80d364bb172e"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 180,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-77dc-8a35-3bc8b145dc35"),
Guid.Parse("019e1b50-15ab-796e-afc0-b2c18ae0763b"),
Guid.Parse("019e1b50-15ab-7260-bc12-08bfbb34278d"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 187,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-7c29-b644-d08ef85e9142"),
Guid.Parse("019e1b50-15ab-7010-9cc4-58004c682a08"),
Guid.Parse("019e1b50-15ab-7523-b01f-f1f3604bcab8"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-7e20-bbe9-65e735df6444"),
Guid.Parse("019e1b50-15ab-7d9e-aa6a-17a5c1e4c5c9"),
Guid.Parse("019e1b50-15ab-7e97-91f0-d5f0e4f4e088"),
Guid.Parse("019e1b50-15ab-7293-bd80-9429cd2c31fe"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-750f-b5a4-b13e0c5b2286"),
Guid.Parse("019e1b50-15ab-7c19-8f1b-7181d3548b20"),
Guid.Parse("019e1b50-15ab-72ab-938f-d6c8e7d84ef7"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 183,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-7085-b790-25c3c7a70361"),
Guid.Parse("019e1b50-15ab-7b49-b2cd-5ad418440ee5"),
Guid.Parse("019e1b50-15ab-7d48-b18c-6cc12bb7e62c"),
Guid.Parse("019e1b50-15ab-7bec-95d7-cce83b5b2a12"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 195,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-76c1-941d-57e3078daea8"),
Guid.Parse("019e1b50-15ab-7079-8f8e-43812557c950"),
Guid.Parse("019e1b50-15ab-7d8f-9dfc-ea6aea862222"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-7feb-aa78-6520dd546245"),
Guid.Parse("019e1b50-15ab-7cc9-958b-ce6565110725"),
Guid.Parse("019e1b50-15ab-7764-8020-0d24708a1c7e"),
Guid.Parse("019e1b50-15ab-7c0d-8730-2f08a354f566"),
},
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 186,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-7213-91fd-a93a1e191438"),
Guid.Parse("019e1b50-15ab-7143-aa02-0ca4ecd59f10"),
Guid.Parse("019e1b50-15ab-79e6-8e58-167bf25db0e3"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 203,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-7d08-b631-0599788f113a"),
Guid.Parse("019e1b50-15ab-70fa-8a71-dee2becc4b67"),
Guid.Parse("019e1b50-15ab-72f1-9341-7244f52744f0"),
Guid.Parse("019e1b50-15ab-7698-8182-c3125de86e80"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-7356-bede-08916354a6df"),
Guid.Parse("019e1b50-15ab-764e-b661-fde6966f286a"),
Guid.Parse("019e1b50-15ab-7a05-953b-d9554017f44e"),
},
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 192,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-15ab-7279-98dd-2fa88f4bb582"),
Guid.Parse("019e1b50-15ab-7118-a4e9-f0bf2583500c"),
Guid.Parse("019e1b50-15ab-7e20-8a9f-5bde947f64b8"),
Guid.Parse("019e1b50-15ab-7c34-9438-0bada43739a6"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 209,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-7c1f-ab05-b2fd0a147dc9"),
Guid.Parse("019e1b50-15ab-7c35-b08b-0ea7560a4fa5"),
Guid.Parse("019e1b50-15ab-7e75-96f4-2c0947d640c2"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b50-15ab-706e-900b-2d481f07baa9"),
Guid.Parse("019e1b50-15ab-7032-ad46-7035961b0f25"),
Guid.Parse("019e1b50-15ab-75ba-b19c-73192dc7a5c6"),
},
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.guidv7marrayd1e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(UUID)}, 
    {mi_id:Int32},
    {mi_value:Array(UUID)}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayMArrayD1)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid[]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid[]), 
                parametrName: "mi_value", 
                methodParametrName: "mi_Value")]
        public void InsertModelDbConnectionConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < 2; i++)
                {
                    await ((IGuidv7MArrayMArrayD1)this).InsertModelDbConnectionAsync(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 2; i < 35; i++)
                {
                     ((IGuidv7MArrayMArrayD1)this).InsertModelDbConnection(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

#endregion

#region Select Models

[Gedaq.DbConnection.Attributes.Query(
            query: @"
SELECT
	m_id AS id,
    m_value AS value,
~StartInner::ModelInner:id~
~Reinterpret::id~
    mi_id,
~Reinterpret::value~
    mi_value
~EndInner::ModelInner~
FROM gedaqtests.guidv7marrayd1e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Guidv7MArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayMArrayD1)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_id")]
        public void SelectModelDbConnectionConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models = await ((IGuidv7MArrayMArrayD1)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Guidv7MArrayD1E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models =  ((IGuidv7MArrayMArrayD1)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Guidv7MArrayD1E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

