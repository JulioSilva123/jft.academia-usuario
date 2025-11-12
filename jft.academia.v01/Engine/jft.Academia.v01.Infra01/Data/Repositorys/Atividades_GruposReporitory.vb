



Imports jft.Academia.v01.Core.Entities
Imports jft.Academia.v01.Core.Entities.Interfaces
Imports jft.Academia.v01.Infra01.Data.Common

Namespace Data
    Namespace Repositorys


        Public Class Atividades_GruposReporitory
            Inherits BaseRepository(Of Atividades_Grupos)
            Implements IDataStoreAsync(Of Atividades_Grupos)

            Public Sub New()

            End Sub




            Public Overloads Function SaveItemAsync(item As Atividades_Grupos) As Task(Of Boolean) Implements IDataStoreAsync(Of Atividades_Grupos).SaveItemAsync

                If (item.id_atividade > 0) Then
                    Return MyBase.UpdateItemAsync(item)
                Else
                    Return MyBase.AddItemAsync(item)
                End If


            End Function

            Public Overloads Function GetItemAsync(id As Integer) As Task(Of Atividades_Grupos) Implements IDataStoreAsync(Of Atividades_Grupos).GetItemAsync
                Return MyBase._databaseAsync.Table(Of Atividades_Grupos)().Where(Function(i) i.id_atividade_grupo = id).FirstOrDefaultAsync()
            End Function



        End Class
    End Namespace
End Namespace