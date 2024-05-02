namespace pryLopezEtapa2
{
    public partial class Form1 : Form
    {
        private List<clsVehiculo> vehiculos;
        private int indiceActual = 0;
        public Form1()
        {
            InitializeComponent();
            vehiculos = new List<clsVehiculo>
            {
                new clsVehiculo("Auto", "Auto", Properties.Resources.auto),
                new clsVehiculo("Barco", "Barco", Properties.Resources.barco),
                new clsVehiculo("Avion", "Avion", Properties.Resources.avion)
            };
        }

        private void MostrarSiguienteVehiculo()
        {

            indiceActual = (indiceActual + 1) % vehiculos.Count;
            clsVehiculo vehiculo = vehiculos[indiceActual];


            pctImagen.Image = vehiculo.Imagen;
            pctImagen.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarSiguienteVehiculo();
        }
    }
}
