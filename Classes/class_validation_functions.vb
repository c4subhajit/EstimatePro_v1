Imports System.Data
Imports System.Data.SqlClient

Public Class class_validation_functions
    Dim dr As SqlDataReader
    Dim con_cls As New class_connect_string

    Public a, c As String
    Public b, e As Control
    Public d As Date
    Public charecter As Char
    Public ascii As Integer
    Public decimal_count, digit_after_decimal, digit_before_decimal As Integer
    Private acctype As String
    Public err_code As Integer

    '==================================================================================
    '==================================================================================
    '                  VALIDATION FUNCTIONS FOR THE POND ESTIMATE
    '==================================================================================
    '==================================================================================

    ' REFERENCE NUMBER AND REFERENCE NUMBER EXIST VALIDATION
    Public Sub txt_refNo_validate(ByVal a, ByRef b)
        If Not a = "" Then
            err_code = 0

            If Not Len(a) <= 50 Then
                err_code = 1
                MsgBox("Reference number limitation within 50 charecters", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If

            con_cls.connect()

            If Not a = "" Then
                Try
                    con_cls.cmd.CommandText = "select * from Estimate_pond where (refNo = '" & Trim(a) & "')"
                    dr = con_cls.cmd.ExecuteReader
                    If dr.HasRows Then
                        MsgBox("Reference number already exists.", MsgBoxStyle.OkOnly, "Validation error")
                        b.Clear()
                        b.Focus()
                        dr.Close()
                        Exit Sub
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Validation reference number exception info")
                End Try
                con_cls.cn.Close()
                dr.Close()
            End If
        End If
    End Sub

    'DISTANCE VALIDATION
    Public Sub distance_validate(ByVal a, ByRef b)
        If Not a = "" Then
            err_code = 0
            decimal_count = 0
            digit_after_decimal = 0
            For i = 1 To Len(a)
                charecter = GetChar(a, i)
                ascii = Asc(charecter)
                If Not ((ascii >= 48 And ascii <= 57) Or ascii = 46) Then
                    err_code = 1
                    MsgBox("Special charecter(s)/ Alphanumeric(s) not allowed", MsgBoxStyle.OkOnly, "Validation error")
                    b.Focus()
                    Exit Sub
                End If
                If ascii = 46 Then
                    decimal_count += 1
                End If
                If decimal_count > 0 Then
                    digit_after_decimal += 1
                End If
            Next
            If decimal_count > 1 Then
                err_code = 1
                MsgBox("Only one decimal point expected", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
            If digit_after_decimal > 3 Then
                err_code = 1
                MsgBox("Only two digits allowed after decimal point", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
            If Not Len(a) <= 18 Then
                err_code = 1
                MsgBox("Field value limitation within 18 charecter including decimal point", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
        End If
    End Sub

    'SLOPE VALIDATION
    Public Sub slope_validate(ByVal a, ByRef b)
        If Not a = "" Then
            err_code = 0
            decimal_count = 0
            digit_after_decimal = 0
            For i = 1 To Len(a)
                charecter = GetChar(a, i)
                ascii = Asc(charecter)
                If Not ((ascii >= 48 And ascii <= 57) Or ascii = 46) Then
                    err_code = 1
                    MsgBox("Special charecter(s)/ Alphanumeric(s) not allowed", MsgBoxStyle.OkOnly, "Validation error")
                    b.Focus()
                    Exit Sub
                End If
                If ascii = 46 Then
                    decimal_count += 1
                End If
                If decimal_count > 0 Then
                    digit_after_decimal += 1
                End If
            Next
            If decimal_count > 1 Then
                err_code = 1
                MsgBox("Only one decimal point expected", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
            If digit_after_decimal > 3 Then
                err_code = 1
                MsgBox("Only two digits allowed after decimal point", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
            If Not Len(a) <= 5 Then
                err_code = 1
                MsgBox("Field value limitation within 5 charecter including decimal point", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
            If CDbl(a) > 90.0 Then
                err_code = 1
                MsgBox("Field value cannot exceed 90.00%", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
        End If
    End Sub

    'PERPENDICULAR AND BASE VALIDATION
    Public Sub perpbase_validate(ByVal a, ByRef b)
        If Not a = "" Then
            err_code = 0
            decimal_count = 0
            digit_after_decimal = 0
            For i = 1 To Len(a)
                charecter = GetChar(a, i)
                ascii = Asc(charecter)
                If Not ((ascii >= 48 And ascii <= 57) Or ascii = 46) Then
                    err_code = 1
                    MsgBox("Special charecter(s)/ Alphanumeric(s) not allowed", MsgBoxStyle.OkOnly, "Validation error")
                    b.clear()
                    b.Focus()
                    Exit Sub
                End If
                If ascii = 46 Then
                    decimal_count += 1
                End If
                If decimal_count > 0 Then
                    digit_after_decimal += 1
                End If
            Next
            If decimal_count > 1 Then
                err_code = 1
                MsgBox("Only one decimal point expected", MsgBoxStyle.OkOnly, "Validation error")
                b.clear()
                b.Focus()
                Exit Sub
            End If
            If digit_after_decimal > 3 Then
                err_code = 1
                MsgBox("Only two digits allowed after decimal point", MsgBoxStyle.OkOnly, "Validation error")
                b.clear()
                b.Focus()
                Exit Sub
            End If
            If Not Len(a) <= 6 Then
                err_code = 1
                MsgBox("Field value limitation within 6 charecter including decimal point", MsgBoxStyle.OkOnly, "Validation error")
                b.clear()
                b.Focus()
                Exit Sub
            End If
        End If
    End Sub

    ' ESTIMATE DATE VALIDATION
    Public Sub date_validate(ByVal a, ByVal d, ByRef b)
        If a = "" Then
            err_code = 0
            'Dim current_date As Date
            'current_date = System.DateTime.Today
            'If d < current_date Then
            '    err_code = 1
            '    MsgBox("Please check the date, earlier date not allowed", MsgBoxStyle.OkOnly, "Validation error")
            '    b.Focus()
            '    Exit Sub
            'End If
            MsgBox("Please enter date.", MsgBoxStyle.OkOnly, "Validation error")
            'b.Focus()
            Exit Sub
        End If
    End Sub

    'DISTANCE UNIT VALIDATION
    Public Sub distUnit_validate(ByVal a, ByRef b)
        If Not a = "" Then
            err_code = 0
            If (a <> "Metre" And a <> "Foot") Then
                err_code = 1
                MsgBox("Please check the unit.", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
        End If
    End Sub

    'NAME OF PERSON VALIDATION
    Public Sub personName_validate(ByVal a, ByRef b)
        If Not a = "" Then
            err_code = 0
            If Not Len(a) <= 250 Then
                err_code = 1
                MsgBox("Person name limitation within 250 charecters", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
        End If
    End Sub

    'NAME AND LOCATION OF WORK VALIDATION
    Public Sub work_validate(ByVal a, ByRef b)
        If Not a = "" Then
            err_code = 0
            If Not Len(a) <= 250 Then
                err_code = 1
                MsgBox("Work name/location limitation within 250 charecters", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
        End If
    End Sub

    'PROGRAM NAME OF WORK VALIDATION
    Public Sub prog_validate(ByVal a, ByRef b)
        If Not a = "" Then
            err_code = 0
            If Not Len(a) <= 250 Then
                err_code = 1
                MsgBox("Program name limitation within 250 charecters", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
        End If
    End Sub

    'DURATION OF WORK VALIDATION
    Public Sub durWork_validate(ByVal a, ByRef b)
        If Not a = "" Then
            err_code = 0
            If Not Len(a) <= 100 Then
                err_code = 1
                MsgBox("Duration of work limitation within 100 charecters digits", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
        End If
    End Sub

    'FINANCIAL YEAR VALIDATION
    Public Sub finYear_validate(ByVal a, ByRef b)
        If Not a = "" Then
            err_code = 0
            If Not Len(a) <= 100 Then
                err_code = 1
                MsgBox("Financial year charecter limitation within 100.", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
        End If
    End Sub


    '==================================================================================
    '==================================================================================
    '                    VALIDATION FUNCTIONS FOR THE RATE FORM
    '==================================================================================
    '==================================================================================

    Public Sub typeWork_validate(ByRef b)
        err_code = 0
        If b.SelectedItem = "" Then
            err_code = 1
            MsgBox("Please select type of work.", MsgBoxStyle.OkOnly, "Validation error")
            b.Focus()
            Exit Sub
        End If
    End Sub

    Public Sub actDesc_validate(ByVal a, ByRef b, ByVal c)
        If Not a = "" Then
            Dim temp As String
            temp = Trim(a)
            b.Text = temp
            err_code = 0

            If Len(a) > 32766 Then
                err_code = 1
                MsgBox("Activity Description exceeds the maximum charecter limitation", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If

            If c = "New Rate" Then
                Try
                    con_cls.connect()
                    con_cls.cmd.CommandText = "SELECT * FROM Estimate_RateData WHERE (descActivity = '" & a & "')"
                    dr = con_cls.cmd.ExecuteReader
                    If dr.HasRows Then
                        err_code = 1
                        MsgBox("Activity Description already exists", MsgBoxStyle.OkOnly, "Validation error")
                        b.Clear()
                        dr.Close()
                        con_cls.cn.Close()
                        b.Focus()
                        Exit Sub
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Validation Activity Description exception info")
                End Try
                dr.Close()
                con_cls.cn.Close()
            End If
        End If
    End Sub

    Public Sub unit_validate(ByVal a, ByRef b)
        If Not a = "" Then
            err_code = 0
            If Len(a) > 49 Then
                err_code = 1
                MsgBox("Unit field exceeds the maximum charecter limitation", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Public Sub labour_validate(ByVal a, ByRef b)
        If Not a = "" Then
            err_code = 0
            If Len(a) > 32766 Then
                err_code = 1
                MsgBox("Labour field exceeds the maximum charecter limitation", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Public Sub rate_validate(ByVal a, ByRef b)
        If Not a = "" Then
            err_code = 0
            decimal_count = 0
            digit_after_decimal = 0
            digit_before_decimal = 0
            For i = 1 To Len(a)
                charecter = GetChar(a, i)
                ascii = Asc(charecter)
                If Not ((ascii >= 48 And ascii <= 57) Or ascii = 46) Then
                    err_code = 1
                    MsgBox("Special charecter(s)/ Alphanumeric(s) not allowed", MsgBoxStyle.OkOnly, "Validation error")
                    b.Focus()
                    Exit Sub
                End If
                If ascii = 46 Then
                    decimal_count += 1
                End If
                If decimal_count > 0 Then
                    digit_after_decimal += 1
                End If
                If decimal_count = 0 Then
                    digit_before_decimal += 1
                End If
            Next
            If decimal_count > 1 Then
                err_code = 1
                MsgBox("Only one decimal point expected", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
            If digit_after_decimal > 5 Then
                err_code = 1
                MsgBox("Only four digits allowed after decimal point", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
            If digit_before_decimal > 4 Then
                err_code = 1
                MsgBox("Only four digits allowed before decimal point", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
            If Not Len(a) <= 9 Then
                err_code = 1
                MsgBox("Field value limitation within 9 charecter including decimal point", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Public Sub qty_validate(ByVal a, ByRef b)
        If Not a = "" Then
            err_code = 0
            decimal_count = 0
            digit_after_decimal = 0
            For i = 1 To Len(a)
                charecter = GetChar(a, i)
                ascii = Asc(charecter)
                If Not ((ascii >= 48 And ascii <= 57) Or ascii = 46) Then
                    err_code = 1
                    MsgBox("Special charecter(s)/ Alphanumeric(s) not allowed", MsgBoxStyle.OkOnly, "Validation error")
                    b.Focus()
                    Exit Sub
                End If
                If ascii = 46 Then
                    decimal_count += 1
                End If
                If decimal_count > 0 Then
                    digit_after_decimal += 1
                End If
                If decimal_count = 0 Then
                    digit_before_decimal += 1
                End If
            Next
            If decimal_count > 1 Then
                err_code = 1
                MsgBox("Only one decimal point expected", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
            If digit_after_decimal > 5 Then
                err_code = 1
                MsgBox("Only four digits allowed after decimal point", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
            If Not Len(a) <= 20 Then
                err_code = 1
                MsgBox("Field value limitation is 2o charecters including decimal point.", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Public Sub material_validate(ByVal a, ByRef b)
        If Not a = "" Then
            err_code = 0
            If Len(a) > 32766 Then
                err_code = 1
                MsgBox("Material field exceeds the maximum charecter limitation", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
        End If
    End Sub

End Class
