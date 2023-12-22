namespace CSharp_Review
{
    internal class Delegate
    {
        delegate int OnClicked();
        // delegate : '형식'은 형식인데, 함수 자체를 인자로 넘겨주는 형식
        // 반환: int, 입력: void
        // OnClicked가 delegate 형식의 이름이다.

        // UI
        static void ButtonPressed(OnClicked clickedFunction/* 함수 자체를 인자로 넘겨주고 */)
        {
            // PlayerAttack()
            // TurnOnLight()
            // ChangeNextPage()

            // ...

            // 이렇게 한줄 한줄 코드를 쓰는 것은 게임 로직과 겹친다는 문제가 있다.

            // 전달 받은 함수를 호출하는 방식
            // -> Call Back Function
            // 콜백 함수란 내가 요청을 하면, 추후에 연락을 달라고 하는 것

            // => 함수를 호출
            // 게임 로직에 관계없이 해당 함수를 실행하기만 하면 된다.
            clickedFunction();
        }

        // 우리가 실제로 게임 로직 관련해서 구현하게 되는 부분..
        static int TestDelegate()
        {
            Console.WriteLine("Hello Delegate");
            return 0;
        }

        static int PrintName()
        {
            Console.WriteLine("공준열");
            return 0;
        }

        static int PrintAge()
        {
            Console.WriteLine("25");
            return 0;
        }
        static int PrintSex()
        {
            Console.WriteLine("Man");
            return 0;
        }

        static void Main(string[] args)
        {
            // 1. 기본적인 Delegate 사용 방식
            // 함수 자체를 인자로 넘긴다.
            ButtonPressed(TestDelegate);

            // 2. 체이닝 방식으로 추가해서 사용하는 방식
            OnClicked clicked = null;

            clicked += PrintName;
            clicked += PrintAge;
            clicked += PrintSex;

            ButtonPressed(clicked);

            // * 문제점..! delegate를 단독으로 사용할 수 있다. *
            clicked();
        }
    }
}
