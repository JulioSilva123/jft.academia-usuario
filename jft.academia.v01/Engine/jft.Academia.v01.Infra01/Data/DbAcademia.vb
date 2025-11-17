Imports jft.Academia.v01.Infra01.Data.Repositorys

Namespace Data


    Public Class DbAcademia


        Public Sub New()

        End Sub



        Private _Grupos As GruposReporitory
        Public ReadOnly Property Grupos As GruposReporitory
            Get
                If _Grupos Is Nothing Then
                    _Grupos = New GruposReporitory()
                End If

                Return _Grupos

            End Get
        End Property


        Private _Atividades As AtividadesReporitory
        Public ReadOnly Property Atividades As AtividadesReporitory
            Get
                If _Atividades Is Nothing Then
                    _Atividades = New AtividadesReporitory()
                End If

                Return _Atividades

            End Get
        End Property


        Private _Atividades_Grupos As Atividades_GruposReporitory
        Public ReadOnly Property Atividades_Grupos As Atividades_GruposReporitory
            Get
                If _Atividades_Grupos Is Nothing Then
                    _Atividades_Grupos = New Atividades_GruposReporitory()
                End If

                Return _Atividades_Grupos

            End Get
        End Property


        Private _Itens_Atividade As Itens_AtividadeRepository
        Public ReadOnly Property Itens_Atividade As Itens_AtividadeRepository
            Get
                If _Itens_Atividade Is Nothing Then
                    _Itens_Atividade = New Itens_AtividadeRepository()
                End If

                Return _Itens_Atividade

            End Get
        End Property



    End Class


End Namespace