using System.Collections.ObjectModel;

namespace SampleBrowser.Maui.PdfViewer.SfPdfViewer;

public partial class TextmarkupView : ContentView
{
    internal void Initialize()
    {
        InitializeComponent();
        listView.ItemsSource = new List<AnnotationButtonItem>()
        {
            new AnnotationButtonItem()
            {
                Icon = "\uE760",
                IconName = "Highlight"
            },
            new AnnotationButtonItem()
            {
                Icon = "\uE762",
                IconName = "Underline"
            },
            new AnnotationButtonItem()
            {
                Icon = "\uE763",
                IconName = "StrikeOut"
            },
            new AnnotationButtonItem()
            {
                Icon = "\uE765",
                IconName = "Squiggly"
            },
        };
    }

    private void SfListView_ItemTapped(object sender, Syncfusion.Maui.ListView.ItemTappedEventArgs e)
    {
        if (e.DataItem is AnnotationButtonItem textMarkupDetails && BindingContext is CustomToolbarViewModel viewModel)
        {
            viewModel.ToolbarCommand.Execute(textMarkupDetails.IconName);
        }
    }
    internal void DisappearHighlight()
    {
        if(listView != null) 
            listView.SelectedItem = null;
    }
}