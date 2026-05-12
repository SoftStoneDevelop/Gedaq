

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
    Id = 7,
    Value = 
new System.Guid[3]
{
Guid.Parse("62102b61-8d9c-4011-a9ba-1ef250e65eed"),
Guid.Parse("cfaec389-50f0-4403-a9e8-20b8d8274d3a"),
Guid.Parse("e22cfe48-cbfa-4856-a1b1-b4889b2aefac"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("d9cb2b64-24e1-4ab8-944d-3455f67610a0"),
Guid.Parse("84c726dd-9b42-402c-bd3e-f161768dac04"),
Guid.Parse("cc1a5c90-3527-4e64-b7c8-f962607f8655"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 13,
    Value = 
new System.Guid[3]
{
Guid.Parse("f615efe9-a36d-440a-b3f0-df573fd4d496"),
Guid.Parse("273b5de0-3c5a-4b19-8fa7-539e214d9e6f"),
Guid.Parse("6e9b44f8-4e0e-4ef4-972f-b57d514c7213"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 4,
    Value = 
new System.Guid[4]
{
Guid.Parse("708ef7e3-1f07-499e-a2ff-9ee6ded46c00"),
Guid.Parse("a54fb223-ec80-4f3a-bd7a-2fb187573d3e"),
Guid.Parse("b29bb671-a289-4b05-99b8-3eee47f0803a"),
Guid.Parse("1192932a-1af2-44f2-b9f2-53577224f05f"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("71970de2-551e-4b97-b135-2b0a1bfd361d"),
Guid.Parse("aa5709a6-ced4-472a-b881-f28376bebea6"),
Guid.Parse("3c059481-aa90-47d5-911e-f1730e9908e1"),
},
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 18,
    Value = 
new System.Guid[3]
{
Guid.Parse("6a791217-1af3-4c1c-81c5-d333978787e0"),
Guid.Parse("c3661a53-bf66-49e6-ae92-feb4c84b0614"),
Guid.Parse("cb4bbd67-eb22-4599-919d-9c9da2944c57"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("7dff7b19-1ff2-44d8-8c4b-0b405aedf360"),
Guid.Parse("7d7fe47c-94c3-48fc-91fc-586092162edd"),
Guid.Parse("e2cfb18d-110c-4cde-8038-357e3dbb66ae"),
Guid.Parse("e9c7aad3-afc8-4ab7-8be1-550530c560b5"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 25,
    Value = 
new System.Guid[4]
{
Guid.Parse("801c5997-b6fe-4ad5-bce6-f144edbcb192"),
Guid.Parse("97667fa7-d495-4081-8124-b30340df2b1e"),
Guid.Parse("ee23d234-f035-445a-a82d-acd4f2df2a01"),
Guid.Parse("7d5a313b-abbc-4097-b41d-10d010392f4b"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 10,
    Value = 
new System.Guid[3]
{
Guid.Parse("d3e50858-2a9a-441d-9b25-b53af7396e1e"),
Guid.Parse("105e73b5-a3f7-4a73-9615-c4f0d33554c5"),
Guid.Parse("e14ee701-648c-4112-a4bc-959140f7efec"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("68d14c87-52e7-4b3a-a848-275c680ec02c"),
Guid.Parse("2a95ff3e-484d-4f72-9691-31c39f5ddd7e"),
Guid.Parse("8e5c8b05-26cb-41e6-961f-12440897bd90"),
Guid.Parse("74f07740-4a11-4477-a1a0-df2cfe2df6a3"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 30,
    Value = 
new System.Guid[3]
{
Guid.Parse("6002dacc-ce52-40a2-af06-d4eb510b5e5d"),
Guid.Parse("bfe89645-5f8a-4d07-9ad2-a587970bee54"),
Guid.Parse("b4822c50-4ba5-410e-9aaa-bcfd58e6d79b"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("e8f45893-5be4-4a3c-886e-e10b9669b427"),
Guid.Parse("2e5a33e3-89cb-4315-a090-1dac475e2035"),
Guid.Parse("69bebb98-f25c-43f9-af56-fa2e4ef68ad8"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 36,
    Value = 
new System.Guid[4]
{
Guid.Parse("7743b783-69d6-473c-9eb3-8797c08f3330"),
Guid.Parse("e8167880-58c0-4699-a1c0-51b6b55abb3c"),
Guid.Parse("c27351cd-0351-4ae2-a8b1-02a1d4e8165a"),
Guid.Parse("89a98140-81b0-4153-9f56-108beb3a4525"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 11,
    Value = 
new System.Guid[3]
{
Guid.Parse("bfa1f988-ce66-4654-a952-cca4693aadc6"),
Guid.Parse("c476c910-f5a7-4bd1-bd72-d325ecbc129a"),
Guid.Parse("737a3e94-b7f6-47e0-a8c1-15b2372221a1"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("c01cdfc2-73b4-4a1f-92e1-8fc08f0fb3d0"),
Guid.Parse("4a41535d-7f2e-4b8a-9031-f91cab909af8"),
Guid.Parse("a5afb578-dc9c-48e0-9fc1-7e73f0351606"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 42,
    Value = 
new System.Guid[4]
{
Guid.Parse("d9b3e8aa-3390-456f-89c0-e7a3a9e45681"),
Guid.Parse("d860991c-26dd-4761-a8b5-85a8558aeb4d"),
Guid.Parse("a1f6ed15-5382-40d3-92ce-32488fe57ae4"),
Guid.Parse("656bfc47-4f41-4bb8-99b6-d86b62935237"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 47,
    Value = 
new System.Guid[4]
{
Guid.Parse("972ddde8-03b6-4002-b616-4df5655f9904"),
Guid.Parse("292712a2-ccf9-4a5e-8f0d-08d9861f52c3"),
Guid.Parse("0c85a5b1-9a3b-4aeb-9dd9-b54bbdce4d03"),
Guid.Parse("ee49ef30-6a62-42b0-b7c9-067b4f2cc13d"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 13,
    Value = 
new System.Guid[4]
{
Guid.Parse("7b244322-826c-42e3-bb87-2588d91a8fc1"),
Guid.Parse("ee9f7b66-1388-4674-ae48-3451bd7fe17e"),
Guid.Parse("b9df5c58-4fd6-46ad-8902-8285f6e2293c"),
Guid.Parse("917848b7-b32b-42e9-9c78-cafac5890182"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("058815c2-2fe1-493a-96af-d7ec95e42ce4"),
Guid.Parse("32c1cc56-4f3f-441d-b6ce-740f58f4a343"),
Guid.Parse("c75b633b-cf03-4975-a00f-96abe8fa683b"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("5d6b1cec-7fe7-4b32-83e0-0ee28d21b956"),
Guid.Parse("9ff966a1-4ff8-4ece-83ec-72a3aca55e1a"),
Guid.Parse("f06552d3-a8fe-43ba-96f8-a5d1e30fbe50"),
Guid.Parse("12f5a989-a109-46b2-aff5-2cbf16891b1c"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 48,
    Value = 
new System.Guid[3]
{
Guid.Parse("c7b1306f-d26b-4454-a3c4-401a3a63f48d"),
Guid.Parse("eabd093f-2751-4331-b83e-7ca38d17b31e"),
Guid.Parse("2fa2533f-a845-4b39-bb0f-8ecc3e29ccb7"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 52,
    Value = 
new System.Guid[4]
{
Guid.Parse("aa02ca6c-cfae-4447-876f-2cbcd5af6366"),
Guid.Parse("16019a51-7979-4115-8955-a040a1867483"),
Guid.Parse("6f602dcb-b9f7-4ca4-8e41-908f1bb04a62"),
Guid.Parse("38ca7fc1-ec6a-49b8-99ab-cb9537de5111"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 20,
    Value = 
new System.Guid[4]
{
Guid.Parse("19a50abb-0d10-4183-be3f-c85d46bced0c"),
Guid.Parse("398fc853-aed7-4625-aa5f-10be191daaa6"),
Guid.Parse("85abe2fa-82f3-4ccc-9622-5b7308262040"),
Guid.Parse("1f6102e3-6861-49e7-a42a-bab561fda13d"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("15701e16-6193-442f-93b9-7d28a9af0e5d"),
Guid.Parse("5eb71816-dfc7-437c-b56a-e6a03a78cf9d"),
Guid.Parse("6435527c-73e2-4017-b2f0-837a543e6a24"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 60,
    Value = 
new System.Guid[4]
{
Guid.Parse("b4d1939a-0305-4281-b094-4ee2e9ec0eb0"),
Guid.Parse("c343a0ae-39ab-4aa0-b139-e34b51d511ed"),
Guid.Parse("e36d9f0c-cc16-480e-8f12-5616956861e7"),
Guid.Parse("f2c1806c-12f3-4c05-a4e1-767192e607d8"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("0d17e3f9-be92-487e-8a0d-afb307fe2508"),
Guid.Parse("facd2149-e53e-4c6c-9647-85cf6e469c34"),
Guid.Parse("6ae463b8-07cf-4169-a893-7285d306cf98"),
Guid.Parse("abeb8838-a17a-4ecf-9390-71a5a74aadd8"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 65,
    Value = 
new System.Guid[4]
{
Guid.Parse("289e4e39-b331-4332-9bfa-222b605f4dee"),
Guid.Parse("49af8172-cd94-4de7-95f8-d051fac62d1e"),
Guid.Parse("4d682be2-3251-472d-8eb5-56f12ca6921d"),
Guid.Parse("de130da1-7efb-48e8-9ba4-0a88c905b823"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 29,
    Value = 
new System.Guid[3]
{
Guid.Parse("a731dff6-7259-4846-a435-9c9747450c57"),
Guid.Parse("a45bef86-90e6-46fb-97aa-a5b75a3328e4"),
Guid.Parse("109d66a1-1ab8-456f-98a3-284cf0e22cf8"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("4748415f-6d60-43d2-b101-317a1e26fdbe"),
Guid.Parse("29e663d6-9abd-45bc-8f60-8cbe7f6e1ac1"),
Guid.Parse("0e9e7452-dd5b-4cf7-88ce-8fc592036d9c"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 72,
    Value = 
new System.Guid[4]
{
Guid.Parse("009ae398-d6e8-4bd9-b72d-d9a5c873c20e"),
Guid.Parse("d3bd4abf-feff-4f50-9bfc-51fc967d4f89"),
Guid.Parse("9d976406-d432-4a20-bcac-7812db079eab"),
Guid.Parse("b701fa4a-6e73-4a0f-b695-13952fb0eca8"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 74,
    Value = 
new System.Guid[4]
{
Guid.Parse("9dffa3b6-acc7-4466-947e-8afe82998797"),
Guid.Parse("62b92bc1-37c9-4321-bfc2-0ee9d49a425b"),
Guid.Parse("89c89f2c-1616-407a-b31a-cf2946fab750"),
Guid.Parse("b21ddd20-e63f-4a56-906c-1e84b009e5cf"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 30,
    Value = 
new System.Guid[4]
{
Guid.Parse("d1be7f16-413f-4d4e-a97f-f1ff52b81e15"),
Guid.Parse("fce9d2cc-0bd5-4303-bcb2-297824b4cbd1"),
Guid.Parse("b1588370-a9ea-4dce-b116-b292e47ef424"),
Guid.Parse("a22f0b04-a268-4968-ab9b-83b7b7f0f457"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("ec4a3585-3829-4255-bbf1-0699429f9de1"),
Guid.Parse("13472d71-8bd5-4a1d-abd8-d475ee9bb465"),
Guid.Parse("d9b8f44c-a52d-4c27-91eb-1a12c012e380"),
Guid.Parse("9b1259fc-0b50-4973-ad4c-5a464526c028"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("c5fb370b-6486-4532-aac7-052243611091"),
Guid.Parse("3ca8eb6b-7e7d-4339-964f-381fa0496029"),
Guid.Parse("ce06cd8e-aa8a-4b48-9b7e-37386adec876"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 75,
    Value = 
new System.Guid[4]
{
Guid.Parse("10d8d948-9ba3-4ebb-a398-c345f9ea9311"),
Guid.Parse("53cd3b7c-e3fc-4c7b-8c8f-5a49b108742b"),
Guid.Parse("d1b30e50-b867-4a74-94d1-bb604114013d"),
Guid.Parse("8e9b8f6e-45de-48ea-8b75-b3eef2be68f1"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 79,
    Value = 
new System.Guid[3]
{
Guid.Parse("bcc0561b-5e90-4fbf-a8c7-6a819aa411a5"),
Guid.Parse("8003d444-79ca-42b9-9f8f-cabd25fba8a1"),
Guid.Parse("363d3a08-efe3-46d7-9d0d-0114d4834cf4"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 36,
    Value = 
new System.Guid[3]
{
Guid.Parse("104d6827-82f4-432e-af28-d8e9b63b73a4"),
Guid.Parse("2bcfd326-e312-49f8-aceb-93c6239ab0ca"),
Guid.Parse("62e48339-2d67-414a-bc20-ee7742c8b628"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("f6babfb4-0069-4862-a4b0-e16415082c2c"),
Guid.Parse("afabad1f-3194-4a8a-a393-cb0a3000cb41"),
Guid.Parse("89179f0d-2653-4fd7-a728-3627fa3fa396"),
Guid.Parse("39ee0894-5ab5-45c1-8eb2-f7c0bbe0eb54"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 81,
    Value = 
new System.Guid[4]
{
Guid.Parse("2de4189a-80bb-46fa-bb48-29e392880a34"),
Guid.Parse("f8c77748-0536-4a6f-8e6b-f52e3c2bb124"),
Guid.Parse("9cef6f06-4982-465d-9227-8bf2b5547310"),
Guid.Parse("b7d32f1a-2988-49c7-9746-e4ce47c31ca8"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 85,
    Value = 
new System.Guid[4]
{
Guid.Parse("cfc8e686-85d7-4df2-bdd0-37fe6f5c8388"),
Guid.Parse("781337c2-7c2e-4cb8-b284-859aac63f278"),
Guid.Parse("486b8243-bcfb-4ab3-bc97-b1829790f65f"),
Guid.Parse("bd81c221-0f13-482b-ade6-3d059ba030e3"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 45,
    Value = 
new System.Guid[4]
{
Guid.Parse("19b6fa2a-0f8b-4022-9288-ef5ff9ccb34e"),
Guid.Parse("3261b611-557c-4cdc-a01b-2530f618b096"),
Guid.Parse("889f628b-bad7-4af4-9cac-0f4c4bd4fda9"),
Guid.Parse("51fce8f3-42e9-451f-8d7b-4a133b4c8a48"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("945a8dad-b78f-4bd7-8613-18bd4324a131"),
Guid.Parse("98c4de01-a250-43ce-bd60-6126a5005a33"),
Guid.Parse("1aca67b3-523b-473d-9f30-cfc70c78ae2d"),
Guid.Parse("0b68c8a6-c8da-47fb-8756-d007d2920463"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("a65da5ba-924e-4312-a528-53a46848493f"),
Guid.Parse("40809d3c-aadb-47b3-a330-dba6d71531f6"),
Guid.Parse("a1ca7538-1c9b-4830-bf86-6bd4518cba4a"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 86,
    Value = 
new System.Guid[3]
{
Guid.Parse("65992272-a702-4eb4-b466-3400b27c3a37"),
Guid.Parse("c4842253-a7cb-46e3-b51d-ad81d4c8e0a7"),
Guid.Parse("41fdc66a-fb8c-4767-ae1d-8a8bbba7e10a"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 94,
    Value = 
new System.Guid[3]
{
Guid.Parse("0a594718-e309-48fc-8d9f-036ff6bf3b95"),
Guid.Parse("727fabec-0caa-4a67-ab57-2e632b3bfc0f"),
Guid.Parse("ea5c7883-39f8-45ba-beee-2b35cc892c80"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 52,
    Value = 
new System.Guid[4]
{
Guid.Parse("d4f4e059-3f79-432a-a7f0-c4b10c671e68"),
Guid.Parse("77256214-942e-4eab-b1b5-ca27262f010a"),
Guid.Parse("cbc7f594-2cc6-4e66-83d4-c4f5128494a3"),
Guid.Parse("1db6b097-1dfe-4fe2-bec7-f810f802a0c5"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("2f720d38-78c5-4b2e-8d0f-da815549be38"),
Guid.Parse("a86641be-f9a9-480d-9038-5fbf93fdb13a"),
Guid.Parse("590a5dc6-dfad-4467-a4ef-49cb30c5ff4f"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("789bb603-94d5-4434-b234-75e2858d40f1"),
Guid.Parse("433eb4b5-866a-4f65-a283-af76f0507bb6"),
Guid.Parse("15fda8d8-683c-44da-beb3-c8c9bf465d44"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 101,
    Value = 
new System.Guid[4]
{
Guid.Parse("5d4d022b-0af8-4860-9477-1a01d99a7849"),
Guid.Parse("7ca89c83-4cb6-4107-bb8e-57517da4cb41"),
Guid.Parse("e5ba4e56-3e95-413c-863d-8cf05389d05a"),
Guid.Parse("0f559fd5-e11f-4068-b343-796380930f08"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 105,
    Value = 
new System.Guid[4]
{
Guid.Parse("5cf15d11-7931-419d-9f34-fbf4b0f98852"),
Guid.Parse("b33e95bb-9fe5-4314-ae15-04da29ab1259"),
Guid.Parse("77d0d84e-966b-41b0-8b54-b79ec57b7a5b"),
Guid.Parse("558a1657-dc90-4a01-80a2-2f02be3cbc0c"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 54,
    Value = 
new System.Guid[4]
{
Guid.Parse("835fcc48-cbe1-40ff-b053-36798b72bf97"),
Guid.Parse("63c6d6c0-e812-4dc8-ae72-bd6e7d5f56fe"),
Guid.Parse("b1cb69ea-81a0-4455-a5a6-e8ced4c4f183"),
Guid.Parse("b059cea8-ffca-4792-a48c-e534f934d39f"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("6fc2aaf1-6540-41f8-bbf9-88a422987393"),
Guid.Parse("4b3fb615-2d77-43e5-be9a-d21e3df1de20"),
Guid.Parse("88a184db-cde8-4ef5-8e98-47f7d6fcf30d"),
},
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 114,
    Value = 
new System.Guid[3]
{
Guid.Parse("41337c0a-091b-42f2-a082-bcc36bbd13c4"),
Guid.Parse("5ec9d072-02f9-4e49-9c7a-07e28b546dac"),
Guid.Parse("c0058061-6e75-45d5-b33e-0c885f59bed2"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("5f8be8d9-b2ed-4bbd-b75f-3fe3a6be9297"),
Guid.Parse("52404145-7509-44b1-9c07-8e6c9dbb050a"),
Guid.Parse("7bf0fb60-cf37-4550-bf3f-b4fbecfd9640"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 120,
    Value = 
new System.Guid[4]
{
Guid.Parse("738f585a-578e-4dcf-b8a2-a0b816911e42"),
Guid.Parse("5a73eb76-08e9-4b7f-bdd1-cf5ad0360547"),
Guid.Parse("ada98528-7149-456f-aa38-92649ed5e4d0"),
Guid.Parse("2357f90c-6fbf-4b16-9895-3d92cb24e929"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 55,
    Value = 
new System.Guid[4]
{
Guid.Parse("facc69f8-df98-4665-9bae-d4d7dd97493f"),
Guid.Parse("35e8617c-2cf5-4ed1-8e91-d6831c8cb671"),
Guid.Parse("9b0c210b-96ce-452a-94ad-804e4206775e"),
Guid.Parse("d3a22e0d-1735-4d0f-89d1-810fe56a3338"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("cc0b7638-a68d-48ec-9cb6-6a63cbee925d"),
Guid.Parse("65880710-1187-4055-aa5d-5e52fb96d4d8"),
Guid.Parse("93513975-ff93-4660-b6e1-244c7b7f2a93"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("37eaca69-984b-4306-b56e-f544e11f442e"),
Guid.Parse("7b8fd917-52e9-4cac-9f90-57cc7a2f5ef5"),
Guid.Parse("11cbad99-6917-43ae-bd9a-7334b14e5404"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 123,
    Value = 
new System.Guid[4]
{
Guid.Parse("11e2e2c0-f674-4852-aff8-06ecb22f1c90"),
Guid.Parse("2e4f65a3-3d05-4bb8-9d86-2de267544f34"),
Guid.Parse("d2cb6e87-1982-4ad9-900b-56cb4572175c"),
Guid.Parse("8ea7cd4a-99b3-4e89-b4fa-479540db96c7"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 130,
    Value = 
new System.Guid[4]
{
Guid.Parse("6e329ba1-3011-42ff-94f8-80be79a42391"),
Guid.Parse("2782997f-7bb3-4f85-9092-a0e7fa82fc35"),
Guid.Parse("dc883f3d-8901-4471-b307-76a017d441a0"),
Guid.Parse("fd39cbb6-66d2-4fed-b00b-39b602bdc54c"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 64,
    Value = 
new System.Guid[4]
{
Guid.Parse("f38edb6d-7e3a-4f08-80b2-60a74d006d46"),
Guid.Parse("6270ce36-19eb-409c-92cf-c4dc09bcb034"),
Guid.Parse("5e5b897a-e9e7-4223-8574-afc71a923284"),
Guid.Parse("e8c18e51-c3c2-41f3-b9ee-220193967062"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("4e38b95d-9621-4786-a016-026af1982033"),
Guid.Parse("5e716f02-75c0-47b2-9338-bf1cee685a37"),
Guid.Parse("0b631d41-5ae4-4929-a872-196a75a89ea8"),
Guid.Parse("1d9e3d4c-06c1-41dc-8260-3efdabf48b0f"),
},
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 131,
    Value = 
new System.Guid[4]
{
Guid.Parse("a55c0b7b-0799-4694-b597-33f4a2edd62d"),
Guid.Parse("e8ac6d84-f7d6-404b-a5f5-ad28cf50a52d"),
Guid.Parse("e5190463-8d82-47a1-9f1c-259d51361f66"),
Guid.Parse("3d40cd2a-b95a-457f-9fd3-62759756d648"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("add73a60-082a-45ad-bedb-e4a49c44b377"),
Guid.Parse("25b5d877-cca4-4412-8f89-3efad0cff0fd"),
Guid.Parse("89457eb5-3f2c-46ba-ad7e-f9f3611d392e"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 135,
    Value = 
new System.Guid[4]
{
Guid.Parse("c062143d-865d-4303-bfef-290b4171d9c5"),
Guid.Parse("d2287aa5-db1e-4b6d-b334-d58ed77a6bc8"),
Guid.Parse("d9c8742d-2750-4d66-b495-5ba6fb1ecf9a"),
Guid.Parse("cf38d3a5-97ad-472a-9dc8-0e74cd6fae57"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 72,
    Value = 
new System.Guid[4]
{
Guid.Parse("372c73e4-cc82-4ddb-a417-965587962b08"),
Guid.Parse("ade9cd77-43c6-443e-b8d7-03560f3c4cbf"),
Guid.Parse("4aed549b-c78f-4fd8-9c8e-4a5b3b9326c1"),
Guid.Parse("034aa9b1-a841-4c28-b846-5fc022d964dd"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("ccd6a1d6-44d1-4674-b4fe-e4ca6e9f84ca"),
Guid.Parse("aca990ef-d920-4128-81a9-6bb92ae74c27"),
Guid.Parse("9e3158f5-acce-40ed-935a-54022555e0d6"),
},
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 143,
    Value = 
new System.Guid[4]
{
Guid.Parse("8f1c0157-ac2e-43e8-b961-c73343244b2c"),
Guid.Parse("e8697fe8-9ea2-425b-a4ce-e0d4d152f39d"),
Guid.Parse("9ceff1f4-91a5-49f5-a1a4-0ef19ee01a8e"),
Guid.Parse("cc7f5be9-4151-43dc-a84c-6298fcfa8801"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("c91d1d4e-25be-47cf-8a56-7237e7f67350"),
Guid.Parse("fbed53ce-2ba7-4b40-870b-dcac33a857bf"),
Guid.Parse("a2ec2670-b447-45a6-a9a9-3b7c42008418"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 150,
    Value = 
new System.Guid[3]
{
Guid.Parse("70387ad2-fffc-4b04-9881-4bd9cecc5e97"),
Guid.Parse("65cafd50-a2df-4b42-889f-cecbe92ec9ba"),
Guid.Parse("c8b38bc8-84c5-479f-bce5-57f4b0be1850"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 74,
    Value = 
new System.Guid[4]
{
Guid.Parse("22003477-161d-4d17-93f9-a0a43a21abba"),
Guid.Parse("49f4af3a-15b8-4a75-adfb-01e3981df0a4"),
Guid.Parse("97b1b3a5-265e-49b1-8a29-2fe8a3d18133"),
Guid.Parse("4e0751fe-c3d4-4a1e-888c-362f9f7e1e53"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("ac6f1d71-a4b6-46f3-a69f-03105baf5633"),
Guid.Parse("21e01d7f-7919-4c5c-ba21-1d358666f169"),
Guid.Parse("eead82cc-310f-4bd2-91a5-448d3ba26861"),
},
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 154,
    Value = 
new System.Guid[3]
{
Guid.Parse("2ff45a82-5c6b-4671-958f-c7a608bac454"),
Guid.Parse("4b08271f-e980-4ef6-a49a-064ffe3dc7ca"),
Guid.Parse("9513f18a-61fd-492f-92b4-eea7967acc15"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 160,
    Value = 
new System.Guid[3]
{
Guid.Parse("7d6b070e-e21b-4296-a626-4d2c90c2a5b0"),
Guid.Parse("c362a0f1-a6da-4f8b-9eea-598b4852fc26"),
Guid.Parse("739be307-ba8b-43dc-92e5-8a53682dec6d"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 77,
    Value = 
new System.Guid[4]
{
Guid.Parse("30dc0c06-56c4-4241-8da2-a983f2b008c2"),
Guid.Parse("a8966dc4-18d1-4a70-8906-2b023edb929e"),
Guid.Parse("c18d0fdf-de96-4c56-a313-461ae4c4c198"),
Guid.Parse("e223a19d-41d3-4719-9a0c-b518eb17a0fc"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("96ef9031-6dc9-4b35-9642-8aed13fb78f1"),
Guid.Parse("086f5b49-e0e4-40dd-bdbf-6a0f8ed1c7a4"),
Guid.Parse("900d75da-2e57-482a-8470-9435cea959ba"),
Guid.Parse("0a9ab787-2d13-44c3-87af-73fe5ac694e6"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 168,
    Value = 
new System.Guid[4]
{
Guid.Parse("6a8f6d21-945d-43cb-96c5-5f65722d3ee4"),
Guid.Parse("ec6f1fb4-04e8-429a-9110-699a990ed036"),
Guid.Parse("622b6f4a-60b7-45b7-b381-6bfc30f2aab4"),
Guid.Parse("c08e74a7-accb-433a-a75a-3850f823e657"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 177,
    Value = 
new System.Guid[4]
{
Guid.Parse("bf186bbd-cf2a-49ee-8486-2b79d7507de1"),
Guid.Parse("6c35b267-032e-4b68-aec3-673134bab014"),
Guid.Parse("69ed0184-2116-4027-9541-33514fc77c5e"),
Guid.Parse("8e092a6d-1ce4-4b3c-8508-5b6e98645740"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 79,
    Value = 
new System.Guid[3]
{
Guid.Parse("0d8c7b4f-5e5d-43e2-a244-c9bcd53abd2a"),
Guid.Parse("d546273d-2ac8-45ad-8981-f8a89da354c0"),
Guid.Parse("6c398336-97e3-4f39-8197-35321d7e7f88"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("66dbf910-2872-4ca6-beb6-0e19d9b77b3d"),
Guid.Parse("b31b7e9f-26a1-4282-b432-a107cd4b9abb"),
Guid.Parse("0a44e71d-4ea3-4b72-91d1-437e704f512f"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("672ee85e-a37f-48c3-adc3-6c33797d4159"),
Guid.Parse("76934080-a21a-4456-88dc-7557b561f2f6"),
Guid.Parse("e13adbed-4c2a-48d6-801c-64e7c4d74165"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 183,
    Value = 
new System.Guid[4]
{
Guid.Parse("2c8bac0f-02d9-4621-b631-bc42b24c1244"),
Guid.Parse("5758fb49-6738-43ac-be86-b339ebb17e3f"),
Guid.Parse("501fc30b-34e3-47ea-871e-1f2e0531d610"),
Guid.Parse("6a2391be-ccb6-4e6c-a05b-d017a9a047ac"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("d25c460a-1cc2-484c-bc29-435b5ba33de4"),
Guid.Parse("f2e71003-4a8d-4697-83ee-cc3565e84ab7"),
Guid.Parse("bbe05966-8a16-418b-96ea-d8b65b048309"),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("e8f45893-5be4-4a3c-886e-e10b9669b427"),
Guid.Parse("2e5a33e3-89cb-4315-a090-1dac475e2035"),
Guid.Parse("69bebb98-f25c-43f9-af56-fa2e4ef68ad8"),
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

                    nullable =  ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("c01cdfc2-73b4-4a1f-92e1-8fc08f0fb3d0"),
Guid.Parse("4a41535d-7f2e-4b8a-9031-f91cab909af8"),
Guid.Parse("a5afb578-dc9c-48e0-9fc1-7e73f0351606"),
}));
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
new System.Guid[4]
{
Guid.Parse("5d6b1cec-7fe7-4b32-83e0-0ee28d21b956"),
Guid.Parse("9ff966a1-4ff8-4ece-83ec-72a3aca55e1a"),
Guid.Parse("f06552d3-a8fe-43ba-96f8-a5d1e30fbe50"),
Guid.Parse("12f5a989-a109-46b2-aff5-2cbf16891b1c"),
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
new System.Guid[3]
{
Guid.Parse("15701e16-6193-442f-93b9-7d28a9af0e5d"),
Guid.Parse("5eb71816-dfc7-437c-b56a-e6a03a78cf9d"),
Guid.Parse("6435527c-73e2-4017-b2f0-837a543e6a24"),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("0d17e3f9-be92-487e-8a0d-afb307fe2508"),
Guid.Parse("facd2149-e53e-4c6c-9647-85cf6e469c34"),
Guid.Parse("6ae463b8-07cf-4169-a893-7285d306cf98"),
Guid.Parse("abeb8838-a17a-4ecf-9390-71a5a74aadd8"),
}));
                nullable = await ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("4748415f-6d60-43d2-b101-317a1e26fdbe"),
Guid.Parse("29e663d6-9abd-45bc-8f60-8cbe7f6e1ac1"),
Guid.Parse("0e9e7452-dd5b-4cf7-88ce-8fc592036d9c"),
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
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
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 143;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[34], false);
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[34], false);
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[34], false);
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
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
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 154;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[34], false);
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 168;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
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
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 86, query1, 120, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[15],_testData[34], false);
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
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 13, query1, 123, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
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
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 160, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[34], false);
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
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 86, query1, 168, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 135, query1, 160, query2))
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[34], false);
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
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 94, query1, 36, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[28],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 143, query1, 79, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[34], false);
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
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 130, query1, 30, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[29],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 86, 79))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[16], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[17], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[18], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[19], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[20], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[21], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[22], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[23], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 42, 94))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[34], false);
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
                ((IGuidMArrayuuidMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 75);
                var models = await ((IGuidMArrayuuidMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(20));

                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidMArrayuuidMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidMArrayuuidMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 18);
                var models =  ((IGuidMArrayuuidMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

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

