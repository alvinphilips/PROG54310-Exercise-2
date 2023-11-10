namespace PROG54310_Exercise_2
{
    partial class ControlYUV
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
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            panel_Y = new System.Windows.Forms.Panel();
            lbl_Y_val = new System.Windows.Forms.Label();
            slider_Y = new System.Windows.Forms.TrackBar();
            lbl_Y = new System.Windows.Forms.Label();
            panel_U = new System.Windows.Forms.Panel();
            lbl_U_val = new System.Windows.Forms.Label();
            slider_U = new System.Windows.Forms.TrackBar();
            lbl_U = new System.Windows.Forms.Label();
            panel_V = new System.Windows.Forms.Panel();
            lbl_V_val = new System.Windows.Forms.Label();
            slider_V = new System.Windows.Forms.TrackBar();
            lbl_V = new System.Windows.Forms.Label();
            chk_InvertColors = new System.Windows.Forms.CheckBox();
            flowLayoutPanel1.SuspendLayout();
            panel_Y.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)slider_Y).BeginInit();
            panel_U.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)slider_U).BeginInit();
            panel_V.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)slider_V).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(panel_Y);
            flowLayoutPanel1.Controls.Add(panel_U);
            flowLayoutPanel1.Controls.Add(panel_V);
            flowLayoutPanel1.Controls.Add(chk_InvertColors);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel_Y
            // 
            panel_Y.Controls.Add(lbl_Y_val);
            panel_Y.Controls.Add(slider_Y);
            panel_Y.Controls.Add(lbl_Y);
            panel_Y.Location = new System.Drawing.Point(3, 3);
            panel_Y.Name = "panel_Y";
            panel_Y.Size = new System.Drawing.Size(800, 78);
            panel_Y.TabIndex = 0;
            // 
            // lbl_Y_val
            // 
            lbl_Y_val.AutoSize = true;
            lbl_Y_val.Location = new System.Drawing.Point(733, 30);
            lbl_Y_val.Name = "lbl_Y_val";
            lbl_Y_val.Size = new System.Drawing.Size(35, 15);
            lbl_Y_val.TabIndex = 2;
            lbl_Y_val.Text = "100%";
            // 
            // slider_Y
            // 
            slider_Y.BackColor = System.Drawing.SystemColors.Control;
            slider_Y.Location = new System.Drawing.Point(29, 30);
            slider_Y.Maximum = 200;
            slider_Y.Name = "slider_Y";
            slider_Y.Size = new System.Drawing.Size(682, 45);
            slider_Y.TabIndex = 1;
            slider_Y.Value = 100;
            slider_Y.Scroll += slider_Y_Scroll;
            // 
            // lbl_Y
            // 
            lbl_Y.AutoSize = true;
            lbl_Y.Location = new System.Drawing.Point(9, 30);
            lbl_Y.Name = "lbl_Y";
            lbl_Y.Size = new System.Drawing.Size(14, 15);
            lbl_Y.TabIndex = 0;
            lbl_Y.Text = "Y";
            // 
            // panel_U
            // 
            panel_U.Controls.Add(lbl_U_val);
            panel_U.Controls.Add(slider_U);
            panel_U.Controls.Add(lbl_U);
            panel_U.Location = new System.Drawing.Point(3, 87);
            panel_U.Name = "panel_U";
            panel_U.Size = new System.Drawing.Size(800, 78);
            panel_U.TabIndex = 3;
            // 
            // lbl_U_val
            // 
            lbl_U_val.AutoSize = true;
            lbl_U_val.Location = new System.Drawing.Point(733, 30);
            lbl_U_val.Name = "lbl_U_val";
            lbl_U_val.Size = new System.Drawing.Size(35, 15);
            lbl_U_val.TabIndex = 2;
            lbl_U_val.Text = "100%";
            // 
            // slider_U
            // 
            slider_U.BackColor = System.Drawing.SystemColors.Control;
            slider_U.Location = new System.Drawing.Point(29, 30);
            slider_U.Maximum = 200;
            slider_U.Name = "slider_U";
            slider_U.Size = new System.Drawing.Size(682, 45);
            slider_U.TabIndex = 1;
            slider_U.Value = 100;
            slider_U.Scroll += slider_U_Scroll;
            // 
            // lbl_U
            // 
            lbl_U.AutoSize = true;
            lbl_U.Location = new System.Drawing.Point(9, 30);
            lbl_U.Name = "lbl_U";
            lbl_U.Size = new System.Drawing.Size(15, 15);
            lbl_U.TabIndex = 0;
            lbl_U.Text = "U";
            // 
            // panel_V
            // 
            panel_V.Controls.Add(lbl_V_val);
            panel_V.Controls.Add(slider_V);
            panel_V.Controls.Add(lbl_V);
            panel_V.Location = new System.Drawing.Point(3, 171);
            panel_V.Name = "panel_V";
            panel_V.Size = new System.Drawing.Size(800, 78);
            panel_V.TabIndex = 4;
            // 
            // lbl_V_val
            // 
            lbl_V_val.AutoSize = true;
            lbl_V_val.Location = new System.Drawing.Point(733, 30);
            lbl_V_val.Name = "lbl_V_val";
            lbl_V_val.Size = new System.Drawing.Size(35, 15);
            lbl_V_val.TabIndex = 2;
            lbl_V_val.Text = "100%";
            // 
            // slider_V
            // 
            slider_V.BackColor = System.Drawing.SystemColors.Control;
            slider_V.Location = new System.Drawing.Point(29, 30);
            slider_V.Maximum = 200;
            slider_V.Name = "slider_V";
            slider_V.Size = new System.Drawing.Size(682, 45);
            slider_V.TabIndex = 1;
            slider_V.Value = 100;
            slider_V.Scroll += slider_V_Scroll;
            // 
            // lbl_V
            // 
            lbl_V.AutoSize = true;
            lbl_V.Location = new System.Drawing.Point(9, 30);
            lbl_V.Name = "lbl_V";
            lbl_V.Size = new System.Drawing.Size(14, 15);
            lbl_V.TabIndex = 0;
            lbl_V.Text = "V";
            // 
            // chk_InvertColors
            // 
            chk_InvertColors.AutoSize = true;
            chk_InvertColors.Location = new System.Drawing.Point(3, 282);
            chk_InvertColors.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            chk_InvertColors.Name = "chk_InvertColors";
            chk_InvertColors.Size = new System.Drawing.Size(93, 19);
            chk_InvertColors.TabIndex = 5;
            chk_InvertColors.Text = "Invert Colors";
            chk_InvertColors.UseVisualStyleBackColor = true;
            chk_InvertColors.CheckedChanged += chk_InvertColors_CheckedChanged;
            // 
            // ControlYUV
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "ControlYUV";
            Text = "ControlYUV";
            TopMost = true;
            Load += ControlYUV_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel_Y.ResumeLayout(false);
            panel_Y.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)slider_Y).EndInit();
            panel_U.ResumeLayout(false);
            panel_U.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)slider_U).EndInit();
            panel_V.ResumeLayout(false);
            panel_V.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)slider_V).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel_Y;
        private System.Windows.Forms.Label lbl_Y;
        private System.Windows.Forms.Label lbl_Y_val;
        private System.Windows.Forms.TrackBar slider_Y;
        private System.Windows.Forms.Panel panel_U;
        private System.Windows.Forms.Label lbl_U_val;
        private System.Windows.Forms.TrackBar slider_U;
        private System.Windows.Forms.Label lbl_U;
        private System.Windows.Forms.Panel panel_V;
        private System.Windows.Forms.Label lbl_V_val;
        private System.Windows.Forms.TrackBar slider_V;
        private System.Windows.Forms.Label lbl_V;
        private System.Windows.Forms.CheckBox chk_InvertColors;
    }
}