

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
    internal partial interface IGuidMArrayuuidMMArrayD3
    {
    }
    
    internal partial class GuidMArrayuuidMMArrayD3 : IGuidMArrayuuidMMArrayD3
    {


#region TestData

        private readonly GuiduuidMMArrayD3E1M[] _testData = new GuiduuidMMArrayD3E1M[]
        {
            new GuiduuidMMArrayD3E1M
{
    Id = 7,
    Value = 
new System.Guid[,,] { { { Guid.Parse("760e90f6-953e-4f93-9670-bead0a3df7b2"), Guid.Parse("03d453e3-0453-487d-a0c4-62f60e69a289"), Guid.Parse("b85ac80e-cbf2-4ea5-8a81-25868283c274"), }, { Guid.Parse("58de49b4-be4f-4122-8638-d2fa60b06a1f"), Guid.Parse("83d3caed-bdd0-4151-8aa0-31305e07326e"), Guid.Parse("3af0691a-4040-49f6-a277-595f24ab569e"), }, { Guid.Parse("fbf6b121-7f59-4094-8f23-b6de13603f12"), Guid.Parse("1bf28f4d-fde2-45d1-9d7b-3b8b3591e2e8"), Guid.Parse("0c00a304-525c-487c-9421-4c781233d9a2"), }, }, { { Guid.Parse("046a78de-949d-47e6-88ee-54b8955e38bf"), Guid.Parse("d44e511d-655f-4460-a18a-608e8d04dbe2"), Guid.Parse("6aef6566-cf3d-460f-8ea2-efc0dda0eff8"), }, { Guid.Parse("f2b0968a-f0bb-4e3c-a964-89902f94bd4b"), Guid.Parse("32b2137b-43f3-410f-830a-54232369e0b3"), Guid.Parse("fa2c98cd-f8d1-4853-9706-2df238efd876"), }, { Guid.Parse("87beb36b-ff09-4749-8325-2ddeb41e338a"), Guid.Parse("efeaa03c-4c5a-4316-a45a-11c6c80b7bed"), Guid.Parse("6ac6897d-c2eb-48db-b382-e2b96b582ba6"), }, }, { { Guid.Parse("db2254c2-ccd1-4ad6-bf5c-9f9ac3ee286a"), Guid.Parse("82511d80-5c59-4feb-8a56-e037ea1459ce"), Guid.Parse("62dcc00c-c513-4e5b-b0d4-8412d81d7d05"), }, { Guid.Parse("9b6adfc1-fca3-438f-b8b9-f14de3eae7f9"), Guid.Parse("cf1d7e3a-8c53-46f3-b130-d8ed3bb3dd84"), Guid.Parse("ff6c62b7-d8a8-4453-9074-1799c0bd42c6"), }, { Guid.Parse("bbef9948-adf3-434f-9d03-31025608046a"), Guid.Parse("323f02d9-ceee-4dfe-a060-51dd6aef5f22"), Guid.Parse("98d46673-ac45-4e78-8b3f-bade55eaaf16"), }, }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,,] { { { Guid.Parse("9e617df8-bdfd-4a49-b983-363b1ac64417"), Guid.Parse("02ddd1c3-bf00-4596-a9c2-7cddf19e05d4"), Guid.Parse("e7f36db8-27a9-43aa-b453-bb9326fdb560"), }, { Guid.Parse("3396ba08-b1dc-4302-98e8-cf1bd33f2449"), Guid.Parse("2fceab30-4281-4fe6-9c8d-d7f7959cd1bc"), Guid.Parse("2f6b8422-86c0-43df-a041-ca92bfa1c37b"), }, { Guid.Parse("64cead70-f40d-4453-92fe-1d6842030038"), Guid.Parse("2a9d0759-b7d7-4016-b655-ca907e4b4e31"), Guid.Parse("41df86d7-6009-4e8a-a505-c9ec22d954f5"), }, }, { { Guid.Parse("47df316f-5af3-46fe-aa75-623f7efc1d80"), Guid.Parse("68c06d43-a778-45c5-bbaf-db5c2668a6ed"), Guid.Parse("67d6c781-e8e0-4914-bd35-3b28c852ab8d"), }, { Guid.Parse("36b10165-b329-47c4-a4f8-a6a8e611ea17"), Guid.Parse("103595ba-8afb-463e-83f3-8b82ed36dc57"), Guid.Parse("d7bae7c6-a38e-400b-aa8b-aad8d7ca5cfc"), }, { Guid.Parse("6d438219-c322-4ab8-8aad-7f2442d82ead"), Guid.Parse("dbf150b4-e4ef-400b-913a-0cbb425bf4b7"), Guid.Parse("358ddb9b-0517-42a7-86f9-e6ce581e4c7e"), }, }, { { Guid.Parse("19223910-98c1-4731-9c81-a7076b4307cf"), Guid.Parse("b1a7e886-18cb-47a9-b9eb-81e0b0ea0cdb"), Guid.Parse("ee4d5981-85a3-419d-ba79-4dc3b7ce7b7c"), }, { Guid.Parse("ccea4654-399c-40ec-b8ef-b82724f72d21"), Guid.Parse("94d9b9b3-6ea0-439b-a49e-9c764255a75e"), Guid.Parse("e59a98ae-5ca0-42a8-80de-e23f524b3342"), }, { Guid.Parse("8751ea2e-4f26-4fc9-8451-e30c14e1ebec"), Guid.Parse("763bdeb8-3d51-4126-a086-e58be77c2719"), Guid.Parse("a1a72731-3d7f-4fe7-8831-baeff50b3024"), }, }, },
},
            new GuiduuidMMArrayD3E1M
{
    Id = 15,
    Value = 
new System.Guid[,,] { { { Guid.Parse("9dc4fc40-eb18-4bdb-8550-6887482bae7b"), Guid.Parse("48e853fd-7c61-4627-829a-19b76f8129f0"), Guid.Parse("e8c021aa-2498-4b32-bf37-c352569aa392"), }, { Guid.Parse("a8cb759f-e8f6-40fd-861f-c4a29ab5163d"), Guid.Parse("68bb29de-2409-4a85-93d9-2b624e9cc363"), Guid.Parse("200ef5a7-15e3-4fe9-9317-20ff5c8d47d8"), }, { Guid.Parse("c73276ba-3ec8-425a-8da8-bf4078ce2e73"), Guid.Parse("f982564d-82a0-485c-9230-283b2305b06b"), Guid.Parse("835cecaa-7f78-4f76-9bc4-37c4a4ff64e2"), }, }, { { Guid.Parse("b8f0ddd2-8470-4abb-8573-14c77df00e61"), Guid.Parse("c0bf0120-a8d5-49d1-b989-fde8e73919d7"), Guid.Parse("3c7cdc10-5a49-425c-a3ec-954d59642cb9"), }, { Guid.Parse("89c1b118-e636-490c-a44f-19e64891e98b"), Guid.Parse("01ba45e5-39fa-4932-9681-0d1a04b40863"), Guid.Parse("eee558de-7b6e-4880-bfad-5f0db8a703e6"), }, { Guid.Parse("b8bdb80a-ca57-4a2a-9c4b-75f6aa9bb938"), Guid.Parse("4e979ffa-3b8a-41d9-baa6-f24f94122c2c"), Guid.Parse("34382aca-8441-48fb-9234-8baf2a11d6bd"), }, }, { { Guid.Parse("77150dec-1509-4817-997d-7f642c71359a"), Guid.Parse("e18f5793-2929-411b-b139-31582061aefa"), Guid.Parse("1660c764-0fa7-4d58-aeb6-e01797e4d4e5"), }, { Guid.Parse("08ebb05f-f3ea-4e62-ac54-747b7e557b4c"), Guid.Parse("0ed547a6-2c2b-4aad-8b32-3e04efb314d5"), Guid.Parse("a20e80d8-2167-4376-9550-7fe838195bbf"), }, { Guid.Parse("b603121a-7a0c-4d47-91ce-83ce4011650e"), Guid.Parse("f70d52fb-4c24-4aa0-ae8e-b605a167da46"), Guid.Parse("796bd670-a7f9-4aa5-ab1b-af57b0c5af87"), }, }, },
    ModelInner = new GuiduuidMMArrayD3E1MI
{
    Id = 9,
    Value = 
new System.Guid[,,] { { { Guid.Parse("4fbe3312-1046-442c-81a1-d43463985923"), Guid.Parse("8b81f55a-fa90-4534-9328-821d430ff40f"), Guid.Parse("33331a51-0649-4e35-bc46-58705167a3fc"), }, { Guid.Parse("63fd6541-33a2-4c05-9e19-5af8b0bf2acc"), Guid.Parse("3f0e9a32-ebdd-4dc0-bd8e-452044ab4897"), Guid.Parse("6a900901-d38a-4212-9be8-37c2c31804a5"), }, { Guid.Parse("78151982-2934-441b-a8d3-f684c1c7c6a6"), Guid.Parse("38959f24-0c0f-4ed0-9b39-dfb70f250a8f"), Guid.Parse("8a774e3f-8590-4be8-9f70-7d42e4e6e2fd"), }, }, { { Guid.Parse("b03b4bf9-48ff-453f-b2e0-534045e5d750"), Guid.Parse("8d9fb7fe-04dc-470d-9010-51231b7995dd"), Guid.Parse("904d7ce8-4343-4b21-bc54-11cf2719763a"), }, { Guid.Parse("f1ef3bf4-b982-4a71-97f4-36063355ca38"), Guid.Parse("580aa665-5960-4889-80c2-c650223f5e17"), Guid.Parse("e05ad9ae-b582-4b3d-a690-252cffb4e36d"), }, { Guid.Parse("5731c839-6063-4618-96a0-af2065f63ad2"), Guid.Parse("0c59d7a3-eb0a-4461-9c12-b74ae36f8e9e"), Guid.Parse("8313fba6-79d4-49f4-ab53-69124f8e39b4"), }, }, { { Guid.Parse("f5f9fff5-6ffa-448d-af55-c57b6eea120b"), Guid.Parse("a92a0e88-c4be-4033-9848-6ab2c7c5d044"), Guid.Parse("16e1cd09-9189-43e4-8eb3-9d7a3c7f0fd8"), }, { Guid.Parse("926e5a4d-bb9d-40fa-be49-fb4bf1fd631a"), Guid.Parse("4343e7c1-f347-4e2a-874e-b799b87468d2"), Guid.Parse("8ccab59a-40d7-40a8-85bf-19ed43fe4b60"), }, { Guid.Parse("0c595959-2a87-419b-a748-44affffd1715"), Guid.Parse("67b95031-e8a6-4b69-886d-afa801111353"), Guid.Parse("ed0d10b3-05a8-45e6-ac7e-d1c5c30b41cc"), }, }, },
    NullableValue = 
new System.Guid[,,] { { { Guid.Parse("ed737535-c584-4de3-b0f2-64330ab342e0"), Guid.Parse("20c6ae7f-c1c8-4fc1-8724-b3ccc71161e1"), Guid.Parse("794dee8a-be9a-42f0-b690-7ab15d2560df"), }, { Guid.Parse("f941468d-6746-488a-8c47-6c2a9466d352"), Guid.Parse("87d07f66-ade1-4518-b1ba-349d747be7fa"), Guid.Parse("8302904f-6d39-4e99-9e9f-53f448b1d5b4"), }, { Guid.Parse("e2d91703-8ab5-491d-85a8-237da2fccf64"), Guid.Parse("8ce089f3-0fa4-4680-bc04-31ef72e20c8f"), Guid.Parse("6372b65d-21e2-4b61-9902-bfe825517afa"), }, }, { { Guid.Parse("f6f6478e-8c3a-4b24-ba9e-b383fe205c84"), Guid.Parse("beac46d2-1677-4672-bfd6-99d5a8164df5"), Guid.Parse("158db5d5-5c82-489c-812a-fccd8d39a997"), }, { Guid.Parse("e798ec51-18a8-4d29-b74e-774fecfe78a2"), Guid.Parse("641b3937-1038-4fa2-b792-60301d6ed618"), Guid.Parse("25f5fa98-54f1-4bd9-b66f-dd139f802d12"), }, { Guid.Parse("e740c41c-e398-48a7-b231-f53102f0e62c"), Guid.Parse("dc45751d-227d-47ef-a7da-f6373d82c2b6"), Guid.Parse("e7636004-01dc-4ef2-84c9-99e5a2589aee"), }, }, { { Guid.Parse("2a3e80b3-2089-4378-a1ff-ef813dcbb4d0"), Guid.Parse("2eff199a-fcb4-48eb-b736-ce896530862e"), Guid.Parse("66bebf0d-e938-4508-b8a5-0512af7bc915"), }, { Guid.Parse("53b61c50-da72-4c59-892a-905f6e910100"), Guid.Parse("9e8000e0-a5da-4dd2-ab51-af06a0f555d8"), Guid.Parse("d152fda1-fb55-436e-923b-76498e99c422"), }, { Guid.Parse("dc8518e8-bb96-43fb-acf1-b7c9854fe531"), Guid.Parse("bce45a32-cb40-4cea-8316-b6458159558a"), Guid.Parse("0fa1127a-48b9-42a2-8ed7-8246dbb1ab38"), }, }, },
},
    NullableValue = 
new System.Guid[,,] { { { Guid.Parse("6b60bff1-3d0d-43a0-ba06-7e6d45eb2d86"), Guid.Parse("ea0e9c57-47ce-4051-9b4a-4f7e93e909d9"), Guid.Parse("c6ddfeca-cfee-44f0-b7a2-e78373971811"), }, { Guid.Parse("31589e4a-e84e-4a54-8b89-6d0f6d4020a0"), Guid.Parse("031d4c73-aa89-4a86-b6aa-42b92461f427"), Guid.Parse("217be17b-33a9-4963-b4a1-c5166bd234e2"), }, { Guid.Parse("bcc77335-1130-4994-a99a-a718625b2af0"), Guid.Parse("9b754158-6539-41af-be44-9aa2cd758261"), Guid.Parse("5b988c0d-2038-41eb-be51-f701fd2a6311"), }, }, { { Guid.Parse("597fa8c2-7fc9-4828-965a-a05d68870746"), Guid.Parse("849d8826-4767-488b-941f-95024c5502ec"), Guid.Parse("790e09e5-a69a-4c11-97bb-452173b180b4"), }, { Guid.Parse("cd7eb0e1-db3f-4c98-bf4a-a8962c1f687d"), Guid.Parse("71e55128-5d83-49fb-b0f6-37e2f2e66176"), Guid.Parse("81a29ae5-4693-42b7-a735-591afb4feb59"), }, { Guid.Parse("3dc919c8-7aad-4ebe-9bfa-618b6c6b3f84"), Guid.Parse("41cabe52-5cf3-4919-a96d-5c3f4ed2753f"), Guid.Parse("e6583672-15a4-47fe-9eca-5e69ac2bdbe4"), }, }, { { Guid.Parse("870a2ed6-3c74-441e-b3ae-7211f394f7b5"), Guid.Parse("467cfb0b-c801-45d1-88ef-b64703ba57ae"), Guid.Parse("c248ab9e-3109-4cf3-be29-b609cf43a610"), }, { Guid.Parse("63451886-9ab0-473e-816c-3a6bfde2a51b"), Guid.Parse("0782f66e-7538-44b2-a6b8-f6d9d638b684"), Guid.Parse("f61ef902-b3d7-491d-8be1-11017762ec69"), }, { Guid.Parse("d95e6153-8415-4c75-aaab-d097293cc2df"), Guid.Parse("502bd441-dcdc-4b65-b5b7-93540c0a4430"), Guid.Parse("70e41250-f73f-4909-9482-479e0afb07d3"), }, }, },
},
            new GuiduuidMMArrayD3E1M
{
    Id = 19,
    Value = 
new System.Guid[,,] { { { Guid.Parse("ebc054c0-24cd-429b-844f-ed6ed1f653a0"), Guid.Parse("627136e6-cf3f-4862-b1ce-84237a3f1614"), Guid.Parse("7942ff0a-5907-4484-8725-90907df170a9"), }, { Guid.Parse("ee8bb6c2-1f2f-420e-b4a0-e6da4b0a88a7"), Guid.Parse("15bdd27e-6c7f-49e4-9adf-a5dd0e45ef28"), Guid.Parse("6ee4b9b7-94e5-4fc9-ba40-de15955044a3"), }, { Guid.Parse("b3cc5fb8-2434-41b5-b57c-6b261227f55d"), Guid.Parse("84d8c447-ff77-4a1e-b621-00f39b2eccb8"), Guid.Parse("5b766ddc-f9bc-4522-8f1e-fa968f7e8ad3"), }, }, { { Guid.Parse("34307654-22b6-4320-9454-e494c1f5fa31"), Guid.Parse("37e891aa-e07d-4f15-a2ce-5691e8e21d27"), Guid.Parse("6255bd57-2c16-42c7-a64e-59a8e3193d71"), }, { Guid.Parse("dbf40887-ac3c-40a0-b25a-38b502d2afdb"), Guid.Parse("c853808d-9240-4743-9e8a-4f57ceacbc1c"), Guid.Parse("d8dbe459-e06a-4a7b-aaf3-14694fff7cce"), }, { Guid.Parse("0b883a15-0a88-476a-b3b2-0af8927108e1"), Guid.Parse("92ba5fe0-4b7d-4bf9-b1ad-6dc87b4f6816"), Guid.Parse("64382d15-0d5e-4fce-94be-18676be270fd"), }, }, { { Guid.Parse("ff25451f-c67c-4b3f-8bf7-21fbd974fa23"), Guid.Parse("61f0deb1-812d-4f53-a52d-88bf8873a7be"), Guid.Parse("32265068-d169-4869-b667-7139749e3902"), }, { Guid.Parse("5e8248db-4cb6-4be8-9a3e-f3e2fa0798ad"), Guid.Parse("a4ea1777-7366-4b59-b0c9-b1f78abd153b"), Guid.Parse("fe4208ef-660a-43b1-acaa-6e806a97cfb1"), }, { Guid.Parse("f42752c2-f8ca-4e7a-a328-18b595a91da4"), Guid.Parse("e0266f7c-9b76-4fcf-bd9b-e21be0dd817f"), Guid.Parse("21353126-7a0a-4573-9987-50d0353490cc"), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD3E1M
{
    Id = 20,
    Value = 
new System.Guid[,,] { { { Guid.Parse("0b6a4eb8-1248-4b7e-a995-99d031e8c4ed"), Guid.Parse("6aa605ce-bdd0-46c7-8c2a-82965013a772"), Guid.Parse("b534a965-961a-4ff0-a334-ed66d53155ff"), }, { Guid.Parse("825e8fcf-af87-49b1-8131-5814d8cfc586"), Guid.Parse("6d93e04f-fafd-472e-ae5b-3a0d27f2786e"), Guid.Parse("f36e57d0-6bdb-406a-b2b4-423d5dc8611d"), }, { Guid.Parse("e28ef137-f122-4232-8b2c-21e98ccc960c"), Guid.Parse("ea8cc843-fc61-44b0-a919-9a659d318a42"), Guid.Parse("99dcb1d8-175f-43d4-b98c-d346c22c7705"), }, }, { { Guid.Parse("29c2ec1a-c2cb-44e7-a844-5e323eab163e"), Guid.Parse("7ea1ce74-fec3-49cd-8504-4ee0bac06662"), Guid.Parse("06655d03-dc29-4d8a-be18-8cd1643bd606"), }, { Guid.Parse("c05d7317-ef6d-474e-b374-b695f6a7a6c2"), Guid.Parse("1c01f1cd-979d-4430-b719-63e64ea353cf"), Guid.Parse("e3c8944c-e8bd-4ca2-ad4c-e8fb2c754f38"), }, { Guid.Parse("1e9f4a49-d281-4072-a2d4-a59926effd11"), Guid.Parse("ddd6e60a-c331-401b-ad9b-2b4348a068a4"), Guid.Parse("e26069f4-6ae8-48c2-b647-d9412780cc5b"), }, }, { { Guid.Parse("aaf41fb1-90db-4b92-b0c6-9039fd813eb0"), Guid.Parse("21fcc830-31cb-4878-b157-41f701e7f6b5"), Guid.Parse("956de3ae-fd30-49e2-9ed0-928b2ad7f600"), }, { Guid.Parse("e6f3a81b-ff52-415c-ba21-beb1e979c36d"), Guid.Parse("cf2f27b0-1c51-48dc-a370-000ce92ea4e5"), Guid.Parse("e5ccadbc-c968-4d10-b412-f2c098184ece"), }, { Guid.Parse("98a13507-d1a0-4e4d-9b40-1d747bdb22c9"), Guid.Parse("7929b110-c880-42fd-baed-338c1526a49a"), Guid.Parse("a0407c8f-d008-4a88-8430-4f8913a58013"), }, }, },
    ModelInner = new GuiduuidMMArrayD3E1MI
{
    Id = 16,
    Value = 
new System.Guid[,,] { { { Guid.Parse("92a58119-4e17-407a-b8cc-7e44f4944a4c"), Guid.Parse("d00a3022-33c1-4b9f-9346-9dee77bd8d9c"), Guid.Parse("1ae54f10-3ae2-4611-bb11-1153f21214e9"), }, { Guid.Parse("5ae0982f-9e2e-428b-9b25-1a23a949f272"), Guid.Parse("aeb6a1f9-d6ba-4104-b775-d3a4ddc69231"), Guid.Parse("bb0ee65b-d68f-419a-b089-30845cd014ca"), }, { Guid.Parse("71a415d6-3bba-44bc-80cc-0f3dd423066f"), Guid.Parse("e007eaff-0878-4028-834d-985c55ca056c"), Guid.Parse("e8c3a7da-e9fe-4f8f-a22d-50f9aba4e628"), }, }, { { Guid.Parse("e70356bf-8414-427e-b16a-017d7b5be960"), Guid.Parse("c4dcc5ef-7d74-4ad7-9d18-fd1fbb4631c8"), Guid.Parse("105b8424-2af2-46af-9b7e-324a7d46fcc6"), }, { Guid.Parse("cc9f304f-7b16-485c-9c91-63b3b47d0b9c"), Guid.Parse("3ba7e178-72e0-4459-ac8b-13a2375eaea5"), Guid.Parse("fdd719ce-5513-4efd-903e-c19eefb4c6ed"), }, { Guid.Parse("d94230d7-484c-4c05-bd0f-6b01a91a5cbd"), Guid.Parse("5ca716c6-3fc5-40ee-af64-de9ace1376fd"), Guid.Parse("0f8da56a-3188-48cd-a08d-34d330a9595b"), }, }, { { Guid.Parse("2a6eb67d-9307-4606-9cd8-d844cfec7d6d"), Guid.Parse("811198fd-8e6b-4928-be4d-1bdee7e0c8b7"), Guid.Parse("ad3ba983-24d6-4beb-a675-57b04083629f"), }, { Guid.Parse("52764f02-9418-4116-9215-6a1dbb251e74"), Guid.Parse("eeb92732-825f-4d90-af35-58b420e18f56"), Guid.Parse("90d008e8-a567-4b6f-8c25-98c63bd63e92"), }, { Guid.Parse("1bc2626e-45ac-4572-a090-d031890dd1af"), Guid.Parse("dfd6f954-3acd-4f29-ab41-6d9924d85597"), Guid.Parse("bc6a2301-bc84-44c4-83ac-59657ff846f9"), }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,,] { { { Guid.Parse("8d21bae7-252e-4fb2-82b2-dfd557977241"), Guid.Parse("82a38550-c5c7-445e-88c9-277e4a745d07"), Guid.Parse("a5513c55-11e7-4853-bf38-5030f9458d02"), }, { Guid.Parse("7ef5f3e2-1622-405c-813c-8c86666f8afb"), Guid.Parse("378e28d2-62cc-4b19-9368-cdc294c45e19"), Guid.Parse("b94136ca-37e3-4f4a-b33b-00f84e04d296"), }, { Guid.Parse("2e4a6253-fc6c-4a28-a4e0-50fa305bd3a9"), Guid.Parse("4cb7ed97-c743-46ae-b1d8-808a461daede"), Guid.Parse("30f6b351-5b70-4ba5-917f-7a967a96e2b9"), }, }, { { Guid.Parse("65cbe974-95c0-4fd8-a15e-18a8644bc1db"), Guid.Parse("17a3ff2f-867d-4dc4-a29d-08eb36e2f6a1"), Guid.Parse("64f3dbe0-8c5e-4e93-a0d5-7a2ca0c939e5"), }, { Guid.Parse("0b085ec6-37fc-41f8-ad8b-8792e9d5674d"), Guid.Parse("bd49227d-ba5b-48e9-ad9d-1ece0f97c381"), Guid.Parse("5581df18-6ebb-466a-b999-095a5dd05130"), }, { Guid.Parse("ac085fab-afa2-4e05-b33a-0b7d6c4fba46"), Guid.Parse("3b302cf3-f16f-4536-877e-6f393b5972f0"), Guid.Parse("fb45e249-c346-4c19-ae6f-8cc02ef6ca83"), }, }, { { Guid.Parse("2d590b55-316d-4e42-a728-2279a8c9f8d4"), Guid.Parse("1c08caa4-c4b0-49c7-b39f-98cbede36a44"), Guid.Parse("00231fd3-27e2-4f7f-835b-6472b2f7c76f"), }, { Guid.Parse("876a5032-566b-4e5e-a1ca-a66b1f49d103"), Guid.Parse("856c5d5c-9b97-4e68-9da2-21f5e15d5dff"), Guid.Parse("bc816366-6033-4cff-8680-6a9e8940e50f"), }, { Guid.Parse("f84d68d0-2468-4b05-a186-f8d529d3b370"), Guid.Parse("46b36899-a185-4451-bb60-a4151130686c"), Guid.Parse("90c6c063-c249-4ef1-91b3-049a08a9726d"), }, }, },
},
            new GuiduuidMMArrayD3E1M
{
    Id = 24,
    Value = 
new System.Guid[,,] { { { Guid.Parse("f2641494-d12e-434a-9554-18e2707b53c5"), Guid.Parse("bd971da8-5126-41aa-a945-2ef70ea38011"), Guid.Parse("0cee5d4f-394c-417c-ac36-dec6c1773050"), }, { Guid.Parse("d89343d9-1c43-4d65-9701-267b3313ddb9"), Guid.Parse("33642950-c012-4e02-a194-7e2e291687c2"), Guid.Parse("f476629b-af90-4495-9b34-14b647ec17ca"), }, { Guid.Parse("9ead10d5-bfbe-45e6-b157-5fcd1a849a2b"), Guid.Parse("14d735dc-31c4-4d47-a413-10344cd964f5"), Guid.Parse("10131c8b-2f84-4185-97c8-cdd94ffba5d2"), }, }, { { Guid.Parse("5babfddd-44c0-4231-bed6-5682451caef5"), Guid.Parse("0e8bae7f-77a9-4d84-993a-9b91e42d672c"), Guid.Parse("7011068a-5ce7-476c-9a78-09c4656f5188"), }, { Guid.Parse("81c0b6de-f3f3-48c0-a573-66c0843b0309"), Guid.Parse("8067ce57-2434-46b5-a0b1-b7e8113353ce"), Guid.Parse("64e7fc6b-af4a-4e0d-ac9b-6f37a4c50c16"), }, { Guid.Parse("ea157fa9-5b7f-4730-a080-796dcbaa0a21"), Guid.Parse("05dfd506-df70-4da5-ab80-f09af0b5b148"), Guid.Parse("55c871d7-6cc6-41af-9b9e-3eab5c4054a8"), }, }, { { Guid.Parse("1e689ec0-dede-4f28-b2a0-ac0b5138204f"), Guid.Parse("bf576c84-2c46-48c5-8fbf-70d24bc83786"), Guid.Parse("24e9ed48-1c0f-4d60-a959-45b45647cb4b"), }, { Guid.Parse("e789bdd2-eeda-4ff9-855e-1c182c12549c"), Guid.Parse("45e872a1-94bc-433b-a3ee-49fd7c92a491"), Guid.Parse("2955b523-2d1f-4190-9bc9-5a35750be3e7"), }, { Guid.Parse("91ebe0fb-8f59-414e-9638-1b2695e32686"), Guid.Parse("895cda42-e557-4eed-bbf8-35633920c9a1"), Guid.Parse("995b5167-bb04-4f84-aebe-49e6adefe785"), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD3E1M
{
    Id = 30,
    Value = 
new System.Guid[,,] { { { Guid.Parse("263b2224-b4ba-4816-b1e4-89fed79f8f5e"), Guid.Parse("a1878b7c-baac-470c-9ebd-a8b668d74410"), Guid.Parse("8d276c17-94d4-4a3a-b553-c657e611abe5"), }, { Guid.Parse("36a79525-96a7-4073-9bdb-19ee2b12c993"), Guid.Parse("28eadc10-30e1-4ba3-b60c-f6803638e3cd"), Guid.Parse("ea5d0dee-caac-4ab5-a2d5-5659df48bede"), }, { Guid.Parse("1a623c44-e55b-4e18-a605-34a3a0e74dab"), Guid.Parse("980a8f63-4ca9-485c-938d-a99c1fc72d84"), Guid.Parse("397fda6d-959f-42ab-b286-35bedead28a3"), }, }, { { Guid.Parse("1b0292ae-5387-4355-9ba0-7b2db3eaf2ed"), Guid.Parse("a5244aa9-626d-4d7f-bff2-1fc4a8bdbfd5"), Guid.Parse("962826fe-7864-49f5-9fc8-8ec95d1ff31f"), }, { Guid.Parse("6f25c62d-3ede-4024-9aa8-8eb196a10346"), Guid.Parse("80b1b207-0f63-47b7-84d4-6a2f51d7e5b8"), Guid.Parse("d9a46a57-1968-41f7-a304-a619997cd13b"), }, { Guid.Parse("bdff4329-d8f6-49ce-9b8b-76933880de4f"), Guid.Parse("a60a42c6-dd04-453b-b76d-3a94746673dc"), Guid.Parse("4accbc8b-60d2-47cf-a184-60eac1d45c71"), }, }, { { Guid.Parse("41771819-8cdd-4334-96cd-789f974cf3ed"), Guid.Parse("803dc7de-8175-43bb-b051-7dddaa9af3e4"), Guid.Parse("b11a997b-63b6-48b2-bc67-fafb6fdb82b8"), }, { Guid.Parse("a547099a-de36-41d8-a3d8-a41a59518c3f"), Guid.Parse("a21e3d91-f2ee-4252-8c7a-9b34e2ccb113"), Guid.Parse("2bab1506-bf82-48fc-8aa4-c397678163bf"), }, { Guid.Parse("57021728-1a0c-49fc-af24-4b2ab47b4cc4"), Guid.Parse("6c608708-0b78-4f1e-a5c0-c6eeadd773d1"), Guid.Parse("4d76a15c-a32c-4d7a-9c36-457f7e2cb5ec"), }, }, },
    ModelInner = new GuiduuidMMArrayD3E1MI
{
    Id = 19,
    Value = 
new System.Guid[,,] { { { Guid.Parse("40ef91ad-a8f1-4f71-92e1-acf5f25d5e36"), Guid.Parse("edadba0c-2b27-40ae-bbee-06d986faafdf"), Guid.Parse("3488003e-58b7-4fa7-b31b-99a47478b6e3"), }, { Guid.Parse("d1767be3-6d48-4945-82f2-9dc90fd04f7c"), Guid.Parse("75ac0be6-843a-4986-8bab-d193fdcd1398"), Guid.Parse("ce289526-8fe8-42f1-a12d-700ce434e73c"), }, { Guid.Parse("8a5244bc-d069-4087-a0a4-7d80164fbe55"), Guid.Parse("88710c20-bf19-4882-9852-f6b0158aabf9"), Guid.Parse("14dcfeaf-e2a4-46ff-9df3-349902331dcf"), }, }, { { Guid.Parse("f853b634-fc22-4249-9c5f-b72bdab8489d"), Guid.Parse("265be4ac-5f44-4b3a-ac82-7643d32a13f2"), Guid.Parse("b010e79b-211f-4983-a3e5-f17311b13f8f"), }, { Guid.Parse("11a5fdc8-7239-447d-88f7-80f44f26ccb5"), Guid.Parse("fd85d6bd-6154-43fa-8b70-481906846bac"), Guid.Parse("66b7dcd4-5a81-4b11-a555-39f8f587384e"), }, { Guid.Parse("ad971873-5bc3-4b46-b5ea-c10c36be7b26"), Guid.Parse("7c044b88-4ed4-416a-b9bb-dddf5d8d4f0d"), Guid.Parse("7e44847b-edd4-4935-8bce-c28814f42a22"), }, }, { { Guid.Parse("a9090bf0-dc64-43e9-9a6c-1d2e8911ff75"), Guid.Parse("19d1dab5-8a9c-4c68-99e4-dc6176fda422"), Guid.Parse("aaf4b117-71c0-42cf-9ddd-b19a5ad1545f"), }, { Guid.Parse("d08e2b13-ca02-4596-8d77-e730b1edcf52"), Guid.Parse("b33ec43d-c6ef-437d-9046-ae3356670f83"), Guid.Parse("f40d2118-daf5-4541-b85d-98d8bb1d93fa"), }, { Guid.Parse("1547502a-3737-431c-95a8-e70338c664ed"), Guid.Parse("9f37564c-5903-4d43-8aac-e13fb6d19b13"), Guid.Parse("8431e95f-a4ba-4db7-b4d2-7e9019463027"), }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,,] { { { Guid.Parse("8fae7e73-da4f-4ce5-90a9-2e292f45cd31"), Guid.Parse("21141bbe-7ea7-430d-beaf-304fedd12e13"), Guid.Parse("7f51a57b-2e34-4060-b0e8-d5379f442680"), }, { Guid.Parse("01314106-3178-40ba-8674-0c08a92e8b36"), Guid.Parse("6f67ca0a-1e3e-4253-8c68-c94ebedd2175"), Guid.Parse("fd734181-304e-4ec1-abb0-e6529771e066"), }, { Guid.Parse("9c6d0998-4199-4115-9040-d845d90bac97"), Guid.Parse("1e76037c-7ce8-4b84-bf4a-17828892e635"), Guid.Parse("761b0d22-2a7b-463f-9f86-e9c0b7255db5"), }, }, { { Guid.Parse("94abf7be-1ab4-4a59-b444-447d725355b0"), Guid.Parse("d4d032ef-d7ee-48e4-9f2c-204a07f89c9d"), Guid.Parse("c5ad1ac3-22f0-4927-bd4b-99e95d8bea7b"), }, { Guid.Parse("45a92c7f-a75d-47e2-932e-cba8fe79fd03"), Guid.Parse("2b7589dc-7d5e-4ddf-be51-526d2007c1fa"), Guid.Parse("4ab339f5-7512-4fa4-b20c-15196edf9a36"), }, { Guid.Parse("42f3d03c-bc1a-47c2-8e88-f7587f6210a0"), Guid.Parse("bc5eb6f9-fed3-47ca-b2e1-6ad3358a8ab1"), Guid.Parse("f4d37453-c1bc-4b5b-9b1f-adcbfcb98b46"), }, }, { { Guid.Parse("6a81cc06-7f94-4c76-80c8-d9d447e20c0e"), Guid.Parse("04a2b86a-98fe-4c4f-a858-e07cff2f682f"), Guid.Parse("f5910725-5a8f-48c5-ae06-094734577e8f"), }, { Guid.Parse("c6ce5036-8056-448a-9d06-2192de260440"), Guid.Parse("0932cb9c-1baf-4760-86de-0ef2e67b0454"), Guid.Parse("611b2c4e-b321-41a8-ab1c-e0a9e48906ac"), }, { Guid.Parse("65bb1c96-7380-45c5-9b36-59698a049d46"), Guid.Parse("ed2629dc-31c3-439d-9935-479b0a7cca06"), Guid.Parse("4fd05985-26a3-44a8-8e43-3c18b30c02b7"), }, }, },
},
            new GuiduuidMMArrayD3E1M
{
    Id = 31,
    Value = 
new System.Guid[,,] { { { Guid.Parse("ee0b7733-ebbf-4337-b978-bdec5fcd1444"), Guid.Parse("56073362-15bc-4f73-8e3d-df58e99f83b1"), Guid.Parse("adc1f751-9878-4f85-b48a-b74ca6a34dbf"), }, { Guid.Parse("66813a3b-6a49-48a9-bad2-5fa3222c7f30"), Guid.Parse("e7961e82-48ee-4a58-9e07-7df76bcdc20b"), Guid.Parse("b0ca75e5-a8c0-40c8-a2ff-c51ebc865217"), }, { Guid.Parse("283f2f76-bee5-410d-932e-a94b347ad69c"), Guid.Parse("72082c4f-6a95-4443-9a2f-8695c1b6b94b"), Guid.Parse("50e1a897-1d59-4bfb-b806-c242ef33ff6b"), }, }, { { Guid.Parse("9ccae5b6-8360-4e15-b24e-83c2054cb224"), Guid.Parse("ea2c0143-2e38-4904-aeb0-523f563d8be4"), Guid.Parse("fd87d674-6288-403e-83a0-4682eb2156b5"), }, { Guid.Parse("8b643961-4266-4178-ba15-a8b02b2dec6d"), Guid.Parse("dc0e8a52-5cee-469f-a92c-6badeeb92e79"), Guid.Parse("330050d8-8777-4310-a7c2-f7db1d32dc13"), }, { Guid.Parse("aa0a452d-842a-4b0c-8092-6450eab9ab2b"), Guid.Parse("f4ecfa36-2b74-44b4-bcd6-5e9c30de890d"), Guid.Parse("31e4b496-78af-4b24-bab1-d0f1440e5791"), }, }, { { Guid.Parse("b553fe17-a0fd-420a-9782-9766641d687c"), Guid.Parse("da88cfbf-711b-4648-8bf7-f250386d351a"), Guid.Parse("ff6337f7-09b7-48db-a413-0fde103741e8"), }, { Guid.Parse("e3125800-d37e-49a0-80a2-2445a8dc0202"), Guid.Parse("10463601-463d-4a17-b113-72c3904903a5"), Guid.Parse("5ad4d37e-2661-4f21-ab05-9b99a90bb00c"), }, { Guid.Parse("edc346d6-95c0-4905-822e-453a8cbd3042"), Guid.Parse("07697c0d-fdf9-46a5-953b-3290afd7b8f6"), Guid.Parse("9e08dbf9-9cf3-458c-b8a5-a16dbdc7794c"), }, }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,,] { { { Guid.Parse("98d5070b-dbe4-45ea-bc3c-c4d92e75e68d"), Guid.Parse("75790aa7-5ea6-4ca6-a1a9-53f6ca5e3433"), Guid.Parse("2ff7f265-afc0-481a-bdf5-9d328c4a7bd2"), }, { Guid.Parse("1581a92e-dd71-4aa2-aaa3-7c74d7ee511d"), Guid.Parse("78ec4f4f-4520-4ca1-a629-4ec86a438888"), Guid.Parse("2e7060c5-3a6b-4f3d-b8cc-d69e68fe88a3"), }, { Guid.Parse("e5eb5b72-640f-46f2-9154-25aa0a4c655a"), Guid.Parse("a0aaeaf9-83d5-4ddd-836e-f365a19b0612"), Guid.Parse("b5335825-ec8e-4fd4-a538-b53ff195b427"), }, }, { { Guid.Parse("c020ada7-5b56-4ccb-a717-b91ad801617a"), Guid.Parse("5f38f382-0421-414a-8aea-b5be2f070e12"), Guid.Parse("409650ce-16e2-454a-b3cb-bbece1cec28d"), }, { Guid.Parse("62039872-4c9b-464d-9dfc-d57f2289e1ce"), Guid.Parse("e33bfba0-e927-4a67-82d1-d99cec96a98f"), Guid.Parse("618cfa6b-a5a3-4b3f-b6f7-5301226ec158"), }, { Guid.Parse("3c29b7cf-411b-433a-a560-c0e67036f895"), Guid.Parse("7db2695a-e0ad-44ac-8a41-b79c8c53a6bc"), Guid.Parse("ae2ff8f1-45eb-4453-a924-b7b20be9054b"), }, }, { { Guid.Parse("2170ba72-d69e-452d-b5fd-683dcf1923be"), Guid.Parse("e6068d8f-d891-4500-b785-c9acf447b9d9"), Guid.Parse("2dee4a45-d8d5-4653-af92-58fea06d2f2c"), }, { Guid.Parse("88ce2545-6f21-49a0-9cf6-56d6ca629e29"), Guid.Parse("429f67ac-43b0-4f47-b470-4715ce73fa20"), Guid.Parse("fbee66ae-46b6-412e-8e71-cee6ba651e0e"), }, { Guid.Parse("05905fd4-94f9-4f2a-9a76-b3b50dc62bdd"), Guid.Parse("95a3075f-8bad-432a-8c37-a1ec510bc2ac"), Guid.Parse("547c588b-11e2-4ea2-b573-aa2aab837a2f"), }, }, },
},
            new GuiduuidMMArrayD3E1M
{
    Id = 37,
    Value = 
new System.Guid[,,] { { { Guid.Parse("41b4dad9-571a-4246-8b93-bfd312732f4a"), Guid.Parse("ccb19317-f177-4fe5-9b0d-9cfe5ead661c"), Guid.Parse("27f9f520-28e0-4060-85aa-1cbcd7396940"), }, { Guid.Parse("153310fb-f55f-4f2c-9374-3626d26b334f"), Guid.Parse("aac943e2-4453-4a57-84a6-606077894480"), Guid.Parse("76b7a0b4-2e82-46fd-b5a7-008644777811"), }, { Guid.Parse("35aab8b8-d7aa-4f12-b9ce-5a4e21e62da8"), Guid.Parse("563a6fa7-8bc8-41c7-9fee-6a73778be03b"), Guid.Parse("d0c3f61e-34c6-474a-a0ee-d1e91e88ba3a"), }, }, { { Guid.Parse("583efbd0-f6fc-40dc-9a7d-ccfa70e2643c"), Guid.Parse("45e76f54-b69e-47e0-b964-5683636df6c8"), Guid.Parse("fabd09cf-1b91-4961-8735-ed269f9ec862"), }, { Guid.Parse("803a1830-107f-4cdf-803b-06a2f8fadc3a"), Guid.Parse("87e8cc7e-d0a6-45a4-afef-a23b2a86479c"), Guid.Parse("e44f607f-9167-4b28-820e-a68b0c757c07"), }, { Guid.Parse("63774248-a0ee-4389-8339-3cdeed123e49"), Guid.Parse("2c8ebd63-8d30-4b49-ab31-c282de78ec56"), Guid.Parse("0188984c-61d3-4f45-bb58-02c890640e38"), }, }, { { Guid.Parse("931edd53-73fc-41a7-a687-1f6fa11804a6"), Guid.Parse("157a2162-a004-4944-a7ef-fa4a8ddbef41"), Guid.Parse("654483e1-e877-4a32-81c5-d9e55d705f88"), }, { Guid.Parse("b092d640-fd52-47cc-8edc-53d8da61b82f"), Guid.Parse("89be6992-605f-4e2f-9009-a8a3f67f8025"), Guid.Parse("842440cf-694f-44b0-bce0-f3372f8a0b01"), }, { Guid.Parse("c6dd3fbe-c59b-4365-b098-005167a1c20d"), Guid.Parse("d887d751-7634-4b26-a073-f69c3fe41025"), Guid.Parse("ba8521ea-8e26-4666-8b25-a503401b893a"), }, }, },
    ModelInner = new GuiduuidMMArrayD3E1MI
{
    Id = 23,
    Value = 
new System.Guid[,,] { { { Guid.Parse("69011bbd-3fd1-4815-b4d7-498b84c4afea"), Guid.Parse("661c83bb-1cbd-48b9-b12c-79ea72c76af3"), Guid.Parse("59c1f9fe-9099-44b0-903a-6a637780fc3f"), }, { Guid.Parse("93a03338-8e86-4dcf-a6ef-512fa9c825bf"), Guid.Parse("912fff6a-7bde-4c06-94a1-051802e21781"), Guid.Parse("d01e65b4-5844-43b8-a3c6-7430ab8ab8b5"), }, { Guid.Parse("d0491b7b-6594-4a59-bfb0-065897ffbe1e"), Guid.Parse("f8d1eb48-ba8c-467b-995a-35928bee3546"), Guid.Parse("e9fcf306-f254-4af7-a9c7-01f13a035f97"), }, }, { { Guid.Parse("e6214f39-859c-447d-8e16-6d2ab064413c"), Guid.Parse("6cca7479-391a-4473-8710-09dba931efec"), Guid.Parse("b3375706-7fb1-443a-a8d9-ec1994ab2cbf"), }, { Guid.Parse("80060884-2140-402d-8c60-1cbf98a62559"), Guid.Parse("56df715d-28e0-4a43-a8b3-0a88be2d9e65"), Guid.Parse("95d9d605-650f-40e2-bcb0-e24743ec655a"), }, { Guid.Parse("07ce0bb3-26d0-418a-9588-6572b8b138d0"), Guid.Parse("b564ab8e-64b1-4139-ba30-e2b97164d366"), Guid.Parse("c1808e40-aba4-494c-8fb4-6fd0c95a66f2"), }, }, { { Guid.Parse("a6f75db1-13fd-422c-b87a-f4bf5e0ce891"), Guid.Parse("ebca4ad7-62e4-4107-b69b-cebbe35b1705"), Guid.Parse("538fd4fa-3b41-490f-9ef2-402abd74f8c4"), }, { Guid.Parse("7c15b2cf-5e22-4070-8033-dfe302ddf833"), Guid.Parse("836f6a4a-b401-4ca9-870b-d4a725193e21"), Guid.Parse("b8d26314-518b-43c6-84de-fa6f89d39fe3"), }, { Guid.Parse("660ce25c-b52a-4847-9f03-fe62060fed57"), Guid.Parse("022e6001-9efe-49ce-9e11-263be275c188"), Guid.Parse("3802f25e-3467-4088-8ef6-c5a36da502bd"), }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,,] { { { Guid.Parse("6bec72d8-59ab-49ff-94f2-d7bf6f674b74"), Guid.Parse("1829e226-f309-4f86-b435-518dd99c5c74"), Guid.Parse("168a375f-1213-4a96-9500-e159ae85e870"), }, { Guid.Parse("206d0f1f-41d1-4993-8e7f-9a9b8cad9322"), Guid.Parse("c320b7af-2268-4774-8475-94729fcd25b5"), Guid.Parse("3d00de28-92de-49c7-831b-e95564335481"), }, { Guid.Parse("7756a817-9037-4df5-abf6-21d5e277cc39"), Guid.Parse("6a78fbd1-b71d-4f67-bc2e-348169155fb7"), Guid.Parse("1bc08a0f-8f24-496e-aff4-724b43d33a1f"), }, }, { { Guid.Parse("ad467527-c3d7-4211-b04f-1436be2127bc"), Guid.Parse("9f3746a4-7e90-4e96-93ab-ed1ebc5a5ec7"), Guid.Parse("b7ddf57a-7d18-43eb-baeb-91b98645517e"), }, { Guid.Parse("57de9497-fc7a-4759-9e10-087addff80d0"), Guid.Parse("d469f1c4-a43e-4f1c-b94a-feaadef9b109"), Guid.Parse("93466914-9b0d-47b8-a9ef-fd171d8f3d7f"), }, { Guid.Parse("d81dd479-0e27-4e3b-bce2-55938bb7a66a"), Guid.Parse("3addcb72-7320-41a9-b2a5-0a48c8190e85"), Guid.Parse("9971bd8c-9c12-403d-80f2-dd71124a084f"), }, }, { { Guid.Parse("62388f01-96a5-4420-b18d-fec506ddb639"), Guid.Parse("3c097718-33c7-4aee-82ac-22761446a8ad"), Guid.Parse("b9d7fc60-2d26-49be-9bb0-16f077626a81"), }, { Guid.Parse("d078bb6b-f526-4fc4-bcab-f605326ba69f"), Guid.Parse("e1b308ef-ef6f-432d-9315-102e4ae7bb24"), Guid.Parse("f05eace9-a87b-4af9-ac24-d6f3b4d7acd0"), }, { Guid.Parse("a18e08c4-892a-4335-96aa-9d7809f0eafd"), Guid.Parse("38dd9edc-869f-456d-b629-8d6336b7136c"), Guid.Parse("10382468-6ce8-4a6e-b892-8a557a82a758"), }, }, },
},
            new GuiduuidMMArrayD3E1M
{
    Id = 44,
    Value = 
new System.Guid[,,] { { { Guid.Parse("4f1c8459-49a3-4b61-aa5f-b8ca5f1a69cc"), Guid.Parse("cedc6947-4a6e-4889-8dd2-941798ab4e32"), Guid.Parse("a7c966d3-6b6f-4d7f-becb-45c130ce36da"), }, { Guid.Parse("f59f6498-f8c6-4827-badd-c7a6ad8ce19e"), Guid.Parse("06a879f4-827b-49c7-88fa-08896406f67b"), Guid.Parse("ac9bb141-f4c1-4ca4-b451-c66a323534d6"), }, { Guid.Parse("c973d0ae-ad5b-4a96-aa05-622a59187d34"), Guid.Parse("ee8eb529-dad8-4b4d-96fb-669958f6d5c4"), Guid.Parse("3c3adc10-39e3-46f5-9718-12e010792bb0"), }, }, { { Guid.Parse("5282dc9b-0051-4235-97ef-feb521aa37f3"), Guid.Parse("d014f412-9ac7-4ed2-9549-4d367daaa350"), Guid.Parse("4667c335-5c17-4394-ad30-5d43e383ba63"), }, { Guid.Parse("67b96a57-8d1e-42a5-b1a2-11675f010e7a"), Guid.Parse("28d98924-1abe-4188-b4b6-8e51d2f79f05"), Guid.Parse("fb5bfe8f-b9fb-4f0f-b105-afb6b05a8997"), }, { Guid.Parse("fedf7245-c011-4179-a53c-7a4fdbcd9e78"), Guid.Parse("539d0264-b940-456b-aba6-5cf67d3e5944"), Guid.Parse("2d814710-4221-4ea6-a4ea-8f13b631a727"), }, }, { { Guid.Parse("b63fc8f7-4b50-4692-a66e-53009fa06463"), Guid.Parse("6de3fa9e-ef84-4a2d-b1ea-3cc10f8c473d"), Guid.Parse("c58088f2-2ce8-4999-8792-c4cab075cf59"), }, { Guid.Parse("4e096f63-7cbe-48a6-aa36-24e18d1e62e6"), Guid.Parse("f985893f-96f5-4139-84c3-189938081f1c"), Guid.Parse("e1809fb9-3392-4146-8ca7-c3304f826315"), }, { Guid.Parse("a2d4bc02-0d80-408a-a13e-e12c782afc25"), Guid.Parse("901b8d05-8133-4e30-9904-971a6426835a"), Guid.Parse("2857db64-36cd-4460-b7f0-115b15aa467b"), }, }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,,] { { { Guid.Parse("dcd99de6-ad36-498e-b351-ecb11079b979"), Guid.Parse("b9238989-12c7-4211-8d22-c41040b8acfd"), Guid.Parse("3e99ef18-87ba-4592-a1a2-51f1c628ecb8"), }, { Guid.Parse("c96cbee9-386e-40ea-a9f3-8c1a4890d226"), Guid.Parse("62e77f16-4c8b-495b-ab5e-c8e7928c2285"), Guid.Parse("d50cd544-fd27-42ff-9fb5-2878740a93a6"), }, { Guid.Parse("f5f613a1-1dff-4f3d-a86c-a5060760ff36"), Guid.Parse("96ad1156-6bbf-476d-9d36-2bdb9fdc2252"), Guid.Parse("718efb3b-0b75-4573-af03-0eb6589b812b"), }, }, { { Guid.Parse("bc7feab7-39c4-481c-a703-bd57763b1370"), Guid.Parse("786887ab-d188-4018-957e-6137aaf9f9fc"), Guid.Parse("bf73d48d-324d-4da0-bf36-25c5303a28c7"), }, { Guid.Parse("0e6de81b-e613-4c98-b377-a1b7136956cf"), Guid.Parse("843d2c72-67d0-4194-9e1e-1d91c9e3dbf2"), Guid.Parse("71542526-fd87-4191-9a1b-28e6e3c59194"), }, { Guid.Parse("d34684c6-1315-471f-a391-33bd9edf593b"), Guid.Parse("4df0d385-2ac2-4602-9e5d-3b72d68fb075"), Guid.Parse("a9ea5d86-a3bb-459e-acff-df48e08b3e38"), }, }, { { Guid.Parse("1371e5a2-cb59-4838-83b6-a38625b0f0d5"), Guid.Parse("ac5a8796-fde8-4609-8c7b-440c129e9871"), Guid.Parse("9565dc12-a4ce-4af5-8029-bb1d49630007"), }, { Guid.Parse("f346977f-5966-4ef7-80b9-89c4c121f91f"), Guid.Parse("5620aee1-df32-48c5-8dd4-3ba8bea94a78"), Guid.Parse("5bd4b263-6490-4d1c-901b-2c0a4485f571"), }, { Guid.Parse("126a2854-368a-4626-9d5e-0c9582e5a702"), Guid.Parse("48e930af-a9b2-4262-9903-7d66a765ccd3"), Guid.Parse("076678bb-8ff3-4f23-a239-4aa43b31390b"), }, }, },
},
            new GuiduuidMMArrayD3E1M
{
    Id = 49,
    Value = 
new System.Guid[,,] { { { Guid.Parse("b5563d8a-3e15-4eca-9cc2-70aced5b4ac2"), Guid.Parse("7ccb2aaa-7b02-4b88-baf0-86e0c3ca11ea"), Guid.Parse("7729b0df-503a-4a23-a5f1-20d16bf1bb6f"), }, { Guid.Parse("8a1abfe7-c978-4c7f-a99e-9190302e7fdb"), Guid.Parse("9516706d-bb0c-45c2-a03e-a5399684e09a"), Guid.Parse("de380c34-4eee-45dc-a6fd-7087a72fc0f4"), }, { Guid.Parse("00bec84c-3ecb-4444-8f7b-02faa768dd03"), Guid.Parse("58d927e0-355f-4cc8-8fa4-17e71fadacbd"), Guid.Parse("3ce671d2-7441-4d1e-ab60-7a73e8232713"), }, }, { { Guid.Parse("98a6e3e7-1149-434d-8d79-17d0eb83d3a5"), Guid.Parse("52e2df7a-51c2-4780-9350-097d80a03030"), Guid.Parse("b2ecab56-bf61-424c-afff-72dfd361b7e0"), }, { Guid.Parse("fb3e2585-1014-44d3-ab75-c4a3c1503189"), Guid.Parse("46909275-144f-40e2-995b-366d3514bc49"), Guid.Parse("aa6f9fc3-a743-4347-aa0b-96294ea8949e"), }, { Guid.Parse("56697ce9-1e69-485a-ac42-14ff76e0196d"), Guid.Parse("5195526e-6880-4834-ba50-b7051fc305e0"), Guid.Parse("499a83c9-27c8-4643-a0f8-dcb99126ade0"), }, }, { { Guid.Parse("a59bcaf6-fd6b-479c-bce4-cd0bbbbca550"), Guid.Parse("9c3f0e6d-6d3f-43f1-b042-711134d7838b"), Guid.Parse("6648f8f2-f5a9-49b4-adfb-21fba8db85e8"), }, { Guid.Parse("7a4db8d1-440d-4aad-8291-473120ed7b7c"), Guid.Parse("e15a4f63-9db8-460c-81b0-c84599b33c2b"), Guid.Parse("dac39ef0-0f3e-416a-9874-882238eb44dd"), }, { Guid.Parse("4aabb47a-edbd-4dc0-b783-e9e9b749d6db"), Guid.Parse("08724d89-55a4-4c2e-acce-ca7d58c171e5"), Guid.Parse("c9d2bf00-79a6-4676-8d29-02398f2d50ac"), }, }, },
    ModelInner = new GuiduuidMMArrayD3E1MI
{
    Id = 29,
    Value = 
new System.Guid[,,] { { { Guid.Parse("4eb8379c-f72f-487a-a5ed-237fa6a247dd"), Guid.Parse("f895f80e-de30-4ac8-a2c7-ca6284bb0f6d"), Guid.Parse("00cb88d7-33ce-4659-b3af-3cd0db669919"), }, { Guid.Parse("0a605b90-75a8-4a07-ae5c-416cb610b19c"), Guid.Parse("accb361d-4809-4f31-b69d-3013ca8988ed"), Guid.Parse("c89a8275-f94a-4047-8220-de7e9663416a"), }, { Guid.Parse("8255b73f-27b0-4d19-a438-522c43854515"), Guid.Parse("14848611-e5c9-4cad-aea1-f9b05be14456"), Guid.Parse("0c48500f-fc24-4b09-ae07-3b12be754526"), }, }, { { Guid.Parse("5aac5705-2d1a-4ee0-98c0-d5bb7b9fc737"), Guid.Parse("e10cb913-3adc-46dc-8152-44f89e546a02"), Guid.Parse("158ed6d8-3c27-4e14-a4c1-ea1c64b2bc49"), }, { Guid.Parse("f53c752c-6eb1-425f-b7a3-02b32290a10e"), Guid.Parse("375b2224-ec46-4a99-89ad-453ed52557a6"), Guid.Parse("84f70340-e7b2-41b4-a1ac-d7057d49e2cd"), }, { Guid.Parse("de5efb1c-f3dd-49b0-b275-509334d86a86"), Guid.Parse("f7e1957c-7f4c-43d9-9aa5-fd2e0aba3a1c"), Guid.Parse("2121014f-f125-4ca3-b58c-783c6e07843c"), }, }, { { Guid.Parse("69aaa5e3-ff6f-4908-994f-58e5a09386ca"), Guid.Parse("a32d768d-c4f4-4e04-98e8-18a0eb3582d7"), Guid.Parse("79c77667-11eb-4ebc-bc2c-5310e0c82950"), }, { Guid.Parse("5b5729b3-4ef6-4c64-a1e3-16ef2cb58ac7"), Guid.Parse("558ffea2-2f8f-4903-b59b-bdbc94912d8b"), Guid.Parse("e957e081-7a18-4282-9448-6eb0c4418f75"), }, { Guid.Parse("f27f0a64-be52-4275-b0c6-9a34241faa69"), Guid.Parse("abf03611-2a51-4dbf-9d73-68b55ea93ec6"), Guid.Parse("4d584280-a4a3-407b-baed-ef27cd93e4e9"), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD3E1M
{
    Id = 56,
    Value = 
new System.Guid[,,] { { { Guid.Parse("ad72c601-16bb-4493-8882-3ba6d212a31a"), Guid.Parse("9d06a485-a76a-482a-8ea4-1f4a49f7775b"), Guid.Parse("c5c3c83f-9c22-46b5-b6b4-dea9d71f6eaf"), }, { Guid.Parse("8a13caa7-f8f0-47b9-9c6e-9bc8f7c5900b"), Guid.Parse("189fe725-ba2c-4576-8a14-c7c8a2556e3d"), Guid.Parse("3825ee26-6553-4930-b5b8-81f97fd09c3a"), }, { Guid.Parse("aa84ab10-c9cb-4ab5-a76e-2d6ce9dee57d"), Guid.Parse("c4e16842-f14e-4963-8b22-fe99b38bf715"), Guid.Parse("7c50b6a8-a719-4b5f-8b4a-4b4a715d834d"), }, }, { { Guid.Parse("cb13cfa7-e0ad-4b59-ba25-c9a4f1a52828"), Guid.Parse("6e5f5249-d5bc-47f9-bb92-be0550ee16e1"), Guid.Parse("2a8b03f2-563a-494d-aab6-8828aa88cb4a"), }, { Guid.Parse("1cc4e366-c22a-477c-92f9-371f9f941166"), Guid.Parse("9c260e62-ff12-4c69-99e0-e7b70a9bc238"), Guid.Parse("9b0e146e-45d2-4a47-836f-93c7bdc7ed9c"), }, { Guid.Parse("4f4d8233-6fab-4ec9-b248-48485c337eb6"), Guid.Parse("420e128a-c1e9-42c5-8dcb-1a2f4ec5ef5d"), Guid.Parse("e4610a7a-abff-4fe0-96a9-1f8f88ac7b2f"), }, }, { { Guid.Parse("b8a8d69b-6181-4e88-8046-9184bdfae38a"), Guid.Parse("be33f56c-6da9-479c-8b64-964c36a8112b"), Guid.Parse("38074328-d2c5-4fac-b665-8ca7c0e8193a"), }, { Guid.Parse("569cf6f9-5aa4-4ae9-896a-a5740e4089a2"), Guid.Parse("bd69189f-b63d-4b0a-baf8-f7779120ef16"), Guid.Parse("12556140-0329-4b49-b030-28b2150489e7"), }, { Guid.Parse("89617700-59f3-463d-a4f2-61afd6782b56"), Guid.Parse("8ad9d5ba-daf3-4014-add4-2cafd4bf3447"), Guid.Parse("31100777-aaa8-4da1-a776-580f0b5b8aff"), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD3E1M
{
    Id = 62,
    Value = 
new System.Guid[,,] { { { Guid.Parse("2a660c5e-6640-4009-bf3d-89a91d85c3de"), Guid.Parse("04bfc74c-3816-4ffd-acd3-2243fb569aac"), Guid.Parse("3543a087-642f-4bff-b52c-3c4fdd7d60b8"), }, { Guid.Parse("0a29a6f6-0e75-4ebb-877b-83b589b54008"), Guid.Parse("5d26a798-1349-4a2e-8e38-a92a8759e764"), Guid.Parse("7eaab866-570e-41fc-a1d8-e6296510e182"), }, { Guid.Parse("f90f2fcf-0adc-43fd-9fe1-6a29e2413ebd"), Guid.Parse("a6732524-35e8-4770-8e04-a9acc28f3918"), Guid.Parse("0750fa34-1395-448b-b490-29cf14ccaff2"), }, }, { { Guid.Parse("de58cd7e-f987-4eb2-9c00-a4d5eec1c462"), Guid.Parse("7f2a215b-8eca-4985-94d8-30549832a2b5"), Guid.Parse("3fdf8635-c153-4e41-b146-9e64bc67cf7e"), }, { Guid.Parse("5f7544b1-f679-4068-84ac-b78dae41895e"), Guid.Parse("7203e68d-4773-4e46-b52d-614fe98e2d68"), Guid.Parse("15a012ff-36e2-4f23-ae00-519cd5f48be5"), }, { Guid.Parse("ba64e853-1538-4712-a5d9-6742b698aa8f"), Guid.Parse("b2bbed4f-0ff0-431c-9900-fb0f17ba119a"), Guid.Parse("0d25d00a-5867-44d7-b1a7-c4b626ec3a77"), }, }, { { Guid.Parse("a501abb5-6b3d-47b8-8609-c7678ed13d63"), Guid.Parse("ccf35210-88d3-44af-a48a-a5432d7d16d3"), Guid.Parse("e4a596e9-d229-435f-afd4-30b8c1107f66"), }, { Guid.Parse("ae546211-a38e-409a-8d13-443f907d4d45"), Guid.Parse("479b3be8-8d3b-4ab5-a2e7-76d507080993"), Guid.Parse("de819b44-aec7-4d1f-8f2a-d8e820b65374"), }, { Guid.Parse("84f9e18c-553f-4fb2-9b93-f41988d69b0d"), Guid.Parse("2f4d6839-874d-463b-93f6-b5f4ecdc5674"), Guid.Parse("5f382dd6-bc52-45f0-8f9b-da0cbb0ae661"), }, }, },
    ModelInner = new GuiduuidMMArrayD3E1MI
{
    Id = 38,
    Value = 
new System.Guid[,,] { { { Guid.Parse("e9d5637c-4a3a-4427-a437-d99f361a7150"), Guid.Parse("786e2c7e-6c0a-4b16-b6ad-4b1bed170285"), Guid.Parse("c3414e3a-b0c0-4639-8462-d7ac2e2d2c09"), }, { Guid.Parse("6744ac98-e00c-4d3e-a991-85a9609dfa1e"), Guid.Parse("7ae01a5b-96b1-4476-9267-90ed84296cf6"), Guid.Parse("b8725967-e643-4005-b2b7-6b22f99af822"), }, { Guid.Parse("dcf60067-2fce-4a80-9dbe-70bb8b12f678"), Guid.Parse("f1a6bfdb-bb67-4239-9749-d92649ba2b45"), Guid.Parse("2180b876-a0d1-4e40-a61a-a53c1e559e50"), }, }, { { Guid.Parse("d5f38f05-271c-42d5-8b1a-58bd693a1d0b"), Guid.Parse("845a4073-5c79-48c4-9afa-e11883c934b6"), Guid.Parse("80bf3f6c-5e4f-455d-a6f5-aed997829b8b"), }, { Guid.Parse("7ae8a6bb-7bdd-47aa-ae69-271d6ddc3fea"), Guid.Parse("101cd82a-7cd5-4b0f-bc22-e59389e0b986"), Guid.Parse("3089279f-b825-40d5-8b37-f129836871c3"), }, { Guid.Parse("c6d1fcf6-3ef7-49b3-a0c6-2088880fb9c0"), Guid.Parse("02fbb6f0-07fd-4f76-a8f5-c560ecb22ab6"), Guid.Parse("1e094d7f-b423-468b-977b-9127faa983dc"), }, }, { { Guid.Parse("101e2949-89c5-483d-9f7f-c885501e2690"), Guid.Parse("e161f5f9-512f-4f97-b8ab-5ce5dbc7b1af"), Guid.Parse("821c4337-d81f-419a-8a22-9ca8e60df2ba"), }, { Guid.Parse("1f21306d-e02a-4ccd-bc61-7c0df0f2118a"), Guid.Parse("c7113598-33df-4f68-9919-1c9b2308f8e1"), Guid.Parse("41a3b4dc-8708-47e7-a002-a3eba0a4036c"), }, { Guid.Parse("2ddddd1c-04db-414a-a194-3c8e919e6ae5"), Guid.Parse("f7642967-ccf3-4c96-bbb1-7bb1ba88afeb"), Guid.Parse("344f8d0f-eca7-4362-9a4a-21c78fe60276"), }, }, },
    NullableValue = 
new System.Guid[,,] { { { Guid.Parse("8be0fc98-86eb-451e-8d65-5ae62c9ff66e"), Guid.Parse("09463c0f-75d4-4a82-9f31-aa5a11de227e"), Guid.Parse("e9988d4e-030d-4770-8cb3-bdaf12619b42"), }, { Guid.Parse("adbffd6a-4502-47db-8df9-68572c29201e"), Guid.Parse("06d61584-f5f2-49f4-a0a0-aa54a8a23cae"), Guid.Parse("86a47717-3a16-47fe-a27f-1408a2383e4c"), }, { Guid.Parse("839830ee-9b71-4c88-94f6-a961735308b7"), Guid.Parse("c0d27e2a-a7fe-444d-a67e-8462b6939073"), Guid.Parse("2b6fe2cc-bd3b-4e32-ac9a-f60a4afadb7f"), }, }, { { Guid.Parse("f402f847-96b9-475a-9043-0ed596db9fc8"), Guid.Parse("77b7e0e0-071f-4fa8-ac8b-0482f99c5fed"), Guid.Parse("c0de2181-310e-461f-b04f-aa1bd275e624"), }, { Guid.Parse("1ff53d00-3bfc-444b-95c5-c73e34818039"), Guid.Parse("49a63731-13af-4de9-9005-6dcab60298cb"), Guid.Parse("eea1f175-96cb-4608-8858-bcb0965bafdf"), }, { Guid.Parse("5cdd45a7-d9b7-41d6-a4b7-ff37984e999b"), Guid.Parse("734c833f-27ac-4ada-821f-9987a5dc210c"), Guid.Parse("03abe683-c5bd-437b-ac90-eef77048f520"), }, }, { { Guid.Parse("64d4bf7b-6848-422b-b850-18ca0755d07e"), Guid.Parse("cd7ee311-c291-401a-b61b-5d9a755e1c88"), Guid.Parse("4333edb0-8bfe-4a29-93db-0b131bdf3ae1"), }, { Guid.Parse("8127fd14-afd1-4674-9e7a-d88b1dccd8e4"), Guid.Parse("bac974ed-8361-4350-8385-fb945edc9453"), Guid.Parse("20da4f44-39ff-4ef9-9859-0a27c10d5f97"), }, { Guid.Parse("ac695ba2-73bd-466f-a304-f2ceafe06690"), Guid.Parse("95fdbb62-ce20-4ba9-ad42-1167252baa96"), Guid.Parse("87781c05-fa94-49de-bdb0-bba282af1986"), }, }, },
},
    NullableValue = 
new System.Guid[,,] { { { Guid.Parse("c2361326-cc85-4d2c-b981-85b7bd91d34c"), Guid.Parse("cfffe930-d7e6-4509-896f-71e94ac6e1ed"), Guid.Parse("cb966f3d-60b6-4983-b240-7050f0a145da"), }, { Guid.Parse("2a89cc04-8481-41ff-ae1d-dd14dc052711"), Guid.Parse("81cc164b-f193-4f90-abad-e22bf6e45a43"), Guid.Parse("b5b980c6-d787-4d6e-9375-8021edc164db"), }, { Guid.Parse("19759c79-8f8f-4e4b-9dbb-b76b3d5fd000"), Guid.Parse("7950cf51-9d30-4339-bb69-2a29d15c54f0"), Guid.Parse("242196ac-9082-43cf-92d6-94386b805736"), }, }, { { Guid.Parse("63fbcc69-392f-4646-bf81-250059c9c1ce"), Guid.Parse("58e71038-0ba4-4322-93e4-0f766b4be265"), Guid.Parse("9c52531b-84cf-4c0a-928d-14c437d10731"), }, { Guid.Parse("bd0b0c2f-86ea-4617-99f8-567b63bfdc65"), Guid.Parse("148f2eb3-331f-43bb-879c-5366348d184d"), Guid.Parse("7782336a-c2df-4f90-a1bb-9de29eff8bdb"), }, { Guid.Parse("e72704b6-c9b5-48f1-9ad3-c13657f598d3"), Guid.Parse("b8293698-aad8-40e8-a646-5327ec560139"), Guid.Parse("9be1208b-77fe-428d-ad1a-9cefd217e471"), }, }, { { Guid.Parse("b669a2fa-ac1d-4fa2-9394-6e1a7581b419"), Guid.Parse("2842d73a-c44e-43c2-a0a0-b97450c53a4a"), Guid.Parse("4138781f-11b6-4871-b488-becc1e6741f5"), }, { Guid.Parse("fdb20db8-61ba-4577-a6a0-1f6a1ca9a8ff"), Guid.Parse("134731b9-0442-4756-ae4e-fe711257fd40"), Guid.Parse("9a45507e-0742-48c9-a760-334f3713e678"), }, { Guid.Parse("5786b92f-e78c-41ab-81ca-08e57b7d454d"), Guid.Parse("64797e10-0c01-4000-a812-a5ce446136a4"), Guid.Parse("74f47f21-ac69-45b9-8b60-8db45fd936bf"), }, }, },
},
            new GuiduuidMMArrayD3E1M
{
    Id = 68,
    Value = 
new System.Guid[,,] { { { Guid.Parse("7093afb9-a414-4a99-b077-39d13761bbfd"), Guid.Parse("13e2b4a7-ffca-402d-8205-e74c66c82ae5"), Guid.Parse("b60f20e1-4a34-4166-93af-0d46c3867baf"), }, { Guid.Parse("219824ec-2210-4e12-bc3c-74df05da2b5f"), Guid.Parse("241c3bf2-cf13-4ad5-b1d6-6ab813bec91a"), Guid.Parse("438a8cb1-30e2-40c2-be89-005510122979"), }, { Guid.Parse("edbd7950-5d85-4679-ae7b-b05b625d4e2e"), Guid.Parse("347359e6-fa56-41d9-b732-c8bbd90d9b7f"), Guid.Parse("aaebd10c-7c5c-4b4d-bea6-fbaec619916c"), }, }, { { Guid.Parse("a789f548-d918-483e-ac9b-9a1f3de57967"), Guid.Parse("e52d90bf-27d5-47f5-9903-0bc565ac6a01"), Guid.Parse("3a4d9401-8683-46dd-9686-a3236e6721fc"), }, { Guid.Parse("8020aaac-1b7c-4300-8132-5b90e8ca3d6f"), Guid.Parse("4fcb194d-f301-40b4-a40b-056fb4f58876"), Guid.Parse("3b7bec62-ad08-4c78-8865-b69c2ce5bdb1"), }, { Guid.Parse("084c089c-a0be-48dc-858f-12267f13bb86"), Guid.Parse("0f8a6d58-be65-4bf9-b5c3-c34f88e6f9a5"), Guid.Parse("e84b58b3-67cc-4e37-a29c-3339bb2168eb"), }, }, { { Guid.Parse("7ae8bb0b-b8da-444b-a2c5-88b724eb697b"), Guid.Parse("b414d7f4-5250-44fc-84c9-4e51d30f9456"), Guid.Parse("86fd95c3-c77b-407b-b485-b4d3f065dc83"), }, { Guid.Parse("0b6abd6c-3342-4ae7-bcda-bb807bb22e06"), Guid.Parse("6c27ab61-749d-4034-9d93-e9c8c7391f37"), Guid.Parse("4ae3f7a8-34d8-422e-8bbd-3506cda33b52"), }, { Guid.Parse("e12c5520-c834-457e-8c8e-c4eaf2264fb3"), Guid.Parse("e239fc90-ff91-4199-a22f-ddb0f6af2ccc"), Guid.Parse("7d2f2b5e-e697-42b5-973d-99f966d1de06"), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD3E1M
{
    Id = 69,
    Value = 
new System.Guid[,,] { { { Guid.Parse("3e61283e-eb1d-4576-a4d0-7f7d0e76ab30"), Guid.Parse("280b704f-8e7c-471b-b375-1203858969f4"), Guid.Parse("70548899-185e-4e7a-8458-94f3c4e9c1bd"), }, { Guid.Parse("d4aef207-79e5-40bf-84ec-98556f122ed3"), Guid.Parse("49f67c8a-7fb1-4626-9a28-8a3d441d12a0"), Guid.Parse("5094d76a-5e5c-4ff3-8cb0-96e53ab1d9a8"), }, { Guid.Parse("d1063598-81e7-41e6-9f41-f51f95909354"), Guid.Parse("80e4ae58-81b2-4ec1-ba2c-1c68304cdbe4"), Guid.Parse("0697d867-4da3-4188-aea9-12910110dafc"), }, }, { { Guid.Parse("d98ea08f-c72c-402c-a0c3-c9bc1a56865d"), Guid.Parse("e021bc60-4f24-4f5c-aa13-605c9ebc9d14"), Guid.Parse("2efccd39-aa30-44df-9d72-db313dc1c12c"), }, { Guid.Parse("cf10ba89-7514-42bd-862f-3c09651946e1"), Guid.Parse("1785cf31-a737-4ca8-a77f-3681dbfdb5e0"), Guid.Parse("94036378-5c85-41b1-b16e-2b0cd17db935"), }, { Guid.Parse("930c160a-0fd5-40fd-b41f-a72f9fd958ce"), Guid.Parse("b25488b5-bb07-45ee-936e-f8433b79cca5"), Guid.Parse("f32ddca9-a988-4049-b943-5426d70c228e"), }, }, { { Guid.Parse("52603a21-7bf1-4426-98ab-ac5efb77ec81"), Guid.Parse("eabe6640-2e8d-43f9-9dc4-4c43c2719fc7"), Guid.Parse("f6fed2a6-4370-40da-82a6-978faeb1e432"), }, { Guid.Parse("4426a025-88d4-43d2-a06a-3b553b72746e"), Guid.Parse("2bb1ee64-ba8a-4962-abc3-7b3e46e6766c"), Guid.Parse("bd59ee1b-b2dd-489e-9333-70c7952a8295"), }, { Guid.Parse("31ee3fba-fef6-4dc4-ab17-a312554d8612"), Guid.Parse("773d9051-d500-4ffc-930e-76925dd241f3"), Guid.Parse("dafa222c-b4c5-4bbc-bb9e-62cc2ee18e20"), }, }, },
    ModelInner = new GuiduuidMMArrayD3E1MI
{
    Id = 46,
    Value = 
new System.Guid[,,] { { { Guid.Parse("93017422-ed7e-411d-8665-131794da16fc"), Guid.Parse("ab386f43-b748-49b9-9077-6822e0d5eb58"), Guid.Parse("bc00d2d8-83b1-4007-b743-140449631936"), }, { Guid.Parse("c66396d8-6025-42e7-92c1-33466588f06e"), Guid.Parse("8bbc1866-b455-46b9-b84a-8a02e60bf825"), Guid.Parse("57aa0ede-aa54-467b-8926-a62495a8dc58"), }, { Guid.Parse("59476aa8-6387-4a47-b6fc-b603b65ec7b8"), Guid.Parse("72d217e2-312b-4954-849f-5bebf88d1e6a"), Guid.Parse("e97214a2-600c-4fd1-a53c-1f2643c8e9e8"), }, }, { { Guid.Parse("437e9843-e9e0-439b-b581-d288f721b7a5"), Guid.Parse("ed7f0c2d-b6cd-48e2-ace4-641583e11e47"), Guid.Parse("b9d95f80-5a8f-45ee-a3cf-f092746419a2"), }, { Guid.Parse("ec4ecc61-e734-4814-a734-4c781b5a6b84"), Guid.Parse("fde4f533-6c94-4b0a-a12f-f910435cb951"), Guid.Parse("e1fde508-ec42-469a-bdb2-5c27242fc44c"), }, { Guid.Parse("31f242db-59ed-4c32-8029-3570c1b512e1"), Guid.Parse("5a49b8b2-793d-40a0-80fd-228f44def262"), Guid.Parse("3dde414f-d22d-41aa-bc19-ffad1ad8f555"), }, }, { { Guid.Parse("3cef2559-d763-47c7-9c19-341dffb6db76"), Guid.Parse("005185f3-3f4d-4aaf-9e0b-31f3d0bbbb31"), Guid.Parse("38e6f0f9-191e-409f-a628-13174d1ccbaf"), }, { Guid.Parse("6e96f46c-fa2e-4b26-b94e-1db22c1138d7"), Guid.Parse("b8dece37-9382-499b-a202-e2416ed5756f"), Guid.Parse("1c2ac8e7-f793-40b6-a948-8b1a48607d8c"), }, { Guid.Parse("d99228d9-4dda-4dbc-b9b1-bc6a93abe227"), Guid.Parse("8de5075b-7a33-49cc-ada9-8581e03ca5d1"), Guid.Parse("6d18b264-232f-4f2d-ac54-0c68c7831e59"), }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,,] { { { Guid.Parse("e0f92ea9-091e-459b-8208-7fd54dd1b851"), Guid.Parse("f6c7690d-4d99-4b52-a1da-9ae999014a44"), Guid.Parse("09d8bb6a-04d2-4b5d-86c2-1b987e9b4b3e"), }, { Guid.Parse("30f78d50-8281-42b1-853d-5e24b13adf97"), Guid.Parse("4a603549-20cb-4ea4-9a50-bac297d13557"), Guid.Parse("540445a8-6d09-404f-aec4-98e96e12309d"), }, { Guid.Parse("a5097552-7438-4028-85b5-c62ffb62b38d"), Guid.Parse("69c446d0-54aa-45ae-9831-72649f9f2170"), Guid.Parse("b068c8d6-afa6-4bc6-b0a9-0ed7afea1f2c"), }, }, { { Guid.Parse("6090f3f9-9b3f-411d-913e-40d2aa17cb6c"), Guid.Parse("6d6624ff-3a3b-4734-94a1-aff00f5286f3"), Guid.Parse("7aeb70f9-6759-4af0-9a4a-70cdb3f1eba6"), }, { Guid.Parse("eb2395a1-173f-44da-86a6-093061fb61ca"), Guid.Parse("e53e5bd5-e416-4fa0-8b20-662bdcc7b558"), Guid.Parse("9b544afa-5e24-4d2f-9c3f-2fe11ae507ce"), }, { Guid.Parse("fdf23582-44ed-49e8-9dbb-96bf3529c61b"), Guid.Parse("965daca6-c22f-4fd7-8935-bfb5cbcb8106"), Guid.Parse("50d95bd7-4c41-490e-9ae6-f04fea449ad8"), }, }, { { Guid.Parse("25e6b889-2105-4076-8079-9d2022e471aa"), Guid.Parse("cc184c9f-2740-40aa-8f1f-40102b0d5461"), Guid.Parse("64366040-7e2b-4b36-af87-ca1f5edd2991"), }, { Guid.Parse("e96a3a6b-00e2-4f5d-bb7f-21e0ae5c469f"), Guid.Parse("45fc02c8-8063-4b12-8c52-aebad73c429a"), Guid.Parse("7c8c7b33-fdc8-4238-b4eb-0b5a33998b19"), }, { Guid.Parse("a7d9f702-5bbb-40f8-add5-98e06b14562a"), Guid.Parse("2e09960f-ba98-4f9d-9876-b9ee1e157803"), Guid.Parse("7699fb35-9055-4404-a3bb-0f1a3dae1682"), }, }, },
},
            new GuiduuidMMArrayD3E1M
{
    Id = 78,
    Value = 
new System.Guid[,,] { { { Guid.Parse("a54dcf2a-6497-4332-a343-9b3d48bc409d"), Guid.Parse("7d4b3164-c2ad-40a4-9056-c63592decf07"), Guid.Parse("0755d5b8-3bdf-4f6b-ab9a-419a0a71be8b"), }, { Guid.Parse("fe4c0f23-d138-44ac-bd3c-c00b42ff076d"), Guid.Parse("5cc1233b-89b6-4439-ab11-217ce1b4338b"), Guid.Parse("8c01dd51-d1eb-4978-bb47-72903830f641"), }, { Guid.Parse("f49ec15d-5978-4ac0-8fac-5a44671b88b9"), Guid.Parse("987143cb-5fa2-498e-8dd6-4e5cb2c8957b"), Guid.Parse("da5f953a-39ce-4493-8718-89c5f6884a8c"), }, }, { { Guid.Parse("07a88831-9dbe-482a-9dba-735df6cc9c68"), Guid.Parse("45e4e4e8-0657-43f0-b236-bfc2e10fa024"), Guid.Parse("c674483a-1c5f-4dff-bbde-9d03ea3d613e"), }, { Guid.Parse("844a8f0c-16aa-40ab-b79a-e081aebd02cc"), Guid.Parse("90abb136-74fc-4b02-bcea-99a04278379e"), Guid.Parse("d3a38930-b6fb-4232-97ac-527be129fd57"), }, { Guid.Parse("c30cdae9-5415-4b77-8234-dfc3d52f14a9"), Guid.Parse("38d31704-29c1-430e-abeb-bd74403dbd34"), Guid.Parse("b0fe5d74-a869-42a7-8fe4-65104a1266c1"), }, }, { { Guid.Parse("1fe24ee3-adc2-44db-b025-23556c5d4075"), Guid.Parse("00aa3ee9-119f-4b89-a8d5-15c119cbfcfd"), Guid.Parse("998cb1aa-6fc4-42db-8881-9e5499bba15e"), }, { Guid.Parse("b5979f1d-d6b5-42d4-9f0a-6604c8273850"), Guid.Parse("63cfe676-1c30-4dd4-82df-46bb700b2320"), Guid.Parse("224085f7-ddfe-40e5-a3cf-0cb24a560964"), }, { Guid.Parse("1e076957-e739-4090-86f0-1fa9b6962987"), Guid.Parse("a5761d56-19c1-4be0-9104-d09a7122d1f8"), Guid.Parse("05aca409-329c-47a1-8233-0084feeccafd"), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD3E1M
{
    Id = 83,
    Value = 
new System.Guid[,,] { { { Guid.Parse("5947c769-f48b-4577-ac40-1596c8323788"), Guid.Parse("8d2d2dfc-0013-46f9-9c28-10647f380ba2"), Guid.Parse("5b0084ee-4cbc-40b9-8af0-68a298e2f324"), }, { Guid.Parse("b8ba0949-8f36-4477-8b74-a165050eac46"), Guid.Parse("00688672-a3eb-46d5-8e33-ded6d83f4df0"), Guid.Parse("31c74bf8-b58e-4129-af58-e538446bd39e"), }, { Guid.Parse("878b5d0f-466f-44d7-b8ee-516dc8232ccb"), Guid.Parse("bff60c43-6d26-4c0c-b5e5-a1cd1845ecd6"), Guid.Parse("5f4932d5-5b0f-44af-a4ba-cf7975f5811a"), }, }, { { Guid.Parse("c4107315-4a7d-4b30-addd-e3c5135fb9de"), Guid.Parse("a4a25f93-6af0-44a2-8643-f31678c1587c"), Guid.Parse("5d92c755-8847-487e-8f1f-1b8e19b82014"), }, { Guid.Parse("0ffa83c6-7133-4c51-a4b7-dea998114c36"), Guid.Parse("e7e393e6-d659-4b50-854c-876b27af8c16"), Guid.Parse("15016291-393b-47af-b700-b2a8dce7bf36"), }, { Guid.Parse("2c714aca-2621-4f70-acae-d129e8389214"), Guid.Parse("014446d7-a665-4fb5-b6e3-144402c4fb1e"), Guid.Parse("612d4b97-6308-4676-89dd-1f11909f16e3"), }, }, { { Guid.Parse("9b1fbbc6-7a15-49d6-896e-2d64188ce04b"), Guid.Parse("dae7d3c2-76e6-4a2c-8d56-7fd3c0ab4eab"), Guid.Parse("16b0c364-2fe0-40a4-8ce3-d88bcf290c56"), }, { Guid.Parse("b1865fbb-6f2b-47f0-a74e-bb56a8e3933e"), Guid.Parse("e239f740-8101-463f-b575-ea872fd94a08"), Guid.Parse("5f17ef0d-7d68-43cd-9e23-5b16ea5f0cb3"), }, { Guid.Parse("f00d719a-6069-409e-b520-d0b246c9c567"), Guid.Parse("d37c5a6e-ea82-4fb5-860d-1d164c6ef811"), Guid.Parse("d2f1e812-4a18-4f92-aba6-ea9e769d3b30"), }, }, },
    ModelInner = new GuiduuidMMArrayD3E1MI
{
    Id = 48,
    Value = 
new System.Guid[,,] { { { Guid.Parse("6b507273-8a3a-47d3-be1e-fcdf1a3705ee"), Guid.Parse("60be3bc0-2dde-4e8d-847d-5ea96367a1c1"), Guid.Parse("fc156882-8c2c-4689-86dc-0d06ea1e2187"), }, { Guid.Parse("a6c7299f-ea26-40e1-b594-0b7d9c2779cb"), Guid.Parse("a6ea0727-65cd-4103-8807-d42ce3affff5"), Guid.Parse("b48b1a75-6fda-40ad-a727-54cde3fb1332"), }, { Guid.Parse("7ce21f33-e8ef-4277-9dae-8d6acf9494c1"), Guid.Parse("53556d42-ba3b-485d-9c0d-e9bebe02ca73"), Guid.Parse("b0f116ac-ac52-42e3-b95f-f5d8cf90dac9"), }, }, { { Guid.Parse("c9918787-6494-4787-934e-8f355bf40d7e"), Guid.Parse("2addfcf9-2d1f-4d2c-a33c-2821b14efa7b"), Guid.Parse("0cf873ac-3a32-4589-b08a-c36807f02745"), }, { Guid.Parse("4ba5157a-d5e4-4a1c-bedd-340b4f4106e1"), Guid.Parse("c5590b10-5037-4252-aecf-5efaabc6cb25"), Guid.Parse("74c5d4cb-3565-4ce1-937a-8d15ae0f8cf0"), }, { Guid.Parse("81f396bf-1c85-4748-bf5f-e4e2b9e50c6e"), Guid.Parse("3cb9ace8-aaf7-499b-ae9e-6d2ea5ae293a"), Guid.Parse("7ce1232f-a22d-4400-90cf-1edea3815887"), }, }, { { Guid.Parse("fc099ae0-1423-45cc-ac29-6c040f56d232"), Guid.Parse("e8de52c5-8586-4256-94d1-9f13f5f7f97e"), Guid.Parse("cbe94881-03e5-4a4e-849e-49f45cdcf551"), }, { Guid.Parse("4d50fc23-73b1-4f64-aa88-0b6f52267c6c"), Guid.Parse("8f39ab0e-2289-41bd-868e-9c6b9b5aa217"), Guid.Parse("950aac38-7e40-4bf2-ae87-1500737d0677"), }, { Guid.Parse("2aa56fb6-634d-461b-a6b3-8b97b80eb0e8"), Guid.Parse("a834158b-401d-4573-989f-1e00b79a78f8"), Guid.Parse("0e1b7b5a-0617-4f95-835a-b24353bd31cc"), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD3E1M
{
    Id = 84,
    Value = 
new System.Guid[,,] { { { Guid.Parse("a7dee752-0e59-4e24-9eb9-ff90fb4c3819"), Guid.Parse("3db513a0-9c8d-4609-84b5-3d56dbe2a384"), Guid.Parse("91519fb0-34e4-42ab-a613-cddd398c4db4"), }, { Guid.Parse("b36beb71-cc82-4230-a7e0-bb12d2e17e94"), Guid.Parse("7bba12bb-e2d0-4b72-9564-7d255e1cf368"), Guid.Parse("7c1a1313-0298-4905-869d-db8b0ff0af8f"), }, { Guid.Parse("6c5fd3dd-a31f-4043-843c-615333a40919"), Guid.Parse("59179f70-ddca-4fa0-be71-8e08e60db3fb"), Guid.Parse("24e30ede-d2b8-442e-8671-f12fdc82c300"), }, }, { { Guid.Parse("b6f71096-ffac-4553-9e6d-990673bad6d8"), Guid.Parse("b7f6a38b-1c69-4ec3-907f-ea2da5a83ff1"), Guid.Parse("c85ed5bb-c8e3-4cad-8671-c1701780637c"), }, { Guid.Parse("3d3c2251-b726-4c3d-bf7d-553b0caefdfc"), Guid.Parse("f20e7e99-da3e-40b7-bca5-63d56c3ad51f"), Guid.Parse("54878e57-5924-47f3-8d5a-bd4342fbbe94"), }, { Guid.Parse("d6172c42-aac0-438b-b9ff-6cb3a516a27f"), Guid.Parse("f8823b0f-ae72-4a26-a95b-ab688bfa1f70"), Guid.Parse("94bcdb59-83d1-4ebd-b066-e0e05b2cc048"), }, }, { { Guid.Parse("0ded622a-c395-4b54-8d3c-e928238ebc4b"), Guid.Parse("a9be93d5-dc85-4d1e-8842-f547fe31fc07"), Guid.Parse("2d2630b7-bec7-4cc4-9e8f-fa10606fad9a"), }, { Guid.Parse("02162196-ee68-4db1-b527-0056510a4014"), Guid.Parse("15bc0734-4f0c-42ac-90a5-a8a7a01d8582"), Guid.Parse("40f935a0-9bc1-49f9-97ce-9d6b27dc74f7"), }, { Guid.Parse("46143ae1-6f1e-4962-bad0-78b309fb3be0"), Guid.Parse("c8c4c5f3-754c-472c-95be-faeb3428feba"), Guid.Parse("df6107f4-ed0f-468c-9471-f169495fdd5c"), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD3E1M
{
    Id = 92,
    Value = 
new System.Guid[,,] { { { Guid.Parse("30f9e3a1-eafe-401b-8067-6885a29313b3"), Guid.Parse("ad71b515-69c8-49a9-933d-64d2d895b675"), Guid.Parse("ced27d35-e797-43ce-a5ee-6ac082f9ddeb"), }, { Guid.Parse("409e9d48-552f-47dd-8ceb-5fdc42207d56"), Guid.Parse("b55135fc-96f1-4d89-a210-c2f0d19e6c80"), Guid.Parse("61e4f06a-42b3-4175-9f93-3aa0b59fc63a"), }, { Guid.Parse("2d2a6472-490b-4741-a5d1-a7ff5961e28c"), Guid.Parse("388d223c-717a-43d3-a1ff-e297ced184b7"), Guid.Parse("7bf55dfd-b22e-4493-8ef4-2e4ad548ef9f"), }, }, { { Guid.Parse("f18951e5-0295-4ab8-a589-e483921429e9"), Guid.Parse("7c6c7c4a-34b3-4e48-a7e3-528e8f453443"), Guid.Parse("843efc17-781f-4bb8-bdb3-d544ae37add8"), }, { Guid.Parse("8cbfe849-84b6-4728-af9f-22c3091bfa8c"), Guid.Parse("627f01cd-2b66-405d-b810-d6310a97125f"), Guid.Parse("310035dc-96d9-40c7-8d16-8ae4bf385825"), }, { Guid.Parse("5687d4ef-66d2-4ddb-a342-c5e4e43799d7"), Guid.Parse("f6b621d1-7895-471f-84b0-dfa07e9124f5"), Guid.Parse("eddcbb70-6af5-4ae2-ac5d-98164bde9858"), }, }, { { Guid.Parse("cd573100-a9bb-461f-99a4-c225af0fb6e9"), Guid.Parse("b1987507-3230-4bf2-8233-7c07cfb90596"), Guid.Parse("be15ce4e-32c3-45a8-8ef3-6d2053fc217e"), }, { Guid.Parse("35a4a7ff-a220-41ed-b253-f546cf8dd279"), Guid.Parse("576df910-afc0-419d-9bac-d07e29822624"), Guid.Parse("4f4e5580-3a8d-4760-87fe-a181c182c4ae"), }, { Guid.Parse("03bab856-1d51-4168-aea8-626ac5eb6e26"), Guid.Parse("5955df8d-7adc-473a-ac8d-f58fcddf16a1"), Guid.Parse("f0a298e0-40b4-4a51-b4cb-aa665afd8748"), }, }, },
    ModelInner = new GuiduuidMMArrayD3E1MI
{
    Id = 53,
    Value = 
new System.Guid[,,] { { { Guid.Parse("d02d33a1-1e19-4169-b608-4aaad4309a07"), Guid.Parse("02564950-fefc-48f1-8b88-15ae3dd501bf"), Guid.Parse("5761383c-71d0-4486-a55c-ff15d19e61f5"), }, { Guid.Parse("17a45fcf-ec87-48af-afb9-9693a476a511"), Guid.Parse("03b03811-5bf9-455c-876c-8b17300f5188"), Guid.Parse("0ca32cfa-fbe9-47ad-997e-f1ff1295f012"), }, { Guid.Parse("2a9b7f90-7d9d-48e8-b9fb-0b01b28065f3"), Guid.Parse("0259161c-9dbb-4d1d-855d-80b499b1d938"), Guid.Parse("9889fa6d-15be-4037-ac14-a7feec650a87"), }, }, { { Guid.Parse("dd7f920b-efa2-46a9-91d9-e1c373715632"), Guid.Parse("1cc238d1-f1d0-41d0-a2a6-32e0c1667295"), Guid.Parse("340accac-afa2-474e-beb4-7c59b73cd167"), }, { Guid.Parse("9680ffc7-160e-4359-9365-e478d8d59834"), Guid.Parse("15850be2-053b-487a-90b2-a98406a07581"), Guid.Parse("9f44c538-f296-4956-ba56-dba3763811df"), }, { Guid.Parse("eae7c2a9-5078-47a7-8043-c80a2487598a"), Guid.Parse("7dabbb2f-6f97-4141-8cb4-700be6ee5b1a"), Guid.Parse("40f17dbc-3fdd-4864-bc72-07955b220f09"), }, }, { { Guid.Parse("221b3adb-493e-4b8b-a2ae-b611d10dd5a5"), Guid.Parse("24683d3c-67e7-4d77-ad4a-1503433485da"), Guid.Parse("108ae0fb-a9e5-4fe5-af4f-15ea3e59d120"), }, { Guid.Parse("24eb4878-2eec-433a-a2b2-8d61734e33e7"), Guid.Parse("c453c21e-1d0e-4299-ac1b-bb4718f6a1ec"), Guid.Parse("1a74919a-50f7-485c-935c-60914902aa30"), }, { Guid.Parse("5ce72d4d-3e22-4cc9-a299-2a812eb7058c"), Guid.Parse("e5d2d144-5192-46e2-a34e-d36ab84fce2d"), Guid.Parse("b7372316-6812-4cf3-a1d9-ab568bccee23"), }, }, },
    NullableValue = 
new System.Guid[,,] { { { Guid.Parse("21c7c1ce-693a-482a-bad8-1ee464d3a1c4"), Guid.Parse("b3a1dbbf-09f9-43f2-8a83-cf8d2d0b92b8"), Guid.Parse("294e8683-988d-416b-9588-8b4d1bf8e54d"), }, { Guid.Parse("edbc1b2f-e685-4103-8add-f73aa6c85c42"), Guid.Parse("bbf4932d-b1a0-45c3-a8de-c472602b3e9c"), Guid.Parse("7902cafe-dd27-4beb-88a7-122a0991da60"), }, { Guid.Parse("1f2deb06-bde0-4098-996f-183389e30463"), Guid.Parse("2884607d-c8ae-41df-ae1c-ff6a8f8e8e0e"), Guid.Parse("96641f17-c116-4c2f-9efc-1977a82edfc8"), }, }, { { Guid.Parse("433302dd-fc84-4afc-b791-8305113e9746"), Guid.Parse("c19bcb13-2d13-48b6-8606-d4993e644ac3"), Guid.Parse("a018efe1-82ec-42b3-b92d-a80740632ea6"), }, { Guid.Parse("98448304-e00e-4b76-94e3-cd95af588e4e"), Guid.Parse("4ff850f7-a30f-411d-ba76-f451d47bb6bb"), Guid.Parse("4db55769-0f98-4c4e-9129-87822692ceba"), }, { Guid.Parse("49f282e1-0d01-4c7d-a08a-8db69b37be8f"), Guid.Parse("f9281d67-cdab-4ec6-b448-3512d1d8d7db"), Guid.Parse("23e3856c-29a9-4917-ae62-f2e9aea934e5"), }, }, { { Guid.Parse("5f8fa76a-42bc-472d-bddc-11ced2e55a11"), Guid.Parse("c0d3c64a-294d-4a77-865f-ea4954fe4387"), Guid.Parse("2503c902-ded3-4e49-b9c3-7c58acca5c87"), }, { Guid.Parse("99410306-731b-4c95-b7f7-0c8f5310c351"), Guid.Parse("624c63cb-1dae-4ceb-b651-d66f2e6c5f48"), Guid.Parse("b5e93653-ae3a-418e-b5db-0dcca8d31676"), }, { Guid.Parse("65c0ad16-7a0c-4231-89fb-cc48ca594650"), Guid.Parse("77df8266-be0c-4d37-b6cc-5ed482918262"), Guid.Parse("8a8f199c-a810-490a-904e-a8bfa7a219b0"), }, }, },
},
    NullableValue = 
new System.Guid[,,] { { { Guid.Parse("906372c8-4314-4504-9e4a-5895f3a47266"), Guid.Parse("3874f990-24c6-4bd2-b0c2-c5132a3f8535"), Guid.Parse("008f8ea5-d1a7-442d-993c-2135e9fbdfe4"), }, { Guid.Parse("9cf40cc9-06f7-43d2-9a9d-534cf3293832"), Guid.Parse("b4a91a65-8377-4070-b028-1b63808a9a0d"), Guid.Parse("03375a0a-48fd-4b27-b1ea-65468aa7005a"), }, { Guid.Parse("4461ee10-be91-4ba0-aa9d-0008debb5cff"), Guid.Parse("ac6585d0-5e52-49b8-b4a6-0d8c3a95b6a3"), Guid.Parse("2e7fa9b3-588c-458c-ab12-bb4cb79e6b40"), }, }, { { Guid.Parse("6a8c8164-4d9e-40f0-a196-c30dac08376f"), Guid.Parse("89ee9857-df10-4f0c-9924-e3e901fb74ee"), Guid.Parse("9d992da2-92df-45ad-99a5-3aafda069eb6"), }, { Guid.Parse("db6a6579-fa4e-4edb-b0db-65d713f15d3b"), Guid.Parse("4131d643-c119-4e3e-88fa-c701b37d088d"), Guid.Parse("59456791-814e-42c3-8999-2ddc428f2521"), }, { Guid.Parse("85030d28-3578-4f50-85a8-f157ba49bb18"), Guid.Parse("0aa80e81-b54c-440a-aba7-8fcff951abd3"), Guid.Parse("1570e028-22aa-42ce-b14d-6e7b4d0d1a11"), }, }, { { Guid.Parse("210236e3-b2a8-48e9-9a3b-e9996160a736"), Guid.Parse("e0ca7cc5-4ff2-4f10-bd70-2f057b0ec229"), Guid.Parse("9f47fe80-198e-4bad-973c-ceac5a8eed81"), }, { Guid.Parse("40efc487-bf42-4090-880a-f30e1ae72f35"), Guid.Parse("7ab6d781-087d-4c82-b9e0-967973ed3ce1"), Guid.Parse("902b9a6c-dd42-4801-891a-fd8d017aca80"), }, { Guid.Parse("74e08816-b61d-41f5-a2ab-8783cdded217"), Guid.Parse("909a1dc2-1b95-4fc6-9bd5-e2ae52e52759"), Guid.Parse("1eaef628-ece0-487d-af0d-df78c7060973"), }, }, },
},
            new GuiduuidMMArrayD3E1M
{
    Id = 99,
    Value = 
new System.Guid[,,] { { { Guid.Parse("774be167-b561-4faa-9faf-95537b5df83a"), Guid.Parse("5736f4d4-94d2-4177-ab91-4fc7970343ec"), Guid.Parse("a8f8722e-4089-4a36-b28f-b6904cd79a66"), }, { Guid.Parse("4039130a-d0db-4ac4-8492-25bb73721091"), Guid.Parse("7b08e8e2-226c-468a-a8d9-4a8962a5e813"), Guid.Parse("0c0e7c4f-ae1c-449d-9306-1d58a31b58ac"), }, { Guid.Parse("3b703151-77e4-4ec3-83a3-885ddadd90b8"), Guid.Parse("c58caf47-805b-4c31-b3d5-9d5defa2349d"), Guid.Parse("455166c1-6d61-4516-a4a9-90944a134412"), }, }, { { Guid.Parse("34284896-2c82-4f50-aacc-f9386b012485"), Guid.Parse("e3b010e9-7557-42b0-b6e2-0a04728e6cb3"), Guid.Parse("e81b7c0f-219c-4acd-a280-63131f78a307"), }, { Guid.Parse("f28c6bd5-5b9a-4b55-99ba-d5908e7b5b95"), Guid.Parse("d08f3727-6191-4f1d-83a7-501c3e886797"), Guid.Parse("d80eefd2-9625-4bc7-a64e-d3307ff7dfe0"), }, { Guid.Parse("0c11894c-469c-4e3f-b72f-11ef7d7123d3"), Guid.Parse("bdf5623f-eefe-4a79-96b6-837fa351e160"), Guid.Parse("af73ed38-febd-445a-a9d8-5806fe58de28"), }, }, { { Guid.Parse("7bc87849-878d-4441-8b41-efde2a7a9667"), Guid.Parse("79c5c885-3534-4f83-ba02-6c9eb31f0032"), Guid.Parse("d18ef73b-085c-4eaa-ac1e-3190c939b47e"), }, { Guid.Parse("88a86025-4e34-4aaa-84a2-af3b7c79d561"), Guid.Parse("657f6251-7f8a-49d7-bbdc-5c3d1437d13c"), Guid.Parse("0b10af56-2524-425b-a632-5c4aa9b82902"), }, { Guid.Parse("e9515212-a3fb-4876-a265-561cc71f34e5"), Guid.Parse("5d6e862b-1b36-440f-9b1e-20e02b3a7116"), Guid.Parse("a541934c-0ec8-465f-9167-3508f79f5d20"), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD3E1M
{
    Id = 107,
    Value = 
new System.Guid[,,] { { { Guid.Parse("4fad6f19-bace-4265-ae0e-e3a2482cc612"), Guid.Parse("4e0c92cf-f78c-42af-b0d2-5dfbdd43963d"), Guid.Parse("25522a36-9493-4a50-9849-39fc7ff778e6"), }, { Guid.Parse("2eaf9c20-1d01-41c1-ba00-d849a00292cc"), Guid.Parse("a9fb4d4e-2f41-4a69-97ca-11ff16227ab2"), Guid.Parse("6f6018a4-1633-43bb-97a4-17d26e9e6b70"), }, { Guid.Parse("9c59aa25-1645-466d-b2fd-10003212c095"), Guid.Parse("6c238a47-2c5b-4bad-bb2a-cb74995b5cdd"), Guid.Parse("2e41d51c-7383-486c-93ef-6cf18f3c643e"), }, }, { { Guid.Parse("e5bfb1da-ffd0-4f8c-8665-4af514636880"), Guid.Parse("f3ca7996-d329-451a-a336-aaee5feef742"), Guid.Parse("ee98c0ca-0f2c-4869-a1ae-d56f730a222b"), }, { Guid.Parse("0833a63f-724c-411d-80ab-193823cbbbdd"), Guid.Parse("afbcbf40-0fa9-465b-84d7-3518aec7eafe"), Guid.Parse("0177fee5-02f5-467e-b8f1-6efed6972da3"), }, { Guid.Parse("e421d6da-41c0-4aff-9b44-c765e34ff654"), Guid.Parse("8a8a194e-9761-4e7a-b154-7045a9d926c1"), Guid.Parse("855c5a21-e418-45ae-8eb8-5c2b25b220cd"), }, }, { { Guid.Parse("dd714f22-c77f-4a0a-a562-d21bab965afa"), Guid.Parse("9a07fc85-eb7d-4ed1-847d-4f1644fae72b"), Guid.Parse("cc5a6415-b681-48d9-9668-2f92c190f2d0"), }, { Guid.Parse("37119253-6074-4ba5-a2e1-bd894ee03951"), Guid.Parse("469ef549-685c-4396-995d-a5cbd1994024"), Guid.Parse("9126360d-ad60-47d7-a3e2-cdccc952e923"), }, { Guid.Parse("7066a739-0969-49e7-97f9-8c11d337265d"), Guid.Parse("89fe9b07-d624-47f2-b6dd-17485e8f4926"), Guid.Parse("d0f4d774-e152-41f2-bffb-bd3d144c2443"), }, }, },
    ModelInner = new GuiduuidMMArrayD3E1MI
{
    Id = 55,
    Value = 
new System.Guid[,,] { { { Guid.Parse("16084a53-cfc7-4486-8aa0-24cbae3f4481"), Guid.Parse("47be9028-3418-4a27-b34a-fdc3fcf3240c"), Guid.Parse("7cb0eed2-462a-415a-9ca5-5f5416cd2c27"), }, { Guid.Parse("319770b2-46fe-404b-beac-0bdf49dad33b"), Guid.Parse("6b17b71d-dabd-4050-9a3c-86cf8d5e6f38"), Guid.Parse("55bb741c-e588-4ae4-884c-3aa401603eea"), }, { Guid.Parse("a033aec8-6847-42b9-84a7-fae916f6fbd1"), Guid.Parse("dcc73dc4-509d-40ed-ad32-3dbdb95afd4f"), Guid.Parse("7682f97d-d3b5-4b9e-9b04-fc9a578bbd43"), }, }, { { Guid.Parse("08e01fbf-64e0-4320-b8a5-8d6435e31476"), Guid.Parse("1acf2fe9-2136-4444-9035-c274558e8f9e"), Guid.Parse("0323f510-3d64-4bfb-838c-235eddb1742a"), }, { Guid.Parse("c428e102-2a35-4364-811c-2ed83cd5828e"), Guid.Parse("93d86d88-8a94-4a1b-9dea-561879db55d0"), Guid.Parse("7105fd48-288c-432e-9f90-c5f9c85a8f99"), }, { Guid.Parse("6a990256-c3c4-4d2a-8f12-079ef3e640aa"), Guid.Parse("f4cd79d9-5d2d-4cc1-8cf3-57fafa04a82d"), Guid.Parse("722f0d35-77e5-4c4d-a661-cccd6701b8be"), }, }, { { Guid.Parse("e04e2ea8-2438-42c4-834f-8ac9c24a2290"), Guid.Parse("e88a0f75-f2d0-45e1-99b3-a32c5503dbc1"), Guid.Parse("ac1499a5-4832-47d4-8d01-1b626b1fafec"), }, { Guid.Parse("31bdf04e-4854-4526-af38-19688de307bf"), Guid.Parse("a25ac3ca-2519-42be-afd8-572d4f7a6f4b"), Guid.Parse("8de90962-3728-4905-8d88-7123f09217a0"), }, { Guid.Parse("6911e342-71d8-49be-ba3f-fdbd96f7de9e"), Guid.Parse("d3f141bb-df87-4a80-a5e9-383160f57c66"), Guid.Parse("7cb59334-deca-4d32-8327-923288f96f29"), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD3E1M
{
    Id = 110,
    Value = 
new System.Guid[,,] { { { Guid.Parse("5f753f6b-48ee-4ffa-9a97-9afd1c146802"), Guid.Parse("65fa09e9-20ae-4d0a-825a-bb1a3c7cc3f6"), Guid.Parse("2b77d226-8e23-48bd-a882-632e538793e8"), }, { Guid.Parse("e714232e-081b-49d9-8286-1714053de925"), Guid.Parse("5c118e43-27fc-4095-a25d-9a0244d7bc72"), Guid.Parse("978b25cb-37d5-40b1-8105-d2b355641d59"), }, { Guid.Parse("b83f503c-e5dc-4712-91d9-9b92f0eb17d4"), Guid.Parse("159260b1-0e51-4cf1-8c5f-c05419d0d460"), Guid.Parse("bb1b7758-1360-4ce5-8f85-314d78464f3f"), }, }, { { Guid.Parse("ad388e46-efb3-4e8d-8dae-c50ec40a9f8a"), Guid.Parse("0dc1a141-d026-42e3-a233-db983fa7a6a9"), Guid.Parse("56061929-fc23-4d74-ae75-8d145dcce14d"), }, { Guid.Parse("0861b75d-c0e1-480a-8b2f-b79a786bef7a"), Guid.Parse("10e52466-7e1a-403f-b891-f68f96826273"), Guid.Parse("142e5dfb-de67-4b05-b1ac-7b4ac917934d"), }, { Guid.Parse("57e43ae7-a710-44ce-be2f-f4f8658936da"), Guid.Parse("4a979d31-6eee-493a-a1bb-d1a1e714175f"), Guid.Parse("80e6c2ff-2acb-4dcf-ae79-365a72da5083"), }, }, { { Guid.Parse("e9c63acb-8551-47b5-b81e-8c17eedfa37a"), Guid.Parse("0c592618-2f60-4fe0-94b3-562dd728de33"), Guid.Parse("926aad13-9a2b-4300-b235-57cbee8db161"), }, { Guid.Parse("38eaca09-36fe-48a1-8048-60577fd1d43c"), Guid.Parse("6883c8d6-095e-46c5-8477-714c1b845598"), Guid.Parse("802fac3a-be69-4e5d-860a-46bbb1a18a3c"), }, { Guid.Parse("cf40b0f6-93c3-4552-bd81-79f80ddf3ef4"), Guid.Parse("8e942a46-9539-4f5e-971f-115ed0f27230"), Guid.Parse("bd3b1b0d-a2d9-4831-a51a-1b7a8b5d6bc4"), }, }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,,] { { { Guid.Parse("cd37161d-d3f0-438e-9c9c-11d2db981ad5"), Guid.Parse("b8fa4f0f-a493-4fe4-99c9-16fc4d952ebd"), Guid.Parse("77364e18-013d-494b-9b2d-b0c750dd7dff"), }, { Guid.Parse("db458c6f-86c7-4427-9c12-0a461172652a"), Guid.Parse("25256984-2b40-461d-8e8a-c1d1f7355587"), Guid.Parse("fca42a00-8736-4871-9420-5a139847b0b7"), }, { Guid.Parse("ef52845c-3d3b-44a7-9583-8a1384a3f003"), Guid.Parse("85a540bf-4199-4d3e-ac1f-660ab9b062ce"), Guid.Parse("486bef57-143f-463b-b194-acfd086ff34e"), }, }, { { Guid.Parse("576cae7a-618a-4f21-8bbc-851768370993"), Guid.Parse("d80eb415-52e3-48e9-bef4-442de060aced"), Guid.Parse("240c0273-9859-4ecb-ac11-c71cbfbcf737"), }, { Guid.Parse("37c33d46-9495-4949-9d30-018455feee08"), Guid.Parse("5a3e29ff-8ac2-4580-b08a-84a89166f7f9"), Guid.Parse("b3c889a3-892a-4e66-acaf-285fd6398fc4"), }, { Guid.Parse("7d2091c1-a754-4ec3-a913-9f5bd6266acc"), Guid.Parse("7eabd9f2-c7bd-4b83-a1a8-dfcb7cfc1951"), Guid.Parse("933cb729-580b-4839-9738-ad142023ad1c"), }, }, { { Guid.Parse("a98d28ae-b9b0-468d-9afb-53972c4652bf"), Guid.Parse("e2553c84-d9a3-4db7-bf6d-7cd5b7aa4397"), Guid.Parse("f67fd357-13d4-473f-ba61-d51498f5fa0f"), }, { Guid.Parse("f21908e9-52a2-46f6-8544-671cb4c0c8a2"), Guid.Parse("00ebd451-3b02-43e3-bd5f-185222dc56a7"), Guid.Parse("67103808-7ce8-41ce-96f2-d8b87d2500bf"), }, { Guid.Parse("00eaa551-305d-463e-9236-5eac038db215"), Guid.Parse("c28b36fd-d4bf-40f2-b490-9cdfeff2e45b"), Guid.Parse("00d3d9e4-96d2-4d6f-a84b-0dac20420066"), }, }, },
},
            new GuiduuidMMArrayD3E1M
{
    Id = 119,
    Value = 
new System.Guid[,,] { { { Guid.Parse("eb4a766f-2ae9-46c1-a8cd-43ce3219d711"), Guid.Parse("f5e57874-cdc9-4892-a176-f930cc69e184"), Guid.Parse("9b67d318-a04f-4dde-a17c-034271e02973"), }, { Guid.Parse("4cb6c96d-01f6-47b9-8525-2c0ff6d20410"), Guid.Parse("7aaeb4cc-99e2-4a8f-b228-cce70ed0f1a0"), Guid.Parse("e8bc5c4d-aa54-44ab-b479-ec0480e05e4b"), }, { Guid.Parse("9a0d29e2-1965-4f82-b0dc-40212428b665"), Guid.Parse("00884ae6-44f5-4362-ac4b-74c4ba5da849"), Guid.Parse("1701b07f-a09b-4d4f-844d-d77001d085cd"), }, }, { { Guid.Parse("0025f467-cb9f-4ce3-9433-1d5ce4d42d5e"), Guid.Parse("8b1cee29-7cb5-4e1c-a692-24425f203456"), Guid.Parse("4357f414-7443-4066-92b4-79c0bfe9789b"), }, { Guid.Parse("c673dfb5-4fcf-4dde-a134-26d406b669fc"), Guid.Parse("01e7ac5e-4f84-46e0-a9e2-d30a0a226c4d"), Guid.Parse("dfda0917-d4b6-48c3-affc-a9a00404ea50"), }, { Guid.Parse("9afc3639-55fa-445c-a0e7-839710ff79f5"), Guid.Parse("8a7c9f43-5dda-454d-8673-6737f47bbef0"), Guid.Parse("24484850-c174-4152-9cb6-8c001e4be088"), }, }, { { Guid.Parse("e9df7456-5f04-4b6b-8ffa-bdd3421be79b"), Guid.Parse("adad4d83-d64a-4ffe-a873-e25d499af73f"), Guid.Parse("824e10e1-1886-4853-b53c-79f6cdfaa9d8"), }, { Guid.Parse("8ef274b9-6e43-4fd9-9934-6db91003cc5b"), Guid.Parse("e631b8f4-ebf8-4d6e-a1cc-cf5aca88028a"), Guid.Parse("0bb1356d-c3c3-4aa2-b707-de7fa521ce5f"), }, { Guid.Parse("7b76fefd-3274-4a4d-811c-ea445a25404b"), Guid.Parse("9430f676-8e7e-475a-968f-b646c74c61ae"), Guid.Parse("0b19a550-83cf-4426-b089-dd9138aaf44d"), }, }, },
    ModelInner = new GuiduuidMMArrayD3E1MI
{
    Id = 58,
    Value = 
new System.Guid[,,] { { { Guid.Parse("284f1603-d052-480c-b458-37032f02e1e2"), Guid.Parse("0187c8f0-03fa-44e6-8a30-678ca9427da3"), Guid.Parse("56889697-dbc8-4d8f-935e-70d7064391bc"), }, { Guid.Parse("9d9bcb6c-f2de-4b8f-874c-28b841685153"), Guid.Parse("beb45d51-5984-4f23-a3b2-1f64cb5cc829"), Guid.Parse("0b8f7bf7-9626-4805-9b4d-b46061356368"), }, { Guid.Parse("220f0dd0-f992-4a23-9332-9b89df504fc6"), Guid.Parse("611cc966-16c2-497e-b7ce-e4bebf4efc3a"), Guid.Parse("ed9ba2d4-e24f-4262-8500-02b5a8dae9e1"), }, }, { { Guid.Parse("9fd96a43-1668-421e-a47b-17f9a4863f6a"), Guid.Parse("2106c3ba-fd7b-4d55-bcbd-0588c1d244ad"), Guid.Parse("c327caab-7d31-47bf-a0e7-228d564921e8"), }, { Guid.Parse("6bd7cf34-b383-47e7-9f87-6c8c399db188"), Guid.Parse("c1f9d4c0-8ed5-4233-bf44-78af49cbfbc0"), Guid.Parse("145d197c-a2e1-42a1-b92f-661152b48770"), }, { Guid.Parse("d0f70649-0502-4cb4-8635-8cfa6c59eb61"), Guid.Parse("4f4137a1-022e-45fd-93fe-5d149364982d"), Guid.Parse("ef4dc9a8-b10f-49f9-b26e-2423ff42bb84"), }, }, { { Guid.Parse("1487232b-44e7-49b8-9e9b-2fc202b9b45b"), Guid.Parse("51b0ce67-552a-44b1-aafb-970ae47290da"), Guid.Parse("67e9241a-a3c5-49cb-90e4-3036520de424"), }, { Guid.Parse("e2c676a9-3f71-483e-ba06-2c087e95e425"), Guid.Parse("a77b7f9c-5a36-42b6-9f7e-762efe2516ea"), Guid.Parse("acb31146-3e0c-442a-8111-7a0cefc43fe0"), }, { Guid.Parse("1b709e51-4c56-4f91-812a-c056dcc054d6"), Guid.Parse("196ff290-c4f2-4bf6-ac74-be9d0b63e193"), Guid.Parse("5237cacc-7701-462e-9b3d-0faa3527d5dc"), }, }, },
    NullableValue = 
new System.Guid[,,] { { { Guid.Parse("30341d03-47ef-4d51-b7dd-6eaae2d94f78"), Guid.Parse("c19a90e0-2d64-4b8e-844f-1426c0e27896"), Guid.Parse("0c2d50f6-40f5-4626-b4c0-7d80af5109a6"), }, { Guid.Parse("0023013c-4717-4c16-88a4-d33ce9167099"), Guid.Parse("e45bca7b-c474-4bf2-bb4e-1dbc9bd54e18"), Guid.Parse("8d35df1c-e108-4b58-9e46-b4475d2627df"), }, { Guid.Parse("3a0ad728-28fe-482f-96cd-d6fe3c4c5618"), Guid.Parse("f7dd5600-a94c-4674-b8dc-b1e06d0c0439"), Guid.Parse("3fac2d8c-84f6-4346-bfdb-b8e8381a047b"), }, }, { { Guid.Parse("a7d201b4-814d-4b4b-9e1e-d985abf8ec1d"), Guid.Parse("6f487120-3f42-48ec-9d8a-405b63eee475"), Guid.Parse("633dfeb0-2f17-4c4a-bdec-034d5cc181f1"), }, { Guid.Parse("481680a5-693c-4d86-adc6-ef9b913a5e8e"), Guid.Parse("a6455e1b-188a-49e2-b0fa-82631e5dd429"), Guid.Parse("37579e51-489a-4891-935a-97eda033e308"), }, { Guid.Parse("f495a394-1a46-4732-839b-d8f635ddffc4"), Guid.Parse("4691b6ef-da4e-4f55-855d-f01032e7f033"), Guid.Parse("44ab14d4-291e-4fdf-9543-e1bae06ca5f7"), }, }, { { Guid.Parse("f331d036-f10c-4272-80d4-635a3a46cdef"), Guid.Parse("ca7d871d-56ec-4942-855f-3b7a2c507edb"), Guid.Parse("39d5f1d0-5213-496d-9e6d-987ab0ab2dfc"), }, { Guid.Parse("1c2e5d55-0b85-4cbf-a366-042f2e06a072"), Guid.Parse("63c0c4cd-03e2-4062-bcd7-758afbc1729b"), Guid.Parse("b838951f-8682-4d85-b28a-a59a74ab910d"), }, { Guid.Parse("84c7ea97-f7cc-40eb-b9bc-8c379292f772"), Guid.Parse("7e265a4c-c5d1-45cf-a69b-33ac93c3e0c1"), Guid.Parse("89f1964d-4da7-4ec5-bfb7-aa419c12afff"), }, }, },
},
    NullableValue = 
new System.Guid[,,] { { { Guid.Parse("f842fc14-13eb-4374-9504-f493e6302bb6"), Guid.Parse("2700ac4b-0e49-4e25-acdb-907c733b486f"), Guid.Parse("b83adbfc-f0cb-42de-80f9-5136d6819d96"), }, { Guid.Parse("3052204f-0239-4841-b0ad-a2d77bb037b8"), Guid.Parse("ccf74874-653c-43cf-8937-fcc82cb9c228"), Guid.Parse("ccaace9d-bff7-4c1b-995a-7c468b3181b8"), }, { Guid.Parse("806b1cb6-21db-47d9-b602-c9c0bf51bfdd"), Guid.Parse("ed5a807b-0846-41b1-939a-3721d617e4df"), Guid.Parse("3c1ec023-78e3-4582-9c03-35117b2ed1dd"), }, }, { { Guid.Parse("28683584-885f-448f-a119-7ecbce90c0a1"), Guid.Parse("a3d4c5a5-bbe8-46d4-835a-1f72790e180c"), Guid.Parse("0a7373f1-ce32-4cce-906b-1193bd4a3446"), }, { Guid.Parse("ffe49d6f-1ab2-49bc-ad02-4d4b00aa3c7a"), Guid.Parse("b157b691-a774-4109-8ca9-a0e381ad81c1"), Guid.Parse("f07b1dc5-35cc-45a9-9bb4-8fd354e7979b"), }, { Guid.Parse("ef8ed2b2-3bee-4add-bc78-0dc6c8e32251"), Guid.Parse("63099bac-8be8-400a-96bd-2b794bc5d764"), Guid.Parse("0777d5f5-aa97-4b18-b16a-4bc7bedb9254"), }, }, { { Guid.Parse("51724e87-0935-4387-892a-0cbd5fefb1a2"), Guid.Parse("5aeb4694-ca02-480b-9e5f-e863e31d7c32"), Guid.Parse("2acf8428-9d47-4d42-bad4-de181d17cd48"), }, { Guid.Parse("48bd5c75-979c-47ae-87f6-dbc48ad3e0d8"), Guid.Parse("fb07a4ff-4e01-4b52-be1b-2f40277139ef"), Guid.Parse("c950852a-81c3-4cf9-9efa-d71a4dd46acd"), }, { Guid.Parse("9f0113bf-2b6e-4fc8-a12e-4da0697f88df"), Guid.Parse("7409019a-3823-48cf-b641-b44112acb2f2"), Guid.Parse("eba89cd6-9efd-4e95-b838-acc2ad226e57"), }, }, },
},
            new GuiduuidMMArrayD3E1M
{
    Id = 120,
    Value = 
new System.Guid[,,] { { { Guid.Parse("8f09a524-3006-43ba-9bb5-0e26bcad6e3e"), Guid.Parse("727c2167-f98e-4980-94ad-3749efb0e2f4"), Guid.Parse("ec365d86-1620-42b1-8c7e-163ce4b61412"), }, { Guid.Parse("386fb930-f8d2-4182-b38c-0a70424ce9bc"), Guid.Parse("510ac60a-a902-4f80-9a6d-24255314e1ee"), Guid.Parse("034d23f2-baa9-4f83-8c91-34092bc2879a"), }, { Guid.Parse("4069be28-582b-42ed-a0c2-80ccd2ce9ce8"), Guid.Parse("26ab0e4f-686a-4637-8b40-c4612be5fe63"), Guid.Parse("69eebea2-0b47-4b5c-8e0d-be849c9a3fcb"), }, }, { { Guid.Parse("179b5875-861e-4a58-94d6-c6ceb8795129"), Guid.Parse("2c47b6c1-18a9-4565-a1cd-f8302c76d61d"), Guid.Parse("e8cf1664-d1d8-4d9a-9b2e-bad72b4b460e"), }, { Guid.Parse("b2608870-174c-4855-b983-f4c331d5f927"), Guid.Parse("11ff45f3-9edb-4aa5-8c6f-c8ed887cf198"), Guid.Parse("86491bdd-9a27-446e-a723-c8ec58f839a4"), }, { Guid.Parse("d896405d-4320-4b2e-8e48-9788a97c1d40"), Guid.Parse("015213af-2c7e-4af6-b783-f7b053e8edd6"), Guid.Parse("d0354406-f547-437d-978b-fbb76f2ba6e4"), }, }, { { Guid.Parse("3398084b-57dc-4885-a564-6bc6d811f530"), Guid.Parse("ade748ab-224e-4a88-84bf-297e0e81cd66"), Guid.Parse("d186e907-8ad5-43db-9997-691d5b732e36"), }, { Guid.Parse("a4447574-f510-4085-947f-8679b454f90d"), Guid.Parse("b382c63d-8b6d-4b39-8e28-d2dd90f32753"), Guid.Parse("119a929e-a94a-482b-8900-ebad2761ebf8"), }, { Guid.Parse("c7879a9a-134b-4d29-a2e7-bc9ca12086d1"), Guid.Parse("1099b6c0-9655-4a26-9855-baeed9d90c20"), Guid.Parse("a1953435-c48e-4b23-8e35-382bd5419f76"), }, }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,,] { { { Guid.Parse("d5fc3a7d-4aef-4cb5-a020-5baf381889a0"), Guid.Parse("5a3b80c9-4df8-46e8-81ec-25e9e8e04082"), Guid.Parse("b5f53788-84be-40c4-afce-cfde32b73fce"), }, { Guid.Parse("3409cc2d-0e80-461f-8865-d4df36ba2f3e"), Guid.Parse("1003992d-1c15-48b1-a9a3-96a8dbdb5afe"), Guid.Parse("45638419-e89e-47fe-a720-c9411e62c000"), }, { Guid.Parse("c3edacbf-065e-46b5-be36-537dbc31c984"), Guid.Parse("78a58af1-d350-4497-ba15-783250306a81"), Guid.Parse("74d29311-a480-485b-bf66-7bf176d4bcc3"), }, }, { { Guid.Parse("e6759541-2c3b-4ed4-a4f9-ad21e67aec3a"), Guid.Parse("5830148d-27ac-40e0-85ad-86b273253651"), Guid.Parse("ec586bdb-0a00-4c51-b80c-cd5b5dc7a2e2"), }, { Guid.Parse("e42b2850-d062-4c12-a105-7a9ecdce81bc"), Guid.Parse("dbd8d4e3-2a6b-45b0-85f6-966acdc48d48"), Guid.Parse("05c78662-ac10-4881-907f-c41ceade5617"), }, { Guid.Parse("44ef6f56-e06a-4c9f-a923-470f5e527df5"), Guid.Parse("abb7d49f-a27d-45a1-96b7-a32f50f94f83"), Guid.Parse("ae7c550d-0031-48f9-95ab-0c6eb9b87752"), }, }, { { Guid.Parse("11c41214-18aa-4944-8049-0ffb3df7d180"), Guid.Parse("b77bf60a-85f6-42e3-adf9-d8f6daa659eb"), Guid.Parse("56b3dd92-7398-484d-bb4d-0f37b03dc431"), }, { Guid.Parse("f474f5e1-e57b-43dd-bfa3-bfc6f4662433"), Guid.Parse("fa788408-a614-4518-a667-b8c7abe19151"), Guid.Parse("962fe3fa-a2f0-4bac-8e12-625df51dccf0"), }, { Guid.Parse("0fe475f4-4096-4199-aeee-44738086e458"), Guid.Parse("4246c1e6-f7f6-4bb1-8b1f-47e6e6a8f7a7"), Guid.Parse("b0b9f51a-5c28-4865-80cf-9b9c4d09b185"), }, }, },
},
            new GuiduuidMMArrayD3E1M
{
    Id = 124,
    Value = 
new System.Guid[,,] { { { Guid.Parse("cd40f243-d1ef-4f4f-8448-040ee30cc42c"), Guid.Parse("78f1e4e4-36ec-48b2-88f7-7a0f810a866f"), Guid.Parse("f1e16502-9f2c-4667-93f7-43f60bf232f9"), }, { Guid.Parse("a606ec51-7636-4407-bcf8-8f84fb85c3f2"), Guid.Parse("c24ec1ee-882f-4076-89cb-f5ff679151cd"), Guid.Parse("a0e6fe8b-5242-44ff-bb62-bc8ac09c99df"), }, { Guid.Parse("28dbe45e-2561-49ae-a0fd-fbf803995f18"), Guid.Parse("54f3a098-c9fa-4d2d-980c-40ca0dbabf51"), Guid.Parse("be1f970b-da54-48de-8478-eec669258291"), }, }, { { Guid.Parse("c8a56258-bc84-46cd-b06b-2e46a088e6c2"), Guid.Parse("1411cab2-5bed-4bb9-aec7-73dcc3cf0d75"), Guid.Parse("8834d73b-b5df-4f3c-8870-b61e6240ab75"), }, { Guid.Parse("29e756e0-8963-4b34-a227-b9cae6e56531"), Guid.Parse("8d1f5c90-af5c-4181-be61-f088cd690ce8"), Guid.Parse("90f33672-2d33-448f-9b73-124718eadb36"), }, { Guid.Parse("cf7a8f77-fcd2-4116-b5bc-64e2534173b6"), Guid.Parse("2cef7ca1-d986-435e-b417-f76fa9397ad6"), Guid.Parse("02ad82ac-1519-4ca6-bc6e-477b7636de23"), }, }, { { Guid.Parse("3e9622e9-c5e4-43bc-b4fc-9f123516405f"), Guid.Parse("476ddf62-34be-4a66-96a3-a95a5f92c08a"), Guid.Parse("e3878cd4-5bac-4b50-a71b-05f2949abc08"), }, { Guid.Parse("82e6261e-bba9-48bf-9d1e-acd896ee2772"), Guid.Parse("feed6c3b-c5fd-45d4-a8e7-d78177daf70d"), Guid.Parse("8b04353a-446c-402f-b9f8-c932a35654e8"), }, { Guid.Parse("599fee3a-fd19-4700-9c56-a69289cb5851"), Guid.Parse("05c19fe8-c544-4be5-b8c0-432dc6507cdc"), Guid.Parse("23e06b2b-1a75-4e31-8c5e-b9fef30fa50a"), }, }, },
    ModelInner = new GuiduuidMMArrayD3E1MI
{
    Id = 63,
    Value = 
new System.Guid[,,] { { { Guid.Parse("dfdead38-60fe-41da-89bb-b762ef3bad6e"), Guid.Parse("726fc467-1266-4841-826b-93c0722b9e6f"), Guid.Parse("d5f5df58-2046-412b-be66-8f3f57a9f26a"), }, { Guid.Parse("23b4de00-1012-4f49-a835-0c33f0330a4a"), Guid.Parse("ade6e8be-c055-4313-a0c4-543f3f1c2db1"), Guid.Parse("71229658-fd71-4da6-a390-d70ef2f06369"), }, { Guid.Parse("907b2f62-e0da-4b7c-9dbf-1bc3ee5465a5"), Guid.Parse("0c8f7265-e444-467f-b110-6671c1aa3896"), Guid.Parse("0932dd2d-166f-427b-9618-68d538a08775"), }, }, { { Guid.Parse("fe2585e4-e3b3-49bd-8be9-c24ba746ac9a"), Guid.Parse("ebba5475-ddcf-4191-8318-1140856b785c"), Guid.Parse("8f5d8a2a-6876-4142-ae43-b264d5b2948b"), }, { Guid.Parse("d0268663-2137-4053-9129-b99f48cda48d"), Guid.Parse("bf1746af-59a2-42e1-9414-dfc6a895ea32"), Guid.Parse("1f808fa1-62c1-4ce3-b285-1cee8ed12240"), }, { Guid.Parse("a8192247-e3d3-4f1e-8147-848b401cad1d"), Guid.Parse("c87db549-8457-44f5-bbe6-3ed54fe9446f"), Guid.Parse("544a3067-3116-4fb9-947d-c1f3afde8795"), }, }, { { Guid.Parse("832314d3-2d02-4533-ad3a-7d71a3e495d9"), Guid.Parse("8ae02947-dde3-4e0a-a20c-ec737ec8024a"), Guid.Parse("edaa877b-ccd5-43fa-930b-55df32fa3631"), }, { Guid.Parse("92cb5cdf-67a9-4b16-8efb-1562f760e9fe"), Guid.Parse("93ebf358-ca8c-4c01-bc9f-e508fa9980ca"), Guid.Parse("07e6530c-49d5-4f31-b345-f27f1038249a"), }, { Guid.Parse("06d0d5ac-c9de-457c-a802-ed06171ac588"), Guid.Parse("aedc1d1b-7062-485a-b903-605f35d76ef5"), Guid.Parse("e52e2aa9-e011-41bb-9155-916f56f52308"), }, }, },
    NullableValue = 
new System.Guid[,,] { { { Guid.Parse("b4b25283-4af9-4ae1-8b92-dea0445c8657"), Guid.Parse("e2ff81fa-20ff-4c33-8970-e057307f74bf"), Guid.Parse("593f6c4a-c99e-44d6-ac68-5cc90ece9305"), }, { Guid.Parse("71c61a98-20f8-4a62-98a9-45ca24afb506"), Guid.Parse("f7ba9aec-40f4-44e4-8a10-f73e12df6d9a"), Guid.Parse("212caaac-d448-4b40-beed-97828788080b"), }, { Guid.Parse("b5b5c41d-ab32-4900-bb94-04d9608878bf"), Guid.Parse("9f96431b-8be0-4009-8a8c-a49caf4f3cd6"), Guid.Parse("c654953d-5cca-4086-bd67-6d50d3f68f27"), }, }, { { Guid.Parse("9b86c2ca-e39c-43b5-a6b6-e47101bbe661"), Guid.Parse("772f0099-e575-453f-9d96-48993e4c492f"), Guid.Parse("5cd02a65-cf52-4298-ab61-1445c7a23efc"), }, { Guid.Parse("6bdda55d-d4a9-42ca-a19e-0cdd523d8309"), Guid.Parse("d3cbfe60-bf95-4812-a7b8-f445f0b1a4d2"), Guid.Parse("642c3eda-e2ab-416a-8cd8-53267da4a032"), }, { Guid.Parse("612816ca-8e73-46ac-9161-d43560ee2813"), Guid.Parse("720ca622-49e6-428a-9d26-7b2e4ee6b063"), Guid.Parse("e17ff2b7-1766-47c0-971e-8cfc0d44d9b0"), }, }, { { Guid.Parse("fd89a265-af29-4740-9fa3-d5a3ade15758"), Guid.Parse("41c9061e-feac-415c-a3e8-15e22e55385c"), Guid.Parse("4003640f-0852-4929-9225-4600af9ca056"), }, { Guid.Parse("7be8a2ee-7d7c-45ff-8f07-2334398239b8"), Guid.Parse("ed287070-56ee-4e19-9077-dadcb7d46d37"), Guid.Parse("5b0832d7-2c58-4e8a-9520-248ddcd335fb"), }, { Guid.Parse("cd993d43-07be-44ec-85cd-c9f671575388"), Guid.Parse("096e8b9b-d2c8-4987-8165-6748d5be037b"), Guid.Parse("8033a9d5-ce5d-4e5a-8191-d7771f5e5646"), }, }, },
},
    NullableValue = null,
},
            new GuiduuidMMArrayD3E1M
{
    Id = 128,
    Value = 
new System.Guid[,,] { { { Guid.Parse("a9034197-cef6-4b94-a991-ef3313c95428"), Guid.Parse("eb0336e4-c792-49aa-92ef-5b62cfb2e656"), Guid.Parse("4d37029a-a2b4-486d-9995-b2255b719e60"), }, { Guid.Parse("cff64e74-ed74-49c8-95ee-fddd567eeb71"), Guid.Parse("7fa62215-64e9-4906-b133-c67be9db6eda"), Guid.Parse("0b3714b9-e33c-4782-b74b-ed85ac0bc4c9"), }, { Guid.Parse("c97cc4b4-1a00-4e6d-aca1-b643f24ffd87"), Guid.Parse("f097eb53-bec8-45aa-8e6b-a2b494176923"), Guid.Parse("7b1f433f-2555-496b-ad49-97729a683f92"), }, }, { { Guid.Parse("bcd9b67f-7f86-4737-b6d0-f30e25da232a"), Guid.Parse("f48e9d21-5e52-4e80-9429-a5511be96462"), Guid.Parse("a9e5add3-e1eb-4458-9d48-f7f2113fb258"), }, { Guid.Parse("43d03377-91eb-4b5f-9ea0-206f096394b7"), Guid.Parse("e151b08a-1f7b-412f-9daa-0d1ccfb345ce"), Guid.Parse("d7815b0b-9d8d-468b-9c26-b572b735445e"), }, { Guid.Parse("b1f06f4d-f85d-427a-8968-553707035975"), Guid.Parse("d62edb6f-84ea-4280-a706-afa9fac0318d"), Guid.Parse("eef6b8d8-65d7-4b82-8e06-89599d390adc"), }, }, { { Guid.Parse("f37d57b3-27c5-499b-908a-3c71197edbab"), Guid.Parse("01c54688-1fde-4005-a9eb-d14b92e79cbb"), Guid.Parse("f668568e-f4a7-440c-874b-3a26854894e4"), }, { Guid.Parse("e5f91976-d5b1-469f-b9de-54d8d1dc7765"), Guid.Parse("eb64f846-44fc-487f-b7cf-41b6e6be712a"), Guid.Parse("0cd6e954-3978-402f-9a9c-c5a8d8acb2fc"), }, { Guid.Parse("67c384be-c2e6-4c8f-9e85-ac7b11827cf0"), Guid.Parse("d976b3bf-0dbe-4695-bf05-497c53403788"), Guid.Parse("44faef64-15cc-4666-b4ae-d317b5cd6ad9"), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD3E1M
{
    Id = 134,
    Value = 
new System.Guid[,,] { { { Guid.Parse("9b77274f-d7cb-4fea-b229-1a4edd9219a1"), Guid.Parse("1130fe41-cbea-4fbb-9d70-0bef88cef242"), Guid.Parse("c790d7c2-fc39-4e38-a695-30787c8c9e8f"), }, { Guid.Parse("650c918a-6a99-4a26-b615-ca7f09681ee0"), Guid.Parse("66659624-87c0-4139-b5e1-529a59abd375"), Guid.Parse("fab43635-6b4a-4315-9b54-411826f44917"), }, { Guid.Parse("b09c6a39-7e5f-4a12-977b-0641028ed894"), Guid.Parse("9b0ec1c5-2753-4623-a124-84c47c39afcc"), Guid.Parse("7edbf11f-a7d2-4aa0-bf72-28aab73c4318"), }, }, { { Guid.Parse("71deed23-3bb8-49b9-8354-53384d1323ee"), Guid.Parse("140aae1b-b3f7-4dc0-8912-abb6113143a5"), Guid.Parse("a825235b-f6fb-4f81-ad79-dc7a0f3ecffa"), }, { Guid.Parse("adb4b235-8815-46ec-9cfa-85509b0f64f1"), Guid.Parse("09e02d07-8084-47ed-938c-16ef8f9d1af3"), Guid.Parse("f8c7f323-b375-424c-9761-a30c39ed0e03"), }, { Guid.Parse("7cb2b02f-ee55-40e8-8c8a-f185b4508218"), Guid.Parse("885afb40-d9b1-4c80-bc82-feee5d1a4d0c"), Guid.Parse("26efa4f7-2f87-4fa0-9592-9cbb69d1bc0c"), }, }, { { Guid.Parse("f75a276a-ba3f-4b5c-b8c3-5528d1de552a"), Guid.Parse("e2db3bd6-b100-4a9e-94c9-9305bf7a5576"), Guid.Parse("30db9ed6-695e-4f6a-9a8e-069fc6ef9a66"), }, { Guid.Parse("646f171c-b1b5-4016-ad5f-d8393aac8ba4"), Guid.Parse("e22e9d55-8c21-4af9-9799-7d9d485aebc7"), Guid.Parse("2974b9d0-2fef-4422-b151-127f3d067683"), }, { Guid.Parse("6a518aba-450f-4b1d-8ba6-cb7fc7701ff1"), Guid.Parse("7a44f2c0-639a-4089-8ce9-31e2a032756f"), Guid.Parse("3bad9e2f-571e-4742-a105-8d192dd44b61"), }, }, },
    ModelInner = new GuiduuidMMArrayD3E1MI
{
    Id = 71,
    Value = 
new System.Guid[,,] { { { Guid.Parse("e4170f2c-10ae-41a2-9bcc-42db9cec8ab2"), Guid.Parse("5b9c3bde-a546-442c-87ad-462a7866f23a"), Guid.Parse("2b2ce1ce-30b5-4211-aa1b-6dc1d324259a"), }, { Guid.Parse("6c55d4f3-d91b-4eed-835d-9d1d7cee8e68"), Guid.Parse("9b71031e-bbbd-476c-899c-f6e30be9ace0"), Guid.Parse("165fb87a-0f92-496e-a5da-bd5110ec50fb"), }, { Guid.Parse("8b808742-946a-4606-b8f0-d98678564403"), Guid.Parse("94c2829e-2c4a-47e5-8d81-cdffd91ae815"), Guid.Parse("57ba8713-a084-46eb-ab33-89f146672183"), }, }, { { Guid.Parse("13a4dff5-1645-494b-bd39-d56f49b1b802"), Guid.Parse("5c9d0c98-cd63-40ac-92a2-99921848db0b"), Guid.Parse("e073d0c6-1b9e-4f58-b625-6f7bda1ab4a8"), }, { Guid.Parse("90fac27b-39bf-4454-985e-70ea1169c9e6"), Guid.Parse("0106f242-7a92-4f01-a283-289a16b3ad3c"), Guid.Parse("a3e8850c-81a8-409b-81ed-6f5baca6b163"), }, { Guid.Parse("b28a5f55-d191-4af3-9e10-43536c2b1747"), Guid.Parse("0719461e-92b5-4eb8-9810-55400345d39f"), Guid.Parse("6469474f-489e-4f55-b45c-11b58f39acce"), }, }, { { Guid.Parse("df1d08b8-dca5-4340-add9-900ff47d2790"), Guid.Parse("609fecf1-22aa-438a-927c-b1b10e649e40"), Guid.Parse("46b18036-e14a-4154-90ed-0420993dc2a5"), }, { Guid.Parse("44a67506-cdf0-4cf3-8a33-bbd09640772c"), Guid.Parse("3f98a26d-6879-4869-8849-8ba9e6faa57b"), Guid.Parse("58162be1-ddad-4401-95d5-83491c90a2be"), }, { Guid.Parse("b169aebc-6131-4285-82c2-fbd52ac8425c"), Guid.Parse("97276de5-b2ad-4894-a973-be580b891219"), Guid.Parse("bf5e6d1f-c52b-4aa4-b365-7561b44a0eb3"), }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,,] { { { Guid.Parse("591bdece-d6ba-4b6f-994c-ee13f394f594"), Guid.Parse("4322d208-8c47-4245-89f4-2837d576bfda"), Guid.Parse("120c43aa-379f-472a-a130-bcad86247aca"), }, { Guid.Parse("a13662c6-4ca7-4d87-a4fe-740e044b0825"), Guid.Parse("1b8dfb0e-4452-4f86-8784-d05465205b4b"), Guid.Parse("71c436f3-1c7d-4669-9e49-df41f9d0f73b"), }, { Guid.Parse("9ad9d115-d1fb-42ea-91d7-5bda294eba74"), Guid.Parse("fb598a55-b8dc-4ace-9224-e9663312bbfd"), Guid.Parse("c31bc065-3d9a-4c15-b589-eff8b8244192"), }, }, { { Guid.Parse("7d756de6-a4b7-4890-bda8-63971d6db4ce"), Guid.Parse("4a8a6174-a5c4-4790-a541-2a455cacf82f"), Guid.Parse("ee8f90ef-eb10-4570-978d-fe7608443d19"), }, { Guid.Parse("3e886f14-69b1-4056-8765-ca2a4621a786"), Guid.Parse("88a35e23-7fd0-46ec-9dcc-197a78be62b5"), Guid.Parse("eb4d3188-9f5b-4795-a6a0-d144e1f599bc"), }, { Guid.Parse("b19e3c80-b588-4c7e-8b77-6e37420536f7"), Guid.Parse("92668087-42e7-4fde-9ef6-10c0d8ee8647"), Guid.Parse("57af92de-3da5-4f87-b256-14da0b0e2d77"), }, }, { { Guid.Parse("ceb57d6c-15f9-42ab-bde6-78d070b2d6fb"), Guid.Parse("17b863c4-960a-4680-8acf-85b7a8e8c225"), Guid.Parse("c6975638-2344-431a-953b-bd58b49c7f25"), }, { Guid.Parse("b0bd5ea2-beb0-42d7-8e6e-b4c2f95c0cd6"), Guid.Parse("fb6f88bb-0162-45b7-ab06-93d8549a5b43"), Guid.Parse("67481f94-58f8-48d2-a632-0af41f8f6160"), }, { Guid.Parse("379f4766-e766-4229-8bda-82c649c1b815"), Guid.Parse("bf4b7cf3-f6ee-4ccb-870c-5c8e2da7ad28"), Guid.Parse("3b394921-4d7a-4dac-8beb-ea5e8bff4f9c"), }, }, },
},
            new GuiduuidMMArrayD3E1M
{
    Id = 139,
    Value = 
new System.Guid[,,] { { { Guid.Parse("b3de91d6-fe88-493f-9bb9-ef9493be6177"), Guid.Parse("e3163328-648a-403b-9721-d651097ec5fd"), Guid.Parse("46a7a7d6-c253-456a-bc60-4cd2f6f29ca1"), }, { Guid.Parse("ccf589e2-0683-4b54-b956-95f38ad04644"), Guid.Parse("cfc56cb2-fa60-431d-af3d-8a1c01b9dfc1"), Guid.Parse("103127e6-3acc-40e3-9352-573300be3885"), }, { Guid.Parse("1dd73205-e158-4b66-9cfb-596ab628bcdf"), Guid.Parse("3c9e402c-62d0-4bf6-8521-0fdd4bffc45f"), Guid.Parse("233fc88f-d01c-4ea8-8a7d-b1724b4446bc"), }, }, { { Guid.Parse("e9b359ff-c59c-423c-95f8-515a4b07a56f"), Guid.Parse("47363c3d-ca80-4090-bfee-2ce10d55f1bc"), Guid.Parse("c7ae3452-5b05-4abe-b3dd-96c120182c99"), }, { Guid.Parse("da8d5215-6d1c-4c40-a33e-dc8fe55e126b"), Guid.Parse("d768cbf0-1413-4d06-97de-8ef7104853cb"), Guid.Parse("7a88c0f0-0135-4f57-a544-84c87b3cdf84"), }, { Guid.Parse("75f16a7a-31ea-4e9b-9d54-69160fc7ba55"), Guid.Parse("7275e003-7ffc-4e8e-969b-ac62364d13d4"), Guid.Parse("008312a4-5ff7-46a4-ba5d-cf81d12b1d7d"), }, }, { { Guid.Parse("aeb67653-fe41-4544-992c-78c61811c3fd"), Guid.Parse("1bb0662b-9539-48f5-8ea8-9dacd8044988"), Guid.Parse("9f8d1154-8ba8-4501-9f4c-494e2c35e552"), }, { Guid.Parse("4ac632f6-4b0d-4404-892f-635719b50fa5"), Guid.Parse("5d9de98f-f5cb-483a-bd00-45cbf884e77d"), Guid.Parse("611dd87b-8394-409f-8126-4a2205ebc1e2"), }, { Guid.Parse("e2587a59-0115-4077-a39e-a907877f8c70"), Guid.Parse("2153c55a-72da-4353-9809-ef4c2f021d5e"), Guid.Parse("feef9c00-bbc2-4121-888e-c117438fb45c"), }, }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,,] { { { Guid.Parse("3a8baa27-0df5-4ed6-bc4a-e5cb6948900f"), Guid.Parse("2818b8b7-96f9-47b3-ab38-509d7093d693"), Guid.Parse("4edc186e-5b00-496c-9c75-6e3555081526"), }, { Guid.Parse("12359188-1322-4c4d-968c-1f288034f0ea"), Guid.Parse("d948e9bb-c5bb-489f-943d-897c740d6193"), Guid.Parse("b4558848-c342-4888-a0e0-8f63556ab5d3"), }, { Guid.Parse("f17d2a49-c5ba-4fa4-993a-f640c9fa9eea"), Guid.Parse("471e9369-f370-4cb7-b9e8-99694b073c80"), Guid.Parse("53797910-06a1-40af-b216-cb5152fff3b6"), }, }, { { Guid.Parse("e3826531-c60d-4b10-8f23-eb3e10a35371"), Guid.Parse("dc38c882-ce57-486d-a400-4ece4d00621e"), Guid.Parse("d9852662-c0bd-4160-afa6-7ea23551a3df"), }, { Guid.Parse("ff82c9e5-c6e1-4351-8a81-caa0f096ae0a"), Guid.Parse("82816f45-1c4f-4fe7-b236-5f38b40f27d7"), Guid.Parse("1df617bd-e7f6-4fff-81c5-d1e8787f6b4f"), }, { Guid.Parse("5af0bafd-b0f8-41a1-8383-6a6c1eed45ef"), Guid.Parse("cd963594-6992-44f5-8be7-1fe7b3d6f1cc"), Guid.Parse("2fdc9eaf-48b8-4b78-ad91-0bf7c7196a24"), }, }, { { Guid.Parse("97ba71bf-0102-47cf-af40-0de90abc58e5"), Guid.Parse("7378f036-8e1a-4a42-aa14-9ec7fddd473d"), Guid.Parse("680f0257-8600-41ae-9f4a-ea6e9b2e3820"), }, { Guid.Parse("95f15178-80df-4fef-a240-e79c90aac96b"), Guid.Parse("9239d809-8d3a-4d0a-ba19-3ff106f827e7"), Guid.Parse("3ccc5f12-66b1-4a6e-b818-11fac75e99fc"), }, { Guid.Parse("57c31495-2745-4e01-a998-5c0332ca9854"), Guid.Parse("8bf4c42d-7186-4742-b19a-b540cb129f37"), Guid.Parse("a735ed46-3b50-4537-b2ae-494cfe2a894b"), }, }, },
},
            new GuiduuidMMArrayD3E1M
{
    Id = 144,
    Value = 
new System.Guid[,,] { { { Guid.Parse("e1d7fed5-44a7-4d64-a431-294cac695b8c"), Guid.Parse("b0b53867-d12e-4454-923a-2c521d38b728"), Guid.Parse("b7bf6df7-871e-4e55-b242-d4a2e4ed002e"), }, { Guid.Parse("d6adf0d6-4372-483e-875a-307cbb389311"), Guid.Parse("872595c8-8e1b-4eda-877e-4f088b8d99ca"), Guid.Parse("7fa24fe6-53b6-40fe-b808-f617ce9dc89a"), }, { Guid.Parse("317a8b64-89dc-4957-a225-83bd1a6f68e8"), Guid.Parse("269695cf-e26b-4b1d-b290-8fe3ff4d3e9a"), Guid.Parse("e605b01b-2bf5-4f1c-b2ef-b218def97895"), }, }, { { Guid.Parse("f721d187-71fc-4c8d-acd2-3bc951438268"), Guid.Parse("bd57cc33-f434-4238-bc02-2166c4816ba8"), Guid.Parse("8df7fbe9-6b51-43c5-8287-7044392a5e80"), }, { Guid.Parse("1b62d449-dafb-4698-ba63-d8f5f4dfe6d4"), Guid.Parse("e4e91e2b-ca86-4b18-bce9-d8180ccbf2ad"), Guid.Parse("5788014f-ca47-4969-a1e9-3019f17c82fa"), }, { Guid.Parse("33e9e070-f1be-4372-8398-bd6bd55518d9"), Guid.Parse("8108ea47-7927-442c-b167-8b4d8b40a1ef"), Guid.Parse("ad1f3dd2-66b1-42e4-8150-805c358d7272"), }, }, { { Guid.Parse("055b50af-ca3e-4499-b807-3bab2f2a6a92"), Guid.Parse("e00a29ee-2571-416a-9eaf-52641c3c928a"), Guid.Parse("c9db1d62-cf32-4b69-9782-fe6bb5f009ca"), }, { Guid.Parse("306f28e9-cc3d-483e-a422-fc4d95d4273a"), Guid.Parse("79472a5f-7ea9-4671-bde6-8351bb200c33"), Guid.Parse("12de63f7-414e-4e75-9628-cab6f4e0f16a"), }, { Guid.Parse("79195668-ead9-4bb1-91c5-d004aee84578"), Guid.Parse("09328f22-c8f0-4bd9-ae85-df072e137508"), Guid.Parse("cdd9a158-2dce-4539-a68f-2d5583c5dcfc"), }, }, },
    ModelInner = new GuiduuidMMArrayD3E1MI
{
    Id = 73,
    Value = 
new System.Guid[,,] { { { Guid.Parse("6025723b-7c38-4bf4-bfa3-ae4a95b5ee51"), Guid.Parse("bef1beab-c23e-4387-b7c6-0625e5512e50"), Guid.Parse("d294a910-b1b6-49c7-bbbc-f19649899217"), }, { Guid.Parse("a4a4c103-f5d4-42c6-b89f-9914a749ad43"), Guid.Parse("3e3c6c3c-3aca-4bfe-9f5d-e3d51a1eaf9b"), Guid.Parse("89a4b629-1b08-4e76-9c08-5c354374b436"), }, { Guid.Parse("43ea3842-f04a-496d-aef0-644f21b44cbc"), Guid.Parse("0794d50b-fde3-4abe-b7be-e42ba5929018"), Guid.Parse("ab643e67-541a-4da4-a452-6ec45756ae9e"), }, }, { { Guid.Parse("ec265b40-a9af-461a-a66e-bd6d7e5c9eb4"), Guid.Parse("b14c2881-ef94-4844-afd3-058a62016342"), Guid.Parse("6073f982-93dc-49f5-9520-58c9fc8df9bc"), }, { Guid.Parse("8214c8ae-5352-4923-89c7-7852cad4883a"), Guid.Parse("e981e36a-73c2-433e-a07b-f3b2f2a7bd13"), Guid.Parse("c8562c55-ac49-46d0-9057-36fedacb8830"), }, { Guid.Parse("30b40b52-84bb-4f40-becc-202b172098e1"), Guid.Parse("a9a2bb8b-804a-4288-8b1e-fbc86c4b57b1"), Guid.Parse("d04afa9e-8fe9-4dc8-9267-8a96365b0bfc"), }, }, { { Guid.Parse("29ed832c-fb3f-4058-8c27-d375d2aa02fa"), Guid.Parse("bb4d2b16-e5ac-4352-aa13-570ffad21844"), Guid.Parse("574dca15-c9ad-43ab-9c11-f7095f248334"), }, { Guid.Parse("a9f9e48a-a3d6-44fd-87ad-2b6272f747dc"), Guid.Parse("a6f3040d-e805-4bbd-b99e-7bdf12dca7d3"), Guid.Parse("1713c247-4cd5-4903-8788-eeb084d919a4"), }, { Guid.Parse("165a83f1-ef3f-4395-9258-5a6755719bdd"), Guid.Parse("059a91db-6763-478d-88f1-fbd3b6bb654c"), Guid.Parse("ca861f78-622b-4d46-a082-df5a24aed500"), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD3E1M
{
    Id = 147,
    Value = 
new System.Guid[,,] { { { Guid.Parse("49977767-b5b2-4c69-910c-d5b74c4fc064"), Guid.Parse("8aef9cee-40c9-4c91-b546-8e4957d79050"), Guid.Parse("138230ed-887e-4a36-a9af-b88a4947f695"), }, { Guid.Parse("dba948c1-887f-481d-ac26-5d6d47afff69"), Guid.Parse("cfd282c6-6dad-44b0-9101-939469595997"), Guid.Parse("ea4ebb15-b076-4ca7-a357-ee01d271e4e0"), }, { Guid.Parse("400184e1-c690-4958-81e6-2a6a50372b3c"), Guid.Parse("f52ba143-3b32-4e5f-aa5b-06f9f758c6ce"), Guid.Parse("f88a7682-b489-4284-bc20-853337acb8d9"), }, }, { { Guid.Parse("dee9804c-b07b-4bb6-91e8-77281dfcbad5"), Guid.Parse("f76f4f25-d274-4fe8-b35f-d8aab25adac0"), Guid.Parse("e1592bf2-943d-4a60-95c0-d9a1d838b12f"), }, { Guid.Parse("3cb95b1f-41f2-4578-8f15-71056049f48b"), Guid.Parse("69275bf1-9de8-4d0b-981a-d691855be33a"), Guid.Parse("5ef83328-4766-4451-8a4b-454760d745e6"), }, { Guid.Parse("4409b8ba-d5ee-4470-9326-b555b445e73b"), Guid.Parse("48b61156-fd09-4f91-a143-31ef8f567016"), Guid.Parse("610af8be-ea1f-4b82-bad5-b190a4db80cb"), }, }, { { Guid.Parse("631319d7-a1b4-41ee-83bc-11d60be860f0"), Guid.Parse("24721db9-1bb2-40fd-a817-169c8ddeea87"), Guid.Parse("77ee089a-ae45-4fd9-9713-1521044f9704"), }, { Guid.Parse("757d7ffc-e275-4b24-85d5-2ff9ae709b52"), Guid.Parse("975c9643-175f-4fe7-afd8-8976df3bd9a6"), Guid.Parse("ab8abce8-6733-4c70-ac9b-6d4bef103819"), }, { Guid.Parse("1e1a656b-ed1c-4717-925e-48897495b3e6"), Guid.Parse("78efc7bb-548e-4cb0-876c-09aac7acb7fe"), Guid.Parse("9b29bda7-6cd3-4ff5-89cd-8841f6262447"), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD3E1M
{
    Id = 152,
    Value = 
new System.Guid[,,] { { { Guid.Parse("bd1d6946-5b7f-4a84-ab0a-2f270d7cfcd0"), Guid.Parse("0a0de322-8c31-43db-b8cc-6d66a6459347"), Guid.Parse("10ef888a-bb21-4bb5-bf21-ecee00e71b90"), }, { Guid.Parse("3a349a17-955b-4c44-9696-42c2e23e042d"), Guid.Parse("156ade2b-19d9-4b5e-844d-f0412dfb5858"), Guid.Parse("3b05929f-1f74-425b-b114-de48a40ca621"), }, { Guid.Parse("c0e197ef-af2b-432a-a715-34e306d16412"), Guid.Parse("d82dbcad-e25d-4f51-acae-1c5ddd7081c1"), Guid.Parse("77555996-d2c1-4644-8019-710bad8dfe0d"), }, }, { { Guid.Parse("b1092f7d-1eb7-4541-b8d1-6ff1e5bf475e"), Guid.Parse("43ea5d08-bffc-4b40-8193-965fd88bf43a"), Guid.Parse("93fc0241-aa1c-4c90-b57c-ffe1c994008d"), }, { Guid.Parse("7f57feff-ce41-464b-976d-0ac76c681528"), Guid.Parse("fcfd68bd-376f-4a3e-a18a-c109303ebe34"), Guid.Parse("6036efea-ae80-494e-b23c-9c961d4f11dc"), }, { Guid.Parse("b0363ba5-7fe3-437b-8ea7-ef1c0ee915a7"), Guid.Parse("2b020c72-ab44-4256-81d9-e2568fecfcff"), Guid.Parse("5a4080b3-e09b-4cae-8cf2-47c49bbd73fe"), }, }, { { Guid.Parse("dcd947d9-1237-43b8-b386-f49b304edfd2"), Guid.Parse("be8e3ecc-9dbd-4a5f-9468-813584b6b959"), Guid.Parse("fb2f62e8-53fe-4371-90a8-51458afa0f30"), }, { Guid.Parse("f8bfb763-e6be-4fd8-8b4a-6c3ec378e33c"), Guid.Parse("6f1e344c-5d35-4d58-ab03-e6b5a51c5722"), Guid.Parse("71deaa43-6a2f-4426-8dff-83ac8475a307"), }, { Guid.Parse("3f5594df-4444-4a80-96a9-679f9247b271"), Guid.Parse("9b9a4f2d-b599-4583-b39d-6d17752cbbca"), Guid.Parse("fc035fc5-4d1c-4ae7-96dd-15b43645928a"), }, }, },
    ModelInner = new GuiduuidMMArrayD3E1MI
{
    Id = 81,
    Value = 
new System.Guid[,,] { { { Guid.Parse("bdcc8d9a-e043-4927-8c7c-6c87c933ef75"), Guid.Parse("12b51b4c-5ad8-4e49-bc2d-035f7cb824fe"), Guid.Parse("8dbfb073-b928-4ee3-a359-3f0e335ff820"), }, { Guid.Parse("86d09bc9-a68e-4fa2-a712-5e0ccfa124b4"), Guid.Parse("e4b98ec6-e8b7-4013-9722-9d44e3227af5"), Guid.Parse("c546ee7a-b072-467f-b5b0-8583065eff90"), }, { Guid.Parse("dfb2f5a9-d2f1-4bef-8a59-055f221627fb"), Guid.Parse("85b4ff20-69f2-4738-9645-d3ecf9db55a8"), Guid.Parse("27bcd8c1-c480-4b4f-9cb1-756ad367f3d7"), }, }, { { Guid.Parse("f8989bf6-1dc2-47af-b679-c825c80ec1d6"), Guid.Parse("2e783dcb-9b5e-4d6a-93b8-5105f3dd48f6"), Guid.Parse("f3d6a617-37d4-48c1-a1bf-b7d818641a18"), }, { Guid.Parse("3151fe3c-9cb1-4519-a08e-568b2fbc8951"), Guid.Parse("dfbbacfe-58f6-474a-8106-2c5f04c4fe53"), Guid.Parse("36197b44-4aaa-43f8-9be6-fb44e7cd7228"), }, { Guid.Parse("c04b07b5-ff6c-47d4-bf5e-6f77ba25d997"), Guid.Parse("5afc8257-30c3-4116-8503-d4bca9989b30"), Guid.Parse("83c8d4d1-907c-4980-b7da-e05bf0f95b2f"), }, }, { { Guid.Parse("cd5f57b7-aa03-4f97-a519-19685fcfa073"), Guid.Parse("0b1e6f47-f999-4519-9213-1a14cc4f0852"), Guid.Parse("df04e6b4-ac00-47ee-8b50-3f36c6f89098"), }, { Guid.Parse("238a8459-5d30-48e0-b02c-f84a6206f8be"), Guid.Parse("1d73e90f-56ca-470c-8d3c-221c65817780"), Guid.Parse("10fbc04b-0750-4a40-b581-a1f6b99f7b2a"), }, { Guid.Parse("de71d48e-a567-4eb5-9a0c-17bf6c4511b1"), Guid.Parse("39083e12-9697-4a9e-865d-aeb768ed9dff"), Guid.Parse("84ab1209-5644-44c0-8899-d15ffa3ee3a3"), }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,,] { { { Guid.Parse("1209b896-082b-4ddc-b40d-9718f239f2ad"), Guid.Parse("c40fb132-e46a-4d34-b22e-20556074e997"), Guid.Parse("f0dde581-3263-4583-b700-190c04c9819b"), }, { Guid.Parse("4cb29258-506c-492c-9101-d578ea346ed0"), Guid.Parse("0db3676d-3570-4cdb-b942-1743a2e60965"), Guid.Parse("2e257ea3-6945-4e72-948a-2a82ce019166"), }, { Guid.Parse("38b7e244-1e84-48b9-866a-fb7e48c22392"), Guid.Parse("18e71af3-942e-4cc0-b766-ba001dc7e75d"), Guid.Parse("12eb21ab-7659-405c-a2ff-745e6f3d5784"), }, }, { { Guid.Parse("5e959f38-0376-42ad-97e0-03bd061203ed"), Guid.Parse("0c4e1881-1ec7-4d14-abba-a1ec1d10b9c1"), Guid.Parse("91e235c7-eb1c-4f78-ac50-cd023dba446b"), }, { Guid.Parse("8b0bd795-97ae-4388-ad70-7b5b50407dcd"), Guid.Parse("1545a2b5-f83e-4195-a5bc-873aa459a878"), Guid.Parse("db458c08-4b51-4be6-b7c0-ac5ad4e9a556"), }, { Guid.Parse("afe34302-3f8b-4e9a-ab32-c87aa8ad4e30"), Guid.Parse("f9049255-b6c9-45dd-b620-5c7aed290701"), Guid.Parse("54cd082a-a62d-4750-8e05-7ad154e96e5f"), }, }, { { Guid.Parse("3daaa459-56d4-49f5-ae6a-b96be2ff1a18"), Guid.Parse("673f5178-8640-4dbe-be42-7c47ee21dce7"), Guid.Parse("18e3b285-08b9-489d-ae4c-342edfb3fbb5"), }, { Guid.Parse("5ff1f1f5-c5b6-4583-ae66-1161d0e876ad"), Guid.Parse("9843cdc8-ff30-4aa2-99af-76d8f7520886"), Guid.Parse("c6b2d29e-0d6c-4b1f-a116-66e6efeff255"), }, { Guid.Parse("3b967d23-0cf5-4136-b039-794501b96f50"), Guid.Parse("979228f7-1330-4681-86d7-df8985098b1b"), Guid.Parse("6ad87483-dffd-4562-832f-fac0ea24231c"), }, }, },
},
            new GuiduuidMMArrayD3E1M
{
    Id = 155,
    Value = 
new System.Guid[,,] { { { Guid.Parse("3136f842-a8d9-43da-b361-cd7dbb4d932d"), Guid.Parse("33b6cdfb-4719-4c60-92a7-7547cb965452"), Guid.Parse("3679a6c7-4475-4567-bb84-c33ceb6b52fb"), }, { Guid.Parse("cbaac145-fecf-4150-b81c-053dfec29753"), Guid.Parse("c8325e56-72ee-40b7-be8c-fe1c12d809e2"), Guid.Parse("77b41225-1758-4d45-a9e1-bd56762b5ad8"), }, { Guid.Parse("c991e457-4bfd-48e4-993d-fe223ebf32f5"), Guid.Parse("56559209-3497-43c8-906e-71f68069eed8"), Guid.Parse("f529fb9c-3a7e-44e1-b63f-4b88e2a1b5da"), }, }, { { Guid.Parse("fb473448-afe4-48c7-af8d-5c6d05b7d583"), Guid.Parse("c439e93d-7de6-4dc1-9ea9-6ff7fbc8fb87"), Guid.Parse("af218848-bc77-469f-9629-9b61c2b8054e"), }, { Guid.Parse("3d54937b-684b-469c-89ec-73d45b9b7a0e"), Guid.Parse("0d016e9b-08d3-473e-a785-01d1dc36d4a4"), Guid.Parse("810279f5-5234-467d-858d-3d031a05b3ff"), }, { Guid.Parse("06ac3364-33c1-4de7-a6db-33e9309ea6ff"), Guid.Parse("128186f6-914b-4279-9217-b250bc0a5ae9"), Guid.Parse("cdefe588-496c-4fb9-b3ff-dfe46dffff6f"), }, }, { { Guid.Parse("c0c2fbec-fbe5-4710-89bc-8867df3b5bc9"), Guid.Parse("6059cda8-2caf-46e9-a77e-13c84c37b6a2"), Guid.Parse("49cad484-b670-43da-a4a7-eb6cbe442b3b"), }, { Guid.Parse("f8bdc0ae-7863-47a7-9c3a-6dd176a47d84"), Guid.Parse("61564454-3feb-44ec-8b24-51fcbb38063a"), Guid.Parse("f7d8ca62-de07-4ccc-8f80-786ce3f1dfb6"), }, { Guid.Parse("e5854b59-ae43-469a-b1a2-fae88132de19"), Guid.Parse("53a08bdc-f010-454b-b5f1-d0583d508657"), Guid.Parse("ec5d2a9e-b2cc-42eb-980f-fe564949b088"), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD3E1M
{
    Id = 160,
    Value = 
new System.Guid[,,] { { { Guid.Parse("ef9b6e33-ba1e-4603-aa21-b29f43d75c7f"), Guid.Parse("89e96f36-7978-4ac4-9d3e-a0b4305bb99c"), Guid.Parse("9160d41e-4cda-4f5b-8a26-3b4fb888c297"), }, { Guid.Parse("ac7921df-1ff2-4623-be7c-b2d04b0177dd"), Guid.Parse("230883d0-5181-49bd-a6a8-67b21d6e7a13"), Guid.Parse("338c718a-8caf-4cf5-9299-c7f8eb03f97f"), }, { Guid.Parse("34101c7b-7c79-470f-8bea-1f54f215f0f0"), Guid.Parse("24be6839-8a97-4ecb-869d-01a76dfea4f2"), Guid.Parse("fa503792-ae1b-4cf6-b88a-290d93489a12"), }, }, { { Guid.Parse("0673e895-f9cb-4ed3-9c62-f206ed30f822"), Guid.Parse("3c3e1e80-5d03-4100-84c7-474408c8faf7"), Guid.Parse("06d1b220-8f7e-4dbf-965f-405be038ec36"), }, { Guid.Parse("a57cab28-fd1e-41a0-a308-df077698ceb8"), Guid.Parse("c43d9c0a-0df6-409b-8dfa-fd33f9fd38fa"), Guid.Parse("04e849ab-87ad-4cc0-a7bc-75d991729f82"), }, { Guid.Parse("be6e22fa-6d4e-46eb-99c9-8048ffffaefa"), Guid.Parse("5b58c9e2-cae0-47a9-9880-be59c4c30abf"), Guid.Parse("783f7ccc-9033-48e2-b72b-2fc8b05f9f2e"), }, }, { { Guid.Parse("830ae204-dd5d-4d4b-8b42-102fcc89ba97"), Guid.Parse("018b94a1-63be-4514-b9e7-737b147e5332"), Guid.Parse("0746cb37-2d92-47df-a708-f56e5e6a6a51"), }, { Guid.Parse("efd5daee-917c-42a3-9673-1c787d6c1f26"), Guid.Parse("db68fbfa-b804-4e33-ae97-adc1469c06c3"), Guid.Parse("e59b72e2-87d6-437d-9e7f-7e32f414f98d"), }, { Guid.Parse("1f4a21e0-0a0c-4c89-b881-f804f9e4cee0"), Guid.Parse("39323854-c987-4954-af6b-72a34dde76a1"), Guid.Parse("2b157abb-282b-4601-8905-ce3bf53f67a5"), }, }, },
    ModelInner = new GuiduuidMMArrayD3E1MI
{
    Id = 87,
    Value = 
new System.Guid[,,] { { { Guid.Parse("fe409cfa-f499-4745-984b-27835ecb0b55"), Guid.Parse("6102d9fa-a18a-45f5-80bd-78142e31a8a1"), Guid.Parse("2f9ada27-52a3-4030-921a-6c6b614ccfd8"), }, { Guid.Parse("03e9ac9d-5e6a-4d8e-825e-d2d4238f8f97"), Guid.Parse("be3932c3-81f3-4604-82cd-0483e2ad1632"), Guid.Parse("05eb6bf8-8610-4549-86ee-e6a1beb61b8f"), }, { Guid.Parse("2c8c1c05-2f52-4a84-a0f0-375359ff7bd9"), Guid.Parse("a76c2a3a-d38e-4976-9cbb-55bf7d27d687"), Guid.Parse("c95c548d-106a-4b89-a877-844530f2714c"), }, }, { { Guid.Parse("1ae7b0e4-f05c-4ef2-8011-6e4d514c5e64"), Guid.Parse("78c64106-2883-4d34-8c64-4a87b0fe4843"), Guid.Parse("c3538aec-0c2c-4923-98cf-98c3c893b9dc"), }, { Guid.Parse("e1e043a0-d674-40bd-886b-5e68389ed0c4"), Guid.Parse("7ada2b2d-c921-498e-9bc2-ec0f0e7642a0"), Guid.Parse("3e4f4fcc-e5e7-455a-81b7-4af9b1d13cdd"), }, { Guid.Parse("069e8e50-7d02-4be7-8d5e-993ae026bce1"), Guid.Parse("b9a239e0-1183-43b0-91b1-6759d7ace762"), Guid.Parse("df05f32b-1098-447a-a8f9-21dc4342a8c9"), }, }, { { Guid.Parse("149d8473-8441-44d5-902b-1ed90bedaa91"), Guid.Parse("0580c496-31a0-4e4d-9359-73dc0b856d0a"), Guid.Parse("7b7398fa-5879-46e6-8719-ed410776e323"), }, { Guid.Parse("9cfc445b-36fe-458e-a1e9-126ccb336258"), Guid.Parse("2b2388e0-3888-4ef7-9b97-5ef78aa6f9f2"), Guid.Parse("59bcd28a-deda-4029-b95b-34c951905571"), }, { Guid.Parse("530dfb4b-d20e-4099-84c6-7d7c35f66648"), Guid.Parse("cb4ea8be-9d1f-4b1f-92ef-2b9a006e50a2"), Guid.Parse("e7d5c502-cbc8-4b7e-a3d5-14d82764e8ba"), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD3E1M
{
    Id = 164,
    Value = 
new System.Guid[,,] { { { Guid.Parse("5e247cf4-4471-4909-892d-f495da0736ab"), Guid.Parse("cad7692e-6296-46d6-8c93-028698ba787b"), Guid.Parse("b8e76f19-ad28-41e3-9cd2-faba8b163c0e"), }, { Guid.Parse("c1074b65-5154-4fb3-9a88-db64f8fcec1f"), Guid.Parse("950641f4-90c3-4c83-843c-63bb7f6eeb97"), Guid.Parse("ade6aa13-8cc0-4ade-b246-cbc354073ed2"), }, { Guid.Parse("8b4b9c31-3952-434a-af89-cda38018f752"), Guid.Parse("cbf346a2-21a9-4b24-a76a-742707a2a72b"), Guid.Parse("84d109d7-be1f-4974-bfe2-7822cd0670fb"), }, }, { { Guid.Parse("91f5314b-aded-4dd2-8da6-18e2ef434dbb"), Guid.Parse("1c046ca7-57aa-44f9-9c41-2d27fc868adb"), Guid.Parse("37229eb1-73d8-4af3-8b89-9fc8431a8a00"), }, { Guid.Parse("a91c00a9-9a48-444c-bb16-df93bfcbe511"), Guid.Parse("d16427c8-16c7-4c2b-995b-1628452d201f"), Guid.Parse("54bef492-d4a8-4831-9d05-b4a73c3b3f75"), }, { Guid.Parse("d0b08bb8-be2e-47c2-a9b0-a556ad815a21"), Guid.Parse("a6bce033-ef46-4347-b3cf-1256c39b44e5"), Guid.Parse("e279bf94-9af7-425d-83ab-e3db586c581f"), }, }, { { Guid.Parse("d3bb3083-f93d-49ca-bb48-d440df55a15d"), Guid.Parse("7a9f039a-d723-49aa-a6cc-ed64807731e6"), Guid.Parse("9273f49e-4235-448d-9bbb-1720d0bbc5d4"), }, { Guid.Parse("b274a60a-98b1-4d8f-a46f-c48d145bd8fa"), Guid.Parse("b0c2cae6-9100-4716-8bb2-715c139431f5"), Guid.Parse("97ee0db2-a1fe-4cab-ac88-995034594c6e"), }, { Guid.Parse("39b00ffe-a6bb-4f8e-bc2f-395c805768b6"), Guid.Parse("26487336-413f-46d0-983f-4185dffd7bee"), Guid.Parse("3e10b087-da3a-40cd-92a3-f385f5899a04"), }, }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,,] { { { Guid.Parse("935cdb4c-a965-4768-8192-e11184ad124f"), Guid.Parse("c224b72c-e501-4dc3-8a1e-65de2777ec8c"), Guid.Parse("343b8789-3b56-4f31-9b8a-004a594af3dc"), }, { Guid.Parse("1cbc00e1-04c2-404f-bc1c-14121f8694d0"), Guid.Parse("42fdf4ba-8d65-4097-992e-07e9ab48e6ba"), Guid.Parse("0c48b9ce-4793-4559-8b65-c3330ffb77a3"), }, { Guid.Parse("3eaeb9cf-99a2-49e2-abef-bd0cfb264537"), Guid.Parse("21b9bb75-3517-4c72-abaf-59c57a4d94c3"), Guid.Parse("27e4c0ad-29c6-4c04-8d5f-701635714b0b"), }, }, { { Guid.Parse("206f8ff9-c2c8-4990-ab9d-c4472da3b105"), Guid.Parse("451c0f5f-a81f-48c0-88ce-1deebd41cc6b"), Guid.Parse("c691aa21-7b49-4d98-9b66-8164b1db0e91"), }, { Guid.Parse("a9ea47a8-0c3c-47e4-9195-9a8ba8b58869"), Guid.Parse("c337d38c-72ba-45c5-9cc7-038ce5ea8982"), Guid.Parse("ee7b17bf-1bf5-4f35-b69f-589de59b5569"), }, { Guid.Parse("fb7280a2-c27b-4f46-8d48-6e1dcdfe18f9"), Guid.Parse("edbe4f0a-985c-45ac-a035-fe54cf80e7b9"), Guid.Parse("a53eeef1-11fe-4e5d-9ebe-fd2f2b3c55e2"), }, }, { { Guid.Parse("b93e4e10-90d7-48df-92f3-a6391f6c23ee"), Guid.Parse("8ad24f77-ea26-4382-b8ab-5fdf5a48bb5c"), Guid.Parse("5786b40f-d8fc-47dd-b504-be836bfec3d6"), }, { Guid.Parse("7f9decc4-8b38-4083-8f28-c405a3e05237"), Guid.Parse("19329159-8c98-4ae3-8877-13e73f233fed"), Guid.Parse("8e0aecc1-b75c-4573-b56f-d2bddad10fc1"), }, { Guid.Parse("aa5439c8-754d-438e-988c-6ab67bba901e"), Guid.Parse("f23b52d1-789f-487a-8bde-da4f886cc0f4"), Guid.Parse("9acb7f7a-6d77-4e2a-8e70-0b3070dca748"), }, }, },
},
            new GuiduuidMMArrayD3E1M
{
    Id = 173,
    Value = 
new System.Guid[,,] { { { Guid.Parse("acd56674-71f3-4881-a174-5d95016a3cb7"), Guid.Parse("64c9218c-a866-43ca-a2c0-c05d7322cd71"), Guid.Parse("8ae315e4-03fb-4241-9c9d-3a2b4846c4f4"), }, { Guid.Parse("d8eb8413-6631-44d6-8d60-10cbbad7c070"), Guid.Parse("ccd4bc5b-5bc1-467a-8fd2-60f7ea379cc2"), Guid.Parse("4b9a7223-e149-443f-a685-25bf5ee328ef"), }, { Guid.Parse("eb491811-667c-4740-a790-7abb9cceaa9d"), Guid.Parse("22e95995-528d-4880-b929-aa180b9623b3"), Guid.Parse("b7a01e76-dd57-498a-b091-08355afd0fbb"), }, }, { { Guid.Parse("2a5221c3-225b-4b24-aa5b-2213e97cd4eb"), Guid.Parse("e6b29c96-f33d-442a-ba00-89ca77032838"), Guid.Parse("d918edef-7cc2-446c-9c2b-993d6a4e897f"), }, { Guid.Parse("47a91075-501c-441d-8bbc-b5f45bd444a2"), Guid.Parse("b7cca576-dc1a-4d02-96be-3cf73dd1f3e0"), Guid.Parse("7c88a77c-4040-4d4b-bee9-936795b9590c"), }, { Guid.Parse("72d60cb9-d834-4d56-ad92-ff42873ab059"), Guid.Parse("763a7e07-6336-4af4-a910-05a5705b73c8"), Guid.Parse("8d84bd51-c6d9-499b-a0bd-710e82f310a0"), }, }, { { Guid.Parse("e48053df-a1f9-4eb5-b603-e9fe9818db3f"), Guid.Parse("f572bf79-d5ba-47f0-a56a-9bcc27836c01"), Guid.Parse("ea430aa0-3395-4861-b62a-ba10b9aa58b2"), }, { Guid.Parse("e9e14b38-7ae8-412b-a95f-6bec7e4cc3fc"), Guid.Parse("58c4df29-d3d1-4b86-bc5a-fb7d10bcee11"), Guid.Parse("9c2d72e2-e34e-4fe8-92b4-35e3ac43b7e7"), }, { Guid.Parse("156a3aa8-60d4-491f-a7ae-0b67115016e6"), Guid.Parse("35a5bee3-36cb-4734-83a2-9dda9a63b94d"), Guid.Parse("57c7ab5c-6429-4a87-b26a-8e3b2e8530f4"), }, }, },
    ModelInner = new GuiduuidMMArrayD3E1MI
{
    Id = 88,
    Value = 
new System.Guid[,,] { { { Guid.Parse("ade4a25e-0903-4c11-b785-5a5212ea8d98"), Guid.Parse("27ed344e-3abd-460f-acd0-072b3da790f9"), Guid.Parse("1998789c-9ec1-40d7-8580-3c4a950b5451"), }, { Guid.Parse("1489cb8c-67b5-410d-a459-cae163ad7015"), Guid.Parse("39862125-8fee-4c4b-94a6-b6243b7b3702"), Guid.Parse("4148bc68-3a3a-4a74-9cf5-c08562cd58cf"), }, { Guid.Parse("9af59f12-41d6-4372-9aa0-2f0423d75587"), Guid.Parse("3dffa424-6687-4888-8bf5-a81d42e29146"), Guid.Parse("2a3c1dcb-f022-4e64-83f2-c3c575d70b64"), }, }, { { Guid.Parse("88ecfe8d-2d6f-4e2e-a6d5-22ebb5b705f0"), Guid.Parse("1793cf2a-feaf-4f43-ba66-db19364bd11d"), Guid.Parse("4b5bd787-5364-453d-9aaa-4fd1cba5fe40"), }, { Guid.Parse("7fe1f1d2-027a-463b-a33b-dda311104c1e"), Guid.Parse("89f1a1c9-a776-4f33-a26e-a5639ea8dac8"), Guid.Parse("f0b2e38d-8111-4b26-9f64-1414f426810d"), }, { Guid.Parse("63a2346e-d5d5-46c8-be4f-70ce2df0cbee"), Guid.Parse("87ec7591-36a8-42a3-8bc9-dcb778b7b878"), Guid.Parse("a997cced-4bbb-4109-bf1a-2b43d35e181f"), }, }, { { Guid.Parse("2df71a98-a6c1-4c88-b776-3edc2530ede6"), Guid.Parse("fdfa820a-0e86-44d5-9ced-bd3b454ac308"), Guid.Parse("2ca127f6-5bd9-4791-a830-2f7bbbde32c4"), }, { Guid.Parse("443b920e-b8db-4cb0-9e7d-34b8afcdb43c"), Guid.Parse("8bff79c9-1d3b-4620-b1db-393c80f2f9c7"), Guid.Parse("4890a15f-d860-47e1-8139-e7126f7b4e63"), }, { Guid.Parse("d267df21-d999-4c5f-8e2d-2cd0d36bf372"), Guid.Parse("700fc29b-365c-47e7-98ca-fba0b34c16a3"), Guid.Parse("ad930c22-639f-4bbe-b913-85eebfc79a50"), }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,,] { { { Guid.Parse("4e4e7921-78a6-45bf-bedf-21a219e4724a"), Guid.Parse("c1b3d6ad-2b44-433c-9517-6d02d43dd2c0"), Guid.Parse("0d07dd9d-dcd3-4ce7-8caa-213ef270b0df"), }, { Guid.Parse("937efc07-309f-431f-8206-a3b1ec30f068"), Guid.Parse("873f0ef2-3b86-4347-9974-1206e9a5a7f3"), Guid.Parse("bf86211b-8fdb-45b0-b380-80e248a25c42"), }, { Guid.Parse("382696ac-529b-4e46-82fa-037663c918d0"), Guid.Parse("66b3e135-cbb6-49d3-ba51-ca5579129bd8"), Guid.Parse("5f19515c-bed6-4d00-a489-17ef5ad66d5d"), }, }, { { Guid.Parse("a482810f-e583-4502-aa0c-9c2dcdf96193"), Guid.Parse("5ceb6ce3-e4bc-4da0-90d4-036759c277b7"), Guid.Parse("e4ea2147-c3a9-406b-8aab-375c156d3c4e"), }, { Guid.Parse("2cb4d37b-174f-404b-ab81-586a2e716f5f"), Guid.Parse("6f6aab54-a991-45d9-b1a1-4e7cb6931bac"), Guid.Parse("cabcf96b-a02b-4c22-bf4a-2b55fa717ced"), }, { Guid.Parse("d5ea3634-2687-4571-b479-24582a5fe57c"), Guid.Parse("d770ea02-d1a4-4721-b94b-37fdc971ee48"), Guid.Parse("7bfbacd8-4f4e-4111-9064-b94e4591f0b8"), }, }, { { Guid.Parse("bd4bb2ce-77bb-4b4d-8dab-1044ac92ebb3"), Guid.Parse("a41ee3b0-415e-4a53-97ff-c0ade50c5e00"), Guid.Parse("b4a244ee-90aa-49ee-9dec-90ada583344b"), }, { Guid.Parse("21af1b54-8f00-4b25-b55d-d7c08d696c2d"), Guid.Parse("af5b3ab1-3618-47a1-a8c1-87618665cb5f"), Guid.Parse("29e627da-bf2d-402a-9fad-48b12944f36b"), }, { Guid.Parse("b0770d86-d5f9-4161-b1f3-8c195c0d47e8"), Guid.Parse("51504e16-11a1-4a33-bbfb-9a06870a2f6c"), Guid.Parse("95611573-5cbe-417c-a742-685d7648f1ea"), }, }, },
},
            new GuiduuidMMArrayD3E1M
{
    Id = 176,
    Value = 
new System.Guid[,,] { { { Guid.Parse("97e98963-7b0d-441f-bde5-2e92b10ee4bb"), Guid.Parse("f987e83a-4367-4f3d-9757-a4c2d0b57d73"), Guid.Parse("93012091-36d1-4b87-b23f-c38044871b0a"), }, { Guid.Parse("481be809-d084-4296-844b-6fc34809bd99"), Guid.Parse("be201d65-6723-47b6-bbf8-9753ed85af0f"), Guid.Parse("d1f5fa5c-ac45-4759-a80c-0cb704878512"), }, { Guid.Parse("94d677a5-2334-4750-b466-a88513da2416"), Guid.Parse("6ad21abd-7764-4069-991d-4004da969034"), Guid.Parse("70bc6ef3-f694-4b12-81b8-43416cd61d3c"), }, }, { { Guid.Parse("4cff660a-3e97-41e5-b6b2-8ac644a6e8f6"), Guid.Parse("f6aa8922-d3c6-40ce-8962-e32916e23fd8"), Guid.Parse("fbbca48e-9b73-4888-8aa5-fd934dea1cfd"), }, { Guid.Parse("cb5ef472-b0d7-4581-8549-2f1176584dcc"), Guid.Parse("e614d268-1f79-4480-a1f7-553123315467"), Guid.Parse("1c349d8c-e107-42cd-8d19-6e6d303e736d"), }, { Guid.Parse("94f368e0-500c-41f7-b700-5c950983ca32"), Guid.Parse("2089c319-8903-4664-b5b3-f722330b66ff"), Guid.Parse("d4eba60d-4941-4351-bcb2-41da07c06389"), }, }, { { Guid.Parse("b5002290-0893-42ab-ae7e-647136b113bf"), Guid.Parse("4c27a2bb-86bf-44fd-999e-f2d755818966"), Guid.Parse("3799f3e8-2b05-4340-9402-a5ff31d01bac"), }, { Guid.Parse("b96df00a-0898-4d27-9396-fbf288650a4e"), Guid.Parse("bbd35476-807c-4012-8a62-42c4f9ab1097"), Guid.Parse("0224c549-0af7-4bd6-ba64-52ac2268391a"), }, { Guid.Parse("706ecea9-053d-4713-ae0c-ee4f45331811"), Guid.Parse("43fda7fb-5637-429f-add6-fff7e71fa693"), Guid.Parse("3d14b11f-9a50-4529-9890-cfec8abc4c8a"), }, }, },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd3e1mi(
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd3e1mi(
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
            queryMapTypes: [typeof(GuiduuidMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,,]), 
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

                changedRows =  ((IGuidMArrayuuidMMArrayD3)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidMArrayuuidMMArrayD3)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IGuidMArrayuuidMMArrayD3)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidMArrayuuidMMArrayD3)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IGuidMArrayuuidMMArrayD3)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IGuidMArrayuuidMMArrayD3)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IGuidMArrayuuidMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd3e1m(
	id,
    value,
    nullablevalue,
    guiduuidmmarrayd3e1mi_id
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuidmmarrayd3e1mi_id", 
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
                changedRows =  ((IGuidMArrayuuidMMArrayD3)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IGuidMArrayuuidMMArrayD3)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IGuidMArrayuuidMMArrayD3)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IGuidMArrayuuidMMArrayD3)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd3e1m(
	id,
    value,
    nullablevalue,
    guiduuidmmarrayd3e1mi_id
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
    guiduuidmmarrayd3e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(GuiduuidMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3)),
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
                System.Guid[,,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[,,]>();
                    ((NpgsqlParameter<System.Guid[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[,,]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((IGuidMArrayuuidMMArrayD3)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[,,]>();
                    ((NpgsqlParameter<System.Guid[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[,,]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((IGuidMArrayuuidMMArrayD3)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,,] { { { Guid.Parse("8fae7e73-da4f-4ce5-90a9-2e292f45cd31"), Guid.Parse("21141bbe-7ea7-430d-beaf-304fedd12e13"), Guid.Parse("7f51a57b-2e34-4060-b0e8-d5379f442680"), }, { Guid.Parse("01314106-3178-40ba-8674-0c08a92e8b36"), Guid.Parse("6f67ca0a-1e3e-4253-8c68-c94ebedd2175"), Guid.Parse("fd734181-304e-4ec1-abb0-e6529771e066"), }, { Guid.Parse("9c6d0998-4199-4115-9040-d845d90bac97"), Guid.Parse("1e76037c-7ce8-4b84-bf4a-17828892e635"), Guid.Parse("761b0d22-2a7b-463f-9f86-e9c0b7255db5"), }, }, { { Guid.Parse("94abf7be-1ab4-4a59-b444-447d725355b0"), Guid.Parse("d4d032ef-d7ee-48e4-9f2c-204a07f89c9d"), Guid.Parse("c5ad1ac3-22f0-4927-bd4b-99e95d8bea7b"), }, { Guid.Parse("45a92c7f-a75d-47e2-932e-cba8fe79fd03"), Guid.Parse("2b7589dc-7d5e-4ddf-be51-526d2007c1fa"), Guid.Parse("4ab339f5-7512-4fa4-b20c-15196edf9a36"), }, { Guid.Parse("42f3d03c-bc1a-47c2-8e88-f7587f6210a0"), Guid.Parse("bc5eb6f9-fed3-47ca-b2e1-6ad3358a8ab1"), Guid.Parse("f4d37453-c1bc-4b5b-9b1f-adcbfcb98b46"), }, }, { { Guid.Parse("6a81cc06-7f94-4c76-80c8-d9d447e20c0e"), Guid.Parse("04a2b86a-98fe-4c4f-a858-e07cff2f682f"), Guid.Parse("f5910725-5a8f-48c5-ae06-094734577e8f"), }, { Guid.Parse("c6ce5036-8056-448a-9d06-2192de260440"), Guid.Parse("0932cb9c-1baf-4760-86de-0ef2e67b0454"), Guid.Parse("611b2c4e-b321-41a8-ab1c-e0a9e48906ac"), }, { Guid.Parse("65bb1c96-7380-45c5-9b36-59698a049d46"), Guid.Parse("ed2629dc-31c3-439d-9935-479b0a7cca06"), Guid.Parse("4fd05985-26a3-44a8-8e43-3c18b30c02b7"), }, }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Guid[,,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[,,]>();
                    ((NpgsqlParameter<System.Guid[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[,,]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((IGuidMArrayuuidMMArrayD3)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,,] { { { Guid.Parse("98d5070b-dbe4-45ea-bc3c-c4d92e75e68d"), Guid.Parse("75790aa7-5ea6-4ca6-a1a9-53f6ca5e3433"), Guid.Parse("2ff7f265-afc0-481a-bdf5-9d328c4a7bd2"), }, { Guid.Parse("1581a92e-dd71-4aa2-aaa3-7c74d7ee511d"), Guid.Parse("78ec4f4f-4520-4ca1-a629-4ec86a438888"), Guid.Parse("2e7060c5-3a6b-4f3d-b8cc-d69e68fe88a3"), }, { Guid.Parse("e5eb5b72-640f-46f2-9154-25aa0a4c655a"), Guid.Parse("a0aaeaf9-83d5-4ddd-836e-f365a19b0612"), Guid.Parse("b5335825-ec8e-4fd4-a538-b53ff195b427"), }, }, { { Guid.Parse("c020ada7-5b56-4ccb-a717-b91ad801617a"), Guid.Parse("5f38f382-0421-414a-8aea-b5be2f070e12"), Guid.Parse("409650ce-16e2-454a-b3cb-bbece1cec28d"), }, { Guid.Parse("62039872-4c9b-464d-9dfc-d57f2289e1ce"), Guid.Parse("e33bfba0-e927-4a67-82d1-d99cec96a98f"), Guid.Parse("618cfa6b-a5a3-4b3f-b6f7-5301226ec158"), }, { Guid.Parse("3c29b7cf-411b-433a-a560-c0e67036f895"), Guid.Parse("7db2695a-e0ad-44ac-8a41-b79c8c53a6bc"), Guid.Parse("ae2ff8f1-45eb-4453-a924-b7b20be9054b"), }, }, { { Guid.Parse("2170ba72-d69e-452d-b5fd-683dcf1923be"), Guid.Parse("e6068d8f-d891-4500-b785-c9acf447b9d9"), Guid.Parse("2dee4a45-d8d5-4653-af92-58fea06d2f2c"), }, { Guid.Parse("88ce2545-6f21-49a0-9cf6-56d6ca629e29"), Guid.Parse("429f67ac-43b0-4f47-b470-4715ce73fa20"), Guid.Parse("fbee66ae-46b6-412e-8e71-cee6ba651e0e"), }, { Guid.Parse("05905fd4-94f9-4f2a-9a76-b3b50dc62bdd"), Guid.Parse("95a3075f-8bad-432a-8c37-a1ec510bc2ac"), Guid.Parse("547c588b-11e2-4ea2-b573-aa2aab837a2f"), }, }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[,,]>();
                    ((NpgsqlParameter<System.Guid[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[,,]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((IGuidMArrayuuidMMArrayD3)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,,] { { { Guid.Parse("6bec72d8-59ab-49ff-94f2-d7bf6f674b74"), Guid.Parse("1829e226-f309-4f86-b435-518dd99c5c74"), Guid.Parse("168a375f-1213-4a96-9500-e159ae85e870"), }, { Guid.Parse("206d0f1f-41d1-4993-8e7f-9a9b8cad9322"), Guid.Parse("c320b7af-2268-4774-8475-94729fcd25b5"), Guid.Parse("3d00de28-92de-49c7-831b-e95564335481"), }, { Guid.Parse("7756a817-9037-4df5-abf6-21d5e277cc39"), Guid.Parse("6a78fbd1-b71d-4f67-bc2e-348169155fb7"), Guid.Parse("1bc08a0f-8f24-496e-aff4-724b43d33a1f"), }, }, { { Guid.Parse("ad467527-c3d7-4211-b04f-1436be2127bc"), Guid.Parse("9f3746a4-7e90-4e96-93ab-ed1ebc5a5ec7"), Guid.Parse("b7ddf57a-7d18-43eb-baeb-91b98645517e"), }, { Guid.Parse("57de9497-fc7a-4759-9e10-087addff80d0"), Guid.Parse("d469f1c4-a43e-4f1c-b94a-feaadef9b109"), Guid.Parse("93466914-9b0d-47b8-a9ef-fd171d8f3d7f"), }, { Guid.Parse("d81dd479-0e27-4e3b-bce2-55938bb7a66a"), Guid.Parse("3addcb72-7320-41a9-b2a5-0a48c8190e85"), Guid.Parse("9971bd8c-9c12-403d-80f2-dd71124a084f"), }, }, { { Guid.Parse("62388f01-96a5-4420-b18d-fec506ddb639"), Guid.Parse("3c097718-33c7-4aee-82ac-22761446a8ad"), Guid.Parse("b9d7fc60-2d26-49be-9bb0-16f077626a81"), }, { Guid.Parse("d078bb6b-f526-4fc4-bcab-f605326ba69f"), Guid.Parse("e1b308ef-ef6f-432d-9315-102e4ae7bb24"), Guid.Parse("f05eace9-a87b-4af9-ac24-d6f3b4d7acd0"), }, { Guid.Parse("a18e08c4-892a-4335-96aa-9d7809f0eafd"), Guid.Parse("38dd9edc-869f-456d-b629-8d6336b7136c"), Guid.Parse("10382468-6ce8-4a6e-b892-8a557a82a758"), }, }, }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd3e1m(
	id,
    value,
    nullablevalue,
    guiduuidmmarrayd3e1mi_id
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
    guiduuidmmarrayd3e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(GuiduuidMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuidmmarrayd3e1mi_id", 
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
                System.Guid[,,] nullable = null;
                nullable =  ((IGuidMArrayuuidMMArrayD3)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,,] { { { Guid.Parse("dcd99de6-ad36-498e-b351-ecb11079b979"), Guid.Parse("b9238989-12c7-4211-8d22-c41040b8acfd"), Guid.Parse("3e99ef18-87ba-4592-a1a2-51f1c628ecb8"), }, { Guid.Parse("c96cbee9-386e-40ea-a9f3-8c1a4890d226"), Guid.Parse("62e77f16-4c8b-495b-ab5e-c8e7928c2285"), Guid.Parse("d50cd544-fd27-42ff-9fb5-2878740a93a6"), }, { Guid.Parse("f5f613a1-1dff-4f3d-a86c-a5060760ff36"), Guid.Parse("96ad1156-6bbf-476d-9d36-2bdb9fdc2252"), Guid.Parse("718efb3b-0b75-4573-af03-0eb6589b812b"), }, }, { { Guid.Parse("bc7feab7-39c4-481c-a703-bd57763b1370"), Guid.Parse("786887ab-d188-4018-957e-6137aaf9f9fc"), Guid.Parse("bf73d48d-324d-4da0-bf36-25c5303a28c7"), }, { Guid.Parse("0e6de81b-e613-4c98-b377-a1b7136956cf"), Guid.Parse("843d2c72-67d0-4194-9e1e-1d91c9e3dbf2"), Guid.Parse("71542526-fd87-4191-9a1b-28e6e3c59194"), }, { Guid.Parse("d34684c6-1315-471f-a391-33bd9edf593b"), Guid.Parse("4df0d385-2ac2-4602-9e5d-3b72d68fb075"), Guid.Parse("a9ea5d86-a3bb-459e-acff-df48e08b3e38"), }, }, { { Guid.Parse("1371e5a2-cb59-4838-83b6-a38625b0f0d5"), Guid.Parse("ac5a8796-fde8-4609-8c7b-440c129e9871"), Guid.Parse("9565dc12-a4ce-4af5-8029-bb1d49630007"), }, { Guid.Parse("f346977f-5966-4ef7-80b9-89c4c121f91f"), Guid.Parse("5620aee1-df32-48c5-8dd4-3ba8bea94a78"), Guid.Parse("5bd4b263-6490-4d1c-901b-2c0a4485f571"), }, { Guid.Parse("126a2854-368a-4626-9d5e-0c9582e5a702"), Guid.Parse("48e930af-a9b2-4262-9903-7d66a765ccd3"), Guid.Parse("076678bb-8ff3-4f23-a239-4aa43b31390b"), }, }, }));
                nullable =  ((IGuidMArrayuuidMMArrayD3)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Guid[,,] nullable = null;
                nullable = await ((IGuidMArrayuuidMMArrayD3)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IGuidMArrayuuidMMArrayD3)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,,] { { { Guid.Parse("c2361326-cc85-4d2c-b981-85b7bd91d34c"), Guid.Parse("cfffe930-d7e6-4509-896f-71e94ac6e1ed"), Guid.Parse("cb966f3d-60b6-4983-b240-7050f0a145da"), }, { Guid.Parse("2a89cc04-8481-41ff-ae1d-dd14dc052711"), Guid.Parse("81cc164b-f193-4f90-abad-e22bf6e45a43"), Guid.Parse("b5b980c6-d787-4d6e-9375-8021edc164db"), }, { Guid.Parse("19759c79-8f8f-4e4b-9dbb-b76b3d5fd000"), Guid.Parse("7950cf51-9d30-4339-bb69-2a29d15c54f0"), Guid.Parse("242196ac-9082-43cf-92d6-94386b805736"), }, }, { { Guid.Parse("63fbcc69-392f-4646-bf81-250059c9c1ce"), Guid.Parse("58e71038-0ba4-4322-93e4-0f766b4be265"), Guid.Parse("9c52531b-84cf-4c0a-928d-14c437d10731"), }, { Guid.Parse("bd0b0c2f-86ea-4617-99f8-567b63bfdc65"), Guid.Parse("148f2eb3-331f-43bb-879c-5366348d184d"), Guid.Parse("7782336a-c2df-4f90-a1bb-9de29eff8bdb"), }, { Guid.Parse("e72704b6-c9b5-48f1-9ad3-c13657f598d3"), Guid.Parse("b8293698-aad8-40e8-a646-5327ec560139"), Guid.Parse("9be1208b-77fe-428d-ad1a-9cefd217e471"), }, }, { { Guid.Parse("b669a2fa-ac1d-4fa2-9394-6e1a7581b419"), Guid.Parse("2842d73a-c44e-43c2-a0a0-b97450c53a4a"), Guid.Parse("4138781f-11b6-4871-b488-becc1e6741f5"), }, { Guid.Parse("fdb20db8-61ba-4577-a6a0-1f6a1ca9a8ff"), Guid.Parse("134731b9-0442-4756-ae4e-fe711257fd40"), Guid.Parse("9a45507e-0742-48c9-a760-334f3713e678"), }, { Guid.Parse("5786b92f-e78c-41ab-81ca-08e57b7d454d"), Guid.Parse("64797e10-0c01-4000-a812-a5ce446136a4"), Guid.Parse("74f47f21-ac69-45b9-8b60-8db45fd936bf"), }, }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidMMArrayD3E1M> models = null;

                models =  ((IGuidMArrayuuidMMArrayD3)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IGuidMArrayuuidMMArrayD3)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IGuidMArrayuuidMMArrayD3)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IGuidMArrayuuidMMArrayD3)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidMMArrayD3E1M> models = null;

                models = await ((IGuidMArrayuuidMMArrayD3)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidMArrayuuidMMArrayD3)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidMArrayuuidMMArrayD3)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidMArrayuuidMMArrayD3)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IGuidMArrayuuidMMArrayD3)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IGuidMArrayuuidMMArrayD3)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IGuidMArrayuuidMMArrayD3)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IGuidMArrayuuidMMArrayD3)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IGuidMArrayuuidMMArrayD3)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IGuidMArrayuuidMMArrayD3)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IGuidMArrayuuidMMArrayD3)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IGuidMArrayuuidMMArrayD3)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IGuidMArrayuuidMMArrayD3)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IGuidMArrayuuidMMArrayD3)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IGuidMArrayuuidMMArrayD3)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IGuidMArrayuuidMMArrayD3)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IGuidMArrayuuidMMArrayD3)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IGuidMArrayuuidMMArrayD3)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IGuidMArrayuuidMMArrayD3)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD3E1M), typeof(FlatGuiduuidMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3)),
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
FROM public.guiduuidmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidMMArrayD3E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD3E1M>();
                await ((IGuidMArrayuuidMMArrayD3)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidMMArrayD3E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD3E1M>();
                ((IGuidMArrayuuidMMArrayD3)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3)),
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
FROM public.guiduuidmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IGuidMArrayuuidMMArrayD3)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidMArrayuuidMMArrayD3)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd3e1m m
LEFT JOIN public.guiduuidmmarrayd3e1mi mi ON mi.id = m.guiduuidmmarrayd3e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3)),
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
                var models = await ((IGuidMArrayuuidMMArrayD3)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IGuidMArrayuuidMMArrayD3)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD3E1M), typeof(FlatGuiduuidMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3)),
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
FROM public.guiduuidmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD3E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD3E1M>();
                await ((IGuidMArrayuuidMMArrayD3)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD3E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD3E1M>();
                ((IGuidMArrayuuidMMArrayD3)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3)),
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
FROM public.guiduuidmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidMArrayuuidMMArrayD3)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidMArrayuuidMMArrayD3)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd3e1m m
LEFT JOIN public.guiduuidmmarrayd3e1mi mi ON mi.id = m.guiduuidmmarrayd3e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3)),
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
                var models = await ((IGuidMArrayuuidMMArrayD3)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IGuidMArrayuuidMMArrayD3)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD3E1M), typeof(FlatGuiduuidMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3)),
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
FROM public.guiduuidmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidMMArrayD3E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD3E1M>();
                await((IGuidMArrayuuidMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
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
FROM public.guiduuidmmarrayd3e1m m
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
FROM public.guiduuidmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD3E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD3E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD3E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD3E1M>();
                await ((IGuidMArrayuuidMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 99;
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
FROM public.guiduuidmmarrayd3e1m m
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
FROM public.guiduuidmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD3E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD3E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD3E1M>();
                await ((IGuidMArrayuuidMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[19],_testData[34], false);
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
FROM public.guiduuidmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidMMArrayD3E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD3E1M>();
                ((IGuidMArrayuuidMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
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
FROM public.guiduuidmmarrayd3e1m m
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
FROM public.guiduuidmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD3E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD3E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD3E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD3E1M>();
                 ((IGuidMArrayuuidMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 160;
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
FROM public.guiduuidmmarrayd3e1m m
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
FROM public.guiduuidmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD3E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD3E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD3E1M>();
                 ((IGuidMArrayuuidMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[2],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3)),
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
FROM public.guiduuidmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IGuidMArrayuuidMMArrayD3)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd3e1m m
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
FROM public.guiduuidmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD3)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[15], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[1],_testData[16], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[2],_testData[17], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[3],_testData[18], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[4],_testData[19], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[5],_testData[20], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[6],_testData[21], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[7],_testData[22], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[8],_testData[23], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[9],_testData[24], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[10],_testData[25], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[11],_testData[26], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[12],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[13],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[14],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[15],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[16],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[17],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[18],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[20], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[1],_testData[21], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[2],_testData[22], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[3],_testData[23], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[4],_testData[24], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[5],_testData[25], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[6],_testData[26], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[7],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[8],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[9],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[10],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[11],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[12],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[13],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[14],_testData[34], false);
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
                parametr2.Value = 78;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd3e1m m
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
FROM public.guiduuidmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD3E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD3E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD3E1M>();
                await ((IGuidMArrayuuidMMArrayD3)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.guiduuidmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IGuidMArrayuuidMMArrayD3)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd3e1m m
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
FROM public.guiduuidmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD3)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[8], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[1],_testData[9], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[2],_testData[10], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[3],_testData[11], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[4],_testData[12], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[5],_testData[13], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[6],_testData[14], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[7],_testData[15], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[8],_testData[16], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[9],_testData[17], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[10],_testData[18], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[11],_testData[19], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[12],_testData[20], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[13],_testData[21], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[14],_testData[22], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[15],_testData[23], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[16],_testData[24], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[17],_testData[25], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[18],_testData[26], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[19],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[20],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[21],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[22],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[23],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[24],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[25],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[8], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[1],_testData[9], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[2],_testData[10], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[3],_testData[11], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[4],_testData[12], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[5],_testData[13], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[6],_testData[14], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[7],_testData[15], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[8],_testData[16], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[9],_testData[17], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[10],_testData[18], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[11],_testData[19], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[12],_testData[20], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[13],_testData[21], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[14],_testData[22], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[15],_testData[23], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[16],_testData[24], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[17],_testData[25], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[18],_testData[26], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[19],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[20],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[21],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[22],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[23],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[24],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[25],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd3e1m m
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
FROM public.guiduuidmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD3E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD3E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD3E1M>();
                 ((IGuidMArrayuuidMMArrayD3)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.guiduuidmmarrayd3e1m m
LEFT JOIN public.guiduuidmmarrayd3e1mi mi ON mi.id = m.guiduuidmmarrayd3e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3)),
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
                var models = await((IGuidMArrayuuidMMArrayD3)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD3)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        GuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[13], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[1],_testData[14], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[2],_testData[15], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[3],_testData[16], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[4],_testData[17], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[5],_testData[18], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[6],_testData[19], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[7],_testData[20], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[8],_testData[21], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[9],_testData[22], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[10],_testData[23], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[11],_testData[24], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[12],_testData[25], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[13],_testData[26], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[14],_testData[27], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[15],_testData[28], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[16],_testData[29], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[17],_testData[30], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[18],_testData[31], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[19],_testData[32], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[20],_testData[33], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        GuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[28], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[1],_testData[29], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[2],_testData[30], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[3],_testData[31], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[4],_testData[32], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[5],_testData[33], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[6],_testData[34], false);
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
                var models = ((IGuidMArrayuuidMMArrayD3)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD3)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        GuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[15], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[1],_testData[16], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[2],_testData[17], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[3],_testData[18], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[4],_testData[19], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[5],_testData[20], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[6],_testData[21], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[7],_testData[22], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[8],_testData[23], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[9],_testData[24], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[10],_testData[25], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[11],_testData[26], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[12],_testData[27], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[13],_testData[28], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[14],_testData[29], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[15],_testData[30], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[16],_testData[31], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[17],_testData[32], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[18],_testData[33], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        GuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[31], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[1],_testData[32], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[2],_testData[33], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD3E1M), typeof(FlatGuiduuidMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3)),
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
FROM public.guiduuidmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD3E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD3E1M>();
                await((IGuidMArrayuuidMMArrayD3)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd3e1m m
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
FROM public.guiduuidmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD3E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD3E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD3E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD3E1M>();
                await ((IGuidMArrayuuidMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 110, query1, 62, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.guiduuidmmarrayd3e1m m
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
FROM public.guiduuidmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD3E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD3E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD3E1M>();
                await ((IGuidMArrayuuidMMArrayD3)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 19, query1, 84, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[17],_testData[34], false);
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
FROM public.guiduuidmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD3E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD3E1M>();
                ((IGuidMArrayuuidMMArrayD3)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd3e1m m
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
FROM public.guiduuidmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD3E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD3E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD3E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD3E1M>();
                 ((IGuidMArrayuuidMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 155, query1, 155, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.guiduuidmmarrayd3e1m m
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
FROM public.guiduuidmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD3E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD3E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD3E1M>();
                 ((IGuidMArrayuuidMMArrayD3)this).DbConnectionMMDynQuerySelectModelBatch(connection, 7, query1, 160, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[2],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3)),
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
FROM public.guiduuidmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidMArrayuuidMMArrayD3)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd3e1m m
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
FROM public.guiduuidmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD3)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 20, query1, 19, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[4], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[1],_testData[5], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[2],_testData[6], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[3],_testData[7], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[4],_testData[8], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[5],_testData[9], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[6],_testData[10], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[7],_testData[11], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[8],_testData[12], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[9],_testData[13], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[10],_testData[14], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[11],_testData[15], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[12],_testData[16], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[13],_testData[17], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[14],_testData[18], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[15],_testData[19], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[16],_testData[20], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[17],_testData[21], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[18],_testData[22], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[19],_testData[23], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[20],_testData[24], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[21],_testData[25], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[22],_testData[26], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[23],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[24],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[25],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[26],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[27],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[28],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[29],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[3], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[1],_testData[4], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[2],_testData[5], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[3],_testData[6], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[4],_testData[7], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[5],_testData[8], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[6],_testData[9], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[7],_testData[10], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[8],_testData[11], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[9],_testData[12], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[10],_testData[13], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[11],_testData[14], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[12],_testData[15], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[13],_testData[16], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[14],_testData[17], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[15],_testData[18], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[16],_testData[19], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[17],_testData[20], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[18],_testData[21], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[19],_testData[22], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[20],_testData[23], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[21],_testData[24], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[22],_testData[25], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[23],_testData[26], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[24],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[25],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[26],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[27],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[28],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[29],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[30],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[31],_testData[34], false);
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
FROM public.guiduuidmmarrayd3e1m m
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
FROM public.guiduuidmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD3E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD3E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD3E1M>();
                await ((IGuidMArrayuuidMMArrayD3)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 119, query1, 139, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.guiduuidmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidMArrayuuidMMArrayD3)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd3e1m m
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
FROM public.guiduuidmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD3)this).DbConnectionSTDynQuerySelectModelBatch(connection, 124, query1, 62, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[24], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[1],_testData[25], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[2],_testData[26], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[3],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[4],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[5],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[6],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[7],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[8],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[9],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[12], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[1],_testData[13], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[2],_testData[14], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[3],_testData[15], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[4],_testData[16], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[5],_testData[17], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[6],_testData[18], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[7],_testData[19], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[8],_testData[20], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[9],_testData[21], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[10],_testData[22], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[11],_testData[23], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[12],_testData[24], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[13],_testData[25], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[14],_testData[26], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[15],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[16],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[17],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[18],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[19],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[20],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[21],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(models[22],_testData[34], false);
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
FROM public.guiduuidmmarrayd3e1m m
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
FROM public.guiduuidmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD3E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD3E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD3E1M>();
                 ((IGuidMArrayuuidMMArrayD3)this).DbConnectionDynQuerySelectModelBatch(connection, 69, query1, 37, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatGuiduuidMMArrayD3E1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.guiduuidmmarrayd3e1m m
LEFT JOIN public.guiduuidmmarrayd3e1mi mi ON mi.id = m.guiduuidmmarrayd3e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3)),
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
                var models = await((IGuidMArrayuuidMMArrayD3)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD3)this).DbConnectionSTSelectModelBatchAsync(connection, 49, 15))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        GuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[10], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[1],_testData[11], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[2],_testData[12], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[3],_testData[13], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[4],_testData[14], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[5],_testData[15], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[6],_testData[16], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[7],_testData[17], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[8],_testData[18], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[9],_testData[19], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[10],_testData[20], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[11],_testData[21], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[12],_testData[22], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[13],_testData[23], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[14],_testData[24], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[15],_testData[25], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[16],_testData[26], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[17],_testData[27], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[18],_testData[28], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[19],_testData[29], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[20],_testData[30], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[21],_testData[31], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[22],_testData[32], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[23],_testData[33], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        GuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[2], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[1],_testData[3], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[2],_testData[4], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[3],_testData[5], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[4],_testData[6], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[5],_testData[7], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[6],_testData[8], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[7],_testData[9], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[8],_testData[10], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[9],_testData[11], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[10],_testData[12], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[11],_testData[13], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[12],_testData[14], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[13],_testData[15], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[14],_testData[16], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[15],_testData[17], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[16],_testData[18], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[17],_testData[19], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[18],_testData[20], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[19],_testData[21], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[20],_testData[22], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[21],_testData[23], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[22],_testData[24], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[23],_testData[25], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[24],_testData[26], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[25],_testData[27], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[26],_testData[28], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[27],_testData[29], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[28],_testData[30], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[29],_testData[31], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[30],_testData[32], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[31],_testData[33], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[32],_testData[34], false);
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
                var models = ((IGuidMArrayuuidMMArrayD3)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD3)this).DbConnectionSTSelectModelBatch(connection, 31, 128))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        GuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[7], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[1],_testData[8], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[2],_testData[9], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[3],_testData[10], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[4],_testData[11], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[5],_testData[12], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[6],_testData[13], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[7],_testData[14], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[8],_testData[15], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[9],_testData[16], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[10],_testData[17], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[11],_testData[18], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[12],_testData[19], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[13],_testData[20], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[14],_testData[21], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[15],_testData[22], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[16],_testData[23], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[17],_testData[24], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[18],_testData[25], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[19],_testData[26], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[20],_testData[27], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[21],_testData[28], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[22],_testData[29], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[23],_testData[30], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[24],_testData[31], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[25],_testData[32], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[26],_testData[33], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        GuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[25], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[1],_testData[26], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[2],_testData[27], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[3],_testData[28], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[4],_testData[29], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[5],_testData[30], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[6],_testData[31], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[7],_testData[32], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[8],_testData[33], false);
                        GuiduuidMMArrayD3E1M.AssertModel(models[9],_testData[34], false);
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
                await using var cmd = await ((IGuidMArrayuuidMMArrayD3)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidMArrayuuidMMArrayD3)this).SetDbConnectionSelectModelParametrs(cmd, 83);
                var models = await ((IGuidMArrayuuidMMArrayD3)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(19));

                GuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[16], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[1],_testData[17], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[2],_testData[18], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[3],_testData[19], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[4],_testData[20], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[5],_testData[21], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[6],_testData[22], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[7],_testData[23], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[8],_testData[24], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[9],_testData[25], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[10],_testData[26], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[11],_testData[27], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[12],_testData[28], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[13],_testData[29], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[14],_testData[30], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[15],_testData[31], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[16],_testData[32], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[17],_testData[33], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidMArrayuuidMMArrayD3)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidMArrayuuidMMArrayD3)this).SetDbConnectionSelectModelParametrs(cmd, 30);
                var models =  ((IGuidMArrayuuidMMArrayD3)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));

                GuiduuidMMArrayD3E1M.AssertModel(models[0],_testData[6], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[1],_testData[7], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[2],_testData[8], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[3],_testData[9], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[4],_testData[10], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[5],_testData[11], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[6],_testData[12], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[7],_testData[13], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[8],_testData[14], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[9],_testData[15], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[10],_testData[16], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[11],_testData[17], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[12],_testData[18], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[13],_testData[19], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[14],_testData[20], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[15],_testData[21], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[16],_testData[22], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[17],_testData[23], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[18],_testData[24], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[19],_testData[25], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[20],_testData[26], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[21],_testData[27], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[22],_testData[28], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[23],_testData[29], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[24],_testData[30], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[25],_testData[31], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[26],_testData[32], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[27],_testData[33], false);
                GuiduuidMMArrayD3E1M.AssertModel(models[28],_testData[34], false);
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
FROM public.binary_guiduuidmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD3E1MIWA),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD3E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMMArrayD3)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidMArrayuuidMMArrayD3)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD3E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMMArrayD3)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidMArrayuuidMMArrayD3)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD3E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD3E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMMArrayD3)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidMArrayuuidMMArrayD3)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD3E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMMArrayD3)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidMArrayuuidMMArrayD3)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmmarrayd3e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD3E1MI),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD3E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidMArrayuuidMMArrayD3)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMMArrayD3)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD3E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD3E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidMArrayuuidMMArrayD3)this).WAImportModelInner(connection, importCollection);
                var models = ((IGuidMArrayuuidMMArrayD3)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD3E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD3E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD3E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMMArrayD3)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMMArrayD3)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD3E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMMArrayD3)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidMArrayuuidMMArrayD3)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD3E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmmarrayd3e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
guiduuidmmarrayd3e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(GuiduuidMMArrayD3E1M),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3))]
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
FROM public.binary_guiduuidmmarrayd3e1m m
LEFT JOIN public.binary_guiduuidmmarrayd3e1mi mi ON mi.id = m.guiduuidmmarrayd3e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD3E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IGuidMArrayuuidMMArrayD3)this).ImportModelAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMMArrayD3)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidMMArrayD3E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD3E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IGuidMArrayuuidMMArrayD3)this).ImportModel(connection, importCollection);
                var models = ((IGuidMArrayuuidMMArrayD3)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidMMArrayD3E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmmarrayd3e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    guiduuidmmarrayd3e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3)),
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
                var models =  ((IGuidMArrayuuidMMArrayD3)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidMMArrayD3E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidMArrayuuidMMArrayD3)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidMMArrayD3E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD3E1MIWA), typeof(GuiduuidMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3)),
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
                var models1 = new List<GuiduuidMMArrayD3E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD3E1MIWA>();
                await ((IGuidMArrayuuidMMArrayD3)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD3E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD3E1MIWA>();
                ((IGuidMArrayuuidMMArrayD3)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3)),
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
                var models = await ((IGuidMArrayuuidMMArrayD3)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidmmarrayd3e1mi
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
                    GuiduuidMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD3)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_guiduuidmmarrayd3e1mi
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
                    GuiduuidMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD3E1MIWA), typeof(GuiduuidMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3))]
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
                var models1 = new List<GuiduuidMMArrayD3E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD3E1MIWA>();
                await ((IGuidMArrayuuidMMArrayD3)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD3E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD3E1MIWA>();
                ((IGuidMArrayuuidMMArrayD3)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3))]
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
                var models = await ((IGuidMArrayuuidMMArrayD3)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidmmarrayd3e1mi
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
                    GuiduuidMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD3)this).DynQueryExportModelInner(connection, @"
COPY public.binary_guiduuidmmarrayd3e1mi
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
                    GuiduuidMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD3E1MI), typeof(GuiduuidMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3)),
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
                var models1 = new List<GuiduuidMMArrayD3E1MI>();
                var models2 = new List<GuiduuidMMArrayD3E1MI>();
                await ((IGuidMArrayuuidMMArrayD3)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD3E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD3E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD3E1MI>();
                var models2 = new List<GuiduuidMMArrayD3E1MI>();
                ((IGuidMArrayuuidMMArrayD3)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD3E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD3E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmmarrayd3e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3)),
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
                var models = await ((IGuidMArrayuuidMMArrayD3)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD3E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD3)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD3E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD3E1MIWA), typeof(GuiduuidMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3))]
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
                var models1 = new List<GuiduuidMMArrayD3E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD3E1MIWA>();
                await ((IGuidMArrayuuidMMArrayD3)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD3E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD3E1MIWA>();
                ((IGuidMArrayuuidMMArrayD3)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmmarrayd3e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD3))]
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
                var models = await ((IGuidMArrayuuidMMArrayD3)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD3)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

