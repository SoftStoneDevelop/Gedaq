

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
    internal partial interface IGuidArrayuuidArray
    {
    }
    
    internal partial class GuidArrayuuidArray : IGuidArrayuuidArray
    {


#region TestData

        private readonly GuiduuidArray1M[] _testData = new GuiduuidArray1M[]
        {
            new GuiduuidArray1M
{
    Id = 7,
    Value = 
new System.Guid[3]
{
Guid.Parse("436b8fdd-c27c-45d2-a38b-f2505e145c21"),
Guid.Parse("08a7ac13-7ad1-4fac-88b8-e21ba5649ea8"),
Guid.Parse("27335f2b-8a3c-4da7-9348-c2ab1ce391a2"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("5f658516-74da-430d-b529-cb969d403f70"),
Guid.Parse("196a9457-940e-463b-8c43-9b9e301f1d9e"),
Guid.Parse("8710c483-1416-4a9e-855f-c5453d17b747"),
Guid.Parse("b290b108-8ea1-42fd-8288-f898ce55bded"),
},
},
            new GuiduuidArray1M
{
    Id = 10,
    Value = 
new System.Guid[3]
{
Guid.Parse("6eca1d14-3910-4ddd-9ff6-71c30b99ffa6"),
Guid.Parse("a53cf5da-1c87-4c49-a858-34f6e0ba6e63"),
Guid.Parse("0b91351e-e67b-4e37-893b-e0c5f3972f90"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 7,
    Value = 
new System.Guid[4]
{
Guid.Parse("85ce2857-7b77-4cc7-82ec-d5958ab993a1"),
Guid.Parse("63148332-6be8-48f7-b471-09ddcafb3fc9"),
Guid.Parse("a19d263a-d5a0-46b2-bdae-844329846f13"),
Guid.Parse("184e0f9e-7837-4345-972b-34d20eb1655c"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 18,
    Value = 
new System.Guid[4]
{
Guid.Parse("e09f1946-ef61-40d0-bca5-50facce8e67f"),
Guid.Parse("6f1ffb99-574c-4fa7-92a0-4fdfb056dc5f"),
Guid.Parse("4cac2a1e-4150-4eee-b6c4-d2120cd72249"),
Guid.Parse("985255b1-90c9-4257-a661-1c9913371c77"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("f68c7bdb-663c-4d2f-b146-266f14be1195"),
Guid.Parse("3fb21fa0-e34e-402d-b25b-ce3a05bbffe1"),
Guid.Parse("2114f92d-8072-4489-a9ab-ab569845c0ea"),
},
},
            new GuiduuidArray1M
{
    Id = 21,
    Value = 
new System.Guid[4]
{
Guid.Parse("1cc07912-c558-40fe-82f0-6ee913590f1e"),
Guid.Parse("3368367e-b057-4fc7-8cd9-29177c64c4d7"),
Guid.Parse("2d55b480-080e-46e7-a56a-adc04165a048"),
Guid.Parse("0d80f530-a50f-4ca4-836c-d9b4b062186b"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 8,
    Value = 
new System.Guid[3]
{
Guid.Parse("1af5610d-c6f7-464f-b9ed-b7bbe63dc542"),
Guid.Parse("c98b8f89-f463-4ef4-86c1-6d6338cbf894"),
Guid.Parse("a025fafd-bb4f-4b8a-bc3f-8c5e064fcc29"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("667343df-d51d-47a2-930e-9322eefa408b"),
Guid.Parse("8830c3a5-639b-4b90-8f4b-7295165971c3"),
Guid.Parse("4a70a747-1ca0-487e-8025-5c8c0a5bad95"),
},
},
            new GuiduuidArray1M
{
    Id = 26,
    Value = 
new System.Guid[3]
{
Guid.Parse("2e601665-9836-4217-bdb1-e1725d553369"),
Guid.Parse("48d05ebe-75d9-4f99-8d59-15f6fe271cef"),
Guid.Parse("655cfa08-63b5-4ce5-8563-e42779841b81"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 35,
    Value = 
new System.Guid[3]
{
Guid.Parse("10312824-60e1-4142-bd07-4c1a1c79b327"),
Guid.Parse("0f14746a-c91b-43f1-a36a-56259898f0a8"),
Guid.Parse("bbce2ac9-4f88-491d-bdfa-e969b6747c48"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 10,
    Value = 
new System.Guid[3]
{
Guid.Parse("b329a3ae-655d-404b-8d3b-a86a264751bb"),
Guid.Parse("2f337114-21fd-4848-a1e2-cd79e04a4ece"),
Guid.Parse("a63da565-7ee6-456b-8797-60f18f16f52f"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 43,
    Value = 
new System.Guid[4]
{
Guid.Parse("e2cdcfd6-0951-485f-bb8a-35041d0d1246"),
Guid.Parse("bde30c60-b7b0-4a50-b86f-bc7f8af172a9"),
Guid.Parse("06f8f285-1296-4890-9103-b89f8f501b7e"),
Guid.Parse("6117ccd3-a05d-48e1-908f-c75bc93f4ae9"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 49,
    Value = 
new System.Guid[3]
{
Guid.Parse("b895bf01-875d-4e7f-9fe8-f5ea3ea28e49"),
Guid.Parse("f920bf58-c35a-4a63-808b-fd8a7d6c87ab"),
Guid.Parse("70706931-372f-49b6-9c8b-9edcf2e827ff"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 17,
    Value = 
new System.Guid[3]
{
Guid.Parse("781a960a-8fae-4338-bb79-db21311c3a70"),
Guid.Parse("e5820e62-ea4b-48d8-aa30-ba0c6825f8e0"),
Guid.Parse("957fd665-de8d-4373-a8e4-9dd41781d654"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("3d0c4e7d-5522-4c1e-b402-35f4cc3e9e32"),
Guid.Parse("e05bd388-0ec5-4afb-8d20-90d8430e9703"),
Guid.Parse("61d3dd76-5d7c-475a-abe1-f490a2e75b4f"),
Guid.Parse("1bbdb7a8-4474-4476-9b87-0562ea5a7487"),
},
},
            new GuiduuidArray1M
{
    Id = 58,
    Value = 
new System.Guid[4]
{
Guid.Parse("5af894a8-f1f2-4754-a5c9-ed8324723686"),
Guid.Parse("810bcb23-8395-458d-b8d1-7421d5556af2"),
Guid.Parse("ea4235f3-bccd-46e9-8ef3-ed3d4f63a809"),
Guid.Parse("c3e227a5-2259-49f7-b847-c29ab5e6e652"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("970f9306-c642-4d8f-a463-d0159c754a08"),
Guid.Parse("6c77deef-d785-4ae4-8f43-c5615cacbff5"),
Guid.Parse("4947dc88-6a33-45aa-83f4-fe39aa13bf60"),
Guid.Parse("9dccd703-0808-4c0e-a9c8-e3a58a34d780"),
},
},
            new GuiduuidArray1M
{
    Id = 60,
    Value = 
new System.Guid[4]
{
Guid.Parse("0a12eea7-1bdb-4604-a921-c022e758a69a"),
Guid.Parse("26dfe575-eef4-42c6-ac51-ef6631ceb028"),
Guid.Parse("708951b4-da6c-43a6-abcf-82dbeec547de"),
Guid.Parse("ed78ab6c-aff2-40b3-9599-07660fd7a850"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 24,
    Value = 
new System.Guid[4]
{
Guid.Parse("77defee4-61c8-4932-bd9d-e045b6128771"),
Guid.Parse("0b71250b-df12-4632-997e-0236e826ed80"),
Guid.Parse("8bd3946f-321c-4a9f-8e8d-3a913e8464bc"),
Guid.Parse("14b1e46d-614c-4387-b424-b276c3c68ab5"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("66113121-0b5e-49f1-b144-d3b17a0dfa8c"),
Guid.Parse("67219c5a-4272-4e13-9d93-840ca58c6f43"),
Guid.Parse("e2f200f5-3434-4165-9579-4e0e5591aae1"),
Guid.Parse("b3ce3ab3-a903-4d48-86cb-8adbd03a4e72"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("4633e2a3-6a3c-4222-9e42-10e1e214fef5"),
Guid.Parse("c4c63be5-11a2-4bb6-be62-e53b140320e6"),
Guid.Parse("122c4e91-8b58-4656-88b9-b2dbda665706"),
Guid.Parse("0f26b112-d9f9-4717-9244-98f19ff9c18a"),
},
},
            new GuiduuidArray1M
{
    Id = 66,
    Value = 
new System.Guid[3]
{
Guid.Parse("bae4c79f-2c77-4b24-a284-19495b2fa0df"),
Guid.Parse("38060d25-f8d9-4a97-888c-f61431c76e3f"),
Guid.Parse("a4e60f42-36ef-4888-85ee-d9f0282865e1"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("e89bc09e-254d-4e76-8638-082dafd97826"),
Guid.Parse("875f7f7e-f1a4-47b1-9cab-643f74989200"),
Guid.Parse("1240a03f-d4ea-4702-a681-7b711e40bf3f"),
},
},
            new GuiduuidArray1M
{
    Id = 69,
    Value = 
new System.Guid[4]
{
Guid.Parse("956edbdc-2bdd-46ba-ad47-09a2b1e059e2"),
Guid.Parse("35fca692-1d1c-444f-88e0-d1820bad74c6"),
Guid.Parse("08187df5-9f56-447a-98f5-1ce0ff30358d"),
Guid.Parse("d8b338f3-030a-4ce2-8dfc-b7927f755875"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 27,
    Value = 
new System.Guid[3]
{
Guid.Parse("be75a618-c14f-4c6d-8316-c82c47b707e9"),
Guid.Parse("1f478cdc-d485-4dfd-9676-2a57cc88a6f3"),
Guid.Parse("3a317abf-51bf-442b-9ef4-7acf0f222a6b"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("8f3d2608-2e45-4f28-b40d-d55a06380de3"),
Guid.Parse("f3adaf5e-68fb-469b-ad72-80360922969a"),
Guid.Parse("f4ee8db3-8521-4921-a414-16dcf1dbd9b1"),
},
},
            new GuiduuidArray1M
{
    Id = 71,
    Value = 
new System.Guid[3]
{
Guid.Parse("339cf3da-0d17-4b7a-b63c-6b95b9bd49de"),
Guid.Parse("01922717-cfe1-4d42-8993-c6a428ecd09a"),
Guid.Parse("61a33565-0fb4-4e3a-85ff-eef70e92ef6b"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 72,
    Value = 
new System.Guid[4]
{
Guid.Parse("6d38f7b6-6238-43db-a653-221333297a77"),
Guid.Parse("1bf8e580-1897-4e5a-995f-64d9f570e888"),
Guid.Parse("a2b71ae8-abca-4be9-a9f9-c19d35c493c0"),
Guid.Parse("29a3610a-560c-44be-9e05-ac95cb4d9242"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 33,
    Value = 
new System.Guid[4]
{
Guid.Parse("242c9904-2fc1-44b0-94e3-2e89a76067e5"),
Guid.Parse("8e73b730-833a-45a4-8b81-fe28744ba969"),
Guid.Parse("51605982-836f-4509-b4c2-04a20820d038"),
Guid.Parse("048674f9-6962-412d-b883-78884d9e0cae"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("a2a7be55-788a-45c0-a5f9-b2d1436a12b3"),
Guid.Parse("5a2c98d6-93f5-46c0-a406-16f3267db53a"),
Guid.Parse("9bfb9dee-5511-4be1-97f2-1a14e8d4fb36"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("44e5c7b3-b114-4457-90bf-b86bab19a530"),
Guid.Parse("90b7d56a-b492-4984-a380-181a271a89d2"),
Guid.Parse("33c782a1-de7a-434a-8210-66a6855c2469"),
Guid.Parse("2fb932f2-23fc-4f3d-a976-d8420ac25919"),
},
},
            new GuiduuidArray1M
{
    Id = 79,
    Value = 
new System.Guid[3]
{
Guid.Parse("c7c48b3c-adef-4a37-8bd0-2804fb57cd9f"),
Guid.Parse("734ff05f-bd3e-4941-8357-db9dadac0095"),
Guid.Parse("fa150dfc-ef85-4d87-b1cd-70e0dbc6ade5"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("01140d00-1ae9-4a1e-acbb-54e3e520910a"),
Guid.Parse("6e4fb112-81f7-406a-8597-75fa8debc9df"),
Guid.Parse("02a95a98-0c65-4ee9-abed-cfd559557169"),
},
},
            new GuiduuidArray1M
{
    Id = 84,
    Value = 
new System.Guid[3]
{
Guid.Parse("9e91a8d1-4292-4f25-9d67-3c641b09385f"),
Guid.Parse("63a1f93c-a672-40c8-be25-8684beeb6d47"),
Guid.Parse("54b59a9b-b18e-4f90-8843-670f4fd7af66"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 42,
    Value = 
new System.Guid[4]
{
Guid.Parse("0c618579-4aaa-4963-ba2f-b2e331ae356c"),
Guid.Parse("4506fb85-deaf-49b2-a081-4af2263ec2a0"),
Guid.Parse("14910c4f-630b-493f-84fe-f40580471727"),
Guid.Parse("827f0eb0-2d3a-4279-850b-ac9653577594"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("99366dd8-bf1b-40fb-b2a8-653194fd0d46"),
Guid.Parse("9c480d47-ea13-4ee9-9f8b-50755d04b7c2"),
Guid.Parse("04a90459-9f0f-4ad8-81af-d41a2ac755e6"),
},
},
            new GuiduuidArray1M
{
    Id = 88,
    Value = 
new System.Guid[3]
{
Guid.Parse("2a8a2f02-f592-4819-bec9-a2b196575e70"),
Guid.Parse("5cb0ca58-f807-4edd-a783-a6323465a955"),
Guid.Parse("6e22546f-0aed-4db8-a239-c2797730e1e5"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("a245a67d-1758-4a39-a185-d3023a3edcf6"),
Guid.Parse("9496a293-aa33-4c55-b214-54d07073966e"),
Guid.Parse("a9f2f75c-d85d-4ceb-9254-9ff84eae0322"),
},
},
            new GuiduuidArray1M
{
    Id = 90,
    Value = 
new System.Guid[3]
{
Guid.Parse("24e186fc-7366-487d-a7f4-ce0a81c9c60b"),
Guid.Parse("4fe6a05a-f2d7-434e-a309-db1cba40e29c"),
Guid.Parse("cd94ed0a-3898-4d12-ab5f-21674576d94a"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 47,
    Value = 
new System.Guid[3]
{
Guid.Parse("52e989d9-fe67-4184-a60c-dc3de5033093"),
Guid.Parse("cdd60182-b761-4708-85a5-356303eb3661"),
Guid.Parse("480b362f-a0c1-4ceb-9941-faafdc6188b3"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 98,
    Value = 
new System.Guid[3]
{
Guid.Parse("5c1d0c77-2623-43e8-87d4-1b72201381d7"),
Guid.Parse("94faaa2e-a35d-4007-83d2-d854434c62e3"),
Guid.Parse("f9d14873-12dd-4361-bd57-03ce8327e5a8"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 105,
    Value = 
new System.Guid[3]
{
Guid.Parse("f1eb8900-aaab-4206-bdb1-f92b4f66320a"),
Guid.Parse("b8d74454-8d18-4325-bab3-cf8f67ba6c96"),
Guid.Parse("3f68621b-bf49-435c-b263-c984cf9e7349"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 49,
    Value = 
new System.Guid[3]
{
Guid.Parse("d22f2f29-a801-4a03-87a0-5b565d591f92"),
Guid.Parse("6038b033-fdfe-4d31-b101-502cf57804e2"),
Guid.Parse("b600f95f-ca3e-4745-8500-8a7502370483"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("19a4b3cf-cb1b-49a9-a102-a17659f94abc"),
Guid.Parse("ab7cd693-df7c-4ced-99dc-c5a0336e03fe"),
Guid.Parse("c3c924ac-1364-436e-a056-eca3f7f5f3b9"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("ebc06cfb-904d-40f0-9954-3469e33ac69d"),
Guid.Parse("677c7485-7437-45d7-b348-3e46db09bfe9"),
Guid.Parse("b7c363e7-18eb-4811-90e4-d1097e81d1c2"),
Guid.Parse("8210ac9b-72e2-4cde-8e3a-4ddbab83346d"),
},
},
            new GuiduuidArray1M
{
    Id = 114,
    Value = 
new System.Guid[4]
{
Guid.Parse("155c89c7-7d64-4de8-9e9c-e49b5c89bd8b"),
Guid.Parse("badbb454-25e8-4337-82b4-b8f40d8be8e0"),
Guid.Parse("38ce98db-177c-4cca-a27d-650857c0aa93"),
Guid.Parse("fab247ef-d1e9-4100-b407-dc65491d97d0"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("ed6b9729-9009-486d-9461-c1a4526e4a51"),
Guid.Parse("e79f4c0b-0ce1-430b-81ec-74377c8c32eb"),
Guid.Parse("83071206-ae4e-4641-aeac-04c7799a3514"),
},
},
            new GuiduuidArray1M
{
    Id = 121,
    Value = 
new System.Guid[4]
{
Guid.Parse("9a7c94ab-db25-4bd0-8d52-8d4a9bcb37c6"),
Guid.Parse("ebf8deb2-86ff-4e2a-9c64-51df87fbf44e"),
Guid.Parse("9d6fb575-a495-4c8e-b169-6a4ac1f11d0b"),
Guid.Parse("e020f9d3-42eb-499c-b98d-5af04c816006"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 52,
    Value = 
new System.Guid[4]
{
Guid.Parse("5471381f-6f65-4b44-9735-65c29ffa898c"),
Guid.Parse("c21660c5-1b6c-4acf-922a-1ac317b4a0ea"),
Guid.Parse("a5a3163c-4582-4434-9aa2-6b761d100733"),
Guid.Parse("1e90b18a-d9d2-4177-b65c-7ef521de5298"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("17c6ed36-c823-47e9-b87c-e31ce3bca34b"),
Guid.Parse("2550dec6-4f81-4090-b0cf-5f905f50dcbd"),
Guid.Parse("da085785-5dfd-4194-9ae3-79889b4f1a7f"),
Guid.Parse("c4230b85-7840-49e5-9ffc-2a04671efc6b"),
},
},
            new GuiduuidArray1M
{
    Id = 125,
    Value = 
new System.Guid[3]
{
Guid.Parse("ea982620-253b-42be-88f2-f5800e5b38e4"),
Guid.Parse("ffbba83b-f839-4b79-81f6-c86064f1f8e7"),
Guid.Parse("ecdfbe7f-f050-4260-9da8-2948c04a4def"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 128,
    Value = 
new System.Guid[3]
{
Guid.Parse("46bd789e-df9e-42ed-9e39-02d1aeaad586"),
Guid.Parse("2323c68f-814b-4234-98a2-518e5f5cb1bf"),
Guid.Parse("83dcd7e5-f8d3-4b87-8566-7ad4c2f644e9"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 58,
    Value = 
new System.Guid[4]
{
Guid.Parse("22f715ee-4611-4286-a8d5-252bc23a224b"),
Guid.Parse("bb95002a-7357-467c-84bc-5678f7b895cc"),
Guid.Parse("06f1caa4-b11d-42aa-b61b-954c86885cfb"),
Guid.Parse("005adf15-38fd-4042-82fd-927b14f5dfc8"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("0619d11a-cd83-46e6-8d8e-7c1108e09564"),
Guid.Parse("74c37ca6-bb2d-4f0f-9f32-1e80b935cbe6"),
Guid.Parse("82c6014b-9c7d-4466-82e7-387d42c77908"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 134,
    Value = 
new System.Guid[3]
{
Guid.Parse("a4e15ac6-4c54-48bf-9fc3-393f40c43905"),
Guid.Parse("47074c52-bcac-442b-b810-e2d09bfd8c24"),
Guid.Parse("a69a9984-6fb0-440c-b024-20a4ffd97984"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("caeaf2a4-84ff-4c0f-b8de-1c5d1e3c1d45"),
Guid.Parse("c6ad3fae-7299-49ad-9d90-ee5e45d8e03c"),
Guid.Parse("a4d28470-1295-426c-96b5-ba9b9e3c4716"),
},
},
            new GuiduuidArray1M
{
    Id = 140,
    Value = 
new System.Guid[4]
{
Guid.Parse("2c67391c-a24f-469a-849c-4f432ab948e5"),
Guid.Parse("84a1be92-846f-4465-9c09-b60662b19643"),
Guid.Parse("62d154a3-50bd-4bb0-ab4b-91b33beec1ee"),
Guid.Parse("42ed2b1b-94bc-4360-8633-f3121cefc56d"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 59,
    Value = 
new System.Guid[3]
{
Guid.Parse("38efee0a-27bf-4008-b8b3-6d055eb21700"),
Guid.Parse("6f504f10-a34d-49b9-a096-eafd2b38bfc3"),
Guid.Parse("3150f167-f4b5-4332-81e5-f769c3201260"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("9b0b7305-f9a3-475e-b529-05331dfccafd"),
Guid.Parse("89de467a-cd7f-45fc-ab9d-43d388c8ca9a"),
Guid.Parse("1397f9e0-30b0-401f-8959-d008bd005d8b"),
Guid.Parse("0ea11667-fc22-4238-8fc2-35a248349004"),
},
},
            new GuiduuidArray1M
{
    Id = 147,
    Value = 
new System.Guid[4]
{
Guid.Parse("6e751f47-8338-45f9-a75d-43c952d5c6ed"),
Guid.Parse("8dde6651-5f2c-4363-9b87-a66ce1dd525d"),
Guid.Parse("4510944c-9e0e-4a18-b638-649ca6f07eb3"),
Guid.Parse("befb496f-ad71-4e99-8d9a-4a3cbce71cd1"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("d1eee6bc-4b7e-4f08-a8f4-54a73e3519e4"),
Guid.Parse("9172d73b-281e-478a-9dca-0dda412a42a6"),
Guid.Parse("c820da94-e0c6-4f02-9364-78226975ed68"),
Guid.Parse("0b22aa97-b02e-4182-9180-aa479ce9c4f6"),
},
},
            new GuiduuidArray1M
{
    Id = 153,
    Value = 
new System.Guid[4]
{
Guid.Parse("e4d592d8-bc31-44a3-8175-e7d4de0f3a05"),
Guid.Parse("ae941b45-b0f7-4126-ab9a-706e7cf58e35"),
Guid.Parse("a1f3a589-d125-4812-ac10-b653eba03bca"),
Guid.Parse("19a956de-3947-4c3f-baed-6e16c6dc92b1"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 63,
    Value = 
new System.Guid[4]
{
Guid.Parse("4e1ce892-4b8c-4aa5-860f-baf63f51810e"),
Guid.Parse("9a98cb5f-1951-4492-af87-6316d3fd7a7b"),
Guid.Parse("84eb6435-52f6-42c1-a9c0-fa5dbc9f8b83"),
Guid.Parse("97fb45e5-f554-456e-aa7b-a8fec070a79b"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("fb97ff7e-5877-44ec-becd-a12201acc647"),
Guid.Parse("b1c376f5-4196-421a-8792-c0e89ff928ad"),
Guid.Parse("59a9bb58-0cb9-45dc-8c6b-274c6ded105b"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("08858c38-23e4-4ce1-b142-ab106bd7b081"),
Guid.Parse("64edf947-f2c2-4dc9-972c-cf16be68c8be"),
Guid.Parse("522f9cb5-6d90-47da-8466-2f086df4a61d"),
},
},
            new GuiduuidArray1M
{
    Id = 154,
    Value = 
new System.Guid[3]
{
Guid.Parse("6bca9101-72de-482e-bb88-b30c6d19ee92"),
Guid.Parse("b7ab56b7-a0b2-4622-8568-77f7923999bc"),
Guid.Parse("8e94adbb-de0f-40ae-a835-19931f409657"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 163,
    Value = 
new System.Guid[4]
{
Guid.Parse("c44ca5cd-4fa3-4243-a9ba-f76f9e0fc317"),
Guid.Parse("69b55f41-2d21-4e20-ae5d-515fa23f104f"),
Guid.Parse("c5e8836f-6025-45ea-8d15-51b74d6b074a"),
Guid.Parse("7392ff19-1404-4e44-8434-d65e6f3b796e"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 70,
    Value = 
new System.Guid[4]
{
Guid.Parse("ec029e13-1c2e-42ab-91d9-80f762130ccd"),
Guid.Parse("96e3fe76-9c90-4fa1-aebd-c3ec1ba89ac0"),
Guid.Parse("7de0ebd2-47ce-4433-b62e-c2ab6a10e858"),
Guid.Parse("8fe4f8fc-5d22-4568-bf0a-c772c4500f31"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("48e9340a-1fa8-4d13-a37a-5a3d18d2a6b5"),
Guid.Parse("a066e4c3-7708-4b1a-8843-e05a2c5b4dc7"),
Guid.Parse("9dd1e99f-920e-41d8-a5df-0044c0e01efe"),
Guid.Parse("e783c8bf-7318-45ce-9483-07b3d685b459"),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray1mi(
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
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
INSERT INTO public.guiduuidarray1mi(
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
            queryMapTypes: [typeof(GuiduuidArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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

                changedRows =  ((IGuidArrayuuidArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidArrayuuidArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IGuidArrayuuidArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidArrayuuidArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IGuidArrayuuidArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IGuidArrayuuidArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray1m(
	id,
    value,
    nullablevalue,
    guiduuidarray1mi_id
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
            asPartInterface: typeof(IGuidArrayuuidArray)), 
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
                methodParametrName: "guiduuidarray1mi_id", 
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
                changedRows =  ((IGuidArrayuuidArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IGuidArrayuuidArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IGuidArrayuuidArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IGuidArrayuuidArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray1m(
	id,
    value,
    nullablevalue,
    guiduuidarray1mi_id
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
    guiduuidarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(GuiduuidArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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

                    nullable =  ((IGuidArrayuuidArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable =  ((IGuidArrayuuidArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable = await ((IGuidArrayuuidArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
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

                    nullable = await ((IGuidArrayuuidArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("3d0c4e7d-5522-4c1e-b402-35f4cc3e9e32"),
Guid.Parse("e05bd388-0ec5-4afb-8d20-90d8430e9703"),
Guid.Parse("61d3dd76-5d7c-475a-abe1-f490a2e75b4f"),
Guid.Parse("1bbdb7a8-4474-4476-9b87-0562ea5a7487"),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray1m(
	id,
    value,
    nullablevalue,
    guiduuidarray1mi_id
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
    guiduuidarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(GuiduuidArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
                methodParametrName: "guiduuidarray1mi_id", 
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
                nullable =  ((IGuidArrayuuidArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("970f9306-c642-4d8f-a463-d0159c754a08"),
Guid.Parse("6c77deef-d785-4ae4-8f43-c5615cacbff5"),
Guid.Parse("4947dc88-6a33-45aa-83f4-fe39aa13bf60"),
Guid.Parse("9dccd703-0808-4c0e-a9c8-e3a58a34d780"),
}));
                nullable =  ((IGuidArrayuuidArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("4633e2a3-6a3c-4222-9e42-10e1e214fef5"),
Guid.Parse("c4c63be5-11a2-4bb6-be62-e53b140320e6"),
Guid.Parse("122c4e91-8b58-4656-88b9-b2dbda665706"),
Guid.Parse("0f26b112-d9f9-4717-9244-98f19ff9c18a"),
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
                nullable = await ((IGuidArrayuuidArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("e89bc09e-254d-4e76-8638-082dafd97826"),
Guid.Parse("875f7f7e-f1a4-47b1-9cab-643f74989200"),
Guid.Parse("1240a03f-d4ea-4702-a681-7b711e40bf3f"),
}));
                nullable = await ((IGuidArrayuuidArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("8f3d2608-2e45-4f28-b40d-d55a06380de3"),
Guid.Parse("f3adaf5e-68fb-469b-ad72-80360922969a"),
Guid.Parse("f4ee8db3-8521-4921-a414-16dcf1dbd9b1"),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidArray1M> models = null;

                models =  ((IGuidArrayuuidArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((IGuidArrayuuidArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((IGuidArrayuuidArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((IGuidArrayuuidArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidArray1M> models = null;

                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray1M), typeof(FlatGuiduuidArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
FROM public.guiduuidarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidArray1M>();
                var models2 = new List<FlatGuiduuidArray1M>();
                await ((IGuidArrayuuidArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidArray1M>();
                var models2 = new List<FlatGuiduuidArray1M>();
                ((IGuidArrayuuidArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
FROM public.guiduuidarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IGuidArrayuuidArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidArrayuuidArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray1m m
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
                var models = await ((IGuidArrayuuidArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IGuidArrayuuidArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray1M), typeof(FlatGuiduuidArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
FROM public.guiduuidarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidArray1M>();
                var models2 = new List<FlatGuiduuidArray1M>();
                await ((IGuidArrayuuidArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidArray1M>();
                var models2 = new List<FlatGuiduuidArray1M>();
                ((IGuidArrayuuidArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
FROM public.guiduuidarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidArrayuuidArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidArrayuuidArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray1m m
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(GuiduuidArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
                var models = await ((IGuidArrayuuidArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IGuidArrayuuidArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray1M), typeof(FlatGuiduuidArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidArray1M>();
                var models2 = new List<FlatGuiduuidArray1M>();
                await((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 43;
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var firstItems2 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems2 = new List<FlatGuiduuidArray1M>();
                await ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var firstItems2 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                await ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[29], false);
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidArray1M>();
                var models2 = new List<FlatGuiduuidArray1M>();
                ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var firstItems2 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems2 = new List<FlatGuiduuidArray1M>();
                 ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var firstItems2 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                 ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 153;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[29], false);
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
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems2 = new List<FlatGuiduuidArray1M>();
                await ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[29], false);
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[29], false);
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
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems2 = new List<FlatGuiduuidArray1M>();
                 ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[29], false);
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
FROM public.guiduuidarray1m m
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
                var models = await((IGuidArrayuuidArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        GuiduuidArray1M.AssertModel(models[0],_testData[11], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[12], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        GuiduuidArray1M.AssertModel(models[0],_testData[4], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[5], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[6], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[7], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[8], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[9], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[10], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[11], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[12], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[21],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[22],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[23],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[24],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[25],_testData[29], false);
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
                var models = ((IGuidArrayuuidArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        GuiduuidArray1M.AssertModel(models[0],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        GuiduuidArray1M.AssertModel(models[0],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray1M), typeof(FlatGuiduuidArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidArray1M>();
                var models2 = new List<FlatGuiduuidArray1M>();
                await((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var firstItems2 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems2 = new List<FlatGuiduuidArray1M>();
                await ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 26, query1, 128, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[29], false);
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var firstItems2 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                await ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 49, query1, 10, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[27],_testData[29], false);
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidArray1M>();
                var models2 = new List<FlatGuiduuidArray1M>();
                ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var firstItems2 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems2 = new List<FlatGuiduuidArray1M>();
                 ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 98, query1, 69, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[29], false);
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var firstItems2 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                 ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 84, query1, 69, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 153, query1, 71, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[29], false);
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems2 = new List<FlatGuiduuidArray1M>();
                await ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 58, query1, 26, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[24],_testData[29], false);
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 125, query1, 26, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[19],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[20],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[21],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[22],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[23],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[24],_testData[29], false);
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems2 = new List<FlatGuiduuidArray1M>();
                 ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 90, query1, 26, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[24],_testData[29], false);
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
FROM public.guiduuidarray1m m
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(GuiduuidArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
                var models = await((IGuidArrayuuidArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelBatchAsync(connection, 58, 18))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        GuiduuidArray1M.AssertModel(models[0],_testData[9], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[10], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[11], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[12], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        GuiduuidArray1M.AssertModel(models[0],_testData[3], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[4], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[5], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[6], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[7], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[8], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[9], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[10], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[11], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[12], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[21],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[22],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[23],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[24],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[25],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[26],_testData[29], false);
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
                var models = ((IGuidArrayuuidArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelBatch(connection, 35, 18))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        GuiduuidArray1M.AssertModel(models[0],_testData[6], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[7], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[8], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[9], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[10], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[11], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[12], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[21],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[22],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        GuiduuidArray1M.AssertModel(models[0],_testData[3], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[4], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[5], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[6], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[7], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[8], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[9], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[10], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[11], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[12], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[21],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[22],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[23],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[24],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[25],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[26],_testData[29], false);
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
                await using var cmd = await ((IGuidArrayuuidArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 134);
                var models = await ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
GuiduuidArray1M.AssertModel(models[0],_testData[25], false);GuiduuidArray1M.AssertModel(models[1],_testData[26], false);GuiduuidArray1M.AssertModel(models[2],_testData[27], false);GuiduuidArray1M.AssertModel(models[3],_testData[28], false);GuiduuidArray1M.AssertModel(models[4],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidArrayuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 10);
                var models =  ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
GuiduuidArray1M.AssertModel(models[0],_testData[2], false);GuiduuidArray1M.AssertModel(models[1],_testData[3], false);GuiduuidArray1M.AssertModel(models[2],_testData[4], false);GuiduuidArray1M.AssertModel(models[3],_testData[5], false);GuiduuidArray1M.AssertModel(models[4],_testData[6], false);GuiduuidArray1M.AssertModel(models[5],_testData[7], false);GuiduuidArray1M.AssertModel(models[6],_testData[8], false);GuiduuidArray1M.AssertModel(models[7],_testData[9], false);GuiduuidArray1M.AssertModel(models[8],_testData[10], false);GuiduuidArray1M.AssertModel(models[9],_testData[11], false);GuiduuidArray1M.AssertModel(models[10],_testData[12], false);GuiduuidArray1M.AssertModel(models[11],_testData[13], false);GuiduuidArray1M.AssertModel(models[12],_testData[14], false);GuiduuidArray1M.AssertModel(models[13],_testData[15], false);GuiduuidArray1M.AssertModel(models[14],_testData[16], false);GuiduuidArray1M.AssertModel(models[15],_testData[17], false);GuiduuidArray1M.AssertModel(models[16],_testData[18], false);GuiduuidArray1M.AssertModel(models[17],_testData[19], false);GuiduuidArray1M.AssertModel(models[18],_testData[20], false);GuiduuidArray1M.AssertModel(models[19],_testData[21], false);GuiduuidArray1M.AssertModel(models[20],_testData[22], false);GuiduuidArray1M.AssertModel(models[21],_testData[23], false);GuiduuidArray1M.AssertModel(models[22],_testData[24], false);GuiduuidArray1M.AssertModel(models[23],_testData[25], false);GuiduuidArray1M.AssertModel(models[24],_testData[26], false);GuiduuidArray1M.AssertModel(models[25],_testData[27], false);GuiduuidArray1M.AssertModel(models[26],_testData[28], false);GuiduuidArray1M.AssertModel(models[27],_testData[29], false);
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
FROM public.binary_guiduuidarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(GuiduuidArray1MIWA),
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
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidArrayuuidArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidArrayuuidArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<GuiduuidArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidArrayuuidArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidArrayuuidArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(GuiduuidArray1MI),
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
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray1MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidArrayuuidArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidArrayuuidArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<GuiduuidArray1MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidArrayuuidArray)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidArrayuuidArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
guiduuidarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(GuiduuidArray1M),
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
            asPartInterface: typeof(IGuidArrayuuidArray))]
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
FROM public.binary_guiduuidarray1m m
LEFT JOIN public.binary_guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(GuiduuidArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(5)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<GuiduuidArray1M>(15);

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
                ((IGuidArrayuuidArray)this).ImportModel(connection, importCollection);
                var models = ((IGuidArrayuuidArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                GuiduuidArray1M.AssertModel(models[0],_testData[0], false);
                GuiduuidArray1M.AssertModel(models[1],_testData[1], false);
                GuiduuidArray1M.AssertModel(models[2],_testData[2], false);
                GuiduuidArray1M.AssertModel(models[3],_testData[3], false);
                GuiduuidArray1M.AssertModel(models[4],_testData[4], false);
                GuiduuidArray1M.AssertModel(models[5],_testData[5], false);
                GuiduuidArray1M.AssertModel(models[6],_testData[6], false);
                GuiduuidArray1M.AssertModel(models[7],_testData[7], false);
                GuiduuidArray1M.AssertModel(models[8],_testData[8], false);
                GuiduuidArray1M.AssertModel(models[9],_testData[9], false);
                GuiduuidArray1M.AssertModel(models[10],_testData[10], false);
                GuiduuidArray1M.AssertModel(models[11],_testData[11], false);
                GuiduuidArray1M.AssertModel(models[12],_testData[12], false);
                GuiduuidArray1M.AssertModel(models[13],_testData[13], false);
                GuiduuidArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((IGuidArrayuuidArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IGuidArrayuuidArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                GuiduuidArray1M.AssertModel(models[0],_testData[0], false);
                GuiduuidArray1M.AssertModel(models[1],_testData[1], false);
                GuiduuidArray1M.AssertModel(models[2],_testData[2], false);
                GuiduuidArray1M.AssertModel(models[3],_testData[3], false);
                GuiduuidArray1M.AssertModel(models[4],_testData[4], false);
                GuiduuidArray1M.AssertModel(models[5],_testData[5], false);
                GuiduuidArray1M.AssertModel(models[6],_testData[6], false);
                GuiduuidArray1M.AssertModel(models[7],_testData[7], false);
                GuiduuidArray1M.AssertModel(models[8],_testData[8], false);
                GuiduuidArray1M.AssertModel(models[9],_testData[9], false);
                GuiduuidArray1M.AssertModel(models[10],_testData[10], false);
                GuiduuidArray1M.AssertModel(models[11],_testData[11], false);
                GuiduuidArray1M.AssertModel(models[12],_testData[12], false);
                GuiduuidArray1M.AssertModel(models[13],_testData[13], false);
                GuiduuidArray1M.AssertModel(models[14],_testData[14], false);
                GuiduuidArray1M.AssertModel(models[15],_testData[15], false);
                GuiduuidArray1M.AssertModel(models[16],_testData[16], false);
                GuiduuidArray1M.AssertModel(models[17],_testData[17], false);
                GuiduuidArray1M.AssertModel(models[18],_testData[18], false);
                GuiduuidArray1M.AssertModel(models[19],_testData[19], false);
                GuiduuidArray1M.AssertModel(models[20],_testData[20], false);
                GuiduuidArray1M.AssertModel(models[21],_testData[21], false);
                GuiduuidArray1M.AssertModel(models[22],_testData[22], false);
                GuiduuidArray1M.AssertModel(models[23],_testData[23], false);
                GuiduuidArray1M.AssertModel(models[24],_testData[24], false);
                GuiduuidArray1M.AssertModel(models[25],_testData[25], false);
                GuiduuidArray1M.AssertModel(models[26],_testData[26], false);
                GuiduuidArray1M.AssertModel(models[27],_testData[27], false);
                GuiduuidArray1M.AssertModel(models[28],_testData[28], false);
                GuiduuidArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    guiduuidarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(GuiduuidArray1M)],
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
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IGuidArrayuuidArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidArrayuuidArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA)],
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
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidArrayuuidArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((IGuidArrayuuidArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_guiduuidarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MI)],
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
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidArrayuuidArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((IGuidArrayuuidArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

