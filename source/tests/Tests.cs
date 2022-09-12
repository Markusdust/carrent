namespace CarRent.Tests
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using CarRent.Car.Domain;

    public class Tests
    {

        [Fact]
        public void CarDomain()
        {
            //var car1 = new Car();
            //var car2 = new Car();

            //car1.Equals(car2);
            //var result = car1 == car2;

        }


        [Fact]
        public void Foo()
        {
            //var g = new MyGraph();
            //g.MyEvent += G_MyEvent;
            //g.MyEvent += G_MyEvent;
            //g.Foo();

            //var carClass = new CarClass();
            //var x = new Car();
        }

        private void G_MyEvent()
        {
            Console.WriteLine("Hallo");
        }
    }

    public class MyGraph
    {
        public event Action MyEvent;

        public void Foo()
        {
            MyEvent();

            var list = MyEvent.GetInvocationList();
            foreach (Delegate? item in list)
            {
                item.DynamicInvoke();
            }
        }
    }
}