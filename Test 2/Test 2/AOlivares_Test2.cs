using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PhoneCompanyBilling
{
    class AOlivares_Test2
    {
        const double PackageA_MonthlyFee = 9.95;
        const double PackageA_HoursIncluded = 5;
        const double PackageA_AdditionalRate = 0.08;

        const double PackageB_MonthlyFee = 14.95;
        const double PackageB_HoursIncluded = 10;
        const double PackageB_AdditionalRate = 0.06;

        const double PackageC_MonthlyFee = 19.95;

        static void Main(string[] args)
        {
            bool tryAgain = true;
            do
            {
                Console.WriteLine("Welcome to the International Internet phone company billing system!");

                Console.Write("Enter customer name: ");
                string customerName = Console.ReadLine();

                char packageChoice;
                do
                {
                    Console.WriteLine("Choose a package: ");
                    Console.WriteLine("A. Package A");
                    Console.WriteLine("B. Package B");
                    Console.WriteLine("C. Package C");
                    Console.Write("Enter your choice (A/B/C): ");
                    packageChoice = char.ToUpper(Console.ReadKey().KeyChar);
                    Console.WriteLine();
                } while (packageChoice != 'A' && packageChoice != 'B' && packageChoice != 'C');

                double hoursUsed;
                do
                {
                    Console.Write("Enter number of hours used: ");
                } while (!double.TryParse(Console.ReadLine(), out hoursUsed) || hoursUsed < 0);

                double totalAmount = 0;
                switch (packageChoice)
                {
                    case 'A':
                        totalAmount = CalculateBill(PackageA_MonthlyFee, PackageA_HoursIncluded, PackageA_AdditionalRate, hoursUsed);
                        break;
                    case 'B':
                        totalAmount = CalculateBill(PackageB_MonthlyFee, PackageB_HoursIncluded, PackageB_AdditionalRate, hoursUsed);
                        break;
                    case 'C':
                        totalAmount = PackageC_MonthlyFee;
                        break;
                }

                Console.WriteLine($"Customer Name: {customerName}");
                Console.WriteLine($"Package: {packageChoice}");
                Console.WriteLine($"Hours Used: {hoursUsed}");
                Console.WriteLine($"Total Amount Due: ${totalAmount:F2}");

                double savings = CalculateSavings(packageChoice, totalAmount);
                if (savings > 0)
                {
                    Console.WriteLine($"You would save ${savings:F2} if you purchased a higher package.");
                }

                Console.Write("Try again? (Y/N): ");
                char tryAgainInput = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
                tryAgain = tryAgainInput == 'Y';
                if (!tryAgain)
                {
                    WriteBillToFile(customerName, packageChoice, hoursUsed, totalAmount);
                }
            } while (tryAgain);
        }

        static double CalculateBill(double monthlyFee, double hoursIncluded, double additionalRate, double hoursUsed)
        {
            double totalAmount = monthlyFee;
            if (hoursUsed > hoursIncluded)
            {
                totalAmount += (hoursUsed - hoursIncluded) * additionalRate * 60; // convert hours to minutes
            }
            return totalAmount;
        }

        static double CalculateSavings(char packageChoice, double totalAmount)
        {
            double savings = 0;
            switch (packageChoice)
            {
                case 'A':
                    savings = (PackageB_MonthlyFee - PackageA_MonthlyFee) + ((PackageB_HoursIncluded * PackageA_AdditionalRate) - (PackageA_HoursIncluded * PackageA_AdditionalRate));
                    break;
                case 'B':
                    savings = PackageC_MonthlyFee - PackageB_MonthlyFee;
                    break;
            }
            return savings;
        }

        static void WriteBillToFile(string customerName, char packageChoice, double hoursUsed, double totalAmount)
        {
            string bill = $"Customer Name: {customerName}\n";
            bill += $"Package: {packageChoice}\n";
            bill += $"Hours Used: {hoursUsed}\n";
            bill += $"Total Amount Due: ${totalAmount:F2}\n";

            File.WriteAllText("MyBill.txt", bill);
            Console.WriteLine("Bill has been saved to MyBill.txt");
        }
    }
}