namespace EnergyLogic
{
    public enum Build
    {
        None,
        Building
    }

    public static class PlayerExtension
    {
        public static Build Building(this Build build)
        {
            return build switch
            {
                Build.Building => Build.Building,
                _ => Build.None,
            };
        }
    }
}
