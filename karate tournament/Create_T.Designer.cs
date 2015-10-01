namespace karate_tournament
{
    partial class Create_T
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create_T));
            this.TurNum = new System.Windows.Forms.Label();
            this.txtTur = new System.Windows.Forms.TextBox();
            this.txtPlayer = new System.Windows.Forms.TextBox();
            this.PlayerName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new karate_tournament.Database1DataSet();
            this.playersTableAdapter = new karate_tournament.Database1DataSetTableAdapters.PlayersTableAdapter();
            this.btnRef = new System.Windows.Forms.Button();
            this.playersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet1 = new karate_tournament.Database1DataSet();
            this.playersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.turNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // TurNum
            // 
            resources.ApplyResources(this.TurNum, "TurNum");
            this.TurNum.Name = "TurNum";
            this.TurNum.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTur
            // 
            resources.ApplyResources(this.txtTur, "txtTur");
            this.txtTur.Name = "txtTur";
            this.txtTur.TextChanged += new System.EventHandler(this.txtTur_TextChanged);
            // 
            // txtPlayer
            // 
            resources.ApplyResources(this.txtPlayer, "txtPlayer");
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.TextChanged += new System.EventHandler(this.txtPlayer_TextChanged);
            // 
            // PlayerName
            // 
            resources.ApplyResources(this.PlayerName, "PlayerName");
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Click += new System.EventHandler(this.PlayerName_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // btnRef
            // 
            resources.ApplyResources(this.btnRef, "btnRef");
            this.btnRef.Name = "btnRef";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // playersBindingSource1
            // 
            this.playersBindingSource1.DataMember = "Players";
            this.playersBindingSource1.DataSource = this.database1DataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.turNumDataGridViewTextBoxColumn,
            this.playerNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.playersBindingSource2;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playersBindingSource2
            // 
            this.playersBindingSource2.DataMember = "Players";
            this.playersBindingSource2.DataSource = this.database1DataSet1;
            // 
            // turNumDataGridViewTextBoxColumn
            // 
            this.turNumDataGridViewTextBoxColumn.DataPropertyName = "TurNum";
            resources.ApplyResources(this.turNumDataGridViewTextBoxColumn, "turNumDataGridViewTextBoxColumn");
            this.turNumDataGridViewTextBoxColumn.Name = "turNumDataGridViewTextBoxColumn";
            // 
            // playerNameDataGridViewTextBoxColumn
            // 
            this.playerNameDataGridViewTextBoxColumn.DataPropertyName = "PlayerName";
            resources.ApplyResources(this.playerNameDataGridViewTextBoxColumn, "playerNameDataGridViewTextBoxColumn");
            this.playerNameDataGridViewTextBoxColumn.Name = "playerNameDataGridViewTextBoxColumn";
            // 
            // Create_T
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRef);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPlayer);
            this.Controls.Add(this.PlayerName);
            this.Controls.Add(this.txtTur);
            this.Controls.Add(this.TurNum);
            this.Name = "Create_T";
            this.Opacity = 0.98D;
            this.Load += new System.EventHandler(this.Main_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TurNum;
        private System.Windows.Forms.TextBox txtTur;
        private System.Windows.Forms.TextBox txtPlayer;
        private System.Windows.Forms.Label PlayerName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.BindingSource playersBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet1;
        private System.Windows.Forms.BindingSource playersBindingSource2;
        private Database1DataSet database1DataSet;
        private Database1DataSetTableAdapters.PlayersTableAdapter playersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn turNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerNameDataGridViewTextBoxColumn;


    }
}

