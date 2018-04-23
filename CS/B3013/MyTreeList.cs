using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.ViewInfo;
using System.Drawing;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Painter;

namespace DXSample {
    public class MyTreeList :TreeList {
        public MyTreeList() : base() { }

        protected override TreeListViewInfo CreateViewInfo() {
            return new MyTreeListViewInfo(this);  
        }
    }

    public class MyTreeListViewInfo :TreeListViewInfo {
        public MyTreeListViewInfo(TreeList treeList) : base(treeList) { }

        protected override void CalcSelectImageBounds(RowInfo rInfo, Rectangle indentBounds)
        {
            base.CalcSelectImageBounds(rInfo, indentBounds);
            if (-1 == rInfo.SelectImageIndex) rInfo.SelectImageBounds = Rectangle.Empty;
        }
        protected override void CalcStateImageBounds(RowInfo rInfo, Rectangle indentBounds)
        {
            base.CalcStateImageBounds(rInfo, indentBounds);
            if (Size.Empty != RC.SelectImageSize && -1 == rInfo.StateImageIndex)
                rInfo.StateImageBounds = Rectangle.Empty;
        }
    }
}