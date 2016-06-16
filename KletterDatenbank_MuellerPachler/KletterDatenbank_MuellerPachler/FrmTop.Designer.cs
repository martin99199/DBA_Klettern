namespace KletterDatenbank_MuellerPachler
{
    partial class FrmTop
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
            this.eF_DB_KletterroutenDataSet = new KletterDatenbank_MuellerPachler.EF_DB_KletterroutenDataSet();
            this.gebieteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gebieteTableAdapter = new KletterDatenbank_MuellerPachler.EF_DB_KletterroutenDataSetTableAdapters.GebieteTableAdapter();
            this.nameGebietDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLZDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPSParkplatzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.fKGebietSektorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sektorenTableAdapter = new KletterDatenbank_MuellerPachler.EF_DB_KletterroutenDataSetTableAdapters.SektorenTableAdapter();
            this.nameSektorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPSExaktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eF_DB_KletterroutenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gebieteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKGebietSektorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameGebietDataGridViewTextBoxColumn,
            this.ortDataGridViewTextBoxColumn,
            this.pLZDataGridViewTextBoxColumn,
            this.gPSParkplatzDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gebieteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(471, 143);
            this.dataGridView1.TabIndex = 0;
            // 
            // eF_DB_KletterroutenDataSet
            // 
            this.eF_DB_KletterroutenDataSet.DataSetName = "EF_DB_KletterroutenDataSet";
            this.eF_DB_KletterroutenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gebieteBindingSource
            // 
            this.gebieteBindingSource.DataMember = "Gebiete";
            this.gebieteBindingSource.DataSource = this.eF_DB_KletterroutenDataSet;
            // 
            // gebieteTableAdapter
            // 
            this.gebieteTableAdapter.ClearBeforeFill = true;
            // 
            // nameGebietDataGridViewTextBoxColumn
            // 
            this.nameGebietDataGridViewTextBoxColumn.DataPropertyName = "NameGebiet";
            this.nameGebietDataGridViewTextBoxColumn.HeaderText = "NameGebiet";
            this.nameGebietDataGridViewTextBoxColumn.Name = "nameGebietDataGridViewTextBoxColumn";
            // 
            // ortDataGridViewTextBoxColumn
            // 
            this.ortDataGridViewTextBoxColumn.DataPropertyName = "Ort";
            this.ortDataGridViewTextBoxColumn.HeaderText = "Ort";
            this.ortDataGridViewTextBoxColumn.Name = "ortDataGridViewTextBoxColumn";
            // 
            // pLZDataGridViewTextBoxColumn
            // 
            this.pLZDataGridViewTextBoxColumn.DataPropertyName = "PLZ";
            this.pLZDataGridViewTextBoxColumn.HeaderText = "PLZ";
            this.pLZDataGridViewTextBoxColumn.Name = "pLZDataGridViewTextBoxColumn";
            // 
            // gPSParkplatzDataGridViewTextBoxColumn
            // 
            this.gPSParkplatzDataGridViewTextBoxColumn.DataPropertyName = "GPS_Parkplatz";
            this.gPSParkplatzDataGridViewTextBoxColumn.HeaderText = "GPS_Parkplatz";
            this.gPSParkplatzDataGridViewTextBoxColumn.Name = "gPSParkplatzDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameSektorDataGridViewTextBoxColumn,
            this.gPSExaktDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.fKGebietSektorBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(31, 216);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // fKGebietSektorBindingSource
            // 
            this.fKGebietSektorBindingSource.DataMember = "FK_GebietSektor";
            this.fKGebietSektorBindingSource.DataSource = this.gebieteBindingSource;
            // 
            // sektorenTableAdapter
            // 
            this.sektorenTableAdapter.ClearBeforeFill = true;
            // 
            // nameSektorDataGridViewTextBoxColumn
            // 
            this.nameSektorDataGridViewTextBoxColumn.DataPropertyName = "NameSektor";
            this.nameSektorDataGridViewTextBoxColumn.HeaderText = "NameSektor";
            this.nameSektorDataGridViewTextBoxColumn.Name = "nameSektorDataGridViewTextBoxColumn";
            // 
            // gPSExaktDataGridViewTextBoxColumn
            // 
            this.gPSExaktDataGridViewTextBoxColumn.DataPropertyName = "GPS_Exakt";
            this.gPSExaktDataGridViewTextBoxColumn.HeaderText = "GPS_Exakt";
            this.gPSExaktDataGridViewTextBoxColumn.Name = "gPSExaktDataGridViewTextBoxColumn";
            // 
            // FrmTop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 456);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmTop";
            this.Text = "FrmTop";
            this.Load += new System.EventHandler(this.FrmTop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eF_DB_KletterroutenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gebieteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKGebietSektorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private EF_DB_KletterroutenDataSet eF_DB_KletterroutenDataSet;
        private System.Windows.Forms.BindingSource gebieteBindingSource;
        private EF_DB_KletterroutenDataSetTableAdapters.GebieteTableAdapter gebieteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGebietDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLZDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPSParkplatzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource fKGebietSektorBindingSource;
        private EF_DB_KletterroutenDataSetTableAdapters.SektorenTableAdapter sektorenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSektorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPSExaktDataGridViewTextBoxColumn;
    }
}