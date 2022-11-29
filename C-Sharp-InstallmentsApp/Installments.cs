using System;
namespace Installments
{
    public class InstallmentTracker
    {
        
        
        private string customer;
        private string product;
        private double plan;
        private decimal price;
        private decimal percentage;
        private int quantity;
        private decimal totalAmount;
        private DateTime date;
        private decimal payment;
        private bool check;

         
        public InstallmentTracker()
        {

        }

        public void CheckInstallments()
        {
            Console.WriteLine("-----Welcome To Ejike and Sons -----\n");
            Console.WriteLine();

            Console.WriteLine(
            "Price-------------------------------------Amount\n" +
            "1---bag of rice --------------------------15000\n" +
            "2---A bag of beans -----------------------10,0000\n" +
            "3---A bag of garri ------------------------8,000\n" +
            "4---A bag of Semovita ----------------------5,500\n" +
            "5---A carton of Tomatoes ---------------------4,800\n" +
            "6---A carton of Indomie-----------------------5000\n");
            Console.WriteLine();
            product ="";
            while(product !="RICE" && product !="BEANS"  && product !="GARRI" && product !="SEMOVITA" && product !="TOMATOES" && product !="INDOMIE")
                      {
            Console.WriteLine("\nPlease select RICE,BEANS,GARRI,SEMOVITA,TOMATOES or INDOMIE from our  list of avilable products");
            product = Console.ReadLine();
            product = product.ToUpper();
                        }
            do{
            Console.WriteLine("Enter customer name: only letters please");
            customer = Console.ReadLine();
            }
            while(customer.Any(y=>!char.IsLetter(y)));

        bool check;
        quantity=0;
        do{
        Console.WriteLine("Enter the quantity");
        check = int.TryParse(Console.ReadLine(), out quantity);
        }
        while(!check);
          
        switch (product) 
        {
            case "RICE":
                    
            price = 15000;
            totalAmount = price * quantity;
            Console.WriteLine($"Price of Product : #{price}\n");
            Console.WriteLine($"Quantity : {quantity}\n");
            Console.WriteLine($"Total Amount : #{totalAmount}\n ");
                    
                        
            installmentPlans();
            break;

            case "BEANS":
                    
            price = 10000;
            totalAmount = price * quantity;
            Console.WriteLine($"Price of Product : #{price}\n");
            Console.WriteLine($"Quantity : {quantity}\n");
            Console.WriteLine($"Total Amount : #{totalAmount}\n ");
                  

                    installmentPlans();
                    break;

                case "GARRI":
                    price = 8000;
                   totalAmount = price * quantity;
                    Console.WriteLine($"Price of Product : #{price}\n");
                    Console.WriteLine($"Quantity : {quantity}\n");
                    Console.WriteLine($"Total Amount : #{totalAmount}\n ");
                   

                    installmentPlans();
                    break;

                case "SEMOVITA":
                    price = 5500;
                    totalAmount = price * quantity;
                    Console.WriteLine($"Price of Product : #{price}\n");
                    Console.WriteLine($"Quantity : {quantity}\n");
                    Console.WriteLine($"Total Amount : #{totalAmount}\n");
                   

                    installmentPlans();
                    break;

                 case "TOMATOES":
                    price = 4800;
                    totalAmount = price * quantity;
                    totalAmount = price * quantity;
                    Console.WriteLine($"Price of Product : #{price}\n");
                    Console.WriteLine($"Quantity : {quantity}\n");
                    Console.WriteLine($"Total Amount : #{totalAmount}\n ");
                   

                    installmentPlans();
                    break;
                     case "INDOMIE":
                    price = 5000;
                    totalAmount = price * quantity;
                    Console.WriteLine($"Price of Product : #{price}\n");
                    Console.WriteLine($"Quantity : {quantity}\n");
                    Console.WriteLine($"Total Amount : #{totalAmount}\n ");

                    installmentPlans();
                    break;

                default:
                    Console.WriteLine("Please, Enter the correct product");
                    break;
            }
            }

        public void installmentPlans() 
        {
           Console.WriteLine(
                "1---Daily Plan----------------------- 4% \n" +
                "2---Weekly Plan---------------------- 5%\n" + 
                "3---Bi-weekly Plan--------------------10%\n" +
                 "4---Monthly Plan----------------------20% \n" +
                "5---6-Months Plan-----------------------25%\n" + 
                "6---One year Plan------------------------50%\n");
          bool check;
          int plan=0;
          do{
        Console.WriteLine("Select a plan from the above list");
        check = int.TryParse(Console.ReadLine(), out plan);
        Console.WriteLine();
        }
        while(!check);

            switch (plan)
            {
                case 1:
                    Console.Clear();
                    daily();
                    break;
                case 2:
                    Console.Clear();
                    weekly();
                    break;
                case 3:
                    Console.Clear();
                    biWeekly();
                    break;
                case 4:
                    Console.Clear();
                    monthly();
                    break;
                case 5:
                    Console.Clear();
                    sixMonths();
                    break;
                default:
                    Console.Clear();
                    yearly();
                    break;
            }
           
        }

