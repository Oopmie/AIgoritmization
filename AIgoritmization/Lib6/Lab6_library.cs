
namespace Lab6_library
{
    public class Matrix
    {
        public static double[] vectorSqrt(double[,] mas)
        {
            double[] temp = new double[6];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (i + j == 5)
                    {
                        temp[i] = mas[i, j] * mas[i, j];
                    }
                }
            }
            return temp;
        }

        public static double SumMinMax(double[,] mas)
        {
            double[] vector = vectorSqrt(mas);
            double min = vector[0];
            double max = vector[0];
            for (int i = 1; i < vector.Length; i++)
            {
                if (vector[i] < min) min = vector[i];
                if (vector[i] > max) max = vector[i];
            }
            double sum = min + max;
            return sum;
        }
    }
}
