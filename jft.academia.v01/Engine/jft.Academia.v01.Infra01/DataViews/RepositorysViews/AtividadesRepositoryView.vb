Imports jft.Academia.v01.Core.Entities
Imports jft.Academia.v01.Core.Entities.Interfaces
Imports jft.Academia.v01.Core.EntitiesViews
Imports jft.Academia.v01.Infra01.DataViews.Common

Namespace DataViews



    Namespace RepositorysViews



        Public Class AtividadesRepositoryView
            Inherits BaseRepositoryView(Of Atividades, AtividadesModel)
            Implements IDataStoreViewAsync(Of Atividades, AtividadesModel)



            'Public Function DeleteViewItemAsync(item As AtividadesModel) As Task(Of Boolean) Implements IDataStoreViewAsync(Of Atividades, AtividadesModel).DeleteViewItemAsync
            '    Throw New NotImplementedException()
            'End Function

            Public Overloads Function GetEntityToModelAsync(_entity As Atividades) As Task(Of AtividadesModel) Implements IDataStoreViewAsync(Of Atividades, AtividadesModel).GetEntityToModelAsync

                Dim _r = New AtividadesModel With {
                    .id_atividade = _entity.id_atividade,
                    .nm_atividade = _entity.nm_atividade,
                    .te_descricao = _entity.te_descricao
                }

                Return Task.FromResult(_r)

            End Function

            'Public Function GetModelToEntityAsync(_entityModel As AtividadesModel) As Task(Of Atividades) Implements IDataStoreViewAsync(Of Atividades, AtividadesModel).GetModelToEntityAsync
            '    Throw New NotImplementedException()
            'End Function

            Public Overloads Function GetViewItemAsync(id As Integer) As Task(Of AtividadesModel) Implements IDataStoreViewAsync(Of Atividades, AtividadesModel).GetViewItemAsync

                Dim _result = Me.dbAcademia.Atividades.GetItemAsync(id).Result
                Return Me.GetEntityToModelAsync(_result)

            End Function

            Public Overloads Function GetViewItemsAsync(Optional forceRefresh As Boolean = False) As Task(Of List(Of AtividadesModel)) Implements IDataStoreViewAsync(Of Atividades, AtividadesModel).GetViewItemsAsync


                Dim _result = Me.dbAcademia.Atividades _
                    .GetItemsAsync().ContinueWith(Function(t)

                                                      Dim atividades = t.Result
                                                      Dim listAtividadesView = New List(Of AtividadesModel)()

                                                      For Each _item In atividades
                                                          Dim _view = GetEntityToModelAsync(CType(_item, Atividades)).Result
                                                          listAtividadesView.Add(_view)
                                                      Next
                                                      Return listAtividadesView
                                                  End Function)


                Return _result


            End Function

            'Public Function SaveViewItemAsync(item As AtividadesModel) As Task(Of Boolean) Implements IDataStoreViewAsync(Of Atividades, AtividadesModel).SaveViewItemAsync
            '    Throw New NotImplementedException()
            'End Function

        End Class

    End Namespace

End Namespace