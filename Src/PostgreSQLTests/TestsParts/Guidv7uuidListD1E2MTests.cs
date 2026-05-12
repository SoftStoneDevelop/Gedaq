

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

        private readonly Guidv7uuidListD1E2M[] _testData = new Guidv7uuidListD1E2M[]
        {
            new Guidv7uuidListD1E2M
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-7da5-b30a-63d6cc7f4f05"),

Guid.Parse("019e1b45-9267-7616-8d46-4dc3201d8c63"),

Guid.Parse("019e1b45-9267-7768-890e-a3665f4d5ca8"),

Guid.Parse("019e1b45-9267-7820-b309-c1f9d38ce2d5"),

},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-7b47-86c7-4287e1a3262b"),

Guid.Parse("019e1b45-9267-71e2-9d10-2d63f32e207d"),

Guid.Parse("019e1b45-9267-74db-93f3-57b34312e6bb"),

Guid.Parse("019e1b45-9267-7dda-90b4-0c4cc096e646"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b45-9267-73a6-a9fc-f26ff9e7dab5"),

Guid.Parse("019e1b45-9267-7d42-ad0a-10893d0a041d"),

Guid.Parse("019e1b45-9267-749d-b783-fa3482c874d7"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-7168-b6c7-4e2e2e4f273b"),

Guid.Parse("019e1b45-9267-724c-ac44-e8013c3ca05c"),

Guid.Parse("019e1b45-9267-7b3f-bc80-d7330ed56e1c"),

Guid.Parse("019e1b45-9267-7edd-a533-1134df07ceb8"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-770e-b262-5c3e295e268e"),

Guid.Parse("019e1b45-9267-774b-9240-315a3f540544"),

Guid.Parse("019e1b45-9267-7610-a22d-a43f8080399b"),

Guid.Parse("019e1b45-9267-7467-9f7d-f39402bd7ec7"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b45-9267-7cec-8c94-60d6dba85f32"),

Guid.Parse("019e1b45-9267-7866-baa3-a09df2c66fa6"),

Guid.Parse("019e1b45-9267-7fd6-b9ea-75a9f2e262ef"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-7da7-9c0d-5926eb96dc67"),

Guid.Parse("019e1b45-9267-73de-855e-36ae6fabbed9"),

Guid.Parse("019e1b45-9267-7ab9-9198-e93f15f526c3"),

Guid.Parse("019e1b45-9267-75f4-99de-712f236ecf98"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-76e0-bc49-4d3f716bbb8a"),

Guid.Parse("019e1b45-9267-7658-b196-be4baa077e52"),

Guid.Parse("019e1b45-9267-78fe-bceb-f08edb7ba017"),

Guid.Parse("019e1b45-9267-710c-bfc4-1a497362b426"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b45-9267-7ea6-b61b-c38aaa48bff7"),

Guid.Parse("019e1b45-9267-7954-a989-71e97c77bf6d"),

Guid.Parse("019e1b45-9267-783d-af59-36cd2d8a440d"),

},
},
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-76ac-a088-175378eea7fc"),

Guid.Parse("019e1b45-9267-78df-884d-ae6b5527396d"),

Guid.Parse("019e1b45-9267-77de-a9ee-33d82dcefe56"),

Guid.Parse("019e1b45-9267-7e8d-a49d-502279491143"),

},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-7568-83be-fb1eb2d47cac"),

Guid.Parse("019e1b45-9267-7949-8709-cf0eba5bc7f0"),

Guid.Parse("019e1b45-9267-74e2-816b-a2906944d975"),

Guid.Parse("019e1b45-9267-7278-ad61-74a3783e6c0a"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-7487-b72e-9a9dca3e06a3"),

Guid.Parse("019e1b45-9267-7850-995b-763b68ebd6c5"),

Guid.Parse("019e1b45-9267-7c05-b01c-243bab3d3676"),

Guid.Parse("019e1b45-9267-72d7-808f-1d965c95ce0f"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-7756-b98f-87d7b83d5f4e"),

Guid.Parse("019e1b45-9267-7178-9fe9-3113c8095eaf"),

Guid.Parse("019e1b45-9267-7b14-8c71-8e52ec56775e"),

Guid.Parse("019e1b45-9267-77b7-a566-7c4a576afbc5"),

},
},
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-781e-9fde-dad8bb2bd22e"),

Guid.Parse("019e1b45-9267-78bb-910c-8220dd4c1dfe"),

Guid.Parse("019e1b45-9267-72db-810b-890921c2cb98"),

Guid.Parse("019e1b45-9267-7ea5-917d-a52ae84e64be"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-786f-9f61-7bb7e1376ddd"),

Guid.Parse("019e1b45-9267-7fcc-b1c3-e96ff590e2fd"),

Guid.Parse("019e1b45-9267-7053-ae9d-01b6e4b8054b"),

Guid.Parse("019e1b45-9267-7ba6-ad8d-2b51ecdd2b52"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-7301-9f60-14d2e1820990"),

Guid.Parse("019e1b45-9267-73ed-a03c-410ded27ce14"),

Guid.Parse("019e1b45-9267-77bd-a5bf-c9f19b937818"),

Guid.Parse("019e1b45-9267-7bea-995b-86790c4b1493"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-7312-83c6-e7ea6fd80da6"),

Guid.Parse("019e1b45-9267-7033-ada3-8a633128ef68"),

Guid.Parse("019e1b45-9267-78d6-908d-ee324006bd11"),

Guid.Parse("019e1b45-9267-7c9e-9b68-1cdb8501a286"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-7f59-99af-8dc5c88dead2"),

Guid.Parse("019e1b45-9267-79f9-9221-10fe3c65340b"),

Guid.Parse("019e1b45-9267-7e20-b248-7fad290b57c4"),

Guid.Parse("019e1b45-9267-71cc-b777-1d36b63ada9b"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b45-9267-7ab4-91e1-dcd5165cbabf"),

Guid.Parse("019e1b45-9267-7080-9f03-a09de7d32b0b"),

Guid.Parse("019e1b45-9267-700e-97ee-9b6f2d13cd5b"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-798e-8008-07ad37a53074"),

Guid.Parse("019e1b45-9267-7623-8d75-338424569231"),

Guid.Parse("019e1b45-9267-715b-9dfa-8bd05b324b48"),

Guid.Parse("019e1b45-9267-7265-b92b-c886f05c7900"),

},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-7a02-ae85-a8fc54981063"),

Guid.Parse("019e1b45-9267-7fe0-8cfd-a5beffcc938d"),

Guid.Parse("019e1b45-9267-79a9-a304-a4f63bf08b6a"),

Guid.Parse("019e1b45-9267-781d-a57b-9e50459e675e"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-7129-8bf3-cfeaae4a84f6"),

Guid.Parse("019e1b45-9267-7c67-b753-70c635be3f50"),

Guid.Parse("019e1b45-9267-7329-9e5b-ce0f8eab0e11"),

Guid.Parse("019e1b45-9267-7e2a-90ba-788c638e7c49"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b45-9267-79aa-b6d6-8d9db6323f44"),

Guid.Parse("019e1b45-9267-75a9-ba6a-eb7db2e04694"),

Guid.Parse("019e1b45-9267-7b06-b903-9205e97105df"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b45-9267-791b-9be4-0f0bf82fe5d1"),

Guid.Parse("019e1b45-9267-7549-a53b-407a4cd881ff"),

Guid.Parse("019e1b45-9267-76eb-8693-136e8baeea49"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-7f83-a052-9ae711ad36d1"),

Guid.Parse("019e1b45-9267-7af7-aed5-8402c002da4d"),

Guid.Parse("019e1b45-9267-71ca-9043-214ac44f7f03"),

Guid.Parse("019e1b45-9267-7e84-8237-6cc770be7d97"),

},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-7fc7-8da7-a1bb3a21b258"),

Guid.Parse("019e1b45-9267-7a14-be5e-12ebd0dd5fc6"),

Guid.Parse("019e1b45-9267-711d-86d6-1e92daa21f9e"),

Guid.Parse("019e1b45-9267-7b3d-9f6b-9ef3589ac9d4"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-7647-8713-9dd9e84807dc"),

Guid.Parse("019e1b45-9267-754e-bad4-cde077ad6b30"),

Guid.Parse("019e1b45-9267-7737-95b9-047084238eba"),

Guid.Parse("019e1b45-9267-7111-8eef-a8f0a3db0584"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b45-9267-713a-92df-98a2d92d1976"),

Guid.Parse("019e1b45-9267-7f4f-8857-dc47c1b7d215"),

Guid.Parse("019e1b45-9267-78e6-b6f3-7a9785a22403"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b45-9267-7d09-8dc2-5f04e4c84402"),

Guid.Parse("019e1b45-9267-7afd-8c33-e5f640792544"),

Guid.Parse("019e1b45-9267-7153-8e60-eded1d9ec8f6"),

},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-7ff4-a2a5-2732dfb95820"),

Guid.Parse("019e1b45-9267-74ee-98df-5f79b455ecaf"),

Guid.Parse("019e1b45-9267-7cf1-8337-1ca7a1c31e1f"),

Guid.Parse("019e1b45-9267-7fe5-b5d7-b2c0267388e0"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b45-9267-7c00-8763-fe6f1bb6b7e0"),

Guid.Parse("019e1b45-9267-7f9c-8fd3-32ae8290e0d2"),

Guid.Parse("019e1b45-9267-7bf1-9b95-5a971be07bf5"),

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
Guid.Parse("019e1b45-9267-7fa6-a5dd-06acf09f39b2"),

Guid.Parse("019e1b45-9267-727b-a08a-64f7f95da385"),

Guid.Parse("019e1b45-9267-7e3b-9bcc-af7fa07d34da"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b45-9267-7c62-9e4e-003fb2b698d1"),

Guid.Parse("019e1b45-9267-72e7-827b-543f00e2df0b"),

Guid.Parse("019e1b45-9267-7404-8f2e-031c5fbf7ec7"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b45-9267-7d1f-8564-521b9f93c76c"),

Guid.Parse("019e1b45-9267-7506-9a5e-83736d593345"),

Guid.Parse("019e1b45-9267-7594-ba29-205ce5248ca5"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-73b0-a50c-6912c23bf0c9"),

Guid.Parse("019e1b45-9267-7719-91ec-6b1891207145"),

Guid.Parse("019e1b45-9267-7bc7-986a-3eec1cbe1bdb"),

Guid.Parse("019e1b45-9267-7fe6-9476-e065f33cd43e"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-71ca-9319-1ab3d9bcd6fd"),

Guid.Parse("019e1b45-9267-714e-87da-acffa7e3ab99"),

Guid.Parse("019e1b45-9267-7e3f-b4d8-255ced3ed82a"),

Guid.Parse("019e1b45-9267-79d6-86d3-db616d68da5b"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-7b15-aca4-2db96a364e58"),

Guid.Parse("019e1b45-9267-75c0-9bc3-5de4ab1d876d"),

Guid.Parse("019e1b45-9267-70e5-913d-b2558dc3716f"),

Guid.Parse("019e1b45-9267-7b66-9bb1-06cbc033df38"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b45-9267-7c7c-8220-86eb25f8a753"),

Guid.Parse("019e1b45-9267-7c74-a067-300e0f970db6"),

Guid.Parse("019e1b45-9267-7236-9c43-662374a75c61"),

},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-7d87-9771-797c9385007a"),

Guid.Parse("019e1b45-9267-7579-b33c-65beb2b1c5dd"),

Guid.Parse("019e1b45-9267-7c61-ad65-3d08def62016"),

Guid.Parse("019e1b45-9267-7f84-bb9c-b40463ce49cd"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b45-9267-7af6-8f55-06d2161e2685"),

Guid.Parse("019e1b45-9267-7aec-b759-427bdc3a0b79"),

Guid.Parse("019e1b45-9267-7a87-aee2-b0968bc3d621"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-76f3-b195-7925f690fc1f"),

Guid.Parse("019e1b45-9267-7cd9-aa41-a70fca90b931"),

Guid.Parse("019e1b45-9267-7299-b737-72bd0ecc4554"),

Guid.Parse("019e1b45-9267-78e0-8ac5-e0dbb73682c0"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-7fa7-91e2-a25d0e8754a8"),

Guid.Parse("019e1b45-9267-764b-99d7-81370e1c7633"),

Guid.Parse("019e1b45-9267-7579-a296-b5db994c6b4a"),

Guid.Parse("019e1b45-9267-7cf4-b805-b05241f3cb28"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-76d8-98a3-514830d82ada"),

Guid.Parse("019e1b45-9267-79a8-8c34-b416d38c8f53"),

Guid.Parse("019e1b45-9267-7c38-bdbf-678c03d53f3d"),

Guid.Parse("019e1b45-9267-719f-a8fa-425578fc89f4"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b45-9267-70ee-b324-d142a1a32f95"),

Guid.Parse("019e1b45-9267-721b-8cfe-0dee612db3fa"),

Guid.Parse("019e1b45-9267-7257-8ec3-6aa3f2bafa23"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b45-9267-7568-a83f-5f7d6c167b51"),

Guid.Parse("019e1b45-9267-7d31-be8b-86e1bec37ba5"),

Guid.Parse("019e1b45-9267-7e56-b795-99647e21f774"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b45-9267-7c21-a04f-93431470d23d"),

Guid.Parse("019e1b45-9267-7377-987e-f287ce022464"),

Guid.Parse("019e1b45-9267-70b2-9b48-89264a65df97"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-7568-88d4-48268bda7107"),

Guid.Parse("019e1b45-9267-7b3f-b4ab-795e5c67dcf1"),

Guid.Parse("019e1b45-9267-7c76-b543-3e2b5352d308"),

Guid.Parse("019e1b45-9267-7459-af3b-12fa8c4a2009"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b45-9267-7cec-b90d-0806e7d40185"),

Guid.Parse("019e1b45-9267-71e0-8aae-c873355ae3bc"),

Guid.Parse("019e1b45-9267-7335-ad30-dc3589543657"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b45-9267-7b7d-996f-16dfe945b334"),

Guid.Parse("019e1b45-9267-7ff6-abf7-8c8bb695f4ba"),

Guid.Parse("019e1b45-9267-7ac9-9c6c-a5bab82fc531"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-7237-8ead-87e5838fbe81"),

Guid.Parse("019e1b45-9267-7487-9d09-23283cec7e89"),

Guid.Parse("019e1b45-9267-7c2f-ae26-547158a1cf08"),

Guid.Parse("019e1b45-9267-782e-9db9-c6ecc1e4532d"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-7da7-b2f8-3f81b9235212"),

Guid.Parse("019e1b45-9267-7a6d-99fc-db1c13fa5a67"),

Guid.Parse("019e1b45-9267-7e88-8958-c7163ba1b749"),

Guid.Parse("019e1b45-9267-7b1d-9dc4-be17fa887530"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-78bf-95be-b2da3231a5b1"),

Guid.Parse("019e1b45-9267-71e5-92c1-5e5509166fc0"),

Guid.Parse("019e1b45-9267-7683-941c-53c3df408221"),

Guid.Parse("019e1b45-9267-7c02-80fe-082cf137756f"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b45-9267-779b-9ec7-d4d0c09c7f1f"),

Guid.Parse("019e1b45-9267-725f-8e05-6ae784665f29"),

Guid.Parse("019e1b45-9267-751b-8214-2a9638afe0c5"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b45-9267-77b5-9c4a-b7767327c0f8"),

Guid.Parse("019e1b45-9267-7fbf-8df5-1af1a56769f7"),

Guid.Parse("019e1b45-9267-789f-82fd-b9f32ef63770"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-7738-944a-5e4b6a345473"),

Guid.Parse("019e1b45-9267-7bc5-806e-8d887977176d"),

Guid.Parse("019e1b45-9267-7d3a-93f7-65543098cd26"),

Guid.Parse("019e1b45-9267-73e2-bb6a-7480a246e24b"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b45-9267-72ae-982e-2ba17b700bb5"),

Guid.Parse("019e1b45-9267-7213-a742-92f02d8f6995"),

Guid.Parse("019e1b45-9267-75a7-a290-466303599fa7"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b45-9267-7dc2-acf3-eb3a2e8c975b"),

Guid.Parse("019e1b45-9267-7f4c-b1d4-d02ab75f5f84"),

Guid.Parse("019e1b45-9267-700b-ba6b-5c9d731b3753"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-706c-82cf-356f9e34523c"),

Guid.Parse("019e1b45-9267-7a52-9677-da6aaef285f4"),

Guid.Parse("019e1b45-9267-79bb-8819-36f87ce12f19"),

Guid.Parse("019e1b45-9267-7964-9230-420848d06c1a"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-7661-82ad-67efc2e7e7e4"),

Guid.Parse("019e1b45-9267-74fe-b6e5-eb03e8e6e5a4"),

Guid.Parse("019e1b45-9267-7ef7-816a-09720320d06f"),

Guid.Parse("019e1b45-9267-738e-814b-8362ad680c74"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-788c-baf7-71ab78b3f3a1"),

Guid.Parse("019e1b45-9267-790f-9d92-518a88ac02c2"),

Guid.Parse("019e1b45-9267-7131-b6c4-061d7800f7a9"),

Guid.Parse("019e1b45-9267-7cff-880d-557260ff461a"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b45-9267-7136-b092-68ab4de82182"),

Guid.Parse("019e1b45-9267-7582-a3a6-7f77b5be7bb2"),

Guid.Parse("019e1b45-9267-740f-8d32-0194afa642ad"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-76b2-8155-eabc06e2d033"),

Guid.Parse("019e1b45-9267-76cd-acb0-4525eb4be981"),

Guid.Parse("019e1b45-9267-7266-91ab-653841493242"),

Guid.Parse("019e1b45-9267-7bb7-853e-71dd93a1a972"),

},
},
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b45-9267-7414-8930-194768472caa"),

Guid.Parse("019e1b45-9267-7056-9070-02fd40f9f37f"),

Guid.Parse("019e1b45-9267-7ddc-a85f-26836ece6c36"),

},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-79a1-b63d-e0213c6b8abe"),

Guid.Parse("019e1b45-9267-7aff-8b9c-66c35c6ca83e"),

Guid.Parse("019e1b45-9267-73e3-bd11-2a77707a7e58"),

Guid.Parse("019e1b45-9267-760b-8cb1-9099b8285fe2"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b45-9267-7e8f-ab47-7a3347d0adb9"),

Guid.Parse("019e1b45-9267-753f-b1d0-7594b87c21b9"),

Guid.Parse("019e1b45-9267-72eb-a38b-c553044b4b02"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b45-9267-7750-81e7-dd58a935f349"),

Guid.Parse("019e1b45-9267-7b41-895c-e4ed758c89d3"),

Guid.Parse("019e1b45-9267-750c-851b-085cc969f6a8"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-7dae-a8f6-9378e319e256"),

Guid.Parse("019e1b45-9267-79be-87e8-85eb99276e21"),

Guid.Parse("019e1b45-9267-736b-bc54-fe523550d9cf"),

Guid.Parse("019e1b45-9267-79aa-ac78-ab43e100347a"),

},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-77e3-8c21-f91a842c9883"),

Guid.Parse("019e1b45-9267-7ad6-befc-f7447139d2d4"),

Guid.Parse("019e1b45-9267-7a71-9862-450d12811912"),

Guid.Parse("019e1b45-9267-7486-bc80-95bf9fcfb26b"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-7ea8-887b-e59a18a5580d"),

Guid.Parse("019e1b45-9267-7709-af2f-0bba4970622e"),

Guid.Parse("019e1b45-9267-7d01-a347-c1d511167740"),

Guid.Parse("019e1b45-9267-78ae-9436-75880de0628c"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-7c56-a8be-a5471f58fd54"),

Guid.Parse("019e1b45-9267-7624-9dfd-b2f0699b1263"),

Guid.Parse("019e1b45-9267-7901-a756-d71e1d4a53c2"),

Guid.Parse("019e1b45-9267-7778-9f09-bf9f4c127719"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-7e60-b14f-47152eb22277"),

Guid.Parse("019e1b45-9267-7796-a582-ef179472ab28"),

Guid.Parse("019e1b45-9267-7cc8-b696-53ab4a4a7b8c"),

Guid.Parse("019e1b45-9267-70b7-ae3b-78eb81b7020b"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-79fe-bcf7-ccbfd5b392d0"),

Guid.Parse("019e1b45-9267-7ae6-9375-2822f5730c1a"),

Guid.Parse("019e1b45-9267-7036-a9a5-6ac7a46475eb"),

Guid.Parse("019e1b45-9267-7f45-88b7-80638aad8630"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-745f-aedb-02eacef073e0"),

Guid.Parse("019e1b45-9267-7b5b-8475-5999bc338c8d"),

Guid.Parse("019e1b45-9267-765b-8be2-680d263e5ba0"),

Guid.Parse("019e1b45-9267-789e-9d1b-14e61c9ada9b"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b45-9267-792f-9ed4-fae1e439f77b"),

Guid.Parse("019e1b45-9267-79c5-a991-54386c9db97b"),

Guid.Parse("019e1b45-9267-701e-88c9-7a73ab6252f8"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b45-9267-721a-9d63-f8a2464a2f1d"),

Guid.Parse("019e1b45-9267-7cf2-bfd3-0a87adc486c2"),

Guid.Parse("019e1b45-9267-7d4b-b494-7e7a7ced193f"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b45-9267-739b-b579-efbba5caa54e"),

Guid.Parse("019e1b45-9267-7852-b563-5d0a8492ecf4"),

Guid.Parse("019e1b45-9267-77fe-873d-0b252b7a590f"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b45-9267-732f-bf6d-309187c1da0f"),

Guid.Parse("019e1b45-9267-7016-885b-1f7e95978c2f"),

Guid.Parse("019e1b45-9267-747e-a50b-8eb4e5439f97"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-7487-93c1-f62b0d8c91d7"),

Guid.Parse("019e1b45-9267-71c2-923e-434843b283ad"),

Guid.Parse("019e1b45-9267-7fa9-9d3f-63ae06aa47aa"),

Guid.Parse("019e1b45-9267-75e7-b665-0fb1ae3da6d0"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-7e79-bda4-f17dbf3b726a"),

Guid.Parse("019e1b45-9267-7499-bfa3-2de054438fca"),

Guid.Parse("019e1b45-9267-7654-9616-0ad524eb670b"),

Guid.Parse("019e1b45-9267-7794-94d5-d2e087ae3b59"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-743e-9ca3-87ee74277639"),

Guid.Parse("019e1b45-9267-756b-9759-db31558f5829"),

Guid.Parse("019e1b45-9267-79ac-ab5e-cec2b0b0f8ff"),

Guid.Parse("019e1b45-9267-7ab7-b11f-7edba90676cc"),

},
},
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b45-9267-7c85-a569-b4d76b8b8619"),

Guid.Parse("019e1b45-9267-7b33-ad04-6b4752c0ed0b"),

Guid.Parse("019e1b45-9267-7665-b2a0-a1ee9f8d40ce"),

Guid.Parse("019e1b45-9267-70ad-9df0-f7bfe5809982"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b45-9267-7f90-9633-d4de9f04d2d5"),

Guid.Parse("019e1b45-9267-7eec-9693-7cc485c2a43b"),

Guid.Parse("019e1b45-9267-7d11-8c27-bbf9ac5f3a37"),

},
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
INSERT INTO public.guidv7uuidlistd1e2m(
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
INSERT INTO public.guidv7uuidlistd1e2m(
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
            queryMapTypes: [typeof(Guidv7uuidListD1E2M)],
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
INSERT INTO public.guidv7uuidlistd1e2m(
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
            queryMapTypes: [typeof(Guidv7uuidListD1E2M)],
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
                List<Guidv7uuidListD1E2M> models = null;

                models =  ((IGuidListuuidListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((IGuidListuuidListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((IGuidListuuidListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((IGuidListuuidListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
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

                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
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
                await ((IGuidListuuidListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
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
                ((IGuidListuuidListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
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
FROM public.guidv7uuidlistd1e2m m
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
                var models = ((IGuidListuuidListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
LEFT JOIN public.guiduuidlistd1e2mi mi ON mi.id = m.guiduuidlistd1e2mi_id
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
                var models = ((IGuidListuuidListD1)this).SelectModelDynPar(connection, [parametr1]);
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
FROM public.guidv7uuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuidv7uuidListD1E2M>();
                var models2 = new List<FlatGuidv7uuidListD1E2M>();
                await ((IGuidListuuidListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
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
                ((IGuidListuuidListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
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
FROM public.guidv7uuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidListuuidListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
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
                var models = ((IGuidListuuidListD1)this).DynQuerySelectModel(connection,  query, 0);
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
LEFT JOIN public.guiduuidlistd1e2mi mi ON mi.id = m.guiduuidlistd1e2mi_id
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
                var models = ((IGuidListuuidListD1)this).SelectModel(connection, 0);
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
                await((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
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
                await ((IGuidListuuidListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
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
                await ((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
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
                ((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
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
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
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
                 ((IGuidListuuidListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
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
                 ((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
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
                var models = await((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
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
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
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
                foreach(var batchResult in await ((IGuidListuuidListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatGuidv7uuidListD1E2M.AssertModel(models[0],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[1],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[2],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[3],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[4],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[5],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatGuidv7uuidListD1E2M.AssertModel(models[0],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[1],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[2],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[3],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[4],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[5],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[6],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[7],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[8],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[9],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[10],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[11],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[12],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[13],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[14],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[15],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[16],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 139;
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
                await ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[6],_testData[34], false);
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
                var models = ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
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
                foreach(var batchResult in  ((IGuidListuuidListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatGuidv7uuidListD1E2M.AssertModel(models[0],_testData[9], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[1],_testData[10], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[2],_testData[11], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[3],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[4],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[5],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[6],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[7],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[8],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[9],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[10],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[11],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[12],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[13],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[14],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[15],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[16],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[17],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[18],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[19],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[20],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[21],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[22],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[23],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[24],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatGuidv7uuidListD1E2M.AssertModel(models[0],_testData[2], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[1],_testData[3], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[2],_testData[4], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[3],_testData[5], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[4],_testData[6], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[5],_testData[7], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[6],_testData[8], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[7],_testData[9], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[8],_testData[10], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[9],_testData[11], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[10],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[11],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[12],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[13],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[14],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[15],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[16],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[17],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[18],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[19],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[20],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[21],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[22],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[23],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[24],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[25],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[26],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[27],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[28],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[29],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[30],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[31],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 82;
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
                 ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[8],_testData[34], false);
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
LEFT JOIN public.guiduuidlistd1e2mi mi ON mi.id = m.guiduuidlistd1e2mi_id
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
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 150;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(4));

                        Guidv7uuidListD1E2M.AssertModel(models[0],_testData[31], false);
                        Guidv7uuidListD1E2M.AssertModel(models[1],_testData[32], false);
                        Guidv7uuidListD1E2M.AssertModel(models[2],_testData[33], false);
                        Guidv7uuidListD1E2M.AssertModel(models[3],_testData[34], false);
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
FROM public.guidv7uuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuidv7uuidListD1E2M>();
                var models2 = new List<FlatGuidv7uuidListD1E2M>();
                await((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
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
                await ((IGuidListuuidListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 4, query1, 106, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[12],_testData[34], false);
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
                await ((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 106, query1, 96, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[15],_testData[34], false);
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
                ((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
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
                 ((IGuidListuuidListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 50, query1, 48, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[23],_testData[34], false);
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
                 ((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 32, query1, 32, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[27],_testData[34], false);
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
FROM public.guidv7uuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
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
                foreach(var batchResult in await ((IGuidListuuidListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 33, query1, 14, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
                await ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 19, query1, 154, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[2],_testData[34], false);
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
                var models = ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
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
                foreach(var batchResult in  ((IGuidListuuidListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 127, query1, 161, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatGuidv7uuidListD1E2M.AssertModel(models[0],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[1],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[2],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[3],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[4],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[5],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[6],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[7],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[8],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatGuidv7uuidListD1E2M.AssertModel(models[0],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[1],_testData[34], false);
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
                 ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 19, query1, 56, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[21],_testData[34], false);
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
LEFT JOIN public.guiduuidlistd1e2mi mi ON mi.id = m.guiduuidlistd1e2mi_id
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
                foreach(var batchResult in await ((IGuidListuuidListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 119, 82))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Guidv7uuidListD1E2M.AssertModel(models[0],_testData[24], false);
                        Guidv7uuidListD1E2M.AssertModel(models[1],_testData[25], false);
                        Guidv7uuidListD1E2M.AssertModel(models[2],_testData[26], false);
                        Guidv7uuidListD1E2M.AssertModel(models[3],_testData[27], false);
                        Guidv7uuidListD1E2M.AssertModel(models[4],_testData[28], false);
                        Guidv7uuidListD1E2M.AssertModel(models[5],_testData[29], false);
                        Guidv7uuidListD1E2M.AssertModel(models[6],_testData[30], false);
                        Guidv7uuidListD1E2M.AssertModel(models[7],_testData[31], false);
                        Guidv7uuidListD1E2M.AssertModel(models[8],_testData[32], false);
                        Guidv7uuidListD1E2M.AssertModel(models[9],_testData[33], false);
                        Guidv7uuidListD1E2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                foreach(var batchResult in  ((IGuidListuuidListD1)this).DbConnectionSTSelectModelBatch(connection, 154, 50))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Guidv7uuidListD1E2M.AssertModel(models[0],_testData[32], false);
                        Guidv7uuidListD1E2M.AssertModel(models[1],_testData[33], false);
                        Guidv7uuidListD1E2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        Guidv7uuidListD1E2M.AssertModel(models[0],_testData[12], false);
                        Guidv7uuidListD1E2M.AssertModel(models[1],_testData[13], false);
                        Guidv7uuidListD1E2M.AssertModel(models[2],_testData[14], false);
                        Guidv7uuidListD1E2M.AssertModel(models[3],_testData[15], false);
                        Guidv7uuidListD1E2M.AssertModel(models[4],_testData[16], false);
                        Guidv7uuidListD1E2M.AssertModel(models[5],_testData[17], false);
                        Guidv7uuidListD1E2M.AssertModel(models[6],_testData[18], false);
                        Guidv7uuidListD1E2M.AssertModel(models[7],_testData[19], false);
                        Guidv7uuidListD1E2M.AssertModel(models[8],_testData[20], false);
                        Guidv7uuidListD1E2M.AssertModel(models[9],_testData[21], false);
                        Guidv7uuidListD1E2M.AssertModel(models[10],_testData[22], false);
                        Guidv7uuidListD1E2M.AssertModel(models[11],_testData[23], false);
                        Guidv7uuidListD1E2M.AssertModel(models[12],_testData[24], false);
                        Guidv7uuidListD1E2M.AssertModel(models[13],_testData[25], false);
                        Guidv7uuidListD1E2M.AssertModel(models[14],_testData[26], false);
                        Guidv7uuidListD1E2M.AssertModel(models[15],_testData[27], false);
                        Guidv7uuidListD1E2M.AssertModel(models[16],_testData[28], false);
                        Guidv7uuidListD1E2M.AssertModel(models[17],_testData[29], false);
                        Guidv7uuidListD1E2M.AssertModel(models[18],_testData[30], false);
                        Guidv7uuidListD1E2M.AssertModel(models[19],_testData[31], false);
                        Guidv7uuidListD1E2M.AssertModel(models[20],_testData[32], false);
                        Guidv7uuidListD1E2M.AssertModel(models[21],_testData[33], false);
                        Guidv7uuidListD1E2M.AssertModel(models[22],_testData[34], false);
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
                ((IGuidListuuidListD1)this).SetDbConnectionSelectModelParametrs(cmd, 39);
                var models = await ((IGuidListuuidListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[9], false);
                Guidv7uuidListD1E2M.AssertModel(models[1],_testData[10], false);
                Guidv7uuidListD1E2M.AssertModel(models[2],_testData[11], false);
                Guidv7uuidListD1E2M.AssertModel(models[3],_testData[12], false);
                Guidv7uuidListD1E2M.AssertModel(models[4],_testData[13], false);
                Guidv7uuidListD1E2M.AssertModel(models[5],_testData[14], false);
                Guidv7uuidListD1E2M.AssertModel(models[6],_testData[15], false);
                Guidv7uuidListD1E2M.AssertModel(models[7],_testData[16], false);
                Guidv7uuidListD1E2M.AssertModel(models[8],_testData[17], false);
                Guidv7uuidListD1E2M.AssertModel(models[9],_testData[18], false);
                Guidv7uuidListD1E2M.AssertModel(models[10],_testData[19], false);
                Guidv7uuidListD1E2M.AssertModel(models[11],_testData[20], false);
                Guidv7uuidListD1E2M.AssertModel(models[12],_testData[21], false);
                Guidv7uuidListD1E2M.AssertModel(models[13],_testData[22], false);
                Guidv7uuidListD1E2M.AssertModel(models[14],_testData[23], false);
                Guidv7uuidListD1E2M.AssertModel(models[15],_testData[24], false);
                Guidv7uuidListD1E2M.AssertModel(models[16],_testData[25], false);
                Guidv7uuidListD1E2M.AssertModel(models[17],_testData[26], false);
                Guidv7uuidListD1E2M.AssertModel(models[18],_testData[27], false);
                Guidv7uuidListD1E2M.AssertModel(models[19],_testData[28], false);
                Guidv7uuidListD1E2M.AssertModel(models[20],_testData[29], false);
                Guidv7uuidListD1E2M.AssertModel(models[21],_testData[30], false);
                Guidv7uuidListD1E2M.AssertModel(models[22],_testData[31], false);
                Guidv7uuidListD1E2M.AssertModel(models[23],_testData[32], false);
                Guidv7uuidListD1E2M.AssertModel(models[24],_testData[33], false);
                Guidv7uuidListD1E2M.AssertModel(models[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidListuuidListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidListuuidListD1)this).SetDbConnectionSelectModelParametrs(cmd, 45);
                var models =  ((IGuidListuuidListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(25));

                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[10], false);
                Guidv7uuidListD1E2M.AssertModel(models[1],_testData[11], false);
                Guidv7uuidListD1E2M.AssertModel(models[2],_testData[12], false);
                Guidv7uuidListD1E2M.AssertModel(models[3],_testData[13], false);
                Guidv7uuidListD1E2M.AssertModel(models[4],_testData[14], false);
                Guidv7uuidListD1E2M.AssertModel(models[5],_testData[15], false);
                Guidv7uuidListD1E2M.AssertModel(models[6],_testData[16], false);
                Guidv7uuidListD1E2M.AssertModel(models[7],_testData[17], false);
                Guidv7uuidListD1E2M.AssertModel(models[8],_testData[18], false);
                Guidv7uuidListD1E2M.AssertModel(models[9],_testData[19], false);
                Guidv7uuidListD1E2M.AssertModel(models[10],_testData[20], false);
                Guidv7uuidListD1E2M.AssertModel(models[11],_testData[21], false);
                Guidv7uuidListD1E2M.AssertModel(models[12],_testData[22], false);
                Guidv7uuidListD1E2M.AssertModel(models[13],_testData[23], false);
                Guidv7uuidListD1E2M.AssertModel(models[14],_testData[24], false);
                Guidv7uuidListD1E2M.AssertModel(models[15],_testData[25], false);
                Guidv7uuidListD1E2M.AssertModel(models[16],_testData[26], false);
                Guidv7uuidListD1E2M.AssertModel(models[17],_testData[27], false);
                Guidv7uuidListD1E2M.AssertModel(models[18],_testData[28], false);
                Guidv7uuidListD1E2M.AssertModel(models[19],_testData[29], false);
                Guidv7uuidListD1E2M.AssertModel(models[20],_testData[30], false);
                Guidv7uuidListD1E2M.AssertModel(models[21],_testData[31], false);
                Guidv7uuidListD1E2M.AssertModel(models[22],_testData[32], false);
                Guidv7uuidListD1E2M.AssertModel(models[23],_testData[33], false);
                Guidv7uuidListD1E2M.AssertModel(models[24],_testData[34], false);
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
COPY public.binary_guidv7uuidlistd1e2m
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
FROM public.binary_guidv7uuidlistd1e2m m
LEFT JOIN public.binary_guiduuidlistd1e2mi mi ON mi.id = m.guiduuidlistd1e2mi_id
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
                var importCollection = new List<Guidv7uuidListD1E2M>();
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

                ((IGuidListuuidListD1)this).ImportModel(connection, importCollection);
                var models = ((IGuidListuuidListD1)this).SelectImportModel(connection);
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
    guiduuidlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Guidv7uuidListD1E2M)],
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
                var models = await ((IGuidListuuidListD1)this).ExportModelAsync(connection).ToListAsync();
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

