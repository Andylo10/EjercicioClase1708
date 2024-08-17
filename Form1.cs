namespace EjercicioClase1708
{
    public partial class Form1 : Form
    {
        List<Tarea> tareas = new List<Tarea>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAgregarTarea_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TxtNombreTarea.Text);
        }
    }
}
