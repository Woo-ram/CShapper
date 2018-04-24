namespace CodeReviewProgram.Controls
{
    partial class CategoryViewControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CategoryView = new System.Windows.Forms.DataGridView();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryView
            // 
            this.CategoryView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryView.AutoGenerateColumns = false;
            this.CategoryView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CategoryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoryView.ColumnHeadersVisible = false;
            this.CategoryView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.CategoryView.DataSource = this.categoryBindingSource;
            this.CategoryView.Location = new System.Drawing.Point(0, 0);
            this.CategoryView.MultiSelect = false;
            this.CategoryView.Name = "CategoryView";
            this.CategoryView.ReadOnly = true;
            this.CategoryView.RowHeadersVisible = false;
            this.CategoryView.RowTemplate.Height = 23;
            this.CategoryView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CategoryView.Size = new System.Drawing.Size(150, 150);
            this.CategoryView.TabIndex = 0;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(CordReviewLib.Category);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CategoryViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CategoryView);
            this.Name = "CategoryViewControl";
            ((System.ComponentModel.ISupportInitialize)(this.CategoryView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CategoryView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource categoryBindingSource;
    }
}
