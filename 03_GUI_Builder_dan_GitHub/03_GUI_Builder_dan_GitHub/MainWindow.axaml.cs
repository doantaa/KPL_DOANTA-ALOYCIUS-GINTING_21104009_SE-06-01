using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace _03_GUI_Builder_dan_GitHub;

public partial class MainWindow : Window
{
    private int counter = 0;
    public MainWindow()
    {
        InitializeComponent();
    }
    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        Console.WriteLine($"The button clicked  {counter} ");
        counter++;
        CounterText.Text = $"Counter: {counter}";
    }
}