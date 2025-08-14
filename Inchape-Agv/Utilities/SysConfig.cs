using System.Text.Json;

namespace Inchape_Agv.Utilities
{
    public class SysConfigModel
    {
        public string? ComPort { get; set; }
        public int Baudrate { get; set; }
        public int WirelessAddr { get; set; }
        public int ServerPort { get; set; }
    }

    public class SysConfig
    {
        private static readonly string _configFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SysConfig");
        private static readonly string _configFile = Path.Combine(_configFolder, "SysConfig.json");

        private static void DefaulConfig()
        {
            Directory.CreateDirectory(_configFolder);
            var defaultConfig = new SysConfigModel
            {
                ComPort = "COM1",
                Baudrate = 9600,
                WirelessAddr = 0,
                ServerPort = 5000
            };
        }
        public static SysConfigModel Load()
        {
            if (!File.Exists(_configFile))
            {
                DefaulConfig();
            }

            string json = File.ReadAllText(_configFile);
            return JsonSerializer.Deserialize<SysConfigModel>(json);
        }

        public void Save(SysConfigModel model)
        {
            Directory.CreateDirectory(_configFolder);
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(model, options);
            File.WriteAllText(_configFile, json);
        }
    }
}
