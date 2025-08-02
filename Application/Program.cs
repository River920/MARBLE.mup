using System.Diagnostics;

ProcessStartInfo ps = new ProcessStartInfo();
ps.FileName = "cmd.exe";
ps.WindowStyle = ProcessWindowStyle.Normal;
ps.Arguments = "/k notepad.exe";
Process.Start(ps);