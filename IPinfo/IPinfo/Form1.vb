Public Class Form1
    Dim HTMLCode As String
    Dim PocketLen As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AxWinsock1.RemotePort = 80
        AxWinsock1.RemoteHost = "ip-whois.net"
        AxWinsock1.Connect()
    End Sub

    Private Sub AxWinsock1_CloseEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles AxWinsock1.CloseEvent
        Me.Text = "Not Connected"
        AxWinsock1.Close()
    End Sub

    Private Sub AxWinsock1_ConnectEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles AxWinsock1.ConnectEvent
        Me.Text = "Connected"
        AxWinsock1.SendData("GET " + "/ip.php" + " HTTP/1.0" + Chr(10) + Chr(10))
    End Sub

    Private Sub AxWinsock1_DataArrival(ByVal sender As Object, ByVal e As AxMSWinsockLib.DMSWinsockControlEvents_DataArrivalEvent) Handles AxWinsock1.DataArrival
        Dim temp As String
        temp = ""
        PocketLen += AxWinsock1.BytesReceived
        AxWinsock1.GetData(temp)
        HTMLCode = HTMLCode + temp
        If PocketLen > 7000 Then IP.Text = CutIP(HTMLCode)
    End Sub
    Function CutIP(ByVal HTML As String) As String
        Dim p1, p2 As Integer
        p1 = 1
        p1 = InStr(HTML, "Ваш IP:")
        If p1 = 0 Then
            CutIP = "Не удалось получить IP"
        Else
            HTML = Mid(HTML, p1, Len(HTML) - p1)
            p2 = InStr(HTML, "</h2>")
            CutIP = Trim(Mid(HTML, 8, p2 - 8))
        End If
    End Function
End Class
