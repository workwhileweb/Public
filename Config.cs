namespace Public
{
    public class Config
    {
        public string DestinationExe { get; }

        public static Config Load(string file)
        {

            return new Config();
        }
        public Config() { }
        public Config(string destinationExe)
        {
            DestinationExe = destinationExe;
        }
    }
}