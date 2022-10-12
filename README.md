# Play.Common
Common libraries used by Play Economy services.

## Create and publish package
'''powershell
$version="1.0.12"
$owner="jeevdotnetmicroservice"
dotnet pack src\Play.Common\ --configuration Release -p:PackageVersion=$version -p:RepositoryUrl=https://github.com/$owner/play.common -o ..\packages
'''