param(
    [Parameter(Mandatory)]
    [ValidateSet(
        'win-x64',
        'win-arm64',
        'linux-x64',
        'linux-arm64',
        'osx-x64',
        'osx-arm64'
    )]
    [string] $RID
)

$output = "schema-scraper-$RID"

if (Test-Path $output)
{
    Remove-Item -Recurse -Force $output
}

dotnet publish .\src\SchemaScraper.csproj `
    -o "schema-scraper-$RID" `
    --self-contained `
    -p:PublishReadyToRun=$true `
    -p:PublishSingleFile=$true `
    -p:IncludeNativeLibrariesForSelfExtract=$true