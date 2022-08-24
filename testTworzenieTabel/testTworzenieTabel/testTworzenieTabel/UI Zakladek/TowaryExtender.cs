using Soneta.Business;
using Soneta.Towary;
using Soneta.Types;
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
    public class TowaryExtender
    {

        [Context]
        public Session Session { get; set; }
        [Context]
        public Towar Towar { get; set; }
        public FiltrTowaruPoCenieDodatkowej WParams { get; set; } = new FiltrTowaruPoCenieDodatkowej();

        public View CennyDodatkowe
        {
            get
            {
                var view = TowarCennyDodatkoweModule.GetInstance(Session).CennyDodatkowe.WgTowar[Towar].CreateView();
                if (!WParams.DataOd.IsNull)
                {
                    view.Condition &= new FieldCondition.GreaterEqual("DataOd", WParams.DataOd);
                }
                if (!WParams.DataDo.IsNull)
                {
                    view.Condition &= new FieldCondition.LessEqual("DataDo", WParams.DataDo);


                }
                return view;
            }
            private set { }
        }


    }
    public class FiltrTowaruPoCenieDodatkowej
    {

        private Date _dataOd;

        public Date DataOd
        {
            get { return _dataOd; }
            set { _dataOd = value; }
        }
        private Date _dataDo;

        public Date DataDo
        {
            get { return _dataDo; }
            set { _dataDo = value; }
        }



    }

}
