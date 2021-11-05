Imports System.Data.SqlClient

Public Class Form1
    Private Const ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nogueira\Desktop\WindowsApp3\WindowsApp3\WindowsApp3\Pizzaria.mdf; Integrated Security=True; Connect Timeout=30"
    Dim myConn As New SqlConnection(ConnectionString)
    Dim myCmd As SqlCommand
    Dim myAdapter As New SqlDataAdapter
    Dim myDataTable As DataTable

    Public Class GlobalVariables
        Public Shared s = New List(Of String)
    End Class

    Private Sub PizzariaLoad(send As Object, e As EventArgs) Handles MyBase.Load
        Try
            myConn.Open()
            myCmd = New SqlCommand With {
                .Connection = myConn,
                .CommandText = "CREATE DATABASE pedidos"
            }
            myCmd.ExecuteNonQuery()

            myCmd = New SqlCommand With {
                .Connection = myConn,
                .CommandText = "
                CREATE TABLE IF NOT EXISTS pedidos ( 
                    user_id uuid PRIMARY KEY NOT NULL
                    orders VARCHAR 
                )"
            }
            myCmd.ExecuteNonQuery()
            myCmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            myConn.Close()
        End Try

    End Sub

    Private Function SaveFlavorList(ByVal User As String, ByVal Orders As String) As Boolean
        Try
            myConn.Open()
            myCmd = New SqlCommand With {
                .Connection = myConn,
                .CommandText = "
                INSERT INTO PEDIDOS (User_id, Orders) 
                VALUES(@User, @Orders)"
            }
            myCmd.Parameters.Add("@User", SqlDbType.VarChar)
            myCmd.Parameters("@User").Value = User
            myCmd.Parameters.Add("@Orders", SqlDbType.VarChar)
            myCmd.Parameters("@Orders").Value = Orders
            myCmd.ExecuteNonQuery()
            myConn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function GetFlavorList(ByVal User As String) As DataTable
        myConn.Open()
        myCmd = New SqlClient.SqlCommand With {
            .Connection = myConn,
            .CommandText = "
                SELECT orders
                FROM pedidos
                WHERE user_id = @User
            "
        }
        myCmd.Parameters.Add("@User", SqlDbType.VarChar)
        myCmd.Parameters("@User").Value = User
        myAdapter.SelectCommand = myCmd
        myAdapter.Fill(myDataTable)
        Dim Result As New DataTable
        myConn.Close()
        Return Result
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GlobalVariables.s.Clear()
        ListBox1.Items.Clear()

        For x = 0 To CheckedListBox1.CheckedItems.Count - 1
            GlobalVariables.s.Add(CheckedListBox1.CheckedItems(x).ToString)
        Next x

        For x = 0 To CheckedListBox2.CheckedItems.Count - 1
            GlobalVariables.s.Add(CheckedListBox2.CheckedItems(x).ToString)
        Next x

        Dim value As String = String.Join(",", GlobalVariables.s)

        SaveFlavorList("023g3a2", value)

        For x = 0 To GlobalVariables.s.Count - 1
            ListBox1.Items.Add(GlobalVariables.s(x))
        Next x
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GetFlavorList("023g3a2")
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub CheckedListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox2.SelectedIndexChanged

    End Sub
End Class
