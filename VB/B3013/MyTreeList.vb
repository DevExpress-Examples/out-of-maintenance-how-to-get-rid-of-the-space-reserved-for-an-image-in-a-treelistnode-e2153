Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.ViewInfo
Imports System.Drawing
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraTreeList.Painter

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

        Protected Overrides Sub CalcSelectImageBounds(ByVal rInfo As RowInfo, ByVal indentBounds As Rectangle)
            MyBase.CalcSelectImageBounds(rInfo, indentBounds)
            If -1 = rInfo.SelectImageIndex Then
                rInfo.SelectImageBounds = Rectangle.Empty
            End If
        End Sub
        Protected Overrides Sub CalcStateImageBounds(ByVal rInfo As RowInfo, ByVal indentBounds As Rectangle)
            MyBase.CalcStateImageBounds(rInfo, indentBounds)
            If Size.Empty <> RC.SelectImageSize AndAlso -1 = rInfo.StateImageIndex Then
                rInfo.StateImageBounds = Rectangle.Empty
            End If
        End Sub
    End Class
End Namespace