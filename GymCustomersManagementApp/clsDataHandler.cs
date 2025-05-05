using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Dynamic;
using System.Net;
using System.Windows.Forms;

namespace GymCustomersManagementApp
{
    internal class clsDataHandler
    {
        public DataSet DS;
        public OleDbDataAdapter customersDA;
        public OleDbDataAdapter paymentsDA;
        public OleDbDataAdapter activitiesDA;

        public clsDataHandler()
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Customers.mdb";
            connection.Open();

            DS = new DataSet();

            OleDbCommand customersCmd = new OleDbCommand();

            customersCmd.CommandType = CommandType.TableDirect;
            customersCmd.CommandText = "Customers";
            customersCmd.Connection = connection;

            customersDA = new OleDbDataAdapter();
            customersDA.SelectCommand = customersCmd;
            customersDA.Fill(DS, "Customers");

            OleDbCommand paymentsCmd = new OleDbCommand();

            paymentsCmd.CommandType = CommandType.TableDirect;
            paymentsCmd.CommandText = "Payments";
            paymentsCmd.Connection = connection;

            paymentsDA = new OleDbDataAdapter();
            paymentsDA.SelectCommand = paymentsCmd;
            paymentsDA.Fill(DS, "Payments");

            OleDbCommand activitiesCmd = new OleDbCommand();

            activitiesCmd.CommandType = CommandType.TableDirect;
            activitiesCmd.CommandText = "Classes";
            activitiesCmd.Connection = connection;

            activitiesDA = new OleDbDataAdapter();
            activitiesDA.SelectCommand = activitiesCmd;
            activitiesDA.Fill(DS, "Classes");

            //PrimaryKeySetUp("Customers");
            //PrimaryKeySetUp("Payments");
            //PrimaryKeySetUp("Activities");

            OleDbCommandBuilder customersCb = new OleDbCommandBuilder(customersDA);
            OleDbCommandBuilder paymentsCb = new OleDbCommandBuilder(paymentsDA);
            OleDbCommandBuilder activitiesCb = new OleDbCommandBuilder(activitiesDA);

            connection.Close();
        }

        public void PrimaryKeySetUp(string tableName) 
        {
            DataColumn[] DC = new DataColumn[1];
            DC[0] = DS.Tables[tableName].Columns["Id"];
            DS.Tables[tableName].PrimaryKey = DC;
        }

        public void CreateCustomer(
            string DNI, 
            string lastName, 
            string firstName, 
            string email, 
            int phNumber, 
            DateTime DOB,
            string membership
            )
        {
            DataRow newRow = DS.Tables["Customers"].NewRow();
            newRow["DNI"] = DNI;
            newRow["Apellido"] = lastName;
            newRow["Nombre"] = firstName;
            newRow["Correo"] = email;
            newRow["Telefono"] = phNumber;
            newRow["FechaNacimiento"] = DOB;
            newRow["Suscripcion"] = membership;

            DS.Tables["Customers"].Rows.Add(newRow);
            customersDA.Update(DS, "Customers");
        }

        public void UpdateCustomer(string DNI, string field, string newData)
        {
            for (int i = 0; i < DS.Tables["Customers"].Rows.Count; i++)
            {
                DataRow row = DS.Tables["Customers"].Rows[i];

                if (row["DNI"].ToString() == DNI.ToString())
                {
                    row.BeginEdit();
                    if (field == "Fecha de Nacimiento")
                    {
                        DateTime date = DateTime.Parse(newData);
                        row[field] = date;
                    }
                    else
                    {
                        row[field] = newData;
                    }
                    row.EndEdit();
                    break;
                }
            }
            customersDA.Update(DS, "Customers");
        }

        public void DeleteCustomer (string DNI)
        {
            for (int i = 0; i < DS.Tables["Customers"].Rows.Count; i++)
            {
                DataRow row = DS.Tables["Customers"].Rows[i];
                if (row["DNI"].ToString() == DNI.ToString())
                {
                    row.Delete();
                    break;
                }
            }
            customersDA.Update(DS, "Customers");
        }

        public void createPayment(string DNI, double amount, string method)
        {
            DataRow newRow = DS.Tables["Payments"].NewRow();
            newRow["Cliente"] = DNI;
            newRow["Monto"] = amount;
            newRow["Método"] = method;
            newRow["Fecha"] = DateTime.Now;

            DS.Tables["Payments"].Rows.Add(newRow);
            paymentsDA.Update(DS, "Payments");
        }

        public void createActivity(string activity, string space, string hour, DateTime date, string provider)
        {
            DataRow newRow = DS.Tables["Classes"].NewRow();
            newRow["Actividad"] = activity;
            newRow["Espacio"] = space;
            newRow["Hora"] = hour;
            newRow["DictadoPor"] = provider;
            newRow["Fecha"] = date.Date;

            DS.Tables["Classes"].Rows.Add(newRow);
            activitiesDA.Update(DS, "Classes");
        }

        public void AttendanceControl(string userNumber, string activity, string date, string time)
        {
            try
            {
                foreach (DataRow cusRow in DS.Tables["Customers"].Rows)
                {
                    foreach (DataRow claRow in DS.Tables["Classes"].Rows)
                    {
                        if (cusRow["DNI"].ToString() == userNumber &&
                            claRow["Actividad"].ToString() == activity &&
                            claRow["Fecha"].ToString() == date &&
                            claRow["Hora"].ToString() == time)
                        {
                            claRow["Asistentes"] += cusRow["Nombre"].ToString() + cusRow["Apellido"].ToString() + ", ";
                            break;
                        }
                    }
                    
                }
                activitiesDA.Update(DS, "Classes");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error registrating attendance: " + ex.Message, "Error Information: Class Attendance", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
