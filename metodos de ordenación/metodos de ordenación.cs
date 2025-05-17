using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos_de_ordenación
{
    internal class Ordenación
    {
        public void print(int[] array)
        {
            foreach (int k in array)
            {
                Console.Write(k + " ");
            }
            Console.WriteLine();
        }

        public void BurbujaMenor(int[] array)
        {
            int n = array.Length - 1;
            int AUX;

            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= i; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        AUX = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = AUX;
                        print(array);
                    }
                }
            }
        }

        public void BurbujaMayor(int[] array)
        {
            int n = array.Length;
            int AUX;

            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        AUX = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = AUX;
                        print(array);
                    }
                }
            }
        }

        public void BurbujaSeñal(int[] array)
        {
            bool BAND = false;
            int N = array.Length;
            int i = 0;

            while (i < N && BAND == false)
            {
                BAND = true;
                for (int j = 0; j < N - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int AUX = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = AUX;
                        BAND = false;
                        print(array);
                    }
                }
                i++;
            }
        }

        public void Sacudida(int[] array)
        {
            int IZQ = 1;
            int DER = array.Length - 1;
            int AUX;
            int k = array.Length - 1;

            while (DER >= IZQ)
            {
                for (int i = DER; i >= IZQ; i--)
                {
                    if (array[i - 1] > array[i])
                    {
                        AUX = array[i - 1];
                        array[i - 1] = array[i];
                        array[i] = AUX;
                        k = i;
                        print(array);
                    }
                }
                IZQ = k + 1;

                for (int i = IZQ; i <= DER; i++)
                {
                    if (array[i - 1] > array[i])
                    {
                        AUX = array[i - 1];
                        array[i - 1] = array[i];
                        array[i] = AUX;
                        k = i;
                        print(array);
                    }
                }
                DER = k - 1;
            }
        }

        public void Inserción(int[] array)
        {
            int AUX;
            int k;
            int n = array.Length - 1;

            for (int i = 1; i <= n; i++)
            {
                AUX = array[i];
                k = i - 1;

                while (k >= 0 && AUX < array[k])
                {
                    array[k + 1] = array[k];
                    k--;
                }
                array[k + 1] = AUX;
                print(array);
            }
        }

        public void InserciónBinaria(int[] array)
        {
            int IZQ, DER, AUX, j, m;
            int n = array.Length - 1;

            for (int i = 1; i <= n; i++)
            {
                AUX = array[i];
                IZQ = 0;
                DER = i - 1;

                while (IZQ <= DER)
                {
                    m = (IZQ + DER) / 2;
                    if (AUX <= array[m])
                    {
                        DER = m - 1;
                    }
                    else
                    {
                        IZQ = m + 1;
                    }
                }

                j = i - 1;
                while (j >= IZQ)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[IZQ] = AUX;
                print(array);
            }
        }

        public void Selección(int[] array)
        {
            int menor, k;
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                menor = array[i];
                k = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < menor)
                    {
                        menor = array[j];
                        k = j;
                    }
                }

                array[k] = array[i];
                array[i] = menor;
                print(array);
            }
        }

        public void Shell(int[] array)
        {
            int n = array.Length;
            int INT = n + 1;
            int AUX, i;
            bool band;

            while (INT > 1)
            {
                INT = INT / 2;
                band = true;

                while (band)
                {
                    band = false;
                    i = 0;

                    while (i + INT < n)
                    {
                        if (array[i] > array[i + INT])
                        {
                            AUX = array[i];
                            array[i] = array[i + INT];
                            array[i + INT] = AUX;
                            band = true;
                            print(array);
                        }
                        i++;
                    }
                }
            }
        }

        public void QuickSort(int[] A, int INI, int FIN)
        {
            int left = INI, right = FIN, POS = INI;
            bool BAND = true;

            while (BAND)
            {
                BAND = false;

                while ((A[POS] <= A[right]) && (POS < right))
                {
                    right--;
                }

                if (POS < right)
                {
                    int AUX = A[POS];
                    A[POS] = A[right];
                    A[right] = AUX;
                    POS = right;
                    print(A);
                }

                while ((A[POS] >= A[left]) && (POS > left))
                {
                    left++;
                }

                if (POS > left)
                {
                    int AUX = A[POS];
                    A[POS] = A[left];
                    A[left] = AUX;
                    POS = left;
                    BAND = true;
                    print(A);
                }
            }

            if (POS - 1 > INI)
                QuickSort(A, INI, POS - 1);

            if (POS + 1 < FIN)
                QuickSort(A, POS + 1, FIN);
        }

        public void HeapSort(int[] A)
        {
            int n = A.Length;

            for (int i = (n / 2) - 1; i >= 0; i--)
                Baja(A, i, n - 1);

            for (int i = n - 1; i >= 1; i--)
            {
                int AUX = A[0];
                A[0] = A[i];
                A[i] = AUX;
                print(A);
                Baja(A, 0, i - 1);
            }
        }

        private void Baja(int[] A, int INI, int FIN)
        {
            int left = 2 * INI + 1;
            int right = 2 * INI + 2;
            int MAYOR = INI;

            if (left <= FIN && A[left] > A[MAYOR])
                MAYOR = left;

            if (right <= FIN && A[right] > A[MAYOR])
                MAYOR = right;

            if (MAYOR != INI)
            {
                int AUX = A[INI];
                A[INI] = A[MAYOR];
                A[MAYOR] = AUX;
                print(A);
                Baja(A, MAYOR, FIN);
            }
        }
    }
}
