using System.Windows;
using System.Windows.Controls;

namespace WpfDependencyProperties.UserControls
{
    
    public partial class DPControl : UserControl
    {
        public DPControl()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty SetTextProperty = DependencyProperty.Register("SetText", typeof(string),
                                                                    typeof(DPControl), new PropertyMetadata(""));

        public string SetText
        {
            get { return (string)GetValue(SetTextProperty); }
            set { SetValue(SetTextProperty, value); }
        }

        private static void OnSetTextChanged(DependencyObject d,
            DependencyPropertyChangedEventArgs e)
        {
            DPControl dpcontrol1 = d as DPControl;
            dpcontrol1.OnSetTextChanged(e);
        }

        private void OnSetTextChanged(DependencyPropertyChangedEventArgs e)
        {
            txtBlock1.Text = e.NewValue.ToString();
        }
    }
}
