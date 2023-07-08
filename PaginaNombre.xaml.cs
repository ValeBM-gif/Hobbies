namespace TDMPW_412_2P_PR02;

public partial class PaginaNombre : ContentPage
{
	public PaginaNombre()
	{
		InitializeComponent();
	}

    void ckb1_CheckedChanged(System.Object sender, Microsoft.Maui.Controls.CheckedChangedEventArgs e)
    {
        if (ckb1.IsChecked)
        {
            sld1.IsEnabled = true;
        }
        else
        {
            sld1.Value = 0;
            sld1.IsEnabled = false;
        }
        
    }

    void ckb2_CheckedChanged(System.Object sender, Microsoft.Maui.Controls.CheckedChangedEventArgs e)
    {
        if (ckb2.IsChecked)
        {
            sld2.IsEnabled = true;
        }
        else
        {
            sld2.Value = 0;
            sld2.IsEnabled = false;
        }
    }

    void ckb3_CheckedChanged(System.Object sender, Microsoft.Maui.Controls.CheckedChangedEventArgs e)
    {
        if (ckb3.IsChecked)
        {
            sld3.IsEnabled = true;
        }
        else
        {
            sld3.Value = 0;
            sld3.IsEnabled = false;
        }
    }

    void sld1_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
        lbl1.Text = Math.Round(sld1.Value,0).ToString();
    }

    void sld2_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
        lbl2.Text = Math.Round(sld2.Value,0).ToString();
    }

    void sld3_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
        lbl3.Text = Math.Round(sld3.Value,0).ToString();
    }

    void txtNombre_TextChanged(System.Object sender, Microsoft.Maui.Controls.TextChangedEventArgs e)
    {
        lblNombre.Text = txtNombre.Text;
    }
}
