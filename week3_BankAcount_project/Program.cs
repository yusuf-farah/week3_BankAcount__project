using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_BankAcount_project
{
    class Program
    {
        static void Main(string[] args)
        {
            checkingAccount checking = new checkingAccount(1000, "123456");
            savingAccount saving = new savingAccount(2000, "98765");
            client client = new client("yusuf", "columbus ohio", "614", saving, checking);
            do
            {
                //menu display or dashboard
                Console.WriteLine("Welcome bank of America");
                Console.WriteLine("Please select bellow opptions.");
                Console.WriteLine("1. View Client Information");
                Console.WriteLine("2. View Account Balance");
                Console.WriteLine("3. Deposit Money");
                Console.WriteLine("4. Withdraw Money");
                Console.WriteLine("5. Exit");
                int userchoice = int.Parse(Console.ReadLine());

                if (userchoice == 1)
                {
                    Console.WriteLine(client.GetInfo());
                }
                else if (userchoice == 2)
                {
                    Console.WriteLine("Please select an account.");
                    Console.WriteLine("1. Checking");
                    Console.WriteLine("2. Savings");
                    userchoice = int.Parse(Console.ReadLine());

                    if (userchoice == 1)
                    {
                        Console.WriteLine(checking.AccountBalance);
                    }
                    else if (userchoice == 2)
                    {
                        Console.WriteLine(saving.AccountBalance);
                    }
                    else
                    {
                        Console.WriteLine("wrong entry");
                    }
                }
                else if (userchoice == 3)
                {
                    Console.WriteLine("Please choose  your account to deposit.");
                    Console.WriteLine("1. Checking");
                    Console.WriteLine("2. Savings");
                    userchoice = Convert.ToInt32(Console.ReadLine());
                    if (userchoice == 1)
                    {
                        Console.WriteLine("Please enter deposit amount.");
                        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                        checking.depositfund(depositAmount);
                    }
                    else if (userchoice == 2)
                    {
                        Console.WriteLine("Please enter deposit amount.");
                        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                        saving.depositfund(depositAmount);
                    }
                    else
                    {
                        Console.WriteLine(" wrong entry  Please try again.");
                    }
                }
                else if (userchoice == 4)
                {
                    Console.WriteLine("Please select an account");
                    Console.WriteLine("1. Checking");
                    Console.WriteLine("2. Savings");
                    userchoice = Convert.ToInt32(Console.ReadLine());
                    if (userchoice == 1)
                    {
                        Console.WriteLine("Please enter withdrawal amount.");

                        decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                        bool result = checking.withdraw(withdrawAmount);
                        if (result == false)
                        {
                            Console.WriteLine(" you can not withdraw this amount");
                        }
                    }
                    else if (userchoice == 2)
                    {
                        Console.WriteLine("Please enter your withdrawal amount.");
                        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                      bool result=   saving.withdraw(depositAmount);
                       if(result==false)
                        {
                            Console.WriteLine(" you can not withdraw this amount");
                        }
                    }
                    else
                    {
                        Console.WriteLine("oops wrong  entry. Please try again.");
                    }
                }
                else if (userchoice == 5)
                {
                    Console.WriteLine("Thank you for your business. Have a nice day.");
                    break;
                }
                else
                {
                    Console.WriteLine("oops! wrong entry . Please try again.");
                    userchoice = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Would you like to make another transaction? Y or NO");
                string userAnswer = Console.ReadLine().ToUpper();

                if (userAnswer == "N")

                { 
                    Console.WriteLine("Thank you for your business. Have a nice day.");
                    break;
                }


            }
            while (true);



        }


        }
    }
