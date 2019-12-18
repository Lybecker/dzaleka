# What is this?
Code samples created at the Dzaleka UNHCR refugee camp visit when training refugees in C# programming.

## Samples
### Deserialize Serialize
This sample show how to serialize and deserialize a `Person` class into JSON with Newtonsoft. It also shows how to write it to disk and how to use NuGet packages.

### Web API REST
This sample uses `WebAPISample`, `StudentConsole` and `SharedClassLibrary` projects and demonstrates:
 - Creating a REST endpoint with WebAPI
 - Consuming the REST endpoint with the `StudentConsole`
 - Pushing new data to the REST endpoint
 - A simple storage with serializing objects to a file on disk
 - Sharing code via Class Libraries
 
 This version of .NET returns XML and JSON when browsing the endpoint in the Chrome browser. To fix it, add the following to `App_Start/WebApiConfig.cs` file:

```csharp 
// Change the media formats to application/json and not the default application/xml
config.Formatters
    .JsonFormatter
    .SupportedMediaTypes
    .Add(new System.Net.Http.Headers.MediaTypeHeaderValue("text/html"));
```