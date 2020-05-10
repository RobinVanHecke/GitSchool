namespace MySQL_productenDB
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCloseMySql = new System.Windows.Forms.Button();
            this.OpenMySQLButton = new System.Windows.Forms.Button();
            this.DropDownConnections = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ControleButton = new System.Windows.Forms.Button();
            this.OrderControleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnectAndClose = new System.Windows.Forms.Button();
            this.rtbReadOut = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbProductStock = new System.Windows.Forms.TextBox();
            this.rtbProductnaam = new System.Windows.Forms.RichTextBox();
            this.ProductToevoegenButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tmrVerbindingsTijd = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblSqlVerbindingsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.LeesTabelButton = new System.Windows.Forms.Button();
            this.VerwijderProductButton = new System.Windows.Forms.Button();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNaam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beschikbaarheid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1076, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCloseMySql);
            this.tabPage1.Controls.Add(this.OpenMySQLButton);
            this.tabPage1.Controls.Add(this.DropDownConnections);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1068, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "verbinding testen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCloseMySql
            // 
            this.btnCloseMySql.Enabled = false;
            this.btnCloseMySql.Location = new System.Drawing.Point(6, 63);
            this.btnCloseMySql.Name = "btnCloseMySql";
            this.btnCloseMySql.Size = new System.Drawing.Size(159, 23);
            this.btnCloseMySql.TabIndex = 6;
            this.btnCloseMySql.Text = "Sluit MySql verbinding";
            this.btnCloseMySql.UseVisualStyleBackColor = true;
            this.btnCloseMySql.Click += new System.EventHandler(this.btnCloseMySql_Click);
            // 
            // OpenMySQLButton
            // 
            this.OpenMySQLButton.Location = new System.Drawing.Point(7, 34);
            this.OpenMySQLButton.Name = "OpenMySQLButton";
            this.OpenMySQLButton.Size = new System.Drawing.Size(158, 23);
            this.OpenMySQLButton.TabIndex = 5;
            this.OpenMySQLButton.Text = "Open MySql verbinding";
            this.OpenMySQLButton.UseVisualStyleBackColor = true;
            this.OpenMySQLButton.Click += new System.EventHandler(this.OpenMySQLButton_Click);
            // 
            // DropDownConnections
            // 
            this.DropDownConnections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownConnections.FormattingEnabled = true;
            this.DropDownConnections.Location = new System.Drawing.Point(6, 6);
            this.DropDownConnections.Name = "DropDownConnections";
            this.DropDownConnections.Size = new System.Drawing.Size(159, 21);
            this.DropDownConnections.TabIndex = 4;
            this.DropDownConnections.SelectedIndexChanged += new System.EventHandler(this.DropDownConnections_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btnConnectAndClose);
            this.tabPage2.Controls.Add(this.rtbReadOut);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1068, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Uitlezen tabel orders";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ControleButton);
            this.groupBox1.Controls.Add(this.OrderControleTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(860, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 132);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OrderControle";
            // 
            // ControleButton
            // 
            this.ControleButton.Location = new System.Drawing.Point(50, 94);
            this.ControleButton.Name = "ControleButton";
            this.ControleButton.Size = new System.Drawing.Size(97, 23);
            this.ControleButton.TabIndex = 4;
            this.ControleButton.Text = "Controleer";
            this.ControleButton.UseVisualStyleBackColor = true;
            this.ControleButton.Click += new System.EventHandler(this.ControlButton_Click);
            // 
            // OrderControleTextBox
            // 
            this.OrderControleTextBox.Location = new System.Drawing.Point(47, 48);
            this.OrderControleTextBox.Name = "OrderControleTextBox";
            this.OrderControleTextBox.Size = new System.Drawing.Size(100, 20);
            this.OrderControleTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "OrderID";
            // 
            // btnConnectAndClose
            // 
            this.btnConnectAndClose.Location = new System.Drawing.Point(8, 380);
            this.btnConnectAndClose.Name = "btnConnectAndClose";
            this.btnConnectAndClose.Size = new System.Drawing.Size(119, 23);
            this.btnConnectAndClose.TabIndex = 0;
            this.btnConnectAndClose.Text = "Uitlezen tabel";
            this.btnConnectAndClose.UseVisualStyleBackColor = true;
            this.btnConnectAndClose.Click += new System.EventHandler(this.btnConnectAndClose_Click);
            // 
            // rtbReadOut
            // 
            this.rtbReadOut.Location = new System.Drawing.Point(8, 7);
            this.rtbReadOut.Name = "rtbReadOut";
            this.rtbReadOut.Size = new System.Drawing.Size(846, 367);
            this.rtbReadOut.TabIndex = 1;
            this.rtbReadOut.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1068, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Product toevoegen";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbProductStock);
            this.groupBox2.Controls.Add(this.rtbProductnaam);
            this.groupBox2.Controls.Add(this.ProductToevoegenButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 387);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product toevoegen";
            // 
            // tbProductStock
            // 
            this.tbProductStock.Location = new System.Drawing.Point(10, 130);
            this.tbProductStock.Name = "tbProductStock";
            this.tbProductStock.Size = new System.Drawing.Size(100, 20);
            this.tbProductStock.TabIndex = 4;
            // 
            // rtbProductnaam
            // 
            this.rtbProductnaam.Location = new System.Drawing.Point(9, 55);
            this.rtbProductnaam.Name = "rtbProductnaam";
            this.rtbProductnaam.Size = new System.Drawing.Size(425, 56);
            this.rtbProductnaam.TabIndex = 3;
            this.rtbProductnaam.Text = "";
            // 
            // ProductToevoegenButton
            // 
            this.ProductToevoegenButton.Location = new System.Drawing.Point(10, 156);
            this.ProductToevoegenButton.Name = "ProductToevoegenButton";
            this.ProductToevoegenButton.Size = new System.Drawing.Size(130, 23);
            this.ProductToevoegenButton.TabIndex = 2;
            this.ProductToevoegenButton.Text = "Product toegevoegen";
            this.ProductToevoegenButton.UseVisualStyleBackColor = true;
            this.ProductToevoegenButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "productstock:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Productnaam:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.VerwijderProductButton);
            this.tabPage4.Controls.Add(this.LeesTabelButton);
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1068, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Beheer tabel producten";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.productNaam,
            this.productStock,
            this.beschikbaarheid});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 403);
            this.dataGridView1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSqlVerbindingsStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1076, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblSqlVerbindingsStatus
            // 
            this.lblSqlVerbindingsStatus.BackColor = System.Drawing.Color.DarkGreen;
            this.lblSqlVerbindingsStatus.ForeColor = System.Drawing.Color.Lime;
            this.lblSqlVerbindingsStatus.Name = "lblSqlVerbindingsStatus";
            this.lblSqlVerbindingsStatus.Size = new System.Drawing.Size(90, 17);
            this.lblSqlVerbindingsStatus.Text = "SQL-verbinding";
            this.lblSqlVerbindingsStatus.Visible = false;
            // 
            // LeesTabelButton
            // 
            this.LeesTabelButton.Location = new System.Drawing.Point(449, 3);
            this.LeesTabelButton.Name = "LeesTabelButton";
            this.LeesTabelButton.Size = new System.Drawing.Size(151, 23);
            this.LeesTabelButton.TabIndex = 1;
            this.LeesTabelButton.Text = "Lees tabel producten";
            this.LeesTabelButton.UseVisualStyleBackColor = true;
            this.LeesTabelButton.Click += new System.EventHandler(this.LeesTableButton_Click);
            // 
            // VerwijderProductButton
            // 
            this.VerwijderProductButton.Location = new System.Drawing.Point(449, 32);
            this.VerwijderProductButton.Name = "VerwijderProductButton";
            this.VerwijderProductButton.Size = new System.Drawing.Size(151, 23);
            this.VerwijderProductButton.TabIndex = 2;
            this.VerwijderProductButton.Text = "Verwijder product";
            this.VerwijderProductButton.UseVisualStyleBackColor = true;
            this.VerwijderProductButton.Click += new System.EventHandler(this.RemoveProductButton_Click);
            // 
            // productID
            // 
            this.productID.HeaderText = "ID";
            this.productID.Name = "productID";
            // 
            // productNaam
            // 
            this.productNaam.HeaderText = "Naam";
            this.productNaam.Name = "productNaam";
            // 
            // productStock
            // 
            this.productStock.HeaderText = "Stock";
            this.productStock.Name = "productStock";
            // 
            // beschikbaarheid
            // 
            this.beschikbaarheid.HeaderText = "beschikbaar";
            this.beschikbaarheid.Name = "beschikbaarheid";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button OpenMySQLButton;
        private System.Windows.Forms.ComboBox DropDownConnections;
        private System.Windows.Forms.Timer tmrVerbindingsTijd;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblSqlVerbindingsStatus;
        private System.Windows.Forms.Button btnCloseMySql;
        private System.Windows.Forms.Button btnConnectAndClose;
        private System.Windows.Forms.RichTextBox rtbReadOut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ControleButton;
        private System.Windows.Forms.TextBox OrderControleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbProductStock;
        private System.Windows.Forms.RichTextBox rtbProductnaam;
        private System.Windows.Forms.Button ProductToevoegenButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button VerwijderProductButton;
        private System.Windows.Forms.Button LeesTabelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNaam;
        private System.Windows.Forms.DataGridViewTextBoxColumn productStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn beschikbaarheid;
    }
}

