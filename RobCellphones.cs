using System;
/*using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/
using System.Windows.Forms;
using System.Data.SQLite;

namespace RobCellphones2
{
    public partial class RobCellphones : Form
    {
        int intId = 0;

        public RobCellphones()
        {
            InitializeComponent();
            j_Std.IniziaProgramma();
        }

        private void RobCellphones_Load(object sender, EventArgs e)
        {
            /*
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.btnEstrazioniPrimo, "Vai all'ultima Estrazione");
            toolTip1.SetToolTip(this.btnEstrazioniPrecedente, "Vai all'Estrazione precedente");
            toolTip1.SetToolTip(this.btnEstrazioniSuccessivo, "Vai all'Estrazione successiva");
            toolTip1.SetToolTip(this.btnEstrazioniUltimo, "Vai alla prima Estrazione");
            toolTip1.SetToolTip(this.btnTermina, "Termina l'applicazione");
            toolTip1.SetToolTip(this.txtLimite, "Scegli quante Estrazioni vuoi nell'elenco");
            toolTip1.SetToolTip(this.txtDataDA, "Scrivi la data minima da selezionare (formato: AAAA-MM-GG)");
            toolTip1.SetToolTip(this.txtDataA, "Scrivi data MASSIMA da selezionare (formato: AAAA-MM-GG)");
            toolTip1.SetToolTip(this.txtAmboCercato, "Scrivi i numeri cercati (formato: PRIMO-SECONDO)");
            toolTip1.SetToolTip(this.txtTernoCercato, "Scrivi i numeri cercati (formato: PRIMO-SECONDO-TERZO)");
            */
            creaBaseDati();

            // Setto i nomi delle descrizioni di inserimento
            lblCognome.Text = j_Std.Dizionario("cognome");
            lblNome.Text = j_Std.Dizionario("nome");
            lblCellnumber.Text = j_Std.Dizionario("cellulare");
            lblSerial.Text = j_Std.Dizionario("seriale");
            lblModel.Text = j_Std.Dizionario("modello");
            lblSite.Text = j_Std.Dizionario("sito");
            lblNote.Text = j_Std.Dizionario("note");
            lblLastupdate.Text = j_Std.Dizionario("ultimoaggiornamento");

            btnInserisci.Text = j_Std.Dizionario("nuovo");
            btnModifica.Text = j_Std.Dizionario("modifica");
            btnCancella.Text = j_Std.Dizionario("cancella");

            btnCerca.Text = j_Std.Dizionario("cerca");
            btnSvuotaScheda.Text = j_Std.Dizionario("svuotascheda");
            btnTermina.Text = j_Std.Dizionario("terminaapplicazione");

            // Setto le dimensioni delle colonne
            dGrdView.Columns[0].Width = 20;
            dGrdView.Columns[1].Width = 90;
            dGrdView.Columns[2].Width = 90;
            dGrdView.Columns[3].Width = 90;
            dGrdView.Columns[4].Width = 100;
            dGrdView.Columns[5].Width = 100;
            dGrdView.Columns[6].Width = 100;
            dGrdView.Columns[7].Width = 100;
            dGrdView.Columns[8].Width = 100;
            dGrdView.Columns[9].Width = 100;
            dGrdView.Columns[10].Width = 70;

            // Setto i titoli delle colonne
            dGrdView.Columns[0].HeaderText = "#";
            dGrdView.Columns[1].HeaderText = j_Std.Dizionario("cognome");
            dGrdView.Columns[2].HeaderText = j_Std.Dizionario("nome");
            dGrdView.Columns[3].HeaderText = j_Std.Dizionario("cellulare");
            dGrdView.Columns[4].HeaderText = "Imei1";
            dGrdView.Columns[5].HeaderText = "Imei2";
            dGrdView.Columns[6].HeaderText = j_Std.Dizionario("seriale");
            dGrdView.Columns[7].HeaderText = j_Std.Dizionario("modello");
            dGrdView.Columns[8].HeaderText = j_Std.Dizionario("sito");
            dGrdView.Columns[9].HeaderText = j_Std.Dizionario("note");
            dGrdView.Columns[10].HeaderText = j_Std.Dizionario("ultimoaggiornamento");

            data_show("");
        }

        private void creaBaseDati()
        {
            string comandoSql = "";

            // creo la tabella cellulari
            comandoSql = "CREATE TABLE IF NOT EXISTS " + j_locVar.cellulari_Name + "(" +
            "id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE," +
            "surname VARCHAR(20)," +
            "name VARCHAR(20)," +
            "cellnumber VARCHAR(20)," +
            "imei1 VARCHAR(15)," +
            "imei2 VARCHAR(15)," +
            "serial VARCHAR(15)," +
            "modello_id INT," +
            "sito_id INT," +
            "note TEXT," +
            "lastupdate VARCHAR(10)";
            comandoSql += ");";
            j_Std.eseguiComandoSQL(comandoSql);

            // creo la tabella modelli
            comandoSql = "CREATE TABLE IF NOT EXISTS " + j_locVar.modelli_Name + "(" +
            "id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE," +
            "modello VARCHAR(20)," +
            "lastupdate VARCHAR(10)";
            comandoSql += ");";
            j_Std.eseguiComandoSQL(comandoSql);

            // creo la tabella siti
            comandoSql = "CREATE TABLE IF NOT EXISTS " + j_locVar.siti_Name + "(" +
            "id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE," +
            "sito VARCHAR(20)," +
            "lastupdate VARCHAR(10)";
            comandoSql += ");";
            j_Std.eseguiComandoSQL(comandoSql);

        }
        private void data_show(string filtro)
        {
            // serve per la lista dei cellulari iniziale
            SQLiteDataReader dr;
            j_Std.openConnection();

            string comandoSql = "";

            if (filtro == "")
            {
                comandoSql = "SELECT * FROM " + j_locVar.cellulari_Name + ";";
            }
            else
            {
                comandoSql = filtro;
            }

            var cmd = new SQLiteCommand(comandoSql, j_Std.connection);
            dr = cmd.ExecuteReader();

            dGrdView.Rows.Clear();
            //dGrdView.AutoResizeColumns((DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnsMode.AllCells);
            dGrdView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            while (dr.Read())
            {
                dGrdView.Rows.Insert(0, dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6), dr.GetInt32(7), dr.GetInt32(8), dr.GetString(9), dr.GetString(10));
            }
            dr.Close();
            j_Std.closeConnection();

            // ordinamento per cognome direttamente nella DataGridView
            dGrdView.Sort(dGrdView.Columns["surname"], System.ComponentModel.ListSortDirection.Ascending);
            displayPosition();
        }

        private void displayPosition()
        {
            //positionLabel.Text = "Position: " + Convert.ToString(dGrdView.SelectedRows[0].Index) + "/"; // + Convert.ToString(dGrdView.Rows);
        }

        private void btnInizio_Click(object sender, EventArgs e)
        {
            displayPosition();
        }

        private void btnIndietro_Click(object sender, EventArgs e)
        {
            displayPosition();
        }

        private void btnAvanti_Click(object sender, EventArgs e)
        {
            displayPosition();
        }

        private void btnFine_Click(object sender, EventArgs e)
        {
            displayPosition();
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            recordAddUpdateSearch("INSERISCI");
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (intId != 0)
            {
                recordAddUpdateSearch("MODIFICA");
            }
            else
            {
                j_Std.BoxErrore("Devi prima scegliere un record!");
            }
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            recordAddUpdateSearch("CERCA");
        }

        private void recordAddUpdateSearch(string cheFaccio)
        {
            string messaggioErrore = ": " + j_Std.Dizionario("campovuoto");
            string campo = j_Std.Dizionario("campo");
            bool risultato;

            if (cheFaccio != "CERCA")
            {
                if (txtSurname.Text.Length < 1)
                {
                    j_Std.BoxErrore(campo + j_Std.Dizionario("cognome").ToUpper() + messaggioErrore);
                    return;
                }
                if (txtName.Text.Length < 1)
                {
                    j_Std.BoxErrore(campo + j_Std.Dizionario("nome").ToUpper() + messaggioErrore);
                    return;
                }
                if (txtCellnumber.Text.Length < 1)
                {
                    j_Std.BoxErrore(campo + j_Std.Dizionario("cellulare").ToUpper() + messaggioErrore);
                    return;
                }

                if (txtImei1.Text.Length < 1)
                {
                    j_Std.BoxErrore(campo + "IMEI1" + messaggioErrore);
                    return;
                }

                if (txtImei2.Text.Length < 1)
                {
                    j_Std.BoxErrore(campo + "IMEI2" + messaggioErrore);
                    return;
                }

                if (txtSerial.Text.Length < 1)
                {
                    j_Std.BoxErrore(campo + j_Std.Dizionario("seriale").ToUpper() + messaggioErrore);
                    return;
                }
            }
            else
            {
                // almeno uno dei campi deve essere stato compilato
                risultato = (
                    (txtSurname.Text.Length != 0)
                    | (txtName.Text.Length != 0)
                    | (txtCellnumber.Text.Length != 0)
                    | (txtImei1.Text.Length != 0)
                    | (txtImei2.Text.Length != 0)
                    | (txtSerial.Text.Length != 0)
                    | (txtNote.Text.Length != 0)
                    );
                if (risultato == false)
                {
                    j_Std.BoxErrore(j_Std.Dizionario("almenouncampo"));
                    return;
                }
            }

            string lastUpdate = j_Std.DataDiOggi().Substring(0, 10);
            string comandoSql = "";
            int datoPrima = 0;

            switch (cheFaccio)
            {
                case "INSERISCI":
                    comandoSql = "INSERT INTO " + j_locVar.cellulari_Name + " (surname,name,cellnumber,imei1,imei2,serial,modello_id,sito_id,note,lastupdate) VALUES (" +
                    "'" + txtSurname.Text.ToUpper() + "'," +
                    "'" + j_Std.UppercaseFirst(txtName.Text.ToLower()) + "'," +
                    "'" + txtCellnumber.Text + "'," +
                    "'" + txtImei1.Text + "'," +
                    "'" + txtImei2.Text + "'," +
                    "'" + txtSerial.Text + "'," +
                    "0," + //modello_Id.Text + "," +
                    "0," + //sito_Id.Text + "," +
                    "'" + txtNote.Text + "'," +
                    "'" + lastUpdate + "');";
                    break;

                case "MODIFICA":
                    if (j_Std.BoxDomanda(j_Std.Dizionario("recordSalva") + ":\n" + txtSurname.Text.ToUpper() + "") == "OK")
                    {
                        comandoSql = "UPDATE " + j_locVar.cellulari_Name + " SET " +
                        //surname, name, cellphone, imei1, imei2, serial, lastupdate
                        "surname = '" + txtSurname.Text.ToUpper() + "'," +
                        "name = '" + j_Std.UppercaseFirst(txtName.Text.ToLower()) + "'," +
                        "cellnumber = '" + txtCellnumber.Text + "'," +
                        "imei1 = '" + txtImei1.Text + "'," +
                        "imei2 = '" + txtImei2.Text + "'," +
                        "serial = '" + txtSerial.Text + "'," +
                        "modello_Id = 0," + //modello_Id.Text + "'," +
                        "sito_Id = 0," + //sito_Id.Text + "'," +
                        "note = '" + txtNote.Text + "'," +
                        "lastupdate = '" + lastUpdate + "' " +
                        "WHERE id = " + intId.ToString() + ";";
                    };
                    break;

                case "CERCA":
                    comandoSql = "SELECT * FROM " + j_locVar.cellulari_Name + " WHERE ";
                    if (txtSurname.Text.Length > 0)
                    {
                        comandoSql += "(surname LIKE '%" + txtSurname.Text + "%')";
                        datoPrima = 1;
                    }
                    if (txtName.Text.Length > 0)
                    {
                        if (datoPrima == 1)
                        {
                            comandoSql += " AND ";
                        }
                        comandoSql += "(name LIKE '%" + txtName.Text +"%')";
                    }
                    if (txtCellnumber.Text.Length > 0)
                    {
                        if (datoPrima == 1)
                        {
                            comandoSql += " AND ";
                        }
                        comandoSql += "(cellnumber LIKE '%" + txtCellnumber.Text + "%')";
                    }
                    if (txtImei1.Text.Length > 0)
                    {
                        if (datoPrima == 1)
                        {
                            comandoSql += " AND ";
                        }
                        comandoSql += "(imei1 LIKE '%" + txtImei1.Text + "%')";
                    }
                    if (txtImei2.Text.Length > 0)
                    {
                        if (datoPrima == 1)
                        {
                            comandoSql += " AND ";
                        }
                        comandoSql += "(imei2 LIKE '%" + txtImei2.Text + "%')";
                    }
                    if (txtSerial.Text.Length > 0)
                    {
                        if (datoPrima == 1)
                        {
                            comandoSql += " AND ";
                        }
                        comandoSql += "(serial LIKE '%" + txtSerial.Text + "%')";
                    }
                    if (txtNote.Text.Length > 0)
                    {
                        if (datoPrima == 1)
                        {
                            comandoSql += " AND ";
                        }
                        comandoSql += "(note LIKE '%" + txtNote.Text + "%')";
                    }
                    comandoSql += ";";

                /*
                    "modello_Id = 0," + //modello_Id.Text + "'," +
                    "sito_Id = 0," + //sito_Id.Text + "'," +
                */
                    break;
            }

            int fatto = j_Std.eseguiComandoSQL(comandoSql);
            if (fatto > -1)
            {
                j_Std.BoxInformazione(j_Std.Dizionario("recordok"));
                // Azzera scheda
                reset_scheda();
                data_show("");
            }
            else
            {
                if (cheFaccio == "CERCA")
                {
                    data_show(comandoSql);
                }
                else
                {
                    j_Std.BoxErrore(j_Std.Dizionario("opnonfatta"));
                }
            }
        }

        private void btnCancella_Click(object sender, EventArgs e)
        {
            string comandoSql = "";

            if (intId != 0)
            {
                if (j_Std.BoxDomanda(j_Std.Dizionario("recordCancella")) == "OK")
                {
                    comandoSql = "DELETE FROM " + j_locVar.cellulari_Name + " WHERE id = " + intId.ToString();
                }
                else
                {
                    j_Std.BoxOk(j_Std.Dizionario("opnonfatta"));
                    return;
                }

                int fatto = j_Std.eseguiComandoSQL(comandoSql);
                if (fatto > -1)
                {
                    SvuotaScheda();
                }
                else
                {
                    j_Std.BoxErrore(j_Std.Dizionario("opnonfatta"));
                }
            }
            else
            {
                j_Std.BoxErrore("Devi prima scegliere un record!");
            }
        }

        private void dGrdView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Seleziono la riga per elaborarla
            if (e.RowIndex != -1)
            {
                DataGridViewRow dg = dGrdView.Rows[e.RowIndex];
                intId = (int)dg.Cells[0].Value;
                txtSurname.Text = dg.Cells[1].Value.ToString();
                txtName.Text = dg.Cells[2].Value.ToString();
                txtCellnumber.Text = dg.Cells[3].Value.ToString();
                txtImei1.Text = dg.Cells[4].Value.ToString();
                txtImei2.Text = dg.Cells[5].Value.ToString();
                txtSerial.Text = dg.Cells[6].Value.ToString();
                cmbModel.Text = dg.Cells[7].Value.ToString(); // vedere comboBox
                cmbSite.Text = dg.Cells[8].Value.ToString(); // vedere comboBox
                txtNote.Text = dg.Cells[9].Value.ToString();
                txtLastupdate.Text = dg.Cells[10].Value.ToString();
            }
        }

        private void reset_scheda()
        {
            intId = 0;
            txtSurname.Text = "";
            txtName.Text = "";
            txtCellnumber.Text = "";
            txtImei1.Text = "";
            txtImei2.Text = "";
            txtSerial.Text = "";
            cmbModel.Text = "";
            cmbSite.Text = "";
            txtNote.Text = "";
            txtLastupdate.Text = "";
        }

        private void SvuotaScheda()
        {
            reset_scheda();
            j_Std.BoxInformazione(j_Std.Dizionario("opfatta"));
            data_show("");
        }

        private void btnSvuotaScheda_Click(object sender, EventArgs e)
        {
            SvuotaScheda();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            j_Std.BoxAbout("");
        }

        private void btnTermina_Click(object sender, EventArgs e)
        {
            j_Std.TerminaProgramma();
        }

        private void btnAiuto_Click(object sender, EventArgs e)
        {
            j_Std.BoxInformazione(j_Std.Dizionario("spiega"));
        }

        /*
                private void ImportaDati()
                {
                    // Importa i dati da un foglio .CSV con una struttura ben definita
                    if (j_Std.BoxDomanda("dato che l'operazione sarà un po' lunga, e cancellerà il contenuto del Database per poi ripopolarlo,\nconfermi?") == "NO")
                    {
                        j_Std.BoxErrore("Operazione interrotta!");
                        return;
                    }

                    string comandoSql = "";
                    string filePath = "";
                    string line = "";

                    //Char virgolette = Convert.ToChar(34);

                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.InitialDirectory = "c:\\";
                        openFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                        openFileDialog.FilterIndex = 1;
                        openFileDialog.RestoreDirectory = true;

                        if (openFileDialog.ShowDialog() == DialogResult.No)
                        {
                            j_Std.BoxErrore("Operazione interrotta!");
                            return;
                        }
                        //Get the path of specified file
                        filePath = openFileDialog.FileName;
                    }

                    // Prima azzero le 3 tabelle (Estrazioni, Ambi, Terni)
                    j_Std.eseguiComandoSQL("DELETE FROM estrazioni;");
                    j_Std.eseguiComandoSQL("DELETE FROM ambi;");
                    //eseguiComandoSQL("DELETE FROM terni;");

                    // Controllo quante linee saranno da importare dal file CSV,
                    // per poter fare le percentuali corrette (questo è il 100%)
                    int quantiSono = File.ReadAllLines(@filePath).Length;
                    int i, inizioRuota, contatore = 0;
                    double percentuale = 0;
                    String[] aValori = new string[5];

                    //toolStripProgressBar1.Value = 0;

                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        // leggo l'intestazione ma non la considero
                        line = reader.ReadLine();
                        while (!reader.EndOfStream)
                        {
                            line = reader.ReadLine();
                            var values = line.Split(';');
                            comandoSql = "INSERT INTO estrazioni VALUES ('" + values[0] + "'";

                            for (i = 1; i < 57; i++)
                            {
                                comandoSql += ",'" + values[i] + "'";
                            }
                            comandoSql += ");";

                            j_Std.eseguiComandoSQL(comandoSql);

                            int quanteRuote = j_locVar.aRuote.Length;

                            comandoSql = "INSERT INTO ambi VALUES ('" + values[0] + "','" + values[1] + "'";

                            // creo le combinazioni dei numeri per ogni ruota; ordino i numeri della ruota dal più piccolo al più grande
                            // (non si fanno statistiche sulle estrazioni in posizione per ora)
                            inizioRuota = 2;
                            for (i = 1; i <= quanteRuote; i++)
                            {
                                aValori[0] = values[inizioRuota];
                                aValori[1] = values[inizioRuota + 1];
                                aValori[2] = values[inizioRuota + 2];
                                aValori[3] = values[inizioRuota + 3];
                                aValori[4] = values[inizioRuota + 4];
                                Array.Sort(aValori);

                                comandoSql +=
                                ",'" + aValori[0] + "-" + aValori[1] + "'" +
                                ",'" + aValori[0] + "-" + aValori[2] + "'" +
                                ",'" + aValori[0] + "-" + aValori[3] + "'" +
                                ",'" + aValori[0] + "-" + aValori[4] + "'" +
                                ",'" + aValori[1] + "-" + aValori[2] + "'" +
                                ",'" + aValori[1] + "-" + aValori[3] + "'" +
                                ",'" + aValori[1] + "-" + aValori[4] + "'" +
                                ",'" + aValori[2] + "-" + aValori[3] + "'" +
                                ",'" + aValori[2] + "-" + aValori[4] + "'" +
                                ",'" + aValori[3] + "-" + aValori[4] + "'";
                                inizioRuota += 5;
                            }
                            comandoSql += ");";

                            j_Std.eseguiComandoSQL(comandoSql);

                        }
                    }
                    j_Std.BoxOk("Importazione ESTRAZIONI+AMBI terminata.");
                    //toolStripProgressBar1.Value = 0;

                    updateDataBiding();
                }
        */
    }
}
