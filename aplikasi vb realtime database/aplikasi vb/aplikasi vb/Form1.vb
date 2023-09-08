Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
'-------------------------------------------

Imports System.Web.Script.Serialization
Imports System.ComponentModel
Public Class Form1
    Dim clearDGVCol As Boolean = True

    Private dtTableGrd As DataTable 'This variable is used to search data on DataGridView.

    '-------------------------------------------Configure FireSharp
    Private fcon As New FirebaseConfig() With
        {
        .AuthSecret = "77Nn44MMkR3fFQE87CcYr8FGOfdYQlmoEH2fRovf",
        .BasePath = "https://vbnetfirebasedatabase-d648f-default-rtdb.firebaseio.com/"
        }

    Private client As IFirebaseClient
    '-------------------------------------------

    '-------------------------------------------Sub to change the Enabled status Of the ToolBox In it.
    Sub DisplayRegSave(Stat As Boolean)
        TBDates.Enabled = Stat
        TBJenis.Enabled = Stat
        TBOprate.Enabled = Stat
        TBSuhu.Enabled = Stat
        BtnSave.Enabled = Stat
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If BtnSave.Text = "Save" Then 'Conditions for storing data to the database.
            If TBDates.Text = Nothing Then
                MessageBox.Show("Date field is empty." & vbCrLf & "Please fill in the name field to continue.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If TBJenis.Text = Nothing Then
                MessageBox.Show("Jenis field is empty." & vbCrLf & "Please fill in the name field to continue.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If TBOprate.Text = Nothing Then
                MessageBox.Show("Oprate field is empty." & vbCrLf & "Please fill in the name field to continue.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If TBSuhu.Text = Nothing Then
                MessageBox.Show("Suhu field is empty." & vbCrLf & "Please fill in the name field to continue.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Try
                Me.Text = "VB Net Firebase RealTime Database (Saving. Please wait...)"
                Maintenen.Text = "Registration (Saving. Please wait...)"
                DisplayRegSave(False)

                Dim PD As New DataMesin() With
                    {
                    .Dates = TBDates.Text,
                    .Jenis = TBJenis.Text,
                    .Oprate = TBOprate.Text,
                    .Suhu = TBSuhu.Text
                    }

                Dim save = client.Set("DataMesinDB/" + TBJenis.Text, PD) 'To save data to Firebase Database.

                DisplayRegSave(True)
                Maintenen.Text = "Registration"
                Me.Text = "VB Net Firebase RealTime Database"

                MessageBox.Show("Data saved successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                If ex.Message = "One or more errors occurred." Then
                    MessageBox.Show("Cannot connect to firebase, check your network !", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                DisplayRegSave(True)
                Maintenen.Text = "Registration"
                Me.Text = "VB Net Firebase RealTime Database"
            End Try

        Else 'Conditions for updating data to a database.

            If TBDates.Text = Nothing Then
                MessageBox.Show("Date field is empty." & vbCrLf & "Please fill in the name field to continue.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If TBSuhu.Text = Nothing Then
                MessageBox.Show("Suhu field is empty." & vbCrLf & "Please fill in the name field to continue.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Try
                Me.Text = "VB Net Firebase RealTime Database (Updating. Please wait...)"
                Maintenen.Text = "Registration (Updating. Please wait...)"
                DisplayRegSave(False)

                Dim PD As New DataMesin() With
                    {
                    .Dates = TBDates.Text,
                    .Jenis = TBJenis.Text,
                    .Oprate = TBOprate.Text,
                    .Suhu = TBSuhu.Text
                    }

                Dim update = client.Update("DataMesinDB/" + TBJenis.Text, PD) 'To update data to Firebase Database.

                DisplayRegSave(True)
                Maintenen.Text = "Registration"
                Me.Text = "VB Net Firebase RealTime Database"

                MessageBox.Show("Data updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                If ex.Message = "One or more errors occurred." Then
                    MessageBox.Show("Cannot connect to firebase, check your network !", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                DisplayRegSave(True)
                Maintenen.Text = "Registration"
                Me.Text = "VB Net Firebase RealTime Database"
            End Try
        End If
    End Sub
End Class
