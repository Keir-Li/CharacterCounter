namespace CharacterCounter
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
            this.lbl_countertitle = new System.Windows.Forms.Label();
            this.txtbox_characterstocount = new System.Windows.Forms.TextBox();
            this.lbl_errorblanktext = new System.Windows.Forms.Label();
            this.lbl_creator = new System.Windows.Forms.Label();
            this.btn_count = new System.Windows.Forms.Button();
            this.btn_copycountedcharacters = new System.Windows.Forms.Button();
            this.txtbox_countercharacters = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_countertitle
            // 
            this.lbl_countertitle.AutoSize = true;
            this.lbl_countertitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbl_countertitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_countertitle.Location = new System.Drawing.Point(250, 35);
            this.lbl_countertitle.Name = "lbl_countertitle";
            this.lbl_countertitle.Size = new System.Drawing.Size(263, 32);
            this.lbl_countertitle.TabIndex = 1;
            this.lbl_countertitle.Text = "Character Counter";
            this.lbl_countertitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbox_characterstocount
            // 
            this.txtbox_characterstocount.Location = new System.Drawing.Point(25, 84);
            this.txtbox_characterstocount.Multiline = true;
            this.txtbox_characterstocount.Name = "txtbox_characterstocount";
            this.txtbox_characterstocount.Size = new System.Drawing.Size(760, 173);
            this.txtbox_characterstocount.TabIndex = 3;
            this.txtbox_characterstocount.Text = "Enter Characters to Count...";
            // 
            // lbl_errorblanktext
            // 
            this.lbl_errorblanktext.AutoSize = true;
            this.lbl_errorblanktext.BackColor = System.Drawing.Color.Transparent;
            this.lbl_errorblanktext.ForeColor = System.Drawing.Color.Red;
            this.lbl_errorblanktext.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_errorblanktext.Location = new System.Drawing.Point(22, 336);
            this.lbl_errorblanktext.MinimumSize = new System.Drawing.Size(210, 0);
            this.lbl_errorblanktext.Name = "lbl_errorblanktext";
            this.lbl_errorblanktext.Size = new System.Drawing.Size(210, 32);
            this.lbl_errorblanktext.TabIndex = 11;
            this.lbl_errorblanktext.Text = "Please type characters to \rcount in the text box.";
            this.lbl_errorblanktext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_errorblanktext.Visible = false;
            // 
            // lbl_creator
            // 
            this.lbl_creator.AutoSize = true;
            this.lbl_creator.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F, System.Drawing.FontStyle.Bold);
            this.lbl_creator.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_creator.Location = new System.Drawing.Point(12, 424);
            this.lbl_creator.Name = "lbl_creator";
            this.lbl_creator.Size = new System.Drawing.Size(51, 17);
            this.lbl_creator.TabIndex = 12;
            this.lbl_creator.Text = "Keir Li";
            this.lbl_creator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_count
            // 
            this.btn_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.btn_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_count.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_count.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_count.Location = new System.Drawing.Point(231, 275);
            this.btn_count.Name = "btn_count";
            this.btn_count.Size = new System.Drawing.Size(315, 94);
            this.btn_count.TabIndex = 13;
            this.btn_count.Text = "COUNT";
            this.btn_count.UseVisualStyleBackColor = false;
            this.btn_count.Click += new System.EventHandler(this.btn_count_Click);
            // 
            // btn_copycountedcharacters
            // 
            this.btn_copycountedcharacters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btn_copycountedcharacters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_copycountedcharacters.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_copycountedcharacters.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_copycountedcharacters.Location = new System.Drawing.Point(231, 375);
            this.btn_copycountedcharacters.Name = "btn_copycountedcharacters";
            this.btn_copycountedcharacters.Size = new System.Drawing.Size(315, 63);
            this.btn_copycountedcharacters.TabIndex = 14;
            this.btn_copycountedcharacters.Text = "Copy Result";
            this.btn_copycountedcharacters.UseVisualStyleBackColor = false;
            this.btn_copycountedcharacters.Click += new System.EventHandler(this.btn_copycountedcharacters_Click);
            // 
            // txtbox_countercharacters
            // 
            this.txtbox_countercharacters.Enabled = false;
            this.txtbox_countercharacters.Location = new System.Drawing.Point(566, 278);
            this.txtbox_countercharacters.Multiline = true;
            this.txtbox_countercharacters.Name = "txtbox_countercharacters";
            this.txtbox_countercharacters.Size = new System.Drawing.Size(219, 160);
            this.txtbox_countercharacters.TabIndex = 15;
            this.txtbox_countercharacters.Text = "Counted Characters / Text...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(32, 281);
            this.label1.MinimumSize = new System.Drawing.Size(150, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Maximum of 32767 Characters";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_countercharacters);
            this.Controls.Add(this.btn_copycountedcharacters);
            this.Controls.Add(this.btn_count);
            this.Controls.Add(this.lbl_creator);
            this.Controls.Add(this.lbl_errorblanktext);
            this.Controls.Add(this.txtbox_characterstocount);
            this.Controls.Add(this.lbl_countertitle);
            this.Name = "Form1";
            this.Text = "Character Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_countertitle;
        private System.Windows.Forms.TextBox txtbox_characterstocount;
        private System.Windows.Forms.Label lbl_errorblanktext;
        private System.Windows.Forms.Label lbl_creator;
        private System.Windows.Forms.Button btn_count;
        private System.Windows.Forms.Button btn_copycountedcharacters;
        private System.Windows.Forms.TextBox txtbox_countercharacters;
        private System.Windows.Forms.Label label1;
    }
}

