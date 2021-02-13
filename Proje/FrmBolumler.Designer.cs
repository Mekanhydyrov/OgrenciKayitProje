namespace TalyplarOyiSystema
{
    partial class FrmBolumler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBolumler));
            this.pcbEkle = new System.Windows.Forms.PictureBox();
            this.pcbSil = new System.Windows.Forms.PictureBox();
            this.pcbDuzenle = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBolumid = new System.Windows.Forms.TextBox();
            this.textBolumAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bolumidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.talyplarOyiDataSet = new TalyplarOyiSystema.TalyplarOyiDataSet();
            this.bolumlerTableAdapter = new TalyplarOyiSystema.TalyplarOyiDataSetTableAdapters.BolumlerTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDuzenle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.talyplarOyiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbEkle
            // 
            this.pcbEkle.BackColor = System.Drawing.Color.Black;
            this.pcbEkle.Image = ((System.Drawing.Image)(resources.GetObject("pcbEkle.Image")));
            this.pcbEkle.Location = new System.Drawing.Point(436, 26);
            this.pcbEkle.Name = "pcbEkle";
            this.pcbEkle.Size = new System.Drawing.Size(94, 81);
            this.pcbEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbEkle.TabIndex = 0;
            this.pcbEkle.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbEkle, "Bölüm Goş");
            this.pcbEkle.Click += new System.EventHandler(this.pcbEkle_Click);
            // 
            // pcbSil
            // 
            this.pcbSil.Image = ((System.Drawing.Image)(resources.GetObject("pcbSil.Image")));
            this.pcbSil.Location = new System.Drawing.Point(656, 26);
            this.pcbSil.Name = "pcbSil";
            this.pcbSil.Size = new System.Drawing.Size(93, 81);
            this.pcbSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSil.TabIndex = 1;
            this.pcbSil.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbSil, "Arassala (Poz)");
            this.pcbSil.Click += new System.EventHandler(this.pcbSil_Click);
            // 
            // pcbDuzenle
            // 
            this.pcbDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("pcbDuzenle.Image")));
            this.pcbDuzenle.Location = new System.Drawing.Point(545, 26);
            this.pcbDuzenle.Name = "pcbDuzenle";
            this.pcbDuzenle.Size = new System.Drawing.Size(91, 81);
            this.pcbDuzenle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbDuzenle.TabIndex = 2;
            this.pcbDuzenle.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbDuzenle, "Täzelendir");
            this.pcbDuzenle.Click += new System.EventHandler(this.pcbDuzenle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bölüm ID";
            // 
            // txtBolumid
            // 
            this.txtBolumid.Enabled = false;
            this.txtBolumid.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBolumid.Location = new System.Drawing.Point(105, 26);
            this.txtBolumid.Name = "txtBolumid";
            this.txtBolumid.Size = new System.Drawing.Size(315, 26);
            this.txtBolumid.TabIndex = 1;
            // 
            // textBolumAd
            // 
            this.textBolumAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBolumAd.Location = new System.Drawing.Point(105, 81);
            this.textBolumAd.Name = "textBolumAd";
            this.textBolumAd.Size = new System.Drawing.Size(315, 26);
            this.textBolumAd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bölüm Ad";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumidDataGridViewTextBoxColumn,
            this.bolumAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bolumlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(759, 303);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bolumidDataGridViewTextBoxColumn
            // 
            this.bolumidDataGridViewTextBoxColumn.DataPropertyName = "Bolumid";
            this.bolumidDataGridViewTextBoxColumn.HeaderText = "Bolumid";
            this.bolumidDataGridViewTextBoxColumn.Name = "bolumidDataGridViewTextBoxColumn";
            this.bolumidDataGridViewTextBoxColumn.ReadOnly = true;
            this.bolumidDataGridViewTextBoxColumn.Width = 358;
            // 
            // bolumAdDataGridViewTextBoxColumn
            // 
            this.bolumAdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bolumAdDataGridViewTextBoxColumn.DataPropertyName = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.HeaderText = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.Name = "bolumAdDataGridViewTextBoxColumn";
            // 
            // bolumlerBindingSource
            // 
            this.bolumlerBindingSource.DataMember = "Bolumler";
            this.bolumlerBindingSource.DataSource = this.talyplarOyiDataSet;
            // 
            // talyplarOyiDataSet
            // 
            this.talyplarOyiDataSet.DataSetName = "TalyplarOyiDataSet";
            this.talyplarOyiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolumlerTableAdapter
            // 
            this.bolumlerTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(761, 447);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBolumAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBolumid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbDuzenle);
            this.Controls.Add(this.pcbSil);
            this.Controls.Add(this.pcbEkle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBolumler";
            this.Text = "Bolumler";
            this.Load += new System.EventHandler(this.FrmBolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDuzenle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.talyplarOyiDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbEkle;
        private System.Windows.Forms.PictureBox pcbSil;
        private System.Windows.Forms.PictureBox pcbDuzenle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBolumid;
        private System.Windows.Forms.TextBox textBolumAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TalyplarOyiDataSet talyplarOyiDataSet;
        private System.Windows.Forms.BindingSource bolumlerBindingSource;
        private TalyplarOyiDataSetTableAdapters.BolumlerTableAdapter bolumlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}