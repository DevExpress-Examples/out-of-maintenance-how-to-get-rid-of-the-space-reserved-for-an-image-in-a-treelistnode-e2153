namespace B3013 {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.myTreeList1 = new DXSample.MyTreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.myTreeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // myTreeList1
            // 
            this.myTreeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.myTreeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myTreeList1.Location = new System.Drawing.Point(0, 0);
            this.myTreeList1.Name = "myTreeList1";
            this.myTreeList1.BeginUnboundLoad();
            this.myTreeList1.AppendNode(new object[] {
            "Root 1"}, -1, 5, 3, 4);
            this.myTreeList1.AppendNode(new object[] {
            "Child 1"}, 0, 5, -1, 4);
            this.myTreeList1.AppendNode(new object[] {
            "Root 2"}, -1, 5, 3, -1);
            this.myTreeList1.AppendNode(new object[] {
            "Child 2"}, 2, 5, -1, -1);
            this.myTreeList1.AppendNode(new object[] {
            "Child 3"}, 2, 5, 3, 4);
            this.myTreeList1.EndUnboundLoad();
            this.myTreeList1.OptionsView.AutoWidth = false;
         //   this.myTreeList1.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.RowFocus;
            this.myTreeList1.SelectImageList = this.imageCollection1;
            this.myTreeList1.Size = new System.Drawing.Size(401, 268);
            this.myTreeList1.StateImageList = this.imageCollection1;
            this.myTreeList1.TabIndex = 0;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Name";
            this.treeListColumn1.FieldName = "Name";
            this.treeListColumn1.MinWidth = 88;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.InsertGalleryImage("apply_16x16.png", "images/actions/apply_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_16x16.png"), 3);
            this.imageCollection1.Images.SetKeyName(3, "apply_16x16.png");
            this.imageCollection1.InsertGalleryImage("cancel_16x16.png", "images/actions/cancel_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_16x16.png"), 4);
            this.imageCollection1.Images.SetKeyName(4, "cancel_16x16.png");
            this.imageCollection1.InsertGalleryImage("add_16x16.png", "images/actions/add_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/add_16x16.png"), 5);
            this.imageCollection1.Images.SetKeyName(5, "add_16x16.png");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 268);
            this.Controls.Add(this.myTreeList1);
            this.Name = "MainForm";
            this.Text = "DX Sample";
            ((System.ComponentModel.ISupportInitialize)(this.myTreeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DXSample.MyTreeList myTreeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.Utils.ImageCollection imageCollection1;

    }
}

