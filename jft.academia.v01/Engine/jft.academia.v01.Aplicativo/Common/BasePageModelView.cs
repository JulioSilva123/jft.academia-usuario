using jft.academia.v01.Aplicativo.DataViews;
using jft.academia.v01.Core.Entities.Interfaces;
using jft.Academia.v01.Infra01.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace jft.academia.v01.Aplicativo.Common
{
    public abstract class BasePageModelView<TEntity, TEntityView> : INotifyPropertyChanged
    {
        public BasePageModelView()
        {

            this._dbAcademia = new DbAcademia();
            this._dbAcademiaViews = new DbAcademiaViews();

        }

        public event PropertyChangedEventHandler PropertyChanged;


        public void OnAppearingBasePage()
        {

            this.IsBusy = true;

        }



        public IDataStoreAsync<TEntity> DataStore => DependencyService.Get<IDataStoreAsync<TEntity>>();
        public IDataStoreViewAsync<TEntityView> DataViewStore => DependencyService.Get<IDataStoreViewAsync<TEntityView>>();



        //var dbAcademia = new DbAcademia();
        DbAcademia _dbAcademia;
        public DbAcademia dbAcademia
        {
            get { return _dbAcademia; }
            //set { SetProperty(ref _isBusy, value); }
        }

        DbAcademiaViews _dbAcademiaViews;
        public DbAcademiaViews dbAcademiaViews
        {
            get { return _dbAcademiaViews; }
            //set { SetProperty(ref _isBusy, value); }
        }



        bool _isBusy = false;
        public bool IsBusy
        {
            get { return _isBusy; }
            set { SetProperty(ref _isBusy, value); }
        }

        string title = string.Empty;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName] string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged
        
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion



    }
}
