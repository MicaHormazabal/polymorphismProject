namespace Figuras
{
    partial class FPrincipal
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
            gbFiguras = new GroupBox();
            rbRectangulo = new RadioButton();
            rbCirculo = new RadioButton();
            rbTriangulo = new RadioButton();
            rbCuadrado = new RadioButton();
            gbFiguraSeleccionada = new GroupBox();
            tbIngresar4 = new TextBox();
            tbIngresar3 = new TextBox();
            tbIngresar2 = new TextBox();
            lIngresar3 = new Label();
            lIngresar2 = new Label();
            tbIngresar1 = new TextBox();
            lIngresar1 = new Label();
            bAgregar = new Button();
            lbFiguras = new ListBox();
            bArea = new Button();
            bPerímetro = new Button();
            bCerrar = new Button();
            lCantFiguras = new Label();
            lCantidad = new Label();
            lContador1 = new Label();
            lContador2 = new Label();
            lIngresar4 = new Label();
            ep1 = new ErrorProvider(components);
            ep2 = new ErrorProvider(components);
            ep3 = new ErrorProvider(components);
            ep4 = new ErrorProvider(components);
            gbFiguras.SuspendLayout();
            gbFiguraSeleccionada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ep1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ep2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ep3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ep4).BeginInit();
            SuspendLayout();
            // 
            // gbFiguras
            // 
            gbFiguras.Controls.Add(rbRectangulo);
            gbFiguras.Controls.Add(rbCirculo);
            gbFiguras.Controls.Add(rbTriangulo);
            gbFiguras.Controls.Add(rbCuadrado);
            gbFiguras.Location = new Point(10, 16);
            gbFiguras.Margin = new Padding(3, 2, 3, 2);
            gbFiguras.Name = "gbFiguras";
            gbFiguras.Padding = new Padding(3, 2, 3, 2);
            gbFiguras.Size = new Size(169, 155);
            gbFiguras.TabIndex = 0;
            gbFiguras.TabStop = false;
            gbFiguras.Text = "Figuras";
            // 
            // rbRectangulo
            // 
            rbRectangulo.AutoSize = true;
            rbRectangulo.Location = new Point(13, 123);
            rbRectangulo.Margin = new Padding(3, 2, 3, 2);
            rbRectangulo.Name = "rbRectangulo";
            rbRectangulo.Size = new Size(85, 19);
            rbRectangulo.TabIndex = 5;
            rbRectangulo.TabStop = true;
            rbRectangulo.Text = "Rectángulo";
            rbRectangulo.UseVisualStyleBackColor = true;
            rbRectangulo.CheckedChanged += rbRectangulo_CheckedChanged;
            // 
            // rbCirculo
            // 
            rbCirculo.AutoSize = true;
            rbCirculo.Location = new Point(13, 28);
            rbCirculo.Margin = new Padding(3, 2, 3, 2);
            rbCirculo.Name = "rbCirculo";
            rbCirculo.Size = new Size(63, 19);
            rbCirculo.TabIndex = 2;
            rbCirculo.TabStop = true;
            rbCirculo.Text = "Círculo";
            rbCirculo.UseVisualStyleBackColor = true;
            rbCirculo.CheckedChanged += rbCirculo_CheckedChanged;
            // 
            // rbTriangulo
            // 
            rbTriangulo.AutoSize = true;
            rbTriangulo.Location = new Point(13, 91);
            rbTriangulo.Margin = new Padding(3, 2, 3, 2);
            rbTriangulo.Name = "rbTriangulo";
            rbTriangulo.Size = new Size(74, 19);
            rbTriangulo.TabIndex = 4;
            rbTriangulo.TabStop = true;
            rbTriangulo.Text = "Triángulo";
            rbTriangulo.UseVisualStyleBackColor = true;
            rbTriangulo.CheckedChanged += rbTriangulo_CheckedChanged;
            // 
            // rbCuadrado
            // 
            rbCuadrado.AutoSize = true;
            rbCuadrado.Location = new Point(13, 60);
            rbCuadrado.Margin = new Padding(3, 2, 3, 2);
            rbCuadrado.Name = "rbCuadrado";
            rbCuadrado.Size = new Size(77, 19);
            rbCuadrado.TabIndex = 3;
            rbCuadrado.TabStop = true;
            rbCuadrado.Text = "Cuadrado";
            rbCuadrado.UseVisualStyleBackColor = true;
            rbCuadrado.CheckedChanged += rbCuadrado_CheckedChanged;
            // 
            // gbFiguraSeleccionada
            // 
            gbFiguraSeleccionada.Controls.Add(lIngresar4);
            gbFiguraSeleccionada.Controls.Add(tbIngresar4);
            gbFiguraSeleccionada.Controls.Add(tbIngresar3);
            gbFiguraSeleccionada.Controls.Add(tbIngresar2);
            gbFiguraSeleccionada.Controls.Add(lIngresar3);
            gbFiguraSeleccionada.Controls.Add(lIngresar2);
            gbFiguraSeleccionada.Controls.Add(tbIngresar1);
            gbFiguraSeleccionada.Controls.Add(lIngresar1);
            gbFiguraSeleccionada.Location = new Point(200, 16);
            gbFiguraSeleccionada.Margin = new Padding(3, 2, 3, 2);
            gbFiguraSeleccionada.Name = "gbFiguraSeleccionada";
            gbFiguraSeleccionada.Padding = new Padding(3, 2, 3, 2);
            gbFiguraSeleccionada.Size = new Size(274, 155);
            gbFiguraSeleccionada.TabIndex = 1;
            gbFiguraSeleccionada.TabStop = false;
            // 
            // tbIngresar4
            // 
            tbIngresar4.Location = new Point(90, 118);
            tbIngresar4.Margin = new Padding(3, 2, 3, 2);
            tbIngresar4.Name = "tbIngresar4";
            tbIngresar4.Size = new Size(110, 23);
            tbIngresar4.TabIndex = 7;
            tbIngresar4.Visible = false;
            tbIngresar4.KeyPress += tbIngresar4_KeyPress;
            // 
            // tbIngresar3
            // 
            tbIngresar3.Location = new Point(90, 86);
            tbIngresar3.Margin = new Padding(3, 2, 3, 2);
            tbIngresar3.Name = "tbIngresar3";
            tbIngresar3.Size = new Size(110, 23);
            tbIngresar3.TabIndex = 6;
            tbIngresar3.Visible = false;
            tbIngresar3.KeyPress += tbIngresar3_KeyPress;
            // 
            // tbIngresar2
            // 
            tbIngresar2.Location = new Point(90, 53);
            tbIngresar2.Margin = new Padding(3, 2, 3, 2);
            tbIngresar2.Name = "tbIngresar2";
            tbIngresar2.Size = new Size(110, 23);
            tbIngresar2.TabIndex = 5;
            tbIngresar2.Visible = false;
            tbIngresar2.KeyPress += tbIngresar2_KeyPress;
            // 
            // lIngresar3
            // 
            lIngresar3.AutoSize = true;
            lIngresar3.Location = new Point(18, 89);
            lIngresar3.Name = "lIngresar3";
            lIngresar3.Size = new Size(49, 15);
            lIngresar3.TabIndex = 4;
            lIngresar3.Text = "Ingresar";
            lIngresar3.Visible = false;
            // 
            // lIngresar2
            // 
            lIngresar2.AutoSize = true;
            lIngresar2.Location = new Point(18, 56);
            lIngresar2.Name = "lIngresar2";
            lIngresar2.Size = new Size(49, 15);
            lIngresar2.TabIndex = 3;
            lIngresar2.Text = "Ingresar";
            lIngresar2.Visible = false;
            // 
            // tbIngresar1
            // 
            tbIngresar1.Location = new Point(90, 19);
            tbIngresar1.Margin = new Padding(3, 2, 3, 2);
            tbIngresar1.Name = "tbIngresar1";
            tbIngresar1.Size = new Size(110, 23);
            tbIngresar1.TabIndex = 2;
            tbIngresar1.KeyPress += tbIngresar1_KeyPress;
            // 
            // lIngresar1
            // 
            lIngresar1.AutoSize = true;
            lIngresar1.Location = new Point(18, 22);
            lIngresar1.Name = "lIngresar1";
            lIngresar1.Size = new Size(49, 15);
            lIngresar1.TabIndex = 1;
            lIngresar1.Text = "Ingresar";
            // 
            // bAgregar
            // 
            bAgregar.Enabled = false;
            bAgregar.Location = new Point(392, 176);
            bAgregar.Margin = new Padding(3, 2, 3, 2);
            bAgregar.Name = "bAgregar";
            bAgregar.Size = new Size(82, 22);
            bAgregar.TabIndex = 2;
            bAgregar.Text = "&Agregar";
            bAgregar.UseVisualStyleBackColor = true;
            bAgregar.Click += bAgregar_Click;
            // 
            // lbFiguras
            // 
            lbFiguras.FormattingEnabled = true;
            lbFiguras.ItemHeight = 15;
            lbFiguras.Location = new Point(10, 176);
            lbFiguras.Margin = new Padding(3, 2, 3, 2);
            lbFiguras.Name = "lbFiguras";
            lbFiguras.Size = new Size(361, 154);
            lbFiguras.TabIndex = 3;
            // 
            // bArea
            // 
            bArea.Enabled = false;
            bArea.Location = new Point(392, 245);
            bArea.Margin = new Padding(3, 2, 3, 2);
            bArea.Name = "bArea";
            bArea.Size = new Size(82, 22);
            bArea.TabIndex = 4;
            bArea.Text = "&Area";
            bArea.UseVisualStyleBackColor = true;
            bArea.Click += bArea_Click;
            // 
            // bPerímetro
            // 
            bPerímetro.Enabled = false;
            bPerímetro.Location = new Point(392, 283);
            bPerímetro.Margin = new Padding(3, 2, 3, 2);
            bPerímetro.Name = "bPerímetro";
            bPerímetro.Size = new Size(82, 22);
            bPerímetro.TabIndex = 5;
            bPerímetro.Text = "&Perímetro";
            bPerímetro.UseVisualStyleBackColor = true;
            bPerímetro.Click += bPerímetro_Click;
            // 
            // bCerrar
            // 
            bCerrar.Location = new Point(392, 376);
            bCerrar.Margin = new Padding(3, 2, 3, 2);
            bCerrar.Name = "bCerrar";
            bCerrar.Size = new Size(82, 22);
            bCerrar.TabIndex = 6;
            bCerrar.Text = "&Cerrar";
            bCerrar.UseVisualStyleBackColor = true;
            bCerrar.Click += bCerrar_Click;
            // 
            // lCantFiguras
            // 
            lCantFiguras.AutoSize = true;
            lCantFiguras.Location = new Point(10, 382);
            lCantFiguras.Name = "lCantFiguras";
            lCantFiguras.Size = new Size(113, 15);
            lCantFiguras.TabIndex = 7;
            lCantFiguras.Text = "Cantidad de figuras:";
            // 
            // lCantidad
            // 
            lCantidad.AutoSize = true;
            lCantidad.Location = new Point(10, 356);
            lCantidad.Name = "lCantidad";
            lCantidad.Size = new Size(118, 15);
            lCantidad.TabIndex = 8;
            lCantidad.Text = "Cantidad de círculos:";
            // 
            // lContador1
            // 
            lContador1.AutoSize = true;
            lContador1.Location = new Point(168, 356);
            lContador1.Name = "lContador1";
            lContador1.Size = new Size(13, 15);
            lContador1.TabIndex = 9;
            lContador1.Text = "0";
            // 
            // lContador2
            // 
            lContador2.AutoSize = true;
            lContador2.Location = new Point(168, 382);
            lContador2.Name = "lContador2";
            lContador2.Size = new Size(13, 15);
            lContador2.TabIndex = 10;
            lContador2.Text = "0";
            // 
            // lIngresar4
            // 
            lIngresar4.AutoSize = true;
            lIngresar4.Location = new Point(18, 121);
            lIngresar4.Name = "lIngresar4";
            lIngresar4.Size = new Size(49, 15);
            lIngresar4.TabIndex = 5;
            lIngresar4.Text = "Ingresar";
            lIngresar4.Visible = false;
            // 
            // ep1
            // 
            ep1.ContainerControl = this;
            // 
            // ep2
            // 
            ep2.ContainerControl = this;
            // 
            // ep3
            // 
            ep3.ContainerControl = this;
            // 
            // ep4
            // 
            ep4.ContainerControl = this;
            // 
            // FPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 413);
            Controls.Add(lContador2);
            Controls.Add(lContador1);
            Controls.Add(lCantidad);
            Controls.Add(lCantFiguras);
            Controls.Add(bCerrar);
            Controls.Add(bPerímetro);
            Controls.Add(bArea);
            Controls.Add(lbFiguras);
            Controls.Add(bAgregar);
            Controls.Add(gbFiguraSeleccionada);
            Controls.Add(gbFiguras);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FPrincipal";
            Text = "Figuras";
            gbFiguras.ResumeLayout(false);
            gbFiguras.PerformLayout();
            gbFiguraSeleccionada.ResumeLayout(false);
            gbFiguraSeleccionada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ep1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ep2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ep3).EndInit();
            ((System.ComponentModel.ISupportInitialize)ep4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbFiguras;
        private RadioButton rbRectangulo;
        private RadioButton rbCirculo;
        private RadioButton rbTriangulo;
        private RadioButton rbCuadrado;
        private GroupBox gbFiguraSeleccionada;
        private TextBox tbIngresar1;
        private Label lIngresar1;
        private Button bAgregar;
        private ListBox lbFiguras;
        private Button bArea;
        private Button bPerímetro;
        private Button bCerrar;
        private Label lCantFiguras;
        private Label lCantidad;
        private Label lContador1;
        private Label lContador2;
        private Label lIngresar4;
        private Label lIngresar3;
        private Label lIngresar2;
        private TextBox tbIngresar4;
        private TextBox tbIngresar3;
        private TextBox tbIngresar2;
        private ErrorProvider ep1;
        private ErrorProvider ep2;
        private ErrorProvider ep3;
        private ErrorProvider ep4;
    }
}