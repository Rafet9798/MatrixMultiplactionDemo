namespace MatrixMultiplactionDemo
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
            this.ndM1Row = new System.Windows.Forms.NumericUpDown();
            this.ndM1Column = new System.Windows.Forms.NumericUpDown();
            this.ndM2Row = new System.Windows.Forms.NumericUpDown();
            this.ndM2Column = new System.Windows.Forms.NumericUpDown();
            this.btnCreateMatrix = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ndM1Row)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndM1Column)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndM2Row)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndM2Column)).BeginInit();
            this.SuspendLayout();
            // 
            // ndM1Row
            // 
            this.ndM1Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndM1Row.Location = new System.Drawing.Point(125, 111);
            this.ndM1Row.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ndM1Row.Name = "ndM1Row";
            this.ndM1Row.Size = new System.Drawing.Size(79, 34);
            this.ndM1Row.TabIndex = 0;
            this.ndM1Row.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ndM1Column
            // 
            this.ndM1Column.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndM1Column.Location = new System.Drawing.Point(253, 111);
            this.ndM1Column.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ndM1Column.Name = "ndM1Column";
            this.ndM1Column.Size = new System.Drawing.Size(79, 34);
            this.ndM1Column.TabIndex = 1;
            this.ndM1Column.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ndM1Column.ValueChanged += new System.EventHandler(this.ndM1Column_ValueChanged);
            // 
            // ndM2Row
            // 
            this.ndM2Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndM2Row.Location = new System.Drawing.Point(125, 172);
            this.ndM2Row.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ndM2Row.Name = "ndM2Row";
            this.ndM2Row.ReadOnly = true;
            this.ndM2Row.Size = new System.Drawing.Size(79, 34);
            this.ndM2Row.TabIndex = 2;
            this.ndM2Row.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ndM2Column
            // 
            this.ndM2Column.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndM2Column.Location = new System.Drawing.Point(253, 172);
            this.ndM2Column.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ndM2Column.Name = "ndM2Column";
            this.ndM2Column.Size = new System.Drawing.Size(79, 34);
            this.ndM2Column.TabIndex = 3;
            this.ndM2Column.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCreateMatrix
            // 
            this.btnCreateMatrix.Location = new System.Drawing.Point(125, 228);
            this.btnCreateMatrix.Name = "btnCreateMatrix";
            this.btnCreateMatrix.Size = new System.Drawing.Size(207, 30);
            this.btnCreateMatrix.TabIndex = 4;
            this.btnCreateMatrix.Text = "Create matrix";
            this.btnCreateMatrix.UseVisualStyleBackColor = true;
            this.btnCreateMatrix.Click += new System.EventHandler(this.btnCreateMatrix_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 291);
            this.Controls.Add(this.btnCreateMatrix);
            this.Controls.Add(this.ndM2Column);
            this.Controls.Add(this.ndM2Row);
            this.Controls.Add(this.ndM1Column);
            this.Controls.Add(this.ndM1Row);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ndM1Row)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndM1Column)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndM2Row)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndM2Column)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ndM1Row;
        private System.Windows.Forms.NumericUpDown ndM1Column;
        private System.Windows.Forms.NumericUpDown ndM2Row;
        private System.Windows.Forms.NumericUpDown ndM2Column;
        private System.Windows.Forms.Button btnCreateMatrix;
    }
}

