Console.Write("digite o numero da tabuada...: ");
int numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int contador = 0;
int produto;

while (contador <= 10)
{
produto = numero * contador;
Console.WriteLine($"{numero} x {contador++} = {produto}");
}
return;

