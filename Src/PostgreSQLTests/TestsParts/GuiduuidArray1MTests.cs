

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
    Id = 7,
    Value = 
new System.Guid[3]
{
Guid.Parse("e0e4e53e-0f96-413d-a552-f7379993048f"),
Guid.Parse("e7116391-cb17-4931-82b3-863a56f13c66"),
Guid.Parse("2afb8822-5788-4156-811c-3dc7003a9684"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("daf1c193-14ac-4bef-95f4-749d1d3e608d"),
Guid.Parse("5615e382-a031-4643-b922-e4045aad6ecb"),
Guid.Parse("0586ee64-df5f-4f00-988d-e40610c80bec"),
},
},
            new GuiduuidArray1M
{
    Id = 14,
    Value = 
new System.Guid[4]
{
Guid.Parse("85497724-3acc-4900-8c37-4b36baf26d69"),
Guid.Parse("f3cc61c7-9cd5-476d-81b3-a53bfcbafe58"),
Guid.Parse("96daa513-8aa3-4355-9328-54dd10a98711"),
Guid.Parse("b7aba1a8-d27c-4299-aacc-c2cec61a21e3"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 1,
    Value = 
new System.Guid[4]
{
Guid.Parse("0e822121-096b-4ed1-bd9c-3c69cc9daa91"),
Guid.Parse("25382c9f-0b69-4f0e-95e9-aa4d77614990"),
Guid.Parse("667fd418-0e5d-4ee7-af51-72580ae3cbd3"),
Guid.Parse("2a5b9118-bedc-4c8f-b59b-f47a573baba8"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 18,
    Value = 
new System.Guid[3]
{
Guid.Parse("017805eb-7c3f-423d-96ce-622ea9756867"),
Guid.Parse("745061b6-1f22-435b-a6c9-f27db56e690c"),
Guid.Parse("c387f950-e42e-4255-a37e-e332faf75115"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("05454e7b-0dbb-43a3-bc9e-b8d3dc48f4d2"),
Guid.Parse("b6377098-3b55-4d26-a7cf-d650647274ee"),
Guid.Parse("5b78a6ae-f735-41e2-834f-f1b27c0a8f5b"),
Guid.Parse("c3148461-7c27-4d90-a029-5c82fc51962e"),
},
},
            new GuiduuidArray1M
{
    Id = 23,
    Value = 
new System.Guid[4]
{
Guid.Parse("790ad001-c8af-485c-b538-4cb80e43ccd6"),
Guid.Parse("fa03727c-c0cc-4a56-9797-9fa8264d1fe1"),
Guid.Parse("00b5d335-a5c2-400b-b291-a2779eb8f8c3"),
Guid.Parse("1ef8b8b7-d90f-4320-8516-78b7902f7ab5"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 2,
    Value = 
new System.Guid[4]
{
Guid.Parse("c50f4740-afa6-4070-a665-c10a92da48a2"),
Guid.Parse("c21fc758-dd19-40df-9e64-8fb4a5582442"),
Guid.Parse("7e45464f-8dc0-4ba0-a2c5-b831ac3ad635"),
Guid.Parse("9be0307b-c2dc-4ce3-8658-e8a3421576c9"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("0a47f7d8-b16b-4746-bae9-4643942d971e"),
Guid.Parse("936227bd-c39c-4478-87bc-c4b5a3234df6"),
Guid.Parse("f44cef42-7bc4-4d37-b757-29588c32d791"),
Guid.Parse("503af4f8-1d84-4db9-b4e9-5041613c9f9a"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("e16b1ba1-4f50-43ff-9425-c63e3992176e"),
Guid.Parse("c32e49bc-aaf6-4480-ab2b-9dd8108c39bb"),
Guid.Parse("b06dd8b1-6559-4465-9550-617c4ea90652"),
Guid.Parse("7baeeafb-2503-484f-bec4-79050dd85919"),
},
},
            new GuiduuidArray1M
{
    Id = 31,
    Value = 
new System.Guid[3]
{
Guid.Parse("f239da0b-f63e-4c77-8f7c-47c9835dd110"),
Guid.Parse("a4008e96-71f7-4cc6-8c9e-8dadbd49b355"),
Guid.Parse("33655e7b-0766-46e6-ab34-db54ff59fa78"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 35,
    Value = 
new System.Guid[3]
{
Guid.Parse("4784397e-fbca-4873-83d0-e488d6edf26f"),
Guid.Parse("7649894a-9007-4471-869e-f153db52b4c4"),
Guid.Parse("b213ce35-f7b0-4870-8606-0ac720dcd893"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 6,
    Value = 
new System.Guid[4]
{
Guid.Parse("014f065a-ef64-4c4c-a373-aaac0d784ee8"),
Guid.Parse("69e8cc94-e3d7-4644-a966-4d8c773446ae"),
Guid.Parse("40afb073-50a7-47bb-b0ad-cd08ceefe08a"),
Guid.Parse("59189f22-a5e0-4377-b20e-2189d2201a7b"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("ab871158-7759-4322-9773-79defab6d2ae"),
Guid.Parse("75dd1d9c-a852-4f7a-a489-19cad899fde5"),
Guid.Parse("fb37a5d9-ba35-4607-a321-cb1f2de29724"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("b11c1645-594f-4963-a090-a65f2daf91e6"),
Guid.Parse("6c411020-c45f-4b5e-930c-216d9e7c7d91"),
Guid.Parse("af27a5be-b533-4f40-911e-90f0241f8440"),
},
},
            new GuiduuidArray1M
{
    Id = 43,
    Value = 
new System.Guid[4]
{
Guid.Parse("14ac2ca0-ec83-4083-b4f3-ab7da2b6014d"),
Guid.Parse("ef2fae24-446b-4f35-b35d-f16b8ffe9ebc"),
Guid.Parse("b4956625-b2e1-461f-a04c-e76c1ac5d687"),
Guid.Parse("d55b2b06-cdd0-4e2e-8c38-3521fe6a18f4"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 47,
    Value = 
new System.Guid[3]
{
Guid.Parse("7594e38c-9a2f-4e0c-91f5-f4941c33ef0c"),
Guid.Parse("9a68946a-4d21-4d64-8e75-7f384f90afec"),
Guid.Parse("14e5b858-ecf2-48df-afb0-c56e77f09912"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 15,
    Value = 
new System.Guid[3]
{
Guid.Parse("7a13c05d-e60c-4437-b2e7-9159a91b82fb"),
Guid.Parse("0c61715d-05fc-4557-8d4b-9765c62b1d72"),
Guid.Parse("edceb83c-73c8-4dde-a212-7d9a1dca59f8"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 53,
    Value = 
new System.Guid[3]
{
Guid.Parse("d2012b3f-2e70-497f-946f-72a15c500361"),
Guid.Parse("1f48af11-ae6b-4ee8-94c4-851262beb002"),
Guid.Parse("3bf41188-84a3-4381-853a-2419d52365dd"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 60,
    Value = 
new System.Guid[4]
{
Guid.Parse("b8185577-85b0-4606-ac4f-71591a1f91a1"),
Guid.Parse("1f173446-f5d6-4a57-bbf7-c32be2408803"),
Guid.Parse("99372874-0ec8-4334-873d-f8e38634603d"),
Guid.Parse("20351bdd-826a-476a-ac3d-880546529913"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 17,
    Value = 
new System.Guid[3]
{
Guid.Parse("d1be4e6a-a667-4376-8a70-b33c09952809"),
Guid.Parse("39f04035-4ef7-4000-a428-38b9ac7b57d3"),
Guid.Parse("d02a20bb-c698-4385-8f0b-b5b87ef5b9a5"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 64,
    Value = 
new System.Guid[3]
{
Guid.Parse("eece2837-ad69-41e1-b21a-e4a101be0a42"),
Guid.Parse("18725e21-dff2-416d-a49c-099e4b860ff2"),
Guid.Parse("1ac38bd0-d522-422a-88ce-632afb1f4633"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("f62b0d0b-189d-4ca6-8fbc-faa8eac9cdd5"),
Guid.Parse("f21c7467-4fae-472b-a202-2e3c523c6b28"),
Guid.Parse("15f4923d-f38d-4ee8-ad43-adf78fe1b9c3"),
},
},
            new GuiduuidArray1M
{
    Id = 66,
    Value = 
new System.Guid[3]
{
Guid.Parse("43d9b145-003e-43fd-abba-ba43d6b374d5"),
Guid.Parse("fbabc8f6-d451-4768-b9ff-3e316ccb6efd"),
Guid.Parse("3d906608-bc5c-43ad-9e9a-545320c268a8"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 18,
    Value = 
new System.Guid[4]
{
Guid.Parse("5ffa9ce7-ddb5-4266-94c8-7e7b237a9d3f"),
Guid.Parse("0123b549-086d-47af-b973-24c46ca936a6"),
Guid.Parse("e9946c31-b4e9-40c0-a5d2-ad3c665ed814"),
Guid.Parse("faf477f4-9f72-4df2-9cab-ee6415fb46bc"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("059aae72-41fe-4275-a0b9-8d161f3dc3be"),
Guid.Parse("0e2240f9-a47c-4f2b-922c-40ca82617085"),
Guid.Parse("dba8e834-0feb-4fca-94b3-ea8235fd72c3"),
Guid.Parse("ef684669-78aa-4e79-832b-184b3cd596bb"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("e78787e0-7b89-4aaa-9da8-93fcebefa1cd"),
Guid.Parse("35bb4b13-55f7-4a12-9101-d574dc9405f2"),
Guid.Parse("ab5953d0-7d8c-48a3-8594-23dcb4c5f4c5"),
},
},
            new GuiduuidArray1M
{
    Id = 68,
    Value = 
new System.Guid[3]
{
Guid.Parse("c5c38611-fe77-48d6-8ee4-538af6577a54"),
Guid.Parse("b73c0cde-ced9-4c1b-a55e-424af0d533e4"),
Guid.Parse("9d6490ef-42e2-4228-8fd0-d58a828119ff"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 71,
    Value = 
new System.Guid[4]
{
Guid.Parse("53841b58-c6a2-48d5-b048-544a6c3cc27b"),
Guid.Parse("dd33c336-eb0f-414f-a2dc-e04bd3121b72"),
Guid.Parse("c38a40b3-2d3d-4b15-ab06-de25db6158d9"),
Guid.Parse("86b65ef3-b66a-4aec-ab8e-cf186ceb554b"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 21,
    Value = 
new System.Guid[3]
{
Guid.Parse("3c5ed65e-a475-4ea0-8ec9-9af7b2f8e3dc"),
Guid.Parse("2122714b-0267-4488-9c3e-a85904ac5327"),
Guid.Parse("d3696f68-2ea1-4f2d-b027-4fac8de39437"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("94839412-98ac-4823-a9af-80136c9d539d"),
Guid.Parse("67bce847-bb13-4031-a908-b44f07f57519"),
Guid.Parse("a1e45a0a-b97c-42f8-946c-88ac9e054487"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 77,
    Value = 
new System.Guid[4]
{
Guid.Parse("d426ec62-4a22-45da-8346-9a4a9d8ad8db"),
Guid.Parse("1ad22a86-693d-4880-a62d-1d86e68353a3"),
Guid.Parse("c673645f-9b7b-49df-9991-a8b9ba2450d2"),
Guid.Parse("b368b2ea-4679-47e5-94df-0a415857f2cb"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("2613caaa-c481-4db9-9fe1-24f1adf4ac35"),
Guid.Parse("5b5b99e5-cc0e-4ddd-844d-890614699c33"),
Guid.Parse("d31a7fd5-1cad-4d8c-a78e-d74d5ce4c233"),
},
},
            new GuiduuidArray1M
{
    Id = 81,
    Value = 
new System.Guid[3]
{
Guid.Parse("8823c0d6-70ee-43d9-b9a6-7d5efcfe314f"),
Guid.Parse("0bddaeaf-7fb0-4dfc-9a79-3d36b3585e5c"),
Guid.Parse("9874acd9-2eb2-45c5-ae38-a9516a90bf03"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 27,
    Value = 
new System.Guid[4]
{
Guid.Parse("2756a1e4-1802-4c14-8ceb-54d53ffd6dd0"),
Guid.Parse("c82b0d07-3b12-4ce4-948c-40b34b3b5a1c"),
Guid.Parse("5d30ea7b-a8c1-44da-b730-09a843deea01"),
Guid.Parse("e39d403e-ff33-4419-bf80-9deda5c6406e"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("96337260-0f0e-4da0-982c-cf881b9ced5b"),
Guid.Parse("f1faf307-c92a-4539-84ea-282b5e378ed1"),
Guid.Parse("3db0c82a-3919-4d07-be27-3b6a6ff5273b"),
Guid.Parse("d367f4be-78f7-47d5-9815-c2a4acd93c5e"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 89,
    Value = 
new System.Guid[3]
{
Guid.Parse("c4fdf6ff-1de2-4bc8-9ac2-2137a5069e42"),
Guid.Parse("8b3b2e2c-7177-41a3-89dc-27d3f014a6ca"),
Guid.Parse("16aedc2c-a769-46af-a487-27333f75e5d7"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 91,
    Value = 
new System.Guid[3]
{
Guid.Parse("926e28a9-4c7f-4fbf-aa27-b0fbc09124a2"),
Guid.Parse("51874f97-520b-45a5-868d-43d97e96b130"),
Guid.Parse("bc26e24a-5f74-47b9-ad5b-92d93e0ae4b9"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 29,
    Value = 
new System.Guid[4]
{
Guid.Parse("9770e330-2b22-420a-a481-30826165b0d5"),
Guid.Parse("32580bfd-2779-4422-88a1-ed3d67030da8"),
Guid.Parse("c9d059d8-5c3c-4f47-8ac0-80164b0ee529"),
Guid.Parse("985aeee2-7e24-4144-8b11-14f732693a83"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("24ee8fad-d075-4cbd-b48e-ab73120da371"),
Guid.Parse("4f6a5d70-4262-4d75-a88a-a59d4a58ddb4"),
Guid.Parse("5dc0059a-9cb9-49c3-8603-3e4383d00bfe"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 98,
    Value = 
new System.Guid[3]
{
Guid.Parse("712bd110-33ab-4eff-82e0-8c7958dab055"),
Guid.Parse("78fdd826-e4c9-4e72-a327-2ccc1e497898"),
Guid.Parse("461b9f67-8abd-4149-ab6b-cb061826ce5c"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("634efe59-5c41-4817-a120-e7877783daf9"),
Guid.Parse("30f08628-23c7-4620-8f2b-f34051b55bee"),
Guid.Parse("bc2d32ef-205c-4d26-84a7-91139461c7f5"),
Guid.Parse("aeb97af9-627d-4c74-9357-3575df9eb8f3"),
},
},
            new GuiduuidArray1M
{
    Id = 106,
    Value = 
new System.Guid[4]
{
Guid.Parse("02bc1308-adf4-4418-9b64-a8e855c6933a"),
Guid.Parse("5d10e354-5147-4c97-84ed-690787a1b0af"),
Guid.Parse("13e5ef43-6be3-4256-9a0f-1479e07f1b28"),
Guid.Parse("3c2d97ba-e57a-4155-8d10-f96494471d6e"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 30,
    Value = 
new System.Guid[3]
{
Guid.Parse("eade188f-3ffc-4289-8ffe-1b75a3838f0c"),
Guid.Parse("d7662881-ce9e-455a-923f-ddc3d835ca53"),
Guid.Parse("4a9c9f38-d63f-4803-9bd2-c79c0ba07001"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 110,
    Value = 
new System.Guid[3]
{
Guid.Parse("2b38bd36-dde7-414b-980d-e34152571bd7"),
Guid.Parse("d3551030-1993-439c-9995-480850d70adf"),
Guid.Parse("1e5625b1-5e5d-4a50-a4eb-d9e3b271488d"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("d929a2b9-f525-472a-b087-4c16ff4ad34d"),
Guid.Parse("692b81e0-8c19-4c9a-abfc-47370e07c240"),
Guid.Parse("9aca060c-a6e6-40d3-9502-db64f0a431fb"),
},
},
            new GuiduuidArray1M
{
    Id = 116,
    Value = 
new System.Guid[3]
{
Guid.Parse("39027268-476f-491c-83e5-1f2368c31707"),
Guid.Parse("e8f6e5f5-b70a-4651-b882-e7a32315edc2"),
Guid.Parse("546523d8-7af2-4dff-9c0f-4dbdacf11946"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 39,
    Value = 
new System.Guid[4]
{
Guid.Parse("3180d512-869a-4eeb-a9bb-3b904e1cef32"),
Guid.Parse("89749cc5-9d87-4a66-a292-1a4f0dd8d325"),
Guid.Parse("a9e20c72-e548-4ba0-8350-30d3de39f8a8"),
Guid.Parse("17a0ab99-7c6a-4c28-8804-71be0b6e6824"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("8fcfeb1a-4e52-4471-bdc9-d109020852ac"),
Guid.Parse("6c0471aa-03b2-4e9a-a70b-9735681f06d8"),
Guid.Parse("5e7253ee-54eb-4eeb-b4ad-e7af7ca52ed3"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("b68074df-c990-49e8-baf1-7ff47cc3a808"),
Guid.Parse("33e3acf2-dcbf-4b28-9e9c-20f4bf04b3b2"),
Guid.Parse("d4651a71-9376-4ec5-b5aa-db7d6cdfc421"),
Guid.Parse("aab9461c-4b9e-43db-a475-7ab081a990d7"),
},
},
            new GuiduuidArray1M
{
    Id = 125,
    Value = 
new System.Guid[3]
{
Guid.Parse("9e98de45-a31b-498f-92da-2c51c2ec925c"),
Guid.Parse("5a37ccc9-764c-412b-8b6b-c298b36f3ada"),
Guid.Parse("7ccd907f-b446-425b-a90d-8c474b6700ae"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 126,
    Value = 
new System.Guid[3]
{
Guid.Parse("5b7727e8-c83e-47c7-aa75-39f292c76a36"),
Guid.Parse("c05163a8-dcc5-41fd-87c8-36bf0bd151a5"),
Guid.Parse("71da672f-656a-467e-8940-6a059dc975fc"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 44,
    Value = 
new System.Guid[3]
{
Guid.Parse("0a7222c8-d973-4956-b422-de2dbc6ccd2e"),
Guid.Parse("e099dd75-cc2c-4972-a353-6cd1ce8a17e3"),
Guid.Parse("6776a45e-a44e-4fa3-833c-9a6201d014d1"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("ca3adbfb-c9fb-49cc-b657-c3b869c68715"),
Guid.Parse("d3437443-9ce7-4c1a-a18a-7ceb4b8d4f19"),
Guid.Parse("80ab9fa7-c681-4a4c-b1e8-3b0790fe314f"),
Guid.Parse("e27e4cf3-8ec1-4d75-bb52-b27de3b647f7"),
},
},
            new GuiduuidArray1M
{
    Id = 130,
    Value = 
new System.Guid[3]
{
Guid.Parse("36ba90a4-0934-45a3-9611-30da42446c63"),
Guid.Parse("a5a61103-8ca3-4a88-b7ac-d786bd95b7cf"),
Guid.Parse("cae47058-1f6c-43b3-b807-557b2da867ce"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 135,
    Value = 
new System.Guid[4]
{
Guid.Parse("911a63b3-c9ff-4aae-92a8-c48c71e93d95"),
Guid.Parse("30a7e556-c22a-4bfa-84c5-f8c543bb9cef"),
Guid.Parse("b959dc21-88ba-4b2e-90a1-0391664522ad"),
Guid.Parse("2cc81acd-5118-45c3-b53f-8eaabd4e0505"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 48,
    Value = 
new System.Guid[4]
{
Guid.Parse("32ee00f1-ef9b-4d81-8c91-c2cdab047baa"),
Guid.Parse("b6d5c3ea-6731-4fb6-b40b-75af3d13fff0"),
Guid.Parse("f45b2858-5b41-466f-9939-b5deb257ecf4"),
Guid.Parse("ca6bf87f-0ddc-4333-a396-ed037da20ab5"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("d6d81aa6-3f12-4562-99c9-04fbae8e8550"),
Guid.Parse("4f6ff545-2e5f-4423-aa82-c5f5d28a180a"),
Guid.Parse("bd85294d-2c82-4de8-b0fc-1ad2d00d48c7"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("3a0d7b7f-5d96-4738-b45d-d64ca12573a0"),
Guid.Parse("39ab5473-602d-4edb-9add-ea6b828300e7"),
Guid.Parse("bbb6b157-c9f4-4440-bd93-81ff2dff01c0"),
Guid.Parse("b1daf575-af7e-4a2c-b389-0999c15e8bba"),
},
},
            new GuiduuidArray1M
{
    Id = 143,
    Value = 
new System.Guid[3]
{
Guid.Parse("49fc7c14-dee2-4aa0-b7c4-755dd216f924"),
Guid.Parse("9ed428b8-965b-4384-9b53-67beab82878d"),
Guid.Parse("1c313383-039f-4a50-ba10-8f6fece3de79"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 147,
    Value = 
new System.Guid[3]
{
Guid.Parse("e5be0922-4a56-46c0-b44c-acbce21d504d"),
Guid.Parse("c9d714af-9e7d-4bde-9bc9-238d216ab885"),
Guid.Parse("4b1619b7-c2c3-4335-b108-d32f8b83ca55"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 54,
    Value = 
new System.Guid[3]
{
Guid.Parse("f8474092-91b3-48fb-ad30-6b044d6da438"),
Guid.Parse("b57aabd6-84ab-452f-ad9c-ab0b6b721ad6"),
Guid.Parse("6793e91d-0030-428b-a436-4957ffcba7c4"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("6f7e3a68-2c0d-4f95-a862-85fff1760f05"),
Guid.Parse("1cd0d23f-74f5-4b77-b70b-e2643b6d2bb5"),
Guid.Parse("ef5a195e-c0f5-4e0b-a837-0520eb41898a"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 154,
    Value = 
new System.Guid[4]
{
Guid.Parse("184c9f30-d5df-4c5f-a2b2-ad73a2668713"),
Guid.Parse("bf3141fd-0419-409a-b7b7-6f536eb2430b"),
Guid.Parse("b944d8e5-725e-4ddc-886e-fb26bba58b57"),
Guid.Parse("a2da8958-632f-4ebd-9b74-877029c615d8"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("0547d392-432a-4144-9037-586fa24e8779"),
Guid.Parse("3cd9a58c-b82d-4b68-9d86-4aa814741091"),
Guid.Parse("77d9cad9-d5c5-4a79-8301-05e68fac651f"),
},
},
            new GuiduuidArray1M
{
    Id = 160,
    Value = 
new System.Guid[4]
{
Guid.Parse("ccde2312-5814-4625-b2fa-e99d8e2c71f3"),
Guid.Parse("559de908-7310-49f9-acb6-40ba74f912e7"),
Guid.Parse("1f1abda4-ee37-48d1-a132-d5b440f79e69"),
Guid.Parse("8f786f59-c716-4de3-ae0c-b077f7119f89"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 59,
    Value = 
new System.Guid[3]
{
Guid.Parse("4f9a7db5-604a-42fc-8ec5-5deb68cdc10e"),
Guid.Parse("b0a3341f-cf8c-4992-bf9e-350aa41acdc0"),
Guid.Parse("228ab097-d4f7-416b-8efb-843552896a04"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("e01c074e-ca3b-4430-a55b-be229498f217"),
Guid.Parse("5a09bd0a-de71-4994-978a-e264a70c8348"),
Guid.Parse("a353689e-5518-4b2d-9cca-7684a25d525a"),
Guid.Parse("509a2e3f-9215-4a8b-a200-0895ca52e871"),
},
},
            new GuiduuidArray1M
{
    Id = 168,
    Value = 
new System.Guid[4]
{
Guid.Parse("788970f0-55a5-4178-80dc-2a0afb074534"),
Guid.Parse("8ab480e5-51cb-4709-bfae-df7dd06886eb"),
Guid.Parse("103866f3-9dc5-4aac-8773-a40dac5662d2"),
Guid.Parse("d16b4b57-2dde-4b95-b480-99b4af0277c0"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 175,
    Value = 
new System.Guid[4]
{
Guid.Parse("678bd845-19dd-4205-869e-06a6a9593b06"),
Guid.Parse("fbf6e3f7-af5f-431e-89b6-c828608ebf05"),
Guid.Parse("c303c1a1-93cc-4130-a803-892d72c5d7be"),
Guid.Parse("fbbec8c8-b2a0-4162-b648-d9b9d472981e"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 61,
    Value = 
new System.Guid[4]
{
Guid.Parse("ba76219f-8cc6-4bfd-be78-b32065a1e3cc"),
Guid.Parse("e861fc40-9db5-430c-b4b7-6ab12f1da82e"),
Guid.Parse("87897423-a588-42dc-87da-8958d5021be8"),
Guid.Parse("b374e0c0-adc3-4d51-b6aa-994acc1364ba"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("620165d9-d376-41af-8f35-c6bda9afa099"),
Guid.Parse("9b56e1ba-dc03-45a3-83ff-d7987bf58b24"),
Guid.Parse("51ef41b6-d42b-4537-9a50-8d7307db1a37"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("2e0f1605-7f1c-4d1e-a3bd-f9520af58cfd"),
Guid.Parse("1a856dcc-c938-486a-857f-dc96f0a3590f"),
Guid.Parse("970cd6c0-332e-409a-88fc-e9b68182ead5"),
},
},
            new GuiduuidArray1M
{
    Id = 179,
    Value = 
new System.Guid[4]
{
Guid.Parse("ddb70e23-df68-4aa0-b695-e21f6351d432"),
Guid.Parse("f974dac9-3b65-452a-8f18-905fb2a46ea9"),
Guid.Parse("36121c70-7f21-4ee7-937e-5762da39e726"),
Guid.Parse("93991c5f-ee9c-4437-81e7-9b572139776f"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("197b069e-865e-44d5-9ecd-06c453abb741"),
Guid.Parse("ae9f4e93-6b62-4f46-b4e5-1763b24e8033"),
Guid.Parse("24563e69-a688-4b7f-9f65-5ddad5e507e0"),
},
},
            new GuiduuidArray1M
{
    Id = 180,
    Value = 
new System.Guid[4]
{
Guid.Parse("c50799cb-c292-4424-9e56-29e9dede1945"),
Guid.Parse("e4714167-bdb6-44e6-9172-78a1550ddfbf"),
Guid.Parse("e71cece5-cf6d-4cac-b0e6-24fb911b4635"),
Guid.Parse("79f40de6-5134-4be6-b9ea-ea35d3b8394b"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 68,
    Value = 
new System.Guid[3]
{
Guid.Parse("ee47670f-8852-48ae-9c2a-8a025c876d82"),
Guid.Parse("589787cd-50fb-4a72-a2c3-648369d1a65a"),
Guid.Parse("c4db5c6d-8f10-42c0-b377-60a47ced1f52"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("e7e110ea-a676-45d6-b8cf-db657a849c12"),
Guid.Parse("34b1d88b-4835-474f-baa9-fc017d022f9b"),
Guid.Parse("d2c503fd-88d5-426d-b3bf-d332e7f0e800"),
},
},
            new GuiduuidArray1M
{
    Id = 187,
    Value = 
new System.Guid[3]
{
Guid.Parse("920c378e-1e3b-4c9d-b75d-36e3e96f476d"),
Guid.Parse("76a29a75-b316-4f2b-94a9-da14f0eb289e"),
Guid.Parse("60c5d0c7-9155-4f40-aeab-4976e025b87d"),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("b11c1645-594f-4963-a090-a65f2daf91e6"),
Guid.Parse("6c411020-c45f-4b5e-930c-216d9e7c7d91"),
Guid.Parse("af27a5be-b533-4f40-911e-90f0241f8440"),
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
Guid.Parse("f62b0d0b-189d-4ca6-8fbc-faa8eac9cdd5"),
Guid.Parse("f21c7467-4fae-472b-a202-2e3c523c6b28"),
Guid.Parse("15f4923d-f38d-4ee8-ad43-adf78fe1b9c3"),
}));
                nullable = await ((IGuidArrayuuidArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("e78787e0-7b89-4aaa-9da8-93fcebefa1cd"),
Guid.Parse("35bb4b13-55f7-4a12-9101-d574dc9405f2"),
Guid.Parse("ab5953d0-7d8c-48a3-8594-23dcb4c5f4c5"),
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 154;
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
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 160;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[34], false);
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 154;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[27],_testData[34], false);
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
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
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
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
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[34], false);
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
                parametr1.Value = 175;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 160;
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
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[34], false);
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
                parametr1.Value = 143;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        GuiduuidArray1M.AssertModel(models[0],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

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
                        GuiduuidArray1M.AssertModel(models[26],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[27],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[28],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[29],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 168;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

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
                        GuiduuidArray1M.AssertModel(models[29],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[30],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[31],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[32],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        GuiduuidArray1M.AssertModel(models[0],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[34], false);
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
                await ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 18, query1, 98, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
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
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[34], false);
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
                await ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 81, query1, 68, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[34], false);
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
                 ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 60, query1, 31, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[29],_testData[34], false);
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
                 ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 14, query1, 147, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 77, query1, 179, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[34], false);
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
                await ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 160, query1, 53, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[25],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 126, query1, 116, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                 ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 168, query1, 160, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelBatchAsync(connection, 18, 125))
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        GuiduuidArray1M.AssertModel(models[0],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelBatch(connection, 135, 23))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

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
                        GuiduuidArray1M.AssertModel(models[26],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[27],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[28],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[29],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[30],_testData[34], false);
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
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 71);
                var models = await ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidArrayuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 116);
                var models =  ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

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

