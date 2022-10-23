using MauiMVVM.ViewModel;
using MauiMVVM.Service;
using Microsoft.Maui.Controls;
using static CommunityToolkit.Maui.Markup.GridRowsColumns;

namespace MauiMVVM;

public partial class DataItemListPage : ContentPage
{
    public DataItemListPage()
    {
        DataItemService dataItemService = new DataItemService();
        InitializeComponent();
        BindingContext = new DataItemListViewModel()
        {
            Navigation = this.Navigation,
            DataItemService = dataItemService
        };
    }

    public void ToolbarItem_Clicked(object sender, EventArgs e)
    {

        FilterScrean.IsVisible = !FilterScrean.IsVisible;

        if (FilterScrean.IsVisible)
        {
            if (DeviceInfo.Current.Idiom == DeviceIdiom.Phone)
            {
                GridScrean.ColumnDefinitions = Columns.Define(Stars(0), Stars(1));
                ListScrean.IsVisible = false;
            }

            if (DeviceInfo.Current.Idiom != DeviceIdiom.Phone)
            {
                GridScrean.ColumnDefinitions = Columns.Define(Stars(75), Stars(25));
            }
        }
        else
        {
            GridScrean.ColumnDefinitions = Columns.Define(Stars(1), Stars(0));
            ListScrean.IsVisible = true;
        }

    }
}

