using myloteria;

Loteria premio = new Loteria();
List<int> miJugada = premio.JugadaSuperKino();
List<int> elSorteo = premio.SorteoSuperKino();

System.Console.WriteLine("Esta es mi jugada:");

for (int i = 0; i < miJugada.Count; i++)
{
  System.Console.Write($"{miJugada[i]} ");
}

string resultados = premio.ConfirmarJugada(miJugada);

System.Console.WriteLine($"\n{resultados}");
System.Console.ReadKey();