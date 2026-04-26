

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
    internal partial interface IGuidListuuidArray
    {
    }
    
    internal partial class GuidListuuidArray : IGuidListuuidArray
    {


#region TestData

        private readonly GuiduuidArray2M[] _testData = new GuiduuidArray2M[]
        {
            new GuiduuidArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("09d345f4-cff3-4248-8d6d-678769ac6c91"),

Guid.Parse("69dacb1e-172a-457b-8491-96eea59c4a0c"),

Guid.Parse("82a7dfa6-6bce-43cd-b94e-417c521178b9"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("226d1eab-9b80-4250-b3f0-41c57e378c6a"),

Guid.Parse("f4f9a4c5-517a-4722-b4ad-f0e513b55859"),

Guid.Parse("680e7a3c-32d8-4daf-80e8-363d3d7d7967"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("326b39fa-415e-499f-a738-6f608adb3cb1"),

Guid.Parse("7b674400-8e70-406d-b53b-ba8235785575"),

Guid.Parse("3cd5a094-1ab7-4ee3-9447-4e726386fa02"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c46ab384-d8d7-4924-8ac5-e9de5290ac4f"),

Guid.Parse("005a326f-bcb6-41b1-a830-8ed5d322d3f3"),

Guid.Parse("e5f49be7-f4f9-4065-adfa-3121dcdc3992"),

Guid.Parse("6c0a6592-4945-45c7-bf64-c7b9320938d6"),

},
},
            new GuiduuidArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("50aa5a54-3449-49ad-a2ea-d5a3db884a71"),

Guid.Parse("4984acc1-df54-4baf-927b-c977368cf461"),

Guid.Parse("8280a3db-e7d8-4f01-b3c1-097c56467c7e"),

Guid.Parse("082d9328-6f61-4c04-828b-b1f6c301f20c"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("71204960-3fb5-478b-8813-80c2c7e03957"),

Guid.Parse("09d7febe-38ab-4380-a8dc-3af0b4304402"),

Guid.Parse("8ced8b4c-bf4b-4d34-8857-a0a47f54bd84"),

Guid.Parse("9b04d880-b422-4b49-835c-4a06b6483d39"),

},
},
            new GuiduuidArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9856b068-2ed1-44e6-8eb5-0bc1f3061b60"),

Guid.Parse("38b58aab-ab54-4184-a30e-c7d54cb7fa02"),

Guid.Parse("727c8730-8962-4eef-ad2a-e9bc8ebf6608"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e7663b7f-d1ca-4fd7-a038-79ab50ee1fb2"),

Guid.Parse("ac4c951b-d25c-4d12-91bb-0d2a3fb75e0f"),

Guid.Parse("d4e8f022-353e-4be2-8530-7811af14d7dc"),

Guid.Parse("66e2d92e-3b73-4ae4-af1a-3b9dcb41276c"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("99a12713-fe6d-422e-ab6c-4a8d0c16fcc5"),

Guid.Parse("e9ea3dd8-ef4c-4299-a8d7-88097163416d"),

Guid.Parse("a7af58a6-b664-4288-a32c-a9634cadc7b5"),

},
},
            new GuiduuidArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3eecffdc-4e73-497c-bb57-0ce6404419c3"),

Guid.Parse("445de5e4-57a0-4b04-af7a-589e5a0a9844"),

Guid.Parse("f9fc0d7a-6e9d-4810-b9f5-97f41dc2585c"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f951a31c-e50d-4703-8265-a361a595933d"),

Guid.Parse("f883733d-e102-40c5-a9bc-7c51b8c1368e"),

Guid.Parse("cb14da81-57f0-49b9-a13f-71d0baad87d0"),

Guid.Parse("a5346883-5840-43f0-b8f0-5b68985ddfb8"),

},
},
            new GuiduuidArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("46f72404-3caa-4ce4-bc7d-6b4e6c0b0b2f"),

Guid.Parse("a1b8aea5-8856-4b78-9490-a2b9b7b532e6"),

Guid.Parse("74fcd5fd-9c33-4972-bfcf-2ed34042b21a"),

Guid.Parse("19e1c82d-f6c0-49f9-88d8-6ec5045c1de6"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("da689db4-5e77-4f7f-8698-974862cdcf85"),

Guid.Parse("2ecdf850-9b95-4c08-8c37-b1188786d86a"),

Guid.Parse("950038ee-9b4c-4aec-8c8b-9206bc4049e3"),

Guid.Parse("4da97984-526c-4a5b-8c81-353e82d2052a"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("9c577cce-4f40-431f-b379-a5905dd43a31"),

Guid.Parse("390c839e-c2e6-4897-b868-928bf0919f09"),

Guid.Parse("46edf82b-0671-4d2b-a31d-33c2b7eae50e"),

Guid.Parse("a17852b3-cf3c-42a9-bcb4-83cdbd45c57e"),

},
},
            new GuiduuidArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("44e9faed-c74e-4f38-be51-314af742e2da"),

Guid.Parse("7ad830b9-1b28-4aa5-bf64-4d4d396d24c4"),

Guid.Parse("54530d29-b9f5-4571-98e0-a2d653b039b7"),

Guid.Parse("7002798a-2790-47ed-b754-b5029c4a0179"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("52551cd4-6af5-4588-a695-d5894182ed10"),

Guid.Parse("94700d8a-6bbe-4fe0-85e8-58d6f9bfe1ae"),

Guid.Parse("ae4a19fe-56c0-4cec-81ff-e951c17da36f"),

},
},
            new GuiduuidArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("1f5960d7-84b2-472f-8f71-f07cfe733f44"),

Guid.Parse("a8653c4c-bd6c-46c0-afd8-f056eb30764a"),

