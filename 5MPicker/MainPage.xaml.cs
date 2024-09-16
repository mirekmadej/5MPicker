namespace _5MPicker
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void onPickerItemChanged(object sender, EventArgs e)
        {
            int cena = 0;
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            if (selectedIndex != 1)
            {
                lblNapoj.Text = picker.ItemsSource[selectedIndex].ToString();
            }
            switch(selectedIndex)
            {
                case 0:
                    cena = 10; break;
                case 1:
                    cena = 8; break;
                case 2:
                    cena = 6; break;
                case 3:
                    cena = 5; break;
            }
            lblNapoj.Text += $" cena: {cena}";
        }

    }

}
