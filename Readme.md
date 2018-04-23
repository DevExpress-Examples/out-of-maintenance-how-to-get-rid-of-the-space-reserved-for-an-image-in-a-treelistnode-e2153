# How to get rid of the space reserved for an image in a TreeListNode


<p>When the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraTreeListTreeList_SelectImageListtopic">TreeList.SelectImageList</a> or <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraTreeListTreeList_StateImageListtopic">TreeList.StateImageList</a> properties are assigned, each TreeListNode has an indent to draw these images, even if the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraTreeListNodesTreeListNode_SelectImageIndextopic">TreeListNode.SelectImageIndex</a> or <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraTreeListNodesTreeListNode_StateImageIndextopic">TreeListNode.StateImageIndex</a> properties are set to -1.</p><p>In a situation when this behavior is undesirable, it's possible to create a custom TreeList descendant, and change it by overriding the TreeListViewInfo.GetDataBoundsLocation method.</p>

<br/>


