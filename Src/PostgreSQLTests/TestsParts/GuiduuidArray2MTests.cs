

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
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a3fd6c0c-9c68-47a7-bd62-16c32e10245b"),

Guid.Parse("e4173b3f-0ffa-4246-80c7-3e550c6d8fe9"),

Guid.Parse("6a6bd6ae-3a3e-4658-a41f-fa5722b00c97"),

Guid.Parse("8a10da12-35a4-4d89-ba8e-888da53e14ae"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("d5612a52-9a6b-44ad-868c-1131594948ea"),

Guid.Parse("cb682453-4344-463d-8b38-129df1dbeff3"),

Guid.Parse("e2c83b99-4e21-49d1-950c-4973e277e498"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e5b79885-a2ae-4cd9-acf8-e6fc774a4d93"),

Guid.Parse("136ee9f5-fa8e-45c6-b72d-e7c39e760e67"),

Guid.Parse("c3ba5085-92d1-406e-8279-2bb183360e88"),

Guid.Parse("d62f9d92-f37a-401c-96f6-234b30ec98a0"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a0976e7c-1ead-4a25-835a-9eb7235b424f"),

Guid.Parse("85c3b714-5e26-4aaa-9575-d433ef877336"),

Guid.Parse("9130074d-019c-4e3d-8917-b681d3fe7015"),

Guid.Parse("00da45e1-c3e1-43c3-9a5c-993b3de15185"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b83018b2-96d2-48e8-912f-4b0ace3350f1"),

Guid.Parse("bce0813b-098c-4d33-9acf-24d0e3fb644f"),

Guid.Parse("40550525-88e7-4653-baeb-40a4fb424611"),

Guid.Parse("280398ca-f2b6-4530-873e-6d8df617d46f"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("408291f0-19c3-4780-895c-cfead21199ad"),

Guid.Parse("9e118bc7-dca2-4f0b-8154-99193d032214"),

Guid.Parse("87786db4-4fbb-449e-80b8-8e2fdf34086a"),

Guid.Parse("6c66fe11-6d09-4634-9cd6-25369054980b"),

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
Guid.Parse("1715edc5-08ce-40f4-be26-ade31e6cf20a"),

Guid.Parse("1a4e5c05-3d2e-4d98-90b3-3ee973440bc3"),

Guid.Parse("1011c2fa-598a-4c2f-bee6-62f0620b4c46"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("8b85c0b4-d59a-4abd-b216-aff1a692bd75"),

Guid.Parse("e0dcb357-a8cd-4986-a3ff-42714b6d75ff"),

Guid.Parse("aebc9af6-3226-4efe-b0cb-d49daf1281eb"),

Guid.Parse("5cae7662-5387-4613-a9dc-657e311be7c4"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("27c99cdc-0560-4fc9-8324-aec34658b08a"),

Guid.Parse("f476d4cf-8b2f-4045-98cc-08bbc0c02bf2"),

Guid.Parse("94812dc9-04f7-41e2-a42b-8f2a0a27c1ad"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e0cb3103-b378-4ff9-a05a-2020a56ad83d"),

Guid.Parse("4c1b8731-33f3-4c98-b1e8-c7dce07f7548"),

Guid.Parse("f9be3583-66a6-4d99-a8c2-5a3600207f65"),

Guid.Parse("18d4e1d9-b153-4158-a7cd-86c897dfbd8c"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("28270860-02c0-4db4-aba4-6aa10f869e95"),

Guid.Parse("ed186cc9-5ef7-486c-a371-c75c02278a07"),

Guid.Parse("a20168ca-0754-4163-864c-61a8abc933da"),

Guid.Parse("53618806-8d27-4235-a05f-4d69b9bd34c3"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("89c8b324-9cc1-48ef-b517-962b5d585d1b"),

Guid.Parse("2a6c4bb2-6bda-4d68-891c-437b7fb3d009"),

Guid.Parse("83286b24-6afe-4f34-9156-7400e412ef3d"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("614a94bb-634e-4ed2-9f9d-b83ec5c9f909"),

Guid.Parse("b75d4410-ad5a-4efe-9779-dac29484102e"),

Guid.Parse("85c28a07-d504-4303-9cbc-ced1a2fe3149"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("add130cb-488a-4c9c-9428-a691babb11dd"),

Guid.Parse("3e4e230f-c6e8-4492-bcc0-81219693e8ea"),

Guid.Parse("377152e1-9680-4688-ba48-355a2967a843"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("8fd167cd-6096-4f37-81d6-335159871107"),

Guid.Parse("aa5bba7d-8f42-4ddb-a051-929b2aaf0c0c"),

Guid.Parse("41e391a4-e6c7-46c3-bb30-73a57a075a68"),

},
},
            new GuiduuidArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a2464c20-039c-4915-96a7-edfd25da122a"),

Guid.Parse("438048a0-68cb-4631-85d0-d97ee6646bde"),

Guid.Parse("51a6bd64-770b-4dad-a39e-2ee48f87bb69"),

Guid.Parse("0a00fb97-cfa9-41e9-9175-a1a8d10886b4"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("de5240d7-6ac7-4a5b-a7e2-82cc0c1edc54"),

Guid.Parse("89fc3097-f6c2-4ab3-b303-bba08e234426"),

Guid.Parse("b52bfbc0-6171-42e5-801d-bb5d3c9b62ab"),

Guid.Parse("8ed59429-a0c7-4c5c-87db-b4e96957cb57"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f0c7e53a-db89-4b92-b835-49b097afdb3f"),

Guid.Parse("7127b7e7-bc19-4555-8a6a-1cb94ee7407e"),

Guid.Parse("c5371cdc-8956-47c4-abc8-7d3968cbdf27"),

Guid.Parse("766d2eb7-f812-4d55-ab51-4d9bdb8c89cd"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7c291a20-8f85-48a3-866b-9e589314b2d4"),

Guid.Parse("0cefb71c-f720-48b0-ba71-c80bcf41a3c0"),

Guid.Parse("319526da-a6f0-4f34-a151-24cd9a024092"),

Guid.Parse("36527612-982f-41ef-bda7-767c879a4315"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4bbef682-5c94-4e29-b267-a787bed23895"),

Guid.Parse("54f6cb80-5b07-4f50-bd2c-8c4f891d8f0c"),

Guid.Parse("65faa645-5798-4584-9caa-1dcedc3d6f25"),

Guid.Parse("a75bb0b9-d6fb-44e0-a870-9fd67ba7e8b5"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("45b53dcf-e1de-4196-8dc6-9b5af8f2f019"),

Guid.Parse("691e0176-89cb-4121-bac7-76f1c1ff6fd6"),

Guid.Parse("4dc58631-dc72-4a3c-aafa-8d258db6e372"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2941c71e-f186-40d9-b5d8-584da14473d2"),

Guid.Parse("a720154b-a673-4ce2-a8d1-47cd00371592"),

Guid.Parse("e99a6d53-21ef-449e-85d4-9e137198b449"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("545c52b4-0016-4e4a-a42f-dde5754c48e0"),

Guid.Parse("a6baada0-9e38-4bf8-8369-7e2e070bdfe7"),

Guid.Parse("ef103759-3a7c-457b-bcd5-2e08d13def3b"),

Guid.Parse("3328b562-176f-4ffb-82b8-566869326a17"),

},
},
            new GuiduuidArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fb62f26d-9c91-4aed-8c04-bf1f2b6f0aff"),

Guid.Parse("3a1974d6-d119-4075-bc59-0dce19b4b80a"),

Guid.Parse("00ae3f2e-b077-4dc0-a63c-d7539c9d4373"),

Guid.Parse("74cf1d59-625c-48a4-ab91-b78481f671fd"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("dee7a06d-4cfb-4789-acf0-fb14d539ae0c"),

Guid.Parse("bf8ed5d2-d8d3-4900-afe2-4b0e5344fc03"),

Guid.Parse("ad483214-92c5-4764-a27b-59f34a73d8ca"),

Guid.Parse("bbd32336-d226-40f9-b657-0d36db5999e4"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ccae1c38-7119-4b43-a545-d4c2949e866b"),

Guid.Parse("6debd318-77a4-4c81-92a2-ce116ae00c1e"),

Guid.Parse("27418574-925a-4695-8524-54614b219a93"),

Guid.Parse("e953eb81-dd39-4e83-88d0-44bf606da464"),

},
},
            new GuiduuidArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4ef867f3-1139-4f4c-a8c1-59be8d1d2aa3"),

Guid.Parse("fc4e6438-4169-4635-960c-bb143b49b364"),

Guid.Parse("8cd67955-817e-43a3-9c70-c73172f2ab6f"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("28de8702-c8ca-42b2-90a7-aa0cd6cddad6"),

Guid.Parse("9368982a-d898-4619-a544-4fbdd162c2c1"),

Guid.Parse("326ecc9e-bda3-49cd-8c95-8985bfcd0a9a"),

Guid.Parse("6657c9c6-b92c-46fd-bb60-faa1c229375b"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("6ed07de9-9434-402b-89eb-460424069613"),

Guid.Parse("7cf13771-4521-45f5-b6f0-428deaeceebd"),

Guid.Parse("a421cfbc-4952-407d-a306-acfc2396f6f5"),

Guid.Parse("800949be-6aba-4275-a1fb-de35218ee025"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("12488ec3-f71b-4540-9413-9a96f5341cb0"),

Guid.Parse("d996de0f-b1c8-4214-958a-70cb9b20418a"),

Guid.Parse("d3964471-0611-4c6d-8020-e82a53601f09"),

Guid.Parse("0daec5ce-d18b-4618-9dfe-1f4a499e33f5"),

},
},
            new GuiduuidArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bd4709f7-a467-4427-b276-c9ad74e82af7"),

Guid.Parse("2f2a9af1-f92a-4e45-8b43-0c9535b26e83"),

Guid.Parse("ac4490e3-673c-4e50-893b-20c1c652d2e4"),

Guid.Parse("0274c19e-f99c-428f-ad6a-3c63b9218ccf"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("fb3cb451-69a7-4c84-8a06-df4c68f10692"),

Guid.Parse("0c42342b-77ff-4f2a-bec6-905966d20b8a"),

Guid.Parse("f56cfc67-e905-4ede-800f-6d70277a5bad"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("63c44ae3-036b-4dc6-974a-efbd4e969c9f"),

Guid.Parse("9172f518-fa85-40e2-a3ab-0d6ab38e047b"),

Guid.Parse("456da1ca-1b3d-4f00-aa88-858ddbee5ab5"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("05a8c3d3-6f3d-47ae-a3bd-ccc20f59f1c4"),

Guid.Parse("c3148f2e-89e3-42d7-8fa1-549ed9397ace"),

Guid.Parse("e5b42772-a0f4-4e09-85a3-6b93cd0c5953"),

Guid.Parse("bff02e1a-a293-471f-a182-f0ecfa43bf16"),

},
},
            new GuiduuidArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0461c2f6-22a7-4b25-8152-d5cc81263900"),

Guid.Parse("034c1c5b-9b04-42d0-b9bb-7dfdd9b0c2fd"),

Guid.Parse("eedb6736-ae1d-4ab3-8490-735fd0d6ddb9"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f74a887f-4cf7-4910-b909-c989d83c6aba"),

Guid.Parse("d5358595-5649-4910-8ef0-3b916798f5f6"),

Guid.Parse("543148de-5b55-40bd-afa6-c51a27d15d8e"),

Guid.Parse("65382633-c9a3-4939-9d7c-bee5503d0e61"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3ff28267-814e-44db-add8-5ef5c20354bc"),

Guid.Parse("67160ae0-da6e-415e-8e77-9117e4355b43"),

Guid.Parse("5daeea96-a92a-461a-bcdf-03269fc6270b"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a8fd88ab-bd42-43f3-983c-5e2c09aefa94"),

Guid.Parse("96f89232-17c7-4b7f-907c-5fcc50084da1"),

Guid.Parse("614225af-3b7a-4490-acae-40d390439070"),

Guid.Parse("c05dae86-b3c3-4917-b1b1-39b0934c7010"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("281cd601-2d81-4e7e-b6cc-14a8caf46685"),

Guid.Parse("02ea51de-0c5b-4104-ad2d-60947ee9390c"),

Guid.Parse("b7783e7f-0c0b-4a5b-92c9-285c2aba7c20"),

},
},
            new GuiduuidArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("eefbc1a5-b211-4375-a696-8542004c9a6d"),

Guid.Parse("b1c3e154-ac82-46da-af18-9f739246104b"),

Guid.Parse("30bebab2-f094-413c-b048-44b4540ee851"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b7e153fb-a15c-4a44-8452-98a953ab94f7"),

Guid.Parse("8e5d77e2-b19d-4425-8a94-e0fc585aae0a"),

Guid.Parse("c30bf06d-9965-46c4-99a6-363e9f8f21e5"),

Guid.Parse("08d71d60-3ecf-4dac-89dc-05520b03eb4d"),

},
},
            new GuiduuidArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2a78b6cc-a2c7-4fd0-9042-677643a76d38"),

Guid.Parse("4442f169-7fd4-4603-98a3-41a96122658e"),

Guid.Parse("c66c4a87-3941-437d-b6ee-784d9535e9cc"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("8bbf605b-ceb7-4348-9bfb-b5d58256effe"),

Guid.Parse("b924e628-8488-48ad-a05d-e33ab83fab2f"),

Guid.Parse("8f4e8314-c4e1-4632-985d-79902a1480d1"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2a98b5ec-69fb-4726-aeb1-9a62090cda51"),

Guid.Parse("302c1aa0-841e-4337-ad28-8d4a0ecfe055"),

Guid.Parse("5c10b581-3676-4208-a8ab-7b1feced0490"),

},
},
            new GuiduuidArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("22c7f643-a26e-4a15-856c-f478b5be0668"),

Guid.Parse("259cbbf0-0df9-4096-a015-265c683ee72f"),

Guid.Parse("da9ce1cf-ac54-46fa-a5f2-aedc478ce83c"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("0f243659-b0ee-400d-a2f2-9a322451794e"),

Guid.Parse("cb3690a4-2c55-48a3-8e0c-b19488b23feb"),

Guid.Parse("9891a64d-a086-4297-98a6-3470f25535e2"),

Guid.Parse("120f1052-f6da-4084-b0e4-c06f6cce6989"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c2086f4c-81e0-4be6-a011-4a7559d15eae"),

Guid.Parse("4a22e0bf-439e-49fc-9c64-6af620770e0d"),

Guid.Parse("5f89dd7f-6a0d-401e-85bc-b73ad6102851"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("83e37744-4779-4830-9da6-d53f29e5bb26"),

Guid.Parse("02f8fe04-769f-4df5-9257-f7b1817e721b"),

Guid.Parse("d4ede88f-417f-41fb-b967-ae110df6bf0f"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f991f283-1225-48ba-8465-6b053a8916b2"),

Guid.Parse("85e215fb-9414-4a8a-a7f7-4aa4fed84a89"),

Guid.Parse("c0dd0fb2-580d-4fb4-a8a8-f5cd0eb70d1e"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f6d4f623-a4d5-46a3-9230-5fc1ceabccb3"),

Guid.Parse("9c439f96-d06c-4255-b6ae-169ac4bf865e"),

Guid.Parse("aefd201b-cc09-43c8-a7e5-758128acfaf1"),

Guid.Parse("72bf6e2a-f703-47bd-be7d-f2183e84c2ac"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b182036c-84b6-4dfd-9345-4fcf756ef193"),

Guid.Parse("730888e8-2d73-40d0-9d5d-bf8c86b9117f"),

Guid.Parse("1e974f19-551a-4c5f-ae39-75edfc84159e"),

Guid.Parse("0a918605-0e45-4b2b-9cc7-2e44167d3f45"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b0aa640a-2a03-4438-8e15-2329cbed29af"),

Guid.Parse("14458486-1213-48b4-869e-1b494ef498ae"),

Guid.Parse("0c760c3b-64a1-466e-825c-76b2268c8ebd"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("8445dfb5-57fa-46b6-a5fc-c32a0f7bebb4"),

Guid.Parse("486fb175-7313-46d4-8c87-b90f9628a0fb"),

Guid.Parse("d4be6f8c-1f5b-48f7-afc3-5799ef453cbf"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("17f6dd3d-eea5-4a8e-80cb-8b865515418e"),

Guid.Parse("2e95231c-ac1d-49f1-9fea-343b439c8200"),

Guid.Parse("1d90c520-f6d0-4c49-b40a-6cbee5d84309"),

Guid.Parse("42365a5d-7bcb-4022-bd39-05c700332054"),

},
},
            new GuiduuidArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("6354f183-1684-4aba-b164-8a6dc10ccde9"),

Guid.Parse("667f053a-2ab0-416f-81b6-d9aacc1463d0"),

Guid.Parse("127f549f-66ca-41c9-9019-c7218f8bc7c8"),

Guid.Parse("090695ac-4eb2-4a3f-8a58-e370ccb76537"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("520caab8-a542-4486-b30b-d729ab158281"),

Guid.Parse("afc77361-f909-4f42-b4be-75fc38bc7091"),

Guid.Parse("697516c2-8168-42a0-aeb6-84a05d61e13e"),

Guid.Parse("fa462feb-755c-4496-86c0-6b60dc4db552"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("53a117c0-6da3-419c-a761-0bf7e2974e6c"),

Guid.Parse("b53a2d64-758c-442a-a08e-e5b2a507678f"),

Guid.Parse("9a4f555b-2ccb-4d52-b63d-d80945f840e9"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("95becada-2e5c-406f-8267-34976a0dba7d"),

Guid.Parse("9511eedd-d59a-4a35-ab26-e304df38766b"),

Guid.Parse("bdabbbd1-e381-40ba-b706-bb42269195e1"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("7750e94b-4814-4abe-bcf8-451ab72970e6"),

Guid.Parse("1ddd80e6-f30a-4fce-a5e0-402866676353"),

Guid.Parse("a9805e8c-f20a-4dd7-bc79-7fb3c69b4474"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("6afadc72-6b3b-452f-9faa-40eae8eafaea"),

Guid.Parse("7c863214-4f46-41e7-8820-1d76894de83c"),

Guid.Parse("09547bf7-b079-4f47-ba5b-816be7dd2273"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("560e4ecc-aa2d-4560-a626-bf4176ecd330"),

Guid.Parse("b4ce4a31-82e2-4f1a-ad2a-9e7ed8500b7e"),

Guid.Parse("a83dc624-912c-4952-bea0-f81ee2b882c7"),

Guid.Parse("d964d5c8-a7cd-4f98-b924-fe27d9080636"),

},
},
            new GuiduuidArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2f77839f-8a83-44a0-8d4c-23adef705caa"),

Guid.Parse("839ead55-99b6-4d71-9084-5f660cc9ce9d"),

Guid.Parse("fb06c04b-2265-403b-a40c-5f48e7ed32de"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d5082c5a-d2ce-4718-9e68-4cadb2f6f31c"),

Guid.Parse("088d61f5-bc94-4959-8319-eaf4c353851a"),

Guid.Parse("898d2d4a-4e8f-4aec-9945-f4ae0e97c00d"),

Guid.Parse("d5f9ba81-32cc-4f59-bab9-175266faeabf"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a2471c0a-2da3-4fd0-9635-64ded47ed913"),

Guid.Parse("a033b3d6-37da-47c6-944c-19abeddbb29e"),

Guid.Parse("a79c9004-6d67-49e9-b032-5c1b357fe415"),

Guid.Parse("e92889b1-80fd-4820-bd99-dc2e3fb5b41a"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4379261c-1445-4e7c-844b-e3230d5ad928"),

Guid.Parse("1f5020b9-057b-4bbd-b7c5-fdfaff28f63c"),

Guid.Parse("eed07688-fef9-411a-91b4-6bfa4316dadf"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f7c24fe4-1891-47c5-98bf-2b77ae8594c2"),

Guid.Parse("6c66d7d5-1a91-4df2-92fb-d9415a1bd75f"),

Guid.Parse("70d84ac2-8d8e-43cb-ab66-436feac10b3b"),

},
},
            new GuiduuidArray2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("879b0c31-fc9f-4ca9-8055-f8d440cbf723"),

Guid.Parse("e8dfab83-6abb-4a1e-8ad7-2705d00ee413"),

Guid.Parse("154d01bf-b2ac-4a3f-84ca-10e9eef9ee3d"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bde262e7-7ca4-45ae-af29-d25de07b0557"),

Guid.Parse("cdc840f5-12da-4356-9076-c61332f623f3"),

Guid.Parse("5e73641d-f16e-4b8e-9103-da7999255433"),

Guid.Parse("d255fa1c-cdef-4293-9592-5f7b23f79e40"),

},
},
            new GuiduuidArray2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("2c6f6f1f-343b-4177-9903-0f262836ac69"),

Guid.Parse("0c1a4ca2-2f68-4de2-9ad8-753c66557383"),

Guid.Parse("d9e54ab3-3a05-4d97-ad74-f637400195f9"),

Guid.Parse("27e3c4ef-9fad-4494-98fb-49843dc532fc"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f855d2ba-fe75-4fc3-bd4c-fc3a99b36d92"),

Guid.Parse("f79a70df-e3da-4a28-984a-8396604367aa"),

Guid.Parse("8d42f44a-d81f-4788-aabd-00a3f64b517b"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("59323dc0-76d9-46eb-b54b-2a2091fe1d93"),

Guid.Parse("7a3ec1ee-2d61-4f95-b67a-b759a1b53b2f"),

Guid.Parse("4c541097-8570-4fe0-93be-562e5fac2ec1"),

Guid.Parse("7d79d689-9252-4adc-86e7-b2ef473d56a7"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("aa334ce5-6ba5-40b4-871e-f7d3058ac57c"),

Guid.Parse("6e1fa389-72bb-4b96-8250-297ed6160145"),

Guid.Parse("b26c63cf-7aef-4220-96af-67905592db1a"),

},
},
            new GuiduuidArray2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("a6c58640-3372-4c0b-841f-c4cf6d3b089d"),

Guid.Parse("47f37805-670f-45b3-ab34-b200d974195a"),

Guid.Parse("46e3e317-8d2f-4466-a3b2-7de6108de5ca"),

},
    ModelInner = null,
    NullableValue = null,
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[34], false);
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
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[34], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
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
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[19],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[20],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[21],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[22],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[23],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 1;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
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
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[34], false);
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
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
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
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[19],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[20],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[21],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[22],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[23],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[24],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[25],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 161;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[34], false);
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
                parametr1.Value = 1;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        GuiduuidArray2M.AssertModel(models[0],_testData[1], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[2], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[3], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[4], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[5], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[6], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[7], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[8], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[9], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[10], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[11], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[12], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[13], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[19],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[20],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[21],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[22],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[23],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[24],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[25],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[26],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[27],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[28],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[29],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[30],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[31],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[32],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        GuiduuidArray2M.AssertModel(models[0],_testData[4], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[5], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[6], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[7], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[8], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[9], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[10], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[11], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[12], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[13], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[19],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[20],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[21],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[22],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[23],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[24],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[25],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[26],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[27],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[28],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[29],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 152, query1, 28, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[28],_testData[34], false);
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
                await ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 132, query1, 132, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[34], false);
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
                 ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 56, query1, 56, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[23],_testData[34], false);
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
                 ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 4, query1, 161, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 54, query1, 137, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[19],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[20],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[21],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[22],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[23],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[34], false);
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
                await ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 74, query1, 152, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 124, query1, 149, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[34], false);
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
                 ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 137, query1, 121, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTSelectModelBatchAsync(connection, 4, 152))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        GuiduuidArray2M.AssertModel(models[0],_testData[2], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[3], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[4], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[5], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[6], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[7], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[8], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[9], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[10], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[11], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[12], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[13], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[19],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[20],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[21],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[22],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[23],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[24],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[25],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[26],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[27],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[28],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[29],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[30],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[31],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[32],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTSelectModelBatch(connection, 105, 54))
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
                        Assert.That(models, Has.Count.EqualTo(25));

                        GuiduuidArray2M.AssertModel(models[0],_testData[10], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[11], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[12], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[13], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[19],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[20],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[21],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[22],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[23],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[24],_testData[34], false);
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
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 124);
                var models = await ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(9));

                GuiduuidArray2M.AssertModel(models[0],_testData[26], false);
                GuiduuidArray2M.AssertModel(models[1],_testData[27], false);
                GuiduuidArray2M.AssertModel(models[2],_testData[28], false);
                GuiduuidArray2M.AssertModel(models[3],_testData[29], false);
                GuiduuidArray2M.AssertModel(models[4],_testData[30], false);
                GuiduuidArray2M.AssertModel(models[5],_testData[31], false);
                GuiduuidArray2M.AssertModel(models[6],_testData[32], false);
                GuiduuidArray2M.AssertModel(models[7],_testData[33], false);
                GuiduuidArray2M.AssertModel(models[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidListuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 124);
                var models =  ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(9));

                GuiduuidArray2M.AssertModel(models[0],_testData[26], false);
                GuiduuidArray2M.AssertModel(models[1],_testData[27], false);
                GuiduuidArray2M.AssertModel(models[2],_testData[28], false);
                GuiduuidArray2M.AssertModel(models[3],_testData[29], false);
                GuiduuidArray2M.AssertModel(models[4],_testData[30], false);
                GuiduuidArray2M.AssertModel(models[5],_testData[31], false);
                GuiduuidArray2M.AssertModel(models[6],_testData[32], false);
                GuiduuidArray2M.AssertModel(models[7],_testData[33], false);
                GuiduuidArray2M.AssertModel(models[8],_testData[34], false);
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

