using RestSharp;
using System.Collections.Concurrent;
using System.IO;
using System.Text.Json;

RestClient client = new("https://digi-api.com/api/v1/");

string animalname = "digimon";
RestRequest request = new RestRequest ($"digimon/Aegiochusmon");

RestResponse response = client.GetAsync(request).Result;

Digimon d = JsonSerializer.Deserialize<Digimon>(response.Content);

Console.WriteLine(d.Name);
Console.WriteLine(d.Id);
Console.WriteLine(d.Attribute);


Console.ReadLine(); 




Console.ReadLine(); 

