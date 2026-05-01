

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
    Id = 2,
    Value = 
new System.Guid[4]
{
Guid.Parse("ac7461cc-37fe-4dd5-a7a4-e4c8756d9868"),
Guid.Parse("2868a56f-af4d-4004-a373-fde1aa65f45c"),
Guid.Parse("3061e310-3f83-453b-9bf1-cc3cab21d646"),
Guid.Parse("93482889-9413-4551-8641-89929034c484"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 3,
    Value = 
new System.Guid[4]
{
Guid.Parse("7858e91c-20b6-4c16-9669-68ed7a2a5f5e"),
Guid.Parse("d162a98c-e1e3-46d6-bc2a-1751231e0c17"),
Guid.Parse("4ffdead8-0e4f-4d44-8c3a-09a6e8f6230c"),
Guid.Parse("3e94922e-19ff-4fcb-8b05-64f33b569e7e"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 9,
    Value = 
new System.Guid[3]
{
Guid.Parse("f784ff84-8a59-42f2-94c5-46905294b466"),
Guid.Parse("3323909a-4a2b-4026-abfb-83d819b61a8c"),
Guid.Parse("c3c2185e-198c-4514-9a2e-fa67adf08069"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("c3a9bb1b-404f-4007-87b0-b41fba556764"),
Guid.Parse("721beca9-469b-45cb-a1b7-44f02f5c9ff3"),
Guid.Parse("33005317-a363-4ffd-a40a-71c01fac6c69"),
},
},
            new GuiduuidArray1M
{
    Id = 10,
    Value = 
new System.Guid[3]
{
Guid.Parse("ffe02d86-faba-430b-9142-2ac31d0d9d47"),
Guid.Parse("5fef9169-bae6-4491-a50f-7581fc1ee3f3"),
Guid.Parse("2551ae66-d087-488a-b176-c0f66505ff1e"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("a1af2372-0d0e-4f3e-b4b4-77f05116320d"),
Guid.Parse("e28bd553-2435-4ca4-bca6-7d257a35b3f6"),
Guid.Parse("30b06b03-0c6f-4994-935f-b6a5426944f3"),
Guid.Parse("84a5e4ff-6b06-4a43-9b08-9e49c2fb2bc6"),
},
},
            new GuiduuidArray1M
{
    Id = 12,
    Value = 
new System.Guid[4]
{
Guid.Parse("71b10662-1bad-4b2b-bfc5-858f286ed671"),
Guid.Parse("ccdd6ee0-a175-4e9c-a3fb-40d15b54908f"),
Guid.Parse("9d7d19be-df45-4568-bf17-0c3011a7973e"),
Guid.Parse("38a5f8a5-52c6-4a3e-829d-3e20aa13e2a5"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 13,
    Value = 
new System.Guid[3]
{
Guid.Parse("2c99ae8d-dd1d-407f-875c-bc7c917313ff"),
Guid.Parse("97feefc5-7e67-46f6-8102-eeef5cbecfaa"),
Guid.Parse("8fb0a74b-f56a-44a3-9436-8474d5ca5c6e"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 16,
    Value = 
new System.Guid[4]
{
Guid.Parse("1b217e5e-c2f1-4c1a-98f5-4c51fb2f4f34"),
Guid.Parse("5a54ed1a-ac09-4d58-8a80-033c4c29d928"),
Guid.Parse("5ac12629-d766-4a2a-bcca-bce8ee07df05"),
Guid.Parse("06315ebb-9b84-4a1b-ae37-b9815d55b9e8"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("29ad59ba-a608-4bd0-b2a7-340f328b7d27"),
Guid.Parse("34f9bbda-363e-471c-86bd-7a6cc2f5eb3e"),
Guid.Parse("cab9e67c-e5ff-4e57-9418-e55dee9b0458"),
Guid.Parse("e71cc180-12b5-4473-9eec-1fa7c1f6f1e3"),
},
},
            new GuiduuidArray1M
{
    Id = 20,
    Value = 
new System.Guid[4]
{
Guid.Parse("d4d43255-a4e0-48c3-98ff-a6b70b206592"),
Guid.Parse("1d331043-75a7-4302-acf4-494ddf7a19ea"),
Guid.Parse("28937250-17a1-43c2-a243-bab0c1644906"),
Guid.Parse("9f10d15d-e402-4009-94e8-f5f875362bb1"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 22,
    Value = 
new System.Guid[3]
{
Guid.Parse("8aae4015-58ee-4817-9de5-b78967a87ed0"),
Guid.Parse("c38d6f12-77a2-4bd5-aa6f-cf31de5cc71a"),
Guid.Parse("0abbd8ca-1d48-4326-afff-d9bcc0da4788"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("5f7f5173-89ca-4866-b8f7-2750fa6cf454"),
Guid.Parse("34289513-4aaa-477a-a3d8-aa4147bfd792"),
Guid.Parse("5268be5f-de0a-412d-956a-9a17b7d4d652"),
Guid.Parse("afd3c3fd-ae89-441c-9323-7127bb72aea7"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("76cab462-e941-4f64-a458-ca7f97c1e5b1"),
Guid.Parse("54dc3ec1-14da-45fd-bee4-dcf4943f59ff"),
Guid.Parse("7255d567-08c8-4fba-8b85-5bae15d531c0"),
},
},
            new GuiduuidArray1M
{
    Id = 25,
    Value = 
new System.Guid[3]
{
Guid.Parse("f0d457fc-fee1-4c73-88c6-aac40fd3b82e"),
Guid.Parse("e0eea984-57b6-40bb-987b-722fc6fc434e"),
Guid.Parse("eeb7e45b-6de4-42eb-b324-637babd7e019"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 34,
    Value = 
new System.Guid[3]
{
Guid.Parse("9103c025-4245-4971-83c8-c9ba937c8df5"),
Guid.Parse("a1742215-1c6d-458a-af84-d6bd3ba47c12"),
Guid.Parse("11e5a4da-81ea-4f26-ace4-862baaf2f42c"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 25,
    Value = 
new System.Guid[3]
{
Guid.Parse("9a019dc6-ca34-4f54-9f19-1a5b474f5e07"),
Guid.Parse("7b2f34bd-8509-4c71-94a1-737b3e74b49d"),
Guid.Parse("d523ab90-6ac9-47a3-b655-afe77cc89bbc"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("ec4dc593-f303-4ea4-b030-1f6b0c19d065"),
Guid.Parse("f50a44b0-222c-4523-bbfa-81eb7c987f68"),
Guid.Parse("5d079cc6-fabd-47a1-b39b-181812624da8"),
},
},
            new GuiduuidArray1M
{
    Id = 37,
    Value = 
new System.Guid[3]
{
Guid.Parse("2d9362ff-a6b3-499b-bd81-171a55052594"),
Guid.Parse("84326adc-d355-4e18-86e7-f8c781bbcc8a"),
Guid.Parse("7d684d03-b7fc-499b-b7d5-189e37834440"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("ca5bbfb4-155a-423e-b7cc-05bb835cbb63"),
Guid.Parse("ff112c02-2690-4ad0-b83f-6b5fd246324e"),
Guid.Parse("3ef8a257-aad2-44ba-b6f3-a5878564e2b1"),
},
},
            new GuiduuidArray1M
{
    Id = 38,
    Value = 
new System.Guid[3]
{
Guid.Parse("51a165ec-583c-4922-8d2f-7b8fc38b0cf7"),
Guid.Parse("60c81aaa-9a3f-4866-8849-2d2a3351a142"),
Guid.Parse("e6edd6f6-5e92-4840-a6a7-5a786320b730"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 32,
    Value = 
new System.Guid[3]
{
Guid.Parse("8778b4cd-ca7d-4602-923e-67744ab8dbc5"),
Guid.Parse("31e07040-3cf0-4321-9033-f5dfcef31994"),
Guid.Parse("f34894f1-8167-483a-9d40-5c7475992c17"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("f3c8480d-0435-4d72-9cfc-8f96185b290a"),
Guid.Parse("556c4842-7aaf-4403-84d0-c58c8f85467f"),
Guid.Parse("4726ba08-e95a-441e-91b7-7cc1618581f3"),
},
},
            new GuiduuidArray1M
{
    Id = 44,
    Value = 
new System.Guid[4]
{
Guid.Parse("cc3f8361-5743-426c-bb25-4ceff6dbe93e"),
Guid.Parse("3d54ed78-ad99-49db-8d33-c167d90b7558"),
Guid.Parse("c430db15-bc5d-45c4-a53b-eab0f18e9e23"),
Guid.Parse("cb26b251-bbd7-46bc-b9ab-91141040e469"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 46,
    Value = 
new System.Guid[3]
{
Guid.Parse("62798e26-0c58-442f-bfbc-93a5692424f2"),
Guid.Parse("5c98638e-da94-43ab-b45f-3b92ba525495"),
Guid.Parse("c00c4a58-c3f2-4e67-bcb4-2a3894ce45e7"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 40,
    Value = 
new System.Guid[3]
{
Guid.Parse("ecda67d6-ff19-463f-99a3-9bf7f85579cf"),
Guid.Parse("b66b06ee-c94e-48f3-9a08-ae0460516856"),
Guid.Parse("54cc6b1e-8382-4226-b262-84b08d09bf76"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("9424e385-e4ec-4460-96f7-98b4bcb8a460"),
Guid.Parse("36c9fcb2-146c-4db3-8b7c-b5236451ab73"),
Guid.Parse("524de17a-13df-496b-a20f-4c97649211dd"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 55,
    Value = 
new System.Guid[4]
{
Guid.Parse("55ae478e-7f09-48b4-8e09-481364e24dd6"),
Guid.Parse("d234d0a8-03b6-4d9d-a456-78fbb2cd8b4f"),
Guid.Parse("94b2e716-5569-41a1-869c-0aed47430a1b"),
Guid.Parse("49d7ef58-0b7f-4e2c-84b4-b8e9cf4fe036"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 62,
    Value = 
new System.Guid[3]
{
Guid.Parse("3ca7b13f-f659-4890-a2a3-b26b1f2d76ff"),
Guid.Parse("09da4cdd-d04c-4c63-8b03-c78ff9d2a31c"),
Guid.Parse("097d2792-91f7-4b3d-b230-1fd84b8534ff"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 47,
    Value = 
new System.Guid[4]
{
Guid.Parse("5e636988-f9d4-4a81-992d-8f969a8b9216"),
Guid.Parse("27764944-ac07-490d-8090-bbf73aacc106"),
Guid.Parse("653843e2-2752-4b41-a09a-09d367e46414"),
Guid.Parse("0703056c-78ec-41b2-926c-f22e5707f539"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("e905a040-c4a9-4ada-9129-0c54a8c889a3"),
Guid.Parse("b09bae55-aa67-490c-9e8d-670906ab7573"),
Guid.Parse("eca699d5-9bb3-4aef-9672-c6c95c84ec8d"),
Guid.Parse("2da956d9-f006-41a5-8f25-bc8b20002829"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 67,
    Value = 
new System.Guid[3]
{
Guid.Parse("4d27cd47-80d4-4616-9b7e-cd24434be365"),
Guid.Parse("05f6c42c-be58-48c7-a498-f13b03651d5d"),
Guid.Parse("87a69f44-c12c-4c14-b443-dd3394081f28"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 69,
    Value = 
new System.Guid[3]
{
Guid.Parse("376fdabd-0691-4e01-9d01-90f6c5fcbe0b"),
Guid.Parse("2df87f33-c97d-41cb-8328-143e596f4075"),
Guid.Parse("75079ce6-5076-4f62-bb1f-2e97cfb058ac"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 52,
    Value = 
new System.Guid[3]
{
Guid.Parse("79223822-ddc4-4b8d-a094-35bd1fe85d39"),
Guid.Parse("190f9c19-2d5e-4a48-9dc9-7f50012ee161"),
Guid.Parse("f7c8172d-788c-4502-b8fd-da9d3186c9ee"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 72,
    Value = 
new System.Guid[4]
{
Guid.Parse("7703c663-dc0b-4cdd-b554-8c503c16a6f3"),
Guid.Parse("2127c7bd-8e29-4be2-861f-947dd292c35d"),
Guid.Parse("a778a9d3-d6ec-4cc7-bb7a-c456ded238ce"),
Guid.Parse("47dce802-1ee4-402e-b1b5-a99f066633b9"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("aaaa9b64-a41a-41cc-bdd1-3fba74b1db15"),
Guid.Parse("71e30467-4136-4569-bbe9-6f49e92dcc9e"),
Guid.Parse("0f685d7a-ea97-4e06-8db8-7b25c5ffe68a"),
},
},
            new GuiduuidArray1M
{
    Id = 79,
    Value = 
new System.Guid[3]
{
Guid.Parse("055b26f7-2bf3-4bd4-b706-ba891476be20"),
Guid.Parse("e39cf362-c6da-4cc8-8524-33497d505dd6"),
Guid.Parse("d31a6686-5a91-49a4-a1de-31c30ab98b79"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 60,
    Value = 
new System.Guid[3]
{
Guid.Parse("7d96a65d-3b7e-4a9a-942b-7fde4991d3f2"),
Guid.Parse("1d91a61a-c8b2-4106-b257-47854826babe"),
Guid.Parse("acdc47c3-b640-47c4-a901-b238f964a292"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("20b0f0ee-70a2-4c23-8fc4-3eea4d2e57bb"),
Guid.Parse("d1a61541-1092-4e36-8c23-2a2fea8df7c9"),
Guid.Parse("98316b97-129b-4f1f-912f-76bed5072ac6"),
Guid.Parse("ddf99b8e-861c-4529-8202-20256ca839d5"),
},
},
            new GuiduuidArray1M
{
    Id = 83,
    Value = 
new System.Guid[3]
{
Guid.Parse("67cd2216-835c-4510-a549-6af272d40062"),
Guid.Parse("9b7f44c6-d72b-4598-8d0f-519184fd8c7b"),
Guid.Parse("ca4db556-3091-4a29-a3c8-b760012fe110"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 86,
    Value = 
new System.Guid[4]
{
Guid.Parse("409cc62e-9e25-4fa5-a2ee-e96f7dbcc767"),
Guid.Parse("74d1e25c-98be-4556-a4cb-8c1f32ec2833"),
Guid.Parse("28a04a59-4932-468f-b372-f819a679b4db"),
Guid.Parse("25584b4f-4b32-4014-a491-ea1cba2bf356"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 67,
    Value = 
new System.Guid[3]
{
Guid.Parse("b50fb588-bd16-4422-b228-9d20ff875f08"),
Guid.Parse("b580f865-c308-46cd-b89f-3a987d2b438a"),
Guid.Parse("f3fb50ed-b4b0-4535-b0a3-8dc879c48a63"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("d816154d-65ce-428e-a482-b5f090976c60"),
Guid.Parse("f9662603-3cf5-4ce7-bf24-a28e011577f9"),
Guid.Parse("75baeb25-2af2-481e-8506-85f00ce6f010"),
Guid.Parse("c8716caf-086c-41b7-a4d8-13287c5a4c6e"),
},
},
            new GuiduuidArray1M
{
    Id = 95,
    Value = 
new System.Guid[3]
{
Guid.Parse("a654b78f-f97e-4387-9a28-04d23334f20c"),
Guid.Parse("c83aad26-6fd8-4b1d-9bbc-c189a18cb4ba"),
Guid.Parse("2d849185-a0c2-4ea9-96f8-e6c9fe50a10a"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("55eb3d58-ab3a-413e-9496-9ddbe29cf40c"),
Guid.Parse("776b063f-3cfa-4be9-9a80-87aa0b224107"),
Guid.Parse("9bf8ac66-4d3b-4185-b217-289f76608581"),
Guid.Parse("2a920723-da49-4007-ba70-3f751dfd24fd"),
},
},
            new GuiduuidArray1M
{
    Id = 96,
    Value = 
new System.Guid[4]
{
Guid.Parse("c7cdd0e2-27e9-4304-8858-679fb9f84aef"),
Guid.Parse("e9beb9d1-2f9a-4882-8592-a04d8356e1af"),
Guid.Parse("c5a4032f-0e5f-4a82-a1dc-1d65beff7d11"),
Guid.Parse("4a0b1a93-3af3-4b31-93dc-b7994e7974e9"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 74,
    Value = 
new System.Guid[3]
{
Guid.Parse("a62808b9-9cf5-4d7e-b02c-a16fc02eed16"),
Guid.Parse("3f37779d-04e2-4307-b590-dd68882b8595"),
Guid.Parse("c63d819b-a647-40f7-85a1-2bf8e5c925e1"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 99,
    Value = 
new System.Guid[3]
{
Guid.Parse("01f34f50-25e3-4c64-826a-a0cfaf26e30d"),
Guid.Parse("9a806995-a3ec-4f64-8f66-715e545b11d1"),
Guid.Parse("53c173d7-4488-4ce8-b3f7-226678d9db99"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 108,
    Value = 
new System.Guid[4]
{
Guid.Parse("256cc868-27c7-4c8b-b3a9-b9696e145b49"),
Guid.Parse("e45ffcc4-aeee-467d-a65b-1bf4830d767a"),
Guid.Parse("b9c07f95-ab71-48f4-8f0d-dba6ebabd050"),
Guid.Parse("17f9ae27-edfc-4b02-b553-25b1015b189d"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 82,
    Value = 
new System.Guid[4]
{
Guid.Parse("349c31b2-d5b5-4b5b-80ec-1a1bf7987bbc"),
Guid.Parse("5d47a920-5ed2-4432-9cf9-b168f3f55f3c"),
Guid.Parse("9af611a6-c8e4-4843-b89a-dfe5bc72f44f"),
Guid.Parse("6b61347a-96bc-4c43-9142-a1594a89fdf6"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 117,
    Value = 
new System.Guid[4]
{
Guid.Parse("40c9da55-734a-466a-9b71-ea9dfec5b0dd"),
Guid.Parse("081b961c-c031-4907-bcc6-8fb943e26bac"),
Guid.Parse("264c3bcd-6b04-4aa6-ac4d-91b9f3bda181"),
Guid.Parse("58da2812-4df8-4106-aaa1-c85eed62440a"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 119,
    Value = 
new System.Guid[4]
{
Guid.Parse("db64423e-a8ad-4ec4-b8ab-fcd5be9b20b0"),
Guid.Parse("13fc0064-316c-411f-95b2-1374ad5f4184"),
Guid.Parse("b39729d4-4a0c-4c5a-9a25-985f94d0326e"),
Guid.Parse("3bdcb26d-0d95-4ef6-a7e0-8942f42ac7a0"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 89,
    Value = 
new System.Guid[3]
{
Guid.Parse("f2237c49-3022-4200-8a0a-019a04e8c2cc"),
Guid.Parse("d2d5fbf3-a1ce-4220-ae35-80f6f702eb6c"),
Guid.Parse("61bf00c7-40f2-4859-9bbe-1948c1834745"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 124,
    Value = 
new System.Guid[4]
{
Guid.Parse("04ed84c8-5760-4d12-92d7-6a6d09ba959b"),
Guid.Parse("26ed8b9b-3c6c-4e53-9eca-8dcf849a7fc1"),
Guid.Parse("4a32c3b8-6132-490c-b3e2-6668dd29198d"),
Guid.Parse("140decb0-290b-4d65-853c-717c1437e338"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("f6aaf0e4-7c04-4316-adf0-c88e87425e40"),
Guid.Parse("c9592150-a62a-427c-b04c-723ba6d1bcba"),
Guid.Parse("e74cf06f-1123-4345-b6c2-24bcba404911"),
Guid.Parse("abaf8e08-0b33-450c-b853-bc086c91ed3c"),
},
},
            new GuiduuidArray1M
{
    Id = 133,
    Value = 
new System.Guid[3]
{
Guid.Parse("00cbf9e2-88ae-4982-9136-335ff2f1e972"),
Guid.Parse("b380a635-21af-4ec0-9623-bf589f75b2d9"),
Guid.Parse("a5196158-0b81-4f63-9d81-84d711d288d1"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 93,
    Value = 
new System.Guid[3]
{
Guid.Parse("ef3d096f-4dd3-4532-899f-f14abc77403b"),
Guid.Parse("6c0b1505-147e-4e16-890a-1113cbaa1cdf"),
Guid.Parse("bec23d4b-bc1b-4834-9f21-af9b37f017a5"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("7b6fc434-12b6-4bb4-940e-7d27ca8a4e53"),
Guid.Parse("c2626305-dbed-489e-bd18-b751c6a3eb40"),
Guid.Parse("2de2ea51-0e36-435f-b537-f1a01ea7598e"),
Guid.Parse("6be4cd57-fb2f-4a42-8617-62f099a4d408"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 141,
    Value = 
new System.Guid[4]
{
Guid.Parse("97e6d729-7487-44d2-a8d9-7219dc33eb07"),
Guid.Parse("4f620cb1-bdbf-41e6-a69b-12a87997840c"),
Guid.Parse("7cb9766a-81ba-4bf0-9db4-a72fed6a527b"),
Guid.Parse("2f960c02-351a-4c4b-87c9-b9211eab7d93"),
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
Guid.Parse("52aeea8d-8a76-4615-b6d4-fe6cef793916"),
Guid.Parse("1c142cf6-9d66-4da0-9731-2180ceb3b421"),
Guid.Parse("060e861b-8455-4b8b-9bb8-1b1a0682f267"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 95,
    Value = 
new System.Guid[4]
{
Guid.Parse("949aebb1-93b8-4615-a15b-3c29ef397783"),
Guid.Parse("69fa96c0-6626-4dc6-951d-ec57af1fbe23"),
Guid.Parse("80aa0760-c136-4abe-92d4-792621471d0b"),
Guid.Parse("1d4e8bf5-5c05-457a-ae78-5bb80c1a389f"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("aacc6b35-dfdf-47bb-9ea7-061137bb08b2"),
Guid.Parse("89a7845a-6bb4-4e4e-a0fd-5b82b7021d0c"),
Guid.Parse("b979529e-6eb2-4de1-8c10-be39345e728b"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 154,
    Value = 
new System.Guid[3]
{
Guid.Parse("b9335c9d-5b78-46cd-8f93-60b88763d72b"),
Guid.Parse("7404ce3b-64df-4fc3-b6c0-7bf1e19e09ee"),
Guid.Parse("979b918a-a090-4457-9c94-e7a723110b76"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("5b1bb000-d8c1-4df1-9491-bb14b6d01361"),
Guid.Parse("9880b24b-0087-4033-ab6d-8c4b13ffbc64"),
Guid.Parse("9273949f-1b0f-4297-8d67-b807c3511409"),
},
},
            new GuiduuidArray1M
{
    Id = 162,
    Value = 
new System.Guid[3]
{
Guid.Parse("a55841a1-875d-40fb-a71a-384cd3358c04"),
Guid.Parse("5c97f2a1-47f9-49e7-9dce-799f5a21eacd"),
Guid.Parse("671a7431-ef45-410b-bac3-08161a06acac"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 104,
    Value = 
new System.Guid[4]
{
Guid.Parse("d806c619-43b1-4942-bc0a-47b39530d3dc"),
Guid.Parse("8b2c8920-a044-4aaa-8e24-e21f853d0991"),
Guid.Parse("17c8e309-bc7f-4371-88f8-848a416519a9"),
Guid.Parse("e92ef4d3-bd97-48d3-96d4-4af04932cb3d"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("b6abb857-f2dc-4912-b07f-77d54d2d9f55"),
Guid.Parse("283162e2-1d53-488a-a4e5-abf28db466d4"),
Guid.Parse("d71b37e8-cde0-43db-a003-09af17948d8b"),
Guid.Parse("d5e2b22e-e1ad-410d-9783-850936c2e6e5"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("e838930e-b86d-45e7-a394-7fa61afac038"),
Guid.Parse("e5f0c0bf-e83e-4ed8-a1cd-cc5bf08b9683"),
Guid.Parse("ce5f9642-a31e-46eb-82e5-627c771949b9"),
},
},
            new GuiduuidArray1M
{
    Id = 165,
    Value = 
new System.Guid[4]
{
Guid.Parse("6262146d-4a8d-4ce4-bf30-69995aee2999"),
Guid.Parse("76257b05-0959-41f9-995e-ae617b6a0f29"),
Guid.Parse("7a1a9ff0-a600-4ebc-918d-43dcf2323373"),
Guid.Parse("2369acba-7ed0-4270-9b37-0eedc334faa5"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 168,
    Value = 
new System.Guid[4]
{
Guid.Parse("0c9c9bdc-f140-4652-aa9d-c11c1de4e027"),
Guid.Parse("f9a3fd6a-ec9f-48ad-b776-82cf2691ceec"),
Guid.Parse("45933454-102f-48f1-a9ab-4ea64367e788"),
Guid.Parse("4eaff4f2-90d7-4520-ac20-6ba1760939af"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 109,
    Value = 
new System.Guid[3]
{
Guid.Parse("c2d52375-b2e0-481c-99b2-8cd287b82e03"),
Guid.Parse("58d546ea-366c-4fe8-8c61-b82ca5f06606"),
Guid.Parse("974f9352-a2f7-43d8-8fd6-deffeabce7ae"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("34debc5c-af02-43a3-8efb-28aed1cd69a9"),
Guid.Parse("92149372-e8eb-4aee-b809-5e07930abf8b"),
Guid.Parse("3b45f9cf-7f48-4296-9d24-b90b1d6529d1"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 171,
    Value = 
new System.Guid[4]
{
Guid.Parse("690f380f-6e45-448b-93c3-0f9598f80acb"),
Guid.Parse("cb89987c-eb1a-4c5c-a529-9109a7f9fa94"),
Guid.Parse("ea0a64a1-e647-4b98-9707-eac60ee80a84"),
Guid.Parse("b7f6f373-d2b6-4594-984d-4ecdf922edfc"),
},
    ModelInner = null,
    NullableValue = null,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("29ad59ba-a608-4bd0-b2a7-340f328b7d27"),
Guid.Parse("34f9bbda-363e-471c-86bd-7a6cc2f5eb3e"),
Guid.Parse("cab9e67c-e5ff-4e57-9418-e55dee9b0458"),
Guid.Parse("e71cc180-12b5-4473-9eec-1fa7c1f6f1e3"),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("76cab462-e941-4f64-a458-ca7f97c1e5b1"),
Guid.Parse("54dc3ec1-14da-45fd-bee4-dcf4943f59ff"),
Guid.Parse("7255d567-08c8-4fba-8b85-5bae15d531c0"),
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
new System.Guid[3]
{
Guid.Parse("ec4dc593-f303-4ea4-b030-1f6b0c19d065"),
Guid.Parse("f50a44b0-222c-4523-bbfa-81eb7c987f68"),
Guid.Parse("5d079cc6-fabd-47a1-b39b-181812624da8"),
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
new System.Guid[3]
{
Guid.Parse("ca5bbfb4-155a-423e-b7cc-05bb835cbb63"),
Guid.Parse("ff112c02-2690-4ad0-b83f-6b5fd246324e"),
Guid.Parse("3ef8a257-aad2-44ba-b6f3-a5878564e2b1"),
}));
                nullable =  ((IGuidArrayuuidArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("f3c8480d-0435-4d72-9cfc-8f96185b290a"),
Guid.Parse("556c4842-7aaf-4403-84d0-c58c8f85467f"),
Guid.Parse("4726ba08-e95a-441e-91b7-7cc1618581f3"),
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
                Assert.That(nullable, Is.Null);
                nullable = await ((IGuidArrayuuidArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                parametr1.Value = 119;
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
                await ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
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
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[34], false);
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
                parametr2.Value = 165;
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
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
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
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 165;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[25],_testData[34], false);
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
                parametr1.Value = 165;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
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

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[34], false);
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
                parametr2.Value = 62;
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
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[34], false);
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
                parametr1.Value = 86;
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 150;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 3;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
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
                        FlatGuiduuidArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[32],_testData[34], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 162;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

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
                        GuiduuidArray1M.AssertModel(models[10],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        GuiduuidArray1M.AssertModel(models[0],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(17));

                        GuiduuidArray1M.AssertModel(models[0],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[34], false);
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
                await ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 150, query1, 79, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[34], false);
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
                await ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 162, query1, 141, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[34], false);
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
                 ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 162, query1, 150, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[34], false);
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
                 ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 55, query1, 2, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[21],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 150, query1, 86, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[34], false);
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
                await ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 38, query1, 96, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
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
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 96, query1, 83, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

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
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[34], false);
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
                 ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 124, query1, 165, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelBatchAsync(connection, 55, 79))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        GuiduuidArray1M.AssertModel(models[0],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        GuiduuidArray1M.AssertModel(models[0],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelBatch(connection, 3, 20))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

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
                        GuiduuidArray1M.AssertModel(models[28],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[29],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[30],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[31],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

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
                        GuiduuidArray1M.AssertModel(models[24],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[25],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[26],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[27],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[28],_testData[34], false);
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
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 20);
                var models = await ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(29));

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
                GuiduuidArray1M.AssertModel(models[24],_testData[30], false);
                GuiduuidArray1M.AssertModel(models[25],_testData[31], false);
                GuiduuidArray1M.AssertModel(models[26],_testData[32], false);
                GuiduuidArray1M.AssertModel(models[27],_testData[33], false);
                GuiduuidArray1M.AssertModel(models[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidArrayuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 37);
                var models =  ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

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

