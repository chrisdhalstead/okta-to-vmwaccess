Public Class Okta_JSON

    Public Class Apps

        Public Property id() As String
        Public Property name() As String
        Public Property label() As String
        Public Property _links() As okta_links

        Public Property signOnMode As String

    End Class

    Public Class Okta_Groups

        Public Property id() As String
        Public Property type() As String
        Public Property profile() As okta_profile
        Public Property _links() As okta_links


    End Class

    Public Class Okta_Users

        Public Property id() As String
        Public Property profile() As okta_profile_user

    End Class

    Public Class okta_links

        Public Property users() As okta_href
        Public Property apps() As okta_href

        Public Property groups() As okta_href
        Public Property appLinks() As List(Of okta_href)
        Public Property logo() As List(Of okta_href)


    End Class


    Public Class okta_href
        Public Property name() As String
        Public Property href() As String

    End Class

    Public Class okta_profile

            Public Property name() As String
        Public Property description() As String
        Public Property samAccountName() As String
        Public Property groupType() As String
        Public Property dn() As String

        Public Property login() As String

    End Class

    Public Class okta_profile_user

        Public Property login() As String
        Public Property firstname() As String
        Public Property lastname() As String

    End Class


    Public Class App_Assignment

            Public Property eventId() As String
            Public Property sessionId() As String
            Public Property requestId() As String
            Public Property published() As String
            Public Property action() As Okta_Action
            Public Property actors() As List(Of Okta_Actors)
            Public Property targets() As List(Of Okta_Targets)


        End Class

        Public Class Okta_Targets

            Public Property id() As String
            Public Property displayName() As String
            Public Property login() As String
            Public Property objectType() As String

        End Class

        Public Class Okta_Actors

            Public Property id() As String
            Public Property displayName() As String
            Public Property login() As String
            Public Property objectType() As String
            Public Property ipAddress() As String

        End Class

    Public Class Okta_Action

            Public Property message() As String
            Public Property categories() As String()
            Public Property objectType() As String
            Public Property requestUri() As String

        End Class

End Class
