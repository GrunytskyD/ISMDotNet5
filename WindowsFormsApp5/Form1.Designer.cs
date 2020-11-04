namespace WindowsFormsApp5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGenerateMatrix = new System.Windows.Forms.Button();
            this.LabelRowCount = new System.Windows.Forms.Label();
            this.labelCollCount = new System.Windows.Forms.Label();
            this.dataGridViewMatrix = new System.Windows.Forms.DataGridView();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.numericUpDownRowCount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownColCount = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewSmall = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRowCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSmall)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGenerateMatrix
            // 
            this.buttonGenerateMatrix.Location = new System.Drawing.Point(135, 92);
            this.buttonGenerateMatrix.Name = "buttonGenerateMatrix";
            this.buttonGenerateMatrix.Size = new System.Drawing.Size(120, 23);
            this.buttonGenerateMatrix.TabIndex = 0;
            this.buttonGenerateMatrix.Text = "Генерувати ";
            this.buttonGenerateMatrix.UseVisualStyleBackColor = true;
            this.buttonGenerateMatrix.Click += new System.EventHandler(this.buttonGEnerateMatrix_Click);
            // 
            // LabelRowCount
            // 
            this.LabelRowCount.AutoSize = true;
            this.LabelRowCount.Location = new System.Drawing.Point(47, 38);
            this.LabelRowCount.Name = "LabelRowCount";
            this.LabelRowCount.Size = new System.Drawing.Size(63, 13);
            this.LabelRowCount.TabIndex = 1;
            this.LabelRowCount.Text = "К-ть рядків";
            // 
            // labelCollCount
            // 
            this.labelCollCount.AutoSize = true;
            this.labelCollCount.Location = new System.Drawing.Point(47, 66);
            this.labelCollCount.Name = "labelCollCount";
            this.labelCollCount.Size = new System.Drawing.Size(74, 13);
            this.labelCollCount.TabIndex = 2;
            this.labelCollCount.Text = "К-ть стовпців";
            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(12, 144);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.Size = new System.Drawing.Size(661, 195);
            this.dataGridViewMatrix.TabIndex = 5;
            this.dataGridViewMatrix.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVisualizer_CellContentClick);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonExit.Location = new System.Drawing.Point(602, 12);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(75, 23);
            this.ButtonExit.TabIndex = 6;
            this.ButtonExit.Text = "Вихід";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // numericUpDownRowCount
            // 
            this.numericUpDownRowCount.Location = new System.Drawing.Point(135, 31);
            this.numericUpDownRowCount.Name = "numericUpDownRowCount";
            this.numericUpDownRowCount.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRowCount.TabIndex = 7;
            this.numericUpDownRowCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownColCount
            // 
            this.numericUpDownColCount.Location = new System.Drawing.Point(135, 57);
            this.numericUpDownColCount.Name = "numericUpDownColCount";
            this.numericUpDownColCount.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownColCount.TabIndex = 8;
            this.numericUpDownColCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // dataGridViewSmall
            // 
            this.dataGridViewSmall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSmall.Location = new System.Drawing.Point(319, 31);
            this.dataGridViewSmall.Name = "dataGridViewSmall";
            this.dataGridViewSmall.Size = new System.Drawing.Size(240, 107);
            this.dataGridViewSmall.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 351);
            this.Controls.Add(this.dataGridViewSmall);
            this.Controls.Add(this.numericUpDownColCount);
            this.Controls.Add(this.numericUpDownRowCount);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.dataGridViewMatrix);
            this.Controls.Add(this.labelCollCount);
            this.Controls.Add(this.LabelRowCount);
            this.Controls.Add(this.buttonGenerateMatrix);
            this.MaximumSize = new System.Drawing.Size(705, 389);
            this.MinimumSize = new System.Drawing.Size(200, 156);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Демонстрація роботи з циклами ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRowCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSmall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerateMatrix;
        private System.Windows.Forms.Label LabelRowCount;
        private System.Windows.Forms.Label labelCollCount;
        private System.Windows.Forms.DataGridView dataGridViewMatrix;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.NumericUpDown numericUpDownRowCount;
        private System.Windows.Forms.NumericUpDown numericUpDownColCount;
        private System.Windows.Forms.DataGridView dataGridViewSmall;
    }
}

