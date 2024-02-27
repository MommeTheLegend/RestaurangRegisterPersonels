namespace RestaurangRegisterPersonels
{
    class Program
    {
        static void Main(string[] args)
        {
            //var someThing = new Program();
            //someThing.initializeRegister(); 

            Console.WriteLine("How many employees are employed at your establishment?");
            int numberOfEmployees = Convert.ToInt32(Console.ReadLine());
            PersonelRegister aSpecificRegister = null; 

            for (int i = 0; i < numberOfEmployees; i++)
            {
                Console.WriteLine("Please provide the name for employee" + i);
                string name = Console.ReadLine();
                Console.WriteLine("Enter the age of same employee, employee number " + i);
                int age = Convert.ToInt32(Console.ReadLine());
                
                
                Personel someEmployee = new Personel(name, age);
                aSpecificRegister = new PersonelRegister(someEmployee);
            }
            Console.WriteLine("The personels are"); 
            Console.WriteLine(aSpecificRegister.totalAmountOfHiredEmployees());
            
            


            
        }
        public void initializeRegister()
        {
            
        }
    }
}
