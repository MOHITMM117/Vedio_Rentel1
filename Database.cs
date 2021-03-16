using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Vedio_Rentel
{
    public class DB // database connection
    {
        string ConnectionString = @"Data Source=LAPTOP-52CB3J4K\SQLEXPRESS;Initial Catalog=VBMOVIESFULLDATA.MDF;Integrated Security=True;";
        SqlConnection Connection;
        public DB()
        {
            Connection = new SqlConnection(ConnectionString);
        }

        public string DBCheck()
        {
            return Connection.Database;
        }

        public DataTable LoadCustomersData() // load customer details in the data grid view 
        {
            Connection.Open();

            DataTable CustomersTable = new DataTable();

            CustomersTable.Clear();

            CustomersTable.Columns.Add("CustID");
            CustomersTable.Columns.Add("FirstName");
            CustomersTable.Columns.Add("LastName");
            CustomersTable.Columns.Add("Address");
            CustomersTable.Columns.Add("Phone");

            string query = "SELECT * FROM Customer";

            SqlCommand command = new SqlCommand(query, Connection); // sql connection 
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                CustomersTable.Rows.Add(
                    reader["CustID"],
                    reader["FirstName"],
                    reader["LastName"],
                    reader["Address"],
                    reader["Phone"]
                    );
            }

            Connection.Close();

            return CustomersTable;
        }

        public DataTable LoadMoviesData() // load movies data in the data grid veiw in the movie section 
        {
            Connection.Open();

            DataTable MoviesTable = new DataTable();

            MoviesTable.Clear();

            MoviesTable.Columns.Add("MovieID");
            MoviesTable.Columns.Add("Rating");
            MoviesTable.Columns.Add("Title");
            MoviesTable.Columns.Add("Year");
            MoviesTable.Columns.Add("Rental_Cost");
            MoviesTable.Columns.Add("Copies");
            MoviesTable.Columns.Add("Plot");
            MoviesTable.Columns.Add("Genre");

            string query = "SELECT * FROM Movies";

            SqlCommand command = new SqlCommand(query, Connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                MoviesTable.Rows.Add(
                    reader["MovieID"],
                    reader["Rating"],
                    reader["Title"],
                    reader["Year"],
                    reader["Rental_Cost"],
                    reader["Copies"],
                    reader["Plot"],
                    reader["Genre"]
                    );
            }

            Connection.Close();

            return MoviesTable;
        }

        public void AddCustomer(string fname, string lname, string phone, string address) // insert querydfor the customer data 
        {
            Connection.Open();
             // insert query 
            string query = "INSERT INTO Customer (FirstName, LastName, Phone, Address) " +
                    "VALUES(@FirstName, @LastName, @Phone, @Address);";

            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = fname;
                command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = lname;
                command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = phone;
                command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = address;

                command.ExecuteNonQuery();
            }

            Connection.Close();
        }

        public void UpdateCustomer(string id, string fname, string lname, string phone, string address) // update the data is the customer datagrid vie bt the click button update 
        {
            Connection.Open();

            string query = "UPDATE Customer SET FirstName = @FirstName, LastName = @LastName, Phone = @Phone, Address = @Address WHERE CustID = " + id + "; ";

            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = fname;
                command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = lname;
                command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = phone;
                command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = address;

                command.ExecuteNonQuery();
            }

            Connection.Close();
        }

        public void DeleteCustomer(string id)  // delete button for the customer data
        {
            Connection.Open();

            string query = "DELETE Customer WHERE CustID = " + id;

            SqlCommand command = new SqlCommand(query, Connection);

            command.ExecuteNonQuery();

            Connection.Close();
        }        public DataTable LoadRentedMoviesData() // load novie data is the dat grid view 
        {
            Connection.Open();

            DataTable CustomersTable = new DataTable();

            CustomersTable.Clear();

            CustomersTable.Columns.Add("RMID");
            CustomersTable.Columns.Add("MovieIDFK");
            CustomersTable.Columns.Add("CustIDFK");
            CustomersTable.Columns.Add("DateRented");
            CustomersTable.Columns.Add("DateReturned");

            string query = "SELECT * FROM RentedMovies";

            SqlCommand command = new SqlCommand(query, Connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                CustomersTable.Rows.Add(
                    reader["RMID"],
                    reader["MovieIDFK"],
                    reader["CustIDFK"],
                    reader["DateRented"],
                    reader["DateReturned"]
                    );
            }

            Connection.Close();

            return CustomersTable;
        }
        public ConnectionState DBStatus()
        {
            return Connection.State;
        }
        public string PopularCustomer()  // function which are tell you for the most pupilar customer in the list
        {
            Connection.Open();

            string query = "SELECT CustIDFK, COUNT(*) AS Rep FROM RentedMovies GROUP BY CustIDFK ORDER BY Rep DESC";

            SqlCommand command = new SqlCommand(query, Connection);

            var result = command.ExecuteScalar().ToString();

            Connection.Close();

            Connection.Open();

            Console.WriteLine(result);

            query = "SELECT FirstName, LastName FROM Customer WHERE CustID = " + result;

            command = new SqlCommand(query, Connection);

            SqlDataReader reader = command.ExecuteReader();

            string output = "";

            while (reader.Read())
            {
                output = reader["FirstName"].ToString();
                output += " ";
                output += reader["LastName"].ToString();
            }

            Connection.Close();

            return output;
        }


        public void AddCustomerData(string fname, string lname, string phone, string address) // add  new customer  innsert query for adding new data for customer
        {
            Connection.Open();

            string query = "INSERT INTO Customer (FirstName, LastName, Phone, Address) " +
                    "VALUES(@FirstName, @LastName, @Phone, @Address);";

            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = fname;
                command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = lname;
                command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = phone;
                command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = address;

                command.ExecuteNonQuery();
            }

            Connection.Close();
        }

        public void UpdateCustomerData(string id, string fname, string lname, string phone, string address)
        {
            Connection.Open();

            string query = "UPDATE Customer SET FirstName = @FirstName, LastName = @LastName, Phone = @Phone, Address = @Address WHERE CustID = " + id + " ";

            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = fname;
                command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = lname;
                command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = phone;
                command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = address;

                command.ExecuteNonQuery();
            }

            Connection.Close();
        }

        public void DeleteCustomerData(string id)
        {
            Connection.Open();

            string query = "DELETE Customer WHERE CustID = " + id;

            SqlCommand command = new SqlCommand(query, Connection);

            command.ExecuteNonQuery();

            Connection.Close();
        }
        public void IssueMovie(string movieIDFK, string custIDFK) //  fisrt selet customer , movie and then issue movie to customer 
        {
            Connection.Open();

            string query = "INSERT INTO RentedMovies (MovieIDFK, CustIDFK, DateRented)" +
                    "VALUES(@MovieIDFK, @CustIDFK, @DateRented)";

            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                command.Parameters.AddWithValue("@MovieIDFK", movieIDFK);
                command.Parameters.AddWithValue("@CustIDFK", custIDFK);
                command.Parameters.AddWithValue("@DateRented", DateTime.Now);

                command.ExecuteNonQuery();
            }

            Connection.Close();
        }

        public void ReturnMovie(string rmID)  // retun movies by customer by click return button 
        {
            Connection.Open();

            string query = "UPDATE RentedMovies set DateReturned=@DateReturned Where RMID = @RMID"; // data updated when the movie retun 

            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                command.Parameters.Add("@RMID", SqlDbType.NVarChar).Value = rmID;
                command.Parameters.Add("@DateReturned", SqlDbType.DateTime).Value = DateTime.Now;

                command.ExecuteNonQuery();
            }

            Connection.Close();
        }

        // add new movies in the data list 
        public void AddMovieData(string Title, string Rating, string Year , string Rental_Cost , string Copies , string Plot , string Genre)
        {
            Connection.Open();

            string query = "INSERT INTO Movies (Title, Rating,Year,Rental_Cost,Copies,Plot,Genre) " +
                    "VALUES(@Title, @Rating, @Rental_Cost,@Copies,@Plot,@Genre, @Year)";

            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                command.Parameters.Add("@Title", SqlDbType.NVarChar).Value = Title;
                command.Parameters.Add("@Rating", SqlDbType.NVarChar).Value = Rating;
                command.Parameters.Add("@Year", SqlDbType.NVarChar).Value = Year;
                command.Parameters.Add("@Rental_Cost", SqlDbType.NVarChar).Value = Rental_Cost;
                command.Parameters.Add("@Copies", SqlDbType.NVarChar).Value = Copies;
                command.Parameters.Add("@Plot", SqlDbType.NVarChar).Value = Plot;
                command.Parameters.Add("@Genre", SqlDbType.NVarChar).Value = Genre;
              

                command.ExecuteNonQuery();
            }

            Connection.Close();
        } 
         // update the movies in database 
        public void UpdateMovieData(string id, string Title, string Rating, string Year, string Rental_Cost, string Copies, string Plot,string Genre)
        {
            Connection.Open();

            string query = "UPDATE Movies SET Title = @Title, Year = @Year, Rating = @Rating, Rental_Cost = @Rental_Cost ,Copies=@Copies,Plot=@Plot,Genre=@Genre WHERE MovieID = " + id + "; ";

            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                command.Parameters.Add("@Title", SqlDbType.NVarChar).Value = Title;
                command.Parameters.Add("@Rating", SqlDbType.NVarChar).Value = Rating;
                command.Parameters.Add("@Year", SqlDbType.NVarChar).Value = Year;
                command.Parameters.Add("@Rental_Cost", SqlDbType.NVarChar).Value = Rental_Cost;
                command.Parameters.Add("@Copies", SqlDbType.NVarChar).Value = Copies;
                command.Parameters.Add("@Plot", SqlDbType.NVarChar).Value = Plot;
                command.Parameters.Add("@Genre", SqlDbType.NVarChar).Value = Genre;

                command.ExecuteNonQuery();
            }

            Connection.Close();
        }

        public void DeleteMovieData(string id) // delete movies from the data list 
        {
            Connection.Open();

            string query = "DELETE Movies WHERE MovieID = " + id;

            SqlCommand command = new SqlCommand(query, Connection);

            command.ExecuteNonQuery();

            Connection.Close();
        }

    }
}