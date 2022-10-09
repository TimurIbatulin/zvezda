Console.Write("Укажите нижнию границу диапазона поиска значений -");
int f = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите верхнюю границу диапазона поиска значений -");
int g = Convert.ToInt32(Console.ReadLine());
int countW=f;
int countX=f;
int countY=f;
for (double w=f; w<g; w++)
{
    countX=f;
    countW++;
    double w5 = Math.Pow(w,5);
    for (double x=f; x<g; x++)
    {
       
        double x5 = Math.Pow(x,5);
        countY=f;
        countX++;
        for (double y=f; y<g; y++)
        {
            double y5 = Math.Pow(y,5);
            countY++;
            Console.Write($"W = {countW}; X={countX}; Y={countY}");
            Console.WriteLine(" ");
            for (double z=f; z<g; z++)
            {
                double z5 = Math.Pow(z,5);
                for (double q=1; q<g; q++)
                {
                    double q5 = Math.Pow(q,5);
                    if (w5==x5 + y5 + z5 + q5)
                    {
                        Console.WriteLine($"x={x};");
                        Console.WriteLine($"y={y};");
                        Console.WriteLine($"z={z};");
                        Console.WriteLine($"q={q};");
                        Console.WriteLine($"w={w};");
                        if (w5==x5 + y5 + z5 + q5) break;
                    }    
                }
            }
        }
    }
}
Console.WriteLine($"В указанном диапазоне нет искомых значений");