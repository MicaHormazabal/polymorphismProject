using System.Drawing;

namespace Figuras
{
    public partial class FPrincipal : Form
    {
        Figura[] ArrFiguras;
        int Cont;
        int TopeFiguras;
        int CantCirc;
        int CantCuad;
        int CantTriang;
        int CantRect;
        public FPrincipal()
        {
            InitializeComponent();
            TopeFiguras = 100;
            Cont = 0;
            ArrFiguras = new Figura[TopeFiguras];
            CantCirc = 0;
            CantCuad = 0;
            CantTriang = 0;
            CantRect = 0;
        }

        private void rbCirculo_CheckedChanged(object sender, EventArgs e)
        {
            ep1.Clear();

            lIngresar2.Visible = false;
            tbIngresar2.Visible = false;
            lIngresar3.Visible = false;
            tbIngresar3.Visible = false;
            lIngresar4.Visible = false;
            tbIngresar4.Visible = false;

            lIngresar1.Text = "Radio";

            gbFiguraSeleccionada.Text = rbCirculo.Text;

            bAgregar.Enabled = true;

            lCantidad.Text = "Cantidad de círculos:";
        }
        private void rbCuadrado_CheckedChanged(object sender, EventArgs e)
        {
            ep1.Clear();

            lIngresar2.Visible = false;
            tbIngresar2.Visible = false;
            lIngresar3.Visible = false;
            tbIngresar3.Visible = false;
            lIngresar4.Visible = false;
            tbIngresar4.Visible = false;

            lIngresar1.Text = "Lado";
            gbFiguraSeleccionada.Text = rbCuadrado.Text;

            bAgregar.Enabled = true;
            lCantidad.Text = "Cantidad de cuadrados:";
        }
        private void rbTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            ep1.Clear();
            ep2.Clear();
            ep3.Clear();
            ep4.Clear();

            lIngresar1.Text = "Base";
            lIngresar2.Text = "Altura";
            lIngresar2.Visible = true;
            tbIngresar2.Visible = true;
            lIngresar3.Text = "Lado 1";
            lIngresar3.Visible = true;
            tbIngresar3.Visible = true;
            lIngresar4.Text = "Lado 2";
            lIngresar4.Visible = true;
            tbIngresar4.Visible = true;

            gbFiguraSeleccionada.Text = rbTriangulo.Text;

            bAgregar.Enabled = true;
            lCantidad.Text = "Cantidad de triangulos:";
        }
        private void rbRectangulo_CheckedChanged(object sender, EventArgs e)
        {
            ep1.Clear();
            ep2.Clear();

            lIngresar3.Visible = false;
            tbIngresar3.Visible = false;
            lIngresar4.Visible = false;
            tbIngresar4.Visible = false;

            lIngresar1.Text = "Base";
            lIngresar2.Text = "Altura";
            lIngresar2.Visible = true;
            tbIngresar2.Visible = true;

            gbFiguraSeleccionada.Text = rbRectangulo.Text;

            bAgregar.Enabled = true;
            lCantidad.Text = "Cantidad de rectangulos:";           
        }

        public void Mostrar()
        {
            lbFiguras.Items.Clear();

            for (int i = 0; i < Cont; i++)
            {
                lbFiguras.Items.Add(ArrFiguras[i].ToString());
            }
            
            lContador2.Text = Cont.ToString();

            if (rbCirculo.Checked)
            {
                lContador1.Text = Convert.ToString(CantCirc);
            }
            else if (rbCuadrado.Checked)
            {
                lContador1.Text = Convert.ToString(CantCuad);
            }
            else if (rbTriangulo.Checked)
            {
                lContador1.Text = Convert.ToString(CantTriang);
            }
            else if (rbRectangulo.Checked)
            {
                lContador1.Text = Convert.ToString(CantRect);
            }

            bArea.Enabled = true;
            bPerímetro.Enabled = true;
        }

        public bool ExisteFigura(object obj)
        {
            bool Existe = false;
            int i = 0;

            while (i < Cont && !Existe)
            {
                Existe = ArrFiguras[i].Equals(obj);
                i++;
            }

            return Existe;
        }

