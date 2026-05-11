

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
    internal partial interface IGuidMArrayuuidMArrayD2
    {
    }
    
    internal partial class GuidMArrayuuidMArrayD2 : IGuidMArrayuuidMArrayD2
    {


#region TestData

        private readonly GuiduuidMArrayD2E1M[] _testData = new GuiduuidMArrayD2E1M[]
        {
            new GuiduuidMArrayD2E1M
{
    Id = 5,
    Value = 
new System.Guid[,] { {
Guid.Parse("0eb5baf7-7a80-48e7-8b21-10f2e0f895df"),
Guid.Parse("c9b6101c-50d3-4c4f-81b1-4239c17f0fc2"), } },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("5d2d23d0-68f0-4ab2-a615-baac3d333ae3"),
Guid.Parse("35a4190c-68c1-42b4-ae1e-36d504be7672"), } },
},
            new GuiduuidMArrayD2E1M
{
    Id = 6,
    Value = 
new System.Guid[,] { {
Guid.Parse("f0bca54b-2121-410c-a938-a73a87f1758d"),
Guid.Parse("da56b39a-be16-4860-86c3-4a002aa94adb"), } },
    ModelInner = new GuiduuidMArrayD21MI
{
    Id = 4,
    Value = 
new System.Guid[,] { {
Guid.Parse("17d8f6fb-544e-4bdf-a03f-f453be0e8457"),
Guid.Parse("73dac9b0-ee13-4e19-8ac6-f51f4c2b1456"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("d8408e6c-78b6-497c-bbf6-aad1c4ed8fd0"),
Guid.Parse("47d37641-a49b-417b-8cb3-086b581568d3"), } },
},
            new GuiduuidMArrayD2E1M
{
    Id = 13,
    Value = 
new System.Guid[,] { {
Guid.Parse("66d665e6-db27-4fdd-95c2-413a3771013b"),
Guid.Parse("a0c6653c-a3ab-4cd7-873a-ce0215e2f9a2"), } },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMArrayD2E1M
{
    Id = 15,
    Value = 
new System.Guid[,] { {
Guid.Parse("89a8e5aa-d4a1-495a-9771-8a29a8dc18ee"),
Guid.Parse("bd59da71-4670-432a-8a41-b3d13659e75e"), } },
    ModelInner = new GuiduuidMArrayD21MI
{
    Id = 7,
    Value = 
new System.Guid[,] { {
Guid.Parse("76ecb592-00b1-42f6-9e1c-91456ad29ae2"),
Guid.Parse("c6c3980c-1bd2-44e6-8704-e105e7e3702d"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("3e9e7959-7f18-423f-96a1-991d70150b73"),
Guid.Parse("7cd33052-5093-4ad3-ab1f-fdb2111fbb5f"), } },
},
            new GuiduuidMArrayD2E1M
{
    Id = 16,
    Value = 
new System.Guid[,] { {
Guid.Parse("a0347232-d3f0-461a-9058-60fdea2a2d59"),
Guid.Parse("8e97268b-907a-4e00-99fe-23a31174fa61"), } },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("4fc77e38-0133-48ea-81c7-95c3d8e84341"),
Guid.Parse("93610360-f5c7-4ffa-adad-7cea21282dfa"), } },
},
            new GuiduuidMArrayD2E1M
{
    Id = 24,
    Value = 
new System.Guid[,] { {
Guid.Parse("71a81029-ca4d-4674-bf04-28952c110df9"),
Guid.Parse("4001b1af-8f02-48d8-b900-d1d924b35c2b"), } },
    ModelInner = new GuiduuidMArrayD21MI
{
    Id = 11,
    Value = 
new System.Guid[,] { {
Guid.Parse("bc92615c-4109-481a-a9aa-b1f454f989c5"),
Guid.Parse("ec4a6939-a52e-4066-8569-9f0acb49ae4b"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMArrayD2E1M
{
    Id = 28,
    Value = 
new System.Guid[,] { {
Guid.Parse("bbe852df-6e5f-4b39-94fe-52f975b90857"),
Guid.Parse("54c64bbb-2aec-470a-ad6a-aeee9ebe4c21"), } },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMArrayD2E1M
{
    Id = 32,
    Value = 
new System.Guid[,] { {
Guid.Parse("e11069e6-bcb1-4195-b7e6-1913e1527760"),
Guid.Parse("838affb2-b560-42e4-b03a-e44334c082eb"), } },
    ModelInner = new GuiduuidMArrayD21MI
{
    Id = 13,
    Value = 
new System.Guid[,] { {
Guid.Parse("bb1fe351-4e68-4f55-a28f-97a427ad908a"),
Guid.Parse("2cbfe8b6-b46b-4ca4-8614-b2bd02facfab"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("cfcda314-52cb-47e4-a553-00e2a7dd6495"),
Guid.Parse("23fc83e7-72a9-401e-889b-b53f8effdcbb"), } },
},
            new GuiduuidMArrayD2E1M
{
    Id = 39,
    Value = 
new System.Guid[,] { {
Guid.Parse("587cb2c7-5f1b-40d0-b13d-6ce7fb3158d1"),
Guid.Parse("88400b9e-7f58-4629-95a8-61dab451376e"), } },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMArrayD2E1M
{
    Id = 45,
    Value = 
new System.Guid[,] { {
Guid.Parse("08d52e3f-2999-4e14-beb4-3b1623cbb30e"),
Guid.Parse("07fbd1dd-e8fc-44e7-9c8d-76b33d2c5515"), } },
    ModelInner = new GuiduuidMArrayD21MI
{
    Id = 18,
    Value = 
new System.Guid[,] { {
Guid.Parse("ad688469-91bd-4f31-9420-78bd5fc30f34"),
Guid.Parse("22d53a1a-095f-494f-92eb-b4af7767218f"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("3236e56b-540b-4432-85e2-a16ed6889c8b"),
Guid.Parse("c9df5ca2-478e-423f-ade3-7f07a2eb9544"), } },
},
    NullableValue = null,
},
            new GuiduuidMArrayD2E1M
{
    Id = 46,
    Value = 
new System.Guid[,] { {
Guid.Parse("e9f07b75-cf97-42f7-affa-be8a5818bf5e"),
Guid.Parse("686cf20d-3d38-4d67-90e9-f7a40ec083a5"), } },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMArrayD2E1M
{
    Id = 51,
    Value = 
new System.Guid[,] { {
Guid.Parse("9dcb35cc-a41e-4a20-a841-4b770b5a9b17"),
Guid.Parse("fb62b0c4-1f30-4177-8f62-72dccb10fac0"), } },
    ModelInner = new GuiduuidMArrayD21MI
{
    Id = 22,
    Value = 
new System.Guid[,] { {
Guid.Parse("41a7ec0d-3571-4d5b-a800-20f4a9d2cf7c"),
Guid.Parse("76d39485-cec0-4f7a-80ea-88fd7a2dd4d1"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("0c2ed3da-e647-4ddf-af46-d967839e3882"),
Guid.Parse("1ac1dffc-0001-4096-8d6e-4f45ee5c6e93"), } },
},
    NullableValue = null,
},
            new GuiduuidMArrayD2E1M
{
    Id = 58,
    Value = 
new System.Guid[,] { {
Guid.Parse("a5f848d0-7fef-4253-b7f0-6f3195aaf321"),
Guid.Parse("7322f8c3-3f57-476c-85d5-e710bc80d727"), } },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("f7a95645-cf7b-4ad1-b098-7205236f1e44"),
Guid.Parse("2336660a-f81e-48c8-862a-609ffcc04be1"), } },
},
            new GuiduuidMArrayD2E1M
{
    Id = 66,
    Value = 
new System.Guid[,] { {
Guid.Parse("12f14b90-d60c-43f6-9cee-e7523bd58117"),
Guid.Parse("b96b41bb-9ad8-4e4a-9889-af2ec811b679"), } },
    ModelInner = new GuiduuidMArrayD21MI
{
    Id = 30,
    Value = 
new System.Guid[,] { {
Guid.Parse("b4b6223c-d760-4e10-8f16-e9f792e7868a"),
Guid.Parse("0bcbea84-77c6-491d-b77a-a25286f617d5"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("ea7bb1df-9ca9-4c96-a1bb-151dca7152e8"),
Guid.Parse("6c775352-a043-454e-b074-0e1623280eba"), } },
},
    NullableValue = null,
},
            new GuiduuidMArrayD2E1M
{
    Id = 70,
    Value = 
new System.Guid[,] { {
Guid.Parse("30175e2d-71c2-4cac-9811-298a683c103b"),
Guid.Parse("4b0606f9-1cfe-4572-8ab1-99ae30840fe4"), } },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMArrayD2E1M
{
    Id = 78,
    Value = 
new System.Guid[,] { {
Guid.Parse("555fe912-06be-4c82-8bc0-f188a7944fba"),
Guid.Parse("12aa8a72-e7c9-4937-a320-4917f7c4a9e4"), } },
    ModelInner = new GuiduuidMArrayD21MI
{
    Id = 39,
    Value = 
new System.Guid[,] { {
Guid.Parse("1680adfc-1064-4f58-a44d-c0f60b707f75"),
Guid.Parse("e09c4d78-3e4e-4f03-a953-f32cac4bf116"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMArrayD2E1M
{
    Id = 87,
    Value = 
new System.Guid[,] { {
Guid.Parse("9ae2d657-ee97-4bba-91e7-6ba674a4225c"),
Guid.Parse("379357a1-cade-4d66-a0eb-f65f12bbed82"), } },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("bbf5ae5e-91e6-4eab-abe0-5e29c132965d"),
Guid.Parse("e1c63e07-8084-4694-aa84-f68d1e9b727e"), } },
},
            new GuiduuidMArrayD2E1M
{
    Id = 91,
    Value = 
new System.Guid[,] { {
Guid.Parse("35bd64c7-d4d3-463a-8f5e-2c31041ce6d0"),
Guid.Parse("2295d47f-3337-464f-af90-16cce97a9e0d"), } },
    ModelInner = new GuiduuidMArrayD21MI
{
    Id = 41,
    Value = 
new System.Guid[,] { {
Guid.Parse("a6f0ced1-5ac9-4172-b768-8de5c9bd4025"),
Guid.Parse("3664f5f9-648a-47db-bc89-385c9bfb91c3"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("b30ff427-4cc4-427f-93f5-7c19e4289491"),
Guid.Parse("f7113f51-d6f4-4e8d-bf7b-7d9766a07886"), } },
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("d2c6fc3f-96cc-4981-826b-d151772f9803"),
Guid.Parse("04baefec-a135-4708-9666-86ecfce26d9a"), } },
},
            new GuiduuidMArrayD2E1M
{
    Id = 96,
    Value = 
new System.Guid[,] { {
Guid.Parse("a67059e7-12b5-4edb-b61d-99cf6b1a15e9"),
Guid.Parse("9d9844e9-2994-48c9-9bf1-6c331982248a"), } },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("c6134fcd-4c47-4e8f-9ce7-5cc64127f3c3"),
Guid.Parse("d6f06fec-b68a-4f28-b339-ba0715adc73c"), } },
},
            new GuiduuidMArrayD2E1M
{
    Id = 97,
    Value = 
new System.Guid[,] { {
Guid.Parse("5935eb21-df3d-434f-bb97-f50c467ab676"),
Guid.Parse("ea44d450-456e-4c80-87f1-bd313b01b7bb"), } },
    ModelInner = new GuiduuidMArrayD21MI
{
    Id = 46,
    Value = 
new System.Guid[,] { {
Guid.Parse("806bf3a7-fd80-4733-95e2-8fdb1f328968"),
Guid.Parse("044f0090-507c-4325-8e5a-ffcf9232f69e"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("12ecf9b7-8215-409a-a1b3-2756a94cbf53"),
Guid.Parse("58e6d1ea-b33c-4623-92a0-61cd55a6e46a"), } },
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("08318c3b-47bc-4c3c-800e-dd706b209327"),
Guid.Parse("a5158779-2bad-46b3-b830-56d28a7d6f2e"), } },
},
            new GuiduuidMArrayD2E1M
{
    Id = 106,
    Value = 
new System.Guid[,] { {
Guid.Parse("8c050636-ff47-41a0-965a-91f821e06f19"),
Guid.Parse("ba8828dc-c0ea-46c8-a4bb-0eba380ae06b"), } },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("6df1e401-d7d6-4d8b-b8db-7d84cc15f1c2"),
Guid.Parse("a422c164-0fe3-4fbb-9f4d-1b121dc475a4"), } },
},
            new GuiduuidMArrayD2E1M
{
    Id = 110,
    Value = 
new System.Guid[,] { {
Guid.Parse("27b565c5-05e4-4474-b3b0-2c9b91e73afa"),
Guid.Parse("8535e0e5-8141-49ed-aa54-60e4ec000b7b"), } },
    ModelInner = new GuiduuidMArrayD21MI
{
    Id = 48,
    Value = 
new System.Guid[,] { {
Guid.Parse("20ac5e82-ddb9-4f94-b96b-f69e736fe38e"),
Guid.Parse("87673b72-b798-431e-8d4c-f548fce33a1b"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMArrayD2E1M
{
    Id = 115,
    Value = 
new System.Guid[,] { {
Guid.Parse("64f8e145-3f93-4b08-be13-0320f14529ae"),
Guid.Parse("d83f358b-37c5-41cf-a028-6d603fd1f4bd"), } },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("5b05f374-f9f6-4665-a000-2ac10929836b"),
Guid.Parse("dbc9a907-ffd6-43b0-937b-faaca17b1183"), } },
},
            new GuiduuidMArrayD2E1M
{
    Id = 123,
    Value = 
new System.Guid[,] { {
Guid.Parse("646ce232-a8df-40c4-aec4-8a4a92deae3d"),
Guid.Parse("ae91630a-ffb0-4c6b-a483-7c85493957e8"), } },
    ModelInner = new GuiduuidMArrayD21MI
{
    Id = 55,
    Value = 
new System.Guid[,] { {
Guid.Parse("0ab7f6ad-c5fb-4f17-b98d-860d30bb762e"),
Guid.Parse("d8131160-6454-46fe-957a-09dd1767354f"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("915defab-5f53-4a33-9997-46c33d65e5c2"),
Guid.Parse("27b343ca-7d30-4156-80ed-e8fca05cfe90"), } },
},
            new GuiduuidMArrayD2E1M
{
    Id = 129,
    Value = 
new System.Guid[,] { {
Guid.Parse("23b7e756-6fc5-41fb-8a6a-297afa3f4492"),
Guid.Parse("49ac8530-dd63-4855-8f2a-2b267cf21203"), } },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("463c0e76-5df6-4186-9f56-f65ae8e0dd75"),
Guid.Parse("11e16bb5-e54e-4e79-ad86-d2c777a14c95"), } },
},
            new GuiduuidMArrayD2E1M
{
    Id = 138,
    Value = 
new System.Guid[,] { {
Guid.Parse("b7012cc9-0f39-4e02-934a-0537b5108cc0"),
Guid.Parse("dd383fb2-0e2a-41e0-ac64-0dd77d51ea39"), } },
    ModelInner = new GuiduuidMArrayD21MI
{
    Id = 60,
    Value = 
new System.Guid[,] { {
Guid.Parse("8bf411fd-1c91-479e-bc0c-6937b95bd213"),
Guid.Parse("b0b9e5dd-dd7e-4b59-afbc-ea78649a9d8b"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("35cbe8ae-7f8d-4707-8fba-b80fd0bddea8"),
Guid.Parse("3d13f90d-c9aa-4bad-aa13-c7adb2ad0a5e"), } },
},
    NullableValue = null,
},
            new GuiduuidMArrayD2E1M
{
    Id = 147,
    Value = 
new System.Guid[,] { {
Guid.Parse("4357222a-f2e6-4776-8f9d-a093e3518715"),
Guid.Parse("37201a43-05e6-4826-9c04-8426b6ed0d82"), } },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("31e1c4cd-5ccd-410a-bcb2-51fa0a1f1f54"),
Guid.Parse("7e89b064-5451-46d2-8513-3b5ee55cdb49"), } },
},
            new GuiduuidMArrayD2E1M
{
    Id = 154,
    Value = 
new System.Guid[,] { {
Guid.Parse("1a468d64-9d38-4c80-a2a6-04033cd79dce"),
Guid.Parse("9300df46-a972-42e0-a241-8ab6f27b5901"), } },
    ModelInner = new GuiduuidMArrayD21MI
{
    Id = 66,
    Value = 
new System.Guid[,] { {
Guid.Parse("7afc3bce-34d4-414f-a7d1-ece80e2178e1"),
Guid.Parse("89dd4cdd-c8dc-4e21-a325-3c9a2abf5fca"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMArrayD2E1M
{
    Id = 158,
    Value = 
new System.Guid[,] { {
Guid.Parse("b8e0c3da-7e60-498a-aa22-f6b13299ebb8"),
Guid.Parse("274543cf-ef9e-405c-83f3-9c09b8744310"), } },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("47d99ac6-c195-4d47-8683-454f855a8db4"),
Guid.Parse("93f93c09-d710-4c64-8b76-86555e2a2ce7"), } },
},
            new GuiduuidMArrayD2E1M
{
    Id = 159,
    Value = 
new System.Guid[,] { {
Guid.Parse("c4c8b44f-0bb7-47b1-b624-8fb862248df8"),
Guid.Parse("9027b4bb-f736-48b2-8c7c-4fc009d1b086"), } },
    ModelInner = new GuiduuidMArrayD21MI
{
    Id = 69,
    Value = 
new System.Guid[,] { {
Guid.Parse("def77688-d368-49d3-901c-7fd061ac2666"),
Guid.Parse("375a013b-2a93-4896-a2c3-9a96f14e4ab1"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("12dfa98e-7058-4840-8bf8-123c32132c99"),
Guid.Parse("ae83fe3c-9b0a-4f1d-a369-7e9c6681cc20"), } },
},
            new GuiduuidMArrayD2E1M
{
    Id = 160,
    Value = 
new System.Guid[,] { {
Guid.Parse("b4038685-2b3f-4fd0-b844-a02f4791de03"),
Guid.Parse("45038beb-41ba-4d0e-8b1c-1be8428f27d3"), } },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMArrayD2E1M
{
    Id = 169,
    Value = 
new System.Guid[,] { {
Guid.Parse("772d027e-e076-41f0-b816-eb524f4bdf13"),
Guid.Parse("d66e44de-187c-4a28-bbc1-13718eeeda67"), } },
    ModelInner = new GuiduuidMArrayD21MI
{
    Id = 75,
    Value = 
new System.Guid[,] { {
Guid.Parse("ef514ca5-8d5c-49bb-80f9-d883da32d9b7"),
Guid.Parse("b7cc3527-a659-4fec-aa47-6b2307730702"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("597e2889-5655-4a5e-801a-4fb2d5cdb592"),
Guid.Parse("d12e38b6-83d4-4e43-863f-efbeb47ff632"), } },
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("2f08dd83-4cee-45f8-9892-00dd7f837058"),
Guid.Parse("0083885c-94bc-4116-9381-d50ae7f3db67"), } },
},
            new GuiduuidMArrayD2E1M
{
    Id = 174,
    Value = 
new System.Guid[,] { {
Guid.Parse("712f0362-b2bc-4e5b-bde9-2f72cd7e8984"),
Guid.Parse("f62f4ee4-3dc5-4f1a-a6ec-e3a89cb006fc"), } },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMArrayD2E1M
{
    Id = 175,
    Value = 
new System.Guid[,] { {
Guid.Parse("50d82d9e-2607-4191-8e16-d5de8eada256"),
Guid.Parse("4de0ce72-513f-427b-946f-d6360b610c6e"), } },
    ModelInner = new GuiduuidMArrayD21MI
{
    Id = 80,
    Value = 
new System.Guid[,] { {
Guid.Parse("b4e94e3f-52b5-43d8-81cd-e8427409ce0d"),
Guid.Parse("c1f37641-95ce-4370-9f3a-d018283a1f43"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("d88dfc6e-7384-41ef-900e-81b29a504a32"),
Guid.Parse("8773fd23-2f38-4988-b863-569587a685b8"), } },
},
            new GuiduuidMArrayD2E1M
{
    Id = 180,
    Value = 
new System.Guid[,] { {
Guid.Parse("08af7369-6267-47c1-8589-203f08297cc8"),
Guid.Parse("3d3816a5-7c6d-4050-8a6f-5254a20d3382"), } },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmarrayd21mi(
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
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2)),
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
INSERT INTO public.guiduuidmarrayd21mi(
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
            queryMapTypes: [typeof(GuiduuidMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2)),
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

                changedRows =  ((IGuidMArrayuuidMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidMArrayuuidMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IGuidMArrayuuidMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidMArrayuuidMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IGuidMArrayuuidMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IGuidMArrayuuidMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IGuidMArrayuuidMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IGuidMArrayuuidMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IGuidMArrayuuidMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IGuidMArrayuuidMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IGuidMArrayuuidMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IGuidMArrayuuidMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IGuidMArrayuuidMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IGuidMArrayuuidMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IGuidMArrayuuidMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IGuidMArrayuuidMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IGuidMArrayuuidMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmarrayd2e1m(
	id,
    value,
    nullablevalue,
    guiduuidmarrayd21mi_id
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
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2)), 
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
                methodParametrName: "guiduuidmarrayd21mi_id", 
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
                changedRows =  ((IGuidMArrayuuidMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IGuidMArrayuuidMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IGuidMArrayuuidMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IGuidMArrayuuidMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmarrayd2e1m(
	id,
    value,
    nullablevalue,
    guiduuidmarrayd21mi_id
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
    guiduuidmarrayd21mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(GuiduuidMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2)),
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

                    nullable =  ((IGuidMArrayuuidMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { {
Guid.Parse("4fc77e38-0133-48ea-81c7-95c3d8e84341"),
Guid.Parse("93610360-f5c7-4ffa-adad-7cea21282dfa"), } }));
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

                    nullable =  ((IGuidMArrayuuidMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable = await ((IGuidMArrayuuidMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
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

                    nullable = await ((IGuidMArrayuuidMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { {
Guid.Parse("cfcda314-52cb-47e4-a553-00e2a7dd6495"),
Guid.Parse("23fc83e7-72a9-401e-889b-b53f8effdcbb"), } }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmarrayd2e1m(
	id,
    value,
    nullablevalue,
    guiduuidmarrayd21mi_id
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
    guiduuidmarrayd21mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(GuiduuidMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2)),
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
                methodParametrName: "guiduuidmarrayd21mi_id", 
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
                nullable =  ((IGuidMArrayuuidMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IGuidMArrayuuidMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
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
                nullable = await ((IGuidMArrayuuidMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IGuidMArrayuuidMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidMArrayD2E1M> models = null;

                models =  ((IGuidMArrayuuidMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IGuidMArrayuuidMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IGuidMArrayuuidMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IGuidMArrayuuidMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidMArrayD2E1M> models = null;

                models = await ((IGuidMArrayuuidMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidMArrayuuidMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidMArrayuuidMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidMArrayuuidMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IGuidMArrayuuidMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IGuidMArrayuuidMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IGuidMArrayuuidMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IGuidMArrayuuidMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IGuidMArrayuuidMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IGuidMArrayuuidMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IGuidMArrayuuidMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IGuidMArrayuuidMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IGuidMArrayuuidMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IGuidMArrayuuidMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IGuidMArrayuuidMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IGuidMArrayuuidMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IGuidMArrayuuidMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IGuidMArrayuuidMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IGuidMArrayuuidMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMArrayD2E1M), typeof(FlatGuiduuidMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2)),
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
FROM public.guiduuidmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMArrayD2E1M>();
                await ((IGuidMArrayuuidMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMArrayD2E1M>();
                ((IGuidMArrayuuidMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2)),
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
FROM public.guiduuidmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IGuidMArrayuuidMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidMArrayuuidMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmarrayd2e1m m
LEFT JOIN public.guiduuidmarrayd21mi mi ON mi.id = m.guiduuidmarrayd21mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2)),
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
                var models = await ((IGuidMArrayuuidMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IGuidMArrayuuidMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMArrayD2E1M), typeof(FlatGuiduuidMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2)),
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
FROM public.guiduuidmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMArrayD2E1M>();
                await ((IGuidMArrayuuidMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMArrayD2E1M>();
                ((IGuidMArrayuuidMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2)),
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
FROM public.guiduuidmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidMArrayuuidMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidMArrayuuidMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmarrayd2e1m m
LEFT JOIN public.guiduuidmarrayd21mi mi ON mi.id = m.guiduuidmarrayd21mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(GuiduuidMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2)),
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
                var models = await ((IGuidMArrayuuidMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IGuidMArrayuuidMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMArrayD2E1M), typeof(FlatGuiduuidMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2)),
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
FROM public.guiduuidmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMArrayD2E1M>();
                await((IGuidMArrayuuidMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
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
FROM public.guiduuidmarrayd2e1m m
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
FROM public.guiduuidmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMArrayD2E1M>();
                await ((IGuidMArrayuuidMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
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
FROM public.guiduuidmarrayd2e1m m
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
FROM public.guiduuidmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMArrayD2E1M>();
                await ((IGuidMArrayuuidMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[16],_testData[34], false);
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
FROM public.guiduuidmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMArrayD2E1M>();
                ((IGuidMArrayuuidMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 174;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
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
FROM public.guiduuidmarrayd2e1m m
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
FROM public.guiduuidmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMArrayD2E1M>();
                 ((IGuidMArrayuuidMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
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
FROM public.guiduuidmarrayd2e1m m
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
FROM public.guiduuidmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMArrayD2E1M>();
                 ((IGuidMArrayuuidMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[32],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2)),
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
FROM public.guiduuidmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IGuidMArrayuuidMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 115;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmarrayd2e1m m
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
FROM public.guiduuidmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatGuiduuidMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatGuiduuidMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmarrayd2e1m m
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
FROM public.guiduuidmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMArrayD2E1M>();
                await ((IGuidMArrayuuidMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.guiduuidmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IGuidMArrayuuidMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmarrayd2e1m m
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
FROM public.guiduuidmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatGuiduuidMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatGuiduuidMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 78;
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
FROM public.guiduuidmarrayd2e1m m
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
FROM public.guiduuidmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMArrayD2E1M>();
                 ((IGuidMArrayuuidMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.guiduuidmarrayd2e1m m
LEFT JOIN public.guiduuidmarrayd21mi mi ON mi.id = m.guiduuidmarrayd21mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2)),
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
                var models = await((IGuidMArrayuuidMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 174;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        GuiduuidMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        GuiduuidMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[33],_testData[34], false);
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
                var models = ((IGuidMArrayuuidMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 13;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        GuiduuidMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        GuiduuidMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMArrayD2E1M), typeof(FlatGuiduuidMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2)),
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
FROM public.guiduuidmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMArrayD2E1M>();
                await((IGuidMArrayuuidMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmarrayd2e1m m
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
FROM public.guiduuidmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMArrayD2E1M>();
                await ((IGuidMArrayuuidMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 169, query1, 123, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.guiduuidmarrayd2e1m m
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
FROM public.guiduuidmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMArrayD2E1M>();
                await ((IGuidMArrayuuidMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 91, query1, 16, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[29],_testData[34], false);
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
FROM public.guiduuidmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMArrayD2E1M>();
                ((IGuidMArrayuuidMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmarrayd2e1m m
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
FROM public.guiduuidmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMArrayD2E1M>();
                 ((IGuidMArrayuuidMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 106, query1, 115, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.guiduuidmarrayd2e1m m
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
FROM public.guiduuidmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMArrayD2E1M>();
                 ((IGuidMArrayuuidMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 169, query1, 110, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[12],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2)),
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
FROM public.guiduuidmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidMArrayuuidMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmarrayd2e1m m
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
FROM public.guiduuidmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 24, query1, 158, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatGuiduuidMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatGuiduuidMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[5],_testData[34], false);
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
FROM public.guiduuidmarrayd2e1m m
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
FROM public.guiduuidmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMArrayD2E1M>();
                await ((IGuidMArrayuuidMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 24, query1, 129, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.guiduuidmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidMArrayuuidMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmarrayd2e1m m
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
FROM public.guiduuidmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 39, query1, 96, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatGuiduuidMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatGuiduuidMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(models[15],_testData[34], false);
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
FROM public.guiduuidmarrayd2e1m m
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
FROM public.guiduuidmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMArrayD2E1M>();
                 ((IGuidMArrayuuidMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 159, query1, 96, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatGuiduuidMArrayD2E1M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.guiduuidmarrayd2e1m m
LEFT JOIN public.guiduuidmarrayd21mi mi ON mi.id = m.guiduuidmarrayd21mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(GuiduuidMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2)),
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
                var models = await((IGuidMArrayuuidMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidMArrayuuidMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 154, 159))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        GuiduuidMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        GuiduuidMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[4],_testData[34], false);
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
                var models = ((IGuidMArrayuuidMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidMArrayuuidMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 32, 32))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        GuiduuidMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        GuiduuidMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        GuiduuidMArrayD2E1M.AssertModel(models[26],_testData[34], false);
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
                await using var cmd = await ((IGuidMArrayuuidMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidMArrayuuidMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 58);
                var models = await ((IGuidMArrayuuidMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(22));

                GuiduuidMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                GuiduuidMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                GuiduuidMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                GuiduuidMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                GuiduuidMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                GuiduuidMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                GuiduuidMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                GuiduuidMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                GuiduuidMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                GuiduuidMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                GuiduuidMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                GuiduuidMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                GuiduuidMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                GuiduuidMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                GuiduuidMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                GuiduuidMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                GuiduuidMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                GuiduuidMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                GuiduuidMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                GuiduuidMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                GuiduuidMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                GuiduuidMArrayD2E1M.AssertModel(models[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidMArrayuuidMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidMArrayuuidMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 154);
                var models =  ((IGuidMArrayuuidMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                GuiduuidMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                GuiduuidMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                GuiduuidMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                GuiduuidMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                GuiduuidMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                GuiduuidMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                GuiduuidMArrayD2E1M.AssertModel(models[6],_testData[34], false);
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
FROM public.binary_guiduuidmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(GuiduuidMArrayD21MIWA),
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
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMArrayD21MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidMArrayuuidMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMArrayD21MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMArrayD21MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidMArrayuuidMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMArrayD21MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(GuiduuidMArrayD21MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMArrayD21MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidMArrayuuidMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMArrayD21MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMArrayD21MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidMArrayuuidMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMArrayD21MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmarrayd21mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(GuiduuidMArrayD21MI),
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
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMArrayD21MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidMArrayuuidMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMArrayD21MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMArrayD21MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidMArrayuuidMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((IGuidMArrayuuidMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMArrayD21MI.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(GuiduuidMArrayD21MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMArrayD21MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMArrayD21MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMArrayD21MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidMArrayuuidMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMArrayD21MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
guiduuidmarrayd21mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(GuiduuidMArrayD2E1M),
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
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2))]
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
FROM public.binary_guiduuidmarrayd2e1m m
LEFT JOIN public.binary_guiduuidmarrayd21mi mi ON mi.id = m.guiduuidmarrayd21mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(GuiduuidMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IGuidMArrayuuidMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IGuidMArrayuuidMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((IGuidMArrayuuidMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    guiduuidmarrayd21mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(GuiduuidMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2)),
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
                var models =  ((IGuidMArrayuuidMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidMArrayuuidMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMArrayD21MIWA), typeof(GuiduuidMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2)),
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
                var models1 = new List<GuiduuidMArrayD21MIWA>();
                var models2 = new List<GuiduuidMArrayD21MIWA>();
                await ((IGuidMArrayuuidMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMArrayD21MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMArrayD21MIWA>();
                var models2 = new List<GuiduuidMArrayD21MIWA>();
                ((IGuidMArrayuuidMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2)),
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
                var models = await ((IGuidMArrayuuidMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidmarrayd21mi
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
                    GuiduuidMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_guiduuidmarrayd21mi
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
                    GuiduuidMArrayD21MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidMArrayD21MIWA), typeof(GuiduuidMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2))]
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
                var models1 = new List<GuiduuidMArrayD21MIWA>();
                var models2 = new List<GuiduuidMArrayD21MIWA>();
                await ((IGuidMArrayuuidMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMArrayD21MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMArrayD21MIWA>();
                var models2 = new List<GuiduuidMArrayD21MIWA>();
                ((IGuidMArrayuuidMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2))]
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
                var models = await ((IGuidMArrayuuidMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidmarrayd21mi
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
                    GuiduuidMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_guiduuidmarrayd21mi
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
                    GuiduuidMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidmarrayd21mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMArrayD21MI), typeof(GuiduuidMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2)),
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
                var models1 = new List<GuiduuidMArrayD21MI>();
                var models2 = new List<GuiduuidMArrayD21MI>();
                await ((IGuidMArrayuuidMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMArrayD21MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMArrayD21MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMArrayD21MI>();
                var models2 = new List<GuiduuidMArrayD21MI>();
                ((IGuidMArrayuuidMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMArrayD21MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMArrayD21MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmarrayd21mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2)),
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
                var models = await ((IGuidMArrayuuidMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMArrayD21MI.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMArrayD21MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidmarrayd21mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(GuiduuidMArrayD21MIWA), typeof(GuiduuidMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2))]
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
                var models1 = new List<GuiduuidMArrayD21MIWA>();
                var models2 = new List<GuiduuidMArrayD21MIWA>();
                await ((IGuidMArrayuuidMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMArrayD21MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMArrayD21MIWA>();
                var models2 = new List<GuiduuidMArrayD21MIWA>();
                ((IGuidMArrayuuidMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmarrayd21mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(GuiduuidMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD2))]
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
                var models = await ((IGuidMArrayuuidMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMArrayD21MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

