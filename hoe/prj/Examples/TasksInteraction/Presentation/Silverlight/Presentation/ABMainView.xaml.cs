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
    [View(typeof(AwardBonusTask), AwardBonusTask.MainView)]
    public partial class ABMainView : UserControlView, IABMainView
    {
        public ABMainView()
        {
            InitializeComponent();
        }

        public int ContractsMade
        {
            get { return Convert.ToInt32(ContractsMadeEdit.Text); }
            set { ContractsMadeEdit.Text = value.ToString(); }
        }

        public int CustomersAttracted
        {
            get { return Convert.ToInt32(CustAttractedEdit.Text); }
            set { CustAttractedEdit.Text = value.ToString(); }
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            (Controller as ABMainController).DoAwardBonus();
        }

        private void AdvancedOptsBtn_Click(object sender, RoutedEventArgs e)
        {
            (Controller as ABMainController).ShowAdvancedOptions();
        }
    }
}
