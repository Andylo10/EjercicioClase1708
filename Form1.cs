using TellerEventos.Clases;

namespace EjercicioClase1708
{
    public partial class Form1 : Form
    {
        List<Tarea> tareas = new List<Tarea>();
        public Form1()
        {
            InitializeComponent();
            TxtNombreTarea.KeyPress += TxtNombreTarea_KeyPress;
        }

        private void TxtNombreTarea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (TxtNombreTarea.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese un nombre para la tarea.");
                    return;
                }
                Tarea nuevaTarea = new Tarea(TxtNombreTarea.Text, "Pendiente");
                tareas.Add(nuevaTarea);

                this.renderizarTareas();
                TxtNombreTarea.Text = "";
            }
        }
        private void BtnAgregarTarea_Click(object sender, EventArgs e)
        {

            if (TxtNombreTarea.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un nombre para la tarea.");
                return;
            }

            Tarea nuevaTarea = new Tarea(TxtNombreTarea.Text, "Pendiente");
            tareas.Add(nuevaTarea);

            this.renderizarTareas();
            TxtNombreTarea.Text = "";
        }

        private void renderizarTareas()
        {
            flowPanelTareaPendientes.Controls.Clear();

            foreach (Tarea tarea in tareas)
            {
                Label tarjeta = new Label
                {
                    Text = tarea.nombre,
                    AutoSize = true,
                    Padding = new Padding(10),
                    Margin = new Padding(5),
                    BackColor = Color.MediumPurple,
                    ForeColor = Color.Black,
                    BorderStyle = BorderStyle.FixedSingle
                };


                tarjeta.DoubleClick += (sender, e) =>
                {
                    Label etiqueta = (Label)sender;
                    Tarea tareaAEliminar = tareas.Find(t => t.nombre == etiqueta.Text);
                    if (tareaAEliminar != null)
                    {
                        tareas.Remove(tareaAEliminar);
                        renderizarTareas();
                    }
                };

                tarjeta.MouseHover += (sender, e) =>
            {
                tarjeta.BackColor = Color.Gray;
                tarjeta.Font = new Font(tarjeta.Font, FontStyle.Bold);
                tarjeta.Cursor = Cursors.Hand;
            };

                tarjeta.MouseLeave += (sender, e) =>
                {
                    tarjeta.BackColor = Color.MediumPurple;
                    tarjeta.Font = new Font(tarjeta.Font, FontStyle.Regular);
                };

                flowPanelTareaPendientes.Controls.Add(tarjeta);
            }
        }

        private void btnEliminarUltimaTarea_Click(object sender, EventArgs e)
        {
            if (tareas.Count > 0)
            {
                tareas.RemoveAt(tareas.Count - 1);
                renderizarTareas();

            }
        }

        private void MensajeParaBotones_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


