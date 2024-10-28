//using System;

//namespace Polimorfismo
//{
//    public class InstrumentoMusical
//    {
//        protected string Som { get; set; }

//        public InstrumentoMusical()
//        {
//        }

//        public virtual void Tocar()
//        {
//            Console.WriteLine("Tocando instrumento musical");
//        }
//    }

//    public class Violao : InstrumentoMusical
//    {
//        public Violao()
//        {
//            Som = "Violão tocando";
//        }

//        public override void Tocar()
//        {
//            Console.WriteLine(Som);
//        }
//    }

//    public class TocadoSom
//    {
//        public void SomTocado()
//        {
//            var violao = new Violao[1];
//            violao[0] = new Violao();

//            foreach (var vo in violao)
//            {
//                Console.WriteLine(vo.ToString());
//            }
//        }
//    }
//}

