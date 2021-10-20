Option Explicit On
Option Strict On


Public Class Form1
    Private db As New NorthwindEntities()

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Dim cus = From c In db.Customers
                  Select New With
                      {
                      c.CustomerID,
                      c.CompanyName,
                      c.ContactName,
                      c.ContactTitle,
                      c.Address,
                      c.City,
                      c.Country,
                      c.Phone,
                      c.Fax
                     }
        If cus.Count() > 0 Then
            DataGridView1.DataSource = cus.ToList()
        Else
            DataGridView1.DataSource = Nothing
            MessageBox.Show("Sorry,No records found.", "SQL Server Entity framework 6: iBasskung.",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
