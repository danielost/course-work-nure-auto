using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CourseWork
{
    class Serializer<T>
    {
        public void Serialize(List<T> data, string path)
        {
            JsonSerializer jsonSerializer = new JsonSerializer();
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            StreamWriter sw = new StreamWriter(path);
            JsonWriter jsonWriter = new JsonTextWriter(sw);

            jsonSerializer.Serialize(jsonWriter, data);

            jsonWriter.Close();
            sw.Close();
        }

        public List<T> Deserialize(string fileName)
        {
            string jsonFilePath = Path.Combine(Environment.CurrentDirectory, fileName);
            if (File.Exists(jsonFilePath))
            {
                using (StreamReader r = new StreamReader(jsonFilePath))
                {
                    string json = r.ReadToEnd();
                    List<T> data = JsonConvert.DeserializeObject<List<T>>(json);
                    return data;
                }
            }
            else return null;
        }
    }
}
