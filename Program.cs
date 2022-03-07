// See https://aka.ms/new-console-template for more information

using API_Hubspot_V2019;
using Newtonsoft.Json;
using RestSharp;
using System;

var client = new RestClient("https://api.hubapi.com/crm/v3/objects/contacts");
var request = new RestRequest("", Method.Post);
request.AddHeader("Content-Type", "application/json");
request.AddQueryParameter("hapikey", "eu1-a7a1-2304-40d3-9658-9d57b6dce06d");

var body = JsonConvert.SerializeObject(new ContactHubspot("clement.moreau150@gmail.com", "Clement"));
//request.AddParameter("application/json", body, ParameterType.RequestBody);
request.AddBody(body,"application/json");
RestResponse response = await client.ExecuteAsync(request);
Console.WriteLine(response.Content);

Console.ReadKey();

