using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Statistics;
using Accord.Statistics.Distributions.Univariate;
using Accord.Math;


namespace Task3
{
    static class mathFormulas
    {
        public static double calculateErrorProbability(double paramOne, double paramTwo, double time, int typeId)
        {
            double result = 0;
            switch (typeId)
            {
                //Экспоненциальный
                case 1:
                    {
                        //В данном случае paramOne = Lambda
                        result = Math.Exp(-1 * paramOne*time);
                        break;
                    }
                //Рэлей
                case 2:
                    {
                        // paramOne = omega
                        result = Math.Exp(-1 * time / (2*Math.Pow(paramOne,2)));
                        break;
                    }
                //Нормальный
                case 3:
                    {
                        result = Normal.Function((paramOne - time)/ paramTwo)/Normal.Function(paramOne/paramTwo);
                        break;
                    }
                //Вейбулла
                case 4:
                    {
                        //ParamOne = Lambda0, paramTwo = k
                        result = Math.Exp(-paramOne * Math.Pow(time, paramTwo));
                        break;
                    }
            }

            return result;
        }

        public static double calculateErrorIntensivity(double paramOne, double paramTwo, double time, int typeId)
        {
            double result = 0;
            switch (typeId)
            {
                //Экспоненциальный
                case 1:
                    {
                        //В данном случае paramOne = Lambda
                        result = paramOne;
                        break;
                    }
                //Рэлей
                case 2:
                    {
                        // paramOne = omega
                        result = time / Math.Pow(paramOne,2);
                        break;
                    }
                //Нормальный
                case 3:
                    {
                        result = (Math.Exp(-1 * Math.Pow(time - paramOne, 2) / (2 * Math.Pow(paramTwo, 2)))) / (Math.Sqrt(2 * Math.PI) * paramTwo * Normal.Function((paramOne - time) / paramTwo));
                        break;
                    }
                //Вейбулла
                case 4:
                    {
                        //ParamOne = Lambda0, paramTwo = k
                        result = paramOne * paramTwo * Math.Pow(time, paramTwo - 1);
                        break;
                    }
            }

            return result;
        }

        public static double calculateAverageTimeUntilError(double paramOne, double paramTwo, double time, int typeId)
        {
            double result = 0;
            switch (typeId)
            {
                //Экспоненциальный
                case 1:
                    {
                        //В данном случае paramOne = Lambda
                        result = 1/paramOne;
                        break;
                    }
                //Рэлей
                case 2:
                    {
                        // paramOne = omega
                        result = Math.Sqrt(Math.PI / 2) * paramOne;
                        break;
                    }
                //Нормальный
                case 3:
                    {
                        result = paramOne + (paramTwo / ((Math.Sqrt(2 * Math.PI) * Normal.Function(paramOne / paramTwo))) * Math.Exp(-1 * Math.Pow(paramOne, 2) / (2 * Math.Pow(paramTwo, 2))));
                        break;
                    }
                //Вейбулла
                case 4:
                    {
                        result = Gamma.Function(1 / paramTwo + 1) / Math.Pow(paramOne, 1 / paramTwo);
                        break;
                    }
            }

            return result;
        }
    }
}
