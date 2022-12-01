// See https://aka.ms/new-console-template for more information
using MQ_Test2.Business.Services;

Console.WriteLine("Hello, World!");

// Read json file
// deserialise json file
// pass object through converter service
// return and display data

var jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\input_mis_data.json");

JsonToObjectConverterService jsonToObjectConverterService = new();
jsonToObjectConverterService.Convert(jsonPath);
