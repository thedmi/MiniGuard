
Push-Location MiniGuard

nuget pack -Build -Prop Configuration=Release -Output ..\..\..\LocalNugetFeed

Pop-Location
