'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class mn_composer
    Public Property idComposer As String
    Public Property name As String
    Public Property urlSource As String
    Public Property lastUpdated As Date
    Public Property begin_date As Nullable(Of Date)
    Public Property end_date As Nullable(Of Date)
    Public Property ranking As Nullable(Of Integer)
    Public Property biography As String

    Public Overridable Property mn_composer_rel As ICollection(Of mn_composer_rel) = New HashSet(Of mn_composer_rel)

End Class