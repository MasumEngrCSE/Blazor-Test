using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLocales
{
    public class CultureInfoClass
    {
        public CultureInfoClass()
        {

        }


        public void CultureInfoInstances()
        {
            var enUS = new CultureInfo("en-US");
            Console.WriteLine(enUS.DateTimeFormat.GetDayName(DayOfWeek.Monday));
            Console.WriteLine(enUS.NumberFormat.NumberDecimalSeparator);


            var nlBE = new CultureInfo("nl-BE");
            Console.WriteLine(nlBE.DateTimeFormat.GetDayName(DayOfWeek.Monday));
            Console.WriteLine(nlBE.NumberFormat.NumberDecimalSeparator);
        }
    }
}
