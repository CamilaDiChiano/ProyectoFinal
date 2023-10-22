namespace SistemaGestionEF
{
    partial class FormPrincipal
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
            components = new System.ComponentModel.Container();
            productoBussinessBindingSource1 = new BindingSource(components);
            productoVendidoBussinessBindingSource = new BindingSource(components);
            ventaBussinessBindingSource = new BindingSource(components);
            productoBindingSource1 = new BindingSource(components);
            productoBindingSource = new BindingSource(components);
            productoBussinessBindingSource = new BindingSource(components);
            usuarioBussinessBindingSource = new BindingSource(components);
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)productoBussinessBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoVendidoBussinessBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ventaBussinessBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoBussinessBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBussinessBindingSource).BeginInit();
            SuspendLayout();
            // 
            // productoBussinessBindingSource1
            // 
            productoBussinessBindingSource1.DataSource = typeof(SistemaGestionBussiness.ProductoBussiness);
            // 
            // productoVendidoBussinessBindingSource
            // 
            productoVendidoBussinessBindingSource.DataSource = typeof(SistemaGestionBussiness.ProductoVendidoBussiness);
            // 
            // ventaBussinessBindingSource
            // 
            ventaBussinessBindingSource.DataSource = typeof(SistemaGestionBussiness.VentaBussiness);
            // 
            // productoBindingSource1
            // 
            productoBindingSource1.DataSource = typeof(SistemaGestionEntities.Producto);
            // 
            // productoBindingSource
            // 
            productoBindingSource.DataSource = typeof(SistemaGestionEntities.Producto);
            // 
            // productoBussinessBindingSource
            // 
            productoBussinessBindingSource.DataSource = typeof(SistemaGestionBussiness.ProductoBussiness);
            // 
            // usuarioBussinessBindingSource
            // 
            usuarioBussinessBindingSource.DataSource = typeof(SistemaGestionBussiness.UsuarioBussiness);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(344, 184);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(207, 38);
            label3.TabIndex = 16;
            label3.Text = "!Bienvenido!";
            label3.Click += label3_Click_1;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(921, 487);
            Controls.Add(label3);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormPrincipal";
            Text = "Sistema Gestion Form";
            ((System.ComponentModel.ISupportInitialize)productoBussinessBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoVendidoBussinessBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ventaBussinessBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoBussinessBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBussinessBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource usuarioBussinessBindingSource;
        private BindingSource productoBussinessBindingSource;
        private BindingSource productoBindingSource;
        private BindingSource productoBindingSource1;
        private BindingSource productoBussinessBindingSource1;
        private BindingSource productoVendidoBussinessBindingSource;
        private BindingSource ventaBussinessBindingSource;
        private Label label3;
    }
}