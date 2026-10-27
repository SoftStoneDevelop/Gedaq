

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
    internal partial interface IGuidMArrayuuidMMArrayD2
    {
    }
    
    internal partial class GuidMArrayuuidMMArrayD2 : IGuidMArrayuuidMMArrayD2
    {


#region TestData

        private readonly GuiduuidMMArrayD2E1M[] _testData = new GuiduuidMMArrayD2E1M[]
        {
            new GuiduuidMMArrayD2E1M
{
    Id = 2,
    Value = 
new System.Guid[,] { { Guid.Parse("946f4faf-f129-4e66-98e4-ae012ed40f1d"), Guid.Parse("169c13b3-5a13-4dce-88b5-70130ee54a58"), }, { Guid.Parse("33828e31-fd27-4a03-94ed-de3343ed8393"), Guid.Parse("f842a35d-e4e2-4dba-b38c-8cd0f5744465"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("955fb5a3-ef4d-46d7-abed-0e35f93ae0a5"), Guid.Parse("52f4aff4-5362-4fea-bbc2-e9640d31267e"), }, { Guid.Parse("743ef62b-6ca0-4906-8494-541e5b35bf52"), Guid.Parse("1960b750-6d08-43ae-be80-675388a6bc7a"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 10,
    Value = 
new System.Guid[,] { { Guid.Parse("287e8fa7-0a8c-4466-8ecb-840831ee4524"), Guid.Parse("d1119e66-e8ce-4643-8736-fb92c2671cba"), }, { Guid.Parse("c5372eb4-e4fa-4178-b1f6-ef1703c50e62"), Guid.Parse("0092b4fd-3d90-472f-a328-da589a00e02f"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 2,
    Value = 
new System.Guid[,] { { Guid.Parse("96c038fc-c20d-422c-9ae7-b6a9aebdf5ad"), Guid.Parse("d0d302ff-0edb-401c-8987-022f9a2a307b"), }, { Guid.Parse("34ff764e-8696-4700-a178-ca14c8c112ba"), Guid.Parse("f6609d89-5cf3-4375-9b40-24d77864b1da"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("ef812749-2e22-44bc-8d08-beb4119f0514"), Guid.Parse("460736e0-fca2-4015-a9da-4bff4dee6adc"), }, { Guid.Parse("4c96a068-55d0-49e6-9cf3-45a94bc6c2ed"), Guid.Parse("5a7ead07-7eb3-46c2-a61c-52f8d3e0d8ac"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 11,
    Value = 
new System.Guid[,] { { Guid.Parse("2b963a4c-dd05-434c-a4b3-d90e8d4aadd5"), Guid.Parse("184d0a69-52e8-48fd-8560-f226053865c2"), }, { Guid.Parse("e7ff816f-d3d7-4b82-918d-72ea145fc06f"), Guid.Parse("e8a252ce-7cf4-45a3-9063-d8330274fe9a"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("ed13fd8c-bd62-4a5c-8b8e-b792262f4e8f"), Guid.Parse("a50d36bc-6baf-43a6-bd23-2b5a132db71c"), }, { Guid.Parse("1bedb477-6f17-41f3-aeb3-6439f223c3dd"), Guid.Parse("c770ac30-c527-4f6f-9529-8ce2fa21c048"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 13,
    Value = 
new System.Guid[,] { { Guid.Parse("2f83721c-11f9-408c-a405-4cf4b1ed3b9f"), Guid.Parse("178513a2-cc2c-49fa-90f3-5e9cb53735c1"), }, { Guid.Parse("a1a8d38c-a8a7-4592-b8f2-91b4580d379b"), Guid.Parse("fba5e72a-a67a-4da9-9866-925b1df07da7"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 3,
    Value = 
new System.Guid[,] { { Guid.Parse("b419da34-f51b-4b59-8457-c69d1d5de2e6"), Guid.Parse("729ee07a-7462-4169-878a-48ddbada5327"), }, { Guid.Parse("523387ae-a091-4725-9c69-3edaa2b2573a"), Guid.Parse("c48487e0-f9d6-4c6d-adfd-35d55f101f42"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("0474598f-0322-4c73-b157-9a75e2a5c643"), Guid.Parse("c83d3bc1-6762-4cc5-affa-6574a89f7d96"), }, { Guid.Parse("8a5c9f97-f8e2-406b-bf5c-8a5264ad4ea0"), Guid.Parse("acd74bd6-092b-442a-a723-d0dfb5536b29"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("9715bef3-77f3-4156-9bdf-2aa7c8447b06"), Guid.Parse("e4b344bd-79d6-44b1-add7-e4d73a6e3095"), }, { Guid.Parse("ae29516d-9fa0-474b-bf93-e9533e5a5554"), Guid.Parse("1975144e-6ba9-4aa7-9c6d-e89d163a4180"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 21,
    Value = 
new System.Guid[,] { { Guid.Parse("e6b7fa1c-f6d8-4da4-91a6-4a9d5916da2e"), Guid.Parse("13d4483d-4f0b-4823-9960-d26785052ca5"), }, { Guid.Parse("9f4afd1b-fd33-406f-b51f-46e5ca62f4e6"), Guid.Parse("ee3d5b1f-c945-4213-b499-600f53b376e0"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 22,
    Value = 
new System.Guid[,] { { Guid.Parse("14d91f31-a66e-4d6a-825b-aa93a954b951"), Guid.Parse("d9513571-892a-4e46-ab2c-5a1d532fc820"), }, { Guid.Parse("29b1d2be-6c87-439a-9f71-c582e7d6afc6"), Guid.Parse("b4539d3e-d02e-4f34-b311-dc3a23892a3b"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 11,
    Value = 
new System.Guid[,] { { Guid.Parse("2c56837f-9dca-4a03-b226-d79c9fc7d9c7"), Guid.Parse("3d350a06-4c93-49d3-a943-76ea54f3edf9"), }, { Guid.Parse("01a1d033-7463-4993-be46-5377a8bf48f6"), Guid.Parse("0ddef600-bc28-4d6f-a4d0-7b63cf22ccdd"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 28,
    Value = 
new System.Guid[,] { { Guid.Parse("05017ec3-2231-4d38-a7e9-ba99394991d5"), Guid.Parse("e15d24c8-34ce-4a12-8a07-8b9a78bd56aa"), }, { Guid.Parse("78c5061c-e5d8-4be5-afea-ef66b7771347"), Guid.Parse("b46f73e0-fc23-4738-82f7-a2c48d6b04b5"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 31,
    Value = 
new System.Guid[,] { { Guid.Parse("88e1aff8-6aab-42c0-97cc-9be439848942"), Guid.Parse("88d96af7-bc01-434f-b75f-92fe987f391f"), }, { Guid.Parse("293539e2-978f-4c23-a0d4-d103e738b1c4"), Guid.Parse("b62a7e33-e6e1-4a1c-a3e9-495ad92ea6c5"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 16,
    Value = 
new System.Guid[,] { { Guid.Parse("1b829a48-d407-4db5-8d54-8694877132ed"), Guid.Parse("5914dbe6-856a-46fe-b0df-6800a9ec5ae6"), }, { Guid.Parse("ca01bd94-8349-4d67-a800-25d13e2411b4"), Guid.Parse("f32fa0c8-8b09-4260-919e-bfb0acdc027d"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("06b683f1-06cf-4b28-b85b-98ef351d758f"), Guid.Parse("52d2ec57-890b-4c9d-b809-12180f4e9089"), }, { Guid.Parse("98e07223-0b9d-4197-8f0e-e00f45b78182"), Guid.Parse("aaa2d081-b9b2-44d1-a3e4-5307a388251a"), }, },
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 40,
    Value = 
new System.Guid[,] { { Guid.Parse("c3385783-971a-4b6e-ab7a-3d3f9aa94ced"), Guid.Parse("bdf34121-fc95-4cf4-bd21-140c581f46a4"), }, { Guid.Parse("ccabea97-db41-43b3-abce-ac82d80cb8f8"), Guid.Parse("5db64291-b3c8-4fe6-898e-7bed2db9f281"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("e55376ed-0674-45b0-b1a4-f6ffaebce1eb"), Guid.Parse("6f2d9b29-0290-431b-940c-7cb56bf2812b"), }, { Guid.Parse("10c3e110-02f3-4ac9-80a7-2638ab8db837"), Guid.Parse("c626b299-38e2-4e88-b765-421b713194d5"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 43,
    Value = 
new System.Guid[,] { { Guid.Parse("5f5a5b2a-f978-4b36-b695-2b90ca44f765"), Guid.Parse("d3ce18d5-63d7-4787-8eee-b69ac7b66984"), }, { Guid.Parse("e3278df9-161b-4e8b-b17d-f4ea66bd2ecc"), Guid.Parse("29955b15-bfba-461c-a20e-0af6c9e1be22"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 23,
    Value = 
new System.Guid[,] { { Guid.Parse("efe03474-042f-42b5-acda-18c2fcd532b4"), Guid.Parse("b2ac9775-302c-4e62-a397-8f818182da37"), }, { Guid.Parse("c4a60be9-5bdb-4304-a6ae-89a0087d1000"), Guid.Parse("0b18e345-1a11-47ae-9edb-f208813335b3"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("2eb0dd31-7a2d-4419-a27d-3102a6e95a12"), Guid.Parse("0e98adec-01a7-4f07-bb07-71920dfcf825"), }, { Guid.Parse("d1a4ef8a-722c-4a2f-a132-a7a2b24c622c"), Guid.Parse("bbae2b56-94ae-43a8-952e-9ca772c08a65"), }, },
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 45,
    Value = 
new System.Guid[,] { { Guid.Parse("0860eafc-4307-4268-bb99-fa5bd199a864"), Guid.Parse("b83e51a5-8994-4a2d-81ae-e85dd9544b7d"), }, { Guid.Parse("ec72e870-6140-4bab-bb4d-1f15f8d6cc24"), Guid.Parse("997e6d31-450a-4fd7-a262-37b1a2171103"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("596c8684-4db7-49bd-9e0f-7cde87bd8460"), Guid.Parse("5b00cd85-4d64-4981-80b5-4a46fdb527cb"), }, { Guid.Parse("e6607a47-7c0d-4571-ab7d-893c9a19ced7"), Guid.Parse("2a143014-fa6d-41c8-b62f-aa11432d2e9f"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 52,
    Value = 
new System.Guid[,] { { Guid.Parse("41e07077-66e0-4043-9f12-f5474a9d02b3"), Guid.Parse("11a5f7ce-9000-4b42-9af0-f094f3d281f6"), }, { Guid.Parse("c4ae197f-a842-4d47-af19-c2fe7148a1ae"), Guid.Parse("b7aaf30f-2bcb-4d96-8c97-9763ff2e9765"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 32,
    Value = 
new System.Guid[,] { { Guid.Parse("cc5010d2-7376-42c4-b813-b2dfa3757f6f"), Guid.Parse("7fed61bc-e57e-453a-ac28-d98d25c49701"), }, { Guid.Parse("6696bed7-b5da-491c-be8e-9f71970ecc05"), Guid.Parse("aecf7b0e-78cc-4010-9a04-327c44af75d9"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("d0ecf225-7d18-435d-961c-e13ffb78722b"), Guid.Parse("063a5f55-a530-4782-9f0f-9fbbe274535e"), }, { Guid.Parse("2d670ade-c630-45af-a302-af5a1f685554"), Guid.Parse("a005d2fc-ffd8-46f4-b5f4-2906e7f5502a"), }, },
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 53,
    Value = 
new System.Guid[,] { { Guid.Parse("c28b15c4-d850-49a3-ab86-4c57b84f9937"), Guid.Parse("a1ce4b55-0576-4d4d-9dea-bcd1e21a342b"), }, { Guid.Parse("1f593dcb-f087-48e9-a488-2b19b0792ce5"), Guid.Parse("6ee029bb-29dc-4e9e-a4e5-0acf9c7a8371"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("1f82b2d9-2e45-491c-b008-1d37e9baa1df"), Guid.Parse("6a0abc06-ea72-4264-bad4-80e29d33ea49"), }, { Guid.Parse("205279f0-e712-4ea0-9118-15649bb9c8ec"), Guid.Parse("c4283d64-8cee-451c-b901-a9df8ad8e1ea"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 58,
    Value = 
new System.Guid[,] { { Guid.Parse("743c5b3e-bb1a-459b-8538-9f51a5accc20"), Guid.Parse("d9e66656-f536-490a-a063-002d6d9a8e29"), }, { Guid.Parse("84ba3a87-158b-49cd-9e77-46e04cdeaa03"), Guid.Parse("75e207a6-b158-467e-a943-548993730c35"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 41,
    Value = 
new System.Guid[,] { { Guid.Parse("31394700-a57c-4f48-966e-5561682846fc"), Guid.Parse("52bb0766-3f38-40a7-96b9-87f27fcb3467"), }, { Guid.Parse("2d20d797-86ed-4a80-8ab0-9f2549e8b606"), Guid.Parse("db341e85-57ba-465b-8e4d-09c42848397a"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 63,
    Value = 
new System.Guid[,] { { Guid.Parse("fc98c661-f089-4d6b-946e-885e3587b4ce"), Guid.Parse("7b6840ab-ee78-4b7f-b757-4955ae52e2cc"), }, { Guid.Parse("24f56f55-00fb-4543-8257-dc035f6c1106"), Guid.Parse("f8143212-72fb-4dd0-9b4f-1d44dc4fff44"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("b23ed376-4a12-4422-9d9e-5532d0224e33"), Guid.Parse("6ac99329-abe9-4caf-a438-1db4760956ea"), }, { Guid.Parse("8c428a60-c53a-4350-a790-396d6793292a"), Guid.Parse("7d458f60-752d-40b4-8890-f38922568a3a"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 64,
    Value = 
new System.Guid[,] { { Guid.Parse("18cce79e-9f01-4856-b0c8-0adc3ca88f1c"), Guid.Parse("b7b48750-fbd0-4fdf-9be5-c07ca974b1de"), }, { Guid.Parse("01ecac4c-d15c-4483-9337-8cc0bc2362e8"), Guid.Parse("ffcb6af1-cedb-4e80-a095-023d77377015"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 49,
    Value = 
new System.Guid[,] { { Guid.Parse("0d5e6423-8a9d-4e1e-8d4b-8e65150944b5"), Guid.Parse("21af79ba-0dd0-402d-90cc-df3ca54ac9f3"), }, { Guid.Parse("f447f792-a533-42e6-927a-de33baa82bb8"), Guid.Parse("f48138dc-96dd-42a6-b2fa-2a63179a19c3"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("c9fb00fb-4839-4bcb-842d-c4fa2b437e28"), Guid.Parse("c70bd80f-86e8-4f4d-8551-1f86f3a61873"), }, { Guid.Parse("b265baed-b273-4148-a40b-0d3a700aa3c3"), Guid.Parse("d10b58f9-2629-40a4-b6ce-9b926c100572"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 69,
    Value = 
new System.Guid[,] { { Guid.Parse("ef564967-da47-4c18-8323-6ea708cf45b6"), Guid.Parse("a7bb4130-6f86-4574-b999-b70ca45f832d"), }, { Guid.Parse("8ec88783-a5d5-4452-a501-53d7bc4fa2cf"), Guid.Parse("7e587ecc-3b61-4f66-9f2a-25d8c4f2677a"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 71,
    Value = 
new System.Guid[,] { { Guid.Parse("e3a0117e-d711-4e89-b4f0-52be105962d8"), Guid.Parse("31f74d41-63f9-41af-a61c-a1f9671a4b02"), }, { Guid.Parse("e9674428-2e15-47a7-8414-26eed388390d"), Guid.Parse("f65b2f92-ed2c-48f1-b56f-2942130d99ae"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 50,
    Value = 
new System.Guid[,] { { Guid.Parse("b0608981-84a9-43e2-9e50-8da32aa76abb"), Guid.Parse("86490d67-ca1d-43d6-b23e-4f4e7221bbb7"), }, { Guid.Parse("8b063683-ddad-41cb-b948-22f1301f5bcc"), Guid.Parse("e61c5d50-f5e1-4dc3-82db-4f8a4d2bc5be"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("8406a257-b435-400e-8d2e-b0d47b74b3d3"), Guid.Parse("f31bba2c-13eb-498b-8562-52951bc7948a"), }, { Guid.Parse("97ae6cd0-5344-4618-ba98-9015180aaf8a"), Guid.Parse("309c18d4-f952-47a0-9619-2b4931edd958"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("b636bf38-ad0e-4d84-b533-436b3c174b49"), Guid.Parse("b8e50229-de91-4ea8-86fe-434e507c1a94"), }, { Guid.Parse("2b465b2b-1c48-459b-bf46-079089f21480"), Guid.Parse("6cd18e81-d0af-45ce-bf3e-8717b9d30829"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 77,
    Value = 
new System.Guid[,] { { Guid.Parse("9ebda4c8-20b7-4de7-989d-8160dd260a25"), Guid.Parse("35107306-65dd-4aea-b2de-c09392622acb"), }, { Guid.Parse("a4f10ab4-642e-4f10-a569-acab30cb02dc"), Guid.Parse("ffe53273-2c76-4d43-8b97-6d663d556255"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("fa41e850-c0fb-4f05-9e82-5b2f37966b5a"), Guid.Parse("fa86fb54-0aaf-4087-ae12-2660abdf8c3f"), }, { Guid.Parse("35e9bc94-0420-4a80-91a1-9ed64eff4591"), Guid.Parse("9ae922d1-6be6-46a0-bc84-34d09bf4a5dc"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 83,
    Value = 
new System.Guid[,] { { Guid.Parse("006631d7-b895-48b8-8943-82d8ebb76fea"), Guid.Parse("a161b618-9907-4f99-9701-80e877b46fd8"), }, { Guid.Parse("0d998df8-c367-4f02-b276-d35369786268"), Guid.Parse("93c5f44d-88da-44c6-8b2c-86752463738e"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 55,
    Value = 
new System.Guid[,] { { Guid.Parse("89f16dbd-a270-470c-9770-8faeb2b958e6"), Guid.Parse("8f3e6168-7945-42ee-b05a-573a375ccc1f"), }, { Guid.Parse("1b2f634f-1404-4ff9-9456-bca5ff6571b2"), Guid.Parse("7f6159ec-c5a5-4047-97a4-d20c0c5c3236"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("3a387d56-4372-417c-863c-957ad4fe6512"), Guid.Parse("c4087e8f-7910-480f-8d0e-13ca049fce7a"), }, { Guid.Parse("9916ee1d-8298-4fec-816e-cdb46e1909d3"), Guid.Parse("5c318490-4d07-47e9-9af3-cbaaf91eb9ef"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 90,
    Value = 
new System.Guid[,] { { Guid.Parse("d0c35f0d-6b92-4b37-ba65-4afc817fd85c"), Guid.Parse("2d300848-6e7d-4497-97ba-46b856800a7b"), }, { Guid.Parse("4f8ac6b0-515f-4e87-86dc-e205dbfe321a"), Guid.Parse("e9008b30-a8e2-402a-9bb7-2f4db827c9d1"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("8802f958-80b6-4ed2-9ab8-ea8d2984f1e4"), Guid.Parse("44d3d41b-bb1c-492a-b789-7f1973f7d6d7"), }, { Guid.Parse("1e6b3b25-3f4f-4de0-b96a-f4c7b2b53423"), Guid.Parse("4a09e6c9-4ab6-476f-875b-6b461f42acd9"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 98,
    Value = 
new System.Guid[,] { { Guid.Parse("e2525c3f-f688-482c-8a77-81ace3ee7a06"), Guid.Parse("ac273990-daf5-442b-84e6-3c70b3530fd5"), }, { Guid.Parse("d8734c7d-2e7e-4595-be14-3b918ffa5b9d"), Guid.Parse("eca90813-7812-471c-b0a3-2dfe49282147"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 63,
    Value = 
new System.Guid[,] { { Guid.Parse("9431b4dd-9728-41f1-9921-692e4aa580bb"), Guid.Parse("a86700db-acfa-40f6-b984-f06723311833"), }, { Guid.Parse("a687454a-2eb3-482b-945a-c4e6bdd5a8a3"), Guid.Parse("2858aa61-f96f-4762-b632-e60028c79bcf"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("0148ca67-4bed-486f-8b3c-de48bc0b9b6c"), Guid.Parse("7a50f42f-5f0c-460d-9864-97595168af59"), }, { Guid.Parse("79933689-26ee-4539-a82e-a6de11d66c46"), Guid.Parse("448551c6-b9cd-4ba1-89c4-58d64a1f20cd"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 105,
    Value = 
new System.Guid[,] { { Guid.Parse("a805dd6c-8d86-4b3f-9266-59334e8f88e0"), Guid.Parse("eb77889e-53e5-4b22-9154-6b52ee7de037"), }, { Guid.Parse("9346e9a3-b0cd-4fba-991c-4d6d09306749"), Guid.Parse("fb20cf5c-ead8-4a63-bbea-5d82224fed7e"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 112,
    Value = 
new System.Guid[,] { { Guid.Parse("a8c0cf98-84cd-49e1-aa9b-e7bc7a933044"), Guid.Parse("4221d5a1-1057-44df-8fdd-a075d7b51935"), }, { Guid.Parse("12d8d18d-68dd-4f3f-953f-cc4258f11d0f"), Guid.Parse("3bc50c47-4d0e-4f48-ba04-cdd1dfea407f"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 70,
    Value = 
new System.Guid[,] { { Guid.Parse("3337a8e2-2b70-4a7e-af76-7d1de9ec133b"), Guid.Parse("c28cdb40-9520-43c4-bab0-e8444b868e78"), }, { Guid.Parse("4e381028-dd04-484b-b4d5-e8837247a088"), Guid.Parse("44000020-4208-44ad-a45c-d4a8654db44d"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 121,
    Value = 
new System.Guid[,] { { Guid.Parse("cb2dd11c-b571-479d-9864-0c5258c08ed1"), Guid.Parse("85acfd82-dee1-4df4-8fb3-bd98c57f334e"), }, { Guid.Parse("984c73e7-8908-4f30-8351-dbc1b62e0873"), Guid.Parse("8984ae12-e240-4bd4-a563-2915191e117d"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 128,
    Value = 
new System.Guid[,] { { Guid.Parse("081fefaa-59e9-4bd3-9a88-6d87ab375f7d"), Guid.Parse("af50e8ce-d40d-4f83-81a1-04ac5b61c606"), }, { Guid.Parse("4654cf3b-83cc-4025-9c79-23092d3366f6"), Guid.Parse("f15e55ac-d9d4-4ccc-aa59-af4183cf2387"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 73,
    Value = 
new System.Guid[,] { { Guid.Parse("c3b5c7ef-6260-407f-b60d-227546c0bbce"), Guid.Parse("4f8b5a29-c3d0-42f6-8d94-b2fd52700d46"), }, { Guid.Parse("352bd29c-58c7-46d8-9b4f-0efecd91db8a"), Guid.Parse("4dbf723f-eff3-46db-a380-22d34d0fed75"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("6ade4f76-4452-4d5e-ac60-592cc70d16d9"), Guid.Parse("74fb766c-4d4f-489f-a8d0-655fd19cdb5f"), }, { Guid.Parse("62e07ced-4f3f-47e3-b6a5-e94987054192"), Guid.Parse("d194b2a0-f2aa-421e-8081-5a0c36eec530"), }, },
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 129,
    Value = 
new System.Guid[,] { { Guid.Parse("bc19b637-e92a-4c79-8003-579c77764292"), Guid.Parse("3742c236-ecb6-4221-92c9-ad5f270fe731"), }, { Guid.Parse("91c0689d-b274-4061-934f-3602580ab4dc"), Guid.Parse("a9b58b59-0f4c-4403-b8d7-e651dad830ba"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("3ed897dd-f85a-459a-8083-1545784b3885"), Guid.Parse("55f3e6f6-75b1-43f0-a701-a9b9a3c10767"), }, { Guid.Parse("bde2305b-e0f9-43a7-aff6-705a6851d9b5"), Guid.Parse("6ac5e13a-9869-4770-a39e-39c1eff153ca"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 130,
    Value = 
new System.Guid[,] { { Guid.Parse("4a87f774-aba0-475b-8cd0-f778c2a8fb02"), Guid.Parse("39df3e88-c819-441b-9d42-b464fef54c15"), }, { Guid.Parse("d2912cd1-1309-435f-a7f3-a198c5a615f1"), Guid.Parse("400ddb6a-cbeb-4163-a375-60b318149be8"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 79,
    Value = 
new System.Guid[,] { { Guid.Parse("2ba31b6a-3beb-4770-8d7b-06a7615f4d6c"), Guid.Parse("6e527da7-2d6a-47c6-9761-b2152841cb39"), }, { Guid.Parse("ecd51e13-8705-4e16-88c4-2f3d352581ff"), Guid.Parse("c3d9763c-9d41-43f9-a2a8-aab71d127018"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("d7e95a3e-fc1e-450d-8f85-99f998d2ca31"), Guid.Parse("36692a90-7ee8-475d-8c37-aee0d6bbb9f5"), }, { Guid.Parse("968fe1ce-80bc-42f2-a115-04330f3b4eda"), Guid.Parse("1552b816-739f-4abc-8eda-dfd59a1f3f67"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("dd98e04a-eda6-4701-8f54-35c0447ff2b4"), Guid.Parse("66809030-d3ff-414f-a551-0d25c5fbec85"), }, { Guid.Parse("67cb8c86-646a-4e7d-9592-2838af100e30"), Guid.Parse("dc8b37a9-6dc4-424e-8ac5-462a10591594"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 139,
    Value = 
new System.Guid[,] { { Guid.Parse("6c963ce3-d752-49b6-ba58-4e5acfb815bc"), Guid.Parse("854566b3-79d0-49a1-9054-7b40c4b70828"), }, { Guid.Parse("9d1ca989-df88-43e2-92ea-9309fbb3cfd8"), Guid.Parse("b9ed67b7-d624-4986-b8b1-27a8eb4caadc"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 145,
    Value = 
new System.Guid[,] { { Guid.Parse("c35df2d3-60a1-4741-a8d4-31c60587968e"), Guid.Parse("bd7c99c0-6d4e-40e8-9b7d-e2bc179c0218"), }, { Guid.Parse("b21e32d6-850a-4d14-9fc9-9d2b5363a491"), Guid.Parse("70a3e021-1147-4e06-9af0-8bf532a5ff20"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 83,
    Value = 
new System.Guid[,] { { Guid.Parse("6bcb0808-c1dc-452e-a723-3c297df7e6d8"), Guid.Parse("408120b2-6068-4af5-b2f8-0dc3bc7c8886"), }, { Guid.Parse("49d56343-d402-47ba-b3aa-68813e0a9317"), Guid.Parse("11f30f80-6aa5-4113-93bb-b27190b52aac"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("7196b8da-8355-4ddb-9104-2e112a655f0e"), Guid.Parse("edd1c264-dfeb-4d73-80ef-023a26c8cc0f"), }, { Guid.Parse("edd27d3a-21bf-4d16-9283-6a4546290e81"), Guid.Parse("4f40220b-b040-4d24-bb04-acf2ba1b78d0"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 146,
    Value = 
new System.Guid[,] { { Guid.Parse("f2dbd2c0-146b-4299-888b-bbcd83439a1e"), Guid.Parse("82b17bcf-e126-4cae-bf0e-1f06546f4984"), }, { Guid.Parse("71f61aed-c85a-4fe0-ae9a-e51388f7b854"), Guid.Parse("dfee4fd6-9a54-496e-a357-8969db0c9df2"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("e9bf3270-4659-4f33-a4ac-83c883d28da6"), Guid.Parse("fa2a62d9-a966-462a-98ec-cd73654af263"), }, { Guid.Parse("e1d3b18c-eed4-46af-bd1b-c6b9eaf5c4fb"), Guid.Parse("4eb05dca-8a57-497b-8901-96848db23eb3"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 155,
    Value = 
new System.Guid[,] { { Guid.Parse("108bfa09-0c47-49d6-ad38-0f9ed0f9b800"), Guid.Parse("b5c50a3c-65bd-4d76-99a7-d71fa23bd42d"), }, { Guid.Parse("3c12f6dd-8a22-445d-85a1-57532f54b930"), Guid.Parse("d303d2a8-fd4e-4142-8996-673cc5135507"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 91,
    Value = 
new System.Guid[,] { { Guid.Parse("933de7f3-29dc-4352-9481-e3165c81fb8e"), Guid.Parse("8246052e-5ad8-4dca-8aa8-8dc179ea2e1d"), }, { Guid.Parse("dbc1e0c5-8489-4f38-b7f8-c79b7a1305b6"), Guid.Parse("06936a88-4da7-4499-a60a-35edd076f300"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("b59ef891-5193-4891-bfe7-f9eeede3be6d"), Guid.Parse("8ab31128-a072-4af7-9db2-72c339ed7673"), }, { Guid.Parse("217ab6ba-c966-440c-826f-3faf8a42cb13"), Guid.Parse("a13a1fb8-4495-4325-93df-cf143e65494e"), }, },
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 162,
    Value = 
new System.Guid[,] { { Guid.Parse("9cd049d1-4d4c-4d3d-b6d1-0a555a181fcb"), Guid.Parse("876b8827-1d29-46b1-b264-ae25b6eae820"), }, { Guid.Parse("497b8635-b105-415e-88c4-cdf29c1dfd3c"), Guid.Parse("f695272c-4556-4c21-8e78-2c856df95fb0"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("4d5c671b-b86e-4dd9-bbd9-44edffe9102a"), Guid.Parse("7d67fcc7-95af-42a5-8dd9-7d65e85f635c"), }, { Guid.Parse("3ea73999-4f31-4503-8ec8-9390f9aae953"), Guid.Parse("24282983-9265-402c-a958-a659a5c2c2a0"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 169,
    Value = 
new System.Guid[,] { { Guid.Parse("a23779ca-a0b6-4bf4-9757-18a8578842c9"), Guid.Parse("f81e9aca-b57a-45cf-be8e-67de575c199c"), }, { Guid.Parse("eb11cefa-10e4-47cf-b476-1cf540049013"), Guid.Parse("391d37a2-a3e3-45d0-8e9f-8f731e24d66c"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 93,
    Value = 
new System.Guid[,] { { Guid.Parse("ffafa103-c20b-40e7-9f37-7b2c3e88ebf6"), Guid.Parse("3c92f4b6-d3bf-459f-a638-8d5da4f4d1df"), }, { Guid.Parse("4d00745f-6246-4d7c-b55d-7d78339e090b"), Guid.Parse("98a8d088-1cc1-40c9-b370-83a861081bf9"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("7bfb7a8b-6e77-4cf0-8f6b-4fcc529b87f7"), Guid.Parse("755fd96e-e565-43fc-a310-810013c65ebe"), }, { Guid.Parse("426decee-c6d1-406f-97e3-9eebf879312f"), Guid.Parse("9f84a2a0-fc51-44a3-9722-a647fcaa2336"), }, },
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 175,
    Value = 
new System.Guid[,] { { Guid.Parse("9107acac-c064-4f20-a5e8-5199f96485db"), Guid.Parse("2e530c26-6666-45cc-8c42-4938aeea3fb4"), }, { Guid.Parse("05534b60-5ab3-4078-a6fd-8ff944ecdddc"), Guid.Parse("b2a9fd80-fe41-4b90-9b84-e1e936a17d8c"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("a553dff7-15b9-4f3f-8e1f-a092f2aefbaf"), Guid.Parse("bfb13ea2-0c20-43fd-8755-361b74a43ec3"), }, { Guid.Parse("f0a9f1cb-4a3e-4858-988d-6c1ef5ebf57e"), Guid.Parse("84104350-7bc9-4161-9493-8f83ce204c69"), }, },
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd2e1mi(
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd2e1mi(
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
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]), 
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

                changedRows =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    guiduuidmmarrayd2e1mi_id
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuidmmarrayd2e1mi_id", 
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
                changedRows =  ((IGuidMArrayuuidMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IGuidMArrayuuidMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    guiduuidmmarrayd2e1mi_id
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
    guiduuidmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                System.Guid[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[,]>();
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[,]>();
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                System.Guid[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[,]>();
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[,]>();
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    guiduuidmmarrayd2e1mi_id
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
    guiduuidmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuidmmarrayd2e1mi_id", 
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
                System.Guid[,] nullable = null;
                nullable =  ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { { Guid.Parse("e55376ed-0674-45b0-b1a4-f6ffaebce1eb"), Guid.Parse("6f2d9b29-0290-431b-940c-7cb56bf2812b"), }, { Guid.Parse("10c3e110-02f3-4ac9-80a7-2638ab8db837"), Guid.Parse("c626b299-38e2-4e88-b765-421b713194d5"), }, }));
                nullable =  ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Guid[,] nullable = null;
                nullable = await ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { { Guid.Parse("596c8684-4db7-49bd-9e0f-7cde87bd8460"), Guid.Parse("5b00cd85-4d64-4981-80b5-4a46fdb527cb"), }, { Guid.Parse("e6607a47-7c0d-4571-ab7d-893c9a19ced7"), Guid.Parse("2a143014-fa6d-41c8-b62f-aa11432d2e9f"), }, }));
                nullable = await ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidMMArrayD2E1M> models = null;

                models =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidMMArrayD2E1M> models = null;

                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M), typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                ((IGuidMArrayuuidMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IGuidMArrayuuidMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidMArrayuuidMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
LEFT JOIN public.guiduuidmmarrayd2e1mi mi ON mi.id = m.guiduuidmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models = await ((IGuidMArrayuuidMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M), typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                ((IGuidMArrayuuidMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidMArrayuuidMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidMArrayuuidMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
LEFT JOIN public.guiduuidmmarrayd2e1mi mi ON mi.id = m.guiduuidmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models = await ((IGuidMArrayuuidMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IGuidMArrayuuidMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M), typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 40;
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 162;
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
LEFT JOIN public.guiduuidmmarrayd2e1mi mi ON mi.id = m.guiduuidmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models = await((IGuidMArrayuuidMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[28],_testData[34], false);
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M), typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 130, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 22, query1, 28, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[27],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 53, query1, 112, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 130, query1, 10, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[32],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 11, query1, 22, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[28],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 13, query1, 52, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 69, query1, 77, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 77, query1, 130, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
LEFT JOIN public.guiduuidmmarrayd2e1mi mi ON mi.id = m.guiduuidmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models = await((IGuidMArrayuuidMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 11, 71))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 121, 129))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[34], false);
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
                await using var cmd = await ((IGuidMArrayuuidMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidMArrayuuidMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 129);
                var models = await ((IGuidMArrayuuidMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidMArrayuuidMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidMArrayuuidMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 43);
                var models =  ((IGuidMArrayuuidMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(25));

                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
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
FROM public.binary_guiduuidmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD2E1MIWA),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidMArrayuuidMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidMArrayuuidMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidMArrayuuidMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidMArrayuuidMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD2E1MI),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidMArrayuuidMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidMArrayuuidMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((IGuidMArrayuuidMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidMArrayuuidMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
guiduuidmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(GuiduuidMMArrayD2E1M),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
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
FROM public.binary_guiduuidmmarrayd2e1m m
LEFT JOIN public.binary_guiduuidmmarrayd2e1mi mi ON mi.id = m.guiduuidmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IGuidMArrayuuidMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IGuidMArrayuuidMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((IGuidMArrayuuidMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    guiduuidmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models =  ((IGuidMArrayuuidMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidMArrayuuidMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA), typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models1 = new List<GuiduuidMMArrayD2E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD2E1MIWA>();
                await ((IGuidMArrayuuidMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD2E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD2E1MIWA>();
                ((IGuidMArrayuuidMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models = await ((IGuidMArrayuuidMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
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
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
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
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA), typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
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
                var models1 = new List<GuiduuidMMArrayD2E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD2E1MIWA>();
                await ((IGuidMArrayuuidMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD2E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD2E1MIWA>();
                ((IGuidMArrayuuidMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
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
                var models = await ((IGuidMArrayuuidMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
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
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
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
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MI), typeof(GuiduuidMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models1 = new List<GuiduuidMMArrayD2E1MI>();
                var models2 = new List<GuiduuidMMArrayD2E1MI>();
                await ((IGuidMArrayuuidMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD2E1MI>();
                var models2 = new List<GuiduuidMMArrayD2E1MI>();
                ((IGuidMArrayuuidMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models = await ((IGuidMArrayuuidMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA), typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
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
                var models1 = new List<GuiduuidMMArrayD2E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD2E1MIWA>();
                await ((IGuidMArrayuuidMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD2E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD2E1MIWA>();
                ((IGuidMArrayuuidMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
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
                var models = await ((IGuidMArrayuuidMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

