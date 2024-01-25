using System.Runtime.CompilerServices;

public class MetodoBurbuja {
    public void Ejecutar(){
        

        string [] cadena = new string[]{
            "En un lugar de l4 manch1 cuyo",
            "2 de la cotorra21 y cuando 229",
            "20,30,40,50"
        };
        int [] numeros = new int[10];
        

foreach (string elemento in cadena)
{
    foreach (char caraccter in elemento)
    {
        if (char.IsDigit(caraccter))
        {
            if (int.TryParse(caraccter.ToString(),out int n))
            {
                for (int i = 0; i < numeros.Length; i++)
                {
                numeros[i] = n;
                i++;
                    
                }
            }
        }
    }
}
Console.WriteLine(string.Join(",", numeros));

     }
}