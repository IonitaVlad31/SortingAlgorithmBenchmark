namespace SortingAlgorithmBenchmark
{
    partial class Form1
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
            btnStart = new Button();
            cmbNumarElemente = new ComboBox();
            label1 = new Label();
            panelGrafic = new Panel();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(448, 82);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start Test";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += BtnStart_Click;
            // 
            // cmbNumarElemente
            // 
            cmbNumarElemente.FormattingEnabled = true;
            cmbNumarElemente.Location = new Point(419, 48);
            cmbNumarElemente.Name = "cmbNumarElemente";
            cmbNumarElemente.Size = new Size(151, 28);
            cmbNumarElemente.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(433, 25);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 2;
            label1.Text = "Numar elemente:";
            // 
            // panelGrafic
            // 
            panelGrafic.AutoScroll = true;
            panelGrafic.BackColor = Color.White;
            panelGrafic.Location = new Point(109, 126);
            panelGrafic.Name = "panelGrafic";
            panelGrafic.Size = new Size(814, 451);
            panelGrafic.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 597);
            Controls.Add(panelGrafic);
            Controls.Add(label1);
            Controls.Add(cmbNumarElemente);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private ComboBox cmbNumarElemente;
        private Label label1;
        private Panel panelGrafic;
    }
}
