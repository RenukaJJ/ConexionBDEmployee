namespace ConexionBDEmployee
{
    partial class Form1
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
            this.btnCNT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbJob = new System.Windows.Forms.TextBox();
            this.tbMinSal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaxSal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCNT
            // 
            this.btnCNT.Location = new System.Drawing.Point(28, 27);
            this.btnCNT.Name = "btnCNT";
            this.btnCNT.Size = new System.Drawing.Size(144, 23);
            this.btnCNT.TabIndex = 0;
            this.btnCNT.Text = "Show Data";
            this.btnCNT.UseVisualStyleBackColor = true;
            this.btnCNT.Click += new System.EventHandler(this.btnCNT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "job title";
            // 
            // tbJob
            // 
            this.tbJob.Location = new System.Drawing.Point(97, 92);
            this.tbJob.Name = "tbJob";
            this.tbJob.Size = new System.Drawing.Size(100, 22);
            this.tbJob.TabIndex = 2;
            // 
            // tbMinSal
            // 
            this.tbMinSal.Location = new System.Drawing.Point(97, 127);
            this.tbMinSal.Name = "tbMinSal";
            this.tbMinSal.Size = new System.Drawing.Size(100, 22);
            this.tbMinSal.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "min salary";
            // 
            // tbMaxSal
            // 
            this.tbMaxSal.Location = new System.Drawing.Point(97, 165);
            this.tbMaxSal.Name = "tbMaxSal";
            this.tbMaxSal.Size = new System.Drawing.Size(100, 22);
            this.tbMaxSal.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "max salary";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(28, 217);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(221, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(529, 395);
            this.dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbMaxSal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMinSal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbJob);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCNT);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCNT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbJob;
        private System.Windows.Forms.TextBox tbMinSal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaxSal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

