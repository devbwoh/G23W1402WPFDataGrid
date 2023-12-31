﻿using System.Windows;

namespace G23W1402WPFDataGrid;

public partial class MainWindow : Window {
    GundamViewModel vm = new GundamViewModel();

    public MainWindow() {
        InitializeComponent();
        this.DataContext = vm;
        Grid.ItemsSource = vm.GundamList;

        vm.Add(new GundamModel("건담", "RX-78-2", "연방군"));
        vm.Add(new GundamModel("자쿠II", "MS-06", "지온군"));
    }

    private void OnAdd(object sender, RoutedEventArgs e) {
        Gundam g = new Gundam();
        if (g.ShowDialog() != true)
            return;

        vm.Add(new GundamModel(g.MSName, g.MSModel, g.MSParty));
    }
}