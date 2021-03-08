# CodeCoverageExample


1. In the unit test project(s) add a reference to `coverlet.msbuild`
1. Open the `<projectNameTests>.csproj` file add the following property group.
   ```
   <PropertyGroup>
       <CollectCoverage>true</CollectCoverage>
       <CoverletOutputFormat>opencover</CoverletOutputFormat>
   </PropertyGroup>
   ```
1. Open `powershell` in the root solution directory.
1. Install the `dotnet-reportgenerator-globaltool` via the command
   ```
   dotnet tool install --global dotnet-reportgenerator-globaltool
   ```
1. Run the `RunUnitTestCoverage.ps1` powershell file to run the unit tests, generate a code coverage report, and open the report in a browser.
