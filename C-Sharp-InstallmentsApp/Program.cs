// Method to withdraw cash
using System;
namespace Installment
{

    public class Loans
    {
        public void LoanPayment()
        {
            Console.WriteLine("----- Loan Payment -----\n");
            {

                Console.WriteLine(
                    "Price-------------------------------------Amount\n" +
                    "1---bag of rice --------------------------20,0000\n" +
                    "2---A bag of beans -----------------------10,0000\n" +
                    "3---A bag of garri ------------------------15,000\n" +
                    "4---A bag of Semovita ----------------------5,500\n" +
                    "5---A carton of Tomatoes ---------------------4,800\n" +
                    "6---A carton of Indomie-----------------------5000\n");
                Console.Write("\nPlease select a product from the list of avilable products (1/2/3/4/5/6): ");
                string product = Console.ReadLine();
            }
        }
        public void Install()
        {
            Console.Write("\nPlease select a mode of payment installmentally (1/2/3/4/5/6): ");
            Console.WriteLine(
                "1---Daily Plan\n" +
                "2---Weekly Plan\n" + "3---Bi-weekly Plan\n" +
                "4---Monthly Plan\n" +
                "5---6-Months Plan\n" + "6---One year Plan\n");
            try
            {

                // Getting input if user wants Fast Cash or Normal Cash
                string option = Console.ReadLine();
                if (option == "1" || option == "2" || option == "3" || option == "4" || option == "5" || option == "6")
                {
                    switch (option)
                    {
                        case "1":
                            decimal percentage = (decimal)(5d / 100);
                            int price = 20000;
                            Console.Write("\nPlease enter quantity");
                            int quantity = Convert.ToInt32(Console.ReadLine());
                            int TotalAmount = price * quantity;
                            Console.WriteLine($"Total Amount is ${TotalAmount}");


                            Console.WriteLine("hello bae");
                            break;
                        case "2":
                            Console.WriteLine("hello bubu");
                            break;




                    }
                    {
                        // Console.WriteLine("Invalid Input. Please try again");
                    }
                }
            }
            catch (Exception)
            {
                // Console.WriteLine("Invalid Input!!!");
            }
        }
    }
   

    class Answer
    {
        static void Main(string[] args)
        {
            Loans loans = new Loans();
            loans.LoanPayment();
            loans.Install();

        }
    }
}