        public void daily() 
        {
           
           decimal percentage = (decimal)(4d / 100);
            Console.WriteLine("You are to  pay 4% of {0} daily.\n", totalAmount);

            date = DateTime.Now;
            Console.WriteLine();

            payment = (percentage * totalAmount);
            
            Console.WriteLine();
            Console.WriteLine(".......Track of Installment Records.......\n");

            
           
            for (decimal i = payment; i <= totalAmount; i += payment)
           
            {
                 Console.WriteLine($"On {date.ToLongDateString()}," +
                    $"  amount to be paid is # {payment}, which will add to the total Amount of # {i} " +
                    $" for {product} bought by our customer {customer}\n");
                date = date.AddDays(1);
            }

            Console.WriteLine();
            Console.WriteLine("Payment Completed!");
            

        }

        public void weekly() 
        {
            
            decimal percentage = (decimal)(5d / 100);
            Console.Clear();
            Console.WriteLine("You are  to pay 5% of {0} weekly.\n", totalAmount);

            date = DateTime.Now;
            Console.WriteLine();

            payment = (percentage * totalAmount);
            Console.WriteLine();
            Console.WriteLine("-------------Installment Records-------------\n");

            

            for (decimal i = payment; i <= totalAmount; i += payment)
            {
                Console.WriteLine($"On {date.ToLongDateString()}," +
                    $"  amount to be paid is # {payment}, which will add to the total Amount of # {i} " +
                    $" for {product} bought by our customer {customer}\n");
                date = date.AddDays(7);
            }

            Console.WriteLine();
            Console.WriteLine(" Installments Completed!");
        }
        

        public void biWeekly()
        {
            
           decimal percentage = (decimal)(10d / 100);
          
            Console.Clear();
            Console.WriteLine("You are  to pay 10% of {0} bi-weekly.\n", totalAmount);

            date = DateTime.Now;
            Console.WriteLine();

            payment = (percentage * totalAmount);
            

            Console.WriteLine();
            Console.WriteLine(".......Installments Records.......\n");

            for (decimal i = payment; i <= totalAmount; i += payment)
            {

                 Console.WriteLine($"On {date.ToLongDateString()}," +
                    $"  amount to be paid is # {payment}, which will add to the total Amount of # {i} " +
                    $" for {product} bought by our customer {customer}\n");
                date = date.AddDays(14); 
            }

            Console.WriteLine();
            Console.WriteLine("Payment Completed!");

            }

        public void monthly()
        {
            decimal percentage = (decimal)(20d / 100); 
            Console.WriteLine("You are  to pay 20% of {0} monthly.\n", totalAmount);

            date = DateTime.Now;
            Console.WriteLine("Installment payment will start on {0}\n", date.AddDays(1).ToLongDateString());
            Console.WriteLine();

            payment = (percentage * totalAmount);



            Console.WriteLine();
            Console.WriteLine(".......Installment Records.......\n");



            for (decimal i = payment
            ; i <= totalAmount; i += payment)
            {
                   Console.WriteLine($"On {date.ToLongDateString()}," +
                    $"  amount to be paid is # {payment}, which will add to the total Amount of # {i} " +
                    $" for {product} bought by our customer {customer}\n");
            }

            Console.WriteLine();
            Console.WriteLine("Payment Completed!");

        }


 
        public void sixMonths()
        {
             decimal percentage = (decimal)(25d / 100);
            
            Console.WriteLine("You are to pay 25% of {0} every six months.\n", totalAmount);

            date = DateTime.Now;
            Console.WriteLine();

            payment = (percentage * totalAmount);
           
            Console.WriteLine();
            Console.WriteLine(".......Installment Records.......\n");



            for (decimal i = payment; i <= totalAmount; i += payment)
            {
                Console.WriteLine($"On {date.ToLongDateString()}," +
                    $"  amount to be paid is # {payment}, which will add to the total Amount of # {i} " +
                    $" for {product} bought by our customer {customer}\n");
                date = date.AddMonths(6);
            }

            Console.WriteLine();
            Console.WriteLine("Payment Completed!");

        }

        public void yearly()
        {
            percentage = (decimal)(50d / 100);
            Console.WriteLine("You are expected to pay 50% of {0} yearly.\n", totalAmount);

            date = DateTime.Now;

            payment = (percentage * totalAmount);

            Console.WriteLine();
            Console.WriteLine(".......Installment Records.......\n");

            for (decimal i = payment; i <= totalAmount; i += payment)
            {
                 Console.WriteLine($"On {date.ToLongDateString()}," +
                    $"  amount to be paid is # {payment}, which will add to the total Amount of # {i} " +
                    $" for {product} bought by our customer {customer}\n");
                date = date.AddYears(1);
            }

            Console.WriteLine();
            Console.WriteLine("Payment Completed");

            }
            
        }

}

