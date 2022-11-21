// Run this from the working directory where the solution or project to build is located.
using HostApi;

string[] allfiles = Directory.GetFiles("path/to/dir", "*.*", SearchOption.AllDirectories);

return new DotNetBuild().Build().ExitCode ?? 1;