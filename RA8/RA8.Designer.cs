namespace AED.RA8
{
    partial class RA8
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEmployee,
            this.tsmiQuery,
            this.tsmiSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(658, 151);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiEmployee
            // 
            this.tsmiEmployee.Image = global::AED.Properties.Resources.employee;
            this.tsmiEmployee.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiEmployee.Name = "tsmiEmployee";
            this.tsmiEmployee.Size = new System.Drawing.Size(140, 147);
            this.tsmiEmployee.Text = "Empleado";
            this.tsmiEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiEmployee.Click += new System.EventHandler(this.TsmiEmployee_Click);
            // 
            // tsmiQuery
            // 
            this.tsmiQuery.Image = global::AED.Properties.Resources.quey;
            this.tsmiQuery.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiQuery.Name = "tsmiQuery";
            this.tsmiQuery.Size = new System.Drawing.Size(140, 147);
            this.tsmiQuery.Text = "Solicitud";
            this.tsmiQuery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiQuery.Click += new System.EventHandler(this.TsmiQuery_Click);
            // 
            // tsmiSalir
            // 
            this.tsmiSalir.Image = global::AED.Properties.Resources.powered_on;
            this.tsmiSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSalir.Name = "tsmiSalir";
            this.tsmiSalir.Size = new System.Drawing.Size(140, 147);
            this.tsmiSalir.Text = "Salir";
            this.tsmiSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiSalir.Click += new System.EventHandler(this.TsmiSalir_Click);
            // 
            // MdiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MdiMain";
            this.Text = "RA8";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmployee;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuery;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalir;
    }
}