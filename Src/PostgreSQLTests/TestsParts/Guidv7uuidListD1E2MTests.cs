

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
Guid.Parse("019e1b50-1727-7fc5-8a55-5669a4e31124"),

Guid.Parse("019e1b50-1727-7561-bead-1977366afe30"),

Guid.Parse("019e1b50-1727-7d38-a52c-1cc9234de966"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-7530-b348-e5f0933a8d31"),

Guid.Parse("019e1b50-1727-717f-a597-38ff24f9d6aa"),

Guid.Parse("019e1b50-1727-7432-98b4-d5e86462c615"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-7198-9bb4-f69d38512153"),

Guid.Parse("019e1b50-1727-79d9-981c-75e8121e0470"),

Guid.Parse("019e1b50-1727-74a9-888d-0608b8e7759a"),

},
    ModelInner = new Guidv7uuidListD1E2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b50-1727-7aa5-b7a7-f9dde7b2483a"),

Guid.Parse("019e1b50-1727-793f-9016-34d9b95118aa"),

Guid.Parse("019e1b50-1727-722c-a8b0-8f3adc2e757a"),

Guid.Parse("019e1b50-1727-7f2a-a166-d7af8676149c"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-7836-abe9-30f07f1a0e47"),

Guid.Parse("019e1b50-1727-70bb-9a64-c5ab97fa49ae"),

Guid.Parse("019e1b50-1727-7d25-9593-434d36f9afac"),

},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-728d-844c-5827d007242c"),

Guid.Parse("019e1b50-1727-7f9a-a511-d57dd1b98813"),

Guid.Parse("019e1b50-1727-7bbb-8cea-a71453bb559b"),

},
    ModelInner = new Guidv7uuidListD1E2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b50-1727-7467-90f1-c6a513bbe58f"),

Guid.Parse("019e1b50-1727-73ee-a2fc-9629f3f4d1c9"),

Guid.Parse("019e1b50-1727-7cd1-bd04-c7e646c96991"),

Guid.Parse("019e1b50-1727-7c0d-be40-224dbed04b49"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b50-1727-7bff-8134-5aed790caba2"),

Guid.Parse("019e1b50-1727-7941-8987-d54be9684278"),

Guid.Parse("019e1b50-1727-74ae-a84f-f52f747ff106"),

Guid.Parse("019e1b50-1727-7ef3-8685-7eef621a1619"),

},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b50-1727-7d9e-bfc0-bfe240c16c45"),

Guid.Parse("019e1b50-1727-794f-8085-50023fd377e4"),

Guid.Parse("019e1b50-1727-76fd-b2db-caeb3adc5a95"),

Guid.Parse("019e1b50-1727-7be7-b5ba-8d00436f88ab"),

},
    ModelInner = new Guidv7uuidListD1E2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-73c9-81fb-e2123bde92ee"),

Guid.Parse("019e1b50-1727-7b5a-9041-f27927cf8810"),

Guid.Parse("019e1b50-1727-7b7b-863c-c64f8b9f6c34"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b50-1727-771a-8be4-f8b79046653e"),

Guid.Parse("019e1b50-1727-72d3-9f6f-576fa98cd5bc"),

Guid.Parse("019e1b50-1727-774f-892c-b585c6661560"),

Guid.Parse("019e1b50-1727-71e8-ae0f-f5d9bf4150e9"),

},
},
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-7e90-a5f6-9e197fd1a162"),

Guid.Parse("019e1b50-1727-75fa-a50b-da7fdf67fc88"),

Guid.Parse("019e1b50-1727-7e46-a944-d5611fa62319"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b50-1727-79bc-a6b1-51cce296be2e"),

Guid.Parse("019e1b50-1727-7470-ae7b-23b139c6b839"),

Guid.Parse("019e1b50-1727-7c15-ad5a-2aceaba87410"),

Guid.Parse("019e1b50-1727-7315-beab-eb5196da916b"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b50-1727-712c-bd95-550aeb89aae9"),

Guid.Parse("019e1b50-1727-798f-92a1-6fc427f50c85"),

Guid.Parse("019e1b50-1727-7009-ac32-540dcf940bb3"),

Guid.Parse("019e1b50-1727-722e-a449-9b712654cb9e"),

},
    ModelInner = new Guidv7uuidListD1E2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-7026-8993-7cdab5baf269"),

Guid.Parse("019e1b50-1727-7ab4-8109-abc364377364"),

Guid.Parse("019e1b50-1727-7fd6-8165-a48857016739"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-753d-a8e5-e716300b908f"),

Guid.Parse("019e1b50-1727-7f41-83a0-8e91800e1865"),

Guid.Parse("019e1b50-1727-7b78-a83c-99067f0773ff"),

},
},
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-795a-9e76-5b3f8e8b56e4"),

