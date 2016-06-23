namespace KletterDatenbank_MuellerPachler
{
    partial class FRM_Routen
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bsGebiet = new System.Windows.Forms.BindingSource(this.components);
            this.eF_DB_KletterroutenDataSet = new KletterDatenbank_MuellerPachler.EF_DB_KletterroutenDataSet();
            this.gebieteTableAdapter = new KletterDatenbank_MuellerPachler.EF_DB_KletterroutenDataSetTableAdapters.GebieteTableAdapter();
            this.sektorenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sektorenTableAdapter = new KletterDatenbank_MuellerPachler.EF_DB_KletterroutenDataSetTableAdapters.SektorenTableAdapter();
            this.tableAdapterManager = new KletterDatenbank_MuellerPachler.EF_DB_KletterroutenDataSetTableAdapters.TableAdapterManager();
            this.nameSektorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPSExaktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGebietDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLZDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPSParkplatzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGebiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eF_DB_KletterroutenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sektorenBindingSource)).BeginInit();
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
            this.dataGridView1.DataSource = this.bsGebiet;
            this.dataGridView1.Location = new System.Drawing.Point(39, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(696, 229);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameSektorDataGridViewTextBoxColumn,
            this.gPSExaktDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.sektorenBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(39, 307);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(298, 245);
            this.dataGridView2.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(534, 307);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(201, 85);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save and Exit";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(534, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 85);
            this.button1.TabIndex = 2;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bsGebiet
            // 
            this.bsGebiet.DataMember = "Gebiete";
            this.bsGebiet.DataSource = this.eF_DB_KletterroutenDataSet;
            // 
            // eF_DB_KletterroutenDataSet
            // 
            this.eF_DB_KletterroutenDataSet.DataSetName = "EF_DB_KletterroutenDataSet";
            this.eF_DB_KletterroutenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gebieteTableAdapter
            // 
            this.gebieteTableAdapter.ClearBeforeFill = true;
            // 
            // sektorenBindingSource
            // 
            this.sektorenBindingSource.DataMember = "FK_GebietSektor";
            this.sektorenBindingSource.DataSource = this.bsGebiet;
            // 
            // sektorenTableAdapter
            // 
            this.sektorenTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GebieteTableAdapter = this.gebieteTableAdapter;
            this.tableAdapterManager.PersonenTableAdapter = null;
            this.tableAdapterManager.RoutenTableAdapter = null;
            this.tableAdapterManager.SektorenTableAdapter = this.sektorenTableAdapter;
            this.tableAdapterManager.UpdateOrder = KletterDatenbank_MuellerPachler.EF_DB_KletterroutenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZOT_DurchstiegslistenTableAdapter = null;
            this.tableAdapterManager.ZOT_WunschlistenTableAdapter = null;
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
            // nameGebietDataGridViewTextBoxColumn
            // 
            this.nameGebietDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nameGebietDataGridViewTextBoxColumn.DataPropertyName = "NameGebiet";
            this.nameGebietDataGridViewTextBoxColumn.HeaderText = "NameGebiet";
            this.nameGebietDataGridViewTextBoxColumn.Name = "nameGebietDataGridViewTextBoxColumn";
            this.nameGebietDataGridViewTextBoxColumn.Width = 116;
            // 
            // ortDataGridViewTextBoxColumn
            // 
            this.ortDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ortDataGridViewTextBoxColumn.DataPropertyName = "Ort";
            this.ortDataGridViewTextBoxColumn.HeaderText = "Ort";
            this.ortDataGridViewTextBoxColumn.Name = "ortDataGridViewTextBoxColumn";
            this.ortDataGridViewTextBoxColumn.Width = 57;
            // 
            // pLZDataGridViewTextBoxColumn
            // 
            this.pLZDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pLZDataGridViewTextBoxColumn.DataPropertyName = "PLZ";
            this.pLZDataGridViewTextBoxColumn.HeaderText = "PLZ";
            this.pLZDataGridViewTextBoxColumn.Name = "pLZDataGridViewTextBoxColumn";
            this.pLZDataGridViewTextBoxColumn.Width = 63;
            // 
            // gPSParkplatzDataGridViewTextBoxColumn
            // 
            this.gPSParkplatzDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gPSParkplatzDataGridViewTextBoxColumn.DataPropertyName = "GPS_Parkplatz";
            this.gPSParkplatzDataGridViewTextBoxColumn.HeaderText = "GPS_Parkplatz";
            this.gPSParkplatzDataGridViewTextBoxColumn.Name = "gPSParkplatzDataGridViewTextBoxColumn";
            this.gPSParkplatzDataGridViewTextBoxColumn.Width = 133;
            // 
            // FRM_Routen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 584);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FRM_Routen";
            this.Text = "Gebiete und Routen";
            this.Load += new System.EventHandler(this.FRM_Routen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGebiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eF_DB_KletterroutenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sektorenBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDGebietDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sektorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSektorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDGebietDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bsGebiet;
        private EF_DB_KletterroutenDataSet eF_DB_KletterroutenDataSet;
        private EF_DB_KletterroutenDataSetTableAdapters.GebieteTableAdapter gebieteTableAdapter;
        private System.Windows.Forms.BindingSource sektorenBindingSource;
        private EF_DB_KletterroutenDataSetTableAdapters.SektorenTableAdapter sektorenTableAdapter;
        private EF_DB_KletterroutenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGebietDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLZDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPSParkplatzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSektorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPSExaktDataGridViewTextBoxColumn;
    }
}