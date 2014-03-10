using System;
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

namespace MVCSharp.Examples.TasksInteraction.Presentation.Silverlight
{
    public partial class ABAdvancedOptionsView : UserControlView, IABAdvancedOptionsView
    {
        public ABAdvancedOptionsView()
        {
            InitializeComponent();
        }

        public override void Activate(bool activate)
        {
            if (!activate) Visibility = Visibility.Collapsed;
        }

        public bool IsWorkerOfTheMonth
        {
            get { return (bool)WorkerOfTheMonthCB.IsChecked; }
            set { WorkerOfTheMonthCB.IsChecked = value; }
        }

        public bool SpecialServices
        {
            get { return (bool)SpecialServicesCB.IsChecked; }
            set { SpecialServicesCB.IsChecked = value; }
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            (Controller as ABAdvancedOptionsController).DoEnterOptions();
        }
    }
}
