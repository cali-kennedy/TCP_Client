'Client Side
'This code is for a simple TCP client application in Visual Basic .NET.
'It allows the user to connect to a TCP server running on a specified IP address and port.
'Once connected, the client can send data to the server by typing in TextBox1 and clicking
'Button2. Any data received from the server is displayed in TextBox2.
'The Timer1 is used to continuously check for incoming data from the server.
Imports System.Net

Public Class Form1
    ' TCPClientz to manage TCP connections
    Dim TCPClientz As Sockets.TcpClient
    ' TCPClientStream to manage the network stream for data exchange
    Dim TCPClientStream As Sockets.NetworkStream

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Create a new TCP client and connect to port 1000
        TCPClientz = New Sockets.TcpClient(TextBox3.Text, 1000)
        ' Enable the timer to start checking for incoming data
        Timer1.Enabled = True
        ' Get the network stream associated with the TCP client
        TCPClientStream = TCPClientz.GetStream()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' Convert the text from TextBox1 to ASCII bytes
        Dim sendbytes() As Byte = System.Text.Encoding.ASCII.GetBytes(TextBox1.Text)
        ' Send the ASCII bytes through the TCP client's socket
        TCPClientz.Client.Send(sendbytes)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        ' Check if there is data available to be read from the network stream
        If TCPClientStream.DataAvailable = True Then
            ' Create an array to store received data, sized to the TCP client's receive buffer size
            Dim rcvbytes(TCPClientz.ReceiveBufferSize) As Byte
            ' Read data from the network stream into the rcvbytes array
            TCPClientStream.Read(rcvbytes, 0, CInt(TCPClientz.ReceiveBufferSize))
            ' Convert received bytes to ASCII string and display in TextBox2
            TextBox2.Text = System.Text.Encoding.ASCII.GetString(rcvbytes)
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class

'Server IP locally 192.168.0.106
'Server IP Globally is 123.456.789.012 wwww.whatismyip.com
'server router > port forward 1000 to 192.168.0.106