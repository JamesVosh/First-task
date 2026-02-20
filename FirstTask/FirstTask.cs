using System;
using System.Collections.Generic;
namespace First_task
{
    class FirstTask
    {
        private static int i = 0;
        private static string[] XYID;
        private static Mat_tochki.Voditeli mas_vodit = new Mat_tochki.Voditeli();
        private static Mat_tochki.Zakazi zakaz;
        static void Main()
        {
            Console.WriteLine("Введите параметр размера сетки N: ");
            mas_vodit.N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите параметр размера сетки M: ");
            mas_vodit.M = Convert.ToInt32(Console.ReadLine());
            do
            {
                XYID = Console.ReadLine().Split(' ');
                if (XYID.Length == 3)
                {
                    mas_vodit.Append(mas_vodit, new Mat_tochki(Convert.ToInt32(XYID[0]), Convert.ToInt32(XYID[1]), XYID[2]));
                }
                else
                {
                    if ((Convert.ToInt32(XYID[0]) >= 0 && Convert.ToInt32(XYID[0]) < mas_vodit.N) && (Convert.ToInt32(XYID[1]) >= 0 && Convert.ToInt32(XYID[1]) < mas_vodit.M))
                    {
                        zakaz = new Mat_tochki.Zakazi(Convert.ToInt32(XYID[0]), Convert.ToInt32(XYID[1]));
                        break;
                    }
                    else throw new ArgumentOutOfRangeException();
                }
            }
            while (true);
            while (i < mas_vodit.Len(mas_vodit))
            {
                mas_vodit[i].X = mas_vodit[i].X - zakaz.X;
                mas_vodit[i].Y = mas_vodit[i].Y - zakaz.Y;
                i++;
            }
            mas_vodit.Sort_Shella(mas_vodit, mas_vodit.Len(mas_vodit));
            i = 0;
            while (i < 5)
            {
                Console.WriteLine(Convert.ToString(mas_vodit[i].X) + " " + Convert.ToString(mas_vodit[i].Y) + " " + Convert.ToString(mas_vodit[i].ID));
                i++;
            }
        }
    }

    public class Mat_tochki
    {
        public string ID;
        public int X, Y;
        public Mat_tochki(int x, int y, string id)
        {
            X = x;
            Y = y;
            ID = id;
        }
        public double Gipotenuza
        {
            get { return Math.Sqrt(Math.Pow(X, 2.0) + Math.Pow(Y, 2.0)); }
        }
        public class Voditeli
        {
            public int N;
            public int M;
            private List<Mat_tochki> voditel = new List<Mat_tochki>() { };
            private int mini;
            private Mat_tochki non;
            public Mat_tochki this[int index]
            {
                get
                {
                    if (index >= 0 && index < voditel.Count) return voditel[index];
                    else throw new IndexOutOfRangeException();
                }
                set
                {
                    voditel[index] = value;
                }
            }
            public void Append(Voditeli mas, Mat_tochki point)
            {
                if ((point.X >= 0 && point.X < N) && (point.Y >= 0 && point.Y < M))
                {
                    mas.voditel.Add(point);
                }
                else
                {
                    throw new ArgumentOutOfRangeException("point.X or point.Y");
                }
            }
            public int Len(Voditeli mas)
            {
                return mas.voditel.Count;
            }
            public List<Mat_tochki> Sort_direct_choice(Voditeli mas, int len)
            {
                for (int i = 0; i < len; i++)
                {
                    mini = i;
                    for (int j = i; j < len - 1; j++)
                    {
                        if (mas.voditel[mini].Gipotenuza > mas.voditel[j + 1].Gipotenuza)
                        {
                            mini = j + 1;
                        }
                    }
                    non = mas.voditel[i];
                    mas.voditel[i] = mas.voditel[mini];
                    mas.voditel[mini] = non;
                }
                return voditel;
            }
            public List<Mat_tochki> Sort_bubble(Voditeli mas, int len)
            {
                for (int i = 0; i < len; i++)
                {
                    for (int j = 0; j < (len - 1 - i); j++)
                    {
                        if (mas.voditel[j].Gipotenuza > mas.voditel[j + 1].Gipotenuza)
                        {
                            non = mas.voditel[j];
                            mas.voditel[j] = mas.voditel[j + 1];
                            mas.voditel[j + 1] = non;
                        }
                    }
                }
                return voditel;
            }
            public List<Mat_tochki> Sort_Shella(Voditeli mas, int len)
            {
                for (int s = len / 2; s > 0; s /= 2)
                {
                    for (int i = s; i < len; ++i)
                    {
                        for (int j = i - s; j >= 0 && mas.voditel[j].Gipotenuza > mas.voditel[j + s].Gipotenuza; j -= s)
                        {
                            non = mas.voditel[j];
                            mas.voditel[j] = mas.voditel[j + s];
                            mas.voditel[j + s] = non;
                        }
                    }
                }
                return voditel;
            }
        }
        public class Zakazi
        {
            public int X, Y;
            public Zakazi(int x, int y)
            {
                X = x;
                Y = y;
            }
        }
    }
}

