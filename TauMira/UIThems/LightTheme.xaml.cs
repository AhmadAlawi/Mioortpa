using System;
using System.Windows;
using System.Windows.Controls;

namespace TauMira.UIThems
{
    public partial class LightTheme
    {

        public Action HideActionBarAction;
        public Action HideWorkSpacePanel;
        public Action HideGroupPanel;
        public LightTheme()
        {
        }
        private void CloseWindow_Event(object sender, RoutedEventArgs e)
        {
            if (e.Source != null)
                try { CloseWind(Window.GetWindow((FrameworkElement)e.Source)); } catch { }
        }
        private void AutoMinimize_Event(object sender, RoutedEventArgs e)
        {
            if (e.Source != null)
                try { MaximizeRestore(Window.GetWindow((FrameworkElement)e.Source)); } catch { }
        }
        private void Minimize_Event(object sender, RoutedEventArgs e)
        {
            if (e.Source != null)
                try { MinimizeWind(Window.GetWindow((FrameworkElement)e.Source)); } catch { }
        }

        public void CloseWind(Window window) => window.Close();
        public void MaximizeRestore(Window window)
        {
            if (window.WindowState == WindowState.Maximized)
                window.WindowState = WindowState.Normal;
            else if (window.WindowState == WindowState.Normal)
                window.WindowState = WindowState.Maximized;
        }
        public void MinimizeWind(Window window) => window.WindowState = WindowState.Minimized;


        private void HidePanels_Click(object sender, RoutedEventArgs e)
        {
            //  MessageBox.Show(((Button)(sender)).ContextMenu.Name);

            var cm = ((ContextMenu)(((Button)(sender)).ContextMenu));
            if (cm == null)
            {
                return;
            }
            //  cm.Placement = PlacementMode.Top;
            cm.PlacementTarget = sender as UIElement;
            cm.IsOpen = true;
            cm.Visibility = Visibility.Visible;
        }

        private void HidePanels_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var cm = ((ContextMenu)(((Button)(sender)).ContextMenu));
            if (cm == null)
            {
                return;
            }
            //  cm.Placement = PlacementMode.Top;
            cm.PlacementTarget = sender as UIElement;
            cm.IsOpen = false;
            cm.Visibility = Visibility.Hidden;

            return;
        }

        private void HidePanels_MouseRightButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var cm = ((ContextMenu)(((Button)(sender)).ContextMenu));
            if (cm == null)
            {
                return;
            }
            cm.PlacementTarget = sender as UIElement;
            cm.IsOpen = false;
            cm.Visibility = Visibility.Hidden;

            return;
        }

        private void Hid_WorkSpacePael_Event(object sender, RoutedEventArgs e)
        {
            //App.appManagerController.HideWorkSpacePanel();
        }
        private void Hid_ActionBar_Event(object sender, RoutedEventArgs e)
        {            
                //App.appManagerController.HideActionBar();  
        }

        private void Hid_GroupPanel_Event(object sender, RoutedEventArgs e)
        {
            //App.appManagerController.HideGroupPanel();
        }
    }
}
