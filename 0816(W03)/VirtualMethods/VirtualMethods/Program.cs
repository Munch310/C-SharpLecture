namespace VirtualMethods
{
    internal class Program
    {
        public class Unit
        {
            public virtual void Move() // 자식이 재정의를 했을 수 있다. Virtual - 자식이 재구성을 할 수 있게 해줌.
            {
                Console.WriteLine("두발로 걷기");

                // virtual -> 실형태가 다를 수 있으니, 실형태에 재정의가 되어있는지 확인해봐야 한다.
            }

            public void Attack()
            {
                Console.WriteLine("Unit 공격");
            }
        }

        public class Marine : Unit
        {

        }

        public class Zergling : Unit
        {
            public override void Move() // 부모 virtual , 자식 override
            {
                Console.WriteLine("네발로 걷기");
            }
        }

        static void Main(string[] args)
        {
            //Marine marine = new Marine();
            //marine.Move();
            //marine.Attack();

            //Zergling zergling = new Zergling();
            //zergling.Move();
            //zergling.Attack();

            // Unit은 참조 형태, Marine, Zergling은 실형태 / 즉 참조 형태와 실형태가 다를 때 Virtual Override 사용.
            List<Unit> list = new List<Unit>();
            list.Add(new Marine());
            list.Add(new Zergling());

            foreach(Unit unit in list)
            {
                unit.Move();
            }
        }
    }
}