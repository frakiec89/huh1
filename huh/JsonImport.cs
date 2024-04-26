using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace huh
{
    public class JsonImport
    {
        public string path;

        public void JI(out Graph graphj)
        {
            string jsonFile = File.ReadAllText(path);


            graphj = JsonConvert.DeserializeObject<Graph>(jsonFile)!;

        }
    }
}
