namespace KletterDatenbank_MuellerPachler
{
    partial class FRM_Top
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
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSourcePerson = new System.Windows.Forms.BindingSource(this.components);
            this.eF_KletterRoutenDataSet = new KletterDatenbank_MuellerPachler.EF_KletterRoutenDataSet();
            this.personTableAdapter = new KletterDatenbank_MuellerPachler.EF_KletterRoutenDataSetTableAdapters.PersonTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nachnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geburtsdatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceGebiet = new System.Windows.Forms.BindingSource(this.components);
            this.gebietTableAdapter = new KletterDatenbank_MuellerPachler.EF_KletterRoutenDataSetTableAdapters.GebietTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDGebietDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGebietDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLZDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPSParkplatzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eF_KletterRoutenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGebiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(593, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 69);
            this.button1.TabIndex = 1;
            this.button1.Text = "Routen Datenbank";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bindingSourcePerson
            // 
            this.bindingSourcePerson.DataMember = "Person";
            this.bindingSourcePerson.DataSource = this.eF_KletterRoutenDataSet;
            // 
            // eF_KletterRoutenDataSet
            // 
            this.eF_KletterRoutenDataSet.DataSetName = "EF_KletterRoutenDataSet";
            this.eF_KletterRoutenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPersonDataGridViewTextBoxColumn,
            this.vornameDataGridViewTextBoxColumn,
            this.nachnameDataGridViewTextBoxColumn,
            this.geburtsdatumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSourcePerson;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(550, 192);
            this.dataGridView1.TabIndex = 2;
            // 
            // iDPersonDataGridViewTextBoxColumn
            // 
            this.iDPersonDataGridViewTextBoxColumn.DataPropertyName = "ID_Person";
            this.iDPersonDataGridViewTextBoxColumn.HeaderText = "ID_Person";
            this.iDPersonDataGridViewTextBoxColumn.Name = "iDPersonDataGridViewTextBoxColumn";
            this.iDPersonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vornameDataGridViewTextBoxColumn
            // 
            this.vornameDataGridViewTextBoxColumn.DataPropertyName = "Vorname";
            this.vornameDataGridViewTextBoxColumn.HeaderText = "Vorname";
            this.vornameDataGridViewTextBoxColumn.Name = "vornameDataGridViewTextBoxColumn";
            // 
            // nachnameDataGridViewTextBoxColumn
            // 
            this.nachnameDataGridViewTextBoxColumn.DataPropertyName = "Nachname";
            this.nachnameDataGridViewTextBoxColumn.HeaderText = "Nachname";
            this.nachnameDataGridViewTextBoxColumn.Name = "nachnameDataGridViewTextBoxColumn";
            // 
            // geburtsdatumDataGridViewTextBoxColumn
            // 
            this.geburtsdatumDataGridViewTextBoxColumn.DataPropertyName = "Geburtsdatum";
            this.geburtsdatumDataGridViewTextBoxColumn.HeaderText = "Geburtsdatum";
            this.geburtsdatumDataGridViewTextBoxColumn.Name = "geburtsdatumDataGridViewTextBoxColumn";
            // 
            // bindingSourceGebiet
            // 
            this.bindingSourceGebiet.DataMember = "Gebiet";
            this.bindingSourceGebiet.DataSource = this.eF_KletterRoutenDataSet;
            // 
            // gebietTableAdapter
            // 
            this.gebietTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDGebietDataGridViewTextBoxColumn,
            this.nameGebietDataGridViewTextBoxColumn,
            this.ortDataGridViewTextBoxColumn,
            this.pLZDataGridViewTextBoxColumn,
            this.gPSParkplatzDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bindingSourceGebiet;
            this.dataGridView2.Location = new System.Drawing.Point(12, 326);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(550, 170);
            this.dataGridView2.TabIndex = 3;
            // 
            // iDGebietDataGridViewTextBoxColumn
            // 
            this.iDGebietDataGridViewTextBoxColumn.DataPropertyName = "ID_Gebiet";
            this.iDGebietDataGridViewTextBoxColumn.HeaderText = "ID_Gebiet";
            this.iDGebietDataGridViewTextBoxColumn.Name = "iDGebietDataGridViewTextBoxColumn";
            this.iDGebietDataGridViewTextBoxColumn.ReadOnly = true;
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
            // FRM_Top
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 508);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "FRM_Top";
            this.Text = "FRM_Top";
            this.Load += new System.EventHandler(this.FRM_Top_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eF_KletterRoutenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGebiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bindingSourcePerson;
        private EF_KletterRoutenDataSet eF_KletterRoutenDataSet;
        private EF_KletterRoutenDataSetTableAdapters.PersonTableAdapter personTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nachnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn geburtsdatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSourceGebiet;
        private EF_KletterRoutenDataSetTableAdapters.GebietTableAdapter gebietTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDGebietDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGebietDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLZDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPSParkplatzDataGridViewTextBoxColumn;
    }
}