using Soneta.Business;
using Soneta.Towary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testTworzenieTabel.TowarCennyDodatkowe;
using testTworzenieTabel.UI_Zakladek;

[assembly: Worker(typeof(TowaryExtender))]
namespace testTworzenieTabel.UI_Zakladek
{
    public  class TowaryExtender
    {
        [Context]
        public Session Session { get; set; }
        [Context]
        public Towar Towar { get; set; }

        public View CennyDodatkowe => TowarCennyDodatkoweModule.GetInstance(Session).CennyDodatkowe.WgTowar[Towar].CreateView();

    }
}
