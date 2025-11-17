Imports SQLite

Public Class BaseDataRepository(Of TEntity As {Class, New}, TEntityView)





    Public Sub New()


        _database = New SQLiteConnection(Constantes.DatabasePath, Constantes.Flags)
        _databaseAsync = New SQLiteAsyncConnection(Constantes.DatabasePath, Constantes.Flags)

        '_database = new SQLiteConnection(Constants.DatabasePath, Constants.Flags);
        Dim result As CreateTableResult = _database.CreateTable(Of TEntity)()
        'CreateTableResult result = await _database.CreateTableAsync<TEntity>();


    End Sub



    Friend ReadOnly _database As SQLiteConnection
    Friend ReadOnly _databaseAsync As SQLiteAsyncConnection

    Public Shared ReadOnly Property DbPath As String = Constantes.DatabasePath
    'Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "chinook.db");




End Class
