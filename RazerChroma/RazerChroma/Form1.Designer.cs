namespace RazerChroma
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ColorSelector = new System.Windows.Forms.ComboBox();
            this.SetColorButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.InstanceSelector = new System.Windows.Forms.ComboBox();
            this.EffectSelector = new System.Windows.Forms.ComboBox();
            this.ColorSelector2 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColorSelector
            // 
            this.ColorSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorSelector.FormattingEnabled = true;
            this.ColorSelector.Location = new System.Drawing.Point(6, 6);
            this.ColorSelector.Name = "ColorSelector";
            this.ColorSelector.Size = new System.Drawing.Size(121, 21);
            this.ColorSelector.TabIndex = 0;
            this.ColorSelector.SelectedIndexChanged += new System.EventHandler(this.ColorSelector_SelectedIndexChanged);
            // 
            // SetColorButton
            // 
            this.SetColorButton.Location = new System.Drawing.Point(223, 182);
            this.SetColorButton.Name = "SetColorButton";
            this.SetColorButton.Size = new System.Drawing.Size(75, 23);
            this.SetColorButton.TabIndex = 1;
            this.SetColorButton.Text = "Apply";
            this.SetColorButton.UseVisualStyleBackColor = true;
            this.SetColorButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SetColorButton_MouseUp);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(312, 237);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ColorSelector2);
            this.tabPage1.Controls.Add(this.EffectSelector);
            this.tabPage1.Controls.Add(this.InstanceSelector);
            this.tabPage1.Controls.Add(this.SetColorButton);
            this.tabPage1.Controls.Add(this.ColorSelector);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(304, 211);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(304, 211);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // InstanceSelector
            // 
            this.InstanceSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InstanceSelector.FormattingEnabled = true;
            this.InstanceSelector.Location = new System.Drawing.Point(177, 6);
            this.InstanceSelector.Name = "InstanceSelector";
            this.InstanceSelector.Size = new System.Drawing.Size(121, 21);
            this.InstanceSelector.TabIndex = 2;
            this.InstanceSelector.SelectedIndexChanged += new System.EventHandler(this.InstanceSelector_SelectedIndexChanged);
            // 
            // EffectSelector
            // 
            this.EffectSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EffectSelector.FormattingEnabled = true;
            this.EffectSelector.Location = new System.Drawing.Point(177, 33);
            this.EffectSelector.Name = "EffectSelector";
            this.EffectSelector.Size = new System.Drawing.Size(121, 21);
            this.EffectSelector.TabIndex = 3;
            this.EffectSelector.SelectedIndexChanged += new System.EventHandler(this.EffectSeletor_SelectedIndexChanged);
            // 
            // ColorSelector2
            // 
            this.ColorSelector2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorSelector2.FormattingEnabled = true;
            this.ColorSelector2.Location = new System.Drawing.Point(6, 33);
            this.ColorSelector2.Name = "ColorSelector2";
            this.ColorSelector2.Size = new System.Drawing.Size(121, 21);
            this.ColorSelector2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 261);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Razer Chroma Test Form";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ColorSelector;
        private System.Windows.Forms.Button SetColorButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox InstanceSelector;
        private System.Windows.Forms.ComboBox EffectSelector;
        private System.Windows.Forms.ComboBox ColorSelector2;
    }
}

