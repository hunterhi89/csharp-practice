using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Test_UWP_App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button senderButton = sender as Button;
            
            StatusTextBlock.Text = "Interaction achieved by " + senderButton.Name;
        }

        private void Canvas_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            Ellipse circle = new Ellipse();
            circle.Height = 50;
            circle.Width = 50;
            circle.Fill = new SolidColorBrush(Windows.UI.Colors.LightBlue);
            var vector = Windows.UI.Core.CoreWindow.GetForCurrentThread().PointerPosition;
            Point target = new Point(vector.X - Window.Current.Bounds.X, vector.Y - Window.Current.Bounds.Y);
            //circle.CenterPoint = new System.Numerics.Vector3((float)vector.X, (float)vector.Y, 0);
            Canvas.SetLeft(circle, target.X);
            Canvas.SetTop(circle, target.Y);
            Canvas drawingCanvas = sender as Canvas;
            drawingCanvas.Children.Add(circle);
        }
    }
}
