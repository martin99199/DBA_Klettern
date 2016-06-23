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
            this.eF_DB_KletterroutenDataSet = new KletterDatenbank_MuellerPachler.EF_DB_KletterroutenDataSet();
            this.personenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personenTableAdapter = new KletterDatenbank_MuellerPachler.EF_DB_KletterroutenDataSetTableAdapters.PersonenTableAdapter();
            this.tableAdapterManager = new KletterDatenbank_MuellerPachler.EF_DB_KletterroutenDataSetTableAdapters.TableAdapterManager();
            this.personenDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGebiete = new System.Windows.Forms.Button();
            this.btnWunsch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eF_DB_KletterroutenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personenDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // eF_DB_KletterroutenDataSet
            // 
            this.eF_DB_KletterroutenDataSet.DataSetName = "EF_DB_KletterroutenDataSet";
            this.eF_DB_KletterroutenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personenBindingSource
            // 
            this.personenBindingSource.DataMember = "Personen";
            this.personenBindingSource.DataSource = this.eF_DB_KletterroutenDataSet;
            // 
            // personenTableAdapter
            // 
            this.personenTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GebieteTableAdapter = null;
            this.tableAdapterManager.PersonenTableAdapter = this.personenTableAdapter;
            this.tableAdapterManager.RoutenTableAdapter = null;
            this.tableAdapterManager.SektorenTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KletterDatenbank_MuellerPachler.EF_DB_KletterroutenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZOT_DurchstiegslistenTableAdapter = null;
            this.tableAdapterManager.ZOT_WunschlistenTableAdapter = null;
            // 
            // personenDataGridView
            // 
            this.personenDataGridView.AutoGenerateColumns = false;
            this.personenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.personenDataGridView.DataSource = this.personenBindingSource;
            this.personenDataGridView.Location = new System.Drawing.Point(40, 37);
            this.personenDataGridView.Name = "personenDataGridView";
            this.personenDataGridView.RowTemplate.Height = 24;
            this.personenDataGridView.Size = new System.Drawing.Size(469, 220);
            this.personenDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Vorname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Vorname";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nachname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nachname";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Geburtsdatum";
            this.dataGridViewTextBoxColumn4.HeaderText = "Geburtsdatum";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // btnGebiete
            // 
            this.btnGebiete.Location = new System.Drawing.Point(558, 37);
            this.btnGebiete.Name = "btnGebiete";
            this.btnGebiete.Size = new System.Drawing.Size(102, 58);
            this.btnGebiete.TabIndex = 2;
            this.btnGebiete.Text = "Gebiete und Routen";
            this.btnGebiete.UseVisualStyleBackColor = true;
            this.btnGebiete.Click += new System.EventHandler(this.btnGebiete_Click);
            // 
            // btnWunsch
            // 
            this.btnWunsch.Location = new System.Drawing.Point(558, 199);
            this.btnWunsch.Name = "btnWunsch";
            this.btnWunsch.Size = new System.Drawing.Size(102, 58);
            this.btnWunsch.TabIndex = 2;
            this.btnWunsch.Text = "Wunsch- und Durchstiegsliste";
            this.btnWunsch.UseVisualStyleBackColor = true;
            this.btnWunsch.Click += new System.EventHandler(this.btnWunsch_Click);
            // 
            // FrmTop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 316);
            this.Controls.Add(this.btnWunsch);
            this.Controls.Add(this.btnGebiete);
            this.Controls.Add(this.personenDataGridView);
            this.Name = "FrmTop";
            this.Text = "Kletterrouten Datenbank";
            this.Load += new System.EventHandler(this.FrmTop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eF_DB_KletterroutenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personenDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EF_DB_KletterroutenDataSet eF_DB_KletterroutenDataSet;
        private System.Windows.Forms.BindingSource personenBindingSource;
        private EF_DB_KletterroutenDataSetTableAdapters.PersonenTableAdapter personenTableAdapter;
        private EF_DB_KletterroutenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView personenDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnGebiete;
        private System.Windows.Forms.Button btnWunsch;




    }
}