

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
    internal partial interface IGuidMArrayuuidMMArrayD1
    {
    }
    
    internal partial class GuidMArrayuuidMMArrayD1 : IGuidMArrayuuidMMArrayD1
    {


#region TestData

        private readonly GuiduuidMMArrayD1E1M[] _testData = new GuiduuidMMArrayD1E1M[]
        {
            new GuiduuidMMArrayD1E1M
{
    Id = 7,
    Value = 
new System.Guid[4]
{
Guid.Parse("2adf2d5f-00fd-4dea-8016-e1ad9cfcf3c6"),
Guid.Parse("22502a84-8b47-48a2-97f6-3acfb7290f54"),
Guid.Parse("b97d824e-3112-496d-8796-83dddd6071ff"),
Guid.Parse("75a1fdb3-4d31-4989-8933-cb14ceaabd98"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("bd76a09b-9c8f-4c49-9408-5d750eeb75c5"),
Guid.Parse("5b5ba38b-e322-486d-99cc-880bef30220d"),
Guid.Parse("4641688f-dd97-48e3-a583-c5e39068f194"),
Guid.Parse("4408f6c7-85ca-48e4-9e97-bf543e220627"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 16,
    Value = 
new System.Guid[4]
{
Guid.Parse("14236b09-9dc7-41a1-9b02-89f9f212839f"),
Guid.Parse("e5b89f46-2d3d-4d94-a2cd-1b6f4975b618"),
Guid.Parse("3ef7dec5-a039-4523-95e7-a81d6f3abb48"),
Guid.Parse("b3235f3e-a766-4fb7-92df-d7fb160681d2"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 1,
    Value = 
new System.Guid[4]
{
Guid.Parse("4bf03a5c-d871-4697-939b-d129a4bcd8cf"),
Guid.Parse("f5b0673c-bb38-4271-bc24-6931d72ed238"),
Guid.Parse("3db7a0ea-1f79-4e71-ae26-0dc135a4258a"),
Guid.Parse("24599ca8-ada7-482e-844c-551451c4e2ce"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("8aad2de2-58cb-4218-8bcb-9e4eafe69ebd"),
Guid.Parse("ee91ba89-be0e-42cb-892e-b14e0af07834"),
Guid.Parse("4eaf09b5-513c-4fbd-96f7-a46cde1596f6"),
Guid.Parse("71d07910-22f3-43bf-848a-09e84ced4a58"),
},
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 22,
    Value = 
new System.Guid[3]
{
Guid.Parse("0cc0d889-3320-4826-958f-35a8035e9f6a"),
Guid.Parse("6f9362a3-e96d-4628-a05d-dd085dc873e9"),
Guid.Parse("4b16d57e-9489-4e5f-986d-caa7a1493997"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 28,
    Value = 
new System.Guid[3]
{
Guid.Parse("03ffda04-dbf0-4ebb-a019-1b110f226a9d"),
Guid.Parse("95e8d5fd-6859-4598-8f01-08ca1798673e"),
Guid.Parse("2e628ce3-9704-451a-b4e8-3dbba5b967b8"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 3,
    Value = 
new System.Guid[4]
{
Guid.Parse("965e4385-a0d3-4141-b7e8-fce05d087331"),
Guid.Parse("6a99d499-12a4-4b5b-8fea-7cc88a127bf0"),
Guid.Parse("0f7a726e-f75f-420c-a4a8-5690a978c6cf"),
Guid.Parse("4f855acf-c211-4383-8318-f723c7a78f4e"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("c1293caf-a333-4cdd-b153-ba88f110b310"),
Guid.Parse("d6613ec8-1b8a-4ea4-9911-6f348310c505"),
Guid.Parse("f977ecd3-7d1d-4825-ac55-4cd1d01b198b"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 33,
    Value = 
new System.Guid[3]
{
Guid.Parse("0248a646-8476-4bf8-a92e-e9e0c15f05ef"),
Guid.Parse("5650d19e-5f41-48bf-af56-7960afc0661f"),
Guid.Parse("9abe4a45-e5f3-4db9-b4fc-d36223688762"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("d0344b92-21d8-477f-9f4b-ecf469d89a7f"),
Guid.Parse("e1dd45e6-b729-485e-9e71-bfbbf8e375ee"),
Guid.Parse("948811e6-f385-475c-be76-abd127ad3bc5"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 37,
    Value = 
new System.Guid[3]
{
Guid.Parse("613a18b6-b9fa-46ce-857f-8a8f6343aef0"),
Guid.Parse("89a95481-d9b8-45d5-b5ac-a8dfbef5f330"),
Guid.Parse("57789167-1ea6-4e7b-9e66-db36a39bfbb3"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 11,
    Value = 
new System.Guid[3]
{
Guid.Parse("f8733291-e99e-4cfa-ad94-49638e968f3e"),
Guid.Parse("6046f102-3d61-4166-9b3f-8dbafc8ea7dd"),
Guid.Parse("9d19f24b-6253-454a-a1fe-528d409940f5"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("3e534d17-1f05-45b3-b68c-519c206d95fb"),
Guid.Parse("9f155079-ee10-40e2-9e97-598873603946"),
Guid.Parse("95c68bb1-50c7-4093-9f48-70ff6c51018c"),
Guid.Parse("65977cea-13e8-4e95-9cdb-a4d913542a44"),
},
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 41,
    Value = 
new System.Guid[4]
{
Guid.Parse("151b0784-6a31-4317-8d16-d572dbed7ca9"),
Guid.Parse("e2cd0c7f-e02f-42b8-817a-605b8d50aa9f"),
Guid.Parse("0d2eb36a-3582-4b6b-a82a-e6e345b8baca"),
Guid.Parse("002fc03b-60b9-4a99-ad84-8f535ef21052"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 43,
    Value = 
new System.Guid[3]
{
Guid.Parse("a8f7c719-2432-4251-9e08-e53a2f37b3de"),
Guid.Parse("d3dfa540-1550-484d-9825-f48424ac726e"),
Guid.Parse("a9f364cb-3ffa-4853-b31d-42bbdad913fc"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 14,
    Value = 
new System.Guid[3]
{
Guid.Parse("5ce75aef-0d68-41d7-b569-a4dfcb15329d"),
Guid.Parse("cb158359-a673-4d23-ae59-6e409230e8bf"),
Guid.Parse("06ac6588-22ba-4261-836d-aa90a0d2f3a3"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("bd416f6b-c1a0-41ec-bff9-996b3db407b2"),
Guid.Parse("1fef0eb6-c4db-4459-991f-52a6488bfd9d"),
Guid.Parse("4f8c9d6e-d210-4347-9a4d-bc99b754e6e4"),
Guid.Parse("ac4bc7d0-f1c6-43e0-acec-a4831ac82e0f"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 45,
    Value = 
new System.Guid[3]
{
Guid.Parse("0a3b523c-e7f8-400c-ba99-a36284aa7bd1"),
Guid.Parse("2762947a-5259-46c5-8d19-27c51409fd75"),
Guid.Parse("68bda4d5-bef0-4676-b5a3-f14b95ec09c6"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 48,
    Value = 
new System.Guid[3]
{
Guid.Parse("0352b9ea-f73c-41c0-8088-d4f029fd7e8f"),
Guid.Parse("03fa9668-433e-499b-92eb-4012dc5d8df1"),
Guid.Parse("1e9f88e2-2a56-4a23-96e7-1b55351b1b96"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 18,
    Value = 
new System.Guid[4]
{
Guid.Parse("e864d438-52e9-4d52-a49a-2a8831a9a358"),
Guid.Parse("c9be222d-186f-42fe-a0b6-36eeeb26a6bb"),
Guid.Parse("683ca3b3-773b-4657-a2d1-6ed23885c5a7"),
Guid.Parse("f8f515a6-7f97-4731-8e31-2fa80e4ce93f"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("afdbab74-e703-405a-8000-68a7e7687d84"),
Guid.Parse("e964c08e-6262-4379-9499-5f2eb7125b19"),
Guid.Parse("fda0e4ac-8031-4496-8fd6-55d2154963d0"),
Guid.Parse("00ecfda2-9fff-4a28-836f-c5ffbdca80be"),
},
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 51,
    Value = 
new System.Guid[4]
{
Guid.Parse("3a370d7e-b96d-45d0-bc90-6a0ec281268c"),
Guid.Parse("fff1fc80-bb54-46f0-84db-0c52674f0623"),
Guid.Parse("41312335-76c6-4dbc-b5a6-46147787c11e"),
Guid.Parse("2470f009-47f9-48cb-add3-d0706c83b36d"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("06454751-d59b-43c5-866a-3adcbe56d36f"),
Guid.Parse("51cdc25a-a2dd-48f4-80db-3a6f4285d01f"),
Guid.Parse("990e848c-64d1-4612-860a-15ef805d9300"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 57,
    Value = 
new System.Guid[3]
{
Guid.Parse("7d0ebb8d-8e96-4ece-b739-89c44c1932a3"),
Guid.Parse("5b4d9f59-4b53-4010-94d2-f9a19fe30745"),
Guid.Parse("db4998f4-6e7a-4c35-91f6-5d7611804b7d"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 23,
    Value = 
new System.Guid[4]
{
Guid.Parse("cc9a1edf-c8c4-417d-98f9-8b5b2b4299e6"),
Guid.Parse("b692885d-b535-4d3d-abd9-4c0e9d7c978a"),
Guid.Parse("d3e4a15f-74bd-439d-9d17-07b7db23ee9e"),
Guid.Parse("31e7d05b-f105-424d-9ebd-c014ee34c556"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("bb76766c-a22e-4dbe-b355-a0765073e4fd"),
Guid.Parse("8d7a1d16-e00d-4773-9523-5d9ae95e43a8"),
Guid.Parse("d1e43a79-32d1-48e9-9ad3-0b468d01c1fd"),
},
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 64,
    Value = 
new System.Guid[3]
{
Guid.Parse("bf0e13dd-a7a2-41cb-9e3f-2ddb5a285ded"),
Guid.Parse("a0a08e34-3385-4eff-8440-c72fea91a37d"),
Guid.Parse("a038f191-9eb1-4881-bf5a-315424f88d19"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("c44d3885-d6db-483c-9f84-c8bf1c46f140"),
Guid.Parse("124d6df1-d98c-4d80-a201-45dec2bd68a6"),
Guid.Parse("75317f39-974d-4d44-97a6-a346b2183b09"),
Guid.Parse("0a01be2a-786a-4c16-b189-6008d2283ff9"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 65,
    Value = 
new System.Guid[3]
{
Guid.Parse("ac96bb24-f314-42e5-92d0-02d7a1be0ef2"),
Guid.Parse("d7f7cd57-425e-44aa-bad3-96ab8081977e"),
Guid.Parse("50ac8929-91c5-4fea-a1f2-d38e3f24ddbf"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 31,
    Value = 
new System.Guid[3]
{
Guid.Parse("2f8393d1-431c-4e5e-a6ea-4f429417ad24"),
Guid.Parse("03013fc2-6b12-45dd-8988-e0e693998029"),
Guid.Parse("09a6b460-a1d6-4edd-bbd7-eaf66b58b012"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("3c1ebcba-bb73-4fd5-a959-3e0f72be6b39"),
Guid.Parse("1cee5fac-bd70-4d37-892f-fb8959d564b4"),
Guid.Parse("ebd7bc84-9310-4652-ac34-431fcf4c7676"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("b08e7c48-4e14-4d1c-ba06-c0d13fdd7e6b"),
Guid.Parse("8211b2ef-0326-478c-b262-9acd9fdf1995"),
Guid.Parse("2ea3066c-7542-474a-b90b-ebf3f327f3c8"),
Guid.Parse("d3b1948a-bae7-444e-8fd2-59faf0c15c35"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 68,
    Value = 
new System.Guid[4]
{
Guid.Parse("eeabbbac-34c8-47fc-a330-976db71cad0a"),
Guid.Parse("9ce6091e-c1c3-4c7d-84d7-f2f66a3a142b"),
Guid.Parse("3ed2e352-ff7a-4fc1-a3dc-d065c6a84025"),
Guid.Parse("79c77e4b-7abe-42d0-b99a-c1bfabaa5c65"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 76,
    Value = 
new System.Guid[4]
{
Guid.Parse("e2131d67-6e42-4813-b5ef-f62520a45918"),
Guid.Parse("5a9aacee-1068-4369-a61f-e20f1cd3588d"),
Guid.Parse("87614115-bdf4-404c-a58d-8b89f9dcfdfa"),
Guid.Parse("f64bcc46-39bc-4e3b-9c27-4c515952e1b1"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 35,
    Value = 
new System.Guid[4]
{
Guid.Parse("99e83347-4f16-4f18-bf1c-5caccc850a22"),
Guid.Parse("b707b2fc-ca61-42ce-97bf-da0a5f9ace3d"),
Guid.Parse("a0b8bca2-e7ee-4af5-9aa2-7ff5af2c6db8"),
Guid.Parse("76703c3a-fd2a-47b2-aebc-ef3a0af643e1"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("05aa3659-a979-4bfe-8c32-13bfabfed5d3"),
Guid.Parse("4f932bb9-e6a0-48ed-9b9a-e8bc1c1d518d"),
Guid.Parse("3e9a78aa-a533-4e97-bd68-edd09e017655"),
},
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 78,
    Value = 
new System.Guid[3]
{
Guid.Parse("78c48744-2e0c-4bac-b78a-beb8f688c313"),
Guid.Parse("52141ffb-ac82-478b-b88c-4010a9d92466"),
Guid.Parse("1a1f61f7-3a5b-4ec6-a0ff-1ca7b73b52d0"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 83,
    Value = 
new System.Guid[4]
{
Guid.Parse("50178bf1-54c2-4e50-8c5f-659d54e289b6"),
Guid.Parse("0e642e7f-07f8-4ba3-bddc-ac09cee11c61"),
Guid.Parse("1eab8fc1-be97-4a0b-883c-9921e37164a0"),
Guid.Parse("7e91821a-ff26-4244-b70a-01ab6fff6f73"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 39,
    Value = 
new System.Guid[4]
{
Guid.Parse("4b13d169-47fc-4009-a164-a79a5c7bc0da"),
Guid.Parse("2796235f-c734-4dff-887a-f7746c6e30af"),
Guid.Parse("931eb45b-3291-4d85-aa13-21aeb9292196"),
Guid.Parse("a973ff70-9449-44e3-8d72-f7769cd1ef13"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("19a959ec-5060-4d7f-a730-61e3d8c3e37f"),
Guid.Parse("d9ee3134-a7a6-49ae-949e-25c814edfd12"),
Guid.Parse("b9e5c2e0-ca4b-410b-a10b-1aa49cf682a7"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("29dc6a07-fde3-4cb0-b365-4adb53524d06"),
Guid.Parse("1f20358b-a0d5-4559-9925-f6d1f8ae01ae"),
Guid.Parse("484eb88a-870d-4911-8970-f0868dc19ef1"),
Guid.Parse("66081b71-f803-489c-9050-c3af48f513e8"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 90,
    Value = 
new System.Guid[3]
{
Guid.Parse("489879f1-6704-4e90-bfd6-ea6ea7a6e89d"),
Guid.Parse("3062bdaf-ae8f-44f4-aee3-34129c3e3992"),
Guid.Parse("8693a4a4-089c-42e4-acbe-8bdee4ed84f3"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 99,
    Value = 
new System.Guid[3]
{
Guid.Parse("f2cad394-25c7-4e21-a4aa-75d92f606658"),
Guid.Parse("b52b7011-11a8-4c2f-8e52-3c4ef5af8e49"),
Guid.Parse("9e80e444-494d-4086-91f6-92b962ff1416"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 45,
    Value = 
new System.Guid[3]
{
Guid.Parse("aaaf31f7-e248-46a0-a626-4c7d7725dc37"),
Guid.Parse("290f344a-9219-41d1-9fe4-298bb907b7c2"),
Guid.Parse("1dfab872-f410-4f22-a2b0-53080cb61b6a"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("08ea1c71-8f01-401b-ab82-6d67de094550"),
Guid.Parse("4cb3d347-063a-4455-85b9-c86b4b09679c"),
Guid.Parse("be983cf1-8cd6-46aa-9882-74c411c44e06"),
},
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 103,
    Value = 
new System.Guid[4]
{
Guid.Parse("6ab08bcc-e658-4e5b-af9b-92a39d07f78f"),
Guid.Parse("a465f7e4-901f-4759-8de9-71caab3e8b3c"),
Guid.Parse("16b072bf-1231-4c2e-b851-cf6accc383c7"),
Guid.Parse("31164621-7d45-42c4-a117-0ceb5bc4c3db"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("3fef457a-de37-41be-8e13-a28a19084c19"),
Guid.Parse("11b3d71b-b32e-4667-9095-3939b457d058"),
Guid.Parse("be99af04-37df-4e7f-af30-39a077b2c73d"),
Guid.Parse("363484f2-267c-47ca-8cff-b4958f8f7971"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 106,
    Value = 
new System.Guid[3]
{
Guid.Parse("adf6a019-07f7-4bb8-8c38-5fd3260cd1c5"),
Guid.Parse("5c5d5ca1-c9d5-42fb-8133-82519202fa99"),
Guid.Parse("47057dfd-62e1-4c54-8429-02999e14d357"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 54,
    Value = 
new System.Guid[4]
{
Guid.Parse("bcf74d5a-b6f8-418a-a3b6-2f5422b39e52"),
Guid.Parse("4f4ed2d9-6e39-4350-b151-7fc923bdd8cc"),
Guid.Parse("9259a753-c825-4ec1-a367-6c80bdc89f5a"),
Guid.Parse("24a93b61-dd01-4c4e-86d1-fca6b171196b"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("93af84fb-b2f8-4d40-a57b-de5b58eb2b5e"),
Guid.Parse("adeb488b-4f71-409e-a0eb-ede93594e1d3"),
Guid.Parse("dc9cdc0a-4c11-4b65-814e-00defed7cefe"),
Guid.Parse("37cde2ed-614b-4a86-a2b9-b775750ef237"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("3c550f5d-6110-48d3-8348-c8b84e2c6692"),
Guid.Parse("76a4ab7c-8dfb-4ee0-a8d5-b2d89f6039b7"),
Guid.Parse("8973f30c-7a34-4f5f-891e-9b10bc4d07b2"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 111,
    Value = 
new System.Guid[4]
{
Guid.Parse("c541935b-2cc3-45af-95ce-6d9a2fcc113c"),
Guid.Parse("4b6a105d-7220-4e9b-a079-49679439ad26"),
Guid.Parse("42579e2c-c42a-4992-a5ea-94adc4ab68af"),
Guid.Parse("e56a1c5b-d7d2-454b-b529-50bb56e97fe9"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 113,
    Value = 
new System.Guid[4]
{
Guid.Parse("1e3fa62d-125f-4017-9753-cc1402b3b6e6"),
Guid.Parse("472036e6-34a5-4498-9e12-58d3f9d7471a"),
Guid.Parse("d6d7032d-95fa-4abd-b4a4-c354395742c0"),
Guid.Parse("7ecd2ba4-addb-49a0-82e4-3d9a997dab4d"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 59,
    Value = 
new System.Guid[3]
{
Guid.Parse("f76bfd41-a38b-455a-b3b5-690df470b458"),
Guid.Parse("93f246da-7dd5-44a6-8b23-c1a239746c08"),
Guid.Parse("9e0ff63b-06c1-47ad-bc54-10af4d785d21"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 119,
    Value = 
new System.Guid[3]
{
Guid.Parse("9bd263f0-bf9d-45f6-a2e1-83a412569c4e"),
Guid.Parse("7e401767-5b51-421f-b9eb-f9feb4d74952"),
Guid.Parse("c1d92128-80e8-4922-bd48-ceb910f348e4"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 128,
    Value = 
new System.Guid[4]
{
Guid.Parse("d9d3559b-6762-4890-bcf2-4ae8e99959f3"),
Guid.Parse("9ad772ef-8680-4930-86e4-4d5e130cb155"),
Guid.Parse("53f6c7ca-cd97-4890-b6f1-e1a1d63b39f1"),
Guid.Parse("8872cc3a-6556-4eb0-a279-03499c1926f2"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 68,
    Value = 
new System.Guid[4]
{
Guid.Parse("5ee400b3-da9b-42ff-baf0-847aa13d7e86"),
Guid.Parse("0b4dc647-ba6b-441d-b934-45c7fbf73cda"),
Guid.Parse("58e6b46d-c1d2-4c54-8925-90a68ab6cac4"),
Guid.Parse("895b4b16-05f2-4ccb-a33b-4364c5ed3d9f"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 131,
    Value = 
new System.Guid[3]
{
Guid.Parse("bb777b2c-424a-4094-82d9-9bcaccd73a3d"),
Guid.Parse("74d45a4d-daae-465c-be09-041361b6b4f8"),
Guid.Parse("a1be874e-e9ff-4663-a2f3-73f3f7baea77"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("59d92be8-c41f-4d17-b285-e193413e449a"),
Guid.Parse("fddbcb09-3ce0-4584-8724-fb4c3f3d1035"),
Guid.Parse("7518b7dd-60e2-4162-bd70-33a1e4db2d14"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 139,
    Value = 
new System.Guid[3]
{
Guid.Parse("c543d169-1bce-4039-810d-56cd31ea739e"),
Guid.Parse("a7d68b9e-a13a-4815-b03c-60d58637f945"),
Guid.Parse("45264bd1-c75b-458b-89b6-350758228498"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 73,
    Value = 
new System.Guid[3]
{
Guid.Parse("511c369c-a19a-4068-b09e-353dae27e0a8"),
Guid.Parse("5f3e7657-f5e0-4027-91da-f9c518104fcd"),
Guid.Parse("171d6d0a-f9b7-451b-92ec-12cdc357ab13"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("9e128cab-55c2-4858-8670-bbec6e6bc1b4"),
Guid.Parse("aa701093-5061-4529-af91-84744e9869c9"),
Guid.Parse("5653fb4a-2e95-439c-bfeb-077e8051b31a"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("9d03ea86-4659-4f47-bc97-2d368796f722"),
Guid.Parse("4edd83b4-f115-4c32-8659-19f067722907"),
Guid.Parse("2f758976-5ddf-4850-bd68-6a1c201e3a13"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 140,
    Value = 
new System.Guid[4]
{
Guid.Parse("2aa9a580-6c5d-4a35-b4e1-9dba04bfeabe"),
Guid.Parse("4bbdb972-dfd9-4814-a036-8d3198462b34"),
Guid.Parse("f4079363-d755-48e2-b34d-3692dd9ada42"),
Guid.Parse("6d2118ec-88fd-455c-8f22-53077923ceb6"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 148,
    Value = 
new System.Guid[4]
{
Guid.Parse("cf542aa5-ee55-48c7-9876-75f46ba7934d"),
Guid.Parse("cf14179f-b9d5-491d-adf5-e21bbafb9372"),
Guid.Parse("d70c251d-1f59-4031-8334-cbdd1712ca6a"),
Guid.Parse("fb2698c3-4d4e-40f6-a828-e6a097cbc6b4"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 77,
    Value = 
new System.Guid[3]
{
Guid.Parse("d4a804ea-2a76-47ef-83b4-de3ca9d2b73e"),
Guid.Parse("f20aebe0-d307-455b-b623-896458684667"),
Guid.Parse("cc992352-7c2d-4fd7-b359-c628ddeaa100"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("fa190a51-945f-4166-ae95-17c7051eabaf"),
Guid.Parse("21284e37-b9d9-47ea-875b-09c3060e361a"),
Guid.Parse("92f6c818-7913-4326-9576-eefeeca8fdfa"),
Guid.Parse("3bab3d27-a6ab-482b-9bd1-004fc49acfd4"),
},
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 154,
    Value = 
new System.Guid[4]
{
Guid.Parse("36164661-9db9-4f7e-a079-24e7d9849258"),
Guid.Parse("90140c7a-b0e8-488f-8de5-6d67d4b64f00"),
Guid.Parse("979a8fae-6ddf-4ccd-9c65-88b94e2e5d54"),
Guid.Parse("a4fb7a0b-34c7-446b-9197-4cc994f3de0a"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("6c41a400-7e6c-48b0-8dc7-3694821520c6"),
Guid.Parse("4891d921-ea35-4185-8b9e-c45700e699e1"),
Guid.Parse("ec3a3d78-f03a-41c2-93d0-45196cbc191f"),
Guid.Parse("57eb8a30-257c-45bb-ac49-aa84814b1969"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 163,
    Value = 
new System.Guid[4]
{
Guid.Parse("bca149a0-226c-4e5f-87a0-25238360e0dd"),
Guid.Parse("de49073a-b4f2-4e51-b94d-f8458d77d78b"),
Guid.Parse("c1d52732-497a-4dc8-a58d-002207397a66"),
Guid.Parse("c71bdbb8-ef8a-4a4d-852b-53b7d16358ba"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 78,
    Value = 
new System.Guid[3]
{
Guid.Parse("35882ab4-0d16-4d71-ac4f-348e3142496b"),
Guid.Parse("70888140-1458-4ecb-9d3d-740366a17fdf"),
Guid.Parse("9f98ccee-27cd-47c5-8700-ac79f6ce3cda"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("6de790ca-d59a-412e-9023-50f011679ddd"),
Guid.Parse("0f05aeb2-c136-4c97-a357-5c12582d233c"),
Guid.Parse("2f1f113b-2c3d-4ff2-8081-ef763829997c"),
Guid.Parse("9cc20dd6-c8d8-4d4e-8c93-1e111e4253ca"),
},
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 170,
    Value = 
new System.Guid[3]
{
Guid.Parse("992c6730-2067-4f0d-8019-91d05653180f"),
Guid.Parse("f74acf10-77d2-4df0-98b2-30b901ca7a8c"),
Guid.Parse("1f705eaa-0c56-408d-8d29-686962722acd"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 173,
    Value = 
new System.Guid[4]
{
Guid.Parse("9f91106a-aa73-42cd-a20c-798cfcafc950"),
Guid.Parse("6b011fd6-aea5-4776-b9e0-b73257cfb77f"),
Guid.Parse("f1605dc0-db2f-45db-b83b-f963c347dd46"),
Guid.Parse("75aec341-2b1d-4c9d-a450-b15da5847e32"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 80,
    Value = 
new System.Guid[4]
{
Guid.Parse("798df054-90d6-4eb9-913b-9579d139dfee"),
Guid.Parse("915339f6-30df-4dbd-9e57-9fd98b255215"),
Guid.Parse("d2f77847-575c-4da1-9d3f-332bb81a3ef4"),
Guid.Parse("0eb603f9-e66d-4b84-9942-44af9e4d0b15"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 179,
    Value = 
new System.Guid[3]
{
Guid.Parse("28c3f5f1-c98b-4d80-af65-ee0e2c94e9ad"),
Guid.Parse("6d5fa2e3-81c1-41d1-9554-d67360d9ae1b"),
Guid.Parse("495aaeb5-4c24-4bf6-8c25-25dc702c320d"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("6d9cfc40-a852-42ff-9e2f-1bf5a8a7b867"),
Guid.Parse("cc504300-0205-4a49-8676-56e0c71606fd"),
Guid.Parse("20afef43-65a6-4b47-aabf-269d8b6d5334"),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd1e1mi(
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
INSERT INTO public.guiduuidmmarrayd1e1mi(
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
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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

                changedRows =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    guiduuidmmarrayd1e1mi_id
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)), 
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
                methodParametrName: "guiduuidmmarrayd1e1mi_id", 
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
                changedRows =  ((IGuidMArrayuuidMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IGuidMArrayuuidMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    guiduuidmmarrayd1e1mi_id
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
    guiduuidmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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

                    nullable =  ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("d0344b92-21d8-477f-9f4b-ecf469d89a7f"),
Guid.Parse("e1dd45e6-b729-485e-9e71-bfbbf8e375ee"),
Guid.Parse("948811e6-f385-475c-be76-abd127ad3bc5"),
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

                    nullable =  ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable = await ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
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

                    nullable = await ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("bd416f6b-c1a0-41ec-bff9-996b3db407b2"),
Guid.Parse("1fef0eb6-c4db-4459-991f-52a6488bfd9d"),
Guid.Parse("4f8c9d6e-d210-4347-9a4d-bc99b754e6e4"),
Guid.Parse("ac4bc7d0-f1c6-43e0-acec-a4831ac82e0f"),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    guiduuidmmarrayd1e1mi_id
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
    guiduuidmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                methodParametrName: "guiduuidmmarrayd1e1mi_id", 
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
                nullable =  ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
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
                nullable = await ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("06454751-d59b-43c5-866a-3adcbe56d36f"),
Guid.Parse("51cdc25a-a2dd-48f4-80db-3a6f4285d01f"),
Guid.Parse("990e848c-64d1-4612-860a-15ef805d9300"),
}));
                nullable = await ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidMMArrayD1E1M> models = null;

                models =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidMMArrayD1E1M> models = null;

                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M), typeof(FlatGuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guiduuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                ((IGuidMArrayuuidMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guiduuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IGuidMArrayuuidMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidMArrayuuidMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
LEFT JOIN public.guiduuidmmarrayd1e1mi mi ON mi.id = m.guiduuidmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models = await ((IGuidMArrayuuidMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IGuidMArrayuuidMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M), typeof(FlatGuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guiduuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                ((IGuidMArrayuuidMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guiduuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidMArrayuuidMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidMArrayuuidMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
LEFT JOIN public.guiduuidmmarrayd1e1mi mi ON mi.id = m.guiduuidmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models = await ((IGuidMArrayuuidMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IGuidMArrayuuidMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M), typeof(FlatGuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[21],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 163;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 170;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 170;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 170;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
LEFT JOIN public.guiduuidmmarrayd1e1mi mi ON mi.id = m.guiduuidmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models = await((IGuidMArrayuuidMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[34], false);
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
                var models = ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M), typeof(FlatGuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 139, query1, 106, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 90, query1, 119, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 103, query1, 16, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 65, query1, 68, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 170, query1, 64, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 128, query1, 163, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 48, query1, 106, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 37, query1, 68, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
LEFT JOIN public.guiduuidmmarrayd1e1mi mi ON mi.id = m.guiduuidmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models = await((IGuidMArrayuuidMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 51, 51))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
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
                var models = ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 154, 139))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
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
                await using var cmd = await ((IGuidMArrayuuidMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidMArrayuuidMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 48);
                var models = await ((IGuidMArrayuuidMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(25));

                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[10], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[11], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[12], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[13], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[14], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[15], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[16], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[17], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[18], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[19], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[20], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[21], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[22], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[23], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[24], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[25], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[26], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[27], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[28], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[29], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[30], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[31], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[32], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[33], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidMArrayuuidMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidMArrayuuidMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 68);
                var models =  ((IGuidMArrayuuidMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(20));

                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[34], false);
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
FROM public.binary_guiduuidmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD1E1MIWA),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidMArrayuuidMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidMArrayuuidMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidMArrayuuidMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidMArrayuuidMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD1E1MI),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidMArrayuuidMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidMArrayuuidMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IGuidMArrayuuidMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidMArrayuuidMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
guiduuidmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(GuiduuidMMArrayD1E1M),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
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
FROM public.binary_guiduuidmmarrayd1e1m m
LEFT JOIN public.binary_guiduuidmmarrayd1e1mi mi ON mi.id = m.guiduuidmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IGuidMArrayuuidMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IGuidMArrayuuidMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((IGuidMArrayuuidMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    guiduuidmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models =  ((IGuidMArrayuuidMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidMArrayuuidMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA), typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models1 = new List<GuiduuidMMArrayD1E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD1E1MIWA>();
                await ((IGuidMArrayuuidMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD1E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD1E1MIWA>();
                ((IGuidMArrayuuidMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models = await ((IGuidMArrayuuidMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
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
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
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
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA), typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
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
                var models1 = new List<GuiduuidMMArrayD1E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD1E1MIWA>();
                await ((IGuidMArrayuuidMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD1E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD1E1MIWA>();
                ((IGuidMArrayuuidMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
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
                var models = await ((IGuidMArrayuuidMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
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
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
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
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MI), typeof(GuiduuidMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models1 = new List<GuiduuidMMArrayD1E1MI>();
                var models2 = new List<GuiduuidMMArrayD1E1MI>();
                await ((IGuidMArrayuuidMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD1E1MI>();
                var models2 = new List<GuiduuidMMArrayD1E1MI>();
                ((IGuidMArrayuuidMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models = await ((IGuidMArrayuuidMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA), typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
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
                var models1 = new List<GuiduuidMMArrayD1E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD1E1MIWA>();
                await ((IGuidMArrayuuidMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD1E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD1E1MIWA>();
                ((IGuidMArrayuuidMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
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
                var models = await ((IGuidMArrayuuidMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

