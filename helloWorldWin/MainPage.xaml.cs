using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace helloWorldWin
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Random rand;
        int x = 5;
        public MainPage()
        {
            this.InitializeComponent();
            rand = new Random();
            
        }

        private byte[] GetRandomBytes (int n)
        {
            //fill the array of bytes of length 'n' with random numbers
            var randomBytes = new byte[n];
            rand.NextBytes(randomBytes);
            return randomBytes;
        }

        private void sayHelloButton_click(object sender, RoutedEventArgs e)
        {
            
            byte[] rgb = GetRandomBytes(3);

            //create a solid color brush using the three numbers
            var randomColorBrush = new SolidColorBrush(Color.FromArgb(255, rgb[0], rgb[1], rgb[2]));

            //set both the text color and the box color to rand
            textBox1.BorderBrush = randomColorBrush;
            textBox1.Foreground = randomColorBrush;
            textBox1.Margin = new Thickness(x, 0, 0, 0);
            x = x + 5;
        }
    }
}
