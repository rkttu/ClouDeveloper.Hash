@echo off
pushd "%~dp0"

if exist RedistPackages rd /s /q RedistPackages
if not exist RedistPackages\libs mkdir RedistPackages\libs

set projectname=ClouDeveloper.Hash
.nuget\nuget.exe pack %projectname%\%projectname%.csproj -Build -Symbols -IncludeReferencedProjects -OutputDirectory "RedistPackages\libs" -Properties configuration=Release

.nuget\NuGet.exe push RedistPackages\libs\ClouDeveloper.Hash.*.nupkg

popd
@echo on