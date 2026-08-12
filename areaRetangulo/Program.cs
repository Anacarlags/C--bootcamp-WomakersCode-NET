using System;

class Program
{
    static void Main()

    {
        //Ler os Valores de Base e Altura do Retangulo
         Console.WriteLine("Digite o Valor da Base:");
         double valorBase = double.Parse(Console.ReadLine());

         Console.WriteLine("Digite o Valor da Altura:");
         double valorAltura = double.Parse(Console.ReadLine());

         //Calculo de Area e Perimetro
         double area = valorBase*valorAltura ;
         double  perimetro = 2*(valorAltura+valorBase) ;

        //Mostra os Resultados
         Console.WriteLine($"O Valor da Are eh: {area}");
         Console.WriteLine($"OValor do Perimetro eh : {perimetro}");

        
    }  
}
