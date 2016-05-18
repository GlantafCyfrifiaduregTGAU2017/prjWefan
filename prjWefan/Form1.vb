Imports System.IO 'Mewnforio llyfrgell i alluogi darllen ac ysgrifennu at ffeil
Public Class Form1
    'Newidynnau EANG

    'Rhestr o dudalennau we i greu 
    Dim TudalenWe As New ArrayList()

    Private Sub btnArbed_Click(sender As Object, e As EventArgs) Handles btnArbed.Click
        Dim objStreamWriter As StreamWriter 'galluogi ysgrifennu at ffeil
        'Rhestr o dagiau i ychwanegu at y ffeil
        Dim Tagiau() As String = {"<html>", "<head>", "</head>", "<body>", "</body>", "</html>"}
        Dim Tag As String

        'Creu tudalen ar gyfer pob dynodwr yn y rhestr cmbTeitlauTudalennau

        Dim TudalenNewydd As String
        'Ar gyfer pob tudalen yn y rhestr

        For Each TudalenNewydd In TudalenWe
            'Ychwanegu .html i'r newidyn ar gyfer dynodwr y dudalen
            TudalenNewydd = TudalenNewydd & ".html"
            MsgBox(TudalenNewydd)
            'creu sianel newydd i ysgrifennu at y ffeil data.txt
            objStreamWriter = New StreamWriter(TudalenNewydd)
            MsgBox(My.Computer.FileSystem.CurrentDirectory)

            'Ar gyfer pob eitem yn y rhestr o dagiau
            For Each Tag In Tagiau
                'Ysgrifennu'r data allan i'r ffel
                objStreamWriter.WriteLine(Tag)
            Next

            'Cau'r sianel [ffeil]
            objStreamWriter.Close()
        Next
    End Sub

    Private Sub btnYchwaneguTeitlau_Click(sender As Object, e As EventArgs) Handles btnYchwaneguTeitlau.Click
        'Ychwanegu teitlau i'r rhestr
        Dim Teitl As String
        'darllen y teitl - dileu bylchau o flaen ac ar ol y dynodwr
        Teitl = Trim(cmbTeitlTudalennau.Text)
        'Prawf dilysu presenoldeb - osgoi ychwanegu eitem gwag i'r rhestr
        If Teitl = "" Then 'dynodwr yn absennol
            MsgBox("Dynodwr y dudalen yn absennol")
        Else 'data yn bresennol
            'Ychwanegu at y rhestr
            cmbTeitlTudalennau.Items.Add(Teitl)
            'Ychwanegu Teitl at y rhestr o dudalennau i greu
            TudalenWe.Add(Teitl)
            'Clurio'r blwch testun
            cmbTeitlTudalennau.Text = ""
        End If
    End Sub
End Class
