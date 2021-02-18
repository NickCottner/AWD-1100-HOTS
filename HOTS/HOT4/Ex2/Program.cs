using System;
using static System.Console;


namespace Ex2
{
    class Program
    {
        const int LEN = 6;
        const string MINEMPNUMBER = "000001";
        const string MAXEMPNUMBER = "999999";
        const double MINHRS = 0;
        const double MAXHRS = 84;
        const double MINRATE = 0.00;
        const double MAXRATE = 99.99;
        const string DEFFIRST = "No First Name Provided!";
        const string DEFLAST = "No Last Name Provided!";
        const string DEFEMPLOYEENUMBER = "No Employee Number Provided!";

        static string[] firstName = new string[LEN];
        static string[] lastName = new string[LEN];
        static string[] empNumber = new string[LEN];
        static bool[] unionStatus = new bool[LEN];
        static double[] hoursWorked = new double[LEN];
        static double[] hourlyRate = new double[LEN];
        static double[] grossPay = new double[LEN];
        static double lowestGrossPay = 1001;
        static double highestGrossPay = -1;
        static double averageGP = 0;




        static void Main(string[] args)
        {
            for (int lcv = 0; lcv < LEN; ++lcv)
            {


                firstName[lcv] = inputFirstName();
                lastName[lcv] = inputLastName();
                empNumber[lcv] = inputEmployeeNumber();
                unionStatus[lcv] = inputUnionStatus();
                hoursWorked[lcv] = inputHoursWorked();
                hourlyRate[lcv] = inputHourlyRate();
                grossPay[lcv] = calculateGrossPay(hoursWorked[lcv], hourlyRate[lcv]);
                calculateSumGP();
                calculateAverageGP();


            }
            printResults();
        }
        static string inputFirstName()
        {
            string fn = "";
            try
            {
                Console.Clear();
                Write("Please Input a First Name: ");
                fn = ReadLine();

                if (fn.Trim() == "")
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException ae)
            {
                WriteLine(ae.Message + "\nDefault Value Set for First Name.");
                fn = DEFFIRST;
            }
            return fn;
        }
        static string inputLastName()
        {
            string ln = "";
            try
            {
                Console.Clear();
                Write("Please Input a Last Name: ");
                ln = ReadLine();

                if (ln.Trim() == "")
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException ae)
            {
                WriteLine(ae.Message + "\nDefault Value Set for Last Name.");
                ln = DEFFIRST;
            }
            return ln;
        }
        static string inputEmployeeNumber()
        {
            string en = "";
            try
            {
                Console.Clear();
                Write("Please Enter an Employee Number: ");
                en = ReadLine();

                if (en.Trim() == "")
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException ae)
            {
                WriteLine(ae.Message + "\nDefault Value Set for Employee Number.");
                en = DEFEMPLOYEENUMBER;
            }
            return en;
        }
        static bool inputUnionStatus()
        {
            bool keepGoing = true;
            string us = "";

            if (keepGoing)
            {
                Write("Please Enter Union Status: ");
                us = ReadLine();
            }
            else
            {
                return false;
            }
            return keepGoing;
        }
        static double inputHoursWorked()
        {
            string input = "";
            double hoursWorked;

            do
            {
                Write("Please Enter Hours Worked (0 - 84): ");
                input = ReadLine();

                if (Double.TryParse(input, out hoursWorked))
                {
                    hoursWorked = Convert.ToDouble(input);
                }
                else
                {
                    hoursWorked = 0;
                }
            }
            while ((hoursWorked < MINHRS) || (hoursWorked > MAXHRS));

            return hoursWorked;
        }
        static double inputHourlyRate()
        {
            string input = "";
            double hourlyRate;

            do
            {
                Write("Please Enter Hourly Rate (0 - 99.99): ");
                input = ReadLine();

                if (Double.TryParse(input, out hourlyRate))
                {
                    hourlyRate = Convert.ToDouble(input);
                }
                else
                {
                    hourlyRate = 0;
                }
            }
            while ((hourlyRate < MINRATE) || (hourlyRate > MAXRATE));

            return hourlyRate;
        }
        static double calculateGrossPay(double hoursWorked, double hourlyRate)
        {
            double gp = hoursWorked * hourlyRate;

            if (gp < lowestGrossPay)
            {
                gp = lowestGrossPay;
            }
            if (gp > highestGrossPay)
            {
                gp = highestGrossPay;
            }
            return gp;
        }
        static void calculateSumGP()
        {
            int sum = 0;

            for (int lcv = 0; lcv < grossPay.Length; ++lcv)
            {
                sum += grossPay.Length;
            }
        }
        static void calculateAverageGP()
        {
            int sum = 0;

            double avg = (double)sum / grossPay.Length;
        }


        static void printResults()
        {
            Console.Clear();

            for (int lcv = 0; lcv < LEN; ++lcv)
            {
                WriteLine("First Name: " + firstName[lcv]);
                WriteLine("Last Name: " + lastName[lcv]);
                WriteLine("Employee Number: " + empNumber[lcv]);
                WriteLine("Union Status: " + unionStatus[lcv]);
                WriteLine("Hours Worked: " + hoursWorked[lcv]);
                WriteLine("Hourly Rate: " + hourlyRate[lcv]);
                WriteLine("Gross Pay: " + grossPay[lcv]);
                ReadLine();
                Console.Clear();
            }

            WriteLine("Lowest Gross Pay: " + lowestGrossPay.ToString("c"));
            WriteLine("Highest Gross Pay: " + highestGrossPay.ToString("c"));
            WriteLine("Average Gross Pay: " + averageGP.ToString("c"));

        }
    }    
}
