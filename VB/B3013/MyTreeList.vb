Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.ViewInfo
Imports System.Drawing
Imports DevExpress.XtraTreeList.Nodes

Namespace DXSample
    Public Class MyTreeList
        Inherits TreeList

        Public Sub New()
            MyBase.New()
        End Sub

        Protected Overrides Function CreateViewInfo() As TreeListViewInfo
            Return New MyTreeListViewInfo(Me)
        End Function
    End Class

    Public Class MyTreeListViewInfo
        Inherits TreeListViewInfo

        Public Sub New(ByVal treeList As TreeList)
            MyBase.New(treeList)
        End Sub

        Protected Overrides Function GetDataBoundsLocation(ByVal node As TreeListNode, ByVal top As Integer) As Point
            Dim result As Point = MyBase.GetDataBoundsLocation(node, top)
            If Size.Empty <> RC.SelectImageSize AndAlso -1 = node.SelectImageIndex Then
                result.X -= RC.SelectImageSize.Width
            End If
            If Size.Empty <> RC.StateImageSize AndAlso -1 = node.StateImageIndex Then
                result.X -= RC.StateImageSize.Width
            End If
            Return result
        End Function

        Protected Overrides Sub CalcStateImage(ByVal ri As RowInfo)
            MyBase.CalcStateImage(ri)
            If Size.Empty <> RC.SelectImageSize AndAlso -1 = ri.Node.SelectImageIndex Then
                ri.StateImageLocation.X = ri.DataBounds.Left - RC.StateImageSize.Width
            End If

        End Sub

        Protected Overrides Sub CalcSelectImage(ByVal ri As RowInfo)
            MyBase.CalcSelectImage(ri)
            If -1 = ri.Node.SelectImageIndex Then
                ri.SelectImageLocation = Point.Empty
            End If
        End Sub
    End Class
End Namespace