

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
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("6eb514bc-ba23-4326-8fb2-5be95ccc2b59"),

Guid.Parse("d68a099f-6445-46f7-a950-4c33bee05924"),

Guid.Parse("69da2290-fd36-4977-8f05-e35b275d4443"),

Guid.Parse("def6eda3-1795-47d4-89af-c74f9a987408"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5a582040-64ea-4483-8379-3ad9d1639344"),

Guid.Parse("3086150d-fb63-4dc6-bba5-3f4cba43bcc2"),

Guid.Parse("48466b9e-ebc6-483a-a8d5-51ab2123fe9b"),

},
},
            new GuiduuidArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b1c92713-8635-4bd7-8367-dc49334f8312"),

Guid.Parse("b2740cff-1b15-44c4-adad-3ae7869309a0"),

Guid.Parse("c7f39db6-1bcf-4bd1-8811-912eb3099902"),

Guid.Parse("c71e3f33-7bf3-48ab-bf86-d850e63f5b27"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("faa3aefa-fa6a-4676-8c5e-32f87885895b"),

Guid.Parse("1edc2e7d-da4d-48bb-a15f-3e1826812a5d"),

Guid.Parse("d9f14574-364c-44d0-a878-804f18b971f0"),

Guid.Parse("b45209a2-4510-47dc-b15b-a154eae07d08"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b5b68037-2c40-49e4-a9b2-3d151717d09b"),

Guid.Parse("983d52f4-a5bd-46b6-aae2-7ed20e0558db"),

Guid.Parse("33a91769-cafc-4877-b3e0-7e9e0ed327ee"),

Guid.Parse("2bd7a750-efca-445f-8202-0e1473716852"),

},
},
            new GuiduuidArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f193ccdd-e3ad-4ffe-bda1-5d26ae957560"),

Guid.Parse("8c3135ed-f577-415f-92a0-f051e60174ca"),

Guid.Parse("eaac8b26-b20b-4d74-9d40-9afa03c021e6"),

Guid.Parse("79863537-ed1d-4027-a83a-cabf4a31c70f"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9098b66c-9d62-4d1f-943b-b90dfe116ad8"),

Guid.Parse("50bb43bc-770a-4380-a69b-dce4b35db48f"),

Guid.Parse("04392841-cbf5-4012-9261-e7c03365555b"),

},
},
            new GuiduuidArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("80a6c992-cb3e-47b0-a781-cadc18b2539d"),

Guid.Parse("0871dff2-a24b-4c34-96cd-2028da918baa"),

Guid.Parse("b35265c3-f87c-43f0-98a7-900907cf8bc9"),

