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
        public void Serialize(object data, string path)
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

        public object DeserializeUser(string fileName)
        {
            string jsonFilePath = @"C:\Users\Daniel\Desktop\2 Семестр\ООП\Курсовая\Car Dealeship\bin\Debug\netcoreapp3.1\" + fileName;
            using (StreamReader r = new StreamReader(jsonFilePath))
            {
                string json = r.ReadToEnd();
                List<User> users = JsonConvert.DeserializeObject<List<User>>(json);
                return users;
            }
        }

        public object DeserializeCar(string fileName)
        {
            string jsonFilePath = @"C:\Users\Daniel\Desktop\2 Семестр\ООП\Курсовая\Car Dealeship\bin\Debug\netcoreapp3.1\" + fileName;
            using (StreamReader r = new StreamReader(jsonFilePath))
            {
                string json = r.ReadToEnd();
                List<Car> users = JsonConvert.DeserializeObject<List<Car>>(json);
                return users;
            }
        }
    }
}
