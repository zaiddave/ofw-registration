Public Class frmManage
    Dim i As Integer
    Private Sub PersonalBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PersonalBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OFWRegistrationDataSet)

    End Sub

    Private Sub frmManage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OFWRegistrationDataSet.Beneficiaries' table. You can move, or remove it, as needed.
        Me.BeneficiariesTableAdapter.Fill(Me.OFWRegistrationDataSet.Beneficiaries)
        'TODO: This line of code loads data into the 'OFWRegistrationDataSet.Registration' table. You can move, or remove it, as needed.
        Me.RegistrationTableAdapter.Fill(Me.OFWRegistrationDataSet.Registration)
        'TODO: This line of code loads data into the 'OFWRegistrationDataSet.Contract' table. You can move, or remove it, as needed.
        Me.ContractTableAdapter.Fill(Me.OFWRegistrationDataSet.Contract)
        'TODO: This line of code loads data into the 'OFWRegistrationDataSet.Address' table. You can move, or remove it, as needed.
        Me.AddressTableAdapter.Fill(Me.OFWRegistrationDataSet.Address)
        'TODO: This line of code loads data into the 'OFWRegistrationDataSet.Personal' table. You can move, or remove it, as needed.
        Me.PersonalTableAdapter.Fill(Me.OFWRegistrationDataSet.Personal)

    End Sub

    Private Sub PersonalDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PersonalDataGridView.CellClick
        i = (PersonalDataGridView.CurrentRow.Index) + 1

        Me.AddressTableAdapter.FillById(Me.OFWRegistrationDataSet.Address, i)
        Me.BeneficiariesTableAdapter.FillById(Me.OFWRegistrationDataSet.Beneficiaries, i)
        Me.ContractTableAdapter.FillById(Me.OFWRegistrationDataSet.Contract, i)
        Me.RegistrationTableAdapter.FillById(Me.OFWRegistrationDataSet.Registration, i)
    End Sub

    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click
        Me.filterGrid()
    End Sub

    Private Sub filterGrid()
        'TODO: This line of code loads data into the 'OFWRegistrationDataSet.Beneficiaries' table. You can move, or remove it, as needed.
        Me.BeneficiariesTableAdapter.Fill(Me.OFWRegistrationDataSet.Beneficiaries)
        'TODO: This line of code loads data into the 'OFWRegistrationDataSet.Registration' table. You can move, or remove it, as needed.
        Me.RegistrationTableAdapter.Fill(Me.OFWRegistrationDataSet.Registration)
        'TODO: This line of code loads data into the 'OFWRegistrationDataSet.Contract' table. You can move, or remove it, as needed.
        Me.ContractTableAdapter.Fill(Me.OFWRegistrationDataSet.Contract)
        'TODO: This line of code loads data into the 'OFWRegistrationDataSet.Address' table. You can move, or remove it, as needed.
        Me.AddressTableAdapter.Fill(Me.OFWRegistrationDataSet.Address)
        'TODO: This line of code loads data into the 'OFWRegistrationDataSet.Personal' table. You can move, or remove it, as needed.
        Me.PersonalTableAdapter.Fill(Me.OFWRegistrationDataSet.Personal)
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        frmMain.Show()

    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        Me.PersonalBindingSource.MoveFirst()
        Me.AddressBindingSource.MoveFirst()
        Me.ContractBindingSource.MoveFirst()
        Me.BeneficiariesBindingSource.MoveFirst()
        Me.RegistrationBindingSource.MoveFirst()
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        Me.PersonalBindingSource.MovePrevious()
        Me.AddressBindingSource.MovePrevious()
        Me.ContractBindingSource.MoveFirst()
        Me.BeneficiariesBindingSource.MovePrevious()
        Me.RegistrationBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Me.PersonalBindingSource.MoveNext()
        Me.AddressBindingSource.MoveNext()
        Me.ContractBindingSource.MoveNext()
        Me.BeneficiariesBindingSource.MoveNext()
        Me.RegistrationBindingSource.MoveNext()
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Me.PersonalBindingSource.MoveLast()
        Me.AddressBindingSource.MoveLast()
        Me.ContractBindingSource.MoveLast()
        Me.BeneficiariesBindingSource.MoveLast()
        Me.RegistrationBindingSource.MoveLast()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim id As Integer

        If Not txtSearch.Text = "" Then
            Try
                Me.PersonalTableAdapter.FillByFName(Me.OFWRegistrationDataSet.Personal, txtSearch.Text)
                id = Me.PersonalTableAdapter.ScalarQuery(txtSearch.Text)

                Me.AddressTableAdapter.FillById(Me.OFWRegistrationDataSet.Address, id)
                Me.BeneficiariesTableAdapter.FillById(Me.OFWRegistrationDataSet.Beneficiaries, id)
                Me.ContractTableAdapter.FillById(Me.OFWRegistrationDataSet.Contract, id)
                Me.RegistrationTableAdapter.FillById(Me.OFWRegistrationDataSet.Registration, id)
            Catch ex As Exception
                MsgBox("Failed to look up!", MsgBoxStyle.Exclamation, "Error")
                Me.filterGrid()

            End Try
        Else
            MsgBox("Please input a name.", MsgBoxStyle.Exclamation, "No name entered.")
            Me.filterGrid()
        End If
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Try
            If MessageBox.Show("Deleting this list cannot be undone. Continue?", _
                "Delete", MessageBoxButtons.OKCancel, _
                MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                Me.PersonalBindingSource.RemoveCurrent()
                Me.AddressBindingSource.RemoveCurrent()
                Me.ContractBindingSource.RemoveCurrent()
                Me.BeneficiariesBindingSource.RemoveCurrent()
                Me.RegistrationBindingSource.RemoveCurrent()
                Me.TableAdapterManager.UpdateAll(Me.OFWRegistrationDataSet)
                Me.filterGrid()
            End If
        Catch ex As Exception
            MsgBox("Cannot be removed. No current rows found.", MsgBoxStyle.Exclamation, "Failed")
        End Try

        Me.filterGrid()
    End Sub
    Private Sub PersonalDataGridView_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PersonalDataGridView.SelectionChanged
        PersonalDataGridView.ClearSelection()
    End Sub
End Class
