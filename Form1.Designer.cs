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
            btnEliminarUltimaTarea = new Button();
            SuspendLayout();
            // 
            // TxtNombreTarea
            // 
            TxtNombreTarea.BackColor = Color.Thistle;
            TxtNombreTarea.Location = new Point(48, 48);
            TxtNombreTarea.Name = "TxtNombreTarea";
            TxtNombreTarea.PlaceholderText = "Ingrese su Tarea";
            TxtNombreTarea.Size = new Size(254, 23);
            TxtNombreTarea.TabIndex = 0;
            // 
            // BtnAgregarTarea
            // 
            BtnAgregarTarea.BackColor = Color.DarkSeaGreen;
            BtnAgregarTarea.Location = new Point(317, 45);
            BtnAgregarTarea.Name = "BtnAgregarTarea";
            BtnAgregarTarea.Size = new Size(99, 29);
            BtnAgregarTarea.TabIndex = 1;
            BtnAgregarTarea.Text = "Agregar +";
            BtnAgregarTarea.UseVisualStyleBackColor = false;
            BtnAgregarTarea.Click += BtnAgregarTarea_Click;
            // 
            // flowPanelTareaPendientes
            // 
            flowPanelTareaPendientes.BackColor = Color.PowderBlue;
            flowPanelTareaPendientes.Location = new Point(48, 144);
            flowPanelTareaPendientes.Name = "flowPanelTareaPendientes";
            flowPanelTareaPendientes.Size = new Size(181, 228);
            flowPanelTareaPendientes.TabIndex = 2;
            // 
            // btnEliminarUltimaTarea
            // 
            btnEliminarUltimaTarea.BackColor = Color.Brown;
            btnEliminarUltimaTarea.Location = new Point(630, 144);
            btnEliminarUltimaTarea.Name = "btnEliminarUltimaTarea";
            btnEliminarUltimaTarea.Size = new Size(113, 66);
            btnEliminarUltimaTarea.TabIndex = 3;
            btnEliminarUltimaTarea.Text = "Eliminar Ultima Tarea";
            btnEliminarUltimaTarea.UseVisualStyleBackColor = false;
            btnEliminarUltimaTarea.Click += btnEliminarUltimaTarea_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
        private Button btnEliminarUltimaTarea;
    }
}
