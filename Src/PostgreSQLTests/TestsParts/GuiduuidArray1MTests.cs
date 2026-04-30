

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
    Id = 4,
    Value = 
new System.Guid[4]
{
Guid.Parse("6cef571d-bc90-4901-ae0f-58684c493a8b"),
Guid.Parse("2d0c9459-1e11-4c89-9c88-b79f7c1150bd"),
Guid.Parse("310e25d2-c700-4122-9df4-9b5cef0c2a3c"),
Guid.Parse("93c49311-f5ca-44c0-b9e8-7e9aced2a719"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("b68f25b2-2c40-40ad-b536-9a21396dc33e"),
Guid.Parse("c45ed171-f109-49d2-9908-2d7babf842ef"),
Guid.Parse("dba0d44c-ec01-4363-892a-10f22bfc5017"),
Guid.Parse("7d041c47-346d-4b0e-8bc1-6ddd129dc289"),
},
},
            new GuiduuidArray1M
{
    Id = 7,
    Value = 
new System.Guid[4]
{
Guid.Parse("a7f1c706-8b67-415b-8be9-ba9b4fd24dc1"),
Guid.Parse("66c5cad4-c35c-4ec5-840f-33f089ca2245"),
Guid.Parse("0b45630a-fb1f-4824-99b3-6b685880ab06"),
Guid.Parse("0bfb0ac6-e840-4b53-8c93-464c057fcbd1"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 5,
    Value = 
new System.Guid[4]
{
Guid.Parse("37d67faa-5a57-4ec3-ab00-7dc73fd13dde"),
Guid.Parse("6f7e2889-16db-415f-96fd-cf686fe426ac"),
Guid.Parse("f27aec84-c005-4c7c-9239-7c3e4dcb62c1"),
Guid.Parse("1eb1c3c1-0ab1-4906-9163-2c35fa4fd9ca"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("50cfa3a0-dcd2-42f1-840b-0a92c9f39ecb"),
Guid.Parse("96cb5584-0de3-4593-8ee3-9a630a0a2dee"),
Guid.Parse("1c8fd8f3-e5c5-44a4-baf3-4f60b51d12de"),
Guid.Parse("b4a32040-fa7c-4de6-b8e1-dcac38013dd7"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 12,
    Value = 
new System.Guid[4]
{
Guid.Parse("9290883e-3ac3-4a66-89f2-a710a0caca3a"),
Guid.Parse("f37aecc7-7855-4064-bebe-1446f3533311"),
Guid.Parse("fbcf8a13-accf-40d0-a056-cea100c87712"),
Guid.Parse("5578b7ce-0f8a-46af-bf27-8231ba4e6680"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("bd1bb2eb-b09b-4f7f-8b27-80d33cd1ce5b"),
Guid.Parse("c287b857-4727-4138-a994-8e91e33ec634"),
Guid.Parse("782b31f2-81d7-4a0c-9a1e-c0d2586d8d6b"),
Guid.Parse("169910d0-1a54-498c-a49e-f3694508843a"),
},
},
            new GuiduuidArray1M
{
    Id = 16,
    Value = 
new System.Guid[3]
{
Guid.Parse("ef8b12d9-d90f-465f-8c64-7415a341e48d"),
Guid.Parse("1f2341da-b6ce-4726-b3d2-ddc01616ee72"),
Guid.Parse("a97131cc-4f56-4b45-8d7f-1f8e581ab4d0"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 12,
    Value = 
new System.Guid[4]
{
Guid.Parse("176aacbb-b26e-4ffd-a758-ded91127162a"),
Guid.Parse("0ebfbb91-36f3-4c42-a8f7-0720c75d3ea6"),
Guid.Parse("2b59afec-ffa4-4eac-915c-0f03c9fa8b6b"),
Guid.Parse("d239f066-d34b-492c-910a-c1a88ba81f1b"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("e4a3be58-224d-4a80-8506-cc6134de7922"),
Guid.Parse("18dc8363-f542-4d58-97f5-d56df7a1fd25"),
Guid.Parse("be9d8b51-2235-4695-9394-305fd4bb7eaa"),
Guid.Parse("9c5c7eca-06c1-4239-b183-ccb3cdf9e659"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("27355e4b-c1b3-4efa-897c-67b5c741cdb3"),
Guid.Parse("765f501b-d403-496d-b94e-d809c32a16fb"),
Guid.Parse("22aae9e4-3a15-4072-bf93-8797e68b41cb"),
},
},
            new GuiduuidArray1M
{
    Id = 18,
    Value = 
new System.Guid[3]
{
Guid.Parse("ac828003-bc8d-4432-8b5d-617f2015dc33"),
Guid.Parse("c1035e47-79c3-44eb-a745-7566e3cde9a6"),
Guid.Parse("2c78ed1e-7ef6-4d95-8899-a1ba9295f081"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("ab6492d5-8cc0-4408-b696-bb48515479ac"),
Guid.Parse("921302cb-553c-412c-af9a-bf89f76e9a8f"),
Guid.Parse("824a0641-a46b-47ff-9c2e-b71580061120"),
Guid.Parse("79fadbaa-60fc-45a6-a614-18b688049cf5"),
},
},
            new GuiduuidArray1M
{
    Id = 23,
    Value = 
new System.Guid[3]
{
Guid.Parse("2e0afc54-5d74-449a-91e0-ff894c50321d"),
Guid.Parse("f1799869-8efb-4609-baff-4153424337a2"),
Guid.Parse("2b00d873-ee46-4c75-a73b-c8c1802c6288"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 13,
    Value = 
new System.Guid[4]
{
Guid.Parse("174a28e3-3e0f-476d-9ebb-e0a6cf4ffa4e"),
Guid.Parse("a3bf58c4-1bc2-44c7-9115-d0be889f2014"),
Guid.Parse("05ab67af-71de-4c3c-a667-f75968587ad8"),
Guid.Parse("b46997d1-6ea2-4650-838e-938076f079e0"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("4c1ed5c9-b5d0-44f0-95b2-4f135bc375ae"),
Guid.Parse("0c1d1560-4a4d-40c4-aa6c-0df5722c8cd5"),
Guid.Parse("4ede3a5f-b30a-4963-8ec9-dee9381026c3"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 32,
    Value = 
new System.Guid[3]
{
Guid.Parse("bd825df9-6488-4d3d-ac4d-98d3beffb2a7"),
Guid.Parse("4fd342ce-c960-4397-a7b9-386a8a39345f"),
Guid.Parse("e5e9ee8b-74a2-42c5-8854-c6107c240e6d"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("a0de1ef5-825c-4800-b5f9-73d26e0e6658"),
Guid.Parse("89c2e0a3-00b5-4a65-9498-3225590a9c0b"),
Guid.Parse("a359f3fa-e94e-4685-b828-333ac6c449ec"),
Guid.Parse("e5b3dd4e-b80b-4d1f-8116-a239ca63534b"),
},
},
            new GuiduuidArray1M
{
    Id = 34,
    Value = 
new System.Guid[3]
{
Guid.Parse("dbf73f1b-4356-43a2-8a93-90f4819cc2a8"),
Guid.Parse("2d644808-c756-41be-8494-3cf8f9a12c75"),
Guid.Parse("19cd2c7d-cd82-4d52-b9a1-9eb88013bf4e"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 21,
    Value = 
new System.Guid[3]
{
Guid.Parse("39d6bb63-717b-482d-8f49-f7ebcc4a5576"),
Guid.Parse("1ccc5414-58cc-482b-b3af-7e09a606a968"),
Guid.Parse("ab03843e-9bc1-429a-92c3-c996be1891c4"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("0f23f6cb-297e-4ad5-8003-556d8e6c54d6"),
Guid.Parse("c1ded6db-308f-4bb2-999f-d4ccfe587f11"),
Guid.Parse("f6400a2d-e4ee-48c6-8f5f-6f2e6a76c570"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("45fba19b-2d2c-4d91-9b4b-9d5c313a5a23"),
Guid.Parse("9a473bdd-bad5-449f-a65a-5f49e37d4c39"),
Guid.Parse("8cbc26cf-4b36-4dcd-95e8-b0fa36e9cf2c"),
},
},
            new GuiduuidArray1M
{
    Id = 35,
    Value = 
new System.Guid[4]
{
Guid.Parse("39cbf9de-740b-45af-9578-abb9e931d536"),
Guid.Parse("ab8047ac-78c4-44c3-98cd-a7983e3bc001"),
Guid.Parse("f71a96d0-4685-4afa-8a69-a27b65f3a630"),
Guid.Parse("81f97128-d6c7-480f-a862-8f4cffa5c03d"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 40,
    Value = 
new System.Guid[4]
{
Guid.Parse("3a245f7b-f682-4185-a2bf-6d3b0088c295"),
Guid.Parse("6be98ea0-5bd6-43a5-8536-f9e429f95d36"),
Guid.Parse("3ab4df23-3a17-44fa-bab8-6d29af5b143c"),
Guid.Parse("178026e3-6264-4450-b6a6-5541874576ae"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 25,
    Value = 
new System.Guid[3]
{
Guid.Parse("195a8d00-a46d-48c2-bf8d-97f6b7a0f84d"),
Guid.Parse("5cd2ece2-d388-4152-89f4-e521039ccb7d"),
Guid.Parse("99e9a74a-d5e7-4901-a247-b7b2d9ebfed1"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("8ac31969-c7b5-419c-b155-fe76565adc78"),
Guid.Parse("b09d7d0d-366b-41b8-8eb1-0be284c3f60f"),
Guid.Parse("c8fd5773-5552-4163-9587-0beb0d8382af"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 41,
    Value = 
new System.Guid[4]
{
Guid.Parse("20eff026-6bd6-49c6-bd29-87f63afb9b37"),
Guid.Parse("e630082e-874e-4abf-a798-684c98d13b14"),
Guid.Parse("7f88f24c-c6f2-4a02-9e03-c272b203b70b"),
Guid.Parse("ea3003bd-c508-4c3e-b55f-5fc4941b1f07"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("2eec70d5-0d49-4b27-b0b7-20718dc8066e"),
Guid.Parse("d3969cb5-6cb1-4a16-aae8-18afd35f33a4"),
Guid.Parse("0aaee308-ddb5-4bb3-a282-6ce50ff86e45"),
},
},
            new GuiduuidArray1M
{
    Id = 46,
    Value = 
new System.Guid[4]
{
Guid.Parse("f5cccca5-c19e-471a-9d47-3c85426c8fff"),
Guid.Parse("789951a4-c6cb-41d6-b71b-2ad1f0694e9b"),
Guid.Parse("29830618-7811-4e8f-a249-24740502919f"),
Guid.Parse("9f84294c-f51f-4b68-9422-bf3e51249e23"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 32,
    Value = 
new System.Guid[3]
{
Guid.Parse("01cc2854-e340-46e8-8c07-2b2f0976e31e"),
Guid.Parse("b20a9ccc-1c5c-456f-9d54-cc2822665a87"),
Guid.Parse("2e70498c-d5d9-4b9f-bfe2-e4e551fd185b"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("7d5319e6-23e2-4e81-a66d-f7325f2bea9b"),
Guid.Parse("20559f3b-ac4b-4ce2-b6d2-d14602fbf462"),
Guid.Parse("e1292f85-0dcf-4a63-825d-0f347d49ae59"),
Guid.Parse("f67565e0-46e2-4227-b942-c8ae1db6c703"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("c28dce12-bf67-49ef-a393-c0a6da731cec"),
Guid.Parse("f75a5aab-1740-40df-b105-58237bbf9e88"),
Guid.Parse("f06f4d5e-c0a8-4158-83d7-2879665d4d06"),
},
},
            new GuiduuidArray1M
{
    Id = 53,
    Value = 
new System.Guid[4]
{
Guid.Parse("a7405d81-a094-4c82-96bc-fc9bfdb77366"),
Guid.Parse("60d54721-d16b-480b-bad5-d92d1184c705"),
Guid.Parse("ab22e30b-7dda-476f-8cd0-f2ae79dfc36e"),
Guid.Parse("1cbf5f09-1c15-4fd7-b2ad-3e6f0bb29085"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("dcf05470-b5ee-4ede-bfe3-6e34e73f819a"),
Guid.Parse("f73346aa-f6d4-40a7-9600-5aaca1d11558"),
Guid.Parse("9ca6fdea-1dbb-4d34-a07d-a003a9e5a93a"),
Guid.Parse("359bd234-62b3-42cb-8574-c1e8ca1f0e24"),
},
},
            new GuiduuidArray1M
{
    Id = 57,
    Value = 
new System.Guid[3]
{
Guid.Parse("3d688605-6afd-438c-b965-52cbc3e37fba"),
Guid.Parse("b72ef0d2-e73b-4650-ad81-c641ec418ba7"),
Guid.Parse("9f07a766-1091-42d4-8262-a078b3ca6a21"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 36,
    Value = 
new System.Guid[4]
{
Guid.Parse("f2ef6095-cfed-4b0a-8e85-567bb913a487"),
Guid.Parse("ec50349b-4fd7-4601-9565-11d85771acd6"),
Guid.Parse("7c31df4f-9b18-4557-bb0b-138ef4f2c8c7"),
Guid.Parse("53b5c931-179e-4596-aec2-2aa4dfd24dab"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 65,
    Value = 
new System.Guid[4]
{
Guid.Parse("6475ddca-c3e4-45e2-927f-ea1957d1c15a"),
Guid.Parse("fd3ca31e-3c2b-4167-8435-0067052e6896"),
Guid.Parse("c364bbac-09c8-44fc-970a-d415b592d16a"),
Guid.Parse("39b16da4-9c0a-4511-a3ce-994b55e88821"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 73,
    Value = 
new System.Guid[4]
{
Guid.Parse("66f33e04-b55d-4adf-9ccf-85a75344cf75"),
Guid.Parse("6b99295d-6b7c-40d2-8f8c-07750d38f15a"),
Guid.Parse("40627ad1-d81a-4a4a-99e6-6b156a567a4f"),
Guid.Parse("e6b701ed-2a5b-495f-b960-407025e2177d"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 37,
    Value = 
new System.Guid[3]
{
Guid.Parse("4466c5cc-612f-4339-9e34-741b8311b0d9"),
Guid.Parse("44857a0b-2902-4944-8fe2-3ff57a321f4c"),
Guid.Parse("793c0df4-c48f-421f-96f5-3346778728ea"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("1d5e8b9c-20a7-48a8-8123-b45146e37e93"),
Guid.Parse("b5e49926-ee07-423a-937b-606cf356a553"),
Guid.Parse("2fa8b945-bf5f-454e-a2aa-c602f5f423b9"),
},
},
            new GuiduuidArray1M
{
    Id = 79,
    Value = 
new System.Guid[4]
{
Guid.Parse("733553ac-a9e1-4d45-b686-f92baf477733"),
Guid.Parse("891d3b55-bbdf-4893-b2a2-8b13fb89bb91"),
Guid.Parse("de035954-7157-4c56-9ad3-824b4fd6806b"),
Guid.Parse("924c2ce1-c54e-4811-8187-4d8e46fe5790"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 82,
    Value = 
new System.Guid[3]
{
Guid.Parse("e5921d3b-e824-476c-97b8-4205722941a8"),
Guid.Parse("ebd40abb-a215-42cb-a59c-1c40e62ee484"),
Guid.Parse("930154a2-efd2-4164-8e89-a600d11e6da3"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 45,
    Value = 
new System.Guid[4]
{
Guid.Parse("f35242ab-277c-4dc0-85f3-d7458ab5a41c"),
Guid.Parse("ed6d23df-92cb-4fb7-8d6b-666412f3be32"),
Guid.Parse("d33a8896-9c12-4dcb-98b2-630aeefca164"),
Guid.Parse("dbe94788-0299-495d-9d81-943ac4d107ad"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("39dc8c13-3c40-4296-b746-9c68617fdda5"),
Guid.Parse("23eec150-e282-4420-b92e-c268d538f1d2"),
Guid.Parse("10501a84-0148-4902-8143-ab55ffe27df1"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 90,
    Value = 
new System.Guid[4]
{
Guid.Parse("26be1091-40cc-4319-9c97-a7d05f7cd517"),
Guid.Parse("5afedef3-7066-4c9e-94a8-2cc2a9e1b65a"),
Guid.Parse("ce9d2926-c7af-4407-b572-974f19a64d83"),
Guid.Parse("a14fe3ab-2759-4de0-834f-aaa58278cc01"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("5b182cca-662b-4dde-9692-f2371f4fae27"),
Guid.Parse("aa827323-9ade-47c8-a2f3-45906bffcdbf"),
Guid.Parse("389dbb82-083a-4850-8d83-b3689f7e8ad6"),
Guid.Parse("d3043266-b880-4a09-a9b0-605968f35c42"),
},
},
            new GuiduuidArray1M
{
    Id = 99,
    Value = 
new System.Guid[4]
{
Guid.Parse("e54105f4-f0da-4ee8-9933-f940e07a10f5"),
Guid.Parse("aa8b2573-6536-4709-96c3-d242194c3158"),
Guid.Parse("7b14b883-a2b7-4592-883d-d1c78bb4fdb2"),
Guid.Parse("0a95366e-bc5a-47fa-9c1b-403e3274dba9"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 53,
    Value = 
new System.Guid[3]
{
Guid.Parse("15a8ffc4-d27a-4bc5-945c-50e43d60e64a"),
Guid.Parse("8f039b2b-2e5b-4f1b-b2fa-8d39cb812fe5"),
Guid.Parse("1062889f-8c38-4110-9133-e9b4b4dbbe9d"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("2b08913a-9e1c-47a0-83a9-5f7b664c0f3d"),
Guid.Parse("46e49cde-19c0-41c3-9978-636c56d6fd46"),
Guid.Parse("7047bcc1-81e1-41e6-9d4d-1bbe773b2b60"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 102,
    Value = 
new System.Guid[4]
{
Guid.Parse("df2261f4-3c08-4a3d-b493-c5b6f349f117"),
Guid.Parse("34725d62-ca56-4601-9aae-087429c9a3e1"),
Guid.Parse("c8af2fb5-7d59-4461-8068-02aa7fdafbd8"),
Guid.Parse("1ba4e403-7ddc-4346-a8ed-e43e89971c92"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("ade84e7d-1b4b-44de-aca6-513313e70342"),
Guid.Parse("be0eb7b4-f301-4a2c-9709-77c82407081f"),
Guid.Parse("bc6dc8bb-7f1f-457c-a6a7-42a8c4117ee1"),
},
},
            new GuiduuidArray1M
{
    Id = 104,
    Value = 
new System.Guid[4]
{
Guid.Parse("4323a3fc-3733-4bef-b8ea-b3de1fa4e29f"),
Guid.Parse("06d6ab59-a5e0-4b11-bc0f-97320854ae1c"),
Guid.Parse("28fdae36-404a-4af6-b8aa-2551950b3788"),
Guid.Parse("f6429c67-b22d-4297-b882-db8971368b21"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 62,
    Value = 
new System.Guid[4]
{
Guid.Parse("33b3301f-d9f2-4c39-a545-8acfc6d97dd8"),
Guid.Parse("4c76ce86-7a6a-49d5-9666-64a91ab01134"),
Guid.Parse("0e520481-942e-4285-8317-b2c047457c74"),
Guid.Parse("aae586f2-f49e-40a6-bcef-a4f1cab3a558"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("940a1c46-d660-4b73-9e2d-582403f1b0e6"),
Guid.Parse("c08aeb3f-dddc-4e0c-898d-fc46f22c0619"),
Guid.Parse("83e7fe32-a8c9-4fae-9554-0ca1e65a5c79"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 108,
    Value = 
new System.Guid[4]
{
Guid.Parse("6ccab7a8-590f-4576-9a6f-73a36acc3a6e"),
Guid.Parse("4a9476e2-5ae6-4fda-bf01-22602600c8a0"),
Guid.Parse("9057ccb6-6161-42c3-9e79-5fb60f57943a"),
Guid.Parse("7d77e23f-08a6-43da-a838-08ec13bb75c4"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("788e0012-0e2c-46e5-9e08-3c701f486169"),
Guid.Parse("ac31dfec-8aac-43d7-ae0c-4ba99224af57"),
Guid.Parse("16f6538a-778d-411e-9fc7-f80b21f94d71"),
},
},
            new GuiduuidArray1M
{
    Id = 113,
    Value = 
new System.Guid[4]
{
Guid.Parse("106010cd-c382-435a-9ffd-7ba160191ba0"),
Guid.Parse("db47a8f0-7ad2-4ccc-b6c1-6b90a91ac438"),
Guid.Parse("67dfa692-bebb-42b2-b4dc-2ff6c73d31b6"),
Guid.Parse("129524af-0dfc-4b57-acae-d632ffa6fcd3"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 69,
    Value = 
new System.Guid[3]
{
Guid.Parse("3cc38b12-afd4-448a-9e0b-f18a1acbe9c0"),
Guid.Parse("87bbc307-7bb8-4b0a-b1b3-183cc10364d5"),
Guid.Parse("861b3cf0-efbb-4f8a-9edb-83f0947706ca"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 115,
    Value = 
new System.Guid[3]
{
Guid.Parse("7903624f-c0a1-488c-b9f1-e03ea8e5d2b9"),
Guid.Parse("75d765e1-9c93-462d-a5d1-963fb1782c75"),
Guid.Parse("747bb538-3abc-4d1b-a5b3-4780abad72ea"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("b5b2c566-dffd-439c-be06-42de5eb37474"),
Guid.Parse("95581c40-b326-4a30-a6ab-09d25003d896"),
Guid.Parse("2f21697f-8d47-4cb4-930f-0511eb591cc5"),
Guid.Parse("33baca80-a7dc-4371-b2a5-7fc8ffd210ed"),
},
},
            new GuiduuidArray1M
{
    Id = 121,
    Value = 
new System.Guid[4]
{
Guid.Parse("b68286a3-f80f-4cf2-b7ca-87b799896098"),
Guid.Parse("a3b7db68-6aaf-4276-922d-f143c44344c8"),
Guid.Parse("b46bd32e-f6c9-4e1d-aae8-09abe72d4259"),
Guid.Parse("281a5998-803c-435e-a6cf-3d158e3213cb"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 78,
    Value = 
new System.Guid[4]
{
Guid.Parse("7a570d95-8d52-4b67-a895-a38837e9893e"),
Guid.Parse("307ea6cc-1433-402c-b60d-7998a066a922"),
Guid.Parse("0c527aad-d3c1-458a-b885-2b568b75997a"),
Guid.Parse("e81fe524-2e1a-4412-b1a3-be0fa10a7e7d"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 126,
    Value = 
new System.Guid[3]
{
Guid.Parse("9599ce6b-ddba-4680-a0c0-b1eb14f9cb41"),
Guid.Parse("1f6efa7a-a222-4037-92f2-3199a2cbf52a"),
Guid.Parse("7888ddf5-801b-4664-aed9-5f3262c8e579"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("ae0b25fd-bfcc-415c-86ac-df08b9a12f80"),
Guid.Parse("7365d4d3-3121-4345-a0bd-3909c1dc85ca"),
Guid.Parse("61a16406-f370-4298-9f25-db09d3fdd903"),
},
},
            new GuiduuidArray1M
{
    Id = 127,
    Value = 
new System.Guid[3]
{
Guid.Parse("08e485f6-56d4-4680-813e-9b9cb288a1e3"),
Guid.Parse("9daf090d-4997-42cd-8fb9-bc68884e184a"),
Guid.Parse("da8c4d91-7c15-422b-9b3b-ff0e655f5cc5"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 84,
    Value = 
new System.Guid[4]
{
Guid.Parse("812da12b-ce00-4a08-8949-7db406cf71a1"),
Guid.Parse("ace2c03c-ef6b-4a36-a257-39c10678de03"),
Guid.Parse("24628cbf-95bc-449a-9990-db7a3b3a656f"),
Guid.Parse("be7221a3-49b3-4dc3-ac0d-0b99684941cc"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 130,
    Value = 
new System.Guid[3]
{
Guid.Parse("615e7954-3f62-46fe-a663-6b51d5161b58"),
Guid.Parse("9a5162b0-ebb1-44b0-a9d2-8f64cd311829"),
Guid.Parse("a414f789-0a92-4eef-a18b-39d0d655911b"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("38b8e734-7c11-48ee-a1f9-8ba85a9d9964"),
Guid.Parse("1acd6b3c-f980-4e4d-b270-ba68dff6fdbd"),
Guid.Parse("ea524aa9-5f59-45b9-bf60-6607fcbc4462"),
Guid.Parse("4e142a0c-e8df-4783-a239-db64b20bf511"),
},
},
            new GuiduuidArray1M
{
    Id = 133,
    Value = 
new System.Guid[3]
{
Guid.Parse("da299cc8-890f-463d-a87e-876ee473815f"),
Guid.Parse("0ee29d1e-71c9-424f-a607-03fe64578583"),
Guid.Parse("e32bc52a-048e-4098-bbd0-75d8f872cec5"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 89,
    Value = 
new System.Guid[4]
{
Guid.Parse("2d7d062b-618e-49b7-94d2-5cead3b79115"),
Guid.Parse("07e11f8d-e528-45c3-8036-423a9196c2eb"),
Guid.Parse("30948f1d-eb2b-4301-9301-5ff8af49dd97"),
Guid.Parse("1301aa0c-9e2a-4049-936b-a120b8c11fe6"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("f08831f7-5ba0-43ce-99be-0a7f89565e1f"),
Guid.Parse("1eb405d0-50a7-49d5-a72a-302c5109a5a7"),
Guid.Parse("0c73313e-0b4d-41df-bbbb-73d098a576e3"),
Guid.Parse("de6e07e9-f909-46f0-8087-0fe13a7b301b"),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("ab6492d5-8cc0-4408-b696-bb48515479ac"),
Guid.Parse("921302cb-553c-412c-af9a-bf89f76e9a8f"),
Guid.Parse("824a0641-a46b-47ff-9c2e-b71580061120"),
Guid.Parse("79fadbaa-60fc-45a6-a614-18b688049cf5"),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("a0de1ef5-825c-4800-b5f9-73d26e0e6658"),
Guid.Parse("89c2e0a3-00b5-4a65-9498-3225590a9c0b"),
Guid.Parse("a359f3fa-e94e-4685-b828-333ac6c449ec"),
Guid.Parse("e5b3dd4e-b80b-4d1f-8116-a239ca63534b"),
}));
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
new System.Guid[3]
{
Guid.Parse("45fba19b-2d2c-4d91-9b4b-9d5c313a5a23"),
Guid.Parse("9a473bdd-bad5-449f-a65a-5f49e37d4c39"),
Guid.Parse("8cbc26cf-4b36-4dcd-95e8-b0fa36e9cf2c"),
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
                Assert.That(nullable, Is.Null);
                nullable =  ((IGuidArrayuuidArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
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
                nullable = await ((IGuidArrayuuidArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("2eec70d5-0d49-4b27-b0b7-20718dc8066e"),
Guid.Parse("d3969cb5-6cb1-4a16-aae8-18afd35f33a4"),
Guid.Parse("0aaee308-ddb5-4bb3-a282-6ce50ff86e45"),
}));
                nullable = await ((IGuidArrayuuidArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("c28dce12-bf67-49ef-a393-c0a6da731cec"),
Guid.Parse("f75a5aab-1740-40df-b105-58237bbf9e88"),
Guid.Parse("f06f4d5e-c0a8-4158-83d7-2879665d4d06"),
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[29], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[29], false);
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[29], false);
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
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
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[19],_testData[29], false);
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
                parametr1.Value = 12;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[22],_testData[29], false);
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
                parametr1.Value = 34;
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[19],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[20],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[29], false);
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[29], false);
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        GuiduuidArray1M.AssertModel(models[0],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        GuiduuidArray1M.AssertModel(models[0],_testData[1], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[2], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[3], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[4], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[5], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[6], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[7], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[8], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[9], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[10], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[11], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[12], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[21],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[22],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[23],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[24],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[25],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[26],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[27],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[28],_testData[29], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        GuiduuidArray1M.AssertModel(models[0],_testData[2], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[3], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[4], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[5], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[6], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[7], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[8], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[9], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[10], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[11], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[12], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[21],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[22],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[23],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[24],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[25],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[26],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        GuiduuidArray1M.AssertModel(models[0],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[29], false);
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
                await ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 35, query1, 7, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[29], false);
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
                await ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 82, query1, 4, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[28],_testData[29], false);
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
                 ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 35, query1, 46, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[29], false);
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
                 ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 79, query1, 79, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[29], false);
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 18, query1, 34, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[19],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[20],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[21],_testData[29], false);
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
                await ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 108, query1, 90, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[29], false);
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 40, query1, 57, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                 ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 18, query1, 23, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[23],_testData[29], false);
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelBatchAsync(connection, 16, 16))
                {
                    if(++resultIndex == 1)
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelBatch(connection, 18, 104))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        GuiduuidArray1M.AssertModel(models[0],_testData[5], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[6], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[7], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[8], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[9], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[10], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[11], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[12], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[21],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[22],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[23],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        GuiduuidArray1M.AssertModel(models[0],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[29], false);
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
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 16);
                var models = await ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));
GuiduuidArray1M.AssertModel(models[0],_testData[4], false);GuiduuidArray1M.AssertModel(models[1],_testData[5], false);GuiduuidArray1M.AssertModel(models[2],_testData[6], false);GuiduuidArray1M.AssertModel(models[3],_testData[7], false);GuiduuidArray1M.AssertModel(models[4],_testData[8], false);GuiduuidArray1M.AssertModel(models[5],_testData[9], false);GuiduuidArray1M.AssertModel(models[6],_testData[10], false);GuiduuidArray1M.AssertModel(models[7],_testData[11], false);GuiduuidArray1M.AssertModel(models[8],_testData[12], false);GuiduuidArray1M.AssertModel(models[9],_testData[13], false);GuiduuidArray1M.AssertModel(models[10],_testData[14], false);GuiduuidArray1M.AssertModel(models[11],_testData[15], false);GuiduuidArray1M.AssertModel(models[12],_testData[16], false);GuiduuidArray1M.AssertModel(models[13],_testData[17], false);GuiduuidArray1M.AssertModel(models[14],_testData[18], false);GuiduuidArray1M.AssertModel(models[15],_testData[19], false);GuiduuidArray1M.AssertModel(models[16],_testData[20], false);GuiduuidArray1M.AssertModel(models[17],_testData[21], false);GuiduuidArray1M.AssertModel(models[18],_testData[22], false);GuiduuidArray1M.AssertModel(models[19],_testData[23], false);GuiduuidArray1M.AssertModel(models[20],_testData[24], false);GuiduuidArray1M.AssertModel(models[21],_testData[25], false);GuiduuidArray1M.AssertModel(models[22],_testData[26], false);GuiduuidArray1M.AssertModel(models[23],_testData[27], false);GuiduuidArray1M.AssertModel(models[24],_testData[28], false);GuiduuidArray1M.AssertModel(models[25],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidArrayuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 65);
                var models =  ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(15));
GuiduuidArray1M.AssertModel(models[0],_testData[15], false);GuiduuidArray1M.AssertModel(models[1],_testData[16], false);GuiduuidArray1M.AssertModel(models[2],_testData[17], false);GuiduuidArray1M.AssertModel(models[3],_testData[18], false);GuiduuidArray1M.AssertModel(models[4],_testData[19], false);GuiduuidArray1M.AssertModel(models[5],_testData[20], false);GuiduuidArray1M.AssertModel(models[6],_testData[21], false);GuiduuidArray1M.AssertModel(models[7],_testData[22], false);GuiduuidArray1M.AssertModel(models[8],_testData[23], false);GuiduuidArray1M.AssertModel(models[9],_testData[24], false);GuiduuidArray1M.AssertModel(models[10],_testData[25], false);GuiduuidArray1M.AssertModel(models[11],_testData[26], false);GuiduuidArray1M.AssertModel(models[12],_testData[27], false);GuiduuidArray1M.AssertModel(models[13],_testData[28], false);GuiduuidArray1M.AssertModel(models[14],_testData[29], false);
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
            query: null,
            methodName:"DynQueryImportModelInner",
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<GuiduuidArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IGuidArrayuuidArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidArrayuuidArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(actual, expect, false);
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
                await ((IGuidArrayuuidArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                models = await ((IGuidArrayuuidArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
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

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<GuiduuidArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IGuidArrayuuidArray)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidArrayuuidArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(actual, expect, false);
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
                await ((IGuidArrayuuidArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IGuidArrayuuidArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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

        [Test, Order(1)]
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

        [Test, Order(2)]
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

        [Test, Order(2)]
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

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IGuidArrayuuidArray)this).ExportModelInner(connection).ToList();
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

        [Test, Order(2)]
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

#endregion

    }
}

