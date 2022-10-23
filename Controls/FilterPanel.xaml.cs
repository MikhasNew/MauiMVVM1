using MauiMVVM.Service;
using MauiMVVM.ViewModel;
using CommunityToolkit.Maui.Markup;
using Microsoft.Maui.Controls.Platform;

namespace MauiMVVM.Controls;

public partial class FilterPanel
{
    public Dictionary<string, string[]> filtredFilds;
    Command SearchButtonCommand { get; set; }
    Command CleanButtonCommand { get; set; }


    public FilterPanel()
	{
        InitializeComponent();
    }
    private bool isShouing;
    public bool Ishiden
    {
        get=> this.IsVisible;
        set
        {
            this.IsVisible = value;
        }
    }

    public void Button_Clicked(object sender, EventArgs e)
    {
      
    }
}