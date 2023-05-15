using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float temp = 0;

        string operation = "";

        string output = "";

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;

            DivideBtn.Content = "\u00F7";
        }
        private void NumBtn_Click(object sender, RoutedEventArgs e)
        {
            string name = ((Button)sender).Name;

            /// Button Output
            switch (name)
            {
                case "ZeroBtn":
                    output += "0";
                    OutputTextBlock.Text = output;
                    break;

                case "OneBtn":
                    output += "1";
                    OutputTextBlock.Text = output;
                    break;

                case "TwoBtn":
                    output += "2";
                    OutputTextBlock.Text = output;
                    break;

                case "ThreeBtn":
                    output += "3";
                    OutputTextBlock.Text = output;
                    break;

                case "FourBtn":
                    output += "4";
                    OutputTextBlock.Text = output;
                    break;

                case "FiveBtn":
                    output += "5";
                    OutputTextBlock.Text = output;
                    break;

                case "SixBtn":
                    output += "6";
                    OutputTextBlock.Text = output;
                    break;

                case "SevenBtn":
                    output += "7";
                    OutputTextBlock.Text = output;
                    break;

                case "EightBtn":
                    output += "8";
                    OutputTextBlock.Text = output;
                    break;

                case "NineBtn":
                    output += "9";
                    OutputTextBlock.Text = output;
                    break;

                case "DotBtn":
                    output += ".";
                    OutputTextBlock.Text = output;
                    break;

            }
        }

        private void MinusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = float.Parse(output);

                output = "";

                operation = "Minus";
            }
        }

        private void PlusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = float.Parse(output);

                output = "";

                operation = "Plus";
            }
        }
        private void TimesBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = float.Parse(output);

                output = "";

                operation = "Times";
            }
        }

        private void DivideBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = float.Parse(output);

                output = "";

                operation = "Divide";
            }
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            temp = 0;
            output = "";
            operation = "";
            OutputTextBlock.Text = "0"; // reset the display to zero
        }
        private void BackspaceBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output.Length > 0)
            {
                output = output.Substring(0, output.Length - 1);
                OutputTextBlock.Text = output;
            }
        }

        private void EqualBtn_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "Minus":
                    float minusTemp = temp - float.Parse(output);
                    output = minusTemp.ToString();
                    OutputTextBlock.Text = output;
                    break;

                case "Plus":
                    float plusTemp = temp + float.Parse(output);
                    output = plusTemp.ToString();
                    OutputTextBlock.Text = output;
                    break;

                case "Times":
                    float timesTemp = temp * float.Parse(output);
                    output = timesTemp.ToString();
                    OutputTextBlock.Text = output;
                    break;

                case "Divide":
                    float divideTemp = temp / float.Parse(output);
                    output = divideTemp.ToString();
                    OutputTextBlock.Text = output;
                    break;
            }
        }


    }
}
