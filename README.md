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

### Anonymous Functions
Showing how to use delegates and anonymous functions e.g.

```csharp 
TestDelegate testDelB = delegate (string s) { Console.WriteLine(s); };
```

### Boxing
Showing reference types and value types. Boxing us casting a value type e.g. int to an object and unboxing is the reverse.

### Linq Samples
A simple example of using Linq. Go [here to see more advanced scenarios]( https://linqsamples.com/).

Also shows how to use Lambda functions, which is also anonymous functions and a delegates.

```csharp 
var scoreQuery2 = scores.Where((x) => x > 80);
```