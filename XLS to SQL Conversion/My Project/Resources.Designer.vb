﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18034
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("XLS_to_SQL_Conversion.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property Delete_Example() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("Delete_Example", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property Insert_Example() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("Insert_Example", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property ss() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("ss", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to CREATE TABLE Test_Table_Excel_SQL(Key1 int,Col1_NotNull varchar(255) not null,Col2_NotNull varchar(255) not null,Col3 varchar(255),Col4 varchar(255),Col5 varchar(255),Col6 varchar(255),Col7 varchar(255)) 
        '''
        '''INSERT INTO Test_Table_Excel_SQL VALUES (1,11,22,33,44,55,66,77)
        '''INSERT INTO Test_Table_Excel_SQL VALUES (2,12,23,34,45,56,67,78)
        '''INSERT INTO Test_Table_Excel_SQL VALUES (3,13,24,35,46,57,68,79)
        '''INSERT INTO Test_Table_Excel_SQL VALUES (4,14,25,36,47,58,69,80)
        '''INSERT INTO Test_Table_Excel_SQL VALUES  [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property Test_Install_sql() As String
            Get
                Return ResourceManager.GetString("Test_Install.sql", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property Update_Example() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("Update_Example", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
    End Module
End Namespace
