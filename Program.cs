// Run this from the working directory where the solution or project to build is located.
using HostApi;

string[] allfiles = Directory.GetFiles("BuildApi", "*.csproj", SearchOption.AllDirectories);

Console.WriteLine(allfiles);

return new DotNetBuild().Build().ExitCode ?? 1;