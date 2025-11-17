Imports jft.Academia.v01.Core.Entities
Imports jft.Academia.v01.Core.Entities.Interfaces
Imports jft.Academia.v01.Core.EntitiesViews
Imports jft.Academia.v01.Infra01.DataViews.Common


Namespace DataViews

    Namespace RepositorysViews




        Public Class Atividades_GruposRepositoryView
            Inherits BaseRepositoryView(Of Atividades_Grupos, Atividades_GruposModel)
            Implements IDataStoreViewAsync(Of Atividades_Grupos, Atividades_GruposModel)





            'Public Function DeleteViewItemAsync(item As Atividades_GruposModel) As Task(Of Boolean) Implements IDataStoreViewAsync(Of Atividades_Grupos, Atividades_GruposModel).DeleteViewItemAsync
            '    Throw New NotImplementedException()
            'End Function




            Public Overloads Function GetEntityToModelAsync(_entity As Atividades_Grupos) As Task(Of Atividades_GruposModel) Implements IDataStoreViewAsync(Of Atividades_Grupos, Atividades_GruposModel).GetEntityToModelAsync


                Dim _atividade = MyBase.dbAcademiaViews.Atividades.GetViewItemAsync(_entity.id_atividade).Result
                Dim _grupos = MyBase.dbAcademiaViews.Grupos.GetViewItemAsync(_entity.id_grupo_atividade).Result
                'var _tipoatividade = dataTiposAtividades.GetItemAsync(atividade.id_tipo_atividade);

                Dim _r = New Atividades_GruposModel With {
                    .id_atividade_grupo = _entity.id_atividade_grupo,
                    .Atividades = _atividade,
                    .Grupos = _grupos,
                    .nr_ordem = _entity.nr_ordem,
                    .te_descricao = _entity.te_descricao
                }

                Return Task.FromResult(_r)


            End Function

            Public Overloads Function GetModelToEntityAsync(_entityModel As Atividades_GruposModel) As Task(Of Atividades_Grupos) Implements IDataStoreViewAsync(Of Atividades_Grupos, Atividades_GruposModel).GetModelToEntityAsync


                Dim _r = New Atividades_Grupos With {
                    .id_atividade_grupo = _entityModel.id_atividade_grupo,
                    .id_atividade = _entityModel.Atividades.id_atividade,
                    .id_grupo_atividade = _entityModel.Grupos.id_grupo_atividade,
                    .nr_ordem = _entityModel.nr_ordem,
                    .te_descricao = _entityModel.te_descricao
                }

                Return Task.FromResult(_r)

            End Function

            'Public Function GetViewItemAsync(id As Integer) As Task(Of Atividades_GruposModel) Implements IDataStoreViewAsync(Of Atividades_Grupos, Atividades_GruposModel).GetViewItemAsync
            '    Throw New NotImplementedException()
            'End Function

            Public Overloads Function GetViewItemsAsync(Optional forceRefresh As Boolean = False) As Task(Of List(Of Atividades_GruposModel)) Implements IDataStoreViewAsync(Of Atividades_Grupos, Atividades_GruposModel).GetViewItemsAsync

                Dim _result = Me.dbAcademia.Atividades_Grupos _
                    .GetItemsAsync().ContinueWith(Function(t)

                                                      Dim lista = t.Result
                                                      Dim listAtividadesView = New List(Of Atividades_GruposModel)()

                                                      For Each _item In lista
                                                          'var _atividade = this.dbAcademiaViews.Atividades.GetViewItemAsync(atividade.id_atividade).Result;
                                                          'var _grupos = this.dbAcademiaViews.Grupos.GetViewItemAsync(atividade.id_grupo_atividade).Result;
                                                          '''var _tipoatividade = dataTiposAtividades.GetItemAsync(atividade.id_tipo_atividade);

                                                          Dim _view = GetEntityToModelAsync(CType(_item, Atividades_Grupos)).Result
                                                          listAtividadesView.Add(_view)
                                                      Next
                                                      Return listAtividadesView
                                                  End Function)


                Return _result


            End Function

            'Public Function SaveViewItemAsync(item As Atividades_GruposModel) As Task(Of Boolean) Implements IDataStoreViewAsync(Of Atividades_Grupos, Atividades_GruposModel).SaveViewItemAsync
            '    Throw New NotImplementedException()
            'End Function



        End Class


    End Namespace

End Namespace