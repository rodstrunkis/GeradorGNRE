namespace GeradorGNRE
{
    partial class FPrincipal
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
            this.lblRazaosocialEmitente = new System.Windows.Forms.Label();
            this.cbRazaoSocialEmitente = new System.Windows.Forms.ComboBox();
            this.cbUFFavorecida = new System.Windows.Forms.ComboBox();
            this.lblUFFavorecida = new System.Windows.Forms.Label();
            this.cbReceita = new System.Windows.Forms.ComboBox();
            this.lblReceita = new System.Windows.Forms.Label();
            this.cbDocOrigem = new System.Windows.Forms.ComboBox();
            this.lblDocOrigem = new System.Windows.Forms.Label();
            this.cbRefPeriodo = new System.Windows.Forms.ComboBox();
            this.lblRefPeriodo = new System.Windows.Forms.Label();
            this.lblRefMes = new System.Windows.Forms.Label();
            this.cbRefMes = new System.Windows.Forms.ComboBox();
            this.lblRefAno = new System.Windows.Forms.Label();
            this.mtbRefAno = new System.Windows.Forms.MaskedTextBox();
            this.lblValorPrincipal = new System.Windows.Forms.Label();
            this.tbValorPrincipal = new System.Windows.Forms.TextBox();
            this.lblDataVenc = new System.Windows.Forms.Label();
            this.dtpDataVenc = new System.Windows.Forms.DateTimePicker();
            this.tbConvenio = new System.Windows.Forms.TextBox();
            this.lblConvenio = new System.Windows.Forms.Label();
            this.mtbTipoDocOrigem = new System.Windows.Forms.MaskedTextBox();
            this.lblTipoDocOrigem = new System.Windows.Forms.Label();
            this.dtpDataPgto = new System.Windows.Forms.DateTimePicker();
            this.lblDataPgto = new System.Windows.Forms.Label();
            this.lblChaveNFE = new System.Windows.Forms.Label();
            this.mtbChaveNFE = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblRazaosocialEmitente
            // 
            this.lblRazaosocialEmitente.AutoSize = true;
            this.lblRazaosocialEmitente.Location = new System.Drawing.Point(12, 9);
            this.lblRazaosocialEmitente.Name = "lblRazaosocialEmitente";
            this.lblRazaosocialEmitente.Size = new System.Drawing.Size(117, 13);
            this.lblRazaosocialEmitente.TabIndex = 0;
            this.lblRazaosocialEmitente.Text = "Razão Social Emitente:";
            // 
            // cbRazaoSocialEmitente
            // 
            this.cbRazaoSocialEmitente.FormattingEnabled = true;
            this.cbRazaoSocialEmitente.Location = new System.Drawing.Point(15, 25);
            this.cbRazaoSocialEmitente.Name = "cbRazaoSocialEmitente";
            this.cbRazaoSocialEmitente.Size = new System.Drawing.Size(261, 21);
            this.cbRazaoSocialEmitente.TabIndex = 1;
            // 
            // cbUFFavorecida
            // 
            this.cbUFFavorecida.FormattingEnabled = true;
            this.cbUFFavorecida.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cbUFFavorecida.Location = new System.Drawing.Point(282, 25);
            this.cbUFFavorecida.Name = "cbUFFavorecida";
            this.cbUFFavorecida.Size = new System.Drawing.Size(77, 21);
            this.cbUFFavorecida.TabIndex = 3;
            // 
            // lblUFFavorecida
            // 
            this.lblUFFavorecida.AutoSize = true;
            this.lblUFFavorecida.Location = new System.Drawing.Point(279, 9);
            this.lblUFFavorecida.Name = "lblUFFavorecida";
            this.lblUFFavorecida.Size = new System.Drawing.Size(80, 13);
            this.lblUFFavorecida.TabIndex = 2;
            this.lblUFFavorecida.Text = "UF Favorecida:";
            // 
            // cbReceita
            // 
            this.cbReceita.FormattingEnabled = true;
            this.cbReceita.Items.AddRange(new object[] {
            "100102",
            "100129"});
            this.cbReceita.Location = new System.Drawing.Point(365, 25);
            this.cbReceita.Name = "cbReceita";
            this.cbReceita.Size = new System.Drawing.Size(77, 21);
            this.cbReceita.TabIndex = 5;
            // 
            // lblReceita
            // 
            this.lblReceita.AutoSize = true;
            this.lblReceita.Location = new System.Drawing.Point(362, 9);
            this.lblReceita.Name = "lblReceita";
            this.lblReceita.Size = new System.Drawing.Size(47, 13);
            this.lblReceita.TabIndex = 4;
            this.lblReceita.Text = "Receita:";
            // 
            // cbDocOrigem
            // 
            this.cbDocOrigem.FormattingEnabled = true;
            this.cbDocOrigem.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18"});
            this.cbDocOrigem.Location = new System.Drawing.Point(448, 25);
            this.cbDocOrigem.Name = "cbDocOrigem";
            this.cbDocOrigem.Size = new System.Drawing.Size(66, 21);
            this.cbDocOrigem.TabIndex = 7;
            // 
            // lblDocOrigem
            // 
            this.lblDocOrigem.AutoSize = true;
            this.lblDocOrigem.Location = new System.Drawing.Point(445, 9);
            this.lblDocOrigem.Name = "lblDocOrigem";
            this.lblDocOrigem.Size = new System.Drawing.Size(69, 13);
            this.lblDocOrigem.TabIndex = 6;
            this.lblDocOrigem.Text = "Doc. Origem:";
            // 
            // cbRefPeriodo
            // 
            this.cbRefPeriodo.FormattingEnabled = true;
            this.cbRefPeriodo.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbRefPeriodo.Location = new System.Drawing.Point(520, 24);
            this.cbRefPeriodo.Name = "cbRefPeriodo";
            this.cbRefPeriodo.Size = new System.Drawing.Size(68, 21);
            this.cbRefPeriodo.TabIndex = 9;
            // 
            // lblRefPeriodo
            // 
            this.lblRefPeriodo.AutoSize = true;
            this.lblRefPeriodo.Location = new System.Drawing.Point(517, 9);
            this.lblRefPeriodo.Name = "lblRefPeriodo";
            this.lblRefPeriodo.Size = new System.Drawing.Size(71, 13);
            this.lblRefPeriodo.TabIndex = 8;
            this.lblRefPeriodo.Text = "Ref. Período:";
            // 
            // lblRefMes
            // 
            this.lblRefMes.AutoSize = true;
            this.lblRefMes.Location = new System.Drawing.Point(591, 9);
            this.lblRefMes.Name = "lblRefMes";
            this.lblRefMes.Size = new System.Drawing.Size(53, 13);
            this.lblRefMes.TabIndex = 10;
            this.lblRefMes.Text = "Ref. Mês:";
            // 
            // cbRefMes
            // 
            this.cbRefMes.FormattingEnabled = true;
            this.cbRefMes.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbRefMes.Location = new System.Drawing.Point(594, 24);
            this.cbRefMes.Name = "cbRefMes";
            this.cbRefMes.Size = new System.Drawing.Size(50, 21);
            this.cbRefMes.TabIndex = 11;
            // 
            // lblRefAno
            // 
            this.lblRefAno.AutoSize = true;
            this.lblRefAno.Location = new System.Drawing.Point(647, 9);
            this.lblRefAno.Name = "lblRefAno";
            this.lblRefAno.Size = new System.Drawing.Size(52, 13);
            this.lblRefAno.TabIndex = 12;
            this.lblRefAno.Text = "Ref. Ano:";
            // 
            // mtbRefAno
            // 
            this.mtbRefAno.Location = new System.Drawing.Point(650, 24);
            this.mtbRefAno.Mask = "9999";
            this.mtbRefAno.Name = "mtbRefAno";
            this.mtbRefAno.Size = new System.Drawing.Size(49, 20);
            this.mtbRefAno.TabIndex = 13;
            // 
            // lblValorPrincipal
            // 
            this.lblValorPrincipal.AutoSize = true;
            this.lblValorPrincipal.Location = new System.Drawing.Point(702, 9);
            this.lblValorPrincipal.Name = "lblValorPrincipal";
            this.lblValorPrincipal.Size = new System.Drawing.Size(77, 13);
            this.lblValorPrincipal.TabIndex = 14;
            this.lblValorPrincipal.Text = "Valor Principal:";
            // 
            // tbValorPrincipal
            // 
            this.tbValorPrincipal.Location = new System.Drawing.Point(705, 24);
            this.tbValorPrincipal.Name = "tbValorPrincipal";
            this.tbValorPrincipal.Size = new System.Drawing.Size(74, 20);
            this.tbValorPrincipal.TabIndex = 15;
            // 
            // lblDataVenc
            // 
            this.lblDataVenc.AutoSize = true;
            this.lblDataVenc.Location = new System.Drawing.Point(782, 8);
            this.lblDataVenc.Name = "lblDataVenc";
            this.lblDataVenc.Size = new System.Drawing.Size(107, 13);
            this.lblDataVenc.TabIndex = 16;
            this.lblDataVenc.Text = "Data do Vencimento:";
            // 
            // dtpDataVenc
            // 
            this.dtpDataVenc.Location = new System.Drawing.Point(785, 24);
            this.dtpDataVenc.Name = "dtpDataVenc";
            this.dtpDataVenc.Size = new System.Drawing.Size(200, 20);
            this.dtpDataVenc.TabIndex = 17;
            // 
            // tbConvenio
            // 
            this.tbConvenio.Location = new System.Drawing.Point(15, 64);
            this.tbConvenio.Name = "tbConvenio";
            this.tbConvenio.Size = new System.Drawing.Size(114, 20);
            this.tbConvenio.TabIndex = 19;
            // 
            // lblConvenio
            // 
            this.lblConvenio.AutoSize = true;
            this.lblConvenio.Location = new System.Drawing.Point(12, 49);
            this.lblConvenio.Name = "lblConvenio";
            this.lblConvenio.Size = new System.Drawing.Size(55, 13);
            this.lblConvenio.TabIndex = 18;
            this.lblConvenio.Text = "Convênio:";
            // 
            // mtbTipoDocOrigem
            // 
            this.mtbTipoDocOrigem.Location = new System.Drawing.Point(135, 64);
            this.mtbTipoDocOrigem.Mask = "99";
            this.mtbTipoDocOrigem.Name = "mtbTipoDocOrigem";
            this.mtbTipoDocOrigem.Size = new System.Drawing.Size(49, 20);
            this.mtbTipoDocOrigem.TabIndex = 21;
            // 
            // lblTipoDocOrigem
            // 
            this.lblTipoDocOrigem.AutoSize = true;
            this.lblTipoDocOrigem.Location = new System.Drawing.Point(132, 49);
            this.lblTipoDocOrigem.Name = "lblTipoDocOrigem";
            this.lblTipoDocOrigem.Size = new System.Drawing.Size(93, 13);
            this.lblTipoDocOrigem.TabIndex = 20;
            this.lblTipoDocOrigem.Text = "Tipo Doc. Origem:";
            // 
            // dtpDataPgto
            // 
            this.dtpDataPgto.Location = new System.Drawing.Point(231, 64);
            this.dtpDataPgto.Name = "dtpDataPgto";
            this.dtpDataPgto.Size = new System.Drawing.Size(200, 20);
            this.dtpDataPgto.TabIndex = 23;
            // 
            // lblDataPgto
            // 
            this.lblDataPgto.AutoSize = true;
            this.lblDataPgto.Location = new System.Drawing.Point(228, 49);
            this.lblDataPgto.Name = "lblDataPgto";
            this.lblDataPgto.Size = new System.Drawing.Size(105, 13);
            this.lblDataPgto.TabIndex = 22;
            this.lblDataPgto.Text = "Data do Pagamento:";
            // 
            // lblChaveNFE
            // 
            this.lblChaveNFE.AutoSize = true;
            this.lblChaveNFE.Location = new System.Drawing.Point(434, 49);
            this.lblChaveNFE.Name = "lblChaveNFE";
            this.lblChaveNFE.Size = new System.Drawing.Size(65, 13);
            this.lblChaveNFE.TabIndex = 24;
            this.lblChaveNFE.Text = "Chave NFE:";
            // 
            // mtbChaveNFE
            // 
            this.mtbChaveNFE.Location = new System.Drawing.Point(437, 64);
            this.mtbChaveNFE.Mask = "99.9999.99999999999999.99.999.999999999.999999999.9";
            this.mtbChaveNFE.Name = "mtbChaveNFE";
            this.mtbChaveNFE.Size = new System.Drawing.Size(342, 20);
            this.mtbChaveNFE.TabIndex = 25;
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 452);
            this.Controls.Add(this.mtbChaveNFE);
            this.Controls.Add(this.lblChaveNFE);
            this.Controls.Add(this.dtpDataPgto);
            this.Controls.Add(this.lblDataPgto);
            this.Controls.Add(this.mtbTipoDocOrigem);
            this.Controls.Add(this.lblTipoDocOrigem);
            this.Controls.Add(this.tbConvenio);
            this.Controls.Add(this.lblConvenio);
            this.Controls.Add(this.dtpDataVenc);
            this.Controls.Add(this.lblDataVenc);
            this.Controls.Add(this.tbValorPrincipal);
            this.Controls.Add(this.lblValorPrincipal);
            this.Controls.Add(this.mtbRefAno);
            this.Controls.Add(this.lblRefAno);
            this.Controls.Add(this.cbRefMes);
            this.Controls.Add(this.lblRefMes);
            this.Controls.Add(this.cbRefPeriodo);
            this.Controls.Add(this.lblRefPeriodo);
            this.Controls.Add(this.cbDocOrigem);
            this.Controls.Add(this.lblDocOrigem);
            this.Controls.Add(this.cbReceita);
            this.Controls.Add(this.lblReceita);
            this.Controls.Add(this.cbUFFavorecida);
            this.Controls.Add(this.lblUFFavorecida);
            this.Controls.Add(this.cbRazaoSocialEmitente);
            this.Controls.Add(this.lblRazaosocialEmitente);
            this.MaximizeBox = false;
            this.Name = "FPrincipal";
            this.Text = "Gerador GNRE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRazaosocialEmitente;
        private System.Windows.Forms.ComboBox cbRazaoSocialEmitente;
        private System.Windows.Forms.ComboBox cbUFFavorecida;
        private System.Windows.Forms.Label lblUFFavorecida;
        private System.Windows.Forms.ComboBox cbReceita;
        private System.Windows.Forms.Label lblReceita;
        private System.Windows.Forms.ComboBox cbDocOrigem;
        private System.Windows.Forms.Label lblDocOrigem;
        private System.Windows.Forms.ComboBox cbRefPeriodo;
        private System.Windows.Forms.Label lblRefPeriodo;
        private System.Windows.Forms.Label lblRefMes;
        private System.Windows.Forms.ComboBox cbRefMes;
        private System.Windows.Forms.Label lblRefAno;
        private System.Windows.Forms.MaskedTextBox mtbRefAno;
        private System.Windows.Forms.Label lblValorPrincipal;
        private System.Windows.Forms.TextBox tbValorPrincipal;
        private System.Windows.Forms.Label lblDataVenc;
        private System.Windows.Forms.DateTimePicker dtpDataVenc;
        private System.Windows.Forms.TextBox tbConvenio;
        private System.Windows.Forms.Label lblConvenio;
        private System.Windows.Forms.MaskedTextBox mtbTipoDocOrigem;
        private System.Windows.Forms.Label lblTipoDocOrigem;
        private System.Windows.Forms.DateTimePicker dtpDataPgto;
        private System.Windows.Forms.Label lblDataPgto;
        private System.Windows.Forms.Label lblChaveNFE;
        private System.Windows.Forms.MaskedTextBox mtbChaveNFE;
    }
}

