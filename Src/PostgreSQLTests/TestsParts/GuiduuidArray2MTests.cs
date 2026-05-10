

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
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a495c3d8-ee6b-4ae8-b6b2-062ff890d8d2"),

Guid.Parse("c84906fd-5e7a-4c36-8164-2422e772ee9f"),

Guid.Parse("adb289d6-6f94-4f2f-a02b-784cdff947be"),

Guid.Parse("49ecd07f-82cd-41d6-857c-ca1bfe792cfa"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f3f30740-5612-4a9c-be22-2f5baaf74e5f"),

Guid.Parse("4e275c82-84d7-493a-bc2f-709023504ace"),

Guid.Parse("8a9648e3-c8c0-45cc-af9e-5a5aae16772d"),

Guid.Parse("2e41cf2c-6174-4d5f-a8b7-ca7aeafe8a49"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("1839e967-9787-4ce0-9e24-88e0a8b446c2"),

Guid.Parse("fc874453-0ef3-4e04-b6ad-161fb966ab0c"),

Guid.Parse("175cdae9-e770-47b1-8fb2-b4a81520baf7"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f5282d6b-fec8-4551-809d-571d254b7b71"),

Guid.Parse("bd514189-1cbb-429c-b143-253d1849000d"),

Guid.Parse("a22ee20b-5347-4a4e-8ba2-be5062b40f50"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f88d3f00-8889-411b-8dc3-fb0a9ecffb09"),

Guid.Parse("82a3b6a5-c187-494e-9249-5433a5906ff0"),

Guid.Parse("04d18677-628b-4f1c-94da-d2ec183a58ae"),

},
},
            new GuiduuidArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1b00f202-2d33-4050-b981-1be6226dc66b"),

Guid.Parse("47710c44-346e-4ab3-ac33-818c4c52332b"),

Guid.Parse("bc50f3e9-ea6b-4242-863c-fcfb38047de8"),

Guid.Parse("1e5673f6-f7d1-41fb-a867-ec3763bda02a"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("9a24fc3e-c5fe-4f4e-97d5-7d116840a5f0"),

Guid.Parse("3845dcb4-f75a-466c-bd57-024302f67a03"),

Guid.Parse("3a9e5685-a369-4956-bc00-def95f4ad6d9"),

Guid.Parse("980ed955-5cab-4ea1-b9ef-fccc831e2416"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("dc374812-c7c8-4ceb-b089-da3434d540ed"),

Guid.Parse("99478c1e-58f2-4ca2-9283-cf48c56a7953"),

Guid.Parse("499093ab-a054-4894-b21b-54ad8752e353"),

Guid.Parse("d6064cb7-456d-4a75-9d18-21c11d172b7f"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("66171e1b-4fe7-469d-ab78-9b809add4568"),

Guid.Parse("ec54c076-aec5-43e5-9a21-56e54a883555"),

Guid.Parse("fd56c3b4-41c3-4467-a7b9-bee159813637"),

},
},
            new GuiduuidArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("538d93e8-28fe-47f8-b8d0-afd2c4141e67"),

Guid.Parse("f5e6920a-5450-409e-91be-9aee32dd783f"),

Guid.Parse("010e585a-720b-488e-ac09-1fb91a3e3923"),

Guid.Parse("bc7ae4b8-b05b-4de2-af99-81374369cf15"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("aa3d3749-5ea0-4c50-a361-f5a6218044de"),

Guid.Parse("8ee7fa66-e8ac-480c-89f4-f79edaa95a85"),

Guid.Parse("9455c0b1-3e17-404e-a992-c91ec5ccd9b3"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("51ae02e7-89c1-40d8-ba04-34f63f4e3e6a"),

Guid.Parse("0327169e-7ba2-45fc-87b5-33534cdbbe4c"),

Guid.Parse("ebaf7148-0aa3-43a5-9789-6bb7fbb5cb22"),

Guid.Parse("c146baef-d414-4cee-8f3b-044c10970cfc"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4d57b6fe-4855-42d8-8f81-aff53dc6613f"),

Guid.Parse("df76e784-fb0b-48ec-9d7f-fe8abff36ab2"),

Guid.Parse("108f157d-ba99-4710-b38b-66a5659f60a1"),

Guid.Parse("72231281-d46c-4f01-8f1e-22228063cb27"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2e0bf296-d4f2-4547-92fd-1b6bd3db0a38"),

Guid.Parse("4ed08b3b-a183-44b5-99df-a52b9b8a42fc"),

Guid.Parse("d87eb4f9-ee06-4f32-9b4b-ad6ece2957a6"),

},
},
            new GuiduuidArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d0732c7c-19d5-4251-8893-b5b14ddbb382"),

Guid.Parse("354b8147-0ced-4617-85ae-01edf10f368f"),

Guid.Parse("094f81ab-eafe-449b-ac7a-0bf0bf577d17"),

Guid.Parse("227fb02e-374e-455b-97e7-be1d83384006"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7787de84-33a8-4426-9d92-966bca2eb110"),

Guid.Parse("692957df-34eb-4679-9f2a-597fec697adb"),

Guid.Parse("b9c1e57d-feeb-4a42-a86d-03724b05ec46"),

Guid.Parse("85410f31-20a1-4d11-9c4c-71af24c67580"),

},
},
            new GuiduuidArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("9bab1646-0cf5-4b6e-b689-c6e009278c7f"),

Guid.Parse("7f83ae9f-386b-487c-b0fb-f7a027877821"),

Guid.Parse("74de2a61-6ed7-4f69-aa41-b1c102674df2"),

Guid.Parse("0fd023b5-61f7-49df-8652-55f3210d2761"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2c082cb4-8f93-463f-be0c-ab1f49b82114"),

Guid.Parse("5c5ed4a6-3c36-42eb-80b6-9480399e1c9c"),

Guid.Parse("32b65a36-dd2a-4a3d-8fc6-58c0d76cfd70"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("20d3f196-c911-45bf-88fb-1bae4a05a601"),

Guid.Parse("ffe1d26b-a7ad-431a-ac0e-e9d0672107f2"),

Guid.Parse("4e6d1b8d-72a4-4f82-a574-33493850219c"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("09cd3b9d-f10b-4f45-9a58-7c524a632294"),

Guid.Parse("e23052e3-4ab8-4cf6-b30b-b87360d517fa"),

Guid.Parse("cc3a4917-561e-4b67-be56-37c074ae32f0"),

},
},
            new GuiduuidArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e0c50925-de14-4959-a512-4b7002088455"),

Guid.Parse("82a8eb63-2b06-496e-b2d2-de0895e28805"),

Guid.Parse("d4968602-30fe-4558-9e37-dee786672277"),

Guid.Parse("1aa2252b-33fc-4bb9-9f88-c9c160b1e232"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("9087ed41-493e-4fe1-be52-46dad2785b1a"),

Guid.Parse("e7202dee-2c54-4cea-9459-0dc5c3ce0854"),

Guid.Parse("877f9e7e-3084-4feb-94b2-796402baf968"),

Guid.Parse("ded12007-cd2e-41f6-a859-d8a20f1623da"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("58e90fe6-5f29-42b3-ab1a-13c4a83c60ee"),

Guid.Parse("be7b7201-a48b-4dde-994c-b13014b8ea29"),

Guid.Parse("7c1efac5-187e-4021-a259-edf1c7d41f45"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("235ea389-53fb-424d-92b0-91b24ef839ab"),

Guid.Parse("1a395a27-d52e-414e-82b2-232dd9e95ccf"),

Guid.Parse("7fd26ec2-167b-462e-8293-1022520488c3"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9d06b883-cf0d-4f26-93a0-c314c1853b82"),

Guid.Parse("016c3e62-2349-4710-a791-911cf05d4cbd"),

Guid.Parse("cf52a1a8-e520-4346-bc73-14bdc580fa3f"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("27376146-f107-44f7-b2a6-69658b1aa2e3"),

Guid.Parse("79d01050-ee27-4fe2-b525-d406b224a0bb"),

Guid.Parse("8ded5494-496b-43f4-a074-9bcb62490d92"),

},
},
            new GuiduuidArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a49d92fa-8a7e-432a-b62e-562165a1873d"),

Guid.Parse("77097887-cdc4-4700-883d-2e9affa5edce"),

Guid.Parse("5b49a8bd-7ac9-433a-9caf-0f75a13e1e79"),

Guid.Parse("004b21ac-324a-43f7-88db-6bbdd49f69f0"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("bf6ba8c6-c2fb-4791-bad2-a79cc864aa2c"),

Guid.Parse("6814ae30-d90f-4611-a7dd-b481ac68440a"),

Guid.Parse("51d4986a-2f34-4e90-9d7b-59a7ed150a0d"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f4a4b48c-b814-4ba4-9279-21e7ceeac8cd"),

Guid.Parse("6c0df712-5d05-46f8-8819-7d3ec62ed910"),

Guid.Parse("53c5e5ab-c50e-4d0a-8672-1064a0a2d15e"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f2371711-0ee5-4ab7-811d-231a78e78d76"),

Guid.Parse("e2b5d931-1b41-4b32-a259-9f42e0ce2cda"),

Guid.Parse("e9045b46-d05c-4e86-9d77-bc257a96abec"),

},
},
            new GuiduuidArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("3edf3492-0cee-4132-baba-a9f9b27cd295"),

Guid.Parse("52e48f19-88d6-4970-92fc-3151f4b12b0d"),

Guid.Parse("dad803e9-f782-48de-810e-7a192f6c77cc"),

Guid.Parse("5b1ab94a-6b60-4cca-8828-6cb82ccfc15a"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("20cf8013-2410-48fb-a868-ad63b693a4c7"),

Guid.Parse("43d5b78a-f75f-40d2-9c0f-9628a783a436"),

Guid.Parse("7b41ab09-3e06-4152-97b9-9be22ad5b407"),

Guid.Parse("30b2c972-410b-41c0-9b93-f353a0f682ec"),

},
},
            new GuiduuidArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a526ee9e-a8f4-4876-a7f1-a47e8cc9501a"),

Guid.Parse("08072eaf-4b35-41d0-8cc7-66cf934cbbe9"),

Guid.Parse("d91a7b59-f832-4c06-a971-6bce7cc2f8e2"),

Guid.Parse("0037368a-4a06-4d88-8bea-ede1ab2e7b44"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c410c07e-9806-4db6-b4e6-de378b93f585"),

Guid.Parse("94987d1b-51ea-4c07-aef5-d388236a45da"),

Guid.Parse("2ce109c2-ec8e-4626-a119-1015957315d9"),

Guid.Parse("137d1179-e4b1-4b79-a568-ca90ce2d0630"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0673e348-6589-4aee-be87-6211481f26f4"),

Guid.Parse("a1446dea-2b64-4f9f-9e1d-59073e6b82d1"),

Guid.Parse("1b960fd3-31f3-4f2f-9398-1260891707b0"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3e216d66-bbb8-417c-bec0-492e89fa4da9"),

Guid.Parse("d2ca7f95-03dd-4790-b8f0-30b319668c5d"),

Guid.Parse("984eafab-a17f-4bf7-b883-956366c55ec0"),

},
},
            new GuiduuidArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("09f8cf69-f96d-40d8-b3ca-fb2a68710983"),

Guid.Parse("4435d38c-34a9-4583-ae3f-a61317fae579"),

Guid.Parse("a683aa5f-81d3-4261-a583-df937acd5738"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("3a21ba39-373a-4bdf-9706-6a09d44e8d15"),

Guid.Parse("48455be6-6ec3-41da-9607-6b7e77feee5c"),

Guid.Parse("ba47b346-8c5e-4275-9756-82b2fac6c24a"),

Guid.Parse("2468d4f5-d36c-43fe-a16b-582155078ff6"),

},
},
            new GuiduuidArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("6342bdf7-6dba-4bc5-b39a-973e04044ec7"),

Guid.Parse("87cae7de-d47f-4b08-abe0-9878b050a655"),

Guid.Parse("6d0b8d5d-04dd-43f4-82dd-729100b83afd"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5ba08b5a-76a5-4779-802b-0dbe06945f26"),

Guid.Parse("783a6811-79ff-49cd-b89d-7b4117dd3c1b"),

Guid.Parse("9aa97bc2-3b45-4771-a7b7-13e1cbe26a2c"),

Guid.Parse("185b4f9a-8a7a-409c-883b-841a6024f733"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e4f87f9f-332a-46cb-984a-0fff94dd86f7"),

Guid.Parse("58fb62a0-7b4b-4823-ae25-cd29784da901"),

Guid.Parse("a4840d05-04f1-4b68-9787-61dd4708481f"),

Guid.Parse("ec136dd2-2e77-482b-8eba-7a132df10769"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("36477a8a-df56-424c-906e-60a476429153"),

Guid.Parse("b6898384-30cd-42b5-850c-6f43abfedb85"),

Guid.Parse("3bf1a45c-6e25-4157-a3c9-86b6b6bf8c5c"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("434d7467-f4f4-4c40-8be8-30b39b54b908"),

Guid.Parse("deda1a1a-3f64-4b38-8bae-40b242b5c356"),

Guid.Parse("7eb02f7b-0a8c-4eab-9c9a-fc20470178be"),

Guid.Parse("57c433ab-1848-41d8-8cf4-b87654369daf"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ddbc6ba1-9185-4e7b-bbab-20e910374e37"),

Guid.Parse("1ae35fa7-9b2a-4fde-9e60-feedd5d35eb6"),

Guid.Parse("a605b067-945b-4fb0-a25c-df44025c2bc2"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e308d0c5-36f0-434f-971f-bf36fa51f36f"),

Guid.Parse("21543e05-6014-4750-9619-67a3ec8f553a"),

Guid.Parse("ce7cca6e-fde6-458e-887a-0870a71ba4ef"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f4304dd1-a519-48e0-a787-7e8052e9d167"),

Guid.Parse("8f2505e2-4495-433d-8b98-efbd5604a484"),

Guid.Parse("933815d3-8ca7-4eb7-a871-7669624e9c71"),

Guid.Parse("5ef769f0-6e0e-46c9-acde-7b13c8f1bb9a"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4950b827-690d-475e-a5f1-8248d64bbfc7"),

Guid.Parse("131c19e4-88d3-440d-b259-f9204505b39e"),

Guid.Parse("09c420f9-c19b-42f1-9266-15b72b7a289d"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b8251bfa-1d54-4629-a1ba-8ad464531184"),

Guid.Parse("e73dd516-a049-4460-98fa-cb739b40674c"),

Guid.Parse("4f73f6a2-f19e-45a1-a094-a49d17640188"),

Guid.Parse("20ff81ed-e0eb-4c83-b2c2-875f4872a3dd"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ef86f1e8-5729-40f8-a44a-715d8b4a85fe"),

Guid.Parse("1916129e-9b4f-47c4-89df-59ca194bc1c2"),

Guid.Parse("e09db6a9-90f5-4ed2-9037-b41b28a6aaa0"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("0b38974e-60f1-4185-8919-805cfecc4d4f"),

Guid.Parse("6398c873-3234-4e87-af35-922783cbe66a"),

Guid.Parse("4ec5e658-5a83-4751-a984-2378769b6ff9"),

Guid.Parse("514172dc-f744-486d-b04a-b8f882793e45"),

},
},
            new GuiduuidArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("bd29de29-611f-4a99-99e3-679cc1c66905"),

Guid.Parse("04388503-0b29-4740-abbd-bf03b0c9e9ec"),

Guid.Parse("8651d6dc-6d76-4f7c-bc7c-afa17a296904"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("16e06d4c-5823-4ac9-af81-c9cb97a5a1b4"),

Guid.Parse("6069db69-20e2-41da-8e20-eb1f494e557e"),

Guid.Parse("d1b23eec-e0c8-4cc0-9e0e-0a28006a1b61"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("88863956-3512-48e8-89e3-d4fa99f731d9"),

Guid.Parse("b2e048a5-806a-475f-8e92-539cfeaffa6e"),

Guid.Parse("d77f7fec-c2a0-4e99-a063-7a3fa71bd92b"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2cde6773-9421-4ce2-91ee-e9083b975adb"),

Guid.Parse("427cbd93-858f-4ba3-aab3-b0493dcd6966"),

Guid.Parse("5ad1cece-c5c6-4b9b-8ab4-533e5d38ba80"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3f23c2c1-8e56-4c6e-a231-1986fd6f25bc"),

Guid.Parse("29b0dfdf-d122-40cf-831c-3e96211e8510"),

Guid.Parse("cc10cce4-4b98-43ad-8499-f9f8abb39fad"),

},
},
            new GuiduuidArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("8b10dacc-b482-4f61-8924-f578a948b644"),

Guid.Parse("318fd411-4534-48c5-840f-42e715701dcb"),

Guid.Parse("696e3223-96af-474d-8cfd-9c637f67694b"),

Guid.Parse("bd660dce-2475-476a-8589-2141aae01a78"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("730d2051-bff9-4d51-a7ed-9cd4f2f4fa59"),

Guid.Parse("c48b36e2-858d-4d74-9dcd-2914b6aeb992"),

Guid.Parse("472ab26d-2fc8-4e3c-b3d0-7e373edf74e3"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("921b2c00-5ecd-4e95-a09d-60d3cd5221c2"),

Guid.Parse("3440eeff-e1cb-4161-a928-bab038e2f2dd"),

Guid.Parse("d9b441cb-9473-42d5-a81b-220229dcd75d"),

Guid.Parse("a03ca7e5-8f01-4339-887b-f8b31ee5aa04"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("1fca468c-6b5d-49fc-b5f0-15271b0d941a"),

Guid.Parse("ca5c9be4-3af4-4525-a33f-b82d32039f22"),

Guid.Parse("47cb7096-ae10-4035-bb84-5ed9c2edc522"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0613f8a3-a6c2-4d3d-8bd7-52deb277456f"),

Guid.Parse("053a2f33-d12f-4715-886d-aa8d307ae06d"),

Guid.Parse("8ca4aedb-52f8-4647-83c4-de6f8048eea3"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e594962e-891f-4cef-8460-a9f6f220dab1"),

Guid.Parse("4cdc6f06-a314-4b5b-945e-986942cac794"),

Guid.Parse("0cf206e7-9558-4dfb-ae7a-8ea16a32a4ae"),

Guid.Parse("38e2a609-4ea8-4657-bc06-246b54e7ae5b"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("09e06295-89ca-4960-a89f-f2d8bc045bea"),

Guid.Parse("39a40f2b-cc43-4692-bebd-bd1a3f0908ea"),

Guid.Parse("34d9de35-48f7-4ef0-b09d-eca1cfead87a"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e6e3e9b9-9724-496f-b075-229fc3254afb"),

Guid.Parse("1d016106-e457-41d9-a740-0cba807199b7"),

Guid.Parse("3bc2c2cc-3710-4b49-8a4b-9a10515b3c4d"),

},
},
            new GuiduuidArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("2152f305-bcea-42bf-ae61-cbf112f3dbbb"),

Guid.Parse("9a0e2b73-c17f-4af5-9eb7-82194c7e0f21"),

Guid.Parse("55f6526e-75f7-44bc-8b2b-c9f4a7de9b4e"),

Guid.Parse("23631787-c44d-4af5-a352-f0d4e81df973"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("34ccd2af-e64e-448f-8832-de514ddf6f14"),

Guid.Parse("2c3dc589-3b46-49a0-a2d1-5fd533e5a14b"),

Guid.Parse("1cbe5eea-2291-40c4-8270-dcd030a575ce"),

Guid.Parse("827563ac-d7d8-4506-a233-e7a6282fa5c1"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a56db227-3f15-4070-a5ca-545ce665b45e"),

Guid.Parse("3d5a769a-37c5-4ea2-bc3d-10f0a9f29f99"),

Guid.Parse("87126e40-ea2f-4495-8ff3-ce7462ff5743"),

Guid.Parse("996bd671-0cd6-4d91-8fbf-f1da0f447297"),

},
},
            new GuiduuidArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("379d9b83-31be-436c-b482-697bc690ede0"),

Guid.Parse("4b598f11-9b01-436e-8198-1f9edbe30102"),

Guid.Parse("7abf1951-6ff3-4eca-86ec-9e7305ebc704"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("75263cee-0292-4de1-b82f-e105980d1d47"),

Guid.Parse("8e2c05b7-b6af-49d6-a337-5b8dbc9b9b64"),

Guid.Parse("aa797201-932c-4b83-b3c9-3103f249b08d"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b5b27dce-0aea-450e-b745-4a55577604e0"),

Guid.Parse("f12b0007-7d1c-433e-b741-be9ac6c95c82"),

Guid.Parse("fa802c29-3c85-47b1-ad00-51cfa4c655da"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("13538aa6-40a3-4ab8-aa80-b92f5f821c1a"),

Guid.Parse("16f8aeb7-3939-4b48-8561-7ec824f40622"),

Guid.Parse("e42ac821-c63c-4fb4-b69b-97aea060093c"),

Guid.Parse("d5436f07-13df-4ea7-b429-0c65e33a21ec"),

},
},
            new GuiduuidArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("6fad63fe-ea41-40e7-bc61-586e0a7a0555"),

Guid.Parse("9f9b5fce-ac6f-41d7-8347-8ba5b143d450"),

Guid.Parse("d291959f-35b1-4be8-ba35-bd36fac52f50"),

Guid.Parse("22cf1c7a-d345-4bf0-8015-8fb24645bf9b"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b62385f6-b7df-4119-b115-d8e140e497fe"),

Guid.Parse("69544d64-af0d-4c3d-97a8-5f2faeb6f9f5"),

Guid.Parse("38f6c8be-e9eb-4569-8e85-fbf667d2cbed"),

Guid.Parse("cfe65ba8-441e-4e24-ae49-68d693e7a651"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("00ea4327-4905-4f72-8ead-79c5ce38b036"),

Guid.Parse("7bbc26c7-f9e7-4d38-aeb4-2aae90bfab9d"),

Guid.Parse("1f4a0154-d852-4e1e-8d93-f7aebdde19a6"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7b4c750e-7327-4cd8-bb40-f18754d2d983"),

Guid.Parse("a1de0b40-70be-4fea-85e9-7f3ce64b4d4e"),

Guid.Parse("204c5b72-8209-4ca2-a29c-303d0098b11e"),

Guid.Parse("addccfb0-6c8b-4912-99e1-8ee1d8aeee30"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("a01dad18-7312-4c04-b927-eb45f3905319"),

Guid.Parse("99191e78-dd95-4925-97d9-29ba6926a09a"),

Guid.Parse("d3de63b6-ca7c-4711-a8bf-17e27546380f"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a85b76c6-5d05-4330-8cc1-c5639e100b4f"),

Guid.Parse("2b82661f-6c82-4d51-bafe-874bb5cb4647"),

Guid.Parse("c56620e9-8e75-4081-a165-f0f37ffdfc70"),

Guid.Parse("35014974-0ee2-44be-b08a-8e00e0a62937"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("7254ddad-f5b2-428e-9a9f-e1aec7fdd79d"),

Guid.Parse("f5d87e36-bb14-4cc0-88d8-2fc14550308e"),

Guid.Parse("8ca08e36-a99a-4198-b5e0-66dc0af92795"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5e9c9475-b2d7-44ab-a69e-e8f134af1063"),

Guid.Parse("9065331d-4c62-41d8-8e82-37b1b180a5ee"),

Guid.Parse("4937cf95-fca2-4d28-8c16-80dc3827ea61"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("d59d59ef-dd82-4130-a39c-fedc9a0045b0"),

Guid.Parse("a96d987e-2d69-45f4-b7a7-4229a0d1c5ed"),

Guid.Parse("69a285d3-764e-49a3-8a91-c7857ed2265c"),

},
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

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
            asPartInterface: typeof(IGuidListuuidArray)),
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var firstItems2 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems2 = new List<FlatGuiduuidArray2M>();
                await ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[22],_testData[34], false);
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
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var firstItems2 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                await ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 22;
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var firstItems2 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems2 = new List<FlatGuiduuidArray2M>();
                 ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 146;
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
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var firstItems2 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                 ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[26],_testData[34], false);
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
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
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
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
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
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 54;
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems2 = new List<FlatGuiduuidArray2M>();
                await ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[27],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
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
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[19],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[20],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[21],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[22],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[23],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[24],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
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
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems2 = new List<FlatGuiduuidArray2M>();
                 ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[34], false);
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
            batchName: "DbConnectionSTSelectModelDynParBatch",
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
                var models = await((IGuidListuuidArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        GuiduuidArray2M.AssertModel(models[0],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        GuiduuidArray2M.AssertModel(models[0],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[19],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[20],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        GuiduuidArray2M.AssertModel(models[0],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        GuiduuidArray2M.AssertModel(models[0],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[19],_testData[34], false);
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

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
            asPartInterface: typeof(IGuidListuuidArray)),
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidArray2M>();
                var models2 = new List<FlatGuiduuidArray2M>();
                await((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var firstItems2 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems2 = new List<FlatGuiduuidArray2M>();
                await ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 51, query1, 117, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[34], false);
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
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var firstItems2 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                await ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 29, query1, 86, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var firstItems2 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems2 = new List<FlatGuiduuidArray2M>();
                 ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 54, query1, 32, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[27],_testData[34], false);
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
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var firstItems2 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                 ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 134, query1, 17, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[32],_testData[34], false);
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
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
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
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 58, query1, 69, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[34], false);
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems2 = new List<FlatGuiduuidArray2M>();
                await ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 69, query1, 33, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[26],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 122, query1, 51, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[19],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[20],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[21],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[22],_testData[34], false);
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems2 = new List<FlatGuiduuidArray2M>();
                 ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 38, query1, 134, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[34], false);
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
            batchName: "DbConnectionSTSelectModelBatch",
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
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((IGuidListuuidArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTSelectModelBatchAsync(connection, 32, 133))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        GuiduuidArray2M.AssertModel(models[0],_testData[7], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[8], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[9], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[10], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[11], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[12], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[13], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[19],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[20],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[21],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[22],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[23],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[24],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[25],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[26],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        GuiduuidArray2M.AssertModel(models[0],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTSelectModelBatch(connection, 114, 141))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        GuiduuidArray2M.AssertModel(models[0],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        GuiduuidArray2M.AssertModel(models[0],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[34], false);
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
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 26);
                var models = await ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(30));

                GuiduuidArray2M.AssertModel(models[0],_testData[5], false);
                GuiduuidArray2M.AssertModel(models[1],_testData[6], false);
                GuiduuidArray2M.AssertModel(models[2],_testData[7], false);
                GuiduuidArray2M.AssertModel(models[3],_testData[8], false);
                GuiduuidArray2M.AssertModel(models[4],_testData[9], false);
                GuiduuidArray2M.AssertModel(models[5],_testData[10], false);
                GuiduuidArray2M.AssertModel(models[6],_testData[11], false);
                GuiduuidArray2M.AssertModel(models[7],_testData[12], false);
                GuiduuidArray2M.AssertModel(models[8],_testData[13], false);
                GuiduuidArray2M.AssertModel(models[9],_testData[14], false);
                GuiduuidArray2M.AssertModel(models[10],_testData[15], false);
                GuiduuidArray2M.AssertModel(models[11],_testData[16], false);
                GuiduuidArray2M.AssertModel(models[12],_testData[17], false);
                GuiduuidArray2M.AssertModel(models[13],_testData[18], false);
                GuiduuidArray2M.AssertModel(models[14],_testData[19], false);
                GuiduuidArray2M.AssertModel(models[15],_testData[20], false);
                GuiduuidArray2M.AssertModel(models[16],_testData[21], false);
                GuiduuidArray2M.AssertModel(models[17],_testData[22], false);
                GuiduuidArray2M.AssertModel(models[18],_testData[23], false);
                GuiduuidArray2M.AssertModel(models[19],_testData[24], false);
                GuiduuidArray2M.AssertModel(models[20],_testData[25], false);
                GuiduuidArray2M.AssertModel(models[21],_testData[26], false);
                GuiduuidArray2M.AssertModel(models[22],_testData[27], false);
                GuiduuidArray2M.AssertModel(models[23],_testData[28], false);
                GuiduuidArray2M.AssertModel(models[24],_testData[29], false);
                GuiduuidArray2M.AssertModel(models[25],_testData[30], false);
                GuiduuidArray2M.AssertModel(models[26],_testData[31], false);
                GuiduuidArray2M.AssertModel(models[27],_testData[32], false);
                GuiduuidArray2M.AssertModel(models[28],_testData[33], false);
                GuiduuidArray2M.AssertModel(models[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidListuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 140);
                var models =  ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(4));

                GuiduuidArray2M.AssertModel(models[0],_testData[31], false);
                GuiduuidArray2M.AssertModel(models[1],_testData[32], false);
                GuiduuidArray2M.AssertModel(models[2],_testData[33], false);
                GuiduuidArray2M.AssertModel(models[3],_testData[34], false);
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
FROM public.binary_guiduuidarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(GuiduuidArray2MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidListuuidArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidListuuidArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidListuuidArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidListuuidArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(GuiduuidArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidListuuidArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidListuuidArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidListuuidArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidListuuidArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

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
            methodName:"WAImportModelInner",
            queryMapType: typeof(GuiduuidArray2MI),
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidListuuidArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidListuuidArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidListuuidArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IGuidListuuidArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(GuiduuidArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidListuuidArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidListuuidArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidListuuidArray)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidListuuidArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(GuiduuidArray2M),
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IGuidListuuidArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IGuidListuuidArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IGuidListuuidArray)this).ImportModel(connection, importCollection);
                var models = ((IGuidListuuidArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MIWA), typeof(GuiduuidArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
                var models1 = new List<GuiduuidArray2MIWA>();
                var models2 = new List<GuiduuidArray2MIWA>();
                await ((IGuidListuuidArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidArray2MIWA>();
                var models2 = new List<GuiduuidArray2MIWA>();
                ((IGuidListuuidArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
                var models = await ((IGuidListuuidArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidarray2mi
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
                    GuiduuidArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidListuuidArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_guiduuidarray2mi
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
                    GuiduuidArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MIWA), typeof(GuiduuidArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
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
                var models1 = new List<GuiduuidArray2MIWA>();
                var models2 = new List<GuiduuidArray2MIWA>();
                await ((IGuidListuuidArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidArray2MIWA>();
                var models2 = new List<GuiduuidArray2MIWA>();
                ((IGuidListuuidArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
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
                var models = await ((IGuidListuuidArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidarray2mi
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
                    GuiduuidArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidListuuidArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_guiduuidarray2mi
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
                    GuiduuidArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MI), typeof(GuiduuidArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
                var models1 = new List<GuiduuidArray2MI>();
                var models2 = new List<GuiduuidArray2MI>();
                await ((IGuidListuuidArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidArray2MI>();
                var models2 = new List<GuiduuidArray2MI>();
                ((IGuidListuuidArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
                var models = await ((IGuidListuuidArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidListuuidArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MIWA), typeof(GuiduuidArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
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
                var models1 = new List<GuiduuidArray2MIWA>();
                var models2 = new List<GuiduuidArray2MIWA>();
                await ((IGuidListuuidArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidArray2MIWA>();
                var models2 = new List<GuiduuidArray2MIWA>();
                ((IGuidListuuidArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
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
                var models = await ((IGuidListuuidArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidListuuidArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

