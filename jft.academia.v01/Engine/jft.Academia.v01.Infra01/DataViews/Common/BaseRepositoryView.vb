


Imports System.ComponentModel
Imports jft.Academia.v01.Core.Entities
Imports jft.Academia.v01.Core.Entities.Interfaces
Imports jft.Academia.v01.Core.EntitiesViews
Imports jft.Academia.v01.Infra01.Data
Imports SQLite

Namespace DataViews


    Namespace Common


        Public Class BaseRepositoryView(Of TEntity As {Class, New}, TEntityView As {Class, New})
            Inherits BaseDataRepository(Of TEntity, TEntityView)
            Implements IDataStoreViewAsync(Of TEntity, TEntityView)




            Public Sub New()

                _dbAcademia = New DbAcademia()
                _dbAcademiaViews = New DbAcademiaViews()

            End Sub



            'var dbAcademia = new DbAcademia();
            Private _dbAcademia As DbAcademia
            Public ReadOnly Property dbAcademia As DbAcademia
                Get
                    Return _dbAcademia
                End Get
                'set { SetProperty(ref _isBusy, value); }
            End Property

            Private _dbAcademiaViews As DbAcademiaViews
            Public ReadOnly Property dbAcademiaViews As DbAcademiaViews
                Get
                    Return _dbAcademiaViews
                End Get
                'set { SetProperty(ref _isBusy, value); }
            End Property





            Public Function GetViewItemsAsync(Optional forceRefresh As Boolean = False) As Task(Of List(Of TEntityView)) Implements IDataStoreViewAsync(Of TEntity, TEntityView).GetViewItemsAsync
                Throw New NotImplementedException()
            End Function




            Public Function GetViewItemAsync(id As Integer) As Task(Of TEntityView) Implements IDataStoreViewAsync(Of TEntity, TEntityView).GetViewItemAsync
                Throw New NotImplementedException()
            End Function

            Public Function GetEntityToModelAsync(_entity As TEntity) As Task(Of TEntityView) Implements IDataStoreViewAsync(Of TEntity, TEntityView).GetEntityToModelAsync
                Throw New NotImplementedException()
            End Function

            Public Function GetModelToEntityAsync(_entityModel As TEntityView) As Task(Of TEntity) Implements IDataStoreViewAsync(Of TEntity, TEntityView).GetModelToEntityAsync
                Throw New NotImplementedException()
            End Function

            Public Function SaveViewItemAsync(item As TEntityView) As Task(Of Boolean) Implements IDataStoreViewAsync(Of TEntity, TEntityView).SaveViewItemAsync
                Throw New NotImplementedException()
            End Function

            Public Function DeleteViewItemAsync(item As TEntityView) As Task(Of Boolean) Implements IDataStoreViewAsync(Of TEntity, TEntityView).DeleteViewItemAsync
                Throw New NotImplementedException()
            End Function

            Public Function GetQueryViewAsync(_select As String, _from As String, _where As String) As Task(Of List(Of TEntityView)) Implements IDataStoreViewAsync(Of TEntity, TEntityView).GetQueryViewAsync
                'Throw New NotImplementedException()
                'Throw New NotImplementedException()

                Dim _sql As String = String.Format("SELECT {0} FROM {1} WHERE {2}", _select, _from, _where)

                Dim _result = _databaseAsync.QueryAsync(Of TEntity)(_sql) _
                    .ContinueWith(Function(t)

                                      Dim lista = t.Result
                                      Dim listAtividadesView = New List(Of TEntityView)()

                                      For Each _item In lista
                                          'var _atividade = this.dbAcademiaViews.Atividades.GetViewItemAsync(atividade.id_atividade).Result;
                                          'var _grupos = this.dbAcademiaViews.Grupos.GetViewItemAsync(atividade.id_grupo_atividade).Result;
                                          '''var _tipoatividade = dataTiposAtividades.GetItemAsync(atividade.id_tipo_atividade);

                                          Dim _view = GetEntityToModelAsync(CType(_item, TEntity)).Result

                                          listAtividadesView.Add(_view)

                                      Next

                                      Return listAtividadesView
                                  End Function)


                Return _result


                ' Return _databaseAsync.QueryAsync(Of TEntityView)(_sql)


            End Function






            'Public Function GetItemsAsync(Optional forceRefresh As Boolean = False) As Task(Of List(Of TEntity)) Implements IDataStoreViewAsync(Of TEntity, TEntityView).GetItemsAsync
            '    Return _databaseAsync.Table(Of TEntity)().ToListAsync()
            'End Function
            'Public Async Function GetItemsAsyncEnumerable(Optional forceRefresh As Boolean = False) As Task(Of IEnumerable(Of TEntity)) Implements IDataStoreViewAsync(Of TEntity, TEntityView).GetItemsAsyncEnumerable
            '    Return Await _databaseAsync.Table(Of TEntity)().ToListAsync()
            'End Function

            'Public Function GetItemAsync(id As Integer) As Task(Of TEntity) Implements IDataStoreViewAsync(Of TEntity, TEntityView).GetItemAsync
            '    Throw New NotImplementedException()
            'End Function





            'Public Function UpdateItemAsync(item As TEntity) As Task(Of Boolean) Implements IDataStoreViewAsync(Of TEntity, TEntityView).UpdateItemAsync
            '    _databaseAsync.UpdateAsync(item)
            '    Return Task.FromResult(True)

            'End Function

            'Public Function AddItemAsync(item As TEntity) As Task(Of Boolean) Implements IDataStoreViewAsync(Of TEntity, TEntityView).AddItemAsync
            '    _databaseAsync.InsertAsync(item)
            '    Return Task.FromResult(True)
            'End Function

            'Public Function DeleteItemAsync(item As TEntity) As Task(Of Boolean) Implements IDataStoreViewAsync(Of TEntity, TEntityView).DeleteItemAsync
            '    _databaseAsync.DeleteAsync(item)
            '    Return Task.FromResult(True)
            'End Function

            'Public Function SaveItemAsync(item As TEntity) As Task(Of Boolean) Implements IDataStoreViewAsync(Of TEntity, TEntityView).SaveItemAsync
            '    Throw New NotImplementedException()
            'End Function
        End Class


    End Namespace

End Namespace