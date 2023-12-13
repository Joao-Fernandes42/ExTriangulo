namespace ExTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gestão de triângulos. Insira os dados pedidos:");

            Console.Write("1º Triângulo: Lado A:  ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("1º Triângulo: Lado B:  ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("1º Triângulo: Lado C:  ");
            double c = double.Parse(Console.ReadLine());

            Triangulo t1 = new Triangulo(a, b, c);
            if(t1.ETriangulo())
                Console.WriteLine($"{t1.ToString}");
            else
                Console.WriteLine("As medidas inseridas não formam um triângulo");

            Console.Write("2º Triângulo: Lado A:  ");
            a = double.Parse(Console.ReadLine());
            Console.Write("2º Triângulo: Lado B:  ");
            b = double.Parse(Console.ReadLine());
            Console.Write("2º Triângulo: Lado C:  ");
            c = double.Parse(Console.ReadLine());

            Triangulo t2 = new Triangulo(a, b, c);
            Console.WriteLine($"{t2.ToString}");
        }
    }
}