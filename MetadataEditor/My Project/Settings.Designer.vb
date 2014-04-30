﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.17929
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0"),  _
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
         Global.System.Configuration.DefaultSettingValueAttribute("en-US.dic")>  _
        Public Property DictionaryFile() As String
            Get
                Return CType(Me("DictionaryFile"),String)
            End Get
            Set
                Me("DictionaryFile") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property DictionaryFolder() As String
            Get
                Return CType(Me("DictionaryFolder"),String)
            End Get
            Set
                Me("DictionaryFolder") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property EnableUserFile() As Boolean
            Get
                Return CType(Me("EnableUserFile"),Boolean)
            End Get
            Set
                Me("EnableUserFile") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("user.dic")>  _
        Public Property UserFile() As String
            Get
                Return CType(Me("UserFile"),String)
            End Get
            Set
                Me("UserFile") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("c:\windows")>  _
        Public Property HHPath() As String
            Get
                Return CType(Me("HHPath"),String)
            End Get
            Set
                Me("HHPath") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("30")>  _
        Public Property ValidationTimeout() As Integer
            Get
                Return CType(Me("ValidationTimeout"),Integer)
            End Get
            Set
                Me("ValidationTimeout") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property ValidationEnabled() As Boolean
            Get
                Return CType(Me("ValidationEnabled"),Boolean)
            End Get
            Set
                Me("ValidationEnabled") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property SyncAttrInfo() As Boolean
            Get
                Return CType(Me("SyncAttrInfo"),Boolean)
            End Get
            Set
                Me("SyncAttrInfo") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property SyncOnlink() As Boolean
            Get
                Return CType(Me("SyncOnlink"),Boolean)
            End Get
            Set
                Me("SyncOnlink") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property SyncProcSteps() As Boolean
            Get
                Return CType(Me("SyncProcSteps"),Boolean)
            End Get
            Set
                Me("SyncProcSteps") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property SyncCSI() As Boolean
            Get
                Return CType(Me("SyncCSI"),Boolean)
            End Get
            Set
                Me("SyncCSI") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property SyncExtent() As Boolean
            Get
                Return CType(Me("SyncExtent"),Boolean)
            End Get
            Set
                Me("SyncExtent") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property SelectedTabIndexSync() As Integer
            Get
                Return CType(Me("SelectedTabIndexSync"),Integer)
            End Get
            Set
                Me("SelectedTabIndexSync") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property SelectedTabIndex() As Integer
            Get
                Return CType(Me("SelectedTabIndex"),Integer)
            End Get
            Set
                Me("SelectedTabIndex") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property FindString() As String
            Get
                Return CType(Me("FindString"),String)
            End Get
            Set
                Me("FindString") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property ReplaceString() As String
            Get
                Return CType(Me("ReplaceString"),String)
            End Get
            Set
                Me("ReplaceString") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property SelectedTabIndexKeywords() As Integer
            Get
                Return CType(Me("SelectedTabIndexKeywords"),Integer)
            End Get
            Set
                Me("SelectedTabIndexKeywords") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property SelectedTabIndexEntityAttr() As Integer
            Get
                Return CType(Me("SelectedTabIndexEntityAttr"),Integer)
            End Get
            Set
                Me("SelectedTabIndexEntityAttr") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property ViewValidationResultsInEME() As Boolean
            Get
                Return CType(Me("ViewValidationResultsInEME"),Boolean)
            End Get
            Set
                Me("ViewValidationResultsInEME") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property ViewValidationResultsInBrowser() As Boolean
            Get
                Return CType(Me("ViewValidationResultsInBrowser"),Boolean)
            End Get
            Set
                Me("ViewValidationResultsInBrowser") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("FulllyQualifiedPathnameOfYourMdbFileHere")>  _
        Public Property MdbFilepathname() As String
            Get
                Return CType(Me("MdbFilepathname"),String)
            End Get
            Set
                Me("MdbFilepathname") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0.7")>  _
        Public Property EditorFormOpacityOnResize() As Single
            Get
                Return CType(Me("EditorFormOpacityOnResize"),Single)
            End Get
            Set
                Me("EditorFormOpacityOnResize") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property WipeEsriTagsOnSync() As Boolean
            Get
                Return CType(Me("WipeEsriTagsOnSync"),Boolean)
            End Get
            Set
                Me("WipeEsriTagsOnSync") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("MME")>  _
        Public Property CommonEditorAbbreviation() As String
            Get
                Return CType(Me("CommonEditorAbbreviation"),String)
            End Get
            Set
                Me("CommonEditorAbbreviation") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("MnGeo")>  _
        Public Property CommonAgencyAbbreviation() As String
            Get
                Return CType(Me("CommonAgencyAbbreviation"),String)
            End Get
            Set
                Me("CommonAgencyAbbreviation") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property AgencyValidationEnabled() As Boolean
            Get
                Return CType(Me("AgencyValidationEnabled"),Boolean)
            End Get
            Set
                Me("AgencyValidationEnabled") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("23")>  _
        Public Property ReleaseNo() As String
            Get
                Return CType(Me("ReleaseNo"),String)
            End Get
            Set
                Me("ReleaseNo") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\metadata.mdb;Persist"& _ 
            " Security Info=True")>  _
        Public ReadOnly Property metadataConnectionString() As String
            Get
                Return CType(Me("metadataConnectionString"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property RetainPublishedDocID() As Boolean
            Get
                Return CType(Me("RetainPublishedDocID"),Boolean)
            End Get
            Set
                Me("RetainPublishedDocID") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property ValidationURL() As String
            Get
                Return CType(Me("ValidationURL"),String)
            End Get
            Set
                Me("ValidationURL") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.MetadataEditor.My.MySettings
            Get
                Return Global.MetadataEditor.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
