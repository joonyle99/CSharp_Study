namespace CSharp_Review
{
    internal class Constructure
    {
        struct MyStruct
        {
            // 기본 생성자
            public MyStruct()
            {
                Console.WriteLine("MyStruct 기본 생성자");
            }

            // 복사 생성자
            public MyStruct(MyStruct _ms)
            {
                Console.WriteLine("MyStruct 복사 생성자");
            }
        }

        class MyClass
        {
            // 기본 생성자
            public MyClass()
            {
                Console.WriteLine("MyClass 기본 생성자");
            }

            // 복사 생성자
            public MyClass(MyClass _mc)
            {
                Console.WriteLine("MyClass 복사 생성자");
            }
        }

        static void Main(string[] args)
        {
            // 기본 생성자 사용
            MyStruct ms = new MyStruct();
            MyClass mc = new MyClass();

            Console.WriteLine("================================");

            MyStruct ms2 = ms;
            MyClass mc2 = mc;

            Console.WriteLine("================================");

            // 복사 생성자 사용
            MyStruct ms3 = new MyStruct(ms);
            MyClass mc3 = new MyClass(mc);
        }
    }
}