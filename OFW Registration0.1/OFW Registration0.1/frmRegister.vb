Imports System.Data.OleDb

Public Class frmRegister
    Dim id As Integer
    Dim day As New Date
    Dim cmd As New OleDbCommand
    Dim con As New OleDbConnection
    Dim adt As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim personalQuery
    Dim addressQuery
    Dim contractQuery
    Dim beneficiaryQuery
    Dim registerQuery
    Dim lastId
    Dim cs

    Private Sub frmRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim adlaw = Date.Now()
        Me.WindowState = FormWindowState.Maximized
        lblRdate.Text = adlaw
        day = adlaw
        Me.disableForm()


        personalQuery = "INSERT INTO Personal" _
                        & "(p_fname, p_lname, p_suffix, p_mname, p_edu, p_course, p_contact, p_email, " _
                        & "p_passport, p_bdate, p_sex, p_religion, p_civil)" _
                        & "VALUES " _
                        & "( @P_txtFname , @P_txtLName, @P_txtSuffix, @P_txtMName, " _
                        & " @P_txtEdu, @P_txtCourse, @P_txtContact, @P_txtEmail, @P_txtPassport, " _
                        & " @P_dtBdate, @P_txtSex, @P_txtReligion, @P_txtCivil )"

        addressQuery = "INSERT INTO Address " _
                            & "(p_id, a_houseNum, a_lotNum, a_blockNum, a_phaseNum, a_street, a_sub, a_brgy, a_city, " _
                            & "a_prov, a_zipcode) " _
                            & "VALUES " _
                            & "(@A_txtId, @A_txtAddress, @A_txtLot, @A_txtBlock, @A_txtPhase, " _
                            & " @A_txtStreet, @A_txtSub, @A_txtBrgy, @A_txtCity, @A_txtProv, @A_txtZip)"

        contractQuery = "INSERT INTO Contract " _
                            & "(p_id, c_name, c_address, c_telephone, c_country, c_position, c_salary, c_contract, c_agency) " _
                            & "VALUES (@C_txtId, @C_txtName, @C_txtAddress, @C_txtTel, @C_txtCountry, @C_txtPosition, @C_txtSalary, @C_txtContract, @C_txtAgency)"

        beneficiaryQuery = "INSERT INTO Beneficiaries " _
                            & "(p_id, b_name1, b_relationship1, b_bdate1, b_address1, b_contact1, b_email1, b_name2, b_relationship2, b_bdate2, b_address2, b_contact2, b_email2, b_name3, b_relationship3, b_bdate3, b_address3, b_contact3, b_email3) " _
                            & "VALUES (@B_txtId, @B_txtNameA, @B_txtRelationshipA, @B_dtBdateA, @B_txtAddressA, @B_txtContactA, @B_txtEmailA, @B_txtNameB, @B_txtRelationshipB, @B_dtBdateB, @B_txtAddressB, @B_txtContactB, @B_txtEmailB, @B_txtNameC, @B_txtRelationshipC, @B_dtBdateC, @B_txtAddressC, @B_txtContactC, @B_txtEmailC )"

        registerQuery = "INSERT INTO Registration" _
                            & "(p_id, r_date)" _
                            & "VALUES " _
                            & "( @R_txtId, @lblRdate)"

        lastId = "SELECT @@IDENTITY"

        cs = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|OFWRegistration.mdb"

        btnSave.Enabled = False
        btnSave.BackColor = Color.Gray
        btnAdd.Enabled = True
        btnAdd.BackColor = Color.Crimson
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.clearForm()
        Me.Hide()
        frmMain.Show()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Me.enableForm()
        btnSave.Enabled = True
        btnSave.BackColor = Color.IndianRed
        btnAdd.Enabled = False
        btnAdd.BackColor = Color.Gray
    End Sub

    Private Sub enableForm()
        'info
        P_txtCivil.Enabled = True
        P_txtContact.Enabled = True
        P_txtPassport.Enabled = True
        P_txtCourse.Enabled = True
        P_txtEdu.Enabled = True
        P_txtEmail.Enabled = True
        P_txtFname.Enabled = True
        P_txtLName.Enabled = True
        P_txtMName.Enabled = True
        P_txtReligion.Enabled = True
        P_txtSex.Enabled = True
        P_txtSuffix.Enabled = True
        P_dtBdate.Enabled = True


        'address
        A_txtAddress.Enabled = True
        A_txtBlock.Enabled = True
        A_txtBrgy.Enabled = True
        A_txtCity.Enabled = True
        A_txtId.Enabled = True
        A_txtLot.Enabled = True
        A_txtPhase.Enabled = True
        A_txtProv.Enabled = True
        A_txtStreet.Enabled = True
        A_txtSub.Enabled = True
        A_txtZip.Enabled = True

        'contract
        C_txtAddress.Enabled = True
        C_txtAgency.Enabled = True
        C_txtContract.Enabled = True
        C_txtCountry.Enabled = True
        C_txtId.Enabled = True
        C_txtName.Enabled = True
        C_txtPosition.Enabled = True
        C_txtSalary.Enabled = True
        C_txtTel.Enabled = True

        'beneficiaries
        B_txtAddressA.Enabled = True
        B_txtAddressB.Enabled = True
        B_txtAddressC.Enabled = True
        B_txtContactA.Enabled = True
        B_txtContactB.Enabled = True
        B_txtContactC.Enabled = True
        B_txtEmailA.Enabled = True
        B_txtEmailB.Enabled = True
        B_txtEmailC.Enabled = True
        B_txtId.Enabled = True
        B_txtNameA.Enabled = True
        B_txtNameB.Enabled = True
        B_txtNameC.Enabled = True
        B_txtRelationshipA.Enabled = True
        B_txtRelationshipB.Enabled = True
        B_txtRelationshipC.Enabled = True
        B_dtBdateA.Enabled = True
        B_dtBdateB.Enabled = True
        B_dtBdateC.Enabled = True
    End Sub

    Private Sub disableForm()
        'info
        P_txtCivil.Enabled = False
        P_txtContact.Enabled = False
        P_txtPassport.Enabled = False
        P_txtCourse.Enabled = False
        P_txtEdu.Enabled = False
        P_txtEmail.Enabled = False
        P_txtFname.Enabled = False
        P_txtLName.Enabled = False
        P_txtMName.Enabled = False
        P_txtReligion.Enabled = False
        P_txtSex.Enabled = False
        P_txtSuffix.Enabled = False
        P_dtBdate.Enabled = False


        'address
        A_txtAddress.Enabled = False
        A_txtBlock.Enabled = False
        A_txtBrgy.Enabled = False
        A_txtCity.Enabled = False
        A_txtId.Enabled = False
        A_txtLot.Enabled = False
        A_txtPhase.Enabled = False
        A_txtProv.Enabled = False
        A_txtStreet.Enabled = False
        A_txtSub.Enabled = False
        A_txtZip.Enabled = False

        'contract
        C_txtAddress.Enabled = False
        C_txtAgency.Enabled = False
        C_txtContract.Enabled = False
        C_txtCountry.Enabled = False
        C_txtId.Enabled = False
        C_txtName.Enabled = False
        C_txtPosition.Enabled = False
        C_txtSalary.Enabled = False
        C_txtTel.Enabled = False

        'beneficiaries
        B_txtAddressA.Enabled = False
        B_txtAddressB.Enabled = False
        B_txtAddressC.Enabled = False
        B_txtContactA.Enabled = False
        B_txtContactB.Enabled = False
        B_txtContactC.Enabled = False
        B_txtEmailA.Enabled = False
        B_txtEmailB.Enabled = False
        B_txtEmailC.Enabled = False
        B_txtId.Enabled = False
        B_txtNameA.Enabled = False
        B_txtNameB.Enabled = False
        B_txtNameC.Enabled = False
        B_txtRelationshipA.Enabled = False
        B_txtRelationshipB.Enabled = False
        B_txtRelationshipC.Enabled = False
        B_dtBdateA.Enabled = False
        B_dtBdateB.Enabled = False
        B_dtBdateC.Enabled = False
    End Sub

    Private Sub clearForm()
        'info
        P_txtCivil.Clear()
        P_txtContact.Clear()
        P_txtPassport.Clear()
        P_txtCourse.Clear()
        P_txtEdu.Clear()
        P_txtEmail.Clear()
        P_txtFname.Clear()
        P_txtLName.Clear()
        P_txtMName.Clear()
        P_txtReligion.Clear()
        P_txtSex.Clear()
        P_txtSuffix.Clear()
        P_dtBdate.Value = Date.Now()


        'address
        A_txtAddress.Clear()
        A_txtBlock.Clear()
        A_txtBrgy.Clear()
        A_txtCity.Clear()
        A_txtId.Clear()
        A_txtLot.Clear()
        A_txtPhase.Clear()
        A_txtProv.Clear()
        A_txtStreet.Clear()
        A_txtSub.Clear()
        A_txtZip.Clear()

        'contract
        C_txtAddress.Clear()
        C_txtAgency.Clear()
        C_txtContract.Clear()
        C_txtCountry.Clear()
        C_txtId.Clear()
        C_txtName.Clear()
        C_txtPosition.Clear()
        C_txtSalary.Clear()
        C_txtTel.Clear()

        'beneficiaries
        B_txtAddressA.Clear()
        B_txtAddressB.Clear()
        B_txtAddressC.Clear()
        B_txtContactA.Clear()
        B_txtContactB.Clear()
        B_txtContactC.Clear()
        B_txtEmailA.Clear()
        B_txtEmailB.Clear()
        B_txtEmailC.Clear()
        B_txtId.Clear()
        B_txtNameA.Clear()
        B_txtNameB.Clear()
        B_txtNameC.Clear()
        B_txtRelationshipA.Clear()
        B_txtRelationshipB.Clear()
        B_txtRelationshipC.Clear()
        B_dtBdateA.Value = Date.Today
        B_dtBdateB.Value = Date.Today
        B_dtBdateC.Value = Date.Today

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'setup the connection
        Dim idNum
        Try
            Using con As New OleDbConnection(cs)
                Using cmd As New OleDbCommand(personalQuery, con)
                    cmd.Parameters.AddWithValue("@P_txtFNam", P_txtFname.Text)
                    cmd.Parameters.AddWithValue("@P_txtLName", P_txtLName.Text)
                    cmd.Parameters.AddWithValue("@P_txtSuffix", P_txtSuffix.Text)
                    cmd.Parameters.AddWithValue("@P_txtMName", P_txtMName.Text)
                    cmd.Parameters.AddWithValue("@P_txtEdu", P_txtEdu.Text)
                    cmd.Parameters.AddWithValue("@P_txtCourse", P_txtCourse.Text)
                    cmd.Parameters.AddWithValue("@P_txtContact", P_txtContact.Text)
                    cmd.Parameters.AddWithValue("@P_txtEmail", P_txtEmail.Text)
                    cmd.Parameters.AddWithValue("@P_txtPassport", P_txtPassport.Text)
                    cmd.Parameters.AddWithValue("@P_dtBdate", P_dtBdate.Text)
                    cmd.Parameters.AddWithValue("@P_txtSex", P_txtSex.Text)
                    cmd.Parameters.AddWithValue("@P_txtReligion", P_txtReligion.Text)
                    cmd.Parameters.AddWithValue("@P_txtCivil", P_txtCivil.Text)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = lastId
                    id = cmd.ExecuteScalar()

                    idNum = Integer.Parse(id)

                    A_txtId.Text = idNum
                    B_txtId.Text = idNum
                    C_txtId.Text = idNum
                    R_txtId.Text = idNum
                    con.Close()
                End Using
                Using cmd1 As New OleDbCommand(addressQuery, con)
                    cmd1.Parameters.AddWithValue("@A_txtId", A_txtId.Text)
                    cmd1.Parameters.AddWithValue("@A_txtAddress", A_txtAddress.Text)
                    cmd1.Parameters.AddWithValue("@A_txtLot", A_txtLot.Text)
                    cmd1.Parameters.AddWithValue("@A_txtBlock", A_txtBlock.Text)
                    cmd1.Parameters.AddWithValue("@A_txtPhase", A_txtPhase.Text)
                    cmd1.Parameters.AddWithValue("@A_txtStreet", A_txtStreet.Text)
                    cmd1.Parameters.AddWithValue("@A_txtSub", A_txtSub.Text)
                    cmd1.Parameters.AddWithValue("@A_txtBrgy", A_txtBrgy.Text)
                    cmd1.Parameters.AddWithValue("@A_txtCity", A_txtCity.Text)
                    cmd1.Parameters.AddWithValue("@A_txtProv", A_txtProv.Text)
                    cmd1.Parameters.AddWithValue("@A_txtZip", A_txtZip.Text)
                    con.Open()
                    cmd1.ExecuteNonQuery()
                    con.Close()

                End Using
                Using cmd2 As New OleDbCommand(contractQuery, con)
                    cmd2.Parameters.AddWithValue("@C_txtId", C_txtId.Text)
                    cmd2.Parameters.AddWithValue("@C_txtName", C_txtName.Text)
                    cmd2.Parameters.AddWithValue("@C_txtAddress", C_txtAddress.Text)
                    cmd2.Parameters.AddWithValue("@C_txtTel", C_txtTel.Text)
                    cmd2.Parameters.AddWithValue("@C_txtCountry", C_txtCountry.Text)
                    cmd2.Parameters.AddWithValue("@C_txtPosition", C_txtPosition.Text)
                    cmd2.Parameters.AddWithValue("@C_txtSalary", C_txtSalary.Text)
                    cmd2.Parameters.AddWithValue("@C_txtContract", C_txtContract.Text)
                    cmd2.Parameters.AddWithValue("@C_txtAgency", C_txtAgency.Text)
                    con.Open()
                    cmd2.ExecuteNonQuery()
                    con.Close()

                End Using
                Using cmd3 As New OleDbCommand(beneficiaryQuery, con)
                    cmd3.Parameters.AddWithValue("@B_txtId", B_txtId.Text)
                    cmd3.Parameters.AddWithValue("@B_txtNameA", B_txtNameA.Text)
                    cmd3.Parameters.AddWithValue("@B_txtRelationshipA", B_txtRelationshipA.Text)
                    cmd3.Parameters.AddWithValue("@B_dtBdateA", B_dtBdateA.Text)
                    cmd3.Parameters.AddWithValue("@B_txtAddressA", B_txtAddressA.Text)
                    cmd3.Parameters.AddWithValue("@B_txtContactA", B_txtContactA.Text)
                    cmd3.Parameters.AddWithValue("@B_txtEmailA", B_txtEmailA.Text)
                    cmd3.Parameters.AddWithValue("@B_txtNameB", B_txtNameB.Text)
                    cmd3.Parameters.AddWithValue("@B_txtRelationshipB", B_txtRelationshipB.Text)
                    cmd3.Parameters.AddWithValue("@B_dtBdateB", B_dtBdateB.Text)
                    cmd3.Parameters.AddWithValue("@B_txtAddressB", B_txtAddressB.Text)
                    cmd3.Parameters.AddWithValue("@B_txtContactB", B_txtContactB.Text)
                    cmd3.Parameters.AddWithValue("@B_txtEmailB", B_txtEmailB.Text)
                    cmd3.Parameters.AddWithValue("@B_txtNameC", B_txtNameC.Text)
                    cmd3.Parameters.AddWithValue("@B_txtRelationshipC", B_txtRelationshipC.Text)
                    cmd3.Parameters.AddWithValue("@B_dtBdateC", B_dtBdateC.Text)
                    cmd3.Parameters.AddWithValue("@B_txtAddressC", B_txtAddressC.Text)
                    cmd3.Parameters.AddWithValue("@B_txtContactC", B_txtContactC.Text)
                    cmd3.Parameters.AddWithValue("@B_txtEmailC ", B_txtEmailC.Text)
                    con.Open()
                    cmd3.ExecuteNonQuery()
                    con.Close()

                End Using
                Using cmd4 As New OleDbCommand(registerQuery, con)
                    cmd4.Parameters.AddWithValue("@R_txtId", R_txtId.Text)
                    cmd4.Parameters.AddWithValue("@lblRdate", lblRdate.Text)
                    con.Open()
                    cmd4.ExecuteNonQuery()
                    con.Close()

                End Using
            End Using
            MessageBox.Show("Successfully save!", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Failed to save!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.disableForm()
        Me.clearForm()
        btnSave.Enabled = False
        btnSave.BackColor = Color.Gray
        btnAdd.Enabled = True
        btnAdd.BackColor = Color.Crimson
    End Sub
End Class