using Syncfusion.Maui.PdfViewer;

namespace SampleBrowser.Maui.PdfViewer.SfPdfViewer;

public partial class StickyNoteListView : ContentView
{
    internal void Initialize()
    {
        InitializeComponent();
        listView.ItemsSource = new List<AnnotationButtonItem>()
        {
            new AnnotationButtonItem()
            {
                Icon = "\uE775",
                IconName = "Note"
            },
            new AnnotationButtonItem()
            {
                Icon = "\uE779",
                IconName = "Insert"
            },
            new AnnotationButtonItem()
            {
                Icon = "\uE711",
                IconName = "Comment"
            },
            new AnnotationButtonItem()
            {
                Icon = "\uE777",
                IconName = "Key"
            },
            new AnnotationButtonItem()
            {
                Icon = "\uE778",
                IconName = "Help"
            },
            new AnnotationButtonItem()
            {
                Icon = "\uE776",
                IconName = "Paragraph"
            },
            new AnnotationButtonItem()
            {
                Icon = "\uE77a",
                IconName = "New Paragraph"
            },
        };
    }

    private void SfListView_ItemTapped(object sender, Syncfusion.Maui.ListView.ItemTappedEventArgs e)
    {

        if (e.DataItem is AnnotationButtonItem stickyNoteDetails && BindingContext is CustomToolbarViewModel viewModel)
        {
            viewModel.ToolbarCommand.Execute(stickyNoteDetails.IconName);
        }
    }
}