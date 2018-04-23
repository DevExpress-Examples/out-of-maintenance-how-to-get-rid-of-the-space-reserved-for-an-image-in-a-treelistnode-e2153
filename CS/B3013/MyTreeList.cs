using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.ViewInfo;
using System.Drawing;
using DevExpress.XtraTreeList.Nodes;

namespace DXSample {
    public class MyTreeList :TreeList {
        public MyTreeList() : base() { }

        protected override TreeListViewInfo CreateViewInfo() {
            return new MyTreeListViewInfo(this);
        }
    }

    public class MyTreeListViewInfo :TreeListViewInfo {
        public MyTreeListViewInfo(TreeList treeList) : base(treeList) { }

        protected override Point GetDataBoundsLocation(TreeListNode node, int top) {
            Point result = base.GetDataBoundsLocation(node, top);
            if (Size.Empty != RC.SelectImageSize && -1 == node.SelectImageIndex)
                result.X -= RC.SelectImageSize.Width;
            if (Size.Empty != RC.StateImageSize && -1 == node.StateImageIndex)
                result.X -= RC.StateImageSize.Width;
            return result;
        }

        protected override void CalcStateImage(RowInfo ri) {
            base.CalcStateImage(ri);
            if (Size.Empty != RC.SelectImageSize && -1 == ri.Node.SelectImageIndex)
                ri.StateImageLocation.X -= RC.SelectImageSize.Width;
        }

        protected override void CalcSelectImage(RowInfo ri) {
            base.CalcSelectImage(ri);
            if (-1 == ri.Node.SelectImageIndex) ri.SelectImageLocation = Point.Empty;
        }
    }
}