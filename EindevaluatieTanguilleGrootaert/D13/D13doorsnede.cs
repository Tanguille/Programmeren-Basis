namespace D13
{
    internal class D13doorsnede
    {
        static void Main()
        {
            double[] temperaturenMeetpunt1 = { 10.1, 20.2, 15.5, 12.3, 28.7 };
            double[] temperaturenMeetpunt2 = { 10.0, 20.2, 15.6, 12.3, 28.8, 11.1 };

            double[] doorsnede = Doorsnede(temperaturenMeetpunt1, temperaturenMeetpunt2);
            ToonDoorsnede(doorsnede);                       // toont de tekst "20,2 | 12,3"

            double[] getallen1 = { 1.23, 2.34, 3.45 };
            double[] getallen2 = { 1.99, 2.34 };
            ToonDoorsnede(Doorsnede(getallen1, getallen2)); // toont de tekst "2,34"

            double[] getallen3 = { 1.99, 2.99, 3.99 };
            ToonDoorsnede(Doorsnede(getallen1, getallen3)); // toont de tekst "geen doorsnede"
        }
        static double[] Doorsnede(double[] array1, double[] array2)
        {
            double[] doorsnede = new double[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == array2[i])
                {
                    doorsnede[i] = array1[i];
                }
            }
            return doorsnede;
        }
        static double[] ToonDoorsnede(double[] array)
        {
            double[] doorsnede = new double[array.Length];
            return doorsnede;
        }


    }
}
