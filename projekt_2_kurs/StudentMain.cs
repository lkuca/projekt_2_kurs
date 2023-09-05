using projekt_2_kurs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//public class StudentMain
//{
//    public static void Main()
//    {
//        Student student = new Student("John", 17, "London", 2000);

//    //Console.WriteLine(student.Name);
//    //Console.WriteLine(student.Age);
//    //Console.WriteLine(student.GetCity());
//    student.showInfo();

//    }
//}
public class StudentMain
{
    public static void Main()
    {
        Message m1 = new Message("Hello", "John", DateTime.Now.AddDays(-10));
        m1.ShowMessageInfo();
        m1.AddLike();
        Console.WriteLine(m1.GetPopularity());

        Message m2 = new Message("Hi", "Mary", DateTime.Now.AddMinutes(-1));
        m2.ShowMessageInfo();
        //m2.AddLike();
        //Console.WriteLine(m2.GetPopularity());
        //Console.Write("m1.GetPopularity() < m2.GetPopularity(): ");
        //Console.WriteLine(m1.GetPopularity() < m2.GetPopularity());
        for (int i = 0; i <1000; i++) { m2.AddLike(); }
        Console.WriteLine(m2.GetPopularity());
        Console.WriteLine(m1.GetPopularityInfo(m1.GetPopularity(),m2.GetPopularity()));
        Message m3 = new Message("Tere", "Mari",DateTime.Now.AddDays(-1));
        Message m4 = new Message("Guten TAg", "Hans", DateTime.Now.AddDays(-5));
        Message m5 = new Message("Yo", "Neco", DateTime.Now.AddDays(-10));
        List<Message> list = new List<Message>();
        list.Add(m1);
        list.Add(m2);
        list.Add(m3);
        list.Add(m4);
        list.Add(m5);
        Console.WriteLine(m1.GetPopularityInfoN(list));




        List<Message> list1 = new List<Message>();
        Random r= new Random();
        Message m = new Message();
        int Mcount = r.Next(1, 10);
        for (int i =0; i <Mcount; i++)
        {
            Console.WriteLine("Sõnumi sisu:");
            string c = Console.ReadLine();
            Console.WriteLine("sõnumi autor:");
            string a = Console.ReadLine();
            int t = r.Next(0, 100000000);
            DateTime dhm= DateTime.Now.Date.AddSeconds(t);
            m = new Message(c,a, dhm);
            for (int j =0;j<r.Next(1,1000);j++)
            {
                m.AddLike();

            }
            list.Add(m);
            m.ShowMessageInfo();
        }   
    }
}