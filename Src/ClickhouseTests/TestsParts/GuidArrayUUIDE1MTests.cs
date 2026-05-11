

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
    internal partial interface IGuidMArrayArrayUUID
    {
    }
    
    internal partial class GuidMArrayArrayUUID : IGuidMArrayArrayUUID
    {


#region TestData

        private readonly GuidArrayUUIDE1M[] _testData = new GuidArrayUUIDE1M[]
        {
            new GuidArrayUUIDE1M
{
    Id = 4,
    Value = 
new System.Guid[4]
{
Guid.Parse("0671999b-1095-4f7e-9987-119870e8cbe0"),
Guid.Parse("94fee55c-bb7b-46c8-b66f-8ebefaab586d"),
Guid.Parse("e07ff56b-f38b-4f34-b67e-482cf0a85e0a"),
Guid.Parse("0d53faad-b0a7-4063-a56e-1d91fd193853"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 6,
    Value = 
new System.Guid[4]
{
Guid.Parse("41bd40b3-7c1e-4b1b-865a-66f446e6054e"),
Guid.Parse("2ba791f8-5d88-4c2d-8db3-7a80666e2b5b"),
Guid.Parse("377adfbc-4400-4e86-9d62-b72e6d69862f"),
Guid.Parse("f6035288-bafe-4068-b62a-6d6831c0787b"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("51fe2dc9-2435-4b02-b19c-721b00c6d070"),
Guid.Parse("e9c7ea7f-bf92-4c88-a15a-c0ba6e7b92f4"),
Guid.Parse("b86b7d0d-da18-4b7a-909b-4ed6ac1bf6c4"),
},
},
    NullableValue = null,
},
            new GuidArrayUUIDE1M
{
    Id = 12,
    Value = 
new System.Guid[4]
{
Guid.Parse("2a756b66-c456-4f2e-abac-6e1ba6e4d5ab"),
Guid.Parse("0f31cb46-e972-4958-a533-4e5973684bcb"),
Guid.Parse("b6d99612-31c9-45ae-9951-af80a8fca864"),
Guid.Parse("494f32c2-14e2-436f-b15e-492a6b0edede"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 13,
    Value = 
new System.Guid[3]
{
Guid.Parse("678c8d66-04a7-42b9-a2ab-02a7350e8f8f"),
Guid.Parse("5d4d2e12-46b6-4681-9db1-052cb183bd44"),
Guid.Parse("169707b3-510b-4707-b055-004fca920010"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("7f73d441-19f7-45a9-a6d5-10f33ca440b3"),
Guid.Parse("866e3722-d956-4814-889b-a2a18cb8ca04"),
Guid.Parse("a6e47cb3-158f-4c46-8106-28c94e8ad58c"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("c3b11253-1995-438b-ab64-11db2b781053"),
Guid.Parse("e08f8d21-1a2c-4da4-acec-f4c3d09241d6"),
Guid.Parse("813612a6-b296-4767-9243-c86fd3478ed5"),
},
},
            new GuidArrayUUIDE1M
{
    Id = 17,
    Value = 
new System.Guid[4]
{
Guid.Parse("744dcfd1-7b02-49c5-bd51-3e0c4bdfd2fd"),
Guid.Parse("3229df07-0668-44c4-9ba3-3924a0a18c42"),
Guid.Parse("b033517d-d617-41e0-8026-c05b5c502c7b"),
Guid.Parse("3ce04e2b-5286-42db-940e-6a0ca4b48fc5"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 16,
    Value = 
new System.Guid[3]
{
Guid.Parse("8771fcd7-8512-4f38-a458-57f913b57cf2"),
Guid.Parse("5b7103f9-a934-43b6-a2e1-f9c998d1ae4c"),
Guid.Parse("b8c6d8ef-0ae2-4a4a-9b24-e09a9feafeef"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("80a267c1-9539-4714-b873-9ee520ef5d57"),
Guid.Parse("4c07f30d-d71c-4e4e-a458-10d45836f733"),
Guid.Parse("a22b3a2f-f84d-4fe3-a1df-d55b688657b9"),
Guid.Parse("aecd813d-2d1b-421a-96be-176b45305fa9"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("36dc4a56-d00a-49fa-a4e1-1b8041c74e60"),
Guid.Parse("ef3b7442-ec98-46e2-bce1-b0c20929ca2f"),
Guid.Parse("4c261357-b9e2-4be5-baac-43a259630430"),
},
},
            new GuidArrayUUIDE1M
{
    Id = 20,
    Value = 
new System.Guid[3]
{
Guid.Parse("eec80dc8-a2fa-4801-a46d-d41da7c22612"),
Guid.Parse("62e94809-e5a5-4fe9-bfd6-5501531e5baa"),
Guid.Parse("465a326e-d693-4901-849b-65489c63e1c0"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 20,
    Value = 
new System.Guid[4]
{
Guid.Parse("3c4d826c-0c60-4d7e-8cb6-b6d7cabb7b64"),
Guid.Parse("3eeab571-6d69-4a4d-a65b-94258f58a2eb"),
Guid.Parse("b50c4f72-e936-4575-bda2-f4b6743e4777"),
Guid.Parse("c4214579-f9b8-494b-869a-4ee2b1fc1211"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidArrayUUIDE1M
{
    Id = 22,
    Value = 
new System.Guid[4]
{
Guid.Parse("8bf56313-8a6a-4df8-bacc-aac4296eb9b3"),
Guid.Parse("2a84394c-2965-43ab-9f07-8db884ced512"),
Guid.Parse("65b1b477-927b-4e15-9e04-09f6dcaff1cb"),
Guid.Parse("891cf8f1-d9d2-453d-8969-20b6d09918dd"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 28,
    Value = 
new System.Guid[3]
{
Guid.Parse("f8f4afa5-5473-47eb-903e-5bb8fe47374a"),
Guid.Parse("4ede9ca4-b572-422b-8d9f-e8671f110f8f"),
Guid.Parse("281e70bc-d5cc-4357-8290-35acc0b83148"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidArrayUUIDE1M
{
    Id = 29,
    Value = 
new System.Guid[3]
{
Guid.Parse("944e2979-e14f-4981-a3e8-8accb6179cf0"),
Guid.Parse("56a22d06-d403-4142-8027-a704365e487a"),
Guid.Parse("05fd0f9f-5a08-4579-89ef-b26861205eb0"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 34,
    Value = 
new System.Guid[4]
{
Guid.Parse("f95947e7-abb6-4771-883f-5e17b82fefd4"),
Guid.Parse("53ffc75a-3cbc-478b-bd51-1823e3651405"),
Guid.Parse("e5af1ac1-d360-45b3-8e5f-ce6a5d469292"),
Guid.Parse("6b353e09-c0c8-478e-9fa2-e4913d792b21"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("6f609f02-ebbd-4c45-a664-b34f735f0639"),
Guid.Parse("c8b275f7-f56d-419f-bb05-a440bd02b7f3"),
Guid.Parse("2fac2175-9717-43f6-8faf-085dcb7181dc"),
},
},
    NullableValue = null,
},
            new GuidArrayUUIDE1M
{
    Id = 31,
    Value = 
new System.Guid[4]
{
Guid.Parse("d073d4a5-ecc8-4108-82b8-834a2b5a5f87"),
Guid.Parse("f9620ca6-2c1b-4285-b8ae-b6c5b59cc728"),
Guid.Parse("83c40f5b-feff-4c7e-8cb5-b8bbfd24b524"),
Guid.Parse("59500ef5-a212-44f9-967b-148fed79c1ae"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 36,
    Value = 
new System.Guid[4]
{
Guid.Parse("76985283-6005-412f-b40b-70328d90975d"),
Guid.Parse("4a5e5fd0-a30f-4eb3-86a3-a6fa1f5459dd"),
Guid.Parse("f2a4312f-8abe-4c85-8ca4-4780d860f9ca"),
Guid.Parse("15c9a557-fbe9-437e-bc77-4f4ba251561a"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidArrayUUIDE1M
{
    Id = 32,
    Value = 
new System.Guid[3]
{
Guid.Parse("a6d6842c-db78-4438-96b0-ba2d1cb4ab41"),
Guid.Parse("6743fd28-8b8c-4a11-8bec-a5932ebcb5a2"),
Guid.Parse("6a9ab0d9-1428-487f-adaa-f593b1133284"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 41,
    Value = 
new System.Guid[3]
{
Guid.Parse("528c2f87-2f1b-4382-8081-9cbfa54d997d"),
Guid.Parse("a89d5299-472b-42e7-936d-caf6916f23ca"),
Guid.Parse("6885a6c6-1aec-4f17-8d4b-f26af82c0c39"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("55cb8f20-63cb-43f9-b708-5c4965909f9a"),
Guid.Parse("4d5b0ddf-7e2f-42b8-823f-04b61a1cadac"),
Guid.Parse("2c75e233-37f8-456f-ac37-c0f8861bdf47"),
Guid.Parse("4aa0a18c-8a1e-4412-b801-6eee830103bb"),
},
},
            new GuidArrayUUIDE1M
{
    Id = 40,
    Value = 
new System.Guid[3]
{
Guid.Parse("306125c7-8709-4431-808d-43e42cf4ad76"),
Guid.Parse("48d48a4c-cd5a-4d6f-bcad-32ab391883f3"),
Guid.Parse("7d80a677-2ae5-4a23-a005-1e816e313d07"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 44,
    Value = 
new System.Guid[3]
{
Guid.Parse("d641b74f-a5f7-465a-8bc6-6e59e8487b95"),
Guid.Parse("77880548-b4fe-4fec-8bab-bf3184850616"),
Guid.Parse("785a2c00-d83f-4798-8dbc-13903d1330bd"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("dff87507-6733-4252-8493-f2e3df762a53"),
Guid.Parse("ad8d5c92-f23e-4aff-8f98-17f48b3edc9f"),
Guid.Parse("b18aa786-b3c7-4600-b898-af554208821e"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("d369a446-850d-4d07-bb8b-09a07ff7ffe1"),
Guid.Parse("b3e86eca-ff4b-4e26-bc9a-e8558eb3da4b"),
Guid.Parse("8e4fdf68-75b1-4426-9c50-4a4b27519ec6"),
},
},
            new GuidArrayUUIDE1M
{
    Id = 46,
    Value = 
new System.Guid[4]
{
Guid.Parse("6d34ac5b-3a23-459b-86b3-abcc05d00424"),
Guid.Parse("31e6370c-fe1b-4566-b76e-e8af5532b0d4"),
Guid.Parse("a0b00ca5-c56f-4f82-8eff-d7ce0bffbc3b"),
Guid.Parse("bf91e348-9976-4eb4-a16f-7f2e758f7739"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 48,
    Value = 
new System.Guid[3]
{
Guid.Parse("5d4bb616-5add-4076-93d8-799100018184"),
Guid.Parse("a762729b-f3e3-4ad2-b8fc-9bc29f462a58"),
Guid.Parse("6ab4707f-515e-4bbb-8325-a6e70239a497"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("dcfb619e-6bdb-4a02-9bb2-878620168fff"),
Guid.Parse("fa15c504-56ab-41ca-8251-fe1f95442871"),
Guid.Parse("eec6558d-01fc-4111-bf51-022e008c974e"),
},
},
            new GuidArrayUUIDE1M
{
    Id = 48,
    Value = 
new System.Guid[4]
{
Guid.Parse("bb46d46a-47b0-48ff-bdc9-2978c9767907"),
Guid.Parse("452dc6eb-83c8-43bc-81c5-61dfda2c83df"),
Guid.Parse("4ccb94be-aebc-42d3-b68d-763da80ff530"),
Guid.Parse("948ed698-6188-44f5-a6ae-58e67923b858"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 57,
    Value = 
new System.Guid[3]
{
Guid.Parse("4488a541-5606-4541-8df4-75495a634d50"),
Guid.Parse("a6f3e229-611f-4f96-920e-a5c4fd8efc5c"),
Guid.Parse("5648c515-edc3-45ea-998c-af8a3a9cf1dd"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("c4bc253d-dcc4-42ed-b6b5-dd6fb365b06c"),
Guid.Parse("4434e56f-dfe0-4d72-b78d-916aa80be1ea"),
Guid.Parse("74eb5367-6c0a-47a4-af52-a5a21c3fde45"),
},
},
    NullableValue = null,
},
            new GuidArrayUUIDE1M
{
    Id = 52,
    Value = 
new System.Guid[4]
{
Guid.Parse("a613d8fe-0ba2-4181-9121-4fd7847f2164"),
Guid.Parse("b7cf91ee-1798-4fc8-8708-a676b628b198"),
Guid.Parse("72d06281-6cd1-49fa-969e-97a0c8915415"),
Guid.Parse("b64f368a-1d57-4938-acdf-fa3c18cb99ef"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 61,
    Value = 
new System.Guid[3]
{
Guid.Parse("55f0ac3e-8809-4e23-91da-d3dfd7f211e8"),
Guid.Parse("5c9b2b91-1ff1-4939-bebe-b7f1b3f4bd8e"),
Guid.Parse("43972863-41f3-4c41-b8ab-719206b02a60"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidArrayUUIDE1M
{
    Id = 59,
    Value = 
new System.Guid[3]
{
Guid.Parse("ca4d7da3-1f3a-4774-a8f1-0085410c558b"),
Guid.Parse("7058b93f-674d-4b5b-ae2b-04374df92c87"),
Guid.Parse("54ed53d3-fee9-4140-91bc-dbb4c3db973a"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 63,
    Value = 
new System.Guid[4]
{
Guid.Parse("ce55a81a-68c8-45c8-855b-00fc7bbd3b52"),
Guid.Parse("90434927-0d3f-4789-8aec-0df21555705d"),
Guid.Parse("75e69799-f3c4-4e18-9c53-596afa381fd7"),
Guid.Parse("4a71741f-69c3-4314-85ae-d72e06ff1be7"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidArrayUUIDE1M
{
    Id = 66,
    Value = 
new System.Guid[3]
{
Guid.Parse("02c5de4e-3b80-44d3-aa7b-07ff2898fe2a"),
Guid.Parse("7120bc29-407e-44b5-989a-14d2230187cb"),
Guid.Parse("0f8dfe08-79a3-44d8-8ea2-2138a236ab81"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 68,
    Value = 
new System.Guid[4]
{
Guid.Parse("90201db8-5855-47e7-948b-e83d91b61eb2"),
Guid.Parse("5f095c42-cfdd-4503-8254-6eace1c41ecf"),
Guid.Parse("45bacac3-8ed0-47a8-ada4-dbbe675f128c"),
Guid.Parse("482fb352-f651-4a32-937e-dddeedfefa83"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidArrayUUIDE1M
{
    Id = 72,
    Value = 
new System.Guid[3]
{
Guid.Parse("a34639e7-1daa-418a-ac18-79a6afb75a3c"),
Guid.Parse("d62dca6f-1f07-4b35-b5ac-40950e7cfa3c"),
Guid.Parse("42c2c6ef-f48f-466c-8d7a-070cd2c6f394"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 71,
    Value = 
new System.Guid[4]
{
Guid.Parse("1f204e48-0206-45d3-be27-96268f9e268e"),
Guid.Parse("7e232383-1a95-4972-aae0-b71562a308cd"),
Guid.Parse("71987c45-d0e1-4399-9723-524696346a5b"),
Guid.Parse("e3c24052-aad8-473d-a6bf-9c83d713fe23"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("fbd779d5-b795-4b25-b6da-d1744f48b360"),
Guid.Parse("704caf7d-40d4-4039-9a2d-5569839a6660"),
Guid.Parse("2cb0867c-c801-4dab-8ef5-98f4d25c5381"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("8a74c068-8b44-4312-ac68-95851684c659"),
Guid.Parse("99236087-683f-4abd-a51a-68609634324a"),
Guid.Parse("f7d1f92d-4731-41e7-bfea-fce2bc4ca094"),
Guid.Parse("9dd142af-697b-4a10-b51c-11e4e8678f15"),
},
},
            new GuidArrayUUIDE1M
{
    Id = 73,
    Value = 
new System.Guid[3]
{
Guid.Parse("60dc9df8-9ee0-420b-8454-e3d77eac62b8"),
Guid.Parse("0c33ab9b-32a0-4b8d-85a8-81995441b371"),
Guid.Parse("e54162d4-b52f-47b9-8598-8e261274eb8c"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 77,
    Value = 
new System.Guid[4]
{
Guid.Parse("c40ef8a8-1ea4-4c35-ac32-bf9704773b21"),
Guid.Parse("cd1c33de-5dfd-45be-bc24-1f4e5befee1b"),
Guid.Parse("cb71454d-7cfe-42d7-a6f1-a77917c07a21"),
Guid.Parse("af0899f8-5656-4dcd-af66-e8ab8a9b1a05"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("3a5e6dbe-c7ed-4e00-85c5-d5afc02a1021"),
Guid.Parse("26c173e2-30cd-4932-beb9-cabb01fedd29"),
Guid.Parse("04588552-5029-4181-96d0-f0be8baf1f94"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("62382734-41d8-4367-a2da-9e1b40f5ee7f"),
Guid.Parse("c4284726-ddf0-4de9-b238-f193fda1c3b9"),
Guid.Parse("ca1705ca-ab79-43f6-8e3e-644657474ff2"),
Guid.Parse("0ac79920-0ded-499a-b33c-9706e08f77bd"),
},
},
            new GuidArrayUUIDE1M
{
    Id = 74,
    Value = 
new System.Guid[4]
{
Guid.Parse("e92a5882-5882-4140-8391-49bcc2eda8cc"),
Guid.Parse("f642f3e1-0f74-46b5-a6ca-ddbcea3d3ba6"),
Guid.Parse("e5bd5f9c-8d64-4773-bae7-cce2a1e8ca0f"),
Guid.Parse("e944010a-e7b5-49ca-b287-c52e3eb1955f"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 79,
    Value = 
new System.Guid[3]
{
Guid.Parse("a3beda6e-8685-4be4-bb50-f04a05f017e8"),
Guid.Parse("e8c45c5f-9613-417b-bed7-c32c13674e59"),
Guid.Parse("65c4b11c-1acc-4943-92a7-05ed26a3e215"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidArrayUUIDE1M
{
    Id = 77,
    Value = 
new System.Guid[3]
{
Guid.Parse("8e517384-24cd-4ea1-956f-0fe6c8b99b4d"),
Guid.Parse("1843ce1f-fbab-4f49-b5f9-e22a08b71069"),
Guid.Parse("e8eac6e1-070d-4854-9104-80171d1d4e9a"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 87,
    Value = 
new System.Guid[4]
{
Guid.Parse("eb9c448b-0b0f-4eb1-b937-79b02dd1b63f"),
Guid.Parse("2406f2e5-fbea-475c-8681-6de92e0a28ae"),
Guid.Parse("fda66a4b-f512-4512-ba98-9b065dece668"),
Guid.Parse("5848a40c-c383-48bd-b3eb-084ca1700168"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("239782b9-f024-4292-939a-fbf44b35e05f"),
Guid.Parse("04d41831-41ae-4551-b10f-e13194df0b78"),
Guid.Parse("7d78be3b-79a4-4088-9705-e93a4ad4a613"),
},
},
            new GuidArrayUUIDE1M
{
    Id = 80,
    Value = 
new System.Guid[3]
{
Guid.Parse("11a078a5-83f5-4520-be35-5d223acb49f9"),
Guid.Parse("4bbc5da5-3282-4666-aa92-a59b1dd5878b"),
Guid.Parse("cc3c4b2c-a987-4b48-870d-6540cfb85c87"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 91,
    Value = 
new System.Guid[3]
{
Guid.Parse("185eef5e-4037-44fe-a9bd-5425750f19cf"),
Guid.Parse("855fe9f1-8e41-4130-8744-1d5a157843a7"),
Guid.Parse("1672f2af-8103-4254-813c-f8ae05d3899d"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("3b2eb2a0-5ac8-4824-b294-94607715a8f3"),
Guid.Parse("621dc936-4547-4a50-a916-64a0dd9d72ef"),
Guid.Parse("20ec7d9a-e17c-43ff-bc0f-56989310daaf"),
Guid.Parse("26d8b9ce-7689-4bcf-8703-2ee880918535"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("3bef2a00-4f6a-4d7e-8199-ba76946466ae"),
Guid.Parse("a7aa94a2-1308-4001-ab7b-73802d387889"),
Guid.Parse("a8f0c49c-cddf-4606-92a7-4e4a538fd898"),
},
},
            new GuidArrayUUIDE1M
{
    Id = 82,
    Value = 
new System.Guid[3]
{
Guid.Parse("9931f473-c450-46e9-aa77-adcf61cd638b"),
Guid.Parse("8ba3ce59-4454-4b40-a6f5-30f0e968fb72"),
Guid.Parse("d44e0550-f390-4c92-923d-31ff596ef96c"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 92,
    Value = 
new System.Guid[3]
{
Guid.Parse("9747e543-010c-4ee1-b152-295e803b8f59"),
Guid.Parse("7b83a870-6764-4878-b471-4889cae0ffc8"),
Guid.Parse("3d2b6fc8-ccf9-4816-a8c9-1cdf05f67d57"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("70d1a7bb-b38b-459f-8977-7d166b7924b4"),
Guid.Parse("deeec50f-84a0-41e2-8545-3ea67f2b33ea"),
Guid.Parse("cded2326-412f-4497-89bc-c43f1c989b2c"),
Guid.Parse("dc23f5d8-9cf2-473e-9cbc-168687a896f1"),
},
},
    NullableValue = null,
},
            new GuidArrayUUIDE1M
{
    Id = 87,
    Value = 
new System.Guid[4]
{
Guid.Parse("f54022e9-6079-4180-904b-b50c21a47358"),
Guid.Parse("16792fa5-3422-456a-b4e9-df9feccc2f4f"),
Guid.Parse("b420f7e0-449b-49b0-992d-b40e79690b75"),
Guid.Parse("66482dcc-5f20-4f43-a10a-b9bf9bf754ac"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 101,
    Value = 
new System.Guid[4]
{
Guid.Parse("a30be53f-b08c-4239-a60d-0cb39e6db727"),
Guid.Parse("cd7421e5-d5ff-48a9-92e4-cb93a21ca394"),
Guid.Parse("218a889a-730f-4540-be08-41286361b84d"),
Guid.Parse("6628ec5c-30ab-4b58-b17c-0cbe2781155e"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("d287485a-313c-43b4-a666-d3b16f7ad523"),
Guid.Parse("4ed82474-c520-47e4-a80f-8de859d07ec6"),
Guid.Parse("4196b731-2252-4dfb-91f2-2090336e4edd"),
},
},
    NullableValue = null,
},
            new GuidArrayUUIDE1M
{
    Id = 94,
    Value = 
new System.Guid[4]
{
Guid.Parse("c74bb44b-4895-4dcf-ad68-a46a6fb51068"),
Guid.Parse("b6399342-310e-45d9-b3ad-9815d72d487d"),
Guid.Parse("9ea9d319-6c72-4030-9319-fa3c578dd1c6"),
Guid.Parse("2732997e-9487-4072-9314-47107d4708ac"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 104,
    Value = 
new System.Guid[3]
{
Guid.Parse("c590a59d-be41-47f1-ab54-42648a591329"),
Guid.Parse("6b70ea33-b3b6-452b-9d8a-4da6c7122719"),
Guid.Parse("88f9dcc5-14b9-4cae-bd60-68feb55b6d3a"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidArrayUUIDE1M
{
    Id = 96,
    Value = 
new System.Guid[3]
{
Guid.Parse("1dea2755-8843-473d-8bc3-3ee13f3efc6e"),
Guid.Parse("cb3b26b6-7166-436d-85e2-67b49f37dc83"),
Guid.Parse("2edbc355-6d9f-49e8-a6c0-073c64aedf9f"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 111,
    Value = 
new System.Guid[4]
{
Guid.Parse("a43c729b-5673-4d6e-9f49-3cb18b8a0ed1"),
Guid.Parse("441eb12c-b47a-4d3a-ad1d-ebd57c7a484a"),
Guid.Parse("aa8d042b-551e-48b4-96f1-e2d0b375d476"),
Guid.Parse("ca9b7b81-f666-4616-a4ac-ec8991dab7ce"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("cfabb0c7-ad1f-4d3f-a3cb-dfce652aa405"),
Guid.Parse("a2b45bcf-fb74-4cff-8993-c9b564e456a0"),
Guid.Parse("7825c101-bda9-4b18-9533-606128b41823"),
Guid.Parse("00be96c3-aa9c-4770-b1b2-f47f08a1c687"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("d7926b20-f89c-4ae5-9c02-264c559152e6"),
Guid.Parse("b36c3c9c-58dc-41a4-a589-b7a8a73df5f6"),
Guid.Parse("0ce98ea3-cef3-4098-92b4-6c68f200296d"),
},
},
            new GuidArrayUUIDE1M
{
    Id = 101,
    Value = 
new System.Guid[3]
{
Guid.Parse("d4a8191d-8f71-4b6f-a1fe-92ecca18a6ee"),
Guid.Parse("6fead175-0edc-4d7f-8bff-9182d5cb86a9"),
Guid.Parse("76ccbe9c-d0b5-4af1-bc4d-024263da6b2e"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 116,
    Value = 
new System.Guid[3]
{
Guid.Parse("b6c4567f-d188-4255-9bd8-87e052a16c9e"),
Guid.Parse("dcc02680-2f4b-47d1-8ba2-a2899387db6a"),
Guid.Parse("1b26eb11-42e4-4758-8bd5-bdead78ec8ba"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidArrayUUIDE1M
{
    Id = 103,
    Value = 
new System.Guid[3]
{
Guid.Parse("d24041ff-b142-446e-b859-8397cfe77827"),
Guid.Parse("3c7fa0ff-0553-44d4-ad9c-9c2f8bfcb6d4"),
Guid.Parse("d46960ef-25fd-4337-9b35-312f7c9e2bbe"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 123,
    Value = 
new System.Guid[4]
{
Guid.Parse("c3ef4278-38bc-4f3c-adbf-d58b00239b89"),
Guid.Parse("8226320c-15d4-4e4b-9e15-05a80bf7d6cd"),
Guid.Parse("52292d95-8d32-4de3-81a1-77cde1462ff8"),
Guid.Parse("e9ab4c80-ff10-4d67-8dc5-80f5f6c0e776"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("95259d02-7577-4c3e-a80f-0a277f58538f"),
Guid.Parse("494c3b9f-3380-4d9e-8284-322dec3f2a03"),
Guid.Parse("77016efe-d0f4-4541-b227-a28e3811a3fb"),
},
},
            new GuidArrayUUIDE1M
{
    Id = 106,
    Value = 
new System.Guid[4]
{
Guid.Parse("b4dd5bd9-b13b-4470-b3a0-6284764d1f4b"),
Guid.Parse("44610e25-7831-4f22-83c5-16c749ca7e3c"),
Guid.Parse("9871983c-4db9-4c90-90d7-3d870077216a"),
Guid.Parse("a2bc7e59-c69a-4c6d-8935-b1ef11f7ebe5"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 125,
    Value = 
new System.Guid[3]
{
Guid.Parse("93a34b7c-40fc-4319-b1cb-ca50c51bd343"),
Guid.Parse("6ab520be-c327-479b-937c-d1aea3217ba9"),
Guid.Parse("2a95df90-831c-4a9c-a1c5-cd00dac2d25f"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("fdd41c97-31f1-4093-aaa9-da200bd6a268"),
Guid.Parse("d65e6e64-1f8a-4e26-91aa-bfe54716725b"),
Guid.Parse("ce8a8ac0-5897-48c2-b477-8316ef228683"),
},
},
    NullableValue = null,
},
            new GuidArrayUUIDE1M
{
    Id = 113,
    Value = 
new System.Guid[3]
{
Guid.Parse("e15b441e-36ef-4fad-8ffd-bc2f8d219943"),
Guid.Parse("ff94b348-a2bc-4729-aaee-b04291e28378"),
Guid.Parse("067668b8-ae23-4690-b87d-cfb4d3d6172f"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 131,
    Value = 
new System.Guid[4]
{
Guid.Parse("f8164dc0-9176-4103-824e-14e51c899cc8"),
Guid.Parse("ae26aa8e-5283-420a-bff4-234c624d29f6"),
Guid.Parse("670df561-f463-4e1c-a484-5881c8669d4f"),
Guid.Parse("529661e2-6b46-4417-9f6c-544c339a6a27"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidArrayUUIDE1M
{
    Id = 115,
    Value = 
new System.Guid[3]
{
Guid.Parse("baf77c07-12a1-448a-8060-c3db9a43d913"),
Guid.Parse("edd56768-11ec-486c-8ae0-46a0546e068a"),
Guid.Parse("d87479bc-9ae0-4a28-985a-270cb1d785ab"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 139,
    Value = 
new System.Guid[3]
{
Guid.Parse("9ac25c9f-75d2-4834-b6a7-4badf5bb3088"),
Guid.Parse("8b284898-5aa3-483b-b82a-bc744873460a"),
Guid.Parse("4ec0c574-76e7-462f-9659-9273904fbc45"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("db9909da-a515-4cb9-9f19-c026275f9daa"),
Guid.Parse("af4e5d63-97e9-4427-a453-fb49d1ed58fa"),
Guid.Parse("c2544486-256b-4714-ab0e-8cf5e76feb59"),
Guid.Parse("c19fd61b-94f1-46cf-a3fa-da5590a0c638"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("159b885e-3b2d-4b0f-9aff-9d8fd569d7a0"),
Guid.Parse("ed781840-4780-49fb-bbe6-26bb25ed051f"),
Guid.Parse("780cb0b8-a28e-46f9-9c4b-b55c8a696514"),
},
},
            new GuidArrayUUIDE1M
{
    Id = 116,
    Value = 
new System.Guid[3]
{
Guid.Parse("1746b3c0-aa11-478e-8be4-963a13e9f1c4"),
Guid.Parse("1a18f957-8455-425b-b7df-a901325dc221"),
Guid.Parse("96e33af7-93db-4ced-8269-31458006905c"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 140,
    Value = 
new System.Guid[3]
{
Guid.Parse("a868c38d-12a2-4c42-afd1-a6ae7e1ca26f"),
Guid.Parse("da84dd9b-8daf-4a64-add8-5fffc8dbe88c"),
Guid.Parse("efa23979-8cd8-4b4e-85b2-5d05e604deca"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("77391da4-c4b6-4f4c-b37d-55a4a8c30d6a"),
Guid.Parse("98dbd1e8-5c2e-4243-ac4c-bc6bfea5a2fd"),
Guid.Parse("53243b24-9e1c-4a01-9bd1-0b6d2a4cbfa1"),
Guid.Parse("fd632934-4ea4-49ea-8d60-d6acb715808a"),
},
},
    NullableValue = null,
},
            new GuidArrayUUIDE1M
{
    Id = 124,
    Value = 
new System.Guid[3]
{
Guid.Parse("179ed496-51eb-408e-a43c-3673817bd8a0"),
Guid.Parse("31f37362-1896-40db-bffa-7585d3965215"),
Guid.Parse("a0d6faa6-a7af-478f-8298-142e7000aea4"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 147,
    Value = 
new System.Guid[3]
{
Guid.Parse("7ad9028e-7ae2-4a07-ba90-cfec5de75de0"),
Guid.Parse("9e671d65-373b-4cc2-b112-a08d7ce73592"),
Guid.Parse("cc29aaa1-f265-4427-9457-73fe9ca107cf"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidArrayUUIDE1M
{
    Id = 128,
    Value = 
new System.Guid[3]
{
Guid.Parse("57754a4b-3243-42dd-bd88-6ec8ed81cbee"),
Guid.Parse("0e9bf990-56c9-40ee-9a2f-3c21629e538c"),
Guid.Parse("0ea781cf-7b6f-4e39-8fc8-1a413fcc69e1"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 154,
    Value = 
new System.Guid[4]
{
Guid.Parse("d12e6305-5ce6-4454-9fc7-d889d33f1782"),
Guid.Parse("362a3eb5-faa9-4248-800c-c8508c422c06"),
Guid.Parse("6b015d28-c50e-4346-ad54-82f1c7c12d45"),
Guid.Parse("7ed0ade0-2424-4482-b0ad-f323ae3c4cff"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("c1c4f89f-d9c8-4436-915c-2d2496524581"),
Guid.Parse("c0ccf95a-0257-456f-91a2-ed17217c8f92"),
Guid.Parse("8044641c-c806-44e4-be78-dc4f42410daf"),
Guid.Parse("e90070f7-5df8-4e26-92dd-545b049ef8b1"),
},
},
            new GuidArrayUUIDE1M
{
    Id = 132,
    Value = 
new System.Guid[3]
{
Guid.Parse("7ff6cedf-099c-4c61-a378-d142659bf99c"),
Guid.Parse("38d9c8c6-fe88-4899-8310-db371b695575"),
Guid.Parse("0c9ddfcb-2ff2-4055-8b87-340ca00cea2d"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 159,
    Value = 
new System.Guid[4]
{
Guid.Parse("685a3014-8475-475c-a013-a755a6ee8314"),
Guid.Parse("afb41d2d-26d4-46e3-8c6f-32f3d5194b6a"),
Guid.Parse("de4bf29d-e161-4364-afcb-1c23b43b8f71"),
Guid.Parse("61b21ae2-67e8-4514-a956-eee0f9893ddd"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("b3a60404-bc1e-4293-9cfc-41db4b0b283e"),
Guid.Parse("09d9907a-7c62-4600-bf2b-7f160e075879"),
Guid.Parse("93a5e5cc-ada8-4eec-86bd-ed28d41831f4"),
Guid.Parse("0538a96f-1d62-4747-ab86-133fd43100ca"),
},
},
    NullableValue = null,
},
            new GuidArrayUUIDE1M
{
    Id = 137,
    Value = 
new System.Guid[4]
{
Guid.Parse("727105a8-fc21-4e16-9e98-051c4e502416"),
Guid.Parse("be040859-6fdd-400d-8ddb-2c5f6e0b6a23"),
Guid.Parse("ba82b32d-1576-4b54-b413-1deb1bb762ba"),
Guid.Parse("ab98e6d7-b370-4f71-86c0-5d40d6a0f224"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 162,
    Value = 
new System.Guid[3]
{
Guid.Parse("326829fa-67c9-4fca-be3b-8629714edc69"),
Guid.Parse("5ff1e7c1-2dba-4263-9daf-6563041bf235"),
Guid.Parse("2d358861-abd6-4ec9-9c55-707efe0a9a20"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("fa4a161f-af14-4f32-8a31-c91591280f95"),
Guid.Parse("6cdade86-6f69-46c1-a686-9e866fa5b8fe"),
Guid.Parse("c153a226-3e2d-425c-94c4-cf7ae0b13fcd"),
},
},
            new GuidArrayUUIDE1M
{
    Id = 138,
    Value = 
new System.Guid[4]
{
Guid.Parse("dc055ed6-8251-4220-b9ec-2aa797642ae8"),
Guid.Parse("e30a1c4e-6867-4863-8250-e8228e58fc0a"),
Guid.Parse("cbdddce2-1fbd-4ac1-8b02-182aae1815d8"),
Guid.Parse("d900e385-6928-45cd-90df-a5c76089dc76"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 171,
    Value = 
new System.Guid[4]
{
Guid.Parse("de700046-abc5-47a6-a82a-901939cf521a"),
Guid.Parse("35d6830e-d067-4ede-bb2d-9200bc113d25"),
Guid.Parse("0feb13f7-dbdc-454c-83a4-29eb4a1a3e50"),
Guid.Parse("36c4131d-f54c-48f3-8872-a82c5ba4e25b"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("5ad0159f-4b29-4619-89f2-cd2b9cd0df10"),
Guid.Parse("5037a05d-c64e-48ec-9d4b-e49bf9c294d9"),
Guid.Parse("698281cd-01be-4ba8-8450-3e81a9a31362"),
Guid.Parse("793e583e-be69-4d10-906b-55e9ce4e6f68"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("ed448e40-6c00-40af-8483-de914bb3efaa"),
Guid.Parse("334b5778-d201-4dca-a305-d2717faa345c"),
Guid.Parse("bc5a5f94-24f3-4f6e-982a-3dd198d2c78b"),
Guid.Parse("c9492953-d9b0-4efe-b90a-8eb7a69f156e"),
},
},
            new GuidArrayUUIDE1M
{
    Id = 142,
    Value = 
new System.Guid[3]
{
Guid.Parse("5b5e8b09-3dcb-4404-9a7e-d1b15682298d"),
Guid.Parse("1b1eab17-ce33-4846-8e45-0d8282080428"),
Guid.Parse("9d832aab-e53e-4c0b-8a9a-f5b86567a0d4"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 174,
    Value = 
new System.Guid[4]
{
Guid.Parse("c367cf15-2460-4e20-bcb0-f06fb03a6058"),
Guid.Parse("c85271ae-6136-483a-9e38-7908255e9091"),
Guid.Parse("2e14f02b-59ce-4469-931d-9f4715aacbc1"),
Guid.Parse("dba8d259-f5b7-4a09-883b-f491e6c8f201"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("56c53f91-6ac1-4bff-8b68-78c54a5e5e91"),
Guid.Parse("422b69d2-1fd7-41a1-bde5-f2f4e8f5887e"),
Guid.Parse("17df6790-cb57-4a44-b633-3c8f1bd7541d"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("8d0ddf9c-1540-448b-87b4-fc4dfab9e45b"),
Guid.Parse("ab98ee91-66bc-429d-8d66-bdb2eb56592d"),
Guid.Parse("d7cc69a5-0494-4c0b-9b8e-772b793e5b5e"),
Guid.Parse("dd4dcd88-3933-4db5-9a36-4bc5cabe19f2"),
},
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.guidarrayuuide1m(
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
            asPartInterface: typeof(IGuidMArrayArrayUUID)),
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
                    await ((IGuidMArrayArrayUUID)this).InsertModelDbConnectionAsync(
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
                     ((IGuidMArrayArrayUUID)this).InsertModelDbConnection(
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
FROM gedaqtests.guidarrayuuide1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(GuidArrayUUIDE1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayArrayUUID)),
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
                    var models = await ((IGuidMArrayArrayUUID)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    GuidArrayUUIDE1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IGuidMArrayArrayUUID)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    GuidArrayUUIDE1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