Guid.Parse("019e1b50-1727-722e-84ab-dcf77b42b2a1"),

Guid.Parse("019e1b50-1727-7897-81fc-b9ecd2bdf619"),

},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b50-1727-70a8-b63e-190e717b99d9"),

Guid.Parse("019e1b50-1727-7fee-b2e4-5b22deef199a"),

Guid.Parse("019e1b50-1727-7929-873a-6bfe134f7a84"),

Guid.Parse("019e1b50-1727-7472-8911-958d1008b8fd"),

},
    ModelInner = new Guidv7uuidListD1E2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-70b8-a756-92b606d865b4"),

Guid.Parse("019e1b50-1727-7c49-bf7c-e62d3ad7c6a1"),

Guid.Parse("019e1b50-1727-7a50-86c4-98bd22e0d7b5"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b50-1727-729b-af50-16105f29dc70"),

Guid.Parse("019e1b50-1727-7807-b4db-6e4dcf0bb84e"),

Guid.Parse("019e1b50-1727-71ef-babf-acc3f6ebaefa"),

Guid.Parse("019e1b50-1727-7f65-b2e0-3c4d95ec79ac"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-7ab6-b648-9906e1f4185c"),

Guid.Parse("019e1b50-1727-77ef-9abc-e2bbb37d01f7"),

Guid.Parse("019e1b50-1727-7586-ae71-ad46de9c6e58"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b50-1727-7dc7-8fc9-f1d613f8a20d"),

Guid.Parse("019e1b50-1727-71cd-ace6-3536a712f7f8"),

Guid.Parse("019e1b50-1727-75f7-a665-6c6748fab37f"),

Guid.Parse("019e1b50-1727-78e7-b02e-d3f66aaee774"),

},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b50-1727-7b6b-8e13-cb5f20e6814f"),

Guid.Parse("019e1b50-1727-7200-ac38-a345f44f007e"),

Guid.Parse("019e1b50-1727-7adc-813d-6f0730bcf142"),

Guid.Parse("019e1b50-1727-7247-9e3e-739f9746b054"),

},
    ModelInner = new Guidv7uuidListD1E2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-7c90-b222-56e157428481"),

Guid.Parse("019e1b50-1727-71c7-b4af-4d78f0bd8442"),

Guid.Parse("019e1b50-1727-7140-8426-a4d40f241deb"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b50-1727-71c2-b36e-c2e766af4dc3"),

Guid.Parse("019e1b50-1727-7973-a8ff-f72232cb134a"),

Guid.Parse("019e1b50-1727-79cc-b87a-6974a1bae8fa"),

Guid.Parse("019e1b50-1727-726c-b38c-e71a03b0ec87"),

},
},
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-73d2-8bbf-f2cc02fb1b49"),

Guid.Parse("019e1b50-1727-7aaa-954c-0b45c3c5075b"),

Guid.Parse("019e1b50-1727-7d50-8f64-5bbb3b59e81c"),

},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-7ae5-8783-a98740d63ec8"),

Guid.Parse("019e1b50-1727-78ad-96e1-0f895585f521"),

Guid.Parse("019e1b50-1727-7760-b94b-1b089d170689"),

},
    ModelInner = new Guidv7uuidListD1E2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b50-1727-7fbc-a1ba-9f722c434a2a"),

Guid.Parse("019e1b50-1727-774c-9195-07b8b950818f"),

Guid.Parse("019e1b50-1727-7412-8af3-cda1f4aa6c17"),

Guid.Parse("019e1b50-1727-7648-9969-09f5bb566a06"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-707b-bfaa-43149a4458a0"),

Guid.Parse("019e1b50-1727-7dea-b092-6a993d272165"),

Guid.Parse("019e1b50-1727-7db4-b7d2-ea2c985b0987"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b50-1727-781c-b1e6-5566c428718f"),

Guid.Parse("019e1b50-1727-7216-87f5-2a6a04a54e1e"),

Guid.Parse("019e1b50-1727-7870-bd15-25dc3a0b148c"),

Guid.Parse("019e1b50-1727-70cc-980a-ba31d2d87df5"),

},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b50-1727-75db-b562-53a43749bda2"),

Guid.Parse("019e1b50-1727-770a-a2c9-036393bd5030"),

Guid.Parse("019e1b50-1727-7029-8252-af50990b7231"),

Guid.Parse("019e1b50-1727-77ac-a30d-7a73ff0b93ae"),

},
    ModelInner = new Guidv7uuidListD1E2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-7254-86cc-afda661d179b"),

