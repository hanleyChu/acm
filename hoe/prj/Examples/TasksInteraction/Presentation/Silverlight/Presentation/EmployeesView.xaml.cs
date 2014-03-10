using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using MVCSharp.Silverlight;
using MVCSharp.Core.Configuration.Views;
using MVCSharp.Examples.TasksInteraction.ApplicationLogic;
using MVCSharp.Examples.TasksInteraction.Model;

namespace MVCSharp.Examples.TasksInteraction.Presentation.Silverlight
{
    [View(typeof(MainTask), MainTask.Employees)]
    public partial class EmployeesView : UserControlView, IEmployeesView
    {
        public EmployeesView()
        {
            InitializeComponent();
        }

        private void AwardBonusButton_Click(object sender, RoutedEventArgs e)
        {
            (Controller as EmployeesController).AwardBounus();
        }

        public Employee CurrentEmployee
        {
            get { return EmployeesGrid.SelectedItem as Employee; }
            set { EmployeesGrid.SelectedItem = value; }
        }

        public void SetEmployeesList(List<Employee> employees)
        {
            EmployeesGrid.ItemsSource = employees;
        }

        public override void Activate(bool activate)
        {
            if (activate) UpdateEmployeesGrid();
        }

        private void UpdateEmployeesGrid()
        {
            object selItm = EmployeesGrid.SelectedItem;
            IEnumerable employees = EmployeesGrid.ItemsSource;
            EmployeesGrid.ItemsSource = null;
            EmployeesGrid.ItemsSource = employees;
            EmployeesGrid.SelectedItem = selItm;
        }
    }
}
