

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
    internal partial interface IGuidListuuidListD1
    {
    }
    
    internal partial class GuidListuuidListD1 : IGuidListuuidListD1
    {


#region TestData

        private readonly GuiduuidListD1E2M[] _testData = new GuiduuidListD1E2M[]
        {
            new GuiduuidListD1E2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a6bd87e0-4400-468a-95df-4046e3c5d418"),

Guid.Parse("70793dae-abe5-4384-85a8-91c108bb4d52"),

Guid.Parse("d6fe9643-5a5a-45cf-903a-7fba94267553"),

Guid.Parse("1885d0c2-1a30-40c3-9b02-3e9ac948900a"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("11298f84-7672-4ac1-8743-9e9accf9c2e2"),

Guid.Parse("93cb6679-7b85-4604-baf5-d62fb8e46174"),

Guid.Parse("8606aabe-29ea-4c67-8996-067315846595"),

},
},
            new GuiduuidListD1E2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("07d582b3-cd13-4b75-a0d4-d1f0006ac376"),

Guid.Parse("25962f18-9d42-4786-a095-6290b5d219f6"),

Guid.Parse("13bd9b3d-95f1-4f69-a58e-30f29fa8255f"),

Guid.Parse("a35fac9c-a8d9-434c-9253-1346a841647e"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4351625f-7044-48dd-9a9e-79f57451d48e"),

Guid.Parse("6b87c6c4-a956-4a62-9a29-bd6b28de97d9"),

Guid.Parse("1116f142-6ec2-4804-ab67-56c47d21d567"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9522b76b-f7b3-428b-98e7-b992904bece3"),

Guid.Parse("154e3082-1415-4e88-b74a-3b444bd4442a"),

Guid.Parse("c51d6625-3bc6-4b8f-be8e-8bcf494c5603"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("888cdff4-a3ef-497a-af37-a00c56137fdc"),

Guid.Parse("0e06e5a5-dd82-460c-a4d3-d6ac941a813e"),

Guid.Parse("ee943486-6827-4580-9dc5-31f1e9bc0662"),

Guid.Parse("9a668385-4f6a-45d9-8457-e2065aa6a932"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e283ba43-e231-416c-84e9-bacf02b003e0"),

Guid.Parse("f12db743-808e-4c54-b855-0155c815662f"),

Guid.Parse("78f46d78-5e23-4933-a69e-fd6e15b89b53"),

Guid.Parse("82382cc4-ee72-4d13-992c-c4126c375a9b"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("9adf57fc-5b50-4436-af4f-0cba68456005"),

Guid.Parse("47f07660-b0bd-4996-bb92-12389a936629"),

Guid.Parse("09140827-efbe-45da-8d85-0bc89a6da483"),

Guid.Parse("3eec06c8-961d-4bb6-9cd8-2532acf0542e"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("777ade02-a706-4194-82f7-39a132bb7a15"),

Guid.Parse("eeffffb3-ae85-488c-b4ae-66df59dd9465"),

Guid.Parse("1ee959bc-213b-4f3f-bb3f-fb6c740a8a38"),

Guid.Parse("d4c8b7eb-d753-4bc3-a78a-5584371d6c15"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ca73edaf-cd91-487d-b7e8-eb15f6622106"),

Guid.Parse("d14b7e58-2957-45af-a69f-521ffc665851"),

Guid.Parse("d7d216f6-183a-490c-8652-a3a7fde5c5da"),

},
},
            new GuiduuidListD1E2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("31ddccd7-7afb-413b-ad55-33c9a2afe267"),

Guid.Parse("2fc580e3-11e2-415f-b5c8-0f6e15b6f2a8"),

Guid.Parse("d9e70880-d202-4fc6-a50f-f2b29d9725e1"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("38344206-bc03-4475-9c2f-d9332da7a1f3"),

Guid.Parse("523367df-fde0-4dbd-b6a4-46939772efae"),

Guid.Parse("0a894cca-bfff-4170-a659-369b28604fca"),

},
},
            new GuiduuidListD1E2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("04f1468c-6f2b-4a2f-b4be-f759e6bae9d1"),

Guid.Parse("e30acbc5-aa9e-4cb7-b208-5c5d7b37a35e"),

Guid.Parse("ebda838b-b40d-4fb5-8367-f11df2f1a3aa"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("d266c73c-ebba-421f-af21-3d0ba025f572"),

Guid.Parse("7a0da373-c77f-40a9-9266-0fae57bdbc4b"),

Guid.Parse("af2c73a9-2708-459b-96f0-d333808632df"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("183ed065-9e24-45ea-8227-6b246a4482f3"),

Guid.Parse("6948959e-7320-4456-b6eb-c4da533bc5b4"),

Guid.Parse("21a16445-6ea6-4763-a733-f1eb0ef11eed"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("600f8692-1b5a-4320-978e-99c88487eb83"),

Guid.Parse("c8f8b692-706c-4a4c-9bd3-54cc14eeba0b"),

Guid.Parse("cf42b122-012b-4be1-89c8-e2e802d7722c"),

},
},
            new GuiduuidListD1E2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9c6b76a9-ed35-4406-a671-49968207a9d8"),

Guid.Parse("6d482399-4956-4c8d-a84d-90e68ee4eea9"),

Guid.Parse("63b2934a-28fb-4bf6-b2c3-9af6d6bf9780"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("89c73c7a-f517-4bfb-8e0b-89023b92177a"),

Guid.Parse("e53bf24a-07c2-4c9f-9522-b8486a3f6029"),

Guid.Parse("48203025-88cc-43ab-abf7-e29069c02a83"),

Guid.Parse("2e9064ca-f2eb-4062-804d-f116bdcb5c49"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2363eba9-a476-4611-a6fe-98026e74f15b"),

Guid.Parse("c034ca00-119f-447b-901d-eb220683ce37"),

Guid.Parse("607935f2-4503-4cb0-9d3b-dff621250ae8"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("8930d7f4-c196-4add-8e18-ee446630a5b5"),

Guid.Parse("bd64e34c-ebe9-4efa-8786-b435141a57d7"),

Guid.Parse("5cd7b35b-22d4-44b8-bd11-0c3c695aff8f"),

Guid.Parse("04b118a7-933b-4265-bc56-2c4a81f4a2e0"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("51b4dcf3-2deb-44b3-8182-7eb78ed3fda8"),

Guid.Parse("7d75b53a-4b02-4322-a7be-bb5275b7934d"),

Guid.Parse("b18d45cc-445d-4a24-9b3b-6795f55b260b"),

Guid.Parse("0c29bcb7-5e21-481b-b7f1-22c8e9106d7f"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("79750037-a9a3-46bc-9f93-83c68e1b5f28"),

Guid.Parse("9ba0f660-9e8b-4f2a-8a3d-67f0a2dd7bee"),

Guid.Parse("b67024e6-331e-4ba2-9592-1f74d2aa35b4"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5075b363-50ee-4ec2-9652-f3676e42c014"),

Guid.Parse("fc325118-c681-4096-a581-135e51732e59"),

Guid.Parse("08ab65d3-1bc8-428b-9146-c7b68c490c62"),

Guid.Parse("0ff5cd52-d678-4bb9-bf47-25a588e9a654"),

},
},
            new GuiduuidListD1E2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("8ff7a5dd-4948-4808-9dec-118080459190"),

Guid.Parse("b057def1-ab73-462f-b453-36b197fbf1f5"),

Guid.Parse("002f7130-1832-4eaa-9dba-d1dd6da3bc15"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("978137fc-a1b1-4383-a783-ff1028009d05"),

Guid.Parse("91021ed5-71fc-40ee-8252-bb8d77e5c527"),

Guid.Parse("5a4a52cc-2af4-41dc-b0e6-9ccc1553b70a"),

Guid.Parse("43ea99ca-d5bb-496d-bc8e-51de2daf14c7"),

},
},
            new GuiduuidListD1E2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("67f04d20-9866-4e64-b82e-dca7e6a50c58"),

Guid.Parse("8500df45-7ed4-4a31-81d1-94d8f3a1aab5"),

Guid.Parse("7b18df70-02a0-4c7b-b962-696b3cfd7bbb"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("92375eaa-bee8-4012-919c-b1c46ddfc84c"),

Guid.Parse("1a406063-bd4a-4581-a1c2-7b570e1f849d"),

Guid.Parse("f596c589-0e4c-428a-8537-634b4c368317"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b9d0900e-a718-4a11-b812-7f05bb977483"),

Guid.Parse("b354d5c8-39f4-4ff7-b0b7-b1b4efa0ee6e"),

Guid.Parse("ae4c278d-ba36-4316-8978-9228151cf8a6"),

Guid.Parse("6fc05f69-8546-455d-90b6-bfbdfc5eacd0"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("730e2501-8756-416f-9141-ea3dd9a479dc"),

Guid.Parse("b5b303a0-efc9-4e57-87b1-a97d827e1bda"),

Guid.Parse("6e1aef8d-56ea-44ec-8849-9defbce415fe"),

Guid.Parse("2a0a2702-5014-4a03-94f6-c3e3167781d2"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("7c812b63-bb46-4f54-96fa-43e4ee1c1642"),

Guid.Parse("c4088faf-4675-401c-8762-790b7c248b7f"),

Guid.Parse("a8028786-9233-4c20-b925-d9f8cea83f12"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1db483f7-b40e-4e42-8bd7-cf8e8703dff1"),

Guid.Parse("821d64cf-c358-4ede-b303-33066f1c5fab"),

Guid.Parse("3afa4e83-a034-4b23-95d0-30b314624d64"),

Guid.Parse("ba738b33-e123-4630-ae96-1f95396f7fe1"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("16f94fbc-8472-4f70-b1d7-19962408349b"),

Guid.Parse("657340e6-c8c2-45da-ba65-40ba5d34997d"),

Guid.Parse("98683686-a769-4ee0-8fbc-0c6504690fd8"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ec71377f-ca6b-44ce-b69d-9ab8f67c05d1"),

Guid.Parse("48b2f57a-52f7-4de5-8920-1671c685c5da"),

Guid.Parse("9e6994cb-7acc-4e6e-b0b7-eb1546c04237"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("8d96d42c-a9f3-4061-b39f-2f2339704328"),

Guid.Parse("03299bc7-ee63-4618-a4f3-dda80d2c9b7a"),

Guid.Parse("a86950df-5bcd-49f5-be5e-7bac1e58b66f"),

Guid.Parse("bd987c39-66e0-4785-b2e6-dc0d1f1dac52"),

},
},
            new GuiduuidListD1E2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ca77526c-9dbc-4aca-850b-dec5ca86d438"),

Guid.Parse("c5218b17-1a81-45b8-9623-6da2763074e5"),

Guid.Parse("4df1920f-7721-41b6-a75a-b95bce349b3a"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("88a8e7cf-6496-4aa7-b00b-cf74728858ea"),

Guid.Parse("069c71c0-1667-4337-aae6-bce89d15f89d"),

Guid.Parse("ad8a448a-763c-4b41-ad6a-063072a79fe0"),

Guid.Parse("da2bdbe6-558d-4cc5-bbed-da23c50ac219"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("7119ef03-e4cb-44f9-8c66-9b2aa3468fa0"),

Guid.Parse("fcb2917e-51d4-4cc5-ad0e-5fea96b09573"),

Guid.Parse("b27dea7a-418d-4336-acf7-3627d522f702"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("09d2a80c-00ce-4062-a5b0-4e9b3f96bb34"),

Guid.Parse("f0263143-bdf5-4e99-900a-ef241f661c03"),

Guid.Parse("1b852055-caf6-49f2-8d1d-e0316c25cc64"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f50bae44-0738-422a-80dc-4c1f08978be6"),

Guid.Parse("663a0880-c2e6-4fa9-a6c8-773c98467e9a"),

Guid.Parse("4a4034bb-a055-4c61-a9f0-21a770451e49"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("8d7c88ea-8cc1-4183-ad40-33e93d779a96"),

Guid.Parse("9202ae91-cb75-4974-a79c-c4ecfb05db68"),

Guid.Parse("6cbe1113-e2a7-483f-b0c1-68a67bcdbf1f"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("02d24c9e-6aed-4438-a536-d4f517cc821d"),

Guid.Parse("769dba37-b3c2-495c-81bb-c5ce557aa198"),

Guid.Parse("cbefbca3-3ea6-4aa9-8d17-e0e560eaaa6c"),

},
},
            new GuiduuidListD1E2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("640b58be-8bb6-4058-8ec7-4eec274c624b"),

Guid.Parse("14304ba4-2b05-4c14-9b24-30caddaa7b83"),

Guid.Parse("1f29d87d-0618-474d-9c23-975b18ea2953"),

Guid.Parse("a0636da9-bbbb-4756-9127-1f90dfb2bc34"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("30851d12-82cc-43f3-88cd-308a26548d93"),

Guid.Parse("c94ad142-1ea8-4baf-8b9a-c2fc36ffdf4a"),

Guid.Parse("fe0ddcfe-e976-47bb-9e84-ed58e0a87eea"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f4cd0bf9-6258-46cb-b938-a054aa41b043"),

Guid.Parse("5a62eebc-560d-4660-bda2-fc602f95b7ee"),

Guid.Parse("e3bc9d0b-582d-4a84-8a21-c0f663986e61"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("60b81920-ba09-4e9f-879f-ce30d40547a5"),

Guid.Parse("7e9a5ea1-b714-4f7a-bade-bfda9dbf7cb4"),

Guid.Parse("8117b8ad-390f-4cea-a957-3248d58f5c1c"),

Guid.Parse("b40dede5-c619-451f-b419-e17bd5228435"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3bffcd7c-989a-4b75-9062-6ca5525aff59"),

Guid.Parse("49ff8068-44fe-439e-b7cb-61a7a9f900ee"),

Guid.Parse("65da8032-a01e-4ab2-bc0d-46a737d7bfb1"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b02182f7-ae57-4bb5-8551-728c2061e5d6"),

Guid.Parse("d14eaa50-852e-42b0-a9a1-0a2957b546d0"),

Guid.Parse("b36c91e1-1e42-4fdb-a09b-a8515d716948"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fc4a6573-66b4-4244-944f-7daa071a05cd"),

Guid.Parse("4329ea17-6812-498a-ae3d-cffdcbd6c3b8"),

Guid.Parse("7422bd1d-bc53-49b2-99fc-51b50b57acf8"),

Guid.Parse("98ee66a9-95b6-4033-ac6e-ac40766792af"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("0eb54dbe-f8d6-49ce-aaa4-7306f893b5f3"),

Guid.Parse("71fc81bc-cec8-4e4c-854f-7671e1ec2ca4"),

Guid.Parse("dd9681c2-e009-4386-ae11-2f8445de82dc"),

Guid.Parse("12f18a44-049f-47a9-8b89-74cb8aa827d4"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("cf0852a5-cecd-4e2a-ab7b-affdfbb24a8b"),

Guid.Parse("6e9d9020-93e2-4c60-aad3-8d12d75243f1"),

Guid.Parse("ad89fe92-d4c4-48d1-9219-d1faf54f60e1"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("99fe35b6-3399-463e-adea-cfcd0807441e"),

Guid.Parse("f3f12ee4-a5d6-49e8-99be-a9d78cb78ea0"),

Guid.Parse("1fcd2d9b-5dbb-4004-8084-f2a212e066e6"),

Guid.Parse("5f468af5-bc6e-4ffb-96c2-de2fca8112d0"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("42e9f116-d68e-434c-9636-f2e28b0a7acc"),

Guid.Parse("dc4487a4-4381-47ca-b644-0c1ced7eedcf"),

Guid.Parse("2ebc655f-51ff-48cb-b963-26a7995af971"),

Guid.Parse("bb6a627b-3d03-46b8-b77c-45b851120231"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("56c0b218-83db-41ad-94b1-5845526315db"),

Guid.Parse("bfb689cc-7083-465c-b66d-371329e4773e"),

Guid.Parse("6ecbc164-1469-4ab2-982d-1242fe67cea5"),

Guid.Parse("8e4d9a28-332f-4a06-bb93-ca11bf8fa05b"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("505dac6c-ab05-4088-8f08-76afab7f4e4f"),

Guid.Parse("35a00b78-a7f4-43ef-81d4-7948f4dd2a6e"),

Guid.Parse("5203d43d-5ce7-4a79-8e4b-e5966cad8da6"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c3970e2f-602e-4718-8e7f-8fad19617295"),

Guid.Parse("ad138ec3-7d71-467d-9422-1a3801c9da69"),

Guid.Parse("a13ddb85-e8f6-49aa-aaf4-222e2e841742"),

},
},
            new GuiduuidListD1E2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("6e7ec05d-1699-4e2f-b8cd-f5616a54a3b8"),

Guid.Parse("be8f7e86-c943-48c9-9c30-e4ce39c33a67"),

Guid.Parse("5ca05dd1-b8f7-4581-8c06-04a909ad32fc"),

Guid.Parse("e35bd6db-3160-44ad-ab3b-a865492152ac"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c71841aa-2197-4af9-a8d5-0b9069157d2b"),

Guid.Parse("12dbee7e-b944-428d-a3e4-7d6ce9a77279"),

Guid.Parse("669372e1-d009-4766-ae3d-46a26d4ce770"),

Guid.Parse("fc05d85d-b569-4998-8b53-e7c6c78ad6f1"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c8200ea8-3254-4bcd-9267-73d8663fe2ab"),

Guid.Parse("1f1355ab-7689-4abc-9ec3-4e9a297b047d"),

Guid.Parse("88c287fb-741e-4ee3-8eac-eeae6ebd25cc"),

Guid.Parse("8ea6b3fb-30c0-457c-84e2-ee612bfe5473"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("d6029850-c388-4250-b2b9-1dd37648a7e7"),

Guid.Parse("3c0ef88c-4155-4e47-b1f0-4b99db7c3860"),

Guid.Parse("231d7daa-7645-4098-a2ac-86f701230378"),

},
},
            new GuiduuidListD1E2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7459d761-5242-4a06-924f-01da60b52336"),

Guid.Parse("6b380a45-5b2b-49c4-8e05-7e0927083e96"),

Guid.Parse("9d403a54-0ccd-45b2-b05f-f2654322213b"),

Guid.Parse("fca187fb-595c-48b8-bf03-f62b664f56df"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("8f7550fa-cf9f-4184-ae0f-832f570b2150"),

Guid.Parse("072e1f5f-e62e-4969-b9a3-9075fd87ea22"),

Guid.Parse("82b7f775-9b5b-458e-8cd7-6ac0d25ea008"),

},
},
            new GuiduuidListD1E2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("2c9ffeb1-6f57-49ea-863e-0bc6b2e88458"),

Guid.Parse("eb66f80f-c039-4e74-9081-33ddf3618904"),

Guid.Parse("9355ee20-59c1-457e-b185-c6ca72b3d416"),

Guid.Parse("f8e24bad-c983-4a17-8bdb-d164d1c36cd0"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e7122d49-1406-4436-a3fb-0fd8b16c7ff2"),

Guid.Parse("096c0be1-1129-4439-944e-11bbbd786acd"),

Guid.Parse("6403a805-3ad7-4279-b441-d227e516af42"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("70bfa691-794a-4859-9e4e-d8c227ab2511"),

Guid.Parse("48a7c983-eda5-4d16-8a5b-36b9abe5d7c5"),

Guid.Parse("d1fa69c7-0269-4cf1-bbff-fe33c956b603"),

Guid.Parse("72f6ea61-eb0b-43bb-8871-30a5155248b5"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3d0d3f3a-7af4-4ab0-9199-edee824fa7ae"),

Guid.Parse("c8adaea9-135e-4fe3-8451-f279966f1f54"),

Guid.Parse("8a630eb5-b771-432d-92e3-bbc0c569c67b"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b3a414fc-6bad-4120-8896-8687b2eb1a30"),

Guid.Parse("5346a01c-d8c6-4c5e-9fb9-59b695edd5c5"),

Guid.Parse("fef69df6-4f43-4545-8c3e-cb25e39c1f57"),

Guid.Parse("252c2d8f-9ae6-4384-93fd-ca5831a4ecd0"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a4aee3c4-28ef-4f6e-82e2-51bd35b2d82c"),

Guid.Parse("66049235-27da-4ccd-a099-bf8f65c53d21"),

Guid.Parse("90524358-d345-4f2c-97bb-0a7e4fb8f003"),

Guid.Parse("e908d493-4641-4776-ac94-6857a2570e7c"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("0fd2abd9-70cd-4270-a7fe-eb2d0c0238ba"),

Guid.Parse("1697056a-7808-4e1c-b6c4-0ce10a20cb57"),

Guid.Parse("c207414e-8091-45ab-9551-5a48cee6f2cf"),

Guid.Parse("dc770c77-6688-4a40-a171-96c346756f79"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("975865f6-7b3d-4384-85ae-39ea6f47591b"),

Guid.Parse("a7426d65-7812-41f0-8507-21d049a6b166"),

Guid.Parse("76a8cb6e-3506-4347-9b8e-3dd12b79f76d"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("a04fbcb7-c3c6-4300-b4ff-6985d6c783a2"),

Guid.Parse("36fcb8ca-5bc4-403e-9175-e4d77151dc68"),

Guid.Parse("4e8627e5-3038-42f3-b89d-dc3696748442"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1d8add21-64e7-43ab-b491-fddc65b8098b"),

Guid.Parse("602b30bd-1ab2-41e0-b8bb-1e8268da03b3"),

Guid.Parse("2c02e4bb-1aa1-4f9b-91ec-46274a299d1b"),

Guid.Parse("f3185103-b469-4351-93ab-17d22c491ee4"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("dab166c6-f86b-4f16-ab68-030a9a75e56b"),

Guid.Parse("ec8947b2-de56-4332-b3e5-86882e66c91d"),

Guid.Parse("46fa6eed-7a30-4655-84e9-f9978b93f4b6"),

},
},
            new GuiduuidListD1E2M
{
    Id = 169,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("448a09c7-7ac6-44b5-bfe4-16623c63e3cb"),

Guid.Parse("5c24ed8e-6e9c-4386-a5d7-9f336279392b"),

Guid.Parse("f31f5287-f779-4860-99cc-36784c408753"),

Guid.Parse("60fbd608-29f3-42e0-9313-07c2fcfd11d4"),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidlistd1e2mi(
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
            asPartInterface: typeof(IGuidListuuidListD1)),
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
INSERT INTO public.guiduuidlistd1e2mi(
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
            queryMapTypes: [typeof(GuiduuidListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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

                changedRows =  ((IGuidListuuidListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidListuuidListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IGuidListuuidListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidListuuidListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IGuidListuuidListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IGuidListuuidListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidlistd1e2m(
	id,
    value,
    nullablevalue,
    guiduuidlistd1e2mi_id
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
            asPartInterface: typeof(IGuidListuuidListD1)), 
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
                methodParametrName: "guiduuidlistd1e2mi_id", 
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
                changedRows =  ((IGuidListuuidListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IGuidListuuidListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IGuidListuuidListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IGuidListuuidListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidlistd1e2m(
	id,
    value,
    nullablevalue,
    guiduuidlistd1e2mi_id
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
    guiduuidlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(GuiduuidListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidlistd1e2m(
	id,
    value,
    nullablevalue,
    guiduuidlistd1e2mi_id
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
    guiduuidlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(GuiduuidListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
                methodParametrName: "guiduuidlistd1e2mi_id", 
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
                List<GuiduuidListD1E2M> models = null;

                models =  ((IGuidListuuidListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((IGuidListuuidListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((IGuidListuuidListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((IGuidListuuidListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidListD1E2M> models = null;

                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidListD1E2M), typeof(FlatGuiduuidListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
FROM public.guiduuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidListD1E2M>();
                var models2 = new List<FlatGuiduuidListD1E2M>();
                await ((IGuidListuuidListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidListD1E2M>();
                var models2 = new List<FlatGuiduuidListD1E2M>();
                ((IGuidListuuidListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
FROM public.guiduuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IGuidListuuidListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidListuuidListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
LEFT JOIN public.guiduuidlistd1e2mi mi ON mi.id = m.guiduuidlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
                var models = await ((IGuidListuuidListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IGuidListuuidListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidListD1E2M), typeof(FlatGuiduuidListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
FROM public.guiduuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidListD1E2M>();
                var models2 = new List<FlatGuiduuidListD1E2M>();
                await ((IGuidListuuidListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidListD1E2M>();
                var models2 = new List<FlatGuiduuidListD1E2M>();
                ((IGuidListuuidListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
FROM public.guiduuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidListuuidListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidListuuidListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
LEFT JOIN public.guiduuidlistd1e2mi mi ON mi.id = m.guiduuidlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(GuiduuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
                var models = await ((IGuidListuuidListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IGuidListuuidListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidListD1E2M), typeof(FlatGuiduuidListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
            asPartInterface: typeof(IGuidListuuidListD1)),
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidListD1E2M>();
                var models2 = new List<FlatGuiduuidListD1E2M>();
                await((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var firstItems2 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems2 = new List<FlatGuiduuidListD1E2M>();
                await ((IGuidListuuidListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 150;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var firstItems2 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                await ((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[18],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidListD1E2M>();
                var models2 = new List<FlatGuiduuidListD1E2M>();
                ((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var firstItems2 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems2 = new List<FlatGuiduuidListD1E2M>();
                 ((IGuidListuuidListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var firstItems2 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                 ((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
            asPartInterface: typeof(IGuidListuuidListD1)),
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 60;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[11],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[12],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[13],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[14],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[15],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[16],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[11],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[12],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[13],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[14],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[15],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[16],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[17],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[18],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[19],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[20],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[21],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 110;
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems2 = new List<FlatGuiduuidListD1E2M>();
                await ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 35;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[6], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[11],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[12],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[13],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[14],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[15],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[16],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[17],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[18],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[19],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[20],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[21],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[22],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[23],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[24],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[25],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[26],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[27],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[11],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[12],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[13],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[14],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[15],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[16],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[17],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[18],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[19],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[20],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[21],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[22],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[23],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[24],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[25],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[26],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 63;
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems2 = new List<FlatGuiduuidListD1E2M>();
                 ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
LEFT JOIN public.guiduuidlistd1e2mi mi ON mi.id = m.guiduuidlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
                var models = await((IGuidListuuidListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[9], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[10], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[11], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[12], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[13], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[14], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[15], false);
                        GuiduuidListD1E2M.AssertModel(models[7],_testData[16], false);
                        GuiduuidListD1E2M.AssertModel(models[8],_testData[17], false);
                        GuiduuidListD1E2M.AssertModel(models[9],_testData[18], false);
                        GuiduuidListD1E2M.AssertModel(models[10],_testData[19], false);
                        GuiduuidListD1E2M.AssertModel(models[11],_testData[20], false);
                        GuiduuidListD1E2M.AssertModel(models[12],_testData[21], false);
                        GuiduuidListD1E2M.AssertModel(models[13],_testData[22], false);
                        GuiduuidListD1E2M.AssertModel(models[14],_testData[23], false);
                        GuiduuidListD1E2M.AssertModel(models[15],_testData[24], false);
                        GuiduuidListD1E2M.AssertModel(models[16],_testData[25], false);
                        GuiduuidListD1E2M.AssertModel(models[17],_testData[26], false);
                        GuiduuidListD1E2M.AssertModel(models[18],_testData[27], false);
                        GuiduuidListD1E2M.AssertModel(models[19],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[20],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[21],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[22],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[23],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[24],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[25],_testData[34], false);
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
                var models = ((IGuidListuuidListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[12], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[13], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[14], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[15], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[16], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[17], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[18], false);
                        GuiduuidListD1E2M.AssertModel(models[7],_testData[19], false);
                        GuiduuidListD1E2M.AssertModel(models[8],_testData[20], false);
                        GuiduuidListD1E2M.AssertModel(models[9],_testData[21], false);
                        GuiduuidListD1E2M.AssertModel(models[10],_testData[22], false);
                        GuiduuidListD1E2M.AssertModel(models[11],_testData[23], false);
                        GuiduuidListD1E2M.AssertModel(models[12],_testData[24], false);
                        GuiduuidListD1E2M.AssertModel(models[13],_testData[25], false);
                        GuiduuidListD1E2M.AssertModel(models[14],_testData[26], false);
                        GuiduuidListD1E2M.AssertModel(models[15],_testData[27], false);
                        GuiduuidListD1E2M.AssertModel(models[16],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[17],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[18],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[19],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[20],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[21],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[6], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[7], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[8], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[9], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[10], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[11], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[12], false);
                        GuiduuidListD1E2M.AssertModel(models[7],_testData[13], false);
                        GuiduuidListD1E2M.AssertModel(models[8],_testData[14], false);
                        GuiduuidListD1E2M.AssertModel(models[9],_testData[15], false);
                        GuiduuidListD1E2M.AssertModel(models[10],_testData[16], false);
                        GuiduuidListD1E2M.AssertModel(models[11],_testData[17], false);
                        GuiduuidListD1E2M.AssertModel(models[12],_testData[18], false);
                        GuiduuidListD1E2M.AssertModel(models[13],_testData[19], false);
                        GuiduuidListD1E2M.AssertModel(models[14],_testData[20], false);
                        GuiduuidListD1E2M.AssertModel(models[15],_testData[21], false);
                        GuiduuidListD1E2M.AssertModel(models[16],_testData[22], false);
                        GuiduuidListD1E2M.AssertModel(models[17],_testData[23], false);
                        GuiduuidListD1E2M.AssertModel(models[18],_testData[24], false);
                        GuiduuidListD1E2M.AssertModel(models[19],_testData[25], false);
                        GuiduuidListD1E2M.AssertModel(models[20],_testData[26], false);
                        GuiduuidListD1E2M.AssertModel(models[21],_testData[27], false);
                        GuiduuidListD1E2M.AssertModel(models[22],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[23],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[24],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[25],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[26],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[27],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidListD1E2M), typeof(FlatGuiduuidListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
            asPartInterface: typeof(IGuidListuuidListD1)),
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
            asPartInterface: typeof(IGuidListuuidListD1)),
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidListD1E2M>();
                var models2 = new List<FlatGuiduuidListD1E2M>();
                await((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var firstItems2 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems2 = new List<FlatGuiduuidListD1E2M>();
                await ((IGuidListuuidListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 35, query1, 58, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var firstItems2 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                await ((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 35, query1, 88, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidListD1E2M>();
                var models2 = new List<FlatGuiduuidListD1E2M>();
                ((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var firstItems2 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems2 = new List<FlatGuiduuidListD1E2M>();
                 ((IGuidListuuidListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 150, query1, 155, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var firstItems2 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                 ((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 155, query1, 88, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
            asPartInterface: typeof(IGuidListuuidListD1)),
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
            asPartInterface: typeof(IGuidListuuidListD1)),
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 141, query1, 141, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems2 = new List<FlatGuiduuidListD1E2M>();
                await ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 150, query1, 155, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 125, query1, 150, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems2 = new List<FlatGuiduuidListD1E2M>();
                 ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 155, query1, 105, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
LEFT JOIN public.guiduuidlistd1e2mi mi ON mi.id = m.guiduuidlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(GuiduuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
            asPartInterface: typeof(IGuidListuuidListD1)),
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
                var models = await((IGuidListuuidListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidListuuidListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 155, 155))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[34], false);
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
                var models = ((IGuidListuuidListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidListuuidListD1)this).DbConnectionSTSelectModelBatch(connection, 35, 131))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[7], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[8], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[9], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[10], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[11], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[12], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[13], false);
                        GuiduuidListD1E2M.AssertModel(models[7],_testData[14], false);
                        GuiduuidListD1E2M.AssertModel(models[8],_testData[15], false);
                        GuiduuidListD1E2M.AssertModel(models[9],_testData[16], false);
                        GuiduuidListD1E2M.AssertModel(models[10],_testData[17], false);
                        GuiduuidListD1E2M.AssertModel(models[11],_testData[18], false);
                        GuiduuidListD1E2M.AssertModel(models[12],_testData[19], false);
                        GuiduuidListD1E2M.AssertModel(models[13],_testData[20], false);
                        GuiduuidListD1E2M.AssertModel(models[14],_testData[21], false);
                        GuiduuidListD1E2M.AssertModel(models[15],_testData[22], false);
                        GuiduuidListD1E2M.AssertModel(models[16],_testData[23], false);
                        GuiduuidListD1E2M.AssertModel(models[17],_testData[24], false);
                        GuiduuidListD1E2M.AssertModel(models[18],_testData[25], false);
                        GuiduuidListD1E2M.AssertModel(models[19],_testData[26], false);
                        GuiduuidListD1E2M.AssertModel(models[20],_testData[27], false);
                        GuiduuidListD1E2M.AssertModel(models[21],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[22],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[23],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[24],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[25],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[26],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[34], false);
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
                await using var cmd = await ((IGuidListuuidListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidListuuidListD1)this).SetDbConnectionSelectModelParametrs(cmd, 95);
                var models = await ((IGuidListuuidListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                GuiduuidListD1E2M.AssertModel(models[0],_testData[22], false);
                GuiduuidListD1E2M.AssertModel(models[1],_testData[23], false);
                GuiduuidListD1E2M.AssertModel(models[2],_testData[24], false);
                GuiduuidListD1E2M.AssertModel(models[3],_testData[25], false);
                GuiduuidListD1E2M.AssertModel(models[4],_testData[26], false);
                GuiduuidListD1E2M.AssertModel(models[5],_testData[27], false);
                GuiduuidListD1E2M.AssertModel(models[6],_testData[28], false);
                GuiduuidListD1E2M.AssertModel(models[7],_testData[29], false);
                GuiduuidListD1E2M.AssertModel(models[8],_testData[30], false);
                GuiduuidListD1E2M.AssertModel(models[9],_testData[31], false);
                GuiduuidListD1E2M.AssertModel(models[10],_testData[32], false);
                GuiduuidListD1E2M.AssertModel(models[11],_testData[33], false);
                GuiduuidListD1E2M.AssertModel(models[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidListuuidListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidListuuidListD1)this).SetDbConnectionSelectModelParametrs(cmd, 141);
                var models =  ((IGuidListuuidListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(4));

                GuiduuidListD1E2M.AssertModel(models[0],_testData[31], false);
                GuiduuidListD1E2M.AssertModel(models[1],_testData[32], false);
                GuiduuidListD1E2M.AssertModel(models[2],_testData[33], false);
                GuiduuidListD1E2M.AssertModel(models[3],_testData[34], false);
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
FROM public.binary_guiduuidlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(GuiduuidListD1E2MIWA),
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
            asPartInterface: typeof(IGuidListuuidListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidListuuidListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidListuuidListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidListuuidListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidListuuidListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(GuiduuidListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidListuuidListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidListuuidListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidListuuidListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidListuuidListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(GuiduuidListD1E2MI),
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
            asPartInterface: typeof(IGuidListuuidListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidListuuidListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidListuuidListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidListuuidListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IGuidListuuidListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(GuiduuidListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidListuuidListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidListuuidListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidListuuidListD1)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidListuuidListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
guiduuidlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(GuiduuidListD1E2M),
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
            asPartInterface: typeof(IGuidListuuidListD1))]
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
FROM public.binary_guiduuidlistd1e2m m
LEFT JOIN public.binary_guiduuidlistd1e2mi mi ON mi.id = m.guiduuidlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(GuiduuidListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IGuidListuuidListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IGuidListuuidListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IGuidListuuidListD1)this).ImportModel(connection, importCollection);
                var models = ((IGuidListuuidListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    guiduuidlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(GuiduuidListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
                var models =  ((IGuidListuuidListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidListuuidListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MIWA), typeof(GuiduuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
                var models1 = new List<GuiduuidListD1E2MIWA>();
                var models2 = new List<GuiduuidListD1E2MIWA>();
                await ((IGuidListuuidListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidListD1E2MIWA>();
                var models2 = new List<GuiduuidListD1E2MIWA>();
                ((IGuidListuuidListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
                var models = await ((IGuidListuuidListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidlistd1e2mi
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
                    GuiduuidListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidListuuidListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_guiduuidlistd1e2mi
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
                    GuiduuidListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MIWA), typeof(GuiduuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
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
                var models1 = new List<GuiduuidListD1E2MIWA>();
                var models2 = new List<GuiduuidListD1E2MIWA>();
                await ((IGuidListuuidListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidListD1E2MIWA>();
                var models2 = new List<GuiduuidListD1E2MIWA>();
                ((IGuidListuuidListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
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
                var models = await ((IGuidListuuidListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidlistd1e2mi
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
                    GuiduuidListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidListuuidListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_guiduuidlistd1e2mi
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
                    GuiduuidListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MI), typeof(GuiduuidListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
                var models1 = new List<GuiduuidListD1E2MI>();
                var models2 = new List<GuiduuidListD1E2MI>();
                await ((IGuidListuuidListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidListD1E2MI>();
                var models2 = new List<GuiduuidListD1E2MI>();
                ((IGuidListuuidListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
                var models = await ((IGuidListuuidListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidListuuidListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MIWA), typeof(GuiduuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
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
                var models1 = new List<GuiduuidListD1E2MIWA>();
                var models2 = new List<GuiduuidListD1E2MIWA>();
                await ((IGuidListuuidListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidListD1E2MIWA>();
                var models2 = new List<GuiduuidListD1E2MIWA>();
                ((IGuidListuuidListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
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
                var models = await ((IGuidListuuidListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidListuuidListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

