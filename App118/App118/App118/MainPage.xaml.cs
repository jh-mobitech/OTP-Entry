using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App118
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        List<Label> labels;
        public MainPage()
        {
            InitializeComponent();

            labels = new List<Label>();
            labels.Add(label1);
            labels.Add(label2);
            labels.Add(label3);
            labels.Add(label4);
        }

        private void Editor_TextChanged(object sender, TextChangedEventArgs e)
        {
            var oldText = e.OldTextValue;
            var newText = e.NewTextValue;

            Editor editor = sender as Editor;


            string editorStr = editor.Text;
            //if string.length lager than max length
            if (editorStr.Length > 4)
            {
                editor.Text = editorStr.Substring(0,4);
            }

            //dismiss keyboard
            if (editorStr.Length >= 4)
            {
                editor.Unfocus();
            }

            for (int i = 0; i < labels.Count; i++)
            {
                Label lb = labels[i];

                if (i < editorStr.Length)
                {
                    lb.Text = editorStr.Substring(i, 1);
                }
                else {
                    lb.Text = "";
                }
            }
        }
    }
}
