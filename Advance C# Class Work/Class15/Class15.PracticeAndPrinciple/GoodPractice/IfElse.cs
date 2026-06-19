namespace Class15.PracticeAndPrinciple.GoodPractice
{
    internal class IfElse
    {
        public void CheckNumber(int numberOne, int numberTwo)
        {
            // BAD EXAMPLE:

            if (numberOne <= 100 && numberTwo <= 100)
            {
                if (numberOne % 2 == 0 && numberTwo % 2 == 0)
                {
                    if (numberOne > 0 && numberTwo > 0)
                    {

                    }
                }
            }


            // GOOD EXAMPLE:
            if ((numberOne > 100 || numberOne < 0) && (numberTwo > 100 || numberTwo < 0)) return;
            if(numberOne %2 != 0 && numberTwo % 2 != 0) return;
            if(numberOne == 0 && numberTwo == 0) 
            {

            }
        }
    }
}
