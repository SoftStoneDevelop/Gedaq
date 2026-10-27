

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
    internal partial interface IGuidv7ListuuidListD1
    {
    }
    
    internal partial class Guidv7ListuuidListD1 : IGuidv7ListuuidListD1
    {


#region TestData

        private readonly Guidv7uuidListD1E2M[] _testData = new Guidv7uuidListD1E2M[]
        {
            new Guidv7uuidListD1E2M
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-7f5c-b847-575038a734c9"),

Guid.Parse("01a17ef0-3a2c-75e6-a56a-59168a5b47b4"),

Guid.Parse("01a17ef0-3a2c-78eb-ad0f-49f545184b95"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-7b6c-846f-77a294de3668"),

Guid.Parse("01a17ef0-3a2c-7a00-9b95-8cd952f77927"),

Guid.Parse("01a17ef0-3a2c-776d-a4ab-5739be215ddb"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-7588-af37-89a2241eb210"),

Guid.Parse("01a17ef0-3a2c-770d-be50-2684b1782a9c"),

Guid.Parse("01a17ef0-3a2c-76d1-adb0-7fea95ba121a"),

Guid.Parse("01a17ef0-3a2c-7fc1-a111-d754d853eb8f"),

},
    ModelInner = new Guidv7uuidListD1E2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-75ab-b785-89e4f6f21f2d"),

Guid.Parse("01a17ef0-3a2c-7ce8-bc84-16393380c29a"),

Guid.Parse("01a17ef0-3a2c-772d-92ed-742efa8eeacf"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-720a-9ebb-1b0d1065e928"),

Guid.Parse("01a17ef0-3a2c-70d0-9e57-ca2a7bd59516"),

Guid.Parse("01a17ef0-3a2c-7eac-b4f1-ce487f1b6154"),

},
},
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-7a82-be08-78b579f0e5e0"),

Guid.Parse("01a17ef0-3a2c-74d3-83ce-7f993a6ec4b4"),

Guid.Parse("01a17ef0-3a2c-7a89-815a-11b96e6ebdfe"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-7d46-b06c-f6514980db87"),

Guid.Parse("01a17ef0-3a2c-725d-87c6-e747abb88dd4"),

Guid.Parse("01a17ef0-3a2c-7db7-a951-47dca4ae39b3"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-7da6-8bc9-029ecf69cec4"),

Guid.Parse("01a17ef0-3a2c-735c-a32a-cd48f77e6d4b"),

Guid.Parse("01a17ef0-3a2c-7837-84f0-0df5ba849a77"),

},
    ModelInner = new Guidv7uuidListD1E2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-7b53-9ff1-4d3b2a587117"),

Guid.Parse("01a17ef0-3a2c-79b7-9979-ad32d4abe9c5"),

Guid.Parse("01a17ef0-3a2c-76e5-998c-ccc8b1bcb4a1"),

Guid.Parse("01a17ef0-3a2c-7930-bcb1-2e13b2b0fe3f"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-7791-8b6a-3b157aa71fb7"),

Guid.Parse("01a17ef0-3a2c-751a-a039-67569003aacb"),

Guid.Parse("01a17ef0-3a2c-7b55-aeaa-78b39a604281"),

Guid.Parse("01a17ef0-3a2c-7a09-a9be-fd3765720dc0"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-775f-bee3-476b5bdb9214"),

Guid.Parse("01a17ef0-3a2c-73a7-bba6-b38948101b03"),

Guid.Parse("01a17ef0-3a2c-7bfd-9f3e-239a25a37077"),

Guid.Parse("01a17ef0-3a2c-7dc5-9ac8-4c2b996fb413"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-7e99-9fb8-d1b2f745c249"),

Guid.Parse("01a17ef0-3a2c-73fe-8755-0bc7712b2cde"),

Guid.Parse("01a17ef0-3a2c-789b-8b99-f034df1da16a"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-75fb-9f89-7d320ef837e5"),

Guid.Parse("01a17ef0-3a2c-7e49-a623-a6659ae760f3"),

Guid.Parse("01a17ef0-3a2c-76a6-8594-168db71dc4c7"),

Guid.Parse("01a17ef0-3a2c-7b04-9d00-58b47e834b77"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-766a-8a2b-c0627091a0e8"),

Guid.Parse("01a17ef0-3a2c-7533-b20d-490ce57cc439"),

Guid.Parse("01a17ef0-3a2c-77b2-95e9-c90aab6a970f"),

Guid.Parse("01a17ef0-3a2c-7afe-9157-88cb149d0555"),

},
    ModelInner = new Guidv7uuidListD1E2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-75f4-b16a-cf6af695f224"),

Guid.Parse("01a17ef0-3a2c-70eb-bec5-21b4fe8055be"),

Guid.Parse("01a17ef0-3a2c-7858-8110-cd4d1fcefdb5"),

Guid.Parse("01a17ef0-3a2c-720a-affb-f08a0ce9242c"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-759e-a907-22431150a1d2"),

Guid.Parse("01a17ef0-3a2c-7a38-9238-f07747b2482e"),

Guid.Parse("01a17ef0-3a2c-7d57-9adc-3fae53360861"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-7694-91ce-58ac441b727f"),

Guid.Parse("01a17ef0-3a2c-7a4b-b8bc-231b5a2e03dc"),

Guid.Parse("01a17ef0-3a2c-79b0-a02b-9e38f65a7728"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-7dad-8b12-aa32cf72224a"),

Guid.Parse("01a17ef0-3a2c-7304-b14a-38bd6173a83a"),

Guid.Parse("01a17ef0-3a2c-7cf8-8000-828fe9abc7fc"),

Guid.Parse("01a17ef0-3a2c-7996-97a7-35c14c774b20"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-7c59-b77f-1e6f94f03a0a"),

Guid.Parse("01a17ef0-3a2c-70cf-bfaa-9a5ba4dba0d5"),

Guid.Parse("01a17ef0-3a2c-7a7f-9f69-9644c76a969e"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-7878-98a8-fad45de56a2f"),

Guid.Parse("01a17ef0-3a2c-7e6c-8bb8-eedc09033bf4"),

Guid.Parse("01a17ef0-3a2c-7468-b8b1-6293c026e41b"),

Guid.Parse("01a17ef0-3a2c-75e5-8844-6bca6c180d38"),

},
    ModelInner = new Guidv7uuidListD1E2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-7805-8d7e-17188939e73d"),

Guid.Parse("01a17ef0-3a2c-77f8-a002-f46b0e980260"),

Guid.Parse("01a17ef0-3a2c-717e-8181-21ea210f8903"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-7ab9-a81c-4ac443a5781d"),

Guid.Parse("01a17ef0-3a2c-7c9e-9951-fcc71697b1d8"),

Guid.Parse("01a17ef0-3a2c-70a0-842f-dca5a0185f61"),

Guid.Parse("01a17ef0-3a2c-71b9-9532-6f95e6595134"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-7211-9809-8b4615b76e2c"),

Guid.Parse("01a17ef0-3a2c-7d7c-a668-6595144b3fb3"),

Guid.Parse("01a17ef0-3a2c-7ec5-b2a5-9c252fad52b0"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-7847-bf66-8227c5c4b66a"),

Guid.Parse("01a17ef0-3a2c-74d6-8033-4f24c8d41f8a"),

Guid.Parse("01a17ef0-3a2c-7259-99d5-6fb53a27f0ca"),

Guid.Parse("01a17ef0-3a2c-77ce-9f2e-1aef8517ddf3"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-7c06-9e5e-6d83d5dad7b9"),

Guid.Parse("01a17ef0-3a2c-71c2-89e5-3fc67d47b3d0"),

Guid.Parse("01a17ef0-3a2c-7f12-8c61-1f495a2d32f7"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-7ae9-8657-799f41a7f2f1"),

Guid.Parse("01a17ef0-3a2c-7e67-8a20-2c6d250a42ee"),

Guid.Parse("01a17ef0-3a2c-7be7-8ee1-4f7e7fd171b1"),

Guid.Parse("01a17ef0-3a2c-710c-a130-c840e9e1428e"),

},
    ModelInner = new Guidv7uuidListD1E2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-7744-8185-6769b4887267"),

Guid.Parse("01a17ef0-3a2c-7a6a-ac35-a84343b58363"),

Guid.Parse("01a17ef0-3a2c-779c-a700-eb9aad744fa6"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-7216-9baf-12d12494026d"),

Guid.Parse("01a17ef0-3a2c-7e81-9aa2-5c18090d6ffe"),

Guid.Parse("01a17ef0-3a2c-7aba-b00d-f4886f729952"),

Guid.Parse("01a17ef0-3a2c-7566-8b54-6ecdaf82a7db"),

},
},
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-7e7b-9b77-7f4328d4b52a"),

Guid.Parse("01a17ef0-3a2c-7604-b4a7-de4af482a691"),

Guid.Parse("01a17ef0-3a2c-776e-9ee5-27b0e974e30f"),

Guid.Parse("01a17ef0-3a2c-76f0-8b1e-9eb89f8956da"),

},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-7cf0-914f-e4fa95f75245"),

Guid.Parse("01a17ef0-3a2c-7e72-b12b-ff6416162cfb"),

Guid.Parse("01a17ef0-3a2c-78d3-a41c-9f7a92a7ee61"),

Guid.Parse("01a17ef0-3a2c-7bde-bd46-6c8c74c0bfb1"),

},
    ModelInner = new Guidv7uuidListD1E2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-7454-9ef1-a5bcd9571410"),

Guid.Parse("01a17ef0-3a2c-7039-a4ca-182acaa996c9"),

Guid.Parse("01a17ef0-3a2c-7ccc-82b9-9fb43b93d446"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-72d1-8c76-77704f8706bb"),

Guid.Parse("01a17ef0-3a2c-750f-97ca-145fc2a9778c"),

Guid.Parse("01a17ef0-3a2c-7cb9-887d-639e4e59bb36"),

Guid.Parse("01a17ef0-3a2c-760d-943d-8ba90f2461ea"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-7198-a4f9-4b6b52f038c2"),

Guid.Parse("01a17ef0-3a2c-76ce-b382-698a1625a63b"),

Guid.Parse("01a17ef0-3a2c-7ce5-aa27-babdee06ce13"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-782c-8d04-ddc8570ff47b"),

Guid.Parse("01a17ef0-3a2c-7b70-b7ef-25e0f61af9e7"),

Guid.Parse("01a17ef0-3a2c-7109-8aca-3a1c838d3a7c"),

},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-79ae-88e9-8de0e8f6b44f"),

Guid.Parse("01a17ef0-3a2c-7874-9d76-a580f7fe4a01"),

Guid.Parse("01a17ef0-3a2c-7deb-93b9-7ff9b348ed9c"),

},
    ModelInner = new Guidv7uuidListD1E2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-70c4-b4dc-fb844d8b2498"),

Guid.Parse("01a17ef0-3a2c-7d25-9894-e390928ca7c1"),

Guid.Parse("01a17ef0-3a2c-7649-a671-a7c76e9b5b47"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-7f5c-a5da-63c0e044ca75"),

Guid.Parse("01a17ef0-3a2c-761b-92ed-80259d4f2e8a"),

Guid.Parse("01a17ef0-3a2c-7510-9d05-a38927c38164"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-71d6-9a73-e8c6633b237b"),

Guid.Parse("01a17ef0-3a2c-7ba0-b20f-53623921e7dc"),

Guid.Parse("01a17ef0-3a2c-71f8-be7b-c02f1e09816a"),

Guid.Parse("01a17ef0-3a2c-765f-bad8-e1fdd9e670a4"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-7488-a579-6495b3450242"),

Guid.Parse("01a17ef0-3a2c-749c-9a8a-cca2a3b85d80"),

Guid.Parse("01a17ef0-3a2c-7fbb-9c2e-1f5e178fc88d"),

Guid.Parse("01a17ef0-3a2c-7739-9150-843bb5bfa085"),

},
    ModelInner = new Guidv7uuidListD1E2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-76d6-961f-a62eacdadb83"),

Guid.Parse("01a17ef0-3a2c-7409-a006-9aca5ac08049"),

Guid.Parse("01a17ef0-3a2c-7aae-b4dd-60bcbbe6aa70"),

Guid.Parse("01a17ef0-3a2c-7238-82b9-60a6d291dfc1"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-71d9-9733-de478a81e355"),

Guid.Parse("01a17ef0-3a2c-7897-9310-2cae2f9968ba"),

Guid.Parse("01a17ef0-3a2c-7523-8782-81947bf4f449"),

},
},
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-7eb0-9d57-50912c1cef64"),

Guid.Parse("01a17ef0-3a2c-7faa-8bde-5b6e8e538119"),

Guid.Parse("01a17ef0-3a2c-7983-bfd7-7d0fe8e7bd04"),

},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-7731-8caf-a267ba0e4ca2"),

Guid.Parse("01a17ef0-3a2c-73f3-9d0b-85d4bc249503"),

Guid.Parse("01a17ef0-3a2c-714f-99be-ea7f4e4e9a4a"),

Guid.Parse("01a17ef0-3a2c-7059-aa07-2ac81d2ceec7"),

},
    ModelInner = new Guidv7uuidListD1E2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-7123-9f9c-e149a3238773"),

Guid.Parse("01a17ef0-3a2c-7334-9d5b-edbef9c3ca7e"),

Guid.Parse("01a17ef0-3a2c-7b7c-9d82-0c247f6da8ef"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-78f6-bf43-6cc8ff0a0d90"),

Guid.Parse("01a17ef0-3a2c-7e54-b40f-2dd0310fd14c"),

Guid.Parse("01a17ef0-3a2c-7db5-931e-59e56cbefd28"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-7d69-ab5f-37ae8ca2029f"),

Guid.Parse("01a17ef0-3a2c-7014-bd00-1a265bcd6b79"),

Guid.Parse("01a17ef0-3a2c-7526-8448-4458291b858c"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-75f9-b292-0d573cd4761b"),

Guid.Parse("01a17ef0-3a2c-7b2e-ae37-256eecbe89ec"),

Guid.Parse("01a17ef0-3a2c-7f24-af29-661483a8d014"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-7403-bab8-7fa63dbdd883"),

Guid.Parse("01a17ef0-3a2c-7bed-a008-8fa2ae3faab5"),

Guid.Parse("01a17ef0-3a2c-72d4-978a-b872b75de911"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-7220-b797-e79010eda967"),

Guid.Parse("01a17ef0-3a2c-7dc4-8a59-89add0918c85"),

Guid.Parse("01a17ef0-3a2c-7ae9-84fd-6681b57138c5"),

Guid.Parse("01a17ef0-3a2c-7aec-8d9a-182bcc45d334"),

},
    ModelInner = new Guidv7uuidListD1E2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-7c8f-b924-831d18fa9e5a"),

Guid.Parse("01a17ef0-3a2c-7f36-a845-3e29b1a940b6"),

Guid.Parse("01a17ef0-3a2c-7616-b517-fb865bf86f50"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-7e9f-8667-79b3ec6d4957"),

Guid.Parse("01a17ef0-3a2c-76a0-8ff9-b42d5fc4295f"),

Guid.Parse("01a17ef0-3a2c-7d8a-998d-5896697c7c7e"),

},
},
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-7d9a-bbe1-b46c439fe8f0"),

Guid.Parse("01a17ef0-3a2c-7b1a-addc-86d3f629c8a0"),

Guid.Parse("01a17ef0-3a2c-765e-9c56-4bd95d1fbac5"),

},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-714f-8c39-cc14de568698"),

Guid.Parse("01a17ef0-3a2c-7eab-a04e-1e2638fa7d9a"),

Guid.Parse("01a17ef0-3a2c-7fb3-8468-e9e75f640626"),

Guid.Parse("01a17ef0-3a2c-7b78-b209-1ae29f62cc73"),

},
    ModelInner = new Guidv7uuidListD1E2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-7cb2-a1fb-2d8ba7dc46df"),

Guid.Parse("01a17ef0-3a2c-7ce0-9dd6-cf9f42fe058e"),

Guid.Parse("01a17ef0-3a2c-75a0-935c-25c2b2dd1da9"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-7e22-8aa7-ff8f00204296"),

Guid.Parse("01a17ef0-3a2c-7434-a759-26ebdf76cd58"),

Guid.Parse("01a17ef0-3a2c-7e8a-98eb-e26041bb0244"),

Guid.Parse("01a17ef0-3a2c-75a0-8128-0c5e6c2c6c3c"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-7b3e-aeb7-73c6940810cb"),

Guid.Parse("01a17ef0-3a2c-7b00-b140-2d45ffed0497"),

Guid.Parse("01a17ef0-3a2c-7c79-9df8-3927c8b1e698"),

Guid.Parse("01a17ef0-3a2c-7fbc-9476-b63062d6ac38"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-78b0-b953-67caaffe457d"),

Guid.Parse("01a17ef0-3a2c-7526-8b23-0a281f03e7e8"),

Guid.Parse("01a17ef0-3a2c-773c-91ef-74c630c783a0"),

Guid.Parse("01a17ef0-3a2c-76dc-8b71-63128c1859c6"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-7962-88ab-1d29d25ccfd9"),

Guid.Parse("01a17ef0-3a2c-7876-984b-c06b7cde93e6"),

Guid.Parse("01a17ef0-3a2c-7367-b59d-5543fabf7fe1"),

Guid.Parse("01a17ef0-3a2c-7753-90f7-113e9d7db5fc"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-7408-9d7c-cb67a81d38b9"),

Guid.Parse("01a17ef0-3a2c-7304-a701-f0aa1f1c949b"),

Guid.Parse("01a17ef0-3a2c-7a27-9469-e1a952bd1c22"),

},
    ModelInner = new Guidv7uuidListD1E2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-7a01-ade7-ab73ca1ec08a"),

Guid.Parse("01a17ef0-3a2c-79f6-9078-ed9c444f170b"),

Guid.Parse("01a17ef0-3a2c-7e57-9964-a11c440e4a07"),

Guid.Parse("01a17ef0-3a2c-7922-9a1c-b424453ea47b"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-7e25-98b7-572baa72f8b9"),

Guid.Parse("01a17ef0-3a2c-79ae-b9c4-e97d10c501ef"),

Guid.Parse("01a17ef0-3a2c-7656-826a-4d1abedb6459"),

},
},
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-7293-aa4a-286b711e97ca"),

Guid.Parse("01a17ef0-3a2c-732d-b06a-08c89a4a9119"),

Guid.Parse("01a17ef0-3a2c-7bd1-ac93-6293cd7971a5"),

},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-78dd-a962-79b125299042"),

Guid.Parse("01a17ef0-3a2c-7121-87a3-4fd4c3b4291d"),

Guid.Parse("01a17ef0-3a2c-7897-8e13-2e3caec4a79a"),

},
    ModelInner = new Guidv7uuidListD1E2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-7e72-96c2-ab428e988cfa"),

Guid.Parse("01a17ef0-3a2c-7671-89ff-ae381d9ad332"),

Guid.Parse("01a17ef0-3a2c-7333-b7f0-e599d0b4862f"),

Guid.Parse("01a17ef0-3a2c-7d3f-9854-0cc15d7e4844"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-7ffc-9d9c-625faa54d847"),

Guid.Parse("01a17ef0-3a2c-7b37-8114-de9ba270cf8c"),

Guid.Parse("01a17ef0-3a2c-78bb-8b61-dd36ee0dcdfd"),

Guid.Parse("01a17ef0-3a2c-7637-9f09-f7e0e53bbf4b"),

},
},
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-7394-89af-d717fe39a475"),

Guid.Parse("01a17ef0-3a2c-75e9-9f45-2386c3a02959"),

Guid.Parse("01a17ef0-3a2c-73fa-ad80-1005c4c1e5d1"),

},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-74db-9022-80c38b7dff2b"),

Guid.Parse("01a17ef0-3a2c-7005-9c5a-241b328dc4d6"),

Guid.Parse("01a17ef0-3a2c-7406-ad9c-d34242433fd6"),

Guid.Parse("01a17ef0-3a2c-71c6-a56e-769339df0757"),

},
    ModelInner = new Guidv7uuidListD1E2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-70e7-9881-0838c44d36f2"),

Guid.Parse("01a17ef0-3a2c-71ee-932f-096b200bd57f"),

Guid.Parse("01a17ef0-3a2c-7ff6-bd3a-98847db2200e"),

Guid.Parse("01a17ef0-3a2c-7392-8984-b4b810f764e1"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-7359-a13a-b96a7751dfe7"),

Guid.Parse("01a17ef0-3a2c-7af8-baec-22912066f4f0"),

Guid.Parse("01a17ef0-3a2c-79d3-8156-e862cc3bdb24"),

Guid.Parse("01a17ef0-3a2c-71ca-8fbd-f5d9dab0f4ce"),

},
},
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-7842-8bff-c26805e4892b"),

Guid.Parse("01a17ef0-3a2c-76be-9057-b1fc7c461caa"),

Guid.Parse("01a17ef0-3a2c-72f8-bc6e-8c2afef42316"),

Guid.Parse("01a17ef0-3a2c-76ba-85fe-844c82291a1a"),

},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-7e6d-8d90-7aaed8873c64"),

Guid.Parse("01a17ef0-3a2c-7f57-a236-7202846ac1fc"),

Guid.Parse("01a17ef0-3a2c-7011-a085-aeaab835a652"),

Guid.Parse("01a17ef0-3a2c-7364-91c6-86897b630184"),

},
    ModelInner = new Guidv7uuidListD1E2MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-74a5-8edd-d0dbe59b386e"),

Guid.Parse("01a17ef0-3a2c-716d-a1d6-b85896ab0c5e"),

Guid.Parse("01a17ef0-3a2c-793c-b046-71035b6e3045"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-7d74-a48c-11ec95740895"),

Guid.Parse("01a17ef0-3a2c-7d9e-acdd-1ab365224a65"),

Guid.Parse("01a17ef0-3a2c-71e0-a1ec-cad0d4310d74"),

Guid.Parse("01a17ef0-3a2c-7312-b9a9-254d5948cee6"),

},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-7a56-af61-8557a8e77188"),

Guid.Parse("01a17ef0-3a2c-7275-94b6-343de8ba0d32"),

Guid.Parse("01a17ef0-3a2c-7aa3-a60a-16c50c4380c0"),

Guid.Parse("01a17ef0-3a2c-7789-8c41-57f999904215"),

},
    ModelInner = new Guidv7uuidListD1E2MI
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-702c-beef-b2c113b5500d"),

Guid.Parse("01a17ef0-3a2c-7e9b-8440-329561cee76e"),

Guid.Parse("01a17ef0-3a2c-7258-b3db-f8b8e6f36795"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-774d-99d1-81aa38b38183"),

Guid.Parse("01a17ef0-3a2c-7c90-a688-06e35cb780c7"),

Guid.Parse("01a17ef0-3a2c-70ff-b18b-9a5249907f71"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-7a9d-aac9-eaae316dd937"),

Guid.Parse("01a17ef0-3a2c-7644-a347-e32889f20768"),

Guid.Parse("01a17ef0-3a2c-7814-99ac-95c65707a512"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 166,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("01a17ef0-3a2c-7505-b579-801a73ad079c"),

Guid.Parse("01a17ef0-3a2c-7e3f-bbda-f580c4363595"),

Guid.Parse("01a17ef0-3a2c-71bc-8a42-1d851eb645ca"),

},
    ModelInner = new Guidv7uuidListD1E2MI
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-718f-b404-62c1b75fd8eb"),

Guid.Parse("01a17ef0-3a2c-75c3-8281-15cfffceb81e"),

Guid.Parse("01a17ef0-3a2c-707f-bee2-c7418d79e701"),

Guid.Parse("01a17ef0-3a2c-7542-809e-7c3f37273963"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-797f-a4aa-79be4b7ffe40"),

Guid.Parse("01a17ef0-3a2c-73ac-964b-28f1932ce268"),

Guid.Parse("01a17ef0-3a2c-7189-8274-4ef406ac3bb4"),

Guid.Parse("01a17ef0-3a2c-7655-a0a0-10d19e11bb9c"),

},
},
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-73b3-8681-ca46ce85d2fe"),

Guid.Parse("01a17ef0-3a2c-7877-8f05-86aa6dd01265"),

Guid.Parse("01a17ef0-3a2c-7be4-8094-b5af778ec088"),

Guid.Parse("01a17ef0-3a2c-79bb-a427-65ba0eb085ae"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("01a17ef0-3a2c-716b-bfd4-e32165c5e0bc"),

Guid.Parse("01a17ef0-3a2c-7369-9bb0-730a7555b0a9"),

Guid.Parse("01a17ef0-3a2c-7ad0-abc6-d0d71ca49aaf"),

Guid.Parse("01a17ef0-3a2c-7223-ae6a-8614503a069d"),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guidv7uuidlistd1e2mi(
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
            asPartInterface: typeof(IGuidv7ListuuidListD1)),
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
INSERT INTO public.guidv7uuidlistd1e2mi(
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
            queryMapTypes: [typeof(Guidv7uuidListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7ListuuidListD1)),
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

                changedRows =  ((IGuidv7ListuuidListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidv7ListuuidListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IGuidv7ListuuidListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidv7ListuuidListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IGuidv7ListuuidListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IGuidv7ListuuidListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IGuidv7ListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IGuidv7ListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IGuidv7ListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IGuidv7ListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IGuidv7ListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IGuidv7ListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IGuidv7ListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IGuidv7ListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IGuidv7ListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IGuidv7ListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IGuidv7ListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guidv7uuidlistd1e2m(
	id,
    value,
    nullablevalue,
    guidv7uuidlistd1e2mi_id
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
            asPartInterface: typeof(IGuidv7ListuuidListD1)), 
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
                methodParametrName: "guidv7uuidlistd1e2mi_id", 
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
                changedRows =  ((IGuidv7ListuuidListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IGuidv7ListuuidListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IGuidv7ListuuidListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IGuidv7ListuuidListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guidv7uuidlistd1e2m(
	id,
    value,
    nullablevalue,
    guidv7uuidlistd1e2mi_id
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
    guidv7uuidlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Guidv7uuidListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7ListuuidListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guidv7uuidlistd1e2m(
	id,
    value,
    nullablevalue,
    guidv7uuidlistd1e2mi_id
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
    guidv7uuidlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Guidv7uuidListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7ListuuidListD1)),
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
                methodParametrName: "guidv7uuidlistd1e2mi_id", 
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
                List<Guidv7uuidListD1E2M> models = null;

                models =  ((IGuidv7ListuuidListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((IGuidv7ListuuidListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((IGuidv7ListuuidListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((IGuidv7ListuuidListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Guidv7uuidListD1E2M> models = null;

                models = await ((IGuidv7ListuuidListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((IGuidv7ListuuidListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((IGuidv7ListuuidListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((IGuidv7ListuuidListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((IGuidv7ListuuidListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((IGuidv7ListuuidListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((IGuidv7ListuuidListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((IGuidv7ListuuidListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((IGuidv7ListuuidListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidv7ListuuidListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidv7ListuuidListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidv7ListuuidListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((IGuidv7ListuuidListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((IGuidv7ListuuidListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((IGuidv7ListuuidListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((IGuidv7ListuuidListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((IGuidv7ListuuidListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((IGuidv7ListuuidListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((IGuidv7ListuuidListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((IGuidv7ListuuidListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((IGuidv7ListuuidListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((IGuidv7ListuuidListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((IGuidv7ListuuidListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((IGuidv7ListuuidListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((IGuidv7ListuuidListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((IGuidv7ListuuidListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((IGuidv7ListuuidListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuidv7uuidListD1E2M), typeof(FlatGuidv7uuidListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7ListuuidListD1)),
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
FROM public.guidv7uuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuidv7uuidListD1E2M>();
                var models2 = new List<FlatGuidv7uuidListD1E2M>();
                await ((IGuidv7ListuuidListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guidv7uuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuidv7uuidListD1E2M>();
                var models2 = new List<FlatGuidv7uuidListD1E2M>();
                ((IGuidv7ListuuidListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuidv7uuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7ListuuidListD1)),
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
FROM public.guidv7uuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IGuidv7ListuuidListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guidv7uuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidv7ListuuidListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guidv7uuidlistd1e2m m
LEFT JOIN public.guidv7uuidlistd1e2mi mi ON mi.id = m.guidv7uuidlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Guidv7uuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7ListuuidListD1)),
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
                var models = await ((IGuidv7ListuuidListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IGuidv7ListuuidListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuidv7uuidListD1E2M), typeof(FlatGuidv7uuidListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7ListuuidListD1)),
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
FROM public.guidv7uuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuidv7uuidListD1E2M>();
                var models2 = new List<FlatGuidv7uuidListD1E2M>();
                await ((IGuidv7ListuuidListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guidv7uuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuidv7uuidListD1E2M>();
                var models2 = new List<FlatGuidv7uuidListD1E2M>();
                ((IGuidv7ListuuidListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuidv7uuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7ListuuidListD1)),
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
FROM public.guidv7uuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidv7ListuuidListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guidv7uuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidv7ListuuidListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guidv7uuidlistd1e2m m
LEFT JOIN public.guidv7uuidlistd1e2mi mi ON mi.id = m.guidv7uuidlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Guidv7uuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7ListuuidListD1)),
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
                var models = await ((IGuidv7ListuuidListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IGuidv7ListuuidListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuidv7uuidListD1E2M), typeof(FlatGuidv7uuidListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7ListuuidListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7ListuuidListD1)),
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
            asPartInterface: typeof(IGuidv7ListuuidListD1)),
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
FROM public.guidv7uuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuidv7uuidListD1E2M>();
                var models2 = new List<FlatGuidv7uuidListD1E2M>();
                await((IGuidv7ListuuidListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 3;
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
FROM public.guidv7uuidlistd1e2m m
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
FROM public.guidv7uuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidListD1E2M>();
                var firstItems2 = new List<FlatGuidv7uuidListD1E2M>();
                var secondItems1 = new List<FlatGuidv7uuidListD1E2M>();
                var secondItems2 = new List<FlatGuidv7uuidListD1E2M>();
                await ((IGuidv7ListuuidListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
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
FROM public.guidv7uuidlistd1e2m m
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
FROM public.guidv7uuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidListD1E2M>();
                var firstItems2 = new List<FlatGuidv7uuidListD1E2M>();
                var secondItems1 = new List<FlatGuidv7uuidListD1E2M>();
                await ((IGuidv7ListuuidListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
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
FROM public.guidv7uuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuidv7uuidListD1E2M>();
                var models2 = new List<FlatGuidv7uuidListD1E2M>();
                ((IGuidv7ListuuidListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 27;
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
FROM public.guidv7uuidlistd1e2m m
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
FROM public.guidv7uuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidListD1E2M>();
                var firstItems2 = new List<FlatGuidv7uuidListD1E2M>();
                var secondItems1 = new List<FlatGuidv7uuidListD1E2M>();
                var secondItems2 = new List<FlatGuidv7uuidListD1E2M>();
                 ((IGuidv7ListuuidListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
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
FROM public.guidv7uuidlistd1e2m m
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
FROM public.guidv7uuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidListD1E2M>();
                var firstItems2 = new List<FlatGuidv7uuidListD1E2M>();
                var secondItems1 = new List<FlatGuidv7uuidListD1E2M>();
                 ((IGuidv7ListuuidListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuidv7uuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7ListuuidListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7ListuuidListD1)),
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
            asPartInterface: typeof(IGuidv7ListuuidListD1)),
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
FROM public.guidv7uuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IGuidv7ListuuidListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidlistd1e2m m
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
FROM public.guidv7uuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidv7ListuuidListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatGuidv7uuidListD1E2M.AssertModel(models[0],_testData[4], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[1],_testData[5], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[2],_testData[6], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[3],_testData[7], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[4],_testData[8], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[5],_testData[9], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[6],_testData[10], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[7],_testData[11], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[8],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[9],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[10],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[11],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[12],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[13],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[14],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[15],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[16],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[17],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[18],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[19],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[20],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[21],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[22],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[23],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[24],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[25],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[26],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[27],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[28],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[29],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatGuidv7uuidListD1E2M.AssertModel(models[0],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[1],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[2],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[3],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[4],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[5],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[6],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[7],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[8],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[9],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[10],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidlistd1e2m m
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
FROM public.guidv7uuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidListD1E2M>();
                var secondItems1 = new List<FlatGuidv7uuidListD1E2M>();
                var secondItems2 = new List<FlatGuidv7uuidListD1E2M>();
                await ((IGuidv7ListuuidListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.guidv7uuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IGuidv7ListuuidListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 150;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidlistd1e2m m
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
FROM public.guidv7uuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidv7ListuuidListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatGuidv7uuidListD1E2M.AssertModel(models[0],_testData[10], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[1],_testData[11], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[2],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[3],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[4],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[5],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[6],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[7],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[8],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[9],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[10],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[11],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[12],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[13],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[14],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[15],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[16],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[17],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[18],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[19],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[20],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[21],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[22],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[23],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatGuidv7uuidListD1E2M.AssertModel(models[0],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[1],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[2],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[3],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidlistd1e2m m
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
FROM public.guidv7uuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidListD1E2M>();
                var secondItems1 = new List<FlatGuidv7uuidListD1E2M>();
                var secondItems2 = new List<FlatGuidv7uuidListD1E2M>();
                 ((IGuidv7ListuuidListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.guidv7uuidlistd1e2m m
LEFT JOIN public.guidv7uuidlistd1e2mi mi ON mi.id = m.guidv7uuidlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Guidv7uuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7ListuuidListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7ListuuidListD1)),
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
                var models = await((IGuidv7ListuuidListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidv7ListuuidListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Guidv7uuidListD1E2M.AssertModel(models[0],_testData[8], false);
                        Guidv7uuidListD1E2M.AssertModel(models[1],_testData[9], false);
                        Guidv7uuidListD1E2M.AssertModel(models[2],_testData[10], false);
                        Guidv7uuidListD1E2M.AssertModel(models[3],_testData[11], false);
                        Guidv7uuidListD1E2M.AssertModel(models[4],_testData[12], false);
                        Guidv7uuidListD1E2M.AssertModel(models[5],_testData[13], false);
                        Guidv7uuidListD1E2M.AssertModel(models[6],_testData[14], false);
                        Guidv7uuidListD1E2M.AssertModel(models[7],_testData[15], false);
                        Guidv7uuidListD1E2M.AssertModel(models[8],_testData[16], false);
                        Guidv7uuidListD1E2M.AssertModel(models[9],_testData[17], false);
                        Guidv7uuidListD1E2M.AssertModel(models[10],_testData[18], false);
                        Guidv7uuidListD1E2M.AssertModel(models[11],_testData[19], false);
                        Guidv7uuidListD1E2M.AssertModel(models[12],_testData[20], false);
                        Guidv7uuidListD1E2M.AssertModel(models[13],_testData[21], false);
                        Guidv7uuidListD1E2M.AssertModel(models[14],_testData[22], false);
                        Guidv7uuidListD1E2M.AssertModel(models[15],_testData[23], false);
                        Guidv7uuidListD1E2M.AssertModel(models[16],_testData[24], false);
                        Guidv7uuidListD1E2M.AssertModel(models[17],_testData[25], false);
                        Guidv7uuidListD1E2M.AssertModel(models[18],_testData[26], false);
                        Guidv7uuidListD1E2M.AssertModel(models[19],_testData[27], false);
                        Guidv7uuidListD1E2M.AssertModel(models[20],_testData[28], false);
                        Guidv7uuidListD1E2M.AssertModel(models[21],_testData[29], false);
                        Guidv7uuidListD1E2M.AssertModel(models[22],_testData[30], false);
                        Guidv7uuidListD1E2M.AssertModel(models[23],_testData[31], false);
                        Guidv7uuidListD1E2M.AssertModel(models[24],_testData[32], false);
                        Guidv7uuidListD1E2M.AssertModel(models[25],_testData[33], false);
                        Guidv7uuidListD1E2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Guidv7uuidListD1E2M.AssertModel(models[0],_testData[7], false);
                        Guidv7uuidListD1E2M.AssertModel(models[1],_testData[8], false);
                        Guidv7uuidListD1E2M.AssertModel(models[2],_testData[9], false);
                        Guidv7uuidListD1E2M.AssertModel(models[3],_testData[10], false);
                        Guidv7uuidListD1E2M.AssertModel(models[4],_testData[11], false);
                        Guidv7uuidListD1E2M.AssertModel(models[5],_testData[12], false);
                        Guidv7uuidListD1E2M.AssertModel(models[6],_testData[13], false);
                        Guidv7uuidListD1E2M.AssertModel(models[7],_testData[14], false);
                        Guidv7uuidListD1E2M.AssertModel(models[8],_testData[15], false);
                        Guidv7uuidListD1E2M.AssertModel(models[9],_testData[16], false);
                        Guidv7uuidListD1E2M.AssertModel(models[10],_testData[17], false);
                        Guidv7uuidListD1E2M.AssertModel(models[11],_testData[18], false);
                        Guidv7uuidListD1E2M.AssertModel(models[12],_testData[19], false);
                        Guidv7uuidListD1E2M.AssertModel(models[13],_testData[20], false);
                        Guidv7uuidListD1E2M.AssertModel(models[14],_testData[21], false);
                        Guidv7uuidListD1E2M.AssertModel(models[15],_testData[22], false);
                        Guidv7uuidListD1E2M.AssertModel(models[16],_testData[23], false);
                        Guidv7uuidListD1E2M.AssertModel(models[17],_testData[24], false);
                        Guidv7uuidListD1E2M.AssertModel(models[18],_testData[25], false);
                        Guidv7uuidListD1E2M.AssertModel(models[19],_testData[26], false);
                        Guidv7uuidListD1E2M.AssertModel(models[20],_testData[27], false);
                        Guidv7uuidListD1E2M.AssertModel(models[21],_testData[28], false);
                        Guidv7uuidListD1E2M.AssertModel(models[22],_testData[29], false);
                        Guidv7uuidListD1E2M.AssertModel(models[23],_testData[30], false);
                        Guidv7uuidListD1E2M.AssertModel(models[24],_testData[31], false);
                        Guidv7uuidListD1E2M.AssertModel(models[25],_testData[32], false);
                        Guidv7uuidListD1E2M.AssertModel(models[26],_testData[33], false);
                        Guidv7uuidListD1E2M.AssertModel(models[27],_testData[34], false);
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
                var models = ((IGuidv7ListuuidListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidv7ListuuidListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Guidv7uuidListD1E2M.AssertModel(models[0],_testData[27], false);
                        Guidv7uuidListD1E2M.AssertModel(models[1],_testData[28], false);
                        Guidv7uuidListD1E2M.AssertModel(models[2],_testData[29], false);
                        Guidv7uuidListD1E2M.AssertModel(models[3],_testData[30], false);
                        Guidv7uuidListD1E2M.AssertModel(models[4],_testData[31], false);
                        Guidv7uuidListD1E2M.AssertModel(models[5],_testData[32], false);
                        Guidv7uuidListD1E2M.AssertModel(models[6],_testData[33], false);
                        Guidv7uuidListD1E2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        Guidv7uuidListD1E2M.AssertModel(models[0],_testData[2], false);
                        Guidv7uuidListD1E2M.AssertModel(models[1],_testData[3], false);
                        Guidv7uuidListD1E2M.AssertModel(models[2],_testData[4], false);
                        Guidv7uuidListD1E2M.AssertModel(models[3],_testData[5], false);
                        Guidv7uuidListD1E2M.AssertModel(models[4],_testData[6], false);
                        Guidv7uuidListD1E2M.AssertModel(models[5],_testData[7], false);
                        Guidv7uuidListD1E2M.AssertModel(models[6],_testData[8], false);
                        Guidv7uuidListD1E2M.AssertModel(models[7],_testData[9], false);
                        Guidv7uuidListD1E2M.AssertModel(models[8],_testData[10], false);
                        Guidv7uuidListD1E2M.AssertModel(models[9],_testData[11], false);
                        Guidv7uuidListD1E2M.AssertModel(models[10],_testData[12], false);
                        Guidv7uuidListD1E2M.AssertModel(models[11],_testData[13], false);
                        Guidv7uuidListD1E2M.AssertModel(models[12],_testData[14], false);
                        Guidv7uuidListD1E2M.AssertModel(models[13],_testData[15], false);
                        Guidv7uuidListD1E2M.AssertModel(models[14],_testData[16], false);
                        Guidv7uuidListD1E2M.AssertModel(models[15],_testData[17], false);
                        Guidv7uuidListD1E2M.AssertModel(models[16],_testData[18], false);
                        Guidv7uuidListD1E2M.AssertModel(models[17],_testData[19], false);
                        Guidv7uuidListD1E2M.AssertModel(models[18],_testData[20], false);
                        Guidv7uuidListD1E2M.AssertModel(models[19],_testData[21], false);
                        Guidv7uuidListD1E2M.AssertModel(models[20],_testData[22], false);
                        Guidv7uuidListD1E2M.AssertModel(models[21],_testData[23], false);
                        Guidv7uuidListD1E2M.AssertModel(models[22],_testData[24], false);
                        Guidv7uuidListD1E2M.AssertModel(models[23],_testData[25], false);
                        Guidv7uuidListD1E2M.AssertModel(models[24],_testData[26], false);
                        Guidv7uuidListD1E2M.AssertModel(models[25],_testData[27], false);
                        Guidv7uuidListD1E2M.AssertModel(models[26],_testData[28], false);
                        Guidv7uuidListD1E2M.AssertModel(models[27],_testData[29], false);
                        Guidv7uuidListD1E2M.AssertModel(models[28],_testData[30], false);
                        Guidv7uuidListD1E2M.AssertModel(models[29],_testData[31], false);
                        Guidv7uuidListD1E2M.AssertModel(models[30],_testData[32], false);
                        Guidv7uuidListD1E2M.AssertModel(models[31],_testData[33], false);
                        Guidv7uuidListD1E2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuidv7uuidListD1E2M), typeof(FlatGuidv7uuidListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7ListuuidListD1)),
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
            asPartInterface: typeof(IGuidv7ListuuidListD1)),
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
            asPartInterface: typeof(IGuidv7ListuuidListD1)),
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
FROM public.guidv7uuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuidv7uuidListD1E2M>();
                var models2 = new List<FlatGuidv7uuidListD1E2M>();
                await((IGuidv7ListuuidListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guidv7uuidlistd1e2m m
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
FROM public.guidv7uuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidListD1E2M>();
                var firstItems2 = new List<FlatGuidv7uuidListD1E2M>();
                var secondItems1 = new List<FlatGuidv7uuidListD1E2M>();
                var secondItems2 = new List<FlatGuidv7uuidListD1E2M>();
                await ((IGuidv7ListuuidListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 93, query1, 32, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.guidv7uuidlistd1e2m m
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
FROM public.guidv7uuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidListD1E2M>();
                var firstItems2 = new List<FlatGuidv7uuidListD1E2M>();
                var secondItems1 = new List<FlatGuidv7uuidListD1E2M>();
                await ((IGuidv7ListuuidListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 61, query1, 141, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
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
FROM public.guidv7uuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuidv7uuidListD1E2M>();
                var models2 = new List<FlatGuidv7uuidListD1E2M>();
                ((IGuidv7ListuuidListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guidv7uuidlistd1e2m m
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
FROM public.guidv7uuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidListD1E2M>();
                var firstItems2 = new List<FlatGuidv7uuidListD1E2M>();
                var secondItems1 = new List<FlatGuidv7uuidListD1E2M>();
                var secondItems2 = new List<FlatGuidv7uuidListD1E2M>();
                 ((IGuidv7ListuuidListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 159, query1, 115, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.guidv7uuidlistd1e2m m
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
FROM public.guidv7uuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidListD1E2M>();
                var firstItems2 = new List<FlatGuidv7uuidListD1E2M>();
                var secondItems1 = new List<FlatGuidv7uuidListD1E2M>();
                 ((IGuidv7ListuuidListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 160, query1, 160, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[2],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuidv7uuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7ListuuidListD1)),
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
            asPartInterface: typeof(IGuidv7ListuuidListD1)),
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
            asPartInterface: typeof(IGuidv7ListuuidListD1)),
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
FROM public.guidv7uuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidv7ListuuidListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guidv7uuidlistd1e2m m
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
FROM public.guidv7uuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidv7ListuuidListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 21, query1, 35, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatGuidv7uuidListD1E2M.AssertModel(models[0],_testData[4], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[1],_testData[5], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[2],_testData[6], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[3],_testData[7], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[4],_testData[8], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[5],_testData[9], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[6],_testData[10], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[7],_testData[11], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[8],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[9],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[10],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[11],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[12],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[13],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[14],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[15],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[16],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[17],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[18],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[19],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[20],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[21],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[22],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[23],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[24],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[25],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[26],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[27],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[28],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[29],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatGuidv7uuidListD1E2M.AssertModel(models[0],_testData[8], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[1],_testData[9], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[2],_testData[10], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[3],_testData[11], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[4],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[5],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[6],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[7],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[8],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[9],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[10],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[11],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[12],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[13],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[14],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[15],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[16],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[17],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[18],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[19],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[20],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[21],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[22],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[23],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[24],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[25],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[26],_testData[34], false);
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
FROM public.guidv7uuidlistd1e2m m
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
FROM public.guidv7uuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidListD1E2M>();
                var secondItems1 = new List<FlatGuidv7uuidListD1E2M>();
                var secondItems2 = new List<FlatGuidv7uuidListD1E2M>();
                await ((IGuidv7ListuuidListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 10, query1, 42, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.guidv7uuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidv7ListuuidListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guidv7uuidlistd1e2m m
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
FROM public.guidv7uuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidv7ListuuidListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 160, query1, 87, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatGuidv7uuidListD1E2M.AssertModel(models[0],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[1],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatGuidv7uuidListD1E2M.AssertModel(models[0],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[1],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[2],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[3],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[4],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[5],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[6],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[7],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[8],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[9],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[10],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[11],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[12],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[13],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[14],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[15],_testData[34], false);
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
FROM public.guidv7uuidlistd1e2m m
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
FROM public.guidv7uuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidListD1E2M>();
                var secondItems1 = new List<FlatGuidv7uuidListD1E2M>();
                var secondItems2 = new List<FlatGuidv7uuidListD1E2M>();
                 ((IGuidv7ListuuidListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 161, query1, 10, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.guidv7uuidlistd1e2m m
LEFT JOIN public.guidv7uuidlistd1e2mi mi ON mi.id = m.guidv7uuidlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Guidv7uuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7ListuuidListD1)),
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
            asPartInterface: typeof(IGuidv7ListuuidListD1)),
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
                var models = await((IGuidv7ListuuidListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidv7ListuuidListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 106, 160))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Guidv7uuidListD1E2M.AssertModel(models[0],_testData[23], false);
                        Guidv7uuidListD1E2M.AssertModel(models[1],_testData[24], false);
                        Guidv7uuidListD1E2M.AssertModel(models[2],_testData[25], false);
                        Guidv7uuidListD1E2M.AssertModel(models[3],_testData[26], false);
                        Guidv7uuidListD1E2M.AssertModel(models[4],_testData[27], false);
                        Guidv7uuidListD1E2M.AssertModel(models[5],_testData[28], false);
                        Guidv7uuidListD1E2M.AssertModel(models[6],_testData[29], false);
                        Guidv7uuidListD1E2M.AssertModel(models[7],_testData[30], false);
                        Guidv7uuidListD1E2M.AssertModel(models[8],_testData[31], false);
                        Guidv7uuidListD1E2M.AssertModel(models[9],_testData[32], false);
                        Guidv7uuidListD1E2M.AssertModel(models[10],_testData[33], false);
                        Guidv7uuidListD1E2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Guidv7uuidListD1E2M.AssertModel(models[0],_testData[32], false);
                        Guidv7uuidListD1E2M.AssertModel(models[1],_testData[33], false);
                        Guidv7uuidListD1E2M.AssertModel(models[2],_testData[34], false);
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
                var models = ((IGuidv7ListuuidListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidv7ListuuidListD1)this).DbConnectionSTSelectModelBatch(connection, 159, 74))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Guidv7uuidListD1E2M.AssertModel(models[0],_testData[31], false);
                        Guidv7uuidListD1E2M.AssertModel(models[1],_testData[32], false);
                        Guidv7uuidListD1E2M.AssertModel(models[2],_testData[33], false);
                        Guidv7uuidListD1E2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Guidv7uuidListD1E2M.AssertModel(models[0],_testData[16], false);
                        Guidv7uuidListD1E2M.AssertModel(models[1],_testData[17], false);
                        Guidv7uuidListD1E2M.AssertModel(models[2],_testData[18], false);
                        Guidv7uuidListD1E2M.AssertModel(models[3],_testData[19], false);
                        Guidv7uuidListD1E2M.AssertModel(models[4],_testData[20], false);
                        Guidv7uuidListD1E2M.AssertModel(models[5],_testData[21], false);
                        Guidv7uuidListD1E2M.AssertModel(models[6],_testData[22], false);
                        Guidv7uuidListD1E2M.AssertModel(models[7],_testData[23], false);
                        Guidv7uuidListD1E2M.AssertModel(models[8],_testData[24], false);
                        Guidv7uuidListD1E2M.AssertModel(models[9],_testData[25], false);
                        Guidv7uuidListD1E2M.AssertModel(models[10],_testData[26], false);
                        Guidv7uuidListD1E2M.AssertModel(models[11],_testData[27], false);
                        Guidv7uuidListD1E2M.AssertModel(models[12],_testData[28], false);
                        Guidv7uuidListD1E2M.AssertModel(models[13],_testData[29], false);
                        Guidv7uuidListD1E2M.AssertModel(models[14],_testData[30], false);
                        Guidv7uuidListD1E2M.AssertModel(models[15],_testData[31], false);
                        Guidv7uuidListD1E2M.AssertModel(models[16],_testData[32], false);
                        Guidv7uuidListD1E2M.AssertModel(models[17],_testData[33], false);
                        Guidv7uuidListD1E2M.AssertModel(models[18],_testData[34], false);
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
                await using var cmd = await ((IGuidv7ListuuidListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidv7ListuuidListD1)this).SetDbConnectionSelectModelParametrs(cmd, 87);
                var models = await ((IGuidv7ListuuidListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(16));

                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[19], false);
                Guidv7uuidListD1E2M.AssertModel(models[1],_testData[20], false);
                Guidv7uuidListD1E2M.AssertModel(models[2],_testData[21], false);
                Guidv7uuidListD1E2M.AssertModel(models[3],_testData[22], false);
                Guidv7uuidListD1E2M.AssertModel(models[4],_testData[23], false);
                Guidv7uuidListD1E2M.AssertModel(models[5],_testData[24], false);
                Guidv7uuidListD1E2M.AssertModel(models[6],_testData[25], false);
                Guidv7uuidListD1E2M.AssertModel(models[7],_testData[26], false);
                Guidv7uuidListD1E2M.AssertModel(models[8],_testData[27], false);
                Guidv7uuidListD1E2M.AssertModel(models[9],_testData[28], false);
                Guidv7uuidListD1E2M.AssertModel(models[10],_testData[29], false);
                Guidv7uuidListD1E2M.AssertModel(models[11],_testData[30], false);
                Guidv7uuidListD1E2M.AssertModel(models[12],_testData[31], false);
                Guidv7uuidListD1E2M.AssertModel(models[13],_testData[32], false);
                Guidv7uuidListD1E2M.AssertModel(models[14],_testData[33], false);
                Guidv7uuidListD1E2M.AssertModel(models[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidv7ListuuidListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidv7ListuuidListD1)this).SetDbConnectionSelectModelParametrs(cmd, 77);
                var models =  ((IGuidv7ListuuidListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));

                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[17], false);
                Guidv7uuidListD1E2M.AssertModel(models[1],_testData[18], false);
                Guidv7uuidListD1E2M.AssertModel(models[2],_testData[19], false);
                Guidv7uuidListD1E2M.AssertModel(models[3],_testData[20], false);
                Guidv7uuidListD1E2M.AssertModel(models[4],_testData[21], false);
                Guidv7uuidListD1E2M.AssertModel(models[5],_testData[22], false);
                Guidv7uuidListD1E2M.AssertModel(models[6],_testData[23], false);
                Guidv7uuidListD1E2M.AssertModel(models[7],_testData[24], false);
                Guidv7uuidListD1E2M.AssertModel(models[8],_testData[25], false);
                Guidv7uuidListD1E2M.AssertModel(models[9],_testData[26], false);
                Guidv7uuidListD1E2M.AssertModel(models[10],_testData[27], false);
                Guidv7uuidListD1E2M.AssertModel(models[11],_testData[28], false);
                Guidv7uuidListD1E2M.AssertModel(models[12],_testData[29], false);
                Guidv7uuidListD1E2M.AssertModel(models[13],_testData[30], false);
                Guidv7uuidListD1E2M.AssertModel(models[14],_testData[31], false);
                Guidv7uuidListD1E2M.AssertModel(models[15],_testData[32], false);
                Guidv7uuidListD1E2M.AssertModel(models[16],_testData[33], false);
                Guidv7uuidListD1E2M.AssertModel(models[17],_testData[34], false);
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
FROM public.binary_guidv7uuidlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Guidv7uuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7ListuuidListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Guidv7uuidListD1E2MIWA),
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
            asPartInterface: typeof(IGuidv7ListuuidListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Guidv7uuidListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guidv7uuidListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidv7ListuuidListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guidv7uuidlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidv7ListuuidListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Guidv7uuidListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guidv7uuidListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidv7ListuuidListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_guidv7uuidlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidv7ListuuidListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guidv7uuidlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Guidv7uuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7ListuuidListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Guidv7uuidListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7ListuuidListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Guidv7uuidListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guidv7uuidListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidv7ListuuidListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guidv7uuidlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidv7ListuuidListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Guidv7uuidListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guidv7uuidListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidv7ListuuidListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guidv7uuidlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidv7ListuuidListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guidv7uuidlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Guidv7uuidListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7ListuuidListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guidv7uuidlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Guidv7uuidListD1E2MI),
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
            asPartInterface: typeof(IGuidv7ListuuidListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Guidv7uuidListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidv7ListuuidListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidv7ListuuidListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Guidv7uuidListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidv7ListuuidListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IGuidv7ListuuidListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_guidv7uuidlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Guidv7uuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7ListuuidListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guidv7uuidlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Guidv7uuidListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7ListuuidListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Guidv7uuidListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guidv7uuidListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidv7ListuuidListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidv7ListuuidListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Guidv7uuidListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guidv7uuidListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidv7ListuuidListD1)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidv7ListuuidListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guidv7uuidlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
guidv7uuidlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Guidv7uuidListD1E2M),
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
            asPartInterface: typeof(IGuidv7ListuuidListD1))]
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
FROM public.binary_guidv7uuidlistd1e2m m
LEFT JOIN public.binary_guidv7uuidlistd1e2mi mi ON mi.id = m.guidv7uuidlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Guidv7uuidListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7ListuuidListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Guidv7uuidListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IGuidv7ListuuidListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IGuidv7ListuuidListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Guidv7uuidListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Guidv7uuidListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IGuidv7ListuuidListD1)this).ImportModel(connection, importCollection);
                var models = ((IGuidv7ListuuidListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Guidv7uuidListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guidv7uuidlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    guidv7uuidlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Guidv7uuidListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7ListuuidListD1)),
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
                var models =  ((IGuidv7ListuuidListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Guidv7uuidListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidv7ListuuidListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Guidv7uuidListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidListD1E2MIWA), typeof(Guidv7uuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7ListuuidListD1)),
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
                var models1 = new List<Guidv7uuidListD1E2MIWA>();
                var models2 = new List<Guidv7uuidListD1E2MIWA>();
                await ((IGuidv7ListuuidListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guidv7uuidlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Guidv7uuidListD1E2MIWA>();
                var models2 = new List<Guidv7uuidListD1E2MIWA>();
                ((IGuidv7ListuuidListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guidv7uuidlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7ListuuidListD1)),
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
                var models = await ((IGuidv7ListuuidListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_guidv7uuidlistd1e2mi
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
                    Guidv7uuidListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidv7ListuuidListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_guidv7uuidlistd1e2mi
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
                    Guidv7uuidListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidListD1E2MIWA), typeof(Guidv7uuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7ListuuidListD1))]
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
                var models1 = new List<Guidv7uuidListD1E2MIWA>();
                var models2 = new List<Guidv7uuidListD1E2MIWA>();
                await ((IGuidv7ListuuidListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guidv7uuidlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Guidv7uuidListD1E2MIWA>();
                var models2 = new List<Guidv7uuidListD1E2MIWA>();
                ((IGuidv7ListuuidListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guidv7uuidlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7ListuuidListD1))]
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
                var models = await ((IGuidv7ListuuidListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_guidv7uuidlistd1e2mi
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
                    Guidv7uuidListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidv7ListuuidListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_guidv7uuidlistd1e2mi
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
                    Guidv7uuidListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guidv7uuidlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidListD1E2MI), typeof(Guidv7uuidListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7ListuuidListD1)),
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
                var models1 = new List<Guidv7uuidListD1E2MI>();
                var models2 = new List<Guidv7uuidListD1E2MI>();
                await ((IGuidv7ListuuidListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Guidv7uuidListD1E2MI>();
                var models2 = new List<Guidv7uuidListD1E2MI>();
                ((IGuidv7ListuuidListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guidv7uuidlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7ListuuidListD1)),
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
                var models = await ((IGuidv7ListuuidListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Guidv7uuidListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidv7ListuuidListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Guidv7uuidListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guidv7uuidlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidListD1E2MIWA), typeof(Guidv7uuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7ListuuidListD1))]
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
                var models1 = new List<Guidv7uuidListD1E2MIWA>();
                var models2 = new List<Guidv7uuidListD1E2MIWA>();
                await ((IGuidv7ListuuidListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Guidv7uuidListD1E2MIWA>();
                var models2 = new List<Guidv7uuidListD1E2MIWA>();
                ((IGuidv7ListuuidListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guidv7uuidlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7ListuuidListD1))]
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
                var models = await ((IGuidv7ListuuidListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Guidv7uuidListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidv7ListuuidListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Guidv7uuidListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

