namespace ApiTest.CustomForms
{
    public partial class ucEmpty : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucEmpty _instatance;

        public static ucEmpty Instance
        {
            get
            {
                if (_instatance == null)
                {
                    _instatance = new ucEmpty();
                }

                return _instatance;
            }

        }
        public ucEmpty()
        {
            InitializeComponent();
        }
    }
}
