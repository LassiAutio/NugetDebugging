namespace MyNuget
{
    public class MyHome
    {
        public int YearOfConstruction { get; set; }

        public string GetCondition()
        {
            if (YearOfConstruction == 2020)
            {
                return "It is a brand new home!";
            }
            else if (YearOfConstruction > 2010)
            {
                return "Quite new home";
            }
            else if (YearOfConstruction < 2000)
            {
                return "It is from past century";
            }

            return "ERROR";
        }
    }
}
