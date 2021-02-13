namespace TalyplarOyiSystema
{
    partial class FrmGiderList
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
            this.odemeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elektrikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suwDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gazDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.azykDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beylekilerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cykdayjylarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.talyplarOyiDataSet4 = new TalyplarOyiSystema.TalyplarOyiDataSet4();
            this.cykdayjylarTableAdapter = new TalyplarOyiSystema.TalyplarOyiDataSet4TableAdapters.CykdayjylarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cykdayjylarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.talyplarOyiDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odemeidDataGridViewTextBoxColumn,
            this.elektrikDataGridViewTextBoxColumn,
            this.suwDataGridViewTextBoxColumn,
            this.gazDataGridViewTextBoxColumn,
            this.internetDataGridViewTextBoxColumn,
            this.azykDataGridViewTextBoxColumn,
            this.personalDataGridViewTextBoxColumn,
            this.beylekilerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cykdayjylarBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(840, 429);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // odemeidDataGridViewTextBoxColumn
            // 
            this.odemeidDataGridViewTextBoxColumn.DataPropertyName = "Odemeid";
            this.odemeidDataGridViewTextBoxColumn.HeaderText = "Odemeid";
            this.odemeidDataGridViewTextBoxColumn.Name = "odemeidDataGridViewTextBoxColumn";
            this.odemeidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // elektrikDataGridViewTextBoxColumn
            // 
            this.elektrikDataGridViewTextBoxColumn.DataPropertyName = "Elektrik";
            this.elektrikDataGridViewTextBoxColumn.HeaderText = "Elektrik";
            this.elektrikDataGridViewTextBoxColumn.Name = "elektrikDataGridViewTextBoxColumn";
            // 
            // suwDataGridViewTextBoxColumn
            // 
            this.suwDataGridViewTextBoxColumn.DataPropertyName = "Suw";
            this.suwDataGridViewTextBoxColumn.HeaderText = "Suw";
            this.suwDataGridViewTextBoxColumn.Name = "suwDataGridViewTextBoxColumn";
            // 
            // gazDataGridViewTextBoxColumn
            // 
            this.gazDataGridViewTextBoxColumn.DataPropertyName = "Gaz";
            this.gazDataGridViewTextBoxColumn.HeaderText = "Gaz";
            this.gazDataGridViewTextBoxColumn.Name = "gazDataGridViewTextBoxColumn";
            // 
            // internetDataGridViewTextBoxColumn
            // 
            this.internetDataGridViewTextBoxColumn.DataPropertyName = "internet";
            this.internetDataGridViewTextBoxColumn.HeaderText = "internet";
            this.internetDataGridViewTextBoxColumn.Name = "internetDataGridViewTextBoxColumn";
            // 
            // azykDataGridViewTextBoxColumn
            // 
            this.azykDataGridViewTextBoxColumn.DataPropertyName = "Azyk";
            this.azykDataGridViewTextBoxColumn.HeaderText = "Azyk";
            this.azykDataGridViewTextBoxColumn.Name = "azykDataGridViewTextBoxColumn";
            // 
            // personalDataGridViewTextBoxColumn
            // 
            this.personalDataGridViewTextBoxColumn.DataPropertyName = "Personal";
            this.personalDataGridViewTextBoxColumn.HeaderText = "Personal";
            this.personalDataGridViewTextBoxColumn.Name = "personalDataGridViewTextBoxColumn";
            // 
            // beylekilerDataGridViewTextBoxColumn
            // 
            this.beylekilerDataGridViewTextBoxColumn.DataPropertyName = "Beylekiler";
            this.beylekilerDataGridViewTextBoxColumn.HeaderText = "Beylekiler";
            this.beylekilerDataGridViewTextBoxColumn.Name = "beylekilerDataGridViewTextBoxColumn";
            // 
            // cykdayjylarBindingSource
            // 
            this.cykdayjylarBindingSource.DataMember = "Cykdayjylar";
            this.cykdayjylarBindingSource.DataSource = this.talyplarOyiDataSet4;
            // 
            // talyplarOyiDataSet4
            // 
            this.talyplarOyiDataSet4.DataSetName = "TalyplarOyiDataSet4";
            this.talyplarOyiDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cykdayjylarTableAdapter
            // 
            this.cykdayjylarTableAdapter.ClearBeforeFill = true;
            // 
            // FrmGiderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(840, 429);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "FrmGiderList";
            this.Text = "FrmGiderList";
            this.Load += new System.EventHandler(this.FrmGiderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cykdayjylarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.talyplarOyiDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TalyplarOyiDataSet4 talyplarOyiDataSet4;
        private System.Windows.Forms.BindingSource cykdayjylarBindingSource;
        private TalyplarOyiDataSet4TableAdapters.CykdayjylarTableAdapter cykdayjylarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn odemeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elektrikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suwDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gazDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn azykDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beylekilerDataGridViewTextBoxColumn;
    }
}