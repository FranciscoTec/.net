using System;
using System.Collections.Generic;

namespace EjemplosBuild.Constructor
{

    public class MainApp
    {
        public static void Main()
        {

            Director director = new Director();
            Constructor b1 = new ConcreteBuilder1();
            Constructor b2 = new ConcreteBuilder2();

            director.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Show();

            director.Construct(b2);

            Product p2 = b2.GetResult();

            p2.Show();

            Console.ReadKey();

        }

    }

    class Director
    {

        public void Construct(Constructor builder)
        {

            builder.BuildPartA();

            builder.BuildPartB();

        }

    }

    abstract class Constructor
    {

        public abstract void BuildPartA();

        public abstract void BuildPartB();

        public abstract Product GetResult();

    }

    class ConcreteBuilder1 : Constructor
    {
        private Product _product = new Product();

        public override void BuildPartA()
        {

            _product.Add("Pieza A");

        }

        public override void BuildPartB()
        {

            _product.Add("Pieza B");

        }

        public override Product GetResult()
        {

            return _product;

        }

    }

    class ConcreteBuilder2 : Constructor
    {

        private Product _product = new Product();

        public override void BuildPartA()
        {

            _product.Add("Pieza 1");

        }


        public override void BuildPartB()
        {

            _product.Add("Pieza 2");

        }


        public override Product GetResult()
        {

            return _product;

        }

    }


    class Product
    {

        private List<string> _parts = new List<string>();


        public void Add(string part)
        {

            _parts.Add(part);

        }



        public void Show()
        {

            Console.WriteLine("\nPiezas del producto -------");

            foreach (string part in _parts)

                Console.WriteLine(part);

        }

    }

}

