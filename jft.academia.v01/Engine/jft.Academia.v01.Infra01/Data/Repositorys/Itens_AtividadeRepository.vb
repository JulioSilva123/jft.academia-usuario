



Imports jft.Academia.v01.Core.EntitiesViews
Imports jft.Academia.v01.Core.Entities
Imports jft.Academia.v01.Core.Entities.Interfaces
Imports jft.Academia.v01.Infra01.Data.Common

Namespace Data
    Namespace Repositorys


        Public Class Itens_AtividadeRepository
            Inherits BaseRepository(Of Itens_Atividade, Itens_AtividadeModel)
            Implements IDataStoreAsync(Of Itens_Atividade)




            Public Sub New()

            End Sub




            Public Overloads Function SaveItemAsync(item As Itens_Atividade) As Task(Of Boolean) Implements IDataStoreAsync(Of Itens_Atividade).SaveItemAsync

                If (item.id_item_atividade > 0) Then
                    Return MyBase.UpdateItemAsync(item)
                Else
                    Return MyBase.AddItemAsync(item)
                End If


            End Function




            Public Overloads Function GetItemAsync(id As Integer) As Task(Of Itens_Atividade) Implements IDataStoreAsync(Of Itens_Atividade).GetItemAsync
                ' Throw New NotImplementedException()
                Return MyBase._databaseAsync.Table(Of Itens_Atividade)().Where(Function(i) i.id_item_atividade = id).FirstOrDefaultAsync()
            End Function




        End Class
    End Namespace
End Namespace