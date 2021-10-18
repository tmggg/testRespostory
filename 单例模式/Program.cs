using System;

namespace 单例模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Singleton<Test>.Instance.Time);
            Console.WriteLine(Singleton<Test>.Instance.Time);
            Test t1 = new Test();
            Console.WriteLine(t1.Time);
            Test t2 = new Test();
            Console.WriteLine(t2.Time);
        }
    }

    public class Test
    {
        private DateTime _time;

        public Test()
        {
            System.Threading.Thread.Sleep(3000);
            _time = DateTime.Now;
        }

        public string Time
        {
            get { return _time.ToString(); }
        }
    }

}
