<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128637612/17.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2153)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# OBSOLETE: How to get rid of the space reserved for an image in a TreeListNode

In version **18.1 and newer versions**, you can set the <a href="https://docs.devexpress.com/WindowsForms/DevExpress.XtraTreeList.TreeListOptionsView.RowImagesShowMode">TreeList.OptionsView.RowImagesShowMode</a> property to **InCell** to show images within cells without extra indents.

**For earlier versions:**
<p>When the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraTreeListTreeList_SelectImageListtopic">TreeList.SelectImageList</a> or <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraTreeListTreeList_StateImageListtopic">TreeList.StateImageList</a> properties are assigned, each TreeListNode has an indent to draw these images, even if the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraTreeListNodesTreeListNode_SelectImageIndextopic">TreeListNode.SelectImageIndex</a> or <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraTreeListNodesTreeListNode_StateImageIndextopic">TreeListNode.StateImageIndex</a> properties are set to -1.</p><p>In a situation when this behavior is undesirable, it's possible to create a custom TreeList descendant, and change it by overriding the TreeListViewInfo.CalcSelectImageBounds and TreeListViewInfo.CalcStateImageBounds methods.</p>
