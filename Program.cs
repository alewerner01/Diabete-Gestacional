Console.Write("Qual o seu nível de glicemia em mg/dL: ");
int mgdL = Convert.ToInt32(Console.ReadLine());

if(mgdL<92)
{
    Console.WriteLine("reavaliar entre 24 e 28 semanas com TTOG 75g de glicose");
}
else if(mgdL >= 92 && mgdL <126)
{
    Console.WriteLine("Compatível com Diabetes Gestacional");
}
else
{
    Console.WriteLine("Diabetes Mellitus na Gravidez");
}