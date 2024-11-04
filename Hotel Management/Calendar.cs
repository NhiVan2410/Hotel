using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Input;

namespace Hotel_Management
{
    public class Calendarr 
    {
        public static void Action ()
        {
            string connectionString = @"Data Source=DAROND\SQLEXPRESS;Initial Catalog=HotelData;Integrated Security=True"; // Cần thay thế bằng chuỗi kết nối của bạn

            List<Employee> employees = GetEmployees(connectionString);
  
            var scheduler = new Scheduler(employees);
            var schedule = scheduler.GenerateSchedule();
            
            SaveSchedule(schedule, connectionString);

        }
        static List<Employee> GetEmployees(string connectionString)
        {
            List<Employee> employees = new List<Employee>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT [ID_Employee], [Name], [Role] FROM [HotelData].[dbo].[Employee]";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            employees.Add(new Employee
                            {
                                Id = reader["ID_Employee"].ToString(),
                                Name = reader["Name"].ToString(),
                                Role = reader["Role"].ToString()
                            });
                        }
                    }
                }
            }

            return employees;
        }

        static void CreateShifts(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO [HotelData].[dbo].[Shift] ([ID_Shift], [Timein], [Timeout]) VALUES (@ShiftId, @Timein, @Timeout)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Ca làm việc 1
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@ShiftId", 1);
                    command.Parameters.AddWithValue("@Timein", new TimeSpan(7, 0, 0)); // 07:00 AM
                    command.Parameters.AddWithValue("@Timeout", new TimeSpan(19, 0, 0)); // 07:00 PM
                    command.ExecuteNonQuery();

                    // Ca làm việc 2
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@ShiftId", 2);
                    command.Parameters.AddWithValue("@Timein", new TimeSpan(20, 0, 0)); // 08:00 PM
                    command.Parameters.AddWithValue("@Timeout", new TimeSpan(6, 0, 0)); // 06:00 AM
                    command.ExecuteNonQuery();
                }
            }
        }

        static void SaveSchedule(List<Shift> schedule, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                foreach (var shift in schedule)
                {
                    foreach (var receiptor in shift.Receiptor)
                    {
                        SaveCalendarEntry(connection, shift.ShiftId, receiptor.Id, shift.Day);
                    }

                    foreach (var labor in shift.Labor)
                    {
                        SaveCalendarEntry(connection, shift.ShiftId, labor.Id, shift.Day);
                    }
                }
            }
        }

        static void SaveCalendarEntry(SqlConnection connection, string shiftId, string employeeId, DateTime day)
        {
            string idCalendar = Guid.NewGuid().ToString();
            string roleQuery = "SELECT [Role] FROM [HotelData].[dbo].[Employee] WHERE [ID_Employee] = @EmployeeId";
            string query = "INSERT INTO [HotelData].[dbo].[Calendar] ([ID_Calendar], [ID_Shift], [ID_Person], [Day]) VALUES (@CalendarID, @ShiftId, @EmployeeId, @Day)";
            string salaryQuery = "INSERT INTO [HotelData].[dbo].[Salary] ([ID_Salary], [ID_Employee], [Day], [Amount]) VALUES (@SalaryId, @EmployeeId, @Day, @Amount)";
            
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CalendarID", idCalendar);
                command.Parameters.AddWithValue("@ShiftId", shiftId);
                command.Parameters.AddWithValue("@EmployeeId", employeeId);
                command.Parameters.AddWithValue("@Day", day);


                command.ExecuteNonQuery();
            }

            string role = "";
            using (SqlCommand roleCommand = new SqlCommand(roleQuery, connection))
            {
                roleCommand.Parameters.AddWithValue("@EmployeeId", employeeId);
                role = (string)roleCommand.ExecuteScalar();
            }

            using (SqlCommand salaryCommand = new SqlCommand(salaryQuery, connection))
            {
                salaryCommand.Parameters.AddWithValue("@SalaryId", idCalendar);
                salaryCommand.Parameters.AddWithValue("@EmployeeId", employeeId);
                salaryCommand.Parameters.AddWithValue("@Day", day);

                // Tính toán lương dựa trên loại nhân viên và ca làm việc
                decimal amount = 0;
                if (role == "Receiptor")
                {
                    amount = (shiftId == "1") ? 60000 * 12 : 60000 * 10;
                }
                else if (role == "Labor")
                {
                    amount = (shiftId == "1") ? 40000 * 12 : 40000 * 10;
                }

                salaryCommand.Parameters.AddWithValue("@Amount", amount);
                salaryCommand.ExecuteNonQuery();
            }
        }


    }

    class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; } // "Receiptor" or "Labor"
        public int Shifts { get; set; } = 0;
    }

    class Shift
    {
        public string ShiftId { get; set; }
        public DateTime Day { get; set; }
        public List<Employee> Receiptor { get; set; } = new List<Employee>();
        public List<Employee> Labor { get; set; } = new List<Employee>();
    }

    class Scheduler
    {
        private List<Employee> employees;
        private Random random = new Random();

        public Scheduler(List<Employee> employees)
        {
            this.employees = employees;
        }

        public List<Shift> GenerateSchedule()
        {
            var schedule = new List<Shift>();
            DateTime startDate = DateTime.Today; // Ngày bắt đầu (ngày hiện tại)
            while (startDate.DayOfWeek != DayOfWeek.Monday)
            {
                startDate = startDate.AddDays(-1);
            }

            for (int dayOffset = 0; dayOffset < 7; dayOffset++)
            {
                DateTime currentDay = startDate.AddDays(dayOffset);
                int receiptorCount = 2;
                int laborCount = (currentDay.DayOfWeek >= DayOfWeek.Monday && currentDay.DayOfWeek <= DayOfWeek.Friday) ? 4 : 3;

                // Ca làm việc ban ngày
                schedule.Add(GenerateShift("1", currentDay, receiptorCount, laborCount));

                // Ca làm việc ban đêm
                schedule.Add(GenerateShift("2", currentDay, receiptorCount, laborCount));
            }

            return schedule;
        }

        private Shift GenerateShift(string shiftId, DateTime day, int receiptorCount, int laborCount)
        {
            var shift = new Shift { ShiftId = shiftId, Day = day };

            var availableReceiptor = employees.Where(e => e.Role == "Receiptor").OrderBy(e => e.Shifts).ThenBy(e => random.Next()).Take(receiptorCount).ToList();
            foreach (var receiptor in availableReceiptor)
            {
                receiptor.Shifts++;
                shift.Receiptor.Add(receiptor);
            }

            var availableLabor = employees.Where(e => e.Role == "Labor").OrderBy(e => e.Shifts).ThenBy(e => random.Next()).Take(laborCount).ToList();
            foreach (var labor in availableLabor)
            {
                labor.Shifts++;
                shift.Labor.Add(labor);
            }

            return shift;
        }
    }

}

    








