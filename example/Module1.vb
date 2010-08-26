
Module Module1

    Sub Main()

        Dim dev As New MobileDevice(MobileDevice.DeviceMode.Normal)

        Console.WriteLine("Device is connected: " & dev.Connect)
        Console.ReadLine()

    End Sub

End Module
