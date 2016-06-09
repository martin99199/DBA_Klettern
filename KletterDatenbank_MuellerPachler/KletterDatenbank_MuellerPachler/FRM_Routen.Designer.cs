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
            this.gebietBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDGebietDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGebietDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLZDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPSParkplatzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sektorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sektorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDSektorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDGebietDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSektorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPSExaktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gebietDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gebietBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sektorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDGebietDataGridViewTextBoxColumn,
            this.nameGebietDataGridViewTextBoxColumn,
            this.ortDataGridViewTextBoxColumn,
            this.pLZDataGridViewTextBoxColumn,
            this.gPSParkplatzDataGridViewTextBoxColumn,
            this.sektorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gebietBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(44, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(680, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // gebietBindingSource
            // 
            this.gebietBindingSource.DataSource = typeof(KletterDatenbank_MuellerPachler.Gebiet);
            // 
            // iDGebietDataGridViewTextBoxColumn
            // 
            this.iDGebietDataGridViewTextBoxColumn.DataPropertyName = "ID_Gebiet";
            this.iDGebietDataGridViewTextBoxColumn.HeaderText = "ID_Gebiet";
            this.iDGebietDataGridViewTextBoxColumn.Name = "iDGebietDataGridViewTextBoxColumn";
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
            // sektorDataGridViewTextBoxColumn
            // 
            this.sektorDataGridViewTextBoxColumn.DataPropertyName = "Sektor";
            this.sektorDataGridViewTextBoxColumn.HeaderText = "Sektor";
            this.sektorDataGridViewTextBoxColumn.Name = "sektorDataGridViewTextBoxColumn";
            // 
            // sektorBindingSource
            // 
            this.sektorBindingSource.DataSource = typeof(KletterDatenbank_MuellerPachler.Sektor);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSektorDataGridViewTextBoxColumn,
            this.iDGebietDataGridViewTextBoxColumn1,
            this.nameSektorDataGridViewTextBoxColumn,
            this.gPSExaktDataGridViewTextBoxColumn,
            this.gebietDataGridViewTextBoxColumn,
            this.routeDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.sektorBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(44, 279);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // iDSektorDataGridViewTextBoxColumn
            // 
            this.iDSektorDataGridViewTextBoxColumn.DataPropertyName = "ID_Sektor";
            this.iDSektorDataGridViewTextBoxColumn.HeaderText = "ID_Sektor";
            this.iDSektorDataGridViewTextBoxColumn.Name = "iDSektorDataGridViewTextBoxColumn";
            // 
            // iDGebietDataGridViewTextBoxColumn1
            // 
            this.iDGebietDataGridViewTextBoxColumn1.DataPropertyName = "ID_Gebiet";
            this.iDGebietDataGridViewTextBoxColumn1.HeaderText = "ID_Gebiet";
            this.iDGebietDataGridViewTextBoxColumn1.Name = "iDGebietDataGridViewTextBoxColumn1";
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
            // gebietDataGridViewTextBoxColumn
            // 
            this.gebietDataGridViewTextBoxColumn.DataPropertyName = "Gebiet";
            this.gebietDataGridViewTextBoxColumn.HeaderText = "Gebiet";
            this.gebietDataGridViewTextBoxColumn.Name = "gebietDataGridViewTextBoxColumn";
            // 
            // routeDataGridViewTextBoxColumn
            // 
            this.routeDataGridViewTextBoxColumn.DataPropertyName = "Route";
            this.routeDataGridViewTextBoxColumn.HeaderText = "Route";
            this.routeDataGridViewTextBoxColumn.Name = "routeDataGridViewTextBoxColumn";
            // 
            // FRM_Routen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 730);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FRM_Routen";
            this.Text = "FRM_Routen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gebietBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sektorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDGebietDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGebietDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLZDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPSParkplatzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sektorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gebietBindingSource;
        private System.Windows.Forms.BindingSource sektorBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSektorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDGebietDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSektorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPSExaktDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gebietDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeDataGridViewTextBoxColumn;
    }
}