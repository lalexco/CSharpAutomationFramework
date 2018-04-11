using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework
{
    public class TestInitializer
    {
        public TestInitializer(string File)
        {
            ReadConfigFile(File);
        }
        public static string Url
        { get; set; }

        public void ReadConfigFile(string FileLocation)
        {
            using (StreamReader file = File.OpenText(FileLocation))
            {
                JsonSerializer serializer = new JsonSerializer();
                TestInitializer testInitializer = (TestInitializer)serializer.Deserialize(file, typeof(TestInitializer));
            }
        }
    }
}
