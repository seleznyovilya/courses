using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace courses
{
    class Users
    {
        public int id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
    }


    class Teacher
    {
        public int id { get; set; }
        public string fio { get; set; }
        public string bithday { get; set; }
        public string gender { get; set; }
        public string education { get; set; }
        public string category { get; set; }

    }
    class Course
    {
        public int id { get; set; }
        public string name { set; get; }
        public string type { set; get; }
        public int count { get; set; }
        public int price { get; set; }
        public int price_VAT { get; set; }

    }
    class Price
    {
        public int id { get; set; }
        public string date { get; set; }
        public int price { get; set; }
        public int courseid { get; set; }

    }
    class Consolidation
    {
        public int id { set; get; }
        public int id_teacher { get; set; }
        public int id_course { get; set; }
        public string start { get; set; }
        public string end { get; set; }

    }
    class Applications
    {
        public int id { set; get; }
        public string name_of_organization { get; set; }
        public string address_of_organization { set; get; }
        public string numberphone_organization { get; set; }
        public string email { get; set; }
        public int amount_stuff { get; set; }
        public string name_surname_lastname_stuff { get; set; }
        public string stuff_position { get; set; }
        public string term_of_course { get; set; }
        public int idcourse { get; set; }

    }
    class Company
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string tel { get; set; }
        public string email { get; set; }
    }

    class Database
    {
        private readonly MySqlConnection _connection;


        public Database()
        {
            var builder = new MySqlConnectionStringBuilder();

            builder.Server = "127.0.0.1";
            builder.Database = "courses_db_new";
            builder.UserID = "user1";
            builder.Password = "user1";
            builder.SslMode = MySqlSslMode.None;
            _connection = new MySqlConnection(builder.ConnectionString);

        }
        private bool OpenConnection()
        {

            _connection.Open();
            return true;

        }
        private bool CloseConnection()
        {
            _connection.Close();
            return true;
        }

        public bool AddUser(Users user)
        {
            string AddUser = "Insert Into users(login,password) Values (@login, @password)";
            int rows = 0;
            if (OpenConnection())
            {
                using (MySqlCommand com = new MySqlCommand(AddUser, _connection))
                {


                    com.Parameters.AddWithValue("@login", user.login);
                    com.Parameters.AddWithValue("@password", user.password);
                    rows = com.ExecuteNonQuery();
                }
                _connection.Close();
            }
            return (rows > 0);
        }
        public bool UpdateUser(Users user)
        {
            string AddUser = "Update users set login=@login, password=@password where idusers=@idusers";
            int rows = 0;
            if (OpenConnection())
            {
                using (MySqlCommand com = new MySqlCommand(AddUser, _connection))
                {
                    com.Parameters.AddWithValue("@login", user.login);
                    com.Parameters.AddWithValue("@password", user.password);
                    com.Parameters.AddWithValue("@idusers", user.id);
                    rows = com.ExecuteNonQuery();
                }
                _connection.Close();
            }
            return (rows > 0);
        }
        public bool DeleteUser(Users user)
        {
            string DelUser = "Delete from users where idusers=@idusers";
            int rows = 0;
            if (OpenConnection())
            {
                using (MySqlCommand com = new MySqlCommand(DelUser, _connection))
                {
                    com.Parameters.AddWithValue("@idusers", user.id);
                    rows = com.ExecuteNonQuery();
                }
                _connection.Close();
            }
            return (rows > 0);
        }

        public List<Users> GetAllUsers()
        {
            string query = "SELECT * from users";
            var list = new List<Users>();

            if (OpenConnection())
            {
                using (var cmd = new MySqlCommand(query,_connection))
                using (var dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        var user = new Users();
                        user.id = dataReader.GetInt32(0);
                        user.login = dataReader.GetString(1);
                        user.password = dataReader.GetString(2);

                        list.Add(user);
                    }

                }
                _connection.Close();
            }
            return list;
        }

        public bool AddTeacher(Teacher teacher)
        {
            string AddTeacher = "Insert Into teachers(surname_name_lastname,bithday,category,gender,education) Values (@surname_name_lastname, @bithday, @category, @gender, @education)";
            int rows = 0;
            if (OpenConnection())
            {
                using (MySqlCommand com = new MySqlCommand(AddTeacher, _connection))
                {


                    com.Parameters.AddWithValue("@surname_name_lastname", teacher.fio);
                    com.Parameters.AddWithValue("@bithday", teacher.bithday);
                    com.Parameters.AddWithValue("@gender", teacher.gender);
                    com.Parameters.AddWithValue("@category", teacher.category);
                    com.Parameters.AddWithValue("@education", teacher.education);
                    rows = com.ExecuteNonQuery();
                }
                _connection.Close();
            }
            return (rows > 0);
        }

        public bool DeleteTeacher(Teacher teacher)
        {
            string DelTeacher = "Delete from teachers where idteacher=@idteacher";
            int rows = 0;
            if (OpenConnection())
            {
                using (MySqlCommand com = new MySqlCommand(DelTeacher, _connection))
                {
                    com.Parameters.AddWithValue("@idteacher", teacher.id);
                    rows = com.ExecuteNonQuery();
                }
                _connection.Close();
            }
            return (rows > 0);
        }


        public List<Teacher> GetAllTeacher()
        {
            string query = "SELECT * from teachers";
            var list = new List<Teacher>();

            if (OpenConnection())
            {
                using (var cmd = new MySqlCommand(query, _connection))
                using (var dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        var teacher = new Teacher
                        {
                            id = dataReader.GetInt32(0),
                            fio = dataReader.GetString(1),
                            bithday = Convert.ToString(dataReader.GetDateTime(2)),
                            gender = dataReader.GetString(4),
                            education = dataReader.GetString(5),
                            category = dataReader.GetString(3)
                        };


                        list.Add(teacher);
                    }
                }
                _connection.Close();
            }
            return list;
        }


        public List<Course> GetAllCourse()
        {
            string query = "SELECT * from cources";
            var list = new List<Course>();

            if (OpenConnection())
            {
                using (var cmd = new MySqlCommand(query, _connection))
                using (var dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        var course = new Course
                        {
                            id = dataReader.GetInt32(0),
                            name = dataReader.GetString(1),
                            type = dataReader.GetString(2),
                            count = dataReader.GetInt32(3),
                            price = dataReader.GetInt32(4),
                            price_VAT = dataReader.GetInt32(5)
                        };


                        list.Add(course);
                    }
                }
                _connection.Close();
            }
            return list;
        }
        public bool AddCourse(Course course)
        {
            string AddCourse = "Insert Into cources(name_of_course,type_of_cource,amount_day_of_cource) Values (@name_of_course, @type_of_cource, @amount_day_of_cource)";
            int rows = 0;
            if (OpenConnection())
            {
                using (MySqlCommand com = new MySqlCommand(AddCourse, _connection))
                {


                    com.Parameters.AddWithValue("@name_of_course", course.name);
                    com.Parameters.AddWithValue("@type_of_cource", course.type);
                    com.Parameters.AddWithValue("@amount_day_of_cource", course.count);

                    rows = com.ExecuteNonQuery();
                }
                _connection.Close();
            }
            return (rows > 0);
        }
        public bool UpdateCourse(Course course)
        {
            string UpdateCourse = "Update cources set name_of_course=@name_of_course, type_of_cource=@type_of_cource, amount_day_of_cource=@amount_day_of_cource, price=@price, price_including_VAT=@price_including_VAT  where cource_code=@cource_code";
            int rows = 0;
            if (OpenConnection())
            {
                using (MySqlCommand com = new MySqlCommand(UpdateCourse, _connection))
                {
                    com.Parameters.AddWithValue("@name_of_course", course.name);
                    com.Parameters.AddWithValue("@type_of_cource", course.type);
                    com.Parameters.AddWithValue("@amount_day_of_cource", course.count);
                    com.Parameters.AddWithValue("@price", course.price);
                    com.Parameters.AddWithValue("@price_including_VAT", course.price_VAT);
                    com.Parameters.AddWithValue("@cource_code", course.id);
                    rows = com.ExecuteNonQuery();
                }
                _connection.Close();
            }
            return (rows > 0);
        }
        public List<Price> GetAllPrice()
        {
            string query = "SELECT * from price";
            var list = new List<Price>();

            if (OpenConnection())
            {
                using (var cmd = new MySqlCommand(query, _connection))
                using (var dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        var price = new Price
                        {
                            id = dataReader.GetInt32(0),
                            date = Convert.ToString(dataReader.GetDateTime(1)),
                            price = dataReader.GetInt32(2),
                            courseid = dataReader.GetInt32(3),

                        };


                        list.Add(price);
                    }
                }
                _connection.Close();
            }
            return list;
        }
        public bool AddPrice(Price price)
        {
            string AddPrice = "Insert Into price(date_of_document,price,cources_cource_code) Values (@date_of_document, @price, @cources_cource_code)";
            int rows = 0;
            if (OpenConnection())
            {
                using (MySqlCommand com = new MySqlCommand(AddPrice, _connection))
                {


                    com.Parameters.AddWithValue("@date_of_document", price.date);
                    com.Parameters.AddWithValue("@price", price.price);
                    com.Parameters.AddWithValue("@cources_cource_code", price.courseid);

                    rows = com.ExecuteNonQuery();
                }
                _connection.Close();
            }
            return (rows > 0);
        }



        public List<Consolidation> GetAllConsolidation()
        {
            string query = "SELECT * from consolidation";
            var list = new List<Consolidation>();

            if (OpenConnection())
            {
                using (var cmd = new MySqlCommand(query, _connection))
                using (var dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        var cons = new Consolidation
                        {
                            id = dataReader.GetInt32(0),
                            id_teacher = dataReader.GetInt32(1),
                            id_course = dataReader.GetInt32(2),
                            start = Convert.ToString(dataReader.GetDateTime(3)),
                            end = Convert.ToString(dataReader.GetDateTime(4)),
                        };


                        list.Add(cons);
                    }
                }
            _connection.Close();
            }
            return list;
        }
        public bool AddConsolidation(Consolidation consolidation)
        {
            string AddConsolidation = "Insert Into consolidation(teachers_idteacher,cources_cource_code,start_cource,end_cource) Values (@teachers_idteacher, @cources_cource_code, @start_cource,@end_cource)";
            int rows = 0;
            if (OpenConnection())
            {
                using (MySqlCommand com = new MySqlCommand(AddConsolidation, _connection))
                {
                    com.Parameters.AddWithValue("@teachers_idteacher", consolidation.id_teacher);
                    com.Parameters.AddWithValue("@cources_cource_code", consolidation.id_course);
                    com.Parameters.AddWithValue("@start_cource", consolidation.start);
                    com.Parameters.AddWithValue("@end_cource", consolidation.end);

                    rows = com.ExecuteNonQuery();
                }
                _connection.Close();
            }
            return (rows > 0);
        }
        public List<Applications> GetAllApplication()
        {
            string query = "SELECT * from application";
            var list = new List<Applications>();

            if (OpenConnection())
            {
                using (var cmd = new MySqlCommand(query, _connection))
                using (var dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        var cons = new Applications
                        {
                            id = dataReader.GetInt32(0),
                            name_of_organization = dataReader.GetString(1),
                            address_of_organization = dataReader.GetString(2),
                            numberphone_organization = dataReader.GetString(3),
                            email = dataReader.GetString(4),
                            amount_stuff = dataReader.GetInt32(5),
                            name_surname_lastname_stuff = dataReader.GetString(6),
                            stuff_position = dataReader.GetString(7),
                            term_of_course = Convert.ToString(dataReader.GetDateTime(8)),
                            idcourse = dataReader.GetInt32(9),
                        };

                        list.Add(cons);
                    }
                }
                _connection.Close();
            }
            return list;
        }
        public bool AddApplication(Applications application)
        {
            string AddApplication = "Insert Into application(name_of_organizations,address_of_organizations,numberphone_organizations,email,amount_stuff,name_surname_lastname_stuff,stuff_position,term_of_course,cources_cource_code) Values (@name_of_organization, @address_of_organization, @numberphone_organization,@email,@amount_stuff,@name_surname_lastname_stuff,@stuff_position,@term_of_course,@cources_cource_code)";

            int rows = 0;
            if (OpenConnection())
            {
                using (MySqlCommand com = new MySqlCommand(AddApplication, _connection))
                {
                    com.Parameters.AddWithValue("@name_of_organization", application.name_of_organization);
                    com.Parameters.AddWithValue("@address_of_organization", application.address_of_organization);
                    com.Parameters.AddWithValue("@numberphone_organization", application.numberphone_organization);
                    com.Parameters.AddWithValue("@email", application.email);
                    com.Parameters.AddWithValue("@amount_stuff", application.amount_stuff);
                    com.Parameters.AddWithValue("@name_surname_lastname_stuff", application.name_surname_lastname_stuff);
                    com.Parameters.AddWithValue("@stuff_position", application.stuff_position);
                    com.Parameters.AddWithValue("@term_of_course", application.term_of_course);
                    com.Parameters.AddWithValue("@cources_cource_code", application.idcourse);


                    rows = com.ExecuteNonQuery();
                }
                _connection.Close();
            }
            return (rows > 0);
        }



    }

    
}
