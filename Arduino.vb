Public Class Arduino
    Private Shared port As New System.IO.Ports.SerialPort

    Private Shared _Comport As String
    Public Shared Property Comport() As String
        Get
            Return _Comport
        End Get
        Set(ByVal value As String)
            _Comport = value
        End Set
    End Property
    Public Sub New()

    End Sub

    Public Shared Sub SendData(ByVal value As Object)
        'Connect()
        Try

            port.Write(value)
        Catch ex As Exception
            MsgBox("No arduino detected on " & Comport & ".")
            Throw ex
        End Try

    End Sub

    Public Shared Sub Close()
        Try

            port.Close()
        Catch ex As Exception

        End Try

    End Sub
    Public Shared Sub Connect()
        If port.IsOpen Then
            Debug.WriteLine("Closing...")
            port.Close()
            Debug.WriteLine("Closed!")
        End If
        Debug.WriteLine("Connecting...")
        Try
            With port
                .PortName = _Comport
                .BaudRate = 9600
                .Parity = IO.Ports.Parity.None
                .DataBits = 8
                .StopBits = IO.Ports.StopBits.One

            End With
            port.Open()
            Debug.WriteLine("waiting")

        Catch ex As Exception
            Console.WriteLine("Failed to connect: " & ex.Message)
        End Try
    End Sub

End Class