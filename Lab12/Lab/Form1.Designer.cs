namespace Lab
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet = new Lab.Database1DataSet();
            this.testTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testTableTableAdapter = new Lab.Database1DataSetTableAdapters.TestTableTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FieldChooser = new System.Windows.Forms.ComboBox();
            this.ASCButton = new System.Windows.Forms.RadioButton();
            this.DESCButton = new System.Windows.Forms.RadioButton();
            this.SortButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.secondNameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.testTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(46, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(552, 270);
            this.dataGridView1.TabIndex = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testTableBindingSource
            // 
            this.testTableBindingSource.DataMember = "TestTable";
            this.testTableBindingSource.DataSource = this.database1DataSet;
            // 
            // testTableTableAdapter
            // 
            this.testTableTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // secondNameDataGridViewTextBoxColumn
            // 
            this.secondNameDataGridViewTextBoxColumn.DataPropertyName = "Second name";
            this.secondNameDataGridViewTextBoxColumn.HeaderText = "Second name";
            this.secondNameDataGridViewTextBoxColumn.Name = "secondNameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(619, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сортировка данных - щелчок по заголовку поля";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "или выбрать поле и тип";
            // 
            // FieldChooser
            // 
            this.FieldChooser.FormattingEnabled = true;
            this.FieldChooser.Location = new System.Drawing.Point(70, 365);
            this.FieldChooser.Name = "FieldChooser";
            this.FieldChooser.Size = new System.Drawing.Size(121, 21);
            this.FieldChooser.TabIndex = 3;
            // 
            // ASCButton
            // 
            this.ASCButton.AutoSize = true;
            this.ASCButton.Location = new System.Drawing.Point(330, 368);
            this.ASCButton.Name = "ASCButton";
            this.ASCButton.Size = new System.Drawing.Size(107, 17);
            this.ASCButton.TabIndex = 4;
            this.ASCButton.TabStop = true;
            this.ASCButton.Text = "по возрастанию";
            this.ASCButton.UseVisualStyleBackColor = true;
            this.ASCButton.Click += new System.EventHandler(this.ASC_Click);
            // 
            // DESCButton
            // 
            this.DESCButton.AutoSize = true;
            this.DESCButton.Location = new System.Drawing.Point(330, 391);
            this.DESCButton.Name = "DESCButton";
            this.DESCButton.Size = new System.Drawing.Size(91, 17);
            this.DESCButton.TabIndex = 5;
            this.DESCButton.TabStop = true;
            this.DESCButton.Text = "по убыванию";
            this.DESCButton.UseVisualStyleBackColor = true;
            this.DESCButton.Click += new System.EventHandler(this.DESC_Click);
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(497, 391);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(81, 23);
            this.SortButton.TabIndex = 6;
            this.SortButton.Text = "Сортировать";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 491);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.DESCButton);
            this.Controls.Add(this.ASCButton);
            this.Controls.Add(this.FieldChooser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Lab12";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource testTableBindingSource;
        private Database1DataSetTableAdapters.TestTableTableAdapter testTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FieldChooser;
        private System.Windows.Forms.RadioButton ASCButton;
        private System.Windows.Forms.RadioButton DESCButton;
        private System.Windows.Forms.Button SortButton;
    }
}

