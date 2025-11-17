Imports jft.Academia.v01.Core.Entities
Imports jft.Academia.v01.Core.Entities.Interfaces
Imports jft.Academia.v01.Core.EntitiesViews
Imports jft.Academia.v01.Infra01.DataViews.Common

Namespace DataViews



    Namespace RepositorysViews



        Public Class Itens_AtividadeRepositoryView
            Inherits BaseRepositoryView(Of Itens_Atividade, Itens_AtividadeModel)
            Implements IDataStoreViewAsync(Of Itens_Atividade, Itens_AtividadeModel)


            Public Overloads Function GetModelToEntityAsync(_entityModel As Itens_AtividadeModel) As Task(Of Itens_Atividade) Implements IDataStoreViewAsync(Of Itens_Atividade, Itens_AtividadeModel).GetModelToEntityAsync


                Dim _r = New Itens_Atividade With {
                    .id_item_atividade = _entityModel.id_item_atividade,
                    .id_atividade = _entityModel.Atividades.id_atividade,
                    .nr_ordem = _entityModel.nr_ordem,
                    .nr_posicao_pino = _entityModel.nr_posicao_pino,
                    .nr_peso = _entityModel.nr_peso,
                    .nr_repeticao = _entityModel.nr_repeticao,
                    .te_descricao = _entityModel.te_descricao
                }

                Return Task.FromResult(_r)

            End Function

            Public Overloads Function GetEntityToModelAsync(_entity As Itens_Atividade) As Task(Of Itens_AtividadeModel) Implements IDataStoreViewAsync(Of Itens_Atividade, Itens_AtividadeModel).GetEntityToModelAsync


                Dim _atividade = MyBase.dbAcademiaViews.Atividades.GetViewItemAsync(_entity.id_atividade).Result

                Dim _r = New Itens_AtividadeModel With {
                    .Atividades = _atividade,
                    .id_item_atividade = _entity.id_item_atividade,
                    .nr_ordem = _entity.nr_ordem,
                    .nr_posicao_pino = _entity.nr_posicao_pino,
                    .nr_peso = _entity.nr_peso,
                    .nr_repeticao = _entity.nr_repeticao,
                    .te_descricao = _entity.te_descricao
                }

                Return Task.FromResult(_r)


            End Function


            Public Overloads Function GetViewItemAsync(id As Integer) As Task(Of Itens_AtividadeModel) Implements IDataStoreViewAsync(Of Itens_Atividade, Itens_AtividadeModel).GetViewItemAsync
                Dim _result = Me.dbAcademia.Itens_Atividade.GetItemAsync(id).Result


                Return Me.GetEntityToModelAsync(_result)
            End Function

            Public Overloads Function GetViewItemsAsync(Optional forceRefresh As Boolean = False) As Task(Of List(Of Itens_AtividadeModel)) Implements IDataStoreViewAsync(Of Itens_Atividade, Itens_AtividadeModel).GetViewItemsAsync


                Dim _result = Me.dbAcademia.Itens_Atividade _
                    .GetItemsAsync().ContinueWith(Function(t)

                                                      Dim lista = t.Result
                                                      Dim listAtividadesView = New List(Of Itens_AtividadeModel)()

                                                      For Each _item In lista

                                                          Dim _view = Me.GetEntityToModelAsync(CType(_item, Itens_Atividade)).Result
                                                          listAtividadesView.Add(_view)

                                                      Next
                                                      Return listAtividadesView
                                                  End Function)


                Return _result


            End Function

            'Public Function SaveViewItemAsync(item As Itens_AtividadeModel) As Task(Of Boolean) Implements IDataStoreViewAsync(Of Itens_Atividade, Itens_AtividadeModel).SaveViewItemAsync
            '    Throw New NotImplementedException()
            'End Function

        End Class


    End Namespace

End Namespace