using System;
using System.IO;
using Xamarin.Forms;


public class MainPage : ContentPage
{
  public MainPage ()
  {
    var layout = new StackLayout ();

    var yellowBox = new BoxView { Color = Color.Yellow,
                                  VerticalOptions = LayoutOptions.FillAndExpand,
                                  HorizontalOptions = LayoutOptions.FillAndExpand };

    var greenBox = new BoxView { Color = Color.Green,
                                 VerticalOptions = LayoutOptions.FillAndExpand,
                                 HorizontalOptions = LayoutOptions.FillAndExpand };

    var blueBox = new BoxView { Color = Color.Blue,
                                VerticalOptions = LayoutOptions.FillAndExpand,
                                HorizontalOptions = LayoutOptions.FillAndExpand,
                                HeightRequest = 75 };

    layout.Children.Add(yellowBox);
    layout.Children.Add(greenBox);
    layout.Children.Add(blueBox);
    layout.Spacing = 10;
    Content = layout;
  }
}