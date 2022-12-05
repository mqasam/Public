﻿// See https://aka.ms/new-console-template for more information
using MQ_Test2.Business.Interfaces;
using MQ_Test2.Business.Services;
using Newtonsoft.Json;

IAddressService addressService = new AddressService();
IEthnicityMapperService mapperService = new EthnicityMapperService();
ILanguageDetailsService languageDetailsService = new LanguageDetailsService();
ISENProvisionDetailsService senProvisionDetailsService = new SENProvisionDetailsService();
IServiceChildService serviceChildService = new ServiceChildService();
IYearGoupService yearGoupService = new YearGroupService();

Console.WriteLine("Hello, World!");

// Read json file
// deserialise json file
// pass object through converter service
// return and display data

var jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\input_mis_data.json");

JsonToObjectConverterService jsonToObjectConverterService = new();
var inputData = jsonToObjectConverterService.Convert(jsonPath);

ObjectToOutputConverterService objectToOutputConverterService = new(addressService, senProvisionDetailsService, serviceChildService, languageDetailsService, mapperService, yearGoupService);
var outputData = objectToOutputConverterService.Convert(inputData);

Console.WriteLine("Input data has been converted. Here is the output:");

string jsonData = JsonConvert.SerializeObject(outputData);

Console.Write(jsonData);

Console.ReadLine();
