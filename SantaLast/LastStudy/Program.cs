using System.Text.Json;

namespace LastStudy
{
    internal class Program
    {
        // 컨테이너중 Dictory 부터 알려준다 
        // KeyValue 스트럭쳐도 알려주고 
        //  그다음에 Json 알려주면된다.

        static void Main(string[] args)
        {
            var person = new User();
            person.Name = "jopd";
            person.Age = 45;

            string jsonText = JsonSerializer.Serialize<User>(person);

            File.WriteAllText("testPath.text", jsonText);

            string readtext =  File.ReadAllText("testPath.text");

            Console.WriteLine(readtext);

            User readClass = JsonSerializer.Deserialize<User>(readtext);

            Console.WriteLine(readClass.Name);


        }


        [Serializable]
        public class User
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}
