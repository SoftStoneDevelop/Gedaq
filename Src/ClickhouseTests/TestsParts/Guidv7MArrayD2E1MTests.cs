

using ClickHouse.Driver.ADO;
using System;
using Gedaq.Common.Enums;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IGuidv7MArrayMArrayD2
    {
    }
    
    internal partial class Guidv7MArrayMArrayD2 : IGuidv7MArrayMArrayD2
    {


#region TestData

        private readonly Guidv7MArrayD2E1M[] _testData = new Guidv7MArrayD2E1M[]
        {
            new Guidv7MArrayD2E1M
{
    Id = 7,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392e-747d-99f7-cb37ee29f3bd"), Guid.Parse("01a17ef0-392e-732e-9d4f-d709780807ec"), }, { Guid.Parse("01a17ef0-392e-73f6-95f4-c3ea45137111"), Guid.Parse("01a17ef0-392e-756d-a250-e50cd6e4667a"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 6,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392e-72bc-b595-71a5619d453c"), Guid.Parse("01a17ef0-392e-7c18-af86-e9404f75d01a"), }, { Guid.Parse("01a17ef0-392e-78be-8895-9f7296d30628"), Guid.Parse("01a17ef0-392e-7def-8765-14f3358b7298"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392e-7465-863f-91f873a44dad"), Guid.Parse("01a17ef0-392e-777a-b15b-f6992aa7a777"), }, { Guid.Parse("01a17ef0-392e-70e2-a04b-34d0945e0f4d"), Guid.Parse("01a17ef0-392e-7dbe-ba5e-86c034d24dcc"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392e-7108-a572-ad6bb56c0ed7"), Guid.Parse("01a17ef0-392e-74c7-b5e3-591229a9ba7e"), }, { Guid.Parse("01a17ef0-392e-7ed7-872e-5d71bb173a0b"), Guid.Parse("01a17ef0-392e-71ad-898b-4dc231da3812"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 10,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392e-7df6-ac10-7e28e3424b0e"), Guid.Parse("01a17ef0-392e-7b75-85c9-79aa119aa395"), }, { Guid.Parse("01a17ef0-392e-7657-b6dc-8f8f7ecb4af4"), Guid.Parse("01a17ef0-392e-7ba6-ad45-a78ec9975ff1"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 11,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392e-701a-bca6-8d89cc047bbc"), Guid.Parse("01a17ef0-392e-7717-a6de-b3d4a6ac7dd8"), }, { Guid.Parse("01a17ef0-392e-7915-a293-d908f3f1153d"), Guid.Parse("01a17ef0-392e-7cbf-8ee6-6fc249ef418b"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392e-74d3-a2a3-6149a8e18995"), Guid.Parse("01a17ef0-392e-7472-a9d7-817d40ebf172"), }, { Guid.Parse("01a17ef0-392e-7b49-bb04-e023a30544a2"), Guid.Parse("01a17ef0-392e-7b4d-a7f2-18ea1b4ed702"), }, },
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 14,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392e-7543-83b5-b3308a20ff14"), Guid.Parse("01a17ef0-392e-73e8-bc86-bdd2cc44cc37"), }, { Guid.Parse("01a17ef0-392e-7e62-9f62-3cf83b8f8779"), Guid.Parse("01a17ef0-392e-7056-86ac-133c4cdec738"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 19,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392e-7f0c-899b-aef8e3b56bf3"), Guid.Parse("01a17ef0-392e-7ffa-9fe4-e2c6ad082df0"), }, { Guid.Parse("01a17ef0-392e-7acd-a4c8-f4665b125d32"), Guid.Parse("01a17ef0-392e-703b-8533-fdc0fc02ed99"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392e-74dd-aa7d-32c3ce8d8a9d"), Guid.Parse("01a17ef0-392e-7c02-9cc1-a60db87c5fef"), }, { Guid.Parse("01a17ef0-392e-7ca0-951d-c369a9766b24"), Guid.Parse("01a17ef0-392e-7d9b-99f8-e9c1cb298722"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392e-7e49-bb51-a345c395c211"), Guid.Parse("01a17ef0-392e-7dec-9c2a-965cf31784b1"), }, { Guid.Parse("01a17ef0-392e-7972-bcc0-f03cf747b53b"), Guid.Parse("01a17ef0-392e-7512-b347-067868e20200"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 18,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392e-79be-97e9-6e0e46595ad6"), Guid.Parse("01a17ef0-392e-7788-a41b-1ffcf3878347"), }, { Guid.Parse("01a17ef0-392e-7437-9328-f9d103cd3955"), Guid.Parse("01a17ef0-392e-7915-8980-ba3c7ed959a0"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 23,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392e-77ed-a668-9607b0cf6517"), Guid.Parse("01a17ef0-392e-7ec3-860a-2918274e54d5"), }, { Guid.Parse("01a17ef0-392e-7486-9cf9-4ea384490dcb"), Guid.Parse("01a17ef0-392e-712e-9b87-3b10eec6d914"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392e-7e2d-9bda-47c6ad33d53f"), Guid.Parse("01a17ef0-392e-73b9-9d31-890cd35d1c86"), }, { Guid.Parse("01a17ef0-392e-7a75-ba79-b36f90ad1a2c"), Guid.Parse("01a17ef0-392e-7afa-bc13-a99384724b3a"), }, },
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 23,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392e-7067-a88f-0d76f0165f5b"), Guid.Parse("01a17ef0-392e-7838-895b-c9f49610b11b"), }, { Guid.Parse("01a17ef0-392e-7a1c-b3ec-80596bc9c4e1"), Guid.Parse("01a17ef0-392e-7a90-9850-7d14e6e3cc3d"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 29,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392e-74a9-b541-09c51c1167fa"), Guid.Parse("01a17ef0-392e-7832-94cb-30bb190eb75c"), }, { Guid.Parse("01a17ef0-392e-7b78-a7f3-1e6386c5b644"), Guid.Parse("01a17ef0-392e-7faf-8386-79a2d663f94a"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 28,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392e-7962-9638-c67dd3b759f3"), Guid.Parse("01a17ef0-392e-7050-a10b-f96a4ca2369f"), }, { Guid.Parse("01a17ef0-392e-75f7-9f69-7323e9df4502"), Guid.Parse("01a17ef0-392e-7228-8cee-2d61b2f23bbc"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 35,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392e-77a4-8bad-2c7eec9918fa"), Guid.Parse("01a17ef0-392e-7366-a768-bf313c64a0e5"), }, { Guid.Parse("01a17ef0-392e-7e06-a532-f4e9a0e2e796"), Guid.Parse("01a17ef0-392e-72c5-ba70-90154883d41d"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392e-7d46-a846-a60bfc4a52c0"), Guid.Parse("01a17ef0-392e-77dc-8b04-97a1d7e6cd38"), }, { Guid.Parse("01a17ef0-392e-7a43-bfd5-4e80e35a538f"), Guid.Parse("01a17ef0-392e-7500-a246-272bd6cbed55"), }, },
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 35,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392e-7c16-a5a5-5f95816253e6"), Guid.Parse("01a17ef0-392e-7cd9-99d3-3a3a1fc1aff9"), }, { Guid.Parse("01a17ef0-392e-763b-8008-2864282c01f4"), Guid.Parse("01a17ef0-392e-7d47-ab66-c4b762c8a618"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 38,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392e-7c33-a364-f711089e235d"), Guid.Parse("01a17ef0-392e-76d8-9c23-2925f8be638d"), }, { Guid.Parse("01a17ef0-392e-7b20-8554-c072e2d6c303"), Guid.Parse("01a17ef0-392e-7373-9760-61c52dbe525c"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392e-7627-849d-ca018ac7b001"), Guid.Parse("01a17ef0-392e-77a7-b764-8b3920ba32c7"), }, { Guid.Parse("01a17ef0-392e-76d7-a548-29b4aa9fe9dc"), Guid.Parse("01a17ef0-392e-7804-9b17-1813c35b0978"), }, },
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 44,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392e-78e4-8ab7-ea0e70bcfea0"), Guid.Parse("01a17ef0-392e-73c7-b3dc-6ce7c3f96fd0"), }, { Guid.Parse("01a17ef0-392e-71f0-a163-7c964e39376f"), Guid.Parse("01a17ef0-392e-77fb-8ec5-e1260a36e364"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 42,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392e-7c68-a6eb-1943968429dd"), Guid.Parse("01a17ef0-392e-7325-8081-f8805e401681"), }, { Guid.Parse("01a17ef0-392e-788c-92e2-982132e65d76"), Guid.Parse("01a17ef0-392e-7933-9368-bfc1d50ffcd3"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392e-777d-8be2-cf3c980a6372"), Guid.Parse("01a17ef0-392e-70b4-9c86-a571743bbf0f"), }, { Guid.Parse("01a17ef0-392e-7bbd-8c7c-c8f7a2656d0f"), Guid.Parse("01a17ef0-392e-783f-8230-73b890e9bca1"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392e-7d0a-b6f6-c85e2dbd72b3"), Guid.Parse("01a17ef0-392e-7d93-853e-06456e385e3c"), }, { Guid.Parse("01a17ef0-392e-72cc-b366-e1b3b54d0627"), Guid.Parse("01a17ef0-392e-74ac-9d2b-b84d036a2553"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 50,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392e-7f31-9d02-99ca20c3c94b"), Guid.Parse("01a17ef0-392e-74c3-9ed3-5ae5b269e2d4"), }, { Guid.Parse("01a17ef0-392e-7415-9df7-0492ed15ad29"), Guid.Parse("01a17ef0-392e-7acd-8d15-bd87f512ba30"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 49,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392e-7570-a125-927d58ed7952"), Guid.Parse("01a17ef0-392e-7bdf-8664-05593a2cc997"), }, { Guid.Parse("01a17ef0-392e-77af-8bc9-ff9e190cc028"), Guid.Parse("01a17ef0-392e-706d-ae52-f5cdf039fd40"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 58,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392e-7f8b-b9a3-bfd6e0c5c2a5"), Guid.Parse("01a17ef0-392e-709e-b162-b0a539bf01a9"), }, { Guid.Parse("01a17ef0-392e-7c02-9a29-a73636efef12"), Guid.Parse("01a17ef0-392e-7999-a437-9ac3cac1c07e"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 55,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392e-7ed4-8cc1-d5002ebc23b8"), Guid.Parse("01a17ef0-392e-74c3-bce4-27330b324447"), }, { Guid.Parse("01a17ef0-392e-70bc-b31f-59b55cac3bbb"), Guid.Parse("01a17ef0-392e-7313-95d0-4a01c4127602"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392e-7c8c-b19d-ba40b4cca51d"), Guid.Parse("01a17ef0-392e-732e-8c30-61272c6db020"), }, { Guid.Parse("01a17ef0-392e-7e07-b6bb-6b858259ddcc"), Guid.Parse("01a17ef0-392e-7ede-996d-f0f0c5328d36"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 60,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392e-7051-ac38-e8ad11f49029"), Guid.Parse("01a17ef0-392e-7a46-80ce-ed5e0d480e14"), }, { Guid.Parse("01a17ef0-392e-7278-b9b9-d328e65f8a1e"), Guid.Parse("01a17ef0-392e-79f4-9ee8-5bd35cafeb71"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 56,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392e-7910-baa6-98cd366e147d"), Guid.Parse("01a17ef0-392e-767e-82e3-151655ac2fcf"), }, { Guid.Parse("01a17ef0-392e-7f9e-8105-9df2125df8cc"), Guid.Parse("01a17ef0-392e-7520-9ca5-220c8ad9bd9c"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 65,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7c06-8c98-8ef57235db81"), Guid.Parse("01a17ef0-392f-7147-8a61-e4acb8b2bff5"), }, { Guid.Parse("01a17ef0-392f-7448-bf69-663fa13a9155"), Guid.Parse("01a17ef0-392f-7e01-9f03-df2c30fdcf09"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 58,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392e-7c7a-92da-42dc0a1eaf07"), Guid.Parse("01a17ef0-392e-7b65-8818-303417507f48"), }, { Guid.Parse("01a17ef0-392e-7d98-b53e-f91968edc746"), Guid.Parse("01a17ef0-392e-7fe7-b792-797273022ecb"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392e-7494-85f7-8bba777c83c2"), Guid.Parse("01a17ef0-392e-7506-be8e-3e7218af3f1f"), }, { Guid.Parse("01a17ef0-392f-7616-a352-a239bcd3e239"), Guid.Parse("01a17ef0-392f-7801-bce0-eb0858afed22"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7221-88f4-6e2247b0cf72"), Guid.Parse("01a17ef0-392f-71b5-84c3-71010266e323"), }, { Guid.Parse("01a17ef0-392f-7f9f-a8da-4b8e3300f40c"), Guid.Parse("01a17ef0-392f-79bd-a31c-3d6c637b4bc7"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 74,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7bab-a8c7-29e0db88a4d4"), Guid.Parse("01a17ef0-392f-7c73-b670-7e975476525e"), }, { Guid.Parse("01a17ef0-392f-7963-baa1-2651f36f2283"), Guid.Parse("01a17ef0-392f-7182-9d22-3a41403be61a"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 62,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7cc5-b470-9c56d92c16a7"), Guid.Parse("01a17ef0-392f-79b0-9b85-7442623eaced"), }, { Guid.Parse("01a17ef0-392f-7a82-b012-cb8e033fff81"), Guid.Parse("01a17ef0-392f-734c-9e9a-766bb2feae9e"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7c40-ae06-9437c60f8c5e"), Guid.Parse("01a17ef0-392f-7157-9ced-9da3cf395e90"), }, { Guid.Parse("01a17ef0-392f-78dd-aca3-0a76f5ea9b7f"), Guid.Parse("01a17ef0-392f-7b0e-b3ca-5e0947e626b1"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7b12-8467-a0940ad4e4da"), Guid.Parse("01a17ef0-392f-7a0d-b0c2-8b60fdbaa2d8"), }, { Guid.Parse("01a17ef0-392f-7abc-ab10-535dbef1e96d"), Guid.Parse("01a17ef0-392f-72a2-8934-6abbab42cf7f"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 76,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-701a-8471-6842681666e9"), Guid.Parse("01a17ef0-392f-735b-9814-800e1816cac7"), }, { Guid.Parse("01a17ef0-392f-7d12-a8e5-2d3b7024419b"), Guid.Parse("01a17ef0-392f-7697-8450-4cfe036c9c27"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 65,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7385-9caa-bcc7143b3eac"), Guid.Parse("01a17ef0-392f-7932-a683-23a56dbab5d8"), }, { Guid.Parse("01a17ef0-392f-7ade-ad71-0e009815ed5a"), Guid.Parse("01a17ef0-392f-7b6f-bab8-f5cc7b17072e"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7abf-8976-0eb3d88df800"), Guid.Parse("01a17ef0-392f-7c86-b8c7-98f035b7d41c"), }, { Guid.Parse("01a17ef0-392f-732a-993a-f55d4378ceed"), Guid.Parse("01a17ef0-392f-7c0a-845c-72a05c9f2b4d"), }, },
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 82,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7a0c-92ed-13aa25cb98e8"), Guid.Parse("01a17ef0-392f-7b32-bd51-5df42169be38"), }, { Guid.Parse("01a17ef0-392f-714a-8826-6746b6cfe32f"), Guid.Parse("01a17ef0-392f-7aae-9907-9c8d7ef04f4e"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 73,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7aa5-8dfd-ab6d12803adf"), Guid.Parse("01a17ef0-392f-7ebc-a994-e4139cd551dd"), }, { Guid.Parse("01a17ef0-392f-75a0-9eb5-262d73daa1ed"), Guid.Parse("01a17ef0-392f-7e69-977d-5e2251edc660"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-78e0-9acb-a63d2efc4e6f"), Guid.Parse("01a17ef0-392f-7ae1-8449-eec35058cfc2"), }, { Guid.Parse("01a17ef0-392f-7f9b-8c5c-58d5cdeb1212"), Guid.Parse("01a17ef0-392f-7b88-85d8-a9db8a3e9244"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-72c7-933d-bfd96879a985"), Guid.Parse("01a17ef0-392f-7800-a301-7c7675da289f"), }, { Guid.Parse("01a17ef0-392f-7907-88a4-36a4bb2a2c02"), Guid.Parse("01a17ef0-392f-716d-bf80-2fe36b2d7c4e"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 90,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7312-85bd-8cd523ba58c0"), Guid.Parse("01a17ef0-392f-7ebb-b1c8-1dad3528ee73"), }, { Guid.Parse("01a17ef0-392f-7117-97f2-610e71437785"), Guid.Parse("01a17ef0-392f-7747-80ec-340a46582676"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 81,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-748a-ba4e-86db90da5201"), Guid.Parse("01a17ef0-392f-7e18-a581-cdc43e8f8565"), }, { Guid.Parse("01a17ef0-392f-76c5-bfab-d8982a2c30a8"), Guid.Parse("01a17ef0-392f-7212-9cb4-f3453c2881a2"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7d69-b85f-b4c0a5033c49"), Guid.Parse("01a17ef0-392f-7eee-8ab6-fe38237beb4d"), }, { Guid.Parse("01a17ef0-392f-78fc-a729-311a6c4415d3"), Guid.Parse("01a17ef0-392f-7d4d-912e-bfde43dac8d1"), }, },
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 98,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-78df-ab99-d7440d9189da"), Guid.Parse("01a17ef0-392f-7a5a-bda0-da37ad25f04d"), }, { Guid.Parse("01a17ef0-392f-7d7b-8605-bc8584e95013"), Guid.Parse("01a17ef0-392f-7106-b1ec-8754de09ebde"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 88,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7d6a-9721-97c2b578726b"), Guid.Parse("01a17ef0-392f-7aa4-bc01-b998ca5477bd"), }, { Guid.Parse("01a17ef0-392f-7fc7-9abf-35505829b8f7"), Guid.Parse("01a17ef0-392f-7e3a-b41a-51354a69c0a6"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7989-b43e-7df85f0333f7"), Guid.Parse("01a17ef0-392f-7cf5-aa99-e7c8c77caaf7"), }, { Guid.Parse("01a17ef0-392f-7840-ab34-ad7542cfd327"), Guid.Parse("01a17ef0-392f-751a-b9af-b5cb5571b175"), }, },
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 104,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7aad-8ac7-98573a1da9d4"), Guid.Parse("01a17ef0-392f-7346-9cb8-d42883f9d84c"), }, { Guid.Parse("01a17ef0-392f-7626-839d-8a98ee31314b"), Guid.Parse("01a17ef0-392f-7bd8-acf4-b9ceab58c5aa"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 93,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-78c5-831f-43f2d83e5768"), Guid.Parse("01a17ef0-392f-7081-b921-7d6c5b1c689d"), }, { Guid.Parse("01a17ef0-392f-7379-8356-1296be0368fa"), Guid.Parse("01a17ef0-392f-7356-9595-5736007747b0"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-74c3-91a8-ae4129320807"), Guid.Parse("01a17ef0-392f-76cc-9756-8a480640076b"), }, { Guid.Parse("01a17ef0-392f-71ab-8b42-99de960d6d46"), Guid.Parse("01a17ef0-392f-740c-9ce3-6ddf30bf1e6f"), }, },
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 105,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7c6d-ba7c-eee5364a8bf7"), Guid.Parse("01a17ef0-392f-74c3-a04a-c7b648321137"), }, { Guid.Parse("01a17ef0-392f-71a8-851e-ef0000b7f0a3"), Guid.Parse("01a17ef0-392f-74c2-960c-3f18abb61c0f"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 100,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7fa8-a37c-23dadebb516f"), Guid.Parse("01a17ef0-392f-7f91-a2f9-4de035c41693"), }, { Guid.Parse("01a17ef0-392f-74de-b07b-1e6e14dc7c29"), Guid.Parse("01a17ef0-392f-7e34-9b63-6162fa55351c"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-79c7-831f-00b0e6c15177"), Guid.Parse("01a17ef0-392f-7432-9081-ab6dd82e747c"), }, { Guid.Parse("01a17ef0-392f-79d7-a465-f585f7332a46"), Guid.Parse("01a17ef0-392f-726e-8b66-80d066430209"), }, },
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 111,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-784e-afdd-498366650cce"), Guid.Parse("01a17ef0-392f-75ea-811b-e97a543d3a78"), }, { Guid.Parse("01a17ef0-392f-76f4-add1-2f47b160994a"), Guid.Parse("01a17ef0-392f-75eb-bace-26a2829da763"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 103,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-73de-b12f-49b82a7d9fbb"), Guid.Parse("01a17ef0-392f-77bc-8203-6181305c7bf1"), }, { Guid.Parse("01a17ef0-392f-78e6-b506-a336e9d5dd0c"), Guid.Parse("01a17ef0-392f-7a11-9013-09199530df67"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-76d9-a971-d63d9da0c324"), Guid.Parse("01a17ef0-392f-772a-8202-4ff6a33ba7db"), }, { Guid.Parse("01a17ef0-392f-7ff4-98b2-e52be6c424c4"), Guid.Parse("01a17ef0-392f-7a60-a594-164885bb14f0"), }, },
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 116,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7659-96a6-c4258e32402b"), Guid.Parse("01a17ef0-392f-709d-8e1b-ec48e4bd9942"), }, { Guid.Parse("01a17ef0-392f-7690-a446-723c3a13e384"), Guid.Parse("01a17ef0-392f-7816-aba4-3cfc6c8add0e"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 111,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7d7a-bd0c-6065460dc1da"), Guid.Parse("01a17ef0-392f-78f0-b3be-f3523854798f"), }, { Guid.Parse("01a17ef0-392f-738d-97dc-a17ca2c075c4"), Guid.Parse("01a17ef0-392f-7dcc-b095-732fcbf087ae"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-72c2-8865-9f868f6f52d3"), Guid.Parse("01a17ef0-392f-757c-b34f-a360ab25a0f4"), }, { Guid.Parse("01a17ef0-392f-77e8-b124-6d12e298e3e9"), Guid.Parse("01a17ef0-392f-7f9c-981b-6eea76d6a097"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-74b9-ab81-3eeeb8758b43"), Guid.Parse("01a17ef0-392f-73f8-8918-275fef7bc970"), }, { Guid.Parse("01a17ef0-392f-7d26-9010-4be147ab4e5f"), Guid.Parse("01a17ef0-392f-73dc-a4c5-e634a44ef1b2"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 122,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7f80-bddf-785a3f16a048"), Guid.Parse("01a17ef0-392f-7876-82b3-ea300745806c"), }, { Guid.Parse("01a17ef0-392f-7b96-ae52-af5f35cbd4e7"), Guid.Parse("01a17ef0-392f-7b58-8407-fd0ddbcc6b49"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 115,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7f4b-a71c-2179039fc57c"), Guid.Parse("01a17ef0-392f-7712-87f9-d499b122e94a"), }, { Guid.Parse("01a17ef0-392f-7b6c-b0ed-13f2b11354b1"), Guid.Parse("01a17ef0-392f-7f89-b717-124d8f86ed65"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7c76-8b93-14bcefbaf430"), Guid.Parse("01a17ef0-392f-7a4c-b7b5-918340db1f32"), }, { Guid.Parse("01a17ef0-392f-702c-b686-f6c93d367611"), Guid.Parse("01a17ef0-392f-7849-85c5-0a0e19c5103c"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7cd5-895e-5be1d7e3bfff"), Guid.Parse("01a17ef0-392f-76a9-a08f-c1ecf5acfd20"), }, { Guid.Parse("01a17ef0-392f-7313-a54e-8e093862f4e3"), Guid.Parse("01a17ef0-392f-7143-ad29-4191b7d10801"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 127,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7b06-a91c-b9d85242342e"), Guid.Parse("01a17ef0-392f-744f-a864-41d1aca27353"), }, { Guid.Parse("01a17ef0-392f-75b6-8be3-5d508ab0873b"), Guid.Parse("01a17ef0-392f-7040-8986-867feb20e708"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 123,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7afb-8f5f-8c8b14feb15c"), Guid.Parse("01a17ef0-392f-7dd9-bbc9-da2da86f2171"), }, { Guid.Parse("01a17ef0-392f-74f8-9002-9eab658e1345"), Guid.Parse("01a17ef0-392f-71db-a01b-8b08d6daeabd"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-75aa-b102-30b585ae287c"), Guid.Parse("01a17ef0-392f-706a-95f1-87b18ab9ea1b"), }, { Guid.Parse("01a17ef0-392f-77d6-8893-b65fb2d665f5"), Guid.Parse("01a17ef0-392f-73bd-a039-084c42f346ee"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 131,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7b13-bbd4-8168262fe681"), Guid.Parse("01a17ef0-392f-7024-9fba-c722ecc796de"), }, { Guid.Parse("01a17ef0-392f-7d1b-b618-ea9d08a54d35"), Guid.Parse("01a17ef0-392f-79ce-969e-0ad90f8eac58"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 127,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7ea3-972b-e115314953f7"), Guid.Parse("01a17ef0-392f-7d2f-b3ca-37c216ad8853"), }, { Guid.Parse("01a17ef0-392f-7dee-b653-c2638b1c619e"), Guid.Parse("01a17ef0-392f-7adc-b96c-f1accd42c7e9"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-71a3-b441-89381251797c"), Guid.Parse("01a17ef0-392f-7b8c-a25b-8c7347329b28"), }, { Guid.Parse("01a17ef0-392f-7a9f-aaa3-26c473b6cf18"), Guid.Parse("01a17ef0-392f-7f3a-a51e-b0d6b112c23b"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7981-a8ea-1f0da089b90c"), Guid.Parse("01a17ef0-392f-71bc-89e1-5fa73624c65e"), }, { Guid.Parse("01a17ef0-392f-7970-8ceb-13872c115b05"), Guid.Parse("01a17ef0-392f-7288-9d20-2de8e4d8e9bc"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 134,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7f97-a28d-ad69735ef13b"), Guid.Parse("01a17ef0-392f-7557-8b84-5df73f785cfa"), }, { Guid.Parse("01a17ef0-392f-7815-94ff-e812ae1a6141"), Guid.Parse("01a17ef0-392f-7692-9141-57a482d11f50"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 128,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7a5e-ace6-88d4e2144901"), Guid.Parse("01a17ef0-392f-71c3-8cfc-098dd91e2762"), }, { Guid.Parse("01a17ef0-392f-7c18-bf25-244b982a26dc"), Guid.Parse("01a17ef0-392f-71ec-a751-ae712b197faa"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 142,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7b73-ae2b-ff63c4b7ecda"), Guid.Parse("01a17ef0-392f-7d08-b5f9-7b27ffce42f0"), }, { Guid.Parse("01a17ef0-392f-70d9-b65c-4bc903436cfd"), Guid.Parse("01a17ef0-392f-7c94-8292-a58183bfaf7c"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 130,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-74f1-ba01-c1d5be4084fc"), Guid.Parse("01a17ef0-392f-7574-8fec-fcf25461768f"), }, { Guid.Parse("01a17ef0-392f-729f-aebc-fce3370b914f"), Guid.Parse("01a17ef0-392f-7239-88e0-e0744e792b89"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 145,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7d50-81c2-8ee4968cb737"), Guid.Parse("01a17ef0-392f-760b-8f50-732efcc0d2a4"), }, { Guid.Parse("01a17ef0-392f-7d46-b50d-2c5fe7588d60"), Guid.Parse("01a17ef0-392f-75d8-a477-7ca03b8f6ed4"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 132,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7299-a9b1-129ecd3abec7"), Guid.Parse("01a17ef0-392f-791e-b680-3f680dd6267a"), }, { Guid.Parse("01a17ef0-392f-7b42-bc8c-f1c3e748fc4a"), Guid.Parse("01a17ef0-392f-7681-b4d3-cffe645a06aa"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7060-bf90-2df0c16487c5"), Guid.Parse("01a17ef0-392f-7adf-a09c-2ae369c20bbe"), }, { Guid.Parse("01a17ef0-392f-76f4-8680-055eded73970"), Guid.Parse("01a17ef0-392f-7ec4-a5bc-315f1b7d6957"), }, },
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 151,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7201-867c-bb76b129b20e"), Guid.Parse("01a17ef0-392f-70be-a5e1-c652489565dd"), }, { Guid.Parse("01a17ef0-392f-78d2-9c49-75b07b31fbe3"), Guid.Parse("01a17ef0-392f-7701-9013-7a192d60158d"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 139,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-78cd-936e-68d74755e2f9"), Guid.Parse("01a17ef0-392f-7f98-a69b-484d8ee0cd59"), }, { Guid.Parse("01a17ef0-392f-71a1-a573-2bdd2dee73f6"), Guid.Parse("01a17ef0-392f-7fdc-9f9c-a95d438b145d"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 160,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7dc8-abb8-6cfa61bd1eea"), Guid.Parse("01a17ef0-392f-7144-a28c-c0e620490374"), }, { Guid.Parse("01a17ef0-392f-7908-8726-aecfa8c23c9c"), Guid.Parse("01a17ef0-392f-7311-9074-188a13a60e1f"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 147,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-70ca-8bd5-3883a8eb3462"), Guid.Parse("01a17ef0-392f-7ec0-8772-ac65ac207d69"), }, { Guid.Parse("01a17ef0-392f-7df8-8e8d-3ae051df63d5"), Guid.Parse("01a17ef0-392f-74f0-a683-208ab4b7bdc6"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7650-b7da-dbc2715c963c"), Guid.Parse("01a17ef0-392f-7a3c-b6a9-e9462a657468"), }, { Guid.Parse("01a17ef0-392f-7a04-ae32-cd65423934ed"), Guid.Parse("01a17ef0-392f-7a32-9010-17fe9dce5ba7"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7eaa-a9cf-47e0aad83745"), Guid.Parse("01a17ef0-392f-7c50-8b0e-7b3abc520557"), }, { Guid.Parse("01a17ef0-392f-7ec5-9a69-37929b0dae3a"), Guid.Parse("01a17ef0-392f-7795-8cf3-72dd7222bf03"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 166,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-75df-9352-d76484755e84"), Guid.Parse("01a17ef0-392f-71d0-9106-b0c60b6d6a8b"), }, { Guid.Parse("01a17ef0-392f-7671-bb65-61a51d89a29a"), Guid.Parse("01a17ef0-392f-72d2-9910-9d9289bb3427"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 153,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-77e6-b37f-9e154c23b4fa"), Guid.Parse("01a17ef0-392f-7a3e-94e9-728db6ab12fe"), }, { Guid.Parse("01a17ef0-392f-74db-9020-100bade23866"), Guid.Parse("01a17ef0-392f-7c38-bd16-b385aefe1590"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7575-8043-69f05aa9aa92"), Guid.Parse("01a17ef0-392f-70c4-860a-3515b7de0d84"), }, { Guid.Parse("01a17ef0-392f-782c-858f-d281ef723e0d"), Guid.Parse("01a17ef0-392f-78d3-a19e-ff29fd3ec085"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7276-a1d8-259b076e30fc"), Guid.Parse("01a17ef0-392f-7f5d-a9e1-b6a3fc957db3"), }, { Guid.Parse("01a17ef0-392f-7946-8f21-c86e6434d9c8"), Guid.Parse("01a17ef0-392f-7cf8-9e9b-908c99732534"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 170,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7c6e-aaec-dda0b46e6ef0"), Guid.Parse("01a17ef0-392f-79b8-90d2-d620f5591334"), }, { Guid.Parse("01a17ef0-392f-7114-b380-3892543e5e1d"), Guid.Parse("01a17ef0-392f-7d48-aa13-fc2f07f29af7"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 161,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7e80-9e82-ea172066164f"), Guid.Parse("01a17ef0-392f-7d37-b863-d8400b176b45"), }, { Guid.Parse("01a17ef0-392f-74d8-b272-28c3a61518f8"), Guid.Parse("01a17ef0-392f-7334-86a5-d560cf7659a8"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 175,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7bd8-b3a8-16fb6fc8accc"), Guid.Parse("01a17ef0-392f-7920-a4bc-0021c1b0b17b"), }, { Guid.Parse("01a17ef0-392f-7f76-b69e-10a10652dd98"), Guid.Parse("01a17ef0-392f-7a34-b07e-cedcecc705d6"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 168,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7b65-a866-0d1084276aba"), Guid.Parse("01a17ef0-392f-7f52-acf1-4b46d3d6411b"), }, { Guid.Parse("01a17ef0-392f-7775-b72d-6ef53bb03ac5"), Guid.Parse("01a17ef0-392f-707f-852e-40ad44bbd0b4"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7896-9f98-f8c020dbf7ef"), Guid.Parse("01a17ef0-392f-76a8-baed-0073fa679666"), }, { Guid.Parse("01a17ef0-392f-732a-8bbe-910c0c276cf3"), Guid.Parse("01a17ef0-392f-7609-b881-c00a59750a17"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7e38-bb26-64801928e687"), Guid.Parse("01a17ef0-392f-74e8-85b4-3a2a7c884b31"), }, { Guid.Parse("01a17ef0-392f-7dea-8c29-20133ac94529"), Guid.Parse("01a17ef0-392f-750c-8a3d-c3ad2828282f"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 180,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7dfb-bd2a-4877e90f4f49"), Guid.Parse("01a17ef0-392f-797f-a15e-5c60a6a38712"), }, { Guid.Parse("01a17ef0-392f-74a8-b8f2-c8594dd55fa8"), Guid.Parse("01a17ef0-392f-7fad-8599-320f315ffc1e"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 171,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7d6e-ae2b-2743d3874505"), Guid.Parse("01a17ef0-392f-7649-a293-ad66213865af"), }, { Guid.Parse("01a17ef0-392f-705c-9bde-c5827dd12882"), Guid.Parse("01a17ef0-392f-789e-a796-978e2ab3c11e"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7101-8fac-ef03bc036324"), Guid.Parse("01a17ef0-392f-7b1c-bf6a-9ec576ffe2eb"), }, { Guid.Parse("01a17ef0-392f-708f-afa3-d10854d6db13"), Guid.Parse("01a17ef0-392f-7c12-9965-cf697ee730e6"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-75e8-9c2c-6c942142a0b9"), Guid.Parse("01a17ef0-392f-71ea-a726-e3b8b1dd8f5d"), }, { Guid.Parse("01a17ef0-392f-7a30-bbfd-8cdcc0fe8e2e"), Guid.Parse("01a17ef0-392f-77ea-a035-b2857feea554"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 188,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7c1e-830e-43216f2b84a1"), Guid.Parse("01a17ef0-392f-7d21-91b9-cb903a494943"), }, { Guid.Parse("01a17ef0-392f-7bbe-9f6a-ad73b71b8feb"), Guid.Parse("01a17ef0-392f-78d7-8f3c-57f8b93793e6"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 175,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7429-99c2-e81102136d98"), Guid.Parse("01a17ef0-392f-7255-8bce-a8bf4db6b48c"), }, { Guid.Parse("01a17ef0-392f-7223-b61a-38e4e2acf59b"), Guid.Parse("01a17ef0-392f-7c64-a978-71006ef0f751"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-732a-979c-ab92a53e0edd"), Guid.Parse("01a17ef0-392f-7426-bd04-96f0d13f8770"), }, { Guid.Parse("01a17ef0-392f-7c3a-af52-d618fe6a4a2a"), Guid.Parse("01a17ef0-392f-7376-901a-9472dbed474c"), }, },
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 193,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7474-85a6-8a0b46b95596"), Guid.Parse("01a17ef0-392f-7023-baeb-52840df0992a"), }, { Guid.Parse("01a17ef0-392f-751f-9b41-703d51489f56"), Guid.Parse("01a17ef0-392f-7429-937b-698ee2110b0a"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 178,
    Value = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-79f5-b726-58c448376dfb"), Guid.Parse("01a17ef0-392f-7723-a387-e23ea98d01ed"), }, { Guid.Parse("01a17ef0-392f-716b-93aa-c1b83e3a4612"), Guid.Parse("01a17ef0-392f-7c8e-a3ec-21460f950fbe"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01a17ef0-392f-7798-bf50-27c2b5ee7903"), Guid.Parse("01a17ef0-392f-7599-a1c1-fa426756ed84"), }, { Guid.Parse("01a17ef0-392f-7bcf-947e-d70f2ed7ec58"), Guid.Parse("01a17ef0-392f-7588-8e66-df34d26449e3"), }, },
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.guidv7marrayd2e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Array(UUID))}, 
    {mi_id:Int32},
    {mi_value:Array(Array(UUID))}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayMArrayD2)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]), 
                parametrName: "mi_value", 
                methodParametrName: "mi_Value")]
        public void InsertModelDbConnectionConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < 2; i++)
                {
                    await ((IGuidv7MArrayMArrayD2)this).InsertModelDbConnectionAsync(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 2; i < 35; i++)
                {
                     ((IGuidv7MArrayMArrayD2)this).InsertModelDbConnection(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

#endregion

#region Select Models

[Gedaq.DbConnection.Attributes.Query(
            query: @"
SELECT
	m_id AS id,
    m_value AS value,
~StartInner::ModelInner:id~
~Reinterpret::id~
    mi_id,
~Reinterpret::value~
    mi_value
~EndInner::ModelInner~
FROM gedaqtests.guidv7marrayd2e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Guidv7MArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayMArrayD2)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_id")]
        public void SelectModelDbConnectionConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models = await ((IGuidv7MArrayMArrayD2)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Guidv7MArrayD2E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models =  ((IGuidv7MArrayMArrayD2)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Guidv7MArrayD2E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

