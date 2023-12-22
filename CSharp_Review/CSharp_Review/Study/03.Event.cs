using Microsoft.VisualBasic;
using static CSharp_Review.InputManager;

namespace CSharp_Review
{
    // 구독자를 모집하고, 구독자에게 메시지를 뿌리는 것을
    // 목적어 패턴 = Observer Pattern 이라고 한다.

    class InputManager
    {
        public delegate void OnInputKey();  // 문법 자체는 함수와 비슷하다
                                            // 함수 자체를 인자로 넘기기 좋다
                                            // 유일한 단점은 외부에서도 호출할 수 있다는 것
                                            // -> Event를 이용해 Wrapping하고 보완한다.
        public event OnInputKey InputKey;   // delegate를 wrapping하기 위한 event
                                            // 구독자를 보유한 유튜버

        public void Update()
        {
            if (Console.KeyAvailable)
                return;

            ConsoleKeyInfo info = Console.ReadKey();

            if (info.Key == ConsoleKey.A)
            {
                // 모두에게 어떤키가 눌렸는지 알려준다
                // -> 너무 번거롭고 지저분한 행동이다. (의존성 증가)
                // => Event를 사용하자 (콜백 사용)

                InputKey();

                // delegate를 사용할때와는 달리 event를 사용하면 좋은점
                // 함수의 단독 사용이 불가능하다.
                // delegate는 단독으로 사용가능하며, event는 불가능하다 (안전하다, wrapping)


            }
        }
    }

    internal class Event
    {
        // 구독자
        static void OnInputTest()
        {
            Console.WriteLine("Input Received");
        }

        static void Main(string[] args)
        {
            InputManager inputManager = new InputManager();

            // 구독 신청
            inputManager.InputKey += OnInputTest;

            while (true)
            {
                inputManager.Update();
            }
        }
    }
}
