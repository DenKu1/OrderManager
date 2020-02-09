namespace OrderManager.Forms
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuGrid = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.menuGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuGrid
            // 
            this.menuGrid.AllowUserToAddRows = false;
            this.menuGrid.AllowUserToDeleteRows = false;
            this.menuGrid.AllowUserToResizeColumns = false;
            this.menuGrid.AllowUserToResizeRows = false;
            this.menuGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.menuGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.menuGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuGrid.ColumnHeadersVisible = false;
            this.menuGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.menuGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.menuGrid.Location = new System.Drawing.Point(13, 13);
            this.menuGrid.Margin = new System.Windows.Forms.Padding(4);
            this.menuGrid.MultiSelect = false;
            this.menuGrid.Name = "menuGrid";
            this.menuGrid.ReadOnly = true;
            this.menuGrid.RowHeadersVisible = false;
            this.menuGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.menuGrid.Size = new System.Drawing.Size(748, 506);
            this.menuGrid.TabIndex = 26;
            this.menuGrid.TabStop = false;
            this.menuGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.menuGrid_CellClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "gridCheckBox";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "text";
            this.Column1.MinimumWidth = 166;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnOrder
            // 
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(521, 527);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(240, 50);
            this.btnOrder.TabIndex = 27;
            this.btnOrder.Text = "Make order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 593);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.menuGrid);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 640);
            this.MinimumSize = new System.Drawing.Size(800, 640);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Order manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView menuGrid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnOrder;
    }
}