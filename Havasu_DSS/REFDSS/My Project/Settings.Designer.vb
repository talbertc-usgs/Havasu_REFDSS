﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34209
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Z:\asb\HavasuNWR\DSS_Tools\HavasuDSS\InitialData\Inputs")>  _
        Public Property InputDataDirectory() As String
            Get
                Return CType(Me("InputDataDirectory"),String)
            End Get
            Set
                Me("InputDataDirectory") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("NA")>  _
        Public Property OutputDataDirectory() As String
            Get
                Return CType(Me("OutputDataDirectory"),String)
            End Get
            Set
                Me("OutputDataDirectory") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("NA")>  _
        Public Property ConfigXML() As String
            Get
                Return CType(Me("ConfigXML"),String)
            End Get
            Set
                Me("ConfigXML") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("NA")>  _
        Public Property SQliteDB() As String
            Get
                Return CType(Me("SQliteDB"),String)
            End Get
            Set
                Me("SQliteDB") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property RelativePaths() As Boolean
            Get
                Return CType(Me("RelativePaths"),Boolean)
            End Get
            Set
                Me("RelativePaths") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Havasu River Decision Support System")>  _
        Public Property ApplicationTitle() As String
            Get
                Return CType(Me("ApplicationTitle"),String)
            End Get
            Set
                Me("ApplicationTitle") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Welcome to the Havasu REFDSS")>  _
        Public Property WelcomeTitle() As String
            Get
                Return CType(Me("WelcomeTitle"),String)
            End Get
            Set
                Me("WelcomeTitle") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property verbose() As Boolean
            Get
                Return CType(Me("verbose"),Boolean)
            End Get
            Set
                Me("verbose") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Z:\asb\HavasuNWR\DSS_Tools\HavasuDSS\InitialData\DefaultSessionDirectoryWorkingCo"& _ 
            "py")>  _
        Public Property SessionDirectory() As String
            Get
                Return CType(Me("SessionDirectory"),String)
            End Get
            Set
                Me("SessionDirectory") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://www.sciencebase.gov/catalog/file/get/55ad349ce4b066a2492409b3?name=InputD"& _ 
            "ataBare.zip")>  _
        Public Property SB_bareInputs() As String
            Get
                Return CType(Me("SB_bareInputs"),String)
            End Get
            Set
                Me("SB_bareInputs") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://www.sciencebase.gov/catalog/file/get/55ad4637e4b066a249242168?name=Backgr"& _ 
            "ound_nc1m.tif")>  _
        Public Property SB_Background() As String
            Get
                Return CType(Me("SB_Background"),String)
            End Get
            Set
                Me("SB_Background") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://www.sciencebase.gov/catalog/file/get/55ad531be4b066a249242173?name=inputs"& _ 
            "_compressed.zip")>  _
        Public Property SB_InputRasters() As String
            Get
                Return CType(Me("SB_InputRasters"),String)
            End Get
            Set
                Me("SB_InputRasters") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://www.sciencebase.gov/catalog/folder/55ad3417e4b066a2492409ad")>  _
        Public Property SB_Home() As String
            Get
                Return CType(Me("SB_Home"),String)
            End Get
            Set
                Me("SB_Home") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://www.sciencebase.gov/catalog/file/get/55ad587be4b066a249242180?f=__disk__c"& _ 
            "2%2Fe0%2F2d%2Fc2e02d61ee7cd5b18871eb6f9ea7e4449be91352")>  _
        Public Property SB_Full() As String
            Get
                Return CType(Me("SB_Full"),String)
            End Get
            Set
                Me("SB_Full") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public ReadOnly Property db_version() As Integer
            Get
                Return CType(Me("db_version"),Integer)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public ReadOnly Property xml_version() As Integer
            Get
                Return CType(Me("xml_version"),Integer)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://www.sciencebase.gov/catalog/file/get/55c0dae5e4b033ef5210449b?name=REFDSS"& _ 
            "_data.sqlite")>  _
        Public ReadOnly Property db_SB() As String
            Get
                Return CType(Me("db_SB"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://www.sciencebase.gov/catalog/file/get/55c27821e4b033ef5210682e?name=config"& _ 
            ".xml")>  _
        Public ReadOnly Property xml_SB() As String
            Get
                Return CType(Me("xml_SB"),String)
            End Get
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.Havasu_REFDSS.My.MySettings
            Get
                Return Global.Havasu_REFDSS.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
