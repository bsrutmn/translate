namespace translate
{
    partial class translate
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
            this.txt_ShowPDF = new System.Windows.Forms.RichTextBox();
            this.txt_ShowTranslate = new System.Windows.Forms.RichTextBox();
            this.btn_OpenPDF = new System.Windows.Forms.Button();
            this.btn_Convert = new System.Windows.Forms.Button();
            this.btn_txtsave = new System.Windows.Forms.Button();
            this.txtpdfname = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_Translate = new System.Windows.Forms.Button();
            this.cb_ChooseLanguage = new System.Windows.Forms.ComboBox();
            this.lbl_ChooseLanguage = new System.Windows.Forms.Label();
            this.btn_pdf = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_ShowPDF
            // 
            this.txt_ShowPDF.Location = new System.Drawing.Point(31, 19);
            this.txt_ShowPDF.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ShowPDF.Name = "txt_ShowPDF";
            this.txt_ShowPDF.Size = new System.Drawing.Size(361, 382);
            this.txt_ShowPDF.TabIndex = 0;
            this.txt_ShowPDF.Text = "";
            // 
            // txt_ShowTranslate
            // 
            this.txt_ShowTranslate.Location = new System.Drawing.Point(484, 19);
            this.txt_ShowTranslate.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ShowTranslate.Name = "txt_ShowTranslate";
            this.txt_ShowTranslate.Size = new System.Drawing.Size(361, 382);
            this.txt_ShowTranslate.TabIndex = 1;
            this.txt_ShowTranslate.Text = "";
            // 
            // btn_OpenPDF
            // 
            this.btn_OpenPDF.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_OpenPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_OpenPDF.Location = new System.Drawing.Point(198, 473);
            this.btn_OpenPDF.Margin = new System.Windows.Forms.Padding(2);
            this.btn_OpenPDF.Name = "btn_OpenPDF";
            this.btn_OpenPDF.Size = new System.Drawing.Size(86, 41);
            this.btn_OpenPDF.TabIndex = 2;
            this.btn_OpenPDF.Text = "Open PDF";
            this.btn_OpenPDF.UseVisualStyleBackColor = false;
            this.btn_OpenPDF.Click += new System.EventHandler(this.btn_OpenPDF_Click);
            // 
            // btn_Convert
            // 
            this.btn_Convert.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Convert.Location = new System.Drawing.Point(304, 473);
            this.btn_Convert.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(88, 41);
            this.btn_Convert.TabIndex = 3;
            this.btn_Convert.Text = "Convert";
            this.btn_Convert.UseVisualStyleBackColor = false;
            this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
            // 
            // btn_txtsave
            // 
            this.btn_txtsave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_txtsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_txtsave.Location = new System.Drawing.Point(759, 473);
            this.btn_txtsave.Margin = new System.Windows.Forms.Padding(2);
            this.btn_txtsave.Name = "btn_txtsave";
            this.btn_txtsave.Size = new System.Drawing.Size(86, 41);
            this.btn_txtsave.TabIndex = 4;
            this.btn_txtsave.Text = "Save";
            this.btn_txtsave.UseVisualStyleBackColor = false;
            this.btn_txtsave.Click += new System.EventHandler(this.btn_txtsave_Click);
            // 
            // txtpdfname
            // 
            this.txtpdfname.Location = new System.Drawing.Point(31, 425);
            this.txtpdfname.Margin = new System.Windows.Forms.Padding(2);
            this.txtpdfname.Name = "txtpdfname";
            this.txtpdfname.Size = new System.Drawing.Size(361, 20);
            this.txtpdfname.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_Translate
            // 
            this.btn_Translate.BackColor = System.Drawing.Color.Teal;
            this.btn_Translate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Translate.Location = new System.Drawing.Point(656, 473);
            this.btn_Translate.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Translate.Name = "btn_Translate";
            this.btn_Translate.Size = new System.Drawing.Size(88, 41);
            this.btn_Translate.TabIndex = 6;
            this.btn_Translate.Text = "Translate";
            this.btn_Translate.UseVisualStyleBackColor = false;
            this.btn_Translate.Click += new System.EventHandler(this.btn_Translate_Click);
            // 
            // cb_ChooseLanguage
            // 
            this.cb_ChooseLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_ChooseLanguage.FormattingEnabled = true;
            this.cb_ChooseLanguage.Location = new System.Drawing.Point(713, 425);
            this.cb_ChooseLanguage.Margin = new System.Windows.Forms.Padding(2);
            this.cb_ChooseLanguage.Name = "cb_ChooseLanguage";
            this.cb_ChooseLanguage.Size = new System.Drawing.Size(133, 25);
            this.cb_ChooseLanguage.TabIndex = 7;
            // 
            // lbl_ChooseLanguage
            // 
            this.lbl_ChooseLanguage.AutoSize = true;
            this.lbl_ChooseLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ChooseLanguage.Location = new System.Drawing.Point(580, 428);
            this.lbl_ChooseLanguage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ChooseLanguage.Name = "lbl_ChooseLanguage";
            this.lbl_ChooseLanguage.Size = new System.Drawing.Size(128, 17);
            this.lbl_ChooseLanguage.TabIndex = 8;
            this.lbl_ChooseLanguage.Text = "Choose Language:";
            // 
            // btn_pdf
            // 
            this.btn_pdf.Image = global::translate.Properties.Resources.pdf;
            this.btn_pdf.Location = new System.Drawing.Point(404, 19);
            this.btn_pdf.Name = "btn_pdf";
            this.btn_pdf.Size = new System.Drawing.Size(66, 53);
            this.btn_pdf.TabIndex = 9;
            this.btn_pdf.UseVisualStyleBackColor = true;
            this.btn_pdf.Click += new System.EventHandler(this.btn_pdf_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(451, 454);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // translate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(876, 538);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_pdf);
            this.Controls.Add(this.lbl_ChooseLanguage);
            this.Controls.Add(this.cb_ChooseLanguage);
            this.Controls.Add(this.btn_Translate);
            this.Controls.Add(this.txtpdfname);
            this.Controls.Add(this.btn_txtsave);
            this.Controls.Add(this.btn_Convert);
            this.Controls.Add(this.btn_OpenPDF);
            this.Controls.Add(this.txt_ShowTranslate);
            this.Controls.Add(this.txt_ShowPDF);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "translate";
            this.ShowIcon = false;
            this.Text = "Yandex Translate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txt_ShowPDF;
        private System.Windows.Forms.RichTextBox txt_ShowTranslate;
        private System.Windows.Forms.Button btn_OpenPDF;
        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.Button btn_txtsave;
        private System.Windows.Forms.TextBox txtpdfname;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_Translate;
        private System.Windows.Forms.ComboBox cb_ChooseLanguage;
        private System.Windows.Forms.Label lbl_ChooseLanguage;
        private System.Windows.Forms.Button btn_pdf;
        private System.Windows.Forms.Button button1;
    }
}

