using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace Rich_Text_Box___Advanced__
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
   
    public partial class MainWindow : Window
    {
        FlowDocument fdDisplay = new FlowDocument();
        public MainWindow()
        {
            InitializeComponent();

            rtbdisplay.Document = fdDisplay;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Paragraph newParagraph = new Paragraph();

            string subjectLine = txtsubjectLine.Text;
            string body = runBody.Text;

            Run newRun = new Run(subjectLine);
            newRun . FontSize = 19;
            newRun.FontStyle = FontStyle;
            newRun.Foreground = new SolidColorBrush(Colors.Gray);
            newParagraph.Inlines.Add(newRun);

            Run runNBody = new Run(body);
            runNBody.FontSize = 12;
            runNBody.Foreground = new SolidColorBrush(Colors.LightPink);
            runNBody.FontWeight = FontWeight;
            newParagraph.Inlines.Add(newRun);
            newParagraph.Inlines.Add("\n");
            newParagraph.Inlines.Add("\n");

            newParagraph.Inlines.Add(runNBody);




            fdDisplay.Blocks.Add(newParagraph);


        }
    }



    //    What's the difference between a paragraph and a run tag ( regarding space used )? paragraph uses the whole line While run uses space till the end of the text 
    //What "Collection" does a Paragraph have that holds inlines?  runs
    //What "Collection" does a FlowDocument have that holds blocks?   paragraph 
    //How do you connect a FlowDocument to a RichTextBox set the RTB to an instance of a FlowDocument
    //How often does Will appear in the Rich Text Box with the following code?  ----  
    //Run name = new Run("Will");                                                   |
    //                                                                              |
    //    paragraph.Inlines.Add(name);                                              |       will appear three times
    //paragraph.Inlines.Add(name);                                                  |
    //paragraph.Inlines.Add(name);                                                  |
    //                                                                              |
    //.....                                                                      ---

    //What property is used to add Italics? fontstyles 
    //What property is used to add bold?  FontWeight
}
