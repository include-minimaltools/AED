
namespace AED
{
    partial class RA7
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.btnEnqueue = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.rbCopy = new System.Windows.Forms.RadioButton();
            this.rbPop = new System.Windows.Forms.RadioButton();
            this.rbPeek = new System.Windows.Forms.RadioButton();
            this.lbStack = new System.Windows.Forms.ListBox();
            this.lbRowCopy = new System.Windows.Forms.ListBox();
            this.lbPrint = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elemento";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(154, 22);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(100, 20);
            this.txtItem.TabIndex = 1;
            this.txtItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItem_KeyPress);
            // 
            // btnEnqueue
            // 
            this.btnEnqueue.Location = new System.Drawing.Point(293, 19);
            this.btnEnqueue.Name = "btnEnqueue";
            this.btnEnqueue.Size = new System.Drawing.Size(83, 23);
            this.btnEnqueue.TabIndex = 2;
            this.btnEnqueue.Text = "Enqueue";
            this.btnEnqueue.UseVisualStyleBackColor = true;
            this.btnEnqueue.Click += new System.EventHandler(this.btnEnqueue_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(48, 68);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // rbCopy
            // 
            this.rbCopy.AutoSize = true;
            this.rbCopy.Location = new System.Drawing.Point(175, 71);
            this.rbCopy.Name = "rbCopy";
            this.rbCopy.Size = new System.Drawing.Size(55, 17);
            this.rbCopy.TabIndex = 4;
            this.rbCopy.TabStop = true;
            this.rbCopy.Text = "Copiar";
            this.rbCopy.UseVisualStyleBackColor = true;
            this.rbCopy.CheckedChanged += new System.EventHandler(this.rbCopy_CheckedChanged);
            // 
            // rbPop
            // 
            this.rbPop.AutoSize = true;
            this.rbPop.Location = new System.Drawing.Point(273, 71);
            this.rbPop.Name = "rbPop";
            this.rbPop.Size = new System.Drawing.Size(69, 17);
            this.rbPop.TabIndex = 5;
            this.rbPop.TabStop = true;
            this.rbPop.Text = "Dequeue";
            this.rbPop.UseVisualStyleBackColor = true;
            this.rbPop.CheckedChanged += new System.EventHandler(this.rbDequeue_CheckedChanged);
            // 
            // rbPeek
            // 
            this.rbPeek.AutoSize = true;
            this.rbPeek.Location = new System.Drawing.Point(363, 71);
            this.rbPeek.Name = "rbPeek";
            this.rbPeek.Size = new System.Drawing.Size(50, 17);
            this.rbPeek.TabIndex = 6;
            this.rbPeek.TabStop = true;
            this.rbPeek.Text = "Peek";
            this.rbPeek.UseVisualStyleBackColor = true;
            this.rbPeek.CheckedChanged += new System.EventHandler(this.rbPeek_CheckedChanged);
            // 
            // lbStack
            // 
            this.lbStack.FormattingEnabled = true;
            this.lbStack.Location = new System.Drawing.Point(25, 129);
            this.lbStack.Name = "lbStack";
            this.lbStack.Size = new System.Drawing.Size(120, 121);
            this.lbStack.TabIndex = 7;
            // 
            // lbRowCopy
            // 
            this.lbRowCopy.FormattingEnabled = true;
            this.lbRowCopy.Location = new System.Drawing.Point(151, 129);
            this.lbRowCopy.Name = "lbRowCopy";
            this.lbRowCopy.Size = new System.Drawing.Size(133, 121);
            this.lbRowCopy.TabIndex = 8;
            // 
            // lbPrint
            // 
            this.lbPrint.FormattingEnabled = true;
            this.lbPrint.Location = new System.Drawing.Point(293, 129);
            this.lbPrint.Name = "lbPrint";
            this.lbPrint.Size = new System.Drawing.Size(132, 121);
            this.lbPrint.TabIndex = 9;
            // 
            // RA7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 285);
            this.Controls.Add(this.lbPrint);
            this.Controls.Add(this.lbRowCopy);
            this.Controls.Add(this.lbStack);
            this.Controls.Add(this.rbPeek);
            this.Controls.Add(this.rbPop);
            this.Controls.Add(this.rbCopy);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnEnqueue);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RA7";
            this.Text = "RA7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Button btnEnqueue;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.RadioButton rbCopy;
        private System.Windows.Forms.RadioButton rbPop;
        private System.Windows.Forms.RadioButton rbPeek;
        private System.Windows.Forms.ListBox lbStack;
        private System.Windows.Forms.ListBox lbRowCopy;
        private System.Windows.Forms.ListBox lbPrint;
    }
}

