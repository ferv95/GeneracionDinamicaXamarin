using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GeneracionDinamica
{
	public partial class MainPage : ContentPage
	{

		public MainPage()
		{
			InitializeComponent();

            this.btnGenerar.Clicked += BtnGenerar_Clicked;
		}

        private void BtnGenerar_Clicked(object sender, EventArgs e)
        {
            int numBotones = int.Parse(this.entryNumBotones.Text);
            this.layourContenedor.Children.Clear();
            for(int i = 1; i <= numBotones; i++)
            {
                Button btn = new Button();
                btn.Text = "Botón " + i;
                this.layourContenedor.Children.Add(btn);
            }
        }
    }
}
