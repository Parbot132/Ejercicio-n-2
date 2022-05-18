int intentos = 1;
int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21);
Console.Clear();
Console.WriteLine("Intente adivinar el número generado por la computadora, desde el 1 hasta el 20");
Console.WriteLine("Ingrese cualquier número");
//Console.WriteLine(numeroSecreto);
//^^^ Para probar sabiendo el número de antemano 
int numeroElegido = int.Parse(Console.ReadLine());
while (numeroElegido > numeroSecreto || numeroElegido < numeroSecreto)
{
    if (numeroElegido > numeroSecreto)
    {
        Console.Clear();
        Console.WriteLine($"Usted ingreso {numeroElegido}, y es mayor al numero de la computadora");
        numeroElegido = int.Parse(Console.ReadLine());
    }
    else if (numeroElegido < numeroSecreto)
    {
        Console.Clear();
        Console.WriteLine($"Usted ingreso {numeroElegido}, y es menor al numero de la computadora");
        numeroElegido = int.Parse(Console.ReadLine());
    }
    intentos++;
}
Console.Clear();
Console.WriteLine($"¡Usted adivinó el número, felicitaciones! El número era {numeroSecreto}.");
if (intentos > 1)
{
    Console.WriteLine($"Le tomó {intentos} intentos para adivinar el número.");
}
else Console.WriteLine("¡Adivinó el número a la primera, wow!");
/*Un dato a tener en cuenta, si se pone letra, o directamente se apreta enter sin poner ningun dato, el programa no funciona y hay que reiniciarlo
No tengo ni idea de como hacerlo para que tire un mensaje de error y que vuelva a iniciar desde cero, asi que, mientras funcione, esta todo bien jaja*/