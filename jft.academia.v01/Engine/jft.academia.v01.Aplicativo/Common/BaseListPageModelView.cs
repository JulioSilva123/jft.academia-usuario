using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace jft.academia.v01.Aplicativo.Common
{
    public abstract class BaseListPageModelView<TEntity, TEntityView> : BasePageModelView<TEntity, TEntityView>
    {



        public BaseListPageModelView()
        {
            this.Items = new ObservableCollection<TEntityView>();
            this.LoadItemsCommand = new Command(async () => await this.ExecuteLoadItemsCommand());
            this.ItemTapped = new Command<TEntityView>(OnItemSelected);
            this.AddItemCommand = new Command(OnAddItem);
        }

        public abstract void OnAppearing();



        //public void OnAppearing()
        //{
        //    //this.SelectedItem = default(TView);
        //}
               
        public void OnAppearingBaseListPage()
        {
            base.OnAppearingBasePage();
            this.SelectedItem = default(TEntityView);
        }


        public ObservableCollection<TEntityView> Items { get; }
        public Command LoadItemsCommand { get; }
        public Command AddItemCommand { get; }
        public Command<TEntityView> ItemTapped { get; }


        public abstract void OnItemSelected(TEntityView item);
        public abstract void OnAddItem(object obj);


        public abstract Task<List<TEntityView>> GetItemsView();




        private TEntityView _selectedItem;
        public TEntityView SelectedItem
        {
            get => _selectedItem;
            set
            {
                SetProperty(ref _selectedItem, value);
                OnItemSelected(value);
            }
        }



        public async Task ExecuteLoadItemsCommand()
        {
            this.IsBusy = true;

            try
            {
                Items.Clear();
                var items = await this.GetItemsView(); // await DataViewStore.GetViewItemsAsync(true);
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }












    }
}
