using Ownskit.Utils;
using System;
using System.Windows.Controls;
using System.Windows.Input;
using System.Security.Principal;
using System.Windows.Media;
using System.Windows.Shapes;

namespace PrecisionSimEngineeringRGBConfigurator
{
    /// <summary>
    /// Control Panel
    /// </summary>
    public partial class HeadlightFlashSettingsControll : UserControl
    {
        public RGBConfigurator Plugin { get; private set; }
        private Key KeyCode { get; set; }

        private RawKeyEventHandler KeyEvent;

        private KeyboardListener Listener;

        public HeadlightFlashSettingsControll(RGBConfigurator plugin)
        {
            InitializeComponent();

            this.Plugin = plugin;

            LoadSettings();
            BtnApply.Content = "Applied";

            //Done to prevent a bug where if not running with Admin perm it does not correctly register the keystroke, and the button would get stuck
            bool isElevated = false;
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                isElevated = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }

            if (!isElevated)
            {
                BtnHeadlightKey.IsEnabled = false;
            }

            if (Plugin.InputManagement.KeyDownTime == -1)
            {
                this.IsEnabled = false;
                LbWarningBox.Content = "Plugin Disabled, Keyboard Emulation test failed. \nMost likely this version of SimHub is not compatible with this version of this Plugin any further.";
            }
        }

        private void LoadSettings()
        {
            LoadButtonValue(ButtonL1Text, ButtonL1Display, Plugin.Settings.ButtonL1ColorCode);
            LoadButtonValue(ButtonL2Text, ButtonL2Display, Plugin.Settings.ButtonL2ColorCode);
            LoadButtonValue(ButtonL3Text, ButtonL3Display, Plugin.Settings.ButtonL3ColorCode);
            LoadButtonValue(ButtonL4Text, ButtonL4Display, Plugin.Settings.ButtonL4ColorCode);
            LoadButtonValue(ButtonL5Text, ButtonL5Display, Plugin.Settings.ButtonL5ColorCode);
            LoadButtonValue(ButtonL6Text, ButtonL6Display, Plugin.Settings.ButtonL6ColorCode);
            LoadButtonValue(ButtonR1Text, ButtonR1Display, Plugin.Settings.ButtonR1ColorCode);
            LoadButtonValue(ButtonR2Text, ButtonR2Display, Plugin.Settings.ButtonR2ColorCode);
            LoadButtonValue(ButtonR3Text, ButtonR3Display, Plugin.Settings.ButtonR3ColorCode);
            LoadButtonValue(ButtonR4Text, ButtonR4Display, Plugin.Settings.ButtonR4ColorCode);
            LoadButtonValue(ButtonR5Text, ButtonR5Display, Plugin.Settings.ButtonR5ColorCode);
            LoadButtonValue(ButtonR6Text, ButtonR6Display, Plugin.Settings.ButtonR6ColorCode);
            LoadButtonValue(ButtonM1Text, ButtonM1Display, Plugin.Settings.ButtonM1ColorCode);
            LoadButtonValue(ButtonM2Text, ButtonM2Display, Plugin.Settings.ButtonM2ColorCode);
            LoadButtonValue(ButtonM3Text, ButtonM3Display, Plugin.Settings.ButtonM3ColorCode);
            LoadButtonValue(ButtonM4Text, ButtonM4Display, Plugin.Settings.ButtonM4ColorCode);
            LoadButtonValue(ButtonM5Text, ButtonM5Display, Plugin.Settings.ButtonM5ColorCode);
            
            BtnApply.IsEnabled = false;

            UpdateWarningBox();
        }

        private void LoadButtonValue(TextBox code, Ellipse display, string value)
        {
            code.Text = value;
            
            var converter = new BrushConverter();
            var brush = (Brush)converter.ConvertFromString(value);
            display.Fill = brush;
        }

        private void ButtonChanged(TextBox code, Ellipse display)
        {
            try
            {
                var converter = new BrushConverter();
                var brush = (Brush)converter.ConvertFromString(code.Text);
                display.Fill = brush;

                code.Foreground = Brushes.Black;
                code.Background = Brushes.White;
                BtnApply.IsEnabled = true;
            }
            catch
            {
                code.Foreground = Brushes.White;
                code.Background = Brushes.Firebrick;
                BtnApply.IsEnabled = false;
            }
        }

