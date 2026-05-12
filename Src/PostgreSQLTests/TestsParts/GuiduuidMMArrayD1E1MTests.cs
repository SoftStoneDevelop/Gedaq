

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

        private readonly GuiduuidMMArrayD1E1M[] _testData = new GuiduuidMMArrayD1E1M[]
        {
            new GuiduuidMMArrayD1E1M
{
    Id = 1,
    Value = 
new System.Guid[3]
{
Guid.Parse("f1d6b00b-a72b-42d7-a118-96571949aa0e"),
Guid.Parse("2e9bc31f-b84f-49f1-9eec-cea1ca865f21"),
Guid.Parse("e0785803-b8eb-4908-97b1-d35712262543"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("5c1c537c-2cc3-4b8f-a190-b8d992a6bdcb"),
Guid.Parse("dff96a10-991f-4716-a22d-56b280f5d82c"),
Guid.Parse("b49f9b4e-547e-4423-92d8-52a4f78a5040"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 2,
    Value = 
new System.Guid[3]
{
Guid.Parse("2bc760a7-cc7a-4717-9835-5408d191969b"),
Guid.Parse("13c85d8e-5287-49c3-aa79-f8d28b147f96"),
Guid.Parse("655ed95f-3195-4174-a7d7-3c8e128d0bcb"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 4,
    Value = 
new System.Guid[3]
{
Guid.Parse("441d290c-1fd1-4779-8051-768a501e25ef"),
Guid.Parse("be4d39cc-4e4c-459f-8b97-7b4cc92fc2bc"),
Guid.Parse("6a843e03-e0b1-457a-8619-f24de594dbc7"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 5,
    Value = 
new System.Guid[4]
{
Guid.Parse("95981005-d89e-4955-a5e3-b5a203132260"),
Guid.Parse("d9bd8a49-c32a-496b-8b9c-0252c9726a9b"),
Guid.Parse("07f9116d-410b-4a01-9373-3ac61c6ff97e"),
Guid.Parse("fa536b60-20b2-42f4-b738-42c9d1a4391b"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 9,
    Value = 
new System.Guid[3]
{
Guid.Parse("90cadfe4-15fb-4fd4-a075-2145b6272aec"),
Guid.Parse("26b80a22-b402-414d-b45a-135d1f9c112f"),
Guid.Parse("943fe9b4-11b7-483c-b71c-88a2c0c9c03e"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 5,
    Value = 
new System.Guid[4]
{
Guid.Parse("a00d7a68-2dfb-42f1-9ef6-5011cbe6217c"),
Guid.Parse("ba5be4cd-653e-4525-b88c-3e2e4d7d4879"),
Guid.Parse("8f7ae92c-ab2b-4640-ad9b-18339f846fde"),
Guid.Parse("c79263fa-2e1e-4aa4-b1b5-24b9af14053b"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 15,
    Value = 
new System.Guid[4]
{
Guid.Parse("ed1a1d1e-13bb-4b2a-9cb9-d2960afd7f0a"),
Guid.Parse("43b0c2a8-a36b-4a52-a7f6-3f08e8efc614"),
Guid.Parse("2a0b2b37-321a-41d5-824b-44f6e9f168f1"),
Guid.Parse("1886814d-f86e-4f02-aab8-927dbba70ae6"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 21,
    Value = 
new System.Guid[4]
{
Guid.Parse("27b5441a-9eb1-4bf7-81ec-163a50cf8ea4"),
Guid.Parse("1332d31d-ef58-4ac7-a284-839f741f46fd"),
Guid.Parse("a673b477-2f2a-44e1-855e-9dc2318214ed"),
Guid.Parse("e8dfb7cd-f726-42fc-8d87-0fd011fd39c9"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 13,
    Value = 
new System.Guid[3]
{
Guid.Parse("ec06dd2c-592e-4aeb-b5be-2d3ac877bde1"),
Guid.Parse("9ce17d94-488c-40d5-987d-f36483654035"),
Guid.Parse("870a55d3-abf4-474b-9402-69a503d0e209"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 29,
    Value = 
new System.Guid[3]
{
Guid.Parse("2e5b589b-16f3-4dcb-b2a3-52e920de6abd"),
Guid.Parse("59d8ddfe-890e-4872-a895-658293869b1c"),
Guid.Parse("300cab6d-53cc-4e9e-a31d-1dee0e12f66d"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 37,
    Value = 
new System.Guid[3]
{
Guid.Parse("576e5a00-6418-4f05-bcd6-7b9fb2ebc339"),
Guid.Parse("701087dd-8499-45a7-9063-fed689b8111d"),
Guid.Parse("c7e1f12e-2354-46f1-b10c-7aac376b4a57"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 18,
    Value = 
new System.Guid[4]
{
Guid.Parse("16935bae-7d3a-4cb9-bfd1-425096247c24"),
Guid.Parse("a5ef9421-8343-47f4-922d-e6668c2114dd"),
Guid.Parse("1bb36a9f-b900-48e3-abf4-4ae5a1bb2a41"),
Guid.Parse("82333f43-81e2-4ddb-8de0-bb175d6124cd"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("3450f1d7-a802-46a2-81eb-b928415995b0"),
Guid.Parse("6c950766-2dfa-4518-af11-42c3782b4549"),
Guid.Parse("9766409f-1e7b-432f-8ac4-80c73bf81fc3"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("cbc73764-6393-470f-8b5b-fe2a353ef7fb"),
Guid.Parse("2a13c6ef-3818-4921-b7ff-e9d6120638f7"),
Guid.Parse("4861ed3e-790f-403d-80b3-c975d62a5999"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 41,
    Value = 
new System.Guid[4]
{
Guid.Parse("94c522af-60ae-4e7b-a0ca-caaa01b51778"),
Guid.Parse("818fe25b-c4b8-4630-a3ac-52eee71f91c8"),
Guid.Parse("578773df-1806-4a26-b787-7026005b18a0"),
Guid.Parse("58ccd627-476d-4b5f-a9fc-f4d85ecd9d1f"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 49,
    Value = 
new System.Guid[3]
{
Guid.Parse("17ef0a10-90cb-4861-ae96-9efae588256a"),
Guid.Parse("6e9893bf-2039-45df-9dc0-1f1701f53506"),
Guid.Parse("d8c20310-bcc3-4229-b5c4-18f6a334d206"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 26,
    Value = 
new System.Guid[4]
{
Guid.Parse("b2370327-47ec-4b1d-bc0d-9ff403cfc7cc"),
Guid.Parse("0672f982-fdb6-4d03-8e22-682dcc32df7a"),
Guid.Parse("6097a5bf-fbc7-46d1-8d03-32cee3cca479"),
Guid.Parse("b562e93f-3da4-4614-aae0-b0fa490bb303"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("8d29b09f-e11a-44df-a554-92154bfbf129"),
Guid.Parse("2e52d4c3-71b1-4a27-bce8-151acba6a3cf"),
Guid.Parse("95c58f1f-3c5d-4a06-866a-c74ff632c4e4"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("13808ba7-e567-48ee-93de-93ef35418275"),
Guid.Parse("f75c7370-d489-432b-af7e-dffb9e9e6c4a"),
Guid.Parse("6eb03ebf-f0f1-4a90-90ae-39c115d717d9"),
Guid.Parse("31d08ccb-5744-4131-af57-f9927641e8d2"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 52,
    Value = 
new System.Guid[4]
{
Guid.Parse("c1c6b77a-a080-4892-9f12-79400c696c06"),
Guid.Parse("2583b782-d72a-433f-a34d-807386d8a52f"),
Guid.Parse("bc024ce4-15a5-4aac-8bc5-b686a73434cb"),
Guid.Parse("e0662de5-dcb8-44d6-a960-d3c6cedbbe5e"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 60,
    Value = 
new System.Guid[4]
{
Guid.Parse("f6b4df6a-5b17-4460-a15e-7f596b4655d6"),
Guid.Parse("161051e6-75ed-4a20-819a-f44eacdefd9a"),
Guid.Parse("9b90d831-adab-4f08-97d2-2e1984e7cb11"),
Guid.Parse("fc8d8aa9-b3b4-4826-b3d0-b9e2b77dfd3b"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 28,
    Value = 
new System.Guid[4]
{
Guid.Parse("dde86bd6-3d8e-4cbd-9a0a-b0b231baa3f0"),
Guid.Parse("5b86b785-94ef-4e3c-a321-9426f536c43d"),
Guid.Parse("e0aaba3a-8403-439a-b591-58304011eb66"),
Guid.Parse("8d91a8dd-c1ee-4167-8fff-852d3a70c92b"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("68581818-f242-4281-94b3-06e6afeb7349"),
Guid.Parse("3f65b0d1-82a5-4b91-9c97-4877d4667563"),
Guid.Parse("456ba32f-5356-4b54-a7cb-d957a695ee46"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("70bef125-f3ea-4295-96ba-a778d296c92e"),
Guid.Parse("4af2cdfa-8fd8-4515-b769-51ca472ca342"),
Guid.Parse("37468508-0bc1-4cdf-9df0-cbbd1a3206b7"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 62,
    Value = 
new System.Guid[4]
{
Guid.Parse("a2cdaa96-7494-4c85-b98a-9fe752277dc1"),
Guid.Parse("e1384d0c-2d79-4207-8bd7-a730cf2f91bb"),
Guid.Parse("89dbc457-71fd-44ed-99a5-cb7fba81bc74"),
Guid.Parse("b09de256-f4f4-4bd7-8558-356e8b92935a"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("26b1a2f8-dfa4-4ae3-8089-ac02e584d00a"),
Guid.Parse("8201b07c-6da0-4eb9-a4d9-4f46538fdf4a"),
Guid.Parse("55818c23-bd3f-4f70-91bf-92dcdcda9944"),
Guid.Parse("410db0f5-32d1-46dd-97b2-1ae5c375b658"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 67,
    Value = 
new System.Guid[4]
{
Guid.Parse("6f6ca517-6697-4d59-a262-a706252719fb"),
Guid.Parse("54b49bdb-53f6-4b7a-a24e-07e6957ccf7f"),
Guid.Parse("2b139556-a801-401b-9388-df7be1b61aa9"),
Guid.Parse("8b58d1f9-0671-4b05-a84b-a808c4141542"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 29,
    Value = 
new System.Guid[4]
{
Guid.Parse("d657ab21-d1a8-48d6-b03d-c3a80dbd9766"),
Guid.Parse("79d38c1c-b4a0-4196-a217-c4e3b8a07704"),
Guid.Parse("9a7a1aa5-3aa6-430f-b78d-99ca19da94a3"),
Guid.Parse("847b2379-2aeb-484f-a238-f3af5701d5f4"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 68,
    Value = 
new System.Guid[3]
{
Guid.Parse("1708c535-0e9d-4e3a-81d6-52c4e14df816"),
Guid.Parse("fcf6c088-8ac7-4a66-9908-d3ba47938632"),
Guid.Parse("1c7df838-e37c-46a7-8516-2c6d603a299c"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 73,
    Value = 
new System.Guid[3]
{
Guid.Parse("f76c953f-d853-4f5d-9882-09c8f027d43a"),
Guid.Parse("a73e56aa-1807-4166-b57d-0e82c948467e"),
Guid.Parse("291a4bfc-0fd0-499c-8a83-8767cfdcda16"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 35,
    Value = 
new System.Guid[4]
{
Guid.Parse("c96afc89-6ad5-4d4f-b660-36037b7a8d98"),
Guid.Parse("4e7c456f-aee1-4865-bfd7-c048dc100032"),
Guid.Parse("b9afcef6-4fd0-44b9-b184-6ee752d852b5"),
Guid.Parse("7a15d819-50e2-4e20-b887-5c4d880b4af0"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 78,
    Value = 
new System.Guid[4]
{
Guid.Parse("8fa7fe10-bd09-45a2-a9d5-89029a9e81ea"),
Guid.Parse("1c0298d1-0201-4d5c-9ccc-9c4a4cd3a464"),
Guid.Parse("8c9f2a35-80d6-4993-944c-92bfcf22ded9"),
Guid.Parse("75be905c-0b06-4bf9-af6a-eef430909493"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 83,
    Value = 
new System.Guid[4]
{
Guid.Parse("4c1d8476-1021-4cc6-b383-75c8843cb294"),
Guid.Parse("24615b5f-e84f-486c-af5e-0215f8715846"),
Guid.Parse("a5b7da0e-2241-41f1-9cc6-24be42852747"),
Guid.Parse("7d2bff67-ecd1-492d-91d6-0b80971e86a7"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 40,
    Value = 
new System.Guid[3]
{
Guid.Parse("b741bb4a-8faf-41d5-aa6d-e64802bef5d4"),
Guid.Parse("61083f07-9ef4-4e16-a8d0-33a1759b3398"),
Guid.Parse("2bb56e40-45ee-479c-ab0e-47957ee6fdd0"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("8a562135-e2d4-44c8-914f-4577d252dccb"),
Guid.Parse("6a925553-2c16-4063-9ef3-8a1a8f4b2975"),
Guid.Parse("ea8abe32-b6e4-42b4-ac96-34c88dae7f43"),
Guid.Parse("1a3848f2-a7f0-410e-85a1-46a05d806c06"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 85,
    Value = 
new System.Guid[4]
{
Guid.Parse("cb7da466-bedf-4877-97af-d0db1d6a9ea0"),
Guid.Parse("d5a56475-eb9d-47ed-a355-e1198236d556"),
Guid.Parse("d6451425-a2b4-4f70-8940-b04f0693138f"),
Guid.Parse("ece60350-e6a5-4d6e-9c7f-16d7184f819b"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 92,
    Value = 
new System.Guid[4]
{
Guid.Parse("9563b207-fcdd-4ac2-ad98-df90f2842a38"),
Guid.Parse("e45f99c9-3672-4488-bc5d-096c5087d541"),
Guid.Parse("eae4d210-8cf6-4868-bf6b-36209e637055"),
Guid.Parse("fcd36146-9d17-4fbb-b53c-1222edf75c3e"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 46,
    Value = 
new System.Guid[3]
{
Guid.Parse("5c4c4b86-85b9-4232-b591-5cd66add4ef6"),
Guid.Parse("43920d0b-2168-463f-ab21-7d37b181555c"),
Guid.Parse("c21a5a66-218f-42ba-8648-379eee01e350"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("a75ebb19-240f-4aa2-a847-3b92909cc5e7"),
Guid.Parse("6963e147-be66-4d33-86ec-0d8a63f318c4"),
Guid.Parse("566b6943-c629-49b7-8a01-5a234b9a35ab"),
Guid.Parse("451c95ba-956e-47f6-bd46-809099efe6ca"),
},
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 100,
    Value = 
new System.Guid[4]
{
Guid.Parse("4c7466be-a0bb-4666-93c9-0a5b2198e927"),
Guid.Parse("d69321da-c7ba-45c2-9f3f-44b2f61d2d36"),
Guid.Parse("95c35e26-84d6-43c1-8c98-13c59604d683"),
Guid.Parse("8561253c-b476-4c2a-9f2d-316b8b64c645"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 108,
    Value = 
new System.Guid[3]
{
Guid.Parse("c628e0ef-4681-4608-b6bc-c5ee693844af"),
Guid.Parse("ae4aa749-0242-4ff9-9beb-a8b34d7eb536"),
Guid.Parse("7cd96916-c402-4a8f-9bfb-80fd8fc259e8"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 53,
    Value = 
new System.Guid[4]
{
Guid.Parse("e3ea77d8-65aa-4852-b553-0de77c840e08"),
Guid.Parse("a92e5c79-04e1-4306-9a81-97cad5074fdd"),
Guid.Parse("eb576056-c628-44d5-87ac-7f9a289d9210"),
Guid.Parse("1c553bcf-2423-4da3-9053-fafee999b503"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("52f43287-b573-4dc0-b2b9-c9ac412cfa7a"),
Guid.Parse("80d632b1-07ab-4b20-8965-934e12c51dbf"),
Guid.Parse("11633d0e-6225-481e-8200-424947d953b2"),
Guid.Parse("7f11efb0-d15c-4153-96e0-d227b0c71285"),
},
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 115,
    Value = 
new System.Guid[3]
{
Guid.Parse("502b08b6-1a18-4b9c-8f62-a3b6332a7c2b"),
Guid.Parse("0950bb1d-52ef-43c6-886c-8cd7f3691601"),
Guid.Parse("1ee87285-3c15-4325-94b4-4ea3b53b548a"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("843ea7f2-115b-4ee0-8c46-2fffde963e65"),
Guid.Parse("8b6fcec9-ccce-471c-b98f-fe68198c5522"),
Guid.Parse("c9d316ec-2104-425e-9726-a6e22c130d32"),
Guid.Parse("6703fc5c-f97c-4267-a314-2ae9a99c1169"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 121,
    Value = 
new System.Guid[3]
{
Guid.Parse("518eaa37-8d0c-48c4-aefd-c5334cf6e113"),
Guid.Parse("628e5c5c-4937-477d-8065-a944e2e1862c"),
Guid.Parse("c1c93cba-0dd0-4909-bf73-62a64d074ffc"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 55,
    Value = 
new System.Guid[4]
{
Guid.Parse("f7b9f7ce-d59b-46c1-8909-e53f27178de1"),
Guid.Parse("e621d059-6211-4623-b381-fdba274c1c21"),
Guid.Parse("47609259-00f9-4b66-ae79-6f8ca900d48c"),
Guid.Parse("2d486e40-f0c4-4ad8-a9ef-f22ac5cac122"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("ba9b376c-4c9d-478c-b137-4780a30d63b0"),
Guid.Parse("3556c5c1-4269-4544-8456-ef6fe64ddf2e"),
Guid.Parse("14bcde5c-c63b-4548-8a37-c5b50791d440"),
Guid.Parse("cf045646-68e0-4b3a-93a0-01f7a4077224"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 127,
    Value = 
new System.Guid[3]
{
Guid.Parse("af6f4a5d-c123-41e7-9b71-a4fa531ee0ef"),
Guid.Parse("d9c121ad-0cd0-4265-ba20-3c89cc0a91c3"),
Guid.Parse("cf59f7db-0181-4815-8018-461a3d38ca9f"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("c4e90042-4522-4c46-bcba-90ef3203428c"),
Guid.Parse("e6a7746e-b509-415b-b7a6-0520190abd62"),
Guid.Parse("42f16d2a-87e9-4b42-9c7a-60e746da90e6"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 133,
    Value = 
new System.Guid[3]
{
Guid.Parse("5e863774-ced5-42c5-be20-e67840ee7d50"),
Guid.Parse("3b07f2a8-3e96-4120-a4d3-1c1faccb5032"),
Guid.Parse("a0a7649d-57a7-4cb5-94cb-09a72f1c7104"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 58,
    Value = 
new System.Guid[4]
{
Guid.Parse("7d5869d7-c0bd-48f3-9c95-f33f736bd854"),
Guid.Parse("43bab493-7c1f-4b64-8f4f-1bb5b1581b0b"),
Guid.Parse("7bf42172-b05c-4f2f-82c4-836b2f030e68"),
Guid.Parse("156f37b1-9ddd-4afe-8da5-0779637aa6c2"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("3a3e9372-4c37-4f6d-ac89-7cb03aca67c3"),
Guid.Parse("2005df48-68ed-49d9-8375-14c5bb7a64f9"),
Guid.Parse("c68bd27d-457a-4f29-aac3-8762aa992d9e"),
Guid.Parse("d2859957-1f7d-4734-9356-d373a134d85c"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 142,
    Value = 
new System.Guid[3]
{
Guid.Parse("7e88de4a-a727-4fe0-949b-1ad6545183c8"),
Guid.Parse("bb1fdb07-521c-4e03-84e8-51d7490eb8c8"),
Guid.Parse("74049e4a-0ca9-4bbb-bd1a-580da174a184"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 143,
    Value = 
new System.Guid[3]
{
Guid.Parse("eaed81d1-bb41-4864-a589-efc82789231c"),
Guid.Parse("8cb5f87a-d172-41aa-83a5-1728b9d3c146"),
Guid.Parse("809a4b70-167c-43e6-b6e8-ff47fe24b1b0"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 63,
    Value = 
new System.Guid[4]
{
Guid.Parse("fb2ceb1c-b1b5-4499-a840-4c64e459f147"),
Guid.Parse("8f5ef25f-436e-4703-b31f-b7ebd3dc805c"),
Guid.Parse("d7fef502-eb4e-4450-a5e1-77b2f59fe0c2"),
Guid.Parse("566146ee-dc23-4dca-b748-c96d8db5dda2"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 144,
    Value = 
new System.Guid[4]
{
Guid.Parse("c259b803-3ce4-454f-876c-0598e34e7fc4"),
Guid.Parse("018cc485-f88a-43f2-a874-b1f3efe6d7ea"),
Guid.Parse("ada36a3d-993c-4672-8174-156748cb3463"),
Guid.Parse("a8533a89-70d7-4d16-bdb0-9a50d67216cb"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 153,
    Value = 
new System.Guid[3]
{
Guid.Parse("cf3f33f5-0012-46f3-af11-c4e82db412fc"),
Guid.Parse("35d85cf1-432e-4c1c-a9da-24668da4f3e9"),
Guid.Parse("db7e157a-b7fa-4724-860a-e0191f617908"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 67,
    Value = 
new System.Guid[3]
{
Guid.Parse("44f23ce1-a1d8-4e15-a907-3c564b3e206e"),
Guid.Parse("caa8665b-3717-4d8f-bd67-a12acbfd5cc7"),
Guid.Parse("41a850a6-593e-4ea7-8228-bf9b4a8060fc"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 155,
    Value = 
new System.Guid[4]
{
Guid.Parse("451ab24f-e40d-4048-aa59-7fea24ee8321"),
Guid.Parse("0c8fbbdc-10af-493b-bd66-3f1d26b58492"),
Guid.Parse("20285990-6e30-43d2-82ca-8e04139a106f"),
Guid.Parse("66f83758-a072-4ef9-88bd-1518256f12a7"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("aeea0e94-dc22-4a81-898f-dccf11144b5f"),
Guid.Parse("bea0e336-e713-47ee-8e8b-c5c5f6abfc7b"),
Guid.Parse("bb2a3cbb-3ab6-4a34-a3d3-560b9c1e8415"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 156,
    Value = 
new System.Guid[4]
{
Guid.Parse("6b248602-79dc-40ff-a9c7-48b4e3a4dda7"),
Guid.Parse("8440ffa1-fe1f-43d4-a406-2d02533f0eb8"),
Guid.Parse("f138c154-a637-43ee-8374-bd5f4528a500"),
Guid.Parse("9ece166d-eec6-4070-84d0-792cbc7db32c"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 73,
    Value = 
new System.Guid[4]
{
Guid.Parse("fcdf2cd4-6b25-4135-a8f2-d248c32b0ce2"),
Guid.Parse("c1a07ff9-4ba5-4532-916b-3c1db3530467"),
Guid.Parse("ea04a3b8-a457-4172-8f27-210cd2dfa49d"),
Guid.Parse("af3f410c-200e-41f3-9e0b-017dbbe2bdb7"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("a2b660e8-fd74-4534-892b-800ce618863f"),
Guid.Parse("2714b788-38a4-4292-a182-41306c3f33bd"),
Guid.Parse("72f613c0-ffea-41b9-a4e5-1be06c18d20e"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 164,
    Value = 
new System.Guid[3]
{
Guid.Parse("4552fc6e-f450-42df-b010-ecc0114d32c4"),
Guid.Parse("aae5c2f9-ba75-4a6b-885a-35ad0b5864ca"),
Guid.Parse("ef90dfdc-ae73-46ba-b35d-21753419c5d3"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("e43b1aef-e7cd-46b7-9c0b-aaea59b3456c"),
Guid.Parse("fac684f6-4617-4478-ad05-247c6de8050b"),
Guid.Parse("5fc04d0d-d737-43d6-8934-79715e267013"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 169,
    Value = 
new System.Guid[3]
{
Guid.Parse("db7871ce-eb50-4347-9711-e8c941214adb"),
Guid.Parse("b158631b-c765-4501-bd02-374f1cfa3d8a"),
Guid.Parse("7af82011-b5e5-4eaf-886a-01053c42c5ed"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 74,
    Value = 
new System.Guid[3]
{
Guid.Parse("30d2b842-ab8d-4dea-985a-068deeac91c3"),
Guid.Parse("359c2c3f-5b62-4325-98a4-0962bf40af10"),
Guid.Parse("808dc263-18bc-4b98-bf7b-4859b99b5889"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 176,
    Value = 
new System.Guid[3]
{
Guid.Parse("7fbb9a10-49b8-48f7-9dd8-61b12f7c133c"),
Guid.Parse("b9edb2c0-e933-4a11-b8a6-fd9e8462e9da"),
Guid.Parse("a629d5b1-c65c-438a-be5e-2306799f8d5a"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("80cd7403-bb66-4606-b84c-86a563a8ecf7"),
Guid.Parse("4bb5f8b6-7357-44ac-99e0-8d6822c3a618"),
Guid.Parse("c806c404-07a2-4e14-9ee6-512894125860"),
Guid.Parse("08b772cb-105a-4461-9a15-eb413de9c317"),
},
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
INSERT INTO public.guiduuidmmarrayd1e1m(
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
INSERT INTO public.guiduuidmmarrayd1e1m(
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
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
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
Guid.Parse("cbc73764-6393-470f-8b5b-fe2a353ef7fb"),
Guid.Parse("2a13c6ef-3818-4921-b7ff-e9d6120638f7"),
Guid.Parse("4861ed3e-790f-403d-80b3-c975d62a5999"),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd1e1m(
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
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("13808ba7-e567-48ee-93de-93ef35418275"),
Guid.Parse("f75c7370-d489-432b-af7e-dffb9e9e6c4a"),
Guid.Parse("6eb03ebf-f0f1-4a90-90ae-39c115d717d9"),
Guid.Parse("31d08ccb-5744-4131-af57-f9927641e8d2"),
}));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("70bef125-f3ea-4295-96ba-a778d296c92e"),
Guid.Parse("4af2cdfa-8fd8-4515-b769-51ca472ca342"),
Guid.Parse("37468508-0bc1-4cdf-9df0-cbbd1a3206b7"),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidMMArrayD1E1M> models = null;

                models =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidMMArrayD1E1M> models = null;

                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M), typeof(FlatGuiduuidMMArrayD1E1M)],
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
FROM public.guiduuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                ((IGuidMArrayuuidMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M)],
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
FROM public.guiduuidmmarrayd1e1m m
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
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
LEFT JOIN public.guiduuidmmarrayd1e1mi mi ON mi.id = m.guiduuidmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
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
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M), typeof(FlatGuiduuidMMArrayD1E1M)],
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
FROM public.guiduuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                ((IGuidMArrayuuidMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M)],
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
FROM public.guiduuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidMArrayuuidMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidMArrayuuidMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
LEFT JOIN public.guiduuidmmarrayd1e1mi mi ON mi.id = m.guiduuidmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
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
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M), typeof(FlatGuiduuidMMArrayD1E1M)],
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 164;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[27],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M)],
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
FROM public.guiduuidmmarrayd1e1m m
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
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
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
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[34], false);
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 164;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 1;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
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
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
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
                parametr2.Value = 29;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
LEFT JOIN public.guiduuidmmarrayd1e1mi mi ON mi.id = m.guiduuidmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
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
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[34], false);
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
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[3], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[4], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[5], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[6], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[7], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[8], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[9], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[10], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[11], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[12], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[13], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[14], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[15], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[16], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[17], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[18], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[19], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[20], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[21], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[22], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[23], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[24],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[25],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[26],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[27],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[28],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[29],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[30],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M), typeof(FlatGuiduuidMMArrayD1E1M)],
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 83, query1, 127, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 5, query1, 155, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 92, query1, 142, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 144, query1, 121, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M)],
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 143, query1, 68, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 153, query1, 127, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 1, query1, 83, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 121, query1, 2, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
LEFT JOIN public.guiduuidmmarrayd1e1mi mi ON mi.id = m.guiduuidmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
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
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 108, 29))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
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
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 143, 52))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
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
                ((IGuidMArrayuuidMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 83);
                var models = await ((IGuidMArrayuuidMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(17));

                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidMArrayuuidMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidMArrayuuidMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 21);
                var models =  ((IGuidMArrayuuidMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));

                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
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
COPY public.binary_guiduuidmmarrayd1e1m
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
            queryMapType: typeof(GuiduuidMMArrayD1E1M),
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
FROM public.binary_guiduuidmmarrayd1e1m m
LEFT JOIN public.binary_guiduuidmmarrayd1e1mi mi ON mi.id = m.guiduuidmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
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
                var importCollection = new List<GuiduuidMMArrayD1E1M>();
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
                    GuiduuidMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD1E1M>();
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
                    GuiduuidMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmmarrayd1e1m
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
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
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
                    GuiduuidMMArrayD1E1M.AssertModel(model, expectedModel, true);
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
                    GuiduuidMMArrayD1E1M.AssertModel(model, expectedModel, true);
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

