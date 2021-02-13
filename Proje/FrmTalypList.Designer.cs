namespace TalyplarOyiSystema
{
    partial class FrmTalypList
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
            this.talyplarOyiDataSet3 = new TalyplarOyiSystema.TalyplarOyiDataSet3();
            this.talypBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.talypTableAdapter = new TalyplarOyiSystema.TalyplarOyiDataSet3TableAdapters.TalypTableAdapter();
            this.talypidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talypAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talypSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talypPasNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talypTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talypDogumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talypBolumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talypMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talypOtagNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talypEneAtaAdyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talypEneAtaTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talypMasgalaAdrsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.talyplarOyiDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.talypBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.talypidDataGridViewTextBoxColumn,
            this.talypAdDataGridViewTextBoxColumn,
            this.talypSoyadDataGridViewTextBoxColumn,
            this.talypPasNoDataGridViewTextBoxColumn,
            this.talypTelefonDataGridViewTextBoxColumn,
            this.talypDogumDataGridViewTextBoxColumn,
            this.talypBolumDataGridViewTextBoxColumn,
            this.talypMailDataGridViewTextBoxColumn,
            this.talypOtagNoDataGridViewTextBoxColumn,
            this.talypEneAtaAdyDataGridViewTextBoxColumn,
            this.talypEneAtaTelDataGridViewTextBoxColumn,
            this.talypMasgalaAdrsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.talypBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1240, 471);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // talyplarOyiDataSet3
            // 
            this.talyplarOyiDataSet3.DataSetName = "TalyplarOyiDataSet3";
            this.talyplarOyiDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // talypBindingSource
            // 
            this.talypBindingSource.DataMember = "Talyp";
            this.talypBindingSource.DataSource = this.talyplarOyiDataSet3;
            // 
            // talypTableAdapter
            // 
            this.talypTableAdapter.ClearBeforeFill = true;
            // 
            // talypidDataGridViewTextBoxColumn
            // 
            this.talypidDataGridViewTextBoxColumn.DataPropertyName = "Talypid";
            this.talypidDataGridViewTextBoxColumn.HeaderText = "Talypid";
            this.talypidDataGridViewTextBoxColumn.Name = "talypidDataGridViewTextBoxColumn";
            this.talypidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // talypAdDataGridViewTextBoxColumn
            // 
            this.talypAdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.talypAdDataGridViewTextBoxColumn.DataPropertyName = "TalypAd";
            this.talypAdDataGridViewTextBoxColumn.HeaderText = "TalypAd";
            this.talypAdDataGridViewTextBoxColumn.Name = "talypAdDataGridViewTextBoxColumn";
            // 
            // talypSoyadDataGridViewTextBoxColumn
            // 
            this.talypSoyadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.talypSoyadDataGridViewTextBoxColumn.DataPropertyName = "TalypSoyad";
            this.talypSoyadDataGridViewTextBoxColumn.HeaderText = "TalypSoyad";
            this.talypSoyadDataGridViewTextBoxColumn.Name = "talypSoyadDataGridViewTextBoxColumn";
            // 
            // talypPasNoDataGridViewTextBoxColumn
            // 
            this.talypPasNoDataGridViewTextBoxColumn.DataPropertyName = "TalypPasNo";
            this.talypPasNoDataGridViewTextBoxColumn.HeaderText = "TalypPasNo";
            this.talypPasNoDataGridViewTextBoxColumn.Name = "talypPasNoDataGridViewTextBoxColumn";
            // 
            // talypTelefonDataGridViewTextBoxColumn
            // 
            this.talypTelefonDataGridViewTextBoxColumn.DataPropertyName = "TalypTelefon";
            this.talypTelefonDataGridViewTextBoxColumn.HeaderText = "TalypTelefon";
            this.talypTelefonDataGridViewTextBoxColumn.Name = "talypTelefonDataGridViewTextBoxColumn";
            // 
            // talypDogumDataGridViewTextBoxColumn
            // 
            this.talypDogumDataGridViewTextBoxColumn.DataPropertyName = "TalypDogum";
            this.talypDogumDataGridViewTextBoxColumn.HeaderText = "TalypDogum";
            this.talypDogumDataGridViewTextBoxColumn.Name = "talypDogumDataGridViewTextBoxColumn";
            // 
            // talypBolumDataGridViewTextBoxColumn
            // 
            this.talypBolumDataGridViewTextBoxColumn.DataPropertyName = "TalypBolum";
            this.talypBolumDataGridViewTextBoxColumn.HeaderText = "TalypBolum";
            this.talypBolumDataGridViewTextBoxColumn.Name = "talypBolumDataGridViewTextBoxColumn";
            // 
            // talypMailDataGridViewTextBoxColumn
            // 
            this.talypMailDataGridViewTextBoxColumn.DataPropertyName = "TalypMail";
            this.talypMailDataGridViewTextBoxColumn.HeaderText = "TalypMail";
            this.talypMailDataGridViewTextBoxColumn.Name = "talypMailDataGridViewTextBoxColumn";
            // 
            // talypOtagNoDataGridViewTextBoxColumn
            // 
            this.talypOtagNoDataGridViewTextBoxColumn.DataPropertyName = "TalypOtagNo";
            this.talypOtagNoDataGridViewTextBoxColumn.HeaderText = "TalypOtagNo";
            this.talypOtagNoDataGridViewTextBoxColumn.Name = "talypOtagNoDataGridViewTextBoxColumn";
            // 
            // talypEneAtaAdyDataGridViewTextBoxColumn
            // 
            this.talypEneAtaAdyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.talypEneAtaAdyDataGridViewTextBoxColumn.DataPropertyName = "TalypEneAtaAdy";
            this.talypEneAtaAdyDataGridViewTextBoxColumn.HeaderText = "TalypEneAtaAdy";
            this.talypEneAtaAdyDataGridViewTextBoxColumn.Name = "talypEneAtaAdyDataGridViewTextBoxColumn";
            // 
            // talypEneAtaTelDataGridViewTextBoxColumn
            // 
            this.talypEneAtaTelDataGridViewTextBoxColumn.DataPropertyName = "TalypEneAtaTel";
            this.talypEneAtaTelDataGridViewTextBoxColumn.HeaderText = "TalypEneAtaTel";
            this.talypEneAtaTelDataGridViewTextBoxColumn.Name = "talypEneAtaTelDataGridViewTextBoxColumn";
            // 
            // talypMasgalaAdrsDataGridViewTextBoxColumn
            // 
            this.talypMasgalaAdrsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.talypMasgalaAdrsDataGridViewTextBoxColumn.DataPropertyName = "TalypMasgalaAdrs";
            this.talypMasgalaAdrsDataGridViewTextBoxColumn.HeaderText = "TalypMasgalaAdrs";
            this.talypMasgalaAdrsDataGridViewTextBoxColumn.Name = "talypMasgalaAdrsDataGridViewTextBoxColumn";
            // 
            // FrmTalypList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1240, 471);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "FrmTalypList";
            this.Text = "Talyp Bilgileri ";
            this.Load += new System.EventHandler(this.FrmTalypList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.talyplarOyiDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.talypBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TalyplarOyiDataSet3 talyplarOyiDataSet3;
        private System.Windows.Forms.BindingSource talypBindingSource;
        private TalyplarOyiDataSet3TableAdapters.TalypTableAdapter talypTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn talypidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn talypAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn talypSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn talypPasNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn talypTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn talypDogumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn talypBolumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn talypMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn talypOtagNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn talypEneAtaAdyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn talypEneAtaTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn talypMasgalaAdrsDataGridViewTextBoxColumn;
    }
}