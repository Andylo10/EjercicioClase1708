using TellerEventos.Clases;

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
            if (TxtNombreTarea.Text.Trim() == "")
            {
                MessageBox.Show(TxtNombreTarea.Text);
                return;
            }

            Tarea nuevaTarea = new Tarea(TxtNombreTarea.Text, "Pendiente");
            tareas.Add(nuevaTarea);

            this.renderizarTareas();
        }

        private void renderizarTareas()
        {
            flowPanelTareaPendientes.Controls.Clear();
            foreach (Tarea tarea in tareas)
            {
                Label tarjeta = new Label();
                tarjeta.Text = tarea.nombre;
                tarjeta.AutoSize = true;
                tarjeta.Padding = new Padding(10);
                tarjeta.Margin = new Padding(5);
                tarjeta.BackColor = Color.White;
                tarjeta.ForeColor = Color.Black;
                tarjeta.BorderStyle = BorderStyle.FixedSingle;

                tarjeta.MouseHover += (sender, e) =>
                {
                    tarjeta.BackColor = Color.LightGray;
                    tarjeta.Font = new Font(tarjeta.Font, FontStyle.Bold);
                    tarjeta.Cursor = Cursors.Hand;
                };

                tarjeta.MouseLeave += (sender, e) =>
                {
                    tarjeta.BackColor = Color.White;
                    tarjeta.Font = new Font(tarjeta.Font, FontStyle.Regular);
                };
                flowPanelTareaPendientes.Controls.Add(tarjeta);
            }
        }


        private void btnEliminarUltimaTarea_Click(object sender, EventArgs e)
        {
            tareas.RemoveAt(tareas.Count - 1);
            this.renderizarTareas();
        }
    }
}