Guid.Parse("7dc74758-18d4-40fb-b7b1-b0c300c15f04"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("47016e45-af5b-4980-8ac6-2539108330da"),

Guid.Parse("06a97ffa-028e-4dfd-b2cd-f04bf1a18822"),

Guid.Parse("9ff86dd9-9a0f-4d8a-a048-6bf4fe6481e4"),

Guid.Parse("72c3665e-2811-4066-8d07-6aac6ea1d877"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("381c2c01-530d-4cb4-88e9-07ad420bdf3b"),

Guid.Parse("034748bf-947d-4e29-bf92-765a6b17d88a"),

Guid.Parse("e73b01c4-33e5-4ec3-8062-c81d6b143a12"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a7158582-687f-4287-b4ca-cbb025da6c30"),

Guid.Parse("7264a3f6-8318-469f-92c0-4c95800302fe"),

Guid.Parse("04a2b8a8-9ef7-459c-9bfd-73682caae91e"),

Guid.Parse("36f509bb-6a2b-4541-bed1-79d6a9e6041d"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("cb88e7de-1244-40c3-984c-47c2228feb14"),

Guid.Parse("af49b82d-2d09-4156-90db-d659cb2624ba"),

Guid.Parse("ce4f4202-9da3-4549-a22f-c832d709f865"),

Guid.Parse("b7ee3889-bd70-4353-8d18-b8897e130999"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("381ce36f-e01d-45fc-9cb6-7aeaa74340ba"),

Guid.Parse("efbb5442-fc7b-4643-b462-8c12b2ca6ccb"),

Guid.Parse("379a6acb-8a60-41ca-ac88-b6969c0c5aa7"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("58750ef3-adde-4a2e-a477-1e29bfe9ab4a"),

Guid.Parse("7992d2ad-fecf-4d9b-9675-d40abe897109"),

Guid.Parse("85faf7d1-9d87-4a84-a513-9c9c959b93ec"),

Guid.Parse("af6a1ce6-ce89-43b5-b993-3a9be61e6f0a"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2b960115-80ad-40c5-bfcc-34646a73b0d6"),

Guid.Parse("156ba992-3fa4-4c51-8362-170b2f7122c4"),

Guid.Parse("e1b89d26-619d-48c6-a079-ac43d0ec9733"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("2ef34b15-1b36-4bac-8d82-82a38d4b509a"),

Guid.Parse("574841b8-081b-4cb8-b782-7d4acb9052e6"),

Guid.Parse("4f73cd19-cd2c-429b-b699-2d168bf78248"),

Guid.Parse("6e37c6cf-7c11-4598-9166-2cefbf42c770"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5c0b929b-aaab-4a8c-b893-7a85c02526ce"),

Guid.Parse("c54322bd-41b8-4930-b068-560806a76a4c"),

Guid.Parse("46bd65d8-b871-4c46-9b2c-8a9e7a2fcbc1"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f5e6cd1c-3d92-4276-81ca-332396aac9b1"),

Guid.Parse("d5f81e64-cd57-4091-b3cc-5521acb90762"),

Guid.Parse("8137b49b-f3e3-423e-ab4e-63919efd082f"),

Guid.Parse("766c8289-9fff-450b-9124-b9ea76a9a4b9"),

},
},
            new GuiduuidArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("0461cd50-7ab3-4494-9164-61d5ca2e4838"),

Guid.Parse("8742bdfd-cf60-4085-abc1-0d24e53e2d6d"),

Guid.Parse("13a9fabe-751f-45e6-ab8f-5c8161c5f3b5"),

Guid.Parse("e4604a09-1d7d-4acf-9695-ffda4f288449"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ae9606d0-1434-45cd-a157-c2bb42c7e063"),

Guid.Parse("b9f2418f-2b30-4648-916b-b08a0e8fe8e6"),

Guid.Parse("1f331195-2b9b-4811-b655-5921aac7f58c"),

Guid.Parse("7eaa8db9-251e-43c9-af46-106aaa394845"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f9ce4587-753f-402f-8db9-4c8a4345392d"),

Guid.Parse("41f43585-e7b6-41a5-8d6e-dd297e83ff60"),

Guid.Parse("a161be98-8808-4019-b71d-13faf723e312"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c6b04c0a-26de-434d-a3e6-7865b33e6425"),

Guid.Parse("c99d4851-a84f-4eeb-aeba-003f00121800"),

Guid.Parse("96dbf8f3-d5cb-47a1-80a1-176cbe9df895"),

},
},
            new GuiduuidArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5b99bdd0-5eaa-47ac-9903-0eb23f066200"),

Guid.Parse("1ce9c90e-0847-40be-a40f-fdd63171b49b"),

Guid.Parse("b083700e-1c81-4277-9d94-143138dacd26"),

Guid.Parse("0389c1f1-9955-43bd-ba44-55d11a7b5cfc"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("8afedf5c-0f69-4910-8d81-89923aa8a554"),

Guid.Parse("eb4e18f1-746a-4edc-9360-d8eac00db9f7"),

Guid.Parse("9c0d92ea-d223-4186-a702-fb55ea35b3b1"),

Guid.Parse("1929a7fb-0f5a-4ca4-922e-0f29591fcbe8"),

},
},
            new GuiduuidArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b2707bcc-26ad-4c14-9238-65815bc5d449"),

Guid.Parse("fab16f0b-456f-4fa1-876b-057a6dc2c98d"),

Guid.Parse("282d1412-2e0c-4a2a-b76d-ab4d29969e54"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0a9d55ec-8eae-4fc9-a7aa-3fc0ad96e87f"),

Guid.Parse("a5bee6c7-587b-41c7-b8b0-6759c6552358"),

Guid.Parse("63c9031b-62d1-4da4-80c6-2119ee14b2e9"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f1238e5d-1851-45f1-b797-171400b7e06d"),

Guid.Parse("bc179108-6dd7-48cc-ae10-1dc0867b9a4a"),

Guid.Parse("07654fd4-9861-498b-b302-67ca9aaddefc"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3c879f44-5bd4-4fd3-98ab-db53befb8cdf"),

Guid.Parse("ca425e22-bca3-4d34-bdf2-0b551e73cf00"),

Guid.Parse("b4d5e245-17dc-42c1-b9ae-af14c177828b"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("a7af5e59-caee-4ca5-b872-8eadfbeb4773"),

Guid.Parse("22388cdd-3d8a-49fb-b723-c753faa054b8"),

Guid.Parse("57b29eac-2c9a-4d5b-bb9a-a627fe8351d4"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ffc02f89-216a-4642-81c4-749fdb2410af"),

Guid.Parse("013cc869-7f3b-4e7c-a19c-0555f523ea3a"),

Guid.Parse("2c573cea-4d2c-4ca1-9658-ca23d337cb6b"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("6b3fe640-1c5c-4d88-81eb-08bbd393e89f"),

Guid.Parse("d9456e23-2b24-4840-8bbd-f808958a40e8"),

Guid.Parse("b27acf7f-ee22-4f86-b5b4-93974bd9a386"),

Guid.Parse("5cec6a4d-3dd7-4975-8726-e525a1946216"),

},
},
            new GuiduuidArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("6460dc69-e52d-4c77-8105-f28765184b1b"),

Guid.Parse("287bc75b-9213-4841-bdce-bc189400d872"),

Guid.Parse("cfec4186-5779-4f13-84a2-d95e361ab269"),

Guid.Parse("6e9d4d8a-69cd-463e-bdce-a674d456e1a4"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("dc3744dd-ef05-4853-9bfe-e6bde42d97cd"),

Guid.Parse("dcd97f87-7851-4a68-adc3-aa20c4f4bc3d"),

Guid.Parse("80f37003-172d-4623-b376-418671d118f9"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fa6faa77-2260-45f4-ba70-6212605a2c8b"),

Guid.Parse("5a0006ef-1347-497f-abeb-f28a7f662d67"),

Guid.Parse("13b262b1-4c84-401c-ad95-56c977b39a6a"),

Guid.Parse("96390780-0b0b-4a55-8bc3-f91268adc4ae"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2a019682-77c5-4392-bfa4-9b270758658d"),

Guid.Parse("fc5f944e-69dd-431a-b043-77def6f06d83"),

Guid.Parse("0977bbb0-dde5-4df9-b4a8-e663a213a43d"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a62be1c9-a12b-4431-ad00-5c0827f16812"),

Guid.Parse("60a6b396-8fd1-444e-b07c-3918759caec2"),

Guid.Parse("24f6d03c-be84-4e82-ae1e-c76c09c7a847"),

Guid.Parse("e6b1a1a2-675b-4bea-a611-e45bbd8a7154"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("1f915e7a-db79-4186-8e5e-022a7bcedba3"),

Guid.Parse("961844ec-9a04-4db6-a5db-8ee6ee47f0b5"),

Guid.Parse("6a8a3d78-6f9f-4b33-9f88-9db42d72bfaf"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("66beaab9-647f-47e6-9b8b-faea65690510"),

Guid.Parse("5dff6fd7-0f47-4ca6-a56a-c06843c2c0fc"),

Guid.Parse("bd56e04a-836d-4a5f-b014-67c8e53c4540"),

Guid.Parse("e1a656da-71e4-4211-a1eb-829dec0dce43"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("40cbe433-2697-4575-9abd-916007fed079"),

Guid.Parse("7331ee35-f3e1-4994-af07-8732146496f6"),

Guid.Parse("3216f2af-709e-4ca3-8e50-5098699bf776"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4a6efe3a-ea75-47c1-bd5f-62b6dc0c8672"),

Guid.Parse("d38116c1-0495-4d81-a37a-6df0d477ef71"),

Guid.Parse("2853e3de-6132-4aa4-83eb-ea79ea45541d"),

},
},
            new GuiduuidArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d0f0790b-b8d7-409f-844d-877d7673b694"),

Guid.Parse("8aeb93f1-ab0d-4c2b-adf9-de774f307f77"),

Guid.Parse("6f60700b-b343-4ad1-8dd6-11d3825074e1"),

Guid.Parse("9f977b00-a4dd-4cc3-b293-5007ddc62a80"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5a5529a2-9083-4770-a107-9aebb5bcbe24"),

Guid.Parse("46cdc18b-e352-4385-a5d6-b2cb4db293cc"),

Guid.Parse("d1d244c0-6223-4611-b9b5-86c2a78f3e74"),

Guid.Parse("b7795acb-4b84-4da4-a26f-f65ffa445682"),

},
},
            new GuiduuidArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("586481a5-41f7-496a-bf01-5c2433f01383"),

Guid.Parse("a0f8ed85-a946-4ed5-9169-93d56917a10e"),

Guid.Parse("6819f957-80f9-4883-a4a2-080eea7a66fd"),

Guid.Parse("3aeb6800-fe5e-4906-804f-d897b83daa1c"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("8b6bb383-2516-49bf-9e74-44460f63f7d7"),

Guid.Parse("034a0f61-628b-4b91-a556-7bcd93ba26d9"),

Guid.Parse("94f86158-2385-4daa-b938-d26c82d35402"),

Guid.Parse("20a962ac-4252-4529-9460-bb325c8fe7b6"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f47f69b8-b39f-4eff-9f16-be84ab04479f"),

Guid.Parse("3328520b-937c-4177-8bf9-b1d4919da180"),

Guid.Parse("44046090-7b11-4ae2-b97d-792d9fd52718"),

Guid.Parse("e05b966c-4a3e-4f69-b728-83e245d6e0c6"),

},
},
            new GuiduuidArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a7d8dadd-617f-4f02-b693-c75bc9185fe0"),

Guid.Parse("21315386-0ccd-404c-a038-0ef7fffa1529"),

Guid.Parse("27df7e6a-f6ec-4ab1-ab13-6c997117369d"),

Guid.Parse("8ba45ada-af07-458b-8d54-c5e7a3ce45d1"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("27c751e7-0da2-496d-bc29-741848d7d7af"),

Guid.Parse("a5156263-ceda-4fe5-b161-55501081056b"),

Guid.Parse("2467e2a6-7a04-4680-aa7f-1daa679d510d"),

},
},
            new GuiduuidArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("6df3acf6-d139-4224-9755-487ee3f84144"),

Guid.Parse("e0e976b2-e168-4218-8349-d1eaae4cd5d6"),

Guid.Parse("3f6bc3b9-74a8-4a69-8a75-acd6b68b1cbc"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bd98b185-aa11-4d1f-98af-bfdf3ab1a004"),

Guid.Parse("0aa9c708-195d-4f0c-bd03-6d9408856db3"),

Guid.Parse("fa1b324f-275d-4797-96f1-6ec86caf8d0b"),

Guid.Parse("690dd305-b45b-4ff9-910a-97f76ec84205"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("3c439250-d333-46f3-8a54-f0b9102b02d1"),

Guid.Parse("ab49f403-c0a0-495b-9716-3682aef0f3ed"),

Guid.Parse("031f9303-9b2c-4750-a754-aeb6d7160198"),

Guid.Parse("a2adc74b-71e2-4e90-bfcf-5a2a3c620aba"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9afce23f-7e62-47cc-964d-441dc37cc724"),

Guid.Parse("70f2cc0d-0777-406c-b4df-582336cb5199"),

Guid.Parse("a8007619-a16d-4c2e-93b0-3f8aa200e554"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a1b3a41b-03f1-48a0-8435-5bce3119ee67"),

Guid.Parse("8768293e-de26-42c8-8e5c-b6baf64c50b8"),

Guid.Parse("bdf74db2-844e-4fd4-a17b-9987092dd81e"),

Guid.Parse("4965d536-aa77-4ebe-8928-b5d4d6a313b9"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e28ae745-0bb7-4ca0-ab49-c668f39897ff"),

Guid.Parse("4d3463ec-e3c8-4565-bdfc-b77e91034706"),

Guid.Parse("0bc5d12c-16c5-4a85-b052-ad1c44eccd9b"),

Guid.Parse("ceecb491-bd1e-410a-af0c-e7a41454b36b"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f648a0bd-3b6c-46ce-8fc4-1f84a5fcc810"),

Guid.Parse("d2a0aad7-f66f-45d9-9e4c-891f46f97b52"),

Guid.Parse("144e7041-5416-4e1a-83e0-2610bf26186b"),

},
},
            new GuiduuidArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("981599b3-ebb1-4b72-a70e-889524ebf8d9"),

Guid.Parse("ee26b1bf-e110-4225-8151-fe703b3985a7"),

Guid.Parse("6983fd1c-bb84-48d3-8865-063d60b6ea49"),

Guid.Parse("3783d42a-92f8-4374-bfe8-6f45611925a2"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e1693d2e-b586-4295-8b8e-4c7f42e7f386"),

Guid.Parse("259bb4d5-9c04-491c-8fe0-c82bb4284967"),

Guid.Parse("45cd3ab6-b638-49ad-9be8-ce02b127ad3a"),

Guid.Parse("e87cacf8-8172-4e94-a5b3-6d386fa1be41"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4fde5595-1c0b-43bc-8ba0-46901745a5a1"),

Guid.Parse("63a2a419-550c-4acc-8996-cd99acb3af30"),

Guid.Parse("26025525-131f-4602-a474-569c600bf1da"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("3b28ee53-e363-45e3-b31d-f90451f5bc47"),

Guid.Parse("791c5ecb-44fb-43ef-8423-2a8a5a3708c1"),

Guid.Parse("205e4727-80c4-4cef-a9ba-1a3540b94165"),

Guid.Parse("0a66ab61-30ec-4f6b-8560-981e2e941591"),

},
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray2mi(
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
            asPartInterface: typeof(IGuidListuuidArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray2mi(
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
            queryMapTypes: [typeof(GuiduuidArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>), 
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

                changedRows =  ((IGuidListuuidArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidListuuidArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IGuidListuuidArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidListuuidArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IGuidListuuidArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IGuidListuuidArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray2m(
	id,
    value,
    nullablevalue,
    guiduuidarray2mi_id
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
            asPartInterface: typeof(IGuidListuuidArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuidarray2mi_id", 
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
                changedRows =  ((IGuidListuuidArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IGuidListuuidArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IGuidListuuidArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IGuidListuuidArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray2m(
	id,
    value,
    nullablevalue,
    guiduuidarray2mi_id
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
    guiduuidarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(GuiduuidArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray2m(
	id,
    value,
    nullablevalue,
    guiduuidarray2mi_id
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
    guiduuidarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(GuiduuidArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuidarray2mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidArray2M> models = null;

                models =  ((IGuidListuuidArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IGuidListuuidArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IGuidListuuidArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IGuidListuuidArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidArray2M> models = null;

                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray2M), typeof(FlatGuiduuidArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
FROM public.guiduuidarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidArray2M>();
                var models2 = new List<FlatGuiduuidArray2M>();
                await ((IGuidListuuidArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidArray2M>();
                var models2 = new List<FlatGuiduuidArray2M>();
                ((IGuidListuuidArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
FROM public.guiduuidarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IGuidListuuidArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidListuuidArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
                var models = await ((IGuidListuuidArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IGuidListuuidArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray2M), typeof(FlatGuiduuidArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
FROM public.guiduuidarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidArray2M>();
                var models2 = new List<FlatGuiduuidArray2M>();
                await ((IGuidListuuidArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidArray2M>();
                var models2 = new List<FlatGuiduuidArray2M>();
                ((IGuidListuuidArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
FROM public.guiduuidarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidListuuidArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidListuuidArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(GuiduuidArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
                var models = await ((IGuidListuuidArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IGuidListuuidArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray2M), typeof(FlatGuiduuidArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidArray2M>();
                var models2 = new List<FlatGuiduuidArray2M>();
                await((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
                }
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidArray2M>();
                var models2 = new List<FlatGuiduuidArray2M>();
                ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatGuiduuidArray2M.AssertModel(models[0],_testData[4], false);FlatGuiduuidArray2M.AssertModel(models[1],_testData[5], false);FlatGuiduuidArray2M.AssertModel(models[2],_testData[6], false);FlatGuiduuidArray2M.AssertModel(models[3],_testData[7], false);FlatGuiduuidArray2M.AssertModel(models[4],_testData[8], false);FlatGuiduuidArray2M.AssertModel(models[5],_testData[9], false);FlatGuiduuidArray2M.AssertModel(models[6],_testData[10], false);FlatGuiduuidArray2M.AssertModel(models[7],_testData[11], false);FlatGuiduuidArray2M.AssertModel(models[8],_testData[12], false);FlatGuiduuidArray2M.AssertModel(models[9],_testData[13], false);FlatGuiduuidArray2M.AssertModel(models[10],_testData[14], false);FlatGuiduuidArray2M.AssertModel(models[11],_testData[15], false);FlatGuiduuidArray2M.AssertModel(models[12],_testData[16], false);FlatGuiduuidArray2M.AssertModel(models[13],_testData[17], false);FlatGuiduuidArray2M.AssertModel(models[14],_testData[18], false);FlatGuiduuidArray2M.AssertModel(models[15],_testData[19], false);FlatGuiduuidArray2M.AssertModel(models[16],_testData[20], false);FlatGuiduuidArray2M.AssertModel(models[17],_testData[21], false);FlatGuiduuidArray2M.AssertModel(models[18],_testData[22], false);FlatGuiduuidArray2M.AssertModel(models[19],_testData[23], false);FlatGuiduuidArray2M.AssertModel(models[20],_testData[24], false);FlatGuiduuidArray2M.AssertModel(models[21],_testData[25], false);FlatGuiduuidArray2M.AssertModel(models[22],_testData[26], false);FlatGuiduuidArray2M.AssertModel(models[23],_testData[27], false);FlatGuiduuidArray2M.AssertModel(models[24],_testData[28], false);FlatGuiduuidArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatGuiduuidArray2M.AssertModel(models[0],_testData[19], false);FlatGuiduuidArray2M.AssertModel(models[1],_testData[20], false);FlatGuiduuidArray2M.AssertModel(models[2],_testData[21], false);FlatGuiduuidArray2M.AssertModel(models[3],_testData[22], false);FlatGuiduuidArray2M.AssertModel(models[4],_testData[23], false);FlatGuiduuidArray2M.AssertModel(models[5],_testData[24], false);FlatGuiduuidArray2M.AssertModel(models[6],_testData[25], false);FlatGuiduuidArray2M.AssertModel(models[7],_testData[26], false);FlatGuiduuidArray2M.AssertModel(models[8],_testData[27], false);FlatGuiduuidArray2M.AssertModel(models[9],_testData[28], false);FlatGuiduuidArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatGuiduuidArray2M.AssertModel(models[0],_testData[10], false);FlatGuiduuidArray2M.AssertModel(models[1],_testData[11], false);FlatGuiduuidArray2M.AssertModel(models[2],_testData[12], false);FlatGuiduuidArray2M.AssertModel(models[3],_testData[13], false);FlatGuiduuidArray2M.AssertModel(models[4],_testData[14], false);FlatGuiduuidArray2M.AssertModel(models[5],_testData[15], false);FlatGuiduuidArray2M.AssertModel(models[6],_testData[16], false);FlatGuiduuidArray2M.AssertModel(models[7],_testData[17], false);FlatGuiduuidArray2M.AssertModel(models[8],_testData[18], false);FlatGuiduuidArray2M.AssertModel(models[9],_testData[19], false);FlatGuiduuidArray2M.AssertModel(models[10],_testData[20], false);FlatGuiduuidArray2M.AssertModel(models[11],_testData[21], false);FlatGuiduuidArray2M.AssertModel(models[12],_testData[22], false);FlatGuiduuidArray2M.AssertModel(models[13],_testData[23], false);FlatGuiduuidArray2M.AssertModel(models[14],_testData[24], false);FlatGuiduuidArray2M.AssertModel(models[15],_testData[25], false);FlatGuiduuidArray2M.AssertModel(models[16],_testData[26], false);FlatGuiduuidArray2M.AssertModel(models[17],_testData[27], false);FlatGuiduuidArray2M.AssertModel(models[18],_testData[28], false);FlatGuiduuidArray2M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatGuiduuidArray2M.AssertModel(models[0],_testData[4], false);FlatGuiduuidArray2M.AssertModel(models[1],_testData[5], false);FlatGuiduuidArray2M.AssertModel(models[2],_testData[6], false);FlatGuiduuidArray2M.AssertModel(models[3],_testData[7], false);FlatGuiduuidArray2M.AssertModel(models[4],_testData[8], false);FlatGuiduuidArray2M.AssertModel(models[5],_testData[9], false);FlatGuiduuidArray2M.AssertModel(models[6],_testData[10], false);FlatGuiduuidArray2M.AssertModel(models[7],_testData[11], false);FlatGuiduuidArray2M.AssertModel(models[8],_testData[12], false);FlatGuiduuidArray2M.AssertModel(models[9],_testData[13], false);FlatGuiduuidArray2M.AssertModel(models[10],_testData[14], false);FlatGuiduuidArray2M.AssertModel(models[11],_testData[15], false);FlatGuiduuidArray2M.AssertModel(models[12],_testData[16], false);FlatGuiduuidArray2M.AssertModel(models[13],_testData[17], false);FlatGuiduuidArray2M.AssertModel(models[14],_testData[18], false);FlatGuiduuidArray2M.AssertModel(models[15],_testData[19], false);FlatGuiduuidArray2M.AssertModel(models[16],_testData[20], false);FlatGuiduuidArray2M.AssertModel(models[17],_testData[21], false);FlatGuiduuidArray2M.AssertModel(models[18],_testData[22], false);FlatGuiduuidArray2M.AssertModel(models[19],_testData[23], false);FlatGuiduuidArray2M.AssertModel(models[20],_testData[24], false);FlatGuiduuidArray2M.AssertModel(models[21],_testData[25], false);FlatGuiduuidArray2M.AssertModel(models[22],_testData[26], false);FlatGuiduuidArray2M.AssertModel(models[23],_testData[27], false);FlatGuiduuidArray2M.AssertModel(models[24],_testData[28], false);FlatGuiduuidArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.guiduuidarray2m m
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 2)]
        private void DbConnectionSelectModelDynParBatchConfig()
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
                var models = await((IGuidListuuidArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
GuiduuidArray2M.AssertModel(models[0],_testData[14], false);GuiduuidArray2M.AssertModel(models[1],_testData[15], false);GuiduuidArray2M.AssertModel(models[2],_testData[16], false);GuiduuidArray2M.AssertModel(models[3],_testData[17], false);GuiduuidArray2M.AssertModel(models[4],_testData[18], false);GuiduuidArray2M.AssertModel(models[5],_testData[19], false);GuiduuidArray2M.AssertModel(models[6],_testData[20], false);GuiduuidArray2M.AssertModel(models[7],_testData[21], false);GuiduuidArray2M.AssertModel(models[8],_testData[22], false);GuiduuidArray2M.AssertModel(models[9],_testData[23], false);GuiduuidArray2M.AssertModel(models[10],_testData[24], false);GuiduuidArray2M.AssertModel(models[11],_testData[25], false);GuiduuidArray2M.AssertModel(models[12],_testData[26], false);GuiduuidArray2M.AssertModel(models[13],_testData[27], false);GuiduuidArray2M.AssertModel(models[14],_testData[28], false);GuiduuidArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
GuiduuidArray2M.AssertModel(models[0],_testData[10], false);GuiduuidArray2M.AssertModel(models[1],_testData[11], false);GuiduuidArray2M.AssertModel(models[2],_testData[12], false);GuiduuidArray2M.AssertModel(models[3],_testData[13], false);GuiduuidArray2M.AssertModel(models[4],_testData[14], false);GuiduuidArray2M.AssertModel(models[5],_testData[15], false);GuiduuidArray2M.AssertModel(models[6],_testData[16], false);GuiduuidArray2M.AssertModel(models[7],_testData[17], false);GuiduuidArray2M.AssertModel(models[8],_testData[18], false);GuiduuidArray2M.AssertModel(models[9],_testData[19], false);GuiduuidArray2M.AssertModel(models[10],_testData[20], false);GuiduuidArray2M.AssertModel(models[11],_testData[21], false);GuiduuidArray2M.AssertModel(models[12],_testData[22], false);GuiduuidArray2M.AssertModel(models[13],_testData[23], false);GuiduuidArray2M.AssertModel(models[14],_testData[24], false);GuiduuidArray2M.AssertModel(models[15],_testData[25], false);GuiduuidArray2M.AssertModel(models[16],_testData[26], false);GuiduuidArray2M.AssertModel(models[17],_testData[27], false);GuiduuidArray2M.AssertModel(models[18],_testData[28], false);GuiduuidArray2M.AssertModel(models[19],_testData[29], false);
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
                var models = ((IGuidListuuidArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 132;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
GuiduuidArray2M.AssertModel(models[0],_testData[28], false);GuiduuidArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
GuiduuidArray2M.AssertModel(models[0],_testData[20], false);GuiduuidArray2M.AssertModel(models[1],_testData[21], false);GuiduuidArray2M.AssertModel(models[2],_testData[22], false);GuiduuidArray2M.AssertModel(models[3],_testData[23], false);GuiduuidArray2M.AssertModel(models[4],_testData[24], false);GuiduuidArray2M.AssertModel(models[5],_testData[25], false);GuiduuidArray2M.AssertModel(models[6],_testData[26], false);GuiduuidArray2M.AssertModel(models[7],_testData[27], false);GuiduuidArray2M.AssertModel(models[8],_testData[28], false);GuiduuidArray2M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray2M), typeof(FlatGuiduuidArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionMMDynQuerySelectModelConfig()
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidArray2M>();
                var models2 = new List<FlatGuiduuidArray2M>();
                await((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
                }
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidArray2M>();
                var models2 = new List<FlatGuiduuidArray2M>();
                ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 58, query1, 66, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatGuiduuidArray2M.AssertModel(models[0],_testData[12], false);FlatGuiduuidArray2M.AssertModel(models[1],_testData[13], false);FlatGuiduuidArray2M.AssertModel(models[2],_testData[14], false);FlatGuiduuidArray2M.AssertModel(models[3],_testData[15], false);FlatGuiduuidArray2M.AssertModel(models[4],_testData[16], false);FlatGuiduuidArray2M.AssertModel(models[5],_testData[17], false);FlatGuiduuidArray2M.AssertModel(models[6],_testData[18], false);FlatGuiduuidArray2M.AssertModel(models[7],_testData[19], false);FlatGuiduuidArray2M.AssertModel(models[8],_testData[20], false);FlatGuiduuidArray2M.AssertModel(models[9],_testData[21], false);FlatGuiduuidArray2M.AssertModel(models[10],_testData[22], false);FlatGuiduuidArray2M.AssertModel(models[11],_testData[23], false);FlatGuiduuidArray2M.AssertModel(models[12],_testData[24], false);FlatGuiduuidArray2M.AssertModel(models[13],_testData[25], false);FlatGuiduuidArray2M.AssertModel(models[14],_testData[26], false);FlatGuiduuidArray2M.AssertModel(models[15],_testData[27], false);FlatGuiduuidArray2M.AssertModel(models[16],_testData[28], false);FlatGuiduuidArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatGuiduuidArray2M.AssertModel(models[0],_testData[14], false);FlatGuiduuidArray2M.AssertModel(models[1],_testData[15], false);FlatGuiduuidArray2M.AssertModel(models[2],_testData[16], false);FlatGuiduuidArray2M.AssertModel(models[3],_testData[17], false);FlatGuiduuidArray2M.AssertModel(models[4],_testData[18], false);FlatGuiduuidArray2M.AssertModel(models[5],_testData[19], false);FlatGuiduuidArray2M.AssertModel(models[6],_testData[20], false);FlatGuiduuidArray2M.AssertModel(models[7],_testData[21], false);FlatGuiduuidArray2M.AssertModel(models[8],_testData[22], false);FlatGuiduuidArray2M.AssertModel(models[9],_testData[23], false);FlatGuiduuidArray2M.AssertModel(models[10],_testData[24], false);FlatGuiduuidArray2M.AssertModel(models[11],_testData[25], false);FlatGuiduuidArray2M.AssertModel(models[12],_testData[26], false);FlatGuiduuidArray2M.AssertModel(models[13],_testData[27], false);FlatGuiduuidArray2M.AssertModel(models[14],_testData[28], false);FlatGuiduuidArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 106, query1, 83, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
FlatGuiduuidArray2M.AssertModel(models[0],_testData[23], false);FlatGuiduuidArray2M.AssertModel(models[1],_testData[24], false);FlatGuiduuidArray2M.AssertModel(models[2],_testData[25], false);FlatGuiduuidArray2M.AssertModel(models[3],_testData[26], false);FlatGuiduuidArray2M.AssertModel(models[4],_testData[27], false);FlatGuiduuidArray2M.AssertModel(models[5],_testData[28], false);FlatGuiduuidArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
FlatGuiduuidArray2M.AssertModel(models[0],_testData[18], false);FlatGuiduuidArray2M.AssertModel(models[1],_testData[19], false);FlatGuiduuidArray2M.AssertModel(models[2],_testData[20], false);FlatGuiduuidArray2M.AssertModel(models[3],_testData[21], false);FlatGuiduuidArray2M.AssertModel(models[4],_testData[22], false);FlatGuiduuidArray2M.AssertModel(models[5],_testData[23], false);FlatGuiduuidArray2M.AssertModel(models[6],_testData[24], false);FlatGuiduuidArray2M.AssertModel(models[7],_testData[25], false);FlatGuiduuidArray2M.AssertModel(models[8],_testData[26], false);FlatGuiduuidArray2M.AssertModel(models[9],_testData[27], false);FlatGuiduuidArray2M.AssertModel(models[10],_testData[28], false);FlatGuiduuidArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.guiduuidarray2m m
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(GuiduuidArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2)]
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((IGuidListuuidArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSelectModelBatchAsync(connection, 64, 58))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
GuiduuidArray2M.AssertModel(models[0],_testData[13], false);GuiduuidArray2M.AssertModel(models[1],_testData[14], false);GuiduuidArray2M.AssertModel(models[2],_testData[15], false);GuiduuidArray2M.AssertModel(models[3],_testData[16], false);GuiduuidArray2M.AssertModel(models[4],_testData[17], false);GuiduuidArray2M.AssertModel(models[5],_testData[18], false);GuiduuidArray2M.AssertModel(models[6],_testData[19], false);GuiduuidArray2M.AssertModel(models[7],_testData[20], false);GuiduuidArray2M.AssertModel(models[8],_testData[21], false);GuiduuidArray2M.AssertModel(models[9],_testData[22], false);GuiduuidArray2M.AssertModel(models[10],_testData[23], false);GuiduuidArray2M.AssertModel(models[11],_testData[24], false);GuiduuidArray2M.AssertModel(models[12],_testData[25], false);GuiduuidArray2M.AssertModel(models[13],_testData[26], false);GuiduuidArray2M.AssertModel(models[14],_testData[27], false);GuiduuidArray2M.AssertModel(models[15],_testData[28], false);GuiduuidArray2M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
GuiduuidArray2M.AssertModel(models[0],_testData[12], false);GuiduuidArray2M.AssertModel(models[1],_testData[13], false);GuiduuidArray2M.AssertModel(models[2],_testData[14], false);GuiduuidArray2M.AssertModel(models[3],_testData[15], false);GuiduuidArray2M.AssertModel(models[4],_testData[16], false);GuiduuidArray2M.AssertModel(models[5],_testData[17], false);GuiduuidArray2M.AssertModel(models[6],_testData[18], false);GuiduuidArray2M.AssertModel(models[7],_testData[19], false);GuiduuidArray2M.AssertModel(models[8],_testData[20], false);GuiduuidArray2M.AssertModel(models[9],_testData[21], false);GuiduuidArray2M.AssertModel(models[10],_testData[22], false);GuiduuidArray2M.AssertModel(models[11],_testData[23], false);GuiduuidArray2M.AssertModel(models[12],_testData[24], false);GuiduuidArray2M.AssertModel(models[13],_testData[25], false);GuiduuidArray2M.AssertModel(models[14],_testData[26], false);GuiduuidArray2M.AssertModel(models[15],_testData[27], false);GuiduuidArray2M.AssertModel(models[16],_testData[28], false);GuiduuidArray2M.AssertModel(models[17],_testData[29], false);
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
                var models = ((IGuidListuuidArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSelectModelBatch(connection, 53, 9))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
GuiduuidArray2M.AssertModel(models[0],_testData[10], false);GuiduuidArray2M.AssertModel(models[1],_testData[11], false);GuiduuidArray2M.AssertModel(models[2],_testData[12], false);GuiduuidArray2M.AssertModel(models[3],_testData[13], false);GuiduuidArray2M.AssertModel(models[4],_testData[14], false);GuiduuidArray2M.AssertModel(models[5],_testData[15], false);GuiduuidArray2M.AssertModel(models[6],_testData[16], false);GuiduuidArray2M.AssertModel(models[7],_testData[17], false);GuiduuidArray2M.AssertModel(models[8],_testData[18], false);GuiduuidArray2M.AssertModel(models[9],_testData[19], false);GuiduuidArray2M.AssertModel(models[10],_testData[20], false);GuiduuidArray2M.AssertModel(models[11],_testData[21], false);GuiduuidArray2M.AssertModel(models[12],_testData[22], false);GuiduuidArray2M.AssertModel(models[13],_testData[23], false);GuiduuidArray2M.AssertModel(models[14],_testData[24], false);GuiduuidArray2M.AssertModel(models[15],_testData[25], false);GuiduuidArray2M.AssertModel(models[16],_testData[26], false);GuiduuidArray2M.AssertModel(models[17],_testData[27], false);GuiduuidArray2M.AssertModel(models[18],_testData[28], false);GuiduuidArray2M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
GuiduuidArray2M.AssertModel(models[0],_testData[1], false);GuiduuidArray2M.AssertModel(models[1],_testData[2], false);GuiduuidArray2M.AssertModel(models[2],_testData[3], false);GuiduuidArray2M.AssertModel(models[3],_testData[4], false);GuiduuidArray2M.AssertModel(models[4],_testData[5], false);GuiduuidArray2M.AssertModel(models[5],_testData[6], false);GuiduuidArray2M.AssertModel(models[6],_testData[7], false);GuiduuidArray2M.AssertModel(models[7],_testData[8], false);GuiduuidArray2M.AssertModel(models[8],_testData[9], false);GuiduuidArray2M.AssertModel(models[9],_testData[10], false);GuiduuidArray2M.AssertModel(models[10],_testData[11], false);GuiduuidArray2M.AssertModel(models[11],_testData[12], false);GuiduuidArray2M.AssertModel(models[12],_testData[13], false);GuiduuidArray2M.AssertModel(models[13],_testData[14], false);GuiduuidArray2M.AssertModel(models[14],_testData[15], false);GuiduuidArray2M.AssertModel(models[15],_testData[16], false);GuiduuidArray2M.AssertModel(models[16],_testData[17], false);GuiduuidArray2M.AssertModel(models[17],_testData[18], false);GuiduuidArray2M.AssertModel(models[18],_testData[19], false);GuiduuidArray2M.AssertModel(models[19],_testData[20], false);GuiduuidArray2M.AssertModel(models[20],_testData[21], false);GuiduuidArray2M.AssertModel(models[21],_testData[22], false);GuiduuidArray2M.AssertModel(models[22],_testData[23], false);GuiduuidArray2M.AssertModel(models[23],_testData[24], false);GuiduuidArray2M.AssertModel(models[24],_testData[25], false);GuiduuidArray2M.AssertModel(models[25],_testData[26], false);GuiduuidArray2M.AssertModel(models[26],_testData[27], false);GuiduuidArray2M.AssertModel(models[27],_testData[28], false);GuiduuidArray2M.AssertModel(models[28],_testData[29], false);
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
                await using var cmd = await ((IGuidListuuidArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 16);
                var models = await ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
GuiduuidArray2M.AssertModel(models[0],_testData[3], false);GuiduuidArray2M.AssertModel(models[1],_testData[4], false);GuiduuidArray2M.AssertModel(models[2],_testData[5], false);GuiduuidArray2M.AssertModel(models[3],_testData[6], false);GuiduuidArray2M.AssertModel(models[4],_testData[7], false);GuiduuidArray2M.AssertModel(models[5],_testData[8], false);GuiduuidArray2M.AssertModel(models[6],_testData[9], false);GuiduuidArray2M.AssertModel(models[7],_testData[10], false);GuiduuidArray2M.AssertModel(models[8],_testData[11], false);GuiduuidArray2M.AssertModel(models[9],_testData[12], false);GuiduuidArray2M.AssertModel(models[10],_testData[13], false);GuiduuidArray2M.AssertModel(models[11],_testData[14], false);GuiduuidArray2M.AssertModel(models[12],_testData[15], false);GuiduuidArray2M.AssertModel(models[13],_testData[16], false);GuiduuidArray2M.AssertModel(models[14],_testData[17], false);GuiduuidArray2M.AssertModel(models[15],_testData[18], false);GuiduuidArray2M.AssertModel(models[16],_testData[19], false);GuiduuidArray2M.AssertModel(models[17],_testData[20], false);GuiduuidArray2M.AssertModel(models[18],_testData[21], false);GuiduuidArray2M.AssertModel(models[19],_testData[22], false);GuiduuidArray2M.AssertModel(models[20],_testData[23], false);GuiduuidArray2M.AssertModel(models[21],_testData[24], false);GuiduuidArray2M.AssertModel(models[22],_testData[25], false);GuiduuidArray2M.AssertModel(models[23],_testData[26], false);GuiduuidArray2M.AssertModel(models[24],_testData[27], false);GuiduuidArray2M.AssertModel(models[25],_testData[28], false);GuiduuidArray2M.AssertModel(models[26],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidListuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 16);
                var models =  ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
GuiduuidArray2M.AssertModel(models[0],_testData[3], false);GuiduuidArray2M.AssertModel(models[1],_testData[4], false);GuiduuidArray2M.AssertModel(models[2],_testData[5], false);GuiduuidArray2M.AssertModel(models[3],_testData[6], false);GuiduuidArray2M.AssertModel(models[4],_testData[7], false);GuiduuidArray2M.AssertModel(models[5],_testData[8], false);GuiduuidArray2M.AssertModel(models[6],_testData[9], false);GuiduuidArray2M.AssertModel(models[7],_testData[10], false);GuiduuidArray2M.AssertModel(models[8],_testData[11], false);GuiduuidArray2M.AssertModel(models[9],_testData[12], false);GuiduuidArray2M.AssertModel(models[10],_testData[13], false);GuiduuidArray2M.AssertModel(models[11],_testData[14], false);GuiduuidArray2M.AssertModel(models[12],_testData[15], false);GuiduuidArray2M.AssertModel(models[13],_testData[16], false);GuiduuidArray2M.AssertModel(models[14],_testData[17], false);GuiduuidArray2M.AssertModel(models[15],_testData[18], false);GuiduuidArray2M.AssertModel(models[16],_testData[19], false);GuiduuidArray2M.AssertModel(models[17],_testData[20], false);GuiduuidArray2M.AssertModel(models[18],_testData[21], false);GuiduuidArray2M.AssertModel(models[19],_testData[22], false);GuiduuidArray2M.AssertModel(models[20],_testData[23], false);GuiduuidArray2M.AssertModel(models[21],_testData[24], false);GuiduuidArray2M.AssertModel(models[22],_testData[25], false);GuiduuidArray2M.AssertModel(models[23],_testData[26], false);GuiduuidArray2M.AssertModel(models[24],_testData[27], false);GuiduuidArray2M.AssertModel(models[25],_testData[28], false);GuiduuidArray2M.AssertModel(models[26],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MI)],
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
            asPartInterface: typeof(IGuidListuuidArray))]
        private void ImportModelInnerConfig()
        {
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_guiduuidarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<GuiduuidArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IGuidListuuidArray)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidListuuidArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
                importCollection.Clear();

                importCollection.Add(_testData[15].ModelInner);
                importCollection.Add(_testData[17].ModelInner);
                importCollection.Add(_testData[19].ModelInner);
                importCollection.Add(_testData[21].ModelInner);
                importCollection.Add(_testData[23].ModelInner);
                importCollection.Add(_testData[25].ModelInner);
                importCollection.Add(_testData[27].ModelInner);
                importCollection.Add(_testData[29].ModelInner);
                await ((IGuidListuuidArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IGuidListuuidArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
guiduuidarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(GuiduuidArray2M)],
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
            asPartInterface: typeof(IGuidListuuidArray))]
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
FROM public.binary_guiduuidarray2m m
LEFT JOIN public.binary_guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(GuiduuidArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<GuiduuidArray2M>(15);

                    importCollection.Add(_testData[0]);
                    importCollection.Add(_testData[1]);
                    importCollection.Add(_testData[2]);
                    importCollection.Add(_testData[3]);
                    importCollection.Add(_testData[4]);
                    importCollection.Add(_testData[5]);
                    importCollection.Add(_testData[6]);
                    importCollection.Add(_testData[7]);
                    importCollection.Add(_testData[8]);
                    importCollection.Add(_testData[9]);
                    importCollection.Add(_testData[10]);
                    importCollection.Add(_testData[11]);
                    importCollection.Add(_testData[12]);
                    importCollection.Add(_testData[13]);
                    importCollection.Add(_testData[14]);
                ((IGuidListuuidArray)this).ImportModel(connection, importCollection);
                var models = ((IGuidListuuidArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                GuiduuidArray2M.AssertModel(models[0],_testData[0], false);
                GuiduuidArray2M.AssertModel(models[1],_testData[1], false);
                GuiduuidArray2M.AssertModel(models[2],_testData[2], false);
                GuiduuidArray2M.AssertModel(models[3],_testData[3], false);
                GuiduuidArray2M.AssertModel(models[4],_testData[4], false);
                GuiduuidArray2M.AssertModel(models[5],_testData[5], false);
                GuiduuidArray2M.AssertModel(models[6],_testData[6], false);
                GuiduuidArray2M.AssertModel(models[7],_testData[7], false);
                GuiduuidArray2M.AssertModel(models[8],_testData[8], false);
                GuiduuidArray2M.AssertModel(models[9],_testData[9], false);
                GuiduuidArray2M.AssertModel(models[10],_testData[10], false);
                GuiduuidArray2M.AssertModel(models[11],_testData[11], false);
                GuiduuidArray2M.AssertModel(models[12],_testData[12], false);
                GuiduuidArray2M.AssertModel(models[13],_testData[13], false);
                GuiduuidArray2M.AssertModel(models[14],_testData[14], false);
                importCollection.Clear();

                    importCollection.Add(_testData[15]);
                    importCollection.Add(_testData[16]);
                    importCollection.Add(_testData[17]);
                    importCollection.Add(_testData[18]);
                    importCollection.Add(_testData[19]);
                    importCollection.Add(_testData[20]);
                    importCollection.Add(_testData[21]);
                    importCollection.Add(_testData[22]);
                    importCollection.Add(_testData[23]);
                    importCollection.Add(_testData[24]);
                    importCollection.Add(_testData[25]);
                    importCollection.Add(_testData[26]);
                    importCollection.Add(_testData[27]);
                    importCollection.Add(_testData[28]);
                    importCollection.Add(_testData[29]);
                await ((IGuidListuuidArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IGuidListuuidArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                GuiduuidArray2M.AssertModel(models[0],_testData[0], false);
                GuiduuidArray2M.AssertModel(models[1],_testData[1], false);
                GuiduuidArray2M.AssertModel(models[2],_testData[2], false);
                GuiduuidArray2M.AssertModel(models[3],_testData[3], false);
                GuiduuidArray2M.AssertModel(models[4],_testData[4], false);
                GuiduuidArray2M.AssertModel(models[5],_testData[5], false);
                GuiduuidArray2M.AssertModel(models[6],_testData[6], false);
                GuiduuidArray2M.AssertModel(models[7],_testData[7], false);
                GuiduuidArray2M.AssertModel(models[8],_testData[8], false);
                GuiduuidArray2M.AssertModel(models[9],_testData[9], false);
                GuiduuidArray2M.AssertModel(models[10],_testData[10], false);
                GuiduuidArray2M.AssertModel(models[11],_testData[11], false);
                GuiduuidArray2M.AssertModel(models[12],_testData[12], false);
                GuiduuidArray2M.AssertModel(models[13],_testData[13], false);
                GuiduuidArray2M.AssertModel(models[14],_testData[14], false);
                GuiduuidArray2M.AssertModel(models[15],_testData[15], false);
                GuiduuidArray2M.AssertModel(models[16],_testData[16], false);
                GuiduuidArray2M.AssertModel(models[17],_testData[17], false);
                GuiduuidArray2M.AssertModel(models[18],_testData[18], false);
                GuiduuidArray2M.AssertModel(models[19],_testData[19], false);
                GuiduuidArray2M.AssertModel(models[20],_testData[20], false);
                GuiduuidArray2M.AssertModel(models[21],_testData[21], false);
                GuiduuidArray2M.AssertModel(models[22],_testData[22], false);
                GuiduuidArray2M.AssertModel(models[23],_testData[23], false);
                GuiduuidArray2M.AssertModel(models[24],_testData[24], false);
                GuiduuidArray2M.AssertModel(models[25],_testData[25], false);
                GuiduuidArray2M.AssertModel(models[26],_testData[26], false);
                GuiduuidArray2M.AssertModel(models[27],_testData[27], false);
                GuiduuidArray2M.AssertModel(models[28],_testData[28], false);
                GuiduuidArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    guiduuidarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(GuiduuidArray2M)],
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
            asPartInterface: typeof(IGuidListuuidArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IGuidListuuidArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidListuuidArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MI)],
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
            asPartInterface: typeof(IGuidListuuidArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IGuidListuuidArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidListuuidArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

