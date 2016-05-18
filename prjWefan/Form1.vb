Imports System.IO 'Mewnforio llyfrgell i alluogi darllen ac ysgrifennu at ffeil
Public Class Form1

    Private Sub btnArbed_Click(sender As Object, e As EventArgs) Handles btnArbed.Click
        Dim objStreamWriter As StreamWriter 'galluogi ysgrifennu at ffeil
        'Rhestr o dagiau i ychwanegu at y ffeil
        Dim Tagiau() As String = {"<html>", "<head>", "</head>", "<body>", "</body>", "</html>"}
        Dim Tag As String

        'creu sianel newydd i ysgrifennu at y ffeil data.txt
        objStreamWriter = New StreamWriter("templed.html")
        MsgBox(My.Computer.FileSystem.CurrentDirectory)

        'Ar gyfer pob eitem yn y rhestr o dagiau
        For Each Tag In Tagiau
            'Ysgrifennu'r data allan i'r ffel
            objStreamWriter.WriteLine(Tag)
        Next

        'Cau'r sianel [ffeil]
        objStreamWriter.Close()

    End Sub

    Private Sub btnYchwaneguTeitlau_Click(sender As Object, e As EventArgs) Handles btnYchwaneguTeitlau.Click
        'Ychwanegu teitlau i'r rhestr
        Dim Teitl As String
        'darllen y teitl
        Teitl = cmbTeitlTudalennau.Text
        'Ychwanegu at y rhestr
        cmbTeitlTudalennau.Items.Add(Teitl)
        'Clurio'r blwch testun
        cmbTeitlTudalennau.Text = ""
    End Sub
End Class
