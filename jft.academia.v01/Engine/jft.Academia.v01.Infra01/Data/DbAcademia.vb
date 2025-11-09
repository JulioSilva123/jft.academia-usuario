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



    End Class


End Namespace