Public Class vIDM_JSON

    Public Class Access
        Public Property access_token() As String

    End Class

    Public Class vIDM_Apps
        Public Property items() As List(Of vidm_items)
        Public Property _links() As vidm_link


    End Class

    Public Class vidm_link

        Public Property self As vIDM_href



    End Class

    Public Class vidm_href

        Public Property href As String

    End Class

    Public Class idm_weblink

        Public Property uuid() As String

    End Class


    Public Class idm_entitle
        Public Property operations() As List(Of idm_operations)

    End Class

    Public Class idm_operations
        Public Property requestPayload() As idm_request_payload
        Public Property status() As idm_status
    End Class


    Public Class idm_request_payload

        Public Property catologItemID() As String

    End Class


    Public Class idm_status

        Public Property code() As String
        Public Property description() As String

    End Class

    Public Class vidm_items

        Public Property name() As String
        Public Property description() As String
        Public Property uuid() As String


    End Class

    Public Class vidm_user

        Public Property totalResults() As String
        Public Property Resources() As List(Of vidm_resources)


    End Class

    Public Class vidm_resources

        Public Property id() As String
        Public Property userName() As String

    End Class



End Class
