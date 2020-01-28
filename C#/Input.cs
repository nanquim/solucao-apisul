using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ProvaAdmissionalCSharpApisul
{
    public class Input
    {
        private string path { get; set; }
        private string jsonString { get; set; }

        public List<ElevadorModel> pegaInputs()
        {
            this.path = "../input.json";

            List<ElevadorModel> inputs = new List<ElevadorModel>();

            this.jsonString = File.ReadAllText(path);

            inputs = JsonSerializer.Deserialize<List<ElevadorModel>>(this.jsonString);


            /* using (FileStream fs = File.OpenRead(path))
            {
                jsonString = await JsonSerializer.DeserializeAsync<Elevador>(fs);
            } */


            return inputs;
        }
    }
}