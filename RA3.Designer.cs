namespace AED
{
    partial class RA3
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.lbNumbers = new System.Windows.Forms.ListBox();
            this.cbOrderMethods = new System.Windows.Forms.ComboBox();
            this.txtOrderResult = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblElements = new System.Windows.Forms.Label();
            this.lblComparisons = new System.Windows.Forms.Label();
            this.lblMovements = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 50);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(57, 20);
            this.txtInput.TabIndex = 0;
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtInput_KeyPress);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(168, 281);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(57, 23);
            this.btnClean.TabIndex = 1;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // lbNumbers
            // 
            this.lbNumbers.FormattingEnabled = true;
            this.lbNumbers.Location = new System.Drawing.Point(12, 76);
            this.lbNumbers.Name = "lbNumbers";
            this.lbNumbers.Size = new System.Drawing.Size(57, 199);
            this.lbNumbers.TabIndex = 2;
            // 
            // cbOrderMethods
            // 
            this.cbOrderMethods.FormattingEnabled = true;
            this.cbOrderMethods.Location = new System.Drawing.Point(85, 49);
            this.cbOrderMethods.Name = "cbOrderMethods";
            this.cbOrderMethods.Size = new System.Drawing.Size(140, 21);
            this.cbOrderMethods.TabIndex = 3;
            this.cbOrderMethods.SelectedIndexChanged += new System.EventHandler(this.CbOrderMethods_SelectedIndexChanged);
            // 
            // txtOrderResult
            // 
            this.txtOrderResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOrderResult.Location = new System.Drawing.Point(85, 76);
            this.txtOrderResult.Name = "txtOrderResult";
            this.txtOrderResult.Size = new System.Drawing.Size(140, 199);
            this.txtOrderResult.TabIndex = 4;
            this.txtOrderResult.Text = "";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingresa un número";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(82, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Método de ordenamiento";
            // 
            // lblElements
            // 
            this.lblElements.Location = new System.Drawing.Point(12, 286);
            this.lblElements.Name = "lblElements";
            this.lblElements.Size = new System.Drawing.Size(130, 18);
            this.lblElements.TabIndex = 7;
            this.lblElements.Text = "Elementos ingresados: 0";
            // 
            // lblComparisons
            // 
            this.lblComparisons.Location = new System.Drawing.Point(12, 304);
            this.lblComparisons.Name = "lblComparisons";
            this.lblComparisons.Size = new System.Drawing.Size(130, 18);
            this.lblComparisons.TabIndex = 8;
            this.lblComparisons.Text = "Comparaciones: 0";
            // 
            // lblMovements
            // 
            this.lblMovements.Location = new System.Drawing.Point(12, 322);
            this.lblMovements.Name = "lblMovements";
            this.lblMovements.Size = new System.Drawing.Size(130, 18);
            this.lblMovements.TabIndex = 9;
            this.lblMovements.Text = "Movimientos: 0";
            // 
            // RA3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 343);
            this.Controls.Add(this.lblMovements);
            this.Controls.Add(this.lblComparisons);
            this.Controls.Add(this.lblElements);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOrderResult);
            this.Controls.Add(this.cbOrderMethods);
            this.Controls.Add(this.lbNumbers);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.txtInput);
            this.Name = "RA3";
            this.Text = "RA3 - RA 4";
            this.Load += new System.EventHandler(this.RA3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.ListBox lbNumbers;
        private System.Windows.Forms.ComboBox cbOrderMethods;
        private System.Windows.Forms.RichTextBox txtOrderResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblElements;
        private System.Windows.Forms.Label lblComparisons;
        private System.Windows.Forms.Label lblMovements;
    }
}