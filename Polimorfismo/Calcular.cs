//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.Serialization;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//namespace Polimorfismo
//{
//    public abstract class Forma
//    {
//        public double Base { get; set; }
//        public double Altura { get; set; }
//        public double Soma { get; set; }
//        public abstract void CalcularPerimetro();
//    }

//    public class Retangulo : Forma
//    {
//        public override void CalcularPerimetro()
//        {
//            Soma = Base * Altura;
//        }
//    }

//    public class Triangulo : Forma
//    {
//        public override void CalcularPerimetro()
//        {
//            Soma = (Base * Altura) / 2;
//        }
//    }

//    public static class Executor
//    {
//        public static void Executar()
//        {
//            var retangulo = new Retangulo();
//            retangulo.Base = 10;
//            retangulo.Altura = 20;
//            retangulo.CalcularPerimetro();
//            Console.WriteLine(retangulo.Soma);

//            var triangulo = new Triangulo();
//            triangulo.Base = 10;
//            triangulo.Altura = 20;
//            triangulo.CalcularPerimetro();
//            Console.WriteLine(triangulo.Soma);

//        }
//    }
//}
