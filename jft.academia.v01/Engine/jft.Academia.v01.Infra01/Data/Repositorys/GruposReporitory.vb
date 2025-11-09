



Imports jft.Academia.v01.Core.Entities
Imports jft.Academia.v01.Core.Entities.Interfaces
Imports jft.Academia.v01.Infra01.Data.Common

Namespace Data
    Namespace Repositorys


        Public Class GruposReporitory
            Inherits BaseRepository(Of Grupos)
            Implements IDataStoreAsync(Of Grupos)

            Public Sub New()

            End Sub




            Public Overloads Function SaveItemAsync(item As Grupos) As Task(Of Boolean) Implements IDataStoreAsync(Of Grupos).SaveItemAsync

                If (item.id_grupo_atividade > 0) Then
                    Return MyBase.UpdateItemAsync(item)
                Else
                    Return MyBase.AddItemAsync(item)
                End If


            End Function

            Public Overloads Function GetItemAsync(id As Integer) As Task(Of Grupos) Implements IDataStoreAsync(Of Grupos).GetItemAsync
                ' Throw New NotImplementedException()
                Return MyBase._databaseAsync.Table(Of Grupos)().Where(Function(i) i.id_grupo_atividade = id).FirstOrDefaultAsync()
            End Function

            'Public Overrides Function SalvarItemAsync(item As Grupos) As Task(Of Boolean)
            '    Throw New NotImplementedException()
            'End Function







            'Public Function GetItemAsync(id As Integer) As Task(Of Grupos) Implements IDataStoreAsync(Of Grupos).GetItemAsync
            '    Return MyBase._databaseAsync.Table(Of Grupos)().Where(CType(Function(i) i.id_grupo_atividade = id, Expressions.Expression(Of Func(Of Grupos, Boolean)))).FirstOrDefaultAsync()
            'End Function



            'Public Function SaveItemAsync(item As Grupos) As Task(Of Boolean) Implements IDataStoreAsync(Of Grupos).SaveItemAsync
            '    If item.id_grupo_atividade <> 0 Then
            '        Return Me.UpdateItemAsync(item)
            '    Else
            '        Return Me.AddItemAsync(item)
            '    End If
            'End Function


        End Class
    End Namespace
End Namespace