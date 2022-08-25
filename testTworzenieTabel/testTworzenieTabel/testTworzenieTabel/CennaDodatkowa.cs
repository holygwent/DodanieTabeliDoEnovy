using Soneta.Towary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Soneta.Types;
using testTworzenieTabel.TowarCennyDodatkowe;
using Soneta.Business;
using testTworzenieTabel;

[assembly: NewRow(typeof(CennaDodatkowa))]

namespace testTworzenieTabel
{
    public class CennaDodatkowa :TowarCennyDodatkoweModule.CennaDodatkowaRow
    {
       
        protected override void OnAdded()
        {

            base.OnAdded();
            var month = DateTime.Now.Month;
            var year = DateTime.Now.Year;
            var lastDayOfMonth = DateTime.DaysInMonth(year, month);
            DataOd = Date.Parse($"1.{month.ToString()}.{year.ToString()}");
           DataDo = Date.Parse($"{lastDayOfMonth.ToString()}.{month.ToString()}.{year.ToString()}");

            
        }

        public CennaDodatkowa(RowCreator creator):base(creator)
        {

            
            
          

        }
        public CennaDodatkowa(Towar towar) :base(towar)
        {
          
        }
        
    }
}
