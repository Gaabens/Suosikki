namespace Suosikki
{
    partial class SuosikkiForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            NimiTB = new TextBox();
            VastausLB = new Label();
            TarkastaBT = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(503, 25);
            label1.TabIndex = 0;
            label1.Text = "Anna nimesi niin tarkistan onko se 50 suosituimman joukossa:";
            // 
            // NimiTB
            // 
            NimiTB.Location = new Point(532, 13);
            NimiTB.Name = "NimiTB";
            NimiTB.Size = new Size(229, 31);
            NimiTB.TabIndex = 1;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Location = new Point(20, 69);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(72, 25);
            VastausLB.TabIndex = 2;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            // 
            // TarkastaBT
            // 
            TarkastaBT.Location = new Point(532, 60);
            TarkastaBT.Name = "TarkastaBT";
            TarkastaBT.Size = new Size(229, 34);
            TarkastaBT.TabIndex = 3;
            TarkastaBT.Text = "Tarkasta";
            TarkastaBT.UseVisualStyleBackColor = true;
            TarkastaBT.Click += TarkastaBT_Click;
            // 
            // SuosikkiForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TarkastaBT);
            Controls.Add(VastausLB);
            Controls.Add(NimiTB);
            Controls.Add(label1);
            Name = "SuosikkiForm";
            Text = "Onko nimesi suosittujen joukossa?";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NimiTB;
        private Label VastausLB;
        private Button TarkastaBT;
    }
}
