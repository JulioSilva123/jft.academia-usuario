Imports jft.Academia.v01.Core.Entities
Imports jft.Academia.v01.Core.Entities.Interfaces
Imports jft.Academia.v01.Core.EntitiesViews
Imports jft.Academia.v01.Infra01.DataViews.Common

Namespace DataViews



    Namespace RepositorysViews



        Public Class GruposRepositoryView
            Inherits BaseRepositoryView(Of Grupos, GruposModel)
            Implements IDataStoreViewAsync(Of Grupos, GruposModel)





            'Public Function DeleteViewItemAsync(item As GruposModel) As Task(Of Boolean) Implements IDataStoreViewAsync(Of Grupos, GruposModel).DeleteViewItemAsync
            '    Throw New NotImplementedException()
            'End Function

            Public Overloads Function GetEntityToModelAsync(_entity As Grupos) As Task(Of GruposModel) Implements IDataStoreViewAsync(Of Grupos, GruposModel).GetEntityToModelAsync
                Dim _r = New GruposModel With {
                    .id_grupo_atividade = _entity.id_grupo_atividade,
                    .nm_grupo_atividade = _entity.nm_grupo_atividade
                }

                Return Task.FromResult(_r)
            End Function

            'Public Function GetModelToEntityAsync(_entityModel As GruposModel) As Task(Of Grupos) Implements IDataStoreViewAsync(Of Grupos, GruposModel).GetModelToEntityAsync
            '    Throw New NotImplementedException()
            'End Function

            Public Overloads Function GetViewItemAsync(id As Integer) As Task(Of GruposModel) Implements IDataStoreViewAsync(Of Grupos, GruposModel).GetViewItemAsync
                Dim _result = Me.dbAcademia.Grupos.GetItemAsync(id).Result


                Return Me.GetEntityToModelAsync(_result)
            End Function

            Public Overloads Function GetViewItemsAsync(Optional forceRefresh As Boolean = False) As Task(Of List(Of GruposModel)) Implements IDataStoreViewAsync(Of Grupos, GruposModel).GetViewItemsAsync


                Dim _result = Me.dbAcademia.Grupos _
                    .GetItemsAsync().ContinueWith(Function(t)

                                                      Dim lista = t.Result
                                                      Dim listAtividadesView = New List(Of GruposModel)()

                                                      For Each _item In lista

                                                          Dim _view = Me.GetEntityToModelAsync(CType(_item, Grupos)).Result
                                                          listAtividadesView.Add(_view)

                                                      Next
                                                      Return listAtividadesView
                                                  End Function)


                Return _result


            End Function

            'Public Function SaveViewItemAsync(item As GruposModel) As Task(Of Boolean) Implements IDataStoreViewAsync(Of Grupos, GruposModel).SaveViewItemAsync
            '    Throw New NotImplementedException()
            'End Function

        End Class


    End Namespace

End Namespace