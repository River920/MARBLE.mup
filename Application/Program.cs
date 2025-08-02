using System.Diagnostics;

ProcessStartInfo ps = new ProcessStartInfo();
ps.FileName = "cmd.exe";
ps.WindowStyle = ProcessWindowStyle.Normal;
ps.Arguments = @"/k C:\Users\admin\OneDrive\Documents\MARBLE\MARBLE\Github\MARBLE.mup\Application\src\Warnings.vbs";
Process.Start(ps);