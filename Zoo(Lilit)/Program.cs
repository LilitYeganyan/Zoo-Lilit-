namespace Zoo_Lilit_
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodType food = FoodType.Milk;
            Cage cage = new Cage();
            cage.AddFoodinContainer(food);
        }
    }
}
