

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
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("95ddd429-bddc-4738-a1a4-f580160f5f98"),

Guid.Parse("b48eb361-838b-4178-9a00-9bf7c7df2c9b"),

Guid.Parse("cdaa2d3b-225e-4b4f-8d0d-1e9ca3c76ef2"),

Guid.Parse("f357960d-b89e-42e4-8c63-44d20c53f534"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1d188bef-8dd8-4faf-a115-f2ff4ad7f70b"),

Guid.Parse("06081441-ca6e-4e94-a200-8a55deb39ca4"),

Guid.Parse("3e8b7c2e-aada-4345-93e5-28d875e5b039"),

Guid.Parse("04769068-4cec-4bcb-b139-0caff2269dce"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f5885b97-4361-4e47-b027-de0c1699235f"),

Guid.Parse("54930400-d613-4fe5-b9e6-f557f8272929"),

Guid.Parse("8895fdcd-d512-41a4-bbda-f527805275e6"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("28b1b4e2-588c-4053-9834-c8483e9aef6d"),

Guid.Parse("e662b458-0226-49b6-a99f-d381135ac2c1"),

Guid.Parse("dcbc6a21-23ca-4d7a-885f-e9959aa40a82"),

Guid.Parse("602910a9-0093-4829-8f97-9941c35aa603"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("98a56ac6-ca56-42ec-b7bf-edd1009629a8"),

Guid.Parse("7624aa65-6c47-4f22-b0dc-946b6ee0b905"),

Guid.Parse("1fdba082-5922-44ec-9bdf-ac5fc806b736"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d97199c1-a6f6-4c30-a541-1af432a2a141"),

Guid.Parse("48f3364f-6d5d-45f0-bc50-c7701cb59d07"),

Guid.Parse("2c25ec37-926e-4ccd-8cdc-62e5b54668aa"),

Guid.Parse("f5d0d3dc-f43d-4f48-b2d2-7ec4189caa2a"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("67f79355-c103-4fe3-9682-ebbc71f7dfee"),

Guid.Parse("0a119ffc-06a2-4b7e-a0fe-08c29f65d558"),

Guid.Parse("ec3c9472-2baa-49fc-850e-e14b4aa9bc75"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("a37ecf60-9b58-4666-b5f4-d705f3613e25"),

Guid.Parse("7c4ab4d5-69a9-4900-8a40-42a302e6b3ba"),

Guid.Parse("99de8010-ffb0-4ff1-b12f-0443f56cb014"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b5790f7e-d8f1-4c77-9add-de7863f56739"),

Guid.Parse("d80f7f1c-0d7d-4e50-8b97-6b418e6d97c0"),

Guid.Parse("e5a856a2-c7a5-407e-866d-45557cc28f86"),

Guid.Parse("39c76a75-c903-47c3-8e8a-0bde8cb897f3"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c8b32eea-34a2-4848-bf7e-81b07119006d"),

Guid.Parse("7fcd175a-6a08-4506-80e5-191b2f487af8"),

Guid.Parse("e7507201-83f9-4927-9078-be069b7ca4ed"),

Guid.Parse("60ddd110-22db-42c2-b99d-046f58c48738"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5da163e1-dae5-4bee-979c-87c93d57e817"),

Guid.Parse("ad542929-f6cf-4476-b957-c65e2c89ad1d"),

Guid.Parse("8f815290-4ef7-4591-9683-6a59a267e6a1"),

Guid.Parse("651ec6a1-f080-4c61-8938-9c3cd9ad8a53"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c0d0eb54-3904-44ed-b4bf-2709f9c45f02"),

Guid.Parse("b31aa8c1-1d89-46f0-b71e-73478f6664c7"),

Guid.Parse("3225e3d7-0683-411f-8711-e90ae3c41c0a"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2365e6c6-24ab-46eb-8c2f-6175cf6499ef"),

Guid.Parse("6e958da2-f297-4ad7-8f0e-2300bdee2a1f"),

Guid.Parse("b23b91a8-bdba-4be8-9153-131624575a99"),

},
},
            new GuiduuidArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("80e5e386-653c-4d2d-b457-dd44da1d6a9e"),

Guid.Parse("8512fcf6-6118-40f8-ba7d-50656dcba60a"),

Guid.Parse("727d4321-bc63-44f5-8cac-8dbd9bbd84e3"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("73c01e3b-7fc8-44aa-ade4-8010a7ff9420"),

Guid.Parse("3cba54a9-1f64-465c-935b-59c96b3ae38d"),

Guid.Parse("021bc9d7-4bfa-4492-977b-96745088fa5d"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("45aa721c-9aaf-48c0-a302-012d0d4f13f3"),

Guid.Parse("bd992d4e-80a4-41ea-933c-43f01e4285c3"),

Guid.Parse("ba3e113b-70fc-43c3-ad4d-d4cc6dc6c38d"),

Guid.Parse("758cd662-b7e2-423e-9745-d44e868f1efc"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b6eec572-b0da-4030-b6ee-91046316f456"),

Guid.Parse("68769c47-0436-4fda-ae32-2fbbc88a6fc2"),

Guid.Parse("50d4d5b1-d151-44ae-825d-bd93f2f86ea8"),

Guid.Parse("8fc8416c-e74c-4dfb-80ea-d0b9db269edd"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5c2c3687-352f-4dc6-905b-b43406c11724"),

Guid.Parse("1005292c-3f59-4e8c-be11-58fcd2099089"),

Guid.Parse("4c572f04-c5e3-4501-99cc-b83fac37c290"),

},
},
            new GuiduuidArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("62639a67-ac5d-4518-beb7-b9e8cf70009a"),

Guid.Parse("4e76bc47-6fbe-4f71-ba29-a1feea736451"),

Guid.Parse("aa478be3-2633-43b7-81e7-74ab7a384563"),

Guid.Parse("0e29f6bf-3bbb-431a-8cc3-ea9f8bfbf595"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("162ea165-526f-4d5e-9014-f529f8ec976e"),

Guid.Parse("eeab3c30-0c64-414d-bbd1-3b074bea6692"),

Guid.Parse("c7a49a1f-900e-4224-913b-6dc4617ff23a"),

Guid.Parse("04e6f411-6642-4a5c-96b1-402bb032622a"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c687216d-67f5-471e-bd8f-c11772568855"),

Guid.Parse("a895a322-1481-46ce-9ea7-2eb74af64e26"),

Guid.Parse("a91d9307-42d7-4041-ac82-edbf5e307447"),

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
Guid.Parse("e7ce2225-4301-4c8f-8cb6-027c15b3d9d3"),

Guid.Parse("4c02ddda-354b-44bb-8944-90490fae9f88"),

Guid.Parse("397e9497-b632-4abe-b428-83f7c6a2261b"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3d2e44be-96ac-459b-be80-96dc9b125a5e"),

Guid.Parse("81766fca-691a-4f44-8909-ad0b3a3cc634"),

Guid.Parse("7c5a5470-2dd5-4228-bb0e-90df41e1d57b"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("49a8c083-cb8c-4593-a0f7-eba16c08ec66"),

Guid.Parse("5a69f7bd-84cc-4ea1-8acb-601a70bb21c4"),

Guid.Parse("0ba12247-06be-4183-b22b-c8a1d8e3500e"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5e183021-ffc9-4673-9fab-d146a40c0396"),

Guid.Parse("9c0bf97b-b2d3-4e0b-b396-1f1242753f80"),

Guid.Parse("f117be80-685d-4cb6-b3e1-c1b73fc1fb3f"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("1e85cb4e-670e-4369-95cc-2f35d4cb8d8e"),

Guid.Parse("0b96eaf1-3821-4949-9bed-12d85b792767"),

Guid.Parse("89d297d7-b944-4437-b692-347225e28eae"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b4be669d-2d4a-44a8-a874-45cdcb2c7c4a"),

Guid.Parse("23926e5a-f1da-461a-9871-9642727320ad"),

Guid.Parse("08cf82b1-6c96-48a8-86c2-ab7ac3706275"),

Guid.Parse("80475b83-6452-4b93-9789-ec83eca30068"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ad5ecfa2-fd58-41e5-aff2-ab9d33ba7db5"),

Guid.Parse("eded454e-c658-4bba-9a86-dfff43720e5e"),

Guid.Parse("f05f4ee5-05cc-46ba-8068-dbc9fccc627f"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b63d7d26-79eb-4820-95d6-9d0a3cc9d121"),

Guid.Parse("54e03369-7009-4a20-8728-9b4394658484"),

Guid.Parse("9345f468-a771-4da0-80d0-c0ca4f32327c"),

Guid.Parse("2ac63760-e12b-42ed-939d-f2e63a52c6e8"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("87ffc7f4-5b4c-4643-8163-90d69fb41e38"),

Guid.Parse("d86d7f51-7c27-45bc-a812-effb873bffce"),

Guid.Parse("0a3fbb61-5df6-4303-9c95-c82f01d23eeb"),

Guid.Parse("e26554dd-7c43-4e7d-89fb-414c3dc9825f"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0729cc74-3b18-47cc-88a7-6786ada8d630"),

Guid.Parse("d788452c-ec06-4750-a478-6c63d5042a75"),

Guid.Parse("2fca8739-a2a1-42e6-9721-80d6ee0f7b12"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ad4ecd66-8ab0-4d6d-97fb-2441e4dcc7eb"),

Guid.Parse("3cdd39f1-8c66-4dfd-9f78-2586353da896"),

Guid.Parse("ea1255e7-2590-4e86-a2f3-e8b81a2a2850"),

},
},
            new GuiduuidArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("8a52901f-101c-4e6b-a2cf-f881ac3138c9"),

Guid.Parse("e303429e-520d-44b2-b9e3-b54070a9043e"),

Guid.Parse("e688e115-9a80-461f-9e5b-9ea9ec794c6e"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e96cd50c-ae10-49d2-a48c-dfba02109663"),

Guid.Parse("f380a63b-f0e9-4d93-9e72-c665d0075a6d"),

Guid.Parse("076d4890-a554-4d08-83b1-1cd08de17a33"),

},
},
            new GuiduuidArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("11d64e24-504c-4ae5-9899-d2d1516e711b"),

Guid.Parse("798a8e52-2f82-4884-b8d9-d9f56f8731b7"),

Guid.Parse("b40a3e06-579d-4437-95f8-ec2f0f2c5318"),

Guid.Parse("7bb2b2f6-1fb6-4b63-a16d-a8b17fe97c52"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("fce623e7-440b-4c87-a47f-1913d7457e02"),

Guid.Parse("914a7918-9ecb-4661-873d-9d33a35bed30"),

Guid.Parse("ea44d460-9a85-4e94-978e-026924f65505"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("178d9ee2-9ad6-41b9-ad04-7151a27d8542"),

Guid.Parse("a9123a43-f7e6-426f-bc8d-46382856bd04"),

Guid.Parse("2780bd8e-990a-4c68-bbb1-33b512becdef"),

},
},
            new GuiduuidArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("110bfb39-740d-4b98-87ad-94d686f725b1"),

Guid.Parse("6789cebb-a168-4c00-a40d-d09d16149b2b"),

Guid.Parse("04a33165-c0b0-47aa-8cf1-519b7d54b239"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("37a2d7eb-0fc7-41e6-9330-f9232946d5a2"),

Guid.Parse("3ba94606-b68a-4dff-928b-acae1589fb65"),

Guid.Parse("1aab91d7-20d4-4f39-b1c4-743e8c6db195"),

Guid.Parse("768871dc-2088-4a55-8fe6-2fdb74ca3bd1"),

},
},
            new GuiduuidArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("bace8b34-5bde-41ca-8fcd-2fc68ca250b1"),

Guid.Parse("599ad033-8fed-4a3b-a1f4-61cbc4b19540"),

Guid.Parse("05235313-52ff-4022-8b4a-ebbff6a390e5"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("38afd722-05f4-45cb-b5d1-593c431f30a0"),

Guid.Parse("33db7538-c41e-4a66-90b4-544203c1fb00"),

Guid.Parse("5623cf3f-77de-4391-a984-fc6cb8ee0ab4"),

Guid.Parse("71e73c5b-e657-455d-b980-224bb1c52071"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("576a7b21-fb60-4f74-a437-3f624cb17716"),

Guid.Parse("badde0d2-4622-4609-8532-e782667c4034"),

Guid.Parse("5258f0c7-5b10-4b0a-8c20-2965cd9d73c0"),

Guid.Parse("bac0f744-94b1-4fcd-a730-1adb28076d04"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ae6c81cd-481d-40fa-a14c-713a63a92cba"),

Guid.Parse("17f67ee6-ca2b-4024-af4e-30f23ba35376"),

Guid.Parse("a2ac76ac-7beb-4bdf-b5c0-39ca3e353868"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("917054b1-67c6-4e3a-9de4-9420a2a68fbc"),

Guid.Parse("c08a54be-5864-4c7b-8144-db06e421c4d9"),

Guid.Parse("1036085c-90a6-4f20-bae7-3f36999aaf0a"),

Guid.Parse("bfb59ad1-dac4-406e-ae66-6337d0105242"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("d69f9f19-a1d9-4cf4-9e7b-d13e0aa83de5"),

Guid.Parse("1196cdb1-79df-4fc2-8785-eced87d54060"),

Guid.Parse("9c4a378f-1cb4-48ce-aff9-9cb332dc9138"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("75d809e1-e82d-4869-8a3b-335090e9020f"),

Guid.Parse("97b915ef-a4d2-4631-9722-650a9721e39e"),

Guid.Parse("10e1ce64-a1e2-4d5b-abaa-5f82222b7f94"),

Guid.Parse("c96059dd-de2d-4be0-93d9-496a0c9d2f55"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("8de96d03-88b3-47ee-bea2-24488f71af18"),

Guid.Parse("b306a28c-7959-4007-a5c0-775797a6f6a1"),

Guid.Parse("2f09c814-92af-4ef8-87da-548e24ea80f8"),

Guid.Parse("3176fd23-8aed-49cd-84b2-92d4b6e22653"),

},
},
            new GuiduuidArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("8ad2b717-9736-497a-93c5-e4837e11c921"),

Guid.Parse("3ad31092-98a1-44b8-a269-10e995bbb6fa"),

Guid.Parse("432dee4c-ba6d-4d38-9d6c-c5199527e4e8"),

Guid.Parse("258debab-d829-4b69-98de-55bd2f53140e"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("aeffc9b6-118f-4079-8fa1-1f54d2e6cc4a"),

Guid.Parse("edfcf341-ff82-4b68-830d-4fed396f912d"),

Guid.Parse("3b178e99-a840-47d6-a5d1-1b6a09cff10c"),

},
},
            new GuiduuidArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("182d2e97-06f6-49ad-b750-afb705ebace0"),

Guid.Parse("2a8081fb-608e-4c9b-881b-349115ca1af8"),

Guid.Parse("1047cff4-7a12-4676-b671-92fe045c3be9"),

Guid.Parse("786980f4-c30c-4261-9b7a-683f45be79bb"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a1d2fbde-db0a-4ca3-a8cb-878918e59420"),

Guid.Parse("a79b7f11-7da8-40ff-87ec-67c49bfcd3a7"),

Guid.Parse("c55e34fb-a72e-4c16-b7b9-dbddb8663528"),

Guid.Parse("d9bd3041-3196-4f15-8034-474e20513567"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("63227be8-be08-41aa-9805-3f23a895f67c"),

Guid.Parse("e3fffb7c-6e3f-4e56-9282-77393732b992"),

Guid.Parse("14c6ed41-6d39-4b67-a22c-f38327c581d9"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("40681eee-4671-449e-8581-90a32587b0a8"),

Guid.Parse("07b66bfa-47ca-4ef2-89b7-e2d2297782be"),

Guid.Parse("c57e5a63-67ae-4480-ad1c-df943774fd99"),

Guid.Parse("f7bb15a0-b18c-4ceb-b3b4-0a0a0512edf0"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("50f832cc-b370-488b-b0c0-fcdc794e9da6"),

Guid.Parse("c8cb0a17-7e7f-49d7-89b1-4d79e9b0a3cc"),

Guid.Parse("ae8f1050-3e8d-4f76-8d64-5237b151edd3"),

Guid.Parse("5336aac7-c744-4c2b-9bc0-b671deb38107"),

},
},
            new GuiduuidArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e79f4ecc-327a-45e5-96d1-19e184c87cc7"),

Guid.Parse("42d7a6fc-26c3-4dcd-959d-8ca4f3d9d8fe"),

Guid.Parse("e7ca5e34-c443-4de1-9ad6-70a3ab15a9dd"),

Guid.Parse("21fa0011-ebfa-4020-a5c6-a02d61f401e6"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("886ae312-64a7-45cc-b1ef-91b35f9f19f2"),

Guid.Parse("01607fe6-0d15-4b47-8f90-9499a2250828"),

Guid.Parse("eae63d75-4167-4587-8b1f-bbe2d8eb922d"),

Guid.Parse("25beb705-0ad1-4567-84cb-329d58845888"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("dc4381be-3c1e-4713-b49e-d4224326f119"),

Guid.Parse("6fd3e0f5-7295-469e-b9ed-f9ee26b0a499"),

Guid.Parse("a7bf2b6d-05e2-44df-9b51-08147b0e8020"),

Guid.Parse("f0d64114-f10b-4c02-bd5a-d82a8269a84b"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("80f8486f-9372-4107-853d-14c695b629a1"),

Guid.Parse("d2e92120-877e-4648-a820-e82b7c72b857"),

Guid.Parse("8b591f45-437b-4541-b7cd-02f758f076f1"),

},
},
            new GuiduuidArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("0e15c2bd-2ff8-4dac-8a13-5a8b95836203"),

Guid.Parse("c545357b-72e2-4a66-8c0d-3d2155b38456"),

Guid.Parse("05fa1043-2e5c-474c-8b31-44fe201b3b88"),

Guid.Parse("4b10d009-995e-4bf0-bd91-6d22369974be"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("36b430bb-b9c4-446a-8871-b055eddc780f"),

Guid.Parse("1b9d847d-b14c-4360-90b4-f84a320423a9"),

Guid.Parse("0085b36a-bbf3-4ea1-9c86-549a01159094"),

Guid.Parse("b2be51ad-c745-49ff-950b-3aa39da0e03b"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("57560f5a-5bbe-4a36-9df8-0f45d6e5a5d5"),

Guid.Parse("7a0a0509-f4e8-4e76-8fc8-7bfdf0729721"),

Guid.Parse("f81ae97d-8f5d-4103-8493-9f0b08f4175e"),

Guid.Parse("8939b398-01e3-4a94-be1e-67f0cb7815f9"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("06f8dcfd-0493-4126-a2a8-7976792e53bf"),

Guid.Parse("a22e9721-860f-44de-b064-2f5834be829c"),

Guid.Parse("fdf3361a-7337-4a21-82bd-e8aeca083945"),

Guid.Parse("e6012f67-1df7-42b3-af1f-04b1a9e896ec"),

},
},
            new GuiduuidArray2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("603e0dfe-5926-48b6-a774-a7f746e07b01"),

Guid.Parse("5beb3418-f4a7-4b7b-9857-05e76c27ed4c"),

Guid.Parse("1db931ab-3c6f-4c9b-acd1-1906a0fef0f0"),

Guid.Parse("f3aba507-f412-4f35-85b3-92dcb6483e6b"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("dec2e2e0-d498-46d5-bcbf-60fcc85ae313"),

Guid.Parse("c2cacede-601f-424c-8f6b-a79a6547f122"),

Guid.Parse("04e2d134-f5c9-4c0a-8bca-ffc5df6fb48e"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("6d2ef18c-a919-4ab2-8789-ac705eef7153"),

Guid.Parse("5e978d08-97db-4c67-a176-8e9ced93b455"),

Guid.Parse("3457998e-0892-412e-92b3-d1afa41e6e06"),

Guid.Parse("3c3f52f6-ba5a-4c84-85b2-f27197b264d5"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b6a24bc8-2606-4168-8a1c-fa2232717f9a"),

Guid.Parse("b6e97e6e-0a61-4ec5-b045-ea9c07e5fe37"),

Guid.Parse("640247f7-23f6-45a4-b3fb-3f6ac84849d2"),

},
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 113;
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
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[1], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[19],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[20],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[21],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[22],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[23],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[24],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[25],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[26],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[27],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[25],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[19],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[20],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[21],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[22],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        GuiduuidArray2M.AssertModel(models[0],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        GuiduuidArray2M.AssertModel(models[0],_testData[13], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        GuiduuidArray2M.AssertModel(models[0],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        GuiduuidArray2M.AssertModel(models[0],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
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
                await ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 37, query1, 142, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                await ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 56, query1, 107, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
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
                 ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 103, query1, 135, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                 ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 63, query1, 92, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 35, query1, 72, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[19],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[20],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[21],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[22],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[29], false);
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
                int resultIndex = 0;
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
                await ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 56, query1, 144, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 113, query1, 12, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[19],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[20],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[21],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[22],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[23],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[24],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[25],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[26],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[27],_testData[29], false);
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
                int resultIndex = 0;
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
                 ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 12, query1, 80, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTSelectModelBatchAsync(connection, 87, 28))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        GuiduuidArray2M.AssertModel(models[0],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        GuiduuidArray2M.AssertModel(models[0],_testData[5], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[6], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[7], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[8], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[9], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[10], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[11], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[12], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[13], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[19],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[20],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[21],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[22],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[23],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[24],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTSelectModelBatch(connection, 107, 28))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        GuiduuidArray2M.AssertModel(models[0],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        GuiduuidArray2M.AssertModel(models[0],_testData[5], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[6], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[7], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[8], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[9], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[10], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[11], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[12], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[13], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[19],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[20],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[21],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[22],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[23],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[24],_testData[29], false);
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
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 12);
                var models = await ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
GuiduuidArray2M.AssertModel(models[0],_testData[2], false);GuiduuidArray2M.AssertModel(models[1],_testData[3], false);GuiduuidArray2M.AssertModel(models[2],_testData[4], false);GuiduuidArray2M.AssertModel(models[3],_testData[5], false);GuiduuidArray2M.AssertModel(models[4],_testData[6], false);GuiduuidArray2M.AssertModel(models[5],_testData[7], false);GuiduuidArray2M.AssertModel(models[6],_testData[8], false);GuiduuidArray2M.AssertModel(models[7],_testData[9], false);GuiduuidArray2M.AssertModel(models[8],_testData[10], false);GuiduuidArray2M.AssertModel(models[9],_testData[11], false);GuiduuidArray2M.AssertModel(models[10],_testData[12], false);GuiduuidArray2M.AssertModel(models[11],_testData[13], false);GuiduuidArray2M.AssertModel(models[12],_testData[14], false);GuiduuidArray2M.AssertModel(models[13],_testData[15], false);GuiduuidArray2M.AssertModel(models[14],_testData[16], false);GuiduuidArray2M.AssertModel(models[15],_testData[17], false);GuiduuidArray2M.AssertModel(models[16],_testData[18], false);GuiduuidArray2M.AssertModel(models[17],_testData[19], false);GuiduuidArray2M.AssertModel(models[18],_testData[20], false);GuiduuidArray2M.AssertModel(models[19],_testData[21], false);GuiduuidArray2M.AssertModel(models[20],_testData[22], false);GuiduuidArray2M.AssertModel(models[21],_testData[23], false);GuiduuidArray2M.AssertModel(models[22],_testData[24], false);GuiduuidArray2M.AssertModel(models[23],_testData[25], false);GuiduuidArray2M.AssertModel(models[24],_testData[26], false);GuiduuidArray2M.AssertModel(models[25],_testData[27], false);GuiduuidArray2M.AssertModel(models[26],_testData[28], false);GuiduuidArray2M.AssertModel(models[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidListuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 135);
                var models =  ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(6));
GuiduuidArray2M.AssertModel(models[0],_testData[24], false);GuiduuidArray2M.AssertModel(models[1],_testData[25], false);GuiduuidArray2M.AssertModel(models[2],_testData[26], false);GuiduuidArray2M.AssertModel(models[3],_testData[27], false);GuiduuidArray2M.AssertModel(models[4],_testData[28], false);GuiduuidArray2M.AssertModel(models[5],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MI)],
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
        private void ImportModelInnerConfig()
        {
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
            queryMapTypes: [typeof(GuiduuidArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<GuiduuidArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IGuidListuuidArray)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidListuuidArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(actual, expect, false);
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
                await ((IGuidListuuidArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IGuidListuuidArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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
            queryMapTypes: [typeof(GuiduuidArray2M)],
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<GuiduuidArray2M>(15);

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
                ((IGuidListuuidArray)this).ImportModel(connection, importCollection);
                var models = ((IGuidListuuidArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                GuiduuidArray2M.AssertModel(models[0],_testData[0], false);
                GuiduuidArray2M.AssertModel(models[1],_testData[1], false);
                GuiduuidArray2M.AssertModel(models[2],_testData[2], false);
                GuiduuidArray2M.AssertModel(models[3],_testData[3], false);
                GuiduuidArray2M.AssertModel(models[4],_testData[4], false);
                GuiduuidArray2M.AssertModel(models[5],_testData[5], false);
                GuiduuidArray2M.AssertModel(models[6],_testData[6], false);
                GuiduuidArray2M.AssertModel(models[7],_testData[7], false);
                GuiduuidArray2M.AssertModel(models[8],_testData[8], false);
                GuiduuidArray2M.AssertModel(models[9],_testData[9], false);
                GuiduuidArray2M.AssertModel(models[10],_testData[10], false);
                GuiduuidArray2M.AssertModel(models[11],_testData[11], false);
                GuiduuidArray2M.AssertModel(models[12],_testData[12], false);
                GuiduuidArray2M.AssertModel(models[13],_testData[13], false);
                GuiduuidArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((IGuidListuuidArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IGuidListuuidArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                GuiduuidArray2M.AssertModel(models[0],_testData[0], false);
                GuiduuidArray2M.AssertModel(models[1],_testData[1], false);
                GuiduuidArray2M.AssertModel(models[2],_testData[2], false);
                GuiduuidArray2M.AssertModel(models[3],_testData[3], false);
                GuiduuidArray2M.AssertModel(models[4],_testData[4], false);
                GuiduuidArray2M.AssertModel(models[5],_testData[5], false);
                GuiduuidArray2M.AssertModel(models[6],_testData[6], false);
                GuiduuidArray2M.AssertModel(models[7],_testData[7], false);
                GuiduuidArray2M.AssertModel(models[8],_testData[8], false);
                GuiduuidArray2M.AssertModel(models[9],_testData[9], false);
                GuiduuidArray2M.AssertModel(models[10],_testData[10], false);
                GuiduuidArray2M.AssertModel(models[11],_testData[11], false);
                GuiduuidArray2M.AssertModel(models[12],_testData[12], false);
                GuiduuidArray2M.AssertModel(models[13],_testData[13], false);
                GuiduuidArray2M.AssertModel(models[14],_testData[14], false);
                GuiduuidArray2M.AssertModel(models[15],_testData[15], false);
                GuiduuidArray2M.AssertModel(models[16],_testData[16], false);
                GuiduuidArray2M.AssertModel(models[17],_testData[17], false);
                GuiduuidArray2M.AssertModel(models[18],_testData[18], false);
                GuiduuidArray2M.AssertModel(models[19],_testData[19], false);
                GuiduuidArray2M.AssertModel(models[20],_testData[20], false);
                GuiduuidArray2M.AssertModel(models[21],_testData[21], false);
                GuiduuidArray2M.AssertModel(models[22],_testData[22], false);
                GuiduuidArray2M.AssertModel(models[23],_testData[23], false);
                GuiduuidArray2M.AssertModel(models[24],_testData[24], false);
                GuiduuidArray2M.AssertModel(models[25],_testData[25], false);
                GuiduuidArray2M.AssertModel(models[26],_testData[26], false);
                GuiduuidArray2M.AssertModel(models[27],_testData[27], false);
                GuiduuidArray2M.AssertModel(models[28],_testData[28], false);
                GuiduuidArray2M.AssertModel(models[29],_testData[29], false);
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_guiduuidarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IGuidListuuidArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidListuuidArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

