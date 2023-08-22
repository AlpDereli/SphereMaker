// See https://aka.ms/new-console-template for more information
SphereMaker make = new SphereMaker();
int r = make.radiustake();
make.maker(r);

class SphereMaker
{
    public int radiustake()
    {
        Console.WriteLine("Please enter the radius of the sphere as an integer: ");
        int r = int.Parse(Console.ReadLine());
        return r;
    }
    public void maker(int radius)
    {
        for (int y = (int)-radius; y <= radius; y++)
        {
            for (int x = (int)-radius; x <= radius; x++)
            {
                double distance = Math.Sqrt(x * x + y * y);
                if (distance <= radius)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
    }

}