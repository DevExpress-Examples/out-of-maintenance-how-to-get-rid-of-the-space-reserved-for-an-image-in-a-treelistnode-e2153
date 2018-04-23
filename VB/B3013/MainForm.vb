Imports DevExpress.XtraEditors

Namespace B3013
    Partial Public Class MainForm
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub
        Protected Overrides Sub OnShown(ByVal e As System.EventArgs)
            MyBase.OnShown(e)
            myTreeList1.OptionsView.RowImagesShowMode = DevExpress.XtraTreeList.RowImagesShowMode.InCell
        End Sub
    End Class
End Namespace