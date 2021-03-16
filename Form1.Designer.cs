
namespace Vedio_Rentel
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
            this.PopCustBtn = new System.Windows.Forms.Button();
            this.LoadRentedMoviesData = new System.Windows.Forms.Button();
            this.btnGive = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.LoadMoviesData = new System.Windows.Forms.Button();
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.LoadCustomerData = new System.Windows.Forms.Button();
            this.DltCustBtn = new System.Windows.Forms.Button();
            this.CustIDTBox = new System.Windows.Forms.TextBox();
            this.UpdCustBtn = new System.Windows.Forms.Button();
            this.AddCustBtn = new System.Windows.Forms.Button();
            this.PhTBox = new System.Windows.Forms.TextBox();
            this.AdTBox = new System.Windows.Forms.TextBox();
            this.LNTBox = new System.Windows.Forms.TextBox();
            this.FNTBox = new System.Windows.Forms.TextBox();
            this.CustomerBox = new System.Windows.Forms.GroupBox();
            this.CustIDLabel = new System.Windows.Forms.Label();
            this.PhLabel = new System.Windows.Forms.Label();
            this.AdLabel = new System.Windows.Forms.Label();
            this.LNLabel = new System.Windows.Forms.Label();
            this.FNLabel = new System.Windows.Forms.Label();
            this.MovieBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.TextBox();
            this.lblplot = new System.Windows.Forms.Label();
            this.copies = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.plot = new System.Windows.Forms.TextBox();
            this.lblMovie = new System.Windows.Forms.Label();
            this.DeleteMovie = new System.Windows.Forms.Button();
            this.UpdateMovie = new System.Windows.Forms.Button();
            this.lblCopies = new System.Windows.Forms.Label();
            this.AddMovie = new System.Windows.Forms.Button();
            this.lblcost = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.rating = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.MovieID = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.TextBox();
            this.cost = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.CustomerBox.SuspendLayout();
            this.MovieBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PopCustBtn
            // 
            this.PopCustBtn.Location = new System.Drawing.Point(256, 237);
            this.PopCustBtn.Name = "PopCustBtn";
            this.PopCustBtn.Size = new System.Drawing.Size(119, 20);
            this.PopCustBtn.TabIndex = 30;
            this.PopCustBtn.Text = "Popular Customer";
            this.PopCustBtn.UseVisualStyleBackColor = true;
            this.PopCustBtn.Click += new System.EventHandler(this.PopCustBtn_Click);
            // 
            // LoadRentedMoviesData
            // 
            this.LoadRentedMoviesData.Location = new System.Drawing.Point(452, 38);
            this.LoadRentedMoviesData.Name = "LoadRentedMoviesData";
            this.LoadRentedMoviesData.Size = new System.Drawing.Size(170, 54);
            this.LoadRentedMoviesData.TabIndex = 29;
            this.LoadRentedMoviesData.Text = "Rented Movies";
            this.LoadRentedMoviesData.UseVisualStyleBackColor = true;
            this.LoadRentedMoviesData.Click += new System.EventHandler(this.LoadRentedMoviesData_Click);
            // 
            // btnGive
            // 
            this.btnGive.Location = new System.Drawing.Point(460, 417);
            this.btnGive.Name = "btnGive";
            this.btnGive.Size = new System.Drawing.Size(94, 54);
            this.btnGive.TabIndex = 28;
            this.btnGive.Text = "Give";
            this.btnGive.UseVisualStyleBackColor = true;
            this.btnGive.Click += new System.EventHandler(this.IssueMovieBtn_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(603, 417);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(96, 54);
            this.btnReturn.TabIndex = 27;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.ReturnMovieBtn_Click);
            // 
            // LoadMoviesData
            // 
            this.LoadMoviesData.Location = new System.Drawing.Point(231, 38);
            this.LoadMoviesData.Name = "LoadMoviesData";
            this.LoadMoviesData.Size = new System.Drawing.Size(141, 54);
            this.LoadMoviesData.TabIndex = 26;
            this.LoadMoviesData.Text = "Movies";
            this.LoadMoviesData.UseVisualStyleBackColor = true;
            this.LoadMoviesData.Click += new System.EventHandler(this.LoadMoviesData_Click);
            // 
            // MainGrid
            // 
            this.MainGrid.BackgroundColor = System.Drawing.Color.White;
            this.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGrid.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainGrid.Location = new System.Drawing.Point(12, 109);
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.Size = new System.Drawing.Size(760, 293);
            this.MainGrid.TabIndex = 25;
            this.MainGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainGrid_CellContentClick);
            this.MainGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainGrid_CellContentClick);
            // 
            // LoadCustomerData
            // 
            this.LoadCustomerData.Location = new System.Drawing.Point(33, 38);
            this.LoadCustomerData.Name = "LoadCustomerData";
            this.LoadCustomerData.Size = new System.Drawing.Size(141, 54);
            this.LoadCustomerData.TabIndex = 24;
            this.LoadCustomerData.Text = "Customers";
            this.LoadCustomerData.UseVisualStyleBackColor = true;
            this.LoadCustomerData.Click += new System.EventHandler(this.LoadCustomerData_Click);
            // 
            // DltCustBtn
            // 
            this.DltCustBtn.Location = new System.Drawing.Point(169, 148);
            this.DltCustBtn.Name = "DltCustBtn";
            this.DltCustBtn.Size = new System.Drawing.Size(62, 54);
            this.DltCustBtn.TabIndex = 39;
            this.DltCustBtn.Text = "Delete Customer";
            this.DltCustBtn.UseVisualStyleBackColor = true;
            this.DltCustBtn.Click += new System.EventHandler(this.DltCustBtn_Click);
            // 
            // CustIDTBox
            // 
            this.CustIDTBox.Enabled = false;
            this.CustIDTBox.Location = new System.Drawing.Point(29, 50);
            this.CustIDTBox.Name = "CustIDTBox";
            this.CustIDTBox.Size = new System.Drawing.Size(100, 20);
            this.CustIDTBox.TabIndex = 38;
            // 
            // UpdCustBtn
            // 
            this.UpdCustBtn.Location = new System.Drawing.Point(101, 148);
            this.UpdCustBtn.Name = "UpdCustBtn";
            this.UpdCustBtn.Size = new System.Drawing.Size(62, 54);
            this.UpdCustBtn.TabIndex = 37;
            this.UpdCustBtn.Text = "Update Customer";
            this.UpdCustBtn.UseVisualStyleBackColor = true;
            this.UpdCustBtn.Click += new System.EventHandler(this.UpdCustBtn_Click);
            // 
            // AddCustBtn
            // 
            this.AddCustBtn.Location = new System.Drawing.Point(33, 148);
            this.AddCustBtn.Name = "AddCustBtn";
            this.AddCustBtn.Size = new System.Drawing.Size(62, 54);
            this.AddCustBtn.TabIndex = 36;
            this.AddCustBtn.Text = "Add Customer";
            this.AddCustBtn.UseVisualStyleBackColor = true;
            this.AddCustBtn.Click += new System.EventHandler(this.AddCustBtn_Click);
            // 
            // PhTBox
            // 
            this.PhTBox.Location = new System.Drawing.Point(141, 103);
            this.PhTBox.Name = "PhTBox";
            this.PhTBox.Size = new System.Drawing.Size(100, 20);
            this.PhTBox.TabIndex = 35;
            // 
            // AdTBox
            // 
            this.AdTBox.Location = new System.Drawing.Point(29, 103);
            this.AdTBox.Name = "AdTBox";
            this.AdTBox.Size = new System.Drawing.Size(100, 20);
            this.AdTBox.TabIndex = 34;
            // 
            // LNTBox
            // 
            this.LNTBox.Location = new System.Drawing.Point(271, 50);
            this.LNTBox.Name = "LNTBox";
            this.LNTBox.Size = new System.Drawing.Size(100, 20);
            this.LNTBox.TabIndex = 33;
            // 
            // FNTBox
            // 
            this.FNTBox.Location = new System.Drawing.Point(141, 50);
            this.FNTBox.Name = "FNTBox";
            this.FNTBox.Size = new System.Drawing.Size(100, 20);
            this.FNTBox.TabIndex = 32;
            // 
            // CustomerBox
            // 
            this.CustomerBox.BackColor = System.Drawing.Color.DarkGray;
            this.CustomerBox.Controls.Add(this.CustIDLabel);
            this.CustomerBox.Controls.Add(this.PopCustBtn);
            this.CustomerBox.Controls.Add(this.DltCustBtn);
            this.CustomerBox.Controls.Add(this.UpdCustBtn);
            this.CustomerBox.Controls.Add(this.PhLabel);
            this.CustomerBox.Controls.Add(this.AddCustBtn);
            this.CustomerBox.Controls.Add(this.AdLabel);
            this.CustomerBox.Controls.Add(this.LNLabel);
            this.CustomerBox.Controls.Add(this.FNLabel);
            this.CustomerBox.Controls.Add(this.FNTBox);
            this.CustomerBox.Controls.Add(this.LNTBox);
            this.CustomerBox.Controls.Add(this.CustIDTBox);
            this.CustomerBox.Controls.Add(this.AdTBox);
            this.CustomerBox.Controls.Add(this.PhTBox);
            this.CustomerBox.Location = new System.Drawing.Point(635, 125);
            this.CustomerBox.Name = "CustomerBox";
            this.CustomerBox.Size = new System.Drawing.Size(381, 263);
            this.CustomerBox.TabIndex = 41;
            this.CustomerBox.TabStop = false;
            this.CustomerBox.Text = "CustomerBox";
            // 
            // CustIDLabel
            // 
            this.CustIDLabel.AutoSize = true;
            this.CustIDLabel.Location = new System.Drawing.Point(26, 34);
            this.CustIDLabel.Name = "CustIDLabel";
            this.CustIDLabel.Size = new System.Drawing.Size(65, 13);
            this.CustIDLabel.TabIndex = 45;
            this.CustIDLabel.Text = "Customer ID";
            // 
            // PhLabel
            // 
            this.PhLabel.AutoSize = true;
            this.PhLabel.Location = new System.Drawing.Point(141, 87);
            this.PhLabel.Name = "PhLabel";
            this.PhLabel.Size = new System.Drawing.Size(38, 13);
            this.PhLabel.TabIndex = 44;
            this.PhLabel.Text = "Phone";
            // 
            // AdLabel
            // 
            this.AdLabel.AutoSize = true;
            this.AdLabel.Location = new System.Drawing.Point(32, 87);
            this.AdLabel.Name = "AdLabel";
            this.AdLabel.Size = new System.Drawing.Size(45, 13);
            this.AdLabel.TabIndex = 43;
            this.AdLabel.Text = "Address";
            // 
            // LNLabel
            // 
            this.LNLabel.AutoSize = true;
            this.LNLabel.Location = new System.Drawing.Point(268, 34);
            this.LNLabel.Name = "LNLabel";
            this.LNLabel.Size = new System.Drawing.Size(58, 13);
            this.LNLabel.TabIndex = 42;
            this.LNLabel.Text = "Last Name";
            // 
            // FNLabel
            // 
            this.FNLabel.AutoSize = true;
            this.FNLabel.Location = new System.Drawing.Point(141, 34);
            this.FNLabel.Name = "FNLabel";
            this.FNLabel.Size = new System.Drawing.Size(57, 13);
            this.FNLabel.TabIndex = 41;
            this.FNLabel.Text = "First Name";
            // 
            // MovieBox
            // 
            this.MovieBox.BackColor = System.Drawing.Color.DarkGray;
            this.MovieBox.Controls.Add(this.label1);
            this.MovieBox.Controls.Add(this.genre);
            this.MovieBox.Controls.Add(this.lblplot);
            this.MovieBox.Controls.Add(this.copies);
            this.MovieBox.Controls.Add(this.lblGenre);
            this.MovieBox.Controls.Add(this.plot);
            this.MovieBox.Controls.Add(this.lblMovie);
            this.MovieBox.Controls.Add(this.DeleteMovie);
            this.MovieBox.Controls.Add(this.UpdateMovie);
            this.MovieBox.Controls.Add(this.lblCopies);
            this.MovieBox.Controls.Add(this.AddMovie);
            this.MovieBox.Controls.Add(this.lblcost);
            this.MovieBox.Controls.Add(this.lblRating);
            this.MovieBox.Controls.Add(this.lbltitle);
            this.MovieBox.Controls.Add(this.rating);
            this.MovieBox.Controls.Add(this.Title);
            this.MovieBox.Controls.Add(this.MovieID);
            this.MovieBox.Controls.Add(this.Year);
            this.MovieBox.Controls.Add(this.cost);
            this.MovieBox.Location = new System.Drawing.Point(776, 123);
            this.MovieBox.Name = "MovieBox";
            this.MovieBox.Size = new System.Drawing.Size(381, 279);
            this.MovieBox.TabIndex = 46;
            this.MovieBox.TabStop = false;
            this.MovieBox.Text = "MovieBox";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Year";
            // 
            // genre
            // 
            this.genre.Location = new System.Drawing.Point(153, 150);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(100, 20);
            this.genre.TabIndex = 52;
            // 
            // lblplot
            // 
            this.lblplot.AutoSize = true;
            this.lblplot.Location = new System.Drawing.Point(34, 134);
            this.lblplot.Name = "lblplot";
            this.lblplot.Size = new System.Drawing.Size(25, 13);
            this.lblplot.TabIndex = 51;
            this.lblplot.Text = "Plot";
            // 
            // copies
            // 
            this.copies.Location = new System.Drawing.Point(265, 98);
            this.copies.Name = "copies";
            this.copies.Size = new System.Drawing.Size(100, 20);
            this.copies.TabIndex = 50;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(156, 128);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 48;
            this.lblGenre.Text = "Genre";
            // 
            // plot
            // 
            this.plot.Location = new System.Drawing.Point(27, 150);
            this.plot.Name = "plot";
            this.plot.Size = new System.Drawing.Size(100, 20);
            this.plot.TabIndex = 46;
            this.plot.TextChanged += new System.EventHandler(this.genre_TextChanged);
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Location = new System.Drawing.Point(26, 34);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(50, 13);
            this.lblMovie.TabIndex = 45;
            this.lblMovie.Text = "Movie ID";
            // 
            // DeleteMovie
            // 
            this.DeleteMovie.Location = new System.Drawing.Point(265, 190);
            this.DeleteMovie.Name = "DeleteMovie";
            this.DeleteMovie.Size = new System.Drawing.Size(62, 30);
            this.DeleteMovie.TabIndex = 39;
            this.DeleteMovie.Text = "Delete";
            this.DeleteMovie.UseVisualStyleBackColor = true;
            this.DeleteMovie.Click += new System.EventHandler(this.DeleteMovie_Click);
            // 
            // UpdateMovie
            // 
            this.UpdateMovie.Location = new System.Drawing.Point(179, 190);
            this.UpdateMovie.Name = "UpdateMovie";
            this.UpdateMovie.Size = new System.Drawing.Size(62, 27);
            this.UpdateMovie.TabIndex = 37;
            this.UpdateMovie.Text = "Update";
            this.UpdateMovie.UseVisualStyleBackColor = true;
            this.UpdateMovie.Click += new System.EventHandler(this.UpdateMovie_Click);
            // 
            // lblCopies
            // 
            this.lblCopies.AutoSize = true;
            this.lblCopies.Location = new System.Drawing.Point(268, 82);
            this.lblCopies.Name = "lblCopies";
            this.lblCopies.Size = new System.Drawing.Size(39, 13);
            this.lblCopies.TabIndex = 44;
            this.lblCopies.Text = "Copies";
            this.lblCopies.Click += new System.EventHandler(this.lblCopies_Click);
            // 
            // AddMovie
            // 
            this.AddMovie.Location = new System.Drawing.Point(67, 190);
            this.AddMovie.Name = "AddMovie";
            this.AddMovie.Size = new System.Drawing.Size(62, 27);
            this.AddMovie.TabIndex = 36;
            this.AddMovie.Text = "Add ";
            this.AddMovie.UseVisualStyleBackColor = true;
            this.AddMovie.Click += new System.EventHandler(this.AddMovie_Click);
            // 
            // lblcost
            // 
            this.lblcost.AutoSize = true;
            this.lblcost.Location = new System.Drawing.Point(147, 82);
            this.lblcost.Name = "lblcost";
            this.lblcost.Size = new System.Drawing.Size(65, 13);
            this.lblcost.TabIndex = 43;
            this.lblcost.Text = "Rental_Cost";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(147, 34);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(38, 13);
            this.lblRating.TabIndex = 42;
            this.lblRating.Text = "Rating";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Location = new System.Drawing.Point(268, 34);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(27, 13);
            this.lbltitle.TabIndex = 41;
            this.lbltitle.Text = "Title";
            // 
            // rating
            // 
            this.rating.Location = new System.Drawing.Point(141, 50);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(100, 20);
            this.rating.TabIndex = 32;
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(271, 50);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(100, 20);
            this.Title.TabIndex = 33;
            // 
            // MovieID
            // 
            this.MovieID.Enabled = false;
            this.MovieID.Location = new System.Drawing.Point(29, 50);
            this.MovieID.Name = "MovieID";
            this.MovieID.Size = new System.Drawing.Size(100, 20);
            this.MovieID.TabIndex = 38;
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(29, 98);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(100, 20);
            this.Year.TabIndex = 34;
            // 
            // cost
            // 
            this.cost.Location = new System.Drawing.Point(141, 98);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(100, 20);
            this.cost.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1191, 605);
            this.Controls.Add(this.MovieBox);
            this.Controls.Add(this.CustomerBox);
            this.Controls.Add(this.LoadRentedMoviesData);
            this.Controls.Add(this.btnGive);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.LoadMoviesData);
            this.Controls.Add(this.MainGrid);
            this.Controls.Add(this.LoadCustomerData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.CustomerBox.ResumeLayout(false);
            this.CustomerBox.PerformLayout();
            this.MovieBox.ResumeLayout(false);
            this.MovieBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button PopCustBtn;
        private System.Windows.Forms.Button LoadRentedMoviesData;
        private System.Windows.Forms.Button btnGive;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button LoadMoviesData;
        private System.Windows.Forms.DataGridView MainGrid;
        private System.Windows.Forms.Button LoadCustomerData;
        private System.Windows.Forms.Button DltCustBtn;
        private System.Windows.Forms.TextBox CustIDTBox;
        private System.Windows.Forms.Button UpdCustBtn;
        private System.Windows.Forms.Button AddCustBtn;
        private System.Windows.Forms.TextBox PhTBox;
        private System.Windows.Forms.TextBox AdTBox;
        private System.Windows.Forms.TextBox LNTBox;
        private System.Windows.Forms.TextBox FNTBox;
        private System.Windows.Forms.GroupBox CustomerBox;
        private System.Windows.Forms.Label CustIDLabel;
        private System.Windows.Forms.Label PhLabel;
        private System.Windows.Forms.Label AdLabel;
        private System.Windows.Forms.Label LNLabel;
        private System.Windows.Forms.Label FNLabel;
        private System.Windows.Forms.GroupBox MovieBox;
        private System.Windows.Forms.Label lblplot;
        private System.Windows.Forms.TextBox copies;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox plot;
        private System.Windows.Forms.Label lblMovie;
        private System.Windows.Forms.Button DeleteMovie;
        private System.Windows.Forms.Button UpdateMovie;
        private System.Windows.Forms.Label lblCopies;
        private System.Windows.Forms.Button AddMovie;
        private System.Windows.Forms.Label lblcost;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.TextBox rating;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox MovieID;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.TextBox cost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox genre;
    }
}

