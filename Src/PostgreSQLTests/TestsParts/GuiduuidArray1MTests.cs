

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
    Id = 8,
    Value = 
new System.Guid[3]
{
Guid.Parse("5d4e179e-25d2-4803-beb1-f8d1d7fcb157"),
Guid.Parse("ecc62fe7-5ff5-45df-b47c-11b2c672e047"),
Guid.Parse("c6794457-6e4a-4953-b521-9f30dc91853c"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 16,
    Value = 
new System.Guid[3]
{
Guid.Parse("5f094730-2ebb-48b6-83f2-07856c529b08"),
Guid.Parse("955f63f7-df0e-496f-909d-a5eb5b44b700"),
Guid.Parse("6f4014f4-5ba9-4dc4-a87b-da53c4dcf82f"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 7,
    Value = 
new System.Guid[3]
{
Guid.Parse("665cf5b1-9c7f-4b79-98ad-c9974f95b5e1"),
Guid.Parse("f58ff329-dc4c-4c0f-b3ad-51060fb274d7"),
Guid.Parse("329c5d23-0cf7-4092-9d2e-ceb682e18200"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("4ad3d2dd-719d-4c92-98a2-b3fa989d818b"),
Guid.Parse("8fa81a31-23ed-4b52-99fc-c2ad1d44a7ab"),
Guid.Parse("125d1eed-a857-4a22-aed4-4947fd9d82f2"),
},
},
            new GuiduuidArray1M
{
    Id = 19,
    Value = 
new System.Guid[3]
{
Guid.Parse("821f8ce4-9a05-4234-92ba-a16b943dd5a0"),
Guid.Parse("3d3f185f-f988-4a01-8ae0-e1cee5c6befe"),
Guid.Parse("74bd8cbf-6d96-4029-9549-a31cc78cb197"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 21,
    Value = 
new System.Guid[3]
{
Guid.Parse("3d18f696-a89a-459c-953d-d64e6034658a"),
Guid.Parse("29c7231f-434c-4142-9086-7d77fed68d7e"),
Guid.Parse("424264fe-a9e8-4804-b388-90734a3f0a62"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 14,
    Value = 
new System.Guid[3]
{
Guid.Parse("3f68ccf8-f383-4842-bd53-58f3e9bbba89"),
Guid.Parse("5a6de9ca-dfa6-4882-9f54-f4835f539b2f"),
Guid.Parse("4b3d097a-f7b2-4c5c-821a-9077685e7102"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("d72b2eb3-d13b-4cc1-ac72-eabe4aa45564"),
Guid.Parse("ad9aef90-c479-4edf-9d73-a1bd399223b1"),
Guid.Parse("cc0f6d14-63ca-41f1-a459-5d8c7b1fd17f"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 27,
    Value = 
new System.Guid[4]
{
Guid.Parse("22be5893-aed3-40a4-bbdb-5b4b37d1ad3b"),
Guid.Parse("802c99d7-76d6-4e2b-b30a-9786868a2144"),
Guid.Parse("85f358ed-aafc-44c5-a28f-4e3298888cef"),
Guid.Parse("d2954cda-3e2c-4d2d-b9af-7071114fa7e5"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 29,
    Value = 
new System.Guid[4]
{
Guid.Parse("13d301bb-5658-4410-b530-26ccebdc64ca"),
Guid.Parse("b2d580b1-7009-4773-b58b-956a8269bc8f"),
Guid.Parse("d0446019-b0d0-4beb-a514-a26a61cc8df4"),
Guid.Parse("a8584aaf-07d1-4277-8d98-adea08b9964a"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 17,
    Value = 
new System.Guid[3]
{
Guid.Parse("d1d7f12e-9e5b-4f1e-a760-01804688a1c1"),
Guid.Parse("275c967b-e1a2-48dc-a1f0-6dd6c4ee549f"),
Guid.Parse("c84a058a-9b56-481d-b246-b3b434a8d9bb"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("e4d85c1d-a0c3-4ca0-82d1-75122069707b"),
Guid.Parse("d2e8b491-2313-4f92-84e1-4219c479ad05"),
Guid.Parse("35c5d14d-89cb-4f3d-9b4e-c21cc1029512"),
Guid.Parse("5a3ef667-bc83-4266-808a-2dd8f714c4de"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 30,
    Value = 
new System.Guid[3]
{
Guid.Parse("defb8645-3ded-4871-af74-4f9cff892bde"),
Guid.Parse("a4541bd4-230b-421d-8464-91d03c42ac14"),
Guid.Parse("3534a74e-301a-49a4-ace6-9a62f7726677"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 31,
    Value = 
new System.Guid[4]
{
Guid.Parse("2ceb0013-edc4-4791-b6c4-273ebcf32c74"),
Guid.Parse("672de791-3011-45ff-b68e-18c8a805fd8f"),
Guid.Parse("1bd96488-c649-4be0-80bc-da9c3fcdc953"),
Guid.Parse("77abbf0d-2f6b-4e83-84f6-5d1e2a2ef294"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 25,
    Value = 
new System.Guid[4]
{
Guid.Parse("8df56c16-b1fe-49a6-8024-ac9d15937709"),
Guid.Parse("dc9803d0-cbf8-46da-8f3a-bf066db55ff1"),
Guid.Parse("43546023-4470-4341-81d7-b1253da4237b"),
Guid.Parse("04a8f06c-d8be-40c6-ad9d-7dcb61d57453"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("fd2a70d5-e5dd-4d1d-a0f4-1b0f07372af4"),
Guid.Parse("3a78361d-7786-4708-939e-1b391c76b404"),
Guid.Parse("f9b83e41-57ac-48bd-acba-83c890bc2051"),
Guid.Parse("6d70886e-fd2b-4d4f-9484-8849e633f03f"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 36,
    Value = 
new System.Guid[3]
{
Guid.Parse("eeb9a8f7-c430-42ce-b79e-4d5f84e7f16a"),
Guid.Parse("03ce4222-21a2-4073-ac19-de0bc0998d74"),
Guid.Parse("d4632700-7bf7-4186-9fb1-9364ea98a558"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("1d3514ba-c2c3-49be-ba50-b6363ee3188d"),
Guid.Parse("9d585547-9bc5-45de-9d85-6361019f506b"),
Guid.Parse("1a82f8b8-3675-4b25-916b-45c9609ee9d5"),
Guid.Parse("02502a8f-1219-4b58-9e43-61fc7f57cd04"),
},
},
            new GuiduuidArray1M
{
    Id = 43,
    Value = 
new System.Guid[3]
{
Guid.Parse("0c96a7ee-53f1-4538-9911-8dbec66c9c53"),
Guid.Parse("257bbf94-95a6-4071-bc73-789a80e6da02"),
Guid.Parse("78f8b4ed-57be-4e26-9d4a-3fe1a30a5d49"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 34,
    Value = 
new System.Guid[3]
{
Guid.Parse("e65ce475-88da-4355-a84a-7dd49c1b41a8"),
Guid.Parse("c5baf1b1-6136-42d1-93bc-155225eda194"),
Guid.Parse("8ab95f54-d044-4844-8722-307ced7b84e7"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("60b490ec-7d7a-44fb-99ea-726168d35a2c"),
Guid.Parse("f9d494eb-fcd8-4b1d-84b0-3a9f8426c911"),
Guid.Parse("cc4c187f-d54f-4112-a420-e859b4118f2f"),
},
},
            new GuiduuidArray1M
{
    Id = 45,
    Value = 
new System.Guid[4]
{
Guid.Parse("df4b6e13-a2bc-45a7-85e6-8c65421e897c"),
Guid.Parse("12283b4f-1e1e-4a4d-88ae-a3e55b68f6e0"),
Guid.Parse("adbc234d-7440-45e9-a28f-145ca2754e9a"),
Guid.Parse("cd68c3c3-57b7-417b-a3d0-1ae9e7b2450b"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("99c59b29-e54e-404c-b685-588cdc9b6a87"),
Guid.Parse("8ffe016a-7673-4787-8fdf-daf1fb3882c1"),
Guid.Parse("8ffa3ccd-d166-4239-a08b-4b7a6676ea96"),
},
},
            new GuiduuidArray1M
{
    Id = 50,
    Value = 
new System.Guid[3]
{
Guid.Parse("1ae84a4c-77da-4242-8a9a-0628d34112ca"),
Guid.Parse("45790487-cd5e-4d18-87b1-89c36a3a7e95"),
Guid.Parse("e47ec46e-6394-48aa-9668-c3e8c4c00de8"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 36,
    Value = 
new System.Guid[4]
{
Guid.Parse("2409cc21-5b6f-45ac-bbbb-a0ac24c083bd"),
Guid.Parse("6f0b6765-b5bf-46e4-81d1-13a42a83c6a9"),
Guid.Parse("a719a420-3643-4af9-83a3-ae3790d87f4f"),
Guid.Parse("f45cb6fe-3081-46fc-91b0-ddddb8e0a8a0"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("09e3fd2c-3ca1-4702-954a-a1dfdf44e15b"),
Guid.Parse("dcdce858-b4a6-4e8f-b67f-f0fab331359b"),
Guid.Parse("c5ffc0bf-5d95-431e-bda4-7750a2dbb196"),
Guid.Parse("672a3513-eb94-46ef-9076-f8fe1cead2ff"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("b559c60b-7cb1-4516-98ac-b192079d9e99"),
Guid.Parse("2d7809c9-7913-472d-bb3d-27dd9c23e580"),
Guid.Parse("27178830-57c1-4cb2-aa6a-ecdb5ccc64c7"),
},
},
            new GuiduuidArray1M
{
    Id = 53,
    Value = 
new System.Guid[4]
{
Guid.Parse("6587646d-1c12-4d0c-82aa-8c50a73c4b47"),
Guid.Parse("89b4de81-6d30-457f-b844-a681799aba58"),
Guid.Parse("0f0c6feb-358d-41db-a843-b82052a24819"),
Guid.Parse("4c8ebc14-fd0b-4641-b031-d624b83e8982"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 61,
    Value = 
new System.Guid[3]
{
Guid.Parse("386cb719-65da-46d2-9190-6de44e65b309"),
Guid.Parse("57a8d274-8a36-4de4-9741-0bf55e723737"),
Guid.Parse("b9954451-e2da-4fa8-b8d7-35057fad780c"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 37,
    Value = 
new System.Guid[3]
{
Guid.Parse("19f647dd-fc82-4f33-b605-ee76f9d293ca"),
Guid.Parse("7504f798-0446-4147-b62d-dae167a776de"),
Guid.Parse("5c5eee90-b8b8-4258-8a68-d38dda3b8358"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 63,
    Value = 
new System.Guid[3]
{
Guid.Parse("ee3b8c94-f0a2-495e-9049-4570c52f69a9"),
Guid.Parse("866e54a5-981b-4efa-a1b9-30207d23cd6b"),
Guid.Parse("ffee4e92-94d8-4d5c-b042-f6e97aae2f76"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 70,
    Value = 
new System.Guid[4]
{
Guid.Parse("653c6851-b571-4516-8f36-3cdec8e9c692"),
Guid.Parse("e2b26ce5-3721-49b1-955e-7d2b6fcd2b0d"),
Guid.Parse("b8da53db-d16d-447e-8c4b-ad3963518c99"),
Guid.Parse("abc9b8f2-6e46-4946-ad3b-b57cea968e02"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 46,
    Value = 
new System.Guid[3]
{
Guid.Parse("4955b4b4-88a6-4fa0-8886-97f04c6d22e7"),
Guid.Parse("af51f9f3-5729-48b8-9a1a-09529335259f"),
Guid.Parse("7295b62a-a975-40da-93f0-efe090af669b"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 77,
    Value = 
new System.Guid[3]
{
Guid.Parse("5feaa936-2f50-4d5b-8518-48441a9edf6c"),
Guid.Parse("bc04ba2f-2332-4559-ba4e-b9b99898eaff"),
Guid.Parse("990305fd-eb07-489b-b834-24b9fd2139a5"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("9cfcc8df-2564-4b2f-9c74-1c3fdf0510c7"),
Guid.Parse("d6e8806b-a59e-43a9-a60f-27c4aaaf0816"),
Guid.Parse("51fb34ff-02be-4e07-9638-2a037c5985d4"),
},
},
            new GuiduuidArray1M
{
    Id = 80,
    Value = 
new System.Guid[3]
{
Guid.Parse("3a232a1a-ee46-490a-a7f1-3a43b60507e7"),
Guid.Parse("79634e63-6002-44bc-a152-4b22c21150e7"),
Guid.Parse("2b9099f5-28ac-4f43-a55d-8ac19f42e895"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 53,
    Value = 
new System.Guid[3]
{
Guid.Parse("28ede2e5-bd65-4a5b-8186-e14f82c5879e"),
Guid.Parse("1a5e65bf-e579-4028-8538-9c0cb4133b18"),
Guid.Parse("c77282fb-5b84-407a-aa4d-27e2493b8fb8"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 88,
    Value = 
new System.Guid[3]
{
Guid.Parse("eeaf9932-6e47-4c68-808c-81f5ba81ae4c"),
Guid.Parse("876a3179-29bf-46d9-8eb2-d760b9263040"),
Guid.Parse("be938a59-0a00-4399-8a81-1da3ddeee5ce"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("1c0cbda0-76fd-4c7e-bfa1-16e307f973ab"),
Guid.Parse("adbbc8fd-1bac-431f-8c52-ad97c553e3d4"),
Guid.Parse("90b417d6-a422-4cc6-bcf6-709ee5de6a3f"),
Guid.Parse("24abe10e-5a44-42a4-a130-c0baa1291783"),
},
},
            new GuiduuidArray1M
{
    Id = 91,
    Value = 
new System.Guid[3]
{
Guid.Parse("dbb8a4aa-5178-4e06-b7f8-e7e9eb5fdbc7"),
Guid.Parse("c3621c70-a05c-4c8d-a4d8-f69b85cb2e27"),
Guid.Parse("0745d907-233f-4720-a564-a1e42ed2f437"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 58,
    Value = 
new System.Guid[4]
{
Guid.Parse("a8b24fdd-686c-4e1c-a859-7f8eceb50826"),
Guid.Parse("b6f00cfc-7e4b-48ae-85f6-d4020ef207f9"),
Guid.Parse("e087baf3-75c0-4990-a205-07a74de17968"),
Guid.Parse("a4f77d27-a81f-4499-b9ae-0bbfc9d66c6e"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("108996ab-594f-4037-a221-9c328e72f498"),
Guid.Parse("529fdbb4-01da-4231-9e9b-8e81521bc98b"),
Guid.Parse("c6f2056e-20e6-437f-8eb9-27a4fcf05d25"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 96,
    Value = 
new System.Guid[3]
{
Guid.Parse("fb42d44b-6790-4c98-b670-204798c99158"),
Guid.Parse("2523e61b-96b8-420c-9445-87d8a10daaaa"),
Guid.Parse("b8cfb2bb-01af-4d57-84af-b101874acb54"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("4d975d63-58dc-4cd7-a209-5e505c199c40"),
Guid.Parse("ba40c0d7-44cf-43ac-b3e1-58cb17d542ab"),
Guid.Parse("e88ce350-6d68-4c69-8f4b-45a69aea0e29"),
Guid.Parse("2c7e88fe-8fb9-42e0-b3d7-423431c25d3e"),
},
},
            new GuiduuidArray1M
{
    Id = 99,
    Value = 
new System.Guid[4]
{
Guid.Parse("bb263ac6-b0a9-4d5e-992c-89d861f6a7f3"),
Guid.Parse("43087a11-e986-452e-bf31-16a78d01881d"),
Guid.Parse("1ccbaec0-6a97-44f5-9400-322cbd76ae76"),
Guid.Parse("74d71a6a-e4d3-4706-92f1-98ca94ff6d51"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 63,
    Value = 
new System.Guid[4]
{
Guid.Parse("fd7b1d49-49cc-45b9-b17f-392f5474a35b"),
Guid.Parse("5d5f793e-6bff-49ec-b23d-9e8b6c87ff7c"),
Guid.Parse("b043cbeb-0ff2-464e-83c1-0143af68ecc3"),
Guid.Parse("58954e57-f758-41bd-a006-801be12ee6ee"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("203cf31e-3b10-4641-930a-54685a82d0c7"),
Guid.Parse("82dc3a22-341f-4c78-b048-7ea0def54d93"),
Guid.Parse("b1bfb4d9-c589-48e3-adad-a14da0869e40"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("6163b725-5775-423a-958a-bd8f24b4265c"),
Guid.Parse("7a8844ff-e109-4d59-b3af-798aefc92b77"),
Guid.Parse("ffd6e76c-5d5c-4fe4-a7e4-762fac77e12d"),
},
},
            new GuiduuidArray1M
{
    Id = 101,
    Value = 
new System.Guid[4]
{
Guid.Parse("efc90c98-5a81-4422-840d-3a8b2130d907"),
Guid.Parse("859ac343-2d1f-45cb-b723-9bfa10e3eb2a"),
Guid.Parse("317161ff-04ab-4136-a01d-7ffdd21186f9"),
Guid.Parse("10f8107c-8d19-40ac-bba4-7f4c1a596ff9"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("c312ef3f-2b0b-407d-afc5-11979de768e0"),
Guid.Parse("d245ecad-9b06-4494-9a27-92e8ea3614cf"),
Guid.Parse("b853493d-cb3c-4c3a-8981-0dab30f09e69"),
Guid.Parse("33ae6c5c-3a83-4b58-bd4e-4937bfbc1ea0"),
},
},
            new GuiduuidArray1M
{
    Id = 110,
    Value = 
new System.Guid[4]
{
Guid.Parse("db3cdfdd-d264-4d85-88be-4b727fbfed48"),
Guid.Parse("16763b1a-c466-4d27-8e66-1a714b764c75"),
Guid.Parse("39aed65b-cc65-41e5-9355-bb95960f9214"),
Guid.Parse("7486ea0b-9cc5-433d-b527-2182ada2ff6d"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 65,
    Value = 
new System.Guid[4]
{
Guid.Parse("d1caf916-ae9a-4db1-84ef-b8c3b5776d6c"),
Guid.Parse("55a5273d-ef53-4207-99c6-3e46c24f918d"),
Guid.Parse("8a596c1f-3ffd-4e07-8794-cdb80f504176"),
Guid.Parse("a4d2a2cf-5dc3-4e49-9e72-062cb9ff8b72"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("ec002d76-82ec-4294-959a-e555a46df899"),
Guid.Parse("c4f5e80c-a83b-4fd3-b4b6-2ae5c5411051"),
Guid.Parse("153b99f9-c8d9-455b-8403-2b7c2392ee50"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 112,
    Value = 
new System.Guid[3]
{
Guid.Parse("6e7f0fb5-0091-493a-8834-5102c663eec0"),
Guid.Parse("079e75d6-fcae-4f22-a655-4e7ed6278698"),
Guid.Parse("e6705c37-80bd-4430-94f8-8798d2127417"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("925e007d-fa08-40a9-92b6-21618078661d"),
Guid.Parse("7a2b407a-dc69-4fa4-98df-98850c05f60e"),
Guid.Parse("5582ea01-dce2-4cd9-af38-a7fdd17be08f"),
},
},
            new GuiduuidArray1M
{
    Id = 113,
    Value = 
new System.Guid[3]
{
Guid.Parse("25a2655e-e37d-4b88-a8a8-7b0f6beb6f5b"),
Guid.Parse("9699c215-f081-4ec2-a09a-cdd5fec922f8"),
Guid.Parse("ee54971e-227f-40dc-b425-7206291cdd6a"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 66,
    Value = 
new System.Guid[3]
{
Guid.Parse("7b720e42-cabe-4816-aba8-bfa96339d517"),
Guid.Parse("7dd83512-4e70-4b7a-9dc6-b16302fbf65d"),
Guid.Parse("d05b919e-aa11-4f97-821b-a066830edec0"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("7cdb290e-ff8d-4734-bb2b-7b347eee7494"),
Guid.Parse("03840c89-98d2-4ab5-b8d6-5c8b56a8f0a7"),
Guid.Parse("bcdfef41-0e4d-49a3-9eb1-3741e1dedb9d"),
Guid.Parse("463dff93-f6fa-4203-b5c3-cdda5ce650e6"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("f041ddc7-07ee-4e06-9527-9a27714cb3e2"),
Guid.Parse("572c61cd-f272-4aae-a8be-85a4989fe0e4"),
Guid.Parse("8ba5f696-6768-4a6c-9541-20bc655b1110"),
},
},
            new GuiduuidArray1M
{
    Id = 122,
    Value = 
new System.Guid[4]
{
Guid.Parse("4e340c1a-6eec-459d-9586-b37bb0c57585"),
Guid.Parse("7a1344a7-8e2d-48e1-93eb-c8be83e7ecd4"),
Guid.Parse("c493b1b9-30d8-4d7e-be6b-61e69a7d5815"),
Guid.Parse("777484ad-a56d-4251-b79a-adac648344bb"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 130,
    Value = 
new System.Guid[3]
{
Guid.Parse("dc5eab31-8342-40d6-aa14-3d2fd1e44407"),
Guid.Parse("41859d26-3d2a-44fc-a4c4-a861ee188aec"),
Guid.Parse("7c8a7841-d339-4e1b-aaf2-715c2c069058"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 73,
    Value = 
new System.Guid[4]
{
Guid.Parse("ee4a2436-b55e-473b-a320-c219bb5d89f7"),
Guid.Parse("c83e17cf-195e-4fd4-abec-cb4647a5b4f2"),
Guid.Parse("66e4c367-878e-4b60-bab3-c934ffc1c86d"),
Guid.Parse("a7f06def-82ca-4c4d-bff5-f1c6dca00a73"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("4d4c2ea2-b47b-4938-98d9-7587bbebb7ec"),
Guid.Parse("ef32466f-5d32-47ba-bd67-313fa9a990fe"),
Guid.Parse("56465125-3994-44de-8ff2-65cda7d7d0a5"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 133,
    Value = 
new System.Guid[4]
{
Guid.Parse("92df46fe-39a8-47fe-86ec-86dd2daa9183"),
Guid.Parse("944e4306-4b5a-4ec4-abbb-9061a9335a5c"),
Guid.Parse("4b826704-8165-457b-a62c-b268368e1a42"),
Guid.Parse("3dbefdb1-3d4e-43b1-b6dc-2f10f07996b0"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 140,
    Value = 
new System.Guid[3]
{
Guid.Parse("b7bece9a-0846-4913-85d3-d499fe8708b8"),
Guid.Parse("33579b6a-31d2-4ef0-a648-ce5a3ff2f685"),
Guid.Parse("eb92aa8d-198f-4046-964f-0189d43cc31e"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 77,
    Value = 
new System.Guid[4]
{
Guid.Parse("949dc977-9b0a-4632-a810-9c1c744a1300"),
Guid.Parse("b96f125c-04ac-451c-8d2d-c0566b6fefba"),
Guid.Parse("b7d2bde5-0f3f-4f4a-ad57-0af8523edfd4"),
Guid.Parse("7041e252-2456-47c5-84f9-555aeb24db68"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("812e9569-bae9-4506-9200-c95ad2f0cd2c"),
Guid.Parse("f929acb6-0e2c-467e-85a5-535aef99cb58"),
Guid.Parse("ba0b3bee-6505-4179-9f20-a8eff4d25e32"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 142,
    Value = 
new System.Guid[4]
{
Guid.Parse("c90fd2e3-905a-41b2-af2b-8b9f11c0dd63"),
Guid.Parse("9a44d7d6-7779-4851-a5eb-2545cda5ddc5"),
Guid.Parse("b9c5acdf-399c-481d-9d6b-e4414c48952a"),
Guid.Parse("f079acbd-b97a-4208-b8e8-3a70d6462630"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 150,
    Value = 
new System.Guid[3]
{
Guid.Parse("2949fc32-bc11-4076-9861-5a97b3c4e775"),
Guid.Parse("556f344f-987c-44e7-972b-be5e2dedc888"),
Guid.Parse("506df0b1-8574-4bbe-9097-3718bb6b44d5"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 80,
    Value = 
new System.Guid[3]
{
Guid.Parse("673011d1-e853-4394-8d87-503b854d5c0c"),
Guid.Parse("514859c6-3300-447d-823e-2e6f440aa05f"),
Guid.Parse("cab05191-5105-497b-b0db-a669d863a36b"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 155,
    Value = 
new System.Guid[3]
{
Guid.Parse("47d05a09-c217-48b5-adbc-f2d23124b195"),
Guid.Parse("56492b8a-bc2d-4ec7-bc94-37c033b51d3a"),
Guid.Parse("e91e62cd-4404-4b9a-949c-ded01ba1b650"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("a0f2e5b1-b27a-446e-a7e2-7445107521e2"),
Guid.Parse("7aabe1d6-354a-4ec7-9015-8a7fb834c629"),
Guid.Parse("65bd0db9-3ada-4293-a4c9-b9dbf873a34a"),
},
},
            new GuiduuidArray1M
{
    Id = 164,
    Value = 
new System.Guid[4]
{
Guid.Parse("da856997-31be-467d-8c9f-4dbdd822cd67"),
Guid.Parse("bae287ac-5866-4dc1-9357-08a5a61940c5"),
Guid.Parse("7bcafb3c-2c7a-49ff-9257-4e0c293d7c09"),
Guid.Parse("ab610e6c-5711-4860-bcef-0c74aef8d702"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 87,
    Value = 
new System.Guid[3]
{
Guid.Parse("4696b86f-1c00-40ce-82dc-c9131194f1a1"),
Guid.Parse("c51ba371-27f8-4e40-b688-108109444239"),
Guid.Parse("b30fe740-5c89-47e3-827f-a101e7974522"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("67344a52-6e4c-47b7-beb6-c29bb18c3bd3"),
Guid.Parse("b35d5f2f-838c-4c98-8596-fc05f04681e1"),
Guid.Parse("5b54f389-4746-4438-a71d-e93c2848f9f8"),
Guid.Parse("0006fac3-f329-4446-811f-a8146660937d"),
},
},
            new GuiduuidArray1M
{
    Id = 168,
    Value = 
new System.Guid[4]
{
Guid.Parse("fdc3de19-8c4a-4bbc-b035-f5fed5cb4b92"),
Guid.Parse("8a3f5c5d-8954-4007-a3ae-48219d256854"),
Guid.Parse("8f300fa3-519f-49bc-a9dd-5ece8043639b"),
Guid.Parse("0a9e87ac-0763-457c-819e-3f988c777cbc"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("198c6ba1-d411-4512-9905-fad998cde79a"),
Guid.Parse("7db2f5ae-ff6c-47ec-b9df-aa57eb4c5747"),
Guid.Parse("a6a9cd72-16b0-4501-9e4d-38ce4c210fd3"),
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

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                Assert.That(nullable, Is.Null);
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
Guid.Parse("1d3514ba-c2c3-49be-ba50-b6363ee3188d"),
Guid.Parse("9d585547-9bc5-45de-9d85-6361019f506b"),
Guid.Parse("1a82f8b8-3675-4b25-916b-45c9609ee9d5"),
Guid.Parse("02502a8f-1219-4b58-9e43-61fc7f57cd04"),
}));
                nullable =  ((IGuidArrayuuidArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("60b490ec-7d7a-44fb-99ea-726168d35a2c"),
Guid.Parse("f9d494eb-fcd8-4b1d-84b0-3a9f8426c911"),
Guid.Parse("cc4c187f-d54f-4112-a420-e859b4118f2f"),
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
Guid.Parse("99c59b29-e54e-404c-b685-588cdc9b6a87"),
Guid.Parse("8ffe016a-7673-4787-8fdf-daf1fb3882c1"),
Guid.Parse("8ffa3ccd-d166-4239-a08b-4b7a6676ea96"),
}));
                nullable = await ((IGuidArrayuuidArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("b559c60b-7cb1-4516-98ac-b192079d9e99"),
Guid.Parse("2d7809c9-7913-472d-bb3d-27dd9c23e580"),
Guid.Parse("27178830-57c1-4cb2-aa6a-ecdb5ccc64c7"),
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
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 122;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
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
                        FlatGuiduuidArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[33],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
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
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[19],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[20],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[21],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[22],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[19],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[20],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[21],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[22],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
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
                        FlatGuiduuidArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
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
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[19],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[20],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[21],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[22],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[23],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[24],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[25],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[26],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[27],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[28],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[29],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        GuiduuidArray1M.AssertModel(models[0],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

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
                        GuiduuidArray1M.AssertModel(models[21],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[22],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[23],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[24],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[25],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        GuiduuidArray1M.AssertModel(models[0],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        GuiduuidArray1M.AssertModel(models[0],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
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
                await ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 130, query1, 142, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[34], false);
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
                await ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 96, query1, 150, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
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
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
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
                 ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 43, query1, 63, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[34], false);
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
                 ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 96, query1, 16, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
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
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
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
                        FlatGuiduuidArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[32],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 36, query1, 91, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[19],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[20],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[21],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[22],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[23],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[24],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[34], false);
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
                await ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 142, query1, 130, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 155, query1, 122, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[34], false);
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
                 ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 122, query1, 21, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[30],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelBatchAsync(connection, 61, 99))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        GuiduuidArray1M.AssertModel(models[0],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        GuiduuidArray1M.AssertModel(models[0],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelBatch(connection, 19, 113))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

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
                        GuiduuidArray1M.AssertModel(models[27],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[28],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[29],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[30],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        GuiduuidArray1M.AssertModel(models[0],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[34], false);
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
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 122);
                var models = await ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                GuiduuidArray1M.AssertModel(models[0],_testData[27], false);
                GuiduuidArray1M.AssertModel(models[1],_testData[28], false);
                GuiduuidArray1M.AssertModel(models[2],_testData[29], false);
                GuiduuidArray1M.AssertModel(models[3],_testData[30], false);
                GuiduuidArray1M.AssertModel(models[4],_testData[31], false);
                GuiduuidArray1M.AssertModel(models[5],_testData[32], false);
                GuiduuidArray1M.AssertModel(models[6],_testData[33], false);
                GuiduuidArray1M.AssertModel(models[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidArrayuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 63);
                var models =  ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(20));

                GuiduuidArray1M.AssertModel(models[0],_testData[15], false);
                GuiduuidArray1M.AssertModel(models[1],_testData[16], false);
                GuiduuidArray1M.AssertModel(models[2],_testData[17], false);
                GuiduuidArray1M.AssertModel(models[3],_testData[18], false);
                GuiduuidArray1M.AssertModel(models[4],_testData[19], false);
                GuiduuidArray1M.AssertModel(models[5],_testData[20], false);
                GuiduuidArray1M.AssertModel(models[6],_testData[21], false);
                GuiduuidArray1M.AssertModel(models[7],_testData[22], false);
                GuiduuidArray1M.AssertModel(models[8],_testData[23], false);
                GuiduuidArray1M.AssertModel(models[9],_testData[24], false);
                GuiduuidArray1M.AssertModel(models[10],_testData[25], false);
                GuiduuidArray1M.AssertModel(models[11],_testData[26], false);
                GuiduuidArray1M.AssertModel(models[12],_testData[27], false);
                GuiduuidArray1M.AssertModel(models[13],_testData[28], false);
                GuiduuidArray1M.AssertModel(models[14],_testData[29], false);
                GuiduuidArray1M.AssertModel(models[15],_testData[30], false);
                GuiduuidArray1M.AssertModel(models[16],_testData[31], false);
                GuiduuidArray1M.AssertModel(models[17],_testData[32], false);
                GuiduuidArray1M.AssertModel(models[18],_testData[33], false);
                GuiduuidArray1M.AssertModel(models[19],_testData[34], false);
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
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
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

                await ((IGuidArrayuuidArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidArrayuuidArray)this).DynQueryWASelectImportModelInnerAsync(connection);
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
        public  void DynQueryWAImportModelInnerTest()
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

                ((IGuidArrayuuidArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidArrayuuidArray)this).DynQueryWASelectImportModelInner(connection);
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
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
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
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<GuiduuidArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
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
                Assert.That(models, Has.Count.EqualTo(8));
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
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void WASelectImportModelInnerConfig()
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
            methodName:"WAImportModelInner",
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidArrayuuidArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidArrayuuidArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
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

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<GuiduuidArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidArrayuuidArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IGuidArrayuuidArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
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
            queryMapTypes: [typeof(GuiduuidArray1MIWA)],
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(GuiduuidArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
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

                await ((IGuidArrayuuidArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidArrayuuidArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
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

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<GuiduuidArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
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

                ((IGuidArrayuuidArray)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidArrayuuidArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IGuidArrayuuidArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IGuidArrayuuidArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IGuidArrayuuidArray)this).ImportModel(connection, importCollection);
                var models = ((IGuidArrayuuidArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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

        [Test, Order(13)]
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
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA), typeof(GuiduuidArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
                var models1 = new List<GuiduuidArray1MIWA>();
                var models2 = new List<GuiduuidArray1MIWA>();
                await ((IGuidArrayuuidArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidArray1MIWA>();
                var models2 = new List<GuiduuidArray1MIWA>();
                ((IGuidArrayuuidArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
                var models = await ((IGuidArrayuuidArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidarray1mi
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
                    GuiduuidArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidArrayuuidArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_guiduuidarray1mi
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
                    GuiduuidArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA), typeof(GuiduuidArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
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
                var models1 = new List<GuiduuidArray1MIWA>();
                var models2 = new List<GuiduuidArray1MIWA>();
                await ((IGuidArrayuuidArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidArray1MIWA>();
                var models2 = new List<GuiduuidArray1MIWA>();
                ((IGuidArrayuuidArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
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
                var models = await ((IGuidArrayuuidArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidarray1mi
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
                    GuiduuidArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidArrayuuidArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_guiduuidarray1mi
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
                    GuiduuidArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MI), typeof(GuiduuidArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
                var models1 = new List<GuiduuidArray1MI>();
                var models2 = new List<GuiduuidArray1MI>();
                await ((IGuidArrayuuidArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidArray1MI>();
                var models2 = new List<GuiduuidArray1MI>();
                ((IGuidArrayuuidArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(model2, expectedModel, false);
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
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
                var models = await ((IGuidArrayuuidArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidArrayuuidArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA), typeof(GuiduuidArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
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
                var models1 = new List<GuiduuidArray1MIWA>();
                var models2 = new List<GuiduuidArray1MIWA>();
                await ((IGuidArrayuuidArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidArray1MIWA>();
                var models2 = new List<GuiduuidArray1MIWA>();
                ((IGuidArrayuuidArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
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
                var models = await ((IGuidArrayuuidArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidArrayuuidArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

