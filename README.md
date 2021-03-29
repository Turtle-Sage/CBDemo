# CBDemo

1. The App is a console app. It's written in .NET Core 3.1
2. The input_mis_data.json file is included in the Resources folder of the CBDataLibrary project. 
3. The App looks in the Resources.resx of the CBDataLibrary project for the location of the input_mis_data.json. You will likely need to update your Resources.resx file to point at the location on your machine.

Packages used:
- AutoMapper
- AutoMapper.Extensions.Microsoft.DependencyInjection
- Microsoft.Extensions.DependencyInjection
- Newtonsoft.Json
- xunit
- xunit.runner.visualstudio
- coverlet.collector
- Microsoft.NET.Test.Sdk
