// Run this from the working directory where the solution or project to build is located.
using HostApi;

var currentDir = Environment.CurrentDirectory;
string[] allfiles = Directory.GetFiles(currentDir, "*.csproj", SearchOption.AllDirectories);

Console.WriteLine(allfiles[0]);

return new DotNetBuild().Build().ExitCode ?? 1;