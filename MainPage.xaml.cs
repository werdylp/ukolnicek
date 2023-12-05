namespace ukolnicek;

public partial class MainPage : ContentPage
{

	public List<ukol> Seznam { get; set; }
		
	public MainPage()
	{
		InitializeComponent();
		
		//vypis.ItemsSource = seznam;
		Seznam = new List<ukol>();
		vypis.BindingContext = this;
        
    }

	private void novy(object sender, EventArgs e)
	{
		ukol u = new ukol(nazev.Text, dat.Date, (byte)pru.SelectedIndex);
		Seznam.Add(u);

		vypis.BindingContext = null;
		vypis.BindingContext = this;
	}
}
