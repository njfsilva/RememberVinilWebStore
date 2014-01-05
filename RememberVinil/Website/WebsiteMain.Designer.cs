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
            this.lbOrderStatus = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFinishOrder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbPrices = new System.Windows.Forms.ListBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.lvSongs = new System.Windows.Forms.ListView();
            this.lvShoppingCart = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
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
            // lbOrderStatus
            // 
            this.lbOrderStatus.FormattingEnabled = true;
            this.lbOrderStatus.Location = new System.Drawing.Point(989, 296);
            this.lbOrderStatus.Name = "lbOrderStatus";
            this.lbOrderStatus.Size = new System.Drawing.Size(143, 173);
            this.lbOrderStatus.TabIndex = 9;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(986, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Precos";
            // 
            // lbPrices
            // 
            this.lbPrices.FormattingEnabled = true;
            this.lbPrices.Location = new System.Drawing.Point(989, 76);
            this.lbPrices.Name = "lbPrices";
            this.lbPrices.Size = new System.Drawing.Size(134, 134);
            this.lbPrices.TabIndex = 13;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(989, 217);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(75, 23);
            this.btnPlaceOrder.TabIndex = 14;
            this.btnPlaceOrder.Text = "Encomendar";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
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
            // 
            // WebsiteMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 528);
            this.Controls.Add(this.btnConfirmOrder);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lvShoppingCart);
            this.Controls.Add(this.lvSongs);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.lbPrices);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFinishOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbOrderStatus);
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
        private System.Windows.Forms.ListBox lbOrderStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFinishOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbPrices;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.ListView lvSongs;
        private System.Windows.Forms.ListView lvShoppingCart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnConfirmOrder;
    }
}