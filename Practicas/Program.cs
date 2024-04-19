using codewars;
namespace Practices {
    public class Program{
       static KataNextBiggerNumber test = new KataNextBiggerNumber();
        public static void Main(string[] args){
            // test.NextBiggerNumber(args);
            int valor = new codewars.KataNextBiggerNumber().NextBiggerNumber(["1","2","3"]);
            Console.WriteLine(valor);
        }
    }
}
