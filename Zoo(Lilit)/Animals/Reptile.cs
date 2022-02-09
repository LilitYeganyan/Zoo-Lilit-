using System;

namespace Zoo_Lilit_
{
    class Reptile : Animal, IGetEggs
    {
        public Reptile(string name, int Age, int Stomach) : base(name, Age, Stomach)
        { }
        public int GetEggs()
        {
            //code duplication
            //int age = 2022 - this.DateOfBirth; 
            // էս մեթոդը ուզում էի չկրկնվելու համար տանել Animal
            // բայց էդպես ճիշտ չի լինի ոչ բոլոր տեսակներն են, որ կարողնանում են ձու ածել
            //դրա համար եմ ինտերֆեյսով իմպլեմենտել սողուններին, թռչուններին ու միջատներին
            int eggCount = Age + 10;

            if (Age < 5)
            {
                Console.WriteLine("չի կարող ձու ածել");
                return 0;
            }
            else
            {
                return eggCount;
            }
        }
    }
}
