using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pola-Database
{
       public partial class Employee : Form
{
    private Functions con;
    public Employee()
    {
        InitializeComponent();
        con = new Functions();
        ShowEmployess();
        GetDepartment();


    }
    private void ShowEmployess()
    {
        string Query = "Select * from Employee";
        EmpList.DataSource = con.GetData(Query);


    }
    private void GetDepartment()
    {
        string Query = "Select * from Department";
        CbDeptIdEmp.DisplayMember = con.GetData(Query).Columns["DeotName"].ToString();
        CbDeptIdEmp.ValueMember = con.GetData(Query).Columns["DeptId"].ToString();
        CbDeptIdEmp.DataSource = con.GetData(Query);

    }
    private void Employee_Load(object sender, EventArgs e)
    {
        Login log = new Login();
        log.Show();
        this.Hide();
    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {

    }
    int Key = 0;
    private void EmpList_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        EmpName.Text = EmpList.SelectedRows[0].Cells[1].Value.ToString();





    }