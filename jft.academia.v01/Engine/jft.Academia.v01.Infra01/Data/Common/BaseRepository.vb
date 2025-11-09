


Imports jft.Academia.v01.Core.Entities
Imports jft.Academia.v01.Core.Entities.Interfaces
Imports SQLite

Namespace Data


    Namespace Common



        Public MustInherit Class BaseRepository(Of TEntity As {Class, New})
            Implements IDataStoreAsync(Of TEntity)



            Public Sub New()
                _database = New SQLiteConnection(Constantes.DatabasePath, Constantes.Flags)
                _databaseAsync = New SQLiteAsyncConnection(Constantes.DatabasePath, Constantes.Flags)
                '_database = new SQLiteConnection(Constants.DatabasePath, Constants.Flags);
                Dim result As CreateTableResult = _database.CreateTable(Of TEntity)()
                'CreateTableResult result = await _database.CreateTableAsync<TEntity>();
            End Sub



            Private ReadOnly _database As SQLiteConnection
            Friend ReadOnly _databaseAsync As SQLiteAsyncConnection

            Public Shared ReadOnly Property DbPath As String = Constantes.DatabasePath
            'Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "chinook.db");





            ' Public MustOverride Function SalvarItemAsync(item As TEntity) As Task(Of Boolean)





            Public Function GetItems(Optional forceRefresh As Boolean = False) As List(Of TEntity)
                Return _database.Table(Of TEntity)().ToList()
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

#End Region



        End Class


    End Namespace

End Namespace