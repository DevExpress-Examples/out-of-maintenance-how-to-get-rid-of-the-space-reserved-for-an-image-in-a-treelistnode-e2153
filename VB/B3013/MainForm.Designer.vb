Namespace B3013
    Partial Public Class MainForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
            Me.myTreeList1 = New DXSample.MyTreeList()
            Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            CType(Me.myTreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' myTreeList1
            ' 
            Me.myTreeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.treeListColumn1})
            Me.myTreeList1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.myTreeList1.Location = New System.Drawing.Point(0, 0)
            Me.myTreeList1.Name = "myTreeList1"
            Me.myTreeList1.BeginUnboundLoad()
            Me.myTreeList1.AppendNode(New Object() { "Root 1"}, -1, 5, 3, 4)
            Me.myTreeList1.AppendNode(New Object() { "Child 1"}, 0, 5, -1, 4)
            Me.myTreeList1.AppendNode(New Object() { "Root 2"}, -1, 5, 3, -1)
            Me.myTreeList1.AppendNode(New Object() { "Child 2"}, 2, 5, -1, -1)
            Me.myTreeList1.AppendNode(New Object() { "Child 3"}, 2, 5, 3, 4)
            Me.myTreeList1.EndUnboundLoad()
            Me.myTreeList1.OptionsView.AutoWidth = False
         '   this.myTreeList1.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.RowFocus;
            Me.myTreeList1.SelectImageList = Me.imageCollection1
            Me.myTreeList1.Size = New System.Drawing.Size(401, 268)
            Me.myTreeList1.StateImageList = Me.imageCollection1
            Me.myTreeList1.TabIndex = 0
            ' 
            ' treeListColumn1
            ' 
            Me.treeListColumn1.Caption = "Name"
            Me.treeListColumn1.FieldName = "Name"
            Me.treeListColumn1.MinWidth = 88
            Me.treeListColumn1.Name = "treeListColumn1"
            Me.treeListColumn1.Visible = True
            Me.treeListColumn1.VisibleIndex = 0
            ' 
            ' imageCollection1
            ' 
            Me.imageCollection1.ImageStream = (CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            Me.imageCollection1.InsertGalleryImage("apply_16x16.png", "images/actions/apply_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_16x16.png"), 3)
            Me.imageCollection1.Images.SetKeyName(3, "apply_16x16.png")
            Me.imageCollection1.InsertGalleryImage("cancel_16x16.png", "images/actions/cancel_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_16x16.png"), 4)
            Me.imageCollection1.Images.SetKeyName(4, "cancel_16x16.png")
            Me.imageCollection1.InsertGalleryImage("add_16x16.png", "images/actions/add_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/add_16x16.png"), 5)
            Me.imageCollection1.Images.SetKeyName(5, "add_16x16.png")
            ' 
            ' MainForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(401, 268)
            Me.Controls.Add(Me.myTreeList1)
            Me.Name = "MainForm"
            Me.Text = "DX Sample"
            CType(Me.myTreeList1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private myTreeList1 As DXSample.MyTreeList
        Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private imageCollection1 As DevExpress.Utils.ImageCollection

    End Class
End Namespace