        private void ButtonL1_Changed(object sender, TextChangedEventArgs e)
        {
            ButtonChanged(ButtonL1Text, ButtonL1Display);
        }
        private void ButtonL2_Changed(object sender, TextChangedEventArgs e)
        {
            ButtonChanged(ButtonL2Text, ButtonL2Display);
        }
        private void ButtonL3_Changed(object sender, TextChangedEventArgs e)
        {
            ButtonChanged(ButtonL3Text, ButtonL3Display);
        }
        private void ButtonL4_Changed(object sender, TextChangedEventArgs e)
        {
            ButtonChanged(ButtonL4Text, ButtonL4Display);
        }
        private void ButtonL5_Changed(object sender, TextChangedEventArgs e)
        {
            ButtonChanged(ButtonL5Text, ButtonL5Display);
        }
        private void ButtonL6_Changed(object sender, TextChangedEventArgs e)
        {
            ButtonChanged(ButtonL6Text, ButtonL6Display);
        }

        private void ButtonR1_Changed(object sender, TextChangedEventArgs e)
        {
            ButtonChanged(ButtonR1Text, ButtonR1Display);
        }
        private void ButtonR2_Changed(object sender, TextChangedEventArgs e)
        {
            ButtonChanged(ButtonR2Text, ButtonR2Display);
        }
        private void ButtonR3_Changed(object sender, TextChangedEventArgs e)
        {
            ButtonChanged(ButtonR3Text, ButtonR3Display);
        }
        private void ButtonR4_Changed(object sender, TextChangedEventArgs e)
        {
            ButtonChanged(ButtonR4Text, ButtonR4Display);
        }
        private void ButtonR5_Changed(object sender, TextChangedEventArgs e)
        {
            ButtonChanged(ButtonR5Text, ButtonR5Display);
        }
        private void ButtonR6_Changed(object sender, TextChangedEventArgs e)
        {
            ButtonChanged(ButtonR6Text, ButtonR6Display);
        }

        private void ButtonM1_Changed(object sender, TextChangedEventArgs e)
        {
            ButtonChanged(ButtonM1Text, ButtonM1Display);
        }
        private void ButtonM2_Changed(object sender, TextChangedEventArgs e)
        {
            ButtonChanged(ButtonM2Text, ButtonM2Display);
        }
        private void ButtonM3_Changed(object sender, TextChangedEventArgs e)
        {
            ButtonChanged(ButtonM3Text, ButtonM3Display);
        }
        private void ButtonM4_Changed(object sender, TextChangedEventArgs e)
        {
            ButtonChanged(ButtonM4Text, ButtonM4Display);
        }
        private void ButtonM5_Changed(object sender, TextChangedEventArgs e)
        {
            ButtonChanged(ButtonM5Text, ButtonM5Display);
        }
        private void BtnApply_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Plugin.Settings.ButtonL1ColorCode = ButtonL1Text.Text;
            Plugin.Settings.ButtonL2ColorCode = ButtonL2Text.Text;
            Plugin.Settings.ButtonL3ColorCode = ButtonL3Text.Text;
            Plugin.Settings.ButtonL4ColorCode = ButtonL4Text.Text;
            Plugin.Settings.ButtonL5ColorCode = ButtonL5Text.Text;
            Plugin.Settings.ButtonL6ColorCode = ButtonL6Text.Text;
            Plugin.Settings.ButtonR1ColorCode = ButtonR1Text.Text;
            Plugin.Settings.ButtonR2ColorCode = ButtonR2Text.Text;
            Plugin.Settings.ButtonR3ColorCode = ButtonR3Text.Text;
            Plugin.Settings.ButtonR4ColorCode = ButtonR4Text.Text;
            Plugin.Settings.ButtonR5ColorCode = ButtonR5Text.Text;
            Plugin.Settings.ButtonR6ColorCode = ButtonR6Text.Text;
            Plugin.Settings.ButtonM1ColorCode = ButtonM1Text.Text;
            Plugin.Settings.ButtonM2ColorCode = ButtonM2Text.Text;
            Plugin.Settings.ButtonM3ColorCode = ButtonM3Text.Text;
            Plugin.Settings.ButtonM4ColorCode = ButtonM4Text.Text;
            Plugin.Settings.ButtonM5ColorCode = ButtonM5Text.Text;

            RGBConfigurator.SendRGBValuesToWheel(P);
            
            UpdateWarningBox();
        }

        private void UpdateWarningBox()
        {
            string text = "";

            //Post processing
            if (!text.Equals(""))
            {
                text = text.Substring(1);
            }

            LbWarningBox.Content = text;
        }
    }
}
