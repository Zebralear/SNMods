using System;

namespace BaseDrillMod
{
	// Patcher with detailed outputs, makes finding errors easy
	public static class QPatch
	{
	public static void Patch()
		{
   			try
    		{
        		Console.WriteLine("<BaseDrillModule> Patching Base Drill");
				Console.WriteLine("[BaseDrillModule] Patching Buildable");
        		new BaseDrillModule().Patch();
				new BaseDrillModule().GetGameObject();
				Console.WriteLine("[BaseDrillModule] Buildable Patched");
				Console.WriteLine("[BaseDrillModule] Patching Outputs");
            	new OutputTimer().InitializeResourceRange();
				Console.WriteLine("[BaseDrillModule] Outputs Patched");
        		Console.WriteLine("<BaseDrillModule> Finished Patching");
  	 		}
    		catch (Exception ex)
   			{
        		Console.WriteLine("[BaseDrillModule] ERROR: " + ex.ToString());
    		}
		}
	}
}