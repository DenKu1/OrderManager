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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOrder = new System.Windows.Forms.Button();
            this.dtpClock = new System.Windows.Forms.DateTimePicker();
            this.btnSetClock = new System.Windows.Forms.Button();
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
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.menuGrid.DefaultCellStyle = dataGridViewCellStyle2;
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
            // dtpClock
            // 
            this.dtpClock.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpClock.Location = new System.Drawing.Point(13, 527);
            this.dtpClock.Name = "dtpClock";
            this.dtpClock.Size = new System.Drawing.Size(200, 22);
            this.dtpClock.TabIndex = 28;
            this.dtpClock.Value = new System.DateTime(2020, 2, 9, 22, 8, 30, 0);
            // 
            // btnSetClock
            // 
            this.btnSetClock.BackColor = System.Drawing.Color.Firebrick;
            this.btnSetClock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSetClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetClock.Location = new System.Drawing.Point(219, 527);
            this.btnSetClock.Name = "btnSetClock";
            this.btnSetClock.Size = new System.Drawing.Size(21, 22);
            this.btnSetClock.TabIndex = 29;
            this.btnSetClock.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 593);
            this.Controls.Add(this.btnSetClock);
            this.Controls.Add(this.dtpClock);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.menuGrid);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 640);
            this.MinimumSize = new System.Drawing.Size(800, 640);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Order manager";
            ((System.ComponentModel.ISupportInitialize)(this.menuGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView menuGrid;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DateTimePicker dtpClock;
        private System.Windows.Forms.Button btnSetClock;
    }
}