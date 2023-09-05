using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_2_kurs
{
    public class Message
    {
        
        private readonly string _content;
        private readonly string _author;
        private readonly DateTime _time;
        private int _likes;

        public Message() { }
        public Message(string content, string author, DateTime time)
        {
            this._content = content;
            this._author = author;
            this._time = time;
        }

        public int Likes { get => _likes; }
        public DateTime Time { get => _time; }
        public string Author { get => _author; }
        public string Content { get => _content; }

        public void AddLike()
        {
            _likes++;
        }

        public double GetPopularity()
        {
            double elapsed = DateTime.Now.Subtract(this._time).TotalSeconds;
            if (elapsed == 0)
            {
                return _likes;
            }
            return _likes / elapsed;

        }
        public void ShowMessageInfo() 
        {
            Console.WriteLine("sisu:{0}\nAutor : {1}", Content, Author);        
        }
        public string GetPopularityInfo(double esimene, double teine)
        {
            string rezult = "";
            if (esimene > teine) { rezult = "Esimene sõnum on populaarsem kui teine"; };
            if (esimene < teine) { rezult = "Teine sõnum on populaarsem kui Esimene"; };
            return rezult;
        }
        public string GetPopularityInfoN(List<Message> messages)
        {
            string rezult = "";
            double popularity = 0;
            for (int i = 0; i < messages.Count; i++) 
            {
                if (messages[i].GetPopularity()>popularity)
                {
                    popularity = messages[i].GetPopularity();
                    rezult = messages[i].Content + "on kõige populaarsem sõnum, seda kirjutas " + messages[i].Author;
                }
            }
            return rezult;
        }

    }

    //public class Program
    //{
    //    public static void Main()
    //    {
    //        Message m1 = new Message("Hello", "John", DateTime.Now.AddDays(-10));
    //        Console.WriteLine(m1.Content);
    //        Console.WriteLine(m1.Time);
    //        m1.AddLike();
    //        Console.WriteLine(m1.GetPopularity());

    //        Message m2 = new Message("Hi", "Mary", DateTime.Now.AddMinutes(-1));
    //        Console.WriteLine(m2.Content);
    //        m2.AddLike();
    //        Console.WriteLine(m2.GetPopularity());
    //        Console.Write("m1.GetPopularity() < m2.GetPopularity(): ");
    //        Console.WriteLine(m1.GetPopularity() < m2.GetPopularity());

    //    }
    //}
}
