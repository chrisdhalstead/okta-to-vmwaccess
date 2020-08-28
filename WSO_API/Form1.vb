Imports System.Web
Imports System.Net
Imports System.IO
Imports System.Web.Script.Serialization
Imports System.Security.Cryptography.X509Certificates
Imports System.Net.Security
Imports System.Text
Imports Microsoft.Win32
Imports System.Xml
Imports IDM_Okta.Okta_JSON
Imports IDM_Okta.crypto
Imports System.Net.Mail
Imports System.Text.RegularExpressions
Imports IDM_Okta.EventLogger
Imports IDM_Okta.vIDM_JSON

Public Class Form1
    Public theuri As Uri
    Public cookies As New CookieContainer
    Public scerthash As String = ""
    Public atrustedcerts As New ArrayList
    Public ssessiontoken As String
    Public slastquery As String
    Public nitem As ListViewItem
    Public htoktaapps As New Hashtable
    Public htvidmapps As New Hashtable
    Public htmapping As New Hashtable
    Public aoktaevents As New ArrayList
    Public svidmcatalogitem As String
    Public svidmuser As String
    Public amonitroredokta As New ArrayList
    Public htoktatoidm As New Hashtable
    Public scurrentevent As String
    Public htoktagroups As New Hashtable
    Public igroupusers As String = ""
    Public sweblinkname As String = ""
    Public sweblinkdesc As String = ""
    Public sweblinkurl As String = ""
    Public sweblinkicon As String = ""
    Public htoktausers As New Hashtable
    Public screatedIDMid As String = ""
    Public ssamlaudience As String = ""
    Public ssamlrecepient As String = ""
    Public ssamlcert As String = ""
    Public sthisserver As String = System.Environment.MachineName



    Sub getdata_okta(uri As Uri, contentType As String, method As String, ByVal thequery As String)

        Dim res As String = ""

        Try

            Dim req As HttpWebRequest = WebRequest.Create(uri)

            req.ContentType = contentType
            req.Method = method
            req.CookieContainer = cookies
            req.Accept = "application/json"
            req.Headers.Add("Authorization: SSWS " & txtoktahash.Text)
            req.ServerCertificateValidationCallback = New RemoteCertificateValidationCallback(AddressOf ServerCertificateValidationCallback)
            Dim jsonresponse = req.GetResponse().GetResponseStream()
            Dim reader As New StreamReader(jsonresponse)
            res = reader.ReadToEnd()

            reader.Close()

            Dim jss As New JavaScriptSerializer()
            jss.MaxJsonLength = "50000000"

            Select Case thequery

                Case "Get_Groups"

                    Dim lstTextAreas As List(Of Okta_Groups) = jss.Deserialize(res, GetType(List(Of Okta_Groups)))

                    For i = 0 To lstTextAreas.Count - 1

                        Dim newuri As Uri

                        newuri = New Uri(txtidmserver.Text & "/SAAS/jersey/manager/api/scim/Groups?filter=distinguishedName%20eq%20%22" & htoktagroups(lstTextAreas(i).id) & "%22")
                        getdata_vidm(newuri, "application/json", "GET", "search_group")

                    Next i


                Case "Get_Okta_Groups"

                    htoktagroups.Clear()

                    Dim lstTextAreas As List(Of Okta_Groups) = jss.Deserialize(res, GetType(List(Of Okta_Groups)))

                    For i = 0 To lstTextAreas.Count - 1

                        'nitem = lstOktaGroups.Items.Add(lstTextAreas(i).profile.samAccountName)
                        htoktagroups.Add(lstTextAreas(i).id, lstTextAreas(i).profile.dn)

                    Next i

                Case "Get_Okta_Users"

                    htoktausers.Clear()

                    Dim lstTextAreas As List(Of Okta_Groups) = jss.Deserialize(res, GetType(List(Of Okta_Groups)))

                    For i = 0 To lstTextAreas.Count - 1

                        htoktausers.Add(lstTextAreas(i).id, lstTextAreas(i).profile.login)

                    Next i

                Case "Get_Group_Users"

                    Dim lstTextAreas As List(Of Okta_Users) = jss.Deserialize(res, GetType(List(Of Okta_Users)))

                    For i = 0 To lstTextAreas.Count - 1

                        ' nitem = lstOkta.Items.Add(lstTextAreas(i).name)
                        'nitem.SubItems.Add(lstTextAreas(i).label)
                        ' nitem.SubItems.Add(lstTextAreas(i).id)

                    Next i

                Case "get_apps"

                    'Dim snewjson As String = "[" + res + "]"

                    lstOkta.Items.Clear()

                    Dim lstTextAreas As List(Of Apps) = jss.Deserialize(res, GetType(List(Of Apps)))

                    For i = 0 To lstTextAreas.Count - 1

                        If lstTextAreas(i)._links.appLinks.Count > 0 Then

                            'And InStr(lstTextAreas(i).signOnMode, "SAML") 

                            If lstTextAreas(i)._links.appLinks.Count = 1 Then

                                nitem = lstOkta.Items.Add(lstTextAreas(i).name)
                                nitem.SubItems.Add(lstTextAreas(i).label)
                                nitem.SubItems.Add(lstTextAreas(i).id)
                                nitem.SubItems.Add(lstTextAreas(i)._links.appLinks(0).href)
                                nitem.SubItems.Add(lstTextAreas(i)._links.logo(0).href)
                                nitem.SubItems.Add(lstTextAreas(i)._links.users.href)
                                nitem.SubItems.Add(lstTextAreas(i)._links.groups.href)

                            Else

                                For icount = 0 To lstTextAreas(i)._links.appLinks.Count - 1

                                    Dim slinkname As String = lstTextAreas(i)._links.appLinks(icount).name
                                    nitem = lstOkta.Items.Add(slinkname)
                                    nitem.SubItems.Add(lstTextAreas(i).name & "-" & slinkname)
                                    nitem.SubItems.Add(lstTextAreas(i).id)
                                    nitem.SubItems.Add(lstTextAreas(i)._links.appLinks(icount).href)
                                    nitem.SubItems.Add(lstTextAreas(i)._links.logo(0).href)
                                    nitem.SubItems.Add(lstTextAreas(i)._links.users.href)
                                    nitem.SubItems.Add(lstTextAreas(i)._links.groups.href)

                                Next icount

                            End If

                        End If

                    Next i


                Case "Get_Users"

                    Dim lstTextAreas As List(Of Okta_Groups) = jss.Deserialize(res, GetType(List(Of Okta_Groups)))

                    For i = 0 To lstTextAreas.Count - 1

                        Dim newuri As Uri

                        newuri = New Uri(txtidmserver.Text & "/SAAS/jersey/manager/api/scim/Users?filter=userPrincipalName%20eq%20%22" & htoktausers(lstTextAreas(i).id) & "%22")
                        getdata_vidm(newuri, "application/json", "GET", "search_user")

                    Next i

                Case "check_entitlements"

                    Dim lstTextAreas As List(Of App_Assignment) = jss.Deserialize(res, GetType(List(Of App_Assignment)))

                    For i = 0 To lstTextAreas.Count - 1

                        If aoktaevents.Contains(lstTextAreas(i).eventId) = False Then

                            nitem = lstoktaevents.Items.Add(lstTextAreas(i).targets(1).displayName)
                            nitem.SubItems.Add(lstTextAreas(i).action.categories(i))
                            nitem.SubItems.Add(lstTextAreas(i).targets(0).login)

                            Dim stime As DateTime = lstTextAreas(i).published

                            stime.ToLocalTime()

                            nitem.SubItems.Add(stime)
                            nitem.SubItems.Add(lstTextAreas(i).eventId)
                            nitem.SubItems.Add(lstTextAreas(i).targets(1).id)

                            aoktaevents.Add(lstTextAreas(i).eventId)

                        End If

                    Next i

            End Select

        Catch ex As WebException

            If ex.Status = WebExceptionStatus.TrustFailure Then

                ' If MsgBox("WARNING: The certificate on server " & sserver & vbCrLf & "is not trusted. If you trust this server, click YES to continue" & vbCrLf & "If you don't trust this server Click NO", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Certificate not Trusted") = MsgBoxResult.Yes Then

                dlgCert.ShowDialog()

                If dlgCert.DialogResult = vbOK Then

                    Me.atrustedcerts.Add(scerthash)

                    If Me.atrustedcerts.Count > 0 Then

                        Dim scerts As String = ""

                        For Each item In Me.atrustedcerts

                            If scerts = "" Then

                                scerts = item

                            Else

                                scerts = scerts & "|" & item

                            End If

                        Next

                        Reg_Write("Software\VMware Flings\vIDM Manager", "TrustedCerts", scerts)

                    Else

                        Reg_Write("Software\VMware Flings\vIDM Manager", "TrustedCerts", scerthash)

                    End If

                End If

            Else

                MsgBox("Error: " & ex.Message, MsgBoxStyle.Exclamation, "Error")

            End If

        Catch ex As Exception

            If InStr(ex.Message, "403") Then

                MsgBox("Session expired. Please login again.")

            Else

                MsgBox(ex.Message)

            End If

            'MsgBox(ex.Message)

        End Try

    End Sub

    Sub read_saml_metadata()

        Dim reader As XmlTextReader = New XmlTextReader(txtsamlmetadata.Text)

        Do While (reader.Read())
            Select Case reader.NodeType
                Case XmlNodeType.Element 'Display beginning of element.

                    If reader.HasAttributes Then 'If attributes exist
                        While reader.MoveToNextAttribute()
                            'Display attribute name and value.

                            Select Case reader.Name

                                Case "entityID"

                                    ssamlaudience = reader.Value

                                Case "Location"

                                    ssamlrecepient = reader.Value

                            End Select

                            'MsgBox(reader.Name & "|" & reader.Value)
                        End While
                    End If

                Case XmlNodeType.Text 'Display the text in each element.

                    If Len(reader.Value) > 150 Then

                        ssamlcert = reader.Value

                    End If



            End Select
        Loop

        ssamlcert = format_cert(ssamlcert)

    End Sub

    Function RemoveWhitespace(fullString As String) As String
        Return New String(fullString.Where(Function(x) Not Char.IsWhiteSpace(x)).ToArray())
    End Function


    Sub getdata_vidm(uri As Uri, contentType As String, method As String, ByVal thequery As String)

        Dim res As String = ""

        Try

            Dim req As HttpWebRequest = WebRequest.Create(uri)

            req.ContentType = contentType
            req.Method = method
            req.CookieContainer = cookies
            req.Accept = "application/json"

            If thequery = "Create_Weblink" Then

                Dim wc As New WebClient()

                Dim temp As String = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)

                Dim sguid As String = create_GUID()

                wc.DownloadFile(sweblinkicon, temp & "\" & sguid & ".png")

                Dim sicon As String = ConvertFileToBase64(temp & "\" & sguid & ".png")

                File.Delete(temp & "\" & sguid & ".png")

                Dim jsonstring As String = "{""catalogItemType"" :  ""WebAppLink"", ""uuid"" :  """ & sguid & """, ""iconBytes"" : """ & sicon & """, ""packageVersion"": ""1.0"", ""name"": """ & sweblinkname & """, ""productVersion"": null, ""description"":  """ & sweblinkdesc & """, ""authInfo"": { ""type"": ""WebAppLink"", ""targetUrl"" : """ & sweblinkurl & """ }}"
                Dim data = Encoding.UTF8.GetBytes(jsonstring)
                req.Accept = "application/vnd.vmware.horizon.manager.catalog.webapplink+json"

                Dim stream = req.GetRequestStream()
                stream.Write(data, 0, data.Length)
                stream.Close()

            End If


            If thequery = "Create_SAML_App" Then

                Dim wc As New WebClient()

                Dim temp As String = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)

                Dim sguid As String = create_GUID()

                If InStr(sweblinkname, "word") > 0 Then


                    sweblinkicon = "https://op1static.oktacdn.com/assets/img/logos/office365-word.161c56d6c7ba2404236fd57edc5227d7.png"


                End If

                If InStr(sweblinkname, "mail") > 0 Then


                    sweblinkicon = "https://op1static.oktacdn.com/assets/img/logos/office365-mail.408c4a3a369fa6e224086653158a071c.png"


                End If


                If InStr(sweblinkname, "calendar") > 0 Then


                    sweblinkicon = "https://op1static.oktacdn.com/assets/img/logos/office365-calendar.89075f5c6b70db8930a28c497748ffcb.png"


                End If


                If InStr(sweblinkname, "newsfeed") > 0 Then


                    sweblinkicon = "https://op1static.oktacdn.com/assets/img/logos/office365-newsfeed.bdb4cc37246420f8884ebaef7c0dd1ad.png"


                End If


                If InStr(sweblinkname, "powerpoint") > 0 Then


                    sweblinkicon = "https://op1static.oktacdn.com/assets/img/logos/office365-powerpoint.abefb540acc237e95e18181da1f879a4.png"


                End If


                If InStr(sweblinkname, "onedrive") > 0 Then


                    sweblinkicon = "https://op1static.oktacdn.com/assets/img/logos/office365-onedrive.8c419c9eddcb7550067b41c149187679.png"


                End If


                If InStr(sweblinkname, "excel") > 0 Then


                    sweblinkicon = "https://op1static.oktacdn.com/assets/img/logos/office365-excel.48ae05ef65078aa953b60b6e6159e363.png"


                End If


                If InStr(sweblinkname, "sites") > 0 Then


                    sweblinkicon = "https://op1static.oktacdn.com/assets/img/logos/office365-sites.f253a1c3942106869b743837d1279e0e.png"


                End If


                If InStr(sweblinkname, "people") > 0 Then


                    sweblinkicon = "https://op1static.oktacdn.com/assets/img/logos/office365-people.9a20432189065d36c36868615312336b.png"


                End If


                wc.DownloadFile(sweblinkicon, temp & "\" & sguid & ".png")

                Dim sicon As String = ConvertFileToBase64(temp & "\" & sguid & ".png")

                File.Delete(temp & "\" & sguid & ".png")

                Dim samldigest As String = ""
                Dim samlsig As String = ""


                Select Case cmbSAMLAlgorithm.Text

                    Case "SHA1"

                        samlsig = "SHA1withRSA"
                        samldigest = "SHA1"

                    Case "SHA256"

                        samlsig = "SHA256withRSA"
                        samldigest = "SHA256"

                End Select

                Dim jsonstring As String = "{""catalogItemType"": ""Saml20"", ""uuid"":""" & sguid & """, ""packageVersion"":""1.0"", ""name"":""" & sweblinkname & """,""productVersion"": null, ""description"" :  """ & sweblinkdesc & """, ""provisioningAdapter"":null, ""resourceConfiguration"": { ""applicationAttributeMap"":null, ""parameterValues"": { } }, ""iconBytes"": """ & sicon & """, ""accessPolicySetUuid"": """", ""labels"":[ ], ""uiCapabilities"":{ ""catalogItemEntitlement"":[ ""READ"", ""DELETE"", ""CREATE"", ""UPDATE"" ], ""catalogItemDetails"":[ ""READ"", ""EXPORT"", ""DELETE"", ""CREATE"", ""UPDATE"" ], ""catalogItemAccessPolicy"":[ ""READ"", ""DELETE"", ""CREATE"", ""UPDATE"" ], ""catalogItemProvisioning"":[ ""READ"", ""DELETE"", ""CREATE"", ""UPDATE"" ], ""catalogItemLicense"":[ ""READ"", ""UPDATE"" ] }, ""_links"":{ ""hw-icon"":{ ""href"":"""" }, ""self"":{ ""href"":""/SAAS/jersey/manager/api/catalogitems/" & sguid & """ }, ""hw-launch"":{ ""href"":""/SAAS/API/1.0/Get/apps/launch/app/" & sguid & """} }, ""authInfo"":{ ""type"":""Saml20"", ""recipientName"":""" & ssamlrecepient & """, ""audience"":""" & ssamlaudience & """, ""validityTimeSeconds"":200, ""signingCert"":""" & ssamlcert & """, ""parameters"":[ ], ""attributes"":null, ""nameIdFormat"": ""urn:oasis:names:tc:SAML:2.0:nameid-format:persistent"", ""nameId"":""${user.userName}"", ""assertionConsumerServiceUrl"":""" & ssamlrecepient & " "", ""configureAs"":""manual"", ""metadata"":null, ""metadataUrl"": null, ""includeDestination"": true, ""signAssertion"":false, ""signResponse"":true, ""includeSigningCert"":false, ""loginRedirectionUrl"":null, ""relayState"": """ & sweblinkurl & """, ""encryptionCerts"":null,""signatureAlgorithm"":""" & samlsig & """,""digestAlgorithm"":""" & samldigest & """,""allowApiAccess"": false, ""credentialCheckType"":null, ""proxyCount"": null } }"

                'Dim jsonstring As String = "{""catalogItemType"": ""Saml20"", ""uuid"":""" & sguid & """, ""packageVersion"":""1.0"", ""name"":""" & sweblinkname & """,""productVersion"": null, ""description"" :  """ & sweblinkdesc & """, ""provisioningAdapter"":null, ""resourceConfiguration"": { ""applicationAttributeMap"":null, ""parameterValues"": { } }, ""iconBytes"": """ & sicon & """, ""accessPolicySetUuid"": """", ""labels"":[ ], ""uiCapabilities"":{ ""catalogItemEntitlement"":[ ""READ"", ""DELETE"", ""CREATE"", ""UPDATE"" ], ""catalogItemDetails"":[ ""READ"", ""EXPORT"", ""DELETE"", ""CREATE"", ""UPDATE"" ], ""catalogItemAccessPolicy"":[ ""READ"", ""DELETE"", ""CREATE"", ""UPDATE"" ], ""catalogItemProvisioning"":[ ""READ"", ""DELETE"", ""CREATE"", ""UPDATE"" ], ""catalogItemLicense"":[ ""READ"", ""UPDATE"" ] }, ""_links"":{ ""hw-icon"":{ ""href"":"""" }, ""self"":{ ""href"":""/SAAS/jersey/manager/api/catalogitems/" & sguid & """ }, ""hw-launch"":{ ""href"":""/SAAS/API/1.0/Get/apps/launch/app/" & sguid & """} }, ""authInfo"":{ ""type"":""Saml20"", ""validityTimeSeconds"":200, ""parameters"":[ ], ""attributes"":null, ""nameIdFormat"": ""urn:oasis:names:tc:SAML:2.0:nameid-format:persistent"", ""nameId"":""${user.userName}"", ""configureAs"":""xml"", ""metadata"": """ & ssamlmetadata & """, ""metadataUrl"": null, ""includeDestination"": true, ""signAssertion"":false, ""signResponse"":true, ""includeSigningCert"":false, ""loginRedirectionUrl"":null, ""relayState"": """ & sweblinkurl & """, ""encryptionCerts"":null, ""allowApiAccess"": false, ""credentialCheckType"":null, ""proxyCount"": null } }"

                Dim data = Encoding.UTF8.GetBytes(jsonstring)
                req.Accept = "application/vnd.vmware.horizon.manager.catalog.saml20+json"

                Dim stream = req.GetRequestStream()
                stream.Write(data, 0, data.Length)
                stream.Close()


            End If

            If thequery = "Delete_App" Then

                req.Accept = "application/vnd.vmware.horizon.manager.catalog.saml20+json"

            End If


            If thequery = "HC_FIX" Then

                Dim jsonstring As String = "{""name"" : ""enableDesktoneCustomIdMap"", ""value"" : ""true ""}"
                Dim data = Encoding.UTF8.GetBytes(jsonstring)
                req.Accept = "*/*"
                Dim stream = req.GetRequestStream()
                stream.Write(data, 0, data.Length)
                stream.Close()

                '{ "name": "enableDesktoneCustomIdMap", "value": "true" }



            End If


            If thequery = "Assign_App" Then

                Dim jsonstring As String = "{""returnPayloadOnError"" :   true, ""operations"" : [{ ""method"" : ""POST"", ""data"" : { ""catalogItemId"" : """ & svidmcatalogitem & """, ""subjectType"" : ""USERS"", ""subjectId"" : """ & svidmuser & """, ""activationPolicy"" : ""AUTOMATIC"" }} ], ""_links"" : { }}"
                Dim data = Encoding.UTF8.GetBytes(jsonstring)
                req.Accept = "application/vnd.vmware.horizon.manager.bulk.sync.response+json"

                Dim stream = req.GetRequestStream()
                stream.Write(data, 0, data.Length)
                stream.Close()

            End If

            If thequery = "Assign_App_Group" Then

                Dim jsonstring As String = "{""returnPayloadOnError"" :   true, ""operations"" : [{ ""method"" : ""POST"", ""data"" : { ""catalogItemId"" : """ & svidmcatalogitem & """, ""subjectType"" : ""GROUPS"", ""subjectId"" : """ & svidmuser & """, ""activationPolicy"" : ""AUTOMATIC"" }} ], ""_links"" : { }}"
                Dim data = Encoding.UTF8.GetBytes(jsonstring)
                req.Accept = "application/vnd.vmware.horizon.manager.bulk.sync.response+json"
                Dim stream = req.GetRequestStream()
                stream.Write(data, 0, data.Length)
                stream.Close()

            End If

            If thequery = "Get_Apps" Then

                Dim jsonstring As String = "{""nameFilter"": """", ""includeTypes"":[""Saml11"",""Saml20"",""WSFed12"",""WebAppLink""], ""categories"":[""""], ""includeAttributes"":[""labels""], ""includeIconBytes"":""true""}"
                req.Accept = "application/vnd.vmware.horizon.manager.catalog.item.list+json"
                Dim data = Encoding.UTF8.GetBytes(jsonstring)
                Dim stream = req.GetRequestStream()
                stream.Write(data, 0, data.Length)
                stream.Close()

            End If

            If thequery = "Get_Access_Token" Then

                req.Headers.Add("Authorization:  Basic " & txtoauthtoken.Text)

            Else

                req.Headers.Add("Authorization: Bearer " & txtoauthaccesstoken.Text)

            End If

            req.ServerCertificateValidationCallback = New RemoteCertificateValidationCallback(AddressOf ServerCertificateValidationCallback)
            Dim jsonresponse = req.GetResponse().GetResponseStream()
            Dim reader As New StreamReader(jsonresponse)
            res = reader.ReadToEnd()

            reader.Close()

            Dim jss As New JavaScriptSerializer()
            jss.MaxJsonLength = "50000000"

            Select Case thequery

                Case "Get_Access_Token"

                    Dim snewjson As String = "[" + res + "]"

                    Dim lstTextAreas As List(Of Access) = jss.Deserialize(snewjson, GetType(List(Of Access)))

                    txtoauthaccesstoken.Text = lstTextAreas(0).access_token

                Case "Get_Users"

                    'Dim snewjson As String = "[" + res + "]"

                    lstOkta.Items.Clear()

                    Dim lstTextAreas As List(Of Apps) = jss.Deserialize(res, GetType(List(Of Apps)))

                    For i = 0 To lstTextAreas.Count - 1

                        nitem = lstOkta.Items.Add(lstTextAreas(i).name)
                        nitem.SubItems.Add(lstTextAreas(i).label)
                        nitem.SubItems.Add(lstTextAreas(i).id)

                    Next i

                Case "Create_Weblink"

                    Dim snewjson As String = "[" + res + "]"

                    Dim lstTextAreas As List(Of idm_weblink) = jss.Deserialize(snewjson, GetType(List(Of idm_weblink)))

                    For i = 0 To lstTextAreas.Count - 1

                        svidmcatalogitem = ""

                        svidmcatalogitem = lstTextAreas(i).uuid

                    Next i

                Case "Create_SAML_App"

                    Dim snewjson As String = "[" + res + "]"

                    Dim lstTextAreas As List(Of idm_weblink) = jss.Deserialize(snewjson, GetType(List(Of idm_weblink)))

                    If lstTextAreas.Count = 0 Then

                        'MsgBox(res)

                    End If

                    For i = 0 To lstTextAreas.Count - 1

                        svidmcatalogitem = ""

                        svidmcatalogitem = lstTextAreas(i).uuid

                    Next i

                Case "Delete_App"

                    If res.Length > 10 Then

                        MsgBox(res, MsgBoxStyle.Information, "Error")

                    End If


                Case "HC_FIX"

                    MsgBox(res)

                Case "Get_Apps"

                    lstvIDM.Items.Clear()

                    Dim snewjson As String = "[" + res + "]"

                    Dim lstTextAreas As List(Of vIDM_Apps) = jss.Deserialize(snewjson, GetType(List(Of vIDM_Apps)))

                    htvidmapps.Clear()

                    For i = 0 To lstTextAreas(0).items.Count - 1

                        htvidmapps.Add(lstTextAreas(0).items(i).uuid, lstTextAreas(0).items(i).name)

                        nitem = lstvIDM.Items.Add(lstTextAreas(0).items(i).name)
                        nitem.SubItems.Add(lstTextAreas(0).items(i).description)
                        nitem.SubItems.Add(lstTextAreas(0).items(i).uuid)

                    Next i

                Case "search_user"

                    svidmuser = ""

                    Dim snewjson As String = "[" + res + "]"

                    Dim lstTextAreas As List(Of vidm_user) = jss.Deserialize(snewjson, GetType(List(Of vidm_user)))

                    htvidmapps.Clear()

                    If lstTextAreas(0).totalResults = "0" Then

                        WriteToEventLog("Cannot find user on VIDM side - skipping")
                        Exit Select

                    End If

                    For i = 0 To lstTextAreas.Count - 1

                        svidmuser = lstTextAreas(i).Resources(i).id

                        Dim newuri As Uri

                        newuri = New Uri(txtidmserver.Text & "/SAAS/jersey/manager/api/entitlements/definitions")
                        getdata_vidm(newuri, "application/vnd.vmware.horizon.manager.entitlements.definition.bulk+json", "POST", "Assign_App")


                    Next i

                Case "search_group"

                    svidmuser = ""

                    Dim snewjson As String = "[" + res + "]"

                    Dim lstTextAreas As List(Of vidm_user) = jss.Deserialize(snewjson, GetType(List(Of vidm_user)))

                    htvidmapps.Clear()

                    If lstTextAreas(0).totalResults = "0" Then

                        WriteToEventLog("Cannot find group on VIDM side - skipping")
                        Exit Select

                    End If

                    For i = 0 To lstTextAreas.Count - 1

                        svidmuser = lstTextAreas(i).Resources(i).id

                        Dim newuri As Uri

                        newuri = New Uri(txtidmserver.Text & "/SAAS/jersey/manager/api/entitlements/definitions")
                        getdata_vidm(newuri, "application/vnd.vmware.horizon.manager.entitlements.definition.bulk+json", "POST", "Assign_App_Group")


                    Next i



                Case "check_entitlements"

                    Dim snewurl As String = "published gt """ & slastquery & """ and action.objectType eq ""app.generic.provision.assign_user_to_app"""

                    Dim sencodedurl As String = HttpUtility.UrlEncode(snewurl)

                    Me.theuri = New Uri("https://dev-108397.oktapreview.com/api/v1/events?filter=" & sencodedurl)


                Case "Assign_App"

                    Dim snewjson As String = "[" + res + "]"

                    Dim lstTextAreas As List(Of idm_entitle) = jss.Deserialize(snewjson, GetType(List(Of idm_entitle)))

                    For i = 0 To lstTextAreas.Count - 1

                        If lstTextAreas(i).operations(i).status.description = "entitlement.exists" Then

                            aoktaevents.Remove(scurrentevent)

                        End If

                    Next i


            End Select

        Catch ex As WebException

            If ex.Status = WebExceptionStatus.TrustFailure Then

                ' If MsgBox("WARNING: The certificate on server " & sserver & vbCrLf & "is not trusted. If you trust this server, click YES to continue" & vbCrLf & "If you don't trust this server Click NO", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Certificate not Trusted") = MsgBoxResult.Yes Then

                dlgCert.ShowDialog()

                If dlgCert.DialogResult = vbOK Then

                    Me.atrustedcerts.Add(scerthash)

                    If Me.atrustedcerts.Count > 0 Then

                        Dim scerts As String = ""

                        For Each item In Me.atrustedcerts

                            If scerts = "" Then

                                scerts = item

                            Else

                                scerts = scerts & "|" & item

                            End If

                        Next

                        Reg_Write("Software\VMware Flings\vIDM Manager", "TrustedCerts", scerts)

                    Else

                        Reg_Write("Software\VMware Flings\vIDM Manager", "TrustedCerts", scerthash)

                    End If

                End If

                Exit Sub


            End If

            If InStr(ex.Message, "403") Then

                MsgBox("Session expired. Please login again.")

            Else

                MsgBox(ex.Message)

            End If

            'MsgBox(ex.Message)

        End Try


    End Sub

    Function format_cert(ByVal scert As String) As String

        Dim newString As String = scert.Replace(vbCr, "").Replace(vbLf, "\r\n")

        Dim sfinalstring As String = Regex.Replace(newString, "\p{C}+", "")

        Return sfinalstring

    End Function


    Public Function ConvertFileToBase64(ByVal fileName As String) As String
        Return Convert.ToBase64String(System.IO.File.ReadAllBytes(fileName))
    End Function

    Function create_GUID() As String

        Dim g As Guid

        g = Guid.NewGuid()

        Return g.ToString


    End Function

    Sub read_event_Logs()

        ' Log type can be Application, Security, System or any other custom log
        ' Select the log type you want to read
        Dim logtype As String = "VMware IDM to Okta Service Bridge"

        ' In the constructor of the eventlog, pass the log type and the computer name 
        ' from which you want to read the logs 
        Dim evtLog As New EventLog(logtype, System.Environment.MachineName)

        Dim lastlogtoshow As Integer = evtLog.Entries.Count
        If lastlogtoshow <= 0 Then
            Console.WriteLine("There are no event logs in the log : " & logtype)
            Exit Sub
        End If

        Dim nitem As ListViewItem

        ' Read the last record in the specified log 
        Dim currentEntry As EventLogEntry
        Dim i As Integer
        ' Show Last 2 entries. You can similarly write the log to a file.

        If lastlogtoshow < 100 Then

            For i = 0 To lastlogtoshow - 1
                currentEntry = evtLog.Entries(i)
                nitem = lstoktaevents.Items.Add(currentEntry.EntryType.ToString)
                nitem.SubItems.Add(currentEntry.TimeGenerated)
                nitem.SubItems.Add(currentEntry.Message)

            Next i

        Else

            For i = evtLog.Entries.Count - 1 To lastlogtoshow - 100 Step -1
                currentEntry = evtLog.Entries(i)
                nitem = lstoktaevents.Items.Add(currentEntry.EntryType.ToString)
                nitem.SubItems.Add(currentEntry.TimeGenerated)
                nitem.SubItems.Add(currentEntry.Message)
            Next i

        End If



        evtLog.Close()

    End Sub




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        WriteToEventLog("VMware IDM to Okta Service Bridge is Starting Up", EventLogEntryType.Information)

        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls Or SecurityProtocolType.Ssl3 Or SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls12

        If My.Settings.IDMServer <> "" Then

            txtidmserver.Text = My.Settings.IDMServer

        End If

        If My.Settings.SAMLMetaDataPath <> "" Then

            txtsamlmetadata.Text = My.Settings.SAMLMetaDataPath

        End If

        If My.Settings.IDMoAuthUser <> "" Then

            txtoauthclient.Text = My.Settings.IDMoAuthUser

        End If

        If My.Settings.SMTPServer <> "" Then

            txtsmtpserver.Text = My.Settings.SMTPServer

        End If

        If My.Settings.SMTPPort <> "" Then

            txtsmtpport.Text = My.Settings.SMTPPort

        End If

        If My.Settings.SMTPUser <> "" Then

            txtsmtpuser.Text = My.Settings.SMTPUser

        End If

        If My.Settings.OktaServer <> "" Then

            txtoktaurl.Text = My.Settings.OktaServer

        End If


        If My.Settings.SMTPpw <> "" Then

            txtsmtppw.Text = My.Settings.SMTPpw

        End If

        If My.Settings.SMTPTo <> "" Then

            txtalertrecipients.Text = My.Settings.SMTPTo

        End If

        If My.Settings.SMTPFrom <> "" Then

            txtSendFrom.Text = My.Settings.SMTPFrom

        End If

        If My.Settings.SMTPSubject <> "" Then

            txtsubjectprefix.Text = My.Settings.SMTPSubject

        End If

        If My.Settings.IDMoAuthSS <> "" Then

            Dim wrapper As New crypto(txtidmserver.Text & "|||||" & txtoauthclient.Text)
            Dim cipherText As String = wrapper.DecryptData(My.Settings.IDMoAuthSS)
            txtoauthss.Text = cipherText

        End If

        cmbSAMLAlgorithm.Text = "SHA256"

        If My.Settings.OktaAPIKey <> "" Then


            Dim wrapper As New crypto(txtoktaurl.Text & "|||||")
            Dim cipherText As String = wrapper.DecryptData(My.Settings.OktaAPIKey)
            txtoktahash.Text = cipherText

        End If

        If reg_key_exists("Software\VMware Flings\vIDM Manager") = False Then

            Try
                Registry.CurrentUser.CreateSubKey("Software\VMware Flings\vIDM Manager")

            Catch ex As Exception

                MessageBox.Show("Error: " & ex.Message)

            End Try

        End If


        If Reg_Read("Software\VMware Flings\vIDM Manager", "TrustedCerts") <> "NO_VALUE" Then

            Dim strustedcerts As String = Reg_Read("Software\VMware Flings\vIDM Manager", "TrustedCerts")

            If InStr(strustedcerts, "|") > 0 Then

                Dim acerts As Array = Split(strustedcerts, "|")

                For Each item In acerts

                    atrustedcerts.Add(item)

                Next

            Else

                atrustedcerts.Add(strustedcerts)

            End If

        End If

    End Sub

    Function get_group_users(ByVal surl As String)

        Dim newuri As Uri

        newuri = New Uri(surl)
        getdata_okta(newuri, "application/json", "GET", "Get_Group_Users")

    End Function


    Function to_utc()

        Dim datePatt As String = "yyyy-MM-ddTHH:mm:ss.000Z"
        Dim saveUtcNow As DateTime = DateTime.UtcNow.AddMinutes(-30)
        Dim dtString As String = saveUtcNow.ToString(datePatt)
        slastquery = dtString

    End Function


    Function Reg_Read(ByVal spath As String, ByVal sname As String) As String

        Dim regKey As RegistryKey
        Dim svalue As String

        Try

            regKey = Registry.CurrentUser.OpenSubKey(spath, True)

            svalue = regKey.GetValue(sname)
            If svalue = Nothing Then

                Return "NO_VALUE"

            End If

            Return svalue
            regKey.Close()

        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message)
            Return "ERROR"

        End Try

    End Function

    Function reg_key_exists(ByVal spath As String) As Boolean

        Dim regExists As RegistryKey
        regExists = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(spath, False)
        If regExists Is Nothing Then

            Return False

        Else

            Return True

        End If
    End Function

    Sub Reg_Write(ByVal spath As String, ByVal sname As String, ByVal svalue As String)

        Dim regKey As RegistryKey

        Try

            regKey = Registry.CurrentUser.OpenSubKey(spath, True)
            regKey.SetValue(sname, svalue)
            regKey.Close()

        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message)


        End Try

    End Sub



    Public Shared Function ServerCertificateValidationCallback(sender As Object, certificate As System.Security.Cryptography.X509Certificates.X509Certificate2, chain As X509Chain, sslPolicyErrors As SslPolicyErrors) As Boolean

        Form1.scerthash = certificate.GetCertHashString

        If Form1.atrustedcerts.Count = 0 Then

            dlgCert.lblIssuedBy.Text = "Issued By: " & certificate.Issuer
            dlgCert.lblIssuedto.Text = "Issued To: " & certificate.Subject
            dlgCert.lblsn.Text = "Serial Number: " & certificate.GetSerialNumberString
            dlgCert.lblvalidfrom.Text = "Valid from " & certificate.GetEffectiveDateString & " to " & certificate.GetExpirationDateString
            dlgCert.lbl256fp.Text = "Thumbprint: " & certificate.Thumbprint
            dlgCert.lblCertError.Text = "Certificate Errors: " & sslPolicyErrors.ToString
            Return False

        Else

            Dim strustedcerthash As String = ""

            Dim slocalhash As String = ""

            slocalhash = certificate.GetCertHashString

            For Each strustedcerthash In Form1.atrustedcerts

                If strustedcerthash = slocalhash Then

                    Return True

                End If

            Next

            dlgCert.lblIssuedBy.Text = "Issued By: " & certificate.Issuer
            dlgCert.lblIssuedto.Text = "Issued To: " & certificate.Subject
            dlgCert.lblsn.Text = "Serial Number: " & certificate.GetSerialNumberString
            dlgCert.lblvalidfrom.Text = "Valid from " & certificate.GetEffectiveDateString & " to " & certificate.GetExpirationDateString
            dlgCert.lbl256fp.Text = "Thumbprint: " & certificate.Thumbprint
            dlgCert.lblCertError.Text = "Certificate Errors: " & sslPolicyErrors.ToString

            Return False

        End If

    End Function

    Private Sub tmrOkta_Tick(sender As Object, e As EventArgs) Handles tmrOkta.Tick

        Dim newuri As Uri

        to_utc()

        Dim snewurl As String = "published gt """ & slastquery & """ and action.objectType eq ""app.generic.provision.assign_user_to_app"""

        Dim sencodedurl As String = HttpUtility.UrlEncode(snewurl)

        newuri = New Uri(txtoktaurl.Text & "/api/v1/events?filter=" & sencodedurl)

        getdata_okta(newuri, "application/json", "GET", "check_entitlements")

        statusokta.Text = "Okta last queried at: " & Now

    End Sub

    Function base64encode(ByVal sdecoded As String) As String

        Dim base64Decoded As String = sdecoded
        Dim base64Encoded As String
        Dim data As Byte()
        data = System.Text.ASCIIEncoding.UTF8.GetBytes(base64Decoded)
        base64Encoded = System.Convert.ToBase64String(data)

        txtoauthtoken.Text = base64Encoded

    End Function




    Private Sub cmdOkta_Click(sender As Object, e As EventArgs)

        Dim newuri As Uri

        to_utc()

        newuri = New Uri(txtoktaurl.Text & "/api/v1/apps")
        getdata_okta(newuri, "application/json", "GET", "get_apps")

    End Sub


    Private Sub tmrProcessEvents_Tick(sender As Object, e As EventArgs) Handles tmrProcessEvents.Tick

        Dim newuri As Uri

        Dim item As ListViewItem

        svidmcatalogitem = ""

        For Each item In lstoktaevents.Items

            If amonitroredokta.Contains(item.SubItems(5).Text) = True And aoktaevents.Contains(item.SubItems(4).Text) = True Then

                scurrentevent = ""

                newuri = New Uri(txtidmserver.Text & "/SAAS/jersey/manager/api/scim/Users?filter=userPrincipalName%20eq%20%22" & item.SubItems(2).Text & "%22")
                getdata_vidm(newuri, "application/json", "GET", "search_user")

                svidmcatalogitem = htoktatoidm(item.SubItems(5).Text)

                scurrentevent = item.SubItems(4).Text

                newuri = New Uri(txtidmserver.Text & "/SAAS/jersey/manager/api/entitlements/definitions")
                getdata_vidm(newuri, "application/vnd.vmware.horizon.manager.entitlements.definition.bulk+json", "POST", "Assign_App")

            End If

        Next


    End Sub

    Sub get_okta_groups()

        Dim newuri As Uri

        newuri = New Uri(txtoktaurl.Text & "/api/v1/groups")
        getdata_okta(newuri, "application/json", "GET", "Get_Okta_Groups")


    End Sub

    Sub get_okta_users()

        Dim newuri As Uri

        newuri = New Uri(txtoktaurl.Text & "/api/v1/users")
        getdata_okta(newuri, "application/json", "GET", "Get_Okta_Users")


    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs)

        get_okta_groups()

    End Sub

    Private Sub cmdDeleteIDM_Click(sender As Object, e As EventArgs) Handles cmdDeleteIDM.Click

        If lstvIDM.CheckedItems.Count = 0 Then

            MsgBox("Please select an IDM application to delete", MsgBoxStyle.Information, "Nothing Selected")

            Exit Sub

        Else

        End If

        Dim item As ListViewItem
        Dim newuri As Uri

        For Each item In lstvIDM.CheckedItems

            newuri = New Uri(txtidmserver.Text & "/SAAS/jersey/manager/api/catalogitems/" & item.SubItems(2).Text)
            getdata_vidm(newuri, "application/json", "DELETE", "Delete_App")


        Next

        newuri = New Uri(txtidmserver.Text & "/SAAS/jersey/manager/api/catalogitems/search")
        getdata_vidm(newuri, "application/vnd.vmware.horizon.manager.catalog.search+json", "POST", "Get_Apps")




    End Sub


    Sub refresh_idm()

        Dim newuri As Uri

        If txtoauthtoken.Text = "" Then

            base64encode(Trim(txtoauthclient.Text) & ":" & Trim(txtoauthss.Text))

            newuri = New Uri(txtidmserver.Text & "/SAAS/API/1.0/oauth2/token?grant_type=client_credentials")
            getdata_vidm(newuri, "application/json", "POST", "Get_Access_Token")

            WriteToEventLog("Created Access Token for IDM Server " & txtidmserver.Text, EventLogEntryType.Information)

            newuri = New Uri(txtidmserver.Text & "/SAAS/jersey/manager/api/catalogitems/search")
            getdata_vidm(newuri, "application/vnd.vmware.horizon.manager.catalog.search+json", "POST", "Get_Apps")

        Else

            newuri = New Uri(txtidmserver.Text & "/SAAS/jersey/manager/api/catalogitems/search")
            getdata_vidm(newuri, "application/vnd.vmware.horizon.manager.catalog.search+json", "POST", "Get_Apps")

        End If

    End Sub


    Private Sub cmdRefreshIDM_Click(sender As Object, e As EventArgs) Handles cmdRefreshIDM.Click

        refresh_idm()

    End Sub

    Private Sub cmdRefreshOkta_Click(sender As Object, e As EventArgs) Handles cmdRefreshOkta.Click

        refresh_okta()

    End Sub

    Sub refresh_okta()

        Dim newuri As Uri

        to_utc()

        newuri = New Uri(txtoktaurl.Text & "/api/v1/apps")
        getdata_okta(newuri, "application/json", "GET", "get_apps")

    End Sub

    Function send_email(ByVal serror As String, ByVal sdate As DateTime, ByVal ssubject As String) As String

        Dim smail As New System.Net.Mail.SmtpClient(txtsmtpserver.Text, txtsmtpport.Text)
        Dim smailerror As String = ""
        Dim ssubjectprefix As String = txtsubjectprefix.Text
        smail.Credentials = New NetworkCredential(txtsmtpuser.Text, txtsmtppw.Text)
        smail.EnableSsl = True

        If InStr(ssubjectprefix, "<servername>") > 0 Then

            ssubjectprefix = Replace(ssubjectprefix, "<servername>", sthisserver)

        End If

        Dim omessage As New MailMessage
        omessage.From = New MailAddress(txtSendFrom.Text)
        omessage.To.Add(txtalertrecipients.Text)
        omessage.Subject = ssubjectprefix
        omessage.IsBodyHtml = True

        'omessage.Attachments

        omessage.Body = "Time of Alert: <br>" & Now & "<br><br>Message:<br>" & serror

        Try

            smail.Send(omessage)

        Catch ex As Exception

            smailerror = ex.Message
            Return ex.Message
            WriteToEventLog("Error Sending Email: " & ex.Message, EventLogEntryType.Error)

            Exit Function

        End Try

        Return "Message Sent"

    End Function




    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        MsgBox(send_email("This is a test message", Now, txtsubjectprefix.Text))


    End Sub

    Private Sub txtidmserver_TextChanged(sender As Object, e As EventArgs) Handles txtidmserver.TextChanged

        My.Settings.IDMServer = txtidmserver.Text
        My.Settings.Save()

    End Sub

    Private Sub cmdgetsaml_Click(sender As Object, e As EventArgs) Handles cmdgetsaml.Click

        openSAMLxml.ShowDialog()

    End Sub

    Private Sub openSAMLxml_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles openSAMLxml.FileOk

        txtsamlmetadata.Text = openSAMLxml.FileName

    End Sub

    Private Sub txtsamlmetadata_TextChanged(sender As Object, e As EventArgs) Handles txtsamlmetadata.TextChanged

        My.Settings.SAMLMetaDataPath = txtsamlmetadata.Text
        My.Settings.Save()

    End Sub

    Private Sub txtoauthclient_TextChanged(sender As Object, e As EventArgs) Handles txtoauthclient.TextChanged

        My.Settings.IDMoAuthUser = txtoauthclient.Text
        My.Settings.Save()

    End Sub

    Private Sub cmdMonitor_Click(sender As Object, e As EventArgs) Handles cmdMonitor.Click


        refresh_idm()

        refresh_okta()

        read_saml_metadata()

        get_okta_users()

        get_okta_groups()


        'tmrOkta.Enabled = True
        'tmrProcessEvents.Enabled = True


        Dim newuri As Uri
        Dim bcreated As Boolean = False
        Dim item As ListViewItem
        Dim idmitem As ListViewItem

        For Each item In lstOkta.Items

            For Each idmitem In lstvIDM.Items

                If InStr(idmitem.SubItems(1).Text, item.SubItems(2).Text) > 0 Then

                    bcreated = True

                    Exit For

                Else

                    bcreated = False

                End If

            Next

            If bcreated = False Then

                sweblinkname = item.SubItems(1).Text
                sweblinkdesc = "Synced From Okta|" & item.SubItems(2).Text
                sweblinkurl = item.SubItems(3).Text
                sweblinkicon = item.SubItems(4).Text

                'newuri = New Uri(txtidmserver.Text & "/SAAS/jersey/manager/api/catalogitems")
                'getdata_vidm(newuri, "application/vnd.vmware.horizon.manager.catalog.webapplink+json", "POST", "Create_Weblink")

                newuri = New Uri(txtidmserver.Text & "/SAAS/jersey/manager/api/catalogitems")
                getdata_vidm(newuri, "application/vnd.vmware.horizon.manager.catalog.saml20+json", "POST", "Create_SAML_App")

                newuri = New Uri(item.SubItems(5).Text)
                getdata_okta(newuri, "application/json", "GET", "Get_Users")

                newuri = New Uri(item.SubItems(6).Text)
                getdata_okta(newuri, "application/json", "GET", "Get_Groups")

                newuri = New Uri(txtidmserver.Text & "/SAAS/jersey/manager/api/catalogitems/search")
                getdata_vidm(newuri, "application/vnd.vmware.horizon.manager.catalog.search+json", "POST", "Get_Apps")

            End If
        Next

        Select Case cmdMonitor.Text

            Case "Start Monitoring Okta"




            Case "Monitoring Okta"



        End Select





    End Sub

    Private Sub txtsmtpserver_TextChanged(sender As Object, e As EventArgs) Handles txtsmtpserver.TextChanged

        My.Settings.SMTPServer = txtsmtpserver.Text
        My.Settings.Save()

    End Sub

    Private Sub txtoktaurl_TextChanged(sender As Object, e As EventArgs) Handles txtoktaurl.TextChanged

        My.Settings.OktaServer = txtoktaurl.Text
        My.Settings.Save()

    End Sub

    Private Sub txtsmtpport_TextChanged(sender As Object, e As EventArgs) Handles txtsmtpport.TextChanged

        My.Settings.SMTPPort = txtsmtpport.Text
        My.Settings.Save()

    End Sub

    Private Sub txtsmtpuser_TextChanged(sender As Object, e As EventArgs) Handles txtsmtpuser.TextChanged

        My.Settings.SMTPUser = txtsmtpuser.Text
        My.Settings.Save()

    End Sub

    Private Sub txtsmtppw_TextChanged(sender As Object, e As EventArgs) Handles txtsmtppw.TextChanged

        My.Settings.SMTPpw = txtsmtppw.Text
        My.Settings.Save()

    End Sub

    Private Sub txtSendFrom_TextChanged(sender As Object, e As EventArgs) Handles txtSendFrom.TextChanged

        My.Settings.SMTPFrom = txtSendFrom.Text
        My.Settings.Save()


    End Sub

    Private Sub txtsubjectprefix_TextChanged(sender As Object, e As EventArgs) Handles txtsubjectprefix.TextChanged

        My.Settings.SMTPSubject = txtsubjectprefix.Text
        My.Settings.Save()

    End Sub

    Private Sub txtalertrecipients_TextChanged(sender As Object, e As EventArgs) Handles txtalertrecipients.TextChanged

        My.Settings.SMTPTo = txtalertrecipients.Text
        My.Settings.Save()


    End Sub


    Private Sub cmdImporttoIDM_Click(sender As Object, e As EventArgs) Handles cmdImporttoIDM.Click

        Dim item As ListViewItem
        Dim sreturn As String = "Are you sure you want to Import the following Okta Apps to IDM?" & vbCrLf & vbCrLf

        If lstOkta.CheckedItems.Count = 0 Then

            MsgBox("Please select one or more Okta Applications to Import to IDM", MsgBoxStyle.Information, "Nothing Selected")
            Exit Sub

        Else

            For Each item In lstOkta.CheckedItems

                sreturn = sreturn & vbTab & "*-" & item.SubItems(1).Text & vbCrLf

            Next

            If MsgBox(sreturn, MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Import to IDM?") = MsgBoxResult.Yes Then

                refresh_idm()

                read_saml_metadata()

                get_okta_users()

                get_okta_groups()

                'tmrOkta.Enabled = True
                'tmrProcessEvents.Enabled = True

                Dim newuri As Uri
                Dim bcreated As Boolean = False
                Dim idmitem As ListViewItem

                For Each item In lstOkta.CheckedItems

                    For Each idmitem In lstvIDM.Items

                        Dim aidm As Array = Split(idmitem.SubItems(1).Text, "|")

                        Dim iub As Integer = aidm.GetUpperBound(0)

                        If iub > 1 Then

                            If aidm(1) = item.SubItems(1).Text And aidm(2) = item.SubItems(2).Text Then


                                bcreated = True

                                Exit For

                            Else

                                bcreated = False

                            End If

                        End If


                    Next

                    If bcreated = False Then

                        sweblinkname = item.SubItems(1).Text
                        sweblinkdesc = "Synced From Okta|" & item.SubItems(1).Text & "|" & item.SubItems(2).Text
                        sweblinkurl = item.SubItems(3).Text
                        sweblinkicon = item.SubItems(4).Text

                        'newuri = New Uri(txtidmserver.Text & "/SAAS/jersey/manager/api/catalogitems")
                        'getdata_vidm(newuri, "application/vnd.vmware.horizon.manager.catalog.webapplink+json", "POST", "Create_Weblink")

                        newuri = New Uri(txtidmserver.Text & "/SAAS/jersey/manager/api/catalogitems")
                        getdata_vidm(newuri, "application/vnd.vmware.horizon.manager.catalog.saml20+json", "POST", "Create_SAML_App")

                        newuri = New Uri(item.SubItems(5).Text)
                        getdata_okta(newuri, "application/json", "GET", "Get_Users")

                        newuri = New Uri(item.SubItems(6).Text)
                        getdata_okta(newuri, "application/json", "GET", "Get_Groups")

                        newuri = New Uri(txtidmserver.Text & "/SAAS/jersey/manager/api/catalogitems/search")
                        getdata_vidm(newuri, "application/vnd.vmware.horizon.manager.catalog.search+json", "POST", "Get_Apps")

                    End If

                Next


                MsgBox("Import from Okta to IDM Complete", MsgBoxStyle.Information, "Import Complete")

            Else


            End If


        End If


    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        MsgBox("VMware IDM to Okta Service Bridge" & vbCrLf & "Version: " & Me.ProductVersion & vbCrLf & "Chris Halstead - chalstead@vmware.com" & vbCrLf & "Copyright © 2016", MsgBoxStyle.Information, "About...")

    End Sub

    Private Sub cmdSaveSS_Click(sender As Object, e As EventArgs) Handles cmdSaveSS.Click

        Dim wrapper As New crypto(txtidmserver.Text & "|||||" & txtoauthclient.Text)
        Dim cipherText As String = wrapper.EncryptData(txtoauthss.Text)
        My.Settings.IDMoAuthSS = cipherText
        My.Settings.Save()

        MsgBox("Setting Saved", MsgBoxStyle.Information, "Setting Saved")

    End Sub

    Private Sub cmdSaveAPIToken_Click(sender As Object, e As EventArgs) Handles cmdSaveAPIToken.Click

        Dim wrapper As New crypto(txtoktaurl.Text & "|||||")
        Dim cipherText As String = wrapper.EncryptData(txtoktahash.Text)
        My.Settings.OktaAPIKey = cipherText
        My.Settings.Save()

        MsgBox("Setting Saved", MsgBoxStyle.Information, "Setting Saved")

    End Sub

    Private Sub cmdRefreshEvents_Click(sender As Object, e As EventArgs) Handles cmdRefreshEvents.Click

        lstoktaevents.Items.Clear()

        read_event_Logs()



    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        If MsgBox("Are you sure you want to Exit?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Exit?") = vbYes Then

            End

        End If

    End Sub

    Private Sub txtoktahash_TextChanged(sender As Object, e As EventArgs) Handles txtoktahash.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

        Dim wrapper As New crypto("test")
        Dim cipherText As String = wrapper.EncryptData(txtoktahash.Text)

        MsgBox(cipherText)


        Dim newwrapper As New crypto("test")
        Dim newcipherText As String = newwrapper.DecryptData(cipherText)

        MsgBox(newcipherText)


    End Sub

    Private Sub cmdHCFix_Click(sender As Object, e As EventArgs) Handles cmdHCFix.Click


        Dim newuri As Uri

        Dim stenant As String = InputBox("Enter name of the tenant to fix", "Tenant Name")

        newuri = New Uri(txtidmserver.Text & "/SAAS/jersey/manager/api/tenants/settings?tenantId=" & stenant)
        getdata_vidm(newuri, "application/vnd.vmware.horizon.manager.tenants.tenant.config+json", "PUT", "HC_FIX")


    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class
