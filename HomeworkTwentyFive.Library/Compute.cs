namespace HomeworkTwentyFive.Library
{
    public static class Compute
    {
        public static double TakeHomePay(double basicSalary, int daysOfWork, double taxPercentage)
        {
            double output;

            double gross = basicSalary * daysOfWork;
            double taxDeduction = gross * (taxPercentage / 100);
            output = gross - taxDeduction; 

            return output;
        }
    }
}
