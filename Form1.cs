using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TellerEventos.Clases;

namespace EjercicioClase1708
{
    public partial class Form1 : Form
    {
        List<Tarea> tareas = new List<Tarea>(); // Lista para tareas pendientes
        List<Tarea> totalTareasPendientes = new List<Tarea>(); // Lista para tareas movidas
        List<Tarea> tareasCompletadas = new List<Tarea>(); // Lista para tareas completadas
        private Tarea tareaSeleccionada; // Variable para almacenar la tarea seleccionada

        public Form1()
        {
            InitializeComponent();
            TxtNombreTarea.KeyPress += TxtNombreTarea_KeyPress;
            btnMoveraTareasPendientes.Click += btnMoveraTareasPendientes_Click;
            btnTareaCompletada.Click += btnTareaCompletada_Click;
            btnEliminarUltimaTarea.Click += btnEliminarUltimaTarea_Click;
        }

        private void btnEliminarUltimaTarea_Click(object sender, EventArgs e)
        {
            if (tareaSeleccionada == null)
            {
                MessageBox.Show("Seleccione una tarea para eliminar.");
                return;
            }

            // Eliminar la tarea seleccionada de las listas correspondientes
            if (tareas.Contains(tareaSeleccionada))
            {
                tareas.Remove(tareaSeleccionada);
            }
            else if (totalTareasPendientes.Contains(tareaSeleccionada))
            {
                totalTareasPendientes.Remove(tareaSeleccionada);
            }
            else if (tareasCompletadas.Contains(tareaSeleccionada))
            {
                tareasCompletadas.Remove(tareaSeleccionada);
            }

            // Renderizar todos los paneles
            renderizarTareas();
            renderizarTotalTareasPendientes();
            renderizarTareasCompletadas();

            // Desmarcar la tarea seleccionada
            tareaSeleccionada = null;
        }

        private void TxtNombreTarea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AgregarTarea();
            }
        }

        private void BtnAgregarTarea_Click(object sender, EventArgs e)
        {
            AgregarTarea();
        }

        private void AgregarTarea()
        {
            if (TxtNombreTarea.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un nombre para la tarea.");
                return;
            }

            Tarea nuevaTarea = new Tarea(TxtNombreTarea.Text, "Pendiente");
            tareas.Add(nuevaTarea);

            renderizarTareas();
            TxtNombreTarea.Text = "";
        }

        private void renderizarTareas()
        {
            flowPanelTareaPendientes.Controls.Clear(); 

            foreach (Tarea tarea in tareas)
            {
                Label tarjeta = CrearEtiquetaTarea(tarea, Color.MediumPurple, flowPanelTareaPendientes);
                flowPanelTareaPendientes.Controls.Add(tarjeta);
            }
        }

        private void btnMoveraTareasPendientes_Click(object sender, EventArgs e)
        {
            if (tareaSeleccionada == null)
            {
                MessageBox.Show("Seleccione una tarea para mover.");
                return;
            }

            
            tareas.Remove(tareaSeleccionada);
            totalTareasPendientes.Add(tareaSeleccionada);

            
            renderizarTareas();
            renderizarTotalTareasPendientes();

            
            tareaSeleccionada = null;
        }

        private void renderizarTotalTareasPendientes()
        {
            flowPanelTotalTareasPendientes.Controls.Clear(); 

            foreach (Tarea tarea in totalTareasPendientes)
            {
                Label tarjeta = CrearEtiquetaTarea(tarea, Color.Khaki, flowPanelTotalTareasPendientes);
                flowPanelTotalTareasPendientes.Controls.Add(tarjeta);
            }
        }

        private void btnTareaCompletada_Click(object sender, EventArgs e)
        {
            if (tareaSeleccionada == null)
            {
                MessageBox.Show("Seleccione una tarea para completar.");
                return;
            }

            
            totalTareasPendientes.Remove(tareaSeleccionada);
            tareasCompletadas.Add(tareaSeleccionada);

            
            renderizarTotalTareasPendientes();
            renderizarTareasCompletadas();

            
            tareaSeleccionada = null;
        }

        private void renderizarTareasCompletadas()
        {
            flowPanelTareasCompletadas.Controls.Clear(); 
            
            foreach (Tarea tarea in tareasCompletadas)
            {
                Label tarjeta = CrearEtiquetaTarea(tarea, Color.LightGreen, flowPanelTareasCompletadas);
                flowPanelTareasCompletadas.Controls.Add(tarjeta);
            }
        }

        
        private Label CrearEtiquetaTarea(Tarea tarea, Color colorFondo, FlowLayoutPanel panel)
        {
            Label tarjeta = new Label
            {
                Text = tarea.nombre,
                AutoSize = true,
                Padding = new Padding(10),
                Margin = new Padding(5),
                BackColor = colorFondo,
                ForeColor = Color.Black,
                BorderStyle = BorderStyle.FixedSingle
            };

            
            tarjeta.Click += (sender, e) =>
            {
                tareaSeleccionada = tarea;

                
                foreach (Label lbl in panel.Controls)
                {
                    lbl.BackColor = colorFondo;
                }
                tarjeta.BackColor = Color.LightBlue; 
            };

            
            tarjeta.DoubleClick += (sender, e) =>
            {
                if (panel == flowPanelTareaPendientes)
                {
                    tareas.Remove(tarea);
                }
                else if (panel == flowPanelTotalTareasPendientes)
                {
                    totalTareasPendientes.Remove(tarea);
                }
                else if (panel == flowPanelTareasCompletadas)
                {
                    tareasCompletadas.Remove(tarea);
                }

                renderizarTareas();
                renderizarTotalTareasPendientes();
                renderizarTareasCompletadas();
            };

            tarjeta.MouseHover += (sender, e) =>
            {
                tarjeta.BackColor = Color.Gray;
                tarjeta.Font = new Font(tarjeta.Font, FontStyle.Bold);
                tarjeta.Cursor = Cursors.Hand;
            };

            tarjeta.MouseLeave += (sender, e) =>
            {
                
                if (tareaSeleccionada == null || tarjeta.Text != tareaSeleccionada.nombre)
                {
                    tarjeta.BackColor = colorFondo;
                }
                tarjeta.Font = new Font(tarjeta.Font, FontStyle.Regular);
            };

            return tarjeta;
        }
    }
}
