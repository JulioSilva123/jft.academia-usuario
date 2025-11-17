

Imports jft.Academia.v01.Infra01.Data.Repositorys
Imports jft.Academia.v01.Infra01.DataViews.RepositorysViews

Namespace DataViews

    Public Class DbAcademiaViews



        Public Sub New()
        End Sub


        Private _Grupos As GruposRepositoryView
        Public ReadOnly Property Grupos As GruposRepositoryView
            Get
                If _Grupos Is Nothing Then
                    _Grupos = New GruposRepositoryView()
                End If

                Return _Grupos

            End Get
        End Property



        Private _Atividades As AtividadesRepositoryView
        Public ReadOnly Property Atividades As AtividadesRepositoryView
            Get
                If _Atividades Is Nothing Then
                    _Atividades = New AtividadesRepositoryView()
                End If

                Return _Atividades

            End Get
        End Property


        Private _Atividades_Grupos As Atividades_GruposRepositoryView
        Public ReadOnly Property Atividades_Grupos As Atividades_GruposRepositoryView
            Get
                If _Atividades_Grupos Is Nothing Then
                    _Atividades_Grupos = New Atividades_GruposRepositoryView()
                End If

                Return _Atividades_Grupos

            End Get
        End Property

        Private _Itens_Atividade As Itens_AtividadeRepositoryView
        Public ReadOnly Property Itens_Atividade As Itens_AtividadeRepositoryView
            Get
                If _Itens_Atividade Is Nothing Then
                    _Itens_Atividade = New Itens_AtividadeRepositoryView()
                End If

                Return _Itens_Atividade

            End Get
        End Property

    End Class


End Namespace