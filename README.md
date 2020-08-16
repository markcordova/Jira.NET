# Jira.NET
This is a .NET Standard complaint library for searching JIRA issues. 

## Introduction
Atlassian already provides a [Jira .NET Library]. I suggest you check it out first and use it if it satisfies your requirements as it's feature complete and officially supported.

Motivation for creating this library is three-fold and is illustrated by the [advanced usage sample]:

* Accessing my company's JIRA instance via VPN requires additional 'tweaks'. Not implemented in the library or in the samples, but it requires 'harvesting' some VPN authentication cookies from the browser and then using them when making API calls to the JIRA server instance. I suspect this is not a typical case, but if it is then this library allows you to create a custom RestSharp client factory where you can instantiate and setup the client as per your requirements.

* The JSON response returns Custom Fields in the same level as Standard Fields and are keyed with names like "customfield_11200". This makes it impossible to model these custom fields in a generic manner, and even then it would make data processing very unweildy (think LINQ). This library allows you to extend the standard field mappings by providing a sub-class where you can define these custom fields and use the appropriate (human-readable!) field names.
  
* The official JIRA library models search results that create circular dependencies. This prevents serializing the returned data back into JSON for persistence. It's possible to map the search results to POCOs but it would require significant overhead to do so. The search results and other data used by this library are simple DTOs that can easily be serialized as needed.


### Prerequisites
This library has been tested on .NET Core and .NET Framework projects and requires the following libraries:

* [Json.NET] 
* [RestSharp].

### Installing
Install the Nuget package using the Package Manager or using the .NET CLI:
```
    PM> Install-Package Lib.Jira.NET
```	
```
    CMD> dotnet add package Lib.Jira.NET
```

### Samples
This library is fairly easy and straightforward to use. Please refer to the [basic usage sample] or the [advanced usage sample].

## License
This project is licensed under the MIT License.


[Jira .NET Library]: https://bitbucket.org/farmas/atlassian.net-sdk/src/master/docs/change-history.md
[advanced usage sample]: https://github.com/markcordova/Jira.NET/blob/master/Samples/Jira.NET.Sample.AdvancedUsage/Program.cs

[basic usage sample]:https://github.com/markcordova/Jira.NET/blob/master/Samples/Jira.NET.Sample.BasicUsage/Program.cs
[Json.NET]: https://www.newtonsoft.com/json
[RestSharp]: https://restsharp.dev/