Guid.Parse("1854bf94-cb12-468d-919c-f754d9de68a5"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("8b2e0599-36a5-46e6-84db-281261889770"),

Guid.Parse("d875637c-6654-4e03-98ec-196685a3e285"),

Guid.Parse("5b840bcd-5136-4493-99b2-4e584a10dea7"),

Guid.Parse("b7beaaab-476c-4b48-96ce-11dc642764ca"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f4395ab4-4ff9-46fc-b78c-875603e635b9"),

Guid.Parse("d2471651-6c3f-4552-b71d-aad8795895f5"),

Guid.Parse("265b5340-7318-402b-bcff-f154626db6af"),

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
Guid.Parse("273599d1-df51-44fd-adfb-f4eafdae83cf"),

Guid.Parse("e0b03945-6d10-4c04-a272-951ab199046d"),

Guid.Parse("d2c47137-4d90-4650-8000-b7c56e2b76df"),

Guid.Parse("985aced1-dfe3-421c-b1c0-a500859f64e2"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("405b207f-3f62-4928-b194-a5bb1a69b017"),

Guid.Parse("af5b8a27-445a-4320-9452-68e8abb418c5"),

Guid.Parse("967e644e-8fb4-4fd6-8a1a-a2bd92d3662e"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ab7c359d-6d18-4d31-b4a5-52e2b6f10a61"),

Guid.Parse("c48d0869-9a82-4c85-b9c8-0cd52701e223"),

Guid.Parse("7cb43692-ce49-4854-9323-dbbce205824d"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("668a6ba2-e030-4f20-babd-549c1d319451"),

Guid.Parse("19419273-50f8-4131-81ed-e3c945ff6ea3"),

Guid.Parse("ddfe3e95-5837-4726-98c3-5906a8b0c336"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c293c399-2cad-4b8a-b17e-5a51028f23ce"),

Guid.Parse("7250d9e0-7634-47b0-8225-acdb7669cf56"),

Guid.Parse("24d6fc09-56f4-4d4f-89ad-d0310a06061f"),

},
},
            new GuiduuidArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("0e938744-f3f8-4c52-b33b-37524e5a761a"),

Guid.Parse("349fb056-9ef3-4d94-8624-d123036e3546"),

Guid.Parse("6de979c8-0f98-4eca-b434-86a5ade21865"),

Guid.Parse("4257c8ac-9659-4450-a553-c196e08a80ac"),

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
Guid.Parse("ee7ff8c7-7bd3-4941-8870-f73d19702bfd"),

Guid.Parse("94aed9e7-4602-4e9a-8c4a-6c5f771d666b"),

Guid.Parse("8b4dabd8-2c84-4fd5-af11-870711d3520d"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3b754617-80d1-4a46-8831-57cb02aaffec"),

Guid.Parse("13f0fc0e-bf10-4494-84cb-c1da36744157"),

Guid.Parse("8837e7e3-3d08-4e5e-b8a0-5f6a82102060"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e6570fc5-8ba5-4c64-8e33-138ca9db3130"),

Guid.Parse("5d8a2630-8254-4843-800a-eef5f728823c"),

Guid.Parse("e69baa54-d78f-44b6-aa78-be3edd25e86a"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f0442914-df3c-4300-8f03-0230fe19b0cc"),

Guid.Parse("5d1cd8cb-d46b-40af-bd4c-8e60a1c24b94"),

Guid.Parse("34e0c0c1-9251-4cc9-b620-a560b99b7136"),

Guid.Parse("6fa00864-d253-4d27-a171-72c7dd6536cb"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ce819692-32c9-4bef-8860-eb31b177ee13"),

Guid.Parse("a3b6b706-2d5b-4545-85e0-79ded0c035c2"),

Guid.Parse("7341f716-4896-4e99-9cb2-f69f0c6e2533"),

Guid.Parse("14a071f6-a8df-477a-8898-bcba1072d493"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4498a8f2-ed8e-4f38-bdc3-01b7b980d989"),

Guid.Parse("35b2226c-59f9-46e6-a621-7a1c1f67f25f"),

Guid.Parse("fc2e8f65-5f68-4732-affb-c16769ae3995"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("52329568-5072-4491-86df-09c8337c7f24"),

Guid.Parse("ebe0b2e1-7946-44e3-80ec-bf85ccc93aa7"),

Guid.Parse("46954a9b-8f01-4f99-8f59-fa2e1fbde940"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ef826627-84f3-4aa3-a4a3-3893c862c181"),

Guid.Parse("9a1cb57b-1d89-4c0d-aa51-567f4ad67104"),

Guid.Parse("fec52680-9168-49f0-ac9f-86db7d798b7e"),

},
},
            new GuiduuidArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("bfd23d64-6052-46d4-a445-54d7dba328c1"),

Guid.Parse("acf23845-4285-4b18-9dba-264e723314fb"),

Guid.Parse("c9846036-1fe7-42da-b675-3893eaed0d73"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("691f64ce-1e13-45a0-8cf2-e6efad6c5bdc"),

Guid.Parse("00758bdc-fe04-4cad-9b4b-deb155c92192"),

Guid.Parse("d89d158f-db22-4cd1-be78-2c698759cc87"),

Guid.Parse("127e6803-db45-4696-a31e-d5fdab60cc5d"),

},
},
            new GuiduuidArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("71c9f903-c00b-46fd-b4ae-a8d45caffd34"),

Guid.Parse("e1c1c86b-7bab-49eb-a276-384e461b10d7"),

Guid.Parse("d21a2016-f4a0-4b46-b7a2-69bae674729f"),

Guid.Parse("1509c86f-b7b2-47fc-b187-3b6f92c4b209"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a56b5963-175d-4566-aa02-ae67c2d1e3df"),

Guid.Parse("742ab420-3522-4e72-a815-043200275513"),

Guid.Parse("ed2d4ee6-e64f-4ee4-86aa-517979a03121"),

Guid.Parse("9d3767f3-1eb5-423c-9764-06dfb737837a"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("94d77e55-1f26-428a-bbc5-4b8583ccc241"),

Guid.Parse("229db67f-cd86-484c-9532-be6f112beac0"),

Guid.Parse("e90959b9-9b59-4b81-ae91-c01b6e9d061a"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5f73e007-e34d-4201-9388-db99593a5c08"),

Guid.Parse("6f22fb5e-905f-4337-905e-0ebdd45f61e2"),

Guid.Parse("e8e6c3d0-f8cf-4120-8769-cb76ba2a5e46"),

},
},
            new GuiduuidArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("6ca85342-be1b-421a-a711-80edc74284e2"),

Guid.Parse("8b489fea-1471-448e-8051-0bb767cae63e"),

Guid.Parse("95c26328-880f-4948-95f3-31bca5e71157"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fc3c88d5-83cb-4ae7-9aba-7535fb9eb428"),

Guid.Parse("cd0ac1a1-6051-453a-b67e-b071f8473f0c"),

Guid.Parse("45d66816-a143-4929-9214-2eee028507c0"),

Guid.Parse("1c986558-adf7-46ab-a8d7-dc8c0bec5e67"),

},
},
            new GuiduuidArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0dbf9fd9-aa0b-41ed-8b80-82f82bb95a3a"),

Guid.Parse("0b160442-e130-4f28-9ca2-d748a4ab7a75"),

Guid.Parse("1010f161-ba2a-445d-978e-c224565037d0"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("95cf6b94-fe53-4240-9fb1-207277953dd3"),

Guid.Parse("8d606b56-9921-4906-a661-bbf27d021bc1"),

Guid.Parse("1eb7188b-c028-4d18-a8db-db7a5a32786f"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b0c2ecbf-217c-4226-abb0-14dcd09cbd01"),

Guid.Parse("98a3cdb7-0068-4488-8277-d48cf474d392"),

Guid.Parse("8941fc61-8a12-4985-95b4-37d265eaaf82"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c7d46418-a29a-4724-b5ca-2fe7aa9bf1f4"),

Guid.Parse("97684217-df31-41e3-993d-d9bef5ba3684"),

Guid.Parse("6bc0ce24-13b8-436c-b551-af6cc1b928be"),

Guid.Parse("095ba80b-d9b9-4cff-aa47-7a8386c328db"),

},
},
            new GuiduuidArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("739ce081-44f9-49d8-8533-3087e827b489"),

Guid.Parse("06c3dfec-9190-4c75-9e58-2bc69df8f9b3"),

Guid.Parse("3234fb2e-b9ce-4e98-b362-c86267912a34"),

Guid.Parse("1bc03458-4a66-4ffc-bb12-4e6182f7a49f"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5f57d968-2ae7-4cad-992b-6cf561304715"),

Guid.Parse("c966de00-3b9d-47b1-be5b-18bc64f176b8"),

Guid.Parse("b48f6a2b-dafa-49a8-b496-464bbaec3b93"),

Guid.Parse("e1286fcc-aa36-46ca-be35-b5f155fbded7"),

},
},
            new GuiduuidArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("6363f01c-efcc-43a7-a206-9baaf13a99c3"),

Guid.Parse("1374eb80-344b-4808-85d1-b2bc600ce9ef"),

Guid.Parse("1e9ea3e8-91d2-4c74-a0a3-b199de43f2c7"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("92884b1a-256d-440a-af77-7038a10655fd"),

Guid.Parse("0a8d4d52-34e5-4f88-9251-64313266d66f"),

Guid.Parse("ca91ca5d-8e06-4637-9acb-652932c9835c"),

Guid.Parse("0a18ca90-562a-4070-8a7f-7875a5f8d1f0"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("987bb570-47e0-4b75-be52-081533fa5986"),

Guid.Parse("fa0ce323-f5df-4b38-9c7d-8b8e06e11a74"),

Guid.Parse("56104222-addb-4f9a-80e0-0f982b16f896"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("287e0989-4b65-4e36-9c42-9fe5e07c3c19"),

Guid.Parse("c6847070-7f71-4f43-9915-2d846f32e705"),

Guid.Parse("30b1705e-14d8-4fc4-b607-642f9bb4239d"),

Guid.Parse("fa614283-bade-4b4a-8866-e96e3ab2225c"),

},
},
            new GuiduuidArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c53bba17-1415-47e7-ad5a-8039e4b3bc50"),

Guid.Parse("38d1f463-cc0a-4429-a2bb-e3a2d457b50a"),

Guid.Parse("62e1811f-2019-4c5c-9179-85b7901e6ab4"),

Guid.Parse("e97aea96-8def-4688-acc2-933d21286684"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("31f71d20-020a-4634-88bb-c81da90c0f3d"),

Guid.Parse("e0376b79-e0fc-4878-979c-93eccc80c55f"),

Guid.Parse("07935498-753c-4947-bfb2-e1a908037b5d"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("61f9be01-45f2-45a4-8702-9b2dce4f1445"),

Guid.Parse("279e4c88-caa5-46a8-b4e9-17521f39804e"),

Guid.Parse("0ad88af9-5fb4-44ce-9a6f-867cc1634775"),

Guid.Parse("db67aeae-277f-4ae7-93a0-8c8a4f13a8a2"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("dbdc7e4f-d6a4-4327-863f-1784c73cf52b"),

Guid.Parse("bb594363-c8ba-4f5c-b5ec-03c47a7789c7"),

Guid.Parse("0bba41d9-2ec9-4c97-a161-ca680b6811db"),

Guid.Parse("ff89cdc3-7133-494a-b456-dfd3636af839"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b4ebedb1-eb33-4217-8ae4-b47c7766d2ac"),

Guid.Parse("ec97886a-05db-490e-aab5-c31ccffe2a99"),

Guid.Parse("b16d256a-8c2f-4fb8-8a45-d5e629f2d9ff"),

Guid.Parse("67db3d49-f000-4dc6-9915-683d701dc4f5"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7f200316-dc97-4e1c-af0b-ffaa4327a9ff"),

Guid.Parse("b9dfc4df-9383-43f0-8de6-96014b57770a"),

Guid.Parse("474a85ea-022b-4ccf-b7ed-e4e98dfe3704"),

Guid.Parse("4bfaa8fa-695c-470d-954f-72ad0e17ee5b"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("1e8c5de8-5de3-4a4e-940b-1d8322614462"),

Guid.Parse("f018bf93-f940-4158-a9a2-a2d9deb7334f"),

Guid.Parse("0c915925-6ca5-43c4-a66a-a12d2d16368f"),

},
},
            new GuiduuidArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5488ab03-6402-4e77-b462-5fd04d26a9c7"),

Guid.Parse("232b3c05-e1d0-4380-a6b4-da2ca4175c38"),

Guid.Parse("044ee8e5-b844-43d7-b688-fe05050a48de"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ecb573cd-4256-4be0-89e6-1c14aabc1996"),

Guid.Parse("8a5fe1fc-2070-491c-a77e-d90f001d9425"),

Guid.Parse("ea5d429d-b85d-4e40-9c97-3e73f9482699"),

},
},
            new GuiduuidArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("051d392c-2b60-4f03-9186-a5b85f9d2922"),

Guid.Parse("47f848db-2280-42d8-b9ad-00d3d57ffa70"),

Guid.Parse("f74ca0d6-1f9e-4a2d-9c5b-3e4635a40bf1"),

Guid.Parse("3d22441a-24b7-4280-8da5-7d29c6ef9b20"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("efcb46fe-9e94-4283-90ba-3e00003d010f"),

Guid.Parse("0c9014f0-4aa7-4e04-91c2-4bcd47af77c5"),

Guid.Parse("088f8cbf-0154-4245-bc9d-97f102976c30"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5bac655f-295b-4e47-adbf-34ab94c83b17"),

Guid.Parse("dbabd759-72b7-40d1-bb43-44d111229a1d"),

Guid.Parse("e0fda9e8-6dca-4378-9730-eaf837f58578"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2eff26fa-68c6-4011-95e1-8b0b2e09a6d6"),

Guid.Parse("935900ec-6c18-4d5f-96b7-5fe2fb6f2357"),

Guid.Parse("2a59a7e9-1b43-4f7c-846f-2626e3e277f7"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c49f8b4d-d067-4c4c-810e-af1b158d25bf"),

Guid.Parse("777ce743-6b6a-4999-8c25-a603db58e19c"),

Guid.Parse("e68ee9a2-4dcc-4147-a015-22037720dc28"),

Guid.Parse("46296773-7622-4a4f-9702-c4ce64a59427"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ae6a6491-cc7f-4a8b-a91b-6581ba88ca92"),

Guid.Parse("e41de0e1-f87c-449e-827c-6acaa6bcf54f"),

Guid.Parse("d0e5558c-2d2c-406a-be06-d59291ad0e65"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("7501ed2c-0cb4-4fa1-8266-491a51b64ad4"),

Guid.Parse("10e23437-0f01-41a0-ba6f-52ecd0aa38d6"),

Guid.Parse("39e81552-44cf-4a08-b231-df6d2163a321"),

},
},
            new GuiduuidArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("46743553-79a0-402e-906a-21cc5bc6c345"),

Guid.Parse("7570efba-aaeb-4191-af93-576544724850"),

Guid.Parse("33583af1-2c85-40b9-9f41-b8b348a81e9d"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b290aa57-d648-422d-930f-6c1e09a5c4a1"),

Guid.Parse("50c41815-330b-4278-9801-1168bda54d69"),

Guid.Parse("a1ddd577-d593-4ba7-92fc-bf0e7cb2b877"),

Guid.Parse("c0220512-24ee-4d2d-84ad-f5af9bfac772"),

},
},
            new GuiduuidArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3b636de4-3949-4b18-9d69-5ea95bc2c9e4"),

Guid.Parse("3940e766-6c0f-4c20-ae2a-eac2a8f87e53"),

Guid.Parse("dba751a1-93e0-4b63-a4d0-2bfbd376c153"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("6508d2d3-d85b-45ce-908b-f9a636bd11b8"),

Guid.Parse("4355dded-a6be-477f-96e5-45e0e38f53ff"),

Guid.Parse("e9ba4293-aac0-4201-93ee-cd2ce233a383"),

Guid.Parse("2691a4f5-6648-408f-9664-9a62f69ea635"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("aadfdd2a-3ada-4da9-979d-8eb9ee501632"),

Guid.Parse("65160b4c-26ff-46bb-9669-842c61a9ab1c"),

Guid.Parse("e6bc1955-98c5-4d23-af75-11670b9b2b66"),

Guid.Parse("a57268be-2407-48db-8f22-0101302cf7b3"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("66a91472-aaae-4b50-a2b2-f53072fafa7d"),

Guid.Parse("6cf339bf-d9e5-4ede-8798-1e25b4ce0cfd"),

Guid.Parse("534acdf5-8b19-4553-990e-395df43a7103"),

},
},
            new GuiduuidArray2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("346cb502-b0ae-42bb-be45-da5dacb34361"),

Guid.Parse("147c3a75-7c6a-4040-92a9-f83a74b544a5"),

Guid.Parse("cd2eec76-08a8-4c05-8050-ec3cd8be5028"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("201b28b7-08f2-4a33-a387-1d61bc32bb24"),

Guid.Parse("6998460f-3174-4af0-a1c4-cb12453e5ed0"),

Guid.Parse("62a9444d-60f8-4a80-8b09-0e5a37ed1fe7"),

Guid.Parse("aa066774-62d9-40ac-9574-175570d3b946"),

},
},
            new GuiduuidArray2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c63f2252-32be-4f87-8aeb-36073646eb91"),

Guid.Parse("1cc17581-19fb-4bd5-bfd5-130677b2efec"),

Guid.Parse("812063eb-af6a-4e61-b342-08f446443cc3"),

Guid.Parse("78a1fc12-c186-4804-a8f7-fa16439c418c"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("60bd9c8d-4d11-4b35-a923-9ceaac3466fc"),

Guid.Parse("b828a500-c62f-4536-8dec-c01a9d30a0c8"),

Guid.Parse("1f40c381-7efd-4d5f-9ef2-b2a10ec7b9a8"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("61deeed5-747e-4e33-9b88-47276d044541"),

Guid.Parse("bd58d7b3-2ee5-4a77-9a45-ecc4e33f8650"),

Guid.Parse("3aca7600-b0c1-435b-95cc-a7cd5e08941c"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("29f8dce1-84cd-42c7-83ee-9d2ca2bafbe3"),

Guid.Parse("0ed5314a-80ff-4661-8d8d-16676803bcda"),

Guid.Parse("1395b58d-fd83-4754-8f89-39731954f99b"),

Guid.Parse("29c92c0f-47e8-4382-b58a-e8527384087d"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("3289823e-322b-43b1-bcab-f0c9f6cbd915"),

Guid.Parse("d8cabf31-8658-4ac6-8745-a6d940b6b47c"),

Guid.Parse("054062a4-7744-4d33-be9d-e1b38c5340d9"),

Guid.Parse("528f3921-c89e-4262-a1cc-9f0bb31bf189"),

},
},
            new GuiduuidArray2M
{
    Id = 169,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5cad4e09-6752-42bc-8365-45708d09e8b2"),

Guid.Parse("86fba633-d24f-4582-b2b7-d9b5ca444a61"),

Guid.Parse("f1c08353-1dc9-4d2a-a8a4-d82afcbd8765"),

Guid.Parse("d0ad4601-1b3b-4488-9559-7dfc1741f612"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("87ae9dc1-867b-41ce-a13c-6e493be5ca3c"),

Guid.Parse("68949dad-b7b1-4bee-a1cf-5b620dedcac0"),

Guid.Parse("c158b99e-41e1-45b1-a519-7d80d43988e9"),

Guid.Parse("2492e6d4-9201-4d4d-a802-6c0f6b59b689"),

},
    NullableValue = null,
},
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 153;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[29], false);
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
                parametr2.Value = 62;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
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
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[19],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[20],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[21],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[22],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[23],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[24],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[25],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[26],_testData[29], false);
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
                parametr2.Value = 45;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 136;
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[29], false);
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        GuiduuidArray2M.AssertModel(models[0],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        GuiduuidArray2M.AssertModel(models[0],_testData[8], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[9], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[10], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[11], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[12], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[13], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[19],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[20],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[21],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        GuiduuidArray2M.AssertModel(models[0],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        GuiduuidArray2M.AssertModel(models[0],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[29], false);
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
                await ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 54, query1, 54, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
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
                await ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 31, query1, 66, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(17));
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
                 ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 103, query1, 88, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                 ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 88, query1, 144, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[29], false);
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 114, query1, 103, query2))
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
                        Assert.That(models, Has.Count.EqualTo(11));

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
                await ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 144, query1, 97, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 103, query1, 54, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[29], false);
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
                 ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 110, query1, 62, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[29], false);
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTSelectModelBatchAsync(connection, 30, 136))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        GuiduuidArray2M.AssertModel(models[0],_testData[6], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[7], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[8], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[9], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[10], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[11], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[12], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[13], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[19],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[20],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[21],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[22],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        GuiduuidArray2M.AssertModel(models[0],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[29], false);
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTSelectModelBatch(connection, 62, 50))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        GuiduuidArray2M.AssertModel(models[0],_testData[12], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[13], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

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
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 97);
                var models = await ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
GuiduuidArray2M.AssertModel(models[0],_testData[18], false);GuiduuidArray2M.AssertModel(models[1],_testData[19], false);GuiduuidArray2M.AssertModel(models[2],_testData[20], false);GuiduuidArray2M.AssertModel(models[3],_testData[21], false);GuiduuidArray2M.AssertModel(models[4],_testData[22], false);GuiduuidArray2M.AssertModel(models[5],_testData[23], false);GuiduuidArray2M.AssertModel(models[6],_testData[24], false);GuiduuidArray2M.AssertModel(models[7],_testData[25], false);GuiduuidArray2M.AssertModel(models[8],_testData[26], false);GuiduuidArray2M.AssertModel(models[9],_testData[27], false);GuiduuidArray2M.AssertModel(models[10],_testData[28], false);GuiduuidArray2M.AssertModel(models[11],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidListuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 127);
                var models =  ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));
GuiduuidArray2M.AssertModel(models[0],_testData[23], false);GuiduuidArray2M.AssertModel(models[1],_testData[24], false);GuiduuidArray2M.AssertModel(models[2],_testData[25], false);GuiduuidArray2M.AssertModel(models[3],_testData[26], false);GuiduuidArray2M.AssertModel(models[4],_testData[27], false);GuiduuidArray2M.AssertModel(models[5],_testData[28], false);GuiduuidArray2M.AssertModel(models[6],_testData[29], false);
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
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
        public  void DynQueryImportModelInnerTest()
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
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray2MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidListuuidArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidListuuidArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<GuiduuidArray2MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidListuuidArray)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidListuuidArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
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

        [Test, Order(5)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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