Guid.Parse("019e1b50-1727-7fba-82d1-1ee1aee39c49"),

Guid.Parse("019e1b50-1727-76dc-b348-8b19995b6d44"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b50-1727-77aa-8af6-b8c8ebbd324a"),

Guid.Parse("019e1b50-1727-70dd-8674-5ccfd2996816"),

Guid.Parse("019e1b50-1727-7297-8de1-c9cf1b36dd01"),

Guid.Parse("019e1b50-1727-7d89-8f5c-4b13536c77a4"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b50-1727-787c-a51c-8f70d7cde1c2"),

Guid.Parse("019e1b50-1727-7922-aa64-c5037492a1c8"),

Guid.Parse("019e1b50-1727-7e9a-a6db-181f73302dfc"),

Guid.Parse("019e1b50-1727-7bcb-92c1-fbd12ca92f41"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-73cb-910e-0cbd6b1de459"),

Guid.Parse("019e1b50-1727-7dff-a346-8844b25ba4e2"),

Guid.Parse("019e1b50-1727-7954-8e66-9026c410c068"),

},
    ModelInner = new Guidv7uuidListD1E2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-7dff-88b3-fe1fbb283e62"),

Guid.Parse("019e1b50-1727-7b7f-b512-08e46a84b666"),

Guid.Parse("019e1b50-1727-7329-8f06-6919f5f1f58b"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b50-1727-751f-a6d4-f827c2bd7582"),

Guid.Parse("019e1b50-1727-7f73-b787-c230dcef9e93"),

Guid.Parse("019e1b50-1727-755b-b805-77dc43a4e687"),

Guid.Parse("019e1b50-1727-7483-8d87-ff7177889607"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-75ca-aaa3-4296023a7990"),

Guid.Parse("019e1b50-1727-7b8b-8c53-f21c0ebb128c"),

Guid.Parse("019e1b50-1727-7239-a5c7-090c98339095"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b50-1727-77a7-b74c-ad0d25a7f31e"),

Guid.Parse("019e1b50-1727-7226-b2c0-0abf65246c3b"),

Guid.Parse("019e1b50-1727-7be8-aefd-66c94e1b8cc6"),

Guid.Parse("019e1b50-1727-7c94-9922-d06d070387f5"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-7a4d-8602-645e95438792"),

Guid.Parse("019e1b50-1727-7424-b338-1383d9ba48d9"),

Guid.Parse("019e1b50-1727-7201-9b9c-00782369acc8"),

},
    ModelInner = new Guidv7uuidListD1E2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-75bf-8e8e-cd2d620d1ca6"),

Guid.Parse("019e1b50-1727-7207-aa23-8af323f6ddc9"),

Guid.Parse("019e1b50-1727-71ca-83ed-2d1c00dc2a73"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b50-1727-7844-87fd-5a6c2d9d025d"),

Guid.Parse("019e1b50-1727-7072-9076-bc8f07116676"),

Guid.Parse("019e1b50-1727-73d5-a3f6-b9ca2a615089"),

Guid.Parse("019e1b50-1727-7ad7-9b70-5b15ed460f31"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-74a9-b7bf-26510cf172dc"),

Guid.Parse("019e1b50-1727-7f76-a955-b69d591a5da5"),

Guid.Parse("019e1b50-1727-74b2-b4f9-b153ae9eaaa7"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b50-1727-7f9c-a4c0-25c515f38fa1"),

Guid.Parse("019e1b50-1727-72d2-980d-acbd3afda871"),

Guid.Parse("019e1b50-1727-7774-aa84-a15bcb3e8905"),

Guid.Parse("019e1b50-1727-72c0-a323-903022bae74e"),

},
    ModelInner = new Guidv7uuidListD1E2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-7969-a169-48a993e76cc9"),

Guid.Parse("019e1b50-1727-794a-baa3-a33e89cc6e47"),

Guid.Parse("019e1b50-1727-76b3-90b1-0cf83836b6a3"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b50-1727-7472-91fc-2cc34b1107a0"),

Guid.Parse("019e1b50-1727-7e82-8ba1-b000ffdf3a6b"),

Guid.Parse("019e1b50-1727-7e58-9616-dc8d1b27f376"),

Guid.Parse("019e1b50-1727-7015-93c2-e714f2e66daa"),

},
},
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-7a12-bd14-3a17bdd280e0"),

Guid.Parse("019e1b50-1727-7eb2-ada0-ae12919f15f7"),

Guid.Parse("019e1b50-1727-7618-8138-f0b749fc5c25"),

},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b50-1727-77ad-9d34-7c19427de116"),

Guid.Parse("019e1b50-1727-7c20-a63e-033fc11d57f9"),

Guid.Parse("019e1b50-1727-7734-8847-4f6e76c7cde4"),

Guid.Parse("019e1b50-1727-73c8-bf4d-045b7c3eeedb"),

},
    ModelInner = new Guidv7uuidListD1E2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-7ff8-8153-777d50f5e355"),

Guid.Parse("019e1b50-1727-7700-953e-d96aad595e46"),

Guid.Parse("019e1b50-1727-7d44-84b6-354261c6f841"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b50-1727-7cae-b159-d5cf51ff5808"),

Guid.Parse("019e1b50-1727-7cd9-9238-48fde6ea1c70"),

Guid.Parse("019e1b50-1727-7bc0-8573-14291e86a977"),

Guid.Parse("019e1b50-1727-7f9f-840e-5c8c7cae123d"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b50-1727-7fe8-8d12-39514b53515e"),

Guid.Parse("019e1b50-1727-7180-b893-4cde1f500295"),

Guid.Parse("019e1b50-1727-7d61-8210-3661b01dec5c"),

Guid.Parse("019e1b50-1727-7659-bcf7-ae883fa94439"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-7e5d-bfe8-e3ce809d3ba8"),

Guid.Parse("019e1b50-1727-764c-9c29-48399dc85685"),

Guid.Parse("019e1b50-1727-7f28-8a24-499b7cb3e4f5"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b50-1727-7f7a-a6c4-5d50f24c68cd"),

Guid.Parse("019e1b50-1727-7bec-9d2b-06d2c0f8f2ad"),

Guid.Parse("019e1b50-1727-7d1e-a5f3-8e7a845ff04b"),

Guid.Parse("019e1b50-1727-7fb6-804f-7dc05396e100"),

},
    ModelInner = new Guidv7uuidListD1E2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b50-1727-7b60-9d51-ca0a4064a244"),

Guid.Parse("019e1b50-1727-789e-9bc0-47dd6b06d8c7"),

Guid.Parse("019e1b50-1727-7dfb-b057-11c86c735f04"),

Guid.Parse("019e1b50-1727-7eec-8b5f-a41bebffeef4"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-7f81-b75f-d9a0e4403615"),

Guid.Parse("019e1b50-1727-7793-91e1-f9973b3c97b0"),

Guid.Parse("019e1b50-1727-711f-9191-9c46267041e3"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b50-1727-72a4-9210-bd1e2a3e9c9b"),

Guid.Parse("019e1b50-1727-788d-8ea7-9a6ecefcf9db"),

Guid.Parse("019e1b50-1727-73c0-8eaf-bfcce04f3d97"),

Guid.Parse("019e1b50-1727-702b-b8d8-f348b54b9ce8"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b50-1727-7170-a723-f4348d8ee0f7"),

Guid.Parse("019e1b50-1727-774e-8f13-cf88952b1d0b"),

Guid.Parse("019e1b50-1727-7254-9560-5922fb0d3d15"),

Guid.Parse("019e1b50-1727-7b2b-8800-d8852b0ed5b3"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-7ca9-bc7b-d460d7a619a5"),

Guid.Parse("019e1b50-1727-7105-abff-4e5a79ad7ea0"),

Guid.Parse("019e1b50-1727-7bb5-aa25-1194b5369da5"),

},
    ModelInner = new Guidv7uuidListD1E2MI
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b50-1727-71cf-9af9-a8bd33f30efc"),

Guid.Parse("019e1b50-1727-725c-ae8c-05f4ec605d8d"),

Guid.Parse("019e1b50-1727-7f44-9cbe-76717d8cdc20"),

Guid.Parse("019e1b50-1727-79ed-9e37-0cfcdb86bd38"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-724b-9558-98bd84913225"),

Guid.Parse("019e1b50-1727-7739-8d57-e0e26fe384bc"),

Guid.Parse("019e1b50-1727-7c81-a88e-934199919189"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-7469-b752-44d223ca57ad"),

Guid.Parse("019e1b50-1727-743e-978c-6dfeff11cccf"),

Guid.Parse("019e1b50-1727-7a3c-b195-65ec0aa67552"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-7ded-bd35-f286eb4d8053"),

Guid.Parse("019e1b50-1727-7afd-b7fd-c2bc00341cbc"),

Guid.Parse("019e1b50-1727-7e87-b802-97b8b8c2f554"),

},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-7831-8290-df9824e31602"),

Guid.Parse("019e1b50-1727-7b89-a667-031d01cdb068"),

Guid.Parse("019e1b50-1727-746a-b9ee-03d4f8e1a6ad"),

},
    ModelInner = new Guidv7uuidListD1E2MI
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-79d1-8106-ffde7ef2e502"),

Guid.Parse("019e1b50-1727-7f56-a5a2-96b27b74bee7"),

Guid.Parse("019e1b50-1727-74a7-852f-648fb3899dbc"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b50-1727-7e48-a600-3b81284b13d7"),

Guid.Parse("019e1b50-1727-7f2c-8ccd-83e6429ef50a"),

Guid.Parse("019e1b50-1727-703f-9b1f-63993b2a4c8a"),

Guid.Parse("019e1b50-1727-7ce6-9ee4-e27834f58664"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-7e39-a3b2-3a485773c8f9"),

Guid.Parse("019e1b50-1727-7b2c-88b3-f3865c53702f"),

Guid.Parse("019e1b50-1727-7cf1-b24c-14b0ac07e54a"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b50-1727-73d1-8872-e8a2ae2a0fe0"),

Guid.Parse("019e1b50-1727-7774-970d-b7a0638e5bcc"),

Guid.Parse("019e1b50-1727-7152-9caa-c5239c2bfbe8"),

Guid.Parse("019e1b50-1727-70d3-b52f-e64c4b5a9c8c"),

},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b50-1727-70ec-94c1-d73db169ca90"),

Guid.Parse("019e1b50-1727-7ecb-9ec7-0a09f16ebe7b"),

Guid.Parse("019e1b50-1727-74ef-8e9d-068164ab62aa"),

Guid.Parse("019e1b50-1727-74b5-81ea-962d19e7d8c1"),

},
    ModelInner = new Guidv7uuidListD1E2MI
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-7996-af93-6a29d27259e5"),

Guid.Parse("019e1b50-1727-7217-80cf-dd1f19e35dbc"),

Guid.Parse("019e1b50-1727-79bd-8ee0-e8534e546aff"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-7237-a731-9bb245f60c7f"),

Guid.Parse("019e1b50-1727-75ee-9536-f4c59b8f2e6a"),

Guid.Parse("019e1b50-1727-7206-bd52-ffa7ce0b8f2a"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-719c-aad9-e1a33073cb39"),

Guid.Parse("019e1b50-1727-775b-8613-470d08cbc555"),

Guid.Parse("019e1b50-1727-75c3-800d-4e18a43ac03d"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b50-1727-75c8-bbc4-e3047cced8db"),

Guid.Parse("019e1b50-1727-7437-8b13-b58e960289a0"),

Guid.Parse("019e1b50-1727-7500-aaa2-df02418735bc"),

Guid.Parse("019e1b50-1727-7208-8f0a-1069bf137bd0"),

},
},
            new Guidv7uuidListD1E2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-789c-838e-ab6e9d1682c8"),

Guid.Parse("019e1b50-1727-79c5-a998-fd0c94636004"),

Guid.Parse("019e1b50-1727-7107-bb10-8c78fda3fd60"),

},
    ModelInner = new Guidv7uuidListD1E2MI
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b50-1727-76b7-80fd-72e62d8aeec9"),

Guid.Parse("019e1b50-1727-78ad-8647-fd3ea0947614"),

Guid.Parse("019e1b50-1727-7cec-9c51-10c149551c8c"),

Guid.Parse("019e1b50-1727-791a-8043-11a4aee3bf89"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidListD1E2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("019e1b50-1727-7c08-b00b-d90aec8ece6e"),

Guid.Parse("019e1b50-1727-7cc9-86b1-f4e7b33acb50"),

Guid.Parse("019e1b50-1727-739a-86c2-c1cf363f1b81"),

Guid.Parse("019e1b50-1727-7ef4-b6ef-388708f06929"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019e1b50-1727-7e78-9542-f4a807911cfd"),

Guid.Parse("019e1b50-1727-7db9-ae7f-536190ff9646"),

Guid.Parse("019e1b50-1727-757f-bad9-605128d6edde"),

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
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[7],_testData[34], false);
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
                parametr1.Value = 120;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 107;
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
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[31],_testData[34], false);
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
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
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatGuidv7uuidListD1E2M.AssertModel(models[0],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[1],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[2],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[3],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[4],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[5],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[6],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[7],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatGuidv7uuidListD1E2M.AssertModel(models[0],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[1],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[2],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[3],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[4],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[5],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[6],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[7],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[8],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[9],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[10],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[11],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 3;
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
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[33],_testData[34], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatGuidv7uuidListD1E2M.AssertModel(models[0],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[1],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[2],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[3],_testData[34], false);
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
                parametr2.Value = 91;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
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
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidv7ListuuidListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Guidv7uuidListD1E2M.AssertModel(models[0],_testData[4], false);
                        Guidv7uuidListD1E2M.AssertModel(models[1],_testData[5], false);
                        Guidv7uuidListD1E2M.AssertModel(models[2],_testData[6], false);
                        Guidv7uuidListD1E2M.AssertModel(models[3],_testData[7], false);
                        Guidv7uuidListD1E2M.AssertModel(models[4],_testData[8], false);
                        Guidv7uuidListD1E2M.AssertModel(models[5],_testData[9], false);
                        Guidv7uuidListD1E2M.AssertModel(models[6],_testData[10], false);
                        Guidv7uuidListD1E2M.AssertModel(models[7],_testData[11], false);
                        Guidv7uuidListD1E2M.AssertModel(models[8],_testData[12], false);
                        Guidv7uuidListD1E2M.AssertModel(models[9],_testData[13], false);
                        Guidv7uuidListD1E2M.AssertModel(models[10],_testData[14], false);
                        Guidv7uuidListD1E2M.AssertModel(models[11],_testData[15], false);
                        Guidv7uuidListD1E2M.AssertModel(models[12],_testData[16], false);
                        Guidv7uuidListD1E2M.AssertModel(models[13],_testData[17], false);
                        Guidv7uuidListD1E2M.AssertModel(models[14],_testData[18], false);
                        Guidv7uuidListD1E2M.AssertModel(models[15],_testData[19], false);
                        Guidv7uuidListD1E2M.AssertModel(models[16],_testData[20], false);
                        Guidv7uuidListD1E2M.AssertModel(models[17],_testData[21], false);
                        Guidv7uuidListD1E2M.AssertModel(models[18],_testData[22], false);
                        Guidv7uuidListD1E2M.AssertModel(models[19],_testData[23], false);
                        Guidv7uuidListD1E2M.AssertModel(models[20],_testData[24], false);
                        Guidv7uuidListD1E2M.AssertModel(models[21],_testData[25], false);
                        Guidv7uuidListD1E2M.AssertModel(models[22],_testData[26], false);
                        Guidv7uuidListD1E2M.AssertModel(models[23],_testData[27], false);
                        Guidv7uuidListD1E2M.AssertModel(models[24],_testData[28], false);
                        Guidv7uuidListD1E2M.AssertModel(models[25],_testData[29], false);
                        Guidv7uuidListD1E2M.AssertModel(models[26],_testData[30], false);
                        Guidv7uuidListD1E2M.AssertModel(models[27],_testData[31], false);
                        Guidv7uuidListD1E2M.AssertModel(models[28],_testData[32], false);
                        Guidv7uuidListD1E2M.AssertModel(models[29],_testData[33], false);
                        Guidv7uuidListD1E2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Guidv7uuidListD1E2M.AssertModel(models[0],_testData[11], false);
                        Guidv7uuidListD1E2M.AssertModel(models[1],_testData[12], false);
                        Guidv7uuidListD1E2M.AssertModel(models[2],_testData[13], false);
                        Guidv7uuidListD1E2M.AssertModel(models[3],_testData[14], false);
                        Guidv7uuidListD1E2M.AssertModel(models[4],_testData[15], false);
                        Guidv7uuidListD1E2M.AssertModel(models[5],_testData[16], false);
                        Guidv7uuidListD1E2M.AssertModel(models[6],_testData[17], false);
                        Guidv7uuidListD1E2M.AssertModel(models[7],_testData[18], false);
                        Guidv7uuidListD1E2M.AssertModel(models[8],_testData[19], false);
                        Guidv7uuidListD1E2M.AssertModel(models[9],_testData[20], false);
                        Guidv7uuidListD1E2M.AssertModel(models[10],_testData[21], false);
                        Guidv7uuidListD1E2M.AssertModel(models[11],_testData[22], false);
                        Guidv7uuidListD1E2M.AssertModel(models[12],_testData[23], false);
                        Guidv7uuidListD1E2M.AssertModel(models[13],_testData[24], false);
                        Guidv7uuidListD1E2M.AssertModel(models[14],_testData[25], false);
                        Guidv7uuidListD1E2M.AssertModel(models[15],_testData[26], false);
                        Guidv7uuidListD1E2M.AssertModel(models[16],_testData[27], false);
                        Guidv7uuidListD1E2M.AssertModel(models[17],_testData[28], false);
                        Guidv7uuidListD1E2M.AssertModel(models[18],_testData[29], false);
                        Guidv7uuidListD1E2M.AssertModel(models[19],_testData[30], false);
                        Guidv7uuidListD1E2M.AssertModel(models[20],_testData[31], false);
                        Guidv7uuidListD1E2M.AssertModel(models[21],_testData[32], false);
                        Guidv7uuidListD1E2M.AssertModel(models[22],_testData[33], false);
                        Guidv7uuidListD1E2M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidv7ListuuidListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Guidv7uuidListD1E2M.AssertModel(models[0],_testData[14], false);
                        Guidv7uuidListD1E2M.AssertModel(models[1],_testData[15], false);
                        Guidv7uuidListD1E2M.AssertModel(models[2],_testData[16], false);
                        Guidv7uuidListD1E2M.AssertModel(models[3],_testData[17], false);
                        Guidv7uuidListD1E2M.AssertModel(models[4],_testData[18], false);
                        Guidv7uuidListD1E2M.AssertModel(models[5],_testData[19], false);
                        Guidv7uuidListD1E2M.AssertModel(models[6],_testData[20], false);
                        Guidv7uuidListD1E2M.AssertModel(models[7],_testData[21], false);
                        Guidv7uuidListD1E2M.AssertModel(models[8],_testData[22], false);
                        Guidv7uuidListD1E2M.AssertModel(models[9],_testData[23], false);
                        Guidv7uuidListD1E2M.AssertModel(models[10],_testData[24], false);
                        Guidv7uuidListD1E2M.AssertModel(models[11],_testData[25], false);
                        Guidv7uuidListD1E2M.AssertModel(models[12],_testData[26], false);
                        Guidv7uuidListD1E2M.AssertModel(models[13],_testData[27], false);
                        Guidv7uuidListD1E2M.AssertModel(models[14],_testData[28], false);
                        Guidv7uuidListD1E2M.AssertModel(models[15],_testData[29], false);
                        Guidv7uuidListD1E2M.AssertModel(models[16],_testData[30], false);
                        Guidv7uuidListD1E2M.AssertModel(models[17],_testData[31], false);
                        Guidv7uuidListD1E2M.AssertModel(models[18],_testData[32], false);
                        Guidv7uuidListD1E2M.AssertModel(models[19],_testData[33], false);
                        Guidv7uuidListD1E2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Guidv7uuidListD1E2M.AssertModel(models[0],_testData[30], false);
                        Guidv7uuidListD1E2M.AssertModel(models[1],_testData[31], false);
                        Guidv7uuidListD1E2M.AssertModel(models[2],_testData[32], false);
                        Guidv7uuidListD1E2M.AssertModel(models[3],_testData[33], false);
                        Guidv7uuidListD1E2M.AssertModel(models[4],_testData[34], false);
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
                await ((IGuidv7ListuuidListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 15, query1, 127, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems2[3],_testData[34], false);
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
                await ((IGuidv7ListuuidListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 15, query1, 38, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[23],_testData[34], false);
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
                 ((IGuidv7ListuuidListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 100, query1, 21, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[9],_testData[34], false);
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
                 ((IGuidv7ListuuidListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 100, query1, 63, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(secondItems1[17],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidv7ListuuidListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 100, query1, 107, query2))
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
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatGuidv7uuidListD1E2M.AssertModel(models[0],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[1],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[2],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[3],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[4],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[5],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[6],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[7],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[8],_testData[34], false);
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
                await ((IGuidv7ListuuidListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 77, query1, 128, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[15],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidv7ListuuidListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 136, query1, 9, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatGuidv7uuidListD1E2M.AssertModel(models[0],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(models[1],_testData[34], false);
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
                 ((IGuidv7ListuuidListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 58, query1, 32, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatGuidv7uuidListD1E2M.AssertModel(firstItems1[18],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidv7ListuuidListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 27, 119))
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        Guidv7uuidListD1E2M.AssertModel(models[0],_testData[29], false);
                        Guidv7uuidListD1E2M.AssertModel(models[1],_testData[30], false);
                        Guidv7uuidListD1E2M.AssertModel(models[2],_testData[31], false);
                        Guidv7uuidListD1E2M.AssertModel(models[3],_testData[32], false);
                        Guidv7uuidListD1E2M.AssertModel(models[4],_testData[33], false);
                        Guidv7uuidListD1E2M.AssertModel(models[5],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidv7ListuuidListD1)this).DbConnectionSTSelectModelBatch(connection, 12, 32))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Guidv7uuidListD1E2M.AssertModel(models[0],_testData[4], false);
                        Guidv7uuidListD1E2M.AssertModel(models[1],_testData[5], false);
                        Guidv7uuidListD1E2M.AssertModel(models[2],_testData[6], false);
                        Guidv7uuidListD1E2M.AssertModel(models[3],_testData[7], false);
                        Guidv7uuidListD1E2M.AssertModel(models[4],_testData[8], false);
                        Guidv7uuidListD1E2M.AssertModel(models[5],_testData[9], false);
                        Guidv7uuidListD1E2M.AssertModel(models[6],_testData[10], false);
                        Guidv7uuidListD1E2M.AssertModel(models[7],_testData[11], false);
                        Guidv7uuidListD1E2M.AssertModel(models[8],_testData[12], false);
                        Guidv7uuidListD1E2M.AssertModel(models[9],_testData[13], false);
                        Guidv7uuidListD1E2M.AssertModel(models[10],_testData[14], false);
                        Guidv7uuidListD1E2M.AssertModel(models[11],_testData[15], false);
                        Guidv7uuidListD1E2M.AssertModel(models[12],_testData[16], false);
                        Guidv7uuidListD1E2M.AssertModel(models[13],_testData[17], false);
                        Guidv7uuidListD1E2M.AssertModel(models[14],_testData[18], false);
                        Guidv7uuidListD1E2M.AssertModel(models[15],_testData[19], false);
                        Guidv7uuidListD1E2M.AssertModel(models[16],_testData[20], false);
                        Guidv7uuidListD1E2M.AssertModel(models[17],_testData[21], false);
                        Guidv7uuidListD1E2M.AssertModel(models[18],_testData[22], false);
                        Guidv7uuidListD1E2M.AssertModel(models[19],_testData[23], false);
                        Guidv7uuidListD1E2M.AssertModel(models[20],_testData[24], false);
                        Guidv7uuidListD1E2M.AssertModel(models[21],_testData[25], false);
                        Guidv7uuidListD1E2M.AssertModel(models[22],_testData[26], false);
                        Guidv7uuidListD1E2M.AssertModel(models[23],_testData[27], false);
                        Guidv7uuidListD1E2M.AssertModel(models[24],_testData[28], false);
                        Guidv7uuidListD1E2M.AssertModel(models[25],_testData[29], false);
                        Guidv7uuidListD1E2M.AssertModel(models[26],_testData[30], false);
                        Guidv7uuidListD1E2M.AssertModel(models[27],_testData[31], false);
                        Guidv7uuidListD1E2M.AssertModel(models[28],_testData[32], false);
                        Guidv7uuidListD1E2M.AssertModel(models[29],_testData[33], false);
                        Guidv7uuidListD1E2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                ((IGuidv7ListuuidListD1)this).SetDbConnectionSelectModelParametrs(cmd, 77);
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
                ((IGuidv7ListuuidListD1)this).SetDbConnectionSelectModelParametrs(cmd, 136);
                var models =  ((IGuidv7ListuuidListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(2));

                Guidv7uuidListD1E2M.AssertModel(models[0],_testData[33], false);
                Guidv7uuidListD1E2M.AssertModel(models[1],_testData[34], false);
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

