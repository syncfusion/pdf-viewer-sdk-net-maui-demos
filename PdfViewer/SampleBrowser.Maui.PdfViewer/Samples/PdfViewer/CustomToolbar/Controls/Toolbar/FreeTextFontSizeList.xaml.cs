using System.Collections.ObjectModel;
using System.ComponentModel;
using SampleBrowser.Maui.PdfViewer.SfPdfViewer;

namespace SampleBrowser.Maui.PdfViewer.SfPdfViewer;

public partial class FreeTextFontSizeList : ContentView
{
	internal void Initialize()
	{
		InitializeComponent();
		freeFontListView.ItemsSource = new List<AnnotationButtonItem>()
		{ 
		 new AnnotationButtonItem
		 {
			 Icon="10",
		 },
         new AnnotationButtonItem
         {
             Icon="11",
         },
          new AnnotationButtonItem
         {
             Icon="12",
         },
           new AnnotationButtonItem
         {
             Icon="13",
         },
            new AnnotationButtonItem
         {
             Icon="14",
         },
             new AnnotationButtonItem
         {
             Icon="15",
         },
              new AnnotationButtonItem
         {
             Icon="16",
         },
        };

	}

    private void freeFontListView_ItemTapped(object sender, Syncfusion.Maui.ListView.ItemTappedEventArgs e)
    {
        if(e.DataItem is AnnotationButtonItem freeTextFontSizeList && BindingContext is CustomToolbarViewModel viewModel)
        {
            viewModel.ToolbarCommand.Execute(freeTextFontSizeList.Icon);
        }
    }

    internal void FreeTextFontSizeListDisappear()
    {
        if(freeFontListView !=null)
        {
            freeFontListView.SelectedItem=null;
        }
    }
}