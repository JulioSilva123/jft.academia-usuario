Imports SQLite

Public Class Itens_AtividadeModel


    Public Sub New()
        'Atividades = New AtividadesModel()
        'Grupos = New GruposModel()
    End Sub




    '<PrimaryKey, AutoIncrement>
    Public Property id_item_atividade As Integer

    Public Property Atividades As AtividadesModel

    Public Property nr_ordem As Integer

    Public Property nr_posicao_pino As Integer

    Public Property nr_peso As Integer

    Public Property nr_repeticao As Integer

    Public Property te_descricao As String



End Class
