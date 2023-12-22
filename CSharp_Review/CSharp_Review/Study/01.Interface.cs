namespace CSharp_Review
{
    internal class Interface
    {
        class Monster
        {

        }

        class Orc : Monster
        {

        }

        // 인터페이스
        // 이 기능을 구현하도록 강제한다
        // abstract와의 차이점은 ..?
        // -> ** 다중 상속의 가능 여부 **
        // -> abstract도 결국 클래스라 다중 상속이라 불가능하다
        interface IFlyable
        {
            void Fly();
        }

        abstract class AGrounable
        {
            public abstract void Ground();
        }

        // C#에서는 C++과 달리 다중 상속이 안되기 때문에
        // 상속과 인터페이스를 함께 사용하는 방식
        // 일반 상속 + 인터페이스 = 다중 상속이 아님
        class FlyableOrc : Orc, IFlyable
        {
            public void Fly()
            {

            }
        }

        static void DoFly(IFlyable flyable)
        {
            // IFlyable 객체는 인터페이스의 함수를 이용할 수 있다.
            flyable.Fly();
        }

        /*
        // 다중 상속 불가능
        class GrounableOrc : Orc, AGrounable
        {

        }
        */

        static void Main(string[] args)
        {
            FlyableOrc orc = new FlyableOrc();

            // 이렇게 Interface 상속 받은 것으로 '박싱'할 수 있다.
            DoFly(orc);
        }
    }
}