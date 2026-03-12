Imports System.Data.SqlClient

Public Class Form1

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub NewTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewTransactionToolStripMenuItem.Click
        ClearForm()
    End Sub

    Private Sub ClearFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearFormToolStripMenuItem.Click
        ClearForm()
    End Sub

    Private Sub AboutSystemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutSystemToolStripMenuItem.Click
        MessageBox.Show("Printing & Branding Shop System" & vbCrLf & vbCrLf &
                        "Version 1.0" & vbCrLf &
                        " " & vbCrLf &
                        "© 2026 ", "About System",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ClearForm()
        txtCustomerName.Clear()
        cmbServiceType.SelectedIndex = -1
        cmbUrgency.SelectedIndex = -1
        txtQuantity.Clear()
        txtReceipt.Clear()
        txtCustomerName.Focus()
    End Sub

    Private Sub cmbUrgency_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUrgency.SelectedIndexChanged

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        If String.IsNullOrWhiteSpace(txtCustomerName.Text) Then
            MessageBox.Show("Please enter customer name.", "Input Required")
            txtCustomerName.Focus()
            Exit Sub
        End If

        If cmbServiceType.SelectedIndex = -1 Then
            MessageBox.Show("Please select a service type.", "Input Required")
            Exit Sub
        End If

        If cmbUrgency.SelectedIndex = -1 Then
            MessageBox.Show("Please select urgency level.", "Input Required")
            Exit Sub
        End If

        Dim quantity As Integer
        If Not Integer.TryParse(txtQuantity.Text, quantity) OrElse quantity < 1 Then
            MessageBox.Show("Please enter a valid number of copies/units (at least 1).", "Invalid Quantity")
            txtQuantity.SelectAll()
            txtQuantity.Focus()
            Exit Sub
        End If


        Dim basePricePerUnit As Decimal = 0

        Select Case cmbServiceType.SelectedItem.ToString()
            Case "Business Cards" : basePricePerUnit = 3D
            Case "Flyers" : basePricePerUnit = 10D
            Case "Banners" : basePricePerUnit = 1200D
            Case "Stickers" : basePricePerUnit = 5.5D
            Case "T-Shirts" : basePricePerUnit = 800D
        End Select

        Dim baseCharge As Decimal = basePricePerUnit * quantity

        Dim expressSurcharge As Decimal = 0
        If cmbUrgency.SelectedItem.ToString() = "Express" Then
            expressSurcharge = baseCharge * 0.35D
        End If

        Dim discount As Decimal = 0
        If quantity >= 150 Then
            discount = baseCharge * 0.15D      ' 15% off for 150+
        ElseIf quantity >= 50 Then
            discount = baseCharge * 0.08D      ' 8% off for 50–149
        End If

        Dim setupFee As Decimal = 0
        If cmbServiceType.SelectedItem.ToString() = "Banners" OrElse
           cmbServiceType.SelectedItem.ToString() = "T-Shirts" Then
            setupFee = 1200D
        End If

        Dim totalBeforeDiscount As Decimal = baseCharge + expressSurcharge + setupFee
        Dim totalPayable As Decimal = totalBeforeDiscount - discount

        Dim receipt As New System.Text.StringBuilder()

        receipt.AppendLine("═══════════════════════════════════════════════")
        receipt.AppendLine("      Printing & Branding Shop Receipt")
        receipt.AppendLine("═══════════════════════════════════════════════")
        receipt.AppendLine("")
        receipt.AppendLine("Hello " & txtCustomerName.Text.Trim() & ",")
        receipt.AppendLine("")
        receipt.AppendLine("Service Type          :  " & cmbServiceType.SelectedItem.ToString())
        receipt.AppendLine("Urgency Level         :  " & cmbUrgency.SelectedItem.ToString())
        receipt.AppendLine("Quantity              :  " & quantity)
        receipt.AppendLine("")
        receipt.AppendLine("Base Charge           :  KES " & baseCharge.ToString("N2"))
        receipt.AppendLine("Express Surcharge     :  KES " & expressSurcharge.ToString("N2"))
        receipt.AppendLine("Setup/Design Fee      :  KES " & setupFee.ToString("N2"))
        receipt.AppendLine("----------------------------------------")
        receipt.AppendLine("Subtotal              :  KES " & totalBeforeDiscount.ToString("N2"))
        If discount > 0 Then
            receipt.AppendLine("Quantity Discount     : -KES " & discount.ToString("N2"))
        End If
        receipt.AppendLine("═══════════════════════════════════════════════")
        receipt.AppendLine("TOTAL PAYABLE         :  KES " & totalPayable.ToString("N2"))
        receipt.AppendLine("")
        receipt.AppendLine("          Thank you for choosing us!")
        receipt.AppendLine("       Come again for quality prints!")

        txtReceipt.Text = receipt.ToString()

        txtReceipt.SelectionStart = 0
        txtReceipt.ScrollToCaret()

    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtReceipt.Text) Then
            MessageBox.Show("Please calculate the receipt first.", "Nothing to save")
            Exit Sub
        End If

        ' Read values from form (you already calculated them earlier – reuse variables or read again)
        Dim customer As String = txtCustomerName.Text.Trim()
        Dim service As String = cmbServiceType.SelectedItem.ToString()
        Dim urgency As String = cmbUrgency.SelectedItem.ToString()
        Dim qty As Integer = Integer.Parse(txtQuantity.Text)

        ' Re-calculate or store from earlier variables (better to keep variables class-level or re-calc)
        ' For simplicity – let's re-calc briefly here (copy your logic or make shared variables)
        Dim baseCharge As Decimal = 0
        Select Case service
            Case "Business Cards" : baseCharge = qty * 3D
            Case "Flyers" : baseCharge = qty * 10D
            Case "Banners" : baseCharge = qty * 1200D
            Case "Stickers" : baseCharge = qty * 5.5D
            Case "T-Shirts" : baseCharge = qty * 800D
        End Select

        Dim expressExtra As Decimal = If(urgency = "Express", baseCharge * 0.35D, 0D)
        Dim setup As Decimal = If(service = "Banners" Or service = "T-Shirts", 1200D, 0D)
        Dim disc As Decimal = If(qty >= 150, baseCharge * 0.15D, If(qty >= 50, baseCharge * 0.08D, 0D))
        Dim total As Decimal = (baseCharge + expressExtra + setup) - disc

        ' ────────────────────────────────────────
        ' Save to database
        ' ────────────────────────────────────────
        Dim connStr As String = My.Settings.ConnStr   ' ← from Settings
        ' OR:  ConfigurationManager.ConnectionStrings("PrintingConn").ConnectionString   if using App.config

        Using conn As New SqlConnection(connStr)
            Try
                conn.Open()

                Dim sql As String = "INSERT INTO [dbo].[Table] (CustomerName, ServiceType, UrgencyLevel, Quantity, " &
                                "BaseCharge, ExpressSurcharge, SetupFee, Discount, TotalAmount, TransactionDate) " &
                                "VALUES (@name, @service, @urgency, @qty, @base, @extra, @setup, @disc, @total, GETDATE())"

                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@name", customer)
                    cmd.Parameters.AddWithValue("@service", service)
                    cmd.Parameters.AddWithValue("@urgency", urgency)
                    cmd.Parameters.AddWithValue("@qty", qty)
                    cmd.Parameters.AddWithValue("@base", baseCharge)
                    cmd.Parameters.AddWithValue("@extra", expressExtra)
                    cmd.Parameters.AddWithValue("@setup", setup)
                    cmd.Parameters.AddWithValue("@disc", disc)
                    cmd.Parameters.AddWithValue("@total", total)

                    Dim rows As Integer = cmd.ExecuteNonQuery()

                    If rows > 0 Then
                        MessageBox.Show("Transaction saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Save failed – no rows affected.", "Error")
                    End If
                End Using

            Catch ex As Exception
                MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class