namespace Zoo_Lilit_
{
    class Program
    {
        static void Main(string[] args)
        {
            Fox f = new Fox("Fox", 5, 10);
            for(int i=0; i<50; i++)
            {
                System.Console.WriteLine(f.stomach);
            }
        }
    }
}
