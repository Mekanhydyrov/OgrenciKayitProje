﻿namespace TalyplarOyiSystema
{
    partial class FrmOdemeler
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTalpid = new System.Windows.Forms.TextBox();
            this.TxtOdenen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtKalnBorc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.talypidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talypAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talypSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talypGalanBorcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borclarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.talyplarOyiDataSet2 = new TalyplarOyiSystema.TalyplarOyiDataSet2();
            this.BtnOdemeAl = new System.Windows.Forms.Button();
            this.borclarTableAdapter = new TalyplarOyiSystema.TalyplarOyiDataSet2TableAdapters.BorclarTableAdapter();
            this.TxtFamilya = new System.Windows.Forms.TextBox();
            this.Lable4 = new System.Windows.Forms.Label();
            this.TxtAdy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtOdenenAy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.talyplarOyiDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(176, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Talyp id :";
            // 
            // TxtTalpid
            // 
            this.TxtTalpid.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTalpid.Location = new System.Drawing.Point(257, 6);
            this.TxtTalpid.Name = "TxtTalpid";
            this.TxtTalpid.Size = new System.Drawing.Size(215, 26);
            this.TxtTalpid.TabIndex = 1;
            // 
            // TxtOdenen
            // 
            this.TxtOdenen.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOdenen.Location = new System.Drawing.Point(257, 101);
            this.TxtOdenen.Name = "TxtOdenen";
            this.TxtOdenen.Size = new System.Drawing.Size(215, 26);
            this.TxtOdenen.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(179, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ödenen :";
            // 
            // TxtKalnBorc
            // 
            this.TxtKalnBorc.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKalnBorc.Location = new System.Drawing.Point(257, 133);
            this.TxtKalnBorc.Name = "TxtKalnBorc";
            this.TxtKalnBorc.Size = new System.Drawing.Size(215, 26);
            this.TxtKalnBorc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(157, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Galan Borç :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.talypidDataGridViewTextBoxColumn,
            this.talypAdDataGridViewTextBoxColumn,
            this.talypSoyadDataGridViewTextBoxColumn,
            this.talypGalanBorcDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.borclarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 247);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(701, 235);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // talypidDataGridViewTextBoxColumn
            // 
            this.talypidDataGridViewTextBoxColumn.DataPropertyName = "Talypid";
            this.talypidDataGridViewTextBoxColumn.HeaderText = "Talypid";
            this.talypidDataGridViewTextBoxColumn.Name = "talypidDataGridViewTextBoxColumn";
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
            // talypGalanBorcDataGridViewTextBoxColumn
            // 
            this.talypGalanBorcDataGridViewTextBoxColumn.DataPropertyName = "TalypGalanBorc";
            this.talypGalanBorcDataGridViewTextBoxColumn.HeaderText = "TalypGalanBorc";
            this.talypGalanBorcDataGridViewTextBoxColumn.Name = "talypGalanBorcDataGridViewTextBoxColumn";
            // 
            // borclarBindingSource
            // 
            this.borclarBindingSource.DataMember = "Borclar";
            this.borclarBindingSource.DataSource = this.talyplarOyiDataSet2;
            // 
            // talyplarOyiDataSet2
            // 
            this.talyplarOyiDataSet2.DataSetName = "TalyplarOyiDataSet2";
            this.talyplarOyiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnOdemeAl
            // 
            this.BtnOdemeAl.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOdemeAl.Location = new System.Drawing.Point(295, 202);
            this.BtnOdemeAl.Name = "BtnOdemeAl";
            this.BtnOdemeAl.Size = new System.Drawing.Size(121, 39);
            this.BtnOdemeAl.TabIndex = 7;
            this.BtnOdemeAl.Text = "Ödeme Al !";
            this.BtnOdemeAl.UseVisualStyleBackColor = true;
            this.BtnOdemeAl.Click += new System.EventHandler(this.BtnOdemeAl_Click);
            // 
            // borclarTableAdapter
            // 
            this.borclarTableAdapter.ClearBeforeFill = true;
            // 
            // TxtFamilya
            // 
            this.TxtFamilya.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtFamilya.Location = new System.Drawing.Point(257, 69);
            this.TxtFamilya.Name = "TxtFamilya";
            this.TxtFamilya.Size = new System.Drawing.Size(215, 26);
            this.TxtFamilya.TabIndex = 3;
            // 
            // Lable4
            // 
            this.Lable4.AutoSize = true;
            this.Lable4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lable4.Location = new System.Drawing.Point(157, 72);
            this.Lable4.Name = "Lable4";
            this.Lable4.Size = new System.Drawing.Size(90, 18);
            this.Lable4.TabIndex = 10;
            this.Lable4.Text = "Familýasy :";
            // 
            // TxtAdy
            // 
            this.TxtAdy.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAdy.Location = new System.Drawing.Point(257, 38);
            this.TxtAdy.Name = "TxtAdy";
            this.TxtAdy.Size = new System.Drawing.Size(215, 26);
            this.TxtAdy.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(205, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ady :";
            // 
            // TxtOdenenAy
            // 
            this.TxtOdenenAy.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOdenenAy.Location = new System.Drawing.Point(257, 165);
            this.TxtOdenenAy.Name = "TxtOdenenAy";
            this.TxtOdenenAy.Size = new System.Drawing.Size(215, 26);
            this.TxtOdenenAy.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(157, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ödelen Aý :";
            // 
            // FrmOdemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(702, 482);
            this.Controls.Add(this.TxtOdenenAy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtFamilya);
            this.Controls.Add(this.Lable4);
            this.Controls.Add(this.TxtAdy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnOdemeAl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtKalnBorc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtOdenen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtTalpid);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmOdemeler";
            this.Text = "Ödemeler";
            this.Load += new System.EventHandler(this.FrmOdemeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.talyplarOyiDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTalpid;
        private System.Windows.Forms.TextBox TxtOdenen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtKalnBorc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnOdemeAl;
        private TalyplarOyiDataSet2 talyplarOyiDataSet2;
        private System.Windows.Forms.BindingSource borclarBindingSource;
        private TalyplarOyiDataSet2TableAdapters.BorclarTableAdapter borclarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn talypidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn talypAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn talypSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn talypGalanBorcDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox TxtFamilya;
        private System.Windows.Forms.Label Lable4;
        private System.Windows.Forms.TextBox TxtAdy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtOdenenAy;
        private System.Windows.Forms.Label label4;
    }
}