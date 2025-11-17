Public Class Atividades_GruposModel
    Public Sub New()
        'Atividades = New AtividadesModel()
        'Grupos = New GruposModel()
    End Sub


    Public Property id_atividade_grupo As Integer
    'public int id_atividade { get; set; }

    Public Property Atividades As AtividadesModel

    'public int id_grupo_atividade { get; set; }

    Public Property Grupos As GruposModel


    Public Property nr_ordem As Integer
    Public Property te_descricao As String

End Class
