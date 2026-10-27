

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
    internal partial interface IGuidv7MArrayuuidMMArrayD1
    {
    }
    
    internal partial class Guidv7MArrayuuidMMArrayD1 : IGuidv7MArrayuuidMMArrayD1
    {


#region TestData

        private readonly Guidv7uuidMMArrayD1E1M[] _testData = new Guidv7uuidMMArrayD1E1M[]
        {
            new Guidv7uuidMMArrayD1E1M
{
    Id = 8,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-3a20-79e5-8b7e-92b790bd7342"),
Guid.Parse("01a17ef0-3a20-7a97-8647-9fa2dd44e31a"),
Guid.Parse("01a17ef0-3a20-7b3b-a507-641955394d1b"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-73b6-8750-3004b2c4ecc2"),
Guid.Parse("01a17ef0-3a20-775b-a132-3d8afc164667"),
Guid.Parse("01a17ef0-3a20-791f-843e-c5aac7e987aa"),
Guid.Parse("01a17ef0-3a20-7a42-be10-65d6185d3b7a"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 12,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-738e-8b5f-65caf02e30e5"),
Guid.Parse("01a17ef0-3a20-71d1-abe4-1c5e7e1479c5"),
Guid.Parse("01a17ef0-3a20-7415-a420-e532ce385fb1"),
Guid.Parse("01a17ef0-3a20-7a9f-8303-79f6821dac8c"),
},
    ModelInner = new Guidv7uuidMMArrayD1E1MI
{
    Id = 3,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-3a20-7322-a34a-9c26a0d9f471"),
Guid.Parse("01a17ef0-3a20-7623-9d33-e78c1366793b"),
Guid.Parse("01a17ef0-3a20-7895-b883-5f72eb8592ed"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-7bb0-a3d6-98e47ef9cdc4"),
Guid.Parse("01a17ef0-3a20-7726-a081-7e8e82723e82"),
Guid.Parse("01a17ef0-3a20-712b-a7ed-8a30757c5f00"),
Guid.Parse("01a17ef0-3a20-76fa-a174-947b55d7ebb6"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-3a20-7ab7-b802-ea4322ce93d9"),
Guid.Parse("01a17ef0-3a20-7703-9698-43553badb35e"),
Guid.Parse("01a17ef0-3a20-771e-a512-687831bb0a7c"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 18,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-76fa-9187-edbf0b6d980c"),
Guid.Parse("01a17ef0-3a20-7dd9-ad42-024a5a44a013"),
Guid.Parse("01a17ef0-3a20-7b79-99f1-633d5d6d82bb"),
Guid.Parse("01a17ef0-3a20-7f08-bf43-5d1a43f563ca"),
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
Guid.Parse("01a17ef0-3a20-70fb-8626-9882ccf824ec"),
Guid.Parse("01a17ef0-3a20-73bb-8cd0-12b96ad46844"),
Guid.Parse("01a17ef0-3a20-782e-b8fd-242ea465c13d"),
},
    ModelInner = new Guidv7uuidMMArrayD1E1MI
{
    Id = 9,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-3a20-73dd-b0a1-484f3e521c1d"),
Guid.Parse("01a17ef0-3a20-79cb-955a-c2900b48f162"),
Guid.Parse("01a17ef0-3a20-7a81-a3e2-0eb15ff7df13"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 22,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-3a20-7fd0-9855-f00619776e9c"),
Guid.Parse("01a17ef0-3a20-70ad-97a8-3c59832fbbd5"),
Guid.Parse("01a17ef0-3a20-7f65-9d9d-b9235da015b9"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-70b1-b627-913bc97330b2"),
Guid.Parse("01a17ef0-3a20-7e1b-a180-0ec551cf0580"),
Guid.Parse("01a17ef0-3a20-773e-80d9-8903545fdda9"),
Guid.Parse("01a17ef0-3a20-718f-8d9a-af41bc302c45"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 31,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-72d0-8cb3-14868b82b49f"),
Guid.Parse("01a17ef0-3a20-72c3-92fb-18cabbb99d81"),
Guid.Parse("01a17ef0-3a20-7cc5-b8f6-6dfd546e0211"),
Guid.Parse("01a17ef0-3a20-70be-8b62-6aedfbdbe498"),
},
    ModelInner = new Guidv7uuidMMArrayD1E1MI
{
    Id = 17,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-71cc-a001-cb64e18622f6"),
Guid.Parse("01a17ef0-3a20-72e8-a7d2-f7cfdf1e8f4c"),
Guid.Parse("01a17ef0-3a20-79b2-8826-7c39ff4b061e"),
Guid.Parse("01a17ef0-3a20-722e-b18a-c94d2fef726c"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 32,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-7bcf-83ec-478b23299cc4"),
Guid.Parse("01a17ef0-3a20-7fac-b9e9-2bd28aa87e10"),
Guid.Parse("01a17ef0-3a20-748a-8565-c7f0f976c3ba"),
Guid.Parse("01a17ef0-3a20-701f-8b59-be1174f9ea1f"),
},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 33,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-3a20-777c-a154-a687809907e1"),
Guid.Parse("01a17ef0-3a20-7dba-b9d3-955fbbb0904e"),
Guid.Parse("01a17ef0-3a20-7179-9c49-f2bd54bab984"),
},
    ModelInner = new Guidv7uuidMMArrayD1E1MI
{
    Id = 20,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-3a20-73cb-ba6d-a2c34592f3c6"),
Guid.Parse("01a17ef0-3a20-7f29-8427-9da419ee4c15"),
Guid.Parse("01a17ef0-3a20-73c1-bce5-2d7da1e053b4"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-72a1-8cfe-b3888de8c1cf"),
Guid.Parse("01a17ef0-3a20-7485-8143-3915f833e0e8"),
Guid.Parse("01a17ef0-3a20-7aca-a12e-7dc8e5fcf80a"),
Guid.Parse("01a17ef0-3a20-7851-80cc-e59c1943ba66"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 39,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-7856-8cd6-816bc6aa01e5"),
Guid.Parse("01a17ef0-3a20-7d70-8a8a-3e49a2af3f41"),
Guid.Parse("01a17ef0-3a20-7d99-9c82-62f7b1249232"),
Guid.Parse("01a17ef0-3a20-7523-9ed2-fd022e1a35d6"),
},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 43,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-3a20-72d2-8050-8b8980bad3c2"),
Guid.Parse("01a17ef0-3a20-7662-906f-b4c7b972feb4"),
Guid.Parse("01a17ef0-3a20-7071-ab97-8d1b4bccc1fe"),
},
    ModelInner = new Guidv7uuidMMArrayD1E1MI
{
    Id = 23,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-3a20-7aba-aeec-52497fcf526c"),
Guid.Parse("01a17ef0-3a20-7ff2-bf59-ece918275dd3"),
Guid.Parse("01a17ef0-3a20-745e-9e36-242b10d2570f"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 44,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-7c5a-8020-df534d4370ca"),
Guid.Parse("01a17ef0-3a20-7dc9-a264-8a51fc793e44"),
Guid.Parse("01a17ef0-3a20-7f11-9ca8-90684759423b"),
Guid.Parse("01a17ef0-3a20-7c1b-ac25-3f3f59607d9a"),
},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 53,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-3a20-79fa-8b7f-76ab37cde8dd"),
Guid.Parse("01a17ef0-3a20-7347-90fc-a767540688ca"),
Guid.Parse("01a17ef0-3a20-7ae5-ade3-31a5876ed974"),
},
    ModelInner = new Guidv7uuidMMArrayD1E1MI
{
    Id = 30,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-3a20-730f-8267-8e38fe0af6aa"),
Guid.Parse("01a17ef0-3a20-7dae-b644-47ed3c3da6fe"),
Guid.Parse("01a17ef0-3a20-7d1c-a922-8439fe64bf52"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-3a20-77da-b7fb-67367c263f63"),
Guid.Parse("01a17ef0-3a20-7bb1-b515-3170b0ad9f75"),
Guid.Parse("01a17ef0-3a20-7ecb-aeb0-368bd60dbe0e"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-7b88-a81e-3b20843e2e3b"),
Guid.Parse("01a17ef0-3a20-76cc-9fd6-37f82c2e852c"),
Guid.Parse("01a17ef0-3a20-77e0-aed1-e35c13310051"),
Guid.Parse("01a17ef0-3a20-7f05-a61e-4507ab7a0abd"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 55,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-3a20-72c7-a72d-ac4b10592552"),
Guid.Parse("01a17ef0-3a20-7a2e-bfef-a0c8ed6dad21"),
Guid.Parse("01a17ef0-3a20-72cd-834d-1541a3c2c190"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-7f7f-97c9-4209fbaf01df"),
Guid.Parse("01a17ef0-3a20-7d42-991c-c08d9eae0506"),
Guid.Parse("01a17ef0-3a20-70b2-a45f-072ea664b2c7"),
Guid.Parse("01a17ef0-3a20-7cac-a5b7-532f46aff11b"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 56,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-7ad7-9d66-036a0e550ac5"),
Guid.Parse("01a17ef0-3a20-7a75-abae-b9c88b8a9755"),
Guid.Parse("01a17ef0-3a20-71c4-9efd-29b1eb6cf9c2"),
Guid.Parse("01a17ef0-3a20-7b03-b7b1-eec8bc1e8927"),
},
    ModelInner = new Guidv7uuidMMArrayD1E1MI
{
    Id = 37,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-79db-91e7-4ce76ab89fab"),
Guid.Parse("01a17ef0-3a20-713c-b2d0-94aefc5f21d7"),
Guid.Parse("01a17ef0-3a20-7a10-b8cf-2063a2c38c1e"),
Guid.Parse("01a17ef0-3a20-79e3-b6dd-2e85e81cee0f"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-7f96-b572-2955b4deb1f9"),
Guid.Parse("01a17ef0-3a20-708c-9400-cf565b525eed"),
Guid.Parse("01a17ef0-3a20-7641-bdb1-a5f980c52a52"),
Guid.Parse("01a17ef0-3a20-737a-906c-ae1fee711aa9"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 59,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-7b27-adf0-6e1b4cbc8625"),
Guid.Parse("01a17ef0-3a20-75b6-856a-e32368d596c5"),
Guid.Parse("01a17ef0-3a20-7c30-a21f-f814696e43c7"),
Guid.Parse("01a17ef0-3a20-7f3b-9881-b0bda4cc302f"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-7881-9f43-b48209bf3fe5"),
Guid.Parse("01a17ef0-3a20-79e7-803d-94c701fedc67"),
Guid.Parse("01a17ef0-3a20-7cba-9686-7584667e350e"),
Guid.Parse("01a17ef0-3a20-772d-8080-89f1173f00c4"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 67,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-7893-86b4-faa9cb56b75e"),
Guid.Parse("01a17ef0-3a20-7bef-961b-ff6d79936050"),
Guid.Parse("01a17ef0-3a20-7c3c-ad90-c15bcb129182"),
Guid.Parse("01a17ef0-3a20-7a65-8cdb-cb93832a919d"),
},
    ModelInner = new Guidv7uuidMMArrayD1E1MI
{
    Id = 40,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-3a20-71fd-8ea9-73184597c76c"),
Guid.Parse("01a17ef0-3a20-7e8a-950d-36cb6abd064a"),
Guid.Parse("01a17ef0-3a20-7992-bb0f-7d473e9dcec3"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-791c-afa5-751e2eb98d19"),
Guid.Parse("01a17ef0-3a20-75d4-ab9e-9da7fbb51ed4"),
Guid.Parse("01a17ef0-3a20-7af4-9701-334c5aa21d3a"),
Guid.Parse("01a17ef0-3a20-7ff9-9ecb-f7f1b50ef609"),
},
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 74,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-3a20-7e7d-9ca6-35b717f37c3c"),
Guid.Parse("01a17ef0-3a20-73b7-b172-fcfbb1821ea6"),
Guid.Parse("01a17ef0-3a20-7ec5-9cfb-bc6c655a9ba0"),
},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 78,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-3a20-7619-b941-5e6474b003e0"),
Guid.Parse("01a17ef0-3a20-70d6-a7ad-7229e3ba3075"),
Guid.Parse("01a17ef0-3a20-7cca-8cb5-6b5da0ce7c40"),
},
    ModelInner = new Guidv7uuidMMArrayD1E1MI
{
    Id = 43,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-7a20-9955-84c62335bfd0"),
Guid.Parse("01a17ef0-3a20-7818-b838-01cd42ce2244"),
Guid.Parse("01a17ef0-3a20-709f-be18-a287c3f73575"),
Guid.Parse("01a17ef0-3a20-7776-ac1a-662cddb3dfe5"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-7ae1-b5ab-98eb2c173f0a"),
Guid.Parse("01a17ef0-3a20-763f-8b57-6a4d9fe100e0"),
Guid.Parse("01a17ef0-3a20-7fbd-a60e-572acb98cc8d"),
Guid.Parse("01a17ef0-3a20-78fd-acb4-43030a37d206"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-3a20-79a5-a3df-6238b060c02e"),
Guid.Parse("01a17ef0-3a20-7901-98cb-6e86153e79d8"),
Guid.Parse("01a17ef0-3a20-72d8-b0e5-c82004129cc1"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 81,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-7ef2-8e4b-768adff57057"),
Guid.Parse("01a17ef0-3a20-7af7-ae4e-69ef744e3ee9"),
Guid.Parse("01a17ef0-3a20-7d82-b4c8-3c2599b049ef"),
Guid.Parse("01a17ef0-3a20-7fc4-aa48-d996a042548e"),
},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 84,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-3a20-7448-b266-23a16185431f"),
Guid.Parse("01a17ef0-3a20-7335-9853-cc680e504104"),
Guid.Parse("01a17ef0-3a20-7730-ab09-fb4a3c388ec4"),
},
    ModelInner = new Guidv7uuidMMArrayD1E1MI
{
    Id = 50,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-3a20-7f0f-bb5b-be3c80b6e7c2"),
Guid.Parse("01a17ef0-3a20-781c-8554-07c7fd8e0989"),
Guid.Parse("01a17ef0-3a20-7b23-9040-e5827f558337"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-7b27-b638-e4293b07d65a"),
Guid.Parse("01a17ef0-3a20-76f1-a661-1aac857d613a"),
Guid.Parse("01a17ef0-3a20-7b12-bb04-e76a5317b6dc"),
Guid.Parse("01a17ef0-3a20-7c35-81af-f292f0e3463a"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 90,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-3a20-7812-a3d7-15b5add2d79f"),
Guid.Parse("01a17ef0-3a20-7c41-85ad-0a1c44b9c1ae"),
Guid.Parse("01a17ef0-3a20-7816-85af-0984136e9ae7"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-768a-9db0-eb2449e80bf0"),
Guid.Parse("01a17ef0-3a20-7d06-90e4-fb9669a7504e"),
Guid.Parse("01a17ef0-3a20-74a7-9579-ce4bd40295f9"),
Guid.Parse("01a17ef0-3a20-715f-a185-1cecb172ad09"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 94,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-76fa-9b9a-716c7df5dab9"),
Guid.Parse("01a17ef0-3a20-7e3b-8fc7-b185346f55fd"),
Guid.Parse("01a17ef0-3a20-701a-99aa-401e702eaff3"),
Guid.Parse("01a17ef0-3a20-7c35-b0e6-0722f5b9db64"),
},
    ModelInner = new Guidv7uuidMMArrayD1E1MI
{
    Id = 55,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-743a-a9f8-4626d57ed10a"),
Guid.Parse("01a17ef0-3a20-77dd-b93c-be5747a14a8c"),
Guid.Parse("01a17ef0-3a20-7a97-a77a-da5cd8209281"),
Guid.Parse("01a17ef0-3a20-727c-b56e-2b9f2e79bb2a"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-7995-95f7-8287932e95c9"),
Guid.Parse("01a17ef0-3a20-7777-a2e8-3c32a2685b9c"),
Guid.Parse("01a17ef0-3a20-7f40-ba46-cf891bb04d10"),
Guid.Parse("01a17ef0-3a20-77c0-8c59-647912336a20"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-3a20-7edc-9be6-0b9769c1b45c"),
Guid.Parse("01a17ef0-3a20-7b59-aed7-0e36080f1e4a"),
Guid.Parse("01a17ef0-3a20-7ea6-b912-7d8798ece47d"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 102,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-7186-810f-405a0b5f9a6d"),
Guid.Parse("01a17ef0-3a20-711f-bc13-40654eb2d411"),
Guid.Parse("01a17ef0-3a20-7664-a279-9a9808a3c42c"),
Guid.Parse("01a17ef0-3a20-7b14-aeed-f307c8a91890"),
},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 105,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-3a20-7bde-b045-46afe6b09ca6"),
Guid.Parse("01a17ef0-3a20-780b-be58-5797cb6c81e0"),
Guid.Parse("01a17ef0-3a20-7d2e-971d-133e2712b00c"),
},
    ModelInner = new Guidv7uuidMMArrayD1E1MI
{
    Id = 64,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-3a20-7a84-ac5d-eac90a3a7eee"),
Guid.Parse("01a17ef0-3a20-7424-9e11-5d827bfca4b6"),
Guid.Parse("01a17ef0-3a20-7268-acf7-2a62898656f6"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-7212-80c2-171f06219ff7"),
Guid.Parse("01a17ef0-3a20-7000-90d5-28cef38200db"),
Guid.Parse("01a17ef0-3a20-73ea-8beb-fdf02c053ac4"),
Guid.Parse("01a17ef0-3a20-72a0-94dd-c2bd6973d197"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-7093-b5e7-da4e2571e9cd"),
Guid.Parse("01a17ef0-3a20-7dee-9105-741e7c659ec5"),
Guid.Parse("01a17ef0-3a20-7794-87bd-ccee6c0cf67f"),
Guid.Parse("01a17ef0-3a20-7587-8f62-5260c3adcf65"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 113,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-3a20-7d06-bde6-150f53e88640"),
Guid.Parse("01a17ef0-3a20-7579-9258-f0aa0170fe66"),
Guid.Parse("01a17ef0-3a20-7acf-8642-aa14f6ce5857"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-3a20-7a7e-a8a1-40ee3f4912af"),
Guid.Parse("01a17ef0-3a20-760b-a3e0-2e41c55404e4"),
Guid.Parse("01a17ef0-3a20-7662-bced-725978c0a26b"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 116,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-3a20-7333-8579-65d248357187"),
Guid.Parse("01a17ef0-3a20-7d16-8fbe-7610773e5d0e"),
Guid.Parse("01a17ef0-3a20-7e1b-89c0-fbf05c17bf4a"),
},
    ModelInner = new Guidv7uuidMMArrayD1E1MI
{
    Id = 69,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-7c1d-bb95-dd2024c40359"),
Guid.Parse("01a17ef0-3a20-75cd-96e9-e16131ed16ca"),
Guid.Parse("01a17ef0-3a20-797f-b1fe-c21a8aa0196f"),
Guid.Parse("01a17ef0-3a20-7f36-b71b-dead043216ef"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-7fb1-be21-abdb9c654b47"),
Guid.Parse("01a17ef0-3a20-73dc-91f4-6b7eef628b50"),
Guid.Parse("01a17ef0-3a20-7dbc-9afa-7452b3113ee1"),
Guid.Parse("01a17ef0-3a20-7cc8-98e3-1078b6ec7344"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 120,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-72ff-8684-3ec1e6b72019"),
Guid.Parse("01a17ef0-3a20-704e-b00e-2a824d43540f"),
Guid.Parse("01a17ef0-3a20-77b0-944f-cc36f3f4fc57"),
Guid.Parse("01a17ef0-3a20-79c1-8491-3b6ef3e4a7c1"),
},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 122,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-3a20-7e6a-b78a-266b8b156706"),
Guid.Parse("01a17ef0-3a20-7c99-a015-b5e8690b4456"),
Guid.Parse("01a17ef0-3a20-7d67-9e98-ab36a3d4e44a"),
},
    ModelInner = new Guidv7uuidMMArrayD1E1MI
{
    Id = 74,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-3a20-72d5-a049-8d88973f72d3"),
Guid.Parse("01a17ef0-3a20-79f0-8df3-32fc7fb3557a"),
Guid.Parse("01a17ef0-3a20-7f87-b080-0a1bfee778e8"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-73d8-88cf-a6bbe2541ab4"),
Guid.Parse("01a17ef0-3a20-758b-b150-563447d6dc23"),
Guid.Parse("01a17ef0-3a20-79e6-a7e1-dd71ef52264a"),
Guid.Parse("01a17ef0-3a20-729e-a4f3-0b60ab96b589"),
},
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 129,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-3a20-7fe3-b4da-8f88bf227e68"),
Guid.Parse("01a17ef0-3a20-70e7-ae4c-914b76ecd655"),
Guid.Parse("01a17ef0-3a20-79c2-a4b8-f464b94e71b1"),
},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 136,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-79a1-8bf7-ebbb7f280ceb"),
Guid.Parse("01a17ef0-3a20-78dc-870a-fe2ec9b83593"),
Guid.Parse("01a17ef0-3a20-7ce6-9538-667894c93d59"),
Guid.Parse("01a17ef0-3a20-7e1c-a6a2-030757a6c624"),
},
    ModelInner = new Guidv7uuidMMArrayD1E1MI
{
    Id = 79,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-3a20-7877-8102-0dd72d4e70a9"),
Guid.Parse("01a17ef0-3a20-744a-ab1d-b4ba17b2d7d3"),
Guid.Parse("01a17ef0-3a20-74ff-acb3-09c2f2abe5dd"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 139,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-7e62-9f78-d94934c4b2c8"),
Guid.Parse("01a17ef0-3a20-78ad-a2eb-b4b4443cf499"),
Guid.Parse("01a17ef0-3a20-7c3c-b3f6-ab43225e7f56"),
Guid.Parse("01a17ef0-3a20-70bf-8234-4accd43fa7e5"),
},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 145,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-3a20-745a-848f-b0154d5cb402"),
Guid.Parse("01a17ef0-3a20-72c1-829b-86849d3a7a7f"),
Guid.Parse("01a17ef0-3a20-7f53-b0ba-2714ce988e9d"),
},
    ModelInner = new Guidv7uuidMMArrayD1E1MI
{
    Id = 87,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-7ac4-93b4-98ea8b3a68f5"),
Guid.Parse("01a17ef0-3a20-7f68-8cf2-a30ec35f7715"),
Guid.Parse("01a17ef0-3a20-73ef-9e87-7e49a73ebc12"),
Guid.Parse("01a17ef0-3a20-7542-87c9-f3ce1940f168"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 149,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-3a20-710a-9029-478ee9e89c92"),
Guid.Parse("01a17ef0-3a20-7e8f-9ff0-0d9c7703a80d"),
Guid.Parse("01a17ef0-3a20-71a6-b41e-44a4a20fb5a3"),
},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 157,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-3a20-7dbf-95da-8e2e81e56aa3"),
Guid.Parse("01a17ef0-3a20-787c-ac61-265917b1c5ed"),
Guid.Parse("01a17ef0-3a20-79ae-a89c-eb48f97bc68a"),
},
    ModelInner = new Guidv7uuidMMArrayD1E1MI
{
    Id = 88,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-70b9-aad7-25ae2fa910e1"),
Guid.Parse("01a17ef0-3a20-7b45-8c53-121868acf138"),
Guid.Parse("01a17ef0-3a20-7ed2-bd82-a3721174e0f7"),
Guid.Parse("01a17ef0-3a20-70d5-9b80-9fd106c720eb"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-3a20-7bf5-babb-20c1c0dc0bc4"),
Guid.Parse("01a17ef0-3a20-77b9-9969-ddd9ae8e27ab"),
Guid.Parse("01a17ef0-3a20-77cc-8f6f-779c170aea64"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-3a20-7a1c-b876-6dd35cce7d39"),
Guid.Parse("01a17ef0-3a20-7261-a7a5-3ffe48f4fe16"),
Guid.Parse("01a17ef0-3a20-7b32-98e1-e703bdda674e"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 166,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-7c32-b563-411eb92fb652"),
Guid.Parse("01a17ef0-3a20-7d2d-a7d5-78cfd840a356"),
Guid.Parse("01a17ef0-3a20-712e-b93f-1cd0c5282130"),
Guid.Parse("01a17ef0-3a20-7f32-b9b1-8fbb0877dd11"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-3a20-7005-ac19-ac183bec2ffa"),
Guid.Parse("01a17ef0-3a20-789b-8744-01b6285d4597"),
Guid.Parse("01a17ef0-3a20-769c-8162-d894c6051c9c"),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guidv7uuidmmarrayd1e1mi(
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
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
INSERT INTO public.guidv7uuidmmarrayd1e1mi(
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
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
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

                changedRows =  ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
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
    guidv7uuidmmarrayd1e1mi_id
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)), 
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
                methodParametrName: "guidv7uuidmmarrayd1e1mi_id", 
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
                changedRows =  ((IGuidv7MArrayuuidMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IGuidv7MArrayuuidMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guidv7uuidmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    guidv7uuidmmarrayd1e1mi_id
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
    guidv7uuidmmarrayd1e1mi_id,
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
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

                    nullable =  ((IGuidv7MArrayuuidMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-70b1-b627-913bc97330b2"),
Guid.Parse("01a17ef0-3a20-7e1b-a180-0ec551cf0580"),
Guid.Parse("01a17ef0-3a20-773e-80d9-8903545fdda9"),
Guid.Parse("01a17ef0-3a20-718f-8d9a-af41bc302c45"),
}));
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

                    nullable =  ((IGuidv7MArrayuuidMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable = await ((IGuidv7MArrayuuidMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
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

                    nullable = await ((IGuidv7MArrayuuidMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-72a1-8cfe-b3888de8c1cf"),
Guid.Parse("01a17ef0-3a20-7485-8143-3915f833e0e8"),
Guid.Parse("01a17ef0-3a20-7aca-a12e-7dc8e5fcf80a"),
Guid.Parse("01a17ef0-3a20-7851-80cc-e59c1943ba66"),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guidv7uuidmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    guidv7uuidmmarrayd1e1mi_id
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
    guidv7uuidmmarrayd1e1mi_id,
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
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
                methodParametrName: "guidv7uuidmmarrayd1e1mi_id", 
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
                nullable =  ((IGuidv7MArrayuuidMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IGuidv7MArrayuuidMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
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
                nullable = await ((IGuidv7MArrayuuidMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IGuidv7MArrayuuidMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("01a17ef0-3a20-7b88-a81e-3b20843e2e3b"),
Guid.Parse("01a17ef0-3a20-76cc-9fd6-37f82c2e852c"),
Guid.Parse("01a17ef0-3a20-77e0-aed1-e35c13310051"),
Guid.Parse("01a17ef0-3a20-7f05-a61e-4507ab7a0abd"),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Guidv7uuidMMArrayD1E1M> models = null;

                models =  ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
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

                models = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
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
                await ((IGuidv7MArrayuuidMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
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
                ((IGuidv7MArrayuuidMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
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
                var models = await ((IGuidv7MArrayuuidMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
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
                var models = ((IGuidv7MArrayuuidMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
LEFT JOIN public.guidv7uuidmmarrayd1e1mi mi ON mi.id = m.guidv7uuidmmarrayd1e1mi_id
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
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
                var models = await ((IGuidv7MArrayuuidMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
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
                var models = ((IGuidv7MArrayuuidMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
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
                await ((IGuidv7MArrayuuidMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
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
                ((IGuidv7MArrayuuidMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
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
                var models = await ((IGuidv7MArrayuuidMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
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
                var models = ((IGuidv7MArrayuuidMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
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
LEFT JOIN public.guidv7uuidmmarrayd1e1mi mi ON mi.id = m.guidv7uuidmmarrayd1e1mi_id
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
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
                var models = await ((IGuidv7MArrayuuidMMArrayD1)this).SelectModelAsync(connection, 0);
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
                var models = ((IGuidv7MArrayuuidMMArrayD1)this).SelectModel(connection, 0);
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
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
                await((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
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
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
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
                await ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
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
                await ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[34], false);
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
                ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
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
                 ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
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
                 ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[34], false);
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
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
                var models = await((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
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
                foreach(var batchResult in await ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
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
                await ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[34], false);
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
                var models = ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
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
                foreach(var batchResult in  ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
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
                 ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[34], false);
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
LEFT JOIN public.guidv7uuidmmarrayd1e1mi mi ON mi.id = m.guidv7uuidmmarrayd1e1mi_id
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
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
                var models = await((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
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
                var models = ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
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
                await((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
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
                await ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 139, query1, 67, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[18],_testData[34], false);
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
                await ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 90, query1, 122, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[34], false);
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
                ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
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
                 ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 44, query1, 21, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[30],_testData[34], false);
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
                 ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 145, query1, 129, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[34], false);
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
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
                var models = await((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
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
                foreach(var batchResult in await ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 113, query1, 102, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 55, query1, 139, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[34], false);
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
                var models = ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
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
                foreach(var batchResult in  ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 43, query1, 32, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[10], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[11], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[13],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[14],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[15],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[16],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[17],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[18],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[19],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[20],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[21],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[22],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[23],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
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
                 ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 145, query1, 18, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
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
LEFT JOIN public.guidv7uuidmmarrayd1e1mi mi ON mi.id = m.guidv7uuidmmarrayd1e1mi_id
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
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
                var models = await((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
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
                foreach(var batchResult in await ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 59, 56))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
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
                var models = ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionSelectModel(connection, 0);
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
                foreach(var batchResult in  ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 43, 31))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
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
                await using var cmd = await ((IGuidv7MArrayuuidMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidv7MArrayuuidMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 21);
                var models = await ((IGuidv7MArrayuuidMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(31));

                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidv7MArrayuuidMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidv7MArrayuuidMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 74);
                var models =  ((IGuidv7MArrayuuidMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));

                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[17], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[18], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[19], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[20], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[21], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[22], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[23], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[24], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[25], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[26], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[27], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[28], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[29], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[13],_testData[30], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[14],_testData[31], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[15],_testData[32], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[16],_testData[33], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[17],_testData[34], false);
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
FROM public.binary_guidv7uuidmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Guidv7uuidMMArrayD1E1MIWA),
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Guidv7uuidMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guidv7uuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidv7MArrayuuidMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guidv7uuidmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidv7MArrayuuidMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Guidv7uuidMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guidv7uuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidv7MArrayuuidMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_guidv7uuidmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidv7MArrayuuidMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guidv7uuidmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Guidv7uuidMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Guidv7uuidMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guidv7uuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidv7MArrayuuidMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guidv7uuidmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidv7MArrayuuidMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Guidv7uuidMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guidv7uuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidv7MArrayuuidMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guidv7uuidmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidv7MArrayuuidMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guidv7uuidmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guidv7uuidmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Guidv7uuidMMArrayD1E1MI),
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Guidv7uuidMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidv7MArrayuuidMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidv7MArrayuuidMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Guidv7uuidMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidv7MArrayuuidMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IGuidv7MArrayuuidMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_guidv7uuidmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guidv7uuidmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Guidv7uuidMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Guidv7uuidMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guidv7uuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidv7MArrayuuidMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidv7MArrayuuidMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Guidv7uuidMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guidv7uuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidv7MArrayuuidMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidv7MArrayuuidMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
guidv7uuidmmarrayd1e1mi_id,
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1))]
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
LEFT JOIN public.binary_guidv7uuidmmarrayd1e1mi mi ON mi.id = m.guidv7uuidmmarrayd1e1mi_id
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
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1))]
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

                await ((IGuidv7MArrayuuidMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IGuidv7MArrayuuidMMArrayD1)this).SelectImportModelAsync(connection);
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

                ((IGuidv7MArrayuuidMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((IGuidv7MArrayuuidMMArrayD1)this).SelectImportModel(connection);
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
    guidv7uuidmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
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
                var models =  ((IGuidv7MArrayuuidMMArrayD1)this).ExportModel(connection).ToList();
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
                var models = await ((IGuidv7MArrayuuidMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
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
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1MIWA), typeof(Guidv7uuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
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
                var models1 = new List<Guidv7uuidMMArrayD1E1MIWA>();
                var models2 = new List<Guidv7uuidMMArrayD1E1MIWA>();
                await ((IGuidv7MArrayuuidMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guidv7uuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Guidv7uuidMMArrayD1E1MIWA>();
                var models2 = new List<Guidv7uuidMMArrayD1E1MIWA>();
                ((IGuidv7MArrayuuidMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guidv7uuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
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
                var models = await ((IGuidv7MArrayuuidMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_guidv7uuidmmarrayd1e1mi
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
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidv7MArrayuuidMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_guidv7uuidmmarrayd1e1mi
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
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1MIWA), typeof(Guidv7uuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1))]
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
                var models1 = new List<Guidv7uuidMMArrayD1E1MIWA>();
                var models2 = new List<Guidv7uuidMMArrayD1E1MIWA>();
                await ((IGuidv7MArrayuuidMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guidv7uuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Guidv7uuidMMArrayD1E1MIWA>();
                var models2 = new List<Guidv7uuidMMArrayD1E1MIWA>();
                ((IGuidv7MArrayuuidMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guidv7uuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1))]
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
                var models = await ((IGuidv7MArrayuuidMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_guidv7uuidmmarrayd1e1mi
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
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidv7MArrayuuidMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_guidv7uuidmmarrayd1e1mi
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
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guidv7uuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1MI), typeof(Guidv7uuidMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
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
                var models1 = new List<Guidv7uuidMMArrayD1E1MI>();
                var models2 = new List<Guidv7uuidMMArrayD1E1MI>();
                await ((IGuidv7MArrayuuidMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Guidv7uuidMMArrayD1E1MI>();
                var models2 = new List<Guidv7uuidMMArrayD1E1MI>();
                ((IGuidv7MArrayuuidMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guidv7uuidmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
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
                var models = await ((IGuidv7MArrayuuidMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidv7MArrayuuidMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guidv7uuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1MIWA), typeof(Guidv7uuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1))]
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
                var models1 = new List<Guidv7uuidMMArrayD1E1MIWA>();
                var models2 = new List<Guidv7uuidMMArrayD1E1MIWA>();
                await ((IGuidv7MArrayuuidMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Guidv7uuidMMArrayD1E1MIWA>();
                var models2 = new List<Guidv7uuidMMArrayD1E1MIWA>();
                ((IGuidv7MArrayuuidMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guidv7uuidmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1))]
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
                var models = await ((IGuidv7MArrayuuidMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidv7MArrayuuidMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

