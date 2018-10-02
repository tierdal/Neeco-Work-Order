Module GlobalFunctions

    Public appPath As String
    Public wo_working_dir As String
    Public cust_working_dir As String
    Public vend_working_dir As String

    Public Sub getAppPath()
        'gets the start up path of the application

        appPath = Application.StartupPath()

    End Sub

    Public Sub setWOworkingDIR()
        'sets location of work order folders
        wo_working_dir = "\\ad.neecovalves.com\Local File Server\Work Orders\"
    End Sub

    Public Sub setCUSTworkingDIR()
        'sets location of client folders
        cust_working_dir = "\\ad.neecovalves.com\Local File Server\Customer Folders\"
    End Sub

    Public Sub setVENDworkingDIR()
        'sets location of vendor folders
        vend_working_dir = "\\ad.neecovalves.com\Local File Server\Vendor Folders\"
    End Sub

End Module
