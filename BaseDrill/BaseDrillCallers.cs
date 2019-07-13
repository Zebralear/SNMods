namespace BaseDrillMod
{
    public class BuildPatch
    {
        readonly BaseDrillModule instance = new BaseDrillModule();
        readonly OutputTimer instance2 = new OutputTimer();

        public void Builder1()
        {
            instance.Patch();
        }
        public void Builder2()
        {
            instance2.InitializeResourceRange();
        }
	}
}