        public void Limpiar()
        {
            tbIngresar1.Clear();
            tbIngresar2.Clear();
            tbIngresar3.Clear();
            tbIngresar4.Clear();
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            ep1.Clear();
            ep2.Clear();
            ep3.Clear();
            ep4.Clear();
            
            if  (Cont >= ArrFiguras.Length)
            {
                MessageBox.Show("El arreglo esta lleno");
            }
            else
            {
                if (rbCirculo.Checked)
                {
                    if (tbIngresar1.Text == "")
                    {
                        ep1.SetError(tbIngresar1, "Completar campo RADIO");
                        tbIngresar1.Focus();
                    }
                    else
                    {
                        double radio = Convert.ToDouble(tbIngresar1.Text);

                        if (radio <= 0)
                        {
                            MessageBox.Show("El radio ingresado es incorrecto");
                        }
                        else
                        {
                            Circulo NvoCirculo = new Circulo(radio);

                            if (ExisteFigura(NvoCirculo)) 
                            {
                                MessageBox.Show("El circulo ya existe en el arreglo");
                            }
                            else
                            {
                                ArrFiguras[Cont++] = NvoCirculo;
                                CantCirc++;
                            }                            
                        }
                    }
                }
                else if (rbCuadrado.Checked)
                {
                    if (tbIngresar1.Text == "")
                    {
                        ep1.SetError(tbIngresar1, "Completar campo LADO");
                        tbIngresar1.Focus();
                    }
                    else
                    {
                        double lado = Convert.ToDouble(tbIngresar1.Text);

                        if (lado <= 0)
                        {
                            MessageBox.Show("El lado ingresado es incorrecto");
                        }
                        else
                        {
                            Cuadrado NvoCuadrado = new Cuadrado(lado);

                            if (ExisteFigura(NvoCuadrado))
                            {
                                MessageBox.Show("El cuadrado ya existe en el arreglo");
                            }
                            else
                            {
                                ArrFiguras[Cont++] = NvoCuadrado;
                                CantCuad++;
                            }                            
                        }
                    }
                }
                else if (rbTriangulo.Checked)
                {
                    if (tbIngresar1.Text == "")
                    {
                        ep1.SetError(tbIngresar1, "Completar campo BASE");
                        tbIngresar1.Focus();
                    }
                    else if (tbIngresar2.Text == "")
                    {
                        ep2.SetError(tbIngresar2, "Completar campo ALTURA");
                        tbIngresar2.Focus();
                    }
                    else if (tbIngresar3.Text == "")
                    {
                        ep3.SetError(tbIngresar3, "Completar campo LADO 1");
                        tbIngresar3.Focus();
                    }
                    else if (tbIngresar4.Text == "")
                    {
                        ep4.SetError(tbIngresar4, "Completar campo LADO 2");
                        tbIngresar4.Focus();
                    }
                    else
                    {
                        double ba = Convert.ToDouble(tbIngresar1.Text);
                        double h = Convert.ToDouble(tbIngresar2.Text);
                        double l1 = Convert.ToDouble(tbIngresar3.Text);
                        double l2 = Convert.ToDouble(tbIngresar4.Text);

                        if ((ba <= 0) || (h <= 0) || (l1 <= 0) || (l2 <= 0))
                        {
                            MessageBox.Show("Algun dato/s ingresado/s es/son incorrecto/s");
                        }
                        else
                        {
                            Triangulo NvoTriangulo = new Triangulo(ba, h, l1, l2);

                            if (ExisteFigura(NvoTriangulo))
                            {
                                MessageBox.Show("El triangulo ya existe en el arreglo");
                            }
                            else
                            {
                                ArrFiguras[Cont++] = NvoTriangulo;
                                CantTriang++;
                            }
                        }
                    }
                }
                else if (rbRectangulo.Checked)
                {
                    if (tbIngresar1.Text == "")
                    {
                        ep1.SetError(tbIngresar1, "Completar campo BASE");
                        tbIngresar1.Focus();
                    }
                    else if (tbIngresar2.Text == "")
                    {
                        ep2.SetError(tbIngresar2, "Completar campo ALTURA");
                        tbIngresar2.Focus();
                    }
                    else
                    {
                        double ba = Convert.ToDouble(tbIngresar1.Text);
                        double h = Convert.ToDouble(tbIngresar2.Text);

                        if ((ba <= 0) || (h <= 0))
                        {
                            MessageBox.Show("La base o la altura es incorrecta");
                        }
                        else
                        {
                            Rectangulo NvoRectangulo = new Rectangulo(ba, h);

                            if (ExisteFigura(NvoRectangulo))
                            {
                                MessageBox.Show("El rectangulo ya existe en el arreglo");
                            }
                            else
                            {
                                ArrFiguras[Cont++] = NvoRectangulo;
                                CantRect++;
                            }
                        }
                    }
                }

                Mostrar();
                Limpiar();
            }
        }

        private void bArea_Click(object sender, EventArgs e)
        {
            int pos = lbFiguras.SelectedIndex;

            if (pos == -1)
            {
                MessageBox.Show("Seleccione una figura de la lista");
            }
            else
            {
                MessageBox.Show("El área es: " + ArrFiguras[pos].getArea().ToString("N2"));
            }
        }

        private void bPerímetro_Click(object sender, EventArgs e)
        {
            int pos = lbFiguras.SelectedIndex;

            if (pos == -1)
            {
                MessageBox.Show("Seleccione una figura de la lista");
            }
            else
            {
                MessageBox.Show("El perímetro es: " + ArrFiguras[pos].getPerimetro().ToString("N2"));
            }
        }
        

        private void tbIngresar1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) | e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbIngresar2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) | e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbIngresar3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) | e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbIngresar4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) | e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}