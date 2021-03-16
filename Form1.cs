using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vedio_Rentel
{
    public partial class Form1 : Form
    {
        DB Database = new DB();// database connetion 
        string WhichButtonClicked = "";
        string RMID = "";

        public Form1()
        {
            InitializeComponent();
            CustomerBox.Hide();
            MovieBox.Hide();  // when group box show on press releted button 
        }

        private void LoadCustomerData_Click(object sender, EventArgs e)
        {

            MainGrid.DataSource = Database.LoadCustomersData();
            WhichButtonClicked = "Customer";// customer datagrid load when click customer 
            CustomerBox.Show();
            MovieBox.Hide();
        }
    

        private void LoadMoviesData_Click(object sender, EventArgs e)
        {
            MainGrid.DataSource = Database.LoadMoviesData();
            WhichButtonClicked = "Movies";
            CustomerBox.Hide();// Movie  datagrid load when click movie
            MovieBox.Show();
        }

        private void LoadRentedMoviesData_Click(object sender, EventArgs e)
        {
            MainGrid.DataSource = Database.LoadRentedMoviesData();
            WhichButtonClicked = "Rented";  // rentedmovie  datagrid load when click rented movie
            CustomerBox.Hide();
        MovieBox.Hide();
    }

        private void MainGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // data load in text boses when  click any cells
            int index = e.RowIndex;
            DataGridViewRow row = MainGrid.Rows[index];

            if (WhichButtonClicked == "Customer")
            {
                CustIDTBox.Text = row.Cells[0].Value.ToString();
                FNTBox.Text = row.Cells[1].Value.ToString();
                LNTBox.Text = row.Cells[2].Value.ToString();
                AdTBox.Text = row.Cells[3].Value.ToString();
                PhTBox.Text = row.Cells[4].Value.ToString();
            }
            else if (WhichButtonClicked == "Movies")
            {
                MovieID.Text = row.Cells[0].Value.ToString();
                rating.Text = row.Cells[1].Value.ToString();
              
               Title.Text = row.Cells[2].Value.ToString();
                Year.Text = row.Cells[3].Value.ToString();
                cost.Text = row.Cells[4].Value.ToString();
                copies.Text = row.Cells[5].Value.ToString();
                plot.Text = row.Cells[6].Value.ToString();
                genre.Text = row.Cells[7].Value.ToString();

            
              
              
            
            }
            else if (WhichButtonClicked == "Rented")
            {
                RMID = row.Cells[0].Value.ToString();
                Console.WriteLine(RMID);
            }
        }

        private void PopCustBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Database.PopularCustomer());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddCustBtn_Click(object sender, EventArgs e)
        {

           Database.AddCustomerData(FNTBox.Text, LNTBox.Text, PhTBox.Text, AdTBox.Text);
            LoadCustomerData_Click(null, null);
        }

        private void UpdCustBtn_Click(object sender, EventArgs e)
        {
            Database.UpdateCustomerData(CustIDTBox.Text, FNTBox.Text, LNTBox.Text, PhTBox.Text, AdTBox.Text);
            LoadCustomerData_Click(null, null);
        }

        private void DltCustBtn_Click(object sender, EventArgs e)
        {
            Database.DeleteCustomerData(CustIDTBox.Text);
            LoadCustomerData_Click(null, null);
        }

        private void lblCopies_Click(object sender, EventArgs e)
        {

        }

        private void genre_TextChanged(object sender, EventArgs e)
        {

        }

        private void IssueMovieBtn_Click(object sender, EventArgs e)
        {
            Database.IssueMovie(MovieID.Text, CustIDTBox.Text);
            LoadRentedMoviesData_Click(null, null);
        }

        private void ReturnMovieBtn_Click(object sender, EventArgs e)
        {
            Database.ReturnMovie(RMID);
            LoadRentedMoviesData_Click(null, null);
        }

        private void AddMovie_Click(object sender, EventArgs e)
        {
            Database.AddMovieData(rating.Text,Title.Text,genre.Text,Year.Text,cost.Text,copies.Text,plot.Text);
            LoadMoviesData_Click(null, null);
        }

        private void UpdateMovie_Click(object sender, EventArgs e)
        {
            Database.UpdateMovieData(MovieID.Text, Title.Text, rating.Text, Year.Text,   cost.Text, copies.Text, plot.Text, genre.Text);
            LoadMoviesData_Click(null, null);
        }

        private void DeleteMovie_Click(object sender, EventArgs e)
        {
            Database.DeleteMovieData(MovieID.Text);
            LoadMoviesData_Click(null, null);
        }
    }
}
