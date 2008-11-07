#Region "Includes"
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports MbUnit.Framework
Imports NoNamespace
#End Region

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Copyright 2008 (c) by Rosas&Olavide All Rights Reserved.
'  
' Project:      
' Module:       Form1Test.vb
' Description:  Tests for the Form 1 class in the FARMACIASJ assembly.
'  
' Date:       Author:           Comments:
' 02/11/2008 11:12 p.m.  jeraro     Module created.
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''' 
Namespace NoNamespaceTest
    
    ''' <summary>
    ''' Tests for the Form 1 Class
    ''' Documentation: 
    ''' </summary>
    ''' <remarks></remarks>
    <TestFixture(), Description("Tests for Form 1")> _
    Public Class Form1Test
#Region "Class Variables"
        'Class Variables
        Private _form1 As Form1 = Nothing
#End Region

#Region "Setup/Cleanup"
        ''' <summary>
        ''' Code that is run before each test
        ''' </summary>
        ''' <remarks></remarks>
        <SetUp()> _
        Public Sub Initialize()
            'New instance of Form 1
            _form1 = New Form1()
        End Sub

        ''' <summary>
        ''' Code that is run after each test
        ''' </summary>
        ''' <remarks></remarks>
        <TearDown()> _
        Public Sub Cleanup()
            'TODO: Put dispose in here for _form1 or delete this line
        End Sub
#End Region

#Region "Property Tests"
        'No public properties were found. No tests are generated for non-public scoped properties.
#End Region

#Region "Method Tests"

        'No public methods were found. No tests are generated for non-public scoped methods.
#End Region

    End Class
End Namespace
