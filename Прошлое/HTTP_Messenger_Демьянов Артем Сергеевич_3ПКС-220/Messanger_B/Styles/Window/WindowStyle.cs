﻿using System;
using System.Windows;
using System.Windows.Controls;

namespace Project.Style.Window {
    partial class WindowStyle {

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            (sender as System.Windows.Window).StateChanged += Window_StateChanged;
        }

        private void Window_StateChanged(object sender, EventArgs e) {
            System.Windows.Window me = (sender as System.Windows.Window);
            Button maximizeCaptionButton = me.Template.FindName("MaxRestoreButton", me) as Button;
            if (!(maximizeCaptionButton is null)) {
                maximizeCaptionButton.Content = me.WindowState == WindowState.Maximized ? "2" : "1";
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e) {
            ((sender as FrameworkElement).TemplatedParent as System.Windows.Window).Close();
        }

        private void MaxRestoreButton_Click(object sender, RoutedEventArgs e) {
            ((sender as FrameworkElement).TemplatedParent as System.Windows.Window)
                .WindowState = (((sender as FrameworkElement).TemplatedParent as System.Windows.Window)
                .WindowState == WindowState.Normal) ? WindowState.Maximized : WindowState.Normal;
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e) {
            ((sender as FrameworkElement).TemplatedParent as System.Windows.Window)
                .WindowState = WindowState.Minimized;
        }
    }
}
