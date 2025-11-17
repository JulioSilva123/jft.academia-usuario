Public Class AtividadesModel


    Public Sub New()
        Atividades_Grupos = New HashSet(Of Atividades_GruposModel)()
        Itens_Atividade = New HashSet(Of Itens_AtividadeModel)()
    End Sub


    Public Property id_atividade As Integer

    Public Property nm_atividade As String

    Public Property te_descricao As String

    Public Overridable Property Atividades_Grupos As ICollection(Of Atividades_GruposModel)
    Public Overridable Property Itens_Atividade As ICollection(Of Itens_AtividadeModel)


End Class
