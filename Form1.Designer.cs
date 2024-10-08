﻿using TellerEventos.Clases;

namespace EjercicioClase1708
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TxtNombreTarea = new TextBox();
            BtnAgregarTarea = new Button();
            flowPanelTareaPendientes = new FlowLayoutPanel();
            btnMoveraTareasPendientes = new Button();
            btnTareaCompletada = new Button();
            flowPanelTotalTareasPendientes = new FlowLayoutPanel();
            labelTotalTareas = new Label();
            labelTareasPentientes = new Label();
            flowPanelTareasCompletadas = new FlowLayoutPanel();
            labelTareasCompletadas = new Label();
            MensajeParaBotones = new Label();
            btnEliminarUltimaTarea = new Button();
            cmbEstadoTarea = new ComboBox();
            SuspendLayout();
            // 
            // TxtNombreTarea
            // 
            TxtNombreTarea.BackColor = Color.Thistle;
            TxtNombreTarea.Location = new Point(48, 40);
            TxtNombreTarea.Name = "TxtNombreTarea";
            TxtNombreTarea.PlaceholderText = "Ingrese su Tarea";
            TxtNombreTarea.Size = new Size(254, 23);
            TxtNombreTarea.TabIndex = 0;
            // 
            // BtnAgregarTarea
            // 
            BtnAgregarTarea.BackColor = Color.DarkSeaGreen;
            BtnAgregarTarea.Location = new Point(308, 37);
            BtnAgregarTarea.Name = "BtnAgregarTarea";
            BtnAgregarTarea.Size = new Size(99, 29);
            BtnAgregarTarea.TabIndex = 1;
            BtnAgregarTarea.Text = "Agregar +";
            BtnAgregarTarea.UseVisualStyleBackColor = false;
            BtnAgregarTarea.Click += BtnAgregarTarea_Click;
            // 
            // flowPanelTareaPendientes
            // 
            flowPanelTareaPendientes.BackColor = Color.LightBlue;
            flowPanelTareaPendientes.Location = new Point(48, 144);
            flowPanelTareaPendientes.Name = "flowPanelTareaPendientes";
            flowPanelTareaPendientes.Size = new Size(164, 241);
            flowPanelTareaPendientes.TabIndex = 2;
            // 
            // btnMoveraTareasPendientes
            // 
            btnMoveraTareasPendientes.BackColor = Color.Goldenrod;
            btnMoveraTareasPendientes.Location = new Point(630, 174);
            btnMoveraTareasPendientes.Name = "btnMoveraTareasPendientes";
            btnMoveraTareasPendientes.Size = new Size(112, 70);
            btnMoveraTareasPendientes.TabIndex = 4;
            btnMoveraTareasPendientes.Text = "Mover a Tareas Proceso";
            btnMoveraTareasPendientes.UseVisualStyleBackColor = false;
            // 
            // btnTareaCompletada
            // 
            btnTareaCompletada.BackColor = Color.ForestGreen;
            btnTareaCompletada.Location = new Point(630, 265);
            btnTareaCompletada.Name = "btnTareaCompletada";
            btnTareaCompletada.Size = new Size(113, 69);
            btnTareaCompletada.TabIndex = 5;
            btnTareaCompletada.Text = "Tarea Completada";
            btnTareaCompletada.UseVisualStyleBackColor = false;
            // 
            // flowPanelTotalTareasPendientes
            // 
            flowPanelTotalTareasPendientes.BackColor = Color.Khaki;
            flowPanelTotalTareasPendientes.Location = new Point(233, 144);
            flowPanelTotalTareasPendientes.Name = "flowPanelTotalTareasPendientes";
            flowPanelTotalTareasPendientes.Size = new Size(172, 241);
            flowPanelTotalTareasPendientes.TabIndex = 6;
            // 
            // labelTotalTareas
            // 
            labelTotalTareas.AutoSize = true;
            labelTotalTareas.Location = new Point(78, 126);
            labelTotalTareas.Name = "labelTotalTareas";
            labelTotalTareas.Size = new Size(105, 15);
            labelTotalTareas.TabIndex = 7;
            labelTotalTareas.Text = "Tareas sin Empezar";
            // 
            // labelTareasPentientes
            // 
            labelTareasPentientes.AutoSize = true;
            labelTareasPentientes.Location = new Point(267, 126);
            labelTareasPentientes.Name = "labelTareasPentientes";
            labelTareasPentientes.Size = new Size(105, 15);
            labelTareasPentientes.TabIndex = 8;
            labelTareasPentientes.Text = "Tareas en Progreso";
            // 
            // flowPanelTareasCompletadas
            // 
            flowPanelTareasCompletadas.BackColor = Color.LightGreen;
            flowPanelTareasCompletadas.Location = new Point(427, 144);
            flowPanelTareasCompletadas.Name = "flowPanelTareasCompletadas";
            flowPanelTareasCompletadas.Size = new Size(158, 241);
            flowPanelTareasCompletadas.TabIndex = 9;
            // 
            // labelTareasCompletadas
            // 
            labelTareasCompletadas.AutoSize = true;
            labelTareasCompletadas.Location = new Point(451, 126);
            labelTareasCompletadas.Name = "labelTareasCompletadas";
            labelTareasCompletadas.Size = new Size(112, 15);
            labelTareasCompletadas.TabIndex = 10;
            labelTareasCompletadas.Text = "Tareas Completadas";
            // 
            // MensajeParaBotones
            // 
            MensajeParaBotones.AutoSize = true;
            MensajeParaBotones.BackColor = Color.DarkGray;
            MensajeParaBotones.Location = new Point(553, 49);
            MensajeParaBotones.Name = "MensajeParaBotones";
            MensajeParaBotones.Size = new Size(205, 15);
            MensajeParaBotones.TabIndex = 11;
            MensajeParaBotones.Text = "Seleccione la Tarea y decida su Estado";
            // 
            // btnEliminarUltimaTarea
            // 
            btnEliminarUltimaTarea.BackColor = Color.White;
            btnEliminarUltimaTarea.Location = new Point(748, 54);
            btnEliminarUltimaTarea.Name = "btnEliminarUltimaTarea";
            btnEliminarUltimaTarea.Size = new Size(10, 10);
            btnEliminarUltimaTarea.TabIndex = 3;
            btnEliminarUltimaTarea.Text = "Eliminar Tarea";
            btnEliminarUltimaTarea.UseVisualStyleBackColor = false;
            btnEliminarUltimaTarea.Click += btnEliminarUltimaTarea_Click;
            // 
            // cmbEstadoTarea
            // 
            cmbEstadoTarea.BackColor = Color.Silver;
            cmbEstadoTarea.FormattingEnabled = true;
            cmbEstadoTarea.Location = new Point(48, 73);
            cmbEstadoTarea.Name = "cmbEstadoTarea";
            cmbEstadoTarea.Size = new Size(147, 23);
            cmbEstadoTarea.TabIndex = 12;
            cmbEstadoTarea.SelectedIndexChanged += CmbEstadoTarea_SelectedIndexChanged;

            cmbEstadoTarea.Items.Add("Sin Empezar");
            cmbEstadoTarea.Items.Add("En Progreso");
            cmbEstadoTarea.Items.Add("Completada");// 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbEstadoTarea);
            Controls.Add(flowPanelTareasCompletadas);
            Controls.Add(MensajeParaBotones);
            Controls.Add(labelTareasCompletadas);
            Controls.Add(labelTareasPentientes);
            Controls.Add(labelTotalTareas);
            Controls.Add(flowPanelTotalTareasPendientes);
            Controls.Add(btnTareaCompletada);
            Controls.Add(btnMoveraTareasPendientes);
            Controls.Add(btnEliminarUltimaTarea);
            Controls.Add(flowPanelTareaPendientes);
            Controls.Add(BtnAgregarTarea);
            Controls.Add(TxtNombreTarea);
            Name = "Form1";
            Text = "ControlTareas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtNombreTarea;
        private Button BtnAgregarTarea;
        private FlowLayoutPanel flowPanelTareaPendientes;
        private Button btnMoveraTareasPendientes;
        private Button btnTareaCompletada;
        private FlowLayoutPanel flowPanelTotalTareasPendientes;
        private Label labelTotalTareas;
        private Label labelTareasPentientes;
        private FlowLayoutPanel flowPanelTareasCompletadas;
        private Label labelTareasCompletadas;
        private Label MensajeParaBotones;
        private Button btnEliminarUltimaTarea;
        private Tarea tareaSeleccionada;
        private ComboBox cmbEstadoTarea;
    }
    
}
