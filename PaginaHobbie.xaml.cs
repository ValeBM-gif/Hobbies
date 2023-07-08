namespace TDMPW_412_2P_PR02;

public partial class PaginaHobbie : ContentPage
{
	public PaginaHobbie()
	{
		InitializeComponent();
	}

    void swt1_Toggled(System.Object sender, Microsoft.Maui.Controls.ToggledEventArgs e)
    {
		if (swt1.IsToggled==true)
		{
			sldStepper.IsEnabled = false;
			stp1.IsEnabled = true;
		}
		else
		{
            sldStepper.IsEnabled = true;
            stp1.IsEnabled = false;
        }
    }

    void stp1_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
		sldStepper.Value = stp1.Value;
        lblStepper.Text = Math.Round(sldStepper.Value, 0).ToString();
    }

    void sldStepper_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
        stp1.Value = sldStepper.Value;
        lblStepper.Text = Math.Round(sldStepper.Value,0).ToString();
    }

    void txtHobby_TextChanged(System.Object sender, Microsoft.Maui.Controls.TextChangedEventArgs e)
    {
        lblHobby.Text = txtHobby.Text;
    }
}
