// See https://aka.ms/new-console-template for more information
using MQ_Test2.Business.Services;

Console.WriteLine("Hello, World!");

// Read json file
// deserialise json file
// pass object through converter service
// return and display data

JsonObjectConverterService jsonObjectConverterService = new();
jsonObjectConverterService.ConvertObjects(new List<string> { "0", "1", "2" });
