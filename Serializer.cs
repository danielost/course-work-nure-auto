using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CourseWork
{
    class Serializer
    {
        public void JsonSerialize(object data)
        {
            string path = "data.save";
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

        public object JsonDeserialize(Type dataType, string path)
        {
            JObject obj = null;
            JsonSerializer jsonSerializer = new JsonSerializer();
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);
                JsonReader jsonReader = new JsonTextReader(sr);
                obj = jsonSerializer.Deserialize(jsonReader) as JObject;
                jsonReader.Close();
                sr.Close();
            }

            return obj == null ? null : obj.ToObject(dataType);
        }
    }
}
