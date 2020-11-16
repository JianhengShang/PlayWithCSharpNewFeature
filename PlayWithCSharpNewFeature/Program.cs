using System;

namespace PlayWithCSharpNewFeature
{
    class Program
    {
        static void Main(string[] args)
        {
            TestRecord();
            //TestPatternMatching();
            //TestPatternMatching2();
            //TestInit();

            Console.ReadKey();
        }

        private static void TestRecord()
        {
            //Console.WriteLine("Hello World!");
            Cat pet1 = new Cat
            {
                Nick = "松子",
                Name = "Jack",
                Age = 1
            };
            Cat pet2 = new Cat
            {
                Nick = "松子",
                Name = "Jack",
                Age = 2
            };
            // 居然不是同一只猫
            Console.WriteLine("同一只？{0}", pet1 == pet2);
        }

        private static void TestPatternMatching()
        {
            int 考试成绩 = 85;
            switch (考试成绩)
            {
                case 0:
                    Console.WriteLine("缺考？");
                    break;
                case > 0 and <= 30:
                    Console.WriteLine("太烂了");
                    break;
                case > 30 and < 60:
                    Console.WriteLine("还是不行");
                    break;
                case >= 60 and < 80:
                    Console.WriteLine("还得努力");
                    break;
                case >= 80 and < 90:
                    Console.WriteLine("秀儿，真优秀");
                    break;
                case >= 90 and <= 100:
                    Console.WriteLine("不错，奇迹");
                    break;
            }
        }

        private static void TestPatternMatching2()
        {
            Order od = new Order
            {
                ID = 11,
                Company = "大嘴狗贸易有限公司",
                ContactName = "陈大爷",
                Qty = 425.12f,
                UP = 1000.55M,
                Date = new(2020, 10, 27)
            };

            switch (od)
            {
                case { Qty: > 1000f }:
                    Console.WriteLine("发财了，发财了");
                    break;
                case { Qty: > 500f }:
                    Console.WriteLine("好家伙，年度大订单");
                    break;
                case { Qty: > 100f }:
                    Console.WriteLine("订单量不错");
                    break;
            }
        }

        private static void TestInit()
        {
            Dog x = new Dog
            {
                No = 100,
                Name = "吉吉",
                Age = 4
            };

            Console.WriteLine(x.Name);
        }
    }
}
