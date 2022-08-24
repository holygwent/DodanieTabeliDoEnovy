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
      
        public CennaDodatkowa(RowCreator creator):base(creator)
        {
           
        }
        public CennaDodatkowa(Towar towar):base(towar)
        {

        }
        
    }
}
