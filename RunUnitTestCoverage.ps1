$tools = dotnet tool list -g
$reportgeneratorInstalled = $tools -like '*dotnet-reportgenerator-globaltool*'

if($reportgeneratorInstalled)
{
	& dotnet tool update -g dotnet-reportgenerator-globaltool
    & dotnet test "CodeCoverageExampleTests"
    & reportgenerator "-reports:.\**\coverage.opencover.xml" "-targetdir:.\UnitTestCoverageReport"
    & .\UnitTestCoverageReport\index.htm
}
else
{
	Write-Host "Please install the report generator tool."
	Write-Host "dotnet tool install --global dotnet-reportgenerator-globaltool"
}