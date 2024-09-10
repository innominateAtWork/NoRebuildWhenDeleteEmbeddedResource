
var assembly = typeof(Program).Assembly;
var assemblyResources = assembly.GetManifestResourceNames();
foreach (var resourceName in assemblyResources)
{
    var resourceStream = assembly.GetManifestResourceStream(resourceName);
    if (resourceStream == null) { continue; }
    using var streamReader = new StreamReader(resourceStream);
    var resourceText = streamReader.ReadToEnd();
    Console.WriteLine($"{resourceName} = {resourceText}");
}

