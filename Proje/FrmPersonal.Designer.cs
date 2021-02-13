namespace TalyplarOyiSystema
{
    partial class FrmPersonal
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
            this.BtnPersonalTazele = new System.Windows.Forms.Button();
            this.BtnPersonalPoz = new System.Windows.Forms.Button();
            this.Btnytsak = new System.Windows.Forms.Button();
            this.TxtPersonalWezipe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPersonalAtFa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPerid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personelidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelDepartmanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.talyplarOyiDataSet7 = new TalyplarOyiSystema.TalyplarOyiDataSet7();
            this.personalTableAdapter = new TalyplarOyiSystema.TalyplarOyiDataSet7TableAdapters.PersonalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.talyplarOyiDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPersonalTazele
            // 
            this.BtnPersonalTazele.BackColor = System.Drawing.Color.Yellow;
            this.BtnPersonalTazele.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnPersonalTazele.Location = new System.Drawing.Point(403, 137);
            this.BtnPersonalTazele.Name = "BtnPersonalTazele";
            this.BtnPersonalTazele.Size = new System.Drawing.Size(101, 33);
            this.BtnPersonalTazele.TabIndex = 6;
            this.BtnPersonalTazele.Text = "Täzele";
            this.BtnPersonalTazele.UseVisualStyleBackColor = false;
            this.BtnPersonalTazele.Click += new System.EventHandler(this.BtnPersonalTazele_Click);
            // 
            // BtnPersonalPoz
            // 
            this.BtnPersonalPoz.BackColor = System.Drawing.Color.Red;
            this.BtnPersonalPoz.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnPersonalPoz.Location = new System.Drawing.Point(240, 137);
            this.BtnPersonalPoz.Name = "BtnPersonalPoz";
            this.BtnPersonalPoz.Size = new System.Drawing.Size(132, 33);
            this.BtnPersonalPoz.TabIndex = 5;
            this.BtnPersonalPoz.Text = "Poz(Arassala)";
            this.BtnPersonalPoz.UseVisualStyleBackColor = false;
            this.BtnPersonalPoz.Click += new System.EventHandler(this.BtnPersonalPoz_Click);
            // 
            // Btnytsak
            // 
            this.Btnytsak.BackColor = System.Drawing.Color.Lime;
            this.Btnytsak.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnytsak.Location = new System.Drawing.Point(112, 137);
            this.Btnytsak.Name = "Btnytsak";
            this.Btnytsak.Size = new System.Drawing.Size(101, 33);
            this.Btnytsak.TabIndex = 4;
            this.Btnytsak.Text = "Ýatda Sakla";
            this.Btnytsak.UseVisualStyleBackColor = false;
            this.Btnytsak.Click += new System.EventHandler(this.Btnytsak_Click);
            // 
            // TxtPersonalWezipe
            // 
            this.TxtPersonalWezipe.BackColor = System.Drawing.Color.GreenYellow;
            this.TxtPersonalWezipe.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPersonalWezipe.Location = new System.Drawing.Point(220, 95);
            this.TxtPersonalWezipe.Name = "TxtPersonalWezipe";
            this.TxtPersonalWezipe.Size = new System.Drawing.Size(284, 26);
            this.TxtPersonalWezipe.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(69, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 18);
            this.label3.TabIndex = 69;
            this.label3.Text = "Personal Wezipesi :";
            // 
            // txtPersonalAtFa
            // 
            this.txtPersonalAtFa.BackColor = System.Drawing.Color.GreenYellow;
            this.txtPersonalAtFa.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonalAtFa.Location = new System.Drawing.Point(220, 63);
            this.txtPersonalAtFa.Name = "txtPersonalAtFa";
            this.txtPersonalAtFa.Size = new System.Drawing.Size(284, 26);
            this.txtPersonalAtFa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(37, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 18);
            this.label2.TabIndex = 67;
            this.label2.Text = "Personal At Familýasy :";
            // 
            // TxtPerid
            // 
            this.TxtPerid.BackColor = System.Drawing.Color.GreenYellow;
            this.TxtPerid.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPerid.Location = new System.Drawing.Point(220, 31);
            this.TxtPerid.Name = "TxtPerid";
            this.TxtPerid.Size = new System.Drawing.Size(284, 26);
            this.TxtPerid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(120, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 65;
            this.label1.Text = "Personal ID :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelidDataGridViewTextBoxColumn,
            this.personelAdSoyadDataGridViewTextBoxColumn,
            this.personelDepartmanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personalBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(630, 209);
            this.dataGridView1.TabIndex = 74;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // personelidDataGridViewTextBoxColumn
            // 
            this.personelidDataGridViewTextBoxColumn.DataPropertyName = "Personelid";
            this.personelidDataGridViewTextBoxColumn.HeaderText = "Personelid";
            this.personelidDataGridViewTextBoxColumn.Name = "personelidDataGridViewTextBoxColumn";
            this.personelidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personelAdSoyadDataGridViewTextBoxColumn
            // 
            this.personelAdSoyadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.personelAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "PersonelAdSoyad";
            this.personelAdSoyadDataGridViewTextBoxColumn.HeaderText = "PersonelAdSoyad";
            this.personelAdSoyadDataGridViewTextBoxColumn.Name = "personelAdSoyadDataGridViewTextBoxColumn";
            // 
            // personelDepartmanDataGridViewTextBoxColumn
            // 
            this.personelDepartmanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.personelDepartmanDataGridViewTextBoxColumn.DataPropertyName = "PersonelDepartman";
            this.personelDepartmanDataGridViewTextBoxColumn.HeaderText = "PersonelDepartman";
            this.personelDepartmanDataGridViewTextBoxColumn.Name = "personelDepartmanDataGridViewTextBoxColumn";
            // 
            // personalBindingSource
            // 
            this.personalBindingSource.DataMember = "Personal";
            this.personalBindingSource.DataSource = this.talyplarOyiDataSet7;
            // 
            // talyplarOyiDataSet7
            // 
            this.talyplarOyiDataSet7.DataSetName = "TalyplarOyiDataSet7";
            this.talyplarOyiDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personalTableAdapter
            // 
            this.personalTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(654, 415);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnPersonalTazele);
            this.Controls.Add(this.BtnPersonalPoz);
            this.Controls.Add(this.Btnytsak);
            this.Controls.Add(this.TxtPersonalWezipe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPersonalAtFa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPerid);
            this.Controls.Add(this.label1);
            this.Name = "FrmPersonal";
            this.Text = "FrmPersonal";
            this.Load += new System.EventHandler(this.FrmPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.talyplarOyiDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPersonalTazele;
        private System.Windows.Forms.Button BtnPersonalPoz;
        private System.Windows.Forms.Button Btnytsak;
        private System.Windows.Forms.TextBox TxtPersonalWezipe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPersonalAtFa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPerid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TalyplarOyiDataSet7 talyplarOyiDataSet7;
        private System.Windows.Forms.BindingSource personalBindingSource;
        private TalyplarOyiDataSet7TableAdapters.PersonalTableAdapter personalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelDepartmanDataGridViewTextBoxColumn;
    }
}