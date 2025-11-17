



Imports jft.Academia.v01.Core.EntitiesViews
Imports jft.Academia.v01.Core.Entities
Imports jft.Academia.v01.Core.Entities.Interfaces
Imports jft.Academia.v01.Infra01.Data.Common

Namespace Data
    Namespace Repositorys


        Public Class AtividadesReporitory
            Inherits BaseRepository(Of Atividades, AtividadesModel)
            Implements IDataStoreAsync(Of Atividades)

            Public Sub New()

            End Sub




            Public Overloads Function SaveItemAsync(item As Atividades) As Task(Of Boolean) Implements IDataStoreAsync(Of Atividades).SaveItemAsync

                If (item.id_atividade > 0) Then
                    Return MyBase.UpdateItemAsync(item)
                Else
                    Return MyBase.AddItemAsync(item)
                End If


            End Function

            Public Overloads Function GetItemAsync(id As Integer) As Task(Of Atividades) Implements IDataStoreAsync(Of Atividades).GetItemAsync
                ' Throw New NotImplementedException()



                'Dim _r = MyBase._databaseAsync.Table(Of Atividades)().Where(Function(i) i.id_atividade = id).FirstOrDefaultAsync().Result


                '_r.A

                Return MyBase._databaseAsync.Table(Of Atividades)().Where(Function(i) i.id_atividade = id).FirstOrDefaultAsync()
            End Function




        End Class
    End Namespace
End Namespace