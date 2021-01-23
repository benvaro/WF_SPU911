namespace _06_CheckBox
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
            this.cbInfo = new System.Windows.Forms.CheckBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.lbLanguages = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbInfo
            // 
            this.cbInfo.Location = new System.Drawing.Point(3, 3);
            this.cbInfo.Name = "cbInfo";
            this.cbInfo.Size = new System.Drawing.Size(118, 89);
            this.cbInfo.TabIndex = 0;
            this.cbInfo.Text = "I agree with policies of use";
            this.cbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbInfo.ThreeState = true;
            this.cbInfo.UseVisualStyleBackColor = true;
            this.cbInfo.CheckedChanged += new System.EventHandler(this.cbInfo_CheckedChanged);
            this.cbInfo.CheckStateChanged += new System.EventHandler(this.cbInfo_CheckStateChanged);
            // 
            // btnGo
            // 
            this.btnGo.Enabled = false;
            this.btnGo.Location = new System.Drawing.Point(3, 98);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(99, 30);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.cbInfo);
            this.splitContainer1.Panel1.Controls.Add(this.btnGo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(727, 416);
            this.splitContainer1.SplitterDistance = 149;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(23, 23);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(47, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "C#";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.MistyRose;
            this.splitContainer2.Panel1.Controls.Add(this.lbLanguages);
            this.splitContainer2.Panel1.Controls.Add(this.checkBox3);
            this.splitContainer2.Panel1.Controls.Add(this.checkBox2);
            this.splitContainer2.Panel1.Controls.Add(this.checkBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.Info;
            this.splitContainer2.Size = new System.Drawing.Size(725, 259);
            this.splitContainer2.SplitterDistance = 241;
            this.splitContainer2.TabIndex = 2;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(23, 65);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(55, 21);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "C++";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(23, 104);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(74, 21);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Python";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lbLanguages
            // 
            this.lbLanguages.AutoSize = true;
            this.lbLanguages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLanguages.Location = new System.Drawing.Point(11, 156);
            this.lbLanguages.Name = "lbLanguages";
            this.lbLanguages.Size = new System.Drawing.Size(2, 19);
            this.lbLanguages.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 416);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbInfo;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label lbLanguages;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

