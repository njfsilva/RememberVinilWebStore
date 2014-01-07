namespace Website
{
    partial class WebsiteMain
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
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.lbArtists = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddSongToOrder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFinishOrder = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.lvSongs = new System.Windows.Forms.ListView();
            this.lvShoppingCart = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();

            this.lbNotifications = new System.Windows.Forms.ListBox();

            this.lb_Status2 = new System.Windows.Forms.ListBox();
            this.lb_Status = new System.Windows.Forms.Label();

            this.SuspendLayout();
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(34, 54);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(100, 20);
            this.txtArtist.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Artista";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(140, 52);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "Pesquisar";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbArtists
            // 
            this.lbArtists.FormattingEnabled = true;
            this.lbArtists.Location = new System.Drawing.Point(34, 130);
            this.lbArtists.Name = "lbArtists";
            this.lbArtists.Size = new System.Drawing.Size(181, 355);
            this.lbArtists.TabIndex = 3;
            this.lbArtists.SelectedIndexChanged += new System.EventHandler(this.lbArtists_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Artistas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Musicas do artista";
            // 
            // btnAddSongToOrder
            // 
            this.btnAddSongToOrder.Location = new System.Drawing.Point(307, 491);
            this.btnAddSongToOrder.Name = "btnAddSongToOrder";
            this.btnAddSongToOrder.Size = new System.Drawing.Size(75, 23);
            this.btnAddSongToOrder.TabIndex = 7;
            this.btnAddSongToOrder.Text = "Adicionar";
            this.btnAddSongToOrder.UseVisualStyleBackColor = true;
            this.btnAddSongToOrder.Click += new System.EventHandler(this.btnAddSongToOrder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Carrinho";
            // 
            // btnFinishOrder
            // 
            this.btnFinishOrder.Location = new System.Drawing.Point(492, 233);
            this.btnFinishOrder.Name = "btnFinishOrder";
            this.btnFinishOrder.Size = new System.Drawing.Size(93, 23);
            this.btnFinishOrder.TabIndex = 11;
            this.btnFinishOrder.Text = "Finalizar";
            this.btnFinishOrder.UseVisualStyleBackColor = true;
            this.btnFinishOrder.Click += new System.EventHandler(this.btnFinishOrder_Click);
            // 
            // lvSongs
            // 
            this.lvSongs.Location = new System.Drawing.Point(224, 130);
            this.lvSongs.Name = "lvSongs";
            this.lvSongs.Size = new System.Drawing.Size(250, 355);
            this.lvSongs.TabIndex = 15;
            this.lvSongs.UseCompatibleStateImageBehavior = false;
            // 
            // lvShoppingCart
            // 
            this.lvShoppingCart.Location = new System.Drawing.Point(492, 93);
            this.lvShoppingCart.Name = "lvShoppingCart";
            this.lvShoppingCart.Size = new System.Drawing.Size(262, 133);
            this.lvShoppingCart.TabIndex = 16;
            this.lvShoppingCart.UseCompatibleStateImageBehavior = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(598, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Total: ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(642, 232);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 18;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(489, 279);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(147, 13);
            this.lblAddress.TabIndex = 19;
            this.lblAddress.Text = "Por favor insira a sua morada:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(492, 296);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(350, 20);
            this.txtAddress.TabIndex = 20;
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.Location = new System.Drawing.Point(625, 322);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmOrder.TabIndex = 21;
            this.btnConfirmOrder.Text = "Confirmar Encomenda";
            this.btnConfirmOrder.UseVisualStyleBackColor = true;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(492, 379);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(0, 13);
            this.lbResultado.TabIndex = 22;
            // 

            // lbNotifications
            // 
            this.lbNotifications.FormattingEnabled = true;
            this.lbNotifications.HorizontalScrollbar = true;
            this.lbNotifications.Location = new System.Drawing.Point(677, 390);
            this.lbNotifications.Name = "lbNotifications";
            this.lbNotifications.Size = new System.Drawing.Size(399, 95);
            this.lbNotifications.TabIndex = 23;

            // lb_Status2
            // 
            this.lb_Status2.FormattingEnabled = true;
            this.lb_Status2.Location = new System.Drawing.Point(934, 93);
            this.lb_Status2.Name = "lb_Status2";
            this.lb_Status2.Size = new System.Drawing.Size(182, 238);
            this.lb_Status2.TabIndex = 23;
            // 
            // lb_Status
            // 
            this.lb_Status.AutoSize = true;
            this.lb_Status.Location = new System.Drawing.Point(934, 60);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(125, 13);
            this.lb_Status.TabIndex = 24;
            this.lb_Status.Text = "Estado das Encomendas";

            // 
            // WebsiteMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 528);

            this.Controls.Add(this.lbNotifications);

            this.Controls.Add(this.lb_Status);
            this.Controls.Add(this.lb_Status2);

            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btnConfirmOrder);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lvShoppingCart);
            this.Controls.Add(this.lvSongs);
            this.Controls.Add(this.btnFinishOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddSongToOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbArtists);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArtist);
            this.Name = "WebsiteMain";
            this.Text = "WebsiteMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.ListBox lbArtists;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddSongToOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFinishOrder;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ListView lvSongs;
        private System.Windows.Forms.ListView lvShoppingCart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.Label lbResultado;

        private System.Windows.Forms.ListBox lbNotifications;

        private System.Windows.Forms.ListBox lb_Status2;
        private System.Windows.Forms.Label lb_Status;

    }
}