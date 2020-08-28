<CLSCompliant(True)> _
Public Class EventLogger

    Public Sub New()
        'default constructor
    End Sub

    'Create the EventLog Source

    Public Shared Function WriteToEventLog(ByVal entry As String, Optional ByVal eventType As EventLogEntryType = EventLogEntryType.Information) As Boolean

        Dim objEventLog As New EventLog

        Try

            If Not EventLog.SourceExists("VMware IDM to Okta Service Bridge") Then

                EventLog.CreateEventSource("VMware IDM to Okta Service Bridge", "VMware IDM to Okta Service Bridge")

            Else

            End If

            'log the entry
            objEventLog.Source = "VMware IDM to Okta Service Bridge"
            objEventLog.WriteEntry(entry, eventType)

            Return True

        Catch Ex As Exception

            MsgBox(Ex.Message)

            Return False

        End Try

    End Function

End Class
