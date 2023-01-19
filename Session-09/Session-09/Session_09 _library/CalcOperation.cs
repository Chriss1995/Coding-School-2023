using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace Session_09__library
{
    public class Addition
    {
        public decimal Do(decimal? x, decimal? y)
        {

            decimal ret = 0;

            if (x != null && y != null)
            {
                ret = x.Value + y.Value;
            }

            return ret;

        }
    }

    public class Subtraction
    {
        public decimal Do(decimal? x, decimal? y)
        {
            decimal ret = 0;
            if (x != null && y != null)
            {
                ret = x.Value - y.Value;
            }
            return ret;
        }

    }
    public class Multiplication
    {
        public decimal Do(decimal? x, decimal? y)
        {
            decimal ret = 0;
            if (x != null && y != null)
            {
                ret = x.Value * y.Value;
            }
            return ret;
        }
    }
   public class Division
    {
        public decimal Do(decimal? x, decimal? y)
        {
            decimal ret = 0;
            if (x != null && y != null)
            {
                ret = x.Value / y.Value;
            }
            return ret;
        }
    }
    public class Power
    {
        public decimal Do(decimal? x, decimal? y)
        {
           decimal ret = 0;
            if (x != null && y != null)
            {
                ret =(decimal)Math.Pow(x:(double) x.Value, y:(double) y.Value);
            }
            return ret;
        }
    }
    public class Squared_Root 
    {
        public decimal Do(decimal? x)
        {
            decimal ret = 0;
            if (x != null)
            {
                ret = (decimal)Math.Sqrt((double)x.Value);
            }
            return ret;
        }
    }

}