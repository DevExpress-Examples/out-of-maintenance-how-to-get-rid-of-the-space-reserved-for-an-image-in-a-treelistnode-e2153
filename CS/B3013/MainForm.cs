using DevExpress.XtraEditors;

namespace B3013 {
    public partial class MainForm :XtraForm {
        public MainForm() {
            InitializeComponent();
        }
        protected override void OnShown(System.EventArgs e) {
            base.OnShown(e);
            myTreeList1.OptionsView.RowImagesShowMode = DevExpress.XtraTreeList.RowImagesShowMode.InCell;
        }
    }
}