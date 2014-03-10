using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MVCSharp.Examples.TasksInteraction.ApplicationLogic;
using MVCSharp.Examples.TasksInteraction.Model;
using MVCSharp.Mobile;
using MVCSharp.Mobile.Configuration;

namespace MVCSharp.Examples.TasksInteraction.Presentation
{
    [MobileformsView(typeof(MainTask), MainTask.Employees)]
    public partial class EmployeesView : MobileFormView, IEmployeesView
    {
        private List<Employee> m_Employees;

        public EmployeesView()
        {
            InitializeComponent();
        }

        public void SetEmployeesList(List<Employee> employees)
        {
            m_Employees = employees;
            employeesDataGrid.DataSource = m_Employees;
        }

        public Employee CurrentEmployee
        {
            get
            {
                if (employeesDataGrid.CurrentRowIndex < m_Employees.Count)
                {
                    return m_Employees[employeesDataGrid.CurrentRowIndex];
                }
                return null;
            }
            set
            {
                if(m_Employees.Contains(value))
                {
                    employeesDataGrid.Select(m_Employees.IndexOf(value));
                }
            }
        }

        private void AwardBonusMenuItem_Click(object sender, EventArgs e)
        {
            (Controller as EmployeesController).AwardBounus();
        }
    }
}