
namespace RobCellphones2
{
    partial class RobCellphones
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpListaCellulari = new System.Windows.Forms.GroupBox();
            this.dGrdView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpSchedaCellulare = new System.Windows.Forms.GroupBox();
            this.cmbSite = new System.Windows.Forms.ComboBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.txtLastupdate = new System.Windows.Forms.TextBox();
            this.lblLastupdate = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblSite = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.lblSerial = new System.Windows.Forms.Label();
            this.txtImei2 = new System.Windows.Forms.TextBox();
            this.lblImei2 = new System.Windows.Forms.Label();
            this.txtImei1 = new System.Windows.Forms.TextBox();
            this.lblImei1 = new System.Windows.Forms.Label();
            this.txtCellnumber = new System.Windows.Forms.TextBox();
            this.lblCellnumber = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblCognome = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.positionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnInizio = new System.Windows.Forms.Button();
            this.btnIndietro = new System.Windows.Forms.Button();
            this.btnAvanti = new System.Windows.Forms.Button();
            this.btnFine = new System.Windows.Forms.Button();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnCancella = new System.Windows.Forms.Button();
            this.btnTermina = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnCerca = new System.Windows.Forms.Button();
            this.btnAiuto = new System.Windows.Forms.Button();
            this.btnSvuotaScheda = new System.Windows.Forms.Button();
            this.grpListaCellulari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGrdView)).BeginInit();
            this.grpSchedaCellulare.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpListaCellulari
            // 
            this.grpListaCellulari.Controls.Add(this.dGrdView);
            this.grpListaCellulari.Location = new System.Drawing.Point(12, 12);
            this.grpListaCellulari.Name = "grpListaCellulari";
            this.grpListaCellulari.Size = new System.Drawing.Size(633, 413);
            this.grpListaCellulari.TabIndex = 0;
            this.grpListaCellulari.TabStop = false;
            this.grpListaCellulari.Text = "Lista Cellulari";
            // 
            // dGrdView
            // 
            this.dGrdView.AllowUserToAddRows = false;
            this.dGrdView.AllowUserToDeleteRows = false;
            this.dGrdView.AllowUserToOrderColumns = true;
            this.dGrdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrdView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.surname,
            this.name,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dGrdView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGrdView.Location = new System.Drawing.Point(3, 16);
            this.dGrdView.Name = "dGrdView";
            this.dGrdView.ReadOnly = true;
            this.dGrdView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGrdView.Size = new System.Drawing.Size(627, 394);
            this.dGrdView.TabIndex = 0;
            this.dGrdView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGrdView_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // surname
            // 
            this.surname.HeaderText = "Column2";
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Column3";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Column10";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Column11";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // grpSchedaCellulare
            // 
            this.grpSchedaCellulare.Controls.Add(this.cmbSite);
            this.grpSchedaCellulare.Controls.Add(this.cmbModel);
            this.grpSchedaCellulare.Controls.Add(this.txtLastupdate);
            this.grpSchedaCellulare.Controls.Add(this.lblLastupdate);
            this.grpSchedaCellulare.Controls.Add(this.txtNote);
            this.grpSchedaCellulare.Controls.Add(this.lblNote);
            this.grpSchedaCellulare.Controls.Add(this.lblSite);
            this.grpSchedaCellulare.Controls.Add(this.lblModel);
            this.grpSchedaCellulare.Controls.Add(this.txtSerial);
            this.grpSchedaCellulare.Controls.Add(this.lblSerial);
            this.grpSchedaCellulare.Controls.Add(this.txtImei2);
            this.grpSchedaCellulare.Controls.Add(this.lblImei2);
            this.grpSchedaCellulare.Controls.Add(this.txtImei1);
            this.grpSchedaCellulare.Controls.Add(this.lblImei1);
            this.grpSchedaCellulare.Controls.Add(this.txtCellnumber);
            this.grpSchedaCellulare.Controls.Add(this.lblCellnumber);
            this.grpSchedaCellulare.Controls.Add(this.txtName);
            this.grpSchedaCellulare.Controls.Add(this.lblNome);
            this.grpSchedaCellulare.Controls.Add(this.txtSurname);
            this.grpSchedaCellulare.Controls.Add(this.lblCognome);
            this.grpSchedaCellulare.Location = new System.Drawing.Point(651, 12);
            this.grpSchedaCellulare.Name = "grpSchedaCellulare";
            this.grpSchedaCellulare.Size = new System.Drawing.Size(321, 364);
            this.grpSchedaCellulare.TabIndex = 1;
            this.grpSchedaCellulare.TabStop = false;
            this.grpSchedaCellulare.Text = "Scheda Cellulare";
            // 
            // cmbSite
            // 
            this.cmbSite.FormattingEnabled = true;
            this.cmbSite.Location = new System.Drawing.Point(100, 197);
            this.cmbSite.Name = "cmbSite";
            this.cmbSite.Size = new System.Drawing.Size(200, 21);
            this.cmbSite.TabIndex = 13;
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(100, 172);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(200, 21);
            this.cmbModel.TabIndex = 12;
            // 
            // txtLastupdate
            // 
            this.txtLastupdate.Location = new System.Drawing.Point(100, 330);
            this.txtLastupdate.Name = "txtLastupdate";
            this.txtLastupdate.ReadOnly = true;
            this.txtLastupdate.Size = new System.Drawing.Size(200, 20);
            this.txtLastupdate.TabIndex = 15;
            this.txtLastupdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLastupdate
            // 
            this.lblLastupdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLastupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLastupdate.Location = new System.Drawing.Point(7, 334);
            this.lblLastupdate.Name = "lblLastupdate";
            this.lblLastupdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLastupdate.Size = new System.Drawing.Size(85, 13);
            this.lblLastupdate.TabIndex = 18;
            this.lblLastupdate.Text = "lblLastupdateDat";
            this.lblLastupdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(100, 224);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNote.Size = new System.Drawing.Size(200, 100);
            this.txtNote.TabIndex = 14;
            // 
            // lblNote
            // 
            this.lblNote.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNote.Location = new System.Drawing.Point(7, 228);
            this.lblNote.Name = "lblNote";
            this.lblNote.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNote.Size = new System.Drawing.Size(85, 13);
            this.lblNote.TabIndex = 16;
            this.lblNote.Text = "lblNote";
            this.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSite
            // 
            this.lblSite.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSite.Location = new System.Drawing.Point(7, 202);
            this.lblSite.Name = "lblSite";
            this.lblSite.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSite.Size = new System.Drawing.Size(85, 13);
            this.lblSite.TabIndex = 14;
            this.lblSite.Text = "lblSite";
            this.lblSite.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblModel
            // 
            this.lblModel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblModel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblModel.Location = new System.Drawing.Point(7, 176);
            this.lblModel.Name = "lblModel";
            this.lblModel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblModel.Size = new System.Drawing.Size(85, 13);
            this.lblModel.TabIndex = 12;
            this.lblModel.Text = "lblModel";
            this.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(100, 146);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(200, 20);
            this.txtSerial.TabIndex = 11;
            // 
            // lblSerial
            // 
            this.lblSerial.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSerial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSerial.Location = new System.Drawing.Point(7, 150);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSerial.Size = new System.Drawing.Size(85, 13);
            this.lblSerial.TabIndex = 10;
            this.lblSerial.Text = "lblSerial";
            this.lblSerial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtImei2
            // 
            this.txtImei2.Location = new System.Drawing.Point(100, 120);
            this.txtImei2.Name = "txtImei2";
            this.txtImei2.Size = new System.Drawing.Size(200, 20);
            this.txtImei2.TabIndex = 9;
            // 
            // lblImei2
            // 
            this.lblImei2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblImei2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblImei2.Location = new System.Drawing.Point(7, 124);
            this.lblImei2.Name = "lblImei2";
            this.lblImei2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblImei2.Size = new System.Drawing.Size(85, 13);
            this.lblImei2.TabIndex = 8;
            this.lblImei2.Text = "Imei2";
            this.lblImei2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtImei1
            // 
            this.txtImei1.Location = new System.Drawing.Point(100, 94);
            this.txtImei1.Name = "txtImei1";
            this.txtImei1.Size = new System.Drawing.Size(200, 20);
            this.txtImei1.TabIndex = 7;
            // 
            // lblImei1
            // 
            this.lblImei1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblImei1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblImei1.Location = new System.Drawing.Point(7, 98);
            this.lblImei1.Name = "lblImei1";
            this.lblImei1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblImei1.Size = new System.Drawing.Size(85, 13);
            this.lblImei1.TabIndex = 6;
            this.lblImei1.Text = "Imei1";
            this.lblImei1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCellnumber
            // 
            this.txtCellnumber.Location = new System.Drawing.Point(100, 68);
            this.txtCellnumber.Name = "txtCellnumber";
            this.txtCellnumber.Size = new System.Drawing.Size(200, 20);
            this.txtCellnumber.TabIndex = 5;
            // 
            // lblCellnumber
            // 
            this.lblCellnumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCellnumber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCellnumber.Location = new System.Drawing.Point(7, 72);
            this.lblCellnumber.Name = "lblCellnumber";
            this.lblCellnumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCellnumber.Size = new System.Drawing.Size(85, 13);
            this.lblCellnumber.TabIndex = 4;
            this.lblCellnumber.Text = "lblCellnumber";
            this.lblCellnumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNome.Location = new System.Drawing.Point(7, 46);
            this.lblNome.Name = "lblNome";
            this.lblNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNome.Size = new System.Drawing.Size(85, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "lblNome";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(100, 16);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(200, 20);
            this.txtSurname.TabIndex = 1;
            // 
            // lblCognome
            // 
            this.lblCognome.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCognome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCognome.Location = new System.Drawing.Point(7, 20);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCognome.Size = new System.Drawing.Size(85, 13);
            this.lblCognome.TabIndex = 0;
            this.lblCognome.Text = "lblCognome";
            this.lblCognome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.positionLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // positionLabel
            // 
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(70, 17);
            this.positionLabel.Text = "Position 0/0";
            // 
            // btnInizio
            // 
            this.btnInizio.Location = new System.Drawing.Point(652, 384);
            this.btnInizio.Name = "btnInizio";
            this.btnInizio.Size = new System.Drawing.Size(30, 23);
            this.btnInizio.TabIndex = 16;
            this.btnInizio.Text = "|<";
            this.btnInizio.UseVisualStyleBackColor = true;
            this.btnInizio.Click += new System.EventHandler(this.btnInizio_Click);
            // 
            // btnIndietro
            // 
            this.btnIndietro.Location = new System.Drawing.Point(683, 384);
            this.btnIndietro.Name = "btnIndietro";
            this.btnIndietro.Size = new System.Drawing.Size(30, 23);
            this.btnIndietro.TabIndex = 17;
            this.btnIndietro.Text = "<";
            this.btnIndietro.UseVisualStyleBackColor = true;
            this.btnIndietro.Click += new System.EventHandler(this.btnIndietro_Click);
            // 
            // btnAvanti
            // 
            this.btnAvanti.Location = new System.Drawing.Point(714, 384);
            this.btnAvanti.Name = "btnAvanti";
            this.btnAvanti.Size = new System.Drawing.Size(30, 23);
            this.btnAvanti.TabIndex = 18;
            this.btnAvanti.Text = ">";
            this.btnAvanti.UseVisualStyleBackColor = true;
            this.btnAvanti.Click += new System.EventHandler(this.btnAvanti_Click);
            // 
            // btnFine
            // 
            this.btnFine.Location = new System.Drawing.Point(745, 384);
            this.btnFine.Name = "btnFine";
            this.btnFine.Size = new System.Drawing.Size(30, 23);
            this.btnFine.TabIndex = 19;
            this.btnFine.Text = ">|";
            this.btnFine.UseVisualStyleBackColor = true;
            this.btnFine.Click += new System.EventHandler(this.btnFine_Click);
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(787, 384);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(60, 23);
            this.btnInserisci.TabIndex = 20;
            this.btnInserisci.Text = "Nuovo";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(848, 384);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(60, 23);
            this.btnModifica.TabIndex = 21;
            this.btnModifica.Text = "Aggiorna";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnCancella
            // 
            this.btnCancella.Location = new System.Drawing.Point(912, 384);
            this.btnCancella.Name = "btnCancella";
            this.btnCancella.Size = new System.Drawing.Size(60, 23);
            this.btnCancella.TabIndex = 22;
            this.btnCancella.Text = "Cancella";
            this.btnCancella.UseVisualStyleBackColor = true;
            this.btnCancella.Click += new System.EventHandler(this.btnCancella_Click);
            // 
            // btnTermina
            // 
            this.btnTermina.Location = new System.Drawing.Point(875, 411);
            this.btnTermina.Name = "btnTermina";
            this.btnTermina.Size = new System.Drawing.Size(65, 23);
            this.btnTermina.TabIndex = 25;
            this.btnTermina.Text = "Termina";
            this.btnTermina.UseVisualStyleBackColor = true;
            this.btnTermina.Click += new System.EventHandler(this.btnTermina_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(810, 411);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(65, 23);
            this.btnAbout.TabIndex = 24;
            this.btnAbout.Text = "About...";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnCerca
            // 
            this.btnCerca.Location = new System.Drawing.Point(652, 411);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(61, 23);
            this.btnCerca.TabIndex = 23;
            this.btnCerca.Text = "Cerca...";
            this.btnCerca.UseVisualStyleBackColor = true;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // btnAiuto
            // 
            this.btnAiuto.Location = new System.Drawing.Point(940, 411);
            this.btnAiuto.Name = "btnAiuto";
            this.btnAiuto.Size = new System.Drawing.Size(30, 23);
            this.btnAiuto.TabIndex = 26;
            this.btnAiuto.Text = "?";
            this.btnAiuto.UseVisualStyleBackColor = true;
            this.btnAiuto.Click += new System.EventHandler(this.btnAiuto_Click);
            // 
            // btnSvuotaScheda
            // 
            this.btnSvuotaScheda.Location = new System.Drawing.Point(713, 411);
            this.btnSvuotaScheda.Name = "btnSvuotaScheda";
            this.btnSvuotaScheda.Size = new System.Drawing.Size(94, 23);
            this.btnSvuotaScheda.TabIndex = 27;
            this.btnSvuotaScheda.Text = "Svuota scheda";
            this.btnSvuotaScheda.UseVisualStyleBackColor = true;
            this.btnSvuotaScheda.Click += new System.EventHandler(this.btnSvuotaScheda_Click);
            // 
            // RobCellphones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.btnSvuotaScheda);
            this.Controls.Add(this.btnAiuto);
            this.Controls.Add(this.btnCerca);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnTermina);
            this.Controls.Add(this.btnCancella);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.btnFine);
            this.Controls.Add(this.btnAvanti);
            this.Controls.Add(this.btnIndietro);
            this.Controls.Add(this.btnInizio);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpSchedaCellulare);
            this.Controls.Add(this.grpListaCellulari);
            this.Name = "RobCellphones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RobCellphones2";
            this.Load += new System.EventHandler(this.RobCellphones_Load);
            this.grpListaCellulari.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGrdView)).EndInit();
            this.grpSchedaCellulare.ResumeLayout(false);
            this.grpSchedaCellulare.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpListaCellulari;
        private System.Windows.Forms.GroupBox grpSchedaCellulare;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel positionLabel;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.DataGridView dGrdView;
        private System.Windows.Forms.TextBox txtImei2;
        private System.Windows.Forms.Label lblImei2;
        private System.Windows.Forms.TextBox txtImei1;
        private System.Windows.Forms.Label lblImei1;
        private System.Windows.Forms.TextBox txtCellnumber;
        private System.Windows.Forms.Label lblCellnumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.TextBox txtLastupdate;
        private System.Windows.Forms.Label lblLastupdate;
        private System.Windows.Forms.ComboBox cmbSite;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.Button btnInizio;
        private System.Windows.Forms.Button btnIndietro;
        private System.Windows.Forms.Button btnAvanti;
        private System.Windows.Forms.Button btnFine;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnCancella;
        private System.Windows.Forms.Button btnTermina;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.Button btnAiuto;
        private System.Windows.Forms.Button btnSvuotaScheda;
    }
}

