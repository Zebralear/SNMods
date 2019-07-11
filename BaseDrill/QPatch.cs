using System;
using Harmony;

namespace BaseDrillMod
{
	// Patcher with detailed outputs, makes finding errors easy
	public class QPatch
	{
	public static void Patch()
		{
   			try
    		{
				BaseDrillModule instance = new BaseDrillModule();
				OutputTimer instance2 = new OutputTimer();
        		Console.WriteLine("<BaseDrillModule> Patching Base Drill");
				Console.WriteLine("[BaseDrillModule] Patching Buildable");
        		new BaseDrillModule().Patch();
				new BaseDrillModule().GetGameObject();
				Console.WriteLine("[BaseDrillModule] Buildable Patched");
				Console.WriteLine("[BaseDrillModule] Patching Outputs");
            	new OutputTimer().InitializeResourceRange();
				new ContainerSize().SetSize();
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