

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
    internal partial interface IGuidMArrayMArrayD1
    {
    }
    
    internal partial class GuidMArrayMArrayD1 : IGuidMArrayMArrayD1
    {


#region TestData

        private readonly GuidMArrayD1E1M[] _testData = new GuidMArrayD1E1M[]
        {
            new GuidMArrayD1E1M
{
    Id = 6,
    Value = 
new System.Guid[3]
{
Guid.Parse("833c2c38-5d20-4676-8d15-e52c59144d87"),
Guid.Parse("2b4892ec-d02a-47da-af60-be3ec867cc69"),
Guid.Parse("edf4fe5b-713f-459f-8d28-37375dad0979"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 4,
    Value = 
new System.Guid[3]
{
Guid.Parse("875bad67-e71b-4f54-b326-e419173e2eed"),
Guid.Parse("28e8ec5c-178a-44d7-8377-9f3f291325b3"),
Guid.Parse("3ed18244-514b-41f5-b92c-a73871db3b2b"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("f446cd25-6489-47fb-9a0f-cfec80560663"),
Guid.Parse("e972f1a9-0d93-4d09-af94-ff87e64ae2da"),
Guid.Parse("e66a96ca-7c52-4901-be31-f758fefcf20f"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("6505b534-6f6f-49a0-837e-4af14c6ee13c"),
Guid.Parse("a2551216-3740-4d6f-9302-5b9d25c061fd"),
Guid.Parse("a545c9e2-67cf-4fc4-a577-638841b441b5"),
},
},
            new GuidMArrayD1E1M
{
    Id = 15,
    Value = 
new System.Guid[3]
{
Guid.Parse("9c9e142d-26eb-4873-ab2f-a55e45b56c15"),
Guid.Parse("97bde3c2-a992-45d4-93a5-bf5163e72bae"),
Guid.Parse("4c76a435-cf70-43e7-917a-15ed8b4176f0"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 12,
    Value = 
new System.Guid[4]
{
Guid.Parse("ab6947d1-4d0d-4a81-bbee-57084e964c7c"),
Guid.Parse("ba116362-2788-4717-9e8f-e1b6286eb1c5"),
Guid.Parse("d5cd5e71-9692-49f3-8b07-a9894f00bb5d"),
Guid.Parse("f56af268-80e9-4aa8-97c7-006dc47d2437"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("70560682-22c1-433f-81f7-f6e29ed5f5ef"),
Guid.Parse("25d028a4-adaa-4ba8-a2ec-fd6d9e5789ce"),
Guid.Parse("d299b997-d2a9-48f9-9e16-e8ab5f809de3"),
Guid.Parse("e73f2038-3dd9-4264-a84c-ba9c30346743"),
},
},
            new GuidMArrayD1E1M
{
    Id = 20,
    Value = 
new System.Guid[4]
{
Guid.Parse("3ee7f8c0-743d-4bda-922f-a7a5b987a7b8"),
Guid.Parse("d7b49dfd-277b-4922-ae7f-4b6af48c21b4"),
Guid.Parse("99b3986d-ca72-4b45-b02a-4f23f84fc9e0"),
Guid.Parse("04ddd803-e9f0-4200-bafa-a1018007214d"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 19,
    Value = 
new System.Guid[3]
{
Guid.Parse("882a7ab8-141c-4c78-8163-f40104f5826a"),
Guid.Parse("fbe8f193-b962-419f-bc1c-85f6e233676a"),
Guid.Parse("176f3600-9611-4554-8f4a-f78b50187a66"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("03a90170-3caf-4883-9f96-638221523b91"),
Guid.Parse("2b499d3c-4cf0-420a-bec2-9548233a8f14"),
Guid.Parse("d5cf5630-421b-4e4e-b2cd-90836f22eff7"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 27,
    Value = 
new System.Guid[4]
{
Guid.Parse("f4dffe64-3d7f-4d36-aab2-4fc11c016255"),
Guid.Parse("12a49d5f-66bb-4fab-8717-4a0051c7afd0"),
Guid.Parse("a3e67210-9079-4f3e-ad3e-be95a75b763e"),
Guid.Parse("853ab236-34bc-48f3-8395-daa6e9aacd44"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 26,
    Value = 
new System.Guid[3]
{
Guid.Parse("d1aa671b-c9e1-493f-8044-b842e631df02"),
Guid.Parse("0b59df8a-03e1-42e3-90b1-4620739a8b71"),
Guid.Parse("fd4da4b7-80b0-49d8-9def-a14a24ccd9bc"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("e90a8bf5-5d10-4dac-96c6-3f6a9fb3b198"),
Guid.Parse("f2416dce-e24e-4e89-8322-967b060c7d57"),
Guid.Parse("f6515cda-ae00-4c29-afb4-025d7729ec70"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 30,
    Value = 
new System.Guid[3]
{
Guid.Parse("acedadbb-5401-4330-bfc7-7b9f374588dc"),
Guid.Parse("cf26be53-426a-4dc8-b949-9fa432bcd30a"),
Guid.Parse("63b30236-f428-4545-97bc-e5a23b32d6ca"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 29,
    Value = 
new System.Guid[4]
{
Guid.Parse("c1e59c2c-2150-4d92-8d86-585d3f95a151"),
Guid.Parse("032b23c4-322f-4fbe-ac06-e0ac28f6e6da"),
Guid.Parse("24bc209d-3971-449b-bbda-585d726354c0"),
Guid.Parse("9e8975cb-8d6e-4582-bfd9-e5d53f20b4a0"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("094f0615-5444-4001-a164-82eea921102c"),
Guid.Parse("2f941161-0a86-41a2-83fe-1c6f9eaa8ba6"),
Guid.Parse("4125ad85-c4ba-42aa-8c5a-401042cf2870"),
Guid.Parse("f98eee66-1add-4453-9bb9-752662c65219"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 31,
    Value = 
new System.Guid[3]
{
Guid.Parse("648148da-e143-4418-b540-679801dc2311"),
Guid.Parse("c1806452-7973-42ed-b879-1444acf8e4d0"),
Guid.Parse("f8d3d946-f19b-42f6-b7f0-851361bbbc0d"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 31,
    Value = 
new System.Guid[4]
{
Guid.Parse("c4de07ba-6a1b-4974-baf9-ed61e9c84477"),
Guid.Parse("f6ceaadd-9096-41fa-9c76-6c78174bf2df"),
Guid.Parse("2eaccf60-16ce-4eeb-9a5d-d4e22b0870fa"),
Guid.Parse("e26abf3c-ae50-4b1a-9108-bd3cb0952953"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("25bd5b8c-93e8-4353-9e9d-2997c3178641"),
Guid.Parse("cfa2f6ee-a682-49b6-87f9-c0da3b3f5acf"),
Guid.Parse("1403035e-65ba-4a8b-91b0-59407f2e2cc4"),
Guid.Parse("81c0eba7-8b37-44c5-a0d6-3a59f4cb874d"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 38,
    Value = 
new System.Guid[4]
{
Guid.Parse("9f80548d-5365-4b27-845b-e0346367435a"),
Guid.Parse("729a9cc0-49ea-46ec-829e-1e2d40fad626"),
Guid.Parse("23f89d42-2b17-4fd7-b360-bad733d0acb6"),
Guid.Parse("4fb120a8-8ccb-4516-9206-7d39918ccfc1"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 37,
    Value = 
new System.Guid[3]
{
Guid.Parse("49a878d9-04ea-4214-bf01-8aa3fecd243f"),
Guid.Parse("dcfa7018-fcc9-48df-80bd-925b165419f7"),
Guid.Parse("f3adbbea-9591-47ce-b020-9b68b1badda7"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("4142649e-dc82-4ac3-8164-6271b4691089"),
Guid.Parse("fb59d9c3-d8d2-44f5-9a07-a6b30f0690d4"),
Guid.Parse("8e8c0dcc-5f50-4053-95ef-f1cc433c6f92"),
Guid.Parse("59ed2543-4419-4fea-9563-d136e8705a76"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("8619da5e-0b04-4789-8ee6-496a42e96938"),
Guid.Parse("95b74413-df32-4044-ae69-9d70d2b489d9"),
Guid.Parse("a9298617-0382-4813-ade0-b1f3f9935638"),
Guid.Parse("ca84995c-d703-413e-93a6-f084af1375ec"),
},
},
            new GuidMArrayD1E1M
{
    Id = 42,
    Value = 
new System.Guid[4]
{
Guid.Parse("95d07fee-6a9d-4364-8b7b-171b0f2a357f"),
Guid.Parse("ec9471b6-69f5-43f1-950e-27d459905481"),
Guid.Parse("df733d51-b7eb-4736-9a09-523a43739ca6"),
Guid.Parse("f29ac2a0-527a-44d5-ba3d-87fe05790cc3"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 44,
    Value = 
new System.Guid[4]
{
Guid.Parse("4cc525bd-dfca-45df-a890-1e7c7fc95fe6"),
Guid.Parse("1797ddb6-ea2a-4311-9487-88b6a7d185fb"),
Guid.Parse("e151794d-2ae3-42a5-a97e-534187725875"),
Guid.Parse("80d47f7e-526e-4a1a-aa9e-14eb5233355d"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("17506be9-870c-4a00-85a5-4a08f3af813c"),
Guid.Parse("fcc3728b-af35-4746-af90-989b9ec6e9ab"),
Guid.Parse("30845107-6868-4414-a88c-d6d2c73a25fc"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("908c8a09-5910-453a-8717-cebde7279d87"),
Guid.Parse("c4de275b-6269-4c9c-9df2-ede506377e91"),
Guid.Parse("ddf2df6b-c81e-4c87-b5f0-19f4a9540ce6"),
},
},
            new GuidMArrayD1E1M
{
    Id = 50,
    Value = 
new System.Guid[3]
{
Guid.Parse("fbf84fd6-65c7-46ad-b257-8044b8b52c50"),
Guid.Parse("e959f983-6a7e-47ed-b222-064a76720c36"),
Guid.Parse("afb78757-a584-4b7f-99d6-c0ad03493e13"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 45,
    Value = 
new System.Guid[4]
{
Guid.Parse("3acd700b-91ef-462b-8507-8eb270d46768"),
Guid.Parse("b6e62563-79e5-40cb-b1c5-911270fda44e"),
Guid.Parse("bd4f90b0-4717-417b-8a70-a7fd34e3b077"),
Guid.Parse("15b1ca2e-da66-4ab1-9773-eba5ac1424e6"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("4dfec874-2d88-45f3-a077-6161a66ce284"),
Guid.Parse("10d515ae-e782-4c79-b743-d588ea68213f"),
Guid.Parse("d52110b4-e61e-401d-8bbf-224cfd283901"),
Guid.Parse("054d5d59-c181-43c6-a637-fd4b05020cf1"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("619e475c-8944-41df-83ee-328a3a980db1"),
Guid.Parse("ad095233-0685-4c0a-9713-cd16fe882ba2"),
Guid.Parse("728b5401-1b22-478a-b649-cf9e4cef7979"),
Guid.Parse("fd98a36c-1025-4f4a-afed-0dc5bce4bdbb"),
},
},
            new GuidMArrayD1E1M
{
    Id = 55,
    Value = 
new System.Guid[3]
{
Guid.Parse("c4c5d837-4faf-49df-b5b9-c9336e224b37"),
Guid.Parse("cb09c7e0-a347-4b52-8dcb-528ddfe12e73"),
Guid.Parse("e7735bae-e7e8-4fdd-a095-b852ef4fed5b"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 47,
    Value = 
new System.Guid[3]
{
Guid.Parse("f9e49e00-5b7a-4dee-ab9e-4e7a55e628d6"),
Guid.Parse("10c9c8f8-01ee-4a65-8f52-5429b3c5aaee"),
Guid.Parse("50e95189-22f1-4b57-9273-591fe3ffec34"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("ed91d14f-00b1-4f6c-983d-bb58ddc5f169"),
Guid.Parse("5f7a1953-9746-4d8c-bc06-c7382a978736"),
Guid.Parse("3120f906-a7bc-4d33-9752-be3e13c5ef35"),
Guid.Parse("85cdcda4-a1b5-4497-a2d5-e74000eb8849"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("e9f5b1e0-57f6-4e09-8f98-7a7ae557600c"),
Guid.Parse("0f839e84-0ba0-459f-815a-36ddb8d42aed"),
Guid.Parse("698ca4de-72a4-4377-8b2e-75204c66680e"),
Guid.Parse("6b7f5496-fe35-4aa6-b69c-1c7e583dcf84"),
},
},
            new GuidMArrayD1E1M
{
    Id = 62,
    Value = 
new System.Guid[4]
{
Guid.Parse("b5cf78e6-31eb-4b9d-a6ca-216142445e55"),
Guid.Parse("1c14dfba-2fe3-4a3c-80c7-b2de4c2173bf"),
Guid.Parse("e8ac9d33-e744-41d4-a51b-e8f71efd91b3"),
Guid.Parse("5e3de9c6-eb17-4778-b74a-84e92078c43c"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 54,
    Value = 
new System.Guid[4]
{
Guid.Parse("9cde59bd-d28d-4e9c-8028-c98477178d2c"),
Guid.Parse("fb5b13a7-01bb-4e24-b52f-b048e0077c37"),
Guid.Parse("4a5a5b2d-40da-4ae6-88c1-781dce81532e"),
Guid.Parse("02542b5e-d4fa-4e1b-8f2f-dc826c423af0"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("e1446850-3816-4aa1-9ee0-49f4a5c16638"),
Guid.Parse("83fb0f0d-553b-48ca-8d93-b7f254a42c8b"),
Guid.Parse("f27bfad9-db14-4e5c-9c5e-50dfbb70e81f"),
Guid.Parse("b2bc4f5d-46f1-4e85-8a0a-0dc6531789ca"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("de8bdaf7-9dc2-459d-88e7-d682aa679aed"),
Guid.Parse("be38c442-80bd-40dd-81c3-4daaa9a7c309"),
Guid.Parse("57e7ad6d-e10f-4579-8344-335a0c4abe06"),
Guid.Parse("fbb6a08c-d63c-45d0-a68f-594569e2c5a4"),
},
},
            new GuidMArrayD1E1M
{
    Id = 71,
    Value = 
new System.Guid[3]
{
Guid.Parse("38fd783b-e694-47ce-998a-d1ffaf6a213c"),
Guid.Parse("c2e70516-91d5-495e-83ad-1bc1330d85f5"),
Guid.Parse("844e9f6e-30fb-4452-860f-9ebf9bbf0e14"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 56,
    Value = 
new System.Guid[3]
{
Guid.Parse("672b5a7b-ef88-42d0-8380-f28e8703cdcb"),
Guid.Parse("57cd3aec-d52c-4f05-98ac-d27f6f342f6c"),
Guid.Parse("d1ad9560-5ba6-4795-beb8-b179a0dc698f"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a0507c-09d5-4997-bd30-eee338a9d7cb"),
Guid.Parse("5809bcf4-3920-4739-a263-a035d45e3acc"),
Guid.Parse("ecbde37c-5e9f-4592-b3bd-d6624382b076"),
Guid.Parse("86c441b3-d1ab-4e07-a807-d9ba7a250ad4"),
},
},
            new GuidMArrayD1E1M
{
    Id = 74,
    Value = 
new System.Guid[4]
{
Guid.Parse("31e1d1c8-cf69-4710-bee3-0ca27eb9ff16"),
Guid.Parse("7aa75664-6703-487a-ba6f-e4b4d0c772ab"),
Guid.Parse("653d2955-832f-47be-98e2-bd4a378a17b1"),
Guid.Parse("85610112-bf3c-4628-a635-e280f930feb2"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 60,
    Value = 
new System.Guid[3]
{
Guid.Parse("ffa617d8-191b-47bf-9949-230cb6bc5718"),
Guid.Parse("f3c5738a-5c0b-470d-8de7-54f7867fb80f"),
Guid.Parse("83452a33-e1aa-48f4-a973-818f5b68f485"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("f5720826-ab89-4e1c-ae40-5f0cbafbe543"),
Guid.Parse("8ce42829-6735-48ab-ac2b-e2ba661ee886"),
Guid.Parse("655cf958-0767-4528-88c2-6103a551b2a9"),
Guid.Parse("8ff8b8f9-2f6b-410f-bc60-cfa8aad88d6b"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("463de018-e62e-4817-89e0-992c10a8caf1"),
Guid.Parse("3622a6a3-56c1-4017-83b0-fb17516e2c8c"),
Guid.Parse("ddae7a1c-7ecc-47b7-a58c-f139c79c33bc"),
},
},
            new GuidMArrayD1E1M
{
    Id = 83,
    Value = 
new System.Guid[3]
{
Guid.Parse("2de55642-039d-46ad-b622-2fa4e3a7f43e"),
Guid.Parse("f54c9c1d-0c63-4313-b8b8-807cc5095f24"),
Guid.Parse("8a939c5b-5aa5-4bc1-b3f2-8ad305cb64fc"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 62,
    Value = 
new System.Guid[4]
{
Guid.Parse("2aa8088c-3c33-4ff6-a4f6-a1b7267ad97f"),
Guid.Parse("537fdb36-2ce6-4355-9275-0869ef8faa4e"),
Guid.Parse("94a5332c-3cf8-422f-9638-e9672b217b68"),
Guid.Parse("c812f1f6-eeac-49f9-b2b8-35c85acea08e"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("3ee685d8-c257-46a1-aa43-032f581befc2"),
Guid.Parse("91f77b70-c87e-496b-bf2b-0112ca6804c4"),
Guid.Parse("7fcff6ab-c100-48ea-a770-8f9c069e8107"),
Guid.Parse("a9fe1963-0d2c-462b-83e6-69d8e1bdf5ef"),
},
},
            new GuidMArrayD1E1M
{
    Id = 87,
    Value = 
new System.Guid[4]
{
Guid.Parse("fdcf4572-63ae-4d04-a403-c1496c23109b"),
Guid.Parse("00f9acf3-6687-4188-aad2-fe8ee1f8146d"),
Guid.Parse("6bae7576-52de-4bca-a214-d94821d6c3a1"),
Guid.Parse("6fd18765-522b-46af-8339-e3a15e795941"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 67,
    Value = 
new System.Guid[3]
{
Guid.Parse("4931c4c4-7af9-4cff-9f2e-7a54c5bca931"),
Guid.Parse("de2e1f6c-1f4d-4196-9534-08f4008cb814"),
Guid.Parse("ff8a0422-48a2-4d4b-a2cf-11e60e980143"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("695d07da-b7b0-4979-9cb5-e6d470c17fde"),
Guid.Parse("493f6113-daf2-444c-b802-2b4f5131598e"),
Guid.Parse("fe49f4c4-f701-43ec-8159-66a54a5d069a"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("bb32fa8f-5cbd-4487-9ebe-a835352a90f8"),
Guid.Parse("e3e7580d-1f90-4c97-9605-eb9927d8dfc4"),
Guid.Parse("31554206-f71c-4d77-98af-17d7da399893"),
},
},
            new GuidMArrayD1E1M
{
    Id = 96,
    Value = 
new System.Guid[3]
{
Guid.Parse("d42f6202-c559-4cad-883b-fb299956f476"),
Guid.Parse("671231c2-9252-4023-8653-ba9a6176f604"),
Guid.Parse("0a5f96e4-618a-4a1b-8bf3-9e87486a2b1d"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 74,
    Value = 
new System.Guid[4]
{
Guid.Parse("93984186-e5c3-4b5f-b930-13ee39054cb9"),
Guid.Parse("15d5dc41-dbd2-490e-8bff-97ef44382c52"),
Guid.Parse("70d13535-b73d-4cbc-a2c4-2f8c2c9ee1b6"),
Guid.Parse("8607d71c-eabf-4f17-88c4-da63c760ff88"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("c50f6b28-4d0b-4dab-bec7-3198c8a376a8"),
Guid.Parse("b865abdb-2333-4530-ad09-50cdfc766dd7"),
Guid.Parse("4831d1d9-458c-43c6-b0cf-063b564f5e20"),
Guid.Parse("0d683ac9-ac48-47bc-ac83-ef8cc560efa3"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 105,
    Value = 
new System.Guid[3]
{
Guid.Parse("804475bc-91f8-4c49-8d10-9f695f3daeec"),
Guid.Parse("977cd09d-b70e-486a-8033-6d4a9d95fbad"),
Guid.Parse("3a5a0e3e-900f-44da-8935-ef7cf00dbc98"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 82,
    Value = 
new System.Guid[4]
{
Guid.Parse("65be36a0-842e-49b7-94aa-1a4dd6db57cf"),
Guid.Parse("8b975bed-e53f-4792-b4a0-90934cbcca2c"),
Guid.Parse("b5bbf40a-3a4f-4b76-8e84-cca4de120f84"),
Guid.Parse("d63a3dbd-2ef5-464d-9f38-619f7c9615ba"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 114,
    Value = 
new System.Guid[3]
{
Guid.Parse("ffff402d-0b86-411f-8fea-9ee7e67c688f"),
Guid.Parse("278dc041-d1ec-4cb5-8e28-2f1dd5efb3da"),
Guid.Parse("1fbc9e44-dadd-408b-8974-149c225fb49c"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 88,
    Value = 
new System.Guid[3]
{
Guid.Parse("8e4eac8f-ebe8-4b26-814d-bdd4c8cc26f8"),
Guid.Parse("19d95f62-9e0c-483f-8b92-813f010dd821"),
Guid.Parse("0894810d-1ec5-436e-9b6c-fb785d7e1e9a"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("36348cf8-ed9c-46d2-83d8-4c7dbcdcbe12"),
Guid.Parse("cb9b571b-b5e5-425d-b90d-b73d03dce0f6"),
Guid.Parse("46164e9d-c6ed-457c-bd3e-eed2c5c56f5b"),
Guid.Parse("30af7067-d911-45b7-b0fb-fc303de102f7"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("d00c7c6a-0e19-4927-b056-acb0aa89423b"),
Guid.Parse("3f4c3c44-b5d2-4c40-b4c0-76cf94a12cf7"),
Guid.Parse("e20f9937-6711-485f-b14a-7a02e7f07b64"),
},
},
            new GuidMArrayD1E1M
{
    Id = 123,
    Value = 
new System.Guid[3]
{
Guid.Parse("b770cd3a-5bf4-439e-8612-2ab3cca25cbe"),
Guid.Parse("8f429aba-b54d-4a44-bf9f-6a24a3f7e602"),
Guid.Parse("5226763f-c1a0-4b5f-8e32-4a9f8054e57f"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 90,
    Value = 
new System.Guid[3]
{
Guid.Parse("8042b295-2915-43f3-a2b7-41276564c563"),
Guid.Parse("9fc544ff-fe37-4068-9c4e-43509a7bd713"),
Guid.Parse("8f11358d-49cd-4c42-915e-ea28f061a391"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("0b41417b-f4a6-4115-84ee-2e7e725bf848"),
Guid.Parse("d4afb103-4ca3-4431-b20e-5dd7a78604f8"),
Guid.Parse("4ca551b0-c747-4305-8fee-9f9f92ad4fa3"),
Guid.Parse("1b5e6902-a658-46a1-9ee5-48ae59448977"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 129,
    Value = 
new System.Guid[4]
{
Guid.Parse("d1f5228d-07ed-4795-9e6f-8967dfcc8013"),
Guid.Parse("52b94379-892e-4d28-93da-9ba503513be8"),
Guid.Parse("980e9020-0eb5-4496-9135-72d2da74440d"),
Guid.Parse("8a5fe32d-46e7-4e99-b649-54d7348ffaf2"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 96,
    Value = 
new System.Guid[4]
{
Guid.Parse("d913bc60-6d4d-46b9-b19b-59047dba4480"),
Guid.Parse("c9440510-9fa5-4004-8ba3-1c113f70fbc9"),
Guid.Parse("b36ba2ed-47ca-42ba-9897-bd08fcfebe37"),
Guid.Parse("1654fdb9-c213-4e55-8e72-554fb5b1e999"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("04bc5901-788e-4f88-bb08-58d13c6dba69"),
Guid.Parse("048e5429-e75e-4e8a-9d53-73ac20ed152c"),
Guid.Parse("5fa77fbe-5b4e-403c-808a-035292ade684"),
Guid.Parse("c67e73a7-666a-48ef-8d89-60f07dde4a97"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 132,
    Value = 
new System.Guid[4]
{
Guid.Parse("14b392cb-48d9-4727-8b46-5556c513679a"),
Guid.Parse("1560e7a2-800e-43c6-b4cf-1a698c475c91"),
Guid.Parse("37f10df5-51f1-4909-8048-2f1d25250067"),
Guid.Parse("dd80dfc0-4ff0-409e-aec4-2ff80d3a346b"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 105,
    Value = 
new System.Guid[3]
{
Guid.Parse("2dd1ae10-cc9d-428b-a836-ee131508b4d3"),
Guid.Parse("e28ffb42-94d9-438f-8c65-7895d2e22067"),
Guid.Parse("e95fe76b-7095-4fa1-ad26-69bdf6a3cdfc"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("1afd59fa-94ef-40f3-9e1b-61678b6bc0de"),
Guid.Parse("e1c65bfd-fc01-4285-89eb-be022239f8e9"),
Guid.Parse("b4b10197-78a0-4230-9c0a-645df86abafb"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("7e56e8cc-ceec-4218-b334-1add1b21724f"),
Guid.Parse("261277da-2292-4fc0-87da-a0572989a4ef"),
Guid.Parse("df3961b0-693b-44ab-83fe-e29624a62dba"),
},
},
            new GuidMArrayD1E1M
{
    Id = 136,
    Value = 
new System.Guid[4]
{
Guid.Parse("d3bd4652-d551-4431-af9d-b14b4cedac92"),
Guid.Parse("1d127f9f-cb9f-450c-aede-6d40b68c73e0"),
Guid.Parse("53b42912-7750-42b2-a670-3163e421f81b"),
Guid.Parse("9558bbe4-37ce-4ae8-b5cb-2d8744046477"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 111,
    Value = 
new System.Guid[3]
{
Guid.Parse("a0dbd642-942a-4e5f-bfbc-356a93de8129"),
Guid.Parse("ed1d8290-b9fe-4332-bc43-d1eb77703b38"),
Guid.Parse("527875a3-f749-4473-8526-e284db96da16"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("d3e9c92e-84bd-4b7c-aa49-2527ca76bed1"),
Guid.Parse("eb80bcec-3d3a-4418-8976-e99a8abecdba"),
Guid.Parse("600ee80c-ac37-458d-9b0e-3caa75c4cbc2"),
Guid.Parse("48672923-48c2-4735-b98b-b86bb5584247"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("30bb1f20-7e6a-4388-8a8a-0bbfcfbb796d"),
Guid.Parse("289a4b78-f0ce-4b3e-93d2-a67e47d576b8"),
Guid.Parse("803c9743-d48c-40d1-9af9-77041604fcf0"),
Guid.Parse("fe79548b-971d-45aa-8894-3741f887c93b"),
},
},
            new GuidMArrayD1E1M
{
    Id = 141,
    Value = 
new System.Guid[3]
{
Guid.Parse("7746fa7b-bf6d-4b56-9f97-04402c151b84"),
Guid.Parse("549a9ccb-4d82-45d4-84c4-cefefbb67353"),
Guid.Parse("da005257-6f6f-486a-9719-07b4d4232bd1"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 115,
    Value = 
new System.Guid[3]
{
Guid.Parse("56f48149-8288-4d1a-84af-db9efd2484b6"),
Guid.Parse("a4082080-51c2-4b3f-b184-cc6da8762252"),
Guid.Parse("0d56e5ae-52be-451c-bd2d-199a4210c0c6"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("829d02f6-3be5-4847-b076-9c4ce7fdbd7a"),
Guid.Parse("ef7db118-d7c5-405b-b3fd-ee6d48f3394c"),
Guid.Parse("2bb4d4e3-a06d-4349-a23f-d1eb5bc81820"),
Guid.Parse("50b4dbd4-4499-4ca3-b377-e655a82cf3e0"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("53058a48-2c76-4fc2-a22c-57cd0299a722"),
Guid.Parse("9b60b0eb-5304-461a-98a9-71c64b1e9d95"),
Guid.Parse("eb9512d5-9bc6-4f9d-8c6c-aaf8035bc1d4"),
},
},
            new GuidMArrayD1E1M
{
    Id = 149,
    Value = 
new System.Guid[3]
{
Guid.Parse("69009b22-02f8-490b-a4e5-92324edb6e74"),
Guid.Parse("ec62f33d-c003-4a3a-ac7d-e6ae22ab74fc"),
Guid.Parse("0b77848e-cc28-401e-84bd-a3fe5e8be776"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 119,
    Value = 
new System.Guid[4]
{
Guid.Parse("e15862d8-38e9-4e29-8114-eff9ebd2066b"),
Guid.Parse("0ce3ce52-0566-4145-bf8b-3426b3c307df"),
Guid.Parse("444c3076-b60e-4342-b4f7-9abf8e9e8571"),
Guid.Parse("ba803029-a0ea-48e7-8e1a-67a5890d0e79"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("31e6e82a-02cb-433f-b075-ccb51d106b2a"),
Guid.Parse("2d85b87b-1ee4-41f5-9135-5488e3ae3552"),
Guid.Parse("90863296-e00b-405d-a3ff-b9ac4b6c2bf2"),
Guid.Parse("3a1b27c4-1b80-4265-92bc-6c11ed094f61"),
},
},
            new GuidMArrayD1E1M
{
    Id = 153,
    Value = 
new System.Guid[4]
{
Guid.Parse("9a9058d8-952a-4563-8841-90f71198bcdd"),
Guid.Parse("6a4581bf-c13e-4c16-bbbb-bc2e624bac69"),
Guid.Parse("dcc57954-a655-4c65-aee4-a847e403813e"),
Guid.Parse("6608a785-172a-4ef8-8d9e-1ccc5ebc2ad9"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 125,
    Value = 
new System.Guid[3]
{
Guid.Parse("fc0d6a42-e4b4-4dfd-97c4-b6da00f762e2"),
Guid.Parse("f24cc799-5aca-4ff6-8ae7-41454dd541ef"),
Guid.Parse("fc407a2d-b653-4376-abe9-c1ed62eb29c4"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("af40ec8b-d980-465b-8d2d-b700fc8bf717"),
Guid.Parse("a33a0d4d-2bc0-41b8-8afd-80c45e3492be"),
Guid.Parse("b462debd-43d7-4381-b538-f5a26308fa8e"),
Guid.Parse("956ba67f-8aae-4fcb-bd5e-006c635395d2"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("c6b628ec-0505-40ab-8949-8d8ffd763363"),
Guid.Parse("ec7134c5-03b4-446f-bbdd-2e63ebb87ae0"),
Guid.Parse("577fd61f-e858-4276-9208-b3befe0122e6"),
},
},
            new GuidMArrayD1E1M
{
    Id = 158,
    Value = 
new System.Guid[4]
{
Guid.Parse("1a5e6701-4060-4820-967e-436e26f3a8be"),
Guid.Parse("4606e264-1448-4662-bb37-25a5921607e7"),
Guid.Parse("de03cf57-c1b0-446e-b750-1a605fc73c32"),
Guid.Parse("b5e96398-8907-4b79-a6f6-ae0bbd63b6b7"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 133,
    Value = 
new System.Guid[4]
{
Guid.Parse("4fd04020-7450-48c6-8c11-75a0d35a2755"),
Guid.Parse("cf523436-4cb0-40e2-a396-c57c28fdffc2"),
Guid.Parse("cb475a2c-5164-4c6f-94de-ffb7988f98e1"),
Guid.Parse("fa6dccf2-cd7a-4ebd-b741-24da6813e4f8"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("b0c423a3-f7d1-4cc6-bf20-de7a2a9c3701"),
Guid.Parse("71b61529-7ef8-431a-8e20-8289450d2c21"),
Guid.Parse("69d5126f-97bb-4f09-b793-0c07c073c9d1"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 162,
    Value = 
new System.Guid[3]
{
Guid.Parse("0c119dd5-4942-4665-89cc-6a13bed0d5e4"),
Guid.Parse("e7aed52d-f0b0-44ae-bc17-c81b2e02d639"),
Guid.Parse("f1094402-4107-4256-917e-fe095939da1a"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 139,
    Value = 
new System.Guid[4]
{
Guid.Parse("07c579fe-ac12-40ad-98c5-b12edf187c43"),
Guid.Parse("a0d0b572-d1b6-4b0f-a399-31d9b2e39f61"),
Guid.Parse("3927420d-70e9-495e-9296-76a63f883fa9"),
Guid.Parse("9200e103-348b-4ce0-864a-792e1253d4e8"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("484eb055-56c2-4157-a56d-4738ac201f90"),
Guid.Parse("89d37716-ecdc-4d2c-ae4b-8682d27fa0d0"),
Guid.Parse("5fdeea26-8f88-4bbf-b086-2c8b44a5bbe1"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("f6355c89-95f6-446d-afd0-bd9805b526ca"),
Guid.Parse("2dbb1f78-2e14-4395-8e1f-affe56f5b6b4"),
Guid.Parse("390f5f41-0cbb-4766-b498-79da40edd4ed"),
},
},
            new GuidMArrayD1E1M
{
    Id = 168,
    Value = 
new System.Guid[3]
{
Guid.Parse("79b6f1f3-4c57-4cfd-9b9c-e09bc294f195"),
Guid.Parse("ba481c69-8596-4483-83e0-4719aba92ba2"),
Guid.Parse("965a2719-5668-48b5-ba67-3197ca0ddb10"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 146,
    Value = 
new System.Guid[4]
{
Guid.Parse("47f27074-bb39-4e51-ba31-e19d015c0580"),
Guid.Parse("05c6501f-3d83-41cb-a5a6-14eaca5e1d19"),
Guid.Parse("b3c4eaa0-c6d0-4be1-b9f9-216973592dda"),
Guid.Parse("37ead8d2-99f0-4a95-9d23-bd00cf050fbd"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("ed562868-5579-4a1a-9453-356a46587839"),
Guid.Parse("daba9104-48b1-47c6-9472-3c351efa89af"),
Guid.Parse("784cbf3c-10b7-49e4-a5fe-3fb746fa862f"),
Guid.Parse("f4b80d26-2ed1-4caf-88b1-6ca7e1819425"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("865132c6-9a73-432c-972f-841e4bf87e84"),
Guid.Parse("8998dfa8-13c8-4cea-ab4e-00fbcbda6c8b"),
Guid.Parse("4750c216-4355-462b-a9c0-d47882484ef3"),
Guid.Parse("7013a227-d79a-4db6-b2fa-e2376dfa4fc2"),
},
},
            new GuidMArrayD1E1M
{
    Id = 176,
    Value = 
new System.Guid[4]
{
Guid.Parse("e8d9f4eb-5307-483d-ae7a-b536fc3f8b05"),
Guid.Parse("9946a4d7-01db-4f61-8560-7ba53571afc3"),
Guid.Parse("d68ccff6-dc9f-481f-96d9-86b54506c8c4"),
Guid.Parse("d69b415e-3496-4e3d-85af-e0e557bdff5f"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 148,
    Value = 
new System.Guid[4]
{
Guid.Parse("3e0e35aa-297b-499d-8d75-c81015782bf6"),
Guid.Parse("a6335d52-ee7f-4591-aa46-26f6b2843819"),
Guid.Parse("3ee74371-ae5f-48af-9825-0539a84bfb9d"),
Guid.Parse("a5eb2e6f-f825-467a-aa36-3d3f5963033c"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("e97a3a80-cb02-44a7-991d-ddbec5dbefcc"),
Guid.Parse("893a159c-3b7b-4fdb-afc4-cfa53613025f"),
Guid.Parse("334ef78f-5dc9-4b38-9b02-b423c234443a"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 183,
    Value = 
new System.Guid[4]
{
Guid.Parse("2bbfcea4-ab70-4869-991c-5a2305e0611e"),
Guid.Parse("f1c2cec2-d053-443f-abed-55e2363cbd10"),
Guid.Parse("6f7e0d54-2217-4215-9b63-f0387ce28b43"),
Guid.Parse("c630294a-5c63-4176-ad34-5a4d6b996edb"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 154,
    Value = 
new System.Guid[3]
{
Guid.Parse("c7f94c81-1afd-4199-9fcf-6f432d1ee8d9"),
Guid.Parse("90692eae-0eeb-4189-baa7-9593979071c0"),
Guid.Parse("6355135e-3013-471a-8769-fa5817181ce5"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("4f13eb8f-052b-4308-bb19-4b0c14ed030f"),
Guid.Parse("cd48f855-cb09-4dcc-a0d7-c7ee296b5ded"),
Guid.Parse("15144345-feb0-4c8f-a1a3-bc2c57e39b1c"),
Guid.Parse("123e0024-5ddd-4a04-b155-6c0ff9a59d85"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("15712d5b-d280-4f24-ad09-d91a5b27c0c6"),
Guid.Parse("5e788a15-f039-4afd-a27b-78b4660ad569"),
Guid.Parse("267dcccb-0b20-4ddd-b7e8-07d991354f83"),
Guid.Parse("fbc5d2b1-5942-420c-a712-eddc08ee66a2"),
},
},
            new GuidMArrayD1E1M
{
    Id = 186,
    Value = 
new System.Guid[4]
{
Guid.Parse("814fc366-3584-41ed-ab57-34880885ce51"),
Guid.Parse("22de8819-1bb7-4e44-b5c7-62b73aa6f476"),
Guid.Parse("9c44e2c9-84ac-447f-80de-f8ba7bfc4db9"),
Guid.Parse("b0ce90b3-9b1e-45c2-a0ae-aec4d23bfdc1"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 163,
    Value = 
new System.Guid[3]
{
Guid.Parse("48a414e2-315c-412e-b964-dd9b1530105a"),
Guid.Parse("3bfbf4ca-c151-4d2d-8f5b-2fbe021e928f"),
Guid.Parse("1b775c96-7848-40e2-972f-ef41ba9cfa96"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("5d722959-26c3-4698-a0e5-c0994a0d59b9"),
Guid.Parse("4f90e14e-a250-4919-8448-0a4d22342774"),
Guid.Parse("a421266b-b40b-46c4-b8d5-d19e6ce57e61"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("5f84ef9b-2539-4b7e-9bf3-5fa020f81345"),
Guid.Parse("91b898f9-9dcf-4209-b876-8cf96155f13b"),
Guid.Parse("16c697d7-a70f-49a5-81bb-29411f73a97c"),
Guid.Parse("ebc5ab0c-14f7-407e-993d-08834383d287"),
},
},
            new GuidMArrayD1E1M
{
    Id = 192,
    Value = 
new System.Guid[4]
{
Guid.Parse("c904407f-59e0-485f-94d4-458836a3ee59"),
Guid.Parse("9586e07e-edd7-437e-8db2-d3b73e138f11"),
Guid.Parse("42bae103-b126-4c7c-9aa9-ec9f44fa444e"),
Guid.Parse("421e534c-2105-4bf6-8545-ea4a5b24b132"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 164,
    Value = 
new System.Guid[4]
{
Guid.Parse("9d38dd13-bc8a-4cf4-a8b1-c2feab5dd9f3"),
Guid.Parse("37484d88-a199-40f1-9f8b-cd7303b843df"),
Guid.Parse("1eeeb22d-f446-4e4a-9c21-0b06cd22044b"),
Guid.Parse("7d00e808-6365-4f1c-b436-55bfda92fcb5"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 195,
    Value = 
new System.Guid[3]
{
Guid.Parse("cf186ebf-ec24-4008-a1d4-fcaa18741e1a"),
Guid.Parse("0b50c915-8c18-4b8a-8325-f2f0204a0c90"),
Guid.Parse("3c557045-2c15-40ec-904e-a8d69df3b2db"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 173,
    Value = 
new System.Guid[4]
{
Guid.Parse("8ac00c68-4880-40f6-9e3e-417a6998523a"),
Guid.Parse("8c5a3cc5-ad39-4007-9d4c-b6c48a381746"),
Guid.Parse("e1146b13-c5aa-470a-9829-977d6b2b5c64"),
Guid.Parse("0a58632d-5e1e-4e03-9833-da260be5f77d"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("d646d7b4-4500-443b-8809-8853ebc0d00b"),
Guid.Parse("2e877462-95a3-402e-bcf8-38b069e78a15"),
Guid.Parse("53f8ab8c-5177-4f4e-a6d0-e3ecffceb6f1"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 199,
    Value = 
new System.Guid[4]
{
Guid.Parse("01fd815a-d5a7-4b53-b62a-a5650fec3907"),
Guid.Parse("39947a7c-1b96-4741-97b4-9b38df7d7c5d"),
Guid.Parse("bc423ab9-dfa3-40e2-bdb2-598531392117"),
Guid.Parse("46b36448-122a-44bf-a1b0-92bfbac66897"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 174,
    Value = 
new System.Guid[3]
{
Guid.Parse("fbcfa14c-ce8b-49ec-8de9-e5f8c8d450e3"),
Guid.Parse("5596830c-fe37-4b61-bbaa-38730b58c9fc"),
Guid.Parse("2d87f01e-6450-4671-b064-fd4ca09fe844"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("638f30b1-c923-41c9-9538-981b7d01860a"),
Guid.Parse("b7c8316a-707c-4ada-86a1-65b207c0cf2c"),
Guid.Parse("dbb89b26-7919-4352-aa50-5589ba66f26a"),
Guid.Parse("371bbab8-fa53-4292-a03e-c35af990fbfb"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 208,
    Value = 
new System.Guid[3]
{
Guid.Parse("e1f6a93e-cef6-4266-a92f-6c02e44f3d80"),
Guid.Parse("87e2528c-f27a-4263-9e68-47448699c16d"),
Guid.Parse("2da837f0-a789-4234-8e52-e898cdd0959e"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 176,
    Value = 
new System.Guid[4]
{
Guid.Parse("ad021fac-b43f-46b4-a71d-40a97ffe44c5"),
Guid.Parse("ed8aeacb-7fa7-4943-8104-a062a474e87b"),
Guid.Parse("af75b663-5f99-42af-bbaa-2dcf1fd6fdd9"),
Guid.Parse("cf1d7014-4b7b-4c13-847a-c3f206602a5f"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("cde4a079-a0c5-4d68-805d-2fd1ee71ea35"),
Guid.Parse("9469973a-2fe4-490a-9d92-f29c4ce30a95"),
Guid.Parse("d383b794-cb53-43b2-8005-4c0448197e42"),
},
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.guidmarrayd1e1m(
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
            asPartInterface: typeof(IGuidMArrayMArrayD1)),
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
                    await ((IGuidMArrayMArrayD1)this).InsertModelDbConnectionAsync(
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
                     ((IGuidMArrayMArrayD1)this).InsertModelDbConnection(
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
FROM gedaqtests.guidmarrayd1e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(GuidMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayMArrayD1)),
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
                    var models = await ((IGuidMArrayMArrayD1)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    GuidMArrayD1E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IGuidMArrayMArrayD1)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    GuidMArrayD1E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

