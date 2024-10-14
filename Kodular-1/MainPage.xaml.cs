namespace Kodular_1
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {



            try {

                Double etanol = Convert.ToDouble(txt_etanol.Text);
                Double gasolina = Convert.ToDouble(txt_gasolina.Text);

                String msg = "";

                if (etanol <= (gasolina * 0.7))
                {

                    msg = "O Etanol esta compensando.";
                }

                else
                {
                    msg = "A Gasolina esta compensando.";
                }

                DisplayAlert("Calculado", msg, "Ok");

            } catch (Exception ex)
            {

                DisplayAlert("Ops", ex.Message, "Fechar");
            }



        } // Fecha método
    } // Fecha Class

} // Fecha nameSpace
