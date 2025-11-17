Public Class GruposModel


    Public Sub New()
        Atividades_Grupos = New HashSet(Of Atividades_GruposModel)()
    End Sub


    Public Property id_grupo_atividade As Integer
    Public Property nm_grupo_atividade As String


    Public Overridable Property Atividades_Grupos As ICollection(Of Atividades_GruposModel)


End Class
