namespace myloteria
{
    public class Loteria
    {
        public List<int> JugadaSuperKino()
        {
            Random rnd = new Random();
            List<int> SuperKino = new List<int>();
            int tempNumber = 0;
            
            for (int i = 0; i < 10; i++)
            {
                do {
                    tempNumber = rnd.Next(1,81);
                } while (SuperKino.Contains(tempNumber));
                SuperKino.Add(tempNumber);
            }
            
            return SuperKino;
        }

        public List<int> SorteoSuperKino()
        {
            int tempNumber = 0;
            Random rnd = new Random();
            List<int> sorteo = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                do {
                    tempNumber = rnd.Next(1,81);
                } while (sorteo.Contains(tempNumber));
                sorteo.Add(tempNumber);
            }
            return sorteo;
        }

        public string ConfirmarJugada(List<int> Jugada)
        {
            List<int> sorteoActual = SorteoSuperKino();
            int contadorAciertos = 0;
            
            foreach (int numeroJugado in Jugada)
            {
                foreach (int numeroSorteo in sorteoActual)
                {
                    if(numeroJugado==numeroSorteo){
                    contadorAciertos++;
                    }
                }
            }
            switch (contadorAciertos)
            {
            case 10:
                return "Felicidades has ganado 25,000,000.00!!!!!";
            case 9:
                return "Felicidades has ganado RD$ 150,000.00!!!";
            case 8:
                return "Felicidades has ganado RD$ 10,000.00!!!";
            case 7:
                return "Felicidades has ganado RD$ 1,000.00!!";
            case 6:
                return "Felicidades has ganado RD$ 300.00!";
            case 5:
                return "Felicidades has ganado RD$ 60.00!";
            case 0:
                return "Felicidades has ganado RD$ 80.00!";
            default:
                return "Lo sentimos, mas suerte para la proxima!";
            }
        }
    }
}