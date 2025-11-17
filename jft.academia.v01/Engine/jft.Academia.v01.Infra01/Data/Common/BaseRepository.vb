


Imports jft.Academia.v01.Core.Entities
Imports jft.Academia.v01.Core.Entities.Interfaces
Imports SQLite

Namespace Data


    Namespace Common



        Public MustInherit Class BaseRepository(Of TEntity As {Class, New}, TEntityView)
            Inherits BaseDataRepository(Of TEntity, TEntityView)
            Implements IDataStoreAsync(Of TEntity)



            Public Sub New()

            End Sub






            Public Function GetItems(Optional forceRefresh As Boolean = False) As List(Of TEntity)
                Return MyBase._database.Table(Of TEntity)().ToList()
            End Function







#Region "Async"

            Public Function GetItemsAsync(Optional forceRefresh As Boolean = False) As Task(Of List(Of TEntity)) Implements IDataStoreAsync(Of TEntity).GetItemsAsync
                Return _databaseAsync.Table(Of TEntity)().ToListAsync()
            End Function
            Public Async Function GetItemsAsyncEnumerable(Optional forceRefresh As Boolean = False) As Task(Of IEnumerable(Of TEntity)) Implements IDataStoreAsync(Of TEntity).GetItemsAsyncEnumerable
                Return Await _databaseAsync.Table(Of TEntity)().ToListAsync()
            End Function

            Public Function GetItemAsync(id As Integer) As Task(Of TEntity) Implements IDataStoreAsync(Of TEntity).GetItemAsync
                Throw New NotImplementedException()
            End Function





            Public Function UpdateItemAsync(item As TEntity) As Task(Of Boolean) Implements IDataStoreAsync(Of TEntity).UpdateItemAsync
                _databaseAsync.UpdateAsync(item)
                Return Task.FromResult(True)

            End Function

            Public Function AddItemAsync(item As TEntity) As Task(Of Boolean) Implements IDataStoreAsync(Of TEntity).AddItemAsync
                _databaseAsync.InsertAsync(item)
                Return Task.FromResult(True)
            End Function

            Public Function DeleteItemAsync(item As TEntity) As Task(Of Boolean) Implements IDataStoreAsync(Of TEntity).DeleteItemAsync
                _databaseAsync.DeleteAsync(item)
                Return Task.FromResult(True)
            End Function

            Public Function SaveItemAsync(item As TEntity) As Task(Of Boolean) Implements IDataStoreAsync(Of TEntity).SaveItemAsync
                Throw New NotImplementedException()
            End Function

            Public Function GetListAsync() As Task(Of List(Of TEntity)) Implements IDataStoreAsync(Of TEntity).GetListAsync
                Throw New NotImplementedException()
            End Function

            Public Function GetQueryAsync(_select As String, _from As String, _where As String) As Task(Of List(Of TEntity)) Implements IDataStoreAsync(Of TEntity).GetQueryAsync


                'Throw New NotImplementedException()

                Dim _sql As String = String.Format("SELECT {0} FROM {1} WHERE {2}", _select, _from, _where)





                Return _databaseAsync.QueryAsync(Of TEntity)(_sql)


            End Function

            'Public Function GetQueryAsync(where As String) As Task(Of List(Of TEntity)) Implements IDataStoreAsync(Of TEntity).GetQueryAsync
            '    'Throw New NotImplementedException()

            'End Function

#End Region



        End Class


    End Namespace

End Namespace