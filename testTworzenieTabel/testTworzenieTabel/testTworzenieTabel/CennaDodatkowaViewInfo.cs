using Soneta.Business;
using Soneta.Business.Licence;
using Soneta.Business.UI;
using Soneta.Towary;
using Soneta.Types;
using System;
using System.Linq;
using testTworzenieTabel;
using testTworzenieTabel.TowarCennyDodatkowe;

[assembly: FolderView("Example",
    Priority = 10,
    Description = "Przykłady implementacji enova365",
    BrickColor = FolderViewAttribute.BlueBrick,
    Icon = "Soneta.Examples.Utils.examples.ico;Soneta.Examples",
    Contexts = new object[] { LicencjeModułu.All }
)]
//dla elementu w folderze
[assembly: FolderView("Example/CennaDodatkowa",
    Priority = 10000,
    Description = "",
    TableName = "CennaDodatkowa",
    ViewType = typeof(CennaDodatkowaViewInfo)
)]


namespace testTworzenieTabel
{
    public class CennaDodatkowaViewInfo : ViewInfo
    {
        public CennaDodatkowaViewInfo()
        {
            // View wiążemy z odpowiednią definicją viewform.xml poprzez property ResourceName
            ResourceName = "CennaDodatkowaViewInfo";

            // Inicjowanie contextu
            InitContext += CennaDodatkowaViewInfo_InitContext;

            // Tworzenie view zawierającego konkretne dane
            CreateView += CennaDodatkowaViewInfo_CreateView;
        }

       // public WParams WParam { get; set; }

        void CennaDodatkowaViewInfo_InitContext(object sender, ContextEventArgs args)
        {
            args.Context.TryAdd(() => new WParams(args.Context));
          
        }

        void CennaDodatkowaViewInfo_CreateView(object sender, CreateViewEventArgs args)
        {
            WParams parameters;
            if (!args.Context.Get(out parameters))
                return;
            args.View = ViewCreate(parameters);
            args.View.AllowNew = false;
           
        }

        protected View ViewCreate(WParams pars)
        {

            View view = TowarCennyDodatkoweModule.GetInstance(pars.Context.Session).CennyDodatkowe.WgTowar.CreateView();
           

            if (pars.Towar != null)
            {
                view.Condition &= new FieldCondition.Equal("Towar", pars.Towar);
            }
            if (pars.DataOd.IsNull)
            {
                view.Condition &= new FieldCondition.GreaterEqual("DataOd", pars.DataOd);
            }
            if (!pars.DataDo.IsNull)
            {
                view.Condition &= new FieldCondition.LessEqual("DataDo", pars.DataDo);
             
               
            }
           
            return view;
        }

       

     


    }
    public class WParams : ContextBase
    {
        public WParams(Context context) : base(context)
        {
         
        }
        private Date _dataOd;

        public Date DataOd
        {
            get { return _dataOd; }
            set { _dataOd = value;OnChanged(); }
        }
        private Date _dataDo;

        public Date DataDo
        {
            get { return _dataDo; }
            set { _dataDo = value; OnChanged(); }
        }

        private Towar _towar;

        public Towar Towar
        {
            get { return _towar; }
            set { _towar = value; OnChanged(); }
        }




    }
}
