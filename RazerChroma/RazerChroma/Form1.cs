using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Corale.Colore.Core;                           // To easily get to the Chroma object
using ColoreColor = Corale.Colore.Core.Color;       // To easily get to the Color object of the API and also distinguish it from C#'s Color            

/*
   TODO: Finish functionality of selecting different effects
         Add Spectrum Cycling
         Add custom colors
         Add saving of colors
*/

namespace RazerChroma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Adds an object from the MyColor class which contains a string for the ComboBox and
            // a ColoreColor object to easily set things later based on the user's selection
            ColorSelector.Items.Add(new MyColor(ColoreColor.Red, "Red"));
            ColorSelector.Items.Add(new MyColor(ColoreColor.Green, "Green"));
            ColorSelector.Items.Add(new MyColor(ColoreColor.Blue, "Blue"));
            ColorSelector.Items.Add(new MyColor(new ColoreColor(0, 0, 0), "None"));

            ColorSelector.SelectedIndex = 0;

            // Copy the previous Items into the second ComboBox
            object[] oContainer = new object[ColorSelector.Items.Count];
            ColorSelector.Items.CopyTo(oContainer, 0);
            ColorSelector2.Items.AddRange(oContainer);

            ColorSelector2.SelectedIndex = 0;

            // Name the strings for each device and store them into a ComboBox
            InstanceSelector.Items.Add("All");
            InstanceSelector.Items.Add("Mouse");
            InstanceSelector.Items.Add("Keyboard");
            InstanceSelector.Items.Add("Keypad");
            InstanceSelector.Items.Add("Mousepad");
            InstanceSelector.Items.Add("Headset");

            InstanceSelector.SelectedIndex = 0;

            // Name the strings for each effect and store them into a ComboBox
            EffectSelector.Items.Add("Static");
            EffectSelector.Items.Add("Breathing");
            EffectSelector.Items.Add("Wave");
            EffectSelector.Items.Add("Reactive");

            EffectSelector.SelectedIndex = 0;

            // Hide the second color since it can only be used with certain effects
            ColorSelector2.Hide();
        }

        private void SetColorButton_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                // Only do things when the user clicks with the left button
                case MouseButtons.Left:
                    {
                        // Parse which MyColor object the user selected in each box
                        MyColor oSelectedColor = ColorSelector.SelectedItem as MyColor;
                        MyColor oSelectedColor2 = ColorSelector2.SelectedItem as MyColor;

                        switch (InstanceSelector.SelectedItem as string)
                        {
                            case "All":
                                switch (EffectSelector.SelectedItem as string)
                                {
                                    // Using SetAll instead of choosing the Instance will set all devices to the static color. No effects
                                    case "Static": Chroma.Instance.SetAll(oSelectedColor.Color); break;
                                    // Fades in to the first color, then out, then back in to the second color, fade out, repeat
                                    case "Breathing":
                                        {
                                            Chroma.Instance.Mouse.SetBreathing(oSelectedColor.Color, oSelectedColor2.Color);        // Not supported on the Naga
                                            Chroma.Instance.Keyboard.SetBreathing(oSelectedColor.Color, oSelectedColor2.Color);     
                                            Chroma.Instance.Keypad.SetBreathing(oSelectedColor.Color, oSelectedColor2.Color);       // A Keypad is the Razer Orbweaver Chroma or the Razer Tartus Chroma
                                            Chroma.Instance.Mousepad.SetBreathing(oSelectedColor.Color, oSelectedColor2.Color);
                                            Chroma.Instance.Headset.SetBreathing(oSelectedColor.Color);                             // Only supports one color fading
                                        }
                                        break;
                                    // Rainbow wave from left to right. Doesn't seem like you can select a color to wave. Also not supported on headsets
                                    case "Wave":
                                        {
                                            Chroma.Instance.Mouse.SetWave(Corale.Colore.Razer.Mouse.Effects.Direction.BackToFront);     // Not supported on the Naga
                                            Chroma.Instance.Keyboard.SetWave(Corale.Colore.Razer.Keyboard.Effects.Direction.LeftToRight);
                                            Chroma.Instance.Keypad.SetWave(Corale.Colore.Razer.Keypad.Effects.Direction.LeftToRight);
                                            Chroma.Instance.Mousepad.SetWave(Corale.Colore.Razer.Mousepad.Effects.Direction.LeftToRight);
                                        }
                                        break;
                                    // Lights up individual keys as you press them. Obviously not supported on Headset and Mousepad
                                    case "Reactive":
                                        {
                                            Chroma.Instance.Mouse.SetReactive(Corale.Colore.Razer.Mouse.Effects.Duration.Medium, oSelectedColor.Color);      // Not supported on the Naga
                                            Chroma.Instance.Keyboard.SetReactive(oSelectedColor.Color, Corale.Colore.Razer.Keyboard.Effects.Duration.Medium);
                                            Chroma.Instance.Keypad.SetReactive(Corale.Colore.Razer.Keypad.Effects.Duration.Medium, oSelectedColor.Color);
                                        }
                                        break;

                                    default: break;
                                }
                                break;
                            // SetAll used in this way will set the Instance to the static color. No effects
                            case "Mouse": Chroma.Instance.Mouse.SetAll(oSelectedColor.Color); break;
                            case "Keyboard": Chroma.Instance.Keyboard.SetAll(oSelectedColor.Color); break;
                            case "Keypad": Chroma.Instance.Keypad.SetAll(oSelectedColor.Color); break;
                            case "Mousepad": Chroma.Instance.Mousepad.SetAll(oSelectedColor.Color); break;
                            default: break;
                        }

                        SetColorButton.Enabled = false;     // After applying the setting, make sure the user cannot click the button again
                        break;
                    }
               
                default: break;     // Otherwise do nothing
            }
        }

        private void ColorSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetColorButton.Enabled = true;      // Since a setting changed, make the apply button functional again
        }

        private void InstanceSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetColorButton.Enabled = true;      // Since a setting changed, make the apply button functional again
        }

        private void EffectSeletor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetColorButton.Enabled = true;      // Since a setting changed, make the apply button functional again

            switch (EffectSelector.SelectedItem as string)
            {
                case "Breathing": ColorSelector2.Show(); break;     // If the user selected Breathing then they are allowed to choose a second color
                default: ColorSelector2.Hide(); break;
            }
        }
    }
}
