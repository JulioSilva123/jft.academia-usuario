using jft.Academia.v01.Infra01;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace jft.academia.v01.Aplicativo.Common
{
    public abstract class BaseItemPageModelView<TEntity, TEntityView> : BasePageModelView<TEntity, TEntityView>
    {


         

        public BaseItemPageModelView()
        {


        }

        public abstract void LoadItemId(string _id);



        public void OnAppearing()
        {

            IsBusy = true;
            this.SelectedItem = default(TEntityView);

        }

        private TEntityView _selectedItem;
        public TEntityView SelectedItem
        {
            get => _selectedItem;
            set
            {
                SetProperty(ref _selectedItem, value);

            }
        }

        private string _itemId;
        public string ItemId
        {
            get
            {
                return _itemId;
            }
            set
            {
                _itemId = value;
                this.LoadItemId(value);
            }
        }


        private string _itemIdOld;
        public string ItemIdOld
        {
            get
            {
                return _itemIdOld;
            }
            set
            {
                _itemIdOld = value;
            }
        }


        public PageMode _Modo;
        public PageMode Modo
        {
            get
            {
                return _Modo;
            }
            set
            {
                _Modo = value;
            }
        }





    }
}
