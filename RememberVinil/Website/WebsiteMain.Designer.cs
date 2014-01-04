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
            this.button1 = new System.Windows.Forms.Button();
            this.lbAlbums = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSongs = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddSongToOrder = new System.Windows.Forms.Button();
            this.lbOrder = new System.Windows.Forms.ListBox();
            this.lbOrderStatus = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbAlbums
            // 
            this.lbAlbums.FormattingEnabled = true;
            this.lbAlbums.Location = new System.Drawing.Point(34, 130);
            this.lbAlbums.Name = "lbAlbums";
            this.lbAlbums.Size = new System.Drawing.Size(181, 355);
            this.lbAlbums.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Discos do Artista";
            // 
            // lbSongs
            // 
            this.lbSongs.FormattingEnabled = true;
            this.lbSongs.Location = new System.Drawing.Point(250, 130);
            this.lbSongs.Name = "lbSongs";
            this.lbSongs.Size = new System.Drawing.Size(187, 355);
            this.lbSongs.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Musicas Do Disco";
            // 
            // btnAddSongToOrder
            // 
            this.btnAddSongToOrder.Location = new System.Drawing.Point(250, 493);
            this.btnAddSongToOrder.Name = "btnAddSongToOrder";
            this.btnAddSongToOrder.Size = new System.Drawing.Size(75, 23);
            this.btnAddSongToOrder.TabIndex = 7;
            this.btnAddSongToOrder.Text = "Adicionar";
            this.btnAddSongToOrder.UseVisualStyleBackColor = true;
            // 
            // lbOrder
            // 
            this.lbOrder.FormattingEnabled = true;
            this.lbOrder.Location = new System.Drawing.Point(544, 54);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(223, 134);
            this.lbOrder.TabIndex = 8;
            // 
            // lbOrderStatus
            // 
            this.lbOrderStatus.FormattingEnabled = true;
            this.lbOrderStatus.Location = new System.Drawing.Point(544, 274);
            this.lbOrderStatus.Name = "lbOrderStatus";
            this.lbOrderStatus.Size = new System.Drawing.Size(223, 173);
            this.lbOrderStatus.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Encomenda";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(544, 195);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(75, 23);
            this.btnPlaceOrder.TabIndex = 11;
            this.btnPlaceOrder.Text = "Encomendar";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            // 
            // WebsiteMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 528);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbOrderStatus);
            this.Controls.Add(this.lbOrder);
            this.Controls.Add(this.btnAddSongToOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbSongs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbAlbums);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbAlbums;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbSongs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddSongToOrder;
        private System.Windows.Forms.ListBox lbOrder;
        private System.Windows.Forms.ListBox lbOrderStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPlaceOrder;
    }
}