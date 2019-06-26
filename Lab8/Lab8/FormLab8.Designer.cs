namespace Lab8
{
    partial class FormLab8
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
            this.LabelLab8 = new System.Windows.Forms.Label();
            this.GroupBoxInfo = new System.Windows.Forms.GroupBox();
            this.TextBoxYourAge = new System.Windows.Forms.TextBox();
            this.LabelYourName = new System.Windows.Forms.Label();
            this.LabelYourAge = new System.Windows.Forms.Label();
            this.TextBoxYourName = new System.Windows.Forms.TextBox();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.GroupBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelLab8
            // 
            this.LabelLab8.AccessibleName = "";
            this.LabelLab8.AutoSize = true;
            this.LabelLab8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLab8.Location = new System.Drawing.Point(12, 9);
            this.LabelLab8.Name = "LabelLab8";
            this.LabelLab8.Size = new System.Drawing.Size(70, 32);
            this.LabelLab8.TabIndex = 0;
            this.LabelLab8.Text = "lab8";
            // 
            // GroupBoxInfo
            // 
            this.GroupBoxInfo.Controls.Add(this.TextBoxYourAge);
            this.GroupBoxInfo.Controls.Add(this.LabelYourName);
            this.GroupBoxInfo.Controls.Add(this.LabelYourAge);
            this.GroupBoxInfo.Controls.Add(this.TextBoxYourName);
            this.GroupBoxInfo.Location = new System.Drawing.Point(18, 44);
            this.GroupBoxInfo.Name = "GroupBoxInfo";
            this.GroupBoxInfo.Size = new System.Drawing.Size(395, 209);
            this.GroupBoxInfo.TabIndex = 1;
            this.GroupBoxInfo.TabStop = false;
            this.GroupBoxInfo.Text = "Info";
            // 
            // TextBoxYourAge
            // 
            this.TextBoxYourAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxYourAge.Location = new System.Drawing.Point(173, 119);
            this.TextBoxYourAge.Name = "TextBoxYourAge";
            this.TextBoxYourAge.Size = new System.Drawing.Size(169, 38);
            this.TextBoxYourAge.TabIndex = 5;
            this.TextBoxYourAge.TextChanged += new System.EventHandler(this.TextBoxYourAge_TextChanged);
            // 
            // LabelYourName
            // 
            this.LabelYourName.AutoSize = true;
            this.LabelYourName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelYourName.Location = new System.Drawing.Point(0, 54);
            this.LabelYourName.Name = "LabelYourName";
            this.LabelYourName.Size = new System.Drawing.Size(157, 32);
            this.LabelYourName.TabIndex = 2;
            this.LabelYourName.Text = "Your Name";
            // 
            // LabelYourAge
            // 
            this.LabelYourAge.AutoSize = true;
            this.LabelYourAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelYourAge.Location = new System.Drawing.Point(0, 110);
            this.LabelYourAge.Name = "LabelYourAge";
            this.LabelYourAge.Size = new System.Drawing.Size(133, 32);
            this.LabelYourAge.TabIndex = 3;
            this.LabelYourAge.Text = "Your Age";
            // 
            // TextBoxYourName
            // 
            this.TextBoxYourName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxYourName.Location = new System.Drawing.Point(173, 54);
            this.TextBoxYourName.Name = "TextBoxYourName";
            this.TextBoxYourName.Size = new System.Drawing.Size(169, 38);
            this.TextBoxYourName.TabIndex = 4;
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSubmit.Location = new System.Drawing.Point(484, 327);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(131, 54);
            this.ButtonSubmit.TabIndex = 2;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(15, 339);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(0, 32);
            this.OutputLabel.TabIndex = 6;
            // 
            // FormLab8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 403);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.GroupBoxInfo);
            this.Controls.Add(this.LabelLab8);
            this.Location = new System.Drawing.Point(200, 200);
            this.Name = "FormLab8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab8";
            this.GroupBoxInfo.ResumeLayout(false);
            this.GroupBoxInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelLab8;
        private System.Windows.Forms.GroupBox GroupBoxInfo;
        private System.Windows.Forms.Label LabelYourName;
        private System.Windows.Forms.Label LabelYourAge;
        private System.Windows.Forms.TextBox TextBoxYourName;
        private System.Windows.Forms.TextBox TextBoxYourAge;
        private System.Windows.Forms.Button ButtonSubmit;
        private System.Windows.Forms.Label OutputLabel;
    }
}

