// Run this from the working directory where the solution or project to build is located.
using HostApi;

var currentDir = Environment.CurrentDirectory;
string[] allfiles = Directory.GetFiles(currentDir, "*.*", SearchOption.AllDirectories);

Console.WriteLine(string.Join(":",allfiles));

return new DotNetBuild().Build().ExitCode ?? 1;