namespace TalyplarOyiSystema
{
    partial class FrmUlanyjyDuzelt
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
            this.TxtUlanyjyid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.texUlanyjyAdy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtParol = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnYatdaSakla = new System.Windows.Forms.Button();
            this.BtnPoz = new System.Windows.Forms.Button();
            this.BtnTazele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yoneticiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiParolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminParolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.talyplarOyiDataSet5 = new TalyplarOyiSystema.TalyplarOyiDataSet5();
            this.adminParolTableAdapter = new TalyplarOyiSystema.TalyplarOyiDataSet5TableAdapters.AdminParolTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminParolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.talyplarOyiDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtUlanyjyid
            // 
            this.TxtUlanyjyid.BackColor = System.Drawing.Color.GreenYellow;
            this.TxtUlanyjyid.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUlanyjyid.Location = new System.Drawing.Point(136, 19);
            this.TxtUlanyjyid.Name = "TxtUlanyjyid";
            this.TxtUlanyjyid.Size = new System.Drawing.Size(284, 26);
            this.TxtUlanyjyid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 56;
            this.label1.Text = "Ulanyjy ID :";
            // 
            // texUlanyjyAdy
            // 
            this.texUlanyjyAdy.BackColor = System.Drawing.Color.GreenYellow;
            this.texUlanyjyAdy.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texUlanyjyAdy.Location = new System.Drawing.Point(136, 51);
            this.texUlanyjyAdy.Name = "texUlanyjyAdy";
            this.texUlanyjyAdy.Size = new System.Drawing.Size(284, 26);
            this.texUlanyjyAdy.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 58;
            this.label2.Text = "Ulanyjy Ady :";
            // 
            // txtParol
            // 
            this.txtParol.BackColor = System.Drawing.Color.GreenYellow;
            this.txtParol.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParol.Location = new System.Drawing.Point(136, 83);
            this.txtParol.Name = "txtParol";
            this.txtParol.Size = new System.Drawing.Size(284, 26);
            this.txtParol.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(56, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 60;
            this.label3.Text = "Parol :";
            // 
            // BtnYatdaSakla
            // 
            this.BtnYatdaSakla.BackColor = System.Drawing.Color.Lime;
            this.BtnYatdaSakla.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYatdaSakla.Location = new System.Drawing.Point(28, 125);
            this.BtnYatdaSakla.Name = "BtnYatdaSakla";
            this.BtnYatdaSakla.Size = new System.Drawing.Size(101, 33);
            this.BtnYatdaSakla.TabIndex = 4;
            this.BtnYatdaSakla.Text = "Ýatda Sakla";
            this.BtnYatdaSakla.UseVisualStyleBackColor = false;
            this.BtnYatdaSakla.Click += new System.EventHandler(this.BtnYatdaSakla_Click);
            // 
            // BtnPoz
            // 
            this.BtnPoz.BackColor = System.Drawing.Color.Red;
            this.BtnPoz.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnPoz.Location = new System.Drawing.Point(156, 125);
            this.BtnPoz.Name = "BtnPoz";
            this.BtnPoz.Size = new System.Drawing.Size(132, 33);
            this.BtnPoz.TabIndex = 5;
            this.BtnPoz.Text = "Poz(Arassala)";
            this.BtnPoz.UseVisualStyleBackColor = false;
            this.BtnPoz.Click += new System.EventHandler(this.BtnPoz_Click);
            // 
            // BtnTazele
            // 
            this.BtnTazele.BackColor = System.Drawing.Color.Yellow;
            this.BtnTazele.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTazele.Location = new System.Drawing.Point(319, 125);
            this.BtnTazele.Name = "BtnTazele";
            this.BtnTazele.Size = new System.Drawing.Size(101, 33);
            this.BtnTazele.TabIndex = 6;
            this.BtnTazele.Text = "Täzele";
            this.BtnTazele.UseVisualStyleBackColor = false;
            this.BtnTazele.Click += new System.EventHandler(this.BtnTazele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yoneticiidDataGridViewTextBoxColumn,
            this.yoneticiAdDataGridViewTextBoxColumn,
            this.yoneticiParolDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.adminParolBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(433, 209);
            this.dataGridView1.TabIndex = 65;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // yoneticiidDataGridViewTextBoxColumn
            // 
            this.yoneticiidDataGridViewTextBoxColumn.DataPropertyName = "Yoneticiid";
            this.yoneticiidDataGridViewTextBoxColumn.HeaderText = "Yoneticiid";
            this.yoneticiidDataGridViewTextBoxColumn.Name = "yoneticiidDataGridViewTextBoxColumn";
            this.yoneticiidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yoneticiAdDataGridViewTextBoxColumn
            // 
            this.yoneticiAdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yoneticiAdDataGridViewTextBoxColumn.DataPropertyName = "YoneticiAd";
            this.yoneticiAdDataGridViewTextBoxColumn.HeaderText = "YoneticiAd";
            this.yoneticiAdDataGridViewTextBoxColumn.Name = "yoneticiAdDataGridViewTextBoxColumn";
            // 
            // yoneticiParolDataGridViewTextBoxColumn
            // 
            this.yoneticiParolDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yoneticiParolDataGridViewTextBoxColumn.DataPropertyName = "YoneticiParol";
            this.yoneticiParolDataGridViewTextBoxColumn.HeaderText = "YoneticiParol";
            this.yoneticiParolDataGridViewTextBoxColumn.Name = "yoneticiParolDataGridViewTextBoxColumn";
            // 
            // adminParolBindingSource
            // 
            this.adminParolBindingSource.DataMember = "AdminParol";
            this.adminParolBindingSource.DataSource = this.talyplarOyiDataSet5;
            // 
            // talyplarOyiDataSet5
            // 
            this.talyplarOyiDataSet5.DataSetName = "TalyplarOyiDataSet5";
            this.talyplarOyiDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminParolTableAdapter
            // 
            this.adminParolTableAdapter.ClearBeforeFill = true;
            // 
            // FrmUlanyjyDuzelt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(432, 392);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnTazele);
            this.Controls.Add(this.BtnPoz);
            this.Controls.Add(this.BtnYatdaSakla);
            this.Controls.Add(this.txtParol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.texUlanyjyAdy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtUlanyjyid);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmUlanyjyDuzelt";
            this.Text = "Ulanyjy İşlemleri :";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminParolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.talyplarOyiDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUlanyjyid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texUlanyjyAdy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtParol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnYatdaSakla;
        private System.Windows.Forms.Button BtnPoz;
        private System.Windows.Forms.Button BtnTazele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TalyplarOyiDataSet5 talyplarOyiDataSet5;
        private System.Windows.Forms.BindingSource adminParolBindingSource;
        private TalyplarOyiDataSet5TableAdapters.AdminParolTableAdapter adminParolTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiParolDataGridViewTextBoxColumn;
    }
}