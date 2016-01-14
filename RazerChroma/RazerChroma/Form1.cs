using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Corale.Colore.Core;
using ColoreColor = Corale.Colore.Core.Color;
using Corale.Colore.Razer.Keypad;

namespace RazerChroma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ColorSelector.Items.Add(new MyColor(ColoreColor.Red, "Red"));
            ColorSelector.Items.Add(new MyColor(ColoreColor.Green, "Green"));
            ColorSelector.Items.Add(new MyColor(ColoreColor.Blue, "Blue"));
            ColorSelector.Items.Add(new MyColor(new ColoreColor(0, 0, 0), "None"));

            ColorSelector.SelectedIndex = 0;

            object[] oContainer = new object[ColorSelector.Items.Count];
            ColorSelector.Items.CopyTo(oContainer, 0);
            ColorSelector2.Items.AddRange(oContainer);

            ColorSelector2.SelectedIndex = 0;

            InstanceSelector.Items.Add("All");
            InstanceSelector.Items.Add("Mouse");
            InstanceSelector.Items.Add("Keyboard");
            InstanceSelector.Items.Add("Keypad");
            InstanceSelector.Items.Add("Mousepad");
            InstanceSelector.Items.Add("Headset");

            InstanceSelector.SelectedIndex = 0;

            EffectSelector.Items.Add("Static");
            EffectSelector.Items.Add("Breathing");
            EffectSelector.Items.Add("Wave");
            EffectSelector.Items.Add("Reactive");

            EffectSelector.SelectedIndex = 0;

            ColorSelector2.Hide();
        }

        private void SetColorButton_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    {
                        MyColor oSelectedColor = ColorSelector.SelectedItem as MyColor;
                        MyColor oSelectedColor2 = ColorSelector2.SelectedItem as MyColor;

                        switch (InstanceSelector.SelectedItem as string)
                        {
                            case "All":
                                switch (EffectSelector.SelectedItem as string)
                                {
                                    case "Static": Chroma.Instance.SetAll(oSelectedColor.Color); break;
                                    case "Breathing":
                                        {
                                            Chroma.Instance.Mouse.SetBreathing(oSelectedColor.Color, oSelectedColor2.Color);
                                            Chroma.Instance.Keyboard.SetBreathing(oSelectedColor.Color, oSelectedColor2.Color);
                                            Chroma.Instance.Keypad.SetBreathing(oSelectedColor.Color, oSelectedColor2.Color);
                                            Chroma.Instance.Mousepad.SetBreathing(oSelectedColor.Color, oSelectedColor2.Color);
                                            Chroma.Instance.Headset.SetBreathing(oSelectedColor.Color);
                                        }
                                        break;
                                    case "Wave":
                                        {
                                            Chroma.Instance.Mouse.SetWave(Corale.Colore.Razer.Mouse.Effects.Direction.BackToFront);
                                            Chroma.Instance.Keyboard.SetWave(Corale.Colore.Razer.Keyboard.Effects.Direction.LeftToRight);
                                            Chroma.Instance.Keypad.SetWave(Corale.Colore.Razer.Keypad.Effects.Direction.LeftToRight);
                                            Chroma.Instance.Mousepad.SetWave(Corale.Colore.Razer.Mousepad.Effects.Direction.LeftToRight);
                                        }
                                        break;
                                    case "Reactive":
                                        {
                                            Chroma.Instance.Mouse.SetReactive(Corale.Colore.Razer.Mouse.Effects.Duration.Medium, oSelectedColor.Color);
                                            Chroma.Instance.Keyboard.SetReactive(oSelectedColor.Color, Corale.Colore.Razer.Keyboard.Effects.Duration.Medium);
                                            Chroma.Instance.Keypad.SetReactive(Corale.Colore.Razer.Keypad.Effects.Duration.Medium, oSelectedColor.Color);
                                        }
                                        break;

                                    default: break;
                                }
                                break;
                            case "Mouse": Chroma.Instance.Mouse.SetAll(oSelectedColor.Color); break;
                            case "Keyboard": Chroma.Instance.Keyboard.SetAll(oSelectedColor.Color); break;
                            case "Keypad": Chroma.Instance.Keypad.SetAll(oSelectedColor.Color); break;
                            case "Mousepad": Chroma.Instance.Mousepad.SetAll(oSelectedColor.Color); break;
                            default: break;
                        }

                        SetColorButton.Enabled = false;
                        break;
                    }

                default: Chroma.Instance.Keypad.SetBreathing(new Corale.Colore.Razer.Keypad.Effects.Breathing(ColoreColor.Blue, ColoreColor.Blue)); break;
            }
        }

        private void ColorSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetColorButton.Enabled = true;
        }

        private void InstanceSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetColorButton.Enabled = true;
        }

        private void EffectSeletor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetColorButton.Enabled = true;

            switch (EffectSelector.SelectedItem as string)
            {
                case "Breathing": ColorSelector2.Show(); break;
                default: ColorSelector2.Hide(); break;
            }
        }
    }
}
