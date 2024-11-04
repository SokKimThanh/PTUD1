namespace GUI.UI.Modules
{
    public partial class ucChonGhe : ucBase
    {
        public ucChonGhe()
        {
            InitializeComponent();
            this.layoutTitle.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutTitle.MaxSize = new System.Drawing.Size(0, 42);
            this.layoutTitle.MinSize = new System.Drawing.Size(36, 36);
        }
        protected override void Load_Data()
        {
            if (strFunctionCode != "")
                lblTitle.Text = strFunctionCode.ToUpper().Trim();
        }
    }
}
